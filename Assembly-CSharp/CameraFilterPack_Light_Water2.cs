using System;
using UnityEngine;

// Token: 0x020000EE RID: 238
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Light/Water2")]
public class CameraFilterPack_Light_Water2 : MonoBehaviour
{
	// Token: 0x0600494A RID: 18762 RVA: 0x0016531B File Offset: 0x0016351B
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600494B RID: 18763 RVA: 0x00165352 File Offset: 0x00163552
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600494C RID: 18764 RVA: 0x0016538C File Offset: 0x0016358C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1913f)
			{
				this.HBJJOCHGOPH = 1781f;
			}
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/Glasses_On", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_MainTex2", this.Speed);
			this.IONHGBPGCHK().SetFloat("_Value1", this.Speed_X);
			this.AELJLBOJAIL().SetFloat("ExitButton", this.Speed_Y);
			this.AELJLBOJAIL().SetFloat("GO==null", this.Intensity);
			this.KGOLDDBHIFN().SetVector("[PlayerBase] Loaded spawner data", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 561f, 1124f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600494D RID: 18765 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600494E RID: 18766 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x0600494F RID: 18767 RVA: 0x0016548B File Offset: 0x0016368B
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004950 RID: 18768 RVA: 0x0016548B File Offset: 0x0016368B
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004951 RID: 18769 RVA: 0x0016548B File Offset: 0x0016368B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004952 RID: 18770 RVA: 0x0016548B File Offset: 0x0016368B
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004953 RID: 18771 RVA: 0x001654A8 File Offset: 0x001636A8
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004954 RID: 18772 RVA: 0x001654CC File Offset: 0x001636CC
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Light_Water2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004955 RID: 18773 RVA: 0x0016548B File Offset: 0x0016368B
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004956 RID: 18774 RVA: 0x001654F0 File Offset: 0x001636F0
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("ERROR: Preview file must be <1MB!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004957 RID: 18775 RVA: 0x00165514 File Offset: 0x00163714
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 609f)
			{
				this.HBJJOCHGOPH = 1830f;
			}
			this.FKEOGPDLBDD().SetFloat("PopulateMapsList", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("Scene", this.Speed);
			this.HEINDEMCGIK().SetFloat("_TimeX", this.Speed_X);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/FX_8bits", this.Speed_Y);
			this.FLOHGDECHHH().SetFloat("bpmgrid", this.Intensity);
			this.NDMPCDHADMJ().SetVector("Checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 1386f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004958 RID: 18776 RVA: 0x0016548B File Offset: 0x0016368B
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004959 RID: 18777 RVA: 0x0016548B File Offset: 0x0016368B
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600495A RID: 18778 RVA: 0x0016548B File Offset: 0x0016368B
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600495B RID: 18779 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x0600495C RID: 18780 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x0600495D RID: 18781 RVA: 0x00165613 File Offset: 0x00163813
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600495E RID: 18782 RVA: 0x0016564A File Offset: 0x0016384A
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

	// Token: 0x0600495F RID: 18783 RVA: 0x00165684 File Offset: 0x00163884
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1228f)
			{
				this.HBJJOCHGOPH = 390f;
			}
			this.NMDBCDFPGOK().SetFloat("/", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("JITTER", this.Speed);
			this.FLOHGDECHHH().SetFloat("_Radius", this.Speed_X);
			this.INOBFNCKFGK().SetFloat("_Bullet_3", this.Speed_Y);
			this.NBPKMLMCHFN.SetFloat("wss://", this.Intensity);
			this.IONHGBPGCHK().SetVector("Editor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 808f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004960 RID: 18784 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06004961 RID: 18785 RVA: 0x00165783 File Offset: 0x00163983
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004962 RID: 18786 RVA: 0x001657BA File Offset: 0x001639BA
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004963 RID: 18787 RVA: 0x001657E0 File Offset: 0x001639E0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 553f)
			{
				this.HBJJOCHGOPH = 457f;
			}
			this.INOBFNCKFGK().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat(".mp3", this.Speed);
			this.NLFJGMBCICG().SetFloat("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!", this.Speed_X);
			this.KGOLDDBHIFN().SetFloat("skin.hit_perfect", this.Speed_Y);
			this.AELJLBOJAIL().SetFloat("x", this.Intensity);
			this.DKNJGHFLAIF().SetVector("#EA4137", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 155f, 215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004964 RID: 18788 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06004965 RID: 18789 RVA: 0x0016548B File Offset: 0x0016368B
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004966 RID: 18790 RVA: 0x001658E0 File Offset: 0x00163AE0
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1828f)
			{
				this.HBJJOCHGOPH = 1967f;
			}
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("_Value11", this.Speed);
			this.FLOHGDECHHH().SetFloat("https://steamcommunity.com/app/513510/workshop/", this.Speed_X);
			this.FKEOGPDLBDD().SetFloat("_ScreenResolution", this.Speed_Y);
			this.NDMPCDHADMJ().SetFloat("/", this.Intensity);
			this.FLOHGDECHHH().SetVector(" Mb", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1498f, 1723f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004967 RID: 18791 RVA: 0x001659E0 File Offset: 0x00163BE0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 341f)
			{
				this.HBJJOCHGOPH = 1815f;
			}
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", this.Speed);
			this.FKEOGPDLBDD().SetFloat("ItemTemplate", this.Speed_X);
			this.KDMBOKLMADJ().SetFloat("SetSunInput", this.Speed_Y);
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", this.Intensity);
			this.INOBFNCKFGK().SetVector("menu.selectedlevelid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1818f, 443f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004968 RID: 18792 RVA: 0x00165ADF File Offset: 0x00163CDF
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("float,1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004969 RID: 18793 RVA: 0x00165B03 File Offset: 0x00163D03
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600496A RID: 18794 RVA: 0x0016548B File Offset: 0x0016368B
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600496B RID: 18795 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x0600496C RID: 18796 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x0600496D RID: 18797 RVA: 0x00165B3A File Offset: 0x00163D3A
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600496E RID: 18798 RVA: 0x0016548B File Offset: 0x0016368B
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600496F RID: 18799 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06004970 RID: 18800 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06004971 RID: 18801 RVA: 0x00165B74 File Offset: 0x00163D74
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1979f)
			{
				this.HBJJOCHGOPH = 1419f;
			}
			this.NMDBCDFPGOK().SetFloat("OxOD.lastPath", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.Speed);
			this.OIMMPLPBLBK().SetFloat("UI Extensions/SoftMaskShader", this.Speed_X);
			this.NLFJGMBCICG().SetFloat("<b>#banended</b>", this.Speed_Y);
			this.FGENHBKMPDA().SetFloat(" ", this.Intensity);
			this.FLOHGDECHHH().SetVector("TimeBGSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 711f, 1003f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004972 RID: 18802 RVA: 0x00165C74 File Offset: 0x00163E74
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 314f)
			{
				this.HBJJOCHGOPH = 1649f;
			}
			this.CIAFLBFJLEJ().SetFloat("Vignette", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("settings.enableranking", this.Speed);
			this.DEFBJOCJJKF().SetFloat(" / ", this.Speed_X);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.Speed_Y);
			this.KGOLDDBHIFN().SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this.Intensity);
			this.PLBEJJIHFPB().SetVector("_Green_B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1959f, 439f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004973 RID: 18803 RVA: 0x00165D73 File Offset: 0x00163F73
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("LevelEditor/icons");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004974 RID: 18804 RVA: 0x00165D98 File Offset: 0x00163F98
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1274f)
			{
				this.HBJJOCHGOPH = 1291f;
			}
			this.NDMPCDHADMJ().SetFloat("EventMenu", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("#tryagain", this.Speed);
			this.OIMMPLPBLBK().SetFloat("_EdgeWeight", this.Speed_X);
			this.PLBEJJIHFPB().SetFloat("_Value9", this.Speed_Y);
			this.KGOLDDBHIFN().SetFloat("PublishButton", this.Intensity);
			this.FAIFBBGFAIB().SetVector("selColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 909f, 202f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004975 RID: 18805 RVA: 0x00165E98 File Offset: 0x00164098
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1849f)
			{
				this.HBJJOCHGOPH = 584f;
			}
			this.DEFBJOCJJKF().SetFloat("OnReadyClick", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("[MapEditor] Exported to ", this.Speed);
			this.FAIFBBGFAIB().SetFloat("Jun", this.Speed_X);
			this.KGOLDDBHIFN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.Speed_Y);
			this.NDMPCDHADMJ().SetFloat("Fill", this.Intensity);
			this.AELJLBOJAIL().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1613f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004976 RID: 18806 RVA: 0x00165F97 File Offset: 0x00164197
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004977 RID: 18807 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06004978 RID: 18808 RVA: 0x00165FCE File Offset: 0x001641CE
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("ItemNameBGImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004979 RID: 18809 RVA: 0x00165FF2 File Offset: 0x001641F2
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600497A RID: 18810 RVA: 0x0016548B File Offset: 0x0016368B
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600497B RID: 18811 RVA: 0x0016548B File Offset: 0x0016368B
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600497C RID: 18812 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x0600497D RID: 18813 RVA: 0x0016548B File Offset: 0x0016368B
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600497E RID: 18814 RVA: 0x0016548B File Offset: 0x0016368B
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600497F RID: 18815 RVA: 0x0016602C File Offset: 0x0016422C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 47f)
			{
				this.HBJJOCHGOPH = 1214f;
			}
			this.OIMMPLPBLBK().SetFloat("Right", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("skin.", this.Speed);
			this.CIAFLBFJLEJ().SetFloat("ShineEffect", this.Speed_X);
			this.PLBEJJIHFPB().SetFloat("Preparing configuration", this.Speed_Y);
			this.OIMMPLPBLBK().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", this.Intensity);
			this.FKEOGPDLBDD().SetVector("Incoming: \n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 930f, 374f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004980 RID: 18816 RVA: 0x0016612B File Offset: 0x0016432B
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004981 RID: 18817 RVA: 0x0016548B File Offset: 0x0016368B
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004982 RID: 18818 RVA: 0x00166162 File Offset: 0x00164362
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("PenaltyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004983 RID: 18819 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x00166186 File Offset: 0x00164386
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004985 RID: 18821 RVA: 0x001661BD File Offset: 0x001643BD
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("[Up-Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004986 RID: 18822 RVA: 0x001661E4 File Offset: 0x001643E4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed_X);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Speed_Y);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Intensity);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004987 RID: 18823 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06004988 RID: 18824 RVA: 0x0016548B File Offset: 0x0016368B
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004989 RID: 18825 RVA: 0x0016548B File Offset: 0x0016368B
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600498A RID: 18826 RVA: 0x001662E3 File Offset: 0x001644E3
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("TotalHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600498B RID: 18827 RVA: 0x00166308 File Offset: 0x00164508
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 442f)
			{
				this.HBJJOCHGOPH = 1650f;
			}
			this.FGENHBKMPDA().SetFloat("_NeighbourMaxTex", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("[PowerUp]", this.Speed);
			this.NMDBCDFPGOK().SetFloat("GhostSize", this.Speed_X);
			this.KDMBOKLMADJ().SetFloat("player.goldcrystal", this.Speed_Y);
			this.AELJLBOJAIL().SetFloat("settings.disablestoryboard", this.Intensity);
			this.CIAFLBFJLEJ().SetVector("Jump", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1183f, 614f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600498C RID: 18828 RVA: 0x00166407 File Offset: 0x00164607
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("player.mysteryitem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600498D RID: 18829 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x0600498E RID: 18830 RVA: 0x0016642B File Offset: 0x0016462B
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("ENABLE_COLOR_GRADING");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600498F RID: 18831 RVA: 0x0016548B File Offset: 0x0016368B
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004990 RID: 18832 RVA: 0x00166450 File Offset: 0x00164650
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 932f)
			{
				this.HBJJOCHGOPH = 1902f;
			}
			this.FAIFBBGFAIB().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("PhotonView with ID ", this.Speed);
			this.NMDBCDFPGOK().SetFloat("/", this.Speed_X);
			this.KGOLDDBHIFN().SetFloat("settings.enableselectormusic", this.Speed_Y);
			this.CIAFLBFJLEJ().SetFloat("\n", this.Intensity);
			this.KGOLDDBHIFN().SetVector("ns", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 638f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004991 RID: 18833 RVA: 0x00166550 File Offset: 0x00164750
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 330f)
			{
				this.HBJJOCHGOPH = 1671f;
			}
			this.OIMMPLPBLBK().SetFloat("float,0.5", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("SetSpeed", this.Speed);
			this.KGOLDDBHIFN().SetFloat("In Map Editor", this.Speed_X);
			this.DEFBJOCJJKF().SetFloat("_Value4", this.Speed_Y);
			this.FGENHBKMPDA().SetFloat("_Distortion", this.Intensity);
			this.CIAFLBFJLEJ().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 552f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004992 RID: 18834 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06004993 RID: 18835 RVA: 0x00166650 File Offset: 0x00164850
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1635f)
			{
				this.HBJJOCHGOPH = 510f;
			}
			this.NDMPCDHADMJ().SetFloat("id", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/Glasses_On", this.Speed);
			this.FLOHGDECHHH().SetFloat("_EmissionGain", this.Speed_X);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/TV_CompressionFX", this.Speed_Y);
			this.NMDBCDFPGOK().SetFloat("[Singleton] multiple instances of '", this.Intensity);
			this.FAIFBBGFAIB().SetVector("STICKLHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1984f, 952f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004994 RID: 18836 RVA: 0x00166750 File Offset: 0x00164950
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1822f)
			{
				this.HBJJOCHGOPH = 386f;
			}
			this.CIAFLBFJLEJ().SetFloat("player.goldcrystal", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("_RedAmplifier", this.Speed);
			this.FAIFBBGFAIB().SetFloat("Result for ", this.Speed_X);
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.Speed_Y);
			this.PLBEJJIHFPB().SetFloat("_Value3", this.Intensity);
			this.DEFBJOCJJKF().SetVector("_Blue_B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1683f, 169f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004995 RID: 18837 RVA: 0x0016684F File Offset: 0x00164A4F
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004996 RID: 18838 RVA: 0x0016548B File Offset: 0x0016368B
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004997 RID: 18839 RVA: 0x0016548B File Offset: 0x0016368B
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004998 RID: 18840 RVA: 0x00166886 File Offset: 0x00164A86
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("[SERVER] Player ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004999 RID: 18841 RVA: 0x001668AC File Offset: 0x00164AAC
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 493f)
			{
				this.HBJJOCHGOPH = 1235f;
			}
			this.HEINDEMCGIK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_Value2", this.Speed);
			this.DEFBJOCJJKF().SetFloat("SetSatelliteTrailLength", this.Speed_X);
			this.INOBFNCKFGK().SetFloat("Tab2Content", this.Speed_Y);
			this.AELJLBOJAIL().SetFloat("_TargetScale", this.Intensity);
			this.KGOLDDBHIFN().SetVector("_LumTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1239f, 1440f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600499A RID: 18842 RVA: 0x001669AB File Offset: 0x00164BAB
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600499B RID: 18843 RVA: 0x001669E2 File Offset: 0x00164BE2
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("Set Particle Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600499C RID: 18844 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x0600499D RID: 18845 RVA: 0x0016548B File Offset: 0x0016368B
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600499E RID: 18846 RVA: 0x0016548B File Offset: 0x0016368B
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600499F RID: 18847 RVA: 0x00166A06 File Offset: 0x00164C06
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049A0 RID: 18848 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x060049A1 RID: 18849 RVA: 0x00166A3D File Offset: 0x00164C3D
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("RestartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060049A2 RID: 18850 RVA: 0x0016548B File Offset: 0x0016368B
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049A3 RID: 18851 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060049A4 RID: 18852 RVA: 0x00166A64 File Offset: 0x00164C64
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1808f)
			{
				this.HBJJOCHGOPH = 212f;
			}
			this.NLFJGMBCICG().SetFloat("IDInputField", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("note.6", this.Speed);
			this.NLFJGMBCICG().SetFloat("workshop.", this.Speed_X);
			this.INOBFNCKFGK().SetFloat("time: ", this.Speed_Y);
			this.FAIFBBGFAIB().SetFloat("_TimeX", this.Intensity);
			this.FLOHGDECHHH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 514f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049A6 RID: 18854 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060049A7 RID: 18855 RVA: 0x00166BA2 File Offset: 0x00164DA2
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049A8 RID: 18856 RVA: 0x00166BD9 File Offset: 0x00164DD9
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049A9 RID: 18857 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060049AA RID: 18858 RVA: 0x00166C10 File Offset: 0x00164E10
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 17f;
			}
			this.FLOHGDECHHH().SetFloat("UseScanLine", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("ResourceIDInputField", this.Speed);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack_TV_HorrorFX", this.Speed_X);
			this.DKNJGHFLAIF().SetFloat(" ", this.Speed_Y);
			this.FGENHBKMPDA().SetFloat("[Up-Right-Down-Left]", this.Intensity);
			this.INOBFNCKFGK().SetVector("SetSunSensitivity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 561f, 1531f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049AB RID: 18859 RVA: 0x0016548B File Offset: 0x0016368B
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049AC RID: 18860 RVA: 0x00166D0F File Offset: 0x00164F0F
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049AD RID: 18861 RVA: 0x00166D46 File Offset: 0x00164F46
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049AE RID: 18862 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060049AF RID: 18863 RVA: 0x0016548B File Offset: 0x0016368B
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049B0 RID: 18864 RVA: 0x00166D7D File Offset: 0x00164F7D
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find(".status");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060049B1 RID: 18865 RVA: 0x00166DA4 File Offset: 0x00164FA4
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1054f)
			{
				this.HBJJOCHGOPH = 299f;
			}
			this.FLOHGDECHHH().SetFloat("input", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("EventSystem", this.Speed);
			this.FAIFBBGFAIB().SetFloat("BitsData", this.Speed_X);
			this.HEINDEMCGIK().SetFloat("InfoText", this.Speed_Y);
			this.FLOHGDECHHH().SetFloat("Received RPC \"", this.Intensity);
			this.NDMPCDHADMJ().SetVector("' ping: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 523f, 1768f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049B2 RID: 18866 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060049B3 RID: 18867 RVA: 0x00166EA3 File Offset: 0x001650A3
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060049B4 RID: 18868 RVA: 0x00166EC7 File Offset: 0x001650C7
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049B5 RID: 18869 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x060049B6 RID: 18870 RVA: 0x00166F00 File Offset: 0x00165100
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 874f)
			{
				this.HBJJOCHGOPH = 576f;
			}
			this.NDMPCDHADMJ().SetFloat("#", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_Intensity", this.Speed);
			this.DEFBJOCJJKF().SetFloat("_Intensity", this.Speed_X);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Vision_Warp2", this.Speed_Y);
			this.FKEOGPDLBDD().SetFloat("_Color_R", this.Intensity);
			this.NDMPCDHADMJ().SetVector("_History2ChromaTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 195f, 1680f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049B7 RID: 18871 RVA: 0x00166FFF File Offset: 0x001651FF
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049B8 RID: 18872 RVA: 0x00167024 File Offset: 0x00165224
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 763f)
			{
				this.HBJJOCHGOPH = 991f;
			}
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/Distortion_ShockWaveManual", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_TimeX", this.Speed);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack_TV_Noise", this.Speed_X);
			this.NBPKMLMCHFN.SetFloat("solo", this.Speed_Y);
			this.AELJLBOJAIL().SetFloat("Set satellite lerp speed", this.Intensity);
			this.PLBEJJIHFPB().SetVector("bool", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 596f, 45f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049B9 RID: 18873 RVA: 0x0016548B File Offset: 0x0016368B
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049BA RID: 18874 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x060049BB RID: 18875 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060049BC RID: 18876 RVA: 0x00167124 File Offset: 0x00165324
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 297f)
			{
				this.HBJJOCHGOPH = 1852f;
			}
			this.NMDBCDFPGOK().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_Value2", this.Speed);
			this.FGENHBKMPDA().SetFloat("_TimeX", this.Speed_X);
			this.KDMBOKLMADJ().SetFloat("SetSatelliteTrailMinVertexDistance", this.Speed_Y);
			this.PLBEJJIHFPB().SetFloat(" not exist", this.Intensity);
			this.NDMPCDHADMJ().SetVector(" from: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1425f, 233f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049BD RID: 18877 RVA: 0x00167223 File Offset: 0x00165423
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("set environment id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060049BE RID: 18878 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x060049BF RID: 18879 RVA: 0x00167247 File Offset: 0x00165447
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("f");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049C0 RID: 18880 RVA: 0x0016548B File Offset: 0x0016368B
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049C1 RID: 18881 RVA: 0x0016548B File Offset: 0x0016368B
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049C2 RID: 18882 RVA: 0x0016726C File Offset: 0x0016546C
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1738f)
			{
				this.HBJJOCHGOPH = 1555f;
			}
			this.NDMPCDHADMJ().SetFloat(" to ", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("error", this.Speed);
			this.KDMBOKLMADJ().SetFloat("PlayButton", this.Speed_X);
			this.FAIFBBGFAIB().SetFloat("SetupEncryption() got called. ", this.Speed_Y);
			this.HEINDEMCGIK().SetFloat("Can't set Room.MaxPlayers to: ", this.Intensity);
			this.KDMBOKLMADJ().SetVector("/../", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1870f, 1098f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049C3 RID: 18883 RVA: 0x0016548B File Offset: 0x0016368B
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049C4 RID: 18884 RVA: 0x0016736C File Offset: 0x0016556C
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 1946f;
			}
			this.NDMPCDHADMJ().SetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_Blue_G", this.Speed);
			this.KGOLDDBHIFN().SetFloat("/", this.Speed_X);
			this.AELJLBOJAIL().SetFloat("/", this.Speed_Y);
			this.NMDBCDFPGOK().SetFloat("_Distortion", this.Intensity);
			this.AELJLBOJAIL().SetVector("1,30,true,0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1497f, 698f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049C5 RID: 18885 RVA: 0x0016746B File Offset: 0x0016566B
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049C6 RID: 18886 RVA: 0x001674A4 File Offset: 0x001656A4
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 334f)
			{
				this.HBJJOCHGOPH = 1348f;
			}
			this.CIAFLBFJLEJ().SetFloat("SetSpeed", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed);
			this.IONHGBPGCHK().SetFloat("Sep", this.Speed_X);
			this.FLOHGDECHHH().SetFloat("_Green_R", this.Speed_Y);
			this.NMDBCDFPGOK().SetFloat("icon", this.Intensity);
			this.NBPKMLMCHFN.SetVector("_QualitySettings", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 84f, 1543f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049C7 RID: 18887 RVA: 0x001675A4 File Offset: 0x001657A4
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 148f)
			{
				this.HBJJOCHGOPH = 1377f;
			}
			this.KGOLDDBHIFN().SetFloat(".lastCheckpoint.time", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_Strength", this.Speed);
			this.KGOLDDBHIFN().SetFloat("_Far", this.Speed_X);
			this.FAIFBBGFAIB().SetFloat(", ", this.Speed_Y);
			this.NMDBCDFPGOK().SetFloat("BitsData", this.Intensity);
			this.FLOHGDECHHH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1671f, 1194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040007B9 RID: 1977
	public Shader SCShader;

	// Token: 0x040007BA RID: 1978
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007BB RID: 1979
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007BC RID: 1980
	private Material BJFKDHHMLJH;

	// Token: 0x040007BD RID: 1981
	[Range(0f, 10f)]
	public float Speed = 0.2f;

	// Token: 0x040007BE RID: 1982
	[Range(0f, 10f)]
	public float Speed_X = 0.2f;

	// Token: 0x040007BF RID: 1983
	[Range(0f, 1f)]
	public float Speed_Y = 0.3f;

	// Token: 0x040007C0 RID: 1984
	[Range(0f, 10f)]
	public float Intensity = 2.4f;
}
