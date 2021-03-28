using System;
using UnityEngine;

// Token: 0x020000DA RID: 218
[AddComponentMenu("Camera Filter Pack/Glasses/Night Glasses")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On_3 : MonoBehaviour
{
	// Token: 0x060042D8 RID: 17112 RVA: 0x00148A5C File Offset: 0x00146C5C
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load("_ColorBuffer") as Texture2D);
		this.SCShader = Shader.Find("float,50");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042D9 RID: 17113 RVA: 0x00148A95 File Offset: 0x00146C95
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042DA RID: 17114 RVA: 0x00148A95 File Offset: 0x00146C95
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042DB RID: 17115 RVA: 0x00148AB2 File Offset: 0x00146CB2
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Speed") as Texture2D);
		this.SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042DC RID: 17116 RVA: 0x00148AEB File Offset: 0x00146CEB
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.shaders") as Texture2D);
		this.SCShader = Shader.Find("PunPickup");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042DD RID: 17117 RVA: 0x00148B24 File Offset: 0x00146D24
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042DF RID: 17119 RVA: 0x00148C1C File Offset: 0x00146E1C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 189f)
			{
				this.HBJJOCHGOPH = 1140f;
			}
			this.PDEAHJPOMEF().SetFloat("Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/Blur_DitherOffset", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("BloomShaderValueSlider", this.Fade);
			this.ADBKPGFMNKO().SetFloat("/", this.VisionBlur);
			this.HCGJCMDJPGD().SetFloat("challenges.", this.GlassDistortion);
			this.MMOODGIODPC().SetFloat("[ItemsHandler] Loading Steam inventory", this.GlassAberration);
			this.IIBLJCKLGFG().SetColor("(singleton) ", this.GlassesColor);
			this.ADBKPGFMNKO().SetColor(",", this.GlassesColor2);
			this.PDEAHJPOMEF().SetColor("_Value3", this.GlassColor);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", this.UseScanLineSize);
			this.MMOODGIODPC().SetFloat("SpawnObj", this.UseScanLine);
			this.PDEAHJPOMEF().SetTexture("#onrankchangedowntext", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042E0 RID: 17120 RVA: 0x00148A95 File Offset: 0x00146C95
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042E1 RID: 17121 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060042E2 RID: 17122 RVA: 0x00148D88 File Offset: 0x00146F88
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042E3 RID: 17123 RVA: 0x00148DBF File Offset: 0x00146FBF
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042E4 RID: 17124 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060042E5 RID: 17125 RVA: 0x00148DF6 File Offset: 0x00146FF6
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Glasses_On4") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042E6 RID: 17126 RVA: 0x00148A95 File Offset: 0x00146C95
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042E7 RID: 17127 RVA: 0x00148A95 File Offset: 0x00146C95
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042E8 RID: 17128 RVA: 0x00148A95 File Offset: 0x00146C95
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042E9 RID: 17129 RVA: 0x00148A95 File Offset: 0x00146C95
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042EA RID: 17130 RVA: 0x00148E2F File Offset: 0x0014702F
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042EB RID: 17131 RVA: 0x00148E66 File Offset: 0x00147066
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042EC RID: 17132 RVA: 0x00148E9D File Offset: 0x0014709D
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("value") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042ED RID: 17133 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060042EE RID: 17134 RVA: 0x00148A95 File Offset: 0x00146C95
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042EF RID: 17135 RVA: 0x00148A95 File Offset: 0x00146C95
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042F0 RID: 17136 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060042F1 RID: 17137 RVA: 0x00148ED6 File Offset: 0x001470D6
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042F2 RID: 17138 RVA: 0x00148F0D File Offset: 0x0014710D
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042F3 RID: 17139 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060042F4 RID: 17140 RVA: 0x00148F44 File Offset: 0x00147144
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042F5 RID: 17141 RVA: 0x00148F7B File Offset: 0x0014717B
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042F6 RID: 17142 RVA: 0x00148FB4 File Offset: 0x001471B4
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1505f)
			{
				this.HBJJOCHGOPH = 1466f;
			}
			this.LDNADDJMIPK().SetFloat("#tryagain", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("ItemTemplate", this.UseFinalGlassColor);
			this.OIMMPLPBLBK().SetFloat("z", this.Fade);
			this.NBPKMLMCHFN.SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", this.VisionBlur);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/OldFilm_Cutting2", this.GlassDistortion);
			this.ADBKPGFMNKO().SetFloat("CheckpointsScoreText", this.GlassAberration);
			this.IIBLJCKLGFG().SetColor("SetEnvSpriteImage", this.GlassesColor);
			this.HCGJCMDJPGD().SetColor("ws://", this.GlassesColor2);
			this.KGOLDDBHIFN().SetColor(".lastCheckpoint.time", this.GlassColor);
			this.MMOODGIODPC().SetFloat(": ", this.UseScanLineSize);
			this.IIBLJCKLGFG().SetFloat("Can't set visible when not in that room.", this.UseScanLine);
			this.OIMMPLPBLBK().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042F7 RID: 17143 RVA: 0x00149120 File Offset: 0x00147320
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

	// Token: 0x060042F8 RID: 17144 RVA: 0x0014928C File Offset: 0x0014748C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 517f)
			{
				this.HBJJOCHGOPH = 1487f;
			}
			this.NDMPCDHADMJ().SetFloat("music.ogg", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("OxOD.lastPath", this.UseFinalGlassColor);
			this.IIBLJCKLGFG().SetFloat("Mine", this.Fade);
			this.KGOLDDBHIFN().SetFloat("In Main Menu", this.VisionBlur);
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.GlassDistortion);
			this.JIBOKBCPDLC().SetFloat("_Value2", this.GlassAberration);
			this.KGOLDDBHIFN().SetColor(",", this.GlassesColor);
			this.JIBOKBCPDLC().SetColor("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", this.GlassesColor2);
			this.ADGHJOHKEHG().SetColor(" argument(s): ", this.GlassColor);
			this.OIMMPLPBLBK().SetFloat("GenerationMenu", this.UseScanLineSize);
			this.OIMMPLPBLBK().SetFloat("settings.enablehitsoundsinnormal", this.UseScanLine);
			this.JIBOKBCPDLC().SetTexture("speed", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042F9 RID: 17145 RVA: 0x001493F8 File Offset: 0x001475F8
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060042FA RID: 17146 RVA: 0x0014942F File Offset: 0x0014762F
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

	// Token: 0x060042FB RID: 17147 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060042FC RID: 17148 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060042FD RID: 17149 RVA: 0x00149466 File Offset: 0x00147666
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load(".GoalProgress") as Texture2D);
		this.SCShader = Shader.Find("Checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042FE RID: 17150 RVA: 0x0014949F File Offset: 0x0014769F
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042FF RID: 17151 RVA: 0x001494D6 File Offset: 0x001476D6
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("Added checkpoint") as Texture2D);
		this.SCShader = Shader.Find("team");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004300 RID: 17152 RVA: 0x0014950F File Offset: 0x0014770F
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004301 RID: 17153 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06004302 RID: 17154 RVA: 0x00149548 File Offset: 0x00147748
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 383f)
			{
				this.HBJJOCHGOPH = 503f;
			}
			this.ADBKPGFMNKO().SetFloat("_Sat", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("shader.ghost", this.UseFinalGlassColor);
			this.KGOLDDBHIFN().SetFloat("Prints list of commands", this.Fade);
			this.ADBKPGFMNKO().SetFloat("SetParticlesCountPerBeat", this.VisionBlur);
			this.JIBOKBCPDLC().SetFloat("entering", this.GlassDistortion);
			this.MMOODGIODPC().SetFloat("en", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("w", this.GlassesColor);
			this.HCGJCMDJPGD().SetColor("_Saturation", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("maps.", this.GlassColor);
			this.ADGHJOHKEHG().SetFloat("#no", this.UseScanLineSize);
			this.PDEAHJPOMEF().SetFloat("[ResourcesManager] Load image error: ", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("_DiffuseColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004303 RID: 17155 RVA: 0x00148A95 File Offset: 0x00146C95
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004304 RID: 17156 RVA: 0x001496B4 File Offset: 0x001478B4
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("Electronic") as Texture2D);
		this.SCShader = Shader.Find("ServerSettings: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004305 RID: 17157 RVA: 0x00148A95 File Offset: 0x00146C95
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004306 RID: 17158 RVA: 0x001496ED File Offset: 0x001478ED
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load(" - ") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004307 RID: 17159 RVA: 0x00149728 File Offset: 0x00147928
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1864f)
			{
				this.HBJJOCHGOPH = 948f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("colorB", this.UseFinalGlassColor);
			this.ADGHJOHKEHG().SetFloat("_Value6", this.Fade);
			this.PDEAHJPOMEF().SetFloat("Aug", this.VisionBlur);
			this.HCGJCMDJPGD().SetFloat("Instrumental", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat("_FarCamera", this.GlassAberration);
			this.KGOLDDBHIFN().SetColor("Done! You are a contributor until: ", this.GlassesColor);
			this.MMOODGIODPC().SetColor("MenuVolumeSlider", this.GlassesColor2);
			this.MMOODGIODPC().SetColor("UI Extensions/UISoftAdditive", this.GlassColor);
			this.PDEAHJPOMEF().SetFloat("\r", this.UseScanLineSize);
			this.LDNADDJMIPK().SetFloat("NO", this.UseScanLine);
			this.HCGJCMDJPGD().SetTexture(" at ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004308 RID: 17160 RVA: 0x00148A95 File Offset: 0x00146C95
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004309 RID: 17161 RVA: 0x00149894 File Offset: 0x00147A94
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 539f)
			{
				this.HBJJOCHGOPH = 1520f;
			}
			this.LDNADDJMIPK().SetFloat("curScn", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("Jump", this.UseFinalGlassColor);
			this.OIMMPLPBLBK().SetFloat("achievements.21.completed.", this.Fade);
			this.PDEAHJPOMEF().SetFloat(" Remote called.", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Vignetting", this.GlassDistortion);
			this.JIBOKBCPDLC().SetFloat("Commands for challenges", this.GlassAberration);
			this.KGOLDDBHIFN().SetColor("hidden", this.GlassesColor);
			this.KGOLDDBHIFN().SetColor("}", this.GlassesColor2);
			this.EMDFHOKEGNG().SetColor("_HighlightSuppression", this.GlassColor);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this.UseScanLineSize);
			this.KGOLDDBHIFN().SetFloat("#no", this.UseScanLine);
			this.OIMMPLPBLBK().SetTexture("Please attach component to a Graphical UI component", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600430A RID: 17162 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x0600430B RID: 17163 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600430C RID: 17164 RVA: 0x00149A00 File Offset: 0x00147C00
	private void KMCPMOGKDEH()
	{
		this.FPHEBLMINDA = (Resources.Load("EditMenu") as Texture2D);
		this.SCShader = Shader.Find("OpAuthenticate()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600430D RID: 17165 RVA: 0x00149A39 File Offset: 0x00147C39
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("Offline") as Texture2D);
		this.SCShader = Shader.Find("OpenButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600430E RID: 17166 RVA: 0x00149A74 File Offset: 0x00147C74
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 120f)
			{
				this.HBJJOCHGOPH = 1867f;
			}
			this.PDEAHJPOMEF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat(" Kb", this.UseFinalGlassColor);
			this.LDNADDJMIPK().SetFloat("Joystick1Button11", this.Fade);
			this.PDEAHJPOMEF().SetFloat("DifficultyBG", this.VisionBlur);
			this.PDEAHJPOMEF().SetFloat("|", this.GlassDistortion);
			this.JIBOKBCPDLC().SetFloat("_Value1", this.GlassAberration);
			this.NDMPCDHADMJ().SetColor("_AdaptationSpeed", this.GlassesColor);
			this.LDNADDJMIPK().SetColor("CameraFilterPack/Atmosphere_Rain_Pro_3D", this.GlassesColor2);
			this.OIMMPLPBLBK().SetColor("ServerSettings: ", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("Reload Maps", this.UseScanLineSize);
			this.MMOODGIODPC().SetFloat("/", this.UseScanLine);
			this.KGOLDDBHIFN().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600430F RID: 17167 RVA: 0x00149BE0 File Offset: 0x00147DE0
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1903f)
			{
				this.HBJJOCHGOPH = 297f;
			}
			this.NBPKMLMCHFN.SetFloat("float,1", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_EmissionColor", this.UseFinalGlassColor);
			this.HCGJCMDJPGD().SetFloat("[Left]", this.Fade);
			this.OIMMPLPBLBK().SetFloat("AreaTex", this.VisionBlur);
			this.IIBLJCKLGFG().SetFloat("SetSpeed", this.GlassDistortion);
			this.ADGHJOHKEHG().SetFloat("keys", this.GlassAberration);
			this.LDNADDJMIPK().SetColor(">", this.GlassesColor);
			this.HCGJCMDJPGD().SetColor("_MainTexBlurred", this.GlassesColor2);
			this.ADBKPGFMNKO().SetColor("CameraFilterPack/3D_Inverse", this.GlassColor);
			this.JIBOKBCPDLC().SetFloat("Back", this.UseScanLineSize);
			this.EMDFHOKEGNG().SetFloat("EventMenu", this.UseScanLine);
			this.LDNADDJMIPK().SetTexture("Item invalid. Make sure your mod contains at leats one file.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400070E RID: 1806
	public Shader SCShader;

	// Token: 0x0400070F RID: 1807
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000710 RID: 1808
	[Range(0f, 1f)]
	public float Fade = 0.3f;

	// Token: 0x04000711 RID: 1809
	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	// Token: 0x04000712 RID: 1810
	public Color GlassesColor = new Color(0.7f, 0.7f, 0.7f, 1f);

	// Token: 0x04000713 RID: 1811
	public Color GlassesColor2 = new Color(1f, 1f, 1f, 1f);

	// Token: 0x04000714 RID: 1812
	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	// Token: 0x04000715 RID: 1813
	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	// Token: 0x04000716 RID: 1814
	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	// Token: 0x04000717 RID: 1815
	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	// Token: 0x04000718 RID: 1816
	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	// Token: 0x04000719 RID: 1817
	public Color GlassColor = new Color(0f, 0.5f, 0f, 1f);

	// Token: 0x0400071A RID: 1818
	private Material BJFKDHHMLJH;

	// Token: 0x0400071B RID: 1819
	private Texture2D FPHEBLMINDA;
}
