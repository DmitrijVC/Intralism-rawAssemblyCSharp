using System;
using UnityEngine;

// Token: 0x020000CB RID: 203
[AddComponentMenu("Camera Filter Pack/FX/Grid")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Grid : MonoBehaviour
{
	// Token: 0x06003DAB RID: 15787 RVA: 0x0013469C File Offset: 0x0013289C
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DAC RID: 15788 RVA: 0x001346BC File Offset: 0x001328BC
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DAD RID: 15789 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06003DAE RID: 15790 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06003DAF RID: 15791 RVA: 0x0013474C File Offset: 0x0013294C
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DB0 RID: 15792 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003DB1 RID: 15793 RVA: 0x00134784 File Offset: 0x00132984
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 725f)
			{
				this.HBJJOCHGOPH = 1181f;
			}
			this.NBPKMLMCHFN.SetFloat("blue", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("SetParticlesParticleSize", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DB2 RID: 15794 RVA: 0x0013469C File Offset: 0x0013289C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DB3 RID: 15795 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06003DB4 RID: 15796 RVA: 0x0013469C File Offset: 0x0013289C
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DB5 RID: 15797 RVA: 0x00134814 File Offset: 0x00132A14
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DB6 RID: 15798 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06003DB7 RID: 15799 RVA: 0x0013469C File Offset: 0x0013289C
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x0013484B File Offset: 0x00132A4B
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

	// Token: 0x06003DB9 RID: 15801 RVA: 0x00134884 File Offset: 0x00132A84
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1829f)
			{
				this.HBJJOCHGOPH = 511f;
			}
			this.NBPKMLMCHFN.SetFloat("MenuScene", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Error: Timeout :S", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DBB RID: 15803 RVA: 0x00134932 File Offset: 0x00132B32
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DBC RID: 15804 RVA: 0x00134969 File Offset: 0x00132B69
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Grid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DBD RID: 15805 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06003DBE RID: 15806 RVA: 0x00134990 File Offset: 0x00132B90
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1689f)
			{
				this.HBJJOCHGOPH = 1719f;
			}
			this.HHIFMIPPMPF().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("JoystickButton13", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040006AB RID: 1707
	public Shader SCShader;

	// Token: 0x040006AC RID: 1708
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006AD RID: 1709
	private Material BJFKDHHMLJH;

	// Token: 0x040006AE RID: 1710
	[Range(0f, 5f)]
	public float Distortion = 1f;

	// Token: 0x040006AF RID: 1711
	public static float ChangeDistortion;
}
