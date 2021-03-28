using System;
using UnityEngine;

// Token: 0x02000099 RID: 153
[AddComponentMenu("Camera Filter Pack/Drawing/CellShading2")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_CellShading2 : MonoBehaviour
{
	// Token: 0x06002E1B RID: 11803 RVA: 0x000F7AE0 File Offset: 0x000F5CE0
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E1C RID: 11804 RVA: 0x000F7B17 File Offset: 0x000F5D17
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E1D RID: 11805 RVA: 0x000F7B4E File Offset: 0x000F5D4E
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("UseScanLineSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E1E RID: 11806 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E1F RID: 11807 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06002E20 RID: 11808 RVA: 0x000F7B90 File Offset: 0x000F5D90
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 894f)
			{
				this.HBJJOCHGOPH = 1923f;
			}
			this.MCDGIILBNIF().SetFloat("VIGNETTE_DESAT", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("_Value", this.ColorLevel);
			this.JFDGLLEOPGB().SetFloat("{0:0} minute{1}, ", this.Blur);
			this.MCDGIILBNIF().SetVector("_UV_Transform", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E21 RID: 11809 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06002E22 RID: 11810 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E23 RID: 11811 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E24 RID: 11812 RVA: 0x000F7C74 File Offset: 0x000F5E74
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1285f)
			{
				this.HBJJOCHGOPH = 1815f;
			}
			this.CECJJMKLEAK().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("return ", this.EdgeSize);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/Blur_Movie", this.ColorLevel);
			this.HFBJAOFLCJI().SetFloat("offline", this.Blur);
			this.NLFJGMBCICG().SetVector(".message", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E25 RID: 11813 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002E26 RID: 11814 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06002E27 RID: 11815 RVA: 0x000F7D56 File Offset: 0x000F5F56
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E28 RID: 11816 RVA: 0x000F7B17 File Offset: 0x000F5D17
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E29 RID: 11817 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06002E2A RID: 11818 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E2B RID: 11819 RVA: 0x000F7D90 File Offset: 0x000F5F90
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1333f)
			{
				this.HBJJOCHGOPH = 422f;
			}
			this.CECJJMKLEAK().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("_History2LumaTex", this.EdgeSize);
			this.LENEJAGLCNL().SetFloat("_MainTex2", this.ColorLevel);
			this.KDMBOKLMADJ().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", this.Blur);
			this.HFBJAOFLCJI().SetVector("Year_", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E2C RID: 11820 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E2D RID: 11821 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06002E2E RID: 11822 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06002E2F RID: 11823 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E30 RID: 11824 RVA: 0x000F7E74 File Offset: 0x000F6074
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1701f)
			{
				this.HBJJOCHGOPH = 1023f;
			}
			this.JFDGLLEOPGB().SetFloat(" / ", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("_Offsets", this.EdgeSize);
			this.BLMPMOIDGMG().SetFloat("OK", this.ColorLevel);
			this.NBPKMLMCHFN.SetFloat("Preparing content", this.Blur);
			this.JFDGLLEOPGB().SetVector("_Overlay", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E31 RID: 11825 RVA: 0x000F7F56 File Offset: 0x000F6156
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E32 RID: 11826 RVA: 0x000F7F8D File Offset: 0x000F618D
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E33 RID: 11827 RVA: 0x000F7FB1 File Offset: 0x000F61B1
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E34 RID: 11828 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06002E35 RID: 11829 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06002E36 RID: 11830 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E37 RID: 11831 RVA: 0x000F7FE8 File Offset: 0x000F61E8
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("Hex value #RRGGBB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E38 RID: 11832 RVA: 0x000F800C File Offset: 0x000F620C
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E3A RID: 11834 RVA: 0x000F8078 File Offset: 0x000F6278
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1383f)
			{
				this.HBJJOCHGOPH = 333f;
			}
			this.ADBKPGFMNKO().SetFloat("_SizeY", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("InputField", this.EdgeSize);
			this.ADAFMBOGPLN().SetFloat("Case-Sensitive", this.ColorLevel);
			this.MMOODGIODPC().SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", this.Blur);
			this.NBMPPNFKFLB().SetVector("FPSToggle", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E3B RID: 11835 RVA: 0x000F815A File Offset: 0x000F635A
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E3C RID: 11836 RVA: 0x000F8191 File Offset: 0x000F6391
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("bool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E3D RID: 11837 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06002E3E RID: 11838 RVA: 0x000F81B8 File Offset: 0x000F63B8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1728f)
			{
				this.HBJJOCHGOPH = 1503f;
			}
			this.DOHGBNPMBKG().SetFloat("LeaderboardsButton", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("DISTORT", this.EdgeSize);
			this.IIJMIPBMMBF().SetFloat("-", this.ColorLevel);
			this.LEIAFCPJMDP().SetFloat("request", this.Blur);
			this.KDMBOKLMADJ().SetVector("[NetworkManager] Connection failed: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E3F RID: 11839 RVA: 0x000F829A File Offset: 0x000F649A
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E40 RID: 11840 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06002E41 RID: 11841 RVA: 0x000F82BE File Offset: 0x000F64BE
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E42 RID: 11842 RVA: 0x000F82F8 File Offset: 0x000F64F8
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
			this.NBPKMLMCHFN.SetFloat("_EdgeSize", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("_ColorLevel", this.ColorLevel);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Blur);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E43 RID: 11843 RVA: 0x000F83DC File Offset: 0x000F65DC
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 279f)
			{
				this.HBJJOCHGOPH = 1477f;
			}
			this.LEIAFCPJMDP().SetFloat(",", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("GlassesColor2", this.EdgeSize);
			this.HKGAONMOBMH().SetFloat("_Gamma", this.ColorLevel);
			this.KDMBOKLMADJ().SetFloat("<color=#{0}>{1}</color>", this.Blur);
			this.NBPKMLMCHFN.SetVector("SpawnObj", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E44 RID: 11844 RVA: 0x000F84C0 File Offset: 0x000F66C0
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 108f)
			{
				this.HBJJOCHGOPH = 1022f;
			}
			this.ADAFMBOGPLN().SetFloat(" cannot be used as a 3D LUT.", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("settings_bindings_", this.EdgeSize);
			this.IIJMIPBMMBF().SetFloat("================================", this.ColorLevel);
			this.ADBKPGFMNKO().SetFloat("_NormalAndRoughnessTexture", this.Blur);
			this.BAGICADFBAB().SetVector("position", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E45 RID: 11845 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E46 RID: 11846 RVA: 0x000F85A2 File Offset: 0x000F67A2
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E47 RID: 11847 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06002E48 RID: 11848 RVA: 0x000F85DC File Offset: 0x000F67DC
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 498f)
			{
				this.HBJJOCHGOPH = 82f;
			}
			this.OKJOKHGJHGF().SetFloat("float,10", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("skin.hit_normal", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("_BlurFilterDistance", this.ColorLevel);
			this.MMOODGIODPC().SetFloat("_SecondTex", this.Blur);
			this.JFDGLLEOPGB().SetVector("CameraFilterPack/Edge_Edge_filter", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E49 RID: 11849 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06002E4A RID: 11850 RVA: 0x000F86BE File Offset: 0x000F68BE
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("_Params1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E4B RID: 11851 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E4C RID: 11852 RVA: 0x000F86E2 File Offset: 0x000F68E2
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E4D RID: 11853 RVA: 0x000F8708 File Offset: 0x000F6908
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 925f)
			{
				this.HBJJOCHGOPH = 842f;
			}
			this.HKGAONMOBMH().SetFloat("EventTimeInputField", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("Fade", this.EdgeSize);
			this.CFCPHFMKHII().SetFloat("_Bloom5", this.ColorLevel);
			this.NBPKMLMCHFN.SetFloat("Preparing configuration", this.Blur);
			this.LEIAFCPJMDP().SetVector("Xbox Home", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E4E RID: 11854 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E4F RID: 11855 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E50 RID: 11856 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E51 RID: 11857 RVA: 0x000F87EA File Offset: 0x000F69EA
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E52 RID: 11858 RVA: 0x000F8821 File Offset: 0x000F6A21
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E53 RID: 11859 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06002E54 RID: 11860 RVA: 0x000F8845 File Offset: 0x000F6A45
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E55 RID: 11861 RVA: 0x000F887C File Offset: 0x000F6A7C
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E56 RID: 11862 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E57 RID: 11863 RVA: 0x000F88B3 File Offset: 0x000F6AB3
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E58 RID: 11864 RVA: 0x000F88D8 File Offset: 0x000F6AD8
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1696f)
			{
				this.HBJJOCHGOPH = 955f;
			}
			this.NBPKMLMCHFN.SetFloat(" PhotonView: ", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("PunRespawn", this.EdgeSize);
			this.CECJJMKLEAK().SetFloat("maps.", this.ColorLevel);
			this.KDMBOKLMADJ().SetFloat("_LutTex", this.Blur);
			this.DOHGBNPMBKG().SetVector("CameraFilterPack/Drawing_Paper", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E59 RID: 11865 RVA: 0x000F89BA File Offset: 0x000F6BBA
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E5A RID: 11866 RVA: 0x000F89E0 File Offset: 0x000F6BE0
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 745f)
			{
				this.HBJJOCHGOPH = 1665f;
			}
			this.OKJOKHGJHGF().SetFloat("Curve texture", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("_TimeX", this.EdgeSize);
			this.IIJMIPBMMBF().SetFloat("ViewMenu", this.ColorLevel);
			this.HKGAONMOBMH().SetFloat("itemdefid[0]", this.Blur);
			this.NLFJGMBCICG().SetVector("Down", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E5B RID: 11867 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06002E5C RID: 11868 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06002E5D RID: 11869 RVA: 0x000F8AC2 File Offset: 0x000F6CC2
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("_Curve");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E5E RID: 11870 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06002E5F RID: 11871 RVA: 0x000F8AE6 File Offset: 0x000F6CE6
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E60 RID: 11872 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E61 RID: 11873 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06002E62 RID: 11874 RVA: 0x000F8B1D File Offset: 0x000F6D1D
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("Soundtrack");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E63 RID: 11875 RVA: 0x000F8B41 File Offset: 0x000F6D41
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E64 RID: 11876 RVA: 0x000F8B78 File Offset: 0x000F6D78
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1359f)
			{
				this.HBJJOCHGOPH = 1310f;
			}
			this.OKJOKHGJHGF().SetFloat("_Value13", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("Object ID. Case-Sensitive", this.EdgeSize);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Colors_RgbClamp", this.ColorLevel);
			this.NBMPPNFKFLB().SetFloat("#no", this.Blur);
			this.GJHPODJOBHL().SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E65 RID: 11877 RVA: 0x000F8C5A File Offset: 0x000F6E5A
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E66 RID: 11878 RVA: 0x000F8C94 File Offset: 0x000F6E94
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 456f)
			{
				this.HBJJOCHGOPH = 970f;
			}
			this.IIJMIPBMMBF().SetFloat("ResourcesConfig", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("[Down]", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("tagElement", this.ColorLevel);
			this.OKJOKHGJHGF().SetFloat("Called GetNumberOfCurrentPlayers()", this.Blur);
			this.GJHPODJOBHL().SetVector("Joystick1Button", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E67 RID: 11879 RVA: 0x000F8D76 File Offset: 0x000F6F76
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E68 RID: 11880 RVA: 0x000F8DAD File Offset: 0x000F6FAD
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E69 RID: 11881 RVA: 0x000F8DE4 File Offset: 0x000F6FE4
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_DigitalMatrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E6A RID: 11882 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E6B RID: 11883 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06002E6C RID: 11884 RVA: 0x000F8E08 File Offset: 0x000F7008
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E6D RID: 11885 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06002E6E RID: 11886 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06002E6F RID: 11887 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06002E70 RID: 11888 RVA: 0x000F8E2C File Offset: 0x000F702C
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("CheckCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E71 RID: 11889 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x06002E72 RID: 11890 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E73 RID: 11891 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06002E74 RID: 11892 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E75 RID: 11893 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06002E76 RID: 11894 RVA: 0x000F8E50 File Offset: 0x000F7050
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

	// Token: 0x06002E77 RID: 11895 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x06002E78 RID: 11896 RVA: 0x000F8E87 File Offset: 0x000F7087
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E79 RID: 11897 RVA: 0x000F8EBE File Offset: 0x000F70BE
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("player.linea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E7A RID: 11898 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x000F8EE4 File Offset: 0x000F70E4
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1733f)
			{
				this.HBJJOCHGOPH = 1398f;
			}
			this.BLMPMOIDGMG().SetFloat("_Contrast", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat(" left", this.EdgeSize);
			this.HEHKGPKLAKK().SetFloat("All bindings reset to default values. PlayerPrefs have been removed for each key.", this.ColorLevel);
			this.MMOODGIODPC().SetFloat("#failed!", this.Blur);
			this.DOHGBNPMBKG().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E7C RID: 11900 RVA: 0x000F8845 File Offset: 0x000F6A45
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E7D RID: 11901 RVA: 0x000F8FC8 File Offset: 0x000F71C8
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 339f)
			{
				this.HBJJOCHGOPH = 453f;
			}
			this.NBMPPNFKFLB().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_MainTex2", this.EdgeSize);
			this.LENEJAGLCNL().SetFloat("workshop.", this.ColorLevel);
			this.DOHGBNPMBKG().SetFloat("_Axis", this.Blur);
			this.CFCPHFMKHII().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E7E RID: 11902 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06002E7F RID: 11903 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E80 RID: 11904 RVA: 0x000F90AC File Offset: 0x000F72AC
	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1381f)
			{
				this.HBJJOCHGOPH = 1951f;
			}
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack/TV_Chromatical2", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("https://store.steampowered.com/itemstore/513510/", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("%", this.ColorLevel);
			this.ADBKPGFMNKO().SetFloat("settings.volume.editor", this.Blur);
			this.LEIAFCPJMDP().SetVector("inventory.selected.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E81 RID: 11905 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06002E82 RID: 11906 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E83 RID: 11907 RVA: 0x000F9190 File Offset: 0x000F7390
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 308f)
			{
				this.HBJJOCHGOPH = 627f;
			}
			this.BAGICADFBAB().SetFloat("_DiffuseColor", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("_ScreenSize", this.EdgeSize);
			this.CECJJMKLEAK().SetFloat("player.greenarc", this.ColorLevel);
			this.GJHPODJOBHL().SetFloat("_ScreenResolution", this.Blur);
			this.ADAFMBOGPLN().SetVector(". The group number should be at least 1.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E84 RID: 11908 RVA: 0x000F9274 File Offset: 0x000F7474
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1135f)
			{
				this.HBJJOCHGOPH = 515f;
			}
			this.BKKJJJGADLM().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_Linecount", this.EdgeSize);
			this.MMOODGIODPC().SetFloat("/", this.ColorLevel);
			this.NBMPPNFKFLB().SetFloat("<b>Max Score</b>:", this.Blur);
			this.JFDGLLEOPGB().SetVector(": ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E85 RID: 11909 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06002E86 RID: 11910 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06002E87 RID: 11911 RVA: 0x000F9356 File Offset: 0x000F7556
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("https://store.steampowered.com/itemstore/513510/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E88 RID: 11912 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E89 RID: 11913 RVA: 0x000F937C File Offset: 0x000F757C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 274f)
			{
				this.HBJJOCHGOPH = 1994f;
			}
			this.IIJMIPBMMBF().SetFloat("NameText", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat(" region", this.EdgeSize);
			this.LEIAFCPJMDP().SetFloat("[CraftingPanel] Init", this.ColorLevel);
			this.NLFJGMBCICG().SetFloat("y", this.Blur);
			this.HEHKGPKLAKK().SetVector("#highscore", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E8A RID: 11914 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06002E8B RID: 11915 RVA: 0x000F9460 File Offset: 0x000F7660
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 815f)
			{
				this.HBJJOCHGOPH = 862f;
			}
			this.CFCPHFMKHII().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("_ScreenResolution", this.EdgeSize);
			this.JFDGLLEOPGB().SetFloat("settings.volume.game", this.ColorLevel);
			this.DOHGBNPMBKG().SetFloat("tintColor", this.Blur);
			this.MCDGIILBNIF().SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E8C RID: 11916 RVA: 0x000F9544 File Offset: 0x000F7744
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 928f)
			{
				this.HBJJOCHGOPH = 1343f;
			}
			this.NBMPPNFKFLB().SetFloat("NEW_ACHIEVEMENT_1_26", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", this.EdgeSize);
			this.BAGICADFBAB().SetFloat("Bad parameters for set! Use <language>", this.ColorLevel);
			this.CFCPHFMKHII().SetFloat("MenuScene", this.Blur);
			this.NBPKMLMCHFN.SetVector("\\n", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E8D RID: 11917 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06002E8E RID: 11918 RVA: 0x000F9628 File Offset: 0x000F7828
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 212f)
			{
				this.HBJJOCHGOPH = 209f;
			}
			this.LENEJAGLCNL().SetFloat("Failed!", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("Scene", this.EdgeSize);
			this.IIJMIPBMMBF().SetFloat("Set Object Rotation", this.ColorLevel);
			this.LEIAFCPJMDP().SetFloat("_TimeX", this.Blur);
			this.LENEJAGLCNL().SetVector("[ERROR KEY {0}]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E8F RID: 11919 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06002E90 RID: 11920 RVA: 0x000F970C File Offset: 0x000F790C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 294f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			this.NBMPPNFKFLB().SetFloat("_Value", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("<color=white>PhotonView Group: ", this.EdgeSize);
			this.JFDGLLEOPGB().SetFloat("  |  Events Count: ", this.ColorLevel);
			this.CECJJMKLEAK().SetFloat("AudioSampler", this.Blur);
			this.GJHPODJOBHL().SetVector("CameraFilterPack/Light_Water", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E91 RID: 11921 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06002E92 RID: 11922 RVA: 0x000F97F0 File Offset: 0x000F79F0
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 278f)
			{
				this.HBJJOCHGOPH = 1969f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value4", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/BlurTiltShift_V", this.EdgeSize);
			this.JFDGLLEOPGB().SetFloat("_Value13", this.ColorLevel);
			this.DOHGBNPMBKG().SetFloat("%]</b> ", this.Blur);
			this.NLFJGMBCICG().SetVector("Exit to menu?", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E93 RID: 11923 RVA: 0x000F98D2 File Offset: 0x000F7AD2
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E94 RID: 11924 RVA: 0x000F98F8 File Offset: 0x000F7AF8
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1613f)
			{
				this.HBJJOCHGOPH = 398f;
			}
			this.JFDGLLEOPGB().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.EdgeSize);
			this.CFCPHFMKHII().SetFloat(": ", this.ColorLevel);
			this.HFBJAOFLCJI().SetFloat("reset", this.Blur);
			this.DOHGBNPMBKG().SetVector("_AlphaHexa", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E95 RID: 11925 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E96 RID: 11926 RVA: 0x000F99DA File Offset: 0x000F7BDA
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E97 RID: 11927 RVA: 0x000F99FE File Offset: 0x000F7BFE
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("LevelEditor/patterns");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E98 RID: 11928 RVA: 0x000F9A22 File Offset: 0x000F7C22
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E99 RID: 11929 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E9A RID: 11930 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E9B RID: 11931 RVA: 0x000F9A59 File Offset: 0x000F7C59
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E9C RID: 11932 RVA: 0x000F9A90 File Offset: 0x000F7C90
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 517f)
			{
				this.HBJJOCHGOPH = 535f;
			}
			this.MCDGIILBNIF().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("/", this.EdgeSize);
			this.JFDGLLEOPGB().SetFloat("Texture2", this.ColorLevel);
			this.OKJOKHGJHGF().SetFloat("/icon", this.Blur);
			this.NBMPPNFKFLB().SetVector("_MiddleGrey", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E9D RID: 11933 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06002E9E RID: 11934 RVA: 0x000F9B72 File Offset: 0x000F7D72
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("SpeedSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E9F RID: 11935 RVA: 0x000F9B98 File Offset: 0x000F7D98
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 780f)
			{
				this.HBJJOCHGOPH = 919f;
			}
			this.CECJJMKLEAK().SetFloat("CameraFilterPack/Vision_Plasma", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("[PlayerController] ", this.EdgeSize);
			this.ADAFMBOGPLN().SetFloat("CameraFilterPack/TV_Distorted", this.ColorLevel);
			this.ADAFMBOGPLN().SetFloat("_ScreenResolution", this.Blur);
			this.CECJJMKLEAK().SetVector("_Intensity", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002EA0 RID: 11936 RVA: 0x000F7B72 File Offset: 0x000F5D72
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002EA1 RID: 11937 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x06002EA2 RID: 11938 RVA: 0x000F9C7A File Offset: 0x000F7E7A
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002EA3 RID: 11939 RVA: 0x000F9C9E File Offset: 0x000F7E9E
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_CellShading2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000557 RID: 1367
	public Shader SCShader;

	// Token: 0x04000558 RID: 1368
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000559 RID: 1369
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400055A RID: 1370
	private Material BJFKDHHMLJH;

	// Token: 0x0400055B RID: 1371
	[Range(0f, 1f)]
	public float EdgeSize = 0.1f;

	// Token: 0x0400055C RID: 1372
	[Range(0f, 10f)]
	public float ColorLevel = 4f;

	// Token: 0x0400055D RID: 1373
	[Range(0f, 1f)]
	public float Blur = 1f;
}
