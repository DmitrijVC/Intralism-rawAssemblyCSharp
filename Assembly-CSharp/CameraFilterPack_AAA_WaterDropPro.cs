using System;
using UnityEngine;

// Token: 0x02000031 RID: 49
[AddComponentMenu("Camera Filter Pack/AAA/WaterDropPro")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_WaterDropPro : MonoBehaviour
{
	// Token: 0x06000C83 RID: 3203 RVA: 0x0005BCB1 File Offset: 0x00059EB1
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0005BCCE File Offset: 0x00059ECE
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("EnvironmentSlider") as Texture2D);
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x0005BCB1 File Offset: 0x00059EB1
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x0005BD07 File Offset: 0x00059F07
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_WaterDrop") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_WaterDropPro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0005BD40 File Offset: 0x00059F40
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
			this.NBPKMLMCHFN.SetFloat("_SizeX", this.SizeX);
			this.NBPKMLMCHFN.SetFloat("_SizeY", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0005BE28 File Offset: 0x0005A028
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1453f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.HFBJAOFLCJI().SetFloat("open", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_SSAO", this.Distortion);
			this.HNICHJCGJOC().SetFloat("_Value", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("_Value3", this.SizeY);
			this.HFBJAOFLCJI().SetFloat("--------------------------------", this.Speed);
			this.DNLMFEGJJDD().SetTexture("_QualitySettings", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x0005BF10 File Offset: 0x0005A110
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 39f)
			{
				this.HBJJOCHGOPH = 982f;
			}
			this.EFDEIFCDAFG().SetFloat(": ", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_FgOverlap", this.Distortion);
			this.HFBJAOFLCJI().SetFloat(".a", this.SizeX);
			this.HNICHJCGJOC().SetFloat("{0}", this.SizeY);
			this.HNICHJCGJOC().SetFloat("_Glitch", this.Speed);
			this.EFDEIFCDAFG().SetTexture("Scale environment object by the values", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0005C030 File Offset: 0x0005A230
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1395f)
			{
				this.HBJJOCHGOPH = 1092f;
			}
			this.NBPKMLMCHFN.SetFloat("achievements.26.progress", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("id", this.Distortion);
			this.EFDEIFCDAFG().SetFloat("float,1", this.SizeX);
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.SizeY);
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this.Speed);
			this.NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Funk", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0005C118 File Offset: 0x0005A318
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x0005C150 File Offset: 0x0005A350
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 737f)
			{
				this.HBJJOCHGOPH = 1614f;
			}
			this.HNICHJCGJOC().SetFloat("/", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("master", this.Distortion);
			this.HFBJAOFLCJI().SetFloat("RT", this.SizeX);
			this.NBPKMLMCHFN.SetFloat("Testing, a toggle has toggled [", this.SizeY);
			this.DNLMFEGJJDD().SetFloat("NetworkCanvas", this.Speed);
			this.HFBJAOFLCJI().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0005C238 File Offset: 0x0005A438
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("OneHand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0005BCB1 File Offset: 0x00059EB1
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0005C271 File Offset: 0x0005A471
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

	// Token: 0x06000C93 RID: 3219 RVA: 0x0005C2A8 File Offset: 0x0005A4A8
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0005C31E File Offset: 0x0005A51E
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Lut_TestMode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0005C357 File Offset: 0x0005A557
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("_LightIntensity") as Texture2D);
		this.SCShader = Shader.Find("<color=#{0}>{1}</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x0005BCB1 File Offset: 0x00059EB1
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x0005C390 File Offset: 0x0005A590
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1073f)
			{
				this.HBJJOCHGOPH = 1503f;
			}
			this.EFDEIFCDAFG().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("/512px-512px.png", this.SizeX);
			this.EFDEIFCDAFG().SetFloat("NEW_ACHIEVEMENT_1_26", this.SizeY);
			this.DNLMFEGJJDD().SetFloat("IconImage", this.Speed);
			this.HNICHJCGJOC().SetTexture("settings.enablehitsoundsinrelax", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x0005C478 File Offset: 0x0005A678
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1634f)
			{
				this.HBJJOCHGOPH = 567f;
			}
			this.DNLMFEGJJDD().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("InstantiateRpc", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("RanksButton", this.SizeX);
			this.HFBJAOFLCJI().SetFloat("plogs", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("\\", this.Speed);
			this.HNICHJCGJOC().SetTexture("ICollection", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x0005C560 File Offset: 0x0005A760
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("Texture2") as Texture2D);
		this.SCShader = Shader.Find("[MapsData] Caching ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x0005C599 File Offset: 0x0005A799
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("_NoisePerChannel") as Texture2D);
		this.SCShader = Shader.Find("SubBass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0005C5D2 File Offset: 0x0005A7D2
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("#,0.00") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x0005C60C File Offset: 0x0005A80C
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1234f)
			{
				this.HBJJOCHGOPH = 1196f;
			}
			this.HNICHJCGJOC().SetFloat("id", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("OK", this.Distortion);
			this.HFBJAOFLCJI().SetFloat("Gameplay/sun", this.SizeX);
			this.EFDEIFCDAFG().SetFloat("ItemsCountText", this.SizeY);
			this.NBPKMLMCHFN.SetFloat("settings.enableselectormusic", this.Speed);
			this.NBPKMLMCHFN.SetTexture("Scrollbar", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x0005BCB1 File Offset: 0x00059EB1
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x0005C6F4 File Offset: 0x0005A8F4
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x0005BCB1 File Offset: 0x00059EB1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001E2 RID: 482
	public Shader SCShader;

	// Token: 0x040001E3 RID: 483
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001E4 RID: 484
	[Range(8f, 64f)]
	public float Distortion = 8f;

	// Token: 0x040001E5 RID: 485
	[Range(0f, 7f)]
	public float SizeX = 1f;

	// Token: 0x040001E6 RID: 486
	[Range(0f, 7f)]
	public float SizeY = 0.5f;

	// Token: 0x040001E7 RID: 487
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x040001E8 RID: 488
	private Material BJFKDHHMLJH;

	// Token: 0x040001E9 RID: 489
	private Texture2D FPHEBLMINDA;
}
