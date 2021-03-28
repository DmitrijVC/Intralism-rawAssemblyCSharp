using System;
using UnityEngine;

// Token: 0x0200011E RID: 286
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Old Film/Old_Movie_2")]
public class CameraFilterPack_TV_Old_Movie_2 : MonoBehaviour
{
	// Token: 0x060059CC RID: 22988 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059CD RID: 22989 RVA: 0x001BBFC9 File Offset: 0x001BA1C9
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059CE RID: 22990 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x060059CF RID: 22991 RVA: 0x001BC000 File Offset: 0x001BA200
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059D0 RID: 22992 RVA: 0x001BC037 File Offset: 0x001BA237
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059D1 RID: 22993 RVA: 0x0002523B File Offset: 0x0002343B
	private void KNBJBNDGCIJ()
	{
	}

	// Token: 0x060059D2 RID: 22994 RVA: 0x0002523B File Offset: 0x0002343B
	private void MGMAOBPPOBJ()
	{
	}

	// Token: 0x060059D3 RID: 22995 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059D4 RID: 22996 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKOMIDCPCDC()
	{
	}

	// Token: 0x060059D5 RID: 22997 RVA: 0x001BC070 File Offset: 0x001BA270
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 176f)
			{
				this.HBJJOCHGOPH = 1802f;
			}
			this.EFDEIFCDAFG().SetFloat("[MapEditor] Updating map assets", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat(".wav", this.FramePerSecond);
			this.LONNIJMNKFB().SetFloat("#ok", this.Contrast);
			this.HEINDEMCGIK().SetFloat("SetSatelliteColor", this.Burn);
			this.MICHFGAOPKM().SetFloat("1,30,true,0", this.SceneCut);
			this.EHDJJANLINB().SetFloat("SpawnObj", this.Fade);
			this.LPDOGGFOBDH().SetVector("PossibleMapPointsText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 456f, 152f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059D6 RID: 22998 RVA: 0x001BC188 File Offset: 0x001BA388
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 960f)
			{
				this.HBJJOCHGOPH = 46f;
			}
			this.OGMEGHKECAH().SetFloat(".lastCheckpoint.bgcolor", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("recipes", this.FramePerSecond);
			this.EHDJJANLINB().SetFloat("SetSatelliteEmission", this.Contrast);
			this.MICHFGAOPKM().SetFloat("_ColorLevel", this.Burn);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack/Blend2Camera_Overlay", this.SceneCut);
			this.NBPKMLMCHFN.SetFloat(": ", this.Fade);
			this.LPPEPKGFOEM().SetVector("_Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 865f, 328f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059D7 RID: 22999 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060059D8 RID: 23000 RVA: 0x001BC2A0 File Offset: 0x001BA4A0
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 645f)
			{
				this.HBJJOCHGOPH = 897f;
			}
			this.BAGICADFBAB().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_Offsets", this.FramePerSecond);
			this.ADBKPGFMNKO().SetFloat("_Params1", this.Contrast);
			this.GJHPODJOBHL().SetFloat("_Parasite", this.Burn);
			this.HKGAONMOBMH().SetFloat("Network destroy Instantiated GO: ", this.SceneCut);
			this.HKHBBBFLGJH().SetFloat("CameraFilterPack/Edge_Golden", this.Fade);
			this.AELJLBOJAIL().SetVector("ItemsCountText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 928f, 1730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059D9 RID: 23001 RVA: 0x0002523B File Offset: 0x0002343B
	private void DKGBFNCOAEO()
	{
	}

	// Token: 0x060059DA RID: 23002 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x060059DB RID: 23003 RVA: 0x001BC3B5 File Offset: 0x001BA5B5
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059DC RID: 23004 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060059DD RID: 23005 RVA: 0x001BC3EC File Offset: 0x001BA5EC
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1521f)
			{
				this.HBJJOCHGOPH = 232f;
			}
			this.LMLENGFLEBD().SetFloat("Uploading content", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("settings.enablerankingnotifications", this.FramePerSecond);
			this.OGMEGHKECAH().SetFloat("[Singleton] An instance of '", this.Contrast);
			this.EFMCNLELMDO().SetFloat("_Value3", this.Burn);
			this.GJHPODJOBHL().SetFloat(" does not exist!", this.SceneCut);
			this.NBPKMLMCHFN.SetFloat("Set satellite trail width", this.Fade);
			this.HKGAONMOBMH().SetVector(". The group number should be at least 1.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 742f, 809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059DE RID: 23006 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059DF RID: 23007 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMCPMOGKDEH()
	{
	}

	// Token: 0x060059E0 RID: 23008 RVA: 0x001BC504 File Offset: 0x001BA704
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 894f)
			{
				this.HBJJOCHGOPH = 1313f;
			}
			this.MLMKCOINOOH().SetFloat("MapEditor v.", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("menu.selectedplaymode", this.FramePerSecond);
			this.EHDJJANLINB().SetFloat("settings.crosshairopacity", this.Contrast);
			this.LPDOGGFOBDH().SetFloat("_ScreenResolution", this.Burn);
			this.DOHGBNPMBKG().SetFloat("IconImage", this.SceneCut);
			this.LPDOGGFOBDH().SetFloat("r", this.Fade);
			this.AELJLBOJAIL().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1020f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059E1 RID: 23009 RVA: 0x001BC619 File Offset: 0x001BA819
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059E2 RID: 23010 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059E3 RID: 23011 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059E4 RID: 23012 RVA: 0x001BC650 File Offset: 0x001BA850
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059E5 RID: 23013 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059E6 RID: 23014 RVA: 0x001BC688 File Offset: 0x001BA888
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 699f)
			{
				this.HBJJOCHGOPH = 1241f;
			}
			this.DOHGBNPMBKG().SetFloat(" Time: ", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("#challengecomplete", this.FramePerSecond);
			this.HKHBBBFLGJH().SetFloat("#onrankchangeuptext", this.Contrast);
			this.DNLMFEGJJDD().SetFloat("Set Sun Lerp Speed", this.Burn);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.SceneCut);
			this.BAGICADFBAB().SetFloat("_Value2", this.Fade);
			this.GJHPODJOBHL().SetVector("Left", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1153f, 329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059E7 RID: 23015 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPEGAEGDJAM()
	{
	}

	// Token: 0x060059E8 RID: 23016 RVA: 0x001BC79D File Offset: 0x001BA99D
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059E9 RID: 23017 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060059EA RID: 23018 RVA: 0x001BC7D4 File Offset: 0x001BA9D4
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059EB RID: 23019 RVA: 0x001BC80C File Offset: 0x001BAA0C
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1601f)
			{
				this.HBJJOCHGOPH = 1025f;
			}
			this.BAGICADFBAB().SetFloat("seconds", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("input", this.FramePerSecond);
			this.LPDOGGFOBDH().SetFloat("_MainTex2", this.Contrast);
			this.GHHPOGODBHB().SetFloat("BitsData", this.Burn);
			this.LONNIJMNKFB().SetFloat("#timeuntilchallenge: ", this.SceneCut);
			this.MICHFGAOPKM().SetFloat("inventory.selected.", this.Fade);
			this.MICHFGAOPKM().SetVector("SetSatelliteTrailWidth", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 687f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059EC RID: 23020 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059ED RID: 23021 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059EF RID: 23023 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059F0 RID: 23024 RVA: 0x001BC960 File Offset: 0x001BAB60
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1398f)
			{
				this.HBJJOCHGOPH = 407f;
			}
			this.LDNADDJMIPK().SetFloat("MenuScene", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/TV_Vcr", this.FramePerSecond);
			this.HKHBBBFLGJH().SetFloat("Connected to NameServer.", this.Contrast);
			this.DOHGBNPMBKG().SetFloat(".lastCheckpoint.perfectHits", this.Burn);
			this.LPDOGGFOBDH().SetFloat("Save", this.SceneCut);
			this.KDMBOKLMADJ().SetFloat("_Offsets", this.Fade);
			this.NBPKMLMCHFN.SetVector("[LocalizationService] All languages: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 952f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059F1 RID: 23025 RVA: 0x001BCA78 File Offset: 0x001BAC78
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 487f)
			{
				this.HBJJOCHGOPH = 1092f;
			}
			this.AELJLBOJAIL().SetFloat("-1", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_Noise", this.FramePerSecond);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Film_ColorPerfection", this.Contrast);
			this.MLMKCOINOOH().SetFloat("cancel", this.Burn);
			this.LMLENGFLEBD().SetFloat("ConnectToRegion: ", this.SceneCut);
			this.AELJLBOJAIL().SetFloat("_Value3", this.Fade);
			this.KDMBOKLMADJ().SetVector("caret", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 297f, 1885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059F2 RID: 23026 RVA: 0x001BCB90 File Offset: 0x001BAD90
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 884f)
			{
				this.HBJJOCHGOPH = 475f;
			}
			this.HKHBBBFLGJH().SetFloat("Joystick1Button10", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("ComboScoreText", this.FramePerSecond);
			this.MFHPKGICPIO().SetFloat("_Bloom5", this.Contrast);
			this.GHHPOGODBHB().SetFloat("_TimeX", this.Burn);
			this.LPDOGGFOBDH().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", this.SceneCut);
			this.MICHFGAOPKM().SetFloat("RecieveChatActionMessage", this.Fade);
			this.HEHKGPKLAKK().SetVector("settings.enablehitsoundsinrelax", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1307f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059F3 RID: 23027 RVA: 0x0002523B File Offset: 0x0002343B
	private void CIPKEPDELJB()
	{
	}

	// Token: 0x060059F4 RID: 23028 RVA: 0x001BCCA5 File Offset: 0x001BAEA5
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059F5 RID: 23029 RVA: 0x001BCCDC File Offset: 0x001BAEDC
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059F6 RID: 23030 RVA: 0x001BCD13 File Offset: 0x001BAF13
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059F7 RID: 23031 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x060059F8 RID: 23032 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059F9 RID: 23033 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x060059FA RID: 23034 RVA: 0x001BCD4A File Offset: 0x001BAF4A
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059FB RID: 23035 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060059FC RID: 23036 RVA: 0x001BCD81 File Offset: 0x001BAF81
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059FD RID: 23037 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060059FE RID: 23038 RVA: 0x001BCDB8 File Offset: 0x001BAFB8
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 855f)
			{
				this.HBJJOCHGOPH = 1507f;
			}
			this.AELJLBOJAIL().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.FramePerSecond);
			this.GCDFNHMJMIP().SetFloat("Unsupported target enum: ", this.Contrast);
			this.DOHGBNPMBKG().SetFloat("_LutTex", this.Burn);
			this.OCHJIMJNEMO().SetFloat("Fill Area", this.SceneCut);
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.Fade);
			this.PLBEJJIHFPB().SetVector("PlayMusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1962f, 1289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059FF RID: 23039 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06005A00 RID: 23040 RVA: 0x001BCECD File Offset: 0x001BB0CD
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

	// Token: 0x06005A01 RID: 23041 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNCHGLIEMA()
	{
	}

	// Token: 0x06005A02 RID: 23042 RVA: 0x001BC037 File Offset: 0x001BA237
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A03 RID: 23043 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A04 RID: 23044 RVA: 0x001BCF04 File Offset: 0x001BB104
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A05 RID: 23045 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06005A06 RID: 23046 RVA: 0x0002523B File Offset: 0x0002343B
	private void DFFKKLAPHCC()
	{
	}

	// Token: 0x06005A07 RID: 23047 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06005A08 RID: 23048 RVA: 0x001BCF3B File Offset: 0x001BB13B
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A09 RID: 23049 RVA: 0x001BCF74 File Offset: 0x001BB174
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1156f)
			{
				this.HBJJOCHGOPH = 1393f;
			}
			this.DNLMFEGJJDD().SetFloat("Icon", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("/files/mods_terms.pdf", this.FramePerSecond);
			this.GJHPODJOBHL().SetFloat("_Value2", this.Contrast);
			this.MICHFGAOPKM().SetFloat("_Value", this.Burn);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.SceneCut);
			this.MLMKCOINOOH().SetFloat("/icon", this.Fade);
			this.LDNADDJMIPK().SetVector("roomDescription", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 558f, 604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A0A RID: 23050 RVA: 0x001BD08C File Offset: 0x001BB28C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 121f)
			{
				this.HBJJOCHGOPH = 498f;
			}
			this.LONNIJMNKFB().SetFloat("Source Object: ", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("?", this.FramePerSecond);
			this.KDMBOKLMADJ().SetFloat("note.5", this.Contrast);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/BlurTiltShift_Hole", this.Burn);
			this.CFEDGDGBCHE().SetFloat("{0:0}", this.SceneCut);
			this.GCDFNHMJMIP().SetFloat("<color=#", this.Fade);
			this.EHDJJANLINB().SetVector("0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 817f, 597f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A0B RID: 23051 RVA: 0x001BD1A1 File Offset: 0x001BB3A1
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A0C RID: 23052 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A0D RID: 23053 RVA: 0x001BD1D8 File Offset: 0x001BB3D8
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1701f)
			{
				this.HBJJOCHGOPH = 1881f;
			}
			this.PLBEJJIHFPB().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.FramePerSecond);
			this.BAGICADFBAB().SetFloat(" - LOCAL", this.Contrast);
			this.DOHGBNPMBKG().SetFloat("B", this.Burn);
			this.PLBEJJIHFPB().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", this.SceneCut);
			this.CFEDGDGBCHE().SetFloat("colorD", this.Fade);
			this.LONNIJMNKFB().SetVector("_WorldToCameraMatrix", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 741f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A0E RID: 23054 RVA: 0x0002523B File Offset: 0x0002343B
	private void NNCCPEBIAKH()
	{
	}

	// Token: 0x06005A0F RID: 23055 RVA: 0x0002523B File Offset: 0x0002343B
	private void COOHIILCOCO()
	{
	}

	// Token: 0x06005A10 RID: 23056 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKIMDFLBFOM()
	{
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDNHCLKNCLE()
	{
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06005A13 RID: 23059 RVA: 0x001BD2ED File Offset: 0x001BB4ED
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A14 RID: 23060 RVA: 0x001BD324 File Offset: 0x001BB524
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A15 RID: 23061 RVA: 0x001BD35B File Offset: 0x001BB55B
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A16 RID: 23062 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A17 RID: 23063 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A18 RID: 23064 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06005A19 RID: 23065 RVA: 0x001BD392 File Offset: 0x001BB592
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A1A RID: 23066 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06005A1B RID: 23067 RVA: 0x001BD3C9 File Offset: 0x001BB5C9
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A1C RID: 23068 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06005A1D RID: 23069 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06005A1E RID: 23070 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKLOBJHKFEO()
	{
	}

	// Token: 0x06005A1F RID: 23071 RVA: 0x0002523B File Offset: 0x0002343B
	private void IMCKJCHKMKB()
	{
	}

	// Token: 0x06005A20 RID: 23072 RVA: 0x001BD400 File Offset: 0x001BB600
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A21 RID: 23073 RVA: 0x001BD438 File Offset: 0x001BB638
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1160f)
			{
				this.HBJJOCHGOPH = 436f;
			}
			this.LONNIJMNKFB().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("GlassDistortion", this.FramePerSecond);
			this.LPDOGGFOBDH().SetFloat("_SecondTex", this.Contrast);
			this.HEHKGPKLAKK().SetFloat("...", this.Burn);
			this.DNLMFEGJJDD().SetFloat("BitsData", this.SceneCut);
			this.LONNIJMNKFB().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", this.Fade);
			this.HEINDEMCGIK().SetVector("SpectateButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1414f, 1761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A22 RID: 23074 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06005A23 RID: 23075 RVA: 0x001BD550 File Offset: 0x001BB750
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 4f)
			{
				this.HBJJOCHGOPH = 1652f;
			}
			this.MLMKCOINOOH().SetFloat("ShadersToggle", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("BestScoreText", this.FramePerSecond);
			this.LONNIJMNKFB().SetFloat("Left", this.Contrast);
			this.BAGICADFBAB().SetFloat("/", this.Burn);
			this.OCHJIMJNEMO().SetFloat("_Screen", this.SceneCut);
			this.NBPKMLMCHFN.SetFloat("colorD", this.Fade);
			this.DOHGBNPMBKG().SetVector("CameraFilterPack/Vision_Blood", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1066f, 1686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A24 RID: 23076 RVA: 0x001BD668 File Offset: 0x001BB868
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1016f)
			{
				this.HBJJOCHGOPH = 1765f;
			}
			this.OGMEGHKECAH().SetFloat("_Fade", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("#task", this.FramePerSecond);
			this.EFMCNLELMDO().SetFloat("_Jitter", this.Contrast);
			this.MFHPKGICPIO().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", this.Burn);
			this.HKGAONMOBMH().SetFloat("LevelInfoInputField", this.SceneCut);
			this.EHDJJANLINB().SetFloat("No Camera attached!", this.Fade);
			this.NBPKMLMCHFN.SetVector("_Blue_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 379f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A25 RID: 23077 RVA: 0x001BD780 File Offset: 0x001BB980
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.FramePerSecond);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Contrast);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Burn);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.SceneCut);
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A26 RID: 23078 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x06005A27 RID: 23079 RVA: 0x0002523B File Offset: 0x0002343B
	private void CHOPDIGHJNH()
	{
	}

	// Token: 0x06005A28 RID: 23080 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A29 RID: 23081 RVA: 0x001BD895 File Offset: 0x001BBA95
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A2A RID: 23082 RVA: 0x001BD8CC File Offset: 0x001BBACC
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A2B RID: 23083 RVA: 0x001BD903 File Offset: 0x001BBB03
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A2C RID: 23084 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A2D RID: 23085 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A2E RID: 23086 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005A2F RID: 23087 RVA: 0x0002523B File Offset: 0x0002343B
	private void MNBPNHNAEBK()
	{
	}

	// Token: 0x06005A30 RID: 23088 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06005A31 RID: 23089 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDMDKOKOOJC()
	{
	}

	// Token: 0x06005A32 RID: 23090 RVA: 0x001BBFAC File Offset: 0x001BA1AC
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A33 RID: 23091 RVA: 0x001BD93A File Offset: 0x001BBB3A
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A34 RID: 23092 RVA: 0x001BD974 File Offset: 0x001BBB74
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1107f)
			{
				this.HBJJOCHGOPH = 266f;
			}
			this.DOHGBNPMBKG().SetFloat("player.playedtutorial", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("#tryagain", this.FramePerSecond);
			this.KDMBOKLMADJ().SetFloat("SpawnObj", this.Contrast);
			this.HEINDEMCGIK().SetFloat("maps.", this.Burn);
			this.HKHBBBFLGJH().SetFloat("x", this.SceneCut);
			this.CFEDGDGBCHE().SetFloat("_Distortion", this.Fade);
			this.ADBKPGFMNKO().SetVector("_MainTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 229f, 1286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A35 RID: 23093 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005A36 RID: 23094 RVA: 0x001BDA89 File Offset: 0x001BBC89
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000935 RID: 2357
	public Shader SCShader;

	// Token: 0x04000936 RID: 2358
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000937 RID: 2359
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000938 RID: 2360
	private Material BJFKDHHMLJH;

	// Token: 0x04000939 RID: 2361
	[Range(1f, 60f)]
	public float FramePerSecond = 15f;

	// Token: 0x0400093A RID: 2362
	[Range(0f, 5f)]
	public float Contrast = 1f;

	// Token: 0x0400093B RID: 2363
	[Range(0f, 4f)]
	public float Burn;

	// Token: 0x0400093C RID: 2364
	[Range(0f, 16f)]
	public float SceneCut = 1f;

	// Token: 0x0400093D RID: 2365
	[Range(0f, 1f)]
	public float Fade = 1f;
}
