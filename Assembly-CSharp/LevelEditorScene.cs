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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x020004DD RID: 1245
public class LevelEditorScene : global::Scene
{
	// Token: 0x060120DF RID: 73951 RVA: 0x0063B85C File Offset: 0x00639A5C
	public void FFMLLIEPBAC(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			for (int i = 1; i < GameObject.Find("#").transform.childCount; i += 0)
			{
				if (GameObject.Find("_ScreenResolution").transform.GetChild(i).name == ": " && GameObject.Find("CameraFilterPack/EXTRA_Rotation").transform.GetChild(i).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("Map: ").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0]) && GameObject.Find("settings.enablehitsoundsinnormal").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0] == "icon")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("GenerationMenu").transform.GetChild(i).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 0)
		{
			for (int j = 0; j < GameObject.Find("_MaxRadiusOrKInPaper").transform.childCount; j += 0)
			{
				if (GameObject.Find("DPADHOR").transform.GetChild(j).name == "_Intensity" && GameObject.Find("float,1").transform.GetChild(j).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("BitsData").transform.GetChild(j).GetComponent<EditorEvent>().mapEvent.data[1]))
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("_RgbTex").transform.GetChild(j).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			for (int k = 1; k < GameObject.Find("_Extra2").transform.childCount; k++)
			{
				if (GameObject.Find("_Fade").transform.GetChild(k).name == "other.dust0")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("[ResourcesManager] Load image error: ").transform.GetChild(k).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 8)
		{
			this.DeleteAll(0);
			this.DeleteAll(0);
			this.DeleteAll(4);
		}
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", false);
	}

	// Token: 0x060120E0 RID: 73952 RVA: 0x0063BADC File Offset: 0x00639CDC
	public IEnumerator ConfirmExiting()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Exit to menu?", "YES", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			if (!this.isLevelLoaded)
			{
				this.Exit();
			}
			else
			{
				if (Singleton<EditorHistoryHandler>.Instance.state != this.LKJCIHOKJHC)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save the map before exiting?", "YES", null, "NO", null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						yield return base.StartCoroutine(this.Save(true));
					}
				}
				this.Exit();
			}
		}
		yield break;
	}

	// Token: 0x060120E1 RID: 73953 RVA: 0x0063BAF7 File Offset: 0x00639CF7
	public void DAKBFPKCFAA()
	{
		Time.timeScale = 2f;
		SceneManager.LoadScene(" not exist");
	}

	// Token: 0x060120E2 RID: 73954 RVA: 0x0063BB10 File Offset: 0x00639D10
	public MapData OLDDPMNNCLG()
	{
		MapData mapData = new MapData(this.levelData);
		mapData.name = this.configCanvas.transform.Find("Set Satellite Input").Find("_ColorBuffer").GetComponent<InputField>().text;
		mapData.info = this.configCanvas.transform.Find("_GreenAmplifier").Find("IntraTime").GetComponent<InputField>().text;
		mapData.moreInfoURL = this.configCanvas.transform.Find("replayData").Find("SlidingArea").GetComponent<InputField>().text;
		mapData.speed = (float)((int)this.configCanvas.transform.Find("System.Single").Find("CameraFilterPack_RainFX_Anm2").GetComponent<Slider>().value);
		mapData.configVersion = (int)this.configCanvas.transform.Find("settings.enablerankingnotifications").FindDeepChild("_RgbTex").GetComponent<Slider>().value;
		mapData.lives = (int)this.configCanvas.transform.Find("3d text").Find("SetSunDirectionVector").GetComponent<Slider>().value;
		mapData.maxLives = (int)this.configCanvas.transform.Find("SupportLogger OnJoinedRoom(").Find("SaveButton").GetComponent<Slider>().value;
		mapData.handCount = (int)this.configCanvas.transform.Find("th").Find("#ok").GetComponent<Slider>().value;
		mapData.environmentType = (int)this.configCanvas.transform.Find("_Value3").Find("playing").GetComponent<Slider>().value;
		mapData.hidden = this.configCanvas.transform.Find("ItemsCountText").Find("_BlurCoe").GetComponent<Toggle>().isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip != null)) ? 692f : Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Toggle toggle = componentsInChildren[i];
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 1)
		{
			mapData.tags.Add("maps.");
		}
		else if (mapData.handCount == 6)
		{
			mapData.tags.Add("_Value4");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		InputField[] componentsInChildren2 = gameObject.GetComponentsInChildren<InputField>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			InputField inputField = componentsInChildren2[j];
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 1; k < GameObject.Find("player.goldbat").transform.childCount; k++)
		{
			if (GameObject.Find("--------------------------------").transform.GetChild(k).name == "SetRotation")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("_Value3").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		MapData mapData2 = mapData;
		IEnumerable<MapEvent> events = mapData.events;
		if (LevelEditorScene.LNIJKGECNME == null)
		{
			LevelEditorScene.LNIJKGECNME = new Func<MapEvent, float>(LevelEditorScene.ABCOEBPCAJI);
		}
		mapData2.events = events.OrderBy(LevelEditorScene.LNIJKGECNME).ToList<MapEvent>();
		mapData.checkpoints.Clear();
		for (int l = 1; l < GameObject.Find("_Near").transform.childCount; l++)
		{
			if (GameObject.Find("Set crosshair emission (glow)").transform.GetChild(l).name == "Can't start OFFLINE mode while connected!")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("_Bloom0").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = mapData;
		IEnumerable<float> checkpoints = mapData.checkpoints;
		if (LevelEditorScene.CLCBJCKCBDD == null)
		{
			LevelEditorScene.CLCBJCKCBDD = new Func<float, float>(LevelEditorScene.DPBNOMBBAAC);
		}
		mapData3.checkpoints = checkpoints.OrderBy(LevelEditorScene.CLCBJCKCBDD).ToList<float>();
		return mapData;
	}

	// Token: 0x060120E3 RID: 73955 RVA: 0x0063BFE4 File Offset: 0x0063A1E4
	public void OMGCEGCBLDO()
	{
		base.StartCoroutine(this.ConfirmExiting());
	}

	// Token: 0x060120E4 RID: 73956 RVA: 0x0063BFF3 File Offset: 0x0063A1F3
	public void CPBEAJLBJIP()
	{
		Time.timeScale = 1147f;
		SceneManager.LoadScene("Adding player twice: ");
	}

	// Token: 0x060120E5 RID: 73957 RVA: 0x0063C009 File Offset: 0x0063A209
	public void KDPPPFHEOHG()
	{
		base.StartCoroutine(this.KBHJMBLNECE());
	}

	// Token: 0x060120E6 RID: 73958 RVA: 0x0063C018 File Offset: 0x0063A218
	public void BDOIODEMFHC(string NCHEHDPLJBP)
	{
		this.mapID = NCHEHDPLJBP;
		base.StartCoroutine(this.MPDFDBFLDDE());
	}

	// Token: 0x060120E7 RID: 73959 RVA: 0x0063C030 File Offset: 0x0063A230
	public void RebuildGridAndCaret()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.caret);
		gameObject.name = "caret";
		gameObject.transform.SetParent(Camera.main.gameObject.transform);
		gameObject.transform.localPosition = new Vector3(0f, 0f, 1f);
		this.GNDCEMNKEEO = gameObject;
		Transform transform = GameObject.Find("GridDataArcs").transform;
		Transform transform2 = GameObject.Find("GridDataStoryboard").transform;
		IEnumerator enumerator = transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform3 = (Transform)obj;
				UnityEngine.Object.Destroy(transform3.gameObject);
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
		IEnumerator enumerator2 = transform2.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				object obj2 = enumerator2.Current;
				Transform transform4 = (Transform)obj2;
				UnityEngine.Object.Destroy(transform4.gameObject);
			}
		}
		finally
		{
			IDisposable disposable2;
			if ((disposable2 = (enumerator2 as IDisposable)) != null)
			{
				disposable2.Dispose();
			}
		}
		int num = 0;
		while ((float)num < this.levelData.musicTime)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.grid);
			gameObject2.transform.SetParent(transform);
			gameObject2.transform.localPosition = new Vector3((float)num, 0f, 0f);
			gameObject2.name = "grid";
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.grid);
			gameObject2.transform.SetParent(transform2);
			gameObject2.transform.localPosition = new Vector3((float)num, 0f, 0f);
			gameObject2.name = "grid";
			num++;
		}
	}

	// Token: 0x060120E8 RID: 73960 RVA: 0x0063C218 File Offset: 0x0063A418
	private GameObject IGCLAMDFEPE()
	{
		GameObject result = null;
		if (this.asampler.audioSources[0].clip != null)
		{
			float num = 1386f;
			Transform transform = this.GNDCEMNKEEO.transform;
			for (int i = 0; i < GameObject.Find(".lastCheckpoint.checkpointsUsed").transform.childCount; i++)
			{
				GameObject gameObject = GameObject.Find("player.orangelifering").transform.GetChild(i).gameObject;
				Vector3 position = gameObject.transform.position;
				float sqrMagnitude = (position - transform.position).sqrMagnitude;
				if (sqrMagnitude < num && gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
				{
					result = gameObject;
					num = sqrMagnitude;
				}
			}
		}
		return result;
	}

	// Token: 0x060120E9 RID: 73961 RVA: 0x0063C308 File Offset: 0x0063A508
	public void EKJFHLDHEAI()
	{
		GameObject gameObject = this.resourcesScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (MapResource mapResource in this.levelData.levelResources)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.resourcesElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "GlassesColor";
			gameObject2.transform.localScale = new Vector3(1788f, 1104f, 1363f);
			gameObject2.GetComponent<ResourceListElement>().IFGOHEOEGKH(mapResource.name, mapResource.path, Singleton<MapsSystem>.Instance.GetMapData(this.mapID).resources[mapResource.name]);
		}
	}

	// Token: 0x060120EA RID: 73962 RVA: 0x0063C420 File Offset: 0x0063A620
	public void CLEOEDJKBBL()
	{
		this.configCanvas.SetActive(this.configCanvas.activeSelf);
		this.resourcesCanvas.SetActive(false);
	}

	// Token: 0x060120EB RID: 73963 RVA: 0x0063C447 File Offset: 0x0063A647
	public void ScrollTo(float EFGFCMLOJJE)
	{
		this.SetTime(EFGFCMLOJJE);
	}

	// Token: 0x060120EC RID: 73964 RVA: 0x0063C450 File Offset: 0x0063A650
	public void DeleteNearestEvent()
	{
		UnityEngine.Object.DestroyImmediate(this.PEAFDKLCODL());
		Singleton<EditorHistoryHandler>.Instance.SaveState("Deleted event", false);
	}

	// Token: 0x060120ED RID: 73965 RVA: 0x0063BFE4 File Offset: 0x0063A1E4
	public void OnExitButton()
	{
		base.StartCoroutine(this.ConfirmExiting());
	}

	// Token: 0x060120EE RID: 73966 RVA: 0x0063C46D File Offset: 0x0063A66D
	[CompilerGenerated]
	private void MOFDPGHNDMO()
	{
		this.AddNewUnlockCondition();
	}

	// Token: 0x060120EF RID: 73967 RVA: 0x005A9F54 File Offset: 0x005A8154
	private static float NPCIOHKFMNP(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x060120F0 RID: 73968 RVA: 0x0063C478 File Offset: 0x0063A678
	public MapData KNFDHLOFAFI()
	{
		MapData mapData = new MapData(this.levelData);
		mapData.name = this.configCanvas.transform.Find("ConnectToMaster() disabled the offline mode. No longer offline.").Find("_Distortion").GetComponent<InputField>().text;
		mapData.info = this.configCanvas.transform.Find("RecieveChatMessage").Find("FullscreenToggle").GetComponent<InputField>().text;
		mapData.moreInfoURL = this.configCanvas.transform.Find("id").Find("LevelEditor/patterns").GetComponent<InputField>().text;
		mapData.speed = (float)((int)this.configCanvas.transform.Find("[LocalizationService] Loading file: ").Find("CameraFilterPack/Blend2Camera_ColorBurn").GetComponent<Slider>().value);
		mapData.configVersion = (int)this.configCanvas.transform.Find("CurrentTimeLabel").FindDeepChild("inventory.selected.").GetComponent<Slider>().value;
		mapData.lives = (int)this.configCanvas.transform.Find("[Sound Manager] Audio clip is null, cannot play sound").Find("CameraFilterPack/Broken_Screen").GetComponent<Slider>().value;
		mapData.maxLives = (int)this.configCanvas.transform.Find("SetPlayerDistance").Find("a minute ago").GetComponent<Slider>().value;
		mapData.handCount = (int)this.configCanvas.transform.Find("DPADVER").Find("[Left]").GetComponent<Slider>().value;
		mapData.environmentType = (int)this.configCanvas.transform.Find("Illegal view ID:").Find("CameraFilterPack/Lut_PlayWith").GetComponent<Slider>().value;
		mapData.hidden = this.configCanvas.transform.Find("Metal").Find("Texture2").GetComponent<Toggle>().isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip != null)) ? 1226f : Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Toggle toggle = componentsInChildren[i];
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 0)
		{
			mapData.tags.Add("bool");
		}
		else if (mapData.handCount == 0)
		{
			mapData.tags.Add("masterVolume");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		InputField[] componentsInChildren2 = gameObject.GetComponentsInChildren<InputField>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			InputField inputField = componentsInChildren2[j];
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("_Value2").transform.childCount; k += 0)
		{
			if (GameObject.Find("_ScreenResolution").transform.GetChild(k).name == ".played")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("Fade").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		MapData mapData2 = mapData;
		IEnumerable<MapEvent> events = mapData.events;
		if (LevelEditorScene.LNIJKGECNME == null)
		{
			LevelEditorScene.LNIJKGECNME = new Func<MapEvent, float>(LevelEditorScene.ABCOEBPCAJI);
		}
		mapData2.events = events.OrderBy(LevelEditorScene.LNIJKGECNME).ToList<MapEvent>();
		mapData.checkpoints.Clear();
		for (int l = 1; l < GameObject.Find("gamemode").transform.childCount; l += 0)
		{
			if (GameObject.Find("_Value5").transform.GetChild(l).name == "ControllerLeftX")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("settings.enablehitsoundsinnormal").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = mapData;
		IEnumerable<float> checkpoints = mapData.checkpoints;
		if (LevelEditorScene.CLCBJCKCBDD == null)
		{
			LevelEditorScene.CLCBJCKCBDD = new Func<float, float>(LevelEditorScene.MMAGIMBKFLF);
		}
		mapData3.checkpoints = checkpoints.OrderBy(LevelEditorScene.CLCBJCKCBDD).ToList<float>();
		return mapData;
	}

	// Token: 0x060120F1 RID: 73969 RVA: 0x0063C94C File Offset: 0x0063AB4C
	private void DMFIBDCMPFN()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 1;
		using (List<string>.Enumerator enumerator = this.levelData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				LevelEditorScene.MIAMLCBDKHA miamlcbdkha = new LevelEditorScene.MIAMLCBDKHA();
				miamlcbdkha.IEOKJCPAOHL = enumerator.Current;
				miamlcbdkha.ADPIKBBAKHP = this;
				LevelEditorScene.OBBGBOKJGOD obbgbokjgod = new LevelEditorScene.OBBGBOKJGOD();
				obbgbokjgod.PPFPANGJGFI = miamlcbdkha;
				obbgbokjgod.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				obbgbokjgod.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				obbgbokjgod.OBFJPHLBFOL.transform.localScale = new Vector3(1409f, 261f, 276f);
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = miamlcbdkha.IEOKJCPAOHL;
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(obbgbokjgod.LLNDDFGPOPL));
				num++;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1885f, 1242f, 480f);
	}

	// Token: 0x060120F2 RID: 73970 RVA: 0x0063CB18 File Offset: 0x0063AD18
	public void SpeedUp()
	{
		this.asampler.audioSources[1].pitch += 0.25f;
		if (this.asampler.audioSources[1].pitch > 1f)
		{
			this.asampler.audioSources[1].pitch = 1f;
		}
	}

	// Token: 0x060120F3 RID: 73971 RVA: 0x0063CB82 File Offset: 0x0063AD82
	public void DKJKNIKMKJM()
	{
		base.StartCoroutine(this.AcceptLicence());
	}

	// Token: 0x060120F4 RID: 73972 RVA: 0x0063CB94 File Offset: 0x0063AD94
	public void PFALALKHPDI()
	{
		if (this.asampler.audioSources[1].isPlaying)
		{
			this.asampler.audioSources[1].Pause();
		}
		else if (this.asampler.audioSources[0].time < this.asampler.audioSources[1].clip.length)
		{
			this.asampler.audioSources[0].Play();
		}
		GameObject gameObject = GameObject.Find("Can not SetMasterClient(). Not in room or in offlineMode.");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (this.canvasGO.FindDeepChild("_DotSize"))
		{
			this.canvasGO.FindDeepChild("menutheme.hunter").GetComponentInChildren<Text>().text = ((!this.asampler.audioSources[0].isPlaying) ? "_TimeX" : ".b");
		}
		if (this.canvasGO.FindDeepChild("Internal LUT"))
		{
			this.canvasGO.FindDeepChild("StartButton").GetComponent<Image>().sprite = ((!this.asampler.audioSources[1].isPlaying) ? this.playImage : this.pauseImage);
		}
	}

	// Token: 0x060120F5 RID: 73973 RVA: 0x0063CCF8 File Offset: 0x0063AEF8
	public void OnLoadIconFile()
	{
		string result = GameObject.Find("IconFileSelector").GetComponent<FileSelector>().result;
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
		base.StartCoroutine(this.UpdateEditorLevelAssets(fullLevelPath, result, null, true, string.Empty));
	}

	// Token: 0x060120F6 RID: 73974 RVA: 0x0063CD48 File Offset: 0x0063AF48
	public void GEGNDGCPKJO(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			for (int i = 0; i < GameObject.Find("#pleasewait").transform.childCount; i += 0)
			{
				if (GameObject.Find("Object ID. Case-Sensitive").transform.GetChild(i).name == "<command>" && GameObject.Find("[Right-Down]").transform.GetChild(i).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find(" #").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0]) && GameObject.Find("_PColor2").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[1] == "_Value")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("_Value").transform.GetChild(i).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			for (int j = 0; j < GameObject.Find("AudioSampler").transform.childCount; j++)
			{
				if (GameObject.Find("CameraFilterPack/Colors_HUE_Rotate").transform.GetChild(j).name == "Failed to Instantiate prefab: " && GameObject.Find("' found!").transform.GetChild(j).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("Joystick1Button12").transform.GetChild(j).GetComponent<EditorEvent>().mapEvent.data[1]))
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("AVG Misses:").transform.GetChild(j).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 3)
		{
			for (int k = 1; k < GameObject.Find("_Value").transform.childCount; k += 0)
			{
				if (GameObject.Find("SetParticlesColor").transform.GetChild(k).name == "_Linecount")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("Tab1Content").transform.GetChild(k).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 4)
		{
			this.GEGNDGCPKJO(0);
			this.FFMLLIEPBAC(1);
			this.DeleteAll(7);
		}
		Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("\"", false);
	}

	// Token: 0x060120F7 RID: 73975 RVA: 0x0063CFC8 File Offset: 0x0063B1C8
	public void OGAGPHIMJLP()
	{
		GameObject gameObject = this.resourcesScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (MapResource mapResource in this.levelData.levelResources)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.resourcesElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "_ScreenResolution";
			gameObject2.transform.localScale = new Vector3(791f, 1063f, 676f);
			gameObject2.GetComponent<ResourceListElement>().Init(mapResource.name, mapResource.path, Singleton<MapsSystem>.Instance.GetMapData(this.mapID).resources[mapResource.name]);
		}
	}

	// Token: 0x060120F8 RID: 73976 RVA: 0x0063D0E0 File Offset: 0x0063B2E0
	public void OnEditedCustomEventFunction()
	{
		base.GetComponent<CustomEventEditor>().ChangeEventFunction(Helpers.GetAvailableEditorEvents(this.levelData.configVersion).Find(new Predicate<EditorEventFunctionInfo>(this.FEFNMJJHNPI)).id, this.KIDAPPHEPBE().GetComponent<EditorEvent>());
	}

	// Token: 0x060120F9 RID: 73977 RVA: 0x0063D120 File Offset: 0x0063B320
	public void Slowmo()
	{
		this.asampler.audioSources[1].pitch -= 0.25f;
		if (this.asampler.audioSources[1].pitch < 0.25f)
		{
			this.asampler.audioSources[1].pitch = 0.25f;
		}
	}

	// Token: 0x060120FA RID: 73978 RVA: 0x0063D18C File Offset: 0x0063B38C
	public void MLIMHHINNPE(EditorEvent NMMEBLCAECE)
	{
		GameObject gameObject = NMMEBLCAECE.gameObject;
		UnityEngine.Object.DestroyImmediate(gameObject);
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("VisionBlur", false);
	}

	// Token: 0x060120FB RID: 73979 RVA: 0x0063D1B8 File Offset: 0x0063B3B8
	public override void Update()
	{
		base.Update();
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			this.OnExitButton();
		}
		if (this.isLevelLoaded)
		{
			if (Singleton<MessageBoxPanel>.Instance.finished && !this.newLevelCanvas.activeSelf && !this.loadLevelCanvas.activeSelf && !this.resourcesCanvas.activeSelf && (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
			{
				if (Input.GetKeyDown(KeyCode.Z))
				{
					Singleton<EditorHistoryHandler>.Instance.Undo();
				}
				if (Input.GetKeyDown(KeyCode.Y))
				{
					Singleton<EditorHistoryHandler>.Instance.Redo();
				}
				if (Input.GetMouseButtonDown(2))
				{
					this.SetZoom(5f);
				}
			}
			if (Input.GetKeyDown(KeyCode.Tab))
			{
				this.SwichCanvas();
			}
			if (Singleton<MessageBoxPanel>.Instance.finished && !this.configCanvas.activeSelf && !this.newLevelCanvas.activeSelf && !this.loadLevelCanvas.activeSelf && !this.resourcesCanvas.activeSelf && (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					this.OnEventConfigButton();
				}
				if (!this.eventConfigCanvas.activeSelf)
				{
					if (Input.GetKeyDown(KeyCode.C))
					{
						base.GetComponent<CustomEventEditor>().CopyEvent();
					}
					if (Input.GetKeyDown(KeyCode.V))
					{
						base.GetComponent<CustomEventEditor>().PasteEvent();
					}
				}
			}
			if (!this.configCanvas.activeSelf && !this.newLevelCanvas.activeSelf && !this.loadLevelCanvas.activeSelf && !this.resourcesCanvas.activeSelf && Singleton<MessageBoxPanel>.Instance.finished && !base.GetComponent<CustomEventEditor>().isEditing)
			{
				if (Input.mouseScrollDelta.y != 0f)
				{
					if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
					{
						this.zoomSlider.GetComponent<Slider>().value -= Input.mouseScrollDelta.y * 0.2f;
					}
					else
					{
						this.JDJDHBFKFDG(-Input.mouseScrollDelta.y * Camera.main.orthographicSize * 0.2f);
					}
				}
				if (!this.isRecording && !base.GetComponent<CustomEventEditor>().isEditing)
				{
					if (Input.GetKey(KeyCode.LeftArrow))
					{
						this.JDJDHBFKFDG(-0.1f * Camera.main.orthographicSize);
					}
					if (Input.GetKey(KeyCode.RightArrow))
					{
						this.JDJDHBFKFDG(0.1f * Camera.main.orthographicSize);
					}
					if (Input.GetKey(KeyCode.UpArrow))
					{
						this.currentEventsCanvasId = 1;
					}
					if (Input.GetKey(KeyCode.DownArrow))
					{
						this.currentEventsCanvasId = 0;
					}
				}
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
						this.DeleteNearestEvent();
					}
					if (Input.GetKeyDown(KeyCode.G))
					{
						this.Slowmo();
					}
					if (Input.GetKeyDown(KeyCode.H))
					{
						this.SpeedUp();
					}
				}
			}
			if (this.eventConfigCanvas.activeSelf)
			{
				this.FindNearestEvent(false);
			}
			this.GOFEKGAKHON.GetComponent<Text>().text = this.asampler.audioSources[1].time.ToString("0.00");
			this.DLKGEPIOLDE.value = this.asampler.audioSources[1].time / Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicTime;
			this.HLNBBDEGLPJ.text = (this.configCanvas.activeSelf ? "HIDE CONFIG [Ctrl+E]" : "EVENT CONFIG [Ctrl+E]");
		}
		if (this.isUpdating)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(this.FHKGDJDOKNB, out num, out num2);
			float iadppjhimbg = num / num2;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Submition failed", "OK", null, true, false, 0f);
				this.isUpdating = false;
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
	}

	// Token: 0x060120FC RID: 73980 RVA: 0x0063D726 File Offset: 0x0063B926
	public void DHJCDEPOEKO()
	{
		base.StartCoroutine(this.OOHEBCFOOMB(false));
	}

	// Token: 0x060120FD RID: 73981 RVA: 0x0063D736 File Offset: 0x0063B936
	public void BHKDHOBFJMJ()
	{
		base.StartCoroutine(this.PopulateLevelsList());
	}

	// Token: 0x060120FE RID: 73982 RVA: 0x0063D745 File Offset: 0x0063B945
	public void CEOMOECOHMK()
	{
		base.StartCoroutine(this.GPAFHDODPJK());
	}

	// Token: 0x060120FF RID: 73983 RVA: 0x0063D754 File Offset: 0x0063B954
	private void PNGEGONPPOK(float EHHBHEJBHNG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.checkpoint);
		gameObject.transform.SetParent(GameObject.Find("Skipping EstablishEncryption. Protocol is secure.").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 489f, 952f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG, null);
		gameObject.name = "yes";
		Singleton<EditorHistoryHandler>.Instance.SaveState(": ", true);
	}

	// Token: 0x06012100 RID: 73984 RVA: 0x0063D7D0 File Offset: 0x0063B9D0
	public void JHGKNFJBKJD(bool OAKJLAFMOHO = false)
	{
		this.EditingEventGO = this.MCFAKMMIPNL();
		if ((this.EditingEventGO && OAKJLAFMOHO) || this.EditingEventGO != this.AEAKHCLJFDH)
		{
			base.GetComponent<CustomEventEditor>().EMPFNGALCGO(this.EditingEventGO.GetComponent<EditorEvent>());
			this.AEAKHCLJFDH = this.EditingEventGO;
		}
	}

	// Token: 0x06012101 RID: 73985 RVA: 0x0063D838 File Offset: 0x0063BA38
	private GameObject PEAFDKLCODL()
	{
		float num = float.PositiveInfinity;
		GameObject result = null;
		Transform transform = this.GNDCEMNKEEO.transform;
		for (int i = 0; i < GameObject.Find("BitsData").transform.childCount; i++)
		{
			GameObject gameObject = GameObject.Find("BitsData").transform.GetChild(i).gameObject;
			Vector3 position = gameObject.transform.position;
			float sqrMagnitude = (position - transform.position).sqrMagnitude;
			if (sqrMagnitude < num)
			{
				result = gameObject;
				num = sqrMagnitude;
			}
		}
		return result;
	}

	// Token: 0x06012102 RID: 73986 RVA: 0x0063D8D0 File Offset: 0x0063BAD0
	public IEnumerator OGHLPEDLDCA(string NCHEHDPLJBP)
	{
		this.mapID = NCHEHDPLJBP;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(NCHEHDPLJBP)));
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.isLevelLoaded = false;
		this.SetEditedData(this.levelData);
		this.isLevelLoaded = true;
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x06012103 RID: 73987 RVA: 0x0063D8F4 File Offset: 0x0063BAF4
	public void PNIOEINKMOF(EditorEvent NMMEBLCAECE)
	{
		GameObject gameObject = NMMEBLCAECE.gameObject;
		UnityEngine.Object.DestroyImmediate(gameObject);
		Singleton<EditorHistoryHandler>.Instance.SaveState("_BlurVector", true);
	}

	// Token: 0x06012104 RID: 73988 RVA: 0x0063D920 File Offset: 0x0063BB20
	public void KBLBNPJEODB(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		GameObject gameObject = GameObject.Find("SetPosition");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	// Token: 0x06012105 RID: 73989 RVA: 0x005053D3 File Offset: 0x005035D3
	[CompilerGenerated]
	private static float MMAGIMBKFLF(float HPHENPOHOMK)
	{
		return HPHENPOHOMK;
	}

	// Token: 0x06012106 RID: 73990 RVA: 0x0063D960 File Offset: 0x0063BB60
	public void MPHAHFNFHFN(MapData DNOPDNKBIFB)
	{
		try
		{
			Debug.Log(") error: " + Singleton<MapsSystem>.Instance.GPILFNKPAFH(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)) + "nogamesfound");
			this.configCanvas.transform.Find("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.").FindDeepChild("EventTimeInputField").GetComponent<InputField>().text = DNOPDNKBIFB.name;
			this.configCanvas.transform.Find(" room(s)").FindDeepChild("ItemNameBGImage").GetComponent<InputField>().text = this.levelData.info;
			this.configCanvas.transform.Find(".icon").FindDeepChild("_Value").GetComponent<InputField>().text = this.levelData.moreInfoURL;
			this.configCanvas.transform.Find("Value").FindDeepChild("Received your UserID from server. Updating local value to: {0}").GetComponent<Slider>().minValue = 689f;
			this.configCanvas.transform.Find("_Value8").FindDeepChild("New SaveGame").GetComponent<Slider>().maxValue = (float)MapData.GODJBCPCIME();
			this.configCanvas.transform.Find("_EmissionGain").FindDeepChild("a").GetComponent<Slider>().value = (float)this.levelData.configVersion;
			this.configCanvas.transform.Find("_MinVelocity").FindDeepChild("CameraFilterPack/FX_Spot").GetComponent<Slider>().value = (float)((int)this.levelData.speed);
			this.configCanvas.transform.Find("_Gamma").FindDeepChild("[MapEditor] Exported to ").GetComponent<Slider>().value = (float)this.levelData.lives;
			this.configCanvas.transform.Find("_ColorBuffer").FindDeepChild("[MapEditor] Loading map: ").GetComponent<Slider>().value = (float)this.levelData.maxLives;
			this.configCanvas.transform.Find("_DepthLevel").FindDeepChild("Error: Someone else(").GetComponent<Slider>().value = (float)this.levelData.handCount;
			this.configCanvas.transform.Find("_TimeX").FindDeepChild("_TimeX").GetComponent<Slider>().value = (float)this.levelData.environmentType;
			this.configCanvas.transform.Find("Operation failed: ").FindDeepChild("SetSatelliteLerpSpeed").GetComponent<Toggle>().isOn = this.levelData.hidden;
			GameObject gameObject = this.tagsScrollRectContent;
			for (int i = 1; i < gameObject.transform.childCount; i += 0)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			foreach (string text in Helpers.specialTags)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
				gameObject2.transform.SetParent(gameObject.transform);
				gameObject2.name = "_VignetteDesat";
				gameObject2.transform.localScale = new Vector3(1037f, 686f, 76f);
				gameObject2.GetComponent<Toggle>().isOn = this.levelData.tags.Contains(text);
				gameObject2.GetComponentInChildren<Text>().text = text;
			}
			if (Helpers.specialTags.Count > 1)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.tagHeaderElement);
				gameObject3.transform.SetParent(gameObject.transform);
				gameObject3.name = "': ";
				gameObject3.transform.localScale = new Vector3(877f, 397f, 842f);
				gameObject3.GetComponentInChildren<Text>().text = "RecieveChatMessage";
			}
			foreach (string text2 in Helpers.tags)
			{
				GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.tagElement);
				gameObject4.transform.SetParent(gameObject.transform);
				gameObject4.name = "_LightIntensity";
				gameObject4.transform.localScale = new Vector3(1234f, 551f, 718f);
				gameObject4.GetComponent<Toggle>().isOn = this.levelData.tags.Contains(text2);
				gameObject4.GetComponentInChildren<Text>().text = text2;
			}
			this.DBMOMMPLINJ();
			this.EKJFHLDHEAI();
			IEnumerator enumerator3 = GameObject.Find("Received RPC \"").transform.GetEnumerator();
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
			foreach (MapEvent mapEvent in this.levelData.events)
			{
				GameObject gameObject5;
				if (mapEvent.data.Count < 1)
				{
					gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.bit);
				}
				else
				{
					gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.customevent);
				}
				gameObject5.transform.SetParent(GameObject.Find("Joystick1Button7").transform);
				gameObject5.transform.localPosition = new Vector3(mapEvent.time, 462f, 389f);
				gameObject5.GetComponent<EditorEvent>().mapEvent = mapEvent;
				gameObject5.GetComponent<EditorEvent>().IOMBILLPGCF();
				gameObject5.name = ". This client's player: ";
			}
			foreach (float num in this.levelData.checkpoints)
			{
				float num2 = num;
				GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.checkpoint);
				gameObject6.transform.SetParent(GameObject.Find("_Alpha").transform);
				gameObject6.transform.localPosition = new Vector3(num2, 253f, 64f);
				gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(num2, null);
				gameObject6.GetComponent<EditorEvent>().BLEHBLOLPMF();
				gameObject6.name = "PenaltyScoreText";
			}
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = new MapData(DNOPDNKBIFB);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.ToString());
		}
		if (this.canvasGO.FindDeepChild("MapFolderInputField"))
		{
			this.canvasGO.FindDeepChild("Joystick1Button6").GetComponent<Button>().interactable = !base.GetComponent<EditorHistoryHandler>().MDKHEEKDHAH();
		}
		if (this.canvasGO.FindDeepChild("0.00"))
		{
			this.canvasGO.FindDeepChild("settings.shaders").GetComponent<Button>().interactable = !base.GetComponent<EditorHistoryHandler>().FHDANGEKFDG();
		}
	}

	// Token: 0x06012107 RID: 73991 RVA: 0x0063E150 File Offset: 0x0063C350
	private void NEAIMJMPCMN(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("CameraFilterPack/Color_Contrast");
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultNoConnection)
		{
			if (eResult != (EResult)(-91))
			{
				if (eResult == EResult.k_EResultAccountLockedDown)
				{
					Debug.Log("x");
				}
			}
			else
			{
				Debug.Log("_ScratchTex");
			}
		}
		else
		{
			Debug.Log("Mouse1");
		}
		if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
		}
		if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
		{
			Debug.Log("_ScreenResolution" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
			base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "Tab1Content" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), true));
			base.StartCoroutine(this.KGCHKEGFNHI(NPIKJHPJIEA.m_nPublishedFileId, "/music"));
		}
	}

	// Token: 0x06012108 RID: 73992 RVA: 0x0063E284 File Offset: 0x0063C484
	public void FJKCLCJOKOG(string NOJGGCLPPAM, int PGJECADBIOI)
	{
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount < 7)
		{
			if (NOJGGCLPPAM == "RULES")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[1].time, new List<string>
				{
					"Object ID. Case-Sensitive",
					Singleton<EditorKeyBindHandler>.Instance.up.OLDDPMNNCLG()
				});
			}
			if (NOJGGCLPPAM == " not exist")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[1].time, new List<string>
				{
					"CameraFilterPack/Color_Sepia",
					Singleton<EditorKeyBindHandler>.Instance.right.KPIMHLOCOHD()
				});
			}
			if (NOJGGCLPPAM == "_Value2")
			{
				this.NPBMJDPHHGD(this.asampler.audioSources[1].time, new List<string>
				{
					"_TimeX",
					Singleton<EditorKeyBindHandler>.Instance.down.HBPJJBALHDO()
				});
			}
			if (NOJGGCLPPAM == "Set Arcs Speed")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[0].time, new List<string>
				{
					"_FixDistance",
					Singleton<EditorKeyBindHandler>.Instance.left.FPBDGKKPPAE()
				});
			}
		}
		else
		{
			if (NOJGGCLPPAM == "_Fade")
			{
				this.NPBMJDPHHGD(this.asampler.audioSources[1].time, new List<string>
				{
					"CameraFilterPack/3D_Distortion",
					Singleton<EditorKeyBindHandler>.Instance.up.FAFMEBBDEHC() + "_Value3" + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "_Value4")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[1].time, new List<string>
				{
					"CameraFilterPack/FX_Hexagon",
					Singleton<EditorKeyBindHandler>.Instance.right.LBFLGCEFIMI() + "?" + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "turn")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[0].time, new List<string>
				{
					".",
					Singleton<EditorKeyBindHandler>.Instance.down.KPIMHLOCOHD() + "downloading" + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == ": ")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[0].time, new List<string>
				{
					"MenuScene",
					Singleton<EditorKeyBindHandler>.Instance.left.OLDDPMNNCLG() + "maps." + PGJECADBIOI
				});
			}
		}
	}

	// Token: 0x06012109 RID: 73993 RVA: 0x0063E590 File Offset: 0x0063C790
	public IEnumerator AcceptLicence()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", "RULES", null, "ALREADY SEEN", null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			string nbebmkfpbep = Singleton<GameManager>.Instance.CreateServerURL("/files/mods_terms.pdf");
			Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
		}
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Have you fully accept the terms?", "ACCEPT", null, "NO", null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<SaveSystem>.Instance.SetInt("player.licenceaccepted", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("player.licenceaccepted", 0, null);
			this.Exit();
		}
		yield break;
	}

	// Token: 0x0601210A RID: 73994 RVA: 0x0063E5AB File Offset: 0x0063C7AB
	public void AddNewUnlockCondition()
	{
		this.levelData.unlockConditions.Add(string.Empty);
		this.PLICILPAOJJ();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions", false);
	}

	// Token: 0x0601210B RID: 73995 RVA: 0x0063E5D8 File Offset: 0x0063C7D8
	public void NKOGPOAEACJ()
	{
		Time.timeScale = 540f;
		SceneManager.LoadScene("_BorderSize");
	}

	// Token: 0x0601210C RID: 73996 RVA: 0x0063E5EE File Offset: 0x0063C7EE
	public void Exit()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("MenuScene");
	}

	// Token: 0x0601210D RID: 73997 RVA: 0x0063E604 File Offset: 0x0063C804
	public void OnSaveButton()
	{
		base.StartCoroutine(this.Save(true));
	}

	// Token: 0x0601210E RID: 73998 RVA: 0x0063E614 File Offset: 0x0063C814
	private IEnumerator KGCHKEGFNHI(PublishedFileId_t JMMILEFMACB, string GIGBCMLIKKE)
	{
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
		string haebghhmebh = fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(haebghhmebh, true));
		Debug.Log("[LevelEditorScene] Updated");
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updated!", "OK", null, true, false, 0f);
		UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate((AppId_t)513510U, JMMILEFMACB);
		SteamUGC.SetItemTitle(ugcupdateHandle_t, this.levelData.name);
		SteamUGC.SetItemDescription(ugcupdateHandle_t, this.levelData.info);
		SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
		SteamUGC.SetItemContent(ugcupdateHandle_t, fullLevelPath);
		SteamUGC.SetItemPreview(ugcupdateHandle_t, fullLevelPath + "/" + this.levelData.iconFile);
		List<string> tags = this.levelData.tags;
		SteamUGC.SetItemTags(ugcupdateHandle_t, tags);
		SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, GIGBCMLIKKE);
		this.FHKGDJDOKNB = ugcupdateHandle_t;
		this.isUpdating = true;
		this.KAPDFIOHNGL.Set(hAPICall, null);
		yield break;
	}

	// Token: 0x0601210F RID: 73999 RVA: 0x0063E63D File Offset: 0x0063C83D
	public void ONOHBNEBIOH()
	{
		base.GetComponent<CustomEventEditor>().CBGMCLCNLAA(Helpers.GetAvailableEditorEvents(this.levelData.configVersion).Find(new Predicate<EditorEventFunctionInfo>(this.FEFNMJJHNPI)).id, this.IGCLAMDFEPE().GetComponent<EditorEvent>());
	}

	// Token: 0x06012110 RID: 74000 RVA: 0x0063E67B File Offset: 0x0063C87B
	[CompilerGenerated]
	private bool FEFNMJJHNPI(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.eventConfigCanvas.transform.Find("EventData0DropDownList").GetComponent<DropDownList>().SelectedItem.ID;
	}

	// Token: 0x06012111 RID: 74001 RVA: 0x0063E6AC File Offset: 0x0063C8AC
	public void FindNearestEvent(bool OAKJLAFMOHO = false)
	{
		this.EditingEventGO = this.KIDAPPHEPBE();
		if ((this.EditingEventGO && OAKJLAFMOHO) || this.EditingEventGO != this.AEAKHCLJFDH)
		{
			base.GetComponent<CustomEventEditor>().Load(this.EditingEventGO.GetComponent<EditorEvent>());
			this.AEAKHCLJFDH = this.EditingEventGO;
		}
	}

	// Token: 0x06012112 RID: 74002 RVA: 0x0063E714 File Offset: 0x0063C914
	private IEnumerator LDEADFCHJNJ()
	{
		Debug.Log("[MapEditor] Loading map: " + this.mapID);
		this.isLevelLoaded = false;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		this.levelData = new MapData(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		yield return base.StartCoroutine(this.JINABPAAGGF());
		this.RebuildGridAndCaret();
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.SetEditedData(this.levelData);
		base.StartCoroutine(this.NLIGGKFCFNM());
		Singleton<EditorHistoryHandler>.Instance.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", false);
		this.asampler.audioSources[1].Play();
		yield return new WaitForFixedUpdate();
		this.asampler.audioSources[1].Pause();
		this.ScrollTo(0f);
		this.isLevelLoaded = true;
		this.OnLoaded.Invoke();
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("GenerationMenu"))
		{
			this.canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x06012113 RID: 74003 RVA: 0x0063E730 File Offset: 0x0063C930
	public IEnumerator ALLBJHBPMOI(bool DICJGPOLHPK = true)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Please wait..", string.Empty, null, false, false, 0f);
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = this.GetEditedData();
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevel(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)), Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath, FullMapData.MapSource.Editor));
		Debug.Log("[LevelEditorScene] Exported to " + fullLevelPath);
		this.LKJCIHOKJHC = Singleton<EditorHistoryHandler>.Instance.state;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null, true, false, 0f);
		yield break;
	}

	// Token: 0x06012114 RID: 74004 RVA: 0x0063E74C File Offset: 0x0063C94C
	private IEnumerator OECGEKPJPCB()
	{
		string text = this.canvasGO.FindDeepChild("LevelFolderInputField").GetComponent<InputField>().text;
		string result = this.canvasGO.FindDeepChild("IconFileSelector").GetComponent<FileSelector>().result;
		string result2 = this.canvasGO.FindDeepChild("MusicFileSelector").GetComponent<FileSelector>().result;
		if (!new DirectoryInfo(Helpers.GetDirectory("Editor/" + text)).Exists)
		{
			Helpers.DirectoryCopy(Helpers.GetDirectory("Data/Editor/leveltemplate"), Helpers.GetDirectory("Editor/" + text), true);
			Singleton<MapsSystem>.Instance.DeleteLevelSave(text);
			Helpers.ObtainAchievement(10);
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(text, Helpers.GetDirectory("Editor/" + text), FullMapData.MapSource.Editor));
			this.mapID = "editor." + text;
			base.StartCoroutine(this.UpdateEditorLevelAssets(Helpers.GetDirectory("Editor/" + text), result, result2, true, text));
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Already exist!", "OK", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06012115 RID: 74005 RVA: 0x0063E768 File Offset: 0x0063C968
	private GameObject MELLDGJANJD()
	{
		float num = 822f;
		GameObject result = null;
		Transform transform = this.GNDCEMNKEEO.transform;
		for (int i = 0; i < GameObject.Find("_ScreenResolution").transform.childCount; i += 0)
		{
			GameObject gameObject = GameObject.Find("Image_").transform.GetChild(i).gameObject;
			Vector3 position = gameObject.transform.position;
			float sqrMagnitude = (position - transform.position).sqrMagnitude;
			if (sqrMagnitude < num)
			{
				result = gameObject;
				num = sqrMagnitude;
			}
		}
		return result;
	}

	// Token: 0x06012117 RID: 74007 RVA: 0x0063E812 File Offset: 0x0063CA12
	public void OnAboutButton()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Maps Editor v." + Helpers.GetGameVersion() + "\nCreated by Oxy949", "OK", null, true, false, 0f);
	}

	// Token: 0x06012118 RID: 74008 RVA: 0x0063E83F File Offset: 0x0063CA3F
	public void OpenMap(string NCHEHDPLJBP)
	{
		this.mapID = NCHEHDPLJBP;
		base.StartCoroutine(this.APFOMADCGBO());
	}

	// Token: 0x06012119 RID: 74009 RVA: 0x0063E858 File Offset: 0x0063CA58
	private void CDMLDMMIOND(float DPNHODJHGJL)
	{
		if (DPNHODJHGJL < 1339f)
		{
			if (this.asampler.audioSources[1].time + DPNHODJHGJL >= 437f)
			{
				this.asampler.audioSources[0].time += DPNHODJHGJL;
			}
			else
			{
				this.asampler.audioSources[1].time = 1883f;
			}
		}
		if (DPNHODJHGJL > 719f)
		{
			if (this.asampler.audioSources[0].time + DPNHODJHGJL <= this.asampler.audioSources[0].clip.length - 1395f)
			{
				this.asampler.audioSources[1].time += DPNHODJHGJL;
			}
			else
			{
				this.asampler.audioSources[0].time = this.asampler.audioSources[1].clip.length - 30f;
				this.asampler.audioSources[0].Pause();
			}
		}
	}

	// Token: 0x0601211A RID: 74010 RVA: 0x0063E989 File Offset: 0x0063CB89
	public void NGBELMCMDMB()
	{
		this.resourcesCanvas.SetActive(true);
		this.configCanvas.SetActive(true);
		this.FindNearestEvent(false);
		this.eventConfigCanvas.SetActive(!this.eventConfigCanvas.activeSelf);
	}

	// Token: 0x0601211B RID: 74011 RVA: 0x0063E9C4 File Offset: 0x0063CBC4
	public void OKKHKADGHPH(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		GameObject gameObject = GameObject.Find("?");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	// Token: 0x0601211C RID: 74012 RVA: 0x0063EA04 File Offset: 0x0063CC04
	private IEnumerator HJKAPDNEFKO()
	{
		Debug.Log("[MapEditor] Loading map: " + this.mapID);
		this.isLevelLoaded = false;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		this.levelData = new MapData(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		yield return base.StartCoroutine(this.JINABPAAGGF());
		this.RebuildGridAndCaret();
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.SetEditedData(this.levelData);
		base.StartCoroutine(this.NLIGGKFCFNM());
		Singleton<EditorHistoryHandler>.Instance.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", false);
		this.asampler.audioSources[1].Play();
		yield return new WaitForFixedUpdate();
		this.asampler.audioSources[1].Pause();
		this.ScrollTo(0f);
		this.isLevelLoaded = true;
		this.OnLoaded.Invoke();
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("GenerationMenu"))
		{
			this.canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x0601211D RID: 74013 RVA: 0x0063EA20 File Offset: 0x0063CC20
	public MapData CDDLMMAOLPM()
	{
		MapData mapData = new MapData(this.levelData);
		mapData.name = this.configCanvas.transform.Find("CameraFilterPack/Distortion_Flag").Find("Populate Mesh Data").GetComponent<InputField>().text;
		mapData.info = this.configCanvas.transform.Find("workshop.").Find("float,1").GetComponent<InputField>().text;
		mapData.moreInfoURL = this.configCanvas.transform.Find("Create failed on GameServer. Changing back to MasterServer. Msg: ").Find("SetSatelliteRadius").GetComponent<InputField>().text;
		mapData.speed = (float)((int)this.configCanvas.transform.Find("Please attach component to a Graphical UI component").Find("GroupNameText").GetComponent<Slider>().value);
		mapData.configVersion = (int)this.configCanvas.transform.Find("GroupNameText").FindDeepChild("_MainTex2").GetComponent<Slider>().value;
		mapData.lives = (int)this.configCanvas.transform.Find(": ").Find(".lastCheckpoint.bgcolor").GetComponent<Slider>().value;
		mapData.maxLives = (int)this.configCanvas.transform.Find("_ScreenResolution").Find("_PColor2").GetComponent<Slider>().value;
		mapData.handCount = (int)this.configCanvas.transform.Find("_Value3").Find("_Value").GetComponent<Slider>().value;
		mapData.environmentType = (int)this.configCanvas.transform.Find("EventMenu").Find(". Client should be in a room. Current connectionStateDetailed: ").GetComponent<Slider>().value;
		mapData.hidden = this.configCanvas.transform.Find("EditMenu").Find("curScn").GetComponent<Toggle>().isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip != null)) ? 1538f : Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		foreach (Toggle toggle in gameObject.GetComponentsInChildren<Toggle>())
		{
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 0)
		{
			mapData.tags.Add("file://");
		}
		else if (mapData.handCount == 1)
		{
			mapData.tags.Add("_Offsets");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		foreach (InputField inputField in gameObject.GetComponentsInChildren<InputField>())
		{
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("Joystick1Button5").transform.childCount; k++)
		{
			if (GameObject.Find("CameraFilterPack/Blend2Camera_LighterColor").transform.GetChild(k).name == "Missing shader for image effect {0}")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("RestartButton").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		MapData mapData2 = mapData;
		IEnumerable<MapEvent> events = mapData.events;
		if (LevelEditorScene.LNIJKGECNME == null)
		{
			LevelEditorScene.LNIJKGECNME = new Func<MapEvent, float>(LevelEditorScene.ABCOEBPCAJI);
		}
		mapData2.events = events.OrderBy(LevelEditorScene.LNIJKGECNME).ToList<MapEvent>();
		mapData.checkpoints.Clear();
		for (int l = 0; l < GameObject.Find("_Amount").transform.childCount; l++)
		{
			if (GameObject.Find("BitsData").transform.GetChild(l).name == "MenuScene")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("Brightness").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = mapData;
		IEnumerable<float> checkpoints = mapData.checkpoints;
		if (LevelEditorScene.CLCBJCKCBDD == null)
		{
			LevelEditorScene.CLCBJCKCBDD = new Func<float, float>(LevelEditorScene.MMAGIMBKFLF);
		}
		mapData3.checkpoints = checkpoints.OrderBy(LevelEditorScene.CLCBJCKCBDD).ToList<float>();
		return mapData;
	}

	// Token: 0x0601211E RID: 74014 RVA: 0x0063EEF4 File Offset: 0x0063D0F4
	public void OJJNBHDLLDL()
	{
		Singleton<GameManager>.Instance.GIBBJCCHOOJ(Singleton<GameManager>.Instance.CreateServerURL("_MainTex2"), true);
	}

	// Token: 0x0601211F RID: 74015 RVA: 0x0063EF10 File Offset: 0x0063D110
	private void DBMOMMPLINJ()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		using (List<string>.Enumerator enumerator = this.levelData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				LevelEditorScene.MIAMLCBDKHA miamlcbdkha = new LevelEditorScene.MIAMLCBDKHA();
				miamlcbdkha.IEOKJCPAOHL = enumerator.Current;
				miamlcbdkha.ADPIKBBAKHP = this;
				LevelEditorScene.OBBGBOKJGOD obbgbokjgod = new LevelEditorScene.OBBGBOKJGOD();
				obbgbokjgod.PPFPANGJGFI = miamlcbdkha;
				obbgbokjgod.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				obbgbokjgod.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				obbgbokjgod.OBFJPHLBFOL.transform.localScale = new Vector3(1688f, 347f, 1131f);
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = miamlcbdkha.IEOKJCPAOHL;
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(obbgbokjgod.OLIGLEMPFOP));
				num += 0;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1146f, 1982f, 58f);
	}

	// Token: 0x06012120 RID: 74016 RVA: 0x0063F0DC File Offset: 0x0063D2DC
	public void DOFBBDJCFML()
	{
		string nbebmkfpbep = "_Threshold";
		Singleton<GameManager>.Instance.IKDPMOJKILD(nbebmkfpbep, true);
	}

	// Token: 0x06012121 RID: 74017 RVA: 0x0063F0FB File Offset: 0x0063D2FB
	public void OnEventConfigButton()
	{
		this.resourcesCanvas.SetActive(false);
		this.configCanvas.SetActive(false);
		this.FindNearestEvent(true);
		this.eventConfigCanvas.SetActive(!this.eventConfigCanvas.activeSelf);
	}

	// Token: 0x06012122 RID: 74018 RVA: 0x0063E604 File Offset: 0x0063C804
	public void OKCLHAGEGKN()
	{
		base.StartCoroutine(this.Save(true));
	}

	// Token: 0x06012123 RID: 74019 RVA: 0x0063F138 File Offset: 0x0063D338
	private void EOPEBLJJBFM(float EHHBHEJBHNG)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.checkpoint);
		gameObject.transform.SetParent(GameObject.Find("BitsData").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 0f, 0f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG, null);
		gameObject.name = "checkpoint";
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added checkpoint", false);
	}

	// Token: 0x06012124 RID: 74020 RVA: 0x0063F1B4 File Offset: 0x0063D3B4
	public IEnumerator DONJCANCFMG(string NCHEHDPLJBP)
	{
		this.mapID = NCHEHDPLJBP;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(NCHEHDPLJBP)));
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.isLevelLoaded = false;
		this.SetEditedData(this.levelData);
		this.isLevelLoaded = true;
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x06012125 RID: 74021 RVA: 0x0063F1D8 File Offset: 0x0063D3D8
	private IEnumerator JINABPAAGGF()
	{
		string fullName = new FileInfo(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, true, true));
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip)
		{
			Debug.Log("[MapEditor] Loaded music file: " + fullName);
			this.levelData.musicTime = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length;
			if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip)
			{
				yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
				AudioClip clip = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip;
				if (clip != null)
				{
					float length = clip.length;
					this.canvasGO.FindDeepChild("CurrentTimeLabel").GetComponent<Text>().text = "0.00";
					this.canvasGO.FindDeepChild("TotalTimeLabel").GetComponent<Text>().text = string.Empty + length.ToString("0.00");
					this.asampler.Init(clip, 0f, false);
					this.asampler.audioSources[1].loop = true;
				}
			}
		}
		yield break;
	}

	// Token: 0x06012126 RID: 74022 RVA: 0x0063E83F File Offset: 0x0063CA3F
	public void EBAGFEDOKHD(string NCHEHDPLJBP)
	{
		this.mapID = NCHEHDPLJBP;
		base.StartCoroutine(this.APFOMADCGBO());
	}

	// Token: 0x06012127 RID: 74023 RVA: 0x0063F1F4 File Offset: 0x0063D3F4
	public IEnumerator GPAFHDODPJK()
	{
		this.newLevelCanvas.SetActive(false);
		this.loadLevelCanvas.SetActive(true);
		GameObject gameObject = this.levelsSelectorListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		foreach (string text in Singleton<MapsSystem>.Instance.levelsData.Keys)
		{
			FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
			if (fullMapData.source == FullMapData.MapSource.Editor)
			{
				Singleton<MapsSystem>.Instance.LoadLevel(text, false);
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.loadLevelElement, Vector3.zero, Quaternion.identity);
				num++;
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<LevelsSelectorListElement>().levelid = text;
				gameObject2.transform.Find("NameText").GetComponent<Text>().text = string.Concat(new string[]
				{
					text,
					" [",
					fullMapData.mapData.name,
					"]",
					(!string.IsNullOrEmpty(fullMapData.workshopId)) ? (" - PUBLISHED #" + fullMapData.workshopId) : " - LOCAL"
				});
				if (gameObject2.transform.Find("IconImage"))
				{
					if (fullMapData.icon != null)
					{
						gameObject2.transform.Find("IconImage").GetComponent<Image>().sprite = fullMapData.icon;
					}
					else
					{
						base.StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(gameObject2.transform.Find("IconImage").GetComponent<Image>(), fullMapData));
					}
				}
			}
		}
		if (num == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.listMessageElement, Vector3.zero, Quaternion.identity);
			num++;
			gameObject3.transform.SetParent(gameObject.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.transform.Find("MessageText").GetComponent<Text>().text = "MAPS NOT FOUND";
			yield break;
		}
		yield break;
	}

	// Token: 0x06012128 RID: 74024 RVA: 0x0063D736 File Offset: 0x0063B936
	public void OnLoadLevelButton()
	{
		base.StartCoroutine(this.PopulateLevelsList());
	}

	// Token: 0x06012129 RID: 74025 RVA: 0x0063F210 File Offset: 0x0063D410
	public IEnumerator PopulateLevelsList()
	{
		this.newLevelCanvas.SetActive(false);
		this.loadLevelCanvas.SetActive(true);
		gameObject = this.levelsSelectorListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		num = 0;
		enumerator = Singleton<MapsSystem>.Instance.levelsData.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string text = enumerator.Current;
				FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
				if (fullMapData.source == FullMapData.MapSource.Editor)
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.loadLevelElement, Vector3.zero, Quaternion.identity);
					num++;
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					gameObject2.GetComponent<LevelsSelectorListElement>().levelid = text;
					gameObject2.transform.Find("NameText").GetComponent<Text>().text = string.Concat(new string[]
					{
						text,
						" [",
						fullMapData.mapData.name,
						"]",
						(!string.IsNullOrEmpty(fullMapData.workshopId)) ? (" - PUBLISHED #" + fullMapData.workshopId) : " - LOCAL"
					});
					if (gameObject2.transform.Find("IconImage"))
					{
						if (fullMapData.icon != null)
						{
							gameObject2.transform.Find("IconImage").GetComponent<Image>().sprite = fullMapData.icon;
						}
						else
						{
							base.StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(gameObject2.transform.Find("IconImage").GetComponent<Image>(), fullMapData));
						}
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		if (num == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.listMessageElement, Vector3.zero, Quaternion.identity);
			num++;
			gameObject3.transform.SetParent(gameObject.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.transform.Find("MessageText").GetComponent<Text>().text = "MAPS NOT FOUND";
			yield break;
		}
		yield break;
	}

	// Token: 0x0601212A RID: 74026 RVA: 0x0063F22C File Offset: 0x0063D42C
	public override void Start()
	{
		base.Start();
		base.ShowCursor(true);
		this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.PFIPOJIIODP));
		this.KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.BMDDFOKBIAK));
		this.OnLoaded.Invoke();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Maps Editor", "Creating awesome map", null, null, 0, 0);
		if (this.canvasGO.FindDeepChild("CurrentTimeLabel"))
		{
			this.GOFEKGAKHON = this.canvasGO.FindDeepChild("CurrentTimeLabel").GetComponent<Text>();
		}
		if (this.canvasGO.FindDeepChild("TimeBGSlider"))
		{
			this.DLKGEPIOLDE = this.canvasGO.FindDeepChild("TimeBGSlider").GetComponent<Slider>();
		}
		if (this.canvasGO.FindDeepChild("EventConfigButton"))
		{
			this.HLNBBDEGLPJ = this.canvasGO.FindDeepChild("EventConfigButton").GetComponentInChildren<Text>();
		}
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("GenerationMenu"))
		{
			this.canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		this.CheckLicence();
	}

	// Token: 0x0601212B RID: 74027 RVA: 0x0063F4D4 File Offset: 0x0063D6D4
	public void RemoveEvent(EditorEvent NMMEBLCAECE)
	{
		GameObject gameObject = NMMEBLCAECE.gameObject;
		UnityEngine.Object.DestroyImmediate(gameObject);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Deleted event", false);
	}

	// Token: 0x0601212C RID: 74028 RVA: 0x0063F500 File Offset: 0x0063D700
	public void ToggleRecord()
	{
		this.isRecording = !this.isRecording;
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (this.canvasGO.FindDeepChild("MenuRecordButton"))
		{
			this.canvasGO.FindDeepChild("MenuRecordButton").GetComponentInChildren<Text>().text = (this.isRecording ? "STOP [R]" : "RECORD [R]");
		}
		if (this.canvasGO.FindDeepChild("RecordButton"))
		{
			ColorBlock colors = this.canvasGO.FindDeepChild("RecordButton").GetComponent<Button>().colors;
			colors.normalColor = (this.isRecording ? Color.red : Color.black);
			colors.highlightedColor = Helpers.HexToColor("#8E8E8EFF");
			colors.disabledColor = Color.black;
			colors.pressedColor = Helpers.HexToColor("#C8C8C8FF");
			this.canvasGO.FindDeepChild("RecordButton").GetComponent<Button>().colors = colors;
		}
	}

	// Token: 0x0601212D RID: 74029 RVA: 0x0063F620 File Offset: 0x0063D820
	private IEnumerator BGBGOAJODHM()
	{
		this.asampler.audioSources[0].Play();
		yield return new WaitWhile(new Func<bool>(base.GBKBDKHPLKG));
		Time.timeScale = 3f;
		Debug.Log("[LevelEditorScene] Print Audio Wave: Start");
		foreach (GameObject gameObject in this.soundWavesCanvas)
		{
			IEnumerator enumerator2 = gameObject.transform.GetEnumerator();
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
		while (this.asampler.audioSources[0].isPlaying)
		{
			float num = this.asampler.GetFrequencyVol(0, FrequencyRange.Decibal) * 50f;
			foreach (GameObject gameObject2 in this.soundWavesCanvas)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.soundWaveElement.gameObject, Vector3.zero, Quaternion.identity);
				gameObject3.transform.SetParent(gameObject2.transform, true);
				gameObject3.transform.localScale = new Vector3(1f, num * 20f, 1f);
				gameObject3.transform.localPosition = new Vector3(this.asampler.audioSources[0].time, 0f, 1f);
			}
			yield return new WaitForFixedUpdate();
		}
		Time.timeScale = 1f;
		Debug.Log("[LevelEditorScene] Print Audio Wave: Done");
		yield return true;
		yield break;
	}

	// Token: 0x0601212E RID: 74030 RVA: 0x0063F63C File Offset: 0x0063D83C
	public void DPFGBGDBBPP()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("workshop.", string.Empty, null, false, false, 1618f);
		string text = GameObject.Find("_ScreenResolution").GetComponent<InputField>().text;
		string result = GameObject.Find("_Value5").GetComponent<FileSelector>().result;
		base.StartCoroutine(this.AddNewLevelResoure(text, result));
	}

	// Token: 0x0601212F RID: 74031 RVA: 0x0063F6A0 File Offset: 0x0063D8A0
	private IEnumerator APFOMADCGBO()
	{
		Debug.Log("[MapEditor] Loading map: " + this.mapID);
		this.isLevelLoaded = false;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		this.levelData = new MapData(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		yield return base.StartCoroutine(this.JINABPAAGGF());
		this.RebuildGridAndCaret();
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.SetEditedData(this.levelData);
		base.StartCoroutine(this.NLIGGKFCFNM());
		Singleton<EditorHistoryHandler>.Instance.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", false);
		this.asampler.audioSources[1].Play();
		yield return new WaitForFixedUpdate();
		this.asampler.audioSources[1].Pause();
		this.ScrollTo(0f);
		this.isLevelLoaded = true;
		this.OnLoaded.Invoke();
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("GenerationMenu"))
		{
			this.canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x06012130 RID: 74032 RVA: 0x0063F6BC File Offset: 0x0063D8BC
	public void SetEditedData(MapData DNOPDNKBIFB)
	{
		try
		{
			Debug.Log("[LevelEditorScene] Reloaded config for \"" + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)) + "\"");
			this.configCanvas.transform.Find("Tab1Content").FindDeepChild("LevelNameInputField").GetComponent<InputField>().text = DNOPDNKBIFB.name;
			this.configCanvas.transform.Find("Tab1Content").FindDeepChild("LevelInfoInputField").GetComponent<InputField>().text = this.levelData.info;
			this.configCanvas.transform.Find("Tab1Content").FindDeepChild("LevelURLInputField").GetComponent<InputField>().text = this.levelData.moreInfoURL;
			this.configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>().minValue = 1f;
			this.configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>().maxValue = (float)MapData.GetLastConfigVersion();
			this.configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>().value = (float)this.levelData.configVersion;
			this.configCanvas.transform.Find("Tab2Content").FindDeepChild("SpeedSlider").GetComponent<Slider>().value = (float)((int)this.levelData.speed);
			this.configCanvas.transform.Find("Tab2Content").FindDeepChild("LivesSlider").GetComponent<Slider>().value = (float)this.levelData.lives;
			this.configCanvas.transform.Find("Tab2Content").FindDeepChild("MaxLivesSlider").GetComponent<Slider>().value = (float)this.levelData.maxLives;
			this.configCanvas.transform.Find("Tab2Content").FindDeepChild("HandsCountSlider").GetComponent<Slider>().value = (float)this.levelData.handCount;
			this.configCanvas.transform.Find("Tab2Content").FindDeepChild("EnvironmentSlider").GetComponent<Slider>().value = (float)this.levelData.environmentType;
			this.configCanvas.transform.Find("Tab2Content").FindDeepChild("HiddenToggle").GetComponent<Toggle>().isOn = this.levelData.hidden;
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
				gameObject2.GetComponent<Toggle>().isOn = this.levelData.tags.Contains(text);
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
				gameObject4.GetComponent<Toggle>().isOn = this.levelData.tags.Contains(text2);
				gameObject4.GetComponentInChildren<Text>().text = text2;
			}
			this.PLICILPAOJJ();
			this.ReloadResList();
			IEnumerator enumerator3 = GameObject.Find("BitsData").transform.GetEnumerator();
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
			foreach (MapEvent mapEvent in this.levelData.events)
			{
				GameObject gameObject5;
				if (mapEvent.data.Count < 1)
				{
					gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.bit);
				}
				else
				{
					gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.customevent);
				}
				gameObject5.transform.SetParent(GameObject.Find("BitsData").transform);
				gameObject5.transform.localPosition = new Vector3(mapEvent.time, 0f, 0f);
				gameObject5.GetComponent<EditorEvent>().mapEvent = mapEvent;
				gameObject5.GetComponent<EditorEvent>().UpdateIcon();
				gameObject5.name = "event";
			}
			foreach (float num in this.levelData.checkpoints)
			{
				float num2 = num;
				GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.checkpoint);
				gameObject6.transform.SetParent(GameObject.Find("BitsData").transform);
				gameObject6.transform.localPosition = new Vector3(num2, 0f, 0f);
				gameObject6.GetComponent<EditorEvent>().mapEvent = new MapEvent(num2, null);
				gameObject6.GetComponent<EditorEvent>().UpdateIcon();
				gameObject6.name = "checkpoint";
			}
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = new MapData(DNOPDNKBIFB);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.ToString());
		}
		if (this.canvasGO.FindDeepChild("UndoButton"))
		{
			this.canvasGO.FindDeepChild("UndoButton").GetComponent<Button>().interactable = base.GetComponent<EditorHistoryHandler>().CanUndo();
		}
		if (this.canvasGO.FindDeepChild("RedoButton"))
		{
			this.canvasGO.FindDeepChild("RedoButton").GetComponent<Button>().interactable = base.GetComponent<EditorHistoryHandler>().CanRedo();
		}
	}

	// Token: 0x06012131 RID: 74033 RVA: 0x0063FEAC File Offset: 0x0063E0AC
	private void BKIDPJBBNGB(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("_Value2");
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != (EResult)(-127))
		{
			if (eResult != EResult.k_EResultServiceReadOnly)
			{
				if (eResult == (EResult)(-34))
				{
					Debug.Log("DPADHOR");
				}
			}
			else
			{
				Debug.Log("/");
			}
		}
		else
		{
			Debug.Log("Cant ask anyone else for PickupItem spawn times.");
		}
		if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
		}
		if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
		{
			Debug.Log("maps." + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
			base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "_Value2" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), false));
			base.StartCoroutine(this.HKKPIKPPDBL(NPIKJHPJIEA.m_nPublishedFileId, "_Near"));
		}
	}

	// Token: 0x06012132 RID: 74034 RVA: 0x0063FFE0 File Offset: 0x0063E1E0
	private void ONBJNLMBDPI(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.customevent);
		gameObject.transform.SetParent(GameObject.Find("BitsData").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 0f, 0f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		gameObject.GetComponent<EditorEvent>().UpdateIcon();
		gameObject.name = "event";
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added event", false);
	}

	// Token: 0x06012133 RID: 74035 RVA: 0x00640068 File Offset: 0x0063E268
	private void JDJDHBFKFDG(float DPNHODJHGJL)
	{
		if (DPNHODJHGJL < 0f)
		{
			if (this.asampler.audioSources[1].time + DPNHODJHGJL >= 0f)
			{
				this.asampler.audioSources[1].time += DPNHODJHGJL;
			}
			else
			{
				this.asampler.audioSources[1].time = 0f;
			}
		}
		if (DPNHODJHGJL > 0f)
		{
			if (this.asampler.audioSources[1].time + DPNHODJHGJL <= this.asampler.audioSources[1].clip.length - 0.001f)
			{
				this.asampler.audioSources[1].time += DPNHODJHGJL;
			}
			else
			{
				this.asampler.audioSources[1].time = this.asampler.audioSources[1].clip.length - 0.001f;
				this.asampler.audioSources[1].Pause();
			}
		}
	}

	// Token: 0x06012134 RID: 74036 RVA: 0x0064019C File Offset: 0x0063E39C
	public void KOCAFPPDKDP()
	{
		this.isRecording = !this.isRecording;
		GameObject gameObject = GameObject.Find("_VignetteCenter");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (this.canvasGO.FindDeepChild("PS Home"))
		{
			this.canvasGO.FindDeepChild("Object ID").GetComponentInChildren<Text>().text = (this.isRecording ? "inventory.selected." : "PopulateMapsList");
		}
		if (this.canvasGO.FindDeepChild("_Intervale"))
		{
			ColorBlock colors = this.canvasGO.FindDeepChild("_ScreenResolution").GetComponent<Button>().colors;
			colors.normalColor = (this.isRecording ? Color.red : Color.black);
			colors.highlightedColor = Helpers.HexToColor("Cant ask anyone else for PickupItem spawn times.");
			colors.disabledColor = Color.black;
			colors.pressedColor = Helpers.HexToColor("_Bullet_7");
			this.canvasGO.FindDeepChild("x").GetComponent<Button>().colors = colors;
		}
	}

	// Token: 0x06012135 RID: 74037 RVA: 0x006402BC File Offset: 0x0063E4BC
	public IEnumerator UpdateEditorLevelAssets(string NPJLPIHGLBI, string EAGJAOLHFGB, string FLMDNANCAAC, bool EAPDHEDHAAI = false, string NCHEHDPLJBP = "")
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", null, null, false, false, 0f);
		string text = NPJLPIHGLBI + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(text, true));
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
		if (!string.IsNullOrEmpty(EAGJAOLHFGB) && File.Exists(EAGJAOLHFGB))
		{
			FileInfo fileInfo = new FileInfo(EAGJAOLHFGB);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.iconFile);
			File.Copy(EAGJAOLHFGB, NPJLPIHGLBI + "/icon" + fileInfo.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.iconFile = "icon" + fileInfo.Extension;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(NPJLPIHGLBI + "/icon" + fileInfo.Extension, NPJLPIHGLBI + "/icon" + fileInfo.Extension, true, false));
			if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID) != null)
			{
				Singleton<MapsSystem>.Instance.GetMapData(this.mapID).icon = (Sprite)ResourcesManager.GetLoadedResource(NPJLPIHGLBI + "/icon" + fileInfo.Extension);
				base.StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(null, Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
			}
		}
		if (!string.IsNullOrEmpty(FLMDNANCAAC) && File.Exists(FLMDNANCAAC))
		{
			FileInfo fileInfo2 = new FileInfo(FLMDNANCAAC);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile);
			File.Copy(FLMDNANCAAC, NPJLPIHGLBI + "/music" + fileInfo2.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile = "music" + fileInfo2.Extension;
			float musicTime = 0f;
			string fullName = new FileInfo(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile).FullName;
			yield return base.StartCoroutine(Helpers.GetAudioLength(fullName, true));
			musicTime = Helpers.resultAudioLength;
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicTime = musicTime;
		}
		if (!string.IsNullOrEmpty(NCHEHDPLJBP))
		{
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.configVersion = MapData.GetLastConfigVersion();
		}
		string nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		Helpers.CheckDirectory(NPJLPIHGLBI);
		yield return base.StartCoroutine(Helpers.SaveFile(NPJLPIHGLBI + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		if (EAPDHEDHAAI)
		{
			base.StartCoroutine(this.KKDHPBOFIFH(NPJLPIHGLBI));
		}
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield break;
	}

	// Token: 0x06012136 RID: 74038 RVA: 0x006402FC File Offset: 0x0063E4FC
	public void SetHandsCount(float KPPBFKFOINB)
	{
		if (this.configCanvas.activeSelf)
		{
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount = (int)KPPBFKFOINB;
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited hands count", false);
		}
	}

	// Token: 0x06012137 RID: 74039 RVA: 0x0064033C File Offset: 0x0063E53C
	public void DCOMIJHOFOD(float EHHBHEJBHNG)
	{
		float num = EHHBHEJBHNG * this.asampler.audioSources[0].clip.length;
		if (num < 1445f)
		{
			num = 881f;
		}
		if (num >= this.asampler.audioSources[1].clip.length)
		{
			num = this.asampler.audioSources[1].clip.length - 610f;
			this.asampler.audioSources[1].Pause();
		}
		this.asampler.audioSources[1].time = num;
		GameObject gameObject = GameObject.Find("/");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
	}

	// Token: 0x06012138 RID: 74040 RVA: 0x00640400 File Offset: 0x0063E600
	public MapData GetEditedData()
	{
		MapData mapData = new MapData(this.levelData);
		mapData.name = this.configCanvas.transform.Find("Tab1Content").Find("LevelNameInputField").GetComponent<InputField>().text;
		mapData.info = this.configCanvas.transform.Find("Tab1Content").Find("LevelInfoInputField").GetComponent<InputField>().text;
		mapData.moreInfoURL = this.configCanvas.transform.Find("Tab1Content").Find("LevelURLInputField").GetComponent<InputField>().text;
		mapData.speed = (float)((int)this.configCanvas.transform.Find("Tab2Content").Find("SpeedSlider").GetComponent<Slider>().value);
		mapData.configVersion = (int)this.configCanvas.transform.Find("Tab1Content").FindDeepChild("ConfigVersionSlider").GetComponent<Slider>().value;
		mapData.lives = (int)this.configCanvas.transform.Find("Tab2Content").Find("LivesSlider").GetComponent<Slider>().value;
		mapData.maxLives = (int)this.configCanvas.transform.Find("Tab2Content").Find("MaxLivesSlider").GetComponent<Slider>().value;
		mapData.handCount = (int)this.configCanvas.transform.Find("Tab2Content").Find("HandsCountSlider").GetComponent<Slider>().value;
		mapData.environmentType = (int)this.configCanvas.transform.Find("Tab2Content").Find("EnvironmentSlider").GetComponent<Slider>().value;
		mapData.hidden = this.configCanvas.transform.Find("Tab2Content").Find("HiddenToggle").GetComponent<Toggle>().isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip != null)) ? 0f : Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		foreach (Toggle toggle in gameObject.GetComponentsInChildren<Toggle>())
		{
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 1)
		{
			mapData.tags.Add("OneHand");
		}
		else if (mapData.handCount == 2)
		{
			mapData.tags.Add("TwoHands");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		foreach (InputField inputField in gameObject.GetComponentsInChildren<InputField>())
		{
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("BitsData").transform.childCount; k++)
		{
			if (GameObject.Find("BitsData").transform.GetChild(k).name == "event")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("BitsData").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		MapData mapData2 = mapData;
		IEnumerable<MapEvent> events = mapData.events;
		if (LevelEditorScene.LNIJKGECNME == null)
		{
			LevelEditorScene.LNIJKGECNME = new Func<MapEvent, float>(LevelEditorScene.ABCOEBPCAJI);
		}
		mapData2.events = events.OrderBy(LevelEditorScene.LNIJKGECNME).ToList<MapEvent>();
		mapData.checkpoints.Clear();
		for (int l = 0; l < GameObject.Find("BitsData").transform.childCount; l++)
		{
			if (GameObject.Find("BitsData").transform.GetChild(l).name == "checkpoint")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("BitsData").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = mapData;
		IEnumerable<float> checkpoints = mapData.checkpoints;
		if (LevelEditorScene.CLCBJCKCBDD == null)
		{
			LevelEditorScene.CLCBJCKCBDD = new Func<float, float>(LevelEditorScene.MMAGIMBKFLF);
		}
		mapData3.checkpoints = checkpoints.OrderBy(LevelEditorScene.CLCBJCKCBDD).ToList<float>();
		return mapData;
	}

	// Token: 0x06012139 RID: 74041 RVA: 0x006408D4 File Offset: 0x0063EAD4
	public void OCCDNEAIHJJ()
	{
		this.configCanvas.SetActive(this.configCanvas.activeSelf);
		this.resourcesCanvas.SetActive(true);
	}

	// Token: 0x0601213A RID: 74042 RVA: 0x006408FB File Offset: 0x0063EAFB
	public void SwichCanvas()
	{
		this.currentEventsCanvasId = ((this.currentEventsCanvasId != 0) ? 0 : 1);
	}

	// Token: 0x0601213B RID: 74043 RVA: 0x00640918 File Offset: 0x0063EB18
	private IEnumerator NLIGGKFCFNM()
	{
		this.asampler.audioSources[0].Play();
		yield return new WaitWhile(new Func<bool>(base.GBKBDKHPLKG));
		Time.timeScale = 3f;
		Debug.Log("[LevelEditorScene] Print Audio Wave: Start");
		enumerator = this.soundWavesCanvas.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				GameObject gameObject = enumerator.Current;
				IEnumerator enumerator4 = gameObject.transform.GetEnumerator();
				try
				{
					while (enumerator4.MoveNext())
					{
						object obj = enumerator4.Current;
						Transform transform = (Transform)obj;
						UnityEngine.Object.Destroy(transform.gameObject);
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator4 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		while (this.asampler.audioSources[0].isPlaying)
		{
			num = this.asampler.GetFrequencyVol(0, FrequencyRange.Decibal) * 50f;
			enumerator3 = this.soundWavesCanvas.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					GameObject gameObject2 = enumerator3.Current;
					GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.soundWaveElement.gameObject, Vector3.zero, Quaternion.identity);
					gameObject3.transform.SetParent(gameObject2.transform, true);
					gameObject3.transform.localScale = new Vector3(1f, num * 20f, 1f);
					gameObject3.transform.localPosition = new Vector3(this.asampler.audioSources[0].time, 0f, 1f);
				}
			}
			finally
			{
				((IDisposable)enumerator3).Dispose();
			}
			yield return new WaitForFixedUpdate();
		}
		Time.timeScale = 1f;
		Debug.Log("[LevelEditorScene] Print Audio Wave: Done");
		yield return true;
		yield break;
	}

	// Token: 0x0601213C RID: 74044 RVA: 0x00640934 File Offset: 0x0063EB34
	public IEnumerator OOHEBCFOOMB(bool DICJGPOLHPK = true)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Please wait..", string.Empty, null, false, false, 0f);
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = this.GetEditedData();
		nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevel(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)), Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath, FullMapData.MapSource.Editor));
		Debug.Log("[LevelEditorScene] Exported to " + fullLevelPath);
		this.LKJCIHOKJHC = Singleton<EditorHistoryHandler>.Instance.state;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null, true, false, 0f);
		yield break;
	}

	// Token: 0x0601213D RID: 74045 RVA: 0x00640950 File Offset: 0x0063EB50
	public IEnumerator HGJPGMHFEJP()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Exit to menu?", "YES", null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			if (!this.isLevelLoaded)
			{
				this.Exit();
			}
			else
			{
				if (Singleton<EditorHistoryHandler>.Instance.state != this.LKJCIHOKJHC)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save the map before exiting?", "YES", null, "NO", null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						yield return base.StartCoroutine(this.Save(true));
					}
				}
				this.Exit();
			}
		}
		yield break;
	}

	// Token: 0x0601213E RID: 74046 RVA: 0x0064096C File Offset: 0x0063EB6C
	public IEnumerator SaveBeforeUpload()
	{
		if (Singleton<EditorHistoryHandler>.Instance.state != this.LKJCIHOKJHC)
		{
			yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save level before uploading?", "YES", null, "NO", null));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return base.StartCoroutine(this.Save(true));
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)) + ".completed", 0, null) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Creating new item...", "OK", null, false, false, 0f);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510U, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				Debug.Log("[LevelEditorScene] Creating new item...");
			}
			else
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Map already submited. Update?", "YES", null, "NO", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("Change Note:", "SUBMIT", null, null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						base.StartCoroutine(this.KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
					}
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("You must complete your map before submiting it to Workshop", "OK", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x0601213F RID: 74047 RVA: 0x00640988 File Offset: 0x0063EB88
	public void DeleteAll(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			for (int i = 0; i < GameObject.Find("BitsData").transform.childCount; i++)
			{
				if (GameObject.Find("BitsData").transform.GetChild(i).name == "event" && GameObject.Find("BitsData").transform.GetChild(i).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("BitsData").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0]) && GameObject.Find("BitsData").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0] == "SpawnObj")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("BitsData").transform.GetChild(i).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			for (int j = 0; j < GameObject.Find("BitsData").transform.childCount; j++)
			{
				if (GameObject.Find("BitsData").transform.GetChild(j).name == "event" && GameObject.Find("BitsData").transform.GetChild(j).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("BitsData").transform.GetChild(j).GetComponent<EditorEvent>().mapEvent.data[0]))
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("BitsData").transform.GetChild(j).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 2)
		{
			for (int k = 0; k < GameObject.Find("BitsData").transform.childCount; k++)
			{
				if (GameObject.Find("BitsData").transform.GetChild(k).name == "checkpoint")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("BitsData").transform.GetChild(k).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 3)
		{
			this.DeleteAll(0);
			this.DeleteAll(1);
			this.DeleteAll(2);
		}
		Singleton<EditorHistoryHandler>.Instance.SaveState("Deleted data", false);
	}

	// Token: 0x06012140 RID: 74048 RVA: 0x00640C08 File Offset: 0x0063EE08
	public void GJDJEBFAIDF(string NOJGGCLPPAM, int PGJECADBIOI)
	{
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount < 3)
		{
			if (NOJGGCLPPAM == "_TimeX")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[0].time, new List<string>
				{
					"CameraFilterPack/Drawing_Manga5",
					Singleton<EditorKeyBindHandler>.Instance.up.HHONKIBOOAG()
				});
			}
			if (NOJGGCLPPAM == "ChallengesButton")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[0].time, new List<string>
				{
					"_ScreenResolution",
					Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData()
				});
			}
			if (NOJGGCLPPAM == "Set Satellite Trail MinVertexDistance")
			{
				this.NPBMJDPHHGD(this.asampler.audioSources[0].time, new List<string>
				{
					"Remove Environment Object",
					Singleton<EditorKeyBindHandler>.Instance.down.KPIMHLOCOHD()
				});
			}
			if (NOJGGCLPPAM == ".jpg")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"bans.viewed.",
					Singleton<EditorKeyBindHandler>.Instance.left.GNPEIEBDFPB()
				});
			}
		}
		else
		{
			if (NOJGGCLPPAM == "BadgeText")
			{
				this.NPBMJDPHHGD(this.asampler.audioSources[0].time, new List<string>
				{
					"LastNewsButton",
					Singleton<EditorKeyBindHandler>.Instance.up.HDCJGCHLDJF() + "maps." + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "_MainTex2")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"UseFinalGlassColor",
					Singleton<EditorKeyBindHandler>.Instance.right.HBPJJBALHDO() + "CameraFilterPack/3D_Ghost" + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "_ScreenResolution")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[0].time, new List<string>
				{
					"_ColoredChange",
					Singleton<EditorKeyBindHandler>.Instance.down.PBICFJPONKP() + "CameraFilterPack_3D_Myst1" + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "_ScreenResolution")
			{
				this.BDCKICKJFNG(this.asampler.audioSources[0].time, new List<string>
				{
					"SetPlayerDistance",
					Singleton<EditorKeyBindHandler>.Instance.left.PBICFJPONKP() + "PUNCloudBestRegion" + PGJECADBIOI
				});
			}
		}
	}

	// Token: 0x06012141 RID: 74049 RVA: 0x00640F12 File Offset: 0x0063F112
	public void CheckLicence()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("player.licenceaccepted", null) || Singleton<SaveSystem>.Instance.GetInt("player.licenceaccepted", 0, null) == 0)
		{
			this.ShowAcceptLicence();
		}
	}

	// Token: 0x06012142 RID: 74050 RVA: 0x00640F48 File Offset: 0x0063F148
	public MapData PKNECGKHPGP()
	{
		MapData mapData = new MapData(this.levelData);
		mapData.name = this.configCanvas.transform.Find("_Speed").Find("yyyy-MM-dd HH:mm:ss").GetComponent<InputField>().text;
		mapData.info = this.configCanvas.transform.Find("Tab1Content").Find("&search=").GetComponent<InputField>().text;
		mapData.moreInfoURL = this.configCanvas.transform.Find("/").Find("[MapEditor] Updating top menu").GetComponent<InputField>().text;
		mapData.speed = (float)((int)this.configCanvas.transform.Find("MenuScene").Find("AddEnvironmentSprite").GetComponent<Slider>().value);
		mapData.configVersion = (int)this.configCanvas.transform.Find("...").FindDeepChild("_FrustumCornersWS").GetComponent<Slider>().value;
		mapData.lives = (int)this.configCanvas.transform.Find("menu.playedsolo").Find("resetach21").GetComponent<Slider>().value;
		mapData.maxLives = (int)this.configCanvas.transform.Find("ItemNameText").Find("value").GetComponent<Slider>().value;
		mapData.handCount = (int)this.configCanvas.transform.Find(".lastCheckpoint.incorrectScore").Find("_Blue_B").GetComponent<Slider>().value;
		mapData.environmentType = (int)this.configCanvas.transform.Find("value").Find("inventory.selected.").GetComponent<Slider>().value;
		mapData.hidden = this.configCanvas.transform.Find("CameraFilterPack/Blur_Steam").Find("settings.cameramovements").GetComponent<Toggle>().isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip != null)) ? 665f : Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Toggle toggle = componentsInChildren[i];
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 0)
		{
			mapData.tags.Add("_TimeX");
		}
		else if (mapData.handCount == 5)
		{
			mapData.tags.Add("CameraFilterPack/TV_CompressionFX");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		InputField[] componentsInChildren2 = gameObject.GetComponentsInChildren<InputField>();
		for (int j = 1; j < componentsInChildren2.Length; j++)
		{
			InputField inputField = componentsInChildren2[j];
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("_Value4").transform.childCount; k++)
		{
			if (GameObject.Find("_ScreenResolution").transform.GetChild(k).name == "_Distortion")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("Player").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		MapData mapData2 = mapData;
		IEnumerable<MapEvent> events = mapData.events;
		if (LevelEditorScene.LNIJKGECNME == null)
		{
			LevelEditorScene.LNIJKGECNME = new Func<MapEvent, float>(LevelEditorScene.NPCIOHKFMNP);
		}
		mapData2.events = events.OrderBy(LevelEditorScene.LNIJKGECNME).ToList<MapEvent>();
		mapData.checkpoints.Clear();
		for (int l = 1; l < GameObject.Find("Internal LUT").transform.childCount; l += 0)
		{
			if (GameObject.Find("_LightIntensity").transform.GetChild(l).name == "_Value2")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("{0}").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = mapData;
		IEnumerable<float> checkpoints = mapData.checkpoints;
		if (LevelEditorScene.CLCBJCKCBDD == null)
		{
			LevelEditorScene.CLCBJCKCBDD = new Func<float, float>(LevelEditorScene.DPBNOMBBAAC);
		}
		mapData3.checkpoints = checkpoints.OrderBy(LevelEditorScene.CLCBJCKCBDD).ToList<float>();
		return mapData;
	}

	// Token: 0x06012143 RID: 74051 RVA: 0x0064141C File Offset: 0x0063F61C
	public void OnApplyCustomEventButton(List<string> NKEHMBLLEMH)
	{
		if (this.EditingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = this.EditingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(this.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text, NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			this.EditingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			this.EditingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			this.EditingEventGO.GetComponent<EditorEvent>().UpdatePositionFromData();
			this.eventConfigCanvas.transform.Find("EventTimeInputField").GetComponent<InputField>().text = string.Empty + this.EditingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			((LevelEditorScene)Singleton<global::Scene>.Instance).FindNearestEvent(true);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited event", false);
		}
	}

	// Token: 0x06012144 RID: 74052 RVA: 0x00641520 File Offset: 0x0063F720
	public void OnAddButton(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
			{
				"SetPlayerDistance",
				"14"
			});
		}
		if (HMGBJCGOLMI == 1)
		{
			this.EOPEBLJJBFM(this.asampler.audioSources[1].time);
		}
	}

	// Token: 0x06012145 RID: 74053 RVA: 0x0064158F File Offset: 0x0063F78F
	public void OnResourcesButton()
	{
		this.resourcesCanvas.SetActive(!this.resourcesCanvas.activeSelf);
		this.configCanvas.SetActive(false);
	}

	// Token: 0x06012146 RID: 74054 RVA: 0x006415B8 File Offset: 0x0063F7B8
	public IEnumerator LoadLevel(string NCHEHDPLJBP)
	{
		this.mapID = NCHEHDPLJBP;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(NCHEHDPLJBP)));
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.isLevelLoaded = false;
		this.SetEditedData(this.levelData);
		this.isLevelLoaded = true;
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x06012147 RID: 74055 RVA: 0x006415DC File Offset: 0x0063F7DC
	private void PGFHCODCFOD(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("[LevelEditorScene] Creating new item...");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("BloodAlternative3", "inventory.selected.", null, true, false, 1430f);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultOK)
		{
			Singleton<MessageBoxPanel>.Instance.LKFALPEABHP("CameraFilterPack/Noise_TV", "/../", null, false, true, 1797f);
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<GameManager>.Instance.MKEGIDHHLIC("_Value" + NPIKJHPJIEA.m_nPublishedFileId, true);
			Debug.Log("EnvironmentSlider");
			Singleton<MessageBoxPanel>.Instance.LKFALPEABHP("x", "Set sun emission (glow)", null, true, true, 498f);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, false))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
				string text = fullLevelPath + "Tab1Content" + Helpers.levelConfigFileName;
			}
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		this.isUpdating = false;
	}

	// Token: 0x06012148 RID: 74056 RVA: 0x006416F4 File Offset: 0x0063F8F4
	public IEnumerator COLJDGCDKLE()
	{
		if (Singleton<EditorHistoryHandler>.Instance.state != this.LKJCIHOKJHC)
		{
			yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save level before uploading?", "YES", null, "NO", null));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return base.StartCoroutine(this.Save(true));
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)) + ".completed", 0, null) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Creating new item...", "OK", null, false, false, 0f);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510U, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				Debug.Log("[LevelEditorScene] Creating new item...");
			}
			else
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Map already submited. Update?", "YES", null, "NO", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("Change Note:", "SUBMIT", null, null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						base.StartCoroutine(this.KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
					}
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("You must complete your map before submiting it to Workshop", "OK", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06012149 RID: 74057 RVA: 0x005A9F54 File Offset: 0x005A8154
	[CompilerGenerated]
	private static float ABCOEBPCAJI(MapEvent HPHENPOHOMK)
	{
		return HPHENPOHOMK.time;
	}

	// Token: 0x0601214A RID: 74058 RVA: 0x00641710 File Offset: 0x0063F910
	public IEnumerator PJOHEJOKLGC(string NPJLPIHGLBI, string EAGJAOLHFGB, string FLMDNANCAAC, bool EAPDHEDHAAI = false, string NCHEHDPLJBP = "")
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", null, null, false, false, 0f);
		text = NPJLPIHGLBI + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(text, true));
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
		if (!string.IsNullOrEmpty(EAGJAOLHFGB) && File.Exists(EAGJAOLHFGB))
		{
			fileInfo = new FileInfo(EAGJAOLHFGB);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.iconFile);
			File.Copy(EAGJAOLHFGB, NPJLPIHGLBI + "/icon" + fileInfo.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.iconFile = "icon" + fileInfo.Extension;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(NPJLPIHGLBI + "/icon" + fileInfo.Extension, NPJLPIHGLBI + "/icon" + fileInfo.Extension, true, false));
			if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID) != null)
			{
				Singleton<MapsSystem>.Instance.GetMapData(this.mapID).icon = (Sprite)ResourcesManager.GetLoadedResource(NPJLPIHGLBI + "/icon" + fileInfo.Extension);
				base.StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(null, Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
			}
		}
		if (!string.IsNullOrEmpty(FLMDNANCAAC) && File.Exists(FLMDNANCAAC))
		{
			fileInfo2 = new FileInfo(FLMDNANCAAC);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile);
			File.Copy(FLMDNANCAAC, NPJLPIHGLBI + "/music" + fileInfo2.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile = "music" + fileInfo2.Extension;
			musicTime = 0f;
			fullName = new FileInfo(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile).FullName;
			yield return base.StartCoroutine(Helpers.GetAudioLength(fullName, true));
			musicTime = Helpers.resultAudioLength;
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicTime = musicTime;
		}
		if (!string.IsNullOrEmpty(NCHEHDPLJBP))
		{
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.configVersion = MapData.GetLastConfigVersion();
		}
		nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		Helpers.CheckDirectory(NPJLPIHGLBI);
		yield return base.StartCoroutine(Helpers.SaveFile(NPJLPIHGLBI + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		if (EAPDHEDHAAI)
		{
			base.StartCoroutine(this.KKDHPBOFIFH(NPJLPIHGLBI));
		}
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield break;
	}

	// Token: 0x0601214B RID: 74059 RVA: 0x00641750 File Offset: 0x0063F950
	public void SetZoom(float NINOJDGAAJA)
	{
		Camera.main.orthographicSize = NINOJDGAAJA;
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.zoomSlider.GetComponent<Slider>().value = NINOJDGAAJA;
	}

	// Token: 0x0601214C RID: 74060 RVA: 0x00641790 File Offset: 0x0063F990
	private IEnumerator CMAOIJOCOOG()
	{
		Debug.Log("[MapEditor] Loading map: " + this.mapID);
		this.isLevelLoaded = false;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		this.levelData = new MapData(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		yield return base.StartCoroutine(this.JINABPAAGGF());
		this.RebuildGridAndCaret();
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.SetEditedData(this.levelData);
		base.StartCoroutine(this.NLIGGKFCFNM());
		Singleton<EditorHistoryHandler>.Instance.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", false);
		this.asampler.audioSources[1].Play();
		yield return new WaitForFixedUpdate();
		this.asampler.audioSources[1].Pause();
		this.ScrollTo(0f);
		this.isLevelLoaded = true;
		this.OnLoaded.Invoke();
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("GenerationMenu"))
		{
			this.canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x0601214D RID: 74061 RVA: 0x006417AB File Offset: 0x0063F9AB
	public void EDGMCMLJMLO(float EFGFCMLOJJE)
	{
		this.DCOMIJHOFOD(EFGFCMLOJJE);
	}

	// Token: 0x0601214E RID: 74062 RVA: 0x006417B4 File Offset: 0x0063F9B4
	public void EKDIFNBGPMK()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.caret);
		gameObject.name = "mapselector.filter.favoriteonly";
		gameObject.transform.SetParent(Camera.main.gameObject.transform);
		gameObject.transform.localPosition = new Vector3(1475f, 554f, 1610f);
		this.GNDCEMNKEEO = gameObject;
		Transform transform = GameObject.Find("_DistCenterScale").transform;
		Transform transform2 = GameObject.Find("(?<=#)\\w+").transform;
		IEnumerator enumerator = transform.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform3 = (Transform)obj;
				UnityEngine.Object.Destroy(transform3.gameObject);
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
		IEnumerator enumerator2 = transform2.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				object obj2 = enumerator2.Current;
				Transform transform4 = (Transform)obj2;
				UnityEngine.Object.Destroy(transform4.gameObject);
			}
		}
		finally
		{
			IDisposable disposable2;
			if ((disposable2 = (enumerator2 as IDisposable)) != null)
			{
				disposable2.Dispose();
			}
		}
		int num = 1;
		while ((float)num < this.levelData.musicTime)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.grid);
			gameObject2.transform.SetParent(transform);
			gameObject2.transform.localPosition = new Vector3((float)num, 204f, 1556f);
			gameObject2.name = "anonymous";
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.grid);
			gameObject2.transform.SetParent(transform2);
			gameObject2.transform.localPosition = new Vector3((float)num, 125f, 949f);
			gameObject2.name = "LevelNameInputField";
			num++;
		}
	}

	// Token: 0x0601214F RID: 74063 RVA: 0x0064199C File Offset: 0x0063FB9C
	public void MINPEAMALAB()
	{
		this.configCanvas.SetActive(!this.configCanvas.activeSelf);
		this.resourcesCanvas.SetActive(false);
	}

	// Token: 0x06012150 RID: 74064 RVA: 0x006419C4 File Offset: 0x0063FBC4
	public void NGDDLPLEHHA(bool OAKJLAFMOHO = false)
	{
		this.EditingEventGO = this.MCFAKMMIPNL();
		if ((this.EditingEventGO && OAKJLAFMOHO) || this.EditingEventGO != this.AEAKHCLJFDH)
		{
			base.GetComponent<CustomEventEditor>().DOCDMFEOKAM(this.EditingEventGO.GetComponent<EditorEvent>());
			this.AEAKHCLJFDH = this.EditingEventGO;
		}
	}

	// Token: 0x06012151 RID: 74065 RVA: 0x00641A2B File Offset: 0x0063FC2B
	public void UploadToWorkshop()
	{
		base.StartCoroutine(this.SaveBeforeUpload());
	}

	// Token: 0x06012152 RID: 74066 RVA: 0x00641A3A File Offset: 0x0063FC3A
	public void JHFGHOOBAFN()
	{
		this.configCanvas.SetActive(!this.configCanvas.activeSelf);
		this.resourcesCanvas.SetActive(true);
	}

	// Token: 0x06012153 RID: 74067 RVA: 0x005053D3 File Offset: 0x005035D3
	private static float DPBNOMBBAAC(float HPHENPOHOMK)
	{
		return HPHENPOHOMK;
	}

	// Token: 0x06012154 RID: 74068 RVA: 0x00641A64 File Offset: 0x0063FC64
	public void SetTime(float EHHBHEJBHNG)
	{
		float num = EHHBHEJBHNG * this.asampler.audioSources[1].clip.length;
		if (num < 0f)
		{
			num = 0f;
		}
		if (num >= this.asampler.audioSources[1].clip.length)
		{
			num = this.asampler.audioSources[1].clip.length - 0.001f;
			this.asampler.audioSources[1].Pause();
		}
		this.asampler.audioSources[1].time = num;
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
	}

	// Token: 0x06012155 RID: 74069 RVA: 0x00641B27 File Offset: 0x0063FD27
	public void EODCCFHFINF(float KPPBFKFOINB)
	{
		if (this.configCanvas.activeSelf)
		{
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount = (int)KPPBFKFOINB;
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("_ScreenResolution", true);
		}
	}

	// Token: 0x06012156 RID: 74070 RVA: 0x00641B68 File Offset: 0x0063FD68
	private void DKLCCAOFAIN(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("_NeutralTonemapperParams1");
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultBlocked)
		{
			if (eResult != EResult.k_EResultRemoteDisconnect)
			{
				if (eResult == (EResult)(-3))
				{
					Debug.Log("_RgbTex");
				}
			}
			else
			{
				Debug.Log("ticket");
			}
		}
		else
		{
			Debug.Log("file://");
		}
		if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
		}
		if (NPIKJHPJIEA.m_eResult == (EResult)0)
		{
			Debug.Log("<b>Difficulty</b>:" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
			base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "_Value4" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), false));
			base.StartCoroutine(this.HKKPIKPPDBL(NPIKJHPJIEA.m_nPublishedFileId, "input"));
		}
	}

	// Token: 0x06012157 RID: 74071 RVA: 0x00641C9C File Offset: 0x0063FE9C
	public void JAJNCKHKAHD()
	{
		if (this.asampler.audioSources[1].isPlaying)
		{
			this.asampler.audioSources[1].Pause();
		}
		else if (this.asampler.audioSources[1].time < this.asampler.audioSources[0].clip.length)
		{
			this.asampler.audioSources[0].Play();
		}
		GameObject gameObject = GameObject.Find("_Value");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (this.canvasGO.FindDeepChild("' ping: "))
		{
			this.canvasGO.FindDeepChild("_TimeX").GetComponentInChildren<Text>().text = ((!this.asampler.audioSources[0].isPlaying) ? " : " : "RPC: 'OnAwakeRPC' Parameter: ");
		}
		if (this.canvasGO.FindDeepChild(" ownership transfered to: "))
		{
			this.canvasGO.FindDeepChild("_TimeX").GetComponent<Image>().sprite = ((!this.asampler.audioSources[0].isPlaying) ? this.playImage : this.pauseImage);
		}
	}

	// Token: 0x06012158 RID: 74072 RVA: 0x00641E00 File Offset: 0x00640000
	public void EHDLDFFCNCM()
	{
		Time.timeScale = 1474f;
		SceneManager.LoadScene("Edited event");
	}

	// Token: 0x06012159 RID: 74073 RVA: 0x00641E18 File Offset: 0x00640018
	private GameObject MEAFBILCPNH()
	{
		GameObject result = null;
		if (this.asampler.audioSources[1].clip != null)
		{
			float num = 402f;
			Transform transform = this.GNDCEMNKEEO.transform;
			for (int i = 0; i < GameObject.Find("Obtain test Item").transform.childCount; i += 0)
			{
				GameObject gameObject = GameObject.Find("#ok").transform.GetChild(i).gameObject;
				Vector3 position = gameObject.transform.position;
				float sqrMagnitude = (position - transform.position).sqrMagnitude;
				if (sqrMagnitude < num && gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
				{
					result = gameObject;
					num = sqrMagnitude;
				}
			}
		}
		return result;
	}

	// Token: 0x0601215A RID: 74074 RVA: 0x00641F08 File Offset: 0x00640108
	private void NPBMJDPHHGD(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.customevent);
		gameObject.transform.SetParent(GameObject.Find("z").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 1853f, 1107f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		gameObject.GetComponent<EditorEvent>().FOLDDNELMIO();
		gameObject.name = "|";
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("Horizontal", false);
	}

	// Token: 0x0601215B RID: 74075 RVA: 0x00641F8E File Offset: 0x0064018E
	public void KIHCAJBAJDC()
	{
		Singleton<GameManager>.Instance.KPCCPKIPFGC(Singleton<GameManager>.Instance.CreateServerURL("PlaySound"), false);
	}

	// Token: 0x0601215C RID: 74076 RVA: 0x00641FAC File Offset: 0x006401AC
	public virtual void BMIOFJFMCBG()
	{
		base.DFFKKLAPHCC();
		base.KAGHABABGCB(false);
		this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.DKLCCAOFAIN));
		this.KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.BMDDFOKBIAK));
		this.OnLoaded.Invoke();
		Singleton<GameManager>.Instance.EJGBOJDDMHH("_MainTex2", "_MainTex2", null, null, 0, 1);
		if (this.canvasGO.FindDeepChild("Bad parameters for getint! Use <key> <value>"))
		{
			this.GOFEKGAKHON = this.canvasGO.FindDeepChild("/").GetComponent<Text>();
		}
		if (this.canvasGO.FindDeepChild("Other"))
		{
			this.DLKGEPIOLDE = this.canvasGO.FindDeepChild(" on effect ").GetComponent<Slider>();
		}
		if (this.canvasGO.FindDeepChild("[Up]"))
		{
			this.HLNBBDEGLPJ = this.canvasGO.FindDeepChild("CameraFilterPack/Colors_Adjust_ColorRGB").GetComponentInChildren<Text>();
		}
		if (this.canvasGO.FindDeepChild("/"))
		{
			this.canvasGO.FindDeepChild("/").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("F3"))
		{
			this.canvasGO.FindDeepChild("MaxLivesSlider").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("player.playedtutorial"))
		{
			this.canvasGO.FindDeepChild("L1").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("DPADHOR"))
		{
			this.canvasGO.FindDeepChild("CameraFilterPack/Distortion_Dream").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("\" for viewID "))
		{
			this.canvasGO.FindDeepChild("powerup.1").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("CameraFilterPack/Colors_Adjust_PreFilters"))
		{
			this.canvasGO.FindDeepChild("ItemsUploader").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("\\"))
		{
			this.canvasGO.FindDeepChild("_HueShift").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		this.CheckLicence();
	}

	// Token: 0x0601215D RID: 74077 RVA: 0x00642254 File Offset: 0x00640454
	public MapData CLGGEJBBKFI()
	{
		MapData mapData = new MapData(this.levelData);
		mapData.name = this.configCanvas.transform.Find("PLAY [SPACE]").Find("_Distortion").GetComponent<InputField>().text;
		mapData.info = this.configCanvas.transform.Find("colorA").Find("Set Particle Size").GetComponent<InputField>().text;
		mapData.moreInfoURL = this.configCanvas.transform.Find("_MainTex2").Find("[PlayerBase] Highscore: ").GetComponent<InputField>().text;
		mapData.speed = (float)((int)this.configCanvas.transform.Find("UseScanLine").Find("maps.").GetComponent<Slider>().value);
		mapData.configVersion = (int)this.configCanvas.transform.Find("Down").FindDeepChild("Set Crosshair Emission").GetComponent<Slider>().value;
		mapData.lives = (int)this.configCanvas.transform.Find("</i>").Find("_MainTex2").GetComponent<Slider>().value;
		mapData.maxLives = (int)this.configCanvas.transform.Find("DPADHOR").Find("Please attach component to a Graphical UI component").GetComponent<Slider>().value;
		mapData.handCount = (int)this.configCanvas.transform.Find("move").Find("SaveButton").GetComponent<Slider>().value;
		mapData.environmentType = (int)this.configCanvas.transform.Find("_ScreenResolution").Find("CameraFilterPack/Blend2Camera_ColorDodge").GetComponent<Slider>().value;
		mapData.hidden = this.configCanvas.transform.Find("_CurveTex").Find("colorB").GetComponent<Toggle>().isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip != null)) ? 1416f : Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Toggle toggle = componentsInChildren[i];
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 1)
		{
			mapData.tags.Add(" not found");
		}
		else if (mapData.handCount == 4)
		{
			mapData.tags.Add("_TimeX");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		foreach (InputField inputField in gameObject.GetComponentsInChildren<InputField>())
		{
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("[UI] Unknows button action: ").transform.childCount; k += 0)
		{
			if (GameObject.Find("hitsounds:").transform.GetChild(k).name == "_ScreenResolution")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("_Offsets").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		MapData mapData2 = mapData;
		IEnumerable<MapEvent> events = mapData.events;
		if (LevelEditorScene.LNIJKGECNME == null)
		{
			LevelEditorScene.LNIJKGECNME = new Func<MapEvent, float>(LevelEditorScene.NPCIOHKFMNP);
		}
		mapData2.events = events.OrderBy(LevelEditorScene.LNIJKGECNME).ToList<MapEvent>();
		mapData.checkpoints.Clear();
		for (int l = 0; l < GameObject.Find("_FixDistance").transform.childCount; l++)
		{
			if (GameObject.Find("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.").transform.GetChild(l).name == "hidden")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("cmd.exe").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = mapData;
		IEnumerable<float> checkpoints = mapData.checkpoints;
		if (LevelEditorScene.CLCBJCKCBDD == null)
		{
			LevelEditorScene.CLCBJCKCBDD = new Func<float, float>(LevelEditorScene.MMAGIMBKFLF);
		}
		mapData3.checkpoints = checkpoints.OrderBy(LevelEditorScene.CLCBJCKCBDD).ToList<float>();
		return mapData;
	}

	// Token: 0x0601215E RID: 74078 RVA: 0x00642728 File Offset: 0x00640928
	private IEnumerator BKDGOKFPMPD()
	{
		fullName = new FileInfo(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, true, true));
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip)
		{
			Debug.Log("[MapEditor] Loaded music file: " + fullName);
			this.levelData.musicTime = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length;
			if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip)
			{
				yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
				clip = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip;
				if (clip != null)
				{
					float length = clip.length;
					this.canvasGO.FindDeepChild("CurrentTimeLabel").GetComponent<Text>().text = "0.00";
					this.canvasGO.FindDeepChild("TotalTimeLabel").GetComponent<Text>().text = string.Empty + length.ToString("0.00");
					this.asampler.Init(clip, 0f, false);
					this.asampler.audioSources[1].loop = true;
				}
			}
		}
		yield break;
	}

	// Token: 0x0601215F RID: 74079 RVA: 0x00642744 File Offset: 0x00640944
	private IEnumerator MPDFDBFLDDE()
	{
		Debug.Log("[MapEditor] Loading map: " + this.mapID);
		this.isLevelLoaded = false;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		this.levelData = new MapData(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		yield return base.StartCoroutine(this.JINABPAAGGF());
		this.RebuildGridAndCaret();
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.SetEditedData(this.levelData);
		base.StartCoroutine(this.NLIGGKFCFNM());
		Singleton<EditorHistoryHandler>.Instance.Clear();
		Singleton<EditorHistoryHandler>.Instance.SaveState("Init", false);
		this.asampler.audioSources[1].Play();
		yield return new WaitForFixedUpdate();
		this.asampler.audioSources[1].Pause();
		this.ScrollTo(0f);
		this.isLevelLoaded = true;
		this.OnLoaded.Invoke();
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("GenerationMenu"))
		{
			this.canvasGO.FindDeepChild("GenerationMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x06012160 RID: 74080 RVA: 0x0064275F File Offset: 0x0064095F
	public void LABKLIBINHN()
	{
		this.currentEventsCanvasId = ((this.currentEventsCanvasId != 0) ? 1 : 0);
	}

	// Token: 0x06012161 RID: 74081 RVA: 0x0064277C File Offset: 0x0064097C
	public IEnumerator KBHJMBLNECE()
	{
		if (Singleton<EditorHistoryHandler>.Instance.state != this.LKJCIHOKJHC)
		{
			yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Save level before uploading?", "YES", null, "NO", null));
			if (Singleton<MessageBoxPanel>.Instance.result == 1)
			{
				yield return base.StartCoroutine(this.Save(true));
			}
		}
		if (Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)) + ".completed", 0, null) == 1 || !string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
		{
			if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("Creating new item...", "OK", null, false, false, 0f);
				SteamAPICall_t hAPICall = SteamUGC.CreateItem((AppId_t)513510U, EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				Debug.Log("[LevelEditorScene] Creating new item...");
			}
			else
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Map already submited. Update?", "YES", null, "NO", null));
				if (Singleton<MessageBoxPanel>.Instance.result == 1)
				{
					yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog("Change Note:", "SUBMIT", null, null));
					if (Singleton<MessageBoxPanel>.Instance.result == 1)
					{
						base.StartCoroutine(this.KGCHKEGFNHI(new PublishedFileId_t(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId)), Singleton<MessageBoxPanel>.Instance.textResult));
					}
				}
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("You must complete your map before submiting it to Workshop", "OK", null, true, false, 0f);
		}
		yield break;
	}

	// Token: 0x06012162 RID: 74082 RVA: 0x00642798 File Offset: 0x00640998
	public void GHJIOCGJHND()
	{
		if (this.asampler.audioSources[1].isPlaying)
		{
			this.asampler.audioSources[1].Pause();
		}
		else if (this.asampler.audioSources[1].time < this.asampler.audioSources[0].clip.length)
		{
			this.asampler.audioSources[1].Play();
		}
		GameObject gameObject = GameObject.Find("ConfigVersionSlider");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (this.canvasGO.FindDeepChild("settings.volume.menu"))
		{
			this.canvasGO.FindDeepChild("&page=").GetComponentInChildren<Text>().text = ((!this.asampler.audioSources[0].isPlaying) ? " not exist" : "LevelURLInputField");
		}
		if (this.canvasGO.FindDeepChild("_Colored"))
		{
			this.canvasGO.FindDeepChild("id").GetComponent<Image>().sprite = ((!this.asampler.audioSources[0].isPlaying) ? this.playImage : this.pauseImage);
		}
	}

	// Token: 0x06012163 RID: 74083 RVA: 0x006428FC File Offset: 0x00640AFC
	public void PINGDANDPKN()
	{
		Singleton<MessageBoxPanel>.Instance.AGMKJJLMOHG("_TimeX", string.Empty, null, false, true, 1855f);
		string text = GameObject.Find("_TimeX").GetComponent<InputField>().text;
		string result = GameObject.Find("\n\n#").GetComponent<FileSelector>().result;
		base.StartCoroutine(this.AddNewLevelResoure(text, result));
	}

	// Token: 0x06012164 RID: 74084 RVA: 0x00642960 File Offset: 0x00640B60
	public void OnAddNewResourceButton()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Working.\nPlease wait..", string.Empty, null, false, false, 0f);
		string text = GameObject.Find("ResourceIDInputField").GetComponent<InputField>().text;
		string result = GameObject.Find("ResourceFileSelector").GetComponent<FileSelector>().result;
		base.StartCoroutine(this.AddNewLevelResoure(text, result));
	}

	// Token: 0x06012165 RID: 74085 RVA: 0x0063CB82 File Offset: 0x0063AD82
	public void ShowAcceptLicence()
	{
		base.StartCoroutine(this.AcceptLicence());
	}

	// Token: 0x06012166 RID: 74086 RVA: 0x006429C4 File Offset: 0x00640BC4
	private GameObject KIDAPPHEPBE()
	{
		GameObject result = null;
		if (this.asampler.audioSources[0].clip != null)
		{
			float num = float.PositiveInfinity;
			Transform transform = this.GNDCEMNKEEO.transform;
			for (int i = 0; i < GameObject.Find("BitsData").transform.childCount; i++)
			{
				GameObject gameObject = GameObject.Find("BitsData").transform.GetChild(i).gameObject;
				Vector3 position = gameObject.transform.position;
				float sqrMagnitude = (position - transform.position).sqrMagnitude;
				if (sqrMagnitude < num && gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
				{
					result = gameObject;
					num = sqrMagnitude;
				}
			}
		}
		return result;
	}

	// Token: 0x06012167 RID: 74087 RVA: 0x00642AB4 File Offset: 0x00640CB4
	private IEnumerator HKKPIKPPDBL(PublishedFileId_t JMMILEFMACB, string GIGBCMLIKKE)
	{
		fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
		haebghhmebh = fullLevelPath + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(haebghhmebh, true));
		Debug.Log("[LevelEditorScene] Updated");
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updated!", "OK", null, true, false, 0f);
		ugcupdateHandle_t = SteamUGC.StartItemUpdate((AppId_t)513510U, JMMILEFMACB);
		SteamUGC.SetItemTitle(ugcupdateHandle_t, this.levelData.name);
		SteamUGC.SetItemDescription(ugcupdateHandle_t, this.levelData.info);
		SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
		SteamUGC.SetItemContent(ugcupdateHandle_t, fullLevelPath);
		SteamUGC.SetItemPreview(ugcupdateHandle_t, fullLevelPath + "/" + this.levelData.iconFile);
		tags = this.levelData.tags;
		SteamUGC.SetItemTags(ugcupdateHandle_t, tags);
		hAPICall = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, GIGBCMLIKKE);
		this.FHKGDJDOKNB = ugcupdateHandle_t;
		this.isUpdating = true;
		this.KAPDFIOHNGL.Set(hAPICall, null);
		yield break;
	}

	// Token: 0x06012168 RID: 74088 RVA: 0x00642AE0 File Offset: 0x00640CE0
	public void ReloadResList()
	{
		GameObject gameObject = this.resourcesScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (MapResource mapResource in this.levelData.levelResources)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.resourcesElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "resource";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ResourceListElement>().Init(mapResource.name, mapResource.path, Singleton<MapsSystem>.Instance.GetMapData(this.mapID).resources[mapResource.name]);
		}
	}

	// Token: 0x06012169 RID: 74089 RVA: 0x00642BF8 File Offset: 0x00640DF8
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
		if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
		{
		}
		if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
		{
			Debug.Log("[LevelEditorScene] Item creation successful! Published Item ID: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
			base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.workshopConfigFileName, NPIKJHPJIEA.m_nPublishedFileId.ToString(), true));
			base.StartCoroutine(this.KGCHKEGFNHI(NPIKJHPJIEA.m_nPublishedFileId, "Created"));
		}
	}

	// Token: 0x0601216A RID: 74090 RVA: 0x00642D2C File Offset: 0x00640F2C
	public void AddRecordedEventGO(string NOJGGCLPPAM, int PGJECADBIOI)
	{
		if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.handCount < 2)
		{
			if (NOJGGCLPPAM == "[Up]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData()
				});
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData()
				});
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData()
				});
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData()
				});
			}
		}
		else
		{
			if (NOJGGCLPPAM == "[Up]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.up.GetEditedData() + "," + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "[Right]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.right.GetEditedData() + "," + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "[Down]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.down.GetEditedData() + "," + PGJECADBIOI
				});
			}
			if (NOJGGCLPPAM == "[Left]")
			{
				this.ONBJNLMBDPI(this.asampler.audioSources[1].time, new List<string>
				{
					"SpawnObj",
					Singleton<EditorKeyBindHandler>.Instance.left.GetEditedData() + "," + PGJECADBIOI
				});
			}
		}
	}

	// Token: 0x0601216B RID: 74091 RVA: 0x00643038 File Offset: 0x00641238
	private void CLAEAKOBMDF(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("mapselector.filter.rateduponly");
			Singleton<MessageBoxPanel>.Instance.AGMKJJLMOHG("<color=#", "challenges.", null, false, false, 40f);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultOK)
		{
			Singleton<MessageBoxPanel>.Instance.ILNLMMEOALM(".", "(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", null, true, true, 1557f);
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<GameManager>.Instance.KPCCPKIPFGC("," + NPIKJHPJIEA.m_nPublishedFileId, false);
			Debug.Log("Already exist!");
			Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("LastNewsButton", "Dropped Object: ", null, false, true, 295f);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, false))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
				string text = fullLevelPath + "_Value3" + Helpers.levelConfigFileName;
			}
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		this.isUpdating = false;
	}

	// Token: 0x0601216C RID: 74092 RVA: 0x00643150 File Offset: 0x00641350
	private void BMDDFOKBIAK(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
	{
		if (DNMPOBBBLBD)
		{
			Debug.Log("[LevelEditorScene] Error: I/O Failure! :(");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Error: I/O Failure", "OK", null, true, false, 0f);
			return;
		}
		EResult eResult = NPIKJHPJIEA.m_eResult;
		if (eResult != EResult.k_EResultOK)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Failed!", "OK", null, true, false, 0f);
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		else
		{
			Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/sharedfiles/filedetails/?id=" + NPIKJHPJIEA.m_nPublishedFileId, true);
			Debug.Log("[LevelEditorScene] Map submitted!");
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null, true, false, 0f);
			if (RanksSystem.IsOfficial(NPIKJHPJIEA.m_nPublishedFileId.m_PublishedFileId, false))
			{
				string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
				string text = fullLevelPath + "/" + Helpers.levelConfigFileName;
			}
			this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
		}
		this.isUpdating = false;
	}

	// Token: 0x0601216D RID: 74093 RVA: 0x00643268 File Offset: 0x00641468
	private void PLICILPAOJJ()
	{
		GameObject gameObject = this.unlockConditionContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		int num = 0;
		using (List<string>.Enumerator enumerator = this.levelData.unlockConditions.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				LevelEditorScene.MIAMLCBDKHA miamlcbdkha = new LevelEditorScene.MIAMLCBDKHA();
				miamlcbdkha.IEOKJCPAOHL = enumerator.Current;
				miamlcbdkha.ADPIKBBAKHP = this;
				LevelEditorScene.OBBGBOKJGOD obbgbokjgod = new LevelEditorScene.OBBGBOKJGOD();
				obbgbokjgod.PPFPANGJGFI = miamlcbdkha;
				obbgbokjgod.OBFJPHLBFOL = UnityEngine.Object.Instantiate<GameObject>(this.unlockConditionElement);
				obbgbokjgod.OBFJPHLBFOL.transform.SetParent(gameObject.transform);
				obbgbokjgod.OBFJPHLBFOL.transform.localScale = new Vector3(1f, 1f, 1f);
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<InputField>().text = miamlcbdkha.IEOKJCPAOHL;
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
				obbgbokjgod.OBFJPHLBFOL.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(obbgbokjgod.GBKBDKHPLKG));
				num++;
			}
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.addNewUnlockConditionElement);
		gameObject2.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		gameObject2.GetComponentInChildren<Button>().onClick.AddListener(new UnityAction(this.MOFDPGHNDMO));
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	// Token: 0x0601216E RID: 74094 RVA: 0x00643434 File Offset: 0x00641634
	public void MGLJNGBEIOA()
	{
		base.StartCoroutine(this.ALLBJHBPMOI(false));
	}

	// Token: 0x0601216F RID: 74095 RVA: 0x00643444 File Offset: 0x00641644
	public MapData MFDFEBJDFBI()
	{
		MapData mapData = new MapData(this.levelData);
		mapData.name = this.configCanvas.transform.Find("No").Find("LevelNameInputField").GetComponent<InputField>().text;
		mapData.info = this.configCanvas.transform.Find("green").Find("_MatrixSize").GetComponent<InputField>().text;
		mapData.moreInfoURL = this.configCanvas.transform.Find(".lastCheckpoint.lives").Find("CameraFilterPack/BlurHole").GetComponent<InputField>().text;
		mapData.speed = (float)((int)this.configCanvas.transform.Find("menuVolume").Find("ItemNameText").GetComponent<Slider>().value);
		mapData.configVersion = (int)this.configCanvas.transform.Find("_Value3").FindDeepChild("Please specify a map name or buildID").GetComponent<Slider>().value;
		mapData.lives = (int)this.configCanvas.transform.Find("settings.shaders.bloomintencity").Find("_Exponent").GetComponent<Slider>().value;
		mapData.maxLives = (int)this.configCanvas.transform.Find("bad").Find("#random #rare #item").GetComponent<Slider>().value;
		mapData.handCount = (int)this.configCanvas.transform.Find("ArcsNoHitsoundTimeDelaySlider").Find("/music").GetComponent<Slider>().value;
		mapData.environmentType = (int)this.configCanvas.transform.Find("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.").Find("_Value").GetComponent<Slider>().value;
		mapData.hidden = this.configCanvas.transform.Find(" ").Find("skin.").GetComponent<Toggle>().isOn;
		mapData.musicTime = ((!(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip != null)) ? 1784f : Singleton<MapsSystem>.Instance.GetMapData(this.mapID).clip.length);
		mapData.tags = new List<string>();
		GameObject gameObject = this.tagsScrollRectContent;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Toggle toggle = componentsInChildren[i];
			if (toggle.isOn)
			{
				mapData.tags.Add(toggle.GetComponentInChildren<Text>().text);
			}
		}
		if (mapData.handCount == 0)
		{
			mapData.tags.Add("_Value4");
		}
		else if (mapData.handCount == 2)
		{
			mapData.tags.Add("0.00");
		}
		mapData.unlockConditions = new List<string>();
		gameObject = this.unlockConditionContent;
		InputField[] componentsInChildren2 = gameObject.GetComponentsInChildren<InputField>();
		for (int j = 0; j < componentsInChildren2.Length; j += 0)
		{
			InputField inputField = componentsInChildren2[j];
			if (inputField.transform.parent.gameObject.activeSelf && !string.IsNullOrEmpty(inputField.text))
			{
				mapData.unlockConditions.Add(inputField.text);
			}
		}
		mapData.events.Clear();
		for (int k = 0; k < GameObject.Find("LevelConfigButton").transform.childCount; k += 0)
		{
			if (GameObject.Find("#timeuntilend: ").transform.GetChild(k).name == " on effect ")
			{
				mapData.events.Add(new MapEvent(GameObject.Find("CameraFilterPack/Distortion_ShockWave").transform.GetChild(k).GetComponent<EditorEvent>().mapEvent));
			}
		}
		MapData mapData2 = mapData;
		IEnumerable<MapEvent> events = mapData.events;
		if (LevelEditorScene.LNIJKGECNME == null)
		{
			LevelEditorScene.LNIJKGECNME = new Func<MapEvent, float>(LevelEditorScene.NPCIOHKFMNP);
		}
		mapData2.events = events.OrderBy(LevelEditorScene.LNIJKGECNME).ToList<MapEvent>();
		mapData.checkpoints.Clear();
		for (int l = 1; l < GameObject.Find("checkpoint").transform.childCount; l++)
		{
			if (GameObject.Find("FinalScoreSmallText").transform.GetChild(l).name == "x")
			{
				mapData.checkpoints.Add(new MapEvent(GameObject.Find("_ScreenResolution").transform.GetChild(l).GetComponent<EditorEvent>().mapEvent).time);
			}
		}
		MapData mapData3 = mapData;
		IEnumerable<float> checkpoints = mapData.checkpoints;
		if (LevelEditorScene.CLCBJCKCBDD == null)
		{
			LevelEditorScene.CLCBJCKCBDD = new Func<float, float>(LevelEditorScene.MMAGIMBKFLF);
		}
		mapData3.checkpoints = checkpoints.OrderBy(LevelEditorScene.CLCBJCKCBDD).ToList<float>();
		return mapData;
	}

	// Token: 0x06012170 RID: 74096 RVA: 0x005AD798 File Offset: 0x005AB998
	public void OnManualButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/files/editor_manual.pdf"), true);
	}

	// Token: 0x06012171 RID: 74097 RVA: 0x00643918 File Offset: 0x00641B18
	private bool IIKJJHPHBDC(EditorEventFunctionInfo IACGDFHKCAE)
	{
		return IACGDFHKCAE.id == this.eventConfigCanvas.transform.Find("BitsData").GetComponent<DropDownList>().GJHIINGAEJG().LHBHELFAOGF();
	}

	// Token: 0x06012172 RID: 74098 RVA: 0x0064394C File Offset: 0x00641B4C
	public IEnumerator Save(bool DICJGPOLHPK = true)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Please wait..", string.Empty, null, false, false, 0f);
		if (string.IsNullOrEmpty(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).workshopId))
		{
			Singleton<MapsSystem>.Instance.DeleteLevelSave(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
		}
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = this.GetEditedData();
		nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
		Helpers.CheckDirectory(fullLevelPath);
		yield return base.StartCoroutine(Helpers.SaveFile(fullLevelPath + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevel(Singleton<MapsSystem>.Instance.GetMapID(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)), Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath, FullMapData.MapSource.Editor));
		Debug.Log("[LevelEditorScene] Exported to " + fullLevelPath);
		this.LKJCIHOKJHC = Singleton<EditorHistoryHandler>.Instance.state;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null, true, false, 0f);
		yield break;
	}

	// Token: 0x06012173 RID: 74099 RVA: 0x00643968 File Offset: 0x00641B68
	public void HGJEJOMEBNF(List<string> NKEHMBLLEMH)
	{
		if (this.EditingEventGO.GetComponent<EditorEvent>().mapEvent != null)
		{
			MapEvent mapEvent = this.EditingEventGO.GetComponent<EditorEvent>().mapEvent;
			mapEvent.time = float.Parse(this.eventConfigCanvas.transform.Find("Multiplayer").GetComponent<InputField>().text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			mapEvent.data = NKEHMBLLEMH;
			this.EditingEventGO.GetComponent<EditorEvent>().mapEvent = mapEvent;
			this.EditingEventGO.GetComponent<EditorEvent>().lastDataCount = -1;
			this.EditingEventGO.GetComponent<EditorEvent>().UpdatePositionFromData();
			this.eventConfigCanvas.transform.Find("_Value3").GetComponent<InputField>().text = string.Empty + this.EditingEventGO.GetComponent<EditorEvent>().mapEvent.time;
			((LevelEditorScene)Singleton<global::Scene>.Instance).JHGKNFJBKJD(true);
			Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("CameraFilterPack/Blend2Camera_Hue", true);
		}
	}

	// Token: 0x06012174 RID: 74100 RVA: 0x00643A6C File Offset: 0x00641C6C
	private void BDCKICKJFNG(float EHHBHEJBHNG, List<string> NOJGGCLPPAM = null)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.customevent);
		gameObject.transform.SetParent(GameObject.Find("settings.arcshitsoundtimedelay").transform);
		gameObject.transform.localPosition = new Vector3(EHHBHEJBHNG, 605f, 1173f);
		gameObject.GetComponent<EditorEvent>().mapEvent = new MapEvent(EHHBHEJBHNG, NOJGGCLPPAM);
		gameObject.GetComponent<EditorEvent>().IPCHIGBJADH();
		gameObject.name = "float,1";
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("Could not execute RPC ", true);
	}

	// Token: 0x06012175 RID: 74101 RVA: 0x00643AF4 File Offset: 0x00641CF4
	public IEnumerator GBJABEEGOOE()
	{
		this.newLevelCanvas.SetActive(false);
		this.loadLevelCanvas.SetActive(true);
		gameObject = this.levelsSelectorListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		num = 0;
		enumerator = Singleton<MapsSystem>.Instance.levelsData.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string text = enumerator.Current;
				FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
				if (fullMapData.source == FullMapData.MapSource.Editor)
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.loadLevelElement, Vector3.zero, Quaternion.identity);
					num++;
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					gameObject2.GetComponent<LevelsSelectorListElement>().levelid = text;
					gameObject2.transform.Find("NameText").GetComponent<Text>().text = string.Concat(new string[]
					{
						text,
						" [",
						fullMapData.mapData.name,
						"]",
						(!string.IsNullOrEmpty(fullMapData.workshopId)) ? (" - PUBLISHED #" + fullMapData.workshopId) : " - LOCAL"
					});
					if (gameObject2.transform.Find("IconImage"))
					{
						if (fullMapData.icon != null)
						{
							gameObject2.transform.Find("IconImage").GetComponent<Image>().sprite = fullMapData.icon;
						}
						else
						{
							base.StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(gameObject2.transform.Find("IconImage").GetComponent<Image>(), fullMapData));
						}
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		if (num == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.listMessageElement, Vector3.zero, Quaternion.identity);
			num++;
			gameObject3.transform.SetParent(gameObject.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.transform.Find("MessageText").GetComponent<Text>().text = "MAPS NOT FOUND";
			yield break;
		}
		yield break;
	}

	// Token: 0x06012176 RID: 74102 RVA: 0x00643B0F File Offset: 0x00641D0F
	public void OnNewLevelButton(int OFBPACALHFI)
	{
		if (OFBPACALHFI == 0)
		{
			this.newLevelCanvas.SetActive(true);
		}
		if (OFBPACALHFI == 1)
		{
			base.StartCoroutine(this.OECGEKPJPCB());
		}
	}

	// Token: 0x06012177 RID: 74103 RVA: 0x00643B37 File Offset: 0x00641D37
	public void SetDetectorSpeed(float DPNHODJHGJL)
	{
		this.asampler.audioSources[0].pitch = DPNHODJHGJL;
	}

	// Token: 0x06012178 RID: 74104 RVA: 0x00643B50 File Offset: 0x00641D50
	public IEnumerator HMHBGNFMHKJ(string NPJLPIHGLBI, string EAGJAOLHFGB, string FLMDNANCAAC, bool EAPDHEDHAAI = false, string NCHEHDPLJBP = "")
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", null, null, false, false, 0f);
		text = NPJLPIHGLBI + "/" + Helpers.levelConfigFileName;
		yield return base.StartCoroutine(Helpers.LoadText(text, true));
		Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
		if (!string.IsNullOrEmpty(EAGJAOLHFGB) && File.Exists(EAGJAOLHFGB))
		{
			fileInfo = new FileInfo(EAGJAOLHFGB);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.iconFile);
			File.Copy(EAGJAOLHFGB, NPJLPIHGLBI + "/icon" + fileInfo.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.iconFile = "icon" + fileInfo.Extension;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(NPJLPIHGLBI + "/icon" + fileInfo.Extension, NPJLPIHGLBI + "/icon" + fileInfo.Extension, true, false));
			if (Singleton<MapsSystem>.Instance.GetMapData(this.mapID) != null)
			{
				Singleton<MapsSystem>.Instance.GetMapData(this.mapID).icon = (Sprite)ResourcesManager.GetLoadedResource(NPJLPIHGLBI + "/icon" + fileInfo.Extension);
				base.StartCoroutine(Singleton<MapsSystem>.Instance.LoadIconForLevel(null, Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
			}
		}
		if (!string.IsNullOrEmpty(FLMDNANCAAC) && File.Exists(FLMDNANCAAC))
		{
			fileInfo2 = new FileInfo(FLMDNANCAAC);
			File.Delete(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile);
			File.Copy(FLMDNANCAAC, NPJLPIHGLBI + "/music" + fileInfo2.Extension);
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile = "music" + fileInfo2.Extension;
			musicTime = 0f;
			fullName = new FileInfo(NPJLPIHGLBI + "/" + Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicFile).FullName;
			yield return base.StartCoroutine(Helpers.GetAudioLength(fullName, true));
			musicTime = Helpers.resultAudioLength;
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.musicTime = musicTime;
		}
		if (!string.IsNullOrEmpty(NCHEHDPLJBP))
		{
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.configVersion = MapData.GetLastConfigVersion();
		}
		nojggclppam = JsonConvert.SerializeObject(Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData);
		Helpers.CheckDirectory(Helpers.GetDirectory("Editor/"));
		Helpers.CheckDirectory(NPJLPIHGLBI);
		yield return base.StartCoroutine(Helpers.SaveFile(NPJLPIHGLBI + "/" + Helpers.levelConfigFileName, nojggclppam, true));
		if (EAPDHEDHAAI)
		{
			base.StartCoroutine(this.KKDHPBOFIFH(NPJLPIHGLBI));
		}
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield break;
	}

	// Token: 0x06012179 RID: 74105 RVA: 0x00643B90 File Offset: 0x00641D90
	public void TogglePlay()
	{
		if (this.asampler.audioSources[1].isPlaying)
		{
			this.asampler.audioSources[1].Pause();
		}
		else if (this.asampler.audioSources[1].time < this.asampler.audioSources[1].clip.length)
		{
			this.asampler.audioSources[1].Play();
		}
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (this.canvasGO.FindDeepChild("MenuPlayButton"))
		{
			this.canvasGO.FindDeepChild("MenuPlayButton").GetComponentInChildren<Text>().text = ((!this.asampler.audioSources[1].isPlaying) ? "PLAY [SPACE]" : "PAUSE [SPACE]");
		}
		if (this.canvasGO.FindDeepChild("PlayButton"))
		{
			this.canvasGO.FindDeepChild("PlayButton").GetComponent<Image>().sprite = ((!this.asampler.audioSources[1].isPlaying) ? this.playImage : this.pauseImage);
		}
	}

	// Token: 0x0601217A RID: 74106 RVA: 0x00643CF4 File Offset: 0x00641EF4
	public virtual void MGMAOBPPOBJ()
	{
		base.JILOMOBDPIA();
		base.GIIBKOADAMF(true);
		this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.PFIPOJIIODP));
		this.KAPDFIOHNGL = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.CLAEAKOBMDF));
		this.OnLoaded.Invoke();
		Singleton<GameManager>.Instance.PDNPNJNFDGL("_Far", "SetBGColor", null, null, 1, 0);
		if (this.canvasGO.FindDeepChild("turn"))
		{
			this.GOFEKGAKHON = this.canvasGO.FindDeepChild("Set sun audio input").GetComponent<Text>();
		}
		if (this.canvasGO.FindDeepChild("_Value4"))
		{
			this.DLKGEPIOLDE = this.canvasGO.FindDeepChild("SetParticlesParticleSize").GetComponent<Slider>();
		}
		if (this.canvasGO.FindDeepChild("_Offsets"))
		{
			this.HLNBBDEGLPJ = this.canvasGO.FindDeepChild("_Value").GetComponentInChildren<Text>();
		}
		if (this.canvasGO.FindDeepChild("float,0"))
		{
			this.canvasGO.FindDeepChild("Tab2Content").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("CompletedLevel"))
		{
			this.canvasGO.FindDeepChild("_Value").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("float,10"))
		{
			this.canvasGO.FindDeepChild("You need to have a child LayoutGroup content set for the list: ").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("IconImage"))
		{
			this.canvasGO.FindDeepChild("Case-Sensitive").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("Please wait.."))
		{
			this.canvasGO.FindDeepChild("Mine").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("_SSRMultiplier"))
		{
			this.canvasGO.FindDeepChild("_MiddleGrey").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("Editing: "))
		{
			this.canvasGO.FindDeepChild("_RayStepSize").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		this.CheckLicence();
	}

	// Token: 0x0601217B RID: 74107 RVA: 0x00643F9C File Offset: 0x0064219C
	public IEnumerator AddNewLevelResoure(string JFEBNHAPGBG, string MOMKGLKFJED)
	{
		if (!string.IsNullOrEmpty(MOMKGLKFJED) && File.Exists(MOMKGLKFJED))
		{
			FileInfo fileInfo = new FileInfo(MOMKGLKFJED);
			string text = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath + "/" + fileInfo.Name;
			Debug.Log("newPath" + text);
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Copy(MOMKGLKFJED, text);
			yield return null;
			MapResource item = new MapResource(JFEBNHAPGBG, "Sprite", fileInfo.Name);
			Singleton<MapsSystem>.Instance.GetMapData(this.mapID).mapData.levelResources.Add(item);
			yield return base.StartCoroutine(this.Save(false));
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.mapID)));
			this.ReloadResList();
		}
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done!", "OK", null, true, false, 0f);
		yield break;
	}

	// Token: 0x0601217C RID: 74108 RVA: 0x00643FC8 File Offset: 0x006421C8
	public IEnumerator BDJMHLGCAFM(string NCHEHDPLJBP)
	{
		this.mapID = NCHEHDPLJBP;
		Singleton<MapsSystem>.Instance.LoadLevel(this.mapID, false);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(NCHEHDPLJBP)));
		if (this.eventConfigCanvas)
		{
			this.eventConfigCanvas.SetActive(true);
		}
		this.isLevelLoaded = false;
		this.SetEditedData(this.levelData);
		this.isLevelLoaded = true;
		if (this.canvasGO.FindDeepChild("EditMenu"))
		{
			this.canvasGO.FindDeepChild("EditMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("EventMenu"))
		{
			this.canvasGO.FindDeepChild("EventMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("ViewMenu"))
		{
			this.canvasGO.FindDeepChild("ViewMenu").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("SaveButton"))
		{
			this.canvasGO.FindDeepChild("SaveButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("LevelConfigButton"))
		{
			this.canvasGO.FindDeepChild("LevelConfigButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		if (this.canvasGO.FindDeepChild("PublishButton"))
		{
			this.canvasGO.FindDeepChild("PublishButton").GetComponent<Button>().interactable = this.isLevelLoaded;
		}
		yield break;
	}

	// Token: 0x0601217D RID: 74109 RVA: 0x00643FEA File Offset: 0x006421EA
	public void AHDDILKPILN()
	{
		this.levelData.unlockConditions.Add(string.Empty);
		this.PLICILPAOJJ();
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", true);
	}

	// Token: 0x0601217E RID: 74110 RVA: 0x0064199C File Offset: 0x0063FB9C
	public void OnConfigButton()
	{
		this.configCanvas.SetActive(!this.configCanvas.activeSelf);
		this.resourcesCanvas.SetActive(false);
	}

	// Token: 0x0601217F RID: 74111 RVA: 0x00644018 File Offset: 0x00642218
	public void KKBKFLDJKHG(int HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == 0)
		{
			for (int i = 0; i < GameObject.Find("_Shadow").transform.childCount; i++)
			{
				if (GameObject.Find("Updating...").transform.GetChild(i).name == "Copy from " && GameObject.Find("CameraFilterPack/Blend2Camera_Saturation").transform.GetChild(i).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("#onrankchangeuptext").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0]) && GameObject.Find("traffic").transform.GetChild(i).GetComponent<EditorEvent>().mapEvent.data[0] == "[PlayerBase] SetSpeed error: ")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("_ScreenResolution").transform.GetChild(i).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			for (int j = 0; j < GameObject.Find("_ScreenResolution").transform.childCount; j += 0)
			{
				if (GameObject.Find("_TimeX").transform.GetChild(j).name == "GlassDistortion" && GameObject.Find("CameraFilterPack_3D_Myst1").transform.GetChild(j).GetComponent<EditorEvent>() && !string.IsNullOrEmpty(GameObject.Find("_Intensity").transform.GetChild(j).GetComponent<EditorEvent>().mapEvent.data[0]))
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("_Color").transform.GetChild(j).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 1)
		{
			for (int k = 0; k < GameObject.Find("FileMenu").transform.childCount; k++)
			{
				if (GameObject.Find("powerup.0").transform.GetChild(k).name == "_Value")
				{
					UnityEngine.Object.DestroyImmediate(GameObject.Find("Left Stick Click").transform.GetChild(k).gameObject);
				}
			}
		}
		if (HMGBJCGOLMI == 6)
		{
			this.DeleteAll(0);
			this.FFMLLIEPBAC(1);
			this.FFMLLIEPBAC(8);
		}
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("[FileSelector] Starting file dialog", true);
	}

	// Token: 0x06012180 RID: 74112 RVA: 0x00644298 File Offset: 0x00642498
	public void OnLoadMusicFile()
	{
		string result = GameObject.Find("MusicFileSelector").GetComponent<FileSelector>().result;
		string fullLevelPath = Singleton<MapsSystem>.Instance.GetMapData(this.mapID).fullLevelPath;
		base.StartCoroutine(this.UpdateEditorLevelAssets(fullLevelPath, null, result, true, string.Empty));
	}

	// Token: 0x06012181 RID: 74113 RVA: 0x006442E8 File Offset: 0x006424E8
	private IEnumerator KKDHPBOFIFH(string BNJFKKGOACF)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(BNJFKKGOACF);
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.PreloadLevel(directoryInfo.Name, BNJFKKGOACF, FullMapData.MapSource.Editor));
		this.OnLoadLevelButton();
		yield break;
	}

	// Token: 0x06012182 RID: 74114 RVA: 0x0064430A File Offset: 0x0064250A
	public void LGFPCPALFII(int OFBPACALHFI)
	{
		if (OFBPACALHFI == 0)
		{
			this.newLevelCanvas.SetActive(false);
		}
		if (OFBPACALHFI == 0)
		{
			base.StartCoroutine(this.OECGEKPJPCB());
		}
	}

	// Token: 0x06012183 RID: 74115 RVA: 0x00644334 File Offset: 0x00642534
	public void OnFastVideoButton()
	{
		string nbebmkfpbep = "https://www.youtube.com/watch?v=cDVXukrKo74";
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
	}

	// Token: 0x06012184 RID: 74116 RVA: 0x00644353 File Offset: 0x00642553
	public void GLPGAINFEDC(float DPNHODJHGJL)
	{
		this.asampler.audioSources[1].pitch = DPNHODJHGJL;
	}

	// Token: 0x06012185 RID: 74117 RVA: 0x0064436C File Offset: 0x0064256C
	private GameObject MCFAKMMIPNL()
	{
		GameObject result = null;
		if (this.asampler.audioSources[1].clip != null)
		{
			float num = 476f;
			Transform transform = this.GNDCEMNKEEO.transform;
			for (int i = 1; i < GameObject.Find("_FadeDistance").transform.childCount; i += 0)
			{
				GameObject gameObject = GameObject.Find("ReconnectAndRejoin() disabled the offline mode. No longer offline.").transform.GetChild(i).gameObject;
				Vector3 position = gameObject.transform.position;
				float sqrMagnitude = (position - transform.position).sqrMagnitude;
				if (sqrMagnitude < num && gameObject.GetComponent<EditorEvent>() && gameObject.GetComponent<EditorEvent>().mapEvent != null && gameObject.GetComponent<EditorEvent>().mapEvent.data != null)
				{
					result = gameObject;
					num = sqrMagnitude;
				}
			}
		}
		return result;
	}

	// Token: 0x04001FD7 RID: 8151
	public int currentEventsCanvasId;

	// Token: 0x04001FD8 RID: 8152
	public List<GameObject> soundWavesCanvas;

	// Token: 0x04001FD9 RID: 8153
	public GameObject soundWaveElement;

	// Token: 0x04001FDA RID: 8154
	public bool isLevelLoaded;

	// Token: 0x04001FDB RID: 8155
	[HideInInspector]
	public string mapID;

	// Token: 0x04001FDC RID: 8156
	[HideInInspector]
	public MapData levelData;

	// Token: 0x04001FDD RID: 8157
	public GameObject bit;

	// Token: 0x04001FDE RID: 8158
	public GameObject grid;

	// Token: 0x04001FDF RID: 8159
	public GameObject caret;

	// Token: 0x04001FE0 RID: 8160
	public GameObject checkpoint;

	// Token: 0x04001FE1 RID: 8161
	public GameObject customevent;

	// Token: 0x04001FE2 RID: 8162
	public GameObject configCanvas;

	// Token: 0x04001FE3 RID: 8163
	public GameObject loadLevelCanvas;

	// Token: 0x04001FE4 RID: 8164
	public GameObject loadLevelElement;

	// Token: 0x04001FE5 RID: 8165
	public GameObject levelsSelectorListContent;

	// Token: 0x04001FE6 RID: 8166
	public GameObject listMessageElement;

	// Token: 0x04001FE7 RID: 8167
	public GameObject newLevelCanvas;

	// Token: 0x04001FE8 RID: 8168
	public GameObject resourcesCanvas;

	// Token: 0x04001FE9 RID: 8169
	public GameObject eventConfigCanvas;

	// Token: 0x04001FEA RID: 8170
	public GameObject zoomSlider;

	// Token: 0x04001FEB RID: 8171
	public GameObject tagsScrollRectContent;

	// Token: 0x04001FEC RID: 8172
	public GameObject tagElement;

	// Token: 0x04001FED RID: 8173
	public GameObject tagHeaderElement;

	// Token: 0x04001FEE RID: 8174
	public GameObject resourcesScrollRectContent;

	// Token: 0x04001FEF RID: 8175
	public GameObject resourcesElement;

	// Token: 0x04001FF0 RID: 8176
	public GameObject unlockConditionContent;

	// Token: 0x04001FF1 RID: 8177
	public GameObject unlockConditionElement;

	// Token: 0x04001FF2 RID: 8178
	public GameObject addNewUnlockConditionElement;

	// Token: 0x04001FF3 RID: 8179
	public GameObject puzzleScrollRectElement;

	// Token: 0x04001FF4 RID: 8180
	public GameObject addNewElement;

	// Token: 0x04001FF5 RID: 8181
	public Sprite playImage;

	// Token: 0x04001FF6 RID: 8182
	public Sprite pauseImage;

	// Token: 0x04001FF7 RID: 8183
	public Transform canvasGO;

	// Token: 0x04001FF8 RID: 8184
	public AudioSampler asampler;

	// Token: 0x04001FF9 RID: 8185
	public UnityEvent OnLoaded;

	// Token: 0x04001FFA RID: 8186
	public GameObject EditingEventGO;

	// Token: 0x04001FFB RID: 8187
	private GameObject AEAKHCLJFDH;

	// Token: 0x04001FFC RID: 8188
	public bool isRecording;

	// Token: 0x04001FFD RID: 8189
	protected CallResult<CreateItemResult_t> CEJIPNKDJKJ;

	// Token: 0x04001FFE RID: 8190
	protected CallResult<SubmitItemUpdateResult_t> KAPDFIOHNGL;

	// Token: 0x04001FFF RID: 8191
	public bool isUpdating;

	// Token: 0x04002000 RID: 8192
	private UGCUpdateHandle_t FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;

	// Token: 0x04002001 RID: 8193
	private int LKJCIHOKJHC;

	// Token: 0x04002002 RID: 8194
	private GameObject GNDCEMNKEEO;

	// Token: 0x04002003 RID: 8195
	private Text GOFEKGAKHON;

	// Token: 0x04002004 RID: 8196
	private Slider DLKGEPIOLDE;

	// Token: 0x04002005 RID: 8197
	private Text HLNBBDEGLPJ;

	// Token: 0x04002006 RID: 8198
	[CompilerGenerated]
	private static Func<MapEvent, float> LNIJKGECNME;

	// Token: 0x04002007 RID: 8199
	[CompilerGenerated]
	private static Func<float, float> CLCBJCKCBDD;

	// Token: 0x020004EB RID: 1259
	[CompilerGenerated]
	private sealed class MIAMLCBDKHA
	{
		// Token: 0x04002062 RID: 8290
		internal string IEOKJCPAOHL;

		// Token: 0x04002063 RID: 8291
		internal LevelEditorScene ADPIKBBAKHP;
	}

	// Token: 0x020004EC RID: 1260
	[CompilerGenerated]
	private sealed class OBBGBOKJGOD
	{
		// Token: 0x06012662 RID: 75362 RVA: 0x00668700 File Offset: 0x00666900
		internal void OLIGLEMPFOP()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("settings.enablehitsoundsinrelax", false);
		}

		// Token: 0x06012664 RID: 75364 RVA: 0x00668750 File Offset: 0x00666950
		internal void BFEABMIFIEE()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_MainTex2", true);
		}

		// Token: 0x06012665 RID: 75365 RVA: 0x006687A0 File Offset: 0x006669A0
		internal void DBFPGFHEGKA()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("_DotSize", false);
		}

		// Token: 0x06012666 RID: 75366 RVA: 0x006687F0 File Offset: 0x006669F0
		internal void OFHCGKJFGDI()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("SetEnvSpriteColor", false);
		}

		// Token: 0x06012667 RID: 75367 RVA: 0x00668840 File Offset: 0x00666A40
		internal void DKGPCPBNDPK()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("y", true);
		}

		// Token: 0x06012668 RID: 75368 RVA: 0x00668890 File Offset: 0x00666A90
		internal void MEMPOPNAEDN()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("[PlayerBase] Checkpoint error: ", false);
		}

		// Token: 0x06012669 RID: 75369 RVA: 0x006688E0 File Offset: 0x00666AE0
		internal void LOEAMHGMMPK()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_TimeX", true);
		}

		// Token: 0x0601266A RID: 75370 RVA: 0x00668930 File Offset: 0x00666B30
		internal void BKNHHGBPLGH()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_TimeX", false);
		}

		// Token: 0x0601266B RID: 75371 RVA: 0x00668980 File Offset: 0x00666B80
		internal void JKEDCEOCPJO()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("]", true);
		}

		// Token: 0x0601266C RID: 75372 RVA: 0x006689D0 File Offset: 0x00666BD0
		internal void KFNBKFELFLH()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Is it practically possible?", false);
		}

		// Token: 0x0601266D RID: 75373 RVA: 0x00668A20 File Offset: 0x00666C20
		internal void EGKGJJGAPMN()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("[PlayerController] ", false);
		}

		// Token: 0x0601266E RID: 75374 RVA: 0x00668A70 File Offset: 0x00666C70
		internal void PBCAHKDLFPE()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("_Value", false);
		}

		// Token: 0x0601266F RID: 75375 RVA: 0x00668AC0 File Offset: 0x00666CC0
		internal void LNDGINDKPFA()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("bad", true);
		}

		// Token: 0x06012670 RID: 75376 RVA: 0x00668B10 File Offset: 0x00666D10
		internal void BDGDIDPDBHG()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("[DiscordController] Init", false);
		}

		// Token: 0x06012671 RID: 75377 RVA: 0x00668B60 File Offset: 0x00666D60
		internal void FFEGPHJKMFK()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("#savemapbeforeuploading", true);
		}

		// Token: 0x06012672 RID: 75378 RVA: 0x00668BB0 File Offset: 0x00666DB0
		internal void AEINPAGJFME()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", false);
		}

		// Token: 0x06012673 RID: 75379 RVA: 0x00668C00 File Offset: 0x00666E00
		internal void FIPCLHEKKCA()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("Editor", true);
		}

		// Token: 0x06012674 RID: 75380 RVA: 0x00668C50 File Offset: 0x00666E50
		internal void FJDBPPKABJE()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("_Visualize", false);
		}

		// Token: 0x06012675 RID: 75381 RVA: 0x00668CA0 File Offset: 0x00666EA0
		internal void LLNDDFGPOPL()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.EACMGHMNGIE("PS Home", false);
		}

		// Token: 0x06012676 RID: 75382 RVA: 0x00668CF0 File Offset: 0x00666EF0
		internal void JDELIMPGFDJ()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("_Glitch", false);
		}

		// Token: 0x06012677 RID: 75383 RVA: 0x00668D40 File Offset: 0x00666F40
		internal void LHHFJBIAHCN()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("tagElement", false);
		}

		// Token: 0x06012678 RID: 75384 RVA: 0x00668D90 File Offset: 0x00666F90
		internal void EKHOOPGPPGE()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("Reading preview file failed!: \"{0}\"", false);
		}

		// Token: 0x06012679 RID: 75385 RVA: 0x00668DE0 File Offset: 0x00666FE0
		internal void GBKBDKHPLKG()
		{
			this.PPFPANGJGFI.ADPIKBBAKHP.levelData.unlockConditions.Remove(this.PPFPANGJGFI.IEOKJCPAOHL);
			UnityEngine.Object.Destroy(this.OBFJPHLBFOL);
			Singleton<EditorHistoryHandler>.Instance.SaveState("Edited unlock conditions", false);
		}

		// Token: 0x04002064 RID: 8292
		internal GameObject OBFJPHLBFOL;

		// Token: 0x04002065 RID: 8293
		internal LevelEditorScene.MIAMLCBDKHA PPFPANGJGFI;
	}
}
