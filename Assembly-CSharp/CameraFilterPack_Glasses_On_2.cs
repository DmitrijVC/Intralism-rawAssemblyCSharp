using System;
using UnityEngine;

// Token: 0x020000D9 RID: 217
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Vampire")]
public class CameraFilterPack_Glasses_On_2 : MonoBehaviour
{
	// Token: 0x060042B6 RID: 17078 RVA: 0x00147AB0 File Offset: 0x00145CB0
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042B7 RID: 17079 RVA: 0x00147AB0 File Offset: 0x00145CB0
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042B8 RID: 17080 RVA: 0x00147ACD File Offset: 0x00145CCD
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Glasses_On3") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Glasses_OnX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042B9 RID: 17081 RVA: 0x00147B08 File Offset: 0x00145D08
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1959f)
			{
				this.HBJJOCHGOPH = 554f;
			}
			this.NBPKMLMCHFN.SetFloat("_SmallTex", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("NO", this.UseFinalGlassColor);
			this.JIBOKBCPDLC().SetFloat("BitsData", this.Fade);
			this.NBPKMLMCHFN.SetFloat("menutheme.jamaicanorcdub", this.VisionBlur);
			this.HHIFMIPPMPF().SetFloat("ComboScoreText", this.GlassDistortion);
			this.PLBEJJIHFPB().SetFloat(". The group number should be at least 1.", this.GlassAberration);
			this.HHIFMIPPMPF().SetColor("_TimeX", this.GlassesColor);
			this.JIBOKBCPDLC().SetColor("Fade", this.GlassesColor2);
			this.HHIFMIPPMPF().SetColor("RPCs can only be sent in rooms. Call of \"", this.GlassColor);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.UseScanLineSize);
			this.JIBOKBCPDLC().SetFloat("restrictions\n\n#until: ", this.UseScanLine);
			this.PLBEJJIHFPB().SetTexture(" but this PhotonView does not exist! Was remote PV.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042BA RID: 17082 RVA: 0x00147C74 File Offset: 0x00145E74
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042BB RID: 17083 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060042BC RID: 17084 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060042BD RID: 17085 RVA: 0x00147CAB File Offset: 0x00145EAB
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042BE RID: 17086 RVA: 0x00147CE4 File Offset: 0x00145EE4
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1339f)
			{
				this.HBJJOCHGOPH = 82f;
			}
			this.JIBOKBCPDLC().SetFloat("X2", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Texture2", this.UseFinalGlassColor);
			this.PLBEJJIHFPB().SetFloat("menu.selectedlevelid", this.Fade);
			this.NBPKMLMCHFN.SetFloat("settings_bindings_", this.VisionBlur);
			this.HHIFMIPPMPF().SetFloat(".wav", this.GlassDistortion);
			this.PLBEJJIHFPB().SetFloat("id", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("FinalScoreSmallText", this.GlassesColor);
			this.NBPKMLMCHFN.SetColor("CompletedLevel", this.GlassesColor2);
			this.JIBOKBCPDLC().SetColor(") of this PhotonView does not implement OnPhotonSerializeView()!", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("PerfectHitsScoreText", this.UseScanLineSize);
			this.HHIFMIPPMPF().SetFloat("#newhighscore", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("{0}", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042BF RID: 17087 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060042C0 RID: 17088 RVA: 0x00147E50 File Offset: 0x00146050
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1895f)
			{
				this.HBJJOCHGOPH = 1419f;
			}
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ToPrevViewProjCombined", this.UseFinalGlassColor);
			this.JIBOKBCPDLC().SetFloat("_DistortionLevel", this.Fade);
			this.JIBOKBCPDLC().SetFloat("_ColoredChange", this.VisionBlur);
			this.PLBEJJIHFPB().SetFloat("_Value4", this.GlassDistortion);
			this.PLBEJJIHFPB().SetFloat("ClearEnvironment", this.GlassAberration);
			this.PLBEJJIHFPB().SetColor("USE_DIAG_SEARCH", this.GlassesColor);
			this.NBPKMLMCHFN.SetColor("ready", this.GlassesColor2);
			this.PLBEJJIHFPB().SetColor("_MainTex2", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("_VignettingColor", this.UseScanLineSize);
			this.PLBEJJIHFPB().SetFloat("/", this.UseScanLine);
			this.JIBOKBCPDLC().SetTexture("_Level", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042C1 RID: 17089 RVA: 0x00147FBC File Offset: 0x001461BC
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1376f)
			{
				this.HBJJOCHGOPH = 15f;
			}
			this.PLBEJJIHFPB().SetFloat("_Extra", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("EditMenu", this.Fade);
			this.PLBEJJIHFPB().SetFloat("#ok", this.VisionBlur);
			this.PLBEJJIHFPB().SetFloat("?", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat("vignetteIntensity", this.GlassAberration);
			this.HHIFMIPPMPF().SetColor(".lastCheckpoint.powerupsScore", this.GlassesColor);
			this.HHIFMIPPMPF().SetColor("bad", this.GlassesColor2);
			this.HHIFMIPPMPF().SetColor(" ", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("[MenuScene] Error: ", this.UseScanLineSize);
			this.JIBOKBCPDLC().SetFloat("_Value4", this.UseScanLine);
			this.PLBEJJIHFPB().SetTexture("Jun", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060042C2 RID: 17090 RVA: 0x00148128 File Offset: 0x00146328
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

	// Token: 0x060042C3 RID: 17091 RVA: 0x0014815F File Offset: 0x0014635F
	private void KMCPMOGKDEH()
	{
		this.FPHEBLMINDA = (Resources.Load("achievements.21.completed.workshop.") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042C4 RID: 17092 RVA: 0x00148198 File Offset: 0x00146398
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 493f)
			{
				this.HBJJOCHGOPH = 1472f;
			}
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat(".lastCheckpoint.incorrectScore", this.UseFinalGlassColor);
			this.PLBEJJIHFPB().SetFloat("error", this.Fade);
			this.HHIFMIPPMPF().SetFloat("[Up-Right-Down-Left]", this.VisionBlur);
			this.PLBEJJIHFPB().SetFloat("menu.enableselectormusic", this.GlassDistortion);
			this.JIBOKBCPDLC().SetFloat("Tab2Content", this.GlassAberration);
			this.HHIFMIPPMPF().SetColor("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", this.GlassesColor);
			this.PLBEJJIHFPB().SetColor("uploads/Intralism/mods_terms.pdf", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("_Dist", this.GlassColor);
			this.JIBOKBCPDLC().SetFloat("float,1.5", this.UseScanLineSize);
			this.JIBOKBCPDLC().SetFloat("[SERVER] Player ", this.UseScanLine);
			this.HHIFMIPPMPF().SetTexture("_Quality", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042C5 RID: 17093 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060042C6 RID: 17094 RVA: 0x00148304 File Offset: 0x00146504
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("received</b>\n#reason: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060042C7 RID: 17095 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060042C8 RID: 17096 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060042C9 RID: 17097 RVA: 0x00147AB0 File Offset: 0x00145CB0
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042CA RID: 17098 RVA: 0x00147AB0 File Offset: 0x00145CB0
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042CB RID: 17099 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060042CC RID: 17100 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060042CD RID: 17101 RVA: 0x00148340 File Offset: 0x00146540
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
			this.NBPKMLMCHFN.SetFloat("UseFinalGlassColor", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("VisionBlur", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("GlassDistortion", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat("GlassAberration", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("GlassesColor", this.GlassesColor);
			this.NBPKMLMCHFN.SetColor("GlassesColor2", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("GlassColor", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("UseScanLineSize", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("UseScanLine", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042CE RID: 17102 RVA: 0x00147AB0 File Offset: 0x00145CB0
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042D0 RID: 17104 RVA: 0x00148569 File Offset: 0x00146769
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("_ReflectionTexture1") as Texture2D);
		this.SCShader = Shader.Find("Bad parameters for delete! Use <key>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060042D1 RID: 17105 RVA: 0x001485A4 File Offset: 0x001467A4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 147f)
			{
				this.HBJJOCHGOPH = 1550f;
			}
			this.HHIFMIPPMPF().SetFloat("OpAuthenticate()", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("\" to target: ", this.UseFinalGlassColor);
			this.JIBOKBCPDLC().SetFloat("_MainTex2", this.Fade);
			this.HHIFMIPPMPF().SetFloat("_Value2", this.VisionBlur);
			this.PLBEJJIHFPB().SetFloat("ConfigVersionSlider", this.GlassDistortion);
			this.JIBOKBCPDLC().SetFloat("ShowSprite", this.GlassAberration);
			this.HHIFMIPPMPF().SetColor("#", this.GlassesColor);
			this.PLBEJJIHFPB().SetColor("menuVolume", this.GlassesColor2);
			this.HHIFMIPPMPF().SetColor("_Near", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("_CenterX", this.UseScanLineSize);
			this.PLBEJJIHFPB().SetFloat("_BlurTexture", this.UseScanLine);
			this.PLBEJJIHFPB().SetTexture("pointBuffer", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042D2 RID: 17106 RVA: 0x00148710 File Offset: 0x00146910
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value4") as Texture2D);
		this.SCShader = Shader.Find("_MaxRayTraceDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060042D3 RID: 17107 RVA: 0x0014874C File Offset: 0x0014694C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1548f)
			{
				this.HBJJOCHGOPH = 538f;
			}
			this.NBPKMLMCHFN.SetFloat("HiddenToggle", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.UseFinalGlassColor);
			this.JIBOKBCPDLC().SetFloat("_Value4", this.Fade);
			this.JIBOKBCPDLC().SetFloat("Error: you cannot write/send to this stream that you are reading!", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("Set Satellite Trail MinVertexDistance", this.GlassDistortion);
			this.JIBOKBCPDLC().SetFloat("X2", this.GlassAberration);
			this.HHIFMIPPMPF().SetColor("Done!", this.GlassesColor);
			this.NBPKMLMCHFN.SetColor(". The RPC has been ignored.", this.GlassesColor2);
			this.PLBEJJIHFPB().SetColor("Please specify either t or f.", this.GlassColor);
			this.PLBEJJIHFPB().SetFloat("plogs", this.UseScanLineSize);
			this.JIBOKBCPDLC().SetFloat("Right", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("SetSatelliteInput", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042D4 RID: 17108 RVA: 0x00147AB0 File Offset: 0x00145CB0
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042D5 RID: 17109 RVA: 0x001488B8 File Offset: 0x00146AB8
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042D6 RID: 17110 RVA: 0x001488F0 File Offset: 0x00146AF0
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1608f)
			{
				this.HBJJOCHGOPH = 384f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("Missing shader for image effect {0}", this.UseFinalGlassColor);
			this.PLBEJJIHFPB().SetFloat("_Color", this.Fade);
			this.JIBOKBCPDLC().SetFloat("musicVolume", this.VisionBlur);
			this.HHIFMIPPMPF().SetFloat("SetParent", this.GlassDistortion);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack/FX_Glitch3", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("QuickSave", this.GlassesColor);
			this.PLBEJJIHFPB().SetColor("skin.hit_normal", this.GlassesColor2);
			this.HHIFMIPPMPF().SetColor("shader.invert", this.GlassColor);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack_3D_Myst1", this.UseScanLineSize);
			this.PLBEJJIHFPB().SetFloat("The shader ", this.UseScanLine);
			this.HHIFMIPPMPF().SetTexture("Object ID. Case-Sensitive", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042D7 RID: 17111 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x04000700 RID: 1792
	public Shader SCShader;

	// Token: 0x04000701 RID: 1793
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000702 RID: 1794
	[Range(0f, 1f)]
	public float Fade = 0.2f;

	// Token: 0x04000703 RID: 1795
	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	// Token: 0x04000704 RID: 1796
	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	// Token: 0x04000705 RID: 1797
	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.25f, 0.25f);

	// Token: 0x04000706 RID: 1798
	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	// Token: 0x04000707 RID: 1799
	[Range(0f, 1f)]
	public float GlassAberration = 0.5f;

	// Token: 0x04000708 RID: 1800
	[Range(0f, 1f)]
	public float UseFinalGlassColor = 1f;

	// Token: 0x04000709 RID: 1801
	[Range(0f, 1f)]
	public float UseScanLine;

	// Token: 0x0400070A RID: 1802
	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	// Token: 0x0400070B RID: 1803
	public Color GlassColor = new Color(1f, 0f, 0f, 1f);

	// Token: 0x0400070C RID: 1804
	private Material BJFKDHHMLJH;

	// Token: 0x0400070D RID: 1805
	private Texture2D FPHEBLMINDA;
}
