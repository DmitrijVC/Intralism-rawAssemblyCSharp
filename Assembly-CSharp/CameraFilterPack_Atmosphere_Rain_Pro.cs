using System;
using UnityEngine;

// Token: 0x02000036 RID: 54
[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Rain_Pro : MonoBehaviour
{
	// Token: 0x06000E5A RID: 3674 RVA: 0x00064A46 File Offset: 0x00062C46
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00064A64 File Offset: 0x00062C64
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1731f)
			{
				this.HBJJOCHGOPH = 1107f;
			}
			this.KEMAALEODNH().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_Color2", this.Fade);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack_Paper3", this.Intensity);
			this.LONNIJMNKFB().SetFloat("0.00", this.DirectionX);
			this.ABHDNGIHBKE().SetFloat("#,0", this.Speed);
			this.HHIFMIPPMPF().SetFloat("rarity", this.Size);
			this.KAFBNOBOIAJ().SetFloat("_Value7", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("RequestOwnership(): ", this.StormFlashOnOff);
			this.LDNADDJMIPK().SetFloat("menu.playedsolo", this.DropOnOff);
			this.HNICHJCGJOC().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1082f, 541f));
			this.KEMAALEODNH().SetTexture("[DiscordController] Init", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00064BD1 File Offset: 0x00062DD1
	private void JONGNKNLLND()
	{
		this.FPHEBLMINDA = (Resources.Load("_EmissionColor") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00064C0A File Offset: 0x00062E0A
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00064C41 File Offset: 0x00062E41
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

	// Token: 0x06000E5F RID: 3679 RVA: 0x00064C78 File Offset: 0x00062E78
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load("Netw. Sim.") as Texture2D);
		this.SCShader = Shader.Find("GraphicsQualitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00064A46 File Offset: 0x00062C46
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00064CB4 File Offset: 0x00062EB4
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1556f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.NBPKMLMCHFN.SetFloat("Set Satellite Radius", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_EdgeThresholdMin", this.Fade);
			this.EMDFHOKEGNG().SetFloat("_Value", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.DirectionX);
			this.ABHDNGIHBKE().SetFloat("GroupNameText", this.Speed);
			this.KAFBNOBOIAJ().SetFloat("SetSunMaxSize", this.Size);
			this.ABHDNGIHBKE().SetFloat("Left Stick Click", this.Distortion);
			this.LONNIJMNKFB().SetFloat("settings.disablestoryboard", this.StormFlashOnOff);
			this.KGOLDDBHIFN().SetFloat("_History4ChromaTex", this.DropOnOff);
			this.LONNIJMNKFB().SetVector("BloodAlternative1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1723f, 1267f));
			this.IIJMIPBMMBF().SetTexture("Protocol switch from: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00064E24 File Offset: 0x00063024
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1816f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			this.JLHLHKPHDFO().SetFloat("D-Pad Down", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("player.xp", this.Fade);
			this.DNLMFEGJJDD().SetFloat("\r", this.Intensity);
			this.HHIFMIPPMPF().SetFloat("yes", this.DirectionX);
			this.OLHDPICFBOF().SetFloat(" at ", this.Speed);
			this.EMDFHOKEGNG().SetFloat("ResourceIDInputField", this.Size);
			this.IIJMIPBMMBF().SetFloat("float,1", this.Distortion);
			this.LDNADDJMIPK().SetFloat("\" error: ", this.StormFlashOnOff);
			this.JLHLHKPHDFO().SetFloat("\\", this.DropOnOff);
			this.NBPKMLMCHFN.SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1129f, 1050f));
			this.EMDFHOKEGNG().SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00064F94 File Offset: 0x00063194
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1623f)
			{
				this.HBJJOCHGOPH = 1630f;
			}
			this.LDNADDJMIPK().SetFloat("FinalScoreText", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat(" SecondsBeforeRespawn: ", this.Fade);
			this.HHIFMIPPMPF().SetFloat(". The RPC has been ignored.", this.Intensity);
			this.KEMAALEODNH().SetFloat("id", this.DirectionX);
			this.LDNADDJMIPK().SetFloat("_Value3", this.Speed);
			this.IIJMIPBMMBF().SetFloat("/", this.Size);
			this.JLHLHKPHDFO().SetFloat("#checkpoint", this.Distortion);
			this.EMDFHOKEGNG().SetFloat("workshop.", this.StormFlashOnOff);
			this.HHIFMIPPMPF().SetFloat("SetEnvSpriteColor", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("SetSunSensitivity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1394f, 728f));
			this.DNLMFEGJJDD().SetTexture("ok", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00065104 File Offset: 0x00063304
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 248f)
			{
				this.HBJJOCHGOPH = 786f;
			}
			this.EMDFHOKEGNG().SetFloat("Reload Maps", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("BitsData", this.Fade);
			this.KEMAALEODNH().SetFloat("[SERVER] Player ", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("fade out duration", this.DirectionX);
			this.KAFBNOBOIAJ().SetFloat("_Value3", this.Speed);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.Size);
			this.LONNIJMNKFB().SetFloat("FileMenu", this.Distortion);
			this.LDNADDJMIPK().SetFloat("_Value11", this.StormFlashOnOff);
			this.OLHDPICFBOF().SetFloat("_Amount", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("SetPlayerDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 235f, 911f));
			this.LDNADDJMIPK().SetTexture("Operation ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00065274 File Offset: 0x00063474
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1547f)
			{
				this.HBJJOCHGOPH = 1634f;
			}
			this.KGOLDDBHIFN().SetFloat("PopulateMapsList", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("UseScanLine", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("_Near", this.DirectionX);
			this.DNLMFEGJJDD().SetFloat(".r", this.Speed);
			this.DKKBFFHBHJE().SetFloat("workshop.", this.Size);
			this.IIJMIPBMMBF().SetFloat("#activechallenges", this.Distortion);
			this.JLHLHKPHDFO().SetFloat("other.dust1", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("Right Stick Click", this.DropOnOff);
			this.IIJMIPBMMBF().SetVector("<b>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1725f, 351f));
			this.KEMAALEODNH().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x000653E4 File Offset: 0x000635E4
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1099f)
			{
				this.HBJJOCHGOPH = 1137f;
			}
			this.JLHLHKPHDFO().SetFloat("offline room", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("[ResourcesManager] Load audio error: ", this.Fade);
			this.NBPKMLMCHFN.SetFloat("X", this.Intensity);
			this.HNICHJCGJOC().SetFloat("_BgFade", this.DirectionX);
			this.HNICHJCGJOC().SetFloat("StartTime already set: ", this.Speed);
			this.KEMAALEODNH().SetFloat("StartButton", this.Size);
			this.HNICHJCGJOC().SetFloat("settings.customdataskin", this.Distortion);
			this.KEMAALEODNH().SetFloat("_Value2", this.StormFlashOnOff);
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.DropOnOff);
			this.KAFBNOBOIAJ().SetVector("[EditorEvent] Exception: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 648f, 1437f));
			this.NBPKMLMCHFN.SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00065554 File Offset: 0x00063754
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 403f)
			{
				this.HBJJOCHGOPH = 1047f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value5", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_Visualize", this.Fade);
			this.KEMAALEODNH().SetFloat("settings.arcshitsoundtimedelay", this.Intensity);
			this.OLHDPICFBOF().SetFloat("Menu", this.DirectionX);
			this.KEMAALEODNH().SetFloat("LevelNameInputField", this.Speed);
			this.KAFBNOBOIAJ().SetFloat(". Prefab must have a PhotonView component.", this.Size);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/BlurHole", this.Distortion);
			this.DKKBFFHBHJE().SetFloat("/", this.StormFlashOnOff);
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/Oculus_NightVision1", this.DropOnOff);
			this.KAFBNOBOIAJ().SetVector("RecieveChatActionMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1446f, 434f));
			this.KAFBNOBOIAJ().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x000656C1 File Offset: 0x000638C1
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("colorA") as Texture2D);
		this.SCShader = Shader.Find("Please specify a map name or buildID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x000656FC File Offset: 0x000638FC
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 530f)
			{
				this.HBJJOCHGOPH = 1237f;
			}
			this.LDNADDJMIPK().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("RecieveChatActionMessage", this.Fade);
			this.LDNADDJMIPK().SetFloat("DPADVER", this.Intensity);
			this.LDNADDJMIPK().SetFloat(",", this.DirectionX);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Color_Contrast", this.Speed);
			this.KEMAALEODNH().SetFloat("\r", this.Size);
			this.LDNADDJMIPK().SetFloat("_Value2", this.Distortion);
			this.HHIFMIPPMPF().SetFloat(": ", this.StormFlashOnOff);
			this.IIJMIPBMMBF().SetFloat("_Value1", this.DropOnOff);
			this.IIJMIPBMMBF().SetVector("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1195f, 133f));
			this.EMDFHOKEGNG().SetTexture("Cannot remove cached RPCs on a PhotonView thats not ours! ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00065869 File Offset: 0x00063A69
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x000658A4 File Offset: 0x00063AA4
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1976f)
			{
				this.HBJJOCHGOPH = 1741f;
			}
			this.HNICHJCGJOC().SetFloat("CameraFilterPack/EXTRA_Rotation", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("...", this.Fade);
			this.EMDFHOKEGNG().SetFloat("_Value", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("_Skybox", this.DirectionX);
			this.LDNADDJMIPK().SetFloat("_Vignette", this.Speed);
			this.ABHDNGIHBKE().SetFloat(": ", this.Size);
			this.EMDFHOKEGNG().SetFloat("<size=24>", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("/icon", this.StormFlashOnOff);
			this.KGOLDDBHIFN().SetFloat("settings.shaders.bloomintencity", this.DropOnOff);
			this.DKKBFFHBHJE().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1954f, 276f));
			this.IIJMIPBMMBF().SetTexture(".png", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x00065A11 File Offset: 0x00063C11
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain_Pro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00065A4C File Offset: 0x00063C4C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1430f)
			{
				this.HBJJOCHGOPH = 1502f;
			}
			this.HNICHJCGJOC().SetFloat("D-Pad Up", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("n/a", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("Mouse", this.DirectionX);
			this.HNICHJCGJOC().SetFloat("menu.enableselectormusic", this.Speed);
			this.KEMAALEODNH().SetFloat("}", this.Size);
			this.EMDFHOKEGNG().SetFloat("Zoom speed. Base 1.5", this.Distortion);
			this.KEMAALEODNH().SetFloat("_Value2", this.StormFlashOnOff);
			this.DNLMFEGJJDD().SetFloat("Malformed RPC; this should never occur. Content: ", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("_dec.json", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 283f, 459f));
			this.DKKBFFHBHJE().SetTexture("float,1.5", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00065BB9 File Offset: 0x00063DB9
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("Sending vacant view IDs. Length: ") as Texture2D);
		this.SCShader = Shader.Find("PossibleMapMaxScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00065C6A File Offset: 0x00063E6A
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("SetBGColor") as Texture2D);
		this.SCShader = Shader.Find(" Owner called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00065CA3 File Offset: 0x00063EA3
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x00064A46 File Offset: 0x00062C46
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00065CDC File Offset: 0x00063EDC
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1596f)
			{
				this.HBJJOCHGOPH = 1465f;
			}
			this.HNICHJCGJOC().SetFloat("ready", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("offsets", this.Fade);
			this.IIJMIPBMMBF().SetFloat("--------------------------------", this.Intensity);
			this.JLHLHKPHDFO().SetFloat("_Contrast", this.DirectionX);
			this.ABHDNGIHBKE().SetFloat("Keypad", this.Speed);
			this.JLHLHKPHDFO().SetFloat("note.4", this.Size);
			this.OLHDPICFBOF().SetFloat("_Glow", this.Distortion);
			this.DKKBFFHBHJE().SetFloat("keys", this.StormFlashOnOff);
			this.KAFBNOBOIAJ().SetFloat("TestMapButton", this.DropOnOff);
			this.LONNIJMNKFB().SetVector("CameraFilterPack_Glasses_On3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1662f, 75f));
			this.KEMAALEODNH().SetTexture("LostLive", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00065E4C File Offset: 0x0006404C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1005f)
			{
				this.HBJJOCHGOPH = 539f;
			}
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Colors_Brightness", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.Fade);
			this.LONNIJMNKFB().SetFloat("_History3ChromaTex", this.Intensity);
			this.DKKBFFHBHJE().SetFloat("_ProjectionInv", this.DirectionX);
			this.DKKBFFHBHJE().SetFloat("menutheme.deleted", this.Speed);
			this.OLHDPICFBOF().SetFloat("_Value5", this.Size);
			this.OLHDPICFBOF().SetFloat(".lastCheckpoint.powerupsScore", this.Distortion);
			this.KGOLDDBHIFN().SetFloat("skin.", this.StormFlashOnOff);
			this.LDNADDJMIPK().SetFloat(" - StoreAuthURLResponse] - ", this.DropOnOff);
			this.KEMAALEODNH().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 351f, 474f));
			this.OLHDPICFBOF().SetTexture("settings.enablehitsoundsinnormal", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00065FB9 File Offset: 0x000641B9
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00065FF0 File Offset: 0x000641F0
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("Print the list of scenes, avalable in game.") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x0006602C File Offset: 0x0006422C
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1808f)
			{
				this.HBJJOCHGOPH = 1527f;
			}
			this.JLHLHKPHDFO().SetFloat("No peer to communicate with. ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("[MapEditor] Prepairing map editor...", this.Fade);
			this.IIJMIPBMMBF().SetFloat("_Offsets", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("_ReflectionTexture3", this.DirectionX);
			this.DNLMFEGJJDD().SetFloat("_FarCamera", this.Speed);
			this.JLHLHKPHDFO().SetFloat("green", this.Size);
			this.ABHDNGIHBKE().SetFloat("AddEnvironmentSprite", this.Distortion);
			this.LDNADDJMIPK().SetFloat("FinalScoreSmallText", this.StormFlashOnOff);
			this.KAFBNOBOIAJ().SetFloat("traffic", this.DropOnOff);
			this.JLHLHKPHDFO().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 361f, 468f));
			this.KEMAALEODNH().SetTexture("_TileTexDebug", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x0006619C File Offset: 0x0006439C
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1655f)
			{
				this.HBJJOCHGOPH = 1809f;
			}
			this.LDNADDJMIPK().SetFloat("MenuPlayButton", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("challenges.", this.Fade);
			this.JLHLHKPHDFO().SetFloat("CameraFilterPack/FX_Hypno", this.Intensity);
			this.KEMAALEODNH().SetFloat("_Value", this.DirectionX);
			this.DKKBFFHBHJE().SetFloat("_TimeX", this.Speed);
			this.JLHLHKPHDFO().SetFloat("/../", this.Size);
			this.KGOLDDBHIFN().SetFloat("Editor/", this.Distortion);
			this.KAFBNOBOIAJ().SetFloat("[SERVER] Player ", this.StormFlashOnOff);
			this.IIJMIPBMMBF().SetFloat("EnvironmentSlider", this.DropOnOff);
			this.DNLMFEGJJDD().SetVector("a minute ago", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 824f, 431f));
			this.IIJMIPBMMBF().SetTexture("CameraFilterPack/Gradients_Desert", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00064A46 File Offset: 0x00062C46
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x0006630C File Offset: 0x0006450C
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 941f)
			{
				this.HBJJOCHGOPH = 1286f;
			}
			this.LDNADDJMIPK().SetFloat("Avoid using this directly. Thanks.", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("Added event", this.Fade);
			this.LDNADDJMIPK().SetFloat("EventTimeInputField", this.Intensity);
			this.OLHDPICFBOF().SetFloat("settings.volume.sfx", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat("Rotate environment object to the rotation", this.Speed);
			this.LONNIJMNKFB().SetFloat("MessageText", this.Size);
			this.IIJMIPBMMBF().SetFloat("Left Stick Click", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("_color", this.StormFlashOnOff);
			this.EMDFHOKEGNG().SetFloat("VHS", this.DropOnOff);
			this.EMDFHOKEGNG().SetVector("settings.hitvariation", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 145f, 1584f));
			this.OLHDPICFBOF().SetTexture(":", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00064A46 File Offset: 0x00062C46
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00066479 File Offset: 0x00064679
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x000664B0 File Offset: 0x000646B0
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 797f)
			{
				this.HBJJOCHGOPH = 335f;
			}
			this.ABHDNGIHBKE().SetFloat("[PlayerBase] Config error: musicTime <= 0", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("event", this.Fade);
			this.DNLMFEGJJDD().SetFloat("null", this.Intensity);
			this.OLHDPICFBOF().SetFloat("_Distortion", this.DirectionX);
			this.DNLMFEGJJDD().SetFloat("_MainTex2", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Size);
			this.ABHDNGIHBKE().SetFloat("SupportLogger ", this.Distortion);
			this.JLHLHKPHDFO().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", this.StormFlashOnOff);
			this.DKKBFFHBHJE().SetFloat(".", this.DropOnOff);
			this.KGOLDDBHIFN().SetVector("settings.enablehitsoundsinrelax", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 381f, 1534f));
			this.LDNADDJMIPK().SetTexture("bad", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0006661D File Offset: 0x0006481D
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00066654 File Offset: 0x00064854
	private void HDMDKOKOOJC()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/TV_50") as Texture2D);
		this.SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x0006668D File Offset: 0x0006488D
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x000666C4 File Offset: 0x000648C4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("_Value8", this.DropOnOff);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00066834 File Offset: 0x00064A34
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1281f)
			{
				this.HBJJOCHGOPH = 88f;
			}
			this.KAFBNOBOIAJ().SetFloat("{0:0} day{1}, ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("/Segment-[Up]", this.Fade);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.Intensity);
			this.DKKBFFHBHJE().SetFloat("_Value4", this.DirectionX);
			this.IIJMIPBMMBF().SetFloat("#md5submitionfailed: ", this.Speed);
			this.JLHLHKPHDFO().SetFloat("mapselector.orderby", this.Size);
			this.HHIFMIPPMPF().SetFloat("_Red_C", this.Distortion);
			this.LONNIJMNKFB().SetFloat("_Value3", this.StormFlashOnOff);
			this.LONNIJMNKFB().SetFloat("_Value", this.DropOnOff);
			this.KEMAALEODNH().SetVector("EnableRankingToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 1982f));
			this.KGOLDDBHIFN().SetTexture("kick", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00064A46 File Offset: 0x00062C46
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x000669A4 File Offset: 0x00064BA4
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1090f)
			{
				this.HBJJOCHGOPH = 1285f;
			}
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("#combo", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_TexelOffsetScale", this.Intensity);
			this.LDNADDJMIPK().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", this.DirectionX);
			this.JLHLHKPHDFO().SetFloat("_Intensity", this.Speed);
			this.DKKBFFHBHJE().SetFloat("_Value4", this.Size);
			this.KEMAALEODNH().SetFloat("STICKRHOR", this.Distortion);
			this.OLHDPICFBOF().SetFloat("#combo", this.StormFlashOnOff);
			this.LONNIJMNKFB().SetFloat("<color=#{0}>{1}</color>", this.DropOnOff);
			this.HNICHJCGJOC().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 480f, 1064f));
			this.DNLMFEGJJDD().SetTexture("LevelInfoInputField", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00066B11 File Offset: 0x00064D11
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00066B48 File Offset: 0x00064D48
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00064A46 File Offset: 0x00062C46
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00066B7F File Offset: 0x00064D7F
	private void DBEMDAJDDDA()
	{
		this.FPHEBLMINDA = (Resources.Load("achievements.26.progress") as Texture2D);
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00066BB8 File Offset: 0x00064DB8
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00064A46 File Offset: 0x00062C46
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00066BEF File Offset: 0x00064DEF
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00064A46 File Offset: 0x00062C46
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x00066C26 File Offset: 0x00064E26
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("Object ID. Case-Sensitive") as Texture2D);
		this.SCShader = Shader.Find("AccuracyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x00066C60 File Offset: 0x00064E60
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 466f)
			{
				this.HBJJOCHGOPH = 1793f;
			}
			this.IIJMIPBMMBF().SetFloat("player.goldlollipop", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Color_Convert_Normal", this.Fade);
			this.LDNADDJMIPK().SetFloat(" ", this.Intensity);
			this.LDNADDJMIPK().SetFloat("_PrevViewProj", this.DirectionX);
			this.OLHDPICFBOF().SetFloat("\n", this.Speed);
			this.KGOLDDBHIFN().SetFloat("Need to specify a start index and end index.", this.Size);
			this.JLHLHKPHDFO().SetFloat("id", this.Distortion);
			this.LONNIJMNKFB().SetFloat("nogamesfound", this.StormFlashOnOff);
			this.LONNIJMNKFB().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", this.DropOnOff);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Glasses_On", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1096f, 1864f));
			this.HNICHJCGJOC().SetTexture("_Amount", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00066DCD File Offset: 0x00064FCD
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00066E04 File Offset: 0x00065004
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 860f)
			{
				this.HBJJOCHGOPH = 1123f;
			}
			this.NBPKMLMCHFN.SetFloat("FullscreenToggle", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("_TimeX", this.Fade);
			this.DKKBFFHBHJE().SetFloat("[Up-Right-Down-Left]", this.Intensity);
			this.DKKBFFHBHJE().SetFloat("...", this.DirectionX);
			this.ABHDNGIHBKE().SetFloat(".lastCheckpoint.incorrectScore", this.Speed);
			this.ABHDNGIHBKE().SetFloat("PointsScoreText", this.Size);
			this.ABHDNGIHBKE().SetFloat("achievements.21.completed.", this.Distortion);
			this.OLHDPICFBOF().SetFloat("_CenterX", this.StormFlashOnOff);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.DropOnOff);
			this.LDNADDJMIPK().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1297f, 229f));
			this.KAFBNOBOIAJ().SetTexture("settings.volume.editor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00066F74 File Offset: 0x00065174
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1030f)
			{
				this.HBJJOCHGOPH = 1670f;
			}
			this.DKKBFFHBHJE().SetFloat("setfloat", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("achievements.21.completed.", this.Fade);
			this.HNICHJCGJOC().SetFloat("Set Arcs Speed", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat(" registered.", this.DirectionX);
			this.HNICHJCGJOC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.Speed);
			this.HNICHJCGJOC().SetFloat("SetParent", this.Size);
			this.HNICHJCGJOC().SetFloat("PublishMapButton", this.Distortion);
			this.ABHDNGIHBKE().SetFloat("[MapsData] Key ", this.StormFlashOnOff);
			this.LONNIJMNKFB().SetFloat("InfoCanvas", this.DropOnOff);
			this.HHIFMIPPMPF().SetVector("[NetworkManager] Join failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1099f, 598f));
			this.LDNADDJMIPK().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x000670E1 File Offset: 0x000652E1
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("_Shadow") as Texture2D);
		this.SCShader = Shader.Find("_BlendTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x0006711C File Offset: 0x0006531C
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1722f)
			{
				this.HBJJOCHGOPH = 1055f;
			}
			this.LONNIJMNKFB().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_Value10", this.Fade);
			this.KEMAALEODNH().SetFloat("SpawnObj", this.Intensity);
			this.DNLMFEGJJDD().SetFloat("OPEN FILE", this.DirectionX);
			this.LONNIJMNKFB().SetFloat("0.00", this.Speed);
			this.HHIFMIPPMPF().SetFloat("TotalHitsScoreText", this.Size);
			this.JLHLHKPHDFO().SetFloat("_Value5", this.Distortion);
			this.HNICHJCGJOC().SetFloat("loadscene", this.StormFlashOnOff);
			this.DKKBFFHBHJE().SetFloat("_Value", this.DropOnOff);
			this.JLHLHKPHDFO().SetVector("_Red_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 551f, 438f));
			this.LDNADDJMIPK().SetTexture("NameText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00067289 File Offset: 0x00065489
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x000672C0 File Offset: 0x000654C0
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 280f)
			{
				this.HBJJOCHGOPH = 437f;
			}
			this.JLHLHKPHDFO().SetFloat("settings.volume.game", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("FullscreenToggle", this.Fade);
			this.HNICHJCGJOC().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", this.Intensity);
			this.DNLMFEGJJDD().SetFloat("player.egglipszerotwo", this.DirectionX);
			this.HHIFMIPPMPF().SetFloat("Protocol switch from: ", this.Speed);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/Blur_Bloom", this.Size);
			this.NBPKMLMCHFN.SetFloat("Edited event", this.Distortion);
			this.IIJMIPBMMBF().SetFloat("Down ", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("Error: I/O Failure! :(", this.DropOnOff);
			this.OLHDPICFBOF().SetVector("[Down]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 594f, 5f));
			this.JLHLHKPHDFO().SetTexture("[Left]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x0006742D File Offset: 0x0006562D
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00064A46 File Offset: 0x00062C46
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00067464 File Offset: 0x00065664
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 616f)
			{
				this.HBJJOCHGOPH = 164f;
			}
			this.HHIFMIPPMPF().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("|", this.Fade);
			this.ABHDNGIHBKE().SetFloat("Joystick1Button8", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(" - ", this.DirectionX);
			this.DKKBFFHBHJE().SetFloat("_SSAO", this.Speed);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Size);
			this.JLHLHKPHDFO().SetFloat("\r", this.Distortion);
			this.HNICHJCGJOC().SetFloat("JoystickButton13", this.StormFlashOnOff);
			this.DNLMFEGJJDD().SetFloat("Jul", this.DropOnOff);
			this.NBPKMLMCHFN.SetVector("Jan", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 552f));
			this.LDNADDJMIPK().SetTexture("HighScaleShot", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00064A46 File Offset: 0x00062C46
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x000675D1 File Offset: 0x000657D1
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Colors_Brightness") as Texture2D);
		this.SCShader = Shader.Find("Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00064A46 File Offset: 0x00062C46
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x0006760C File Offset: 0x0006580C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 254f)
			{
				this.HBJJOCHGOPH = 124f;
			}
			this.HHIFMIPPMPF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("#ok", this.Fade);
			this.LDNADDJMIPK().SetFloat("_FarCamera", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("[PlayerController] ", this.DirectionX);
			this.JLHLHKPHDFO().SetFloat("Status: ", this.Speed);
			this.KAFBNOBOIAJ().SetFloat("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", this.Size);
			this.HHIFMIPPMPF().SetFloat("_Value4", this.Distortion);
			this.JLHLHKPHDFO().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.StormFlashOnOff);
			this.LDNADDJMIPK().SetFloat("Overlay", this.DropOnOff);
			this.HNICHJCGJOC().SetVector("_Bullet_2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 799f, 1992f));
			this.IIJMIPBMMBF().SetTexture("received</b>\n#reason: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00064A46 File Offset: 0x00062C46
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00067779 File Offset: 0x00065979
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400020C RID: 524
	public Shader SCShader;

	// Token: 0x0400020D RID: 525
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400020E RID: 526
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400020F RID: 527
	private Material BJFKDHHMLJH;

	// Token: 0x04000210 RID: 528
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000211 RID: 529
	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	// Token: 0x04000212 RID: 530
	[Range(-0.25f, 0.25f)]
	public float DirectionX = 0.12f;

	// Token: 0x04000213 RID: 531
	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	// Token: 0x04000214 RID: 532
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x04000215 RID: 533
	[Range(0f, 0.5f)]
	public float Distortion = 0.025f;

	// Token: 0x04000216 RID: 534
	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	// Token: 0x04000217 RID: 535
	[Range(0f, 1f)]
	public float DropOnOff = 1f;

	// Token: 0x04000218 RID: 536
	private Texture2D FPHEBLMINDA;
}
