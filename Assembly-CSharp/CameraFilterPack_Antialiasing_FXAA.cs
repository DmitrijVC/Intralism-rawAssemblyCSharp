using System;
using UnityEngine;

// Token: 0x02000033 RID: 51
[AddComponentMenu("Camera Filter Pack/Antialiasing/FXAA")]
[ExecuteInEditMode]
public class CameraFilterPack_Antialiasing_FXAA : MonoBehaviour
{
	// Token: 0x06000CEF RID: 3311 RVA: 0x0005DA8A File Offset: 0x0005BC8A
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x0005DADE File Offset: 0x0005BCDE
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x0005DB18 File Offset: 0x0005BD18
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1358f)
			{
				this.HBJJOCHGOPH = 1504f;
			}
			this.OCHJIMJNEMO().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetVector("_EdgeSize", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x0005DBB8 File Offset: 0x0005BDB8
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x0005DBEF File Offset: 0x0005BDEF
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("restrictions\n\n#until: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x0005DC14 File Offset: 0x0005BE14
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1454f)
			{
				this.HBJJOCHGOPH = 983f;
			}
			this.KGOLDDBHIFN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetVector("GlassColor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x0005DCB4 File Offset: 0x0005BEB4
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x0005DCEB File Offset: 0x0005BEEB
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("Netw. Sim.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x0005DD0F File Offset: 0x0005BF0F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Antialiasing_FXAA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x0005DD33 File Offset: 0x0005BF33
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x0005DD6C File Offset: 0x0005BF6C
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 229f)
			{
				this.HBJJOCHGOPH = 404f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetVector("_BlurPass", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x0005DE0C File Offset: 0x0005C00C
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("closed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x0005DE30 File Offset: 0x0005C030
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1502f)
			{
				this.HBJJOCHGOPH = 732f;
			}
			this.NBPKMLMCHFN.SetFloat("Spawn new environment sprite (image) and sets its id", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetVector("_ReflectionTexture1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x0005DED0 File Offset: 0x0005C0D0
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x0005DF08 File Offset: 0x0005C108
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 643f)
			{
				this.HBJJOCHGOPH = 1291f;
			}
			this.OCHJIMJNEMO().SetFloat("Set sun min/max size", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetVector("{0} hours ago", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x0005DFA8 File Offset: 0x0005C1A8
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x0005DFDF File Offset: 0x0005C1DF
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x0005E004 File Offset: 0x0005C204
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1268f)
			{
				this.HBJJOCHGOPH = 1181f;
			}
			this.ADBKPGFMNKO().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetVector(".jpg", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0005E0A4 File Offset: 0x0005C2A4
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 133f)
			{
				this.HBJJOCHGOPH = 244f;
			}
			this.NBPKMLMCHFN.SetFloat("0,2,true,0", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetVector("z", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x0005E144 File Offset: 0x0005C344
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0005E1E4 File Offset: 0x0005C3E4
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

	// Token: 0x06000D10 RID: 3344 RVA: 0x0005E21C File Offset: 0x0005C41C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1022f)
			{
				this.HBJJOCHGOPH = 375f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Blend", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetVector("Preparing configuration", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x0005E2BC File Offset: 0x0005C4BC
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0005E2F3 File Offset: 0x0005C4F3
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0005E317 File Offset: 0x0005C517
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x0005E34E File Offset: 0x0005C54E
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0005E388 File Offset: 0x0005C588
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 285f)
			{
				this.HBJJOCHGOPH = 529f;
			}
			this.KGOLDDBHIFN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetVector("USE_DIAG_SEARCH", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x0005E428 File Offset: 0x0005C628
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("Mouse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x0005E44C File Offset: 0x0005C64C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1757f)
			{
				this.HBJJOCHGOPH = 922f;
			}
			this.DONENAMLFLF().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetVector("{", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x0005E4EC File Offset: 0x0005C6EC
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1387f)
			{
				this.HBJJOCHGOPH = 1176f;
			}
			this.HEINDEMCGIK().SetFloat("set environment id", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("CameraFilterPack/Vision_Warp2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x0005E58C File Offset: 0x0005C78C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1833f)
			{
				this.HBJJOCHGOPH = 764f;
			}
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetVector("maps.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x0005E62C File Offset: 0x0005C82C
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x0005E663 File Offset: 0x0005C863
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("_Gain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x0005E688 File Offset: 0x0005C888
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 368f)
			{
				this.HBJJOCHGOPH = 423f;
			}
			this.DONENAMLFLF().SetFloat("_Green_R", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetVector("Joystick1Button10", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x0005E728 File Offset: 0x0005C928
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 1001f;
			}
			this.IIBLJCKLGFG().SetFloat("settings.arcsdestroydelay", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetVector("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x0005E7C8 File Offset: 0x0005C9C8
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("SupportLogger OnJoinedRoom(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x0005E7EC File Offset: 0x0005C9EC
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("GlassAberration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x0005E810 File Offset: 0x0005CA10
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 988f)
			{
				this.HBJJOCHGOPH = 762f;
			}
			this.PDEAHJPOMEF().SetFloat("\\\"", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("CameraFilterPack/Color_Switching", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1243f)
			{
				this.HBJJOCHGOPH = 334f;
			}
			this.JLHLHKPHDFO().SetFloat("_DistortionSize", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetVector("settings.gamemessagesduration", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x0005E950 File Offset: 0x0005CB50
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x0005E987 File Offset: 0x0005CB87
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D3F RID: 3391 RVA: 0x0005E9C0 File Offset: 0x0005CBC0
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1811f)
			{
				this.HBJJOCHGOPH = 50f;
			}
			this.KGOLDDBHIFN().SetFloat("settings_bindings_", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("Set satellite radius (offset)", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x0005EA60 File Offset: 0x0005CC60
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1016f)
			{
				this.HBJJOCHGOPH = 800f;
			}
			this.DEFBJOCJJKF().SetFloat("ChangeSelectedLevel", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetVector("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x0005EB00 File Offset: 0x0005CD00
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 829f;
			}
			this.HHIFMIPPMPF().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_Bullet_6", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x0005EBA0 File Offset: 0x0005CDA0
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 925f)
			{
				this.HBJJOCHGOPH = 77f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetVector("\n\n#", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x0005EC40 File Offset: 0x0005CE40
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("NEW_ACHIEVEMENT_1_21");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x0005EC64 File Offset: 0x0005CE64
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x0005EC9B File Offset: 0x0005CE9B
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("Drop_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x0005DFA8 File Offset: 0x0005C1A8
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x0005ECBF File Offset: 0x0005CEBF
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x0005ECF6 File Offset: 0x0005CEF6
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("Uploading preview image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x0005ED1A File Offset: 0x0005CF1A
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x0005ED54 File Offset: 0x0005CF54
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1046f)
			{
				this.HBJJOCHGOPH = 1933f;
			}
			this.HHIFMIPPMPF().SetFloat("Alpha", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("Oct", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x0005DAC1 File Offset: 0x0005BCC1
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x0005EE08 File Offset: 0x0005D008
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 329f)
			{
				this.HBJJOCHGOPH = 349f;
			}
			this.OCHJIMJNEMO().SetFloat("In Main Menu", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetVector("mapselector.filter.rateduponly", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040001F2 RID: 498
	public Shader SCShader;

	// Token: 0x040001F3 RID: 499
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001F4 RID: 500
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001F5 RID: 501
	private Material BJFKDHHMLJH;
}
