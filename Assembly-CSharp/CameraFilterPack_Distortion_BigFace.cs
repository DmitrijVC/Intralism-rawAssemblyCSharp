using System;
using UnityEngine;

// Token: 0x02000085 RID: 133
[AddComponentMenu("Camera Filter Pack/Distortion/BigFace")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_BigFace : MonoBehaviour
{
	// Token: 0x060025ED RID: 9709 RVA: 0x000D72F4 File Offset: 0x000D54F4
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1574f)
			{
				this.HBJJOCHGOPH = 1414f;
			}
			this.JIBOKBCPDLC().SetFloat(" ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("SetPlayerDistance", this.Distortion);
			this.EFDEIFCDAFG().SetFloat("sounds/hit_normal", this._Size);
			this.ADBKPGFMNKO().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 947f, 972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x000D73E4 File Offset: 0x000D55E4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1855f)
			{
				this.HBJJOCHGOPH = 1973f;
			}
			this.EFDEIFCDAFG().SetFloat("Image", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_BlurSize", this.Distortion);
			this.ADBKPGFMNKO().SetFloat("Object ID", this._Size);
			this.DOHGBNPMBKG().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 126f, 934f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x000D74B8 File Offset: 0x000D56B8
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 942f)
			{
				this.HBJJOCHGOPH = 1862f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("The given 2D texture ", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("[Right]", this._Size);
			this.JIBOKBCPDLC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1104f, 1639f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025F1 RID: 9713 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025F2 RID: 9714 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025F4 RID: 9716 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060025F5 RID: 9717 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025F6 RID: 9718 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025F7 RID: 9719 RVA: 0x000D758B File Offset: 0x000D578B
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x000D75C2 File Offset: 0x000D57C2
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("ColorBlood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060025FC RID: 9724 RVA: 0x000D75E6 File Offset: 0x000D57E6
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060025FD RID: 9725 RVA: 0x000D760A File Offset: 0x000D580A
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

	// Token: 0x060025FE RID: 9726 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060025FF RID: 9727 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002600 RID: 9728 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002601 RID: 9729 RVA: 0x000D7641 File Offset: 0x000D5841
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_BigFace");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002602 RID: 9730 RVA: 0x000D7668 File Offset: 0x000D5868
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 190f)
			{
				this.HBJJOCHGOPH = 512f;
			}
			this.ADBKPGFMNKO().SetFloat("Network destroy Instantiated GO: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("DPADVER", this.Distortion);
			this.EFDEIFCDAFG().SetFloat("float,1", this._Size);
			this.ADBKPGFMNKO().SetVector("_CurveParams", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 41f, 1277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x000D773B File Offset: 0x000D593B
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x000D7772 File Offset: 0x000D5972
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x000D77BF File Offset: 0x000D59BF
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600260A RID: 9738 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600260B RID: 9739 RVA: 0x000D77F6 File Offset: 0x000D59F6
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x000D73C7 File Offset: 0x000D55C7
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x000D781A File Offset: 0x000D5A1A
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("EnableRankingToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x000D783E File Offset: 0x000D5A3E
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x000D7878 File Offset: 0x000D5A78
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1081f)
			{
				this.HBJJOCHGOPH = 404f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value11", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("Set Satellite Trail Width", this.Distortion);
			this.NFMGLIKNOOC().SetFloat("HandsCountSlider", this._Size);
			this.NFMGLIKNOOC().SetVector("player.fire", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1503f, 818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x000D794B File Offset: 0x000D5B4B
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x000D7984 File Offset: 0x000D5B84
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
			this.NBPKMLMCHFN.SetFloat("_Size", this._Size);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x040004CE RID: 1230
	public Shader SCShader;

	// Token: 0x040004CF RID: 1231
	private float HBJJOCHGOPH = 6.5f;

	// Token: 0x040004D0 RID: 1232
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004D1 RID: 1233
	private Material BJFKDHHMLJH;

	// Token: 0x040004D2 RID: 1234
	public float _Size = 5f;

	// Token: 0x040004D3 RID: 1235
	[Range(2f, 10f)]
	public float Distortion = 2.5f;
}
