using System;
using UnityEngine;

// Token: 0x0200007B RID: 123
[AddComponentMenu("Camera Filter Pack/Colors/BleachBypass")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_BleachBypass : MonoBehaviour
{
	// Token: 0x060022CC RID: 8908 RVA: 0x000CBE04 File Offset: 0x000CA004
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x000CBEC1 File Offset: 0x000CA0C1
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_RgbClamp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x000CBEE5 File Offset: 0x000CA0E5
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x000CBF1C File Offset: 0x000CA11C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 74f)
			{
				this.HBJJOCHGOPH = 156f;
			}
			this.IONHGBPGCHK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Tab2Content", this.Value);
			this.OLHDPICFBOF().SetVector("english", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 169f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x000CBFD9 File Offset: 0x000CA1D9
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x000CC010 File Offset: 0x000CA210
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x000CC02D File Offset: 0x000CA22D
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x000CC064 File Offset: 0x000CA264
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_BleachBypass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060022D4 RID: 8916 RVA: 0x000CC088 File Offset: 0x000CA288
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

	// Token: 0x060022D5 RID: 8917 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x000CC0C0 File Offset: 0x000CA2C0
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1536f)
			{
				this.HBJJOCHGOPH = 629f;
			}
			this.OLHDPICFBOF().SetFloat("_History3Weight", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_Value2", this.Value);
			this.NFMGLIKNOOC().SetVector("wss://", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 353f, 317f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x000CC17D File Offset: 0x000CA37D
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x000CC1A1 File Offset: 0x000CA3A1
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("Color's hex value #RRGGBBAA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x000CC1C8 File Offset: 0x000CA3C8
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1092f)
			{
				this.HBJJOCHGOPH = 338f;
			}
			this.NFMGLIKNOOC().SetFloat(".status", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("Fade", this.Value);
			this.IONHGBPGCHK().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1229f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x000CC285 File Offset: 0x000CA485
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x000CC010 File Offset: 0x000CA210
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x000CC2BC File Offset: 0x000CA4BC
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x000CC2E0 File Offset: 0x000CA4E0
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 374f)
			{
				this.HBJJOCHGOPH = 1034f;
			}
			this.NDMPCDHADMJ().SetFloat(".", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", this.Value);
			this.JLHLHKPHDFO().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 63f, 1599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x000CC39D File Offset: 0x000CA59D
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x000CC3C1 File Offset: 0x000CA5C1
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x000CC3F8 File Offset: 0x000CA5F8
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x000CC41C File Offset: 0x000CA61C
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x000CC453 File Offset: 0x000CA653
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x000CC48A File Offset: 0x000CA68A
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x000CC4AE File Offset: 0x000CA6AE
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060022E8 RID: 8936 RVA: 0x000CC010 File Offset: 0x000CA210
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x000CC4D2 File Offset: 0x000CA6D2
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060022EA RID: 8938 RVA: 0x000CC4F6 File Offset: 0x000CA6F6
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("#restart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022EB RID: 8939 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x000CC010 File Offset: 0x000CA210
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022EE RID: 8942 RVA: 0x000CC010 File Offset: 0x000CA210
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x000CC010 File Offset: 0x000CA210
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x000CC2BC File Offset: 0x000CA4BC
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060022F1 RID: 8945 RVA: 0x000CC51A File Offset: 0x000CA71A
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022F2 RID: 8946 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060022F3 RID: 8947 RVA: 0x000CC551 File Offset: 0x000CA751
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("Offline or in OfflineMode. No VitalStats available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022F4 RID: 8948 RVA: 0x000CC010 File Offset: 0x000CA210
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022F5 RID: 8949 RVA: 0x000CC010 File Offset: 0x000CA210
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060022F6 RID: 8950 RVA: 0x000CC575 File Offset: 0x000CA775
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022F7 RID: 8951 RVA: 0x000CC5AC File Offset: 0x000CA7AC
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x000CC5D0 File Offset: 0x000CA7D0
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022FB RID: 8955 RVA: 0x000CC625 File Offset: 0x000CA825
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x000CC65C File Offset: 0x000CA85C
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x000CC694 File Offset: 0x000CA894
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 565f)
			{
				this.HBJJOCHGOPH = 1046f;
			}
			this.IFMAPIDFNLI().SetFloat("GLITCH", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("Electronic", this.Value);
			this.NBPKMLMCHFN.SetVector("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 457f, 940f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x000CC751 File Offset: 0x000CA951
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("LevelEditor/CustomEventEditor-Text");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x000CC778 File Offset: 0x000CA978
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1246f)
			{
				this.HBJJOCHGOPH = 147f;
			}
			this.IFMAPIDFNLI().SetFloat("Submition failed", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat(" By: ", this.Value);
			this.KBOPGONOCNP().SetVector("_MainTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 493f, 626f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x000CC838 File Offset: 0x000CAA38
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1460f)
			{
				this.HBJJOCHGOPH = 1699f;
			}
			this.DEFBJOCJJKF().SetFloat("Fade", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_Value3", this.Value);
			this.FHFLKLMFHOI().SetVector("ItemNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1113f, 817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x000CC8F5 File Offset: 0x000CAAF5
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x000CC92C File Offset: 0x000CAB2C
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x000CC950 File Offset: 0x000CAB50
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x000CC988 File Offset: 0x000CAB88
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1924f)
			{
				this.HBJJOCHGOPH = 1127f;
			}
			this.NBPKMLMCHFN.SetFloat(".completedMaps", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("getstring", this.Value);
			this.NFMGLIKNOOC().SetVector("levelcompleted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 557f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000CC285 File Offset: 0x000CA485
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x000CC010 File Offset: 0x000CA210
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x000CCA48 File Offset: 0x000CAC48
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1688f)
			{
				this.HBJJOCHGOPH = 1333f;
			}
			this.FHFLKLMFHOI().SetFloat("_Overlay", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("yyyy-MM-dd HH:mm:ss", this.Value);
			this.MJJIEHANFJA().SetVector("tolobby", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 413f, 23f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600230A RID: 8970 RVA: 0x000CCB05 File Offset: 0x000CAD05
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_GreenAmplifier");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x000CCB29 File Offset: 0x000CAD29
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x000CCB4D File Offset: 0x000CAD4D
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600230D RID: 8973 RVA: 0x000CCB84 File Offset: 0x000CAD84
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x000CCBBC File Offset: 0x000CADBC
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 972f)
			{
				this.HBJJOCHGOPH = 1509f;
			}
			this.MJJIEHANFJA().SetFloat("remaining: {0:0.000}", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("[ERROR KEY {0}]", this.Value);
			this.NBPKMLMCHFN.SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1306f, 299f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x000CCC7C File Offset: 0x000CAE7C
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 835f)
			{
				this.HBJJOCHGOPH = 1115f;
			}
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_Value2", this.Value);
			this.DEFBJOCJJKF().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1139f, 1487f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x000CC010 File Offset: 0x000CA210
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x000CCD3C File Offset: 0x000CAF3C
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1730f)
			{
				this.HBJJOCHGOPH = 665f;
			}
			this.OLHDPICFBOF().SetFloat(" not found", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_PColor", this.Value);
			this.BLMPMOIDGMG().SetVector(".completed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 145f, 1248f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x000CC010 File Offset: 0x000CA210
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x000CCDFC File Offset: 0x000CAFFC
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1495f)
			{
				this.HBJJOCHGOPH = 1182f;
			}
			this.PHGCJOPFDOG().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_TimeX", this.Value);
			this.FKEOGPDLBDD().SetVector("23x3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 185f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x000CCEBC File Offset: 0x000CB0BC
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1611f)
			{
				this.HBJJOCHGOPH = 1962f;
			}
			this.NDMPCDHADMJ().SetFloat("settings_bindings_", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_Intensity", this.Value);
			this.NDMPCDHADMJ().SetVector("CameraFilterPack/OldFilm_Cutting1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 710f, 775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x000CCF7C File Offset: 0x000CB17C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1975f)
			{
				this.HBJJOCHGOPH = 528f;
			}
			this.OCHJIMJNEMO().SetFloat("[ResourcesManager] Unloading data resources", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("SlidingArea", this.Value);
			this.MJJIEHANFJA().SetVector("New SaveGame", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 275f, 727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x000CD039 File Offset: 0x000CB239
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x000CC010 File Offset: 0x000CA210
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x000CD060 File Offset: 0x000CB260
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 394f)
			{
				this.HBJJOCHGOPH = 1035f;
			}
			this.NDMPCDHADMJ().SetFloat("_HeightParams", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_Value3", this.Value);
			this.MJJIEHANFJA().SetVector("RPC: 'OnAwakeRPC' PhotonView: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1325f, 1012f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x000CD11D File Offset: 0x000CB31D
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("move");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x000CC2BC File Offset: 0x000CA4BC
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x000CC5D0 File Offset: 0x000CA7D0
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x000CD144 File Offset: 0x000CB344
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1022f)
			{
				this.HBJJOCHGOPH = 694f;
			}
			this.NBPKMLMCHFN.SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_Value4", this.Value);
			this.NFMGLIKNOOC().SetVector("_NoisePerChannel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1285f, 1364f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x000CC2BC File Offset: 0x000CA4BC
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x000CD204 File Offset: 0x000CB404
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1512f)
			{
				this.HBJJOCHGOPH = 1637f;
			}
			this.NFMGLIKNOOC().SetFloat("{\"items\":", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("RedoButton", this.Value);
			this.FHFLKLMFHOI().SetVector("Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 579f, 688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002320 RID: 8992 RVA: 0x000CD2C1 File Offset: 0x000CB4C1
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("CameraFilterPack_TV_BrokenGlass1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x000CD2E5 File Offset: 0x000CB4E5
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("EnvironmentSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x000CC010 File Offset: 0x000CA210
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002323 RID: 8995 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x000CC010 File Offset: 0x000CA210
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x000CD309 File Offset: 0x000CB509
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("Set sun colors");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x000CC8F5 File Offset: 0x000CAAF5
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x000CD330 File Offset: 0x000CB530
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 587f)
			{
				this.HBJJOCHGOPH = 683f;
			}
			this.KJMECMIGJJA().SetFloat("Drop_Near", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_Bullet_6", this.Value);
			this.OLHDPICFBOF().SetVector(" respawn: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 852f, 1656f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x000CD3ED File Offset: 0x000CB5ED
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("#FFFFFF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x000CD414 File Offset: 0x000CB614
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1592f)
			{
				this.HBJJOCHGOPH = 486f;
			}
			this.EPCGJFCCAFH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_ScreenResolution", this.Value);
			this.DEFBJOCJJKF().SetVector("[LocalizationService] All languages: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 142f, 942f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x000CD4D4 File Offset: 0x000CB6D4
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 983f)
			{
				this.HBJJOCHGOPH = 1084f;
			}
			this.NFMGLIKNOOC().SetFloat(";", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat(" not exist", this.Value);
			this.MJJIEHANFJA().SetVector("mapselector.lastSearch", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 103f, 1013f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400048F RID: 1167
	public Shader SCShader;

	// Token: 0x04000490 RID: 1168
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000491 RID: 1169
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000492 RID: 1170
	private Material BJFKDHHMLJH;

	// Token: 0x04000493 RID: 1171
	[Range(-1f, 2f)]
	public float Value = 1f;
}
