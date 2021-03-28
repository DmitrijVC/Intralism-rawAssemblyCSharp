using System;
using UnityEngine;

// Token: 0x0200002A RID: 42
[AddComponentMenu("Camera Filter Pack/AAA/Blood")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood : MonoBehaviour
{
	// Token: 0x06000B0A RID: 2826 RVA: 0x00053414 File Offset: 0x00051614
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00053434 File Offset: 0x00051634
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 433f)
			{
				this.HBJJOCHGOPH = 1285f;
			}
			this.HCGJCMDJPGD().SetFloat("_Value6", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_Overlay", this.LightReflect);
			this.LNLKMDPHDCC().SetFloat(".completedMaps", this.Blood1);
			this.FHFLKLMFHOI().SetFloat("_MainTex2", this.Blood2);
			this.IONHGBPGCHK().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", this.Blood3);
			this.IONHGBPGCHK().SetFloat("ScrollPanel", this.Blood4);
			this.HCGJCMDJPGD().SetTexture("Scale environment object by the values", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00053534 File Offset: 0x00051734
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1131f)
			{
				this.HBJJOCHGOPH = 395f;
			}
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/Oculus_NightVision2", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("/files/editor_manual.pdf", this.LightReflect);
			this.NDMPCDHADMJ().SetFloat(".highscore", this.Blood1);
			this.NBPKMLMCHFN.SetFloat("FinishMap", this.Blood2);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Blood3);
			this.NDMPCDHADMJ().SetFloat("Set Object Scale", this.Blood4);
			this.LNLKMDPHDCC().SetTexture("Mouse X", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00053632 File Offset: 0x00051832
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("RPCs can only be sent in rooms. Call of \"") as Texture2D);
		this.SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x0005366B File Offset: 0x0005186B
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("Instrumental");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x000536A4 File Offset: 0x000518A4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 964f)
			{
				this.HBJJOCHGOPH = 1487f;
			}
			this.JFDGLLEOPGB().SetFloat("Joystick1Button10", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("ScoreText", this.LightReflect);
			this.LNLKMDPHDCC().SetFloat("Error: you cannot write/send to this stream that you are reading!", this.Blood1);
			this.IONHGBPGCHK().SetFloat("in seconds. 0 - forever", this.Blood2);
			this.NDMPCDHADMJ().SetFloat("1234332714", this.Blood3);
			this.FHFLKLMFHOI().SetFloat("_BgFade", this.Blood4);
			this.HCGJCMDJPGD().SetTexture("CameraFilterPack/Drawing_Curve", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x000537A2 File Offset: 0x000519A2
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00053414 File Offset: 0x00051614
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x000537DC File Offset: 0x000519DC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1066f)
			{
				this.HBJJOCHGOPH = 1892f;
			}
			this.NDMPCDHADMJ().SetFloat("_Noise", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("settings.fps", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("AccuracyScoreText", this.Blood1);
			this.NDMPCDHADMJ().SetFloat("Tab2Content", this.Blood2);
			this.HNICHJCGJOC().SetFloat(".played", this.Blood3);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.Blood4);
			this.JFDGLLEOPGB().SetTexture("_LightIntensity", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x000538DC File Offset: 0x00051ADC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Blood1);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Blood2);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Blood3);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Blood4);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x000539DC File Offset: 0x00051BDC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1372f)
			{
				this.HBJJOCHGOPH = 1857f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Coroutine container not configured... did you forget to call Init?", this.LightReflect);
			this.FHFLKLMFHOI().SetFloat("mapid", this.Blood1);
			this.LNLKMDPHDCC().SetFloat(": ", this.Blood2);
			this.HCGJCMDJPGD().SetFloat("_Intervale", this.Blood3);
			this.FHFLKLMFHOI().SetFloat("Remove Environment Object", this.Blood4);
			this.IONHGBPGCHK().SetTexture("CameraFilterPack/Gradients_Hue", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x00053414 File Offset: 0x00051614
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00053414 File Offset: 0x00051614
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00053ADA File Offset: 0x00051CDA
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00053B11 File Offset: 0x00051D11
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("[GameScene] Checkpoints count: ") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00053B4C File Offset: 0x00051D4C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1743f)
			{
				this.HBJJOCHGOPH = 562f;
			}
			this.LNLKMDPHDCC().SetFloat("settings.enablehitsoundsinrelax", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("music", this.LightReflect);
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.Blood1);
			this.NBPKMLMCHFN.SetFloat(" - {0}", this.Blood2);
			this.LNLKMDPHDCC().SetFloat("x", this.Blood3);
			this.LNLKMDPHDCC().SetFloat(" ", this.Blood4);
			this.HCGJCMDJPGD().SetTexture("masterVolume", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00053C4A File Offset: 0x00051E4A
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("0.00") as Texture2D);
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00053414 File Offset: 0x00051614
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00053C83 File Offset: 0x00051E83
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("R2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x00053414 File Offset: 0x00051614
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x00053414 File Offset: 0x00051614
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00053414 File Offset: 0x00051614
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00053414 File Offset: 0x00051614
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00053CBC File Offset: 0x00051EBC
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_Blood1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00053CF5 File Offset: 0x00051EF5
	private void MMOKKAPFGAK()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("R1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00053D57 File Offset: 0x00051F57
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load(".icon") as Texture2D);
		this.SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00053D90 File Offset: 0x00051F90
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00053DC7 File Offset: 0x00051FC7
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00053414 File Offset: 0x00051614
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00053E00 File Offset: 0x00052000
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1979f)
			{
				this.HBJJOCHGOPH = 148f;
			}
			this.HNICHJCGJOC().SetFloat(": ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.LightReflect);
			this.FHFLKLMFHOI().SetFloat("_DiffuseColor", this.Blood1);
			this.HCGJCMDJPGD().SetFloat("SetParticlesInput", this.Blood2);
			this.HNICHJCGJOC().SetFloat("_Value2", this.Blood3);
			this.NDMPCDHADMJ().SetFloat("_Value", this.Blood4);
			this.LNLKMDPHDCC().SetTexture("Set Sun MaxSize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00053EFE File Offset: 0x000520FE
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x00053F35 File Offset: 0x00052135
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x00053414 File Offset: 0x00051614
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x00053414 File Offset: 0x00051614
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x00053F6C File Offset: 0x0005216C
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x00053FA3 File Offset: 0x000521A3
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.cameramovements") as Texture2D);
		this.SCShader = Shader.Find("The other scroll rect doesnt support scrolling horizontally");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x00053414 File Offset: 0x00051614
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x00053FDC File Offset: 0x000521DC
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1427f)
			{
				this.HBJJOCHGOPH = 209f;
			}
			this.NDMPCDHADMJ().SetFloat("]", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", this.LightReflect);
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack_Glasses_On6", this.Blood1);
			this.FHFLKLMFHOI().SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", this.Blood2);
			this.NBPKMLMCHFN.SetFloat("_Val", this.Blood3);
			this.HNICHJCGJOC().SetFloat("ShowSprite", this.Blood4);
			this.LNLKMDPHDCC().SetTexture("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x000540DA File Offset: 0x000522DA
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("There is already a virtual axis named ") as Texture2D);
		this.SCShader = Shader.Find("[ResourcesManager] Unloading data resources");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00054113 File Offset: 0x00052313
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load(" Kb") as Texture2D);
		this.SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0005414C File Offset: 0x0005234C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 927f)
			{
				this.HBJJOCHGOPH = 1099f;
			}
			this.FHFLKLMFHOI().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("OpAuthenticate()", this.LightReflect);
			this.JFDGLLEOPGB().SetFloat("Set Particles Emission", this.Blood1);
			this.NBPKMLMCHFN.SetFloat("#ok", this.Blood2);
			this.IONHGBPGCHK().SetFloat("PossibleMapMaxScoreText", this.Blood3);
			this.NBPKMLMCHFN.SetFloat("LT", this.Blood4);
			this.HNICHJCGJOC().SetTexture("[PlayerBase] Highscore: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x0005424C File Offset: 0x0005244C
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1126f)
			{
				this.HBJJOCHGOPH = 1604f;
			}
			this.HNICHJCGJOC().SetFloat("EventSystem", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat(".lastCheckpoint.playerdistance", this.LightReflect);
			this.HCGJCMDJPGD().SetFloat("_Value3", this.Blood1);
			this.HNICHJCGJOC().SetFloat("UseScanLine", this.Blood2);
			this.NDMPCDHADMJ().SetFloat("_Visualize", this.Blood3);
			this.JFDGLLEOPGB().SetFloat("_Value2", this.Blood4);
			this.LNLKMDPHDCC().SetTexture("FavoriteButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00053414 File Offset: 0x00051614
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00053414 File Offset: 0x00051614
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0005434A File Offset: 0x0005254A
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

	// Token: 0x06000B42 RID: 2882 RVA: 0x00054381 File Offset: 0x00052581
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("Drop_Far") as Texture2D);
		this.SCShader = Shader.Find("shader.invert");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x000543BC File Offset: 0x000525BC
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1283f)
			{
				this.HBJJOCHGOPH = 782f;
			}
			this.FHFLKLMFHOI().SetFloat("[MapEditor] Loading map: ", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Mid", this.LightReflect);
			this.HCGJCMDJPGD().SetFloat("EventSystem", this.Blood1);
			this.NDMPCDHADMJ().SetFloat("_TapMedium", this.Blood2);
			this.JFDGLLEOPGB().SetFloat("ready", this.Blood3);
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack/Drawing_Lines", this.Blood4);
			this.FHFLKLMFHOI().SetTexture("Horizontal", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00053414 File Offset: 0x00051614
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00053414 File Offset: 0x00051614
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x00053414 File Offset: 0x00051614
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x000544BC File Offset: 0x000526BC
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 846f)
			{
				this.HBJJOCHGOPH = 137f;
			}
			this.IONHGBPGCHK().SetFloat("Mouse", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("/", this.LightReflect);
			this.JFDGLLEOPGB().SetFloat("_TexelOffsetScale", this.Blood1);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.Blood2);
			this.HCGJCMDJPGD().SetFloat("[ItemsHandler] All in-game items loaded", this.Blood3);
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/3D_Mirror", this.Blood4);
			this.LNLKMDPHDCC().SetTexture("Event Received", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00053414 File Offset: 0x00051614
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400018D RID: 397
	public Shader SCShader;

	// Token: 0x0400018E RID: 398
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400018F RID: 399
	[Range(0f, 128f)]
	public float Blood1;

	// Token: 0x04000190 RID: 400
	[Range(0f, 128f)]
	public float Blood2;

	// Token: 0x04000191 RID: 401
	[Range(0f, 128f)]
	public float Blood3;

	// Token: 0x04000192 RID: 402
	[Range(0f, 128f)]
	public float Blood4 = 1f;

	// Token: 0x04000193 RID: 403
	[Range(0f, 0.004f)]
	public float LightReflect = 0.002f;

	// Token: 0x04000194 RID: 404
	private Material BJFKDHHMLJH;

	// Token: 0x04000195 RID: 405
	private Texture2D FPHEBLMINDA;
}
