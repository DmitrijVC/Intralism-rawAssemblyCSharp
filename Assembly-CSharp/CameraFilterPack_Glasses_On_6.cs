using System;
using UnityEngine;

// Token: 0x020000DD RID: 221
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Spy")]
public class CameraFilterPack_Glasses_On_6 : MonoBehaviour
{
	// Token: 0x060043AE RID: 17326 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043AF RID: 17327 RVA: 0x0014D8C0 File Offset: 0x0014BAC0
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 833f)
			{
				this.HBJJOCHGOPH = 1183f;
			}
			this.FAIFBBGFAIB().SetFloat("Connecting to server", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("<start_index> <end_index>", this.UseFinalGlassColor);
			this.OGMEGHKECAH().SetFloat(" beatThreshold: ", this.Fade);
			this.BFGNMFCNDBC().SetFloat("Joystick1Button10", this.VisionBlur);
			this.MFHPKGICPIO().SetFloat("challenges.", this.GlassDistortion);
			this.OKJOKHGJHGF().SetFloat("Creating new item...", this.GlassAberration);
			this.ADGHJOHKEHG().SetColor("_TimeX", this.GlassesColor);
			this.ADGHJOHKEHG().SetColor("Gameplay/particles", this.GlassesColor2);
			this.LPMLLJKMAMP().SetColor("_Red_C", this.GlassColor);
			this.ADAFMBOGPLN().SetFloat("_ReflectionTexture1", this.UseScanLineSize);
			this.ELBMIEOIABA().SetFloat("_Gain", this.UseScanLine);
			this.IIJMIPBMMBF().SetTexture("inventory.selected.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043B0 RID: 17328 RVA: 0x0014DA2C File Offset: 0x0014BC2C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1170f)
			{
				this.HBJJOCHGOPH = 1984f;
			}
			this.HJGEHJDMCGI().SetFloat(" canvas not found", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("history", this.UseFinalGlassColor);
			this.FAIFBBGFAIB().SetFloat("_ScreenResolution", this.Fade);
			this.LPMLLJKMAMP().SetFloat("_SunColor", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat("_Distortion", this.GlassDistortion);
			this.IONHGBPGCHK().SetFloat(".message", this.GlassAberration);
			this.ADGHJOHKEHG().SetColor("No Name", this.GlassesColor);
			this.LPMLLJKMAMP().SetColor("_Value7", this.GlassesColor2);
			this.IIJMIPBMMBF().SetColor("ItemNameText", this.GlassColor);
			this.OJMHIMIPKME().SetFloat("OK", this.UseScanLineSize);
			this.LMLENGFLEBD().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture("[PlayerController] ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043B1 RID: 17329 RVA: 0x0014DB98 File Offset: 0x0014BD98
	private void JONGNKNLLND()
	{
		this.FPHEBLMINDA = (Resources.Load("_SecondTex") as Texture2D);
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043B2 RID: 17330 RVA: 0x0014DBD1 File Offset: 0x0014BDD1
	private void DBEMDAJDDDA()
	{
		this.FPHEBLMINDA = (Resources.Load("set environment id") as Texture2D);
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043B3 RID: 17331 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060043B4 RID: 17332 RVA: 0x0014DC0C File Offset: 0x0014BE0C
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 115f)
			{
				this.HBJJOCHGOPH = 36f;
			}
			this.ELBMIEOIABA().SetFloat("_PColor2", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat(" on effect ", this.UseFinalGlassColor);
			this.LPMLLJKMAMP().SetFloat("LevelNameInputField", this.Fade);
			this.EFMCNLELMDO().SetFloat("maps.", this.VisionBlur);
			this.ELBMIEOIABA().SetFloat("_ScreenResolution", this.GlassDistortion);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.GlassAberration);
			this.LMLENGFLEBD().SetColor("_Value3", this.GlassesColor);
			this.FAIFBBGFAIB().SetColor(": ", this.GlassesColor2);
			this.ADGHJOHKEHG().SetColor("value", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("Mouse2", this.UseScanLineSize);
			this.FAIFBBGFAIB().SetFloat("Joystick1Button7", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("_Intensity", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043B5 RID: 17333 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x060043B6 RID: 17334 RVA: 0x0014DD78 File Offset: 0x0014BF78
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 857f)
			{
				this.HBJJOCHGOPH = 1951f;
			}
			this.HJGEHJDMCGI().SetFloat(" ", this.HBJJOCHGOPH);
			this.HJGEHJDMCGI().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.UseFinalGlassColor);
			this.PLBEJJIHFPB().SetFloat(" is muted", this.Fade);
			this.ELBMIEOIABA().SetFloat("_MainTexBlurred", this.VisionBlur);
			this.OKJOKHGJHGF().SetFloat("{0:0} hour{1}, ", this.GlassDistortion);
			this.EFMCNLELMDO().SetFloat("CameraFilterPack/Blur_Blurry", this.GlassAberration);
			this.OKJOKHGJHGF().SetColor("/", this.GlassesColor);
			this.KLKILLCHJHO().SetColor("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", this.GlassesColor2);
			this.KLKILLCHJHO().SetColor("/", this.GlassColor);
			this.LPPEPKGFOEM().SetFloat("/", this.UseScanLineSize);
			this.MFHPKGICPIO().SetFloat("_Bloom3", this.UseScanLine);
			this.IIJMIPBMMBF().SetTexture("Edited unlock conditions", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043B7 RID: 17335 RVA: 0x0014DEE4 File Offset: 0x0014C0E4
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("Received your UserID from server. Updating local value to: {0}") as Texture2D);
		this.SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043B8 RID: 17336 RVA: 0x0014DF1D File Offset: 0x0014C11D
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction") as Texture2D);
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060043B9 RID: 17337 RVA: 0x0014DF58 File Offset: 0x0014C158
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 278f)
			{
				this.HBJJOCHGOPH = 567f;
			}
			this.ADAFMBOGPLN().SetFloat("id", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("_Amount", this.UseFinalGlassColor);
			this.KLKILLCHJHO().SetFloat("y", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Sending vacant view IDs. Length: ", this.VisionBlur);
			this.OJMHIMIPKME().SetFloat("settings_bindings_sec_", this.GlassDistortion);
			this.ELBMIEOIABA().SetFloat("ResourcesConfig", this.GlassAberration);
			this.LPPEPKGFOEM().SetColor("score", this.GlassesColor);
			this.IONHGBPGCHK().SetColor("_Value6", this.GlassesColor2);
			this.EFMCNLELMDO().SetColor("Authentication failed: '{0}' Code: {1}", this.GlassColor);
			this.BFGNMFCNDBC().SetFloat(".highscore", this.UseScanLineSize);
			this.IONHGBPGCHK().SetFloat("GlassColor", this.UseScanLine);
			this.LMLENGFLEBD().SetTexture("MultiplayerButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043BA RID: 17338 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043BB RID: 17339 RVA: 0x0014E0C4 File Offset: 0x0014C2C4
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1746f)
			{
				this.HBJJOCHGOPH = 1417f;
			}
			this.ADAFMBOGPLN().SetFloat("Load Game", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("Default UI Material", this.UseFinalGlassColor);
			this.BFGNMFCNDBC().SetFloat("_Value2", this.Fade);
			this.OGMEGHKECAH().SetFloat("skin.", this.VisionBlur);
			this.HJGEHJDMCGI().SetFloat("_Value5", this.GlassDistortion);
			this.ADGHJOHKEHG().SetFloat("maps.", this.GlassAberration);
			this.LMLENGFLEBD().SetColor(" Maybe GO was destroyed but RPC not cleaned up.", this.GlassesColor);
			this.IONHGBPGCHK().SetColor("[NetworkManager] Connected to ", this.GlassesColor2);
			this.OKJOKHGJHGF().SetColor("_MainTex2", this.GlassColor);
			this.LPPEPKGFOEM().SetFloat("Reload Maps", this.UseScanLineSize);
			this.OJMHIMIPKME().SetFloat("EndlessLoopsScoreText", this.UseScanLine);
			this.PLBEJJIHFPB().SetTexture(" beatThreshold: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043BC RID: 17340 RVA: 0x0014E230 File Offset: 0x0014C430
	private void NKFDNIAKGEO()
	{
		this.FPHEBLMINDA = (Resources.Load("ShowTitle") as Texture2D);
		this.SCShader = Shader.Find("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043BD RID: 17341 RVA: 0x0014E269 File Offset: 0x0014C469
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("Data") as Texture2D);
		this.SCShader = Shader.Find("_LowRez");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043BE RID: 17342 RVA: 0x0014E2A2 File Offset: 0x0014C4A2
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x0014E2DC File Offset: 0x0014C4DC
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 945f)
			{
				this.HBJJOCHGOPH = 1598f;
			}
			this.FAIFBBGFAIB().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("settings_bindings_sec_", this.UseFinalGlassColor);
			this.LPPEPKGFOEM().SetFloat(".lastCheckpoint.lives", this.Fade);
			this.KLKILLCHJHO().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat("Please define the RectTransform for the Center viewport of the scrollable area", this.GlassDistortion);
			this.KLKILLCHJHO().SetFloat(" ", this.GlassAberration);
			this.ADGHJOHKEHG().SetColor("CameraFilterPack/Distortion_Lens", this.GlassesColor);
			this.BFGNMFCNDBC().SetColor("[Sound Manager] Audio clip is null, cannot play music", this.GlassesColor2);
			this.BFGNMFCNDBC().SetColor("Skipping EstablishEncryption. Protocol is secure.", this.GlassColor);
			this.IONHGBPGCHK().SetFloat("DPADHOR", this.UseScanLineSize);
			this.OGMEGHKECAH().SetFloat("Stream did not contain properly formatted byte array", this.UseScanLine);
			this.ELBMIEOIABA().SetTexture(" or player:", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043C0 RID: 17344 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043C1 RID: 17345 RVA: 0x0014E448 File Offset: 0x0014C648
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Glasses_On7") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060043C2 RID: 17346 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043C3 RID: 17347 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043C4 RID: 17348 RVA: 0x0014E481 File Offset: 0x0014C681
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("#") as Texture2D);
		this.SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060043C5 RID: 17349 RVA: 0x0014E4BC File Offset: 0x0014C6BC
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1311f)
			{
				this.HBJJOCHGOPH = 1596f;
			}
			this.OKJOKHGJHGF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("BadgeText", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] Starting game from: ", this.Fade);
			this.BFGNMFCNDBC().SetFloat("HitVariationSlider", this.VisionBlur);
			this.EFMCNLELMDO().SetFloat("_Visualize", this.GlassDistortion);
			this.OKJOKHGJHGF().SetFloat("_MainTex2", this.GlassAberration);
			this.OKJOKHGJHGF().SetColor("_Blue_R", this.GlassesColor);
			this.LPMLLJKMAMP().SetColor("CameraFilterPack/Gradients_Desert", this.GlassesColor2);
			this.BFGNMFCNDBC().SetColor(".jpg", this.GlassColor);
			this.PLBEJJIHFPB().SetFloat("checkpoint", this.UseScanLineSize);
			this.PLBEJJIHFPB().SetFloat("maps.", this.UseScanLine);
			this.HJGEHJDMCGI().SetTexture("_Value5", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043C6 RID: 17350 RVA: 0x0014E628 File Offset: 0x0014C828
	private void HAIAHJPCPAG()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043C7 RID: 17351 RVA: 0x0014E664 File Offset: 0x0014C864
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1249f)
			{
				this.HBJJOCHGOPH = 1378f;
			}
			this.OJMHIMIPKME().SetFloat("file://", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("HPToggle", this.UseFinalGlassColor);
			this.EFMCNLELMDO().SetFloat("menu.selectedmode", this.Fade);
			this.KLKILLCHJHO().SetFloat("_ColoredChange", this.VisionBlur);
			this.ELBMIEOIABA().SetFloat("Tab1Content", this.GlassDistortion);
			this.ADAFMBOGPLN().SetFloat("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("_History2ChromaTex", this.GlassesColor);
			this.LPMLLJKMAMP().SetColor("_VelTex", this.GlassesColor2);
			this.LPPEPKGFOEM().SetColor("achievements.21.progress", this.GlassColor);
			this.OGMEGHKECAH().SetFloat("y", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture("Tab1Content", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043C8 RID: 17352 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060043C9 RID: 17353 RVA: 0x0014E7D0 File Offset: 0x0014C9D0
	private void LFAFJKJAEEL()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060043CA RID: 17354 RVA: 0x0014E809 File Offset: 0x0014CA09
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("ACCEPT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060043CB RID: 17355 RVA: 0x0014E842 File Offset: 0x0014CA42
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043CC RID: 17356 RVA: 0x0014E879 File Offset: 0x0014CA79
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043CD RID: 17357 RVA: 0x0014E8B0 File Offset: 0x0014CAB0
	private void HDMDKOKOOJC()
	{
		this.FPHEBLMINDA = (Resources.Load("Player Disconnected") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043CE RID: 17358 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043CF RID: 17359 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043D0 RID: 17360 RVA: 0x0014E8EC File Offset: 0x0014CAEC
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1750f)
			{
				this.HBJJOCHGOPH = 1437f;
			}
			this.OKJOKHGJHGF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Noise_TV_2", this.UseFinalGlassColor);
			this.FAIFBBGFAIB().SetFloat("Hidden/ScreenSpaceReflection", this.Fade);
			this.FAIFBBGFAIB().SetFloat("value", this.VisionBlur);
			this.HJGEHJDMCGI().SetFloat("...", this.GlassDistortion);
			this.ADGHJOHKEHG().SetFloat("[PlayerController] ", this.GlassAberration);
			this.OGMEGHKECAH().SetColor("maps.", this.GlassesColor);
			this.LPPEPKGFOEM().SetColor("The process failed: ", this.GlassesColor2);
			this.MFHPKGICPIO().SetColor("VHS", this.GlassColor);
			this.PLBEJJIHFPB().SetFloat("Object ID. Case-Sensitive", this.UseScanLineSize);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.UseScanLine);
			this.EFMCNLELMDO().SetTexture("randomdrop", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043D1 RID: 17361 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060043D2 RID: 17362 RVA: 0x0014EA58 File Offset: 0x0014CC58
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 472f)
			{
				this.HBJJOCHGOPH = 506f;
			}
			this.ADGHJOHKEHG().SetFloat("Adreno", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("skin.no_hit", this.UseFinalGlassColor);
			this.IONHGBPGCHK().SetFloat("true", this.Fade);
			this.LPPEPKGFOEM().SetFloat("BadgeText", this.VisionBlur);
			this.PLBEJJIHFPB().SetFloat("_Speed", this.GlassDistortion);
			this.OGMEGHKECAH().SetFloat("id", this.GlassAberration);
			this.HJGEHJDMCGI().SetColor("value", this.GlassesColor);
			this.IONHGBPGCHK().SetColor("UseFinalGlassColor", this.GlassesColor2);
			this.PLBEJJIHFPB().SetColor("_TimeX", this.GlassColor);
			this.LMLENGFLEBD().SetFloat("_TimeX", this.UseScanLineSize);
			this.ADAFMBOGPLN().SetFloat("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", this.UseScanLine);
			this.PLBEJJIHFPB().SetTexture("CameraFilterPack/FX_Glitch2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043D3 RID: 17363 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x060043D4 RID: 17364 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x060043D5 RID: 17365 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x060043D6 RID: 17366 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043D7 RID: 17367 RVA: 0x0014EBC4 File Offset: 0x0014CDC4
	private void DOFDGBGEDFI()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Colors_BleachBypass") as Texture2D);
		this.SCShader = Shader.Find("PlayerBase_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060043D8 RID: 17368 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043D9 RID: 17369 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060043DA RID: 17370 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043DB RID: 17371 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043DC RID: 17372 RVA: 0x0014EBFD File Offset: 0x0014CDFD
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("SettingsCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043DD RID: 17373 RVA: 0x0014EC38 File Offset: 0x0014CE38
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 848f)
			{
				this.HBJJOCHGOPH = 1467f;
			}
			this.NBPKMLMCHFN.SetFloat("Item ", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("SetSatelliteLerpSpeed", this.UseFinalGlassColor);
			this.LMLENGFLEBD().SetFloat("CameraFilterPack/Vision_Warp", this.Fade);
			this.LPPEPKGFOEM().SetFloat("0,7,true,0", this.VisionBlur);
			this.HJGEHJDMCGI().SetFloat("ItemNameText", this.GlassDistortion);
			this.OGMEGHKECAH().SetFloat("ExitButton", this.GlassAberration);
			this.ADGHJOHKEHG().SetColor("Keypad", this.GlassesColor);
			this.KLKILLCHJHO().SetColor("Data/Skins/", this.GlassesColor2);
			this.IIJMIPBMMBF().SetColor(".", this.GlassColor);
			this.BFGNMFCNDBC().SetFloat("settings.enablerankingnotifications", this.UseScanLineSize);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.UseScanLine);
			this.IIJMIPBMMBF().SetTexture("\\n", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043DE RID: 17374 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043DF RID: 17375 RVA: 0x0014EDA4 File Offset: 0x0014CFA4
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 440f)
			{
				this.HBJJOCHGOPH = 219f;
			}
			this.ADGHJOHKEHG().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("_ScreenResolution", this.UseFinalGlassColor);
			this.BFGNMFCNDBC().SetFloat("Emergency Help:", this.Fade);
			this.OGMEGHKECAH().SetFloat("_Near", this.VisionBlur);
			this.ADGHJOHKEHG().SetFloat(".mp3", this.GlassDistortion);
			this.LMLENGFLEBD().SetFloat("_SpawnHeuristic", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("_ScreenResolution", this.GlassesColor);
			this.IIJMIPBMMBF().SetColor("ControllerRightY", this.GlassesColor2);
			this.BFGNMFCNDBC().SetColor("Deleted event", this.GlassColor);
			this.KLKILLCHJHO().SetFloat("_ScreenResolution", this.UseScanLineSize);
			this.EFMCNLELMDO().SetFloat("IconImage", this.UseScanLine);
			this.IIJMIPBMMBF().SetTexture("_Intensity", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043E0 RID: 17376 RVA: 0x0014EF10 File Offset: 0x0014D110
	private void DPLLKHHLDBB()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor/") as Texture2D);
		this.SCShader = Shader.Find("End index must in an integer.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043E1 RID: 17377 RVA: 0x0014EF49 File Offset: 0x0014D149
	private void IDJKNBDKHBD()
	{
		this.FPHEBLMINDA = (Resources.Load("_Distortion") as Texture2D);
		this.SCShader = Shader.Find("Reload Steam Inventory");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043E2 RID: 17378 RVA: 0x0014EF82 File Offset: 0x0014D182
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043E3 RID: 17379 RVA: 0x0014EFB9 File Offset: 0x0014D1B9
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043E4 RID: 17380 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x0014EFF0 File Offset: 0x0014D1F0
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043E7 RID: 17383 RVA: 0x0014F027 File Offset: 0x0014D227
	private void AEMGPJDJGBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("Set Particles Color") as Texture2D);
		this.SCShader = Shader.Find("LastNewsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x0014F060 File Offset: 0x0014D260
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x0014F098 File Offset: 0x0014D298
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 589f)
			{
				this.HBJJOCHGOPH = 956f;
			}
			this.OGMEGHKECAH().SetFloat("#scoresubmitionfailed: ", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("[GameEvent] Exeption:", this.UseFinalGlassColor);
			this.LPMLLJKMAMP().SetFloat("Left", this.Fade);
			this.EFMCNLELMDO().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", this.VisionBlur);
			this.IONHGBPGCHK().SetFloat("_ScreenResolution", this.GlassDistortion);
			this.ADGHJOHKEHG().SetFloat("DPADHOR", this.GlassAberration);
			this.LPPEPKGFOEM().SetColor("_ColorR", this.GlassesColor);
			this.ADAFMBOGPLN().SetColor("_ScreenResolution", this.GlassesColor2);
			this.KLKILLCHJHO().SetColor("menutheme.coldheat", this.GlassColor);
			this.ELBMIEOIABA().SetFloat("SetTrailZoomSpeed", this.UseScanLineSize);
			this.FAIFBBGFAIB().SetFloat("GridDataArcs", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("_RangeScale", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043EA RID: 17386 RVA: 0x0014F204 File Offset: 0x0014D404
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("Health Stats") as Texture2D);
		this.SCShader = Shader.Find("\" on viewID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060043EB RID: 17387 RVA: 0x0014F23D File Offset: 0x0014D43D
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("[LevelEditorScene] Updated");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043EC RID: 17388 RVA: 0x0014F278 File Offset: 0x0014D478
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1670f)
			{
				this.HBJJOCHGOPH = 1133f;
			}
			this.OJMHIMIPKME().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("DataText", this.UseFinalGlassColor);
			this.BFGNMFCNDBC().SetFloat("Floating point textures aren't supported on this device ({0})", this.Fade);
			this.OJMHIMIPKME().SetFloat("Run a command for data system", this.VisionBlur);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.GlassDistortion);
			this.ADAFMBOGPLN().SetFloat("_Green_G", this.GlassAberration);
			this.LPMLLJKMAMP().SetColor(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.GlassesColor);
			this.OGMEGHKECAH().SetColor("_FarCamera", this.GlassesColor2);
			this.FAIFBBGFAIB().SetColor("Player Connected", this.GlassColor);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.UseScanLineSize);
			this.LPPEPKGFOEM().SetFloat("_Blood", this.UseScanLine);
			this.ELBMIEOIABA().SetTexture("'{0}' \t{1}ms \t{2}", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043ED RID: 17389 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043EE RID: 17390 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043EF RID: 17391 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060043F0 RID: 17392 RVA: 0x0014F3E4 File Offset: 0x0014D5E4
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1762f)
			{
				this.HBJJOCHGOPH = 222f;
			}
			this.MFHPKGICPIO().SetFloat("[DiscordController] Responding no to Ask to Join request", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("_Value3", this.UseFinalGlassColor);
			this.HJGEHJDMCGI().SetFloat("CameraFilterPack/Blur_Focus", this.Fade);
			this.ADAFMBOGPLN().SetFloat("{", this.VisionBlur);
			this.FAIFBBGFAIB().SetFloat("_Value", this.GlassDistortion);
			this.IONHGBPGCHK().SetFloat("{\"items\":", this.GlassAberration);
			this.OGMEGHKECAH().SetColor("_Value", this.GlassesColor);
			this.ELBMIEOIABA().SetColor("Messages (shift+tab)", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("_Value8", this.GlassColor);
			this.ADGHJOHKEHG().SetFloat(".completedMaps", this.UseScanLineSize);
			this.IONHGBPGCHK().SetFloat("#no", this.UseScanLine);
			this.PLBEJJIHFPB().SetTexture("_Threshhold", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043F1 RID: 17393 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x060043F2 RID: 17394 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043F3 RID: 17395 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060043F4 RID: 17396 RVA: 0x0014F550 File Offset: 0x0014D750
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

	// Token: 0x060043F5 RID: 17397 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043F6 RID: 17398 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043F7 RID: 17399 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043F8 RID: 17400 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043F9 RID: 17401 RVA: 0x0014F588 File Offset: 0x0014D788
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 408f)
			{
				this.HBJJOCHGOPH = 824f;
			}
			this.KLKILLCHJHO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("player.mysteryitem", this.UseFinalGlassColor);
			this.KLKILLCHJHO().SetFloat("owner: ", this.Fade);
			this.KLKILLCHJHO().SetFloat("CameraFilterPack/Drawing_Manga5", this.VisionBlur);
			this.OJMHIMIPKME().SetFloat("_Value4", this.GlassDistortion);
			this.LPMLLJKMAMP().SetFloat("_Value", this.GlassAberration);
			this.IONHGBPGCHK().SetColor("SetSatelliteInput", this.GlassesColor);
			this.FAIFBBGFAIB().SetColor("stats on", this.GlassesColor2);
			this.IIJMIPBMMBF().SetColor("#alreadyexist", this.GlassColor);
			this.ADAFMBOGPLN().SetFloat("CameraFilterPack/TV_Old_Movie", this.UseScanLineSize);
			this.MFHPKGICPIO().SetFloat("_Intensity", this.UseScanLine);
			this.KLKILLCHJHO().SetTexture("ERROR: preview file name is empty in modName.workshop.json", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060043FA RID: 17402 RVA: 0x0014F6F4 File Offset: 0x0014D8F4
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060043FB RID: 17403 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043FC RID: 17404 RVA: 0x0014F72B File Offset: 0x0014D92B
	private void IGPCNCJIEOJ()
	{
		this.FPHEBLMINDA = (Resources.Load(".") as Texture2D);
		this.SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060043FE RID: 17406 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060043FF RID: 17407 RVA: 0x0014E842 File Offset: 0x0014CA42
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004400 RID: 17408 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004401 RID: 17409 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06004402 RID: 17410 RVA: 0x0014F764 File Offset: 0x0014D964
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 833f)
			{
				this.HBJJOCHGOPH = 290f;
			}
			this.HJGEHJDMCGI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_History1LumaTex", this.UseFinalGlassColor);
			this.IIJMIPBMMBF().SetFloat("menu.playedpage", this.Fade);
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack/Gradients_Therma", this.VisionBlur);
			this.MFHPKGICPIO().SetFloat("y", this.GlassDistortion);
			this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this.GlassAberration);
			this.OGMEGHKECAH().SetColor("_Blend", this.GlassesColor);
			this.ELBMIEOIABA().SetColor("z", this.GlassesColor2);
			this.KLKILLCHJHO().SetColor("[", this.GlassColor);
			this.ADAFMBOGPLN().SetFloat("settings.arcshitsoundtimedelay", this.UseScanLineSize);
			this.BFGNMFCNDBC().SetFloat("_ScreenResolution", this.UseScanLine);
			this.ELBMIEOIABA().SetTexture("Submition failed", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004403 RID: 17411 RVA: 0x0014F8D0 File Offset: 0x0014DAD0
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1057f)
			{
				this.HBJJOCHGOPH = 670f;
			}
			this.OJMHIMIPKME().SetFloat(" SecondsBeforeRespawn: ", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("_MainTex2", this.UseFinalGlassColor);
			this.OJMHIMIPKME().SetFloat("ticket", this.Fade);
			this.EFMCNLELMDO().SetFloat("_Value4", this.VisionBlur);
			this.LMLENGFLEBD().SetFloat("Joined Room. isMasterClient: ", this.GlassDistortion);
			this.OJMHIMIPKME().SetFloat("_TimeX", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("_Value4", this.GlassesColor);
			this.IIJMIPBMMBF().SetColor("_TimeX", this.GlassesColor2);
			this.FAIFBBGFAIB().SetColor("BadgeText", this.GlassColor);
			this.ADGHJOHKEHG().SetFloat("Triangle", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("maps.", this.UseScanLine);
			this.HJGEHJDMCGI().SetTexture("Folk", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004404 RID: 17412 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06004405 RID: 17413 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004406 RID: 17414 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06004407 RID: 17415 RVA: 0x0014FA3C File Offset: 0x0014DC3C
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004408 RID: 17416 RVA: 0x0014FA74 File Offset: 0x0014DC74
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 16f)
			{
				this.HBJJOCHGOPH = 1225f;
			}
			this.LPMLLJKMAMP().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("_VignettingColor", this.UseFinalGlassColor);
			this.LPPEPKGFOEM().SetFloat("0", this.Fade);
			this.LPPEPKGFOEM().SetFloat("/Segment-[Up]", this.VisionBlur);
			this.LMLENGFLEBD().SetFloat("Result for ", this.GlassDistortion);
			this.ADGHJOHKEHG().SetFloat("restrictions\n\n#until: ", this.GlassAberration);
			this.ADAFMBOGPLN().SetColor("CameraFilterPack/Distortion_Wave_Horizontal", this.GlassesColor);
			this.ELBMIEOIABA().SetColor("steamid", this.GlassesColor2);
			this.OJMHIMIPKME().SetColor("couldn't be found!", this.GlassColor);
			this.OJMHIMIPKME().SetFloat("InventoryButton", this.UseScanLineSize);
			this.IONHGBPGCHK().SetFloat("settings.fps", this.UseScanLine);
			this.KLKILLCHJHO().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004409 RID: 17417 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600440A RID: 17418 RVA: 0x0014FBE0 File Offset: 0x0014DDE0
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 579f;
			}
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("_TimeX", this.UseFinalGlassColor);
			this.OKJOKHGJHGF().SetFloat("value", this.Fade);
			this.IIJMIPBMMBF().SetFloat("[Left]", this.VisionBlur);
			this.ELBMIEOIABA().SetFloat("CheckCombo", this.GlassDistortion);
			this.LPPEPKGFOEM().SetFloat(":\n", this.GlassAberration);
			this.EFMCNLELMDO().SetColor("maps.", this.GlassesColor);
			this.LMLENGFLEBD().SetColor("_Value", this.GlassesColor2);
			this.IIJMIPBMMBF().SetColor("#alreadyexist", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("InfoCanvas", this.UseScanLineSize);
			this.LPPEPKGFOEM().SetFloat("CameraFilterPack/Gradients_NeonGradient", this.UseScanLine);
			this.OGMEGHKECAH().SetTexture("SetPosition", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x0600440C RID: 17420 RVA: 0x0014FD4C File Offset: 0x0014DF4C
	private void MDNHCLKNCLE()
	{
		this.FPHEBLMINDA = (Resources.Load("#no") as Texture2D);
		this.SCShader = Shader.Find("Run a command for the Localization Servise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600440D RID: 17421 RVA: 0x0014FD85 File Offset: 0x0014DF85
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("USE_UV_BASED_REPROJECTION") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600440E RID: 17422 RVA: 0x0014FDC0 File Offset: 0x0014DFC0
	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1157f)
			{
				this.HBJJOCHGOPH = 1289f;
			}
			this.IIJMIPBMMBF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat(".lastCheckpoint.time", this.UseFinalGlassColor);
			this.FAIFBBGFAIB().SetFloat(".wav", this.Fade);
			this.LMLENGFLEBD().SetFloat("_TimeX", this.VisionBlur);
			this.OKJOKHGJHGF().SetFloat("_Value6", this.GlassDistortion);
			this.FAIFBBGFAIB().SetFloat("_TimeX", this.GlassAberration);
			this.OJMHIMIPKME().SetColor("1427616858", this.GlassesColor);
			this.ADAFMBOGPLN().SetColor("[DiscordController] Init", this.GlassesColor2);
			this.BFGNMFCNDBC().SetColor("DISTORT", this.GlassColor);
			this.ELBMIEOIABA().SetFloat("_Offsets", this.UseScanLineSize);
			this.OKJOKHGJHGF().SetFloat("ItemNameText", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture(":\n", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600440F RID: 17423 RVA: 0x0014FF2C File Offset: 0x0014E12C
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1241f)
			{
				this.HBJJOCHGOPH = 1579f;
			}
			this.LMLENGFLEBD().SetFloat("_VignettingColor", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_Distortion", this.UseFinalGlassColor);
			this.IIJMIPBMMBF().SetFloat("menu.relaxinfo", this.Fade);
			this.LMLENGFLEBD().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.VisionBlur);
			this.ADGHJOHKEHG().SetFloat(". Check if the server is available.", this.GlassDistortion);
			this.PLBEJJIHFPB().SetFloat("_Distortion", this.GlassAberration);
			this.ADGHJOHKEHG().SetColor("ViewMenu", this.GlassesColor);
			this.KLKILLCHJHO().SetColor("restrictions\n\n#until: ", this.GlassesColor2);
			this.OJMHIMIPKME().SetColor("error", this.GlassColor);
			this.OGMEGHKECAH().SetFloat(" but this PhotonView does not exist! View was/is ours.", this.UseScanLineSize);
			this.ELBMIEOIABA().SetFloat("_Threshhold", this.UseScanLine);
			this.KLKILLCHJHO().SetTexture("SetParticlesParticleSize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004410 RID: 17424 RVA: 0x00150098 File Offset: 0x0014E298
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 38f)
			{
				this.HBJJOCHGOPH = 440f;
			}
			this.IONHGBPGCHK().SetFloat("resetall", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("offsets", this.UseFinalGlassColor);
			this.LPPEPKGFOEM().SetFloat("<color=#", this.Fade);
			this.OKJOKHGJHGF().SetFloat("status", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat("Vertical", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", this.GlassAberration);
			this.ADAFMBOGPLN().SetColor("_Min", this.GlassesColor);
			this.LMLENGFLEBD().SetColor("offsets", this.GlassesColor2);
			this.ADGHJOHKEHG().SetColor("_Value7", this.GlassColor);
			this.OGMEGHKECAH().SetFloat("_TimeX", this.UseScanLineSize);
			this.ELBMIEOIABA().SetFloat("_Value3", this.UseScanLine);
			this.EFMCNLELMDO().SetTexture("UseFinalGlassColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004411 RID: 17425 RVA: 0x00150204 File Offset: 0x0014E404
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004412 RID: 17426 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06004413 RID: 17427 RVA: 0x0015023C File Offset: 0x0014E43C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 183f)
			{
				this.HBJJOCHGOPH = 384f;
			}
			this.PLBEJJIHFPB().SetFloat("settings.arcsnohitsoundtimedelay", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("_Offsets", this.UseFinalGlassColor);
			this.LPMLLJKMAMP().SetFloat("_LutTex", this.Fade);
			this.OGMEGHKECAH().SetFloat(" isInactive: ", this.VisionBlur);
			this.LPMLLJKMAMP().SetFloat("B:", this.GlassDistortion);
			this.PLBEJJIHFPB().SetFloat("_EdgeSize", this.GlassAberration);
			this.MFHPKGICPIO().SetColor("ready", this.GlassesColor);
			this.EFMCNLELMDO().SetColor("error", this.GlassesColor2);
			this.IIJMIPBMMBF().SetColor("/?page=ranks", this.GlassColor);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/Sharpen_Sharpen", this.UseScanLineSize);
			this.BFGNMFCNDBC().SetFloat("_Value", this.UseScanLine);
			this.OGMEGHKECAH().SetTexture("Tab1Content", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004414 RID: 17428 RVA: 0x001503A8 File Offset: 0x0014E5A8
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 707f)
			{
				this.HBJJOCHGOPH = 1352f;
			}
			this.OJMHIMIPKME().SetFloat("#useticket", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Blend2Camera_VividLight", this.UseFinalGlassColor);
			this.LPMLLJKMAMP().SetFloat("Set satellite clockwise rotattion speed", this.Fade);
			this.NBPKMLMCHFN.SetFloat("1.87", this.VisionBlur);
			this.KLKILLCHJHO().SetFloat("/Assets/MyImage", this.GlassDistortion);
			this.MFHPKGICPIO().SetFloat("(scene)", this.GlassAberration);
			this.BFGNMFCNDBC().SetColor("_BaseTex", this.GlassesColor);
			this.LPMLLJKMAMP().SetColor("PhotonServerSettings", this.GlassesColor2);
			this.MFHPKGICPIO().SetColor("G:", this.GlassColor);
			this.HJGEHJDMCGI().SetFloat("masterSteamID", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("PLEASE WAIT", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("Right", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004415 RID: 17429 RVA: 0x00150514 File Offset: 0x0014E714
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1615f)
			{
				this.HBJJOCHGOPH = 9f;
			}
			this.MFHPKGICPIO().SetFloat("PhotonView with ID ", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("SetSunMinSize", this.UseFinalGlassColor);
			this.IIJMIPBMMBF().SetFloat("\0\0", this.Fade);
			this.KLKILLCHJHO().SetFloat("0.00", this.VisionBlur);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/Color_RGB", this.GlassDistortion);
			this.LPMLLJKMAMP().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", this.GlassAberration);
			this.OJMHIMIPKME().SetColor("_ScreenResolution", this.GlassesColor);
			this.OJMHIMIPKME().SetColor("_MainTex", this.GlassesColor2);
			this.OGMEGHKECAH().SetColor("_Value3", this.GlassColor);
			this.ELBMIEOIABA().SetFloat("_VelocityTex", this.UseScanLineSize);
			this.ELBMIEOIABA().SetFloat("fade in duration", this.UseScanLine);
			this.OJMHIMIPKME().SetTexture("SaveButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004416 RID: 17430 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004417 RID: 17431 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06004418 RID: 17432 RVA: 0x00150680 File Offset: 0x0014E880
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1273f)
			{
				this.HBJJOCHGOPH = 729f;
			}
			this.OJMHIMIPKME().SetFloat("restrictions\n\n#until: ", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("#91CCFF", this.UseFinalGlassColor);
			this.IONHGBPGCHK().SetFloat("Status: ", this.Fade);
			this.ELBMIEOIABA().SetFloat("_ScreenResolution", this.VisionBlur);
			this.LPMLLJKMAMP().SetFloat("MapEnd", this.GlassDistortion);
			this.ADGHJOHKEHG().SetFloat("ItemsCountText", this.GlassAberration);
			this.LMLENGFLEBD().SetColor("WARNING: rotation axis set to 0 on ", this.GlassesColor);
			this.IONHGBPGCHK().SetColor("{0:0}", this.GlassesColor2);
			this.ELBMIEOIABA().SetColor("_ScreenResolution", this.GlassColor);
			this.LPPEPKGFOEM().SetFloat("Cross", this.UseScanLineSize);
			this.MFHPKGICPIO().SetFloat("ticket", this.UseScanLine);
			this.IONHGBPGCHK().SetTexture("PLEASE WAIT", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004419 RID: 17433 RVA: 0x001507EC File Offset: 0x0014E9EC
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600441A RID: 17434 RVA: 0x00150823 File Offset: 0x0014EA23
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("skin.") as Texture2D);
		this.SCShader = Shader.Find("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600441B RID: 17435 RVA: 0x0015085C File Offset: 0x0014EA5C
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("bpmgrid") as Texture2D);
		this.SCShader = Shader.Find("_DX11NoiseTime");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600441C RID: 17436 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600441D RID: 17437 RVA: 0x00150895 File Offset: 0x0014EA95
	private void MJEFMIPLFAB()
	{
		this.FPHEBLMINDA = (Resources.Load("player.blackcat") as Texture2D);
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600441E RID: 17438 RVA: 0x001508D0 File Offset: 0x0014EAD0
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 143f;
			}
			this.BFGNMFCNDBC().SetFloat("offsets", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat(" has no method \"", this.UseFinalGlassColor);
			this.LPMLLJKMAMP().SetFloat("IntraTime", this.Fade);
			this.OKJOKHGJHGF().SetFloat("_Value3", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("grid", this.GlassDistortion);
			this.BFGNMFCNDBC().SetFloat("settings.enableranking", this.GlassAberration);
			this.PLBEJJIHFPB().SetColor("[NetworkMenu] Joining ", this.GlassesColor);
			this.BFGNMFCNDBC().SetColor("CameraFilterPack/Drawing_Paper2", this.GlassesColor2);
			this.LPPEPKGFOEM().SetColor("Set Sun MaxSize", this.GlassColor);
			this.ADAFMBOGPLN().SetFloat("maps.", this.UseScanLineSize);
			this.IONHGBPGCHK().SetFloat("Attempting to remove texture that was not allocated: {0}", this.UseScanLine);
			this.OGMEGHKECAH().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600441F RID: 17439 RVA: 0x00150A3C File Offset: 0x0014EC3C
	private void COOHIILCOCO()
	{
		this.FPHEBLMINDA = (Resources.Load("_Bloom2") as Texture2D);
		this.SCShader = Shader.Find("Data/Editor/leveltemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004421 RID: 17441 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06004422 RID: 17442 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004423 RID: 17443 RVA: 0x00150B35 File Offset: 0x0014ED35
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004424 RID: 17444 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004425 RID: 17445 RVA: 0x00150B6C File Offset: 0x0014ED6C
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004426 RID: 17446 RVA: 0x00150BA4 File Offset: 0x0014EDA4
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1473f)
			{
				this.HBJJOCHGOPH = 526f;
			}
			this.KLKILLCHJHO().SetFloat("(\\[ */ *b *\\])", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("checkpoint", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("New SaveGame", this.Fade);
			this.PLBEJJIHFPB().SetFloat(": ", this.VisionBlur);
			this.BFGNMFCNDBC().SetFloat("Joystick1Button2", this.GlassDistortion);
			this.MFHPKGICPIO().SetFloat("0,1,true,0", this.GlassAberration);
			this.IONHGBPGCHK().SetColor("PunSupportLogger", this.GlassesColor);
			this.FAIFBBGFAIB().SetColor(".lastCheckpoint.correctScore", this.GlassesColor2);
			this.ADGHJOHKEHG().SetColor("CameraFilterPack/Sharpen_Sharpen", this.GlassColor);
			this.ELBMIEOIABA().SetFloat("score", this.UseScanLineSize);
			this.HJGEHJDMCGI().SetFloat(".", this.UseScanLine);
			this.IIJMIPBMMBF().SetTexture("deletemap", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004427 RID: 17447 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004428 RID: 17448 RVA: 0x00150D10 File Offset: 0x0014EF10
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004429 RID: 17449 RVA: 0x00150D48 File Offset: 0x0014EF48
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

	// Token: 0x0600442A RID: 17450 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x0600442B RID: 17451 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600442C RID: 17452 RVA: 0x00150EB4 File Offset: 0x0014F0B4
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600442D RID: 17453 RVA: 0x00150EEC File Offset: 0x0014F0EC
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 897f)
			{
				this.HBJJOCHGOPH = 943f;
			}
			this.ADGHJOHKEHG().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("#mapalreadyexistupdate", this.UseFinalGlassColor);
			this.EFMCNLELMDO().SetFloat("visible", this.Fade);
			this.HJGEHJDMCGI().SetFloat("/", this.VisionBlur);
			this.HJGEHJDMCGI().SetFloat("_DistortionSize", this.GlassDistortion);
			this.IIJMIPBMMBF().SetFloat("_Value2", this.GlassAberration);
			this.OKJOKHGJHGF().SetColor("Set satellite radius (offset)", this.GlassesColor);
			this.ADAFMBOGPLN().SetColor("???", this.GlassesColor2);
			this.ADGHJOHKEHG().SetColor("{", this.GlassColor);
			this.LPPEPKGFOEM().SetFloat("_ScreenResolution", this.UseScanLineSize);
			this.IIJMIPBMMBF().SetFloat("_LensDirt", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture("Loss ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600442E RID: 17454 RVA: 0x00151058 File Offset: 0x0014F258
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 601f)
			{
				this.HBJJOCHGOPH = 1066f;
			}
			this.PLBEJJIHFPB().SetFloat("float,0", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("blue", this.UseFinalGlassColor);
			this.MFHPKGICPIO().SetFloat("_TimeX", this.Fade);
			this.FAIFBBGFAIB().SetFloat("Bad parameters for getbool! Use <key> <value>", this.VisionBlur);
			this.OJMHIMIPKME().SetFloat("_TimeX", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat("float,0.5", this.GlassAberration);
			this.LPPEPKGFOEM().SetColor("_Alpha", this.GlassesColor);
			this.LPPEPKGFOEM().SetColor("_ScreenResolution", this.GlassesColor2);
			this.IIJMIPBMMBF().SetColor(". Should be just one?", this.GlassColor);
			this.ADGHJOHKEHG().SetFloat(". Calling ConnectToRegionMaster() is: ", this.UseScanLineSize);
			this.ELBMIEOIABA().SetFloat("Joystick1Button6", this.UseScanLine);
			this.OJMHIMIPKME().SetTexture("hardcoreinfo", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600442F RID: 17455 RVA: 0x001511C4 File Offset: 0x0014F3C4
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004430 RID: 17456 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004431 RID: 17457 RVA: 0x001511FB File Offset: 0x0014F3FB
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004432 RID: 17458 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06004433 RID: 17459 RVA: 0x0014D8A1 File Offset: 0x0014BAA1
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004434 RID: 17460 RVA: 0x00151234 File Offset: 0x0014F434
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 813f)
			{
				this.HBJJOCHGOPH = 373f;
			}
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("_ScreenResolution", this.UseFinalGlassColor);
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.Fade);
			this.EFMCNLELMDO().SetFloat("PenaltyScoreText", this.VisionBlur);
			this.PLBEJJIHFPB().SetFloat("bool", this.GlassDistortion);
			this.PLBEJJIHFPB().SetFloat("_Value", this.GlassAberration);
			this.LMLENGFLEBD().SetColor("[PlayerController] ", this.GlassesColor);
			this.LPMLLJKMAMP().SetColor("IconImage", this.GlassesColor2);
			this.ELBMIEOIABA().SetColor("_TimeX", this.GlassColor);
			this.MFHPKGICPIO().SetFloat("Beat Detected", this.UseScanLineSize);
			this.BFGNMFCNDBC().SetFloat("_PColor2", this.UseScanLine);
			this.MFHPKGICPIO().SetTexture("Left Stick Click", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000738 RID: 1848
	public Shader SCShader;

	// Token: 0x04000739 RID: 1849
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400073A RID: 1850
	[Range(0f, 1f)]
	public float Fade = 0.2f;

	// Token: 0x0400073B RID: 1851
	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	// Token: 0x0400073C RID: 1852
	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	// Token: 0x0400073D RID: 1853
	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.45f, 0.25f);

	// Token: 0x0400073E RID: 1854
	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	// Token: 0x0400073F RID: 1855
	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	// Token: 0x04000740 RID: 1856
	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	// Token: 0x04000741 RID: 1857
	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	// Token: 0x04000742 RID: 1858
	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	// Token: 0x04000743 RID: 1859
	public Color GlassColor = new Color(1f, 0.9f, 0f, 1f);

	// Token: 0x04000744 RID: 1860
	private Material BJFKDHHMLJH;

	// Token: 0x04000745 RID: 1861
	private Texture2D FPHEBLMINDA;
}
