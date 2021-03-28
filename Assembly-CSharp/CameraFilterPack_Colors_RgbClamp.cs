using System;
using UnityEngine;

// Token: 0x02000081 RID: 129
[AddComponentMenu("Camera Filter Pack/Colors/RgbClamp")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_RgbClamp : MonoBehaviour
{
	// Token: 0x0600245E RID: 9310 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x0600245F RID: 9311 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06002460 RID: 9312 RVA: 0x000D1519 File Offset: 0x000CF719
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002461 RID: 9313 RVA: 0x000D1536 File Offset: 0x000CF736
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002462 RID: 9314 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06002463 RID: 9315 RVA: 0x000D156D File Offset: 0x000CF76D
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("TRACKING");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002464 RID: 9316 RVA: 0x000D1591 File Offset: 0x000CF791
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002465 RID: 9317 RVA: 0x000D15C8 File Offset: 0x000CF7C8
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002466 RID: 9318 RVA: 0x000D1519 File Offset: 0x000CF719
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002467 RID: 9319 RVA: 0x000D15EC File Offset: 0x000CF7EC
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002468 RID: 9320 RVA: 0x000D1519 File Offset: 0x000CF719
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002469 RID: 9321 RVA: 0x000D1519 File Offset: 0x000CF719
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600246A RID: 9322 RVA: 0x000D1623 File Offset: 0x000CF823
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600246B RID: 9323 RVA: 0x000D165A File Offset: 0x000CF85A
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("ItemsCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600246C RID: 9324 RVA: 0x000D1680 File Offset: 0x000CF880
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1377f)
			{
				this.HBJJOCHGOPH = 1112f;
			}
			this.OCHJIMJNEMO().SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("turn", this.Red_Start);
			this.DONENAMLFLF().SetFloat("CompletedLevel", this.Red_End);
			this.MJJIEHANFJA().SetFloat("[ResourcesManager] Unloading data resources", this.Green_Start);
			this.MICHFGAOPKM().SetFloat("#news", this.Green_End);
			this.CBCNOEIALHB().SetFloat("Anomaly_Near", this.Blue_Start);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Blue_End);
			this.MICHFGAOPKM().SetFloat("cameramovements:", this.RGB_Start);
			this.KEMJNOMIPHN().SetFloat("[DiscordController] Init", this.RGB_End);
			this.MHBAIEKFBIJ().SetVector("Event Received", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1333f, 1844f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600246D RID: 9325 RVA: 0x000D1519 File Offset: 0x000CF719
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600246E RID: 9326 RVA: 0x000D1519 File Offset: 0x000CF719
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600246F RID: 9327 RVA: 0x000D17D7 File Offset: 0x000CF9D7
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002470 RID: 9328 RVA: 0x000D1519 File Offset: 0x000CF719
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002472 RID: 9330 RVA: 0x000D1850 File Offset: 0x000CFA50
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 783f)
			{
				this.HBJJOCHGOPH = 1492f;
			}
			this.OLHDPICFBOF().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("MapCreationCanvas", this.Red_Start);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Red_End);
			this.HNICHJCGJOC().SetFloat("masterSteamID", this.Green_Start);
			this.ENKPNJMPDEB().SetFloat("_GlowColor", this.Green_End);
			this.MHBAIEKFBIJ().SetFloat(" ", this.Blue_Start);
			this.HFBJAOFLCJI().SetFloat("The binding '", this.Blue_End);
			this.CFEDGDGBCHE().SetFloat("Object ID. Case-Sensitive", this.RGB_Start);
			this.LNLKMDPHDCC().SetFloat("_Value2", this.RGB_End);
			this.NBPKMLMCHFN.SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1636f, 1795f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002473 RID: 9331 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06002474 RID: 9332 RVA: 0x000D19A7 File Offset: 0x000CFBA7
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002475 RID: 9333 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06002476 RID: 9334 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06002477 RID: 9335 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06002478 RID: 9336 RVA: 0x000D1519 File Offset: 0x000CF719
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002479 RID: 9337 RVA: 0x000D1519 File Offset: 0x000CF719
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600247A RID: 9338 RVA: 0x000D19CB File Offset: 0x000CFBCB
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600247B RID: 9339 RVA: 0x000D1A04 File Offset: 0x000CFC04
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 835f)
			{
				this.HBJJOCHGOPH = 1922f;
			}
			this.KOHGPKOFEJO().SetFloat("_Blue_G", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_AdaptationMin", this.Red_Start);
			this.LPMLLJKMAMP().SetFloat("\n", this.Red_End);
			this.LNLKMDPHDCC().SetFloat(".", this.Green_Start);
			this.OLHDPICFBOF().SetFloat("BadgeText", this.Green_End);
			this.GJHPODJOBHL().SetFloat("_LoopCount", this.Blue_Start);
			this.AELJLBOJAIL().SetFloat("_FgOverlap", this.Blue_End);
			this.CFEDGDGBCHE().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", this.RGB_Start);
			this.NBPKMLMCHFN.SetFloat("LivesSlider", this.RGB_End);
			this.KHCLIAMBBNC().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1732f, 1775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600247C RID: 9340 RVA: 0x000D1B5B File Offset: 0x000CFD5B
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600247D RID: 9341 RVA: 0x000D1519 File Offset: 0x000CF719
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600247E RID: 9342 RVA: 0x000D1519 File Offset: 0x000CF719
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600247F RID: 9343 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06002480 RID: 9344 RVA: 0x000D1B7F File Offset: 0x000CFD7F
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("BlockSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002481 RID: 9345 RVA: 0x000D1BA3 File Offset: 0x000CFDA3
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002482 RID: 9346 RVA: 0x000D1BDA File Offset: 0x000CFDDA
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_RgbClamp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002483 RID: 9347 RVA: 0x000D1C00 File Offset: 0x000CFE00
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 666f)
			{
				this.HBJJOCHGOPH = 1313f;
			}
			this.HFBJAOFLCJI().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("float,40", this.Red_Start);
			this.OJMHIMIPKME().SetFloat(" elements", this.Red_End);
			this.HFBJAOFLCJI().SetFloat("Intensity", this.Green_Start);
			this.KOHGPKOFEJO().SetFloat("_ScreenResolution", this.Green_End);
			this.DNLMFEGJJDD().SetFloat("SlidingArea", this.Blue_Start);
			this.ENKPNJMPDEB().SetFloat("Editor", this.Blue_End);
			this.LNLKMDPHDCC().SetFloat("/icon", this.RGB_Start);
			this.CFEDGDGBCHE().SetFloat("_MinVelocity", this.RGB_End);
			this.DNLMFEGJJDD().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 979f, 847f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002484 RID: 9348 RVA: 0x000D1D57 File Offset: 0x000CFF57
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002485 RID: 9349 RVA: 0x000D1D90 File Offset: 0x000CFF90
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 605f)
			{
				this.HBJJOCHGOPH = 1756f;
			}
			this.NLFJGMBCICG().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack_RainFX_Anm2", this.Red_Start);
			this.CFEDGDGBCHE().SetFloat("music", this.Red_End);
			this.NBPKMLMCHFN.SetFloat("grid", this.Green_Start);
			this.MMOODGIODPC().SetFloat(".ogg", this.Green_End);
			this.MJJIEHANFJA().SetFloat("Tab1Content", this.Blue_Start);
			this.GJHPODJOBHL().SetFloat("key", this.Blue_End);
			this.CECICEGFHKL().SetFloat("_Distortion", this.RGB_Start);
			this.NLFJGMBCICG().SetFloat(".b", this.RGB_End);
			this.KEMJNOMIPHN().SetVector("CameraFilterPack/Vision_Rainbow", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 321f, 1300f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002486 RID: 9350 RVA: 0x000D1EE8 File Offset: 0x000D00E8
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1225f)
			{
				this.HBJJOCHGOPH = 1764f;
			}
			this.OJMHIMIPKME().SetFloat("_BlurPass", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("AddEnvironmentObject", this.Red_Start);
			this.DNLMFEGJJDD().SetFloat("_Value3", this.Red_End);
			this.NBPKMLMCHFN.SetFloat("player.xp", this.Green_Start);
			this.GJHPODJOBHL().SetFloat("The shader ", this.Green_End);
			this.MHBAIEKFBIJ().SetFloat("_Distortion", this.Blue_Start);
			this.KEMJNOMIPHN().SetFloat("mine", this.Blue_End);
			this.MJJIEHANFJA().SetFloat("_ScreenResolution", this.RGB_Start);
			this.MICHFGAOPKM().SetFloat("_BlurVector", this.RGB_End);
			this.KOHGPKOFEJO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 292f, 1252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x000D203F File Offset: 0x000D023F
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002488 RID: 9352 RVA: 0x000D1519 File Offset: 0x000CF719
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002489 RID: 9353 RVA: 0x000D2078 File Offset: 0x000D0278
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 418f)
			{
				this.HBJJOCHGOPH = 1317f;
			}
			this.NLFJGMBCICG().SetFloat("_SceneFogMode", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("1087340967", this.Red_Start);
			this.OJMHIMIPKME().SetFloat("_Value4", this.Red_End);
			this.GJHPODJOBHL().SetFloat("Texture2", this.Green_Start);
			this.OJMHIMIPKME().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", this.Green_End);
			this.DNLMFEGJJDD().SetFloat("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", this.Blue_Start);
			this.OLHDPICFBOF().SetFloat("_PositionX", this.Blue_End);
			this.GJHPODJOBHL().SetFloat("_Distortion", this.RGB_Start);
			this.MICHFGAOPKM().SetFloat("s", this.RGB_End);
			this.CFEDGDGBCHE().SetVector("_DistAmount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1915f, 601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x000D21D0 File Offset: 0x000D03D0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1784f)
			{
				this.HBJJOCHGOPH = 1863f;
			}
			this.OJMHIMIPKME().SetFloat("No child content found, exiting..", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("GameScene", this.Red_Start);
			this.HFBJAOFLCJI().SetFloat("_Intensity", this.Red_End);
			this.LNLKMDPHDCC().SetFloat("Value", this.Green_Start);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.Green_End);
			this.DNLMFEGJJDD().SetFloat("Create failed on GameServer. Changing back to MasterServer. Msg: ", this.Blue_Start);
			this.HNICHJCGJOC().SetFloat("RedoButton", this.Blue_End);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.RGB_Start);
			this.CECICEGFHKL().SetFloat("settings.hitvariation", this.RGB_End);
			this.AELJLBOJAIL().SetVector("Can't set open when not in that room.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1568f, 1535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x000D2327 File Offset: 0x000D0527
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("SupportLogger OnJoinedRoom(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x000D234B File Offset: 0x000D054B
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600248D RID: 9357 RVA: 0x000D2384 File Offset: 0x000D0584
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 639f)
			{
				this.HBJJOCHGOPH = 934f;
			}
			this.CFEDGDGBCHE().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("JoinTeam was called in state: ", this.Red_Start);
			this.HFBJAOFLCJI().SetFloat("value", this.Red_End);
			this.MMOODGIODPC().SetFloat("[Down]", this.Green_Start);
			this.KEMJNOMIPHN().SetFloat("_DiffuseColor", this.Green_End);
			this.ENKPNJMPDEB().SetFloat("HightScoreMaxPointsText", this.Blue_Start);
			this.OOMFJGPAOKL().SetFloat("Object ID. Case-Sensitive", this.Blue_End);
			this.MJJIEHANFJA().SetFloat("#EA4137", this.RGB_Start);
			this.LNLKMDPHDCC().SetFloat("_Amount", this.RGB_End);
			this.DONENAMLFLF().SetVector("MultiplayerButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 528f, 1765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x000D24DB File Offset: 0x000D06DB
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600248F RID: 9359 RVA: 0x000D2512 File Offset: 0x000D0712
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

	// Token: 0x06002490 RID: 9360 RVA: 0x000D254C File Offset: 0x000D074C
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1944f)
			{
				this.HBJJOCHGOPH = 1590f;
			}
			this.MMOODGIODPC().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("D-Pad Up", this.Red_Start);
			this.HFBJAOFLCJI().SetFloat("ViewMenu", this.Red_End);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.Green_Start);
			this.FLOHGDECHHH().SetFloat("_Value3", this.Green_End);
			this.FLOHGDECHHH().SetFloat("_ScreenResolution", this.Blue_Start);
			this.KHCLIAMBBNC().SetFloat("\"", this.Blue_End);
			this.DONENAMLFLF().SetFloat("NO", this.RGB_Start);
			this.LNLKMDPHDCC().SetFloat("_ColorKey", this.RGB_End);
			this.OLHDPICFBOF().SetVector("[PlayerBase] Reset", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 625f, 422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x000D1519 File Offset: 0x000CF719
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x000D26A3 File Offset: 0x000D08A3
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x000D1519 File Offset: 0x000CF719
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06002495 RID: 9365 RVA: 0x000D26DA File Offset: 0x000D08DA
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x000D2711 File Offset: 0x000D0911
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x000D2735 File Offset: 0x000D0935
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x000D24DB File Offset: 0x000D06DB
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x000D276C File Offset: 0x000D096C
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x000D27A3 File Offset: 0x000D09A3
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Radial_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x000D1519 File Offset: 0x000CF719
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x000D27C7 File Offset: 0x000D09C7
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600249E RID: 9374 RVA: 0x000D1519 File Offset: 0x000CF719
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600249F RID: 9375 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x060024A0 RID: 9376 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060024A1 RID: 9377 RVA: 0x000D27FE File Offset: 0x000D09FE
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x000D1519 File Offset: 0x000CF719
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024A3 RID: 9379 RVA: 0x000D2838 File Offset: 0x000D0A38
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1729f)
			{
				this.HBJJOCHGOPH = 1724f;
			}
			this.OJMHIMIPKME().SetFloat("/../", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("maps.", this.Red_Start);
			this.HFBJAOFLCJI().SetFloat("1 Kb", this.Red_End);
			this.KHCLIAMBBNC().SetFloat("_TimeX", this.Green_Start);
			this.CECICEGFHKL().SetFloat("_color", this.Green_End);
			this.OJMHIMIPKME().SetFloat("_Value9", this.Blue_Start);
			this.KEMJNOMIPHN().SetFloat("_Value4", this.Blue_End);
			this.CECICEGFHKL().SetFloat("_VignettingDirt", this.RGB_Start);
			this.MJJIEHANFJA().SetFloat(" [", this.RGB_End);
			this.CECICEGFHKL().SetVector(".progress", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 221f, 826f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024A4 RID: 9380 RVA: 0x000D298F File Offset: 0x000D0B8F
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x000D29B4 File Offset: 0x000D0BB4
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1352f)
			{
				this.HBJJOCHGOPH = 444f;
			}
			this.MMOODGIODPC().SetFloat("Set sun audio input", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("settings.enablehitsoundsinrelax", this.Red_Start);
			this.NLFJGMBCICG().SetFloat(" argument(s): ", this.Red_End);
			this.LNLKMDPHDCC().SetFloat("_ScreenResolution", this.Green_Start);
			this.CFEDGDGBCHE().SetFloat("_TimeX", this.Green_End);
			this.OJMHIMIPKME().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", this.Blue_Start);
			this.GJHPODJOBHL().SetFloat("Error: I/O Failure! :(", this.Blue_End);
			this.LPMLLJKMAMP().SetFloat(" registered.", this.RGB_Start);
			this.NLFJGMBCICG().SetFloat("[PlayerController] ", this.RGB_End);
			this.NBPKMLMCHFN.SetVector("&search=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1335f, 565f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x000D2B0B File Offset: 0x000D0D0B
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("[ReplayScene] Loading replay: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x000D2B2F File Offset: 0x000D0D2F
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x000D1519 File Offset: 0x000CF719
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x000D2B53 File Offset: 0x000D0D53
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x000D2B77 File Offset: 0x000D0D77
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("_Value11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024AC RID: 9388 RVA: 0x000D2B9B File Offset: 0x000D0D9B
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024AD RID: 9389 RVA: 0x000D2BBF File Offset: 0x000D0DBF
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x000D2BF8 File Offset: 0x000D0DF8
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1983f)
			{
				this.HBJJOCHGOPH = 1392f;
			}
			this.OJMHIMIPKME().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_Fade", this.Red_Start);
			this.KEMJNOMIPHN().SetFloat("Gameplay/sprite", this.Red_End);
			this.OOMFJGPAOKL().SetFloat("_Value3", this.Green_Start);
			this.MJJIEHANFJA().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", this.Green_End);
			this.LNLKMDPHDCC().SetFloat("_Value", this.Blue_Start);
			this.LPMLLJKMAMP().SetFloat("SAVE FILE", this.Blue_End);
			this.DNLMFEGJJDD().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.RGB_Start);
			this.ENKPNJMPDEB().SetFloat("(\\[ */ *quote *\\])", this.RGB_End);
			this.LPMLLJKMAMP().SetVector("ArcsNoHitsoundTimeDelaySlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1277f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x000D2D4F File Offset: 0x000D0F4F
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x000D1519 File Offset: 0x000CF719
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024B2 RID: 9394 RVA: 0x000D2D88 File Offset: 0x000D0F88
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 329f)
			{
				this.HBJJOCHGOPH = 1163f;
			}
			this.CBCNOEIALHB().SetFloat("Connection error: ", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_Value3", this.Red_Start);
			this.MJJIEHANFJA().SetFloat("#score", this.Red_End);
			this.OLHDPICFBOF().SetFloat("]", this.Green_Start);
			this.HNICHJCGJOC().SetFloat("<start_index> <end_index>", this.Green_End);
			this.CBCNOEIALHB().SetFloat("Set satellite clockwise rotattion speed", this.Blue_Start);
			this.OLHDPICFBOF().SetFloat("LoadMapCanvas", this.Blue_End);
			this.ENKPNJMPDEB().SetFloat("x", this.RGB_Start);
			this.GJHPODJOBHL().SetFloat("ERROR: preview file name is empty in modName.workshop.json", this.RGB_End);
			this.AELJLBOJAIL().SetVector("The given 2D texture ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1926f, 230f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x000D2EE0 File Offset: 0x000D10E0
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 713f)
			{
				this.HBJJOCHGOPH = 1984f;
			}
			this.OCHJIMJNEMO().SetFloat("ShowSprite", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("settings.gamemessagesduration", this.Red_Start);
			this.MICHFGAOPKM().SetFloat("SaveGameName is null or empty!", this.Red_End);
			this.HNICHJCGJOC().SetFloat("/", this.Green_Start);
			this.GJHPODJOBHL().SetFloat("UsernameText", this.Green_End);
			this.DNLMFEGJJDD().SetFloat("[MenuScene] Error: ", this.Blue_Start);
			this.HNICHJCGJOC().SetFloat("LevelEditor/patterns", this.Blue_End);
			this.OOMFJGPAOKL().SetFloat("Start index must in an integer.", this.RGB_Start);
			this.NBPKMLMCHFN.SetFloat("received</b>\n#reason: ", this.RGB_End);
			this.CECICEGFHKL().SetVector("DPADVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1047f, 742f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024B4 RID: 9396 RVA: 0x000D3038 File Offset: 0x000D1238
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Red_Start);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Red_End);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Green_Start);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Green_End);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Blue_Start);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Blue_End);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.RGB_Start);
			this.NBPKMLMCHFN.SetFloat("_Value8", this.RGB_End);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x000D1519 File Offset: 0x000CF719
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x000D318F File Offset: 0x000D138F
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024B7 RID: 9399 RVA: 0x000D1519 File Offset: 0x000CF719
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x000D1519 File Offset: 0x000CF719
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x000D31B4 File Offset: 0x000D13B4
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1077f)
			{
				this.HBJJOCHGOPH = 443f;
			}
			this.KOHGPKOFEJO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("[SERVER] Selected map: ", this.Red_Start);
			this.MICHFGAOPKM().SetFloat("_Value2", this.Red_End);
			this.OLHDPICFBOF().SetFloat("PLAY [SPACE]", this.Green_Start);
			this.CFEDGDGBCHE().SetFloat("_TapMedium", this.Green_End);
			this.NLFJGMBCICG().SetFloat("workshop.", this.Blue_Start);
			this.LPMLLJKMAMP().SetFloat("Connection error: ", this.Blue_End);
			this.CFEDGDGBCHE().SetFloat(",", this.RGB_Start);
			this.NBPKMLMCHFN.SetFloat("yyyy", this.RGB_End);
			this.OJMHIMIPKME().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1442f, 347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x000D330B File Offset: 0x000D150B
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_CenterX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024BC RID: 9404 RVA: 0x000D3330 File Offset: 0x000D1530
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 1756f;
			}
			this.MJJIEHANFJA().SetFloat("Set Trail Zoom Speed", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_VividLight", this.Red_Start);
			this.MMOODGIODPC().SetFloat("_FixDistance", this.Red_End);
			this.ENKPNJMPDEB().SetFloat("_SSAO", this.Green_Start);
			this.MICHFGAOPKM().SetFloat("Gameplay/sun", this.Green_End);
			this.LNLKMDPHDCC().SetFloat("clear", this.Blue_Start);
			this.NLFJGMBCICG().SetFloat("_ScreenResolution", this.Blue_End);
			this.OLHDPICFBOF().SetFloat("bool", this.RGB_Start);
			this.OJMHIMIPKME().SetFloat("{0} days ago", this.RGB_End);
			this.DONENAMLFLF().SetVector("_ColorR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 588f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x000D1519 File Offset: 0x000CF719
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x000D1519 File Offset: 0x000CF719
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x060024C1 RID: 9409 RVA: 0x000D1519 File Offset: 0x000CF719
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024C2 RID: 9410 RVA: 0x000D1519 File Offset: 0x000CF719
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024C3 RID: 9411 RVA: 0x000D1519 File Offset: 0x000CF719
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x000D3488 File Offset: 0x000D1688
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1524f)
			{
				this.HBJJOCHGOPH = 24f;
			}
			this.MHBAIEKFBIJ().SetFloat("GlassColor", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_Mirror", this.Red_Start);
			this.DONENAMLFLF().SetFloat("Cause: ", this.Red_End);
			this.FLOHGDECHHH().SetFloat("There are {0} reported logs.", this.Green_Start);
			this.FLOHGDECHHH().SetFloat("_Value8", this.Green_End);
			this.OOMFJGPAOKL().SetFloat("Joystick1Button4", this.Blue_Start);
			this.OOMFJGPAOKL().SetFloat("CameraFilterPack/3D_Myst", this.Blue_End);
			this.MMOODGIODPC().SetFloat("vignetteIntensity", this.RGB_Start);
			this.KHCLIAMBBNC().SetFloat("_Colorisation", this.RGB_End);
			this.FLOHGDECHHH().SetVector("getstring", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 878f, 1326f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x000D1519 File Offset: 0x000CF719
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x000D35DF File Offset: 0x000D17DF
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x000D3603 File Offset: 0x000D1803
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Aura");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x000D3628 File Offset: 0x000D1828
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 599f)
			{
				this.HBJJOCHGOPH = 917f;
			}
			this.HFBJAOFLCJI().SetFloat("Set satellite trail length in seconds", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("ready", this.Red_Start);
			this.CECICEGFHKL().SetFloat("score", this.Red_End);
			this.AELJLBOJAIL().SetFloat(".sawoutdatedmessage", this.Green_Start);
			this.MHBAIEKFBIJ().SetFloat("R:", this.Green_End);
			this.OJMHIMIPKME().SetFloat("_TimeX", this.Blue_Start);
			this.HNICHJCGJOC().SetFloat("LoadingStatusText", this.Blue_End);
			this.FLOHGDECHHH().SetFloat("_Value4", this.RGB_Start);
			this.CECICEGFHKL().SetFloat("st", this.RGB_End);
			this.GJHPODJOBHL().SetVector("_DistortionSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1156f, 705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x000D377F File Offset: 0x000D197F
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("Crosshair");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x000D37A3 File Offset: 0x000D19A3
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x000D1519 File Offset: 0x000CF719
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x000D37DA File Offset: 0x000D19DA
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("_Value13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x000D2B53 File Offset: 0x000D0D53
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x000D37FE File Offset: 0x000D19FE
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Spot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024D2 RID: 9426 RVA: 0x000D3822 File Offset: 0x000D1A22
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("NEW_ACHIEVEMENT_1_21");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x000D3846 File Offset: 0x000D1A46
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024D4 RID: 9428 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060024D5 RID: 9429 RVA: 0x000D3880 File Offset: 0x000D1A80
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 578f)
			{
				this.HBJJOCHGOPH = 313f;
			}
			this.NLFJGMBCICG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("ViewMenu", this.Red_Start);
			this.OLHDPICFBOF().SetFloat(",", this.Red_End);
			this.KOHGPKOFEJO().SetFloat("mapselector.orderby", this.Green_Start);
			this.OCHJIMJNEMO().SetFloat(".a", this.Green_End);
			this.AELJLBOJAIL().SetFloat("SetSatelliteSensitivity", this.Blue_Start);
			this.NLFJGMBCICG().SetFloat("_MainTex2", this.Blue_End);
			this.HNICHJCGJOC().SetFloat("LT", this.RGB_Start);
			this.LNLKMDPHDCC().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", this.RGB_End);
			this.LPMLLJKMAMP().SetVector("[Right]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 699f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024D6 RID: 9430 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x060024D7 RID: 9431 RVA: 0x000D39D7 File Offset: 0x000D1BD7
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024D8 RID: 9432 RVA: 0x000D3A0E File Offset: 0x000D1C0E
	private void MODENHKMKOC()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024D9 RID: 9433 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x000D15EC File Offset: 0x000CF7EC
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024DB RID: 9435 RVA: 0x000D3A32 File Offset: 0x000D1C32
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x000D3A69 File Offset: 0x000D1C69
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find(" = ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x000D3A8D File Offset: 0x000D1C8D
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("_InvRenderTargetSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x000D1519 File Offset: 0x000CF719
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024E0 RID: 9440 RVA: 0x000D3AB4 File Offset: 0x000D1CB4
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1967f)
			{
				this.HBJJOCHGOPH = 1718f;
			}
			this.MICHFGAOPKM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ENKPNJMPDEB().SetFloat("RestartButton", this.Red_Start);
			this.NBPKMLMCHFN.SetFloat("x", this.Red_End);
			this.OLHDPICFBOF().SetFloat("&page=", this.Green_Start);
			this.DONENAMLFLF().SetFloat("MissesText", this.Green_End);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/FX_DigitalMatrix", this.Blue_Start);
			this.CFEDGDGBCHE().SetFloat("cipherText", this.Blue_End);
			this.KOHGPKOFEJO().SetFloat("_FinalReflectionTexture", this.RGB_Start);
			this.ENKPNJMPDEB().SetFloat("_UserLutTex", this.RGB_End);
			this.LPMLLJKMAMP().SetVector("Default UI Material", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1117f, 1321f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x000D1519 File Offset: 0x000CF719
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024E2 RID: 9442 RVA: 0x000D3C0C File Offset: 0x000D1E0C
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1189f)
			{
				this.HBJJOCHGOPH = 343f;
			}
			this.AELJLBOJAIL().SetFloat(".lastCheckpoint.powerupsScore", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("_MainTex2", this.Red_Start);
			this.KOHGPKOFEJO().SetFloat("GlassesColor2", this.Red_End);
			this.DNLMFEGJJDD().SetFloat("ticket", this.Green_Start);
			this.MHBAIEKFBIJ().SetFloat("_ScreenResolution", this.Green_End);
			this.DONENAMLFLF().SetFloat("Joystick1Button11", this.Blue_Start);
			this.MICHFGAOPKM().SetFloat("/", this.Blue_End);
			this.ENKPNJMPDEB().SetFloat("_EmissionColor", this.RGB_Start);
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.RGB_End);
			this.OCHJIMJNEMO().SetVector("CameraFilterPack/Blur_Radial", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 216f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x000D3D64 File Offset: 0x000D1F64
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 292f)
			{
				this.HBJJOCHGOPH = 1512f;
			}
			this.HNICHJCGJOC().SetFloat("\\", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_ColorBuffer", this.Red_Start);
			this.CBCNOEIALHB().SetFloat("settings.gamemessagesduration", this.Red_End);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", this.Green_Start);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Distortion_Dream2", this.Green_End);
			this.OCHJIMJNEMO().SetFloat("[PlayerController] ", this.Blue_Start);
			this.NLFJGMBCICG().SetFloat("_Value4", this.Blue_End);
			this.OOMFJGPAOKL().SetFloat("Save Path: ", this.RGB_Start);
			this.MJJIEHANFJA().SetFloat(" not exist", this.RGB_End);
			this.KHCLIAMBBNC().SetVector("z", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1222f, 1928f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x040004B1 RID: 1201
	public Shader SCShader;

	// Token: 0x040004B2 RID: 1202
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004B3 RID: 1203
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004B4 RID: 1204
	private Material BJFKDHHMLJH;

	// Token: 0x040004B5 RID: 1205
	[Range(0f, 1f)]
	public float Red_Start;

	// Token: 0x040004B6 RID: 1206
	[Range(0f, 1f)]
	public float Red_End = 1f;

	// Token: 0x040004B7 RID: 1207
	[Range(0f, 1f)]
	public float Green_Start;

	// Token: 0x040004B8 RID: 1208
	[Range(0f, 1f)]
	public float Green_End = 1f;

	// Token: 0x040004B9 RID: 1209
	[Range(0f, 1f)]
	public float Blue_Start;

	// Token: 0x040004BA RID: 1210
	[Range(0f, 1f)]
	public float Blue_End = 1f;

	// Token: 0x040004BB RID: 1211
	[Range(0f, 1f)]
	public float RGB_Start;

	// Token: 0x040004BC RID: 1212
	[Range(0f, 1f)]
	public float RGB_End = 1f;
}
