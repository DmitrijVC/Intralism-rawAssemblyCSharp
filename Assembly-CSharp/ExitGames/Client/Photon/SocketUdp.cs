using System;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Threading;

namespace ExitGames.Client.Photon
{
	// Token: 0x02000323 RID: 803
	internal class SocketUdp : IPhotonSocket, IDisposable
	{
		// Token: 0x0600B8AF RID: 47279 RVA: 0x00437D7C File Offset: 0x00435F7C
		public SocketUdp(PeerBase npeer) : base(npeer)
		{
			if (base.ReportDebugOfLevel(DebugLevel.ALL))
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "CSharpSocket: UDP, Unity3d.");
			}
			this.PollReceive = false;
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x00437DB4 File Offset: 0x00435FB4
		public void Dispose()
		{
			base.State = PhotonSocketState.Disconnecting;
			if (this.sock != null)
			{
				try
				{
					if (this.sock.Connected)
					{
						this.sock.Close();
					}
				}
				catch (Exception arg)
				{
					base.EnqueueDebugReturn(DebugLevel.INFO, "Exception in Dispose(): " + arg);
				}
			}
			this.sock = null;
			base.State = PhotonSocketState.Disconnected;
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x00437E2C File Offset: 0x0043602C
		public override bool Connect()
		{
			object obj = this.syncer;
			bool result;
			lock (obj)
			{
				if (!base.Connect())
				{
					result = false;
				}
				else
				{
					base.State = PhotonSocketState.Connecting;
					new Thread(new ThreadStart(this.DnsAndConnect))
					{
						Name = "photon dns thread",
						IsBackground = true
					}.Start();
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x00437EAC File Offset: 0x004360AC
		public override bool Disconnect()
		{
			if (base.ReportDebugOfLevel(DebugLevel.INFO))
			{
				base.EnqueueDebugReturn(DebugLevel.INFO, "CSharpSocket.Disconnect()");
			}
			base.State = PhotonSocketState.Disconnecting;
			object obj = this.syncer;
			lock (obj)
			{
				if (this.sock != null)
				{
					try
					{
						this.sock.Close();
					}
					catch (Exception arg)
					{
						base.EnqueueDebugReturn(DebugLevel.INFO, "Exception in Disconnect(): " + arg);
					}
					this.sock = null;
				}
			}
			base.State = PhotonSocketState.Disconnected;
			return true;
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x00437F50 File Offset: 0x00436150
		public override PhotonSocketError Send(byte[] data, int length)
		{
			object obj = this.syncer;
			lock (obj)
			{
				if (this.sock == null || !this.sock.Connected)
				{
					return PhotonSocketError.Skipped;
				}
				try
				{
					this.sock.Send(data, 0, length, SocketFlags.None);
				}
				catch (Exception ex)
				{
					if (base.ReportDebugOfLevel(DebugLevel.ERROR))
					{
						base.EnqueueDebugReturn(DebugLevel.ERROR, "Cannot send to: " + base.ServerAddress + ". " + ex.Message);
					}
					return PhotonSocketError.Exception;
				}
			}
			return PhotonSocketError.Success;
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x00438004 File Offset: 0x00436204
		public override PhotonSocketError Receive(out byte[] data)
		{
			data = null;
			return PhotonSocketError.NoData;
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x0043800C File Offset: 0x0043620C
		internal void DnsAndConnect()
		{
			IPAddress ipaddress = null;
			try
			{
				ipaddress = IPhotonSocket.GetIpAddress(base.ServerAddress);
				if (ipaddress == null)
				{
					throw new ArgumentException("Invalid IPAddress. Address: " + base.ServerAddress);
				}
				object obj = this.syncer;
				lock (obj)
				{
					if (base.State == PhotonSocketState.Disconnecting || base.State == PhotonSocketState.Disconnected)
					{
						return;
					}
					this.sock = new Socket(ipaddress.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
					this.sock.Connect(ipaddress, base.ServerPort);
					base.AddressResolvedAsIpv6 = base.IsIpv6SimpleCheck(ipaddress);
					base.State = PhotonSocketState.Connected;
					this.peerBase.OnConnect();
				}
			}
			catch (SecurityException ex)
			{
				if (base.ReportDebugOfLevel(DebugLevel.ERROR))
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, string.Concat(new string[]
					{
						"Connect() to '",
						base.ServerAddress,
						"' (",
						(ipaddress != null) ? ipaddress.AddressFamily.ToString() : string.Empty,
						") failed: ",
						ex.ToString()
					}));
				}
				base.HandleException(StatusCode.SecurityExceptionOnConnect);
				return;
			}
			catch (Exception ex2)
			{
				if (base.ReportDebugOfLevel(DebugLevel.ERROR))
				{
					base.Listener.DebugReturn(DebugLevel.ERROR, string.Concat(new string[]
					{
						"Connect() to '",
						base.ServerAddress,
						"' (",
						(ipaddress != null) ? ipaddress.AddressFamily.ToString() : string.Empty,
						") failed: ",
						ex2.ToString()
					}));
				}
				base.HandleException(StatusCode.ExceptionOnConnect);
				return;
			}
			new Thread(new ThreadStart(this.ReceiveLoop))
			{
				Name = "photon receive thread",
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x00438228 File Offset: 0x00436428
		public void ReceiveLoop()
		{
			byte[] array = new byte[base.MTU];
			while (base.State == PhotonSocketState.Connected)
			{
				try
				{
					int length = this.sock.Receive(array);
					base.HandleReceivedDatagram(array, length, true);
				}
				catch (Exception ex)
				{
					if (base.State != PhotonSocketState.Disconnecting && base.State != PhotonSocketState.Disconnected)
					{
						if (base.ReportDebugOfLevel(DebugLevel.ERROR))
						{
							base.EnqueueDebugReturn(DebugLevel.ERROR, string.Concat(new object[]
							{
								"Receive issue. State: ",
								base.State,
								". Server: '",
								base.ServerAddress,
								"' Exception: ",
								ex
							}));
						}
						base.HandleException(StatusCode.ExceptionOnReceive);
					}
				}
			}
			this.Disconnect();
		}

		// Token: 0x0400159D RID: 5533
		private Socket sock;

		// Token: 0x0400159E RID: 5534
		private readonly object syncer = new object();
	}
}
