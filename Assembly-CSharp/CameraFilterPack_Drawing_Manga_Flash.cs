using System;
using UnityEngine;

// Token: 0x020000A3 RID: 163
[AddComponentMenu("Camera Filter Pack/Drawing/Manga_Flash")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Manga_Flash : MonoBehaviour
{
	// Token: 0x060030EC RID: 12524 RVA: 0x001027D0 File Offset: 0x001009D0
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 415f)
			{
				this.HBJJOCHGOPH = 913f;
			}
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("_Visualize", this.Size);
			this.NBPKMLMCHFN.SetFloat(" not exist", (float)this.Speed);
			this.KBOPGONOCNP().SetFloat("bool", this.PosX);
			this.NBPKMLMCHFN.SetFloat("grid", this.PosY);
			this.LONNIJMNKFB().SetFloat("menu.playedpage", this.Intensity);
			this.DNLMFEGJJDD().SetVector("SupportLogger OnFailedToConnectToPhoton(", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 976f, 1751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030ED RID: 12525 RVA: 0x001028E6 File Offset: 0x00100AE6
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x0010291D File Offset: 0x00100B1D
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("getbool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030EF RID: 12527 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060030F1 RID: 12529 RVA: 0x00102995 File Offset: 0x00100B95
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030F2 RID: 12530 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060030F3 RID: 12531 RVA: 0x001029CC File Offset: 0x00100BCC
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("OxOD.lastPath");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030F4 RID: 12532 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030F5 RID: 12533 RVA: 0x00102A0D File Offset: 0x00100C0D
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("ExitButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030F6 RID: 12534 RVA: 0x00102A31 File Offset: 0x00100C31
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_Linecount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030F7 RID: 12535 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060030F8 RID: 12536 RVA: 0x00102A55 File Offset: 0x00100C55
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030F9 RID: 12537 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x00102A7C File Offset: 0x00100C7C
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1270f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.KBOPGONOCNP().SetFloat(".a", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("distance", this.Size);
			this.NBPKMLMCHFN.SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", (float)this.Speed);
			this.DBOLLHHMKKN().SetFloat("/", this.PosX);
			this.KBOPGONOCNP().SetFloat("#useticket", this.PosY);
			this.KBOPGONOCNP().SetFloat(".played", this.Intensity);
			this.KBOPGONOCNP().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 836f, 1816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030FB RID: 12539 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030FC RID: 12540 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030FD RID: 12541 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060030FE RID: 12542 RVA: 0x00102B92 File Offset: 0x00100D92
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("GameObject ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030FF RID: 12543 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x00102BB8 File Offset: 0x00100DB8
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 468f)
			{
				this.HBJJOCHGOPH = 1970f;
			}
			this.NBPKMLMCHFN.SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Twist_Square", this.Size);
			this.NBPKMLMCHFN.SetFloat(". Sent by actorNr: ", (float)this.Speed);
			this.LONNIJMNKFB().SetFloat("#", this.PosX);
			this.KOHGPKOFEJO().SetFloat("_Value", this.PosY);
			this.DBOLLHHMKKN().SetFloat("float,0", this.Intensity);
			this.LONNIJMNKFB().SetVector("_EmissionColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1330f, 1687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003102 RID: 12546 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06003103 RID: 12547 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003104 RID: 12548 RVA: 0x00102CD0 File Offset: 0x00100ED0
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1378f)
			{
				this.HBJJOCHGOPH = 26f;
			}
			this.KOHGPKOFEJO().SetFloat("EndlessLoopsScoreText", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_RampOffset", this.Size);
			this.NBPKMLMCHFN.SetFloat("RecordButton", (float)this.Speed);
			this.DNLMFEGJJDD().SetFloat("EventSystem", this.PosX);
			this.EFDEIFCDAFG().SetFloat("\" gets executed locally only, if at all.", this.PosY);
			this.KBOPGONOCNP().SetFloat("maps.", this.Intensity);
			this.EFDEIFCDAFG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 460f, 1879f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003105 RID: 12549 RVA: 0x00102DE6 File Offset: 0x00100FE6
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("Mouse2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003106 RID: 12550 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003107 RID: 12551 RVA: 0x00102E0A File Offset: 0x0010100A
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003108 RID: 12552 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06003109 RID: 12553 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x0600310A RID: 12554 RVA: 0x00102E2E File Offset: 0x0010102E
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600310B RID: 12555 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600310C RID: 12556 RVA: 0x00102E65 File Offset: 0x00101065
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Flash");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600310D RID: 12557 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600310E RID: 12558 RVA: 0x00102E8C File Offset: 0x0010108C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 598f)
			{
				this.HBJJOCHGOPH = 692f;
			}
			this.LONNIJMNKFB().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("\n", this.Size);
			this.LONNIJMNKFB().SetFloat(".", (float)this.Speed);
			this.KOHGPKOFEJO().SetFloat("_ScreenResolution", this.PosX);
			this.LONNIJMNKFB().SetFloat("maps.", this.PosY);
			this.DNLMFEGJJDD().SetFloat("_Value3", this.Intensity);
			this.KOHGPKOFEJO().SetVector("ScreenResolutionPanel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 157f, 366f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600310F RID: 12559 RVA: 0x00102FA2 File Offset: 0x001011A2
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003110 RID: 12560 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003111 RID: 12561 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003112 RID: 12562 RVA: 0x00102FD9 File Offset: 0x001011D9
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003113 RID: 12563 RVA: 0x00103010 File Offset: 0x00101210
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 342f)
			{
				this.HBJJOCHGOPH = 616f;
			}
			this.LONNIJMNKFB().SetFloat("Apr", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_Offsets", this.Size);
			this.DBOLLHHMKKN().SetFloat("_SampleScale", (float)this.Speed);
			this.DBOLLHHMKKN().SetFloat("JoinRandom failed: {0}.", this.PosX);
			this.NBPKMLMCHFN.SetFloat("maps.", this.PosY);
			this.KOHGPKOFEJO().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", this.Intensity);
			this.EFDEIFCDAFG().SetVector("_Parameter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1290f, 6f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003114 RID: 12564 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06003115 RID: 12565 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06003116 RID: 12566 RVA: 0x00103126 File Offset: 0x00101326
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

	// Token: 0x06003117 RID: 12567 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003118 RID: 12568 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06003119 RID: 12569 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600311A RID: 12570 RVA: 0x00103160 File Offset: 0x00101360
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1915f)
			{
				this.HBJJOCHGOPH = 134f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value5", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("???", this.Size);
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", (float)this.Speed);
			this.KOHGPKOFEJO().SetFloat("_Bloom3", this.PosX);
			this.EFDEIFCDAFG().SetFloat("_Contrast", this.PosY);
			this.DNLMFEGJJDD().SetFloat("Image", this.Intensity);
			this.DNLMFEGJJDD().SetVector("ScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 149f, 1307f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600311B RID: 12571 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600311C RID: 12572 RVA: 0x00103276 File Offset: 0x00101476
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600311D RID: 12573 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600311E RID: 12574 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600311F RID: 12575 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003120 RID: 12576 RVA: 0x001032B0 File Offset: 0x001014B0
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1583f)
			{
				this.HBJJOCHGOPH = 1716f;
			}
			this.DBOLLHHMKKN().SetFloat("--------------------------------", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_Value5", this.Size);
			this.KOHGPKOFEJO().SetFloat("Malformed RPC; this should never occur. Content: ", (float)this.Speed);
			this.EFDEIFCDAFG().SetFloat("GroupNameText", this.PosX);
			this.EFDEIFCDAFG().SetFloat("_MainTex2", this.PosY);
			this.KOHGPKOFEJO().SetFloat("_Heigh", this.Intensity);
			this.KBOPGONOCNP().SetVector(" is muted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 323f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003121 RID: 12577 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003122 RID: 12578 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003123 RID: 12579 RVA: 0x001033C8 File Offset: 0x001015C8
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1498f)
			{
				this.HBJJOCHGOPH = 69f;
			}
			this.KOHGPKOFEJO().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("settings.volume.editor", this.Size);
			this.EFDEIFCDAFG().SetFloat("help", (float)this.Speed);
			this.KBOPGONOCNP().SetFloat("maps.", this.PosX);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.PosY);
			this.KOHGPKOFEJO().SetFloat("_TimeX", this.Intensity);
			this.DBOLLHHMKKN().SetVector("_EmissionColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 668f, 566f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003124 RID: 12580 RVA: 0x001034E0 File Offset: 0x001016E0
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 543f)
			{
				this.HBJJOCHGOPH = 1399f;
			}
			this.EFDEIFCDAFG().SetFloat("g", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("yyyy-MM-dd HH:mm:ss", this.Size);
			this.DBOLLHHMKKN().SetFloat("ChatHistoryInputField", (float)this.Speed);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Gradients_Hue", this.PosX);
			this.DBOLLHHMKKN().SetFloat("LostAllLives", this.PosY);
			this.NBPKMLMCHFN.SetFloat("[MapEditor] Created new map: ", this.Intensity);
			this.DBOLLHHMKKN().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1938f, 94f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003125 RID: 12581 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06003126 RID: 12582 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06003127 RID: 12583 RVA: 0x001035F8 File Offset: 0x001017F8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.Intensity);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003128 RID: 12584 RVA: 0x001029F0 File Offset: 0x00100BF0
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003129 RID: 12585 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x04000591 RID: 1425
	public Shader SCShader;

	// Token: 0x04000592 RID: 1426
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000593 RID: 1427
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000594 RID: 1428
	private Material BJFKDHHMLJH;

	// Token: 0x04000595 RID: 1429
	[Range(1f, 10f)]
	public float Size = 1f;

	// Token: 0x04000596 RID: 1430
	[Range(0f, 30f)]
	public int Speed = 5;

	// Token: 0x04000597 RID: 1431
	[Range(-1f, 1f)]
	public float PosX = 0.5f;

	// Token: 0x04000598 RID: 1432
	[Range(-1f, 1f)]
	public float PosY = 0.5f;

	// Token: 0x04000599 RID: 1433
	[Range(0f, 1f)]
	public float Intensity = 1f;
}
