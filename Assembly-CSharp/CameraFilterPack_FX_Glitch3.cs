using System;
using UnityEngine;

// Token: 0x020000CA RID: 202
[AddComponentMenu("Camera Filter Pack/Glitch/Glitch3")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Glitch3 : MonoBehaviour
{
	// Token: 0x06003D28 RID: 15656 RVA: 0x001329F1 File Offset: 0x00130BF1
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D29 RID: 15657 RVA: 0x00132A15 File Offset: 0x00130C15
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x00132A34 File Offset: 0x00130C34
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1847f)
			{
				this.HBJJOCHGOPH = 437f;
			}
			this.OKJOKHGJHGF().SetFloat("settings.arcsnohitsoundtimedelay", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("MaxLivesSlider", this._Glitch);
			this.OLHDPICFBOF().SetFloat("tagElement", this._Noise);
			this.ADAFMBOGPLN().SetVector("{0:0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 146f, 1488f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D2B RID: 15659 RVA: 0x00132B07 File Offset: 0x00130D07
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("workshop.txt");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06003D2D RID: 15661 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x00132A15 File Offset: 0x00130C15
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x00132A15 File Offset: 0x00130C15
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x00132B2B File Offset: 0x00130D2B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Glitch3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D31 RID: 15665 RVA: 0x00132B4F File Offset: 0x00130D4F
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D32 RID: 15666 RVA: 0x00132B86 File Offset: 0x00130D86
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D33 RID: 15667 RVA: 0x00132BC0 File Offset: 0x00130DC0
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 423f)
			{
				this.HBJJOCHGOPH = 1001f;
			}
			this.HHLFDHNEIAH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("_Axis", this._Glitch);
			this.LPMLLJKMAMP().SetFloat("_MainTex2", this._Noise);
			this.FEAEGGCNIAA().SetVector("LoadMapCanvas", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1897f, 340f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D34 RID: 15668 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06003D35 RID: 15669 RVA: 0x00132C93 File Offset: 0x00130E93
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D36 RID: 15670 RVA: 0x00132CCC File Offset: 0x00130ECC
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 98f)
			{
				this.HBJJOCHGOPH = 537f;
			}
			this.EHDJJANLINB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this._Glitch);
			this.FEAEGGCNIAA().SetFloat("_Exposure", this._Noise);
			this.FLOHGDECHHH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 91f, 952f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D37 RID: 15671 RVA: 0x00132D9F File Offset: 0x00130F9F
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D38 RID: 15672 RVA: 0x00132DD6 File Offset: 0x00130FD6
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D39 RID: 15673 RVA: 0x00132E10 File Offset: 0x00131010
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 916f)
			{
				this.HBJJOCHGOPH = 308f;
			}
			this.LDNADDJMIPK().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/Color_Switching", this._Glitch);
			this.GJHLADDCMFF().SetFloat("BadgeText", this._Noise);
			this.MMOODGIODPC().SetVector("ItemsUploader", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1739f, 46f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D3A RID: 15674 RVA: 0x00132EE3 File Offset: 0x001310E3
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D3B RID: 15675 RVA: 0x00132A15 File Offset: 0x00130C15
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D3C RID: 15676 RVA: 0x00132F1A File Offset: 0x0013111A
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D3D RID: 15677 RVA: 0x00132A15 File Offset: 0x00130C15
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D3E RID: 15678 RVA: 0x00132F54 File Offset: 0x00131154
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 78f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.EHDJJANLINB().SetFloat("_MatrixColor", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Currently, the limit of users is reached for this title. Try again later. Disconnecting", this._Glitch);
			this.DKKBFFHBHJE().SetFloat("?", this._Noise);
			this.MMOODGIODPC().SetVector("_Green_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 924f, 412f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D3F RID: 15679 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06003D40 RID: 15680 RVA: 0x00133027 File Offset: 0x00131227
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D41 RID: 15681 RVA: 0x00132A15 File Offset: 0x00130C15
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D42 RID: 15682 RVA: 0x0013305E File Offset: 0x0013125E
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find(".progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D43 RID: 15683 RVA: 0x00133082 File Offset: 0x00131282
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("score");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D44 RID: 15684 RVA: 0x00132A15 File Offset: 0x00130C15
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D45 RID: 15685 RVA: 0x001330A6 File Offset: 0x001312A6
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D46 RID: 15686 RVA: 0x001330E0 File Offset: 0x001312E0
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 438f)
			{
				this.HBJJOCHGOPH = 1845f;
			}
			this.OIMMPLPBLBK().SetFloat("_UserLutTex", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", this._Glitch);
			this.OHKGGPFGLFD().SetFloat("Checkpoint", this._Noise);
			this.LPMLLJKMAMP().SetVector("#yes", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 785f, 613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D47 RID: 15687 RVA: 0x001331B4 File Offset: 0x001313B4
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 291f)
			{
				this.HBJJOCHGOPH = 1815f;
			}
			this.DKNJGHFLAIF().SetFloat("#{0:00}{1}{2}", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("'{0}'{1}{2}", this._Glitch);
			this.PDEAHJPOMEF().SetFloat("AudioSampler", this._Noise);
			this.OHKGGPFGLFD().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 678f, 1374f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D48 RID: 15688 RVA: 0x00133287 File Offset: 0x00131487
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D49 RID: 15689 RVA: 0x001332BE File Offset: 0x001314BE
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find(" / ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06003D4A RID: 15690 RVA: 0x001332E2 File Offset: 0x001314E2
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

	// Token: 0x06003D4B RID: 15691 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003D4C RID: 15692 RVA: 0x00133319 File Offset: 0x00131519
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D4D RID: 15693 RVA: 0x0013333D File Offset: 0x0013153D
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D4E RID: 15694 RVA: 0x00132A15 File Offset: 0x00130C15
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D4F RID: 15695 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06003D50 RID: 15696 RVA: 0x00133374 File Offset: 0x00131574
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D51 RID: 15697 RVA: 0x001333AB File Offset: 0x001315AB
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("_MatrixSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D52 RID: 15698 RVA: 0x001333CF File Offset: 0x001315CF
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D53 RID: 15699 RVA: 0x00132A15 File Offset: 0x00130C15
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D54 RID: 15700 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003D55 RID: 15701 RVA: 0x00133408 File Offset: 0x00131608
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1160f)
			{
				this.HBJJOCHGOPH = 1575f;
			}
			this.NBPKMLMCHFN.SetFloat("settings_bindings_", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("ItemNameText", this._Glitch);
			this.NLFJGMBCICG().SetFloat("_TimeX", this._Noise);
			this.OLHDPICFBOF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1706f, 198f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D56 RID: 15702 RVA: 0x00132A15 File Offset: 0x00130C15
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D57 RID: 15703 RVA: 0x001334DC File Offset: 0x001316DC
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1357f)
			{
				this.HBJJOCHGOPH = 405f;
			}
			this.GJHLADDCMFF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("0.00", this._Glitch);
			this.DKNJGHFLAIF().SetFloat("GlassColor", this._Noise);
			this.EPCGJFCCAFH().SetVector("CameraFilterPack/FX_Glitch1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1273f, 1156f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D58 RID: 15704 RVA: 0x001335AF File Offset: 0x001317AF
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_DistortionSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D59 RID: 15705 RVA: 0x00132A15 File Offset: 0x00130C15
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D5A RID: 15706 RVA: 0x001335D4 File Offset: 0x001317D4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 1434f;
			}
			this.INOBFNCKFGK().SetFloat("CameraFilterPack/Colors_BleachBypass", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("/", this._Glitch);
			this.FAIFBBGFAIB().SetFloat("HighScaleShot", this._Noise);
			this.HHIFMIPPMPF().SetVector("inventory.lastitemscount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1062f, 1407f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D5B RID: 15707 RVA: 0x001336A7 File Offset: 0x001318A7
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D5C RID: 15708 RVA: 0x00132A15 File Offset: 0x00130C15
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D5D RID: 15709 RVA: 0x001336DE File Offset: 0x001318DE
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D5E RID: 15710 RVA: 0x00133715 File Offset: 0x00131915
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D5F RID: 15711 RVA: 0x0013373C File Offset: 0x0013193C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 546f)
			{
				this.HBJJOCHGOPH = 654f;
			}
			this.KBOPGONOCNP().SetFloat("Updating...", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_Value3", this._Glitch);
			this.DKNJGHFLAIF().SetFloat("offsets", this._Noise);
			this.KEMAALEODNH().SetVector("float,10", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1378f, 111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D60 RID: 15712 RVA: 0x00132A15 File Offset: 0x00130C15
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D61 RID: 15713 RVA: 0x0013380F File Offset: 0x00131A0F
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D62 RID: 15714 RVA: 0x00132A15 File Offset: 0x00130C15
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D63 RID: 15715 RVA: 0x00132A15 File Offset: 0x00130C15
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D64 RID: 15716 RVA: 0x00133846 File Offset: 0x00131A46
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D65 RID: 15717 RVA: 0x00132A15 File Offset: 0x00130C15
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D66 RID: 15718 RVA: 0x00132A15 File Offset: 0x00130C15
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D67 RID: 15719 RVA: 0x00133880 File Offset: 0x00131A80
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1566f)
			{
				this.HBJJOCHGOPH = 119f;
			}
			this.FEAEGGCNIAA().SetFloat("shader.frost", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("PLEASE WAIT", this._Glitch);
			this.KBOPGONOCNP().SetFloat("FreqVolume: ", this._Noise);
			this.FAIFBBGFAIB().SetVector("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1411f, 1980f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D68 RID: 15720 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06003D69 RID: 15721 RVA: 0x00132A15 File Offset: 0x00130C15
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D6A RID: 15722 RVA: 0x00133953 File Offset: 0x00131B53
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D6B RID: 15723 RVA: 0x0013398A File Offset: 0x00131B8A
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D6C RID: 15724 RVA: 0x001339C4 File Offset: 0x00131BC4
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 919f)
			{
				this.HBJJOCHGOPH = 156f;
			}
			this.INOBFNCKFGK().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Set Particle Size", this._Glitch);
			this.PDEAHJPOMEF().SetFloat(".lastCheckpoint.checkpointsUsed", this._Noise);
			this.ADAFMBOGPLN().SetVector("#timeuntilchallenge: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1362f, 1771f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D6D RID: 15725 RVA: 0x00133A97 File Offset: 0x00131C97
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D6E RID: 15726 RVA: 0x00132A15 File Offset: 0x00130C15
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D6F RID: 15727 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003D70 RID: 15728 RVA: 0x00133ACE File Offset: 0x00131CCE
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D71 RID: 15729 RVA: 0x00133B08 File Offset: 0x00131D08
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1862f)
			{
				this.HBJJOCHGOPH = 1824f;
			}
			this.INOBFNCKFGK().SetFloat("_Val2", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat(".highscore", this._Glitch);
			this.OIMMPLPBLBK().SetFloat("useSrcAlphaAsMask", this._Noise);
			this.PDEAHJPOMEF().SetVector("<b>#banended</b>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1044f, 1262f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D72 RID: 15730 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06003D73 RID: 15731 RVA: 0x00133BDB File Offset: 0x00131DDB
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D74 RID: 15732 RVA: 0x00132A15 File Offset: 0x00130C15
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D75 RID: 15733 RVA: 0x00132A15 File Offset: 0x00130C15
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D76 RID: 15734 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06003D77 RID: 15735 RVA: 0x00133C12 File Offset: 0x00131E12
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find(".sav");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D78 RID: 15736 RVA: 0x00132A15 File Offset: 0x00130C15
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D79 RID: 15737 RVA: 0x00133C36 File Offset: 0x00131E36
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D7A RID: 15738 RVA: 0x00133C5C File Offset: 0x00131E5C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 301f)
			{
				this.HBJJOCHGOPH = 1206f;
			}
			this.OLHDPICFBOF().SetFloat("Share", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("CameraFilterPack/Blur_Blurry", this._Glitch);
			this.GJHPODJOBHL().SetFloat("FileLabel", this._Noise);
			this.KBOPGONOCNP().SetVector("player.licenceaccepted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1986f, 1777f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D7B RID: 15739 RVA: 0x00133D2F File Offset: 0x00131F2F
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("settings.volume.menu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D7C RID: 15740 RVA: 0x00133D53 File Offset: 0x00131F53
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D7D RID: 15741 RVA: 0x00133D8C File Offset: 0x00131F8C
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
			this.NBPKMLMCHFN.SetFloat("_Glitch", this._Glitch);
			this.NBPKMLMCHFN.SetFloat("_Noise", this._Noise);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D7E RID: 15742 RVA: 0x00133E5F File Offset: 0x0013205F
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D7F RID: 15743 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06003D80 RID: 15744 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06003D81 RID: 15745 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06003D82 RID: 15746 RVA: 0x00133E84 File Offset: 0x00132084
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1546f)
			{
				this.HBJJOCHGOPH = 1976f;
			}
			this.KEMAALEODNH().SetFloat(" Remote called.", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_Offsets", this._Glitch);
			this.PDEAHJPOMEF().SetFloat("offsets", this._Noise);
			this.INOBFNCKFGK().SetVector("GlassesColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 769f, 1373f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D83 RID: 15747 RVA: 0x00132A15 File Offset: 0x00130C15
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D84 RID: 15748 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06003D85 RID: 15749 RVA: 0x00133F58 File Offset: 0x00132158
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 890f)
			{
				this.HBJJOCHGOPH = 1973f;
			}
			this.DKKBFFHBHJE().SetFloat("[LocalizationService] Loading file: ", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("RequestOwnership(): ", this._Glitch);
			this.INOBFNCKFGK().SetFloat("_ScreenResolution", this._Noise);
			this.OKJOKHGJHGF().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 718f, 559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D86 RID: 15750 RVA: 0x00132A15 File Offset: 0x00130C15
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x00132A15 File Offset: 0x00130C15
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D88 RID: 15752 RVA: 0x0013402C File Offset: 0x0013222C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 626f)
			{
				this.HBJJOCHGOPH = 356f;
			}
			this.ABHDNGIHBKE().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_Far", this._Glitch);
			this.HEINDEMCGIK().SetFloat("_ThirdTex", this._Noise);
			this.OHKGGPFGLFD().SetVector("SetSatelliteEmission", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1047f, 311f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D89 RID: 15753 RVA: 0x00132A15 File Offset: 0x00130C15
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D8A RID: 15754 RVA: 0x00132A15 File Offset: 0x00130C15
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D8B RID: 15755 RVA: 0x001340FF File Offset: 0x001322FF
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D8C RID: 15756 RVA: 0x00134123 File Offset: 0x00132323
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D8D RID: 15757 RVA: 0x00132A15 File Offset: 0x00130C15
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x00134147 File Offset: 0x00132347
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x0013417E File Offset: 0x0013237E
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D90 RID: 15760 RVA: 0x001341B5 File Offset: 0x001323B5
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D91 RID: 15761 RVA: 0x00132A15 File Offset: 0x00130C15
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D92 RID: 15762 RVA: 0x001341DC File Offset: 0x001323DC
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 612f;
			}
			this.HHIFMIPPMPF().SetFloat("There is already a virtual axis named ", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("bans.viewed.", this._Glitch);
			this.EHDJJANLINB().SetFloat("RequestSelectedLevel", this._Noise);
			this.FEAEGGCNIAA().SetVector("setAF", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 290f, 155f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D93 RID: 15763 RVA: 0x001342AF File Offset: 0x001324AF
	private void IBLGHLNNAHN()
	{
		this.SCShader = Shader.Find("_Blue_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x06003D95 RID: 15765 RVA: 0x00132A15 File Offset: 0x00130C15
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x001342D3 File Offset: 0x001324D3
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("MapEditorScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D97 RID: 15767 RVA: 0x001342F7 File Offset: 0x001324F7
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D98 RID: 15768 RVA: 0x00134330 File Offset: 0x00132530
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 13f)
			{
				this.HBJJOCHGOPH = 518f;
			}
			this.KJMECMIGJJA().SetFloat("FinalScoreText", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_Offsets", this._Glitch);
			this.KJMECMIGJJA().SetFloat("Preparing content...", this._Noise);
			this.GJHLADDCMFF().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1433f, 240f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D9A RID: 15770 RVA: 0x00132A15 File Offset: 0x00130C15
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D9B RID: 15771 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06003D9C RID: 15772 RVA: 0x00132A15 File Offset: 0x00130C15
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D9D RID: 15773 RVA: 0x00132A15 File Offset: 0x00130C15
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D9E RID: 15774 RVA: 0x0013442C File Offset: 0x0013262C
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D9F RID: 15775 RVA: 0x00132A15 File Offset: 0x00130C15
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DA0 RID: 15776 RVA: 0x00134450 File Offset: 0x00132650
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 820f)
			{
				this.HBJJOCHGOPH = 1659f;
			}
			this.ADAFMBOGPLN().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Value2", this._Glitch);
			this.DKKBFFHBHJE().SetFloat("Set particless emission (glow)", this._Noise);
			this.NLFJGMBCICG().SetVector("System.String", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1772f, 387f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DA1 RID: 15777 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x06003DA2 RID: 15778 RVA: 0x00134524 File Offset: 0x00132724
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1799f)
			{
				this.HBJJOCHGOPH = 382f;
			}
			this.MICHFGAOPKM().SetFloat("_PixelsPerMeterAtOneMeter", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("\n\n#", this._Glitch);
			this.GJHLADDCMFF().SetFloat("InputField", this._Noise);
			this.HEINDEMCGIK().SetVector("[Up-Right-Down-Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 318f, 1146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DA3 RID: 15779 RVA: 0x00132A15 File Offset: 0x00130C15
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DA4 RID: 15780 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06003DA5 RID: 15781 RVA: 0x001345F7 File Offset: 0x001327F7
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DA6 RID: 15782 RVA: 0x0013462E File Offset: 0x0013282E
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DA7 RID: 15783 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003DA8 RID: 15784 RVA: 0x00134665 File Offset: 0x00132865
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DA9 RID: 15785 RVA: 0x00132A15 File Offset: 0x00130C15
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DAA RID: 15786 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x040006A5 RID: 1701
	public Shader SCShader;

	// Token: 0x040006A6 RID: 1702
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006A7 RID: 1703
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006A8 RID: 1704
	private Material BJFKDHHMLJH;

	// Token: 0x040006A9 RID: 1705
	[Range(0f, 1f)]
	public float _Glitch = 1f;

	// Token: 0x040006AA RID: 1706
	[Range(0f, 1f)]
	public float _Noise = 1f;
}
