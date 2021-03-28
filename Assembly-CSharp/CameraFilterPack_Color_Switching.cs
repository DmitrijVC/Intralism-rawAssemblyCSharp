using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
[AddComponentMenu("Camera Filter Pack/Colors/Switching")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Switching : MonoBehaviour
{
	// Token: 0x06002153 RID: 8531 RVA: 0x000C0481 File Offset: 0x000BE681
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x000C04B8 File Offset: 0x000BE6B8
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x000C04EF File Offset: 0x000BE6EF
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("[SERVER] Kicked ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x000C0513 File Offset: 0x000BE713
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x000C0530 File Offset: 0x000BE730
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("?page=addtip");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x000C0554 File Offset: 0x000BE754
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 520f)
			{
				this.HBJJOCHGOPH = 435f;
			}
			this.ADBKPGFMNKO().SetFloat("IEnumerable", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("SetSpeed", (float)this.Color);
			this.ADBKPGFMNKO().SetVector("\"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1981f, 1488f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000C0612 File Offset: 0x000BE812
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x000C0513 File Offset: 0x000BE713
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x000C0636 File Offset: 0x000BE836
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("ItemNameBGImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x000C065A File Offset: 0x000BE85A
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x000C0513 File Offset: 0x000BE713
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x000C0680 File Offset: 0x000BE880
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1462f)
			{
				this.HBJJOCHGOPH = 1767f;
			}
			this.IONHGBPGCHK().SetFloat("z", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("_Offsets", (float)this.Color);
			this.KGOLDDBHIFN().SetVector("SupportLogger Info: PUN {0}: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 586f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x000C0513 File Offset: 0x000BE713
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x000C0740 File Offset: 0x000BE940
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 910f)
			{
				this.HBJJOCHGOPH = 289f;
			}
			this.KAFBNOBOIAJ().SetFloat("_SmoothEnd", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("SingleplayerButton", (float)this.Color);
			this.DEFBJOCJJKF().SetVector(". The group number should be at least 1.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 187f, 1971f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x000C07FE File Offset: 0x000BE9FE
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x000C0838 File Offset: 0x000BEA38
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", (float)this.Color);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x000C0513 File Offset: 0x000BE713
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x000C08F6 File Offset: 0x000BEAF6
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("menu.relaxinfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x000C091C File Offset: 0x000BEB1C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1550f)
			{
				this.HBJJOCHGOPH = 558f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat(": ", (float)this.Color);
			this.IONHGBPGCHK().SetVector("[MapsData] Found ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 974f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x000C09F4 File Offset: 0x000BEBF4
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find(" while connecting to: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x0600216B RID: 8555 RVA: 0x000C0A18 File Offset: 0x000BEC18
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

	// Token: 0x0600216C RID: 8556 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x000C0A50 File Offset: 0x000BEC50
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 750f)
			{
				this.HBJJOCHGOPH = 666f;
			}
			this.HHIFMIPPMPF().SetFloat("_SunPosition", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat(",", (float)this.Color);
			this.ADBKPGFMNKO().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1367f, 366f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x000C0513 File Offset: 0x000BE713
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x000C0B10 File Offset: 0x000BED10
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 75f)
			{
				this.HBJJOCHGOPH = 129f;
			}
			this.KGOLDDBHIFN().SetFloat("_Extra", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/Light_Rainbow", (float)this.Color);
			this.DEFBJOCJJKF().SetVector("_SunPosition", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 971f, 264f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x000C0513 File Offset: 0x000BE713
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x000C0513 File Offset: 0x000BE713
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x000C0BD0 File Offset: 0x000BEDD0
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1089f)
			{
				this.HBJJOCHGOPH = 1622f;
			}
			this.NBPKMLMCHFN.SetFloat("Freq: ", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("PickupItemInit", (float)this.Color);
			this.DEFBJOCJJKF().SetVector("[", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 14f, 513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x000C0C8E File Offset: 0x000BEE8E
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x000C0CC8 File Offset: 0x000BEEC8
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1188f)
			{
				this.HBJJOCHGOPH = 478f;
			}
			this.KGOLDDBHIFN().SetFloat("CONTRAST", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_Value", (float)this.Color);
			this.IONHGBPGCHK().SetVector("seconds", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1116f, 178f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x000C0D88 File Offset: 0x000BEF88
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 856f)
			{
				this.HBJJOCHGOPH = 1754f;
			}
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("SetPlayerDistance", (float)this.Color);
			this.IONHGBPGCHK().SetVector("Scrollbar", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1479f, 1021f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x000C0E48 File Offset: 0x000BF048
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 397f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Added checkpoint", (float)this.Color);
			this.KAFBNOBOIAJ().SetVector("_Green_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1806f, 1839f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x000C0F06 File Offset: 0x000BF106
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x000C0F3D File Offset: 0x000BF13D
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x000C0F74 File Offset: 0x000BF174
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x000C0F98 File Offset: 0x000BF198
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Switching");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000442 RID: 1090
	public Shader SCShader;

	// Token: 0x04000443 RID: 1091
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000444 RID: 1092
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000445 RID: 1093
	private Material BJFKDHHMLJH;

	// Token: 0x04000446 RID: 1094
	[Range(0f, 5f)]
	public int Color = 1;
}
