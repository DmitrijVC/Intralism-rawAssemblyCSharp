using System;
using UnityEngine;

// Token: 0x02000090 RID: 144
[AddComponentMenu("Camera Filter Pack/Distortion/Noise")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Noise : MonoBehaviour
{
	// Token: 0x060029E6 RID: 10726 RVA: 0x000E568A File Offset: 0x000E388A
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029E7 RID: 10727 RVA: 0x000E568A File Offset: 0x000E388A
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x000E568A File Offset: 0x000E388A
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029EA RID: 10730 RVA: 0x000E56A7 File Offset: 0x000E38A7
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x000E56DE File Offset: 0x000E38DE
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029EC RID: 10732 RVA: 0x000E5702 File Offset: 0x000E3902
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("settings.selectormapsperpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x000E5728 File Offset: 0x000E3928
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 637f)
			{
				this.HBJJOCHGOPH = 1831f;
			}
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("Set particles size", this.Distortion);
			this.JIBOKBCPDLC().SetVector("_Value8", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029EE RID: 10734 RVA: 0x000E57DE File Offset: 0x000E39DE
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029EF RID: 10735 RVA: 0x000E568A File Offset: 0x000E388A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029F0 RID: 10736 RVA: 0x000E568A File Offset: 0x000E388A
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029F1 RID: 10737 RVA: 0x000E5815 File Offset: 0x000E3A15
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029F2 RID: 10738 RVA: 0x000E568A File Offset: 0x000E388A
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029F3 RID: 10739 RVA: 0x000E584C File Offset: 0x000E3A4C
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029F4 RID: 10740 RVA: 0x000E5883 File Offset: 0x000E3A83
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029F5 RID: 10741 RVA: 0x000E568A File Offset: 0x000E388A
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029F6 RID: 10742 RVA: 0x000E58A7 File Offset: 0x000E3AA7
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029F7 RID: 10743 RVA: 0x000E58CB File Offset: 0x000E3ACB
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029F8 RID: 10744 RVA: 0x000E58F0 File Offset: 0x000E3AF0
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 847f)
			{
				this.HBJJOCHGOPH = 1879f;
			}
			this.EHDJJANLINB().SetFloat("float,1.5", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("#exitmapeditor", this.Distortion);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/AAA_Blood_Plus", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029F9 RID: 10745 RVA: 0x000E568A File Offset: 0x000E388A
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029FA RID: 10746 RVA: 0x000E568A File Offset: 0x000E388A
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x000E568A File Offset: 0x000E388A
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x000E59A6 File Offset: 0x000E3BA6
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("NewIconFileSelector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029FD RID: 10749 RVA: 0x000E59CA File Offset: 0x000E3BCA
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060029FF RID: 10751 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06002A00 RID: 10752 RVA: 0x000E5A04 File Offset: 0x000E3C04
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1141f)
			{
				this.HBJJOCHGOPH = 1731f;
			}
			this.MFHPKGICPIO().SetFloat("/", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("[Left]", this.Distortion);
			this.HFBJAOFLCJI().SetVector("ClearEnvironment", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A01 RID: 10753 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06002A02 RID: 10754 RVA: 0x000E5ABC File Offset: 0x000E3CBC
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1929f)
			{
				this.HBJJOCHGOPH = 1872f;
			}
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Vision_Psycho", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("GlassDistortion", this.Distortion);
			this.FAIFBBGFAIB().SetVector("\n", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A03 RID: 10755 RVA: 0x000E5B72 File Offset: 0x000E3D72
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A04 RID: 10756 RVA: 0x000E568A File Offset: 0x000E388A
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A05 RID: 10757 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06002A06 RID: 10758 RVA: 0x000E5BA9 File Offset: 0x000E3DA9
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find(". No ViewIDs are free to use. Max is: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A07 RID: 10759 RVA: 0x000E5BCD File Offset: 0x000E3DCD
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x000E5C04 File Offset: 0x000E3E04
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A09 RID: 10761 RVA: 0x000E5C3C File Offset: 0x000E3E3C
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1586f)
			{
				this.HBJJOCHGOPH = 506f;
			}
			this.FLOHGDECHHH().SetFloat("Items/", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Distortion);
			this.CFCPHFMKHII().SetVector("win", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A0A RID: 10762 RVA: 0x000E5CF2 File Offset: 0x000E3EF2
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x000E5D29 File Offset: 0x000E3F29
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x000E5D4D File Offset: 0x000E3F4D
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x000E5D84 File Offset: 0x000E3F84
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1327f)
			{
				this.HBJJOCHGOPH = 756f;
			}
			this.NJDIODJNGGA().SetFloat("#no", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("master", this.Distortion);
			this.MFHPKGICPIO().SetVector("ViewMenu", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x000E5E3C File Offset: 0x000E403C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 419f)
			{
				this.HBJJOCHGOPH = 312f;
			}
			this.FLOHGDECHHH().SetFloat(" elements", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("PublishButton", this.Distortion);
			this.NBPKMLMCHFN.SetVector(" not exist", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x000E5EF2 File Offset: 0x000E40F2
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("tagElement");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A11 RID: 10769 RVA: 0x000E5F16 File Offset: 0x000E4116
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x000E568A File Offset: 0x000E388A
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06002A14 RID: 10772 RVA: 0x000E5F4D File Offset: 0x000E414D
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("ItemNameBGImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x000E568A File Offset: 0x000E388A
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A16 RID: 10774 RVA: 0x000E5F74 File Offset: 0x000E4174
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 13f)
			{
				this.HBJJOCHGOPH = 922f;
			}
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("Set Particles Emission", this.Distortion);
			this.MICHFGAOPKM().SetVector("Done!", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A17 RID: 10775 RVA: 0x000E568A File Offset: 0x000E388A
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A18 RID: 10776 RVA: 0x000E602A File Offset: 0x000E422A
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x000E568A File Offset: 0x000E388A
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A1B RID: 10779 RVA: 0x000E568A File Offset: 0x000E388A
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A1C RID: 10780 RVA: 0x000E568A File Offset: 0x000E388A
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x000E606C File Offset: 0x000E426C
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A1E RID: 10782 RVA: 0x000E60A4 File Offset: 0x000E42A4
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 261f)
			{
				this.HBJJOCHGOPH = 1788f;
			}
			this.FLOHGDECHHH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat(" connected: ", this.Distortion);
			this.ACHNOHCLGOO().SetVector("CameraFilterPack/FX_Mirror", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x000E568A File Offset: 0x000E388A
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A20 RID: 10784 RVA: 0x000E568A File Offset: 0x000E388A
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A21 RID: 10785 RVA: 0x000E615A File Offset: 0x000E435A
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("musicVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000E617E File Offset: 0x000E437E
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

	// Token: 0x06002A23 RID: 10787 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002A24 RID: 10788 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06002A25 RID: 10789 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06002A26 RID: 10790 RVA: 0x000E61B5 File Offset: 0x000E43B5
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A27 RID: 10791 RVA: 0x000E57DE File Offset: 0x000E39DE
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A28 RID: 10792 RVA: 0x000E568A File Offset: 0x000E388A
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A29 RID: 10793 RVA: 0x000E61EC File Offset: 0x000E43EC
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 473f)
			{
				this.HBJJOCHGOPH = 986f;
			}
			this.ACHNOHCLGOO().SetFloat("[Up]", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("Map: ", this.Distortion);
			this.CFCPHFMKHII().SetVector("_Blue_C", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A2A RID: 10794 RVA: 0x000E62A4 File Offset: 0x000E44A4
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1137f)
			{
				this.HBJJOCHGOPH = 1566f;
			}
			this.MFHPKGICPIO().SetFloat("#", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("float,1", this.Distortion);
			this.CFCPHFMKHII().SetVector("https://www.youtube.com/watch?v=cDVXukrKo74", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x000E635A File Offset: 0x000E455A
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("LastHighScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x000E568A File Offset: 0x000E388A
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A2D RID: 10797 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06002A2E RID: 10798 RVA: 0x000E568A File Offset: 0x000E388A
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A2F RID: 10799 RVA: 0x000E6380 File Offset: 0x000E4580
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A30 RID: 10800 RVA: 0x000E568A File Offset: 0x000E388A
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A31 RID: 10801 RVA: 0x000E6438 File Offset: 0x000E4638
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 152f)
			{
				this.HBJJOCHGOPH = 1480f;
			}
			this.MFHPKGICPIO().SetFloat("speed", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_TimeX", this.Distortion);
			this.MICHFGAOPKM().SetVector("CameraFilterPack/Colors_Threshold", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A32 RID: 10802 RVA: 0x000E64F0 File Offset: 0x000E46F0
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 93f)
			{
				this.HBJJOCHGOPH = 1399f;
			}
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack/Distortion_FishEye", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("editor.", this.Distortion);
			this.DOHGBNPMBKG().SetVector("pointBuffer", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A33 RID: 10803 RVA: 0x000E65A6 File Offset: 0x000E47A6
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A34 RID: 10804 RVA: 0x000E65CC File Offset: 0x000E47CC
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 1648f;
			}
			this.MICHFGAOPKM().SetFloat("[Up]", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_ReflectionBlur", this.Distortion);
			this.FAIFBBGFAIB().SetVector(".ogg", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A35 RID: 10805 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06002A36 RID: 10806 RVA: 0x000E568A File Offset: 0x000E388A
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06002A38 RID: 10808 RVA: 0x000E6682 File Offset: 0x000E4882
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("The observed monobehaviour (");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x000E66A6 File Offset: 0x000E48A6
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A3A RID: 10810 RVA: 0x000E66CA File Offset: 0x000E48CA
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000512 RID: 1298
	public Shader SCShader;

	// Token: 0x04000513 RID: 1299
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000514 RID: 1300
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000515 RID: 1301
	private Material BJFKDHHMLJH;

	// Token: 0x04000516 RID: 1302
	[Range(0f, 3f)]
	public float Distortion = 1f;
}
