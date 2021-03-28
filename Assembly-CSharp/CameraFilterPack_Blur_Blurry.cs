using System;
using UnityEngine;

// Token: 0x0200005D RID: 93
[AddComponentMenu("Camera Filter Pack/Blur/Blurry")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Blurry : MonoBehaviour
{
	// Token: 0x06001A73 RID: 6771 RVA: 0x000A559C File Offset: 0x000A379C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 348f)
			{
				this.HBJJOCHGOPH = 733f;
			}
			this.ACHNOHCLGOO().SetFloat(".completedCount", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Creating new item...", this.Amount);
			this.IONHGBPGCHK().SetVector("offsets", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06001A74 RID: 6772 RVA: 0x000A56AA File Offset: 0x000A38AA
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

	// Token: 0x06001A75 RID: 6773 RVA: 0x000A56E4 File Offset: 0x000A38E4
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 162f)
			{
				this.HBJJOCHGOPH = 1273f;
			}
			this.IONHGBPGCHK().SetFloat("_SampleDistance", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Amount);
			this.IONHGBPGCHK().SetVector("in seconds. 0 - forever", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x000A57F2 File Offset: 0x000A39F2
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x000A5834 File Offset: 0x000A3A34
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1203f)
			{
				this.HBJJOCHGOPH = 1076f;
			}
			this.KGOLDDBHIFN().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_SunThreshold", this.Amount);
			this.IONHGBPGCHK().SetVector("maps.", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x000A5942 File Offset: 0x000A3B42
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x000A597C File Offset: 0x000A3B7C
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x000A5A8A File Offset: 0x000A3C8A
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x000A5AC1 File Offset: 0x000A3CC1
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A7F RID: 6783 RVA: 0x000A57F2 File Offset: 0x000A39F2
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A80 RID: 6784 RVA: 0x000A5AF8 File Offset: 0x000A3CF8
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x000A5B2F File Offset: 0x000A3D2F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Blurry");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x000A5B54 File Offset: 0x000A3D54
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 50f)
			{
				this.HBJJOCHGOPH = 1699f;
			}
			this.ACHNOHCLGOO().SetFloat("\n\n#", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("System.Single", this.Amount);
			this.KGOLDDBHIFN().SetVector("[ItemsHandler] Loading ", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.KGOLDDBHIFN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x000A57F2 File Offset: 0x000A39F2
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040003A7 RID: 935
	public Shader SCShader;

	// Token: 0x040003A8 RID: 936
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003A9 RID: 937
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003AA RID: 938
	private Material BJFKDHHMLJH;

	// Token: 0x040003AB RID: 939
	[Range(0f, 20f)]
	public float Amount = 2f;

	// Token: 0x040003AC RID: 940
	[Range(1f, 8f)]
	public int FastFilter = 2;
}
