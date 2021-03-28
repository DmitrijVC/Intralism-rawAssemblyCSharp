using System;
using UnityEngine;

// Token: 0x02000134 RID: 308
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Drost")]
public class CameraFilterPack_Vision_Drost : MonoBehaviour
{
	// Token: 0x06006163 RID: 24931 RVA: 0x001D9C16 File Offset: 0x001D7E16
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("new round");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006164 RID: 24932 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006165 RID: 24933 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06006166 RID: 24934 RVA: 0x001D9C58 File Offset: 0x001D7E58
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006167 RID: 24935 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006168 RID: 24936 RVA: 0x001D9D57 File Offset: 0x001D7F57
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006169 RID: 24937 RVA: 0x001D9D90 File Offset: 0x001D7F90
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 76f)
			{
				this.HBJJOCHGOPH = 168f;
			}
			this.DEFBJOCJJKF().SetFloat("position", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("CurrentTimeLabel", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("Using constructor for new PingNativeDynamic()", this.Speed);
			this.KBOPGONOCNP().SetFloat("_Amount", this.ILHJFHFPGBB);
			this.IIBLJCKLGFG().SetFloat("ChatHistoryInputField", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1833f, 522f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600616A RID: 24938 RVA: 0x001D9E90 File Offset: 0x001D8090
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 855f)
			{
				this.HBJJOCHGOPH = 1374f;
			}
			this.NBPKMLMCHFN.SetFloat(": ", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Value4", this.Intensity);
			this.DEFBJOCJJKF().SetFloat("st", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_BorderSize", this.ILHJFHFPGBB);
			this.DEFBJOCJJKF().SetFloat("Validating mod pack...", this.CCIENBFIKKH);
			this.DNLMFEGJJDD().SetVector("Screenshots only supported in PlayMode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1649f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600616B RID: 24939 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600616C RID: 24940 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x0600616D RID: 24941 RVA: 0x001D9F90 File Offset: 0x001D8190
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1561f)
			{
				this.HBJJOCHGOPH = 1149f;
			}
			this.DEFBJOCJJKF().SetFloat("ResourceFileSelector", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.Intensity);
			this.EPCGJFCCAFH().SetFloat("ok", this.Speed);
			this.NBPKMLMCHFN.SetFloat("icon_border", this.ILHJFHFPGBB);
			this.EPCGJFCCAFH().SetFloat("ItemNameText", this.CCIENBFIKKH);
			this.KEMAALEODNH().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 671f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600616E RID: 24942 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600616F RID: 24943 RVA: 0x001DA090 File Offset: 0x001D8290
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1875f)
			{
				this.HBJJOCHGOPH = 998f;
			}
			this.KEMAALEODNH().SetFloat("ShowSprite", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("X", this.Intensity);
			this.KBOPGONOCNP().SetFloat(".", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("GridDataArcs", this.CCIENBFIKKH);
			this.DNLMFEGJJDD().SetVector("image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1918f, 570f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006170 RID: 24944 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006171 RID: 24945 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06006172 RID: 24946 RVA: 0x001DA18F File Offset: 0x001D838F
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006173 RID: 24947 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006174 RID: 24948 RVA: 0x001DA1B4 File Offset: 0x001D83B4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1147f)
			{
				this.HBJJOCHGOPH = 1229f;
			}
			this.KEMAALEODNH().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_TreatBackfaceHitAsMiss", this.Intensity);
			this.KBOPGONOCNP().SetFloat("AudioSampler", this.Speed);
			this.IIBLJCKLGFG().SetFloat("_FgCocMask", this.ILHJFHFPGBB);
			this.KEMAALEODNH().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("Result for ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 219f, 26f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006176 RID: 24950 RVA: 0x001DA2F2 File Offset: 0x001D84F2
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006177 RID: 24951 RVA: 0x001DA329 File Offset: 0x001D8529
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Drost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006178 RID: 24952 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06006179 RID: 24953 RVA: 0x001DA34D File Offset: 0x001D854D
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600617A RID: 24954 RVA: 0x001DA384 File Offset: 0x001D8584
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600617B RID: 24955 RVA: 0x001DA3A8 File Offset: 0x001D85A8
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("MessageText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x0600617C RID: 24956 RVA: 0x001DA3CC File Offset: 0x001D85CC
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

	// Token: 0x0600617D RID: 24957 RVA: 0x001DA403 File Offset: 0x001D8603
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("Missing shader in ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600617E RID: 24958 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600617F RID: 24959 RVA: 0x001DA427 File Offset: 0x001D8627
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006180 RID: 24960 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06006181 RID: 24961 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006182 RID: 24962 RVA: 0x001D9C3A File Offset: 0x001D7E3A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006183 RID: 24963 RVA: 0x001DA460 File Offset: 0x001D8660
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 973f)
			{
				this.HBJJOCHGOPH = 1240f;
			}
			this.NBPKMLMCHFN.SetFloat("Waiting to start", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(",", this.Intensity);
			this.IIBLJCKLGFG().SetFloat("STICKRHOR", this.Speed);
			this.KBOPGONOCNP().SetFloat("_MainTex2", this.ILHJFHFPGBB);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.KEMAALEODNH().SetVector("_FadeFX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 101f, 1106f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006184 RID: 24964 RVA: 0x001DA55F File Offset: 0x001D875F
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006185 RID: 24965 RVA: 0x001DA596 File Offset: 0x001D8796
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("MenuPlayButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006186 RID: 24966 RVA: 0x001DA5BA File Offset: 0x001D87BA
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040009CD RID: 2509
	public Shader SCShader;

	// Token: 0x040009CE RID: 2510
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009CF RID: 2511
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009D0 RID: 2512
	private Material BJFKDHHMLJH;

	// Token: 0x040009D1 RID: 2513
	[Range(0f, 0.4f)]
	public float Intensity = 0.4f;

	// Token: 0x040009D2 RID: 2514
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x040009D3 RID: 2515
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x040009D4 RID: 2516
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
