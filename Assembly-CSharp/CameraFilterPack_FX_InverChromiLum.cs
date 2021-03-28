using System;
using UnityEngine;

// Token: 0x020000CF RID: 207
[AddComponentMenu("Camera Filter Pack/FX/InverChromiLum")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_InverChromiLum : MonoBehaviour
{
	// Token: 0x06003EAE RID: 16046 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06003EAF RID: 16047 RVA: 0x001383AF File Offset: 0x001365AF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_InverChromiLum");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003EB0 RID: 16048 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06003EB1 RID: 16049 RVA: 0x001383D4 File Offset: 0x001365D4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 891f)
			{
				this.HBJJOCHGOPH = 1454f;
			}
			this.OIMMPLPBLBK().SetFloat(". No ViewIDs are free to use. Max is: ", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetVector("[MenuScene] Error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1093f, 361f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EB2 RID: 16050 RVA: 0x0013847C File Offset: 0x0013667C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1828f)
			{
				this.HBJJOCHGOPH = 200f;
			}
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_LoopCount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 994f, 676f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EB3 RID: 16051 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06003EB4 RID: 16052 RVA: 0x00138523 File Offset: 0x00136723
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EB5 RID: 16053 RVA: 0x0013855A File Offset: 0x0013675A
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EB6 RID: 16054 RVA: 0x00138591 File Offset: 0x00136791
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find(" has no method \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EB7 RID: 16055 RVA: 0x001385B5 File Offset: 0x001367B5
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EB8 RID: 16056 RVA: 0x001385EC File Offset: 0x001367EC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1214f)
			{
				this.HBJJOCHGOPH = 427f;
			}
			this.ADGHJOHKEHG().SetFloat("Joystick", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("data", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 337f, 1375f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EB9 RID: 16057 RVA: 0x00138693 File Offset: 0x00136893
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003EBA RID: 16058 RVA: 0x001386B7 File Offset: 0x001368B7
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("Joystick1Button6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003EBB RID: 16059 RVA: 0x001386DB File Offset: 0x001368DB
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find(" Remote called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EBC RID: 16060 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003EBD RID: 16061 RVA: 0x001386FF File Offset: 0x001368FF
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EBE RID: 16062 RVA: 0x0013871C File Offset: 0x0013691C
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EBF RID: 16063 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003EC0 RID: 16064 RVA: 0x00138753 File Offset: 0x00136953
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EC1 RID: 16065 RVA: 0x0013878A File Offset: 0x0013698A
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EC2 RID: 16066 RVA: 0x001387B0 File Offset: 0x001369B0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 504f)
			{
				this.HBJJOCHGOPH = 1263f;
			}
			this.JLHLHKPHDFO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetVector("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 286f, 900f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EC3 RID: 16067 RVA: 0x00138857 File Offset: 0x00136A57
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("AddEnvironmentSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EC4 RID: 16068 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06003EC5 RID: 16069 RVA: 0x0013887B File Offset: 0x00136A7B
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EC6 RID: 16070 RVA: 0x001388B2 File Offset: 0x00136AB2
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EC7 RID: 16071 RVA: 0x001386FF File Offset: 0x001368FF
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EC8 RID: 16072 RVA: 0x001388EC File Offset: 0x00136AEC
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1011f)
			{
				this.HBJJOCHGOPH = 1074f;
			}
			this.OIMMPLPBLBK().SetFloat("[NetworkManager] Join failed", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetVector("MenuScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1270f, 1944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EC9 RID: 16073 RVA: 0x00138993 File Offset: 0x00136B93
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003ECA RID: 16074 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06003ECB RID: 16075 RVA: 0x001389B8 File Offset: 0x00136BB8
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

	// Token: 0x06003ECC RID: 16076 RVA: 0x001386FF File Offset: 0x001368FF
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003ECD RID: 16077 RVA: 0x00138A5F File Offset: 0x00136C5F
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003ECE RID: 16078 RVA: 0x00138A98 File Offset: 0x00136C98
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1862f)
			{
				this.HBJJOCHGOPH = 369f;
			}
			this.OIMMPLPBLBK().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 594f, 1886f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003ECF RID: 16079 RVA: 0x00138B3F File Offset: 0x00136D3F
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.bgcolor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003ED0 RID: 16080 RVA: 0x00138B63 File Offset: 0x00136D63
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("mapselector.filter.officialsortmode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003ED1 RID: 16081 RVA: 0x00138B88 File Offset: 0x00136D88
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 208f)
			{
				this.HBJJOCHGOPH = 368f;
			}
			this.JLHLHKPHDFO().SetFloat("menu.playedsolo", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetVector("-", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1450f, 1902f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003ED2 RID: 16082 RVA: 0x00138C2F File Offset: 0x00136E2F
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("CameraFilterPack_RainFX_Anm");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003ED3 RID: 16083 RVA: 0x00138C54 File Offset: 0x00136E54
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 70f)
			{
				this.HBJJOCHGOPH = 831f;
			}
			this.DBOLLHHMKKN().SetFloat("Item ", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetVector("Set Sun MaxSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 592f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x00138CFB File Offset: 0x00136EFB
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

	// Token: 0x06003ED5 RID: 16085 RVA: 0x00138D32 File Offset: 0x00136F32
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003ED6 RID: 16086 RVA: 0x001386FF File Offset: 0x001368FF
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003ED7 RID: 16087 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003ED8 RID: 16088 RVA: 0x00138D6C File Offset: 0x00136F6C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1685f)
			{
				this.HBJJOCHGOPH = 107f;
			}
			this.DEFBJOCJJKF().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("RECORD [R]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 266f, 524f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003ED9 RID: 16089 RVA: 0x00138E13 File Offset: 0x00137013
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("File not found: {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EDA RID: 16090 RVA: 0x00138E38 File Offset: 0x00137038
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1411f)
			{
				this.HBJJOCHGOPH = 902f;
			}
			this.OIMMPLPBLBK().SetFloat("-", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetVector("lobby '{0}'[{1}]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1454f, 46f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EDB RID: 16091 RVA: 0x001386FF File Offset: 0x001368FF
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EDC RID: 16092 RVA: 0x00138EDF File Offset: 0x001370DF
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EDD RID: 16093 RVA: 0x00138F16 File Offset: 0x00137116
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EDE RID: 16094 RVA: 0x001386FF File Offset: 0x001368FF
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EDF RID: 16095 RVA: 0x001386FF File Offset: 0x001368FF
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EE0 RID: 16096 RVA: 0x00138F4D File Offset: 0x0013714D
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EE2 RID: 16098 RVA: 0x001386FF File Offset: 0x001368FF
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EE3 RID: 16099 RVA: 0x00138F98 File Offset: 0x00137198
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1076f)
			{
				this.HBJJOCHGOPH = 1022f;
			}
			this.ADGHJOHKEHG().SetFloat(" (inactive)", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetVector("_FarCamera", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1844f, 765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EE4 RID: 16100 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06003EE5 RID: 16101 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003EE6 RID: 16102 RVA: 0x0013903F File Offset: 0x0013723F
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EE7 RID: 16103 RVA: 0x00139076 File Offset: 0x00137276
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EE8 RID: 16104 RVA: 0x001386FF File Offset: 0x001368FF
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040006C1 RID: 1729
	public Shader SCShader;

	// Token: 0x040006C2 RID: 1730
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006C3 RID: 1731
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006C4 RID: 1732
	private Material BJFKDHHMLJH;
}
