using System;
using UnityEngine;

// Token: 0x020000CD RID: 205
[AddComponentMenu("Camera Filter Pack/FX/Hexagon_Black")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Hexagon_Black : MonoBehaviour
{
	// Token: 0x06003DDC RID: 15836 RVA: 0x00134E7A File Offset: 0x0013307A
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DDD RID: 15837 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06003DDE RID: 15838 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06003DDF RID: 15839 RVA: 0x00134EB1 File Offset: 0x001330B1
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DE0 RID: 15840 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06003DE1 RID: 15841 RVA: 0x00134EE8 File Offset: 0x001330E8
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DE2 RID: 15842 RVA: 0x00134F1F File Offset: 0x0013311F
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find(" methods \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DE3 RID: 15843 RVA: 0x00134F44 File Offset: 0x00133144
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 442f)
			{
				this.HBJJOCHGOPH = 979f;
			}
			this.FGENHBKMPDA().SetFloat("Distortion", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("settings.enablehitsoundsinrelax", this.Value);
			this.NLFJGMBCICG().SetVector("_LowRez", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1871f, 525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DE4 RID: 15844 RVA: 0x00135001 File Offset: 0x00133201
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("OnReadyClick");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003DE5 RID: 15845 RVA: 0x00135025 File Offset: 0x00133225
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("_Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DE6 RID: 15846 RVA: 0x0013504C File Offset: 0x0013324C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 875f)
			{
				this.HBJJOCHGOPH = 731f;
			}
			this.NBMPPNFKFLB().SetFloat("[Left]", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("achievements.21.completed.", this.Value);
			this.MICHFGAOPKM().SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 223f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DE7 RID: 15847 RVA: 0x00135109 File Offset: 0x00133309
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DE8 RID: 15848 RVA: 0x00135140 File Offset: 0x00133340
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DE9 RID: 15849 RVA: 0x00135177 File Offset: 0x00133377
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DEA RID: 15850 RVA: 0x00135194 File Offset: 0x00133394
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 255f)
			{
				this.HBJJOCHGOPH = 455f;
			}
			this.PDEAHJPOMEF().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("A", this.Value);
			this.PDEAHJPOMEF().SetVector("mapselector.lastSearch", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1122f, 333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DEB RID: 15851 RVA: 0x00135251 File Offset: 0x00133451
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DEC RID: 15852 RVA: 0x00135278 File Offset: 0x00133478
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1561f)
			{
				this.HBJJOCHGOPH = 1436f;
			}
			this.KOHGPKOFEJO().SetFloat("/", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("VisionBlur", this.Value);
			this.KOHGPKOFEJO().SetVector("No Name", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1255f, 383f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DED RID: 15853 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06003DEE RID: 15854 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06003DEF RID: 15855 RVA: 0x00135338 File Offset: 0x00133538
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 734f)
			{
				this.HBJJOCHGOPH = 1036f;
			}
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("turn", this.Value);
			this.PHGCJOPFDOG().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 650f, 585f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DF0 RID: 15856 RVA: 0x001353F8 File Offset: 0x001335F8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1956f)
			{
				this.HBJJOCHGOPH = 80f;
			}
			this.NBMPPNFKFLB().SetFloat("#mapby", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_MainTex2", this.Value);
			this.HHIAIGCAHDA().SetVector("CameraFilterPack/FX_Glitch1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 185f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DF1 RID: 15857 RVA: 0x001354B5 File Offset: 0x001336B5
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DF2 RID: 15858 RVA: 0x001354EC File Offset: 0x001336EC
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 566f)
			{
				this.HBJJOCHGOPH = 1663f;
			}
			this.NLFJGMBCICG().SetFloat("visible", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("SetSunColors", this.Value);
			this.PHGCJOPFDOG().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1802f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DF3 RID: 15859 RVA: 0x00135177 File Offset: 0x00133377
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DF4 RID: 15860 RVA: 0x001355A9 File Offset: 0x001337A9
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_Source");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DF5 RID: 15861 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06003DF6 RID: 15862 RVA: 0x001355D0 File Offset: 0x001337D0
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 235f)
			{
				this.HBJJOCHGOPH = 802f;
			}
			this.LONNIJMNKFB().SetFloat(" Server: ", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/Distortion_Twist_Square", this.Value);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Color_Convert_Normal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1450f, 1341f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DF7 RID: 15863 RVA: 0x0013568D File Offset: 0x0013388D
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("InfoText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003DF8 RID: 15864 RVA: 0x001356B1 File Offset: 0x001338B1
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003DF9 RID: 15865 RVA: 0x001356D5 File Offset: 0x001338D5
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DFA RID: 15866 RVA: 0x0013570C File Offset: 0x0013390C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 236f)
			{
				this.HBJJOCHGOPH = 1760f;
			}
			this.PHGCJOPFDOG().SetFloat("Alternative", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("[PlayerController] ", this.Value);
			this.MICHFGAOPKM().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 724f, 666f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DFB RID: 15867 RVA: 0x00135177 File Offset: 0x00133377
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DFC RID: 15868 RVA: 0x001357C9 File Offset: 0x001339C9
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DFD RID: 15869 RVA: 0x00135800 File Offset: 0x00133A00
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Hexagon_Black");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DFE RID: 15870 RVA: 0x00135824 File Offset: 0x00133A24
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1716f)
			{
				this.HBJJOCHGOPH = 1914f;
			}
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack_eyes_vision_1", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("  |  Events Count: ", this.Value);
			this.MICHFGAOPKM().SetVector("StartTime already set: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1472f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DFF RID: 15871 RVA: 0x00135177 File Offset: 0x00133377
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E00 RID: 15872 RVA: 0x00135177 File Offset: 0x00133377
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E01 RID: 15873 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06003E02 RID: 15874 RVA: 0x001358E1 File Offset: 0x00133AE1
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E03 RID: 15875 RVA: 0x00135918 File Offset: 0x00133B18
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1866f)
			{
				this.HBJJOCHGOPH = 772f;
			}
			this.LPCHMEKDCHI().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat(".message", this.Value);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 224f, 535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E04 RID: 15876 RVA: 0x001359D5 File Offset: 0x00133BD5
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E05 RID: 15877 RVA: 0x001359FC File Offset: 0x00133BFC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E06 RID: 15878 RVA: 0x00135AB9 File Offset: 0x00133CB9
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("Save level before uploading?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E07 RID: 15879 RVA: 0x00135177 File Offset: 0x00133377
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E08 RID: 15880 RVA: 0x00135AE0 File Offset: 0x00133CE0
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 865f)
			{
				this.HBJJOCHGOPH = 247f;
			}
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Antialiasing_FXAA", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("_Linecount", this.Value);
			this.GKILCDHJFEG().SetVector("_Overlay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1119f, 903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E09 RID: 15881 RVA: 0x00135B9D File Offset: 0x00133D9D
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E0A RID: 15882 RVA: 0x00135BC4 File Offset: 0x00133DC4
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 73f)
			{
				this.HBJJOCHGOPH = 1146f;
			}
			this.HCGJCMDJPGD().SetFloat("/512px-512px.png", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("Server: {0}. Region: {1} ", this.Value);
			this.NBMPPNFKFLB().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 766f, 515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E0B RID: 15883 RVA: 0x00135C81 File Offset: 0x00133E81
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06003E0D RID: 15885 RVA: 0x00135CD6 File Offset: 0x00133ED6
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

	// Token: 0x06003E0E RID: 15886 RVA: 0x00135177 File Offset: 0x00133377
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E0F RID: 15887 RVA: 0x00135D0D File Offset: 0x00133F0D
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E10 RID: 15888 RVA: 0x00135D44 File Offset: 0x00133F44
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 76f)
			{
				this.HBJJOCHGOPH = 97f;
			}
			this.IONHGBPGCHK().SetFloat("TStart", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_Value2", this.Value);
			this.IONHGBPGCHK().SetVector("_SpherePositionY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1231f, 727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E11 RID: 15889 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06003E12 RID: 15890 RVA: 0x00135E01 File Offset: 0x00134001
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E13 RID: 15891 RVA: 0x00135177 File Offset: 0x00133377
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E14 RID: 15892 RVA: 0x00135E28 File Offset: 0x00134028
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1872f)
			{
				this.HBJJOCHGOPH = 550f;
			}
			this.HCGJCMDJPGD().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_Threshhold", this.Value);
			this.IONHGBPGCHK().SetVector("Crosshair", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1820f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E15 RID: 15893 RVA: 0x00135EE8 File Offset: 0x001340E8
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1848f)
			{
				this.HBJJOCHGOPH = 59f;
			}
			this.HHIAIGCAHDA().SetFloat("menu.selectedlevelid", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("settings.disablestoryboard", this.Value);
			this.NLFJGMBCICG().SetVector("_SSAO", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1204f, 1046f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E16 RID: 15894 RVA: 0x00135177 File Offset: 0x00133377
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E17 RID: 15895 RVA: 0x00135FA8 File Offset: 0x001341A8
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 356f)
			{
				this.HBJJOCHGOPH = 356f;
			}
			this.HCGJCMDJPGD().SetFloat(".workshop.json", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Closes the app", this.Value);
			this.NLFJGMBCICG().SetVector("_Green_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1234f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E18 RID: 15896 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06003E19 RID: 15897 RVA: 0x00135177 File Offset: 0x00133377
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E1A RID: 15898 RVA: 0x00136065 File Offset: 0x00134265
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("https://reddit.com/r/Intralism");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E1B RID: 15899 RVA: 0x0013608C File Offset: 0x0013428C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 882f)
			{
				this.HBJJOCHGOPH = 183f;
			}
			this.GKILCDHJFEG().SetFloat("Received OnSerialization for view ID ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("#accuracy", this.Value);
			this.MICHFGAOPKM().SetVector("_SprTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 407f, 1916f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E1C RID: 15900 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003E1D RID: 15901 RVA: 0x0013614C File Offset: 0x0013434C
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1939f)
			{
				this.HBJJOCHGOPH = 1585f;
			}
			this.LPCHMEKDCHI().SetFloat("#exit", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", this.Value);
			this.FHFLKLMFHOI().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 632f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E1E RID: 15902 RVA: 0x0013620C File Offset: 0x0013440C
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 85f)
			{
				this.HBJJOCHGOPH = 224f;
			}
			this.NBPKMLMCHFN.SetFloat("LevelInfoInputField", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("[PlayerController] ", this.Value);
			this.NBMPPNFKFLB().SetVector("<i>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 142f, 225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E1F RID: 15903 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06003E20 RID: 15904 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06003E21 RID: 15905 RVA: 0x001362C9 File Offset: 0x001344C9
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E22 RID: 15906 RVA: 0x00136300 File Offset: 0x00134500
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E23 RID: 15907 RVA: 0x00136338 File Offset: 0x00134538
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 124f)
			{
				this.HBJJOCHGOPH = 256f;
			}
			this.NBMPPNFKFLB().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("OnSerialize", this.Value);
			this.GKILCDHJFEG().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1538f, 115f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E24 RID: 15908 RVA: 0x001363F8 File Offset: 0x001345F8
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1574f)
			{
				this.HBJJOCHGOPH = 1875f;
			}
			this.IONHGBPGCHK().SetFloat("{0}", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Error: I/O Failure! :(", this.Value);
			this.HHIAIGCAHDA().SetVector("Connecting", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1623f, 357f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E25 RID: 15909 RVA: 0x001364B5 File Offset: 0x001346B5
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E26 RID: 15910 RVA: 0x001364EC File Offset: 0x001346EC
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E27 RID: 15911 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06003E28 RID: 15912 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06003E29 RID: 15913 RVA: 0x00136523 File Offset: 0x00134723
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E2A RID: 15914 RVA: 0x00136547 File Offset: 0x00134747
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E2B RID: 15915 RVA: 0x0013656B File Offset: 0x0013476B
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E2C RID: 15916 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06003E2D RID: 15917 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06003E2E RID: 15918 RVA: 0x00135177 File Offset: 0x00133377
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E2F RID: 15919 RVA: 0x00135177 File Offset: 0x00133377
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E30 RID: 15920 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003E31 RID: 15921 RVA: 0x00135177 File Offset: 0x00133377
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E32 RID: 15922 RVA: 0x001365A2 File Offset: 0x001347A2
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E33 RID: 15923 RVA: 0x001365D9 File Offset: 0x001347D9
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("[PlayerBase] Unknown event: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E34 RID: 15924 RVA: 0x001365FD File Offset: 0x001347FD
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E35 RID: 15925 RVA: 0x00135177 File Offset: 0x00133377
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E36 RID: 15926 RVA: 0x00136624 File Offset: 0x00134824
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 435f)
			{
				this.HBJJOCHGOPH = 1904f;
			}
			this.KAFBNOBOIAJ().SetFloat("Skipping EstablishEncryption. Protocol is secure.", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_Value4", this.Value);
			this.KOHGPKOFEJO().SetVector("NEW_ACHIEVEMENT_1_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 82f, 653f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E37 RID: 15927 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x001366E4 File Offset: 0x001348E4
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1830f)
			{
				this.HBJJOCHGOPH = 790f;
			}
			this.GKILCDHJFEG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat(": ", this.Value);
			this.FGENHBKMPDA().SetVector("_Blue_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1331f, 1570f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E39 RID: 15929 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003E3A RID: 15930 RVA: 0x001367A1 File Offset: 0x001349A1
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("CrosshairOpacitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E3B RID: 15931 RVA: 0x001367C5 File Offset: 0x001349C5
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("rarity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E3C RID: 15932 RVA: 0x001367EC File Offset: 0x001349EC
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1411f)
			{
				this.HBJJOCHGOPH = 795f;
			}
			this.GKILCDHJFEG().SetFloat("Joystick1Button0", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("menu.selectedlevelid", this.Value);
			this.HHIAIGCAHDA().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 774f, 1257f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E3D RID: 15933 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06003E3E RID: 15934 RVA: 0x001368A9 File Offset: 0x00134AA9
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("bad");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040006B4 RID: 1716
	public Shader SCShader;

	// Token: 0x040006B5 RID: 1717
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006B6 RID: 1718
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006B7 RID: 1719
	private Material BJFKDHHMLJH;

	// Token: 0x040006B8 RID: 1720
	[Range(0.2f, 10f)]
	public float Value = 1f;
}
