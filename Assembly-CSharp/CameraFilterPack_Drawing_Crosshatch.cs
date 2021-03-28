using System;
using UnityEngine;

// Token: 0x0200009B RID: 155
[AddComponentMenu("Camera Filter Pack/Drawing/Crosshatch")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Crosshatch : MonoBehaviour
{
	// Token: 0x06002EF3 RID: 12019 RVA: 0x000FAAEF File Offset: 0x000F8CEF
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("turn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002EF4 RID: 12020 RVA: 0x000FAB13 File Offset: 0x000F8D13
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x000FAB4A File Offset: 0x000F8D4A
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find(". Verify the Prefab is in a Resources folder (and not in a subfolder)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x000FAB6E File Offset: 0x000F8D6E
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002EF7 RID: 12023 RVA: 0x000FAB6E File Offset: 0x000F8D6E
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002EF8 RID: 12024 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002EF9 RID: 12025 RVA: 0x000FAB8B File Offset: 0x000F8D8B
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002EFA RID: 12026 RVA: 0x000FABC4 File Offset: 0x000F8DC4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 517f)
			{
				this.HBJJOCHGOPH = 279f;
			}
			this.KGOLDDBHIFN().SetFloat("#{0:00} '{1}'{2} {3}", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("SlidingArea", this.Width);
			this.DEFBJOCJJKF().SetVector("_Extra", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1857f, 1973f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x000FAB6E File Offset: 0x000F8D6E
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06002EFD RID: 12029 RVA: 0x000FAC81 File Offset: 0x000F8E81
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("%");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x000FACA5 File Offset: 0x000F8EA5
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002EFF RID: 12031 RVA: 0x000FACDC File Offset: 0x000F8EDC
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F00 RID: 12032 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06002F01 RID: 12033 RVA: 0x000FAD13 File Offset: 0x000F8F13
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F02 RID: 12034 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06002F03 RID: 12035 RVA: 0x000FAD4A File Offset: 0x000F8F4A
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F04 RID: 12036 RVA: 0x000FAD81 File Offset: 0x000F8F81
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F05 RID: 12037 RVA: 0x000FADB8 File Offset: 0x000F8FB8
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 974f)
			{
				this.HBJJOCHGOPH = 1085f;
			}
			this.KGOLDDBHIFN().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat(" Gb", this.Width);
			this.NBPKMLMCHFN.SetVector("_Factor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 787f, 183f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F06 RID: 12038 RVA: 0x000FAE75 File Offset: 0x000F9075
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F07 RID: 12039 RVA: 0x000FAB6E File Offset: 0x000F8D6E
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F08 RID: 12040 RVA: 0x000FAB6E File Offset: 0x000F8D6E
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F09 RID: 12041 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x000FAB6E File Offset: 0x000F8D6E
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x000FAEAC File Offset: 0x000F90AC
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Fly_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F0C RID: 12044 RVA: 0x000FAED0 File Offset: 0x000F90D0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 757f)
			{
				this.HBJJOCHGOPH = 768f;
			}
			this.BFGNMFCNDBC().SetFloat("PublishButton", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("0.00", this.Width);
			this.LONNIJMNKFB().SetVector("_Speed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1702f, 1039f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F0D RID: 12045 RVA: 0x000FAF90 File Offset: 0x000F9190
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Width);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F0E RID: 12046 RVA: 0x000FB04D File Offset: 0x000F924D
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F0F RID: 12047 RVA: 0x000FB084 File Offset: 0x000F9284
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F10 RID: 12048 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002F11 RID: 12049 RVA: 0x000FB0BB File Offset: 0x000F92BB
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Crosshatch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06002F12 RID: 12050 RVA: 0x000FB0DF File Offset: 0x000F92DF
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

	// Token: 0x06002F14 RID: 12052 RVA: 0x000FB134 File Offset: 0x000F9334
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Hexagon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F15 RID: 12053 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06002F16 RID: 12054 RVA: 0x000FAB6E File Offset: 0x000F8D6E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F17 RID: 12055 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06002F18 RID: 12056 RVA: 0x000FB158 File Offset: 0x000F9358
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 270f)
			{
				this.HBJJOCHGOPH = 1282f;
			}
			this.LONNIJMNKFB().SetFloat("Edited unlock conditions", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("A", this.Width);
			this.KGOLDDBHIFN().SetVector("color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 130f, 222f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000562 RID: 1378
	public Shader SCShader;

	// Token: 0x04000563 RID: 1379
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000564 RID: 1380
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000565 RID: 1381
	private Material BJFKDHHMLJH;

	// Token: 0x04000566 RID: 1382
	[Range(1f, 10f)]
	public float Width = 2f;
}
