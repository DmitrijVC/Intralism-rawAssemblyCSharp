using System;
using UnityEngine;

// Token: 0x02000105 RID: 261
[AddComponentMenu("Camera Filter Pack/Pixelisation/OilPaintHQ")]
[ExecuteInEditMode]
public class CameraFilterPack_Pixelisation_OilPaintHQ : MonoBehaviour
{
	// Token: 0x060051B7 RID: 20919 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060051B8 RID: 20920 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060051B9 RID: 20921 RVA: 0x00196B71 File Offset: 0x00194D71
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

	// Token: 0x060051BA RID: 20922 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060051BC RID: 20924 RVA: 0x00196BC6 File Offset: 0x00194DC6
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051BD RID: 20925 RVA: 0x00196BFD File Offset: 0x00194DFD
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051BE RID: 20926 RVA: 0x00196C34 File Offset: 0x00194E34
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 772f)
			{
				this.HBJJOCHGOPH = 822f;
			}
			this.KAFBNOBOIAJ().SetFloat("SetSatelliteSensitivity", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1070f, 841f));
			this.KAFBNOBOIAJ().SetFloat("#random #rare #item", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051BF RID: 20927 RVA: 0x00196CF1 File Offset: 0x00194EF1
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051C0 RID: 20928 RVA: 0x00196D0E File Offset: 0x00194F0E
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051C1 RID: 20929 RVA: 0x00196D32 File Offset: 0x00194F32
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Pixelisation_OilPaintHQ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051C2 RID: 20930 RVA: 0x00196D56 File Offset: 0x00194F56
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("SetEnvSpriteColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051C3 RID: 20931 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060051C4 RID: 20932 RVA: 0x00196CF1 File Offset: 0x00194EF1
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051C5 RID: 20933 RVA: 0x00196D7C File Offset: 0x00194F7C
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 61f)
			{
				this.HBJJOCHGOPH = 686f;
			}
			this.KAFBNOBOIAJ().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetVector("menutheme.deleted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1910f, 629f));
			this.DNLMFEGJJDD().SetFloat("id", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051C6 RID: 20934 RVA: 0x00196CF1 File Offset: 0x00194EF1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051C7 RID: 20935 RVA: 0x00196E3C File Offset: 0x0019503C
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1143f)
			{
				this.HBJJOCHGOPH = 1572f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/EXTRA_Rotation", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetVector("Mouse", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 462f, 1287f));
			this.NBPKMLMCHFN.SetFloat("icon.png", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051C8 RID: 20936 RVA: 0x00196EFC File Offset: 0x001950FC
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 368f)
			{
				this.HBJJOCHGOPH = 442f;
			}
			this.KAFBNOBOIAJ().SetFloat("/", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 406f, 68f));
			this.DNLMFEGJJDD().SetFloat("_DistortionSize", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051C9 RID: 20937 RVA: 0x00196FB9 File Offset: 0x001951B9
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_HdrParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051CA RID: 20938 RVA: 0x00196FE0 File Offset: 0x001951E0
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

	// Token: 0x060051CB RID: 20939 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x04000886 RID: 2182
	public Shader SCShader;

	// Token: 0x04000887 RID: 2183
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000888 RID: 2184
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000889 RID: 2185
	private Material BJFKDHHMLJH;

	// Token: 0x0400088A RID: 2186
	[Range(0f, 5f)]
	public float Value = 2f;
}
