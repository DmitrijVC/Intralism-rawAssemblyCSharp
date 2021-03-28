using System;
using UnityEngine;

// Token: 0x02000062 RID: 98
[AddComponentMenu("Camera Filter Pack/Blur/Movie")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Movie : MonoBehaviour
{
	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06001B4C RID: 6988 RVA: 0x000A93C3 File Offset: 0x000A75C3
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

	// Token: 0x06001B4D RID: 6989 RVA: 0x000A93FA File Offset: 0x000A75FA
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Movie");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x000A9420 File Offset: 0x000A7620
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 303f)
			{
				this.HBJJOCHGOPH = 1464f;
			}
			this.LONNIJMNKFB().SetFloat("_Fade", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("#exit", this.Radius / (float)fastFilter);
			this.DBOLLHHMKKN().SetFloat("LoadingStatusText", this.Factor);
			this.DOHGBNPMBKG().SetVector("ShowSprite", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN());
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

	// Token: 0x06001B4F RID: 6991 RVA: 0x000A9540 File Offset: 0x000A7740
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x000A9577 File Offset: 0x000A7777
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x000A959C File Offset: 0x000A779C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1447f)
			{
				this.HBJJOCHGOPH = 1011f;
			}
			this.JIBOKBCPDLC().SetFloat("GlassDistortion", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("[EMPTY]", this.Radius / (float)fastFilter);
			this.JIBOKBCPDLC().SetFloat(" Mb", this.Factor);
			this.DBOLLHHMKKN().SetVector("settings.hitvariation", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x000A96BC File Offset: 0x000A78BC
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_ToPrevViewProjCombined");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x000A96E0 File Offset: 0x000A78E0
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x000A9718 File Offset: 0x000A7918
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1474f)
			{
				this.HBJJOCHGOPH = 991f;
			}
			this.EPCGJFCCAFH().SetFloat("_Size", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_History1LumaTex", this.Radius / (float)fastFilter);
			this.FAIFBBGFAIB().SetFloat("Print the list of scenes, avalable in game.", this.Factor);
			this.DOHGBNPMBKG().SetVector("workshop.", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x000A9838 File Offset: 0x000A7A38
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1028f)
			{
				this.HBJJOCHGOPH = 1726f;
			}
			this.DOHGBNPMBKG().SetFloat("sfxVolume", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_Color", this.Radius / (float)fastFilter);
			this.DBOLLHHMKKN().SetFloat("_Value", this.Factor);
			this.DBOLLHHMKKN().SetVector("My New Mod Pack", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x000A9958 File Offset: 0x000A7B58
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("resource");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x000A99C9 File Offset: 0x000A7BC9
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("_RangeScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x000A99F0 File Offset: 0x000A7BF0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1358f)
			{
				this.HBJJOCHGOPH = 1486f;
			}
			this.NBPKMLMCHFN.SetFloat("settings_bindings_controller_type", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_Noise", this.Radius / (float)fastFilter);
			this.DOHGBNPMBKG().SetFloat("_MainTex2", this.Factor);
			this.DBOLLHHMKKN().SetVector("_Value4", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x000A9B10 File Offset: 0x000A7D10
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1397f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			this.DBOLLHHMKKN().SetFloat("_Threshhold", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("MapEnd", this.Radius / (float)fastFilter);
			this.FAIFBBGFAIB().SetFloat("[PlayerBase] Saveing checkpoint data", this.Factor);
			this.AELJLBOJAIL().SetVector("_TimeX", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, this.JIBOKBCPDLC());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x000A9C30 File Offset: 0x000A7E30
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x000A9C54 File Offset: 0x000A7E54
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1596f)
			{
				this.HBJJOCHGOPH = 386f;
			}
			this.NBPKMLMCHFN.SetFloat("Lerp speed. Recomended 10", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat(".", this.Radius / (float)fastFilter);
			this.EPCGJFCCAFH().SetFloat("float,10", this.Factor);
			this.DOHGBNPMBKG().SetVector("Editor/", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, this.AELJLBOJAIL());
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

	// Token: 0x06001B64 RID: 7012 RVA: 0x000A9D74 File Offset: 0x000A7F74
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x000A9DAB File Offset: 0x000A7FAB
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x000A9DE2 File Offset: 0x000A7FE2
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x000A9E08 File Offset: 0x000A8008
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
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Radius / (float)fastFilter);
			this.NBPKMLMCHFN.SetFloat("_Factor", this.Factor);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
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

	// Token: 0x06001B68 RID: 7016 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x000A9F28 File Offset: 0x000A8128
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1606f)
			{
				this.HBJJOCHGOPH = 1804f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("0.00", this.Radius / (float)fastFilter);
			this.AELJLBOJAIL().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.Factor);
			this.JIBOKBCPDLC().SetVector(".", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, this.AELJLBOJAIL());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B6C RID: 7020 RVA: 0x000AA048 File Offset: 0x000A8248
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 74f)
			{
				this.HBJJOCHGOPH = 719f;
			}
			this.AELJLBOJAIL().SetFloat("difficulty", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Finished", this.Radius / (float)fastFilter);
			this.DOHGBNPMBKG().SetFloat("HH:mm:ss", this.Factor);
			this.DBOLLHHMKKN().SetVector("_TimeX", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(AAACLELCPML, temporary, this.AELJLBOJAIL());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B6D RID: 7021 RVA: 0x000AA168 File Offset: 0x000A8368
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1993f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("[MapEditor] Loading music...", this.Radius / (float)fastFilter);
			this.EPCGJFCCAFH().SetFloat("0,2,true,0", this.Factor);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, this.FAIFBBGFAIB());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x000AA288 File Offset: 0x000A8488
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 327f)
			{
				this.HBJJOCHGOPH = 1267f;
			}
			this.NBPKMLMCHFN.SetFloat("Texture2", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat(" Loaded: ", this.Radius / (float)fastFilter);
			this.AELJLBOJAIL().SetFloat("float,1.5", this.Factor);
			this.DBOLLHHMKKN().SetVector("_DiffuseColor", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(AAACLELCPML, temporary, this.DOHGBNPMBKG());
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

	// Token: 0x06001B70 RID: 7024 RVA: 0x000AA3A8 File Offset: 0x000A85A8
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x000AA3DF File Offset: 0x000A85DF
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x000A99AC File Offset: 0x000A7BAC
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x000AA416 File Offset: 0x000A8616
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040003C6 RID: 966
	public Shader SCShader;

	// Token: 0x040003C7 RID: 967
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003C8 RID: 968
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003C9 RID: 969
	private Material BJFKDHHMLJH;

	// Token: 0x040003CA RID: 970
	[Range(0f, 1000f)]
	public float Radius = 150f;

	// Token: 0x040003CB RID: 971
	[Range(0f, 1000f)]
	public float Factor = 200f;

	// Token: 0x040003CC RID: 972
	[Range(1f, 8f)]
	public int FastFilter = 2;
}
