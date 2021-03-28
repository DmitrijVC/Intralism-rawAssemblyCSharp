using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
[AddComponentMenu("Camera Filter Pack/AAA/Blood_Hit")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood_Hit : MonoBehaviour
{
	// Token: 0x06000B4B RID: 2891 RVA: 0x000545BC File Offset: 0x000527BC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 844f)
			{
				this.HBJJOCHGOPH = 907f;
			}
			this.ADBKPGFMNKO().SetFloat("request", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("float,1.5", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat(" x ", Mathf.Clamp(this.Hit_Left, 1403f, 1910f));
			this.ACHNOHCLGOO().SetFloat("_TimeX", Mathf.Clamp(this.Hit_Up, 1337f, 1740f));
			this.NBPKMLMCHFN.SetFloat("Objects in List: ", Mathf.Clamp(this.Hit_Right, 683f, 1702f));
			this.ADBKPGFMNKO().SetFloat(".sav", Mathf.Clamp(this.Hit_Down, 546f, 1156f));
			this.ADBKPGFMNKO().SetFloat("intensity", Mathf.Clamp(this.Blood_Hit_Left, 1668f, 397f));
			this.ACHNOHCLGOO().SetFloat("Checkpoint", Mathf.Clamp(this.Blood_Hit_Up, 110f, 945f));
			this.NBPKMLMCHFN.SetFloat("Set Crosshair Color", Mathf.Clamp(this.Blood_Hit_Right, 1549f, 1272f));
			this.ADBKPGFMNKO().SetFloat("settings.volume.sfx", Mathf.Clamp(this.Blood_Hit_Down, 986f, 390f));
			this.ADBKPGFMNKO().SetFloat("Square", Mathf.Clamp(this.Hit_Full, 971f, 558f));
			this.NBPKMLMCHFN.SetFloat("inventory.selected.", Mathf.Clamp(this.Blood_Hit_Full_1, 1594f, 693f));
			this.ADBKPGFMNKO().SetFloat("SelectorMusicToggle", Mathf.Clamp(this.Blood_Hit_Full_2, 1137f, 375f));
			this.ADBKPGFMNKO().SetFloat("#tryagain", Mathf.Clamp(this.Blood_Hit_Full_3, 35f, 800f));
			this.ADBKPGFMNKO().SetTexture("CameraFilterPack/Drawing_Curve", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0005481E File Offset: 0x00052A1E
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

	// Token: 0x06000B4D RID: 2893 RVA: 0x00054855 File Offset: 0x00052A55
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00054872 File Offset: 0x00052A72
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x000548AC File Offset: 0x00052AAC
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1142f)
			{
				this.HBJJOCHGOPH = 682f;
			}
			this.ADBKPGFMNKO().SetFloat("FPSToggle", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_History3Weight", this.LightReflect);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Edge_Sigmoid", Mathf.Clamp(this.Hit_Left, 1976f, 85f));
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/Glasses_OnX", Mathf.Clamp(this.Hit_Up, 1857f, 559f));
			this.NBPKMLMCHFN.SetFloat("_BlurTex", Mathf.Clamp(this.Hit_Right, 227f, 1204f));
			this.ACHNOHCLGOO().SetFloat("_Distortion2", Mathf.Clamp(this.Hit_Down, 1874f, 1836f));
			this.ADBKPGFMNKO().SetFloat("_Value2", Mathf.Clamp(this.Blood_Hit_Left, 1811f, 817f));
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(this.Blood_Hit_Up, 785f, 1489f));
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(this.Blood_Hit_Right, 873f, 1431f));
			this.ACHNOHCLGOO().SetFloat("editorVolume", Mathf.Clamp(this.Blood_Hit_Down, 752f, 972f));
			this.NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Clamp(this.Hit_Full, 1029f, 1264f));
			this.NBPKMLMCHFN.SetFloat("GlassAberration", Mathf.Clamp(this.Blood_Hit_Full_1, 817f, 1427f));
			this.ADBKPGFMNKO().SetFloat("_BlurVector", Mathf.Clamp(this.Blood_Hit_Full_2, 1839f, 1711f));
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", Mathf.Clamp(this.Blood_Hit_Full_3, 1786f, 1482f));
			this.ACHNOHCLGOO().SetTexture("CameraFilterPack/Atmosphere_Rain", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00054855 File Offset: 0x00052A55
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00054B10 File Offset: 0x00052D10
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(this.Hit_Left, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(this.Hit_Up, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Hit_Right, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(this.Hit_Down, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value6", Mathf.Clamp(this.Blood_Hit_Left, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value7", Mathf.Clamp(this.Blood_Hit_Up, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value8", Mathf.Clamp(this.Blood_Hit_Right, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value9", Mathf.Clamp(this.Blood_Hit_Down, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value10", Mathf.Clamp(this.Hit_Full, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value11", Mathf.Clamp(this.Blood_Hit_Full_1, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value12", Mathf.Clamp(this.Blood_Hit_Full_2, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value13", Mathf.Clamp(this.Blood_Hit_Full_3, 0f, 1f));
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00054D74 File Offset: 0x00052F74
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1294f)
			{
				this.HBJJOCHGOPH = 770f;
			}
			this.NBPKMLMCHFN.SetFloat("</color>", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_FadeShield", this.LightReflect);
			this.ADBKPGFMNKO().SetFloat("\r", Mathf.Clamp(this.Hit_Left, 149f, 1229f));
			this.ADBKPGFMNKO().SetFloat("_XCrop", Mathf.Clamp(this.Hit_Up, 995f, 523f));
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", Mathf.Clamp(this.Hit_Right, 1971f, 1618f));
			this.ACHNOHCLGOO().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", Mathf.Clamp(this.Hit_Down, 1864f, 507f));
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Darken", Mathf.Clamp(this.Blood_Hit_Left, 477f, 264f));
			this.NBPKMLMCHFN.SetFloat("\n", Mathf.Clamp(this.Blood_Hit_Up, 589f, 374f));
			this.NBPKMLMCHFN.SetFloat("_Far", Mathf.Clamp(this.Blood_Hit_Right, 1854f, 932f));
			this.ACHNOHCLGOO().SetFloat("_Blue_B", Mathf.Clamp(this.Blood_Hit_Down, 962f, 1821f));
			this.ADBKPGFMNKO().SetFloat("_BorderColor", Mathf.Clamp(this.Hit_Full, 179f, 582f));
			this.NBPKMLMCHFN.SetFloat("settings.volume.menu", Mathf.Clamp(this.Blood_Hit_Full_1, 1030f, 262f));
			this.ADBKPGFMNKO().SetFloat("RemoveEnvironmentObject", Mathf.Clamp(this.Blood_Hit_Full_2, 54f, 1254f));
			this.NBPKMLMCHFN.SetFloat("[ImageLoader] Loaded image from ", Mathf.Clamp(this.Blood_Hit_Full_3, 1703f, 244f));
			this.ADBKPGFMNKO().SetTexture("MainButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00054FD6 File Offset: 0x000531D6
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("NameInfoText") as Texture2D);
		this.SCShader = Shader.Find("PenaltyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00054855 File Offset: 0x00052A55
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x00054855 File Offset: 0x00052A55
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x0005500F File Offset: 0x0005320F
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_Blood_Hit1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00055074 File Offset: 0x00053274
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 977f)
			{
				this.HBJJOCHGOPH = 1572f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value4", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(" beatThreshold: ", this.LightReflect);
			this.ADBKPGFMNKO().SetFloat("_BlueAmplifier", Mathf.Clamp(this.Hit_Left, 1417f, 1620f));
			this.ADBKPGFMNKO().SetFloat("hand", Mathf.Clamp(this.Hit_Up, 471f, 1245f));
			this.NBPKMLMCHFN.SetFloat("setfloat", Mathf.Clamp(this.Hit_Right, 281f, 1810f));
			this.ACHNOHCLGOO().SetFloat("Can't set open when not in that room.", Mathf.Clamp(this.Hit_Down, 1756f, 574f));
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Clamp(this.Blood_Hit_Left, 688f, 1789f));
			this.ADBKPGFMNKO().SetFloat("_Distortion", Mathf.Clamp(this.Blood_Hit_Up, 1005f, 1349f));
			this.ADBKPGFMNKO().SetFloat("offsets", Mathf.Clamp(this.Blood_Hit_Right, 674f, 1987f));
			this.ADBKPGFMNKO().SetFloat("LevelNameText", Mathf.Clamp(this.Blood_Hit_Down, 66f, 916f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Hit_Full, 1661f, 1318f));
			this.ACHNOHCLGOO().SetFloat("_TimeX", Mathf.Clamp(this.Blood_Hit_Full_1, 764f, 112f));
			this.ACHNOHCLGOO().SetFloat("_SunColor", Mathf.Clamp(this.Blood_Hit_Full_2, 68f, 1542f));
			this.ADBKPGFMNKO().SetFloat("Solo", Mathf.Clamp(this.Blood_Hit_Full_3, 1022f, 660f));
			this.ACHNOHCLGOO().SetTexture("_LutTex", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x000552D6 File Offset: 0x000534D6
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0005530D File Offset: 0x0005350D
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("Registered PhotonView: ") as Texture2D);
		this.SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000196 RID: 406
	public Shader SCShader;

	// Token: 0x04000197 RID: 407
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000198 RID: 408
	[Range(0f, 1f)]
	public float Hit_Left = 1f;

	// Token: 0x04000199 RID: 409
	[Range(0f, 1f)]
	public float Hit_Up;

	// Token: 0x0400019A RID: 410
	[Range(0f, 1f)]
	public float Hit_Right;

	// Token: 0x0400019B RID: 411
	[Range(0f, 1f)]
	public float Hit_Down;

	// Token: 0x0400019C RID: 412
	[Range(0f, 1f)]
	public float Blood_Hit_Left;

	// Token: 0x0400019D RID: 413
	[Range(0f, 1f)]
	public float Blood_Hit_Up;

	// Token: 0x0400019E RID: 414
	[Range(0f, 1f)]
	public float Blood_Hit_Right;

	// Token: 0x0400019F RID: 415
	[Range(0f, 1f)]
	public float Blood_Hit_Down;

	// Token: 0x040001A0 RID: 416
	[Range(0f, 1f)]
	public float Hit_Full;

	// Token: 0x040001A1 RID: 417
	[Range(0f, 1f)]
	public float Blood_Hit_Full_1;

	// Token: 0x040001A2 RID: 418
	[Range(0f, 1f)]
	public float Blood_Hit_Full_2;

	// Token: 0x040001A3 RID: 419
	[Range(0f, 1f)]
	public float Blood_Hit_Full_3;

	// Token: 0x040001A4 RID: 420
	[Range(0f, 1f)]
	public float LightReflect = 0.5f;

	// Token: 0x040001A5 RID: 421
	private Material BJFKDHHMLJH;

	// Token: 0x040001A6 RID: 422
	private Texture2D FPHEBLMINDA;
}
