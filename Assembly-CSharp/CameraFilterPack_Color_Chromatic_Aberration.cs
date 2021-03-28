using System;
using UnityEngine;

// Token: 0x0200006D RID: 109
[AddComponentMenu("Camera Filter Pack/Colors/Chromatic_Aberration")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Chromatic_Aberration : MonoBehaviour
{
	// Token: 0x06001E5D RID: 7773 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000B698C File Offset: 0x000B4B8C
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Chromatic_Aberration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x000B69B0 File Offset: 0x000B4BB0
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("#useticket");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x000B69D4 File Offset: 0x000B4BD4
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x000B6A0B File Offset: 0x000B4C0B
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E67 RID: 7783 RVA: 0x000B6A42 File Offset: 0x000B4C42
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_Bullet_8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x000B6A66 File Offset: 0x000B4C66
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x000B69D4 File Offset: 0x000B4BD4
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E6B RID: 7787 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x000B6A8A File Offset: 0x000B4C8A
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x000B6AC1 File Offset: 0x000B4CC1
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x000B6B16 File Offset: 0x000B4D16
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06001E73 RID: 7795 RVA: 0x000B6B4D File Offset: 0x000B4D4D
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

	// Token: 0x06001E74 RID: 7796 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x000B696F File Offset: 0x000B4B6F
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x000B6B84 File Offset: 0x000B4D84
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("deletemap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x000B6BA8 File Offset: 0x000B4DA8
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x000B6BE0 File Offset: 0x000B4DE0
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 345f)
			{
				this.HBJJOCHGOPH = 1975f;
			}
			this.BFGNMFCNDBC().SetFloat("speed", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_DistCenterScale", this.Offset);
			this.FAIFBBGFAIB().SetVector(" registered.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 174f, 645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x000B6C9D File Offset: 0x000B4E9D
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x000B6CD4 File Offset: 0x000B4ED4
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1532f)
			{
				this.HBJJOCHGOPH = 1991f;
			}
			this.PGPEMMBJOOG().SetFloat("{0}\t is: {1}", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/RainFX", this.Offset);
			this.NFMGLIKNOOC().SetVector("music", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1346f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x000B6D91 File Offset: 0x000B4F91
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000B6DC8 File Offset: 0x000B4FC8
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x000B6DFF File Offset: 0x000B4FFF
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_PositionY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x000B6E24 File Offset: 0x000B5024
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Offset);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000B6EE1 File Offset: 0x000B50E1
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Bloom3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x000B6F05 File Offset: 0x000B5105
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x000B6A66 File Offset: 0x000B4C66
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000418 RID: 1048
	public Shader SCShader;

	// Token: 0x04000419 RID: 1049
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400041A RID: 1050
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400041B RID: 1051
	private Material BJFKDHHMLJH;

	// Token: 0x0400041C RID: 1052
	[Range(-0.02f, 0.02f)]
	public float Offset = 0.02f;
}
