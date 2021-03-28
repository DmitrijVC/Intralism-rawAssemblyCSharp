using System;
using UnityEngine;

// Token: 0x020000C3 RID: 195
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Dot_Circle")]
public class CameraFilterPack_FX_Dot_Circle : MonoBehaviour
{
	// Token: 0x06003ADE RID: 15070 RVA: 0x00129458 File Offset: 0x00127658
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06003ADF RID: 15071 RVA: 0x00129475 File Offset: 0x00127675
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

	// Token: 0x06003AE0 RID: 15072 RVA: 0x001294AC File Offset: 0x001276AC
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 969f)
			{
				this.HBJJOCHGOPH = 914f;
			}
			this.NBPKMLMCHFN.SetFloat("<command>", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("ENABLE_EYE_ADAPTATION", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1653f, 1341f));
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x0012956C File Offset: 0x0012776C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 652f)
			{
				this.HBJJOCHGOPH = 1984f;
			}
			this.NBPKMLMCHFN.SetFloat("_Noise", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("mapselector.filter.officialsortmode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1928f, 398f));
			this.NBPKMLMCHFN.SetFloat("ConfigVersionSlider", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AE3 RID: 15075 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06003AE4 RID: 15076 RVA: 0x00129629 File Offset: 0x00127829
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003AE6 RID: 15078 RVA: 0x00129458 File Offset: 0x00127658
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AE7 RID: 15079 RVA: 0x0012966B File Offset: 0x0012786B
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("Warning: Unhandled event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AE8 RID: 15080 RVA: 0x00129690 File Offset: 0x00127890
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AE9 RID: 15081 RVA: 0x00129458 File Offset: 0x00127658
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AEA RID: 15082 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06003AEB RID: 15083 RVA: 0x0012974D File Offset: 0x0012794D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Dot_Circle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AEC RID: 15084 RVA: 0x00129774 File Offset: 0x00127974
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 860f)
			{
				this.HBJJOCHGOPH = 220f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1816f, 74f));
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AED RID: 15085 RVA: 0x00129834 File Offset: 0x00127A34
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 268f)
			{
				this.HBJJOCHGOPH = 240f;
			}
			this.NBPKMLMCHFN.SetFloat("ticket", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("PossibleMapPointsText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 121f, 1639f));
			this.NBPKMLMCHFN.SetFloat("#alreadyexist", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x001298F4 File Offset: 0x00127AF4
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1226f)
			{
				this.HBJJOCHGOPH = 1273f;
			}
			this.NBPKMLMCHFN.SetFloat("x", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("Clears the console and prints the logs in the specified range", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 581f, 770f));
			this.NBPKMLMCHFN.SetFloat("USE_CORNER_DETECTION", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AEF RID: 15087 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x04000673 RID: 1651
	public Shader SCShader;

	// Token: 0x04000674 RID: 1652
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000675 RID: 1653
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000676 RID: 1654
	private Material BJFKDHHMLJH;

	// Token: 0x04000677 RID: 1655
	[Range(4f, 32f)]
	public float Value = 7f;
}
