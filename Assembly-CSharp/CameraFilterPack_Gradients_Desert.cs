using System;
using UnityEngine;

// Token: 0x020000E2 RID: 226
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Gradients/Desert")]
public class CameraFilterPack_Gradients_Desert : MonoBehaviour
{
	// Token: 0x06004531 RID: 17713 RVA: 0x00156A97 File Offset: 0x00154C97
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004532 RID: 17714 RVA: 0x00156ABC File Offset: 0x00154CBC
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004533 RID: 17715 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004534 RID: 17716 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004535 RID: 17717 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004536 RID: 17718 RVA: 0x00156A97 File Offset: 0x00154C97
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004537 RID: 17719 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004538 RID: 17720 RVA: 0x00156B10 File Offset: 0x00154D10
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004539 RID: 17721 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x0600453A RID: 17722 RVA: 0x00156B10 File Offset: 0x00154D10
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600453B RID: 17723 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x0600453C RID: 17724 RVA: 0x00156A97 File Offset: 0x00154C97
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x0600453D RID: 17725 RVA: 0x00156B35 File Offset: 0x00154D35
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

	// Token: 0x0600453E RID: 17726 RVA: 0x00156B6C File Offset: 0x00154D6C
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 786f)
			{
				this.HBJJOCHGOPH = 161f;
			}
			this.PLBEJJIHFPB().SetFloat("Sequence contains no elements", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Error: You're not logged into Steam!", this.Switch);
			this.FLOHGDECHHH().SetFloat("CameraFilterPack/Blend2Camera_Hue", this.Fade);
			this.EPCGJFCCAFH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1800f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600453F RID: 17727 RVA: 0x00156C3F File Offset: 0x00154E3F
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004540 RID: 17728 RVA: 0x00156A97 File Offset: 0x00154C97
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004541 RID: 17729 RVA: 0x00156C78 File Offset: 0x00154E78
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1695f)
			{
				this.HBJJOCHGOPH = 77f;
			}
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("BadgeText", this.Switch);
			this.DBOLLHHMKKN().SetFloat("[NetworkManager] Joined room with ", this.Fade);
			this.EPCGJFCCAFH().SetVector("USE_DIAG_SEARCH", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1104f, 118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004542 RID: 17730 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004543 RID: 17731 RVA: 0x00156A97 File Offset: 0x00154C97
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004544 RID: 17732 RVA: 0x00156D4C File Offset: 0x00154F4C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 977f)
			{
				this.HBJJOCHGOPH = 450f;
			}
			this.KEMAALEODNH().SetFloat("float,0", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_Value", this.Switch);
			this.DBOLLHHMKKN().SetFloat(" SphereWaveform.cs", this.Fade);
			this.DBOLLHHMKKN().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1754f, 708f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004545 RID: 17733 RVA: 0x00156E1F File Offset: 0x0015501F
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004546 RID: 17734 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004547 RID: 17735 RVA: 0x00156E58 File Offset: 0x00155058
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 46f;
			}
			this.IIBLJCKLGFG().SetFloat("<command>", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("[LocalizationService] All keys for ", this.Switch);
			this.HEHKGPKLAKK().SetFloat("_AllowBackwardsRays", this.Fade);
			this.LDNADDJMIPK().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 718f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x00156F2C File Offset: 0x0015512C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 969f)
			{
				this.HBJJOCHGOPH = 130f;
			}
			this.PGPEMMBJOOG().SetFloat("1278033234", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("Texture2", this.Switch);
			this.PGPEMMBJOOG().SetFloat(" - StoreAuthURLResponse] - ", this.Fade);
			this.EPCGJFCCAFH().SetVector("connecting", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1617f, 1475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004549 RID: 17737 RVA: 0x00156FFF File Offset: 0x001551FF
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x00157038 File Offset: 0x00155238
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1563f)
			{
				this.HBJJOCHGOPH = 1880f;
			}
			this.LDNADDJMIPK().SetFloat("OpChangeGroups()", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("id", this.Switch);
			this.PLBEJJIHFPB().SetFloat("_Value2", this.Fade);
			this.DEFBJOCJJKF().SetVector("Edited hands count", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1567f, 150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600454C RID: 17740 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600454D RID: 17741 RVA: 0x0015710C File Offset: 0x0015530C
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

	// Token: 0x0600454E RID: 17742 RVA: 0x001571DF File Offset: 0x001553DF
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600454F RID: 17743 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004550 RID: 17744 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06004551 RID: 17745 RVA: 0x00157216 File Offset: 0x00155416
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004552 RID: 17746 RVA: 0x00157250 File Offset: 0x00155450
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 78f)
			{
				this.HBJJOCHGOPH = 755f;
			}
			this.FLOHGDECHHH().SetFloat("#yes", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.Switch);
			this.DEFBJOCJJKF().SetFloat("_TimeX", this.Fade);
			this.LDNADDJMIPK().SetVector("_Red_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1049f, 1604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004553 RID: 17747 RVA: 0x00157323 File Offset: 0x00155523
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004554 RID: 17748 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004555 RID: 17749 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06004556 RID: 17750 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004557 RID: 17751 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004559 RID: 17753 RVA: 0x0015735A File Offset: 0x0015555A
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600455A RID: 17754 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x0600455B RID: 17755 RVA: 0x00156B10 File Offset: 0x00154D10
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600455C RID: 17756 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x001573C8 File Offset: 0x001555C8
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 438f)
			{
				this.HBJJOCHGOPH = 1948f;
			}
			this.IIBLJCKLGFG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat(". The group number should be at least 1.", this.Switch);
			this.LDNADDJMIPK().SetFloat("Joystick1Button10", this.Fade);
			this.DEFBJOCJJKF().SetVector("No Dispatcher exists in the scene. Actions will not be invoked!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1363f, 1067f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600455F RID: 17759 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004560 RID: 17760 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x0015749B File Offset: 0x0015569B
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004562 RID: 17762 RVA: 0x001574D2 File Offset: 0x001556D2
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004563 RID: 17763 RVA: 0x00156A97 File Offset: 0x00154C97
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004564 RID: 17764 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06004565 RID: 17765 RVA: 0x00156AF3 File Offset: 0x00154CF3
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000768 RID: 1896
	public Shader SCShader;

	// Token: 0x04000769 RID: 1897
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Desert";

	// Token: 0x0400076A RID: 1898
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400076B RID: 1899
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400076C RID: 1900
	private Material BJFKDHHMLJH;

	// Token: 0x0400076D RID: 1901
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x0400076E RID: 1902
	[Range(0f, 1f)]
	public float Fade = 1f;
}
