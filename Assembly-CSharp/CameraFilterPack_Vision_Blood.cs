using System;
using UnityEngine;

// Token: 0x02000131 RID: 305
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Blood")]
public class CameraFilterPack_Vision_Blood : MonoBehaviour
{
	// Token: 0x060060B3 RID: 24755 RVA: 0x001D6A68 File Offset: 0x001D4C68
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060060B5 RID: 24757 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x060060B6 RID: 24758 RVA: 0x001D6ACB File Offset: 0x001D4CCB
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060B7 RID: 24759 RVA: 0x001D6B02 File Offset: 0x001D4D02
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("finished");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060B8 RID: 24760 RVA: 0x001D6B26 File Offset: 0x001D4D26
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060B9 RID: 24761 RVA: 0x001D6B5D File Offset: 0x001D4D5D
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060BA RID: 24762 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060060BB RID: 24763 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060060BC RID: 24764 RVA: 0x001D6B94 File Offset: 0x001D4D94
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 873f)
			{
				this.HBJJOCHGOPH = 435f;
			}
			this.MJJIEHANFJA().SetFloat("[GameScene] Submiting rank", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("GenerationMenu", this.HoleSize);
			this.OLHDPICFBOF().SetFloat("_MainTex2", this.HoleSmooth);
			this.EFMCNLELMDO().SetFloat("_EmissionColor", this.Color1);
			this.HEHKGPKLAKK().SetFloat("DPADHOR", this.Color2);
			this.IONHGBPGCHK().SetVector("_Noise", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 836f, 1055f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060BD RID: 24765 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060060BE RID: 24766 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060060BF RID: 24767 RVA: 0x001D6C93 File Offset: 0x001D4E93
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_VignetteSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060060C1 RID: 24769 RVA: 0x001D6CB7 File Offset: 0x001D4EB7
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x060060C2 RID: 24770 RVA: 0x001D6CEE File Offset: 0x001D4EEE
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

	// Token: 0x060060C3 RID: 24771 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x001D6D44 File Offset: 0x001D4F44
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1191f)
			{
				this.HBJJOCHGOPH = 1614f;
			}
			this.HHIAIGCAHDA().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("InfoCanvas", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("color", this.HoleSmooth);
			this.NFKFAAHHLLM().SetFloat("Set Arcs Speed", this.Color1);
			this.IONHGBPGCHK().SetFloat("LevelEditor/patterns", this.Color2);
			this.IONHGBPGCHK().SetVector("settings.cameramovements", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 864f, 1378f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060C6 RID: 24774 RVA: 0x001D6E44 File Offset: 0x001D5044
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1857f)
			{
				this.HBJJOCHGOPH = 1969f;
			}
			this.OGMEGHKECAH().SetFloat("CameraFilterPack_Paper3", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("ShowTitle", this.HoleSize);
			this.GKILCDHJFEG().SetFloat("settings.showHP", this.HoleSmooth);
			this.AELJLBOJAIL().SetFloat("[ResourcesManager] Load text error: not found", this.Color1);
			this.DOHGBNPMBKG().SetFloat(";", this.Color2);
			this.KAFBNOBOIAJ().SetVector("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1668f, 1839f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060C7 RID: 24775 RVA: 0x001D6F44 File Offset: 0x001D5144
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1640f)
			{
				this.HBJJOCHGOPH = 347f;
			}
			this.JLHLHKPHDFO().SetFloat("_Value", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Editor", this.HoleSize);
			this.GKILCDHJFEG().SetFloat("Fade", this.HoleSmooth);
			this.OGMEGHKECAH().SetFloat("back", this.Color1);
			this.FEAEGGCNIAA().SetFloat("Set Satellite Lerp Speed", this.Color2);
			this.NFKFAAHHLLM().SetVector("TimeBGSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 847f, 296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060C8 RID: 24776 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x001D7043 File Offset: 0x001D5243
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060CA RID: 24778 RVA: 0x001D707A File Offset: 0x001D527A
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Share");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060CB RID: 24779 RVA: 0x001D709E File Offset: 0x001D529E
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060060CC RID: 24780 RVA: 0x001D70C4 File Offset: 0x001D52C4
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 271f)
			{
				this.HBJJOCHGOPH = 1879f;
			}
			this.JIBOKBCPDLC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("No Name", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("setbool", this.HoleSmooth);
			this.IONHGBPGCHK().SetFloat("Map: ", this.Color1);
			this.GKILCDHJFEG().SetFloat("settings.arcsdestroydelay", this.Color2);
			this.NJDIODJNGGA().SetVector("TestMapButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 777f, 244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060CD RID: 24781 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060CE RID: 24782 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060CF RID: 24783 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060060D0 RID: 24784 RVA: 0x001D71C4 File Offset: 0x001D53C4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Color1);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Color2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060D1 RID: 24785 RVA: 0x001D72C3 File Offset: 0x001D54C3
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("Reset All");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060D2 RID: 24786 RVA: 0x001D72E7 File Offset: 0x001D54E7
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060D3 RID: 24787 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060D4 RID: 24788 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x060060D5 RID: 24789 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060D6 RID: 24790 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060D7 RID: 24791 RVA: 0x001D731E File Offset: 0x001D551E
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060D8 RID: 24792 RVA: 0x001D7355 File Offset: 0x001D5555
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060D9 RID: 24793 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060DA RID: 24794 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060060DB RID: 24795 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060DC RID: 24796 RVA: 0x001D7379 File Offset: 0x001D5579
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060DD RID: 24797 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060DE RID: 24798 RVA: 0x001D73B0 File Offset: 0x001D55B0
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1203f)
			{
				this.HBJJOCHGOPH = 240f;
			}
			this.ADBKPGFMNKO().SetFloat("maps.", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("' ping: ", this.HoleSize);
			this.ADBKPGFMNKO().SetFloat("New SaveGame", this.HoleSmooth);
			this.EFMCNLELMDO().SetFloat("ItemTemplate", this.Color1);
			this.ABHDNGIHBKE().SetFloat("  |  Events Count: ", this.Color2);
			this.HHIAIGCAHDA().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1661f, 1403f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060DF RID: 24799 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060E0 RID: 24800 RVA: 0x001D74AF File Offset: 0x001D56AF
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_Gamma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060060E1 RID: 24801 RVA: 0x001D74D3 File Offset: 0x001D56D3
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060E2 RID: 24802 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060E3 RID: 24803 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060060E4 RID: 24804 RVA: 0x001D74F7 File Offset: 0x001D56F7
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060E5 RID: 24805 RVA: 0x001D7530 File Offset: 0x001D5730
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1251f)
			{
				this.HBJJOCHGOPH = 1127f;
			}
			this.KEMAALEODNH().SetFloat("[LevelEditorScene] Creating new item...", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this.HoleSize);
			this.NJDIODJNGGA().SetFloat("_Value5", this.HoleSmooth);
			this.ABHDNGIHBKE().SetFloat("SetParticlesParticleSpeed", this.Color1);
			this.HHIAIGCAHDA().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.Color2);
			this.JIBOKBCPDLC().SetVector("Uploading preview image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1931f, 1721f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060E6 RID: 24806 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060060E7 RID: 24807 RVA: 0x001D7630 File Offset: 0x001D5830
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 720f)
			{
				this.HBJJOCHGOPH = 233f;
			}
			this.JIBOKBCPDLC().SetFloat("#availablechallenges", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.HoleSize);
			this.JLHLHKPHDFO().SetFloat("CrosshairOpacitySlider", this.HoleSmooth);
			this.OLHDPICFBOF().SetFloat("note.0", this.Color1);
			this.IONHGBPGCHK().SetFloat("_Value", this.Color2);
			this.ABHDNGIHBKE().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 214f, 1786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060E8 RID: 24808 RVA: 0x001D7730 File Offset: 0x001D5930
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1105f)
			{
				this.HBJJOCHGOPH = 726f;
			}
			this.HHIAIGCAHDA().SetFloat("_YCrop", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("workshop.", this.HoleSize);
			this.DOHGBNPMBKG().SetFloat("#creatingnewitem", this.HoleSmooth);
			this.CIAFLBFJLEJ().SetFloat("RootCanvas", this.Color1);
			this.KOHGPKOFEJO().SetFloat("MenuScene", this.Color2);
			this.NJDIODJNGGA().SetVector("CheckResources () for ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 860f, 457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060E9 RID: 24809 RVA: 0x001D782F File Offset: 0x001D5A2F
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060EA RID: 24810 RVA: 0x001D7866 File Offset: 0x001D5A66
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Fog");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060EB RID: 24811 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060EC RID: 24812 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060060ED RID: 24813 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060EE RID: 24814 RVA: 0x001D788A File Offset: 0x001D5A8A
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("colorD");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060060EF RID: 24815 RVA: 0x001D78AE File Offset: 0x001D5AAE
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("_History2ChromaTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060F0 RID: 24816 RVA: 0x001D78D4 File Offset: 0x001D5AD4
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1985f)
			{
				this.HBJJOCHGOPH = 702f;
			}
			this.GKILCDHJFEG().SetFloat("_CenterX", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Other", this.HoleSize);
			this.AELJLBOJAIL().SetFloat("_Value3", this.HoleSmooth);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/TV_LED", this.Color1);
			this.KOHGPKOFEJO().SetFloat("https://steamcommunity.com/app/513510/workshop/", this.Color2);
			this.NFKFAAHHLLM().SetVector("float,1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1962f, 1994f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060F1 RID: 24817 RVA: 0x001D79D3 File Offset: 0x001D5BD3
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060F2 RID: 24818 RVA: 0x001D7A0A File Offset: 0x001D5C0A
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("settings.volume.game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060F3 RID: 24819 RVA: 0x001D7A30 File Offset: 0x001D5C30
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 84f)
			{
				this.HBJJOCHGOPH = 798f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value3", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("inventory.selected.", this.HoleSize);
			this.DOHGBNPMBKG().SetFloat("_Value6", this.HoleSmooth);
			this.OGMEGHKECAH().SetFloat("settings.enablerankingnotifications", this.Color1);
			this.ABHDNGIHBKE().SetFloat("_Value4", this.Color2);
			this.IONHGBPGCHK().SetVector("[MapEditor] Prepairing map editor...", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1303f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060F4 RID: 24820 RVA: 0x001D7B2F File Offset: 0x001D5D2F
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060F5 RID: 24821 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x060060F6 RID: 24822 RVA: 0x001D7B68 File Offset: 0x001D5D68
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 584f)
			{
				this.HBJJOCHGOPH = 1420f;
			}
			this.JLHLHKPHDFO().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("z", this.HoleSize);
			this.HHIAIGCAHDA().SetFloat("_MainTex2", this.HoleSmooth);
			this.MJJIEHANFJA().SetFloat("LoadMapCanvas", this.Color1);
			this.KEMAALEODNH().SetFloat("Changed config", this.Color2);
			this.EFMCNLELMDO().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1589f, 1046f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060F7 RID: 24823 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x060060F8 RID: 24824 RVA: 0x001D7C67 File Offset: 0x001D5E67
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060F9 RID: 24825 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x060060FA RID: 24826 RVA: 0x001D7CA0 File Offset: 0x001D5EA0
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 993f)
			{
				this.HBJJOCHGOPH = 200f;
			}
			this.ABHDNGIHBKE().SetFloat("_MatrixColor", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/Distortion_Flag", this.HoleSize);
			this.JIBOKBCPDLC().SetFloat("icon.png", this.HoleSmooth);
			this.NFMGLIKNOOC().SetFloat("cameramovements:", this.Color1);
			this.EFMCNLELMDO().SetFloat("[LevelEditorScene] Print Audio Wave: Done", this.Color2);
			this.NJDIODJNGGA().SetVector("_Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1138f, 479f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060FB RID: 24827 RVA: 0x001D7D9F File Offset: 0x001D5F9F
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060FC RID: 24828 RVA: 0x001D7DD6 File Offset: 0x001D5FD6
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060FD RID: 24829 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060060FE RID: 24830 RVA: 0x001D7DFA File Offset: 0x001D5FFA
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060FF RID: 24831 RVA: 0x001D7E31 File Offset: 0x001D6031
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_U");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006100 RID: 24832 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06006101 RID: 24833 RVA: 0x001D7E58 File Offset: 0x001D6058
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 268f)
			{
				this.HBJJOCHGOPH = 1181f;
			}
			this.NJDIODJNGGA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_Value2", this.HoleSize);
			this.DOHGBNPMBKG().SetFloat("ItemNameText", this.HoleSmooth);
			this.ADBKPGFMNKO().SetFloat("settings.selectormapsperpage", this.Color1);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack_TV_Arcade1", this.Color2);
			this.ABHDNGIHBKE().SetVector("Chat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1201f, 288f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006102 RID: 24834 RVA: 0x001D7F58 File Offset: 0x001D6158
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 329f)
			{
				this.HBJJOCHGOPH = 1568f;
			}
			this.ABHDNGIHBKE().SetFloat("_RgbDepthTex", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_Value2", this.HoleSize);
			this.EFMCNLELMDO().SetFloat("/?player=", this.HoleSmooth);
			this.IONHGBPGCHK().SetFloat("AskForPickupItemSpawnTimes", this.Color1);
			this.IONHGBPGCHK().SetFloat("_Value6", this.Color2);
			this.OLHDPICFBOF().SetVector("Joystick1Button8", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1182f, 872f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006103 RID: 24835 RVA: 0x001D8057 File Offset: 0x001D6257
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006104 RID: 24836 RVA: 0x001D807B File Offset: 0x001D627B
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006105 RID: 24837 RVA: 0x001D80B2 File Offset: 0x001D62B2
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006106 RID: 24838 RVA: 0x001D80D8 File Offset: 0x001D62D8
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1348f)
			{
				this.HBJJOCHGOPH = 753f;
			}
			this.ABHDNGIHBKE().SetFloat("Creating new item...", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("<b>#", this.HoleSize);
			this.NFMGLIKNOOC().SetFloat(".g", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("_MaxRadiusOrKInPaper", this.Color1);
			this.KEMAALEODNH().SetFloat("_SampleCount", this.Color2);
			this.HEHKGPKLAKK().SetVector("[GameScene] Events count: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1242f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006107 RID: 24839 RVA: 0x001D81D7 File Offset: 0x001D63D7
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006108 RID: 24840 RVA: 0x001D79D3 File Offset: 0x001D5BD3
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006109 RID: 24841 RVA: 0x001D8210 File Offset: 0x001D6410
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1257f)
			{
				this.HBJJOCHGOPH = 909f;
			}
			this.GKILCDHJFEG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Bloom1", this.HoleSize);
			this.MJJIEHANFJA().SetFloat("menu.playedsolo", this.HoleSmooth);
			this.MJJIEHANFJA().SetFloat("Error0", this.Color1);
			this.CIAFLBFJLEJ().SetFloat("offline", this.Color2);
			this.FEAEGGCNIAA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1921f, 730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600610A RID: 24842 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x0600610B RID: 24843 RVA: 0x001D830F File Offset: 0x001D650F
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600610C RID: 24844 RVA: 0x001D8346 File Offset: 0x001D6546
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600610D RID: 24845 RVA: 0x001D837D File Offset: 0x001D657D
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("Set crosshair color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600610E RID: 24846 RVA: 0x001D83A4 File Offset: 0x001D65A4
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1725f)
			{
				this.HBJJOCHGOPH = 1682f;
			}
			this.HHIAIGCAHDA().SetFloat("/", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("OnReadyClick", this.HoleSize);
			this.NJDIODJNGGA().SetFloat("ACCEPT", this.HoleSmooth);
			this.NFMGLIKNOOC().SetFloat("Scene", this.Color1);
			this.AELJLBOJAIL().SetFloat("...", this.Color2);
			this.HEHKGPKLAKK().SetVector("_Red_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1963f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600610F RID: 24847 RVA: 0x001D84A4 File Offset: 0x001D66A4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1955f)
			{
				this.HBJJOCHGOPH = 663f;
			}
			this.GKILCDHJFEG().SetFloat("isVisible", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("_Bloom0", this.HoleSize);
			this.NJDIODJNGGA().SetFloat("]", this.HoleSmooth);
			this.MJJIEHANFJA().SetFloat("ChangeSelectedLevel", this.Color1);
			this.NFKFAAHHLLM().SetFloat("_TimeX", this.Color2);
			this.GKILCDHJFEG().SetVector("CameraFilterPack_WaterDrop", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 125f, 648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006110 RID: 24848 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006111 RID: 24849 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06006112 RID: 24850 RVA: 0x001D6D25 File Offset: 0x001D4F25
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006113 RID: 24851 RVA: 0x001D85A3 File Offset: 0x001D67A3
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006114 RID: 24852 RVA: 0x001D85DA File Offset: 0x001D67DA
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("Joystick1Button11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006115 RID: 24853 RVA: 0x001D8600 File Offset: 0x001D6800
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1480f)
			{
				this.HBJJOCHGOPH = 1003f;
			}
			this.HEHKGPKLAKK().SetFloat("ScrollPanel", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("RateButton", this.HoleSize);
			this.NJDIODJNGGA().SetFloat("mapselector.lastSearch", this.HoleSmooth);
			this.NFMGLIKNOOC().SetFloat("_TimeX", this.Color1);
			this.AELJLBOJAIL().SetFloat("GameScene", this.Color2);
			this.IONHGBPGCHK().SetVector("music", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1973f, 1725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006116 RID: 24854 RVA: 0x001D86FF File Offset: 0x001D68FF
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006117 RID: 24855 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x040009B5 RID: 2485
	public Shader SCShader;

	// Token: 0x040009B6 RID: 2486
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009B7 RID: 2487
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009B8 RID: 2488
	private Material BJFKDHHMLJH;

	// Token: 0x040009B9 RID: 2489
	[Range(0.01f, 1f)]
	public float HoleSize = 0.6f;

	// Token: 0x040009BA RID: 2490
	[Range(-1f, 1f)]
	public float HoleSmooth = 0.3f;

	// Token: 0x040009BB RID: 2491
	[Range(-2f, 2f)]
	public float Color1 = 0.2f;

	// Token: 0x040009BC RID: 2492
	[Range(-2f, 2f)]
	public float Color2 = 0.9f;
}
