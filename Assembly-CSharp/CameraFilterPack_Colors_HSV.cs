using System;
using UnityEngine;

// Token: 0x0200007E RID: 126
[AddComponentMenu("Camera Filter Pack/Colors/HSV")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_HSV : MonoBehaviour
{
	// Token: 0x060023CF RID: 9167 RVA: 0x000CF0C7 File Offset: 0x000CD2C7
	private void BEBNOKFLJPH()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x000CF0DC File Offset: 0x000CD2DC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HHIFMIPPMPF().SetFloat("[MapsData] Bad map: ", this._HueShift);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/Drawing_Manga5", this._Saturation);
			this.ACHNOHCLGOO().SetFloat("tagElement", this._ValueBrightness);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x000CF155 File Offset: 0x000CD355
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x000CF0C7 File Offset: 0x000CD2C7
	private void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x000CF155 File Offset: 0x000CD355
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x000CF155 File Offset: 0x000CD355
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x000CF174 File Offset: 0x000CD374
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBPKMLMCHFN.SetFloat("_HueShift", this._HueShift);
			this.NBPKMLMCHFN.SetFloat("_Sat", this._Saturation);
			this.NBPKMLMCHFN.SetFloat("_Val", this._ValueBrightness);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x000CF1ED File Offset: 0x000CD3ED
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060023D9 RID: 9177 RVA: 0x000CF224 File Offset: 0x000CD424
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

	// Token: 0x060023DA RID: 9178 RVA: 0x000CF25B File Offset: 0x000CD45B
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x000CF0C7 File Offset: 0x000CD2C7
	private void KLILJHJNICK()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x000CF2BB File Offset: 0x000CD4BB
	private void IMCKJCHKMKB()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x000CF2D0 File Offset: 0x000CD4D0
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/TV_WideScreenHV", this._HueShift);
			this.ACHNOHCLGOO().SetFloat("_AOTex", this._Saturation);
			this.HHIFMIPPMPF().SetFloat("resource", this._ValueBrightness);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x000CF155 File Offset: 0x000CD355
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x000CF155 File Offset: 0x000CD355
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400049F RID: 1183
	public Shader SCShader;

	// Token: 0x040004A0 RID: 1184
	[Range(0f, 360f)]
	public float _HueShift = 180f;

	// Token: 0x040004A1 RID: 1185
	[Range(-32f, 32f)]
	public float _Saturation = 1f;

	// Token: 0x040004A2 RID: 1186
	[Range(-32f, 32f)]
	public float _ValueBrightness = 1f;

	// Token: 0x040004A3 RID: 1187
	private Material BJFKDHHMLJH;
}
