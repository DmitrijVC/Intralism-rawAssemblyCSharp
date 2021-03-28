using System;
using UnityEngine;

// Token: 0x020000BA RID: 186
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Film/ColorPerfection")]
public class CameraFilterPack_Film_ColorPerfection : MonoBehaviour
{
	// Token: 0x06003897 RID: 14487 RVA: 0x0011F644 File Offset: 0x0011D844
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_Vignette_Alpha");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003898 RID: 14488 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06003899 RID: 14489 RVA: 0x0011F668 File Offset: 0x0011D868
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600389A RID: 14490 RVA: 0x0011F68C File Offset: 0x0011D88C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1413f)
			{
				this.HBJJOCHGOPH = 1819f;
			}
			this.EMDFHOKEGNG().SetFloat("Cant ask anyone else for PickupItem spawn times.", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_PositionY", this.Gamma);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Drawing_CellShading2", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("[DiscordController] Init", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("masterSteamID", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("[NetworkManager] Exited", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1286f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600389B RID: 14491 RVA: 0x0011F78B File Offset: 0x0011D98B
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Cause: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600389C RID: 14492 RVA: 0x0011F7AF File Offset: 0x0011D9AF
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_MatrixSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600389D RID: 14493 RVA: 0x0011F7D3 File Offset: 0x0011D9D3
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("SpectatingUserInfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600389E RID: 14494 RVA: 0x0011F7F7 File Offset: 0x0011D9F7
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600389F RID: 14495 RVA: 0x0011F81B File Offset: 0x0011DA1B
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038A0 RID: 14496 RVA: 0x0011F854 File Offset: 0x0011DA54
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1523f)
			{
				this.HBJJOCHGOPH = 275f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value1", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Gamma);
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Vision_Plasma", this.EOKMJCIDCDB);
			this.EMDFHOKEGNG().SetFloat("SetParticlesGravity", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("player.xp", this.CCIENBFIKKH);
			this.JFDGLLEOPGB().SetVector("Is it practically possible?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 532f, 1667f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038A1 RID: 14497 RVA: 0x0011F953 File Offset: 0x0011DB53
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038A3 RID: 14499 RVA: 0x0011F9CC File Offset: 0x0011DBCC
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 204f)
			{
				this.HBJJOCHGOPH = 1917f;
			}
			this.FEAEGGCNIAA().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("\0\0", this.Gamma);
			this.NBPKMLMCHFN.SetFloat("curScn", this.EOKMJCIDCDB);
			this.EPCGJFCCAFH().SetFloat("_Level", this.ILHJFHFPGBB);
			this.EPCGJFCCAFH().SetFloat("_MidGrey", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("Coroutine container not configured... did you forget to call Init?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1840f, 1875f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038A4 RID: 14500 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060038A5 RID: 14501 RVA: 0x0011FACC File Offset: 0x0011DCCC
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1215f)
			{
				this.HBJJOCHGOPH = 1693f;
			}
			this.FEAEGGCNIAA().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("useSrcAlphaAsMask", this.Gamma);
			this.KBOPGONOCNP().SetFloat("1177138211", this.EOKMJCIDCDB);
			this.KBOPGONOCNP().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.ILHJFHFPGBB);
			this.FEAEGGCNIAA().SetFloat("caret", this.CCIENBFIKKH);
			this.HCGJCMDJPGD().SetVector("CameraFilterPack/Gradients_Hue", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 126f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038A6 RID: 14502 RVA: 0x0011FBCC File Offset: 0x0011DDCC
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1277f)
			{
				this.HBJJOCHGOPH = 1184f;
			}
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_TimeX", this.Gamma);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Gradients_Rainbow", this.EOKMJCIDCDB);
			this.FEAEGGCNIAA().SetFloat("SetScale", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.EPCGJFCCAFH().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1102f, 375f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038A7 RID: 14503 RVA: 0x0011FCCC File Offset: 0x0011DECC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Gamma);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038A8 RID: 14504 RVA: 0x0011FDCB File Offset: 0x0011DFCB
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038A9 RID: 14505 RVA: 0x0011FDE8 File Offset: 0x0011DFE8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1387f)
			{
				this.HBJJOCHGOPH = 1381f;
			}
			this.HCGJCMDJPGD().SetFloat("Game Version: ", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("0", this.Gamma);
			this.EMDFHOKEGNG().SetFloat("maps.", this.EOKMJCIDCDB);
			this.EMDFHOKEGNG().SetFloat("_History2Weight", this.ILHJFHFPGBB);
			this.EMDFHOKEGNG().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1056f, 613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038AA RID: 14506 RVA: 0x0011FEE8 File Offset: 0x0011E0E8
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1149f)
			{
				this.HBJJOCHGOPH = 508f;
			}
			this.EMDFHOKEGNG().SetFloat("Items", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("float,0", this.Gamma);
			this.KBOPGONOCNP().SetFloat("_Value2", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ILHJFHFPGBB);
			this.EMDFHOKEGNG().SetFloat("offsets", this.CCIENBFIKKH);
			this.FEAEGGCNIAA().SetVector(".b", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 91f, 370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038AB RID: 14507 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060038AC RID: 14508 RVA: 0x0011FFE7 File Offset: 0x0011E1E7
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("-");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038AD RID: 14509 RVA: 0x0011FDCB File Offset: 0x0011DFCB
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038AE RID: 14510 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060038AF RID: 14511 RVA: 0x0012000B File Offset: 0x0011E20B
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038B0 RID: 14512 RVA: 0x00120044 File Offset: 0x0011E244
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 681f)
			{
				this.HBJJOCHGOPH = 1448f;
			}
			this.EMDFHOKEGNG().SetFloat("ChangeSelectedLevel", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_MainTex2", this.Gamma);
			this.FEAEGGCNIAA().SetFloat("_Value4", this.EOKMJCIDCDB);
			this.LONNIJMNKFB().SetFloat("Tab1Content", this.ILHJFHFPGBB);
			this.EMDFHOKEGNG().SetFloat("-", this.CCIENBFIKKH);
			this.LONNIJMNKFB().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 143f, 1993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038B1 RID: 14513 RVA: 0x00120143 File Offset: 0x0011E343
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038B2 RID: 14514 RVA: 0x0011FDCB File Offset: 0x0011DFCB
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038B3 RID: 14515 RVA: 0x0011FDCB File Offset: 0x0011DFCB
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038B4 RID: 14516 RVA: 0x0012017A File Offset: 0x0011E37A
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("NewMusicFileSelector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038B5 RID: 14517 RVA: 0x001201A0 File Offset: 0x0011E3A0
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 436f)
			{
				this.HBJJOCHGOPH = 1028f;
			}
			this.KBOPGONOCNP().SetFloat("#challengecomplete", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Added GameObject to prefabDictionary: ", this.Gamma);
			this.JFDGLLEOPGB().SetFloat("_Value1", this.EOKMJCIDCDB);
			this.LONNIJMNKFB().SetFloat("maps.", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("https://twitch.tv/intralism", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("Bad parameters for getbool! Use <key> <value>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1894f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038B6 RID: 14518 RVA: 0x0012029F File Offset: 0x0011E49F
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038B7 RID: 14519 RVA: 0x001202C3 File Offset: 0x0011E4C3
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("isVisible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038B8 RID: 14520 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060038B9 RID: 14521 RVA: 0x001202E7 File Offset: 0x0011E4E7
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Film_ColorPerfection");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038BA RID: 14522 RVA: 0x0011FDCB File Offset: 0x0011DFCB
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038BB RID: 14523 RVA: 0x0012030B File Offset: 0x0011E50B
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("NewMapHandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038BC RID: 14524 RVA: 0x00120330 File Offset: 0x0011E530
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 515f)
			{
				this.HBJJOCHGOPH = 1142f;
			}
			this.KBOPGONOCNP().SetFloat("_Fade", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat(" with prefix ", this.Gamma);
			this.KBOPGONOCNP().SetFloat("MenuScene", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.HCGJCMDJPGD().SetFloat("NameInfoText", this.CCIENBFIKKH);
			this.JFDGLLEOPGB().SetVector("--------------------------------", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 402f, 710f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038BD RID: 14525 RVA: 0x0012042F File Offset: 0x0011E62F
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("\" that takes ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038BE RID: 14526 RVA: 0x00120454 File Offset: 0x0011E654
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 555f)
			{
				this.HBJJOCHGOPH = 1803f;
			}
			this.KBOPGONOCNP().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("Gameplay/Base", this.Gamma);
			this.EMDFHOKEGNG().SetFloat("_Vignetting2", this.EOKMJCIDCDB);
			this.JFDGLLEOPGB().SetFloat("_BorderColor", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("_Value3", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 303f, 1934f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038BF RID: 14527 RVA: 0x00120553 File Offset: 0x0011E753
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038C0 RID: 14528 RVA: 0x0012058C File Offset: 0x0011E78C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1286f)
			{
				this.HBJJOCHGOPH = 879f;
			}
			this.FEAEGGCNIAA().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("CheckpointsScoreText", this.Gamma);
			this.EPCGJFCCAFH().SetFloat("z", this.EOKMJCIDCDB);
			this.LONNIJMNKFB().SetFloat("#ok", this.ILHJFHFPGBB);
			this.EPCGJFCCAFH().SetFloat("finished", this.CCIENBFIKKH);
			this.JFDGLLEOPGB().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1594f, 1822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038C1 RID: 14529 RVA: 0x0011FDCB File Offset: 0x0011DFCB
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038C2 RID: 14530 RVA: 0x0012068C File Offset: 0x0011E88C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1744f)
			{
				this.HBJJOCHGOPH = 771f;
			}
			this.JFDGLLEOPGB().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_Offsets", this.Gamma);
			this.NBPKMLMCHFN.SetFloat("<color=white>", this.EOKMJCIDCDB);
			this.LONNIJMNKFB().SetFloat("float,1", this.ILHJFHFPGBB);
			this.EMDFHOKEGNG().SetFloat("The given 2D texture ", this.CCIENBFIKKH);
			this.HCGJCMDJPGD().SetVector(".completedCount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1076f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038C3 RID: 14531 RVA: 0x0012078C File Offset: 0x0011E98C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1509f)
			{
				this.HBJJOCHGOPH = 986f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value3", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Clear Environment", this.Gamma);
			this.EPCGJFCCAFH().SetFloat("/icon", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("#done", this.ILHJFHFPGBB);
			this.LONNIJMNKFB().SetFloat("[Up]", this.CCIENBFIKKH);
			this.FEAEGGCNIAA().SetVector("BadgeText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 988f, 628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038C4 RID: 14532 RVA: 0x0012088C File Offset: 0x0011EA8C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 168f)
			{
				this.HBJJOCHGOPH = 498f;
			}
			this.EMDFHOKEGNG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_Amount", this.Gamma);
			this.KBOPGONOCNP().SetFloat("SpawnObj", this.EOKMJCIDCDB);
			this.HCGJCMDJPGD().SetFloat("skin.", this.ILHJFHFPGBB);
			this.HCGJCMDJPGD().SetFloat("/", this.CCIENBFIKKH);
			this.LONNIJMNKFB().SetVector("CameraFilterPack/Edge_Sigmoid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 638f, 837f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038C5 RID: 14533 RVA: 0x0012098C File Offset: 0x0011EB8C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 69f)
			{
				this.HBJJOCHGOPH = 554f;
			}
			this.JFDGLLEOPGB().SetFloat("menutheme.hunter", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this.Gamma);
			this.JFDGLLEOPGB().SetFloat("_Value2", this.EOKMJCIDCDB);
			this.EMDFHOKEGNG().SetFloat("{0} years ago", this.ILHJFHFPGBB);
			this.HCGJCMDJPGD().SetFloat(".lastCheckpoint.lives", this.CCIENBFIKKH);
			this.HCGJCMDJPGD().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 623f, 522f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x060038C6 RID: 14534 RVA: 0x00120A8B File Offset: 0x0011EC8B
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

	// Token: 0x060038C7 RID: 14535 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060038C8 RID: 14536 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060038C9 RID: 14537 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060038CA RID: 14538 RVA: 0x00120AC2 File Offset: 0x0011ECC2
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x00120AF9 File Offset: 0x0011ECF9
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("Players NetIDs:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038CC RID: 14540 RVA: 0x00120B1D File Offset: 0x0011ED1D
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038CD RID: 14541 RVA: 0x00120B44 File Offset: 0x0011ED44
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 772f)
			{
				this.HBJJOCHGOPH = 530f;
			}
			this.KBOPGONOCNP().SetFloat("_Value1", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Lerp speed. Recomended 10", this.Gamma);
			this.EMDFHOKEGNG().SetFloat("_Speed", this.EOKMJCIDCDB);
			this.HCGJCMDJPGD().SetFloat("Set sun lerp speed", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("menu.enableselectormusic", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1089f, 1525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038CE RID: 14542 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x060038CF RID: 14543 RVA: 0x00120C43 File Offset: 0x0011EE43
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000633 RID: 1587
	public Shader SCShader;

	// Token: 0x04000634 RID: 1588
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000635 RID: 1589
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000636 RID: 1590
	private Material BJFKDHHMLJH;

	// Token: 0x04000637 RID: 1591
	[Range(0f, 4f)]
	public float Gamma = 0.55f;

	// Token: 0x04000638 RID: 1592
	[Range(0f, 10f)]
	private float EOKMJCIDCDB = 1f;

	// Token: 0x04000639 RID: 1593
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x0400063A RID: 1594
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
