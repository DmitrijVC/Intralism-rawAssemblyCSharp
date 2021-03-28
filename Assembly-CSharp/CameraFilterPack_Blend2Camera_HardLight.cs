using System;
using UnityEngine;

// Token: 0x02000045 RID: 69
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/HardLight")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_HardLight : MonoBehaviour
{
	// Token: 0x0600130D RID: 4877 RVA: 0x0007FB7C File Offset: 0x0007DD7C
	private void MMOKKAPFGAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x0007FBE5 File Offset: 0x0007DDE5
	private void PHJLHCMCCKE()
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

	// Token: 0x0600130F RID: 4879 RVA: 0x0007FC1F File Offset: 0x0007DE1F
	private void OCHMKJKBAPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x0007FC5A File Offset: 0x0007DE5A
	private void PDILBLLIPFJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -65);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x0007FC98 File Offset: 0x0007DE98
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 101f)
			{
				this.HBJJOCHGOPH = 350f;
			}
			if (this.Camera2 != null)
			{
				this.LENEJAGLCNL().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.HCGJCMDJPGD().SetFloat("OnAwakeRPC", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("skin.hit_normal", this.BlendFX);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.SwitchCameraToCamera2);
			this.FLOHGDECHHH().SetVector("ItemsCountText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 572f, 550f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x0007FD92 File Offset: 0x0007DF92
	private void GPJHPNGNEBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -84);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0007FDD0 File Offset: 0x0007DFD0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1953f)
			{
				this.HBJJOCHGOPH = 872f;
			}
			if (this.Camera2 != null)
			{
				this.KBOPGONOCNP().SetTexture("[LocalizationService] Localization: ", this.JDMCFBKJHDD);
			}
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/TV_ARCADE_Fast", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_MainTex2", this.BlendFX);
			this.EJDPNJAEAKJ().SetFloat("Uploading content", this.SwitchCameraToCamera2);
			this.DNLMFEGJJDD().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1013f, 1884f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0007FECA File Offset: 0x0007E0CA
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x0007FBE5 File Offset: 0x0007DDE5
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

	// Token: 0x06001319 RID: 4889 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x0007FF04 File Offset: 0x0007E104
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 134f)
			{
				this.HBJJOCHGOPH = 1286f;
			}
			if (this.Camera2 != null)
			{
				this.DNLMFEGJJDD().SetTexture("settings.enableranking", this.JDMCFBKJHDD);
			}
			this.EJDPNJAEAKJ().SetFloat("HitInRelaxMusicToggle", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/FX_Drunk2", this.BlendFX);
			this.BFGNMFCNDBC().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", this.SwitchCameraToCamera2);
			this.GKILCDHJFEG().SetVector("RedoButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 660f, 1652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x0007FBE5 File Offset: 0x0007DDE5
	private void FKEJGBFDCAH()
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

	// Token: 0x0600131C RID: 4892 RVA: 0x0007FBE5 File Offset: 0x0007DDE5
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

	// Token: 0x0600131D RID: 4893 RVA: 0x00080000 File Offset: 0x0007E200
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

	// Token: 0x0600131E RID: 4894 RVA: 0x0007FBE5 File Offset: 0x0007DDE5
	private void ODGMCJILIHF()
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

	// Token: 0x0600131F RID: 4895 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x000800FA File Offset: 0x0007E2FA
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06001321 RID: 4897 RVA: 0x00080131 File Offset: 0x0007E331
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

	// Token: 0x06001322 RID: 4898 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00080168 File Offset: 0x0007E368
	private void FINDGJLEHOL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -33);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x000801A4 File Offset: 0x0007E3A4
	private void CIPKEPDELJB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0008020D File Offset: 0x0007E40D
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00080244 File Offset: 0x0007E444
	private void HLIAEEMGBHN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x000802AD File Offset: 0x0007E4AD
	private void PCGODOELOHG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x000802E8 File Offset: 0x0007E4E8
	private void GNDNNEKPGCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00080323 File Offset: 0x0007E523
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00080387 File Offset: 0x0007E587
	private void JBAPHFIBANG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x000803C4 File Offset: 0x0007E5C4
	private void JKFDDNMPOJH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -4);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x0008042D File Offset: 0x0007E62D
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x00080464 File Offset: 0x0007E664
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x000804A0 File Offset: 0x0007E6A0
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1907f)
			{
				this.HBJJOCHGOPH = 1869f;
			}
			if (this.Camera2 != null)
			{
				this.EPCGJFCCAFH().SetTexture("_NeighborMaxTex", this.JDMCFBKJHDD);
			}
			this.EPCGJFCCAFH().SetFloat(" : ", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("0", this.BlendFX);
			this.KBOPGONOCNP().SetFloat("menutheme.letitbe", this.SwitchCameraToCamera2);
			this.LENEJAGLCNL().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1945f, 1528f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x0008059C File Offset: 0x0007E79C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 904f)
			{
				this.HBJJOCHGOPH = 645f;
			}
			if (this.Camera2 != null)
			{
				this.EJDPNJAEAKJ().SetTexture("HiddenToggle", this.JDMCFBKJHDD);
			}
			this.JFDGLLEOPGB().SetFloat("_DepthLevel", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("|", this.BlendFX);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.LENEJAGLCNL().SetVector("RequestForPickupItems", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 887f, 1090f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00080696 File Offset: 0x0007E896
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x0007FBE5 File Offset: 0x0007DDE5
	private void JHLGHODFJOO()
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

	// Token: 0x06001333 RID: 4915 RVA: 0x000806D0 File Offset: 0x0007E8D0
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1641f)
			{
				this.HBJJOCHGOPH = 206f;
			}
			if (this.Camera2 != null)
			{
				this.KBOPGONOCNP().SetTexture("HiddenToggle", this.JDMCFBKJHDD);
			}
			this.KBOPGONOCNP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Hello", this.BlendFX);
			this.BFGNMFCNDBC().SetFloat("menu.tabid", this.SwitchCameraToCamera2);
			this.JIBOKBCPDLC().SetVector("/512px-512px.png", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1613f, 153f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x000807CA File Offset: 0x0007E9CA
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00080801 File Offset: 0x0007EA01
	private void MIAMLFNACAI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x0008083C File Offset: 0x0007EA3C
	private void BGDPIHMAACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -98);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x000808A5 File Offset: 0x0007EAA5
	private void BNIIBNCLHFA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -15);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x000808E0 File Offset: 0x0007EAE0
	private void NBGIMIDICKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x00080949 File Offset: 0x0007EB49
	private void BFKANNFLAKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00080984 File Offset: 0x0007EB84
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1407f)
			{
				this.HBJJOCHGOPH = 552f;
			}
			if (this.Camera2 != null)
			{
				this.LENEJAGLCNL().SetTexture("CameraFilterPack/Blend2Camera_Difference", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat("0", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("ResourceFileSelector", this.BlendFX);
			this.BFGNMFCNDBC().SetFloat("_BlurDirectionPacked", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("inventory.selected.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 269f, 1738f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00080A7E File Offset: 0x0007EC7E
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x00080AB8 File Offset: 0x0007ECB8
	private void EGEPLFGKGLI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x00080B24 File Offset: 0x0007ED24
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

	// Token: 0x06001340 RID: 4928 RVA: 0x00080B8D File Offset: 0x0007ED8D
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00080BC4 File Offset: 0x0007EDC4
	private void POIFMMFPELA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x00080BFF File Offset: 0x0007EDFF
	private void IFBPAGFGDGD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 90);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x00080C3C File Offset: 0x0007EE3C
	private void KMCPMOGKDEH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -128);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00080CA5 File Offset: 0x0007EEA5
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00080CDC File Offset: 0x0007EEDC
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00080D14 File Offset: 0x0007EF14
	private void JKBMKPDGCHG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 98);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00080D7D File Offset: 0x0007EF7D
	private void OEAMLMGNFFC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00080DB8 File Offset: 0x0007EFB8
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 607f;
			}
			if (this.Camera2 != null)
			{
				this.HCGJCMDJPGD().SetTexture("unsubscribemap", this.JDMCFBKJHDD);
			}
			this.LENEJAGLCNL().SetFloat("HightScoreMaxPointsText", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", this.BlendFX);
			this.LENEJAGLCNL().SetFloat("_FixDistance", this.SwitchCameraToCamera2);
			this.KBOPGONOCNP().SetVector("[NetworkManager] Updating current room...", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1811f, 623f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00080EB2 File Offset: 0x0007F0B2
	private void GFLAINNLMBO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00080EF0 File Offset: 0x0007F0F0
	private void PKLOBJHKFEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00080F59 File Offset: 0x0007F159
	private void IDKPHKOCOLD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x00080F94 File Offset: 0x0007F194
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1394f)
			{
				this.HBJJOCHGOPH = 917f;
			}
			if (this.Camera2 != null)
			{
				this.EJDPNJAEAKJ().SetTexture("_EdgeSize", this.JDMCFBKJHDD);
			}
			this.FLOHGDECHHH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("selector", this.BlendFX);
			this.FLOHGDECHHH().SetFloat("_Red_B", this.SwitchCameraToCamera2);
			this.JFDGLLEOPGB().SetVector("The image effect ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 773f, 1616f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x00081090 File Offset: 0x0007F290
	private void NNCCPEBIAKH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x000810F9 File Offset: 0x0007F2F9
	private void KKDDHFJOAAD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -87);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x00081134 File Offset: 0x0007F334
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x0008116C File Offset: 0x0007F36C
	private void JHANGPCOCIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -86);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x000811D5 File Offset: 0x0007F3D5
	private void AONJNAGNLIH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -18);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x00081210 File Offset: 0x0007F410
	private void GFOOJOMCCBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x0008124C File Offset: 0x0007F44C
	private void FMNPFCHBLJF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x000812B5 File Offset: 0x0007F4B5
	private void CMBGFMAOEPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00080464 File Offset: 0x0007E664
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x000812F0 File Offset: 0x0007F4F0
	private void FANADGBGCPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 43);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040002B2 RID: 690
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardLight";

	// Token: 0x040002B3 RID: 691
	public Shader SCShader;

	// Token: 0x040002B4 RID: 692
	public Camera Camera2;

	// Token: 0x040002B5 RID: 693
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002B6 RID: 694
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002B7 RID: 695
	private Material BJFKDHHMLJH;

	// Token: 0x040002B8 RID: 696
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002B9 RID: 697
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002BA RID: 698
	private RenderTexture JDMCFBKJHDD;
}
