using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x02000370 RID: 880
	public class ChatPeer : PhotonPeer
	{
		// Token: 0x0600C332 RID: 49970 RVA: 0x0046F6BC File Offset: 0x0046D8BC
		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol) : base(listener, protocol)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600C333 RID: 49971 RVA: 0x0046F6C6 File Offset: 0x0046D8C6
		public string NameServerAddress
		{
			get
			{
				return this.GetNameServerAddress();
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600C334 RID: 49972 RVA: 0x003FD546 File Offset: 0x003FB746
		internal virtual bool IsProtocolSecure
		{
			get
			{
				return base.UsedProtocol == ConnectionProtocol.WebSocketSecure;
			}
		}

		// Token: 0x0600C335 RID: 49973 RVA: 0x0046F6D0 File Offset: 0x0046D8D0
		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
			Type type = Type.GetType("ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp", false);
			type = (type ?? Type.GetType("ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp-firstpass", false));
			type = (type ?? Type.GetType("ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp", false));
			type = (type ?? Type.GetType("ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass", false));
			if (type != null)
			{
				this.SocketImplementationConfig[ConnectionProtocol.WebSocket] = type;
				this.SocketImplementationConfig[ConnectionProtocol.WebSocketSecure] = type;
			}
		}

		// Token: 0x0600C336 RID: 49974 RVA: 0x0046F748 File Offset: 0x0046D948
		private string GetNameServerAddress()
		{
			int num = 0;
			ChatPeer.ProtocolToNameServerPort.TryGetValue(base.TransportProtocol, out num);
			switch (base.TransportProtocol)
			{
			case ConnectionProtocol.Udp:
			case ConnectionProtocol.Tcp:
				return string.Format("{0}:{1}", "ns.exitgames.com", num);
			case ConnectionProtocol.WebSocket:
				return string.Format("ws://{0}:{1}", "ns.exitgames.com", num);
			case ConnectionProtocol.WebSocketSecure:
				return string.Format("wss://{0}:{1}", "ns.exitgames.com", num);
			}
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x0046F7DB File Offset: 0x0046D9DB
		public bool Connect()
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "Connecting to nameserver " + this.NameServerAddress);
			}
			return this.Connect(this.NameServerAddress, "NameServer");
		}

		// Token: 0x0600C338 RID: 49976 RVA: 0x0046F818 File Offset: 0x0046DA18
		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpAuthenticate()");
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			dictionary[220] = appVersion;
			dictionary[224] = appId;
			dictionary[210] = region;
			if (authValues != null)
			{
				if (!string.IsNullOrEmpty(authValues.UserId))
				{
					dictionary[225] = authValues.UserId;
				}
				if (authValues != null && authValues.AuthType != CustomAuthenticationType.None)
				{
					dictionary[217] = (byte)authValues.AuthType;
					if (!string.IsNullOrEmpty(authValues.Token))
					{
						dictionary[221] = authValues.Token;
					}
					else
					{
						if (!string.IsNullOrEmpty(authValues.AuthGetParameters))
						{
							dictionary[216] = authValues.AuthGetParameters;
						}
						if (authValues.AuthPostData != null)
						{
							dictionary[214] = authValues.AuthPostData;
						}
					}
				}
			}
			return this.OpCustom(230, dictionary, true, 0, base.IsEncryptionAvailable);
		}

		// Token: 0x040016E1 RID: 5857
		public const string NameServerHost = "ns.exitgames.com";

		// Token: 0x040016E2 RID: 5858
		public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

		// Token: 0x040016E3 RID: 5859
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort = new Dictionary<ConnectionProtocol, int>
		{
			{
				ConnectionProtocol.Udp,
				5058
			},
			{
				ConnectionProtocol.Tcp,
				4533
			},
			{
				ConnectionProtocol.WebSocket,
				9093
			},
			{
				ConnectionProtocol.WebSocketSecure,
				19093
			}
		};
	}
}
