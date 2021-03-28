using System;
using UnityEngine;

// Token: 0x02000084 RID: 132
[AddComponentMenu("Camera Filter Pack/Distortion/Aspiration")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Aspiration : MonoBehaviour
{
	// Token: 0x060025C2 RID: 9666 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x000D6588 File Offset: 0x000D4788
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1964f)
			{
				this.HBJJOCHGOPH = 1428f;
			}
			this.LONNIJMNKFB().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ColorR", 1647f - this.Value);
			this.NFMGLIKNOOC().SetFloat("float,0", this.PosX);
			this.DEFBJOCJJKF().SetFloat("Object ID. Case-Sensitive", this.PosY);
			this.LONNIJMNKFB().SetFloat("#or", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("CameraFilterPack/Pixelisation_Sweater", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 140f, 1272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x000D668D File Offset: 0x000D488D
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_InternalLutParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x000D66B4 File Offset: 0x000D48B4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1353f)
			{
				this.HBJJOCHGOPH = 1869f;
			}
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Blend2Camera_Screen", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();", 860f - this.Value);
			this.NFMGLIKNOOC().SetFloat("_Value2", this.PosX);
			this.KBOPGONOCNP().SetFloat("Error: I/O Failure! :(", this.PosY);
			this.LDNADDJMIPK().SetFloat("_FadeFX", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("The other scroll rect doesnt support scrolling vertically", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1088f, 444f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x000D67B9 File Offset: 0x000D49B9
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x000D67F0 File Offset: 0x000D49F0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 829f)
			{
				this.HBJJOCHGOPH = 81f;
			}
			this.NFMGLIKNOOC().SetFloat("IconImage", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat(" not found", 1937f - this.Value);
			this.BFGNMFCNDBC().SetFloat("Set satellite beat detection sensitivity", this.PosX);
			this.DEFBJOCJJKF().SetFloat("_PColor", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector("TimeBGSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 222f, 495f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x000D68F5 File Offset: 0x000D4AF5
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x000D692C File Offset: 0x000D4B2C
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x000D6964 File Offset: 0x000D4B64
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 142f)
			{
				this.HBJJOCHGOPH = 262f;
			}
			this.IIBLJCKLGFG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("_Skybox", 1548f - this.Value);
			this.NBPKMLMCHFN.SetFloat("_Value", this.PosX);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack_Glasses_On6", this.PosY);
			this.DNLMFEGJJDD().SetFloat("No problem found, so far", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 666f, 972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x000D6A69 File Offset: 0x000D4C69
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x000D6AA0 File Offset: 0x000D4CA0
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Aspiration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060025CE RID: 9678 RVA: 0x000D6AC4 File Offset: 0x000D4CC4
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x000D6B20 File Offset: 0x000D4D20
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x000D6B57 File Offset: 0x000D4D57
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x000D6B90 File Offset: 0x000D4D90
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1773f)
			{
				this.HBJJOCHGOPH = 1003f;
			}
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/FX_Glitch2", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("Reading preview file failed!: \"{0}\"", 444f - this.Value);
			this.JIBOKBCPDLC().SetFloat("Bad parameters for setbool! Use <key> <value>", this.PosX);
			this.BFGNMFCNDBC().SetFloat("_Blue_R", this.PosY);
			this.GCDFNHMJMIP().SetFloat("X2", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("_EdgeSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 924f, 1500f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x000D6C95 File Offset: 0x000D4E95
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x000D6CCC File Offset: 0x000D4ECC
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x000D6CF0 File Offset: 0x000D4EF0
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("[MapEditor] Loading map: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x000D6D14 File Offset: 0x000D4F14
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 533f)
			{
				this.HBJJOCHGOPH = 1684f;
			}
			this.GCDFNHMJMIP().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_VignetteSettings", 864f - this.Value);
			this.DNLMFEGJJDD().SetFloat("Edited unlock conditions", this.PosX);
			this.NBPKMLMCHFN.SetFloat("-", this.PosY);
			this.IIJMIPBMMBF().SetFloat(" ", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1174f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x000D6E19 File Offset: 0x000D5019
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x000D6E3D File Offset: 0x000D503D
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x000D6AC4 File Offset: 0x000D4CC4
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x000D6E74 File Offset: 0x000D5074
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 473f)
			{
				this.HBJJOCHGOPH = 1383f;
			}
			this.GCDFNHMJMIP().SetFloat("_Sensitivity", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("'{0}' \t{1}ms \t{2}", 774f - this.Value);
			this.NBPKMLMCHFN.SetFloat("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", this.PosX);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Drawing_Comics", this.PosY);
			this.LONNIJMNKFB().SetFloat(".", this.CCIENBFIKKH);
			this.BFGNMFCNDBC().SetVector("x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1446f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060025DB RID: 9691 RVA: 0x000D6F79 File Offset: 0x000D5179
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

	// Token: 0x060025DC RID: 9692 RVA: 0x000D6AC4 File Offset: 0x000D4CC4
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x000D6AC4 File Offset: 0x000D4CC4
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x000D6FB0 File Offset: 0x000D51B0
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 97f)
			{
				this.HBJJOCHGOPH = 759f;
			}
			this.IIJMIPBMMBF().SetFloat("menu.selectedplaymode", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("[RanksSystem] Ranks: no need to update", 1408f - this.Value);
			this.IIJMIPBMMBF().SetFloat("Mouse", this.PosX);
			this.KBOPGONOCNP().SetFloat("Items", this.PosY);
			this.NBPKMLMCHFN.SetFloat("In Main Menu", this.CCIENBFIKKH);
			this.NFMGLIKNOOC().SetVector("Deleted event", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1380f, 1915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x000D70B8 File Offset: 0x000D52B8
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
			this.NBPKMLMCHFN.SetFloat("_Value", 1f - this.Value);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x000D71BD File Offset: 0x000D53BD
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("CurrentTimeLabel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x000D71E1 File Offset: 0x000D53E1
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x000D6AC4 File Offset: 0x000D4CC4
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x000D7218 File Offset: 0x000D5418
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_DistortionWave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x000D723C File Offset: 0x000D543C
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x000D6AC4 File Offset: 0x000D4CC4
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x000D7273 File Offset: 0x000D5473
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x000D72AA File Offset: 0x000D54AA
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("PerfectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x000D72CE File Offset: 0x000D54CE
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040004C6 RID: 1222
	public Shader SCShader;

	// Token: 0x040004C7 RID: 1223
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004C8 RID: 1224
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004C9 RID: 1225
	private Material BJFKDHHMLJH;

	// Token: 0x040004CA RID: 1226
	[Range(0f, 1f)]
	public float Value = 0.8f;

	// Token: 0x040004CB RID: 1227
	[Range(-1f, 1f)]
	public float PosX = 0.5f;

	// Token: 0x040004CC RID: 1228
	[Range(-1f, 1f)]
	public float PosY = 0.5f;

	// Token: 0x040004CD RID: 1229
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
