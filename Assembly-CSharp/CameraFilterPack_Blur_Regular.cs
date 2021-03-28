using System;
using UnityEngine;

// Token: 0x02000066 RID: 102
[AddComponentMenu("Camera Filter Pack/Blur/Regular")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Regular : MonoBehaviour
{
	// Token: 0x06001C9E RID: 7326 RVA: 0x000AF3E4 File Offset: 0x000AD5E4
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 380f)
			{
				this.HBJJOCHGOPH = 294f;
			}
			this.HNICHJCGJOC().SetFloat("GroupNameText", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("Joystick1Button9", (float)this.Level);
			this.NBPKMLMCHFN.SetVector("[DiscordController] Responding yes to Ask to Join request", this.Distance);
			this.NBPKMLMCHFN.SetVector("PLEASE WAIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 300f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x000AF4BD File Offset: 0x000AD6BD
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06001CA2 RID: 7330 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x000AF514 File Offset: 0x000AD714
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1821f)
			{
				this.HBJJOCHGOPH = 1330f;
			}
			this.HNICHJCGJOC().SetFloat("Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", (float)this.Level);
			this.GCDFNHMJMIP().SetVector("anonymous", this.Distance);
			this.LDNADDJMIPK().SetVector("VisionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 371f, 145f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CA6 RID: 7334 RVA: 0x000AF5ED File Offset: 0x000AD7ED
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CA7 RID: 7335 RVA: 0x000AF624 File Offset: 0x000AD824
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1143f)
			{
				this.HBJJOCHGOPH = 800f;
			}
			this.NBPKMLMCHFN.SetFloat("NEW_ACHIEVEMENT_1_", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("maps.", (float)this.Level);
			this.HNICHJCGJOC().SetVector("AddEnvironmentSprite", this.Distance);
			this.GCDFNHMJMIP().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 288f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CA8 RID: 7336 RVA: 0x000AF6FD File Offset: 0x000AD8FD
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Regular");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001CA9 RID: 7337 RVA: 0x000AF721 File Offset: 0x000AD921
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CAA RID: 7338 RVA: 0x000AF758 File Offset: 0x000AD958
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CAB RID: 7339 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x000AF78F File Offset: 0x000AD98F
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001CAD RID: 7341 RVA: 0x000AF7B4 File Offset: 0x000AD9B4
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
			this.NBPKMLMCHFN.SetFloat("_Level", (float)this.Level);
			this.NBPKMLMCHFN.SetVector("_Distance", this.Distance);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CB0 RID: 7344 RVA: 0x000AF8BC File Offset: 0x000ADABC
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_BaseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001CB1 RID: 7345 RVA: 0x000AF8E0 File Offset: 0x000ADAE0
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001CB2 RID: 7346 RVA: 0x000AF904 File Offset: 0x000ADB04
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001CB3 RID: 7347 RVA: 0x000AF928 File Offset: 0x000ADB28
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 810f)
			{
				this.HBJJOCHGOPH = 751f;
			}
			this.HNICHJCGJOC().SetFloat("[Right]", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_NeighbourMaxTex", (float)this.Level);
			this.GCDFNHMJMIP().SetVector("_ScreenResolution", this.Distance);
			this.GCDFNHMJMIP().SetVector("_Parasite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1263f, 1244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x000AFA01 File Offset: 0x000ADC01
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

	// Token: 0x06001CB5 RID: 7349 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001CB7 RID: 7351 RVA: 0x000AFA38 File Offset: 0x000ADC38
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("&");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06001CB9 RID: 7353 RVA: 0x000AF4F4 File Offset: 0x000AD6F4
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040003E3 RID: 995
	public Shader SCShader;

	// Token: 0x040003E4 RID: 996
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003E5 RID: 997
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003E6 RID: 998
	private Material BJFKDHHMLJH;

	// Token: 0x040003E7 RID: 999
	[Range(1f, 16f)]
	public int Level = 4;

	// Token: 0x040003E8 RID: 1000
	public Vector2 Distance = new Vector2(30f, 0f);
}
