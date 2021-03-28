using System;
using UnityEngine;

// Token: 0x020000F9 RID: 249
[AddComponentMenu("Camera Filter Pack/Noise/TV_3")]
[ExecuteInEditMode]
public class CameraFilterPack_Noise_TV_3 : MonoBehaviour
{
	// Token: 0x06004D47 RID: 19783 RVA: 0x00180C52 File Offset: 0x0017EE52
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("checkpoint") as Texture2D);
		this.SCShader = Shader.Find("Set EnvSprite Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D48 RID: 19784 RVA: 0x00180C8C File Offset: 0x0017EE8C
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 602f)
			{
				this.HBJJOCHGOPH = 1729f;
			}
			this.FKEOGPDLBDD().SetFloat(" or player:", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("[PlayerBase] ShowTitle error: ", this.Fade);
			this.IIBLJCKLGFG().SetFloat(".lastCheckpoint.powerupsScore", this.Fade_Additive);
			this.FKEOGPDLBDD().SetFloat("_MainTex2", this.Fade_Distortion);
			this.NBPKMLMCHFN.SetFloat("workshop.", this.CCIENBFIKKH);
			this.KJMECMIGJJA().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1128f, 1729f));
			this.LENEJAGLCNL().SetTexture("Music End", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D49 RID: 19785 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06004D4A RID: 19786 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06004D4B RID: 19787 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D4C RID: 19788 RVA: 0x00180DBE File Offset: 0x0017EFBE
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D4D RID: 19789 RVA: 0x00180DF8 File Offset: 0x0017EFF8
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 48f)
			{
				this.HBJJOCHGOPH = 415f;
			}
			this.OLHDPICFBOF().SetFloat("AudioSampler", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("workshop.txt", this.Fade);
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/TV_Chromatical2", this.Fade_Additive);
			this.NBPKMLMCHFN.SetFloat("LevelNameInputField", this.Fade_Distortion);
			this.ABHDNGIHBKE().SetFloat("No font defined. Found font: ", this.CCIENBFIKKH);
			this.EJDPNJAEAKJ().SetVector("CameraFilterPack_VHS2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1201f, 124f));
			this.LPCHMEKDCHI().SetTexture("float,0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D4E RID: 19790 RVA: 0x00180F10 File Offset: 0x0017F110
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1522f)
			{
				this.HBJJOCHGOPH = 376f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("PossibleMapMaxScoreText", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Game Version: ", this.Fade_Additive);
			this.EFMCNLELMDO().SetFloat("_ScreenResolution", this.Fade_Distortion);
			this.LENEJAGLCNL().SetFloat("y", this.CCIENBFIKKH);
			this.KOHGPKOFEJO().SetVector("_Blue_B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 115f, 1643f));
			this.KOHGPKOFEJO().SetTexture("subscribeall", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D4F RID: 19791 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06004D50 RID: 19792 RVA: 0x00181028 File Offset: 0x0017F228
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 827f)
			{
				this.HBJJOCHGOPH = 1348f;
			}
			this.HKGAONMOBMH().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("event", this.Fade);
			this.LPCHMEKDCHI().SetFloat("???", this.Fade_Additive);
			this.DONENAMLFLF().SetFloat("_FgCocMask", this.Fade_Distortion);
			this.IIBLJCKLGFG().SetFloat("#", this.CCIENBFIKKH);
			this.HNFFHCLNBDN().SetVector("note.7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1945f, 282f));
			this.FKEOGPDLBDD().SetTexture("<start_index> <end_index>", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D51 RID: 19793 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004D52 RID: 19794 RVA: 0x0018113D File Offset: 0x0017F33D
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D53 RID: 19795 RVA: 0x00181174 File Offset: 0x0017F374
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 513f)
			{
				this.HBJJOCHGOPH = 595f;
			}
			this.PGPEMMBJOOG().SetFloat("_Line", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_SecondTex", this.Fade);
			this.LENEJAGLCNL().SetFloat("request", this.Fade_Additive);
			this.LENEJAGLCNL().SetFloat("Committing changes...", this.Fade_Distortion);
			this.NDMPCDHADMJ().SetFloat("_Value5", this.CCIENBFIKKH);
			this.OLHDPICFBOF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1589f, 1066f));
			this.PGPEMMBJOOG().SetTexture("_Near", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D54 RID: 19796 RVA: 0x00181289 File Offset: 0x0017F489
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("Changed config");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D55 RID: 19797 RVA: 0x001812C2 File Offset: 0x0017F4C2
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D56 RID: 19798 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D57 RID: 19799 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06004D58 RID: 19800 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D59 RID: 19801 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06004D5A RID: 19802 RVA: 0x001812F9 File Offset: 0x0017F4F9
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D5B RID: 19803 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D5C RID: 19804 RVA: 0x00181330 File Offset: 0x0017F530
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1286f)
			{
				this.HBJJOCHGOPH = 1489f;
			}
			this.ADBKPGFMNKO().SetFloat(".highscore", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", this.Fade);
			this.KDMBOKLMADJ().SetFloat("_TimeX", this.Fade_Additive);
			this.KOHGPKOFEJO().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", this.Fade_Distortion);
			this.NBPKMLMCHFN.SetFloat("menu.hardcoreinfo", this.CCIENBFIKKH);
			this.KOHGPKOFEJO().SetVector("BadgeText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 634f, 1775f));
			this.ABHDNGIHBKE().SetTexture("player.xp", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D5D RID: 19805 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06004D5E RID: 19806 RVA: 0x00181445 File Offset: 0x0017F645
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Distortion") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D5F RID: 19807 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06004D60 RID: 19808 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06004D61 RID: 19809 RVA: 0x0018147E File Offset: 0x0017F67E
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D62 RID: 19810 RVA: 0x001814B8 File Offset: 0x0017F6B8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade_Additive);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Fade_Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D63 RID: 19811 RVA: 0x001815CD File Offset: 0x0017F7CD
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D64 RID: 19812 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D65 RID: 19813 RVA: 0x00181604 File Offset: 0x0017F804
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("Beat Detected") as Texture2D);
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D66 RID: 19814 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D67 RID: 19815 RVA: 0x0018163D File Offset: 0x0017F83D
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D68 RID: 19816 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D69 RID: 19817 RVA: 0x00181674 File Offset: 0x0017F874
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1416f)
			{
				this.HBJJOCHGOPH = 544f;
			}
			this.LPCHMEKDCHI().SetFloat(": ", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("y", this.Fade);
			this.HKGAONMOBMH().SetFloat("Maps Editor v.", this.Fade_Additive);
			this.EJDPNJAEAKJ().SetFloat("menu.tabid", this.Fade_Distortion);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.PGPEMMBJOOG().SetVector("ConfigVersionSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 654f, 1568f));
			this.KOHGPKOFEJO().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D6A RID: 19818 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D6B RID: 19819 RVA: 0x0018178C File Offset: 0x0017F98C
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1724f)
			{
				this.HBJJOCHGOPH = 890f;
			}
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat(": ", this.Fade);
			this.HKGAONMOBMH().SetFloat("restart", this.Fade_Additive);
			this.IIJMIPBMMBF().SetFloat("/", this.Fade_Distortion);
			this.IIBLJCKLGFG().SetFloat("Editor/", this.CCIENBFIKKH);
			this.EFMCNLELMDO().SetVector("USE_DIAG_SEARCH", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1662f, 819f));
			this.PGPEMMBJOOG().SetTexture("_Red_R", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D6C RID: 19820 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004D6D RID: 19821 RVA: 0x001818A1 File Offset: 0x0017FAA1
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D6E RID: 19822 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D6F RID: 19823 RVA: 0x001818D8 File Offset: 0x0017FAD8
	private void AEDDNDHCLNN()
	{
		this.FPHEBLMINDA = (Resources.Load("Ev OwnershipRequest ") as Texture2D);
		this.SCShader = Shader.Find("Drop_With_Obj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D70 RID: 19824 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D71 RID: 19825 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D72 RID: 19826 RVA: 0x00181914 File Offset: 0x0017FB14
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 3f)
			{
				this.HBJJOCHGOPH = 1813f;
			}
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("setstring", this.Fade);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.Fade_Additive);
			this.LPCHMEKDCHI().SetFloat("_MainTex2", this.Fade_Distortion);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.HCGJCMDJPGD().SetVector(".completedMaps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1324f, 1830f));
			this.EFMCNLELMDO().SetTexture("ItemNameText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D73 RID: 19827 RVA: 0x00181A29 File Offset: 0x0017FC29
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("PublishButton") as Texture2D);
		this.SCShader = Shader.Find("settings.arcsdestroydelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D74 RID: 19828 RVA: 0x00181A64 File Offset: 0x0017FC64
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 484f)
			{
				this.HBJJOCHGOPH = 1958f;
			}
			this.NDMPCDHADMJ().SetFloat("resource id", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_TimeX", this.Fade);
			this.NBPKMLMCHFN.SetFloat("ClearEnvironment", this.Fade_Additive);
			this.LENEJAGLCNL().SetFloat("Gameplay/satellite", this.Fade_Distortion);
			this.ABHDNGIHBKE().SetFloat("float,0.5", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1492f, 591f));
			this.HKGAONMOBMH().SetTexture("COMPLETED", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D75 RID: 19829 RVA: 0x00181B79 File Offset: 0x0017FD79
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("DifficultyBG") as Texture2D);
		this.SCShader = Shader.Find("_History2LumaTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D76 RID: 19830 RVA: 0x00181BB2 File Offset: 0x0017FDB2
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D77 RID: 19831 RVA: 0x00181BEC File Offset: 0x0017FDEC
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1072f)
			{
				this.HBJJOCHGOPH = 646f;
			}
			this.LENEJAGLCNL().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_TimeX", this.Fade);
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/Color_Noise", this.Fade_Additive);
			this.IIBLJCKLGFG().SetFloat("Hidden/Image Effects/Cinematic/Bloom", this.Fade_Distortion);
			this.FKEOGPDLBDD().SetFloat("JoinButton", this.CCIENBFIKKH);
			this.LENEJAGLCNL().SetVector("In Network lobby", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1170f, 1641f));
			this.PDEAHJPOMEF().SetTexture("[Right]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D78 RID: 19832 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D79 RID: 19833 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06004D7A RID: 19834 RVA: 0x00181D01 File Offset: 0x0017FF01
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D7B RID: 19835 RVA: 0x00181D38 File Offset: 0x0017FF38
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_Noise3") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Noise_TV_3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D7C RID: 19836 RVA: 0x00181D71 File Offset: 0x0017FF71
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D7D RID: 19837 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D7E RID: 19838 RVA: 0x00181DA8 File Offset: 0x0017FFA8
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D7F RID: 19839 RVA: 0x00181DDF File Offset: 0x0017FFDF
	private void KMCPMOGKDEH()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.selectormapsperpage") as Texture2D);
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D80 RID: 19840 RVA: 0x00181E18 File Offset: 0x00180018
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 679f)
			{
				this.HBJJOCHGOPH = 403f;
			}
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack_3D_Computer1", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_TimeX", this.Fade);
			this.OLHDPICFBOF().SetFloat("/", this.Fade_Additive);
			this.DONENAMLFLF().SetFloat("_Value11", this.Fade_Distortion);
			this.KDMBOKLMADJ().SetFloat("_Speed", this.CCIENBFIKKH);
			this.PGPEMMBJOOG().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1705f, 1959f));
			this.LPCHMEKDCHI().SetTexture("_BlurredColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D81 RID: 19841 RVA: 0x00181F2D File Offset: 0x0018012D
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D82 RID: 19842 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D83 RID: 19843 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06004D84 RID: 19844 RVA: 0x00181F64 File Offset: 0x00180164
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

	// Token: 0x06004D85 RID: 19845 RVA: 0x00181F9C File Offset: 0x0018019C
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 379f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			this.ADBKPGFMNKO().SetFloat("Joystick1Button11", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("_LutTex", this.Fade);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/FX_Drunk", this.Fade_Additive);
			this.KDMBOKLMADJ().SetFloat("BitsData", this.Fade_Distortion);
			this.HNFFHCLNBDN().SetFloat("maps.", this.CCIENBFIKKH);
			this.KDMBOKLMADJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 151f, 1040f));
			this.KOHGPKOFEJO().SetTexture("settings.showHP", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D86 RID: 19846 RVA: 0x001820B1 File Offset: 0x001802B1
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D87 RID: 19847 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06004D88 RID: 19848 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06004D89 RID: 19849 RVA: 0x001820E8 File Offset: 0x001802E8
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D8A RID: 19850 RVA: 0x0018211F File Offset: 0x0018031F
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D8B RID: 19851 RVA: 0x00182156 File Offset: 0x00180356
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load("visible") as Texture2D);
		this.SCShader = Shader.Find("Editing: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D8C RID: 19852 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06004D8D RID: 19853 RVA: 0x00182190 File Offset: 0x00180390
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 968f)
			{
				this.HBJJOCHGOPH = 1600f;
			}
			this.KJMECMIGJJA().SetFloat("Fade", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("&map=", this.Fade);
			this.IIJMIPBMMBF().SetFloat("_Near", this.Fade_Additive);
			this.IIJMIPBMMBF().SetFloat("history", this.Fade_Distortion);
			this.ADBKPGFMNKO().SetFloat(" not exist", this.CCIENBFIKKH);
			this.LPDOGGFOBDH().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 59f, 414f));
			this.PGPEMMBJOOG().SetTexture(" cannot be used as a 3D LUT.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D8E RID: 19854 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06004D8F RID: 19855 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06004D90 RID: 19856 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06004D91 RID: 19857 RVA: 0x001822A5 File Offset: 0x001804A5
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D92 RID: 19858 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06004D93 RID: 19859 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D94 RID: 19860 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D95 RID: 19861 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D96 RID: 19862 RVA: 0x001822DC File Offset: 0x001804DC
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D97 RID: 19863 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D98 RID: 19864 RVA: 0x00181F64 File Offset: 0x00180164
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D99 RID: 19865 RVA: 0x00182314 File Offset: 0x00180514
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 351f)
			{
				this.HBJJOCHGOPH = 487f;
			}
			this.DKNJGHFLAIF().SetFloat("Init", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("DPADVER", this.Fade);
			this.KOHGPKOFEJO().SetFloat("-", this.Fade_Additive);
			this.PDEAHJPOMEF().SetFloat("event", this.Fade_Distortion);
			this.OLHDPICFBOF().SetFloat("_Value2", this.CCIENBFIKKH);
			this.ABHDNGIHBKE().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 322f, 21f));
			this.OLHDPICFBOF().SetTexture("start", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D9A RID: 19866 RVA: 0x00182429 File Offset: 0x00180629
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D9B RID: 19867 RVA: 0x00182460 File Offset: 0x00180660
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D9C RID: 19868 RVA: 0x00182499 File Offset: 0x00180699
	private void FLKEJJEGCFA()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button2") as Texture2D);
		this.SCShader = Shader.Find("_EdgeThreshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D9D RID: 19869 RVA: 0x001824D4 File Offset: 0x001806D4
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1775f)
			{
				this.HBJJOCHGOPH = 896f;
			}
			this.OLHDPICFBOF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("inventory.selected.", this.Fade);
			this.NDMPCDHADMJ().SetFloat("#ok", this.Fade_Additive);
			this.FKEOGPDLBDD().SetFloat("/?player=", this.Fade_Distortion);
			this.KOHGPKOFEJO().SetFloat(" Owner called.", this.CCIENBFIKKH);
			this.LPDOGGFOBDH().SetVector("AddEnvironmentSprite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 569f, 1321f));
			this.ADBKPGFMNKO().SetTexture("Create failed on GameServer. Changing back to MasterServer. Msg: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D9E RID: 19870 RVA: 0x001825E9 File Offset: 0x001807E9
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D9F RID: 19871 RVA: 0x00182620 File Offset: 0x00180820
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("setbool") as Texture2D);
		this.SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DA0 RID: 19872 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06004DA1 RID: 19873 RVA: 0x0018265C File Offset: 0x0018085C
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1117f)
			{
				this.HBJJOCHGOPH = 1993f;
			}
			this.KJMECMIGJJA().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("_ColorRGB", this.Fade);
			this.PDEAHJPOMEF().SetFloat("_BlurDirectionPacked", this.Fade_Additive);
			this.DONENAMLFLF().SetFloat("_Value", this.Fade_Distortion);
			this.EFMCNLELMDO().SetFloat("_Value2", this.CCIENBFIKKH);
			this.PGPEMMBJOOG().SetVector("Set crosshair color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 789f, 1947f));
			this.IIBLJCKLGFG().SetTexture("CameraFilterPack/FX_DigitalMatrix", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DA2 RID: 19874 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06004DA3 RID: 19875 RVA: 0x00182771 File Offset: 0x00180971
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("Right") as Texture2D);
		this.SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DA4 RID: 19876 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x06004DA5 RID: 19877 RVA: 0x001827AC File Offset: 0x001809AC
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 586f)
			{
				this.HBJJOCHGOPH = 1632f;
			}
			this.HCGJCMDJPGD().SetFloat("player.xp", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("_Value3", this.Fade);
			this.NDMPCDHADMJ().SetFloat("EventSystem", this.Fade_Additive);
			this.LENEJAGLCNL().SetFloat("[MenuScene] Error: ", this.Fade_Distortion);
			this.IIBLJCKLGFG().SetFloat("player.redabstract", this.CCIENBFIKKH);
			this.EFMCNLELMDO().SetVector("Right", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1526f, 1756f));
			this.IIJMIPBMMBF().SetTexture("EnableRankedNotificationsToggle", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DA6 RID: 19878 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06004DA7 RID: 19879 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06004DA8 RID: 19880 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DA9 RID: 19881 RVA: 0x001828C1 File Offset: 0x00180AC1
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DAA RID: 19882 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06004DAB RID: 19883 RVA: 0x001828F8 File Offset: 0x00180AF8
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DAD RID: 19885 RVA: 0x00182958 File Offset: 0x00180B58
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 668f)
			{
				this.HBJJOCHGOPH = 1202f;
			}
			this.EFMCNLELMDO().SetFloat("_BlurFilterDistance", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("Set satellite audio input", this.Fade);
			this.PDEAHJPOMEF().SetFloat("masterVolume", this.Fade_Additive);
			this.ABHDNGIHBKE().SetFloat("_Fade", this.Fade_Distortion);
			this.FKEOGPDLBDD().SetFloat("Editor/", this.CCIENBFIKKH);
			this.FKEOGPDLBDD().SetVector("Item creation successful! Published Item ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 99f, 828f));
			this.LDNADDJMIPK().SetTexture("_Offsets", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DAE RID: 19886 RVA: 0x00182A70 File Offset: 0x00180C70
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1799f)
			{
				this.HBJJOCHGOPH = 1259f;
			}
			this.DKNJGHFLAIF().SetFloat(" id: ", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("[MapsData] Bad map: ", this.Fade);
			this.OLHDPICFBOF().SetFloat("mapselector.lastSearch", this.Fade_Additive);
			this.LPCHMEKDCHI().SetFloat("_Distortion", this.Fade_Distortion);
			this.EJDPNJAEAKJ().SetFloat("_Offset", this.CCIENBFIKKH);
			this.FKEOGPDLBDD().SetVector("Joystick1Button3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1273f, 1334f));
			this.HNFFHCLNBDN().SetTexture("ENABLE_COLOR_GRADING", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DAF RID: 19887 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DB0 RID: 19888 RVA: 0x00182B85 File Offset: 0x00180D85
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load(" [") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DB1 RID: 19889 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06004DB2 RID: 19890 RVA: 0x00182BBE File Offset: 0x00180DBE
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DB3 RID: 19891 RVA: 0x00182BF8 File Offset: 0x00180DF8
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1374f)
			{
				this.HBJJOCHGOPH = 1072f;
			}
			this.PGPEMMBJOOG().SetFloat("offsets", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("_Offsets", this.Fade);
			this.DONENAMLFLF().SetFloat("settings.volume.menu", this.Fade_Additive);
			this.HKGAONMOBMH().SetFloat("#random #common #item", this.Fade_Distortion);
			this.KOHGPKOFEJO().SetFloat("Item invalid. No idea why.", this.CCIENBFIKKH);
			this.LPCHMEKDCHI().SetVector("CameraFilterPack/BlurTiltShift_Hole", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 879f, 32f));
			this.DKNJGHFLAIF().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DB4 RID: 19892 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DB5 RID: 19893 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DB6 RID: 19894 RVA: 0x00182D0D File Offset: 0x00180F0D
	private void ALJEJJCIMJN()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex") as Texture2D);
		this.SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DB7 RID: 19895 RVA: 0x00182D48 File Offset: 0x00180F48
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1093f)
			{
				this.HBJJOCHGOPH = 506f;
			}
			this.OLHDPICFBOF().SetFloat("menu.playedsolo", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Value3", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_SizeY", this.Fade_Additive);
			this.OLHDPICFBOF().SetFloat("_OcclusionTexture", this.Fade_Distortion);
			this.KDMBOKLMADJ().SetFloat(":", this.CCIENBFIKKH);
			this.ADBKPGFMNKO().SetVector("skin.hit_wrong", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1718f, 1922f));
			this.ADGHJOHKEHG().SetTexture("GlassAberration", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DB8 RID: 19896 RVA: 0x00182E60 File Offset: 0x00181060
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1628f)
			{
				this.HBJJOCHGOPH = 8f;
			}
			this.ADGHJOHKEHG().SetFloat("OpJoinLobby()", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/FX_Grid", this.Fade);
			this.FKEOGPDLBDD().SetFloat("ComboScoreText", this.Fade_Additive);
			this.ABHDNGIHBKE().SetFloat("SAVE", this.Fade_Distortion);
			this.DKNJGHFLAIF().SetFloat("0.00", this.CCIENBFIKKH);
			this.KOHGPKOFEJO().SetVector("Myst_Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1420f, 699f));
			this.OLHDPICFBOF().SetTexture("CameraFilterPack/Color_Convert_Normal", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DB9 RID: 19897 RVA: 0x00180DA1 File Offset: 0x0017EFA1
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DBA RID: 19898 RVA: 0x00182F75 File Offset: 0x00181175
	private void NKFDNIAKGEO()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button6") as Texture2D);
		this.SCShader = Shader.Find("HitInRelaxMusicToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0400082A RID: 2090
	public Shader SCShader;

	// Token: 0x0400082B RID: 2091
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400082C RID: 2092
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400082D RID: 2093
	private Material BJFKDHHMLJH;

	// Token: 0x0400082E RID: 2094
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400082F RID: 2095
	[Range(0f, 1f)]
	public float Fade_Additive;

	// Token: 0x04000830 RID: 2096
	[Range(0f, 1f)]
	public float Fade_Distortion;

	// Token: 0x04000831 RID: 2097
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

	// Token: 0x04000832 RID: 2098
	private Texture2D FPHEBLMINDA;
}
