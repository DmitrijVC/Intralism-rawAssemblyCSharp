using System;
using UnityEngine;

// Token: 0x0200013B RID: 315
[AddComponentMenu("Camera Filter Pack/Vision/Warp")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Warp : MonoBehaviour
{
	// Token: 0x06006366 RID: 25446 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006367 RID: 25447 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006368 RID: 25448 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x001E3B0C File Offset: 0x001E1D0C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1224f)
			{
				this.HBJJOCHGOPH = 1085f;
			}
			this.LNLKMDPHDCC().SetFloat("IncorrectHitsScoreText", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat(".jpg", this.Value);
			this.EPCGJFCCAFH().SetFloat("_ScreenResolution", this.Value2);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", this.ILHJFHFPGBB);
			this.FHFLKLMFHOI().SetFloat("settings.showHP", this.CCIENBFIKKH);
			this.EPCGJFCCAFH().SetVector("[Up]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 96f, 1284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x001E3C0B File Offset: 0x001E1E0B
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x001E3C2F File Offset: 0x001E1E2F
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600636D RID: 25453 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x0600636E RID: 25454 RVA: 0x001E3C53 File Offset: 0x001E1E53
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600636F RID: 25455 RVA: 0x001E3C77 File Offset: 0x001E1E77
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("USE_PREDICATION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006370 RID: 25456 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006371 RID: 25457 RVA: 0x001E3C9B File Offset: 0x001E1E9B
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006372 RID: 25458 RVA: 0x001E3CD4 File Offset: 0x001E1ED4
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 135f;
			}
			this.EPCGJFCCAFH().SetFloat("Netw. Sim.", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("/Saved Games/", this.Value);
			this.HCGJCMDJPGD().SetFloat("Misses:", this.Value2);
			this.HCGJCMDJPGD().SetFloat("_MainTex", this.ILHJFHFPGBB);
			this.LNLKMDPHDCC().SetFloat("#changenote", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector(" - GameWebCallback] - ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1589f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006373 RID: 25459 RVA: 0x001E3DD3 File Offset: 0x001E1FD3
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006374 RID: 25460 RVA: 0x001E3E0A File Offset: 0x001E200A
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006375 RID: 25461 RVA: 0x001E3E41 File Offset: 0x001E2041
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("0 seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006376 RID: 25462 RVA: 0x001E3E68 File Offset: 0x001E2068
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1641f)
			{
				this.HBJJOCHGOPH = 392f;
			}
			this.GKILCDHJFEG().SetFloat("_Near", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_ProjectionInv", this.Value);
			this.HCGJCMDJPGD().SetFloat("_Offsets", this.Value2);
			this.HFBJAOFLCJI().SetFloat("(\\[ */ *h1 *\\])", this.ILHJFHFPGBB);
			this.HCGJCMDJPGD().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector("CameraFilterPack/Blend2Camera_ColorDodge", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 304f, 761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006377 RID: 25463 RVA: 0x001E3F67 File Offset: 0x001E2167
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006378 RID: 25464 RVA: 0x001E3F9E File Offset: 0x001E219E
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x001E3FC2 File Offset: 0x001E21C2
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600637A RID: 25466 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x0600637B RID: 25467 RVA: 0x001E3FE8 File Offset: 0x001E21E8
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 554f)
			{
				this.HBJJOCHGOPH = 702f;
			}
			this.LNLKMDPHDCC().SetFloat("OpSetPropertiesOfRoom()", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_Value3", this.Value);
			this.HCGJCMDJPGD().SetFloat("_FixDistance", this.Value2);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.ILHJFHFPGBB);
			this.NBMPPNFKFLB().SetFloat("LoadingStatusText", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("player.licenceaccepted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 350f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600637C RID: 25468 RVA: 0x001E40E7 File Offset: 0x001E22E7
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600637D RID: 25469 RVA: 0x001E411E File Offset: 0x001E231E
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600637E RID: 25470 RVA: 0x001E4155 File Offset: 0x001E2355
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("[Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600637F RID: 25471 RVA: 0x001E417C File Offset: 0x001E237C
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 250f)
			{
				this.HBJJOCHGOPH = 932f;
			}
			this.EPCGJFCCAFH().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_Value2", this.Value);
			this.GKILCDHJFEG().SetFloat("PublishButton", this.Value2);
			this.HFBJAOFLCJI().SetFloat("1", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("Joystick1Button2", this.CCIENBFIKKH);
			this.HFBJAOFLCJI().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 688f, 1301f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006380 RID: 25472 RVA: 0x001E427C File Offset: 0x001E247C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 695f)
			{
				this.HBJJOCHGOPH = 1046f;
			}
			this.NBMPPNFKFLB().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("/Segment-[Left]", this.Value);
			this.NBMPPNFKFLB().SetFloat("_MainTex2", this.Value2);
			this.LNLKMDPHDCC().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this.ILHJFHFPGBB);
			this.GKILCDHJFEG().SetFloat("_Blend", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("GhostSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1098f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006381 RID: 25473 RVA: 0x001E437B File Offset: 0x001E257B
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006382 RID: 25474 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06006383 RID: 25475 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006385 RID: 25477 RVA: 0x001E43E0 File Offset: 0x001E25E0
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Value2);
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

	// Token: 0x06006386 RID: 25478 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06006387 RID: 25479 RVA: 0x001E44E0 File Offset: 0x001E26E0
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 19f)
			{
				this.HBJJOCHGOPH = 603f;
			}
			this.EPCGJFCCAFH().SetFloat("float", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", this.Value);
			this.HCGJCMDJPGD().SetFloat("?", this.Value2);
			this.IIBLJCKLGFG().SetFloat("Hidden/Image Effects/Cinematic/Bloom", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("maps.", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("menutheme.jamaicanorcdub", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1049f, 1885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006388 RID: 25480 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006389 RID: 25481 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600638A RID: 25482 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600638B RID: 25483 RVA: 0x001E45DF File Offset: 0x001E27DF
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600638C RID: 25484 RVA: 0x001E4616 File Offset: 0x001E2816
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600638D RID: 25485 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600638E RID: 25486 RVA: 0x001E463C File Offset: 0x001E283C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1247f)
			{
				this.HBJJOCHGOPH = 1080f;
			}
			this.HCGJCMDJPGD().SetFloat("_CurrentMipLevel", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat(".status", this.Value);
			this.LNLKMDPHDCC().SetFloat("PLEASE WAIT", this.Value2);
			this.NBPKMLMCHFN.SetFloat("\n", this.ILHJFHFPGBB);
			this.IIBLJCKLGFG().SetFloat("-1", this.CCIENBFIKKH);
			this.LNLKMDPHDCC().SetVector("CameraFilterPack/Blend2Camera_SoftLight", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1264f, 1913f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x001E473B File Offset: 0x001E293B
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.correctScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06006390 RID: 25488 RVA: 0x001E475F File Offset: 0x001E295F
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

	// Token: 0x06006391 RID: 25489 RVA: 0x001E4796 File Offset: 0x001E2996
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_InvScreenSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006392 RID: 25490 RVA: 0x001E47BA File Offset: 0x001E29BA
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006393 RID: 25491 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006394 RID: 25492 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06006395 RID: 25493 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006396 RID: 25494 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006397 RID: 25495 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06006398 RID: 25496 RVA: 0x001E47F4 File Offset: 0x001E29F4
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1501f)
			{
				this.HBJJOCHGOPH = 1419f;
			}
			this.LNLKMDPHDCC().SetFloat(".lastCheckpoint.bgcolor", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_Value5", this.Value);
			this.HCGJCMDJPGD().SetFloat("_DepthLevel", this.Value2);
			this.NBMPPNFKFLB().SetFloat("player.gamecompleted", this.ILHJFHFPGBB);
			this.HFBJAOFLCJI().SetFloat("id", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_EmissionGain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1954f, 1381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006399 RID: 25497 RVA: 0x001E48F4 File Offset: 0x001E2AF4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 133f)
			{
				this.HBJJOCHGOPH = 1583f;
			}
			this.GKILCDHJFEG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("Joystick1Button9", this.Value);
			this.HFBJAOFLCJI().SetFloat("GlassAberration", this.Value2);
			this.NBMPPNFKFLB().SetFloat("_SceneFogMode", this.ILHJFHFPGBB);
			this.FHFLKLMFHOI().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("GlassesColor2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 987f, 704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600639A RID: 25498 RVA: 0x001E49F3 File Offset: 0x001E2BF3
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("DataText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600639B RID: 25499 RVA: 0x001E4A18 File Offset: 0x001E2C18
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 700f)
			{
				this.HBJJOCHGOPH = 1159f;
			}
			this.FHFLKLMFHOI().SetFloat("settings.arcshitsoundtimedelay", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat(".lastCheckpoint.time", this.Value);
			this.NBPKMLMCHFN.SetFloat("move", this.Value2);
			this.GKILCDHJFEG().SetFloat("_Vibrance", this.ILHJFHFPGBB);
			this.HCGJCMDJPGD().SetFloat("SetSpeed", this.CCIENBFIKKH);
			this.GKILCDHJFEG().SetVector("00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 470f, 802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600639C RID: 25500 RVA: 0x001E4B17 File Offset: 0x001E2D17
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_Bullet_11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600639D RID: 25501 RVA: 0x001E4B3C File Offset: 0x001E2D3C
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 629f)
			{
				this.HBJJOCHGOPH = 539f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value4", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("Done!", this.Value);
			this.FHFLKLMFHOI().SetFloat("#startofflinemessage", this.Value2);
			this.EPCGJFCCAFH().SetFloat("Error! no audio sources attached to AudioSampler.css", this.ILHJFHFPGBB);
			this.EPCGJFCCAFH().SetFloat("_Near", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("in seconds. 0 - forever", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 666f, 115f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600639E RID: 25502 RVA: 0x001E4C3B File Offset: 0x001E2E3B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Warp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600639F RID: 25503 RVA: 0x001E4C60 File Offset: 0x001E2E60
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 164f)
			{
				this.HBJJOCHGOPH = 432f;
			}
			this.LNLKMDPHDCC().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("Left", this.Value);
			this.HCGJCMDJPGD().SetFloat("GameScene", this.Value2);
			this.JFDGLLEOPGB().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", this.ILHJFHFPGBB);
			this.IIBLJCKLGFG().SetFloat("_CenterX", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector("CameraFilterPack/FX_Hexagon_Black", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 251f, 1231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060063A0 RID: 25504 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060063A1 RID: 25505 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060063A2 RID: 25506 RVA: 0x001E4D60 File Offset: 0x001E2F60
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1445f)
			{
				this.HBJJOCHGOPH = 148f;
			}
			this.JFDGLLEOPGB().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("Received unknown status code: ", this.Value);
			this.NBMPPNFKFLB().SetFloat("colorC", this.Value2);
			this.EPCGJFCCAFH().SetFloat(".sav", this.ILHJFHFPGBB);
			this.HFBJAOFLCJI().SetFloat("No Name", this.CCIENBFIKKH);
			this.EPCGJFCCAFH().SetVector("_Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 249f, 1558f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060063A3 RID: 25507 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060063A4 RID: 25508 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060063A5 RID: 25509 RVA: 0x001E3AEE File Offset: 0x001E1CEE
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060063A6 RID: 25510 RVA: 0x001E4E60 File Offset: 0x001E3060
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 186f)
			{
				this.HBJJOCHGOPH = 1928f;
			}
			this.HCGJCMDJPGD().SetFloat("_Level", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("0 - sun, 1 - satellite, 2 - particles emitter", this.Value);
			this.LNLKMDPHDCC().SetFloat("_Value", this.Value2);
			this.HCGJCMDJPGD().SetFloat("_Value7", this.ILHJFHFPGBB);
			this.GKILCDHJFEG().SetFloat("_Value3", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector("Environment/SunBase_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1576f, 853f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060063A7 RID: 25511 RVA: 0x001E4F5F File Offset: 0x001E315F
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000A12 RID: 2578
	public Shader SCShader;

	// Token: 0x04000A13 RID: 2579
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000A14 RID: 2580
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000A15 RID: 2581
	private Material BJFKDHHMLJH;

	// Token: 0x04000A16 RID: 2582
	[Range(0f, 1f)]
	public float Value = 0.6f;

	// Token: 0x04000A17 RID: 2583
	[Range(0f, 1f)]
	public float Value2 = 0.6f;

	// Token: 0x04000A18 RID: 2584
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x04000A19 RID: 2585
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
