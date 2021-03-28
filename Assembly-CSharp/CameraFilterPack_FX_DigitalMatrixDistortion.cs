using System;
using UnityEngine;

// Token: 0x020000C2 RID: 194
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/DigitalMatrixDistortion")]
public class CameraFilterPack_FX_DigitalMatrixDistortion : MonoBehaviour
{
	// Token: 0x06003A7D RID: 14973 RVA: 0x00127B98 File Offset: 0x00125D98
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 70f;
			}
			this.CEKJODEAMGB().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("shader.invert", this.Size);
			this.GHHPOGODBHB().SetFloat("_Value", this.Distortion);
			this.HCGJCMDJPGD().SetFloat("_Fade", this.Speed);
			this.FAIFBBGFAIB().SetVector("_ChangeRed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 991f, 1611f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A7E RID: 14974 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003A7F RID: 14975 RVA: 0x00127C81 File Offset: 0x00125E81
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A80 RID: 14976 RVA: 0x00127C9E File Offset: 0x00125E9E
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_DigitalMatrixDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A81 RID: 14977 RVA: 0x00127CC4 File Offset: 0x00125EC4
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1677f)
			{
				this.HBJJOCHGOPH = 1080f;
			}
			this.HKHBBBFLGJH().SetFloat(").png", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_FilteredReflections", this.Size);
			this.EMDFHOKEGNG().SetFloat("StartCanvas", this.Distortion);
			this.PGPEMMBJOOG().SetFloat("Set satellite color", this.Speed);
			this.EFMCNLELMDO().SetVector("Bad parameters for set! Use <language>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 634f, 824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A82 RID: 14978 RVA: 0x00127DAD File Offset: 0x00125FAD
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A83 RID: 14979 RVA: 0x00127DE4 File Offset: 0x00125FE4
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A84 RID: 14980 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06003A85 RID: 14981 RVA: 0x00127C81 File Offset: 0x00125E81
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A86 RID: 14982 RVA: 0x00127C81 File Offset: 0x00125E81
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A87 RID: 14983 RVA: 0x00127E1B File Offset: 0x0012601B
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A88 RID: 14984 RVA: 0x00127E52 File Offset: 0x00126052
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x00127E76 File Offset: 0x00126076
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A8A RID: 14986 RVA: 0x00127C81 File Offset: 0x00125E81
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x00127E9A File Offset: 0x0012609A
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x00127C81 File Offset: 0x00125E81
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A8E RID: 14990 RVA: 0x00127EBE File Offset: 0x001260BE
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("Sets the boolean value of the Auto Focus Input Field property.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06003A8F RID: 14991 RVA: 0x00127EE2 File Offset: 0x001260E2
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

	// Token: 0x06003A90 RID: 14992 RVA: 0x00127C81 File Offset: 0x00125E81
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A91 RID: 14993 RVA: 0x00127C81 File Offset: 0x00125E81
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A92 RID: 14994 RVA: 0x00127F19 File Offset: 0x00126119
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A93 RID: 14995 RVA: 0x00127C81 File Offset: 0x00125E81
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A94 RID: 14996 RVA: 0x00127F50 File Offset: 0x00126150
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A95 RID: 14997 RVA: 0x00127C81 File Offset: 0x00125E81
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A96 RID: 14998 RVA: 0x00127F74 File Offset: 0x00126174
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("_Green_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A97 RID: 14999 RVA: 0x00127F98 File Offset: 0x00126198
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A98 RID: 15000 RVA: 0x00127FCF File Offset: 0x001261CF
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A99 RID: 15001 RVA: 0x00128006 File Offset: 0x00126206
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A9A RID: 15002 RVA: 0x0012803D File Offset: 0x0012623D
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("EditMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x00128064 File Offset: 0x00126264
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1365f)
			{
				this.HBJJOCHGOPH = 631f;
			}
			this.KDMBOKLMADJ().SetFloat("SetEnvSpriteImage", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("Map already submited. Update?", this.Size);
			this.HCGJCMDJPGD().SetFloat("menu.enableselectormusic", this.Distortion);
			this.PGPEMMBJOOG().SetFloat("_DotSize", this.Speed);
			this.PHGCJOPFDOG().SetVector("Scene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 655f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A9C RID: 15004 RVA: 0x00127C81 File Offset: 0x00125E81
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A9D RID: 15005 RVA: 0x00128150 File Offset: 0x00126350
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 453f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			this.PHGCJOPFDOG().SetFloat("CameraFilterPack/Special_Bubble", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("Init", this.Size);
			this.KDMBOKLMADJ().SetFloat("_Sensitivity", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("Tab2Content", this.Speed);
			this.HKHBBBFLGJH().SetVector(". Client should be in a room. Current connectionStateDetailed: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 203f, 73f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A9E RID: 15006 RVA: 0x00128239 File Offset: 0x00126439
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A9F RID: 15007 RVA: 0x00128270 File Offset: 0x00126470
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x00128294 File Offset: 0x00126494
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AA1 RID: 15009 RVA: 0x001282CB File Offset: 0x001264CB
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("CreateRoom failed. In offline mode you still have to leave a room to enter another.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003AA2 RID: 15010 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x001282EF File Offset: 0x001264EF
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x00127C81 File Offset: 0x00125E81
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x00127C81 File Offset: 0x00125E81
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AA6 RID: 15014 RVA: 0x00128313 File Offset: 0x00126513
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AA7 RID: 15015 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003AA8 RID: 15016 RVA: 0x00127C81 File Offset: 0x00125E81
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AA9 RID: 15017 RVA: 0x0012834A File Offset: 0x0012654A
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AAA RID: 15018 RVA: 0x00128381 File Offset: 0x00126581
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AAB RID: 15019 RVA: 0x001283A8 File Offset: 0x001265A8
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 605f)
			{
				this.HBJJOCHGOPH = 214f;
			}
			this.ACHNOHCLGOO().SetFloat("menutheme.jamaicanorcdub", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_ColoredChange", this.Size);
			this.HHIAIGCAHDA().SetFloat("Joystick1Button9", this.Distortion);
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.Speed);
			this.KOHGPKOFEJO().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 575f, 116f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AAC RID: 15020 RVA: 0x00128491 File Offset: 0x00126691
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AAD RID: 15021 RVA: 0x001284C8 File Offset: 0x001266C8
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003AAE RID: 15022 RVA: 0x001284EC File Offset: 0x001266EC
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 822f)
			{
				this.HBJJOCHGOPH = 1434f;
			}
			this.ACHNOHCLGOO().SetFloat("\n", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("_Value3", this.Size);
			this.DKNJGHFLAIF().SetFloat("_EmissionColor", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", this.Speed);
			this.MCDGIILBNIF().SetVector("#forever", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 355f, 728f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AAF RID: 15023 RVA: 0x001285D8 File Offset: 0x001267D8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Speed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AB0 RID: 15024 RVA: 0x00127C81 File Offset: 0x00125E81
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AB1 RID: 15025 RVA: 0x00127C81 File Offset: 0x00125E81
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AB2 RID: 15026 RVA: 0x001286C1 File Offset: 0x001268C1
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AB3 RID: 15027 RVA: 0x001286F8 File Offset: 0x001268F8
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AB4 RID: 15028 RVA: 0x0012872F File Offset: 0x0012692F
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("Can't set visible when not in that room.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003AB5 RID: 15029 RVA: 0x00128753 File Offset: 0x00126953
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003AB6 RID: 15030 RVA: 0x00127C81 File Offset: 0x00125E81
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AB7 RID: 15031 RVA: 0x00128778 File Offset: 0x00126978
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 65f)
			{
				this.HBJJOCHGOPH = 916f;
			}
			this.KDMBOKLMADJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_ScreenResolution", this.Size);
			this.ACHNOHCLGOO().SetFloat("ResourceIDInputField", this.Distortion);
			this.GHHPOGODBHB().SetFloat("sprite", this.Speed);
			this.PGPEMMBJOOG().SetVector("Joystick1Button0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1962f, 1039f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AB8 RID: 15032 RVA: 0x00128864 File Offset: 0x00126A64
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 666f)
			{
				this.HBJJOCHGOPH = 1377f;
			}
			this.HFBJAOFLCJI().SetFloat("LetterSpacing: Missing Text component", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("[GameScene] Events count: ", this.Size);
			this.PGPEMMBJOOG().SetFloat("BitsData", this.Distortion);
			this.HCGJCMDJPGD().SetFloat("id", this.Speed);
			this.CFEDGDGBCHE().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1976f, 865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AB9 RID: 15033 RVA: 0x00127C81 File Offset: 0x00125E81
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003ABA RID: 15034 RVA: 0x00127C81 File Offset: 0x00125E81
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003ABB RID: 15035 RVA: 0x0012894D File Offset: 0x00126B4D
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003ABC RID: 15036 RVA: 0x00128984 File Offset: 0x00126B84
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("#newhighscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003ABD RID: 15037 RVA: 0x001289A8 File Offset: 0x00126BA8
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003ABE RID: 15038 RVA: 0x001289CC File Offset: 0x00126BCC
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003ABF RID: 15039 RVA: 0x00128A04 File Offset: 0x00126C04
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1715f)
			{
				this.HBJJOCHGOPH = 1612f;
			}
			this.MCDGIILBNIF().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("InfoCanvas", this.Size);
			this.CFEDGDGBCHE().SetFloat("[ItemsHandler] Loading Steam inventory", this.Distortion);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/TV_PlanetMars", this.Speed);
			this.EMDFHOKEGNG().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 58f, 1377f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AC0 RID: 15040 RVA: 0x00127C81 File Offset: 0x00125E81
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AC1 RID: 15041 RVA: 0x00128AED File Offset: 0x00126CED
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AC2 RID: 15042 RVA: 0x00128B24 File Offset: 0x00126D24
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1490f)
			{
				this.HBJJOCHGOPH = 471f;
			}
			this.FLOHGDECHHH().SetFloat("???", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("challenges/", this.Size);
			this.HFBJAOFLCJI().SetFloat("shader.pixel", this.Distortion);
			this.DKNJGHFLAIF().SetFloat(",", this.Speed);
			this.HHIAIGCAHDA().SetVector("challenges/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1951f, 1312f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AC3 RID: 15043 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06003AC5 RID: 15045 RVA: 0x00128C0D File Offset: 0x00126E0D
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003AC6 RID: 15046 RVA: 0x00127C81 File Offset: 0x00125E81
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AC7 RID: 15047 RVA: 0x00128C34 File Offset: 0x00126E34
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1833f)
			{
				this.HBJJOCHGOPH = 360f;
			}
			this.FGENHBKMPDA().SetFloat(".jpg", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat(" is muted", this.Size);
			this.PGPEMMBJOOG().SetFloat(" scene: ", this.Distortion);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/Distortion_ShockWave", this.Speed);
			this.DKNJGHFLAIF().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1668f, 197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AC8 RID: 15048 RVA: 0x00128D20 File Offset: 0x00126F20
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 190f)
			{
				this.HBJJOCHGOPH = 1967f;
			}
			this.KDMBOKLMADJ().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("InfoText", this.Size);
			this.HCGJCMDJPGD().SetFloat("LevelEditor/patterns", this.Distortion);
			this.CEKJODEAMGB().SetFloat("_Value3", this.Speed);
			this.HCGJCMDJPGD().SetVector("EventMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 730f, 1813f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AC9 RID: 15049 RVA: 0x00128E0C File Offset: 0x0012700C
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1385f)
			{
				this.HBJJOCHGOPH = 1960f;
			}
			this.PHGCJOPFDOG().SetFloat("TimeBGSlider", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("ItemNameBGImage", this.Size);
			this.FGENHBKMPDA().SetFloat("end", this.Distortion);
			this.KOHGPKOFEJO().SetFloat("_Value2", this.Speed);
			this.DBOLLHHMKKN().SetVector("<b>(╯°□°）╯︵ ┻━┻</b>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 385f, 1780f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003ACA RID: 15050 RVA: 0x00127C81 File Offset: 0x00125E81
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003ACB RID: 15051 RVA: 0x00128EF8 File Offset: 0x001270F8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1063f)
			{
				this.HBJJOCHGOPH = 86f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Left Click", this.Size);
			this.HCGJCMDJPGD().SetFloat("[MapsData] Workshop maps was loaded", this.Distortion);
			this.GHHPOGODBHB().SetFloat("player.mysteryitem", this.Speed);
			this.HKGAONMOBMH().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 533f, 1771f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003ACC RID: 15052 RVA: 0x00128FE1 File Offset: 0x001271E1
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003ACD RID: 15053 RVA: 0x00129018 File Offset: 0x00127218
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003ACE RID: 15054 RVA: 0x00127C81 File Offset: 0x00125E81
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AD0 RID: 15056 RVA: 0x00127C81 File Offset: 0x00125E81
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AD1 RID: 15057 RVA: 0x00129084 File Offset: 0x00127284
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1939f)
			{
				this.HBJJOCHGOPH = 215f;
			}
			this.KOHGPKOFEJO().SetFloat("?page=addtip", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_Value3", this.Size);
			this.EFMCNLELMDO().SetFloat("ns.exitgames.com", this.Distortion);
			this.LENEJAGLCNL().SetFloat("_ScreenResolution", this.Speed);
			this.HFBJAOFLCJI().SetVector("HPText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1824f, 122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AD2 RID: 15058 RVA: 0x00127C81 File Offset: 0x00125E81
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003AD3 RID: 15059 RVA: 0x0012916D File Offset: 0x0012736D
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AD4 RID: 15060 RVA: 0x001291A4 File Offset: 0x001273A4
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AD5 RID: 15061 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06003AD6 RID: 15062 RVA: 0x001291DB File Offset: 0x001273DB
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AD7 RID: 15063 RVA: 0x00129212 File Offset: 0x00127412
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003AD8 RID: 15064 RVA: 0x0012924C File Offset: 0x0012744C
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 231f)
			{
				this.HBJJOCHGOPH = 1955f;
			}
			this.CEKJODEAMGB().SetFloat("Edited unlock conditions", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("GlassesColor", this.Size);
			this.FLOHGDECHHH().SetFloat("ZoomFade", this.Distortion);
			this.HKHBBBFLGJH().SetFloat("[PlayerBase] SetBGColor error: ", this.Speed);
			this.HKGAONMOBMH().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 862f, 284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003AD9 RID: 15065 RVA: 0x00129338 File Offset: 0x00127538
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1321f)
			{
				this.HBJJOCHGOPH = 1951f;
			}
			this.FGENHBKMPDA().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("InfoButton", this.Size);
			this.GHHPOGODBHB().SetFloat("Joystick1Button6", this.Distortion);
			this.FLOHGDECHHH().SetFloat("_EmissionGain", this.Speed);
			this.EFMCNLELMDO().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1718f, 753f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003ADA RID: 15066 RVA: 0x00127C81 File Offset: 0x00125E81
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003ADB RID: 15067 RVA: 0x00129421 File Offset: 0x00127621
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003ADC RID: 15068 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06003ADD RID: 15069 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0400066C RID: 1644
	public Shader SCShader;

	// Token: 0x0400066D RID: 1645
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400066E RID: 1646
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400066F RID: 1647
	private Material BJFKDHHMLJH;

	// Token: 0x04000670 RID: 1648
	[Range(0.4f, 5f)]
	public float Size = 1.4f;

	// Token: 0x04000671 RID: 1649
	[Range(-2f, 2f)]
	public float Speed = 0.5f;

	// Token: 0x04000672 RID: 1650
	[Range(-5f, 5f)]
	public float Distortion = 2.3f;
}
