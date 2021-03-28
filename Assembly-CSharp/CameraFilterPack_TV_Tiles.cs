using System;
using UnityEngine;

// Token: 0x02000122 RID: 290
[AddComponentMenu("Camera Filter Pack/TV/Tiles")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Tiles : MonoBehaviour
{
	// Token: 0x06005B6A RID: 23402 RVA: 0x001C1FD7 File Offset: 0x001C01D7
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B6B RID: 23403 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06005B6C RID: 23404 RVA: 0x001C200E File Offset: 0x001C020E
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B6D RID: 23405 RVA: 0x001C2045 File Offset: 0x001C0245
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B6E RID: 23406 RVA: 0x001C2062 File Offset: 0x001C0262
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("Item creation successful! Published Item ID: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B6F RID: 23407 RVA: 0x001C2045 File Offset: 0x001C0245
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B70 RID: 23408 RVA: 0x001C2045 File Offset: 0x001C0245
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06005B71 RID: 23409 RVA: 0x001C2086 File Offset: 0x001C0286
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

	// Token: 0x06005B72 RID: 23410 RVA: 0x001C20BD File Offset: 0x001C02BD
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B73 RID: 23411 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06005B74 RID: 23412 RVA: 0x001C20F4 File Offset: 0x001C02F4
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B75 RID: 23413 RVA: 0x001C2045 File Offset: 0x001C0245
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B76 RID: 23414 RVA: 0x001C2118 File Offset: 0x001C0318
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.StretchX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.StretchY);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B77 RID: 23415 RVA: 0x001C2230 File Offset: 0x001C0430
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1250f)
			{
				this.HBJJOCHGOPH = 528f;
			}
			this.FEAEGGCNIAA().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", this.Size);
			this.FEAEGGCNIAA().SetFloat("The binding '", this.Intensity);
			this.OKJOKHGJHGF().SetFloat("PRESS A KEY", this.StretchX);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.StretchY);
			this.EPCGJFCCAFH().SetFloat("Items/", this.Fade);
			this.OKJOKHGJHGF().SetVector("float,0.5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 631f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B78 RID: 23416 RVA: 0x001C2345 File Offset: 0x001C0545
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B79 RID: 23417 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005B7A RID: 23418 RVA: 0x001C237C File Offset: 0x001C057C
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B7B RID: 23419 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005B7C RID: 23420 RVA: 0x001C23B3 File Offset: 0x001C05B3
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("_Wavy");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B7D RID: 23421 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06005B7E RID: 23422 RVA: 0x001C23D7 File Offset: 0x001C05D7
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B7F RID: 23423 RVA: 0x001C240E File Offset: 0x001C060E
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B80 RID: 23424 RVA: 0x001C2432 File Offset: 0x001C0632
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B81 RID: 23425 RVA: 0x001C2045 File Offset: 0x001C0245
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B82 RID: 23426 RVA: 0x001C2458 File Offset: 0x001C0658
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1760f)
			{
				this.HBJJOCHGOPH = 1508f;
			}
			this.JIBOKBCPDLC().SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("#activechallenges", this.Size);
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.Intensity);
			this.EPCGJFCCAFH().SetFloat("Added event", this.StretchX);
			this.IIBLJCKLGFG().SetFloat("LeaderboardsButton", this.StretchY);
			this.OIMMPLPBLBK().SetFloat("/", this.Fade);
			this.IIBLJCKLGFG().SetVector("float,0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1959f, 1059f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B83 RID: 23427 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005B84 RID: 23428 RVA: 0x001C2570 File Offset: 0x001C0770
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1986f)
			{
				this.HBJJOCHGOPH = 1973f;
			}
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/TV_CompressionFX", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_Value4", this.Size);
			this.JIBOKBCPDLC().SetFloat("_SpotSize", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("DisableStoryboardToggle", this.StretchX);
			this.GJHLADDCMFF().SetFloat("_CenterY", this.StretchY);
			this.OIMMPLPBLBK().SetFloat("GlassColor", this.Fade);
			this.OKJOKHGJHGF().SetVector("bool", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1384f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B85 RID: 23429 RVA: 0x001C2685 File Offset: 0x001C0885
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B86 RID: 23430 RVA: 0x001C26AC File Offset: 0x001C08AC
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 274f)
			{
				this.HBJJOCHGOPH = 815f;
			}
			this.DNLMFEGJJDD().SetFloat("_CenterX", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("settings.arcsdestroydelay", this.Size);
			this.OGMEGHKECAH().SetFloat(".png", this.Intensity);
			this.OGMEGHKECAH().SetFloat("OneHand", this.StretchX);
			this.NBPKMLMCHFN.SetFloat("IntraTime", this.StretchY);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/Gradients_Tech", this.Fade);
			this.IIBLJCKLGFG().SetVector("<command>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1175f, 695f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B87 RID: 23431 RVA: 0x001C2045 File Offset: 0x001C0245
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B88 RID: 23432 RVA: 0x001C27C1 File Offset: 0x001C09C1
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B89 RID: 23433 RVA: 0x001C2045 File Offset: 0x001C0245
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B8A RID: 23434 RVA: 0x001C27F8 File Offset: 0x001C09F8
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B8B RID: 23435 RVA: 0x001C282F File Offset: 0x001C0A2F
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("grid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B8C RID: 23436 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06005B8D RID: 23437 RVA: 0x001C2045 File Offset: 0x001C0245
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B8E RID: 23438 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06005B8F RID: 23439 RVA: 0x001C2853 File Offset: 0x001C0A53
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B90 RID: 23440 RVA: 0x001C288C File Offset: 0x001C0A8C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 345f)
			{
				this.HBJJOCHGOPH = 1675f;
			}
			this.HKGAONMOBMH().SetFloat("value", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("SetupEncryption() got called. ", this.Size);
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this.Intensity);
			this.OKJOKHGJHGF().SetFloat("#tryagain", this.StretchX);
			this.EMDFHOKEGNG().SetFloat("#", this.StretchY);
			this.OIMMPLPBLBK().SetFloat("ArcsDestroyDelaySlider", this.Fade);
			this.OIMMPLPBLBK().SetVector("settings.cameramovements", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1897f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B91 RID: 23441 RVA: 0x001C2045 File Offset: 0x001C0245
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B92 RID: 23442 RVA: 0x001C29A1 File Offset: 0x001C0BA1
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("#mapby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B93 RID: 23443 RVA: 0x001C2045 File Offset: 0x001C0245
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B94 RID: 23444 RVA: 0x001C29C5 File Offset: 0x001C0BC5
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B95 RID: 23445 RVA: 0x001C29E9 File Offset: 0x001C0BE9
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B96 RID: 23446 RVA: 0x001C2A0D File Offset: 0x001C0C0D
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("Setting autoCleanUpPlayerObjects while in a room is not supported.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B97 RID: 23447 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06005B98 RID: 23448 RVA: 0x001C2A34 File Offset: 0x001C0C34
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 611f)
			{
				this.HBJJOCHGOPH = 62f;
			}
			this.IIBLJCKLGFG().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_Value5", this.Size);
			this.HKGAONMOBMH().SetFloat("_Value", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(".status", this.StretchX);
			this.OKJOKHGJHGF().SetFloat("_Near", this.StretchY);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", this.Fade);
			this.NBPKMLMCHFN.SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1578f, 1227f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B99 RID: 23449 RVA: 0x001C2345 File Offset: 0x001C0545
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B9A RID: 23450 RVA: 0x001C2B49 File Offset: 0x001C0D49
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("Middle Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B9C RID: 23452 RVA: 0x001C2BC8 File Offset: 0x001C0DC8
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 409f)
			{
				this.HBJJOCHGOPH = 1039f;
			}
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("BloodAlternative3", this.Size);
			this.OGMEGHKECAH().SetFloat("_Value", this.Intensity);
			this.EPCGJFCCAFH().SetFloat("#creatingnewitem", this.StretchX);
			this.GJHLADDCMFF().SetFloat("CameraFilterPack/Edge_Sobel", this.StretchY);
			this.GJHLADDCMFF().SetFloat("CameraFilterPack/Drawing_Manga4", this.Fade);
			this.OGMEGHKECAH().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 705f, 1159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B9D RID: 23453 RVA: 0x001C2045 File Offset: 0x001C0245
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B9E RID: 23454 RVA: 0x001C2CDD File Offset: 0x001C0EDD
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("owner: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B9F RID: 23455 RVA: 0x001C2D04 File Offset: 0x001C0F04
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1595f)
			{
				this.HBJJOCHGOPH = 444f;
			}
			this.OKJOKHGJHGF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("R1", this.Size);
			this.HKGAONMOBMH().SetFloat("Mouse1", this.Intensity);
			this.OKJOKHGJHGF().SetFloat("_Value", this.StretchX);
			this.HKGAONMOBMH().SetFloat("_Value", this.StretchY);
			this.NBPKMLMCHFN.SetFloat("GameVolumeSlider", this.Fade);
			this.NBPKMLMCHFN.SetVector("Already exist!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 771f, 101f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BA0 RID: 23456 RVA: 0x001C2045 File Offset: 0x001C0245
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BA1 RID: 23457 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005BA2 RID: 23458 RVA: 0x001C2E19 File Offset: 0x001C1019
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("error");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005BA3 RID: 23459 RVA: 0x001C2E40 File Offset: 0x001C1040
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1898f)
			{
				this.HBJJOCHGOPH = 1399f;
			}
			this.OGMEGHKECAH().SetFloat("offline", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_SpherePositionY", this.Size);
			this.JIBOKBCPDLC().SetFloat("_Value", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("error", this.StretchX);
			this.NBMPPNFKFLB().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", this.StretchY);
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this.Fade);
			this.HKGAONMOBMH().SetVector("[PlayerBase] Loaded environment: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1866f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BA4 RID: 23460 RVA: 0x001C2045 File Offset: 0x001C0245
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BA5 RID: 23461 RVA: 0x001C2045 File Offset: 0x001C0245
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BA6 RID: 23462 RVA: 0x001C2F55 File Offset: 0x001C1155
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Tiles");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BA7 RID: 23463 RVA: 0x001C2F79 File Offset: 0x001C1179
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_SubsampleIndices");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005BA8 RID: 23464 RVA: 0x001C2045 File Offset: 0x001C0245
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BA9 RID: 23465 RVA: 0x001C2045 File Offset: 0x001C0245
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x001C2F9D File Offset: 0x001C119D
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x001C2FD4 File Offset: 0x001C11D4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 529f)
			{
				this.HBJJOCHGOPH = 406f;
			}
			this.FEAEGGCNIAA().SetFloat("Set satellite color", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("inventory.selected.", this.Size);
			this.EMDFHOKEGNG().SetFloat("ComboScoreText", this.Intensity);
			this.FEAEGGCNIAA().SetFloat("_SunThreshold", this.StretchX);
			this.IIBLJCKLGFG().SetFloat("note.4", this.StretchY);
			this.GJHLADDCMFF().SetFloat("#savemapchanges?", this.Fade);
			this.OIMMPLPBLBK().SetVector("_InvRenderTargetSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 317f, 395f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BAC RID: 23468 RVA: 0x001C30E9 File Offset: 0x001C12E9
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BAD RID: 23469 RVA: 0x001C3120 File Offset: 0x001C1320
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 365f)
			{
				this.HBJJOCHGOPH = 370f;
			}
			this.OKJOKHGJHGF().SetFloat("--------------------------------", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("_TimeX", this.Size);
			this.HKGAONMOBMH().SetFloat("FullscreenToggle", this.Intensity);
			this.IIBLJCKLGFG().SetFloat("_Far", this.StretchX);
			this.NBPKMLMCHFN.SetFloat("_NeutralTonemapperParams2", this.StretchY);
			this.OGMEGHKECAH().SetFloat("Joystick1Button7", this.Fade);
			this.IIBLJCKLGFG().SetVector("CameraFilterPack/Glasses_On", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 468f, 1302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BAE RID: 23470 RVA: 0x001C2045 File Offset: 0x001C0245
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400094E RID: 2382
	public Shader SCShader;

	// Token: 0x0400094F RID: 2383
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000950 RID: 2384
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000951 RID: 2385
	private Material BJFKDHHMLJH;

	// Token: 0x04000952 RID: 2386
	[Range(0.5f, 2f)]
	public float Size = 1f;

	// Token: 0x04000953 RID: 2387
	[Range(0f, 10f)]
	public float Intensity = 4f;

	// Token: 0x04000954 RID: 2388
	[Range(0f, 1f)]
	public float StretchX = 0.6f;

	// Token: 0x04000955 RID: 2389
	[Range(0f, 1f)]
	public float StretchY = 0.4f;

	// Token: 0x04000956 RID: 2390
	[Range(0f, 1f)]
	public float Fade = 0.6f;
}
