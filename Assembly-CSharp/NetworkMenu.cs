using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020004C1 RID: 1217
public class NetworkMenu : PunBehaviour
{
	// Token: 0x060117BB RID: 71611 RVA: 0x00602D2C File Offset: 0x00600F2C
	public override void OnJoinedLobby()
	{
		Debug.Log("[NetworkManager] Joined main lobby");
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu", null, null, null, 0, 0);
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "Offline";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.none);
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x060117BC RID: 71612 RVA: 0x00602DE8 File Offset: 0x00600FE8
	public void BEPIGKICNKH()
	{
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.IPOGIBLJDPE("_Value2", null, null, null, 1, 0);
		if (GameObject.Find("Load Game"))
		{
			GameObject.Find(".mp3").transform.Find("ViewMenu").GetComponent<Button>().onClick.Invoke();
		}
	}

	// Token: 0x060117BD RID: 71613 RVA: 0x00602E4C File Offset: 0x0060104C
	public void PHHCHGEHPJD()
	{
		this.roomNameInputField.text = UnityEngine.Random.Range(-61, -161) + string.Empty;
		this.roomDescriptionInputField.text = "[PlayerController] " + SteamFriends.GetFriendPersonaName(SteamUser.GetSteamID());
		this.roomPrivateToggle.isOn = false;
	}

	// Token: 0x060117BE RID: 71614 RVA: 0x00602EB0 File Offset: 0x006010B0
	private IEnumerator HBKFEHBOKGL()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog(LocalizationService.Instance.GetLocalizatedText("#roomname"), LocalizationService.Instance.GetLocalizatedText("#join").ToUpper(), string.Empty, null));
		this.JoinRoomByID(Singleton<MessageBoxPanel>.Instance.textResult);
		yield break;
	}

	// Token: 0x060117BF RID: 71615 RVA: 0x00602ECC File Offset: 0x006010CC
	public override void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("Player Disconnected");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("masterSteamID", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		}
		this.UpdateRoom();
	}

	// Token: 0x060117C0 RID: 71616 RVA: 0x00602F18 File Offset: 0x00601118
	public virtual void GCOEACCGCBE(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("OnEvent: {0}");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Rock", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		}
		this.FDNCEFHNLNJ();
	}

	// Token: 0x060117C1 RID: 71617 RVA: 0x00602F64 File Offset: 0x00601164
	private IEnumerator LBLPBKEBNNI()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x060117C2 RID: 71618 RVA: 0x00602F80 File Offset: 0x00601180
	public virtual void GKHBAIPDPOL()
	{
		Singleton<MessageBoxPanel>.Instance.LNBENKOBLCG(-1, null);
		Debug.Log("_TimeX" + PhotonNetwork.room.EGPGEMJNPFD() + "Missing shader in ");
		Singleton<MultiplayerSystem>.Instance.PHJEHMIGLOD("Identity LUT" + PhotonNetwork.room.GJCOLGAHAIO());
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.BGKEBGKLIOK();
		PhotonView photonView = base.AAMNKPHHHCI();
		string lblkdnnpaco = "y";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[1] = "maps." + ResourcesManager.MFBHOGHAPHA(SteamUser.GetSteamID(), true) + "_ScratchTex";
		photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
		this.reciveLevelId = false;
		this.lobbyCanvas.SetActive(true);
		this.networkCanvas.SetActive(true);
		GameObject.Find("_ScreenResolution").GetComponent<Button>().interactable = true;
		if (GameObject.Find("_TimeX"))
		{
			GameObject.Find("[NetworkManager] Joined main lobby").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.MKGBAKICGOA("settings.fps", "SetSunDirectionVector", PhotonNetwork.room.Name, PhotonNetwork.room.OFNKBGMDLPG(), PhotonNetwork.room.PlayerCount, PhotonNetwork.room.MaxPlayers);
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("mapselector.filter.subscribedonly", new Vector3(1569f, 1797f, 504f), Quaternion.identity, 1);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1928f, 1836f, 655f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.POGJLIDHDIH();
		this.FDNCEFHNLNJ();
		base.FFIPLLNKGEN().MIAHMDGOOPJ("_Value3", PhotonTargets.AllBuffered, new object[1]);
	}

	// Token: 0x060117C3 RID: 71619 RVA: 0x0060314C File Offset: 0x0060134C
	private IEnumerator KJLFOJHECGL(string OIFIJMAEAFO)
	{
		this.OnJoinedRoom();
		if (PhotonNetwork.insideLobby)
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		else
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			while (!PhotonNetwork.insideLobby)
			{
				yield return new WaitForSeconds(0.1f);
			}
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		yield break;
	}

	// Token: 0x060117C4 RID: 71620 RVA: 0x00603170 File Offset: 0x00601370
	public virtual void JGDFMEELCKL(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log(".status");
		Singleton<GameManager>.Instance.UpdateOnlineStatus("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", "MapEditor v.", PhotonNetwork.room.Name, PhotonNetwork.room.GJCOLGAHAIO(), PhotonNetwork.room.DHOGHIOACME(), PhotonNetwork.room.DDDIFAMCNDO());
	}

	// Token: 0x060117C5 RID: 71621 RVA: 0x006031C4 File Offset: 0x006013C4
	private IEnumerator IPOLKJBMJKB(string OIFIJMAEAFO)
	{
		this.OnJoinedRoom();
		if (PhotonNetwork.insideLobby)
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		else
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			while (!PhotonNetwork.insideLobby)
			{
				yield return new WaitForSeconds(0.1f);
			}
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		yield break;
	}

	// Token: 0x060117C6 RID: 71622 RVA: 0x006031E8 File Offset: 0x006013E8
	public override void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("Player Connected");
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Network lobby", "Waiting to start", PhotonNetwork.room.Name, PhotonNetwork.room.Name, PhotonNetwork.room.PlayerCount, PhotonNetwork.room.MaxPlayers);
	}

	// Token: 0x060117C7 RID: 71623 RVA: 0x0060323C File Offset: 0x0060143C
	private IEnumerator NCOGMGLNMJM()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x060117C8 RID: 71624 RVA: 0x00603258 File Offset: 0x00601458
	public bool CLMHNNMBCGB()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer jhoedacnnkk = playerList[i];
			if (jhoedacnnkk.GetTeam() == PunTeams.Team.none)
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x060117C9 RID: 71625 RVA: 0x00603293 File Offset: 0x00601493
	public void SelectMapForMultiplayer()
	{
		base.StartCoroutine(this.DIBHMOMMNNG());
	}

	// Token: 0x060117CA RID: 71626 RVA: 0x006032A4 File Offset: 0x006014A4
	public void ExitToMenu()
	{
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu", null, null, null, 0, 0);
		if (GameObject.Find("NetworkCanvas"))
		{
			GameObject.Find("NetworkCanvas").transform.Find("BackButton").GetComponent<Button>().onClick.Invoke();
		}
	}

	// Token: 0x060117CB RID: 71627 RVA: 0x002AC686 File Offset: 0x002AA886
	public virtual void DODDDMCNOKJ(object[] APELDCFFFOH)
	{
		Debug.Log("_ScreenResolution");
	}

	// Token: 0x060117CC RID: 71628 RVA: 0x00603308 File Offset: 0x00601508
	public void PHKHIMHBCME()
	{
		this.roomNameInputField.text = UnityEngine.Random.Range(77, 170) + string.Empty;
		this.roomDescriptionInputField.text = "SpeedSlider" + SteamFriends.GetFriendPersonaName(SteamUser.GetSteamID());
		this.roomPrivateToggle.isOn = false;
	}

	// Token: 0x060117CD RID: 71629 RVA: 0x00603369 File Offset: 0x00601569
	public void JoinRoomByID(string JMMILEFMACB)
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		base.StartCoroutine(this.KJLFOJHECGL(JMMILEFMACB));
	}

	// Token: 0x060117CE RID: 71630 RVA: 0x0060338C File Offset: 0x0060158C
	public void ABIJHGFDJPD()
	{
		PhotonView photonView = base.EDIJKHEMPAD();
		string lblkdnnpaco = "_TimeX";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[0] = "#,0.00" + ResourcesManager.MDDNCHKAMDI(SteamUser.GetSteamID(), false) + "#forever";
		photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
		PhotonNetwork.LeaveRoom();
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.reciveLevelId = false;
		this.selectedlevelid = string.Empty;
		base.StopAllCoroutines();
		this.FCNKIGEPDFO();
		Singleton<MultiplayerSystem>.Instance.APEDOOJPKFC();
	}

	// Token: 0x060117CF RID: 71631 RVA: 0x00603434 File Offset: 0x00601634
	public void FDNCEFHNLNJ()
	{
		Debug.Log("Fade");
		if (this.reciveLevelId)
		{
			if (Singleton<MapsSystem>.Instance.GetMapData(this.selectedlevelid) != null && Singleton<MapsSystem>.Instance.GetMapData(this.selectedlevelid).source != FullMapData.MapSource.Editor)
			{
				if (GameObject.Find("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use"))
				{
					if (!this.CLMHNNMBCGB())
					{
						GameObject.Find("_Radius").GetComponentInChildren<Text>().text = ((PhotonNetwork.player.GetTeam() != PunTeams.Team.none) ? LocalizationService.Instance.GetTextByKey("Unsupported type: ").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("OpGetGameList not sent. LobbyType must be SqlLobby.").ToUpper());
					}
					else
					{
						GameObject.Find("Missing shader in ").GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient || !this.BLGNOEFJFKJ()) ? LocalizationService.Instance.GetTextByKey(" ").ToUpper() : LocalizationService.Instance.GetTextByKey("_Distortion").ToUpper());
					}
					GameObject.Find("No Dispatcher exists in the scene. Actions will not be invoked!").GetComponent<Button>().interactable = true;
				}
			}
			else if (GameObject.Find("_TimeX"))
			{
				GameObject.Find(",").GetComponentInChildren<Text>().text = LocalizationService.Instance.GetTextByKey("input").ToUpper() + "PublishButton";
				GameObject.Find("Added event").GetComponent<Button>().interactable = true;
			}
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("LevelInfoInputField", "_VelocityScale", PhotonNetwork.room.Name, PhotonNetwork.room.OFNKBGMDLPG(), PhotonNetwork.room.EGPGEMJNPFD(), PhotonNetwork.room.AOHMIPHOEBD());
	}

	// Token: 0x060117D0 RID: 71632 RVA: 0x00603604 File Offset: 0x00601804
	private IEnumerator DBAFIKLHOCG()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x060117D1 RID: 71633 RVA: 0x0060361F File Offset: 0x0060181F
	public void EFDIJDAFKCN(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.GHMOPFGCJAP(JKPJCEMPAGH);
	}

	// Token: 0x060117D2 RID: 71634 RVA: 0x0060362C File Offset: 0x0060182C
	public IEnumerator UpdateRooms()
	{
		base.StopCoroutine(this.UpdateRooms());
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("updating").ToUpper() + "...", LocalizationService.Instance.GetTextByKey("cancel").ToUpper(), new UnityAction(this.ExitToMenu), true, false, 0f);
		yield return new WaitForSeconds(0.5f);
		if (PhotonNetwork.insideLobby && this.roomsListContent)
		{
			Debug.Log("[NetworkManager] Updating rooms...");
			GameObject gameObject = this.roomsListContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			int num = 0;
			Debug.Log("[NetworkManager] Found " + PhotonNetwork.GetRoomList().Length + " room(s)");
			foreach (RoomInfo roomInfo in PhotonNetwork.GetRoomList())
			{
				Debug.Log("[NetworkManager] roomInfo.name: " + roomInfo.Name);
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.roomsListElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<RoomListItem>().roomInfo = roomInfo;
				ulong num2 = 0UL;
				try
				{
					num2 = ulong.Parse((string)roomInfo.CustomProperties["masterSteamID"]);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
				Sprite sprite = null;
				CSteamID csteamID = new CSteamID(num2);
				if (num2 != 0UL)
				{
					yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
					try
					{
						if (ResourcesManager.GetLoadedAvatar(csteamID))
						{
							sprite = ResourcesManager.GetLoadedAvatar(csteamID);
						}
					}
					catch (Exception)
					{
					}
				}
				if (gameObject2.transform.Find("AvatarImage"))
				{
					gameObject2.transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
				}
				if (gameObject2.transform.Find("RoomNameText"))
				{
					gameObject2.transform.Find("RoomNameText").GetComponent<Text>().text = roomInfo.Name;
				}
				if (gameObject2.transform.Find("RoomPlayersCountText"))
				{
					gameObject2.transform.Find("RoomPlayersCountText").GetComponent<Text>().text = roomInfo.PlayerCount + "/" + roomInfo.MaxPlayers;
				}
				if (gameObject2.transform.Find("RoomDescriptionText") && roomInfo.CustomProperties["roomDescription"] != null)
				{
					gameObject2.transform.Find("RoomDescriptionText").GetComponent<Text>().text = (string)roomInfo.CustomProperties["roomDescription"];
				}
				if (!roomInfo.IsOpen && gameObject2.transform.Find("JoinButton"))
				{
					gameObject2.transform.Find("JoinButton").GetComponent<Button>().interactable = false;
					gameObject2.transform.Find("JoinButton").GetComponent<Button>().GetComponentInChildren<Text>().text = "#alreadystarted";
				}
				num++;
			}
			if (num == 0)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.roomsMessageElement, Vector3.zero, Quaternion.identity);
				gameObject3.transform.SetParent(gameObject.transform, true);
				gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
				if (gameObject3.transform.Find("MessageText"))
				{
					gameObject3.transform.Find("MessageText").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("nogamesfound").ToUpper();
				}
			}
		}
		else
		{
			base.StopAllCoroutines();
		}
		yield return null;
		base.StopAllCoroutines();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield break;
	}

	// Token: 0x060117D3 RID: 71635 RVA: 0x00603648 File Offset: 0x00601848
	private IEnumerator BNFMECPNCOA(ulong LFLDPPGGLCL)
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + LFLDPPGGLCL;
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		}
		this.reciveLevelId = true;
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text, null);
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		this.UpdateRoom();
		this.lobbyPlayer.CheckIsReady();
		yield break;
	}

	// Token: 0x060117D4 RID: 71636 RVA: 0x0060366A File Offset: 0x0060186A
	public void InitProfileCanvas()
	{
		InventorySelector instance = Singleton<InventorySelector>.Instance;
		if (NetworkMenu.LNIJKGECNME == null)
		{
			NetworkMenu.LNIJKGECNME = new UnityAction(NetworkMenu.NNNDDGHDLCP);
		}
		base.StartCoroutine(instance.DisplayInventory(NetworkMenu.LNIJKGECNME));
	}

	// Token: 0x060117D5 RID: 71637 RVA: 0x0060369C File Offset: 0x0060189C
	public void OnReadyButton()
	{
		if (!this.IsAllPlayersReady())
		{
			if (PhotonNetwork.player.GetTeam() == PunTeams.Team.none)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", this.selectedlevelid, null);
				Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", this.selectedmodelid, null);
				this.lobbyPlayer.photonView.RPC("OnReadyClick", PhotonTargets.All, new object[]
				{
					PhotonNetwork.player
				});
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				this.lobbyPlayer.photonView.RPC("OnReadyClick", PhotonTargets.All, new object[]
				{
					PhotonNetwork.player
				});
			}
		}
		else if (PhotonNetwork.isMasterClient)
		{
			Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", this.selectedlevelid, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", this.selectedmodelid, null);
			PhotonNetwork.LoadLevel("GameScene");
			PhotonNetwork.room.IsOpen = false;
		}
	}

	// Token: 0x060117D6 RID: 71638 RVA: 0x006037A4 File Offset: 0x006019A4
	public void LeaveRoom()
	{
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.Others, new object[]
		{
			"[SERVER] Player " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID(), true) + " left"
		});
		PhotonNetwork.LeaveRoom();
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.reciveLevelId = false;
		this.selectedlevelid = string.Empty;
		base.StopAllCoroutines();
		this.OnConnectedToMaster();
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	// Token: 0x060117D7 RID: 71639 RVA: 0x0060384C File Offset: 0x00601A4C
	public void GPAOABPDKMI()
	{
		base.StartCoroutine(this.LGKIEDJKGDI());
	}

	// Token: 0x060117D8 RID: 71640 RVA: 0x0060385C File Offset: 0x00601A5C
	internal void AMIADFAHNDM(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.none);
			GameObject gameObject = this.playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i += 0)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = false;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				this.SendChatActionMessage("Set camera (or player) distance. Base player distance - 14" + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("VIGNETTE_DESAT", string.Empty).Replace("_Blend", string.Empty).Replace("CameraFilterPack/Colors_Adjust_FullColors", string.Empty));
				this.SendChatActionMessage("closed" + (GameScene.GameMode)DLGIPFOEDCF);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				this.reciveLevelId = true;
				this.UpdateRoom();
				this.lobbyPlayer.FIDKCPFLHEB();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				PublishedFileId_t lijpbbcjnhd = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("|", string.Empty));
				Singleton<MessageBoxPanel>.Instance.LKFALPEABHP(LocalizationService.Instance.GetTextByKey("/").ToUpper() + "DISTORT", LocalizationService.Instance.GetTextByKey("_Bloom1").ToUpper(), null, false, false, 1381f);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.HEGBGPNCAHA(new MapsSystem.MapSubscribedAndDownloadedEventHandler(this.IGKBKBNIFGL));
				Singleton<MapsSystem>.Instance.MMLOJFEBOHN(lijpbbcjnhd);
			}
		}
	}

	// Token: 0x060117D9 RID: 71641 RVA: 0x00603A10 File Offset: 0x00601C10
	[PunRPC]
	internal void ChangeSelectedLevel(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.none);
			GameObject gameObject = this.playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = false;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				this.SendChatActionMessage("[SERVER] Selected map: " + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty));
				this.SendChatActionMessage("[SERVER] Selected mode: " + (GameScene.GameMode)DLGIPFOEDCF);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				this.reciveLevelId = true;
				this.UpdateRoom();
				this.lobbyPlayer.CheckIsReady();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				PublishedFileId_t lijpbbcjnhd = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("workshop.", string.Empty));
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("downloading").ToUpper() + "...", LocalizationService.Instance.GetTextByKey("cancel").ToUpper(), null, false, false, 0f);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += this.HDKKLFLOHLD;
				Singleton<MapsSystem>.Instance.SubscribeAndDownload(lijpbbcjnhd);
			}
		}
	}

	// Token: 0x060117DA RID: 71642 RVA: 0x00603BC3 File Offset: 0x00601DC3
	private void HHDNKOFPEPO(GameRichPresenceJoinRequested_t OEJIJIPGMCO)
	{
		Debug.Log("ticket" + OEJIJIPGMCO.m_rgchConnect);
		this.JoinRoomByID(OEJIJIPGMCO.m_rgchConnect);
	}

	// Token: 0x060117DB RID: 71643 RVA: 0x00603BE8 File Offset: 0x00601DE8
	public void NOBNCNJKOLA()
	{
		this.isConnecting = true;
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.logLevel = PhotonLogLevel.Informational;
		PhotonNetwork.autoJoinLobby = false;
		PhotonNetwork.automaticallySyncScene = false;
		Singleton<MessageBoxPanel>.Instance.ILNLMMEOALM(LocalizationService.Instance.GetTextByKey("[MapsData] Found ").ToUpper() + "_ContrastGainGamma", LocalizationService.Instance.IAAEBJKAHDD("_Screen").ToUpper(), new UnityAction(this.DJJFPNBIHMD), true, false, 329f);
		if (PhotonNetwork.connected)
		{
			this.CHDPOPKEINF();
		}
		else
		{
			Debug.Log("?");
			PhotonNetwork.ConnectUsingSettings(Helpers.GetGameVersion());
		}
	}

	// Token: 0x060117DC RID: 71644 RVA: 0x00603C90 File Offset: 0x00601E90
	private IEnumerator DIBHMOMMNNG()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x060117DD RID: 71645 RVA: 0x00603CAB File Offset: 0x00601EAB
	public void ADAOECHPMLM(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.PHJEHMIGLOD(JKPJCEMPAGH);
	}

	// Token: 0x060117DE RID: 71646 RVA: 0x00603CB8 File Offset: 0x00601EB8
	[PunRPC]
	public void RecieveChatActionMessage(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}

	// Token: 0x060117DF RID: 71647 RVA: 0x00603CC5 File Offset: 0x00601EC5
	public void Exit()
	{
		this.isConnecting = false;
		base.StopAllCoroutines();
		base.StartCoroutine(this.Disconnect());
	}

	// Token: 0x060117E0 RID: 71648 RVA: 0x00603CE1 File Offset: 0x00601EE1
	public void GDGPGCEAGKN(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.BLMHOKPIMOD();
		string lblkdnnpaco = "DPADHOR";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[1] = JKPJCEMPAGH;
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x060117E1 RID: 71649 RVA: 0x00603CFE File Offset: 0x00601EFE
	public void JFFEHHLLDFG()
	{
		this.isConnecting = true;
		base.StopAllCoroutines();
		base.StartCoroutine(this.OOCNMBODPMG());
	}

	// Token: 0x060117E2 RID: 71650 RVA: 0x00603D1A File Offset: 0x00601F1A
	private void IPDJDLNOCLJ(GameRichPresenceJoinRequested_t OEJIJIPGMCO)
	{
		Debug.Log("mapselector.filter.rateduponly" + OEJIJIPGMCO.m_rgchConnect);
		this.JoinRoomByID(OEJIJIPGMCO.m_rgchConnect);
	}

	// Token: 0x060117E3 RID: 71651 RVA: 0x00603D40 File Offset: 0x00601F40
	public IEnumerator EKGMCMLMHJC()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu", null, null, null, 0, 0);
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
		yield break;
	}

	// Token: 0x060117E4 RID: 71652 RVA: 0x00603D5C File Offset: 0x00601F5C
	private IEnumerator LGKIEDJKGDI()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x060117E5 RID: 71653 RVA: 0x00603D78 File Offset: 0x00601F78
	private void IGKBKBNIFGL(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if ("_SunColor" + KJPAHOFPCKD.BAOHGANDHBD().ToString() == this.selectedlevelid)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= this.IGKBKBNIFGL;
			base.StartCoroutine(this.BNFMECPNCOA(KJPAHOFPCKD.ENDOGIJIIMN()));
		}
	}

	// Token: 0x060117E6 RID: 71654 RVA: 0x00603DDC File Offset: 0x00601FDC
	public void SendChatActionMessage(string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
		{
			JKPJCEMPAGH
		});
	}

	// Token: 0x060117E7 RID: 71655 RVA: 0x00603DFC File Offset: 0x00601FFC
	private IEnumerator LDCKKJOHMHE()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog(LocalizationService.Instance.GetLocalizatedText("#roomname"), LocalizationService.Instance.GetLocalizatedText("#join").ToUpper(), string.Empty, null));
		this.JoinRoomByID(Singleton<MessageBoxPanel>.Instance.textResult);
		yield break;
	}

	// Token: 0x060117E8 RID: 71656 RVA: 0x00603CB8 File Offset: 0x00601EB8
	public void GEHHOGACFND(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}

	// Token: 0x060117E9 RID: 71657 RVA: 0x00603E18 File Offset: 0x00602018
	public virtual void LFPIALDGOKI(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("_Value4");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Editing: ", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		}
		this.UpdateRoom();
	}

	// Token: 0x060117EA RID: 71658 RVA: 0x00603E62 File Offset: 0x00602062
	public void IKBMJEHCJBF()
	{
		InventorySelector instance = Singleton<InventorySelector>.Instance;
		if (NetworkMenu.LNIJKGECNME == null)
		{
			NetworkMenu.LNIJKGECNME = new UnityAction(NetworkMenu.CAKAOMKICAA);
		}
		base.StartCoroutine(instance.KDJBPKJFAKI(NetworkMenu.LNIJKGECNME));
	}

	// Token: 0x060117EB RID: 71659 RVA: 0x00603E94 File Offset: 0x00602094
	public virtual void CJJAMKNIOOF()
	{
		Singleton<MessageBoxPanel>.Instance.FCNDDFJNFPH(-1, null);
		Debug.Log("[PlayerController] " + PhotonNetwork.room.DHOGHIOACME() + "_MainTex2");
		Singleton<MultiplayerSystem>.Instance.DGPGGBAKKJO("InventoryButton" + PhotonNetwork.room.OFNKBGMDLPG());
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.BGKEBGKLIOK();
		PhotonView photonView = base.photonView;
		string lblkdnnpaco = "FinalScoreSmallText";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[1];
		array[1] = " / Sample Count: " + ResourcesManager.ALCCOCOFLAK(SteamUser.GetSteamID(), true) + "sounds/hit_wrong";
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
		this.reciveLevelId = false;
		this.lobbyCanvas.SetActive(false);
		this.networkCanvas.SetActive(false);
		GameObject.Find("ItemNameText").GetComponent<Button>().interactable = true;
		if (GameObject.Find("UI Extensions/UIScreen"))
		{
			GameObject.Find("SpawnObj").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.EJGBOJDDMHH("Working.\nPlease wait..", "Joystick1Button7", PhotonNetwork.room.OFNKBGMDLPG(), PhotonNetwork.room.POPKEPNKIAO(), PhotonNetwork.room.EGPGEMJNPFD(), PhotonNetwork.room.MaxPlayers);
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("CameraFilterPack/Blend2Camera_DarkerColor", new Vector3(980f, 780f, 988f), Quaternion.identity, 0);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1698f, 1113f, 147f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.GDJMBJEAPHM();
		this.FDNCEFHNLNJ();
		base.JAEJDHHCJJO().PBMFBOOALKA("Default UI Material", PhotonTargets.AllBufferedViaServer, new object[0]);
	}

	// Token: 0x060117EC RID: 71660 RVA: 0x0002523B File Offset: 0x0002343B
	private static void NAFJHMACIOC()
	{
	}

	// Token: 0x060117ED RID: 71661 RVA: 0x00604060 File Offset: 0x00602260
	public void CEFGDJNHHII()
	{
		Singleton<MessageBoxPanel>.Instance.ILNLMMEOALM(LocalizationService.Instance.IAAEBJKAHDD("Texture3").ToUpper() + "_TimeX", "ENABLE_USER_LUT", null, false, true, 562f);
		string[] array = new string[3];
		array[1] = "true";
		array[1] = ".completed";
		RoomOptions dpodhcmgcpf = new RoomOptions
		{
			IsVisible = this.roomPrivateToggle.isOn,
			MaxPlayers = (byte)-88,
			CustomRoomPropertiesForLobby = array,
			CleanupCacheOnLeave = true
		};
		PhotonNetwork.JoinOrCreateRoom((!string.IsNullOrEmpty(this.roomNameInputField.text)) ? this.roomNameInputField.text : (UnityEngine.Random.Range(-62, 182) + string.Empty), dpodhcmgcpf, TypedLobby.Default);
	}

	// Token: 0x060117EE RID: 71662 RVA: 0x0060413C File Offset: 0x0060233C
	public void KPHPJLODFDO()
	{
		this.isConnecting = false;
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.logLevel = PhotonLogLevel.Informational;
		PhotonNetwork.autoJoinLobby = false;
		PhotonNetwork.automaticallySyncScene = false;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey(" not exist").ToUpper() + "/", LocalizationService.Instance.GetTextByKey("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.").ToUpper(), new UnityAction(this.DJJFPNBIHMD), false, true, 751f);
		if (PhotonNetwork.connected)
		{
			this.OnConnectedToMaster();
		}
		else
		{
			Debug.Log("_TimeX");
			PhotonNetwork.ConnectUsingSettings(Helpers.GetGameVersion());
		}
	}

	// Token: 0x060117EF RID: 71663 RVA: 0x006041E4 File Offset: 0x006023E4
	private IEnumerator GNPJOODGNLO()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x060117F0 RID: 71664 RVA: 0x00604200 File Offset: 0x00602400
	private IEnumerator PIJEPBMKMAJ(string OIFIJMAEAFO)
	{
		this.OnJoinedRoom();
		if (PhotonNetwork.insideLobby)
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		else
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			while (!PhotonNetwork.insideLobby)
			{
				yield return new WaitForSeconds(0.1f);
			}
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		yield break;
	}

	// Token: 0x060117F1 RID: 71665 RVA: 0x00604222 File Offset: 0x00602422
	public void SendChatMessage(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatMessage", PhotonTargets.AllViaServer, new object[]
		{
			string.Empty + BHNGOLDNELC,
			JKPJCEMPAGH
		});
	}

	// Token: 0x060117F2 RID: 71666 RVA: 0x00604252 File Offset: 0x00602452
	public void NBOMCOFDKFH()
	{
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x060117F3 RID: 71667 RVA: 0x00604264 File Offset: 0x00602464
	public override void OnJoinedRoom()
	{
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		Debug.Log("[NetworkManager] Joined room with " + PhotonNetwork.room.PlayerCount + " player(s)");
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage("Joined room " + PhotonNetwork.room.Name);
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.InitChat();
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.Others, new object[]
		{
			"[SERVER] Player " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID(), true) + " joined"
		});
		this.reciveLevelId = false;
		this.lobbyCanvas.SetActive(true);
		this.networkCanvas.SetActive(false);
		GameObject.Find("StartButton").GetComponent<Button>().interactable = false;
		if (GameObject.Find("ChatHistoryInputField"))
		{
			GameObject.Find("ChatHistoryInputField").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Network lobby", "Waiting to start", PhotonNetwork.room.Name, PhotonNetwork.room.Name, PhotonNetwork.room.PlayerCount, PhotonNetwork.room.MaxPlayers);
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("Gameplay/LobbyPlayerIconElement", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.Init();
		this.UpdateRoom();
		base.photonView.RPC("RequestSelectedLevel", PhotonTargets.MasterClient, new object[0]);
	}

	// Token: 0x060117F4 RID: 71668 RVA: 0x00604430 File Offset: 0x00602630
	public virtual void JHHPHEAAJLD()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("Event Received", this.roomDescriptionInputField.text);
		hashtable.Add("_MainTex2", PhotonNetwork.playerName);
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x060117F5 RID: 71669 RVA: 0x00604478 File Offset: 0x00602678
	private void HDKKLFLOHLD(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if ("workshop." + KJPAHOFPCKD.id.ToString() == this.selectedlevelid)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= this.HDKKLFLOHLD;
			base.StartCoroutine(this.BNFMECPNCOA(KJPAHOFPCKD.id));
		}
	}

	// Token: 0x060117F6 RID: 71670 RVA: 0x00604252 File Offset: 0x00602452
	public void OnUpdateRoomsButton()
	{
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x060117F7 RID: 71671 RVA: 0x006044DC File Offset: 0x006026DC
	public void BJFEKODCLGJ(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.EOOCGIFFKBG();
		string lblkdnnpaco = "OpAuthenticate()";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
		object[] array = new object[6];
		array[1] = string.Empty + BHNGOLDNELC;
		array[0] = JKPJCEMPAGH;
		photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x060117F8 RID: 71672 RVA: 0x0060450C File Offset: 0x0060270C
	public virtual void PIJBLFBJMBG()
	{
		Singleton<MessageBoxPanel>.Instance.PALFHOFEKEG(-1, null);
		Debug.Log("_Amount" + PhotonNetwork.room.DHOGHIOACME() + "LoadPlayerSkin");
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage("DISTORT" + PhotonNetwork.room.OFNKBGMDLPG());
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.KHEAOFLJPFM();
		PhotonView photonView = base.GMAHNPNHMFK();
		string lblkdnnpaco = "CameraFilterPack/TV_Artefact";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[1];
		array[1] = "_SpotSize" + ResourcesManager.ALCCOCOFLAK(SteamUser.GetSteamID(), false) + " is set to dontSave = true, continuing loop.";
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
		this.reciveLevelId = true;
		this.lobbyCanvas.SetActive(true);
		this.networkCanvas.SetActive(true);
		GameObject.Find("[PlayerController] ").GetComponent<Button>().interactable = false;
		if (GameObject.Find("GlassesColor2"))
		{
			GameObject.Find("EventMenu").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.PDNPNJNFDGL("_MatrixSpeed", "_MainTex2", PhotonNetwork.room.GJCOLGAHAIO(), PhotonNetwork.room.GJCOLGAHAIO(), PhotonNetwork.room.PlayerCount, PhotonNetwork.room.DEICKHNCDML());
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("Coroutine container not configured... did you forget to call Init?", new Vector3(215f, 1022f, 1394f), Quaternion.identity, 0);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(510f, 771f, 1898f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.BKLCHHKOMLD();
		this.NPAELKPFIKP();
		base.GBHNDHLAJLI().IKIJDNPJKPM("#rt", PhotonTargets.AllViaServer, new object[1]);
	}

	// Token: 0x060117F9 RID: 71673 RVA: 0x006046D8 File Offset: 0x006028D8
	public virtual void HLKNINOPDNG()
	{
		if (this.isConnecting)
		{
			Debug.Log("_Far" + PhotonNetwork.JNJJAMNLOHA.CloudRegion + "Triangle");
			PhotonNetwork.LeaveLobby();
			PhotonNetwork.JoinLobby();
		}
	}

	// Token: 0x060117FA RID: 71674 RVA: 0x00604714 File Offset: 0x00602914
	public void OnJoinByRoomName()
	{
		base.StartCoroutine(this.IPCGDACEHIO());
	}

	// Token: 0x060117FB RID: 71675 RVA: 0x00604724 File Offset: 0x00602924
	public void OOLEFFFOMGF()
	{
		if (!this.CLMHNNMBCGB())
		{
			if (PhotonNetwork.player.GetTeam() == PunTeams.Team.none)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				Singleton<SaveSystem>.Instance.NOEIPDOLJFA("[PlayerBase] MapEnd error: ", this.selectedlevelid, null);
				Singleton<SaveSystem>.Instance.SetInt(".lastCheckpoint.lives", this.selectedmodelid, null);
				PhotonView photonView = this.lobbyPlayer.CIACEFBNDDJ();
				string lblkdnnpaco = "workshop.";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[1];
				array[1] = PhotonNetwork.player;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				PhotonView photonView2 = this.lobbyPlayer.GMAHNPNHMFK();
				string lblkdnnpaco2 = "#close";
				PhotonTargets mpnmoonbmii2 = PhotonTargets.Others;
				object[] array2 = new object[0];
				array2[0] = PhotonNetwork.player;
				photonView2.IKIJDNPJKPM(lblkdnnpaco2, mpnmoonbmii2, array2);
			}
		}
		else if (PhotonNetwork.isMasterClient)
		{
			Singleton<SaveSystem>.Instance.DAGHAOBCIFL("#done", this.selectedlevelid, null);
			Singleton<SaveSystem>.Instance.SetInt("X2", this.selectedmodelid, null);
			PhotonNetwork.LoadLevel("CameraFilterPack_AAA_Blood_Hit1");
			PhotonNetwork.room.AOFIBMMLNAA(true);
		}
	}

	// Token: 0x060117FC RID: 71676 RVA: 0x0060482A File Offset: 0x00602A2A
	[PunRPC]
	public void RecieveChatMessage(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x060117FD RID: 71677 RVA: 0x00604842 File Offset: 0x00602A42
	private void JGGENJBJNKO(GameRichPresenceJoinRequested_t OEJIJIPGMCO)
	{
		Debug.Log("ShowSprite" + OEJIJIPGMCO.m_rgchConnect);
		this.JoinRoomByID(OEJIJIPGMCO.m_rgchConnect);
	}

	// Token: 0x060117FE RID: 71678 RVA: 0x00604868 File Offset: 0x00602A68
	public virtual void GMKMLFAIIAJ()
	{
		Singleton<MessageBoxPanel>.Instance.GIKJIFGFMFP(-1, null);
		Debug.Log("[PlayerBase] MapEnd error: " + PhotonNetwork.room.PlayerCount + "0");
		Singleton<MultiplayerSystem>.Instance.ONAHBFAMBPE("tagElement" + PhotonNetwork.room.OFNKBGMDLPG());
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.BLMACALKKHH();
		PhotonView photonView = base.OELHGNKAMEG();
		string lblkdnnpaco = "settings.volume.menu";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[1];
		array[1] = "The number of players playing your game: " + ResourcesManager.ALCCOCOFLAK(SteamUser.GetSteamID(), true) + "Bad modpack name: {0}";
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
		this.reciveLevelId = true;
		this.lobbyCanvas.SetActive(false);
		this.networkCanvas.SetActive(false);
		GameObject.Find("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.").GetComponent<Button>().interactable = true;
		if (GameObject.Find("_Value2"))
		{
			GameObject.Find("CameraFilterPack_3D_Myst1").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("_ScreenResolution", "mapselector.orderby", PhotonNetwork.room.OFNKBGMDLPG(), PhotonNetwork.room.GJCOLGAHAIO(), PhotonNetwork.room.PlayerCount, PhotonNetwork.room.BAEAAGJIHNJ());
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("_Value", new Vector3(229f, 1590f, 105f), Quaternion.identity, 0);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(982f, 1664f, 1139f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.MDPJHKECLOF();
		this.NPAELKPFIKP();
		base.FFIPLLNKGEN().MIAHMDGOOPJ("menu.selectedmode", PhotonTargets.AllBuffered, new object[0]);
	}

	// Token: 0x06011800 RID: 71680 RVA: 0x00604A47 File Offset: 0x00602C47
	public void MFAMHKBMBEI()
	{
		this.BPKBDDEPHFK = Callback<GameRichPresenceJoinRequested_t>.Create(new Callback<GameRichPresenceJoinRequested_t>.DispatchDelegate(this.IPDJDLNOCLJ));
	}

	// Token: 0x06011801 RID: 71681 RVA: 0x00604A60 File Offset: 0x00602C60
	public virtual void GICALGKGLJC()
	{
		Debug.Log(" region");
		Singleton<GameManager>.Instance.MKGBAKICGOA("isVisible", null, null, null, 0, 1);
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "Editor/";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.none);
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x06011802 RID: 71682 RVA: 0x00604B1C File Offset: 0x00602D1C
	public void PBBDHIFJHHC()
	{
		this.isConnecting = true;
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.logLevel = PhotonLogLevel.ErrorsOnly;
		PhotonNetwork.autoJoinLobby = true;
		PhotonNetwork.automaticallySyncScene = true;
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC(LocalizationService.Instance.GetTextByKey("EventMenu").ToUpper() + "_BlurPass", LocalizationService.Instance.IAAEBJKAHDD("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp").ToUpper(), new UnityAction(this.DJJFPNBIHMD), true, false, 195f);
		if (PhotonNetwork.connected)
		{
			this.OnConnectedToMaster();
		}
		else
		{
			Debug.Log("_ToPrevViewProjCombined");
			PhotonNetwork.ConnectUsingSettings(Helpers.GetGameVersion());
		}
	}

	// Token: 0x06011803 RID: 71683 RVA: 0x00604BC4 File Offset: 0x00602DC4
	public bool CDHACJOOEDE()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer jhoedacnnkk = playerList[i];
			if (jhoedacnnkk.GetTeam() == PunTeams.Team.none)
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06011804 RID: 71684 RVA: 0x00604C00 File Offset: 0x00602E00
	public virtual void CPIBIOIPEJG()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("[PlayerBase] Loaded spawner data", this.roomDescriptionInputField.text);
		hashtable.Add("Right Click", PhotonNetwork.playerName);
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	// Token: 0x06011805 RID: 71685 RVA: 0x00604C48 File Offset: 0x00602E48
	public void UpdateRoom()
	{
		Debug.Log("[NetworkManager] Updating current room...");
		if (this.reciveLevelId)
		{
			if (Singleton<MapsSystem>.Instance.GetMapData(this.selectedlevelid) != null && Singleton<MapsSystem>.Instance.GetMapData(this.selectedlevelid).source != FullMapData.MapSource.Editor)
			{
				if (GameObject.Find("StartButton"))
				{
					if (!this.IsAllPlayersReady())
					{
						GameObject.Find("StartButton").GetComponentInChildren<Text>().text = ((PhotonNetwork.player.GetTeam() != PunTeams.Team.none) ? LocalizationService.Instance.GetTextByKey("notready").ToUpper() : LocalizationService.Instance.GetTextByKey("ready").ToUpper());
					}
					else
					{
						GameObject.Find("StartButton").GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient || !this.IsAllPlayersReady()) ? LocalizationService.Instance.GetTextByKey("ready").ToUpper() : LocalizationService.Instance.GetTextByKey("start").ToUpper());
					}
					GameObject.Find("StartButton").GetComponent<Button>().interactable = true;
				}
			}
			else if (GameObject.Find("StartButton"))
			{
				GameObject.Find("StartButton").GetComponentInChildren<Text>().text = LocalizationService.Instance.GetTextByKey("downloading").ToUpper() + "...";
				GameObject.Find("StartButton").GetComponent<Button>().interactable = false;
			}
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Network lobby", "Waiting to start", PhotonNetwork.room.Name, PhotonNetwork.room.Name, PhotonNetwork.room.PlayerCount, PhotonNetwork.room.MaxPlayers);
	}

	// Token: 0x06011806 RID: 71686 RVA: 0x00604E18 File Offset: 0x00603018
	public void NPAELKPFIKP()
	{
		Debug.Log("_TimeX");
		if (this.reciveLevelId)
		{
			if (Singleton<MapsSystem>.Instance.GetMapData(this.selectedlevelid) != null && Singleton<MapsSystem>.Instance.GetMapData(this.selectedlevelid).source != FullMapData.MapSource.Editor)
			{
				if (GameObject.Find("_Value"))
				{
					if (!this.IsAllPlayersReady())
					{
						GameObject.Find("CameraFilterPack/Distortion_Dissipation").GetComponentInChildren<Text>().text = ((PhotonNetwork.player.GetTeam() != PunTeams.Team.none) ? LocalizationService.Instance.IAAEBJKAHDD("_EmissionGain").ToUpper() : LocalizationService.Instance.GetTextByKey("EnvironmentSlider").ToUpper());
					}
					else
					{
						GameObject.Find("menutheme.coldheat").GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient || !this.CLMHNNMBCGB()) ? LocalizationService.Instance.GetTextByKey("[PlayerController] ").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("CameraFilterPack/Colors_Adjust_FullColors").ToUpper());
					}
					GameObject.Find("[GameScene] Checkpoints count: ").GetComponent<Button>().interactable = true;
				}
			}
			else if (GameObject.Find("float,1"))
			{
				GameObject.Find("OpLeaveLobby()").GetComponentInChildren<Text>().text = LocalizationService.Instance.GetTextByKey("type").ToUpper() + "PlayMusic";
				GameObject.Find("Tried to Initialize the SteamAPI twice in one session!").GetComponent<Button>().interactable = false;
			}
		}
		Singleton<GameManager>.Instance.EJGBOJDDMHH("Editor", "Bad parameters for setstring! Use <key> <value>", PhotonNetwork.room.Name, PhotonNetwork.room.GJCOLGAHAIO(), PhotonNetwork.room.DHOGHIOACME(), PhotonNetwork.room.DDDIFAMCNDO());
	}

	// Token: 0x06011807 RID: 71687 RVA: 0x00604FE8 File Offset: 0x006031E8
	public virtual void CPIGOIKNCHP()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("_Screen", this.roomDescriptionInputField.text);
		hashtable.Add("Error0", PhotonNetwork.playerName);
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x06011808 RID: 71688 RVA: 0x00605030 File Offset: 0x00603230
	private void EOCCIPEKJEL(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if ("LoadPlayerSkin" + KJPAHOFPCKD.KBMEBAACODH().ToString() == this.selectedlevelid)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= this.HDKKLFLOHLD;
			base.StartCoroutine(this.BNFMECPNCOA(KJPAHOFPCKD.CHDCIFPPIFI()));
		}
	}

	// Token: 0x06011809 RID: 71689 RVA: 0x00605094 File Offset: 0x00603294
	public virtual void JKNOPMDDLML()
	{
		Singleton<MessageBoxPanel>.Instance.FCNDDFJNFPH(-1, null);
		Debug.Log("#no" + PhotonNetwork.room.EGPGEMJNPFD() + ").");
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage("finished" + PhotonNetwork.room.POPKEPNKIAO());
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.BGKEBGKLIOK();
		base.EDIJKHEMPAD().GNFNHDCJOFC("_Strength", PhotonTargets.All, new object[]
		{
			"settings.volume.sfx" + ResourcesManager.NCPKEIIHELP(SteamUser.GetSteamID(), false) + "Sprite"
		});
		this.reciveLevelId = true;
		this.lobbyCanvas.SetActive(false);
		this.networkCanvas.SetActive(false);
		GameObject.Find("Game Version: ").GetComponent<Button>().interactable = false;
		if (GameObject.Find("/Saved Games/"))
		{
			GameObject.Find("RemoveHighlight").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("float,2", "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", PhotonNetwork.room.OFNKBGMDLPG(), PhotonNetwork.room.POPKEPNKIAO(), PhotonNetwork.room.PlayerCount, PhotonNetwork.room.DDDIFAMCNDO());
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("error", new Vector3(569f, 1843f, 1190f), Quaternion.identity, 1);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1763f, 1944f, 30f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.GDJMBJEAPHM();
		this.NPAELKPFIKP();
		base.GMAHNPNHMFK().MIAHMDGOOPJ("s", PhotonTargets.AllBuffered, new object[0]);
	}

	// Token: 0x0601180A RID: 71690 RVA: 0x00605260 File Offset: 0x00603460
	public void DFKLECMNBFA()
	{
		PhotonView photonView = base.JAEJDHHCJJO();
		string lblkdnnpaco = "[PlayerController] ";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[1];
		array[1] = "Emergency Help:" + ResourcesManager.ALCCOCOFLAK(SteamUser.GetSteamID(), true) + "s";
		photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
		PhotonNetwork.LeaveRoom();
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.reciveLevelId = false;
		this.selectedlevelid = string.Empty;
		base.StopAllCoroutines();
		this.DHINPANGALG();
		Singleton<MultiplayerSystem>.Instance.HCIFGHPJKIB();
	}

	// Token: 0x0601180B RID: 71691 RVA: 0x00605308 File Offset: 0x00603508
	public void CAKAJNHFOBI()
	{
		base.StartCoroutine(this.NCOGMGLNMJM());
	}

	// Token: 0x0601180C RID: 71692 RVA: 0x00605318 File Offset: 0x00603518
	public virtual void OKAHNIHFAOA()
	{
		Debug.Log("#no");
		Singleton<GameManager>.Instance.UpdateOnlineStatus("CameraFilterPack/Gradients_FireGradient", null, null, null, 1, 0);
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "_TimeX";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.none);
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x0601180D RID: 71693 RVA: 0x006053D4 File Offset: 0x006035D4
	public IEnumerator HDINOONCLOP()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu", null, null, null, 0, 0);
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
		yield break;
	}

	// Token: 0x0601180E RID: 71694 RVA: 0x006053F0 File Offset: 0x006035F0
	private IEnumerator OGPPMOJBEKL(string OIFIJMAEAFO)
	{
		this.OnJoinedRoom();
		if (PhotonNetwork.insideLobby)
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		else
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			while (!PhotonNetwork.insideLobby)
			{
				yield return new WaitForSeconds(0.1f);
			}
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
		}
		yield break;
	}

	// Token: 0x0601180F RID: 71695 RVA: 0x00605414 File Offset: 0x00603614
	public void DJJFPNBIHMD()
	{
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.MKGBAKICGOA("_FinalReflectionTexture", null, null, null, 0, 0);
		if (GameObject.Find("[DiscordController] Error {0}: {1}"))
		{
			GameObject.Find("powerup.1").transform.Find("Bass").GetComponent<Button>().onClick.Invoke();
		}
	}

	// Token: 0x06011810 RID: 71696 RVA: 0x00605477 File Offset: 0x00603677
	public override void OnPhotonRandomJoinFailed(object[] APELDCFFFOH)
	{
		Debug.Log("[NetworkManager] Join failed");
	}

	// Token: 0x06011811 RID: 71697 RVA: 0x00605483 File Offset: 0x00603683
	public virtual void EMJBCIFMAID(object[] APELDCFFFOH)
	{
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("Waiting to start" + APELDCFFFOH[1], ": ", null, true, false, 1390f);
		Debug.LogError("_Value2" + APELDCFFFOH[1]);
	}

	// Token: 0x06011812 RID: 71698 RVA: 0x0060482A File Offset: 0x00602A2A
	public void GILIKKHONMA(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011813 RID: 71699 RVA: 0x006054BC File Offset: 0x006036BC
	public bool BLGNOEFJFKJ()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer jhoedacnnkk = playerList[i];
			if (jhoedacnnkk.GetTeam() == PunTeams.Team.none)
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011814 RID: 71700 RVA: 0x006054F8 File Offset: 0x006036F8
	public void GANLMBAFJAO()
	{
		this.roomNameInputField.text = UnityEngine.Random.Range(-76, -33) + string.Empty;
		this.roomDescriptionInputField.text = "OxOD.lastPath" + SteamFriends.GetFriendPersonaName(SteamUser.GetSteamID());
		this.roomPrivateToggle.isOn = true;
	}

	// Token: 0x06011815 RID: 71701 RVA: 0x0060555C File Offset: 0x0060375C
	public virtual void FGNOHCFMPDA(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("_Value");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("[EMPTY]", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		}
		this.NPAELKPFIKP();
	}

	// Token: 0x06011816 RID: 71702 RVA: 0x006055A6 File Offset: 0x006037A6
	public void ODHNNDCGOJH(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.BLMHOKPIMOD();
		string lblkdnnpaco = " now: ";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[]
		{
			null,
			string.Empty + BHNGOLDNELC
		};
		array[0] = JKPJCEMPAGH;
		photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011817 RID: 71703 RVA: 0x006055D8 File Offset: 0x006037D8
	public virtual void AHIBJHDPAFD()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("_EmissionColor", this.roomDescriptionInputField.text);
		hashtable.Add("Reading preview file failed!: \"{0}\"", PhotonNetwork.playerName);
		PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
	}

	// Token: 0x06011818 RID: 71704 RVA: 0x0002523B File Offset: 0x0002343B
	private static void CAKAOMKICAA()
	{
	}

	// Token: 0x06011819 RID: 71705 RVA: 0x0060561E File Offset: 0x0060381E
	public void KPJOEDDBFHB(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.CIACEFBNDDJ();
		string lblkdnnpaco = "id";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
		object[] array = new object[6];
		array[1] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0601181A RID: 71706 RVA: 0x00605650 File Offset: 0x00603850
	internal void IGMMDOKIBGJ(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.red);
			GameObject gameObject = this.playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = true;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				this.SendChatActionMessage("{0:0} minute{1}, " + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("Menu", string.Empty).Replace("DataText", string.Empty).Replace("ready", string.Empty));
				this.GDGPGCEAGKN("win" + (GameScene.GameMode)DLGIPFOEDCF);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				this.reciveLevelId = true;
				this.FDNCEFHNLNJ();
				this.lobbyPlayer.NJDAJMNCPIA();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				PublishedFileId_t lijpbbcjnhd = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("_AlphaHexa", string.Empty));
				Singleton<MessageBoxPanel>.Instance.AGMKJJLMOHG(LocalizationService.Instance.GetTextByKey("SpawnObj").ToUpper() + "CameraFilterPack/TV_LED", LocalizationService.Instance.GetTextByKey("colorC").ToUpper(), null, false, true, 347f);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.NMOMJBGOLNB(new MapsSystem.MapSubscribedAndDownloadedEventHandler(this.IGKBKBNIFGL));
				Singleton<MapsSystem>.Instance.MMLOJFEBOHN(lijpbbcjnhd);
			}
		}
	}

	// Token: 0x0601181B RID: 71707 RVA: 0x00605804 File Offset: 0x00603A04
	public bool IsAllPlayersReady()
	{
		bool result = true;
		foreach (PhotonPlayer jhoedacnnkk in PhotonNetwork.playerList)
		{
			if (jhoedacnnkk.GetTeam() == PunTeams.Team.none)
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0601181C RID: 71708 RVA: 0x00605840 File Offset: 0x00603A40
	private IEnumerator EDMAINKFEFC()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x0601181D RID: 71709 RVA: 0x0060585C File Offset: 0x00603A5C
	public void InitRoomCreator()
	{
		this.roomNameInputField.text = UnityEngine.Random.Range(10000000, 99999999) + string.Empty;
		this.roomDescriptionInputField.text = "Created by " + SteamFriends.GetFriendPersonaName(SteamUser.GetSteamID());
		this.roomPrivateToggle.isOn = false;
	}

	// Token: 0x0601181E RID: 71710 RVA: 0x0002523B File Offset: 0x0002343B
	[CompilerGenerated]
	private static void NNNDDGHDLCP()
	{
	}

	// Token: 0x0601181F RID: 71711 RVA: 0x006058BD File Offset: 0x00603ABD
	public void IMNMEBIEAPH()
	{
		InventorySelector instance = Singleton<InventorySelector>.Instance;
		if (NetworkMenu.LNIJKGECNME == null)
		{
			NetworkMenu.LNIJKGECNME = new UnityAction(NetworkMenu.NNNDDGHDLCP);
		}
		base.StartCoroutine(instance.KDJBPKJFAKI(NetworkMenu.LNIJKGECNME));
	}

	// Token: 0x06011820 RID: 71712 RVA: 0x00604714 File Offset: 0x00602914
	public void EKKCGFEACCB()
	{
		base.StartCoroutine(this.IPCGDACEHIO());
	}

	// Token: 0x06011821 RID: 71713 RVA: 0x006058F0 File Offset: 0x00603AF0
	public void CMLLPMJLCAK()
	{
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.PDNPNJNFDGL("[PlayerController] ", null, null, null, 0, 1);
		if (GameObject.Find("OnStatusChanged: {0} current State: {1}"))
		{
			GameObject.Find("_Near").transform.Find("_CameraWS").GetComponent<Button>().onClick.Invoke();
		}
	}

	// Token: 0x06011822 RID: 71714 RVA: 0x00605954 File Offset: 0x00603B54
	public virtual void LOOGFAAHILO()
	{
		Debug.Log("[");
		Singleton<GameManager>.Instance.EJGBOJDDMHH("_Value3", null, null, null, 1, 1);
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "_ScreenResolution";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.red);
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x06011823 RID: 71715 RVA: 0x00605A10 File Offset: 0x00603C10
	public void LOMAFFEDACB()
	{
		base.StartCoroutine(this.LBLPBKEBNNI());
	}

	// Token: 0x06011824 RID: 71716 RVA: 0x00605A20 File Offset: 0x00603C20
	private IEnumerator NGEGBKDDFPA()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x06011825 RID: 71717 RVA: 0x00605A3C File Offset: 0x00603C3C
	public virtual void FEIJFPOFEHA()
	{
		Singleton<MessageBoxPanel>.Instance.PALFHOFEKEG(-1, null);
		Debug.Log("achievements.21.progress" + PhotonNetwork.room.DHOGHIOACME() + "float,1");
		Singleton<MultiplayerSystem>.Instance.ONAHBFAMBPE("Done!" + PhotonNetwork.room.POPKEPNKIAO());
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.OCIJFGFDDCI();
		PhotonView photonView = base.GMAHNPNHMFK();
		string lblkdnnpaco = "workshop.";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[0] = "SetSunMinSize" + ResourcesManager.IPFFGAILCED(SteamUser.GetSteamID(), true) + "id";
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
		this.reciveLevelId = false;
		this.lobbyCanvas.SetActive(false);
		this.networkCanvas.SetActive(false);
		GameObject.Find("_TimeX").GetComponent<Button>().interactable = true;
		if (GameObject.Find("Drop_With_Obj"))
		{
			GameObject.Find("achievements.26.progress").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("OnAwakeRPC", "/", PhotonNetwork.room.Name, PhotonNetwork.room.POPKEPNKIAO(), PhotonNetwork.room.EGPGEMJNPFD(), PhotonNetwork.room.MaxPlayers);
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("_SpotSize", new Vector3(1326f, 468f, 991f), Quaternion.identity, 0);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1852f, 316f, 330f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.GDJMBJEAPHM();
		this.FDNCEFHNLNJ();
		base.EDIJKHEMPAD().GNFNHDCJOFC("_AdditiveReflection", PhotonTargets.AllViaServer, new object[0]);
	}

	// Token: 0x06011826 RID: 71718 RVA: 0x00605C08 File Offset: 0x00603E08
	private IEnumerator IPCGDACEHIO()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog(LocalizationService.Instance.GetLocalizatedText("#roomname"), LocalizationService.Instance.GetLocalizatedText("#join").ToUpper(), string.Empty, null));
		this.JoinRoomByID(Singleton<MessageBoxPanel>.Instance.textResult);
		yield break;
	}

	// Token: 0x06011827 RID: 71719 RVA: 0x00605C23 File Offset: 0x00603E23
	[PunRPC]
	internal void RequestSelectedLevel()
	{
		base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllViaServer, new object[]
		{
			this.selectedlevelid,
			this.selectedmodelid
		});
	}

	// Token: 0x06011828 RID: 71720 RVA: 0x00605C53 File Offset: 0x00603E53
	public void BMFOPFIIBPD()
	{
		base.StartCoroutine(this.HBKFEHBOKGL());
	}

	// Token: 0x06011829 RID: 71721 RVA: 0x00605C62 File Offset: 0x00603E62
	private void DOKFAFHFBEO(GameRichPresenceJoinRequested_t OEJIJIPGMCO)
	{
		Debug.Log("[NetworkMenu] Joining " + OEJIJIPGMCO.m_rgchConnect);
		this.JoinRoomByID(OEJIJIPGMCO.m_rgchConnect);
	}

	// Token: 0x0601182A RID: 71722 RVA: 0x00605C88 File Offset: 0x00603E88
	public void BFDHFHPANCL()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL(LocalizationService.Instance.IAAEBJKAHDD("CameraFilterPack/Colors_DarkColor").ToUpper() + "CameraFilterPack_Paper4", "_Value", null, true, false, 1875f);
		string[] array = new string[6];
		array[1] = "_EmissionColor";
		array[1] = "Color";
		RoomOptions dpodhcmgcpf = new RoomOptions
		{
			IsVisible = !this.roomPrivateToggle.isOn,
			MaxPlayers = 5,
			CustomRoomPropertiesForLobby = array,
			CleanupCacheOnLeave = false
		};
		PhotonNetwork.JoinOrCreateRoom((!string.IsNullOrEmpty(this.roomNameInputField.text)) ? this.roomNameInputField.text : (UnityEngine.Random.Range(-198, 104) + string.Empty), dpodhcmgcpf, TypedLobby.Default);
	}

	// Token: 0x0601182B RID: 71723 RVA: 0x00605D62 File Offset: 0x00603F62
	public virtual void MOMFHGJNBFG(object[] APELDCFFFOH)
	{
		Debug.Log("menutheme.hunter");
	}

	// Token: 0x0601182C RID: 71724 RVA: 0x00605D6E File Offset: 0x00603F6E
	public void EGEJEGMHMPD(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.photonView;
		string lblkdnnpaco = "_Color";
		PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
		object[] array = new object[0];
		array[1] = JKPJCEMPAGH;
		photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0601182D RID: 71725 RVA: 0x00605D8C File Offset: 0x00603F8C
	public virtual void MHJIOFCPMAI()
	{
		Debug.Log("note.6");
		Singleton<GameManager>.Instance.PDNPNJNFDGL("id", null, null, null, 1, 0);
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "Editor/";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.red);
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x0601182E RID: 71726 RVA: 0x00605E48 File Offset: 0x00604048
	public void NFKKPHKGIEI()
	{
		this.isConnecting = false;
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.logLevel = PhotonLogLevel.Informational;
		PhotonNetwork.autoJoinLobby = true;
		PhotonNetwork.automaticallySyncScene = true;
		Singleton<MessageBoxPanel>.Instance.KJPEAAAGNGK(LocalizationService.Instance.GetTextByKey("ItemsStoreButton").ToUpper() + "hitsounds:", LocalizationService.Instance.IAAEBJKAHDD("_Glitch").ToUpper(), new UnityAction(this.ExitToMenu), false, false, 594f);
		if (PhotonNetwork.connected)
		{
			this.OnConnectedToMaster();
		}
		else
		{
			Debug.Log("selector");
			PhotonNetwork.ConnectUsingSettings(Helpers.GetGameVersion());
		}
	}

	// Token: 0x0601182F RID: 71727 RVA: 0x00605EED File Offset: 0x006040ED
	public void DJADJEGPBEC(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.AAMNKPHHHCI();
		string lblkdnnpaco = "/";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[1];
		array[1] = JKPJCEMPAGH;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011830 RID: 71728 RVA: 0x00605F0A File Offset: 0x0060410A
	public override void OnConnectedToMaster()
	{
		if (this.isConnecting)
		{
			Debug.Log("[NetworkManager] Connected to " + PhotonNetwork.JNJJAMNLOHA.CloudRegion + " region");
			PhotonNetwork.LeaveLobby();
			PhotonNetwork.JoinLobby();
		}
	}

	// Token: 0x06011831 RID: 71729 RVA: 0x00605F46 File Offset: 0x00604146
	public void AECDDNEIJBJ(string JKPJCEMPAGH)
	{
		base.GMAHNPNHMFK().GNFNHDCJOFC("OK", (PhotonTargets)8, new object[]
		{
			JKPJCEMPAGH
		});
	}

	// Token: 0x06011832 RID: 71730 RVA: 0x00605F63 File Offset: 0x00604163
	public void Awake()
	{
		this.BPKBDDEPHFK = Callback<GameRichPresenceJoinRequested_t>.Create(new Callback<GameRichPresenceJoinRequested_t>.DispatchDelegate(this.DOKFAFHFBEO));
	}

	// Token: 0x06011833 RID: 71731 RVA: 0x00605F63 File Offset: 0x00604163
	public void EIFCCFBJKOO()
	{
		this.BPKBDDEPHFK = Callback<GameRichPresenceJoinRequested_t>.Create(new Callback<GameRichPresenceJoinRequested_t>.DispatchDelegate(this.DOKFAFHFBEO));
	}

	// Token: 0x06011834 RID: 71732 RVA: 0x00605F7C File Offset: 0x0060417C
	public virtual void IOALJLKBLFM()
	{
		if (this.isConnecting)
		{
			Debug.Log("Joystick1Button0" + PhotonNetwork.JNJJAMNLOHA.CloudRegion + "AvatarImage");
			PhotonNetwork.LeaveLobby();
			PhotonNetwork.JoinLobby();
		}
	}

	// Token: 0x06011835 RID: 71733 RVA: 0x00605FB8 File Offset: 0x006041B8
	public virtual void KEAGEGOPFMI(object[] APELDCFFFOH)
	{
		Debug.Log("#exitmapeditor");
	}

	// Token: 0x06011836 RID: 71734 RVA: 0x00605FC4 File Offset: 0x006041C4
	public virtual void GGPNPNGELEF()
	{
		Singleton<MessageBoxPanel>.Instance.IPMMEMNBGNL(-1, null);
		Debug.Log("Reconnect() failed. It seems the client wasn't connected before?! Current state: " + PhotonNetwork.room.PlayerCount + ".wav");
		Singleton<MultiplayerSystem>.Instance.GFOMJBDKANJ("\"" + PhotonNetwork.room.POPKEPNKIAO());
		base.StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.HIFFKEGBEDB();
		PhotonView photonView = base.GBHNDHLAJLI();
		string lblkdnnpaco = "_Value2";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[1];
		array[1] = "y" + ResourcesManager.IPFFGAILCED(SteamUser.GetSteamID(), true) + "Commands for challenges";
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
		this.reciveLevelId = true;
		this.lobbyCanvas.SetActive(false);
		this.networkCanvas.SetActive(false);
		GameObject.Find("CameraFilterPack/FX_DigitalMatrixDistortion").GetComponent<Button>().interactable = false;
		if (GameObject.Find("DontDestroy"))
		{
			GameObject.Find(" ").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.MKGBAKICGOA("_DepthLevel", "Error: Someone else(", PhotonNetwork.room.Name, PhotonNetwork.room.Name, PhotonNetwork.room.DHOGHIOACME(), PhotonNetwork.room.DDDIFAMCNDO());
		GameObject gameObject = this.playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("_Threshhold", new Vector3(1264f, 1361f, 21f), Quaternion.identity, 1);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(175f, 1754f, 701f);
		this.lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		this.lobbyPlayer.GGHCMPKGNGE();
		this.NPAELKPFIKP();
		base.CIACEFBNDDJ().IKIJDNPJKPM("OPEN", PhotonTargets.MasterClient, new object[1]);
	}

	// Token: 0x06011837 RID: 71735 RVA: 0x00606190 File Offset: 0x00604390
	public void FLPKJOJLGON()
	{
		InventorySelector instance = Singleton<InventorySelector>.Instance;
		if (NetworkMenu.LNIJKGECNME == null)
		{
			NetworkMenu.LNIJKGECNME = new UnityAction(NetworkMenu.CAKAOMKICAA);
		}
		base.StartCoroutine(instance.INLAAKKJLGH(NetworkMenu.LNIJKGECNME));
	}

	// Token: 0x06011838 RID: 71736 RVA: 0x006061C0 File Offset: 0x006043C0
	public bool OHFEAECIENP()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer jhoedacnnkk = playerList[i];
			if (jhoedacnnkk.GetTeam() == PunTeams.Team.none)
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06011839 RID: 71737 RVA: 0x006061FC File Offset: 0x006043FC
	public virtual void FDIKMPKOGDD(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("_FixDistance");
		Singleton<GameManager>.Instance.IPOGIBLJDPE("ready", "_CurveParams", PhotonNetwork.room.Name, PhotonNetwork.room.GJCOLGAHAIO(), PhotonNetwork.room.EGPGEMJNPFD(), PhotonNetwork.room.DEICKHNCDML());
	}

	// Token: 0x0601183A RID: 71738 RVA: 0x00606250 File Offset: 0x00604450
	public virtual void AHMMPNGEPDO()
	{
		Debug.Log("_Green_G");
		Singleton<GameManager>.Instance.EJGBOJDDMHH("_Value2", null, null, null, 0, 1);
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "value";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.red);
		base.StartCoroutine(this.UpdateRooms());
	}

	// Token: 0x0601183B RID: 71739 RVA: 0x0060630C File Offset: 0x0060450C
	public override void OnPhotonJoinRoomFailed(object[] APELDCFFFOH)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Connection failed: " + APELDCFFFOH[1], "OK", null, true, false, 0f);
		Debug.LogError("[NetworkManager] Connection failed: " + APELDCFFFOH[1]);
	}

	// Token: 0x0601183C RID: 71740 RVA: 0x00606344 File Offset: 0x00604544
	public void CGOHBJIKMGJ()
	{
		Singleton<MessageBoxPanel>.Instance.ILNLMMEOALM(LocalizationService.Instance.GetTextByKey("BadgeText").ToUpper() + "_Value6", "#000000", null, false, true, 1958f);
		string[] array = new string[7];
		array[1] = "RoomDescriptionText";
		array[0] = "/";
		RoomOptions dpodhcmgcpf = new RoomOptions
		{
			IsVisible = !this.roomPrivateToggle.isOn,
			MaxPlayers = (byte)-82,
			CustomRoomPropertiesForLobby = array,
			CleanupCacheOnLeave = false
		};
		PhotonNetwork.JoinOrCreateRoom((!string.IsNullOrEmpty(this.roomNameInputField.text)) ? this.roomNameInputField.text : (UnityEngine.Random.Range(-140, 26) + string.Empty), dpodhcmgcpf, TypedLobby.Default);
	}

	// Token: 0x0601183D RID: 71741 RVA: 0x0060641E File Offset: 0x0060461E
	public void GLDGNBOGBCG()
	{
		InventorySelector instance = Singleton<InventorySelector>.Instance;
		if (NetworkMenu.LNIJKGECNME == null)
		{
			NetworkMenu.LNIJKGECNME = new UnityAction(NetworkMenu.NAFJHMACIOC);
		}
		base.StartCoroutine(instance.INLAAKKJLGH(NetworkMenu.LNIJKGECNME));
	}

	// Token: 0x0601183E RID: 71742 RVA: 0x00606450 File Offset: 0x00604650
	internal void DNOHFBHBMJB(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.none);
			GameObject gameObject = this.playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i += 0)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = true;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				this.DJADJEGPBEC("OnAwakeRPC" + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("Keypad", string.Empty).Replace("workshop.", string.Empty).Replace("id", string.Empty));
				this.AECDDNEIJBJ("Anomaly_Intensity" + (GameScene.GameMode)DLGIPFOEDCF);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				this.reciveLevelId = true;
				this.FDNCEFHNLNJ();
				this.lobbyPlayer.HBIGOLEEFNH();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				PublishedFileId_t lijpbbcjnhd = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("_Far", string.Empty));
				Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC(LocalizationService.Instance.IAAEBJKAHDD("inventory.itemscash").ToUpper() + "NetworkScene", LocalizationService.Instance.GetTextByKey("_Value5").ToUpper(), null, true, true, 788f);
				this.selectedlevelid = EAFAMAMDNEG;
				this.selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += this.HDKKLFLOHLD;
				Singleton<MapsSystem>.Instance.SubscribeAndDownload(lijpbbcjnhd);
			}
		}
	}

	// Token: 0x0601183F RID: 71743 RVA: 0x00606604 File Offset: 0x00604804
	public void CreateRoom()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("entering").ToUpper() + "...", "OK", null, false, false, 0f);
		string[] customRoomPropertiesForLobby = new string[]
		{
			"roomDescription",
			"masterSteamID"
		};
		RoomOptions dpodhcmgcpf = new RoomOptions
		{
			IsVisible = !this.roomPrivateToggle.isOn,
			MaxPlayers = 16,
			CustomRoomPropertiesForLobby = customRoomPropertiesForLobby,
			CleanupCacheOnLeave = true
		};
		PhotonNetwork.JoinOrCreateRoom((!string.IsNullOrEmpty(this.roomNameInputField.text)) ? this.roomNameInputField.text : (UnityEngine.Random.Range(10000000, 99999999) + string.Empty), dpodhcmgcpf, TypedLobby.Default);
	}

	// Token: 0x06011840 RID: 71744 RVA: 0x006066E0 File Offset: 0x006048E0
	private IEnumerator PCEIBDOLEFP(ulong LFLDPPGGLCL)
	{
		parent = base.transform.parent;
		text = "workshop." + LFLDPPGGLCL;
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		}
		this.reciveLevelId = true;
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text, null);
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		this.UpdateRoom();
		this.lobbyPlayer.CheckIsReady();
		yield break;
	}

	// Token: 0x06011841 RID: 71745 RVA: 0x00606704 File Offset: 0x00604904
	private IEnumerator FBCMNDNMMNF()
	{
		if (NetworkMenu.MBOJBANHFBK.LNIJKGECNME == null)
		{
			NetworkMenu.MBOJBANHFBK.LNIJKGECNME = new Func<bool>(NetworkMenu.MBOJBANHFBK.GBKBDKHPLKG);
		}
		yield return new WaitUntil(NetworkMenu.MBOJBANHFBK.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, null, null));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, new object[]
				{
					Singleton<MapsListSelector>.Instance.result,
					(int)Singleton<MapsListSelector>.Instance.resultMode
				});
			}
			else
			{
				base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
				{
					string.Concat(new object[]
					{
						"[",
						SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))),
						"] Suggested ",
						Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty),
						" at ",
						Singleton<MapsListSelector>.Instance.resultMode
					})
				});
			}
		}
		yield break;
	}

	// Token: 0x06011842 RID: 71746 RVA: 0x00603E62 File Offset: 0x00602062
	public void NKKNKHEJJNF()
	{
		InventorySelector instance = Singleton<InventorySelector>.Instance;
		if (NetworkMenu.LNIJKGECNME == null)
		{
			NetworkMenu.LNIJKGECNME = new UnityAction(NetworkMenu.CAKAOMKICAA);
		}
		base.StartCoroutine(instance.KDJBPKJFAKI(NetworkMenu.LNIJKGECNME));
	}

	// Token: 0x06011843 RID: 71747 RVA: 0x00606720 File Offset: 0x00604920
	public override void OnCreatedRoom()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("roomDescription", this.roomDescriptionInputField.text);
		hashtable.Add("masterSteamID", PhotonNetwork.playerName);
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x06011844 RID: 71748 RVA: 0x00606768 File Offset: 0x00604968
	public IEnumerator Disconnect()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu", null, null, null, 0, 0);
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
		yield break;
	}

	// Token: 0x06011845 RID: 71749 RVA: 0x00606784 File Offset: 0x00604984
	public IEnumerator OOCNMBODPMG()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		base.StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu", null, null, null, 0, 0);
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
		yield break;
	}

	// Token: 0x06011846 RID: 71750 RVA: 0x006067A0 File Offset: 0x006049A0
	public virtual void MIPKIHHLEHK(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("_Value");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Value", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		this.FDNCEFHNLNJ();
	}

	// Token: 0x06011847 RID: 71751 RVA: 0x006067EC File Offset: 0x006049EC
	public void OIMKNDDHFLK()
	{
		base.ACPGHFHDCIP().PBMFBOOALKA("ChatHistoryInputField", PhotonTargets.All, new object[]
		{
			"steamid" + ResourcesManager.MDDNCHKAMDI(SteamUser.GetSteamID(), true) + "z"
		});
		PhotonNetwork.LeaveRoom();
		GameObject gameObject = this.playersScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.reciveLevelId = false;
		this.selectedlevelid = string.Empty;
		base.StopAllCoroutines();
		this.EMBFNPAGFIK();
		Singleton<MultiplayerSystem>.Instance.JFPJFJHLPMB();
	}

	// Token: 0x06011848 RID: 71752 RVA: 0x00606894 File Offset: 0x00604A94
	public void Init()
	{
		this.isConnecting = true;
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.logLevel = PhotonLogLevel.ErrorsOnly;
		PhotonNetwork.autoJoinLobby = false;
		PhotonNetwork.automaticallySyncScene = true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("connecting").ToUpper() + "...", LocalizationService.Instance.GetTextByKey("cancel").ToUpper(), new UnityAction(this.ExitToMenu), true, false, 0f);
		if (PhotonNetwork.connected)
		{
			this.OnConnectedToMaster();
		}
		else
		{
			Debug.Log("[NetworkManager] Connecting...");
			PhotonNetwork.ConnectUsingSettings(Helpers.GetGameVersion());
		}
	}

	// Token: 0x06011849 RID: 71753 RVA: 0x0060693C File Offset: 0x00604B3C
	public virtual void JNHPFMKIBMO(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("DPADVER");
		Singleton<GameManager>.Instance.EJGBOJDDMHH("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", "OK", PhotonNetwork.room.GJCOLGAHAIO(), PhotonNetwork.room.Name, PhotonNetwork.room.EGPGEMJNPFD(), PhotonNetwork.room.DEICKHNCDML());
	}

	// Token: 0x04001EEC RID: 7916
	public GameObject roomsListContent;

	// Token: 0x04001EED RID: 7917
	public GameObject networkCanvas;

	// Token: 0x04001EEE RID: 7918
	public GameObject lobbyCanvas;

	// Token: 0x04001EEF RID: 7919
	public GameObject lobbyLevelsListElement;

	// Token: 0x04001EF0 RID: 7920
	public GameObject playersScrollRectContent;

	// Token: 0x04001EF1 RID: 7921
	public LobbyPlayerElement lobbyPlayer;

	// Token: 0x04001EF2 RID: 7922
	public GameObject roomsListElement;

	// Token: 0x04001EF3 RID: 7923
	public GameObject roomsMessageElement;

	// Token: 0x04001EF4 RID: 7924
	public GameObject lobbyPlayerElement;

	// Token: 0x04001EF5 RID: 7925
	public bool isConnecting;

	// Token: 0x04001EF6 RID: 7926
	public bool reciveLevelId;

	// Token: 0x04001EF7 RID: 7927
	public string selectedlevelid = string.Empty;

	// Token: 0x04001EF8 RID: 7928
	public int selectedmodelid;

	// Token: 0x04001EF9 RID: 7929
	public GameObject inventoryGroupsContent;

	// Token: 0x04001EFA RID: 7930
	public GameObject inventoryGroupElement;

	// Token: 0x04001EFB RID: 7931
	public GameObject inventoryItemElement;

	// Token: 0x04001EFC RID: 7932
	public InputField roomNameInputField;

	// Token: 0x04001EFD RID: 7933
	public InputField roomDescriptionInputField;

	// Token: 0x04001EFE RID: 7934
	public Toggle roomPrivateToggle;

	// Token: 0x04001EFF RID: 7935
	private bool PKPKKHLGANI;

	// Token: 0x04001F00 RID: 7936
	private Callback<GameRichPresenceJoinRequested_t> BPKBDDEPHFK;

	// Token: 0x04001F01 RID: 7937
	[CompilerGenerated]
	private static UnityAction LNIJKGECNME;
}
