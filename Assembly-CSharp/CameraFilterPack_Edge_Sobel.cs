using System;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[AddComponentMenu("Camera Filter Pack/Edge/Sobel")]
[ExecuteInEditMode]
public class CameraFilterPack_Edge_Sobel : MonoBehaviour
{
	// Token: 0x060036FE RID: 14078 RVA: 0x0011A652 File Offset: 0x00118852
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036FF RID: 14079 RVA: 0x0011A652 File Offset: 0x00118852
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003700 RID: 14080 RVA: 0x0011A66F File Offset: 0x0011886F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Edge_Sobel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003701 RID: 14081 RVA: 0x0011A652 File Offset: 0x00118852
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003702 RID: 14082 RVA: 0x0011A652 File Offset: 0x00118852
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003703 RID: 14083 RVA: 0x0011A694 File Offset: 0x00118894
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1135f)
			{
				this.HBJJOCHGOPH = 1306f;
			}
			this.NBPKMLMCHFN.SetFloat("</size>", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetVector("DontDestroy", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1560f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003704 RID: 14084 RVA: 0x0011A73C File Offset: 0x0011893C
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003705 RID: 14085 RVA: 0x0011A7E3 File Offset: 0x001189E3
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003706 RID: 14086 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06003707 RID: 14087 RVA: 0x0011A808 File Offset: 0x00118A08
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 743f)
			{
				this.HBJJOCHGOPH = 886f;
			}
			this.DEFBJOCJJKF().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetVector("LoadingStatusText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1447f, 1087f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003708 RID: 14088 RVA: 0x0011A8B0 File Offset: 0x00118AB0
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 855f)
			{
				this.HBJJOCHGOPH = 1372f;
			}
			this.MICHFGAOPKM().SetFloat("Image", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("LevelInfoInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 661f, 1646f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003709 RID: 14089 RVA: 0x0011A652 File Offset: 0x00118852
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600370A RID: 14090 RVA: 0x0011A958 File Offset: 0x00118B58
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 471f)
			{
				this.HBJJOCHGOPH = 1593f;
			}
			this.NBPKMLMCHFN.SetFloat("SetSpeed", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("DPADHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1931f, 1195f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600370B RID: 14091 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x0600370D RID: 14093 RVA: 0x0011A652 File Offset: 0x00118852
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600370E RID: 14094 RVA: 0x0011AA14 File Offset: 0x00118C14
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 777f)
			{
				this.HBJJOCHGOPH = 51f;
			}
			this.HCGJCMDJPGD().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetVector("Editor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1123f, 1501f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600370F RID: 14095 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06003710 RID: 14096 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06003711 RID: 14097 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06003712 RID: 14098 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06003713 RID: 14099 RVA: 0x0011AABB File Offset: 0x00118CBB
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003714 RID: 14100 RVA: 0x0011A652 File Offset: 0x00118852
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003715 RID: 14101 RVA: 0x0011AAF2 File Offset: 0x00118CF2
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.bgcolor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003716 RID: 14102 RVA: 0x0011AB16 File Offset: 0x00118D16
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find(" b.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003717 RID: 14103 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003718 RID: 14104 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06003719 RID: 14105 RVA: 0x0011AB3C File Offset: 0x00118D3C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1976f)
			{
				this.HBJJOCHGOPH = 1501f;
			}
			this.INOBFNCKFGK().SetFloat("CloseConnection: No such player connected!", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetVector("settings_bindings_sec_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 450f, 1161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600371A RID: 14106 RVA: 0x0011ABE3 File Offset: 0x00118DE3
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600371B RID: 14107 RVA: 0x0011AC07 File Offset: 0x00118E07
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("Received RPC: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600371C RID: 14108 RVA: 0x0011AC2B File Offset: 0x00118E2B
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600371D RID: 14109 RVA: 0x0011A652 File Offset: 0x00118852
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600371E RID: 14110 RVA: 0x0011AC4F File Offset: 0x00118E4F
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600371F RID: 14111 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06003720 RID: 14112 RVA: 0x0011AC74 File Offset: 0x00118E74
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1957f)
			{
				this.HBJJOCHGOPH = 1325f;
			}
			this.KGOLDDBHIFN().SetFloat("_DiffuseColor", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1145f, 865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003721 RID: 14113 RVA: 0x0011AD1B File Offset: 0x00118F1B
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("#random #epic #item");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003722 RID: 14114 RVA: 0x0011AD3F File Offset: 0x00118F3F
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003723 RID: 14115 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06003724 RID: 14116 RVA: 0x0011AD76 File Offset: 0x00118F76
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003725 RID: 14117 RVA: 0x0011ADB0 File Offset: 0x00118FB0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 994f)
			{
				this.HBJJOCHGOPH = 814f;
			}
			this.DKKBFFHBHJE().SetFloat("MapEnd", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetVector("player.egglipszerotwo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 609f, 752f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003726 RID: 14118 RVA: 0x0011AE57 File Offset: 0x00119057
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003727 RID: 14119 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06003728 RID: 14120 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06003729 RID: 14121 RVA: 0x0011AE8E File Offset: 0x0011908E
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600372A RID: 14122 RVA: 0x0011AEC5 File Offset: 0x001190C5
	private void FIJHDKIPENG()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600372B RID: 14123 RVA: 0x0011AEE9 File Offset: 0x001190E9
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600372C RID: 14124 RVA: 0x0011A652 File Offset: 0x00118852
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600372D RID: 14125 RVA: 0x0011AF20 File Offset: 0x00119120
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600372E RID: 14126 RVA: 0x0011A652 File Offset: 0x00118852
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600372F RID: 14127 RVA: 0x0011AF57 File Offset: 0x00119157
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003730 RID: 14128 RVA: 0x0011AF7B File Offset: 0x0011917B
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003731 RID: 14129 RVA: 0x0011AFA0 File Offset: 0x001191A0
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1206f)
			{
				this.HBJJOCHGOPH = 1829f;
			}
			this.INOBFNCKFGK().SetFloat("CameraFilterPack_TV_BrokenGlass_2", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetVector("hidden", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1803f, 531f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003732 RID: 14130 RVA: 0x0011B047 File Offset: 0x00119247
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003733 RID: 14131 RVA: 0x0011A652 File Offset: 0x00118852
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003734 RID: 14132 RVA: 0x0011B080 File Offset: 0x00119280
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 522f)
			{
				this.HBJJOCHGOPH = 412f;
			}
			this.DKKBFFHBHJE().SetFloat("[Up]", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("LB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 218f, 844f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003735 RID: 14133 RVA: 0x0011B127 File Offset: 0x00119327
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("other.dust1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003736 RID: 14134 RVA: 0x0011B14B File Offset: 0x0011934B
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("ReplyMatch is false! ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003737 RID: 14135 RVA: 0x0011B16F File Offset: 0x0011936F
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003738 RID: 14136 RVA: 0x0011B194 File Offset: 0x00119394
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 162f)
			{
				this.HBJJOCHGOPH = 1848f;
			}
			this.FEAEGGCNIAA().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetVector("Sep", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1688f, 61f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003739 RID: 14137 RVA: 0x0011A652 File Offset: 0x00118852
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x0600373A RID: 14138 RVA: 0x0011B23B File Offset: 0x0011943B
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

	// Token: 0x0600373B RID: 14139 RVA: 0x0011B272 File Offset: 0x00119472
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600373C RID: 14140 RVA: 0x0011B2A9 File Offset: 0x001194A9
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600373D RID: 14141 RVA: 0x0011A652 File Offset: 0x00118852
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600373E RID: 14142 RVA: 0x0011B2E0 File Offset: 0x001194E0
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1082f)
			{
				this.HBJJOCHGOPH = 160f;
			}
			this.HNICHJCGJOC().SetFloat(": ", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetVector("_Far", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1928f, 213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600373F RID: 14143 RVA: 0x0011B388 File Offset: 0x00119588
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 379f)
			{
				this.HBJJOCHGOPH = 756f;
			}
			this.EFMCNLELMDO().SetFloat("Hidden/DepthOfField/DepthOfField", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetVector("#useticket", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1798f, 1316f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003740 RID: 14144 RVA: 0x0011B42F File Offset: 0x0011962F
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003741 RID: 14145 RVA: 0x0011B466 File Offset: 0x00119666
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003742 RID: 14146 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06003743 RID: 14147 RVA: 0x0011B48C File Offset: 0x0011968C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 477f)
			{
				this.HBJJOCHGOPH = 1235f;
			}
			this.FEAEGGCNIAA().SetFloat("GlassDistortion", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetVector("menu.selectedlevelid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 789f, 1822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003744 RID: 14148 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06003745 RID: 14149 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06003746 RID: 14150 RVA: 0x0011A652 File Offset: 0x00118852
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003747 RID: 14151 RVA: 0x0011B533 File Offset: 0x00119733
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("_NoiseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003748 RID: 14152 RVA: 0x0011B557 File Offset: 0x00119757
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003749 RID: 14153 RVA: 0x0011B590 File Offset: 0x00119790
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 874f)
			{
				this.HBJJOCHGOPH = 1655f;
			}
			this.MICHFGAOPKM().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetVector("AudioClip", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 275f, 967f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600374A RID: 14154 RVA: 0x0011B637 File Offset: 0x00119837
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600374B RID: 14155 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600374C RID: 14156 RVA: 0x0011A652 File Offset: 0x00118852
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600374D RID: 14157 RVA: 0x0011B65C File Offset: 0x0011985C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1832f)
			{
				this.HBJJOCHGOPH = 34f;
			}
			this.DNLMFEGJJDD().SetFloat("plainText", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 465f, 607f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600374E RID: 14158 RVA: 0x0011B704 File Offset: 0x00119904
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 120f)
			{
				this.HBJJOCHGOPH = 741f;
			}
			this.HHIFMIPPMPF().SetFloat("player.goldarc", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetVector("0 seconds", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1314f, 1425f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600374F RID: 14159 RVA: 0x0011B7AB File Offset: 0x001199AB
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003750 RID: 14160 RVA: 0x0011A652 File Offset: 0x00118852
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003751 RID: 14161 RVA: 0x0011B7D0 File Offset: 0x001199D0
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1063f)
			{
				this.HBJJOCHGOPH = 45f;
			}
			this.BKKJJJGADLM().SetFloat("[SoundManager] Loaded skin audio", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetVector("CountEventsGoal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1594f, 140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003752 RID: 14162 RVA: 0x0011B877 File Offset: 0x00119A77
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003753 RID: 14163 RVA: 0x0011A652 File Offset: 0x00118852
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003754 RID: 14164 RVA: 0x0011A652 File Offset: 0x00118852
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003755 RID: 14165 RVA: 0x0011A652 File Offset: 0x00118852
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003756 RID: 14166 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06003757 RID: 14167 RVA: 0x0011B8B0 File Offset: 0x00119AB0
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 506f)
			{
				this.HBJJOCHGOPH = 463f;
			}
			this.HNFFHCLNBDN().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetVector("RecieveChatActionMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 299f, 1071f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003758 RID: 14168 RVA: 0x0011A652 File Offset: 0x00118852
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003759 RID: 14169 RVA: 0x0011B466 File Offset: 0x00119666
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600375A RID: 14170 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x0600375B RID: 14171 RVA: 0x0011B958 File Offset: 0x00119B58
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 4f)
			{
				this.HBJJOCHGOPH = 1360f;
			}
			this.FEAEGGCNIAA().SetFloat("file://", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetVector("LevelNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 367f, 1514f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600375C RID: 14172 RVA: 0x0011BA00 File Offset: 0x00119C00
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1367f)
			{
				this.HBJJOCHGOPH = 1662f;
			}
			this.NBPKMLMCHFN.SetFloat("ViewMenu", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1036f, 1966f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600375D RID: 14173 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x0600375E RID: 14174 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x0600375F RID: 14175 RVA: 0x0011BAA7 File Offset: 0x00119CA7
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003760 RID: 14176 RVA: 0x0011BADE File Offset: 0x00119CDE
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003761 RID: 14177 RVA: 0x0011A652 File Offset: 0x00118852
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003762 RID: 14178 RVA: 0x0011BB02 File Offset: 0x00119D02
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003763 RID: 14179 RVA: 0x0011BB26 File Offset: 0x00119D26
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("YES");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003764 RID: 14180 RVA: 0x0011BB4A File Offset: 0x00119D4A
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("{0:0} hour{1}, ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003765 RID: 14181 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06003766 RID: 14182 RVA: 0x0011B877 File Offset: 0x00119A77
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003767 RID: 14183 RVA: 0x0011BB6E File Offset: 0x00119D6E
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003768 RID: 14184 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06003769 RID: 14185 RVA: 0x0011BBA5 File Offset: 0x00119DA5
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600376A RID: 14186 RVA: 0x0011BBC9 File Offset: 0x00119DC9
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600376B RID: 14187 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x0600376C RID: 14188 RVA: 0x0011BBF0 File Offset: 0x00119DF0
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 593f)
			{
				this.HBJJOCHGOPH = 1632f;
			}
			this.HCGJCMDJPGD().SetFloat("_HexaColor", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetVector("intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1631f, 1337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600376D RID: 14189 RVA: 0x0011BC98 File Offset: 0x00119E98
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 112f)
			{
				this.HBJJOCHGOPH = 1277f;
			}
			this.FEAEGGCNIAA().SetFloat("RecordButton", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1096f, 557f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600376E RID: 14190 RVA: 0x0011BD40 File Offset: 0x00119F40
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 696f)
			{
				this.HBJJOCHGOPH = 582f;
			}
			this.BKKJJJGADLM().SetFloat("+", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetVector("Image_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1978f, 67f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600376F RID: 14191 RVA: 0x0011BDE7 File Offset: 0x00119FE7
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003770 RID: 14192 RVA: 0x0011BE0B File Offset: 0x0011A00B
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003771 RID: 14193 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06003772 RID: 14194 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06003773 RID: 14195 RVA: 0x0011A652 File Offset: 0x00118852
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003774 RID: 14196 RVA: 0x0011BE2F File Offset: 0x0011A02F
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003775 RID: 14197 RVA: 0x0011BE53 File Offset: 0x0011A053
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003776 RID: 14198 RVA: 0x0011A652 File Offset: 0x00118852
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003777 RID: 14199 RVA: 0x0011BE8A File Offset: 0x0011A08A
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000607 RID: 1543
	public Shader SCShader;

	// Token: 0x04000608 RID: 1544
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000609 RID: 1545
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400060A RID: 1546
	private Material BJFKDHHMLJH;
}
