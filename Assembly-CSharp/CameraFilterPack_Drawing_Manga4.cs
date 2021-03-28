using System;
using UnityEngine;

// Token: 0x020000A8 RID: 168
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Manga4")]
public class CameraFilterPack_Drawing_Manga4 : MonoBehaviour
{
	// Token: 0x060032A8 RID: 12968 RVA: 0x00108E05 File Offset: 0x00107005
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032A9 RID: 12969 RVA: 0x00108E22 File Offset: 0x00107022
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Reloaded config for \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032AA RID: 12970 RVA: 0x00108E46 File Offset: 0x00107046
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032AB RID: 12971 RVA: 0x00108E6C File Offset: 0x0010706C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1607f)
			{
				this.HBJJOCHGOPH = 1720f;
			}
			this.CEKJODEAMGB().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("menu.selectedlevelid", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032AC RID: 12972 RVA: 0x00108EFC File Offset: 0x001070FC
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("There are {0} reported logs.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032AD RID: 12973 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060032AE RID: 12974 RVA: 0x00108F20 File Offset: 0x00107120
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 841f)
			{
				this.HBJJOCHGOPH = 398f;
			}
			this.LDNADDJMIPK().SetFloat(".played", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("[PlayerController] ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032AF RID: 12975 RVA: 0x00108E05 File Offset: 0x00107005
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032B0 RID: 12976 RVA: 0x00108E05 File Offset: 0x00107005
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032B1 RID: 12977 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060032B2 RID: 12978 RVA: 0x00108FB0 File Offset: 0x001071B0
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
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032B3 RID: 12979 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x060032B4 RID: 12980 RVA: 0x00108E05 File Offset: 0x00107005
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032B5 RID: 12981 RVA: 0x00109040 File Offset: 0x00107240
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 998f)
			{
				this.HBJJOCHGOPH = 56f;
			}
			this.CEKJODEAMGB().SetFloat(",", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032B6 RID: 12982 RVA: 0x001090D0 File Offset: 0x001072D0
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032B7 RID: 12983 RVA: 0x00108E05 File Offset: 0x00107005
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032B8 RID: 12984 RVA: 0x00109108 File Offset: 0x00107308
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 496f)
			{
				this.HBJJOCHGOPH = 985f;
			}
			this.LDNADDJMIPK().SetFloat("pointBuffer", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("#close", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032B9 RID: 12985 RVA: 0x00109198 File Offset: 0x00107398
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1996f)
			{
				this.HBJJOCHGOPH = 1998f;
			}
			this.CEKJODEAMGB().SetFloat("Right", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_PositionY", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032BA RID: 12986 RVA: 0x00108E05 File Offset: 0x00107005
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032BB RID: 12987 RVA: 0x00109228 File Offset: 0x00107428
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1820f)
			{
				this.HBJJOCHGOPH = 118f;
			}
			this.DBOLLHHMKKN().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("</color>", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032BC RID: 12988 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060032BD RID: 12989 RVA: 0x001092B8 File Offset: 0x001074B8
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 996f)
			{
				this.HBJJOCHGOPH = 1604f;
			}
			this.CFEDGDGBCHE().SetFloat("_Far", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("SetRoomStartTimestamp", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032BE RID: 12990 RVA: 0x00109348 File Offset: 0x00107548
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_Bloom5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032BF RID: 12991 RVA: 0x0010936C File Offset: 0x0010756C
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032C0 RID: 12992 RVA: 0x001093A3 File Offset: 0x001075A3
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032C1 RID: 12993 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060032C2 RID: 12994 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060032C3 RID: 12995 RVA: 0x001093C7 File Offset: 0x001075C7
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("PlayerPrefs::Deserialize() parameterContent has ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060032C4 RID: 12996 RVA: 0x00108E05 File Offset: 0x00107005
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032C5 RID: 12997 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x060032C6 RID: 12998 RVA: 0x001093EB File Offset: 0x001075EB
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("Please attach component to a Graphical UI component");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032C7 RID: 12999 RVA: 0x00108E05 File Offset: 0x00107005
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032C8 RID: 13000 RVA: 0x00108E05 File Offset: 0x00107005
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032C9 RID: 13001 RVA: 0x0010940F File Offset: 0x0010760F
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032CA RID: 13002 RVA: 0x00109446 File Offset: 0x00107646
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_FarCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060032CB RID: 13003 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060032CC RID: 13004 RVA: 0x0010946A File Offset: 0x0010766A
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032CD RID: 13005 RVA: 0x00109490 File Offset: 0x00107690
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 103f)
			{
				this.HBJJOCHGOPH = 503f;
			}
			this.HHIAIGCAHDA().SetFloat("st", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_MatrixSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032CE RID: 13006 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060032CF RID: 13007 RVA: 0x00109520 File Offset: 0x00107720
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032D0 RID: 13008 RVA: 0x00108E05 File Offset: 0x00107005
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032D1 RID: 13009 RVA: 0x00108E05 File Offset: 0x00107005
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032D2 RID: 13010 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060032D3 RID: 13011 RVA: 0x00109544 File Offset: 0x00107744
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

	// Token: 0x060032D4 RID: 13012 RVA: 0x00108E05 File Offset: 0x00107005
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032D5 RID: 13013 RVA: 0x0010957B File Offset: 0x0010777B
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032D6 RID: 13014 RVA: 0x00108E05 File Offset: 0x00107005
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032D7 RID: 13015 RVA: 0x00108E05 File Offset: 0x00107005
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032D8 RID: 13016 RVA: 0x001095B4 File Offset: 0x001077B4
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 384f)
			{
				this.HBJJOCHGOPH = 1191f;
			}
			this.HEHKGPKLAKK().SetFloat("GraphicsQualitySlider", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("In Main Menu", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032D9 RID: 13017 RVA: 0x00108E05 File Offset: 0x00107005
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032DA RID: 13018 RVA: 0x00108E05 File Offset: 0x00107005
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032DB RID: 13019 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x060032DC RID: 13020 RVA: 0x00109644 File Offset: 0x00107844
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032DD RID: 13021 RVA: 0x0010967C File Offset: 0x0010787C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 783f)
			{
				this.HBJJOCHGOPH = 192f;
			}
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Vision_Warp", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat(" != ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032DE RID: 13022 RVA: 0x0010970C File Offset: 0x0010790C
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("_CenterRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032DF RID: 13023 RVA: 0x00109730 File Offset: 0x00107930
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060032E0 RID: 13024 RVA: 0x00109754 File Offset: 0x00107954
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032E1 RID: 13025 RVA: 0x00109778 File Offset: 0x00107978
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032E2 RID: 13026 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060032E3 RID: 13027 RVA: 0x001097AF File Offset: 0x001079AF
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032E5 RID: 13029 RVA: 0x00109804 File Offset: 0x00107A04
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("Dec");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032E6 RID: 13030 RVA: 0x0010957B File Offset: 0x0010777B
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032E7 RID: 13031 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x060032E8 RID: 13032 RVA: 0x00108E05 File Offset: 0x00107005
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032E9 RID: 13033 RVA: 0x00109828 File Offset: 0x00107A28
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 142f)
			{
				this.HBJJOCHGOPH = 894f;
			}
			this.LDNADDJMIPK().SetFloat("shader.future", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_FixDistance", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032EA RID: 13034 RVA: 0x001098B8 File Offset: 0x00107AB8
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032EB RID: 13035 RVA: 0x001098EF File Offset: 0x00107AEF
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032EC RID: 13036 RVA: 0x00109914 File Offset: 0x00107B14
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 164f)
			{
				this.HBJJOCHGOPH = 568f;
			}
			this.OGMEGHKECAH().SetFloat("_PColor", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("1177138211", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032ED RID: 13037 RVA: 0x001099A4 File Offset: 0x00107BA4
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("{0}{1}{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060032EE RID: 13038 RVA: 0x001099C8 File Offset: 0x00107BC8
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032EF RID: 13039 RVA: 0x001099FF File Offset: 0x00107BFF
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060032F0 RID: 13040 RVA: 0x00109A23 File Offset: 0x00107C23
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_Red_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060032F1 RID: 13041 RVA: 0x00109A47 File Offset: 0x00107C47
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032F2 RID: 13042 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060032F3 RID: 13043 RVA: 0x00108E05 File Offset: 0x00107005
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032F4 RID: 13044 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060032F5 RID: 13045 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x060032F6 RID: 13046 RVA: 0x00109A7E File Offset: 0x00107C7E
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_Strength");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040005B5 RID: 1461
	public Shader SCShader;

	// Token: 0x040005B6 RID: 1462
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005B7 RID: 1463
	private Material BJFKDHHMLJH;

	// Token: 0x040005B8 RID: 1464
	[Range(1f, 8f)]
	public float DotSize = 4.72f;
}
