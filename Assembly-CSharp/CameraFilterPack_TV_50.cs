using System;
using UnityEngine;

// Token: 0x0200010C RID: 268
[AddComponentMenu("Camera Filter Pack/TV/50s")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_50 : MonoBehaviour
{
	// Token: 0x0600539E RID: 21406 RVA: 0x0019FAFE File Offset: 0x0019DCFE
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600539F RID: 21407 RVA: 0x0019FB1B File Offset: 0x0019DD1B
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Subtract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060053A0 RID: 21408 RVA: 0x0019FAFE File Offset: 0x0019DCFE
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053A1 RID: 21409 RVA: 0x0019FB40 File Offset: 0x0019DD40
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 290f)
			{
				this.HBJJOCHGOPH = 1367f;
			}
			this.DNLMFEGJJDD().SetFloat("_LightIntensity", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("SpawnObj", this.Fade);
			this.DNLMFEGJJDD().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1669f, 1577f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053A2 RID: 21410 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060053A3 RID: 21411 RVA: 0x0019FBFD File Offset: 0x0019DDFD
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060053A4 RID: 21412 RVA: 0x0019FC24 File Offset: 0x0019DE24
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1879f)
			{
				this.HBJJOCHGOPH = 337f;
			}
			this.NBPKMLMCHFN.SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("OK", this.Fade);
			this.DNLMFEGJJDD().SetVector("LB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1216f, 1584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053A5 RID: 21413 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x060053A6 RID: 21414 RVA: 0x0019FCE1 File Offset: 0x0019DEE1
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

	// Token: 0x060053A7 RID: 21415 RVA: 0x0019FD18 File Offset: 0x0019DF18
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060053A8 RID: 21416 RVA: 0x0019FD4F File Offset: 0x0019DF4F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_50");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060053AA RID: 21418 RVA: 0x0019FAFE File Offset: 0x0019DCFE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060053AB RID: 21419 RVA: 0x0019FD94 File Offset: 0x0019DF94
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1689f)
			{
				this.HBJJOCHGOPH = 1416f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("[PlayerController] ", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ColorBuffer", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1537f, 1492f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053AC RID: 21420 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060053AD RID: 21421 RVA: 0x0019FE54 File Offset: 0x0019E054
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060053AE RID: 21422 RVA: 0x0019FF11 File Offset: 0x0019E111
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("\n\n#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040008BB RID: 2235
	public Shader SCShader;

	// Token: 0x040008BC RID: 2236
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008BD RID: 2237
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008BE RID: 2238
	private Material BJFKDHHMLJH;

	// Token: 0x040008BF RID: 2239
	[Range(0f, 1f)]
	public float Fade = 1f;
}
