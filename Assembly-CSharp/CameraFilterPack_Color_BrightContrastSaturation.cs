using System;
using UnityEngine;

// Token: 0x0200006C RID: 108
[AddComponentMenu("Camera Filter Pack/Colors/BrightContrastSaturation")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_BrightContrastSaturation : MonoBehaviour
{
	// Token: 0x06001E04 RID: 7684 RVA: 0x000B55E4 File Offset: 0x000B37E4
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_Value13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x000B5608 File Offset: 0x000B3808
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("Please attach component to a Graphical UI component");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x000B562C File Offset: 0x000B382C
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x000B5649 File Offset: 0x000B3849
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_Threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000B566D File Offset: 0x000B386D
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.longestComboScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000B5691 File Offset: 0x000B3891
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000B56C8 File Offset: 0x000B38C8
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x000B56EC File Offset: 0x000B38EC
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 983f)
			{
				this.HBJJOCHGOPH = 1385f;
			}
			this.NBPKMLMCHFN.SetFloat("win", this.Brightness);
			this.MFHPKGICPIO().SetFloat("_Val", this.Saturation);
			this.NBMPPNFKFLB().SetFloat("GameScene", this.Contrast);
			this.JIBOKBCPDLC().SetFloat("Chat", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetVector("float,10", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 523f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x000B562C File Offset: 0x000B382C
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x000B57D5 File Offset: 0x000B39D5
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x000B57F9 File Offset: 0x000B39F9
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x000B5830 File Offset: 0x000B3A30
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x000B562C File Offset: 0x000B382C
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x000B5854 File Offset: 0x000B3A54
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x000B588C File Offset: 0x000B3A8C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 913f)
			{
				this.HBJJOCHGOPH = 1735f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Glitch_Mozaic", this.Brightness);
			this.DEFBJOCJJKF().SetFloat("maps.", this.Saturation);
			this.KJMECMIGJJA().SetFloat("CameraFilterPack/Edge_Sobel", this.Contrast);
			this.FLOHGDECHHH().SetFloat("Please attach component to a Graphical UI component", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetVector("Joystick1Button6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 353f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x000B5978 File Offset: 0x000B3B78
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 898f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.KJMECMIGJJA().SetFloat("_Alpha", this.Brightness);
			this.MMOODGIODPC().SetFloat("_Value2", this.Saturation);
			this.NBMPPNFKFLB().SetFloat("Items/", this.Contrast);
			this.IIBLJCKLGFG().SetFloat("maps.", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetVector("finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 55f, 1790f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000B5A61 File Offset: 0x000B3C61
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x000B5A98 File Offset: 0x000B3C98
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 723f)
			{
				this.HBJJOCHGOPH = 325f;
			}
			this.NJDIODJNGGA().SetFloat("master", this.Brightness);
			this.IIBLJCKLGFG().SetFloat("_NoiseScale", this.Saturation);
			this.LDNADDJMIPK().SetFloat("addNewButton", this.Contrast);
			this.HCGJCMDJPGD().SetFloat("_Blend", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetVector("Set Particles Input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 29f, 1157f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x000B562C File Offset: 0x000B382C
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x000B562C File Offset: 0x000B382C
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x000B5B81 File Offset: 0x000B3D81
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x000B5BB8 File Offset: 0x000B3DB8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 1965f;
			}
			this.BLMPMOIDGMG().SetFloat("#accuracy", this.Brightness);
			this.IIBLJCKLGFG().SetFloat("_Value", this.Saturation);
			this.HCGJCMDJPGD().SetFloat("ScreenResolutionPanel", this.Contrast);
			this.JLHLHKPHDFO().SetFloat("mode", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetVector("float,1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 687f, 1310f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x000B5CA4 File Offset: 0x000B3EA4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1365f)
			{
				this.HBJJOCHGOPH = 403f;
			}
			this.KJMECMIGJJA().SetFloat("Multiplayer", this.Brightness);
			this.HCGJCMDJPGD().SetFloat("y", this.Saturation);
			this.OCHJIMJNEMO().SetFloat("Ignored PU RPC, cause item is inactive. ", this.Contrast);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetVector("Registered PhotonView: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 135f, 762f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x000B5D8D File Offset: 0x000B3F8D
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x000B5DC4 File Offset: 0x000B3FC4
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x000B5DFC File Offset: 0x000B3FFC
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1099f)
			{
				this.HBJJOCHGOPH = 1581f;
			}
			this.LNLKMDPHDCC().SetFloat("Please attach component to a Graphical UI component", this.Brightness);
			this.NBMPPNFKFLB().SetFloat("_ScreenResolution", this.Saturation);
			this.KJMECMIGJJA().SetFloat("SpeedSlider", this.Contrast);
			this.MMOODGIODPC().SetFloat(".lastCheckpoint.powerupsScore", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetVector("No Name", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 555f, 60f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x000B5EE5 File Offset: 0x000B40E5
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x000B5F1C File Offset: 0x000B411C
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x000B5F53 File Offset: 0x000B4153
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x000B562C File Offset: 0x000B382C
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x000B5F8A File Offset: 0x000B418A
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000B5FAE File Offset: 0x000B41AE
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

	// Token: 0x06001E2A RID: 7722 RVA: 0x000B562C File Offset: 0x000B382C
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x000B562C File Offset: 0x000B382C
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x000B562C File Offset: 0x000B382C
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x000B5FE5 File Offset: 0x000B41E5
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("ConfigVersionSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x000B562C File Offset: 0x000B382C
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x000B6009 File Offset: 0x000B4209
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("SelectorMusicToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x000B602D File Offset: 0x000B422D
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x000B6064 File Offset: 0x000B4264
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_BrightContrastSaturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x000B60BC File Offset: 0x000B42BC
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("settings.volume.game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x000B60E0 File Offset: 0x000B42E0
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Map submitted!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x000B562C File Offset: 0x000B382C
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x000B6104 File Offset: 0x000B4304
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x000B5D8D File Offset: 0x000B3F8D
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x000B613B File Offset: 0x000B433B
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06001E3D RID: 7741 RVA: 0x000B6172 File Offset: 0x000B4372
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E3E RID: 7742 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06001E3F RID: 7743 RVA: 0x000B61A9 File Offset: 0x000B43A9
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x000B61E0 File Offset: 0x000B43E0
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1636f)
			{
				this.HBJJOCHGOPH = 1997f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value6", this.Brightness);
			this.JIBOKBCPDLC().SetFloat("[MapEditor] Updating top menu", this.Saturation);
			this.LNLKMDPHDCC().SetFloat("_ZCurve", this.Contrast);
			this.MMOODGIODPC().SetFloat("CameraFilterPack/Blur_GaussianBlur", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetVector("_BokehParams", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 507f, 1688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000B62CC File Offset: 0x000B44CC
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1933f)
			{
				this.HBJJOCHGOPH = 1827f;
			}
			this.LDNADDJMIPK().SetFloat("_Min", this.Brightness);
			this.JFDGLLEOPGB().SetFloat("_Value2", this.Saturation);
			this.KJMECMIGJJA().SetFloat("menu.enableselectormusic", this.Contrast);
			this.KEMJNOMIPHN().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetVector("error", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1151f, 1432f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x000B562C File Offset: 0x000B382C
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x000B63B8 File Offset: 0x000B45B8
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1626f)
			{
				this.HBJJOCHGOPH = 1405f;
			}
			this.IIBLJCKLGFG().SetFloat("_Value8", this.Brightness);
			this.NBPKMLMCHFN.SetFloat("GameScene", this.Saturation);
			this.LDNADDJMIPK().SetFloat(" workshop map(s)", this.Contrast);
			this.KEMJNOMIPHN().SetFloat(". Prefab must have a PhotonView component.", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E44 RID: 7748 RVA: 0x000B562C File Offset: 0x000B382C
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E45 RID: 7749 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x000B64A1 File Offset: 0x000B46A1
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_NoiseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x000B64C8 File Offset: 0x000B46C8
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1041f)
			{
				this.HBJJOCHGOPH = 579f;
			}
			this.KEMJNOMIPHN().SetFloat("/../", this.Brightness);
			this.HCGJCMDJPGD().SetFloat("player.xp", this.Saturation);
			this.KEMJNOMIPHN().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", this.Contrast);
			this.LDNADDJMIPK().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetVector("#outdatedmap! Challenges will not work!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 154f, 1938f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x000B65B4 File Offset: 0x000B47B4
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1668f)
			{
				this.HBJJOCHGOPH = 1053f;
			}
			this.KJMECMIGJJA().SetFloat("_Value", this.Brightness);
			this.NBPKMLMCHFN.SetFloat("UseScanLineSize", this.Saturation);
			this.DEFBJOCJJKF().SetFloat("settings_bindings_sec_", this.Contrast);
			this.KEMJNOMIPHN().SetFloat("VisionBlur", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetVector("EventData0DropDownList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 993f, 1848f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x000B669D File Offset: 0x000B489D
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E4B RID: 7755 RVA: 0x000B66D4 File Offset: 0x000B48D4
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x000B66F8 File Offset: 0x000B48F8
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_Brightness", this.Brightness);
			this.NBPKMLMCHFN.SetFloat("_Saturation", this.Saturation);
			this.NBPKMLMCHFN.SetFloat("_Contrast", this.Contrast);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000B562C File Offset: 0x000B382C
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x000B67E1 File Offset: 0x000B49E1
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("menu.copyright");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x000B6805 File Offset: 0x000B4A05
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("LoadMapCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x000B6829 File Offset: 0x000B4A29
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("IconFileSelector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x000B684D File Offset: 0x000B4A4D
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("\" for viewID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E53 RID: 7763 RVA: 0x000B562C File Offset: 0x000B382C
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E54 RID: 7764 RVA: 0x000B6871 File Offset: 0x000B4A71
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E55 RID: 7765 RVA: 0x000B562C File Offset: 0x000B382C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E56 RID: 7766 RVA: 0x000B562C File Offset: 0x000B382C
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E57 RID: 7767 RVA: 0x000B68A8 File Offset: 0x000B4AA8
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E58 RID: 7768 RVA: 0x000B68CC File Offset: 0x000B4ACC
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("isVisible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E59 RID: 7769 RVA: 0x000B68F0 File Offset: 0x000B4AF0
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x000B6914 File Offset: 0x000B4B14
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("tolobby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x000B6938 File Offset: 0x000B4B38
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000411 RID: 1041
	public Shader SCShader;

	// Token: 0x04000412 RID: 1042
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000413 RID: 1043
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000414 RID: 1044
	private Material BJFKDHHMLJH;

	// Token: 0x04000415 RID: 1045
	[Range(0f, 10f)]
	public float Brightness = 2f;

	// Token: 0x04000416 RID: 1046
	[Range(0f, 10f)]
	public float Saturation = 1.5f;

	// Token: 0x04000417 RID: 1047
	[Range(0f, 10f)]
	public float Contrast = 1.5f;
}
