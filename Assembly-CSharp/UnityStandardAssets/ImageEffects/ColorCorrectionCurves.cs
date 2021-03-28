using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001D3 RID: 467
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		// Token: 0x06007B39 RID: 31545 RVA: 0x00279388 File Offset: 0x00277588
		public virtual bool GHHAAPCBJJD()
		{
			base.MBMLNJJEONO(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Simple);
			this.PGAHJLAAGKI = base.EDFIBHNHAAB(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.EDFIBHNHAAB(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.ECNEGNMAMDE(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(198, 5, TextureFormat.Alpha8, true, false);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-175, 5, TextureFormat.RGB565, true, true);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(-159, 0, TextureFormat.RGB24, true, true);
			}
			this.AKGCPDNDHAJ.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.OMIHJHOPGEC.hideFlags = ~HideFlags.NotEditable;
			this.GIMLIHNKKNO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Clamp;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Repeat;
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x002794BC File Offset: 0x002776BC
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.OKGGMOGEJFD)
			{
				this.UpdateParameters();
				this.OKGGMOGEJFD = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = BMMLHGHKBNM;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			}
			if (this.useDepthCorrection)
			{
				this.GNCKPFCNIKF.SetTexture("_RgbTex", this.AKGCPDNDHAJ);
				this.GNCKPFCNIKF.SetTexture("_ZCurve", this.GIMLIHNKKNO);
				this.GNCKPFCNIKF.SetTexture("_RgbDepthTex", this.OMIHJHOPGEC);
				this.GNCKPFCNIKF.SetFloat("_Saturation", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GNCKPFCNIKF);
			}
			else
			{
				this.PGAHJLAAGKI.SetTexture("_RgbTex", this.AKGCPDNDHAJ);
				this.PGAHJLAAGKI.SetFloat("_Saturation", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PGAHJLAAGKI);
			}
			if (this.selectiveCc)
			{
				this.GMHJFMMJFBL.SetColor("selColor", this.selectiveFromColor);
				this.GMHJFMMJFBL.SetColor("targetColor", this.selectiveToColor);
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.GMHJFMMJFBL);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x00279629 File Offset: 0x00277829
		private void BIPLNMPAAOG()
		{
			this.IKKLJLDADAK();
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x00279634 File Offset: 0x00277834
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.OKGGMOGEJFD)
			{
				this.EJMOKDJNDBC();
				this.OKGGMOGEJFD = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = BMMLHGHKBNM;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			}
			if (this.useDepthCorrection)
			{
				this.GNCKPFCNIKF.SetTexture("warning: Audio Source: ", this.AKGCPDNDHAJ);
				this.GNCKPFCNIKF.SetTexture("NO", this.GIMLIHNKKNO);
				this.GNCKPFCNIKF.SetTexture("Set satellite lerp speed", this.OMIHJHOPGEC);
				this.GNCKPFCNIKF.SetFloat("CameraFilterPack_TV_BrokenGlass_2", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GNCKPFCNIKF);
			}
			else
			{
				this.PGAHJLAAGKI.SetTexture("null", this.AKGCPDNDHAJ);
				this.PGAHJLAAGKI.SetFloat("_FarCamera", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PGAHJLAAGKI);
			}
			if (this.selectiveCc)
			{
				this.GMHJFMMJFBL.SetColor("BitsData", this.selectiveFromColor);
				this.GMHJFMMJFBL.SetColor("x", this.selectiveToColor);
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.GMHJFMMJFBL);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x002797A4 File Offset: 0x002779A4
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.OKGGMOGEJFD)
			{
				this.ANDGHMDPICK();
				this.OKGGMOGEJFD = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = BMMLHGHKBNM;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			}
			if (this.useDepthCorrection)
			{
				this.GNCKPFCNIKF.SetTexture("Joystick1Button11", this.AKGCPDNDHAJ);
				this.GNCKPFCNIKF.SetTexture("_Glow", this.GIMLIHNKKNO);
				this.GNCKPFCNIKF.SetTexture("GenerationMenu", this.OMIHJHOPGEC);
				this.GNCKPFCNIKF.SetFloat(" not exist", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GNCKPFCNIKF);
			}
			else
			{
				this.PGAHJLAAGKI.SetTexture("_ScreenResolution", this.AKGCPDNDHAJ);
				this.PGAHJLAAGKI.SetFloat("MessageText", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PGAHJLAAGKI);
			}
			if (this.selectiveCc)
			{
				this.GMHJFMMJFBL.SetColor("IncorrectHitsScoreText", this.selectiveFromColor);
				this.GMHJFMMJFBL.SetColor("_Extra3", this.selectiveToColor);
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.GMHJFMMJFBL);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x0002523B File Offset: 0x0002343B
		private void CEKLAECJCKG()
		{
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x0002523B File Offset: 0x0002343B
		private void Awake()
		{
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x0002523B File Offset: 0x0002343B
		private void OPFDGBDADMA()
		{
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x00279914 File Offset: 0x00277B14
		public void UpdateParameters()
		{
			this.CheckResources();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 0f, 1f);
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 0f, 1f);
					this.GIMLIHNKKNO.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 0f, 1f);
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				}
				this.AKGCPDNDHAJ.Apply();
				this.OMIHJHOPGEC.Apply();
				this.GIMLIHNKKNO.Apply();
			}
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x00279B37 File Offset: 0x00277D37
		private void CIPKEPDELJB()
		{
			base.DKOPKPBLDHH();
			this.OKGGMOGEJFD = false;
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x00279B48 File Offset: 0x00277D48
		public virtual bool OAGFHJHEBCA()
		{
			base.IBFDMKMOBCA(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Advanced);
			this.PGAHJLAAGKI = base.GJKHKCOAFDB(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.NODBMINMALP(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.AJKPGPKKHHB(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(-25, 0, TextureFormat.RGBA32, false, false);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(35, 3, (TextureFormat)8, true, true);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(-112, 0, TextureFormat.ARGB4444, true, true);
			}
			this.AKGCPDNDHAJ.hideFlags = (HideFlags)(-87);
			this.OMIHJHOPGEC.hideFlags = HideFlags.DontSave;
			this.GIMLIHNKKNO.hideFlags = (HideFlags)89;
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Repeat;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Repeat;
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x00279C7C File Offset: 0x00277E7C
		public virtual bool MOLMLGKEBOL()
		{
			base.JOMCJOEOLHP(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Advanced);
			this.PGAHJLAAGKI = base.ECNEGNMAMDE(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.ECNEGNMAMDE(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.ECNEGNMAMDE(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(99, 8, TextureFormat.Alpha8, true, true);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-30, 8, TextureFormat.RGB24, true, false);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(197, 1, TextureFormat.Alpha8, false, false);
			}
			this.AKGCPDNDHAJ.hideFlags = HideFlags.DontSaveInEditor;
			this.OMIHJHOPGEC.hideFlags = (HideFlags)79;
			this.GIMLIHNKKNO.hideFlags = (HideFlags)64;
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Clamp;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Repeat;
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x00279DB0 File Offset: 0x00277FB0
		public void AHHBDBKBJOC()
		{
			this.LPDGLHPMDLB();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 664f; num <= 1650f; num += 1273f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 666f, 1826f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 228f, 485f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1693f, 542f);
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1462f), 1, new Color(num2, num2, num2));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 212f), 1, new Color(num3, num3, num3));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1553f), 8, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 85f, 1164f);
					this.GIMLIHNKKNO.SetPixel((int)Mathf.Floor(num * 1923f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1141f, 1134f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1473f, 366f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 687f, 1480f);
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1300f), 1, new Color(num2, num2, num2));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1505f), 0, new Color(num3, num3, num3));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1585f), 2, new Color(num4, num4, num4));
				}
				this.AKGCPDNDHAJ.Apply();
				this.OMIHJHOPGEC.Apply();
				this.GIMLIHNKKNO.Apply();
			}
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x00279FD4 File Offset: 0x002781D4
		public virtual bool EAOFDBCPJDI()
		{
			base.NPOEJIDLJGK(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Simple);
			this.PGAHJLAAGKI = base.LKIJNGDHLAK(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.ECNEGNMAMDE(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.LKIJNGDHLAK(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(-143, 6, (TextureFormat)6, false, false);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-183, 8, (TextureFormat)6, true, true);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(153, 1, (TextureFormat)8, true, false);
			}
			this.AKGCPDNDHAJ.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.OMIHJHOPGEC.hideFlags = (HideFlags)(-70);
			this.GIMLIHNKKNO.hideFlags = (HideFlags)115;
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Repeat;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Clamp;
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x0002523B File Offset: 0x0002343B
		private void PPCGJBIIFAO()
		{
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x0027A108 File Offset: 0x00278308
		public virtual bool GCLELPIDOCM()
		{
			base.JOMCJOEOLHP(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Simple);
			this.PGAHJLAAGKI = base.KDHKHOHMKCG(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.NODBMINMALP(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.EDFIBHNHAAB(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(8, 3, TextureFormat.RGB565, false, false);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-82, 5, (TextureFormat)0, true, false);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(186, 1, (TextureFormat)8, false, false);
			}
			this.AKGCPDNDHAJ.hideFlags = (HideFlags)69;
			this.OMIHJHOPGEC.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.GIMLIHNKKNO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Repeat;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Repeat;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Clamp;
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x0027A23C File Offset: 0x0027843C
		public override bool ILMGHBFANON()
		{
			base.JOMCJOEOLHP(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Simple);
			this.PGAHJLAAGKI = base.EDFIBHNHAAB(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.AJKPGPKKHHB(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.AJKPGPKKHHB(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(-176, 4, TextureFormat.ARGB4444, true, true);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-70, 6, TextureFormat.ARGB32, false, true);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(-158, 1, TextureFormat.Alpha8, true, false);
			}
			this.AKGCPDNDHAJ.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.OMIHJHOPGEC.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			this.GIMLIHNKKNO.hideFlags = (HideFlags)94;
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Clamp;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Repeat;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Repeat;
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x0027A370 File Offset: 0x00278570
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Advanced);
			this.PGAHJLAAGKI = base.EDFIBHNHAAB(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.EDFIBHNHAAB(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.EDFIBHNHAAB(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(256, 4, TextureFormat.ARGB32, false, true);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(256, 4, TextureFormat.ARGB32, false, true);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(256, 1, TextureFormat.ARGB32, false, true);
			}
			this.AKGCPDNDHAJ.hideFlags = HideFlags.DontSave;
			this.OMIHJHOPGEC.hideFlags = HideFlags.DontSave;
			this.GIMLIHNKKNO.hideFlags = HideFlags.DontSave;
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Clamp;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Clamp;
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x0027A4A3 File Offset: 0x002786A3
		private void MODINNNGFAL()
		{
			this.JDCODMMDPII();
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x0027A4AC File Offset: 0x002786AC
		public void JDCODMMDPII()
		{
			this.PFIELBMLHJK();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1538f; num <= 1043f; num += 1813f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1398f, 657f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1967f, 214f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1599f, 1466f);
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1820f), 1, new Color(num2, num2, num2));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1049f), 1, new Color(num3, num3, num3));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1359f), 6, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1684f, 466f);
					this.GIMLIHNKKNO.SetPixel((int)Mathf.Floor(num * 1905f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1414f, 1188f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1724f, 1122f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 1227f, 486f);
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 704f), 0, new Color(num2, num2, num2));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 506f), 0, new Color(num3, num3, num3));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 172f), 1, new Color(num4, num4, num4));
				}
				this.AKGCPDNDHAJ.Apply();
				this.OMIHJHOPGEC.Apply();
				this.GIMLIHNKKNO.Apply();
			}
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x0027A6D0 File Offset: 0x002788D0
		public void EJMOKDJNDBC()
		{
			this.BNMLMGBCHHI();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 422f; num <= 631f; num += 572f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1845f, 887f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1067f, 996f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1210f, 1453f);
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 732f), 0, new Color(num2, num2, num2));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1628f), 0, new Color(num3, num3, num3));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 482f), 5, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 534f, 1458f);
					this.GIMLIHNKKNO.SetPixel((int)Mathf.Floor(num * 1296f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 133f, 1074f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1650f, 162f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 1058f, 1349f);
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1355f), 1, new Color(num2, num2, num2));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1863f), 1, new Color(num3, num3, num3));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 237f), 2, new Color(num4, num4, num4));
				}
				this.AKGCPDNDHAJ.Apply();
				this.OMIHJHOPGEC.Apply();
				this.GIMLIHNKKNO.Apply();
			}
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x0027A8F4 File Offset: 0x00278AF4
		public virtual bool PDNFBCMPHEI()
		{
			base.NPOEJIDLJGK(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Simple);
			this.PGAHJLAAGKI = base.NODBMINMALP(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.EDFIBHNHAAB(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.ECNEGNMAMDE(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(-42, 4, (TextureFormat)6, true, true);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-16, 4, (TextureFormat)8, false, false);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(-83, 1, TextureFormat.Alpha8, false, false);
			}
			this.AKGCPDNDHAJ.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.OMIHJHOPGEC.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
			this.GIMLIHNKKNO.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Repeat;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Repeat;
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x0027AA28 File Offset: 0x00278C28
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.OKGGMOGEJFD)
			{
				this.ANDGHMDPICK();
				this.OKGGMOGEJFD = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = BMMLHGHKBNM;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			}
			if (this.useDepthCorrection)
			{
				this.GNCKPFCNIKF.SetTexture("LevelProgressBar", this.AKGCPDNDHAJ);
				this.GNCKPFCNIKF.SetTexture("Down", this.GIMLIHNKKNO);
				this.GNCKPFCNIKF.SetTexture(" - PUBLISHED #", this.OMIHJHOPGEC);
				this.GNCKPFCNIKF.SetFloat("_EdgeSize", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GNCKPFCNIKF);
			}
			else
			{
				this.PGAHJLAAGKI.SetTexture("mapselector.tags.", this.AKGCPDNDHAJ);
				this.PGAHJLAAGKI.SetFloat(".highscore", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PGAHJLAAGKI);
			}
			if (this.selectiveCc)
			{
				this.GMHJFMMJFBL.SetColor("_Value3", this.selectiveFromColor);
				this.GMHJFMMJFBL.SetColor("[ItemsHandler] Loading Steam inventory", this.selectiveToColor);
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.GMHJFMMJFBL);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x0027ADCC File Offset: 0x00278FCC
		public void ANDGHMDPICK()
		{
			this.AFNHKGFNOCL();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 501f; num <= 813f; num += 1440f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 101f, 1944f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1267f, 1673f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1097f, 674f);
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1055f), 1, new Color(num2, num2, num2));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1301f), 1, new Color(num3, num3, num3));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1541f), 4, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 887f, 1765f);
					this.GIMLIHNKKNO.SetPixel((int)Mathf.Floor(num * 1515f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 491f, 372f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 320f, 256f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 853f, 1967f);
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 588f), 0, new Color(num2, num2, num2));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1794f), 0, new Color(num3, num3, num3));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 427f), 6, new Color(num4, num4, num4));
				}
				this.AKGCPDNDHAJ.Apply();
				this.OMIHJHOPGEC.Apply();
				this.GIMLIHNKKNO.Apply();
			}
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x0027AFEF File Offset: 0x002791EF
		private void NPLCENPNJBM()
		{
			base.LIBGAKMKHJJ();
			this.OKGGMOGEJFD = false;
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x00279B37 File Offset: 0x00277D37
		private void DNNFHBOOPIN()
		{
			base.DKOPKPBLDHH();
			this.OKGGMOGEJFD = false;
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x0027AFFE File Offset: 0x002791FE
		private void AEDLNOCBGEP()
		{
			this.UpdateParameters();
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x0002523B File Offset: 0x0002343B
		private void JEEINPBLBDI()
		{
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x0027B006 File Offset: 0x00279206
		private void PAKPHKPDKGE()
		{
			base.Start();
			this.OKGGMOGEJFD = true;
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x0027B006 File Offset: 0x00279206
		private new void Start()
		{
			base.Start();
			this.OKGGMOGEJFD = true;
		}

		// Token: 0x06007B58 RID: 31576 RVA: 0x0027A4A3 File Offset: 0x002786A3
		private void MEHIJOBLBFG()
		{
			this.JDCODMMDPII();
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x0027B018 File Offset: 0x00279218
		public virtual bool JDPOEILHKLC()
		{
			base.DCHKKHDGBLJ(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Advanced);
			this.PGAHJLAAGKI = base.KDHKHOHMKCG(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.ECNEGNMAMDE(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.AJKPGPKKHHB(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(-68, 7, (TextureFormat)6, false, false);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-158, 3, TextureFormat.RGBA32, false, false);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(56, 1, TextureFormat.Alpha8, true, true);
			}
			this.AKGCPDNDHAJ.hideFlags = (HideFlags)115;
			this.OMIHJHOPGEC.hideFlags = HideFlags.DontUnloadUnusedAsset;
			this.GIMLIHNKKNO.hideFlags = (HideFlags)(-111);
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Repeat;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Repeat;
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B5A RID: 31578 RVA: 0x0027B14B File Offset: 0x0027934B
		private void KMCPMOGKDEH()
		{
			base.DKOPKPBLDHH();
			this.OKGGMOGEJFD = true;
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x0027B15C File Offset: 0x0027935C
		public void MENIGCOFDFC()
		{
			this.AFNHKGFNOCL();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1959f; num <= 1089f; num += 5f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1372f, 1260f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 643f, 1346f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 799f, 333f);
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 188f), 1, new Color(num2, num2, num2));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 799f), 1, new Color(num3, num3, num3));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1932f), 4, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1664f, 213f);
					this.GIMLIHNKKNO.SetPixel((int)Mathf.Floor(num * 1537f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 929f, 89f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 747f, 1650f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 600f, 1682f);
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 720f), 1, new Color(num2, num2, num2));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 811f), 0, new Color(num3, num3, num3));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1159f), 4, new Color(num4, num4, num4));
				}
				this.AKGCPDNDHAJ.Apply();
				this.OMIHJHOPGEC.Apply();
				this.GIMLIHNKKNO.Apply();
			}
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x0027B380 File Offset: 0x00279580
		public void IKKLJLDADAK()
		{
			this.PFIELBMLHJK();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 780f; num <= 725f; num += 1349f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1372f, 1652f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1418f, 395f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1705f, 1454f);
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 1512f), 1, new Color(num2, num2, num2));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 878f), 0, new Color(num3, num3, num3));
					this.AKGCPDNDHAJ.SetPixel((int)Mathf.Floor(num * 779f), 8, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1110f, 1916f);
					this.GIMLIHNKKNO.SetPixel((int)Mathf.Floor(num * 181f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1526f, 1194f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 531f, 696f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 677f, 1468f);
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 587f), 0, new Color(num2, num2, num2));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 1654f), 0, new Color(num3, num3, num3));
					this.OMIHJHOPGEC.SetPixel((int)Mathf.Floor(num * 511f), 5, new Color(num4, num4, num4));
				}
				this.AKGCPDNDHAJ.Apply();
				this.OMIHJHOPGEC.Apply();
				this.GIMLIHNKKNO.Apply();
			}
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x0027B5A3 File Offset: 0x002797A3
		private void JKFDDNMPOJH()
		{
			base.FJNCHGLIEMA();
			this.OKGGMOGEJFD = false;
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x0027B5B4 File Offset: 0x002797B4
		public virtual bool ELHBKCFNCOJ()
		{
			base.KHNPMDDIJAJ(this.mode == ColorCorrectionCurves.ColorCorrectionMode.Simple);
			this.PGAHJLAAGKI = base.EDFIBHNHAAB(this.simpleColorCorrectionCurvesShader, this.PGAHJLAAGKI);
			this.GNCKPFCNIKF = base.EDFIBHNHAAB(this.colorCorrectionCurvesShader, this.GNCKPFCNIKF);
			this.GMHJFMMJFBL = base.AJKPGPKKHHB(this.colorCorrectionSelectiveShader, this.GMHJFMMJFBL);
			if (!this.AKGCPDNDHAJ)
			{
				this.AKGCPDNDHAJ = new Texture2D(-24, 1, TextureFormat.ARGB32, true, false);
			}
			if (!this.OMIHJHOPGEC)
			{
				this.OMIHJHOPGEC = new Texture2D(-142, 4, TextureFormat.ARGB4444, true, false);
			}
			if (!this.GIMLIHNKKNO)
			{
				this.GIMLIHNKKNO = new Texture2D(13, 1, TextureFormat.RGB565, false, false);
			}
			this.AKGCPDNDHAJ.hideFlags = (HideFlags)72;
			this.OMIHJHOPGEC.hideFlags = (HideFlags)65;
			this.GIMLIHNKKNO.hideFlags = HideFlags.DontUnloadUnusedAsset;
			this.AKGCPDNDHAJ.wrapMode = TextureWrapMode.Clamp;
			this.OMIHJHOPGEC.wrapMode = TextureWrapMode.Clamp;
			this.GIMLIHNKKNO.wrapMode = TextureWrapMode.Repeat;
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x0027B6E8 File Offset: 0x002798E8
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.OKGGMOGEJFD)
			{
				this.MENIGCOFDFC();
				this.OKGGMOGEJFD = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = BMMLHGHKBNM;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height);
			}
			if (this.useDepthCorrection)
			{
				this.GNCKPFCNIKF.SetTexture("wss://", this.AKGCPDNDHAJ);
				this.GNCKPFCNIKF.SetTexture("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", this.GIMLIHNKKNO);
				this.GNCKPFCNIKF.SetTexture("Texture2", this.OMIHJHOPGEC);
				this.GNCKPFCNIKF.SetFloat("Events Moved", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GNCKPFCNIKF);
			}
			else
			{
				this.PGAHJLAAGKI.SetTexture("_Value", this.AKGCPDNDHAJ);
				this.PGAHJLAAGKI.SetFloat("input", this.saturation);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PGAHJLAAGKI);
			}
			if (this.selectiveCc)
			{
				this.GMHJFMMJFBL.SetColor("workshop.", this.selectiveFromColor);
				this.GMHJFMMJFBL.SetColor("_EmissionColor", this.selectiveToColor);
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.GMHJFMMJFBL);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x04000D68 RID: 3432
		public AnimationCurve redChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000D69 RID: 3433
		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000D6A RID: 3434
		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000D6B RID: 3435
		public bool useDepthCorrection;

		// Token: 0x04000D6C RID: 3436
		public AnimationCurve zCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000D6D RID: 3437
		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000D6E RID: 3438
		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000D6F RID: 3439
		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04000D70 RID: 3440
		private Material PGAHJLAAGKI;

		// Token: 0x04000D71 RID: 3441
		private Material GNCKPFCNIKF;

		// Token: 0x04000D72 RID: 3442
		private Material GMHJFMMJFBL;

		// Token: 0x04000D73 RID: 3443
		private Texture2D AKGCPDNDHAJ;

		// Token: 0x04000D74 RID: 3444
		private Texture2D OMIHJHOPGEC;

		// Token: 0x04000D75 RID: 3445
		private Texture2D GIMLIHNKKNO;

		// Token: 0x04000D76 RID: 3446
		public float saturation = 1f;

		// Token: 0x04000D77 RID: 3447
		public bool selectiveCc;

		// Token: 0x04000D78 RID: 3448
		public Color selectiveFromColor = Color.white;

		// Token: 0x04000D79 RID: 3449
		public Color selectiveToColor = Color.white;

		// Token: 0x04000D7A RID: 3450
		public ColorCorrectionCurves.ColorCorrectionMode mode;

		// Token: 0x04000D7B RID: 3451
		public bool updateTextures = true;

		// Token: 0x04000D7C RID: 3452
		public Shader colorCorrectionCurvesShader;

		// Token: 0x04000D7D RID: 3453
		public Shader simpleColorCorrectionCurvesShader;

		// Token: 0x04000D7E RID: 3454
		public Shader colorCorrectionSelectiveShader;

		// Token: 0x04000D7F RID: 3455
		private bool OKGGMOGEJFD = true;

		// Token: 0x020001D4 RID: 468
		public enum ColorCorrectionMode
		{
			// Token: 0x04000D81 RID: 3457
			Simple,
			// Token: 0x04000D82 RID: 3458
			Advanced
		}
	}
}
