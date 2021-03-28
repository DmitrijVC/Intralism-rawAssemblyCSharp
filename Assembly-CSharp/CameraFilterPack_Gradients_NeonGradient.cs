using System;
using UnityEngine;

// Token: 0x020000E6 RID: 230
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Gradients/Neon")]
public class CameraFilterPack_Gradients_NeonGradient : MonoBehaviour
{
	// Token: 0x060046B3 RID: 18099 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046B5 RID: 18101 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046B6 RID: 18102 RVA: 0x0015BE20 File Offset: 0x0015A020
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046B7 RID: 18103 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046B8 RID: 18104 RVA: 0x0015BE57 File Offset: 0x0015A057
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046B9 RID: 18105 RVA: 0x0015BE8E File Offset: 0x0015A08E
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046BA RID: 18106 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046BB RID: 18107 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x060046BC RID: 18108 RVA: 0x0015BEEC File Offset: 0x0015A0EC
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 399f)
			{
				this.HBJJOCHGOPH = 1397f;
			}
			this.JCPDCGIJKJD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat(" not exist", this.Switch);
			this.HEINDEMCGIK().SetFloat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", this.Fade);
			this.NFKFAAHHLLM().SetVector("skin.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1187f, 1339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046BD RID: 18109 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x060046BE RID: 18110 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046BF RID: 18111 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046C0 RID: 18112 RVA: 0x0015BFC0 File Offset: 0x0015A1C0
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 404f)
			{
				this.HBJJOCHGOPH = 838f;
			}
			this.INOBFNCKFGK().SetFloat("_NormalAndRoughnessTexture", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("ControllerRightX", this.Switch);
			this.OLHDPICFBOF().SetFloat("CameraFilterPack/BlurTiltShift_Hole", this.Fade);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Pixelisation_OilPaint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1533f, 875f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046C1 RID: 18113 RVA: 0x0015C093 File Offset: 0x0015A293
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046C2 RID: 18114 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x060046C3 RID: 18115 RVA: 0x0015C0CC File Offset: 0x0015A2CC
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 93f;
			}
			this.CIAFLBFJLEJ().SetFloat("_Red_B", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("#reward: ", this.Switch);
			this.JFDGLLEOPGB().SetFloat("[LevelEditorScene] Exported to ", this.Fade);
			this.ABHDNGIHBKE().SetVector("?page=addtip", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 180f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060046C4 RID: 18116 RVA: 0x0015C19F File Offset: 0x0015A39F
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

	// Token: 0x060046C5 RID: 18117 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046C6 RID: 18118 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x060046C7 RID: 18119 RVA: 0x0015C1D8 File Offset: 0x0015A3D8
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1275f)
			{
				this.HBJJOCHGOPH = 1353f;
			}
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", this.Switch);
			this.DOMEEFLPEPJ().SetFloat("achievements.21.completed.", this.Fade);
			this.CIAFLBFJLEJ().SetVector("tip", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 670f, 923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046C8 RID: 18120 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060046C9 RID: 18121 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x060046CA RID: 18122 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046CB RID: 18123 RVA: 0x0015C2D0 File Offset: 0x0015A4D0
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1292f)
			{
				this.HBJJOCHGOPH = 1818f;
			}
			this.FHFLKLMFHOI().SetFloat("#onrankchangeuptext", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Pixelisation_Dot", this.Switch);
			this.OKJOKHGJHGF().SetFloat(">", this.Fade);
			this.OKJOKHGJHGF().SetVector("_BlurParams", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1770f, 1048f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046CC RID: 18124 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046CD RID: 18125 RVA: 0x0015C3A4 File Offset: 0x0015A5A4
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 590f)
			{
				this.HBJJOCHGOPH = 363f;
			}
			this.JCPDCGIJKJD().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("SpawnObj", this.Switch);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack_Broken_Screen1", this.Fade);
			this.HEINDEMCGIK().SetVector("x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1643f, 1177f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046CE RID: 18126 RVA: 0x0015C478 File Offset: 0x0015A678
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1955f)
			{
				this.HBJJOCHGOPH = 1292f;
			}
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/TV_Chromatical2", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("_DistCenterScale", this.Switch);
			this.CIAFLBFJLEJ().SetFloat("_Value3", this.Fade);
			this.NFKFAAHHLLM().SetVector("TotalHitsScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1515f, 1921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046CF RID: 18127 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046D0 RID: 18128 RVA: 0x0015C54B File Offset: 0x0015A74B
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046D1 RID: 18129 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046D2 RID: 18130 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046D3 RID: 18131 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046D4 RID: 18132 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046D5 RID: 18133 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x060046D6 RID: 18134 RVA: 0x0015C584 File Offset: 0x0015A784
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 233f;
			}
			this.PGPEMMBJOOG().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("\n", this.Switch);
			this.NFKFAAHHLLM().SetFloat("\" gets executed locally only, if at all.", this.Fade);
			this.OLHDPICFBOF().SetVector("</color>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 290f, 351f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046D7 RID: 18135 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046D8 RID: 18136 RVA: 0x0015C657 File Offset: 0x0015A857
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046D9 RID: 18137 RVA: 0x0015C68E File Offset: 0x0015A88E
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046DA RID: 18138 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046DB RID: 18139 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046DC RID: 18140 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046DD RID: 18141 RVA: 0x0015C6C5 File Offset: 0x0015A8C5
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046DE RID: 18142 RVA: 0x0015C6FC File Offset: 0x0015A8FC
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1827f)
			{
				this.HBJJOCHGOPH = 1448f;
			}
			this.CIAFLBFJLEJ().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack_Sweater", this.Switch);
			this.JCPDCGIJKJD().SetFloat("Joystick1Button8", this.Fade);
			this.CIAFLBFJLEJ().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 593f, 1778f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046DF RID: 18143 RVA: 0x0015C7D0 File Offset: 0x0015A9D0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 76f)
			{
				this.HBJJOCHGOPH = 1231f;
			}
			this.HHLFDHNEIAH().SetFloat("_MotionBlurTmpCam", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("Despawn environment object by id", this.Switch);
			this.ABHDNGIHBKE().SetFloat("_History1Weight", this.Fade);
			this.CIAFLBFJLEJ().SetVector("SelectorMapsCountSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1832f, 248f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x0015C8A4 File Offset: 0x0015AAA4
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 927f)
			{
				this.HBJJOCHGOPH = 109f;
			}
			this.INOBFNCKFGK().SetFloat("No info", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.Switch);
			this.GJHLADDCMFF().SetFloat("[MapsData] Preloading workshop", this.Fade);
			this.HHLFDHNEIAH().SetVector("_InternalLutTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 876f, 1729f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046E1 RID: 18145 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060046E2 RID: 18146 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046E3 RID: 18147 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060046E4 RID: 18148 RVA: 0x0015C978 File Offset: 0x0015AB78
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 317f)
			{
				this.HBJJOCHGOPH = 307f;
			}
			this.OLHDPICFBOF().SetFloat("_Bullet_6", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("ScrollPanel", this.Switch);
			this.NBPKMLMCHFN.SetFloat("settings_bindings_", this.Fade);
			this.GJHLADDCMFF().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 49f, 1892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046E5 RID: 18149 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046E6 RID: 18150 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x0015CA4B File Offset: 0x0015AC4B
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046E9 RID: 18153 RVA: 0x0015CA82 File Offset: 0x0015AC82
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046EA RID: 18154 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046EB RID: 18155 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046EC RID: 18156 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046ED RID: 18157 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046EE RID: 18158 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x060046EF RID: 18159 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046F0 RID: 18160 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x060046F1 RID: 18161 RVA: 0x0015CABC File Offset: 0x0015ACBC
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 129f)
			{
				this.HBJJOCHGOPH = 390f;
			}
			this.JCPDCGIJKJD().SetFloat("Set Sun Emission", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("[Down]", this.Switch);
			this.JCPDCGIJKJD().SetFloat("\t", this.Fade);
			this.HEINDEMCGIK().SetVector("RecieveChatActionMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1053f, 52f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046F2 RID: 18162 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060046F3 RID: 18163 RVA: 0x0015C657 File Offset: 0x0015A857
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046F4 RID: 18164 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046F5 RID: 18165 RVA: 0x0015CB8F File Offset: 0x0015AD8F
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046F6 RID: 18166 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046F7 RID: 18167 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046F8 RID: 18168 RVA: 0x0015CBC8 File Offset: 0x0015ADC8
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 142f)
			{
				this.HBJJOCHGOPH = 1798f;
			}
			this.GJHLADDCMFF().SetFloat("resource", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_EmissionGain", this.Switch);
			this.JCPDCGIJKJD().SetFloat("CameraFilterPack/Vision_AuraDistortion", this.Fade);
			this.OKJOKHGJHGF().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1417f, 1928f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046F9 RID: 18169 RVA: 0x0015CC9B File Offset: 0x0015AE9B
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046FA RID: 18170 RVA: 0x0015CCD2 File Offset: 0x0015AED2
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046FB RID: 18171 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMNOHLNANIP()
	{
	}

	// Token: 0x060046FC RID: 18172 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046FD RID: 18173 RVA: 0x0015CD0C File Offset: 0x0015AF0C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1020f)
			{
				this.HBJJOCHGOPH = 1587f;
			}
			this.ABHDNGIHBKE().SetFloat("LevelEditor/CustomEventEditor-", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("#pleasewait", this.Switch);
			this.OLHDPICFBOF().SetFloat("_Intensity", this.Fade);
			this.OLHDPICFBOF().SetVector("_BlurredColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 291f, 1323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046FE RID: 18174 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x060046FF RID: 18175 RVA: 0x0015CDDF File Offset: 0x0015AFDF
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004700 RID: 18176 RVA: 0x0015CE18 File Offset: 0x0015B018
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 401f)
			{
				this.HBJJOCHGOPH = 1962f;
			}
			this.GJHLADDCMFF().SetFloat(".lastCheckpoint.lives", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_DepthLevel", this.Switch);
			this.GJHLADDCMFF().SetFloat("offline room", this.Fade);
			this.NBPKMLMCHFN.SetVector("Up ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1224f, 825f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004701 RID: 18177 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06004702 RID: 18178 RVA: 0x0015CEEC File Offset: 0x0015B0EC
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 468f)
			{
				this.HBJJOCHGOPH = 1033f;
			}
			this.NFKFAAHHLLM().SetFloat("CameraFilterPack/TV_Artefact", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("RoomNameText", this.Switch);
			this.OLHDPICFBOF().SetFloat("CameraFilterPack/RainFX", this.Fade);
			this.NFKFAAHHLLM().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1112f, 540f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004703 RID: 18179 RVA: 0x0015CFC0 File Offset: 0x0015B1C0
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 974f)
			{
				this.HBJJOCHGOPH = 535f;
			}
			this.HEINDEMCGIK().SetFloat("[GameEvent] Exeption:", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("ArcsDestroyDelaySlider", this.Switch);
			this.HEINDEMCGIK().SetFloat("Connection error: ", this.Fade);
			this.JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 578f, 846f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004704 RID: 18180 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004705 RID: 18181 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004706 RID: 18182 RVA: 0x0015D094 File Offset: 0x0015B294
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1456f)
			{
				this.HBJJOCHGOPH = 1766f;
			}
			this.GCDFNHMJMIP().SetFloat("FileMenu", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("Copy from ", this.Switch);
			this.HFBJAOFLCJI().SetFloat("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", this.Fade);
			this.OKJOKHGJHGF().SetVector("Hex value #RRGGBB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1759f, 1071f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004707 RID: 18183 RVA: 0x0015D168 File Offset: 0x0015B368
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 439f)
			{
				this.HBJJOCHGOPH = 976f;
			}
			this.GJHLADDCMFF().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("settings.volume.sfx", this.Switch);
			this.EMDFHOKEGNG().SetFloat("Most likely the game became empty during the switch to GameServer.", this.Fade);
			this.INOBFNCKFGK().SetVector("_DistortionSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1915f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004708 RID: 18184 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004709 RID: 18185 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x0600470A RID: 18186 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x0600470B RID: 18187 RVA: 0x0015D23B File Offset: 0x0015B43B
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600470C RID: 18188 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600470D RID: 18189 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600470E RID: 18190 RVA: 0x0015D274 File Offset: 0x0015B474
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 123f)
			{
				this.HBJJOCHGOPH = 728f;
			}
			this.HHLFDHNEIAH().SetFloat("_Blue_R", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Blue_B", this.Switch);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.Fade);
			this.DOMEEFLPEPJ().SetVector("HandsCountSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 766f, 874f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600470F RID: 18191 RVA: 0x0015D348 File Offset: 0x0015B548
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1739f)
			{
				this.HBJJOCHGOPH = 865f;
			}
			this.NFKFAAHHLLM().SetFloat("CameraFilterPack/Drawing_Laplacian", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("maps.", this.Switch);
			this.KDMBOKLMADJ().SetFloat("settings.volume.sfx", this.Fade);
			this.JCPDCGIJKJD().SetVector("Can't start OFFLINE mode while connected!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1916f, 432f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004710 RID: 18192 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004711 RID: 18193 RVA: 0x0015D41C File Offset: 0x0015B61C
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 679f)
			{
				this.HBJJOCHGOPH = 906f;
			}
			this.EOCCJGIGEGJ().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_ScreenResolution", this.Switch);
			this.JFDGLLEOPGB().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", this.Fade);
			this.HEINDEMCGIK().SetVector("Backward", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 671f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004712 RID: 18194 RVA: 0x0015D4F0 File Offset: 0x0015B6F0
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1107f)
			{
				this.HBJJOCHGOPH = 321f;
			}
			this.HFBJAOFLCJI().SetFloat("SpectateButton", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("#rt", this.Switch);
			this.ABHDNGIHBKE().SetFloat("_FadeFX", this.Fade);
			this.INOBFNCKFGK().SetVector("Texture2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 839f, 951f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004713 RID: 18195 RVA: 0x0015D5C3 File Offset: 0x0015B7C3
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004714 RID: 18196 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06004715 RID: 18197 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06004716 RID: 18198 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06004717 RID: 18199 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06004718 RID: 18200 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004719 RID: 18201 RVA: 0x0015D5FA File Offset: 0x0015B7FA
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600471A RID: 18202 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600471B RID: 18203 RVA: 0x0015D634 File Offset: 0x0015B834
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600471C RID: 18204 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600471D RID: 18205 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600471E RID: 18206 RVA: 0x0015D708 File Offset: 0x0015B908
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1826f)
			{
				this.HBJJOCHGOPH = 390f;
			}
			this.INOBFNCKFGK().SetFloat("#onrankchangedowntext", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_Intensity", this.Switch);
			this.EOCCJGIGEGJ().SetFloat(".highscore", this.Fade);
			this.GCDFNHMJMIP().SetVector("_EmissionColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 683f, 1422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600471F RID: 18207 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004720 RID: 18208 RVA: 0x0015D7DB File Offset: 0x0015B9DB
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004721 RID: 18209 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004722 RID: 18210 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004723 RID: 18211 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004724 RID: 18212 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004725 RID: 18213 RVA: 0x0015D814 File Offset: 0x0015BA14
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1369f)
			{
				this.HBJJOCHGOPH = 1298f;
			}
			this.ABHDNGIHBKE().SetFloat("|", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("SetRoomStartTimestamp", this.Switch);
			this.PGPEMMBJOOG().SetFloat("_Value2", this.Fade);
			this.HEINDEMCGIK().SetVector("skin.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1724f, 824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004726 RID: 18214 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004727 RID: 18215 RVA: 0x0015C2AB File Offset: 0x0015A4AB
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004728 RID: 18216 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004729 RID: 18217 RVA: 0x0015BEC5 File Offset: 0x0015A0C5
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600472A RID: 18218 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600472B RID: 18219 RVA: 0x0015BDCF File Offset: 0x00159FCF
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600472C RID: 18220 RVA: 0x0015D8E8 File Offset: 0x0015BAE8
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1506f)
			{
				this.HBJJOCHGOPH = 1825f;
			}
			this.CIAFLBFJLEJ().SetFloat("_Far", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("Mine", this.Switch);
			this.DOMEEFLPEPJ().SetFloat("#exit", this.Fade);
			this.HHLFDHNEIAH().SetVector("#mapalreadyexistupdate", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1121f, 842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600472D RID: 18221 RVA: 0x0015D9BC File Offset: 0x0015BBBC
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 571f)
			{
				this.HBJJOCHGOPH = 50f;
			}
			this.FHFLKLMFHOI().SetFloat(": ", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_FlipAlphaMask", this.Switch);
			this.EOCCJGIGEGJ().SetFloat("menu.selectedlevelid", this.Fade);
			this.NFKFAAHHLLM().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1766f, 568f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600472E RID: 18222 RVA: 0x0015DA90 File Offset: 0x0015BC90
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 120f)
			{
				this.HBJJOCHGOPH = 1561f;
			}
			this.GCDFNHMJMIP().SetFloat("Please attach component to a Graphical UI component", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("powerup.0", this.Switch);
			this.HHLFDHNEIAH().SetFloat("ItemTemplate", this.Fade);
			this.HFBJAOFLCJI().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1369f, 1290f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600472F RID: 18223 RVA: 0x0015DB63 File Offset: 0x0015BD63
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000784 RID: 1924
	public Shader SCShader;

	// Token: 0x04000785 RID: 1925
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_NeonGradient";

	// Token: 0x04000786 RID: 1926
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000787 RID: 1927
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000788 RID: 1928
	private Material BJFKDHHMLJH;

	// Token: 0x04000789 RID: 1929
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x0400078A RID: 1930
	[Range(0f, 1f)]
	public float Fade = 1f;
}
