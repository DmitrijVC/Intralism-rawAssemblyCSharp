using System;
using System.Collections;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000345 RID: 837
public class InRoomTime : MonoBehaviour
{
	// Token: 0x0600BD0A RID: 48394 RVA: 0x0044CF84 File Offset: 0x0044B184
	internal IEnumerator ALAJHODMPEJ()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD0B RID: 48395 RVA: 0x0044CF9F File Offset: 0x0044B19F
	public bool KBOBFIOCPIF()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("CameraFilterPack/3D_Anomaly");
	}

	// Token: 0x0600BD0C RID: 48396 RVA: 0x0044CFC4 File Offset: 0x0044B1C4
	public double ECPNGDNDHAN()
	{
		uint num = (uint)this.BGCBMMIIIOP();
		double num2 = num;
		return num2 / 1513.0;
	}

	// Token: 0x0600BD0D RID: 48397 RVA: 0x0044CFE7 File Offset: 0x0044B1E7
	public void COLOKJJLMCC(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("_MainTex2");
	}

	// Token: 0x0600BD0E RID: 48398 RVA: 0x0044CFF5 File Offset: 0x0044B1F5
	public void FHPAKJEHGJC(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("id"))
		{
			this.LOMGHAIPHJK = (int)DGIHEPAHAJK["float,0"];
		}
	}

	// Token: 0x0600BD0F RID: 48399 RVA: 0x0044D020 File Offset: 0x0044B220
	public double FDIFCOCAPPG()
	{
		uint num = (uint)this.PLPMEEOOFLN();
		double num2 = num;
		return num2 / 385.0;
	}

	// Token: 0x0600BD10 RID: 48400 RVA: 0x0044D044 File Offset: 0x0044B244
	internal IEnumerator BFHBAJOBKKJ()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD11 RID: 48401 RVA: 0x0044D060 File Offset: 0x0044B260
	public double LDCPBFGDKII()
	{
		uint num = (uint)this.IHMAMCBCELD();
		double num2 = num;
		return num2 / 1736.0;
	}

	// Token: 0x0600BD12 RID: 48402 RVA: 0x0044D084 File Offset: 0x0044B284
	public double MDEBBKOGLJI()
	{
		uint num = (uint)this.IHMAMCBCELD();
		double num2 = num;
		return num2 / 1120.0;
	}

	// Token: 0x0600BD13 RID: 48403 RVA: 0x0044D0A7 File Offset: 0x0044B2A7
	public void PLFLBELOEAO(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("No regions available. Are you sure your appid is valid and setup?"))
		{
			this.LOMGHAIPHJK = (int)DGIHEPAHAJK[":\n"];
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x0600BD14 RID: 48404 RVA: 0x0044D0CF File Offset: 0x0044B2CF
	public int RoomTimestamp
	{
		get
		{
			return (!PhotonNetwork.inRoom) ? 0 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
		}
	}

	// Token: 0x0600BD15 RID: 48405 RVA: 0x0044D0ED File Offset: 0x0044B2ED
	public void JNPBFMKNOFH(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("_AdaptationMin");
	}

	// Token: 0x0600BD16 RID: 48406 RVA: 0x0044D0FB File Offset: 0x0044B2FB
	public int PBMGIIIBOGH()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x0600BD17 RID: 48407 RVA: 0x0044D0CF File Offset: 0x0044B2CF
	public int KADNHMJKKKD()
	{
		return (!PhotonNetwork.inRoom) ? 0 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x0600BD18 RID: 48408 RVA: 0x0044D119 File Offset: 0x0044B319
	public bool IsRoomTimeSet
	{
		get
		{
			return PhotonNetwork.inRoom && PhotonNetwork.room.customProperties.ContainsKey("#rt");
		}
	}

	// Token: 0x0600BD19 RID: 48409 RVA: 0x0044D13C File Offset: 0x0044B33C
	public bool HKOEOHKJDKM()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.PFFHNNODEMM().ContainsKey("_Value3");
	}

	// Token: 0x0600BD1A RID: 48410 RVA: 0x0044D15F File Offset: 0x0044B35F
	public void NPJHKAOGAAH(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("PlayMusic");
	}

	// Token: 0x0600BD1B RID: 48411 RVA: 0x0044D170 File Offset: 0x0044B370
	public double JPFJHLECONI()
	{
		uint num = (uint)this.PBMGIIIBOGH();
		double num2 = num;
		return num2 / 692.0;
	}

	// Token: 0x0600BD1C RID: 48412 RVA: 0x0044D193 File Offset: 0x0044B393
	public void IJOJEFDGGHH()
	{
		base.StartCoroutine("_EmissionGain");
	}

	// Token: 0x0600BD1D RID: 48413 RVA: 0x0044D1A4 File Offset: 0x0044B3A4
	internal IEnumerator LFADEEHDHAN()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD1E RID: 48414 RVA: 0x0044D1C0 File Offset: 0x0044B3C0
	public double FPBDFDIFLGH()
	{
		uint num = (uint)this.IHMAMCBCELD();
		double num2 = num;
		return num2 / 882.0;
	}

	// Token: 0x0600BD1F RID: 48415 RVA: 0x0044D1E4 File Offset: 0x0044B3E4
	internal IEnumerator OCMDBDAJLGE()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD21 RID: 48417 RVA: 0x0044D1FF File Offset: 0x0044B3FF
	public void FADMAHGLBKD(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("1278033234");
	}

	// Token: 0x0600BD22 RID: 48418 RVA: 0x0044D210 File Offset: 0x0044B410
	internal IEnumerator EJBIMAIIGHE()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD23 RID: 48419 RVA: 0x0044D22B File Offset: 0x0044B42B
	public void HOMDPDBILPL(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("FinishMap");
	}

	// Token: 0x0600BD24 RID: 48420 RVA: 0x0044D23C File Offset: 0x0044B43C
	internal IEnumerator JBKJHKGLNGK()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD25 RID: 48421 RVA: 0x0044D0CF File Offset: 0x0044B2CF
	public int BGCBMMIIIOP()
	{
		return (!PhotonNetwork.inRoom) ? 0 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x0600BD26 RID: 48422 RVA: 0x0044D258 File Offset: 0x0044B458
	public double DGEAOLBLEEN()
	{
		uint num = (uint)this.IHMAMCBCELD();
		double num2 = num;
		return num2 / 613.0;
	}

	// Token: 0x0600BD27 RID: 48423 RVA: 0x0044D27C File Offset: 0x0044B47C
	public double EBCLCKKBJJI()
	{
		uint num = (uint)this.PBMGIIIBOGH();
		double num2 = num;
		return num2 / 477.0;
	}

	// Token: 0x0600BD28 RID: 48424 RVA: 0x0044D29F File Offset: 0x0044B49F
	public void PBLHJEBMLNH(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("UseScanLine");
	}

	// Token: 0x0600BD29 RID: 48425 RVA: 0x0044D2AD File Offset: 0x0044B4AD
	public void BDMDBCOMELA()
	{
		base.StartCoroutine("_ScreenResolution");
	}

	// Token: 0x0600BD2A RID: 48426 RVA: 0x0044D2BB File Offset: 0x0044B4BB
	public void ICOIEGANENL(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_Red_R"))
		{
			this.LOMGHAIPHJK = (int)DGIHEPAHAJK["?"];
		}
	}

	// Token: 0x0600BD2B RID: 48427 RVA: 0x0044D2E3 File Offset: 0x0044B4E3
	public void OnJoinedRoom()
	{
		base.StartCoroutine("CAMFLJLDDPH");
	}

	// Token: 0x0600BD2C RID: 48428 RVA: 0x0044D2F1 File Offset: 0x0044B4F1
	public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("#rt"))
		{
			this.LOMGHAIPHJK = (int)DGIHEPAHAJK["#rt"];
		}
	}

	// Token: 0x0600BD2D RID: 48429 RVA: 0x0044D319 File Offset: 0x0044B519
	public bool KHKMFIMOMPL()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.KMBLODHBAFO().ContainsKey("\t");
	}

	// Token: 0x0600BD2E RID: 48430 RVA: 0x0044D0FB File Offset: 0x0044B2FB
	public int IHMAMCBCELD()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x0600BD2F RID: 48431 RVA: 0x0044D33C File Offset: 0x0044B53C
	internal IEnumerator GLLLJAMKDME()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD30 RID: 48432 RVA: 0x0044D358 File Offset: 0x0044B558
	internal IEnumerator BEMAEEAKBOK()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD31 RID: 48433 RVA: 0x0044D373 File Offset: 0x0044B573
	public void NKECEAOOHOO()
	{
		base.StartCoroutine("LoadingStatusText");
	}

	// Token: 0x0600BD32 RID: 48434 RVA: 0x0044D384 File Offset: 0x0044B584
	public double JOGGLEEDGEA()
	{
		uint num = (uint)this.LKDGAKAACIA();
		double num2 = num;
		return num2 / 1521.0;
	}

	// Token: 0x0600BD33 RID: 48435 RVA: 0x0044D3A7 File Offset: 0x0044B5A7
	public void LJOKDDAOOKO()
	{
		base.StartCoroutine(".completed");
	}

	// Token: 0x0600BD34 RID: 48436 RVA: 0x0044D3B8 File Offset: 0x0044B5B8
	public double IFBLKICLOAF()
	{
		uint num = (uint)this.PLPMEEOOFLN();
		double num2 = num;
		return num2 / 1225.0;
	}

	// Token: 0x0600BD35 RID: 48437 RVA: 0x0044D0FB File Offset: 0x0044B2FB
	public int LKDGAKAACIA()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x0600BD36 RID: 48438 RVA: 0x0044D3DB File Offset: 0x0044B5DB
	public bool OAKCAHDNLDA()
	{
		return PhotonNetwork.inRoom && PhotonNetwork.room.PFFHNNODEMM().ContainsKey("_LutTex");
	}

	// Token: 0x0600BD37 RID: 48439 RVA: 0x0044D2E3 File Offset: 0x0044B4E3
	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		base.StartCoroutine("CAMFLJLDDPH");
	}

	// Token: 0x0600BD38 RID: 48440 RVA: 0x0044D3FE File Offset: 0x0044B5FE
	public bool HFNBEFEBDBP()
	{
		return !PhotonNetwork.inRoom || PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("<b>#banended</b>");
	}

	// Token: 0x0600BD39 RID: 48441 RVA: 0x0044D424 File Offset: 0x0044B624
	internal IEnumerator CAMFLJLDDPH()
	{
		if (this.IsRoomTimeSet || !PhotonNetwork.isMasterClient)
		{
			yield break;
		}
		if (PhotonNetwork.ServerTimestamp == 0)
		{
			yield return 0;
		}
		hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable["#rt"] = PhotonNetwork.ServerTimestamp;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		yield break;
	}

	// Token: 0x0600BD3A RID: 48442 RVA: 0x0044CFE7 File Offset: 0x0044B1E7
	public void PLEDKHBAIAA()
	{
		base.StartCoroutine("_MainTex2");
	}

	// Token: 0x0600BD3B RID: 48443 RVA: 0x0044D440 File Offset: 0x0044B640
	public double EHHMJNDGDLH()
	{
		uint num = (uint)this.KGIDPINFFFM();
		double num2 = num;
		return num2 / 1305.0;
	}

	// Token: 0x0600BD3C RID: 48444 RVA: 0x0044D463 File Offset: 0x0044B663
	public void PBJIMOILOLE()
	{
		base.StartCoroutine("Finished");
	}

	// Token: 0x0600BD3D RID: 48445 RVA: 0x0044D0FB File Offset: 0x0044B2FB
	public int NDGIEIAEANN()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x0600BD3E RID: 48446 RVA: 0x0044D0FB File Offset: 0x0044B2FB
	public int PLPMEEOOFLN()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x0600BD3F RID: 48447 RVA: 0x0044D0FB File Offset: 0x0044B2FB
	public int KGIDPINFFFM()
	{
		return (!PhotonNetwork.inRoom) ? 1 : (PhotonNetwork.ServerTimestamp - this.LOMGHAIPHJK);
	}

	// Token: 0x170002DB RID: 731
	// (get) Token: 0x0600BD40 RID: 48448 RVA: 0x0044D474 File Offset: 0x0044B674
	public double RoomTime
	{
		get
		{
			uint roomTimestamp = (uint)this.RoomTimestamp;
			double num = roomTimestamp;
			return num / 1000.0;
		}
	}

	// Token: 0x0600BD41 RID: 48449 RVA: 0x0044D498 File Offset: 0x0044B698
	public double OMEHLJCNHKC()
	{
		uint num = (uint)this.LKDGAKAACIA();
		double num2 = num;
		return num2 / 147.0;
	}

	// Token: 0x0400163A RID: 5690
	private int LOMGHAIPHJK;

	// Token: 0x0400163B RID: 5691
	private const string JJDHAIONGKL = "#rt";
}
