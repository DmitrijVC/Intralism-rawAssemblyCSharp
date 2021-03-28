using System;
using UnityEngine;

// Token: 0x02000107 RID: 263
[AddComponentMenu("Camera Filter Pack/Weather/New Rain FX")]
[ExecuteInEditMode]
public class CameraFilterPack_Rain_RainFX : MonoBehaviour
{
	// Token: 0x06005221 RID: 21025 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06005222 RID: 21026 RVA: 0x001986AC File Offset: 0x001968AC
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 940f)
			{
				this.HBJJOCHGOPH = 945f;
			}
			this.ACHNOHCLGOO().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("0.00", this.Fade);
			this.ACHNOHCLGOO().SetFloat("Lag ", this.Speed);
			this.NBPKMLMCHFN.SetVector("Sending RPC \"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 670f, 372f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			AnimationCurve animationCurve = new AnimationCurve();
			animationCurve = new AnimationCurve();
			animationCurve.AddKey(1254f, 1678f);
			animationCurve.AddKey(783f, 108f);
			animationCurve.AddKey(823f, 666f);
			animationCurve.AddKey(486f, 1995f);
			animationCurve.AddKey(873f, 814f);
			for (int i = 0; i < 4; i++)
			{
				Vector4[] bapbimnehjn = this.BAPBIMNEHJN;
				int num = i;
				bapbimnehjn[num].z = bapbimnehjn[num].z + 1112f;
				if (this.BAPBIMNEHJN[i].w == 1907f)
				{
					this.BAPBIMNEHJN[i].x = 828f;
				}
				if (this.BAPBIMNEHJN[i].z > 713f)
				{
					this.BAPBIMNEHJN[i] = new Vector4(UnityEngine.Random.Range(1589f, 430f), UnityEngine.Random.Range(746f, 1463f), 1365f, (float)UnityEngine.Random.Range(0, 2));
				}
				this.NBPKMLMCHFN.SetVector("_Blue_R" + (i + 0).ToString(), new Vector4(this.BAPBIMNEHJN[i].x, this.BAPBIMNEHJN[i].y, (float)((int)animationCurve.Evaluate(this.BAPBIMNEHJN[i].z)), this.BAPBIMNEHJN[i].w));
			}
			this.NBPKMLMCHFN.SetTexture("id", this.FPHEBLMINDA);
			this.ACHNOHCLGOO().SetTexture("CreateRoom failed. In offline mode you still have to leave a room to enter another.", this.LKKHMFFDPJG);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005223 RID: 21027 RVA: 0x0019894C File Offset: 0x00196B4C
	private void DNNFHBOOPIN()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.LKKHMFFDPJG = (Resources.Load("_Vignetting2") as Texture2D);
		this.SCShader = Shader.Find("menu.playedpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005224 RID: 21028 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005225 RID: 21029 RVA: 0x001989A5 File Offset: 0x00196BA5
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005226 RID: 21030 RVA: 0x001989C2 File Offset: 0x00196BC2
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005227 RID: 21031 RVA: 0x001989FC File Offset: 0x00196BFC
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("workshop.") as Texture2D);
		this.LKKHMFFDPJG = (Resources.Load("/music") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005228 RID: 21032 RVA: 0x00198A58 File Offset: 0x00196C58
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_RainFX_Anm2") as Texture2D);
		this.LKKHMFFDPJG = (Resources.Load("CameraFilterPack_RainFX_Anm") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/RainFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600522A RID: 21034 RVA: 0x001989A5 File Offset: 0x00196BA5
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600522B RID: 21035 RVA: 0x00198AE8 File Offset: 0x00196CE8
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("health") as Texture2D);
		this.LKKHMFFDPJG = (Resources.Load("_InvViewProj") as Texture2D);
		this.SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600522C RID: 21036 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x0600522D RID: 21037 RVA: 0x00198B41 File Offset: 0x00196D41
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

	// Token: 0x0600522E RID: 21038 RVA: 0x00198B78 File Offset: 0x00196D78
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			AnimationCurve animationCurve = new AnimationCurve();
			animationCurve = new AnimationCurve();
			animationCurve.AddKey(0f, 0.01f);
			animationCurve.AddKey(64f, 5f);
			animationCurve.AddKey(128f, 80f);
			animationCurve.AddKey(255f, 255f);
			animationCurve.AddKey(300f, 255f);
			for (int i = 0; i < 4; i++)
			{
				Vector4[] bapbimnehjn = this.BAPBIMNEHJN;
				int num = i;
				bapbimnehjn[num].z = bapbimnehjn[num].z + 0.5f;
				if (this.BAPBIMNEHJN[i].w == -1f)
				{
					this.BAPBIMNEHJN[i].x = -5f;
				}
				if (this.BAPBIMNEHJN[i].z > 254f)
				{
					this.BAPBIMNEHJN[i] = new Vector4(UnityEngine.Random.Range(0f, 0.9f), UnityEngine.Random.Range(0.2f, 1.1f), 0f, (float)UnityEngine.Random.Range(0, 3));
				}
				this.NBPKMLMCHFN.SetVector("Coord" + (i + 1).ToString(), new Vector4(this.BAPBIMNEHJN[i].x, this.BAPBIMNEHJN[i].y, (float)((int)animationCurve.Evaluate(this.BAPBIMNEHJN[i].z)), this.BAPBIMNEHJN[i].w));
			}
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			this.NBPKMLMCHFN.SetTexture("Texture3", this.LKKHMFFDPJG);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600522F RID: 21039 RVA: 0x00198E18 File Offset: 0x00197018
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.LKKHMFFDPJG = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005230 RID: 21040 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x04000893 RID: 2195
	public Shader SCShader;

	// Token: 0x04000894 RID: 2196
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000895 RID: 2197
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000896 RID: 2198
	private Material BJFKDHHMLJH;

	// Token: 0x04000897 RID: 2199
	[Range(-8f, 8f)]
	public float Speed = 1f;

	// Token: 0x04000898 RID: 2200
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000899 RID: 2201
	[HideInInspector]
	public int Count;

	// Token: 0x0400089A RID: 2202
	private Vector4[] BAPBIMNEHJN = new Vector4[4];

	// Token: 0x0400089B RID: 2203
	public static Color ChangeColorRGB;

	// Token: 0x0400089C RID: 2204
	private Texture2D FPHEBLMINDA;

	// Token: 0x0400089D RID: 2205
	private Texture2D LKKHMFFDPJG;
}
