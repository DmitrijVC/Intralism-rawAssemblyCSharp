using System;
using UnityEngine;

// Token: 0x02000029 RID: 41
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Snow")]
public class CameraFilterPack_3D_Snow : MonoBehaviour
{
	// Token: 0x06000A79 RID: 2681 RVA: 0x0004FF8C File Offset: 0x0004E18C
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1783f)
			{
				this.HBJJOCHGOPH = 815f;
			}
			this.KLKILLCHJHO().SetFloat("]", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button0", this.Fade);
			this.MCDGIILBNIF().SetFloat("[Right]", this.Intensity);
			this.HKHBBBFLGJH().SetFloat("_Distortion", this.Speed * 957f);
			this.HKHBBBFLGJH().SetFloat("System.Boolean", this.Size);
			this.NKBIEMJBCBM().SetFloat("HiddenToggle", (float)((!this._Visualize) ? 0 : 0));
			this.ADAFMBOGPLN().SetFloat("CameraFilterPack/Color_YUV", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("[MapEditor] Exported to ", this.Snow_Near);
			this.FAIFBBGFAIB().SetFloat("steamid", this.Snow_Far);
			this.IGKFMCPDNOI().SetFloat("other.dust0", this.SnowWithoutObject);
			this.KLKILLCHJHO().SetVector("Texture2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1989f, 1905f));
			this.NKBIEMJBCBM().SetTexture("_BlurFilterDistance", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x0002523B File Offset: 0x0002343B
	private void CNGAJDBOCLJ()
	{
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x0002523B File Offset: 0x0002343B
	private void JKBMKPDGCHG()
	{
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKLOBJHKFEO()
	{
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x0002523B File Offset: 0x0002343B
	private void PAKPHKPDKGE()
	{
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x000501A6 File Offset: 0x0004E3A6
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x000501E0 File Offset: 0x0004E3E0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 907f)
			{
				this.HBJJOCHGOPH = 1210f;
			}
			this.LPPEPKGFOEM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/Vision_Drost", this.Fade);
			this.IOHHLNAPGMA().SetFloat("Set Arcs Speed", this.Intensity);
			this.IGKFMCPDNOI().SetFloat("_ColorLevel", this.Speed * 1813f);
			this.MCDGIILBNIF().SetFloat("Joined room ", this.Size);
			this.EFMCNLELMDO().SetFloat("SupportLogger OnApplicationPause: ", (float)((!this._Visualize) ? 1 : 1));
			this.BAGICADFBAB().SetFloat("x", this._FixDistance);
			this.IGKFMCPDNOI().SetFloat("_RedAmplifier", this.Snow_Near);
			this.OCHJIMJNEMO().SetFloat("UseFinalGlassColor", this.Snow_Far);
			this.OCHJIMJNEMO().SetFloat("_TintColor", this.SnowWithoutObject);
			this.DOHGBNPMBKG().SetVector("MenuScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 159f, 1657f));
			this.KLKILLCHJHO().SetTexture("close", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00050382 File Offset: 0x0004E582
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x000503BC File Offset: 0x0004E5BC
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 9f)
			{
				this.HBJJOCHGOPH = 502f;
			}
			this.INOBFNCKFGK().SetFloat("player.currentrank", this.HBJJOCHGOPH);
			this.ILKALHDJBFE().SetFloat("{0:0} minute{1}, ", this.Fade);
			this.OCHJIMJNEMO().SetFloat("GlassesColor", this.Intensity);
			this.IOHHLNAPGMA().SetFloat("LevelNameInputField", this.Speed * 24f);
			this.LMLENGFLEBD().SetFloat("_Near", this.Size);
			this.NDMPCDHADMJ().SetFloat("DISTORT", (float)((!this._Visualize) ? 1 : 0));
			this.MCDGIILBNIF().SetFloat("RarityImage", this._FixDistance);
			this.BAGICADFBAB().SetFloat("_TimeX", this.Snow_Near);
			this.LPPEPKGFOEM().SetFloat("SetSpeed", this.Snow_Far);
			this.NBPKMLMCHFN.SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", this.SnowWithoutObject);
			this.KLKILLCHJHO().SetVector("Dec", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1974f, 1079f));
			this.MCDGIILBNIF().SetTexture("_Red_B", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x0002523B File Offset: 0x0002343B
	private void DAHFFNNIGML()
	{
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x0005055E File Offset: 0x0004E75E
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x0005057C File Offset: 0x0004E77C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1010f)
			{
				this.HBJJOCHGOPH = 213f;
			}
			this.NKBIEMJBCBM().SetFloat("_ChannelMixerBlue", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_ScreenResolution", this.Fade);
			this.DOHGBNPMBKG().SetFloat("yes", this.Intensity);
			this.FEAEGGCNIAA().SetFloat("Editor/", this.Speed * 305f);
			this.DOHGBNPMBKG().SetFloat("_LightIntensity", this.Size);
			this.ILKALHDJBFE().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 0 : 1));
			this.DOHGBNPMBKG().SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", this._FixDistance);
			this.LPPEPKGFOEM().SetFloat("_Bullet_9", this.Snow_Near);
			this.NKBIEMJBCBM().SetFloat("SetSpeed", this.Snow_Far);
			this.CECJJMKLEAK().SetFloat("BlockCount", this.SnowWithoutObject);
			this.HFBJAOFLCJI().SetVector("restrictions\n\n#until: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1524f, 1059f));
			this.INOBFNCKFGK().SetTexture("#updateoutdatedmap", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKFDNIAKGEO()
	{
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGEJKLMJGDO()
	{
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00050720 File Offset: 0x0004E920
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
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed * 6f);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Drop_Near", this.Snow_Near);
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.Snow_Far);
			this.NBPKMLMCHFN.SetFloat("Drop_With_Obj", this.SnowWithoutObject);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x000508C2 File Offset: 0x0004EAC2
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x0002523B File Offset: 0x0002343B
	private void MGMAOBPPOBJ()
	{
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x0002523B File Offset: 0x0002343B
	private void DKOPKPBLDHH()
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x000508F9 File Offset: 0x0004EAF9
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0005055E File Offset: 0x0004E75E
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00050930 File Offset: 0x0004EB30
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0005055E File Offset: 0x0004E75E
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00050968 File Offset: 0x0004EB68
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 152f)
			{
				this.HBJJOCHGOPH = 1664f;
			}
			this.MCDGIILBNIF().SetFloat("[SteamManager] Connection established, authorization", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("System.Boolean", this.Fade);
			this.DOHGBNPMBKG().SetFloat("ItemsCountText", this.Intensity);
			this.IOHHLNAPGMA().SetFloat("[PlayerBase] Loaded environment: ", this.Speed * 1739f);
			this.DOHGBNPMBKG().SetFloat("LevelProgressBar", this.Size);
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", (float)((!this._Visualize) ? 1 : 0));
			this.IOHHLNAPGMA().SetFloat("SetSatelliteTrailMinVertexDistance", this._FixDistance);
			this.ADAFMBOGPLN().SetFloat("?", this.Snow_Near);
			this.INOBFNCKFGK().SetFloat("_TimeX", this.Snow_Far);
			this.DOHGBNPMBKG().SetFloat("_Val", this.SnowWithoutObject);
			this.NKBIEMJBCBM().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 321f, 36f));
			this.LMLENGFLEBD().SetTexture("QuickSave", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00050B0A File Offset: 0x0004ED0A
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0002523B File Offset: 0x0002343B
	private void FANADGBGCPI()
	{
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x0002523B File Offset: 0x0002343B
	private void EFJDNLGNACH()
	{
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x0002523B File Offset: 0x0002343B
	private void JKFDDNMPOJH()
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMKBLLMIKAB()
	{
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKDNLHLBHID()
	{
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x0002523B File Offset: 0x0002343B
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x0002523B File Offset: 0x0002343B
	private void JECMJNFGBGC()
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00050B44 File Offset: 0x0004ED44
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1029f)
			{
				this.HBJJOCHGOPH = 1245f;
			}
			this.CECJJMKLEAK().SetFloat("[LocalizationService] Localization: ", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("string", this.Fade);
			this.ADBKPGFMNKO().SetFloat("skin.", this.Intensity);
			this.HFBJAOFLCJI().SetFloat("#close", this.Speed * 1279f);
			this.NFMGLIKNOOC().SetFloat("_Amount", this.Size);
			this.HHIAIGCAHDA().SetFloat("Y", (float)((!this._Visualize) ? 0 : 0));
			this.IOHHLNAPGMA().SetFloat("id", this._FixDistance);
			this.LMLENGFLEBD().SetFloat("_Value", this.Snow_Near);
			this.KLKILLCHJHO().SetFloat("_Value2", this.Snow_Far);
			this.HHIFMIPPMPF().SetFloat(".completedMaps", this.SnowWithoutObject);
			this.HKHBBBFLGJH().SetVector("LostLive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 772f, 1965f));
			this.LPPEPKGFOEM().SetTexture("CameraFilterPack/Distortion_ShockWaveManual", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00050CE8 File Offset: 0x0004EEE8
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1621f)
			{
				this.HBJJOCHGOPH = 1424f;
			}
			this.KLKILLCHJHO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_Blue_C", this.Fade);
			this.BKKJJJGADLM().SetFloat("_MainTex2", this.Intensity);
			this.KLKILLCHJHO().SetFloat("#score", this.Speed * 1565f);
			this.ADBKPGFMNKO().SetFloat("_ScreenResolution", this.Size);
			this.OCHJIMJNEMO().SetFloat("[Left]", (float)((!this._Visualize) ? 0 : 0));
			this.NFMGLIKNOOC().SetFloat("on master", this._FixDistance);
			this.IOHHLNAPGMA().SetFloat("' found!", this.Snow_Near);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Snow_Far);
			this.IOHHLNAPGMA().SetFloat("_Value", this.SnowWithoutObject);
			this.IGKFMCPDNOI().SetVector("_RandomTexture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1763f, 679f));
			this.INOBFNCKFGK().SetTexture("[MapsSystem] Unloading maps resources...", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00050E8C File Offset: 0x0004F08C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 227f)
			{
				this.HBJJOCHGOPH = 1425f;
			}
			this.NFMGLIKNOOC().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("Failed to InstantiateSceneObject prefab: ", this.Fade);
			this.ADBKPGFMNKO().SetFloat("_RampOffset", this.Intensity);
			this.ADBKPGFMNKO().SetFloat("[Left]", this.Speed * 1250f);
			this.FEAEGGCNIAA().SetFloat("_Value2", this.Size);
			this.OCHJIMJNEMO().SetFloat(" user's map(s)", (float)((!this._Visualize) ? 0 : 1));
			this.EFMCNLELMDO().SetFloat("Data/Editor/leveltemplate", this._FixDistance);
			this.BAGICADFBAB().SetFloat("Tab1Content", this.Snow_Near);
			this.FAIFBBGFAIB().SetFloat(" scene: ", this.Snow_Far);
			this.MCDGIILBNIF().SetFloat("_PColor2", this.SnowWithoutObject);
			this.LPPEPKGFOEM().SetVector("InfoButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1107f, 27f));
			this.LMLENGFLEBD().SetTexture("(master)", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00051030 File Offset: 0x0004F230
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 807f)
			{
				this.HBJJOCHGOPH = 1876f;
			}
			this.HHIFMIPPMPF().SetFloat("0,7,true,0", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat(".sav", this.Fade);
			this.BAGICADFBAB().SetFloat("_PColor", this.Intensity);
			this.FEAEGGCNIAA().SetFloat("status", this.Speed * 1042f);
			this.MCDGIILBNIF().SetFloat("Set particles audio input", this.Size);
			this.OCHJIMJNEMO().SetFloat("_Alpha", (float)((!this._Visualize) ? 1 : 1));
			this.DOHGBNPMBKG().SetFloat("_ScreenResolution", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("X2", this.Snow_Near);
			this.NBPKMLMCHFN.SetFloat("float,10", this.Snow_Far);
			this.ILKALHDJBFE().SetFloat("Down ", this.SnowWithoutObject);
			this.BKKJJJGADLM().SetVector("EventMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 16f, 1744f));
			this.IOHHLNAPGMA().SetTexture("Save level before uploading?", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0005055E File Offset: 0x0004E75E
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x000511D2 File Offset: 0x0004F3D2
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x0005120C File Offset: 0x0004F40C
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1524f)
			{
				this.HBJJOCHGOPH = 157f;
			}
			this.BAGICADFBAB().SetFloat(" takes from: ", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("Scene", this.Fade);
			this.ILKALHDJBFE().SetFloat("Editor/", this.Intensity);
			this.NDMPCDHADMJ().SetFloat("_Value4", this.Speed * 1159f);
			this.NDMPCDHADMJ().SetFloat("ItemNameBGImage", this.Size);
			this.HFBJAOFLCJI().SetFloat("\" error: ", (float)((!this._Visualize) ? 0 : 0));
			this.IOHHLNAPGMA().SetFloat("Object ID. Case-Sensitive", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("_DiffuseColor", this.Snow_Near);
			this.LMLENGFLEBD().SetFloat("DataText", this.Snow_Far);
			this.FAIFBBGFAIB().SetFloat("[GameEvent] Exeption:", this.SnowWithoutObject);
			this.IOHHLNAPGMA().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1f, 212f));
			this.NKBIEMJBCBM().SetTexture("[#clicktoacceptchallenge]", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0005055E File Offset: 0x0004E75E
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x0005055E File Offset: 0x0004E75E
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x000513AE File Offset: 0x0004F5AE
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x000513E8 File Offset: 0x0004F5E8
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 570f)
			{
				this.HBJJOCHGOPH = 897f;
			}
			this.KLKILLCHJHO().SetFloat(":\n", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("_Fade", this.Fade);
			this.HHIFMIPPMPF().SetFloat("#timeuntilchallenge: ", this.Intensity);
			this.IGKFMCPDNOI().SetFloat("_Value2", this.Speed * 536f);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.Size);
			this.HHIAIGCAHDA().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", (float)((!this._Visualize) ? 1 : 1));
			this.HHIFMIPPMPF().SetFloat("menu.tabid", this._FixDistance);
			this.NDMPCDHADMJ().SetFloat("LevelConfigButton", this.Snow_Near);
			this.IOHHLNAPGMA().SetFloat("_Green_R", this.Snow_Far);
			this.BAGICADFBAB().SetFloat("_Value2", this.SnowWithoutObject);
			this.LMLENGFLEBD().SetVector(".played", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 721f, 1021f));
			this.LMLENGFLEBD().SetTexture("_BlurFilterDistance", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKOMIDCPCDC()
	{
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x0005055E File Offset: 0x0004E75E
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x0002523B File Offset: 0x0002343B
	private void JABNHMIHBHC()
	{
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0005158C File Offset: 0x0004F78C
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1060f)
			{
				this.HBJJOCHGOPH = 955f;
			}
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("[SoundManager] Loaded skin audio", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Set Satellite Radius", this.Intensity);
			this.MMOODGIODPC().SetFloat("Tab2Content", this.Speed * 1948f);
			this.ADAFMBOGPLN().SetFloat("_Value3", this.Size);
			this.ACHNOHCLGOO().SetFloat("_Red_C", (float)((!this._Visualize) ? 0 : 1));
			this.LPPEPKGFOEM().SetFloat("0 - background, 1 - foreground", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("player.xp", this.Snow_Near);
			this.OCHJIMJNEMO().SetFloat("Load scene by name or build id", this.Snow_Far);
			this.NFMGLIKNOOC().SetFloat("skin.", this.SnowWithoutObject);
			this.MMOODGIODPC().SetVector("_MainTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1682f, 1863f));
			this.NFMGLIKNOOC().SetTexture(" to: ", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x0005055E File Offset: 0x0004E75E
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x0005172E File Offset: 0x0004F92E
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODBNMPGBCGO()
	{
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00051768 File Offset: 0x0004F968
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1711f)
			{
				this.HBJJOCHGOPH = 5f;
			}
			this.ILKALHDJBFE().SetFloat("Fade", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("Fill", this.Fade);
			this.ACHNOHCLGOO().SetFloat("_MainTex2", this.Intensity);
			this.LPPEPKGFOEM().SetFloat("StartButton", this.Speed * 1390f);
			this.HFBJAOFLCJI().SetFloat("SlidingArea", this.Size);
			this.ADAFMBOGPLN().SetFloat("_EdgeSharpness", (float)((!this._Visualize) ? 1 : 1));
			this.KLKILLCHJHO().SetFloat("_LightIntensity", this._FixDistance);
			this.BKKJJJGADLM().SetFloat("menutheme.idunno", this.Snow_Near);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.Snow_Far);
			this.ILKALHDJBFE().SetFloat("Right", this.SnowWithoutObject);
			this.ADAFMBOGPLN().SetVector("_BlurVector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 510f, 1867f));
			this.NKBIEMJBCBM().SetTexture("_Amount", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPLLKHHLDBB()
	{
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x0002523B File Offset: 0x0002343B
	private void HJPCJGOEKMF()
	{
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x0005190A File Offset: 0x0004FB0A
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0005055E File Offset: 0x0004E75E
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00051941 File Offset: 0x0004FB41
	private Material NKBIEMJBCBM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x0005055E File Offset: 0x0004E75E
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMPGIFBJFIK()
	{
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00051978 File Offset: 0x0004FB78
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x0005055E File Offset: 0x0004E75E
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x000519B0 File Offset: 0x0004FBB0
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1927f)
			{
				this.HBJJOCHGOPH = 1608f;
			}
			this.OCHJIMJNEMO().SetFloat("settings_bindings_controller_type", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("_Value5", this.Fade);
			this.NFMGLIKNOOC().SetFloat("http", this.Intensity);
			this.NKBIEMJBCBM().SetFloat("_ReprojectionMatrix", this.Speed * 133f);
			this.LPPEPKGFOEM().SetFloat("SpawnObj", this.Size);
			this.FEAEGGCNIAA().SetFloat("/", (float)((!this._Visualize) ? 0 : 0));
			this.BKKJJJGADLM().SetFloat("_Value", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("arc", this.Snow_Near);
			this.ADAFMBOGPLN().SetFloat("B:", this.Snow_Far);
			this.IOHHLNAPGMA().SetFloat("id", this.SnowWithoutObject);
			this.IOHHLNAPGMA().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1474f, 1234f));
			this.EFMCNLELMDO().SetTexture("SelectorMusicToggle", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00051B52 File Offset: 0x0004FD52
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00051B89 File Offset: 0x0004FD89
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x0005055E File Offset: 0x0004E75E
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00051BC0 File Offset: 0x0004FDC0
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIMNPCMHJLJ()
	{
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x0002523B File Offset: 0x0002343B
	private void GNJDKAECPKA()
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00051BF8 File Offset: 0x0004FDF8
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 771f)
			{
				this.HBJJOCHGOPH = 556f;
			}
			this.IGKFMCPDNOI().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.Fade);
			this.LMLENGFLEBD().SetFloat("UI Extensions/UISoftAdditive", this.Intensity);
			this.KLKILLCHJHO().SetFloat("_ScreenResolution", this.Speed * 1476f);
			this.HFBJAOFLCJI().SetFloat("[Right]", this.Size);
			this.ACHNOHCLGOO().SetFloat("BitsData", (float)((!this._Visualize) ? 1 : 0));
			this.ADBKPGFMNKO().SetFloat("[SteamManager] Connecting to server", this._FixDistance);
			this.ILKALHDJBFE().SetFloat("_Offsets", this.Snow_Near);
			this.NKBIEMJBCBM().SetFloat("VisionBlur", this.Snow_Far);
			this.IOHHLNAPGMA().SetFloat("_Bullet_12", this.SnowWithoutObject);
			this.ILKALHDJBFE().SetVector("finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1462f, 890f));
			this.DOHGBNPMBKG().SetTexture("_ScreenResolution", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x0002523B File Offset: 0x0002343B
	private void CEDFFAOOPOG()
	{
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00051D9A File Offset: 0x0004FF9A
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00051DD1 File Offset: 0x0004FFD1
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00051E08 File Offset: 0x00050008
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 179f)
			{
				this.HBJJOCHGOPH = 787f;
			}
			this.MCDGIILBNIF().SetFloat(".lastCheckpoint.powerupsScore", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("isVisible", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			this.HHIFMIPPMPF().SetFloat("SetParticlesParticleSize", this.Speed * 545f);
			this.MCDGIILBNIF().SetFloat("EnvironmentSlider", this.Size);
			this.ADBKPGFMNKO().SetFloat("http", (float)((!this._Visualize) ? 0 : 1));
			this.NDMPCDHADMJ().SetFloat("The other scroll rect doesnt support scrolling vertically", this._FixDistance);
			this.HHIAIGCAHDA().SetFloat("BitsData", this.Snow_Near);
			this.INOBFNCKFGK().SetFloat("Set Background Color", this.Snow_Far);
			this.ACHNOHCLGOO().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.SnowWithoutObject);
			this.BKKJJJGADLM().SetVector("STICKLHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1505f, 817f));
			this.DOHGBNPMBKG().SetTexture(".completed", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x0002523B File Offset: 0x0002343B
	private void ICILLMAKLMI()
	{
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDMANOEMOCA()
	{
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00051FAA File Offset: 0x000501AA
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x0005055E File Offset: 0x0004E75E
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCNPAKFAFOE()
	{
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x0005055E File Offset: 0x0004E75E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x0005055E File Offset: 0x0004E75E
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x0005055E File Offset: 0x0004E75E
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0005055E File Offset: 0x0004E75E
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x0005055E File Offset: 0x0004E75E
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00051FE1 File Offset: 0x000501E1
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x0005055E File Offset: 0x0004E75E
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x0002523B File Offset: 0x0002343B
	private void LIBGAKMKHJJ()
	{
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOHOFNKJDEB()
	{
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0002523B File Offset: 0x0002343B
	private void DIPDEHOOBPG()
	{
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00052018 File Offset: 0x00050218
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00052050 File Offset: 0x00050250
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 556f)
			{
				this.HBJJOCHGOPH = 472f;
			}
			this.BKKJJJGADLM().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("Item creation successful! Published Item ID: ", this.Fade);
			this.IOHHLNAPGMA().SetFloat("ItemNameText", this.Intensity);
			this.HHIFMIPPMPF().SetFloat("SetSatelliteTrailWidth", this.Speed * 87f);
			this.LMLENGFLEBD().SetFloat("Can't set Room.MaxPlayers to: ", this.Size);
			this.ADAFMBOGPLN().SetFloat("#no", (float)((!this._Visualize) ? 1 : 1));
			this.ADAFMBOGPLN().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", this._FixDistance);
			this.ILKALHDJBFE().SetFloat("_Value", this.Snow_Near);
			this.CECJJMKLEAK().SetFloat("-", this.Snow_Far);
			this.EFMCNLELMDO().SetFloat("_Distortion", this.SnowWithoutObject);
			this.NKBIEMJBCBM().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 721f, 193f));
			this.ILKALHDJBFE().SetTexture("SpawnObj", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x000521F2 File Offset: 0x000503F2
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00052229 File Offset: 0x00050429
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x0005055E File Offset: 0x0004E75E
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0005055E File Offset: 0x0004E75E
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00052260 File Offset: 0x00050460
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 243f)
			{
				this.HBJJOCHGOPH = 217f;
			}
			this.FAIFBBGFAIB().SetFloat("#obtained", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_TimeX", this.Fade);
			this.KLKILLCHJHO().SetFloat("SetParticlesEmission", this.Intensity);
			this.ADAFMBOGPLN().SetFloat("#tryagain", this.Speed * 786f);
			this.NDMPCDHADMJ().SetFloat("mapselector.orderby", this.Size);
			this.IOHHLNAPGMA().SetFloat("_TimeX", (float)((!this._Visualize) ? 1 : 1));
			this.OCHJIMJNEMO().SetFloat("_Value5", this._FixDistance);
			this.HHIFMIPPMPF().SetFloat("_ReprojectionMatrix", this.Snow_Near);
			this.HHIFMIPPMPF().SetFloat("_TileTexDebug", this.Snow_Far);
			this.OCHJIMJNEMO().SetFloat("RecordButton", this.SnowWithoutObject);
			this.IOHHLNAPGMA().SetVector("#or", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1653f, 1787f));
			this.NBPKMLMCHFN.SetTexture("No regions available. Are you sure your appid is valid and setup?", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00052404 File Offset: 0x00050604
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1235f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.DOHGBNPMBKG().SetFloat("Lerp speed. Recomended 10", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("_VignetteCenter", this.Fade);
			this.MCDGIILBNIF().SetFloat("???", this.Intensity);
			this.HKHBBBFLGJH().SetFloat(" in SaveLoadMenu.prefabDictionary!", this.Speed * 666f);
			this.INOBFNCKFGK().SetFloat("turn", this.Size);
			this.NFMGLIKNOOC().SetFloat("#scoresubmitionfailed: ", (float)((!this._Visualize) ? 0 : 0));
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack/Oculus_NightVision5", this._FixDistance);
			this.EFMCNLELMDO().SetFloat("menu.selectedplaymode", this.Snow_Near);
			this.ACHNOHCLGOO().SetFloat("ticket.ticket1", this.Snow_Far);
			this.ACHNOHCLGOO().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", this.SnowWithoutObject);
			this.EFMCNLELMDO().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 448f, 384f));
			this.NKBIEMJBCBM().SetTexture("_Blue_R", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x000525A8 File Offset: 0x000507A8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1115f)
			{
				this.HBJJOCHGOPH = 1601f;
			}
			this.ADAFMBOGPLN().SetFloat("_DistanceParams", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Editor/", this.Fade);
			this.BAGICADFBAB().SetFloat("_BlurArea", this.Intensity);
			this.BKKJJJGADLM().SetFloat("_EmissionGain", this.Speed * 1981f);
			this.FEAEGGCNIAA().SetFloat("1177138211", this.Size);
			this.MCDGIILBNIF().SetFloat("Drop_Far", (float)((!this._Visualize) ? 0 : 1));
			this.LMLENGFLEBD().SetFloat("IconImage", this._FixDistance);
			this.FEAEGGCNIAA().SetFloat("https://store.steampowered.com/itemstore/513510/", this.Snow_Near);
			this.EFMCNLELMDO().SetFloat("Can't set Room.MaxPlayers to: ", this.Snow_Far);
			this.EFMCNLELMDO().SetFloat("InventoryGrid", this.SnowWithoutObject);
			this.CECJJMKLEAK().SetVector("#pleasewait", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1335f, 1780f));
			this.MCDGIILBNIF().SetTexture("_ScreenResolution", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x0002523B File Offset: 0x0002343B
	private void COOHIILCOCO()
	{
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x0002523B File Offset: 0x0002343B
	private void OGJJDKENBNC()
	{
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0005274C File Offset: 0x0005094C
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1066f)
			{
				this.HBJJOCHGOPH = 1700f;
			}
			this.NFMGLIKNOOC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("hardcoreinfo", this.Fade);
			this.INOBFNCKFGK().SetFloat("_Value7", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Speed * 1933f);
			this.NKBIEMJBCBM().SetFloat("_Radius", this.Size);
			this.HFBJAOFLCJI().SetFloat("PLAY [SPACE]", (float)((!this._Visualize) ? 1 : 1));
			this.NFMGLIKNOOC().SetFloat("_TimeX", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("SpeedSlider", this.Snow_Near);
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.Snow_Far);
			this.NBPKMLMCHFN.SetFloat("gamemode", this.SnowWithoutObject);
			this.ADBKPGFMNKO().SetVector("GroupNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 419f, 1717f));
			this.EFMCNLELMDO().SetTexture("Circle", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000AEF RID: 2799 RVA: 0x000528EE File Offset: 0x00050AEE
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

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0002523B File Offset: 0x0002343B
	private void JONGNKNLLND()
	{
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x00052928 File Offset: 0x00050B28
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 38f)
			{
				this.HBJJOCHGOPH = 80f;
			}
			this.ILKALHDJBFE().SetFloat("Dance", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("CameraFilterPack_AAA_Blood2", this.Fade);
			this.BKKJJJGADLM().SetFloat("Editor/", this.Intensity);
			this.NDMPCDHADMJ().SetFloat("yes", this.Speed * 1255f);
			this.NDMPCDHADMJ().SetFloat("ResetSpeed", this.Size);
			this.ACHNOHCLGOO().SetFloat("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", (float)((!this._Visualize) ? 0 : 1));
			this.INOBFNCKFGK().SetFloat("_Color_B", this._FixDistance);
			this.INOBFNCKFGK().SetFloat("EventConfigButton", this.Snow_Near);
			this.IGKFMCPDNOI().SetFloat("Connected to gameserver.", this.Snow_Far);
			this.HKHBBBFLGJH().SetFloat("[MapsData] Found ", this.SnowWithoutObject);
			this.INOBFNCKFGK().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1874f, 903f));
			this.NFMGLIKNOOC().SetTexture(" Mb", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00052ACA File Offset: 0x00050CCA
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00052B04 File Offset: 0x00050D04
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1425f)
			{
				this.HBJJOCHGOPH = 624f;
			}
			this.IGKFMCPDNOI().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.ILKALHDJBFE().SetFloat("float,50", this.Fade);
			this.BKKJJJGADLM().SetFloat("ArcsNoHitsoundTimeDelaySlider", this.Intensity);
			this.INOBFNCKFGK().SetFloat("Editor/", this.Speed * 1912f);
			this.BAGICADFBAB().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", this.Size);
			this.IOHHLNAPGMA().SetFloat("D-Pad Right", (float)((!this._Visualize) ? 0 : 0));
			this.FAIFBBGFAIB().SetFloat("GameScene", this._FixDistance);
			this.NFMGLIKNOOC().SetFloat("Sprite", this.Snow_Near);
			this.LPPEPKGFOEM().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this.Snow_Far);
			this.BAGICADFBAB().SetFloat("SupportLogger OnDisconnectedFromPhoton().", this.SnowWithoutObject);
			this.ADAFMBOGPLN().SetVector("1177138211", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 24f, 319f));
			this.MMOODGIODPC().SetTexture("AddEnvironmentObject", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00052CA6 File Offset: 0x00050EA6
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00052CE0 File Offset: 0x00050EE0
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1102f)
			{
				this.HBJJOCHGOPH = 1651f;
			}
			this.IGKFMCPDNOI().SetFloat(" ", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("SetSatelliteRadius", this.Fade);
			this.IGKFMCPDNOI().SetFloat("maps.", this.Intensity);
			this.IGKFMCPDNOI().SetFloat("OneHand", this.Speed * 51f);
			this.LPPEPKGFOEM().SetFloat("_TapMedium", this.Size);
			this.IGKFMCPDNOI().SetFloat("MapEnd", (float)((!this._Visualize) ? 1 : 1));
			this.HKHBBBFLGJH().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", this._FixDistance);
			this.NFMGLIKNOOC().SetFloat("Save", this.Snow_Near);
			this.CECJJMKLEAK().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Snow_Far);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack_TV_Noise3", this.SnowWithoutObject);
			this.ADAFMBOGPLN().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 593f, 524f));
			this.BKKJJJGADLM().SetTexture("_Value3", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00052E84 File Offset: 0x00051084
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 231f)
			{
				this.HBJJOCHGOPH = 1726f;
			}
			this.HKHBBBFLGJH().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("z", this.Fade);
			this.FEAEGGCNIAA().SetFloat("DPADVER", this.Intensity);
			this.FEAEGGCNIAA().SetFloat("_Value12", this.Speed * 211f);
			this.OCHJIMJNEMO().SetFloat("setint", this.Size);
			this.HHIAIGCAHDA().SetFloat("maps.", (float)((!this._Visualize) ? 1 : 1));
			this.FAIFBBGFAIB().SetFloat("_LightIntensity", this._FixDistance);
			this.NDMPCDHADMJ().SetFloat("DisableStoryboardToggle", this.Snow_Near);
			this.HHIAIGCAHDA().SetFloat("_Noise", this.Snow_Far);
			this.ILKALHDJBFE().SetFloat("0.00:0.00", this.SnowWithoutObject);
			this.BKKJJJGADLM().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1968f, 1995f));
			this.DOHGBNPMBKG().SetTexture("request", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMOFEBKGLFI()
	{
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x00053028 File Offset: 0x00051228
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1784f)
			{
				this.HBJJOCHGOPH = 1888f;
			}
			this.BAGICADFBAB().SetFloat("0 seconds", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("MusicFileSelector", this.Fade);
			this.NKBIEMJBCBM().SetFloat("_MainTex2", this.Intensity);
			this.CECJJMKLEAK().SetFloat("Fill Area", this.Speed * 1268f);
			this.LMLENGFLEBD().SetFloat("The observed monobehaviour (", this.Size);
			this.HHIFMIPPMPF().SetFloat("Coord", (float)((!this._Visualize) ? 1 : 1));
			this.DOHGBNPMBKG().SetFloat("steamid", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("_Value6", this.Snow_Near);
			this.LPPEPKGFOEM().SetFloat("_TimeX", this.Snow_Far);
			this.ACHNOHCLGOO().SetFloat("SpawnObj", this.SnowWithoutObject);
			this.INOBFNCKFGK().SetVector("BadgeText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 612f, 1586f));
			this.HHIFMIPPMPF().SetTexture("AvatarImage", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x0002523B File Offset: 0x0002343B
	private void FEKECCBFGMI()
	{
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x000531CA File Offset: 0x000513CA
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x0002523B File Offset: 0x0002343B
	private void FIKFJDFELIP()
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00053204 File Offset: 0x00051404
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 629f)
			{
				this.HBJJOCHGOPH = 451f;
			}
			this.INOBFNCKFGK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.ILKALHDJBFE().SetFloat("</color>", this.Fade);
			this.IGKFMCPDNOI().SetFloat("<color=#", this.Intensity);
			this.BAGICADFBAB().SetFloat("ShowTitle", this.Speed * 35f);
			this.HHIAIGCAHDA().SetFloat("_Value1", this.Size);
			this.HFBJAOFLCJI().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 0));
			this.NKBIEMJBCBM().SetFloat("{0}", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("Joystick1Button7", this.Snow_Near);
			this.FEAEGGCNIAA().SetFloat("CurrentTimeLabel", this.Snow_Far);
			this.BKKJJJGADLM().SetFloat("ok", this.SnowWithoutObject);
			this.NDMPCDHADMJ().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 480f, 70f));
			this.DOHGBNPMBKG().SetTexture("SetSpeed", this.Texture2);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBAJLLFMMMP()
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x0002523B File Offset: 0x0002343B
	private void BKIGIIINEDH()
	{
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0005055E File Offset: 0x0004E75E
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x000533A6 File Offset: 0x000515A6
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x000533DD File Offset: 0x000515DD
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x0400017F RID: 383
	public Shader SCShader;

	// Token: 0x04000180 RID: 384
	public bool _Visualize;

	// Token: 0x04000181 RID: 385
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000182 RID: 386
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000183 RID: 387
	private Material BJFKDHHMLJH;

	// Token: 0x04000184 RID: 388
	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	// Token: 0x04000185 RID: 389
	[Range(-0.5f, 0.99f)]
	public float Snow_Near = 0.08f;

	// Token: 0x04000186 RID: 390
	[Range(0f, 1f)]
	public float Snow_Far = 0.55f;

	// Token: 0x04000187 RID: 391
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000188 RID: 392
	[Range(0f, 2f)]
	public float Intensity = 1f;

	// Token: 0x04000189 RID: 393
	[Range(0f, 2f)]
	public float Size = 1f;

	// Token: 0x0400018A RID: 394
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x0400018B RID: 395
	[Range(0f, 1f)]
	public float SnowWithoutObject = 1f;

	// Token: 0x0400018C RID: 396
	public Texture2D Texture2;
}
