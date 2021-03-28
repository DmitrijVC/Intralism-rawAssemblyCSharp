using System;
using UnityEngine;

// Token: 0x0200004C RID: 76
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/LinearLight")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_LinearLight : MonoBehaviour
{
	// Token: 0x06001553 RID: 5459 RVA: 0x0008AE29 File Offset: 0x00089029
	private void BJOHDLNDFAD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x0008AE64 File Offset: 0x00089064
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 469f)
			{
				this.HBJJOCHGOPH = 1778f;
			}
			if (this.Camera2 != null)
			{
				this.KGOLDDBHIFN().SetTexture("-1", this.JDMCFBKJHDD);
			}
			this.HNICHJCGJOC().SetFloat("CameraFilterPack_AAA_Blood2", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Edited event", this.BlendFX);
			this.HNICHJCGJOC().SetFloat("_Blue_G", this.SwitchCameraToCamera2);
			this.MCDGIILBNIF().SetVector("GameObject ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1288f, 1225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x0008AF5E File Offset: 0x0008915E
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x0008AF98 File Offset: 0x00089198
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 483f)
			{
				this.HBJJOCHGOPH = 1523f;
			}
			if (this.Camera2 != null)
			{
				this.MCDGIILBNIF().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Value", this.BlendFX);
			this.OGMEGHKECAH().SetFloat("_Bullet_12", this.SwitchCameraToCamera2);
			this.PLBEJJIHFPB().SetVector("_Blue_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1208f, 1759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x0008B094 File Offset: 0x00089294
	private void DNNFHBOOPIN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -92);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x0008B100 File Offset: 0x00089300
	private void OHFOLGANOLC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x0008B169 File Offset: 0x00089369
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x0008B1A0 File Offset: 0x000893A0
	private void KLILJHJNICK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x0008B20C File Offset: 0x0008940C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1630f)
			{
				this.HBJJOCHGOPH = 980f;
			}
			if (this.Camera2 != null)
			{
				this.HNICHJCGJOC().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("value", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_MainTex", this.BlendFX);
			this.HNICHJCGJOC().SetFloat("_Offsets", this.SwitchCameraToCamera2);
			this.ABHDNGIHBKE().SetVector("CameraFilterPack/Drawing_Laplacian", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1072f, 1410f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x0008AE29 File Offset: 0x00089029
	private void HLLHJIDOOGA()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x0008B308 File Offset: 0x00089508
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 602f)
			{
				this.HBJJOCHGOPH = 729f;
			}
			if (this.Camera2 != null)
			{
				this.MCDGIILBNIF().SetTexture("Bad parameters for getstring! Use <key> <value>", this.JDMCFBKJHDD);
			}
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/AAA_Super_Computer", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat(",", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("_ReflectionBufferSize", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector("arc", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1395f, 930f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x0008B404 File Offset: 0x00089604
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 414f)
			{
				this.HBJJOCHGOPH = 1915f;
			}
			if (this.Camera2 != null)
			{
				this.MCDGIILBNIF().SetTexture("_Skybox", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("EnvironmentSlider", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/TV_Videoflip", this.BlendFX);
			this.MCDGIILBNIF().SetFloat("_Offsets", this.SwitchCameraToCamera2);
			this.PLBEJJIHFPB().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 575f, 649f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x0008B4FE File Offset: 0x000896FE
	private void FELENDJEOGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 78);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x0008B539 File Offset: 0x00089739
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x0008B570 File Offset: 0x00089770
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1813f)
			{
				this.HBJJOCHGOPH = 409f;
			}
			if (this.Camera2 != null)
			{
				this.ABHDNGIHBKE().SetTexture("shader.frost", this.JDMCFBKJHDD);
			}
			this.HNICHJCGJOC().SetFloat("Image", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("isVisible", this.BlendFX);
			this.EPCGJFCCAFH().SetFloat("USE_UV_BASED_REPROJECTION", this.SwitchCameraToCamera2);
			this.EPCGJFCCAFH().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1397f, 368f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x0008B66A File Offset: 0x0008986A
	private void LLAJPKFNDIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x0008B6A8 File Offset: 0x000898A8
	private void MMOKKAPFGAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x0008B714 File Offset: 0x00089914
	private void FHPFJBFCOOF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x0008B780 File Offset: 0x00089980
	private void DKGBFNCOAEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x0008B7EC File Offset: 0x000899EC
	private void EFJDNLGNACH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x0008B858 File Offset: 0x00089A58
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x0008B954 File Offset: 0x00089B54
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1494f)
			{
				this.HBJJOCHGOPH = 99f;
			}
			if (this.Camera2 != null)
			{
				this.PDEAHJPOMEF().SetTexture("_Offsets", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("HightScoreMaxPointsText", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("music.ogg", this.BlendFX);
			this.OGMEGHKECAH().SetFloat("Right", this.SwitchCameraToCamera2);
			this.ABHDNGIHBKE().SetVector("[Down]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1183f, 361f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x0008BA4E File Offset: 0x00089C4E
	private void GHMDNIFLGOB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x0008BA8C File Offset: 0x00089C8C
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x0008BAF5 File Offset: 0x00089CF5
	private void IIJAPKAADNH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -56);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x0008BB30 File Offset: 0x00089D30
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1201f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			if (this.Camera2 != null)
			{
				this.HNICHJCGJOC().SetTexture("_ChangeRed", this.JDMCFBKJHDD);
			}
			this.HNICHJCGJOC().SetFloat("_TintColor", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat(": ", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("OxOD.lastPath", this.SwitchCameraToCamera2);
			this.OGMEGHKECAH().SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 232f, 612f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x0008BC2A File Offset: 0x00089E2A
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06001573 RID: 5491 RVA: 0x0008BC65 File Offset: 0x00089E65
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

	// Token: 0x06001574 RID: 5492 RVA: 0x0008AE29 File Offset: 0x00089029
	private void IMGGCJICLHK()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x0008BC9C File Offset: 0x00089E9C
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001576 RID: 5494 RVA: 0x0008BCD3 File Offset: 0x00089ED3
	private void MOMGJJDIFFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -70);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x0008BD10 File Offset: 0x00089F10
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 827f)
			{
				this.HBJJOCHGOPH = 132f;
			}
			if (this.Camera2 != null)
			{
				this.PDEAHJPOMEF().SetTexture("_Value3", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_TimeX", this.BlendFX);
			this.OGMEGHKECAH().SetFloat("_MainTex2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1819f, 980f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x0008BE0C File Offset: 0x0008A00C
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1807f)
			{
				this.HBJJOCHGOPH = 132f;
			}
			if (this.Camera2 != null)
			{
				this.KGOLDDBHIFN().SetTexture("fetch", this.JDMCFBKJHDD);
			}
			this.EPCGJFCCAFH().SetFloat("]", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("SetSpeed", this.BlendFX);
			this.OGMEGHKECAH().SetFloat(" has no method \"", this.SwitchCameraToCamera2);
			this.PDEAHJPOMEF().SetVector("ItemNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1740f, 1702f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x0008BF06 File Offset: 0x0008A106
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x0008BF3D File Offset: 0x0008A13D
	private void FDIJLKIIMLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x0008BF78 File Offset: 0x0008A178
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1303f)
			{
				this.HBJJOCHGOPH = 1343f;
			}
			if (this.Camera2 != null)
			{
				this.PDEAHJPOMEF().SetTexture("PerfectHitsScoreText", this.JDMCFBKJHDD);
			}
			this.EPCGJFCCAFH().SetFloat("/", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_EdgeSize", this.BlendFX);
			this.PDEAHJPOMEF().SetFloat("_Value9", this.SwitchCameraToCamera2);
			this.PLBEJJIHFPB().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 531f, 537f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x0008C072 File Offset: 0x0008A272
	private void FKDKJKCAHJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x0008C0AD File Offset: 0x0008A2AD
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x0008AE29 File Offset: 0x00089029
	private void EJJEDJIOFAB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x0008AE29 File Offset: 0x00089029
	private void FKEJGBFDCAH()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x0008AE29 File Offset: 0x00089029
	private void PKBENONAOOL()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x0008AE29 File Offset: 0x00089029
	private void JOJFHFHOCHO()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x0008C10D File Offset: 0x0008A30D
	private void PDILBLLIPFJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 22);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x0008AE29 File Offset: 0x00089029
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001588 RID: 5512 RVA: 0x0008C148 File Offset: 0x0008A348
	private void GAAPMFBPJNH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x0008BC2A File Offset: 0x00089E2A
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x0008C183 File Offset: 0x0008A383
	private void KOCPGJCINKD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x0008AE29 File Offset: 0x00089029
	private void ALMGMOOHLMA()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x0008C1BE File Offset: 0x0008A3BE
	private void IJCBBIJOCAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x0008AE29 File Offset: 0x00089029
	private void GPHPJIDGEPI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x0008AE29 File Offset: 0x00089029
	private void OCCGJMPAJIK()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x0008C1FC File Offset: 0x0008A3FC
	private void KNBJBNDGCIJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x0008C265 File Offset: 0x0008A465
	private void JHBPINEKDPE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 61);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x0008C2A0 File Offset: 0x0008A4A0
	private void HAIAHJPCPAG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x0008AE29 File Offset: 0x00089029
	private void NAOLAJPDGIC()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x0008C309 File Offset: 0x0008A509
	private void MBNMADBPDLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 49);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x0008C344 File Offset: 0x0008A544
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 1899f;
			}
			if (this.Camera2 != null)
			{
				this.MCDGIILBNIF().SetTexture("Set Sun Lerp Speed", this.JDMCFBKJHDD);
			}
			this.OGMEGHKECAH().SetFloat("/", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("didAuthenticate ", this.BlendFX);
			this.PLBEJJIHFPB().SetFloat("inventory.selected.", this.SwitchCameraToCamera2);
			this.ABHDNGIHBKE().SetVector("ItemsUploader", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 772f, 788f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x0008BC65 File Offset: 0x00089E65
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x0008C43E File Offset: 0x0008A63E
	private void MBFNACDMEEK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -69);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x0008C479 File Offset: 0x0008A679
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x0008AE29 File Offset: 0x00089029
	private void BNEJMABFKJE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x0008C4B0 File Offset: 0x0008A6B0
	private void HIFPDKKBDHJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 125);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x0008C4EC File Offset: 0x0008A6EC
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1322f)
			{
				this.HBJJOCHGOPH = 316f;
			}
			if (this.Camera2 != null)
			{
				this.PLBEJJIHFPB().SetTexture("SpawnObj", this.JDMCFBKJHDD);
			}
			this.PLBEJJIHFPB().SetFloat("{0:0.0} ms ({1:0.} fps)", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Tab1Content", this.BlendFX);
			this.PLBEJJIHFPB().SetFloat("2hands", this.SwitchCameraToCamera2);
			this.KGOLDDBHIFN().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1887f, 128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040002F1 RID: 753
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearLight";

	// Token: 0x040002F2 RID: 754
	public Shader SCShader;

	// Token: 0x040002F3 RID: 755
	public Camera Camera2;

	// Token: 0x040002F4 RID: 756
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002F5 RID: 757
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002F6 RID: 758
	private Material BJFKDHHMLJH;

	// Token: 0x040002F7 RID: 759
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002F8 RID: 760
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002F9 RID: 761
	private RenderTexture JDMCFBKJHDD;
}
