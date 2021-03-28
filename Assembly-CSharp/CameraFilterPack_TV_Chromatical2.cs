using System;
using UnityEngine;

// Token: 0x02000115 RID: 277
[AddComponentMenu("Camera Filter Pack/TV/Chromatical2")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Chromatical2 : MonoBehaviour
{
	// Token: 0x060056A4 RID: 22180 RVA: 0x001AFCE4 File Offset: 0x001ADEE4
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1872f)
			{
				this.HBJJOCHGOPH = 406f;
			}
			this.BFGNMFCNDBC().SetFloat(".lastCheckpoint.checkpointsUsed", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("MessageText", this.Aberration);
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/FX_Glitch1", this.Fade);
			this.BFGNMFCNDBC().SetFloat("'{0}' \t{1}ms \t{2}", this.ZoomFade);
			this.BFGNMFCNDBC().SetFloat("_MatrixColor", this.ZoomSpeed);
			this.HHIFMIPPMPF().SetVector("ViewMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 153f, 379f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056A5 RID: 22181 RVA: 0x001AFDE3 File Offset: 0x001ADFE3
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find(" canvas not found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056A6 RID: 22182 RVA: 0x001AFE08 File Offset: 0x001AE008
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 625f)
			{
				this.HBJJOCHGOPH = 698f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("SetSatelliteRadius", this.Aberration);
			this.DEFBJOCJJKF().SetFloat("DPADVER", this.Fade);
			this.AELJLBOJAIL().SetFloat("_Value", this.ZoomFade);
			this.OIMMPLPBLBK().SetFloat("MusicFileSelector", this.ZoomSpeed);
			this.HHIFMIPPMPF().SetVector(". The group number should be at least 1.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 68f, 585f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056A7 RID: 22183 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056A8 RID: 22184 RVA: 0x001AFF24 File Offset: 0x001AE124
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 226f)
			{
				this.HBJJOCHGOPH = 282f;
			}
			this.OIMMPLPBLBK().SetFloat("FileMenu", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Dance", this.Aberration);
			this.OIMMPLPBLBK().SetFloat("_Amount", this.Fade);
			this.OIMMPLPBLBK().SetFloat("#tryagain", this.ZoomFade);
			this.HHIFMIPPMPF().SetFloat(" is muted", this.ZoomSpeed);
			this.FAIFBBGFAIB().SetVector("Mouse Wheel Down", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1034f, 547f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056A9 RID: 22185 RVA: 0x001B0024 File Offset: 0x001AE224
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 174f)
			{
				this.HBJJOCHGOPH = 49f;
			}
			this.AELJLBOJAIL().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", this.Aberration);
			this.FAIFBBGFAIB().SetFloat("_TileMaxOffs", this.Fade);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.ZoomFade);
			this.AELJLBOJAIL().SetFloat("Editor/", this.ZoomSpeed);
			this.IIJMIPBMMBF().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 611f, 1874f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056AA RID: 22186 RVA: 0x001B0124 File Offset: 0x001AE324
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 66f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			this.NBPKMLMCHFN.SetFloat("UseFinalGlassColor", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("Hidden/Fast Approximate Anti-aliasing", this.Aberration);
			this.HHIFMIPPMPF().SetFloat(". The group number should be at least 1.", this.Fade);
			this.HHIFMIPPMPF().SetFloat("[NetworkScene] Exited", this.ZoomFade);
			this.HHIFMIPPMPF().SetFloat("_Bullet_12", this.ZoomSpeed);
			this.NBPKMLMCHFN.SetVector("masterSteamID", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1983f, 388f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056AB RID: 22187 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056AC RID: 22188 RVA: 0x001B0223 File Offset: 0x001AE423
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("#onfirstranktext");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056AD RID: 22189 RVA: 0x001B0248 File Offset: 0x001AE448
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Aberration);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("ZoomFade", this.ZoomFade);
			this.NBPKMLMCHFN.SetFloat("ZoomSpeed", this.ZoomSpeed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056AE RID: 22190 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056AF RID: 22191 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056B1 RID: 22193 RVA: 0x001B0386 File Offset: 0x001AE586
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056B2 RID: 22194 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056B3 RID: 22195 RVA: 0x001B03AC File Offset: 0x001AE5AC
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 61f)
			{
				this.HBJJOCHGOPH = 726f;
			}
			this.IIJMIPBMMBF().SetFloat("MouseX", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("inventory.selected.", this.Aberration);
			this.FAIFBBGFAIB().SetFloat("achievements.21.completed.", this.Fade);
			this.DEFBJOCJJKF().SetFloat("_Value3", this.ZoomFade);
			this.BFGNMFCNDBC().SetFloat("maps.", this.ZoomSpeed);
			this.FAIFBBGFAIB().SetVector("ResetSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1853f, 1373f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056B4 RID: 22196 RVA: 0x001B04AB File Offset: 0x001AE6AB
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056B5 RID: 22197 RVA: 0x001B04E2 File Offset: 0x001AE6E2
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("/C tasklist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056B6 RID: 22198 RVA: 0x001B0506 File Offset: 0x001AE706
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056B7 RID: 22199 RVA: 0x001B053D File Offset: 0x001AE73D
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056B8 RID: 22200 RVA: 0x001B0561 File Offset: 0x001AE761
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056B9 RID: 22201 RVA: 0x001B0598 File Offset: 0x001AE798
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056BA RID: 22202 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056BB RID: 22203 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056BC RID: 22204 RVA: 0x001B05BC File Offset: 0x001AE7BC
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 990f)
			{
				this.HBJJOCHGOPH = 527f;
			}
			this.HHIFMIPPMPF().SetFloat("#timeuntilchallenge: ", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.Aberration);
			this.HHIFMIPPMPF().SetFloat(".completed", this.Fade);
			this.AELJLBOJAIL().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.ZoomFade);
			this.FAIFBBGFAIB().SetFloat("Source Object: ", this.ZoomSpeed);
			this.NFMGLIKNOOC().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 65f, 1312f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056BD RID: 22205 RVA: 0x001B06BB File Offset: 0x001AE8BB
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("help");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056BE RID: 22206 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060056BF RID: 22207 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056C0 RID: 22208 RVA: 0x001B06DF File Offset: 0x001AE8DF
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056C1 RID: 22209 RVA: 0x001B0703 File Offset: 0x001AE903
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056C2 RID: 22210 RVA: 0x001B073C File Offset: 0x001AE93C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1502f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.FAIFBBGFAIB().SetFloat("_SecondTex", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("DPADHOR", this.Aberration);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/FX_Dot_Circle", this.Fade);
			this.BFGNMFCNDBC().SetFloat("_ProjInfo", this.ZoomFade);
			this.NBPKMLMCHFN.SetFloat("Left", this.ZoomSpeed);
			this.FAIFBBGFAIB().SetVector("_Intervale", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1361f, 1727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056C3 RID: 22211 RVA: 0x001B083B File Offset: 0x001AEA3B
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056C4 RID: 22212 RVA: 0x001B085F File Offset: 0x001AEA5F
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("InfoCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056C5 RID: 22213 RVA: 0x001B0884 File Offset: 0x001AEA84
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 337f)
			{
				this.HBJJOCHGOPH = 1007f;
			}
			this.NBPKMLMCHFN.SetFloat("z", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/FX_Hypno", this.Aberration);
			this.AELJLBOJAIL().SetFloat("_UserLutTex", this.Fade);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/Antialiasing_FXAA", this.ZoomFade);
			this.NBPKMLMCHFN.SetFloat("Called GetNumberOfCurrentPlayers()", this.ZoomSpeed);
			this.AELJLBOJAIL().SetVector("Items/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1774f, 1456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x060056C6 RID: 22214 RVA: 0x001B0983 File Offset: 0x001AEB83
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

	// Token: 0x060056C7 RID: 22215 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056C8 RID: 22216 RVA: 0x001AFF07 File Offset: 0x001AE107
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056C9 RID: 22217 RVA: 0x001B09BA File Offset: 0x001AEBBA
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056CA RID: 22218 RVA: 0x001B09F1 File Offset: 0x001AEBF1
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056CB RID: 22219 RVA: 0x001B0A28 File Offset: 0x001AEC28
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056CC RID: 22220 RVA: 0x001B0A5F File Offset: 0x001AEC5F
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056CD RID: 22221 RVA: 0x001B0A96 File Offset: 0x001AEC96
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Chromatical2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000903 RID: 2307
	public Shader SCShader;

	// Token: 0x04000904 RID: 2308
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000905 RID: 2309
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000906 RID: 2310
	private Material BJFKDHHMLJH;

	// Token: 0x04000907 RID: 2311
	[Range(0f, 10f)]
	public float Aberration = 2f;

	// Token: 0x04000908 RID: 2312
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000909 RID: 2313
	[Range(0f, 1f)]
	public float ZoomFade = 1f;

	// Token: 0x0400090A RID: 2314
	[Range(0f, 8f)]
	public float ZoomSpeed = 1f;
}
