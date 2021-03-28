using System;
using UnityEngine;

// Token: 0x02000102 RID: 258
[AddComponentMenu("Camera Filter Pack/Pixelisation/Deep OilPaint HQ")]
[ExecuteInEditMode]
public class CameraFilterPack_Pixelisation_DeepOilPaintHQ : MonoBehaviour
{
	// Token: 0x060050EF RID: 20719 RVA: 0x0019345C File Offset: 0x0019165C
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050F0 RID: 20720 RVA: 0x00193479 File Offset: 0x00191679
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050F1 RID: 20721 RVA: 0x001934B0 File Offset: 0x001916B0
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 735f)
			{
				this.HBJJOCHGOPH = 1332f;
			}
			this.NBPKMLMCHFN.SetFloat("HightScoreMaxPointsText", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1283f)
				{
					this._Distance = 443f;
				}
				if (this._Distance < 993f)
				{
					this._Distance = 1797f;
				}
				this.KGOLDDBHIFN().SetFloat("speed", this._Distance);
			}
			else
			{
				this.DEFBJOCJJKF().SetFloat("WARNING: rotation axis set to 0 on ", this._Distance);
			}
			this.DEFBJOCJJKF().SetFloat("float,1", this._Size);
			this.KGOLDDBHIFN().SetFloat("maps.", this._FixDistance);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/AAA_WaterDrop", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KGOLDDBHIFN().SetFloat("NOISE", 1489f / farClipPlane);
			this.KGOLDDBHIFN().SetVector("settings.selectormapsperpage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1062f, 1300f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050F2 RID: 20722 RVA: 0x00193676 File Offset: 0x00191876
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060050F3 RID: 20723 RVA: 0x001936AD File Offset: 0x001918AD
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Deep_OilPaintHQ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050F4 RID: 20724 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060050F5 RID: 20725 RVA: 0x0019345C File Offset: 0x0019165C
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050F6 RID: 20726 RVA: 0x001936D1 File Offset: 0x001918D1
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(" not found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060050F7 RID: 20727 RVA: 0x001936F8 File Offset: 0x001918F8
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
				{
					this._Distance = 1f;
				}
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060050F9 RID: 20729 RVA: 0x0019345C File Offset: 0x0019165C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060050FA RID: 20730 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060050FB RID: 20731 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060050FC RID: 20732 RVA: 0x00193915 File Offset: 0x00191B15
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("_NeighborMaxTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060050FD RID: 20733 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060050FE RID: 20734 RVA: 0x00193939 File Offset: 0x00191B39
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

	// Token: 0x0400086D RID: 2157
	public Shader SCShader;

	// Token: 0x0400086E RID: 2158
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400086F RID: 2159
	public bool _Visualize;

	// Token: 0x04000870 RID: 2160
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000871 RID: 2161
	private Material BJFKDHHMLJH;

	// Token: 0x04000872 RID: 2162
	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	// Token: 0x04000873 RID: 2163
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	// Token: 0x04000874 RID: 2164
	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	// Token: 0x04000875 RID: 2165
	[Range(0f, 8f)]
	public float Intensity = 1f;

	// Token: 0x04000876 RID: 2166
	public bool AutoAnimatedNear;

	// Token: 0x04000877 RID: 2167
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x04000878 RID: 2168
	public static Color ChangeColorRGB;
}
