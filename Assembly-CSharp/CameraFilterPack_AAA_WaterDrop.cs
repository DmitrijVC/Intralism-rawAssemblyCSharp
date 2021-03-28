using System;
using UnityEngine;

// Token: 0x02000030 RID: 48
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/WaterDrop")]
public class CameraFilterPack_AAA_WaterDrop : MonoBehaviour
{
	// Token: 0x06000BFF RID: 3071 RVA: 0x00059248 File Offset: 0x00057448
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 352f)
			{
				this.HBJJOCHGOPH = 1859f;
			}
			this.ADAFMBOGPLN().SetFloat("(\\[ *i *\\])", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("_Value3", this.Distortion);
			this.LPCHMEKDCHI().SetFloat("CameraFilterPack_WaterDrop", this.SizeX);
			this.OCMBHMLNCEK().SetFloat("PossibleMapPointsText", this.SizeY);
			this.OOMFJGPAOKL().SetFloat("id", this.Speed);
			this.FKEOGPDLBDD().SetTexture("_Threshhold", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00059330 File Offset: 0x00057530
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("DifficultyBG") as Texture2D);
		this.SCShader = Shader.Find("_Green_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0005936C File Offset: 0x0005756C
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1683f)
			{
				this.HBJJOCHGOPH = 725f;
			}
			this.FEAEGGCNIAA().SetFloat("_Blue_G", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Value2", this.Distortion);
			this.DKNJGHFLAIF().SetFloat("Tab1Content", this.SizeX);
			this.NLFJGMBCICG().SetFloat("status", this.SizeY);
			this.HNICHJCGJOC().SetFloat("error", this.Speed);
			this.OOMFJGPAOKL().SetTexture("MaxLivesSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00059454 File Offset: 0x00057654
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 183f)
			{
				this.HBJJOCHGOPH = 465f;
			}
			this.LPCHMEKDCHI().SetFloat(".played", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("settings.crosshairopacity", this.Distortion);
			this.KBOPGONOCNP().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", this.SizeX);
			this.OOMFJGPAOKL().SetFloat("_Fade", this.SizeY);
			this.JCPDCGIJKJD().SetFloat("SpawnObj", this.Speed);
			this.DOHGBNPMBKG().SetTexture("/", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0005953C File Offset: 0x0005773C
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1629f)
			{
				this.HBJJOCHGOPH = 460f;
			}
			this.HHIFMIPPMPF().SetFloat("GhostFade2", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat(" not exist", this.Distortion);
			this.EHDJJANLINB().SetFloat("settings_bindings_controller_type", this.SizeX);
			this.FEAEGGCNIAA().SetFloat("offsets", this.SizeY);
			this.FEAEGGCNIAA().SetFloat("Moved event", this.Speed);
			this.GKILCDHJFEG().SetTexture("checkpoint", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00059624 File Offset: 0x00057824
	private void DOKAKEMDALN()
	{
		this.FPHEBLMINDA = (Resources.Load("color") as Texture2D);
		this.SCShader = Shader.Find("_FadeDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0005965D File Offset: 0x0005785D
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00059694 File Offset: 0x00057894
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x000596B1 File Offset: 0x000578B1
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x000596E8 File Offset: 0x000578E8
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1257f)
			{
				this.HBJJOCHGOPH = 1149f;
			}
			this.IIBLJCKLGFG().SetFloat("settings.selectormapsperpage", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("MenuScene", this.Distortion);
			this.HKHBBBFLGJH().SetFloat("_Value", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/TV_Video3D", this.SizeY);
			this.DOHGBNPMBKG().SetFloat(" not found", this.Speed);
			this.NLFJGMBCICG().SetTexture("Preparing configuration", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x000597D0 File Offset: 0x000579D0
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00059807 File Offset: 0x00057A07
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00059840 File Offset: 0x00057A40
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1376f)
			{
				this.HBJJOCHGOPH = 1718f;
			}
			this.HNICHJCGJOC().SetFloat("menu.hardcoreinfo", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("FPSToggle", this.Distortion);
			this.DEFBJOCJJKF().SetFloat("Set Satellite Sensitivity", this.SizeX);
			this.DKNJGHFLAIF().SetFloat("_TapLowForeground", this.SizeY);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/Blend2Camera_ColorKey", this.Speed);
			this.KBOPGONOCNP().SetTexture("GridDataStoryboard", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00059694 File Offset: 0x00057894
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00059928 File Offset: 0x00057B28
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x0005995F File Offset: 0x00057B5F
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00059998 File Offset: 0x00057B98
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 587f)
			{
				this.HBJJOCHGOPH = 326f;
			}
			this.NDMPCDHADMJ().SetFloat(":", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("maps.", this.Distortion);
			this.HKHBBBFLGJH().SetFloat("score", this.SizeX);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", this.SizeY);
			this.DKNJGHFLAIF().SetFloat("_CurTex", this.Speed);
			this.KBOPGONOCNP().SetTexture("BadgeText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00059694 File Offset: 0x00057894
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00059A80 File Offset: 0x00057C80
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1047f)
			{
				this.HBJJOCHGOPH = 513f;
			}
			this.KBOPGONOCNP().SetFloat("UseScanLine", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("[NetworkMenu] Joining ", this.Distortion);
			this.IIBLJCKLGFG().SetFloat("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("#ok", this.SizeY);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack_VHS2", this.Speed);
			this.HHIFMIPPMPF().SetTexture("LivesSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00059B68 File Offset: 0x00057D68
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 323f)
			{
				this.HBJJOCHGOPH = 313f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_SpawnHeuristic", this.Distortion);
			this.ADAFMBOGPLN().SetFloat("\" on viewID ", this.SizeX);
			this.IIBLJCKLGFG().SetFloat("#close", this.SizeY);
			this.IIBLJCKLGFG().SetFloat("newPath", this.Speed);
			this.DOHGBNPMBKG().SetTexture("_Offsets", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00059694 File Offset: 0x00057894
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00059C50 File Offset: 0x00057E50
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 326f;
			}
			this.FKEOGPDLBDD().SetFloat("_ForceYSwap", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("shader.none", this.Distortion);
			this.OCMBHMLNCEK().SetFloat("0", this.SizeX);
			this.DOHGBNPMBKG().SetFloat("_Level", this.SizeY);
			this.GHHPOGODBHB().SetFloat("#onrankchangeuptext", this.Speed);
			this.NLFJGMBCICG().SetTexture("Connection error: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00059D38 File Offset: 0x00057F38
	private void ALJEJJCIMJN()
	{
		this.FPHEBLMINDA = (Resources.Load("PLEASE WAIT") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00059694 File Offset: 0x00057894
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00059D71 File Offset: 0x00057F71
	private void NDBPCNICGLC()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button7") as Texture2D);
		this.SCShader = Shader.Find("HPToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x00059DAA File Offset: 0x00057FAA
	private void JKBMKPDGCHG()
	{
		this.FPHEBLMINDA = (Resources.Load("Preparing content...") as Texture2D);
		this.SCShader = Shader.Find("CountEventsGoal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x00059694 File Offset: 0x00057894
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00059DE4 File Offset: 0x00057FE4
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1172f)
			{
				this.HBJJOCHGOPH = 923f;
			}
			this.HCGJCMDJPGD().SetFloat("settings.hitvariation", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("InfoCanvas", this.Distortion);
			this.HCGJCMDJPGD().SetFloat("_Value2", this.SizeX);
			this.IONHGBPGCHK().SetFloat("WARNING: rotation axis set to 0 on ", this.SizeY);
			this.EHDJJANLINB().SetFloat("_TimeX", this.Speed);
			this.OOMFJGPAOKL().SetTexture("_Value3", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00059694 File Offset: 0x00057894
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00059ECC File Offset: 0x000580CC
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00059F44 File Offset: 0x00058144
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 332f)
			{
				this.HBJJOCHGOPH = 550f;
			}
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Gradients_Therma", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("#combo", this.Distortion);
			this.DKNJGHFLAIF().SetFloat("Items/", this.SizeX);
			this.LPCHMEKDCHI().SetFloat("_Bullet_10", this.SizeY);
			this.LPCHMEKDCHI().SetFloat("_ScreenResolution", this.Speed);
			this.HFBJAOFLCJI().SetTexture("\" gets executed locally only, if at all.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0005A02C File Offset: 0x0005822C
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("MultiplayerButton") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x0005A065 File Offset: 0x00058265
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0005A09C File Offset: 0x0005829C
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x0005A0D4 File Offset: 0x000582D4
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1375f)
			{
				this.HBJJOCHGOPH = 1936f;
			}
			this.DOMEEFLPEPJ().SetFloat(".png", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("s", this.Distortion);
			this.IIBLJCKLGFG().SetFloat("_CenterY", this.SizeX);
			this.NDMPCDHADMJ().SetFloat("OnAwakeRPC", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("float,10", this.Speed);
			this.ABHDNGIHBKE().SetTexture("#task", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0005A1BC File Offset: 0x000583BC
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_WaterDrop") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_WaterDrop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0005A1F5 File Offset: 0x000583F5
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0005A22C File Offset: 0x0005842C
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("float,0") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x0005A268 File Offset: 0x00058468
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 919f)
			{
				this.HBJJOCHGOPH = 548f;
			}
			this.OOMFJGPAOKL().SetFloat("ScrollPanel", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("checkpoint", this.Distortion);
			this.OCMBHMLNCEK().SetFloat("settings.volume.game", this.SizeX);
			this.FGENHBKMPDA().SetFloat("Mouse Y", this.SizeY);
			this.IIBLJCKLGFG().SetFloat("_TimeX", this.Speed);
			this.LPCHMEKDCHI().SetTexture("\n\n#", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0005A350 File Offset: 0x00058550
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1469f)
			{
				this.HBJJOCHGOPH = 42f;
			}
			this.KBOPGONOCNP().SetFloat("_Distortion2", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("IntraSig", this.Distortion);
			this.DKNJGHFLAIF().SetFloat("_MainTex2", this.SizeX);
			this.OCMBHMLNCEK().SetFloat("#close", this.SizeY);
			this.FKEOGPDLBDD().SetFloat("_TimeX", this.Speed);
			this.FKEOGPDLBDD().SetTexture("ConfigVersionSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0005A438 File Offset: 0x00058638
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 560f)
			{
				this.HBJJOCHGOPH = 182f;
			}
			this.HCGJCMDJPGD().SetFloat("menutheme.hunter", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat(" not exist", this.Distortion);
			this.NDMPCDHADMJ().SetFloat("Created by ", this.SizeX);
			this.HCGJCMDJPGD().SetFloat("skin.hit_perfect", this.SizeY);
			this.ECCPAOBFDKP().SetFloat("Authentication failed: '{0}' Code: {1}", this.Speed);
			this.DEFBJOCJJKF().SetTexture("[Left]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0005A520 File Offset: 0x00058720
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("#ok") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x0005A559 File Offset: 0x00058759
	private void MDNHCLKNCLE()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.enablehitsoundsinrelax") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x0005A594 File Offset: 0x00058794
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1743f)
			{
				this.HBJJOCHGOPH = 424f;
			}
			this.DEFBJOCJJKF().SetFloat("caret", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", this.Distortion);
			this.IIBLJCKLGFG().SetFloat("/music", this.SizeX);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Glasses_On", this.SizeY);
			this.JCPDCGIJKJD().SetFloat("-showlogs", this.Speed);
			this.HCGJCMDJPGD().SetTexture(".lastCheckpoint.playerdistance", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x0005A67C File Offset: 0x0005887C
	private void KOFAMEKHHGD()
	{
		this.FPHEBLMINDA = (Resources.Load("Fade") as Texture2D);
		this.SCShader = Shader.Find("no lives color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x0005A6B5 File Offset: 0x000588B5
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x0005A6EC File Offset: 0x000588EC
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x00059694 File Offset: 0x00057894
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C3A RID: 3130 RVA: 0x0005A723 File Offset: 0x00058923
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C3B RID: 3131 RVA: 0x00059694 File Offset: 0x00057894
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00059694 File Offset: 0x00057894
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x00059694 File Offset: 0x00057894
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x0005A75C File Offset: 0x0005895C
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1554f)
			{
				this.HBJJOCHGOPH = 1288f;
			}
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("mapselector.tags.", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("_Intensity", this.SizeX);
			this.DKNJGHFLAIF().SetFloat("_EmissionColor", this.SizeY);
			this.CFEDGDGBCHE().SetFloat("menu.playedpage", this.Speed);
			this.FKEOGPDLBDD().SetTexture("SetBGColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x0005A844 File Offset: 0x00058A44
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_SizeX", this.SizeX);
			this.NBPKMLMCHFN.SetFloat("_SizeY", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x0005A92C File Offset: 0x00058B2C
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x0005A963 File Offset: 0x00058B63
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x00059694 File Offset: 0x00057894
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x0005A99C File Offset: 0x00058B9C
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1399f)
			{
				this.HBJJOCHGOPH = 1644f;
			}
			this.DOHGBNPMBKG().SetFloat("maps.", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("?", this.Distortion);
			this.IIBLJCKLGFG().SetFloat("_Near", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/EyesVision_2", this.SizeY);
			this.HCGJCMDJPGD().SetFloat("_Value6", this.Speed);
			this.FKEOGPDLBDD().SetTexture("inventory.selected.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x0005AA84 File Offset: 0x00058C84
	private void ADPLHDFJFID()
	{
		this.FPHEBLMINDA = (Resources.Load("PunPickupSimple") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x0005AAC0 File Offset: 0x00058CC0
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 553f)
			{
				this.HBJJOCHGOPH = 1628f;
			}
			this.LDNADDJMIPK().SetFloat("Created", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_PositionX", this.Distortion);
			this.DOMEEFLPEPJ().SetFloat("MenuVolumeSlider", this.SizeX);
			this.GHHPOGODBHB().SetFloat("ERROR: Preview file must be <1MB!", this.SizeY);
			this.HHIFMIPPMPF().SetFloat(".lastCheckpoint.powerupsScore", this.Speed);
			this.OCMBHMLNCEK().SetTexture("#score", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x0005ABA8 File Offset: 0x00058DA8
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x0005ABDF File Offset: 0x00058DDF
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load("Connection error: ") as Texture2D);
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x0005AC18 File Offset: 0x00058E18
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 515f)
			{
				this.HBJJOCHGOPH = 422f;
			}
			this.EHDJJANLINB().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("EventMenu", this.Distortion);
			this.OIBHFCLJKDB().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", this.SizeX);
			this.FKEOGPDLBDD().SetFloat("#91CCFF", this.SizeY);
			this.LPCHMEKDCHI().SetFloat("GameScene", this.Speed);
			this.FKEOGPDLBDD().SetTexture("CameraFilterPack/Color_YUV", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x0005AD00 File Offset: 0x00058F00
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1893f)
			{
				this.HBJJOCHGOPH = 1682f;
			}
			this.IONHGBPGCHK().SetFloat("_BlurVector", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("GlassColor", this.Distortion);
			this.DOHGBNPMBKG().SetFloat("\\\\", this.SizeX);
			this.IIBLJCKLGFG().SetFloat(" b.", this.SizeY);
			this.HCGJCMDJPGD().SetFloat("Fade", this.Speed);
			this.FEAEGGCNIAA().SetTexture("_Saturation", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x0005ADE8 File Offset: 0x00058FE8
	private void FMNPFCHBLJF()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_DarkerColor") as Texture2D);
		this.SCShader = Shader.Find("_ColorBuffer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0005AE21 File Offset: 0x00059021
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

	// Token: 0x06000C50 RID: 3152 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00059694 File Offset: 0x00057894
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x0005AE58 File Offset: 0x00059058
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x0005AE90 File Offset: 0x00059090
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 219f)
			{
				this.HBJJOCHGOPH = 459f;
			}
			this.GKILCDHJFEG().SetFloat("achievements.id", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("_SpawnHeuristic", this.Distortion);
			this.HCGJCMDJPGD().SetFloat("_Value", this.SizeX);
			this.DOMEEFLPEPJ().SetFloat("InfoCanvas", this.SizeY);
			this.OIBHFCLJKDB().SetFloat("float,0", this.Speed);
			this.KBOPGONOCNP().SetTexture("LevelEditor/CustomEventEditor-Text", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x0005AF78 File Offset: 0x00059178
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("SetSunMaxSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00059694 File Offset: 0x00057894
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x0005AFB4 File Offset: 0x000591B4
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 841f)
			{
				this.HBJJOCHGOPH = 1018f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Pixel_Pixelisation", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/Pixelisation_OilPaint", this.Distortion);
			this.CFEDGDGBCHE().SetFloat("_Value", this.SizeX);
			this.JCPDCGIJKJD().SetFloat("menu.selectedplaymode", this.SizeY);
			this.KEMAALEODNH().SetFloat("help", this.Speed);
			this.OIBHFCLJKDB().SetTexture("Add Environment Object", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x0005B09C File Offset: 0x0005929C
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0005B0D3 File Offset: 0x000592D3
	private void OGJJDKENBNC()
	{
		this.FPHEBLMINDA = (Resources.Load("UseFinalGlassColor") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Real_VHS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x0005B10C File Offset: 0x0005930C
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x0005B144 File Offset: 0x00059344
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 632f)
			{
				this.HBJJOCHGOPH = 1209f;
			}
			this.NBPKMLMCHFN.SetFloat("RoomNameText", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_MainTex2", this.Distortion);
			this.GKILCDHJFEG().SetFloat("_ScreenResolution", this.SizeX);
			this.ECCPAOBFDKP().SetFloat("Set satellite trail width", this.SizeY);
			this.GKILCDHJFEG().SetFloat("SfxVolumeSlider", this.Speed);
			this.OCMBHMLNCEK().SetTexture("No connection to item server!", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x0005B22C File Offset: 0x0005942C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 312f)
			{
				this.HBJJOCHGOPH = 1755f;
			}
			this.GHHPOGODBHB().SetFloat("Items/", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("_Min", this.Distortion);
			this.LDNADDJMIPK().SetFloat("Tab2Content", this.SizeX);
			this.KBOPGONOCNP().SetFloat("<b>#", this.SizeY);
			this.FKEOGPDLBDD().SetFloat("Set Satellite Emission", this.Speed);
			this.HNICHJCGJOC().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0005B314 File Offset: 0x00059514
	private void NKFDNIAKGEO()
	{
		this.FPHEBLMINDA = (Resources.Load(".status") as Texture2D);
		this.SCShader = Shader.Find("_Red_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00059694 File Offset: 0x00057894
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x0005B34D File Offset: 0x0005954D
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0005B384 File Offset: 0x00059584
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x0005B3BC File Offset: 0x000595BC
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 411f)
			{
				this.HBJJOCHGOPH = 1750f;
			}
			this.HKGAONMOBMH().SetFloat("Sent count: ", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_8bits_gb", this.Distortion);
			this.DOHGBNPMBKG().SetFloat("SetSpeed", this.SizeX);
			this.LDNADDJMIPK().SetFloat("RenderTextureUtilityTempTexture", this.SizeY);
			this.FEAEGGCNIAA().SetFloat("_AreaTex", this.Speed);
			this.LPCHMEKDCHI().SetTexture("player.greenarc", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x0005A1F5 File Offset: 0x000583F5
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00059694 File Offset: 0x00057894
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0005B4A4 File Offset: 0x000596A4
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0005B4DC File Offset: 0x000596DC
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1089f)
			{
				this.HBJJOCHGOPH = 1259f;
			}
			this.HHIFMIPPMPF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("\\n", this.Distortion);
			this.HCGJCMDJPGD().SetFloat("Item ", this.SizeX);
			this.DKNJGHFLAIF().SetFloat("maps.", this.SizeY);
			this.ABHDNGIHBKE().SetFloat("_OcclusionTexture", this.Speed);
			this.HHIFMIPPMPF().SetTexture("0.00", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x0005A92C File Offset: 0x00058B2C
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x0005B5C4 File Offset: 0x000597C4
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1752f)
			{
				this.HBJJOCHGOPH = 945f;
			}
			this.FKEOGPDLBDD().SetFloat("[PlayerBase] Unknown event: ", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("_TimeX", this.Distortion);
			this.HKHBBBFLGJH().SetFloat("\" for viewID ", this.SizeX);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Glow_Glow", this.SizeY);
			this.GKILCDHJFEG().SetFloat(",", this.Speed);
			this.FKEOGPDLBDD().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x0005B6AC File Offset: 0x000598AC
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1752f)
			{
				this.HBJJOCHGOPH = 649f;
			}
			this.LPCHMEKDCHI().SetFloat("MultiplayerButton", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("_Value7", this.Distortion);
			this.ABHDNGIHBKE().SetFloat("settings.disablestoryboard", this.SizeX);
			this.DOMEEFLPEPJ().SetFloat("< true | false >", this.SizeY);
			this.JCPDCGIJKJD().SetFloat("_ForegroundBlurExtrude", this.Speed);
			this.FKEOGPDLBDD().SetTexture("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x0005B794 File Offset: 0x00059994
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x0005B7CC File Offset: 0x000599CC
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1727f)
			{
				this.HBJJOCHGOPH = 327f;
			}
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack_Paper4", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("Icon", this.Distortion);
			this.KEMAALEODNH().SetFloat("_Far", this.SizeX);
			this.HKGAONMOBMH().SetFloat("Items", this.SizeY);
			this.HKHBBBFLGJH().SetFloat("_MatrixColor", this.Speed);
			this.KEMAALEODNH().SetTexture("OK", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0005B8B4 File Offset: 0x00059AB4
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00059694 File Offset: 0x00057894
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x0005B8EB File Offset: 0x00059AEB
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x0005B922 File Offset: 0x00059B22
	private void IKDNLHLBHID()
	{
		this.FPHEBLMINDA = (Resources.Load("Send") as Texture2D);
		this.SCShader = Shader.Find("GameModeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x0005B95B File Offset: 0x00059B5B
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x00059694 File Offset: 0x00057894
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x0005B992 File Offset: 0x00059B92
	private void FIJHDKIPENG()
	{
		this.FPHEBLMINDA = (Resources.Load("Connection failed: ") as Texture2D);
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x0005B9CC File Offset: 0x00059BCC
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 259f)
			{
				this.HBJJOCHGOPH = 590f;
			}
			this.IONHGBPGCHK().SetFloat("<b>Time</b>:", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("_ExposureAdjustment", this.Distortion);
			this.LDNADDJMIPK().SetFloat("maps.", this.SizeX);
			this.CFEDGDGBCHE().SetFloat("Drop_Near", this.SizeY);
			this.OOMFJGPAOKL().SetFloat("_Value3", this.Speed);
			this.OOMFJGPAOKL().SetTexture("In Main Menu", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x0005BAB4 File Offset: 0x00059CB4
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1697f)
			{
				this.HBJJOCHGOPH = 1011f;
			}
			this.GHHPOGODBHB().SetFloat("Bad parameters for setbool! Use <key> <value>", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("yes", this.Distortion);
			this.FKEOGPDLBDD().SetFloat("settings.arcshitsoundtimedelay", this.SizeX);
			this.FEAEGGCNIAA().SetFloat("_PColor2", this.SizeY);
			this.CFEDGDGBCHE().SetFloat("Achievement 21 progress reseted", this.Speed);
			this.GKILCDHJFEG().SetTexture(".played", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x0005BB9C File Offset: 0x00059D9C
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00059694 File Offset: 0x00057894
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x00059694 File Offset: 0x00057894
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x00059694 File Offset: 0x00057894
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x0005BBD3 File Offset: 0x00059DD3
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0005BC0A File Offset: 0x00059E0A
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x0005BC41 File Offset: 0x00059E41
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x0005BC78 File Offset: 0x00059E78
	private void AEOLJEIDMDB()
	{
		this.FPHEBLMINDA = (Resources.Load("_Green_C") as Texture2D);
		this.SCShader = Shader.Find("_Params3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040001DA RID: 474
	public Shader SCShader;

	// Token: 0x040001DB RID: 475
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001DC RID: 476
	[Range(8f, 64f)]
	public float Distortion = 8f;

	// Token: 0x040001DD RID: 477
	[Range(0f, 7f)]
	public float SizeX = 1f;

	// Token: 0x040001DE RID: 478
	[Range(0f, 7f)]
	public float SizeY = 0.5f;

	// Token: 0x040001DF RID: 479
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x040001E0 RID: 480
	private Material BJFKDHHMLJH;

	// Token: 0x040001E1 RID: 481
	private Texture2D FPHEBLMINDA;
}
