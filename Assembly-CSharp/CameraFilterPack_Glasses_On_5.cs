using System;
using UnityEngine;

// Token: 0x020000DC RID: 220
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Futuristic Montain")]
public class CameraFilterPack_Glasses_On_5 : MonoBehaviour
{
	// Token: 0x06004390 RID: 17296 RVA: 0x0014CABB File Offset: 0x0014ACBB
	private void BEBNOKFLJPH()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004391 RID: 17297 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004392 RID: 17298 RVA: 0x0014CAF4 File Offset: 0x0014ACF4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 867f)
			{
				this.HBJJOCHGOPH = 531f;
			}
			this.NBPKMLMCHFN.SetFloat(".lastCheckpoint.lives", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat(" not exist", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("offsets", this.Fade);
			this.HNICHJCGJOC().SetFloat("-", this.VisionBlur);
			this.HHIFMIPPMPF().SetFloat("mapselector.filter.favoriteonly", this.GlassDistortion);
			this.KGOLDDBHIFN().SetFloat("#savemapchanges?", this.GlassAberration);
			this.HFBJAOFLCJI().SetColor("scn", this.GlassesColor);
			this.HFBJAOFLCJI().SetColor("ChatInput", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("IconImage", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.UseScanLineSize);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.UseScanLine);
			this.HNICHJCGJOC().SetTexture("plogs", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004393 RID: 17299 RVA: 0x0014CC60 File Offset: 0x0014AE60
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004394 RID: 17300 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004395 RID: 17301 RVA: 0x0014CC98 File Offset: 0x0014AE98
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 860f)
			{
				this.HBJJOCHGOPH = 123f;
			}
			this.HHIFMIPPMPF().SetFloat("Missing shader for image effect {0}", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat(" SecondsBeforeRespawn: ", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("_Far", this.Fade);
			this.HNICHJCGJOC().SetFloat("Cant ask anyone else for PickupItem spawn times.", this.VisionBlur);
			this.HFBJAOFLCJI().SetFloat("Drop_Far", this.GlassDistortion);
			this.KGOLDDBHIFN().SetFloat("hidden", this.GlassAberration);
			this.OIMMPLPBLBK().SetColor("_Value", this.GlassesColor);
			this.HFBJAOFLCJI().SetColor("_Distortion", this.GlassesColor2);
			this.OIMMPLPBLBK().SetColor("float,1", this.GlassColor);
			this.KGOLDDBHIFN().SetFloat("_TexelOffsetScale", this.UseScanLineSize);
			this.HNICHJCGJOC().SetFloat("_Vignette", this.UseScanLine);
			this.OIMMPLPBLBK().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004396 RID: 17302 RVA: 0x0014CE04 File Offset: 0x0014B004
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load(" workshop map(s)") as Texture2D);
		this.SCShader = Shader.Find("Joystick1Button4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004397 RID: 17303 RVA: 0x0014CE40 File Offset: 0x0014B040
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1772f)
			{
				this.HBJJOCHGOPH = 582f;
			}
			this.HNICHJCGJOC().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_HighlightSuppression", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("<b>Intralism Items Uploader</b> by Oxy949", this.Fade);
			this.HHIFMIPPMPF().SetFloat("_Bullet_9", this.VisionBlur);
			this.HHIFMIPPMPF().SetFloat("Items/", this.GlassDistortion);
			this.OIMMPLPBLBK().SetFloat("player.redlifering", this.GlassAberration);
			this.HNICHJCGJOC().SetColor("SetSatelliteTrailLength", this.GlassesColor);
			this.HNICHJCGJOC().SetColor("_Value4", this.GlassesColor2);
			this.KGOLDDBHIFN().SetColor(" not exist", this.GlassColor);
			this.HHIFMIPPMPF().SetFloat("================================", this.UseScanLineSize);
			this.OIMMPLPBLBK().SetFloat("mapselector.filter.rateduponly", this.UseScanLine);
			this.HFBJAOFLCJI().SetTexture("yesterday", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004398 RID: 17304 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06004399 RID: 17305 RVA: 0x0014CFAC File Offset: 0x0014B1AC
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("Fill") as Texture2D);
		this.SCShader = Shader.Find("Beat Detected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600439A RID: 17306 RVA: 0x0014CFE5 File Offset: 0x0014B1E5
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Glasses_On6") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600439B RID: 17307 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x0600439C RID: 17308 RVA: 0x0014D01E File Offset: 0x0014B21E
	private void KLILJHJNICK()
	{
		this.FPHEBLMINDA = (Resources.Load("Tonemapper curve texture") as Texture2D);
		this.SCShader = Shader.Find("image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600439D RID: 17309 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x0600439E RID: 17310 RVA: 0x0014D057 File Offset: 0x0014B257
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600439F RID: 17311 RVA: 0x0014D08E File Offset: 0x0014B28E
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043A0 RID: 17312 RVA: 0x0014D0C5 File Offset: 0x0014B2C5
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043A1 RID: 17313 RVA: 0x0014D0E4 File Offset: 0x0014B2E4
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

	// Token: 0x060043A2 RID: 17314 RVA: 0x0014D250 File Offset: 0x0014B450
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("[LevelEditorScene] Print Audio Wave: Done") as Texture2D);
		this.SCShader = Shader.Find("2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043A3 RID: 17315 RVA: 0x0014D0C5 File Offset: 0x0014B2C5
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043A4 RID: 17316 RVA: 0x0014D289 File Offset: 0x0014B489
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043A5 RID: 17317 RVA: 0x0014D2C0 File Offset: 0x0014B4C0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 525f)
			{
				this.HBJJOCHGOPH = 837f;
			}
			this.OIMMPLPBLBK().SetFloat("Texture2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(" beatThreshold: ", this.UseFinalGlassColor);
			this.HHIFMIPPMPF().SetFloat(" region", this.Fade);
			this.HFBJAOFLCJI().SetFloat("_Color", this.VisionBlur);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.GlassDistortion);
			this.OIMMPLPBLBK().SetFloat(".", this.GlassAberration);
			this.OIMMPLPBLBK().SetColor("Object ID. Case-Sensitive", this.GlassesColor);
			this.HNICHJCGJOC().SetColor(".lastCheckpoint.powerupsScore", this.GlassesColor2);
			this.HNICHJCGJOC().SetColor("_Value3", this.GlassColor);
			this.KGOLDDBHIFN().SetFloat("float,0.5", this.UseScanLineSize);
			this.OIMMPLPBLBK().SetFloat("Closes the app", this.UseScanLine);
			this.OIMMPLPBLBK().SetTexture("nd", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043A6 RID: 17318 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x060043A7 RID: 17319 RVA: 0x0014D42C File Offset: 0x0014B62C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 927f)
			{
				this.HBJJOCHGOPH = 792f;
			}
			this.HNICHJCGJOC().SetFloat("_Level", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Skipping packet for ", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("_ReprojectionMatrix", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Gameplay/Base", this.VisionBlur);
			this.HFBJAOFLCJI().SetFloat("New resource ID. Case-Sensitive", this.GlassDistortion);
			this.KGOLDDBHIFN().SetFloat("{0} hours ago", this.GlassAberration);
			this.KGOLDDBHIFN().SetColor("UndoButton", this.GlassesColor);
			this.HFBJAOFLCJI().SetColor("_LutTex", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("ready", this.GlassColor);
			this.OIMMPLPBLBK().SetFloat("Vertical", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("_LrDepthTex", this.UseScanLine);
			this.HNICHJCGJOC().SetTexture("request", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043A8 RID: 17320 RVA: 0x0014D598 File Offset: 0x0014B798
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1258f)
			{
				this.HBJJOCHGOPH = 535f;
			}
			this.HNICHJCGJOC().SetFloat(" not found", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("Init", this.UseFinalGlassColor);
			this.HFBJAOFLCJI().SetFloat("_LoopCount", this.Fade);
			this.HHIFMIPPMPF().SetFloat("_History3ChromaTex", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("Please wait..", this.GlassDistortion);
			this.KGOLDDBHIFN().SetFloat("traffic", this.GlassAberration);
			this.KGOLDDBHIFN().SetColor("#yes", this.GlassesColor);
			this.HNICHJCGJOC().SetColor("_Value8", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("player.xp", this.GlassColor);
			this.HHIFMIPPMPF().SetFloat("challenges/", this.UseScanLineSize);
			this.HHIFMIPPMPF().SetFloat("GameScene", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("MapperNameText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043A9 RID: 17321 RVA: 0x0014D704 File Offset: 0x0014B904
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("Preparing content") as Texture2D);
		this.SCShader = Shader.Find(".lastCheckpoint.correctScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043AA RID: 17322 RVA: 0x0014D73D File Offset: 0x0014B93D
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060043AB RID: 17323 RVA: 0x0014D774 File Offset: 0x0014B974
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

	// Token: 0x060043AC RID: 17324 RVA: 0x0014D7AB File Offset: 0x0014B9AB
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("bans.viewed.") as Texture2D);
		this.SCShader = Shader.Find("SetupEncryption() got called. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400072A RID: 1834
	public Shader SCShader;

	// Token: 0x0400072B RID: 1835
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400072C RID: 1836
	[Range(0f, 1f)]
	public float Fade = 0.2f;

	// Token: 0x0400072D RID: 1837
	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	// Token: 0x0400072E RID: 1838
	public Color GlassesColor = new Color(0.1f, 0.1f, 0.1f, 1f);

	// Token: 0x0400072F RID: 1839
	public Color GlassesColor2 = new Color(0.45f, 0.45f, 0.45f, 0.25f);

	// Token: 0x04000730 RID: 1840
	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	// Token: 0x04000731 RID: 1841
	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	// Token: 0x04000732 RID: 1842
	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	// Token: 0x04000733 RID: 1843
	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	// Token: 0x04000734 RID: 1844
	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	// Token: 0x04000735 RID: 1845
	public Color GlassColor = new Color(0.1f, 0.3f, 1f, 1f);

	// Token: 0x04000736 RID: 1846
	private Material BJFKDHHMLJH;

	// Token: 0x04000737 RID: 1847
	private Texture2D FPHEBLMINDA;
}
