using System;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000313 RID: 787
public class PhotonStatsGui : MonoBehaviour
{
	// Token: 0x0600B431 RID: 46129 RVA: 0x0041E72C File Offset: 0x0041C92C
	public void FFBECHMKMPK()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.ELOFOJIJFFA), "R2", new GUILayoutOption[0]);
	}

	// Token: 0x0600B432 RID: 46130 RVA: 0x0041E798 File Offset: 0x0041C998
	public void Start()
	{
		if (this.statsRect.x <= 0f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B433 RID: 46131 RVA: 0x0041E7CC File Offset: 0x0041C9CC
	public void BKIGIIINEDH()
	{
		if (this.statsRect.x <= 80f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B434 RID: 46132 RVA: 0x0041E800 File Offset: 0x0041CA00
	public void EIMNPCMHJLJ()
	{
		if (this.statsRect.x <= 965f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B435 RID: 46133 RVA: 0x0041E834 File Offset: 0x0041CA34
	public void DLCHPKAMIJK(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -66L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, ",", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "Cannot send messages when not connected. Either connect to Photon OR use offline mode!", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "DISTORT", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("_OcclusionTexture", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Object ID. Case-Sensitive", num);
		string text3 = string.Format("Music End", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "SetSatelliteTrailLength", new GUILayoutOption[0]);
			if (GUILayout.Button("EventData0DropDownList", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_SizeX", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_Value1", new GUILayoutOption[1]);
			text4 = "connect" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "curScn" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box(" not exist", new GUILayoutOption[0]);
			string format = "USE_DIAG_SEARCH";
			object[] array = new object[83];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "Beat Detected";
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[1] = text3;
			array2[0] = text4;
			array2[3] = text5;
			array2[5] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1636f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B436 RID: 46134 RVA: 0x0041EB7B File Offset: 0x0041CD7B
	public void PBEPCAPAKLG()
	{
		if (Input.GetKeyDown((KeyCode)(-107)) && Input.GetKey((KeyCode)(-65)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B437 RID: 46135 RVA: 0x0041EBAE File Offset: 0x0041CDAE
	public void GFACKFCEIBC()
	{
		if (Input.GetKeyDown((KeyCode)(-97)) && Input.GetKey((KeyCode)(-75)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B438 RID: 46136 RVA: 0x0041EBE4 File Offset: 0x0041CDE4
	public void MKPKOEENFND(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -192L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "_Value2", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "Chat", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_Saturation", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Mouse ", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("\nCreated by Oxy949", num);
		string text3 = string.Format("[Right]", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_TimeX", new GUILayoutOption[0]);
			if (GUILayout.Button("CameraFilterPack_RainFX_Anm2", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Misses:", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("duration", new GUILayoutOption[0]);
			text4 = "SpawnObj" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "GameVolumeSlider" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("OnAwakeRPC", new GUILayoutOption[0]);
			string format = "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data";
			object[] array = new object[60];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[4] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "workshop.";
			object[] array2 = new object[7];
			array2[1] = text;
			array2[0] = text2;
			array2[0] = text3;
			array2[3] = text4;
			array2[6] = text5;
			array2[6] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1149f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B439 RID: 46137 RVA: 0x0041EF2C File Offset: 0x0041D12C
	public void JFHCMEAOPPC()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.MIAGFIIILHJ), "_TimeX", new GUILayoutOption[0]);
	}

	// Token: 0x0600B43A RID: 46138 RVA: 0x0041EF98 File Offset: 0x0041D198
	public void NFKGNKJPKIB(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 71L;
		if (num == 0L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "_LutTex", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "_TileMaxLoop", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "UseFinalGlassColor", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("_Value5", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("maps.", num);
		string text3 = string.Format("menu.selectedplaymode", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, " not exist", new GUILayoutOption[1]);
			if (GUILayout.Button("a", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("\" on viewID ", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_VelocityScale", new GUILayoutOption[1]);
			text4 = "_GreenAmplifier" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "TBD" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("deletemap", new GUILayoutOption[1]);
			string format = "GameScene";
			object[] array = new object[-52];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "Cross";
			object[] array2 = new object[6];
			array2[0] = text;
			array2[0] = text2;
			array2[3] = text3;
			array2[4] = text4;
			array2[1] = text5;
			array2[1] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1921f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B43B RID: 46139 RVA: 0x0041F2DF File Offset: 0x0041D4DF
	public void JBCNIPJDPJB()
	{
		if (Input.GetKeyDown((KeyCode)(-52)) && Input.GetKey((KeyCode)(-108)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B43C RID: 46140 RVA: 0x0041F314 File Offset: 0x0041D514
	public void IDDPLCAHDPO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.FGHCDCINJFD), ":", new GUILayoutOption[1]);
	}

	// Token: 0x0600B43D RID: 46141 RVA: 0x0041F380 File Offset: 0x0041D580
	public void LIFJIJLOEFK()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GPINLMGJMKO), "DPADHOR", new GUILayoutOption[1]);
	}

	// Token: 0x0600B43E RID: 46142 RVA: 0x0041F3EC File Offset: 0x0041D5EC
	public void PPCJACOLHBJ()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.EGECCNAEECP), "_FgCocMask", new GUILayoutOption[1]);
	}

	// Token: 0x0600B43F RID: 46143 RVA: 0x0041F458 File Offset: 0x0041D658
	public void NOIHPECMDLI(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 177L;
		if (num == 0L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "offsets", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "https://steamcommunity.com/app/513510/workshop/", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "1234332714", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("menu.selectedplaymode", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Image", num);
		string text3 = string.Format("MenuScene", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_TimeX", new GUILayoutOption[0]);
			if (GUILayout.Button("id", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("EventSystem", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("wss://", new GUILayoutOption[0]);
			text4 = "< true | false >" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "float,2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("[PlayerBase] SpawnObj error: ", new GUILayoutOption[0]);
			string format = "_Value7";
			object[] array = new object[125];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_TimeX";
			object[] array2 = new object[4];
			array2[1] = text;
			array2[0] = text2;
			array2[0] = text3;
			array2[2] = text4;
			array2[2] = text5;
			array2[4] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 318f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B440 RID: 46144 RVA: 0x0041F79F File Offset: 0x0041D99F
	public void OKLAJINHPAN()
	{
		if (this.statsRect.x <= 1352f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B441 RID: 46145 RVA: 0x0041F7D3 File Offset: 0x0041D9D3
	public void DBEMDAJDDDA()
	{
		if (this.statsRect.x <= 453f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B442 RID: 46146 RVA: 0x0041F807 File Offset: 0x0041DA07
	public void JDKHBGDEONK()
	{
		if (this.statsRect.x <= 660f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B443 RID: 46147 RVA: 0x0041F83C File Offset: 0x0041DA3C
	public void KOCIIOKHKME()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.CMHIDPNNHAA), "_Value2", new GUILayoutOption[0]);
	}

	// Token: 0x0600B444 RID: 46148 RVA: 0x0041F8A8 File Offset: 0x0041DAA8
	public void ODCJJFBJJNF()
	{
		if (Input.GetKeyDown((KeyCode)(-101)) && Input.GetKey(KeyCode.N))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B445 RID: 46149 RVA: 0x0041F8DB File Offset: 0x0041DADB
	public void IIFCIDDJHPM()
	{
		if (Input.GetKeyDown((KeyCode)(-114)) && Input.GetKey((KeyCode)(-153)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B446 RID: 46150 RVA: 0x0041F910 File Offset: 0x0041DB10
	public void KKJNHIGPHJC(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -28L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "_SubsampleIndices", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "y", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "https://reddit.com/r/Intralism", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("_Gain", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(". Possible scene loading in progress?", num);
		string text3 = string.Format(". Verify the Prefab is in a Resources folder (and not in a subfolder)", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "masterSteamID", new GUILayoutOption[0]);
			if (GUILayout.Button("Delete events", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("Image", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("x", new GUILayoutOption[0]);
			text4 = "GameScene" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "ExitButton" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box(" not found", new GUILayoutOption[1]);
			string format = "SpawnObj";
			object[] array = new object[-80];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[5] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "Anime";
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[7] = text3;
			array2[0] = text4;
			array2[2] = text5;
			array2[1] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 80f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B447 RID: 46151 RVA: 0x0041FC57 File Offset: 0x0041DE57
	public void FOLDLDLFFLM()
	{
		if (Input.GetKeyDown(KeyCode.A) && Input.GetKey((KeyCode)(-103)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B448 RID: 46152 RVA: 0x0041FC8A File Offset: 0x0041DE8A
	public void MNBPNHNAEBK()
	{
		if (this.statsRect.x <= 1520f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B449 RID: 46153 RVA: 0x0041FCC0 File Offset: 0x0041DEC0
	public void FGHCDCINJFD(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -158L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "steamid", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "1234332714", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "[PlayerController] ", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format(",0", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("Set particles size", num);
		string text3 = string.Format("_MaxRayTraceDistance", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_MainTex2", new GUILayoutOption[0]);
			if (GUILayout.Button("Fade", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("notready", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("ENABLE_DITHERING", new GUILayoutOption[0]);
			text4 = "settings_bindings_sec_" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "CameraFilterPack/Blur_Dithering2x2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_Value2", new GUILayoutOption[1]);
			string format = "AppID: {0}*** GameVersion: {1} PeerId: {2} ";
			object[] array = new object[-21];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "_Contrast";
			object[] array2 = new object[2];
			array2[0] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[3] = text4;
			array2[1] = text5;
			array2[7] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 103f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B44A RID: 46154 RVA: 0x00420007 File Offset: 0x0041E207
	public void BEBNOKFLJPH()
	{
		if (this.statsRect.x <= 1300f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B44B RID: 46155 RVA: 0x0042003C File Offset: 0x0041E23C
	public void HHKCCIJMGAB()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GMOFOHLNBDK), "Creating new item...", new GUILayoutOption[1]);
	}

	// Token: 0x0600B44C RID: 46156 RVA: 0x004200A8 File Offset: 0x0041E2A8
	public void IEMEHGCFAPD()
	{
		if (Input.GetKeyDown((KeyCode)16) && Input.GetKey((KeyCode)(-123)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B44D RID: 46157 RVA: 0x004200DB File Offset: 0x0041E2DB
	public void JGMEKCFHGLE()
	{
		if (Input.GetKeyDown(KeyCode.Question) && Input.GetKey((KeyCode)(-184)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B44E RID: 46158 RVA: 0x00420110 File Offset: 0x0041E310
	public void TrafficStatsWindow(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 1000L;
		if (num == 0L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "buttons", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "health", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "traffic", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("Out {0,4} | In {1,4} | Sum {2,4}", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("{0}sec average:", num);
		string text3 = string.Format("Out {0,4} | In {1,4} | Sum {2,4}", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "stats on", new GUILayoutOption[0]);
			if (GUILayout.Button("Reset", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("To Log", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("Traffic Stats", new GUILayoutOption[0]);
			text4 = "Incoming: \n" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Outgoing: \n" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("Health Stats", new GUILayoutOption[0]);
			text6 = string.Format("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", new object[]
			{
				trafficStatsGameLevel.LongestDeltaBetweenSending,
				trafficStatsGameLevel.LongestDeltaBetweenDispatching,
				trafficStatsGameLevel.LongestEventCallback,
				trafficStatsGameLevel.LongestEventCallbackCode,
				trafficStatsGameLevel.LongestOpResponseCallback,
				trafficStatsGameLevel.LongestOpResponseCallbackOpCode,
				PhotonNetwork.JNJJAMNLOHA.RoundTripTime,
				PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance,
				PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands
			});
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string message = string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", new object[]
			{
				text,
				text2,
				text3,
				text4,
				text5,
				text6
			});
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 100f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B44F RID: 46159 RVA: 0x00420458 File Offset: 0x0041E658
	public void IJFOOJMMMDA(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 170L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "accuracy", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "mapselector.filter.subscribedonly", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_Green_C", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("#ok", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("OnStatusChanged: {0} current State: {1}", num);
		string text3 = string.Format("_BlurCoe", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_SpherePositionY", new GUILayoutOption[1]);
			if (GUILayout.Button("/", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("maps.", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("init", new GUILayoutOption[0]);
			text4 = "JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster." + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_MainTex2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_Blue_R", new GUILayoutOption[0]);
			string format = "BitsData";
			object[] array = new object[-61];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_TimeX";
			object[] array2 = new object[4];
			array2[0] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[5] = text4;
			array2[1] = text5;
			array2[0] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 231f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B450 RID: 46160 RVA: 0x0042079F File Offset: 0x0041E99F
	public void EHJJFJCKGAJ()
	{
		if (Input.GetKeyDown((KeyCode)70) && Input.GetKey((KeyCode)20))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B451 RID: 46161 RVA: 0x004207D4 File Offset: 0x0041E9D4
	public void AHFNKCIBLIN(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 12L;
		if (num == 0L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, " not exist", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, " SecondsBeforeRespawn: ", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "Tab2Content", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("GenerationMenu", num);
		string text3 = string.Format("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "offsets", new GUILayoutOption[0]);
			if (GUILayout.Button(" : ", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("_ScreenResolution", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_Red_R", new GUILayoutOption[1]);
			text4 = "CameraFilterPack/Color_Switching" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "<color=white>" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("/icon", new GUILayoutOption[0]);
			string format = "mapselector.filter.subscribedonly";
			object[] array = new object[98];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_ScreenResolution";
			object[] array2 = new object[7];
			array2[0] = text;
			array2[0] = text2;
			array2[5] = text3;
			array2[6] = text4;
			array2[7] = text5;
			array2[2] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 839f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B452 RID: 46162 RVA: 0x00420B1B File Offset: 0x0041ED1B
	public void KIEJKBNBHMD()
	{
		if (Input.GetKeyDown((KeyCode)75) && Input.GetKey((KeyCode)(-168)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B453 RID: 46163 RVA: 0x00420B4E File Offset: 0x0041ED4E
	public void HMNLHMLILKD()
	{
		if (Input.GetKeyDown(KeyCode.Alpha9) && Input.GetKey((KeyCode)2))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B454 RID: 46164 RVA: 0x00420B81 File Offset: 0x0041ED81
	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B455 RID: 46165 RVA: 0x00420BB4 File Offset: 0x0041EDB4
	public void IGPCNCJIEOJ()
	{
		if (this.statsRect.x <= 562f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B456 RID: 46166 RVA: 0x00420BE8 File Offset: 0x0041EDE8
	public void EAHKLHCEDLB()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.AHFNKCIBLIN), "_CurveParams", new GUILayoutOption[1]);
	}

	// Token: 0x0600B457 RID: 46167 RVA: 0x00420C54 File Offset: 0x0041EE54
	public void FLLEIMBAAAH(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 42L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "Connection error: ", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "Joystick1Button4", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "PLAY [SPACE]", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("Left", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("SlidingArea", num);
		string text3 = string.Format("[ItemsHandler] Inventory has changed", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_DotSize", new GUILayoutOption[1]);
			if (GUILayout.Button("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("EventSystem", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("Inside cells:\n", new GUILayoutOption[0]);
			text4 = "settings.shaders.bloomintencity" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "CameraFilterPack/Color_YUV" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("offsets", new GUILayoutOption[1]);
			string format = "_DotSize";
			object[] array = new object[-56];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[7] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "Exception while connecting to: ";
			object[] array2 = new object[]
			{
				text
			};
			array2[0] = text2;
			array2[0] = text3;
			array2[7] = text4;
			array2[4] = text5;
			array2[8] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 898f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B458 RID: 46168 RVA: 0x00420F9B File Offset: 0x0041F19B
	public void AEDDNDHCLNN()
	{
		if (this.statsRect.x <= 521f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B459 RID: 46169 RVA: 0x00420FCF File Offset: 0x0041F1CF
	public void HLIAEEMGBHN()
	{
		if (this.statsRect.x <= 449f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B45A RID: 46170 RVA: 0x00421004 File Offset: 0x0041F204
	public void CNAFKDEAAGD(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -64L;
		if (num == 0L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "caret", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "To {0} at Index {1} \n", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "EXCEPTION:", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("Object ID. Case-Sensitive", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("]", num);
		string text3 = string.Format("_TimeX", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "RateButton", new GUILayoutOption[0]);
			if (GUILayout.Button("HightScoreMaxPointsText", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("]. Please verify you have this gameobject in a Resources folder.", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("MenuScene", new GUILayoutOption[1]);
			text4 = "menu.selectedplaymode" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_NoiseTex" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_BlurCoe", new GUILayoutOption[0]);
			string format = "#ok";
			object[] array = new object[-85];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[3] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "0";
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[4] = text3;
			array2[6] = text4;
			array2[3] = text5;
			array2[6] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 489f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B45B RID: 46171 RVA: 0x0042134C File Offset: 0x0041F54C
	public void JODODFGLOLD()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.NNFMGBNMFFH), "mapselector.filter.subscribedonly", new GUILayoutOption[0]);
	}

	// Token: 0x0600B45C RID: 46172 RVA: 0x004213B8 File Offset: 0x0041F5B8
	public void JDGFCEPDKAJ()
	{
		if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.M))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B45D RID: 46173 RVA: 0x004213EB File Offset: 0x0041F5EB
	public void AEMGPJDJGBJ()
	{
		if (this.statsRect.x <= 1261f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B45E RID: 46174 RVA: 0x0042141F File Offset: 0x0041F61F
	public void LMADKINICIN()
	{
		if (Input.GetKeyDown(KeyCode.DoubleQuote) && Input.GetKey(KeyCode.Colon))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B45F RID: 46175 RVA: 0x00421454 File Offset: 0x0041F654
	public void JABMMIMOJMJ()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.OKEPACMIAGF), "Edited hands count", new GUILayoutOption[0]);
	}

	// Token: 0x0600B460 RID: 46176 RVA: 0x004214C0 File Offset: 0x0041F6C0
	public void AFOKJPBHIEG()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.DHFEODCFJDP), "finished", new GUILayoutOption[0]);
	}

	// Token: 0x0600B461 RID: 46177 RVA: 0x0042152C File Offset: 0x0041F72C
	public void GPINLMGJMKO(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 156L;
		if (num == 0L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "CloseConnection: No such player connected!", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "s", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_ScreenResolution", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("}", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("isBunned", num);
		string text3 = string.Format("x", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "yyyy-MM-dd HH:mm:ss", new GUILayoutOption[1]);
			if (GUILayout.Button(" joined", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("http", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("SupportLogger OnFailedToConnectToPhoton(", new GUILayoutOption[0]);
			text4 = "(\\[ */ *h1 *\\])" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "RateButton" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("OpSettings()", new GUILayoutOption[1]);
			string format = "CameraFilterPack/Distortion_Half_Sphere";
			object[] array = new object[-88];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[3] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "Myst";
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[5] = text4;
			array2[4] = text5;
			array2[5] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1892f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B462 RID: 46178 RVA: 0x00421873 File Offset: 0x0041FA73
	public void KNBJBNDGCIJ()
	{
		if (this.statsRect.x <= 1643f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B463 RID: 46179 RVA: 0x004218A8 File Offset: 0x0041FAA8
	public void JOINFIDKFCG(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 199L;
		if (num == 0L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "RecordButton", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "Remove Environment Object", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "Tab2Content", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Added checkpoint", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(" does not exist!", num);
		string text3 = string.Format("CameraFilterPack/Glasses_On", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_Value2", new GUILayoutOption[0]);
			if (GUILayout.Button("_TimeX", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("[PlayerController] ", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_VelocityTex", new GUILayoutOption[0]);
			text4 = "_Value6" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "settings.shaders.bloomintencity" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("ScoreText", new GUILayoutOption[1]);
			string format = "_FixDistance";
			object[] array = new object[-18];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_GlowColor";
			object[] array2 = new object[5];
			array2[1] = text;
			array2[0] = text2;
			array2[8] = text3;
			array2[0] = text4;
			array2[0] = text5;
			array2[3] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 174f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B464 RID: 46180 RVA: 0x00421BF0 File Offset: 0x0041FDF0
	public void OLGIPJAFKOJ(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -139L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "CameraFilterPack/Blend2Camera_Luminosity", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "_TimeX", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "No font defined. Found font: ", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("ENABLE_COLOR_GRADING", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("ControllerRightX", num);
		string text3 = string.Format("finished", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "ItemsCountText", new GUILayoutOption[1]);
			if (GUILayout.Button("[ResourcesManager] Load image error: ", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("#", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("[MenuScene] Error: ", new GUILayoutOption[0]);
			text4 = "PunPickup" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_SunPosition" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("maps.", new GUILayoutOption[1]);
			string format = "Connection error: ";
			object[] array = new object[-58];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_ScreenResolution";
			object[] array2 = new object[]
			{
				text,
				text2,
				null,
				null,
				text3
			};
			array2[4] = text4;
			array2[8] = text5;
			array2[1] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 846f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B465 RID: 46181 RVA: 0x00421F38 File Offset: 0x00420138
	public void MLFACDCDMAL()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.MKPKOEENFND), "Save level before uploading?", new GUILayoutOption[1]);
	}

	// Token: 0x0600B466 RID: 46182 RVA: 0x00421FA4 File Offset: 0x004201A4
	public void DOFDGBGEDFI()
	{
		if (this.statsRect.x <= 1510f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B467 RID: 46183 RVA: 0x00421FD8 File Offset: 0x004201D8
	public void LIBGAKMKHJJ()
	{
		if (this.statsRect.x <= 1340f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B468 RID: 46184 RVA: 0x0042200C File Offset: 0x0042020C
	public void HILFMJPALJH(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -38L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "_TimeX", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "settings.crosshairopacity", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "Bad parameters for setint! Use <key> <value>", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Scale environment object by the values", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("SelectorMapsCountSlider", num);
		string text3 = string.Format("\n", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_AdaptationSpeed", new GUILayoutOption[0]);
			if (GUILayout.Button("#no", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("Error: I/O Failure! :(", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("Prints the number of logs currently held by DebugLogs", new GUILayoutOption[1]);
			text4 = "workshop." + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "[NetworkManager] Joined room with " + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("GridDataArcs", new GUILayoutOption[1]);
			string format = "Checkpoint";
			object[] array = new object[54];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[0] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "Using Stopwatch as precision timer for PUN.";
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[7] = text3;
			array2[5] = text4;
			array2[7] = text5;
			array2[2] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 705f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B469 RID: 46185 RVA: 0x00422354 File Offset: 0x00420554
	public void IFDFLGHEONF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.OKEPACMIAGF), "_FgOverlap", new GUILayoutOption[0]);
	}

	// Token: 0x0600B46A RID: 46186 RVA: 0x004223C0 File Offset: 0x004205C0
	public void FMNPFCHBLJF()
	{
		if (this.statsRect.x <= 426f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B46B RID: 46187 RVA: 0x004223F4 File Offset: 0x004205F4
	public void GIPHJOKGPMO(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -27L;
		if (num == 0L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "\\\\", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "Jit ", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_MainTex", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("settings_bindings_controller_type", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("event", num);
		string text3 = string.Format("_TimeX", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, " GameServer:", new GUILayoutOption[1]);
			if (GUILayout.Button("The shader ", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("float,0", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("Operation ", new GUILayoutOption[0]);
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "LevelProgressBar" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("MenuScene", new GUILayoutOption[0]);
			string format = "float,1.5";
			object[] array = new object[-91];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "TwoHands";
			object[] array2 = new object[5];
			array2[1] = text;
			array2[0] = text2;
			array2[1] = text3;
			array2[0] = text4;
			array2[6] = text5;
			array2[1] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 483f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B46C RID: 46188 RVA: 0x0042273B File Offset: 0x0042093B
	public void JOPCCCCHNLI()
	{
		if (this.statsRect.x <= 683f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B46D RID: 46189 RVA: 0x0042276F File Offset: 0x0042096F
	public void ALJEJJCIMJN()
	{
		if (this.statsRect.x <= 698f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B46E RID: 46190 RVA: 0x004227A4 File Offset: 0x004209A4
	public void DENGAACEDJC(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 114L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "\" on viewID ", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "EndlessLoopsScoreText", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, ".completedMaps", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_ToneCurve", num);
		string text3 = string.Format("CameraFilterPack/Colors_Adjust_PreFilters", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "CameraFilterPack/TV_Noise", new GUILayoutOption[1]);
			if (GUILayout.Button("MenuScene", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("_CenterX", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_Speed", new GUILayoutOption[0]);
			text4 = "_ThirdTex" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "1332644700" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box(" ; ", new GUILayoutOption[0]);
			string format = "_Distortion";
			object[] array = new object[-95];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ";
			object[] array2 = new object[4];
			array2[0] = text;
			array2[1] = text2;
			array2[3] = text3;
			array2[4] = text4;
			array2[3] = text5;
			array2[0] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1104f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B46F RID: 46191 RVA: 0x00422AEB File Offset: 0x00420CEB
	public void KMKLDAJLCNM()
	{
		if (Input.GetKeyDown((KeyCode)(-69)) && Input.GetKey((KeyCode)(-144)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B470 RID: 46192 RVA: 0x00422B20 File Offset: 0x00420D20
	public void OLFFIKHJIEO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GPINLMGJMKO), "PS Home", new GUILayoutOption[1]);
	}

	// Token: 0x0600B471 RID: 46193 RVA: 0x00422B8C File Offset: 0x00420D8C
	public void EPEGAEGDJAM()
	{
		if (this.statsRect.x <= 342f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B472 RID: 46194 RVA: 0x00422BC0 File Offset: 0x00420DC0
	public void AEIJFLJEABG()
	{
		if (Input.GetKeyDown((KeyCode)(-7)) && Input.GetKey((KeyCode)131))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B473 RID: 46195 RVA: 0x00422BF4 File Offset: 0x00420DF4
	public void ELOFOJIJFFA(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -189L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, ": ", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, ".lastCheckpoint.correctScore", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "time", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("</color>", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Threshhold", num);
		string text3 = string.Format("x", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", new GUILayoutOption[1]);
			if (GUILayout.Button("maps.", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("_ReflectionTexture3", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("[LobbyPlayerElement] On ready click", new GUILayoutOption[0]);
			text4 = "_Offsets" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("[DiscordController] Init", new GUILayoutOption[0]);
			string format = "BitsData";
			object[] array = new object[-96];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[0] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = ".png";
			object[] array2 = new object[]
			{
				null,
				text
			};
			array2[0] = text2;
			array2[6] = text3;
			array2[3] = text4;
			array2[1] = text5;
			array2[7] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1298f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B474 RID: 46196 RVA: 0x00422F3C File Offset: 0x0042113C
	public void CPJBNBJMJFA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.HILFMJPALJH), "_ScreenResolution", new GUILayoutOption[0]);
	}

	// Token: 0x0600B475 RID: 46197 RVA: 0x00422FA8 File Offset: 0x004211A8
	public void EHHEKBPCDOH()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.DHFEODCFJDP), "NEW", new GUILayoutOption[1]);
	}

	// Token: 0x0600B476 RID: 46198 RVA: 0x00423014 File Offset: 0x00421214
	public void IKIDIJLIGOH()
	{
		if (Input.GetKeyDown(KeyCode.T) && Input.GetKey((KeyCode)136))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B478 RID: 46200 RVA: 0x00423084 File Offset: 0x00421284
	public void MMPHNFPPEHO()
	{
		if (this.statsRect.x <= 477f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B479 RID: 46201 RVA: 0x004230B8 File Offset: 0x004212B8
	public void DFFKKLAPHCC()
	{
		if (this.statsRect.x <= 1182f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B47A RID: 46202 RVA: 0x004230EC File Offset: 0x004212EC
	public void OKEPOJNDCHO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.MIAGFIIILHJ), "[Down]", new GUILayoutOption[1]);
	}

	// Token: 0x0600B47B RID: 46203 RVA: 0x00423158 File Offset: 0x00421358
	public void EEPEAEEEPMK(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 80L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "menu.playedsolo", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "_Radius", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_TimeX", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("menuthemes", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("%", num);
		string text3 = string.Format("_Value3", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "settings.showHP", new GUILayoutOption[1]);
			if (GUILayout.Button("LevelProgressBar", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Editor/", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("CameraFilterPack/FX_Psycho", new GUILayoutOption[0]);
			text4 = "/?player=" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "SetSatelliteLerpSpeed" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("\\", new GUILayoutOption[1]);
			string format = "?";
			object[] array = new object[11];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "G:";
			object[] array2 = new object[3];
			array2[1] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[0] = text4;
			array2[6] = text5;
			array2[6] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1349f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B47C RID: 46204 RVA: 0x0042349F File Offset: 0x0042169F
	public void BGDONBMDPGM()
	{
		if (Input.GetKeyDown(KeyCode.K) && Input.GetKey((KeyCode)(-166)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B47D RID: 46205 RVA: 0x004234D4 File Offset: 0x004216D4
	public void MDBEPCKAJFP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.DHFEODCFJDP), "Message duration multiplier. Recomended 1", new GUILayoutOption[0]);
	}

	// Token: 0x0600B47E RID: 46206 RVA: 0x00423540 File Offset: 0x00421740
	public void CDLHBDMJAJI()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.DENGAACEDJC), "bad", new GUILayoutOption[0]);
	}

	// Token: 0x0600B47F RID: 46207 RVA: 0x004235AC File Offset: 0x004217AC
	public void EJJMMCLNCKA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GMOFOHLNBDK), ".", new GUILayoutOption[1]);
	}

	// Token: 0x0600B480 RID: 46208 RVA: 0x00423618 File Offset: 0x00421818
	public void APKNAPHOFHC()
	{
		if (Input.GetKeyDown(KeyCode.Delete) && Input.GetKey(KeyCode.Alpha3))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B481 RID: 46209 RVA: 0x0042364C File Offset: 0x0042184C
	public void NGHMCPOJIOO(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -174L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "CameraFilterPack/Glasses_OnX", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "settings.crosshairopacity", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "player.orangelifering", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("_Blue_B", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_ScreenResolution", num);
		string text3 = string.Format("_MainTex2", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_ScreenResolution", new GUILayoutOption[1]);
			if (GUILayout.Button("<b><i>Map's Stats:</i></b>", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("#", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("|", new GUILayoutOption[1]);
			text4 = "Fade" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_Convolved_TexelSize", new GUILayoutOption[1]);
			string format = "RarityImage";
			object[] array = new object[-42];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[1] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "{\"items\":";
			object[] array2 = new object[0];
			array2[0] = text;
			array2[1] = text2;
			array2[6] = text3;
			array2[2] = text4;
			array2[8] = text5;
			array2[7] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 365f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B482 RID: 46210 RVA: 0x00423993 File Offset: 0x00421B93
	public void ECBILENEOOL()
	{
		if (this.statsRect.x <= 1090f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B483 RID: 46211 RVA: 0x004239C7 File Offset: 0x00421BC7
	public void MAOCOEGAFND()
	{
		if (Input.GetKeyDown((KeyCode)23) && Input.GetKey((KeyCode)84))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B484 RID: 46212 RVA: 0x004239FC File Offset: 0x00421BFC
	public void LGMADMDBKNE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GMOFOHLNBDK), "_TimeX", new GUILayoutOption[0]);
	}

	// Token: 0x0600B485 RID: 46213 RVA: 0x00423A68 File Offset: 0x00421C68
	public void LEKGHGJPIJE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.MKPKOEENFND), "_VelTex", new GUILayoutOption[0]);
	}

	// Token: 0x0600B486 RID: 46214 RVA: 0x00420BB4 File Offset: 0x0041EDB4
	public void JECMJNFGBGC()
	{
		if (this.statsRect.x <= 562f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B487 RID: 46215 RVA: 0x00423AD4 File Offset: 0x00421CD4
	public void INODCHEOKGF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.DIFKPMBNIIA), "[ItemsHandler] Found ", new GUILayoutOption[0]);
	}

	// Token: 0x0600B488 RID: 46216 RVA: 0x00423B40 File Offset: 0x00421D40
	public void NDAJBJFJGCF()
	{
		if (Input.GetKeyDown((KeyCode)(-116)) && Input.GetKey((KeyCode)(-58)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B489 RID: 46217 RVA: 0x00423B73 File Offset: 0x00421D73
	public void FOMNCPKKCFN()
	{
		if (Input.GetKeyDown((KeyCode)(-88)) && Input.GetKey((KeyCode)75))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B48A RID: 46218 RVA: 0x00423BA8 File Offset: 0x00421DA8
	public void KNKOCAKPJKF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.CMHIDPNNHAA), "#random #epic #item", new GUILayoutOption[1]);
	}

	// Token: 0x0600B48B RID: 46219 RVA: 0x00423C14 File Offset: 0x00421E14
	public void OnGUI()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.TrafficStatsWindow), "Messages (shift+tab)", new GUILayoutOption[0]);
	}

	// Token: 0x0600B48C RID: 46220 RVA: 0x00423C80 File Offset: 0x00421E80
	public void PLDAMMNBJFE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.MKPKOEENFND), "Prints list of all previous commands", new GUILayoutOption[1]);
	}

	// Token: 0x0600B48D RID: 46221 RVA: 0x00423CEC File Offset: 0x00421EEC
	public void CEDFFAOOPOG()
	{
		if (this.statsRect.x <= 1714f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B48E RID: 46222 RVA: 0x00423D20 File Offset: 0x00421F20
	public void PKLOBJHKFEO()
	{
		if (this.statsRect.x <= 469f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B48F RID: 46223 RVA: 0x00423D54 File Offset: 0x00421F54
	public void NDBPCNICGLC()
	{
		if (this.statsRect.x <= 1188f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B490 RID: 46224 RVA: 0x00423D88 File Offset: 0x00421F88
	public void HCABOHEKHKF(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -122L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "_Colorisation", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "_TimeX", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_Value", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("Alternative", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("CompletedLevel", num);
		string text3 = string.Format("settings.enablerankingnotifications", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_Value5", new GUILayoutOption[1]);
			if (GUILayout.Button("_Parameter", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_FlipAlphaMask", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_ProjInfo", new GUILayoutOption[1]);
			text4 = "_Value2" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "GameScene" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_Near", new GUILayoutOption[0]);
			string format = "settings.arcsnohitsoundtimedelay";
			object[] array = new object[91];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_TimeX";
			object[] array2 = new object[]
			{
				null,
				text
			};
			array2[1] = text2;
			array2[8] = text3;
			array2[1] = text4;
			array2[6] = text5;
			array2[2] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 732f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B491 RID: 46225 RVA: 0x004240CF File Offset: 0x004222CF
	public void ANKIJGCGCBF()
	{
		if (Input.GetKeyDown((KeyCode)(-61)) && Input.GetKey((KeyCode)(-190)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B492 RID: 46226 RVA: 0x00424104 File Offset: 0x00422304
	public void GMOFOHLNBDK(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 187L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "_History4ChromaTex", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "_EmissionColor", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("In Network lobby", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("settings.shaders.bloomintencity", num);
		string text3 = string.Format("_NoiseTex", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "CameraFilterPack/Glasses_On", new GUILayoutOption[1]);
			if (GUILayout.Button("maps.", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("music", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("Needs to be attached to the Event System component in the scene", new GUILayoutOption[0]);
			text4 = "map.data" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_LoopCount" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("cipherText", new GUILayoutOption[1]);
			string format = "ENABLE_USER_LUT";
			object[] array = new object[-114];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_Fade";
			object[] array2 = new object[]
			{
				null,
				text
			};
			array2[0] = text2;
			array2[8] = text3;
			array2[5] = text4;
			array2[3] = text5;
			array2[5] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1499f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B493 RID: 46227 RVA: 0x0042444B File Offset: 0x0042264B
	public void FIKFJDFELIP()
	{
		if (this.statsRect.x <= 1010f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B494 RID: 46228 RVA: 0x00424480 File Offset: 0x00422680
	public void OKEPACMIAGF(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 146L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "y", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, ".icon", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "[RanksSystem] Init", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("Ignored PU RPC, cause item is inactive. ", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("CameraFilterPack/Vision_Tunnel", num);
		string text3 = string.Format("_Speed", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "menu.playedpage", new GUILayoutOption[0]);
			if (GUILayout.Button("_Value", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("Object ID. Case-Sensitive", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("kick", new GUILayoutOption[0]);
			text4 = "Classical" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Source" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box(" has no method \"", new GUILayoutOption[1]);
			string format = "Joystick";
			object[] array = new object[-32];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[4] = trafficStatsGameLevel.LongestEventCallback;
			array[5] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[0] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "...";
			object[] array2 = new object[7];
			array2[0] = text;
			array2[1] = text2;
			array2[2] = text3;
			array2[3] = text4;
			array2[0] = text5;
			array2[2] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 549f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B495 RID: 46229 RVA: 0x004247C7 File Offset: 0x004229C7
	public void HIPBNBKNICE()
	{
		if (Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKey((KeyCode)(-188)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B496 RID: 46230 RVA: 0x004247FC File Offset: 0x004229FC
	public void FCEAHFFGLIE(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -179L;
		if (num == 0L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "R1", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "Hex value #RRGGBB", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "GhostFade2", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("grid", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_TimeX", num);
		string text3 = string.Format("#C8C8C8FF", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_TimeX", new GUILayoutOption[1]);
			if (GUILayout.Button("L2", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("CameraFilterPack/Vision_Rainbow", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("maps.", new GUILayoutOption[1]);
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Dec" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("Working.\nPlease wait..", new GUILayoutOption[0]);
			string format = "JITTER";
			object[] array = new object[-111];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[3] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "_ScreenResolution";
			object[] array2 = new object[5];
			array2[1] = text;
			array2[1] = text2;
			array2[7] = text3;
			array2[8] = text4;
			array2[8] = text5;
			array2[7] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 697f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B497 RID: 46231 RVA: 0x00424B44 File Offset: 0x00422D44
	public void ELMOEFJHMAN()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.FLLEIMBAAAH), "_PColor", new GUILayoutOption[1]);
	}

	// Token: 0x0600B498 RID: 46232 RVA: 0x00424BB0 File Offset: 0x00422DB0
	public void COHFJLIPGMI(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 183L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "EventData0DropDownList", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "x", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "Failed to Instantiate prefab: ", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("set environment id", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("UseScanLine", num);
		string text3 = string.Format("Left Stick Click", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "settings_bindings_sec_", new GUILayoutOption[1]);
			if (GUILayout.Button("_Glitch", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_MainTex2", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("note.7", new GUILayoutOption[0]);
			text4 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "GhostFade" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_Exponent", new GUILayoutOption[1]);
			string format = "closed";
			object[] array = new object[-86];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[5] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[4] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "[LevelEditorScene] Print Audio Wave: Done";
			object[] array2 = new object[5];
			array2[0] = text;
			array2[0] = text2;
			array2[5] = text3;
			array2[0] = text4;
			array2[8] = text5;
			array2[1] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1456f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B499 RID: 46233 RVA: 0x00424EF8 File Offset: 0x004230F8
	public void LGHNKDFEOKO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GMOFOHLNBDK), "settings.disablestoryboard", new GUILayoutOption[0]);
	}

	// Token: 0x0600B49A RID: 46234 RVA: 0x00424F64 File Offset: 0x00423164
	public void IPDCBNCBBEN()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.CNAFKDEAAGD), "BloomShaderValueSlider", new GUILayoutOption[0]);
	}

	// Token: 0x0600B49B RID: 46235 RVA: 0x00424FD0 File Offset: 0x004231D0
	public void FEDMNHEFFBM(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / 137L;
		if (num == 0L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "/files/editor_manual.pdf", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "CameraFilterPack/Glasses_On", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_CameraClipInfo", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("#.##", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("\t", num);
		string text3 = string.Format("_SizeX", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_InvRenderTargetSize", new GUILayoutOption[0]);
			if (GUILayout.Button("_Near", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button(" (", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("error", new GUILayoutOption[1]);
			text4 = "&" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "challengeid" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_ScreenResolution", new GUILayoutOption[0]);
			string format = "_Rand";
			object[] array = new object[-105];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[6] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[2] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "CameraFilterPack/TV_Vintage";
			object[] array2 = new object[]
			{
				text,
				text2,
				null,
				null,
				null,
				text3
			};
			array2[5] = text4;
			array2[0] = text5;
			array2[3] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 539f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B49C RID: 46236 RVA: 0x00425318 File Offset: 0x00423518
	public void NNFMGBNMFFH(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -104L;
		if (num == 1L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "Anomaly_Distortion", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "SpectatingUserInfo", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "Exit to menu?", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("_TimeX", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("DPADVER", num);
		string text3 = string.Format("Start Color's hex value #RRGGBBAA", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "SetSpeed", new GUILayoutOption[0]);
			if (GUILayout.Button("CameraFilterPack/TV_VHS_Rewind", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("Fade", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("-1", new GUILayoutOption[1]);
			text4 = "_TimeX" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Value" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("#", new GUILayoutOption[0]);
			string format = "KickThePlayer";
			object[] array = new object[19];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[6] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[0] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[3] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "FinishMap";
			object[] array2 = new object[4];
			array2[0] = text;
			array2[1] = text2;
			array2[0] = text3;
			array2[7] = text4;
			array2[3] = text5;
			array2[8] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 309f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B49D RID: 46237 RVA: 0x00425660 File Offset: 0x00423860
	public void JFDIAAOJJEA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.MIAGFIIILHJ), "_TimeX", new GUILayoutOption[0]);
	}

	// Token: 0x0600B49E RID: 46238 RVA: 0x004256CC File Offset: 0x004238CC
	public void MIAGFIIILHJ(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -77L;
		if (num == 0L)
		{
			num = 0L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "value", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "y", new GUILayoutOption[1]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_MaxVelocity", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("OpChangeGroups()", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format(":", num);
		string text3 = string.Format("[PlayerController] ", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, " = ", new GUILayoutOption[0]);
			if (GUILayout.Button("_TimeX", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_TimeX", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_TimeX", new GUILayoutOption[0]);
			text4 = "CameraFilterPack/Blend2Camera_LighterColor" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_Value" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_SizeX", new GUILayoutOption[1]);
			string format = "CameraFilterPack/Gradients_FireGradient";
			object[] array = new object[]
			{
				trafficStatsGameLevel.LongestDeltaBetweenSending
			};
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[2] = trafficStatsGameLevel.LongestEventCallback;
			array[0] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[2] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[7] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "maps.";
			object[] array2 = new object[4];
			array2[1] = text;
			array2[1] = text2;
			array2[8] = text3;
			array2[1] = text4;
			array2[4] = text5;
			array2[8] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1604f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B49F RID: 46239 RVA: 0x00425A13 File Offset: 0x00423C13
	public void NFEDLAOPHML()
	{
		if (Input.GetKeyDown((KeyCode)30) && Input.GetKey((KeyCode)(-75)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B4A0 RID: 46240 RVA: 0x00425A48 File Offset: 0x00423C48
	public void DIFKPMBNIIA(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -103L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, ",", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "/files/mods_terms.pdf", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, ". Client is not the MasterClient in this room.", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("_Size", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_Value", num);
		string text3 = string.Format("CameraFilterPack/Vision_Rainbow", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "_TimeX", new GUILayoutOption[1]);
			if (GUILayout.Button("_Distortion", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("SetPosition", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("FinalScoreText", new GUILayoutOption[1]);
			text4 = "[SoundManager] Loaded skin audio" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = ". Going to authenticate anyways." + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_TimeX", new GUILayoutOption[1]);
			string format = "CameraFilterPack/Blend2Camera_Lighten";
			object[] array = new object[-58];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[3] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[1] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[3] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "Tab1Content";
			object[] array2 = new object[5];
			array2[0] = text;
			array2[1] = text2;
			array2[5] = text3;
			array2[2] = text4;
			array2[7] = text5;
			array2[6] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1134f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B4A1 RID: 46241 RVA: 0x00425D8F File Offset: 0x00423F8F
	public void OEENOOGEEHD()
	{
		if (Input.GetKeyDown((KeyCode)89) && Input.GetKey((KeyCode)(-88)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B4A2 RID: 46242 RVA: 0x00425DC2 File Offset: 0x00423FC2
	public void DKOPKPBLDHH()
	{
		if (this.statsRect.x <= 374f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4A3 RID: 46243 RVA: 0x00425DF6 File Offset: 0x00423FF6
	public void IBHACCEEFFI()
	{
		if (Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKey((KeyCode)(-173)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B4A4 RID: 46244 RVA: 0x00425E2C File Offset: 0x0042402C
	public void FBGCMIJBLJF(int KJNKDKDDCIE)
	{
		bool flag = false;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -198L;
		if (num == 0L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "X", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "CameraFilterPack/Blend2Camera_ColorKey", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "Joystick1Button0", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("Set Trail Zoom Speed", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("[RanksSystem] Init", num);
		string text3 = string.Format("CameraFilterPack/AAA_BloodOnScreen", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "CameraFilterPack/Blend2Camera_LinearLight", new GUILayoutOption[0]);
			if (GUILayout.Button("CameraFilterPack/Drawing_EnhancedComics", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button("_Value3", new GUILayoutOption[0]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("Set Trail Zoom Speed", new GUILayoutOption[1]);
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "menu.selectedlevelid" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[0]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new GUILayoutOption[1]);
			string format = "_MaxRayTraceDistance";
			object[] array = new object[-40];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[0] = trafficStatsGameLevel.LongestEventCallback;
			array[7] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[0] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[6] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "Bad parameters for getbool! Use <key> <value>";
			object[] array2 = new object[6];
			array2[1] = text;
			array2[1] = text2;
			array2[3] = text3;
			array2[8] = text4;
			array2[3] = text5;
			array2[8] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 201f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B4A5 RID: 46245 RVA: 0x00426174 File Offset: 0x00424374
	public void EGECCNAEECP(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -127L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[1]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "z", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, " ; ", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "_Value2", new GUILayoutOption[1]);
		GUILayout.EndHorizontal();
		string text = string.Format("Anomaly_Distortion", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("STICKRHOR", num);
		string text3 = string.Format("GlassAberration", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[1]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "\"", new GUILayoutOption[1]);
			if (GUILayout.Button("_Value2", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("CameraFilterPack/Distortion_ShockWave", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("[MapEditor] Reset", new GUILayoutOption[0]);
			text4 = "_ScreenResolution" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "Turn" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("_TimeX", new GUILayoutOption[0]);
			string format = "_Value2";
			object[] array = new object[-32];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[8] = trafficStatsGameLevel.LongestEventCallback;
			array[8] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[5] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[1] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[5] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[6] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "_Value3";
			object[] array2 = new object[]
			{
				null,
				text
			};
			array2[0] = text2;
			array2[4] = text3;
			array2[3] = text4;
			array2[6] = text5;
			array2[0] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1724f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B4A6 RID: 46246 RVA: 0x004264BC File Offset: 0x004246BC
	public void EAHGDNIEPKP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.FEDMNHEFFBM), "checkpoint", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4A7 RID: 46247 RVA: 0x00426528 File Offset: 0x00424728
	public void DHFEODCFJDP(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -16L;
		if (num == 0L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "_Value3", new GUILayoutOption[0]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "menu.selectedlevelid", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "BitsData", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("#ok", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("_TimeX", num);
		string text3 = string.Format("OK", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[0]);
		GUILayout.Label(text3, new GUILayoutOption[0]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[1]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "GlassDistortion", new GUILayoutOption[0]);
			if (GUILayout.Button("Joystick1Button7", new GUILayoutOption[1]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = false;
			}
			flag = GUILayout.Button("QuickSave", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("_ScreenResolution", new GUILayoutOption[0]);
			text4 = "duration" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = "_PositionY" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[1]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("challenges/", new GUILayoutOption[1]);
			string format = "_SpotSize";
			object[] array = new object[61];
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[1] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[8] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[6] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[4] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[8] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[1]);
		}
		if (flag)
		{
			string format2 = "_TintColor";
			object[] array2 = new object[]
			{
				null,
				text
			};
			array2[1] = text2;
			array2[1] = text3;
			array2[2] = text4;
			array2[0] = text5;
			array2[0] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1263f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B4A8 RID: 46248 RVA: 0x00426870 File Offset: 0x00424A70
	public void CMEJNBPFGHP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.KKJNHIGPHJC), "CameraFilterPack/3D_Inverse", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4A9 RID: 46249 RVA: 0x004268DC File Offset: 0x00424ADC
	public void FFJMMBGFDMD()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.IJFOOJMMMDA), "menu.tabid", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4AA RID: 46250 RVA: 0x00426948 File Offset: 0x00424B48
	public void KDJEJBBDILE()
	{
		if (Input.GetKeyDown((KeyCode)(-105)) && Input.GetKey(KeyCode.K))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B4AB RID: 46251 RVA: 0x0042697B File Offset: 0x00424B7B
	public void CNGAJDBOCLJ()
	{
		if (this.statsRect.x <= 459f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4AC RID: 46252 RVA: 0x004269B0 File Offset: 0x00424BB0
	public void BOGBNJJMFOK()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.OKEPACMIAGF), "#", new GUILayoutOption[0]);
	}

	// Token: 0x0600B4AD RID: 46253 RVA: 0x00426A1C File Offset: 0x00424C1C
	public void JKBMKPDGCHG()
	{
		if (this.statsRect.x <= 1550f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4AE RID: 46254 RVA: 0x00426A50 File Offset: 0x00424C50
	public void CMHIDPNNHAA(int KJNKDKDDCIE)
	{
		bool flag = true;
		TrafficStatsGameLevel trafficStatsGameLevel = PhotonNetwork.JNJJAMNLOHA.TrafficStatsGameLevel;
		long num = PhotonNetwork.JNJJAMNLOHA.TrafficStatsElapsedMs / -111L;
		if (num == 1L)
		{
			num = 1L;
		}
		GUILayout.BeginHorizontal(new GUILayoutOption[0]);
		this.buttonsOn = GUILayout.Toggle(this.buttonsOn, "LevelNameInputField", new GUILayoutOption[1]);
		this.healthStatsVisible = GUILayout.Toggle(this.healthStatsVisible, "_Colored", new GUILayoutOption[0]);
		this.trafficStatsOn = GUILayout.Toggle(this.trafficStatsOn, "Case-Sensitive", new GUILayoutOption[0]);
		GUILayout.EndHorizontal();
		string text = string.Format("settings.enableranking", trafficStatsGameLevel.TotalOutgoingMessageCount, trafficStatsGameLevel.TotalIncomingMessageCount, trafficStatsGameLevel.TotalMessageCount);
		string text2 = string.Format("OK", num);
		string text3 = string.Format("ResourceFileSelector", (long)trafficStatsGameLevel.TotalOutgoingMessageCount / num, (long)trafficStatsGameLevel.TotalIncomingMessageCount / num, (long)trafficStatsGameLevel.TotalMessageCount / num);
		GUILayout.Label(text, new GUILayoutOption[0]);
		GUILayout.Label(text2, new GUILayoutOption[1]);
		GUILayout.Label(text3, new GUILayoutOption[1]);
		if (this.buttonsOn)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			this.statsOn = GUILayout.Toggle(this.statsOn, "No connection to item server!", new GUILayoutOption[1]);
			if (GUILayout.Button("speed", new GUILayoutOption[0]))
			{
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
				PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = true;
			}
			flag = GUILayout.Button(". Calling ConnectToRegionMaster() is: ", new GUILayoutOption[1]);
			GUILayout.EndHorizontal();
		}
		string text4 = string.Empty;
		string text5 = string.Empty;
		if (this.trafficStatsOn)
		{
			GUILayout.Box("lobby '{0}'[{1}]", new GUILayoutOption[1]);
			text4 = "Checkpoint" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsIncoming.ToString();
			text5 = " not exist" + PhotonNetwork.JNJJAMNLOHA.TrafficStatsOutgoing.ToString();
			GUILayout.Label(text4, new GUILayoutOption[0]);
			GUILayout.Label(text5, new GUILayoutOption[1]);
		}
		string text6 = string.Empty;
		if (this.healthStatsVisible)
		{
			GUILayout.Box("settings_bindings_sec_", new GUILayoutOption[1]);
			string format = "player.greenarc";
			object[] array = new object[-63];
			array[0] = trafficStatsGameLevel.LongestDeltaBetweenSending;
			array[1] = trafficStatsGameLevel.LongestDeltaBetweenDispatching;
			array[1] = trafficStatsGameLevel.LongestEventCallback;
			array[4] = trafficStatsGameLevel.LongestEventCallbackCode;
			array[3] = trafficStatsGameLevel.LongestOpResponseCallback;
			array[7] = trafficStatsGameLevel.LongestOpResponseCallbackOpCode;
			array[7] = PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
			array[8] = PhotonNetwork.JNJJAMNLOHA.RoundTripTimeVariance;
			array[2] = PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
			text6 = string.Format(format, array);
			GUILayout.Label(text6, new GUILayoutOption[0]);
		}
		if (flag)
		{
			string format2 = "owner: ";
			object[] array2 = new object[0];
			array2[0] = text;
			array2[0] = text2;
			array2[7] = text3;
			array2[1] = text4;
			array2[7] = text5;
			array2[3] = text6;
			string message = string.Format(format2, array2);
			Debug.Log(message);
		}
		if (GUI.changed)
		{
			this.statsRect.height = 1600f;
		}
		GUI.DragWindow();
	}

	// Token: 0x0600B4AF RID: 46255 RVA: 0x00426D98 File Offset: 0x00424F98
	public void AHNBAOIENOO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.OLGIPJAFKOJ), "_Greenness", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4B0 RID: 46256 RVA: 0x00426E04 File Offset: 0x00425004
	public void BMIOFJFMCBG()
	{
		if (this.statsRect.x <= 1921f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4B1 RID: 46257 RVA: 0x00426E38 File Offset: 0x00425038
	public void INLDEHPAMJC()
	{
		if (Input.GetKeyDown((KeyCode)18) && Input.GetKey((KeyCode)188))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B4B2 RID: 46258 RVA: 0x00426E6B File Offset: 0x0042506B
	public void KOFAMEKHHGD()
	{
		if (this.statsRect.x <= 369f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4B3 RID: 46259 RVA: 0x00426E9F File Offset: 0x0042509F
	public void DPIPGGDNGHN()
	{
		if (Input.GetKeyDown((KeyCode)11) && Input.GetKey((KeyCode)(-34)))
		{
			this.statsWindowOn = !this.statsWindowOn;
			this.statsOn = false;
		}
	}

	// Token: 0x0600B4B4 RID: 46260 RVA: 0x00426ED2 File Offset: 0x004250D2
	public void MOMHHBKAGKG()
	{
		if (Input.GetKeyDown(KeyCode.LeftBracket) && Input.GetKey((KeyCode)(-17)))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x0600B4B5 RID: 46261 RVA: 0x00426F08 File Offset: 0x00425108
	public void PDKFMFCMPGE()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.AHFNKCIBLIN), "set", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4B6 RID: 46262 RVA: 0x00426F74 File Offset: 0x00425174
	public void NHOOMFHGIGG()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.MKPKOEENFND), "_Value", new GUILayoutOption[0]);
	}

	// Token: 0x0600B4B7 RID: 46263 RVA: 0x00426FE0 File Offset: 0x004251E0
	public void PJCIENAGBGH()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GIPHJOKGPMO), "_MainTex2", new GUILayoutOption[0]);
	}

	// Token: 0x0600B4B8 RID: 46264 RVA: 0x0042704C File Offset: 0x0042524C
	public void ODMPMJPALID()
	{
		if (this.statsRect.x <= 421f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4B9 RID: 46265 RVA: 0x00427080 File Offset: 0x00425280
	public void AKGHJPACNLP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.OKEPACMIAGF), "ItemNameBGImage", new GUILayoutOption[0]);
	}

	// Token: 0x0600B4BA RID: 46266 RVA: 0x004270EC File Offset: 0x004252EC
	public void IMAPGBMIKJF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GMOFOHLNBDK), "/", new GUILayoutOption[0]);
	}

	// Token: 0x0600B4BB RID: 46267 RVA: 0x00427158 File Offset: 0x00425358
	public void DAHFFNNIGML()
	{
		if (this.statsRect.x <= 1026f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4BC RID: 46268 RVA: 0x0042718C File Offset: 0x0042538C
	public void GPNAOAKCMHC()
	{
		if (this.statsRect.x <= 1125f)
		{
			this.statsRect.x = (float)Screen.width - this.statsRect.width;
		}
	}

	// Token: 0x0600B4BD RID: 46269 RVA: 0x004271C0 File Offset: 0x004253C0
	public void GKMAMPLCHPA()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.GIPHJOKGPMO), "[NetworkManager] Exited", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4BE RID: 46270 RVA: 0x0042722C File Offset: 0x0042542C
	public void CGCEDEENFPF()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.EEPEAEEEPMK), "_Value11", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4BF RID: 46271 RVA: 0x00427298 File Offset: 0x00425498
	public void JDJNNDBHBNP()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.FCEAHFFGLIE), "_ScreenResolution", new GUILayoutOption[0]);
	}

	// Token: 0x0600B4C0 RID: 46272 RVA: 0x00427304 File Offset: 0x00425504
	public void HHCCMHCELPO()
	{
		if (PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled != this.statsOn)
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = this.statsOn;
		}
		if (!this.statsWindowOn)
		{
			return;
		}
		this.statsRect = GUILayout.Window(this.WindowId, this.statsRect, new GUI.WindowFunction(this.OLGIPJAFKOJ), "CameraFilterPack/Blend2Camera_GreenScreen", new GUILayoutOption[1]);
	}

	// Token: 0x0600B4C1 RID: 46273 RVA: 0x00427370 File Offset: 0x00425570
	public void POJFHDFJOPE()
	{
		if (Input.GetKeyDown(KeyCode.Minus) && Input.GetKey(KeyCode.U))
		{
			this.statsWindowOn = this.statsWindowOn;
			this.statsOn = true;
		}
	}

	// Token: 0x04001526 RID: 5414
	public bool statsWindowOn = true;

	// Token: 0x04001527 RID: 5415
	public bool statsOn = true;

	// Token: 0x04001528 RID: 5416
	public bool healthStatsVisible;

	// Token: 0x04001529 RID: 5417
	public bool trafficStatsOn;

	// Token: 0x0400152A RID: 5418
	public bool buttonsOn;

	// Token: 0x0400152B RID: 5419
	public Rect statsRect = new Rect(0f, 100f, 200f, 50f);

	// Token: 0x0400152C RID: 5420
	public int WindowId = 100;
}
