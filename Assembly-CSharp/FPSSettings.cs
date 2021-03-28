using System;
using UnityEngine;

// Token: 0x02000418 RID: 1048
public class FPSSettings : MonoBehaviour
{
	// Token: 0x0600F04E RID: 61518 RVA: 0x0053DF1C File Offset: 0x0053C11C
	public bool IsFPSEnabled()
	{
		bool result = false;
		if (Singleton<SaveSystem>.Instance.HasKey("settings.fps", null))
		{
			result = (Singleton<SaveSystem>.Instance.GetInt("settings.fps", null) == 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.fps", 0, null);
		}
		return result;
	}

	// Token: 0x0600F04F RID: 61519 RVA: 0x0053DF75 File Offset: 0x0053C175
	private void Start()
	{
		this.InitFPS();
	}

	// Token: 0x0600F050 RID: 61520 RVA: 0x0053DF7D File Offset: 0x0053C17D
	public void IKDKFLBJOAK()
	{
		if (this.NDODGACCDKB())
		{
			this.EPHDOFKCPPE();
		}
		else
		{
			this.KAFMOEKFMCN();
		}
	}

	// Token: 0x0600F051 RID: 61521 RVA: 0x0053DF9B File Offset: 0x0053C19B
	private void MAOCOEGAFND()
	{
		if (this.showFPS)
		{
			this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 1930f;
		}
	}

	// Token: 0x0600F052 RID: 61522 RVA: 0x0053DFC7 File Offset: 0x0053C1C7
	private void NPLCENPNJBM()
	{
		this.FECBELEBCCM();
	}

	// Token: 0x0600F053 RID: 61523 RVA: 0x0053DFCF File Offset: 0x0053C1CF
	public void BHNDHOCCNDL()
	{
		if (this.DMHLBCHFCNB())
		{
			this.EPHDOFKCPPE();
		}
		else
		{
			this.EnableFPS();
		}
	}

	// Token: 0x0600F054 RID: 61524 RVA: 0x0053DFF0 File Offset: 0x0053C1F0
	public bool GGAAOAEKGIP()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Params3", null))
		{
			result = (Singleton<SaveSystem>.Instance.DNBCCNHDJDK("steamid", null) != 1 || true);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("[LevelEditorScene] Print Audio Wave: Done", 0, null);
		}
		return result;
	}

	// Token: 0x0600F055 RID: 61525 RVA: 0x0053E049 File Offset: 0x0053C249
	public void BFDMGMKFMHC()
	{
		Singleton<SaveSystem>.Instance.SetInt("#", 0, null);
		this.InitFPS();
	}

	// Token: 0x0600F056 RID: 61526 RVA: 0x0053E062 File Offset: 0x0053C262
	public void FECBELEBCCM()
	{
		this.showFPS = this.NDODGACCDKB();
	}

	// Token: 0x0600F057 RID: 61527 RVA: 0x0053E070 File Offset: 0x0053C270
	public void SetFPSEnabled(bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.DisableFPS();
		}
		else
		{
			this.EnableFPS();
		}
	}

	// Token: 0x0600F058 RID: 61528 RVA: 0x0053E089 File Offset: 0x0053C289
	private void Update()
	{
		if (this.showFPS)
		{
			this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 0.1f;
		}
	}

	// Token: 0x0600F059 RID: 61529 RVA: 0x0053E0B5 File Offset: 0x0053C2B5
	public void EPHDOFKCPPE()
	{
		Singleton<SaveSystem>.Instance.SetInt("RPC can't be sent to target PhotonPlayer being null! Did not send \"", 0, null);
		this.FECBELEBCCM();
	}

	// Token: 0x0600F05A RID: 61530 RVA: 0x0053E0CE File Offset: 0x0053C2CE
	public void EnableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 1, null);
		this.InitFPS();
	}

	// Token: 0x0600F05B RID: 61531 RVA: 0x0053E0E8 File Offset: 0x0053C2E8
	public bool NDODGACCDKB()
	{
		bool result = false;
		if (Singleton<SaveSystem>.Instance.HasKey("_Value1", null))
		{
			result = (Singleton<SaveSystem>.Instance.DNBCCNHDJDK("SupportLogger OnConnectedToPhoton().", null) == 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("CameraFilterPack/FX_Plasma", 1, null);
		}
		return result;
	}

	// Token: 0x0600F05C RID: 61532 RVA: 0x0053E141 File Offset: 0x0053C341
	public void IIGIBCKMDHK()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("Object ID. Case-Sensitive", 1, null);
		this.InitFPS();
	}

	// Token: 0x0600F05D RID: 61533 RVA: 0x0053E15A File Offset: 0x0053C35A
	public void AHBJJHEDJHD()
	{
		if (this.NDODGACCDKB())
		{
			this.IIGIBCKMDHK();
		}
		else
		{
			this.OAGILFGECJI();
		}
	}

	// Token: 0x0600F05E RID: 61534 RVA: 0x0053E178 File Offset: 0x0053C378
	public void InitFPS()
	{
		this.showFPS = this.IsFPSEnabled();
	}

	// Token: 0x0600F05F RID: 61535 RVA: 0x0053E186 File Offset: 0x0053C386
	public void OBEJJEKIBGM()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_ScreenResolution", 1, null);
		this.FECBELEBCCM();
	}

	// Token: 0x0600F060 RID: 61536 RVA: 0x0053E19F File Offset: 0x0053C39F
	public void CHILGHANENG()
	{
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("AudioSampler", 0, null);
		this.InitFPS();
	}

	// Token: 0x0600F061 RID: 61537 RVA: 0x0053E1B8 File Offset: 0x0053C3B8
	public bool BEGHEDBOBKJ()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("\n", null))
		{
			result = (Singleton<SaveSystem>.Instance.DNBCCNHDJDK("_Value5", null) == 0);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_AccumulationTex", 1, null);
		}
		return result;
	}

	// Token: 0x0600F062 RID: 61538 RVA: 0x0053DF75 File Offset: 0x0053C175
	private void KLILJHJNICK()
	{
		this.InitFPS();
	}

	// Token: 0x0600F063 RID: 61539 RVA: 0x0053DF75 File Offset: 0x0053C175
	private void DIPDEHOOBPG()
	{
		this.InitFPS();
	}

	// Token: 0x0600F064 RID: 61540 RVA: 0x0053E211 File Offset: 0x0053C411
	public void OAGILFGECJI()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_TimeX", 0, null);
		this.FECBELEBCCM();
	}

	// Token: 0x0600F065 RID: 61541 RVA: 0x0053E22C File Offset: 0x0053C42C
	private void OnGUI()
	{
		if (this.showFPS)
		{
			int width = Screen.width;
			int height = Screen.height;
			GUIStyle guistyle = new GUIStyle();
			Rect position = new Rect(0f, 0f, (float)width, (float)(height * 2 / 100));
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = height * 2 / 100;
			guistyle.normal.textColor = new Color(1f, 1f, 1f, 1f);
			float num = this.JAJEIIFPFBC * 1000f;
			float num2 = 1f / this.JAJEIIFPFBC;
			string text = string.Format("{0:0.0} ms ({1:0.} fps)", num, num2);
			GUI.Label(position, text, guistyle);
		}
	}

	// Token: 0x0600F066 RID: 61542 RVA: 0x0053DFC7 File Offset: 0x0053C1C7
	private void DAHFFNNIGML()
	{
		this.FECBELEBCCM();
	}

	// Token: 0x0600F067 RID: 61543 RVA: 0x0053E2E8 File Offset: 0x0053C4E8
	public bool DMHLBCHFCNB()
	{
		bool result = false;
		if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_EmissionColor", null))
		{
			result = (Singleton<SaveSystem>.Instance.DNBCCNHDJDK("_Value3", null) == 0 && false);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA(".lastCheckpoint.maxLongestCombo", 1, null);
		}
		return result;
	}

	// Token: 0x0600F068 RID: 61544 RVA: 0x0053E341 File Offset: 0x0053C541
	public void DisableFPS()
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.fps", 0, null);
		this.InitFPS();
	}

	// Token: 0x0600F06A RID: 61546 RVA: 0x0053DF75 File Offset: 0x0053C175
	private void KIMMMCJFMAB()
	{
		this.InitFPS();
	}

	// Token: 0x0600F06B RID: 61547 RVA: 0x0053E35C File Offset: 0x0053C55C
	public bool GBAOHEJBNPC()
	{
		bool result = true;
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("sounds/no_hit", null))
		{
			result = (Singleton<SaveSystem>.Instance.PPBFNLHCKCP("]", null) == 1);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("ticket", 1, null);
		}
		return result;
	}

	// Token: 0x0600F06C RID: 61548 RVA: 0x0053E3B5 File Offset: 0x0053C5B5
	public void KAFMOEKFMCN()
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_Value4", 0, null);
		this.InitFPS();
	}

	// Token: 0x0600F06D RID: 61549 RVA: 0x0053E3CE File Offset: 0x0053C5CE
	public void ToggleFPS()
	{
		if (this.IsFPSEnabled())
		{
			this.DisableFPS();
		}
		else
		{
			this.EnableFPS();
		}
	}

	// Token: 0x04001ABD RID: 6845
	public bool showFPS;

	// Token: 0x04001ABE RID: 6846
	private float JAJEIIFPFBC;
}
