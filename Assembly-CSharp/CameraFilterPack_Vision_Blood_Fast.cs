using System;
using UnityEngine;

// Token: 0x02000132 RID: 306
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Blood_Fast")]
public class CameraFilterPack_Vision_Blood_Fast : MonoBehaviour
{
	// Token: 0x06006118 RID: 24856 RVA: 0x001D8736 File Offset: 0x001D6936
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006119 RID: 24857 RVA: 0x001D8736 File Offset: 0x001D6936
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600611A RID: 24858 RVA: 0x001D8754 File Offset: 0x001D6954
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1713f)
			{
				this.HBJJOCHGOPH = 727f;
			}
			this.NBPKMLMCHFN.SetFloat(" x ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_Value3", this.HoleSize);
			this.KGOLDDBHIFN().SetFloat("Joystick1Button11", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("_BlurFilterDistance", this.Color1);
			this.KGOLDDBHIFN().SetFloat("UseScanLineSize", this.Color2);
			this.KGOLDDBHIFN().SetVector("OnPress", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 252f, 278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600611B RID: 24859 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x0600611C RID: 24860 RVA: 0x001D8853 File Offset: 0x001D6A53
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Toon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x0600611D RID: 24861 RVA: 0x001D8877 File Offset: 0x001D6A77
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

	// Token: 0x0600611E RID: 24862 RVA: 0x001D88AE File Offset: 0x001D6AAE
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600611F RID: 24863 RVA: 0x001D88D4 File Offset: 0x001D6AD4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 275f)
			{
				this.HBJJOCHGOPH = 548f;
			}
			this.KGOLDDBHIFN().SetFloat("PUNCloudBestRegion", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("menutheme.27thfloor", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("maps.", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Color1);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Color2);
			this.KGOLDDBHIFN().SetVector("SetTrailZoomSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1563f, 829f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006120 RID: 24864 RVA: 0x001D89D3 File Offset: 0x001D6BD3
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006122 RID: 24866 RVA: 0x001D8736 File Offset: 0x001D6936
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006123 RID: 24867 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06006124 RID: 24868 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006125 RID: 24869 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06006126 RID: 24870 RVA: 0x001D8A4C File Offset: 0x001D6C4C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Color1);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Color2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006127 RID: 24871 RVA: 0x001D8B4C File Offset: 0x001D6D4C
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1669f)
			{
				this.HBJJOCHGOPH = 925f;
			}
			this.KGOLDDBHIFN().SetFloat("[EditorEvent] Exception: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("z", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("Set particles audio input", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("#ok", this.Color1);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Color2);
			this.NBPKMLMCHFN.SetVector("EventData0DropDownList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 300f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006128 RID: 24872 RVA: 0x001D8736 File Offset: 0x001D6936
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006129 RID: 24873 RVA: 0x001D8C4B File Offset: 0x001D6E4B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Blood_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040009BD RID: 2493
	public Shader SCShader;

	// Token: 0x040009BE RID: 2494
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009BF RID: 2495
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009C0 RID: 2496
	private Material BJFKDHHMLJH;

	// Token: 0x040009C1 RID: 2497
	[Range(0.01f, 1f)]
	public float HoleSize = 0.6f;

	// Token: 0x040009C2 RID: 2498
	[Range(-1f, 1f)]
	public float HoleSmooth = 0.3f;

	// Token: 0x040009C3 RID: 2499
	[Range(-2f, 2f)]
	public float Color1 = 0.2f;

	// Token: 0x040009C4 RID: 2500
	[Range(-2f, 2f)]
	public float Color2 = 0.9f;
}
