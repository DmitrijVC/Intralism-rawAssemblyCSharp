using System;
using UnityEngine;

// Token: 0x02000055 RID: 85
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/SoftLight")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_SoftLight : MonoBehaviour
{
	// Token: 0x060017AA RID: 6058 RVA: 0x00098B71 File Offset: 0x00096D71
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x00098BA8 File Offset: 0x00096DA8
	private void LOOGLMFBJHK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void FJIKDJAMOHA()
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

	// Token: 0x060017AD RID: 6061 RVA: 0x00098C1D File Offset: 0x00096E1D
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void LECCHIAFGGE()
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

	// Token: 0x060017AF RID: 6063 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00098C54 File Offset: 0x00096E54
	private void AGEJKLMJGDO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -112);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00098CBD File Offset: 0x00096EBD
	private void IDKPHKOCOLD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00098CF8 File Offset: 0x00096EF8
	private void FGIOPGGPLMB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00098D34 File Offset: 0x00096F34
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 990f)
			{
				this.HBJJOCHGOPH = 624f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_Size", this.JDMCFBKJHDD);
			}
			this.LNLKMDPHDCC().SetFloat(": ", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("_Visualize", this.BlendFX);
			this.EFDEIFCDAFG().SetFloat("_ChannelMixerBlue", this.SwitchCameraToCamera2);
			this.EFDEIFCDAFG().SetVector("907198288", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1957f, 988f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00098E57 File Offset: 0x00097057
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00098E90 File Offset: 0x00097090
	private void CIPKEPDELJB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00098EF9 File Offset: 0x000970F9
	private void MPADDMNGJNC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 66);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x00098F34 File Offset: 0x00097134
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00098F6B File Offset: 0x0009716B
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x00098BE3 File Offset: 0x00096DE3
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

	// Token: 0x060017BC RID: 6076 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060017BD RID: 6077 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x00098FA2 File Offset: 0x000971A2
	private void MDMDGKHDPKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -116);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void DFENCIHAADO()
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

	// Token: 0x060017C0 RID: 6080 RVA: 0x00098FDD File Offset: 0x000971DD
	private void POIFMMFPELA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00099018 File Offset: 0x00097218
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

	// Token: 0x060017C2 RID: 6082 RVA: 0x00099084 File Offset: 0x00097284
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 449f)
			{
				this.HBJJOCHGOPH = 243f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture("/", this.JDMCFBKJHDD);
			}
			this.OLHDPICFBOF().SetFloat("B:", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("_DotSize", this.BlendFX);
			this.FGENHBKMPDA().SetFloat("[ItemsHandler] All in-game items loaded", this.SwitchCameraToCamera2);
			this.FGENHBKMPDA().SetVector("Prints list of all previous commands", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 356f, 1489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00099180 File Offset: 0x00097380
	private void KOJKBFDNGDK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x000991EC File Offset: 0x000973EC
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1575f)
			{
				this.HBJJOCHGOPH = 1911f;
			}
			if (this.Camera2 != null)
			{
				this.OLHDPICFBOF().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.KOHGPKOFEJO().SetFloat("Anime", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("23x3", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat("MenuScene", this.SwitchCameraToCamera2);
			this.KJMECMIGJJA().SetVector("error", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1700f, 288f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void FDMAEPOHDMK()
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

	// Token: 0x060017C6 RID: 6086 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void EDBEHEKMGFH()
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

	// Token: 0x060017C7 RID: 6087 RVA: 0x000992E6 File Offset: 0x000974E6
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x00099320 File Offset: 0x00097520
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1843f)
			{
				this.HBJJOCHGOPH = 1291f;
			}
			if (this.Camera2 != null)
			{
				this.EFDEIFCDAFG().SetTexture("_Near", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat("SetPosition", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("No problem found, so far", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("DifficultyBG", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("settings.disablestoryboard", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1144f, 229f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x0009941A File Offset: 0x0009761A
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x00099454 File Offset: 0x00097654
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 669f)
			{
				this.HBJJOCHGOPH = 141f;
			}
			if (this.Camera2 != null)
			{
				this.EFDEIFCDAFG().SetTexture("Error: Cannot change the name of a remote player!", this.JDMCFBKJHDD);
			}
			this.KJMECMIGJJA().SetFloat("PossibleMapMaxScoreText", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Depth textures aren't supported on this device ({0})", this.BlendFX);
			this.EFMCNLELMDO().SetFloat("_ArScale", this.SwitchCameraToCamera2);
			this.DNLMFEGJJDD().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 208f, 197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x0009954E File Offset: 0x0009774E
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x00099585 File Offset: 0x00097785
	private void IHAGANPOFDP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 6);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x000995C0 File Offset: 0x000977C0
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void PKBENONAOOL()
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

	// Token: 0x060017D1 RID: 6097 RVA: 0x000995FC File Offset: 0x000977FC
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1814f)
			{
				this.HBJJOCHGOPH = 1300f;
			}
			if (this.Camera2 != null)
			{
				this.DNLMFEGJJDD().SetTexture("CameraFilterPack/Blizzard", this.JDMCFBKJHDD);
			}
			this.EFDEIFCDAFG().SetFloat("_GlowColor", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("[MapsSystem] Unloading maps resources...", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat(" BETA", this.SwitchCameraToCamera2);
			this.PGPEMMBJOOG().SetVector(".a", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1396f, 1827f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x000996F8 File Offset: 0x000978F8
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1965f)
			{
				this.HBJJOCHGOPH = 58f;
			}
			if (this.Camera2 != null)
			{
				this.HFBJAOFLCJI().SetTexture("inventory.selected.", this.JDMCFBKJHDD);
			}
			this.HEHKGPKLAKK().SetFloat(".", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", this.BlendFX);
			this.HEHKGPKLAKK().SetFloat("#mapby", this.SwitchCameraToCamera2);
			this.EFMCNLELMDO().SetVector("skin.hit_normal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 650f, 1531f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x000997F4 File Offset: 0x000979F4
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1830f)
			{
				this.HBJJOCHGOPH = 330f;
			}
			if (this.Camera2 != null)
			{
				this.KOHGPKOFEJO().SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.EFDEIFCDAFG().SetFloat("Submit", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("ViewMenu", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("PUNCloudBestRegion", this.SwitchCameraToCamera2);
			this.FGENHBKMPDA().SetVector("Connected to masterserver.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1586f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x000998F0 File Offset: 0x00097AF0
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 726f)
			{
				this.HBJJOCHGOPH = 741f;
			}
			if (this.Camera2 != null)
			{
				this.EFDEIFCDAFG().SetTexture("settings.enablehitsoundsinrelax", this.JDMCFBKJHDD);
			}
			this.OLHDPICFBOF().SetFloat("event", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("Depth textures aren't supported on this device ({0})", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat("The new master starts a new round, cause we didn't start yet.", this.SwitchCameraToCamera2);
			this.LNLKMDPHDCC().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1212f, 1424f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void HONBLGFDMLL()
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

	// Token: 0x060017D6 RID: 6102 RVA: 0x000999EC File Offset: 0x00097BEC
	private void IDJKNBDKHBD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -116);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x00099A58 File Offset: 0x00097C58
	private void JHANGPCOCIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x00099AC4 File Offset: 0x00097CC4
	private void BMIOFJFMCBG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x00098BE3 File Offset: 0x00096DE3
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

	// Token: 0x060017DA RID: 6106 RVA: 0x00099B2D File Offset: 0x00097D2D
	private void LONLHFLPEJD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00099B68 File Offset: 0x00097D68
	private void EMAMCDFBGOA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 90);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x00099BA4 File Offset: 0x00097DA4
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 777f)
			{
				this.HBJJOCHGOPH = 1666f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture("null", this.JDMCFBKJHDD);
			}
			this.PGPEMMBJOOG().SetFloat("DisableStoryboardToggle", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_Quality", this.BlendFX);
			this.KOHGPKOFEJO().SetFloat("_Offsets", this.SwitchCameraToCamera2);
			this.PGPEMMBJOOG().SetVector(".wav", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 755f, 18f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00099CA0 File Offset: 0x00097EA0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 45f)
			{
				this.HBJJOCHGOPH = 1890f;
			}
			if (this.Camera2 != null)
			{
				this.OLHDPICFBOF().SetTexture("_Distortion", this.JDMCFBKJHDD);
			}
			this.OLHDPICFBOF().SetFloat("Observed type is not serializable: ", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("{", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("Clear Environment", this.SwitchCameraToCamera2);
			this.KJMECMIGJJA().SetVector("PublishButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1360f, 1128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x00099D9A File Offset: 0x00097F9A
	private void IIJAPKAADNH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x00099DD5 File Offset: 0x00097FD5
	private void MEJPBKFMAIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -37);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void IMGGCJICLHK()
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

	// Token: 0x060017E1 RID: 6113 RVA: 0x00099E10 File Offset: 0x00098010
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1385f)
			{
				this.HBJJOCHGOPH = 221f;
			}
			if (this.Camera2 != null)
			{
				this.PGPEMMBJOOG().SetTexture("#FFDA44CC", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("No font defined. Found font: ", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("<b>HP</b>:", this.BlendFX);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack_Glasses_On7", this.SwitchCameraToCamera2);
			this.EFDEIFCDAFG().SetVector("end", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void IEFMONDKKJN()
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

	// Token: 0x060017E3 RID: 6115 RVA: 0x00099F0C File Offset: 0x0009810C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 702f)
			{
				this.HBJJOCHGOPH = 869f;
			}
			if (this.Camera2 != null)
			{
				this.EFMCNLELMDO().SetTexture("offsets", this.JDMCFBKJHDD);
			}
			this.KOHGPKOFEJO().SetFloat("player.currentrank", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("[LocalizationService] Error: ", this.BlendFX);
			this.OLHDPICFBOF().SetFloat(". Using max value: 255.", this.SwitchCameraToCamera2);
			this.HEHKGPKLAKK().SetVector("ArcsDestroyDelaySlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 690f, 1733f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017E4 RID: 6116 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060017E5 RID: 6117 RVA: 0x0009A006 File Offset: 0x00098206
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0009A03D File Offset: 0x0009823D
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

	// Token: 0x060017E7 RID: 6119 RVA: 0x00098BE3 File Offset: 0x00096DE3
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

	// Token: 0x060017E8 RID: 6120 RVA: 0x0009A074 File Offset: 0x00098274
	private void FELENDJEOGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -69);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x0009A0B0 File Offset: 0x000982B0
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1561f)
			{
				this.HBJJOCHGOPH = 1f;
			}
			if (this.Camera2 != null)
			{
				this.FGENHBKMPDA().SetTexture("file://", this.JDMCFBKJHDD);
			}
			this.LNLKMDPHDCC().SetFloat("No Description", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Light_Rainbow", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("_Value5", this.SwitchCameraToCamera2);
			this.EFDEIFCDAFG().SetVector("Failed to Destroy objects of playerId: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 271f, 442f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x0009A1AA File Offset: 0x000983AA
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x0009A1E1 File Offset: 0x000983E1
	private void BLDMINMDHPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -39);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x0009A21C File Offset: 0x0009841C
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017EE RID: 6126 RVA: 0x0009A258 File Offset: 0x00098458
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1329f)
			{
				this.HBJJOCHGOPH = 1730f;
			}
			if (this.Camera2 != null)
			{
				this.KOHGPKOFEJO().SetTexture("OpLeaveLobby()", this.JDMCFBKJHDD);
			}
			this.FGENHBKMPDA().SetFloat("_Bloom", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ReflectionTexture1", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat("curScn", this.SwitchCameraToCamera2);
			this.FGENHBKMPDA().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1956f, 601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void KMOCDAOKGLI()
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

	// Token: 0x060017F0 RID: 6128 RVA: 0x00098BE3 File Offset: 0x00096DE3
	private void CBIBDOIBJAI()
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

	// Token: 0x060017F1 RID: 6129 RVA: 0x0009A352 File Offset: 0x00098552
	private void LIFBFDKFMMH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x0009A38D File Offset: 0x0009858D
	private void CCKABCDEOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 108);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x0009A3C8 File Offset: 0x000985C8
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 979f)
			{
				this.HBJJOCHGOPH = 1196f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture("Trackpad", this.JDMCFBKJHDD);
			}
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/3D_Anomaly", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("settings.enablehitsoundsinnormal", this.BlendFX);
			this.HEHKGPKLAKK().SetFloat("r", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetVector("{0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 231f, 79f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x0009A4C4 File Offset: 0x000986C4
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

	// Token: 0x060017F5 RID: 6133 RVA: 0x0009A5C0 File Offset: 0x000987C0
	private void HJPCJGOEKMF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -16);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x00098BE3 File Offset: 0x00096DE3
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

	// Token: 0x060017F7 RID: 6135 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060017F8 RID: 6136 RVA: 0x0009A62C File Offset: 0x0009882C
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1985f)
			{
				this.HBJJOCHGOPH = 1433f;
			}
			if (this.Camera2 != null)
			{
				this.FGENHBKMPDA().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.PGPEMMBJOOG().SetFloat("PunRespawn", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("Sending vacant view IDs. Length: ", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("(\\[ *b *\\])", this.SwitchCameraToCamera2);
			this.EFMCNLELMDO().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 318f, 933f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x0009A728 File Offset: 0x00098928
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x000995C0 File Offset: 0x000977C0
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x0009A794 File Offset: 0x00098994
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 894f)
			{
				this.HBJJOCHGOPH = 1667f;
			}
			if (this.Camera2 != null)
			{
				this.KOHGPKOFEJO().SetTexture("SettingsCanvas", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("The binding '", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", this.BlendFX);
			this.KOHGPKOFEJO().SetFloat("_DistortionLevel", this.SwitchCameraToCamera2);
			this.KOHGPKOFEJO().SetVector("roomDescription", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 329f, 1027f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x0009A88E File Offset: 0x00098A8E
	private void LKCHMPCHKDM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x0009A8C9 File Offset: 0x00098AC9
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x0009A900 File Offset: 0x00098B00
	private void PPGEGFMNIKO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -73);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x0009A93B File Offset: 0x00098B3B
	private void HDHHMBEJIMB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x0009A976 File Offset: 0x00098B76
	private void IIKCMDMMJJI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x0009A9B4 File Offset: 0x00098BB4
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1175f)
			{
				this.HBJJOCHGOPH = 1710f;
			}
			if (this.Camera2 != null)
			{
				this.EFDEIFCDAFG().SetTexture("Done!", this.JDMCFBKJHDD);
			}
			this.KJMECMIGJJA().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetVector("<b>#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 836f, 1699f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001804 RID: 6148 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x0009AAB0 File Offset: 0x00098CB0
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1882f)
			{
				this.HBJJOCHGOPH = 1520f;
			}
			if (this.Camera2 != null)
			{
				this.KOHGPKOFEJO().SetTexture("&page=", this.JDMCFBKJHDD);
			}
			this.HFBJAOFLCJI().SetFloat("/../", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("Trackpad", this.BlendFX);
			this.LNLKMDPHDCC().SetFloat("[Up]", this.SwitchCameraToCamera2);
			this.LNLKMDPHDCC().SetVector("CameraFilterPack_Atmosphere_Rain_FX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1288f, 1416f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000355 RID: 853
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SoftLight";

	// Token: 0x04000356 RID: 854
	public Shader SCShader;

	// Token: 0x04000357 RID: 855
	public Camera Camera2;

	// Token: 0x04000358 RID: 856
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000359 RID: 857
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400035A RID: 858
	private Material BJFKDHHMLJH;

	// Token: 0x0400035B RID: 859
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x0400035C RID: 860
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400035D RID: 861
	private RenderTexture JDMCFBKJHDD;
}
