using System;
using UnityEngine;

// Token: 0x02000026 RID: 38
[AddComponentMenu("Camera Filter Pack/3D/Myst")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Myst : MonoBehaviour
{
	// Token: 0x060008EF RID: 2287 RVA: 0x00043BCC File Offset: 0x00041DCC
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00043C03 File Offset: 0x00041E03
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load(" not exist") as Texture2D);
		this.SCShader = Shader.Find("Working commands:\nreset <challengeid>\nresetall");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00043C3C File Offset: 0x00041E3C
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("_DistortionLevel") as Texture2D);
		this.SCShader = Shader.Find("OxOD.lastPath");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00043C78 File Offset: 0x00041E78
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 230f)
			{
				this.HBJJOCHGOPH = 657f;
			}
			this.OCMBHMLNCEK().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 784f)
				{
					this._Distance = 1735f;
				}
				if (this._Distance < 1301f)
				{
					this._Distance = 1762f;
				}
				this.CECICEGFHKL().SetFloat("SetSpeed", this._Distance);
			}
			else
			{
				this.HKHBBBFLGJH().SetFloat("Reload Maps", this._Distance);
			}
			this.HKIMAANBGMJ().SetFloat("_FarCamera", this._Size);
			this.FEAEGGCNIAA().SetFloat("HPToggle", (float)((!this._Visualize) ? 0 : 0));
			this.KEMJNOMIPHN().SetFloat("levelcompleted", this._FixDistance);
			this.HKIMAANBGMJ().SetFloat(". Check if the server is available.", this.DistortionLevel * 1426f);
			this.LMLENGFLEBD().SetFloat("\n", this.DistortionSize * 319f);
			this.EOCCJGIGEGJ().SetFloat("LB", this.LightIntensity * 130f);
			this.EFDEIFCDAFG().SetTexture("Hex value #RRGGBB", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("y", 679f / farClipPlane);
			this.LMLENGFLEBD().SetVector("[UI] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1437f, 280f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00043EFF File Offset: 0x000420FF
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00043F1C File Offset: 0x0004211C
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 623f)
			{
				this.HBJJOCHGOPH = 1684f;
			}
			this.ADBKPGFMNKO().SetFloat("music", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 730f)
				{
					this._Distance = 1828f;
				}
				if (this._Distance < 5f)
				{
					this._Distance = 559f;
				}
				this.HHLFDHNEIAH().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this._Distance);
			}
			this.FEAEGGCNIAA().SetFloat("GraphicsQualitySlider", this._Size);
			this.HKHBBBFLGJH().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 0));
			this.NBPKMLMCHFN.SetFloat("Please specify either t or f.", this._FixDistance);
			this.HKIMAANBGMJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.DistortionLevel * 1004f);
			this.MFHPKGICPIO().SetFloat("/Assets/MyImage", this.DistortionSize * 1218f);
			this.HFBJAOFLCJI().SetFloat("_MainTex2", this.LightIntensity * 1123f);
			this.HKIMAANBGMJ().SetTexture("[Left]", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("Tab2Content", 1755f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("restart", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1082f, 937f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00043EFF File Offset: 0x000420FF
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00044136 File Offset: 0x00042336
	private void LFAFJKJAEEL()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00044170 File Offset: 0x00042370
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1649f)
			{
				this.HBJJOCHGOPH = 1668f;
			}
			this.ADAFMBOGPLN().SetFloat("Waiting to start", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1331f)
				{
					this._Distance = 222f;
				}
				if (this._Distance < 848f)
				{
					this._Distance = 481f;
				}
				this.EOCCJGIGEGJ().SetFloat("sounds/hit_perfect", this._Distance);
			}
			else
			{
				this.EOCCJGIGEGJ().SetFloat("settings.gamemessagesduration", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("ResetButton", this._Size);
			this.HKHBBBFLGJH().SetFloat("Exit to Windows", (float)((!this._Visualize) ? 1 : 0));
			this.JLHLHKPHDFO().SetFloat("_Value4", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("maps.", this.DistortionLevel * 723f);
			this.NBPKMLMCHFN.SetFloat("menu.tabid", this.DistortionSize * 110f);
			this.HHLFDHNEIAH().SetFloat("_NoiseTilingPerChannel", this.LightIntensity * 1332f);
			this.FEAEGGCNIAA().SetTexture("checkpoint", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CFEDGDGBCHE().SetFloat("curScn", 1789f / farClipPlane);
			this.NMDBCDFPGOK().SetVector("player.quantum", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 741f, 1412f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x0004438A File Offset: 0x0004258A
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00043EFF File Offset: 0x000420FF
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00043EFF File Offset: 0x000420FF
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060008FF RID: 2303 RVA: 0x000443C1 File Offset: 0x000425C1
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

	// Token: 0x06000900 RID: 2304 RVA: 0x000443F8 File Offset: 0x000425F8
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00043EFF File Offset: 0x000420FF
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x0004442F File Offset: 0x0004262F
	private void LFBGJIIECLD()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value8") as Texture2D);
		this.SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00044468 File Offset: 0x00042668
	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 651f)
			{
				this.HBJJOCHGOPH = 1450f;
			}
			this.OCMBHMLNCEK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 307f)
				{
					this._Distance = 1644f;
				}
				if (this._Distance < 1254f)
				{
					this._Distance = 1004f;
				}
				this.NMDBCDFPGOK().SetFloat("[EMPTY]", this._Distance);
			}
			else
			{
				this.GHHPOGODBHB().SetFloat("#000000CC", this._Distance);
			}
			this.NMDBCDFPGOK().SetFloat("_Speed", this._Size);
			this.GHHPOGODBHB().SetFloat("[NetworkManager] Joined room with ", (float)((!this._Visualize) ? 1 : 0));
			this.CFEDGDGBCHE().SetFloat("_FarCamera", this._FixDistance);
			this.MFHPKGICPIO().SetFloat("_TimeX", this.DistortionLevel * 177f);
			this.CFEDGDGBCHE().SetFloat("maps.", this.DistortionSize * 53f);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack_3D_Matrix1", this.LightIntensity * 694f);
			this.HKHBBBFLGJH().SetTexture("_EmissionColor", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("_Near", 796f / farClipPlane);
			this.OCMBHMLNCEK().SetVector("settings.fps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 959f, 762f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00044684 File Offset: 0x00042884
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 19f)
			{
				this.HBJJOCHGOPH = 1671f;
			}
			this.FEAEGGCNIAA().SetFloat("_OcclusionBlurTexture", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 171f)
				{
					this._Distance = 1971f;
				}
				if (this._Distance < 695f)
				{
					this._Distance = 1715f;
				}
				this.HKHBBBFLGJH().SetFloat("Ownership mode == fixed. Ignoring request.", this._Distance);
			}
			else
			{
				this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/TV_WideScreenVertical", this._Distance);
			}
			this.FEAEGGCNIAA().SetFloat("SettingsCanvas", this._Size);
			this.FEAEGGCNIAA().SetFloat("_DiffuseColor", (float)((!this._Visualize) ? 1 : 0));
			this.CFEDGDGBCHE().SetFloat("_TimeX", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("GUICamera", this.DistortionLevel * 11f);
			this.MFHPKGICPIO().SetFloat("/../", this.DistortionSize * 735f);
			this.NBPKMLMCHFN.SetFloat("Curve texture", this.LightIntensity * 1198f);
			this.HHLFDHNEIAH().SetTexture("note.2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("_Speed", 1133f / farClipPlane);
			this.EFDEIFCDAFG().SetVector("_Near", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1092f, 425f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x0004489E File Offset: 0x00042A9E
	private void DBLILJGKGHJ()
	{
		this.FPHEBLMINDA = (Resources.Load("points:") as Texture2D);
		this.SCShader = Shader.Find("_Min");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00043EFF File Offset: 0x000420FF
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x000448D7 File Offset: 0x00042AD7
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Heigh") as Texture2D);
		this.SCShader = Shader.Find("VIGNETTE_FILMIC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00044910 File Offset: 0x00042B10
	private void NEFHGMNAPEP()
	{
		this.FPHEBLMINDA = (Resources.Load("set id") as Texture2D);
		this.SCShader = Shader.Find("View");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00043EFF File Offset: 0x000420FF
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00043EFF File Offset: 0x000420FF
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x0004494C File Offset: 0x00042B4C
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 254f)
			{
				this.HBJJOCHGOPH = 1682f;
			}
			this.GHHPOGODBHB().SetFloat("Tab1Content", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 260f)
				{
					this._Distance = 832f;
				}
				if (this._Distance < 1454f)
				{
					this._Distance = 409f;
				}
				this.EOCCJGIGEGJ().SetFloat("z", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("player.mysteryitem", this._Distance);
			}
			this.GHHPOGODBHB().SetFloat("LivesSlider", this._Size);
			this.CECICEGFHKL().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 1));
			this.HKIMAANBGMJ().SetFloat("14", this._FixDistance);
			this.GHHPOGODBHB().SetFloat("Created by ", this.DistortionLevel * 615f);
			this.HKHBBBFLGJH().SetFloat("ResourceFileSelector", this.DistortionSize * 1246f);
			this.LMLENGFLEBD().SetFloat("_Value2", this.LightIntensity * 1673f);
			this.EOCCJGIGEGJ().SetTexture("ZoomFade", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHLFDHNEIAH().SetFloat("CameraFilterPack/Alien_Vision", 1139f / farClipPlane);
			this.MFHPKGICPIO().SetVector("_InvViewProj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1703f, 53f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x00044B68 File Offset: 0x00042D68
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1287f)
			{
				this.HBJJOCHGOPH = 894f;
			}
			this.HKHBBBFLGJH().SetFloat("Scrollbar", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 356f)
				{
					this._Distance = 789f;
				}
				if (this._Distance < 848f)
				{
					this._Distance = 1839f;
				}
				this.JLHLHKPHDFO().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("CameraFilterPack_VHS2", this._Distance);
			}
			this.HKIMAANBGMJ().SetFloat("/", this._Size);
			this.LMLENGFLEBD().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 0));
			this.CFEDGDGBCHE().SetFloat("_Value6", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat(": ", this.DistortionLevel * 928f);
			this.GCDFNHMJMIP().SetFloat("LastNewsButton", this.DistortionSize * 1001f);
			this.OCMBHMLNCEK().SetFloat("position", this.LightIntensity * 797f);
			this.NBPKMLMCHFN.SetTexture("_Value4", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("settings.cameramovements", 1349f / farClipPlane);
			this.MFHPKGICPIO().SetVector("System.Int64", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1981f, 1584f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x00043EFF File Offset: 0x000420FF
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00044D82 File Offset: 0x00042F82
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00043EFF File Offset: 0x000420FF
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00044DB9 File Offset: 0x00042FB9
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00044DF0 File Offset: 0x00042FF0
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("Multiplayer") as Texture2D);
		this.SCShader = Shader.Find("GameModeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00044E29 File Offset: 0x00043029
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00043EFF File Offset: 0x000420FF
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00044E60 File Offset: 0x00043060
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 662f)
			{
				this.HBJJOCHGOPH = 390f;
			}
			this.MFHPKGICPIO().SetFloat("#task", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 534f)
				{
					this._Distance = 283f;
				}
				if (this._Distance < 156f)
				{
					this._Distance = 1902f;
				}
				this.EFDEIFCDAFG().SetFloat("SetParent", this._Distance);
			}
			else
			{
				this.OCMBHMLNCEK().SetFloat("\n", this._Distance);
			}
			this.KEMJNOMIPHN().SetFloat(": ", this._Size);
			this.NBPKMLMCHFN.SetFloat("colorA", (float)((!this._Visualize) ? 0 : 1));
			this.NMDBCDFPGOK().SetFloat("PerfectHitsScoreText", this._FixDistance);
			this.JLHLHKPHDFO().SetFloat("_MainTex2", this.DistortionLevel * 898f);
			this.ADAFMBOGPLN().SetFloat("<color=#{0}>{1}</color>", this.DistortionSize * 1458f);
			this.JLHLHKPHDFO().SetFloat(" takes from: ", this.LightIntensity * 1723f);
			this.FEAEGGCNIAA().SetTexture("win", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_VividLight", 769f / farClipPlane);
			this.HHLFDHNEIAH().SetVector("RequestForPickupItems", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 893f, 1989f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0004507C File Offset: 0x0004327C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1814f)
			{
				this.HBJJOCHGOPH = 1896f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_Binary", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1358f)
				{
					this._Distance = 1873f;
				}
				if (this._Distance < 1647f)
				{
					this._Distance = 1048f;
				}
				this.EFDEIFCDAFG().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("CameraFilterPack/TV_Chromatical2", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("Bad parameters for setstring! Use <key> <value>", this._Size);
			this.KEMJNOMIPHN().SetFloat("[ResourcesManager] Load text error: not found", (float)((!this._Visualize) ? 0 : 0));
			this.EFDEIFCDAFG().SetFloat("_Intensity", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("[ResourcesManager] Load audio error: ", this.DistortionLevel * 1048f);
			this.JLHLHKPHDFO().SetFloat("Set satellite emission (glow)", this.DistortionSize * 1915f);
			this.HFBJAOFLCJI().SetFloat("PlayMusic", this.LightIntensity * 1437f);
			this.EOCCJGIGEGJ().SetTexture("Joystick1Button2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("offsets", 1718f / farClipPlane);
			this.HKIMAANBGMJ().SetVector("[MapsSystem] Unloading maps resources...", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 997f, 387f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00045296 File Offset: 0x00043496
	private void HPFIHLMKIPF()
	{
		this.FPHEBLMINDA = (Resources.Load("DifficultyBG") as Texture2D);
		this.SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x000452CF File Offset: 0x000434CF
	private void JFJLGJEPEAA()
	{
		this.FPHEBLMINDA = (Resources.Load("NO") as Texture2D);
		this.SCShader = Shader.Find("Run a command for the Localization Servise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00043EFF File Offset: 0x000420FF
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00045308 File Offset: 0x00043508
	private void CFFCLAHMBAA()
	{
		this.FPHEBLMINDA = (Resources.Load("in seconds. 0 - forever") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00045341 File Offset: 0x00043541
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("_NormalAndRoughnessTexture") as Texture2D);
		this.SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x0004537C File Offset: 0x0004357C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 193f)
			{
				this.HBJJOCHGOPH = 861f;
			}
			this.JLHLHKPHDFO().SetFloat("MenuScene", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 621f)
				{
					this._Distance = 1161f;
				}
				if (this._Distance < 1429f)
				{
					this._Distance = 619f;
				}
				this.HFBJAOFLCJI().SetFloat("threshold", this._Distance);
			}
			else
			{
				this.JLHLHKPHDFO().SetFloat("Result for ", this._Distance);
			}
			this.ADAFMBOGPLN().SetFloat("_ProjInfo", this._Size);
			this.CFEDGDGBCHE().SetFloat("00", (float)((!this._Visualize) ? 1 : 0));
			this.NMDBCDFPGOK().SetFloat("Submit", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat(".", this.DistortionLevel * 259f);
			this.JLHLHKPHDFO().SetFloat("_MainTex2", this.DistortionSize * 9f);
			this.ADAFMBOGPLN().SetFloat("[NetworkManager] Exited", this.LightIntensity * 1635f);
			this.NBPKMLMCHFN.SetTexture("USE_DIAG_SEARCH", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HFBJAOFLCJI().SetFloat("_Threshold", 226f / farClipPlane);
			this.EOCCJGIGEGJ().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 680f, 1854f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00045596 File Offset: 0x00043796
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("Set satellite trail width") as Texture2D);
		this.SCShader = Shader.Find("PointsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x000455D0 File Offset: 0x000437D0
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 759f)
			{
				this.HBJJOCHGOPH = 353f;
			}
			this.MFHPKGICPIO().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 221f)
				{
					this._Distance = 704f;
				}
				if (this._Distance < 1545f)
				{
					this._Distance = 1748f;
				}
				this.HKIMAANBGMJ().SetFloat("_BorderColor", this._Distance);
			}
			else
			{
				this.CECICEGFHKL().SetFloat("Done! You are a contributor until: ", this._Distance);
			}
			this.NMDBCDFPGOK().SetFloat("restart", this._Size);
			this.GCDFNHMJMIP().SetFloat("2", (float)((!this._Visualize) ? 1 : 1));
			this.NMDBCDFPGOK().SetFloat("Submition failed", this._FixDistance);
			this.MFHPKGICPIO().SetFloat("KickThePlayer", this.DistortionLevel * 589f);
			this.NMDBCDFPGOK().SetFloat("You need to have a Graphic control (such as an Image) for the list [", this.DistortionSize * 294f);
			this.NBPKMLMCHFN.SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.LightIntensity * 1242f);
			this.EOCCJGIGEGJ().SetTexture("_MainTex2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADAFMBOGPLN().SetFloat("_Value5", 1961f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("(master)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 262f, 98f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00043EFF File Offset: 0x000420FF
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x000457EA File Offset: 0x000439EA
	private void MMMDPANNAIO()
	{
		this.FPHEBLMINDA = (Resources.Load("[NetworkManager] Connected to ") as Texture2D);
		this.SCShader = Shader.Find("SetEnvSpriteImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00045823 File Offset: 0x00043A23
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x0004585C File Offset: 0x00043A5C
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1002f)
			{
				this.HBJJOCHGOPH = 221f;
			}
			this.HHLFDHNEIAH().SetFloat("[ItemsHandler] Loading ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 40f)
				{
					this._Distance = 65f;
				}
				if (this._Distance < 400f)
				{
					this._Distance = 1020f;
				}
				this.GHHPOGODBHB().SetFloat("_Value", this._Distance);
			}
			else
			{
				this.NMDBCDFPGOK().SetFloat("Gameplay/Base", this._Distance);
			}
			this.GHHPOGODBHB().SetFloat("_Value2", this._Size);
			this.ADBKPGFMNKO().SetFloat("_PrevViewProj", (float)((!this._Visualize) ? 0 : 0));
			this.FEAEGGCNIAA().SetFloat("settings.fps", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("settings.volume.menu", this.DistortionLevel * 454f);
			this.EFDEIFCDAFG().SetFloat(".", this.DistortionSize * 216f);
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack/Gradients_NeonGradient", this.LightIntensity * 359f);
			this.HFBJAOFLCJI().SetTexture(" not exist", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("StartButton", 1444f / farClipPlane);
			this.HHLFDHNEIAH().SetVector("restrictions\n\n#until: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 319f, 1192f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00045A78 File Offset: 0x00043C78
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 460f)
			{
				this.HBJJOCHGOPH = 391f;
			}
			this.HKIMAANBGMJ().SetFloat("Unsupported type: ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 688f)
				{
					this._Distance = 849f;
				}
				if (this._Distance < 1895f)
				{
					this._Distance = 960f;
				}
				this.EOCCJGIGEGJ().SetFloat("HightScoreMaxPointsText", this._Distance);
			}
			else
			{
				this.HKIMAANBGMJ().SetFloat("_TimeX", this._Distance);
			}
			this.HKIMAANBGMJ().SetFloat("selector", this._Size);
			this.ADBKPGFMNKO().SetFloat(",0", (float)((!this._Visualize) ? 0 : 0));
			this.KEMJNOMIPHN().SetFloat(" ", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.DistortionLevel * 1414f);
			this.EFDEIFCDAFG().SetFloat("_Visualize", this.DistortionSize * 138f);
			this.HKHBBBFLGJH().SetFloat(".lastCheckpoint.longestComboScore", this.LightIntensity * 12f);
			this.LMLENGFLEBD().SetTexture("SSAARenderTargetCamera", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CECICEGFHKL().SetFloat("AddEnvironmentObject", 1700f / farClipPlane);
			this.MFHPKGICPIO().SetVector("_EmissionColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1638f, 1467f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00043EFF File Offset: 0x000420FF
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00045C92 File Offset: 0x00043E92
	private void JDKHBGDEONK()
	{
		this.FPHEBLMINDA = (Resources.Load("_FrustumCornersWS") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00045CCB File Offset: 0x00043ECB
	private void EDPDMBFLHLP()
	{
		this.FPHEBLMINDA = (Resources.Load("[PlayerBase] SetBGColor error: ") as Texture2D);
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00045D04 File Offset: 0x00043F04
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab2Content") as Texture2D);
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00045D3D File Offset: 0x00043F3D
	private void HPFOFGJPNCI()
	{
		this.FPHEBLMINDA = (Resources.Load("BadgeText") as Texture2D);
		this.SCShader = Shader.Find("settings.showHP");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00043EFF File Offset: 0x000420FF
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00045D76 File Offset: 0x00043F76
	private void IBLGHLNNAHN()
	{
		this.FPHEBLMINDA = (Resources.Load("Received RPC: ") as Texture2D);
		this.SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00045DAF File Offset: 0x00043FAF
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00045DE6 File Offset: 0x00043FE6
	private void JOHOFNKJDEB()
	{
		this.FPHEBLMINDA = (Resources.Load("OneHand") as Texture2D);
		this.SCShader = Shader.Find("Bad parameters for set! Use <language>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00043EFF File Offset: 0x000420FF
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00045E1F File Offset: 0x0004401F
	private void MMPHNFPPEHO()
	{
		this.FPHEBLMINDA = (Resources.Load("DontDestroy") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00045E58 File Offset: 0x00044058
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.playedsolo") as Texture2D);
		this.SCShader = Shader.Find("Set particles start speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00045E91 File Offset: 0x00044091
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00045EC8 File Offset: 0x000440C8
	private void GLEJGFLCLPJ()
	{
		this.FPHEBLMINDA = (Resources.Load("#roomname") as Texture2D);
		this.SCShader = Shader.Find("Received unknown status code: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00045F01 File Offset: 0x00044101
	private void AIBNKIDADPI()
	{
		this.FPHEBLMINDA = (Resources.Load("RecieveChatActionMessage") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00045F3A File Offset: 0x0004413A
	private void BOPKKCAFODF()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button9") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00045F74 File Offset: 0x00044174
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 195f)
			{
				this.HBJJOCHGOPH = 950f;
			}
			this.LMLENGFLEBD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 97f)
				{
					this._Distance = 1558f;
				}
				if (this._Distance < 1036f)
				{
					this._Distance = 587f;
				}
				this.OCMBHMLNCEK().SetFloat("OK", this._Distance);
			}
			else
			{
				this.HKHBBBFLGJH().SetFloat("Tab2Content", this._Distance);
			}
			this.LMLENGFLEBD().SetFloat("[Singleton] An instance of '", this._Size);
			this.NMDBCDFPGOK().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 1));
			this.HHLFDHNEIAH().SetFloat("event", this._FixDistance);
			this.EFDEIFCDAFG().SetFloat("Sets the boolean value of the Auto Focus Input Field property.", this.DistortionLevel * 1021f);
			this.KEMJNOMIPHN().SetFloat("_ClutTex", this.DistortionSize * 1017f);
			this.KEMJNOMIPHN().SetFloat("_MainTex2", this.LightIntensity * 1323f);
			this.KEMJNOMIPHN().SetTexture("_Value", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/FX_EarthQuake", 1114f / farClipPlane);
			this.NMDBCDFPGOK().SetVector("TwoHands", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1976f, 1021f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x0004618E File Offset: 0x0004438E
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("ShowTitle") as Texture2D);
		this.SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x000461C7 File Offset: 0x000443C7
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x000461FE File Offset: 0x000443FE
	private void DNNFHBOOPIN()
	{
		this.FPHEBLMINDA = (Resources.Load("finished") as Texture2D);
		this.SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x00043EFF File Offset: 0x000420FF
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00046237 File Offset: 0x00044437
	private void ALNNIDLFILB()
	{
		this.FPHEBLMINDA = (Resources.Load("settings_bindings_controller_type") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00046270 File Offset: 0x00044470
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1933f)
			{
				this.HBJJOCHGOPH = 1053f;
			}
			this.OCMBHMLNCEK().SetFloat("QuickSave", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1324f)
				{
					this._Distance = 1284f;
				}
				if (this._Distance < 945f)
				{
					this._Distance = 840f;
				}
				this.FEAEGGCNIAA().SetFloat("mapselector.filter.subscribedonly", this._Distance);
			}
			else
			{
				this.OCMBHMLNCEK().SetFloat("_Value2", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("bpmgrid", this._Size);
			this.CFEDGDGBCHE().SetFloat("SetPosition", (float)((!this._Visualize) ? 1 : 1));
			this.NMDBCDFPGOK().SetFloat("ENABLE_DITHERING", this._FixDistance);
			this.CFEDGDGBCHE().SetFloat("Connected to gameserver.", this.DistortionLevel * 1825f);
			this.EFDEIFCDAFG().SetFloat("_Value2", this.DistortionSize * 1790f);
			this.OCMBHMLNCEK().SetFloat("#FFDA44CC", this.LightIntensity * 1427f);
			this.LMLENGFLEBD().SetTexture("[PlayerBase] MapEnd error: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GCDFNHMJMIP().SetFloat("NOISE", 423f / farClipPlane);
			this.EOCCJGIGEGJ().SetVector("AddEnvironmentObject", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 870f, 155f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x0004648A File Offset: 0x0004468A
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x000464C4 File Offset: 0x000446C4
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 703f)
			{
				this.HBJJOCHGOPH = 1278f;
			}
			this.ADAFMBOGPLN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 410f)
				{
					this._Distance = 1264f;
				}
				if (this._Distance < 1192f)
				{
					this._Distance = 1775f;
				}
				this.NMDBCDFPGOK().SetFloat("SpawnObj", this._Distance);
			}
			else
			{
				this.HKIMAANBGMJ().SetFloat("BloomShaderValueSlider", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("settings_bindings_controller_type", this._Size);
			this.ADAFMBOGPLN().SetFloat("shader.future", (float)((!this._Visualize) ? 0 : 1));
			this.HFBJAOFLCJI().SetFloat("_TileMaxOffs", this._FixDistance);
			this.JLHLHKPHDFO().SetFloat("CameraFilterPack/Drawing_Halftone", this.DistortionLevel * 105f);
			this.NBPKMLMCHFN.SetFloat("_BokehParams", this.DistortionSize * 1462f);
			this.EFDEIFCDAFG().SetFloat(" Also make sure to disable sprite packing for this sprite.", this.LightIntensity * 829f);
			this.CECICEGFHKL().SetTexture("HPText", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LMLENGFLEBD().SetFloat("Floating point textures aren't supported on this device ({0})", 1407f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("CameraFilterPack/Oculus_NightVision2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 834f, 1142f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x000466DE File Offset: 0x000448DE
	private void FMNPFCHBLJF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Contrast") as Texture2D);
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x000461C7 File Offset: 0x000443C7
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00043EFF File Offset: 0x000420FF
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00046717 File Offset: 0x00044917
	private void DOFDGBGEDFI()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlurDirectionPacked") as Texture2D);
		this.SCShader = Shader.Find(".lastCheckpoint.perfectHits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00043EFF File Offset: 0x000420FF
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00046750 File Offset: 0x00044950
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 799f)
			{
				this.HBJJOCHGOPH = 1831f;
			}
			this.LMLENGFLEBD().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 115f)
				{
					this._Distance = 779f;
				}
				if (this._Distance < 419f)
				{
					this._Distance = 87f;
				}
				this.ADBKPGFMNKO().SetFloat("_TimeX", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("#random #epic #item", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("_Value4", this._Size);
			this.CECICEGFHKL().SetFloat("_Value3", (float)((!this._Visualize) ? 1 : 1));
			this.OCMBHMLNCEK().SetFloat("_TimeX", this._FixDistance);
			this.JLHLHKPHDFO().SetFloat("_Sensitivity", this.DistortionLevel * 485f);
			this.EFDEIFCDAFG().SetFloat("#", this.DistortionSize * 1250f);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.LightIntensity * 1117f);
			this.EOCCJGIGEGJ().SetTexture("HelpMenu", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("_TimeX", 1346f / farClipPlane);
			this.GHHPOGODBHB().SetVector("Done! You are a contributor until: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 253f, 1847f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x0004696C File Offset: 0x00044B6C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1004f)
			{
				this.HBJJOCHGOPH = 889f;
			}
			this.NMDBCDFPGOK().SetFloat("_Value", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 623f)
				{
					this._Distance = 1176f;
				}
				if (this._Distance < 360f)
				{
					this._Distance = 730f;
				}
				this.HHLFDHNEIAH().SetFloat("ns", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("_Value5", this._Distance);
			}
			this.OCMBHMLNCEK().SetFloat("IconImage", this._Size);
			this.OCMBHMLNCEK().SetFloat("_NoiseAmount", (float)((!this._Visualize) ? 0 : 1));
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this._FixDistance);
			this.ADAFMBOGPLN().SetFloat("\n - NetID: ", this.DistortionLevel * 1856f);
			this.HFBJAOFLCJI().SetFloat("_Noise", this.DistortionSize * 455f);
			this.FEAEGGCNIAA().SetFloat("(from resources)", this.LightIntensity * 1754f);
			this.GCDFNHMJMIP().SetTexture("4,28,true,0", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("Failed to Instantiate prefab: ", 891f / farClipPlane);
			this.HKHBBBFLGJH().SetVector("[Up]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1098f, 1055f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00046B88 File Offset: 0x00044D88
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1609f)
			{
				this.HBJJOCHGOPH = 877f;
			}
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 756f)
				{
					this._Distance = 298f;
				}
				if (this._Distance < 1540f)
				{
					this._Distance = 1714f;
				}
				this.CECICEGFHKL().SetFloat("[#clicktogetreward]", this._Distance);
			}
			else
			{
				this.MFHPKGICPIO().SetFloat("ChallengesButton", this._Distance);
			}
			this.MFHPKGICPIO().SetFloat("MenuScene", this._Size);
			this.EOCCJGIGEGJ().SetFloat("GameScene", (float)((!this._Visualize) ? 0 : 0));
			this.KEMJNOMIPHN().SetFloat("HighScaleShot", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("#.##", this.DistortionLevel * 1004f);
			this.GCDFNHMJMIP().SetFloat("player.deleted", this.DistortionSize * 1339f);
			this.NMDBCDFPGOK().SetFloat("_Value", this.LightIntensity * 949f);
			this.ADBKPGFMNKO().SetTexture("SetSunInput", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", 1588f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("). ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1048f, 1201f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00046DA2 File Offset: 0x00044FA2
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load("\n\n#") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00046DDC File Offset: 0x00044FDC
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
				{
					this._Distance = 1f;
				}
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel * 28f);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize * 16f);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
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

	// Token: 0x0600094F RID: 2383 RVA: 0x00043EFF File Offset: 0x000420FF
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00046FF6 File Offset: 0x000451F6
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00043EFF File Offset: 0x000420FF
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x0004702D File Offset: 0x0004522D
	private void JMEOGJHCONJ()
	{
		this.FPHEBLMINDA = (Resources.Load("\n\n• ") as Texture2D);
		this.SCShader = Shader.Find("ticket.ticket1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00043EFF File Offset: 0x000420FF
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00043EFF File Offset: 0x000420FF
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00047068 File Offset: 0x00045268
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 74f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.HKIMAANBGMJ().SetFloat("_Blue_R", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1419f)
				{
					this._Distance = 504f;
				}
				if (this._Distance < 45f)
				{
					this._Distance = 1451f;
				}
				this.HFBJAOFLCJI().SetFloat("[RanksSystem] Ranks: no need to update", this._Distance);
			}
			else
			{
				this.ADAFMBOGPLN().SetFloat("Cancel", this._Distance);
			}
			this.NMDBCDFPGOK().SetFloat("_Offsets", this._Size);
			this.MFHPKGICPIO().SetFloat("_Value1", (float)((!this._Visualize) ? 1 : 0));
			this.CFEDGDGBCHE().SetFloat("OnRenderImage in Helper called ...", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("EditMenu", this.DistortionLevel * 1173f);
			this.KEMJNOMIPHN().SetFloat("_UserLutParams", this.DistortionSize * 1450f);
			this.FEAEGGCNIAA().SetFloat("buttons", this.LightIntensity * 305f);
			this.GHHPOGODBHB().SetTexture("_Value4", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NMDBCDFPGOK().SetFloat("Hidden/Fast Approximate Anti-aliasing", 1187f / farClipPlane);
			this.ADAFMBOGPLN().SetVector("_ReflectionTexture0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 885f, 112f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00043EFF File Offset: 0x000420FF
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00047284 File Offset: 0x00045484
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 191f)
			{
				this.HBJJOCHGOPH = 84f;
			}
			this.CFEDGDGBCHE().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 60f)
				{
					this._Distance = 1782f;
				}
				if (this._Distance < 1654f)
				{
					this._Distance = 1958f;
				}
				this.HHLFDHNEIAH().SetFloat("menu.playedpage", this._Distance);
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("player.arrow", this._Distance);
			}
			this.OCMBHMLNCEK().SetFloat("_Value", this._Size);
			this.KEMJNOMIPHN().SetFloat("Please attach component to a Graphical UI component", (float)((!this._Visualize) ? 0 : 0));
			this.FEAEGGCNIAA().SetFloat("_TimeX", this._FixDistance);
			this.CECICEGFHKL().SetFloat("_Value4", this.DistortionLevel * 1633f);
			this.EFDEIFCDAFG().SetFloat("custom", this.DistortionSize * 416f);
			this.NBPKMLMCHFN.SetFloat("Can't set MaxPlayers when not in that room.", this.LightIntensity * 14f);
			this.EOCCJGIGEGJ().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ADBKPGFMNKO().SetFloat("float,1.5", 525f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_FadeFromBinary", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1132f, 1200f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x000474A0 File Offset: 0x000456A0
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 566f)
			{
				this.HBJJOCHGOPH = 407f;
			}
			this.GHHPOGODBHB().SetFloat("GUICamera", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1525f)
				{
					this._Distance = 565f;
				}
				if (this._Distance < 171f)
				{
					this._Distance = 1674f;
				}
				this.OCMBHMLNCEK().SetFloat("3d text", this._Distance);
			}
			else
			{
				this.NMDBCDFPGOK().SetFloat(":", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("_MatrixSize", this._Size);
			this.GHHPOGODBHB().SetFloat("ReJoinRoom failed due to offline mode.", (float)((!this._Visualize) ? 1 : 1));
			this.NBPKMLMCHFN.SetFloat("_TimeX", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("downloading", this.DistortionLevel * 229f);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/AAA_Blood_Hit", this.DistortionSize * 1014f);
			this.NBPKMLMCHFN.SetFloat("SetSunColors", this.LightIntensity * 13f);
			this.NMDBCDFPGOK().SetTexture("_Green_R", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_Value", 323f / farClipPlane);
			this.OCMBHMLNCEK().SetVector("CameraFilterPack/Blur_Regular", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 408f, 672f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x000476BA File Offset: 0x000458BA
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x000476F1 File Offset: 0x000458F1
	private void LGHCJCFHEMF()
	{
		this.FPHEBLMINDA = (Resources.Load("value") as Texture2D);
		this.SCShader = Shader.Find("BloodAlternative1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x0004772A File Offset: 0x0004592A
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00047764 File Offset: 0x00045964
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1517f)
			{
				this.HBJJOCHGOPH = 615f;
			}
			this.GCDFNHMJMIP().SetFloat("LoadMapCanvas", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1438f)
				{
					this._Distance = 1014f;
				}
				if (this._Distance < 1843f)
				{
					this._Distance = 1931f;
				}
				this.CFEDGDGBCHE().SetFloat("\n\n#", this._Distance);
			}
			else
			{
				this.EFDEIFCDAFG().SetFloat(". The group number should be at least 1.", this._Distance);
			}
			this.CFEDGDGBCHE().SetFloat("_Color", this._Size);
			this.OCMBHMLNCEK().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", (float)((!this._Visualize) ? 1 : 0));
			this.JLHLHKPHDFO().SetFloat("_Value", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("_History2Weight", this.DistortionLevel * 1014f);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.DistortionSize * 621f);
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/Light_Water2", this.LightIntensity * 1233f);
			this.CECICEGFHKL().SetTexture("_Distortion2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JLHLHKPHDFO().SetFloat("SetSunMaxSize", 1968f / farClipPlane);
			this.LMLENGFLEBD().SetVector("Chat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1364f, 607f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x0004797E File Offset: 0x00045B7E
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x000479B5 File Offset: 0x00045BB5
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00043EFF File Offset: 0x000420FF
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x000479EC File Offset: 0x00045BEC
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Axis") as Texture2D);
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00047A28 File Offset: 0x00045C28
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 376f)
			{
				this.HBJJOCHGOPH = 407f;
			}
			this.ADAFMBOGPLN().SetFloat("_ColorLevel", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1749f)
				{
					this._Distance = 415f;
				}
				if (this._Distance < 1519f)
				{
					this._Distance = 1196f;
				}
				this.HFBJAOFLCJI().SetFloat("1.87", this._Distance);
			}
			else
			{
				this.HKHBBBFLGJH().SetFloat("#no", this._Distance);
			}
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this._Size);
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack/TV_BrokenGlass", (float)((!this._Visualize) ? 0 : 0));
			this.EFDEIFCDAFG().SetFloat("value", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("_Value2", this.DistortionLevel * 619f);
			this.CECICEGFHKL().SetFloat(".message", this.DistortionSize * 1021f);
			this.CECICEGFHKL().SetFloat("s", this.LightIntensity * 1025f);
			this.HKHBBBFLGJH().SetTexture("mapselector.filter.rateduponly", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LMLENGFLEBD().SetFloat("Fade", 448f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("Vertical", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1271f, 641f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00047C42 File Offset: 0x00045E42
	private void PKLOBJHKFEO()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlurVector") as Texture2D);
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00047C7C File Offset: 0x00045E7C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1722f)
			{
				this.HBJJOCHGOPH = 1736f;
			}
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1756f)
				{
					this._Distance = 1617f;
				}
				if (this._Distance < 339f)
				{
					this._Distance = 1258f;
				}
				this.GCDFNHMJMIP().SetFloat(" = ", this._Distance);
			}
			else
			{
				this.CECICEGFHKL().SetFloat("_ScreenResolution", this._Distance);
			}
			this.MFHPKGICPIO().SetFloat("_Value2", this._Size);
			this.MFHPKGICPIO().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", (float)((!this._Visualize) ? 0 : 1));
			this.MFHPKGICPIO().SetFloat(". Name: ", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("Commands for challenges", this.DistortionLevel * 106f);
			this.OCMBHMLNCEK().SetFloat("CameraFilterPack/Oculus_NightVision2", this.DistortionSize * 1505f);
			this.GHHPOGODBHB().SetFloat("mapselector.filter.favoriteonly", this.LightIntensity * 143f);
			this.OCMBHMLNCEK().SetTexture("_Value2", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", 1478f / farClipPlane);
			this.HHLFDHNEIAH().SetVector("GlassDistortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 1242f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00047E96 File Offset: 0x00046096
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load(" scene view IDs from last level.") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00047ECF File Offset: 0x000460CF
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00047F08 File Offset: 0x00046108
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1223f)
			{
				this.HBJJOCHGOPH = 1843f;
			}
			this.EOCCJGIGEGJ().SetFloat("_Value2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 749f)
				{
					this._Distance = 789f;
				}
				if (this._Distance < 665f)
				{
					this._Distance = 767f;
				}
				this.ADAFMBOGPLN().SetFloat("Clears all text from the debug console", this._Distance);
			}
			else
			{
				this.GHHPOGODBHB().SetFloat("maps.", this._Distance);
			}
			this.HKHBBBFLGJH().SetFloat("CameraFilterPack/Light_Water2", this._Size);
			this.MFHPKGICPIO().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", (float)((!this._Visualize) ? 1 : 0));
			this.HFBJAOFLCJI().SetFloat("Scene", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("/", this.DistortionLevel * 593f);
			this.HFBJAOFLCJI().SetFloat("COMPLETED", this.DistortionSize * 1946f);
			this.KEMJNOMIPHN().SetFloat("PossibleMapMaxScoreText", this.LightIntensity * 416f);
			this.ADBKPGFMNKO().SetTexture("Dropped Object: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("OnPress", 1631f / farClipPlane);
			this.GCDFNHMJMIP().SetVector("Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1608f, 1610f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00043EFF File Offset: 0x000420FF
	private void OHIJGCLBMJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00043EFF File Offset: 0x000420FF
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00048122 File Offset: 0x00046322
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00048159 File Offset: 0x00046359
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Myst1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00043EFF File Offset: 0x000420FF
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00043EFF File Offset: 0x000420FF
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00048192 File Offset: 0x00046392
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00043EFF File Offset: 0x000420FF
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00043EFF File Offset: 0x000420FF
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x000481C9 File Offset: 0x000463C9
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load(":\n") as Texture2D);
		this.SCShader = Shader.Find("DestroyRpc");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000151 RID: 337
	public Shader SCShader;

	// Token: 0x04000152 RID: 338
	public bool _Visualize;

	// Token: 0x04000153 RID: 339
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000154 RID: 340
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000155 RID: 341
	private Material BJFKDHHMLJH;

	// Token: 0x04000156 RID: 342
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x04000157 RID: 343
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	// Token: 0x04000158 RID: 344
	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	// Token: 0x04000159 RID: 345
	[Range(0f, 10f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x0400015A RID: 346
	[Range(0.1f, 10f)]
	public float DistortionSize = 1.4f;

	// Token: 0x0400015B RID: 347
	[Range(-2f, 4f)]
	public float LightIntensity = 0.08f;

	// Token: 0x0400015C RID: 348
	public bool AutoAnimatedNear;

	// Token: 0x0400015D RID: 349
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x0400015E RID: 350
	private Texture2D FPHEBLMINDA;

	// Token: 0x0400015F RID: 351
	public static Color ChangeColorRGB;
}
