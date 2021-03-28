using System;
using UnityEngine;

// Token: 0x020000D5 RID: 213
[AddComponentMenu("Camera Filter Pack/FX/Spot")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Spot : MonoBehaviour
{
	// Token: 0x060040BE RID: 16574 RVA: 0x00140364 File Offset: 0x0013E564
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1799f)
			{
				this.HBJJOCHGOPH = 1853f;
			}
			this.KGOLDDBHIFN().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", this.center.x);
			this.LEIAFCPJMDP().SetFloat("ItemTemplate", this.center.y);
			this.CECJJMKLEAK().SetFloat("player.currentrank", this.Radius);
			this.GJHLADDCMFF().SetVector("Color's hex value #RRGGBBAA", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 99f, 95f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040BF RID: 16575 RVA: 0x00140457 File Offset: 0x0013E657
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040C0 RID: 16576 RVA: 0x00140474 File Offset: 0x0013E674
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1793f)
			{
				this.HBJJOCHGOPH = 878f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("setAF", this.center.x);
			this.BLMPMOIDGMG().SetFloat("MenuScene", this.center.y);
			this.HKIMAANBGMJ().SetFloat("[PlayerController] ", this.Radius);
			this.OLHDPICFBOF().SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1387f, 237f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040C1 RID: 16577 RVA: 0x00140567 File Offset: 0x0013E767
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040C2 RID: 16578 RVA: 0x0014059E File Offset: 0x0013E79E
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040C3 RID: 16579 RVA: 0x001405D5 File Offset: 0x0013E7D5
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("note.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040C4 RID: 16580 RVA: 0x001405F9 File Offset: 0x0013E7F9
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040C5 RID: 16581 RVA: 0x00140457 File Offset: 0x0013E657
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040C6 RID: 16582 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x060040C7 RID: 16583 RVA: 0x00140630 File Offset: 0x0013E830
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1481f)
			{
				this.HBJJOCHGOPH = 1282f;
			}
			this.PHGCJOPFDOG().SetFloat("#creatingnewitem", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("menu.selectedplaymode", this.center.x);
			this.BLMPMOIDGMG().SetFloat("_TimeX", this.center.y);
			this.KBOPGONOCNP().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", this.Radius);
			this.FOOCJIDNGBB().SetVector("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 42f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040C8 RID: 16584 RVA: 0x00140457 File Offset: 0x0013E657
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040C9 RID: 16585 RVA: 0x00140457 File Offset: 0x0013E657
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040CA RID: 16586 RVA: 0x00140724 File Offset: 0x0013E924
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1499f)
			{
				this.HBJJOCHGOPH = 1191f;
			}
			this.CECJJMKLEAK().SetFloat("PhotonServerSettings", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("_MainTex2", this.center.x);
			this.LEIAFCPJMDP().SetFloat("CameraFilterPack/Drawing_Laplacian", this.center.y);
			this.EFDEIFCDAFG().SetFloat("HelpMenu", this.Radius);
			this.LEIAFCPJMDP().SetVector("SpeedSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1462f, 1966f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040CB RID: 16587 RVA: 0x00140817 File Offset: 0x0013EA17
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040CC RID: 16588 RVA: 0x00140850 File Offset: 0x0013EA50
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1285f)
			{
				this.HBJJOCHGOPH = 1335f;
			}
			this.CECJJMKLEAK().SetFloat("CameraFilterPack_3D_Myst1", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Value11", this.center.x);
			this.KGOLDDBHIFN().SetFloat("offsets", this.center.y);
			this.FOOCJIDNGBB().SetFloat("_TimeX", this.Radius);
			this.KGOLDDBHIFN().SetVector("_PositionY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 45f, 1052f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040CD RID: 16589 RVA: 0x00140457 File Offset: 0x0013E657
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040CE RID: 16590 RVA: 0x00140943 File Offset: 0x0013EB43
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040CF RID: 16591 RVA: 0x0014097A File Offset: 0x0013EB7A
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("http://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040D0 RID: 16592 RVA: 0x0014099E File Offset: 0x0013EB9E
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("IncorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060040D1 RID: 16593 RVA: 0x001409C2 File Offset: 0x0013EBC2
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("). ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040D2 RID: 16594 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x060040D3 RID: 16595 RVA: 0x001409E6 File Offset: 0x0013EBE6
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040D4 RID: 16596 RVA: 0x00140A20 File Offset: 0x0013EC20
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1543f)
			{
				this.HBJJOCHGOPH = 772f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("clicked ", this.center.x);
			this.EFDEIFCDAFG().SetFloat("Set Sun DirectionVector", this.center.y);
			this.HKIMAANBGMJ().SetFloat("_Value2", this.Radius);
			this.PLBEJJIHFPB().SetVector("LevelEditor/icons", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 784f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040D5 RID: 16597 RVA: 0x00140B13 File Offset: 0x0013ED13
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find(" / ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040D6 RID: 16598 RVA: 0x00140B37 File Offset: 0x0013ED37
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("Set particles count per one beat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040D7 RID: 16599 RVA: 0x00140457 File Offset: 0x0013E657
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040D8 RID: 16600 RVA: 0x00140457 File Offset: 0x0013E657
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040D9 RID: 16601 RVA: 0x00140B5B File Offset: 0x0013ED5B
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Broken_Screen1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040DA RID: 16602 RVA: 0x00140B7F File Offset: 0x0013ED7F
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040DB RID: 16603 RVA: 0x00140BA4 File Offset: 0x0013EDA4
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1321f)
			{
				this.HBJJOCHGOPH = 1678f;
			}
			this.LEIAFCPJMDP().SetFloat("Hidden/ScreenSpaceReflection", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", this.center.x);
			this.KGOLDDBHIFN().SetFloat(".a", this.center.y);
			this.KBOPGONOCNP().SetFloat("[PlayerBase] Loaded custom model: ", this.Radius);
			this.HHIAIGCAHDA().SetVector("Item invalid. Make sure your mod contains at leats one file.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1175f, 1003f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040DC RID: 16604 RVA: 0x00140C98 File Offset: 0x0013EE98
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1701f)
			{
				this.HBJJOCHGOPH = 684f;
			}
			this.CECJJMKLEAK().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("MultiplayerButton", this.center.x);
			this.PHGCJOPFDOG().SetFloat("_Greenness", this.center.y);
			this.ACHNOHCLGOO().SetFloat("_Value3", this.Radius);
			this.BLMPMOIDGMG().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 483f, 1602f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040DD RID: 16605 RVA: 0x00140D8B File Offset: 0x0013EF8B
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("OpGetGameList not sent. LobbyType must be SqlLobby.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040DE RID: 16606 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060040DF RID: 16607 RVA: 0x00140DAF File Offset: 0x0013EFAF
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("[LocalizationService] Loading file: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040E0 RID: 16608 RVA: 0x00140DD4 File Offset: 0x0013EFD4
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 350f)
			{
				this.HBJJOCHGOPH = 1592f;
			}
			this.CECJJMKLEAK().SetFloat("_BlurRadius4", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("1", this.center.x);
			this.NBPKMLMCHFN.SetFloat(" not exist", this.center.y);
			this.MFHPKGICPIO().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Radius);
			this.BLMPMOIDGMG().SetVector("workshop.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 158f, 1372f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040E1 RID: 16609 RVA: 0x00140EC7 File Offset: 0x0013F0C7
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040E2 RID: 16610 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x060040E3 RID: 16611 RVA: 0x00140EFE File Offset: 0x0013F0FE
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040E4 RID: 16612 RVA: 0x00140457 File Offset: 0x0013E657
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040E5 RID: 16613 RVA: 0x00140F22 File Offset: 0x0013F122
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("UseScanLine");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060040E6 RID: 16614 RVA: 0x00140F46 File Offset: 0x0013F146
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Bullet_3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040E7 RID: 16615 RVA: 0x00140F6A File Offset: 0x0013F16A
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack/RainFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040E8 RID: 16616 RVA: 0x00140F8E File Offset: 0x0013F18E
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040E9 RID: 16617 RVA: 0x00140FB2 File Offset: 0x0013F1B2
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_Threshhold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060040EA RID: 16618 RVA: 0x00140457 File Offset: 0x0013E657
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040EB RID: 16619 RVA: 0x00140FD6 File Offset: 0x0013F1D6
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040EC RID: 16620 RVA: 0x0014100D File Offset: 0x0013F20D
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040ED RID: 16621 RVA: 0x00140457 File Offset: 0x0013E657
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040EE RID: 16622 RVA: 0x00141044 File Offset: 0x0013F244
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060040EF RID: 16623 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x060040F0 RID: 16624 RVA: 0x00140457 File Offset: 0x0013E657
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040F1 RID: 16625 RVA: 0x00141068 File Offset: 0x0013F268
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060040F2 RID: 16626 RVA: 0x0014108C File Offset: 0x0013F28C
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040F3 RID: 16627 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x060040F4 RID: 16628 RVA: 0x001410C4 File Offset: 0x0013F2C4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 330f)
			{
				this.HBJJOCHGOPH = 655f;
			}
			this.BLMPMOIDGMG().SetFloat("Bad parameters for setbool! Use <key> <value>", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("/", this.center.x);
			this.HHIAIGCAHDA().SetFloat("[Down]", this.center.y);
			this.GJHLADDCMFF().SetFloat("RoomPlayersCountText", this.Radius);
			this.CECJJMKLEAK().SetVector("STICKLHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 691f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040F5 RID: 16629 RVA: 0x00140457 File Offset: 0x0013E657
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040F6 RID: 16630 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060040F7 RID: 16631 RVA: 0x00140457 File Offset: 0x0013E657
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040F8 RID: 16632 RVA: 0x001411B7 File Offset: 0x0013F3B7
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040F9 RID: 16633 RVA: 0x001411F0 File Offset: 0x0013F3F0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 136f)
			{
				this.HBJJOCHGOPH = 1615f;
			}
			this.CFEDGDGBCHE().SetFloat("ControllerLeftY", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("LoadMapCanvas", this.center.x);
			this.BLMPMOIDGMG().SetFloat("_ArScale", this.center.y);
			this.LEIAFCPJMDP().SetFloat("_Value", this.Radius);
			this.CFEDGDGBCHE().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 995f, 1625f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040FA RID: 16634 RVA: 0x001412E4 File Offset: 0x0013F4E4
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 362f)
			{
				this.HBJJOCHGOPH = 997f;
			}
			this.BLMPMOIDGMG().SetFloat("player.xp", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_EdgeThreshold", this.center.x);
			this.LEIAFCPJMDP().SetFloat("_Value4", this.center.y);
			this.FOOCJIDNGBB().SetFloat(".wav", this.Radius);
			this.CFEDGDGBCHE().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 952f, 697f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040FB RID: 16635 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x060040FC RID: 16636 RVA: 0x001413D8 File Offset: 0x0013F5D8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 578f)
			{
				this.HBJJOCHGOPH = 594f;
			}
			this.ACHNOHCLGOO().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("GlassesColor", this.center.x);
			this.ACHNOHCLGOO().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", this.center.y);
			this.LEIAFCPJMDP().SetFloat(" region", this.Radius);
			this.MFHPKGICPIO().SetVector("EnableRankingToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1282f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040FD RID: 16637 RVA: 0x001414CC File Offset: 0x0013F6CC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1200f)
			{
				this.HBJJOCHGOPH = 1660f;
			}
			this.KBOPGONOCNP().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("workshop.", this.center.x);
			this.CFEDGDGBCHE().SetFloat("_Value5", this.center.y);
			this.BLMPMOIDGMG().SetFloat("F3", this.Radius);
			this.ACHNOHCLGOO().SetVector("caret", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 125f, 556f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040FE RID: 16638 RVA: 0x001415C0 File Offset: 0x0013F7C0
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1789f)
			{
				this.HBJJOCHGOPH = 1172f;
			}
			this.EHDJJANLINB().SetFloat("Freq: ", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat(",0", this.center.x);
			this.CFEDGDGBCHE().SetFloat("tagElement", this.center.y);
			this.NDMPCDHADMJ().SetFloat("ConfigVersionSlider", this.Radius);
			this.MFHPKGICPIO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 750f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040FF RID: 16639 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004100 RID: 16640 RVA: 0x00140457 File Offset: 0x0013E657
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004101 RID: 16641 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06004102 RID: 16642 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06004103 RID: 16643 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06004104 RID: 16644 RVA: 0x001416B3 File Offset: 0x0013F8B3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Spot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004105 RID: 16645 RVA: 0x001416D7 File Offset: 0x0013F8D7
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004106 RID: 16646 RVA: 0x00140457 File Offset: 0x0013E657
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004107 RID: 16647 RVA: 0x00140457 File Offset: 0x0013E657
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004108 RID: 16648 RVA: 0x00141710 File Offset: 0x0013F910
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1649f)
			{
				this.HBJJOCHGOPH = 1026f;
			}
			this.BLMPMOIDGMG().SetFloat("LivesSlider", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("#later", this.center.x);
			this.PLBEJJIHFPB().SetFloat("settings.disablestoryboard", this.center.y);
			this.NFMGLIKNOOC().SetFloat("_Value4", this.Radius);
			this.ACHNOHCLGOO().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1128f, 1929f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004109 RID: 16649 RVA: 0x00141803 File Offset: 0x0013FA03
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600410A RID: 16650 RVA: 0x00140457 File Offset: 0x0013E657
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600410B RID: 16651 RVA: 0x0014183A File Offset: 0x0013FA3A
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600410C RID: 16652 RVA: 0x00140457 File Offset: 0x0013E657
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600410D RID: 16653 RVA: 0x00140457 File Offset: 0x0013E657
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600410E RID: 16654 RVA: 0x00140457 File Offset: 0x0013E657
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600410F RID: 16655 RVA: 0x00141874 File Offset: 0x0013FA74
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 973f;
			}
			this.CECJJMKLEAK().SetFloat(".", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Tab1Content", this.center.x);
			this.OLHDPICFBOF().SetFloat("Set Satellite Trail Length", this.center.y);
			this.HKIMAANBGMJ().SetFloat("&page=", this.Radius);
			this.HHIAIGCAHDA().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 293f, 227f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004110 RID: 16656 RVA: 0x00141968 File Offset: 0x0013FB68
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
			this.NBPKMLMCHFN.SetFloat("_PositionX", this.center.x);
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.center.y);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Radius);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004111 RID: 16657 RVA: 0x00141A5B File Offset: 0x0013FC5B
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("Item ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004112 RID: 16658 RVA: 0x00141A7F File Offset: 0x0013FC7F
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004113 RID: 16659 RVA: 0x00141AB8 File Offset: 0x0013FCB8
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1262f)
			{
				this.HBJJOCHGOPH = 1871f;
			}
			this.NFMGLIKNOOC().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("_Value", this.center.x);
			this.FOOCJIDNGBB().SetFloat("_FlipAlphaMask", this.center.y);
			this.MFHPKGICPIO().SetFloat("#C8C8C8FF", this.Radius);
			this.CECJJMKLEAK().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1116f, 1443f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004114 RID: 16660 RVA: 0x00141BAC File Offset: 0x0013FDAC
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 428f)
			{
				this.HBJJOCHGOPH = 1286f;
			}
			this.LEIAFCPJMDP().SetFloat(". Client is not the MasterClient in this room.", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", this.center.x);
			this.GJHLADDCMFF().SetFloat("_TimeX", this.center.y);
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.Radius);
			this.HKIMAANBGMJ().SetVector("/../", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 52f, 1202f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004115 RID: 16661 RVA: 0x00140457 File Offset: 0x0013E657
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004116 RID: 16662 RVA: 0x00140457 File Offset: 0x0013E657
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004117 RID: 16663 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06004118 RID: 16664 RVA: 0x00141CA0 File Offset: 0x0013FEA0
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1370f)
			{
				this.HBJJOCHGOPH = 1736f;
			}
			this.NDMPCDHADMJ().SetFloat(".lastCheckpoint.isMapCompleted", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("_Value5", this.center.x);
			this.PLBEJJIHFPB().SetFloat(".lastCheckpoint.incorrectScore", this.center.y);
			this.NFMGLIKNOOC().SetFloat("MapCreationCanvas", this.Radius);
			this.PHGCJOPFDOG().SetVector("[MapEditor] Loading map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 340f, 581f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004119 RID: 16665 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600411A RID: 16666 RVA: 0x00141D93 File Offset: 0x0013FF93
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("_NoiseAmount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600411B RID: 16667 RVA: 0x00140457 File Offset: 0x0013E657
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600411C RID: 16668 RVA: 0x00141DB7 File Offset: 0x0013FFB7
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600411D RID: 16669 RVA: 0x00141DEE File Offset: 0x0013FFEE
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600411E RID: 16670 RVA: 0x00141E12 File Offset: 0x00140012
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600411F RID: 16671 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06004120 RID: 16672 RVA: 0x00140457 File Offset: 0x0013E657
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004122 RID: 16674 RVA: 0x00141E7C File Offset: 0x0014007C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 548f)
			{
				this.HBJJOCHGOPH = 1001f;
			}
			this.NDMPCDHADMJ().SetFloat("sfxVolume", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("_Distortion", this.center.x);
			this.MFHPKGICPIO().SetFloat("LoadingStatusText", this.center.y);
			this.HKIMAANBGMJ().SetFloat("workshop.", this.Radius);
			this.OLHDPICFBOF().SetVector("#pleasewait", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1785f, 119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004123 RID: 16675 RVA: 0x00141F6F File Offset: 0x0014016F
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004124 RID: 16676 RVA: 0x00141FA8 File Offset: 0x001401A8
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1474f)
			{
				this.HBJJOCHGOPH = 1101f;
			}
			this.MFHPKGICPIO().SetFloat(".b", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_Value5", this.center.x);
			this.HKIMAANBGMJ().SetFloat(" timeUntilRespawn: ", this.center.y);
			this.CECJJMKLEAK().SetFloat("id", this.Radius);
			this.EHDJJANLINB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1180f, 1437f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004125 RID: 16677 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06004126 RID: 16678 RVA: 0x0014209B File Offset: 0x0014029B
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004127 RID: 16679 RVA: 0x001420BF File Offset: 0x001402BF
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Twist_Square");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004128 RID: 16680 RVA: 0x001420E3 File Offset: 0x001402E3
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06004129 RID: 16681 RVA: 0x0014211A File Offset: 0x0014031A
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

	// Token: 0x0600412A RID: 16682 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x0600412B RID: 16683 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x040006E3 RID: 1763
	public Shader SCShader;

	// Token: 0x040006E4 RID: 1764
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006E5 RID: 1765
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006E6 RID: 1766
	private Material BJFKDHHMLJH;

	// Token: 0x040006E7 RID: 1767
	public Vector2 center = new Vector2(0.5f, 0.5f);

	// Token: 0x040006E8 RID: 1768
	public float Radius = 0.2f;
}
