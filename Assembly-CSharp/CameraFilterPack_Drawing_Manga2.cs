using System;
using UnityEngine;

// Token: 0x020000A6 RID: 166
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Manga2")]
public class CameraFilterPack_Drawing_Manga2 : MonoBehaviour
{
	// Token: 0x060031C3 RID: 12739 RVA: 0x00106946 File Offset: 0x00104B46
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031C4 RID: 12740 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060031C5 RID: 12741 RVA: 0x00106963 File Offset: 0x00104B63
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031C6 RID: 12742 RVA: 0x00106987 File Offset: 0x00104B87
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x060031C8 RID: 12744 RVA: 0x001069BE File Offset: 0x00104BBE
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031C9 RID: 12745 RVA: 0x001069F5 File Offset: 0x00104BF5
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031CA RID: 12746 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060031CB RID: 12747 RVA: 0x00106A19 File Offset: 0x00104C19
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("USE_UV_BASED_REPROJECTION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x00106A3D File Offset: 0x00104C3D
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x00106A74 File Offset: 0x00104C74
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find(";");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031CE RID: 12750 RVA: 0x00106A98 File Offset: 0x00104C98
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031CF RID: 12751 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x060031D0 RID: 12752 RVA: 0x00106ACF File Offset: 0x00104CCF
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031D1 RID: 12753 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060031D2 RID: 12754 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060031D3 RID: 12755 RVA: 0x00106AF4 File Offset: 0x00104CF4
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1511f)
			{
				this.HBJJOCHGOPH = 1026f;
			}
			this.GJHLADDCMFF().SetFloat("player.deleted", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Manga_Flash", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031D4 RID: 12756 RVA: 0x00106B84 File Offset: 0x00104D84
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031D5 RID: 12757 RVA: 0x00106946 File Offset: 0x00104B46
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x00106BA8 File Offset: 0x00104DA8
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 237f)
			{
				this.HBJJOCHGOPH = 1215f;
			}
			this.DNLMFEGJJDD().SetFloat("D-Pad Down", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("[ImageLoader] Loaded image from ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031D7 RID: 12759 RVA: 0x00106946 File Offset: 0x00104B46
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x00106C38 File Offset: 0x00104E38
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 518f)
			{
				this.HBJJOCHGOPH = 637f;
			}
			this.HNICHJCGJOC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("SlidingArea", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x00106CC8 File Offset: 0x00104EC8
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031DA RID: 12762 RVA: 0x00106CFF File Offset: 0x00104EFF
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("Hex value #RRGGBB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031DB RID: 12763 RVA: 0x00106D23 File Offset: 0x00104F23
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("OnRelease");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x00106946 File Offset: 0x00104B46
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031DD RID: 12765 RVA: 0x00106D48 File Offset: 0x00104F48
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 91f)
			{
				this.HBJJOCHGOPH = 1902f;
			}
			this.GKILCDHJFEG().SetFloat("RecieveChatActionMessage", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("_ScreenResolution", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031DE RID: 12766 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060031DF RID: 12767 RVA: 0x00106DD8 File Offset: 0x00104FD8
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("accuracy");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031E0 RID: 12768 RVA: 0x00106DFC File Offset: 0x00104FFC
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1964f)
			{
				this.HBJJOCHGOPH = 1610f;
			}
			this.IONHGBPGCHK().SetFloat("DISTORT", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("ticket", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031E1 RID: 12769 RVA: 0x00106E8C File Offset: 0x0010508C
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031E2 RID: 12770 RVA: 0x00106EC3 File Offset: 0x001050C3
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("ns");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031E3 RID: 12771 RVA: 0x00106946 File Offset: 0x00104B46
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031E4 RID: 12772 RVA: 0x00106946 File Offset: 0x00104B46
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031E5 RID: 12773 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060031E6 RID: 12774 RVA: 0x00106EE8 File Offset: 0x001050E8
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
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031E7 RID: 12775 RVA: 0x00106F78 File Offset: 0x00105178
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031E8 RID: 12776 RVA: 0x00106FB0 File Offset: 0x001051B0
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1383f)
			{
				this.HBJJOCHGOPH = 1982f;
			}
			this.NBMPPNFKFLB().SetFloat("CameraFilterPack/Noise_TV_2", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_TimeX", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031E9 RID: 12777 RVA: 0x00106946 File Offset: 0x00104B46
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x00107040 File Offset: 0x00105240
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("_FadeFromBinary");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031EB RID: 12779 RVA: 0x00107064 File Offset: 0x00105264
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031EC RID: 12780 RVA: 0x0010709B File Offset: 0x0010529B
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031ED RID: 12781 RVA: 0x00106946 File Offset: 0x00104B46
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031EE RID: 12782 RVA: 0x001070D2 File Offset: 0x001052D2
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031EF RID: 12783 RVA: 0x00106946 File Offset: 0x00104B46
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031F0 RID: 12784 RVA: 0x0010710C File Offset: 0x0010530C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 834f)
			{
				this.HBJJOCHGOPH = 1974f;
			}
			this.NBPKMLMCHFN.SetFloat("_ColorRGB", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031F1 RID: 12785 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060031F2 RID: 12786 RVA: 0x00106946 File Offset: 0x00104B46
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031F3 RID: 12787 RVA: 0x0010719C File Offset: 0x0010539C
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("#failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031F4 RID: 12788 RVA: 0x001071C0 File Offset: 0x001053C0
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031F5 RID: 12789 RVA: 0x001071F7 File Offset: 0x001053F7
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x0010721C File Offset: 0x0010541C
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 361f)
			{
				this.HBJJOCHGOPH = 1841f;
			}
			this.IONHGBPGCHK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Noise shaders are not set up! Disabling noise effect.", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031F8 RID: 12792 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060031F9 RID: 12793 RVA: 0x001072AC File Offset: 0x001054AC
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031FA RID: 12794 RVA: 0x001072D0 File Offset: 0x001054D0
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1926f)
			{
				this.HBJJOCHGOPH = 1339f;
			}
			this.IONHGBPGCHK().SetFloat("_Noise", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("#failed!", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031FB RID: 12795 RVA: 0x00107360 File Offset: 0x00105560
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1010f)
			{
				this.HBJJOCHGOPH = 1971f;
			}
			this.FAIFBBGFAIB().SetFloat("Joystick1Button0", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_DiffuseColor", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031FC RID: 12796 RVA: 0x001073F0 File Offset: 0x001055F0
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031FD RID: 12797 RVA: 0x00106946 File Offset: 0x00104B46
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031FE RID: 12798 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060031FF RID: 12799 RVA: 0x00107427 File Offset: 0x00105627
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("settings_bindings_sec_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003200 RID: 12800 RVA: 0x0010744B File Offset: 0x0010564B
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("Working.\nPlease wait..");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003201 RID: 12801 RVA: 0x0010746F File Offset: 0x0010566F
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("Please specify a map name or buildID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x00107493 File Offset: 0x00105693
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003203 RID: 12803 RVA: 0x00106946 File Offset: 0x00104B46
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06003204 RID: 12804 RVA: 0x001074CA File Offset: 0x001056CA
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

	// Token: 0x06003205 RID: 12805 RVA: 0x00106946 File Offset: 0x00104B46
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003206 RID: 12806 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x00107501 File Offset: 0x00105701
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003208 RID: 12808 RVA: 0x00106946 File Offset: 0x00104B46
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003209 RID: 12809 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x0600320A RID: 12810 RVA: 0x00107538 File Offset: 0x00105738
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find(" BETA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600320B RID: 12811 RVA: 0x0010755C File Offset: 0x0010575C
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("FPSToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600320C RID: 12812 RVA: 0x00107580 File Offset: 0x00105780
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600320D RID: 12813 RVA: 0x001075A4 File Offset: 0x001057A4
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600320E RID: 12814 RVA: 0x001075C8 File Offset: 0x001057C8
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600320F RID: 12815 RVA: 0x001075EC File Offset: 0x001057EC
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003211 RID: 12817 RVA: 0x00107641 File Offset: 0x00105841
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("mainMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040005AD RID: 1453
	public Shader SCShader;

	// Token: 0x040005AE RID: 1454
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005AF RID: 1455
	private Material BJFKDHHMLJH;

	// Token: 0x040005B0 RID: 1456
	[Range(1f, 8f)]
	public float DotSize = 4.72f;
}
