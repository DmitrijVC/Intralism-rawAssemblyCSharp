using System;
using UnityEngine;

// Token: 0x02000096 RID: 150
[AddComponentMenu("Camera Filter Pack/Distortion/Wave_Horizontal")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Wave_Horizontal : MonoBehaviour
{
	// Token: 0x06002D00 RID: 11520 RVA: 0x000F31C0 File Offset: 0x000F13C0
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D01 RID: 11521 RVA: 0x000F31F8 File Offset: 0x000F13F8
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1600f)
			{
				this.HBJJOCHGOPH = 277f;
			}
			this.KBOPGONOCNP().SetFloat("SpawnObj", this.WaveIntensity);
			this.NBPKMLMCHFN.SetFloat("_InvScreenSize", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D02 RID: 11522 RVA: 0x000F32AE File Offset: 0x000F14AE
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D03 RID: 11523 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06002D04 RID: 11524 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002D05 RID: 11525 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002D07 RID: 11527 RVA: 0x000F3303 File Offset: 0x000F1503
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D08 RID: 11528 RVA: 0x000F333A File Offset: 0x000F153A
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("settings.enableranking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D09 RID: 11529 RVA: 0x000F335E File Offset: 0x000F155E
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D0A RID: 11530 RVA: 0x000F337B File Offset: 0x000F157B
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D0B RID: 11531 RVA: 0x000F33B4 File Offset: 0x000F15B4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1292f)
			{
				this.HBJJOCHGOPH = 1294f;
			}
			this.GCDFNHMJMIP().SetFloat("_Blue_B", this.WaveIntensity);
			this.CFEDGDGBCHE().SetFloat("players", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetVector("CameraFilterPack_Glasses_On2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D0C RID: 11532 RVA: 0x000F346A File Offset: 0x000F166A
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D0D RID: 11533 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06002D0E RID: 11534 RVA: 0x000F335E File Offset: 0x000F155E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D0F RID: 11535 RVA: 0x000F335E File Offset: 0x000F155E
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D10 RID: 11536 RVA: 0x000F34A4 File Offset: 0x000F16A4
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1789f)
			{
				this.HBJJOCHGOPH = 86f;
			}
			this.CFEDGDGBCHE().SetFloat("_Distortion", this.WaveIntensity);
			this.OIMMPLPBLBK().SetFloat("id", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetVector("s", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D11 RID: 11537 RVA: 0x000F355A File Offset: 0x000F175A
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D12 RID: 11538 RVA: 0x000F357E File Offset: 0x000F177E
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("[FileSelector] Dialog canceled");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D13 RID: 11539 RVA: 0x000F35A2 File Offset: 0x000F17A2
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D14 RID: 11540 RVA: 0x000F335E File Offset: 0x000F155E
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D15 RID: 11541 RVA: 0x000F335E File Offset: 0x000F155E
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D16 RID: 11542 RVA: 0x000F35D9 File Offset: 0x000F17D9
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000F3610 File Offset: 0x000F1810
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

	// Token: 0x06002D18 RID: 11544 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06002D19 RID: 11545 RVA: 0x000F3647 File Offset: 0x000F1847
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D1A RID: 11546 RVA: 0x000F335E File Offset: 0x000F155E
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D1B RID: 11547 RVA: 0x000F335E File Offset: 0x000F155E
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D1C RID: 11548 RVA: 0x000F3680 File Offset: 0x000F1880
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_WaveIntensity", this.WaveIntensity);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D1D RID: 11549 RVA: 0x000F3738 File Offset: 0x000F1938
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 103f)
			{
				this.HBJJOCHGOPH = 94f;
			}
			this.KAFBNOBOIAJ().SetFloat("SetParticlesEmission", this.WaveIntensity);
			this.KAFBNOBOIAJ().SetFloat("Error: I/O Failure", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetVector(".save", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D1E RID: 11550 RVA: 0x000F335E File Offset: 0x000F155E
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D1F RID: 11551 RVA: 0x000F37EE File Offset: 0x000F19EE
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("LevelURLInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D20 RID: 11552 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06002D21 RID: 11553 RVA: 0x000F3812 File Offset: 0x000F1A12
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D22 RID: 11554 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002D23 RID: 11555 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06002D24 RID: 11556 RVA: 0x000F384C File Offset: 0x000F1A4C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 1599f;
			}
			this.CFEDGDGBCHE().SetFloat("skin.no_hit", this.WaveIntensity);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Gradients_Stripe", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("\n", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D25 RID: 11557 RVA: 0x000F3902 File Offset: 0x000F1B02
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Wave_Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D26 RID: 11558 RVA: 0x000F3928 File Offset: 0x000F1B28
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 442f)
			{
				this.HBJJOCHGOPH = 538f;
			}
			this.GCDFNHMJMIP().SetFloat("CameraMovementSlider", this.WaveIntensity);
			this.ADBKPGFMNKO().SetFloat("Drop_Near", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("rarity", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D27 RID: 11559 RVA: 0x000F39E0 File Offset: 0x000F1BE0
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1613f)
			{
				this.HBJJOCHGOPH = 1045f;
			}
			this.CFEDGDGBCHE().SetFloat("settings_bindings_controller_type", this.WaveIntensity);
			this.NBPKMLMCHFN.SetFloat("Netw. Sim.", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetVector("maps.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D28 RID: 11560 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06002D29 RID: 11561 RVA: 0x000F3A96 File Offset: 0x000F1C96
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D2A RID: 11562 RVA: 0x000F3AD0 File Offset: 0x000F1CD0
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 525f)
			{
				this.HBJJOCHGOPH = 1458f;
			}
			this.KAFBNOBOIAJ().SetFloat("cancel", this.WaveIntensity);
			this.GCDFNHMJMIP().SetFloat("PUN-instantiated '", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetVector("_SecondTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D2B RID: 11563 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06002D2C RID: 11564 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0400053F RID: 1343
	public Shader SCShader;

	// Token: 0x04000540 RID: 1344
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000541 RID: 1345
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000542 RID: 1346
	private Material BJFKDHHMLJH;

	// Token: 0x04000543 RID: 1347
	[Range(1f, 100f)]
	public float WaveIntensity = 32f;
}
