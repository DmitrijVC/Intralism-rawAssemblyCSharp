using System;
using UnityEngine;

// Token: 0x0200005E RID: 94
[AddComponentMenu("Camera Filter Pack/Blur/Dithering2x2")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Dithering2x2 : MonoBehaviour
{
	// Token: 0x06001A85 RID: 6789 RVA: 0x000A5C62 File Offset: 0x000A3E62
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A86 RID: 6790 RVA: 0x000A5C7F File Offset: 0x000A3E7F
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A87 RID: 6791 RVA: 0x000A5C62 File Offset: 0x000A3E62
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A88 RID: 6792 RVA: 0x000A5CB6 File Offset: 0x000A3EB6
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_ForceYSwap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A89 RID: 6793 RVA: 0x000A5CDA File Offset: 0x000A3EDA
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A8A RID: 6794 RVA: 0x000A5C62 File Offset: 0x000A3E62
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A8B RID: 6795 RVA: 0x000A5D11 File Offset: 0x000A3F11
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A8C RID: 6796 RVA: 0x000A5D48 File Offset: 0x000A3F48
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Dithering2x2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A8D RID: 6797 RVA: 0x000A5D6C File Offset: 0x000A3F6C
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06001A8E RID: 6798 RVA: 0x000A5DA3 File Offset: 0x000A3FA3
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

	// Token: 0x06001A8F RID: 6799 RVA: 0x000A5DDA File Offset: 0x000A3FDA
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Atmosphere_Rain_FX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x000A5DFE File Offset: 0x000A3FFE
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x000A5E35 File Offset: 0x000A4035
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x000A5E6C File Offset: 0x000A406C
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1114f)
			{
				this.HBJJOCHGOPH = 1645f;
			}
			this.DBOLLHHMKKN().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(" not exist", (float)this.Level);
			this.IIBLJCKLGFG().SetVector("maxScore", this.Distance);
			this.DNLMFEGJJDD().SetVector(" GameServer:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 753f, 1697f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x000A5F48 File Offset: 0x000A4148
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1314f)
			{
				this.HBJJOCHGOPH = 1600f;
			}
			this.ACHNOHCLGOO().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("[Up-Down-Left]", (float)this.Level);
			this.PDEAHJPOMEF().SetVector("_MainTex2", this.Distance);
			this.IIJMIPBMMBF().SetVector("set id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 957f, 578f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x000A6021 File Offset: 0x000A4221
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_Shadow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x000A6048 File Offset: 0x000A4248
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 716f)
			{
				this.HBJJOCHGOPH = 1757f;
			}
			this.DBOLLHHMKKN().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("menu.selectedplaymode", (float)this.Level);
			this.DBOLLHHMKKN().SetVector("#craftng", this.Distance);
			this.IIJMIPBMMBF().SetVector("settings.fps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1066f, 1558f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x000A6124 File Offset: 0x000A4324
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 668f)
			{
				this.HBJJOCHGOPH = 730f;
			}
			this.IIBLJCKLGFG().SetFloat("bad", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat(".", (float)this.Level);
			this.DBOLLHHMKKN().SetVector("#savemapchanges?", this.Distance);
			this.IIBLJCKLGFG().SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 625f, 337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x000A61FD File Offset: 0x000A43FD
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_MaxRadiusOrKInPaper");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x000A6224 File Offset: 0x000A4424
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
			this.NBPKMLMCHFN.SetFloat("_Level", (float)this.Level);
			this.NBPKMLMCHFN.SetVector("_Distance", this.Distance);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A9B RID: 6811 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x000A62FD File Offset: 0x000A44FD
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x000A6334 File Offset: 0x000A4534
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1245f)
			{
				this.HBJJOCHGOPH = 1343f;
			}
			this.JFDGLLEOPGB().SetFloat(".", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("<size=24>", (float)this.Level);
			this.ACHNOHCLGOO().SetVector(" : ", this.Distance);
			this.IIJMIPBMMBF().SetVector("seconds", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1218f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x000A6410 File Offset: 0x000A4610
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1143f)
			{
				this.HBJJOCHGOPH = 1314f;
			}
			this.KGOLDDBHIFN().SetFloat("Keypad", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_MainTex", (float)this.Level);
			this.EFDEIFCDAFG().SetVector(".sav", this.Distance);
			this.ACHNOHCLGOO().SetVector("NEW_ACHIEVEMENT_1_21", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 716f, 66f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x000A6518 File Offset: 0x000A4718
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1988f)
			{
				this.HBJJOCHGOPH = 1245f;
			}
			this.PDEAHJPOMEF().SetFloat("b", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", (float)this.Level);
			this.JFDGLLEOPGB().SetVector("RULES", this.Distance);
			this.KGOLDDBHIFN().SetVector("OpGetGameList not sent. LobbyType must be SqlLobby.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1018f, 1660f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x000A65F1 File Offset: 0x000A47F1
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x000A6628 File Offset: 0x000A4828
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x000A6660 File Offset: 0x000A4860
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 951f)
			{
				this.HBJJOCHGOPH = 631f;
			}
			this.DBOLLHHMKKN().SetFloat("Submit", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("bad", (float)this.Level);
			this.DBOLLHHMKKN().SetVector("[RanksSystem] Ranks updated. Next update: ", this.Distance);
			this.ACHNOHCLGOO().SetVector("JoinButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 97f, 1961f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x000A6739 File Offset: 0x000A4939
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Film_Grain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x000A5C62 File Offset: 0x000A3E62
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x000A675D File Offset: 0x000A495D
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x000A6781 File Offset: 0x000A4981
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x000A67B8 File Offset: 0x000A49B8
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x000A5C62 File Offset: 0x000A3E62
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040003AD RID: 941
	public Shader SCShader;

	// Token: 0x040003AE RID: 942
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003AF RID: 943
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003B0 RID: 944
	private Material BJFKDHHMLJH;

	// Token: 0x040003B1 RID: 945
	[Range(2f, 16f)]
	public int Level = 4;

	// Token: 0x040003B2 RID: 946
	public Vector2 Distance = new Vector2(30f, 0f);
}
