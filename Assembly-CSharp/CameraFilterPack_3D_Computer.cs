using System;
using UnityEngine;

// Token: 0x0200001F RID: 31
[AddComponentMenu("Camera Filter Pack/3D/Computer")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Computer : MonoBehaviour
{
	// Token: 0x06000635 RID: 1589 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x000321CC File Offset: 0x000303CC
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x000321E9 File Offset: 0x000303E9
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00032220 File Offset: 0x00030420
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1706f)
			{
				this.HBJJOCHGOPH = 662f;
			}
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/Lut_TestMode", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("y", this.Fade);
			this.EFMCNLELMDO().SetFloat("OxOD.lastPath", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("[Left]", this.MatrixSize);
			this.IGKFMCPDNOI().SetColor("UndoButton", this._MatrixColor);
			this.KGOLDDBHIFN().SetFloat("/", this.MatrixSpeed * 1627f);
			this.HFBJAOFLCJI().SetFloat(",", (float)((!this._Visualize) ? 1 : 0));
			this.IIJMIPBMMBF().SetFloat("IconImage", this.LightIntensity);
			this.KGOLDDBHIFN().SetTexture("Down", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMAALEODNH().SetFloat("settings.volume.sfx", 1168f / farClipPlane);
			this.DKKBFFHBHJE().SetVector("\"x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 82f, 91f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x000323BC File Offset: 0x000305BC
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 44f)
			{
				this.HBJJOCHGOPH = 1874f;
			}
			this.HCGJCMDJPGD().SetFloat("\" error: ", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_Intensity", this.Fade);
			this.HHIAIGCAHDA().SetFloat("public", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat("SetEnvSpriteImage", this.MatrixSize);
			this.DOHGBNPMBKG().SetColor(".completed", this._MatrixColor);
			this.IIJMIPBMMBF().SetFloat("_FadeShield", this.MatrixSpeed * 173f);
			this.HHIAIGCAHDA().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", (float)((!this._Visualize) ? 1 : 0));
			this.KGOLDDBHIFN().SetFloat("SupportLogger OnCreatedRoom(", this.LightIntensity);
			this.EFMCNLELMDO().SetTexture("#done", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OLHDPICFBOF().SetFloat("ItemNameText", 1694f / farClipPlane);
			this.KGOLDDBHIFN().SetVector("float", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1535f, 1473f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00032555 File Offset: 0x00030755
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("file://") as Texture2D);
		this.SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x000321CC File Offset: 0x000303CC
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x0003258E File Offset: 0x0003078E
	private void MJEFMIPLFAB()
	{
		this.FPHEBLMINDA = (Resources.Load("_SunColor") as Texture2D);
		this.SCShader = Shader.Find("CorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x000325C7 File Offset: 0x000307C7
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("[MapEditor] Importing map: ") as Texture2D);
		this.SCShader = Shader.Find("<b>Speed</b>:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00032600 File Offset: 0x00030800
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 101f)
			{
				this.HBJJOCHGOPH = 1999f;
			}
			this.HFBJAOFLCJI().SetFloat("Data/Editor/leveltemplate", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("[PlayerController] ", this.Fade);
			this.IGKFMCPDNOI().SetFloat("LevelConfigButton", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("PerfectHitsScoreText", this.MatrixSize);
			this.FAIFBBGFAIB().SetColor("_BlendTex", this._MatrixColor);
			this.ADBKPGFMNKO().SetFloat("DestroyRpc", this.MatrixSpeed * 1455f);
			this.NBMPPNFKFLB().SetFloat("skin.no_hit", (float)((!this._Visualize) ? 0 : 0));
			this.IGKFMCPDNOI().SetFloat("_Value4", this.LightIntensity);
			this.DBOLLHHMKKN().SetTexture("SetCrosshairColor", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFMCNLELMDO().SetFloat("Zoom speed. Base 1.5", 143f / farClipPlane);
			this.HKHBBBFLGJH().SetVector("Left Stick Click", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1194f, 1399f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00032799 File Offset: 0x00030999
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x000327D0 File Offset: 0x000309D0
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("bool") as Texture2D);
		this.SCShader = Shader.Find("[CraftingPanel] Init");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00032809 File Offset: 0x00030A09
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00032840 File Offset: 0x00030A40
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
			this.NBPKMLMCHFN.SetFloat("_DepthLevel", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_MatrixSize", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("_MatrixColor", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("_MatrixSpeed", this.MatrixSpeed * 2f);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x000329D9 File Offset: 0x00030BD9
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Computer1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00032A14 File Offset: 0x00030C14
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1857f)
			{
				this.HBJJOCHGOPH = 1078f;
			}
			this.HHIAIGCAHDA().SetFloat("Set satellite beat detection sensitivity", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.Fade);
			this.DBOLLHHMKKN().SetFloat("_ExposureAdjustment", this._FixDistance);
			this.DKKBFFHBHJE().SetFloat("ChallengesButton", this.MatrixSize);
			this.HCGJCMDJPGD().SetColor("Error: Timeout :S", this._MatrixColor);
			this.HKHBBBFLGJH().SetFloat("#", this.MatrixSpeed * 1769f);
			this.DOHGBNPMBKG().SetFloat("PopulateMapsList", (float)((!this._Visualize) ? 1 : 1));
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.LightIntensity);
			this.ACHNOHCLGOO().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IIJMIPBMMBF().SetFloat("EnableRankingToggle", 79f / farClipPlane);
			this.JIBOKBCPDLC().SetVector("[GameScene] Submiting rank", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1256f, 1181f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00032BAD File Offset: 0x00030DAD
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00032BE4 File Offset: 0x00030DE4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1039f)
			{
				this.HBJJOCHGOPH = 1262f;
			}
			this.ADBKPGFMNKO().SetFloat("float,1.5", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_ReflectionBlur", this.Fade);
			this.DOHGBNPMBKG().SetFloat("ZoomSpeed", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("Triangle", this.MatrixSize);
			this.FAIFBBGFAIB().SetColor("Data/Skins/", this._MatrixColor);
			this.EFMCNLELMDO().SetFloat("_Threshhold", this.MatrixSpeed * 198f);
			this.KGOLDDBHIFN().SetFloat("RecieveChatActionMessage", (float)((!this._Visualize) ? 0 : 1));
			this.HHIAIGCAHDA().SetFloat("Can't set open when not in that room.", this.LightIntensity);
			this.DBOLLHHMKKN().SetTexture("#score", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LNLKMDPHDCC().SetFloat("Keypad", 57f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("HightScoreMaxPointsText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 442f, 1890f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00032D7D File Offset: 0x00030F7D
	private void PDHKMDBNGGN()
	{
		this.FPHEBLMINDA = (Resources.Load("[SaveSystem] Outdated savefile found") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/TV_PlanetMars");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600064A RID: 1610 RVA: 0x00032DB6 File Offset: 0x00030FB6
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

	// Token: 0x0600064B RID: 1611 RVA: 0x00032DED File Offset: 0x00030FED
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("0.00") as Texture2D);
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x000321CC File Offset: 0x000303CC
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00032E28 File Offset: 0x00031028
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 1310f;
			}
			this.AELJLBOJAIL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("maps.", this.Fade);
			this.ADBKPGFMNKO().SetFloat("_ScreenResolution", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("Set arcs speed. Base value - 15", this.MatrixSize);
			this.KEMAALEODNH().SetColor("_ScreenResolution", this._MatrixColor);
			this.IIJMIPBMMBF().SetFloat("All bindings reset to default values. PlayerPrefs have been removed for each key.", this.MatrixSpeed * 1880f);
			this.HKHBBBFLGJH().SetFloat("ChallengesButton", (float)((!this._Visualize) ? 0 : 1));
			this.HCGJCMDJPGD().SetFloat("ControllerLeftX", this.LightIntensity);
			this.DBOLLHHMKKN().SetTexture("_Far", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DKKBFFHBHJE().SetFloat("_EdgeSize", 836f / farClipPlane);
			this.NBMPPNFKFLB().SetVector("The directory was created successfully at ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 127f, 1018f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00032FC1 File Offset: 0x000311C1
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00032FF8 File Offset: 0x000311F8
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("Hidden/DepthOfField/DepthOfField") as Texture2D);
		this.SCShader = Shader.Find("View");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00033031 File Offset: 0x00031231
	private void AEDDNDHCLNN()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("AddEnvironmentSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x0003306A File Offset: 0x0003126A
	private void IDJKNBDKHBD()
	{
		this.FPHEBLMINDA = (Resources.Load("PLEASE WAIT") as Texture2D);
		this.SCShader = Shader.Find("Oct");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x000330A3 File Offset: 0x000312A3
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x000330DC File Offset: 0x000312DC
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 462f)
			{
				this.HBJJOCHGOPH = 679f;
			}
			this.KEMAALEODNH().SetFloat("VIGNETTE_BLUR", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("error", this.Fade);
			this.IGKFMCPDNOI().SetFloat("_BlurRadius4", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("Events Moved", this.MatrixSize);
			this.DBOLLHHMKKN().SetColor("Created", this._MatrixColor);
			this.IIJMIPBMMBF().SetFloat("shader.invert", this.MatrixSpeed * 736f);
			this.DOHGBNPMBKG().SetFloat("Set sun colors", (float)((!this._Visualize) ? 0 : 1));
			this.HFBJAOFLCJI().SetFloat("No font defined. Found font: ", this.LightIntensity);
			this.DKKBFFHBHJE().SetTexture("CameraFilterPack/Drawing_Paper3", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("LevelEditor/patterns", 1714f / farClipPlane);
			this.JIBOKBCPDLC().SetVector("mainmenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1734f, 1755f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00033275 File Offset: 0x00031475
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Pixel_Pixelisation") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x000332B0 File Offset: 0x000314B0
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 964f)
			{
				this.HBJJOCHGOPH = 866f;
			}
			this.IIJMIPBMMBF().SetFloat(". Set PhotonNetwork.OnEventCall.", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Set particles start speed", this.Fade);
			this.LNLKMDPHDCC().SetFloat("[Right]", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat(".b", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("]. Please verify you have this gameobject in a Resources folder.", this._MatrixColor);
			this.OLHDPICFBOF().SetFloat("_HeightParams", this.MatrixSpeed * 417f);
			this.OLHDPICFBOF().SetFloat("float,10", (float)((!this._Visualize) ? 0 : 1));
			this.ADBKPGFMNKO().SetFloat("_Extra", this.LightIntensity);
			this.DBOLLHHMKKN().SetTexture("Down", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DBOLLHHMKKN().SetFloat(".b", 1388f / farClipPlane);
			this.IGKFMCPDNOI().SetVector(">", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 398f, 786f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x000321CC File Offset: 0x000303CC
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00033449 File Offset: 0x00031649
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00033480 File Offset: 0x00031680
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("settings_bindings_") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x000334B9 File Offset: 0x000316B9
	private void CGDMLHLJIDK()
	{
		this.FPHEBLMINDA = (Resources.Load("RemoveHighlight") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x000334F2 File Offset: 0x000316F2
	private void HDMDKOKOOJC()
	{
		this.FPHEBLMINDA = (Resources.Load("/icon") as Texture2D);
		this.SCShader = Shader.Find("_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x000335A0 File Offset: 0x000317A0
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Tint") as Texture2D);
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x000335DC File Offset: 0x000317DC
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1734f)
			{
				this.HBJJOCHGOPH = 1883f;
			}
			this.HKHBBBFLGJH().SetFloat("Added unlock condition", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("st", this.Fade);
			this.HFBJAOFLCJI().SetFloat("Health Stats", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("VisionBlur", this.MatrixSize);
			this.ADBKPGFMNKO().SetColor(" respawn: ", this._MatrixColor);
			this.HFBJAOFLCJI().SetFloat("settings.gamemessagesduration", this.MatrixSpeed * 897f);
			this.NBPKMLMCHFN.SetFloat("OK", (float)((!this._Visualize) ? 1 : 1));
			this.HKHBBBFLGJH().SetFloat("[MapEditor] Importing map: ", this.LightIntensity);
			this.DBOLLHHMKKN().SetTexture(" should be overwritten.", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBMPPNFKFLB().SetFloat("_TimeX", 1642f / farClipPlane);
			this.JIBOKBCPDLC().SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1597f, 1217f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00033778 File Offset: 0x00031978
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 927f)
			{
				this.HBJJOCHGOPH = 6f;
			}
			this.EFMCNLELMDO().SetFloat("Right Stick Click", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_Value5", this.Fade);
			this.KGOLDDBHIFN().SetFloat("21x3", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat("ResetSpeed", this.MatrixSize);
			this.IIJMIPBMMBF().SetColor("_EmissionGain", this._MatrixColor);
			this.AELJLBOJAIL().SetFloat("MultiplayerButton", this.MatrixSpeed * 1780f);
			this.NBPKMLMCHFN.SetFloat("Most likely the game became empty during the switch to GameServer.", (float)((!this._Visualize) ? 1 : 0));
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack_3D_Computer1", this.LightIntensity);
			this.KEMAALEODNH().SetTexture("y", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.AELJLBOJAIL().SetFloat("Coroutine container not configured... did you forget to call Init?", 643f / farClipPlane);
			this.IIJMIPBMMBF().SetVector("CameraFilterPack/Vision_Blood", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1909f, 1799f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x000321CC File Offset: 0x000303CC
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00033911 File Offset: 0x00031B11
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0003394A File Offset: 0x00031B4A
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00033981 File Offset: 0x00031B81
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x000339B8 File Offset: 0x00031BB8
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 773f)
			{
				this.HBJJOCHGOPH = 1505f;
			}
			this.HCGJCMDJPGD().SetFloat("_Alpha2", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("settings.volume.game", this.Fade);
			this.OLHDPICFBOF().SetFloat("ItemNameText", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat("_PositionX", this.MatrixSize);
			this.EFMCNLELMDO().SetColor("_Distortion", this._MatrixColor);
			this.KEMAALEODNH().SetFloat("<b>", this.MatrixSpeed * 0f);
			this.IIJMIPBMMBF().SetFloat("#status", (float)((!this._Visualize) ? 0 : 1));
			this.NFKFAAHHLLM().SetFloat("GameScene", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("Currently, the limit of users is reached for this title. Try again later. Disconnecting", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKHBBBFLGJH().SetFloat("Edited unlock conditions", 1604f / farClipPlane);
			this.AELJLBOJAIL().SetVector("{0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1778f, 778f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x000321CC File Offset: 0x000303CC
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x000321CC File Offset: 0x000303CC
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00033B51 File Offset: 0x00031D51
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00033B88 File Offset: 0x00031D88
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1228f)
			{
				this.HBJJOCHGOPH = 892f;
			}
			this.IGKFMCPDNOI().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("#yes", this.Fade);
			this.IGKFMCPDNOI().SetFloat("/", this._FixDistance);
			this.NFKFAAHHLLM().SetFloat("SetParticlesParticleSize", this.MatrixSize);
			this.KEMAALEODNH().SetColor("Set object anchor to another object", this._MatrixColor);
			this.EFMCNLELMDO().SetFloat("Object ID. Case-Sensitive", this.MatrixSpeed * 335f);
			this.HCGJCMDJPGD().SetFloat("_FixDistance", (float)((!this._Visualize) ? 1 : 1));
			this.LNLKMDPHDCC().SetFloat(": ", this.LightIntensity);
			this.DBOLLHHMKKN().SetTexture(" cannot be used as a 3D LUT.", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFMCNLELMDO().SetFloat("CameraFilterPack_Paper4", 921f / farClipPlane);
			this.LNLKMDPHDCC().SetVector("#finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1853f, 1816f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00033D21 File Offset: 0x00031F21
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x000321CC File Offset: 0x000303CC
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00033D58 File Offset: 0x00031F58
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00033D8F File Offset: 0x00031F8F
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00033DC6 File Offset: 0x00031FC6
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x000321CC File Offset: 0x000303CC
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00033DFD File Offset: 0x00031FFD
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00033E34 File Offset: 0x00032034
	private void COOHIILCOCO()
	{
		this.FPHEBLMINDA = (Resources.Load("PointsScoreText") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Saturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x000321CC File Offset: 0x000303CC
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00033E6D File Offset: 0x0003206D
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load(". The group number should be at least 1.") as Texture2D);
		this.SCShader = Shader.Find("Set Satellite Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00033EA6 File Offset: 0x000320A6
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load(". No ViewIDs are free to use. Max is: ") as Texture2D);
		this.SCShader = Shader.Find("ItemTemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00033EDF File Offset: 0x000320DF
	private void LIBGAKMKHJJ()
	{
		this.FPHEBLMINDA = (Resources.Load("#no") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00033F18 File Offset: 0x00032118
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 349f)
			{
				this.HBJJOCHGOPH = 1644f;
			}
			this.HKHBBBFLGJH().SetFloat("&page=", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("history", this.Fade);
			this.HKHBBBFLGJH().SetFloat("1427616858", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("X2", this.MatrixSize);
			this.DBOLLHHMKKN().SetColor(" url: ", this._MatrixColor);
			this.DOHGBNPMBKG().SetFloat("[NetworkMenu] Joining ", this.MatrixSpeed * 1037f);
			this.NFKFAAHHLLM().SetFloat("mapselector.filter.favoriteonly", (float)((!this._Visualize) ? 1 : 1));
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.LightIntensity);
			this.KEMAALEODNH().SetTexture("GlassColor", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("_Value", 1957f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1478f, 343f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x000321CC File Offset: 0x000303CC
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x000340B1 File Offset: 0x000322B1
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_LighterColor") as Texture2D);
		this.SCShader = Shader.Find("3d text");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000340EC File Offset: 0x000322EC
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 556f)
			{
				this.HBJJOCHGOPH = 1254f;
			}
			this.OLHDPICFBOF().SetFloat("#ok", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Mouse Y", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Tab2Content", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/AAA_Super_Computer", this.MatrixSize);
			this.DBOLLHHMKKN().SetColor("_SSAO", this._MatrixColor);
			this.DOHGBNPMBKG().SetFloat("ready", this.MatrixSpeed * 30f);
			this.KGOLDDBHIFN().SetFloat("_Value5", (float)((!this._Visualize) ? 1 : 1));
			this.IIJMIPBMMBF().SetFloat("Set sun beat detection sensitivity", this.LightIntensity);
			this.DKKBFFHBHJE().SetTexture(": ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KGOLDDBHIFN().SetFloat("ScreenResolutionPanel", 1337f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("Chat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1890f, 1970f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x000321CC File Offset: 0x000303CC
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00034285 File Offset: 0x00032485
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("PublishButton") as Texture2D);
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x000342BE File Offset: 0x000324BE
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x000342F5 File Offset: 0x000324F5
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x0003432C File Offset: 0x0003252C
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 49f)
			{
				this.HBJJOCHGOPH = 176f;
			}
			this.NBMPPNFKFLB().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("InfoText", this.Fade);
			this.ADBKPGFMNKO().SetFloat("Joystick", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("_Value2", this.MatrixSize);
			this.OLHDPICFBOF().SetColor("127.0.0.1", this._MatrixColor);
			this.DOHGBNPMBKG().SetFloat("settings.enablehitsoundsinnormal", this.MatrixSpeed * 481f);
			this.OLHDPICFBOF().SetFloat("Lightning", (float)((!this._Visualize) ? 1 : 1));
			this.HKHBBBFLGJH().SetFloat("_Red_G", this.LightIntensity);
			this.HHIAIGCAHDA().SetTexture("_MainTex2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFMCNLELMDO().SetFloat("EndlessLoopsScoreText", 1006f / farClipPlane);
			this.NBMPPNFKFLB().SetVector("_SphereSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 854f, 1103f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x000321CC File Offset: 0x000303CC
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x000344C5 File Offset: 0x000326C5
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00032FC1 File Offset: 0x000311C1
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x000344FC File Offset: 0x000326FC
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack_TV_Vignetting1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00034535 File Offset: 0x00032735
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x0003456C File Offset: 0x0003276C
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x000345A4 File Offset: 0x000327A4
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1719f)
			{
				this.HBJJOCHGOPH = 502f;
			}
			this.DKKBFFHBHJE().SetFloat("addNewButton", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("maps.", this.Fade);
			this.LNLKMDPHDCC().SetFloat("[Up]", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("Joystick1Button3", this.MatrixSize);
			this.KGOLDDBHIFN().SetColor("ready", this._MatrixColor);
			this.KGOLDDBHIFN().SetFloat("InfoCanvas", this.MatrixSpeed * 509f);
			this.OLHDPICFBOF().SetFloat("CameraFilterPack_Paper2", (float)((!this._Visualize) ? 0 : 1));
			this.NFKFAAHHLLM().SetFloat("Exit to Windows", this.LightIntensity);
			this.KGOLDDBHIFN().SetTexture("4,28,true,0", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("HPToggle", 54f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("Reload Maps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1294f, 1723f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x000321CC File Offset: 0x000303CC
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x000321CC File Offset: 0x000303CC
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040000F2 RID: 242
	public Shader SCShader;

	// Token: 0x040000F3 RID: 243
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000F4 RID: 244
	public bool _Visualize;

	// Token: 0x040000F5 RID: 245
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000F6 RID: 246
	private Material BJFKDHHMLJH;

	// Token: 0x040000F7 RID: 247
	[Range(0f, 100f)]
	public float _FixDistance = 2f;

	// Token: 0x040000F8 RID: 248
	[Range(-5f, 5f)]
	public float LightIntensity = 1f;

	// Token: 0x040000F9 RID: 249
	[Range(0f, 8f)]
	public float MatrixSize = 2f;

	// Token: 0x040000FA RID: 250
	[Range(-4f, 4f)]
	public float MatrixSpeed = 0.1f;

	// Token: 0x040000FB RID: 251
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040000FC RID: 252
	public Color _MatrixColor = new Color(0f, 0.5f, 1f, 1f);

	// Token: 0x040000FD RID: 253
	public static Color ChangeColorRGB;

	// Token: 0x040000FE RID: 254
	private Texture2D FPHEBLMINDA;
}
