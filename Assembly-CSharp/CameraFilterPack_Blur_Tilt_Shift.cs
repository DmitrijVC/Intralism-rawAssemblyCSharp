using System;
using UnityEngine;

// Token: 0x02000068 RID: 104
[AddComponentMenu("Camera Filter Pack/Blur/Tilt_Shift")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Tilt_Shift : MonoBehaviour
{
	// Token: 0x06001D52 RID: 7506 RVA: 0x000B16DF File Offset: 0x000AF8DF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/BlurTiltShift");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x000B1703 File Offset: 0x000AF903
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x000B1727 File Offset: 0x000AF927
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_RgbClamp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x000B174B File Offset: 0x000AF94B
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x000B17D8 File Offset: 0x000AF9D8
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1466f)
			{
				this.HBJJOCHGOPH = 894f;
			}
			this.DBOLLHHMKKN().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_CenterX", this.Amount);
			this.ACHNOHCLGOO().SetFloat("Intensity", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("0.00", this.Size);
			this.ACHNOHCLGOO().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", this.Position);
			this.DBOLLHHMKKN().SetVector("restrictions", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)4;
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN(), 3);
				Graphics.Blit(temporary, temporary2, this.ACHNOHCLGOO(), 1);
				this.LDNADDJMIPK().SetFloat("Save", this.Amount * 1888f);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 5);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.ACHNOHCLGOO().SetTexture("menu.playedpage", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x000B19A0 File Offset: 0x000AFBA0
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 793f)
			{
				this.HBJJOCHGOPH = 409f;
			}
			this.LDNADDJMIPK().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("FinalScoreSmallText", this.Amount);
			this.NBPKMLMCHFN.SetFloat("inventory.selected.", this.Smooth);
			this.ACHNOHCLGOO().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Size);
			this.NBPKMLMCHFN.SetFloat("input", this.Position);
			this.LDNADDJMIPK().SetVector("#scoresubmitionfailed: ", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN(), 8);
				Graphics.Blit(temporary, temporary2, this.DBOLLHHMKKN(), 0);
				this.ACHNOHCLGOO().SetFloat("[MapEditor] Loading music...", this.Amount * 1597f);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 6);
				Graphics.Blit(temporary, temporary2, this.ACHNOHCLGOO(), 0);
				this.LDNADDJMIPK().SetTexture("CameraFilterPack/TV_Vintage", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x000B1B65 File Offset: 0x000AFD65
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x000B1B82 File Offset: 0x000AFD82
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x000B1BB9 File Offset: 0x000AFDB9
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("SetSunSensitivity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x000B1BE0 File Offset: 0x000AFDE0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1613f)
			{
				this.HBJJOCHGOPH = 1879f;
			}
			this.ACHNOHCLGOO().SetFloat("shader.none", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value9", this.Amount);
			this.DBOLLHHMKKN().SetFloat("Ignored PU RPC, cause item is inactive. ", this.Smooth);
			this.DBOLLHHMKKN().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", this.Size);
			this.NBPKMLMCHFN.SetFloat("SetParticlesGravity", this.Position);
			this.ACHNOHCLGOO().SetVector("_Source", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, this.LDNADDJMIPK(), 2);
				Graphics.Blit(temporary, temporary2, this.ACHNOHCLGOO(), 1);
				this.NBPKMLMCHFN.SetFloat("<color=#", this.Amount * 1037f);
				Graphics.Blit(temporary2, temporary, this.ACHNOHCLGOO(), 8);
				Graphics.Blit(temporary, temporary2, this.ACHNOHCLGOO(), 1);
				this.NBPKMLMCHFN.SetTexture("_Value", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x000B1DA5 File Offset: 0x000AFFA5
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x000B1DDC File Offset: 0x000AFFDC
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1816f)
			{
				this.HBJJOCHGOPH = 5f;
			}
			this.ACHNOHCLGOO().SetFloat("new round", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_Value5", this.Amount);
			this.DBOLLHHMKKN().SetFloat("maps.", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.ACHNOHCLGOO().SetFloat("_UV_Transform", this.Position);
			this.LDNADDJMIPK().SetVector("/", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)8;
				Graphics.Blit(AAACLELCPML, temporary, this.ACHNOHCLGOO(), 4);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 1);
				this.DBOLLHHMKKN().SetFloat("_Alpha", this.Amount * 973f);
				Graphics.Blit(temporary2, temporary, this.ACHNOHCLGOO(), 5);
				Graphics.Blit(temporary, temporary2, this.LDNADDJMIPK(), 0);
				this.NBPKMLMCHFN.SetTexture("skin.no_hit", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x000B1FA4 File Offset: 0x000B01A4
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Position);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount * 2f);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetTexture("_MainTex2", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x000B2169 File Offset: 0x000B0369
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06001D63 RID: 7523 RVA: 0x000B218D File Offset: 0x000B038D
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

	// Token: 0x06001D64 RID: 7524 RVA: 0x000B21C4 File Offset: 0x000B03C4
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_GrainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x000B21E8 File Offset: 0x000B03E8
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x000B220C File Offset: 0x000B040C
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x000B1B65 File Offset: 0x000AFD65
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040003EF RID: 1007
	public Shader SCShader;

	// Token: 0x040003F0 RID: 1008
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003F1 RID: 1009
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003F2 RID: 1010
	private Material BJFKDHHMLJH;

	// Token: 0x040003F3 RID: 1011
	[Range(0f, 20f)]
	public float Amount = 3f;

	// Token: 0x040003F4 RID: 1012
	[Range(2f, 16f)]
	public int FastFilter = 8;

	// Token: 0x040003F5 RID: 1013
	[Range(0f, 1f)]
	public float Smooth = 0.5f;

	// Token: 0x040003F6 RID: 1014
	[Range(0f, 1f)]
	public float Size = 0.5f;

	// Token: 0x040003F7 RID: 1015
	[Range(-1f, 1f)]
	public float Position = 0.5f;
}
