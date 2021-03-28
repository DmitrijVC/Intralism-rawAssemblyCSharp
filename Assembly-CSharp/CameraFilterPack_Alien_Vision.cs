using System;
using UnityEngine;

// Token: 0x02000032 RID: 50
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Alien/Vision")]
public class CameraFilterPack_Alien_Vision : MonoBehaviour
{
	// Token: 0x06000CA5 RID: 3237 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x0005C748 File Offset: 0x0005A948
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Alien_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x0005C76C File Offset: 0x0005A96C
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x0005C790 File Offset: 0x0005A990
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("X");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x0005C7B4 File Offset: 0x0005A9B4
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x0005C7EB File Offset: 0x0005A9EB
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("Operation ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x0005C810 File Offset: 0x0005AA10
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1330f)
			{
				this.HBJJOCHGOPH = 869f;
			}
			this.HKGAONMOBMH().SetFloat("float,1", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("/", this.Therma_Variation);
			this.IIBLJCKLGFG().SetFloat("#ok", this.Speed);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.ALELLLFCDBF);
			this.HKGAONMOBMH().SetFloat("nogamesfound", this.NFDIFLHGJKB);
			this.IIBLJCKLGFG().SetVector("_NoisePerChannel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 970f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x0005C910 File Offset: 0x0005AB10
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Therma_Variation);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.NFDIFLHGJKB);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x0005CA0F File Offset: 0x0005AC0F
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x0005CA68 File Offset: 0x0005AC68
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1416f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.MCDGIILBNIF().SetFloat("EventData0DropDownList", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("_Screen", this.Therma_Variation);
			this.KBOPGONOCNP().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", this.Speed);
			this.EJDPNJAEAKJ().SetFloat("_Value3", this.ALELLLFCDBF);
			this.EJDPNJAEAKJ().SetFloat("_EmissionColor", this.NFDIFLHGJKB);
			this.NBPKMLMCHFN.SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1368f, 1642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x0005CB67 File Offset: 0x0005AD67
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x0005CB9E File Offset: 0x0005AD9E
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("1234332714");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0005CBC2 File Offset: 0x0005ADC2
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

	// Token: 0x06000CB6 RID: 3254 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x0005CBF9 File Offset: 0x0005ADF9
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x0005CC30 File Offset: 0x0005AE30
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1890f)
			{
				this.HBJJOCHGOPH = 1541f;
			}
			this.EJDPNJAEAKJ().SetFloat("Connecting to server", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("PunRespawn with Position.", this.Therma_Variation);
			this.IIBLJCKLGFG().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.Speed);
			this.DEFBJOCJJKF().SetFloat("st", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("_Threshhold", this.NFDIFLHGJKB);
			this.GCDFNHMJMIP().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1388f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x0005CD2F File Offset: 0x0005AF2F
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x0005CD53 File Offset: 0x0005AF53
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x0005CD8C File Offset: 0x0005AF8C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 640f)
			{
				this.HBJJOCHGOPH = 1790f;
			}
			this.HKGAONMOBMH().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.Therma_Variation);
			this.ADGHJOHKEHG().SetFloat("EventConfigButton", this.Speed);
			this.KBOPGONOCNP().SetFloat("_BlurVector", this.ALELLLFCDBF);
			this.ADGHJOHKEHG().SetFloat("The shader ", this.NFDIFLHGJKB);
			this.IIBLJCKLGFG().SetVector("GameScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 249f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x0005CE8B File Offset: 0x0005B08B
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("[PlayerBase] ShowImage \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0005CEB0 File Offset: 0x0005B0B0
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 696f)
			{
				this.HBJJOCHGOPH = 1968f;
			}
			this.EJDPNJAEAKJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("SpawnObj", this.Therma_Variation);
			this.KBOPGONOCNP().SetFloat("ItemNameText", this.Speed);
			this.HKGAONMOBMH().SetFloat("value", this.ALELLLFCDBF);
			this.NBPKMLMCHFN.SetFloat("4,28,true,0", this.NFDIFLHGJKB);
			this.IIBLJCKLGFG().SetVector("_Bullet_1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 346f, 1284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x0005CFAF File Offset: 0x0005B1AF
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Chromatical2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x0005CFD3 File Offset: 0x0005B1D3
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x0005CD2F File Offset: 0x0005AF2F
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0005D00C File Offset: 0x0005B20C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 151f;
			}
			this.NBPKMLMCHFN.SetFloat("blue", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("float,0", this.Therma_Variation);
			this.HKGAONMOBMH().SetFloat("_Saturation", this.Speed);
			this.EPCGJFCCAFH().SetFloat("_ScreenResolution", this.ALELLLFCDBF);
			this.HKGAONMOBMH().SetFloat("skin.hit_perfect", this.NFDIFLHGJKB);
			this.GCDFNHMJMIP().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1078f, 942f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x0005D10C File Offset: 0x0005B30C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 203f)
			{
				this.HBJJOCHGOPH = 891f;
			}
			this.KBOPGONOCNP().SetFloat("PLEASE WAIT", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("]", this.Therma_Variation);
			this.DEFBJOCJJKF().SetFloat("ControllerLeftY", this.Speed);
			this.DEFBJOCJJKF().SetFloat("_Fade", this.ALELLLFCDBF);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/Gradients_Desert", this.NFDIFLHGJKB);
			this.HKGAONMOBMH().SetVector("StartButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 668f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x0005D20C File Offset: 0x0005B40C
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1002f)
			{
				this.HBJJOCHGOPH = 51f;
			}
			this.EJDPNJAEAKJ().SetFloat("BlockSize", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_Saturation", this.Therma_Variation);
			this.KBOPGONOCNP().SetFloat("Please attach component to a Graphical UI component", this.Speed);
			this.EJDPNJAEAKJ().SetFloat(")", this.ALELLLFCDBF);
			this.HKGAONMOBMH().SetFloat("_Value5", this.NFDIFLHGJKB);
			this.HKGAONMOBMH().SetVector("LevelNameInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 746f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x0005D30C File Offset: 0x0005B50C
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 821f)
			{
				this.HBJJOCHGOPH = 761f;
			}
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/Vision_Tunnel", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("settings.enablehitsoundsinnormal", this.Therma_Variation);
			this.KBOPGONOCNP().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", this.Speed);
			this.GCDFNHMJMIP().SetFloat("_ReprojectionMatrix", this.ALELLLFCDBF);
			this.MCDGIILBNIF().SetFloat("_MatrixSize", this.NFDIFLHGJKB);
			this.EJDPNJAEAKJ().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1178f, 968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x0005D40C File Offset: 0x0005B60C
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1566f)
			{
				this.HBJJOCHGOPH = 303f;
			}
			this.EJDPNJAEAKJ().SetFloat("Write me to get one for testing :)", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("StartButton", this.Therma_Variation);
			this.NBPKMLMCHFN.SetFloat("GameScene", this.Speed);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/EyesVision_2", this.ALELLLFCDBF);
			this.MCDGIILBNIF().SetFloat("_ScreenResolution", this.NFDIFLHGJKB);
			this.DEFBJOCJJKF().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 572f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x0005D50C File Offset: 0x0005B70C
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 417f)
			{
				this.HBJJOCHGOPH = 523f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("maps.", this.Therma_Variation);
			this.EJDPNJAEAKJ().SetFloat("_BlurDirectionPacked", this.Speed);
			this.GCDFNHMJMIP().SetFloat("Please attach component to a Graphical UI component", this.ALELLLFCDBF);
			this.HKGAONMOBMH().SetFloat("Noise shaders are not set up! Disabling noise effect.", this.NFDIFLHGJKB);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 273f, 1461f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x0005D60B File Offset: 0x0005B80B
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x0005D62F File Offset: 0x0005B82F
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x0005D668 File Offset: 0x0005B868
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 711f;
			}
			this.EPCGJFCCAFH().SetFloat("TwoHands", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("inventory.selected.", this.Therma_Variation);
			this.EPCGJFCCAFH().SetFloat("_Far", this.Speed);
			this.MCDGIILBNIF().SetFloat("_TimeX", this.ALELLLFCDBF);
			this.KBOPGONOCNP().SetFloat("Joystick1Button2", this.NFDIFLHGJKB);
			this.IIBLJCKLGFG().SetVector("UseScanLine", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1561f, 244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x0005D767 File Offset: 0x0005B967
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x0005D79E File Offset: 0x0005B99E
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x0005D7D5 File Offset: 0x0005B9D5
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x0005D80C File Offset: 0x0005BA0C
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("Parameter levelId can't be null!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x0005D830 File Offset: 0x0005BA30
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1460f)
			{
				this.HBJJOCHGOPH = 123f;
			}
			this.EJDPNJAEAKJ().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("Texture2", this.Therma_Variation);
			this.HKGAONMOBMH().SetFloat("achievements.21.progress", this.Speed);
			this.MCDGIILBNIF().SetFloat("_Value3", this.ALELLLFCDBF);
			this.IIBLJCKLGFG().SetFloat("_Val3", this.NFDIFLHGJKB);
			this.GCDFNHMJMIP().SetVector("VHS", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1776f, 1797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x0005D930 File Offset: 0x0005BB30
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1092f)
			{
				this.HBJJOCHGOPH = 230f;
			}
			this.EJDPNJAEAKJ().SetFloat("YES", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat(" = ", this.Therma_Variation);
			this.HHIFMIPPMPF().SetFloat("L1", this.Speed);
			this.DEFBJOCJJKF().SetFloat(": ", this.ALELLLFCDBF);
			this.ADGHJOHKEHG().SetFloat("_TimeX", this.NFDIFLHGJKB);
			this.NBPKMLMCHFN.SetVector("Jit ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 311f, 851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x0005DA2F File Offset: 0x0005BC2F
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x0005DA66 File Offset: 0x0005BC66
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find(" Remote called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x0005C72B File Offset: 0x0005A92B
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001EA RID: 490
	public Shader SCShader;

	// Token: 0x040001EB RID: 491
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001EC RID: 492
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001ED RID: 493
	private Material BJFKDHHMLJH;

	// Token: 0x040001EE RID: 494
	[Range(0f, 0.5f)]
	public float Therma_Variation = 0.5f;

	// Token: 0x040001EF RID: 495
	[Range(0f, 1f)]
	public float Speed = 0.5f;

	// Token: 0x040001F0 RID: 496
	[Range(0f, 4f)]
	private float ALELLLFCDBF;

	// Token: 0x040001F1 RID: 497
	[Range(0f, 16f)]
	private float NFDIFLHGJKB = 1f;
}
