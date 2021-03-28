using System;
using UnityEngine;

// Token: 0x020000A1 RID: 161
[AddComponentMenu("Camera Filter Pack/Drawing/Manga")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Manga : MonoBehaviour
{
	// Token: 0x0600304E RID: 12366 RVA: 0x00100B38 File Offset: 0x000FED38
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 833f)
			{
				this.HBJJOCHGOPH = 1075f;
			}
			this.NBPKMLMCHFN.SetFloat("New resource ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("/", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600304F RID: 12367 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06003050 RID: 12368 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06003051 RID: 12369 RVA: 0x00100BC8 File Offset: 0x000FEDC8
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("setAF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003052 RID: 12370 RVA: 0x00100BEC File Offset: 0x000FEDEC
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003053 RID: 12371 RVA: 0x00100C24 File Offset: 0x000FEE24
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1718f)
			{
				this.HBJJOCHGOPH = 1822f;
			}
			this.DNLMFEGJJDD().SetFloat("Joystick1Button1", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("/../", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003054 RID: 12372 RVA: 0x00100CB4 File Offset: 0x000FEEB4
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003055 RID: 12373 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003056 RID: 12374 RVA: 0x00100CD8 File Offset: 0x000FEED8
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x00100CFC File Offset: 0x000FEEFC
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x00100D33 File Offset: 0x000FEF33
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600305B RID: 12379 RVA: 0x00100D50 File Offset: 0x000FEF50
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("[SERVER] Player ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600305C RID: 12380 RVA: 0x00100D74 File Offset: 0x000FEF74
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

	// Token: 0x0600305D RID: 12381 RVA: 0x00100DAC File Offset: 0x000FEFAC
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
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x00100E3C File Offset: 0x000FF03C
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x00100D33 File Offset: 0x000FEF33
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003060 RID: 12384 RVA: 0x00100E73 File Offset: 0x000FF073
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x00100D33 File Offset: 0x000FEF33
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x00100EAC File Offset: 0x000FF0AC
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 191f)
			{
				this.HBJJOCHGOPH = 1112f;
			}
			this.GCDFNHMJMIP().SetFloat("_DistortionSize", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("Bad parameters for setbool! Use <key> <value>", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003063 RID: 12387 RVA: 0x00100F3C File Offset: 0x000FF13C
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003064 RID: 12388 RVA: 0x00100D33 File Offset: 0x000FEF33
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003066 RID: 12390 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003067 RID: 12391 RVA: 0x00100F91 File Offset: 0x000FF191
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000588 RID: 1416
	public Shader SCShader;

	// Token: 0x04000589 RID: 1417
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400058A RID: 1418
	private Material BJFKDHHMLJH;

	// Token: 0x0400058B RID: 1419
	[Range(1f, 8f)]
	public float DotSize = 4.72f;
}
