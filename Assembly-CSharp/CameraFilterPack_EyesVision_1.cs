using System;
using UnityEngine;

// Token: 0x020000B8 RID: 184
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Eyes 1")]
public class CameraFilterPack_EyesVision_1 : MonoBehaviour
{
	// Token: 0x06003826 RID: 14374 RVA: 0x0011DD63 File Offset: 0x0011BF63
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003827 RID: 14375 RVA: 0x0011DD9A File Offset: 0x0011BF9A
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003828 RID: 14376 RVA: 0x0011DDB7 File Offset: 0x0011BFB7
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("Object ID. Case-Sensitive") as Texture2D);
		this.SCShader = Shader.Find("file://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003829 RID: 14377 RVA: 0x0011DDF0 File Offset: 0x0011BFF0
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.crosshairopacity") as Texture2D);
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600382B RID: 14379 RVA: 0x0011DE68 File Offset: 0x0011C068
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("Please specify a map name or buildID") as Texture2D);
		this.SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600382C RID: 14380 RVA: 0x0011DEA1 File Offset: 0x0011C0A1
	private void DNNFHBOOPIN()
	{
		this.FPHEBLMINDA = (Resources.Load("AudioSampler") as Texture2D);
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600382D RID: 14381 RVA: 0x0011DEDA File Offset: 0x0011C0DA
	private void BEBNOKFLJPH()
	{
		this.FPHEBLMINDA = (Resources.Load("SpawnObj") as Texture2D);
		this.SCShader = Shader.Find("checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600382E RID: 14382 RVA: 0x0011DD9A File Offset: 0x0011BF9A
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600382F RID: 14383 RVA: 0x0011DF13 File Offset: 0x0011C113
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003830 RID: 14384 RVA: 0x0011DD9A File Offset: 0x0011BF9A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003831 RID: 14385 RVA: 0x0011DF4A File Offset: 0x0011C14A
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_eyes_vision_1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/EyesVision_1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06003832 RID: 14386 RVA: 0x0011DF83 File Offset: 0x0011C183
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

	// Token: 0x06003833 RID: 14387 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003834 RID: 14388 RVA: 0x0011DFBC File Offset: 0x0011C1BC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this._EyeWave);
			this.NBPKMLMCHFN.SetFloat("_Value2", this._EyeSpeed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this._EyeMove);
			this.NBPKMLMCHFN.SetFloat("_Value4", this._EyeBlink);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003835 RID: 14389 RVA: 0x0011DD9A File Offset: 0x0011BF9A
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000623 RID: 1571
	public Shader SCShader;

	// Token: 0x04000624 RID: 1572
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000625 RID: 1573
	[Range(1f, 32f)]
	public float _EyeWave = 15f;

	// Token: 0x04000626 RID: 1574
	[Range(0f, 10f)]
	public float _EyeSpeed = 1f;

	// Token: 0x04000627 RID: 1575
	[Range(0f, 8f)]
	public float _EyeMove = 2f;

	// Token: 0x04000628 RID: 1576
	[Range(0f, 1f)]
	public float _EyeBlink = 1f;

	// Token: 0x04000629 RID: 1577
	private Material BJFKDHHMLJH;

	// Token: 0x0400062A RID: 1578
	private Texture2D FPHEBLMINDA;
}
