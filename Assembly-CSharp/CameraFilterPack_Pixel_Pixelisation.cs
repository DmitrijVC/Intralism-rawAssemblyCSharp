using System;
using UnityEngine;

// Token: 0x02000101 RID: 257
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Pixel/Pixelisation")]
public class CameraFilterPack_Pixel_Pixelisation : MonoBehaviour
{
	// Token: 0x06005084 RID: 20612 RVA: 0x00192290 File Offset: 0x00190490
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005085 RID: 20613 RVA: 0x001922C7 File Offset: 0x001904C7
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005086 RID: 20614 RVA: 0x001922FE File Offset: 0x001904FE
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005087 RID: 20615 RVA: 0x00192338 File Offset: 0x00190538
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KDMBOKLMADJ().SetFloat("visible", this._Pixelisation);
			this.HEINDEMCGIK().SetFloat("_TintColor", this._SizeX);
			this.EHDJJANLINB().SetFloat("w", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005088 RID: 20616 RVA: 0x001923B1 File Offset: 0x001905B1
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005089 RID: 20617 RVA: 0x001923CE File Offset: 0x001905CE
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Pixel_Pixelisation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600508A RID: 20618 RVA: 0x001923F4 File Offset: 0x001905F4
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.GKILCDHJFEG().SetFloat("[DiscordController] Connected to {0}#{1}: {2}", this._Pixelisation);
			this.HKIMAANBGMJ().SetFloat("Joystick1Button4", this._SizeX);
			this.FGENHBKMPDA().SetFloat("Current xp: ", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600508B RID: 20619 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x0600508C RID: 20620 RVA: 0x0019246D File Offset: 0x0019066D
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600508D RID: 20621 RVA: 0x00192491 File Offset: 0x00190691
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("#loopnumber ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600508E RID: 20622 RVA: 0x001923B1 File Offset: 0x001905B1
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600508F RID: 20623 RVA: 0x001923B1 File Offset: 0x001905B1
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005090 RID: 20624 RVA: 0x001924B8 File Offset: 0x001906B8
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.GKILCDHJFEG().SetFloat("_BlurredColor", this._Pixelisation);
			this.HHIAIGCAHDA().SetFloat("SetSpeed", this._SizeX);
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005091 RID: 20625 RVA: 0x00192531 File Offset: 0x00190731
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Item ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005092 RID: 20626 RVA: 0x00192555 File Offset: 0x00190755
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005093 RID: 20627 RVA: 0x0019258C File Offset: 0x0019078C
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HHIAIGCAHDA().SetFloat(".completedCount", this._Pixelisation);
			this.MFHPKGICPIO().SetFloat("clear", this._SizeX);
			this.HEINDEMCGIK().SetFloat("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005094 RID: 20628 RVA: 0x00192605 File Offset: 0x00190805
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005095 RID: 20629 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06005096 RID: 20630 RVA: 0x001923B1 File Offset: 0x001905B1
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06005097 RID: 20631 RVA: 0x0019263C File Offset: 0x0019083C
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

	// Token: 0x06005098 RID: 20632 RVA: 0x001923B1 File Offset: 0x001905B1
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005099 RID: 20633 RVA: 0x00192673 File Offset: 0x00190873
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("_MatrixSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600509A RID: 20634 RVA: 0x00192697 File Offset: 0x00190897
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Chromatic_Aberration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600509B RID: 20635 RVA: 0x001923B1 File Offset: 0x001905B1
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600509C RID: 20636 RVA: 0x001926BC File Offset: 0x001908BC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HKIMAANBGMJ().SetFloat("#", this._Pixelisation);
			this.MFHPKGICPIO().SetFloat("Texture2", this._SizeX);
			this.ADGHJOHKEHG().SetFloat("F3", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600509D RID: 20637 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x0600509E RID: 20638 RVA: 0x00192735 File Offset: 0x00190935
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050A0 RID: 20640 RVA: 0x00192782 File Offset: 0x00190982
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find(". Possible scene loading in progress?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050A1 RID: 20641 RVA: 0x001923B1 File Offset: 0x001905B1
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050A2 RID: 20642 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060050A3 RID: 20643 RVA: 0x001927A6 File Offset: 0x001909A6
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("Show Title");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050A4 RID: 20644 RVA: 0x001927CA File Offset: 0x001909CA
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050A5 RID: 20645 RVA: 0x00192804 File Offset: 0x00190A04
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBPKMLMCHFN.SetFloat("_Val", this._Pixelisation);
			this.NBPKMLMCHFN.SetFloat("_Val2", this._SizeX);
			this.NBPKMLMCHFN.SetFloat("_Val3", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050A6 RID: 20646 RVA: 0x0019287D File Offset: 0x00190A7D
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050A7 RID: 20647 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060050A8 RID: 20648 RVA: 0x001928B4 File Offset: 0x00190AB4
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050A9 RID: 20649 RVA: 0x001928D8 File Offset: 0x00190AD8
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HEHKGPKLAKK().SetFloat("#", this._Pixelisation);
			this.DONENAMLFLF().SetFloat("owner: ", this._SizeX);
			this.LNLKMDPHDCC().SetFloat("score:", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050AA RID: 20650 RVA: 0x00192951 File Offset: 0x00190B51
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050AB RID: 20651 RVA: 0x001923B1 File Offset: 0x001905B1
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050AC RID: 20652 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060050AD RID: 20653 RVA: 0x00192988 File Offset: 0x00190B88
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050AE RID: 20654 RVA: 0x001929BF File Offset: 0x00190BBF
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050AF RID: 20655 RVA: 0x001929F6 File Offset: 0x00190BF6
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050B0 RID: 20656 RVA: 0x00192A2D File Offset: 0x00190C2D
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("stretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050B1 RID: 20657 RVA: 0x00192A51 File Offset: 0x00190C51
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("No problem found, so far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050B2 RID: 20658 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060050B3 RID: 20659 RVA: 0x00192A75 File Offset: 0x00190C75
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("Joystick1Button4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050B4 RID: 20660 RVA: 0x00192A9C File Offset: 0x00190C9C
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KDMBOKLMADJ().SetFloat("inventory.selected.", this._Pixelisation);
			this.HKIMAANBGMJ().SetFloat("note.5", this._SizeX);
			this.MFHPKGICPIO().SetFloat("color", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050B5 RID: 20661 RVA: 0x00192B18 File Offset: 0x00190D18
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.ADGHJOHKEHG().SetFloat("MenuPlayButton", this._Pixelisation);
			this.LONNIJMNKFB().SetFloat(".lastCheckpoint.correctScore", this._SizeX);
			this.PLBEJJIHFPB().SetFloat("_VelocityTex", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050B6 RID: 20662 RVA: 0x00192B94 File Offset: 0x00190D94
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NFMGLIKNOOC().SetFloat("ticket", this._Pixelisation);
			this.DONENAMLFLF().SetFloat("_AlphaHexa", this._SizeX);
			this.FGENHBKMPDA().SetFloat("Editor/", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050B7 RID: 20663 RVA: 0x001923B1 File Offset: 0x001905B1
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050B8 RID: 20664 RVA: 0x00192C10 File Offset: 0x00190E10
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.GKILCDHJFEG().SetFloat("_Offsets", this._Pixelisation);
			this.BAGICADFBAB().SetFloat("ResetSpeed", this._SizeX);
			this.ADGHJOHKEHG().SetFloat("GraphicsQualitySlider", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050B9 RID: 20665 RVA: 0x00192C89 File Offset: 0x00190E89
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("#exit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050BA RID: 20666 RVA: 0x00192CAD File Offset: 0x00190EAD
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050BB RID: 20667 RVA: 0x00192CD1 File Offset: 0x00190ED1
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_InternalLutTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050BC RID: 20668 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x060050BD RID: 20669 RVA: 0x00192CF5 File Offset: 0x00190EF5
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050BE RID: 20670 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060050BF RID: 20671 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060050C0 RID: 20672 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060050C1 RID: 20673 RVA: 0x001923B1 File Offset: 0x001905B1
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050C2 RID: 20674 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x060050C3 RID: 20675 RVA: 0x00192D2C File Offset: 0x00190F2C
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050C4 RID: 20676 RVA: 0x00192D64 File Offset: 0x00190F64
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NDMPCDHADMJ().SetFloat("SetSatelliteLerpSpeed", this._Pixelisation);
			this.FHFLKLMFHOI().SetFloat(".sav", this._SizeX);
			this.LPMLLJKMAMP().SetFloat("FinalScoreSmallText", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050C5 RID: 20677 RVA: 0x001923B1 File Offset: 0x001905B1
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050C6 RID: 20678 RVA: 0x001923B1 File Offset: 0x001905B1
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050C7 RID: 20679 RVA: 0x001923B1 File Offset: 0x001905B1
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050C8 RID: 20680 RVA: 0x001923B1 File Offset: 0x001905B1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050C9 RID: 20681 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x060050CA RID: 20682 RVA: 0x00192DDD File Offset: 0x00190FDD
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050CB RID: 20683 RVA: 0x00192E04 File Offset: 0x00191004
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HHIAIGCAHDA().SetFloat("DPADVER", this._Pixelisation);
			this.ADGHJOHKEHG().SetFloat("3d text", this._SizeX);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050CC RID: 20684 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x060050CD RID: 20685 RVA: 0x00192E7D File Offset: 0x0019107D
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050CE RID: 20686 RVA: 0x00192EA1 File Offset: 0x001910A1
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("http://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050CF RID: 20687 RVA: 0x00192EC5 File Offset: 0x001910C5
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050D0 RID: 20688 RVA: 0x00192EE9 File Offset: 0x001910E9
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050D1 RID: 20689 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060050D2 RID: 20690 RVA: 0x00192F20 File Offset: 0x00191120
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050D3 RID: 20691 RVA: 0x00192F44 File Offset: 0x00191144
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("file://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050D4 RID: 20692 RVA: 0x00192F68 File Offset: 0x00191168
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NFMGLIKNOOC().SetFloat("_Value8", this._Pixelisation);
			this.EOCCJGIGEGJ().SetFloat("/theme", this._SizeX);
			this.KDMBOKLMADJ().SetFloat("note.4", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050D5 RID: 20693 RVA: 0x00192FE1 File Offset: 0x001911E1
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050D6 RID: 20694 RVA: 0x001923B1 File Offset: 0x001905B1
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050D7 RID: 20695 RVA: 0x001923B1 File Offset: 0x001905B1
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050D8 RID: 20696 RVA: 0x001923B1 File Offset: 0x001905B1
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050D9 RID: 20697 RVA: 0x00193018 File Offset: 0x00191218
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find(".played");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050DA RID: 20698 RVA: 0x0019303C File Offset: 0x0019123C
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050DB RID: 20699 RVA: 0x00192D2C File Offset: 0x00190F2C
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050DC RID: 20700 RVA: 0x00193060 File Offset: 0x00191260
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050DD RID: 20701 RVA: 0x00193097 File Offset: 0x00191297
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050DE RID: 20702 RVA: 0x001930BB File Offset: 0x001912BB
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050DF RID: 20703 RVA: 0x001930F4 File Offset: 0x001912F4
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.ADGHJOHKEHG().SetFloat("player.currentrank", this._Pixelisation);
			this.EFMCNLELMDO().SetFloat("mapselector.orderby", this._SizeX);
			this.GKILCDHJFEG().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050E0 RID: 20704 RVA: 0x00192CF5 File Offset: 0x00190EF5
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050E1 RID: 20705 RVA: 0x001923B1 File Offset: 0x001905B1
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050E2 RID: 20706 RVA: 0x001923B1 File Offset: 0x001905B1
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050E3 RID: 20707 RVA: 0x0019316D File Offset: 0x0019136D
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("Map already submited. Update?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050E4 RID: 20708 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x060050E5 RID: 20709 RVA: 0x00193191 File Offset: 0x00191391
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("ShadersToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050E6 RID: 20710 RVA: 0x001931B5 File Offset: 0x001913B5
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050E7 RID: 20711 RVA: 0x001931EC File Offset: 0x001913EC
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050E8 RID: 20712 RVA: 0x00193223 File Offset: 0x00191423
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050E9 RID: 20713 RVA: 0x0019325C File Offset: 0x0019145C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.JIBOKBCPDLC().SetFloat("76561198041679481", this._Pixelisation);
			this.HEHKGPKLAKK().SetFloat("win", this._SizeX);
			this.GKILCDHJFEG().SetFloat(" ", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050EA RID: 20714 RVA: 0x001932D8 File Offset: 0x001914D8
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HEINDEMCGIK().SetFloat("_Sat", this._Pixelisation);
			this.GJHLADDCMFF().SetFloat("<command>", this._SizeX);
			this.DONENAMLFLF().SetFloat("Map already submited. Update?", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050EB RID: 20715 RVA: 0x00193351 File Offset: 0x00191551
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050EC RID: 20716 RVA: 0x00193388 File Offset: 0x00191588
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HKIMAANBGMJ().SetFloat("0 - default, 1 - left, 2 - right", this._Pixelisation);
			this.NDMPCDHADMJ().SetFloat("GridDataArcs", this._SizeX);
			this.LNLKMDPHDCC().SetFloat("_Red_G", this._SizeY);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050ED RID: 20717 RVA: 0x00193401 File Offset: 0x00191601
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050EE RID: 20718 RVA: 0x00193438 File Offset: 0x00191638
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000868 RID: 2152
	public Shader SCShader;

	// Token: 0x04000869 RID: 2153
	[Range(0.6f, 120f)]
	public float _Pixelisation = 8f;

	// Token: 0x0400086A RID: 2154
	[Range(0.6f, 120f)]
	public float _SizeX = 1f;

	// Token: 0x0400086B RID: 2155
	[Range(0.6f, 120f)]
	public float _SizeY = 1f;

	// Token: 0x0400086C RID: 2156
	private Material BJFKDHHMLJH;
}
