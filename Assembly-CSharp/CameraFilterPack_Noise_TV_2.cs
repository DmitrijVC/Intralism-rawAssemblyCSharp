using System;
using UnityEngine;

// Token: 0x020000F8 RID: 248
[AddComponentMenu("Camera Filter Pack/Noise/TV_2")]
[ExecuteInEditMode]
public class CameraFilterPack_Noise_TV_2 : MonoBehaviour
{
	// Token: 0x06004D19 RID: 19737 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D1A RID: 19738 RVA: 0x001802CA File Offset: 0x0017E4CA
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D1B RID: 19739 RVA: 0x00180301 File Offset: 0x0017E501
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D1D RID: 19741 RVA: 0x00180364 File Offset: 0x0017E564
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 363f)
			{
				this.HBJJOCHGOPH = 785f;
			}
			this.KBOPGONOCNP().SetFloat("/", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Received event Leave for unknown player ID: {0}", this.Fade);
			this.FAIFBBGFAIB().SetFloat("Horizontal", this.Fade_Additive);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Fade_Distortion);
			this.KGOLDDBHIFN().SetFloat("other.dust2", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1526f, 210f));
			this.KGOLDDBHIFN().SetTexture("input", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D1E RID: 19742 RVA: 0x0018047C File Offset: 0x0017E67C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade_Additive);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Fade_Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D1F RID: 19743 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06004D20 RID: 19744 RVA: 0x00180591 File Offset: 0x0017E791
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

	// Token: 0x06004D21 RID: 19745 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D22 RID: 19746 RVA: 0x001805C8 File Offset: 0x0017E7C8
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_Noise2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Noise_TV_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D23 RID: 19747 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D24 RID: 19748 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D25 RID: 19749 RVA: 0x00180601 File Offset: 0x0017E801
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D26 RID: 19750 RVA: 0x00180638 File Offset: 0x0017E838
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D27 RID: 19751 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D28 RID: 19752 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06004D29 RID: 19753 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06004D2A RID: 19754 RVA: 0x0018066F File Offset: 0x0017E86F
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load("#turnoninternet") as Texture2D);
		this.SCShader = Shader.Find("STICKLHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D2B RID: 19755 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06004D2C RID: 19756 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D2D RID: 19757 RVA: 0x001806A8 File Offset: 0x0017E8A8
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D2E RID: 19758 RVA: 0x001806DF File Offset: 0x0017E8DF
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D2F RID: 19759 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D30 RID: 19760 RVA: 0x00180716 File Offset: 0x0017E916
	private void CGDMLHLJIDK()
	{
		this.FPHEBLMINDA = (Resources.Load("Uploading preview image...") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D31 RID: 19761 RVA: 0x0018074F File Offset: 0x0017E94F
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D32 RID: 19762 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06004D33 RID: 19763 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004D34 RID: 19764 RVA: 0x00180786 File Offset: 0x0017E986
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("plogs") as Texture2D);
		this.SCShader = Shader.Find("ENABLE_DITHERING");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D35 RID: 19765 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D36 RID: 19766 RVA: 0x001807C0 File Offset: 0x0017E9C0
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 779f)
			{
				this.HBJJOCHGOPH = 1594f;
			}
			this.NDMPCDHADMJ().SetFloat("&map=", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Selection Box", this.Fade);
			this.KEMAALEODNH().SetFloat("_Distortion", this.Fade_Additive);
			this.HHIFMIPPMPF().SetFloat(" not exist", this.Fade_Distortion);
			this.NDMPCDHADMJ().SetFloat("_BlurArea", this.CCIENBFIKKH);
			this.HHIFMIPPMPF().SetVector("CameraFilterPack/Blend2Camera_Multiply", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1324f, 1188f));
			this.IIJMIPBMMBF().SetTexture("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D37 RID: 19767 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06004D38 RID: 19768 RVA: 0x001808D5 File Offset: 0x0017EAD5
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D39 RID: 19769 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06004D3A RID: 19770 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D3B RID: 19771 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06004D3C RID: 19772 RVA: 0x0018090C File Offset: 0x0017EB0C
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D3D RID: 19773 RVA: 0x00180943 File Offset: 0x0017EB43
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("Failed to 'network-remove' GameObject because it's null.") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D3E RID: 19774 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06004D3F RID: 19775 RVA: 0x0018097C File Offset: 0x0017EB7C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1162f)
			{
				this.HBJJOCHGOPH = 1283f;
			}
			this.LONNIJMNKFB().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("[ItemsHandler] No connection to item server: ", this.Fade);
			this.ADBKPGFMNKO().SetFloat("SetSpeed", this.Fade_Additive);
			this.FAIFBBGFAIB().SetFloat("/", this.Fade_Distortion);
			this.KBOPGONOCNP().SetFloat("No font defined. Found font: ", this.CCIENBFIKKH);
			this.FAIFBBGFAIB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 623f, 1289f));
			this.FAIFBBGFAIB().SetTexture("</color>", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D40 RID: 19776 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004D41 RID: 19777 RVA: 0x00180A94 File Offset: 0x0017EC94
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1336f)
			{
				this.HBJJOCHGOPH = 1008f;
			}
			this.HHIFMIPPMPF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Metrics", this.Fade);
			this.KEMAALEODNH().SetFloat("\t", this.Fade_Additive);
			this.KBOPGONOCNP().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", this.Fade_Distortion);
			this.NDMPCDHADMJ().SetFloat("bpmgrid", this.CCIENBFIKKH);
			this.NBMPPNFKFLB().SetVector(".b", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 985f, 1676f));
			this.KBOPGONOCNP().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D42 RID: 19778 RVA: 0x00180BA9 File Offset: 0x0017EDA9
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load("Set Sun Input") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D43 RID: 19779 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06004D44 RID: 19780 RVA: 0x001802AD File Offset: 0x0017E4AD
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D45 RID: 19781 RVA: 0x00180BE2 File Offset: 0x0017EDE2
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlurVector") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004D46 RID: 19782 RVA: 0x00180C1B File Offset: 0x0017EE1B
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000821 RID: 2081
	public Shader SCShader;

	// Token: 0x04000822 RID: 2082
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000823 RID: 2083
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000824 RID: 2084
	private Material BJFKDHHMLJH;

	// Token: 0x04000825 RID: 2085
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000826 RID: 2086
	[Range(0f, 1f)]
	public float Fade_Additive;

	// Token: 0x04000827 RID: 2087
	[Range(0f, 1f)]
	public float Fade_Distortion;

	// Token: 0x04000828 RID: 2088
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

	// Token: 0x04000829 RID: 2089
	private Texture2D FPHEBLMINDA;
}
