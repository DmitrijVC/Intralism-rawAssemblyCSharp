using System;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000344 RID: 836
public class InRoomRoundTimer : MonoBehaviour
{
	// Token: 0x0600BCC9 RID: 48329 RVA: 0x0044BC88 File Offset: 0x00449E88
	public void PELNCDEODGD()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.JDKOEAMABCK();
		}
		else
		{
			Debug.Log("<b>Time</b>:" + PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("[DiscordController] Error {0}: {1}"));
		}
	}

	// Token: 0x0600BCCA RID: 48330 RVA: 0x0044BCC7 File Offset: 0x00449EC7
	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.customProperties.ContainsKey("st"))
		{
			Debug.Log("The new master starts a new round, cause we didn't start yet.");
			this.AEMCMOBKOJK();
		}
	}

	// Token: 0x0600BCCB RID: 48331 RVA: 0x0044BCF2 File Offset: 0x00449EF2
	private void LLJLDLLNFBH()
	{
		if (this.DBHJOONLNJE)
		{
			this.JDKOEAMABCK();
		}
	}

	// Token: 0x0600BCCC RID: 48332 RVA: 0x0044BD08 File Offset: 0x00449F08
	private void AEMCMOBKOJK()
	{
		if (PhotonNetwork.time < 9.9999997473787516E-05)
		{
			this.DBHJOONLNJE = true;
			return;
		}
		this.DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["st"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0600BCCD RID: 48333 RVA: 0x0044BD5F File Offset: 0x00449F5F
	public void LKLDBEBLMBI(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("_Size"))
		{
			Debug.Log(" in-game items");
			this.JLOCLBNNAAN();
		}
	}

	// Token: 0x0600BCCE RID: 48334 RVA: 0x0044BD8A File Offset: 0x00449F8A
	public void LEEHMNACMEI(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("ticket.ticket1"))
		{
			this.StartTime = (double)DGIHEPAHAJK["_Far"];
		}
	}

	// Token: 0x0600BCCF RID: 48335 RVA: 0x0044BDB2 File Offset: 0x00449FB2
	public void MNNLMGKAPFG(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("Can't set Room.MaxPlayers to: "))
		{
			Debug.Log("0.000");
			this.NAPOAHBNGCK();
		}
	}

	// Token: 0x0600BCD0 RID: 48336 RVA: 0x0044BDDD File Offset: 0x00449FDD
	public void OANDGCIFNAN()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.NAPOAHBNGCK();
		}
		else
		{
			Debug.Log("settings.hideui" + PhotonNetwork.room.customProperties.ContainsKey("_Green_G"));
		}
	}

	// Token: 0x0600BCD1 RID: 48337 RVA: 0x0044BE1C File Offset: 0x0044A01C
	public void PCABPJAANFH()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("11", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("_TimeX", num2), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("NetworkPeer broke!", num3), new GUILayoutOption[1]);
		if (GUILayout.Button(" [", new GUILayoutOption[0]))
		{
			this.NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCD3 RID: 48339 RVA: 0x0044BF00 File Offset: 0x0044A100
	public void LLLOCCNLCNL()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("_Fade", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format(". Using max value: 255.", num2), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("_TimeX", num3), new GUILayoutOption[0]);
		if (GUILayout.Button("MapEnd", new GUILayoutOption[1]))
		{
			this.JDKOEAMABCK();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCD4 RID: 48340 RVA: 0x0044BFB3 File Offset: 0x0044A1B3
	public void JCJENMGGCLB(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("cancel"))
		{
			Debug.Log("music.ogg");
			this.AEMCMOBKOJK();
		}
	}

	// Token: 0x0600BCD5 RID: 48341 RVA: 0x0044BFDE File Offset: 0x0044A1DE
	public void LHACGKFCAMG(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("PLEASE WAIT"))
		{
			this.StartTime = (double)DGIHEPAHAJK["workshop."];
		}
	}

	// Token: 0x0600BCD6 RID: 48342 RVA: 0x0044C006 File Offset: 0x0044A206
	private void Update()
	{
		if (this.DBHJOONLNJE)
		{
			this.AEMCMOBKOJK();
		}
	}

	// Token: 0x0600BCD7 RID: 48343 RVA: 0x0044C019 File Offset: 0x0044A219
	public void HOEJPDLECMG(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("<b>#"))
		{
			Debug.Log("_Amount");
			this.DNBPCAEIMHN();
		}
	}

	// Token: 0x0600BCD8 RID: 48344 RVA: 0x0044C044 File Offset: 0x0044A244
	public void HMKPEEAJODO()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("EventSystem", num2), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("_Value", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("YES", new GUILayoutOption[0]))
		{
			this.DDMJBHAHJED();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCD9 RID: 48345 RVA: 0x0044C0F8 File Offset: 0x0044A2F8
	public void AHNBAOIENOO()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("#accuracy", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_Intensity", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("SetRotation", num3), new GUILayoutOption[0]);
		if (GUILayout.Button("_VignetteDesat", new GUILayoutOption[0]))
		{
			this.DDMJBHAHJED();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCDA RID: 48346 RVA: 0x0044C1AC File Offset: 0x0044A3AC
	private void JDKOEAMABCK()
	{
		if (PhotonNetwork.time < 1276.0)
		{
			this.DBHJOONLNJE = false;
			return;
		}
		this.DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable[" PhotonView: "] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	// Token: 0x0600BCDB RID: 48347 RVA: 0x0044C203 File Offset: 0x0044A403
	private void NKLIHNJCHOG()
	{
		if (this.DBHJOONLNJE)
		{
			this.LPEOOKEOBEL();
		}
	}

	// Token: 0x0600BCDC RID: 48348 RVA: 0x0044C216 File Offset: 0x0044A416
	public void GKCLHCNEGJM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results"))
		{
			this.StartTime = (double)DGIHEPAHAJK[".played"];
		}
	}

	// Token: 0x0600BCDD RID: 48349 RVA: 0x0044C240 File Offset: 0x0044A440
	public void JLJHPNKKJPJ()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("settings.fps", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("OnAwakeRPC", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Object ID. Case-Sensitive", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Line", new GUILayoutOption[1]))
		{
			this.JAIBANMMMFF();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCDE RID: 48350 RVA: 0x0044C2F4 File Offset: 0x0044A4F4
	public void LPKLOFJJJEI()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("_Value", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("VoteDownToggle", num2), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("menutheme.coldheat", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Speed", new GUILayoutOption[1]))
		{
			this.JLOCLBNNAAN();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCDF RID: 48351 RVA: 0x0044C3A7 File Offset: 0x0044A5A7
	public void HBBHCICNOMA(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.PFFHNNODEMM().ContainsKey("BloodAlternative3"))
		{
			Debug.Log("Set camera (or player) distance. Base player distance - 14");
			this.JAIBANMMMFF();
		}
	}

	// Token: 0x0600BCE0 RID: 48352 RVA: 0x0044C3D4 File Offset: 0x0044A5D4
	private void JLOCLBNNAAN()
	{
		if (PhotonNetwork.time < 683.0)
		{
			this.DBHJOONLNJE = true;
			return;
		}
		this.DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["Joystick1Button9"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	// Token: 0x0600BCE1 RID: 48353 RVA: 0x0044C42C File Offset: 0x0044A62C
	private void NAPOAHBNGCK()
	{
		if (PhotonNetwork.time < 1239.0)
		{
			this.DBHJOONLNJE = true;
			return;
		}
		this.DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["plainText"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0600BCE2 RID: 48354 RVA: 0x0044C483 File Offset: 0x0044A683
	public void NOHIOLKMJNH(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.KMBLODHBAFO().ContainsKey("_PositionY"))
		{
			Debug.Log(".png");
			this.DDMJBHAHJED();
		}
	}

	// Token: 0x0600BCE3 RID: 48355 RVA: 0x0044C4AE File Offset: 0x0044A6AE
	public void CCPEJINHAGP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_ScreenResolution"))
		{
			this.StartTime = (double)DGIHEPAHAJK[" - PUBLISHED #"];
		}
	}

	// Token: 0x0600BCE4 RID: 48356 RVA: 0x0044C4D6 File Offset: 0x0044A6D6
	private void CFIAKIJAILI()
	{
		if (this.DBHJOONLNJE)
		{
			this.JLOCLBNNAAN();
		}
	}

	// Token: 0x0600BCE5 RID: 48357 RVA: 0x0044C4E9 File Offset: 0x0044A6E9
	public void GLNBFKKAAOP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("GameMessagesDurationSlider"))
		{
			this.StartTime = (double)DGIHEPAHAJK["_ScreenResolution"];
		}
	}

	// Token: 0x0600BCE6 RID: 48358 RVA: 0x0044C511 File Offset: 0x0044A711
	public void MOJGCADBPBI(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.EHLPGMBBDLG().ContainsKey("_TimeX"))
		{
			Debug.Log("_Contrast");
			this.AEMCMOBKOJK();
		}
	}

	// Token: 0x0600BCE7 RID: 48359 RVA: 0x0044C53C File Offset: 0x0044A73C
	private void HPNNCNNFMGK()
	{
		if (this.DBHJOONLNJE)
		{
			this.JAIBANMMMFF();
		}
	}

	// Token: 0x0600BCE8 RID: 48360 RVA: 0x0044C53C File Offset: 0x0044A73C
	private void BGDONBMDPGM()
	{
		if (this.DBHJOONLNJE)
		{
			this.JAIBANMMMFF();
		}
	}

	// Token: 0x0600BCE9 RID: 48361 RVA: 0x0044C54F File Offset: 0x0044A74F
	public void PBJIMOILOLE()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.LPEOOKEOBEL();
		}
		else
		{
			Debug.Log("_Value4" + PhotonNetwork.room.KMBLODHBAFO().ContainsKey("settings_bindings_controller_type"));
		}
	}

	// Token: 0x0600BCEA RID: 48362 RVA: 0x0044C58E File Offset: 0x0044A78E
	public void OnJoinedRoom()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.AEMCMOBKOJK();
		}
		else
		{
			Debug.Log("StartTime already set: " + PhotonNetwork.room.customProperties.ContainsKey("st"));
		}
	}

	// Token: 0x0600BCEB RID: 48363 RVA: 0x0044C5CD File Offset: 0x0044A7CD
	public void NEMLLIAHOBM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("[SoundManager] Loaded skin audio"))
		{
			this.StartTime = (double)DGIHEPAHAJK["_Value3"];
		}
	}

	// Token: 0x0600BCEC RID: 48364 RVA: 0x0044C5F5 File Offset: 0x0044A7F5
	private void LPMINJJPDCH()
	{
		if (this.DBHJOONLNJE)
		{
			this.NAPOAHBNGCK();
		}
	}

	// Token: 0x0600BCED RID: 48365 RVA: 0x0044C608 File Offset: 0x0044A808
	public void EOJGCJABGNC()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("ok", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("<b>#banended</b>", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Malformed RPC; this should never occur. Content: ", num3), new GUILayoutOption[0]);
		if (GUILayout.Button("^", new GUILayoutOption[0]))
		{
			this.JDKOEAMABCK();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCEE RID: 48366 RVA: 0x0044C6BC File Offset: 0x0044A8BC
	public void IDDPLCAHDPO()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("_TimeX", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_BlurRadius4", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("Gameplay/satellite", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Value", new GUILayoutOption[0]))
		{
			this.JLOCLBNNAAN();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCEF RID: 48367 RVA: 0x0044C76F File Offset: 0x0044A96F
	public void ICOIEGANENL(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("help"))
		{
			this.StartTime = (double)DGIHEPAHAJK["s"];
		}
	}

	// Token: 0x0600BCF0 RID: 48368 RVA: 0x0044C798 File Offset: 0x0044A998
	public void KOCIIOKHKME()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("isBunned", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("]", num2), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("GO==null", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_Value", new GUILayoutOption[1]))
		{
			this.NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCF1 RID: 48369 RVA: 0x0044C84B File Offset: 0x0044AA4B
	public void PNHBOKMFFNN()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.JLOCLBNNAAN();
		}
		else
		{
			Debug.Log("_Offsets" + PhotonNetwork.room.PFFHNNODEMM().ContainsKey("white"));
		}
	}

	// Token: 0x0600BCF2 RID: 48370 RVA: 0x0044C88A File Offset: 0x0044AA8A
	public void GMKMLFAIIAJ()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.NAPOAHBNGCK();
		}
		else
		{
			Debug.Log("_Value2" + PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("Set Satellite Sensitivity"));
		}
	}

	// Token: 0x0600BCF3 RID: 48371 RVA: 0x0044C53C File Offset: 0x0044A73C
	private void JHPOIOELNCG()
	{
		if (this.DBHJOONLNJE)
		{
			this.JAIBANMMMFF();
		}
	}

	// Token: 0x0600BCF4 RID: 48372 RVA: 0x0044C8CC File Offset: 0x0044AACC
	private void LPEOOKEOBEL()
	{
		if (PhotonNetwork.time < 1812.0)
		{
			this.DBHJOONLNJE = false;
			return;
		}
		this.DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable[". Going to ignore! Check PhotonServerSettings.RpcList"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0600BCF5 RID: 48373 RVA: 0x0044C924 File Offset: 0x0044AB24
	private void JAIBANMMMFF()
	{
		if (PhotonNetwork.time < 274.0)
		{
			this.DBHJOONLNJE = true;
			return;
		}
		this.DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["GridDataArcs"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0600BCF6 RID: 48374 RVA: 0x0044C97B File Offset: 0x0044AB7B
	public void BNHKNBILGBK(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("[PlayerController] "))
		{
			Debug.Log("_Value2");
			this.JAIBANMMMFF();
		}
	}

	// Token: 0x0600BCF7 RID: 48375 RVA: 0x0044C9A6 File Offset: 0x0044ABA6
	public void PHCOGMJPGNN(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("_TimeX"))
		{
			Debug.Log("Init");
			this.DDMJBHAHJED();
		}
	}

	// Token: 0x0600BCF8 RID: 48376 RVA: 0x0044C53C File Offset: 0x0044A73C
	private void EGEGNHLODAA()
	{
		if (this.DBHJOONLNJE)
		{
			this.JAIBANMMMFF();
		}
	}

	// Token: 0x0600BCF9 RID: 48377 RVA: 0x0044C9D4 File Offset: 0x0044ABD4
	private void DDMJBHAHJED()
	{
		if (PhotonNetwork.time < 576.0)
		{
			this.DBHJOONLNJE = false;
			return;
		}
		this.DBHJOONLNJE = false;
		Hashtable hashtable = new Hashtable();
		hashtable["offsets"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	// Token: 0x0600BCFA RID: 48378 RVA: 0x0044CA2C File Offset: 0x0044AC2C
	private void DNBPCAEIMHN()
	{
		if (PhotonNetwork.time < 508.0)
		{
			this.DBHJOONLNJE = true;
			return;
		}
		this.DBHJOONLNJE = true;
		Hashtable hashtable = new Hashtable();
		hashtable["float,1.5"] = PhotonNetwork.time;
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	// Token: 0x0600BCFB RID: 48379 RVA: 0x0044CA83 File Offset: 0x0044AC83
	public void LEHMPPOHPEI()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.DDMJBHAHJED();
		}
		else
		{
			Debug.Log("," + PhotonNetwork.room.KMBLODHBAFO().ContainsKey("[DiscordController] Sectate ({0})"));
		}
	}

	// Token: 0x0600BCFC RID: 48380 RVA: 0x0044CAC4 File Offset: 0x0044ACC4
	public void OnGUI()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("elapsed: {0:0.000}", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("remaining: {0:0.000}", num2), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("turn: {0:0}", num3), new GUILayoutOption[0]);
		if (GUILayout.Button("new round", new GUILayoutOption[0]))
		{
			this.AEMCMOBKOJK();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCFD RID: 48381 RVA: 0x0044CB78 File Offset: 0x0044AD78
	public void LKFBADCLLML()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format(": ", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("_Value", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_threshold", num3), new GUILayoutOption[0]);
		if (GUILayout.Button("Subscribed cells:\n", new GUILayoutOption[0]))
		{
			this.DDMJBHAHJED();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BCFE RID: 48382 RVA: 0x0044CC2B File Offset: 0x0044AE2B
	public void MPOCGBCPFJC(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("_VelocityScale"))
		{
			Debug.Log("GridDataStoryboard");
			this.NAPOAHBNGCK();
		}
	}

	// Token: 0x0600BCFF RID: 48383 RVA: 0x0044CC56 File Offset: 0x0044AE56
	public void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("st"))
		{
			this.StartTime = (double)DGIHEPAHAJK["st"];
		}
	}

	// Token: 0x0600BD00 RID: 48384 RVA: 0x0044CC80 File Offset: 0x0044AE80
	public void BCODHAOJLJL()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("_Red_G", num), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_ScreenResolution", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("OnAwakeRPC", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
		{
			this.NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BD01 RID: 48385 RVA: 0x0044CD33 File Offset: 0x0044AF33
	public void EDODBNGGNDF(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.KMBLODHBAFO().ContainsKey("_Distortion"))
		{
			Debug.Log("00");
			this.LPEOOKEOBEL();
		}
	}

	// Token: 0x0600BD02 RID: 48386 RVA: 0x0044CD5E File Offset: 0x0044AF5E
	public void HNOGLCMFLPA(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.KMBLODHBAFO().ContainsKey("_Value"))
		{
			Debug.Log("_Offsets");
			this.JDKOEAMABCK();
		}
	}

	// Token: 0x0600BD03 RID: 48387 RVA: 0x0044CD89 File Offset: 0x0044AF89
	private void NDAJBJFJGCF()
	{
		if (this.DBHJOONLNJE)
		{
			this.DDMJBHAHJED();
		}
	}

	// Token: 0x0600BD04 RID: 48388 RVA: 0x0044CD9C File Offset: 0x0044AF9C
	public void NMHIDAOMOGO()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("shader.sunny", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("Event Received", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("#ok", num3), new GUILayoutOption[1]);
		if (GUILayout.Button("settings_bindings_", new GUILayoutOption[1]))
		{
			this.NAPOAHBNGCK();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BD05 RID: 48389 RVA: 0x0044C203 File Offset: 0x0044A403
	private void HMNLHMLILKD()
	{
		if (this.DBHJOONLNJE)
		{
			this.LPEOOKEOBEL();
		}
	}

	// Token: 0x0600BD06 RID: 48390 RVA: 0x0044CE50 File Offset: 0x0044B050
	public void EAHKLHCEDLB()
	{
		double num = PhotonNetwork.time - this.StartTime;
		double num2 = (double)this.SecondsPerTurn - num % (double)this.SecondsPerTurn;
		int num3 = (int)(num / (double)this.SecondsPerTurn);
		GUILayout.BeginArea(this.TextPos);
		GUILayout.Label(string.Format("_Value", num), new GUILayoutOption[0]);
		GUILayout.Label(string.Format("EventTimeInputField", num2), new GUILayoutOption[1]);
		GUILayout.Label(string.Format("_Value2", num3), new GUILayoutOption[0]);
		if (GUILayout.Button("/music", new GUILayoutOption[0]))
		{
			this.JAIBANMMMFF();
		}
		GUILayout.EndArea();
	}

	// Token: 0x0600BD07 RID: 48391 RVA: 0x0044CF03 File Offset: 0x0044B103
	public void LPLDDGOEEIJ(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("[NetworkManager] Exited"))
		{
			Debug.Log("color");
			this.JLOCLBNNAAN();
		}
	}

	// Token: 0x0600BD08 RID: 48392 RVA: 0x0044CF2E File Offset: 0x0044B12E
	public void PFPGCHHHEHM(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("CameraFilterPack/Blend2Camera_ColorBurn"))
		{
			Debug.Log("ShowTitle");
			this.JLOCLBNNAAN();
		}
	}

	// Token: 0x0600BD09 RID: 48393 RVA: 0x0044CF59 File Offset: 0x0044B159
	public void GAAMDOMCJLK(PhotonPlayer DELECHPDOCO)
	{
		if (!PhotonNetwork.room.OJKFLHKNPKO().ContainsKey("UnityEngine.MonoBehaviour"))
		{
			Debug.Log("_CenterX");
			this.JLOCLBNNAAN();
		}
	}

	// Token: 0x04001635 RID: 5685
	public int SecondsPerTurn = 5;

	// Token: 0x04001636 RID: 5686
	public double StartTime;

	// Token: 0x04001637 RID: 5687
	public Rect TextPos = new Rect(0f, 80f, 150f, 300f);

	// Token: 0x04001638 RID: 5688
	private bool DBHJOONLNJE;

	// Token: 0x04001639 RID: 5689
	private const string JJDHAIONGKL = "st";
}
