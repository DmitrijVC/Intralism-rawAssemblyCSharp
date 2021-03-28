using System;
using UnityEngine;

// Token: 0x0200006E RID: 110
[AddComponentMenu("Camera Filter Pack/Colors/Chromatic_Plus")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Chromatic_Plus : MonoBehaviour
{
	// Token: 0x06001E84 RID: 7812 RVA: 0x000B6F3C File Offset: 0x000B513C
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000B6F60 File Offset: 0x000B5160
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

	// Token: 0x06001E88 RID: 7816 RVA: 0x000B6F97 File Offset: 0x000B5197
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x000B6FBB File Offset: 0x000B51BB
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x000B6FF2 File Offset: 0x000B51F2
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("PointsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x000B7016 File Offset: 0x000B5216
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("_ExtraLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x000B703A File Offset: 0x000B523A
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("_History3LumaTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x000B7094 File Offset: 0x000B5294
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1874f)
			{
				this.HBJJOCHGOPH = 1397f;
			}
			this.LONNIJMNKFB().SetFloat("_Near", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("Set satellite color", this.Size);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Smooth);
			this.LONNIJMNKFB().SetFloat("Crosshair2", this.Offset);
			this.KHCLIAMBBNC().SetVector("closed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1653f, 956f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x000B717D File Offset: 0x000B537D
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x000B719A File Offset: 0x000B539A
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x000B71D1 File Offset: 0x000B53D1
	private Material ALABBJPHCNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x000B7208 File Offset: 0x000B5408
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x000B722C File Offset: 0x000B542C
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("[NetworkScene] Exited");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x000B717D File Offset: 0x000B537D
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x000B7250 File Offset: 0x000B5450
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x000B7287 File Offset: 0x000B5487
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x000B717D File Offset: 0x000B537D
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x000B72BE File Offset: 0x000B54BE
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x000B72F8 File Offset: 0x000B54F8
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 710f)
			{
				this.HBJJOCHGOPH = 608f;
			}
			this.KEMJNOMIPHN().SetFloat("mapselector.tags.", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("seconds", this.Size);
			this.MMOODGIODPC().SetFloat("_Near", this.Smooth);
			this.DEFBJOCJJKF().SetFloat("GUICamera", this.Offset);
			this.NBPKMLMCHFN.SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1613f, 1756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x000B73E1 File Offset: 0x000B55E1
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("SpeedSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x000B7405 File Offset: 0x000B5605
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x000B717D File Offset: 0x000B537D
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x000B743C File Offset: 0x000B563C
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1779f)
			{
				this.HBJJOCHGOPH = 1209f;
			}
			this.JLHLHKPHDFO().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("DPADHOR", this.Size);
			this.ALABBJPHCNG().SetFloat("CameraFilterPack/Pixelisation_OilPaint", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Offset);
			this.GCDFNHMJMIP().SetVector("GameMessagesDurationSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1795f, 1326f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x000B7525 File Offset: 0x000B5725
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x000B7549 File Offset: 0x000B5749
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("Created by ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x000B756D File Offset: 0x000B576D
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x000B7591 File Offset: 0x000B5791
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x000B717D File Offset: 0x000B537D
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x000B75C8 File Offset: 0x000B57C8
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 38f)
			{
				this.HBJJOCHGOPH = 713f;
			}
			this.EHDJJANLINB().SetFloat("(\\[ */ *h1 *\\])", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("_Distortion", this.Size);
			this.EFMCNLELMDO().SetFloat("_Value", this.Smooth);
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.Offset);
			this.MLMKCOINOOH().SetVector("Horizontal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 809f, 960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x000B717D File Offset: 0x000B537D
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x000B717D File Offset: 0x000B537D
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x000B76B1 File Offset: 0x000B58B1
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Chromatic_Plus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x000B717D File Offset: 0x000B537D
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x000B717D File Offset: 0x000B537D
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x000B76D8 File Offset: 0x000B58D8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1304f)
			{
				this.HBJJOCHGOPH = 1794f;
			}
			this.EFMCNLELMDO().SetFloat(" respawn in future: ", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat(" not exist", this.Size);
			this.MMOODGIODPC().SetFloat("value", this.Smooth);
			this.EFMCNLELMDO().SetFloat("_Value4", this.Offset);
			this.FOOCJIDNGBB().SetVector("_PositionX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1675f, 1263f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x000B77C4 File Offset: 0x000B59C4
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 240f)
			{
				this.HBJJOCHGOPH = 970f;
			}
			this.EFMCNLELMDO().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat(" is set to dontSave = true, continuing loop.", this.Size);
			this.LONNIJMNKFB().SetFloat("_Value4", this.Smooth);
			this.EFMCNLELMDO().SetFloat("#C8C8C8FF", this.Offset);
			this.MMOODGIODPC().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1618f, 285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x000B78AD File Offset: 0x000B5AAD
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x000B717D File Offset: 0x000B537D
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x000B717D File Offset: 0x000B537D
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x000B717D File Offset: 0x000B537D
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x000B78D4 File Offset: 0x000B5AD4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Offset);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x000B79BD File Offset: 0x000B5BBD
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x000B79F4 File Offset: 0x000B5BF4
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x000B7A2B File Offset: 0x000B5C2B
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x000B7A62 File Offset: 0x000B5C62
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x000B717D File Offset: 0x000B537D
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x000B7A99 File Offset: 0x000B5C99
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x000B717D File Offset: 0x000B537D
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x000B7A2B File Offset: 0x000B5C2B
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x000B717D File Offset: 0x000B537D
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x000B717D File Offset: 0x000B537D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x000B717D File Offset: 0x000B537D
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000B717D File Offset: 0x000B537D
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x000B7AD0 File Offset: 0x000B5CD0
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 102f)
			{
				this.HBJJOCHGOPH = 182f;
			}
			this.LPCHMEKDCHI().SetFloat("Joystick1Button9", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_TimeX", this.Size);
			this.MLMKCOINOOH().SetFloat("Object ID. Case-Sensitive", this.Smooth);
			this.KHCLIAMBBNC().SetFloat("_Value", this.Offset);
			this.DEFBJOCJJKF().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1811f, 1162f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x000B7BB9 File Offset: 0x000B5DB9
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("#mapmustbecompletebeforesubmit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x000B7BDD File Offset: 0x000B5DDD
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x000B7C14 File Offset: 0x000B5E14
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("Error: Cannot change the name of a remote player!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x000B717D File Offset: 0x000B537D
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x000B717D File Offset: 0x000B537D
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x000B7C38 File Offset: 0x000B5E38
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x000B7C6F File Offset: 0x000B5E6F
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x000B7CA6 File Offset: 0x000B5EA6
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("_Green_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x000B7CCC File Offset: 0x000B5ECC
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 106f)
			{
				this.HBJJOCHGOPH = 466f;
			}
			this.FOOCJIDNGBB().SetFloat("menu.selectedlevelid", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("on master", this.Size);
			this.KHCLIAMBBNC().SetFloat("[", this.Smooth);
			this.KEMJNOMIPHN().SetFloat("_Value2", this.Offset);
			this.KEMJNOMIPHN().SetVector("Reset All", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1337f, 4f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x000B7DB8 File Offset: 0x000B5FB8
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1810f)
			{
				this.HBJJOCHGOPH = 1337f;
			}
			this.EHDJJANLINB().SetFloat("#turnoninternet", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("settings.volume.sfx", this.Size);
			this.LELKBCALFCF().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", this.Smooth);
			this.ALABBJPHCNG().SetFloat("menu.tabid", this.Offset);
			this.LPCHMEKDCHI().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1661f, 1523f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x000B717D File Offset: 0x000B537D
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x000B7EA1 File Offset: 0x000B60A1
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x000B7EC5 File Offset: 0x000B60C5
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("_GrainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000B7EE9 File Offset: 0x000B60E9
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("Keypad ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x000B717D File Offset: 0x000B537D
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x000B7F0D File Offset: 0x000B610D
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x000B7F31 File Offset: 0x000B6131
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x000B7F68 File Offset: 0x000B6168
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_WaterDropPro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x000B7F8C File Offset: 0x000B618C
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 750f)
			{
				this.HBJJOCHGOPH = 697f;
			}
			this.EFMCNLELMDO().SetFloat("/", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("catched: ", this.Size);
			this.MMOODGIODPC().SetFloat("RarityImage", this.Smooth);
			this.IFMAPIDFNLI().SetFloat("LevelURLInputField", this.Offset);
			this.KHCLIAMBBNC().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1347f, 386f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x000B717D File Offset: 0x000B537D
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x000B8075 File Offset: 0x000B6275
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x000B809C File Offset: 0x000B629C
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 607f)
			{
				this.HBJJOCHGOPH = 357f;
			}
			this.EFMCNLELMDO().SetFloat("OpJoinRoom()", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("z", this.Size);
			this.DOMEEFLPEPJ().SetFloat("]", this.Smooth);
			this.PHGCJOPFDOG().SetFloat("Speed", this.Offset);
			this.MMOODGIODPC().SetVector("Scene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 287f, 1891f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x000B8188 File Offset: 0x000B6388
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 473f)
			{
				this.HBJJOCHGOPH = 891f;
			}
			this.PHGCJOPFDOG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("EventData0DropDownList", this.Size);
			this.MLMKCOINOOH().SetFloat("_Factor", this.Smooth);
			this.KHCLIAMBBNC().SetFloat("_TimeX", this.Offset);
			this.MMOODGIODPC().SetVector("Did not read byte array properly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 354f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x000B717D File Offset: 0x000B537D
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x000B8274 File Offset: 0x000B6474
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1451f)
			{
				this.HBJJOCHGOPH = 798f;
			}
			this.ALABBJPHCNG().SetFloat("_SunPosition", this.HBJJOCHGOPH);
			this.ALABBJPHCNG().SetFloat("CameraFilterPack/BlurTiltShift_V", this.Size);
			this.LELKBCALFCF().SetFloat("CameraFilterPack_Glasses_On7", this.Smooth);
			this.MMOODGIODPC().SetFloat("/", this.Offset);
			this.JLHLHKPHDFO().SetVector("cancel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 708f, 816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x000B835D File Offset: 0x000B655D
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("menu.relaxinfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x000B8381 File Offset: 0x000B6581
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find(" Maybe GO was destroyed but RPC not cleaned up.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x000B83A5 File Offset: 0x000B65A5
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x000B717D File Offset: 0x000B537D
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x000B83C9 File Offset: 0x000B65C9
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("FreqVolume: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x000B717D File Offset: 0x000B537D
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x000B83ED File Offset: 0x000B65ED
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x000B8424 File Offset: 0x000B6624
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("settings.enablehitsoundsinrelax");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x000B717D File Offset: 0x000B537D
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x000B8448 File Offset: 0x000B6648
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find(" from: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x000B846C File Offset: 0x000B666C
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x000B84A3 File Offset: 0x000B66A3
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x000B84C7 File Offset: 0x000B66C7
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x000B717D File Offset: 0x000B537D
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x000B8500 File Offset: 0x000B6700
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 173f)
			{
				this.HBJJOCHGOPH = 1328f;
			}
			this.NBPKMLMCHFN.SetFloat("_Colorisation", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("_Value4", this.Size);
			this.KHCLIAMBBNC().SetFloat("SaveButton", this.Smooth);
			this.LONNIJMNKFB().SetFloat("Joystick1Button5", this.Offset);
			this.ALABBJPHCNG().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1043f, 1998f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x000B85EC File Offset: 0x000B67EC
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1290f)
			{
				this.HBJJOCHGOPH = 1712f;
			}
			this.EFMCNLELMDO().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("Set camera background color", this.Size);
			this.EFMCNLELMDO().SetFloat(" not exist", this.Smooth);
			this.IFMAPIDFNLI().SetFloat("Connected to NameServer.", this.Offset);
			this.PHGCJOPFDOG().SetVector("Is it practically possible?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1643f, 1934f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x000B86D5 File Offset: 0x000B68D5
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x000B86F9 File Offset: 0x000B68F9
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x000B717D File Offset: 0x000B537D
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400041D RID: 1053
	public Shader SCShader;

	// Token: 0x0400041E RID: 1054
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400041F RID: 1055
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000420 RID: 1056
	private Material BJFKDHHMLJH;

	// Token: 0x04000421 RID: 1057
	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	// Token: 0x04000422 RID: 1058
	[Range(0.01f, 0.4f)]
	public float Smooth = 0.26f;

	// Token: 0x04000423 RID: 1059
	[Range(-0.02f, 0.02f)]
	public float Offset = 0.005f;
}
