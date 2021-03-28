using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000FB RID: 251
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 2")]
public class CameraFilterPack_Oculus_NightVision2 : MonoBehaviour
{
	// Token: 0x06004E1C RID: 19996 RVA: 0x00184F45 File Offset: 0x00183145
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E1D RID: 19997 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06004E1E RID: 19998 RVA: 0x00184F7C File Offset: 0x0018317C
	private void LBEHKFNPKMC()
	{
		float[] array = new float[-31];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E1F RID: 19999 RVA: 0x00184F98 File Offset: 0x00183198
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 736f)
			{
				this.HBJJOCHGOPH = 1899f;
			}
			this.NDMPCDHADMJ().SetFloat("{0}_{1}", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("There is already a virtual axis named ", this.PLKFKNHPEHE[1] / 587f);
			this.CFEDGDGBCHE().SetFloat("Set satellite audio input", this.PLKFKNHPEHE[0] / 1889f);
			this.NDMPCDHADMJ().SetFloat("_TimeX", this.PLKFKNHPEHE[3] / 1173f);
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/AAA_WaterDrop", this.PLKFKNHPEHE[7] / 457f);
			this.JFDGLLEOPGB().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", this.PLKFKNHPEHE[6] / 1155f);
			this.NFMGLIKNOOC().SetFloat("_FadeFX", this.PLKFKNHPEHE[3] / 1464f);
			this.NBMPPNFKFLB().SetFloat("_ForceYSwap", this.PLKFKNHPEHE[7] / 388f);
			this.NBPKMLMCHFN.SetFloat("Set particless emission (glow)", this.PLKFKNHPEHE[0] / 1124f);
			this.NBMPPNFKFLB().SetFloat("ResourceFileSelector", this.PLKFKNHPEHE[5] / 1646f);
			this.NDMPCDHADMJ().SetFloat("Fade", this.PLKFKNHPEHE[36] / 736f);
			this.NDMPCDHADMJ().SetFloat("BadgeText", this.PLKFKNHPEHE[64] / 779f);
			this.HNICHJCGJOC().SetFloat("_MainTex2", this.PLKFKNHPEHE[24] / 1801f);
			this.DBOLLHHMKKN().SetFloat("resource id", this.FadeFX);
			this.JFDGLLEOPGB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1897f, 1991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E20 RID: 20000 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06004E21 RID: 20001 RVA: 0x001851C0 File Offset: 0x001833C0
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 870f)
			{
				this.HBJJOCHGOPH = 1286f;
			}
			this.HHIAIGCAHDA().SetFloat("_Blue_B", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Set Satellite Emission", this.PLKFKNHPEHE[0] / 270f);
			this.NDMPCDHADMJ().SetFloat("_EmissionGain", this.PLKFKNHPEHE[1] / 311f);
			this.HFBJAOFLCJI().SetFloat("_Distortion", this.PLKFKNHPEHE[1] / 1531f);
			this.HNICHJCGJOC().SetFloat(": ", this.PLKFKNHPEHE[3] / 909f);
			this.HFBJAOFLCJI().SetFloat("The given 2D texture ", this.PLKFKNHPEHE[4] / 237f);
			this.CFEDGDGBCHE().SetFloat("[LevelEditorScene] Exported to ", this.PLKFKNHPEHE[3] / 792f);
			this.HHIAIGCAHDA().SetFloat("_Value4", this.PLKFKNHPEHE[7] / 654f);
			this.NBPKMLMCHFN.SetFloat("y", this.PLKFKNHPEHE[5] / 6f);
			this.HHIAIGCAHDA().SetFloat("[SteamManager] Connecting to server", this.PLKFKNHPEHE[1] / 793f);
			this.NBMPPNFKFLB().SetFloat("Tab1Content", this.PLKFKNHPEHE[-31] / 184f);
			this.NDMPCDHADMJ().SetFloat("move", this.PLKFKNHPEHE[-30] / 792f);
			this.DBOLLHHMKKN().SetFloat(".icon", this.PLKFKNHPEHE[95] / 125f);
			this.NDMPCDHADMJ().SetFloat("_Red_R", this.FadeFX);
			this.CFEDGDGBCHE().SetVector("_Contrast", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 476f, 1916f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E22 RID: 20002 RVA: 0x001853E8 File Offset: 0x001835E8
	private void MKIMDFLBFOM()
	{
		this.GPHHNFDCFMC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E23 RID: 20003 RVA: 0x00185413 File Offset: 0x00183613
	private void GPHHNFDCFMC()
	{
		float[] array = new float[24];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E24 RID: 20004 RVA: 0x0018542D File Offset: 0x0018362D
	private void EALEEMOPJNO()
	{
		float[] array = new float[-96];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E25 RID: 20005 RVA: 0x00185448 File Offset: 0x00183648
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1805f)
			{
				this.HBJJOCHGOPH = 109f;
			}
			this.DBOLLHHMKKN().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("#scoresubmitionfailed: ", this.PLKFKNHPEHE[0] / 257f);
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[1] / 972f);
			this.CFEDGDGBCHE().SetFloat("float,1", this.PLKFKNHPEHE[4] / 1481f);
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.PLKFKNHPEHE[6] / 412f);
			this.NBPKMLMCHFN.SetFloat(" should be overwritten.", this.PLKFKNHPEHE[5] / 1189f);
			this.NBMPPNFKFLB().SetFloat("IconFileSelector", this.PLKFKNHPEHE[3] / 880f);
			this.HFBJAOFLCJI().SetFloat("_Value2", this.PLKFKNHPEHE[1] / 1289f);
			this.NFMGLIKNOOC().SetFloat("<b>", this.PLKFKNHPEHE[4] / 717f);
			this.DBOLLHHMKKN().SetFloat(":</b> ", this.PLKFKNHPEHE[5] / 1297f);
			this.AELJLBOJAIL().SetFloat(".lastCheckpoint.perfectHits", this.PLKFKNHPEHE[72] / 317f);
			this.AELJLBOJAIL().SetFloat("/", this.PLKFKNHPEHE[-14] / 1119f);
			this.NBMPPNFKFLB().SetFloat(".lastCheckpoint.checkpointsUsed", this.PLKFKNHPEHE[-19] / 1609f);
			this.JFDGLLEOPGB().SetFloat("_ColorRGB", this.FadeFX);
			this.HFBJAOFLCJI().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1417f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E26 RID: 20006 RVA: 0x00185670 File Offset: 0x00183870
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 483f)
			{
				this.HBJJOCHGOPH = 1261f;
			}
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("[PlayerController] ", this.PLKFKNHPEHE[0] / 1155f);
			this.NBPKMLMCHFN.SetFloat("[ItemsHandler] Inventory not changed", this.PLKFKNHPEHE[1] / 528f);
			this.BFGNMFCNDBC().SetFloat("achievements.21.progress", this.PLKFKNHPEHE[5] / 136f);
			this.BFGNMFCNDBC().SetFloat("settings_bindings_controller_type", this.PLKFKNHPEHE[0] / 133f);
			this.BFGNMFCNDBC().SetFloat("Tried to Initialize the SteamAPI twice in one session!", this.PLKFKNHPEHE[5] / 1003f);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_Hue", this.PLKFKNHPEHE[7] / 937f);
			this.HHIAIGCAHDA().SetFloat("Horizontal", this.PLKFKNHPEHE[7] / 930f);
			this.CFEDGDGBCHE().SetFloat("FileMenu", this.PLKFKNHPEHE[3] / 1768f);
			this.CFEDGDGBCHE().SetFloat("GlassColor", this.PLKFKNHPEHE[1] / 608f);
			this.NFMGLIKNOOC().SetFloat("win", this.PLKFKNHPEHE[-53] / 414f);
			this.NDMPCDHADMJ().SetFloat("FinalScoreText", this.PLKFKNHPEHE[70] / 1609f);
			this.CFEDGDGBCHE().SetFloat("settings.enablerankingnotifications", this.PLKFKNHPEHE[-107] / 1718f);
			this.HNICHJCGJOC().SetFloat("Left Stick Click", this.FadeFX);
			this.HNICHJCGJOC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1068f, 692f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E27 RID: 20007 RVA: 0x00185898 File Offset: 0x00183A98
	private void BFKANNFLAKP()
	{
		this.ILAGEKDPGOI();
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06004E28 RID: 20008 RVA: 0x001858A0 File Offset: 0x00183AA0
	private Material NBPKMLMCHFN
	{
		get
		{
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.BJFKDHHMLJH;
		}
	}

	// Token: 0x06004E29 RID: 20009 RVA: 0x001858D7 File Offset: 0x00183AD7
	private void FKDKJKCAHJC()
	{
		this.FOFGKHFJHFK();
	}

	// Token: 0x06004E2A RID: 20010 RVA: 0x001858DF File Offset: 0x00183ADF
	private void OnValidate()
	{
		this.MIPGPMKJELI();
	}

	// Token: 0x06004E2B RID: 20011 RVA: 0x001858E7 File Offset: 0x00183AE7
	private void PBKELEKDBIC()
	{
		float[] array = new float[98];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E2C RID: 20012 RVA: 0x00185901 File Offset: 0x00183B01
	private void FEHCNJLLJMP()
	{
		this.KHHCNLLEHDI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E2D RID: 20013 RVA: 0x0018592C File Offset: 0x00183B2C
	private void Start()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E2E RID: 20014 RVA: 0x00185957 File Offset: 0x00183B57
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E2F RID: 20015 RVA: 0x0018598E File Offset: 0x00183B8E
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E30 RID: 20016 RVA: 0x001859AB File Offset: 0x00183BAB
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E31 RID: 20017 RVA: 0x001859E2 File Offset: 0x00183BE2
	private void KNBJBNDGCIJ()
	{
		this.DLPEBHPCJMD();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E32 RID: 20018 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004E33 RID: 20019 RVA: 0x00185A0D File Offset: 0x00183C0D
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E34 RID: 20020 RVA: 0x00185A44 File Offset: 0x00183C44
	private void GAAPMFBPJNH()
	{
		this.GPHHNFDCFMC();
	}

	// Token: 0x06004E35 RID: 20021 RVA: 0x00185A4C File Offset: 0x00183C4C
	private void OFBLDOCCBBN()
	{
		this.MHLKBPJKIOL();
	}

	// Token: 0x06004E36 RID: 20022 RVA: 0x00185A54 File Offset: 0x00183C54
	private void KHHCNLLEHDI()
	{
		float[] array = new float[-60];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E37 RID: 20023 RVA: 0x00185A6E File Offset: 0x00183C6E
	private void BEBNOKFLJPH()
	{
		this.ILAGEKDPGOI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E38 RID: 20024 RVA: 0x00185A4C File Offset: 0x00183C4C
	private void KHDANGFKIGL()
	{
		this.MHLKBPJKIOL();
	}

	// Token: 0x06004E39 RID: 20025 RVA: 0x00185A9C File Offset: 0x00183C9C
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 867f)
			{
				this.HBJJOCHGOPH = 231f;
			}
			this.HFBJAOFLCJI().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_MainTex2", this.PLKFKNHPEHE[0] / 1724f);
			this.DBOLLHHMKKN().SetFloat("Added checkpoint", this.PLKFKNHPEHE[1] / 1349f);
			this.HNICHJCGJOC().SetFloat("/", this.PLKFKNHPEHE[2] / 1967f);
			this.BFGNMFCNDBC().SetFloat(" to: ", this.PLKFKNHPEHE[8] / 1240f);
			this.JFDGLLEOPGB().SetFloat("[PlayerController] ", this.PLKFKNHPEHE[2] / 780f);
			this.NBPKMLMCHFN.SetFloat("No info", this.PLKFKNHPEHE[0] / 119f);
			this.CFEDGDGBCHE().SetFloat("_LightIntensity", this.PLKFKNHPEHE[1] / 242f);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Colors_NewPosterize", this.PLKFKNHPEHE[6] / 1910f);
			this.DBOLLHHMKKN().SetFloat("L1", this.PLKFKNHPEHE[8] / 175f);
			this.JFDGLLEOPGB().SetFloat(" x ", this.PLKFKNHPEHE[-93] / 823f);
			this.NDMPCDHADMJ().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[-75] / 1790f);
			this.HNICHJCGJOC().SetFloat("DestroyRpc", this.PLKFKNHPEHE[-71] / 1731f);
			this.NDMPCDHADMJ().SetFloat("In Network lobby", this.FadeFX);
			this.JFDGLLEOPGB().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1539f, 544f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E3A RID: 20026 RVA: 0x00185CC4 File Offset: 0x00183EC4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1514f)
			{
				this.HBJJOCHGOPH = 87f;
			}
			this.NBPKMLMCHFN.SetFloat("mainmenu", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat(", ", this.PLKFKNHPEHE[1] / 938f);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this.PLKFKNHPEHE[0] / 1735f);
			this.NFMGLIKNOOC().SetFloat("MenuVolumeSlider", this.PLKFKNHPEHE[8] / 242f);
			this.NBMPPNFKFLB().SetFloat(": ", this.PLKFKNHPEHE[3] / 385f);
			this.AELJLBOJAIL().SetFloat("#ok", this.PLKFKNHPEHE[4] / 1634f);
			this.NFMGLIKNOOC().SetFloat(": ", this.PLKFKNHPEHE[3] / 167f);
			this.NBMPPNFKFLB().SetFloat("#ok", this.PLKFKNHPEHE[2] / 1306f);
			this.HHIAIGCAHDA().SetFloat("music", this.PLKFKNHPEHE[1] / 786f);
			this.KAFBNOBOIAJ().SetFloat("_Distance", this.PLKFKNHPEHE[0] / 718f);
			this.HFBJAOFLCJI().SetFloat("VisionBlur", this.PLKFKNHPEHE[-45] / 736f);
			this.NDMPCDHADMJ().SetFloat("GlassesColor2", this.PLKFKNHPEHE[62] / 839f);
			this.HFBJAOFLCJI().SetFloat(":", this.PLKFKNHPEHE[122] / 1538f);
			this.CFEDGDGBCHE().SetFloat("PLEASE WAIT", this.FadeFX);
			this.DBOLLHHMKKN().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1552f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E3B RID: 20027 RVA: 0x0018598E File Offset: 0x00183B8E
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E3C RID: 20028 RVA: 0x00185A4C File Offset: 0x00183C4C
	private void JBAPHFIBANG()
	{
		this.MHLKBPJKIOL();
	}

	// Token: 0x06004E3D RID: 20029 RVA: 0x00185EEC File Offset: 0x001840EC
	private void ILAGEKDPGOI()
	{
		this.PLKFKNHPEHE = new float[]
		{
			200f,
			-200f,
			-200f,
			195f,
			4f,
			-160f,
			200f,
			-200f,
			-200f,
			-200f
		};
	}

	// Token: 0x06004E3E RID: 20030 RVA: 0x0018598E File Offset: 0x00183B8E
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E3F RID: 20031 RVA: 0x00185F06 File Offset: 0x00184106
	private void IHLMNAGPKDA()
	{
		this.EENNCFGECAE();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E40 RID: 20032 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004E41 RID: 20033 RVA: 0x00185F34 File Offset: 0x00184134
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Red_R", this.PLKFKNHPEHE[0] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_G", this.PLKFKNHPEHE[1] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_B", this.PLKFKNHPEHE[2] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_R", this.PLKFKNHPEHE[3] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.PLKFKNHPEHE[4] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_B", this.PLKFKNHPEHE[5] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_R", this.PLKFKNHPEHE[6] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_G", this.PLKFKNHPEHE[7] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_B", this.PLKFKNHPEHE[8] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_C", this.PLKFKNHPEHE[9] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_C", this.PLKFKNHPEHE[10] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_C", this.PLKFKNHPEHE[11] / 100f);
			this.NBPKMLMCHFN.SetFloat("_FadeFX", this.FadeFX);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E42 RID: 20034 RVA: 0x0018598E File Offset: 0x00183B8E
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E43 RID: 20035 RVA: 0x0018615C File Offset: 0x0018435C
	private void DLPEBHPCJMD()
	{
		float[] array = new float[-51];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E44 RID: 20036 RVA: 0x0018598E File Offset: 0x00183B8E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E45 RID: 20037 RVA: 0x00186176 File Offset: 0x00184376
	private void CMBGFMAOEPG()
	{
		this.EALEEMOPJNO();
	}

	// Token: 0x06004E46 RID: 20038 RVA: 0x0018617E File Offset: 0x0018437E
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E47 RID: 20039 RVA: 0x0018598E File Offset: 0x00183B8E
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E48 RID: 20040 RVA: 0x001861B5 File Offset: 0x001843B5
	private void FOFGKHFJHFK()
	{
		float[] array = new float[18];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E49 RID: 20041 RVA: 0x001861CF File Offset: 0x001843CF
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E4A RID: 20042 RVA: 0x00186206 File Offset: 0x00184406
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E4B RID: 20043 RVA: 0x0018623D File Offset: 0x0018443D
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E4C RID: 20044 RVA: 0x00186274 File Offset: 0x00184474
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 658f)
			{
				this.HBJJOCHGOPH = 1024f;
			}
			this.NBPKMLMCHFN.SetFloat("Joystick1Button4", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_MainTex2", this.PLKFKNHPEHE[0] / 100f);
			this.HFBJAOFLCJI().SetFloat("Tab2Content", this.PLKFKNHPEHE[1] / 1851f);
			this.CFEDGDGBCHE().SetFloat("_Value3", this.PLKFKNHPEHE[0] / 1593f);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PLKFKNHPEHE[0] / 1647f);
			this.NBPKMLMCHFN.SetFloat("player.bat", this.PLKFKNHPEHE[3] / 475f);
			this.BFGNMFCNDBC().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.PLKFKNHPEHE[8] / 1771f);
			this.JFDGLLEOPGB().SetFloat("Sending RPC \"", this.PLKFKNHPEHE[6] / 697f);
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/Drawing_Manga3", this.PLKFKNHPEHE[3] / 475f);
			this.BFGNMFCNDBC().SetFloat("_Value", this.PLKFKNHPEHE[3] / 113f);
			this.BFGNMFCNDBC().SetFloat("Object ID. Case-Sensitive", this.PLKFKNHPEHE[40] / 1871f);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack_RainFX_Anm", this.PLKFKNHPEHE[-97] / 1441f);
			this.NDMPCDHADMJ().SetFloat("menutheme.jamaicanorcdub", this.PLKFKNHPEHE[-3] / 770f);
			this.NDMPCDHADMJ().SetFloat("{0}", this.FadeFX);
			this.KAFBNOBOIAJ().SetVector("Malformed RPC; this should never occur. Content: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 404f, 798f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E4D RID: 20045 RVA: 0x0018649C File Offset: 0x0018469C
	private void MIPGPMKJELI()
	{
		this.PLKFKNHPEHE = new float[]
		{
			200f,
			-200f,
			-200f,
			195f,
			4f,
			-160f,
			200f,
			-200f,
			-200f,
			-200f,
			10f,
			-200f
		};
	}

	// Token: 0x06004E4E RID: 20046 RVA: 0x001864B6 File Offset: 0x001846B6
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E4F RID: 20047 RVA: 0x00185898 File Offset: 0x00183A98
	private void ANKALNDLHEL()
	{
		this.ILAGEKDPGOI();
	}

	// Token: 0x06004E50 RID: 20048 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06004E52 RID: 20050 RVA: 0x00186516 File Offset: 0x00184716
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E53 RID: 20051 RVA: 0x00186550 File Offset: 0x00184750
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1818f)
			{
				this.HBJJOCHGOPH = 373f;
			}
			this.NBMPPNFKFLB().SetFloat("_Quality", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("challenges.", this.PLKFKNHPEHE[1] / 660f);
			this.HHIAIGCAHDA().SetFloat("resource id", this.PLKFKNHPEHE[0] / 50f);
			this.JFDGLLEOPGB().SetFloat("\n", this.PLKFKNHPEHE[3] / 405f);
			this.JFDGLLEOPGB().SetFloat("_Value13", this.PLKFKNHPEHE[7] / 1675f);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 1241f);
			this.NBMPPNFKFLB().SetFloat("Rtt:{0,4} +/-{1,3}", this.PLKFKNHPEHE[4] / 1929f);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_OldFilm1", this.PLKFKNHPEHE[3] / 1338f);
			this.BFGNMFCNDBC().SetFloat("_Value", this.PLKFKNHPEHE[2] / 340f);
			this.CFEDGDGBCHE().SetFloat(". Check if the server is available.", this.PLKFKNHPEHE[7] / 521f);
			this.JFDGLLEOPGB().SetFloat("#ok", this.PLKFKNHPEHE[-70] / 1378f);
			this.BFGNMFCNDBC().SetFloat("color", this.PLKFKNHPEHE[-73] / 366f);
			this.NFMGLIKNOOC().SetFloat("?", this.PLKFKNHPEHE[114] / 1661f);
			this.AELJLBOJAIL().SetFloat("/../", this.FadeFX);
			this.BFGNMFCNDBC().SetVector("OK", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 78f, 993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E54 RID: 20052 RVA: 0x00186778 File Offset: 0x00184978
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 254f)
			{
				this.HBJJOCHGOPH = 1028f;
			}
			this.NBPKMLMCHFN.SetFloat("/music", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Value2", this.PLKFKNHPEHE[0] / 1128f);
			this.HHIAIGCAHDA().SetFloat("-1", this.PLKFKNHPEHE[0] / 1190f);
			this.NFMGLIKNOOC().SetFloat("Unable to get a reward! Try again?", this.PLKFKNHPEHE[4] / 1450f);
			this.HNICHJCGJOC().SetFloat("SetSpeed", this.PLKFKNHPEHE[6] / 1191f);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Drawing_Halftone", this.PLKFKNHPEHE[1] / 214f);
			this.HFBJAOFLCJI().SetFloat("_TraceBehindObjects", this.PLKFKNHPEHE[2] / 43f);
			this.HHIAIGCAHDA().SetFloat("_Threshold", this.PLKFKNHPEHE[5] / 1150f);
			this.CFEDGDGBCHE().SetFloat("x", this.PLKFKNHPEHE[6] / 1159f);
			this.NBMPPNFKFLB().SetFloat("#91CCFF", this.PLKFKNHPEHE[3] / 1331f);
			this.KAFBNOBOIAJ().SetFloat("LoadingStatusText", this.PLKFKNHPEHE[43] / 978f);
			this.AELJLBOJAIL().SetFloat("_MainTex2", this.PLKFKNHPEHE[40] / 1979f);
			this.NBPKMLMCHFN.SetFloat(" id: ", this.PLKFKNHPEHE[92] / 451f);
			this.NDMPCDHADMJ().SetFloat("The process failed: ", this.FadeFX);
			this.NFMGLIKNOOC().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1827f, 463f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E55 RID: 20053 RVA: 0x001869A0 File Offset: 0x00184BA0
	private void MHLKBPJKIOL()
	{
		float[] array = new float[-57];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E56 RID: 20054 RVA: 0x001869BC File Offset: 0x00184BBC
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 12f)
			{
				this.HBJJOCHGOPH = 949f;
			}
			this.BFGNMFCNDBC().SetFloat("gamemode", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("[SERVER] Player ", this.PLKFKNHPEHE[1] / 1152f);
			this.HFBJAOFLCJI().SetFloat("_MainTex2", this.PLKFKNHPEHE[0] / 812f);
			this.HHIAIGCAHDA().SetFloat("Right Stick Click", this.PLKFKNHPEHE[4] / 1208f);
			this.KAFBNOBOIAJ().SetFloat("]", this.PLKFKNHPEHE[4] / 1682f);
			this.HFBJAOFLCJI().SetFloat("_BlurRadius4", this.PLKFKNHPEHE[4] / 129f);
			this.NFMGLIKNOOC().SetFloat("/music", this.PLKFKNHPEHE[7] / 92f);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/Blizzard", this.PLKFKNHPEHE[8] / 1013f);
			this.CFEDGDGBCHE().SetFloat("???", this.PLKFKNHPEHE[0] / 258f);
			this.NBMPPNFKFLB().SetFloat(" method: ", this.PLKFKNHPEHE[4] / 1736f);
			this.CFEDGDGBCHE().SetFloat("_Value2", this.PLKFKNHPEHE[-123] / 1979f);
			this.AELJLBOJAIL().SetFloat("player.goldcrystal", this.PLKFKNHPEHE[-66] / 107f);
			this.NFMGLIKNOOC().SetFloat("DPADHOR", this.PLKFKNHPEHE[48] / 562f);
			this.CFEDGDGBCHE().SetFloat("Joystick1Button2", this.FadeFX);
			this.NDMPCDHADMJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 849f, 870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E57 RID: 20055 RVA: 0x00186BE4 File Offset: 0x00184DE4
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1284f)
			{
				this.HBJJOCHGOPH = 1426f;
			}
			this.CFEDGDGBCHE().SetFloat("PunRespawn", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("/GetNews/pinnednewsid", this.PLKFKNHPEHE[0] / 717f);
			this.KAFBNOBOIAJ().SetFloat("ShineEffect", this.PLKFKNHPEHE[1] / 1624f);
			this.AELJLBOJAIL().SetFloat("Image", this.PLKFKNHPEHE[1] / 1716f);
			this.NBMPPNFKFLB().SetFloat("_Bullet_1", this.PLKFKNHPEHE[3] / 133f);
			this.KAFBNOBOIAJ().SetFloat("[SERVER] Kicked ", this.PLKFKNHPEHE[1] / 459f);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/Colors_HUE_Rotate", this.PLKFKNHPEHE[1] / 1154f);
			this.KAFBNOBOIAJ().SetFloat("owner: ", this.PLKFKNHPEHE[5] / 681f);
			this.NBMPPNFKFLB().SetFloat("_Parasite", this.PLKFKNHPEHE[5] / 1113f);
			this.DBOLLHHMKKN().SetFloat("_Value2", this.PLKFKNHPEHE[1] / 589f);
			this.KAFBNOBOIAJ().SetFloat(" ", this.PLKFKNHPEHE[-4] / 1162f);
			this.NDMPCDHADMJ().SetFloat("_Offsets", this.PLKFKNHPEHE[103] / 1001f);
			this.KAFBNOBOIAJ().SetFloat("SpeedSlider", this.PLKFKNHPEHE[122] / 602f);
			this.KAFBNOBOIAJ().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", this.FadeFX);
			this.AELJLBOJAIL().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 379f, 988f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E58 RID: 20056 RVA: 0x00186E0C File Offset: 0x0018500C
	private void HAIAHJPCPAG()
	{
		this.KHHCNLLEHDI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E59 RID: 20057 RVA: 0x00186E37 File Offset: 0x00185037
	private void EENNCFGECAE()
	{
		float[] array = new float[29];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004E5A RID: 20058 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06004E5B RID: 20059 RVA: 0x00186E51 File Offset: 0x00185051
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E5C RID: 20060 RVA: 0x00186E88 File Offset: 0x00185088
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E5D RID: 20061 RVA: 0x00186EC0 File Offset: 0x001850C0
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1338f)
			{
				this.HBJJOCHGOPH = 1359f;
			}
			this.HNICHJCGJOC().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_BlurFilterDistance", this.PLKFKNHPEHE[0] / 760f);
			this.BFGNMFCNDBC().SetFloat("z", this.PLKFKNHPEHE[1] / 1254f);
			this.CFEDGDGBCHE().SetFloat("float,1.5", this.PLKFKNHPEHE[8] / 757f);
			this.NBMPPNFKFLB().SetFloat("float,50", this.PLKFKNHPEHE[8] / 1801f);
			this.CFEDGDGBCHE().SetFloat("/", this.PLKFKNHPEHE[0] / 317f);
			this.NDMPCDHADMJ().SetFloat("ExitButton", this.PLKFKNHPEHE[4] / 1098f);
			this.BFGNMFCNDBC().SetFloat("Set Sun DirectionVector", this.PLKFKNHPEHE[6] / 1609f);
			this.CFEDGDGBCHE().SetFloat("FreqVolume: ", this.PLKFKNHPEHE[4] / 1454f);
			this.NBMPPNFKFLB().SetFloat(".png", this.PLKFKNHPEHE[1] / 888f);
			this.NBMPPNFKFLB().SetFloat("513510", this.PLKFKNHPEHE[-107] / 1203f);
			this.HHIAIGCAHDA().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[71] / 1675f);
			this.NBPKMLMCHFN.SetFloat("Sending vacant view IDs. Length: ", this.PLKFKNHPEHE[37] / 95f);
			this.BFGNMFCNDBC().SetFloat("settings.arcsdestroydelay", this.FadeFX);
			this.NFMGLIKNOOC().SetVector("ControllerRightY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1590f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E5E RID: 20062 RVA: 0x001870E8 File Offset: 0x001852E8
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 13f)
			{
				this.HBJJOCHGOPH = 1857f;
			}
			this.JFDGLLEOPGB().SetFloat("ShowSprite", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("PUNCloudBestRegion", this.PLKFKNHPEHE[0] / 137f);
			this.JFDGLLEOPGB().SetFloat("RoomDescriptionText", this.PLKFKNHPEHE[1] / 107f);
			this.KAFBNOBOIAJ().SetFloat("#close", this.PLKFKNHPEHE[5] / 632f);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.PLKFKNHPEHE[5] / 1552f);
			this.KAFBNOBOIAJ().SetFloat(": ", this.PLKFKNHPEHE[0] / 59f);
			this.NBMPPNFKFLB().SetFloat("SpawnObj", this.PLKFKNHPEHE[7] / 951f);
			this.CFEDGDGBCHE().SetFloat(" ; ", this.PLKFKNHPEHE[5] / 1741f);
			this.AELJLBOJAIL().SetFloat(". Going to authenticate anyways.", this.PLKFKNHPEHE[1] / 684f);
			this.KAFBNOBOIAJ().SetFloat("JoinButton", this.PLKFKNHPEHE[8] / 172f);
			this.HNICHJCGJOC().SetFloat("player.licenceaccepted", this.PLKFKNHPEHE[61] / 1271f);
			this.JFDGLLEOPGB().SetFloat("_Value4", this.PLKFKNHPEHE[-20] / 208f);
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[78] / 330f);
			this.CFEDGDGBCHE().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", this.FadeFX);
			this.NBPKMLMCHFN.SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1006f, 907f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E5F RID: 20063 RVA: 0x00187310 File Offset: 0x00185510
	private void DBGBCCBHBBC()
	{
		this.PBKELEKDBIC();
	}

	// Token: 0x0400083A RID: 2106
	private string ELOFMLPCCEA = "CameraFilterPack/Oculus_NightVision2";

	// Token: 0x0400083B RID: 2107
	public Shader SCShader;

	// Token: 0x0400083C RID: 2108
	[Range(0f, 1f)]
	public float FadeFX = 1f;

	// Token: 0x0400083D RID: 2109
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400083E RID: 2110
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400083F RID: 2111
	private Material BJFKDHHMLJH;

	// Token: 0x04000840 RID: 2112
	private float[] PLKFKNHPEHE;
}
