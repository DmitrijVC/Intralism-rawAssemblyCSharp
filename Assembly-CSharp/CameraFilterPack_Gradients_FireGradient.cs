using System;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[AddComponentMenu("Camera Filter Pack/Gradients/Fire")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_FireGradient : MonoBehaviour
{
	// Token: 0x060045BB RID: 17851 RVA: 0x00158754 File Offset: 0x00156954
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1007f)
			{
				this.HBJJOCHGOPH = 1380f;
			}
			this.HEHKGPKLAKK().SetFloat("#ok", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("[ReplayScene] Loading replay: ", this.Switch);
			this.NBPKMLMCHFN.SetFloat("SpeedSlider", this.Fade);
			this.FEAEGGCNIAA().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1591f, 1296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045BC RID: 17852 RVA: 0x00158827 File Offset: 0x00156A27
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045BD RID: 17853 RVA: 0x00158860 File Offset: 0x00156A60
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 327f)
			{
				this.HBJJOCHGOPH = 954f;
			}
			this.KBOPGONOCNP().SetFloat("_Green_R", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("_Green_C", this.Switch);
			this.KGOLDDBHIFN().SetFloat("HitVariationSlider", this.Fade);
			this.KGOLDDBHIFN().SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1397f, 604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045BE RID: 17854 RVA: 0x00158934 File Offset: 0x00156B34
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1255f)
			{
				this.HBJJOCHGOPH = 100f;
			}
			this.CFCPHFMKHII().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("#done", this.Switch);
			this.KJMECMIGJJA().SetFloat("SetEnvSpriteImage", this.Fade);
			this.MHBAIEKFBIJ().SetVector("ControllerRightX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 94f, 8f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045BF RID: 17855 RVA: 0x00158A07 File Offset: 0x00156C07
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045C0 RID: 17856 RVA: 0x00158A3E File Offset: 0x00156C3E
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045C1 RID: 17857 RVA: 0x00158A75 File Offset: 0x00156C75
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045C3 RID: 17859 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045C4 RID: 17860 RVA: 0x00158AEB File Offset: 0x00156CEB
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045C5 RID: 17861 RVA: 0x00158A75 File Offset: 0x00156C75
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045C6 RID: 17862 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045C7 RID: 17863 RVA: 0x00158A75 File Offset: 0x00156C75
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045C8 RID: 17864 RVA: 0x00158B22 File Offset: 0x00156D22
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045C9 RID: 17865 RVA: 0x00158B59 File Offset: 0x00156D59
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045CA RID: 17866 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045CC RID: 17868 RVA: 0x00158A75 File Offset: 0x00156C75
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045CD RID: 17869 RVA: 0x00158A75 File Offset: 0x00156C75
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045CE RID: 17870 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045CF RID: 17871 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060045D0 RID: 17872 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060045D1 RID: 17873 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x060045D2 RID: 17874 RVA: 0x00158B7E File Offset: 0x00156D7E
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045D3 RID: 17875 RVA: 0x00158BB8 File Offset: 0x00156DB8
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1882f)
			{
				this.HBJJOCHGOPH = 370f;
			}
			this.NJDIODJNGGA().SetFloat("_PColor2", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("DeleteButton", this.Switch);
			this.NBMPPNFKFLB().SetFloat("maps.", this.Fade);
			this.KGOLDDBHIFN().SetVector("settings.volume.game", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1851f, 1738f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045D4 RID: 17876 RVA: 0x00158B59 File Offset: 0x00156D59
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045D5 RID: 17877 RVA: 0x00158B59 File Offset: 0x00156D59
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045D6 RID: 17878 RVA: 0x00158C8C File Offset: 0x00156E8C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1320f)
			{
				this.HBJJOCHGOPH = 1034f;
			}
			this.HNFFHCLNBDN().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("mapselector.orderby", this.Switch);
			this.JFDGLLEOPGB().SetFloat("id", this.Fade);
			this.HNFFHCLNBDN().SetVector("settings_bindings_sec_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 724f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045D7 RID: 17879 RVA: 0x00158D60 File Offset: 0x00156F60
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1811f)
			{
				this.HBJJOCHGOPH = 1756f;
			}
			this.OKJOKHGJHGF().SetFloat("#ok", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Set particles count per one beat", this.Switch);
			this.FEAEGGCNIAA().SetFloat("score:", this.Fade);
			this.MCDGIILBNIF().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1549f, 1432f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045D8 RID: 17880 RVA: 0x00158A75 File Offset: 0x00156C75
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x00158A75 File Offset: 0x00156C75
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x00158B59 File Offset: 0x00156D59
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045DB RID: 17883 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045DC RID: 17884 RVA: 0x00158A75 File Offset: 0x00156C75
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x00158A75 File Offset: 0x00156C75
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x00158B59 File Offset: 0x00156D59
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045DF RID: 17887 RVA: 0x00158E33 File Offset: 0x00157033
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045E0 RID: 17888 RVA: 0x00158E6A File Offset: 0x0015706A
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045E1 RID: 17889 RVA: 0x00158EA4 File Offset: 0x001570A4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1755f)
			{
				this.HBJJOCHGOPH = 379f;
			}
			this.NBMPPNFKFLB().SetFloat(",", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("_ScreenResolution", this.Switch);
			this.MHBAIEKFBIJ().SetFloat("\\\"", this.Fade);
			this.DOHGBNPMBKG().SetVector("SetSunMinSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 704f, 66f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045E2 RID: 17890 RVA: 0x00158F77 File Offset: 0x00157177
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045E3 RID: 17891 RVA: 0x00158A75 File Offset: 0x00156C75
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x00158B59 File Offset: 0x00156D59
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045E5 RID: 17893 RVA: 0x00158FB0 File Offset: 0x001571B0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 492f)
			{
				this.HBJJOCHGOPH = 546f;
			}
			this.HEHKGPKLAKK().SetFloat("FinalScoreText", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("SpawnObj", this.Switch);
			this.NJDIODJNGGA().SetFloat("_ScreenResolution", this.Fade);
			this.MJJIEHANFJA().SetVector("YES", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 914f, 728f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045E6 RID: 17894 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x060045E7 RID: 17895 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x060045E8 RID: 17896 RVA: 0x00159084 File Offset: 0x00157284
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 782f)
			{
				this.HBJJOCHGOPH = 1666f;
			}
			this.NFMGLIKNOOC().SetFloat("Set Sun Sensitivity", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("/", this.Switch);
			this.EFDEIFCDAFG().SetFloat("settings.hitvariation", this.Fade);
			this.HNFFHCLNBDN().SetVector("CameraFilterPack/3D_Ghost", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1238f, 825f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045E9 RID: 17897 RVA: 0x00158A75 File Offset: 0x00156C75
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045EA RID: 17898 RVA: 0x00158A75 File Offset: 0x00156C75
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045EB RID: 17899 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045EC RID: 17900 RVA: 0x00159158 File Offset: 0x00157358
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045ED RID: 17901 RVA: 0x00158B59 File Offset: 0x00156D59
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045EE RID: 17902 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060045EF RID: 17903 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045F0 RID: 17904 RVA: 0x0015922B File Offset: 0x0015742B
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045F1 RID: 17905 RVA: 0x00159262 File Offset: 0x00157462
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045F2 RID: 17906 RVA: 0x0015929C File Offset: 0x0015749C
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1472f)
			{
				this.HBJJOCHGOPH = 198f;
			}
			this.CFCPHFMKHII().SetFloat("Error: I/O Failure", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("SettingsCanvas", this.Switch);
			this.PHGCJOPFDOG().SetFloat("IconImage", this.Fade);
			this.HNFFHCLNBDN().SetVector("reset", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1596f, 671f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045F3 RID: 17907 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045F4 RID: 17908 RVA: 0x00158A75 File Offset: 0x00156C75
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045F5 RID: 17909 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060045F6 RID: 17910 RVA: 0x00159370 File Offset: 0x00157570
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 698f)
			{
				this.HBJJOCHGOPH = 868f;
			}
			this.NBMPPNFKFLB().SetFloat("Selection Box", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("_TimeX", this.Switch);
			this.FEAEGGCNIAA().SetFloat("Overlay", this.Fade);
			this.IGKFMCPDNOI().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1962f, 130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045F7 RID: 17911 RVA: 0x00158A75 File Offset: 0x00156C75
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045F8 RID: 17912 RVA: 0x00158A75 File Offset: 0x00156C75
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045F9 RID: 17913 RVA: 0x00158827 File Offset: 0x00156A27
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045FA RID: 17914 RVA: 0x00159443 File Offset: 0x00157643
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060045FB RID: 17915 RVA: 0x0015947A File Offset: 0x0015767A
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

	// Token: 0x060045FC RID: 17916 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045FD RID: 17917 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060045FE RID: 17918 RVA: 0x001594B1 File Offset: 0x001576B1
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060045FF RID: 17919 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06004600 RID: 17920 RVA: 0x001594E8 File Offset: 0x001576E8
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004601 RID: 17921 RVA: 0x00159520 File Offset: 0x00157720
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1227f)
			{
				this.HBJJOCHGOPH = 570f;
			}
			this.KBOPGONOCNP().SetFloat("Value", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("#pleasewait", this.Switch);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.Fade);
			this.EHDJJANLINB().SetVector("#pleasewait", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 355f, 1897f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004602 RID: 17922 RVA: 0x001595F3 File Offset: 0x001577F3
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004603 RID: 17923 RVA: 0x00158B59 File Offset: 0x00156D59
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004604 RID: 17924 RVA: 0x00158A75 File Offset: 0x00156C75
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004605 RID: 17925 RVA: 0x0015962A File Offset: 0x0015782A
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004606 RID: 17926 RVA: 0x00158A75 File Offset: 0x00156C75
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004607 RID: 17927 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06004608 RID: 17928 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06004609 RID: 17929 RVA: 0x00159664 File Offset: 0x00157864
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1160f)
			{
				this.HBJJOCHGOPH = 573f;
			}
			this.ABHDNGIHBKE().SetFloat("0.00", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("AddEnvironmentObject", this.Switch);
			this.DOHGBNPMBKG().SetFloat("Cross", this.Fade);
			this.MCDGIILBNIF().SetVector("_MatrixSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1749f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600460A RID: 17930 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x0600460B RID: 17931 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600460C RID: 17932 RVA: 0x00158B59 File Offset: 0x00156D59
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600460D RID: 17933 RVA: 0x00159738 File Offset: 0x00157938
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 902f)
			{
				this.HBJJOCHGOPH = 865f;
			}
			this.KBOPGONOCNP().SetFloat("skin.hit_perfect", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("</color>", this.Switch);
			this.OKJOKHGJHGF().SetFloat("\"", this.Fade);
			this.OKJOKHGJHGF().SetVector("PublishButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1780f, 116f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600460E RID: 17934 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600460F RID: 17935 RVA: 0x0015980C File Offset: 0x00157A0C
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1926f)
			{
				this.HBJJOCHGOPH = 335f;
			}
			this.JFDGLLEOPGB().SetFloat("_Metrics", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("D-Pad Left", this.Switch);
			this.LMLENGFLEBD().SetFloat("_ColorLevel", this.Fade);
			this.MCDGIILBNIF().SetVector("_Green_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 259f, 275f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004610 RID: 17936 RVA: 0x00158A75 File Offset: 0x00156C75
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004611 RID: 17937 RVA: 0x001598DF File Offset: 0x00157ADF
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004612 RID: 17938 RVA: 0x00159918 File Offset: 0x00157B18
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 960f)
			{
				this.HBJJOCHGOPH = 1713f;
			}
			this.JFDGLLEOPGB().SetFloat("Set Particles Input", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("menu.tabid", this.Switch);
			this.MCDGIILBNIF().SetFloat("Description goes here", this.Fade);
			this.EHDJJANLINB().SetVector("mine", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 77f, 1723f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004613 RID: 17939 RVA: 0x001599EC File Offset: 0x00157BEC
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 1197f;
			}
			this.DOHGBNPMBKG().SetFloat("Failed to InstantiateSceneObject prefab: ", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("PUNCloudBestRegion", this.Switch);
			this.EFDEIFCDAFG().SetFloat("Received OnSerialization for view ID ", this.Fade);
			this.AELJLBOJAIL().SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1944f, 989f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004614 RID: 17940 RVA: 0x00159AC0 File Offset: 0x00157CC0
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 51f)
			{
				this.HBJJOCHGOPH = 1060f;
			}
			this.KGOLDDBHIFN().SetFloat("_AdaptTex", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("SaveButton", this.Switch);
			this.MJJIEHANFJA().SetFloat("_ScreenResolution", this.Fade);
			this.EHDJJANLINB().SetVector(" ; ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1301f, 1644f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004615 RID: 17941 RVA: 0x00158A75 File Offset: 0x00156C75
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004616 RID: 17942 RVA: 0x00158B59 File Offset: 0x00156D59
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004617 RID: 17943 RVA: 0x00158B59 File Offset: 0x00156D59
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004618 RID: 17944 RVA: 0x00158B59 File Offset: 0x00156D59
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004619 RID: 17945 RVA: 0x00158A75 File Offset: 0x00156C75
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600461A RID: 17946 RVA: 0x00159B94 File Offset: 0x00157D94
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 454f)
			{
				this.HBJJOCHGOPH = 1338f;
			}
			this.EFDEIFCDAFG().SetFloat(".lastCheckpoint.correctScore", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat(":", this.Switch);
			this.MHBAIEKFBIJ().SetFloat(" not exist", this.Fade);
			this.AELJLBOJAIL().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 600f, 265f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600461B RID: 17947 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x0600461C RID: 17948 RVA: 0x00158A75 File Offset: 0x00156C75
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600461D RID: 17949 RVA: 0x00159C68 File Offset: 0x00157E68
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 670f)
			{
				this.HBJJOCHGOPH = 179f;
			}
			this.DOHGBNPMBKG().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("string", this.Switch);
			this.LMLENGFLEBD().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.Fade);
			this.AELJLBOJAIL().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1937f, 1969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600461E RID: 17950 RVA: 0x00159D3B File Offset: 0x00157F3B
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600461F RID: 17951 RVA: 0x00159D72 File Offset: 0x00157F72
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004620 RID: 17952 RVA: 0x00158A75 File Offset: 0x00156C75
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004621 RID: 17953 RVA: 0x00159DAC File Offset: 0x00157FAC
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1153f)
			{
				this.HBJJOCHGOPH = 406f;
			}
			this.IGKFMCPDNOI().SetFloat("CameraMovementSlider", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_Green_G", this.Switch);
			this.MHBAIEKFBIJ().SetFloat("_Value", this.Fade);
			this.HNFFHCLNBDN().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 463f, 119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004622 RID: 17954 RVA: 0x00158B59 File Offset: 0x00156D59
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004623 RID: 17955 RVA: 0x00159E80 File Offset: 0x00158080
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1191f)
			{
				this.HBJJOCHGOPH = 1609f;
			}
			this.LELKBCALFCF().SetFloat("ticket", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("CameraFilterPack/FX_Drunk2", this.Switch);
			this.CFCPHFMKHII().SetFloat("_TimeX", this.Fade);
			this.LELKBCALFCF().SetVector("winter2020_official", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 963f, 1896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x00158B7E File Offset: 0x00156D7E
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004625 RID: 17957 RVA: 0x00159F53 File Offset: 0x00158153
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004626 RID: 17958 RVA: 0x00159F8A File Offset: 0x0015818A
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004627 RID: 17959 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06004628 RID: 17960 RVA: 0x00159FC4 File Offset: 0x001581C4
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1857f)
			{
				this.HBJJOCHGOPH = 309f;
			}
			this.CFCPHFMKHII().SetFloat("Run a command for the Localization Servise", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", this.Switch);
			this.OKJOKHGJHGF().SetFloat("Sending RPC \"", this.Fade);
			this.MHBAIEKFBIJ().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 982f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x00158A75 File Offset: 0x00156C75
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600462A RID: 17962 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x00158A75 File Offset: 0x00156C75
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600462C RID: 17964 RVA: 0x0015A098 File Offset: 0x00158298
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1367f)
			{
				this.HBJJOCHGOPH = 1476f;
			}
			this.NFMGLIKNOOC().SetFloat("Square", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("gameVolume", this.Switch);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Blur_Bloom", this.Fade);
			this.KBOPGONOCNP().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 283f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600462D RID: 17965 RVA: 0x0015A16B File Offset: 0x0015836B
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600462E RID: 17966 RVA: 0x00158AC6 File Offset: 0x00156CC6
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000776 RID: 1910
	public Shader SCShader;

	// Token: 0x04000777 RID: 1911
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_FireGradient";

	// Token: 0x04000778 RID: 1912
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000779 RID: 1913
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400077A RID: 1914
	private Material BJFKDHHMLJH;

	// Token: 0x0400077B RID: 1915
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x0400077C RID: 1916
	[Range(0f, 1f)]
	public float Fade = 1f;
}
