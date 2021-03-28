using System;
using UnityEngine;

// Token: 0x020000BE RID: 190
[AddComponentMenu("Camera Filter Pack/Pixel/8bits_gb")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_8bits_gb : MonoBehaviour
{
	// Token: 0x060039A1 RID: 14753 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039A2 RID: 14754 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039A3 RID: 14755 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x060039A4 RID: 14756 RVA: 0x00123D0F File Offset: 0x00121F0F
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039A5 RID: 14757 RVA: 0x00123D33 File Offset: 0x00121F33
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039A6 RID: 14758 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039A7 RID: 14759 RVA: 0x00123D6A File Offset: 0x00121F6A
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039A8 RID: 14760 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039A9 RID: 14761 RVA: 0x00123DA1 File Offset: 0x00121FA1
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039AA RID: 14762 RVA: 0x00123DD8 File Offset: 0x00121FD8
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1482f)
			{
				this.HBJJOCHGOPH = 1787f;
			}
			this.IONHGBPGCHK().SetFloat("LobbyCanvas", this.HBJJOCHGOPH);
			if (this.Brightness == 1741f)
			{
				this.Brightness = 634f;
			}
			this.NBPKMLMCHFN.SetFloat("#", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-41, 153, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.MMOODGIODPC());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039AB RID: 14763 RVA: 0x00123EA8 File Offset: 0x001220A8
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039AC RID: 14764 RVA: 0x00123EDF File Offset: 0x001220DF
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("NetworkPeer broke!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039AD RID: 14765 RVA: 0x00123F04 File Offset: 0x00122104
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 351f)
			{
				this.HBJJOCHGOPH = 1005f;
			}
			this.FHFLKLMFHOI().SetFloat("{0:x2}", this.HBJJOCHGOPH);
			if (this.Brightness == 1038f)
			{
				this.Brightness = 1286f;
			}
			this.HCGJCMDJPGD().SetFloat("en", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(65, 3, 1);
			Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039AE RID: 14766 RVA: 0x00123FD4 File Offset: 0x001221D4
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039AF RID: 14767 RVA: 0x0012400C File Offset: 0x0012220C
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1509f)
			{
				this.HBJJOCHGOPH = 361f;
			}
			this.NBPKMLMCHFN.SetFloat("turn", this.HBJJOCHGOPH);
			if (this.Brightness == 1667f)
			{
				this.Brightness = 1584f;
			}
			this.MMOODGIODPC().SetFloat("|", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(131, -1, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039B0 RID: 14768 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060039B1 RID: 14769 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060039B2 RID: 14770 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060039B3 RID: 14771 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060039B4 RID: 14772 RVA: 0x001240DC File Offset: 0x001222DC
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("Load Game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039B5 RID: 14773 RVA: 0x00124100 File Offset: 0x00122300
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
			if (this.Brightness == 0f)
			{
				this.Brightness = 0.001f;
			}
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(160, 144, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060039B6 RID: 14774 RVA: 0x001241D0 File Offset: 0x001223D0
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

	// Token: 0x060039B7 RID: 14775 RVA: 0x00124207 File Offset: 0x00122407
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("FinalScoreSmallText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039B8 RID: 14776 RVA: 0x0012422B File Offset: 0x0012242B
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039B9 RID: 14777 RVA: 0x0012424F File Offset: 0x0012244F
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039BA RID: 14778 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060039BB RID: 14779 RVA: 0x00124274 File Offset: 0x00122474
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1090f)
			{
				this.HBJJOCHGOPH = 788f;
			}
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Vision_Warp", this.HBJJOCHGOPH);
			if (this.Brightness == 1791f)
			{
				this.Brightness = 1468f;
			}
			this.FHFLKLMFHOI().SetFloat("[Right-Down]", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-29, 111, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.HCGJCMDJPGD());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039BC RID: 14780 RVA: 0x00124344 File Offset: 0x00122544
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039BD RID: 14781 RVA: 0x0012437C File Offset: 0x0012257C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1409f)
			{
				this.HBJJOCHGOPH = 725f;
			}
			this.IONHGBPGCHK().SetFloat("_Near", this.HBJJOCHGOPH);
			if (this.Brightness == 1344f)
			{
				this.Brightness = 1872f;
			}
			this.BFGNMFCNDBC().SetFloat("Items/", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(173, 134, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.FHFLKLMFHOI());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039BE RID: 14782 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039BF RID: 14783 RVA: 0x0012444C File Offset: 0x0012264C
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("<color=#{0}>{1}</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039C0 RID: 14784 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039C1 RID: 14785 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060039C2 RID: 14786 RVA: 0x00124470 File Offset: 0x00122670
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_TileMaxOffs");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039C3 RID: 14787 RVA: 0x00124494 File Offset: 0x00122694
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_Red_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039C4 RID: 14788 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x060039C5 RID: 14789 RVA: 0x001244B8 File Offset: 0x001226B8
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 681f)
			{
				this.HBJJOCHGOPH = 66f;
			}
			this.JIBOKBCPDLC().SetFloat("_Near", this.HBJJOCHGOPH);
			if (this.Brightness == 766f)
			{
				this.Brightness = 1945f;
			}
			this.EMDFHOKEGNG().SetFloat("_ScreenResolution", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(160, -159, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.HCGJCMDJPGD());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039C6 RID: 14790 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039C7 RID: 14791 RVA: 0x00124588 File Offset: 0x00122788
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 890f)
			{
				this.HBJJOCHGOPH = 1580f;
			}
			this.MMOODGIODPC().SetFloat("_SSAO", this.HBJJOCHGOPH);
			if (this.Brightness == 737f)
			{
				this.Brightness = 1511f;
			}
			this.MMOODGIODPC().SetFloat("int", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(125, 78, 1);
			Graphics.Blit(AAACLELCPML, temporary, this.MMOODGIODPC());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039C8 RID: 14792 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060039C9 RID: 14793 RVA: 0x00124658 File Offset: 0x00122858
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039CA RID: 14794 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x060039CB RID: 14795 RVA: 0x00124690 File Offset: 0x00122890
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1388f)
			{
				this.HBJJOCHGOPH = 1559f;
			}
			this.KBOPGONOCNP().SetFloat(". Not connectedAndReady.", this.HBJJOCHGOPH);
			if (this.Brightness == 1695f)
			{
				this.Brightness = 1557f;
			}
			this.NBPKMLMCHFN.SetFloat("isVisible", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(166, -60, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039CC RID: 14796 RVA: 0x00124760 File Offset: 0x00122960
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039CE RID: 14798 RVA: 0x001247AA File Offset: 0x001229AA
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_8bits_gb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039CF RID: 14799 RVA: 0x00123CF2 File Offset: 0x00121EF2
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039D0 RID: 14800 RVA: 0x001247D0 File Offset: 0x001229D0
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1200f)
			{
				this.HBJJOCHGOPH = 456f;
			}
			this.KAFBNOBOIAJ().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			if (this.Brightness == 650f)
			{
				this.Brightness = 1166f;
			}
			this.KBOPGONOCNP().SetFloat("SetCrosshairColor", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-62, -179, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.EMDFHOKEGNG());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039D1 RID: 14801 RVA: 0x001248A0 File Offset: 0x00122AA0
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039D2 RID: 14802 RVA: 0x001248C4 File Offset: 0x00122AC4
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1838f)
			{
				this.HBJJOCHGOPH = 17f;
			}
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Distortion_Lens", this.HBJJOCHGOPH);
			if (this.Brightness == 120f)
			{
				this.Brightness = 551f;
			}
			this.FHFLKLMFHOI().SetFloat(",", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(11, -159, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.JIBOKBCPDLC());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039D3 RID: 14803 RVA: 0x00124994 File Offset: 0x00122B94
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039D4 RID: 14804 RVA: 0x001249B8 File Offset: 0x00122BB8
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1742f)
			{
				this.HBJJOCHGOPH = 435f;
			}
			this.FHFLKLMFHOI().SetFloat("BitsData", this.HBJJOCHGOPH);
			if (this.Brightness == 53f)
			{
				this.Brightness = 1594f;
			}
			this.NBPKMLMCHFN.SetFloat("Vertical", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(92, -196, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.FHFLKLMFHOI());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039D5 RID: 14805 RVA: 0x00124A88 File Offset: 0x00122C88
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 298f)
			{
				this.HBJJOCHGOPH = 951f;
			}
			this.HCGJCMDJPGD().SetFloat("A", this.HBJJOCHGOPH);
			if (this.Brightness == 1162f)
			{
				this.Brightness = 1916f;
			}
			this.HCGJCMDJPGD().SetFloat("SetPlayerDistance", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(-43, 88, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.KBOPGONOCNP());
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039D6 RID: 14806 RVA: 0x00124B58 File Offset: 0x00122D58
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1084f)
			{
				this.HBJJOCHGOPH = 973f;
			}
			this.KBOPGONOCNP().SetFloat("_OffsetScale", this.HBJJOCHGOPH);
			if (this.Brightness == 296f)
			{
				this.Brightness = 520f;
			}
			this.MMOODGIODPC().SetFloat(".lastCheckpoint.isMapCompleted", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(15, 168, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.BFGNMFCNDBC());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039D7 RID: 14807 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060039D8 RID: 14808 RVA: 0x00124C28 File Offset: 0x00122E28
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400064F RID: 1615
	public Shader SCShader;

	// Token: 0x04000650 RID: 1616
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000651 RID: 1617
	private Material BJFKDHHMLJH;

	// Token: 0x04000652 RID: 1618
	[Range(-1f, 1f)]
	public float Brightness;
}
