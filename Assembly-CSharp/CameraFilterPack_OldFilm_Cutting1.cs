using System;
using UnityEngine;

// Token: 0x020000FF RID: 255
[AddComponentMenu("Camera Filter Pack/Old Film/Cutting 1")]
[ExecuteInEditMode]
public class CameraFilterPack_OldFilm_Cutting1 : MonoBehaviour
{
	// Token: 0x06005000 RID: 20480 RVA: 0x0018FFC1 File Offset: 0x0018E1C1
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06005001 RID: 20481 RVA: 0x0018FFDE File Offset: 0x0018E1DE
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

	// Token: 0x06005002 RID: 20482 RVA: 0x00190015 File Offset: 0x0018E215
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("Beat Detected") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005003 RID: 20483 RVA: 0x0019004E File Offset: 0x0018E24E
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x00190087 File Offset: 0x0018E287
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005005 RID: 20485 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06005006 RID: 20486 RVA: 0x0018FFC1 File Offset: 0x0018E1C1
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005007 RID: 20487 RVA: 0x0018FFC1 File Offset: 0x0018E1C1
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06005009 RID: 20489 RVA: 0x001900BE File Offset: 0x0018E2BE
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x001900F5 File Offset: 0x0018E2F5
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x0019012C File Offset: 0x0018E32C
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600500C RID: 20492 RVA: 0x00190163 File Offset: 0x0018E363
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600500E RID: 20494 RVA: 0x001901D0 File Offset: 0x0018E3D0
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 547f)
			{
				this.HBJJOCHGOPH = 1098f;
			}
			this.LDNADDJMIPK().SetFloat("#close", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.Luminosity);
			this.HHIFMIPPMPF().SetFloat("[MapEditor] Updating map assets", 1393f - this.Vignette);
			this.PLBEJJIHFPB().SetFloat("ERROR You have missing MonoBehaviours on your gameobjects!", this.Negative);
			this.PLBEJJIHFPB().SetFloat("Emergency Help:", this.Speed);
			this.NFMGLIKNOOC().SetTexture("colorA", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600500F RID: 20495 RVA: 0x001902C0 File Offset: 0x0018E4C0
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 980f)
			{
				this.HBJJOCHGOPH = 56f;
			}
			this.PLBEJJIHFPB().SetFloat("stretchWidth", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_Value4", this.Luminosity);
			this.PLBEJJIHFPB().SetFloat("\n\n• ", 1109f - this.Vignette);
			this.HHIFMIPPMPF().SetFloat("[PlayerController] ", this.Negative);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_Value9", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005010 RID: 20496 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005011 RID: 20497 RVA: 0x0018FFC1 File Offset: 0x0018E1C1
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005012 RID: 20498 RVA: 0x001903AE File Offset: 0x0018E5AE
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005013 RID: 20499 RVA: 0x001903E8 File Offset: 0x0018E5E8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("_Value2", 1f - this.Vignette);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Negative);
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005014 RID: 20500 RVA: 0x001904D6 File Offset: 0x0018E6D6
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("\\");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005015 RID: 20501 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06005016 RID: 20502 RVA: 0x0018FFC1 File Offset: 0x0018E1C1
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005017 RID: 20503 RVA: 0x0019050F File Offset: 0x0018E70F
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("No Dispatcher exists in the scene. Actions will not be invoked!") as Texture2D);
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005018 RID: 20504 RVA: 0x00190548 File Offset: 0x0018E748
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005019 RID: 20505 RVA: 0x00190580 File Offset: 0x0018E780
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1468f)
			{
				this.HBJJOCHGOPH = 1751f;
			}
			this.PDEAHJPOMEF().SetFloat("FullscreenToggle", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("player.violetarc", this.Luminosity);
			this.HHIFMIPPMPF().SetFloat("GlassAberration", 1710f - this.Vignette);
			this.NBPKMLMCHFN.SetFloat("To {0} at Index {1} \n", this.Negative);
			this.LDNADDJMIPK().SetFloat("[MapsData] User's maps was loaded", this.Speed);
			this.PLBEJJIHFPB().SetTexture("_DistortionSize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600501A RID: 20506 RVA: 0x0018FFC1 File Offset: 0x0018E1C1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600501B RID: 20507 RVA: 0x0019066E File Offset: 0x0018E86E
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_OldFilm1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600501C RID: 20508 RVA: 0x001906A8 File Offset: 0x0018E8A8
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1372f)
			{
				this.HBJJOCHGOPH = 1014f;
			}
			this.NBPKMLMCHFN.SetFloat("{0}", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/FX_EarthQuake", this.Luminosity);
			this.HHIFMIPPMPF().SetFloat("_History2Weight", 592f - this.Vignette);
			this.DNLMFEGJJDD().SetFloat("rarity", this.Negative);
			this.HHIFMIPPMPF().SetFloat("SetSunInput", this.Speed);
			this.LDNADDJMIPK().SetTexture("_Near", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600501D RID: 20509 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600501E RID: 20510 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x0600501F RID: 20511 RVA: 0x0018FFC1 File Offset: 0x0018E1C1
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005020 RID: 20512 RVA: 0x00190796 File Offset: 0x0018E996
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000858 RID: 2136
	public Shader SCShader;

	// Token: 0x04000859 RID: 2137
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400085A RID: 2138
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x0400085B RID: 2139
	[Range(0f, 2f)]
	public float Luminosity = 1.5f;

	// Token: 0x0400085C RID: 2140
	[Range(0f, 1f)]
	public float Vignette = 1f;

	// Token: 0x0400085D RID: 2141
	[Range(0f, 2f)]
	public float Negative;

	// Token: 0x0400085E RID: 2142
	private Material BJFKDHHMLJH;

	// Token: 0x0400085F RID: 2143
	private Texture2D FPHEBLMINDA;
}
