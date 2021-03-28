using System;
using UnityEngine;

// Token: 0x0200005F RID: 95
[AddComponentMenu("Camera Filter Pack/Blur/DitherOffset")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_DitherOffset : MonoBehaviour
{
	// Token: 0x06001AAB RID: 6827 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x000A67EF File Offset: 0x000A49EF
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("restrictions\n\n#until: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x000A6813 File Offset: 0x000A4A13
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("#alreadystarted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x000A6854 File Offset: 0x000A4A54
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x000A6878 File Offset: 0x000A4A78
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_Distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x000A689C File Offset: 0x000A4A9C
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x000A68C0 File Offset: 0x000A4AC0
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1856f)
			{
				this.HBJJOCHGOPH = 737f;
			}
			this.DNLMFEGJJDD().SetFloat("/icon", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_Value4", (float)this.Level);
			this.IONHGBPGCHK().SetVector("] Suggested ", this.Distance);
			this.DNLMFEGJJDD().SetVector("CameraFilterPack/Glasses_On", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1563f, 1980f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x000A699C File Offset: 0x000A4B9C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1473f)
			{
				this.HBJJOCHGOPH = 363f;
			}
			this.HNICHJCGJOC().SetFloat("_HexaColor", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("Tab2Content", (float)this.Level);
			this.IONHGBPGCHK().SetVector("_ScreenResolution", this.Distance);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1543f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x000A6A78 File Offset: 0x000A4C78
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 209f)
			{
				this.HBJJOCHGOPH = 1571f;
			}
			this.LONNIJMNKFB().SetFloat("settings.cameramovements", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", (float)this.Level);
			this.LONNIJMNKFB().SetVector("Joystick1Button4", this.Distance);
			this.HNICHJCGJOC().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 83f, 1643f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x000A6B51 File Offset: 0x000A4D51
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

	// Token: 0x06001AB8 RID: 6840 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x000A6B88 File Offset: 0x000A4D88
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x000A6BC0 File Offset: 0x000A4DC0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 542f)
			{
				this.HBJJOCHGOPH = 426f;
			}
			this.LNLKMDPHDCC().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Joystick1Button5", (float)this.Level);
			this.LONNIJMNKFB().SetVector("[Up]", this.Distance);
			this.LNLKMDPHDCC().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 487f, 1804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x000A6C9C File Offset: 0x000A4E9C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1315f)
			{
				this.HBJJOCHGOPH = 1359f;
			}
			this.LNLKMDPHDCC().SetFloat("shader.none", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_MainTex2", (float)this.Level);
			this.DNLMFEGJJDD().SetVector("Created", this.Distance);
			this.NBPKMLMCHFN.SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1410f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x000A6D75 File Offset: 0x000A4F75
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x000A6D99 File Offset: 0x000A4F99
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_DitherOffset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x000A6DBD File Offset: 0x000A4FBD
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("EnvironmentSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x000A6DE1 File Offset: 0x000A4FE1
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x000A6E18 File Offset: 0x000A5018
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x000A6E4F File Offset: 0x000A504F
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("[PlayerBase] ShowImage \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x000A6E73 File Offset: 0x000A5073
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x000A6E98 File Offset: 0x000A5098
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 348f)
			{
				this.HBJJOCHGOPH = 1999f;
			}
			this.IONHGBPGCHK().SetFloat("path", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_Value3", (float)this.Level);
			this.DNLMFEGJJDD().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Distance);
			this.LNLKMDPHDCC().SetVector("Hidden/Image Effects/Cinematic/AmbientOcclusion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 727f, 228f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x000A6F74 File Offset: 0x000A5174
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 878f)
			{
				this.HBJJOCHGOPH = 1781f;
			}
			this.NBPKMLMCHFN.SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_Green_B", (float)this.Level);
			this.LONNIJMNKFB().SetVector("Dropped Object: ", this.Distance);
			this.DNLMFEGJJDD().SetVector("???", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 150f, 1168f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x000A704D File Offset: 0x000A524D
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x000A7084 File Offset: 0x000A5284
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x000A70BC File Offset: 0x000A52BC
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
			this.NBPKMLMCHFN.SetFloat("_Level", (float)this.Level);
			this.NBPKMLMCHFN.SetVector("_Distance", this.Distance);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x000A7198 File Offset: 0x000A5398
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 438f)
			{
				this.HBJJOCHGOPH = 432f;
			}
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_TimeX", (float)this.Level);
			this.DNLMFEGJJDD().SetVector("_TimeX", this.Distance);
			this.LONNIJMNKFB().SetVector("CameraFilterPack/Blend2Camera_DarkerColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1667f, 1080f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x000A72A0 File Offset: 0x000A54A0
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 531f)
			{
				this.HBJJOCHGOPH = 2f;
			}
			this.DNLMFEGJJDD().SetFloat("maps.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", (float)this.Level);
			this.DNLMFEGJJDD().SetVector("_Value", this.Distance);
			this.DNLMFEGJJDD().SetVector("SupportLogger Info: PUN {0}: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1369f, 1734f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x000A6837 File Offset: 0x000A4A37
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x000A737C File Offset: 0x000A557C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1958f)
			{
				this.HBJJOCHGOPH = 1077f;
			}
			this.HNICHJCGJOC().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("[SteamManager] Connecting to server", (float)this.Level);
			this.HNICHJCGJOC().SetVector("CameraFilterPack/RainFX", this.Distance);
			this.IONHGBPGCHK().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 364f, 762f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x000A7458 File Offset: 0x000A5658
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 192f)
			{
				this.HBJJOCHGOPH = 1722f;
			}
			this.LNLKMDPHDCC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat(". Check if the server is available.", (float)this.Level);
			this.HNICHJCGJOC().SetVector("_Blue_C", this.Distance);
			this.LONNIJMNKFB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 879f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x040003B3 RID: 947
	public Shader SCShader;

	// Token: 0x040003B4 RID: 948
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003B5 RID: 949
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003B6 RID: 950
	private Material BJFKDHHMLJH;

	// Token: 0x040003B7 RID: 951
	[Range(1f, 16f)]
	public int Level = 4;

	// Token: 0x040003B8 RID: 952
	public Vector2 Distance = new Vector2(30f, 0f);
}
