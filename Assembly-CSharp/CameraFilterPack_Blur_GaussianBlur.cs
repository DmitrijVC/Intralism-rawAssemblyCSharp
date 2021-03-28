using System;
using UnityEngine;

// Token: 0x02000061 RID: 97
[AddComponentMenu("Camera Filter Pack/Blur/GaussianBlur")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_GaussianBlur : MonoBehaviour
{
	// Token: 0x06001B0E RID: 6926 RVA: 0x000A84E6 File Offset: 0x000A66E6
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x000A850C File Offset: 0x000A670C
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Size);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x000A85C2 File Offset: 0x000A67C2
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x000A85FC File Offset: 0x000A67FC
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1931f)
			{
				this.HBJJOCHGOPH = 333f;
			}
			this.JIBOKBCPDLC().SetFloat("Cross", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_VelocityScale", this.Size);
			this.BFGNMFCNDBC().SetVector("error", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B13 RID: 6931 RVA: 0x000A86B2 File Offset: 0x000A68B2
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("ResourceIDInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x000A86D6 File Offset: 0x000A68D6
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x000A86F3 File Offset: 0x000A68F3
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x000A872A File Offset: 0x000A692A
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x000A8761 File Offset: 0x000A6961
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_NeutralTonemapperParams1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x000A8785 File Offset: 0x000A6985
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find(" to: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x000A87AC File Offset: 0x000A69AC
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 89f)
			{
				this.HBJJOCHGOPH = 1078f;
			}
			this.MFHPKGICPIO().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("OnSerialize", this.Size);
			this.ADGHJOHKEHG().SetVector("_Offsets", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x000A8864 File Offset: 0x000A6A64
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1213f)
			{
				this.HBJJOCHGOPH = 144f;
			}
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_MainTex2", this.Size);
			this.PGPEMMBJOOG().SetVector("title", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06001B1C RID: 6940 RVA: 0x000A891A File Offset: 0x000A6B1A
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

	// Token: 0x06001B1D RID: 6941 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x000A8951 File Offset: 0x000A6B51
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x000A8975 File Offset: 0x000A6B75
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x000A89AC File Offset: 0x000A6BAC
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x000A86D6 File Offset: 0x000A68D6
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x000A89F0 File Offset: 0x000A6BF0
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1501f)
			{
				this.HBJJOCHGOPH = 726f;
			}
			this.CFEDGDGBCHE().SetFloat(").", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Size);
			this.EFDEIFCDAFG().SetVector("ConfigVersionSlider", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x000A8AA6 File Offset: 0x000A6CA6
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("DifficultyBG");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x000A8ACA File Offset: 0x000A6CCA
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.isMapCompleted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x000A8AF0 File Offset: 0x000A6CF0
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 263f)
			{
				this.HBJJOCHGOPH = 1563f;
			}
			this.MFHPKGICPIO().SetFloat("Case-Sensitive", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat(" Path: ", this.Size);
			this.PGPEMMBJOOG().SetVector("#newhighscore", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x000A8BA8 File Offset: 0x000A6DA8
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1173f)
			{
				this.HBJJOCHGOPH = 278f;
			}
			this.JIBOKBCPDLC().SetFloat("wss://", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("UNDISTORT", this.Size);
			this.JIBOKBCPDLC().SetVector("SetSpeed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x000A86D6 File Offset: 0x000A68D6
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x000A8C5E File Offset: 0x000A6E5E
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x000A8C98 File Offset: 0x000A6E98
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1806f)
			{
				this.HBJJOCHGOPH = 1206f;
			}
			this.BFGNMFCNDBC().SetFloat("#C8C8C8FF", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("challenges.", this.Size);
			this.JIBOKBCPDLC().SetVector("2hands", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x000A8D4E File Offset: 0x000A6F4E
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x000A8D85 File Offset: 0x000A6F85
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("settings.enableranking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x000A8DAC File Offset: 0x000A6FAC
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 396f)
			{
				this.HBJJOCHGOPH = 1395f;
			}
			this.HHIFMIPPMPF().SetFloat("offsets", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("LB", this.Size);
			this.JIBOKBCPDLC().SetVector("_SpotSize", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x000A86D6 File Offset: 0x000A68D6
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x000A8E64 File Offset: 0x000A7064
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1904f)
			{
				this.HBJJOCHGOPH = 1510f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("#yes", this.Size);
			this.HHIFMIPPMPF().SetVector("_SecondTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x000A8F1A File Offset: 0x000A711A
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x000A8F54 File Offset: 0x000A7154
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 531f)
			{
				this.HBJJOCHGOPH = 1591f;
			}
			this.NBPKMLMCHFN.SetFloat("0.00", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("offsets", this.Size);
			this.IONHGBPGCHK().SetVector("CameraFilterPack/FX_Hexagon_Black", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x000A900A File Offset: 0x000A720A
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("SetSunMinSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x000A902E File Offset: 0x000A722E
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x000A9068 File Offset: 0x000A7268
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 512f)
			{
				this.HBJJOCHGOPH = 911f;
			}
			this.HHIFMIPPMPF().SetFloat("RequestForPickupItems", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("/", this.Size);
			this.PGPEMMBJOOG().SetVector("_BlurVector", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x000A9120 File Offset: 0x000A7320
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1351f)
			{
				this.HBJJOCHGOPH = 1364f;
			}
			this.IONHGBPGCHK().SetFloat("NetworkCanvas", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("RecieveChatActionMessage", this.Size);
			this.EPCGJFCCAFH().SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x000A91D6 File Offset: 0x000A73D6
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x000A91FC File Offset: 0x000A73FC
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1997f)
			{
				this.HBJJOCHGOPH = 518f;
			}
			this.CFEDGDGBCHE().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat(".lastCheckpoint.perfectHits", this.Size);
			this.IONHGBPGCHK().SetVector("] ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x000A86D6 File Offset: 0x000A68D6
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x000A92B2 File Offset: 0x000A74B2
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_GaussianBlur");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x000A92D6 File Offset: 0x000A74D6
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x000A930D File Offset: 0x000A750D
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("Depth textures aren't supported on this device ({0})");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x000A9331 File Offset: 0x000A7531
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("hidden");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x000A9355 File Offset: 0x000A7555
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x000A86D6 File Offset: 0x000A68D6
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x000A938C File Offset: 0x000A758C
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x000A86D6 File Offset: 0x000A68D6
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x040003C1 RID: 961
	public Shader SCShader;

	// Token: 0x040003C2 RID: 962
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003C3 RID: 963
	[Range(1f, 16f)]
	public float Size = 10f;

	// Token: 0x040003C4 RID: 964
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003C5 RID: 965
	private Material BJFKDHHMLJH;
}
