using System;
using UnityEngine;

// Token: 0x02000095 RID: 149
[AddComponentMenu("Camera Filter Pack/Distortion/Water_Drop")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Water_Drop : MonoBehaviour
{
	// Token: 0x06002C74 RID: 11380 RVA: 0x000F0E60 File Offset: 0x000EF060
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 652f)
			{
				this.HBJJOCHGOPH = 1497f;
			}
			this.OKJOKHGJHGF().SetFloat(". Not connectedAndReady.", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetVector("MultiplayerButton", new Vector2((float)Screen.width, (float)Screen.height));
			this.IIJMIPBMMBF().SetFloat("Anomaly_Far", this.CenterX);
			this.OLHDPICFBOF().SetFloat("YES", this.CenterY);
			this.HKHBBBFLGJH().SetFloat("_Value4", this.WaveIntensity);
			this.EFDEIFCDAFG().SetInt("_MaxRadiusOrKInPaper", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x000F0F78 File Offset: 0x000EF178
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 792f)
			{
				this.HBJJOCHGOPH = 946f;
			}
			this.CEKJODEAMGB().SetFloat("/Segment-[Down]", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetVector("CameraFilterPack/3D_Computer", new Vector2((float)Screen.width, (float)Screen.height));
			this.OKJOKHGJHGF().SetFloat("<b>#", this.CenterX);
			this.HEHKGPKLAKK().SetFloat("Delete events", this.CenterY);
			this.GBFOAHKAJEK().SetFloat("HiddenToggle", this.WaveIntensity);
			this.HKHBBBFLGJH().SetInt("_TimeX", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C78 RID: 11384 RVA: 0x000F1070 File Offset: 0x000EF270
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C79 RID: 11385 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C7A RID: 11386 RVA: 0x000F1094 File Offset: 0x000EF294
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1773f)
			{
				this.HBJJOCHGOPH = 106f;
			}
			this.BLMPMOIDGMG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetVector("_Color", new Vector2((float)Screen.width, (float)Screen.height));
			this.JLHLHKPHDFO().SetFloat("[MapsData] User's maps was loaded", this.CenterX);
			this.MCDGIILBNIF().SetFloat("_Value7", this.CenterY);
			this.HHLFDHNEIAH().SetFloat("?", this.WaveIntensity);
			this.MMOODGIODPC().SetInt("\r", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C7B RID: 11387 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x000F118C File Offset: 0x000EF38C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 154f)
			{
				this.HBJJOCHGOPH = 1984f;
			}
			this.CIAFLBFJLEJ().SetFloat("[MenuScene] Error: ", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetVector("_Value7", new Vector2((float)Screen.width, (float)Screen.height));
			this.DBOLLHHMKKN().SetFloat("GlassColor", this.CenterX);
			this.MICHFGAOPKM().SetFloat("_TimeX", this.CenterY);
			this.KEMJNOMIPHN().SetFloat("SearchTex", this.WaveIntensity);
			this.PGPEMMBJOOG().SetInt("cipherText", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x000F1284 File Offset: 0x000EF484
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002C7F RID: 11391 RVA: 0x000F12BB File Offset: 0x000EF4BB
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C80 RID: 11392 RVA: 0x000F12DF File Offset: 0x000EF4DF
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("_ColorLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C81 RID: 11393 RVA: 0x000F1304 File Offset: 0x000EF504
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 382f)
			{
				this.HBJJOCHGOPH = 1744f;
			}
			this.HNICHJCGJOC().SetFloat("recipes", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			this.GKILCDHJFEG().SetFloat("/", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", this.CenterY);
			this.LNLKMDPHDCC().SetFloat("GroupNameText", this.WaveIntensity);
			this.ADGHJOHKEHG().SetInt("player.licenceaccepted", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C82 RID: 11394 RVA: 0x000F13FC File Offset: 0x000EF5FC
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find(" AuthMode ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C83 RID: 11395 RVA: 0x000F1420 File Offset: 0x000EF620
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C84 RID: 11396 RVA: 0x000F1457 File Offset: 0x000EF657
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("RT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C85 RID: 11397 RVA: 0x000F147C File Offset: 0x000EF67C
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 505f)
			{
				this.HBJJOCHGOPH = 1535f;
			}
			this.JIBOKBCPDLC().SetFloat("turn: {0:0}", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetVector("CameraFilterPack/Distortion_Dream", new Vector2((float)Screen.width, (float)Screen.height));
			this.NBPKMLMCHFN.SetFloat("Hidden/ScreenSpaceReflection", this.CenterX);
			this.HNICHJCGJOC().SetFloat("/", this.CenterY);
			this.GKILCDHJFEG().SetFloat("F3", this.WaveIntensity);
			this.EFDEIFCDAFG().SetInt("DifficultyBG", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C86 RID: 11398 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C87 RID: 11399 RVA: 0x000F1574 File Offset: 0x000EF774
	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 323f)
			{
				this.HBJJOCHGOPH = 1083f;
			}
			this.MMOODGIODPC().SetFloat("CameraFilterPack_TV_Vignetting1", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetVector(":", new Vector2((float)Screen.width, (float)Screen.height));
			this.GBFOAHKAJEK().SetFloat(" method: ", this.CenterX);
			this.OKJOKHGJHGF().SetFloat("PS Home", this.CenterY);
			this.PGPEMMBJOOG().SetFloat("You must complete your map before submiting it to Workshop", this.WaveIntensity);
			this.CFEDGDGBCHE().SetInt(":", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C88 RID: 11400 RVA: 0x000F166C File Offset: 0x000EF86C
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 953f)
			{
				this.HBJJOCHGOPH = 28f;
			}
			this.BLMPMOIDGMG().SetFloat("76561198041679481", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetVector("_Value", new Vector2((float)Screen.width, (float)Screen.height));
			this.HEHKGPKLAKK().SetFloat("{0:x2}", this.CenterX);
			this.PEIMCBBHLBJ().SetFloat("anonymous", this.CenterY);
			this.OLHDPICFBOF().SetFloat("^", this.WaveIntensity);
			this.CFEDGDGBCHE().SetInt("_NeutralTonemapperParams1", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x000F1764 File Offset: 0x000EF964
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x000F179B File Offset: 0x000EF99B
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("Prints list of all previous commands");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x000F17BF File Offset: 0x000EF9BF
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C90 RID: 11408 RVA: 0x000F17F8 File Offset: 0x000EF9F8
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
			this.NBPKMLMCHFN.SetFloat("_CenterX", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("_CenterY", this.CenterY);
			this.NBPKMLMCHFN.SetFloat("_WaveIntensity", this.WaveIntensity);
			this.NBPKMLMCHFN.SetInt("_NumberOfWaves", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x000F18F0 File Offset: 0x000EFAF0
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C92 RID: 11410 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x000F1928 File Offset: 0x000EFB28
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1323f)
			{
				this.HBJJOCHGOPH = 475f;
			}
			this.HKHBBBFLGJH().SetFloat("[", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_FlipAlphaMask", new Vector2((float)Screen.width, (float)Screen.height));
			this.DBOLLHHMKKN().SetFloat("{0:0.0} ms ({1:0.} fps)", this.CenterX);
			this.ADGHJOHKEHG().SetFloat("_Value3", this.CenterY);
			this.OKJOKHGJHGF().SetFloat("_TileMaxLoop", this.WaveIntensity);
			this.NBPKMLMCHFN.SetInt("[Left]", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x000F1A20 File Offset: 0x000EFC20
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("No info");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x000F1A44 File Offset: 0x000EFC44
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("SetParticlesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C96 RID: 11414 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x000F1A68 File Offset: 0x000EFC68
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1350f)
			{
				this.HBJJOCHGOPH = 307f;
			}
			this.NFKFAAHHLLM().SetFloat("curScn", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetVector("RanksButton", new Vector2((float)Screen.width, (float)Screen.height));
			this.NMDBCDFPGOK().SetFloat("_VignetteColor", this.CenterX);
			this.HNICHJCGJOC().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", this.CenterY);
			this.FGENHBKMPDA().SetFloat("USE_PREDICATION", this.WaveIntensity);
			this.CEKJODEAMGB().SetInt("KickThePlayer", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C98 RID: 11416 RVA: 0x000F1B60 File Offset: 0x000EFD60
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C99 RID: 11417 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x000F1B84 File Offset: 0x000EFD84
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x000F1BA8 File Offset: 0x000EFDA8
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 526f)
			{
				this.HBJJOCHGOPH = 150f;
			}
			this.NFKFAAHHLLM().SetFloat("EventMenu", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetVector("[#clicktogetreward]", new Vector2((float)Screen.width, (float)Screen.height));
			this.MICHFGAOPKM().SetFloat("Operation failed: ", this.CenterX);
			this.MCDGIILBNIF().SetFloat("[EditorEvent] Exception: ", this.CenterY);
			this.EFDEIFCDAFG().SetFloat("_UserLutTex", this.WaveIntensity);
			this.BLMPMOIDGMG().SetInt(" or player:", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C9D RID: 11421 RVA: 0x000F1CA0 File Offset: 0x000EFEA0
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C9E RID: 11422 RVA: 0x000F1CD7 File Offset: 0x000EFED7
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C9F RID: 11423 RVA: 0x000F1CFB File Offset: 0x000EFEFB
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CA0 RID: 11424 RVA: 0x000F1D20 File Offset: 0x000EFF20
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 267f)
			{
				this.HBJJOCHGOPH = 1817f;
			}
			this.EFDEIFCDAFG().SetFloat("VoteDownToggle", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetVector("LevelConfigButton", new Vector2((float)Screen.width, (float)Screen.height));
			this.MCDGIILBNIF().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this.CenterX);
			this.HNICHJCGJOC().SetFloat(":", this.CenterY);
			this.CFEDGDGBCHE().SetFloat("y", this.WaveIntensity);
			this.HHLFDHNEIAH().SetInt("MenuScene", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x000F1E18 File Offset: 0x000F0018
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("MenuPlayButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x000F1E3C File Offset: 0x000F003C
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 372f)
			{
				this.HBJJOCHGOPH = 395f;
			}
			this.PEIMCBBHLBJ().SetFloat("Vertical", this.HBJJOCHGOPH);
			this.PEIMCBBHLBJ().SetVector("x", new Vector2((float)Screen.width, (float)Screen.height));
			this.EFDEIFCDAFG().SetFloat("SetSunLerpSpeed", this.CenterX);
			this.BLMPMOIDGMG().SetFloat("PopulateMapsList", this.CenterY);
			this.CFEDGDGBCHE().SetFloat("OnRelease", this.WaveIntensity);
			this.KEMJNOMIPHN().SetInt(" - ", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x000F1F34 File Offset: 0x000F0134
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CA5 RID: 11429 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06002CA6 RID: 11430 RVA: 0x000F1F6B File Offset: 0x000F016B
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CA7 RID: 11431 RVA: 0x000F1FA2 File Offset: 0x000F01A2
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CA8 RID: 11432 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06002CA9 RID: 11433 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002CAA RID: 11434 RVA: 0x000F1FDC File Offset: 0x000F01DC
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1794f)
			{
				this.HBJJOCHGOPH = 992f;
			}
			this.BLMPMOIDGMG().SetFloat("Joystick1Button10", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetVector("[MapsEditor] Creating new item...", new Vector2((float)Screen.width, (float)Screen.height));
			this.NFKFAAHHLLM().SetFloat("shader.future", this.CenterX);
			this.OLHDPICFBOF().SetFloat("masterSteamID", this.CenterY);
			this.BLMPMOIDGMG().SetFloat("tip", this.WaveIntensity);
			this.LNLKMDPHDCC().SetInt("_Value2", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CAB RID: 11435 RVA: 0x000F20D4 File Offset: 0x000F02D4
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CAC RID: 11436 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CAD RID: 11437 RVA: 0x000F210B File Offset: 0x000F030B
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06002CAF RID: 11439 RVA: 0x000F2144 File Offset: 0x000F0344
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1900f)
			{
				this.HBJJOCHGOPH = 1001f;
			}
			this.HNICHJCGJOC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetVector("_BlurVector", new Vector2((float)Screen.width, (float)Screen.height));
			this.CEKJODEAMGB().SetFloat("_VignetteSettings", this.CenterX);
			this.CFEDGDGBCHE().SetFloat("ViewMenu", this.CenterY);
			this.OGMEGHKECAH().SetFloat("_FarCamera", this.WaveIntensity);
			this.MCDGIILBNIF().SetInt("_SSAO", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CB0 RID: 11440 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06002CB1 RID: 11441 RVA: 0x000F223C File Offset: 0x000F043C
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CB2 RID: 11442 RVA: 0x000F18F0 File Offset: 0x000EFAF0
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CB3 RID: 11443 RVA: 0x000F2273 File Offset: 0x000F0473
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("SelectorMusicToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CB4 RID: 11444 RVA: 0x000F2298 File Offset: 0x000F0498
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 580f)
			{
				this.HBJJOCHGOPH = 246f;
			}
			this.PGPEMMBJOOG().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetVector("_Offsets", new Vector2((float)Screen.width, (float)Screen.height));
			this.CFEDGDGBCHE().SetFloat("BitsData", this.CenterX);
			this.HEHKGPKLAKK().SetFloat("_MaxSteps", this.CenterY);
			this.NFKFAAHHLLM().SetFloat("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", this.WaveIntensity);
			this.OLHDPICFBOF().SetInt("AddEnvironmentObject", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CB5 RID: 11445 RVA: 0x000F2390 File Offset: 0x000F0590
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CB6 RID: 11446 RVA: 0x000F23B4 File Offset: 0x000F05B4
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CB7 RID: 11447 RVA: 0x000F23EC File Offset: 0x000F05EC
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1236f)
			{
				this.HBJJOCHGOPH = 807f;
			}
			this.NFKFAAHHLLM().SetFloat("SetPlayerDistance", this.HBJJOCHGOPH);
			this.PEIMCBBHLBJ().SetVector("/icon", new Vector2((float)Screen.width, (float)Screen.height));
			this.MCDGIILBNIF().SetFloat("float,2", this.CenterX);
			this.MICHFGAOPKM().SetFloat("PopulateMapsList", this.CenterY);
			this.NBPKMLMCHFN.SetFloat("RecieveChatMessage", this.WaveIntensity);
			this.JIBOKBCPDLC().SetInt("_AccumOrig", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CB8 RID: 11448 RVA: 0x000F24E4 File Offset: 0x000F06E4
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("settings.fps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x000F2508 File Offset: 0x000F0708
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06002CBB RID: 11451 RVA: 0x000F253F File Offset: 0x000F073F
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CBC RID: 11452 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CBE RID: 11454 RVA: 0x000F2576 File Offset: 0x000F0776
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CBF RID: 11455 RVA: 0x000F25AD File Offset: 0x000F07AD
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CC0 RID: 11456 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06002CC2 RID: 11458 RVA: 0x000F25D1 File Offset: 0x000F07D1
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("Texture3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CC3 RID: 11459 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CC4 RID: 11460 RVA: 0x000F25F5 File Offset: 0x000F07F5
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000F262C File Offset: 0x000F082C
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

	// Token: 0x06002CC6 RID: 11462 RVA: 0x000F2663 File Offset: 0x000F0863
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x000F269A File Offset: 0x000F089A
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x000F26D4 File Offset: 0x000F08D4
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 493f)
			{
				this.HBJJOCHGOPH = 461f;
			}
			this.HEHKGPKLAKK().SetFloat("BadgeText", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetVector("_Distortion", new Vector2((float)Screen.width, (float)Screen.height));
			this.EFDEIFCDAFG().SetFloat("Offline", this.CenterX);
			this.ADGHJOHKEHG().SetFloat("_Value3", this.CenterY);
			this.MICHFGAOPKM().SetFloat("0.00", this.WaveIntensity);
			this.HNICHJCGJOC().SetInt("Tab2Content", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CC9 RID: 11465 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CCA RID: 11466 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x06002CCB RID: 11467 RVA: 0x000F27CC File Offset: 0x000F09CC
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CCC RID: 11468 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CCD RID: 11469 RVA: 0x000F2803 File Offset: 0x000F0A03
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CCE RID: 11470 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CCF RID: 11471 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06002CD0 RID: 11472 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CD1 RID: 11473 RVA: 0x000F2827 File Offset: 0x000F0A27
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CD2 RID: 11474 RVA: 0x000F2860 File Offset: 0x000F0A60
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 280f)
			{
				this.HBJJOCHGOPH = 193f;
			}
			this.LEIAFCPJMDP().SetFloat("22x3", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetVector("_Value2", new Vector2((float)Screen.width, (float)Screen.height));
			this.HNICHJCGJOC().SetFloat("shader.ghost", this.CenterX);
			this.JLHLHKPHDFO().SetFloat("maps.", this.CenterY);
			this.IIJMIPBMMBF().SetFloat("_HitPointTexture", this.WaveIntensity);
			this.BLMPMOIDGMG().SetInt("Set Object Rotation", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CD3 RID: 11475 RVA: 0x000F2958 File Offset: 0x000F0B58
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(".icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CD4 RID: 11476 RVA: 0x000F297C File Offset: 0x000F0B7C
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("Player");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CD5 RID: 11477 RVA: 0x000F29A0 File Offset: 0x000F0BA0
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("Jun");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CD6 RID: 11478 RVA: 0x000F29C4 File Offset: 0x000F0BC4
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_SizeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CD7 RID: 11479 RVA: 0x000F29E8 File Offset: 0x000F0BE8
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1136f)
			{
				this.HBJJOCHGOPH = 465f;
			}
			this.HNICHJCGJOC().SetFloat("_TileMaxOffs", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetVector("_Value3", new Vector2((float)Screen.width, (float)Screen.height));
			this.KEMJNOMIPHN().SetFloat("_ReflectionTexture1", this.CenterX);
			this.KEMJNOMIPHN().SetFloat("_TimeX", this.CenterY);
			this.OKJOKHGJHGF().SetFloat("id", this.WaveIntensity);
			this.FGENHBKMPDA().SetInt("_", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CD8 RID: 11480 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06002CD9 RID: 11481 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CDA RID: 11482 RVA: 0x000F2AE0 File Offset: 0x000F0CE0
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Water_Drop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CDB RID: 11483 RVA: 0x000F2B04 File Offset: 0x000F0D04
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CDC RID: 11484 RVA: 0x0002523B File Offset: 0x0002343B
	private void DEEPMOLMGED()
	{
	}

	// Token: 0x06002CDD RID: 11485 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06002CDF RID: 11487 RVA: 0x000F269A File Offset: 0x000F089A
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CE0 RID: 11488 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CE1 RID: 11489 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06002CE2 RID: 11490 RVA: 0x000F2B4D File Offset: 0x000F0D4D
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CE3 RID: 11491 RVA: 0x000F2B84 File Offset: 0x000F0D84
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CE4 RID: 11492 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06002CE5 RID: 11493 RVA: 0x000F2BA8 File Offset: 0x000F0DA8
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CE6 RID: 11494 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void HCDBNAKGDJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CE7 RID: 11495 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void ABHEJPAGNMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CE8 RID: 11496 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CE9 RID: 11497 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06002CEA RID: 11498 RVA: 0x000F2BCC File Offset: 0x000F0DCC
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CEB RID: 11499 RVA: 0x000F2C03 File Offset: 0x000F0E03
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CEC RID: 11500 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06002CED RID: 11501 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06002CEE RID: 11502 RVA: 0x000F2C3A File Offset: 0x000F0E3A
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CEF RID: 11503 RVA: 0x000F2C5E File Offset: 0x000F0E5E
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CF0 RID: 11504 RVA: 0x000F2C95 File Offset: 0x000F0E95
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("[MapsData] Key ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CF1 RID: 11505 RVA: 0x000F2CB9 File Offset: 0x000F0EB9
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find(". Our prefix is ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002CF2 RID: 11506 RVA: 0x000F2CDD File Offset: 0x000F0EDD
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("ConfigVersionSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002CF3 RID: 11507 RVA: 0x000F2D04 File Offset: 0x000F0F04
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1601f)
			{
				this.HBJJOCHGOPH = 289f;
			}
			this.GBFOAHKAJEK().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetVector("_FixDistance", new Vector2((float)Screen.width, (float)Screen.height));
			this.DBOLLHHMKKN().SetFloat("_Radius", this.CenterX);
			this.BLMPMOIDGMG().SetFloat("Tab2Content", this.CenterY);
			this.BLMPMOIDGMG().SetFloat("_TimeX", this.WaveIntensity);
			this.CEKJODEAMGB().SetInt("SetSunMinSize", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CF4 RID: 11508 RVA: 0x000F2DFC File Offset: 0x000F0FFC
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 725f)
			{
				this.HBJJOCHGOPH = 909f;
			}
			this.PGPEMMBJOOG().SetFloat("bad", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetVector("LoadMapCanvas", new Vector2((float)Screen.width, (float)Screen.height));
			this.CIAFLBFJLEJ().SetFloat("(master)", this.CenterX);
			this.PGPEMMBJOOG().SetFloat(" elements", this.CenterY);
			this.EFDEIFCDAFG().SetFloat("[NetworkManager] Connected to ", this.WaveIntensity);
			this.MICHFGAOPKM().SetInt(". Using max value: 255.", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CF5 RID: 11509 RVA: 0x000F2EF4 File Offset: 0x000F10F4
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CF6 RID: 11510 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06002CF7 RID: 11511 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06002CF8 RID: 11512 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06002CF9 RID: 11513 RVA: 0x000F2F2B File Offset: 0x000F112B
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CFA RID: 11514 RVA: 0x000F2F62 File Offset: 0x000F1162
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CFB RID: 11515 RVA: 0x000F0F58 File Offset: 0x000EF158
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002CFC RID: 11516 RVA: 0x000F2F99 File Offset: 0x000F1199
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CFD RID: 11517 RVA: 0x000F253F File Offset: 0x000F073F
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002CFE RID: 11518 RVA: 0x000F2FD0 File Offset: 0x000F11D0
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1998f)
			{
				this.HBJJOCHGOPH = 1013f;
			}
			this.DBOLLHHMKKN().SetFloat("Turn", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetVector("_EmissionColor", new Vector2((float)Screen.width, (float)Screen.height));
			this.MCDGIILBNIF().SetFloat(".workshop.json", this.CenterX);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this.CenterY);
			this.LEIAFCPJMDP().SetFloat("CameraFilterPack/Lut_TestMode", this.WaveIntensity);
			this.MCDGIILBNIF().SetInt("_ScreenResolution", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002CFF RID: 11519 RVA: 0x000F30C8 File Offset: 0x000F12C8
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 540f)
			{
				this.HBJJOCHGOPH = 971f;
			}
			this.NFKFAAHHLLM().SetFloat("Change Note:", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			this.LPDOGGFOBDH().SetFloat("ConfigVersionSlider", this.CenterX);
			this.CFEDGDGBCHE().SetFloat("settings.enablerankingnotifications", this.CenterY);
			this.LNLKMDPHDCC().SetFloat("_DistortionSize", this.WaveIntensity);
			this.EFDEIFCDAFG().SetInt("Left", this.NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000537 RID: 1335
	public Shader SCShader;

	// Token: 0x04000538 RID: 1336
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000539 RID: 1337
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400053A RID: 1338
	private Material BJFKDHHMLJH;

	// Token: 0x0400053B RID: 1339
	[Range(-1f, 1f)]
	public float CenterX;

	// Token: 0x0400053C RID: 1340
	[Range(-1f, 1f)]
	public float CenterY;

	// Token: 0x0400053D RID: 1341
	[Range(0f, 10f)]
	public float WaveIntensity = 1f;

	// Token: 0x0400053E RID: 1342
	[Range(0f, 20f)]
	public int NumberOfWaves = 5;
}
