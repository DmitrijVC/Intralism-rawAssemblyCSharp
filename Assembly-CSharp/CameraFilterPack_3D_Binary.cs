using System;
using UnityEngine;

// Token: 0x0200001D RID: 29
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Binary")]
public class CameraFilterPack_3D_Binary : MonoBehaviour
{
	// Token: 0x06000591 RID: 1425 RVA: 0x0002D5D2 File Offset: 0x0002B7D2
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0002D60C File Offset: 0x0002B80C
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1195f)
			{
				this.HBJJOCHGOPH = 1492f;
			}
			this.EMDFHOKEGNG().SetFloat("Connection failed: ", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_ScreenResolution", this.Fade);
			this.CEKJODEAMGB().SetFloat("StopMusic", this.FadeFromBinary);
			this.NBPKMLMCHFN.SetFloat("settings.gamemessagesduration", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat(" ", this.MatrixSize);
			this.CEKJODEAMGB().SetColor("FPSToggle", this._MatrixColor);
			this.PGPEMMBJOOG().SetFloat(": ", this.MatrixSpeed * 1122f);
			this.EMDFHOKEGNG().SetFloat("SupportLogger Info: PUN {0}: ", (float)((!this._Visualize) ? 1 : 0));
			this.GKILCDHJFEG().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("HandsCountSlider", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MCDGIILBNIF().SetFloat("Please specify a map name or buildID", 1732f / farClipPlane);
			this.GKILCDHJFEG().SetVector("inventory.itemscash", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 494f, 371f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0002D7BC File Offset: 0x0002B9BC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1510f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.Fade);
			this.GKILCDHJFEG().SetFloat("_Value2", this.FadeFromBinary);
			this.JIBOKBCPDLC().SetFloat("{0:0} hour{1}, ", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("_TimeX", this.MatrixSize);
			this.LENEJAGLCNL().SetColor("_Blue_R", this._MatrixColor);
			this.KGOLDDBHIFN().SetFloat("GroupNameText", this.MatrixSpeed * 152f);
			this.NBPKMLMCHFN.SetFloat("_Fade", (float)((!this._Visualize) ? 0 : 0));
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("_Value2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("_Value", 961f / farClipPlane);
			this.AELJLBOJAIL().SetVector("Keypad", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1102f, 1343f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0002D96C File Offset: 0x0002BB6C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 198f)
			{
				this.HBJJOCHGOPH = 398f;
			}
			this.FLOHGDECHHH().SetFloat("\nv.", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("Warning: Unhandled event ", this.Fade);
			this.EPCGJFCCAFH().SetFloat("<command>", this.FadeFromBinary);
			this.KEMJNOMIPHN().SetFloat("_TimeX", this._FixDistance);
			this.GKILCDHJFEG().SetFloat("catched: ", this.MatrixSize);
			this.JIBOKBCPDLC().SetColor("_ColorRGB", this._MatrixColor);
			this.JIBOKBCPDLC().SetFloat("_Value", this.MatrixSpeed * 1322f);
			this.JIBOKBCPDLC().SetFloat("LivesSlider", (float)((!this._Visualize) ? 0 : 0));
			this.EMDFHOKEGNG().SetFloat("_Offsets", this.LightIntensity);
			this.KEMJNOMIPHN().SetTexture("Gameplay/Base", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BFGNMFCNDBC().SetFloat("StartButton", 697f / farClipPlane);
			this.OIMMPLPBLBK().SetVector("_EdgeThreshold", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1231f, 196f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0002DB1B File Offset: 0x0002BD1B
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("OpGetGameList not sent. LobbyType must be SqlLobby.") as Texture2D);
		this.SCShader = Shader.Find("{0} days ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0002DB71 File Offset: 0x0002BD71
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("RoomDescriptionText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0002DBAC File Offset: 0x0002BDAC
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 934f)
			{
				this.HBJJOCHGOPH = 702f;
			}
			this.NBPKMLMCHFN.SetFloat("Please specify either t or f.", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("/", this.Fade);
			this.EPCGJFCCAFH().SetFloat("HandsCountSlider", this.FadeFromBinary);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this._FixDistance);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_InverChromiLum", this.MatrixSize);
			this.EMDFHOKEGNG().SetColor("_TimeX", this._MatrixColor);
			this.HFBJAOFLCJI().SetFloat(" timeUntilRespawn: ", this.MatrixSpeed * 1028f);
			this.GKILCDHJFEG().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.DKNJGHFLAIF().SetFloat("_Value2", this.LightIntensity);
			this.HEINDEMCGIK().SetTexture("_Offsets", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JIBOKBCPDLC().SetFloat("Particles/Additive", 480f / farClipPlane);
			this.DKNJGHFLAIF().SetVector("Observed type is not serializable: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 662f, 1256f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0002DD5B File Offset: 0x0002BF5B
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Binary1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Binary");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0002DD94 File Offset: 0x0002BF94
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
			this.NBPKMLMCHFN.SetFloat("_DepthLevel", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_FadeFromBinary", this.FadeFromBinary);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_MatrixSize", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("_MatrixColor", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("_MatrixSpeed", this.MatrixSpeed * 2f);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0002DF43 File Offset: 0x0002C143
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("achievements.21.completed.workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0002DF7C File Offset: 0x0002C17C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1371f)
			{
				this.HBJJOCHGOPH = 661f;
			}
			this.MCDGIILBNIF().SetFloat("EventTimeInputField", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("ItemTemplate", this.Fade);
			this.AELJLBOJAIL().SetFloat("maps.", this.FadeFromBinary);
			this.NBPKMLMCHFN.SetFloat("maps.", this._FixDistance);
			this.IGIAPKPKGPK().SetFloat("_Value3", this.MatrixSize);
			this.PGPEMMBJOOG().SetColor("_BorderColor", this._MatrixColor);
			this.OIMMPLPBLBK().SetFloat(",", this.MatrixSpeed * 820f);
			this.CEKJODEAMGB().SetFloat("[PlayerController] ", (float)((!this._Visualize) ? 0 : 0));
			this.KEMJNOMIPHN().SetFloat("_Value", this.LightIntensity);
			this.KGOLDDBHIFN().SetTexture("FileMenu", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("Please specify either t or f.", 1987f / farClipPlane);
			this.LPMLLJKMAMP().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 770f, 1321f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0002E12C File Offset: 0x0002C32C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 211f)
			{
				this.HBJJOCHGOPH = 1646f;
			}
			this.LENEJAGLCNL().SetFloat("_Green_B", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_TimeX", this.Fade);
			this.AELJLBOJAIL().SetFloat(". Name: ", this.FadeFromBinary);
			this.DKNJGHFLAIF().SetFloat("<b>#", this._FixDistance);
			this.CEKJODEAMGB().SetFloat("finished", this.MatrixSize);
			this.IGIAPKPKGPK().SetColor(". Possible scene loading in progress?", this._MatrixColor);
			this.BFGNMFCNDBC().SetFloat("Tab2Content", this.MatrixSpeed * 1239f);
			this.FLOHGDECHHH().SetFloat("settings.selectormapsperpage", (float)((!this._Visualize) ? 1 : 0));
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack_eyes_vision_1", this.LightIntensity);
			this.DKNJGHFLAIF().SetTexture("_FarCamera", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack/Broken_Screen", 1793f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("_PixelsPerMeterAtOneMeter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1475f, 1192f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0002E2DB File Offset: 0x0002C4DB
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0002E312 File Offset: 0x0002C512
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0002E349 File Offset: 0x0002C549
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("GhostFade") as Texture2D);
		this.SCShader = Shader.Find("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0002E382 File Offset: 0x0002C582
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("Bad parameters for setbool! Use <key> <value>") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Flag");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0002E3BB File Offset: 0x0002C5BB
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.selectedplaymode") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/TV_Vintage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x0002E3F4 File Offset: 0x0002C5F4
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x0002E42B File Offset: 0x0002C62B
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0002E462 File Offset: 0x0002C662
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0002E49C File Offset: 0x0002C69C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 1370f;
			}
			this.EMDFHOKEGNG().SetFloat("_Saturation", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("BloomShaderValueSlider", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_FgOverlap", this.FadeFromBinary);
			this.LPMLLJKMAMP().SetFloat("_Blue_B", this._FixDistance);
			this.MCDGIILBNIF().SetFloat(" not exist", this.MatrixSize);
			this.DKNJGHFLAIF().SetColor("SUBMIT '{0}' FILES", this._MatrixColor);
			this.BFGNMFCNDBC().SetFloat("PRESS A KEY", this.MatrixSpeed * 1235f);
			this.BFGNMFCNDBC().SetFloat("_History3Weight", (float)((!this._Visualize) ? 0 : 0));
			this.MCDGIILBNIF().SetFloat("ready", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("#combo", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.PGPEMMBJOOG().SetFloat("/icon", 1397f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1845f, 1541f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0002E64B File Offset: 0x0002C84B
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

	// Token: 0x060005B6 RID: 1462 RVA: 0x0002E682 File Offset: 0x0002C882
	private void ICILLMAKLMI()
	{
		this.FPHEBLMINDA = (Resources.Load("Coord") as Texture2D);
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0002E6BB File Offset: 0x0002C8BB
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1942f)
			{
				this.HBJJOCHGOPH = 81f;
			}
			this.JFDGLLEOPGB().SetFloat(" Time: ", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat(" - GameWebCallback] - ", this.Fade);
			this.NBPKMLMCHFN.SetFloat("VIGNETTE_FILMIC", this.FadeFromBinary);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("/icon", this.MatrixSize);
			this.AELJLBOJAIL().SetColor("Set Particles Speed", this._MatrixColor);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.MatrixSpeed * 292f);
			this.GKILCDHJFEG().SetFloat("RecordButton", (float)((!this._Visualize) ? 0 : 1));
			this.DKNJGHFLAIF().SetFloat("mapselector.filter.favoriteonly", this.LightIntensity);
			this.EMDFHOKEGNG().SetTexture("CameraFilterPack/Color_RGB", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIMMPLPBLBK().SetFloat("BadgeText", 995f / farClipPlane);
			this.DKNJGHFLAIF().SetVector("setbool", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1413f, 1611f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0002E8A3 File Offset: 0x0002CAA3
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0002E8DC File Offset: 0x0002CADC
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 789f;
			}
			this.EPCGJFCCAFH().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("isVisible", this.Fade);
			this.AELJLBOJAIL().SetFloat("Use ticket: ", this.FadeFromBinary);
			this.NBPKMLMCHFN.SetFloat("_Value", this._FixDistance);
			this.OCHJIMJNEMO().SetFloat("GlassDistortion", this.MatrixSize);
			this.LPMLLJKMAMP().SetColor("_EdgeThresholdMin", this._MatrixColor);
			this.JFDGLLEOPGB().SetFloat("There is already a virtual axis named ", this.MatrixSpeed * 780f);
			this.OCHJIMJNEMO().SetFloat("[MapEditor] Loading events...", (float)((!this._Visualize) ? 1 : 1));
			this.HEINDEMCGIK().SetFloat("Can't find key ", this.LightIntensity);
			this.LENEJAGLCNL().SetTexture("Mouse Y", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLOHGDECHHH().SetFloat("_ScreenResolution", 187f / farClipPlane);
			this.FLOHGDECHHH().SetVector("_ChannelMixerRed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1065f, 1332f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0002EA8B File Offset: 0x0002CC8B
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0002EAC2 File Offset: 0x0002CCC2
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0002EAF9 File Offset: 0x0002CCF9
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0002EB30 File Offset: 0x0002CD30
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0002EB67 File Offset: 0x0002CD67
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0002EB9E File Offset: 0x0002CD9E
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x0002EC41 File Offset: 0x0002CE41
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("BadgeText") as Texture2D);
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x0002EC7A File Offset: 0x0002CE7A
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0002ECB1 File Offset: 0x0002CEB1
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Sensitivity") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0002ECEA File Offset: 0x0002CEEA
	private void AEDDNDHCLNN()
	{
		this.FPHEBLMINDA = (Resources.Load("No Dispatcher exists in the scene. Actions will not be invoked!") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0002ED24 File Offset: 0x0002CF24
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1715f)
			{
				this.HBJJOCHGOPH = 949f;
			}
			this.OIMMPLPBLBK().SetFloat("visible", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_AlphaHexa", this.Fade);
			this.FLOHGDECHHH().SetFloat("CameraFilterPack/Drawing_Manga_Flash", this.FadeFromBinary);
			this.IGIAPKPKGPK().SetFloat("_TimeX", this._FixDistance);
			this.JIBOKBCPDLC().SetFloat("Mouse Wheel Up", this.MatrixSize);
			this.JIBOKBCPDLC().SetColor("Found best region: '", this._MatrixColor);
			this.IGIAPKPKGPK().SetFloat("SpectatingUserInfo", this.MatrixSpeed * 1201f);
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack/FX_Glitch1", (float)((!this._Visualize) ? 1 : 0));
			this.HFBJAOFLCJI().SetFloat("_TimeX", this.LightIntensity);
			this.EMDFHOKEGNG().SetTexture("InventoryButton", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HFBJAOFLCJI().SetFloat("Misses:", 1559f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("tagElement", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 605f, 1727f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0002EED4 File Offset: 0x0002D0D4
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 7f)
			{
				this.HBJJOCHGOPH = 1252f;
			}
			this.BFGNMFCNDBC().SetFloat("#join", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_Distortion", this.Fade);
			this.HEINDEMCGIK().SetFloat("ChatHistoryInputField", this.FadeFromBinary);
			this.OIMMPLPBLBK().SetFloat("Received event Leave for unknown player ID: {0}", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("_MaxVelocity", this.MatrixSize);
			this.LPMLLJKMAMP().SetColor("AddEnvironmentObject", this._MatrixColor);
			this.AELJLBOJAIL().SetFloat("Down", this.MatrixSpeed * 719f);
			this.LPMLLJKMAMP().SetFloat("tintColor", (float)((!this._Visualize) ? 1 : 1));
			this.EPCGJFCCAFH().SetFloat("settings.enableselectormusic", this.LightIntensity);
			this.IGIAPKPKGPK().SetTexture("Source directory does not exist or could not be found: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_TimeX", 707f / farClipPlane);
			this.LENEJAGLCNL().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1631f, 25f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x0002F083 File Offset: 0x0002D283
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load(".icon") as Texture2D);
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0002F0BC File Offset: 0x0002D2BC
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 181f)
			{
				this.HBJJOCHGOPH = 1900f;
			}
			this.EPCGJFCCAFH().SetFloat("_History3LumaTex", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("_TimeX", this.Fade);
			this.OCHJIMJNEMO().SetFloat("[Left]", this.FadeFromBinary);
			this.NBPKMLMCHFN.SetFloat("[LevelEditorScene] Map submitted!", this._FixDistance);
			this.HEINDEMCGIK().SetFloat("MenuScene", this.MatrixSize);
			this.IGIAPKPKGPK().SetColor("Connection error: ", this._MatrixColor);
			this.JIBOKBCPDLC().SetFloat("#onfirstranktext", this.MatrixSpeed * 5f);
			this.KGOLDDBHIFN().SetFloat("_RedAmplifier", (float)((!this._Visualize) ? 0 : 1));
			this.MCDGIILBNIF().SetFloat("quit", this.LightIntensity);
			this.IGIAPKPKGPK().SetTexture("[MapsEditor] Creating new item...", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GKILCDHJFEG().SetFloat("G:", 1424f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1917f, 1244f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0002F26C File Offset: 0x0002D46C
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 295f)
			{
				this.HBJJOCHGOPH = 1891f;
			}
			this.EMDFHOKEGNG().SetFloat("_BlendTex", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("SendVacantViewIds()", this.Fade);
			this.FLOHGDECHHH().SetFloat("_TimeX", this.FadeFromBinary);
			this.JFDGLLEOPGB().SetFloat("other.dust0", this._FixDistance);
			this.FLOHGDECHHH().SetFloat("_ScreenResolution", this.MatrixSize);
			this.BFGNMFCNDBC().SetColor("CameraFilterPack/Blend2Camera_VividLight", this._MatrixColor);
			this.OCHJIMJNEMO().SetFloat("achievements.21.progress", this.MatrixSpeed * 1188f);
			this.FLOHGDECHHH().SetFloat("_SunThreshold", (float)((!this._Visualize) ? 0 : 1));
			this.MCDGIILBNIF().SetFloat("_ScreenResolution", this.LightIntensity);
			this.HFBJAOFLCJI().SetTexture("_VignetteColor", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LENEJAGLCNL().SetFloat("_Offsets", 752f / farClipPlane);
			this.EPCGJFCCAFH().SetVector("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 186f, 1208f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x0002F41B File Offset: 0x0002D61B
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("BackButton") as Texture2D);
		this.SCShader = Shader.Find("_Red_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0002F454 File Offset: 0x0002D654
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/FX_Glitch3") as Texture2D);
		this.SCShader = Shader.Find("SetParticlesParticleSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x0002F48D File Offset: 0x0002D68D
	private void FMFNILJIEIA()
	{
		this.FPHEBLMINDA = (Resources.Load("quit") as Texture2D);
		this.SCShader = Shader.Find("JoinRandom failed: {0}.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0002F4C6 File Offset: 0x0002D6C6
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0002F4FD File Offset: 0x0002D6FD
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0002F534 File Offset: 0x0002D734
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1422f)
			{
				this.HBJJOCHGOPH = 384f;
			}
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/FX_Funk", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.Fade);
			this.KGOLDDBHIFN().SetFloat("LevelNameInputField", this.FadeFromBinary);
			this.FLOHGDECHHH().SetFloat("mapselector.filter.rateduponly", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("#or", this.MatrixSize);
			this.FLOHGDECHHH().SetColor("restrictions\n\n#until: ", this._MatrixColor);
			this.PGPEMMBJOOG().SetFloat("_EmissionColor", this.MatrixSpeed * 1550f);
			this.KGOLDDBHIFN().SetFloat("getbool", (float)((!this._Visualize) ? 0 : 1));
			this.PGPEMMBJOOG().SetFloat("ItemNameText", this.LightIntensity);
			this.JFDGLLEOPGB().SetTexture("76561198041679481", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BFGNMFCNDBC().SetFloat(",", 1276f / farClipPlane);
			this.JIBOKBCPDLC().SetVector("CameraFilterPack/Blend2Camera_Saturation", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1382f, 1081f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0002F6E3 File Offset: 0x0002D8E3
	private void MNBPNHNAEBK()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0002F71C File Offset: 0x0002D91C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1026f)
			{
				this.HBJJOCHGOPH = 414f;
			}
			this.DKNJGHFLAIF().SetFloat("[MapsData] Caching ", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("materialsitemid[", this.Fade);
			this.KGOLDDBHIFN().SetFloat("_FadeShield", this.FadeFromBinary);
			this.HEINDEMCGIK().SetFloat("VHS", this._FixDistance);
			this.EMDFHOKEGNG().SetFloat("seconds", this.MatrixSize);
			this.JFDGLLEOPGB().SetColor(",0", this._MatrixColor);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_Lighten", this.MatrixSpeed * 1608f);
			this.FLOHGDECHHH().SetFloat("w", (float)((!this._Visualize) ? 0 : 0));
			this.HFBJAOFLCJI().SetFloat("_Amount", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("Tab1Content", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DKNJGHFLAIF().SetFloat("_Value2", 522f / farClipPlane);
			this.LENEJAGLCNL().SetVector("LevelURLInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 289f, 70f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0002F8CC File Offset: 0x0002DACC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 149f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Real_VHS", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_TileTexDebug", this.Fade);
			this.GKILCDHJFEG().SetFloat("_Intensity", this.FadeFromBinary);
			this.HFBJAOFLCJI().SetFloat("_TimeX", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("player.blackcat", this.MatrixSize);
			this.BFGNMFCNDBC().SetColor("_FresnelFadePower", this._MatrixColor);
			this.DKNJGHFLAIF().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", this.MatrixSpeed * 1312f);
			this.GKILCDHJFEG().SetFloat("resetall", (float)((!this._Visualize) ? 1 : 0));
			this.PGPEMMBJOOG().SetFloat("LevelInfoInputField", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("inventory.itemscash", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat(": ", 188f / farClipPlane);
			this.CEKJODEAMGB().SetVector("color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1177f, 171f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0002FA7C File Offset: 0x0002DC7C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 211f)
			{
				this.HBJJOCHGOPH = 227f;
			}
			this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("#md5submitionfailed: ", this.Fade);
			this.BFGNMFCNDBC().SetFloat("_ScreenResolution", this.FadeFromBinary);
			this.AELJLBOJAIL().SetFloat("maps.", this._FixDistance);
			this.LENEJAGLCNL().SetFloat("_BorderColor", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("#ok", this._MatrixColor);
			this.KGOLDDBHIFN().SetFloat("EVENT CONFIG [Ctrl+E]", this.MatrixSpeed * 398f);
			this.KEMJNOMIPHN().SetFloat("_Value4", (float)((!this._Visualize) ? 1 : 1));
			this.FLOHGDECHHH().SetFloat(".lastCheckpoint.maxLongestCombo", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("_TimeX", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("[FileSelector] Dialog canceled", 605f / farClipPlane);
			this.GKILCDHJFEG().SetVector("L1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 563f, 1555f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0002FC2B File Offset: 0x0002DE2B
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0002FC62 File Offset: 0x0002DE62
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/TV_Distorted") as Texture2D);
		this.SCShader = Shader.Find("Please specify a map name or buildID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0002FC9B File Offset: 0x0002DE9B
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0002FCD2 File Offset: 0x0002DED2
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load(".") as Texture2D);
		this.SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0002DB54 File Offset: 0x0002BD54
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0002FD0B File Offset: 0x0002DF0B
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x0002FD44 File Offset: 0x0002DF44
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1058f)
			{
				this.HBJJOCHGOPH = 1890f;
			}
			this.HFBJAOFLCJI().SetFloat("settings_bindings_controller_type", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("visible", this.Fade);
			this.LPMLLJKMAMP().SetFloat("SetSatelliteInput", this.FadeFromBinary);
			this.EMDFHOKEGNG().SetFloat("_VignetteTex", this._FixDistance);
			this.IGIAPKPKGPK().SetFloat("_TimeX", this.MatrixSize);
			this.EPCGJFCCAFH().SetColor("SSAARenderTargetCamera", this._MatrixColor);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.MatrixSpeed * 502f);
			this.BFGNMFCNDBC().SetFloat(".r", (float)((!this._Visualize) ? 0 : 1));
			this.OCHJIMJNEMO().SetFloat("_TimeX", this.LightIntensity);
			this.IGIAPKPKGPK().SetTexture("PLEASE WAIT", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("BitsData", 1477f / farClipPlane);
			this.AELJLBOJAIL().SetVector("uploads/Intralism/mods_terms.pdf", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1518f, 768f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 267f)
			{
				this.HBJJOCHGOPH = 1787f;
			}
			this.AELJLBOJAIL().SetFloat("#mapnotloaded", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("Internal LUT", this.Fade);
			this.LENEJAGLCNL().SetFloat("_Green_R", this.FadeFromBinary);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/AAA_WaterDropPro", this._FixDistance);
			this.MCDGIILBNIF().SetFloat(": ", this.MatrixSize);
			this.CEKJODEAMGB().SetColor("The given 2D texture ", this._MatrixColor);
			this.JFDGLLEOPGB().SetFloat("float,0", this.MatrixSpeed * 1707f);
			this.AELJLBOJAIL().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.OCHJIMJNEMO().SetFloat("[Right]", this.LightIntensity);
			this.CEKJODEAMGB().SetTexture("StartButton", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EMDFHOKEGNG().SetFloat("MusicFileSelector", 494f / farClipPlane);
			this.CEKJODEAMGB().SetVector("_Red_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1491f, 558f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x000300A3 File Offset: 0x0002E2A3
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040000D7 RID: 215
	public Shader SCShader;

	// Token: 0x040000D8 RID: 216
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000D9 RID: 217
	public bool _Visualize;

	// Token: 0x040000DA RID: 218
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000DB RID: 219
	private Material BJFKDHHMLJH;

	// Token: 0x040000DC RID: 220
	[Range(0f, 100f)]
	public float _FixDistance = 2f;

	// Token: 0x040000DD RID: 221
	[Range(-5f, 5f)]
	public float LightIntensity;

	// Token: 0x040000DE RID: 222
	[Range(0f, 8f)]
	public float MatrixSize = 2f;

	// Token: 0x040000DF RID: 223
	[Range(-4f, 4f)]
	public float MatrixSpeed = 1f;

	// Token: 0x040000E0 RID: 224
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040000E1 RID: 225
	[Range(0f, 1f)]
	public float FadeFromBinary;

	// Token: 0x040000E2 RID: 226
	public Color _MatrixColor = new Color(1f, 0.3f, 0.3f, 1f);

	// Token: 0x040000E3 RID: 227
	public static Color ChangeColorRGB;

	// Token: 0x040000E4 RID: 228
	private Texture2D FPHEBLMINDA;
}
