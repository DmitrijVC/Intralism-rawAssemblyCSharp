using System;
using UnityEngine;

// Token: 0x02000038 RID: 56
[AddComponentMenu("Camera Filter Pack/Pixel/Snow_8bits")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Snow_8bits : MonoBehaviour
{
	// Token: 0x06000EE8 RID: 3816 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0006A510 File Offset: 0x00068710
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 911f)
			{
				this.HBJJOCHGOPH = 1319f;
			}
			this.OIMMPLPBLBK().SetFloat("_ReflectionTexture4", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("Default UI Material", this.Threshold);
			this.OKJOKHGJHGF().SetFloat(" ", this.Size);
			this.EOCCJGIGEGJ().SetFloat("_Value", this.DirectionX);
			this.EOCCJGIGEGJ().SetFloat("Left Stick Click", this.Fade);
			this.PDEAHJPOMEF().SetVector("UndoButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 637f, 918f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x0006A60F File Offset: 0x0006880F
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x0006A60F File Offset: 0x0006880F
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x0006A62C File Offset: 0x0006882C
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 230f)
			{
				this.HBJJOCHGOPH = 6f;
			}
			this.MCDGIILBNIF().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("menu.hardcoreinfo", this.Threshold);
			this.MCDGIILBNIF().SetFloat("float,10", this.Size);
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.DirectionX);
			this.BFGNMFCNDBC().SetFloat("menu.selectedlevelid", this.Fade);
			this.MICHFGAOPKM().SetVector("bool", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 927f, 1534f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x0006A72B File Offset: 0x0006892B
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("player.bluebat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x0006A750 File Offset: 0x00068950
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 449f)
			{
				this.HBJJOCHGOPH = 1702f;
			}
			this.GCDFNHMJMIP().SetFloat("Uploading content", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("<size=24>", this.Threshold);
			this.KGOLDDBHIFN().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Size);
			this.BFGNMFCNDBC().SetFloat("Added GameObject to prefabDictionary: ", this.DirectionX);
			this.OIMMPLPBLBK().SetFloat("HandsCountSlider", this.Fade);
			this.NFMGLIKNOOC().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 158f, 909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x0006A84F File Offset: 0x00068A4F
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0006A886 File Offset: 0x00068A86
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("Populate Mesh Data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0006A8AA File Offset: 0x00068AAA
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x0006A8E4 File Offset: 0x00068AE4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x0006A9E4 File Offset: 0x00068BE4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1521f)
			{
				this.HBJJOCHGOPH = 248f;
			}
			this.EOCCJGIGEGJ().SetFloat("GlassesColor2", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("New SaveGame", this.Threshold);
			this.MCDGIILBNIF().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", this.Size);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.DirectionX);
			this.NFMGLIKNOOC().SetFloat("EventData0DropDownList", this.Fade);
			this.ADBKPGFMNKO().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 205f, 32f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x0006A60F File Offset: 0x0006880F
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x0006AAE3 File Offset: 0x00068CE3
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x0006AB1A File Offset: 0x00068D1A
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x0006AB3E File Offset: 0x00068D3E
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x0006AB62 File Offset: 0x00068D62
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x0006AB99 File Offset: 0x00068D99
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x0006A60F File Offset: 0x0006880F
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x0006A60F File Offset: 0x0006880F
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x0006ABD0 File Offset: 0x00068DD0
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x0006AC07 File Offset: 0x00068E07
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0006AC3E File Offset: 0x00068E3E
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

	// Token: 0x06000F03 RID: 3843 RVA: 0x0006A60F File Offset: 0x0006880F
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x0006A60F File Offset: 0x0006880F
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x0006AC78 File Offset: 0x00068E78
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 1653f;
			}
			this.ADBKPGFMNKO().SetFloat("IEnumerable", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.Threshold);
			this.OIMMPLPBLBK().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.Size);
			this.DBOLLHHMKKN().SetFloat("[RanksSystem] Ranks: no need to update", this.DirectionX);
			this.OIMMPLPBLBK().SetFloat("challenges.", this.Fade);
			this.OKJOKHGJHGF().SetVector(" [", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1495f, 1818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0006A60F File Offset: 0x0006880F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x0006A60F File Offset: 0x0006880F
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x0006AD77 File Offset: 0x00068F77
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x0006ADB0 File Offset: 0x00068FB0
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 698f)
			{
				this.HBJJOCHGOPH = 433f;
			}
			this.EOCCJGIGEGJ().SetFloat("MouseX", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("MenuScene", this.Threshold);
			this.GJHLADDCMFF().SetFloat("_Level", this.Size);
			this.GCDFNHMJMIP().SetFloat("_ScreenResolution", this.DirectionX);
			this.NFMGLIKNOOC().SetFloat("_Shadow", this.Fade);
			this.BFGNMFCNDBC().SetVector("CountEventsGoal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1062f, 1609f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x0006A60F File Offset: 0x0006880F
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x0006A60F File Offset: 0x0006880F
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x0006A60F File Offset: 0x0006880F
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x0006AEAF File Offset: 0x000690AF
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("MissesText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x0006AED3 File Offset: 0x000690D3
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x0006AF0A File Offset: 0x0006910A
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x0006AF30 File Offset: 0x00069130
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 835f)
			{
				this.HBJJOCHGOPH = 1017f;
			}
			this.BFGNMFCNDBC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("--------------------------------", this.Threshold);
			this.MCDGIILBNIF().SetFloat("MultiplayerButton", this.Size);
			this.ADBKPGFMNKO().SetFloat("_BokehParams", this.DirectionX);
			this.BFGNMFCNDBC().SetFloat("Fade", this.Fade);
			this.PDEAHJPOMEF().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 692f, 529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x0006B02F File Offset: 0x0006922F
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x0006B066 File Offset: 0x00069266
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Snow_8bits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x0006A60F File Offset: 0x0006880F
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x0006B08A File Offset: 0x0006928A
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("<color=#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0006B0AE File Offset: 0x000692AE
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("UseScanLineSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x0006B0D4 File Offset: 0x000692D4
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1580f)
			{
				this.HBJJOCHGOPH = 428f;
			}
			this.OKJOKHGJHGF().SetFloat("intensity", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("[PlayerBase] Loaded music", this.Threshold);
			this.BFGNMFCNDBC().SetFloat("#,0", this.Size);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_3D_Myst1", this.DirectionX);
			this.EOCCJGIGEGJ().SetFloat("_Red_B", this.Fade);
			this.BFGNMFCNDBC().SetVector("LastHighScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1849f, 732f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0006B1D3 File Offset: 0x000693D3
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0006B20A File Offset: 0x0006940A
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x0006A60F File Offset: 0x0006880F
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x0006A60F File Offset: 0x0006880F
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0006B22E File Offset: 0x0006942E
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0006A60F File Offset: 0x0006880F
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x0006B268 File Offset: 0x00069468
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1561f)
			{
				this.HBJJOCHGOPH = 153f;
			}
			this.FLOHGDECHHH().SetFloat("_Blue_C", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("settings_bindings_sec_", this.Threshold);
			this.ADBKPGFMNKO().SetFloat("tagElement", this.Size);
			this.NFMGLIKNOOC().SetFloat("LevelInfoInputField", this.DirectionX);
			this.ADBKPGFMNKO().SetFloat("GlassAberration", this.Fade);
			this.OIMMPLPBLBK().SetVector("VoteUpToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1806f, 1564f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x0006B367 File Offset: 0x00069567
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("Remove Environment Object");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x0006B3BF File Offset: 0x000695BF
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x0006A60F File Offset: 0x0006880F
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0006B3F6 File Offset: 0x000695F6
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0006B42D File Offset: 0x0006962D
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0006B451 File Offset: 0x00069651
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[NetworkManager] Connecting...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0006B478 File Offset: 0x00069678
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1927f)
			{
				this.HBJJOCHGOPH = 798f;
			}
			this.MICHFGAOPKM().SetFloat("y", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("3;4;9;10;21x6", this.Threshold);
			this.KGOLDDBHIFN().SetFloat("X2", this.Size);
			this.FLOHGDECHHH().SetFloat("_Value1", this.DirectionX);
			this.FLOHGDECHHH().SetFloat("plainText", this.Fade);
			this.MICHFGAOPKM().SetVector("mapid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 388f, 1653f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x0006B577 File Offset: 0x00069777
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400022F RID: 559
	public Shader SCShader;

	// Token: 0x04000230 RID: 560
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000231 RID: 561
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000232 RID: 562
	private Material BJFKDHHMLJH;

	// Token: 0x04000233 RID: 563
	[Range(0.9f, 2f)]
	public float Threshold = 1f;

	// Token: 0x04000234 RID: 564
	[Range(8f, 256f)]
	public float Size = 64f;

	// Token: 0x04000235 RID: 565
	[Range(-0.5f, 0.5f)]
	public float DirectionX;

	// Token: 0x04000236 RID: 566
	[Range(0f, 1f)]
	public float Fade = 1f;
}
