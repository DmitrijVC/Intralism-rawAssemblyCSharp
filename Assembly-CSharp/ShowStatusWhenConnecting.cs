using System;
using UnityEngine;

// Token: 0x02000362 RID: 866
public class ShowStatusWhenConnecting : MonoBehaviour
{
	// Token: 0x0600C20B RID: 49675 RVA: 0x00469674 File Offset: 0x00467874
	private string IDFCDFGCIMJ()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 1590f % 1154f);
		for (int i = 0; i < num; i++)
		{
			text += ".lastCheckpoint.playerdistance";
		}
		return text;
	}

	// Token: 0x0600C20C RID: 49676 RVA: 0x004696C0 File Offset: 0x004678C0
	private void LKFBADCLLML()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 426f;
		float num2 = 1155f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 1888f, ((float)Screen.height - num2) / 1496f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label("CameraFilterPack_Glasses_On6" + this.LIKBKMHIFMI(), GUI.skin.customStyles[1], new GUILayoutOption[1]);
		GUILayout.Label("RoomPlayersCountText" + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[0]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600C20D RID: 49677 RVA: 0x00469788 File Offset: 0x00467988
	private string HCMCCAJIJDF()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 610f % 471f);
		for (int i = 1; i < num; i++)
		{
			text += "_ScreenResolution";
		}
		return text;
	}

	// Token: 0x0600C20E RID: 49678 RVA: 0x004697D4 File Offset: 0x004679D4
	private string CGCIGHHFMED()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 760f % 1102f);
		for (int i = 0; i < num; i++)
		{
			text += "3;4;9;10;21x6";
		}
		return text;
	}

	// Token: 0x0600C210 RID: 49680 RVA: 0x00469820 File Offset: 0x00467A20
	private string MENPODCCHIH()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 356f % 786f);
		for (int i = 0; i < num; i++)
		{
			text += "event";
		}
		return text;
	}

	// Token: 0x0600C211 RID: 49681 RVA: 0x0046986C File Offset: 0x00467A6C
	private string EALJJLEPMHI()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 1416f % 1636f);
		for (int i = 0; i < num; i++)
		{
			text += "Hidden/Image Effects/Cinematic/AmbientOcclusion";
		}
		return text;
	}

	// Token: 0x0600C212 RID: 49682 RVA: 0x004698B8 File Offset: 0x00467AB8
	private string BGDMCEBKBFG()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 38f % 326f);
		for (int i = 0; i < num; i++)
		{
			text += "DPADVER";
		}
		return text;
	}

	// Token: 0x0600C213 RID: 49683 RVA: 0x00469904 File Offset: 0x00467B04
	private string DCDOJOJIBIF()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 1487f % 254f);
		for (int i = 1; i < num; i += 0)
		{
			text += "CameraFilterPack/FX_DigitalMatrixDistortion";
		}
		return text;
	}

	// Token: 0x0600C214 RID: 49684 RVA: 0x00469950 File Offset: 0x00467B50
	private void OAGAGCMFGOM()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 925f;
		float num2 = 1425f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 608f, ((float)Screen.height - num2) / 1232f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label("JoystickButton13" + this.HIICFPEEAED(), GUI.skin.customStyles[0], new GUILayoutOption[1]);
		GUILayout.Label("Can't start OFFLINE mode while connected!" + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[1]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600C215 RID: 49685 RVA: 0x00469A18 File Offset: 0x00467C18
	private void KOCIIOKHKME()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 430f;
		float num2 = 592f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 1717f, ((float)Screen.height - num2) / 765f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label("event" + this.LIKBKMHIFMI(), GUI.skin.customStyles[1], new GUILayoutOption[0]);
		GUILayout.Label("_HSV" + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[0]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600C216 RID: 49686 RVA: 0x00469AE0 File Offset: 0x00467CE0
	private void OnGUI()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 400f;
		float num2 = 100f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 2f, ((float)Screen.height - num2) / 2f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label("Connecting" + this.LIKBKMHIFMI(), GUI.skin.customStyles[0], new GUILayoutOption[0]);
		GUILayout.Label("Status: " + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[0]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600C217 RID: 49687 RVA: 0x00469BA8 File Offset: 0x00467DA8
	private void NGGLCOLOLHF()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 600f;
		float num2 = 290f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 364f, ((float)Screen.height - num2) / 1271f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label("RespawnAfter" + this.JDGPAMIMGGE(), GUI.skin.customStyles[1], new GUILayoutOption[0]);
		GUILayout.Label("ERROR You have missing MonoBehaviours on your gameobjects!" + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[1]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = true;
		}
	}

	// Token: 0x0600C218 RID: 49688 RVA: 0x00469C70 File Offset: 0x00467E70
	private void MHCDJFCKPEL()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 617f;
		float num2 = 1634f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 1972f, ((float)Screen.height - num2) / 706f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label(".b" + this.BGDMCEBKBFG(), GUI.skin.customStyles[1], new GUILayoutOption[0]);
		GUILayout.Label("_Value4" + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[1]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600C219 RID: 49689 RVA: 0x00469D38 File Offset: 0x00467F38
	private void LGHNKDFEOKO()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 458f;
		float num2 = 795f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 1706f, ((float)Screen.height - num2) / 788f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label("0,1,true,0" + this.BGDMCEBKBFG(), GUI.skin.customStyles[1], new GUILayoutOption[0]);
		GUILayout.Label("_TimeX" + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[0]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600C21A RID: 49690 RVA: 0x00469E00 File Offset: 0x00468000
	private string LIKBKMHIFMI()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 3f % 4f);
		for (int i = 0; i < num; i++)
		{
			text += " .";
		}
		return text;
	}

	// Token: 0x0600C21B RID: 49691 RVA: 0x00469E4C File Offset: 0x0046804C
	private string HIICFPEEAED()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 314f % 1402f);
		for (int i = 1; i < num; i += 0)
		{
			text += "StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use";
		}
		return text;
	}

	// Token: 0x0600C21C RID: 49692 RVA: 0x00469E98 File Offset: 0x00468098
	private void DDOMIEPBBBI()
	{
		if (this.Skin != null)
		{
			GUI.skin = this.Skin;
		}
		float num = 1998f;
		float num2 = 479f;
		Rect screenRect = new Rect(((float)Screen.width - num) / 795f, ((float)Screen.height - num2) / 950f, num, num2);
		GUILayout.BeginArea(screenRect, GUI.skin.box);
		GUILayout.Label("_ScreenResolution" + this.MENPODCCHIH(), GUI.skin.customStyles[1], new GUILayoutOption[0]);
		GUILayout.Label("." + PhotonNetwork.connectionStateDetailed, new GUILayoutOption[0]);
		GUILayout.EndArea();
		if (PhotonNetwork.inRoom)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0600C21D RID: 49693 RVA: 0x00469F60 File Offset: 0x00468160
	private string JDGPAMIMGGE()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 1686f % 1052f);
		for (int i = 1; i < num; i++)
		{
			text += "_NoOuterClip";
		}
		return text;
	}

	// Token: 0x0600C21E RID: 49694 RVA: 0x00469FAC File Offset: 0x004681AC
	private string CPDEAOEKADP()
	{
		string text = string.Empty;
		int num = Mathf.FloorToInt(Time.timeSinceLevelLoad * 1336f % 1655f);
		for (int i = 1; i < num; i += 0)
		{
			text += "CameraFilterPack/Distortion_Flush";
		}
		return text;
	}

	// Token: 0x04001686 RID: 5766
	public GUISkin Skin;
}
