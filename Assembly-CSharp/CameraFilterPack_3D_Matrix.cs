using System;
using UnityEngine;

// Token: 0x02000024 RID: 36
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Matrix")]
public class CameraFilterPack_3D_Matrix : MonoBehaviour
{
	// Token: 0x060007E8 RID: 2024 RVA: 0x0003CF54 File Offset: 0x0003B154
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1332f)
			{
				this.HBJJOCHGOPH = 1316f;
			}
			this.EOCCJGIGEGJ().SetFloat("Bad parameters for getbool! Use <key> <value>", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("Triangle", this.Fade);
			this.HKGAONMOBMH().SetFloat("Chat", this._FixDistance);
			this.OJMHIMIPKME().SetFloat(" registered.", this.MatrixSize);
			this.IONHGBPGCHK().SetColor("_Value", this._MatrixColor);
			this.DKNJGHFLAIF().SetFloat("Vignette", this.MatrixSpeed * 308f);
			this.FGENHBKMPDA().SetFloat("BitsData", (float)((!this._Visualize) ? 0 : 1));
			this.CECICEGFHKL().SetFloat("offsets", this.LightIntensity);
			this.DKNJGHFLAIF().SetTexture("_TimeX", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DNLMFEGJJDD().SetFloat("MapEnd", 1932f / farClipPlane);
			this.FGENHBKMPDA().SetVector(".sawoutdatedmessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1962f, 385f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x0003D0ED File Offset: 0x0003B2ED
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x0003D124 File Offset: 0x0003B324
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0003D141 File Offset: 0x0003B341
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x0003D124 File Offset: 0x0003B324
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x0003D178 File Offset: 0x0003B378
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1030f)
			{
				this.HBJJOCHGOPH = 1972f;
			}
			this.CBCNOEIALHB().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("menu.tabid", this.Fade);
			this.CECICEGFHKL().SetFloat("_Value3", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Y", this.MatrixSize);
			this.PGPEMMBJOOG().SetColor("Joystick1Button7", this._MatrixColor);
			this.FHFLKLMFHOI().SetFloat("Received your NickName from server. Updating local value to: {0}", this.MatrixSpeed * 1960f);
			this.ABHDNGIHBKE().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.GHHPOGODBHB().SetFloat("_FadeFX", this.LightIntensity);
			this.HKGAONMOBMH().SetTexture("offsets", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MHBAIEKFBIJ().SetFloat("_Value4", 381f / farClipPlane);
			this.DKNJGHFLAIF().SetVector("menu.hardcoreinfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1785f, 1793f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x0003D124 File Offset: 0x0003B324
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x0003D311 File Offset: 0x0003B511
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0003D348 File Offset: 0x0003B548
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x0003D380 File Offset: 0x0003B580
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 831f)
			{
				this.HBJJOCHGOPH = 1976f;
			}
			this.GHHPOGODBHB().SetFloat("_Light", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("y", this.Fade);
			this.DONENAMLFLF().SetFloat("_MatrixSize", this._FixDistance);
			this.DNLMFEGJJDD().SetFloat("Set particles size", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", this._MatrixColor);
			this.OJMHIMIPKME().SetFloat("ItemNameText", this.MatrixSpeed * 250f);
			this.ABHDNGIHBKE().SetFloat("_Bloom", (float)((!this._Visualize) ? 0 : 1));
			this.ECCPAOBFDKP().SetFloat("_Value2", this.LightIntensity);
			this.NBPKMLMCHFN.SetTexture("Joystick1Button9", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat(".sav", 283f / farClipPlane);
			this.HNFFHCLNBDN().SetVector("settings.enablehitsoundsinnormal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 549f, 544f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x0003D51C File Offset: 0x0003B71C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1667f)
			{
				this.HBJJOCHGOPH = 200f;
			}
			this.OJMHIMIPKME().SetFloat("LostLive", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_Threshold", this.Fade);
			this.CECICEGFHKL().SetFloat("_History3Weight", this._FixDistance);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.MatrixSize);
			this.ABHDNGIHBKE().SetColor("Joystick1Button9", this._MatrixColor);
			this.PDEAHJPOMEF().SetFloat("settings.cameramovements", this.MatrixSpeed * 359f);
			this.PDEAHJPOMEF().SetFloat("_OnOff", (float)((!this._Visualize) ? 1 : 0));
			this.JFDGLLEOPGB().SetFloat("_BlurPass", this.LightIntensity);
			this.CBCNOEIALHB().SetTexture("DPADHOR", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OJMHIMIPKME().SetFloat("_AxialAberration", 181f / farClipPlane);
			this.DONENAMLFLF().SetVector(".completed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1880f, 1135f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0003D6B5 File Offset: 0x0003B8B5
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x0003D124 File Offset: 0x0003B324
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060007FB RID: 2043 RVA: 0x0003D6EE File Offset: 0x0003B8EE
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007FC RID: 2044 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x0003D725 File Offset: 0x0003B925
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x0003D75C File Offset: 0x0003B95C
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x0003D794 File Offset: 0x0003B994
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 375f)
			{
				this.HBJJOCHGOPH = 1410f;
			}
			this.HEINDEMCGIK().SetFloat("IntraSig", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", this.Fade);
			this.GHHPOGODBHB().SetFloat("OxOD.lastPath", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("mapselector.orderby", this.MatrixSize);
			this.JFDGLLEOPGB().SetColor("_TimeX", this._MatrixColor);
			this.DONENAMLFLF().SetFloat("_TimeX", this.MatrixSpeed * 1935f);
			this.PDEAHJPOMEF().SetFloat("Beat Detected", (float)((!this._Visualize) ? 0 : 1));
			this.HKGAONMOBMH().SetFloat("_Value5", this.LightIntensity);
			this.CEKJODEAMGB().SetTexture("ResetButton", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat("_TimeX", 1279f / farClipPlane);
			this.IONHGBPGCHK().SetVector("Playing ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 443f, 999f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x0003D92D File Offset: 0x0003BB2D
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("_EmissionGain") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0003D968 File Offset: 0x0003BB68
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1296f)
			{
				this.HBJJOCHGOPH = 316f;
			}
			this.HHIFMIPPMPF().SetFloat("/", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.Fade);
			this.HNFFHCLNBDN().SetFloat("settings.crosshairopacity", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("r", this.MatrixSize);
			this.IGKFMCPDNOI().SetColor("Items/", this._MatrixColor);
			this.GHHPOGODBHB().SetFloat("gameVolume", this.MatrixSpeed * 769f);
			this.BBIMPFGLDCP().SetFloat("#rt", (float)((!this._Visualize) ? 0 : 0));
			this.CEKJODEAMGB().SetFloat("CameraFilterPack/TV_BrokenGlass2", this.LightIntensity);
			this.IIJMIPBMMBF().SetTexture("_Bullet_3", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GBFOAHKAJEK().SetFloat("SaveButton", 1200f / farClipPlane);
			this.ABHDNGIHBKE().SetVector("Failed to 'network-remove' GameObject because has no PhotonView components: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 115f, 1630f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0003D124 File Offset: 0x0003B324
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x0003D124 File Offset: 0x0003B324
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x0003DB04 File Offset: 0x0003BD04
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 285f)
			{
				this.HBJJOCHGOPH = 956f;
			}
			this.DNLMFEGJJDD().SetFloat("value", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("_Value2", this.Fade);
			this.IONHGBPGCHK().SetFloat("LivesSlider", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("You must complete your map before submiting it to Workshop", this.MatrixSize);
			this.NBPKMLMCHFN.SetColor("Square", this._MatrixColor);
			this.CBCNOEIALHB().SetFloat("y", this.MatrixSpeed * 1431f);
			this.HILDKDFEBPF().SetFloat("CameraFilterPack/TV_ARCADE_2", (float)((!this._Visualize) ? 0 : 0));
			this.HILDKDFEBPF().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.LightIntensity);
			this.PDEAHJPOMEF().SetTexture("SetRotation", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", 1037f / farClipPlane);
			this.PGPEMMBJOOG().SetVector("z", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 369f, 1296f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0003DC9D File Offset: 0x0003BE9D
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0003DCD4 File Offset: 0x0003BED4
	private void IGPCNCJIEOJ()
	{
		this.FPHEBLMINDA = (Resources.Load(": ") as Texture2D);
		this.SCShader = Shader.Find(".played");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x0003D124 File Offset: 0x0003B324
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x0003DD0D File Offset: 0x0003BF0D
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("checkpoint") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0003DD46 File Offset: 0x0003BF46
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("Failed to 'network-remove' GameObject because it's null.") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0003D124 File Offset: 0x0003B324
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0003DD80 File Offset: 0x0003BF80
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1984f)
			{
				this.HBJJOCHGOPH = 1211f;
			}
			this.CECICEGFHKL().SetFloat("_Bloom0", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("Created", this.Fade);
			this.DKNJGHFLAIF().SetFloat("_TimeX", this._FixDistance);
			this.HHIFMIPPMPF().SetFloat("880078120", this.MatrixSize);
			this.FKEOGPDLBDD().SetColor("targetColor", this._MatrixColor);
			this.FGENHBKMPDA().SetFloat("_ScreenResolution", this.MatrixSpeed * 475f);
			this.GHHPOGODBHB().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 1));
			this.BBIMPFGLDCP().SetFloat("_BlurVector", this.LightIntensity);
			this.PDEAHJPOMEF().SetTexture("ticket", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HILDKDFEBPF().SetFloat("offsets", 763f / farClipPlane);
			this.GHHPOGODBHB().SetVector("SetParticlesParticleSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 464f, 1403f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x0003D348 File Offset: 0x0003B548
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0003DF19 File Offset: 0x0003C119
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_3D_Matrix1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Matrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0003DF54 File Offset: 0x0003C154
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 563f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.HILDKDFEBPF().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Player", this.Fade);
			this.ECCPAOBFDKP().SetFloat("Finished", this._FixDistance);
			this.MHBAIEKFBIJ().SetFloat("_Value3", this.MatrixSize);
			this.ECCPAOBFDKP().SetColor("_ScreenResolution", this._MatrixColor);
			this.HHIFMIPPMPF().SetFloat("_Value6", this.MatrixSpeed * 1202f);
			this.OJMHIMIPKME().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.HKGAONMOBMH().SetFloat("menu.relaxinfo", this.LightIntensity);
			this.ADGHJOHKEHG().SetTexture("\\", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MHBAIEKFBIJ().SetFloat("#,0.00", 527f / farClipPlane);
			this.FGENHBKMPDA().SetVector("menutheme", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1461f, 1154f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0003E0ED File Offset: 0x0003C2ED
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0003E124 File Offset: 0x0003C324
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 491f)
			{
				this.HBJJOCHGOPH = 268f;
			}
			this.DONENAMLFLF().SetFloat("CameraFilterPack/Blend2Camera_Screen", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("#,0.00", this.Fade);
			this.HILDKDFEBPF().SetFloat("_NeutralTonemapperParams1", this._FixDistance);
			this.OJMHIMIPKME().SetFloat("Needs to be attached to the Event System component in the scene", this.MatrixSize);
			this.HNFFHCLNBDN().SetColor("offsets", this._MatrixColor);
			this.BBIMPFGLDCP().SetFloat("settings.volume.editor", this.MatrixSpeed * 1345f);
			this.FKEOGPDLBDD().SetFloat(" ", (float)((!this._Visualize) ? 0 : 1));
			this.HHIFMIPPMPF().SetFloat("Object ID. Case-Sensitive", this.LightIntensity);
			this.IGKFMCPDNOI().SetTexture("_Value4", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CECICEGFHKL().SetFloat("\n", 751f / farClipPlane);
			this.FKEOGPDLBDD().SetVector("Clears the console and prints the logs in the specified range", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1798f, 736f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x0003E2BD File Offset: 0x0003C4BD
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0003E2F6 File Offset: 0x0003C4F6
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x0003E32D File Offset: 0x0003C52D
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0003E364 File Offset: 0x0003C564
	private void AKHCOBHHGJP()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.selectormapsperpage") as Texture2D);
		this.SCShader = Shader.Find("/?player=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x0003E39D File Offset: 0x0003C59D
	private void HIPEHGNBJMN()
	{
		this.FPHEBLMINDA = (Resources.Load("BadgeText") as Texture2D);
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0003E3D6 File Offset: 0x0003C5D6
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("SaveButton") as Texture2D);
		this.SCShader = Shader.Find("FullscreenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x0003E410 File Offset: 0x0003C610
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 842f)
			{
				this.HBJJOCHGOPH = 1172f;
			}
			this.GBFOAHKAJEK().SetFloat("_Parameter", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("menuVolume", this.Fade);
			this.OJMHIMIPKME().SetFloat("#currentbpm: ", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("Using constructor for new PingNativeStatic()", this.MatrixSize);
			this.CEKJODEAMGB().SetColor("CameraFilterPack/FX_Drunk", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("RenderTextureUtilityTempTexture", this.MatrixSpeed * 716f);
			this.IIJMIPBMMBF().SetFloat("GenerationMenu", (float)((!this._Visualize) ? 1 : 0));
			this.GHHPOGODBHB().SetFloat("Exception while connecting to: ", this.LightIntensity);
			this.ECCPAOBFDKP().SetTexture("PlayMapsSeriesGoal", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HHIFMIPPMPF().SetFloat("_MainTex2", 284f / farClipPlane);
			this.FKEOGPDLBDD().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1883f, 181f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x0003E5A9 File Offset: 0x0003C7A9
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x0003E32D File Offset: 0x0003C52D
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 371f)
			{
				this.HBJJOCHGOPH = 1693f;
			}
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetFloat("Fade", this.Fade);
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack/FX_Psycho", this._FixDistance);
			this.FGENHBKMPDA().SetFloat(":", this.MatrixSize);
			this.OJMHIMIPKME().SetColor("_Factor", this._MatrixColor);
			this.GHHPOGODBHB().SetFloat("player.egglipszerotwo", this.MatrixSpeed * 741f);
			this.FKEOGPDLBDD().SetFloat("/", (float)((!this._Visualize) ? 0 : 1));
			this.JFDGLLEOPGB().SetFloat("intensity", this.LightIntensity);
			this.BBIMPFGLDCP().SetTexture("threshold", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKGAONMOBMH().SetFloat("<color=white>", 1360f / farClipPlane);
			this.PGPEMMBJOOG().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1705f, 898f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x0003D124 File Offset: 0x0003B324
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0003E779 File Offset: 0x0003C979
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0003E7B0 File Offset: 0x0003C9B0
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 810f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.BBIMPFGLDCP().SetFloat("UI Extensions/SoftMaskShader", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("true", this.Fade);
			this.HILDKDFEBPF().SetFloat("DPADHOR", this._FixDistance);
			this.HHIFMIPPMPF().SetFloat("Jan", this.MatrixSize);
			this.OJMHIMIPKME().SetColor("Color's hex value #RRGGBBAA", this._MatrixColor);
			this.DNLMFEGJJDD().SetFloat("_Value4", this.MatrixSpeed * 845f);
			this.GBFOAHKAJEK().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", (float)((!this._Visualize) ? 1 : 0));
			this.IONHGBPGCHK().SetFloat("_TimeX", this.LightIntensity);
			this.IIJMIPBMMBF().SetTexture("_PColor", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.PDEAHJPOMEF().SetFloat("Y", 1243f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("player", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 71f, 1634f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0003E94C File Offset: 0x0003CB4C
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 324f)
			{
				this.HBJJOCHGOPH = 665f;
			}
			this.JFDGLLEOPGB().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("InstantiateRpc", this.Fade);
			this.ABHDNGIHBKE().SetFloat("_BorderSize", this._FixDistance);
			this.ABHDNGIHBKE().SetFloat("PublishButton", this.MatrixSize);
			this.MHBAIEKFBIJ().SetColor("_ScreenResolution", this._MatrixColor);
			this.GHHPOGODBHB().SetFloat("menu.playedpage", this.MatrixSpeed * 103f);
			this.HEINDEMCGIK().SetFloat("_Value2", (float)((!this._Visualize) ? 1 : 1));
			this.OJMHIMIPKME().SetFloat("_ScreenResolution", this.LightIntensity);
			this.IIJMIPBMMBF().SetTexture("LevelInfoInputField", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("offsets", 1391f / farClipPlane);
			this.GBFOAHKAJEK().SetVector("_Parasite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 136f, 1792f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1606f)
			{
				this.HBJJOCHGOPH = 1955f;
			}
			this.FHFLKLMFHOI().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/TV_WideScreenVertical", this.Fade);
			this.CBCNOEIALHB().SetFloat("Run a command for the Localization Servise", this._FixDistance);
			this.FKEOGPDLBDD().SetFloat("Xbox Home", this.MatrixSize);
			this.DNLMFEGJJDD().SetColor("_MainTex2", this._MatrixColor);
			this.PGPEMMBJOOG().SetFloat("offsets", this.MatrixSpeed * 959f);
			this.JFDGLLEOPGB().SetFloat("[MenuScene] Error: ", (float)((!this._Visualize) ? 0 : 1));
			this.OJMHIMIPKME().SetFloat("[SoundManager] Loaded skin audio", this.LightIntensity);
			this.ABHDNGIHBKE().SetTexture(": ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IIJMIPBMMBF().SetFloat("#kicked", 191f / farClipPlane);
			this.HHIFMIPPMPF().SetVector("_ArScale", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1431f, 390f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0003EC81 File Offset: 0x0003CE81
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0003ECB8 File Offset: 0x0003CEB8
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1809f)
			{
				this.HBJJOCHGOPH = 1878f;
			}
			this.HILDKDFEBPF().SetFloat(".GoalProgress", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_Value6", this.Fade);
			this.ADGHJOHKEHG().SetFloat("colorD", this._FixDistance);
			this.IIJMIPBMMBF().SetFloat("_Value5", this.MatrixSize);
			this.ECCPAOBFDKP().SetColor("IconImage", this._MatrixColor);
			this.FKEOGPDLBDD().SetFloat("_Value4", this.MatrixSpeed * 1612f);
			this.MHBAIEKFBIJ().SetFloat("Map: ", (float)((!this._Visualize) ? 0 : 1));
			this.ABHDNGIHBKE().SetFloat("DISTORT", this.LightIntensity);
			this.IONHGBPGCHK().SetTexture("AreaTex", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BBIMPFGLDCP().SetFloat("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", 1498f / farClipPlane);
			this.HEINDEMCGIK().SetVector("x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 271f, 1967f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x0003D124 File Offset: 0x0003B324
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x0003EE54 File Offset: 0x0003D054
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 849f)
			{
				this.HBJJOCHGOPH = 814f;
			}
			this.PGPEMMBJOOG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("colorB", this.Fade);
			this.OJMHIMIPKME().SetFloat("_TimeX", this._FixDistance);
			this.DKNJGHFLAIF().SetFloat("_Color", this.MatrixSize);
			this.EOCCJGIGEGJ().SetColor("_Blurred", this._MatrixColor);
			this.BBIMPFGLDCP().SetFloat("_MainTex2", this.MatrixSpeed * 1221f);
			this.ADGHJOHKEHG().SetFloat("_Value4", (float)((!this._Visualize) ? 1 : 0));
			this.DKNJGHFLAIF().SetFloat("_Distortion", this.LightIntensity);
			this.CECICEGFHKL().SetTexture("OK", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat("CameraFilterPack/Blend2Camera_Lighten", 295f / farClipPlane);
			this.HHIFMIPPMPF().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 743f, 1879f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x0003EFED File Offset: 0x0003D1ED
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x0003F024 File Offset: 0x0003D224
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 941f)
			{
				this.HBJJOCHGOPH = 1929f;
			}
			this.IGKFMCPDNOI().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.Fade);
			this.IGKFMCPDNOI().SetFloat("_SoftZDistance", this._FixDistance);
			this.FHFLKLMFHOI().SetFloat("Triangle", this.MatrixSize);
			this.FGENHBKMPDA().SetColor("UseFinalGlassColor", this._MatrixColor);
			this.HHIFMIPPMPF().SetFloat("\n", this.MatrixSpeed * 832f);
			this.DONENAMLFLF().SetFloat("Color", (float)((!this._Visualize) ? 0 : 1));
			this.IONHGBPGCHK().SetFloat("mapselector.filter.rateduponly", this.LightIntensity);
			this.CECICEGFHKL().SetTexture("_Red_G", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CEKJODEAMGB().SetFloat("_TimeX", 1683f / farClipPlane);
			this.HILDKDFEBPF().SetVector("R2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1639f, 1676f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x0003F1C0 File Offset: 0x0003D3C0
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1532f)
			{
				this.HBJJOCHGOPH = 1348f;
			}
			this.FGENHBKMPDA().SetFloat("ShineEffect", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("DifficultyBG", this.Fade);
			this.IGKFMCPDNOI().SetFloat("id", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("ZoomSpeed", this.MatrixSize);
			this.DNLMFEGJJDD().SetColor("CameraFilterPack/Blend2Camera_Screen", this._MatrixColor);
			this.HEINDEMCGIK().SetFloat("PublishButton", this.MatrixSpeed * 1554f);
			this.ECCPAOBFDKP().SetFloat("{0}{1}{2}", (float)((!this._Visualize) ? 0 : 1));
			this.HILDKDFEBPF().SetFloat("_ScreenSize", this.LightIntensity);
			this.CEKJODEAMGB().SetTexture("Current xp: ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DNLMFEGJJDD().SetFloat("DISTORT", 1461f / farClipPlane);
			this.FHFLKLMFHOI().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 548f, 1744f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x0003F359 File Offset: 0x0003D559
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x0003F390 File Offset: 0x0003D590
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1177f)
			{
				this.HBJJOCHGOPH = 500f;
			}
			this.GBFOAHKAJEK().SetFloat("settings.volume.game", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack/Distortion_Dream", this.Fade);
			this.MHBAIEKFBIJ().SetFloat("_TimeX", this._FixDistance);
			this.IONHGBPGCHK().SetFloat("_ScreenResolution", this.MatrixSize);
			this.PDEAHJPOMEF().SetColor("DPADHOR", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.MatrixSpeed * 1608f);
			this.GBFOAHKAJEK().SetFloat("#", (float)((!this._Visualize) ? 0 : 1));
			this.IIJMIPBMMBF().SetFloat("_CenterY", this.LightIntensity);
			this.DONENAMLFLF().SetTexture("ticket", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FGENHBKMPDA().SetFloat("#ok", 277f / farClipPlane);
			this.MHBAIEKFBIJ().SetVector("Item invalid. No idea why.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 949f, 198f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x0003F5A0 File Offset: 0x0003D7A0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 74f)
			{
				this.HBJJOCHGOPH = 335f;
			}
			this.HHIFMIPPMPF().SetFloat("OnRenderImage in Helper called ...", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_ColorRGB", this.Fade);
			this.HEINDEMCGIK().SetFloat("GameScene", this._FixDistance);
			this.ABHDNGIHBKE().SetFloat(".workshop.json", this.MatrixSize);
			this.CBCNOEIALHB().SetColor("Clear Environment", this._MatrixColor);
			this.HKGAONMOBMH().SetFloat("#no", this.MatrixSpeed * 711f);
			this.IONHGBPGCHK().SetFloat("#failed!", (float)((!this._Visualize) ? 1 : 0));
			this.IONHGBPGCHK().SetFloat("B:", this.LightIntensity);
			this.IGKFMCPDNOI().SetTexture("x", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FHFLKLMFHOI().SetFloat("kick", 1279f / farClipPlane);
			this.EOCCJGIGEGJ().SetVector("player.lollipop", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 21f, 882f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x0003F73C File Offset: 0x0003D93C
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1832f)
			{
				this.HBJJOCHGOPH = 169f;
			}
			this.LPDOGGFOBDH().SetFloat("Up ", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("\r", this.Fade);
			this.GHHPOGODBHB().SetFloat("_Fade", this._FixDistance);
			this.GHHPOGODBHB().SetFloat("_History1LumaTex", this.MatrixSize);
			this.EOCCJGIGEGJ().SetColor("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", this._MatrixColor);
			this.NBPKMLMCHFN.SetFloat("Save level before uploading?", this.MatrixSpeed * 1586f);
			this.FHFLKLMFHOI().SetFloat("DifficultyBG", (float)((!this._Visualize) ? 1 : 0));
			this.FKEOGPDLBDD().SetFloat("_BorderColor", this.LightIntensity);
			this.CEKJODEAMGB().SetTexture("https://www.youtube.com/watch?v=cDVXukrKo74", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CECICEGFHKL().SetFloat("/", 618f / farClipPlane);
			this.EOCCJGIGEGJ().SetVector("curScn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 173f, 121f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x0003F8D5 File Offset: 0x0003DAD5
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("mapselector.filter.rateduponly") as Texture2D);
		this.SCShader = Shader.Find("<color=white>PhotonView Group: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x0003D124 File Offset: 0x0003B324
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x0003F90E File Offset: 0x0003DB0E
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("_Min") as Texture2D);
		this.SCShader = Shader.Find(";");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x0003F947 File Offset: 0x0003DB47
	private void ODMPMJPALID()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find(" cannot be used as a 3D LUT.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x0003F980 File Offset: 0x0003DB80
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("\" gets executed locally only, if at all.") as Texture2D);
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x0003F9B9 File Offset: 0x0003DBB9
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x0003E779 File Offset: 0x0003C979
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x0003F9F0 File Offset: 0x0003DBF0
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("Left Stick Click") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/VHS_Tracking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x0003FA29 File Offset: 0x0003DC29
	private void MEBPBNLBECA()
	{
		this.FPHEBLMINDA = (Resources.Load("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.") as Texture2D);
		this.SCShader = Shader.Find("Unsupported type: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0003FA62 File Offset: 0x0003DC62
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x0003FA99 File Offset: 0x0003DC99
	private void CEDFFAOOPOG()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0003EFED File Offset: 0x0003D1ED
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x0003FAD2 File Offset: 0x0003DCD2
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0003FB09 File Offset: 0x0003DD09
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("bad") as Texture2D);
		this.SCShader = Shader.Find("LastHighScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0003FB44 File Offset: 0x0003DD44
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1721f)
			{
				this.HBJJOCHGOPH = 985f;
			}
			this.IGKFMCPDNOI().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat("MapperNameText", this.Fade);
			this.BBIMPFGLDCP().SetFloat("unsubscribemap", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("\"", this.MatrixSize);
			this.FKEOGPDLBDD().SetColor("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", this._MatrixColor);
			this.CECICEGFHKL().SetFloat("[ItemsHandler] Found ", this.MatrixSpeed * 1744f);
			this.FKEOGPDLBDD().SetFloat("Horizontal", (float)((!this._Visualize) ? 0 : 1));
			this.GHHPOGODBHB().SetFloat("MultiplayerButton", this.LightIntensity);
			this.HEINDEMCGIK().SetTexture("<b>", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.PDEAHJPOMEF().SetFloat("ResetButton", 803f / farClipPlane);
			this.HEINDEMCGIK().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 508f, 1492f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0003FCDD File Offset: 0x0003DEDD
	private void ALJEJJCIMJN()
	{
		this.FPHEBLMINDA = (Resources.Load("effector") as Texture2D);
		this.SCShader = Shader.Find("Unable to get a reward! Try again?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0003FD16 File Offset: 0x0003DF16
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Metrics") as Texture2D);
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x0003FD50 File Offset: 0x0003DF50
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1121f)
			{
				this.HBJJOCHGOPH = 1491f;
			}
			this.HHIFMIPPMPF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.GBFOAHKAJEK().SetFloat("_ScreenResolution", this.Fade);
			this.FHFLKLMFHOI().SetFloat("_StretchWidth", this._FixDistance);
			this.DKNJGHFLAIF().SetFloat("name", this.MatrixSize);
			this.HHIFMIPPMPF().SetColor("_Value", this._MatrixColor);
			this.DONENAMLFLF().SetFloat("Case-Sensitive", this.MatrixSpeed * 412f);
			this.OJMHIMIPKME().SetFloat("00", (float)((!this._Visualize) ? 0 : 0));
			this.ADGHJOHKEHG().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", this.LightIntensity);
			this.MHBAIEKFBIJ().SetTexture("_Parameter", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IGKFMCPDNOI().SetFloat("#ok", 363f / farClipPlane);
			this.BBIMPFGLDCP().SetVector("Operation ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 316f, 1109f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x0003D124 File Offset: 0x0003B324
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x0003FEEC File Offset: 0x0003E0EC
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 45f)
			{
				this.HBJJOCHGOPH = 1568f;
			}
			this.IIJMIPBMMBF().SetFloat("Mouse X", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("_TimeX", this.Fade);
			this.NBPKMLMCHFN.SetFloat("[MenuScene] Error: ", this._FixDistance);
			this.ECCPAOBFDKP().SetFloat("Gameplay/Base", this.MatrixSize);
			this.ADGHJOHKEHG().SetColor("Tab1Content", this._MatrixColor);
			this.CEKJODEAMGB().SetFloat("_FilteredReflections", this.MatrixSpeed * 1575f);
			this.CBCNOEIALHB().SetFloat("menutheme.deleted", (float)((!this._Visualize) ? 1 : 0));
			this.IIJMIPBMMBF().SetFloat("Created", this.LightIntensity);
			this.DONENAMLFLF().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FHFLKLMFHOI().SetFloat(", data: ", 1104f / farClipPlane);
			this.GBFOAHKAJEK().SetVector("No Camera attached!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1902f, 219f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00040085 File Offset: 0x0003E285
	private Material HILDKDFEBPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0003D124 File Offset: 0x0003B324
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x000400BC File Offset: 0x0003E2BC
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x000400F4 File Offset: 0x0003E2F4
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1897f)
			{
				this.HBJJOCHGOPH = 374f;
			}
			this.FKEOGPDLBDD().SetFloat("_Visualize", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("X2", this.Fade);
			this.FHFLKLMFHOI().SetFloat("maps.", this._FixDistance);
			this.CECICEGFHKL().SetFloat("time", this.MatrixSize);
			this.ECCPAOBFDKP().SetColor("_Value", this._MatrixColor);
			this.ECCPAOBFDKP().SetFloat("[PlayerBase] Saveing checkpoint data", this.MatrixSpeed * 1425f);
			this.BBIMPFGLDCP().SetFloat("Set Sun Sensitivity", (float)((!this._Visualize) ? 0 : 1));
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack_Fly_VisionFX", this.LightIntensity);
			this.BBIMPFGLDCP().SetTexture("[", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.ECCPAOBFDKP().SetFloat("_TimeX", 1587f / farClipPlane);
			this.FHFLKLMFHOI().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 916f, 1201f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0003EFED File Offset: 0x0003D1ED
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x0004028D File Offset: 0x0003E48D
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x000402C4 File Offset: 0x0003E4C4
	private void KLILJHJNICK()
	{
		this.FPHEBLMINDA = (Resources.Load("SetEnvSpriteColor") as Texture2D);
		this.SCShader = Shader.Find("Freq: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00040300 File Offset: 0x0003E500
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1612f)
			{
				this.HBJJOCHGOPH = 31f;
			}
			this.CEKJODEAMGB().SetFloat("CameraFilterPack/Distortion_Half_Sphere", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("settings.fps", this.Fade);
			this.BBIMPFGLDCP().SetFloat("[", this._FixDistance);
			this.HNFFHCLNBDN().SetFloat("Drop_Far", this.MatrixSize);
			this.DKNJGHFLAIF().SetColor("ControllerRightX", this._MatrixColor);
			this.HKGAONMOBMH().SetFloat("127.0.0.1", this.MatrixSpeed * 1974f);
			this.FHFLKLMFHOI().SetFloat("note.3", (float)((!this._Visualize) ? 1 : 0));
			this.CBCNOEIALHB().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", this.LightIntensity);
			this.CBCNOEIALHB().SetTexture("_Value7", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FHFLKLMFHOI().SetFloat("_TimeX", 839f / farClipPlane);
			this.BBIMPFGLDCP().SetVector("[Right]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 9f, 1788f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00040499 File Offset: 0x0003E699
	private void JONGNKNLLND()
	{
		this.FPHEBLMINDA = (Resources.Load("1248864821") as Texture2D);
		this.SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0003D124 File Offset: 0x0003B324
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x000404D2 File Offset: 0x0003E6D2
	private void CGDMLHLJIDK()
	{
		this.FPHEBLMINDA = (Resources.Load("mapid") as Texture2D);
		this.SCShader = Shader.Find("_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x0004050B File Offset: 0x0003E70B
	private void MKOMIDCPCDC()
	{
		this.FPHEBLMINDA = (Resources.Load("_Extra2") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00040544 File Offset: 0x0003E744
	private void BEBNOKFLJPH()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0004057D File Offset: 0x0003E77D
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x000405B4 File Offset: 0x0003E7B4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1117f)
			{
				this.HBJJOCHGOPH = 291f;
			}
			this.OJMHIMIPKME().SetFloat("Please attach component to a Graphical UI component", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("Result for ", this.Fade);
			this.HNFFHCLNBDN().SetFloat("Tab2Content", this._FixDistance);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.MatrixSize);
			this.CEKJODEAMGB().SetColor("_ScreenResolution", this._MatrixColor);
			this.CEKJODEAMGB().SetFloat("/icon", this.MatrixSpeed * 211f);
			this.EOCCJGIGEGJ().SetFloat("offsets", (float)((!this._Visualize) ? 1 : 0));
			this.CBCNOEIALHB().SetFloat("Tab2Content", this.LightIntensity);
			this.PDEAHJPOMEF().SetTexture("[ImageLoader] Loaded image from ", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EOCCJGIGEGJ().SetFloat("Set Sun Emission", 1801f / farClipPlane);
			this.PGPEMMBJOOG().SetVector("input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1234f, 253f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0003D124 File Offset: 0x0003B324
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0004074D File Offset: 0x0003E94D
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load("ResourcesConfig") as Texture2D);
		this.SCShader = Shader.Find("LevelInfoInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00040788 File Offset: 0x0003E988
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

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000865 RID: 2149 RVA: 0x00040921 File Offset: 0x0003EB21
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

	// Token: 0x06000866 RID: 2150 RVA: 0x0003D124 File Offset: 0x0003B324
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00040958 File Offset: 0x0003EB58
	private void CFFCLAHMBAA()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.enableranking") as Texture2D);
		this.SCShader = Shader.Find("IntraSig");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x0003D124 File Offset: 0x0003B324
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0003D124 File Offset: 0x0003B324
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0003D124 File Offset: 0x0003B324
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00040994 File Offset: 0x0003EB94
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 631f)
			{
				this.HBJJOCHGOPH = 927f;
			}
			this.HKGAONMOBMH().SetFloat("CurrentTimeLabel", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("InfoText", this.Fade);
			this.HNFFHCLNBDN().SetFloat("id", this._FixDistance);
			this.EOCCJGIGEGJ().SetFloat(". The group number should be at least 1.", this.MatrixSize);
			this.FGENHBKMPDA().SetColor("_ScreenResolution", this._MatrixColor);
			this.PDEAHJPOMEF().SetFloat("Tab2Content", this.MatrixSpeed * 948f);
			this.HKGAONMOBMH().SetFloat("' has been reset to the fault value", (float)((!this._Visualize) ? 0 : 0));
			this.FHFLKLMFHOI().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", this.LightIntensity);
			this.ADGHJOHKEHG().SetTexture("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", this.FPHEBLMINDA);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat("PLEASE WAIT", 31f / farClipPlane);
			this.CBCNOEIALHB().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 660f, 155f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00040B2D File Offset: 0x0003ED2D
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0003D124 File Offset: 0x0003B324
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00040B64 File Offset: 0x0003ED64
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load(".completed") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x0003D124 File Offset: 0x0003B324
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0003E2F6 File Offset: 0x0003C4F6
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000137 RID: 311
	public Shader SCShader;

	// Token: 0x04000138 RID: 312
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000139 RID: 313
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400013A RID: 314
	private Material BJFKDHHMLJH;

	// Token: 0x0400013B RID: 315
	public bool _Visualize;

	// Token: 0x0400013C RID: 316
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x0400013D RID: 317
	[Range(-5f, 5f)]
	public float LightIntensity = 1f;

	// Token: 0x0400013E RID: 318
	[Range(0f, 6f)]
	public float MatrixSize = 1f;

	// Token: 0x0400013F RID: 319
	[Range(-4f, 4f)]
	public float MatrixSpeed = 1f;

	// Token: 0x04000140 RID: 320
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000141 RID: 321
	public Color _MatrixColor = new Color(0f, 1f, 0f, 1f);

	// Token: 0x04000142 RID: 322
	public static Color ChangeColorRGB;

	// Token: 0x04000143 RID: 323
	private Texture2D FPHEBLMINDA;
}
