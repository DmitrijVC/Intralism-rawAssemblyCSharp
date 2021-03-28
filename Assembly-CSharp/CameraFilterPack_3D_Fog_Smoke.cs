using System;
using UnityEngine;

// Token: 0x02000021 RID: 33
[AddComponentMenu("Camera Filter Pack/3D/Fog_Smoke")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Fog_Smoke : MonoBehaviour
{
	// Token: 0x060006BF RID: 1727 RVA: 0x00035BA4 File Offset: 0x00033DA4
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("Loaded Game: ") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00035BFC File Offset: 0x00033DFC
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1318f)
			{
				this.HBJJOCHGOPH = 841f;
			}
			this.EFDEIFCDAFG().SetFloat("_DiffuseColor", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1182f)
				{
					this._Distance = 1046f;
				}
				if (this._Distance < 987f)
				{
					this._Distance = 1652f;
				}
				this.HFBJAOFLCJI().SetFloat("Horizontal", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("#91CCFF", this._Distance);
			}
			this.JIBOKBCPDLC().SetFloat("note.2", this._Size);
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/3D_Mirror", (float)((!this._Visualize) ? 1 : 0));
			this.NDMPCDHADMJ().SetFloat("_Value", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Set sun audio input", this.DistortionLevel * 1672f);
			this.NBPKMLMCHFN.SetFloat("PublishButton", this.DistortionSize * 1147f);
			this.HCGJCMDJPGD().SetFloat("_BlurCoe", this.LightIntensity * 221f);
			this.KAFBNOBOIAJ().SetTexture("UNDISTORT", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Deep_OilPaintHQ", 1475f / farClipPlane);
			this.HCGJCMDJPGD().SetVector("plogs", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 807f, 1651f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00035E16 File Offset: 0x00034016
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00035E4D File Offset: 0x0003404D
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00035EEF File Offset: 0x000340EF
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00035F26 File Offset: 0x00034126
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00035F5D File Offset: 0x0003415D
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00035F94 File Offset: 0x00034194
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00035FD0 File Offset: 0x000341D0
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 299f)
			{
				this.HBJJOCHGOPH = 1115f;
			}
			this.LPMLLJKMAMP().SetFloat("getfloat", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1604f)
				{
					this._Distance = 207f;
				}
				if (this._Distance < 1563f)
				{
					this._Distance = 20f;
				}
				this.EFDEIFCDAFG().SetFloat("_AdaptationMin", this._Distance);
			}
			else
			{
				this.JIBOKBCPDLC().SetFloat("_Value3", this._Distance);
			}
			this.LPMLLJKMAMP().SetFloat("-1", this._Size);
			this.HHIAIGCAHDA().SetFloat("/", (float)((!this._Visualize) ? 0 : 0));
			this.LPMLLJKMAMP().SetFloat("_Value", this._FixDistance);
			this.NDMPCDHADMJ().SetFloat(" ", this.DistortionLevel * 166f);
			this.IIJMIPBMMBF().SetFloat("Right Stick Click", this.DistortionSize * 508f);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack_3D_Myst1", this.LightIntensity * 397f);
			this.MMOODGIODPC().SetTexture("_TimeX", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GCDFNHMJMIP().SetFloat("cancel", 1013f / farClipPlane);
			this.KAFBNOBOIAJ().SetVector("Netw. Sim.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 400f, 1463f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x000361EA File Offset: 0x000343EA
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Myst1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00036223 File Offset: 0x00034423
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("Skipping EstablishEncryption. Protocol is secure.") as Texture2D);
		this.SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x0003625C File Offset: 0x0003445C
	private void KLILJHJNICK()
	{
		this.FPHEBLMINDA = (Resources.Load("GameScene") as Texture2D);
		this.SCShader = Shader.Find("menutheme.letitbe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00036295 File Offset: 0x00034495
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000362CC File Offset: 0x000344CC
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

	// Token: 0x060006D9 RID: 1753 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00036303 File Offset: 0x00034503
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x0003633C File Offset: 0x0003453C
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1499f)
			{
				this.HBJJOCHGOPH = 250f;
			}
			this.ADBKPGFMNKO().SetFloat("mapselector.filter.favoriteonly", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 883f)
				{
					this._Distance = 1666f;
				}
				if (this._Distance < 893f)
				{
					this._Distance = 168f;
				}
				this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this._Distance);
			}
			else
			{
				this.LPMLLJKMAMP().SetFloat("_Colored", this._Distance);
			}
			this.LPMLLJKMAMP().SetFloat("stretchWidth", this._Size);
			this.KAFBNOBOIAJ().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 1));
			this.HHIAIGCAHDA().SetFloat("_TimeX", this._FixDistance);
			this.JIBOKBCPDLC().SetFloat("[PlayerController] ", this.DistortionLevel * 1185f);
			this.NBPKMLMCHFN.SetFloat("Hex value #RRGGBB", this.DistortionSize * 1955f);
			this.NDMPCDHADMJ().SetFloat("BestScoreText", this.LightIntensity * 748f);
			this.ACHNOHCLGOO().SetTexture("GameMessagesDurationSlider", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IIJMIPBMMBF().SetFloat("Ignored PU RPC, cause item is inactive. ", 1131f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("In Main Menu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 75f, 1002f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x00036558 File Offset: 0x00034758
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 635f)
			{
				this.HBJJOCHGOPH = 94f;
			}
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Drawing_BluePrint", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 446f)
				{
					this._Distance = 547f;
				}
				if (this._Distance < 608f)
				{
					this._Distance = 1430f;
				}
				this.MMOODGIODPC().SetFloat("_InvScreenSize", this._Distance);
			}
			else
			{
				this.EFDEIFCDAFG().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this._Distance);
			}
			this.HCGJCMDJPGD().SetFloat("#highscore", this._Size);
			this.ADBKPGFMNKO().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 0));
			this.IIJMIPBMMBF().SetFloat("[EditorEvent] Exception: ", this._FixDistance);
			this.MMOODGIODPC().SetFloat("offsets", this.DistortionLevel * 1884f);
			this.HFBJAOFLCJI().SetFloat("skin.hit_normal", this.DistortionSize * 327f);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", this.LightIntensity * 1614f);
			this.JIBOKBCPDLC().SetTexture("_VignetteColor", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("_AllowBackwardsRays", 1480f / farClipPlane);
			this.ACHNOHCLGOO().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 629f, 1827f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00036772 File Offset: 0x00034972
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("{0}{1}{2}") as Texture2D);
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x000367AB File Offset: 0x000349AB
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Vision_Blood") as Texture2D);
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x000367E4 File Offset: 0x000349E4
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0003681B File Offset: 0x00034A1B
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00036854 File Offset: 0x00034A54
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
				{
					this._Distance = 1f;
				}
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel * 28f);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize * 16f);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
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

	// Token: 0x060006ED RID: 1773 RVA: 0x00036A6E File Offset: 0x00034C6E
	private void FBPHNEJBDJN()
	{
		this.FPHEBLMINDA = (Resources.Load(".message") as Texture2D);
		this.SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00035F26 File Offset: 0x00034126
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00036AA8 File Offset: 0x00034CA8
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 855f)
			{
				this.HBJJOCHGOPH = 1234f;
			}
			this.IIJMIPBMMBF().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1265f)
				{
					this._Distance = 1921f;
				}
				if (this._Distance < 531f)
				{
					this._Distance = 1921f;
				}
				this.MMOODGIODPC().SetFloat("NEW_ACHIEVEMENT_1_", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("b", this._Distance);
			}
			this.AELJLBOJAIL().SetFloat("<b>[", this._Size);
			this.NDMPCDHADMJ().SetFloat("input", (float)((!this._Visualize) ? 1 : 0));
			this.GCDFNHMJMIP().SetFloat("/icon", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("threshold", this.DistortionLevel * 68f);
			this.NDMPCDHADMJ().SetFloat(" not exist", this.DistortionSize * 1145f);
			this.LPMLLJKMAMP().SetFloat("maps.", this.LightIntensity * 262f);
			this.KAFBNOBOIAJ().SetTexture("y", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KAFBNOBOIAJ().SetFloat("[PlayerBase] Starting new round", 1279f / farClipPlane);
			this.HCGJCMDJPGD().SetVector("ERROR: Make sure your mod contains at leats one file!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 155f, 418f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00036CC2 File Offset: 0x00034EC2
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("float,0") as Texture2D);
		this.SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00036CFB File Offset: 0x00034EFB
	private void DKGBFNCOAEO()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.playedpage") as Texture2D);
		this.SCShader = Shader.Find("SettingsCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00036D34 File Offset: 0x00034F34
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("Mouse Wheel Up") as Texture2D);
		this.SCShader = Shader.Find("Parameter levelId must be int or string!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00036D6D File Offset: 0x00034F6D
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00036DA4 File Offset: 0x00034FA4
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("FileMenu") as Texture2D);
		this.SCShader = Shader.Find("OperationResponse ignored while disconnecting. Code: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00036DE0 File Offset: 0x00034FE0
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 462f)
			{
				this.HBJJOCHGOPH = 1010f;
			}
			this.NBPKMLMCHFN.SetFloat("[MapEditor] Updating map assets", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 623f)
				{
					this._Distance = 1106f;
				}
				if (this._Distance < 76f)
				{
					this._Distance = 801f;
				}
				this.IIJMIPBMMBF().SetFloat("</size>", this._Distance);
			}
			else
			{
				this.EFDEIFCDAFG().SetFloat("0 - background, 1 - foreground", this._Distance);
			}
			this.ACHNOHCLGOO().SetFloat("Joystick1Button", this._Size);
			this.NBPKMLMCHFN.SetFloat("_ReflectionTexture2", (float)((!this._Visualize) ? 0 : 0));
			this.HFBJAOFLCJI().SetFloat("#failed!", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("Myst", this.DistortionLevel * 1282f);
			this.GCDFNHMJMIP().SetFloat("_TintColor", this.DistortionSize * 656f);
			this.HFBJAOFLCJI().SetFloat("menu.selectedplaymode", this.LightIntensity * 690f);
			this.LPMLLJKMAMP().SetTexture("_FixDistance", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", 1887f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("z", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 720f, 887f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00036FFC File Offset: 0x000351FC
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 766f)
			{
				this.HBJJOCHGOPH = 1905f;
			}
			this.HFBJAOFLCJI().SetFloat("NewMapHandsCountSlider", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 604f)
				{
					this._Distance = 4f;
				}
				if (this._Distance < 810f)
				{
					this._Distance = 366f;
				}
				this.NDMPCDHADMJ().SetFloat("_MainTex2", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat(".r", this._Distance);
			}
			this.IIJMIPBMMBF().SetFloat("_Value", this._Size);
			this.NDMPCDHADMJ().SetFloat(".lastCheckpoint.isMapCompleted", (float)((!this._Visualize) ? 1 : 1));
			this.NBPKMLMCHFN.SetFloat("[FileSelector] Dialog ended, result: ", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("ticket", this.DistortionLevel * 334f);
			this.LPMLLJKMAMP().SetFloat("OxOD.lastPath", this.DistortionSize * 874f);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.LightIntensity * 1891f);
			this.GCDFNHMJMIP().SetTexture(". Check if the server is available.", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHIAIGCAHDA().SetFloat("settings.fps", 471f / farClipPlane);
			this.LPMLLJKMAMP().SetVector("_SpotSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 23f, 604f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00037216 File Offset: 0x00035416
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x0003724D File Offset: 0x0003544D
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00037284 File Offset: 0x00035484
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("setAF") as Texture2D);
		this.SCShader = Shader.Find("). ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x000372BD File Offset: 0x000354BD
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00035BDD File Offset: 0x00033DDD
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000372F4 File Offset: 0x000354F4
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load(".played") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x0003732D File Offset: 0x0003552D
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400010D RID: 269
	public Shader SCShader;

	// Token: 0x0400010E RID: 270
	public bool _Visualize;

	// Token: 0x0400010F RID: 271
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000110 RID: 272
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000111 RID: 273
	private Material BJFKDHHMLJH;

	// Token: 0x04000112 RID: 274
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x04000113 RID: 275
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	// Token: 0x04000114 RID: 276
	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	// Token: 0x04000115 RID: 277
	[Range(0f, 10f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x04000116 RID: 278
	[Range(0.1f, 10f)]
	public float DistortionSize = 1.4f;

	// Token: 0x04000117 RID: 279
	[Range(-2f, 4f)]
	public float LightIntensity = 0.08f;

	// Token: 0x04000118 RID: 280
	public bool AutoAnimatedNear;

	// Token: 0x04000119 RID: 281
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x0400011A RID: 282
	private Texture2D FPHEBLMINDA;

	// Token: 0x0400011B RID: 283
	public static Color ChangeColorRGB;
}
