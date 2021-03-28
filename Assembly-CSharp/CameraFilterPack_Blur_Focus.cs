using System;
using UnityEngine;

// Token: 0x02000060 RID: 96
[AddComponentMenu("Camera Filter Pack/Blur/Focus")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Focus : MonoBehaviour
{
	// Token: 0x06001AD9 RID: 6873 RVA: 0x000A7534 File Offset: 0x000A5734
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1498f)
			{
				this.HBJJOCHGOPH = 261f;
			}
			this.EFDEIFCDAFG().SetFloat("y", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("Paste events", this.CenterX);
			this.PGPEMMBJOOG().SetFloat("ticket", this.CenterY);
			float value = Mathf.Round(this._Size / 1256f) * 378f;
			this.ADBKPGFMNKO().SetFloat("_ScreenResolution", value);
			this.PDEAHJPOMEF().SetFloat("_AdaptTex", this._Eyes);
			this.EPCGJFCCAFH().SetVector(".highscore", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x000A7640 File Offset: 0x000A5840
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1086f)
			{
				this.HBJJOCHGOPH = 722f;
			}
			this.LONNIJMNKFB().SetFloat("intensity", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_Value3", this.CenterX);
			this.DEFBJOCJJKF().SetFloat("colorA", this.CenterY);
			float value = Mathf.Round(this._Size / 518f) * 690f;
			this.ADBKPGFMNKO().SetFloat(" not exist", value);
			this.ADBKPGFMNKO().SetFloat(";", this._Eyes);
			this.LONNIJMNKFB().SetVector("\n", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x000A774B File Offset: 0x000A594B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Focus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x000A7770 File Offset: 0x000A5970
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
			this.NBPKMLMCHFN.SetFloat("_CenterX", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("_CenterY", this.CenterY);
			float value = Mathf.Round(this._Size / 0.2f) * 0.2f;
			this.NBPKMLMCHFN.SetFloat("_Size", value);
			this.NBPKMLMCHFN.SetFloat("_Circle", this._Eyes);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x000A7898 File Offset: 0x000A5A98
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1546f)
			{
				this.HBJJOCHGOPH = 1734f;
			}
			this.ADBKPGFMNKO().SetFloat("value", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat(". Check if the server is available.", this.CenterX);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Blend2Camera_PinLight", this.CenterY);
			float value = Mathf.Round(this._Size / 969f) * 1118f;
			this.DEFBJOCJJKF().SetFloat("MessageText", value);
			this.PGPEMMBJOOG().SetFloat("Selection Box", this._Eyes);
			this.ADBKPGFMNKO().SetVector("ItemNameBGImage", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x000A79A3 File Offset: 0x000A5BA3
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x000A79DA File Offset: 0x000A5BDA
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x000A79FE File Offset: 0x000A5BFE
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x000A7A35 File Offset: 0x000A5C35
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x000A7A6C File Offset: 0x000A5C6C
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x000A7AA3 File Offset: 0x000A5CA3
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("cmd.exe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000A7AC8 File Offset: 0x000A5CC8
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1570f)
			{
				this.HBJJOCHGOPH = 1540f;
			}
			this.ADBKPGFMNKO().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Mouse X", this.CenterX);
			this.EPCGJFCCAFH().SetFloat("OpJoinLobby()", this.CenterY);
			float value = Mathf.Round(this._Size / 638f) * 646f;
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Distortion_Flush", value);
			this.ADBKPGFMNKO().SetFloat("_Value2", this._Eyes);
			this.OIMMPLPBLBK().SetVector("Emergency Help:", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x000A7BD3 File Offset: 0x000A5DD3
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x000A7BF7 File Offset: 0x000A5DF7
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000A7C1C File Offset: 0x000A5E1C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1498f)
			{
				this.HBJJOCHGOPH = 1522f;
			}
			this.HNICHJCGJOC().SetFloat("_ExposureAdjustment", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("]", this.CenterX);
			this.PDEAHJPOMEF().SetFloat("#", this.CenterY);
			float value = Mathf.Round(this._Size / 718f) * 1683f;
			this.DEFBJOCJJKF().SetFloat("_TimeX", value);
			this.OIMMPLPBLBK().SetFloat("_Speed", this._Eyes);
			this.LONNIJMNKFB().SetVector("_Value", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000A7D27 File Offset: 0x000A5F27
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("[SaveSystem] Outdated savefile found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x000A7D74 File Offset: 0x000A5F74
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 637f)
			{
				this.HBJJOCHGOPH = 1842f;
			}
			this.NBPKMLMCHFN.SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("EVENT CONFIG [Ctrl+E]", this.CenterX);
			this.EFDEIFCDAFG().SetFloat("No Name", this.CenterY);
			float value = Mathf.Round(this._Size / 1876f) * 282f;
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", value);
			this.PDEAHJPOMEF().SetFloat("music.ogg", this._Eyes);
			this.NBMPPNFKFLB().SetVector("LoadMapCanvas", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x000A7E80 File Offset: 0x000A6080
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1793f)
			{
				this.HBJJOCHGOPH = 1476f;
			}
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("{0}{1}{2}={3}", this.CenterX);
			this.LONNIJMNKFB().SetFloat("_Offsets", this.CenterY);
			float value = Mathf.Round(this._Size / 914f) * 46f;
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", value);
			this.LONNIJMNKFB().SetFloat("ticket", this._Eyes);
			this.NBMPPNFKFLB().SetVector("_NoiseScale", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x000A7F8B File Offset: 0x000A618B
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x000A7FC4 File Offset: 0x000A61C4
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 67f)
			{
				this.HBJJOCHGOPH = 1293f;
			}
			this.LONNIJMNKFB().SetFloat("[PlayerBase] Checkpoint error: ", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.CenterX);
			this.IGIAPKPKGPK().SetFloat("RestartButton", this.CenterY);
			float value = Mathf.Round(this._Size / 155f) * 1146f;
			this.PGPEMMBJOOG().SetFloat("/", value);
			this.ADBKPGFMNKO().SetFloat("\t", this._Eyes);
			this.EPCGJFCCAFH().SetVector("ScreenResolutionPanel", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x000A7F8B File Offset: 0x000A618B
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06001AFA RID: 6906 RVA: 0x000A80CF File Offset: 0x000A62CF
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

	// Token: 0x06001AFB RID: 6907 RVA: 0x000A8108 File Offset: 0x000A6308
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 808f)
			{
				this.HBJJOCHGOPH = 734f;
			}
			this.NBPKMLMCHFN.SetFloat("challenges.", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_ScreenResolution", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("music.ogg", this.CenterY);
			float value = Mathf.Round(this._Size / 1528f) * 304f;
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Blend2Camera_Saturation", value);
			this.PDEAHJPOMEF().SetFloat("1248864821", this._Eyes);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x000A8213 File Offset: 0x000A6413
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x000A824A File Offset: 0x000A644A
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x000A8281 File Offset: 0x000A6481
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x000A82B8 File Offset: 0x000A64B8
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x000A82EF File Offset: 0x000A64EF
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("[PlayerBase] SetPlayerDistance error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x000A8313 File Offset: 0x000A6513
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_Level");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x000A8338 File Offset: 0x000A6538
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1224f)
			{
				this.HBJJOCHGOPH = 732f;
			}
			this.HNICHJCGJOC().SetFloat("selColor", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat(" while connecting to: ", this.CenterX);
			this.DEFBJOCJJKF().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", this.CenterY);
			float value = Mathf.Round(this._Size / 694f) * 1813f;
			this.PGPEMMBJOOG().SetFloat("_Value4", value);
			this.PDEAHJPOMEF().SetFloat("_Value", this._Eyes);
			this.ADBKPGFMNKO().SetVector("[ItemsHandler] No connection to item server: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06001B06 RID: 6918 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x000A8443 File Offset: 0x000A6643
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B08 RID: 6920 RVA: 0x000A787B File Offset: 0x000A5A7B
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x000A847A File Offset: 0x000A667A
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("http");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x000A849E File Offset: 0x000A669E
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x000A84C2 File Offset: 0x000A66C2
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040003B9 RID: 953
	public Shader SCShader;

	// Token: 0x040003BA RID: 954
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003BB RID: 955
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003BC RID: 956
	private Material BJFKDHHMLJH;

	// Token: 0x040003BD RID: 957
	[Range(-1f, 1f)]
	public float CenterX;

	// Token: 0x040003BE RID: 958
	[Range(-1f, 1f)]
	public float CenterY;

	// Token: 0x040003BF RID: 959
	[Range(0f, 10f)]
	public float _Size = 5f;

	// Token: 0x040003C0 RID: 960
	[Range(0.12f, 64f)]
	public float _Eyes = 2f;
}
