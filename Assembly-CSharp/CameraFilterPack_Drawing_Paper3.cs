using System;
using UnityEngine;

// Token: 0x020000AD RID: 173
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Paper3")]
public class CameraFilterPack_Drawing_Paper3 : MonoBehaviour
{
	// Token: 0x060034B4 RID: 13492 RVA: 0x00111FB9 File Offset: 0x001101B9
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_Subtract") as Texture2D);
		this.SCShader = Shader.Find("0 seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034B5 RID: 13493 RVA: 0x00111FF4 File Offset: 0x001101F4
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 926f)
			{
				this.HBJJOCHGOPH = 918f;
			}
			this.IONHGBPGCHK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetColor("_ScreenResolution", this.Pencil_Color);
			this.PDEAHJPOMEF().SetFloat("PointsScoreText", this.Pencil_Size);
			this.CFEDGDGBCHE().SetFloat("DPADVER", this.Pencil_Correction);
			this.MMOODGIODPC().SetFloat("settings_bindings_controller_type", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("The given 2D texture ", this.Speed_Animation);
			this.MMOODGIODPC().SetFloat("Result for ", this.Corner_Lose);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Noise", this.Fade_Paper_to_BackColor);
			this.IONHGBPGCHK().SetFloat("_VignetteTex", this.Fade_With_Original);
			this.GCDFNHMJMIP().SetColor("Selection Box", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("/", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034B7 RID: 13495 RVA: 0x001121EA File Offset: 0x001103EA
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034B8 RID: 13496 RVA: 0x001121EA File Offset: 0x001103EA
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034B9 RID: 13497 RVA: 0x00112207 File Offset: 0x00110407
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("0x") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060034BB RID: 13499 RVA: 0x00112240 File Offset: 0x00110440
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Radius2") as Texture2D);
		this.SCShader = Shader.Find("players");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034BC RID: 13500 RVA: 0x00112279 File Offset: 0x00110479
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034BD RID: 13501 RVA: 0x001122B0 File Offset: 0x001104B0
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Paper4") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Paper3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034BE RID: 13502 RVA: 0x001122E9 File Offset: 0x001104E9
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034BF RID: 13503 RVA: 0x001121EA File Offset: 0x001103EA
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060034C1 RID: 13505 RVA: 0x00112320 File Offset: 0x00110520
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034C2 RID: 13506 RVA: 0x00112358 File Offset: 0x00110558
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 820f)
			{
				this.HBJJOCHGOPH = 1062f;
			}
			this.IONHGBPGCHK().SetFloat("_Alpha", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("_Value4", this.Pencil_Color);
			this.OIMMPLPBLBK().SetFloat("settings.hideui", this.Pencil_Size);
			this.HEHKGPKLAKK().SetFloat("_Value4", this.Pencil_Correction);
			this.IONHGBPGCHK().SetFloat("maps.", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed_Animation);
			this.MMOODGIODPC().SetFloat("id", this.Corner_Lose);
			this.OIMMPLPBLBK().SetFloat("_MainTex", this.Fade_Paper_to_BackColor);
			this.MFHPKGICPIO().SetFloat("_ScreenResolution", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("_Fade", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("_Glitch", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034C3 RID: 13507 RVA: 0x001124B0 File Offset: 0x001106B0
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1735f)
			{
				this.HBJJOCHGOPH = 1484f;
			}
			this.NBPKMLMCHFN.SetFloat("_SizeY", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("_EmissionGain", this.Pencil_Color);
			this.OIMMPLPBLBK().SetFloat("_Value2", this.Pencil_Size);
			this.IONHGBPGCHK().SetFloat("DISTORT", this.Pencil_Correction);
			this.IONHGBPGCHK().SetFloat(".lastCheckpoint.powerupsScore", this.Intensity);
			this.MFHPKGICPIO().SetFloat("_ReflectionTexture2", this.Speed_Animation);
			this.OIMMPLPBLBK().SetFloat("SpectatingUserInfo", this.Corner_Lose);
			this.OIMMPLPBLBK().SetFloat("Checkpoint", this.Fade_Paper_to_BackColor);
			this.OIMMPLPBLBK().SetFloat("1248864821", this.Fade_With_Original);
			this.OIMMPLPBLBK().SetColor("_Parameter", this.Back_Color);
			this.GCDFNHMJMIP().SetTexture("In Main Menu", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x00112606 File Offset: 0x00110806
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("_FinalReflectionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060034C5 RID: 13509 RVA: 0x0011263F File Offset: 0x0011083F
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034C6 RID: 13510 RVA: 0x001121EA File Offset: 0x001103EA
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x00112676 File Offset: 0x00110876
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load(". Check if the server is available.") as Texture2D);
		this.SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034C8 RID: 13512 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x001126B0 File Offset: 0x001108B0
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 144f)
			{
				this.HBJJOCHGOPH = 680f;
			}
			this.MMOODGIODPC().SetFloat("_ChannelMixerGreen", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetColor("<b>Max Score</b>:", this.Pencil_Color);
			this.PDEAHJPOMEF().SetFloat("_Value", this.Pencil_Size);
			this.IONHGBPGCHK().SetFloat("OpCreateRoom()", this.Pencil_Correction);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Intensity);
			this.MFHPKGICPIO().SetFloat("GUICamera", this.Speed_Animation);
			this.HNICHJCGJOC().SetFloat("PLEASE WAIT", this.Corner_Lose);
			this.MMOODGIODPC().SetFloat("\nCreated by Oxy949", this.Fade_Paper_to_BackColor);
			this.MFHPKGICPIO().SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this.Fade_With_Original);
			this.OIMMPLPBLBK().SetColor(". Our prefix is ", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("]. Please verify you have this gameobject in a Resources folder.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x00112806 File Offset: 0x00110A06
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x0011283D File Offset: 0x00110A3D
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("received</b>\n#reason: ") as Texture2D);
		this.SCShader = Shader.Find("_PrefilterOffs");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x00112876 File Offset: 0x00110A76
	private void PKLOBJHKFEO()
	{
		this.FPHEBLMINDA = (Resources.Load("_SmoothEnd") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x001128AF File Offset: 0x00110AAF
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x001128E6 File Offset: 0x00110AE6
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x0011291D File Offset: 0x00110B1D
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("Object ID. Case-Sensitive") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x001121EA File Offset: 0x001103EA
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034D3 RID: 13523 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x00112956 File Offset: 0x00110B56
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x00112990 File Offset: 0x00110B90
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1653f)
			{
				this.HBJJOCHGOPH = 1255f;
			}
			this.CFEDGDGBCHE().SetFloat("\t", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetColor("_DistortionLevel", this.Pencil_Color);
			this.MFHPKGICPIO().SetFloat("Joystick1Button10", this.Pencil_Size);
			this.NBPKMLMCHFN.SetFloat("Clears all text from the debug console", this.Pencil_Correction);
			this.HNICHJCGJOC().SetFloat("OK", this.Intensity);
			this.MFHPKGICPIO().SetFloat("UI", this.Speed_Animation);
			this.IONHGBPGCHK().SetFloat("_FarCamera", this.Corner_Lose);
			this.HNICHJCGJOC().SetFloat("Observed type is not serializable: ", this.Fade_Paper_to_BackColor);
			this.MFHPKGICPIO().SetFloat("menutheme.27thfloor", this.Fade_With_Original);
			this.OIMMPLPBLBK().SetColor(" from: ", this.Back_Color);
			this.MMOODGIODPC().SetTexture("CameraFilterPack/Vision_Psycho", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060034D7 RID: 13527 RVA: 0x00112AE6 File Offset: 0x00110CE6
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("_Max") as Texture2D);
		this.SCShader = Shader.Find("^");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034D8 RID: 13528 RVA: 0x00112B1F File Offset: 0x00110D1F
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("</color>") as Texture2D);
		this.SCShader = Shader.Find("<start_index> <end_index>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034D9 RID: 13529 RVA: 0x00112B58 File Offset: 0x00110D58
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034DA RID: 13530 RVA: 0x001121EA File Offset: 0x001103EA
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x001121EA File Offset: 0x001103EA
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034DC RID: 13532 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x00112B90 File Offset: 0x00110D90
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 381f)
			{
				this.HBJJOCHGOPH = 721f;
			}
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack_Glasses_On2", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetColor("Closes the app", this.Pencil_Color);
			this.IONHGBPGCHK().SetFloat("_Distortion", this.Pencil_Size);
			this.IONHGBPGCHK().SetFloat("_Value2", this.Pencil_Correction);
			this.HEHKGPKLAKK().SetFloat("_ScreenResolution", this.Intensity);
			this.IONHGBPGCHK().SetFloat("Working.\nPlease wait..", this.Speed_Animation);
			this.PDEAHJPOMEF().SetFloat("GameScene", this.Corner_Lose);
			this.IONHGBPGCHK().SetFloat("Tab1Content", this.Fade_Paper_to_BackColor);
			this.GCDFNHMJMIP().SetFloat("-1", this.Fade_With_Original);
			this.CFEDGDGBCHE().SetColor(".lastCheckpoint.currentCombo", this.Back_Color);
			this.OIMMPLPBLBK().SetTexture("Description goes here", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x00112CE8 File Offset: 0x00110EE8
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 916f)
			{
				this.HBJJOCHGOPH = 905f;
			}
			this.HEHKGPKLAKK().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetColor("Image", this.Pencil_Color);
			this.MMOODGIODPC().SetFloat("(\\[ */ *h1 *\\])", this.Pencil_Size);
			this.CFEDGDGBCHE().SetFloat(".lastCheckpoint.lives", this.Pencil_Correction);
			this.IONHGBPGCHK().SetFloat("_Visualize", this.Intensity);
			this.MMOODGIODPC().SetFloat("_Value2", this.Speed_Animation);
			this.IONHGBPGCHK().SetFloat("TotalHitsScoreText", this.Corner_Lose);
			this.MMOODGIODPC().SetFloat("No info", this.Fade_Paper_to_BackColor);
			this.CFEDGDGBCHE().SetFloat("-", this.Fade_With_Original);
			this.OIMMPLPBLBK().SetColor("[Right]", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("_ChromaticAberration", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034DF RID: 13535 RVA: 0x00112E3E File Offset: 0x0011103E
	private void FBPHNEJBDJN()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060034E0 RID: 13536 RVA: 0x00112E78 File Offset: 0x00111078
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 919f)
			{
				this.HBJJOCHGOPH = 1894f;
			}
			this.CFEDGDGBCHE().SetFloat("#pleasewait", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetColor(" ", this.Pencil_Color);
			this.MMOODGIODPC().SetFloat("_Value6", this.Pencil_Size);
			this.IONHGBPGCHK().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.Pencil_Correction);
			this.HNICHJCGJOC().SetFloat("SpawnObj", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("received</b>\n#reason: ", this.Speed_Animation);
			this.HNICHJCGJOC().SetFloat("editor.", this.Corner_Lose);
			this.OIMMPLPBLBK().SetFloat("_Saturation", this.Fade_Paper_to_BackColor);
			this.MFHPKGICPIO().SetFloat("Default UI Material", this.Fade_With_Original);
			this.IONHGBPGCHK().SetColor(".lastCheckpoint.playerdistance", this.Back_Color);
			this.PDEAHJPOMEF().SetTexture("AudioSampler", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034E1 RID: 13537 RVA: 0x001121EA File Offset: 0x001103EA
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034E2 RID: 13538 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x00112FCE File Offset: 0x001111CE
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("NEW") as Texture2D);
		this.SCShader = Shader.Find("{\"items\":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060034E6 RID: 13542 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x00113008 File Offset: 0x00111208
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

	// Token: 0x060034E8 RID: 13544 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x00113160 File Offset: 0x00111360
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 276f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			this.HEHKGPKLAKK().SetFloat("?", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetColor("/icon", this.Pencil_Color);
			this.OIMMPLPBLBK().SetFloat("Connected to masterserver.", this.Pencil_Size);
			this.PDEAHJPOMEF().SetFloat("[PlayerController] ", this.Pencil_Correction);
			this.MMOODGIODPC().SetFloat("Editor/", this.Intensity);
			this.IONHGBPGCHK().SetFloat("_EmissionColor", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat(": ", this.Corner_Lose);
			this.GCDFNHMJMIP().SetFloat("shader.crispwinter", this.Fade_Paper_to_BackColor);
			this.GCDFNHMJMIP().SetFloat("SpeedSlider", this.Fade_With_Original);
			this.HEHKGPKLAKK().SetColor(":", this.Back_Color);
			this.HEHKGPKLAKK().SetTexture("/icon", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x001132B6 File Offset: 0x001114B6
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("[MapsData] Bad map: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x001132EF File Offset: 0x001114EF
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("http://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x00113328 File Offset: 0x00111528
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1174f)
			{
				this.HBJJOCHGOPH = 1132f;
			}
			this.HEHKGPKLAKK().SetFloat("UseScanLine", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("New level loaded. Removed ", this.Pencil_Color);
			this.OIMMPLPBLBK().SetFloat("_InternalLutTex", this.Pencil_Size);
			this.HEHKGPKLAKK().SetFloat("_ScreenResolution", this.Pencil_Correction);
			this.MMOODGIODPC().SetFloat("End index must in an integer.", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("_Value1", this.Speed_Animation);
			this.HNICHJCGJOC().SetFloat(": ", this.Corner_Lose);
			this.MFHPKGICPIO().SetFloat("_Far", this.Fade_Paper_to_BackColor);
			this.GCDFNHMJMIP().SetFloat("Drop_With_Obj", this.Fade_With_Original);
			this.HNICHJCGJOC().SetColor("_Value4", this.Back_Color);
			this.MFHPKGICPIO().SetTexture("mapselector.tags.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x0011347E File Offset: 0x0011167E
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("\n - NetID: ") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034EF RID: 13551 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060034F1 RID: 13553 RVA: 0x001121EA File Offset: 0x001103EA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034F2 RID: 13554 RVA: 0x001134B8 File Offset: 0x001116B8
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 143f)
			{
				this.HBJJOCHGOPH = 251f;
			}
			this.HEHKGPKLAKK().SetFloat("[SERVER] Kicked ", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetColor("_Quality", this.Pencil_Color);
			this.HNICHJCGJOC().SetFloat("maps.", this.Pencil_Size);
			this.GCDFNHMJMIP().SetFloat("_BlurRadius4", this.Pencil_Correction);
			this.MMOODGIODPC().SetFloat("player.redarc", this.Intensity);
			this.HNICHJCGJOC().SetFloat("_MotionBlurTmpCam", this.Speed_Animation);
			this.IONHGBPGCHK().SetFloat("bad", this.Corner_Lose);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/TV_Noise", this.Fade_Paper_to_BackColor);
			this.HEHKGPKLAKK().SetFloat("Hidden/Fast Approximate Anti-aliasing", this.Fade_With_Original);
			this.MMOODGIODPC().SetColor("[PlayerController] ", this.Back_Color);
			this.HNICHJCGJOC().SetTexture("IconFileSelector", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x001121EA File Offset: 0x001103EA
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034F4 RID: 13556 RVA: 0x001121EA File Offset: 0x001103EA
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034F5 RID: 13557 RVA: 0x00113610 File Offset: 0x00111810
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 678f)
			{
				this.HBJJOCHGOPH = 1139f;
			}
			this.NBPKMLMCHFN.SetFloat("_FadeDistance", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetColor("Parameter levelId can't be null!", this.Pencil_Color);
			this.OIMMPLPBLBK().SetFloat("OperationResponse ignored while disconnecting. Code: ", this.Pencil_Size);
			this.HNICHJCGJOC().SetFloat("UI Extensions/UIScreen", this.Pencil_Correction);
			this.MMOODGIODPC().SetFloat("LoadMapCanvas", this.Intensity);
			this.OIMMPLPBLBK().SetFloat("cancel", this.Speed_Animation);
			this.PDEAHJPOMEF().SetFloat("[PlayerBase] Loaded custom model: ", this.Corner_Lose);
			this.MFHPKGICPIO().SetFloat("0", this.Fade_Paper_to_BackColor);
			this.IONHGBPGCHK().SetFloat("settings_bindings_", this.Fade_With_Original);
			this.HNICHJCGJOC().SetColor("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", this.Back_Color);
			this.GCDFNHMJMIP().SetTexture("Fill Area", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034F6 RID: 13558 RVA: 0x00113768 File Offset: 0x00111968
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 64f)
			{
				this.HBJJOCHGOPH = 1020f;
			}
			this.MMOODGIODPC().SetFloat("[DiscordController] Error {0}: {1}", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetColor("shader.ghost", this.Pencil_Color);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/Blend2Camera_Color", this.Pencil_Size);
			this.MMOODGIODPC().SetFloat("Tab2Content", this.Pencil_Correction);
			this.GCDFNHMJMIP().SetFloat("stretchWidth", this.Intensity);
			this.CFEDGDGBCHE().SetFloat("Myst", this.Speed_Animation);
			this.HEHKGPKLAKK().SetFloat("float,0", this.Corner_Lose);
			this.HNICHJCGJOC().SetFloat("note.2", this.Fade_Paper_to_BackColor);
			this.IONHGBPGCHK().SetFloat("[PlayerController] ", this.Fade_With_Original);
			this.OIMMPLPBLBK().SetColor("file://", this.Back_Color);
			this.CFEDGDGBCHE().SetTexture("maps.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060034F7 RID: 13559 RVA: 0x001138BE File Offset: 0x00111ABE
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

	// Token: 0x060034F8 RID: 13560 RVA: 0x001121EA File Offset: 0x001103EA
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040005DC RID: 1500
	public Shader SCShader;

	// Token: 0x040005DD RID: 1501
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005DE RID: 1502
	public Color Pencil_Color = new Color(0f, 0f, 0f, 0f);

	// Token: 0x040005DF RID: 1503
	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size = 0.00125f;

	// Token: 0x040005E0 RID: 1504
	[Range(0f, 2f)]
	public float Pencil_Correction = 0.35f;

	// Token: 0x040005E1 RID: 1505
	[Range(0f, 1f)]
	public float Intensity = 1f;

	// Token: 0x040005E2 RID: 1506
	[Range(0f, 2f)]
	public float Speed_Animation = 1f;

	// Token: 0x040005E3 RID: 1507
	[Range(0f, 1f)]
	public float Corner_Lose = 1f;

	// Token: 0x040005E4 RID: 1508
	[Range(0f, 1f)]
	public float Fade_Paper_to_BackColor;

	// Token: 0x040005E5 RID: 1509
	[Range(0f, 1f)]
	public float Fade_With_Original = 1f;

	// Token: 0x040005E6 RID: 1510
	public Color Back_Color = new Color(1f, 1f, 1f, 1f);

	// Token: 0x040005E7 RID: 1511
	private Material BJFKDHHMLJH;

	// Token: 0x040005E8 RID: 1512
	private Texture2D FPHEBLMINDA;
}
