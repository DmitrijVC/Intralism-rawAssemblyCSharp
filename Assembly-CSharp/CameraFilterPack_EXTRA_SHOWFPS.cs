using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000B6 RID: 182
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/EXTRA/SHOWFPS")]
public class CameraFilterPack_EXTRA_SHOWFPS : MonoBehaviour
{
	// Token: 0x060037AD RID: 14253 RVA: 0x0011CAB6 File Offset: 0x0011ACB6
	private void AEIJFLJEABG()
	{
		this.OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		this.NOIDDEDHJDF++;
	}

	// Token: 0x060037AE RID: 14254 RVA: 0x0011CADE File Offset: 0x0011ACDE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060037AF RID: 14255 RVA: 0x0011CAFB File Offset: 0x0011ACFB
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060037B0 RID: 14256 RVA: 0x0011CB32 File Offset: 0x0011AD32
	private void EGEPLFGKGLI()
	{
		this.PBNOHCNHAHB = 0;
		base.StartCoroutine(this.DKKLGINECAC());
		this.SCShader = Shader.Find("Set satellite lerp speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060037B1 RID: 14257 RVA: 0x0011CB6A File Offset: 0x0011AD6A
	private void JKFDDNMPOJH()
	{
		this.PBNOHCNHAHB = 0;
		base.StartCoroutine(this.EBJKKIKCJCC());
		this.SCShader = Shader.Find("SetParticlesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060037B2 RID: 14258 RVA: 0x0011CBA2 File Offset: 0x0011ADA2
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

	// Token: 0x060037B3 RID: 14259 RVA: 0x0011CBDC File Offset: 0x0011ADDC
	private IEnumerator DKKLGINECAC()
	{
		for (;;)
		{
			float num = this.OLIFJHCOEGP / (float)this.NOIDDEDHJDF;
			this.PBNOHCNHAHB = (int)num;
			this.OLIFJHCOEGP = 0f;
			this.NOIDDEDHJDF = 0;
			yield return new WaitForSeconds(this.frequency);
		}
		yield break;
	}

	// Token: 0x060037B4 RID: 14260 RVA: 0x0011CBF7 File Offset: 0x0011ADF7
	private void DIPDEHOOBPG()
	{
		this.PBNOHCNHAHB = 1;
		base.StartCoroutine(this.DKKLGINECAC());
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060037B5 RID: 14261 RVA: 0x0011CC30 File Offset: 0x0011AE30
	private IEnumerator EBJKKIKCJCC()
	{
		for (;;)
		{
			num = this.OLIFJHCOEGP / (float)this.NOIDDEDHJDF;
			this.PBNOHCNHAHB = (int)num;
			this.OLIFJHCOEGP = 0f;
			this.NOIDDEDHJDF = 0;
			yield return new WaitForSeconds(this.frequency);
		}
		yield break;
	}

	// Token: 0x060037B6 RID: 14262 RVA: 0x0011CC4B File Offset: 0x0011AE4B
	private void KDMANOEMOCA()
	{
		this.PBNOHCNHAHB = 1;
		base.StartCoroutine(this.DKKLGINECAC());
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060037B7 RID: 14263 RVA: 0x0011CC83 File Offset: 0x0011AE83
	private void Start()
	{
		this.PBNOHCNHAHB = 0;
		base.StartCoroutine(this.DKKLGINECAC());
		this.SCShader = Shader.Find("CameraFilterPack/EXTRA_SHOWFPS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060037B8 RID: 14264 RVA: 0x0011CCBB File Offset: 0x0011AEBB
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060037B9 RID: 14265 RVA: 0x0011CCF4 File Offset: 0x0011AEF4
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1018f)
			{
				this.HBJJOCHGOPH = 1838f;
			}
			this.ACHNOHCLGOO().SetFloat("mode", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("DPADVER", this.Size);
			this.HFBJAOFLCJI().SetFloat(": ", (float)this.PBNOHCNHAHB);
			this.ACHNOHCLGOO().SetFloat("MenuVolumeSlider", this.ILHJFHFPGBB);
			this.HFBJAOFLCJI().SetFloat("_PositionY", this.CCIENBFIKKH);
			this.ACHNOHCLGOO().SetVector("#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 376f, 1126f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060037BA RID: 14266 RVA: 0x0011CADE File Offset: 0x0011ACDE
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060037BB RID: 14267 RVA: 0x0011CADE File Offset: 0x0011ACDE
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060037BC RID: 14268 RVA: 0x0011CAB6 File Offset: 0x0011ACB6
	private void KMKLDAJLCNM()
	{
		this.OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		this.NOIDDEDHJDF++;
	}

	// Token: 0x060037BE RID: 14270 RVA: 0x0011CE48 File Offset: 0x0011B048
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", (float)this.PBNOHCNHAHB);
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

	// Token: 0x060037BF RID: 14271 RVA: 0x0011CF48 File Offset: 0x0011B148
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060037C0 RID: 14272 RVA: 0x0011CF7F File Offset: 0x0011B17F
	private void BEBNOKFLJPH()
	{
		this.PBNOHCNHAHB = 1;
		base.StartCoroutine(this.DKKLGINECAC());
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060037C1 RID: 14273 RVA: 0x0011CAB6 File Offset: 0x0011ACB6
	private void Update()
	{
		this.OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		this.NOIDDEDHJDF++;
	}

	// Token: 0x060037C2 RID: 14274 RVA: 0x0011CFB7 File Offset: 0x0011B1B7
	private void MAOCOEGAFND()
	{
		this.OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		this.NOIDDEDHJDF += 0;
	}

	// Token: 0x04000613 RID: 1555
	public Shader SCShader;

	// Token: 0x04000614 RID: 1556
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000615 RID: 1557
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000616 RID: 1558
	private Material BJFKDHHMLJH;

	// Token: 0x04000617 RID: 1559
	[Range(8f, 42f)]
	public float Size = 12f;

	// Token: 0x04000618 RID: 1560
	[Range(0f, 100f)]
	private int PBNOHCNHAHB = 1;

	// Token: 0x04000619 RID: 1561
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x0400061A RID: 1562
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

	// Token: 0x0400061B RID: 1563
	private float OLIFJHCOEGP;

	// Token: 0x0400061C RID: 1564
	private int NOIDDEDHJDF;

	// Token: 0x0400061D RID: 1565
	public float frequency = 0.5f;
}
