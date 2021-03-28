using System;
using UnityEngine;

// Token: 0x02000022 RID: 34
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Ghost")]
public class CameraFilterPack_3D_Ghost : MonoBehaviour
{
	// Token: 0x06000704 RID: 1796 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00037364 File Offset: 0x00035564
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00037384 File Offset: 0x00035584
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 392f)
			{
				this.HBJJOCHGOPH = 1303f;
			}
			this.LNLKMDPHDCC().SetFloat(".", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("Attempting to remove texture that was not allocated: {0}", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.GhostPosX);
			this.MMOODGIODPC().SetFloat("BitsData", this.GhostPosY);
			this.OIMMPLPBLBK().SetFloat("menu.tabid", this.GhostFade);
			this.BKKJJJGADLM().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.GhostFade2);
			this.FAIFBBGFAIB().SetFloat("inventory.itemscash", this.GhostSize);
			this.BKKJJJGADLM().SetFloat("_InternalLutParams", (float)((!this._Visualize) ? 0 : 1));
			this.CFEDGDGBCHE().SetFloat("_ChangeGreen", this._FixDistance);
			this.NLFJGMBCICG().SetFloat("input", this.Ghost_Near);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Drawing_Comics", this.Ghost_Far);
			this.MICHFGAOPKM().SetFloat("checkpoint", this.GhostWithoutObject);
			this.DKNJGHFLAIF().SetVector("CameraFilterPack/Oculus_NightVision5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 196f, 211f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00037536 File Offset: 0x00035736
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("default");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x0003755A File Offset: 0x0003575A
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00037591 File Offset: 0x00035791
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Luminosity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00037364 File Offset: 0x00035564
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x000375B5 File Offset: 0x000357B5
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x000375EC File Offset: 0x000357EC
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 383f)
			{
				this.HBJJOCHGOPH = 1330f;
			}
			this.OIMMPLPBLBK().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.Intensity);
			this.NLFJGMBCICG().SetFloat(".completed", this.GhostPosX);
			this.FAIFBBGFAIB().SetFloat(" to ", this.GhostPosY);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.GhostFade);
			this.IIJMIPBMMBF().SetFloat("The given 2D texture ", this.GhostFade2);
			this.BKKJJJGADLM().SetFloat("Texture2", this.GhostSize);
			this.MICHFGAOPKM().SetFloat("_Size", (float)((!this._Visualize) ? 0 : 0));
			this.OIMMPLPBLBK().SetFloat(".workshop.json", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Antialiasing_FXAA", this.Ghost_Near);
			this.ABHDNGIHBKE().SetFloat("_Value3", this.Ghost_Far);
			this.NBPKMLMCHFN.SetFloat("powerup.0", this.GhostWithoutObject);
			this.CFEDGDGBCHE().SetVector("SUBMIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1750f, 789f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00037364 File Offset: 0x00035564
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x0003779E File Offset: 0x0003599E
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("Anomaly_With_Obj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x000377C2 File Offset: 0x000359C2
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x000377F9 File Offset: 0x000359F9
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("OnPickedUp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x0003781D File Offset: 0x00035A1D
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00037854 File Offset: 0x00035A54
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 141f)
			{
				this.HBJJOCHGOPH = 315f;
			}
			this.FAIFBBGFAIB().SetFloat("CompletedLevel", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Intensity);
			this.CFEDGDGBCHE().SetFloat("[EMPTY]", this.GhostPosX);
			this.IIJMIPBMMBF().SetFloat("_Value", this.GhostPosY);
			this.MICHFGAOPKM().SetFloat("Object ID. Case-Sensitive", this.GhostFade);
			this.KGOLDDBHIFN().SetFloat("_Green_B", this.GhostFade2);
			this.ABHDNGIHBKE().SetFloat("BlockSize", this.GhostSize);
			this.FEAEGGCNIAA().SetFloat("_TileTexDebug", (float)((!this._Visualize) ? 0 : 0));
			this.IIJMIPBMMBF().SetFloat("[BuildInfo] Error: ", this._FixDistance);
			this.KAFBNOBOIAJ().SetFloat("_Amount", this.Ghost_Near);
			this.DKNJGHFLAIF().SetFloat("steamid", this.Ghost_Far);
			this.NBPKMLMCHFN.SetFloat("ReconnectAndRejoin() disabled the offline mode. No longer offline.", this.GhostWithoutObject);
			this.IIJMIPBMMBF().SetVector("ERROR: Make sure your mod contains at leats one file!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1761f, 42f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00037A06 File Offset: 0x00035C06
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00037364 File Offset: 0x00035564
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00037A40 File Offset: 0x00035C40
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1409f)
			{
				this.HBJJOCHGOPH = 419f;
			}
			this.BFGNMFCNDBC().SetFloat(": ", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", this.Intensity);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/TV_Vcr", this.GhostPosX);
			this.BFGNMFCNDBC().SetFloat(".lastCheckpoint.time", this.GhostPosY);
			this.NLFJGMBCICG().SetFloat("_MainTex2", this.GhostFade);
			this.IIJMIPBMMBF().SetFloat("RedoButton", this.GhostFade2);
			this.IIJMIPBMMBF().SetFloat("mapselector.orderby", this.GhostSize);
			this.FEAEGGCNIAA().SetFloat(" ", (float)((!this._Visualize) ? 1 : 1));
			this.MMOODGIODPC().SetFloat("CameraFilterPack/Distortion_Aspiration", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("owner: ", this.Ghost_Near);
			this.BKKJJJGADLM().SetFloat("UNDISTORT", this.Ghost_Far);
			this.IIJMIPBMMBF().SetFloat("_Speed", this.GhostWithoutObject);
			this.MMOODGIODPC().SetVector("#close", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1866f, 749f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00037364 File Offset: 0x00035564
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00037BF2 File Offset: 0x00035DF2
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00037364 File Offset: 0x00035564
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00037C29 File Offset: 0x00035E29
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00037364 File Offset: 0x00035564
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00037364 File Offset: 0x00035564
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00037C60 File Offset: 0x00035E60
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 1852f;
			}
			this.DKNJGHFLAIF().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("SpawnObj", this.Intensity);
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.GhostPosX);
			this.NBPKMLMCHFN.SetFloat("event", this.GhostPosY);
			this.KAFBNOBOIAJ().SetFloat("player.redlifering", this.GhostFade);
			this.NLFJGMBCICG().SetFloat("_Value3", this.GhostFade2);
			this.FAIFBBGFAIB().SetFloat("BadgeText", this.GhostSize);
			this.HCGJCMDJPGD().SetFloat("_Value2", (float)((!this._Visualize) ? 0 : 0));
			this.HCGJCMDJPGD().SetFloat("_ScreenResolution", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", this.Ghost_Near);
			this.ABHDNGIHBKE().SetFloat(".lastCheckpoint.checkpointsUsed", this.Ghost_Far);
			this.KAFBNOBOIAJ().SetFloat("DPADHOR", this.GhostWithoutObject);
			this.MMOODGIODPC().SetVector("[Sound Manager] Audio clip is null, cannot play sound", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 707f, 477f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00037E12 File Offset: 0x00036012
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00037E36 File Offset: 0x00036036
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("ticket");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00037E5C File Offset: 0x0003605C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 281f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.KAFBNOBOIAJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat(" argument(s): ", this.Intensity);
			this.FEAEGGCNIAA().SetFloat(",", this.GhostPosX);
			this.NLFJGMBCICG().SetFloat("BadgeText", this.GhostPosY);
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.GhostFade);
			this.FEAEGGCNIAA().SetFloat("Show image from resources by id at the center of the screen at foreground or background", this.GhostFade2);
			this.KAFBNOBOIAJ().SetFloat("_Intensity", this.GhostSize);
			this.NBPKMLMCHFN.SetFloat("_Bullet_5", (float)((!this._Visualize) ? 0 : 1));
			this.BKKJJJGADLM().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("VisionBlur", this.Ghost_Near);
			this.MICHFGAOPKM().SetFloat("0 seconds", this.Ghost_Far);
			this.NBPKMLMCHFN.SetFloat("EnableRankedNotificationsToggle", this.GhostWithoutObject);
			this.LNLKMDPHDCC().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 788f, 1644f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00038010 File Offset: 0x00036210
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 676f)
			{
				this.HBJJOCHGOPH = 1669f;
			}
			this.ABHDNGIHBKE().SetFloat(" ", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("[NetworkManager] Exited", this.Intensity);
			this.CFEDGDGBCHE().SetFloat("[MapEditor] Loading map: ", this.GhostPosX);
			this.MICHFGAOPKM().SetFloat("_Value3", this.GhostPosY);
			this.MICHFGAOPKM().SetFloat("maps.", this.GhostFade);
			this.FAIFBBGFAIB().SetFloat("Netw. Sim.", this.GhostFade2);
			this.BFGNMFCNDBC().SetFloat("\r\n", this.GhostSize);
			this.NLFJGMBCICG().SetFloat("Gameplay/Segment-[PowerUp]", (float)((!this._Visualize) ? 0 : 0));
			this.MMOODGIODPC().SetFloat("init", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat("_GrainTex", this.Ghost_Near);
			this.MMOODGIODPC().SetFloat("_TimeX", this.Ghost_Far);
			this.HCGJCMDJPGD().SetFloat("Failed to 'network-remove' GameObject because it's null.", this.GhostWithoutObject);
			this.MMOODGIODPC().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 936f, 1234f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00037364 File Offset: 0x00035564
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x000381C4 File Offset: 0x000363C4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1034f)
			{
				this.HBJJOCHGOPH = 1231f;
			}
			this.IIJMIPBMMBF().SetFloat("_LightIntensity", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("_Saturation", this.Intensity);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Blur_Steam", this.GhostPosX);
			this.NBPKMLMCHFN.SetFloat("[MapsData] Workshop maps was loaded", this.GhostPosY);
			this.BFGNMFCNDBC().SetFloat("id", this.GhostFade);
			this.HCGJCMDJPGD().SetFloat("_MainTex2", this.GhostFade2);
			this.IIJMIPBMMBF().SetFloat("_Value", this.GhostSize);
			this.FAIFBBGFAIB().SetFloat("sounds/hit_wrong", (float)((!this._Visualize) ? 1 : 1));
			this.FEAEGGCNIAA().SetFloat("yyyy-MM-dd HH:mm:ss", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("fetch", this.Ghost_Near);
			this.IIJMIPBMMBF().SetFloat("_TimeX", this.Ghost_Far);
			this.NLFJGMBCICG().SetFloat("s", this.GhostWithoutObject);
			this.CFEDGDGBCHE().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1335f, 433f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00038376 File Offset: 0x00036576
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x0003839A File Offset: 0x0003659A
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000383D1 File Offset: 0x000365D1
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00037364 File Offset: 0x00035564
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00038408 File Offset: 0x00036608
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00037364 File Offset: 0x00035564
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00037364 File Offset: 0x00035564
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x0003843F File Offset: 0x0003663F
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00038478 File Offset: 0x00036678
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1051f)
			{
				this.HBJJOCHGOPH = 1835f;
			}
			this.HCGJCMDJPGD().SetFloat("PS Home", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("Mouse Y", this.Intensity);
			this.LNLKMDPHDCC().SetFloat("_Blend", this.GhostPosX);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.GhostPosY);
			this.BFGNMFCNDBC().SetFloat("y", this.GhostFade);
			this.OIMMPLPBLBK().SetFloat("Load Game", this.GhostFade2);
			this.BKKJJJGADLM().SetFloat("0x", this.GhostSize);
			this.BFGNMFCNDBC().SetFloat("_FixDistance", (float)((!this._Visualize) ? 1 : 0));
			this.BKKJJJGADLM().SetFloat("_TimeX", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("Fade", this.Ghost_Near);
			this.LNLKMDPHDCC().SetFloat("OnDeserialize", this.Ghost_Far);
			this.MICHFGAOPKM().SetFloat("_TimeX", this.GhostWithoutObject);
			this.MICHFGAOPKM().SetVector("_FarCamera", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1188f, 726f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00037364 File Offset: 0x00035564
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x0003862A File Offset: 0x0003682A
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00037364 File Offset: 0x00035564
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00037364 File Offset: 0x00035564
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00038650 File Offset: 0x00036850
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 893f)
			{
				this.HBJJOCHGOPH = 685f;
			}
			this.CFEDGDGBCHE().SetFloat("[PlayerBase] Delete checkpoint data", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("EventTimeInputField", this.Intensity);
			this.BFGNMFCNDBC().SetFloat("Curve texture", this.GhostPosX);
			this.MMOODGIODPC().SetFloat("UnityEngine.MonoBehaviour", this.GhostPosY);
			this.HCGJCMDJPGD().SetFloat("Joystick1Button1", this.GhostFade);
			this.HCGJCMDJPGD().SetFloat("GridDataArcs", this.GhostFade2);
			this.NLFJGMBCICG().SetFloat("_TimeX", this.GhostSize);
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/AAA_WaterDropPro", (float)((!this._Visualize) ? 1 : 0));
			this.ABHDNGIHBKE().SetFloat("_Value4", this._FixDistance);
			this.FAIFBBGFAIB().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.Ghost_Near);
			this.FAIFBBGFAIB().SetFloat("PLEASE WAIT", this.Ghost_Far);
			this.BKKJJJGADLM().SetFloat("_MatrixSpeed", this.GhostWithoutObject);
			this.DKNJGHFLAIF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1469f, 998f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000737 RID: 1847 RVA: 0x00038802 File Offset: 0x00036A02
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

	// Token: 0x06000738 RID: 1848 RVA: 0x00038839 File Offset: 0x00036A39
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find(" scene view IDs from last level.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00037364 File Offset: 0x00035564
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x0003885D File Offset: 0x00036A5D
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00038894 File Offset: 0x00036A94
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_DiffuseColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00037364 File Offset: 0x00035564
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00038923 File Offset: 0x00036B23
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("FrostCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00037364 File Offset: 0x00035564
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00038947 File Offset: 0x00036B47
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("#FFFFFFFF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00037364 File Offset: 0x00035564
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x0003896B File Offset: 0x00036B6B
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("ItemsCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x0003898F File Offset: 0x00036B8F
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("CONTRAST");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00037364 File Offset: 0x00035564
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x000389B3 File Offset: 0x00036BB3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Ghost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x000389D8 File Offset: 0x00036BD8
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("GhostPosX", this.GhostPosX);
			this.NBPKMLMCHFN.SetFloat("GhostPosY", this.GhostPosY);
			this.NBPKMLMCHFN.SetFloat("GhostFade", this.GhostFade);
			this.NBPKMLMCHFN.SetFloat("GhostFade2", this.GhostFade2);
			this.NBPKMLMCHFN.SetFloat("GhostSize", this.GhostSize);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Drop_Near", this.Ghost_Near);
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.Ghost_Far);
			this.NBPKMLMCHFN.SetFloat("Drop_With_Obj", this.GhostWithoutObject);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00038B8C File Offset: 0x00036D8C
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1313f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Gradients_NeonGradient", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_Size", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("LeaderboardsButton", this.GhostPosX);
			this.FAIFBBGFAIB().SetFloat("_Parameter", this.GhostPosY);
			this.BFGNMFCNDBC().SetFloat("hidden", this.GhostFade);
			this.IIJMIPBMMBF().SetFloat(".icon", this.GhostFade2);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/Drawing_Manga2", this.GhostSize);
			this.OIMMPLPBLBK().SetFloat("Uploading content...", (float)((!this._Visualize) ? 1 : 0));
			this.BFGNMFCNDBC().SetFloat("_Value", this._FixDistance);
			this.HCGJCMDJPGD().SetFloat("[PlayerBase] ShowTitle error: ", this.Ghost_Near);
			this.MICHFGAOPKM().SetFloat("[Right]", this.Ghost_Far);
			this.IIJMIPBMMBF().SetFloat("[DiscordController] Responding yes to Ask to Join request", this.GhostWithoutObject);
			this.FAIFBBGFAIB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 434f, 1857f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00038D40 File Offset: 0x00036F40
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 31f)
			{
				this.HBJJOCHGOPH = 478f;
			}
			this.HCGJCMDJPGD().SetFloat("settings_bindings_controller_type", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_TimeX", this.Intensity);
			this.ABHDNGIHBKE().SetFloat("SetParent", this.GhostPosX);
			this.NLFJGMBCICG().SetFloat("_Value2", this.GhostPosY);
			this.IIJMIPBMMBF().SetFloat("ResetSpeed", this.GhostFade);
			this.NLFJGMBCICG().SetFloat("Created by ", this.GhostFade2);
			this.BFGNMFCNDBC().SetFloat("_Value2", this.GhostSize);
			this.BKKJJJGADLM().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			this.NLFJGMBCICG().SetFloat("SendVacantViewIds()", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("\n", this.Ghost_Near);
			this.MMOODGIODPC().SetFloat("_DotSize", this.Ghost_Far);
			this.MMOODGIODPC().SetFloat("menuVolume", this.GhostWithoutObject);
			this.IIJMIPBMMBF().SetVector("_NoiseTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 8f, 858f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00038EF2 File Offset: 0x000370F2
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00038F29 File Offset: 0x00037129
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00038F60 File Offset: 0x00037160
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00037364 File Offset: 0x00035564
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00038F97 File Offset: 0x00037197
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00038FCE File Offset: 0x000371CE
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0400011C RID: 284
	public Shader SCShader;

	// Token: 0x0400011D RID: 285
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400011E RID: 286
	public bool _Visualize;

	// Token: 0x0400011F RID: 287
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000120 RID: 288
	private Material BJFKDHHMLJH;

	// Token: 0x04000121 RID: 289
	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	// Token: 0x04000122 RID: 290
	[Range(-0.5f, 0.99f)]
	public float Ghost_Near = 0.08f;

	// Token: 0x04000123 RID: 291
	[Range(0f, 1f)]
	public float Ghost_Far = 0.55f;

	// Token: 0x04000124 RID: 292
	[Range(0f, 2f)]
	public float Intensity = 1f;

	// Token: 0x04000125 RID: 293
	[Range(0f, 1f)]
	public float GhostWithoutObject = 1f;

	// Token: 0x04000126 RID: 294
	[Range(-1f, 1f)]
	public float GhostPosX;

	// Token: 0x04000127 RID: 295
	[Range(-1f, 1f)]
	public float GhostPosY;

	// Token: 0x04000128 RID: 296
	[Range(0.1f, 8f)]
	public float GhostFade2 = 2f;

	// Token: 0x04000129 RID: 297
	[Range(-1f, 1f)]
	public float GhostFade;

	// Token: 0x0400012A RID: 298
	[Range(0.5f, 1.5f)]
	public float GhostSize = 0.9f;
}
