using System;
using UnityEngine;

// Token: 0x02000028 RID: 40
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Shield")]
public class CameraFilterPack_3D_Shield : MonoBehaviour
{
	// Token: 0x060009EA RID: 2538 RVA: 0x0004B95F File Offset: 0x00049B5F
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x0004B996 File Offset: 0x00049B96
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x0004B9CD File Offset: 0x00049BCD
	private Material DCCHGBHLAAF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x0004BA24 File Offset: 0x00049C24
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 1553f;
			}
			this.KEMAALEODNH().SetFloat("_Distortion", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 979f)
				{
					this._Distance = 1687f;
				}
				if (this._Distance < 675f)
				{
					this._Distance = 38f;
				}
				this.CECJJMKLEAK().SetFloat("Bad parameters for getstring! Use <key> <value>", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("ItemsCountText", this._Distance);
			}
			this.MJJIEHANFJA().SetFloat("recipes", this._Size);
			this.PLBEJJIHFPB().SetFloat("x", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("Drop_With_Obj", this.LightIntensity * 366f);
			this.FGENHBKMPDA().SetFloat("_MainTex2", (float)((!this._Visualize) ? 1 : 1));
			this.IIBLJCKLGFG().SetFloat("Error: Timeout :S", this._FadeShield);
			this.CIAFLBFJLEJ().SetFloat("00", this.Speed);
			this.FEAEGGCNIAA().SetFloat("_Value8", this.Speed_X);
			this.CIAFLBFJLEJ().SetFloat("OnSerialize", this.Speed_Y);
			this.GJHPODJOBHL().SetFloat("Internal LUT", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLGPDBBKAIP().SetFloat("_TimeX", 562f / farClipPlane);
			this.ACHNOHCLGOO().SetVector("_CenterX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1576f, 846f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x0004BC5E File Offset: 0x00049E5E
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x0004BC82 File Offset: 0x00049E82
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0004BCA6 File Offset: 0x00049EA6
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x0004BCCA File Offset: 0x00049ECA
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0004BD01 File Offset: 0x00049F01
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0004BDC4 File Offset: 0x00049FC4
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x0004BDFB File Offset: 0x00049FFB
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("Updating...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0004BE20 File Offset: 0x0004A020
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 191f)
			{
				this.HBJJOCHGOPH = 1974f;
			}
			this.HNICHJCGJOC().SetFloat("[GameScene] Checkpoints count: ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 951f)
				{
					this._Distance = 1486f;
				}
				if (this._Distance < 412f)
				{
					this._Distance = 50f;
				}
				this.DCCHGBHLAAF().SetFloat("HightScoreMaxPointsText", this._Distance);
			}
			else
			{
				this.DCCHGBHLAAF().SetFloat("Using Stopwatch as precision timer for PUN.", this._Distance);
			}
			this.BFGNMFCNDBC().SetFloat("#{0:X2}{1:X2}{2:X2}", this._Size);
			this.KOHGPKOFEJO().SetFloat("/", this._FixDistance);
			this.HJGEHJDMCGI().SetFloat("\n", this.LightIntensity * 756f);
			this.DEFBJOCJJKF().SetFloat("_StretchWidth", (float)((!this._Visualize) ? 1 : 1));
			this.PLBEJJIHFPB().SetFloat(".lastCheckpoint.correctScore", this._FadeShield);
			this.LELKBCALFCF().SetFloat("_Value", this.Speed);
			this.DEFBJOCJJKF().SetFloat("No Name", this.Speed_X);
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", this.Speed_Y);
			this.BFGNMFCNDBC().SetFloat("_Threshold", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HEINDEMCGIK().SetFloat("_PositionX", 1230f / farClipPlane);
			this.HNICHJCGJOC().SetVector("_Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 550f, 856f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0004C05A File Offset: 0x0004A25A
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x0004C07E File Offset: 0x0004A27E
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0004C0A2 File Offset: 0x0004A2A2
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("https://twitch.tv/intralism");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x0004C0C6 File Offset: 0x0004A2C6
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("musicVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x0004C0EC File Offset: 0x0004A2EC
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 353f)
			{
				this.HBJJOCHGOPH = 786f;
			}
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/OldFilm_Cutting1", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 317f)
				{
					this._Distance = 317f;
				}
				if (this._Distance < 1864f)
				{
					this._Distance = 634f;
				}
				this.PLBEJJIHFPB().SetFloat("HiddenToggle", this._Distance);
			}
			else
			{
				this.FLGPDBBKAIP().SetFloat("_ScreenResolution", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("mapselector.filter.favoriteonly", this._Size);
			this.KEMAALEODNH().SetFloat("_Vignette", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("ViewMenu", this.LightIntensity * 1352f);
			this.PLBEJJIHFPB().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.OKJOKHGJHGF().SetFloat(".lastCheckpoint.correctScore", this._FadeShield);
			this.DEFBJOCJJKF().SetFloat(".lastCheckpoint.incorrectScore", this.Speed);
			this.NBMPPNFKFLB().SetFloat("_BlurTexture", this.Speed_X);
			this.PLBEJJIHFPB().SetFloat("HPText", this.Speed_Y);
			this.PLBEJJIHFPB().SetFloat("_Threshhold", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FGENHBKMPDA().SetFloat("Metal", 291f / farClipPlane);
			this.MJJIEHANFJA().SetVector("Init", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 228f, 1505f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0004C326 File Offset: 0x0004A526
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x0004C35D File Offset: 0x0004A55D
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("_BlurCoe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0004C381 File Offset: 0x0004A581
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0004C3B8 File Offset: 0x0004A5B8
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[Sound Manager] Audio clip is null, cannot play sound");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x0004C3DC File Offset: 0x0004A5DC
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 421f)
			{
				this.HBJJOCHGOPH = 1944f;
			}
			this.HNICHJCGJOC().SetFloat("_NoisePerChannel", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1003f)
				{
					this._Distance = 27f;
				}
				if (this._Distance < 1436f)
				{
					this._Distance = 1100f;
				}
				this.CIAFLBFJLEJ().SetFloat("[SERVER] Selected mode: ", this._Distance);
			}
			else
			{
				this.PGPEMMBJOOG().SetFloat("roomDescription", this._Distance);
			}
			this.FLGPDBBKAIP().SetFloat("HighScaleShot", this._Size);
			this.FKEOGPDLBDD().SetFloat("_Fade", this._FixDistance);
			this.IIBLJCKLGFG().SetFloat("RestartButton", this.LightIntensity * 948f);
			this.MJJIEHANFJA().SetFloat("2hands", (float)((!this._Visualize) ? 0 : 0));
			this.FLGPDBBKAIP().SetFloat("menu.tabid", this._FadeShield);
			this.HEINDEMCGIK().SetFloat("_Offsets", this.Speed);
			this.MJJIEHANFJA().SetFloat("11", this.Speed_X);
			this.LELKBCALFCF().SetFloat("Object ID. Case-Sensitive", this.Speed_Y);
			this.GJHPODJOBHL().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_GlowColor", 1988f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("_MinVelocity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 970f, 1074f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x0004C616 File Offset: 0x0004A816
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x0004C64D File Offset: 0x0004A84D
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x0004C684 File Offset: 0x0004A884
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 445f)
			{
				this.HBJJOCHGOPH = 1000f;
			}
			this.ACHNOHCLGOO().SetFloat("Gameplay/particles", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1281f)
				{
					this._Distance = 1006f;
				}
				if (this._Distance < 1855f)
				{
					this._Distance = 293f;
				}
				this.IIBLJCKLGFG().SetFloat("GlassColor", this._Distance);
			}
			else
			{
				this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Edge_Sigmoid", this._Distance);
			}
			this.KEMAALEODNH().SetFloat("/", this._Size);
			this.FEAEGGCNIAA().SetFloat("_Val", this._FixDistance);
			this.DCCHGBHLAAF().SetFloat("CameraFilterPack/Distortion_Flush", this.LightIntensity * 1304f);
			this.CECJJMKLEAK().SetFloat("HPText", (float)((!this._Visualize) ? 1 : 0));
			this.PLBEJJIHFPB().SetFloat("ready", this._FadeShield);
			this.OIIDAKBILMI().SetFloat("menutheme.deleted", this.Speed);
			this.FLGPDBBKAIP().SetFloat("Winter2020", this.Speed_X);
			this.OKJOKHGJHGF().SetFloat("ItemNameText", this.Speed_Y);
			this.LELKBCALFCF().SetFloat("/", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GJHPODJOBHL().SetFloat("editor.", 1842f / farClipPlane);
			this.IIJMIPBMMBF().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 14f, 72f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x0004C8BE File Offset: 0x0004AABE
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0004C8F5 File Offset: 0x0004AAF5
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("Joystick1Button0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x0004C919 File Offset: 0x0004AB19
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x0004C950 File Offset: 0x0004AB50
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("settings.volume.game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x0004C974 File Offset: 0x0004AB74
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x0004C998 File Offset: 0x0004AB98
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1429f)
			{
				this.HBJJOCHGOPH = 1963f;
			}
			this.OIIDAKBILMI().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1601f)
				{
					this._Distance = 1391f;
				}
				if (this._Distance < 1019f)
				{
					this._Distance = 0f;
				}
				this.JFDGLLEOPGB().SetFloat("player.xp", this._Distance);
			}
			else
			{
				this.BFGNMFCNDBC().SetFloat("ConfigVersionSlider", this._Distance);
			}
			this.FLGPDBBKAIP().SetFloat("#TBD", this._Size);
			this.FGENHBKMPDA().SetFloat("menu.relaxinfo", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("/", this.LightIntensity * 320f);
			this.IIJMIPBMMBF().SetFloat("YES", (float)((!this._Visualize) ? 0 : 0));
			this.NBPKMLMCHFN.SetFloat("ComboText", this._FadeShield);
			this.CIAFLBFJLEJ().SetFloat("menu.tabid", this.Speed);
			this.PGPEMMBJOOG().SetFloat("_Value4", this.Speed_X);
			this.CECJJMKLEAK().SetFloat("seconds", this.Speed_Y);
			this.BFGNMFCNDBC().SetFloat("Outgoing: \n", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", 476f / farClipPlane);
			this.PGPEMMBJOOG().SetVector("UseScanLine", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 373f, 1925f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A1A RID: 2586 RVA: 0x0004CBD4 File Offset: 0x0004ADD4
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 460f)
			{
				this.HBJJOCHGOPH = 1072f;
			}
			this.DCCHGBHLAAF().SetFloat("_Green_C", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 53f)
				{
					this._Distance = 1682f;
				}
				if (this._Distance < 973f)
				{
					this._Distance = 233f;
				}
				this.HEINDEMCGIK().SetFloat("maps.", this._Distance);
			}
			else
			{
				this.PGPEMMBJOOG().SetFloat(" isInactive: ", this._Distance);
			}
			this.CIAFLBFJLEJ().SetFloat("settings_bindings_", this._Size);
			this.PGPEMMBJOOG().SetFloat("Case-Sensitive", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("_TimeX", this.LightIntensity * 1941f);
			this.JFDGLLEOPGB().SetFloat("seconds", (float)((!this._Visualize) ? 0 : 0));
			this.GJHPODJOBHL().SetFloat(" [", this._FadeShield);
			this.OKJOKHGJHGF().SetFloat("_Value5", this.Speed);
			this.PLBEJJIHFPB().SetFloat("TimeBGSlider", this.Speed_X);
			this.LPPEPKGFOEM().SetFloat("_Intensity", this.Speed_Y);
			this.IIBLJCKLGFG().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GJHPODJOBHL().SetFloat("1.87", 483f / farClipPlane);
			this.DEFBJOCJJKF().SetVector("_FadeDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1735f, 81f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x0004CE0E File Offset: 0x0004B00E
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("Health Stats");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x0004CE34 File Offset: 0x0004B034
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1755f)
			{
				this.HBJJOCHGOPH = 618f;
			}
			this.PGPEMMBJOOG().SetFloat("SetSunColors", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1801f)
				{
					this._Distance = 1985f;
				}
				if (this._Distance < 513f)
				{
					this._Distance = 839f;
				}
				this.NBPKMLMCHFN.SetFloat("B:", this._Distance);
			}
			else
			{
				this.OKJOKHGJHGF().SetFloat("_ReflectionTexture4", this._Distance);
			}
			this.DEFBJOCJJKF().SetFloat("ChallengesButton", this._Size);
			this.JFDGLLEOPGB().SetFloat("Case-Sensitive", this._FixDistance);
			this.LELKBCALFCF().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.LightIntensity * 921f);
			this.FKEOGPDLBDD().SetFloat("SetLives", (float)((!this._Visualize) ? 1 : 0));
			this.LPPEPKGFOEM().SetFloat("BloomShaderValueSlider", this._FadeShield);
			this.FLGPDBBKAIP().SetFloat(":", this.Speed);
			this.DCCHGBHLAAF().SetFloat("_Bullet_12", this.Speed_X);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.Speed_Y);
			this.OIIDAKBILMI().SetFloat("colorB", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat(" ", 1748f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("curScn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 746f, 1198f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x0004D070 File Offset: 0x0004B270
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1111f)
			{
				this.HBJJOCHGOPH = 781f;
			}
			this.KEMAALEODNH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 981f)
				{
					this._Distance = 884f;
				}
				if (this._Distance < 1824f)
				{
					this._Distance = 1752f;
				}
				this.FGENHBKMPDA().SetFloat("f", this._Distance);
			}
			else
			{
				this.ACHNOHCLGOO().SetFloat("#", this._Distance);
			}
			this.OKJOKHGJHGF().SetFloat("{0} seconds ago", this._Size);
			this.KEMAALEODNH().SetFloat("GhostPosY", this._FixDistance);
			this.OKJOKHGJHGF().SetFloat(".", this.LightIntensity * 160f);
			this.JFDGLLEOPGB().SetFloat("_FlipAlphaMask", (float)((!this._Visualize) ? 0 : 1));
			this.GJHPODJOBHL().SetFloat("_EmissionColor", this._FadeShield);
			this.FKEOGPDLBDD().SetFloat(":", this.Speed);
			this.CIAFLBFJLEJ().SetFloat("Moved event", this.Speed_X);
			this.HEINDEMCGIK().SetFloat("Hex value #RRGGBB", this.Speed_Y);
			this.MJJIEHANFJA().SetFloat("[MenuScene] Error: ", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LELKBCALFCF().SetFloat("CameraFilterPack/Vision_SniperScore", 1312f / farClipPlane);
			this.FGENHBKMPDA().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1708f, 1200f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0004D2AC File Offset: 0x0004B4AC
	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 801f)
			{
				this.HBJJOCHGOPH = 1973f;
			}
			this.FEAEGGCNIAA().SetFloat("_Value2", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1568f)
				{
					this._Distance = 190f;
				}
				if (this._Distance < 840f)
				{
					this._Distance = 332f;
				}
				this.FGENHBKMPDA().SetFloat(" x ", this._Distance);
			}
			else
			{
				this.HEINDEMCGIK().SetFloat(".", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack/FX_Mirror", this._Size);
			this.MJJIEHANFJA().SetFloat("No", this._FixDistance);
			this.CIAFLBFJLEJ().SetFloat("Items/", this.LightIntensity * 382f);
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 1));
			this.IGKFMCPDNOI().SetFloat(".highscore", this._FadeShield);
			this.HJGEHJDMCGI().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", this.Speed);
			this.PLBEJJIHFPB().SetFloat("y", this.Speed_X);
			this.HEINDEMCGIK().SetFloat("#obtained", this.Speed_Y);
			this.OKJOKHGJHGF().SetFloat("_LoopCount", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BFGNMFCNDBC().SetFloat("EXCEPTION:", 633f / farClipPlane);
			this.LELKBCALFCF().SetVector("saveGameName ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 761f, 1873f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x0004D4E8 File Offset: 0x0004B6E8
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 203f;
			}
			this.FKEOGPDLBDD().SetFloat("_ArScale", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1706f)
				{
					this._Distance = 1121f;
				}
				if (this._Distance < 1598f)
				{
					this._Distance = 32f;
				}
				this.LELKBCALFCF().SetFloat("_Value4", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("_Contrast", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("ResourceFileSelector", this._Size);
			this.HNICHJCGJOC().SetFloat("maps.", this._FixDistance);
			this.IGKFMCPDNOI().SetFloat("LevelInfoInputField", this.LightIntensity * 1874f);
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this._FadeShield);
			this.IIJMIPBMMBF().SetFloat("tagElement", this.Speed);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Blend2Camera_Overlay", this.Speed_X);
			this.CIAFLBFJLEJ().SetFloat(".lastCheckpoint.bgcolor", this.Speed_Y);
			this.MJJIEHANFJA().SetFloat("shader.future", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBMPPNFKFLB().SetFloat("_Value4", 1846f / farClipPlane);
			this.FGENHBKMPDA().SetVector("mapid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1083f, 980f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x0004D722 File Offset: 0x0004B922
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Shield");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x0004D748 File Offset: 0x0004B948
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 638f)
			{
				this.HBJJOCHGOPH = 933f;
			}
			this.MJJIEHANFJA().SetFloat("[Left]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1054f)
				{
					this._Distance = 855f;
				}
				if (this._Distance < 202f)
				{
					this._Distance = 1727f;
				}
				this.OIIDAKBILMI().SetFloat("CameraFilterPack/Drawing_BluePrint", this._Distance);
			}
			else
			{
				this.HNICHJCGJOC().SetFloat("PlayButton", this._Distance);
			}
			this.PLBEJJIHFPB().SetFloat("settings_bindings_controller_type", this._Size);
			this.ACHNOHCLGOO().SetFloat("_BlurVector", this._FixDistance);
			this.LELKBCALFCF().SetFloat(" SphereWaveform.cs", this.LightIntensity * 499f);
			this.KEMAALEODNH().SetFloat("_ReflectionTexture0", (float)((!this._Visualize) ? 1 : 1));
			this.HJGEHJDMCGI().SetFloat("replayData", this._FadeShield);
			this.IGKFMCPDNOI().SetFloat("ok", this.Speed);
			this.NBMPPNFKFLB().SetFloat("_Value", this.Speed_X);
			this.IIJMIPBMMBF().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", this.Speed_Y);
			this.CECJJMKLEAK().SetFloat("_TimeX", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CIAFLBFJLEJ().SetFloat("Joystick1Button2", 1954f / farClipPlane);
			this.FEAEGGCNIAA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1690f, 1609f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x0004D982 File Offset: 0x0004BB82
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x0004D9B9 File Offset: 0x0004BBB9
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("wss://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x0004D9E0 File Offset: 0x0004BBE0
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 749f)
			{
				this.HBJJOCHGOPH = 780f;
			}
			this.FLGPDBBKAIP().SetFloat("FavoriteButton", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 890f)
				{
					this._Distance = 335f;
				}
				if (this._Distance < 1578f)
				{
					this._Distance = 815f;
				}
				this.LPPEPKGFOEM().SetFloat("1248864821", this._Distance);
			}
			else
			{
				this.IIJMIPBMMBF().SetFloat("_Value3", this._Distance);
			}
			this.LELKBCALFCF().SetFloat("[FileSelector] Dialog canceled", this._Size);
			this.NBPKMLMCHFN.SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("InfoCanvas", this.LightIntensity * 1262f);
			this.PLBEJJIHFPB().SetFloat("_ChannelMixerRed", (float)((!this._Visualize) ? 0 : 0));
			this.IIJMIPBMMBF().SetFloat("Sending RPC \"", this._FadeShield);
			this.HNICHJCGJOC().SetFloat("#no", this.Speed);
			this.FEAEGGCNIAA().SetFloat("GlassAberration", this.Speed_X);
			this.HNICHJCGJOC().SetFloat("#highscore", this.Speed_Y);
			this.HNICHJCGJOC().SetFloat(".", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CIAFLBFJLEJ().SetFloat("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", 741f / farClipPlane);
			this.HNICHJCGJOC().SetVector("Alpha", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 954f, 1416f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x0004DC1A File Offset: 0x0004BE1A
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x0004DC51 File Offset: 0x0004BE51
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x0004DC88 File Offset: 0x0004BE88
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x0004DCBF File Offset: 0x0004BEBF
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x0004DCF8 File Offset: 0x0004BEF8
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 194f)
			{
				this.HBJJOCHGOPH = 313f;
			}
			this.KEMAALEODNH().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1335f)
				{
					this._Distance = 479f;
				}
				if (this._Distance < 91f)
				{
					this._Distance = 1495f;
				}
				this.MJJIEHANFJA().SetFloat("_Value6", this._Distance);
			}
			else
			{
				this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Oculus_ThermaVision", this._Distance);
			}
			this.NBMPPNFKFLB().SetFloat("EnableRankedNotificationsToggle", this._Size);
			this.IGKFMCPDNOI().SetFloat("STICKLVER", this._FixDistance);
			this.GJHPODJOBHL().SetFloat("The region arrays from Name Server are not ok. Must be non-null and same length. ", this.LightIntensity * 1990f);
			this.JFDGLLEOPGB().SetFloat("1", (float)((!this._Visualize) ? 1 : 1));
			this.NBPKMLMCHFN.SetFloat("\nCreated by Oxy949", this._FadeShield);
			this.BFGNMFCNDBC().SetFloat("UseScanLineSize", this.Speed);
			this.DCCHGBHLAAF().SetFloat("]", this.Speed_X);
			this.LELKBCALFCF().SetFloat("#outdatedmap! Challenges will not work!", this.Speed_Y);
			this.HNICHJCGJOC().SetFloat("_Curve", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMAALEODNH().SetFloat("_SpawnHeuristic", 359f / farClipPlane);
			this.OKJOKHGJHGF().SetVector("_PrefilterOffs", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 438f, 586f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x0004DF34 File Offset: 0x0004C134
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1661f)
			{
				this.HBJJOCHGOPH = 1430f;
			}
			this.GJHPODJOBHL().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 542f)
				{
					this._Distance = 1226f;
				}
				if (this._Distance < 1150f)
				{
					this._Distance = 654f;
				}
				this.LELKBCALFCF().SetFloat("Children", this._Distance);
			}
			else
			{
				this.DCCHGBHLAAF().SetFloat("_ScreenResolution", this._Distance);
			}
			this.KOHGPKOFEJO().SetFloat("Delete events", this._Size);
			this.NBPKMLMCHFN.SetFloat("bpmgrid", this._FixDistance);
			this.CIAFLBFJLEJ().SetFloat("SetEnvSpriteColor", this.LightIntensity * 511f);
			this.OKJOKHGJHGF().SetFloat("masterSteamID", (float)((!this._Visualize) ? 1 : 0));
			this.DEFBJOCJJKF().SetFloat("_ForceYSwap", this._FadeShield);
			this.KEMAALEODNH().SetFloat("[NetworkManager] Joined main lobby", this.Speed);
			this.CIAFLBFJLEJ().SetFloat("EventMenu", this.Speed_X);
			this.PGPEMMBJOOG().SetFloat("#ok", this.Speed_Y);
			this.FKEOGPDLBDD().SetFloat("ChangeSelectedLevel", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BFGNMFCNDBC().SetFloat("_Green_C", 908f / farClipPlane);
			this.NBMPPNFKFLB().SetVector("_FullResolutionFiltering", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1271f, 839f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x0004E16E File Offset: 0x0004C36E
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("VIGNETTE_BLUR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x0004E192 File Offset: 0x0004C392
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x0004E1C9 File Offset: 0x0004C3C9
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x0004BC5E File Offset: 0x00049E5E
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x0004E1F0 File Offset: 0x0004C3F0
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 55f)
			{
				this.HBJJOCHGOPH = 1157f;
			}
			this.KEMAALEODNH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 913f)
				{
					this._Distance = 1486f;
				}
				if (this._Distance < 1007f)
				{
					this._Distance = 1047f;
				}
				this.PLBEJJIHFPB().SetFloat("_FixDistance", this._Distance);
			}
			else
			{
				this.LPPEPKGFOEM().SetFloat("UseScanLine", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("_FarCamera", this._Size);
			this.DCCHGBHLAAF().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this._FixDistance);
			this.LELKBCALFCF().SetFloat("_TimeX", this.LightIntensity * 964f);
			this.NBPKMLMCHFN.SetFloat("settings.enablehitsoundsinnormal", (float)((!this._Visualize) ? 0 : 1));
			this.NBMPPNFKFLB().SetFloat("_TimeX", this._FadeShield);
			this.HNICHJCGJOC().SetFloat("_FixDistance", this.Speed);
			this.LPPEPKGFOEM().SetFloat("_Intensity", this.Speed_X);
			this.PLBEJJIHFPB().SetFloat("Drop_With_Obj", this.Speed_Y);
			this.FKEOGPDLBDD().SetFloat("/", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBMPPNFKFLB().SetFloat("maps.", 1047f / farClipPlane);
			this.NBMPPNFKFLB().SetVector("Can not SetMasterClient(). Not in room or in offlineMode.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 257f, 530f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x0004E42A File Offset: 0x0004C62A
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("\" for viewID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x0004E450 File Offset: 0x0004C650
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 411f)
			{
				this.HBJJOCHGOPH = 1348f;
			}
			this.IIJMIPBMMBF().SetFloat("masterSteamID", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 787f)
				{
					this._Distance = 1812f;
				}
				if (this._Distance < 1740f)
				{
					this._Distance = 1785f;
				}
				this.IIBLJCKLGFG().SetFloat("_Bullet_6", this._Distance);
			}
			else
			{
				this.FLGPDBBKAIP().SetFloat("#random #rare #item", this._Distance);
			}
			this.CECJJMKLEAK().SetFloat("_Value4", this._Size);
			this.MJJIEHANFJA().SetFloat("LT", this._FixDistance);
			this.PLBEJJIHFPB().SetFloat("{0}", this.LightIntensity * 1389f);
			this.LELKBCALFCF().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 0 : 0));
			this.OIIDAKBILMI().SetFloat("#exit", this._FadeShield);
			this.CECJJMKLEAK().SetFloat("CameraFilterPack/Drawing_Crosshatch", this.Speed);
			this.CECJJMKLEAK().SetFloat("Drop_With_Obj", this.Speed_X);
			this.FEAEGGCNIAA().SetFloat("help", this.Speed_Y);
			this.HJGEHJDMCGI().SetFloat("inventory.itemscash", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OIIDAKBILMI().SetFloat("_Value", 740f / farClipPlane);
			this.HNICHJCGJOC().SetVector("_PosY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 458f, 1289f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x0004E68A File Offset: 0x0004C88A
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("Paste events");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x0004E6B0 File Offset: 0x0004C8B0
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1053f)
			{
				this.HBJJOCHGOPH = 623f;
			}
			this.KEMAALEODNH().SetFloat("SettingsCanvas", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 472f)
				{
					this._Distance = 1387f;
				}
				if (this._Distance < 574f)
				{
					this._Distance = 880f;
				}
				this.PLBEJJIHFPB().SetFloat("_Value5", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("_TimeX", this._Distance);
			}
			this.FGENHBKMPDA().SetFloat("  |  Events Count: ", this._Size);
			this.BFGNMFCNDBC().SetFloat("_Value2", this._FixDistance);
			this.NBMPPNFKFLB().SetFloat("offsets", this.LightIntensity * 1006f);
			this.FLGPDBBKAIP().SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 0));
			this.IIBLJCKLGFG().SetFloat("offsets", this._FadeShield);
			this.FGENHBKMPDA().SetFloat("LivesSlider", this.Speed);
			this.PGPEMMBJOOG().SetFloat("UI/Particles/Hidden", this.Speed_X);
			this.OIIDAKBILMI().SetFloat("/config", this.Speed_Y);
			this.DCCHGBHLAAF().SetFloat("_Value6", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FEAEGGCNIAA().SetFloat("Have you fully accept the terms?", 194f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 57f, 157f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DCCHGBHLAAF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x0004E8EA File Offset: 0x0004CAEA
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x0004E921 File Offset: 0x0004CB21
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("[");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x0004E945 File Offset: 0x0004CB45
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x0004E97C File Offset: 0x0004CB7C
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x0004E9B3 File Offset: 0x0004CBB3
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0004E9EA File Offset: 0x0004CBEA
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

	// Token: 0x06000A42 RID: 2626 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0004EA21 File Offset: 0x0004CC21
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x0004EA45 File Offset: 0x0004CC45
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("SetParticlesCountPerBeat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x0004EA69 File Offset: 0x0004CC69
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x0004EA8D File Offset: 0x0004CC8D
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0004EAB1 File Offset: 0x0004CCB1
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("_SoftZDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x0004EAD5 File Offset: 0x0004CCD5
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x0004EB0C File Offset: 0x0004CD0C
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
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FadeShield", this._FadeShield);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed_X);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Speed_Y);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Intensity);
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

	// Token: 0x06000A4E RID: 2638 RVA: 0x0004ED48 File Offset: 0x0004CF48
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1192f)
			{
				this.HBJJOCHGOPH = 852f;
			}
			this.CECJJMKLEAK().SetFloat(", ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 372f)
				{
					this._Distance = 589f;
				}
				if (this._Distance < 992f)
				{
					this._Distance = 312f;
				}
				this.IIBLJCKLGFG().SetFloat("_Value2", this._Distance);
			}
			else
			{
				this.IIJMIPBMMBF().SetFloat("_Value2", this._Distance);
			}
			this.IIBLJCKLGFG().SetFloat("_TimeX", this._Size);
			this.GJHPODJOBHL().SetFloat("_PixelsPerMeterAtOneMeter", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("Spawn new environment sprite (image) and sets its id", this.LightIntensity * 1613f);
			this.OKJOKHGJHGF().SetFloat("[PlayerBase] MapEnd error: ", (float)((!this._Visualize) ? 1 : 0));
			this.GJHPODJOBHL().SetFloat("[ResourcesManager] Load text error: not found", this._FadeShield);
			this.CIAFLBFJLEJ().SetFloat("Identity LUT", this.Speed);
			this.ACHNOHCLGOO().SetFloat("status", this.Speed_X);
			this.FEAEGGCNIAA().SetFloat("New resource ID. Case-Sensitive", this.Speed_Y);
			this.LPPEPKGFOEM().SetFloat("settings.arcsnohitsoundtimedelay", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OKJOKHGJHGF().SetFloat("Data", 692f / farClipPlane);
			this.FGENHBKMPDA().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1993f, 1354f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0004EF82 File Offset: 0x0004D182
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Drunk2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0004EFA6 File Offset: 0x0004D1A6
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x0004EFDD File Offset: 0x0004D1DD
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x0004F004 File Offset: 0x0004D204
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1886f)
			{
				this.HBJJOCHGOPH = 742f;
			}
			this.HEINDEMCGIK().SetFloat("_AdaptationMin", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 568f)
				{
					this._Distance = 1850f;
				}
				if (this._Distance < 1242f)
				{
					this._Distance = 1030f;
				}
				this.IIBLJCKLGFG().SetFloat("/?player=", this._Distance);
			}
			else
			{
				this.HJGEHJDMCGI().SetFloat("Paste events", this._Distance);
			}
			this.FKEOGPDLBDD().SetFloat("Unsupported target enum: ", this._Size);
			this.OIIDAKBILMI().SetFloat("Set object anchor to another object", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat(".highscore", this.LightIntensity * 628f);
			this.DCCHGBHLAAF().SetFloat("ItemNameBGImage", (float)((!this._Visualize) ? 1 : 0));
			this.IIJMIPBMMBF().SetFloat("_TimeX", this._FadeShield);
			this.OKJOKHGJHGF().SetFloat("_TimeX", this.Speed);
			this.HEINDEMCGIK().SetFloat(" player(s)", this.Speed_X);
			this.DEFBJOCJJKF().SetFloat("_Value2", this.Speed_Y);
			this.FLGPDBBKAIP().SetFloat("#rategameinfo", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/Distortion_BlackHole", 1368f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("[NetworkManager] Join failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1117f, 1285f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x0004F23E File Offset: 0x0004D43E
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x0002523B File Offset: 0x0002343B
	private void DEEPMOLMGED()
	{
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x0004F275 File Offset: 0x0004D475
	private void GNJDKAECPKA()
	{
		this.SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x0004F299 File Offset: 0x0004D499
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x0004F2D0 File Offset: 0x0004D4D0
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("[PlayerBase] Loading checkpoint data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x0004F2F4 File Offset: 0x0004D4F4
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x0004F32B File Offset: 0x0004D52B
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("_TileTexDebug");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x0004F34F File Offset: 0x0004D54F
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x0004F386 File Offset: 0x0004D586
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x0004F3AA File Offset: 0x0004D5AA
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("PlayMusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x0004F3CE File Offset: 0x0004D5CE
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x0004F3F4 File Offset: 0x0004D5F4
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1920f)
			{
				this.HBJJOCHGOPH = 1069f;
			}
			this.OIIDAKBILMI().SetFloat("[Down]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1641f)
				{
					this._Distance = 1760f;
				}
				if (this._Distance < 1434f)
				{
					this._Distance = 1877f;
				}
				this.HNICHJCGJOC().SetFloat("_MiddleGrey", this._Distance);
			}
			else
			{
				this.OKJOKHGJHGF().SetFloat("_Value", this._Distance);
			}
			this.KEMAALEODNH().SetFloat("_ScreenResolution", this._Size);
			this.HEINDEMCGIK().SetFloat("[ERROR KEY {0}]", this._FixDistance);
			this.LELKBCALFCF().SetFloat(": ", this.LightIntensity * 558f);
			this.LPPEPKGFOEM().SetFloat("SetParticlesParticleSize", (float)((!this._Visualize) ? 0 : 0));
			this.OKJOKHGJHGF().SetFloat("bad", this._FadeShield);
			this.DCCHGBHLAAF().SetFloat("SpawnObj", this.Speed);
			this.PGPEMMBJOOG().SetFloat("_Value", this.Speed_X);
			this.CECJJMKLEAK().SetFloat("_CenterX", this.Speed_Y);
			this.DEFBJOCJJKF().SetFloat("{0:0} day{1}, ", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HEINDEMCGIK().SetFloat("[ResourcesManager] Load text error: not found", 401f / farClipPlane);
			this.CECJJMKLEAK().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 435f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x0004F630 File Offset: 0x0004D830
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1599f)
			{
				this.HBJJOCHGOPH = 1084f;
			}
			this.DCCHGBHLAAF().SetFloat("[SERVER] Selected mode: ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 273f)
				{
					this._Distance = 1339f;
				}
				if (this._Distance < 945f)
				{
					this._Distance = 1105f;
				}
				this.IGKFMCPDNOI().SetFloat("true", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("[PlayerController] ", this._Distance);
			}
			this.MJJIEHANFJA().SetFloat("_MatrixColor", this._Size);
			this.GJHPODJOBHL().SetFloat("_SSAO", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat(" / ", this.LightIntensity * 726f);
			this.FEAEGGCNIAA().SetFloat("z", (float)((!this._Visualize) ? 1 : 1));
			this.OIIDAKBILMI().SetFloat("_VignettingDirt", this._FadeShield);
			this.FGENHBKMPDA().SetFloat("ItemsCountText", this.Speed);
			this.FKEOGPDLBDD().SetFloat("_Offsets", this.Speed_X);
			this.ACHNOHCLGOO().SetFloat("player.bat", this.Speed_Y);
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.CECJJMKLEAK().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", 1818f / farClipPlane);
			this.IIJMIPBMMBF().SetVector("Hidden/DepthOfField/MedianFilter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1933f, 346f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x0004F86C File Offset: 0x0004DA6C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 353f)
			{
				this.HBJJOCHGOPH = 1128f;
			}
			this.CECJJMKLEAK().SetFloat("StartButton", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1857f)
				{
					this._Distance = 195f;
				}
				if (this._Distance < 1153f)
				{
					this._Distance = 810f;
				}
				this.PGPEMMBJOOG().SetFloat("_Luminance", this._Distance);
			}
			else
			{
				this.NBMPPNFKFLB().SetFloat("menu.selectedplaymode", this._Distance);
			}
			this.IIJMIPBMMBF().SetFloat("_PositionX", this._Size);
			this.KOHGPKOFEJO().SetFloat("[Right]", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat("_Value3", this.LightIntensity * 1933f);
			this.KOHGPKOFEJO().SetFloat("SaveButton", (float)((!this._Visualize) ? 1 : 0));
			this.DEFBJOCJJKF().SetFloat("FinalScoreSmallText", this._FadeShield);
			this.IGKFMCPDNOI().SetFloat("Editor", this.Speed);
			this.MJJIEHANFJA().SetFloat("StartTime already set: ", this.Speed_X);
			this.IIBLJCKLGFG().SetFloat("_Value3", this.Speed_Y);
			this.MJJIEHANFJA().SetFloat("SetEnvSpriteImage", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DCCHGBHLAAF().SetFloat("_Value", 82f / farClipPlane);
			this.FKEOGPDLBDD().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 699f, 1494f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x0004FAA6 File Offset: 0x0004DCA6
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x0004BA04 File Offset: 0x00049C04
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x0004FACC File Offset: 0x0004DCCC
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1241f)
			{
				this.HBJJOCHGOPH = 1114f;
			}
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/Light_Rainbow", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1225f)
				{
					this._Distance = 1142f;
				}
				if (this._Distance < 1545f)
				{
					this._Distance = 15f;
				}
				this.DEFBJOCJJKF().SetFloat("_Value", this._Distance);
			}
			else
			{
				this.ACHNOHCLGOO().SetFloat("Up", this._Distance);
			}
			this.GJHPODJOBHL().SetFloat("_ScreenResolution", this._Size);
			this.HEINDEMCGIK().SetFloat("_Near", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("_UserLutTex", this.LightIntensity * 93f);
			this.PLBEJJIHFPB().SetFloat("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", (float)((!this._Visualize) ? 1 : 1));
			this.DCCHGBHLAAF().SetFloat("_Color_R", this._FadeShield);
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Speed);
			this.JFDGLLEOPGB().SetFloat("Tab2Content", this.Speed_X);
			this.CIAFLBFJLEJ().SetFloat("value", this.Speed_Y);
			this.DCCHGBHLAAF().SetFloat("Texture2", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("_Amount", 425f / farClipPlane);
			this.LPPEPKGFOEM().SetVector("_ColorR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 854f, 684f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x0004FD08 File Offset: 0x0004DF08
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 213f)
			{
				this.HBJJOCHGOPH = 1571f;
			}
			this.LELKBCALFCF().SetFloat("MaxLivesSlider", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1095f)
				{
					this._Distance = 1446f;
				}
				if (this._Distance < 17f)
				{
					this._Distance = 977f;
				}
				this.HJGEHJDMCGI().SetFloat("/", this._Distance);
			}
			else
			{
				this.FGENHBKMPDA().SetFloat("_Value1", this._Distance);
			}
			this.LPPEPKGFOEM().SetFloat("Editor/", this._Size);
			this.KOHGPKOFEJO().SetFloat("\n", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("closed", this.LightIntensity * 1931f);
			this.FKEOGPDLBDD().SetFloat("_FixDistance", (float)((!this._Visualize) ? 0 : 0));
			this.NBMPPNFKFLB().SetFloat("_BlurRadius4", this._FadeShield);
			this.PGPEMMBJOOG().SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", this.Speed);
			this.MJJIEHANFJA().SetFloat("#task", this.Speed_X);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.Speed_Y);
			this.GJHPODJOBHL().SetFloat("_Light2", this.Intensity);
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MJJIEHANFJA().SetFloat("_TimeX", 910f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("BloodAlternative3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 633f, 1029f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x0004FF42 File Offset: 0x0004E142
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_PColor2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x0004FF66 File Offset: 0x0004E166
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0400016E RID: 366
	public Shader SCShader;

	// Token: 0x0400016F RID: 367
	public bool _Visualize;

	// Token: 0x04000170 RID: 368
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000171 RID: 369
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000172 RID: 370
	private Material BJFKDHHMLJH;

	// Token: 0x04000173 RID: 371
	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	// Token: 0x04000174 RID: 372
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	// Token: 0x04000175 RID: 373
	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	// Token: 0x04000176 RID: 374
	[Range(0f, 1f)]
	public float _FadeShield = 0.75f;

	// Token: 0x04000177 RID: 375
	[Range(-0.2f, 0.2f)]
	public float LightIntensity = 0.025f;

	// Token: 0x04000178 RID: 376
	public bool AutoAnimatedNear;

	// Token: 0x04000179 RID: 377
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x0400017A RID: 378
	[Range(0f, 10f)]
	public float Speed = 0.2f;

	// Token: 0x0400017B RID: 379
	[Range(0f, 10f)]
	public float Speed_X = 0.2f;

	// Token: 0x0400017C RID: 380
	[Range(0f, 1f)]
	public float Speed_Y = 0.3f;

	// Token: 0x0400017D RID: 381
	[Range(0f, 10f)]
	public float Intensity = 2.4f;

	// Token: 0x0400017E RID: 382
	public static Color ChangeColorRGB;
}
