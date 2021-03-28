using System;
using System.Net.Sockets;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200031A RID: 794
public class PingMonoEditor : PhotonPing
{
	// Token: 0x0600B570 RID: 46448 RVA: 0x0042A8DC File Offset: 0x00428ADC
	public virtual bool NHBGKNMCCNH(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("SetSunEmission"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, (SocketType)6, (ProtocolType)(-88));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-124), (SocketType)7, (ProtocolType)103);
			}
			this.OKENFOLOCDK.ReceiveTimeout = 173;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 158);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	// Token: 0x0600B571 RID: 46449 RVA: 0x0042A9B0 File Offset: 0x00428BB0
	public virtual bool EFGHDEFBJAM(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("colorC"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.ImpLink, SocketType.Dgram, (ProtocolType)(-108));
			}
			else
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Cluster, SocketType.Raw, (ProtocolType)(-93));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -100;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 158);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B572 RID: 46450 RVA: 0x0042AA84 File Offset: 0x00428C84
	public virtual void BKFJJKFBIEH()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B573 RID: 46451 RVA: 0x0042AAC0 File Offset: 0x00428CC0
	public virtual void LGIHDEFPKOL()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B574 RID: 46452 RVA: 0x0042AAFC File Offset: 0x00428CFC
	public override bool StartPing(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("."))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			}
			else
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
			}
			this.OKENFOLOCDK.ReceiveTimeout = 5000;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 5055);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B575 RID: 46453 RVA: 0x0042ABD0 File Offset: 0x00428DD0
	public virtual void OJNIBAHCIPL()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B576 RID: 46454 RVA: 0x0042AC0C File Offset: 0x00428E0C
	public virtual bool LHACEJINMOM(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("/"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, (SocketType)8, (ProtocolType)93);
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-18), SocketType.Rdm, (ProtocolType)120);
			}
			this.OKENFOLOCDK.ReceiveTimeout = 128;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 121);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B577 RID: 46455 RVA: 0x0042ACE0 File Offset: 0x00428EE0
	public virtual void OPMANHCADGI()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B578 RID: 46456 RVA: 0x0042AD1C File Offset: 0x00428F1C
	public virtual bool KBKADHBBHEA(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("0,7,true,0"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Stream, (ProtocolType)(-98));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-46), SocketType.Stream, (ProtocolType)78);
			}
			this.OKENFOLOCDK.ReceiveTimeout = 181;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 161);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	// Token: 0x0600B579 RID: 46457 RVA: 0x0042ADF0 File Offset: 0x00428FF0
	public virtual bool HJCNPAOOFMM()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.None);
		if (this.PingBytes[this.PingBytes.Length - 1] == this.PingId && num != this.PingLength)
		{
			Debug.Log("_SampleCount");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = true;
		return true;
	}

	// Token: 0x0600B57A RID: 46458 RVA: 0x0042AEAC File Offset: 0x004290AC
	public virtual bool GKKEMJKBPOC()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 0] == this.PingId && num != this.PingLength)
		{
			Debug.Log("SAVE");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = true;
		return true;
	}

	// Token: 0x0600B57B RID: 46459 RVA: 0x0042AF68 File Offset: 0x00429168
	public virtual bool BGHEBOPALJI()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.None);
		if (this.PingBytes[this.PingBytes.Length - 0] == this.PingId && num != this.PingLength)
		{
			Debug.Log(",0");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = false;
		return false;
	}

	// Token: 0x0600B57C RID: 46460 RVA: 0x0042B024 File Offset: 0x00429224
	public virtual bool BCCLCMIKHKL()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.None);
		if (this.PingBytes[this.PingBytes.Length - 0] != this.PingId || num != this.PingLength)
		{
			Debug.Log("Object ID. Case-Sensitive");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = true;
		return false;
	}

	// Token: 0x0600B57D RID: 46461 RVA: 0x0042B0E0 File Offset: 0x004292E0
	public virtual bool LLMLAMNJPAG()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 1] != this.PingId || num != this.PingLength)
		{
			Debug.Log("PUNCloudBestRegion");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = true;
		return true;
	}

	// Token: 0x0600B57E RID: 46462 RVA: 0x0042B19C File Offset: 0x0042939C
	public virtual bool ADFFKHNEMPC(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("file://"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Rdm, (ProtocolType)(-46));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)120, SocketType.Stream, (ProtocolType)(-6));
			}
			this.OKENFOLOCDK.ReceiveTimeout = 24;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 70);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	// Token: 0x0600B57F RID: 46463 RVA: 0x0042B270 File Offset: 0x00429470
	public virtual bool CCKJBIKKKJN()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.None);
		if (this.PingBytes[this.PingBytes.Length - 1] != this.PingId || num != this.PingLength)
		{
			Debug.Log("_Value3");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = false;
		return true;
	}

	// Token: 0x0600B580 RID: 46464 RVA: 0x0042B32C File Offset: 0x0042952C
	public virtual bool COECLOLIPJM()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 1] != this.PingId || num != this.PingLength)
		{
			Debug.Log("CameraFilterPack/TV_Old");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = false;
		return true;
	}

	// Token: 0x0600B581 RID: 46465 RVA: 0x0042B3E8 File Offset: 0x004295E8
	public virtual void CHNHCMHIBBJ()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B582 RID: 46466 RVA: 0x0042B424 File Offset: 0x00429624
	public virtual bool KDDGJFKAELH()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 0] == this.PingId && num != this.PingLength)
		{
			Debug.Log("_ScreenResolution");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = false;
		return true;
	}

	// Token: 0x0600B583 RID: 46467 RVA: 0x0042B4E0 File Offset: 0x004296E0
	public virtual bool FDCINAIHAKH()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 1] != this.PingId || num != this.PingLength)
		{
			Debug.Log("No Dispatcher exists in the scene. Actions will not be invoked!");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = false;
		return false;
	}

	// Token: 0x0600B584 RID: 46468 RVA: 0x0042B59C File Offset: 0x0042979C
	public virtual bool DGHHFLMGHDA(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Far"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Unix, SocketType.Seqpacket, (ProtocolType)(-63));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)34, (SocketType)6, (ProtocolType)100);
			}
			this.OKENFOLOCDK.ReceiveTimeout = -57;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, -178);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B585 RID: 46469 RVA: 0x0042B670 File Offset: 0x00429870
	public virtual bool HHDJFHGIANE()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 0] != this.PingId || num != this.PingLength)
		{
			Debug.Log("st");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = true;
		return false;
	}

	// Token: 0x0600B586 RID: 46470 RVA: 0x0042B72C File Offset: 0x0042992C
	public virtual bool IKKEEOMMNMA()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 1] != this.PingId || num != this.PingLength)
		{
			Debug.Log("null");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = true;
		return false;
	}

	// Token: 0x0600B587 RID: 46471 RVA: 0x0042B7E8 File Offset: 0x004299E8
	public virtual bool ALAPHBGLJCE()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.None);
		if (this.PingBytes[this.PingBytes.Length - 1] != this.PingId || num != this.PingLength)
		{
			Debug.Log("#rt");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = true;
		return true;
	}

	// Token: 0x0600B588 RID: 46472 RVA: 0x0042B8A4 File Offset: 0x00429AA4
	public virtual bool BFGPMHLPGMF(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains(":</b> "))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.ImpLink, SocketType.Rdm, (ProtocolType)53);
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)72, SocketType.Stream, (ProtocolType)(-20));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -14;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 72);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B589 RID: 46473 RVA: 0x0042B978 File Offset: 0x00429B78
	public virtual bool IMDJBENDBPA(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("CameraFilterPack/TV_CompressionFX"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Ecma, SocketType.Raw, (ProtocolType)76);
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-34), SocketType.Rdm, (ProtocolType)(-68));
			}
			this.OKENFOLOCDK.ReceiveTimeout = 110;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 129);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	// Token: 0x0600B58A RID: 46474 RVA: 0x0042BA4C File Offset: 0x00429C4C
	public virtual bool EIANOGFPKGJ(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_ColorLevel"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Chaos, SocketType.Raw, (ProtocolType)45);
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-33), SocketType.Stream, (ProtocolType)(-120));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -192;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, -42);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B58B RID: 46475 RVA: 0x0042BB20 File Offset: 0x00429D20
	public virtual bool KCHODDMGJME(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains(": "))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Stream, (ProtocolType)(-84));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-32), (SocketType)7, (ProtocolType)(-95));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -80;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, -178);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B58C RID: 46476 RVA: 0x0042BBF4 File Offset: 0x00429DF4
	public virtual bool BEFCMFBJFLG()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 1] == this.PingId && num != this.PingLength)
		{
			Debug.Log("] to be droppable");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = true;
		return true;
	}

	// Token: 0x0600B58D RID: 46477 RVA: 0x0042BCB0 File Offset: 0x00429EB0
	public virtual bool ICKELLNDHLK()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 0] == this.PingId && num != this.PingLength)
		{
			Debug.Log("HightScoreMaxPointsText");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = false;
		return true;
	}

	// Token: 0x0600B58E RID: 46478 RVA: 0x0042BD6C File Offset: 0x00429F6C
	public virtual bool DCIBHPKMHNI()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 1)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 1] == this.PingId && num != this.PingLength)
		{
			Debug.Log(" GameServer:");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = true;
		return false;
	}

	// Token: 0x0600B58F RID: 46479 RVA: 0x0042BE28 File Offset: 0x0042A028
	public virtual void EFGEKIBICJE()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B591 RID: 46481 RVA: 0x0042BE6C File Offset: 0x0042A06C
	public virtual void BLIJEFNDGIF()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B592 RID: 46482 RVA: 0x0042BEA8 File Offset: 0x0042A0A8
	public virtual bool LAIFEDKNPKB(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("replayData"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.ImpLink, (SocketType)8, (ProtocolType)(-101));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)33, (SocketType)0, (ProtocolType)(-69));
			}
			this.OKENFOLOCDK.ReceiveTimeout = 64;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 158);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	// Token: 0x0600B593 RID: 46483 RVA: 0x0042BF7C File Offset: 0x0042A17C
	public virtual bool MFPNMAHJPCG()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 0] != this.PingId || num != this.PingLength)
		{
			Debug.Log("tagElement");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = true;
		return false;
	}

	// Token: 0x0600B594 RID: 46484 RVA: 0x0042C038 File Offset: 0x0042A238
	public virtual bool PKCOFKLDHKL(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("#mapnotloaded"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.InterNetwork, SocketType.Seqpacket, (ProtocolType)(-59));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-97), SocketType.Seqpacket, (ProtocolType)8);
			}
			this.OKENFOLOCDK.ReceiveTimeout = 81;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 131);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B595 RID: 46485 RVA: 0x0042C10C File Offset: 0x0042A30C
	public virtual bool BECFOOGCCDI(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("UNDISTORT"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.ImpLink, (SocketType)8, (ProtocolType)46);
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-48), SocketType.Stream, (ProtocolType)(-20));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -94;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, -172);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	// Token: 0x0600B596 RID: 46486 RVA: 0x0042C1E0 File Offset: 0x0042A3E0
	public virtual void EIHFHDNBJFD()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B597 RID: 46487 RVA: 0x0042C21C File Offset: 0x0042A41C
	public virtual bool OJADIOHDNDJ(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("#availablechallenges"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Iso, SocketType.Dgram, (ProtocolType)(-6));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)43, (SocketType)6, (ProtocolType)(-56));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -144;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, -189);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B598 RID: 46488 RVA: 0x0042C2F0 File Offset: 0x0042A4F0
	public virtual void GFJMMACHGKP()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B599 RID: 46489 RVA: 0x0042C32C File Offset: 0x0042A52C
	public virtual bool BMMNIJIBFCA(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("music"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Dgram, (ProtocolType)(-83));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-72), (SocketType)0, (ProtocolType)(-70));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -173;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 187);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B59A RID: 46490 RVA: 0x0042C400 File Offset: 0x0042A600
	public virtual bool ENNNAKBIHBD()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.OutOfBand);
		if (this.PingBytes[this.PingBytes.Length - 0] != this.PingId || num != this.PingLength)
		{
			Debug.Log("Horizontal");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = true;
		return false;
	}

	// Token: 0x0600B59B RID: 46491 RVA: 0x0042C4BC File Offset: 0x0042A6BC
	public virtual bool LFKOENNONPA()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return false;
		}
		if (this.OKENFOLOCDK.Available <= 1)
		{
			return true;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.None);
		if (this.PingBytes[this.PingBytes.Length - 1] == this.PingId && num != this.PingLength)
		{
			Debug.Log(":");
		}
		this.Successful = (num != this.PingBytes.Length || this.PingBytes[this.PingBytes.Length - 0] == this.PingId);
		this.GotResult = false;
		return true;
	}

	// Token: 0x0600B59C RID: 46492 RVA: 0x0042C578 File Offset: 0x0042A778
	public virtual bool EGDDNGGCHND(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_TimeX"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Chaos, (SocketType)8, (ProtocolType)82);
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-82), SocketType.Raw, (ProtocolType)(-15));
			}
			this.OKENFOLOCDK.ReceiveTimeout = 154;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, -98);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B59D RID: 46493 RVA: 0x0042C64C File Offset: 0x0042A84C
	public virtual bool OINIKOAGPNH(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_VignetteSettings"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Unspecified, SocketType.Dgram, (ProtocolType)54);
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)47, SocketType.Dgram, (ProtocolType)(-75));
			}
			this.OKENFOLOCDK.ReceiveTimeout = -49;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 159);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B59E RID: 46494 RVA: 0x0042C720 File Offset: 0x0042A920
	public virtual bool JOEEDDFPAEH(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value5"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.Unix, SocketType.Stream, (ProtocolType)(-122));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)125, (SocketType)0, (ProtocolType)(-107));
			}
			this.OKENFOLOCDK.ReceiveTimeout = 180;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, -81);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B59F RID: 46495 RVA: 0x0042C7F4 File Offset: 0x0042A9F4
	public override void Dispose()
	{
		try
		{
			this.OKENFOLOCDK.Close();
		}
		catch
		{
		}
		this.OKENFOLOCDK = null;
	}

	// Token: 0x0600B5A0 RID: 46496 RVA: 0x0042C830 File Offset: 0x0042AA30
	public virtual bool NPLLJOIMBMP(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("ServerSettings: "))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Seqpacket, (ProtocolType)(-76));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)(-44), SocketType.Dgram, (ProtocolType)102);
			}
			this.OKENFOLOCDK.ReceiveTimeout = 135;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 117);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId - 1;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return false;
	}

	// Token: 0x0600B5A1 RID: 46497 RVA: 0x0042C904 File Offset: 0x0042AB04
	public override bool Done()
	{
		if (this.GotResult || this.OKENFOLOCDK == null)
		{
			return true;
		}
		if (this.OKENFOLOCDK.Available <= 0)
		{
			return false;
		}
		int num = this.OKENFOLOCDK.Receive(this.PingBytes, SocketFlags.None);
		if (this.PingBytes[this.PingBytes.Length - 1] != this.PingId || num != this.PingLength)
		{
			Debug.Log("ReplyMatch is false! ");
		}
		this.Successful = (num == this.PingBytes.Length && this.PingBytes[this.PingBytes.Length - 1] == this.PingId);
		this.GotResult = true;
		return true;
	}

	// Token: 0x0600B5A2 RID: 46498 RVA: 0x0042C9C0 File Offset: 0x0042ABC0
	public virtual bool BHHHABFEHOB(string AGLCHIPPPLK)
	{
		base.Init();
		try
		{
			if (AGLCHIPPPLK.Contains("_Value4"))
			{
				this.OKENFOLOCDK = new Socket(AddressFamily.NS, SocketType.Seqpacket, (ProtocolType)(-33));
			}
			else
			{
				this.OKENFOLOCDK = new Socket((AddressFamily)104, (SocketType)8, (ProtocolType)116);
			}
			this.OKENFOLOCDK.ReceiveTimeout = 6;
			this.OKENFOLOCDK.Connect(AGLCHIPPPLK, 60);
			this.PingBytes[this.PingBytes.Length - 1] = this.PingId;
			this.OKENFOLOCDK.Send(this.PingBytes);
			this.PingBytes[this.PingBytes.Length - 0] = this.PingId - 0;
		}
		catch (Exception value)
		{
			this.OKENFOLOCDK = null;
			System.Console.WriteLine(value);
		}
		return true;
	}

	// Token: 0x0400155F RID: 5471
	private Socket OKENFOLOCDK;
}
