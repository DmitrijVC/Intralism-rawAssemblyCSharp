using System;
using UnityEngine;

// Token: 0x020000D6 RID: 214
[AddComponentMenu("Camera Filter Pack/FX/SuperDot")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_superDot : MonoBehaviour
{
	// Token: 0x0600412C RID: 16684 RVA: 0x00142151 File Offset: 0x00140351
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600412D RID: 16685 RVA: 0x00142188 File Offset: 0x00140388
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1671f)
			{
				this.HBJJOCHGOPH = 822f;
			}
			this.FOOCJIDNGBB().SetFloat("Set sun lerp speed", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetVector("CameraFilterPack_Broken_Screen1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 351f, 814f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600412E RID: 16686 RVA: 0x0014222F File Offset: 0x0014042F
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600412F RID: 16687 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004130 RID: 16688 RVA: 0x00142253 File Offset: 0x00140453
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004131 RID: 16689 RVA: 0x0014228C File Offset: 0x0014048C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 210f)
			{
				this.HBJJOCHGOPH = 238f;
			}
			this.DNLMFEGJJDD().SetFloat("ShowSprite", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 325f, 1663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004132 RID: 16690 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06004133 RID: 16691 RVA: 0x00142333 File Offset: 0x00140533
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004134 RID: 16692 RVA: 0x00142333 File Offset: 0x00140533
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004136 RID: 16694 RVA: 0x00142364 File Offset: 0x00140564
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 172f)
			{
				this.HBJJOCHGOPH = 212f;
			}
			this.LNLKMDPHDCC().SetFloat("Joystick1Button5", this.HBJJOCHGOPH);
			this.MPENCEIGLEH().SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 127f, 9f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004137 RID: 16695 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMNOHLNANIP()
	{
	}

	// Token: 0x06004138 RID: 16696 RVA: 0x00142333 File Offset: 0x00140533
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004139 RID: 16697 RVA: 0x0014240B File Offset: 0x0014060B
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("Netw. Sim.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600413A RID: 16698 RVA: 0x00142333 File Offset: 0x00140533
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600413B RID: 16699 RVA: 0x0014242F File Offset: 0x0014062F
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600413C RID: 16700 RVA: 0x00142468 File Offset: 0x00140668
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 208f)
			{
				this.HBJJOCHGOPH = 692f;
			}
			this.KHCLIAMBBNC().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetVector("settings.shaders.bloomintencity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1429f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600413D RID: 16701 RVA: 0x00142510 File Offset: 0x00140710
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1214f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			this.CEKJODEAMGB().SetFloat("settings.volume.game", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetVector("ShowSprite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 453f, 621f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600413E RID: 16702 RVA: 0x001425B7 File Offset: 0x001407B7
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600413F RID: 16703 RVA: 0x001425EE File Offset: 0x001407EE
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004140 RID: 16704 RVA: 0x00142612 File Offset: 0x00140812
	private void IBLGHLNNAHN()
	{
		this.SCShader = Shader.Find("Scrollbar");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004141 RID: 16705 RVA: 0x00142333 File Offset: 0x00140533
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004142 RID: 16706 RVA: 0x00142636 File Offset: 0x00140836
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004143 RID: 16707 RVA: 0x0014265A File Offset: 0x0014085A
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004144 RID: 16708 RVA: 0x00142333 File Offset: 0x00140533
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004145 RID: 16709 RVA: 0x00142691 File Offset: 0x00140891
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004146 RID: 16710 RVA: 0x001426B5 File Offset: 0x001408B5
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004147 RID: 16711 RVA: 0x001426D9 File Offset: 0x001408D9
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("settings.hitvariation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004148 RID: 16712 RVA: 0x001426FD File Offset: 0x001408FD
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("Bad parameters for setint! Use <key> <value>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004149 RID: 16713 RVA: 0x00142333 File Offset: 0x00140533
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600414A RID: 16714 RVA: 0x00142721 File Offset: 0x00140921
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600414B RID: 16715 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600414C RID: 16716 RVA: 0x00142758 File Offset: 0x00140958
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600414D RID: 16717 RVA: 0x0014277C File Offset: 0x0014097C
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600414E RID: 16718 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x0600414F RID: 16719 RVA: 0x001427B3 File Offset: 0x001409B3
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004150 RID: 16720 RVA: 0x00142333 File Offset: 0x00140533
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004151 RID: 16721 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06004152 RID: 16722 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06004153 RID: 16723 RVA: 0x001427D8 File Offset: 0x001409D8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 336f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			this.LONNIJMNKFB().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 178f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004154 RID: 16724 RVA: 0x0014287F File Offset: 0x00140A7F
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004155 RID: 16725 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06004156 RID: 16726 RVA: 0x001428B8 File Offset: 0x00140AB8
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 268f)
			{
				this.HBJJOCHGOPH = 1898f;
			}
			this.IFMAPIDFNLI().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetVector("SetSatelliteRotationSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1627f, 68f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004157 RID: 16727 RVA: 0x0014295F File Offset: 0x00140B5F
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_ProjInfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004158 RID: 16728 RVA: 0x00142983 File Offset: 0x00140B83
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("_Level");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004159 RID: 16729 RVA: 0x001429A7 File Offset: 0x00140BA7
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600415A RID: 16730 RVA: 0x001429CB File Offset: 0x00140BCB
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600415B RID: 16731 RVA: 0x00142A02 File Offset: 0x00140C02
	private void EDPDMBFLHLP()
	{
		this.SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600415C RID: 16732 RVA: 0x00142A26 File Offset: 0x00140C26
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find(">");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600415D RID: 16733 RVA: 0x00142A4C File Offset: 0x00140C4C
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 536f)
			{
				this.HBJJOCHGOPH = 1647f;
			}
			this.KGOLDDBHIFN().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1599f, 557f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600415E RID: 16734 RVA: 0x00142AF4 File Offset: 0x00140CF4
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1828f)
			{
				this.HBJJOCHGOPH = 1636f;
			}
			this.CECICEGFHKL().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetVector("<b>(╯°□°）╯︵ ┻━┻</b>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 606f, 1053f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600415F RID: 16735 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06004160 RID: 16736 RVA: 0x00142333 File Offset: 0x00140533
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004161 RID: 16737 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06004162 RID: 16738 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06004163 RID: 16739 RVA: 0x00142B9C File Offset: 0x00140D9C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 438f)
			{
				this.HBJJOCHGOPH = 452f;
			}
			this.DNLMFEGJJDD().SetFloat("Can't set open when not in that room.", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1111f, 1536f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004164 RID: 16740 RVA: 0x00142C44 File Offset: 0x00140E44
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1817f)
			{
				this.HBJJOCHGOPH = 1731f;
			}
			this.CFCPHFMKHII().SetFloat("CameraFilterPack/Oculus_NightVision3", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetVector("SetLives", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1356f, 895f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004165 RID: 16741 RVA: 0x00142333 File Offset: 0x00140533
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004166 RID: 16742 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06004167 RID: 16743 RVA: 0x00142CEC File Offset: 0x00140EEC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1819f)
			{
				this.HBJJOCHGOPH = 442f;
			}
			this.ECCPAOBFDKP().SetFloat("_FarCorner", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 639f, 776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004168 RID: 16744 RVA: 0x00142D93 File Offset: 0x00140F93
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_ARCADE_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004169 RID: 16745 RVA: 0x00142DB7 File Offset: 0x00140FB7
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("Down");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600416A RID: 16746 RVA: 0x00142333 File Offset: 0x00140533
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600416B RID: 16747 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600416C RID: 16748 RVA: 0x00142DDB File Offset: 0x00140FDB
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600416D RID: 16749 RVA: 0x00142E12 File Offset: 0x00141012
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600416E RID: 16750 RVA: 0x00142333 File Offset: 0x00140533
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600416F RID: 16751 RVA: 0x00142333 File Offset: 0x00140533
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004170 RID: 16752 RVA: 0x00142E49 File Offset: 0x00141049
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004171 RID: 16753 RVA: 0x00142333 File Offset: 0x00140533
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004172 RID: 16754 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06004173 RID: 16755 RVA: 0x00142E80 File Offset: 0x00141080
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004174 RID: 16756 RVA: 0x00142333 File Offset: 0x00140533
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004175 RID: 16757 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06004176 RID: 16758 RVA: 0x00142333 File Offset: 0x00140533
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004177 RID: 16759 RVA: 0x00142EB7 File Offset: 0x001410B7
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("</i>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x00142EDC File Offset: 0x001410DC
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1902f)
			{
				this.HBJJOCHGOPH = 1383f;
			}
			this.ELBMIEOIABA().SetFloat("CameraFilterPack_RainFX_Anm2", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetVector("PopulateMapsList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 216f, 1720f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x0600417A RID: 16762 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x0600417B RID: 16763 RVA: 0x00142333 File Offset: 0x00140533
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x00142F83 File Offset: 0x00141183
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("Turn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600417D RID: 16765 RVA: 0x00142FA7 File Offset: 0x001411A7
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x00142FDE File Offset: 0x001411DE
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600417F RID: 16767 RVA: 0x00142333 File Offset: 0x00140533
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004180 RID: 16768 RVA: 0x00143018 File Offset: 0x00141218
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1839f)
			{
				this.HBJJOCHGOPH = 961f;
			}
			this.DNLMFEGJJDD().SetFloat(" Time: ", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetVector("mapselector.filter.officialsortmode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1369f, 1340f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004181 RID: 16769 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06004182 RID: 16770 RVA: 0x00142253 File Offset: 0x00140453
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004183 RID: 16771 RVA: 0x001430BF File Offset: 0x001412BF
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("X2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004184 RID: 16772 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06004185 RID: 16773 RVA: 0x00142333 File Offset: 0x00140533
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004186 RID: 16774 RVA: 0x00142333 File Offset: 0x00140533
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004187 RID: 16775 RVA: 0x00142333 File Offset: 0x00140533
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004188 RID: 16776 RVA: 0x001430E3 File Offset: 0x001412E3
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004189 RID: 16777 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x0600418A RID: 16778 RVA: 0x0014311A File Offset: 0x0014131A
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("NO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600418B RID: 16779 RVA: 0x0014313E File Offset: 0x0014133E
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600418C RID: 16780 RVA: 0x00143164 File Offset: 0x00141364
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 695f)
			{
				this.HBJJOCHGOPH = 619f;
			}
			this.OHKGGPFGLFD().SetFloat("/", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetVector("_Blend", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 185f, 1395f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600418D RID: 16781 RVA: 0x00142333 File Offset: 0x00140533
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600418E RID: 16782 RVA: 0x00142333 File Offset: 0x00140533
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600418F RID: 16783 RVA: 0x0014320B File Offset: 0x0014140B
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004190 RID: 16784 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06004191 RID: 16785 RVA: 0x00143242 File Offset: 0x00141442
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

	// Token: 0x06004192 RID: 16786 RVA: 0x00142333 File Offset: 0x00140533
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004193 RID: 16787 RVA: 0x00142333 File Offset: 0x00140533
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004194 RID: 16788 RVA: 0x00142333 File Offset: 0x00140533
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004195 RID: 16789 RVA: 0x00142333 File Offset: 0x00140533
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004196 RID: 16790 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06004197 RID: 16791 RVA: 0x0014327C File Offset: 0x0014147C
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

	// Token: 0x06004198 RID: 16792 RVA: 0x00142333 File Offset: 0x00140533
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x00143323 File Offset: 0x00141523
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x0014335A File Offset: 0x0014155A
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x0014337E File Offset: 0x0014157E
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x001433B5 File Offset: 0x001415B5
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600419E RID: 16798 RVA: 0x001433DC File Offset: 0x001415DC
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 840f)
			{
				this.HBJJOCHGOPH = 107f;
			}
			this.LONNIJMNKFB().SetFloat("LevelNameText", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1943f, 862f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x00143484 File Offset: 0x00141684
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1250f)
			{
				this.HBJJOCHGOPH = 824f;
			}
			this.CECICEGFHKL().SetFloat("curScn", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1806f, 1148f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x0014352C File Offset: 0x0014172C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1868f)
			{
				this.HBJJOCHGOPH = 1103f;
			}
			this.KHCLIAMBBNC().SetFloat("Source Object: ", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1045f, 1271f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x060041A2 RID: 16802 RVA: 0x001435D3 File Offset: 0x001417D3
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041A3 RID: 16803 RVA: 0x001435F8 File Offset: 0x001417F8
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1115f)
			{
				this.HBJJOCHGOPH = 373f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetVector("RB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1108f, 1104f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041A4 RID: 16804 RVA: 0x0014369F File Offset: 0x0014189F
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041A5 RID: 16805 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x060041A6 RID: 16806 RVA: 0x00142333 File Offset: 0x00140533
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041A7 RID: 16807 RVA: 0x00142333 File Offset: 0x00140533
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041A8 RID: 16808 RVA: 0x001436D6 File Offset: 0x001418D6
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_superDot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060041AA RID: 16810 RVA: 0x00142333 File Offset: 0x00140533
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041AB RID: 16811 RVA: 0x001436FA File Offset: 0x001418FA
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find(" SecondsBeforeRespawn: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041AC RID: 16812 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060041AD RID: 16813 RVA: 0x00143720 File Offset: 0x00141920
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 1239f;
			}
			this.HCGJCMDJPGD().SetFloat("Set sun emission (glow)", this.HBJJOCHGOPH);
			this.MPENCEIGLEH().SetVector("_DiffuseColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 630f, 1492f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041AE RID: 16814 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060041AF RID: 16815 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x060041B0 RID: 16816 RVA: 0x001437C8 File Offset: 0x001419C8
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1147f)
			{
				this.HBJJOCHGOPH = 1963f;
			}
			this.IFMAPIDFNLI().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1093f, 1521f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041B1 RID: 16817 RVA: 0x00142333 File Offset: 0x00140533
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041B2 RID: 16818 RVA: 0x00143870 File Offset: 0x00141A70
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1057f)
			{
				this.HBJJOCHGOPH = 1827f;
			}
			this.FOOCJIDNGBB().SetFloat("</color>", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetVector("RemoveEnvironmentObject", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 152f, 1554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040006E9 RID: 1769
	public Shader SCShader;

	// Token: 0x040006EA RID: 1770
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006EB RID: 1771
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006EC RID: 1772
	private Material BJFKDHHMLJH;
}
