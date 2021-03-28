using System;
using UnityEngine;

// Token: 0x020000C0 RID: 192
[AddComponentMenu("Camera Filter Pack/FX/DarkMatter")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_DarkMatter : MonoBehaviour
{
	// Token: 0x060039FC RID: 14844 RVA: 0x00125673 File Offset: 0x00123873
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x00125690 File Offset: 0x00123890
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("FinalScoreSmallText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039FE RID: 14846 RVA: 0x001256B4 File Offset: 0x001238B4
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x00125673 File Offset: 0x00123873
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06003A02 RID: 14850 RVA: 0x0012574C File Offset: 0x0012394C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 767f)
			{
				this.HBJJOCHGOPH = 1197f;
			}
			this.DNLMFEGJJDD().SetFloat("F3", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("\n", this.Speed);
			this.DBOLLHHMKKN().SetFloat("No child content found, exiting..", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("StartButton", this.PosX);
			this.OIMMPLPBLBK().SetFloat("_BlurParams", this.PosY);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Zoom);
			this.DNLMFEGJJDD().SetFloat("settings.arcsnohitsoundtimedelay", this.DarkIntensity);
			this.DBOLLHHMKKN().SetVector("CameraFilterPack/Blur_Movie", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 1499f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A03 RID: 14851 RVA: 0x00125877 File Offset: 0x00123A77
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A04 RID: 14852 RVA: 0x001258B0 File Offset: 0x00123AB0
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 182f)
			{
				this.HBJJOCHGOPH = 485f;
			}
			this.DBOLLHHMKKN().SetFloat(": ", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/Blur_Blurry", this.Speed);
			this.DNLMFEGJJDD().SetFloat("Tried to Initialize the SteamAPI twice in one session!", this.Intensity);
			this.DNLMFEGJJDD().SetFloat("SetParticlesColor", this.PosX);
			this.DBOLLHHMKKN().SetFloat("x", this.PosY);
			this.DBOLLHHMKKN().SetFloat("#,0.00", this.Zoom);
			this.OIMMPLPBLBK().SetFloat("_Visualize", this.DarkIntensity);
			this.DBOLLHHMKKN().SetVector("_EmissionColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 884f, 1781f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A05 RID: 14853 RVA: 0x00125673 File Offset: 0x00123873
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A06 RID: 14854 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003A07 RID: 14855 RVA: 0x001259DC File Offset: 0x00123BDC
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1867f)
			{
				this.HBJJOCHGOPH = 724f;
			}
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/3D_BlackHole", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat(" | Level: ", this.Speed);
			this.DBOLLHHMKKN().SetFloat(".icon", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.PosX);
			this.OIMMPLPBLBK().SetFloat("#updateoutdatedmap", this.PosY);
			this.OIMMPLPBLBK().SetFloat("TimeBGSlider", this.Zoom);
			this.DBOLLHHMKKN().SetFloat("Please attach component to a Graphical UI component", this.DarkIntensity);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 64f, 1836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A08 RID: 14856 RVA: 0x00125B07 File Offset: 0x00123D07
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_DarkMatter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A09 RID: 14857 RVA: 0x00125B2B File Offset: 0x00123D2B
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find(" to: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A0A RID: 14858 RVA: 0x00125B4F File Offset: 0x00123D4F
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("Have you fully accept the terms?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A0B RID: 14859 RVA: 0x00125673 File Offset: 0x00123873
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A0C RID: 14860 RVA: 0x00125B74 File Offset: 0x00123D74
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1661f)
			{
				this.HBJJOCHGOPH = 1862f;
			}
			this.DNLMFEGJJDD().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack_3D_Computer1", this.Speed);
			this.DBOLLHHMKKN().SetFloat("\" for viewID ", this.Intensity);
			this.DNLMFEGJJDD().SetFloat("SetSatelliteSensitivity", this.PosX);
			this.DBOLLHHMKKN().SetFloat("Texture2", this.PosY);
			this.NBPKMLMCHFN.SetFloat("SpawnObj", this.Zoom);
			this.DBOLLHHMKKN().SetFloat("#", this.DarkIntensity);
			this.OIMMPLPBLBK().SetVector("HightScoreMaxPointsText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 832f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00125C9F File Offset: 0x00123E9F
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

	// Token: 0x06003A0E RID: 14862 RVA: 0x00125CD6 File Offset: 0x00123ED6
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A0F RID: 14863 RVA: 0x00125D10 File Offset: 0x00123F10
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Zoom);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.DarkIntensity);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000659 RID: 1625
	public Shader SCShader;

	// Token: 0x0400065A RID: 1626
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400065B RID: 1627
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400065C RID: 1628
	private Material BJFKDHHMLJH;

	// Token: 0x0400065D RID: 1629
	[Range(-10f, 10f)]
	public float Speed = 0.8f;

	// Token: 0x0400065E RID: 1630
	[Range(0f, 1f)]
	public float Intensity = 1f;

	// Token: 0x0400065F RID: 1631
	[Range(-1f, 2f)]
	public float PosX = 0.5f;

	// Token: 0x04000660 RID: 1632
	[Range(-1f, 2f)]
	public float PosY = 0.5f;

	// Token: 0x04000661 RID: 1633
	[Range(-2f, 2f)]
	public float Zoom = 0.33f;

	// Token: 0x04000662 RID: 1634
	[Range(0f, 5f)]
	public float DarkIntensity = 2f;
}
