using System;
using UnityEngine;

// Token: 0x0200010D RID: 269
[AddComponentMenu("Camera Filter Pack/TV/80s")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_80 : MonoBehaviour
{
	// Token: 0x060053AF RID: 21423 RVA: 0x0002523B File Offset: 0x0002343B
	private void MGMAOBPPOBJ()
	{
	}

	// Token: 0x060053B0 RID: 21424 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060053B1 RID: 21425 RVA: 0x0019FF35 File Offset: 0x0019E135
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053B2 RID: 21426 RVA: 0x0002523B File Offset: 0x0002343B
	private void DIPDEHOOBPG()
	{
	}

	// Token: 0x060053B3 RID: 21427 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060053B4 RID: 21428 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053B5 RID: 21429 RVA: 0x0019FF8C File Offset: 0x0019E18C
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 137f)
			{
				this.HBJJOCHGOPH = 1946f;
			}
			this.LNLKMDPHDCC().SetFloat("Right Click", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", this.Fade);
			this.JLHLHKPHDFO().SetVector("</color>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1993f, 701f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053B6 RID: 21430 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060053B7 RID: 21431 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060053B8 RID: 21432 RVA: 0x001A0049 File Offset: 0x0019E249
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053B9 RID: 21433 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060053BA RID: 21434 RVA: 0x001A0080 File Offset: 0x0019E280
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 715f)
			{
				this.HBJJOCHGOPH = 429f;
			}
			this.FLOHGDECHHH().SetFloat("BlockCount", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("|", this.Fade);
			this.JIBOKBCPDLC().SetVector("ShowTitle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 486f, 478f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053BB RID: 21435 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x060053BC RID: 21436 RVA: 0x001A0140 File Offset: 0x0019E340
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 346f)
			{
				this.HBJJOCHGOPH = 1236f;
			}
			this.BKKJJJGADLM().SetFloat("getint", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("MapEnd", this.Fade);
			this.CFEDGDGBCHE().SetVector("[ItemsHandler] All in-game items loaded", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 277f, 732f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053BD RID: 21437 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053BE RID: 21438 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCNPAKFAFOE()
	{
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060053BF RID: 21439 RVA: 0x001A01FD File Offset: 0x0019E3FD
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

	// Token: 0x060053C0 RID: 21440 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060053C1 RID: 21441 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHANGPCOCIG()
	{
	}

	// Token: 0x060053C2 RID: 21442 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMPGIFBJFIK()
	{
	}

	// Token: 0x060053C3 RID: 21443 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053C4 RID: 21444 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053C5 RID: 21445 RVA: 0x001A0234 File Offset: 0x0019E434
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1984f)
			{
				this.HBJJOCHGOPH = 825f;
			}
			this.FHFLKLMFHOI().SetFloat("red", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.Fade);
			this.NBPKMLMCHFN.SetVector("UseScanLineSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1713f, 753f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053C6 RID: 21446 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFFCLAHMBAA()
	{
	}

	// Token: 0x060053C9 RID: 21449 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANCKKLFPGDI()
	{
	}

	// Token: 0x060053CA RID: 21450 RVA: 0x001A02F1 File Offset: 0x0019E4F1
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053CB RID: 21451 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMCPMOGKDEH()
	{
	}

	// Token: 0x060053CD RID: 21453 RVA: 0x0002523B File Offset: 0x0002343B
	private void LIBGAKMKHJJ()
	{
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x001A0328 File Offset: 0x0019E528
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053CF RID: 21455 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x060053D1 RID: 21457 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCCIEMBMOBA()
	{
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053D4 RID: 21460 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053D5 RID: 21461 RVA: 0x001A037D File Offset: 0x0019E57D
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053D6 RID: 21462 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053D8 RID: 21464 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060053D9 RID: 21465 RVA: 0x001A03B4 File Offset: 0x0019E5B4
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x060053DB RID: 21467 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053DC RID: 21468 RVA: 0x001A03EB File Offset: 0x0019E5EB
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053DD RID: 21469 RVA: 0x0002523B File Offset: 0x0002343B
	private void ILCFPCIPENO()
	{
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060053DF RID: 21471 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053E0 RID: 21472 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060053E1 RID: 21473 RVA: 0x001A0422 File Offset: 0x0019E622
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053E2 RID: 21474 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060053E3 RID: 21475 RVA: 0x001A0459 File Offset: 0x0019E659
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053E4 RID: 21476 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060053E5 RID: 21477 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060053E6 RID: 21478 RVA: 0x001A0490 File Offset: 0x0019E690
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053E7 RID: 21479 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053E8 RID: 21480 RVA: 0x001A04C7 File Offset: 0x0019E6C7
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053E9 RID: 21481 RVA: 0x0002523B File Offset: 0x0002343B
	private void FMNPFCHBLJF()
	{
	}

	// Token: 0x060053EA RID: 21482 RVA: 0x0002523B File Offset: 0x0002343B
	private void CCLNNLCOPBL()
	{
	}

	// Token: 0x060053EB RID: 21483 RVA: 0x001A04FE File Offset: 0x0019E6FE
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053EC RID: 21484 RVA: 0x001A0535 File Offset: 0x0019E735
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053ED RID: 21485 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053EE RID: 21486 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053EF RID: 21487 RVA: 0x001A056C File Offset: 0x0019E76C
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053F0 RID: 21488 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x001A062C File Offset: 0x0019E82C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 531f)
			{
				this.HBJJOCHGOPH = 1982f;
			}
			this.KJMECMIGJJA().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this.Fade);
			this.JIBOKBCPDLC().SetVector("z", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1921f, 183f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x001A06EC File Offset: 0x0019E8EC
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 478f)
			{
				this.HBJJOCHGOPH = 1345f;
			}
			this.IONHGBPGCHK().SetFloat("[Down]", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("PlayButton", this.Fade);
			this.CFEDGDGBCHE().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 858f, 1096f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x0002523B File Offset: 0x0002343B
	private void DBLILJGKGHJ()
	{
	}

	// Token: 0x060053F4 RID: 21492 RVA: 0x001A07A9 File Offset: 0x0019E9A9
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053F5 RID: 21493 RVA: 0x001A07E0 File Offset: 0x0019E9E0
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1707f)
			{
				this.HBJJOCHGOPH = 1230f;
			}
			this.CFEDGDGBCHE().SetFloat("<b><i>Map's Stats:</i></b>", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_TimeX", this.Fade);
			this.GCDFNHMJMIP().SetVector("settings.fps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 597f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x001A08A0 File Offset: 0x0019EAA0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 624f)
			{
				this.HBJJOCHGOPH = 847f;
			}
			this.NBPKMLMCHFN.SetFloat("powerup.1", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_FgOverlap", this.Fade);
			this.FLOHGDECHHH().SetVector("Reset XP", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 911f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060053F9 RID: 21497 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x001A095D File Offset: 0x0019EB5D
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060053FD RID: 21501 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053FE RID: 21502 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053FF RID: 21503 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005400 RID: 21504 RVA: 0x001A0994 File Offset: 0x0019EB94
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1687f)
			{
				this.HBJJOCHGOPH = 1228f;
			}
			this.FEAEGGCNIAA().SetFloat("SetParticlesParticleSpeed", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("HH:mm:ss", this.Fade);
			this.BKKJJJGADLM().SetVector("ready", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 614f, 1956f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005401 RID: 21505 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005402 RID: 21506 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06005403 RID: 21507 RVA: 0x0002523B File Offset: 0x0002343B
	private void CIPKEPDELJB()
	{
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06005405 RID: 21509 RVA: 0x0019FF6C File Offset: 0x0019E16C
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x0002523B File Offset: 0x0002343B
	private void HAIAHJPCPAG()
	{
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06005408 RID: 21512 RVA: 0x001A0A54 File Offset: 0x0019EC54
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 346f)
			{
				this.HBJJOCHGOPH = 339f;
			}
			this.LNLKMDPHDCC().SetFloat("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button12", this.Fade);
			this.BKKJJJGADLM().SetVector("_VignetteTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1309f, 1426f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x001A0B14 File Offset: 0x0019ED14
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1545f)
			{
				this.HBJJOCHGOPH = 1326f;
			}
			this.NBPKMLMCHFN.SetFloat("-help", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("_FarCamera", this.Fade);
			this.FLOHGDECHHH().SetVector("CameraFilterPack_OldFilm1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 27f, 878f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040008C0 RID: 2240
	public Shader SCShader;

	// Token: 0x040008C1 RID: 2241
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008C2 RID: 2242
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008C3 RID: 2243
	private Material BJFKDHHMLJH;

	// Token: 0x040008C4 RID: 2244
	[Range(0f, 1f)]
	public float Fade = 1f;
}
