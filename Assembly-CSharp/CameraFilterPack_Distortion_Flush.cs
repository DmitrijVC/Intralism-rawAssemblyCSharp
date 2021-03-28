using System;
using UnityEngine;

// Token: 0x0200008C RID: 140
[AddComponentMenu("Camera Filter Pack/Distortion/Flush")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Flush : MonoBehaviour
{
	// Token: 0x06002843 RID: 10307 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06002844 RID: 10308 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x000DFAE4 File Offset: 0x000DDCE4
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 189f)
			{
				this.HBJJOCHGOPH = 633f;
			}
			this.MLMKCOINOOH().SetFloat("Set sun lerp speed", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("ItemTemplate", this.Value);
			this.PHGCJOPFDOG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 208f, 605f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002847 RID: 10311 RVA: 0x000DFBA4 File Offset: 0x000DDDA4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1335f)
			{
				this.HBJJOCHGOPH = 246f;
			}
			this.DNLMFEGJJDD().SetFloat(" from: ", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("\" error: ", this.Value);
			this.EJDPNJAEAKJ().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1690f, 718f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002848 RID: 10312 RVA: 0x000DFC61 File Offset: 0x000DDE61
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("FileMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x000DFC88 File Offset: 0x000DDE88
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1717f)
			{
				this.HBJJOCHGOPH = 1892f;
			}
			this.PHGCJOPFDOG().SetFloat("/?page=ranks", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("PossibleMapPointsText", this.Value);
			this.NBPKMLMCHFN.SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 596f, 568f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600284A RID: 10314 RVA: 0x000DFD45 File Offset: 0x000DDF45
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600284B RID: 10315 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x0600284C RID: 10316 RVA: 0x000DFD7C File Offset: 0x000DDF7C
	private void BKIGIIINEDH()
	{
		this.SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x000DFDA0 File Offset: 0x000DDFA0
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002850 RID: 10320 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x000DFDD7 File Offset: 0x000DDFD7
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002852 RID: 10322 RVA: 0x000DFDFB File Offset: 0x000DDFFB
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x000DFE32 File Offset: 0x000DE032
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002854 RID: 10324 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002856 RID: 10326 RVA: 0x000DFE69 File Offset: 0x000DE069
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002857 RID: 10327 RVA: 0x000DFEA0 File Offset: 0x000DE0A0
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 985f)
			{
				this.HBJJOCHGOPH = 1530f;
			}
			this.MLMKCOINOOH().SetFloat("score", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.Value);
			this.LONNIJMNKFB().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 35f, 524f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002858 RID: 10328 RVA: 0x000DFF60 File Offset: 0x000DE160
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 471f)
			{
				this.HBJJOCHGOPH = 559f;
			}
			this.DKNJGHFLAIF().SetFloat("GlassesColor2", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.Value);
			this.MCDGIILBNIF().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 285f, 940f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002859 RID: 10329 RVA: 0x000E0020 File Offset: 0x000DE220
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 524f)
			{
				this.HBJJOCHGOPH = 1438f;
			}
			this.LENEJAGLCNL().SetFloat("CameraFilterPack_3D_Matrix1", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("BadgeText", this.Value);
			this.CECJJMKLEAK().SetVector("_AdaptationSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 422f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600285A RID: 10330 RVA: 0x000E00DD File Offset: 0x000DE2DD
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x000E0101 File Offset: 0x000DE301
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600285E RID: 10334 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600285F RID: 10335 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x000E0138 File Offset: 0x000DE338
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002862 RID: 10338 RVA: 0x000E016F File Offset: 0x000DE36F
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06002864 RID: 10340 RVA: 0x000E0194 File Offset: 0x000DE394
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 211f)
			{
				this.HBJJOCHGOPH = 163f;
			}
			this.LENEJAGLCNL().SetFloat("http", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this.Value);
			this.LONNIJMNKFB().SetVector("Reset XP", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1808f, 353f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002865 RID: 10341 RVA: 0x000E0251 File Offset: 0x000DE451
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("_LrDepthTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002866 RID: 10342 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x000E0278 File Offset: 0x000DE478
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1731f)
			{
				this.HBJJOCHGOPH = 138f;
			}
			this.ECCPAOBFDKP().SetFloat("{0:0} day{1}, ", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("AudioSampler", this.Value);
			this.MCDGIILBNIF().SetVector("mapselector.lastSearch", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1130f, 176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x000E0338 File Offset: 0x000DE538
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 781f)
			{
				this.HBJJOCHGOPH = 1540f;
			}
			this.MLMKCOINOOH().SetFloat("Set satellite clockwise rotattion speed", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat(".", this.Value);
			this.EJDPNJAEAKJ().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1173f, 1905f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002869 RID: 10345 RVA: 0x000E03F5 File Offset: 0x000DE5F5
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600286A RID: 10346 RVA: 0x000E041C File Offset: 0x000DE61C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1766f)
			{
				this.HBJJOCHGOPH = 455f;
			}
			this.IFMAPIDFNLI().SetFloat("View", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("\t", this.Value);
			this.MLMKCOINOOH().SetVector("CameraFilterPack/Distortion_Noise", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1941f, 957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600286B RID: 10347 RVA: 0x000E04D9 File Offset: 0x000DE6D9
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600286C RID: 10348 RVA: 0x000E0510 File Offset: 0x000DE710
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("Ev DestroyAll! By PlayerId: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600286D RID: 10349 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600286E RID: 10350 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600286F RID: 10351 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06002870 RID: 10352 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06002871 RID: 10353 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002872 RID: 10354 RVA: 0x000E0534 File Offset: 0x000DE734
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 701f)
			{
				this.HBJJOCHGOPH = 1416f;
			}
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] SetBGColor error: ", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("--------------------------------", this.Value);
			this.LNLKMDPHDCC().SetVector("Please attach component to a Graphical UI component", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1304f, 1354f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002873 RID: 10355 RVA: 0x000E05F4 File Offset: 0x000DE7F4
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 454f)
			{
				this.HBJJOCHGOPH = 1716f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("/music", this.Value);
			this.JIBOKBCPDLC().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 756f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002874 RID: 10356 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002875 RID: 10357 RVA: 0x000E06B1 File Offset: 0x000DE8B1
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("LastHighScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002876 RID: 10358 RVA: 0x000E06D8 File Offset: 0x000DE8D8
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
			this.NBPKMLMCHFN.SetFloat("Value", this.Value);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002877 RID: 10359 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x06002878 RID: 10360 RVA: 0x000E0795 File Offset: 0x000DE995
	private void BEKMLIFILFP()
	{
		this.SCShader = Shader.Find("Missing shader in ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002879 RID: 10361 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600287A RID: 10362 RVA: 0x000E07B9 File Offset: 0x000DE9B9
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x000E07E0 File Offset: 0x000DE9E0
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 793f)
			{
				this.HBJJOCHGOPH = 1007f;
			}
			this.LPDOGGFOBDH().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("id", this.Value);
			this.KOHGPKOFEJO().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 93f, 1966f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600287C RID: 10364 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600287D RID: 10365 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x0600287E RID: 10366 RVA: 0x000E089D File Offset: 0x000DEA9D
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x000E08D4 File Offset: 0x000DEAD4
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 702f)
			{
				this.HBJJOCHGOPH = 1790f;
			}
			this.OJMHIMIPKME().SetFloat("restrictions\n\n#until: ", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("_Value4", this.Value);
			this.DNLMFEGJJDD().SetVector("Indie", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1529f, 1969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002880 RID: 10368 RVA: 0x000E0991 File Offset: 0x000DEB91
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("GlassesColor2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002881 RID: 10369 RVA: 0x000E09B5 File Offset: 0x000DEBB5
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002882 RID: 10370 RVA: 0x000E09EC File Offset: 0x000DEBEC
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002883 RID: 10371 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06002884 RID: 10372 RVA: 0x000E03F5 File Offset: 0x000DE5F5
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x000E0A23 File Offset: 0x000DEC23
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002886 RID: 10374 RVA: 0x000E0A5C File Offset: 0x000DEC5C
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1300f)
			{
				this.HBJJOCHGOPH = 785f;
			}
			this.OJMHIMIPKME().SetFloat("Map: ", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("[PlayerController] ", this.Value);
			this.JIBOKBCPDLC().SetVector("_Noise", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 762f, 632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002887 RID: 10375 RVA: 0x000E0B19 File Offset: 0x000DED19
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("mapid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002888 RID: 10376 RVA: 0x000E0B3D File Offset: 0x000DED3D
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x000E0B61 File Offset: 0x000DED61
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x000E0B88 File Offset: 0x000DED88
	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 833f)
			{
				this.HBJJOCHGOPH = 994f;
			}
			this.LPDOGGFOBDH().SetFloat("Right", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("_ScreenResolution", this.Value);
			this.OJMHIMIPKME().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1227f, 53f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600288C RID: 10380 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void ABHEJPAGNMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x0600288F RID: 10383 RVA: 0x000E0C48 File Offset: 0x000DEE48
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1020f)
			{
				this.HBJJOCHGOPH = 271f;
			}
			this.KDMBOKLMADJ().SetFloat("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("UseScanLine", this.Value);
			this.ECCPAOBFDKP().SetVector("SlidingArea", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 339f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002890 RID: 10384 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002892 RID: 10386 RVA: 0x000E0D08 File Offset: 0x000DEF08
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1110f)
			{
				this.HBJJOCHGOPH = 273f;
			}
			this.LNLKMDPHDCC().SetFloat("ControllerRightX", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("Up ", this.Value);
			this.OJMHIMIPKME().SetVector("1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 897f, 28f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002894 RID: 10388 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002895 RID: 10389 RVA: 0x000E0DC5 File Offset: 0x000DEFC5
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x000E0DFC File Offset: 0x000DEFFC
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002897 RID: 10391 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x000E0E33 File Offset: 0x000DF033
	private void IBJIBLHJKMG()
	{
		this.SCShader = Shader.Find("file://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x000E03F5 File Offset: 0x000DE5F5
	private void PJHBFAFOEEN()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x000E0E58 File Offset: 0x000DF058
	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1938f)
			{
				this.HBJJOCHGOPH = 97f;
			}
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/FX_InverChromiLum", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat(" not exist", this.Value);
			this.MCDGIILBNIF().SetVector("Horizontal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1520f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600289C RID: 10396 RVA: 0x000DFDD7 File Offset: 0x000DDFD7
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600289D RID: 10397 RVA: 0x000E0F15 File Offset: 0x000DF115
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600289E RID: 10398 RVA: 0x000E0F4C File Offset: 0x000DF14C
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1717f)
			{
				this.HBJJOCHGOPH = 929f;
			}
			this.LPDOGGFOBDH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_DiffuseColor", this.Value);
			this.HEINDEMCGIK().SetVector("VisionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 991f, 669f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x000E1009 File Offset: 0x000DF209
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028A0 RID: 10400 RVA: 0x000E102D File Offset: 0x000DF22D
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("TimeBGSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x000E1054 File Offset: 0x000DF254
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 969f)
			{
				this.HBJJOCHGOPH = 24f;
			}
			this.LNLKMDPHDCC().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("Case-Sensitive", this.Value);
			this.LONNIJMNKFB().SetVector("DPADVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1662f, 397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x000E1114 File Offset: 0x000DF314
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1603f)
			{
				this.HBJJOCHGOPH = 1285f;
			}
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Blend2Camera_Blend", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Value);
			this.EJDPNJAEAKJ().SetVector("CameraFilterPack/Blend2Camera_Multiply", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1677f, 386f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x000E11D1 File Offset: 0x000DF3D1
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("Working commands:\nreset <challengeid>\nresetall");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028A4 RID: 10404 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void NHHCGPAMLAJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028A5 RID: 10405 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060028A6 RID: 10406 RVA: 0x000E11F5 File Offset: 0x000DF3F5
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028A7 RID: 10407 RVA: 0x000E121C File Offset: 0x000DF41C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1386f)
			{
				this.HBJJOCHGOPH = 504f;
			}
			this.LNLKMDPHDCC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_PColor", this.Value);
			this.IFMAPIDFNLI().SetVector("wss://", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1763f, 348f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028A8 RID: 10408 RVA: 0x000E12D9 File Offset: 0x000DF4D9
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028A9 RID: 10409 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028AA RID: 10410 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028AB RID: 10411 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060028AC RID: 10412 RVA: 0x000E1310 File Offset: 0x000DF510
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 305f)
			{
				this.HBJJOCHGOPH = 212f;
			}
			this.CECJJMKLEAK().SetFloat("Type \"help\" for list of commands", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("settings.enableranking", this.Value);
			this.NBPKMLMCHFN.SetVector("deletemap", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 211f, 1938f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028AD RID: 10413 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x060028AE RID: 10414 RVA: 0x000E13CD File Offset: 0x000DF5CD
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028AF RID: 10415 RVA: 0x000E13F4 File Offset: 0x000DF5F4
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1225f)
			{
				this.HBJJOCHGOPH = 286f;
			}
			this.DNLMFEGJJDD().SetFloat("powerup.1", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.Value);
			this.MLMKCOINOOH().SetVector(" cannot be used as a 3D LUT.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1511f, 1053f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028B0 RID: 10416 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x060028B1 RID: 10417 RVA: 0x000E14B1 File Offset: 0x000DF6B1
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028B2 RID: 10418 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x060028B3 RID: 10419 RVA: 0x000E14D8 File Offset: 0x000DF6D8
	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1614f)
			{
				this.HBJJOCHGOPH = 1601f;
			}
			this.LPDOGGFOBDH().SetFloat("LeaderboardsButton", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("maps.", this.Value);
			this.KDMBOKLMADJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1637f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028B4 RID: 10420 RVA: 0x000E1598 File Offset: 0x000DF798
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1486f)
			{
				this.HBJJOCHGOPH = 802f;
			}
			this.ECCPAOBFDKP().SetFloat("_Visualize", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_TimeX", this.Value);
			this.MLMKCOINOOH().SetVector("DPADVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1014f, 197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028B5 RID: 10421 RVA: 0x000E1655 File Offset: 0x000DF855
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("ChatHistoryInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028B6 RID: 10422 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x000E1679 File Offset: 0x000DF879
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Ascii");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x000E16A0 File Offset: 0x000DF8A0
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 881f)
			{
				this.HBJJOCHGOPH = 1954f;
			}
			this.KDMBOKLMADJ().SetFloat("note.7", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_MainTex", this.Value);
			this.HEINDEMCGIK().SetVector(".lastCheckpoint.perfectHits", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1816f, 1955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x0002523B File Offset: 0x0002343B
	private void PCIMPDNLCHH()
	{
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x000E175D File Offset: 0x000DF95D
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x000E1781 File Offset: 0x000DF981
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("JoinRandom failed: {0}.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028BC RID: 10428 RVA: 0x000E17A5 File Offset: 0x000DF9A5
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028BD RID: 10429 RVA: 0x000DFDA0 File Offset: 0x000DDFA0
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028BE RID: 10430 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060028BF RID: 10431 RVA: 0x000E17DC File Offset: 0x000DF9DC
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

	// Token: 0x060028C0 RID: 10432 RVA: 0x000E1813 File Offset: 0x000DFA13
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("[SERVER] Selected map: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028C1 RID: 10433 RVA: 0x000E1837 File Offset: 0x000DFA37
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("OnPickedUp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028C2 RID: 10434 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x060028C3 RID: 10435 RVA: 0x000E185C File Offset: 0x000DFA5C
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1657f)
			{
				this.HBJJOCHGOPH = 1162f;
			}
			this.EJDPNJAEAKJ().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_Value3", this.Value);
			this.EJDPNJAEAKJ().SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1766f, 471f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028C4 RID: 10436 RVA: 0x000E191C File Offset: 0x000DFB1C
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1565f)
			{
				this.HBJJOCHGOPH = 1472f;
			}
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("checkpoint", this.Value);
			this.JIBOKBCPDLC().SetVector("Show Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1248f, 962f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028C5 RID: 10437 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMKBLLMIKAB()
	{
	}

	// Token: 0x060028C6 RID: 10438 RVA: 0x000E19D9 File Offset: 0x000DFBD9
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_FgOverlap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028C7 RID: 10439 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060028C8 RID: 10440 RVA: 0x000E1A00 File Offset: 0x000DFC00
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 445f)
			{
				this.HBJJOCHGOPH = 96f;
			}
			this.LNLKMDPHDCC().SetFloat("LoadPlayerEnvironment", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_MainTex2", this.Value);
			this.NBPKMLMCHFN.SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 652f, 75f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028C9 RID: 10441 RVA: 0x000E1ABD File Offset: 0x000DFCBD
	private void OGJJDKENBNC()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Grid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028CA RID: 10442 RVA: 0x000E1AE1 File Offset: 0x000DFCE1
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Flush");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028CB RID: 10443 RVA: 0x000E1B05 File Offset: 0x000DFD05
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x000E1B29 File Offset: 0x000DFD29
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("Received OnSerialization for view ID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028CD RID: 10445 RVA: 0x000E1B4D File Offset: 0x000DFD4D
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("ControllerLeftY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028CE RID: 10446 RVA: 0x000E1B71 File Offset: 0x000DFD71
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("[Singleton] Using instance of '");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028CF RID: 10447 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKKJICPMPHK()
	{
	}

	// Token: 0x060028D0 RID: 10448 RVA: 0x000E11F5 File Offset: 0x000DF3F5
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028D2 RID: 10450 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x000DFDD7 File Offset: 0x000DDFD7
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028D4 RID: 10452 RVA: 0x000E1BB3 File Offset: 0x000DFDB3
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028D5 RID: 10453 RVA: 0x000E1BD7 File Offset: 0x000DFDD7
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("_Value8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNJIHCLODK()
	{
	}

	// Token: 0x060028D7 RID: 10455 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x000E1BFB File Offset: 0x000DFDFB
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x000DFAC5 File Offset: 0x000DDCC5
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040004F9 RID: 1273
	public Shader SCShader;

	// Token: 0x040004FA RID: 1274
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004FB RID: 1275
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004FC RID: 1276
	private Material BJFKDHHMLJH;

	// Token: 0x040004FD RID: 1277
	[Range(-10f, 50f)]
	public float Value = 5f;
}
