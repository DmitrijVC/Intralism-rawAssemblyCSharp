using System;
using UnityEngine;

// Token: 0x02000078 RID: 120
[AddComponentMenu("Camera Filter Pack/ColorsAdjust/FullColors")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_Adjust_FullColors : MonoBehaviour
{
	// Token: 0x0600222A RID: 8746 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000C3E20 File Offset: 0x000C2020
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 85f)
			{
				this.HBJJOCHGOPH = 723f;
			}
			this.BLMPMOIDGMG().SetFloat("ready", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", this.Red_R / 1507f);
			this.KOHGPKOFEJO().SetFloat("_TimeX", this.Red_G / 1153f);
			this.JLHLHKPHDFO().SetFloat("custom", this.Red_B / 871f);
			this.IGIAPKPKGPK().SetFloat("icon", this.Green_R / 1005f);
			this.GJHLADDCMFF().SetFloat("_Blue_R", this.Green_G / 1713f);
			this.ACHNOHCLGOO().SetFloat("_Value4", this.Green_B / 1610f);
			this.JLHLHKPHDFO().SetFloat("-", this.Blue_R / 1848f);
			this.MLMKCOINOOH().SetFloat("_ScreenResolution", this.Blue_G / 451f);
			this.KDMBOKLMADJ().SetFloat("_TimeX", this.Blue_B / 533f);
			this.KDMBOKLMADJ().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", this.Red_Constant / 1171f);
			this.LDNADDJMIPK().SetFloat("OnRelease", this.Green_Constant / 1998f);
			this.GJHLADDCMFF().SetFloat("RPC can't be sent to target PhotonPlayer being null! Did not send \"", this.Blue_Constant / 364f);
			this.NBMPPNFKFLB().SetVector("inventory.itemscash", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 450f, 528f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000C4017 File Offset: 0x000C2217
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x000C404E File Offset: 0x000C224E
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000C4072 File Offset: 0x000C2272
	private void KDJEJBBDILE()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000C4080 File Offset: 0x000C2280
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1220f)
			{
				this.HBJJOCHGOPH = 1368f;
			}
			this.NBPKMLMCHFN.SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("CameraFilterPack/TV_PlanetMars", this.Red_R / 614f);
			this.EMDFHOKEGNG().SetFloat(".mp3", this.Red_G / 1304f);
			this.LMLENGFLEBD().SetFloat("Tab1Content", this.Red_B / 1600f);
			this.ACHNOHCLGOO().SetFloat("_EmissionGain", this.Green_R / 107f);
			this.NLFJGMBCICG().SetFloat("_Value4", this.Green_G / 1765f);
			this.HCGJCMDJPGD().SetFloat("Joystick1Button7", this.Green_B / 79f);
			this.LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Color", this.Blue_R / 1342f);
			this.OIIDAKBILMI().SetFloat(".", this.Blue_G / 1280f);
			this.OIIDAKBILMI().SetFloat(" not exist", this.Blue_B / 1102f);
			this.GJHLADDCMFF().SetFloat("/../", this.Red_Constant / 1420f);
			this.EPCGJFCCAFH().SetFloat("outputitemdefid", this.Green_Constant / 520f);
			this.HHIFMIPPMPF().SetFloat("SettingsCanvas", this.Blue_Constant / 1306f);
			this.HEHKGPKLAKK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1766f, 1705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06002230 RID: 8752 RVA: 0x000C4277 File Offset: 0x000C2477
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

	// Token: 0x06002231 RID: 8753 RVA: 0x000C42AE File Offset: 0x000C24AE
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x000C42E5 File Offset: 0x000C24E5
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x000C431C File Offset: 0x000C251C
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x000C4072 File Offset: 0x000C2272
	private void PFNFPINPCMH()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x000C4353 File Offset: 0x000C2553
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_LinearDodge");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000C4377 File Offset: 0x000C2577
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x000C43AE File Offset: 0x000C25AE
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000C43E8 File Offset: 0x000C25E8
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1614f)
			{
				this.HBJJOCHGOPH = 134f;
			}
			this.KOHGPKOFEJO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_TimeX", this.Red_R / 485f);
			this.NLFJGMBCICG().SetFloat("_Blend", this.Red_G / 1787f);
			this.EMDFHOKEGNG().SetFloat("LevelNameInputField", this.Red_B / 559f);
			this.DKNJGHFLAIF().SetFloat("OpenButton", this.Green_R / 405f);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_Psycho", this.Green_G / 380f);
			this.KDMBOKLMADJ().SetFloat(".completed", this.Green_B / 588f);
			this.EMDFHOKEGNG().SetFloat("Editor/", this.Blue_R / 1707f);
			this.NBPKMLMCHFN.SetFloat("_FarCamera", this.Blue_G / 884f);
			this.HHIFMIPPMPF().SetFloat("Drop_With_Obj", this.Blue_B / 429f);
			this.LDNADDJMIPK().SetFloat("Bad parameters for set! Use <language>", this.Red_Constant / 1021f);
			this.EPCGJFCCAFH().SetFloat("\n", this.Green_Constant / 920f);
			this.EHDJJANLINB().SetFloat("Remove Environment Object", this.Blue_Constant / 1302f);
			this.EPCGJFCCAFH().SetVector("_ForceYSwap", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1411f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x000C4613 File Offset: 0x000C2813
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000C4072 File Offset: 0x000C2272
	private void COGBDFKOHKK()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x000C4072 File Offset: 0x000C2272
	private void PNLKFANNOKO()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000C4072 File Offset: 0x000C2272
	private void LCJHDLKJEOM()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000C464A File Offset: 0x000C284A
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000C4681 File Offset: 0x000C2881
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000C46B8 File Offset: 0x000C28B8
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 149f)
			{
				this.HBJJOCHGOPH = 1948f;
			}
			this.LDNADDJMIPK().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("Cancel", this.Red_R / 1041f);
			this.KOHGPKOFEJO().SetFloat("OK", this.Red_G / 722f);
			this.EPCGJFCCAFH().SetFloat("ticket", this.Red_B / 1663f);
			this.NBPKMLMCHFN.SetFloat(".png", this.Green_R / 1692f);
			this.KDMBOKLMADJ().SetFloat("_Value4", this.Green_G / 1624f);
			this.DKNJGHFLAIF().SetFloat("settings.customdataskin", this.Green_B / 1445f);
			this.EHDJJANLINB().SetFloat("score:", this.Blue_R / 90f);
			this.EMDFHOKEGNG().SetFloat("MouseX", this.Blue_G / 1957f);
			this.EJDPNJAEAKJ().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", this.Blue_B / 433f);
			this.EHDJJANLINB().SetFloat("_UV_Transform", this.Red_Constant / 621f);
			this.EJDPNJAEAKJ().SetFloat("_Linecount", this.Green_Constant / 1101f);
			this.HHIFMIPPMPF().SetFloat("_FadeFX", this.Blue_Constant / 1327f);
			this.EHDJJANLINB().SetVector("_Alpha2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1604f, 272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x000C4072 File Offset: 0x000C2272
	private void AIJGAJIOJDJ()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000C48AF File Offset: 0x000C2AAF
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000C48E8 File Offset: 0x000C2AE8
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1771f)
			{
				this.HBJJOCHGOPH = 740f;
			}
			this.JLHLHKPHDFO().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("/", this.Red_R / 1031f);
			this.ACHNOHCLGOO().SetFloat("Items/", this.Red_G / 1996f);
			this.JLHLHKPHDFO().SetFloat("inventory.selected.", this.Red_B / 317f);
			this.BLMPMOIDGMG().SetFloat("[MapsData] Preloading workshop", this.Green_R / 59f);
			this.NBMPPNFKFLB().SetFloat("Tab2Content", this.Green_G / 1424f);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.Green_B / 309f);
			this.KOHGPKOFEJO().SetFloat(",", this.Blue_R / 1720f);
			this.EMDFHOKEGNG().SetFloat(" #", this.Blue_G / 477f);
			this.EPCGJFCCAFH().SetFloat("#", this.Blue_B / 485f);
			this.DKNJGHFLAIF().SetFloat(" has ", this.Red_Constant / 1140f);
			this.KOHGPKOFEJO().SetFloat("Testing, the group has toggled [", this.Green_Constant / 1929f);
			this.EJDPNJAEAKJ().SetFloat("_MainTex2", this.Blue_Constant / 1411f);
			this.HEHKGPKLAKK().SetVector("ShadersToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1690f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x000C4AE0 File Offset: 0x000C2CE0
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 226f)
			{
				this.HBJJOCHGOPH = 570f;
			}
			this.LDNADDJMIPK().SetFloat("_Value", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("[EMPTY]", this.Red_R / 1811f);
			this.HCGJCMDJPGD().SetFloat("_Value3", this.Red_G / 1089f);
			this.HEHKGPKLAKK().SetFloat("_Value", this.Red_B / 677f);
			this.HHIFMIPPMPF().SetFloat("_SSAO", this.Green_R / 199f);
			this.DKNJGHFLAIF().SetFloat("_Value4", this.Green_G / 454f);
			this.KOHGPKOFEJO().SetFloat("#ok", this.Green_B / 1517f);
			this.NBPKMLMCHFN.SetFloat(": ", this.Blue_R / 996f);
			this.HEHKGPKLAKK().SetFloat("[ItemsHandler] All in-game items loaded", this.Blue_G / 1338f);
			this.DKNJGHFLAIF().SetFloat("ItemsUploader", this.Blue_B / 152f);
			this.HEHKGPKLAKK().SetFloat("MaxLivesSlider", this.Red_Constant / 1578f);
			this.EHDJJANLINB().SetFloat("_DistortionLevel", this.Green_Constant / 114f);
			this.NBPKMLMCHFN.SetFloat("DPADHOR", this.Blue_Constant / 709f);
			this.BKKJJJGADLM().SetVector(". Calling ConnectToRegionMaster() is: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 506f, 1612f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x000C4CD7 File Offset: 0x000C2ED7
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000C4D0E File Offset: 0x000C2F0E
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x000C4D45 File Offset: 0x000C2F45
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x000C4D7C File Offset: 0x000C2F7C
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 908f)
			{
				this.HBJJOCHGOPH = 1224f;
			}
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_DiffuseColor", this.Red_R / 1052f);
			this.NBPKMLMCHFN.SetFloat("Data/Editor/leveltemplate", this.Red_G / 318f);
			this.KOHGPKOFEJO().SetFloat("ResetButton", this.Red_B / 908f);
			this.DKNJGHFLAIF().SetFloat("_Value3", this.Green_R / 1195f);
			this.OIIDAKBILMI().SetFloat("_Value6", this.Green_G / 1406f);
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/FX_Dot_Circle", this.Green_B / 1143f);
			this.OIIDAKBILMI().SetFloat("ShadersToggle", this.Blue_R / 1176f);
			this.EHDJJANLINB().SetFloat("_Value3", this.Blue_G / 308f);
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/Retro_Loading", this.Blue_B / 1094f);
			this.EHDJJANLINB().SetFloat("[EMPTY]", this.Red_Constant / 857f);
			this.OIIDAKBILMI().SetFloat("_Value3", this.Green_Constant / 86f);
			this.KOHGPKOFEJO().SetFloat("Icon", this.Blue_Constant / 273f);
			this.EHDJJANLINB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 252f, 210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x000C4F74 File Offset: 0x000C3174
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 246f)
			{
				this.HBJJOCHGOPH = 1586f;
			}
			this.HHIFMIPPMPF().SetFloat(".lastCheckpoint.time", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat(" but this PhotonView does not exist! Was remote PV.", this.Red_R / 233f);
			this.BLMPMOIDGMG().SetFloat("_SizeY", this.Red_G / 1734f);
			this.JLHLHKPHDFO().SetFloat(".completed", this.Red_B / 1382f);
			this.HCGJCMDJPGD().SetFloat("settings.volume.editor", this.Green_R / 1038f);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/3D_Anomaly", this.Green_G / 67f);
			this.ACHNOHCLGOO().SetFloat("[PlayerBase] Loaded custom model: ", this.Green_B / 1275f);
			this.KDMBOKLMADJ().SetFloat("mapselector.orderby", this.Blue_R / 669f);
			this.NLFJGMBCICG().SetFloat("settings.showHP", this.Blue_G / 798f);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this.Blue_B / 1348f);
			this.NBPKMLMCHFN.SetFloat("G:", this.Red_Constant / 1491f);
			this.KDMBOKLMADJ().SetFloat(".lastCheckpoint.correctScore", this.Green_Constant / 865f);
			this.LDNADDJMIPK().SetFloat("BitsData", this.Blue_Constant / 1446f);
			this.KDMBOKLMADJ().SetVector("_ZCurve", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 646f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x000C516C File Offset: 0x000C336C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1190f)
			{
				this.HBJJOCHGOPH = 1900f;
			}
			this.IGIAPKPKGPK().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("_copy", this.Red_R / 895f);
			this.HKHBBBFLGJH().SetFloat("#ok", this.Red_G / 1111f);
			this.HEHKGPKLAKK().SetFloat("[Sound Manager] Audio clip is null, cannot play sound", this.Red_B / 272f);
			this.LMLENGFLEBD().SetFloat("_ChangeBlue", this.Green_R / 1193f);
			this.HCGJCMDJPGD().SetFloat(" not exist", this.Green_G / 1347f);
			this.HCGJCMDJPGD().SetFloat("DPADVER", this.Green_B / 1834f);
			this.NBMPPNFKFLB().SetFloat("nogamesfound", this.Blue_R / 498f);
			this.EPCGJFCCAFH().SetFloat("Deleted event", this.Blue_G / 594f);
			this.BKKJJJGADLM().SetFloat("_Fade", this.Blue_B / 1373f);
			this.EMDFHOKEGNG().SetFloat("]", this.Red_Constant / 1138f);
			this.KDMBOKLMADJ().SetFloat("Save", this.Green_Constant / 1907f);
			this.JLHLHKPHDFO().SetFloat("Fade", this.Blue_Constant / 770f);
			this.DKNJGHFLAIF().SetVector("float,50", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1975f, 1515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000C5363 File Offset: 0x000C3563
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x000C4072 File Offset: 0x000C2272
	private void GHILDCBCDJI()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x000C5387 File Offset: 0x000C3587
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("sounds/hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000C53AC File Offset: 0x000C35AC
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 136f)
			{
				this.HBJJOCHGOPH = 1485f;
			}
			this.EMDFHOKEGNG().SetFloat("settings.arcsdestroydelay", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("editorVolume", this.Red_R / 1398f);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Myst", this.Red_G / 193f);
			this.HKHBBBFLGJH().SetFloat("CameraFilterPack_Paper4", this.Red_B / 516f);
			this.EMDFHOKEGNG().SetFloat(".lastCheckpoint.comboScore", this.Green_R / 1391f);
			this.EJDPNJAEAKJ().SetFloat("Use \"/help\" for commands list", this.Green_G / 1364f);
			this.LDNADDJMIPK().SetFloat(", ", this.Green_B / 326f);
			this.NBPKMLMCHFN.SetFloat("#useticket", this.Blue_R / 1429f);
			this.HCGJCMDJPGD().SetFloat("DPADVER", this.Blue_G / 1704f);
			this.MLMKCOINOOH().SetFloat("st", this.Blue_B / 1294f);
			this.HCGJCMDJPGD().SetFloat("_Blend", this.Red_Constant / 1672f);
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this.Green_Constant / 227f);
			this.KOHGPKOFEJO().SetFloat("_PixelsPerMeterAtOneMeter", this.Blue_Constant / 1203f);
			this.DKNJGHFLAIF().SetVector("CameraFilterPack/Blend2Camera_Subtract", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1901f, 433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000C4072 File Offset: 0x000C2272
	private void OMCLOFCJMPG()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x000C55A3 File Offset: 0x000C37A3
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("float,1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x000C4072 File Offset: 0x000C2272
	private void JAAJECBCCFM()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000C55C8 File Offset: 0x000C37C8
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1859f)
			{
				this.HBJJOCHGOPH = 643f;
			}
			this.EFDEIFCDAFG().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("_ScreenResolution", this.Red_R / 1878f);
			this.GJHLADDCMFF().SetFloat("BadgeText", this.Red_G / 710f);
			this.NBMPPNFKFLB().SetFloat("Drop_With_Obj", this.Red_B / 1000f);
			this.KOHGPKOFEJO().SetFloat("Waiting to start", this.Green_R / 1173f);
			this.MLMKCOINOOH().SetFloat("_FarCamera", this.Green_G / 1998f);
			this.EFDEIFCDAFG().SetFloat("id", this.Green_B / 975f);
			this.KOHGPKOFEJO().SetFloat("<b>#", this.Blue_R / 951f);
			this.HCGJCMDJPGD().SetFloat("Mouse0", this.Blue_G / 1585f);
			this.ACHNOHCLGOO().SetFloat("IconFileSelector", this.Blue_B / 172f);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_Funk", this.Red_Constant / 1778f);
			this.HEHKGPKLAKK().SetFloat("CrosshairOpacitySlider", this.Green_Constant / 648f);
			this.OIIDAKBILMI().SetFloat("Joystick1Button5", this.Blue_Constant / 102f);
			this.BKKJJJGADLM().SetVector(".lastCheckpoint.bgcolor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1665f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x000C57C0 File Offset: 0x000C39C0
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 192f)
			{
				this.HBJJOCHGOPH = 1378f;
			}
			this.HHIFMIPPMPF().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("[PlayerBase] Config error: musicTime <= 0", this.Red_R / 407f);
			this.LMLENGFLEBD().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.Red_G / 1051f);
			this.HKHBBBFLGJH().SetFloat("X", this.Red_B / 126f);
			this.HHIFMIPPMPF().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.Green_R / 280f);
			this.ACHNOHCLGOO().SetFloat("_Offsets", this.Green_G / 1320f);
			this.EPCGJFCCAFH().SetFloat("_Green_B", this.Green_B / 1878f);
			this.HHIFMIPPMPF().SetFloat("FavoriteButton", this.Blue_R / 579f);
			this.BKKJJJGADLM().SetFloat("Added GameObject to prefabDictionary: ", this.Blue_G / 1748f);
			this.OIIDAKBILMI().SetFloat("ItemNameBGImage", this.Blue_B / 919f);
			this.EFDEIFCDAFG().SetFloat("inventory.lastitemscount", this.Red_Constant / 995f);
			this.GJHLADDCMFF().SetFloat("_Value3", this.Green_Constant / 212f);
			this.NBMPPNFKFLB().SetFloat("Found best region: '", this.Blue_Constant / 759f);
			this.EJDPNJAEAKJ().SetVector("_CenterX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 180f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x000C59B8 File Offset: 0x000C3BB8
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 962f)
			{
				this.HBJJOCHGOPH = 1007f;
			}
			this.JLHLHKPHDFO().SetFloat("menu.selectedlevelid", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.Red_R / 872f);
			this.KDMBOKLMADJ().SetFloat("[SERVER] Selected mode: ", this.Red_G / 1029f);
			this.GJHLADDCMFF().SetFloat(".", this.Red_B / 113f);
			this.EMDFHOKEGNG().SetFloat("Copy from ", this.Green_R / 749f);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/Color_Chromatic_Plus", this.Green_G / 1038f);
			this.EJDPNJAEAKJ().SetFloat("#8E8E8EFF", this.Green_B / 1790f);
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this.Blue_R / 1488f);
			this.EJDPNJAEAKJ().SetFloat("_Value2", this.Blue_G / 905f);
			this.LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.Blue_B / 1529f);
			this.LDNADDJMIPK().SetFloat("/", this.Red_Constant / 747f);
			this.NLFJGMBCICG().SetFloat("menu.relaxinfo", this.Green_Constant / 1756f);
			this.GJHLADDCMFF().SetFloat("Fade", this.Blue_Constant / 228f);
			this.DKNJGHFLAIF().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1722f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x000C5BAF File Offset: 0x000C3DAF
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000C5BE6 File Offset: 0x000C3DE6
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x000C5C20 File Offset: 0x000C3E20
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 801f)
			{
				this.HBJJOCHGOPH = 1468f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/TV_WideScreenCircle", this.Red_R / 1504f);
			this.KOHGPKOFEJO().SetFloat("[ItemsHandler] Loading ", this.Red_G / 724f);
			this.MLMKCOINOOH().SetFloat("MAPS NOT FOUND", this.Red_B / 1551f);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.Green_R / 1361f);
			this.GJHLADDCMFF().SetFloat("[PlayerBase] Ready", this.Green_G / 761f);
			this.LMLENGFLEBD().SetFloat("_Value9", this.Green_B / 1099f);
			this.DKNJGHFLAIF().SetFloat("[PlayerController] ", this.Blue_R / 385f);
			this.EMDFHOKEGNG().SetFloat("_Offsets", this.Blue_G / 1219f);
			this.NBPKMLMCHFN.SetFloat("_BlurRadius4", this.Blue_B / 242f);
			this.BLMPMOIDGMG().SetFloat("_Value4", this.Red_Constant / 1722f);
			this.EFDEIFCDAFG().SetFloat("DifficultyBG", this.Green_Constant / 1076f);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Shield", this.Blue_Constant / 358f);
			this.MLMKCOINOOH().SetVector("action", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1496f, 232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002261 RID: 8801 RVA: 0x000C5E17 File Offset: 0x000C4017
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("menu.tabid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x000C5E3B File Offset: 0x000C403B
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x000C5E72 File Offset: 0x000C4072
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("JoinTeam was called in state: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x000C5E96 File Offset: 0x000C4096
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("ShadersToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000C4072 File Offset: 0x000C2272
	private void OBAEDJJDCPN()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x000C5EBC File Offset: 0x000C40BC
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 719f)
			{
				this.HBJJOCHGOPH = 1396f;
			}
			this.EFDEIFCDAFG().SetFloat("settings.volume.sfx", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("y", this.Red_R / 594f);
			this.NLFJGMBCICG().SetFloat("DifficultyBG", this.Red_G / 821f);
			this.OIIDAKBILMI().SetFloat("_VelTex", this.Red_B / 1541f);
			this.HHIFMIPPMPF().SetFloat("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", this.Green_R / 78f);
			this.HEHKGPKLAKK().SetFloat("[ResourcesManager] Load text error: not found", this.Green_G / 474f);
			this.HEHKGPKLAKK().SetFloat("[NetworkManager] Exited", this.Green_B / 70f);
			this.HEHKGPKLAKK().SetFloat("_Noise", this.Blue_R / 745f);
			this.IGIAPKPKGPK().SetFloat(":", this.Blue_G / 1979f);
			this.MLMKCOINOOH().SetFloat("_OffsetScale", this.Blue_B / 823f);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/TV_MovieNoise", this.Red_Constant / 1020f);
			this.EJDPNJAEAKJ().SetFloat("_Offsets", this.Green_Constant / 472f);
			this.GJHLADDCMFF().SetFloat("_ScreenResolution", this.Blue_Constant / 1431f);
			this.KDMBOKLMADJ().SetVector("[PlayerBase] Loaded custom model: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 42f, 759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000C4072 File Offset: 0x000C2272
	private void NFEDLAOPHML()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x000C4072 File Offset: 0x000C2272
	private void IIFCIDDJHPM()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x000C60B4 File Offset: 0x000C42B4
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1410f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			this.NBMPPNFKFLB().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat(" (", this.Red_R / 930f);
			this.KDMBOKLMADJ().SetFloat(".message", this.Red_G / 289f);
			this.HKHBBBFLGJH().SetFloat("D-Pad Right", this.Red_B / 1086f);
			this.HCGJCMDJPGD().SetFloat("B:", this.Green_R / 767f);
			this.DKNJGHFLAIF().SetFloat("_Blue_G", this.Green_G / 583f);
			this.BKKJJJGADLM().SetFloat("_Distortion", this.Green_B / 613f);
			this.BKKJJJGADLM().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.Blue_R / 1696f);
			this.BKKJJJGADLM().SetFloat("maps.", this.Blue_G / 73f);
			this.KDMBOKLMADJ().SetFloat("_Value3", this.Blue_B / 1798f);
			this.IGIAPKPKGPK().SetFloat("InputField", this.Red_Constant / 1293f);
			this.BKKJJJGADLM().SetFloat("_Value2", this.Green_Constant / 1391f);
			this.OIIDAKBILMI().SetFloat("[PlayerController] ", this.Blue_Constant / 345f);
			this.NBMPPNFKFLB().SetVector("HiddenToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 768f, 1515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x000C62AC File Offset: 0x000C44AC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1628f)
			{
				this.HBJJOCHGOPH = 592f;
			}
			this.DKNJGHFLAIF().SetFloat("[RanksSystem] Ranks updated. Next update: ", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Editor/", this.Red_R / 1481f);
			this.KOHGPKOFEJO().SetFloat("_Value2", this.Red_G / 1963f);
			this.EHDJJANLINB().SetFloat("_HrDepthTex", this.Red_B / 14f);
			this.BLMPMOIDGMG().SetFloat("_Value3", this.Green_R / 1900f);
			this.EHDJJANLINB().SetFloat("time", this.Green_G / 970f);
			this.EHDJJANLINB().SetFloat("_Axis", this.Green_B / 572f);
			this.OIIDAKBILMI().SetFloat("Save Path: ", this.Blue_R / 1122f);
			this.GJHLADDCMFF().SetFloat("_Value3", this.Blue_G / 1946f);
			this.OIIDAKBILMI().SetFloat("_Value", this.Blue_B / 1171f);
			this.EHDJJANLINB().SetFloat(". Prefab must have a PhotonView component.", this.Red_Constant / 1711f);
			this.EJDPNJAEAKJ().SetFloat(".", this.Green_Constant / 1993f);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/Blend2Camera_Difference", this.Blue_Constant / 996f);
			this.EHDJJANLINB().SetVector("_FarCamera", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1725f, 235f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x000C64A3 File Offset: 0x000C46A3
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x000C4072 File Offset: 0x000C2272
	private void POJFHDFJOPE()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x000C4072 File Offset: 0x000C2272
	private void Update()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000C4072 File Offset: 0x000C2272
	private void PHJJHFBLICM()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x000C64DC File Offset: 0x000C46DC
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1665f)
			{
				this.HBJJOCHGOPH = 1697f;
			}
			this.HCGJCMDJPGD().SetFloat("_NoiseTilingPerChannel", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_DotSize", this.Red_R / 1960f);
			this.OIIDAKBILMI().SetFloat("CameraFilterPack/Oculus_NightVision5", this.Red_G / 356f);
			this.DKNJGHFLAIF().SetFloat("ItemNameText", this.Red_B / 1659f);
			this.KOHGPKOFEJO().SetFloat("z", this.Green_R / 399f);
			this.HKHBBBFLGJH().SetFloat("#timeuntilend: ", this.Green_G / 1202f);
			this.IGIAPKPKGPK().SetFloat("{0} hours ago", this.Green_B / 657f);
			this.LMLENGFLEBD().SetFloat("Error: Cannot change the name of a remote player!", this.Blue_R / 384f);
			this.ACHNOHCLGOO().SetFloat("_ColorBuffer", this.Blue_G / 1246f);
			this.LMLENGFLEBD().SetFloat("</color>", this.Blue_B / 252f);
			this.EFDEIFCDAFG().SetFloat("_Radius", this.Red_Constant / 1005f);
			this.GJHLADDCMFF().SetFloat("BitsData", this.Green_Constant / 779f);
			this.ACHNOHCLGOO().SetFloat("Set Particles Input", this.Blue_Constant / 95f);
			this.HKHBBBFLGJH().SetVector("Set EnvSprite Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1757f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000C66D3 File Offset: 0x000C48D3
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000C670A File Offset: 0x000C490A
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000C6744 File Offset: 0x000C4944
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1021f)
			{
				this.HBJJOCHGOPH = 1983f;
			}
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.Red_R / 473f);
			this.JLHLHKPHDFO().SetFloat("_Value2", this.Red_G / 1410f);
			this.BLMPMOIDGMG().SetFloat("Joystick1Button11", this.Red_B / 52f);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/FX_Glitch2", this.Green_R / 1452f);
			this.EMDFHOKEGNG().SetFloat("Editor/", this.Green_G / 1045f);
			this.NLFJGMBCICG().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.Green_B / 1454f);
			this.EFDEIFCDAFG().SetFloat("_Value", this.Blue_R / 1007f);
			this.IGIAPKPKGPK().SetFloat("RecordButton", this.Blue_G / 72f);
			this.DKNJGHFLAIF().SetFloat("_Value4", this.Blue_B / 40f);
			this.BLMPMOIDGMG().SetFloat("_Far", this.Red_Constant / 191f);
			this.GJHLADDCMFF().SetFloat("_TimeX", this.Green_Constant / 169f);
			this.EMDFHOKEGNG().SetFloat("[MapEditor] Loaded music file: ", this.Blue_Constant / 1616f);
			this.NBPKMLMCHFN.SetVector("ItemsCountText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 421f, 1090f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000C4072 File Offset: 0x000C2272
	private void GCHBGCGBMCK()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x000C693B File Offset: 0x000C4B3B
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("Set satellite color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000C4072 File Offset: 0x000C2272
	private void ONKDMMJPEMN()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000C4072 File Offset: 0x000C2272
	private void LEAHIBJDMBI()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000C695F File Offset: 0x000C4B5F
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find(" now: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x000C6983 File Offset: 0x000C4B83
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000C69BC File Offset: 0x000C4BBC
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1578f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.LMLENGFLEBD().SetFloat("{0:0} minute{1}, ", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("#discord{0}joinrequest", this.Red_R / 1690f);
			this.OIIDAKBILMI().SetFloat("ok", this.Red_G / 1623f);
			this.EFDEIFCDAFG().SetFloat("_Value", this.Red_B / 902f);
			this.KDMBOKLMADJ().SetFloat("_ScreenResolution", this.Green_R / 83f);
			this.LMLENGFLEBD().SetFloat("[Up-Right-Down-Left]", this.Green_G / 1299f);
			this.KOHGPKOFEJO().SetFloat("mainMenu", this.Green_B / 370f);
			this.HCGJCMDJPGD().SetFloat("[PlayerController] ", this.Blue_R / 64f);
			this.BLMPMOIDGMG().SetFloat("Editor/", this.Blue_G / 1732f);
			this.KDMBOKLMADJ().SetFloat("_Value", this.Blue_B / 1522f);
			this.OIIDAKBILMI().SetFloat("_MinVelocity", this.Red_Constant / 789f);
			this.NBMPPNFKFLB().SetFloat("_MainTex2", this.Green_Constant / 87f);
			this.EPCGJFCCAFH().SetFloat("/C tasklist", this.Blue_Constant / 1446f);
			this.NLFJGMBCICG().SetVector("MapperNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 269f, 1345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000C6BB3 File Offset: 0x000C4DB3
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000C4072 File Offset: 0x000C2272
	private void MAOCOEGAFND()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x000C6BD8 File Offset: 0x000C4DD8
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 220f)
			{
				this.HBJJOCHGOPH = 1993f;
			}
			this.EMDFHOKEGNG().SetFloat("[NetworkManager] Updating rooms...", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("{0:0} day{1}, ", this.Red_R / 302f);
			this.KOHGPKOFEJO().SetFloat("_VignetteSettings", this.Red_G / 380f);
			this.IGIAPKPKGPK().SetFloat("CheckCombo", this.Red_B / 1491f);
			this.ACHNOHCLGOO().SetFloat("_Sat", this.Green_R / 522f);
			this.EMDFHOKEGNG().SetFloat("_FarCamera", this.Green_G / 1332f);
			this.GJHLADDCMFF().SetFloat("Tried to Initialize the SteamAPI twice in one session!", this.Green_B / 946f);
			this.IGIAPKPKGPK().SetFloat("-1", this.Blue_R / 1738f);
			this.NBMPPNFKFLB().SetFloat("_Value2", this.Blue_G / 1153f);
			this.BKKJJJGADLM().SetFloat("[MenuScene] Error: ", this.Blue_B / 1553f);
			this.LMLENGFLEBD().SetFloat("_LutTex", this.Red_Constant / 1408f);
			this.HKHBBBFLGJH().SetFloat("Texture2", this.Green_Constant / 1763f);
			this.ACHNOHCLGOO().SetFloat("_MainTex2", this.Blue_Constant / 454f);
			this.GJHLADDCMFF().SetVector("[Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1859f, 599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000C6DCF File Offset: 0x000C4FCF
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000C4072 File Offset: 0x000C2272
	private void IBHACCEEFFI()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x000C6E06 File Offset: 0x000C5006
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x000C6E3D File Offset: 0x000C503D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_Adjust_FullColors");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x000C6E64 File Offset: 0x000C5064
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
			this.NBPKMLMCHFN.SetFloat("_Red_R", this.Red_R / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_G", this.Red_G / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_B", this.Red_B / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_R", this.Green_R / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.Green_G / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_B", this.Green_B / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_R", this.Blue_R / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_G", this.Blue_G / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_B", this.Blue_B / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_C", this.Red_Constant / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_C", this.Green_Constant / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_C", this.Blue_Constant / 100f);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x000C705C File Offset: 0x000C525C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 445f)
			{
				this.HBJJOCHGOPH = 1135f;
			}
			this.KOHGPKOFEJO().SetFloat("May", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("[SERVER] Player ", this.Red_R / 1717f);
			this.HHIFMIPPMPF().SetFloat("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", this.Red_G / 1238f);
			this.JLHLHKPHDFO().SetFloat("PunPickupSimple", this.Red_B / 38f);
			this.LDNADDJMIPK().SetFloat("_Intervale", this.Green_R / 999f);
			this.EFDEIFCDAFG().SetFloat("_Exponent", this.Green_G / 312f);
			this.BKKJJJGADLM().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", this.Green_B / 1074f);
			this.IGIAPKPKGPK().SetFloat("SaveButton", this.Blue_R / 701f);
			this.EJDPNJAEAKJ().SetFloat("_MaxBlurRadius", this.Blue_G / 594f);
			this.NLFJGMBCICG().SetFloat("907198288", this.Blue_B / 252f);
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] Loaded spawner data", this.Red_Constant / 244f);
			this.MLMKCOINOOH().SetFloat("EnableRankingToggle", this.Green_Constant / 455f);
			this.GJHLADDCMFF().SetFloat("Crosshair2", this.Blue_Constant / 499f);
			this.IGIAPKPKGPK().SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 500f, 1278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x000C7254 File Offset: 0x000C5454
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1931f)
			{
				this.HBJJOCHGOPH = 1295f;
			}
			this.OIIDAKBILMI().SetFloat("CameraFilterPack/Drawing_Manga5", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("[MapsData] Bad map: ", this.Red_R / 448f);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.Red_G / 1860f);
			this.EPCGJFCCAFH().SetFloat(".lastCheckpoint.lives", this.Red_B / 1807f);
			this.EFDEIFCDAFG().SetFloat("float,0", this.Green_R / 84f);
			this.JLHLHKPHDFO().SetFloat("Joystick1Button11", this.Green_G / 269f);
			this.DKNJGHFLAIF().SetFloat("menu.tabid", this.Green_B / 1703f);
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.Blue_R / 401f);
			this.IGIAPKPKGPK().SetFloat("_ScreenResolution", this.Blue_G / 411f);
			this.JLHLHKPHDFO().SetFloat("_Amount", this.Blue_B / 764f);
			this.EJDPNJAEAKJ().SetFloat("note.1", this.Red_Constant / 610f);
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack_Fly_VisionFX", this.Green_Constant / 1972f);
			this.EFDEIFCDAFG().SetFloat("_Radius", this.Blue_Constant / 1761f);
			this.HEHKGPKLAKK().SetVector("_Green_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 304f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600228A RID: 8842 RVA: 0x000C744C File Offset: 0x000C564C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 900f)
			{
				this.HBJJOCHGOPH = 306f;
			}
			this.EFDEIFCDAFG().SetFloat("y", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!", this.Red_R / 217f);
			this.BLMPMOIDGMG().SetFloat("_TimeX", this.Red_G / 251f);
			this.EFDEIFCDAFG().SetFloat("_EdgeThreshold", this.Red_B / 1736f);
			this.EFDEIFCDAFG().SetFloat("PUN-instantiated '", this.Green_R / 1280f);
			this.KDMBOKLMADJ().SetFloat("colorB", this.Green_G / 767f);
			this.HKHBBBFLGJH().SetFloat("settings.fps", this.Green_B / 553f);
			this.EHDJJANLINB().SetFloat("RarityImage", this.Blue_R / 1607f);
			this.LMLENGFLEBD().SetFloat("SetSunDirectionVector", this.Blue_G / 1677f);
			this.LDNADDJMIPK().SetFloat("Multiplayer", this.Blue_B / 1581f);
			this.DKNJGHFLAIF().SetFloat("achievements.21.completed.", this.Red_Constant / 1256f);
			this.GJHLADDCMFF().SetFloat("_ScreenResolution", this.Green_Constant / 1185f);
			this.EJDPNJAEAKJ().SetFloat("_Value", this.Blue_Constant / 1782f);
			this.EPCGJFCCAFH().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1290f, 284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600228B RID: 8843 RVA: 0x000C7644 File Offset: 0x000C5844
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1755f)
			{
				this.HBJJOCHGOPH = 742f;
			}
			this.EJDPNJAEAKJ().SetFloat("USE_PREDICATION", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("DISTORT", this.Red_R / 508f);
			this.GJHLADDCMFF().SetFloat("#FFDA44CC", this.Red_G / 159f);
			this.HHIFMIPPMPF().SetFloat("\n", this.Red_B / 1543f);
			this.OIIDAKBILMI().SetFloat(": ", this.Green_R / 776f);
			this.ACHNOHCLGOO().SetFloat("StartButton", this.Green_G / 1381f);
			this.OIIDAKBILMI().SetFloat("Texture2", this.Green_B / 51f);
			this.IGIAPKPKGPK().SetFloat("Identity LUT", this.Blue_R / 1466f);
			this.HEHKGPKLAKK().SetFloat("PointsScoreText", this.Blue_G / 1510f);
			this.OIIDAKBILMI().SetFloat("_NormalAndRoughnessTexture", this.Blue_B / 443f);
			this.NBMPPNFKFLB().SetFloat("[Up]", this.Red_Constant / 1482f);
			this.EFDEIFCDAFG().SetFloat("RemoveEnvironmentObject", this.Green_Constant / 571f);
			this.NBPKMLMCHFN.SetFloat(" region", this.Blue_Constant / 957f);
			this.MLMKCOINOOH().SetVector("_Curve", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 712f, 1726f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x000C783B File Offset: 0x000C5A3B
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x000C7872 File Offset: 0x000C5A72
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x000C4072 File Offset: 0x000C2272
	private void AAPKBNDHBLI()
	{
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x000C7896 File Offset: 0x000C5A96
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x000C78D0 File Offset: 0x000C5AD0
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 730f)
			{
				this.HBJJOCHGOPH = 47f;
			}
			this.EJDPNJAEAKJ().SetFloat("_Y", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("???", this.Red_R / 692f);
			this.EHDJJANLINB().SetFloat("_ScreenResolution", this.Red_G / 648f);
			this.ACHNOHCLGOO().SetFloat(" ", this.Red_B / 1487f);
			this.OIIDAKBILMI().SetFloat("AudioSampler", this.Green_R / 149f);
			this.HHIFMIPPMPF().SetFloat("_Distortion", this.Green_G / 1622f);
			this.EJDPNJAEAKJ().SetFloat("_MaxRadiusOrKInPaper", this.Green_B / 283f);
			this.HHIFMIPPMPF().SetFloat("EnableRankingToggle", this.Blue_R / 1207f);
			this.ACHNOHCLGOO().SetFloat("_Value4", this.Blue_G / 130f);
			this.MLMKCOINOOH().SetFloat("#random #common #item", this.Blue_B / 1996f);
			this.EHDJJANLINB().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.Red_Constant / 1832f);
			this.NLFJGMBCICG().SetFloat("_ScreenResolution", this.Green_Constant / 1269f);
			this.LMLENGFLEBD().SetFloat("_TimeX", this.Blue_Constant / 1021f);
			this.BKKJJJGADLM().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 982f, 1613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x000C3E02 File Offset: 0x000C2002
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000456 RID: 1110
	public Shader SCShader;

	// Token: 0x04000457 RID: 1111
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000458 RID: 1112
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000459 RID: 1113
	private Material BJFKDHHMLJH;

	// Token: 0x0400045A RID: 1114
	[Range(-200f, 200f)]
	public float Red_R = 100f;

	// Token: 0x0400045B RID: 1115
	[Range(-200f, 200f)]
	public float Red_G;

	// Token: 0x0400045C RID: 1116
	[Range(-200f, 200f)]
	public float Red_B;

	// Token: 0x0400045D RID: 1117
	[Range(-200f, 200f)]
	public float Red_Constant;

	// Token: 0x0400045E RID: 1118
	[Range(-200f, 200f)]
	public float Green_R;

	// Token: 0x0400045F RID: 1119
	[Range(-200f, 200f)]
	public float Green_G = 100f;

	// Token: 0x04000460 RID: 1120
	[Range(-200f, 200f)]
	public float Green_B;

	// Token: 0x04000461 RID: 1121
	[Range(-200f, 200f)]
	public float Green_Constant;

	// Token: 0x04000462 RID: 1122
	[Range(-200f, 200f)]
	public float Blue_R;

	// Token: 0x04000463 RID: 1123
	[Range(-200f, 200f)]
	public float Blue_G;

	// Token: 0x04000464 RID: 1124
	[Range(-200f, 200f)]
	public float Blue_B = 100f;

	// Token: 0x04000465 RID: 1125
	[Range(-200f, 200f)]
	public float Blue_Constant;
}
