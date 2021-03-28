using System;
using UnityEngine;

// Token: 0x02000058 RID: 88
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Subtract")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Subtract : MonoBehaviour
{
	// Token: 0x060018CA RID: 6346 RVA: 0x0009E2DF File Offset: 0x0009C4DF
	private void OOBIMFILNED()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -112);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x0009E31C File Offset: 0x0009C51C
	private void HDMDKOKOOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -45);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x0009E385 File Offset: 0x0009C585
	private void BDBKIEIIFPB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x0009E3C0 File Offset: 0x0009C5C0
	private void MLAGEPNCCGM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x0009E3FB File Offset: 0x0009C5FB
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x0009E432 File Offset: 0x0009C632
	private void GNDNNEKPGCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -21);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x0009E46D File Offset: 0x0009C66D
	private void HFLHDMPHOJA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void DPFOEBCADNP()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void JOJFHFHOCHO()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x0009E4E4 File Offset: 0x0009C6E4
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 571f)
			{
				this.HBJJOCHGOPH = 1691f;
			}
			if (this.Camera2 != null)
			{
				this.IGKFMCPDNOI().SetTexture("\" call.", this.JDMCFBKJHDD);
			}
			this.IGKFMCPDNOI().SetFloat("_Value1", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_Value3", this.BlendFX);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/Drawing_BluePrint", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("source", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1702f, 60f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x0009E5DE File Offset: 0x0009C7DE
	private void LIFBFDKFMMH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x0009E619 File Offset: 0x0009C819
	private void LONLHFLPEJD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -73);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x0009E654 File Offset: 0x0009C854
	private void ELANJOHIJME()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -78);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x0009E68F File Offset: 0x0009C88F
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x0009E6CA File Offset: 0x0009C8CA
	private void HGIMCCHIPCP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x0009E708 File Offset: 0x0009C908
	private void OHFOLGANOLC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x0009E3C0 File Offset: 0x0009C5C0
	private void DBGBCCBHBBC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x0009E774 File Offset: 0x0009C974
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 77f)
			{
				this.HBJJOCHGOPH = 949f;
			}
			if (this.Camera2 != null)
			{
				this.NJDIODJNGGA().SetTexture("BloomShaderValueSlider", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("settings.arcsnohitsoundtimedelay", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_Value1", this.BlendFX);
			this.NJDIODJNGGA().SetFloat("#ok", this.SwitchCameraToCamera2);
			this.GKILCDHJFEG().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1088f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x0009E870 File Offset: 0x0009CA70
	private void CGDMLHLJIDK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x0009E8D9 File Offset: 0x0009CAD9
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x0009E910 File Offset: 0x0009CB10
	private void NNONKGKCKKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -72);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x0009E94B File Offset: 0x0009CB4B
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x0009E986 File Offset: 0x0009CB86
	private void CBKHALIFIAN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 64);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x0009E9C1 File Offset: 0x0009CBC1
	private void EBBOJPEPDCN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -80);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018E4 RID: 6372 RVA: 0x0009E9FC File Offset: 0x0009CBFC
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x0009EA65 File Offset: 0x0009CC65
	private void MPADDMNGJNC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x0009EAA0 File Offset: 0x0009CCA0
	private void JOPCCCCHNLI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 94);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x0009EB0C File Offset: 0x0009CD0C
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x0009EC06 File Offset: 0x0009CE06
	private void DGEPPDJDBLN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 1);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x0009EC41 File Offset: 0x0009CE41
	private void IBEAPBDAOCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x0009EC7C File Offset: 0x0009CE7C
	private void KCCIEMBMOBA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 115);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x0009ECE5 File Offset: 0x0009CEE5
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x0009ED1C File Offset: 0x0009CF1C
	private void MEMKLOMFFJO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 3);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060018EF RID: 6383 RVA: 0x0009ED57 File Offset: 0x0009CF57
	private void OAKONCDEPPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void HGDDCINLDAD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060018F1 RID: 6385 RVA: 0x0009ED94 File Offset: 0x0009CF94
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018F2 RID: 6386 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void NAALCEPIHCH()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void FGOPJMGNHGO()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x0009EDFD File Offset: 0x0009CFFD
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x0009E385 File Offset: 0x0009C585
	private void MCKOAMFEDGL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x0009EE34 File Offset: 0x0009D034
	private void OCHMKJKBAPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -56);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void FDPOFMCFBMF()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x0009EE6F File Offset: 0x0009D06F
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x0009EEA8 File Offset: 0x0009D0A8
	private void MMMDPANNAIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -128);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x0009EF11 File Offset: 0x0009D111
	private void IDIEBLNAEIF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x0009EF4C File Offset: 0x0009D14C
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1104f)
			{
				this.HBJJOCHGOPH = 1954f;
			}
			if (this.Camera2 != null)
			{
				this.LPMLLJKMAMP().SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.IGKFMCPDNOI().SetFloat("Electronic", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("Deleted event", this.BlendFX);
			this.IGKFMCPDNOI().SetFloat(": ", this.SwitchCameraToCamera2);
			this.IGKFMCPDNOI().SetVector("GetGameList failed: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1853f, 1722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x0009F046 File Offset: 0x0009D246
	private void AAPKKMKDOFO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 25);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060018FD RID: 6397 RVA: 0x0009F081 File Offset: 0x0009D281
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

	// Token: 0x060018FE RID: 6398 RVA: 0x0009F0B8 File Offset: 0x0009D2B8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 865f)
			{
				this.HBJJOCHGOPH = 1920f;
			}
			if (this.Camera2 != null)
			{
				this.GKILCDHJFEG().SetTexture("true", this.JDMCFBKJHDD);
			}
			this.CEKJODEAMGB().SetFloat("Image_", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("player.quantum", this.BlendFX);
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this.SwitchCameraToCamera2);
			this.GKILCDHJFEG().SetVector("OK", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 818f, 1333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x0009F1B2 File Offset: 0x0009D3B2
	private void ENDDDMALLBK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 106);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void CCPEDDLAMIB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x0009F1ED File Offset: 0x0009D3ED
	private void OLCOOJIONIL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -65);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void EKCKJLFFAID()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x0009F228 File Offset: 0x0009D428
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x0009F260 File Offset: 0x0009D460
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 180f)
			{
				this.HBJJOCHGOPH = 895f;
			}
			if (this.Camera2 != null)
			{
				this.GKILCDHJFEG().SetTexture(". No ViewIDs are free to use. Max is: ", this.JDMCFBKJHDD);
			}
			this.CEKJODEAMGB().SetFloat("--------------------------------", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("Fade", this.BlendFX);
			this.EFDEIFCDAFG().SetFloat("BloodAlternative2", this.SwitchCameraToCamera2);
			this.NJDIODJNGGA().SetVector("menutheme.coldheat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 224f, 424f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x0009F35C File Offset: 0x0009D55C
	private void PDHKMDBNGGN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 44);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x0009F3C8 File Offset: 0x0009D5C8
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1223f)
			{
				this.HBJJOCHGOPH = 151f;
			}
			if (this.Camera2 != null)
			{
				this.GKILCDHJFEG().SetTexture("DestroyRpc", this.JDMCFBKJHDD);
			}
			this.NJDIODJNGGA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("menu.playedsolo", this.BlendFX);
			this.IGKFMCPDNOI().SetFloat(".highscore", this.SwitchCameraToCamera2);
			this.EFDEIFCDAFG().SetVector("Copy from ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 786f, 533f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x0600190C RID: 6412 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x0009F4C4 File Offset: 0x0009D6C4
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 27f)
			{
				this.HBJJOCHGOPH = 1436f;
			}
			if (this.Camera2 != null)
			{
				this.GKILCDHJFEG().SetTexture("_VignetteBlur", this.JDMCFBKJHDD);
			}
			this.NJDIODJNGGA().SetFloat("id", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("#,0", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("LevelURLInputField", this.SwitchCameraToCamera2);
			this.IGKFMCPDNOI().SetVector("[MapEditor] Item creation successful! Published Item ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1534f, 200f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x0009F5E8 File Offset: 0x0009D7E8
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1754f)
			{
				this.HBJJOCHGOPH = 516f;
			}
			if (this.Camera2 != null)
			{
				this.IGKFMCPDNOI().SetTexture("set", this.JDMCFBKJHDD);
			}
			this.NJDIODJNGGA().SetFloat("CameraFilterPack/Colors_Adjust_FullColors", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("/", this.BlendFX);
			this.LPMLLJKMAMP().SetFloat("/", this.SwitchCameraToCamera2);
			this.GKILCDHJFEG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 79f, 1726f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x0009F6E2 File Offset: 0x0009D8E2
	private void INGOODALACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x0009F71D File Offset: 0x0009D91D
	private void BLDMINMDHPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x0009EE6F File Offset: 0x0009D06F
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x0009F758 File Offset: 0x0009D958
	private void OKLAJINHPAN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -67);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x0009F7C4 File Offset: 0x0009D9C4
	private void EPEGAEGDJAM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x0009F830 File Offset: 0x0009DA30
	private void EFJDNLGNACH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -60);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x0009F899 File Offset: 0x0009DA99
	private void FINDGJLEHOL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 6);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x0009E6CA File Offset: 0x0009C8CA
	private void JHBPINEKDPE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x0009F8D4 File Offset: 0x0009DAD4
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 104f)
			{
				this.HBJJOCHGOPH = 319f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("#orderby:", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_Near", this.BlendFX);
			this.GKILCDHJFEG().SetFloat(".lastCheckpoint.powerupsScore", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1432f, 1932f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x0009E4A8 File Offset: 0x0009C6A8
	private void LOMDIOLNFHI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x0009E94B File Offset: 0x0009CB4B
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x0009F9D0 File Offset: 0x0009DBD0
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 177f)
			{
				this.HBJJOCHGOPH = 1915f;
			}
			if (this.Camera2 != null)
			{
				this.NJDIODJNGGA().SetTexture("StartCanvas", this.JDMCFBKJHDD);
			}
			this.EFDEIFCDAFG().SetFloat("materialsitemid[", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("Editor", this.BlendFX);
			this.IGKFMCPDNOI().SetFloat("Anime", this.SwitchCameraToCamera2);
			this.IGKFMCPDNOI().SetVector("_Visualize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 750f, 1356f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x0009F1B2 File Offset: 0x0009D3B2
	private void KDBKBPCIHBL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 106);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x0400037D RID: 893
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Subtract";

	// Token: 0x0400037E RID: 894
	public Shader SCShader;

	// Token: 0x0400037F RID: 895
	public Camera Camera2;

	// Token: 0x04000380 RID: 896
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000381 RID: 897
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000382 RID: 898
	private Material BJFKDHHMLJH;

	// Token: 0x04000383 RID: 899
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000384 RID: 900
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000385 RID: 901
	private RenderTexture JDMCFBKJHDD;
}
