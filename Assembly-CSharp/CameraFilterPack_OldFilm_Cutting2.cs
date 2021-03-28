using System;
using UnityEngine;

// Token: 0x02000100 RID: 256
[AddComponentMenu("Camera Filter Pack/Old Film/Cutting 2")]
[ExecuteInEditMode]
public class CameraFilterPack_OldFilm_Cutting2 : MonoBehaviour
{
	// Token: 0x06005021 RID: 20513 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005022 RID: 20514 RVA: 0x001907EA File Offset: 0x0018E9EA
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005023 RID: 20515 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005024 RID: 20516 RVA: 0x00190821 File Offset: 0x0018EA21
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005025 RID: 20517 RVA: 0x00190858 File Offset: 0x0018EA58
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1177f)
			{
				this.HBJJOCHGOPH = 1593f;
			}
			this.HNICHJCGJOC().SetFloat("/Segment-[Down]", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("_Value", 97f - this.Luminosity);
			this.NBMPPNFKFLB().SetFloat("offsets", 1226f - this.Vignette);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Distortion_ShockWave", this.Negative);
			this.OLHDPICFBOF().SetFloat("BloomShaderValueSlider", this.Speed);
			this.EOCCJGIGEGJ().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005026 RID: 20518 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005027 RID: 20519 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005028 RID: 20520 RVA: 0x0019094C File Offset: 0x0018EB4C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1803f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("resource", 1208f - this.Luminosity);
			this.KBOPGONOCNP().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", 1273f - this.Vignette);
			this.KJMECMIGJJA().SetFloat("CameraFilterPack/TV_Tiles", this.Negative);
			this.CECJJMKLEAK().SetFloat("_Value2", this.Speed);
			this.EOCCJGIGEGJ().SetTexture("Crosshair", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005029 RID: 20521 RVA: 0x00190A40 File Offset: 0x0018EC40
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600502A RID: 20522 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600502B RID: 20523 RVA: 0x00190A79 File Offset: 0x0018EC79
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600502C RID: 20524 RVA: 0x00190AB0 File Offset: 0x0018ECB0
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 386f)
			{
				this.HBJJOCHGOPH = 1023f;
			}
			this.MLMKCOINOOH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_SearchTex", 1992f - this.Luminosity);
			this.PGPEMMBJOOG().SetFloat("_NeighborMaxTex", 516f - this.Vignette);
			this.HHIFMIPPMPF().SetFloat("settings.shaders", this.Negative);
			this.MFHPKGICPIO().SetFloat("shader.sunny", this.Speed);
			this.PGPEMMBJOOG().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600502D RID: 20525 RVA: 0x00190BA4 File Offset: 0x0018EDA4
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600502E RID: 20526 RVA: 0x00190BDC File Offset: 0x0018EDDC
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1414f)
			{
				this.HBJJOCHGOPH = 983f;
			}
			this.LPCHMEKDCHI().SetFloat("[SERVER] Kicked ", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("CameraFilterPack/AAA_Super_Hexagon", 1084f - this.Luminosity);
			this.KEMAALEODNH().SetFloat("' has been reset to the fault value", 272f - this.Vignette);
			this.KEMAALEODNH().SetFloat("_Distortion", this.Negative);
			this.MLMKCOINOOH().SetFloat("PossibleMapPointsText", this.Speed);
			this.PGPEMMBJOOG().SetTexture("_Glitch", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600502F RID: 20527 RVA: 0x00190CD0 File Offset: 0x0018EED0
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005030 RID: 20528 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005031 RID: 20529 RVA: 0x00190D07 File Offset: 0x0018EF07
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load(",") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005032 RID: 20530 RVA: 0x00190D40 File Offset: 0x0018EF40
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab1Content") as Texture2D);
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005033 RID: 20531 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06005034 RID: 20532 RVA: 0x00190D79 File Offset: 0x0018EF79
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005035 RID: 20533 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005036 RID: 20534 RVA: 0x00190DB0 File Offset: 0x0018EFB0
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005037 RID: 20535 RVA: 0x00190DE7 File Offset: 0x0018EFE7
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("VisionBlur") as Texture2D);
		this.SCShader = Shader.Find("ScreenResolutionPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005038 RID: 20536 RVA: 0x00190E20 File Offset: 0x0018F020
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005039 RID: 20537 RVA: 0x00190E58 File Offset: 0x0018F058
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 762f)
			{
				this.HBJJOCHGOPH = 880f;
			}
			this.KBOPGONOCNP().SetFloat("menu.selectedlevelid", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("DPADVER", 873f - this.Luminosity);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", 570f - this.Vignette);
			this.LPCHMEKDCHI().SetFloat("CameraFilterPack/Deep_OilPaintHQ", this.Negative);
			this.KDMBOKLMADJ().SetFloat("DPADHOR", this.Speed);
			this.KBOPGONOCNP().SetTexture("LoadingStatusText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600503A RID: 20538 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600503B RID: 20539 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600503C RID: 20540 RVA: 0x00190F4C File Offset: 0x0018F14C
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find(".completedMaps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600503D RID: 20541 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600503E RID: 20542 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600503F RID: 20543 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005040 RID: 20544 RVA: 0x00190F88 File Offset: 0x0018F188
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1467f)
			{
				this.HBJJOCHGOPH = 1117f;
			}
			this.LPCHMEKDCHI().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_TimeX", 1924f - this.Luminosity);
			this.EOCCJGIGEGJ().SetFloat("ShowTitle", 333f - this.Vignette);
			this.LNLKMDPHDCC().SetFloat("LevelEditor/icons", this.Negative);
			this.EOCCJGIGEGJ().SetFloat("_BgFade", this.Speed);
			this.IFMAPIDFNLI().SetTexture("_Value4", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005041 RID: 20545 RVA: 0x0019107C File Offset: 0x0018F27C
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1486f)
			{
				this.HBJJOCHGOPH = 1154f;
			}
			this.PGPEMMBJOOG().SetFloat("SetPlayerDistance", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("ConfigVersionSlider", 1877f - this.Luminosity);
			this.NBPKMLMCHFN.SetFloat(":", 733f - this.Vignette);
			this.LNLKMDPHDCC().SetFloat("shader.sunny", this.Negative);
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", this.Speed);
			this.NBPKMLMCHFN.SetTexture("bloomintencity:", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005042 RID: 20546 RVA: 0x00191170 File Offset: 0x0018F370
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005043 RID: 20547 RVA: 0x001911A7 File Offset: 0x0018F3A7
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005044 RID: 20548 RVA: 0x001911DE File Offset: 0x0018F3DE
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlurDistance") as Texture2D);
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005045 RID: 20549 RVA: 0x00191217 File Offset: 0x0018F417
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005046 RID: 20550 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005047 RID: 20551 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06005048 RID: 20552 RVA: 0x00191250 File Offset: 0x0018F450
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 240f)
			{
				this.HBJJOCHGOPH = 1606f;
			}
			this.DOHGBNPMBKG().SetFloat("[MapEditor] Exported to ", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("[PlayerBase] SetSpeed error: ", 1707f - this.Luminosity);
			this.HNICHJCGJOC().SetFloat("Crosshair2", 1579f - this.Vignette);
			this.NBPKMLMCHFN.SetFloat("_ReflectionTexture0", this.Negative);
			this.DOHGBNPMBKG().SetFloat("error", this.Speed);
			this.NBMPPNFKFLB().SetTexture(" #", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005049 RID: 20553 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600504A RID: 20554 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600504B RID: 20555 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600504C RID: 20556 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600504D RID: 20557 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600504E RID: 20558 RVA: 0x00191344 File Offset: 0x0018F544
	private void PKLOBJHKFEO()
	{
		this.FPHEBLMINDA = (Resources.Load("MenuScene") as Texture2D);
		this.SCShader = Shader.Find("finished");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600504F RID: 20559 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06005050 RID: 20560 RVA: 0x0019137D File Offset: 0x0018F57D
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005051 RID: 20561 RVA: 0x001913B4 File Offset: 0x0018F5B4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 594f)
			{
				this.HBJJOCHGOPH = 1411f;
			}
			this.MLMKCOINOOH().SetFloat("float,0", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_ScreenResolution", 1458f - this.Luminosity);
			this.NFKFAAHHLLM().SetFloat("settings_bindings_", 424f - this.Vignette);
			this.EMDFHOKEGNG().SetFloat("#currentbpm: ", this.Negative);
			this.MFHPKGICPIO().SetFloat("Connected to NameServer.", this.Speed);
			this.DBOLLHHMKKN().SetTexture("x", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005052 RID: 20562 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06005053 RID: 20563 RVA: 0x001914A8 File Offset: 0x0018F6A8
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

	// Token: 0x06005054 RID: 20564 RVA: 0x001914DF File Offset: 0x0018F6DF
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005055 RID: 20565 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06005056 RID: 20566 RVA: 0x00191516 File Offset: 0x0018F716
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("\n\n#") as Texture2D);
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005057 RID: 20567 RVA: 0x00191550 File Offset: 0x0018F750
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 172f)
			{
				this.HBJJOCHGOPH = 325f;
			}
			this.EMDFHOKEGNG().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("<b>[", 1266f - this.Luminosity);
			this.CECJJMKLEAK().SetFloat("SetTrailZoomSpeed", 1530f - this.Vignette);
			this.KEMAALEODNH().SetFloat("Ignored PU RPC, cause item is inactive. ", this.Negative);
			this.EMDFHOKEGNG().SetFloat("masterSteamID", this.Speed);
			this.CECJJMKLEAK().SetTexture("_EmissionColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005058 RID: 20568 RVA: 0x00191644 File Offset: 0x0018F844
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005059 RID: 20569 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600505A RID: 20570 RVA: 0x0019167B File Offset: 0x0018F87B
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("R2") as Texture2D);
		this.SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600505B RID: 20571 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600505C RID: 20572 RVA: 0x001916B4 File Offset: 0x0018F8B4
	private void CFFCLAHMBAA()
	{
		this.FPHEBLMINDA = (Resources.Load("menutheme.summerbreeze") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600505D RID: 20573 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600505E RID: 20574 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600505F RID: 20575 RVA: 0x001916F0 File Offset: 0x0018F8F0
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1927f)
			{
				this.HBJJOCHGOPH = 735f;
			}
			this.NFKFAAHHLLM().SetFloat("Authentication failed: '{0}' Code: {1}", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("PublishButton", 348f - this.Luminosity);
			this.OLHDPICFBOF().SetFloat("OnSerialize", 599f - this.Vignette);
			this.DBOLLHHMKKN().SetFloat("[PlayerController] ", this.Negative);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_HardMix", this.Speed);
			this.NBMPPNFKFLB().SetTexture(";", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005060 RID: 20576 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005061 RID: 20577 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005062 RID: 20578 RVA: 0x001917E4 File Offset: 0x0018F9E4
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005063 RID: 20579 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06005064 RID: 20580 RVA: 0x0019181B File Offset: 0x0018FA1B
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005065 RID: 20581 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06005066 RID: 20582 RVA: 0x00191852 File Offset: 0x0018FA52
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("ready") as Texture2D);
		this.SCShader = Shader.Find("UndoButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005067 RID: 20583 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005069 RID: 20585 RVA: 0x001918C0 File Offset: 0x0018FAC0
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1696f)
			{
				this.HBJJOCHGOPH = 507f;
			}
			this.KBOPGONOCNP().SetFloat(".lastCheckpoint.perfectHits", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_TimeX", 816f - this.Luminosity);
			this.OLHDPICFBOF().SetFloat("workshop.", 1425f - this.Vignette);
			this.KAFBNOBOIAJ().SetFloat("_Value2", this.Negative);
			this.MFHPKGICPIO().SetFloat("maps.", this.Speed);
			this.FEAEGGCNIAA().SetTexture("settings.volume.editor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600506A RID: 20586 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600506B RID: 20587 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x0600506C RID: 20588 RVA: 0x001919B4 File Offset: 0x0018FBB4
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600506D RID: 20589 RVA: 0x001919EC File Offset: 0x0018FBEC
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1367f)
			{
				this.HBJJOCHGOPH = 1125f;
			}
			this.NBMPPNFKFLB().SetFloat("_Smooth", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("OK", 864f - this.Luminosity);
			this.DOHGBNPMBKG().SetFloat("ENABLE_EYE_ADAPTATION", 1536f - this.Vignette);
			this.MLMKCOINOOH().SetFloat("score:", this.Negative);
			this.OLHDPICFBOF().SetFloat("\\n", this.Speed);
			this.HNICHJCGJOC().SetTexture("#scoresubmitionfailed: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600506E RID: 20590 RVA: 0x00191AE0 File Offset: 0x0018FCE0
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600506F RID: 20591 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005070 RID: 20592 RVA: 0x00191B18 File Offset: 0x0018FD18
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 632f)
			{
				this.HBJJOCHGOPH = 634f;
			}
			this.MFHPKGICPIO().SetFloat("settings.shaders", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("gold", 1874f - this.Luminosity);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Gradients_FireGradient", 1567f - this.Vignette);
			this.DOHGBNPMBKG().SetFloat("SpawnObj", this.Negative);
			this.NBMPPNFKFLB().SetFloat("_ScreenResolution", this.Speed);
			this.EMDFHOKEGNG().SetTexture("VIGNETTE_DESAT", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005071 RID: 20593 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005072 RID: 20594 RVA: 0x00191C0C File Offset: 0x0018FE0C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1425f)
			{
				this.HBJJOCHGOPH = 1146f;
			}
			this.EMDFHOKEGNG().SetFloat("Down ", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Value4", 1864f - this.Luminosity);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/TV_Vignetting", 129f - this.Vignette);
			this.NFKFAAHHLLM().SetFloat("EventConfigButton", this.Negative);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Film_Grain", this.Speed);
			this.LPCHMEKDCHI().SetTexture("SetSunColors", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005073 RID: 20595 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005074 RID: 20596 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005075 RID: 20597 RVA: 0x00191D00 File Offset: 0x0018FF00
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 728f)
			{
				this.HBJJOCHGOPH = 194f;
			}
			this.KAFBNOBOIAJ().SetFloat("logc", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_Value6", 1625f - this.Luminosity);
			this.EMDFHOKEGNG().SetFloat("SpawnObj", 1884f - this.Vignette);
			this.FEAEGGCNIAA().SetFloat("_Speed", this.Negative);
			this.KDMBOKLMADJ().SetFloat("_Offsets", this.Speed);
			this.NFKFAAHHLLM().SetTexture(". Check if the server is available.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005076 RID: 20598 RVA: 0x00191DF4 File Offset: 0x0018FFF4
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1669f)
			{
				this.HBJJOCHGOPH = 762f;
			}
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("[ItemsHandler] All in-game items loaded", 1757f - this.Luminosity);
			this.KBOPGONOCNP().SetFloat(".lastCheckpoint.powerupsScore", 193f - this.Vignette);
			this.IFMAPIDFNLI().SetFloat("CountEventsGoal", this.Negative);
			this.NBPKMLMCHFN.SetFloat(" ", this.Speed);
			this.HNICHJCGJOC().SetTexture("mapselector.filter.subscribedonly", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005077 RID: 20599 RVA: 0x00191EE8 File Offset: 0x001900E8
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_OldFilm2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005078 RID: 20600 RVA: 0x00191F21 File Offset: 0x00190121
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("VoteDownToggle") as Texture2D);
		this.SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005079 RID: 20601 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600507A RID: 20602 RVA: 0x00191F5A File Offset: 0x0019015A
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600507B RID: 20603 RVA: 0x00191F91 File Offset: 0x00190191
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600507C RID: 20604 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600507D RID: 20605 RVA: 0x00191FC8 File Offset: 0x001901C8
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600507E RID: 20606 RVA: 0x00192000 File Offset: 0x00190200
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1225f)
			{
				this.HBJJOCHGOPH = 1263f;
			}
			this.MFHPKGICPIO().SetFloat("_DistortionLevel", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_TimeX", 1465f - this.Luminosity);
			this.FEAEGGCNIAA().SetFloat("CameraMovementSlider", 1985f - this.Vignette);
			this.KAFBNOBOIAJ().SetFloat("_DistAmount", this.Negative);
			this.KBOPGONOCNP().SetFloat("_MainTex", this.Speed);
			this.DBOLLHHMKKN().SetTexture("player.licenceaccepted", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600507F RID: 20607 RVA: 0x001907CD File Offset: 0x0018E9CD
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005080 RID: 20608 RVA: 0x001920F4 File Offset: 0x001902F4
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005081 RID: 20609 RVA: 0x0019212C File Offset: 0x0019032C
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
			this.NBPKMLMCHFN.SetFloat("_Value", 2f - this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("_Value2", 1f - this.Vignette);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Negative);
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005082 RID: 20610 RVA: 0x00192220 File Offset: 0x00190420
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005083 RID: 20611 RVA: 0x00192257 File Offset: 0x00190457
	private void FHPFJBFCOOF()
	{
		this.FPHEBLMINDA = (Resources.Load("Is it practically possible?") as Texture2D);
		this.SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000860 RID: 2144
	public Shader SCShader;

	// Token: 0x04000861 RID: 2145
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000862 RID: 2146
	[Range(0f, 10f)]
	public float Speed = 5f;

	// Token: 0x04000863 RID: 2147
	[Range(0f, 2f)]
	public float Luminosity = 1f;

	// Token: 0x04000864 RID: 2148
	[Range(0f, 1f)]
	public float Vignette = 1f;

	// Token: 0x04000865 RID: 2149
	[Range(0f, 1f)]
	public float Negative;

	// Token: 0x04000866 RID: 2150
	private Material BJFKDHHMLJH;

	// Token: 0x04000867 RID: 2151
	private Texture2D FPHEBLMINDA;
}
