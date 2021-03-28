using System;
using UnityEngine;

// Token: 0x0200009F RID: 159
[AddComponentMenu("Camera Filter Pack/Drawing/Laplacian")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Laplacian : MonoBehaviour
{
	// Token: 0x06002FFB RID: 12283 RVA: 0x000FF661 File Offset: 0x000FD861
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FFC RID: 12284 RVA: 0x000FF685 File Offset: 0x000FD885
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FFD RID: 12285 RVA: 0x000FF6A2 File Offset: 0x000FD8A2
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FFE RID: 12286 RVA: 0x000FF6D9 File Offset: 0x000FD8D9
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find(".progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002FFF RID: 12287 RVA: 0x000FF685 File Offset: 0x000FD885
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003000 RID: 12288 RVA: 0x000C4072 File Offset: 0x000C2272
	private void LLJLDLLNFBH()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06003001 RID: 12289 RVA: 0x000FF700 File Offset: 0x000FD900
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1964f)
			{
				this.HBJJOCHGOPH = 1613f;
			}
			this.KAFBNOBOIAJ().SetFloat("Joystick1Button1", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetVector("Events Moved", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1168f, 1117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003003 RID: 12291 RVA: 0x000FF7BA File Offset: 0x000FD9BA
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003004 RID: 12292 RVA: 0x000FF7E0 File Offset: 0x000FD9E0
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 295f)
			{
				this.HBJJOCHGOPH = 939f;
			}
			this.KAFBNOBOIAJ().SetFloat("_AdditiveReflection", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetVector("_Value7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1186f, 1338f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003005 RID: 12293 RVA: 0x000FF685 File Offset: 0x000FD885
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003006 RID: 12294 RVA: 0x000FF887 File Offset: 0x000FDA87
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Laplacian");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003007 RID: 12295 RVA: 0x000C4072 File Offset: 0x000C2272
	private void Update()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06003008 RID: 12296 RVA: 0x000FF8AB File Offset: 0x000FDAAB
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003009 RID: 12297 RVA: 0x000FF8E4 File Offset: 0x000FDAE4
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
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600300A RID: 12298 RVA: 0x000FF98C File Offset: 0x000FDB8C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1363f)
			{
				this.HBJJOCHGOPH = 719f;
			}
			this.JIBOKBCPDLC().SetFloat("/", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetVector("Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 964f, 758f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600300B RID: 12299 RVA: 0x000FFA33 File Offset: 0x000FDC33
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600300C RID: 12300 RVA: 0x000FFA6A File Offset: 0x000FDC6A
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600300D RID: 12301 RVA: 0x000FFAA1 File Offset: 0x000FDCA1
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

	// Token: 0x0600300E RID: 12302 RVA: 0x000FFAD8 File Offset: 0x000FDCD8
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600300F RID: 12303 RVA: 0x000FFB10 File Offset: 0x000FDD10
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 818f)
			{
				this.HBJJOCHGOPH = 1408f;
			}
			this.JIBOKBCPDLC().SetFloat("_FullResolutionFiltering", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetVector("StartButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1803f, 1433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003010 RID: 12304 RVA: 0x000C4072 File Offset: 0x000C2272
	private void MFMIODIAKNI()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06003011 RID: 12305 RVA: 0x000FFBB8 File Offset: 0x000FDDB8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1186f)
			{
				this.HBJJOCHGOPH = 879f;
			}
			this.JIBOKBCPDLC().SetFloat("_Color2", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetVector("USE_UV_BASED_REPROJECTION", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 594f, 1377f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400057C RID: 1404
	public Shader SCShader;

	// Token: 0x0400057D RID: 1405
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400057E RID: 1406
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400057F RID: 1407
	private Material BJFKDHHMLJH;
}
