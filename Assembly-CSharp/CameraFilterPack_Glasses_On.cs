using System;
using UnityEngine;

// Token: 0x020000D8 RID: 216
[AddComponentMenu("Camera Filter Pack/Glasses/Classic Glasses")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On : MonoBehaviour
{
	// Token: 0x0600424C RID: 16972 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600424D RID: 16973 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x0600424E RID: 16974 RVA: 0x00145D08 File Offset: 0x00143F08
	private void JDKHBGDEONK()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("DataText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600424F RID: 16975 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06004250 RID: 16976 RVA: 0x00145D41 File Offset: 0x00143F41
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004251 RID: 16977 RVA: 0x00145D78 File Offset: 0x00143F78
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004252 RID: 16978 RVA: 0x00145DAF File Offset: 0x00143FAF
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("masterSteamID") as Texture2D);
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004253 RID: 16979 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004254 RID: 16980 RVA: 0x00145DE8 File Offset: 0x00143FE8
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1829f)
			{
				this.HBJJOCHGOPH = 966f;
			}
			this.OLHDPICFBOF().SetFloat("CameraFilterPack_TV_Noise2", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat(" should be overwritten.", this.UseFinalGlassColor);
			this.HEHKGPKLAKK().SetFloat("turn", this.Fade);
			this.MFHPKGICPIO().SetFloat(" ", this.VisionBlur);
			this.GHHPOGODBHB().SetFloat(",", this.GlassDistortion);
			this.MICHFGAOPKM().SetFloat("Updated!", this.GlassAberration);
			this.MFHPKGICPIO().SetColor("_Blend", this.GlassesColor);
			this.GHHPOGODBHB().SetColor(",", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("_History3ChromaTex", this.GlassColor);
			this.HNFFHCLNBDN().SetFloat("skin.", this.UseScanLineSize);
			this.KEMJNOMIPHN().SetFloat("_ScreenResolution", this.UseScanLine);
			this.HKGAONMOBMH().SetTexture("_Value4", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004255 RID: 16981 RVA: 0x00145F54 File Offset: 0x00144154
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004256 RID: 16982 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06004257 RID: 16983 RVA: 0x00145F8C File Offset: 0x0014418C
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 760f)
			{
				this.HBJJOCHGOPH = 22f;
			}
			this.MLMKCOINOOH().SetFloat("_NormalAndRoughnessTexture", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("\0\0", this.UseFinalGlassColor);
			this.HEHKGPKLAKK().SetFloat("\" that takes ", this.Fade);
			this.MLMKCOINOOH().SetFloat("[EditorEvent] Exception: ", this.VisionBlur);
			this.HEHKGPKLAKK().SetFloat("LevelNameInputField", this.GlassDistortion);
			this.LPMLLJKMAMP().SetFloat("StartButton", this.GlassAberration);
			this.HEHKGPKLAKK().SetColor("_Value3", this.GlassesColor);
			this.DKKBFFHBHJE().SetColor("error", this.GlassesColor2);
			this.DKKBFFHBHJE().SetColor("tagElement", this.GlassColor);
			this.MLMKCOINOOH().SetFloat("MultiplayerButton", this.UseScanLineSize);
			this.OLHDPICFBOF().SetFloat("SingleplayerButton", this.UseScanLine);
			this.MICHFGAOPKM().SetTexture("#000000", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004258 RID: 16984 RVA: 0x001460F8 File Offset: 0x001442F8
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.") as Texture2D);
		this.SCShader = Shader.Find("https://vk.com/khb.soft");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004259 RID: 16985 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600425A RID: 16986 RVA: 0x00146134 File Offset: 0x00144334
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1441f)
			{
				this.HBJJOCHGOPH = 402f;
			}
			this.GHHPOGODBHB().SetFloat("CameraFilterPack/Pixelisation_Dot", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("SetSunInput", this.UseFinalGlassColor);
			this.GHHPOGODBHB().SetFloat("System.Boolean", this.Fade);
			this.KEMJNOMIPHN().SetFloat("_Value2", this.VisionBlur);
			this.OLHDPICFBOF().SetFloat("_Value", this.GlassDistortion);
			this.MICHFGAOPKM().SetFloat("SetTrailZoomSpeed", this.GlassAberration);
			this.HKGAONMOBMH().SetColor("_TimeX", this.GlassesColor);
			this.FEAEGGCNIAA().SetColor("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", this.GlassesColor2);
			this.HKGAONMOBMH().SetColor("0,1,false", this.GlassColor);
			this.OLHDPICFBOF().SetFloat(".", this.UseScanLineSize);
			this.MFHPKGICPIO().SetFloat("curScn", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture("EnvironmentSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600425B RID: 16987 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600425C RID: 16988 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600425D RID: 16989 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600425E RID: 16990 RVA: 0x001462A0 File Offset: 0x001444A0
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600425F RID: 16991 RVA: 0x001462D8 File Offset: 0x001444D8
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
			this.NBPKMLMCHFN.SetFloat("UseFinalGlassColor", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("VisionBlur", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("GlassDistortion", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat("GlassAberration", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("GlassesColor", this.GlassesColor);
			this.NBPKMLMCHFN.SetColor("GlassesColor2", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("GlassColor", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("UseScanLineSize", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("UseScanLine", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004260 RID: 16992 RVA: 0x00146444 File Offset: 0x00144644
	private void HIPEHGNBJMN()
	{
		this.FPHEBLMINDA = (Resources.Load("_ExposureAdjustment") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004261 RID: 16993 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004262 RID: 16994 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004263 RID: 16995 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06004264 RID: 16996 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004265 RID: 16997 RVA: 0x00146480 File Offset: 0x00144680
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 44f)
			{
				this.HBJJOCHGOPH = 1760f;
			}
			this.MFHPKGICPIO().SetFloat("StartCanvas", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("menutheme", this.UseFinalGlassColor);
			this.OLHDPICFBOF().SetFloat("_TimeX", this.Fade);
			this.LENEJAGLCNL().SetFloat("???", this.VisionBlur);
			this.HEHKGPKLAKK().SetFloat("_DotSize", this.GlassDistortion);
			this.KEMJNOMIPHN().SetFloat("_Value1", this.GlassAberration);
			this.MFHPKGICPIO().SetColor("_Blue_B", this.GlassesColor);
			this.FEAEGGCNIAA().SetColor("BitsData", this.GlassesColor2);
			this.LMLENGFLEBD().SetColor("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", this.GlassColor);
			this.HKGAONMOBMH().SetFloat("My New Mod Pack", this.UseScanLineSize);
			this.HNFFHCLNBDN().SetFloat("CONTRAST", this.UseScanLine);
			this.OLHDPICFBOF().SetTexture("]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004266 RID: 16998 RVA: 0x001465EC File Offset: 0x001447EC
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("Despawn environment object by id") as Texture2D);
		this.SCShader = Shader.Find("#onrankchangeuptext");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004267 RID: 16999 RVA: 0x00146625 File Offset: 0x00144825
	private void LGHCJCFHEMF()
	{
		this.FPHEBLMINDA = (Resources.Load("[MenuScene] Error: ") as Texture2D);
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004268 RID: 17000 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06004269 RID: 17001 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x0600426A RID: 17002 RVA: 0x0014665E File Offset: 0x0014485E
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("Emergency Help:") as Texture2D);
		this.SCShader = Shader.Find("playing");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600426B RID: 17003 RVA: 0x00146697 File Offset: 0x00144897
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.volume.sfx") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_NeonGradient");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600426C RID: 17004 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600426D RID: 17005 RVA: 0x001466D0 File Offset: 0x001448D0
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("</size>") as Texture2D);
		this.SCShader = Shader.Find("_Bullet_6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600426E RID: 17006 RVA: 0x00146709 File Offset: 0x00144909
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600426F RID: 17007 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06004270 RID: 17008 RVA: 0x00146740 File Offset: 0x00144940
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004271 RID: 17009 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004272 RID: 17010 RVA: 0x00146777 File Offset: 0x00144977
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004273 RID: 17011 RVA: 0x001467AE File Offset: 0x001449AE
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Retro_Loading") as Texture2D);
		this.SCShader = Shader.Find("SetSatelliteRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004274 RID: 17012 RVA: 0x001467E7 File Offset: 0x001449E7
	private void EPEGAEGDJAM()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button10") as Texture2D);
		this.SCShader = Shader.Find("#,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004275 RID: 17013 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004276 RID: 17014 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004277 RID: 17015 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004278 RID: 17016 RVA: 0x00146820 File Offset: 0x00144A20
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("]") as Texture2D);
		this.SCShader = Shader.Find("mapselector.lastSearch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004279 RID: 17017 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x0600427A RID: 17018 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600427B RID: 17019 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600427C RID: 17020 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600427D RID: 17021 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600427E RID: 17022 RVA: 0x0014685C File Offset: 0x00144A5C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 663f)
			{
				this.HBJJOCHGOPH = 907f;
			}
			this.KEMJNOMIPHN().SetFloat("SpeedSlider", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("_SoftZDistance", this.UseFinalGlassColor);
			this.MICHFGAOPKM().SetFloat("other.dust0", this.Fade);
			this.KEMJNOMIPHN().SetFloat("MapEditorScene", this.VisionBlur);
			this.LPMLLJKMAMP().SetFloat("shaders", this.GlassDistortion);
			this.LENEJAGLCNL().SetFloat("Please define the RectTransform for the Center viewport of the scrollable area", this.GlassAberration);
			this.LPMLLJKMAMP().SetColor("<b>Speed</b>:", this.GlassesColor);
			this.LMLENGFLEBD().SetColor("_Green_B", this.GlassesColor2);
			this.NBMPPNFKFLB().SetColor("CameraFilterPack/Distortion_ShockWaveManual", this.GlassColor);
			this.NBMPPNFKFLB().SetFloat("Tried to Initialize the SteamAPI twice in one session!", this.UseScanLineSize);
			this.LENEJAGLCNL().SetFloat("No font defined. Found font: ", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture("int", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600427F RID: 17023 RVA: 0x001469C8 File Offset: 0x00144BC8
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 793f)
			{
				this.HBJJOCHGOPH = 1346f;
			}
			this.HEHKGPKLAKK().SetFloat("NetworkCanvas", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("ViewMenu", this.UseFinalGlassColor);
			this.LMLENGFLEBD().SetFloat("challenges.", this.Fade);
			this.HKGAONMOBMH().SetFloat("Tab2Content", this.VisionBlur);
			this.IONHGBPGCHK().SetFloat("_History1Weight", this.GlassDistortion);
			this.OKJOKHGJHGF().SetFloat(",", this.GlassAberration);
			this.LPMLLJKMAMP().SetColor("SetCrosshairEmission", this.GlassesColor);
			this.OLHDPICFBOF().SetColor("My New Mod Pack", this.GlassesColor2);
			this.OLHDPICFBOF().SetColor("CameraFilterPack/Vision_Blood_Fast", this.GlassColor);
			this.HKGAONMOBMH().SetFloat("Set satellite trail length in seconds", this.UseScanLineSize);
			this.MFHPKGICPIO().SetFloat("_BorderColor", this.UseScanLine);
			this.DKKBFFHBHJE().SetTexture("Preparing content", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004280 RID: 17024 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06004281 RID: 17025 RVA: 0x00146B34 File Offset: 0x00144D34
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1226f)
			{
				this.HBJJOCHGOPH = 1159f;
			}
			this.KEMJNOMIPHN().SetFloat("Missing shader for image effect {0}", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_Red_G", this.UseFinalGlassColor);
			this.FLOHGDECHHH().SetFloat("JITTER", this.Fade);
			this.OKJOKHGJHGF().SetFloat("-help", this.VisionBlur);
			this.MFHPKGICPIO().SetFloat("_FixDistance", this.GlassDistortion);
			this.MLMKCOINOOH().SetFloat(".completedMaps", this.GlassAberration);
			this.DKKBFFHBHJE().SetColor("_Value4", this.GlassesColor);
			this.HNFFHCLNBDN().SetColor("You must complete your map before submiting it to Workshop", this.GlassesColor2);
			this.GHHPOGODBHB().SetColor("offline room", this.GlassColor);
			this.LENEJAGLCNL().SetFloat("CameraFilterPack/EyesVision_2", this.UseScanLineSize);
			this.LMLENGFLEBD().SetFloat("_Value", this.UseScanLine);
			this.LENEJAGLCNL().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004282 RID: 17026 RVA: 0x00146CA0 File Offset: 0x00144EA0
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Glasses_On2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004283 RID: 17027 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06004284 RID: 17028 RVA: 0x00146CD9 File Offset: 0x00144ED9
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("init") as Texture2D);
		this.SCShader = Shader.Find("\\");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004285 RID: 17029 RVA: 0x00146D14 File Offset: 0x00144F14
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1469f)
			{
				this.HBJJOCHGOPH = 1381f;
			}
			this.GHHPOGODBHB().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_SunColor", this.UseFinalGlassColor);
			this.NBMPPNFKFLB().SetFloat("_RangeScale", this.Fade);
			this.HNFFHCLNBDN().SetFloat("lobby '{0}'[{1}]", this.VisionBlur);
			this.GHHPOGODBHB().SetFloat(".", this.GlassDistortion);
			this.MLMKCOINOOH().SetFloat("Please specify a map name or buildID", this.GlassAberration);
			this.IONHGBPGCHK().SetColor(" left", this.GlassesColor);
			this.HKGAONMOBMH().SetColor("[MapEditor] Prepairing map editor...", this.GlassesColor2);
			this.LPMLLJKMAMP().SetColor("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", this.GlassColor);
			this.MFHPKGICPIO().SetFloat("_TimeX", this.UseScanLineSize);
			this.OLHDPICFBOF().SetFloat("received</b>\n#reason: ", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture("workshop.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004286 RID: 17030 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004287 RID: 17031 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06004288 RID: 17032 RVA: 0x00146E80 File Offset: 0x00145080
	private void JECMJNFGBGC()
	{
		this.FPHEBLMINDA = (Resources.Load("mapselector.tags.") as Texture2D);
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004289 RID: 17033 RVA: 0x00146EBC File Offset: 0x001450BC
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 439f)
			{
				this.HBJJOCHGOPH = 1784f;
			}
			this.MFHPKGICPIO().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("resetall", this.UseFinalGlassColor);
			this.FLOHGDECHHH().SetFloat("[NetworkManager] Updating current room...", this.Fade);
			this.LENEJAGLCNL().SetFloat("pointBuffer", this.VisionBlur);
			this.LENEJAGLCNL().SetFloat("<b>Speed</b>:", this.GlassDistortion);
			this.LMLENGFLEBD().SetFloat("icon", this.GlassAberration);
			this.LMLENGFLEBD().SetColor("_Value2", this.GlassesColor);
			this.KEMJNOMIPHN().SetColor("offsets", this.GlassesColor2);
			this.DKKBFFHBHJE().SetColor("_FixDistance", this.GlassColor);
			this.NBMPPNFKFLB().SetFloat("]", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("_Saturation", this.UseScanLine);
			this.IONHGBPGCHK().SetTexture("EditMenu", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600428A RID: 17034 RVA: 0x00147028 File Offset: 0x00145228
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 305f)
			{
				this.HBJJOCHGOPH = 1987f;
			}
			this.LMLENGFLEBD().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("Editor/", this.UseFinalGlassColor);
			this.HNFFHCLNBDN().SetFloat("_Value2", this.Fade);
			this.MLMKCOINOOH().SetFloat("GameScene", this.VisionBlur);
			this.FLOHGDECHHH().SetFloat("_Value2", this.GlassDistortion);
			this.IONHGBPGCHK().SetFloat(": ", this.GlassAberration);
			this.PGPEMMBJOOG().SetColor("_Value4", this.GlassesColor);
			this.LPMLLJKMAMP().SetColor("restrictions\n\n#until: ", this.GlassesColor2);
			this.KEMJNOMIPHN().SetColor("menutheme.fragout", this.GlassColor);
			this.LENEJAGLCNL().SetFloat(". Name: ", this.UseScanLineSize);
			this.GHHPOGODBHB().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.UseScanLine);
			this.GHHPOGODBHB().SetTexture("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600428B RID: 17035 RVA: 0x00147194 File Offset: 0x00145394
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600428C RID: 17036 RVA: 0x001471CB File Offset: 0x001453CB
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("Stream did not contain properly formatted byte array") as Texture2D);
		this.SCShader = Shader.Find("PunRespawn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600428D RID: 17037 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600428E RID: 17038 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x0600428F RID: 17039 RVA: 0x00147204 File Offset: 0x00145404
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004290 RID: 17040 RVA: 0x0014723B File Offset: 0x0014543B
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004291 RID: 17041 RVA: 0x00147272 File Offset: 0x00145472
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value4") as Texture2D);
		this.SCShader = Shader.Find("Set arcs speed. Base value - 15");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004292 RID: 17042 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06004293 RID: 17043 RVA: 0x001472AB File Offset: 0x001454AB
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("_WaveIntensity") as Texture2D);
		this.SCShader = Shader.Find("Using constructor for new PingNativeStatic()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004294 RID: 17044 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06004295 RID: 17045 RVA: 0x001472E4 File Offset: 0x001454E4
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004296 RID: 17046 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06004297 RID: 17047 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06004298 RID: 17048 RVA: 0x0014731C File Offset: 0x0014551C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 705f)
			{
				this.HBJJOCHGOPH = 1730f;
			}
			this.LPMLLJKMAMP().SetFloat("_Value", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("Delete events", this.UseFinalGlassColor);
			this.HNFFHCLNBDN().SetFloat("settings.showHP", this.Fade);
			this.MICHFGAOPKM().SetFloat("Texture2", this.VisionBlur);
			this.GHHPOGODBHB().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", this.GlassDistortion);
			this.KEMJNOMIPHN().SetFloat("id", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("inventory.lastitemscount", this.GlassesColor);
			this.OLHDPICFBOF().SetColor("GameScene", this.GlassesColor2);
			this.HEHKGPKLAKK().SetColor("#8E8E8EFF", this.GlassColor);
			this.IONHGBPGCHK().SetFloat("Write me to get one for testing :)", this.UseScanLineSize);
			this.OLHDPICFBOF().SetFloat("_Size", this.UseScanLine);
			this.LPMLLJKMAMP().SetTexture("Horizontal", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600429A RID: 17050 RVA: 0x0014753A File Offset: 0x0014573A
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600429B RID: 17051 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600429C RID: 17052 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600429D RID: 17053 RVA: 0x00146709 File Offset: 0x00144909
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600429E RID: 17054 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600429F RID: 17055 RVA: 0x00147571 File Offset: 0x00145771
	private void HDMDKOKOOJC()
	{
		this.FPHEBLMINDA = (Resources.Load("88f00bdf0ad61b16b803971ebe071962") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060042A0 RID: 17056 RVA: 0x001475AC File Offset: 0x001457AC
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1132f)
			{
				this.HBJJOCHGOPH = 1397f;
			}
			this.HEHKGPKLAKK().SetFloat("Remove Environment Object", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("offsets", this.UseFinalGlassColor);
			this.NBMPPNFKFLB().SetFloat("ns", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Print the list of scenes, avalable in game.", this.VisionBlur);
			this.OKJOKHGJHGF().SetFloat("_Fade", this.GlassDistortion);
			this.HKGAONMOBMH().SetFloat("Tab2Content", this.GlassAberration);
			this.IONHGBPGCHK().SetColor("GameScene", this.GlassesColor);
			this.LPMLLJKMAMP().SetColor("_ScreenResolution", this.GlassesColor2);
			this.GHHPOGODBHB().SetColor("_Value3", this.GlassColor);
			this.GHHPOGODBHB().SetFloat("_TimeX", this.UseScanLineSize);
			this.FLOHGDECHHH().SetFloat("#tryagain", this.UseScanLine);
			this.OLHDPICFBOF().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042A1 RID: 17057 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060042A2 RID: 17058 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x060042A3 RID: 17059 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042A4 RID: 17060 RVA: 0x00147718 File Offset: 0x00145918
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042A5 RID: 17061 RVA: 0x0014774F File Offset: 0x0014594F
	private void IDJKNBDKHBD()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_Noise") as Texture2D);
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042A6 RID: 17062 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060042A7 RID: 17063 RVA: 0x00147788 File Offset: 0x00145988
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042A8 RID: 17064 RVA: 0x001477BF File Offset: 0x001459BF
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("\t") as Texture2D);
		this.SCShader = Shader.Find("FrostCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060042A9 RID: 17065 RVA: 0x001477F8 File Offset: 0x001459F8
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load(">") as Texture2D);
		this.SCShader = Shader.Find("_Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060042AA RID: 17066 RVA: 0x00147831 File Offset: 0x00145A31
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042AB RID: 17067 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042AC RID: 17068 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060042AD RID: 17069 RVA: 0x00147868 File Offset: 0x00145A68
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

	// Token: 0x060042AE RID: 17070 RVA: 0x0014789F File Offset: 0x00145A9F
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042AF RID: 17071 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042B0 RID: 17072 RVA: 0x001478D6 File Offset: 0x00145AD6
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042B1 RID: 17073 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x060042B2 RID: 17074 RVA: 0x00145CEB File Offset: 0x00143EEB
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060042B3 RID: 17075 RVA: 0x0014790D File Offset: 0x00145B0D
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060042B4 RID: 17076 RVA: 0x00147944 File Offset: 0x00145B44
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1082f)
			{
				this.HBJJOCHGOPH = 1324f;
			}
			this.HNFFHCLNBDN().SetFloat("[Down]", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("STICKRVER", this.UseFinalGlassColor);
			this.FLOHGDECHHH().SetFloat("_Blur", this.Fade);
			this.PGPEMMBJOOG().SetFloat("_SunThreshold", this.VisionBlur);
			this.MLMKCOINOOH().SetFloat("_TimeX", this.GlassDistortion);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack_3D_Myst1", this.GlassAberration);
			this.MFHPKGICPIO().SetColor("_FullResolutionFiltering", this.GlassesColor);
			this.OLHDPICFBOF().SetColor("_TimeX", this.GlassesColor2);
			this.NBMPPNFKFLB().SetColor("#creatingnewitem", this.GlassColor);
			this.FLOHGDECHHH().SetFloat("note.2", this.UseScanLineSize);
			this.OLHDPICFBOF().SetFloat("Mouse0", this.UseScanLine);
			this.OLHDPICFBOF().SetTexture("/", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060042B5 RID: 17077 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x040006F2 RID: 1778
	public Shader SCShader;

	// Token: 0x040006F3 RID: 1779
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006F4 RID: 1780
	[Range(0f, 1f)]
	public float Fade = 0.2f;

	// Token: 0x040006F5 RID: 1781
	[Range(0f, 0.1f)]
	public float VisionBlur = 0.0095f;

	// Token: 0x040006F6 RID: 1782
	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	// Token: 0x040006F7 RID: 1783
	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.25f, 0.25f);

	// Token: 0x040006F8 RID: 1784
	[Range(0f, 1f)]
	public float GlassDistortion = 0.45f;

	// Token: 0x040006F9 RID: 1785
	[Range(0f, 1f)]
	public float GlassAberration = 0.5f;

	// Token: 0x040006FA RID: 1786
	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	// Token: 0x040006FB RID: 1787
	[Range(0f, 1f)]
	public float UseScanLine;

	// Token: 0x040006FC RID: 1788
	[Range(1f, 512f)]
	public float UseScanLineSize = 1f;

	// Token: 0x040006FD RID: 1789
	public Color GlassColor = new Color(0f, 0f, 0f, 1f);

	// Token: 0x040006FE RID: 1790
	private Material BJFKDHHMLJH;

	// Token: 0x040006FF RID: 1791
	private Texture2D FPHEBLMINDA;
}
