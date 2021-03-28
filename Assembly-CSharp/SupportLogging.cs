using System;
using System.Text;
using UnityEngine;

// Token: 0x02000365 RID: 869
public class SupportLogging : MonoBehaviour
{
	// Token: 0x0600C2B5 RID: 49845 RVA: 0x0046DCA0 File Offset: 0x0046BEA0
	protected void OnApplicationPause(bool IGIHEKLJKAP)
	{
		Debug.Log(string.Concat(new object[]
		{
			"SupportLogger OnApplicationPause: ",
			IGIHEKLJKAP,
			" connected: ",
			PhotonNetwork.connected
		}));
	}

	// Token: 0x0600C2B6 RID: 49846 RVA: 0x0046DCD8 File Offset: 0x0046BED8
	public void OnJoinedLobby()
	{
		Debug.Log("SupportLogger OnJoinedLobby(" + PhotonNetwork.lobby + ").");
	}

	// Token: 0x0600C2B7 RID: 49847 RVA: 0x0046DCF3 File Offset: 0x0046BEF3
	public void LogStats()
	{
		if (this.LogTrafficStats)
		{
			Debug.Log("SupportLogger " + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	// Token: 0x0600C2B8 RID: 49848 RVA: 0x0046DD14 File Offset: 0x0046BF14
	public void ANKNFCMMJHD()
	{
		if (this.LogTrafficStats)
		{
			Debug.Log("<command>" + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	// Token: 0x0600C2B9 RID: 49849 RVA: 0x0046DD35 File Offset: 0x0046BF35
	public void OnDisconnectedFromPhoton()
	{
		Debug.Log("SupportLogger OnDisconnectedFromPhoton().");
	}

	// Token: 0x0600C2BA RID: 49850 RVA: 0x0046DD41 File Offset: 0x0046BF41
	public void AJAJOMFBEAJ()
	{
		Debug.Log("_FgOverlap");
	}

	// Token: 0x0600C2BB RID: 49851 RVA: 0x0046DD50 File Offset: 0x0046BF50
	public void OnCreatedRoom()
	{
		Debug.Log(string.Concat(new object[]
		{
			"SupportLogger OnCreatedRoom(",
			PhotonNetwork.room,
			"). ",
			PhotonNetwork.lobby,
			" GameServer:",
			PhotonNetwork.ServerAddress
		}));
	}

	// Token: 0x0600C2BC RID: 49852 RVA: 0x0046DD9D File Offset: 0x0046BF9D
	public void CNFKCKKOHFF()
	{
		base.CancelInvoke();
	}

	// Token: 0x0600C2BD RID: 49853 RVA: 0x0046DDA5 File Offset: 0x0046BFA5
	public void AGPKNOAEIPJ()
	{
		Debug.Log("0.00" + PhotonNetwork.lobby + "ResetButton");
	}

	// Token: 0x0600C2BE RID: 49854 RVA: 0x0046DDC0 File Offset: 0x0046BFC0
	protected void AMNADGKJIIP(bool IGIHEKLJKAP)
	{
		object[] array = new object[8];
		array[1] = "_Offsets";
		array[1] = IGIHEKLJKAP;
		array[5] = "...";
		array[8] = PhotonNetwork.connected;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600C2C0 RID: 49856 RVA: 0x0046DDF8 File Offset: 0x0046BFF8
	public void OnConnectedToPhoton()
	{
		Debug.Log("SupportLogger OnConnectedToPhoton().");
		this.AAMJFFJPCOC();
		if (this.LogTrafficStats)
		{
			PhotonNetwork.NetworkStatisticsEnabled = true;
		}
	}

	// Token: 0x0600C2C1 RID: 49857 RVA: 0x0046DE1B File Offset: 0x0046C01B
	public void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log("SupportLogger OnFailedToConnectToPhoton(" + BMDDEFBNHAL + ").");
		this.AAMJFFJPCOC();
	}

	// Token: 0x0600C2C2 RID: 49858 RVA: 0x0046DE3D File Offset: 0x0046C03D
	public void MIEMJDALBCF()
	{
		if (this.LogTrafficStats)
		{
			Debug.Log("_Value3" + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	// Token: 0x0600C2C3 RID: 49859 RVA: 0x00442828 File Offset: 0x00440A28
	public void EBBHDEHPHKA()
	{
		Debug.Log("_Value5");
	}

	// Token: 0x0600C2C4 RID: 49860 RVA: 0x0046DE60 File Offset: 0x0046C060
	private void AAMJFFJPCOC()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("SupportLogger Info: PUN {0}: ", "1.87");
		stringBuilder.AppendFormat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", PhotonNetwork.JNJJAMNLOHA.KAIBLIKEDHM.Substring(0, 8), PhotonNetwork.JNJJAMNLOHA.EOCFDCJNAGM, PhotonNetwork.JNJJAMNLOHA.PeerID);
		stringBuilder.AppendFormat("Server: {0}. Region: {1} ", PhotonNetwork.ServerAddress, PhotonNetwork.JNJJAMNLOHA.CloudRegion);
		stringBuilder.AppendFormat("HostType: {0} ", PhotonNetwork.PhotonServerSettings.HostType);
		Debug.Log(stringBuilder.ToString());
	}

	// Token: 0x0600C2C5 RID: 49861 RVA: 0x0046DEFB File Offset: 0x0046C0FB
	public void PFOCFDDGIDH(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log("_SunPosition" + BMDDEFBNHAL + "_DistortionSize");
		this.AAMJFFJPCOC();
	}

	// Token: 0x0600C2C6 RID: 49862 RVA: 0x0046DF1D File Offset: 0x0046C11D
	public void EAGBMGICBHE()
	{
		if (this.LogTrafficStats)
		{
			Debug.Log("_BlurVector" + PhotonNetwork.NetworkStatisticsToString());
		}
	}

	// Token: 0x0600C2C7 RID: 49863 RVA: 0x0046DF40 File Offset: 0x0046C140
	public void OnJoinedRoom()
	{
		Debug.Log(string.Concat(new object[]
		{
			"SupportLogger OnJoinedRoom(",
			PhotonNetwork.room,
			"). ",
			PhotonNetwork.lobby,
			" GameServer:",
			PhotonNetwork.ServerAddress
		}));
	}

	// Token: 0x0600C2C8 RID: 49864 RVA: 0x0046DF8D File Offset: 0x0046C18D
	public void PLBAILEKBKA()
	{
		Debug.Log("OnClick");
	}

	// Token: 0x0600C2C9 RID: 49865 RVA: 0x0046DD9D File Offset: 0x0046BF9D
	public void OnApplicationQuit()
	{
		base.CancelInvoke();
	}

	// Token: 0x0600C2CA RID: 49866 RVA: 0x0046DF99 File Offset: 0x0046C199
	public void OnLeftRoom()
	{
		Debug.Log("SupportLogger OnLeftRoom().");
	}

	// Token: 0x0600C2CB RID: 49867 RVA: 0x0046DFA5 File Offset: 0x0046C1A5
	public void Start()
	{
		if (this.LogTrafficStats)
		{
			base.InvokeRepeating("LogStats", 10f, 10f);
		}
	}

	// Token: 0x0600C2CC RID: 49868 RVA: 0x0046DFC7 File Offset: 0x0046C1C7
	public void HJDPPMOGLOH()
	{
		Debug.Log(" evLeave: ");
	}

	// Token: 0x0600C2CD RID: 49869 RVA: 0x0046DFD3 File Offset: 0x0046C1D3
	public void PHMKMCEHNEH(DisconnectCause BMDDEFBNHAL)
	{
		Debug.Log(" - PUBLISHED #" + BMDDEFBNHAL + "_AlphaHexa");
		this.AAMJFFJPCOC();
	}

	// Token: 0x0400168B RID: 5771
	public bool LogTrafficStats;
}
