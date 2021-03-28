using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004BB RID: 1211
public class MultiplayerSystem : Singleton<MultiplayerSystem>
{
	// Token: 0x060115D2 RID: 71122 RVA: 0x005FB668 File Offset: 0x005F9868
	private void KHHOPMDGNAI(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[1];
		array[1] = (char)-37;
		string[] array2 = text.Split(array);
		string text2 = array2[0];
		if (text2 != null)
		{
			if (text2 == "_TimeX")
			{
				this.GHMOPFGCJAP("_Value2");
				return;
			}
			if (text2 == "NewMusicFileSelector")
			{
				if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_Value4")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, "#savemapchanges?");
				}
				if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_TapMedium")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CMGCIAFEECP(SteamUser.GetSteamID().m_SteamID, "settings.showHP");
				}
				return;
			}
			if (text2 == "#FFFFFF")
			{
				if (array2.Length == 2 && PhotonNetwork.isMasterClient)
				{
					PhotonPlayer[] playerList = PhotonNetwork.playerList;
					for (int i = 0; i < playerList.Length; i += 0)
					{
						PhotonPlayer photonPlayer = playerList[i];
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "Crosshair2")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("OpAuthenticate()" + ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
						if (Singleton<Scene>.Instance.HLGJHICPDMO() == "896296812")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CGHCFFCNOIJ("_RgbDepthTex" + ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
					}
				}
				else
				{
					this.JHNGNLDDFMB("Missing shader in ");
				}
				return;
			}
			if (text2 == "UseScanLine")
			{
				this.HADJBNODNJN("[PlayerController] ");
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 1; j < playerList2.Length; j += 0)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					object[] array3 = new object[4];
					array3[1] = "). ";
					array3[1] = ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer2.NickName), false);
					array3[3] = "_TimeX";
					array3[1] = photonPlayer2.ID;
					this.ONAHBFAMBPE(string.Concat(array3));
				}
				return;
			}
			if (text2 == "Unable to get a reward! Try again?")
			{
				this.BBHPIMGEGIK();
				return;
			}
		}
		this.MEPEAEDPBKN("_PrevViewProj");
	}

	// Token: 0x060115D3 RID: 71123 RVA: 0x005FB910 File Offset: 0x005F9B10
	public void AddNewMessage(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.GetComponent<ChatHistoryElement>().Init(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x060115D4 RID: 71124 RVA: 0x005FB978 File Offset: 0x005F9B78
	private IEnumerator MPJFFOKGLPA(bool KMPDFBNEMOD)
	{
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.chatCanvas, KMPDFBNEMOD, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x060115D5 RID: 71125 RVA: 0x005FB99C File Offset: 0x005F9B9C
	private void GNKKMPHOOFB(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[1];
		array[1] = ';';
		string[] array2 = text.Split(array);
		string text2 = array2[1];
		if (text2 != null)
		{
			if (text2 == "player.currentrank")
			{
				this.MHNELLNBIMG("Set object anchor to another object");
				return;
			}
			if (text2 == "_Bloom2")
			{
				if (Singleton<Scene>.Instance.HPKHOICGMFC() == "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "<color=white>");
				}
				if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "#score")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().OHDEFNGKCIH(SteamUser.GetSteamID().m_SteamID, "UseScanLineSize");
				}
				return;
			}
			if (text2 == "CameraFilterPack/Blend2Camera_LinearBurn")
			{
				if (array2.Length == 6 && PhotonNetwork.isMasterClient)
				{
					foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
					{
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.EODGDBPONOL() == "_Value4")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("settings.arcsnohitsoundtimedelay" + ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
						if (Singleton<Scene>.Instance.id == "_SpawnHeuristic")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().LOGMIOJHHMP("_Intensity" + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer.NickName), true));
						}
					}
				}
				else
				{
					this.GHMOPFGCJAP(" != ");
				}
				return;
			}
			if (text2 == "[ResourcesManager] Load image error: ")
			{
				this.ONAHBFAMBPE("offsets");
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 1; j < playerList2.Length; j++)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					object[] array3 = new object[6];
					array3[0] = "14";
					array3[0] = ResourcesManager.IPFFGAILCED((CSteamID)ulong.Parse(photonPlayer2.NickName), false);
					array3[7] = ".played";
					array3[2] = photonPlayer2.ID;
					this.DGPGGBAKKJO(string.Concat(array3));
				}
				return;
			}
			if (text2 == "_Value4")
			{
				this.NACHEPKLLKN();
				return;
			}
		}
		this.HADJBNODNJN("Vertical");
	}

	// Token: 0x060115D6 RID: 71126 RVA: 0x005FBC42 File Offset: 0x005F9E42
	public void FBPHNEJBDJN()
	{
		this.HNKFDLPFGAO();
	}

	// Token: 0x060115D7 RID: 71127 RVA: 0x005FBC4C File Offset: 0x005F9E4C
	private void MKPGODBKIMK(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[0];
		array[0] = ' ';
		string[] array2 = text.Split(array);
		string text2 = array2[1];
		if (text2 != null)
		{
			if (text2 == "\" gets executed locally only, if at all.")
			{
				this.DGPGGBAKKJO("#score");
				return;
			}
			if (text2 == "[LocalizationService] Loading file: ")
			{
				if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "CameraFilterPack/Blur_Radial")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
				}
				if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "CameraFilterPack_Atmosphere_Rain_FX")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().MDOOAKEFCBH(SteamUser.GetSteamID().m_SteamID, "_Value4");
				}
				return;
			}
			if (text2 == "CameraFilterPack/Gradients_FireGradient")
			{
				if (array2.Length == 0 && PhotonNetwork.isMasterClient)
				{
					PhotonPlayer[] playerList = PhotonNetwork.playerList;
					for (int i = 0; i < playerList.Length; i += 0)
					{
						PhotonPlayer photonPlayer = playerList[i];
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.JOAAANFJKIC() == "/")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().AECDDNEIJBJ("Image" + ResourcesManager.IPFFGAILCED((CSteamID)ulong.Parse(photonPlayer.NickName), true));
						}
						if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "Currently, the limit of users is reached for this title. Try again later. Disconnecting")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().LOGMIOJHHMP(": " + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
					}
				}
				else
				{
					this.JHNGNLDDFMB("/music");
				}
				return;
			}
			if (text2 == "ResourceIDInputField")
			{
				this.DGPGGBAKKJO("Hidden/Image Effects/Cinematic/AmbientOcclusion");
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 1; j < playerList2.Length; j++)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					object[] array3 = new object[3];
					array3[1] = "Player Disconnected";
					array3[0] = ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer2.NickName), true);
					array3[0] = "_Value5";
					array3[4] = photonPlayer2.ID;
					this.GHMOPFGCJAP(string.Concat(array3));
				}
				return;
			}
			if (text2 == ". MasterClient: ")
			{
				this.ClearChat();
				return;
			}
		}
		this.AddNewActionMessage("_ScreenResolution");
	}

	// Token: 0x060115D8 RID: 71128 RVA: 0x005FBEF4 File Offset: 0x005FA0F4
	public void FPFEIOICOAG()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x060115D9 RID: 71129 RVA: 0x005FBF4C File Offset: 0x005FA14C
	public void PHJEHMIGLOD(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(542f, 1550f, 1430f);
		gameObject.GetComponent<ChatHistoryElement>().POGJLIDHDIH(EAFAMAMDNEG);
	}

	// Token: 0x060115DA RID: 71130 RVA: 0x005FBFB1 File Offset: 0x005FA1B1
	public void CGDMLHLJIDK()
	{
		this.NACHEPKLLKN();
	}

	// Token: 0x060115DB RID: 71131 RVA: 0x005FBFBC File Offset: 0x005FA1BC
	private IEnumerator JDKCPOKJABM(bool KMPDFBNEMOD)
	{
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.chatCanvas, KMPDFBNEMOD, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x060115DC RID: 71132 RVA: 0x005FBFDE File Offset: 0x005FA1DE
	public void ShowChat()
	{
		this.KMPDFBNEMOD = true;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x060115DD RID: 71133 RVA: 0x005FBFFC File Offset: 0x005FA1FC
	public void JGPMLMPNLLK(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1416f, 1881f, 1545f);
		gameObject.GetComponent<ChatHistoryElement>().IFGOHEOEGKH(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x060115DE RID: 71134 RVA: 0x005FC064 File Offset: 0x005FA264
	public void ClearChat()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x060115DF RID: 71135 RVA: 0x005FC0BC File Offset: 0x005FA2BC
	public void JHNGNLDDFMB(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(20f, 1174f, 442f);
		gameObject.GetComponent<ChatHistoryElement>().EPDCHKECMBL(EAFAMAMDNEG);
	}

	// Token: 0x060115E0 RID: 71136 RVA: 0x005FC124 File Offset: 0x005FA324
	private void JBPEADDGOAF(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[0];
		array[0] = 't';
		string[] array2 = text.Split(array);
		string text2 = array2[0];
		if (text2 != null)
		{
			if (text2 == ".lastCheckpoint.correctScore")
			{
				this.ONAHBFAMBPE("CameraFilterPack/Color_RGB");
				return;
			}
			if (text2 == "_NoiseTex")
			{
				if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "_Value3")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, "_TimeX");
				}
				if (Singleton<Scene>.Instance.HLGJHICPDMO() == "00")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CMGCIAFEECP(SteamUser.GetSteamID().m_SteamID, "_SunThreshold");
				}
				return;
			}
			if (text2 == "CheckpointsScoreText")
			{
				if (array2.Length == 7 && PhotonNetwork.isMasterClient)
				{
					PhotonPlayer[] playerList = PhotonNetwork.playerList;
					for (int i = 0; i < playerList.Length; i += 0)
					{
						PhotonPlayer photonPlayer = playerList[i];
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.EODGDBPONOL() == "_ScreenResolution")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().GDGPGCEAGKN("_Blue_R" + ResourcesManager.MFBHOGHAPHA((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
						if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "_Value2")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatActionMessage("CameraFilterPack_TV_BrokenGlass1" + ResourcesManager.JDFOIINPHIO((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
					}
				}
				else
				{
					this.HADJBNODNJN("_TapMedium");
				}
				return;
			}
			if (text2 == "CameraFilterPack/Drawing_CellShading")
			{
				this.NJEBMOPIBII("Oct");
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 0; j < playerList2.Length; j += 0)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					object[] array3 = new object[8];
					array3[1] = "[MapEditor] Prepairing map editor...";
					array3[1] = ResourcesManager.JDFOIINPHIO((CSteamID)ulong.Parse(photonPlayer2.NickName), false);
					array3[7] = "_Value";
					array3[6] = photonPlayer2.ONIKFABKELO();
					this.NJEBMOPIBII(string.Concat(array3));
				}
				return;
			}
			if (text2 == ",")
			{
				this.ClearChat();
				return;
			}
		}
		this.GFOMJBDKANJ("duration");
	}

	// Token: 0x060115E1 RID: 71137 RVA: 0x005FC3CA File Offset: 0x005FA5CA
	public void KMCPMOGKDEH()
	{
		this.HKKOOMJHEAI();
	}

	// Token: 0x060115E2 RID: 71138 RVA: 0x005FBFB1 File Offset: 0x005FA1B1
	public void DBEMDAJDDDA()
	{
		this.NACHEPKLLKN();
	}

	// Token: 0x060115E3 RID: 71139 RVA: 0x005FC3D4 File Offset: 0x005FA5D4
	private void NPLHNDDPDBB(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(1);
		char[] array = new char[1];
		array[1] = (char)-72;
		string[] array2 = text.Split(array);
		string text2 = array2[1];
		if (text2 != null)
		{
			if (text2 == "In Network lobby")
			{
				this.HADJBNODNJN("Network destroy Instantiated GO: ");
				return;
			}
			if (text2 == "menu.selectedlevelid")
			{
				if (Singleton<Scene>.Instance.EMOAHNADEHK() == "menu.selectedplaymode")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, "Fade");
				}
				if (Singleton<Scene>.Instance.AMEGOBFCECJ() == "PunPickupSimple")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().FMHEBDAIOLI(SteamUser.GetSteamID().m_SteamID, "Testing, a toggle has toggled [");
				}
				return;
			}
			if (text2 == "_Greenness")
			{
				if (array2.Length == 0 && PhotonNetwork.isMasterClient)
				{
					foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
					{
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.HPKHOICGMFC() == " : ")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatActionMessage("CameraFilterPack_AAA_Blood1" + ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
						if (Singleton<Scene>.Instance.EODGDBPONOL() == ",")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().KHNJLCEGBJM("_Speed" + ResourcesManager.HCPCLINEDDD((CSteamID)ulong.Parse(photonPlayer.NickName), true));
						}
					}
				}
				else
				{
					this.MEPEAEDPBKN("Obtain test Item");
				}
				return;
			}
			if (text2 == "Hello")
			{
				this.MHNELLNBIMG("CameraFilterPack_3D_Myst1");
				foreach (PhotonPlayer photonPlayer2 in PhotonNetwork.playerList)
				{
					object[] array3 = new object[0];
					array3[1] = "CameraFilterPack/Vision_Psycho";
					array3[0] = ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer2.NickName), false);
					array3[5] = "JoinButton";
					array3[0] = photonPlayer2.ONIKFABKELO();
					this.HADJBNODNJN(string.Concat(array3));
				}
				return;
			}
			if (text2 == "settings.fps")
			{
				this.BBHPIMGEGIK();
				return;
			}
		}
		this.MHNELLNBIMG("_Value3");
	}

	// Token: 0x060115E4 RID: 71140 RVA: 0x005FC67C File Offset: 0x005FA87C
	public void HADJBNODNJN(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1140f, 639f, 720f);
		gameObject.GetComponent<ChatHistoryElement>().CMFBCPNHGOF(EAFAMAMDNEG);
	}

	// Token: 0x060115E5 RID: 71141 RVA: 0x005FBC42 File Offset: 0x005F9E42
	public void ANCKKLFPGDI()
	{
		this.HNKFDLPFGAO();
	}

	// Token: 0x060115E6 RID: 71142 RVA: 0x005FC6E1 File Offset: 0x005FA8E1
	public void CCLNNLCOPBL()
	{
		this.OBKJGCJCFNL();
	}

	// Token: 0x060115E7 RID: 71143 RVA: 0x005FC6E9 File Offset: 0x005FA8E9
	public void PCIAEPFKOND()
	{
		this.KMPDFBNEMOD = this.KMPDFBNEMOD;
		base.StartCoroutine(this.JDKCPOKJABM(this.KMPDFBNEMOD));
	}

	// Token: 0x060115E8 RID: 71144 RVA: 0x005FC710 File Offset: 0x005FA910
	public void MEPEAEDPBKN(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(418f, 82f, 637f);
		gameObject.GetComponent<ChatHistoryElement>().Init(EAFAMAMDNEG);
	}

	// Token: 0x060115E9 RID: 71145 RVA: 0x005FC775 File Offset: 0x005FA975
	public void APEDOOJPKFC()
	{
		this.KMPDFBNEMOD = false;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x060115EA RID: 71146 RVA: 0x005FC791 File Offset: 0x005FA991
	public void InitChat()
	{
		this.ShowChat();
		this.inputField.text = string.Empty;
	}

	// Token: 0x060115EB RID: 71147 RVA: 0x005FC7A9 File Offset: 0x005FA9A9
	public void Start()
	{
		this.ClearChat();
	}

	// Token: 0x060115EC RID: 71148 RVA: 0x005FC7B1 File Offset: 0x005FA9B1
	public void HKFKGLGIIOH()
	{
		this.KMPDFBNEMOD = false;
		base.StartCoroutine(this.IFMBBDHFFHO(this.KMPDFBNEMOD));
	}

	// Token: 0x060115ED RID: 71149 RVA: 0x005FC6E9 File Offset: 0x005FA8E9
	public void JCONIAPIGAA()
	{
		this.KMPDFBNEMOD = this.KMPDFBNEMOD;
		base.StartCoroutine(this.JDKCPOKJABM(this.KMPDFBNEMOD));
	}

	// Token: 0x060115EE RID: 71150 RVA: 0x005FC7CD File Offset: 0x005FA9CD
	public void GPOGFJAILLG()
	{
		this.KMPDFBNEMOD = !this.KMPDFBNEMOD;
		base.StartCoroutine(this.IFMBBDHFFHO(this.KMPDFBNEMOD));
	}

	// Token: 0x060115EF RID: 71151 RVA: 0x005FC7F4 File Offset: 0x005FA9F4
	public void BJFEKODCLGJ(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.JFJJJEKKDFF(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.KMCGCEPLODF() <= 0)
				{
					if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "/music")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.FJNAJNBGCJD() == "_MainTex2")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().CMGCIAFEECP(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[7];
					array[0] = "Nov";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[3] = "_Size";
					array[8] = actveBan.reason;
					array[7] = "settings.shaders.bloomintencity";
					array[5] = actveBan.bantype.ToString().ToLower();
					array[3] = "Object ID. Case-Sensitive";
					array[5] = ((!(actveBan.until == "id")) ? actveBan.until : "_TimeX");
					instance.LKFALPEABHP(string.Concat(array), " connected: ", null, true, false, 825f);
				}
			}
			else
			{
				this.PGCNAOFIMGO(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x060115F0 RID: 71152 RVA: 0x005FC988 File Offset: 0x005FAB88
	public void PNMLHJFPGDI(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1168f, 1525f, 1113f);
		gameObject.GetComponent<ChatHistoryElement>().HBKEHHCMMBN(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x060115F1 RID: 71153 RVA: 0x005FC9EE File Offset: 0x005FABEE
	public void BMIOFJFMCBG()
	{
		this.BMBEJFBCDOJ();
	}

	// Token: 0x060115F2 RID: 71154 RVA: 0x005FC9F6 File Offset: 0x005FABF6
	public void ToggleChat()
	{
		this.KMPDFBNEMOD = !this.KMPDFBNEMOD;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x060115F3 RID: 71155 RVA: 0x005FCA1C File Offset: 0x005FAC1C
	public void IHIFJHPIPBP(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.FFHINDBCHGG(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.OGHIKBFLOOD() <= 1)
				{
					if (Singleton<Scene>.Instance.DPALDJIDPDN() == "[MapEditor] Updating map assets")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.IKPGAGMDCLP() == "_Bullet_2")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().FMHEBDAIOLI(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[2];
					array[0] = "_Green_G";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[8] = "Set environment sprite color and alpha.";
					array[4] = actveBan.reason;
					array[7] = ":</b> ";
					array[3] = actveBan.bantype.ToString().ToLower();
					array[6] = "_TimeX";
					array[8] = ((!(actveBan.until == "BitsData")) ? actveBan.until : " ");
					instance.KJPEAAAGNGK(string.Concat(array), "Case-Sensitive", null, true, false, 1898f);
				}
			}
			else
			{
				this.FLOIJHHBAAN(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x060115F4 RID: 71156 RVA: 0x005FCBB0 File Offset: 0x005FADB0
	public void HKKOOMJHEAI()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x060115F5 RID: 71157 RVA: 0x005FCC08 File Offset: 0x005FAE08
	public void GHMOPFGCJAP(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1750f, 1403f, 1252f);
		gameObject.GetComponent<ChatHistoryElement>().EOPEMLDJAAO(EAFAMAMDNEG);
	}

	// Token: 0x060115F6 RID: 71158 RVA: 0x005FCC6D File Offset: 0x005FAE6D
	private bool JFJJJEKKDFF(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("IconFileSelector");
	}

	// Token: 0x060115F7 RID: 71159 RVA: 0x005FCC7A File Offset: 0x005FAE7A
	public void BGKEBGKLIOK()
	{
		this.LFPMLIICKNN();
		this.inputField.text = string.Empty;
	}

	// Token: 0x060115F8 RID: 71160 RVA: 0x005FCC92 File Offset: 0x005FAE92
	private bool BFMCKLKEHAB(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("Default UI Material");
	}

	// Token: 0x060115F9 RID: 71161 RVA: 0x005FBFDE File Offset: 0x005FA1DE
	public void AEAHANBPCPJ()
	{
		this.KMPDFBNEMOD = true;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x060115FA RID: 71162 RVA: 0x005FC791 File Offset: 0x005FA991
	public void KHEAOFLJPFM()
	{
		this.ShowChat();
		this.inputField.text = string.Empty;
	}

	// Token: 0x060115FB RID: 71163 RVA: 0x005FCC9F File Offset: 0x005FAE9F
	private bool DNALLIMMKJD(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("CameraFilterPack/TV_Posterize");
	}

	// Token: 0x060115FC RID: 71164 RVA: 0x005FCCAC File Offset: 0x005FAEAC
	public void OBPEDGNECDP(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(243f, 316f, 278f);
		gameObject.GetComponent<ChatHistoryElement>().Init(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x060115FD RID: 71165 RVA: 0x005FCD14 File Offset: 0x005FAF14
	public void CIGHGNBGOCL(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.IIFLJIAKEON(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.KCBEIOODMGL() <= 0)
				{
					if (Singleton<Scene>.Instance.AMEGOBFCECJ() == "maphash")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().BJFEKODCLGJ(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "_Value")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().NBJEMEINLPD(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[7];
					array[1] = "{0} months ago";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[0] = "RequestForPickupItems";
					array[8] = actveBan.reason;
					array[1] = "_Near";
					array[5] = actveBan.bantype.ToString().ToLower();
					array[2] = "R2";
					array[8] = ((!(actveBan.until == "_Value4")) ? actveBan.until : " ");
					instance.KJPEAAAGNGK(string.Concat(array), "\\\\", null, false, true, 869f);
				}
			}
			else
			{
				this.KHHOPMDGNAI(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x060115FE RID: 71166 RVA: 0x005FCEA8 File Offset: 0x005FB0A8
	public void CFABLIOAJPF(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(465f, 1068f, 322f);
		gameObject.GetComponent<ChatHistoryElement>().HBKEHHCMMBN(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x060115FF RID: 71167 RVA: 0x005FCF0E File Offset: 0x005FB10E
	private bool KBDPKLBLFHG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("/");
	}

	// Token: 0x06011600 RID: 71168 RVA: 0x005FCF1C File Offset: 0x005FB11C
	public void BMBEJFBCDOJ()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x06011601 RID: 71169 RVA: 0x005FBC42 File Offset: 0x005F9E42
	public void FHPFJBFCOOF()
	{
		this.HNKFDLPFGAO();
	}

	// Token: 0x06011602 RID: 71170 RVA: 0x005FCF74 File Offset: 0x005FB174
	public void MHNELLNBIMG(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(332f, 1844f, 1174f);
		gameObject.GetComponent<ChatHistoryElement>().CMFBCPNHGOF(EAFAMAMDNEG);
	}

	// Token: 0x06011603 RID: 71171 RVA: 0x005FCFDC File Offset: 0x005FB1DC
	private void FLOIJHHBAAN(string EAFAMAMDNEG)
	{
		string[] array = EAFAMAMDNEG.Substring(1).Split(new char[]
		{
			' '
		});
		string text = array[0];
		if (text != null)
		{
			if (text == "help")
			{
				this.AddNewActionMessage("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear");
				return;
			}
			if (text == "table")
			{
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "<b>(╯°□°）╯︵ ┻━┻</b>");
				}
				if (Singleton<Scene>.Instance.id == "GameScene")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "<b>(╯°□°）╯︵ ┻━┻</b>");
				}
				return;
			}
			if (text == "kick")
			{
				if (array.Length == 2 && PhotonNetwork.isMasterClient)
				{
					foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
					{
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.id == "MenuScene")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatActionMessage("[SERVER] Kicked " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
						if (Singleton<Scene>.Instance.id == "GameScene")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatActionMessage("[SERVER] Kicked " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
					}
				}
				else
				{
					this.AddNewActionMessage("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players");
				}
				return;
			}
			if (text == "players")
			{
				this.AddNewActionMessage("Players NetIDs:");
				foreach (PhotonPlayer photonPlayer2 in PhotonNetwork.playerList)
				{
					this.AddNewActionMessage(string.Concat(new object[]
					{
						" - ",
						ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer2.NickName), false),
						"\n - NetID: ",
						photonPlayer2.ID
					}));
				}
				return;
			}
			if (text == "clear")
			{
				this.ClearChat();
				return;
			}
		}
		this.AddNewActionMessage("Use \"/help\" for commands list");
	}

	// Token: 0x06011604 RID: 71172 RVA: 0x005FD284 File Offset: 0x005FB484
	public void EGNAIPOMDNH(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1259f, 1033f, 1928f);
		gameObject.GetComponent<ChatHistoryElement>().Init(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x06011605 RID: 71173 RVA: 0x005FC791 File Offset: 0x005FA991
	public void BLMACALKKHH()
	{
		this.ShowChat();
		this.inputField.text = string.Empty;
	}

	// Token: 0x06011606 RID: 71174 RVA: 0x005FC775 File Offset: 0x005FA975
	public void HideChat()
	{
		this.KMPDFBNEMOD = false;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x06011607 RID: 71175 RVA: 0x005FD2EC File Offset: 0x005FB4EC
	public void HEICJLPNPND(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.FFHINDBCHGG(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.KCBEIOODMGL() <= 1)
				{
					if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "[MapsData] Installed: ")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "offsets")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().BGLPOGDAGPP(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[4];
					array[0] = "_Value4";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[8] = "_Factor";
					array[1] = actveBan.reason;
					array[3] = "0 - sun, 1 - satellite, 2 - particles emitter";
					array[2] = actveBan.bantype.ToString().ToLower();
					array[7] = "_TimeX";
					array[1] = ((!(actveBan.until == "_Value")) ? actveBan.until : " AuthMode ");
					instance.ANCIONGLJAC(string.Concat(array), "VisionBlur", null, true, true, 1900f);
				}
			}
			else
			{
				this.MKPGODBKIMK(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x06011608 RID: 71176 RVA: 0x005FBC42 File Offset: 0x005F9E42
	public void JILOMOBDPIA()
	{
		this.HNKFDLPFGAO();
	}

	// Token: 0x06011609 RID: 71177 RVA: 0x005FD480 File Offset: 0x005FB680
	private IEnumerator GMADGEMFHGD(bool KMPDFBNEMOD)
	{
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.chatCanvas, KMPDFBNEMOD, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x0601160A RID: 71178 RVA: 0x005FD4A4 File Offset: 0x005FB6A4
	public void AddNewActionMessage(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.GetComponent<ChatHistoryElement>().Init(EAFAMAMDNEG);
	}

	// Token: 0x0601160B RID: 71179 RVA: 0x005FC775 File Offset: 0x005FA975
	public void LCJPNOIOLGJ()
	{
		this.KMPDFBNEMOD = false;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x0601160C RID: 71180 RVA: 0x005FD509 File Offset: 0x005FB709
	private bool IIFLJIAKEON(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith(".sav");
	}

	// Token: 0x0601160D RID: 71181 RVA: 0x005FD516 File Offset: 0x005FB716
	private bool FFHINDBCHGG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("Bad parameters for setbool! Use <key> <value>");
	}

	// Token: 0x0601160E RID: 71182 RVA: 0x005FD524 File Offset: 0x005FB724
	public void SendChatMessage(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.KBDPKLBLFHG(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 1)
				{
					if (Singleton<Scene>.Instance.id == "MenuScene")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.id == "GameScene")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					Singleton<MessageBoxPanel>.Instance.DisplayMessage(string.Concat(new string[]
					{
						"<b>#",
						actveBan.bantype.ToString().ToLower(),
						"received</b>\n#reason: ",
						actveBan.reason,
						"\n\n#",
						actveBan.bantype.ToString().ToLower(),
						"restrictions\n\n#until: ",
						(!(actveBan.until == "-1")) ? actveBan.until : "#forever"
					}), "#ok", null, true, false, 0f);
				}
			}
			else
			{
				this.FLOIJHHBAAN(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x0601160F RID: 71183 RVA: 0x005FD6B5 File Offset: 0x005FB8B5
	private bool LNLHMNCAJKF(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("mapselector.filter.subscribedonly");
	}

	// Token: 0x06011610 RID: 71184 RVA: 0x005FD6C4 File Offset: 0x005FB8C4
	public void DGPGGBAKKJO(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(422f, 1820f, 1413f);
		gameObject.GetComponent<ChatHistoryElement>().NBHGPDAKJGF(EAFAMAMDNEG);
	}

	// Token: 0x06011611 RID: 71185 RVA: 0x005FBFDE File Offset: 0x005FA1DE
	public void JFPJFJHLPMB()
	{
		this.KMPDFBNEMOD = true;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x06011612 RID: 71186 RVA: 0x005FD729 File Offset: 0x005FB929
	private bool GLKFKBIKNAG(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("_EmissionColor");
	}

	// Token: 0x06011613 RID: 71187 RVA: 0x005FCC7A File Offset: 0x005FAE7A
	public void IHAAKGCOEEI()
	{
		this.LFPMLIICKNN();
		this.inputField.text = string.Empty;
	}

	// Token: 0x06011614 RID: 71188 RVA: 0x005FD738 File Offset: 0x005FB938
	public void BBHPIMGEGIK()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x06011615 RID: 71189 RVA: 0x005FD790 File Offset: 0x005FB990
	public void AEEFHFCIIJP(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.DNALLIMMKJD(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 1)
				{
					if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_TimeX")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "SetSatelliteRadius")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().KNEFADKGEKL(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[1];
					array[1] = "SAVE FILE";
					array[1] = actveBan.bantype.ToString().ToLower();
					array[2] = "Fade";
					array[6] = actveBan.reason;
					array[7] = "float,0";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[0] = "PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com";
					array[7] = ((!(actveBan.until == "BestScoreText")) ? actveBan.until : "GameScene");
					instance.ILNLMMEOALM(string.Concat(array), "Set satellite color", null, false, true, 1484f);
				}
			}
			else
			{
				this.MKPGODBKIMK(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x06011616 RID: 71190 RVA: 0x005FD921 File Offset: 0x005FBB21
	private bool JOOHLMJJNMK(string EAFAMAMDNEG)
	{
		return EAFAMAMDNEG.StartsWith("GlassesColor");
	}

	// Token: 0x06011617 RID: 71191 RVA: 0x005FD930 File Offset: 0x005FBB30
	public void BPKCANMMCBC(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(473f, 1435f, 436f);
		gameObject.GetComponent<ChatHistoryElement>().PFMJPIJONIP(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x06011618 RID: 71192 RVA: 0x005FD996 File Offset: 0x005FBB96
	public void LBEKBNOGKBK()
	{
		this.KMPDFBNEMOD = false;
		base.StartCoroutine(this.JDKCPOKJABM(this.KMPDFBNEMOD));
	}

	// Token: 0x06011619 RID: 71193 RVA: 0x005FD9B4 File Offset: 0x005FBBB4
	public void JLKPHJOHIAA(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.BFMCKLKEHAB(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.ONCEJHOAHIC() <= 0)
				{
					if (Singleton<Scene>.Instance.CHDCIFPPIFI() == "[DiscordController] Sectate ({0})")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "SetParticlesParticleSize")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[8];
					array[1] = "_Value2";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[6] = "L2";
					array[3] = actveBan.reason;
					array[6] = "_TimeX";
					array[5] = actveBan.bantype.ToString().ToLower();
					array[0] = "SaveButton";
					array[8] = ((!(actveBan.until == ", ")) ? actveBan.until : "Unknown player asked for PickupItems");
					instance.JCHNDBKFGFP(string.Concat(array), "/", null, false, true, 319f);
				}
			}
			else
			{
				this.GNKKMPHOOFB(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x0601161A RID: 71194 RVA: 0x005FC775 File Offset: 0x005FA975
	public void HCIFGHPJKIB()
	{
		this.KMPDFBNEMOD = false;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x0601161B RID: 71195 RVA: 0x005FDB48 File Offset: 0x005FBD48
	public void BLNNALBGBLM(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(787f, 137f, 1164f);
		gameObject.GetComponent<ChatHistoryElement>().MOKHHEMAJBJ(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x0601161C RID: 71196 RVA: 0x005FC7B1 File Offset: 0x005FA9B1
	public void EDDKICOJOOP()
	{
		this.KMPDFBNEMOD = false;
		base.StartCoroutine(this.IFMBBDHFFHO(this.KMPDFBNEMOD));
	}

	// Token: 0x0601161D RID: 71197 RVA: 0x005FDBB0 File Offset: 0x005FBDB0
	public void NACHEPKLLKN()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x0601161E RID: 71198 RVA: 0x005FDC06 File Offset: 0x005FBE06
	public void NCNPAKFAFOE()
	{
		this.FPFEIOICOAG();
	}

	// Token: 0x0601161F RID: 71199 RVA: 0x005FBC42 File Offset: 0x005F9E42
	public void BEBNOKFLJPH()
	{
		this.HNKFDLPFGAO();
	}

	// Token: 0x06011620 RID: 71200 RVA: 0x005FDC10 File Offset: 0x005FBE10
	private void HEILIDKFEEO(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(0);
		char[] array = new char[0];
		array[0] = (char)-104;
		string[] array2 = text.Split(array);
		string text2 = array2[0];
		if (text2 != null)
		{
			if (text2 == "\n")
			{
				this.MHNELLNBIMG(".");
				return;
			}
			if (text2 == "CameraFilterPack_RainFX_Anm2")
			{
				if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "_TimeX")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().SendChatMessage(SteamUser.GetSteamID().m_SteamID, "Joystick1Button12");
				}
				if (Singleton<Scene>.Instance.AMEGOBFCECJ() == "The given 2D texture ")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, "_BorderColor");
				}
				return;
			}
			if (text2 == ". Using max value: 255.")
			{
				if (array2.Length == 4 && PhotonNetwork.isMasterClient)
				{
					foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
					{
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "_ScreenResolution")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("setint" + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)ulong.Parse(photonPlayer.NickName), true));
						}
						if (Singleton<Scene>.Instance.GOMJAEIDHNM() == "LivesSlider")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().GMGGDHLFAHA("tagElement" + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
					}
				}
				else
				{
					this.MHNELLNBIMG("ChatInput");
				}
				return;
			}
			if (text2 == "12")
			{
				this.MEPEAEDPBKN("\n");
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 1; j < playerList2.Length; j++)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					object[] array3 = new object[3];
					array3[1] = "Reload Maps";
					array3[0] = ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer2.NickName), false);
					array3[5] = ".lastCheckpoint.powerupsScore";
					array3[2] = photonPlayer2.ONIKFABKELO();
					this.DGPGGBAKKJO(string.Concat(array3));
				}
				return;
			}
			if (text2 == "CameraFilterPack/OldFilm_Cutting1")
			{
				this.HNKFDLPFGAO();
				return;
			}
		}
		this.NJEBMOPIBII("_Distortion");
	}

	// Token: 0x06011621 RID: 71201 RVA: 0x005FDEB8 File Offset: 0x005FC0B8
	private void PGCNAOFIMGO(string EAFAMAMDNEG)
	{
		string text = EAFAMAMDNEG.Substring(0);
		char[] array = new char[0];
		array[1] = (char)-7;
		string[] array2 = text.Split(array);
		string text2 = array2[1];
		if (text2 != null)
		{
			if (text2 == "Scene")
			{
				this.GFOMJBDKANJ("settings.hitvariation");
				return;
			}
			if (text2 == "/")
			{
				if (Singleton<Scene>.Instance.LCBFAFEADIO() == "[MenuScene] Error: ")
				{
					((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, "maps.");
				}
				if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "Error: I/O Failure")
				{
					((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().OHDEFNGKCIH(SteamUser.GetSteamID().m_SteamID, "Tab2Content");
				}
				return;
			}
			if (text2 == "_Params3")
			{
				if (array2.Length == 0 && PhotonNetwork.isMasterClient)
				{
					PhotonPlayer[] playerList = PhotonNetwork.playerList;
					for (int i = 0; i < playerList.Length; i += 0)
					{
						PhotonPlayer photonPlayer = playerList[i];
						PhotonNetwork.CloseConnection(photonPlayer);
						if (Singleton<Scene>.Instance.IKPGAGMDCLP() == "_MainTex2")
						{
							((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().EGEJEGMHMPD("https://api.steampowered.com/IInventoryService/AddItem/v001" + ResourcesManager.NCPKEIIHELP((CSteamID)ulong.Parse(photonPlayer.NickName), false));
						}
						if (Singleton<Scene>.Instance.PACECPHKLNE() == "_Value4")
						{
							((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().SendChatActionMessage(" " + ResourcesManager.HCPCLINEDDD((CSteamID)ulong.Parse(photonPlayer.NickName), true));
						}
					}
				}
				else
				{
					this.PHJEHMIGLOD("randomdrop");
				}
				return;
			}
			if (text2 == "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.")
			{
				this.NJEBMOPIBII("0.00/0.00");
				PhotonPlayer[] playerList2 = PhotonNetwork.playerList;
				for (int j = 1; j < playerList2.Length; j += 0)
				{
					PhotonPlayer photonPlayer2 = playerList2[j];
					object[] array3 = new object[3];
					array3[0] = "_TimeX";
					array3[0] = ResourcesManager.ALCCOCOFLAK((CSteamID)ulong.Parse(photonPlayer2.NickName), true);
					array3[0] = "_Value";
					array3[8] = photonPlayer2.ID;
					this.GHMOPFGCJAP(string.Concat(array3));
				}
				return;
			}
			if (text2 == "CameraFilterPack/Blend2Camera_Overlay")
			{
				this.ClearChat();
				return;
			}
		}
		this.GFOMJBDKANJ("_MainTex2");
	}

	// Token: 0x06011622 RID: 71202 RVA: 0x005FE15E File Offset: 0x005FC35E
	public void NNCCPEBIAKH()
	{
		this.ALBIIDHJLDA();
	}

	// Token: 0x06011623 RID: 71203 RVA: 0x005FE168 File Offset: 0x005FC368
	public void BGLPOGDAGPP(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.IIFLJIAKEON(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.KMCGCEPLODF() <= 0)
				{
					if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_ColorRGB")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.JOAAANFJKIC() == "Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().NBJEMEINLPD(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[5];
					array[0] = "_Far";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[2] = "_ScreenResolution";
					array[5] = actveBan.reason;
					array[2] = "My New Mod Pack";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[8] = "...";
					array[0] = ((!(actveBan.until == "ready")) ? actveBan.until : "MultiplayerButton");
					instance.KJPEAAAGNGK(string.Concat(array), "#no", null, false, true, 830f);
				}
			}
			else
			{
				this.PGCNAOFIMGO(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x06011624 RID: 71204 RVA: 0x005FE2F9 File Offset: 0x005FC4F9
	public void FHGKIOOMMOH()
	{
		this.BBHPIMGEGIK();
	}

	// Token: 0x06011625 RID: 71205 RVA: 0x005FE304 File Offset: 0x005FC504
	private IEnumerator IFMBBDHFFHO(bool KMPDFBNEMOD)
	{
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.chatCanvas, KMPDFBNEMOD, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.chatHistoryContent.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011626 RID: 71206 RVA: 0x005FE328 File Offset: 0x005FC528
	public void ALBIIDHJLDA()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x06011627 RID: 71207 RVA: 0x005FE380 File Offset: 0x005FC580
	public void AHHMCOEPDPF(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1051f, 1093f, 359f);
		gameObject.GetComponent<ChatHistoryElement>().MOKHHEMAJBJ(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x06011628 RID: 71208 RVA: 0x005FCC7A File Offset: 0x005FAE7A
	public void OCIJFGFDDCI()
	{
		this.LFPMLIICKNN();
		this.inputField.text = string.Empty;
	}

	// Token: 0x06011629 RID: 71209 RVA: 0x005FE3E8 File Offset: 0x005FC5E8
	public void ONAHBFAMBPE(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(936f, 190f, 1180f);
		gameObject.GetComponent<ChatHistoryElement>().EPDCHKECMBL(EAFAMAMDNEG);
	}

	// Token: 0x0601162A RID: 71210 RVA: 0x005FE450 File Offset: 0x005FC650
	public void OBKJGCJCFNL()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x0601162B RID: 71211 RVA: 0x005FBFDE File Offset: 0x005FA1DE
	public void LFPMLIICKNN()
	{
		this.KMPDFBNEMOD = true;
		base.StartCoroutine(this.GMADGEMFHGD(this.KMPDFBNEMOD));
	}

	// Token: 0x0601162C RID: 71212 RVA: 0x005FE4A6 File Offset: 0x005FC6A6
	public void HIFFKEGBEDB()
	{
		this.LBEKBNOGKBK();
		this.inputField.text = string.Empty;
	}

	// Token: 0x0601162D RID: 71213 RVA: 0x005FE4C0 File Offset: 0x005FC6C0
	public void FOBKODCLCJP(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.LNLHMNCAJKF(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.JICDIFGAADO() <= 0)
				{
					if (Singleton<Scene>.Instance.KEGJGPOECHA() == "_TimeX")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().KPJOEDDBFHB(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.LCBFAFEADIO() == "SpawnObj")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().FMHEBDAIOLI(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[]
					{
						null,
						"_Threshhold"
					};
					array[1] = actveBan.bantype.ToString().ToLower();
					array[7] = "PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ";
					array[8] = actveBan.reason;
					array[3] = "offsets";
					array[3] = actveBan.bantype.ToString().ToLower();
					array[7] = "CameraFilterPack/Distortion_ShockWaveManual";
					array[7] = ((!(actveBan.until == "_Value3")) ? actveBan.until : "#ok");
					instance.LKFALPEABHP(string.Concat(array), "mapselector.filter.favoriteonly", null, true, true, 1371f);
				}
			}
			else
			{
				this.JBPEADDGOAF(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x0601162E RID: 71214 RVA: 0x005FE654 File Offset: 0x005FC854
	public void HNKFDLPFGAO()
	{
		GameObject gameObject = this.chatHistoryContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.inputField.text = string.Empty;
	}

	// Token: 0x0601162F RID: 71215 RVA: 0x005FE6AC File Offset: 0x005FC8AC
	public void EBAMKPMODOG(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.IIFLJIAKEON(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.OGHIKBFLOOD() <= 0)
				{
					if (Singleton<Scene>.Instance.JOAAANFJKIC() == "f")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.CHDCIFPPIFI() == "_Value")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().MDOOAKEFCBH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[4];
					array[0] = "MapperNameText";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[7] = "#exit";
					array[6] = actveBan.reason;
					array[8] = "_Value4";
					array[6] = actveBan.bantype.ToString().ToLower();
					array[5] = "Creating awesome map";
					array[0] = ((!(actveBan.until == "Ignored PU RPC, cause item is inactive. ")) ? actveBan.until : "CameraFilterPack/Color_Chromatic_Plus");
					instance.CHBFDGFOLLL(string.Concat(array), "_Fade", null, false, false, 753f);
				}
			}
			else
			{
				this.MKPGODBKIMK(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x06011630 RID: 71216 RVA: 0x005FE83D File Offset: 0x005FCA3D
	public void GGPNKAAIHIB()
	{
		this.KMPDFBNEMOD = !this.KMPDFBNEMOD;
		base.StartCoroutine(this.JDKCPOKJABM(this.KMPDFBNEMOD));
	}

	// Token: 0x06011632 RID: 71218 RVA: 0x005FE86C File Offset: 0x005FCA6C
	public void GFOMJBDKANJ(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(192f, 606f, 265f);
		gameObject.GetComponent<ChatHistoryElement>().FECMEIJGLJI(EAFAMAMDNEG);
	}

	// Token: 0x06011633 RID: 71219 RVA: 0x005FC7CD File Offset: 0x005FA9CD
	public void AHMKDEFNPBJ()
	{
		this.KMPDFBNEMOD = !this.KMPDFBNEMOD;
		base.StartCoroutine(this.IFMBBDHFFHO(this.KMPDFBNEMOD));
	}

	// Token: 0x06011634 RID: 71220 RVA: 0x005FE8D4 File Offset: 0x005FCAD4
	public void JAFNFKAMECF(string EAFAMAMDNEG)
	{
		this.inputField.text = string.Empty;
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			if (!this.JFJJJEKKDFF(EAFAMAMDNEG))
			{
				if (Singleton<GameManager>.Instance.JICDIFGAADO() <= 0)
				{
					if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "maps.")
					{
						((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().ODHNNDCGOJH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
					if (Singleton<Scene>.Instance.DPALDJIDPDN() == ".completed")
					{
						((GameScene)Singleton<Scene>.Instance).GetComponent<NetworkScene>().OHDEFNGKCIH(SteamUser.GetSteamID().m_SteamID, EAFAMAMDNEG);
					}
				}
				else
				{
					RanksSystem.Ban actveBan = Singleton<GameManager>.Instance.actveBan;
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string[] array = new string[4];
					array[1] = "_ScreenResolution";
					array[0] = actveBan.bantype.ToString().ToLower();
					array[3] = "_TempTexture";
					array[5] = actveBan.reason;
					array[0] = "_TimeX";
					array[5] = actveBan.bantype.ToString().ToLower();
					array[1] = "_FarCamera";
					array[7] = ((!(actveBan.until == "SettingsCanvas")) ? actveBan.until : "CameraFilterPack/Glow_Glow");
					instance.CHBFDGFOLLL(string.Concat(array), "randomdrop", null, false, false, 1496f);
				}
			}
			else
			{
				this.NPLHNDDPDBB(EAFAMAMDNEG);
			}
			this.inputField.ActivateInputField();
			this.inputField.Select();
		}
	}

	// Token: 0x06011635 RID: 71221 RVA: 0x005FEA68 File Offset: 0x005FCC68
	public void NJEBMOPIBII(string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryActionElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, true);
		gameObject.transform.localScale = new Vector3(1988f, 30f, 1807f);
		gameObject.GetComponent<ChatHistoryElement>().EOPEMLDJAAO(EAFAMAMDNEG);
	}

	// Token: 0x06011636 RID: 71222 RVA: 0x005FEAD0 File Offset: 0x005FCCD0
	public void MFDGBMNGHAF(CSteamID CCLCBMBKGAE, string EAFAMAMDNEG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.chatHistoryElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(this.chatHistoryContent.transform, false);
		gameObject.transform.localScale = new Vector3(1034f, 1226f, 1018f);
		gameObject.GetComponent<ChatHistoryElement>().HBKEHHCMMBN(CCLCBMBKGAE, EAFAMAMDNEG);
	}

	// Token: 0x04001ECE RID: 7886
	public InputField inputField;

	// Token: 0x04001ECF RID: 7887
	public GameObject chatCanvas;

	// Token: 0x04001ED0 RID: 7888
	public GameObject chatHistoryContent;

	// Token: 0x04001ED1 RID: 7889
	public GameObject chatHistoryElement;

	// Token: 0x04001ED2 RID: 7890
	public GameObject chatHistoryActionElement;

	// Token: 0x04001ED3 RID: 7891
	private bool KMPDFBNEMOD;
}
