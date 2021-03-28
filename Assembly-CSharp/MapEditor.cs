using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x02000491 RID: 1169
public class MapEditor : Singleton<MapEditor>
{
	// Token: 0x06010B40 RID: 68416 RVA: 0x005A94FB File Offset: 0x005A76FB
	public void OnCopyButton()
	{
		if (Singleton<EditorArcsSelector>.Instance.selectedunits.Count > 0)
		{
			Singleton<EditorArcsSelector>.Instance.SaveSelectedToMemory();
		}
	}

	// Token: 0x06010B41 RID: 68417 RVA: 0x005A951C File Offset: 0x005A771C
	public void SetCustomBPM(string DPNHODJHGJL)
	{
		try
		{
			float bpm = float.Parse(DPNHODJHGJL, NumberStyles.Float);
			this.SetBPM(bpm);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06010B42 RID: 68418 RVA: 0x005A9558 File Offset: 0x005A7758
	public MapData GetEditedMapDataObj()
	{
		return this.editedMapData;
	}

	// Token: 0x06010B43 RID: 68419 RVA: 0x005A9560 File Offset: 0x005A7760
	public void Reset()
	{
		Debug.Log("[MapEditor] Reset");
		Singleton<EditorHistoryHandler>.Instance.Clear();
		this.currentState = MapEditor.EditorState.Init;
		this.DMOOGKMALBD = false;
		this.CAFHKDIIDEE = null;
		this.editedMapData = null;
		this.isRecording = false;
		this.PAODIJKEBCA = false;
		this.isPlaying = false;
		this.currentTime = 0f;
		this.currentEventsCanvasId = 0;
		this.GPNKNBLBFOD = base.GetComponent<CustomEventEditor>();
		this.editingEventGO = null;
		this.AEAKHCLJFDH = null;
		DropDownList component = this.eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>();
		component.Start();
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.eventConfigCanvas, false, null, true, 0f, true));
		this.UpdateTopMenu();
		this.UpdateBottomBar();
		this.currentTimeText.text = "0.00:0.00";
	}

	// Token: 0x06010B44 RID: 68420 RVA: 0x005A963C File Offset: 0x005A783C
	public void FindNearestEvent(bool OAKJLAFMOHO = false)
	{
		this.editingEventGO = this.KIDAPPHEPBE();
		if (this.editingEventGO && (OAKJLAFMOHO || this.editingEventGO != this.AEAKHCLJFDH))
		{
			this.GPNKNBLBFOD.Load(this.editingEventGO.GetComponent<EditorEvent>());
			this.AEAKHCLJFDH = this.editingEventGO;
		}
	}

	// Token: 0x06010B45 RID: 68421 RVA: 0x005A96A4 File Offset: 0x005A78A4
	public IEnumerator ShowOutdatedMapWarning()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#updateoutdatedmap", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value = (float)MapData.GetLastConfigVersion();
			yield return base.StartCoroutine(this.Save(true, true));
			this.IIIGPJIJHKD(this.CAFHKDIIDEE);
		}
		Singleton<SaveSystem>.Instance.SetBool("maps." + this.CAFHKDIIDEE + ".sawoutdatedmessage", true, null);
		yield break;
	}

	// Token: 0x06010B46 RID: 68422 RVA: 0x005A96BF File Offset: 0x005A78BF
	public void OnAboutButton()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("MapEditor v." + Helpers.GetGameVersion() + "\nCreated by Oxy949", "#ok", null, true, false, 0f);
	}

	// Token: 0x06010B47 RID: 68423 RVA: 0x005A96EC File Offset: 0x005A78EC
	public void ScrollTime(float EHHBHEJBHNG)
	{
		Singleton<UI>.Instance.ClearSelection();
		this.NLJJIAIEIDH(EHHBHEJBHNG, true);
	}

	// Token: 0x06010B48 RID: 68424 RVA: 0x005A9700 File Offset: 0x005A7900
	public void AddRecordedEventGO(string NOJGGCLPPAM, int PGJECADBIOI, float NPAFFMIFMCD = -1f)
	{
		if (this.editedMapData.handCount < 2)
		{
			string item = NOJGGCLPPAM;
			if (NOJGGCLPPAM == "[Up]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				item = Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData();
			}
			this.AddNewEvent((NPAFFMIFMCD >= 0f) ? NPAFFMIFMCD : this.currentTime, new List<string>
			{
				"SpawnObj",
				item
			}, true);
		}
		else
		{
			string arg = NOJGGCLPPAM;
			if (NOJGGCLPPAM == "[Up]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData();
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				arg = Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData();
			}
			this.AddNewEvent((NPAFFMIFMCD >= 0f) ? NPAFFMIFMCD : this.currentTime, new List<string>
			{
				"SpawnObj",
				arg + "," + PGJECADBIOI
			}, true);
		}
	}

	// Token: 0x06010B49 RID: 68425 RVA: 0x005A98A8 File Offset: 0x005A7AA8
	public IEnumerator UpdateMapAssets(string BNJFKKGOACF, string EAGJAOLHFGB, string FLMDNANCAAC, string CAFHKDIIDEE, bool MEPPNHMBCFL = false, int ACODLKJMCJF = 1)
	{
		Debug.Log("[MapEditor] Updating map assets");
		string text = BNJFKKGOACF + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(text, true));
		Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
		if (!string.IsNullOrEmpty(EAGJAOLHFGB) && File.Exists(EAGJAOLHFGB))
		{
			FileInfo fileInfo = new FileInfo(EAGJAOLHFGB);
			File.Delete(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.iconFile);
			File.Copy(EAGJAOLHFGB, BNJFKKGOACF + "/icon" + fileInfo.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.iconFile = "icon" + fileInfo.Extension;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(BNJFKKGOACF + "/icon" + fileInfo.Extension, BNJFKKGOACF + "/icon" + fileInfo.Extension, true, false));
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).icon = (Sprite)ResourcesManager.GetLoadedResource(BNJFKKGOACF + "/icon" + fileInfo.Extension);
		}
		if (!string.IsNullOrEmpty(FLMDNANCAAC) && File.Exists(FLMDNANCAAC))
		{
			FileInfo fileInfo2 = new FileInfo(FLMDNANCAAC);
			File.Delete(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile);
			File.Copy(FLMDNANCAAC, BNJFKKGOACF + "/music" + fileInfo2.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile = "music" + fileInfo2.Extension;
			float musicTime = 0f;
			string fullName = new FileInfo(BNJFKKGOACF + "/" + Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicFile).FullName;
			yield return base.StartCoroutine(Helpers.GetAudioLength(fullName, true));
			musicTime = Helpers.resultAudioLength;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.musicTime = musicTime;
		}
		if (!string.IsNullOrEmpty(CAFHKDIIDEE) && MEPPNHMBCFL)
		{
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.name = CAFHKDIIDEE;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.configVersion = MapData.GetLastConfigVersion();
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapperSteamID = SteamUser.GetSteamID().m_SteamID;
			Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData.handCount = ACODLKJMCJF;
		}
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		Helpers.CheckDirectory(BNJFKKGOACF);
		yield return base.StartCoroutine(Helpers.SaveFile(BNJFKKGOACF + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		yield break;
	}

	// Token: 0x06010B4A RID: 68426 RVA: 0x005A98F0 File Offset: 0x005A7AF0
	public void UpdateBottomBar()
	{
		string text = string.Empty;
		if (!this.IsMapLoaded())
		{
			if (LocalizationService.Instance && LocalizationService.Instance.inited)
			{
				text = LocalizationService.Instance.GetLocalizatedText("#mapnotloaded");
			}
		}
		else
		{
			text = string.Concat(new object[]
			{
				this.CAFHKDIIDEE,
				"  |  ",
				Singleton<EditorHistoryHandler>.Instance.GetCurrentStateString(),
				"  |  Events Count: ",
				this.editedMapData.events.Count
			});
		}
		this.statusBarText.text = text;
		if (GameObject.Find("PlayButton"))
		{
			GameObject.Find("PlayButton").GetComponent<Image>().sprite = ((!this.audioSampler.audioSources[1].isPlaying) ? this.playImage : this.pauseImage);
		}
		if (GameObject.Find("RecordButton"))
		{
			Button component = GameObject.Find("RecordButton").GetComponent<Button>();
			ColorBlock colors = component.colors;
			colors.normalColor = (this.isRecording ? Color.red : Color.black);
			colors.highlightedColor = Helpers.HexToColor("#8E8E8EFF");
			colors.disabledColor = Color.black;
			colors.pressedColor = Helpers.HexToColor("#C8C8C8FF");
			component.colors = colors;
		}
	}

	// Token: 0x06010B4B RID: 68427 RVA: 0x005A9A6C File Offset: 0x005A7C6C
	public void ToggleVolume()
	{
		this.DMOOGKMALBD = !this.DMOOGKMALBD;
		this.volumePanel.GetComponentInChildren<Slider>().value = base.GetComponent<VolumeSettings>().GetEditorVolume();
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.volumePanel, this.DMOOGKMALBD, null, true, 0.2f, true));
		Singleton<UI>.Instance.ClearSelection();
	}

	// Token: 0x06010B4C RID: 68428 RVA: 0x005A9AD4 File Offset: 0x005A7CD4
	public void TogglePlay()
	{
		Singleton<UI>.Instance.ClearSelection();
		this.isPlaying = !this.isPlaying;
		this.audioSampler.audioSources[1].time = this.currentTime;
		if (this.isPlaying)
		{
			this.audioSampler.audioSources[1].Play();
		}
		else
		{
			this.audioSampler.audioSources[1].Pause();
		}
		this.UpdateBottomBar();
	}

	// Token: 0x06010B4D RID: 68429 RVA: 0x005A9B58 File Offset: 0x005A7D58
	private IEnumerator GMKAIGKBLAA()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		if (MapEditor.PABLEKNHGMG.LNIJKGECNME == null)
		{
			MapEditor.PABLEKNHGMG.LNIJKGECNME = new Func<bool>(MapEditor.PABLEKNHGMG.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MapEditor.PABLEKNHGMG.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(0, -1, new List<int>
		{
			0,
			2,
			3,
			4
		}, false, null, null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			base.StartCoroutine(this.NODFLLCDCOH(Singleton<MapsListSelector>.Instance.result));
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		}
		yield break;
	}

	// Token: 0x06010B4E RID: 68430 RVA: 0x005A9B74 File Offset: 0x005A7D74
	public IEnumerator GPEMLDLGEHG(string JFEBNHAPGBG, string MOMKGLKFJED)
	{
		if (!string.IsNullOrEmpty(MOMKGLKFJED) && File.Exists(MOMKGLKFJED))
		{
			FileInfo fileInfo = new FileInfo(MOMKGLKFJED);
			string text = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath + "/" + fileInfo.Name;
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(MOMKGLKFJED, text);
			yield return null;
			MapResource item = new MapResource(JFEBNHAPGBG, "Sprite", fileInfo.Name);
			this.editedMapData.levelResources.Add(item);
			yield return base.StartCoroutine(this.Save(false, true));
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
			this.ReloadResList();
		}
		yield break;
	}

	// Token: 0x06010B4F RID: 68431 RVA: 0x005A9B9D File Offset: 0x005A7D9D
	private static bool HGPHALHGDDD(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[1] == "_Value2";
	}

	// Token: 0x06010B50 RID: 68432 RVA: 0x005A9BB8 File Offset: 0x005A7DB8
	public void OnPublichButton()
	{
		if (Singleton<GameManager>.Instance.GetCurrentBanLevel() <= 1)
		{
			base.StartCoroutine(this.ONJIIJDEFOM());
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

	// Token: 0x06010B51 RID: 68433 RVA: 0x005A9C98 File Offset: 0x005A7E98
	private void PFIPOJIIODP(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("[LevelEditorScene] Error: I/O Failure! :(");
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultInsufficientPrivilege)
		{
			if (eResult != EResult.k_EResultTimeout)
			{
				if (eResult == EResult.k_EResultNotLoggedOn)
				{
					Debug.Log("[LevelEditorScene] Error: You're not logged into Steam!");
				}
			}
			else
			{
				Debug.Log("[LevelEditorScene] Error: Timeout :S");
			}
		}
		else
		{
			Debug.Log("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(");
		}
		if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
		{
			Debug.Log("[MapEditor] Item creation successful! Published Item ID: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
			base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), true));
			base.StartCoroutine(this.KGCHKEGFNHI(NPIKJHPJIEA.m_nPublishedFileId, "Created"));
		}
	}

	// Token: 0x06010B52 RID: 68434 RVA: 0x005A9DC0 File Offset: 0x005A7FC0
	private void HDMEKGJCKMG(string NBGPBKCPFDN)
	{
		this.IIIGPJIJHKD(NBGPBKCPFDN);
	}

	// Token: 0x06010B53 RID: 68435 RVA: 0x005A9DD8 File Offset: 0x005A7FD8
	private void FAGPOJDCKEC(float EHHBHEJBHNG)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, new List<string>
		{
			"Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: "
		});
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "_AdaptionSpeed";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().FMGBIHDGKBI();
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_EmissionGain", true);
		this.UpdateBottomBar();
		this.FindNearestEvent(true);
	}

	// Token: 0x06010B54 RID: 68436 RVA: 0x005A9E74 File Offset: 0x005A8074
	public IEnumerator ConfirmExiting()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#exitmapeditor", "#yes", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			if (!this.IsMapLoaded())
			{
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
			else
			{
				if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapchanges?", "#yes", null, "#no", null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						yield return base.StartCoroutine(this.Save(true, true));
					}
				}
				Time.timeScale = 1f;
				ResourcesManager.UnloadResources(false);
				SceneManager.LoadScene("MenuScene");
			}
		}
		yield break;
	}

	// Token: 0x06010B55 RID: 68437 RVA: 0x005A9E90 File Offset: 0x005A8090
	private IEnumerator NODFLLCDCOH(string JMMILEFMACB)
	{
		string text = JMMILEFMACB + "_copy" + UnityEngine.Random.Range(1000000, 10000000);
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Singleton<MapsSystem>.Instance.GetMapData(JMMILEFMACB).fullLevelPath, Helpers.GetDirectory("Editor/" + text), true);
			string text2 = Helpers.GetDirectory("Editor/" + text) + "/" + Helpers.workshopConfigFileName;
			if (new FileInfo(text2).Exists)
			{
				File.Delete(text2);
			}
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text3 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text3);
			Debug.Log("[MapEditor] Importing map: " + text3);
			yield return base.StartCoroutine(this.UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), null, null, text3, false, 1));
			this.IIIGPJIJHKD(text3);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010B56 RID: 68438 RVA: 0x005A9EB4 File Offset: 0x005A80B4
	public GameObject AddNewEvent(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null, bool KFDLOHFINOD = true)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "event";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		if (KFDLOHFINOD)
		{
			Singleton<EditorHistoryHandler>.Instance.SaveState("Added event", false);
			this.UpdateBottomBar();
			this.FindNearestEvent(true);
		}
		return gameObject;
	}

	// Token: 0x06010B57 RID: 68439 RVA: 0x005A9F45 File Offset: 0x005A8145
	public void SetBPM(float DPNHODJHGJL)
	{
		this.BPM = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010B58 RID: 68440 RVA: 0x005A9F54 File Offset: 0x005A8154
	[CompilerGenerated]
	private static float NMNLKCNHNIN(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010B59 RID: 68441 RVA: 0x005A9F5C File Offset: 0x005A815C
	public void OnDeleteButton()
	{
		if (Singleton<EditorArcsSelector>.Instance.selectedunits.Count > 0)
		{
			foreach (GameObject obj in Singleton<EditorArcsSelector>.Instance.selectedunits)
			{
				UnityEngine.Object.Destroy(obj);
			}
			Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
			Singleton<EditorHistoryHandler>.Instance.SaveState("Delete events", false);
		}
	}

	// Token: 0x06010B5A RID: 68442 RVA: 0x005A9FF0 File Offset: 0x005A81F0
	public void OnMapResourcesButton()
	{
		this.currentState = MapEditor.EditorState.Busy;
		Singleton<UI>.Instance.SwitchView("ResourcesConfig", 0.2f);
	}

	// Token: 0x06010B5B RID: 68443 RVA: 0x005AA010 File Offset: 0x005A8210
	private IEnumerator DGJDBEHHFCB()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		if (MapEditor.ICAGHLKBFLC.LNIJKGECNME == null)
		{
			MapEditor.ICAGHLKBFLC.LNIJKGECNME = new Func<bool>(MapEditor.ICAGHLKBFLC.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MapEditor.ICAGHLKBFLC.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(1, 0, new List<int>
		{
			1
		}, false, null, null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			this.IIIGPJIJHKD(Singleton<MapsListSelector>.Instance.result);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		}
		yield break;
	}

	// Token: 0x06010B5C RID: 68444 RVA: 0x005AA02B File Offset: 0x005A822B
	[CompilerGenerated]
	private static bool IFMCPCOBNNH(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "SetSpeed";
	}

	// Token: 0x06010B5D RID: 68445 RVA: 0x005AA044 File Offset: 0x005A8244
	public void OnFastVideoButton()
	{
		string nbebmkfpbep = "https://www.youtube.com/watch?v=cDVXukrKo74";
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
	}

	// Token: 0x06010B5E RID: 68446 RVA: 0x005AA063 File Offset: 0x005A8263
	public void SetBPMOffsetText(string DPNHODJHGJL)
	{
		this.BPMOffset = float.Parse(DPNHODJHGJL);
		this.DPGILDLHMLM();
	}

	// Token: 0x06010B5F RID: 68447 RVA: 0x005AA078 File Offset: 0x005A8278
	public void SetEditedData(MapData NOJGGCLPPAM)
	{
		Singleton<EditorArcsSelector>.Instance.ClearSelection();
		this.editedMapData = new MapData(NOJGGCLPPAM);
		this.configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>().text = this.editedMapData.name;
		this.configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>().text = this.editedMapData.info;
		this.configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>().text = this.editedMapData.moreInfoURL;
		this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().minValue = 1f;
		this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().maxValue = (float)MapData.GetLastConfigVersion();
		this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value = (float)this.editedMapData.configVersion;
		this.configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>().value = (float)((int)this.editedMapData.speed);
		this.configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>().value = (float)this.editedMapData.lives;
		this.configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>().value = (float)this.editedMapData.maxLives;
		this.configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>().value = (float)this.editedMapData.handCount;
		this.configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>().value = (float)this.editedMapData.environmentType;
		this.configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>().isOn = this.editedMapData.hidden;
		GameObject gameObject = this.tagsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string text in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "tagElement";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<Toggle>().isOn = this.editedMapData.tags.Contains(text);
			gameObject2.GetComponentInChildren<Text>().text = text;
		}
		if (Helpers.specialTags.Count > 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.tagHeaderElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "tagElement";
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.GetComponentInChildren<Text>().text = " ";
		}
		foreach (string text2 in Helpers.tags)
		{
			GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.name = "tagElement";
			gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject4.GetComponent<Toggle>().isOn = this.editedMapData.tags.Contains(text2);
			gameObject4.GetComponentInChildren<Text>().text = text2;
		}
		this.PLICILPAOJJ();
		this.ReloadResList();
		if (this.editedMapData.configVersion >= 3 && !string.IsNullOrEmpty(this.editedMapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(this.editedMapData.e, Singleton<SaveSystem>.Instance.folder));
				this.editedMapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		IEnumerator enumerator3 = this.eventsContainer.transform.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				object obj = enumerator3.Current;
				Transform transform = (Transform)obj;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator3 as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		foreach (MapEvent mapEvent in this.editedMapData.events)
		{
			GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
			gameObject5.transform.SetParent(this.eventsContainer.transform);
			gameObject5.GetComponent<EditorEvent>().mapEvent = mapEvent;
			gameObject5.GetComponent<EditorEvent>().UpdateEvent();
			gameObject5.name = "event";
		}
		foreach (float num in this.editedMapData.checkpoints)
		{
			float ehhbhejbhng = num;
			GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
			gameObject6.transform.SetParent(this.eventsContainer.transform);
			gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(ehhbhejbhng, new List<string>
			{
				"checkpoint"
			});
			gameObject6.GetComponent<EditorEvent>().UpdateEvent();
			gameObject6.name = "checkpoint";
		}
		this.GPNKNBLBFOD.StopEditing();
		this.UpdateBottomBar();
		this.FindNearestEvent(true);
	}

	// Token: 0x06010B60 RID: 68448 RVA: 0x005AA768 File Offset: 0x005A8968
	public void SwichCanvas()
	{
		this.currentEventsCanvasId++;
		if (this.currentEventsCanvasId >= this.eventsCanvases.Count)
		{
			this.currentEventsCanvasId = 0;
		}
		if (this.eventConfigCanvas.activeSelf)
		{
			this.FindNearestEvent(false);
		}
	}

	// Token: 0x06010B61 RID: 68449 RVA: 0x005AA7B7 File Offset: 0x005A89B7
	public void SetBPMText(string DPNHODJHGJL)
	{
		this.SetBPM(float.Parse(DPNHODJHGJL));
	}

	// Token: 0x06010B62 RID: 68450 RVA: 0x005AA7C5 File Offset: 0x005A89C5
	public void ToggleRecord()
	{
		Singleton<UI>.Instance.ClearSelection();
		this.isRecording = !this.isRecording;
		this.UpdateBottomBar();
	}

	// Token: 0x06010B63 RID: 68451 RVA: 0x005AA7E8 File Offset: 0x005A89E8
	public void OnAddButton(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			if (this.eventsCanvases[this.currentEventsCanvasId].forType == MapEditor.EventType.Gameplay)
			{
				this.AddNewEvent(this.currentTime, new List<string>
				{
					"SpawnObj",
					"[Up]"
				}, true);
			}
			else
			{
				this.AddNewEvent(this.currentTime, new List<string>
				{
					"ShowTitle",
					",0"
				}, true);
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			this.AJEFOEJANDB(this.currentTime);
		}
	}

	// Token: 0x06010B64 RID: 68452 RVA: 0x005AA884 File Offset: 0x005A8A84
	public void OnNewMapButton()
	{
		Singleton<UI>.Instance.SwitchView("MapCreationCanvas", 0.2f);
	}

	// Token: 0x06010B65 RID: 68453 RVA: 0x005AA89A File Offset: 0x005A8A9A
	public string GetMapID()
	{
		return this.CAFHKDIIDEE;
	}

	// Token: 0x06010B66 RID: 68454 RVA: 0x005AA8A4 File Offset: 0x005A8AA4
	private IEnumerator AMAENBAABIN()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		if (MapEditor.ICAGHLKBFLC.LNIJKGECNME == null)
		{
			MapEditor.ICAGHLKBFLC.LNIJKGECNME = new Func<bool>(MapEditor.ICAGHLKBFLC.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MapEditor.ICAGHLKBFLC.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(1, 0, new List<int>
		{
			1
		}, false, null, null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			this.IIIGPJIJHKD(Singleton<MapsListSelector>.Instance.result);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		}
		yield break;
	}

	// Token: 0x06010B67 RID: 68455 RVA: 0x005AA8C0 File Offset: 0x005A8AC0
	private IEnumerator IEJIFEMNJCJ()
	{
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		if (MapEditor.PABLEKNHGMG.LNIJKGECNME == null)
		{
			MapEditor.PABLEKNHGMG.LNIJKGECNME = new Func<bool>(MapEditor.PABLEKNHGMG.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MapEditor.PABLEKNHGMG.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(0, -1, new List<int>
		{
			0,
			2,
			3,
			4
		}, false, null, null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			base.StartCoroutine(this.NODFLLCDCOH(Singleton<MapsListSelector>.Instance.result));
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		}
		yield break;
	}

	// Token: 0x06010B68 RID: 68456 RVA: 0x005AA8DC File Offset: 0x005A8ADC
	private void EHEAELMGGIH()
	{
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (!this.GPNKNBLBFOD.isEditing && this.currentState == MapEditor.EditorState.MapLoaded)
		{
			if (Input.mouseScrollDelta.y != 0f)
			{
				if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
				{
					this.zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 0.2f;
				}
				else
				{
					this.NLJJIAIEIDH(-Input.mouseScrollDelta.y * Camera.main.orthographicSize * 0.2f, false);
				}
			}
			if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl) && !flag)
			{
				if (Input.GetKeyDown(KeyCode.Space))
				{
					this.TogglePlay();
				}
				if (Input.GetKeyDown(KeyCode.R))
				{
					this.ToggleRecord();
				}
				if (Input.GetKeyDown(KeyCode.Delete))
				{
					this.OnDeleteButton();
				}
				if (Input.GetKeyDown(KeyCode.G))
				{
					this.Slowmo();
				}
				if (Input.GetKeyDown(KeyCode.B))
				{
					this.SetBPMEnabled(!this.useBPMSnap);
					this.useBpmToggle.isOn = this.useBPMSnap;
				}
				if (Input.GetKeyDown(KeyCode.H))
				{
					this.SpeedUp();
				}
				if (Input.GetKeyDown(KeyCode.Tab))
				{
					this.SwichCanvas();
				}
			}
		}
		if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
		{
			if (Input.GetKeyDown(KeyCode.Z))
			{
				Singleton<EditorHistoryHandler>.Instance.Undo();
			}
			if (Input.GetKeyDown(KeyCode.Y))
			{
				Singleton<EditorHistoryHandler>.Instance.Redo();
			}
			if (this.currentState == MapEditor.EditorState.MapLoaded && !flag)
			{
				if (Input.GetKeyDown(KeyCode.A))
				{
					Singleton<EditorArcsSelector>.Instance.SelectAll();
				}
				if (Input.GetKeyDown(KeyCode.C))
				{
					Singleton<EditorArcsSelector>.Instance.SaveSelectedToMemory();
				}
				if (Input.GetKeyDown(KeyCode.V))
				{
					Singleton<EditorArcsSelector>.Instance.PasteFromMemory(this.currentTime);
				}
				if (Input.GetMouseButtonDown(2))
				{
					this.SetZoom(5f);
				}
				if (Input.GetKeyDown(KeyCode.E))
				{
					this.OnEventConfigButton();
				}
			}
		}
		if (!this.isRecording && !this.GPNKNBLBFOD.isEditing && !flag)
		{
			if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					this.OnAddButton(0);
				}
				if (Input.GetKeyDown(KeyCode.C))
				{
					this.OnAddButton(1);
				}
			}
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				this.NLJJIAIEIDH(-0.1f * Camera.main.orthographicSize, false);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				this.NLJJIAIEIDH(0.1f * Camera.main.orthographicSize, false);
			}
			if (Input.GetKeyDown(KeyCode.UpArrow) && this.currentEventsCanvasId < this.eventsCanvases.Count - 1)
			{
				this.currentEventsCanvasId++;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(false);
				}
			}
			if (Input.GetKeyDown(KeyCode.DownArrow) && this.currentEventsCanvasId > 0)
			{
				this.currentEventsCanvasId--;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(false);
				}
			}
		}
	}

	// Token: 0x06010B69 RID: 68457 RVA: 0x005AAC5F File Offset: 0x005A8E5F
	public void OnCreateNewMapButton()
	{
		base.StartCoroutine(this.OECGEKPJPCB());
	}

	// Token: 0x06010B6B RID: 68459 RVA: 0x005AAC9C File Offset: 0x005A8E9C
	public MapData GetEditedData(bool KIIAKJPJDKB = true)
	{
		this.editedMapData.name = this.configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>().text;
		this.editedMapData.info = this.configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>().text;
		this.editedMapData.moreInfoURL = this.configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>().text;
		this.editedMapData.speed = (float)((int)this.configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>().value);
		this.editedMapData.configVersion = (int)this.configCanvas.transform.Find("Tab1Content").Find("ConfigVersionSlider").GetComponent<Slider>().value;
		this.editedMapData.lives = (int)this.configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>().value;
		this.editedMapData.maxLives = (int)this.configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>().value;
		this.editedMapData.handCount = (int)this.configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>().value;
		this.editedMapData.environmentType = (int)this.configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>().value;
		this.editedMapData.hidden = this.configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>().isOn;
		if (KIIAKJPJDKB)
		{
			this.editedMapData.musicTime = this.audioSampler.audioSources[1].clip.length;
		}
		this.editedMapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		foreach (Toggle toggle in gameObject.GetComponentsInChildren<Toggle>())
		{
			if (toggle.isOn)
			{
				this.editedMapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (this.editedMapData.handCount == 1)
		{
			this.editedMapData.tags.Add("OneHand");
		}
		else if (this.editedMapData.handCount == 2)
		{
			this.editedMapData.tags.Add("TwoHands");
		}
		this.editedMapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		foreach (InputField inputField in gameObject.GetComponentsInChildren<InputField>())
		{
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				this.editedMapData.unlockConditions.Add(inputField.text);
			}
		}
		this.editedMapData.events.Clear();
		if (this.editedMapData.configVersion >= 3)
		{
			MapData.EData edata = new MapData.EData();
			edata.events = new List<MapEvent>();
			for (int k = 0; k < this.eventsContainer.transform.childCount; k++)
			{
				if (this.eventsContainer.transform.GetChild(k).name == "event")
				{
					MapEvent mapEvent = new MapEvent(this.eventsContainer.transform.GetChild(k).GetComponent<EditorEvent>().mapEvent);
					if (Helpers.IsStoryboardEvent(mapEvent.data[0]))
					{
						this.editedMapData.events.Add(mapEvent);
					}
					else
					{
						edata.events.Add(mapEvent);
					}
				}
			}
			MapData mapData = this.editedMapData;
			IEnumerable<MapEvent> events = this.editedMapData.events;
			if (MapEditor.CLCBJCKCBDD == null)
			{
				MapEditor.CLCBJCKCBDD = new Func<MapEvent, float>(MapEditor.ABCOEBPCAJI);
			}
			mapData.events = events.OrderBy(MapEditor.CLCBJCKCBDD).ToList<MapEvent>();
			MapData.EData edata2 = edata;
			IEnumerable<MapEvent> events2 = edata.events;
			if (MapEditor.HCLEECLNOEA == null)
			{
				MapEditor.HCLEECLNOEA = new Func<MapEvent, float>(MapEditor.MMAGIMBKFLF);
			}
			edata2.events = events2.OrderBy(MapEditor.HCLEECLNOEA).ToList<MapEvent>();
			this.editedMapData.e = global::Console.Log(JsonConvert.SerializeObject(edata), Singleton<SaveSystem>.Instance.folder);
		}
		else
		{
			for (int l = 0; l < this.eventsContainer.transform.childCount; l++)
			{
				if (this.eventsContainer.transform.GetChild(l).name == "event")
				{
					MapEvent item = new MapEvent(this.eventsContainer.transform.GetChild(l).GetComponent<EditorEvent>().mapEvent);
					this.editedMapData.events.Add(item);
				}
			}
			MapData mapData2 = this.editedMapData;
			IEnumerable<MapEvent> events3 = this.editedMapData.events;
			if (MapEditor.ADLAKIHINOM == null)
			{
				MapEditor.ADLAKIHINOM = new Func<MapEvent, float>(MapEditor.NMNLKCNHNIN);
			}
			mapData2.events = events3.OrderBy(MapEditor.ADLAKIHINOM).ToList<MapEvent>();
			this.editedMapData.e = string.Empty;
		}
		this.editedMapData.checkpoints.Clear();
		for (int m = 0; m < this.eventsContainer.transform.childCount; m++)
		{
			if (this.eventsContainer.transform.GetChild(m).name == "checkpoint")
			{
				this.editedMapData.checkpoints.Add(new MapEvent(this.eventsContainer.transform.GetChild(m).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = this.editedMapData;
		IEnumerable<float> checkpoints = this.editedMapData.checkpoints;
		if (MapEditor.KCAPKHIJOHL == null)
		{
			MapEditor.KCAPKHIJOHL = new Func<float, float>(MapEditor.LPLFCLBJPEI);
		}
		mapData3.checkpoints = checkpoints.OrderBy(MapEditor.KCAPKHIJOHL).ToList<float>();
		return this.editedMapData;
	}

	// Token: 0x06010B6C RID: 68460 RVA: 0x005AB32C File Offset: 0x005A952C
	public void Slowmo()
	{
		this.audioSampler.audioSources[1].pitch -= 0.25f;
		if (this.audioSampler.audioSources[1].pitch < 0.25f)
		{
			this.audioSampler.audioSources[1].pitch = 0.25f;
		}
	}

	// Token: 0x06010B6D RID: 68461 RVA: 0x005AB396 File Offset: 0x005A9596
	public void OnSaveButton()
	{
		base.StartCoroutine(this.Save(true, true));
	}

	// Token: 0x06010B6E RID: 68462 RVA: 0x005AB3A8 File Offset: 0x005A95A8
	public void Update()
	{
		if (!this.PAODIJKEBCA && Input.GetKeyDown(KeyCode.Escape))
		{
			this.OnExitButton();
		}
		if (this.PAODIJKEBCA)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(this.FHKGDJDOKNB, out num, out num2);
			float iadppjhimbg = num / num2;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null, true, false, 0f);
				this.PAODIJKEBCA = false;
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Preparing configuration", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Preparing content", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Uploading content", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Uploading preview image", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Committing changes...", "PLEASE WAIT", null, false, true, iadppjhimbg);
				break;
			}
		}
		if (!this.IsMapLoaded())
		{
			this.currentTimeText.text = "0.00/0.00";
		}
		else
		{
			this.currentTimeText.text = this.currentTime.ToString("0.00") + "/" + this.audioSampler.audioSources[1].clip.length.ToString("0.00");
			this.currentTimeSlider.value = this.currentTime;
			if (this.isPlaying)
			{
				if (this.audioSampler.audioSources[1].isPlaying)
				{
					this.currentTime = this.audioSampler.audioSources[1].time;
					if (this.eventConfigCanvas.activeSelf)
					{
						this.FindNearestEvent(false);
					}
				}
				else
				{
					this.isPlaying = false;
					this.UpdateBottomBar();
				}
			}
			this.EHEAELMGGIH();
		}
	}

	// Token: 0x06010B6F RID: 68463 RVA: 0x005AB5C4 File Offset: 0x005A97C4
	public void OnEventConfigButton()
	{
		bool flag = !this.eventConfigCanvas.activeSelf;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.eventConfigCanvas, flag, null, true, 0.2f, true));
		if (flag)
		{
			this.FindNearestEvent(false);
		}
		else
		{
			this.GPNKNBLBFOD.StopEditing();
			Singleton<UI>.Instance.ClearSelection();
		}
	}

	// Token: 0x06010B70 RID: 68464 RVA: 0x005053D3 File Offset: 0x005035D3
	[CompilerGenerated]
	private static float LPLFCLBJPEI(float HPHENPOHOMK)
	{
		return HPHENPOHOMK;
	}

	// Token: 0x06010B71 RID: 68465 RVA: 0x005AB627 File Offset: 0x005A9827
	public void OnPasteButton()
	{
		Singleton<EditorArcsSelector>.Instance.selectedunits.Clear();
		Singleton<EditorArcsSelector>.Instance.PasteFromMemory(this.currentTime);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Delete events", false);
	}

	// Token: 0x06010B72 RID: 68466 RVA: 0x005AB658 File Offset: 0x005A9858
	private IEnumerator FLFAONNOBFL()
	{
		string text = GameObject.Find("MapFolderInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		int acodlkjmcjf = (int)GameObject.Find("NewMapHandsCountSlider").GetComponent<Slider>().value;
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Helpers.ObtainAchievement(10);
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			string text2 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text2);
			Debug.Log("[MapEditor] Created new map: " + text2);
			yield return base.StartCoroutine(this.UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), result, result2, text2, true, acodlkjmcjf));
			this.IIIGPJIJHKD(text2);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010B73 RID: 68467 RVA: 0x005AB674 File Offset: 0x005A9874
	public float GetSnappedBPM(float GEMDHBEGEFH)
	{
		if (this.useBPMSnap)
		{
			bool flag = true;
			float result = 0f;
			float num = 0f;
			int num2 = 0;
			while ((float)num2 <= (float)Mathf.CeilToInt(this.editedMapData.musicTime) * (this.BPM * (float)this.BPMSplit / 60f))
			{
				float num3 = this.BPMOffset + (float)num2 * (60f / (this.BPM * (float)this.BPMSplit));
				if (flag)
				{
					result = num3;
					num = Mathf.Abs(GEMDHBEGEFH - num3);
					flag = false;
				}
				if (Mathf.Abs(GEMDHBEGEFH - num3) < num)
				{
					result = num3;
					num = Mathf.Abs(GEMDHBEGEFH - num3);
				}
				num2++;
			}
			return result;
		}
		return GEMDHBEGEFH;
	}

	// Token: 0x06010B74 RID: 68468 RVA: 0x005AB726 File Offset: 0x005A9926
	public void SetBPMEnabled(bool DPNHODJHGJL)
	{
		this.useBPMSnap = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010B75 RID: 68469 RVA: 0x005AB738 File Offset: 0x005A9938
	public GameObject HBLICNDEMAK(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null, bool KFDLOHFINOD = true)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "Joystick1Button7";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		if (KFDLOHFINOD)
		{
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("#tryagain", true);
			this.UpdateBottomBar();
			this.FindNearestEvent(false);
		}
		return gameObject;
	}

	// Token: 0x06010B76 RID: 68470 RVA: 0x005AB7CC File Offset: 0x005A99CC
	private void BLLONNLMMNA()
	{
		string nbebmkfpbep = Singleton<GameManager>.Instance.CreateServerURL("uploads/Intralism/mods_terms.pdf");
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
	}

	// Token: 0x06010B77 RID: 68471 RVA: 0x005AB7F8 File Offset: 0x005A99F8
	public void LHKFPHHOLKE(MapData NOJGGCLPPAM)
	{
		Singleton<EditorArcsSelector>.Instance.ClearSelection();
		this.editedMapData = new MapData(NOJGGCLPPAM);
		this.configCanvas.transform.Find("' found!").Find("LevelEditor/patterns").GetComponent<InputField>().text = this.editedMapData.name;
		this.configCanvas.transform.Find("_Value").Find("F3").GetComponent<InputField>().text = this.editedMapData.info;
		this.configCanvas.transform.Find("Set satellite audio input").Find("Error: you cannot read this stream that you are writing!").GetComponent<InputField>().text = this.editedMapData.moreInfoURL;
		this.configCanvas.transform.Find("_OcclusionTexture").Find("PointsScoreText").GetComponent<Slider>().minValue = 1738f;
		this.configCanvas.transform.Find("mapselector.filter.favoriteonly").Find("Remove Environment Object").GetComponent<Slider>().maxValue = (float)MapData.GAEEAAPAIAI();
		this.configCanvas.transform.Find(". MasterClient: ").Find("_TimeX").GetComponent<Slider>().value = (float)this.editedMapData.configVersion;
		this.configCanvas.transform.Find("</color>").Find("_DistortionWave").GetComponent<Slider>().value = (float)((int)this.editedMapData.speed);
		this.configCanvas.transform.Find("CameraFilterPack/Atmosphere_Rain_Pro_3D").Find("_Blue_B").GetComponent<Slider>().value = (float)this.editedMapData.lives;
		this.configCanvas.transform.Find("Source Object: ").Find(" has been disabled as it's not supported on the current platform.").GetComponent<Slider>().value = (float)this.editedMapData.maxLives;
		this.configCanvas.transform.Find("closed").Find(" By: ").GetComponent<Slider>().value = (float)this.editedMapData.handCount;
		this.configCanvas.transform.Find("Right Stick Click").Find("/Saved Games/").GetComponent<Slider>().value = (float)this.editedMapData.environmentType;
		this.configCanvas.transform.Find("/").Find("Horizontal").GetComponent<Toggle>().isOn = this.editedMapData.hidden;
		GameObject gameObject = this.tagsScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string text in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "_Blend";
			gameObject2.transform.localScale = new Vector3(1153f, 1542f, 1375f);
			gameObject2.GetComponent<Toggle>().isOn = this.editedMapData.tags.Contains(text);
			gameObject2.GetComponentInChildren<Text>().text = text;
		}
		if (Helpers.specialTags.Count > 1)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.tagHeaderElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "Horizontal";
			gameObject3.transform.localScale = new Vector3(815f, 289f, 206f);
			gameObject3.GetComponentInChildren<Text>().text = "GlassesColor2";
		}
		foreach (string text2 in Helpers.tags)
		{
			GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.name = "VIGNETTE_DESAT";
			gameObject4.transform.localScale = new Vector3(615f, 918f, 969f);
			gameObject4.GetComponent<Toggle>().isOn = this.editedMapData.tags.Contains(text2);
			gameObject4.GetComponentInChildren<Text>().text = text2;
		}
		this.PLICILPAOJJ();
		this.ReloadResList();
		if (this.editedMapData.configVersion >= 2 && !string.IsNullOrEmpty(this.editedMapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(this.editedMapData.e, Singleton<SaveSystem>.Instance.folder));
				this.editedMapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		IEnumerator enumerator3 = this.eventsContainer.transform.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				object obj = enumerator3.Current;
				Transform transform = (Transform)obj;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator3 as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		foreach (MapEvent mapEvent in this.editedMapData.events)
		{
			GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
			gameObject5.transform.SetParent(this.eventsContainer.transform);
			gameObject5.GetComponent<EditorEvent>().mapEvent = mapEvent;
			gameObject5.GetComponent<EditorEvent>().NJDJHMPAIFE();
			gameObject5.name = "downloading";
		}
		foreach (float num in this.editedMapData.checkpoints)
		{
			float ehhbhejbhng = num;
			GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
			gameObject6.transform.SetParent(this.eventsContainer.transform);
			gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(ehhbhejbhng, new List<string>
			{
				"Object ID. Case-Sensitive"
			});
			gameObject6.GetComponent<EditorEvent>().UpdateEvent();
			gameObject6.name = ": ";
		}
		this.GPNKNBLBFOD.MABHOELCKCO();
		this.UpdateBottomBar();
		this.FindNearestEvent(false);
	}

	// Token: 0x06010B78 RID: 68472 RVA: 0x005ABEE8 File Offset: 0x005AA0E8
	public void OnLicenceButton()
	{
		this.BLLONNLMMNA();
	}

	// Token: 0x06010B79 RID: 68473 RVA: 0x005ABEF0 File Offset: 0x005AA0F0
	private void DPGILDLHMLM()
	{
		this.currentBPMText.text = LocalizationService.Instance.GetLocalizatedText("#currentbpm: ");
		this.currentBpmOffsetInputField.text = string.Empty + this.BPMOffset;
		this.currentBpmInputField.text = string.Empty + this.BPM;
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvas.bpmGrid.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator2 as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		if (this.useBPMSnap)
		{
			int num = 0;
			while ((float)num <= (float)Mathf.CeilToInt(this.editedMapData.musicTime) * (this.BPM * (float)this.BPMSplit / 60f))
			{
				foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.bpmGridGameObject);
					gameObject.transform.SetParent(eventsCanvas2.bpmGrid);
					gameObject.transform.localPosition = new Vector3(this.BPMOffset + (float)num * (60f / (this.BPM * (float)this.BPMSplit)), 0f, 0f);
					gameObject.name = "bpmgrid";
				}
				num++;
			}
		}
	}

	// Token: 0x06010B7A RID: 68474 RVA: 0x005AC0EC File Offset: 0x005AA2EC
	private IEnumerator KGCHKEGFNHI(PublishedFileId_t JMMILEFMACB, string GIGBCMLIKKE)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		string haebghhmebh = fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(haebghhmebh, true));
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate((AppId_t)513510U, JMMILEFMACB);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE);
		SteamUGC.SetItemTitle(ugcupdateHandle_t, mapData.mapData.name);
		SteamUGC.SetItemDescription(ugcupdateHandle_t, mapData.mapData.info);
		SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
		SteamUGC.SetItemContent(ugcupdateHandle_t, fullLevelPath);
		SteamUGC.SetItemPreview(ugcupdateHandle_t, fullLevelPath + "/" + mapData.mapData.iconFile);
		List<string> tags = mapData.mapData.tags;
		SteamUGC.SetItemTags(ugcupdateHandle_t, tags);
		this.PAODIJKEBCA = true;
		SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, GIGBCMLIKKE);
		this.FHKGDJDOKNB = ugcupdateHandle_t;
		this.KAPDFIOHNGL.Set(hAPICall, null);
		yield break;
	}

	// Token: 0x06010B7B RID: 68475 RVA: 0x005AC115 File Offset: 0x005AA315
	public void OnMapConfigButton()
	{
		this.currentState = MapEditor.EditorState.Busy;
		Singleton<UI>.Instance.SwitchView("MapConfig", 0.2f);
	}

	// Token: 0x06010B7C RID: 68476 RVA: 0x005AC134 File Offset: 0x005AA334
	private IEnumerator PPEKKHNBMIH()
	{
		yield return new WaitForSeconds(0.5f);
		Singleton<UI>.Instance.SwitchView("StartCanvas", 0.2f);
		yield break;
	}

	// Token: 0x06010B7D RID: 68477 RVA: 0x005AC148 File Offset: 0x005AA348
	public void OnMapStatsButton()
	{
		MapData editedData = this.GetEditedData(true);
		int mapMaxScore = Helpers.GetMapMaxScore(editedData);
		float mapDifficulty = Helpers.GetMapDifficulty(editedData);
		if (editedData.configVersion >= 3 && !string.IsNullOrEmpty(editedData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(editedData.e, Singleton<SaveSystem>.Instance.folder));
				editedData.events.AddRange(editedData.events);
			}
			catch (Exception)
			{
			}
		}
		float num = editedData.speed;
		float num2 = editedData.speed;
		IEnumerable<MapEvent> events = editedData.events;
		if (MapEditor.LNIJKGECNME == null)
		{
			MapEditor.LNIJKGECNME = new Func<MapEvent, bool>(MapEditor.IFMCPCOBNNH);
		}
		List<MapEvent> list = events.Where(MapEditor.LNIJKGECNME).ToList<MapEvent>();
		if (list.Count > 0)
		{
			foreach (MapEvent mapEvent in list)
			{
				float num3 = float.Parse(mapEvent.data[1], CultureInfo.InvariantCulture);
				if (num > num3)
				{
					num = num3;
				}
				if (num2 < num3)
				{
					num2 = num3;
				}
			}
		}
		string format = "{0,-18} {1,18}";
		string text = "<b><i>Map's Stats:</i></b>" + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		text = text + string.Format(format, "<b>Difficulty</b>:", mapDifficulty.ToString("0.00")) + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		text = text + string.Format(format, "<b>Max Score</b>:", mapMaxScore) + Environment.NewLine;
		text = text + string.Format(format, "<b>Time</b>:", editedData.musicTime.ToString("0.00")) + Environment.NewLine;
		text = text + string.Format(format, "<b>HP</b>:", editedData.lives + "/" + editedData.maxLives) + Environment.NewLine;
		text = text + string.Format(format, "<b>Speed</b>:", num.ToString("0") + "-" + num2.ToString("0")) + Environment.NewLine;
		text = text + "--------------------------------" + Environment.NewLine;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(text, "#ok", null, true, false, 0f);
	}

	// Token: 0x06010B7E RID: 68478 RVA: 0x005AC3E0 File Offset: 0x005AA5E0
	public void OnBackToEditorButton()
	{
		this.currentState = MapEditor.EditorState.MapLoaded;
		Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		if (this.eventConfigCanvas.activeSelf)
		{
			this.FindNearestEvent(true);
		}
	}

	// Token: 0x06010B7F RID: 68479 RVA: 0x005AC414 File Offset: 0x005AA614
	private IEnumerator OECGEKPJPCB()
	{
		text = GameObject.Find("MapFolderInputField").GetComponent<InputField>().text;
		result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		result2 = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		acodlkjmcjf = (int)GameObject.Find("NewMapHandsCountSlider").GetComponent<Slider>().value;
		Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Helpers.ObtainAchievement(10);
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			text2 = "editor." + text;
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text2);
			Debug.Log("[MapEditor] Created new map: " + text2);
			yield return base.StartCoroutine(this.UpdateMapAssets(Helpers.GetDirectory("Editor/" + text), result, result2, text2, true, acodlkjmcjf));
			this.IIIGPJIJHKD(text2);
		}
		else
		{
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#alreadyexist", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010B80 RID: 68480 RVA: 0x005AC42F File Offset: 0x005AA62F
	private void LCJDCFFEMLP()
	{
		base.StartCoroutine(this.ConfirmExiting());
	}

	// Token: 0x06010B81 RID: 68481 RVA: 0x005AC440 File Offset: 0x005AA640
	private void PLICILPAOJJ()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		using (List<string>.Enumerator enumerator = this.editedMapData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MapEditor.CFBBHNAOKPA cfbbhnaokpa = new MapEditor.CFBBHNAOKPA();
				cfbbhnaokpa.IEOKJCPAOHL = enumerator.Current;
				cfbbhnaokpa.ADPIKBBAKHP = this;
				MapEditor.NDFEKONPOMG ndfekonpomg = new MapEditor.NDFEKONPOMG();
				ndfekonpomg.KHCIOAJAKOO = cfbbhnaokpa;
				ndfekonpomg.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				ndfekonpomg.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				ndfekonpomg.OBFJPHLBFOL.transform.localScale = new Vector3(1f, 1f, 1f);
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = cfbbhnaokpa.IEOKJCPAOHL;
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				ndfekonpomg.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(ndfekonpomg.GBKBDKHPLKG));
				num++;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	// Token: 0x06010B82 RID: 68482 RVA: 0x005AC60C File Offset: 0x005AA80C
	public void OnLoadMapButton()
	{
		base.StartCoroutine(this.AMAENBAABIN());
	}

	// Token: 0x06010B83 RID: 68483 RVA: 0x005AC61B File Offset: 0x005AA81B
	[CompilerGenerated]
	private void MOFDPGHNDMO()
	{
		this.AddNewUnlockCondition();
	}

	// Token: 0x06010B84 RID: 68484 RVA: 0x005AC624 File Offset: 0x005AA824
	private void CKJMMGCPIHO()
	{
		this.currentBPMText.text = LocalizationService.Instance.HOPMEAJKPHL("Failed to InstantiateSceneObject prefab: ");
		this.currentBpmOffsetInputField.text = string.Empty + this.BPMOffset;
		this.currentBpmInputField.text = string.Empty + this.BPM;
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvas.bpmGrid.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator2 as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		if (this.useBPMSnap)
		{
			int num = 0;
			while ((float)num <= (float)Mathf.CeilToInt(this.editedMapData.musicTime) * (this.BPM * (float)this.BPMSplit / 986f))
			{
				foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.bpmGridGameObject);
					gameObject.transform.SetParent(eventsCanvas2.bpmGrid);
					gameObject.transform.localPosition = new Vector3(this.BPMOffset + (float)num * (586f / (this.BPM * (float)this.BPMSplit)), 344f, 1584f);
					gameObject.name = "Joystick1Button0";
				}
				num++;
			}
		}
	}

	// Token: 0x06010B85 RID: 68485 RVA: 0x005AC820 File Offset: 0x005AAA20
	public IEnumerator Save(bool BLIOAGPOANM = true, bool KIIAKJPJDKB = true)
	{
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		}
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData = this.GetEditedData(KIIAKJPJDKB);
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		Debug.Log("[MapEditor] Exported to " + fullLevelPath);
		Singleton<EditorHistoryHandler>.Instance.OnMapSaved();
		if (BLIOAGPOANM)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010B86 RID: 68486 RVA: 0x005AC849 File Offset: 0x005AAA49
	public void HAEIHFOMIIJ()
	{
		base.StartCoroutine(this.IEJIFEMNJCJ());
	}

	// Token: 0x06010B87 RID: 68487 RVA: 0x005AC858 File Offset: 0x005AAA58
	public void SetBPMSplit(float DPNHODJHGJL)
	{
		this.BPMSplit = (int)DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010B88 RID: 68488 RVA: 0x005AC868 File Offset: 0x005AAA68
	private void GINAEDMALEA()
	{
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (!this.GPNKNBLBFOD.isEditing && this.currentState == MapEditor.EditorState.MapLoaded)
		{
			if (Input.mouseScrollDelta.y != 1982f)
			{
				if (Input.GetKey((KeyCode)(-120)) || Input.GetKey((KeyCode)(-29)))
				{
					this.zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 1832f;
				}
				else
				{
					this.NLJJIAIEIDH(-Input.mouseScrollDelta.y * Camera.main.orthographicSize * 679f, false);
				}
			}
			if (!Input.GetKey((KeyCode)134) && !Input.GetKey((KeyCode)(-20)) && !flag)
			{
				if (Input.GetKeyDown((KeyCode)85))
				{
					this.TogglePlay();
				}
				if (Input.GetKeyDown(KeyCode.LeftBracket))
				{
					this.ToggleRecord();
				}
				if (Input.GetKeyDown((KeyCode)25))
				{
					this.OnDeleteButton();
				}
				if (Input.GetKeyDown((KeyCode)(-51)))
				{
					this.Slowmo();
				}
				if (Input.GetKeyDown(KeyCode.Q))
				{
					this.SetBPMEnabled(this.useBPMSnap);
					this.useBpmToggle.isOn = this.useBPMSnap;
				}
				if (Input.GetKeyDown((KeyCode)(-24)))
				{
					this.SpeedUp();
				}
				if (Input.GetKeyDown((KeyCode)(-35)))
				{
					this.SwichCanvas();
				}
			}
		}
		if (Input.GetKey((KeyCode)(-42)) || Input.GetKey(KeyCode.Minus))
		{
			if (Input.GetKeyDown(KeyCode.Return))
			{
				Singleton<EditorHistoryHandler>.Instance.Undo();
			}
			if (Input.GetKeyDown(KeyCode.G))
			{
				Singleton<EditorHistoryHandler>.Instance.HIABDMALLGO();
			}
			if (this.currentState == MapEditor.EditorState.MapLoaded && !flag)
			{
				if (Input.GetKeyDown((KeyCode)(-24)))
				{
					Singleton<EditorArcsSelector>.Instance.IFEJJGEAGBM();
				}
				if (Input.GetKeyDown(KeyCode.Percent))
				{
					Singleton<EditorArcsSelector>.Instance.HONMFAMJNLD();
				}
				if (Input.GetKeyDown((KeyCode)30))
				{
					Singleton<EditorArcsSelector>.Instance.IJOGFHDIBHP(this.currentTime);
				}
				if (Input.GetMouseButtonDown(3))
				{
					this.HDBJAPODAGG(626f);
				}
				if (Input.GetKeyDown((KeyCode)(-116)))
				{
					this.OnEventConfigButton();
				}
			}
		}
		if (!this.isRecording && !this.GPNKNBLBFOD.isEditing && !flag)
		{
			if (!Input.GetKey((KeyCode)(-39)) && !Input.GetKey((KeyCode)(-157)))
			{
				if (Input.GetKeyDown((KeyCode)79))
				{
					this.OnAddButton(1);
				}
				if (Input.GetKeyDown((KeyCode)(-39)))
				{
					this.OnAddButton(0);
				}
			}
			if (Input.GetKey((KeyCode)(-58)))
			{
				this.NLJJIAIEIDH(1951f * Camera.main.orthographicSize, false);
			}
			if (Input.GetKey(KeyCode.A))
			{
				this.NLJJIAIEIDH(693f * Camera.main.orthographicSize, true);
			}
			if (Input.GetKeyDown((KeyCode)(-183)) && this.currentEventsCanvasId < this.eventsCanvases.Count - 1)
			{
				this.currentEventsCanvasId += 0;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(true);
				}
			}
			if (Input.GetKeyDown((KeyCode)(-1)) && this.currentEventsCanvasId > 0)
			{
				this.currentEventsCanvasId -= 0;
				if (this.eventConfigCanvas.activeSelf)
				{
					this.FindNearestEvent(true);
				}
			}
		}
	}

	// Token: 0x06010B89 RID: 68489 RVA: 0x005ACBEB File Offset: 0x005AADEB
	public void HDBJAPODAGG(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		Singleton<UI>.Instance.GGIFLKMELMP();
		this.zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	// Token: 0x06010B8A RID: 68490 RVA: 0x005ACC13 File Offset: 0x005AAE13
	public void OnImportMapButton()
	{
		base.StartCoroutine(this.GMKAIGKBLAA());
	}

	// Token: 0x06010B8B RID: 68491 RVA: 0x005ACC22 File Offset: 0x005AAE22
	public void SetZoom(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		Singleton<UI>.Instance.ClearSelection();
		this.zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	// Token: 0x06010B8C RID: 68492 RVA: 0x005ACC4A File Offset: 0x005AAE4A
	public void OnExitButton()
	{
		this.LCJDCFFEMLP();
	}

	// Token: 0x06010B8D RID: 68493 RVA: 0x005ACC54 File Offset: 0x005AAE54
	private IEnumerator ONJIIJDEFOM()
	{
		if (Singleton<EditorHistoryHandler>.Instance.savedHistoryState != Singleton<EditorHistoryHandler>.Instance.state)
		{
			yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#savemapbeforeuploading", "#yes", null, "#no", null));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return base.StartCoroutine(this.Save(true, true));
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)) + ".completed", 0, null) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#creatingnewitem", string.Empty, null, false, false, 0f);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510U, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				Debug.Log("[MapsEditor] Creating new item...");
			}
			else
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#mapalreadyexistupdate", "#yes", null, "#no", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("#changenote", "#submit", null, null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						base.StartCoroutine(this.KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
					}
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#mapmustbecompletebeforesubmit", "OK", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06010B8E RID: 68494 RVA: 0x005ACC70 File Offset: 0x005AAE70
	public void OnApplyCustomEventButton(List<string> NKEHMBLLEMH)
	{
		if (this.editingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = this.editingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(this.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text, NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			this.editingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			this.editingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			this.editingEventGO.GetComponent<EditorEvent>().UpdatePositionFromData();
			this.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text = string.Empty + this.editingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			this.FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited event", false);
		}
	}

	// Token: 0x06010B8F RID: 68495 RVA: 0x005ACD6C File Offset: 0x005AAF6C
	public void LIGNDDCOBJH(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			if (this.eventsCanvases[this.currentEventsCanvasId].forType == MapEditor.EventType.Gameplay)
			{
				this.AddNewEvent(this.currentTime, new List<string>
				{
					"z",
					"BitsData"
				}, false);
			}
			else
			{
				this.AddNewEvent(this.currentTime, new List<string>
				{
					"(master)",
					".lastCheckpoint.correctScore"
				}, true);
			}
		}
		if (HMGBJCGOLMI == 0)
		{
			this.FAGPOJDCKEC(this.currentTime);
		}
	}

	// Token: 0x06010B90 RID: 68496 RVA: 0x005ACE08 File Offset: 0x005AB008
	public void SpeedUp()
	{
		this.audioSampler.audioSources[1].pitch += 0.25f;
		if (this.audioSampler.audioSources[1].pitch > 1f)
		{
			this.audioSampler.audioSources[1].pitch = 1f;
		}
	}

	// Token: 0x06010B91 RID: 68497 RVA: 0x005ACE74 File Offset: 0x005AB074
	public void UpdateTopMenu()
	{
		Debug.Log("[MapEditor] Updating top menu");
		bool flag = this.IsMapLoaded();
		bool flag2 = this.currentState == MapEditor.EditorState.Busy;
		this.topMenuPanel.transform.Find("FileMenu").GetComponent<Button>().interactable = !flag2;
		this.topMenuPanel.transform.Find("FileMenu").FindDeepChild("SaveMapButton").GetComponent<Button>().interactable = flag;
		this.topMenuPanel.transform.Find("FileMenu").FindDeepChild("PublishMapButton").GetComponent<Button>().interactable = flag;
		this.topMenuPanel.transform.Find("FileMenu").FindDeepChild("TestMapButton").GetComponent<Button>().interactable = flag;
		this.topMenuPanel.transform.Find("EditMenu").GetComponent<Button>().interactable = (flag && !flag2);
		this.topMenuPanel.transform.Find("EventMenu").GetComponent<Button>().interactable = (flag && !flag2);
		this.topMenuPanel.transform.Find("ViewMenu").GetComponent<Button>().interactable = (flag && !flag2);
		this.topMenuPanel.transform.Find("HelpMenu").GetComponent<Button>().interactable = !flag2;
	}

	// Token: 0x06010B92 RID: 68498 RVA: 0x005ACFE4 File Offset: 0x005AB1E4
	public void Start()
	{
		this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.PFIPOJIIODP));
		this.KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.BMDDFOKBIAK));
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Map Editor", "Creating awesome maps", null, null, 0, 0);
		this.Reset();
		base.StartCoroutine(this.PPEKKHNBMIH());
	}

	// Token: 0x06010B93 RID: 68499 RVA: 0x005AD04C File Offset: 0x005AB24C
	public void OnAddNewResourceButton()
	{
		string text = GameObject.Find("ResourceIDInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("ResourceFileSelector").GetComponent<FileSelector>().result;
		base.StartCoroutine(this.AddNewLevelResoure(text, result));
	}

	// Token: 0x06010B94 RID: 68500 RVA: 0x005AD092 File Offset: 0x005AB292
	public void SetBPMOffset(float DPNHODJHGJL)
	{
		this.BPMOffset = DPNHODJHGJL;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010B95 RID: 68501 RVA: 0x005AA89A File Offset: 0x005A8A9A
	public string FONMIHBONDF()
	{
		return this.CAFHKDIIDEE;
	}

	// Token: 0x06010B96 RID: 68502 RVA: 0x005AD0A4 File Offset: 0x005AB2A4
	private void BPOJHBIEMOJ()
	{
		this.DPGILDLHMLM();
		IEnumerator enumerator = Camera.main.gameObject.transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform = (Transform)obj;
				if (transform.name == "caret")
				{
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.caretGameObject);
		gameObject.name = "caret";
		gameObject.transform.SetParent(Camera.main.gameObject.transform);
		gameObject.transform.localPosition = new Vector3(0f, 0f, 1f);
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator3 = eventsCanvas.grid.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					object obj2 = enumerator3.Current;
					Transform transform2 = (Transform)obj2;
					UnityEngine.Object.Destroy(transform2.gameObject);
				}
			}
			finally
			{
				IDisposable disposable2;
				if ((disposable2 = (enumerator3 as IDisposable)) != null)
				{
					disposable2.Dispose();
				}
			}
		}
		int num = 0;
		while ((float)num < this.editedMapData.musicTime)
		{
			foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.gridGameObject);
				gameObject2.transform.SetParent(eventsCanvas2.grid);
				gameObject2.transform.localPosition = new Vector3((float)num, 0f, 0f);
				gameObject2.name = "grid";
			}
			num++;
		}
	}

	// Token: 0x06010B97 RID: 68503 RVA: 0x005A9F54 File Offset: 0x005A8154
	[CompilerGenerated]
	private static float ABCOEBPCAJI(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010B98 RID: 68504 RVA: 0x005AD2DC File Offset: 0x005AB4DC
	public IEnumerator AddNewLevelResoure(string JFEBNHAPGBG, string MOMKGLKFJED)
	{
		if (!string.IsNullOrEmpty(MOMKGLKFJED) && File.Exists(MOMKGLKFJED))
		{
			fileInfo = new FileInfo(MOMKGLKFJED);
			text = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath + "/" + fileInfo.Name;
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(MOMKGLKFJED, text);
			yield return null;
			item = new MapResource(JFEBNHAPGBG, "Sprite", fileInfo.Name);
			this.editedMapData.levelResources.Add(item);
			yield return base.StartCoroutine(this.Save(false, true));
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
			this.ReloadResList();
		}
		yield break;
	}

	// Token: 0x06010B99 RID: 68505 RVA: 0x005A9F54 File Offset: 0x005A8154
	[CompilerGenerated]
	private static float MMAGIMBKFLF(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x06010B9A RID: 68506 RVA: 0x005AD308 File Offset: 0x005AB508
	private void NLJJIAIEIDH(float EHHBHEJBHNG, bool BNLKFNOIDHH = true)
	{
		if (this.IsMapLoaded())
		{
			float num;
			if (BNLKFNOIDHH)
			{
				num = EHHBHEJBHNG * this.audioSampler.audioSources[1].clip.length;
			}
			else
			{
				num = this.currentTime + EHHBHEJBHNG;
			}
			if (num < 0f)
			{
				num = 0f;
			}
			if (num >= this.audioSampler.audioSources[1].clip.length)
			{
				num = this.audioSampler.audioSources[1].clip.length;
			}
			this.currentTime = num;
			if (this.eventConfigCanvas.activeSelf)
			{
				this.FindNearestEvent(false);
			}
			if (this.isPlaying)
			{
				this.audioSampler.audioSources[1].time = this.currentTime;
			}
		}
	}

	// Token: 0x06010B9B RID: 68507 RVA: 0x005AD3EC File Offset: 0x005AB5EC
	private void AJEFOEJANDB(float EHHBHEJBHNG)
	{
		if (this.useBPMSnap)
		{
			EHHBHEJBHNG = this.GetSnappedBPM(EHHBHEJBHNG);
		}
		MapEvent mapEvent = new MapEvent(EHHBHEJBHNG, new List<string>
		{
			"checkpoint"
		});
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.eventGameObject);
		gameObject.name = "checkpoint";
		gameObject.transform.SetParent(this.eventsContainer.transform);
		gameObject.GetComponent<EditorEvent>().mapEvent = mapEvent;
		gameObject.GetComponent<EditorEvent>().UpdateEvent();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added checkpoint", false);
		this.UpdateBottomBar();
		this.FindNearestEvent(true);
	}

	// Token: 0x06010B9C RID: 68508 RVA: 0x005AD487 File Offset: 0x005AB687
	private void IIIGPJIJHKD(string NBGPBKCPFDN)
	{
		this.Reset();
		this.CAFHKDIIDEE = NBGPBKCPFDN;
		base.StartCoroutine(this.GOGFAHNINFB());
	}

	// Token: 0x06010B9D RID: 68509 RVA: 0x005AD4A4 File Offset: 0x005AB6A4
	private GameObject KIDAPPHEPBE()
	{
		GameObject result = null;
		if (this.audioSampler.audioSources[1].clip != null)
		{
			float num = float.PositiveInfinity;
			for (int i = 0; i < this.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = this.eventsContainer.transform.GetChild(i).gameObject;
				if (gameObject.name != "checkpoint")
				{
					Vector3 position = gameObject.transform.position;
					float sqrMagnitude = (position - new Vector3(this.currentTime, (float)((this.currentEventsCanvasId != 0) ? 2 : -2), 0f)).sqrMagnitude;
					if (sqrMagnitude <= num && gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
					{
						result = gameObject;
						num = sqrMagnitude;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06010B9E RID: 68510 RVA: 0x005AD487 File Offset: 0x005AB687
	private void BDOIODEMFHC(string NBGPBKCPFDN)
	{
		this.Reset();
		this.CAFHKDIIDEE = NBGPBKCPFDN;
		base.StartCoroutine(this.GOGFAHNINFB());
	}

	// Token: 0x06010B9F RID: 68511 RVA: 0x005AD5AD File Offset: 0x005AB7AD
	public bool IsMapLoaded()
	{
		return this.currentState == MapEditor.EditorState.MapLoaded && !string.IsNullOrEmpty(this.CAFHKDIIDEE);
	}

	// Token: 0x06010BA0 RID: 68512 RVA: 0x005AD5CC File Offset: 0x005AB7CC
	public void OnUpdateMapMainResourceButton(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.GKGAABCOKHJ(HMGBJCGOLMI));
	}

	// Token: 0x06010BA1 RID: 68513 RVA: 0x005AD5DC File Offset: 0x005AB7DC
	public void SetBPMOffsetToCaret()
	{
		this.BPMOffset = this.currentTime;
		this.DPGILDLHMLM();
	}

	// Token: 0x06010BA2 RID: 68514 RVA: 0x005AD5F0 File Offset: 0x005AB7F0
	public void AddNewUnlockCondition()
	{
		this.editedMapData.unlockConditions.Add(string.Empty);
		this.PLICILPAOJJ();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions", false);
	}

	// Token: 0x06010BA3 RID: 68515 RVA: 0x005AD620 File Offset: 0x005AB820
	private void BMDDFOKBIAK(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null, true, false, 0f);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultOK)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed!", "#ok", null, true, false, 0f);
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=" + NPIKJHPJIEA.m_nPublishedFileId, true);
			Debug.Log("[LevelEditorScene] Map submitted!");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#done", "#ok", null, true, false, 0f);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, false))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
				string ddaomdpaiep = fullLevelPath + "/" + Helpers.levelConfigFileName;
				int mapMaxScore = Helpers.GetMapMaxScore(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
				float mapDifficulty = Helpers.GetMapDifficulty(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData);
				base.StartCoroutine(Singleton<RanksSystem>.Instance.UpdateOfficialMap(string.Empty + NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, Helpers.CalculateMD5(ddaomdpaiep), mapDifficulty, mapMaxScore));
			}
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		this.PAODIJKEBCA = false;
	}

	// Token: 0x06010BA4 RID: 68516 RVA: 0x005AD798 File Offset: 0x005AB998
	public void OnManualButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/files/editor_manual.pdf"), true);
	}

	// Token: 0x06010BA5 RID: 68517 RVA: 0x005AD7B4 File Offset: 0x005AB9B4
	public void ReloadResList()
	{
		GameObject gameObject = this.resourcesScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (MapResource mapResource in this.editedMapData.levelResources)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.resourcesElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "resource";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ResourceListElement>().Init(mapResource.name, mapResource.path, Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).resources[mapResource.name]);
		}
	}

	// Token: 0x06010BA6 RID: 68518 RVA: 0x005AD8CC File Offset: 0x005ABACC
	private IEnumerator GKGAABCOKHJ(int HMGBJCGOLMI)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).fullLevelPath;
		if (HMGBJCGOLMI == 0)
		{
			string result = GameObject.Find("NewIconFileSelector").GetComponent<FileSelector>().result;
			Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
			yield return new WaitForSeconds(0.2f);
			FileInfo fileInfo = new FileInfo(result);
			File.Delete(fullLevelPath + "/" + this.editedMapData.iconFile);
			File.Copy(result, fullLevelPath + "/icon" + fileInfo.Extension);
			this.editedMapData.iconFile = "icon" + fileInfo.Extension;
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData.iconFile = this.editedMapData.iconFile;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullLevelPath + "/icon" + fileInfo.Extension, fullLevelPath + "/icon" + fileInfo.Extension, true, false));
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).icon = (Sprite)ResourcesManager.GetLoadedResource(fullLevelPath + "/icon" + fileInfo.Extension);
			yield return base.StartCoroutine(this.Save(false, true));
			Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
			yield return new WaitForSeconds(0.2f);
			this.currentState = MapEditor.EditorState.MapLoaded;
		}
		if (HMGBJCGOLMI == 1)
		{
			string result2 = GameObject.Find("NewMusicFileSelector").GetComponent<FileSelector>().result;
			Singleton<UI>.Instance.SwitchView("LoadMapCanvas", 0.2f);
			yield return new WaitForSeconds(0.2f);
			FileInfo fileInfo2 = new FileInfo(result2);
			File.Delete(fullLevelPath + "/" + this.editedMapData.musicFile);
			File.Copy(result2, fullLevelPath + "/music" + fileInfo2.Extension);
			this.editedMapData.musicFile = "music" + fileInfo2.Extension;
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData.musicFile = this.editedMapData.musicFile;
			float musicTime = 0f;
			string fullName = new FileInfo(fullLevelPath + "/" + this.editedMapData.musicFile).FullName;
			yield return base.StartCoroutine(Helpers.GetAudioLength(fullName, true));
			musicTime = Helpers.resultAudioLength;
			this.editedMapData.musicTime = musicTime;
			Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE).mapData.musicTime = this.editedMapData.musicTime;
			this.currentState = MapEditor.EditorState.MapLoaded;
			yield return base.StartCoroutine(this.Save(false, false));
			this.currentState = MapEditor.EditorState.MapLoaded;
			this.IIIGPJIJHKD(this.CAFHKDIIDEE);
		}
		yield break;
	}

	// Token: 0x06010BA7 RID: 68519 RVA: 0x005AD8F0 File Offset: 0x005ABAF0
	private IEnumerator NLIGGKFCFNM()
	{
		TrashManRecycleBin khnadifnkfm = new TrashManRecycleBin
		{
			prefab = this.soundWaveGameObject,
			instancesToPreallocate = (int)this.audioSampler.audioSources[0].clip.length * 100
		};
		TrashMan.manageRecycleBin(khnadifnkfm, string.Empty);
		this.audioSampler.audioSources[0].Play();
		yield return new WaitWhile(new Func<bool>(base.GBKBDKHPLKG));
		Debug.Log("[LevelEditorScene] Print Audio Wave: Start");
		foreach (MapEditor.EventsCanvas eventsCanvas in this.eventsCanvases)
		{
			IEnumerator enumerator2 = eventsCanvas.soundwave.transform.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					Transform transform = (Transform)obj;
					TrashMan.despawn(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator2 as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		while (this.audioSampler.audioSources[0].isPlaying)
		{
			float num = this.audioSampler.GetFrequencyVol(0, FrequencyRange.Decibal) * 50f;
			foreach (MapEditor.EventsCanvas eventsCanvas2 in this.eventsCanvases)
			{
				GameObject gameObject = TrashMan.spawn(this.soundWaveGameObject, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(eventsCanvas2.soundwave.transform, true);
				gameObject.transform.localScale = new Vector3(1f, num * 20f, 1f);
				gameObject.transform.localPosition = new Vector3(this.audioSampler.audioSources[0].time, 0f, 1f);
			}
			yield return new WaitForFixedUpdate();
		}
		Debug.Log("[LevelEditorScene] Print Audio Wave: Done");
		yield return true;
		yield break;
	}

	// Token: 0x06010BA8 RID: 68520 RVA: 0x005AD90C File Offset: 0x005ABB0C
	private IEnumerator GOGFAHNINFB()
	{
		Singleton<UI>.Instance.SwitchView("Loading", 0.2f);
		yield return new WaitForSeconds(0.2f);
		Debug.Log("[MapEditor] Openning " + this.CAFHKDIIDEE);
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE);
		Debug.Log("[MapEditor] Loading music...");
		string fullName = new FileInfo(mapData.fullLevelPath + "/" + mapData.mapData.musicFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, true, false));
		AudioClip audioClip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		this.audioSampler.Init(audioClip, 0f, false);
		Debug.Log("[MapEditor] Prepairing map editor...");
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.CAFHKDIIDEE)));
		this.SetEditedData(mapData.mapData);
		this.BPOJHBIEMOJ();
		base.StopCoroutine(this.NLIGGKFCFNM());
		base.StartCoroutine(this.NLIGGKFCFNM());
		Debug.Log("[MapEditor] Loading events...");
		this.currentTimeSlider.minValue = 0f;
		this.currentTimeSlider.maxValue = audioClip.length;
		this.currentTimeSlider.value = 0f;
		this.currentState = MapEditor.EditorState.MapLoaded;
		this.UpdateTopMenu();
		this.UpdateBottomBar();
		this.FindNearestEvent(true);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", true);
		yield return new WaitForSeconds(0.5f);
		Singleton<UI>.Instance.SwitchView("Editor", 0.2f);
		yield return new WaitForSeconds(0.2f);
		if (this.editedMapData.configVersion < MapData.GetLastConfigVersion() && !Singleton<SaveSystem>.Instance.HasKey("maps." + this.CAFHKDIIDEE + ".sawoutdatedmessage", null))
		{
			base.StartCoroutine(this.ShowOutdatedMapWarning());
		}
		yield break;
	}

	// Token: 0x04001D51 RID: 7505
	public Text currentBPMText;

	// Token: 0x04001D52 RID: 7506
	public InputField currentBpmInputField;

	// Token: 0x04001D53 RID: 7507
	public InputField currentBpmOffsetInputField;

	// Token: 0x04001D54 RID: 7508
	public Toggle useBpmToggle;

	// Token: 0x04001D55 RID: 7509
	public float BPM = 120f;

	// Token: 0x04001D56 RID: 7510
	public bool useBPMSnap = true;

	// Token: 0x04001D57 RID: 7511
	public float BPMOffset;

	// Token: 0x04001D58 RID: 7512
	public int BPMSplit = 4;

	// Token: 0x04001D59 RID: 7513
	[Header("System")]
	public AudioSampler audioSampler;

	// Token: 0x04001D5A RID: 7514
	public MapEditor.EditorState currentState;

	// Token: 0x04001D5B RID: 7515
	public GameObject eventsContainer;

	// Token: 0x04001D5C RID: 7516
	public List<MapEditor.EventsCanvas> eventsCanvases;

	// Token: 0x04001D5D RID: 7517
	[Header("UI")]
	public GameObject volumePanel;

	// Token: 0x04001D5E RID: 7518
	public GameObject topMenuPanel;

	// Token: 0x04001D5F RID: 7519
	public Text statusBarText;

	// Token: 0x04001D60 RID: 7520
	public Text currentTimeText;

	// Token: 0x04001D61 RID: 7521
	public Slider currentTimeSlider;

	// Token: 0x04001D62 RID: 7522
	public Slider zoomSlider;

	// Token: 0x04001D63 RID: 7523
	public GameObject configCanvas;

	// Token: 0x04001D64 RID: 7524
	public GameObject tagsScrollRectContent;

	// Token: 0x04001D65 RID: 7525
	public GameObject unlockConditionContent;

	// Token: 0x04001D66 RID: 7526
	public GameObject resourcesScrollRectContent;

	// Token: 0x04001D67 RID: 7527
	public GameObject eventConfigCanvas;

	// Token: 0x04001D68 RID: 7528
	[Header("References")]
	public Sprite playImage;

	// Token: 0x04001D69 RID: 7529
	public Sprite pauseImage;

	// Token: 0x04001D6A RID: 7530
	public GameObject eventGameObject;

	// Token: 0x04001D6B RID: 7531
	public GameObject gridGameObject;

	// Token: 0x04001D6C RID: 7532
	public GameObject bpmGridGameObject;

	// Token: 0x04001D6D RID: 7533
	public GameObject caretGameObject;

	// Token: 0x04001D6E RID: 7534
	public GameObject soundWaveGameObject;

	// Token: 0x04001D6F RID: 7535
	public GameObject tagElement;

	// Token: 0x04001D70 RID: 7536
	public GameObject tagHeaderElement;

	// Token: 0x04001D71 RID: 7537
	public GameObject unlockConditionElement;

	// Token: 0x04001D72 RID: 7538
	public GameObject addNewUnlockConditionElement;

	// Token: 0x04001D73 RID: 7539
	public GameObject resourcesElement;

	// Token: 0x04001D74 RID: 7540
	[HideInInspector]
	public float currentTime;

	// Token: 0x04001D75 RID: 7541
	[HideInInspector]
	public int currentEventsCanvasId;

	// Token: 0x04001D76 RID: 7542
	[HideInInspector]
	public bool isPlaying;

	// Token: 0x04001D77 RID: 7543
	[HideInInspector]
	public bool isRecording;

	// Token: 0x04001D78 RID: 7544
	[HideInInspector]
	public GameObject editingEventGO;

	// Token: 0x04001D79 RID: 7545
	private string CAFHKDIIDEE;

	// Token: 0x04001D7A RID: 7546
	[SerializeField]
	private MapData editedMapData;

	// Token: 0x04001D7B RID: 7547
	private bool DMOOGKMALBD;

	// Token: 0x04001D7C RID: 7548
	private GameObject AEAKHCLJFDH;

	// Token: 0x04001D7D RID: 7549
	private CustomEventEditor GPNKNBLBFOD;

	// Token: 0x04001D7E RID: 7550
	private bool PAODIJKEBCA;

	// Token: 0x04001D7F RID: 7551
	private UGCUpdateHandle_t FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;

	// Token: 0x04001D80 RID: 7552
	protected CallResult<CreateItemResult_t> CEJIPNKDJKJ;

	// Token: 0x04001D81 RID: 7553
	protected CallResult<SubmitItemUpdateResult_t> KAPDFIOHNGL;

	// Token: 0x04001D82 RID: 7554
	[CompilerGenerated]
	private static Func<MapEvent, bool> LNIJKGECNME;

	// Token: 0x04001D83 RID: 7555
	[CompilerGenerated]
	private static Func<MapEvent, float> CLCBJCKCBDD;

	// Token: 0x04001D84 RID: 7556
	[CompilerGenerated]
	private static Func<MapEvent, float> HCLEECLNOEA;

	// Token: 0x04001D85 RID: 7557
	[CompilerGenerated]
	private static Func<MapEvent, float> ADLAKIHINOM;

	// Token: 0x04001D86 RID: 7558
	[CompilerGenerated]
	private static Func<float, float> KCAPKHIJOHL;

	// Token: 0x02000492 RID: 1170
	public enum EditorState
	{
		// Token: 0x04001D88 RID: 7560
		Init,
		// Token: 0x04001D89 RID: 7561
		MapLoaded,
		// Token: 0x04001D8A RID: 7562
		Busy
	}

	// Token: 0x02000493 RID: 1171
	public enum EventType
	{
		// Token: 0x04001D8C RID: 7564
		Gameplay,
		// Token: 0x04001D8D RID: 7565
		Storyboard
	}

	// Token: 0x02000494 RID: 1172
	[Serializable]
	public class EventsCanvas
	{
		// Token: 0x04001D8E RID: 7566
		public MapEditor.EventType forType;

		// Token: 0x04001D8F RID: 7567
		public Transform grid;

		// Token: 0x04001D90 RID: 7568
		public Transform bpmGrid;

		// Token: 0x04001D91 RID: 7569
		public Transform soundwave;
	}

	// Token: 0x0200049D RID: 1181
	[CompilerGenerated]
	private sealed class CFBBHNAOKPA
	{
		// Token: 0x04001DBE RID: 7614
		internal string IEOKJCPAOHL;

		// Token: 0x04001DBF RID: 7615
		internal MapEditor ADPIKBBAKHP;
	}

	// Token: 0x0200049E RID: 1182
	[CompilerGenerated]
	private sealed class NDFEKONPOMG
	{
		// Token: 0x06010E28 RID: 69160 RVA: 0x005BBADC File Offset: 0x005B9CDC
		internal void AKDOOLPMPMG()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("CameraFilterPack/Antialiasing_FXAA", true);
		}

		// Token: 0x06010E29 RID: 69161 RVA: 0x005BBB2C File Offset: 0x005B9D2C
		internal void BDGDIDPDBHG()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("NEW_ACHIEVEMENT_1_21", false);
		}

		// Token: 0x06010E2A RID: 69162 RVA: 0x005BBB7C File Offset: 0x005B9D7C
		internal void PCDFLCEIHFF()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_FlipAlphaMask", false);
		}

		// Token: 0x06010E2B RID: 69163 RVA: 0x005BBBCC File Offset: 0x005B9DCC
		internal void AEINPAGJFME()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("CameraFilterPack/FX_Ascii", true);
		}

		// Token: 0x06010E2C RID: 69164 RVA: 0x005BBC1C File Offset: 0x005B9E1C
		internal void EDGAPOPEIJF()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Connected to NameServer.", false);
		}

		// Token: 0x06010E2D RID: 69165 RVA: 0x005BBC6C File Offset: 0x005B9E6C
		internal void DNIMHEKGJHB()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Value2", true);
		}

		// Token: 0x06010E2E RID: 69166 RVA: 0x005BBCBC File Offset: 0x005B9EBC
		internal void DBFPGFHEGKA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_MainTex2", true);
		}

		// Token: 0x06010E2F RID: 69167 RVA: 0x005BBD0C File Offset: 0x005B9F0C
		internal void MPGGBMMPNDH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("/../", true);
		}

		// Token: 0x06010E30 RID: 69168 RVA: 0x005BBD5C File Offset: 0x005B9F5C
		internal void GBKBDKHPLKG()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions", false);
		}

		// Token: 0x06010E31 RID: 69169 RVA: 0x005BBDAC File Offset: 0x005B9FAC
		internal void DKGPCPBNDPK()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("SetSatelliteSensitivity", false);
		}

		// Token: 0x06010E33 RID: 69171 RVA: 0x005BBDFC File Offset: 0x005B9FFC
		internal void BJMAIJDIKCN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_History3ChromaTex", false);
		}

		// Token: 0x06010E34 RID: 69172 RVA: 0x005BBE4C File Offset: 0x005BA04C
		internal void BMAOCLKPNNC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("settings.volume.sfx", true);
		}

		// Token: 0x06010E35 RID: 69173 RVA: 0x005BBE9C File Offset: 0x005BA09C
		internal void AGFDCBCBAGI()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_ScreenResolution", true);
		}

		// Token: 0x06010E36 RID: 69174 RVA: 0x005BBEEC File Offset: 0x005BA0EC
		internal void MAGEPMCPGOC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("_TimeX", true);
		}

		// Token: 0x06010E37 RID: 69175 RVA: 0x005BBF3C File Offset: 0x005BA13C
		internal void OMBHIBNMFNB()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB(" to ", true);
		}

		// Token: 0x06010E38 RID: 69176 RVA: 0x005BBF8C File Offset: 0x005BA18C
		internal void BBIADFAPKDL()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE(".played", false);
		}

		// Token: 0x06010E39 RID: 69177 RVA: 0x005BBFDC File Offset: 0x005BA1DC
		internal void LNDGINDKPFA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("_Red_G", false);
		}

		// Token: 0x06010E3A RID: 69178 RVA: 0x005BC02C File Offset: 0x005BA22C
		internal void FCAGEDLBBHD()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("0x", true);
		}

		// Token: 0x06010E3B RID: 69179 RVA: 0x005BC07C File Offset: 0x005BA27C
		internal void INHOEMCLAAP()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("IEnumerable", true);
		}

		// Token: 0x06010E3C RID: 69180 RVA: 0x005BC0CC File Offset: 0x005BA2CC
		internal void AEIFJLBBKBP()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("editorVolume", true);
		}

		// Token: 0x06010E3D RID: 69181 RVA: 0x005BC11C File Offset: 0x005BA31C
		internal void JKEDCEOCPJO()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("SlidingArea", false);
		}

		// Token: 0x06010E3E RID: 69182 RVA: 0x005BC16C File Offset: 0x005BA36C
		internal void FDAIFOAGDLA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("Horizontal", false);
		}

		// Token: 0x06010E3F RID: 69183 RVA: 0x005BC1BC File Offset: 0x005BA3BC
		internal void FHIJCPPECHA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("_Value", true);
		}

		// Token: 0x06010E40 RID: 69184 RVA: 0x005BC20C File Offset: 0x005BA40C
		internal void PIJAOCFAPKC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("{0}", false);
		}

		// Token: 0x06010E41 RID: 69185 RVA: 0x005BC25C File Offset: 0x005BA45C
		internal void IGFOBPKFCDJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("A", false);
		}

		// Token: 0x06010E42 RID: 69186 RVA: 0x005BC2AC File Offset: 0x005BA4AC
		internal void PBCAHKDLFPE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("Set satellite lerp speed", true);
		}

		// Token: 0x06010E43 RID: 69187 RVA: 0x005BC2FC File Offset: 0x005BA4FC
		internal void MGENGAEDACG()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("BitsData", false);
		}

		// Token: 0x06010E44 RID: 69188 RVA: 0x005BC34C File Offset: 0x005BA54C
		internal void JDELIMPGFDJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_MainTex2", true);
		}

		// Token: 0x06010E45 RID: 69189 RVA: 0x005BC39C File Offset: 0x005BA59C
		internal void BKNHHGBPLGH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("Joystick1Button4", false);
		}

		// Token: 0x06010E46 RID: 69190 RVA: 0x005BC3EC File Offset: 0x005BA5EC
		internal void FMIHBNPKEEO()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("_MatrixSize", true);
		}

		// Token: 0x06010E47 RID: 69191 RVA: 0x005BC43C File Offset: 0x005BA63C
		internal void AGJKEBOPIOC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Added GameObject to prefabDictionary: ", true);
		}

		// Token: 0x06010E48 RID: 69192 RVA: 0x005BC48C File Offset: 0x005BA68C
		internal void FFEGPHJKMFK()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("settings.crosshairopacity", false);
		}

		// Token: 0x06010E49 RID: 69193 RVA: 0x005BC4DC File Offset: 0x005BA6DC
		internal void OFHCGKJFGDI()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("[LevelEditorScene] Print Audio Wave: Done", false);
		}

		// Token: 0x06010E4A RID: 69194 RVA: 0x005BC52C File Offset: 0x005BA72C
		internal void BEBAENEJFLD()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("Deleted event", true);
		}

		// Token: 0x06010E4B RID: 69195 RVA: 0x005BC57C File Offset: 0x005BA77C
		internal void LOEAMHGMMPK()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("value", false);
		}

		// Token: 0x06010E4C RID: 69196 RVA: 0x005BC5CC File Offset: 0x005BA7CC
		internal void EKHOOPGPPGE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("Bad parameters for setint! Use <key> <value>", false);
		}

		// Token: 0x06010E4D RID: 69197 RVA: 0x005BC61C File Offset: 0x005BA81C
		internal void GLHKGBNIHFH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_Value2", false);
		}

		// Token: 0x06010E4E RID: 69198 RVA: 0x005BC66C File Offset: 0x005BA86C
		internal void LLNDDFGPOPL()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Tab2Content", false);
		}

		// Token: 0x06010E4F RID: 69199 RVA: 0x005BC6BC File Offset: 0x005BA8BC
		internal void FIPCLHEKKCA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", false);
		}

		// Token: 0x06010E50 RID: 69200 RVA: 0x005BC70C File Offset: 0x005BA90C
		internal void EGKGJJGAPMN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("SelectorMusicToggle", false);
		}

		// Token: 0x06010E51 RID: 69201 RVA: 0x005BC75C File Offset: 0x005BA95C
		internal void BFEABMIFIEE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("_LayerThickness", false);
		}

		// Token: 0x06010E52 RID: 69202 RVA: 0x005BC7AC File Offset: 0x005BA9AC
		internal void OLIGLEMPFOP()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("_TimeX", true);
		}

		// Token: 0x06010E53 RID: 69203 RVA: 0x005BC7FC File Offset: 0x005BA9FC
		internal void FHFECFLBHMA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("CurrentTimeLabel", true);
		}

		// Token: 0x06010E54 RID: 69204 RVA: 0x005BC84C File Offset: 0x005BAA4C
		internal void MEMPOPNAEDN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("logc", false);
		}

		// Token: 0x06010E55 RID: 69205 RVA: 0x005BC89C File Offset: 0x005BAA9C
		internal void LHHFJBIAHCN()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("_SceneFogMode", true);
		}

		// Token: 0x06010E56 RID: 69206 RVA: 0x005BC8EC File Offset: 0x005BAAEC
		internal void KFNBKFELFLH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("Set sun min/max size", false);
		}

		// Token: 0x06010E57 RID: 69207 RVA: 0x005BC93C File Offset: 0x005BAB3C
		internal void LJDLIIIPIIJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Convolved_TexelSize", false);
		}

		// Token: 0x06010E58 RID: 69208 RVA: 0x005BC98C File Offset: 0x005BAB8C
		internal void JBCHBMKPDAJ()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("Pop", true);
		}

		// Token: 0x06010E59 RID: 69209 RVA: 0x005BC9DC File Offset: 0x005BABDC
		internal void JBAJEMGOPDL()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("mapselector.tags.", true);
		}

		// Token: 0x06010E5A RID: 69210 RVA: 0x005BCA2C File Offset: 0x005BAC2C
		internal void OFLDIMDDLHM()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Drop_Near", true);
		}

		// Token: 0x06010E5B RID: 69211 RVA: 0x005BCA7C File Offset: 0x005BAC7C
		internal void KGKMOLCPDIH()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("CameraFilterPack/Distortion_Twist_Square", true);
		}

		// Token: 0x06010E5C RID: 69212 RVA: 0x005BCACC File Offset: 0x005BACCC
		internal void EFAPFFFGOOA()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("n/a", true);
		}

		// Token: 0x06010E5D RID: 69213 RVA: 0x005BCB1C File Offset: 0x005BAD1C
		internal void HBJFIOJFBHC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("CameraFilterPack/Blend2Camera_Screen", true);
		}

		// Token: 0x06010E5E RID: 69214 RVA: 0x005BCB6C File Offset: 0x005BAD6C
		internal void PKAPLCFHDOC()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("0,7,true,0", true);
		}

		// Token: 0x06010E5F RID: 69215 RVA: 0x005BCBBC File Offset: 0x005BADBC
		internal void FJDBPPKABJE()
		{
			this.KHCIOAJAKOO.ADPIKBBAKHP.editedMapData.unlockConditions.Remove(this.KHCIOAJAKOO.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("addNewButton", false);
		}

		// Token: 0x04001DC0 RID: 7616
		internal GameObject OBFJPHLBFOL;

		// Token: 0x04001DC1 RID: 7617
		internal MapEditor.CFBBHNAOKPA KHCIOAJAKOO;
	}
}
