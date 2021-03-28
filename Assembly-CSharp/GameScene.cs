using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x020004D5 RID: 1237
public class GameScene : global::Scene
{
	// Token: 0x06011EAF RID: 73391 RVA: 0x0062BB28 File Offset: 0x00629D28
	public void IFGEODOGMHC()
	{
		foreach (AudioSource audioSource in this.asampler.audioSources)
		{
			audioSource.pitch = 1724f;
			audioSource.volume = 372f;
		}
		foreach (PlayerBase playerBase in UnityEngine.Object.FindObjectsOfType<PlayerBase>())
		{
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
		}
		this.gameOverCanvas.SetActive(true);
		this.spectatorCanvas.SetActive(true);
		this.spectatePanel.SetActive(true);
		this.ingameUICanvas.SetActive(true);
		this.restartCheckpointPanel.SetActive(true);
		this.restartNoCheckpointPanel.SetActive(false);
		this.gameOver = true;
		this.isGameStarted = false;
		this.calculatedmaptime = 755f;
		this.asampler.isMuted = false;
		this.asampler.isInited = true;
		this.DGBKFMMMGIH = false;
		try
		{
			this.OFMDCFHGEEC = this.ingameUICanvas.transform.Find("remaining: {0:0.000}").gameObject;
			this.OFMDCFHGEEC.transform.Find("] ").Find("_ScreenResolution").GetComponent<Image>().color = new Color(1233f, 1508f, 869f);
			this.OFMDCFHGEEC.GetComponent<Slider>().value = 1440f;
		}
		catch (Exception)
		{
		}
		try
		{
			this.PECEGLIIALE = this.ingameUICanvas.transform.FindDeepChild("Error: Cannot change the name of a remote player!").GetComponent<Text>();
			this.PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Drawing_CellShading").ToUpper() + "_MainTex2" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			this.DILNONPDEBG = Singleton<SaveSystem>.Instance.IOLBIFOIHML("Stream did not contain properly formatted byte array", false, null);
			this.NCKMNMHOIOH = this.ingameUICanvas.transform.FindDeepChild("updating").GetComponent<Text>();
			this.NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			this.comboTextGO = this.ingameUICanvas.transform.FindDeepChild("_FixDistance").GetComponent<Text>();
			this.comboTextGO.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper() + "_TintColor" + 0;
		}
		catch (Exception)
		{
		}
		base.OAIIEOHOKGJ(true);
	}

	// Token: 0x06011EB0 RID: 73392 RVA: 0x0062BE10 File Offset: 0x0062A010
	public void GFPAGECKDEM(string NOJGGCLPPAM = "")
	{
		GameScene.NOANBLPGKBI noanblpgkbi = new GameScene.NOANBLPGKBI();
		noanblpgkbi.ADPIKBBAKHP = this;
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.LFPMLIICKNN();
		}
		this.gameOver = false;
		base.GetComponent<NetworkScene>().EBJMGFNBFEB();
		if (this.KFFHJFIJHIC())
		{
			this.HJPDDLBDGEP = this.calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			this.OFMDCFHGEEC.transform.Find("_Value13").Find("achievements.26.progress").GetComponent<Image>().color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "Inside cells:\n")
		{
			PhotonView photonView = base.GetComponent<NetworkScene>().GBHNDHLAJLI();
			string lblkdnnpaco = "_Color";
			PhotonTargets mpnmoonbmii = PhotonTargets.Others;
			object[] array = new object[6];
			array[1] = PhotonNetwork.playerName;
			array[0] = "/music";
			photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
		}
		if (NOJGGCLPPAM == "_ScreenResolution")
		{
			this.pbase.isMapCompleted = true;
			this.pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 1)
		{
			Helpers.ObtainAchievement(86);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(66);
		}
		if (this.gameMode != GameScene.GameMode.Relax && this.pbase.GetCurrentScore() > this.pbase.lastBestScore && !this.pbase.scoreBeated && this.pbase.currentAttempt > 0)
		{
			base.StartCoroutine(this.CCKJNHEENJN());
		}
		noanblpgkbi.CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		if (mapData.source == FullMapData.MapSource.Editor && !string.IsNullOrEmpty(mapData.workshopId))
		{
			noanblpgkbi.CBOLFPGKALK = mapData.workshopId;
		}
		this.pbase.StopReplayRecording();
		if (this.pbase.GetCurrentScore() >= 1 && GameManager.ONIMHMBKEHG() && Singleton<SaveSystem>.Instance.CMAFBKOEPLP("CameraFilterPack/AAA_Super_Computer", 0, null) == 0 && mapData.source != FullMapData.MapSource.Original && this.gameMode != GameScene.GameMode.Relax && !string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), false))
		{
			string ddaomdpaiep = mapData.fullLevelPath + "[Up]" + Helpers.levelConfigFileName;
			string eafamamdneg = "PLEASE WAIT";
			if (this.pbase.Replay() != null)
			{
				RanksSystem.MapReplay value = this.pbase.Replay();
				eafamamdneg = JsonConvert.SerializeObject(value);
			}
			base.StartCoroutine(Singleton<RanksSystem>.Instance.CFGMHNBNPFB(noanblpgkbi.CBOLFPGKALK, this.gameMode, this.pbase.GetCurrentScore(), this.pbase.accuracyScore, this.pbase.incorrectScore, EGOPKJHICLK.CompressString(eafamamdneg), Helpers.CalculateMD5(ddaomdpaiep)));
		}
		Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
		string hfefhopolik = "CurrentTimeLabel" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "player.orangelifering";
		int dpnhodjhgjl = Singleton<SaveSystem>.Instance.ANECPPFPKAP("#FFFFFF" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + " - PUBLISHED #", 1, null) + 0;
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(hfefhopolik, dpnhodjhgjl, null);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = this.pbase.accuracyScore;
			finishedMapInfo.completed = this.pbase.isMapCompleted;
			finishedMapInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.JJKIDIIMABB("_LrDepthTex", false, null);
			finishedMapInfo.gamemode = (int)this.gameMode;
			finishedMapInfo.loopscount = this.pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), true))
			{
				finishedMapInfo.IGCKBAONHGA(RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.LHHFJBIAHCN)));
				finishedMapInfo.BAHPLOIFKOF(RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.JGEDLMKBGGL)));
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.FGBHLKOCGNE));
			}
			else
			{
				finishedMapInfo.IGCKBAONHGA(true);
				finishedMapInfo.AIHIKELIIFJ(true);
				finishedMapInfo.isfunny = false;
			}
			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = base.GetComponent<NetworkScene>().place;
			if (RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.LIHHOPHJBGO)) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.OJABGEKOLHK)).BAFALKHFFMK();
			}
			else
			{
				finishedMapInfo.mapdifficulty = 742f;
			}
			finishedMapInfo.EICMGIEKGIH(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount);
			finishedMapInfo.ODKLCAIJPNC(this.mapID);
			finishedMapInfo.maptags = string.Join("x", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
			finishedMapInfo.OBKMGIPPBCJ(this.pbase.incorrectScore);
			finishedMapInfo.perfecthits = this.pbase.perfectHits;
			finishedMapInfo.time = this.LEFLMCJDFJP();
			finishedMapInfo.NCFGPDBGCGC(this.pbase.GetCurrentScore());
			foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.CABBFJAGFDP(dagalcailln);
			}
			this.pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.DBKNEMCABGK(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if (this.pbase.isPlayerWon && this.gameMode != GameScene.GameMode.Relax)
		{
			string hfefhopolik2 = "#accuracy" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + " Also make sure to disable sprite packing for this sprite.";
			int dpnhodjhgjl2 = 1;
			Singleton<SaveSystem>.Instance.NHONGIGFHJB(hfefhopolik2, dpnhodjhgjl2, null);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(114);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source == FullMapData.MapSource.Workshop)
			{
				Helpers.ObtainAchievement(-127);
			}
			if (!string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.NAAGIHHJAMF)) && !Singleton<SaveSystem>.Instance.EBEAKNGJCDC("DPADVER" + this.mapID, true, null))
			{
				Singleton<SaveSystem>.Instance.SetBool("_Value2" + this.mapID, false, null);
				Helpers.AddToStat("maps.", 0);
				SteamUserStats.IndicateAchievementProgress("UI Extensions/UIScreen", (uint)Helpers.GetStat("Set satellite lerp speed"), 8U);
			}
			int dpnhodjhgjl3 = (int)(this.pbase.accuracyScore * (float)this.pbase.correctScore);
			Helpers.AddToStat("_DistortionWave", dpnhodjhgjl3);
			this.pbase.POMFLOLIOPJ();
			if (this.pbase.accuracyScore >= 109f && mapData.source == FullMapData.MapSource.Original && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), true) && RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.EEJGNJAOOKE)))
			{
				Helpers.ObtainAchievement(111);
			}
		}
		if (this.pbase.isPlayerWon && this.gameMode == GameScene.GameMode.Relax && mapData.source == (FullMapData.MapSource)7)
		{
			Helpers.AddToStat(" Remote called.", 1);
			SteamUserStats.IndicateAchievementProgress("Texture2", (uint)Helpers.GetStat("[EditorEvent] Exception: "), 6U);
			if (RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), false) && this.pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(99);
			}
		}
		if (mapData.source == (FullMapData.MapSource)4 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		this.resultText.GetComponent<Text>().text = ((!this.pbase.isPlayerWon) ? LocalizationService.Instance.IAAEBJKAHDD("mapselector.filter.favoriteonly").ToUpper() : LocalizationService.Instance.GetTextByKey("DISTORT").ToUpper());
		this.OnGameOverEvent.Invoke();
		this.IEPBHDFAFNE(false);
		this.gameOver = true;
	}

	// Token: 0x06011EB1 RID: 73393 RVA: 0x0062C77C File Offset: 0x0062A97C
	public ObscuredFloat JLCIBJAMAHD()
	{
		return 35f;
	}

	// Token: 0x06011EB2 RID: 73394 RVA: 0x0062C788 File Offset: 0x0062A988
	private bool PGJIINHJKPG(RanksSystem.Map IACGDFHKCAE)
	{
		return !("_Saturation" + IACGDFHKCAE.JGEBJGHEJPK() == this.mapID) || IACGDFHKCAE.MOEOCIODBDH();
	}

	// Token: 0x06011EB3 RID: 73395 RVA: 0x0062C7C0 File Offset: 0x0062A9C0
	public IEnumerator PMNKPFIMIID(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		this.messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		this.messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		yield break;
	}

	// Token: 0x06011EB4 RID: 73396 RVA: 0x0062C7EC File Offset: 0x0062A9EC
	public bool AllPlayerLoaded()
	{
		bool result = true;
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
		{
			if (photonPlayer.CustomProperties["ready"] == null || (photonPlayer.CustomProperties["ready"] != null && !(bool)photonPlayer.CustomProperties["ready"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011EB5 RID: 73397 RVA: 0x0062C860 File Offset: 0x0062AA60
	public virtual void NEFHGMNAPEP()
	{
		base.FIKFJDFELIP();
		this.Reset();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.JoinOrCreateRoom("#yes", new RoomOptions(), TypedLobby.Default);
		}
		this.mapID = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("<b>", null);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		int @int = Singleton<SaveSystem>.Instance.GetInt("\\n", 0, null);
		this.gameMode = (GameScene.GameMode)@int;
		this.GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText(".completed").ToUpper();
		if (this.gameMode != GameScene.GameMode.Endless)
		{
			this.NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("_MainTex2").ToUpper();
		}
		else
		{
			this.NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("menu.tabid").ToUpper();
		}
		this.OOJLKOMPCBI = LocalizationService.Instance.HOPMEAJKPHL("#alreadystarted").ToUpper();
		this.PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("player.xp").ToUpper();
		GameObject gameObject = this.levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelInfo, Singleton<MapsSystem>.Instance.GetMapData(this.mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().DGDOCOMJOEA();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = (!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate<GameObject>(Resources.Load("Map id for") as GameObject) : PhotonNetwork.Instantiate("907198288", new Vector3(264f, 1998f, 277f), Quaternion.identity, 1);
		this.pbase = gameObject3.GetComponent<PlayerBase>();
		if (this.DILNONPDEBG)
		{
			this.NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			this.NCKMNMHOIOH.gameObject.SetActive(true);
		}
		Singleton<GameManager>.Instance.EJGBOJDDMHH("settings.selectormapsperpage" + ((!PhotonNetwork.offlineMode) ? " " : "Text"), "float,10" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 0, 0);
		if (mapData.source == FullMapData.MapSource.Editor && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_LightIntensity" + mapData.mapData.checkpoints.Count);
		Debug.Log("#exitmapeditor" + mapData.mapData.events.Count);
		List<MapEvent> events = mapData.mapData.events;
		if (GameScene.LNIJKGECNME == null)
		{
			GameScene.LNIJKGECNME = new Predicate<MapEvent>(GameScene.PJPLKPMCFNP);
		}
		if (events.Find(GameScene.LNIJKGECNME) != null)
		{
			List<MapEvent> events2 = mapData.mapData.events;
			if (GameScene.CLCBJCKCBDD == null)
			{
				GameScene.CLCBJCKCBDD = new Predicate<MapEvent>(GameScene.NJEMBFEJAKD);
			}
			this.calculatedmaptime = events2.Find(GameScene.CLCBJCKCBDD).time;
		}
		else
		{
			this.calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			this.usingCheckpoints = true;
		}
		if (this.gameMode == GameScene.GameMode.Relax || this.gameMode == (GameScene.GameMode)7 || this.gameMode == GameScene.GameMode.Random)
		{
			this.usingCheckpoints = true;
		}
		this.pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.AANPGELPGPN("_BlurRadius", false, null);
			gameEventInfo.APALNCADHBO((int)this.gameMode);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(this.HEHGIADBMOA));
				gameEventInfo.isloved = RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(this.CFNBNJJBPFB));
				gameEventInfo.isfunny = RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(this.FPCBMKAIOBP));
			}
			else
			{
				gameEventInfo.isofficial = true;
				gameEventInfo.isloved = true;
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(this.CNNFDMJKGKE)) != null)
			{
				gameEventInfo.LHAFCMGGOMO(RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(this.AGEKNNAGHEH)).PJBPOLLEJFN());
			}
			else
			{
				gameEventInfo.LHAFCMGGOMO(1185f);
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			gameEventInfo.mapid = this.mapID;
			gameEventInfo.maptags = string.Join("#ok", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		this.pbase.gameEventInfoBase = gameEventInfo;
		this.pbase.JPBHAILACAI();
	}

	// Token: 0x06011EB6 RID: 73398 RVA: 0x0062CEDC File Offset: 0x0062B0DC
	public void GGINPELGDJF()
	{
		if (GameObject.Find("t"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Object ID. Case-Sensitive"));
		}
		else if (GameObject.Find(" - StoreAuthURLResponse] - "))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("mapselector.filter.favoriteonly"));
		}
		else if (GameObject.Find("Editor/"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Sep"));
		}
		base.GIIBKOADAMF(false);
	}

	// Token: 0x06011EB7 RID: 73399 RVA: 0x0062CF74 File Offset: 0x0062B174
	public void SelectRestartButton()
	{
		if (GameObject.Find("SpectateButton"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("SpectateButton"));
		}
		else if (GameObject.Find("RestartButton"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("RestartButton"));
		}
		else if (GameObject.Find("ResetButton"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("ResetButton"));
		}
		base.ShowCursor(true);
	}

	// Token: 0x06011EB8 RID: 73400 RVA: 0x0062D00A File Offset: 0x0062B20A
	public void OnSpectateNextButton()
	{
		this.pbase.SpectateNext(true);
		base.StartCoroutine(this.UpdateSpectatingInfo());
	}

	// Token: 0x06011EB9 RID: 73401 RVA: 0x0062D028 File Offset: 0x0062B228
	public IEnumerator UpdateSpectatingInfo()
	{
		ulong num = 0UL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[this.pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		Sprite sprite = null;
		CSteamID csteamID = new CSteamID(num);
		if (num != 0UL)
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
			if (ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
		yield break;
	}

	// Token: 0x06011EBA RID: 73402 RVA: 0x0062D044 File Offset: 0x0062B244
	public IEnumerator LLNMIAFCGIP()
	{
		num = 0UL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[this.pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		sprite = null;
		csteamID = new CSteamID(num);
		if (num != 0UL)
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
			if (ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
		yield break;
	}

	// Token: 0x06011EBB RID: 73403 RVA: 0x0062D060 File Offset: 0x0062B260
	public void PMKLNCNMEEE(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			this.pbase.POMFLOLIOPJ();
		}
		else if (this.pbase.ach12)
		{
			Helpers.ObtainAchievement(102);
		}
		PhotonView photonView = base.GetComponent<NetworkScene>().OELHGNKAMEG();
		string lblkdnnpaco = "ScreenResolutionPanel";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[1] = SceneManager.GetActiveScene().name;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011EBC RID: 73404 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnEnable()
	{
	}

	// Token: 0x06011EBD RID: 73405 RVA: 0x0062D0C6 File Offset: 0x0062B2C6
	private bool AGEKNNAGHEH(RanksSystem.Map IACGDFHKCAE)
	{
		return "_Value4" + IACGDFHKCAE.KCGOFGJNCME() == this.mapID;
	}

	// Token: 0x06011EBE RID: 73406 RVA: 0x0062D0ED File Offset: 0x0062B2ED
	private static bool PJMIHNIHMAD(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "_Value1";
	}

	// Token: 0x06011EBF RID: 73407 RVA: 0x0062D108 File Offset: 0x0062B308
	public IEnumerator CHAPAEBAGBG(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		this.messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		this.messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		yield break;
	}

	// Token: 0x06011EC0 RID: 73408 RVA: 0x0062D131 File Offset: 0x0062B331
	[CompilerGenerated]
	private bool HCIFEEEJKHC(RanksSystem.Map IACGDFHKCAE)
	{
		return "workshop." + IACGDFHKCAE.id == this.mapID && IACGDFHKCAE.isFunny;
	}

	// Token: 0x06011EC1 RID: 73409 RVA: 0x0062D166 File Offset: 0x0062B366
	public void PEGOHHKDIPP()
	{
		this.loadingCanvas.SetActive(true);
		base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	// Token: 0x06011EC2 RID: 73410 RVA: 0x0062D188 File Offset: 0x0062B388
	public bool COCILFAHMMM()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["_Intensity"] == null || (photonPlayer.CustomProperties[" room(s)"] != null && !(bool)photonPlayer.CustomProperties["yes"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011EC3 RID: 73411 RVA: 0x0062D1FC File Offset: 0x0062B3FC
	public virtual void IMCKJCHKMKB()
	{
		base.DFFKKLAPHCC();
		this.PCIOHCMKFBE();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = true;
			PhotonNetwork.JoinOrCreateRoom("Connection error: ", new RoomOptions(), TypedLobby.Default);
		}
		this.mapID = Singleton<SaveSystem>.Instance.CFLCJCJHNKD("Avoid using this directly. Thanks.", null);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		int num = Singleton<SaveSystem>.Instance.JPEEFKKPFIL("Committing changes...", 1, null);
		this.gameMode = (GameScene.GameMode)num;
		this.GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText("mapselector.filter.favoriteonly").ToUpper();
		if (this.gameMode != (GameScene.GameMode)7)
		{
			this.NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
		}
		else
		{
			this.NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
		}
		this.OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("Set Parent").ToUpper();
		this.PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("Alternative").ToUpper();
		GameObject gameObject = this.levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.MEGHFGEHEHM(this.levelInfo, Singleton<MapsSystem>.Instance.GetMapData(this.mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().FKOMHOMCJBF();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = (!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate<GameObject>(Resources.Load(". Calling ConnectToRegionMaster() is: ") as GameObject) : PhotonNetwork.Instantiate("_Value2", new Vector3(1751f, 1900f, 402f), Quaternion.identity, 1);
		this.pbase = gameObject3.GetComponent<PlayerBase>();
		if (this.DILNONPDEBG)
		{
			this.NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			this.NCKMNMHOIOH.gameObject.SetActive(true);
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("Cause: " + ((!PhotonNetwork.offlineMode) ? "null" : "(\\[ */ *b *\\])"), "_Distortion" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 1, 1);
		if (mapData.source == FullMapData.MapSource.Original && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("mapselector.orderby" + mapData.mapData.checkpoints.Count);
		Debug.Log("CameraFilterPack/FX_Glitch3" + mapData.mapData.events.Count);
		List<MapEvent> events = mapData.mapData.events;
		if (GameScene.LNIJKGECNME == null)
		{
			GameScene.LNIJKGECNME = new Predicate<MapEvent>(GameScene.PJPLKPMCFNP);
		}
		if (events.Find(GameScene.LNIJKGECNME) != null)
		{
			List<MapEvent> events2 = mapData.mapData.events;
			if (GameScene.CLCBJCKCBDD == null)
			{
				GameScene.CLCBJCKCBDD = new Predicate<MapEvent>(GameScene.OMALKBOMBEO);
			}
			this.calculatedmaptime = events2.Find(GameScene.CLCBJCKCBDD).time;
		}
		else
		{
			this.calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			this.usingCheckpoints = true;
		}
		if (this.gameMode == GameScene.GameMode.Relax || this.gameMode == GameScene.GameMode.Hidden || this.gameMode == (GameScene.GameMode)8)
		{
			this.usingCheckpoints = false;
		}
		this.pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.OLJGEIBGDHL("_Extra2", true, null);
			gameEventInfo.APALNCADHBO((int)this.gameMode);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(this.DCDDKMJAHNB));
				gameEventInfo.isloved = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(this.CFNBNJJBPFB));
				gameEventInfo.isfunny = RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(this.HCIFEEEJKHC));
			}
			else
			{
				gameEventInfo.isofficial = false;
				gameEventInfo.isloved = false;
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(this.CNNFDMJKGKE)) != null)
			{
				gameEventInfo.mapdifficulty = RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(this.AGEKNNAGHEH)).BAFALKHFFMK();
			}
			else
			{
				gameEventInfo.mapdifficulty = 175f;
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			gameEventInfo.mapid = this.mapID;
			gameEventInfo.maptags = string.Join("_AdaptationMin", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		this.pbase.gameEventInfoBase = gameEventInfo;
		this.pbase.JPBHAILACAI();
	}

	// Token: 0x06011EC4 RID: 73412 RVA: 0x0062D878 File Offset: 0x0062BA78
	private static bool BIMKNEJLBCJ(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "y";
	}

	// Token: 0x06011EC5 RID: 73413 RVA: 0x0062D890 File Offset: 0x0062BA90
	public IEnumerator LNMIKJCOCDE()
	{
		num = 0UL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[this.pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		sprite = null;
		csteamID = new CSteamID(num);
		if (num != 0UL)
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
			if (ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
		yield break;
	}

	// Token: 0x06011EC6 RID: 73414 RVA: 0x0062D8AC File Offset: 0x0062BAAC
	public IEnumerator HOCOLBHKCHL(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		this.messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		this.messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		yield break;
	}

	// Token: 0x06011EC7 RID: 73415 RVA: 0x0062D8D8 File Offset: 0x0062BAD8
	public void OJACMIDFPFB(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			this.pbase.POMFLOLIOPJ();
		}
		else if (this.pbase.ach12)
		{
			Helpers.ObtainAchievement(-100);
		}
		base.GetComponent<NetworkScene>().GBMJAPGLMGB().PBMFBOOALKA("CameraFilterPack/BlurHole", PhotonTargets.Others, new object[]
		{
			SceneManager.GetActiveScene().name
		});
	}

	// Token: 0x06011EC8 RID: 73416 RVA: 0x0062D93E File Offset: 0x0062BB3E
	[CompilerGenerated]
	private bool CFNBNJJBPFB(RanksSystem.Map IACGDFHKCAE)
	{
		return "workshop." + IACGDFHKCAE.id == this.mapID && IACGDFHKCAE.isLoved;
	}

	// Token: 0x06011EC9 RID: 73417 RVA: 0x0062D974 File Offset: 0x0062BB74
	public void ABFCBLPKIAA()
	{
		if (PhotonNetwork.offlineMode && this.mapID != "Items/")
		{
			Singleton<SaveSystem>.Instance.CONNMLDKBOF(" evLeave: ", true, null);
		}
		if (this.pbase != null)
		{
			this.pbase.DeletePlayerData();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = false;
			}
		}
		base.GetComponent<NetworkScene>().HLPBAPBIMHD(1);
		Singleton<SaveSystem>.Instance.MMMIEPDLMNM();
	}

	// Token: 0x06011ECA RID: 73418 RVA: 0x0062D9F8 File Offset: 0x0062BBF8
	public void PCIOHCMKFBE()
	{
		foreach (AudioSource audioSource in this.asampler.audioSources)
		{
			audioSource.pitch = 1453f;
			audioSource.volume = 1647f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 1; i < array.Length; i++)
		{
			PlayerBase playerBase = array[i];
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
		}
		this.gameOverCanvas.SetActive(false);
		this.spectatorCanvas.SetActive(true);
		this.spectatePanel.SetActive(false);
		this.ingameUICanvas.SetActive(false);
		this.restartCheckpointPanel.SetActive(false);
		this.restartNoCheckpointPanel.SetActive(false);
		this.gameOver = false;
		this.isGameStarted = false;
		this.calculatedmaptime = 864f;
		this.asampler.isMuted = false;
		this.asampler.isInited = false;
		this.DGBKFMMMGIH = false;
		try
		{
			this.OFMDCFHGEEC = this.ingameUICanvas.transform.Find("Reload Maps").gameObject;
			this.OFMDCFHGEEC.transform.Find("InfoText").Find("Joystick1Button11").GetComponent<Image>().color = new Color(486f, 3f, 913f);
			this.OFMDCFHGEEC.GetComponent<Slider>().value = 952f;
		}
		catch (Exception)
		{
		}
		try
		{
			this.PECEGLIIALE = this.ingameUICanvas.transform.FindDeepChild("] to be droppable").GetComponent<Text>();
			this.PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("_RayStepSize").ToUpper() + "_MainTex2" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			this.DILNONPDEBG = Singleton<SaveSystem>.Instance.IOLBIFOIHML("/", false, null);
			this.NCKMNMHOIOH = this.ingameUICanvas.transform.FindDeepChild("_Amount").GetComponent<Text>();
			this.NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			this.comboTextGO = this.ingameUICanvas.transform.FindDeepChild("#EA4137").GetComponent<Text>();
			this.comboTextGO.text = LocalizationService.Instance.HOPMEAJKPHL("_Near").ToUpper() + "CameraFilterPack/Atmosphere_Rain_Pro_3D" + 1;
		}
		catch (Exception)
		{
		}
		base.BDMABAGHOOF(true);
	}

	// Token: 0x06011ECB RID: 73419 RVA: 0x0062DCE0 File Offset: 0x0062BEE0
	public IEnumerator DPCGEHNCEAA(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		this.messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		this.messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		yield break;
	}

	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06011EE1 RID: 73441 RVA: 0x0062F2A9 File Offset: 0x0062D4A9
	// (set) Token: 0x06011ECC RID: 73420 RVA: 0x0062DD0C File Offset: 0x0062BF0C
	public ObscuredFloat HPAnimationTime
	{
		get
		{
			return this.HJPDDLBDGEP;
		}
		set
		{
			this.HJPDDLBDGEP = value;
			if (this.HJPDDLBDGEP >= 0f)
			{
				if (this.asampler.audioSources[0].clip)
				{
					this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
				}
				if (this.asampler.audioSources[1].clip)
				{
					this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
				}
			}
		}
	}

	// Token: 0x06011ECD RID: 73421 RVA: 0x0062DDB7 File Offset: 0x0062BFB7
	private static bool PJPLKPMCFNP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[1] == "'{0}' \t{1}ms \t{2}";
	}

	// Token: 0x06011ECE RID: 73422 RVA: 0x0062DDD0 File Offset: 0x0062BFD0
	public void IEPBHDFAFNE(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			this.gameOverCanvas.SetActive(true);
		}
		if (!this.LFKFNIKPDNI())
		{
			this.spectatePanel.SetActive(true);
		}
		else
		{
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
				this.restartNoCheckpointPanel.SetActive(false);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(false);
				this.restartCheckpointPanel.SetActive(false);
			}
			this.GGINPELGDJF();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 0 && base.GetComponent<NetworkScene>().firstPlayer.player != null && base.GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(93);
			}
		}
		GameObject gameObject = this.levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().FKODENGGPKG();
		}
	}

	// Token: 0x06011ECF RID: 73423 RVA: 0x0062DF60 File Offset: 0x0062C160
	public void HCJKLKMKEOI()
	{
		this.ingameUICanvas.transform.FindDeepChild("\n").GetComponent<Text>().text = this.OOJLKOMPCBI + "turn: {0:0}" + this.pbase.lastBestScore;
		this.loadingCanvas.SetActive(false);
		this.ingameUICanvas.SetActive(false);
		if (this.gameMode == GameScene.GameMode.Relax)
		{
			this.ingameUICanvas.transform.FindDeepChild("_Value6").gameObject.SetActive(true);
			this.PECEGLIIALE.gameObject.SetActive(true);
			this.NCKMNMHOIOH.gameObject.SetActive(true);
			this.comboTextGO.gameObject.SetActive(true);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.APEDOOJPKFC();
		}
	}

	// Token: 0x06011ED0 RID: 73424 RVA: 0x0062E038 File Offset: 0x0062C238
	public void JJNOOCBCFIF(ObscuredFloat DPNHODJHGJL)
	{
		this.HJPDDLBDGEP = DPNHODJHGJL;
		if (this.HJPDDLBDGEP >= 1728f)
		{
			if (this.asampler.audioSources[0].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
			if (this.asampler.audioSources[1].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
		}
	}

	// Token: 0x06011ED1 RID: 73425 RVA: 0x0062E0E4 File Offset: 0x0062C2E4
	public void IKAGPAGAKNM()
	{
		this.ingameUICanvas.transform.FindDeepChild("_Value").GetComponent<Text>().text = this.OOJLKOMPCBI + "[ResourcesManager] Load text error: not found" + this.pbase.lastBestScore;
		this.loadingCanvas.SetActive(false);
		this.ingameUICanvas.SetActive(false);
		if (this.gameMode == GameScene.GameMode.Relax)
		{
			this.ingameUICanvas.transform.FindDeepChild(".lastCheckpoint.checkpointsUsed").gameObject.SetActive(false);
			this.PECEGLIIALE.gameObject.SetActive(false);
			this.NCKMNMHOIOH.gameObject.SetActive(true);
			this.comboTextGO.gameObject.SetActive(true);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.JFPJFJHLPMB();
		}
	}

	// Token: 0x06011ED2 RID: 73426 RVA: 0x0062E1BC File Offset: 0x0062C3BC
	public IEnumerator ShowMessage(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		this.messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		this.messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		yield break;
	}

	// Token: 0x06011ED3 RID: 73427 RVA: 0x0062E1E5 File Offset: 0x0062C3E5
	public void AddMessage(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		this.NBCIEBFNLGN.Add(JKPJCEMPAGH);
		this.INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	// Token: 0x06011ED4 RID: 73428 RVA: 0x0062E1FF File Offset: 0x0062C3FF
	private bool FPCBMKAIOBP(RanksSystem.Map IACGDFHKCAE)
	{
		return "\n" + IACGDFHKCAE.KCGOFGJNCME() == this.mapID && IACGDFHKCAE.GCLPAFADHMD();
	}

	// Token: 0x06011ED5 RID: 73429 RVA: 0x0062E234 File Offset: 0x0062C434
	[CompilerGenerated]
	private bool PCJBMKOMIEP(RanksSystem.Map IACGDFHKCAE)
	{
		return "workshop." + IACGDFHKCAE.id == this.mapID;
	}

	// Token: 0x06011ED6 RID: 73430 RVA: 0x0062E25C File Offset: 0x0062C45C
	public override void Start()
	{
		base.Start();
		this.Reset();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = true;
			PhotonNetwork.JoinOrCreateRoom("offline", new RoomOptions(), TypedLobby.Default);
		}
		this.mapID = Singleton<SaveSystem>.Instance.GetString("menu.selectedlevelid", null);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		int @int = Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0, null);
		this.gameMode = (GameScene.GameMode)@int;
		this.GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper();
		if (this.gameMode != GameScene.GameMode.Hardcore)
		{
			this.NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("#lives").ToUpper();
		}
		else
		{
			this.NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("#accuracy").ToUpper();
		}
		this.OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("#highscore").ToUpper();
		this.PIDICMNEOJL = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper();
		GameObject gameObject = this.levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelInfo, Singleton<MapsSystem>.Instance.GetMapData(this.mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = (!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate<GameObject>(Resources.Load("Gameplay/Base") as GameObject) : PhotonNetwork.Instantiate("Gameplay/Base", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
		this.pbase = gameObject3.GetComponent<PlayerBase>();
		if (this.DILNONPDEBG)
		{
			this.NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			this.NCKMNMHOIOH.gameObject.SetActive(false);
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("Playing " + ((!PhotonNetwork.offlineMode) ? "Multiplayer" : "Solo"), "Map: " + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 0, 0);
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("[GameScene] Checkpoints count: " + mapData.mapData.checkpoints.Count);
		Debug.Log("[GameScene] Events count: " + mapData.mapData.events.Count);
		List<MapEvent> events = mapData.mapData.events;
		if (GameScene.LNIJKGECNME == null)
		{
			GameScene.LNIJKGECNME = new Predicate<MapEvent>(GameScene.NFHPEBCJNMP);
		}
		if (events.Find(GameScene.LNIJKGECNME) != null)
		{
			List<MapEvent> events2 = mapData.mapData.events;
			if (GameScene.CLCBJCKCBDD == null)
			{
				GameScene.CLCBJCKCBDD = new Predicate<MapEvent>(GameScene.NJEMBFEJAKD);
			}
			this.calculatedmaptime = events2.Find(GameScene.CLCBJCKCBDD).time;
		}
		else
		{
			this.calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			this.usingCheckpoints = false;
		}
		if (this.gameMode == GameScene.GameMode.Relax || this.gameMode == GameScene.GameMode.Hardcore || this.gameMode == GameScene.GameMode.Endless)
		{
			this.usingCheckpoints = false;
		}
		this.pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false, null);
			gameEventInfo.gamemode = (int)this.gameMode;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(this.DCDDKMJAHNB));
				gameEventInfo.isloved = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(this.CFNBNJJBPFB));
				gameEventInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(this.HCIFEEEJKHC));
			}
			else
			{
				gameEventInfo.isofficial = false;
				gameEventInfo.isloved = false;
				gameEventInfo.isfunny = false;
			}
			if (RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(this.AJDFAACIKPB)) != null)
			{
				gameEventInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(this.PCJBMKOMIEP)).difficulty;
			}
			else
			{
				gameEventInfo.mapdifficulty = -1f;
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			gameEventInfo.mapid = this.mapID;
			gameEventInfo.maptags = string.Join(",", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		this.pbase.gameEventInfoBase = gameEventInfo;
		this.pbase.InitSystem();
	}

	// Token: 0x06011ED7 RID: 73431 RVA: 0x0062E8D8 File Offset: 0x0062CAD8
	public void OnStartRound()
	{
		this.ingameUICanvas.transform.FindDeepChild("BestScoreText").GetComponent<Text>().text = this.OOJLKOMPCBI + ": " + this.pbase.lastBestScore;
		this.loadingCanvas.SetActive(false);
		this.ingameUICanvas.SetActive(true);
		if (this.gameMode == GameScene.GameMode.Relax)
		{
			this.ingameUICanvas.transform.FindDeepChild("BestScoreText").gameObject.SetActive(false);
			this.PECEGLIIALE.gameObject.SetActive(false);
			this.NCKMNMHOIOH.gameObject.SetActive(false);
			this.comboTextGO.gameObject.SetActive(false);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
	}

	// Token: 0x06011ED8 RID: 73432 RVA: 0x0062E9B0 File Offset: 0x0062CBB0
	private void FHFGOOOFIKO(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("_SecondTex");
			SteamLeaderboard_t hSteamLeaderboard = IAFAANLMOAG.m_hSteamLeaderboard;
			SteamUserStats.UploadLeaderboardScore(hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, this.pbase.GetCurrentScore(), null, 1);
		}
	}

	// Token: 0x06011ED9 RID: 73433 RVA: 0x0062E9F0 File Offset: 0x0062CBF0
	public virtual void AEDDNDHCLNN()
	{
		base.FLKEJJEGCFA();
		this.PCIOHCMKFBE();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.JoinOrCreateRoom("_Green_G", new RoomOptions(), TypedLobby.Default);
		}
		this.mapID = Singleton<SaveSystem>.Instance.NBMEANCMGEH("_Value2", null);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		int num = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_LightIntensity", 0, null);
		this.gameMode = (GameScene.GameMode)num;
		this.GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText("settings.crosshairopacity").ToUpper();
		if (this.gameMode != GameScene.GameMode.Normal)
		{
			this.NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("{0:0} second{1}").ToUpper();
		}
		else
		{
			this.NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("Lag ").ToUpper();
		}
		this.OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("_BlurVector").ToUpper();
		this.PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("menutheme.summerbreeze").ToUpper();
		GameObject gameObject = this.levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.MEGHFGEHEHM(this.levelInfo, Singleton<MapsSystem>.Instance.GetMapData(this.mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().IMJKKFLAEFF();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = (!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate<GameObject>(Resources.Load("maps.") as GameObject) : PhotonNetwork.Instantiate("Scene", new Vector3(779f, 1221f, 200f), Quaternion.identity, 1);
		this.pbase = gameObject3.GetComponent<PlayerBase>();
		if (this.DILNONPDEBG)
		{
			this.NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			this.NCKMNMHOIOH.gameObject.SetActive(false);
		}
		Singleton<GameManager>.Instance.EJGBOJDDMHH(".save" + ((!PhotonNetwork.offlineMode) ? "RarityImage" : "visible"), "MultiplayerButton" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 1, 1);
		if (mapData.source == (FullMapData.MapSource)8 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_Value3" + mapData.mapData.checkpoints.Count);
		Debug.Log("maps." + mapData.mapData.events.Count);
		List<MapEvent> events = mapData.mapData.events;
		if (GameScene.LNIJKGECNME == null)
		{
			GameScene.LNIJKGECNME = new Predicate<MapEvent>(GameScene.PJMIHNIHMAD);
		}
		if (events.Find(GameScene.LNIJKGECNME) != null)
		{
			List<MapEvent> events2 = mapData.mapData.events;
			if (GameScene.CLCBJCKCBDD == null)
			{
				GameScene.CLCBJCKCBDD = new Predicate<MapEvent>(GameScene.OMALKBOMBEO);
			}
			this.calculatedmaptime = events2.Find(GameScene.CLCBJCKCBDD).time;
		}
		else
		{
			this.calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			this.usingCheckpoints = true;
		}
		if (this.gameMode == GameScene.GameMode.Relax || this.gameMode == (GameScene.GameMode)8 || this.gameMode == (GameScene.GameMode)7)
		{
			this.usingCheckpoints = false;
		}
		this.pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.AANPGELPGPN("Right", true, null);
			gameEventInfo.APALNCADHBO((int)this.gameMode);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), false))
			{
				gameEventInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(this.CODFMMBELLL));
				gameEventInfo.isloved = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(this.LLNHIGJPNOA));
				gameEventInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(this.JCJJBIDGIMI));
			}
			else
			{
				gameEventInfo.isofficial = false;
				gameEventInfo.isloved = true;
				gameEventInfo.isfunny = false;
			}
			if (RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(this.CNNFDMJKGKE)) != null)
			{
				gameEventInfo.LHAFCMGGOMO(RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(this.CBDGNINOGFE)).NNDFIJEBENA());
			}
			else
			{
				gameEventInfo.mapdifficulty = 705f;
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			gameEventInfo.mapid = this.mapID;
			gameEventInfo.maptags = string.Join("_Offsets", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		this.pbase.gameEventInfoBase = gameEventInfo;
		this.pbase.JPBHAILACAI();
	}

	// Token: 0x06011EDA RID: 73434 RVA: 0x0062F06C File Offset: 0x0062D26C
	private bool CEMFNJFCPEE(RanksSystem.Map IACGDFHKCAE)
	{
		return "Lag " + IACGDFHKCAE.JGEBJGHEJPK() == this.mapID && IACGDFHKCAE.CDPELGPJPND();
	}

	// Token: 0x06011EDB RID: 73435 RVA: 0x0062F0A4 File Offset: 0x0062D2A4
	public bool AllPlayersWin()
	{
		bool result = true;
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
		{
			if (photonPlayer.CustomProperties["win"] == null || (photonPlayer.CustomProperties["win"] != null && !(bool)photonPlayer.CustomProperties["win"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011EDC RID: 73436 RVA: 0x0062F118 File Offset: 0x0062D318
	public void DCFPNBEMONF()
	{
		if (GameObject.Find("_TimeX"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Lag "));
		}
		else if (GameObject.Find("/"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("deletemap"));
		}
		else if (GameObject.Find("#failed"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("[GameScene] Submiting rank"));
		}
		base.GIIBKOADAMF(true);
	}

	// Token: 0x06011EDD RID: 73437 RVA: 0x0062F1B0 File Offset: 0x0062D3B0
	public void BLCNEDJKELM(ObscuredFloat DPNHODJHGJL)
	{
		this.HJPDDLBDGEP = DPNHODJHGJL;
		if (this.HJPDDLBDGEP >= 828f)
		{
			if (this.asampler.audioSources[1].clip)
			{
				this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			}
			if (this.asampler.audioSources[0].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
		}
	}

	// Token: 0x06011EDE RID: 73438 RVA: 0x0062F25B File Offset: 0x0062D45B
	private static bool ILJAMABHEFP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[1] == "_Value5";
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06011EDF RID: 73439 RVA: 0x0062F273 File Offset: 0x0062D473
	// (set) Token: 0x06011F20 RID: 73504 RVA: 0x00633410 File Offset: 0x00631610
	public ObscuredFloat CurrentMusicTime
	{
		get
		{
			return float.PositiveInfinity;
		}
		set
		{
			this.HJPDDLBDGEP = value;
			if (this.HJPDDLBDGEP >= 0f)
			{
				if (this.asampler.audioSources[1].clip)
				{
					this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
				}
				if (this.asampler.audioSources[0].clip)
				{
					this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
				}
			}
		}
	}

	// Token: 0x06011EE0 RID: 73440 RVA: 0x0062F280 File Offset: 0x0062D480
	public IEnumerator DAFGMNEEOJN(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		this.messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		this.messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		this.messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		yield break;
	}

	// Token: 0x06011EE2 RID: 73442 RVA: 0x0062F2B4 File Offset: 0x0062D4B4
	public void Reset()
	{
		foreach (AudioSource audioSource in this.asampler.audioSources)
		{
			audioSource.pitch = 1f;
			audioSource.volume = 1f;
		}
		foreach (PlayerBase playerBase in UnityEngine.Object.FindObjectsOfType<PlayerBase>())
		{
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
		}
		this.gameOverCanvas.SetActive(false);
		this.spectatorCanvas.SetActive(false);
		this.spectatePanel.SetActive(false);
		this.ingameUICanvas.SetActive(false);
		this.restartCheckpointPanel.SetActive(false);
		this.restartNoCheckpointPanel.SetActive(false);
		this.gameOver = false;
		this.isGameStarted = false;
		this.calculatedmaptime = 0f;
		this.asampler.isMuted = false;
		this.asampler.isInited = false;
		this.DGBKFMMMGIH = false;
		try
		{
			this.OFMDCFHGEEC = this.ingameUICanvas.transform.Find("LevelProgressBar").gameObject;
			this.OFMDCFHGEEC.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = new Color(0.654902f, 0.8784314f, 0.9843137f);
			this.OFMDCFHGEEC.GetComponent<Slider>().value = 0f;
		}
		catch (Exception)
		{
		}
		try
		{
			this.PECEGLIIALE = this.ingameUICanvas.transform.FindDeepChild("ScoreText").GetComponent<Text>();
			this.PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper() + ": " + 0;
		}
		catch (Exception)
		{
		}
		try
		{
			this.DILNONPDEBG = Singleton<SaveSystem>.Instance.GetBool("settings.showHP", true, null);
			this.NCKMNMHOIOH = this.ingameUICanvas.transform.FindDeepChild("HPText").GetComponent<Text>();
			this.NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			this.comboTextGO = this.ingameUICanvas.transform.FindDeepChild("ComboText").GetComponent<Text>();
			this.comboTextGO.text = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper() + ": " + 0;
		}
		catch (Exception)
		{
		}
		base.ShowCursor(false);
	}

	// Token: 0x06011EE3 RID: 73443 RVA: 0x0062F59C File Offset: 0x0062D79C
	private bool NBEDJBNOPPP(RanksSystem.Map IACGDFHKCAE)
	{
		return !("Failed to Instantiate prefab:" + IACGDFHKCAE.CHDCIFPPIFI() == this.mapID) || IACGDFHKCAE.GCLPAFADHMD();
	}

	// Token: 0x06011EE4 RID: 73444 RVA: 0x0062F5D1 File Offset: 0x0062D7D1
	private bool HEHGIADBMOA(RanksSystem.Map IACGDFHKCAE)
	{
		return !("#close" + IACGDFHKCAE.CHDCIFPPIFI() == this.mapID) || IACGDFHKCAE.GPAPLIKKEOH();
	}

	// Token: 0x06011EE5 RID: 73445 RVA: 0x0062F2A9 File Offset: 0x0062D4A9
	public ObscuredFloat EIFMOHOFICD()
	{
		return this.HJPDDLBDGEP;
	}

	// Token: 0x06011EE6 RID: 73446 RVA: 0x0062F608 File Offset: 0x0062D808
	public void OnRestartButton(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			this.pbase.DeletePlayerData();
		}
		else if (this.pbase.ach12)
		{
			Helpers.ObtainAchievement(12);
		}
		base.GetComponent<NetworkScene>().photonView.RPC("OnMastedChangeScene", PhotonTargets.AllViaServer, new object[]
		{
			SceneManager.GetActiveScene().name
		});
	}

	// Token: 0x06011EE7 RID: 73447 RVA: 0x0062F66E File Offset: 0x0062D86E
	public void HAPPBOEODOA()
	{
		this.pbase.SpectateNext(true);
		base.StartCoroutine(this.LNMIKJCOCDE());
	}

	// Token: 0x06011EE8 RID: 73448 RVA: 0x0002523B File Offset: 0x0002343B
	public void HJDPEBAPBPN()
	{
	}

	// Token: 0x06011EE9 RID: 73449 RVA: 0x0002523B File Offset: 0x0002343B
	public void LNIOFCGDDKP()
	{
	}

	// Token: 0x06011EEA RID: 73450 RVA: 0x0062F68C File Offset: 0x0062D88C
	public void ICEICNLMEMO()
	{
		if (PhotonNetwork.offlineMode && this.mapID != "_ScreenResolution")
		{
			Singleton<SaveSystem>.Instance.LBFFJLFBOAM("???", true, null);
		}
		if (this.pbase != null)
		{
			this.pbase.POMFLOLIOPJ();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = true;
			}
		}
		base.GetComponent<NetworkScene>().OnExitButton(1);
		Singleton<SaveSystem>.Instance.MMMIEPDLMNM();
	}

	// Token: 0x06011EEB RID: 73451 RVA: 0x0062F710 File Offset: 0x0062D910
	private static bool OMALKBOMBEO(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "_Value2";
	}

	// Token: 0x06011EEC RID: 73452 RVA: 0x0062F728 File Offset: 0x0062D928
	public void OKKNKLKHAKL(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			this.pbase.DeletePlayerData();
		}
		else if (this.pbase.ach12)
		{
			Helpers.ObtainAchievement(35);
		}
		base.GetComponent<NetworkScene>().ACPGHFHDCIP().RPC("...", PhotonTargets.MasterClient, new object[]
		{
			SceneManager.GetActiveScene().name
		});
	}

	// Token: 0x06011EED RID: 73453 RVA: 0x0062F790 File Offset: 0x0062D990
	public bool GDNMAFDLPHN()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["OpJoinRoom()"] == null || (photonPlayer.CustomProperties["_Tint"] != null && !(bool)photonPlayer.CustomProperties["The region arrays from Name Server are not ok. Must be non-null and same length. "]))
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06011EEE RID: 73454 RVA: 0x0062D166 File Offset: 0x0062B366
	public void OnRestartRound()
	{
		this.loadingCanvas.SetActive(true);
		base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	// Token: 0x06011EEF RID: 73455 RVA: 0x0062F804 File Offset: 0x0062DA04
	private void DFFOABDNEEE(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("[GameScene] Submiting rank");
			SteamLeaderboard_t hSteamLeaderboard = IAFAANLMOAG.m_hSteamLeaderboard;
			SteamUserStats.UploadLeaderboardScore(hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, this.pbase.GetCurrentScore(), null, 0);
		}
	}

	// Token: 0x06011EF0 RID: 73456 RVA: 0x0062F844 File Offset: 0x0062DA44
	public IEnumerator KNNEAOLLKCI()
	{
		num = 0UL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[this.pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		sprite = null;
		csteamID = new CSteamID(num);
		if (num != 0UL)
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
			if (ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
		yield break;
	}

	// Token: 0x06011EF1 RID: 73457 RVA: 0x0062F85F File Offset: 0x0062DA5F
	public void IJDDJAEPCNK()
	{
		this.pbase.SpectateNext(true);
		base.StartCoroutine(this.KNNEAOLLKCI());
	}

	// Token: 0x06011EF2 RID: 73458 RVA: 0x0062F87A File Offset: 0x0062DA7A
	private bool CNNFDMJKGKE(RanksSystem.Map IACGDFHKCAE)
	{
		return "GameModeText" + IACGDFHKCAE.GOMJAEIDHNM() == this.mapID;
	}

	// Token: 0x06011EF3 RID: 73459 RVA: 0x0062F8A1 File Offset: 0x0062DAA1
	private bool CBDGNINOGFE(RanksSystem.Map IACGDFHKCAE)
	{
		return "_TimeX" + IACGDFHKCAE.CHDCIFPPIFI() == this.mapID;
	}

	// Token: 0x06011EF4 RID: 73460 RVA: 0x0062F8C8 File Offset: 0x0062DAC8
	public void PGOFGLJNDEC()
	{
		this.pbase.SpectateNext(true);
		base.StartCoroutine(this.LLNMIAFCGIP());
	}

	// Token: 0x06011EF5 RID: 73461 RVA: 0x0062F8E4 File Offset: 0x0062DAE4
	public override void LBAJLLFMMMP()
	{
		base.KLILJHJNICK();
		this.PCIOHCMKFBE();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.JoinOrCreateRoom("HightScoreMaxPointsText", new RoomOptions(), TypedLobby.Default);
		}
		this.mapID = Singleton<SaveSystem>.Instance.NBMEANCMGEH("{0:0.0} ms ({1:0.} fps)", null);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		int @int = Singleton<SaveSystem>.Instance.GetInt("#ok", 0, null);
		this.gameMode = (GameScene.GameMode)@int;
		this.GIDJMDIODGM = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Glasses_On").ToUpper();
		if (this.gameMode != (GameScene.GameMode)8)
		{
			this.NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper();
		}
		else
		{
			this.NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("_EdgeThresholdMin").ToUpper();
		}
		this.OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("value").ToUpper();
		this.PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("player.fire").ToUpper();
		GameObject gameObject = this.levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.CHALLJOJCDJ(this.levelInfo, Singleton<MapsSystem>.Instance.GetMapData(this.mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source != FullMapData.MapSource.Original && Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().FKOMHOMCJBF();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = (!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate<GameObject>(Resources.Load("_TimeX") as GameObject) : PhotonNetwork.Instantiate("CameraFilterPack/Drawing_Manga_Flash_Color", new Vector3(110f, 1812f, 469f), Quaternion.identity, 0);
		this.pbase = gameObject3.GetComponent<PlayerBase>();
		if (this.DILNONPDEBG)
		{
			this.NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			this.NCKMNMHOIOH.gameObject.SetActive(true);
		}
		Singleton<GameManager>.Instance.IPOGIBLJDPE("_ColorBuffer" + ((!PhotonNetwork.offlineMode) ? "Options" : "If you host Photon yourself, make sure to start the 'Instance LoadBalancing' "), "CameraFilterPack/AAA_Super_Hexagon" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 0, 1);
		if (mapData.source == (FullMapData.MapSource)8 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_MainTex" + mapData.mapData.checkpoints.Count);
		Debug.Log("_Value" + mapData.mapData.events.Count);
		List<MapEvent> events = mapData.mapData.events;
		if (GameScene.LNIJKGECNME == null)
		{
			GameScene.LNIJKGECNME = new Predicate<MapEvent>(GameScene.BIMKNEJLBCJ);
		}
		if (events.Find(GameScene.LNIJKGECNME) != null)
		{
			List<MapEvent> events2 = mapData.mapData.events;
			if (GameScene.CLCBJCKCBDD == null)
			{
				GameScene.CLCBJCKCBDD = new Predicate<MapEvent>(GameScene.NJEMBFEJAKD);
			}
			this.calculatedmaptime = events2.Find(GameScene.CLCBJCKCBDD).time;
		}
		else
		{
			this.calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			this.usingCheckpoints = false;
		}
		if (this.gameMode == GameScene.GameMode.Relax || this.gameMode == GameScene.GameMode.Relax || this.gameMode == GameScene.GameMode.Endless)
		{
			this.usingCheckpoints = false;
		}
		this.pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.ABHJCEENJBC(Singleton<SaveSystem>.Instance.GIHOKCMHMCP("Please specify a map name or buildID", true, null));
			gameEventInfo.gamemode = (int)this.gameMode;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(this.DCDDKMJAHNB));
				gameEventInfo.isloved = RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(this.CFNBNJJBPFB));
				gameEventInfo.isfunny = RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(this.HCIFEEEJKHC));
			}
			else
			{
				gameEventInfo.isofficial = true;
				gameEventInfo.isloved = true;
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(this.AJDFAACIKPB)) != null)
			{
				gameEventInfo.mapdifficulty = RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(this.GBAGCGAJEGH)).NNDFIJEBENA();
			}
			else
			{
				gameEventInfo.LHAFCMGGOMO(1709f);
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			gameEventInfo.mapid = this.mapID;
			gameEventInfo.maptags = string.Join("_Value", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		this.pbase.gameEventInfoBase = gameEventInfo;
		this.pbase.InitSystem();
	}

	// Token: 0x06011EF6 RID: 73462 RVA: 0x0062FF60 File Offset: 0x0062E160
	public void AEKELFJMBPP(ObscuredFloat DPNHODJHGJL)
	{
		this.HJPDDLBDGEP = DPNHODJHGJL;
		if (this.HJPDDLBDGEP >= 1953f)
		{
			if (this.asampler.audioSources[1].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
			if (this.asampler.audioSources[0].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
		}
	}

	// Token: 0x06011EF7 RID: 73463 RVA: 0x0063000B File Offset: 0x0062E20B
	[CompilerGenerated]
	private static bool NFHPEBCJNMP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
	}

	// Token: 0x06011EF8 RID: 73464 RVA: 0x0062D166 File Offset: 0x0062B366
	public void OOFODPKJAGB()
	{
		this.loadingCanvas.SetActive(true);
		base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	// Token: 0x06011EF9 RID: 73465 RVA: 0x00630023 File Offset: 0x0062E223
	private bool HHPKEOCNDDP(RanksSystem.Map IACGDFHKCAE)
	{
		return !("EventSystem" + IACGDFHKCAE.KCGOFGJNCME() == this.mapID) || IACGDFHKCAE.MEFGLBKEHJE();
	}

	// Token: 0x06011EFA RID: 73466 RVA: 0x00630058 File Offset: 0x0062E258
	public bool KFFHJFIJHIC()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["wss://"] == null || (photonPlayer.CustomProperties["_Value"] != null && !(bool)photonPlayer.CustomProperties["offsets"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011EFB RID: 73467 RVA: 0x006300CC File Offset: 0x0062E2CC
	public void ShowGOCanvas(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			this.gameOverCanvas.SetActive(true);
		}
		if (!this.AllPlayersFinished())
		{
			this.spectatePanel.SetActive(true);
		}
		else
		{
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
				this.restartNoCheckpointPanel.SetActive(false);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(true);
				this.restartCheckpointPanel.SetActive(false);
			}
			this.SelectRestartButton();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && base.GetComponent<NetworkScene>().firstPlayer.player != null && base.GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(17);
			}
		}
		GameObject gameObject = this.levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();
		}
	}

	// Token: 0x06011EFC RID: 73468 RVA: 0x0063025B File Offset: 0x0062E45B
	private bool JCJJBIDGIMI(RanksSystem.Map IACGDFHKCAE)
	{
		return "Save Game" + IACGDFHKCAE.id == this.mapID && IACGDFHKCAE.AMJIEEIMBDN();
	}

	// Token: 0x06011EFD RID: 73469 RVA: 0x0002523B File Offset: 0x0002343B
	public void GFBOBIBIOMC()
	{
	}

	// Token: 0x06011EFE RID: 73470 RVA: 0x00630290 File Offset: 0x0062E490
	public bool NECIHAFICEN()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["CameraFilterPack/Vision_AuraDistortion"] == null || (photonPlayer.CustomProperties["VIGNETTE_BLUR"] != null && !(bool)photonPlayer.CustomProperties["st"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011EFF RID: 73471 RVA: 0x0002523B File Offset: 0x0002343B
	public void EMAMCDFBGOA()
	{
	}

	// Token: 0x06011F00 RID: 73472 RVA: 0x00630304 File Offset: 0x0062E504
	public void DAILLIMMGMB(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			this.pbase.POMFLOLIOPJ();
		}
		else if (this.pbase.ach12)
		{
			Helpers.ObtainAchievement(49);
		}
		PhotonView photonView = base.GetComponent<NetworkScene>().IBKCMBIGOEJ();
		string lblkdnnpaco = " Server: ";
		PhotonTargets mpnmoonbmii = (PhotonTargets)7;
		object[] array = new object[0];
		array[1] = SceneManager.GetActiveScene().name;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011F01 RID: 73473 RVA: 0x0063036C File Offset: 0x0062E56C
	public void PGELCEKONCE(string NOJGGCLPPAM = "")
	{
		GameScene.NOANBLPGKBI noanblpgkbi = new GameScene.NOANBLPGKBI();
		noanblpgkbi.ADPIKBBAKHP = this;
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.LBEKBNOGKBK();
		}
		this.gameOver = false;
		base.GetComponent<NetworkScene>().BMOBABEGEFG();
		if (this.AllPlayersFinished())
		{
			this.HJPDDLBDGEP = this.calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			this.OFMDCFHGEEC.transform.Find("_Green_B").Find("_SunColor").GetComponent<Image>().color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "ItemsStoreButton")
		{
			PhotonView photonView = base.GetComponent<NetworkScene>().photonView;
			string lblkdnnpaco = "[UI] Unknows button action: ";
			PhotonTargets mpnmoonbmii = PhotonTargets.All;
			object[] array = new object[8];
			array[1] = PhotonNetwork.playerName;
			array[0] = "BlockCount";
			photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
		}
		if (NOJGGCLPPAM == "ViewMenu")
		{
			this.pbase.isMapCompleted = true;
			this.pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.DHOGHIOACME() >= 3)
		{
			Helpers.ObtainAchievement(-111);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 0)
		{
			Helpers.ObtainAchievement(-85);
		}
		if (this.gameMode != GameScene.GameMode.Relax && this.pbase.GetCurrentScore() > this.pbase.lastBestScore && !this.pbase.scoreBeated && this.pbase.currentAttempt > 1)
		{
			base.StartCoroutine(this.CCKJNHEENJN());
		}
		noanblpgkbi.CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			noanblpgkbi.CBOLFPGKALK = mapData.workshopId;
		}
		this.pbase.IIFDPILKHMO();
		if (this.pbase.GetCurrentScore() >= 0 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("visible", 0, null) == 1 && mapData.source != FullMapData.MapSource.Original && this.gameMode != GameScene.GameMode.Relax && !string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), false))
		{
			string ddaomdpaiep = mapData.fullLevelPath + "_Value2" + Helpers.levelConfigFileName;
			string eafamamdneg = "BadgeText";
			if (this.pbase.Replay() != null)
			{
				RanksSystem.MapReplay value = this.pbase.Replay();
				eafamamdneg = JsonConvert.SerializeObject(value);
			}
			base.StartCoroutine(Singleton<RanksSystem>.Instance.CFGMHNBNPFB(noanblpgkbi.CBOLFPGKALK, this.gameMode, this.pbase.GetCurrentScore(), this.pbase.accuracyScore, this.pbase.incorrectScore, EGOPKJHICLK.CompressString(eafamamdneg), Helpers.CalculateMD5(ddaomdpaiep)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hfefhopolik = "DifficultyBG" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(mapData) + "_TreatBackfaceHitAsMiss";
		int dpnhodjhgjl = Singleton<SaveSystem>.Instance.GetInt("CameraFilterPack/3D_Shield" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(mapData) + "_TimeX", 0, null) + 1;
		Singleton<SaveSystem>.Instance.NHONGIGFHJB(hfefhopolik, dpnhodjhgjl, null);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.KNDDGKJBIDJ(this.pbase.accuracyScore);
			finishedMapInfo.BCFCKNPHPID(this.pbase.isMapCompleted);
			finishedMapInfo.PNDEPBDCKKO(Singleton<SaveSystem>.Instance.GIHOKCMHMCP("SpawnObj", false, null));
			finishedMapInfo.AIBKCDNFAAG((int)this.gameMode);
			finishedMapInfo.loopscount = this.pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), false))
			{
				finishedMapInfo.NLMLEGJAEJC(RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.OFLDIMDDLHM)));
				finishedMapInfo.INMHOFPBLAB(RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.HMMBBDJNGGL)));
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.NEIDGMKKCBI));
			}
			else
			{
				finishedMapInfo.IGCKBAONHGA(true);
				finishedMapInfo.INMHOFPBLAB(false);
				finishedMapInfo.isfunny = false;
			}
			finishedMapInfo.FPEPFJBBANC(!PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = base.GetComponent<NetworkScene>().place;
			if (RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.IKGFMLEODHJ)) != null)
			{
				finishedMapInfo.ABNOACNJLJG(RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.FMBNCFBHLHH)).JEKMHHCPHCN());
			}
			else
			{
				finishedMapInfo.ABNOACNJLJG(166f);
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			finishedMapInfo.mapid = this.mapID;
			finishedMapInfo.DFAEGIMMLJG(string.Join("yyyy-MM-dd HH:mm:ss", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray()));
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
			finishedMapInfo.OBKMGIPPBCJ(this.pbase.incorrectScore);
			finishedMapInfo.OMOBMDJMNHN(this.pbase.perfectHits);
			finishedMapInfo.HIKNMAFMEGN(this.LEFLMCJDFJP());
			finishedMapInfo.NCFGPDBGCGC(this.pbase.GetCurrentScore());
			foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.CABBFJAGFDP(dagalcailln);
			}
			this.pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.OLDEAEGFDAP(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if (this.pbase.isPlayerWon && this.gameMode != GameScene.GameMode.Relax)
		{
			string hfefhopolik2 = "[PlayerController] " + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "color";
			int dpnhodjhgjl2 = 0;
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA(hfefhopolik2, dpnhodjhgjl2, null);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(106);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source == FullMapData.MapSource.Editor)
			{
				Helpers.ObtainAchievement(-126);
			}
			if (!string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.NFDJLPNCFJL)) && !Singleton<SaveSystem>.Instance.LCHPECEJMPE("_ScreenResolution" + this.mapID, true, null))
			{
				Singleton<SaveSystem>.Instance.CONNMLDKBOF("CameraFilterPack/Color_Chromatic_Plus" + this.mapID, true, null);
				Helpers.AddToStat("Editor/", 0);
				SteamUserStats.IndicateAchievementProgress("_Distortion", (uint)Helpers.GetStat("_BlurredColor"), 4294967287U);
			}
			int dpnhodjhgjl3 = (int)(this.pbase.accuracyScore * (float)this.pbase.correctScore);
			Helpers.AddToStat("ShowTitle", dpnhodjhgjl3);
			this.pbase.POMFLOLIOPJ();
			if (this.pbase.accuracyScore >= 666f && mapData.source == FullMapData.MapSource.Editor && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), false) && RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.JIBOGBEMPHH)))
			{
				Helpers.ObtainAchievement(-21);
			}
		}
		if (this.pbase.isPlayerWon && this.gameMode == GameScene.GameMode.Relax && mapData.source == FullMapData.MapSource.Editor)
		{
			Helpers.AddToStat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", 1);
			SteamUserStats.IndicateAchievementProgress(";", (uint)Helpers.GetStat("\n"), 6U);
			if (RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), true) && this.pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(18);
			}
		}
		if (mapData.source == FullMapData.MapSource.Original && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		this.resultText.GetComponent<Text>().text = ((!this.pbase.isPlayerWon) ? LocalizationService.Instance.IAAEBJKAHDD("[MapsData] Bad map: ").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("settings.arcsnohitsoundtimedelay").ToUpper());
		this.OnGameOverEvent.Invoke();
		this.ShowGOCanvas(false);
		this.gameOver = false;
	}

	// Token: 0x06011F02 RID: 73474 RVA: 0x00630CD8 File Offset: 0x0062EED8
	public bool GJBKNJDJDLK()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["_Value3"] == null || (photonPlayer.CustomProperties["Done!"] != null && !(bool)photonPlayer.CustomProperties["ClearEnvironment"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011F03 RID: 73475 RVA: 0x00630D4C File Offset: 0x0062EF4C
	public bool IsRoundFinished()
	{
		return this.gameOver && this.AllPlayersFinished();
	}

	// Token: 0x06011F04 RID: 73476 RVA: 0x00630D74 File Offset: 0x0062EF74
	public void KFAPLCBFMON(ObscuredFloat DPNHODJHGJL)
	{
		this.HJPDDLBDGEP = DPNHODJHGJL;
		if (this.HJPDDLBDGEP >= 227f)
		{
			if (this.asampler.audioSources[0].clip)
			{
				this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			}
			if (this.asampler.audioSources[0].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
		}
	}

	// Token: 0x06011F05 RID: 73477 RVA: 0x00630E20 File Offset: 0x0062F020
	public void KNHENIOHPMF()
	{
		if (PhotonNetwork.offlineMode && this.mapID != " is muted")
		{
			Singleton<SaveSystem>.Instance.LBFFJLFBOAM("[PlayerController] ", false, null);
		}
		if (this.pbase != null)
		{
			this.pbase.DeletePlayerData();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = true;
			}
		}
		base.GetComponent<NetworkScene>().OEEJIBAHEJO(0);
		Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
	}

	// Token: 0x06011F06 RID: 73478 RVA: 0x00630EA4 File Offset: 0x0062F0A4
	public void IDHAOOBEHAE(ObscuredFloat DPNHODJHGJL)
	{
		this.HJPDDLBDGEP = DPNHODJHGJL;
		if (this.HJPDDLBDGEP >= 530f)
		{
			if (this.asampler.audioSources[1].clip)
			{
				this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			}
			if (this.asampler.audioSources[0].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
		}
	}

	// Token: 0x06011F07 RID: 73479 RVA: 0x0062E1E5 File Offset: 0x0062C3E5
	public void PNEHHLMHJAA(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		this.NBCIEBFNLGN.Add(JKPJCEMPAGH);
		this.INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	// Token: 0x06011F08 RID: 73480 RVA: 0x00630F50 File Offset: 0x0062F150
	public virtual void HLDFOJMHKNL()
	{
		base.IBHACCEEFFI();
		if (!this.isGameStarted && this.NMICDBOOLHN())
		{
			this.pbase.AAMNKPHHHCI().MIAHMDGOOPJ("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", (PhotonTargets)8, null);
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > 624f && !this.DGBKFMMMGIH)
		{
			this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			this.asampler.Play(0);
			this.asampler.MKPLCLNPMDP(0);
			this.DGBKFMMMGIH = false;
		}
		if (this.HJPDDLBDGEP < this.calculatedmaptime && !this.IsRoundFinished() && this.isGameStarted)
		{
			this.HJPDDLBDGEP += Time.deltaTime;
			this.OFMDCFHGEEC.GetComponent<Slider>().value = this.HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = this.pbase;
			if (this.pbase.currentState == (PlayerBase.PlayerState)8 && this.pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = this.pbase.spectatedPlayerBase;
			}
			if (this.DILNONPDEBG)
			{
				if (this.gameMode != (GameScene.GameMode)6)
				{
					Text nckmnmhoioh = this.NCKMNMHOIOH;
					object[] array = new object[3];
					array[1] = this.NELDEHEICJD;
					array[1] = "_Value4";
					array[6] = spectatedPlayerBase.BMKCMMJMOKN();
					array[7] = "Save";
					array[1] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nckmnmhoioh.text = string.Concat(array);
				}
				else
				{
					this.NCKMNMHOIOH.text = this.NELDEHEICJD + "RarityImage" + (Math.Floor((double)(spectatedPlayerBase.accuracyScore * 1064f)) / 443.0 * 1075.0).ToString("ERROR You have missing MonoBehaviours on your gameobjects!") + "_Smooth";
				}
			}
			this.PECEGLIIALE.text = this.GIDJMDIODGM + ", " + spectatedPlayerBase.GetCurrentScore();
			Text text = this.comboTextGO;
			object[] array2 = new object[6];
			array2[0] = this.PIDICMNEOJL;
			array2[1] = "player.goldarc";
			array2[8] = "[MapsStats] Map ID: ";
			array2[1] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.AADFFLGEJPP("_SunThreshold") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.GameEvent(dagalcailln);
				}
				this.pbase.gameEventInfoList.Clear();
				this.PMKLNCNMEEE(false);
			}
		}
		if (this.gameOver && this.pbase.currentState == (PlayerBase.PlayerState)8)
		{
			GameScene.CLIFHDIIFCC clifhdiifcc = new GameScene.CLIFHDIIFCC();
			clifhdiifcc.ADPIKBBAKHP = this;
			this.ingameUICanvas.SetActive(true);
			if (this.AllPlayersFinished())
			{
				foreach (AudioSource audioSource in this.asampler.audioSources)
				{
					if (!this.pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 757f, Time.deltaTime * 460f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 1257f, Time.deltaTime * 1481f);
				}
				this.asampler.isMuted = false;
			}
			clifhdiifcc.CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
			if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
			{
				clifhdiifcc.CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(clifhdiifcc.CBOLFPGKALK) && RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(clifhdiifcc.FMIHBNPKEEO)))
			{
				if (GameObject.Find("SpeedSlider"))
				{
					GameObject.Find(". Client should be in a room. Current connectionStateDetailed: ").SetActive(true);
				}
			}
			else
			{
				if (GameObject.Find("Updating..."))
				{
					GameObject.Find("X2").SetActive(true);
				}
				if (GameObject.Find("_TimeX"))
				{
					GameObject.Find("mapselector.filter.rateduponly").SetActive(false);
				}
				if (GameObject.Find("Protocol switch from: "))
				{
					GameObject.Find(" This is not possible to be called for standalone input. Please check your platform and code where this is called").SetActive(true);
				}
				if (GameObject.Find("FavoriteButton"))
				{
					GameObject.Find("unsubscribemap").SetActive(true);
				}
			}
			if ((this.gameMode == GameScene.GameMode.Normal || this.gameMode == GameScene.GameMode.Relax) && GameObject.Find(".icon"))
			{
				GameObject.Find("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/").SetActive(false);
			}
			if (this.gameMode != (GameScene.GameMode)7 && GameObject.Find("_Value"))
			{
				GameObject.Find("offsets").SetActive(true);
			}
			int currentScore = this.pbase.GetCurrentScore();
			if (GameObject.Find("_MainTex2"))
			{
				GameObject.Find("_TimeX").GetComponent<Text>().text = string.Empty + this.pbase.lastBestScore;
			}
			if (GameObject.Find("1177138211"))
			{
				GameObject.Find("CameraFilterPack/Noise_TV_2").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData);
			}
			if (GameObject.Find(" GO:"))
			{
				GameObject.Find("Clears all text from the debug console").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.HOPMEAJKPHL("_Green_B" + this.gameMode.ToString().ToLower() + "Multiplayer").ToUpper();
			}
			if (GameObject.Find("Scene"))
			{
				GameObject.Find("LeaderboardsButton").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (GameObject.Find("Fade"))
			{
				GameObject.Find("IconImage").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore + this.pbase.incorrectScore);
			}
			if (GameObject.Find("ns"))
			{
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + this.pbase.perfectHits;
			}
			if (GameObject.Find("_ScreenResolution"))
			{
				GameObject.Find("event").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore - this.pbase.perfectHits);
			}
			if (GameObject.Find("maps."))
			{
				GameObject.Find("_Value3").GetComponent<Text>().text = string.Empty + this.pbase.incorrectScore;
			}
			if (GameObject.Find("menu.selectedlevelid"))
			{
				GameObject.Find("?").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(this.pbase.comboScore);
			}
			if (GameObject.Find("Hidden/Fast Approximate Anti-aliasing"))
			{
				GameObject.Find("_ScreenResolution").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(this.pbase.penaltyScore);
			}
			if (GameObject.Find("StopMusic"))
			{
				GameObject.Find("Back").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(this.pbase.accuracyScore * 1390f)) / 472.0 * 1877.0).ToString("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending") + "CameraFilterPack/TV_Distorted";
			}
			if (GameObject.Find("_Value7"))
			{
				GameObject.Find("SetParticlesGravity").GetComponent<Text>().text = string.Empty + this.pbase.checkpointsUsed;
			}
			if (GameObject.Find("player.licenceaccepted"))
			{
				GameObject.Find("ArcsNoHitsoundTimeDelaySlider").GetComponent<Text>().text = string.Empty + this.pbase.loopsCount;
			}
			if (GameObject.Find("solo"))
			{
				float num = (float)this.pbase.lastBestScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.AFIPGCELCFA)).PJBPOLLEJFN();
				GameObject.Find("_StretchWidth").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num * 692f)) / 259.0).ToString("SettingsCanvas");
			}
			if (GameObject.Find("COMPLETED"))
			{
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.BHIAMFCFHEA)).MBAFCIHCIOM().ToString("Set sun min/max size");
			}
			if (GameObject.Find("_ColoredChange"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.NGOGBFAINDE)).DEFJMFBIGIM();
				num2 = ((num2 >= 1075f) ? num2 : 251f);
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num2 * 758f)) / 875.0).ToString("Set satellite emission (glow)");
			}
			if (GameObject.Find("OK"))
			{
				GameObject.Find("NEW").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (this.restartNoCheckpointPanel.transform.Find("_MainTex2").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				this.restartNoCheckpointPanel.transform.Find(" is not supported on this platform!").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("Joystick").ToUpper() : LocalizationService.Instance.GetTextByKey("OneHand").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && GameObject.Find("init"))
			{
				GameObject.Find("CameraFilterPack/Distortion_Water_Drop").GetComponent<Button>().interactable = false;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
			}
		}
		if (this.gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.BEEPICMONOD();
		}
		if (this.gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ODADIAEDJFD();
		}
		if (this.gameOver && Singleton<ChallengesManager>.Instance.PIHGMOLGBJF())
		{
			Singleton<ChallengesManager>.Instance.RewardsReadyNotification();
		}
		if (this.GDNMAFDLPHN() && this.pbase.currentState == PlayerBase.PlayerState.Playing && this.spectatePanel.activeSelf)
		{
			this.gameOverCanvas.SetActive(false);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(false);
			this.ingameUICanvas.SetActive(false);
			if (!this.pbase.isPlayerWon && this.pbase.FNLJBBLLMBJ())
			{
				this.restartCheckpointPanel.SetActive(false);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(false);
			}
		}
		if (this.GDNMAFDLPHN() && this.pbase.currentState == PlayerBase.PlayerState.Spectator)
		{
			this.gameOverCanvas.SetActive(false);
			this.spectatorCanvas.SetActive(true);
			this.spectatePanel.SetActive(true);
			this.ingameUICanvas.SetActive(false);
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(false);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(false);
			}
			this.pbase.currentState = PlayerBase.PlayerState.Finished;
		}
		if (!this.isGameStarted || !this.pbase || !PhotonNetwork.inRoom || !this.pbase.isPlayerWon || PhotonNetwork.offlineMode || !this.COCILFAHMMM() || PhotonNetwork.room.EGPGEMJNPFD() > 1)
		{
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > this.calculatedmaptime && !this.gameOver)
		{
			GameScene.ALGLIOKEMAK algliokemak = new GameScene.ALGLIOKEMAK();
			algliokemak.HHFFNOHKAIC = true;
			this.pbase.playerController.objects.ForEach(new Action<GameObject>(algliokemak.FJDBPPKABJE));
			if (algliokemak.HHFFNOHKAIC)
			{
				this.pbase.isMapCompleted = false;
				if (this.gameMode != GameScene.GameMode.Random)
				{
					ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
					{
						{
							"3",
							true
						}
					};
					PhotonNetwork.player.MGMCOJHGJNO(eneebhgaajh, null, false);
					this.pbase.currentState = (PlayerBase.PlayerState)5;
					if (this.pbase.EDIJKHEMPAD().BGJKMGJBPFA())
					{
						ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
						{
							{
								"resetall",
								false
							}
						};
						PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, true);
					}
					this.PLBCBPIOIHF(".highscore");
				}
				else
				{
					this.ILGGMPKMPIN();
				}
			}
		}
		if (this.NBCIEBFNLGN.Count > 1 && !this.messageCanvas.activeSelf)
		{
			string jkpjcempagh = this.NBCIEBFNLGN[1];
			float num3 = 1870f;
			if (this.INGHGBLACKC.Count == this.NBCIEBFNLGN.Count)
			{
				num3 = this.INGHGBLACKC[0];
			}
			base.StartCoroutine(this.PMNKPFIMIID(jkpjcempagh, num3 * Singleton<SaveSystem>.Instance.GetFloat("ConfigVersionSlider", 1586f, null)));
			this.NBCIEBFNLGN.RemoveAt(0);
			this.INGHGBLACKC.RemoveAt(0);
		}
	}

	// Token: 0x06011F09 RID: 73481 RVA: 0x00631FC4 File Offset: 0x006301C4
	[CompilerGenerated]
	private bool DCDDKMJAHNB(RanksSystem.Map IACGDFHKCAE)
	{
		return "workshop." + IACGDFHKCAE.id == this.mapID && IACGDFHKCAE.isOfficial;
	}

	// Token: 0x06011F0A RID: 73482 RVA: 0x0062F66E File Offset: 0x0062D86E
	public void JADKCLIPOCL()
	{
		this.pbase.SpectateNext(true);
		base.StartCoroutine(this.LNMIKJCOCDE());
	}

	// Token: 0x06011F0B RID: 73483 RVA: 0x0062D00A File Offset: 0x0062B20A
	public void AFEGJAFAEHJ()
	{
		this.pbase.SpectateNext(true);
		base.StartCoroutine(this.UpdateSpectatingInfo());
	}

	// Token: 0x06011F0C RID: 73484 RVA: 0x00631FF9 File Offset: 0x006301F9
	public void PIJKHHGIFDI()
	{
		this.pbase.SpectateNext(false);
		base.StartCoroutine(this.UpdateSpectatingInfo());
	}

	// Token: 0x06011F0D RID: 73485 RVA: 0x00632014 File Offset: 0x00630214
	public bool NMICDBOOLHN()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["player.xp"] == null || (photonPlayer.CustomProperties["Have you fully accept the terms?"] != null && !(bool)photonPlayer.CustomProperties["LevelNameInputField"]))
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06011F0E RID: 73486 RVA: 0x00632088 File Offset: 0x00630288
	public bool FJGOEKJIPFD()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["_Rand"] == null || (photonPlayer.CustomProperties["Found best region: '"] != null && !(bool)photonPlayer.CustomProperties["D-Pad Down"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011F0F RID: 73487 RVA: 0x0062E234 File Offset: 0x0062C434
	[CompilerGenerated]
	private bool AJDFAACIKPB(RanksSystem.Map IACGDFHKCAE)
	{
		return "workshop." + IACGDFHKCAE.id == this.mapID;
	}

	// Token: 0x06011F10 RID: 73488 RVA: 0x00631FF9 File Offset: 0x006301F9
	public void FCBBMFAJEFG()
	{
		this.pbase.SpectateNext(false);
		base.StartCoroutine(this.UpdateSpectatingInfo());
	}

	// Token: 0x06011F11 RID: 73489 RVA: 0x006320FC File Offset: 0x006302FC
	public void OKLPMPMHDMG()
	{
		this.loadingCanvas.SetActive(false);
		base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
	}

	// Token: 0x06011F12 RID: 73490 RVA: 0x0063211C File Offset: 0x0063031C
	private IEnumerator DBNMOBILJHL()
	{
		yield return new WaitForSeconds(1f);
		this.pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		this.AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"), 1f);
		string hfefhopolik = string.Concat(new string[]
		{
			"maps.",
			this.mapID,
			".",
			this.gameMode.ToString().ToLower(),
			".highscore"
		});
		if (this.gameMode == GameScene.GameMode.Normal)
		{
			hfefhopolik = "maps." + this.mapID + ".highscore";
		}
		int currentScore = this.pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hfefhopolik, currentScore, null);
		yield break;
	}

	// Token: 0x06011F13 RID: 73491 RVA: 0x00632138 File Offset: 0x00630338
	public override void Update()
	{
		base.Update();
		if (!this.isGameStarted && this.AllPlayerLoaded())
		{
			this.pbase.photonView.RPC("StartRound", PhotonTargets.AllBufferedViaServer, null);
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > 0f && !this.DGBKFMMMGIH)
		{
			this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			this.asampler.Play(0);
			this.asampler.Play(1);
			this.DGBKFMMMGIH = true;
		}
		if (this.HJPDDLBDGEP < this.calculatedmaptime && !this.IsRoundFinished() && this.isGameStarted)
		{
			this.HJPDDLBDGEP += Time.deltaTime;
			this.OFMDCFHGEEC.GetComponent<Slider>().value = this.HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = this.pbase;
			if (this.pbase.currentState == PlayerBase.PlayerState.Spectator && this.pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = this.pbase.spectatedPlayerBase;
			}
			if (this.DILNONPDEBG)
			{
				if (this.gameMode != GameScene.GameMode.Hardcore)
				{
					this.NCKMNMHOIOH.text = string.Concat(new object[]
					{
						this.NELDEHEICJD,
						": ",
						spectatedPlayerBase.lives,
						" / ",
						spectatedPlayerBase.fullLevelData.mapData.maxLives
					});
				}
				else
				{
					this.NCKMNMHOIOH.text = this.NELDEHEICJD + ": " + (Math.Floor((double)(spectatedPlayerBase.accuracyScore * 10000f)) / 10000.0 * 100.0).ToString("0.00") + "%";
				}
			}
			this.PECEGLIIALE.text = this.GIDJMDIODGM + ": " + spectatedPlayerBase.GetCurrentScore();
			this.comboTextGO.text = string.Concat(new object[]
			{
				this.PIDICMNEOJL,
				": ",
				"x",
				spectatedPlayerBase.currentCombo
			});
			if (hardInput.GetKeyDown("restart") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.GameEvent(dagalcailln);
				}
				this.pbase.gameEventInfoList.Clear();
				this.OnRestartButton(true);
			}
		}
		if (this.gameOver && this.pbase.currentState == PlayerBase.PlayerState.Finished)
		{
			GameScene.CLIFHDIIFCC clifhdiifcc = new GameScene.CLIFHDIIFCC();
			clifhdiifcc.ADPIKBBAKHP = this;
			this.ingameUICanvas.SetActive(false);
			if (this.AllPlayersFinished())
			{
				foreach (AudioSource audioSource in this.asampler.audioSources)
				{
					if (!this.pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 0f, Time.deltaTime * 0.5f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 0f, Time.deltaTime * 0.5f);
				}
				this.asampler.isMuted = true;
			}
			clifhdiifcc.CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
			if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
			{
				clifhdiifcc.CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(clifhdiifcc.CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(clifhdiifcc.GBKBDKHPLKG)))
			{
				if (GameObject.Find("FinalScoreText"))
				{
					GameObject.Find("FinalScoreText").SetActive(false);
				}
			}
			else
			{
				if (GameObject.Find("HightScoreMaxPointsText"))
				{
					GameObject.Find("HightScoreMaxPointsText").SetActive(false);
				}
				if (GameObject.Find("PossibleMapPointsText"))
				{
					GameObject.Find("PossibleMapPointsText").SetActive(false);
				}
				if (GameObject.Find("PointsScoreText"))
				{
					GameObject.Find("PointsScoreText").SetActive(false);
				}
				if (GameObject.Find("FinalScoreSmallText"))
				{
					GameObject.Find("FinalScoreSmallText").SetActive(false);
				}
			}
			if ((this.gameMode == GameScene.GameMode.Hardcore || this.gameMode == GameScene.GameMode.Endless) && GameObject.Find("CheckpointsScoreText"))
			{
				GameObject.Find("CheckpointsScoreText").SetActive(false);
			}
			if (this.gameMode != GameScene.GameMode.Endless && GameObject.Find("EndlessLoopsScoreText"))
			{
				GameObject.Find("EndlessLoopsScoreText").SetActive(false);
			}
			int currentScore = this.pbase.GetCurrentScore();
			if (GameObject.Find("LastHighScoreText"))
			{
				GameObject.Find("LastHighScoreText").GetComponent<Text>().text = string.Empty + this.pbase.lastBestScore;
			}
			if (GameObject.Find("PossibleMapMaxScoreText"))
			{
				GameObject.Find("PossibleMapMaxScoreText").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData);
			}
			if (GameObject.Find("GameModeText"))
			{
				GameObject.Find("GameModeText").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.GetLocalizatedText("#" + this.gameMode.ToString().ToLower() + "mode").ToUpper();
			}
			if (GameObject.Find("FinalScoreText"))
			{
				GameObject.Find("FinalScoreText").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (GameObject.Find("TotalHitsScoreText"))
			{
				GameObject.Find("TotalHitsScoreText").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore + this.pbase.incorrectScore);
			}
			if (GameObject.Find("PerfectHitsScoreText"))
			{
				GameObject.Find("PerfectHitsScoreText").GetComponent<Text>().text = string.Empty + this.pbase.perfectHits;
			}
			if (GameObject.Find("CorrectHitsScoreText"))
			{
				GameObject.Find("CorrectHitsScoreText").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore - this.pbase.perfectHits);
			}
			if (GameObject.Find("IncorrectHitsScoreText"))
			{
				GameObject.Find("IncorrectHitsScoreText").GetComponent<Text>().text = string.Empty + this.pbase.incorrectScore;
			}
			if (GameObject.Find("ComboScoreText"))
			{
				GameObject.Find("ComboScoreText").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(this.pbase.comboScore);
			}
			if (GameObject.Find("PenaltyScoreText"))
			{
				GameObject.Find("PenaltyScoreText").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(this.pbase.penaltyScore);
			}
			if (GameObject.Find("AccuracyScoreText"))
			{
				GameObject.Find("AccuracyScoreText").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(this.pbase.accuracyScore * 10000f)) / 10000.0 * 100.0).ToString("0.00") + "%";
			}
			if (GameObject.Find("CheckpointsScoreText"))
			{
				GameObject.Find("CheckpointsScoreText").GetComponent<Text>().text = string.Empty + this.pbase.checkpointsUsed;
			}
			if (GameObject.Find("EndlessLoopsScoreText"))
			{
				GameObject.Find("EndlessLoopsScoreText").GetComponent<Text>().text = string.Empty + this.pbase.loopsCount;
			}
			if (GameObject.Find("HightScoreMaxPointsText"))
			{
				float num = (float)this.pbase.lastBestScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.HMMBBDJNGGL)).difficulty;
				GameObject.Find("HightScoreMaxPointsText").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num * 100f)) / 100.0).ToString("0.00");
			}
			if (GameObject.Find("PossibleMapPointsText"))
			{
				GameObject.Find("PossibleMapPointsText").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.NEIDGMKKCBI)).difficulty.ToString("0.00");
			}
			if (GameObject.Find("PointsScoreText"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.BJGDNLAOMHE)).difficulty;
				num2 = ((num2 >= 0f) ? num2 : 0f);
				GameObject.Find("PointsScoreText").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num2 * 100f)) / 100.0).ToString("0.00");
			}
			if (GameObject.Find("FinalScoreSmallText"))
			{
				GameObject.Find("FinalScoreSmallText").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (this.restartNoCheckpointPanel.transform.Find("ExitButton").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				this.restartNoCheckpointPanel.transform.Find("ExitButton").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("leave").ToUpper() : LocalizationService.Instance.GetTextByKey("tolobby").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && GameObject.Find("ResetButton"))
			{
				GameObject.Find("ResetButton").GetComponent<Button>().interactable = false;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
			}
		}
		if (this.gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.DisplayRanksChanges();
		}
		if (this.gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		if (this.gameOver && Singleton<ChallengesManager>.Instance.HasProgress())
		{
			Singleton<ChallengesManager>.Instance.RewardsReadyNotification();
		}
		if (this.AllPlayersFinished() && this.pbase.currentState == PlayerBase.PlayerState.Finished && this.spectatePanel.activeSelf)
		{
			this.gameOverCanvas.SetActive(true);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(false);
			this.ingameUICanvas.SetActive(false);
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(true);
			}
		}
		if (this.AllPlayersFinished() && this.pbase.currentState == PlayerBase.PlayerState.Spectator)
		{
			this.gameOverCanvas.SetActive(true);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(false);
			this.ingameUICanvas.SetActive(false);
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(true);
			}
			this.pbase.currentState = PlayerBase.PlayerState.Finished;
		}
		if (!this.isGameStarted || !this.pbase || !PhotonNetwork.inRoom || !this.pbase.isPlayerWon || PhotonNetwork.offlineMode || !this.AllPlayersWin() || PhotonNetwork.room.PlayerCount > 1)
		{
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > this.calculatedmaptime && !this.gameOver)
		{
			GameScene.ALGLIOKEMAK algliokemak = new GameScene.ALGLIOKEMAK();
			algliokemak.HHFFNOHKAIC = true;
			this.pbase.playerController.objects.ForEach(new Action<GameObject>(algliokemak.GBKBDKHPLKG));
			if (algliokemak.HHFFNOHKAIC)
			{
				this.pbase.isMapCompleted = true;
				if (this.gameMode != GameScene.GameMode.Endless)
				{
					ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
					{
						{
							"finished",
							true
						}
					};
					PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
					this.pbase.currentState = PlayerBase.PlayerState.Finished;
					if (this.pbase.photonView.isMine)
					{
						ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
						{
							{
								"win",
								true
							}
						};
						PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, false);
					}
					this.ShowResult("CompletedLevel");
				}
				else
				{
					this.RestartEndless();
				}
			}
		}
		if (this.NBCIEBFNLGN.Count > 0 && !this.messageCanvas.activeSelf)
		{
			string jkpjcempagh = this.NBCIEBFNLGN[0];
			float num3 = 1f;
			if (this.INGHGBLACKC.Count == this.NBCIEBFNLGN.Count)
			{
				num3 = this.INGHGBLACKC[0];
			}
			base.StartCoroutine(this.ShowMessage(jkpjcempagh, num3 * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f, null)));
			this.NBCIEBFNLGN.RemoveAt(0);
			this.INGHGBLACKC.RemoveAt(0);
		}
	}

	// Token: 0x06011F14 RID: 73492 RVA: 0x0063000B File Offset: 0x0062E20B
	[CompilerGenerated]
	private static bool NJEMBFEJAKD(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
	}

	// Token: 0x06011F15 RID: 73493 RVA: 0x006331AC File Offset: 0x006313AC
	private IEnumerator KIAADBLIDHD()
	{
		yield return new WaitForSeconds(1f);
		this.pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		this.AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"), 1f);
		hfefhopolik = string.Concat(new string[]
		{
			"maps.",
			this.mapID,
			".",
			this.gameMode.ToString().ToLower(),
			".highscore"
		});
		if (this.gameMode == GameScene.GameMode.Normal)
		{
			hfefhopolik = "maps." + this.mapID + ".highscore";
		}
		currentScore = this.pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hfefhopolik, currentScore, null);
		yield break;
	}

	// Token: 0x06011F16 RID: 73494 RVA: 0x00631FF9 File Offset: 0x006301F9
	public void OnSpectatePrevButton()
	{
		this.pbase.SpectateNext(false);
		base.StartCoroutine(this.UpdateSpectatingInfo());
	}

	// Token: 0x06011F17 RID: 73495 RVA: 0x006331C8 File Offset: 0x006313C8
	private void HFGJLIBIBJE(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("_Value5");
			SteamLeaderboard_t hSteamLeaderboard = IAFAANLMOAG.m_hSteamLeaderboard;
			SteamUserStats.UploadLeaderboardScore(hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, this.pbase.GetCurrentScore(), null, 0);
		}
	}

	// Token: 0x06011F19 RID: 73497 RVA: 0x006332A0 File Offset: 0x006314A0
	public void KBALHGHFKEG(ObscuredFloat DPNHODJHGJL)
	{
		this.HJPDDLBDGEP = DPNHODJHGJL;
		if (this.HJPDDLBDGEP >= 1644f)
		{
			if (this.asampler.audioSources[1].clip)
			{
				this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			}
			if (this.asampler.audioSources[1].clip)
			{
				this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			}
		}
	}

	// Token: 0x06011F1A RID: 73498 RVA: 0x0002523B File Offset: 0x0002343B
	public void MDMDGKHDPKP()
	{
	}

	// Token: 0x06011F1B RID: 73499 RVA: 0x0062F2A9 File Offset: 0x0062D4A9
	public ObscuredFloat LEFLMCJDFJP()
	{
		return this.HJPDDLBDGEP;
	}

	// Token: 0x06011F1C RID: 73500 RVA: 0x006320FC File Offset: 0x006302FC
	public void FCHMHBLECEA()
	{
		this.loadingCanvas.SetActive(false);
		base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
	}

	// Token: 0x06011F1D RID: 73501 RVA: 0x0063334B File Offset: 0x0063154B
	private bool LLNHIGJPNOA(RanksSystem.Map IACGDFHKCAE)
	{
		return "_TimeX" + IACGDFHKCAE.id == this.mapID && IACGDFHKCAE.JMMAPHACFAG();
	}

	// Token: 0x06011F1E RID: 73502 RVA: 0x00633380 File Offset: 0x00631580
	private IEnumerator GGKLGOENNGK()
	{
		yield return new WaitForSeconds(1f);
		this.pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		this.AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"), 1f);
		hfefhopolik = string.Concat(new string[]
		{
			"maps.",
			this.mapID,
			".",
			this.gameMode.ToString().ToLower(),
			".highscore"
		});
		if (this.gameMode == GameScene.GameMode.Normal)
		{
			hfefhopolik = "maps." + this.mapID + ".highscore";
		}
		currentScore = this.pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hfefhopolik, currentScore, null);
		yield break;
	}

	// Token: 0x06011F1F RID: 73503 RVA: 0x0063339C File Offset: 0x0063159C
	public bool AllPlayersFinished()
	{
		bool result = true;
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
		{
			if (photonPlayer.CustomProperties["finished"] == null || (photonPlayer.CustomProperties["finished"] != null && !(bool)photonPlayer.CustomProperties["finished"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011F21 RID: 73505 RVA: 0x006334BC File Offset: 0x006316BC
	public void OnSpectateButton()
	{
		this.restartCheckpointPanel.SetActive(false);
		this.restartNoCheckpointPanel.SetActive(false);
		this.gameOverCanvas.SetActive(false);
		this.spectatorCanvas.SetActive(true);
		base.StartCoroutine(this.UpdateSpectatingInfo());
		this.pbase.StartSpectating();
	}

	// Token: 0x06011F22 RID: 73506 RVA: 0x00633514 File Offset: 0x00631714
	public virtual void KDJEJBBDILE()
	{
		base.BGFJOEPFOPM();
		if (!this.isGameStarted && this.AllPlayerLoaded())
		{
			this.pbase.GMAHNPNHMFK().IKIJDNPJKPM("mapid", PhotonTargets.Others, null);
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > 1585f && !this.DGBKFMMMGIH)
		{
			this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			this.asampler.audioSources[0].time = this.HJPDDLBDGEP;
			this.asampler.EFGFFEECBAF(0);
			this.asampler.NPAGHEOHGEF(0);
			this.DGBKFMMMGIH = false;
		}
		if (this.HJPDDLBDGEP < this.calculatedmaptime && !this.IsRoundFinished() && this.isGameStarted)
		{
			this.HJPDDLBDGEP += Time.deltaTime;
			this.OFMDCFHGEEC.GetComponent<Slider>().value = this.HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = this.pbase;
			if (this.pbase.currentState == PlayerBase.PlayerState.Finished && this.pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = this.pbase.spectatedPlayerBase;
			}
			if (this.DILNONPDEBG)
			{
				if (this.gameMode != GameScene.GameMode.Relax)
				{
					Text nckmnmhoioh = this.NCKMNMHOIOH;
					object[] array = new object[4];
					array[0] = this.NELDEHEICJD;
					array[0] = "_Value3";
					array[3] = spectatedPlayerBase.NCBBBJINGMM();
					array[7] = "FullscreenToggle";
					array[7] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nckmnmhoioh.text = string.Concat(array);
				}
				else
				{
					this.NCKMNMHOIOH.text = this.NELDEHEICJD + "_Value" + (Math.Floor((double)(spectatedPlayerBase.accuracyScore * 547f)) / 1003.0 * 1000.0).ToString("_RampTex") + " beatThreshold: ";
				}
			}
			this.PECEGLIIALE.text = this.GIDJMDIODGM + "_Distortion" + spectatedPlayerBase.GetCurrentScore();
			Text text = this.comboTextGO;
			object[] array2 = new object[6];
			array2[0] = this.PIDICMNEOJL;
			array2[1] = "Joystick1Button1";
			array2[3] = "maps.";
			array2[1] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.GetKeyDown("GlassDistortion") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.GameEvent(dagalcailln);
				}
				this.pbase.gameEventInfoList.Clear();
				this.DAILLIMMGMB(true);
			}
		}
		if (this.gameOver && this.pbase.currentState == PlayerBase.PlayerState.Loading)
		{
			GameScene.CLIFHDIIFCC clifhdiifcc = new GameScene.CLIFHDIIFCC();
			clifhdiifcc.ADPIKBBAKHP = this;
			this.ingameUICanvas.SetActive(true);
			if (this.AllPlayersFinished())
			{
				foreach (AudioSource audioSource in this.asampler.audioSources)
				{
					if (!this.pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 945f, Time.deltaTime * 1100f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 98f, Time.deltaTime * 1802f);
				}
				this.asampler.isMuted = false;
			}
			clifhdiifcc.CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
			if (mapData.source == (FullMapData.MapSource)3 && !string.IsNullOrEmpty(mapData.workshopId))
			{
				clifhdiifcc.CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(clifhdiifcc.CBOLFPGKALK) && RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(clifhdiifcc.GBKBDKHPLKG)))
			{
				if (GameObject.Find("#failed: "))
				{
					GameObject.Find("DPADHOR").SetActive(false);
				}
			}
			else
			{
				if (GameObject.Find("_Blood"))
				{
					GameObject.Find("System.Single").SetActive(false);
				}
				if (GameObject.Find("_Value4"))
				{
					GameObject.Find("_Far").SetActive(false);
				}
				if (GameObject.Find("[ResourcesManager] Load image error: "))
				{
					GameObject.Find("FinishMap").SetActive(false);
				}
				if (GameObject.Find("settings.shaders"))
				{
					GameObject.Find("Selection Box").SetActive(true);
				}
			}
			if ((this.gameMode == GameScene.GameMode.Relax || this.gameMode == (GameScene.GameMode)8) && GameObject.Find("SetRotation"))
			{
				GameObject.Find("menu.playedsolo").SetActive(true);
			}
			if (this.gameMode != GameScene.GameMode.Relax && GameObject.Find("ENABLE_COLOR_GRADING"))
			{
				GameObject.Find("BadgeText").SetActive(false);
			}
			int currentScore = this.pbase.GetCurrentScore();
			if (GameObject.Find("/"))
			{
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + this.pbase.lastBestScore;
			}
			if (GameObject.Find("maps."))
			{
				GameObject.Find("_Value4").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData);
			}
			if (GameObject.Find("/"))
			{
				GameObject.Find("path").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.HOPMEAJKPHL("(master)" + this.gameMode.ToString().ToLower() + "_Value4").ToUpper();
			}
			if (GameObject.Find("PLEASE WAIT"))
			{
				GameObject.Find("player.dragon").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (GameObject.Find("NEW_ACHIEVEMENT_1_21"))
			{
				GameObject.Find("CameraFilterPack/Distortion_Flag").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore + this.pbase.incorrectScore);
			}
			if (GameObject.Find("CameraFilterPack_TV_Noise3"))
			{
				GameObject.Find(".mp3").GetComponent<Text>().text = string.Empty + this.pbase.perfectHits;
			}
			if (GameObject.Find("<b>HP</b>:"))
			{
				GameObject.Find("_ColorG").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore - this.pbase.perfectHits);
			}
			if (GameObject.Find("/icon"))
			{
				GameObject.Find("Set particless emission (glow)").GetComponent<Text>().text = string.Empty + this.pbase.incorrectScore;
			}
			if (GameObject.Find("Month_"))
			{
				GameObject.Find("_TimeX").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(this.pbase.comboScore);
			}
			if (GameObject.Find("_TimeX"))
			{
				GameObject.Find("settings.shaders").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(this.pbase.penaltyScore);
			}
			if (GameObject.Find("ViewMenu"))
			{
				GameObject.Find("_Value9").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(this.pbase.accuracyScore * 214f)) / 804.0 * 1583.0).ToString(".lastCheckpoint.powerupsScore") + "IconImage";
			}
			if (GameObject.Find("_MaxBlurRadius"))
			{
				GameObject.Find("Bad parameters for getbool! Use <key> <value>").GetComponent<Text>().text = string.Empty + this.pbase.checkpointsUsed;
			}
			if (GameObject.Find("PS Home"))
			{
				GameObject.Find("_FrustumCornersWS").GetComponent<Text>().text = string.Empty + this.pbase.loopsCount;
			}
			if (GameObject.Find("Set Sun MaxSize"))
			{
				float num = (float)this.pbase.lastBestScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.NFHJNMELIEI)).IFMFDMKFJBI();
				GameObject.Find("_TimeX").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num * 1515f)) / 1743.0).ToString("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
			}
			if (GameObject.Find("_Intensity"))
			{
				GameObject.Find("_Blend").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.FDIHIDKBBAD)).BAFALKHFFMK().ToString("/icon");
			}
			if (GameObject.Find("score:"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.CNLHKMJBMBK)).IFMFDMKFJBI();
				num2 = ((num2 >= 1619f) ? num2 : 1388f);
				GameObject.Find("DPADVER").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num2 * 279f)) / 243.0).ToString("[Down]");
			}
			if (GameObject.Find("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: "))
			{
				GameObject.Find("maps.").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (this.restartNoCheckpointPanel.transform.Find("player.goldarc").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				this.restartNoCheckpointPanel.transform.Find("_Value").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("_Intensity").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("JoinRandom failed: {0}.").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && GameObject.Find("_DistortionWave"))
			{
				GameObject.Find("y").GetComponent<Button>().interactable = true;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
			}
		}
		if (this.gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.PMHFJKDEOMG();
		}
		if (this.gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.LGGNNFBLJFC();
		}
		if (this.gameOver && Singleton<ChallengesManager>.Instance.LHCINEGDJCM())
		{
			Singleton<ChallengesManager>.Instance.AJOOJLMPNMO();
		}
		if (this.LFKFNIKPDNI() && this.pbase.currentState == PlayerBase.PlayerState.Playing && this.spectatePanel.activeSelf)
		{
			this.gameOverCanvas.SetActive(false);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(true);
			this.ingameUICanvas.SetActive(true);
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(false);
			}
		}
		if (this.AllPlayersFinished() && this.pbase.currentState == PlayerBase.PlayerState.Finished)
		{
			this.gameOverCanvas.SetActive(true);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(true);
			this.ingameUICanvas.SetActive(false);
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(false);
			}
			this.pbase.currentState = (PlayerBase.PlayerState)7;
		}
		if (!this.isGameStarted || !this.pbase || !PhotonNetwork.inRoom || !this.pbase.isPlayerWon || PhotonNetwork.offlineMode || !this.AllPlayersWin() || PhotonNetwork.room.DHOGHIOACME() > 0)
		{
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > this.calculatedmaptime && !this.gameOver)
		{
			GameScene.ALGLIOKEMAK algliokemak = new GameScene.ALGLIOKEMAK();
			algliokemak.HHFFNOHKAIC = true;
			this.pbase.playerController.objects.ForEach(new Action<GameObject>(algliokemak.FIPCLHEKKCA));
			if (algliokemak.HHFFNOHKAIC)
			{
				this.pbase.isMapCompleted = false;
				if (this.gameMode != GameScene.GameMode.Hidden)
				{
					ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
					{
						{
							"StartButton",
							true
						}
					};
					PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, true);
					this.pbase.currentState = (PlayerBase.PlayerState)6;
					if (this.pbase.GBHNDHLAJLI().isMine)
					{
						ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
						{
							{
								"Set Satellite Trail MinVertexDistance",
								true
							}
						};
						PhotonNetwork.player.MGMCOJHGJNO(eneebhgaajh2, null, false);
					}
					this.PGELCEKONCE(" ");
				}
				else
				{
					this.ILGGMPKMPIN();
				}
			}
		}
		if (this.NBCIEBFNLGN.Count > 0 && !this.messageCanvas.activeSelf)
		{
			string jkpjcempagh = this.NBCIEBFNLGN[1];
			float num3 = 1842f;
			if (this.INGHGBLACKC.Count == this.NBCIEBFNLGN.Count)
			{
				num3 = this.INGHGBLACKC[0];
			}
			base.StartCoroutine(this.DPCGEHNCEAA(jkpjcempagh, num3 * Singleton<SaveSystem>.Instance.GetFloat("Populate Mesh Data", 686f, null)));
			this.NBCIEBFNLGN.RemoveAt(0);
			this.INGHGBLACKC.RemoveAt(1);
		}
	}

	// Token: 0x06011F23 RID: 73507 RVA: 0x00634588 File Offset: 0x00632788
	public void PLBCBPIOIHF(string NOJGGCLPPAM = "")
	{
		GameScene.NOANBLPGKBI noanblpgkbi = new GameScene.NOANBLPGKBI();
		noanblpgkbi.ADPIKBBAKHP = this;
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.ShowChat();
		}
		this.gameOver = true;
		base.GetComponent<NetworkScene>().OLBAIFGLAJM();
		if (this.KFFHJFIJHIC())
		{
			this.HJPDDLBDGEP = this.calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			this.OFMDCFHGEEC.transform.Find("Init").Find("[PlayerBase] Unknown event: ").GetComponent<Image>().color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "MenuScene")
		{
			PhotonView photonView = base.GetComponent<NetworkScene>().photonView;
			string lblkdnnpaco = "float,0";
			PhotonTargets mpnmoonbmii = PhotonTargets.Others;
			object[] array = new object[5];
			array[0] = PhotonNetwork.playerName;
			array[0] = "USE_PREDICATION";
			photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
		}
		if (NOJGGCLPPAM == "_Value4")
		{
			this.pbase.isMapCompleted = false;
			this.pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 6)
		{
			Helpers.ObtainAchievement(99);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.EGPGEMJNPFD() == 0)
		{
			Helpers.ObtainAchievement(0);
		}
		if (this.gameMode != GameScene.GameMode.Relax && this.pbase.GetCurrentScore() > this.pbase.lastBestScore && !this.pbase.scoreBeated && this.pbase.currentAttempt > 1)
		{
			base.StartCoroutine(this.KIAADBLIDHD());
		}
		noanblpgkbi.CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		if (mapData.source == (FullMapData.MapSource)3 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			noanblpgkbi.CBOLFPGKALK = mapData.workshopId;
		}
		this.pbase.IIFDPILKHMO();
		if (this.pbase.GetCurrentScore() >= 1 && GameManager.ONIMHMBKEHG() && Singleton<SaveSystem>.Instance.CMAFBKOEPLP("#mapby", 0, null) == 0 && mapData.source != FullMapData.MapSource.Editor && this.gameMode != GameScene.GameMode.Relax && !string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), true))
		{
			string ddaomdpaiep = mapData.fullLevelPath + "_ColorB" + Helpers.levelConfigFileName;
			string eafamamdneg = "Texture2";
			if (this.pbase.Replay() != null)
			{
				RanksSystem.MapReplay value = this.pbase.Replay();
				eafamamdneg = JsonConvert.SerializeObject(value);
			}
			base.StartCoroutine(Singleton<RanksSystem>.Instance.DJHAGBKILNI(noanblpgkbi.CBOLFPGKALK, this.gameMode, this.pbase.GetCurrentScore(), this.pbase.accuracyScore, this.pbase.incorrectScore, EGOPKJHICLK.CompressString(eafamamdneg), Helpers.CalculateMD5(ddaomdpaiep)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hfefhopolik = "player.dragon" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Month_";
		int dpnhodjhgjl = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_MainTex2" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(mapData) + "workshop.", 0, null) + 1;
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA(hfefhopolik, dpnhodjhgjl, null);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = this.pbase.accuracyScore;
			finishedMapInfo.BCFCKNPHPID(this.pbase.isMapCompleted);
			finishedMapInfo.PNDEPBDCKKO(!Singleton<SaveSystem>.Instance.LCHPECEJMPE("_Color", true, null));
			finishedMapInfo.EDOFADAPLLB((int)this.gameMode);
			finishedMapInfo.loopscount = this.pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), true))
			{
				finishedMapInfo.IGCKBAONHGA(RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.FJDBPPKABJE)));
				finishedMapInfo.OHOGEANBEKM(RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.FBGMHPEEIFC)));
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.PBHFICAHLJK));
			}
			else
			{
				finishedMapInfo.NLMLEGJAEJC(true);
				finishedMapInfo.INMHOFPBLAB(true);
				finishedMapInfo.isfunny = true;
			}
			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.EGPGEMJNPFD();
			finishedMapInfo.multiplayerplace = base.GetComponent<NetworkScene>().place;
			if (RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.JKIOEELDEFJ)) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.CMHELGPCEHI)).IFMFDMKFJBI();
			}
			else
			{
				finishedMapInfo.ABNOACNJLJG(422f);
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			finishedMapInfo.NCIOHFAJOBI(this.mapID);
			finishedMapInfo.maptags = string.Join("CameraFilterPack/Gradients_Hue", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
			finishedMapInfo.misses = this.pbase.incorrectScore;
			finishedMapInfo.perfecthits = this.pbase.perfectHits;
			finishedMapInfo.time = this.EIFMOHOFICD();
			finishedMapInfo.score = this.pbase.GetCurrentScore();
			foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.CABBFJAGFDP(dagalcailln);
			}
			this.pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.IFOBNIOIEEL(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if (this.pbase.isPlayerWon && this.gameMode != GameScene.GameMode.Relax)
		{
			string hfefhopolik2 = "Bad parameters for getbool! Use <key> <value>" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "_ScreenResolution";
			int dpnhodjhgjl2 = 1;
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA(hfefhopolik2, dpnhodjhgjl2, null);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(-62);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source == FullMapData.MapSource.Original)
			{
				Helpers.ObtainAchievement(44);
			}
			if (!string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.LMMPGEHHFCM)) && !Singleton<SaveSystem>.Instance.GetBool(" cannot be used as a 3D LUT." + this.mapID, false, null))
			{
				Singleton<SaveSystem>.Instance.CMLFCHINKCH("_CenterX" + this.mapID, true, null);
				Helpers.AddToStat("_Value", 1);
				SteamUserStats.IndicateAchievementProgress("PUNCloudBestRegion", (uint)Helpers.GetStat("["), 4294967181U);
			}
			int dpnhodjhgjl3 = (int)(this.pbase.accuracyScore * (float)this.pbase.correctScore);
			Helpers.AddToStat("_Value4", dpnhodjhgjl3);
			this.pbase.DeletePlayerData();
			if (this.pbase.accuracyScore >= 441f && mapData.source == (FullMapData.MapSource)5 && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), true) && RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.MLKBGKFJFAO)))
			{
				Helpers.ObtainAchievement(-8);
			}
		}
		if (this.pbase.isPlayerWon && this.gameMode == GameScene.GameMode.Relax && mapData.source == (FullMapData.MapSource)6)
		{
			Helpers.AddToStat("settings.arcshitsoundtimedelay", 1);
			SteamUserStats.IndicateAchievementProgress("_Value4", (uint)Helpers.GetStat("/"), 4U);
			if (RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), true) && this.pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(-118);
			}
		}
		if (mapData.source == (FullMapData.MapSource)4 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		this.resultText.GetComponent<Text>().text = ((!this.pbase.isPlayerWon) ? LocalizationService.Instance.IAAEBJKAHDD("_TimeX").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("_FarCamera").ToUpper());
		this.OnGameOverEvent.Invoke();
		this.IEPBHDFAFNE(true);
		this.gameOver = false;
	}

	// Token: 0x06011F24 RID: 73508 RVA: 0x0062E1E5 File Offset: 0x0062C3E5
	public void OHOJFIKCLPI(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		this.NBCIEBFNLGN.Add(JKPJCEMPAGH);
		this.INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	// Token: 0x06011F25 RID: 73509 RVA: 0x00634EF4 File Offset: 0x006330F4
	public bool LFKFNIKPDNI()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["input"] == null || (photonPlayer.CustomProperties["Object ID. Case-Sensitive"] != null && !(bool)photonPlayer.CustomProperties["_Value2"]))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06011F26 RID: 73510 RVA: 0x00634F68 File Offset: 0x00633168
	public void PPBFBGEICEF()
	{
		if (GameObject.Find("CameraFilterPack/Drawing_Paper3"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("#yes"));
		}
		else if (GameObject.Find("_BilateralUpsampling"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Text"));
		}
		else if (GameObject.Find("ConfigVersionSlider"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("[Singleton] multiple instances of '"));
		}
		base.CIEGLBDAOOI(false);
	}

	// Token: 0x06011F27 RID: 73511 RVA: 0x00634FFE File Offset: 0x006331FE
	public void IJMADCNFKCE()
	{
		this.pbase.SpectateNext(false);
		base.StartCoroutine(this.LLNMIAFCGIP());
	}

	// Token: 0x06011F28 RID: 73512 RVA: 0x0063501C File Offset: 0x0063321C
	public void RestartEndless()
	{
		PlayerBase playerBase = this.pbase;
		playerBase.loopsCount++;
		base.StartCoroutine(this.ShowMessage("#loopnumber " + this.pbase.loopsCount, 1f * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f, null)));
		this.DGBKFMMMGIH = false;
		this.HJPDDLBDGEP = -1f;
		this.pbase.ResetEndless();
	}

	// Token: 0x06011F29 RID: 73513 RVA: 0x006350B0 File Offset: 0x006332B0
	public void ILGGMPKMPIN()
	{
		PlayerBase playerBase = this.pbase;
		playerBase.loopsCount += 0;
		base.StartCoroutine(this.HOCOLBHKCHL("_Value4" + this.pbase.loopsCount, 1068f * Singleton<SaveSystem>.Instance.NPNOOLFEDKN("Warning: No Shape Curve set for CurveWaveform.cs on ", 216f, null)));
		this.DGBKFMMMGIH = true;
		this.HJPDDLBDGEP = 506f;
		this.pbase.ResetEndless();
	}

	// Token: 0x06011F2A RID: 73514 RVA: 0x0062F2A9 File Offset: 0x0062D4A9
	public ObscuredFloat DADGJKNFIIK()
	{
		return this.HJPDDLBDGEP;
	}

	// Token: 0x06011F2B RID: 73515 RVA: 0x0062F2A9 File Offset: 0x0062D4A9
	public ObscuredFloat PJHGHEKLOCH()
	{
		return this.HJPDDLBDGEP;
	}

	// Token: 0x06011F2C RID: 73516 RVA: 0x00635144 File Offset: 0x00633344
	public void OnExitButton()
	{
		if (PhotonNetwork.offlineMode && this.mapID != "original.tutorial")
		{
			Singleton<SaveSystem>.Instance.SetBool("menu.playedsolo", true, null);
		}
		if (this.pbase != null)
		{
			this.pbase.DeletePlayerData();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = false;
			}
		}
		base.GetComponent<NetworkScene>().OnExitButton(0);
		Singleton<SaveSystem>.Instance.Flush();
	}

	// Token: 0x06011F2D RID: 73517 RVA: 0x006351C8 File Offset: 0x006333C8
	private IEnumerator CHOCDHEBDIE()
	{
		yield return new WaitForSeconds(1f);
		this.pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		this.AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"), 1f);
		hfefhopolik = string.Concat(new string[]
		{
			"maps.",
			this.mapID,
			".",
			this.gameMode.ToString().ToLower(),
			".highscore"
		});
		if (this.gameMode == GameScene.GameMode.Normal)
		{
			hfefhopolik = "maps." + this.mapID + ".highscore";
		}
		currentScore = this.pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hfefhopolik, currentScore, null);
		yield break;
	}

	// Token: 0x06011F2E RID: 73518 RVA: 0x006351E4 File Offset: 0x006333E4
	public virtual void AEIJFLJEABG()
	{
		base.MBLDJEFBLFL();
		if (!this.isGameStarted && this.NMICDBOOLHN())
		{
			this.pbase.OELHGNKAMEG().KEKKFNNMLMG("IconImage", PhotonTargets.AllBufferedViaServer, null);
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > 1101f && !this.DGBKFMMMGIH)
		{
			this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			this.asampler.MKPLCLNPMDP(0);
			this.asampler.Play(1);
			this.DGBKFMMMGIH = true;
		}
		if (this.HJPDDLBDGEP < this.calculatedmaptime && !this.IsRoundFinished() && this.isGameStarted)
		{
			this.HJPDDLBDGEP += Time.deltaTime;
			this.OFMDCFHGEEC.GetComponent<Slider>().value = this.HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = this.pbase;
			if (this.pbase.currentState == (PlayerBase.PlayerState)4 && this.pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = this.pbase.spectatedPlayerBase;
			}
			if (this.DILNONPDEBG)
			{
				if (this.gameMode != GameScene.GameMode.Relax)
				{
					Text nckmnmhoioh = this.NCKMNMHOIOH;
					object[] array = new object[0];
					array[0] = this.NELDEHEICJD;
					array[0] = "&search=";
					array[8] = spectatedPlayerBase.LJBFCKKNPGN();
					array[5] = "SetSatelliteInput";
					array[4] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nckmnmhoioh.text = string.Concat(array);
				}
				else
				{
					this.NCKMNMHOIOH.text = this.NELDEHEICJD + "FullscreenToggle" + (Math.Floor((double)(spectatedPlayerBase.accuracyScore * 913f)) / 1025.0 * 585.0).ToString("_TimeX") + "_Size";
				}
			}
			this.PECEGLIIALE.text = this.GIDJMDIODGM + "RB" + spectatedPlayerBase.GetCurrentScore();
			Text text = this.comboTextGO;
			object[] array2 = new object[6];
			array2[0] = this.PIDICMNEOJL;
			array2[1] = "st";
			array2[2] = "#E14FFF";
			array2[4] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.CHAJOGCCKDA("maps.") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.FODNDEKALAO(dagalcailln);
				}
				this.pbase.gameEventInfoList.Clear();
				this.PMKLNCNMEEE(false);
			}
		}
		if (this.gameOver && this.pbase.currentState == (PlayerBase.PlayerState)8)
		{
			GameScene.CLIFHDIIFCC clifhdiifcc = new GameScene.CLIFHDIIFCC();
			clifhdiifcc.ADPIKBBAKHP = this;
			this.ingameUICanvas.SetActive(true);
			if (this.AllPlayersFinished())
			{
				foreach (AudioSource audioSource in this.asampler.audioSources)
				{
					if (!this.pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 833f, Time.deltaTime * 1201f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 1349f, Time.deltaTime * 888f);
				}
				this.asampler.isMuted = true;
			}
			clifhdiifcc.CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
			if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
			{
				clifhdiifcc.CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(clifhdiifcc.CBOLFPGKALK) && RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(clifhdiifcc.IPPEMIOOKJK)))
			{
				if (GameObject.Find("UseScanLine"))
				{
					GameObject.Find("UI Extensions/UIScreen").SetActive(true);
				}
			}
			else
			{
				if (GameObject.Find("_Blue_B"))
				{
					GameObject.Find(":").SetActive(false);
				}
				if (GameObject.Find("note.7"))
				{
					GameObject.Find("ArcsHitsoundTimeDelaySlider").SetActive(false);
				}
				if (GameObject.Find("_ScreenResolution"))
				{
					GameObject.Find("VisionBlur").SetActive(true);
				}
				if (GameObject.Find("int"))
				{
					GameObject.Find("_Value2").SetActive(false);
				}
			}
			if ((this.gameMode == GameScene.GameMode.Endless || this.gameMode == (GameScene.GameMode)8) && GameObject.Find("_MainTex"))
			{
				GameObject.Find("_Value2").SetActive(false);
			}
			if (this.gameMode != GameScene.GameMode.Relax && GameObject.Find("Drop_With_Obj"))
			{
				GameObject.Find("CameraFilterPack_Glasses_On3").SetActive(true);
			}
			int currentScore = this.pbase.GetCurrentScore();
			if (GameObject.Find("_Greenness"))
			{
				GameObject.Find("_Visualize").GetComponent<Text>().text = string.Empty + this.pbase.lastBestScore;
			}
			if (GameObject.Find("PLEASE WAIT"))
			{
				GameObject.Find("connecting").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData);
			}
			if (GameObject.Find("ViewMenu"))
			{
				GameObject.Find("#close").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.HOPMEAJKPHL("ConfigVersionSlider" + this.gameMode.ToString().ToLower() + "menu.playedpage").ToUpper();
			}
			if (GameObject.Find("warning: Audio Source: "))
			{
				GameObject.Find("CameraFilterPack_TV_HorrorFX").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (GameObject.Find("_Brightness"))
			{
				GameObject.Find("settings_bindings_").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore + this.pbase.incorrectScore);
			}
			if (GameObject.Find("_NeighbourMaxTex"))
			{
				GameObject.Find("Texture2").GetComponent<Text>().text = string.Empty + this.pbase.perfectHits;
			}
			if (GameObject.Find("cipherText"))
			{
				GameObject.Find("Using constructor for new PingNativeStatic()").GetComponent<Text>().text = string.Empty + (this.pbase.correctScore - this.pbase.perfectHits);
			}
			if (GameObject.Find("ChatInput"))
			{
				GameObject.Find("CameraFilterPack/Distortion_Half_Sphere").GetComponent<Text>().text = string.Empty + this.pbase.incorrectScore;
			}
			if (GameObject.Find("_Value4"))
			{
				GameObject.Find("[EMPTY]").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(this.pbase.comboScore);
			}
			if (GameObject.Find("Items"))
			{
				GameObject.Find("#,0.00").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(this.pbase.penaltyScore);
			}
			if (GameObject.Find("MapperNameText"))
			{
				GameObject.Find("_Intensity").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(this.pbase.accuracyScore * 578f)) / 818.0 * 1365.0).ToString("Tab2Content") + "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ";
			}
			if (GameObject.Find("_Blue_C"))
			{
				GameObject.Find("UI Extensions/UISoftAdditive").GetComponent<Text>().text = string.Empty + this.pbase.checkpointsUsed;
			}
			if (GameObject.Find("_MainTex2"))
			{
				GameObject.Find("Image").GetComponent<Text>().text = string.Empty + this.pbase.loopsCount;
			}
			if (GameObject.Find("Set satellite audio input"))
			{
				float num = (float)this.pbase.lastBestScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.CBHLHPPBCIG)).JEKMHHCPHCN();
				GameObject.Find("_DistortionSize").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num * 639f)) / 1391.0).ToString(".lastCheckpoint.currentCombo");
			}
			if (GameObject.Find("B"))
			{
				GameObject.Find("LevelNameInputField").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.BIDLFEPEAEC)).NNDFIJEBENA().ToString("GroupNameText");
			}
			if (GameObject.Find("_Value4"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(this.pbase.fullLevelData.mapData) * RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(clifhdiifcc.LKHDDLENDIN)).PJBPOLLEJFN();
				num2 = ((num2 >= 1397f) ? num2 : 829f);
				GameObject.Find("GameScene").GetComponent<Text>().text = string.Empty + (Math.Floor((double)(num2 * 1011f)) / 1363.0).ToString("sfxVolume");
			}
			if (GameObject.Find("_ScreenResolution"))
			{
				GameObject.Find("FileLabel").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (this.restartNoCheckpointPanel.transform.Find("[PlayerController] ").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				this.restartNoCheckpointPanel.transform.Find("_Blue_R").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.IAAEBJKAHDD("/").ToUpper() : LocalizationService.Instance.GetTextByKey("turn").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && GameObject.Find("D-Pad Right"))
			{
				GameObject.Find("_Value2").GetComponent<Button>().interactable = true;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				base.GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
			}
		}
		if (this.gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.DisplayRanksChanges();
		}
		if (this.gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ODADIAEDJFD();
		}
		if (this.gameOver && Singleton<ChallengesManager>.Instance.DJAJOCAAKEC())
		{
			Singleton<ChallengesManager>.Instance.GHGGFGCMGGE();
		}
		if (this.AllPlayersFinished() && this.pbase.currentState == (PlayerBase.PlayerState)5 && this.spectatePanel.activeSelf)
		{
			this.gameOverCanvas.SetActive(true);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(true);
			this.ingameUICanvas.SetActive(false);
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(false);
			}
		}
		if (this.LFKFNIKPDNI() && this.pbase.currentState == (PlayerBase.PlayerState)5)
		{
			this.gameOverCanvas.SetActive(true);
			this.spectatorCanvas.SetActive(false);
			this.spectatePanel.SetActive(false);
			this.ingameUICanvas.SetActive(true);
			if (!this.pbase.isPlayerWon && this.pbase.CanResumeFromCheckpoint())
			{
				this.restartCheckpointPanel.SetActive(true);
			}
			else
			{
				this.restartNoCheckpointPanel.SetActive(false);
			}
			this.pbase.currentState = (PlayerBase.PlayerState)4;
		}
		if (!this.isGameStarted || !this.pbase || !PhotonNetwork.inRoom || !this.pbase.isPlayerWon || PhotonNetwork.offlineMode || !this.AllPlayersWin() || PhotonNetwork.room.PlayerCount > 1)
		{
		}
		if (this.isGameStarted && this.HJPDDLBDGEP > this.calculatedmaptime && !this.gameOver)
		{
			GameScene.ALGLIOKEMAK algliokemak = new GameScene.ALGLIOKEMAK();
			algliokemak.HHFFNOHKAIC = false;
			this.pbase.playerController.objects.ForEach(new Action<GameObject>(algliokemak.JDELIMPGFDJ));
			if (algliokemak.HHFFNOHKAIC)
			{
				this.pbase.isMapCompleted = false;
				if (this.gameMode != (GameScene.GameMode)7)
				{
					ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
					{
						{
							"Result for ",
							false
						}
					};
					PhotonNetwork.player.MGMCOJHGJNO(eneebhgaajh, null, true);
					this.pbase.currentState = (PlayerBase.PlayerState)4;
					if (this.pbase.photonView.BGJKMGJBPFA())
					{
						ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
						{
							{
								"settings.shaders.bloomintencity",
								true
							}
						};
						PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, false);
					}
					this.GFPAGECKDEM("_Line");
				}
				else
				{
					this.ILGGMPKMPIN();
				}
			}
		}
		if (this.NBCIEBFNLGN.Count > 1 && !this.messageCanvas.activeSelf)
		{
			string jkpjcempagh = this.NBCIEBFNLGN[0];
			float num3 = 374f;
			if (this.INGHGBLACKC.Count == this.NBCIEBFNLGN.Count)
			{
				num3 = this.INGHGBLACKC[1];
			}
			base.StartCoroutine(this.PMNKPFIMIID(jkpjcempagh, num3 * Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Parent ID", 1480f, null)));
			this.NBCIEBFNLGN.RemoveAt(0);
			this.INGHGBLACKC.RemoveAt(0);
		}
	}

	// Token: 0x06011F2F RID: 73519 RVA: 0x00636258 File Offset: 0x00634458
	public void PMLIOODCKDB()
	{
		foreach (AudioSource audioSource in this.asampler.audioSources)
		{
			audioSource.pitch = 1017f;
			audioSource.volume = 43f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 0; i < array.Length; i += 0)
		{
			PlayerBase playerBase = array[i];
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
		}
		this.gameOverCanvas.SetActive(false);
		this.spectatorCanvas.SetActive(false);
		this.spectatePanel.SetActive(true);
		this.ingameUICanvas.SetActive(true);
		this.restartCheckpointPanel.SetActive(true);
		this.restartNoCheckpointPanel.SetActive(true);
		this.gameOver = false;
		this.isGameStarted = true;
		this.calculatedmaptime = 978f;
		this.asampler.isMuted = true;
		this.asampler.isInited = true;
		this.DGBKFMMMGIH = true;
		try
		{
			this.OFMDCFHGEEC = this.ingameUICanvas.transform.Find("In Main Menu").gameObject;
			this.OFMDCFHGEEC.transform.Find("_TimeX").Find("LetterSpacing: Missing Text component").GetComponent<Image>().color = new Color(1404f, 1550f, 719f);
			this.OFMDCFHGEEC.GetComponent<Slider>().value = 582f;
		}
		catch (Exception)
		{
		}
		try
		{
			this.PECEGLIIALE = this.ingameUICanvas.transform.FindDeepChild("_NoiseTex").GetComponent<Text>();
			this.PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("_Value").ToUpper() + "_Offsets" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			this.DILNONPDEBG = Singleton<SaveSystem>.Instance.IOLBIFOIHML("_Blue_G", false, null);
			this.NCKMNMHOIOH = this.ingameUICanvas.transform.FindDeepChild("_Speed").GetComponent<Text>();
			this.NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			this.comboTextGO = this.ingameUICanvas.transform.FindDeepChild("_Value2").GetComponent<Text>();
			this.comboTextGO.text = LocalizationService.Instance.HOPMEAJKPHL("menutheme.letitbe").ToUpper() + "&search=" + 1;
		}
		catch (Exception)
		{
		}
		base.JCEKIILMPHH(true);
	}

	// Token: 0x06011F30 RID: 73520 RVA: 0x00636540 File Offset: 0x00634740
	public void JINOJEAEPDF(ObscuredFloat DPNHODJHGJL)
	{
		this.HJPDDLBDGEP = DPNHODJHGJL;
		if (this.HJPDDLBDGEP >= 728f)
		{
			if (this.asampler.audioSources[1].clip)
			{
				this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			}
			if (this.asampler.audioSources[0].clip)
			{
				this.asampler.audioSources[1].time = this.HJPDDLBDGEP;
			}
		}
	}

	// Token: 0x06011F31 RID: 73521 RVA: 0x006365EB File Offset: 0x006347EB
	private bool CODFMMBELLL(RanksSystem.Map IACGDFHKCAE)
	{
		return "_TimeX" + IACGDFHKCAE.GOMJAEIDHNM() == this.mapID && IACGDFHKCAE.KFMNMCJFPPI();
	}

	// Token: 0x06011F32 RID: 73522 RVA: 0x00636620 File Offset: 0x00634820
	public void ShowResult(string NOJGGCLPPAM = "")
	{
		GameScene.NOANBLPGKBI noanblpgkbi = new GameScene.NOANBLPGKBI();
		noanblpgkbi.ADPIKBBAKHP = this;
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.ShowChat();
		}
		this.gameOver = true;
		base.GetComponent<NetworkScene>().UpdateScoreboard();
		if (this.AllPlayersFinished())
		{
			this.HJPDDLBDGEP = this.calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			this.OFMDCFHGEEC.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "CompletedLevel")
		{
			base.GetComponent<NetworkScene>().photonView.RPC("OnPlayerGameMessage", PhotonTargets.Others, new object[]
			{
				PhotonNetwork.playerName,
				"Finished"
			});
		}
		if (NOJGGCLPPAM == "CompletedLevel")
		{
			this.pbase.isMapCompleted = true;
			this.pbase.isPlayerWon = true;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 2)
		{
			Helpers.ObtainAchievement(18);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(19);
		}
		if (this.gameMode != GameScene.GameMode.Relax && this.pbase.GetCurrentScore() > this.pbase.lastBestScore && !this.pbase.scoreBeated && this.pbase.currentAttempt > 0)
		{
			base.StartCoroutine(this.DBNMOBILJHL());
		}
		noanblpgkbi.CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			noanblpgkbi.CBOLFPGKALK = mapData.workshopId;
		}
		this.pbase.StopReplayRecording();
		if (this.pbase.GetCurrentScore() >= 0 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("settings.enableranking", 1, null) == 1 && mapData.source != FullMapData.MapSource.Editor && this.gameMode != GameScene.GameMode.Relax && !string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), false))
		{
			string ddaomdpaiep = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			string eafamamdneg = "{}";
			if (this.pbase.Replay() != null)
			{
				RanksSystem.MapReplay value = this.pbase.Replay();
				eafamamdneg = JsonConvert.SerializeObject(value);
			}
			base.StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(noanblpgkbi.CBOLFPGKALK, this.gameMode, this.pbase.GetCurrentScore(), this.pbase.accuracyScore, this.pbase.incorrectScore, EGOPKJHICLK.CompressString(eafamamdneg), Helpers.CalculateMD5(ddaomdpaiep)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hfefhopolik = "maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".played";
		int dpnhodjhgjl = Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".played", 0, null) + 1;
		Singleton<SaveSystem>.Instance.SetInt(hfefhopolik, dpnhodjhgjl, null);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = this.pbase.accuracyScore;
			finishedMapInfo.completed = this.pbase.isMapCompleted;
			finishedMapInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false, null);
			finishedMapInfo.gamemode = (int)this.gameMode;
			finishedMapInfo.loopscount = this.pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId), true))
			{
				finishedMapInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.GBKBDKHPLKG));
				finishedMapInfo.isloved = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.HMMBBDJNGGL));
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.NEIDGMKKCBI));
			}
			else
			{
				finishedMapInfo.isofficial = false;
				finishedMapInfo.isloved = false;
				finishedMapInfo.isfunny = false;
			}
			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = base.GetComponent<NetworkScene>().place;
			if (RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.BJGDNLAOMHE)) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(noanblpgkbi.PEOLMJGDHJK)).difficulty;
			}
			else
			{
				finishedMapInfo.mapdifficulty = -1f;
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount;
			finishedMapInfo.mapid = this.mapID;
			finishedMapInfo.maptags = string.Join(",", Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapperSteamID;
			finishedMapInfo.misses = this.pbase.incorrectScore;
			finishedMapInfo.perfecthits = this.pbase.perfectHits;
			finishedMapInfo.time = this.HPAnimationTime;
			finishedMapInfo.score = this.pbase.GetCurrentScore();
			foreach (GameEventInfo dagalcailln in this.pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.GameEvent(dagalcailln);
			}
			this.pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.FinishedMap(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if (this.pbase.isPlayerWon && this.gameMode != GameScene.GameMode.Relax)
		{
			string hfefhopolik2 = "maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".completed";
			int dpnhodjhgjl2 = 1;
			Singleton<SaveSystem>.Instance.SetInt(hfefhopolik2, dpnhodjhgjl2, null);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(15);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(this.mapID).source == FullMapData.MapSource.Workshop)
			{
				Helpers.ObtainAchievement(16);
			}
			if (!string.IsNullOrEmpty(noanblpgkbi.CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.GLDCBMNHEGA)) && !Singleton<SaveSystem>.Instance.GetBool("achievements.21.completed." + this.mapID, false, null))
			{
				Singleton<SaveSystem>.Instance.SetBool("achievements.21.completed." + this.mapID, true, null);
				Helpers.AddToStat("achievements.21.progress", 1);
				SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_21", (uint)Helpers.GetStat("achievements.21.progress"), 10U);
			}
			int dpnhodjhgjl3 = (int)(this.pbase.accuracyScore * (float)this.pbase.correctScore);
			Helpers.AddToStat("player.xp", dpnhodjhgjl3);
			this.pbase.DeletePlayerData();
			if (this.pbase.accuracyScore >= 0.9f && mapData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), false) && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(noanblpgkbi.HBICJNIKCNA)))
			{
				Helpers.ObtainAchievement(22);
			}
		}
		if (this.pbase.isPlayerWon && this.gameMode == GameScene.GameMode.Relax && mapData.source == FullMapData.MapSource.Workshop)
		{
			Helpers.AddToStat("achievements.26.progress", 1);
			SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_26", (uint)Helpers.GetStat("achievements.26.progress"), 5U);
			if (RanksSystem.IsOfficial(ulong.Parse(noanblpgkbi.CBOLFPGKALK), false) && this.pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(27);
			}
		}
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		this.resultText.GetComponent<Text>().text = ((!this.pbase.isPlayerWon) ? LocalizationService.Instance.GetTextByKey("failed").ToUpper() : LocalizationService.Instance.GetTextByKey("levelcompleted").ToUpper());
		this.OnGameOverEvent.Invoke();
		this.ShowGOCanvas(false);
		this.gameOver = true;
	}

	// Token: 0x06011F33 RID: 73523 RVA: 0x00636F8C File Offset: 0x0063518C
	private bool GBAGCGAJEGH(RanksSystem.Map IACGDFHKCAE)
	{
		return "_Value2" + IACGDFHKCAE.id == this.mapID;
	}

	// Token: 0x06011F34 RID: 73524 RVA: 0x00636FB4 File Offset: 0x006351B4
	private IEnumerator CCKJNHEENJN()
	{
		yield return new WaitForSeconds(1f);
		this.pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		this.AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"), 1f);
		hfefhopolik = string.Concat(new string[]
		{
			"maps.",
			this.mapID,
			".",
			this.gameMode.ToString().ToLower(),
			".highscore"
		});
		if (this.gameMode == GameScene.GameMode.Normal)
		{
			hfefhopolik = "maps." + this.mapID + ".highscore";
		}
		currentScore = this.pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hfefhopolik, currentScore, null);
		yield break;
	}

	// Token: 0x06011F35 RID: 73525 RVA: 0x00636FD0 File Offset: 0x006351D0
	public bool FFBINOOKNLN()
	{
		bool result = false;
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
		{
			if (photonPlayer.CustomProperties["Up"] == null || (photonPlayer.CustomProperties["Tab1Content"] != null && !(bool)photonPlayer.CustomProperties["_SSAO"]))
			{
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06011F36 RID: 73526 RVA: 0x00637044 File Offset: 0x00635244
	private bool KIGIBCODDMK(RanksSystem.Map IACGDFHKCAE)
	{
		return !("_TimeX" + IACGDFHKCAE.KCGOFGJNCME() == this.mapID) || IACGDFHKCAE.AMJIEEIMBDN();
	}

	// Token: 0x04001F90 RID: 8080
	public Image hiddenImage;

	// Token: 0x04001F91 RID: 8081
	public ObscuredBool gameOver = false;

	// Token: 0x04001F92 RID: 8082
	public ObscuredBool isGameStarted = false;

	// Token: 0x04001F93 RID: 8083
	public AudioSampler asampler;

	// Token: 0x04001F94 RID: 8084
	[HideInInspector]
	public PlayerBase pbase;

	// Token: 0x04001F95 RID: 8085
	public GameObject levelCanvas;

	// Token: 0x04001F96 RID: 8086
	public GameObject levelCanvasImage;

	// Token: 0x04001F97 RID: 8087
	public GameObject gameOverCanvas;

	// Token: 0x04001F98 RID: 8088
	public GameObject messageCanvas;

	// Token: 0x04001F99 RID: 8089
	public GameObject spectatorCanvas;

	// Token: 0x04001F9A RID: 8090
	public GameObject messageAnimation;

	// Token: 0x04001F9B RID: 8091
	public GameObject resultText;

	// Token: 0x04001F9C RID: 8092
	public GameObject ingameUICanvas;

	// Token: 0x04001F9D RID: 8093
	public GameObject loadingCanvas;

	// Token: 0x04001F9E RID: 8094
	public UnityEvent OnGameOverEvent;

	// Token: 0x04001F9F RID: 8095
	[HideInInspector]
	public ObscuredString mapID;

	// Token: 0x04001FA0 RID: 8096
	public bool usingCheckpoints = true;

	// Token: 0x04001FA1 RID: 8097
	public GameScene.GameMode gameMode = GameScene.GameMode.Normal;

	// Token: 0x04001FA2 RID: 8098
	public UnityEvent OnLoaded;

	// Token: 0x04001FA3 RID: 8099
	public GameObject restartCheckpointPanel;

	// Token: 0x04001FA4 RID: 8100
	public GameObject restartNoCheckpointPanel;

	// Token: 0x04001FA5 RID: 8101
	public GameObject spectatePanel;

	// Token: 0x04001FA6 RID: 8102
	public GameObject levelInfo;

	// Token: 0x04001FA7 RID: 8103
	public GameObject levelInfoContent;

	// Token: 0x04001FA8 RID: 8104
	public float calculatedmaptime;

	// Token: 0x04001FA9 RID: 8105
	private ObscuredBool DGBKFMMMGIH = false;

	// Token: 0x04001FAA RID: 8106
	private List<string> NBCIEBFNLGN = new List<string>();

	// Token: 0x04001FAB RID: 8107
	private List<float> INGHGBLACKC = new List<float>();

	// Token: 0x04001FAC RID: 8108
	private string GIDJMDIODGM = string.Empty;

	// Token: 0x04001FAD RID: 8109
	private string NELDEHEICJD = string.Empty;

	// Token: 0x04001FAE RID: 8110
	private string OOJLKOMPCBI = string.Empty;

	// Token: 0x04001FAF RID: 8111
	private string PIDICMNEOJL = string.Empty;

	// Token: 0x04001FB0 RID: 8112
	private GameObject OFMDCFHGEEC;

	// Token: 0x04001FB1 RID: 8113
	private Text PECEGLIIALE;

	// Token: 0x04001FB2 RID: 8114
	private Text NCKMNMHOIOH;

	// Token: 0x04001FB3 RID: 8115
	[HideInInspector]
	public Text comboTextGO;

	// Token: 0x04001FB4 RID: 8116
	private bool DILNONPDEBG;

	// Token: 0x04001FB5 RID: 8117
	private ObscuredFloat HJPDDLBDGEP = 0f;

	// Token: 0x04001FB6 RID: 8118
	[CompilerGenerated]
	private static Predicate<MapEvent> LNIJKGECNME;

	// Token: 0x04001FB7 RID: 8119
	[CompilerGenerated]
	private static Predicate<MapEvent> CLCBJCKCBDD;

	// Token: 0x020004D6 RID: 1238
	public enum GameMode
	{
		// Token: 0x04001FB9 RID: 8121
		Relax,
		// Token: 0x04001FBA RID: 8122
		Normal,
		// Token: 0x04001FBB RID: 8123
		Hardcore,
		// Token: 0x04001FBC RID: 8124
		Random,
		// Token: 0x04001FBD RID: 8125
		Endless,
		// Token: 0x04001FBE RID: 8126
		Hidden
	}

	// Token: 0x020004D7 RID: 1239
	[CompilerGenerated]
	private sealed class CLIFHDIIFCC
	{
		// Token: 0x06011F37 RID: 73527 RVA: 0x00637079 File Offset: 0x00635279
		internal bool PCJBHKELGNM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F38 RID: 73528 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool GGOLDDMONEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F39 RID: 73529 RVA: 0x006370A4 File Offset: 0x006352A4
		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Endless && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F3A RID: 73530 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool ENINHNANGPG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F3B RID: 73531 RVA: 0x0063710C File Offset: 0x0063530C
		internal bool BLEKGEPJBFN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || (this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Normal && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F3C RID: 73532 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool AOCLLLHOEPF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F3D RID: 73533 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool GKNGIBMOHBG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F3E RID: 73534 RVA: 0x00637079 File Offset: 0x00635279
		internal bool FBGEJBKEPFI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F3F RID: 73535 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool EGJAIPCIJEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F40 RID: 73536 RVA: 0x00637174 File Offset: 0x00635374
		internal bool ILMDLDPMCBD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)7 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F41 RID: 73537 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool BNABGIKKBLP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F42 RID: 73538 RVA: 0x006371C8 File Offset: 0x006353C8
		internal bool FKOIPBAKJDE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F43 RID: 73539 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool BEFHJKGDBHJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F44 RID: 73540 RVA: 0x00637079 File Offset: 0x00635279
		internal bool PAHEEBJDAEA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F45 RID: 73541 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool ODODGALBCPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F46 RID: 73542 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool HKCAPINMNFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F47 RID: 73543 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool CNEFGIKLOGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F48 RID: 73544 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool PJHNGEPABHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F49 RID: 73545 RVA: 0x00637079 File Offset: 0x00635279
		internal bool LHDKMBKLNPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F4A RID: 73546 RVA: 0x00637230 File Offset: 0x00635430
		internal bool BHMNMHFDPLN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F4B RID: 73547 RVA: 0x00637079 File Offset: 0x00635279
		internal bool CNFFIABGOKN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F4C RID: 73548 RVA: 0x00637248 File Offset: 0x00635448
		internal bool FCAGEDLBBHD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || this.ADPIKBBAKHP.gameMode == (GameScene.GameMode)6 || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F4D RID: 73549 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool FLCOLKKLFPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F4E RID: 73550 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool AFIPGCELCFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F4F RID: 73551 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool ONDNJLFLNMF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F50 RID: 73552 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool PKJCCIGEACE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F51 RID: 73553 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool CKLEFMLCEBN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F52 RID: 73554 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool JLAJGEPNAJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F53 RID: 73555 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool FMCCGLHBGOL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F54 RID: 73556 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool EJEBFELHMGM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F55 RID: 73557 RVA: 0x00637079 File Offset: 0x00635279
		internal bool BEFJFFLBLCE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F56 RID: 73558 RVA: 0x00637079 File Offset: 0x00635279
		internal bool EKNKLPPOIPN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F57 RID: 73559 RVA: 0x00637230 File Offset: 0x00635430
		internal bool LLMELNAGMNA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F58 RID: 73560 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool NEIDGMKKCBI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F59 RID: 73561 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool DGDCNDCGPCP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F5A RID: 73562 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool PODLCOEIIGA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F5B RID: 73563 RVA: 0x006372B0 File Offset: 0x006354B0
		internal bool LJDLIIIPIIJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.CILAHEMDKNO() || this.ADPIKBBAKHP.gameMode == (GameScene.GameMode)6 || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F5C RID: 73564 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool MPOCBBDLGMP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F5D RID: 73565 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool NFHJNMELIEI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F5E RID: 73566 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool BAOFCDGMECG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F5F RID: 73567 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool HHGPEDICCCI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F60 RID: 73568 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool OJFHDDECJKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F61 RID: 73569 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool CGMENGEHBKH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F62 RID: 73570 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool OPLBAOKOOJN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F63 RID: 73571 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool PDCEJFJILFL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F64 RID: 73572 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool BJGDNLAOMHE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F65 RID: 73573 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool PHKLCGKAKON(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F66 RID: 73574 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool HKLBHBIENLO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F67 RID: 73575 RVA: 0x00637304 File Offset: 0x00635504
		internal bool FMIHBNPKEEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F68 RID: 73576 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool FAKMANMIGEP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F69 RID: 73577 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool FDIHIDKBBAD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F6A RID: 73578 RVA: 0x00637079 File Offset: 0x00635279
		internal bool MACILKHEBEF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F6B RID: 73579 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool DGCJLJMCNGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F6C RID: 73580 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool HIHNMOEFONO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F6D RID: 73581 RVA: 0x00637079 File Offset: 0x00635279
		internal bool JJDBNMIFCHM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F6E RID: 73582 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool KFGCBAHGDNK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F6F RID: 73583 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool KOKDJJJIGCC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F70 RID: 73584 RVA: 0x00637358 File Offset: 0x00635558
		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.CILAHEMDKNO() || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Hidden || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F71 RID: 73585 RVA: 0x00637230 File Offset: 0x00635430
		internal bool ALCLIPCDCFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F72 RID: 73586 RVA: 0x006373AC File Offset: 0x006355AC
		internal bool BJMAIJDIKCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.GPAPLIKKEOH() || (this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Hidden && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F73 RID: 73587 RVA: 0x00637400 File Offset: 0x00635600
		internal bool GLHKGBNIHFH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Endless || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal;
		}

		// Token: 0x06011F74 RID: 73588 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool BJCNLIJFEKF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F75 RID: 73589 RVA: 0x00637454 File Offset: 0x00635654
		internal bool PNJOGNDMFBD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || (this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)6 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F76 RID: 73590 RVA: 0x006374A8 File Offset: 0x006356A8
		internal bool OFLDIMDDLHM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BMKGKMJPAMF() && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Endless && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F77 RID: 73591 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool EJBBFECHIOD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F78 RID: 73592 RVA: 0x006374FC File Offset: 0x006356FC
		internal bool CHPMMDDOFKM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.CILAHEMDKNO() && this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)7 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F79 RID: 73593 RVA: 0x00637550 File Offset: 0x00635750
		internal bool IJEMMODBHFI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.CDPELGPJPND() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Endless || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F7A RID: 73594 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool MNCMPEJLMJH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F7B RID: 73595 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool DFEBIECLKEK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F7C RID: 73596 RVA: 0x00637079 File Offset: 0x00635279
		internal bool BNAGFAENIDL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F7D RID: 73597 RVA: 0x006375A4 File Offset: 0x006357A4
		internal bool FHFECFLBHMA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.CDPELGPJPND() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Endless || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F7E RID: 73598 RVA: 0x00637230 File Offset: 0x00635430
		internal bool ANJAEKGJILL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F7F RID: 73599 RVA: 0x006375F8 File Offset: 0x006357F8
		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.isOfficial && this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)8 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F80 RID: 73600 RVA: 0x0063764C File Offset: 0x0063584C
		internal bool BLPJEDJCHKN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Hardcore && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F81 RID: 73601 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool BHIAMFCFHEA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F82 RID: 73602 RVA: 0x00637230 File Offset: 0x00635430
		internal bool CJPKAHOENCE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F83 RID: 73603 RVA: 0x006376A0 File Offset: 0x006358A0
		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BMKGKMJPAMF() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Random || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F84 RID: 73604 RVA: 0x006376F4 File Offset: 0x006358F4
		internal bool HHHLDJJNBCG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06011F85 RID: 73605 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool DGHLKHFIBFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F86 RID: 73606 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool MFAOBEEABIE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F87 RID: 73607 RVA: 0x00637748 File Offset: 0x00635948
		internal bool IJINAAGMHKM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.CILAHEMDKNO() || (this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)7 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06011F88 RID: 73608 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool LMOFPPCBJAJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F89 RID: 73609 RVA: 0x00637079 File Offset: 0x00635279
		internal bool BOJCHGIGGNK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F8A RID: 73610 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool FKHKOGEPNIO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F8B RID: 73611 RVA: 0x00637079 File Offset: 0x00635279
		internal bool HJNKOEGPEMO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F8C RID: 73612 RVA: 0x0063779C File Offset: 0x0063599C
		internal bool ANIOBFCCLOM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal;
		}

		// Token: 0x06011F8D RID: 73613 RVA: 0x00637079 File Offset: 0x00635279
		internal bool CBHLHPPBCIG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F8E RID: 73614 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool IAOPMFNHBEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F8F RID: 73615 RVA: 0x006377F0 File Offset: 0x006359F0
		internal bool IPPEMIOOKJK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Hidden && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011F90 RID: 73616 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool NGFGLJGABCM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F91 RID: 73617 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool MHOOBEJEOGN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F92 RID: 73618 RVA: 0x00637844 File Offset: 0x00635A44
		internal bool AEIFJLBBKBP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Relax && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06011F93 RID: 73619 RVA: 0x00637230 File Offset: 0x00635430
		internal bool KOKGJKCLJGG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F94 RID: 73620 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool AAPNNKGJEOG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F95 RID: 73621 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool LKHDDLENDIN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F96 RID: 73622 RVA: 0x00637898 File Offset: 0x00635A98
		internal bool AKDOOLPMPMG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Normal && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011F97 RID: 73623 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool MDNPKLLOGFN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F98 RID: 73624 RVA: 0x00637079 File Offset: 0x00635279
		internal bool CPCAFOFNMPP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F99 RID: 73625 RVA: 0x00637079 File Offset: 0x00635279
		internal bool MEPHHACNBDP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F9A RID: 73626 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool LIHHOPHJBGO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F9B RID: 73627 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool NJNINIMOHIL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F9C RID: 73628 RVA: 0x00637230 File Offset: 0x00635430
		internal bool KPGCHLHFGLF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F9D RID: 73629 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool CNLHKMJBMBK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F9E RID: 73630 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool DMKALNCPIAJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011F9F RID: 73631 RVA: 0x00637230 File Offset: 0x00635430
		internal bool PNNIBLNDJAB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA0 RID: 73632 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool LMNCLJKEIFD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA1 RID: 73633 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool HMMBBDJNGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA2 RID: 73634 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool BCGGBECECMI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA3 RID: 73635 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool LGKMMLGKBEF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA4 RID: 73636 RVA: 0x00637230 File Offset: 0x00635430
		internal bool FPELDBFGMLG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA5 RID: 73637 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool AGMKEOEENNB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA6 RID: 73638 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool NOJCMLCPIKB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA7 RID: 73639 RVA: 0x006378EC File Offset: 0x00635AEC
		internal bool CPGJCCBMBBF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.CDPELGPJPND() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Random || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06011FA8 RID: 73640 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool NGOGBFAINDE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FA9 RID: 73641 RVA: 0x00637940 File Offset: 0x00635B40
		internal bool IKMOFMJNEPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Endless || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06011FAA RID: 73642 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool GDFBBMNOGGD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FAB RID: 73643 RVA: 0x00637994 File Offset: 0x00635B94
		internal bool NIFPHAJMPFC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011FAC RID: 73644 RVA: 0x006379E8 File Offset: 0x00635BE8
		internal bool LGKFHOBDANE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && (this.ADPIKBBAKHP.gameMode == (GameScene.GameMode)8 || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06011FAD RID: 73645 RVA: 0x00637A3C File Offset: 0x00635C3C
		internal bool IMOHKBJBLBA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Hidden && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal;
		}

		// Token: 0x06011FAE RID: 73646 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool OBPEOGPJGPB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FAF RID: 73647 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool BIDLFEPEAEC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FB0 RID: 73648 RVA: 0x00637A90 File Offset: 0x00635C90
		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Random || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011FB1 RID: 73649 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool PCAFEACHAAC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FB2 RID: 73650 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool HAPNOCCALGP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FB3 RID: 73651 RVA: 0x00637AE4 File Offset: 0x00635CE4
		internal bool NBFOKGGNEOJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Endless && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06011FB4 RID: 73652 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool PKLBHPIMGDL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FB5 RID: 73653 RVA: 0x00637B38 File Offset: 0x00635D38
		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)7 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal;
		}

		// Token: 0x06011FB6 RID: 73654 RVA: 0x00637B8C File Offset: 0x00635D8C
		internal bool HAPGCHDIKMF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Random || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal;
		}

		// Token: 0x06011FB7 RID: 73655 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool CCJNHCEBGDO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FB8 RID: 73656 RVA: 0x0063708E File Offset: 0x0063528E
		internal bool DFHFAFAJGBA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FB9 RID: 73657 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool NFMMONDLJCC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FBA RID: 73658 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool OBKGOLOMFPJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FBB RID: 73659 RVA: 0x00637230 File Offset: 0x00635430
		internal bool FHAMDNDPKBA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FBC RID: 73660 RVA: 0x00637BE0 File Offset: 0x00635DE0
		internal bool PDNFNOLBNIF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.CILAHEMDKNO() && (this.ADPIKBBAKHP.gameMode == (GameScene.GameMode)6 || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06011FBD RID: 73661 RVA: 0x0063721B File Offset: 0x0063541B
		internal bool HEPDDMCNEKD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FBE RID: 73662 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool ILGJJBKIAAP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FBF RID: 73663 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool BDMPPMLGGDG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FC0 RID: 73664 RVA: 0x0063715F File Offset: 0x0063535F
		internal bool LFOOFBPCAAO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FC2 RID: 73666 RVA: 0x0063729B File Offset: 0x0063549B
		internal bool INCKLCFEMJK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FC3 RID: 73667 RVA: 0x006370F7 File Offset: 0x006352F7
		internal bool HMNNKBBNGLB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK);
		}

		// Token: 0x06011FC4 RID: 73668 RVA: 0x00637C34 File Offset: 0x00635E34
		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Hardcore || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011FC5 RID: 73669 RVA: 0x00637C88 File Offset: 0x00635E88
		internal bool LDNDNOOCFFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || (this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)8 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x04001FBF RID: 8127
		internal string CBOLFPGKALK;

		// Token: 0x04001FC0 RID: 8128
		internal GameScene ADPIKBBAKHP;
	}

	// Token: 0x020004D8 RID: 1240
	[CompilerGenerated]
	private sealed class ALGLIOKEMAK
	{
		// Token: 0x06011FC6 RID: 73670 RVA: 0x00637CDB File Offset: 0x00635EDB
		internal void OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FC7 RID: 73671 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FC8 RID: 73672 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FC9 RID: 73673 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FCA RID: 73674 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FCB RID: 73675 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FCC RID: 73676 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FCD RID: 73677 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FCE RID: 73678 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FCF RID: 73679 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FD0 RID: 73680 RVA: 0x00637CDB File Offset: 0x00635EDB
		internal void MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FD1 RID: 73681 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FD2 RID: 73682 RVA: 0x00637CDB File Offset: 0x00635EDB
		internal void BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FD3 RID: 73683 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FD4 RID: 73684 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FD6 RID: 73686 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FD7 RID: 73687 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FD8 RID: 73688 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FD9 RID: 73689 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FDA RID: 73690 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FDB RID: 73691 RVA: 0x00637CDB File Offset: 0x00635EDB
		internal void JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FDC RID: 73692 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FDD RID: 73693 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void EFAPFFFGOOA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FDE RID: 73694 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FDF RID: 73695 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FE0 RID: 73696 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FE1 RID: 73697 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FE2 RID: 73698 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FE3 RID: 73699 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FE4 RID: 73700 RVA: 0x00637CDB File Offset: 0x00635EDB
		internal void IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FE5 RID: 73701 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FE6 RID: 73702 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FE7 RID: 73703 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FE8 RID: 73704 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FE9 RID: 73705 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FEA RID: 73706 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FEB RID: 73707 RVA: 0x00637CDB File Offset: 0x00635EDB
		internal void EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FEC RID: 73708 RVA: 0x00637CDB File Offset: 0x00635EDB
		internal void BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FED RID: 73709 RVA: 0x00637CF5 File Offset: 0x00635EF5
		internal void FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = false;
			}
		}

		// Token: 0x06011FEE RID: 73710 RVA: 0x00637D29 File Offset: 0x00635F29
		internal void LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x06011FEF RID: 73711 RVA: 0x00637D0F File Offset: 0x00635F0F
		internal void AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				this.HHFFNOHKAIC = true;
			}
		}

		// Token: 0x04001FC1 RID: 8129
		internal bool HHFFNOHKAIC;
	}

	// Token: 0x020004D9 RID: 1241
	[CompilerGenerated]
	private sealed class NOANBLPGKBI
	{
		// Token: 0x06011FF0 RID: 73712 RVA: 0x00637D43 File Offset: 0x00635F43
		internal bool CHBEFOHEEGK(RanksSystem.Map IACGDFHKCAE)
		{
			return !("challenges/" + IACGDFHKCAE.JGEBJGHEJPK() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.MKLAMAFMEPF();
		}

		// Token: 0x06011FF1 RID: 73713 RVA: 0x00637D7D File Offset: 0x00635F7D
		internal bool PEOLMJGDHJK(RanksSystem.Map IACGDFHKCAE)
		{
			return "workshop." + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06011FF2 RID: 73714 RVA: 0x00637DA9 File Offset: 0x00635FA9
		internal bool AEIFJLBBKBP(RanksSystem.Map IACGDFHKCAE)
		{
			return "System.Int32" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.CDPELGPJPND();
		}

		// Token: 0x06011FF3 RID: 73715 RVA: 0x00637DE3 File Offset: 0x00635FE3
		internal bool BPJGFELFEDC(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Blue_B" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.AIGLNDJJPFL();
		}

		// Token: 0x06011FF4 RID: 73716 RVA: 0x00637E1D File Offset: 0x0063601D
		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return "workshop." + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		// Token: 0x06011FF5 RID: 73717 RVA: 0x00637E57 File Offset: 0x00636057
		internal bool PNNIBLNDJAB(RanksSystem.Map IACGDFHKCAE)
		{
			return "_ColorLevel" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06011FF6 RID: 73718 RVA: 0x00637E83 File Offset: 0x00636083
		internal bool MMJGKBNKFGM(RanksSystem.Map IACGDFHKCAE)
		{
			return !("_TimeX" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.AIGLNDJJPFL();
		}

		// Token: 0x06011FF7 RID: 73719 RVA: 0x00637EBD File Offset: 0x006360BD
		internal bool MKJANCFANJN(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Speed" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06011FF8 RID: 73720 RVA: 0x00637EEC File Offset: 0x006360EC
		internal bool HOJKBGLIHKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Random && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06011FF9 RID: 73721 RVA: 0x00637F3F File Offset: 0x0063613F
		internal bool MGENGAEDACG(RanksSystem.Map IACGDFHKCAE)
		{
			return "CameraFilterPack/TV_Old" + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		// Token: 0x06011FFA RID: 73722 RVA: 0x00637F79 File Offset: 0x00636179
		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Visualize" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		// Token: 0x06011FFB RID: 73723 RVA: 0x00637FB3 File Offset: 0x006361B3
		internal bool HBICJNIKCNA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.isOfficial && IACGDFHKCAE.difficulty >= 4.5f;
		}

		// Token: 0x06011FFC RID: 73724 RVA: 0x00637FE9 File Offset: 0x006361E9
		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Value3" + IACGDFHKCAE.GOMJAEIDHNM() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		// Token: 0x06011FFD RID: 73725 RVA: 0x00638023 File Offset: 0x00636223
		internal bool LIHHOPHJBGO(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Value" + IACGDFHKCAE.KCGOFGJNCME() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06011FFE RID: 73726 RVA: 0x0063804F File Offset: 0x0063624F
		internal bool IKGFMLEODHJ(RanksSystem.Map IACGDFHKCAE)
		{
			return "_ScreenResolution" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06011FFF RID: 73727 RVA: 0x0063807C File Offset: 0x0063627C
		internal bool LBIHCBDDFIG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.isOfficial && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Hardcore && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal;
		}

		// Token: 0x06012000 RID: 73728 RVA: 0x006380CF File Offset: 0x006362CF
		internal bool JKIOEELDEFJ(RanksSystem.Map IACGDFHKCAE)
		{
			return "ShadersToggle" + IACGDFHKCAE.HJPGIGBFCID() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012001 RID: 73729 RVA: 0x006380FB File Offset: 0x006362FB
		internal bool CBKBGEBIAIJ(RanksSystem.Map IACGDFHKCAE)
		{
			return "settings.disablestoryboard" + IACGDFHKCAE.JGEBJGHEJPK() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012002 RID: 73730 RVA: 0x00638127 File Offset: 0x00636327
		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Value11" + IACGDFHKCAE.KCGOFGJNCME() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.GPAPLIKKEOH();
		}

		// Token: 0x06012003 RID: 73731 RVA: 0x00638161 File Offset: 0x00636361
		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return ".lastCheckpoint.penaltyScore" + IACGDFHKCAE.GOMJAEIDHNM() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.CILAHEMDKNO();
		}

		// Token: 0x06012004 RID: 73732 RVA: 0x0063819C File Offset: 0x0063639C
		internal bool BHBAGCLINDF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.GPAPLIKKEOH() || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Random || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06012005 RID: 73733 RVA: 0x006381EF File Offset: 0x006363EF
		internal bool HMMBBDJNGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return "workshop." + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.isLoved;
		}

		// Token: 0x06012006 RID: 73734 RVA: 0x0063822C File Offset: 0x0063642C
		internal bool GLDCBMNHEGA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Hardcore || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06012007 RID: 73735 RVA: 0x0063827F File Offset: 0x0063647F
		internal bool KLCOHBPBBPJ(RanksSystem.Map IACGDFHKCAE)
		{
			return "0.00" + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012008 RID: 73736 RVA: 0x006382AB File Offset: 0x006364AB
		internal bool JIBOGBEMPHH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && IACGDFHKCAE.IFMFDMKFJBI() < 1102f;
		}

		// Token: 0x06012009 RID: 73737 RVA: 0x006382E1 File Offset: 0x006364E1
		internal bool PHGILLBNBME(RanksSystem.Map IACGDFHKCAE)
		{
			return !(". Set PhotonNetwork.OnEventCall." + IACGDFHKCAE.GOMJAEIDHNM() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.NPFHGDJAMPK();
		}

		// Token: 0x0601200A RID: 73738 RVA: 0x0063831B File Offset: 0x0063651B
		internal bool BPMFAGKEGOH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && IACGDFHKCAE.difficulty >= 1013f;
		}

		// Token: 0x0601200B RID: 73739 RVA: 0x00638354 File Offset: 0x00636554
		internal bool FNLNALBIFBB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && (this.ADPIKBBAKHP.gameMode == (GameScene.GameMode)7 || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x0601200C RID: 73740 RVA: 0x006383A7 File Offset: 0x006365A7
		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return !("No" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.CDPELGPJPND();
		}

		// Token: 0x0601200D RID: 73741 RVA: 0x006383E1 File Offset: 0x006365E1
		internal bool PBHFICAHLJK(RanksSystem.Map IACGDFHKCAE)
		{
			return "BloomShaderValueSlider" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.GCLPAFADHMD();
		}

		// Token: 0x0601200E RID: 73742 RVA: 0x0063841B File Offset: 0x0063661B
		internal bool CMHELGPCEHI(RanksSystem.Map IACGDFHKCAE)
		{
			return "\"x" + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x0601200F RID: 73743 RVA: 0x00638448 File Offset: 0x00636648
		internal bool NFDJLPNCFJL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || (this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)7 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06012010 RID: 73744 RVA: 0x0063849B File Offset: 0x0063669B
		internal bool JECDDGPMGOF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || IACGDFHKCAE.JEKMHHCPHCN() < 147f;
		}

		// Token: 0x06012011 RID: 73745 RVA: 0x006384D4 File Offset: 0x006366D4
		internal bool LMMPGEHHFCM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.GPAPLIKKEOH() || (this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Hidden && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x06012012 RID: 73746 RVA: 0x00638528 File Offset: 0x00636728
		internal bool LJKLEFGGCDB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Endless || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06012013 RID: 73747 RVA: 0x0063857B File Offset: 0x0063677B
		internal bool NFHJNMELIEI(RanksSystem.Map IACGDFHKCAE)
		{
			return !("_ScreenResolution" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.NPFHGDJAMPK();
		}

		// Token: 0x06012014 RID: 73748 RVA: 0x006385B5 File Offset: 0x006367B5
		internal bool LCLIAICAIMH(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Value" + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012015 RID: 73749 RVA: 0x00637D7D File Offset: 0x00635F7D
		internal bool BJGDNLAOMHE(RanksSystem.Map IACGDFHKCAE)
		{
			return "workshop." + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012017 RID: 73751 RVA: 0x006385E1 File Offset: 0x006367E1
		internal bool KKENKEDKDJP(RanksSystem.Map IACGDFHKCAE)
		{
			return "_TimeX" + IACGDFHKCAE.JGEBJGHEJPK() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012018 RID: 73752 RVA: 0x0063860D File Offset: 0x0063680D
		internal bool JGEDLMKBGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return "BitsData" + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.AIGLNDJJPFL();
		}

		// Token: 0x06012019 RID: 73753 RVA: 0x00638647 File Offset: 0x00636847
		internal bool OCMEKJENJIB(RanksSystem.Map IACGDFHKCAE)
		{
			return "_FarCamera" + IACGDFHKCAE.KCGOFGJNCME() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x0601201A RID: 73754 RVA: 0x00638673 File Offset: 0x00636873
		internal bool NEIDGMKKCBI(RanksSystem.Map IACGDFHKCAE)
		{
			return "workshop." + IACGDFHKCAE.id == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.isFunny;
		}

		// Token: 0x0601201B RID: 73755 RVA: 0x006386AD File Offset: 0x006368AD
		internal bool OJABGEKOLHK(RanksSystem.Map IACGDFHKCAE)
		{
			return "CameraFilterPack/Blend2Camera_DarkerColor" + IACGDFHKCAE.HJPGIGBFCID() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x0601201C RID: 73756 RVA: 0x006386D9 File Offset: 0x006368D9
		internal bool INHOEMCLAAP(RanksSystem.Map IACGDFHKCAE)
		{
			return !("[Down]" + IACGDFHKCAE.GOMJAEIDHNM() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.BJBPMLKECIA();
		}

		// Token: 0x0601201D RID: 73757 RVA: 0x00638713 File Offset: 0x00636913
		internal bool FLEACLFIGPK(RanksSystem.Map IACGDFHKCAE)
		{
			return "y" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x0601201E RID: 73758 RVA: 0x0063873F File Offset: 0x0063693F
		internal bool OFLDIMDDLHM(RanksSystem.Map IACGDFHKCAE)
		{
			return !("plogs" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.CDPELGPJPND();
		}

		// Token: 0x0601201F RID: 73759 RVA: 0x00638779 File Offset: 0x00636979
		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return "#mapby" + IACGDFHKCAE.JGEBJGHEJPK() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.CDPELGPJPND();
		}

		// Token: 0x06012020 RID: 73760 RVA: 0x006387B3 File Offset: 0x006369B3
		internal bool JAFPLONIDNO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && IACGDFHKCAE.JEKMHHCPHCN() < 1582f;
		}

		// Token: 0x06012021 RID: 73761 RVA: 0x006387E9 File Offset: 0x006369E9
		internal bool NNIPMNELDCH(RanksSystem.Map IACGDFHKCAE)
		{
			return "Use ticket: " + IACGDFHKCAE.HJPGIGBFCID() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012022 RID: 73762 RVA: 0x00638815 File Offset: 0x00636A15
		internal bool INJBMNCHKLJ(RanksSystem.Map IACGDFHKCAE)
		{
			return "AddEnvironmentSprite" + IACGDFHKCAE.HJPGIGBFCID() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012023 RID: 73763 RVA: 0x00638841 File Offset: 0x00636A41
		internal bool EEJGNJAOOKE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.BMKGKMJPAMF() || IACGDFHKCAE.BAFALKHFFMK() >= 1272f;
		}

		// Token: 0x06012024 RID: 73764 RVA: 0x00638878 File Offset: 0x00636A78
		internal bool BFOAFBMNJMI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && this.ADPIKBBAKHP.gameMode != GameScene.GameMode.Relax && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax;
		}

		// Token: 0x06012025 RID: 73765 RVA: 0x006388CB File Offset: 0x00636ACB
		internal bool IIFAPDEIJEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || IACGDFHKCAE.JEKMHHCPHCN() < 1858f;
		}

		// Token: 0x06012026 RID: 73766 RVA: 0x00638901 File Offset: 0x00636B01
		internal bool FMBNCFBHLHH(RanksSystem.Map IACGDFHKCAE)
		{
			return "BestRegion checks region: " + IACGDFHKCAE.JGEBJGHEJPK() == this.ADPIKBBAKHP.mapID;
		}

		// Token: 0x06012027 RID: 73767 RVA: 0x00638930 File Offset: 0x00636B30
		internal bool OFBIAJNDMBI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || (this.ADPIKBBAKHP.gameMode != (GameScene.GameMode)8 && this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal);
		}

		// Token: 0x06012028 RID: 73768 RVA: 0x0063857B File Offset: 0x0063677B
		internal bool FBGMHPEEIFC(RanksSystem.Map IACGDFHKCAE)
		{
			return !("_ScreenResolution" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.NPFHGDJAMPK();
		}

		// Token: 0x06012029 RID: 73769 RVA: 0x00638983 File Offset: 0x00636B83
		internal bool PHKBLLOPAHM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || IACGDFHKCAE.DEFJMFBIGIM() >= 223f;
		}

		// Token: 0x0601202A RID: 73770 RVA: 0x006389B9 File Offset: 0x00636BB9
		internal bool LLELFPJGDBO(RanksSystem.Map IACGDFHKCAE)
		{
			return !("Reconnect() failed. It seems the client wasn't connected before?! Current state: " + IACGDFHKCAE.JGEBJGHEJPK() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.OOFBBOBFPIH();
		}

		// Token: 0x0601202B RID: 73771 RVA: 0x006389F3 File Offset: 0x00636BF3
		internal bool IDDDJNEFHJM(RanksSystem.Map IACGDFHKCAE)
		{
			return !("_Value" + IACGDFHKCAE.CEEKAHOMGKG() == this.ADPIKBBAKHP.mapID) || IACGDFHKCAE.GCLPAFADHMD();
		}

		// Token: 0x0601202C RID: 73772 RVA: 0x00638A2D File Offset: 0x00636C2D
		internal bool JFAHEIFLBMA(RanksSystem.Map IACGDFHKCAE)
		{
			return "OpJoinRandomRoom()" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.MEFGLBKEHJE();
		}

		// Token: 0x0601202D RID: 73773 RVA: 0x00638A67 File Offset: 0x00636C67
		internal bool MLKBGKFJFAO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() != ulong.Parse(this.CBOLFPGKALK) || !IACGDFHKCAE.CDPELGPJPND() || IACGDFHKCAE.MBAFCIHCIOM() < 1424f;
		}

		// Token: 0x0601202E RID: 73774 RVA: 0x00638AA0 File Offset: 0x00636CA0
		internal bool NAAGIHHJAMF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.CBOLFPGKALK) && IACGDFHKCAE.CILAHEMDKNO() && (this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Normal || this.ADPIKBBAKHP.gameMode == GameScene.GameMode.Relax);
		}

		// Token: 0x0601202F RID: 73775 RVA: 0x00638AF3 File Offset: 0x00636CF3
		internal bool FGBHLKOCGNE(RanksSystem.Map IACGDFHKCAE)
		{
			return "_Value2" + IACGDFHKCAE.JGEBJGHEJPK() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.AMJIEEIMBDN();
		}

		// Token: 0x06012030 RID: 73776 RVA: 0x00638B2D File Offset: 0x00636D2D
		internal bool OMJJLDBPEHI(RanksSystem.Map IACGDFHKCAE)
		{
			return ",viewkeys" + IACGDFHKCAE.CHDCIFPPIFI() == this.ADPIKBBAKHP.mapID && IACGDFHKCAE.AIGLNDJJPFL();
		}

		// Token: 0x04001FC2 RID: 8130
		internal string CBOLFPGKALK;

		// Token: 0x04001FC3 RID: 8131
		internal GameScene ADPIKBBAKHP;
	}
}
