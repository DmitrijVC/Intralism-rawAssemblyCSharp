using System;
using UnityEngine;

// Token: 0x02000091 RID: 145
[AddComponentMenu("Camera Filter Pack/Distortion/ShockWave")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_ShockWave : MonoBehaviour
{
	// Token: 0x06002A3B RID: 10811 RVA: 0x000E6701 File Offset: 0x000E4901
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A3C RID: 10812 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06002A3D RID: 10813 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x000E6725 File Offset: 0x000E4925
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x000E675C File Offset: 0x000E495C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 270f)
			{
				this.HBJJOCHGOPH = 1689f;
			}
			this.NJDIODJNGGA().SetFloat("NetworkCanvas", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("null", this.PosX);
			this.LPDOGGFOBDH().SetFloat("Set Satellite Lerp Speed", this.PosY);
			this.ALABBJPHCNG().SetFloat("_Intensity", this.Speed);
			this.NDMPCDHADMJ().SetFloat("No problem found, so far", this.FPECJFFEDOM);
			this.PHGCJOPFDOG().SetVector("[MapsData] Bad map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 813f, 837f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000E685B File Offset: 0x000E4A5B
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

	// Token: 0x06002A41 RID: 10817 RVA: 0x000E6894 File Offset: 0x000E4A94
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.FPECJFFEDOM);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x000E6994 File Offset: 0x000E4B94
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1274f)
			{
				this.HBJJOCHGOPH = 375f;
			}
			this.ALABBJPHCNG().SetFloat("CameraFilterPack_Fly_VisionFX", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("(", this.PosX);
			this.PLBEJJIHFPB().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", this.PosY);
			this.IIBLJCKLGFG().SetFloat("_Val", this.Speed);
			this.ADGHJOHKEHG().SetFloat("OK", this.FPECJFFEDOM);
			this.LPDOGGFOBDH().SetVector("_PositionY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 667f, 1103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x000E6A93 File Offset: 0x000E4C93
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x000E6ACA File Offset: 0x000E4CCA
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("#failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x000E6AF0 File Offset: 0x000E4CF0
	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1608f)
			{
				this.HBJJOCHGOPH = 1503f;
			}
			this.HILDKDFEBPF().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("_TimeX", this.PosX);
			this.EOCCJGIGEGJ().SetFloat("_Value2", this.PosY);
			this.HILDKDFEBPF().SetFloat("Show image from resources by id at the center of the screen at foreground or background", this.Speed);
			this.EOCCJGIGEGJ().SetFloat("Can't start OFFLINE mode while connected!", this.FPECJFFEDOM);
			this.ADGHJOHKEHG().SetVector("ControllerRightX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1553f, 436f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A47 RID: 10823 RVA: 0x000E6BF0 File Offset: 0x000E4DF0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1317f)
			{
				this.HBJJOCHGOPH = 1845f;
			}
			this.KGOLDDBHIFN().SetFloat("#mapby", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("bans.viewed.", this.PosX);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack_TV_Noise2", this.PosY);
			this.OHKGGPFGLFD().SetFloat("_TimeX", this.Speed);
			this.LENEJAGLCNL().SetFloat("settings.enableranking", this.FPECJFFEDOM);
			this.LPDOGGFOBDH().SetVector("CameraFilterPack/FX_Ascii", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1814f, 1347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A49 RID: 10825 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x000E6D0C File Offset: 0x000E4F0C
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x000E6D30 File Offset: 0x000E4F30
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 387f)
			{
				this.HBJJOCHGOPH = 145f;
			}
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("LastHighScoreText", this.PosX);
			this.NJDIODJNGGA().SetFloat("Save", this.PosY);
			this.PLBEJJIHFPB().SetFloat("curScn", this.Speed);
			this.NMDBCDFPGOK().SetFloat("Playing ", this.FPECJFFEDOM);
			this.ALABBJPHCNG().SetVector("Error: you cannot read this stream that you are writing!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1938f, 345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A52 RID: 10834 RVA: 0x000E6E2F File Offset: 0x000E502F
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A53 RID: 10835 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A54 RID: 10836 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06002A55 RID: 10837 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06002A56 RID: 10838 RVA: 0x000E6E66 File Offset: 0x000E5066
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("null");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x000E6E8C File Offset: 0x000E508C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 771f)
			{
				this.HBJJOCHGOPH = 254f;
			}
			this.NBPKMLMCHFN.SetFloat("Joystick1Button1", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat("_ScreenResolution", this.PosX);
			this.NDMPCDHADMJ().SetFloat("/", this.PosY);
			this.OHKGGPFGLFD().SetFloat("_TimeX", this.Speed);
			this.NJDIODJNGGA().SetFloat("grid", this.FPECJFFEDOM);
			this.OHKGGPFGLFD().SetVector("Music End", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1681f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A58 RID: 10840 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x000E6F8B File Offset: 0x000E518B
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("\n - NetID: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A5A RID: 10842 RVA: 0x000E6FB0 File Offset: 0x000E51B0
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1608f)
			{
				this.HBJJOCHGOPH = 1273f;
			}
			this.MNLKBFFKHIE().SetFloat("_GreenAmplifier", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("#forever", this.PosX);
			this.AELJLBOJAIL().SetFloat("[Right]", this.PosY);
			this.IGIAPKPKGPK().SetFloat("_ToPrevViewProjCombined", this.Speed);
			this.IGIAPKPKGPK().SetFloat("_Value2", this.FPECJFFEDOM);
			this.NDMPCDHADMJ().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1346f, 870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A5B RID: 10843 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06002A5C RID: 10844 RVA: 0x000E70B0 File Offset: 0x000E52B0
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1694f)
			{
				this.HBJJOCHGOPH = 1016f;
			}
			this.AELJLBOJAIL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("<color=#{0}>{1}</color>", this.PosX);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.PosY);
			this.NJDIODJNGGA().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this.Speed);
			this.IGIAPKPKGPK().SetFloat("ticket", this.FPECJFFEDOM);
			this.DOMEEFLPEPJ().SetVector("stretchWidth", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1345f, 1340f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A5D RID: 10845 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A5E RID: 10846 RVA: 0x000E71AF File Offset: 0x000E53AF
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("Please attach component to a Graphical UI component");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x000E71D4 File Offset: 0x000E53D4
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 481f)
			{
				this.HBJJOCHGOPH = 206f;
			}
			this.HILDKDFEBPF().SetFloat("settings.volume.sfx", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("TStart", this.PosX);
			this.AELJLBOJAIL().SetFloat("SupportLogger OnCreatedRoom(", this.PosY);
			this.DKNJGHFLAIF().SetFloat(" on effect ", this.Speed);
			this.PHGCJOPFDOG().SetFloat("Drop_Far", this.FPECJFFEDOM);
			this.EOCCJGIGEGJ().SetVector("Joystick1Button0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1318f, 1209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A60 RID: 10848 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x000E72D3 File Offset: 0x000E54D3
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A62 RID: 10850 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x000E72F7 File Offset: 0x000E54F7
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06002A67 RID: 10855 RVA: 0x000E731B File Offset: 0x000E551B
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A68 RID: 10856 RVA: 0x000E7352 File Offset: 0x000E5552
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A69 RID: 10857 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x000E7376 File Offset: 0x000E5576
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("#pleasewait");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x000E739C File Offset: 0x000E559C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 60f)
			{
				this.HBJJOCHGOPH = 1988f;
			}
			this.OHKGGPFGLFD().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Joystick1Button2", this.PosX);
			this.IGIAPKPKGPK().SetFloat("RoomNameText", this.PosY);
			this.NJDIODJNGGA().SetFloat("_WorldToCameraMatrix", this.Speed);
			this.DKNJGHFLAIF().SetFloat("[NetworkManager] roomInfo.name: ", this.FPECJFFEDOM);
			this.IIBLJCKLGFG().SetVector("[PlayerBase] ShowTitle error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 667f, 265f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x000E749B File Offset: 0x000E569B
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find(".workshop.json");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A6D RID: 10861 RVA: 0x000E74BF File Offset: 0x000E56BF
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A6E RID: 10862 RVA: 0x000E74F6 File Offset: 0x000E56F6
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("B:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A6F RID: 10863 RVA: 0x000E751A File Offset: 0x000E571A
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("[Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A70 RID: 10864 RVA: 0x000E753E File Offset: 0x000E573E
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A71 RID: 10865 RVA: 0x000E7578 File Offset: 0x000E5778
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1419f)
			{
				this.HBJJOCHGOPH = 1330f;
			}
			this.EHDJJANLINB().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("{0:0} minute{1}, ", this.PosX);
			this.NJDIODJNGGA().SetFloat("BloodAlternative3", this.PosY);
			this.IIBLJCKLGFG().SetFloat("Object ID. Case-Sensitive", this.Speed);
			this.NMDBCDFPGOK().SetFloat("_TimeX", this.FPECJFFEDOM);
			this.HILDKDFEBPF().SetVector("UseScanLine", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 356f, 865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A72 RID: 10866 RVA: 0x000E7677 File Offset: 0x000E5877
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_ShockWave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A73 RID: 10867 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A74 RID: 10868 RVA: 0x000E769C File Offset: 0x000E589C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 129f)
			{
				this.HBJJOCHGOPH = 892f;
			}
			this.PDEAHJPOMEF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("BitsData", this.PosX);
			this.LENEJAGLCNL().SetFloat(" beatThreshold: ", this.PosY);
			this.PDEAHJPOMEF().SetFloat("Joystick1Button12", this.Speed);
			this.MNLKBFFKHIE().SetFloat("_ScreenResolution", this.FPECJFFEDOM);
			this.GKILCDHJFEG().SetVector("SupportLogger OnFailedToConnectToPhoton(", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 939f, 364f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A75 RID: 10869 RVA: 0x000E779B File Offset: 0x000E599B
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void JAFOCEDILNK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A77 RID: 10871 RVA: 0x000E77BF File Offset: 0x000E59BF
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x000E77F6 File Offset: 0x000E59F6
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A79 RID: 10873 RVA: 0x000E782D File Offset: 0x000E5A2D
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A7A RID: 10874 RVA: 0x000E7864 File Offset: 0x000E5A64
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x000E7888 File Offset: 0x000E5A88
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A7D RID: 10877 RVA: 0x000E78BF File Offset: 0x000E5ABF
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Not sending leave operation. State is not 'Joined': ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A7E RID: 10878 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x000E78E3 File Offset: 0x000E5AE3
	private Material HILDKDFEBPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06002A81 RID: 10881 RVA: 0x000E791A File Offset: 0x000E5B1A
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("[ResourcesManager] Load image error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x000E7940 File Offset: 0x000E5B40
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 553f)
			{
				this.HBJJOCHGOPH = 594f;
			}
			this.LENEJAGLCNL().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("<b>", this.PosX);
			this.DOMEEFLPEPJ().SetFloat("_SSAO", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Speed);
			this.EPCGJFCCAFH().SetFloat("delete", this.FPECJFFEDOM);
			this.IIBLJCKLGFG().SetVector("_PColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1687f, 801f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A83 RID: 10883 RVA: 0x000E7A3F File Offset: 0x000E5C3F
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x000E7A76 File Offset: 0x000E5C76
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_FrustumCornersWS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A85 RID: 10885 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x000E7A9C File Offset: 0x000E5C9C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1583f)
			{
				this.HBJJOCHGOPH = 1420f;
			}
			this.GKILCDHJFEG().SetFloat("/", this.HBJJOCHGOPH);
			this.ALABBJPHCNG().SetFloat("DPADHOR", this.PosX);
			this.EHDJJANLINB().SetFloat("id", this.PosY);
			this.KBOPGONOCNP().SetFloat("arcs", this.Speed);
			this.GKILCDHJFEG().SetFloat("[Left]", this.FPECJFFEDOM);
			this.NMDBCDFPGOK().SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1344f, 668f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A87 RID: 10887 RVA: 0x000E7B9B File Offset: 0x000E5D9B
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x000E7BD2 File Offset: 0x000E5DD2
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(". MasterClient: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A89 RID: 10889 RVA: 0x000E7BF6 File Offset: 0x000E5DF6
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A8A RID: 10890 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A8B RID: 10891 RVA: 0x000E7C2D File Offset: 0x000E5E2D
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A8C RID: 10892 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A8D RID: 10893 RVA: 0x000E7C54 File Offset: 0x000E5E54
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1254f)
			{
				this.HBJJOCHGOPH = 1625f;
			}
			this.DKNJGHFLAIF().SetFloat("id", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.PosX);
			this.DOMEEFLPEPJ().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", this.PosY);
			this.LENEJAGLCNL().SetFloat("Editor/", this.Speed);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/3D_Shield", this.FPECJFFEDOM);
			this.HILDKDFEBPF().SetVector("_InternalLutTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1862f, 1013f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A8E RID: 10894 RVA: 0x000E7D53 File Offset: 0x000E5F53
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A8F RID: 10895 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A90 RID: 10896 RVA: 0x000E7D8A File Offset: 0x000E5F8A
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A91 RID: 10897 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A92 RID: 10898 RVA: 0x000E7DC1 File Offset: 0x000E5FC1
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A93 RID: 10899 RVA: 0x000E7DE8 File Offset: 0x000E5FE8
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1768f)
			{
				this.HBJJOCHGOPH = 1225f;
			}
			this.ADGHJOHKEHG().SetFloat("[TextSaver] Text saved to ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PosX);
			this.OHKGGPFGLFD().SetFloat("#onrankchangeuptext", this.PosY);
			this.PHGCJOPFDOG().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", this.Speed);
			this.IGIAPKPKGPK().SetFloat(" not exist", this.FPECJFFEDOM);
			this.LENEJAGLCNL().SetVector("#close", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1735f, 983f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A94 RID: 10900 RVA: 0x000E7EE8 File Offset: 0x000E60E8
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 786f)
			{
				this.HBJJOCHGOPH = 1287f;
			}
			this.OCMBHMLNCEK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("Tab1Content", this.PosX);
			this.PLBEJJIHFPB().SetFloat("_Intensity", this.PosY);
			this.AELJLBOJAIL().SetFloat("<b>Time</b>:", this.Speed);
			this.AELJLBOJAIL().SetFloat("1159514800", this.FPECJFFEDOM);
			this.DOMEEFLPEPJ().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 523f, 1313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x000E7FE7 File Offset: 0x000E61E7
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("1087340967");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A97 RID: 10903 RVA: 0x000E804A File Offset: 0x000E624A
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("PunSupportLogger");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A98 RID: 10904 RVA: 0x000E806E File Offset: 0x000E626E
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("QuickSave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002A99 RID: 10905 RVA: 0x000E8092 File Offset: 0x000E6292
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x000E80C9 File Offset: 0x000E62C9
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find("_BlurDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002A9B RID: 10907 RVA: 0x000E80ED File Offset: 0x000E62ED
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A9C RID: 10908 RVA: 0x000E8124 File Offset: 0x000E6324
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A9D RID: 10909 RVA: 0x000E815B File Offset: 0x000E635B
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002A9E RID: 10910 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002A9F RID: 10911 RVA: 0x000E8194 File Offset: 0x000E6394
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 88f)
			{
				this.HBJJOCHGOPH = 1677f;
			}
			this.ADGHJOHKEHG().SetFloat("clear", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("CameraFilterPack/BlurTiltShift", this.PosX);
			this.KGOLDDBHIFN().SetFloat(" SecondsBeforeRespawn: ", this.PosY);
			this.PLBEJJIHFPB().SetFloat("_Green_B", this.Speed);
			this.DKNJGHFLAIF().SetFloat("#ok", this.FPECJFFEDOM);
			this.NDMPCDHADMJ().SetVector("CameraFilterPack/TV_BrokenGlass2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1387f, 1456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AA0 RID: 10912 RVA: 0x000E8294 File Offset: 0x000E6494
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 533f)
			{
				this.HBJJOCHGOPH = 1111f;
			}
			this.MICHFGAOPKM().SetFloat("x", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("Please specify a map name or buildID", this.PosX);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack_Paper1", this.PosY);
			this.KGOLDDBHIFN().SetFloat("#mapby", this.Speed);
			this.ALABBJPHCNG().SetFloat("value", this.FPECJFFEDOM);
			this.EHDJJANLINB().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1990f, 1993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x000E8393 File Offset: 0x000E6593
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x000E83CA File Offset: 0x000E65CA
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("ConnectToRegion: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x000E83F0 File Offset: 0x000E65F0
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 507f)
			{
				this.HBJJOCHGOPH = 1217f;
			}
			this.KBOPGONOCNP().SetFloat(": ", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("settings.hitvariation", this.PosX);
			this.DKNJGHFLAIF().SetFloat("[TextSaver] Text saved to ", this.PosY);
			this.IGIAPKPKGPK().SetFloat("_MainTex2", this.Speed);
			this.LENEJAGLCNL().SetFloat(" .", this.FPECJFFEDOM);
			this.IGIAPKPKGPK().SetVector(".completed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1158f, 1206f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x000E84EF File Offset: 0x000E66EF
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("local CheckCondition = function()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AA5 RID: 10917 RVA: 0x000E8514 File Offset: 0x000E6714
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1167f)
			{
				this.HBJJOCHGOPH = 93f;
			}
			this.NMDBCDFPGOK().SetFloat("RecordButton", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat(" elements", this.PosX);
			this.AELJLBOJAIL().SetFloat("LoadingStatusText", this.PosY);
			this.PDEAHJPOMEF().SetFloat("time", this.Speed);
			this.OCMBHMLNCEK().SetFloat("#close", this.FPECJFFEDOM);
			this.ADGHJOHKEHG().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 388f, 1084f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06002AA7 RID: 10919 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x06002AA8 RID: 10920 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AA9 RID: 10921 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06002AAA RID: 10922 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06002AAB RID: 10923 RVA: 0x000E8613 File Offset: 0x000E6813
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("/Segment-[Right]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AAC RID: 10924 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06002AAD RID: 10925 RVA: 0x000E8637 File Offset: 0x000E6837
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("SetParticlesParticleSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002AAE RID: 10926 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06002AAF RID: 10927 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06002AB0 RID: 10928 RVA: 0x000E753E File Offset: 0x000E573E
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AB1 RID: 10929 RVA: 0x000E865B File Offset: 0x000E685B
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002AB2 RID: 10930 RVA: 0x000E867F File Offset: 0x000E687F
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x000E86B6 File Offset: 0x000E68B6
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("menu.selectedlevelid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x000E86DA File Offset: 0x000E68DA
	private Material ALABBJPHCNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x000E8714 File Offset: 0x000E6914
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 21f)
			{
				this.HBJJOCHGOPH = 270f;
			}
			this.AELJLBOJAIL().SetFloat("X", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_Value2", this.PosX);
			this.OHKGGPFGLFD().SetFloat(". Prefab must have a PhotonView component.", this.PosY);
			this.EOCCJGIGEGJ().SetFloat("_Linecount", this.Speed);
			this.PDEAHJPOMEF().SetFloat("_Value", this.FPECJFFEDOM);
			this.KGOLDDBHIFN().SetVector("Write me to get one for testing :)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 254f, 1789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x000E8813 File Offset: 0x000E6A13
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x000E6CEF File Offset: 0x000E4EEF
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x000E884A File Offset: 0x000E6A4A
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("menu.selectedplaymode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06002ABC RID: 10940 RVA: 0x000E8870 File Offset: 0x000E6A70
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1279f)
			{
				this.HBJJOCHGOPH = 1338f;
			}
			this.AELJLBOJAIL().SetFloat("Map: ", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("#yes", this.PosX);
			this.DKNJGHFLAIF().SetFloat("Connection failed: ", this.PosY);
			this.KGOLDDBHIFN().SetFloat("_Value4", this.Speed);
			this.EPCGJFCCAFH().SetFloat(".g", this.FPECJFFEDOM);
			this.PLBEJJIHFPB().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1158f, 834f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002ABD RID: 10941 RVA: 0x000E896F File Offset: 0x000E6B6F
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000517 RID: 1303
	public Shader SCShader;

	// Token: 0x04000518 RID: 1304
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000519 RID: 1305
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400051A RID: 1306
	private Material BJFKDHHMLJH;

	// Token: 0x0400051B RID: 1307
	[Range(-1.5f, 1.5f)]
	public float PosX = 0.5f;

	// Token: 0x0400051C RID: 1308
	[Range(-1.5f, 1.5f)]
	public float PosY = 0.5f;

	// Token: 0x0400051D RID: 1309
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x0400051E RID: 1310
	[Range(0f, 10f)]
	private float FPECJFFEDOM = 1f;
}
