using System;
using UnityEngine;

// Token: 0x0200002C RID: 44
[AddComponentMenu("Camera Filter Pack/AAA/Blood_Plus")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood_Plus : MonoBehaviour
{
	// Token: 0x06000B5D RID: 2909 RVA: 0x00055346 File Offset: 0x00053546
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0005537D File Offset: 0x0005357D
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000553B4 File Offset: 0x000535B4
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

	// Token: 0x06000B60 RID: 2912 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x000553EC File Offset: 0x000535EC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 594f)
			{
				this.HBJJOCHGOPH = 885f;
			}
			this.GCDFNHMJMIP().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("menu.enableselectormusic", this.LightReflect);
			this.GCDFNHMJMIP().SetFloat("SetSatelliteTrailWidth", Mathf.Clamp(this.Blood_1, 1514f, 1579f));
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack_TV_BrokenGlass_2", Mathf.Clamp(this.Blood_2, 1463f, 188f));
			this.PDEAHJPOMEF().SetFloat("_SampleScale", Mathf.Clamp(this.Blood_3, 442f, 723f));
			this.PGPEMMBJOOG().SetFloat("st", Mathf.Clamp(this.Blood_4, 70f, 1842f));
			this.KGOLDDBHIFN().SetFloat("_MatrixSize", Mathf.Clamp(this.Blood_5, 775f, 1100f));
			this.KGOLDDBHIFN().SetFloat("float,0", Mathf.Clamp(this.Blood_6, 1821f, 1251f));
			this.IONHGBPGCHK().SetFloat("steamid", Mathf.Clamp(this.Blood_7, 680f, 1603f));
			this.IONHGBPGCHK().SetFloat("VIGNETTE_DESAT", Mathf.Clamp(this.Blood_8, 198f, 280f));
			this.NBPKMLMCHFN.SetFloat("Uploading content...", Mathf.Clamp(this.Blood_9, 166f, 1739f));
			this.NBPKMLMCHFN.SetFloat("Hidden/DepthOfField/BokehSplatting", Mathf.Clamp(this.Blood_10, 1006f, 1579f));
			this.EFDEIFCDAFG().SetFloat("#yes", Mathf.Clamp(this.Blood_11, 1564f, 920f));
			this.PDEAHJPOMEF().SetFloat("_Value3", Mathf.Clamp(this.Blood_12, 664f, 219f));
			this.IONHGBPGCHK().SetTexture("LevelURLInputField", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0005564E File Offset: 0x0005384E
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0005564E File Offset: 0x0005384E
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00055694 File Offset: 0x00053894
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(this.Blood_1, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(this.Blood_2, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Blood_3, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(this.Blood_4, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value6", Mathf.Clamp(this.Blood_5, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value7", Mathf.Clamp(this.Blood_6, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value8", Mathf.Clamp(this.Blood_7, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value9", Mathf.Clamp(this.Blood_8, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value10", Mathf.Clamp(this.Blood_9, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value11", Mathf.Clamp(this.Blood_10, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value12", Mathf.Clamp(this.Blood_11, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value13", Mathf.Clamp(this.Blood_12, 0f, 1f));
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x000558F6 File Offset: 0x00053AF6
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x0005564E File Offset: 0x0005384E
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00055930 File Offset: 0x00053B30
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1750f)
			{
				this.HBJJOCHGOPH = 809f;
			}
			this.HNICHJCGJOC().SetFloat("Feb", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Visualize", this.LightReflect);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/Antialiasing_FXAA", Mathf.Clamp(this.Blood_1, 246f, 1429f));
			this.HNICHJCGJOC().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", Mathf.Clamp(this.Blood_2, 1765f, 1951f));
			this.PGPEMMBJOOG().SetFloat(" ", Mathf.Clamp(this.Blood_3, 1912f, 258f));
			this.HNICHJCGJOC().SetFloat("_Amount", Mathf.Clamp(this.Blood_4, 965f, 1795f));
			this.HNICHJCGJOC().SetFloat("Scene", Mathf.Clamp(this.Blood_5, 1932f, 1149f));
			this.IONHGBPGCHK().SetFloat("AskForPickupItemSpawnTimes", Mathf.Clamp(this.Blood_6, 1233f, 1515f));
			this.NBPKMLMCHFN.SetFloat("SetCrosshairEmission", Mathf.Clamp(this.Blood_7, 1520f, 1533f));
			this.GCDFNHMJMIP().SetFloat(": ", Mathf.Clamp(this.Blood_8, 1924f, 223f));
			this.IONHGBPGCHK().SetFloat("ZoomSpeed", Mathf.Clamp(this.Blood_9, 725f, 1417f));
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Mathf.Clamp(this.Blood_10, 1972f, 329f));
			this.NBPKMLMCHFN.SetFloat(" url: ", Mathf.Clamp(this.Blood_11, 1669f, 1893f));
			this.NFMGLIKNOOC().SetFloat("Case-Sensitive", Mathf.Clamp(this.Blood_12, 152f, 1384f));
			this.PGPEMMBJOOG().SetTexture("maps.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00055B92 File Offset: 0x00053D92
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00055BC9 File Offset: 0x00053DC9
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00055C00 File Offset: 0x00053E00
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button2") as Texture2D);
		this.SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00055C39 File Offset: 0x00053E39
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("mapselector.orderby") as Texture2D);
		this.SCShader = Shader.Find("Left Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00055C72 File Offset: 0x00053E72
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("_VelocityScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x0005564E File Offset: 0x0005384E
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00055CAC File Offset: 0x00053EAC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1091f)
			{
				this.HBJJOCHGOPH = 1627f;
			}
			this.PDEAHJPOMEF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("HightScoreMaxPointsText", this.LightReflect);
			this.HNICHJCGJOC().SetFloat("duration", Mathf.Clamp(this.Blood_1, 312f, 966f));
			this.PGPEMMBJOOG().SetFloat("float,1.5", Mathf.Clamp(this.Blood_2, 1158f, 721f));
			this.PGPEMMBJOOG().SetFloat("[PlayerController] ", Mathf.Clamp(this.Blood_3, 1525f, 1828f));
			this.KGOLDDBHIFN().SetFloat("Keypad", Mathf.Clamp(this.Blood_4, 75f, 289f));
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] Checkpoint error: ", Mathf.Clamp(this.Blood_5, 642f, 1649f));
			this.IONHGBPGCHK().SetFloat("_Linecount", Mathf.Clamp(this.Blood_6, 465f, 1730f));
			this.NFMGLIKNOOC().SetFloat("#alreadystarted", Mathf.Clamp(this.Blood_7, 1388f, 1332f));
			this.IONHGBPGCHK().SetFloat("Ignored PU RPC, cause item is inactive. ", Mathf.Clamp(this.Blood_8, 1531f, 198f));
			this.GCDFNHMJMIP().SetFloat("mapselector.filter.rateduponly", Mathf.Clamp(this.Blood_9, 744f, 1425f));
			this.PDEAHJPOMEF().SetFloat("Could not execute RPC ", Mathf.Clamp(this.Blood_10, 1680f, 1319f));
			this.PGPEMMBJOOG().SetFloat("SetSunLerpSpeed", Mathf.Clamp(this.Blood_11, 469f, 1767f));
			this.PGPEMMBJOOG().SetFloat("original.tutorial", Mathf.Clamp(this.Blood_12, 7f, 1644f));
			this.EFDEIFCDAFG().SetTexture("Moved event", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00055F0E File Offset: 0x0005410E
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00055F47 File Offset: 0x00054147
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x0005564E File Offset: 0x0005384E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x0005564E File Offset: 0x0005384E
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x0005564E File Offset: 0x0005384E
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00055F80 File Offset: 0x00054180
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_Blood2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Plus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x00055FB9 File Offset: 0x000541B9
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x00055FF0 File Offset: 0x000541F0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1109f)
			{
				this.HBJJOCHGOPH = 611f;
			}
			this.NBPKMLMCHFN.SetFloat(": ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("EditMenu", this.LightReflect);
			this.NBPKMLMCHFN.SetFloat("PhotonServerSettings", Mathf.Clamp(this.Blood_1, 1438f, 1599f));
			this.IONHGBPGCHK().SetFloat("_InternalLutTex", Mathf.Clamp(this.Blood_2, 547f, 511f));
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Light_Rainbow", Mathf.Clamp(this.Blood_3, 353f, 54f));
			this.PDEAHJPOMEF().SetFloat("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", Mathf.Clamp(this.Blood_4, 380f, 424f));
			this.NBPKMLMCHFN.SetFloat("/", Mathf.Clamp(this.Blood_5, 1702f, 5f));
			this.HNICHJCGJOC().SetFloat("<color=white>", Mathf.Clamp(this.Blood_6, 1057f, 392f));
			this.HNICHJCGJOC().SetFloat("_OnOff", Mathf.Clamp(this.Blood_7, 839f, 40f));
			this.GCDFNHMJMIP().SetFloat("_Value", Mathf.Clamp(this.Blood_8, 1995f, 1596f));
			this.KGOLDDBHIFN().SetFloat("_Distortion", Mathf.Clamp(this.Blood_9, 82f, 1933f));
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack_Glasses_On6", Mathf.Clamp(this.Blood_10, 1377f, 1711f));
			this.PGPEMMBJOOG().SetFloat("_TimeX", Mathf.Clamp(this.Blood_11, 371f, 1362f));
			this.PDEAHJPOMEF().SetFloat("received</b>\n#reason: ", Mathf.Clamp(this.Blood_12, 1591f, 1904f));
			this.KGOLDDBHIFN().SetTexture("Please attach component to a Graphical UI component", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x00056254 File Offset: 0x00054454
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1534f)
			{
				this.HBJJOCHGOPH = 1654f;
			}
			this.IONHGBPGCHK().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("SetParticlesInput", this.LightReflect);
			this.PGPEMMBJOOG().SetFloat("SaveButton", Mathf.Clamp(this.Blood_1, 1075f, 1367f));
			this.PGPEMMBJOOG().SetFloat("_TimeX", Mathf.Clamp(this.Blood_2, 1251f, 926f));
			this.HNICHJCGJOC().SetFloat("PlayButton", Mathf.Clamp(this.Blood_3, 558f, 1372f));
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/Blur_Movie", Mathf.Clamp(this.Blood_4, 364f, 890f));
			this.KGOLDDBHIFN().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", Mathf.Clamp(this.Blood_5, 1039f, 751f));
			this.EFDEIFCDAFG().SetFloat("_Distortion", Mathf.Clamp(this.Blood_6, 853f, 1004f));
			this.IONHGBPGCHK().SetFloat("_MainTex2", Mathf.Clamp(this.Blood_7, 1948f, 498f));
			this.GCDFNHMJMIP().SetFloat("_Value4", Mathf.Clamp(this.Blood_8, 226f, 43f));
			this.PGPEMMBJOOG().SetFloat("EventMenu", Mathf.Clamp(this.Blood_9, 168f, 1193f));
			this.PDEAHJPOMEF().SetFloat("_Color", Mathf.Clamp(this.Blood_10, 658f, 1627f));
			this.NBPKMLMCHFN.SetFloat("_LoopCount", Mathf.Clamp(this.Blood_11, 190f, 1771f));
			this.NBPKMLMCHFN.SetFloat("_Value", Mathf.Clamp(this.Blood_12, 325f, 389f));
			this.NFMGLIKNOOC().SetTexture("CameraFilterPack_eyes_vision_2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x000564B6 File Offset: 0x000546B6
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x000564ED File Offset: 0x000546ED
	private void BEBNOKFLJPH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Glitch") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x0005564E File Offset: 0x0005384E
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00056528 File Offset: 0x00054728
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 532f)
			{
				this.HBJJOCHGOPH = 170f;
			}
			this.GCDFNHMJMIP().SetFloat("GlassesColor", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("SetSpeed", this.LightReflect);
			this.NFMGLIKNOOC().SetFloat("_BlurVector", Mathf.Clamp(this.Blood_1, 1754f, 85f));
			this.GCDFNHMJMIP().SetFloat("levelcompleted", Mathf.Clamp(this.Blood_2, 151f, 1286f));
			this.KGOLDDBHIFN().SetFloat("_Fade", Mathf.Clamp(this.Blood_3, 1780f, 1111f));
			this.NFMGLIKNOOC().SetFloat("LevelInfoInputField", Mathf.Clamp(this.Blood_4, 1879f, 966f));
			this.IONHGBPGCHK().SetFloat("_Visualize", Mathf.Clamp(this.Blood_5, 1853f, 593f));
			this.PGPEMMBJOOG().SetFloat("rarity", Mathf.Clamp(this.Blood_6, 1834f, 1244f));
			this.KGOLDDBHIFN().SetFloat("_TimeX", Mathf.Clamp(this.Blood_7, 1577f, 1910f));
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Vision_Drost", Mathf.Clamp(this.Blood_8, 660f, 749f));
			this.EFDEIFCDAFG().SetFloat("/theme", Mathf.Clamp(this.Blood_9, 259f, 689f));
			this.NFMGLIKNOOC().SetFloat("#tryagain", Mathf.Clamp(this.Blood_10, 1243f, 534f));
			this.NFMGLIKNOOC().SetFloat("_MainTex", Mathf.Clamp(this.Blood_11, 1326f, 1569f));
			this.KGOLDDBHIFN().SetFloat("ready", Mathf.Clamp(this.Blood_12, 929f, 1232f));
			this.PDEAHJPOMEF().SetTexture("_Value3", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x0005564E File Offset: 0x0005384E
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0005678A File Offset: 0x0005498A
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x0005564E File Offset: 0x0005384E
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x0005564E File Offset: 0x0005384E
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001A7 RID: 423
	public Shader SCShader;

	// Token: 0x040001A8 RID: 424
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001A9 RID: 425
	[Range(0f, 1f)]
	public float Blood_1 = 1f;

	// Token: 0x040001AA RID: 426
	[Range(0f, 1f)]
	public float Blood_2;

	// Token: 0x040001AB RID: 427
	[Range(0f, 1f)]
	public float Blood_3;

	// Token: 0x040001AC RID: 428
	[Range(0f, 1f)]
	public float Blood_4;

	// Token: 0x040001AD RID: 429
	[Range(0f, 1f)]
	public float Blood_5;

	// Token: 0x040001AE RID: 430
	[Range(0f, 1f)]
	public float Blood_6;

	// Token: 0x040001AF RID: 431
	[Range(0f, 1f)]
	public float Blood_7;

	// Token: 0x040001B0 RID: 432
	[Range(0f, 1f)]
	public float Blood_8;

	// Token: 0x040001B1 RID: 433
	[Range(0f, 1f)]
	public float Blood_9;

	// Token: 0x040001B2 RID: 434
	[Range(0f, 1f)]
	public float Blood_10;

	// Token: 0x040001B3 RID: 435
	[Range(0f, 1f)]
	public float Blood_11;

	// Token: 0x040001B4 RID: 436
	[Range(0f, 1f)]
	public float Blood_12;

	// Token: 0x040001B5 RID: 437
	[Range(0f, 1f)]
	public float LightReflect = 0.5f;

	// Token: 0x040001B6 RID: 438
	private Material BJFKDHHMLJH;

	// Token: 0x040001B7 RID: 439
	private Texture2D FPHEBLMINDA;
}
