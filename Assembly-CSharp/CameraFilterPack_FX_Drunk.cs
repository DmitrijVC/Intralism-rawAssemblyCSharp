using System;
using UnityEngine;

// Token: 0x020000C4 RID: 196
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Drunk")]
public class CameraFilterPack_FX_Drunk : MonoBehaviour
{
	// Token: 0x06003AF1 RID: 15089 RVA: 0x001299B1 File Offset: 0x00127BB1
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x001299E8 File Offset: 0x00127BE8
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

	// Token: 0x06003AF3 RID: 15091 RVA: 0x00129A1F File Offset: 0x00127C1F
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AF4 RID: 15092 RVA: 0x00129A43 File Offset: 0x00127C43
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AF5 RID: 15093 RVA: 0x00129A67 File Offset: 0x00127C67
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AF6 RID: 15094 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003AF7 RID: 15095 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003AF8 RID: 15096 RVA: 0x00129AA0 File Offset: 0x00127CA0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1423f)
			{
				this.HBJJOCHGOPH = 1747f;
			}
			this.NBPKMLMCHFN.SetFloat(": ", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("gamemode", this.Value);
			this.BFGNMFCNDBC().SetFloat("[MapEditor] Openning ", this.Speed);
			this.HCGJCMDJPGD().SetFloat("[Right-Left]", this.Distortion);
			this.KBOPGONOCNP().SetFloat("Tab2Content", this.DistortionWave);
			this.KEMJNOMIPHN().SetFloat("-", this.Wavy);
			this.KBOPGONOCNP().SetFloat("_Value", this.Fade);
			this.NFMGLIKNOOC().SetFloat(" not exist", this.ColoredChange);
			this.KEMJNOMIPHN().SetFloat("_Value2", this.ChangeRed);
			this.OKJOKHGJHGF().SetFloat("SetSatelliteColor", this.ChangeGreen);
			this.LNLKMDPHDCC().SetFloat("_ScreenResolution", this.ChangeBlue);
			this.OCHJIMJNEMO().SetFloat("catched: ", this.ColoredSaturate);
			this.HKGAONMOBMH().SetVector("1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1453f, 140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AF9 RID: 15097 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06003AFA RID: 15098 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06003AFB RID: 15099 RVA: 0x00129C39 File Offset: 0x00127E39
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AFC RID: 15100 RVA: 0x00129C70 File Offset: 0x00127E70
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1522f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.NLFJGMBCICG().SetFloat("Fill", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("RarityImage", this.Value);
			this.MFHPKGICPIO().SetFloat("_Offsets", this.Speed);
			this.LNLKMDPHDCC().SetFloat("Object ID. Case-Sensitive", this.Distortion);
			this.EPCGJFCCAFH().SetFloat("/", this.DistortionWave);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/3D_Scan_Scene", this.Wavy);
			this.LPCHMEKDCHI().SetFloat(": ", this.Fade);
			this.NBPKMLMCHFN.SetFloat(" ", this.ColoredChange);
			this.LNLKMDPHDCC().SetFloat("RT", this.ChangeRed);
			this.HKGAONMOBMH().SetFloat("_MainTex", this.ChangeGreen);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.ChangeBlue);
			this.DONENAMLFLF().SetFloat("FPSToggle", this.ColoredSaturate);
			this.NFMGLIKNOOC().SetVector("_Radius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1433f, 853f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AFD RID: 15101 RVA: 0x00129E09 File Offset: 0x00128009
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AFE RID: 15102 RVA: 0x00129E26 File Offset: 0x00128026
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("SetBGColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AFF RID: 15103 RVA: 0x00129E4A File Offset: 0x0012804A
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B00 RID: 15104 RVA: 0x00129E09 File Offset: 0x00128009
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B01 RID: 15105 RVA: 0x00129E81 File Offset: 0x00128081
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x00129EA5 File Offset: 0x001280A5
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x00129EDC File Offset: 0x001280DC
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x00129F00 File Offset: 0x00128100
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B05 RID: 15109 RVA: 0x00129EDC File Offset: 0x001280DC
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B06 RID: 15110 RVA: 0x00129F37 File Offset: 0x00128137
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B07 RID: 15111 RVA: 0x00129F6E File Offset: 0x0012816E
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003B08 RID: 15112 RVA: 0x00129F92 File Offset: 0x00128192
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B09 RID: 15113 RVA: 0x00129E09 File Offset: 0x00128009
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B0A RID: 15114 RVA: 0x00129FB8 File Offset: 0x001281B8
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1764f)
			{
				this.HBJJOCHGOPH = 385f;
			}
			this.OCHJIMJNEMO().SetFloat("Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("EnableRankedNotificationsToggle", this.Value);
			this.IGKFMCPDNOI().SetFloat("_Value2", this.Speed);
			this.EHDJJANLINB().SetFloat("CameraFilterPack/Edge_Golden", this.Distortion);
			this.OKJOKHGJHGF().SetFloat("ShineEffect", this.DistortionWave);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Wavy);
			this.BFGNMFCNDBC().SetFloat("_HdrParams", this.Fade);
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/TV_Rgb", this.ColoredChange);
			this.EPCGJFCCAFH().SetFloat("[PlayerBase] Loaded spawner data", this.ChangeRed);
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.ChangeGreen);
			this.OCHJIMJNEMO().SetFloat("_Bloom5", this.ChangeBlue);
			this.OLHDPICFBOF().SetFloat("_ScreenResolution", this.ColoredSaturate);
			this.OCHJIMJNEMO().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 538f, 1272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B0B RID: 15115 RVA: 0x0012A151 File Offset: 0x00128351
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B0C RID: 15116 RVA: 0x0012A188 File Offset: 0x00128388
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("SupportLogger OnCreatedRoom(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B0D RID: 15117 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06003B0E RID: 15118 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06003B0F RID: 15119 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06003B10 RID: 15120 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06003B11 RID: 15121 RVA: 0x0012A1AC File Offset: 0x001283AC
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B12 RID: 15122 RVA: 0x0012A1D0 File Offset: 0x001283D0
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 710f)
			{
				this.HBJJOCHGOPH = 650f;
			}
			this.IGKFMCPDNOI().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Color_Sepia", this.Value);
			this.PDEAHJPOMEF().SetFloat(" [", this.Speed);
			this.IGKFMCPDNOI().SetFloat("_BlurredColor", this.Distortion);
			this.KBOPGONOCNP().SetFloat("DPADHOR", this.DistortionWave);
			this.OKJOKHGJHGF().SetFloat("_BlendTex", this.Wavy);
			this.IGKFMCPDNOI().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Fade);
			this.HCGJCMDJPGD().SetFloat(" Kb", this.ColoredChange);
			this.OKJOKHGJHGF().SetFloat("Editor/", this.ChangeRed);
			this.OCHJIMJNEMO().SetFloat("_TimeX", this.ChangeGreen);
			this.IGKFMCPDNOI().SetFloat("Horizontal", this.ChangeBlue);
			this.DONENAMLFLF().SetFloat("_Value4", this.ColoredSaturate);
			this.EPCGJFCCAFH().SetVector("Items", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 305f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B13 RID: 15123 RVA: 0x0012A369 File Offset: 0x00128569
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("LevelConfigButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x0012A390 File Offset: 0x00128590
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1314f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.PLBEJJIHFPB().SetFloat("OPEN", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("Joystick1Button", this.Value);
			this.PDEAHJPOMEF().SetFloat("closed", this.Speed);
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Colors_Threshold", this.Distortion);
			this.PDEAHJPOMEF().SetFloat("id", this.DistortionWave);
			this.PLBEJJIHFPB().SetFloat("SingleplayerButton", this.Wavy);
			this.KBOPGONOCNP().SetFloat("color", this.Fade);
			this.NLFJGMBCICG().SetFloat("LevelEditor/CustomEventEditor-Text", this.ColoredChange);
			this.NLFJGMBCICG().SetFloat(": ", this.ChangeRed);
			this.LNLKMDPHDCC().SetFloat("_Value2", this.ChangeGreen);
			this.LNLKMDPHDCC().SetFloat(" not exist", this.ChangeBlue);
			this.EPCGJFCCAFH().SetFloat("The other scroll rect doesnt support scrolling horizontally", this.ColoredSaturate);
			this.LPCHMEKDCHI().SetVector("CurrentTimeLabel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1039f, 1093f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B15 RID: 15125 RVA: 0x0012A529 File Offset: 0x00128729
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("#submit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B16 RID: 15126 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06003B17 RID: 15127 RVA: 0x0012A550 File Offset: 0x00128750
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1003f)
			{
				this.HBJJOCHGOPH = 1352f;
			}
			this.MFHPKGICPIO().SetFloat("_Parasite", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_ScreenResolution", this.Value);
			this.EHDJJANLINB().SetFloat("Set camera background color", this.Speed);
			this.LENEJAGLCNL().SetFloat("SpectatingUserInfo", this.Distortion);
			this.LNLKMDPHDCC().SetFloat("_Value", this.DistortionWave);
			this.KBOPGONOCNP().SetFloat("_MainTex2", this.Wavy);
			this.OKJOKHGJHGF().SetFloat("[PlayerController] ", this.Fade);
			this.KEMJNOMIPHN().SetFloat("DPADHOR", this.ColoredChange);
			this.IIJMIPBMMBF().SetFloat("_Value11", this.ChangeRed);
			this.OKJOKHGJHGF().SetFloat("_History1LumaTex", this.ChangeGreen);
			this.BLMPMOIDGMG().SetFloat(",", this.ChangeBlue);
			this.OKJOKHGJHGF().SetFloat(" = ", this.ColoredSaturate);
			this.MFHPKGICPIO().SetVector("[", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1862f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B18 RID: 15128 RVA: 0x0012A6EC File Offset: 0x001288EC
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1728f)
			{
				this.HBJJOCHGOPH = 555f;
			}
			this.MFHPKGICPIO().SetFloat("masterSteamID", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("curScn", this.Value);
			this.MFHPKGICPIO().SetFloat("_Colored", this.Speed);
			this.PLBEJJIHFPB().SetFloat("SetSatelliteTrailWidth", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("buttons", this.DistortionWave);
			this.LPCHMEKDCHI().SetFloat("sounds/hit_perfect", this.Wavy);
			this.IGKFMCPDNOI().SetFloat("_TimeX", this.Fade);
			this.IGKFMCPDNOI().SetFloat("TotalTimeLabel", this.ColoredChange);
			this.NLFJGMBCICG().SetFloat("0,2,true,0", this.ChangeRed);
			this.NFMGLIKNOOC().SetFloat("Item ", this.ChangeGreen);
			this.PDEAHJPOMEF().SetFloat("Current xp: ", this.ChangeBlue);
			this.KEMJNOMIPHN().SetFloat("note.4", this.ColoredSaturate);
			this.OKJOKHGJHGF().SetVector("input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 862f, 1208f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x0012A888 File Offset: 0x00128A88
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 409f)
			{
				this.HBJJOCHGOPH = 1572f;
			}
			this.IIJMIPBMMBF().SetFloat("Folk", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("settings.fps", this.Value);
			this.LENEJAGLCNL().SetFloat("New SaveGame", this.Speed);
			this.OCHJIMJNEMO().SetFloat("AskForPickupItemSpawnTimes", this.Distortion);
			this.NFMGLIKNOOC().SetFloat("Sep", this.DistortionWave);
			this.IGKFMCPDNOI().SetFloat(" ownership transfered to: ", this.Wavy);
			this.LPCHMEKDCHI().SetFloat("Hidden/ScreenSpaceReflection", this.Fade);
			this.HKGAONMOBMH().SetFloat("Hello World, is my item a clone? [", this.ColoredChange);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/TV_Chromatical", this.ChangeRed);
			this.EPCGJFCCAFH().SetFloat("challenges.", this.ChangeGreen);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.ChangeBlue);
			this.NLFJGMBCICG().SetFloat("_Visualize", this.ColoredSaturate);
			this.NBPKMLMCHFN.SetVector("EVENT CONFIG [Ctrl+E]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1962f, 490f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B1A RID: 15130 RVA: 0x0012AA21 File Offset: 0x00128C21
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x0012AA58 File Offset: 0x00128C58
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B1C RID: 15132 RVA: 0x0012AA8F File Offset: 0x00128C8F
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06003B1E RID: 15134 RVA: 0x0012AAC6 File Offset: 0x00128CC6
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B1F RID: 15135 RVA: 0x00129E09 File Offset: 0x00128009
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B20 RID: 15136 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06003B21 RID: 15137 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06003B22 RID: 15138 RVA: 0x0012AB00 File Offset: 0x00128D00
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 668f)
			{
				this.HBJJOCHGOPH = 1382f;
			}
			this.NLFJGMBCICG().SetFloat("?", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("DPADVER", this.Value);
			this.BFGNMFCNDBC().SetFloat("STICKLHOR", this.Speed);
			this.NFMGLIKNOOC().SetFloat("LevelProgressBar", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("BitsData", this.DistortionWave);
			this.HCGJCMDJPGD().SetFloat("]", this.Wavy);
			this.NFMGLIKNOOC().SetFloat("Horizontal", this.Fade);
			this.OCHJIMJNEMO().SetFloat("_Value2", this.ColoredChange);
			this.PDEAHJPOMEF().SetFloat("settings.cameramovements", this.ChangeRed);
			this.OLHDPICFBOF().SetFloat("_DistortionSize", this.ChangeGreen);
			this.PDEAHJPOMEF().SetFloat("File not found: {0}", this.ChangeBlue);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Drawing_EnhancedComics", this.ColoredSaturate);
			this.BFGNMFCNDBC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 640f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B23 RID: 15139 RVA: 0x00129E09 File Offset: 0x00128009
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B24 RID: 15140 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003B25 RID: 15141 RVA: 0x0012AC99 File Offset: 0x00128E99
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B26 RID: 15142 RVA: 0x0012ACD0 File Offset: 0x00128ED0
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06003B28 RID: 15144 RVA: 0x0012ACF4 File Offset: 0x00128EF4
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Drunk");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B29 RID: 15145 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06003B2A RID: 15146 RVA: 0x00129E09 File Offset: 0x00128009
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B2C RID: 15148 RVA: 0x0012AD6D File Offset: 0x00128F6D
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B2D RID: 15149 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06003B2E RID: 15150 RVA: 0x00129E09 File Offset: 0x00128009
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B2F RID: 15151 RVA: 0x0012ADA4 File Offset: 0x00128FA4
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B30 RID: 15152 RVA: 0x0012ADDB File Offset: 0x00128FDB
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B31 RID: 15153 RVA: 0x00129E09 File Offset: 0x00128009
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B32 RID: 15154 RVA: 0x0012AE14 File Offset: 0x00129014
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1772f)
			{
				this.HBJJOCHGOPH = 1425f;
			}
			this.IGKFMCPDNOI().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_Value", this.Value);
			this.EPCGJFCCAFH().SetFloat("_Scale", this.Speed);
			this.MFHPKGICPIO().SetFloat("file://", this.Distortion);
			this.BLMPMOIDGMG().SetFloat("ViewMenu", this.DistortionWave);
			this.KBOPGONOCNP().SetFloat("RemoveHighlight", this.Wavy);
			this.HCGJCMDJPGD().SetFloat("Joystick1Button", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.ColoredChange);
			this.NFMGLIKNOOC().SetFloat("_EmissionColor", this.ChangeRed);
			this.MFHPKGICPIO().SetFloat("/", this.ChangeGreen);
			this.HKGAONMOBMH().SetFloat("Event Received", this.ChangeBlue);
			this.BFGNMFCNDBC().SetFloat("music", this.ColoredSaturate);
			this.PDEAHJPOMEF().SetVector("settings_bindings_controller_type", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 933f, 1954f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B33 RID: 15155 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06003B34 RID: 15156 RVA: 0x0012AFAD File Offset: 0x001291AD
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_WaterDropPro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B35 RID: 15157 RVA: 0x0012AFD4 File Offset: 0x001291D4
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1137f)
			{
				this.HBJJOCHGOPH = 1893f;
			}
			this.OCHJIMJNEMO().SetFloat("value", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", this.Value);
			this.EHDJJANLINB().SetFloat("original.tutorial", this.Speed);
			this.KBOPGONOCNP().SetFloat("settings.shaders.bloomintencity", this.Distortion);
			this.DONENAMLFLF().SetFloat("sfxVolume", this.DistortionWave);
			this.BLMPMOIDGMG().SetFloat("Result for ", this.Wavy);
			this.KEMJNOMIPHN().SetFloat("[Up-Right-Left]", this.Fade);
			this.LNLKMDPHDCC().SetFloat("Overlay", this.ColoredChange);
			this.NBPKMLMCHFN.SetFloat(".lastCheckpoint.currentCombo", this.ChangeRed);
			this.HCGJCMDJPGD().SetFloat(".completedCount", this.ChangeGreen);
			this.LPCHMEKDCHI().SetFloat("id", this.ChangeBlue);
			this.NLFJGMBCICG().SetFloat("PowerUp", this.ColoredSaturate);
			this.IIJMIPBMMBF().SetVector("The number of objects sent via a PhotonStreamQueue has to be the same each frame", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1840f, 35f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B36 RID: 15158 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06003B37 RID: 15159 RVA: 0x0012B16D File Offset: 0x0012936D
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B38 RID: 15160 RVA: 0x0012B1A4 File Offset: 0x001293A4
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("_Source");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B39 RID: 15161 RVA: 0x0012B1C8 File Offset: 0x001293C8
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B3A RID: 15162 RVA: 0x00129E09 File Offset: 0x00128009
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B3B RID: 15163 RVA: 0x0012B1FF File Offset: 0x001293FF
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B3C RID: 15164 RVA: 0x00129E09 File Offset: 0x00128009
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B3D RID: 15165 RVA: 0x0012B224 File Offset: 0x00129424
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1577f)
			{
				this.HBJJOCHGOPH = 1363f;
			}
			this.LENEJAGLCNL().SetFloat("Myst", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("FileMenu", this.Value);
			this.OLHDPICFBOF().SetFloat("_OcclusionTexture", this.Speed);
			this.PLBEJJIHFPB().SetFloat("No Name", this.Distortion);
			this.PLBEJJIHFPB().SetFloat("maps.", this.DistortionWave);
			this.NLFJGMBCICG().SetFloat("SetPlayerDistance", this.Wavy);
			this.HCGJCMDJPGD().SetFloat("#mapby", this.Fade);
			this.NFMGLIKNOOC().SetFloat(",", this.ColoredChange);
			this.NFMGLIKNOOC().SetFloat("[Right-Left]", this.ChangeRed);
			this.OLHDPICFBOF().SetFloat("_BlurredColor", this.ChangeGreen);
			this.EHDJJANLINB().SetFloat("_TimeX", this.ChangeBlue);
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.ColoredSaturate);
			this.OCHJIMJNEMO().SetVector("B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 411f, 1334f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B3E RID: 15166 RVA: 0x0012B3BD File Offset: 0x001295BD
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003B3F RID: 15167 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06003B40 RID: 15168 RVA: 0x0012B3E1 File Offset: 0x001295E1
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Internal LUT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B41 RID: 15169 RVA: 0x0012B408 File Offset: 0x00129608
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1882f)
			{
				this.HBJJOCHGOPH = 1494f;
			}
			this.LENEJAGLCNL().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("_Value4", this.Value);
			this.EHDJJANLINB().SetFloat("_HdrParams", this.Speed);
			this.NFMGLIKNOOC().SetFloat("DifficultyBG", this.Distortion);
			this.KEMJNOMIPHN().SetFloat("Yes", this.DistortionWave);
			this.EHDJJANLINB().SetFloat("_TimeX", this.Wavy);
			this.PLBEJJIHFPB().SetFloat("SetSunColors", this.Fade);
			this.OCHJIMJNEMO().SetFloat("Coroutine container not configured... did you forget to call Init?", this.ColoredChange);
			this.BFGNMFCNDBC().SetFloat("_Tint", this.ChangeRed);
			this.OLHDPICFBOF().SetFloat(".completedMaps", this.ChangeGreen);
			this.IGKFMCPDNOI().SetFloat("win", this.ChangeBlue);
			this.LPCHMEKDCHI().SetFloat("_Value2", this.ColoredSaturate);
			this.IIJMIPBMMBF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 962f, 582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B42 RID: 15170 RVA: 0x00129E09 File Offset: 0x00128009
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B43 RID: 15171 RVA: 0x0012B5A4 File Offset: 0x001297A4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_DistortionWave", this.DistortionWave);
			this.NBPKMLMCHFN.SetFloat("_Wavy", this.Wavy);
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_ColoredChange", this.ColoredChange);
			this.NBPKMLMCHFN.SetFloat("_ChangeRed", this.ChangeRed);
			this.NBPKMLMCHFN.SetFloat("_ChangeGreen", this.ChangeGreen);
			this.NBPKMLMCHFN.SetFloat("_ChangeBlue", this.ChangeBlue);
			this.NBPKMLMCHFN.SetFloat("_Colored", this.ColoredSaturate);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B44 RID: 15172 RVA: 0x0012B740 File Offset: 0x00129940
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1734f)
			{
				this.HBJJOCHGOPH = 327f;
			}
			this.LENEJAGLCNL().SetFloat("selector", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("Subscribe: ", this.Value);
			this.LNLKMDPHDCC().SetFloat("team", this.Speed);
			this.PLBEJJIHFPB().SetFloat("RecieveChatMessage", this.Distortion);
			this.IIJMIPBMMBF().SetFloat("EventMenu", this.DistortionWave);
			this.LNLKMDPHDCC().SetFloat(" ", this.Wavy);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/FX_Glitch1", this.Fade);
			this.LENEJAGLCNL().SetFloat("_Value5", this.ColoredChange);
			this.LPCHMEKDCHI().SetFloat("HightScoreMaxPointsText", this.ChangeRed);
			this.HCGJCMDJPGD().SetFloat("_Value4", this.ChangeGreen);
			this.LENEJAGLCNL().SetFloat(" Maybe GO was destroyed but RPC not cleaned up.", this.ChangeBlue);
			this.LENEJAGLCNL().SetFloat("CameraFilterPack/Edge_Golden", this.ColoredSaturate);
			this.KEMJNOMIPHN().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 219f, 1259f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B45 RID: 15173 RVA: 0x00129E09 File Offset: 0x00128009
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B46 RID: 15174 RVA: 0x0012B8D9 File Offset: 0x00129AD9
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B47 RID: 15175 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06003B48 RID: 15176 RVA: 0x0012B910 File Offset: 0x00129B10
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B49 RID: 15177 RVA: 0x0012B947 File Offset: 0x00129B47
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B4A RID: 15178 RVA: 0x0012B96B File Offset: 0x00129B6B
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B4B RID: 15179 RVA: 0x0012B9A4 File Offset: 0x00129BA4
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1190f)
			{
				this.HBJJOCHGOPH = 824f;
			}
			this.PLBEJJIHFPB().SetFloat("_NumberOfWaves", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("Added GameObject to prefabDictionary: ", this.Value);
			this.OLHDPICFBOF().SetFloat("_Max", this.Speed);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/Drawing_Manga_Color", this.Distortion);
			this.LNLKMDPHDCC().SetFloat("_History4LumaTex", this.DistortionWave);
			this.EPCGJFCCAFH().SetFloat("Exit to Windows", this.Wavy);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button3", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Colorisation", this.ColoredChange);
			this.NLFJGMBCICG().SetFloat("maps.", this.ChangeRed);
			this.PDEAHJPOMEF().SetFloat("inventory.selected.", this.ChangeGreen);
			this.BFGNMFCNDBC().SetFloat("_Axis", this.ChangeBlue);
			this.NFMGLIKNOOC().SetFloat("OPEN FILE", this.ColoredSaturate);
			this.KBOPGONOCNP().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1617f, 1248f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B4C RID: 15180 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06003B4D RID: 15181 RVA: 0x0012BB3D File Offset: 0x00129D3D
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("EditMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B4E RID: 15182 RVA: 0x00129E09 File Offset: 0x00128009
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B4F RID: 15183 RVA: 0x0012BB61 File Offset: 0x00129D61
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000678 RID: 1656
	public Shader SCShader;

	// Token: 0x04000679 RID: 1657
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400067A RID: 1658
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400067B RID: 1659
	private Material BJFKDHHMLJH;

	// Token: 0x0400067C RID: 1660
	[Range(0f, 20f)]
	[HideInInspector]
	public float Value = 6f;

	// Token: 0x0400067D RID: 1661
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x0400067E RID: 1662
	[Range(0f, 1f)]
	public float Wavy = 1f;

	// Token: 0x0400067F RID: 1663
	[Range(0f, 1f)]
	public float Distortion;

	// Token: 0x04000680 RID: 1664
	[Range(0f, 1f)]
	public float DistortionWave;

	// Token: 0x04000681 RID: 1665
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000682 RID: 1666
	[Range(-2f, 2f)]
	public float ColoredSaturate = 1f;

	// Token: 0x04000683 RID: 1667
	[Range(-1f, 2f)]
	public float ColoredChange;

	// Token: 0x04000684 RID: 1668
	[Range(-1f, 1f)]
	public float ChangeRed;

	// Token: 0x04000685 RID: 1669
	[Range(-1f, 1f)]
	public float ChangeGreen;

	// Token: 0x04000686 RID: 1670
	[Range(-1f, 1f)]
	public float ChangeBlue;
}
