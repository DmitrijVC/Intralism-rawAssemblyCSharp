using System;
using UnityEngine;

// Token: 0x02000097 RID: 151
[AddComponentMenu("Camera Filter Pack/Drawing/BluePrint")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_BluePrint : MonoBehaviour
{
	// Token: 0x06002D2D RID: 11565 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06002D2E RID: 11566 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D2F RID: 11567 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002D30 RID: 11568 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06002D31 RID: 11569 RVA: 0x000F3BA3 File Offset: 0x000F1DA3
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D32 RID: 11570 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D33 RID: 11571 RVA: 0x000F3BDA File Offset: 0x000F1DDA
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("offsets") as Texture2D);
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D34 RID: 11572 RVA: 0x000F3C13 File Offset: 0x000F1E13
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D35 RID: 11573 RVA: 0x000F3C4A File Offset: 0x000F1E4A
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/FX_Spot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D36 RID: 11574 RVA: 0x000F3C83 File Offset: 0x000F1E83
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D37 RID: 11575 RVA: 0x000F3CBA File Offset: 0x000F1EBA
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D38 RID: 11576 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D39 RID: 11577 RVA: 0x000F3CF4 File Offset: 0x000F1EF4
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1522f)
			{
				this.HBJJOCHGOPH = 1581f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value3", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetColor("Unsupported target enum: ", this.Pencil_Color);
			this.NLFJGMBCICG().SetFloat("_Value5", this.Pencil_Size);
			this.AELJLBOJAIL().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Pencil_Correction);
			this.EMDFHOKEGNG().SetFloat(": ", this.Intensity);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", this.Speed_Animation);
			this.NLFJGMBCICG().SetFloat("Crosshair2", this.Corner_Lose);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Fade_Paper_to_BackColor);
			this.NBMPPNFKFLB().SetFloat("Set Particles Gravity", this.Fade_With_Original);
			this.CIAFLBFJLEJ().SetColor("CameraFilterPack/Blur_Dithering2x2", this.Back_Color);
			this.AELJLBOJAIL().SetTexture("CountEventsGoal", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D3A RID: 11578 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06002D3B RID: 11579 RVA: 0x000F3E4A File Offset: 0x000F204A
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor") as Texture2D);
		this.SCShader = Shader.Find("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D3C RID: 11580 RVA: 0x000F3E83 File Offset: 0x000F2083
	private void FLKEJJEGCFA()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.enablerankingnotifications") as Texture2D);
		this.SCShader = Shader.Find("checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D3D RID: 11581 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D3E RID: 11582 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06002D3F RID: 11583 RVA: 0x000F3EBC File Offset: 0x000F20BC
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D40 RID: 11584 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D41 RID: 11585 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D42 RID: 11586 RVA: 0x000F3EF4 File Offset: 0x000F20F4
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 761f)
			{
				this.HBJJOCHGOPH = 807f;
			}
			this.PLBEJJIHFPB().SetFloat("[MapsData] Caching ", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetColor("InventoryButton", this.Pencil_Color);
			this.IONHGBPGCHK().SetFloat("ShineEffect", this.Pencil_Size);
			this.AELJLBOJAIL().SetFloat("[PlayerController] ", this.Pencil_Correction);
			this.AELJLBOJAIL().SetFloat("_Value", this.Intensity);
			this.DBOLLHHMKKN().SetFloat("_Distortion", this.Speed_Animation);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.Corner_Lose);
			this.AELJLBOJAIL().SetFloat("fade in duration", this.Fade_Paper_to_BackColor);
			this.PLBEJJIHFPB().SetFloat("_Value", this.Fade_With_Original);
			this.PLBEJJIHFPB().SetColor("Testing, a toggle has toggled [", this.Back_Color);
			this.EMDFHOKEGNG().SetTexture("false", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D44 RID: 11588 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x000F404C File Offset: 0x000F224C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 192f)
			{
				this.HBJJOCHGOPH = 1957f;
			}
			this.GKILCDHJFEG().SetFloat("_Parameter", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetColor("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.Pencil_Color);
			this.DKNJGHFLAIF().SetFloat("Avoid using this directly. Thanks.", this.Pencil_Size);
			this.CFEDGDGBCHE().SetFloat("resource", this.Pencil_Correction);
			this.NLFJGMBCICG().SetFloat(". Calling ConnectToRegionMaster() is: ", this.Intensity);
			this.CFEDGDGBCHE().SetFloat("Added checkpoint", this.Speed_Animation);
			this.CIAFLBFJLEJ().SetFloat("Y", this.Corner_Lose);
			this.DKNJGHFLAIF().SetFloat("FPSToggle", this.Fade_Paper_to_BackColor);
			this.NBMPPNFKFLB().SetFloat("_LightIntensity", this.Fade_With_Original);
			this.EMDFHOKEGNG().SetColor("_DotSize", this.Back_Color);
			this.NBMPPNFKFLB().SetTexture("_Value12", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06002D49 RID: 11593 RVA: 0x000F41A2 File Offset: 0x000F23A2
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

	// Token: 0x06002D4A RID: 11594 RVA: 0x000F41DC File Offset: 0x000F23DC
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1490f)
			{
				this.HBJJOCHGOPH = 1459f;
			}
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetColor("CountEventsGoal", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("[PlayerController] ", this.Pencil_Size);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Light_Water2", this.Pencil_Correction);
			this.CFCPHFMKHII().SetFloat("_Smooth", this.Intensity);
			this.MMOODGIODPC().SetFloat("ItemsUploader", this.Speed_Animation);
			this.AELJLBOJAIL().SetFloat("type", this.Corner_Lose);
			this.DKNJGHFLAIF().SetFloat("settings.enablehitsoundsinnormal", this.Fade_Paper_to_BackColor);
			this.NBMPPNFKFLB().SetFloat("OxOD.lastPath", this.Fade_With_Original);
			this.CFCPHFMKHII().SetColor("AudioSampler", this.Back_Color);
			this.DKNJGHFLAIF().SetTexture("_Color2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D4B RID: 11595 RVA: 0x000F4332 File Offset: 0x000F2532
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D4C RID: 11596 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06002D4D RID: 11597 RVA: 0x000F4369 File Offset: 0x000F2569
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D4E RID: 11598 RVA: 0x000F43A2 File Offset: 0x000F25A2
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D4F RID: 11599 RVA: 0x000F43D9 File Offset: 0x000F25D9
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("SubmitUserVote:") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/NightVisionFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D50 RID: 11600 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D51 RID: 11601 RVA: 0x000F4412 File Offset: 0x000F2612
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D52 RID: 11602 RVA: 0x000F444C File Offset: 0x000F264C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1047f)
			{
				this.HBJJOCHGOPH = 1025f;
			}
			this.DKNJGHFLAIF().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetColor(" to: ", this.Pencil_Color);
			this.NBPKMLMCHFN.SetFloat("Clears the console and prints the logs in the specified range", this.Pencil_Size);
			this.NLFJGMBCICG().SetFloat("[PlayerBase] Loaded spawner data", this.Pencil_Correction);
			this.IONHGBPGCHK().SetFloat("menu.tabid", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.Speed_Animation);
			this.GKILCDHJFEG().SetFloat("[DiscordController] Shutdown", this.Corner_Lose);
			this.IONHGBPGCHK().SetFloat("mapselector.tags.", this.Fade_Paper_to_BackColor);
			this.CFEDGDGBCHE().SetFloat(".lastCheckpoint.powerupsScore", this.Fade_With_Original);
			this.NBMPPNFKFLB().SetColor("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", this.Back_Color);
			this.EMDFHOKEGNG().SetTexture("#mapmustbecompletebeforesubmit", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D53 RID: 11603 RVA: 0x000F45A4 File Offset: 0x000F27A4
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
			this.NBPKMLMCHFN.SetColor("_PColor", this.Pencil_Color);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.Pencil_Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Pencil_Correction);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Corner_Lose);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Fade_Paper_to_BackColor);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("_PColor2", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D54 RID: 11604 RVA: 0x000F46FA File Offset: 0x000F28FA
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/TV_50") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D55 RID: 11605 RVA: 0x000F4733 File Offset: 0x000F2933
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("[Right-Left]") as Texture2D);
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D56 RID: 11606 RVA: 0x000F476C File Offset: 0x000F296C
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1713f)
			{
				this.HBJJOCHGOPH = 1598f;
			}
			this.MMOODGIODPC().SetFloat("_Far", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetColor("[", this.Pencil_Color);
			this.AELJLBOJAIL().SetFloat("menutheme.deleted", this.Pencil_Size);
			this.GKILCDHJFEG().SetFloat("_FarCamera", this.Pencil_Correction);
			this.BFGNMFCNDBC().SetFloat("Added checkpoint", this.Intensity);
			this.EJDPNJAEAKJ().SetFloat("X", this.Speed_Animation);
			this.NBMPPNFKFLB().SetFloat("Reset", this.Corner_Lose);
			this.IONHGBPGCHK().SetFloat("Start", this.Fade_Paper_to_BackColor);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/Drawing_Halftone", this.Fade_With_Original);
			this.IONHGBPGCHK().SetColor("Tab1Content", this.Back_Color);
			this.PLBEJJIHFPB().SetTexture("[PlayerController] ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D57 RID: 11607 RVA: 0x000F48C2 File Offset: 0x000F2AC2
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D58 RID: 11608 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06002D59 RID: 11609 RVA: 0x000F48FC File Offset: 0x000F2AFC
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 212f)
			{
				this.HBJJOCHGOPH = 1691f;
			}
			this.DBOLLHHMKKN().SetFloat("In Main Menu", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetColor("_ScreenResolution", this.Pencil_Color);
			this.AELJLBOJAIL().SetFloat("_Value2", this.Pencil_Size);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Atmosphere_Rain", this.Pencil_Correction);
			this.GKILCDHJFEG().SetFloat("float,0", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("OpJoinRoom()", this.Speed_Animation);
			this.EJDPNJAEAKJ().SetFloat("Stream did not contain properly formatted byte array", this.Corner_Lose);
			this.MMOODGIODPC().SetFloat("_Value4", this.Fade_Paper_to_BackColor);
			this.DBOLLHHMKKN().SetFloat("SetupEncryption() got called. ", this.Fade_With_Original);
			this.BFGNMFCNDBC().SetColor("/", this.Back_Color);
			this.DBOLLHHMKKN().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D5A RID: 11610 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06002D5B RID: 11611 RVA: 0x000F4A54 File Offset: 0x000F2C54
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1164f)
			{
				this.HBJJOCHGOPH = 453f;
			}
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/Color_Chromatic_Plus", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetColor(".g", this.Pencil_Color);
			this.BFGNMFCNDBC().SetFloat("Forward", this.Pencil_Size);
			this.EJDPNJAEAKJ().SetFloat("event", this.Pencil_Correction);
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack/Colors_Brightness", this.Intensity);
			this.MMOODGIODPC().SetFloat("CameraFilterPack/Color_Switching", this.Speed_Animation);
			this.NLFJGMBCICG().SetFloat("_FixDistance", this.Corner_Lose);
			this.CFEDGDGBCHE().SetFloat("_BorderSize", this.Fade_Paper_to_BackColor);
			this.CFCPHFMKHII().SetFloat("_ScreenResolution", this.Fade_With_Original);
			this.PGPEMMBJOOG().SetColor("Mouse1", this.Back_Color);
			this.BFGNMFCNDBC().SetTexture("Checkpoint", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D5C RID: 11612 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D5D RID: 11613 RVA: 0x000F4BAA File Offset: 0x000F2DAA
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D5E RID: 11614 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D5F RID: 11615 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06002D60 RID: 11616 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D61 RID: 11617 RVA: 0x000F4BE1 File Offset: 0x000F2DE1
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D62 RID: 11618 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D63 RID: 11619 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06002D64 RID: 11620 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002D65 RID: 11621 RVA: 0x000F4C18 File Offset: 0x000F2E18
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Focus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D66 RID: 11622 RVA: 0x000F4C54 File Offset: 0x000F2E54
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1442f)
			{
				this.HBJJOCHGOPH = 961f;
			}
			this.NLFJGMBCICG().SetFloat("Emergency Help:", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("_Value7", this.Pencil_Color);
			this.IONHGBPGCHK().SetFloat("#{0:00} '{1}'{2} {3}", this.Pencil_Size);
			this.DBOLLHHMKKN().SetFloat("#exitmapeditor", this.Pencil_Correction);
			this.DBOLLHHMKKN().SetFloat("_FixDistance", this.Intensity);
			this.GKILCDHJFEG().SetFloat(" ", this.Speed_Animation);
			this.CIAFLBFJLEJ().SetFloat("true", this.Corner_Lose);
			this.DBOLLHHMKKN().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", this.Fade_Paper_to_BackColor);
			this.DKNJGHFLAIF().SetFloat("#FFFFFFFF", this.Fade_With_Original);
			this.EMDFHOKEGNG().SetColor("_Visualize", this.Back_Color);
			this.EMDFHOKEGNG().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D67 RID: 11623 RVA: 0x000F4DAA File Offset: 0x000F2FAA
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("Object ID. Case-Sensitive") as Texture2D);
		this.SCShader = Shader.Find("PublishButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D68 RID: 11624 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06002D69 RID: 11625 RVA: 0x000F4DE4 File Offset: 0x000F2FE4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 416f)
			{
				this.HBJJOCHGOPH = 1301f;
			}
			this.NLFJGMBCICG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetColor("#loopnumber ", this.Pencil_Color);
			this.DKNJGHFLAIF().SetFloat(" GameServer:", this.Pencil_Size);
			this.PLBEJJIHFPB().SetFloat("IconImage", this.Pencil_Correction);
			this.MMOODGIODPC().SetFloat("Object ID. Case-Sensitive", this.Intensity);
			this.CFCPHFMKHII().SetFloat("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("cameramovements:", this.Corner_Lose);
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.Fade_Paper_to_BackColor);
			this.DBOLLHHMKKN().SetFloat("_Angle", this.Fade_With_Original);
			this.MMOODGIODPC().SetColor("[CraftingPanel] Init", this.Back_Color);
			this.NBMPPNFKFLB().SetTexture("\t", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D6A RID: 11626 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D6B RID: 11627 RVA: 0x000F4F3C File Offset: 0x000F313C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 355f)
			{
				this.HBJJOCHGOPH = 816f;
			}
			this.MMOODGIODPC().SetFloat(": ", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetColor("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", this.Pencil_Color);
			this.EMDFHOKEGNG().SetFloat("maps.", this.Pencil_Size);
			this.DKNJGHFLAIF().SetFloat("return ", this.Pencil_Correction);
			this.AELJLBOJAIL().SetFloat("_Dist", this.Intensity);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.Speed_Animation);
			this.DKNJGHFLAIF().SetFloat("{0}", this.Corner_Lose);
			this.GKILCDHJFEG().SetFloat("'{0}' \t{1}ms \t{2}", this.Fade_Paper_to_BackColor);
			this.MMOODGIODPC().SetFloat("_TintColor", this.Fade_With_Original);
			this.NBMPPNFKFLB().SetColor("_LutTex", this.Back_Color);
			this.PLBEJJIHFPB().SetTexture("editor.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D6C RID: 11628 RVA: 0x000F5094 File Offset: 0x000F3294
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1536f)
			{
				this.HBJJOCHGOPH = 297f;
			}
			this.CIAFLBFJLEJ().SetFloat("turn", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetColor("settings.shaders", this.Pencil_Color);
			this.NBPKMLMCHFN.SetFloat("Clears the console and prints the logs in the specified range", this.Pencil_Size);
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack/Drawing_Manga2", this.Pencil_Correction);
			this.CFCPHFMKHII().SetFloat("CameraFilterPack/Real_VHS", this.Intensity);
			this.AELJLBOJAIL().SetFloat("help", this.Speed_Animation);
			this.NBMPPNFKFLB().SetFloat("_Color2", this.Corner_Lose);
			this.NBPKMLMCHFN.SetFloat("SupportLogger OnJoinedLobby(", this.Fade_Paper_to_BackColor);
			this.PLBEJJIHFPB().SetFloat("LevelURLInputField", this.Fade_With_Original);
			this.AELJLBOJAIL().SetColor("offsets", this.Back_Color);
			this.CFCPHFMKHII().SetTexture("getbool", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D6D RID: 11629 RVA: 0x000F51EA File Offset: 0x000F33EA
	private void FBPHNEJBDJN()
	{
		this.FPHEBLMINDA = (Resources.Load(":\n") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D6E RID: 11630 RVA: 0x000F5224 File Offset: 0x000F3424
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1496f)
			{
				this.HBJJOCHGOPH = 488f;
			}
			this.EJDPNJAEAKJ().SetFloat("OpLeaveLobby()", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetColor("skin.hit_wrong", this.Pencil_Color);
			this.NLFJGMBCICG().SetFloat("mapid", this.Pencil_Size);
			this.AELJLBOJAIL().SetFloat("/", this.Pencil_Correction);
			this.CIAFLBFJLEJ().SetFloat("_MainTex2", this.Intensity);
			this.AELJLBOJAIL().SetFloat("maps.", this.Speed_Animation);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/Drawing_NewCellShading", this.Corner_Lose);
			this.EJDPNJAEAKJ().SetFloat("'{0}' \t{1}ms \t{2}", this.Fade_Paper_to_BackColor);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("Right ", this.Back_Color);
			this.CFEDGDGBCHE().SetTexture("[MapsStats] Hash: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D6F RID: 11631 RVA: 0x000F537C File Offset: 0x000F357C
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1703f)
			{
				this.HBJJOCHGOPH = 195f;
			}
			this.PGPEMMBJOOG().SetFloat("Crosshair1", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("#", this.Pencil_Color);
			this.CFCPHFMKHII().SetFloat("_Value3", this.Pencil_Size);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.Pencil_Correction);
			this.EMDFHOKEGNG().SetFloat("ItemNameText", this.Intensity);
			this.AELJLBOJAIL().SetFloat("Fade", this.Speed_Animation);
			this.DBOLLHHMKKN().SetFloat("_FarCamera", this.Corner_Lose);
			this.PLBEJJIHFPB().SetFloat("[PlayerBase] SetPlayerDistance error: ", this.Fade_Paper_to_BackColor);
			this.NLFJGMBCICG().SetFloat("OnReadyClick", this.Fade_With_Original);
			this.NLFJGMBCICG().SetColor("HandsCountSlider", this.Back_Color);
			this.CFCPHFMKHII().SetTexture("ERROR: Make sure your mod contains at leats one file!", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D70 RID: 11632 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06002D71 RID: 11633 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06002D72 RID: 11634 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06002D74 RID: 11636 RVA: 0x000F557D File Offset: 0x000F377D
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/FX_Scan") as Texture2D);
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D75 RID: 11637 RVA: 0x000F55B6 File Offset: 0x000F37B6
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("11") as Texture2D);
		this.SCShader = Shader.Find("misses");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D76 RID: 11638 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D77 RID: 11639 RVA: 0x000F55EF File Offset: 0x000F37EF
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("Parent ID") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D78 RID: 11640 RVA: 0x000F5628 File Offset: 0x000F3828
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 623f)
			{
				this.HBJJOCHGOPH = 1772f;
			}
			this.DBOLLHHMKKN().SetFloat("player.goldlollipop", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetColor("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", this.Pencil_Color);
			this.AELJLBOJAIL().SetFloat("_MainTex2", this.Pencil_Size);
			this.NLFJGMBCICG().SetFloat("maps.", this.Pencil_Correction);
			this.NBMPPNFKFLB().SetFloat("GlassesColor", this.Intensity);
			this.PGPEMMBJOOG().SetFloat("GameScene", this.Speed_Animation);
			this.CIAFLBFJLEJ().SetFloat("_Value4", this.Corner_Lose);
			this.AELJLBOJAIL().SetFloat("_Value1", this.Fade_Paper_to_BackColor);
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] SetBGColor error: ", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("_MainTex2", this.Back_Color);
			this.EJDPNJAEAKJ().SetTexture(".lastCheckpoint.powerupsScore", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D79 RID: 11641 RVA: 0x000F577E File Offset: 0x000F397E
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D7A RID: 11642 RVA: 0x000F57B5 File Offset: 0x000F39B5
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D7B RID: 11643 RVA: 0x000F57EC File Offset: 0x000F39EC
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("EventMenu") as Texture2D);
		this.SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D7C RID: 11644 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D7D RID: 11645 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D7E RID: 11646 RVA: 0x000F5825 File Offset: 0x000F3A25
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D7F RID: 11647 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D80 RID: 11648 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D81 RID: 11649 RVA: 0x000F585E File Offset: 0x000F3A5E
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Paper2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_BluePrint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D82 RID: 11650 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D83 RID: 11651 RVA: 0x000F5897 File Offset: 0x000F3A97
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D84 RID: 11652 RVA: 0x000F58D0 File Offset: 0x000F3AD0
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1068f)
			{
				this.HBJJOCHGOPH = 404f;
			}
			this.DKNJGHFLAIF().SetFloat("ArcsNoHitsoundTimeDelaySlider", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetColor("/", this.Pencil_Color);
			this.CIAFLBFJLEJ().SetFloat(".g", this.Pencil_Size);
			this.GKILCDHJFEG().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", this.Pencil_Correction);
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this.Intensity);
			this.AELJLBOJAIL().SetFloat("SelectorMapsCountSlider", this.Speed_Animation);
			this.PGPEMMBJOOG().SetFloat("In Main Menu", this.Corner_Lose);
			this.MMOODGIODPC().SetFloat("maps.", this.Fade_Paper_to_BackColor);
			this.CIAFLBFJLEJ().SetFloat("Joystick1Button5", this.Fade_With_Original);
			this.EMDFHOKEGNG().SetColor("bpmgrid", this.Back_Color);
			this.CIAFLBFJLEJ().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D85 RID: 11653 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D86 RID: 11654 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D87 RID: 11655 RVA: 0x000F5A26 File Offset: 0x000F3C26
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D88 RID: 11656 RVA: 0x000F5A5D File Offset: 0x000F3C5D
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D89 RID: 11657 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06002D8A RID: 11658 RVA: 0x000F5A94 File Offset: 0x000F3C94
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("UseScanLineSize") as Texture2D);
		this.SCShader = Shader.Find("settings.volume.editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D8B RID: 11659 RVA: 0x000F3B86 File Offset: 0x000F1D86
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D8C RID: 11660 RVA: 0x000F5ACD File Offset: 0x000F3CCD
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000544 RID: 1348
	public Shader SCShader;

	// Token: 0x04000545 RID: 1349
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000546 RID: 1350
	public Color Pencil_Color = new Color(1f, 1f, 1f, 1f);

	// Token: 0x04000547 RID: 1351
	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size = 0.0008f;

	// Token: 0x04000548 RID: 1352
	[Range(0f, 2f)]
	public float Pencil_Correction = 0.76f;

	// Token: 0x04000549 RID: 1353
	[Range(0f, 1f)]
	public float Intensity = 1f;

	// Token: 0x0400054A RID: 1354
	[Range(0f, 2f)]
	public float Speed_Animation = 1f;

	// Token: 0x0400054B RID: 1355
	[Range(0f, 1f)]
	public float Corner_Lose = 0.5f;

	// Token: 0x0400054C RID: 1356
	[Range(0f, 1f)]
	public float Fade_Paper_to_BackColor = 0.2f;

	// Token: 0x0400054D RID: 1357
	[Range(0f, 1f)]
	public float Fade_With_Original = 1f;

	// Token: 0x0400054E RID: 1358
	public Color Back_Color = new Color(0.175f, 0.402f, 0.687f, 1f);

	// Token: 0x0400054F RID: 1359
	private Material BJFKDHHMLJH;

	// Token: 0x04000550 RID: 1360
	private Texture2D FPHEBLMINDA;
}
