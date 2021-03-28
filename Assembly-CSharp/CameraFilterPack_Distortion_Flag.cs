using System;
using UnityEngine;

// Token: 0x0200008B RID: 139
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Distortion/Flag")]
public class CameraFilterPack_Distortion_Flag : MonoBehaviour
{
	// Token: 0x060027ED RID: 10221 RVA: 0x000DE658 File Offset: 0x000DC858
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 569f)
			{
				this.HBJJOCHGOPH = 1775f;
			}
			this.HKGAONMOBMH().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat(" ", this.Distortion);
			this.LNLKMDPHDCC().SetVector("Uploading preview image", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027EE RID: 10222 RVA: 0x000DE70E File Offset: 0x000DC90E
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x000DE732 File Offset: 0x000DC932
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x000DE787 File Offset: 0x000DC987
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x000DE7AB File Offset: 0x000DC9AB
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("s");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x000DE7CF File Offset: 0x000DC9CF
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("ArcsDestroyDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x000DE7F3 File Offset: 0x000DC9F3
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("roomDescription");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027F7 RID: 10231 RVA: 0x000DE818 File Offset: 0x000DCA18
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 318f)
			{
				this.HBJJOCHGOPH = 976f;
			}
			this.HKGAONMOBMH().SetFloat("settings.cameramovements", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("Sprite", this.Distortion);
			this.MFHPKGICPIO().SetVector("_Offsets", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x000DE8CE File Offset: 0x000DCACE
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x000DE8F2 File Offset: 0x000DCAF2
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027FA RID: 10234 RVA: 0x000DE92C File Offset: 0x000DCB2C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 190f)
			{
				this.HBJJOCHGOPH = 1250f;
			}
			this.HCGJCMDJPGD().SetFloat("The shader ", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("AVG Misses:", this.Distortion);
			this.KOHGPKOFEJO().SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x000DE9E2 File Offset: 0x000DCBE2
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060027FD RID: 10237 RVA: 0x000DEA08 File Offset: 0x000DCC08
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 938f)
			{
				this.HBJJOCHGOPH = 1379f;
			}
			this.LENEJAGLCNL().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Nov", this.Distortion);
			this.LPMLLJKMAMP().SetVector("Deleted data", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027FE RID: 10238 RVA: 0x000DEAC0 File Offset: 0x000DCCC0
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 995f)
			{
				this.HBJJOCHGOPH = 921f;
			}
			this.NBPKMLMCHFN.SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Exception while connecting to: ", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027FF RID: 10239 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06002800 RID: 10240 RVA: 0x000DEB76 File Offset: 0x000DCD76
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002801 RID: 10241 RVA: 0x000DEBB0 File Offset: 0x000DCDB0
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1377f)
			{
				this.HBJJOCHGOPH = 541f;
			}
			this.LNLKMDPHDCC().SetFloat("open", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_LutTex", this.Distortion);
			this.LENEJAGLCNL().SetVector("Edited unlock conditions", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002802 RID: 10242 RVA: 0x000DEC66 File Offset: 0x000DCE66
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002803 RID: 10243 RVA: 0x000DEC8A File Offset: 0x000DCE8A
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Flag");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002804 RID: 10244 RVA: 0x000DECAE File Offset: 0x000DCEAE
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06002806 RID: 10246 RVA: 0x000DECE5 File Offset: 0x000DCEE5
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002807 RID: 10247 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x000DED39 File Offset: 0x000DCF39
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("TimeBGSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x000DED5D File Offset: 0x000DCF5D
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x000DED94 File Offset: 0x000DCF94
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 115f)
			{
				this.HBJJOCHGOPH = 21f;
			}
			this.LENEJAGLCNL().SetFloat("X2", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_DepthLevel", this.Distortion);
			this.HHIAIGCAHDA().SetVector("_History2LumaTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x000DEE4A File Offset: 0x000DD04A
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x000DEE6E File Offset: 0x000DD06E
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("#orderby:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002810 RID: 10256 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06002812 RID: 10258 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06002813 RID: 10259 RVA: 0x000DEE92 File Offset: 0x000DD092
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

	// Token: 0x06002814 RID: 10260 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002816 RID: 10262 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002817 RID: 10263 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06002818 RID: 10264 RVA: 0x000DEECC File Offset: 0x000DD0CC
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 156f)
			{
				this.HBJJOCHGOPH = 714f;
			}
			this.ADBKPGFMNKO().SetFloat(".lastCheckpoint.comboScore", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("CameraFilterPack/Colors_Brightness", this.Distortion);
			this.KGOLDDBHIFN().SetVector("UndoButton", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002819 RID: 10265 RVA: 0x000DEF82 File Offset: 0x000DD182
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600281A RID: 10266 RVA: 0x000DEFB9 File Offset: 0x000DD1B9
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find(" Owner called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600281B RID: 10267 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x0600281C RID: 10268 RVA: 0x000DEFE0 File Offset: 0x000DD1E0
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1309f)
			{
				this.HBJJOCHGOPH = 1579f;
			}
			this.HKHBBBFLGJH().SetFloat("LevelInfoInputField", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("achievements.21.progress", this.Distortion);
			this.HHIAIGCAHDA().SetVector("0.00", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600281D RID: 10269 RVA: 0x000DF096 File Offset: 0x000DD296
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600281E RID: 10270 RVA: 0x000DF0CD File Offset: 0x000DD2CD
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600281F RID: 10271 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06002820 RID: 10272 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06002821 RID: 10273 RVA: 0x000DF104 File Offset: 0x000DD304
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1179f)
			{
				this.HBJJOCHGOPH = 882f;
			}
			this.KGOLDDBHIFN().SetFloat("RanksButton", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat(",", this.Distortion);
			this.MFHPKGICPIO().SetVector(" not exist", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002822 RID: 10274 RVA: 0x000DF1BC File Offset: 0x000DD3BC
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 357f)
			{
				this.HBJJOCHGOPH = 1004f;
			}
			this.LPMLLJKMAMP().SetFloat("Hex value #RRGGBB", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_Offsets", this.Distortion);
			this.KOHGPKOFEJO().SetVector("note.7", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002823 RID: 10275 RVA: 0x000DF274 File Offset: 0x000DD474
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1820f)
			{
				this.HBJJOCHGOPH = 536f;
			}
			this.LPMLLJKMAMP().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_DotSize", this.Distortion);
			this.LENEJAGLCNL().SetVector("outputitemdefid", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002824 RID: 10276 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06002825 RID: 10277 RVA: 0x000DF32A File Offset: 0x000DD52A
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002826 RID: 10278 RVA: 0x000DF364 File Offset: 0x000DD564
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06002828 RID: 10280 RVA: 0x000DF41A File Offset: 0x000DD61A
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_50");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002829 RID: 10281 RVA: 0x000DF43E File Offset: 0x000DD63E
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600282A RID: 10282 RVA: 0x000DE732 File Offset: 0x000DC932
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x000DF478 File Offset: 0x000DD678
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 310f)
			{
				this.HBJJOCHGOPH = 800f;
			}
			this.MMOODGIODPC().SetFloat("SetParticlesParticleSpeed", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("RoomNameText", this.Distortion);
			this.OKJOKHGJHGF().SetVector("<color=#{0}>{1}</color>", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x000DF52E File Offset: 0x000DD72E
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_BlurRadius4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x000DF554 File Offset: 0x000DD754
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1693f)
			{
				this.HBJJOCHGOPH = 1007f;
			}
			this.LENEJAGLCNL().SetFloat("float,1", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat(": ", this.Distortion);
			this.LNLKMDPHDCC().SetVector("LevelFolderInputField", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x000DF60C File Offset: 0x000DD80C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 577f)
			{
				this.HBJJOCHGOPH = 184f;
			}
			this.LPMLLJKMAMP().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat(".", this.Distortion);
			this.HCGJCMDJPGD().SetVector("/music", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x000DF6C4 File Offset: 0x000DD8C4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 714f)
			{
				this.HBJJOCHGOPH = 1257f;
			}
			this.LNLKMDPHDCC().SetFloat("Editor", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("_TimeX", this.Distortion);
			this.HKHBBBFLGJH().SetVector(".", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x000DF77A File Offset: 0x000DD97A
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("SetParent");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x000DF7A0 File Offset: 0x000DD9A0
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 562f)
			{
				this.HBJJOCHGOPH = 1617f;
			}
			this.OKJOKHGJHGF().SetFloat("OK", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat(". Stopping handling if inactive.", this.Distortion);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Gradients_Stripe", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002833 RID: 10291 RVA: 0x000DF858 File Offset: 0x000DDA58
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1446f)
			{
				this.HBJJOCHGOPH = 1928f;
			}
			this.LENEJAGLCNL().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("ready", this.Distortion);
			this.KOHGPKOFEJO().SetVector("2;13;14;15;16", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002834 RID: 10292 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002835 RID: 10293 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002836 RID: 10294 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06002837 RID: 10295 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x000DF90E File Offset: 0x000DDB0E
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002839 RID: 10297 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600283A RID: 10298 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600283B RID: 10299 RVA: 0x000DF932 File Offset: 0x000DDB32
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600283C RID: 10300 RVA: 0x000DF969 File Offset: 0x000DDB69
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600283D RID: 10301 RVA: 0x000DF9A0 File Offset: 0x000DDBA0
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600283E RID: 10302 RVA: 0x000DF9D8 File Offset: 0x000DDBD8
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1135f)
			{
				this.HBJJOCHGOPH = 373f;
			}
			this.KGOLDDBHIFN().SetFloat("SetSatelliteSensitivity", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("maps.", this.Distortion);
			this.HKHBBBFLGJH().SetVector("InventoryContent", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600283F RID: 10303 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06002840 RID: 10304 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002841 RID: 10305 RVA: 0x000DED1C File Offset: 0x000DCF1C
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002842 RID: 10306 RVA: 0x000DFA8E File Offset: 0x000DDC8E
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040004F3 RID: 1267
	public Shader SCShader;

	// Token: 0x040004F4 RID: 1268
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004F5 RID: 1269
	[Range(0f, 2f)]
	public float Distortion = 1f;

	// Token: 0x040004F6 RID: 1270
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004F7 RID: 1271
	private Material BJFKDHHMLJH;

	// Token: 0x040004F8 RID: 1272
	public static float ChangeDistortion;
}
