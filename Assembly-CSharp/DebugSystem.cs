using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020003A0 RID: 928
public class DebugSystem : MonoBehaviour
{
	// Token: 0x0600CF78 RID: 53112 RVA: 0x004A6F38 File Offset: 0x004A5138
	private IEnumerator NJBKKNMCANL(int JMMILEFMACB)
	{
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		byte[] data = wwwform.data;
		string url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		WWW www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF79 RID: 53113 RVA: 0x004A6F54 File Offset: 0x004A5154
	private void GAMPNFOIFHF()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "mapselector.filter.subscribedonly")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("SpawnObj", null) && flag)
		{
			GUILayout.Label(".", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[3];
			array2[0] = "_Value2";
			array2[1] = Helpers.GetStat("[ItemsHandler] Inventory has changed");
			array2[0] = "CameraFilterPack/Real_VHS";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat(" not exist"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("Uploading content", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("player.xp", 0, null);
			}
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("menu.selectedplaymode", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("PLEASE WAIT", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 48, new GUILayoutOption[0]);
			if (GUILayout.Button("SpawnObj", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.CDHNLLBNBFD(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("Text", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF7A RID: 53114 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x0600CF7B RID: 53115 RVA: 0x004A7134 File Offset: 0x004A5334
	private void IMAPGBMIKJF()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "steamid")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_ScreenResolution", null) && flag)
		{
			GUILayout.Label("Preparing content", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[0];
			array2[0] = "[Left]";
			array2[0] = Helpers.GetStat("Feb");
			array2[6] = "_Distance";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("CameraFilterPack/AAA_WaterDropPro"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("ws://", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("Reset 21 achievement progress", 0, null);
			}
			if (GUILayout.Button("_Value", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("LoadMapCanvas", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("path", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 40, new GUILayoutOption[1]);
			if (GUILayout.Button("CheckCombo", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.IAFPILJNPJE(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("<b>Speed</b>:", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF7C RID: 53116 RVA: 0x004A7314 File Offset: 0x004A5514
	private IEnumerator BPFDEIPEHNB(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF7D RID: 53117 RVA: 0x004A7330 File Offset: 0x004A5530
	private IEnumerator NCHNAJLDLBE(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF7E RID: 53118 RVA: 0x004A734C File Offset: 0x004A554C
	private void EFFEJFOOIDM()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "R2")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("{0:0}", null) && flag)
		{
			GUILayout.Label("_Axis", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[2];
			array2[0] = "_Value2";
			array2[0] = Helpers.GetStat("workshop.");
			array2[1] = "Reload Maps";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("{STEAM_CLAN_IMAGE}"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_DistortionSize", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Value4", 1, null);
			}
			if (GUILayout.Button("CameraFilterPack/Blend2Camera_SoftLight", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("#lives", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("SetCrosshairColor", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 102, new GUILayoutOption[1]);
			if (GUILayout.Button("_MainTex2", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.DEOBEEFBNPF(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("settings.cameramovements", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF7F RID: 53119 RVA: 0x004A752C File Offset: 0x004A572C
	private void AJCFIBPGAME()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "workshop.")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_Value", null) && flag)
		{
			GUILayout.Label("#no", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[5];
			array2[1] = "Failed to InstantiateSceneObject prefab:";
			array2[0] = Helpers.GetStat("player.currentrank");
			array2[6] = "_CenterX";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("Hidden/DepthOfField/BokehSplatting"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("CameraFilterPack/AAA_BloodOnScreen", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_Value9", 0, null);
			}
			if (GUILayout.Button("_RotationMatrix", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("LastHighScoreText", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("settings.crosshairopacity", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 24, new GUILayoutOption[1]);
			if (GUILayout.Button("/", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.IKIGAFJHIIG(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("workshop.", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF80 RID: 53120 RVA: 0x004A770C File Offset: 0x004A590C
	private void LKFBADCLLML()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "PUN-instantiated '")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey(".lastCheckpoint.time", null) && flag)
		{
			GUILayout.Label("settings_bindings_", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[0] = "_Value";
			array2[0] = Helpers.GetStat("STICKLVER");
			array2[7] = "mapselector.filter.rateduponly";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("/"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("/", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("MascotChallenge2019", 1, null);
			}
			if (GUILayout.Button("ConfigVersionSlider", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button(".lastCheckpoint.time", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("maxScore", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -63, new GUILayoutOption[1]);
			if (GUILayout.Button("Joystick1Button6", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.FNMOGPINAAJ(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("[LobbyPlayerElement] Created lpe for ", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF81 RID: 53121 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOPCCCCHNLI()
	{
	}

	// Token: 0x0600CF82 RID: 53122 RVA: 0x004A78EC File Offset: 0x004A5AEC
	private IEnumerator OKFHFFHCDEB(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF83 RID: 53123 RVA: 0x004A7908 File Offset: 0x004A5B08
	private void KOCIIOKHKME()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "_TimeX")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_Near", null) && flag)
		{
			GUILayout.Label("/", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[1];
			array2[1] = "value";
			array2[0] = Helpers.GetStat("#currentbpm: ");
			array2[1] = "_SunPosition";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("OpJoinRandomRoom()"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("Chat", 1, null);
			}
			if (GUILayout.Button("[PlayerController] ", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("1", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("SpectatingUserInfo", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -66, new GUILayoutOption[0]);
			if (GUILayout.Button("_Value4", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.MIGCGKLBGML(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_Visualize", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF84 RID: 53124 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMCPMOGKDEH()
	{
	}

	// Token: 0x0600CF85 RID: 53125 RVA: 0x004A7AE8 File Offset: 0x004A5CE8
	private void MOIFIHHBFFF()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string a = array[i];
			if (a == "_Value")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_Speed", null) && flag)
		{
			GUILayout.Label(" [", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[4];
			array2[0] = "CameraFilterPack/Drawing_Manga3";
			array2[0] = Helpers.GetStat("Tab2Content");
			array2[8] = "_RedAmplifier";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("[Sound Manager] Audio clip is null, cannot play music"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("_TimeX", 0, null);
			}
			if (GUILayout.Button("#creatingnewitem", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("CameraFilterPack/AAA_WaterDrop", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("_Glitch", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 20, new GUILayoutOption[1]);
			if (GUILayout.Button("MapperNameText", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.HFPELPCLPAL(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("OK", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF86 RID: 53126 RVA: 0x004A7CC8 File Offset: 0x004A5EC8
	private IEnumerator FNMOGPINAAJ(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF87 RID: 53127 RVA: 0x004A7CE4 File Offset: 0x004A5EE4
	private IEnumerator IAFPILJNPJE(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF88 RID: 53128 RVA: 0x004A7D00 File Offset: 0x004A5F00
	private IEnumerator JFKPFDLOFGB(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF89 RID: 53129 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x0600CF8A RID: 53130 RVA: 0x004A7D1C File Offset: 0x004A5F1C
	private void IPLADLICBIP()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string a = array[i];
			if (a == "PointsScoreText")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Set particles color", null) && flag)
		{
			GUILayout.Label(";", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[1] = "[NetworkManager] Exited";
			array2[0] = Helpers.GetStat("playing");
			array2[4] = "/";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat("SaveButton"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("#exit", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Value3", 0, null);
			}
			if (GUILayout.Button("_Intensity", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("Connecting", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("x", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 46, new GUILayoutOption[0]);
			if (GUILayout.Button("_Offsets", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.MIGCGKLBGML(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("Hello", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF8B RID: 53131 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x0600CF8C RID: 53132 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x0600CF8D RID: 53133 RVA: 0x004A7EFC File Offset: 0x004A60FC
	private IEnumerator FGBHBIPLKDC(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF8E RID: 53134 RVA: 0x004A7F18 File Offset: 0x004A6118
	private IEnumerator DOGJFAMOKAP(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF8F RID: 53135 RVA: 0x004A7F34 File Offset: 0x004A6134
	private void OKEPOJNDCHO()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		foreach (string a in commandLineArgs)
		{
			if (a == "Tab2Content")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("PunRespawn", null) && flag)
		{
			GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[3];
			array2[0] = "Adreno";
			array2[1] = Helpers.GetStat("close");
			array2[7] = "menu.relaxinfo";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("RoomDescriptionText"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_AdaptationSpeed", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("907198288", 1, null);
			}
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("Right", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("_EmissionGain", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -76, new GUILayoutOption[0]);
			if (GUILayout.Button(".", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.PMEDHNBFNNG(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_Speed", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF90 RID: 53136 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x0600CF91 RID: 53137 RVA: 0x004A8114 File Offset: 0x004A6314
	private IEnumerator HCGNLFCJELN(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF92 RID: 53138 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600CF93 RID: 53139 RVA: 0x0002523B File Offset: 0x0002343B
	private void JONGNKNLLND()
	{
	}

	// Token: 0x0600CF94 RID: 53140 RVA: 0x0002523B File Offset: 0x0002343B
	private void HAIAHJPCPAG()
	{
	}

	// Token: 0x0600CF95 RID: 53141 RVA: 0x0002523B File Offset: 0x0002343B
	private void COIJKMKIEAK()
	{
	}

	// Token: 0x0600CF96 RID: 53142 RVA: 0x0002523B File Offset: 0x0002343B
	private void JKFDDNMPOJH()
	{
	}

	// Token: 0x0600CF97 RID: 53143 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x0600CF98 RID: 53144 RVA: 0x0002523B File Offset: 0x0002343B
	private void GNJDKAECPKA()
	{
	}

	// Token: 0x0600CF99 RID: 53145 RVA: 0x004A8130 File Offset: 0x004A6330
	private IEnumerator GGDGAMFAEHI(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF9A RID: 53146 RVA: 0x004A814C File Offset: 0x004A634C
	private IEnumerator DFLCELEEGBL(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF9B RID: 53147 RVA: 0x0002523B File Offset: 0x0002343B
	private void NNFMIAFHMJM()
	{
	}

	// Token: 0x0600CF9C RID: 53148 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x0600CF9D RID: 53149 RVA: 0x004A8168 File Offset: 0x004A6368
	private IEnumerator BGLNJKHPEFK(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CF9E RID: 53150 RVA: 0x004A8184 File Offset: 0x004A6384
	private void GNFIAMJKJIN()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "mapselector.filter.rateduponly")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("GlassDistortion", null) && flag)
		{
			GUILayout.Label("_Value3", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[1];
			array2[0] = "X2";
			array2[1] = Helpers.GetStat("MenuScene");
			array2[6] = "player.mysteryitem";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("12"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("?", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.SetInt("Freq: ", 1, null);
			}
			if (GUILayout.Button("HostType: {0} ", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_color", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("maps.", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -18, new GUILayoutOption[0]);
			if (GUILayout.Button("_FrustumCornersWS", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.DFLCELEEGBL(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("Preparing content", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CF9F RID: 53151 RVA: 0x0002523B File Offset: 0x0002343B
	private void JECMJNFGBGC()
	{
	}

	// Token: 0x0600CFA0 RID: 53152 RVA: 0x0002523B File Offset: 0x0002343B
	private void KLILJHJNICK()
	{
	}

	// Token: 0x0600CFA1 RID: 53153 RVA: 0x004A8364 File Offset: 0x004A6564
	private void HMKPDNHBGDE()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "SetSatelliteTrailWidth")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("The image effect ", null) && flag)
		{
			GUILayout.Label(".highscore", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[2];
			array2[0] = "Image";
			array2[1] = Helpers.GetStat("finished");
			array2[4] = "_Offsets";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("Offline or in OfflineMode. No VitalStats available."));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("float,1.5", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("Value", 1, null);
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("[MapsData] Caching ", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -18, new GUILayoutOption[0]);
			if (GUILayout.Button("_Value", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.NFBBJIGIDPP(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("From {0} at Index {1} \n", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFA2 RID: 53154 RVA: 0x004A8544 File Offset: 0x004A6744
	private void PCCEPADONHK()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		foreach (string a in commandLineArgs)
		{
			if (a == "Color")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("MenuPlayButton", null) && flag)
		{
			GUILayout.Label("_Value5", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[5];
			array2[0] = "The given 2D texture ";
			array2[0] = Helpers.GetStat("<b>Time</b>:");
			array2[5] = "[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("z"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_FixDistance", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt(") error: ", 0, null);
			}
			if (GUILayout.Button("Oct", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button(".", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("Can't find key ", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -45, new GUILayoutOption[1]);
			if (GUILayout.Button("FToA", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.NJBKKNMCANL(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("sfxVolume", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFA3 RID: 53155 RVA: 0x004A8724 File Offset: 0x004A6924
	private void AHAIBKMLNAP()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		foreach (string a in commandLineArgs)
		{
			if (a == "VeryHigh")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("Fade", null) && flag)
		{
			GUILayout.Label("ShowTitle", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[]
			{
				"CameraFilterPack/Blend2Camera_Screen"
			};
			array2[0] = Helpers.GetStat("OK");
			array2[3] = "_Near";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("_LightIntensity"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_Visualize", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("MultiplayerButton", 0, null);
			}
			if (GUILayout.Button("/icon", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Value3", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -47, new GUILayoutOption[1]);
			if (GUILayout.Button("maps.", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.GGDGAMFAEHI(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("Vertical", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFA4 RID: 53156 RVA: 0x004A8904 File Offset: 0x004A6B04
	private void PPCJACOLHBJ()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "/icon")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("DisableStoryboardToggle", null) && flag)
		{
			GUILayout.Label("PUN-instantiated '", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[7];
			array2[0] = "settings.volume.menu";
			array2[1] = Helpers.GetStat("shader.crispwinter");
			array2[3] = "_Value3";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("https://www.youtube.com/watch?v=cDVXukrKo74"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("[MapsStats] Max score: ", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CONTRAST", 1, null);
			}
			if (GUILayout.Button("set environment id", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Intensity", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Set particles audio input", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -76, new GUILayoutOption[1]);
			if (GUILayout.Button("_Value", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.NAPOEAOOPIC(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("Distortion", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFA5 RID: 53157 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600CFA6 RID: 53158 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600CFA7 RID: 53159 RVA: 0x0002523B File Offset: 0x0002343B
	private void ILCFPCIPENO()
	{
	}

	// Token: 0x0600CFA8 RID: 53160 RVA: 0x0002523B File Offset: 0x0002343B
	private void IHLMNAGPKDA()
	{
	}

	// Token: 0x0600CFA9 RID: 53161 RVA: 0x004A8AE4 File Offset: 0x004A6CE4
	private IEnumerator NFBBJIGIDPP(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFAA RID: 53162 RVA: 0x004A8B00 File Offset: 0x004A6D00
	private void OMBBIILDCCJ()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string a = array[i];
			if (a == "\\")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("BloodAlternative2", null) && flag)
		{
			GUILayout.Label(".completedMaps", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[6];
			array2[0] = "Horizontal";
			array2[0] = Helpers.GetStat("0.00");
			array2[1] = "CameraFilterPack_AAA_Blood1";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("High"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("<not connected>", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Intensity", 0, null);
			}
			if (GUILayout.Button("CameraFilterPack/3D_Myst", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("player.ice", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("ReJoinRoom failed due to offline mode.", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -126, new GUILayoutOption[1]);
			if (GUILayout.Button(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.EEHHMEKHAOG(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFAB RID: 53163 RVA: 0x004A8CE0 File Offset: 0x004A6EE0
	private void AKGHJPACNLP()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "curScn")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Tab1Content", null) && flag)
		{
			GUILayout.Label("_ScreenResolution", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[4];
			array2[0] = "GlassAberration";
			array2[0] = Helpers.GetStat("#yes");
			array2[0] = "Set Particles Emission";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("..."));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("_SpotSize", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Value5", 1, null);
			}
			if (GUILayout.Button("StartButton", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("0", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 71, new GUILayoutOption[1]);
			if (GUILayout.Button("_LutTex", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.GGDGAMFAEHI(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button(" base map(s)", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFAC RID: 53164 RVA: 0x0002523B File Offset: 0x0002343B
	private void CIPKEPDELJB()
	{
	}

	// Token: 0x0600CFAD RID: 53165 RVA: 0x0002523B File Offset: 0x0002343B
	private void FLKEJJEGCFA()
	{
	}

	// Token: 0x0600CFAE RID: 53166 RVA: 0x004A8EC0 File Offset: 0x004A70C0
	private IEnumerator OBFLOLGMFEE(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFAF RID: 53167 RVA: 0x004A8EDC File Offset: 0x004A70DC
	private void LGMADMDBKNE()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		foreach (string a in commandLineArgs)
		{
			if (a == "_Distortion")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("MainThreadExecuter", null) && flag)
		{
			GUILayout.Label("_Speed", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[5];
			array2[0] = "&map=";
			array2[1] = Helpers.GetStat("1427616858");
			array2[2] = "SetTrailZoomSpeed";
			array2[3] = Helpers.GetPlayerLevel(Helpers.GetStat("SetCrosshairColor"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("settings_bindings_", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.NHONGIGFHJB("mapselector.filter.rateduponly", 1, null);
			}
			if (GUILayout.Button("Items/", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_Blue_C", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("CameraFilterPack/Blend2Camera_Luminosity", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 74, new GUILayoutOption[0]);
			if (GUILayout.Button("/C tasklist", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.BGLNJKHPEFK(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_FarCorner", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFB0 RID: 53168 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEDDNDHCLNN()
	{
	}

	// Token: 0x0600CFB1 RID: 53169 RVA: 0x004A90BC File Offset: 0x004A72BC
	private void OGBJNAAAEGI()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == ".highscore")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("???", null) && flag)
		{
			GUILayout.Label("IconImage", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[2];
			array2[0] = "_ScreenResolution";
			array2[0] = Helpers.GetStat("UNDISTORT");
			array2[7] = "CameraFilterPack/Blend2Camera_Luminosity";
			array2[2] = Helpers.GetPlayerLevel(Helpers.GetStat("_Value4"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("SearchTex", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("SetParent", 0, null);
			}
			if (GUILayout.Button("_Intensity", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("Circle", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button(" left", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -112, new GUILayoutOption[0]);
			if (GUILayout.Button("yyyy", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.DFLCELEEGBL(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("/", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFB2 RID: 53170 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x0600CFB3 RID: 53171 RVA: 0x004A929C File Offset: 0x004A749C
	private IEnumerator HFPELPCLPAL(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFB4 RID: 53172 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIMNPCMHJLJ()
	{
	}

	// Token: 0x0600CFB5 RID: 53173 RVA: 0x004A92B8 File Offset: 0x004A74B8
	private void LGNBNCBPMAA()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		foreach (string a in commandLineArgs)
		{
			if (a == "[PlayerController] ")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("FileMenu", null) && flag)
		{
			GUILayout.Label("_Value5", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[5];
			array2[0] = "_Value";
			array2[1] = Helpers.GetStat("_TimeX");
			array2[5] = "Set Sun MaxSize";
			array2[4] = Helpers.GetPlayerLevel(Helpers.GetStat("_Bullet_8"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("#close", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("STICKRVER", 1, null);
			}
			if (GUILayout.Button("Received RPC: ", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("Editor/", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button(" ", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 68, new GUILayoutOption[0]);
			if (GUILayout.Button("_Value2", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.GGDGAMFAEHI(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_Green_R", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFB6 RID: 53174 RVA: 0x004A9498 File Offset: 0x004A7698
	private void GGJKHODKNOC()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		foreach (string a in commandLineArgs)
		{
			if (a == "ItemNameText")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO(".jpg", null) && flag)
		{
			GUILayout.Label("GlassColor", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			GUILayout.Label(string.Concat(new object[]
			{
				"Preparing configuration...",
				Helpers.GetStat("Done!"),
				null,
				"CameraFilterPack/Blend2Camera_Saturation",
				Helpers.GetPlayerLevel(Helpers.GetStat("_NeighborMaxTex"))
			}), new GUILayoutOption[1]);
			if (GUILayout.Button("#lives", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Intensity", 0, null);
			}
			if (GUILayout.Button("GroupNameText", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("[ResourcesManager] Load image error: ", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("[NetworkManager] Exited", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 30, new GUILayoutOption[1]);
			if (GUILayout.Button("_TimeX", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.IAFPILJNPJE(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFB7 RID: 53175 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBAJLLFMMMP()
	{
	}

	// Token: 0x0600CFB8 RID: 53176 RVA: 0x004A9678 File Offset: 0x004A7878
	private void FBDOGLBMDNG()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		foreach (string a in commandLineArgs)
		{
			if (a == "_Value4")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("player.xp", null) && flag)
		{
			GUILayout.Label("attempted to spawn go (", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[0];
			array2[0] = "_Offsets";
			array2[0] = Helpers.GetStat("ENABLE_DITHERING");
			array2[8] = "EnvironmentSlider";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat(".lastCheckpoint.checkpointsUsed"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("GameScene", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("OnReadyClick", 1, null);
			}
			if (GUILayout.Button("skin.", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ChannelMixerGreen", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 25, new GUILayoutOption[0]);
			if (GUILayout.Button("UI Extensions/SoftMaskShaderText", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.OBOLALMEFCE(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_Bloom5", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFB9 RID: 53177 RVA: 0x0002523B File Offset: 0x0002343B
	private void FMNPFCHBLJF()
	{
	}

	// Token: 0x0600CFBA RID: 53178 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBLGHLNNAHN()
	{
	}

	// Token: 0x0600CFBB RID: 53179 RVA: 0x004A9858 File Offset: 0x004A7A58
	private IEnumerator BDHBLCMKLLM(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFBC RID: 53180 RVA: 0x004A9874 File Offset: 0x004A7A74
	private IEnumerator PMEDHNBFNNG(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFBD RID: 53181 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x0600CFBE RID: 53182 RVA: 0x0002523B File Offset: 0x0002343B
	private void EFJDNLGNACH()
	{
	}

	// Token: 0x0600CFBF RID: 53183 RVA: 0x004A9890 File Offset: 0x004A7A90
	private void JLKEEOILNFI()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		foreach (string a in commandLineArgs)
		{
			if (a == "MenuScene")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("LoadMapCanvas", null) && flag)
		{
			GUILayout.Label("x", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[5];
			array2[1] = "green";
			array2[1] = Helpers.GetStat("Set Sun Sensitivity");
			array2[0] = "SUCCESS! Item submitted! :D :D :D";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("CameraFilterPack/Blend2Camera_LinearBurn"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("ArcsDestroyDelaySlider", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("BitsData", 0, null);
			}
			if (GUILayout.Button("_Green_C", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button(": ", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Connected to gameserver.", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 108, new GUILayoutOption[1]);
			if (GUILayout.Button("Not sending leave operation. State is not 'Joined': ", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.FGBHBIPLKDC(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("CameraFilterPack/EXTRA_Rotation", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFC0 RID: 53184 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x0600CFC1 RID: 53185 RVA: 0x004A9A70 File Offset: 0x004A7C70
	private IEnumerator IIBMFAMNFEE(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFC2 RID: 53186 RVA: 0x004A9A8C File Offset: 0x004A7C8C
	private IEnumerator HIODJDMJILF(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFC3 RID: 53187 RVA: 0x004A9AA8 File Offset: 0x004A7CA8
	private IEnumerator EEHHMEKHAOG(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFC4 RID: 53188 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600CFC5 RID: 53189 RVA: 0x0002523B File Offset: 0x0002343B
	private void DLBODOFAJGM()
	{
	}

	// Token: 0x0600CFC6 RID: 53190 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x0600CFC7 RID: 53191 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600CFC8 RID: 53192 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x0600CFC9 RID: 53193 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x0600CFCA RID: 53194 RVA: 0x0002523B File Offset: 0x0002343B
	private void MEBPBNLBECA()
	{
	}

	// Token: 0x0600CFCB RID: 53195 RVA: 0x004A9AC4 File Offset: 0x004A7CC4
	private IEnumerator NAPOEAOOPIC(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFCC RID: 53196 RVA: 0x0002523B File Offset: 0x0002343B
	private void FEKECCBFGMI()
	{
	}

	// Token: 0x0600CFCD RID: 53197 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x0600CFCE RID: 53198 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDPIHMAACO()
	{
	}

	// Token: 0x0600CFCF RID: 53199 RVA: 0x004A9AE0 File Offset: 0x004A7CE0
	private void NHOKMFGLIPN()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		foreach (string a in commandLineArgs)
		{
			if (a == "[ResourcesManager] Load audio error: ")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_RGB", null) && flag)
		{
			GUILayout.Label("SupportLogger OnLeftRoom().", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[6];
			array2[1] = "HandsCountSlider";
			array2[1] = Helpers.GetStat("_Value2");
			array2[4] = "[Up]";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("_Skybox", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("Tab1Content", 1, null);
			}
			if (GUILayout.Button("ItemNameBGImage", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("IconImage", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Cross", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -5, new GUILayoutOption[1]);
			if (GUILayout.Button("skin.hit_wrong", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.DEOBEEFBNPF(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("[LocalizationService] Localization: ", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFD0 RID: 53200 RVA: 0x004A9CC0 File Offset: 0x004A7EC0
	private IEnumerator DEOBEEFBNPF(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFD1 RID: 53201 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x0600CFD2 RID: 53202 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKFDNIAKGEO()
	{
	}

	// Token: 0x0600CFD3 RID: 53203 RVA: 0x0002523B File Offset: 0x0002343B
	private void DAHFFNNIGML()
	{
	}

	// Token: 0x0600CFD4 RID: 53204 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x0600CFD5 RID: 53205 RVA: 0x004A9CDC File Offset: 0x004A7EDC
	private IEnumerator MAMOAAJKNOE(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFD6 RID: 53206 RVA: 0x004A9CF8 File Offset: 0x004A7EF8
	private IEnumerator IKIGAFJHIIG(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFD7 RID: 53207 RVA: 0x0002523B File Offset: 0x0002343B
	private void DOKAKEMDALN()
	{
	}

	// Token: 0x0600CFD8 RID: 53208 RVA: 0x004A9D14 File Offset: 0x004A7F14
	private IEnumerator CDHNLLBNBFD(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFD9 RID: 53209 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPEGAEGDJAM()
	{
	}

	// Token: 0x0600CFDA RID: 53210 RVA: 0x004A9D30 File Offset: 0x004A7F30
	private void INODCHEOKGF()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "The given 2D texture ")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP(" BETA", null) && flag)
		{
			GUILayout.Label("[Singleton] Using instance of '", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[1]);
			object[] array2 = new object[0];
			array2[1] = "maps.";
			array2[1] = Helpers.GetStat("curScn");
			array2[3] = "s";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("Avoid using this directly. Thanks."));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA(".completedCount", 0, null);
			}
			if (GUILayout.Button("No info", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("pointBuffer", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button(" ", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 75, new GUILayoutOption[0]);
			if (GUILayout.Button("UseScanLine", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.NCHNAJLDLBE(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_Value2", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFDB RID: 53211 RVA: 0x004A9F10 File Offset: 0x004A8110
	private void PEEJIJMKMFG()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string a = array[i];
			if (a == "_ScreenResolution")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("ok", null) && flag)
		{
			GUILayout.Label("_TimeX", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[4];
			array2[1] = "CameraFilterPack/BlurHole";
			array2[1] = Helpers.GetStat("Music End");
			array2[1] = "': ";
			array2[8] = Helpers.GetPlayerLevel(Helpers.GetStat("_Value"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("DPADVER", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HIDBNDKJHAA("Color's hex value #RRGGBBAA", 1, null);
			}
			if (GUILayout.Button("[Singleton] Using instance of '", new GUILayoutOption[1]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("You need to have a Graphic control (such as an Image) for the list [", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 26, new GUILayoutOption[1]);
			if (GUILayout.Button("PS Home", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.HCGNLFCJELN(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_DistortionSize", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFDC RID: 53212 RVA: 0x004AA0F0 File Offset: 0x004A82F0
	private void FAGGMAKKMAE()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "CameraFilterPack/Blend2Camera_Divide")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("Move environment object to the position", null) && flag)
		{
			GUILayout.Label("event", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[7];
			array2[1] = "Time Offset: {0}";
			array2[0] = Helpers.GetStat("settings.enablehitsoundsinnormal");
			array2[7] = "Can't set visible when not in that room.";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat(".lastCheckpoint.incorrectScore"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("#onrankchangeuptext", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.SetInt("CameraFilterPack/TV_WideScreenHorizontal", 0, null);
			}
			if (GUILayout.Button("_ScreenResolution", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("solo", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("masterSteamID", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -122, new GUILayoutOption[0]);
			if (GUILayout.Button("z", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.IAFPILJNPJE(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFDD RID: 53213 RVA: 0x004AA2D0 File Offset: 0x004A84D0
	private IEnumerator KEGFLEHHHNI(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFDE RID: 53214 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEPLFGKGLI()
	{
	}

	// Token: 0x0600CFE0 RID: 53216 RVA: 0x004AA300 File Offset: 0x004A8500
	private IEnumerator ACIHAOMNCGK(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFE1 RID: 53217 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x0600CFE2 RID: 53218 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x0600CFE3 RID: 53219 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x0600CFE4 RID: 53220 RVA: 0x004AA31C File Offset: 0x004A851C
	private IEnumerator MIGCGKLBGML(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFE5 RID: 53221 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x0600CFE6 RID: 53222 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFFCLAHMBAA()
	{
	}

	// Token: 0x0600CFE7 RID: 53223 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x0600CFE8 RID: 53224 RVA: 0x004AA338 File Offset: 0x004A8538
	private void OLFFIKHJIEO()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == ".completedCount")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_Value2", null) && flag)
		{
			GUILayout.Label("_CurTex", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[5];
			array2[0] = "[MapsStats] Length: ";
			array2[0] = Helpers.GetStat("s");
			array2[3] = "z";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("_TimeX"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button(". Possible scene loading in progress?", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("[MapEditor] Item creation successful! Published Item ID: ", 0, null);
			}
			if (GUILayout.Button("0.00", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("health", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("CameraFilterPack/Distortion_ShockWave", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -8, new GUILayoutOption[0]);
			if (GUILayout.Button("ItemNameBGImage", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.FNMOGPINAAJ(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("X2", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(false);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFE9 RID: 53225 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPNAOAKCMHC()
	{
	}

	// Token: 0x0600CFEA RID: 53226 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x0600CFEB RID: 53227 RVA: 0x004AA518 File Offset: 0x004A8718
	private void NJDBPAFPIAJ()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "CameraFilterPack/3D_Scan_Scene")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("_OcclusionTexture", null) && flag)
		{
			GUILayout.Label("_TimeX", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[2];
			array2[0] = "Failed to 'network-remove' GameObject because it's null.";
			array2[0] = Helpers.GetStat("[");
			array2[8] = "UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}";
			array2[7] = Helpers.GetPlayerLevel(Helpers.GetStat("Soundtrack"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_ScreenResolution", 0, null);
			}
			if (GUILayout.Button(" x ", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("\\\"", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 82, new GUILayoutOption[0]);
			if (GUILayout.Button("InfoCanvas", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.BDHBLCMKLLM(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_Red_B", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(1);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFEC RID: 53228 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600CFED RID: 53229 RVA: 0x0002523B File Offset: 0x0002343B
	private void DEEPMOLMGED()
	{
	}

	// Token: 0x0600CFEE RID: 53230 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x0600CFEF RID: 53231 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x0600CFF0 RID: 53232 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600CFF1 RID: 53233 RVA: 0x004AA6F8 File Offset: 0x004A88F8
	private IEnumerator OBOLALMEFCE(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFF2 RID: 53234 RVA: 0x004AA714 File Offset: 0x004A8914
	private void JFHCMEAOPPC()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		string[] array = commandLineArgs;
		for (int i = 0; i < array.Length; i += 0)
		{
			string a = array[i];
			if (a == "No font defined. Found font: ")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Unable to get a reward! Try again?", null) && flag)
		{
			GUILayout.Label("_TimeX", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[1];
			array2[0] = "\n";
			array2[1] = Helpers.GetStat("AddEnvironmentObject");
			array2[6] = ".message";
			array2[0] = Helpers.GetPlayerLevel(Helpers.GetStat("sounds/hit_normal"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("_Angle", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_SpawnHeuristic", 0, null);
			}
			if (GUILayout.Button("Cant send PickupItem spawn times to unknown targetPlayer.", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
			}
			if (GUILayout.Button("_Green_B", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.FECMEIJGLJI();
			}
			if (GUILayout.Button("Image effects aren't supported on this device ({0})", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -31, new GUILayoutOption[0]);
			if (GUILayout.Button("Error: I/O Failure", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.MIGCGKLBGML(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_TimeX", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFF3 RID: 53235 RVA: 0x0002523B File Offset: 0x0002343B
	private void KOFAMEKHHGD()
	{
	}

	// Token: 0x0600CFF4 RID: 53236 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600CFF5 RID: 53237 RVA: 0x004AA8F4 File Offset: 0x004A8AF4
	private IEnumerator CPIJNAKOLBG(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFF6 RID: 53238 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANCKKLFPGDI()
	{
	}

	// Token: 0x0600CFF7 RID: 53239 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEFHGMNAPEP()
	{
	}

	// Token: 0x0600CFF8 RID: 53240 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x0600CFF9 RID: 53241 RVA: 0x004AA910 File Offset: 0x004A8B10
	private void IPDCBNCBBEN()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		foreach (string a in commandLineArgs)
		{
			if (a == "roomDescription")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("IntraTime", null) && flag)
		{
			GUILayout.Label("LevelNameText", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[7];
			array2[0] = "Error0";
			array2[0] = Helpers.GetStat("_Value4");
			array2[1] = "GhostPosY";
			array2[5] = Helpers.GetPlayerLevel(Helpers.GetStat("Image effects aren't supported on this device ({0})"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[1]);
			if (GUILayout.Button("Set Satellite Trail MinVertexDistance", new GUILayoutOption[1]))
			{
				Singleton<SaveSystem>.Instance.SetInt("_Radius", 1, null);
			}
			if (GUILayout.Button("settings.enablehitsoundsinnormal", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("_BlurVector", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.OPKKBMCDOEM();
			}
			if (GUILayout.Button("B", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, -98, new GUILayoutOption[0]);
			if (GUILayout.Button("  |  Events Count: ", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.IKIGAFJHIIG(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("SetScale", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.CBPMAEIODNN(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600CFFA RID: 53242 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x0600CFFB RID: 53243 RVA: 0x004AAAF0 File Offset: 0x004A8CF0
	private IEnumerator OOPGEFDNHGH(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600CFFC RID: 53244 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x0600CFFD RID: 53245 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNNFHBOOPIN()
	{
	}

	// Token: 0x0600CFFE RID: 53246 RVA: 0x0002523B File Offset: 0x0002343B
	private void DKEHGPPOKEA()
	{
	}

	// Token: 0x0600CFFF RID: 53247 RVA: 0x004AAB0C File Offset: 0x004A8D0C
	private IEnumerator LDAAFJMJGOL(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600D000 RID: 53248 RVA: 0x004AAB28 File Offset: 0x004A8D28
	private void OnGUI()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		foreach (string a in commandLineArgs)
		{
			if (a == "-help")
			{
				flag = true;
			}
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("isBunned", null) && flag)
		{
			GUILayout.Label("Emergency Help:", new GUILayoutOption[0]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			GUILayout.Label(string.Concat(new object[]
			{
				"Current xp: ",
				Helpers.GetStat("player.xp"),
				" | Level: ",
				Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"))
			}), new GUILayoutOption[0]);
			if (GUILayout.Button("Reset XP", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.SetInt("player.xp", 0, null);
			}
			if (GUILayout.Button("Reload Steam Inventory", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("Reload Maps", new GUILayoutOption[0]))
			{
				Singleton<MapsSystem>.Instance.Init();
			}
			if (GUILayout.Button("Obtain promo Item", new GUILayoutOption[0]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 25, new GUILayoutOption[0]);
			if (GUILayout.Button("Obtain test Item", new GUILayoutOption[0]))
			{
				base.StartCoroutine(this.HCGNLFCJELN(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("Reset All", new GUILayoutOption[0]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.DeleteAll(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600D001 RID: 53249 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFJLGJEPEAA()
	{
	}

	// Token: 0x0600D002 RID: 53250 RVA: 0x004AAD08 File Offset: 0x004A8F08
	private IEnumerator HGOOGLPNNEC(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x0600D003 RID: 53251 RVA: 0x004AAD24 File Offset: 0x004A8F24
	private void DCJBGIFPNAN()
	{
		GUI.skin = this.skin;
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		string[] array = commandLineArgs;
		for (int i = 1; i < array.Length; i++)
		{
			string a = array[i];
			if (a == "menu.playedsolo")
			{
				flag = false;
			}
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("BitsData", null) && flag)
		{
			GUILayout.Label("StartButton", new GUILayoutOption[1]);
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.BeginVertical(new GUILayoutOption[0]);
			object[] array2 = new object[0];
			array2[1] = "_Near";
			array2[1] = Helpers.GetStat("_Value2");
			array2[8] = "_RampTex";
			array2[6] = Helpers.GetPlayerLevel(Helpers.GetStat("FToA"));
			GUILayout.Label(string.Concat(array2), new GUILayoutOption[0]);
			if (GUILayout.Button("_EmissionGain", new GUILayoutOption[0]))
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("#orderby:", 0, null);
			}
			if (GUILayout.Button("_AdaptionSpeed", new GUILayoutOption[0]))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			if (GUILayout.Button("|", new GUILayoutOption[1]))
			{
				Singleton<MapsSystem>.Instance.AOEEOKNJDCK();
			}
			if (GUILayout.Button("maps.", new GUILayoutOption[1]))
			{
			}
			this.JMMILEFMACB = GUILayout.TextField(this.JMMILEFMACB, 59, new GUILayoutOption[0]);
			if (GUILayout.Button("CameraFilterPack/OldFilm_Cutting2", new GUILayoutOption[1]))
			{
				base.StartCoroutine(this.BPFDEIPEHNB(int.Parse(this.JMMILEFMACB)));
			}
			if (GUILayout.Button("_Blue_G", new GUILayoutOption[1]))
			{
				SteamUserStats.ResetAllStats(true);
				SteamUserStats.StoreStats();
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK(null);
				SceneManager.LoadScene(0);
			}
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}
	}

	// Token: 0x0600D004 RID: 53252 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x0600D005 RID: 53253 RVA: 0x004AAF04 File Offset: 0x004A9104
	private IEnumerator GCKDIDJBLFO(int JMMILEFMACB)
	{
		wwwform = new WWWForm();
		wwwform.AddField("key", "---");
		wwwform.AddField("appid", "513510");
		wwwform.AddField("steamid", "76561198041679481");
		wwwform.AddField("itemdefid[0]", JMMILEFMACB);
		data = wwwform.data;
		url = "https://api.steampowered.com/IInventoryService/AddItem/v001";
		www = new WWW(url, data);
		yield return www;
		yield break;
	}

	// Token: 0x040017EE RID: 6126
	public GUISkin skin;

	// Token: 0x040017EF RID: 6127
	private GameObject NGNILGONOOC;

	// Token: 0x040017F0 RID: 6128
	private bool AHBEBGJJIJH;

	// Token: 0x040017F1 RID: 6129
	private bool CKIEEIONLPH;

	// Token: 0x040017F2 RID: 6130
	private string JMMILEFMACB = "0";
}
