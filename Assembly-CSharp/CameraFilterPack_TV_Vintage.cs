using System;
using UnityEngine;

// Token: 0x02000129 RID: 297
[AddComponentMenu("Camera Filter Pack/TV/Vintage")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Vintage : MonoBehaviour
{
	// Token: 0x06005E0B RID: 24075 RVA: 0x001CB12D File Offset: 0x001C932D
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E0C RID: 24076 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06005E0D RID: 24077 RVA: 0x001CB12D File Offset: 0x001C932D
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E0E RID: 24078 RVA: 0x001CB14A File Offset: 0x001C934A
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_VividLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E0F RID: 24079 RVA: 0x001CB16E File Offset: 0x001C936E
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E10 RID: 24080 RVA: 0x001CB194 File Offset: 0x001C9394
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 373f)
			{
				this.HBJJOCHGOPH = 1818f;
			}
			this.KAFBNOBOIAJ().SetFloat("SelectorMapsCountSlider", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("_Value7", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E11 RID: 24081 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06005E12 RID: 24082 RVA: 0x001CB12D File Offset: 0x001C932D
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E13 RID: 24083 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06005E14 RID: 24084 RVA: 0x001CB224 File Offset: 0x001C9424
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E15 RID: 24085 RVA: 0x001CB248 File Offset: 0x001C9448
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1552f)
			{
				this.HBJJOCHGOPH = 842f;
			}
			this.FEAEGGCNIAA().SetFloat("_SecondTex", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E16 RID: 24086 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06005E17 RID: 24087 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06005E18 RID: 24088 RVA: 0x001CB2D8 File Offset: 0x001C94D8
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E19 RID: 24089 RVA: 0x001CB30F File Offset: 0x001C950F
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E1A RID: 24090 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005E1B RID: 24091 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06005E1C RID: 24092 RVA: 0x001CB348 File Offset: 0x001C9548
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1936f)
			{
				this.HBJJOCHGOPH = 1057f;
			}
			this.NFKFAAHHLLM().SetFloat("Joystick1Button0", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Blend", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E1D RID: 24093 RVA: 0x001CB12D File Offset: 0x001C932D
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E1E RID: 24094 RVA: 0x001CB12D File Offset: 0x001C932D
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E1F RID: 24095 RVA: 0x001CB3D8 File Offset: 0x001C95D8
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
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E20 RID: 24096 RVA: 0x001CB468 File Offset: 0x001C9668
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E21 RID: 24097 RVA: 0x001CB12D File Offset: 0x001C932D
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E22 RID: 24098 RVA: 0x001CB49F File Offset: 0x001C969F
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E23 RID: 24099 RVA: 0x001CB4D8 File Offset: 0x001C96D8
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1754f)
			{
				this.HBJJOCHGOPH = 1467f;
			}
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat(" (now: ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E24 RID: 24100 RVA: 0x001CB568 File Offset: 0x001C9768
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("editor.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E25 RID: 24101 RVA: 0x001CB58C File Offset: 0x001C978C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 744f)
			{
				this.HBJJOCHGOPH = 266f;
			}
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("{0:0} second{1}", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E26 RID: 24102 RVA: 0x001CB61C File Offset: 0x001C981C
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(" Also make sure to disable sprite packing for this sprite.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E27 RID: 24103 RVA: 0x001CB640 File Offset: 0x001C9840
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1658f)
			{
				this.HBJJOCHGOPH = 1006f;
			}
			this.EOCCJGIGEGJ().SetFloat("bad", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("R:", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E28 RID: 24104 RVA: 0x001CB12D File Offset: 0x001C932D
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E29 RID: 24105 RVA: 0x001CB6D0 File Offset: 0x001C98D0
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E2A RID: 24106 RVA: 0x001CB12D File Offset: 0x001C932D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E2B RID: 24107 RVA: 0x001CB6F4 File Offset: 0x001C98F4
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06005E2C RID: 24108 RVA: 0x001CB72B File Offset: 0x001C992B
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

	// Token: 0x06005E2D RID: 24109 RVA: 0x001CB12D File Offset: 0x001C932D
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E2E RID: 24110 RVA: 0x001CB764 File Offset: 0x001C9964
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 710f)
			{
				this.HBJJOCHGOPH = 490f;
			}
			this.AELJLBOJAIL().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Color_Contrast", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E2F RID: 24111 RVA: 0x001CB7F4 File Offset: 0x001C99F4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1504f)
			{
				this.HBJJOCHGOPH = 1902f;
			}
			this.PDEAHJPOMEF().SetFloat(" url: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E30 RID: 24112 RVA: 0x001CB884 File Offset: 0x001C9A84
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E31 RID: 24113 RVA: 0x001CB8BB File Offset: 0x001C9ABB
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E32 RID: 24114 RVA: 0x001CB12D File Offset: 0x001C932D
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E33 RID: 24115 RVA: 0x001CB12D File Offset: 0x001C932D
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E34 RID: 24116 RVA: 0x001CB8F4 File Offset: 0x001C9AF4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 326f)
			{
				this.HBJJOCHGOPH = 1653f;
			}
			this.DNLMFEGJJDD().SetFloat("\"\"", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("ItemsCountText", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E35 RID: 24117 RVA: 0x001CB12D File Offset: 0x001C932D
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E36 RID: 24118 RVA: 0x001CB12D File Offset: 0x001C932D
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E37 RID: 24119 RVA: 0x001CB984 File Offset: 0x001C9B84
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E38 RID: 24120 RVA: 0x001CB9A8 File Offset: 0x001C9BA8
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E39 RID: 24121 RVA: 0x001CB9DF File Offset: 0x001C9BDF
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E3A RID: 24122 RVA: 0x001CBA04 File Offset: 0x001C9C04
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 295f)
			{
				this.HBJJOCHGOPH = 434f;
			}
			this.DKNJGHFLAIF().SetFloat("CompletedLevel", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat(": ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E3B RID: 24123 RVA: 0x001CBA94 File Offset: 0x001C9C94
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("0,1,false");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E3C RID: 24124 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06005E3D RID: 24125 RVA: 0x001CBAB8 File Offset: 0x001C9CB8
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 976f)
			{
				this.HBJJOCHGOPH = 694f;
			}
			this.NFKFAAHHLLM().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_EmissionGain", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E3E RID: 24126 RVA: 0x001CBB48 File Offset: 0x001C9D48
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Vintage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E3F RID: 24127 RVA: 0x001CBB6C File Offset: 0x001C9D6C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1704f)
			{
				this.HBJJOCHGOPH = 9f;
			}
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("[PlayerBase] Loaded music", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E40 RID: 24128 RVA: 0x001CB12D File Offset: 0x001C932D
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E41 RID: 24129 RVA: 0x001CBBFC File Offset: 0x001C9DFC
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 199f)
			{
				this.HBJJOCHGOPH = 229f;
			}
			this.NBPKMLMCHFN.SetFloat("[UI] Unknows button action: ", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_TimeX", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E42 RID: 24130 RVA: 0x001CBC8C File Offset: 0x001C9E8C
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E43 RID: 24131 RVA: 0x001CBCC3 File Offset: 0x001C9EC3
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E44 RID: 24132 RVA: 0x001CBCE7 File Offset: 0x001C9EE7
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E46 RID: 24134 RVA: 0x001CBD3C File Offset: 0x001C9F3C
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E47 RID: 24135 RVA: 0x001CBD74 File Offset: 0x001C9F74
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 146f)
			{
				this.HBJJOCHGOPH = 1132f;
			}
			this.ADGHJOHKEHG().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("_TimeX", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E48 RID: 24136 RVA: 0x001CB12D File Offset: 0x001C932D
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E49 RID: 24137 RVA: 0x001CBE04 File Offset: 0x001CA004
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E4A RID: 24138 RVA: 0x001CB12D File Offset: 0x001C932D
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E4B RID: 24139 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06005E4C RID: 24140 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005E4D RID: 24141 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06005E4E RID: 24142 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005E4F RID: 24143 RVA: 0x001CBE28 File Offset: 0x001CA028
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E50 RID: 24144 RVA: 0x001CBE60 File Offset: 0x001CA060
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1488f)
			{
				this.HBJJOCHGOPH = 1407f;
			}
			this.PLBEJJIHFPB().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E51 RID: 24145 RVA: 0x001CBEF0 File Offset: 0x001CA0F0
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_BlurRadius4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E52 RID: 24146 RVA: 0x001CBF14 File Offset: 0x001CA114
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E53 RID: 24147 RVA: 0x001CB12D File Offset: 0x001C932D
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E54 RID: 24148 RVA: 0x001CBF38 File Offset: 0x001CA138
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E55 RID: 24149 RVA: 0x001CBF5C File Offset: 0x001CA15C
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E56 RID: 24150 RVA: 0x001CBF80 File Offset: 0x001CA180
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E57 RID: 24151 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06005E58 RID: 24152 RVA: 0x001CBFB7 File Offset: 0x001CA1B7
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E59 RID: 24153 RVA: 0x001CBFDB File Offset: 0x001CA1DB
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E5A RID: 24154 RVA: 0x001CC014 File Offset: 0x001CA214
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1778f)
			{
				this.HBJJOCHGOPH = 1526f;
			}
			this.PLBEJJIHFPB().SetFloat("_MatrixColor", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("Joystick1Button3", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E5B RID: 24155 RVA: 0x001CB12D File Offset: 0x001C932D
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E5C RID: 24156 RVA: 0x001CC0A4 File Offset: 0x001CA2A4
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400097A RID: 2426
	public Shader SCShader;

	// Token: 0x0400097B RID: 2427
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400097C RID: 2428
	[Range(1f, 10f)]
	public float Distortion = 1f;

	// Token: 0x0400097D RID: 2429
	private Material BJFKDHHMLJH;
}
