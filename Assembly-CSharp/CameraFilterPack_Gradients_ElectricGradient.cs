using System;
using UnityEngine;

// Token: 0x020000E3 RID: 227
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Gradients/Electric")]
public class CameraFilterPack_Gradients_ElectricGradient : MonoBehaviour
{
	// Token: 0x06004566 RID: 17766 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06004567 RID: 17767 RVA: 0x00157509 File Offset: 0x00155709
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004568 RID: 17768 RVA: 0x00157526 File Offset: 0x00155726
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600456A RID: 17770 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x0600456B RID: 17771 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600456C RID: 17772 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x0015754B File Offset: 0x0015574B
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x0600456E RID: 17774 RVA: 0x00157570 File Offset: 0x00155770
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

	// Token: 0x0600456F RID: 17775 RVA: 0x001575A7 File Offset: 0x001557A7
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06004571 RID: 17777 RVA: 0x00157509 File Offset: 0x00155709
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x001575E0 File Offset: 0x001557E0
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1114f)
			{
				this.HBJJOCHGOPH = 941f;
			}
			this.LDNADDJMIPK().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_MidGrey", this.Switch);
			this.FHFLKLMFHOI().SetFloat("Set Particles Speed", this.Fade);
			this.FHFLKLMFHOI().SetVector("LoadMapCanvas", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 470f, 975f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004573 RID: 17779 RVA: 0x001576B4 File Offset: 0x001558B4
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 758f)
			{
				this.HBJJOCHGOPH = 1219f;
			}
			this.DBOLLHHMKKN().SetFloat("_Vignette", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", this.Switch);
			this.MCDGIILBNIF().SetFloat("GlassColor", this.Fade);
			this.HHIAIGCAHDA().SetVector("https://discord.gg/intralism", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1056f, 187f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x0015754B File Offset: 0x0015574B
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x0015754B File Offset: 0x0015574B
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x0015754B File Offset: 0x0015574B
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004577 RID: 17783 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x00157526 File Offset: 0x00155726
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x00157787 File Offset: 0x00155987
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x001577BE File Offset: 0x001559BE
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x001577F5 File Offset: 0x001559F5
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x0015782C File Offset: 0x00155A2C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 549f)
			{
				this.HBJJOCHGOPH = 1090f;
			}
			this.MCDGIILBNIF().SetFloat(" ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Parameter levelId must be int or string!", this.Switch);
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack/Colors_Threshold", this.Fade);
			this.FHFLKLMFHOI().SetVector("_TempTexture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1670f, 1851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x00157509 File Offset: 0x00155709
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x00157509 File Offset: 0x00155709
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x00157509 File Offset: 0x00155709
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004581 RID: 17793 RVA: 0x00157934 File Offset: 0x00155B34
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 336f)
			{
				this.HBJJOCHGOPH = 947f;
			}
			this.HHIAIGCAHDA().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_Intensity", this.Switch);
			this.ABHDNGIHBKE().SetFloat("_Visualize", this.Fade);
			this.NBPKMLMCHFN.SetVector("Left", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1264f, 1591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004582 RID: 17794 RVA: 0x00157A08 File Offset: 0x00155C08
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 770f)
			{
				this.HBJJOCHGOPH = 685f;
			}
			this.HCGJCMDJPGD().SetFloat(".completed", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("Default UI Material", this.Switch);
			this.MCDGIILBNIF().SetFloat("_Value3", this.Fade);
			this.FHFLKLMFHOI().SetVector(" b.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1707f, 1604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004583 RID: 17795 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06004584 RID: 17796 RVA: 0x0015754B File Offset: 0x0015574B
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004585 RID: 17797 RVA: 0x0015754B File Offset: 0x0015574B
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004586 RID: 17798 RVA: 0x00157509 File Offset: 0x00155709
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004587 RID: 17799 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06004588 RID: 17800 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06004589 RID: 17801 RVA: 0x00157ADB File Offset: 0x00155CDB
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600458A RID: 17802 RVA: 0x00157B12 File Offset: 0x00155D12
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600458B RID: 17803 RVA: 0x0015754B File Offset: 0x0015574B
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600458C RID: 17804 RVA: 0x00157B4C File Offset: 0x00155D4C
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 124f)
			{
				this.HBJJOCHGOPH = 77f;
			}
			this.FEAEGGCNIAA().SetFloat("w", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", this.Switch);
			this.NBPKMLMCHFN.SetFloat("VoteUpToggle", this.Fade);
			this.DBOLLHHMKKN().SetVector(" PhotonNetwork.networkingPeer.AvailableRegions ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 67f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600458D RID: 17805 RVA: 0x0015754B File Offset: 0x0015574B
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600458E RID: 17806 RVA: 0x00157509 File Offset: 0x00155709
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600458F RID: 17807 RVA: 0x0015754B File Offset: 0x0015574B
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004590 RID: 17808 RVA: 0x00157C20 File Offset: 0x00155E20
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1563f)
			{
				this.HBJJOCHGOPH = 1669f;
			}
			this.HCGJCMDJPGD().SetFloat("0 - default, 1 - left, 2 - right", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Switch);
			this.HHIAIGCAHDA().SetFloat("NEW", this.Fade);
			this.NBPKMLMCHFN.SetVector("_AlphaUV", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 520f, 681f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x00157509 File Offset: 0x00155709
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x00157CF4 File Offset: 0x00155EF4
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1561f)
			{
				this.HBJJOCHGOPH = 1492f;
			}
			this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", this.Switch);
			this.FHFLKLMFHOI().SetFloat("skins", this.Fade);
			this.LDNADDJMIPK().SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1775f, 1129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x00157DC8 File Offset: 0x00155FC8
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1076f)
			{
				this.HBJJOCHGOPH = 106f;
			}
			this.HHIAIGCAHDA().SetFloat("OK", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("_NeutralTonemapperParams2", this.Switch);
			this.HHIAIGCAHDA().SetFloat("NO", this.Fade);
			this.ABHDNGIHBKE().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1521f, 1951f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004596 RID: 17814 RVA: 0x00157E9C File Offset: 0x0015609C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1230f)
			{
				this.HBJJOCHGOPH = 1985f;
			}
			this.NBPKMLMCHFN.SetFloat("[LocalizationService] Loading file: ", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("speed", this.Switch);
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.Fade);
			this.ABHDNGIHBKE().SetVector("_SoftZDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1068f, 1082f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004597 RID: 17815 RVA: 0x00157F6F File Offset: 0x0015616F
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x0015754B File Offset: 0x0015574B
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x0015754B File Offset: 0x0015574B
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x00157509 File Offset: 0x00155709
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600459B RID: 17819 RVA: 0x00157509 File Offset: 0x00155709
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x00157509 File Offset: 0x00155709
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600459E RID: 17822 RVA: 0x00157FA8 File Offset: 0x001561A8
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1494f)
			{
				this.HBJJOCHGOPH = 1090f;
			}
			this.FHFLKLMFHOI().SetFloat(" has ", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("ItemNameText", this.Switch);
			this.HHIAIGCAHDA().SetFloat(" ", this.Fade);
			this.DBOLLHHMKKN().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1698f, 1656f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600459F RID: 17823 RVA: 0x0015807C File Offset: 0x0015627C
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

	// Token: 0x060045A0 RID: 17824 RVA: 0x0015754B File Offset: 0x0015574B
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x00157509 File Offset: 0x00155709
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x00157509 File Offset: 0x00155709
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x0015754B File Offset: 0x0015574B
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045A5 RID: 17829 RVA: 0x0015754B File Offset: 0x0015574B
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060045A6 RID: 17830 RVA: 0x00157509 File Offset: 0x00155709
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060045A8 RID: 17832 RVA: 0x00157509 File Offset: 0x00155709
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045A9 RID: 17833 RVA: 0x00158150 File Offset: 0x00156350
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 445f)
			{
				this.HBJJOCHGOPH = 1408f;
			}
			this.ABHDNGIHBKE().SetFloat("LevelConfigButton", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack/Edge_Golden", this.Switch);
			this.FEAEGGCNIAA().SetFloat("Triangle", this.Fade);
			this.MCDGIILBNIF().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1266f, 457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x00158224 File Offset: 0x00156424
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 873f)
			{
				this.HBJJOCHGOPH = 766f;
			}
			this.NBPKMLMCHFN.SetFloat("EventMenu", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Anomaly_With_Obj", this.Switch);
			this.HHIAIGCAHDA().SetFloat("Failed to InstantiateSceneObject prefab:", this.Fade);
			this.HHIAIGCAHDA().SetVector("Down ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 621f, 1777f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045AB RID: 17835 RVA: 0x00157509 File Offset: 0x00155709
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045AC RID: 17836 RVA: 0x00157509 File Offset: 0x00155709
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x00157509 File Offset: 0x00155709
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045AE RID: 17838 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060045AF RID: 17839 RVA: 0x00157509 File Offset: 0x00155709
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045B0 RID: 17840 RVA: 0x001582F8 File Offset: 0x001564F8
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1920f)
			{
				this.HBJJOCHGOPH = 1991f;
			}
			this.LDNADDJMIPK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("Best region found in PlayerPrefs. Connecting to: ", this.Switch);
			this.HHIAIGCAHDA().SetFloat("Joystick1Button7", this.Fade);
			this.NBPKMLMCHFN.SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1860f, 1171f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x00157509 File Offset: 0x00155709
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045B2 RID: 17842 RVA: 0x001583CC File Offset: 0x001565CC
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 611f)
			{
				this.HBJJOCHGOPH = 641f;
			}
			this.NBPKMLMCHFN.SetFloat("MainThreadExecuter", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Item created: Id: ", this.Switch);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack_Broken_Screen1", this.Fade);
			this.DBOLLHHMKKN().SetVector("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1992f, 1043f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x00157509 File Offset: 0x00155709
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x00157526 File Offset: 0x00155726
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045B5 RID: 17845 RVA: 0x001584A0 File Offset: 0x001566A0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1902f)
			{
				this.HBJJOCHGOPH = 690f;
			}
			this.FHFLKLMFHOI().SetFloat("player.redarc", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("[PlayerBase] Loaded environment: ", this.Switch);
			this.HCGJCMDJPGD().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this.Fade);
			this.HCGJCMDJPGD().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 959f, 1351f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045B6 RID: 17846 RVA: 0x00157509 File Offset: 0x00155709
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060045B7 RID: 17847 RVA: 0x00157526 File Offset: 0x00155726
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060045B8 RID: 17848 RVA: 0x00158574 File Offset: 0x00156774
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 241f;
			}
			this.FHFLKLMFHOI().SetFloat("SpeedSlider", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Switch);
			this.LDNADDJMIPK().SetFloat("_Value3", this.Fade);
			this.DBOLLHHMKKN().SetVector("CameraFilterPack/Gradients_Hue", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1554f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045B9 RID: 17849 RVA: 0x00158648 File Offset: 0x00156848
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 736f)
			{
				this.HBJJOCHGOPH = 1023f;
			}
			this.HHIAIGCAHDA().SetFloat("[Right]", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_Value3", this.Switch);
			this.HCGJCMDJPGD().SetFloat("getfloat", this.Fade);
			this.DBOLLHHMKKN().SetVector("EndlessLoopsScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 357f, 1542f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060045BA RID: 17850 RVA: 0x0015871B File Offset: 0x0015691B
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400076F RID: 1903
	public Shader SCShader;

	// Token: 0x04000770 RID: 1904
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_ElectricGradient";

	// Token: 0x04000771 RID: 1905
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000772 RID: 1906
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000773 RID: 1907
	private Material BJFKDHHMLJH;

	// Token: 0x04000774 RID: 1908
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x04000775 RID: 1909
	[Range(0f, 1f)]
	public float Fade = 1f;
}
