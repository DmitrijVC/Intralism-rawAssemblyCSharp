using System;
using UnityEngine;

// Token: 0x020000BD RID: 189
[AddComponentMenu("Camera Filter Pack/Pixel/8bits")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_8bits : MonoBehaviour
{
	// Token: 0x0600397C RID: 14716 RVA: 0x0012356A File Offset: 0x0012176A
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600397D RID: 14717 RVA: 0x00123587 File Offset: 0x00121787
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600397E RID: 14718 RVA: 0x001235BE File Offset: 0x001217BE
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_TapLow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600397F RID: 14719 RVA: 0x0012356A File Offset: 0x0012176A
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003980 RID: 14720 RVA: 0x0012356A File Offset: 0x0012176A
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003981 RID: 14721 RVA: 0x001235E4 File Offset: 0x001217E4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 731f)
			{
				this.HBJJOCHGOPH = 99f;
			}
			this.PDEAHJPOMEF().SetFloat("finished", this.HBJJOCHGOPH);
			if (this.Brightness == 666f)
			{
				this.Brightness = 657f;
			}
			this.LDNADDJMIPK().SetFloat("_Value4", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(this.ResolutionX, this.ResolutionY, 0);
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

	// Token: 0x06003982 RID: 14722 RVA: 0x0012356A File Offset: 0x0012176A
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003983 RID: 14723 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x001236B6 File Offset: 0x001218B6
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x001236DA File Offset: 0x001218DA
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06003986 RID: 14726 RVA: 0x001236FE File Offset: 0x001218FE
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

	// Token: 0x06003987 RID: 14727 RVA: 0x00123738 File Offset: 0x00121938
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 782f)
			{
				this.HBJJOCHGOPH = 1963f;
			}
			this.KAFBNOBOIAJ().SetFloat("_HighlightSuppression", this.HBJJOCHGOPH);
			if (this.Brightness == 824f)
			{
				this.Brightness = 1725f;
			}
			this.PDEAHJPOMEF().SetFloat("SetParticlesCountPerBeat", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(this.ResolutionX, this.ResolutionY, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.LDNADDJMIPK());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x0012356A File Offset: 0x0012176A
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x0012356A File Offset: 0x0012176A
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600398A RID: 14730 RVA: 0x0012380A File Offset: 0x00121A0A
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600398B RID: 14731 RVA: 0x0012382E File Offset: 0x00121A2E
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600398C RID: 14732 RVA: 0x00123865 File Offset: 0x00121A65
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600398E RID: 14734 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600398F RID: 14735 RVA: 0x001238C5 File Offset: 0x00121AC5
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003990 RID: 14736 RVA: 0x0012356A File Offset: 0x0012176A
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003991 RID: 14737 RVA: 0x001238EC File Offset: 0x00121AEC
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1910f)
			{
				this.HBJJOCHGOPH = 1156f;
			}
			this.HFBJAOFLCJI().SetFloat("LevelEditor/CustomEventEditor-Text", this.HBJJOCHGOPH);
			if (this.Brightness == 1611f)
			{
				this.Brightness = 385f;
			}
			this.KAFBNOBOIAJ().SetFloat("Avoid using this directly. Thanks.", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(this.ResolutionX, this.ResolutionY, 0);
			Graphics.Blit(AAACLELCPML, temporary, this.LDNADDJMIPK());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003992 RID: 14738 RVA: 0x0012356A File Offset: 0x0012176A
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003993 RID: 14739 RVA: 0x001239BE File Offset: 0x00121BBE
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003994 RID: 14740 RVA: 0x001239E2 File Offset: 0x00121BE2
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003995 RID: 14741 RVA: 0x0012356A File Offset: 0x0012176A
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x0012356A File Offset: 0x0012176A
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003998 RID: 14744 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06003999 RID: 14745 RVA: 0x0012356A File Offset: 0x0012176A
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600399A RID: 14746 RVA: 0x00123A19 File Offset: 0x00121C19
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_8bits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600399B RID: 14747 RVA: 0x00123A40 File Offset: 0x00121C40
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 907f)
			{
				this.HBJJOCHGOPH = 468f;
			}
			this.EFDEIFCDAFG().SetFloat("SetParent", this.HBJJOCHGOPH);
			if (this.Brightness == 1463f)
			{
				this.Brightness = 881f;
			}
			this.LDNADDJMIPK().SetFloat("Text", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(this.ResolutionX, this.ResolutionY, 1);
			Graphics.Blit(AAACLELCPML, temporary, this.PDEAHJPOMEF());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600399C RID: 14748 RVA: 0x00123B14 File Offset: 0x00121D14
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1056f)
			{
				this.HBJJOCHGOPH = 1956f;
			}
			this.LDNADDJMIPK().SetFloat("Exception while connecting to: ", this.HBJJOCHGOPH);
			if (this.Brightness == 1727f)
			{
				this.Brightness = 796f;
			}
			this.EFDEIFCDAFG().SetFloat("_ChangeBlue", this.Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(this.ResolutionX, this.ResolutionY, 1);
			Graphics.Blit(AAACLELCPML, temporary, this.EFDEIFCDAFG());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600399D RID: 14749 RVA: 0x0012356A File Offset: 0x0012176A
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600399E RID: 14750 RVA: 0x0012356A File Offset: 0x0012176A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600399F RID: 14751 RVA: 0x00123BE6 File Offset: 0x00121DE6
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039A0 RID: 14752 RVA: 0x00123C20 File Offset: 0x00121E20
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
			RenderTexture temporary = RenderTexture.GetTemporary(this.ResolutionX, this.ResolutionY, 0);
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

	// Token: 0x04000649 RID: 1609
	public Shader SCShader;

	// Token: 0x0400064A RID: 1610
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400064B RID: 1611
	private Material BJFKDHHMLJH;

	// Token: 0x0400064C RID: 1612
	[Range(-1f, 1f)]
	public float Brightness;

	// Token: 0x0400064D RID: 1613
	[Range(80f, 640f)]
	public int ResolutionX = 160;

	// Token: 0x0400064E RID: 1614
	[Range(60f, 480f)]
	public int ResolutionY = 240;
}
