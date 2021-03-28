using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001F8 RID: 504
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	[RequireComponent(typeof(Camera))]
	internal class TiltShift : PostEffectsBase
	{
		// Token: 0x06008156 RID: 33110 RVA: 0x002C1F9C File Offset: 0x002C019C
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat("[MapEditor] Loading music...", (this.maxBlurSize >= 1179f) ? this.maxBlurSize : 1887f);
			this.OBLBJDPHCIG.SetFloat(" ", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 4f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & 95), HLBKCLPNHEB.height >> (this.downsample & 44), 1, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 1) : num);
			if (this.downsample > 0)
			{
				this.OBLBJDPHCIG.SetTexture("[MapsData] Bad map: ", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 0);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x002C20BC File Offset: 0x002C02BC
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat("challenges/", (this.maxBlurSize >= 1344f) ? this.maxBlurSize : 338f);
			this.OBLBJDPHCIG.SetFloat("SpawnObj", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 658f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & 60), HLBKCLPNHEB.height >> (this.downsample & 106), 1, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 7;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 0) : num);
			if (this.downsample > 0)
			{
				this.OBLBJDPHCIG.SetTexture("_Value", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 6);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x002C21D9 File Offset: 0x002C03D9
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true);
			this.OBLBJDPHCIG = base.EDFIBHNHAAB(this.tiltShiftShader, this.OBLBJDPHCIG);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x002C2214 File Offset: 0x002C0414
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat(" Also make sure to disable sprite packing for this sprite.", (this.maxBlurSize >= 1895f) ? this.maxBlurSize : 1074f);
			this.OBLBJDPHCIG.SetFloat("PerfectHitsScoreText", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 1612f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & 113), HLBKCLPNHEB.height >> (this.downsample & -87), 0, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 0) : num);
			if (this.downsample > 1)
			{
				this.OBLBJDPHCIG.SetTexture("Set Particle Size", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 8);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x002C2334 File Offset: 0x002C0534
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat("_BlurSize", (this.maxBlurSize >= 0f) ? this.maxBlurSize : 0f);
			this.OBLBJDPHCIG.SetFloat("_BlurArea", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> this.downsample, HLBKCLPNHEB.height >> this.downsample, 0, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 2;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 1) : num);
			if (this.downsample > 0)
			{
				this.OBLBJDPHCIG.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 6);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x002C2454 File Offset: 0x002C0654
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat("#savemapchanges?", (this.maxBlurSize >= 1052f) ? this.maxBlurSize : 982f);
			this.OBLBJDPHCIG.SetFloat("SetSatelliteSensitivity", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 194f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & 65), HLBKCLPNHEB.height >> (this.downsample & 88), 0, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 5;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 0) : num);
			if (this.downsample > 1)
			{
				this.OBLBJDPHCIG.SetTexture("Player Connected", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 4);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x002C2598 File Offset: 0x002C0798
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat("value", (this.maxBlurSize >= 1152f) ? this.maxBlurSize : 515f);
			this.OBLBJDPHCIG.SetFloat("couldn't be found!", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 1055f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & 15), HLBKCLPNHEB.height >> (this.downsample & 38), 1, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 2;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 0) : num);
			if (this.downsample > 1)
			{
				this.OBLBJDPHCIG.SetTexture("/", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 4);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x002C26B8 File Offset: 0x002C08B8
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat("finished", (this.maxBlurSize >= 1118f) ? this.maxBlurSize : 745f);
			this.OBLBJDPHCIG.SetFloat("SetParticlesGravity", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 1890f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & -123), HLBKCLPNHEB.height >> (this.downsample & 32), 0, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 1) : num);
			if (this.downsample > 1)
			{
				this.OBLBJDPHCIG.SetTexture("_CameraClipInfo", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 8);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x002C27D5 File Offset: 0x002C09D5
		public virtual bool MOLMLGKEBOL()
		{
			base.CKIAMHAKJOK(false);
			this.OBLBJDPHCIG = base.LKIJNGDHLAK(this.tiltShiftShader, this.OBLBJDPHCIG);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x002C2810 File Offset: 0x002C0A10
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat(". Should be just one?", (this.maxBlurSize >= 1264f) ? this.maxBlurSize : 411f);
			this.OBLBJDPHCIG.SetFloat("_ScreenResolution", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 609f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & 33), HLBKCLPNHEB.height >> (this.downsample & 0), 1, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 5;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 1) : num);
			if (this.downsample > 0)
			{
				this.OBLBJDPHCIG.SetTexture("finished", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 8);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x002C292D File Offset: 0x002C0B2D
		public virtual bool AMKCNLBKLDJ()
		{
			base.MBMLNJJEONO(false);
			this.OBLBJDPHCIG = base.NODBMINMALP(this.tiltShiftShader, this.OBLBJDPHCIG);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x002C2966 File Offset: 0x002C0B66
		public virtual bool KIELKBGLNKO()
		{
			base.MBMLNJJEONO(true);
			this.OBLBJDPHCIG = base.KDHKHOHMKCG(this.tiltShiftShader, this.OBLBJDPHCIG);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x002C29A0 File Offset: 0x002C0BA0
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat(" = ", (this.maxBlurSize >= 1921f) ? this.maxBlurSize : 1215f);
			this.OBLBJDPHCIG.SetFloat("BitsData", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 1699f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & -25), HLBKCLPNHEB.height >> (this.downsample & 93), 1, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 5;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 1) : num);
			if (this.downsample > 0)
			{
				this.OBLBJDPHCIG.SetTexture("_Value3", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 0);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x002C2ABD File Offset: 0x002C0CBD
		public virtual bool KLLLLEOIGHG()
		{
			base.IBFDMKMOBCA(false);
			this.OBLBJDPHCIG = base.EDFIBHNHAAB(this.tiltShiftShader, this.OBLBJDPHCIG);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x002C2AF8 File Offset: 0x002C0CF8
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.OBLBJDPHCIG.SetFloat("OneHand", (this.maxBlurSize >= 1770f) ? this.maxBlurSize : 585f);
			this.OBLBJDPHCIG.SetFloat("[LevelEditorScene] Item creation successful! Published Item ID: ", this.blurArea);
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			RenderTexture renderTexture = BMMLHGHKBNM;
			if ((float)this.downsample > 729f)
			{
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> (this.downsample & 68), HLBKCLPNHEB.height >> (this.downsample & -78), 0, HLBKCLPNHEB.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.OBLBJDPHCIG, (this.mode != TiltShift.TiltShiftMode.TiltShiftMode) ? (num + 0) : num);
			if (this.downsample > 1)
			{
				this.OBLBJDPHCIG.SetTexture("_Value2", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.OBLBJDPHCIG, 6);
			}
			if (renderTexture != BMMLHGHKBNM)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x002C2C15 File Offset: 0x002C0E15
		public virtual bool KFDALIFKLHE()
		{
			base.KHNPMDDIJAJ(false);
			this.OBLBJDPHCIG = base.KDHKHOHMKCG(this.tiltShiftShader, this.OBLBJDPHCIG);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000E84 RID: 3716
		public TiltShift.TiltShiftMode mode;

		// Token: 0x04000E85 RID: 3717
		public TiltShift.TiltShiftQuality quality = TiltShift.TiltShiftQuality.Normal;

		// Token: 0x04000E86 RID: 3718
		[Range(0f, 15f)]
		public float blurArea = 1f;

		// Token: 0x04000E87 RID: 3719
		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		// Token: 0x04000E88 RID: 3720
		[Range(0f, 1f)]
		public int downsample;

		// Token: 0x04000E89 RID: 3721
		public Shader tiltShiftShader;

		// Token: 0x04000E8A RID: 3722
		private Material OBLBJDPHCIG;

		// Token: 0x020001F9 RID: 505
		public enum TiltShiftMode
		{
			// Token: 0x04000E8C RID: 3724
			TiltShiftMode,
			// Token: 0x04000E8D RID: 3725
			IrisMode
		}

		// Token: 0x020001FA RID: 506
		public enum TiltShiftQuality
		{
			// Token: 0x04000E8F RID: 3727
			Preview,
			// Token: 0x04000E90 RID: 3728
			Normal,
			// Token: 0x04000E91 RID: 3729
			High
		}
	}
}
