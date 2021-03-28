using System;
using UnityEngine;

// Token: 0x020000E0 RID: 224
[AddComponentMenu("Camera Filter Pack/Glow/Glow_Color")]
[ExecuteInEditMode]
public class CameraFilterPack_Glow_Glow_Color : MonoBehaviour
{
	// Token: 0x06004494 RID: 17556 RVA: 0x00153B2D File Offset: 0x00151D2D
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004495 RID: 17557 RVA: 0x00153B4A File Offset: 0x00151D4A
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("<b>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004496 RID: 17558 RVA: 0x00153B70 File Offset: 0x00151D70
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1357f)
			{
				this.HBJJOCHGOPH = 723f;
			}
			this.NFMGLIKNOOC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("ns.exitgames.com", this.Amount);
			this.NFMGLIKNOOC().SetFloat(": ", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("BloodAlternative3", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(".lastCheckpoint.time", this.Precision);
			this.NFMGLIKNOOC().SetColor("menu.playedpage", this.GlowColor);
			this.NFMGLIKNOOC().SetVector("CameraFilterPack/Color_GrayScale", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 1);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 1);
				this.NBPKMLMCHFN.SetFloat("float,0", this.Amount * 288f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 1);
				this.NBPKMLMCHFN.SetTexture("_LightIntensity", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004497 RID: 17559 RVA: 0x00153B2D File Offset: 0x00151D2D
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004498 RID: 17560 RVA: 0x00153D5C File Offset: 0x00151F5C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1970f)
			{
				this.HBJJOCHGOPH = 875f;
			}
			this.NBPKMLMCHFN.SetFloat("float,0", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("bool", this.Amount);
			this.NFMGLIKNOOC().SetFloat("GlassDistortion", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Intensity);
			this.NFMGLIKNOOC().SetFloat(").png", this.Precision);
			this.NBPKMLMCHFN.SetColor("RPCs can only be sent in rooms. Call of \"", this.GlowColor);
			this.NBPKMLMCHFN.SetVector("settings.volume.sfx", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC(), 2);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 3);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 0);
				this.NFMGLIKNOOC().SetFloat("x", this.Amount * 1469f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 7);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.NFMGLIKNOOC().SetTexture("CameraFilterPack_TV_Vignetting1", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004499 RID: 17561 RVA: 0x00153F45 File Offset: 0x00152145
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("Coroutine container not configured... did you forget to call Init?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600449A RID: 17562 RVA: 0x00153F69 File Offset: 0x00152169
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("LevelNameInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600449B RID: 17563 RVA: 0x00153F8D File Offset: 0x0015218D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Glow_Glow_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600449C RID: 17564 RVA: 0x00153B2D File Offset: 0x00151D2D
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600449D RID: 17565 RVA: 0x00153FB1 File Offset: 0x001521B1
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("#failed!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600449E RID: 17566 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x0600449F RID: 17567 RVA: 0x00153B2D File Offset: 0x00151D2D
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044A0 RID: 17568 RVA: 0x00153FD8 File Offset: 0x001521D8
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Precision);
			this.NBPKMLMCHFN.SetColor("_GlowColor", this.GlowColor);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 3);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount * 2f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetTexture("_MainTex2", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044A2 RID: 17570 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060044A3 RID: 17571 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060044A4 RID: 17572 RVA: 0x00154234 File Offset: 0x00152434
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1374f)
			{
				this.HBJJOCHGOPH = 1292f;
			}
			this.NFMGLIKNOOC().SetFloat("EventMenu", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("elapsed: {0:0.000}", this.Amount);
			this.NFMGLIKNOOC().SetFloat("settings_bindings_", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("Please specify a map name or buildID", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("Parent ID", this.Precision);
			this.NBPKMLMCHFN.SetColor("Need to specify a start index and end index.", this.GlowColor);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC(), 3);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 7);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Amount * 35f);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 4);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 0);
				this.NBPKMLMCHFN.SetTexture("_Parasite", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044A5 RID: 17573 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060044A6 RID: 17574 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060044A7 RID: 17575 RVA: 0x00153B2D File Offset: 0x00151D2D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060044A8 RID: 17576 RVA: 0x00154420 File Offset: 0x00152620
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1516f)
			{
				this.HBJJOCHGOPH = 462f;
			}
			this.NBPKMLMCHFN.SetFloat("settings.cameramovements", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("null", this.Amount);
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Intensity);
			this.NFMGLIKNOOC().SetFloat("SetEnvSpriteImage", this.Precision);
			this.NBPKMLMCHFN.SetColor("[Singleton] An instance of '", this.GlowColor);
			this.NBPKMLMCHFN.SetVector("PointerEnter ", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC(), 8);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 7);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 0);
				this.NBPKMLMCHFN.SetFloat("_Blurred", this.Amount * 555f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 4);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 0);
				this.NBPKMLMCHFN.SetTexture("float,0", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044A9 RID: 17577 RVA: 0x00154609 File Offset: 0x00152809
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("ScrollPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060044AA RID: 17578 RVA: 0x00154630 File Offset: 0x00152830
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1394f)
			{
				this.HBJJOCHGOPH = 47f;
			}
			this.NFMGLIKNOOC().SetFloat("Failed to InstantiateSceneObject prefab:", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Playing ", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("Failed to Instantiate prefab: ", this.Intensity);
			this.NFMGLIKNOOC().SetFloat("maphash", this.Precision);
			this.NBPKMLMCHFN.SetColor("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", this.GlowColor);
			this.NBPKMLMCHFN.SetVector("SettingsCanvas", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)4;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC(), 8);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 5);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.NFMGLIKNOOC().SetFloat("randomdrop", this.Amount * 657f);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 2);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 1);
				this.NBPKMLMCHFN.SetTexture("[EditorEvent] Exception: ", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044AB RID: 17579 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060044AC RID: 17580 RVA: 0x00154819 File Offset: 0x00152A19
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

	// Token: 0x060044AD RID: 17581 RVA: 0x00154850 File Offset: 0x00152A50
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1560f)
			{
				this.HBJJOCHGOPH = 793f;
			}
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("<color=white>", this.Amount);
			this.NBPKMLMCHFN.SetFloat("2hands", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("Editor/", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("/?player=", this.Precision);
			this.NBPKMLMCHFN.SetColor("Players NetIDs:", this.GlowColor);
			this.NFMGLIKNOOC().SetVector("[Down-Left]", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)8;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC(), 0);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 4);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 1);
				this.NFMGLIKNOOC().SetFloat("Connecting", this.Amount * 509f);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 8);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 1);
				this.NBPKMLMCHFN.SetTexture("settings_bindings_", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060044AE RID: 17582 RVA: 0x00154A39 File Offset: 0x00152C39
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060044AF RID: 17583 RVA: 0x00154A70 File Offset: 0x00152C70
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060044B0 RID: 17584 RVA: 0x00154A94 File Offset: 0x00152C94
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 645f)
			{
				this.HBJJOCHGOPH = 1790f;
			}
			this.NBPKMLMCHFN.SetFloat("Image", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] Loading checkpoint data", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("SupportLogger Info: PUN {0}: ", this.Precision);
			this.NBPKMLMCHFN.SetColor("_Value", this.GlowColor);
			this.NBPKMLMCHFN.SetVector("AskForPickupItemSpawnTimes", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 6);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 6);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 0);
				this.NFMGLIKNOOC().SetFloat("x", this.Amount * 473f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 1);
				this.NBPKMLMCHFN.SetTexture("_TimeX", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000757 RID: 1879
	public Shader SCShader;

	// Token: 0x04000758 RID: 1880
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000759 RID: 1881
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400075A RID: 1882
	private Material BJFKDHHMLJH;

	// Token: 0x0400075B RID: 1883
	[Range(0f, 20f)]
	public float Amount = 4f;

	// Token: 0x0400075C RID: 1884
	[Range(2f, 16f)]
	public int FastFilter = 4;

	// Token: 0x0400075D RID: 1885
	[Range(0f, 1f)]
	public float Threshold = 0.5f;

	// Token: 0x0400075E RID: 1886
	[Range(0f, 3f)]
	public float Intensity = 2.25f;

	// Token: 0x0400075F RID: 1887
	[Range(-1f, 1f)]
	public float Precision = 0.56f;

	// Token: 0x04000760 RID: 1888
	public Color GlowColor = new Color(0f, 0.7f, 1f, 1f);
}
