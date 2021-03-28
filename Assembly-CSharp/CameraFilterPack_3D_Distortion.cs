using System;
using UnityEngine;

// Token: 0x02000020 RID: 32
[AddComponentMenu("Camera Filter Pack/3D/Distortion")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Distortion : MonoBehaviour
{
	// Token: 0x06000695 RID: 1685 RVA: 0x0003473D File Offset: 0x0003293D
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x0003475C File Offset: 0x0003295C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1408f)
			{
				this.HBJJOCHGOPH = 740f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value3", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1227f)
				{
					this._Distance = 35f;
				}
				if (this._Distance < 1763f)
				{
					this._Distance = 694f;
				}
				this.IIBLJCKLGFG().SetFloat("element", this._Distance);
			}
			else
			{
				this.GCDFNHMJMIP().SetFloat("#task", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("maps.", this._Size);
			this.EPCGJFCCAFH().SetFloat("Working.\nPlease wait..", this._FixDistance);
			this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Edge_Sigmoid", this.DistortionLevel * 1926f);
			this.KGOLDDBHIFN().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.DistortionSize * 404f);
			this.ADBKPGFMNKO().SetFloat("Keypad", this.LightIntensity * 991f);
			this.ACHNOHCLGOO().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IIBLJCKLGFG().SetFloat("return ", 725f / farClipPlane);
			this.ADBKPGFMNKO().SetVector("GroupNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1220f, 986f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00034960 File Offset: 0x00032B60
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 621f)
			{
				this.HBJJOCHGOPH = 931f;
			}
			this.NBPKMLMCHFN.SetFloat("masterVolume", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 115f)
				{
					this._Distance = 260f;
				}
				if (this._Distance < 91f)
				{
					this._Distance = 104f;
				}
				this.IONHGBPGCHK().SetFloat("Please wait..", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("seconds", this._Distance);
			}
			this.IONHGBPGCHK().SetFloat("PhotonView with ID ", this._Size);
			this.OIMMPLPBLBK().SetFloat("0.00", this._FixDistance);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.DistortionLevel * 838f);
			this.MMOODGIODPC().SetFloat("_ScreenResolution", this.DistortionSize * 1821f);
			this.ADBKPGFMNKO().SetFloat("Could not execute RPC ", this.LightIntensity * 812f);
			this.MMOODGIODPC().SetFloat("note.5", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HFBJAOFLCJI().SetFloat(".lastCheckpoint.currentCombo", 437f / farClipPlane);
			this.PLBEJJIHFPB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 387f, 1609f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00034B64 File Offset: 0x00032D64
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("FullscreenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x0003473D File Offset: 0x0003293D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00034B88 File Offset: 0x00032D88
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Set Particles Emission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00034BAC File Offset: 0x00032DAC
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00034BE3 File Offset: 0x00032DE3
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00034C1A File Offset: 0x00032E1A
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00034C3E File Offset: 0x00032E3E
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00034C78 File Offset: 0x00032E78
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 505f)
			{
				this.HBJJOCHGOPH = 825f;
			}
			this.OIMMPLPBLBK().SetFloat("LivesSlider", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 977f)
				{
					this._Distance = 1219f;
				}
				if (this._Distance < 1060f)
				{
					this._Distance = 1735f;
				}
				this.IONHGBPGCHK().SetFloat("CameraFilterPack/TV_BrokenGlass2", this._Distance);
			}
			else
			{
				this.OIMMPLPBLBK().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", this._Distance);
			}
			this.PLBEJJIHFPB().SetFloat(". Stopping handling if inactive.", this._Size);
			this.MMOODGIODPC().SetFloat("CameraFilterPack/TV_50", this._FixDistance);
			this.PLBEJJIHFPB().SetFloat("Start Color's hex value #RRGGBBAA", this.DistortionLevel * 940f);
			this.ADBKPGFMNKO().SetFloat("_BlurVector", this.DistortionSize * 1632f);
			this.EPCGJFCCAFH().SetFloat("<color=white>PhotonView Group: ", this.LightIntensity * 1936f);
			this.NBPKMLMCHFN.SetFloat("return ", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EPCGJFCCAFH().SetFloat("PunRespawn", 1856f / farClipPlane);
			this.HFBJAOFLCJI().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 751f, 600f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00034E7C File Offset: 0x0003307C
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_Desert");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00034EA0 File Offset: 0x000330A0
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("Backward");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00034EC4 File Offset: 0x000330C4
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
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
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel * 28f);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize * 16f);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.LightIntensity * 64f);
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

	// Token: 0x060006A5 RID: 1701 RVA: 0x0003473D File Offset: 0x0003293D
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x000350C8 File Offset: 0x000332C8
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x0003516B File Offset: 0x0003336B
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("SetSatelliteSensitivity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x0003518F File Offset: 0x0003338F
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x0003473D File Offset: 0x0003293D
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x000351C6 File Offset: 0x000333C6
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x000351FD File Offset: 0x000333FD
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00035234 File Offset: 0x00033434
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

	// Token: 0x060006B2 RID: 1714 RVA: 0x0003473D File Offset: 0x0003293D
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x0003526B File Offset: 0x0003346B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00035290 File Offset: 0x00033490
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1091f)
			{
				this.HBJJOCHGOPH = 85f;
			}
			this.PLBEJJIHFPB().SetFloat("[Right]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1411f)
				{
					this._Distance = 861f;
				}
				if (this._Distance < 1201f)
				{
					this._Distance = 403f;
				}
				this.NBPKMLMCHFN.SetFloat("UseScanLine", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("_MainTex2", this._Distance);
			}
			this.PLBEJJIHFPB().SetFloat("difficulty", this._Size);
			this.ADBKPGFMNKO().SetFloat("[MapsData] Preloading workshop", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("DISTORT", this.DistortionLevel * 973f);
			this.HFBJAOFLCJI().SetFloat("_Linecount", this.DistortionSize * 1641f);
			this.KGOLDDBHIFN().SetFloat(".lastCheckpoint.currentCombo", this.LightIntensity * 1139f);
			this.GCDFNHMJMIP().SetFloat("DPADVER", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KGOLDDBHIFN().SetFloat(".", 86f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1416f, 1734f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00035494 File Offset: 0x00033694
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000354CB File Offset: 0x000336CB
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x000354EF File Offset: 0x000336EF
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00035526 File Offset: 0x00033726
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x0003473D File Offset: 0x0003293D
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00035560 File Offset: 0x00033760
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 419f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Distortion_ShockWave", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1957f)
				{
					this._Distance = 1663f;
				}
				if (this._Distance < 884f)
				{
					this._Distance = 1588f;
				}
				this.PLBEJJIHFPB().SetFloat("_Value", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("Reset", this._Distance);
			}
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Blend2Camera_Color", this._Size);
			this.PLBEJJIHFPB().SetFloat("Item ", this._FixDistance);
			this.ADBKPGFMNKO().SetFloat("IncorrectHitsScoreText", this.DistortionLevel * 1900f);
			this.NBPKMLMCHFN.SetFloat("_LightIntensity", this.DistortionSize * 1445f);
			this.GCDFNHMJMIP().SetFloat("_MainTex2", this.LightIntensity * 771f);
			this.IIBLJCKLGFG().SetFloat("Set Player Distance", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_Value4", 844f / farClipPlane);
			this.MMOODGIODPC().SetVector("ArcsDestroyDelaySlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1740f, 199f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x0003473D File Offset: 0x0003293D
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00035764 File Offset: 0x00033964
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1818f)
			{
				this.HBJJOCHGOPH = 426f;
			}
			this.KGOLDDBHIFN().SetFloat(": ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1787f)
				{
					this._Distance = 355f;
				}
				if (this._Distance < 1701f)
				{
					this._Distance = 137f;
				}
				this.KGOLDDBHIFN().SetFloat("%", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("_Value", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("Checkpoint", this._Size);
			this.EPCGJFCCAFH().SetFloat("_FarCamera", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Show Image", this.DistortionLevel * 10f);
			this.ADBKPGFMNKO().SetFloat("MainButton", this.DistortionSize * 685f);
			this.KGOLDDBHIFN().SetFloat("_Vignetting2", this.LightIntensity * 449f);
			this.MMOODGIODPC().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KGOLDDBHIFN().SetFloat("_TimeX", 815f / farClipPlane);
			this.IONHGBPGCHK().SetVector("player.circle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1032f, 441f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00035968 File Offset: 0x00033B68
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x000359A0 File Offset: 0x00033BA0
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 303f)
			{
				this.HBJJOCHGOPH = 769f;
			}
			this.HFBJAOFLCJI().SetFloat("SetParent", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1754f)
				{
					this._Distance = 525f;
				}
				if (this._Distance < 115f)
				{
					this._Distance = 1955f;
				}
				this.MMOODGIODPC().SetFloat("_RgbTex", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_DotSize", this._Distance);
			}
			this.HFBJAOFLCJI().SetFloat("SetTrailZoomSpeed", this._Size);
			this.NBPKMLMCHFN.SetFloat("_Value", this._FixDistance);
			this.GCDFNHMJMIP().SetFloat("workshop.", this.DistortionLevel * 1054f);
			this.KGOLDDBHIFN().SetFloat(" cannot be used as a 3D LUT.", this.DistortionSize * 1551f);
			this.HFBJAOFLCJI().SetFloat("_Value3", this.LightIntensity * 949f);
			this.ADBKPGFMNKO().SetFloat("_Value1", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.IIBLJCKLGFG().SetFloat("Year_", 1922f / farClipPlane);
			this.ACHNOHCLGOO().SetVector("[MapsStats] Hash: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 302f, 1608f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040000FF RID: 255
	public Shader SCShader;

	// Token: 0x04000100 RID: 256
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000101 RID: 257
	public bool _Visualize;

	// Token: 0x04000102 RID: 258
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000103 RID: 259
	private Material BJFKDHHMLJH;

	// Token: 0x04000104 RID: 260
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x04000105 RID: 261
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	// Token: 0x04000106 RID: 262
	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	// Token: 0x04000107 RID: 263
	[Range(0f, 10f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x04000108 RID: 264
	[Range(0.1f, 10f)]
	public float DistortionSize = 1.4f;

	// Token: 0x04000109 RID: 265
	[Range(-2f, 4f)]
	public float LightIntensity = 0.08f;

	// Token: 0x0400010A RID: 266
	public bool AutoAnimatedNear;

	// Token: 0x0400010B RID: 267
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x0400010C RID: 268
	public static Color ChangeColorRGB;
}
