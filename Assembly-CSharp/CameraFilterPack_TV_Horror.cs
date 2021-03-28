using System;
using UnityEngine;

// Token: 0x02000118 RID: 280
[AddComponentMenu("Camera Filter Pack/TV/Horror")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Horror : MonoBehaviour
{
	// Token: 0x060057C8 RID: 22472 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x060057C9 RID: 22473 RVA: 0x001B4147 File Offset: 0x001B2347
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057CA RID: 22474 RVA: 0x001B417E File Offset: 0x001B237E
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057CB RID: 22475 RVA: 0x001B419B File Offset: 0x001B239B
	private void JMEOGJHCONJ()
	{
		this.FPHEBLMINDA = (Resources.Load("Lag ") as Texture2D);
		this.SCShader = Shader.Find("PhotonView with ID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057CC RID: 22476 RVA: 0x001B417E File Offset: 0x001B237E
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057CD RID: 22477 RVA: 0x001B41D4 File Offset: 0x001B23D4
	private void BEBNOKFLJPH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057CE RID: 22478 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060057CF RID: 22479 RVA: 0x001B417E File Offset: 0x001B237E
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057D0 RID: 22480 RVA: 0x001B4210 File Offset: 0x001B2410
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1856f)
			{
				this.HBJJOCHGOPH = 472f;
			}
			this.HFBJAOFLCJI().SetFloat("RecieveChatActionMessage", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("challenges", this.Fade);
			this.MICHFGAOPKM().SetFloat("[ERROR KEY {0}]", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_Green_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 396f, 1283f));
			this.NDMPCDHADMJ().SetTexture("No child content found, exiting..", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057D1 RID: 22481 RVA: 0x001B42F9 File Offset: 0x001B24F9
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057D2 RID: 22482 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060057D3 RID: 22483 RVA: 0x001B417E File Offset: 0x001B237E
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057D4 RID: 22484 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060057D5 RID: 22485 RVA: 0x001B4330 File Offset: 0x001B2530
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 182f)
			{
				this.HBJJOCHGOPH = 410f;
			}
			this.HFBJAOFLCJI().SetFloat("LoadingStatusText", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat(" Owner called.", this.Fade);
			this.NDMPCDHADMJ().SetFloat(" (inactive)", this.Distortion);
			this.NFMGLIKNOOC().SetVector("MouseY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 135f, 281f));
			this.MICHFGAOPKM().SetTexture("0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x060057D6 RID: 22486 RVA: 0x001B4419 File Offset: 0x001B2619
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

	// Token: 0x060057D7 RID: 22487 RVA: 0x001B4450 File Offset: 0x001B2650
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("#restart") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057D8 RID: 22488 RVA: 0x001B448C File Offset: 0x001B268C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1618f)
			{
				this.HBJJOCHGOPH = 106f;
			}
			this.NDMPCDHADMJ().SetFloat("true", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("player.watermelon", this.Fade);
			this.HFBJAOFLCJI().SetFloat("_Value8", this.Distortion);
			this.JFDGLLEOPGB().SetVector("PossibleMapMaxScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 786f, 1457f));
			this.HFBJAOFLCJI().SetTexture("Waiting to start", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057D9 RID: 22489 RVA: 0x001B4578 File Offset: 0x001B2778
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1045f)
			{
				this.HBJJOCHGOPH = 1170f;
			}
			this.MICHFGAOPKM().SetFloat("Joystick1Button7", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Visualize", this.Fade);
			this.NFMGLIKNOOC().SetFloat(".lastCheckpoint.checkpointsUsed", this.Distortion);
			this.KBOPGONOCNP().SetVector("_Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 583f, 705f));
			this.IIBLJCKLGFG().SetTexture("CameraFilterPack/Blend2Camera_ColorDodge", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057DA RID: 22490 RVA: 0x001B4661 File Offset: 0x001B2861
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057DB RID: 22491 RVA: 0x001B4698 File Offset: 0x001B2898
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1365f)
			{
				this.HBJJOCHGOPH = 756f;
			}
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/Edge_Golden", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Received OnSerialization for view ID ", this.Fade);
			this.DBOLLHHMKKN().SetFloat("x", this.Distortion);
			this.NBPKMLMCHFN.SetVector("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1698f, 543f));
			this.MICHFGAOPKM().SetTexture("yes", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057DC RID: 22492 RVA: 0x001B4784 File Offset: 0x001B2984
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1469f)
			{
				this.HBJJOCHGOPH = 1417f;
			}
			this.KBOPGONOCNP().SetFloat("_Bullet_5", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.Fade);
			this.KBOPGONOCNP().SetFloat("Hidden/LensAberrations", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 558f, 764f));
			this.JFDGLLEOPGB().SetTexture("Connected to masterserver.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057DD RID: 22493 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060057DE RID: 22494 RVA: 0x001B417E File Offset: 0x001B237E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057DF RID: 22495 RVA: 0x001B4870 File Offset: 0x001B2A70
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1836f)
			{
				this.HBJJOCHGOPH = 1115f;
			}
			this.FAIFBBGFAIB().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("threshold", this.Fade);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/BlurTiltShift_V", this.Distortion);
			this.MICHFGAOPKM().SetVector(" not found", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1104f, 1647f));
			this.MICHFGAOPKM().SetTexture("ConnectUsingSettings() disabled the offline mode. No longer offline.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057E0 RID: 22496 RVA: 0x001B4959 File Offset: 0x001B2B59
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("_BlurredColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057E2 RID: 22498 RVA: 0x001B417E File Offset: 0x001B237E
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057E3 RID: 22499 RVA: 0x001B49BB File Offset: 0x001B2BBB
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057E4 RID: 22500 RVA: 0x001B49F2 File Offset: 0x001B2BF2
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057E5 RID: 22501 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060057E6 RID: 22502 RVA: 0x001B4A29 File Offset: 0x001B2C29
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057E7 RID: 22503 RVA: 0x001B4A60 File Offset: 0x001B2C60
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_HorrorFX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/TV_Horror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057E8 RID: 22504 RVA: 0x001B49BB File Offset: 0x001B2BBB
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057E9 RID: 22505 RVA: 0x001B4A99 File Offset: 0x001B2C99
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057EA RID: 22506 RVA: 0x001B417E File Offset: 0x001B237E
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057EB RID: 22507 RVA: 0x001B4AD0 File Offset: 0x001B2CD0
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("_PositionX") as Texture2D);
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057EC RID: 22508 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060057ED RID: 22509 RVA: 0x001B4B0C File Offset: 0x001B2D0C
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 784f)
			{
				this.HBJJOCHGOPH = 1829f;
			}
			this.JFDGLLEOPGB().SetFloat(" at ", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat(", ", this.Fade);
			this.JFDGLLEOPGB().SetFloat("DPADHOR", this.Distortion);
			this.IIBLJCKLGFG().SetVector("float,1.5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 294f, 431f));
			this.NDMPCDHADMJ().SetTexture("IconImage", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x001B4BF5 File Offset: 0x001B2DF5
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("Image") as Texture2D);
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057EF RID: 22511 RVA: 0x001B4C30 File Offset: 0x001B2E30
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1648f)
			{
				this.HBJJOCHGOPH = 863f;
			}
			this.JFDGLLEOPGB().SetFloat("colorB", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("COMPLETED", this.Fade);
			this.MICHFGAOPKM().SetFloat("OpGetGameList not sent. Lobby cannot be null.", this.Distortion);
			this.HFBJAOFLCJI().SetVector(" - GameWebCallback] - ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 238f, 755f));
			this.NDMPCDHADMJ().SetTexture("0,1,false", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057F0 RID: 22512 RVA: 0x001B417E File Offset: 0x001B237E
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057F1 RID: 22513 RVA: 0x001B4D1C File Offset: 0x001B2F1C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1057f)
			{
				this.HBJJOCHGOPH = 294f;
			}
			this.NBPKMLMCHFN.SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/FX_Hexagon", this.Fade);
			this.HFBJAOFLCJI().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", this.Distortion);
			this.JFDGLLEOPGB().SetVector("editor.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 725f, 57f));
			this.JFDGLLEOPGB().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057F2 RID: 22514 RVA: 0x001B4E05 File Offset: 0x001B3005
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057F3 RID: 22515 RVA: 0x001B4E3C File Offset: 0x001B303C
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
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057F4 RID: 22516 RVA: 0x001B4F28 File Offset: 0x001B3128
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 708f)
			{
				this.HBJJOCHGOPH = 364f;
			}
			this.NFMGLIKNOOC().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("Tab2Content", this.Fade);
			this.IIBLJCKLGFG().SetFloat("Set satellite trail length in seconds", this.Distortion);
			this.NFMGLIKNOOC().SetVector("ArcsHitsoundTimeDelaySlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 394f, 261f));
			this.DBOLLHHMKKN().SetTexture("SubmitUserVote:", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057F5 RID: 22517 RVA: 0x001B5014 File Offset: 0x001B3214
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 917f)
			{
				this.HBJJOCHGOPH = 1374f;
			}
			this.NBPKMLMCHFN.SetFloat("Preparing content", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_MainTex2", this.Fade);
			this.JFDGLLEOPGB().SetFloat("Day_", this.Distortion);
			this.MICHFGAOPKM().SetVector(". ActorNr: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1340f, 578f));
			this.JFDGLLEOPGB().SetTexture("_Amount", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057F6 RID: 22518 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x04000915 RID: 2325
	public Shader SCShader;

	// Token: 0x04000916 RID: 2326
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000917 RID: 2327
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000918 RID: 2328
	private Material BJFKDHHMLJH;

	// Token: 0x04000919 RID: 2329
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400091A RID: 2330
	[Range(0f, 1f)]
	public float Distortion = 1f;

	// Token: 0x0400091B RID: 2331
	private Texture2D FPHEBLMINDA;
}
