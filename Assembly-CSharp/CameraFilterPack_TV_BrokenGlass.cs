using System;
using UnityEngine;

// Token: 0x02000112 RID: 274
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Broken Glass")]
public class CameraFilterPack_TV_BrokenGlass : MonoBehaviour
{
	// Token: 0x06005579 RID: 21881 RVA: 0x001A7200 File Offset: 0x001A5400
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 337f)
			{
				this.HBJJOCHGOPH = 419f;
			}
			this.PDEAHJPOMEF().SetFloat("[Left]", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Noise_TV_3", this.LightReflect);
			this.KBOPGONOCNP().SetFloat(":", this.Broken_Small);
			this.OIMMPLPBLBK().SetFloat("Joystick1Button5", this.Broken_Medium);
			this.KEMAALEODNH().SetFloat("_MainTex2", this.Broken_High);
			this.NBPKMLMCHFN.SetFloat("deletemap", this.Broken_Big);
			this.KBOPGONOCNP().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600557A RID: 21882 RVA: 0x001A72FE File Offset: 0x001A54FE
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Size") as Texture2D);
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600557B RID: 21883 RVA: 0x001A7337 File Offset: 0x001A5537
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("#exit") as Texture2D);
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600557C RID: 21884 RVA: 0x001A7370 File Offset: 0x001A5570
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/FX_Drunk2") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600557D RID: 21885 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600557E RID: 21886 RVA: 0x001A73C8 File Offset: 0x001A55C8
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 77f)
			{
				this.HBJJOCHGOPH = 433f;
			}
			this.GKILCDHJFEG().SetFloat("SelectorMapsCountSlider", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("ResetButton", this.LightReflect);
			this.KBOPGONOCNP().SetFloat("MouseY", this.Broken_Small);
			this.OIMMPLPBLBK().SetFloat("EditMenu", this.Broken_Medium);
			this.LNLKMDPHDCC().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", this.Broken_High);
			this.GKILCDHJFEG().SetFloat("SpawnObj", this.Broken_Big);
			this.PDEAHJPOMEF().SetTexture("ItemsCountText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600557F RID: 21887 RVA: 0x001A74C6 File Offset: 0x001A56C6
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005580 RID: 21888 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06005581 RID: 21889 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005582 RID: 21890 RVA: 0x001A7500 File Offset: 0x001A5700
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 718f)
			{
				this.HBJJOCHGOPH = 539f;
			}
			this.PDEAHJPOMEF().SetFloat("ScreenResolutionPanel", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("LevelInfoInputField", this.LightReflect);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.Broken_Small);
			this.GKILCDHJFEG().SetFloat("_TimeX", this.Broken_Medium);
			this.OIMMPLPBLBK().SetFloat("SupportLogger OnDisconnectedFromPhoton().", this.Broken_High);
			this.NBPKMLMCHFN.SetFloat("x", this.Broken_Big);
			this.PGPEMMBJOOG().SetTexture("id", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005583 RID: 21891 RVA: 0x001A75FE File Offset: 0x001A57FE
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005584 RID: 21892 RVA: 0x001A7635 File Offset: 0x001A5835
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_BrokenGlass1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005585 RID: 21893 RVA: 0x001A766E File Offset: 0x001A586E
	private void FHPFJBFCOOF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Far") as Texture2D);
		this.SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005586 RID: 21894 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005587 RID: 21895 RVA: 0x001A76A8 File Offset: 0x001A58A8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1369f)
			{
				this.HBJJOCHGOPH = 668f;
			}
			this.KEMAALEODNH().SetFloat("CameraFilterPack/TV_Tiles", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat(".b", this.LightReflect);
			this.KEMAALEODNH().SetFloat(".lastCheckpoint.bgcolor", this.Broken_Small);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Broken_Medium);
			this.OIMMPLPBLBK().SetFloat("cancel", this.Broken_High);
			this.GKILCDHJFEG().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.Broken_Big);
			this.NBPKMLMCHFN.SetTexture("input", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005588 RID: 21896 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06005589 RID: 21897 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600558A RID: 21898 RVA: 0x001A77A8 File Offset: 0x001A59A8
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 716f)
			{
				this.HBJJOCHGOPH = 585f;
			}
			this.OIMMPLPBLBK().SetFloat("offsets", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Show image from resources by id at the center of the screen at foreground or background", this.LightReflect);
			this.KEMAALEODNH().SetFloat("z", this.Broken_Small);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.Broken_Medium);
			this.PDEAHJPOMEF().SetFloat("distance", this.Broken_High);
			this.PDEAHJPOMEF().SetFloat("keep aspect ratio", this.Broken_Big);
			this.LNLKMDPHDCC().SetTexture("selector", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600558B RID: 21899 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600558C RID: 21900 RVA: 0x001A78A6 File Offset: 0x001A5AA6
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600558D RID: 21901 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600558E RID: 21902 RVA: 0x001A78DD File Offset: 0x001A5ADD
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("RPC: 'OnAwakeRPC' Parameter: ") as Texture2D);
		this.SCShader = Shader.Find("Reset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600558F RID: 21903 RVA: 0x001A7918 File Offset: 0x001A5B18
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Broken_Small);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Broken_Medium);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Broken_High);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Broken_Big);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005590 RID: 21904 RVA: 0x001A7A16 File Offset: 0x001A5C16
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("[ImageLoader] Loaded image from ") as Texture2D);
		this.SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005591 RID: 21905 RVA: 0x001A7A50 File Offset: 0x001A5C50
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1381f)
			{
				this.HBJJOCHGOPH = 1978f;
			}
			this.OIMMPLPBLBK().SetFloat("float,0", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("float,0", this.LightReflect);
			this.KBOPGONOCNP().SetFloat("_Far", this.Broken_Small);
			this.PGPEMMBJOOG().SetFloat("#alreadystarted", this.Broken_Medium);
			this.OIMMPLPBLBK().SetFloat("]", this.Broken_High);
			this.OIMMPLPBLBK().SetFloat("_Red_R", this.Broken_Big);
			this.PGPEMMBJOOG().SetTexture("sounds/no_hit", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005592 RID: 21906 RVA: 0x001A7B4E File Offset: 0x001A5D4E
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005593 RID: 21907 RVA: 0x001A7B88 File Offset: 0x001A5D88
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1779f)
			{
				this.HBJJOCHGOPH = 883f;
			}
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("CrosshairOpacitySlider", this.LightReflect);
			this.OIMMPLPBLBK().SetFloat("Messages (shift+tab)", this.Broken_Small);
			this.OIMMPLPBLBK().SetFloat("_Value4", this.Broken_Medium);
			this.PDEAHJPOMEF().SetFloat("_Value3", this.Broken_High);
			this.KBOPGONOCNP().SetFloat("EventConfigButton", this.Broken_Big);
			this.KEMAALEODNH().SetTexture("\"", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005594 RID: 21908 RVA: 0x001A7C86 File Offset: 0x001A5E86
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("int") as Texture2D);
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005595 RID: 21909 RVA: 0x001A7CBF File Offset: 0x001A5EBF
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005596 RID: 21910 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06005597 RID: 21911 RVA: 0x001A7CF8 File Offset: 0x001A5EF8
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("[LevelEditorScene] Print Audio Wave: Start") as Texture2D);
		this.SCShader = Shader.Find("Up ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005598 RID: 21912 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06005599 RID: 21913 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600559A RID: 21914 RVA: 0x001A7D34 File Offset: 0x001A5F34
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1855f)
			{
				this.HBJJOCHGOPH = 739f;
			}
			this.NBPKMLMCHFN.SetFloat("From {0} at Index {1} \n", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat(".played", this.LightReflect);
			this.PGPEMMBJOOG().SetFloat("_PrevViewProj", this.Broken_Small);
			this.NBPKMLMCHFN.SetFloat("float,1", this.Broken_Medium);
			this.GKILCDHJFEG().SetFloat("<color=#", this.Broken_High);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.Broken_Big);
			this.HFBJAOFLCJI().SetTexture("Tab2Content", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600559B RID: 21915 RVA: 0x001A7E32 File Offset: 0x001A6032
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("_HrDepthTex") as Texture2D);
		this.SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600559C RID: 21916 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600559D RID: 21917 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x0600559E RID: 21918 RVA: 0x001A7E6C File Offset: 0x001A606C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 258f)
			{
				this.HBJJOCHGOPH = 25f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_TV_Arcade1", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("_ProjectToPixelMatrix", this.LightReflect);
			this.HFBJAOFLCJI().SetFloat("maps.", this.Broken_Small);
			this.PDEAHJPOMEF().SetFloat("Messages (shift+tab)", this.Broken_Medium);
			this.PGPEMMBJOOG().SetFloat("Set Player Distance", this.Broken_High);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.Broken_Big);
			this.HFBJAOFLCJI().SetTexture("#mapby", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600559F RID: 21919 RVA: 0x001A7F6A File Offset: 0x001A616A
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("menutheme.deleted") as Texture2D);
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055A0 RID: 21920 RVA: 0x001A7FA3 File Offset: 0x001A61A3
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055A1 RID: 21921 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x060055A2 RID: 21922 RVA: 0x001A7FDA File Offset: 0x001A61DA
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

	// Token: 0x060055A3 RID: 21923 RVA: 0x001A8011 File Offset: 0x001A6211
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055A4 RID: 21924 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055A5 RID: 21925 RVA: 0x001A8048 File Offset: 0x001A6248
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1246f)
			{
				this.HBJJOCHGOPH = 1546f;
			}
			this.LNLKMDPHDCC().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("1", this.LightReflect);
			this.PGPEMMBJOOG().SetFloat(" (inactive)", this.Broken_Small);
			this.GKILCDHJFEG().SetFloat("Preparing configuration...", this.Broken_Medium);
			this.PGPEMMBJOOG().SetFloat("threshold", this.Broken_High);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.Broken_Big);
			this.NBPKMLMCHFN.SetTexture("[PlayerController] ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055A6 RID: 21926 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060055A7 RID: 21927 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060055A8 RID: 21928 RVA: 0x001A8148 File Offset: 0x001A6348
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 545f)
			{
				this.HBJJOCHGOPH = 415f;
			}
			this.OIMMPLPBLBK().SetFloat(".completedMaps", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.LightReflect);
			this.LNLKMDPHDCC().SetFloat("mapselector.filter.rateduponly", this.Broken_Small);
			this.PDEAHJPOMEF().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", this.Broken_Medium);
			this.PDEAHJPOMEF().SetFloat("No connection to item server!", this.Broken_High);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Color_GrayScale", this.Broken_Big);
			this.PGPEMMBJOOG().SetTexture("Finished", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055A9 RID: 21929 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055AA RID: 21930 RVA: 0x001A8248 File Offset: 0x001A6448
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1001f)
			{
				this.HBJJOCHGOPH = 805f;
			}
			this.GKILCDHJFEG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("LoadMapCanvas", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("': ", this.Broken_Small);
			this.HFBJAOFLCJI().SetFloat("EnvironmentSlider", this.Broken_Medium);
			this.NBPKMLMCHFN.SetFloat("SetSatelliteTrailMinVertexDistance", this.Broken_High);
			this.HFBJAOFLCJI().SetFloat(":", this.Broken_Big);
			this.PDEAHJPOMEF().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055AB RID: 21931 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055AC RID: 21932 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060055AD RID: 21933 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055AE RID: 21934 RVA: 0x001A8348 File Offset: 0x001A6548
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1173f)
			{
				this.HBJJOCHGOPH = 1183f;
			}
			this.NBPKMLMCHFN.SetFloat(") but there is no recycle bin setup for it", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack_Paper2", this.LightReflect);
			this.GKILCDHJFEG().SetFloat("_DistanceParams", this.Broken_Small);
			this.OGMEGHKECAH().SetFloat("HightScoreMaxPointsText", this.Broken_Medium);
			this.OIMMPLPBLBK().SetFloat("MainButton", this.Broken_High);
			this.KBOPGONOCNP().SetFloat("#ok", this.Broken_Big);
			this.KBOPGONOCNP().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055B0 RID: 21936 RVA: 0x001A8470 File Offset: 0x001A6670
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 658f)
			{
				this.HBJJOCHGOPH = 124f;
			}
			this.LNLKMDPHDCC().SetFloat("Nov", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Currently, the limit of users is reached for this title. Try again later. Disconnecting", this.LightReflect);
			this.OGMEGHKECAH().SetFloat("_SecondTex", this.Broken_Small);
			this.OIMMPLPBLBK().SetFloat("colorC", this.Broken_Medium);
			this.KEMAALEODNH().SetFloat("_Threshhold", this.Broken_High);
			this.PDEAHJPOMEF().SetFloat("Move environment object to the position", this.Broken_Big);
			this.NBPKMLMCHFN.SetTexture("id", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055B1 RID: 21937 RVA: 0x001A856E File Offset: 0x001A676E
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055B2 RID: 21938 RVA: 0x001A7B4E File Offset: 0x001A5D4E
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055B3 RID: 21939 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060055B4 RID: 21940 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055B5 RID: 21941 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060055B6 RID: 21942 RVA: 0x001A85A7 File Offset: 0x001A67A7
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("a year ago") as Texture2D);
		this.SCShader = Shader.Find("float,10");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055B7 RID: 21943 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055B8 RID: 21944 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060055B9 RID: 21945 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060055BA RID: 21946 RVA: 0x001A85E0 File Offset: 0x001A67E0
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055BB RID: 21947 RVA: 0x001A8617 File Offset: 0x001A6817
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055BC RID: 21948 RVA: 0x001A8650 File Offset: 0x001A6850
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 618f)
			{
				this.HBJJOCHGOPH = 1935f;
			}
			this.HFBJAOFLCJI().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("Items", this.LightReflect);
			this.KEMAALEODNH().SetFloat("Noise shaders are not set up! Disabling noise effect.", this.Broken_Small);
			this.HFBJAOFLCJI().SetFloat("event", this.Broken_Medium);
			this.OIMMPLPBLBK().SetFloat("_Value3", this.Broken_High);
			this.NBPKMLMCHFN.SetFloat("Solo", this.Broken_Big);
			this.PDEAHJPOMEF().SetTexture("RecordButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055BD RID: 21949 RVA: 0x001A73A9 File Offset: 0x001A55A9
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040008E3 RID: 2275
	public Shader SCShader;

	// Token: 0x040008E4 RID: 2276
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008E5 RID: 2277
	[Range(0f, 128f)]
	public float Broken_Small;

	// Token: 0x040008E6 RID: 2278
	[Range(0f, 128f)]
	public float Broken_Medium;

	// Token: 0x040008E7 RID: 2279
	[Range(0f, 128f)]
	public float Broken_High;

	// Token: 0x040008E8 RID: 2280
	[Range(0f, 128f)]
	public float Broken_Big = 1f;

	// Token: 0x040008E9 RID: 2281
	[Range(0f, 0.004f)]
	public float LightReflect = 0.002f;

	// Token: 0x040008EA RID: 2282
	private Material BJFKDHHMLJH;

	// Token: 0x040008EB RID: 2283
	private Texture2D FPHEBLMINDA;
}
