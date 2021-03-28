using System;
using UnityEngine;

// Token: 0x02000027 RID: 39
[AddComponentMenu("Camera Filter Pack/3D/Scan_Scene")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Scan_Scene : MonoBehaviour
{
	// Token: 0x0600097B RID: 2427 RVA: 0x00048204 File Offset: 0x00046404
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 709f)
			{
				this.HBJJOCHGOPH = 1776f;
			}
			this.OLHDPICFBOF().SetFloat("cancel", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("No Camera attached!", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 184f)
				{
					this._Distance = 1078f;
				}
				if (this._Distance < 1617f)
				{
					this._Distance = 43f;
				}
				this.BFGNMFCNDBC().SetFloat("Player Connected", this._Distance);
			}
			else
			{
				this.AELJLBOJAIL().SetFloat("BlockSize", this._Distance);
			}
			this.FLOHGDECHHH().SetFloat("No peer to communicate with. ", this._Size);
			this.DEFBJOCJJKF().SetColor("<command>", this.ScanColor);
			this.IFMAPIDFNLI().SetFloat("_Value", this._FixDistance);
			this.IGKFMCPDNOI().SetFloat("880078120", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BLMPMOIDGMG().SetFloat("GlassColor", 1925f / farClipPlane);
			this.BFGNMFCNDBC().SetVector("PointsScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 708f, 144f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x000483E0 File Offset: 0x000465E0
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x000483FD File Offset: 0x000465FD
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00048434 File Offset: 0x00046634
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("Jit ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00048458 File Offset: 0x00046658
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = 0f;
				}
				if (this._Distance < 0f)
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
			this.NBPKMLMCHFN.SetColor("_ColorRGB", this.ScanColor);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
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

	// Token: 0x06000982 RID: 2434 RVA: 0x00048634 File Offset: 0x00046834
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 286f)
			{
				this.HBJJOCHGOPH = 906f;
			}
			this.HEINDEMCGIK().SetFloat("_VelTex", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("Tab2Content", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1604f)
				{
					this._Distance = 785f;
				}
				if (this._Distance < 1695f)
				{
					this._Distance = 864f;
				}
				this.JFDGLLEOPGB().SetFloat(".lastCheckpoint.playerdistance", this._Distance);
			}
			else
			{
				this.OLHDPICFBOF().SetFloat("[Up]", this._Distance);
			}
			this.FGENHBKMPDA().SetFloat(".lastCheckpoint.playerdistance", this._Size);
			this.PGPEMMBJOOG().SetColor("Error: Can not set the OnSerialize rate higher than the overall SendRate.", this.ScanColor);
			this.KEMAALEODNH().SetFloat("Object ID. Case-Sensitive", this._FixDistance);
			this.IFMAPIDFNLI().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IGKFMCPDNOI().SetFloat("[PlayerBase] Loaded music", 1348f / farClipPlane);
			this.IIBLJCKLGFG().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 878f, 550f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x00048810 File Offset: 0x00046A10
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 779f)
			{
				this.HBJJOCHGOPH = 1693f;
			}
			this.GKILCDHJFEG().SetFloat("CameraFilterPack_Glasses_On6", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("/", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1183f)
				{
					this._Distance = 269f;
				}
				if (this._Distance < 1572f)
				{
					this._Distance = 986f;
				}
				this.HFBJAOFLCJI().SetFloat("[NetworkManager] Joined main lobby", this._Distance);
			}
			else
			{
				this.IIBLJCKLGFG().SetFloat("curScn", this._Distance);
			}
			this.OLHDPICFBOF().SetFloat("_ScreenResolution", this._Size);
			this.FGENHBKMPDA().SetColor("CheckCombo", this.ScanColor);
			this.IFMAPIDFNLI().SetFloat("_Value4", this._FixDistance);
			this.FGENHBKMPDA().SetFloat("skin.hit_normal", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OGMEGHKECAH().SetFloat("cameramovements:", 502f / farClipPlane);
			this.OLHDPICFBOF().SetVector("CameraFilterPack/Blend2Camera_Luminosity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 89f, 906f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x000489EC File Offset: 0x00046BEC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1209f)
			{
				this.HBJJOCHGOPH = 25f;
			}
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat(" or player:", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1794f)
				{
					this._Distance = 1801f;
				}
				if (this._Distance < 29f)
				{
					this._Distance = 1131f;
				}
				this.BFGNMFCNDBC().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("AudioSampler", this._Distance);
			}
			this.IFMAPIDFNLI().SetFloat("Vertical", this._Size);
			this.HFBJAOFLCJI().SetColor("Failed to Destroy objects of playerId: ", this.ScanColor);
			this.BLMPMOIDGMG().SetFloat(".png", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat(": ", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMAALEODNH().SetFloat("GLITCH", 1556f / farClipPlane);
			this.BFGNMFCNDBC().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 513f, 989f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00048BC8 File Offset: 0x00046DC8
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00048BFF File Offset: 0x00046DFF
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Lag ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00048C23 File Offset: 0x00046E23
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00048C47 File Offset: 0x00046E47
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("*.workshop.json");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00048C6C File Offset: 0x00046E6C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1096f)
			{
				this.HBJJOCHGOPH = 56f;
			}
			this.FGENHBKMPDA().SetFloat(" to ", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_Value7", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1951f)
				{
					this._Distance = 131f;
				}
				if (this._Distance < 955f)
				{
					this._Distance = 934f;
				}
				this.IIBLJCKLGFG().SetFloat("settings.arcsnohitsoundtimedelay", this._Distance);
			}
			else
			{
				this.PGPEMMBJOOG().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this._Distance);
			}
			this.HEINDEMCGIK().SetFloat("Item ", this._Size);
			this.IIBLJCKLGFG().SetColor("_Val", this.ScanColor);
			this.OGMEGHKECAH().SetFloat(" : ", this._FixDistance);
			this.DEFBJOCJJKF().SetFloat("_Value2", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DKKBFFHBHJE().SetFloat("#useticket", 245f / farClipPlane);
			this.BFGNMFCNDBC().SetVector("_Bloom0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 584f, 1389f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00048E48 File Offset: 0x00047048
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 75f)
			{
				this.HBJJOCHGOPH = 1988f;
			}
			this.FLOHGDECHHH().SetFloat("_TraceBehindObjects", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("menuthemes", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 962f)
				{
					this._Distance = 249f;
				}
				if (this._Distance < 804f)
				{
					this._Distance = 199f;
				}
				this.OLHDPICFBOF().SetFloat("PublishButton", this._Distance);
			}
			else
			{
				this.HEINDEMCGIK().SetFloat("No Description", this._Distance);
			}
			this.GKILCDHJFEG().SetFloat("_TimeX", this._Size);
			this.FGENHBKMPDA().SetColor("_SearchTex", this.ScanColor);
			this.IFMAPIDFNLI().SetFloat("PLEASE WAIT", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("_Value2", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FGENHBKMPDA().SetFloat("[PlayerBase] Unknown event: ", 1372f / farClipPlane);
			this.GCDFNHMJMIP().SetVector("EditMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1551f, 147f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00049024 File Offset: 0x00047224
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find(". Verify the Prefab is in a Resources folder (and not in a subfolder)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00049048 File Offset: 0x00047248
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("ScrollPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x0004906C File Offset: 0x0004726C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 509f)
			{
				this.HBJJOCHGOPH = 1383f;
			}
			this.IGKFMCPDNOI().SetFloat(": ", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("Type \"help\" for list of commands", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 800f)
				{
					this._Distance = 1230f;
				}
				if (this._Distance < 900f)
				{
					this._Distance = 1358f;
				}
				this.BFGNMFCNDBC().SetFloat("SetCrosshairColor", this._Distance);
			}
			else
			{
				this.BFGNMFCNDBC().SetFloat("maps.", this._Distance);
			}
			this.BLMPMOIDGMG().SetFloat("SupportLogger OnCreatedRoom(", this._Size);
			this.IGKFMCPDNOI().SetColor("L2", this.ScanColor);
			this.GCDFNHMJMIP().SetFloat("musicVolume", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GCDFNHMJMIP().SetFloat(".lastCheckpoint.isMapCompleted", 1307f / farClipPlane);
			this.GKILCDHJFEG().SetVector("RemoveEnvironmentObject", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 506f, 1026f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00049248 File Offset: 0x00047448
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x0004926C File Offset: 0x0004746C
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x000492A4 File Offset: 0x000474A4
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1874f)
			{
				this.HBJJOCHGOPH = 954f;
			}
			this.GCDFNHMJMIP().SetFloat("Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("1332644700", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1816f)
				{
					this._Distance = 161f;
				}
				if (this._Distance < 1843f)
				{
					this._Distance = 129f;
				}
				this.IFMAPIDFNLI().SetFloat(".played", this._Distance);
			}
			else
			{
				this.IGKFMCPDNOI().SetFloat("_Value7", this._Distance);
			}
			this.BLMPMOIDGMG().SetFloat("_TimeX", this._Size);
			this.GCDFNHMJMIP().SetColor("settings.disablestoryboard", this.ScanColor);
			this.DEFBJOCJJKF().SetFloat(".", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("Object ID. Case-Sensitive", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat(" not exist", 1512f / farClipPlane);
			this.BAGICADFBAB().SetVector("action", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 364f, 1203f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00049480 File Offset: 0x00047680
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x000494A4 File Offset: 0x000476A4
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1233f)
			{
				this.HBJJOCHGOPH = 1483f;
			}
			this.HFBJAOFLCJI().SetFloat("UseScanLineSize", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("MaxLivesSlider", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1229f)
				{
					this._Distance = 1926f;
				}
				if (this._Distance < 368f)
				{
					this._Distance = 341f;
				}
				this.DEFBJOCJJKF().SetFloat("_Blend", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("/", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("[SteamManager] Connecting to server", this._Size);
			this.IFMAPIDFNLI().SetColor("CameraFilterPack/Blur_Bloom", this.ScanColor);
			this.IIBLJCKLGFG().SetFloat("Missing shader in ", this._FixDistance);
			this.BFGNMFCNDBC().SetFloat("vignetteIntensity", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IFMAPIDFNLI().SetFloat("_History4ChromaTex", 1536f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 965f, 978f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00049680 File Offset: 0x00047880
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x000483E0 File Offset: 0x000465E0
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x000496B8 File Offset: 0x000478B8
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 598f)
			{
				this.HBJJOCHGOPH = 1794f;
			}
			this.KEMAALEODNH().SetFloat("\"", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("\nCreated by Oxy949", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1803f)
				{
					this._Distance = 29f;
				}
				if (this._Distance < 1306f)
				{
					this._Distance = 54f;
				}
				this.GCDFNHMJMIP().SetFloat("_MainTex2", this._Distance);
			}
			else
			{
				this.BLMPMOIDGMG().SetFloat("_MainTex2", this._Distance);
			}
			this.OLHDPICFBOF().SetFloat("_Value7", this._Size);
			this.AELJLBOJAIL().SetColor("_MainTex2", this.ScanColor);
			this.FGENHBKMPDA().SetFloat("menutheme.jamaicanorcdub", this._FixDistance);
			this.IIBLJCKLGFG().SetFloat("Set satellite color", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FGENHBKMPDA().SetFloat("settings.fps", 279f / farClipPlane);
			this.FGENHBKMPDA().SetVector("SetSatelliteTrailLength", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 468f, 1780f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x000483E0 File Offset: 0x000465E0
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00049894 File Offset: 0x00047A94
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Scan_Scene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x000498B8 File Offset: 0x00047AB8
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x000498EF File Offset: 0x00047AEF
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Greenness");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x000483E0 File Offset: 0x000465E0
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00049913 File Offset: 0x00047B13
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("\t");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00049938 File Offset: 0x00047B38
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1746f)
			{
				this.HBJJOCHGOPH = 1634f;
			}
			this.KEMAALEODNH().SetFloat("#mapalreadyexistupdate", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 267f)
				{
					this._Distance = 1683f;
				}
				if (this._Distance < 39f)
				{
					this._Distance = 1417f;
				}
				this.FLOHGDECHHH().SetFloat("_Value2", this._Distance);
			}
			else
			{
				this.GCDFNHMJMIP().SetFloat("Editor/", this._Distance);
			}
			this.AELJLBOJAIL().SetFloat("DPADVER", this._Size);
			this.BLMPMOIDGMG().SetColor("_Glitch", this.ScanColor);
			this.NBPKMLMCHFN.SetFloat("restrictions\n\n#until: ", this._FixDistance);
			this.DKKBFFHBHJE().SetFloat("mapselector.orderby", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BAGICADFBAB().SetFloat(". No ViewIDs are free to use. Max is: ", 1141f / farClipPlane);
			this.IIBLJCKLGFG().SetVector("Tab2Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1346f, 1345f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00049B14 File Offset: 0x00047D14
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00049B4B File Offset: 0x00047D4B
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("other.dust2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00049B70 File Offset: 0x00047D70
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 283f)
			{
				this.HBJJOCHGOPH = 909f;
			}
			this.BLMPMOIDGMG().SetFloat("PlayButton", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Extra2", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1042f)
				{
					this._Distance = 971f;
				}
				if (this._Distance < 621f)
				{
					this._Distance = 1651f;
				}
				this.BLMPMOIDGMG().SetFloat("CameraFilterPack/TV_Videoflip", this._Distance);
			}
			else
			{
				this.IFMAPIDFNLI().SetFloat("menu.tabid", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("_Value5", this._Size);
			this.DEFBJOCJJKF().SetColor("_Distortion", this.ScanColor);
			this.BLMPMOIDGMG().SetFloat("_TimeX", this._FixDistance);
			this.OLHDPICFBOF().SetFloat("_MainTex2", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DEFBJOCJJKF().SetFloat("Editor/", 752f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1161f, 1566f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00049D4C File Offset: 0x00047F4C
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00049D83 File Offset: 0x00047F83
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("sounds/hit_perfect");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00049DA8 File Offset: 0x00047FA8
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 374f)
			{
				this.HBJJOCHGOPH = 218f;
			}
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack/FX_Screens", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("#changenote", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 134f)
				{
					this._Distance = 836f;
				}
				if (this._Distance < 737f)
				{
					this._Distance = 246f;
				}
				this.PGPEMMBJOOG().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", this._Distance);
			}
			else
			{
				this.AELJLBOJAIL().SetFloat("<color=white>", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat(" ", this._Size);
			this.PGPEMMBJOOG().SetColor("88f00bdf0ad61b16b803971ebe071962", this.ScanColor);
			this.BAGICADFBAB().SetFloat("</b>", this._FixDistance);
			this.HEINDEMCGIK().SetFloat("ICollection", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HEINDEMCGIK().SetFloat("SetSunMaxSize", 338f / farClipPlane);
			this.HEINDEMCGIK().SetVector("Edited unlock conditions", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1378f, 140f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00049FF8 File Offset: 0x000481F8
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("No Name");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x0004A01C File Offset: 0x0004821C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 382f)
			{
				this.HBJJOCHGOPH = 1534f;
			}
			this.LPCHMEKDCHI().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("[", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 402f)
				{
					this._Distance = 1682f;
				}
				if (this._Distance < 783f)
				{
					this._Distance = 506f;
				}
				this.LPCHMEKDCHI().SetFloat("Set Sun Sensitivity", this._Distance);
			}
			else
			{
				this.LPCHMEKDCHI().SetFloat("ready", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Glasses_On5", this._Size);
			this.LPCHMEKDCHI().SetColor("LostLive", this.ScanColor);
			this.AELJLBOJAIL().SetFloat("distance", this._FixDistance);
			this.DKKBFFHBHJE().SetFloat("time", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IFMAPIDFNLI().SetFloat("_ScreenResolution", 1201f / farClipPlane);
			this.BAGICADFBAB().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1052f, 929f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x0004A1F8 File Offset: 0x000483F8
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x0004A22F File Offset: 0x0004842F
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x0004A266 File Offset: 0x00048466
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("_ToPrevViewProjCombined");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x0004A28A File Offset: 0x0004848A
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x0004A2AE File Offset: 0x000484AE
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("UpperMid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x000483E0 File Offset: 0x000465E0
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x0004A2D2 File Offset: 0x000484D2
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x0004A309 File Offset: 0x00048509
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("LivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x0004A32D File Offset: 0x0004852D
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0004A364 File Offset: 0x00048564
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1087f)
			{
				this.HBJJOCHGOPH = 212f;
			}
			this.JFDGLLEOPGB().SetFloat("Image", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("maps.", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 155f)
				{
					this._Distance = 1951f;
				}
				if (this._Distance < 1806f)
				{
					this._Distance = 1676f;
				}
				this.OLHDPICFBOF().SetFloat("FavoriteButton", this._Distance);
			}
			else
			{
				this.BFGNMFCNDBC().SetFloat("Items/", this._Distance);
			}
			this.BFGNMFCNDBC().SetFloat("player.bluelifering", this._Size);
			this.FLOHGDECHHH().SetColor(".status", this.ScanColor);
			this.HEINDEMCGIK().SetFloat("_NoiseTex", this._FixDistance);
			this.DKKBFFHBHJE().SetFloat("_Value", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.JFDGLLEOPGB().SetFloat("menu.enableselectormusic", 1619f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("Please attach component to a Graphical UI component", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1137f, 426f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x000483E0 File Offset: 0x000465E0
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x0004A540 File Offset: 0x00048740
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x0004A564 File Offset: 0x00048764
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1337f)
			{
				this.HBJJOCHGOPH = 1070f;
			}
			this.JFDGLLEOPGB().SetFloat("powerup.0", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_RampTex", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 843f)
				{
					this._Distance = 1249f;
				}
				if (this._Distance < 387f)
				{
					this._Distance = 1851f;
				}
				this.HEINDEMCGIK().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.AELJLBOJAIL().SetFloat("[PlayerController] ", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("STOP [R]", this._Size);
			this.IFMAPIDFNLI().SetColor("_Wavy", this.ScanColor);
			this.HEINDEMCGIK().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", this._FixDistance);
			this.OLHDPICFBOF().SetFloat(".lastCheckpoint.perfectHits", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OGMEGHKECAH().SetFloat("_Bullet_8", 1159f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("_LensDirt", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1566f, 1812f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x0004A740 File Offset: 0x00048940
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x000483E0 File Offset: 0x000465E0
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x0004A778 File Offset: 0x00048978
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1973f)
			{
				this.HBJJOCHGOPH = 243f;
			}
			this.LPCHMEKDCHI().SetFloat("Set crosshair color", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("_TimeX", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1919f)
				{
					this._Distance = 1176f;
				}
				if (this._Distance < 484f)
				{
					this._Distance = 121f;
				}
				this.IFMAPIDFNLI().SetFloat("data", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("SpawnObj", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("Set Particles Gravity", this._Size);
			this.FLOHGDECHHH().SetColor("_Glitch", this.ScanColor);
			this.AELJLBOJAIL().SetFloat("RoomPlayersCountText", this._FixDistance);
			this.AELJLBOJAIL().SetFloat("?", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BAGICADFBAB().SetFloat("_Blend", 1360f / farClipPlane);
			this.HEINDEMCGIK().SetVector("EventMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1213f, 98f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0004A954 File Offset: 0x00048B54
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0004A98B File Offset: 0x00048B8B
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x000483E0 File Offset: 0x000465E0
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x0004A9C2 File Offset: 0x00048BC2
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x0004A9E6 File Offset: 0x00048BE6
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("LevelNameInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0004AA0C File Offset: 0x00048C0C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1748f)
			{
				this.HBJJOCHGOPH = 1421f;
			}
			this.AELJLBOJAIL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_SearchTex", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1686f)
				{
					this._Distance = 1175f;
				}
				if (this._Distance < 1449f)
				{
					this._Distance = 1266f;
				}
				this.KEMAALEODNH().SetFloat("BestRegion checks region: ", this._Distance);
			}
			else
			{
				this.GCDFNHMJMIP().SetFloat("arc", this._Distance);
			}
			this.LPCHMEKDCHI().SetFloat("_Near", this._Size);
			this.BAGICADFBAB().SetColor("settings.enableranking", this.ScanColor);
			this.GKILCDHJFEG().SetFloat("13", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("shader.sunny", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GCDFNHMJMIP().SetFloat("_Value", 1185f / farClipPlane);
			this.BFGNMFCNDBC().SetVector("CameraFilterPack/Colors_Adjust_FullColors", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 729f, 1564f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x000483E0 File Offset: 0x000465E0
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x0004ABE8 File Offset: 0x00048DE8
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x0004AC20 File Offset: 0x00048E20
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1541f)
			{
				this.HBJJOCHGOPH = 171f;
			}
			this.LPCHMEKDCHI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("OnReadyClick", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1707f)
				{
					this._Distance = 1007f;
				}
				if (this._Distance < 678f)
				{
					this._Distance = 893f;
				}
				this.NBPKMLMCHFN.SetFloat("{0:x2}", this._Distance);
			}
			else
			{
				this.BFGNMFCNDBC().SetFloat("mapselector.lastSearch", this._Distance);
			}
			this.GCDFNHMJMIP().SetFloat("StartButton", this._Size);
			this.IGKFMCPDNOI().SetColor("SetSpeed", this.ScanColor);
			this.BAGICADFBAB().SetFloat("Warning: Unhandled event ", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Tab1Content", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.FLOHGDECHHH().SetFloat("_ScreenResolution", 1380f / farClipPlane);
			this.FLOHGDECHHH().SetVector("tagElement", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1430f, 1229f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x0004ADFC File Offset: 0x00048FFC
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0004AE33 File Offset: 0x00049033
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("No valid adaptive tonemapper type found!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0004AE58 File Offset: 0x00049058
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 753f)
			{
				this.HBJJOCHGOPH = 733f;
			}
			this.FLOHGDECHHH().SetFloat("Data", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("DPADHOR", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1447f)
				{
					this._Distance = 1231f;
				}
				if (this._Distance < 1839f)
				{
					this._Distance = 1429f;
				}
				this.LPCHMEKDCHI().SetFloat("ViewMenu", this._Distance);
			}
			else
			{
				this.DEFBJOCJJKF().SetFloat("_Smooth", this._Distance);
			}
			this.DEFBJOCJJKF().SetFloat("Line", this._Size);
			this.FGENHBKMPDA().SetColor("Object ID. Case-Sensitive", this.ScanColor);
			this.HFBJAOFLCJI().SetFloat("_Value", this._FixDistance);
			this.FLOHGDECHHH().SetFloat("_V", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IFMAPIDFNLI().SetFloat("GUICamera", 1306f / farClipPlane);
			this.IFMAPIDFNLI().SetVector("list", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 542f, 446f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x000483E0 File Offset: 0x000465E0
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x000483E0 File Offset: 0x000465E0
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0004B034 File Offset: 0x00049234
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1775f)
			{
				this.HBJJOCHGOPH = 791f;
			}
			this.IGKFMCPDNOI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("Tab1Content", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1052f)
				{
					this._Distance = 1069f;
				}
				if (this._Distance < 418f)
				{
					this._Distance = 818f;
				}
				this.IFMAPIDFNLI().SetFloat("896296812", this._Distance);
			}
			else
			{
				this.GKILCDHJFEG().SetFloat("\" that takes ", this._Distance);
			}
			this.BAGICADFBAB().SetFloat(".lastCheckpoint.comboScore", this._Size);
			this.JFDGLLEOPGB().SetColor("green", this.ScanColor);
			this.PGPEMMBJOOG().SetFloat("_RedAmplifier", this._FixDistance);
			this.HEINDEMCGIK().SetFloat("_Value3", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.BAGICADFBAB().SetFloat("\" to target: ", 1499f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 790f, 1468f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x0004B210 File Offset: 0x00049410
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x0004B248 File Offset: 0x00049448
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 142f)
			{
				this.HBJJOCHGOPH = 1873f;
			}
			this.DKKBFFHBHJE().SetFloat("Right", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("CurrentTimeLabel", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1395f)
				{
					this._Distance = 1577f;
				}
				if (this._Distance < 626f)
				{
					this._Distance = 1390f;
				}
				this.OLHDPICFBOF().SetFloat("float,2", this._Distance);
			}
			else
			{
				this.IIBLJCKLGFG().SetFloat("GlassAberration", this._Distance);
			}
			this.BLMPMOIDGMG().SetFloat("_ScreenResolution", this._Size);
			this.FLOHGDECHHH().SetColor("itemid", this.ScanColor);
			this.AELJLBOJAIL().SetFloat("Toggle {0} is not part of ToggleGroup {1}", this._FixDistance);
			this.OGMEGHKECAH().SetFloat("Hello World, is my item a clone? [", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OGMEGHKECAH().SetFloat("_GrainOffsetScale", 1932f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("green", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 798f, 1949f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x000483E0 File Offset: 0x000465E0
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x0004B424 File Offset: 0x00049624
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x0004B45B File Offset: 0x0004965B
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060009DB RID: 2523 RVA: 0x0004B47F File Offset: 0x0004967F
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

	// Token: 0x060009DC RID: 2524 RVA: 0x0004B4B6 File Offset: 0x000496B6
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x0004B4F0 File Offset: 0x000496F0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1694f)
			{
				this.HBJJOCHGOPH = 1267f;
			}
			this.PGPEMMBJOOG().SetFloat("Set Sun Emission", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("maps.", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 177f)
				{
					this._Distance = 335f;
				}
				if (this._Distance < 1719f)
				{
					this._Distance = 725f;
				}
				this.HEINDEMCGIK().SetFloat("maps.", this._Distance);
			}
			else
			{
				this.BAGICADFBAB().SetFloat("_Value2", this._Distance);
			}
			this.KEMAALEODNH().SetFloat("\n", this._Size);
			this.AELJLBOJAIL().SetColor("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", this.ScanColor);
			this.JFDGLLEOPGB().SetFloat("GameScene", this._FixDistance);
			this.GKILCDHJFEG().SetFloat("Set Crosshair Emission", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.DKKBFFHBHJE().SetFloat("SpawnObj", 1760f / farClipPlane);
			this.IGKFMCPDNOI().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1307f, 1797f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x0004B6CC File Offset: 0x000498CC
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_Bloom2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x0004B6F0 File Offset: 0x000498F0
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0004B727 File Offset: 0x00049927
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x0004B74C File Offset: 0x0004994C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 408f)
			{
				this.HBJJOCHGOPH = 833f;
			}
			this.LPCHMEKDCHI().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("76561198041679481", this.Fade);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 953f)
				{
					this._Distance = 1447f;
				}
				if (this._Distance < 1501f)
				{
					this._Distance = 1527f;
				}
				this.HFBJAOFLCJI().SetFloat("_MainTex2", this._Distance);
			}
			else
			{
				this.GKILCDHJFEG().SetFloat("_Value2", this._Distance);
			}
			this.IGKFMCPDNOI().SetFloat("_Value4", this._Size);
			this.AELJLBOJAIL().SetColor("_Value", this.ScanColor);
			this.HFBJAOFLCJI().SetFloat("_Screen", this._FixDistance);
			this.IGKFMCPDNOI().SetFloat("Scrollbar", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.OGMEGHKECAH().SetFloat("winter2020_official", 1658f / farClipPlane);
			this.BFGNMFCNDBC().SetVector("_VignettingColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 819f, 1867f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x000483E0 File Offset: 0x000465E0
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x000483E0 File Offset: 0x000465E0
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x000483E0 File Offset: 0x000465E0
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x000483E0 File Offset: 0x000465E0
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x000483E0 File Offset: 0x000465E0
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x0004B928 File Offset: 0x00049B28
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000160 RID: 352
	public Shader SCShader;

	// Token: 0x04000161 RID: 353
	public bool _Visualize;

	// Token: 0x04000162 RID: 354
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000163 RID: 355
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000164 RID: 356
	private Material BJFKDHHMLJH;

	// Token: 0x04000165 RID: 357
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x04000166 RID: 358
	[Range(0f, 0.99f)]
	public float _Distance = 1f;

	// Token: 0x04000167 RID: 359
	[Range(0f, 0.1f)]
	public float _Size = 0.01f;

	// Token: 0x04000168 RID: 360
	public bool AutoAnimatedNear;

	// Token: 0x04000169 RID: 361
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 1f;

	// Token: 0x0400016A RID: 362
	public Color ScanColor = new Color(2f, 0f, 0f, 1f);

	// Token: 0x0400016B RID: 363
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400016C RID: 364
	public static Color ChangeColorRGB;

	// Token: 0x0400016D RID: 365
	private Texture2D FPHEBLMINDA;
}
