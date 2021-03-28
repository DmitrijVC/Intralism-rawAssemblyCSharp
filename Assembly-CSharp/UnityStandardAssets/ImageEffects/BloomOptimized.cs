using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001CB RID: 459
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class BloomOptimized : PostEffectsBase
	{
		// Token: 0x06007A04 RID: 31236 RVA: 0x0026CA68 File Offset: 0x0026AC68
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 8 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 234f : 1343f;
			this.LIEPIPBIBDN.SetVector("BadgeText", new Vector4(this.blurSize * num2, 1537f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("OnDeserialize", new Vector4(this.blurSize * num2 + (float)i * 554f, 173f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("RespawnAfter", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x0026CC20 File Offset: 0x0026AE20
		private void JIHNFLGAMJE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 860f : 1010f;
			this.LIEPIPBIBDN.SetVector("#mapby", new Vector4(this.blurSize * num2, 977f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_TimeX", new Vector4(this.blurSize * num2 + (float)i * 1649f, 877f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture(" not found", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x0026CDD8 File Offset: 0x0026AFD8
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 8 : 4;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1192f : 1167f;
			this.LIEPIPBIBDN.SetVector("Joystick1Button1", new Vector4(this.blurSize * num2, 1923f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 3 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("isVisible", new Vector4(this.blurSize * num2 + (float)i * 448f, 343f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("\n", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x0026CF8E File Offset: 0x0026B18E
		public virtual bool ONAHEOAPKBP()
		{
			base.CKIAMHAKJOK(true);
			this.LIEPIPBIBDN = base.NODBMINMALP(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x0026CFC7 File Offset: 0x0026B1C7
		public virtual bool FNKEKPIFDKA()
		{
			base.MBMLNJJEONO(false);
			this.LIEPIPBIBDN = base.LKIJNGDHLAK(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x0026D000 File Offset: 0x0026B200
		public virtual bool PDNFBCMPHEI()
		{
			base.DHHGCBANGJL(false);
			this.LIEPIPBIBDN = base.AJKPGPKKHHB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x0026D039 File Offset: 0x0026B239
		public virtual bool JOACCNEJLJL()
		{
			base.DHHGCBANGJL(false);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x0026D072 File Offset: 0x0026B272
		private void GBGAMCPNBCC()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x0026D090 File Offset: 0x0026B290
		private void POENGNEMHJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 2 : 8;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1624f : 1026f;
			this.LIEPIPBIBDN.SetVector("shader.ghost", new Vector4(this.blurSize * num2, 1454f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("CameraFilterPack/Colors_NewPosterize", new Vector4(this.blurSize * num2 + (float)i * 218f, 1426f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("LeaderboardsButton", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x0026D072 File Offset: 0x0026B272
		private void PNNPDMHLFHE()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x0026D072 File Offset: 0x0026B272
		private void IEFMONDKKJN()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x0026D072 File Offset: 0x0026B272
		private void HNGHDAPKEJG()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x0026D072 File Offset: 0x0026B272
		private void MFLBEJHMEMO()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x0026D248 File Offset: 0x0026B448
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 3;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 713f : 718f;
			this.LIEPIPBIBDN.SetVector("{", new Vector4(this.blurSize * num2, 1193f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 8 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("settings.arcsnohitsoundtimedelay", new Vector4(this.blurSize * num2 + (float)i * 1831f, 1994f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("Feb", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x0026D072 File Offset: 0x0026B272
		private void NAALCEPIHCH()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x0026D3FE File Offset: 0x0026B5FE
		public virtual bool KJOKEGFHMJB()
		{
			base.CKIAMHAKJOK(true);
			this.LIEPIPBIBDN = base.GJKHKCOAFDB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x0026D072 File Offset: 0x0026B272
		private void NNBCLMJGFEN()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x0026D438 File Offset: 0x0026B638
		private void AOGCKKLFGPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 6 : 2;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1471f : 1528f;
			this.LIEPIPBIBDN.SetVector("map.data", new Vector4(this.blurSize * num2, 989f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 4 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("_Near", new Vector4(this.blurSize * num2 + (float)i * 1777f, 1727f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_ScreenResolution", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x0026D072 File Offset: 0x0026B272
		private void CNPINCHINJA()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x0026D5EE File Offset: 0x0026B7EE
		public override bool AFNHKGFNOCL()
		{
			base.DCHKKHDGBLJ(false);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x0026D072 File Offset: 0x0026B272
		private void ONPFGCEFMML()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x0026D072 File Offset: 0x0026B272
		private void OnDisable()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x0026D627 File Offset: 0x0026B827
		public virtual bool EICPCBFEDNI()
		{
			base.KHNPMDDIJAJ(true);
			this.LIEPIPBIBDN = base.NODBMINMALP(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x0026D660 File Offset: 0x0026B860
		public virtual bool MJKEPBHOGOL()
		{
			base.LMEBEGFJGEM(false);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x0026D69C File Offset: 0x0026B89C
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 3 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 937f : 537f;
			this.LIEPIPBIBDN.SetVector("id", new Vector4(this.blurSize * num2, 102f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("Folk", new Vector4(this.blurSize * num2 + (float)i * 1173f, 1122f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("Start", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x0026D854 File Offset: 0x0026BA54
		private void PEBBCNICBDK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1951f : 226f;
			this.LIEPIPBIBDN.SetVector("_UserLutTex", new Vector4(this.blurSize * num2, 1775f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 7 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("Attempting to remove texture that was not allocated: {0}", new Vector4(this.blurSize * num2 + (float)i * 1310f, 1567f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Value5", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x0026DA0C File Offset: 0x0026BC0C
		private void NPBDIMJDMGA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 7;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1454f : 880f;
			this.LIEPIPBIBDN.SetVector(":\n", new Vector4(this.blurSize * num2, 215f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("restrictions\n\n#until: ", new Vector4(this.blurSize * num2 + (float)i * 622f, 1123f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture(" not exist", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x0026DBC2 File Offset: 0x0026BDC2
		public virtual bool INPJJOOGMMO()
		{
			base.DHHGCBANGJL(true);
			this.LIEPIPBIBDN = base.AJKPGPKKHHB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x0026D072 File Offset: 0x0026B272
		private void LINKAMEPKGM()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x0026DBFC File Offset: 0x0026BDFC
		private void IFMHIDNCFFH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1866f : 1505f;
			this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2, 1212f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 4 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("[LobbyPlayerElement] On ready click", new Vector4(this.blurSize * num2 + (float)i * 1924f, 1299f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture(".icon", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x0026DDB4 File Offset: 0x0026BFB4
		private void MMBPPEPNNLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 3 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 632f : 1596f;
			this.LIEPIPBIBDN.SetVector("_ScreenResolution", new Vector4(this.blurSize * num2, 1411f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 2 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Red_C", new Vector4(this.blurSize * num2 + (float)i * 1033f, 1576f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("mapselector.filter.subscribedonly", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x0026D072 File Offset: 0x0026B272
		private void GJAJBMGGPFB()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x0026DF6C File Offset: 0x0026C16C
		private void GENCBNFIILN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 534f : 253f;
			this.LIEPIPBIBDN.SetVector("PUNCloudBestRegion", new Vector4(this.blurSize * num2, 1381f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 4 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("id", new Vector4(this.blurSize * num2 + (float)i * 834f, 958f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_TimeX", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x0026D072 File Offset: 0x0026B272
		private void LLKKGGLNIDF()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x0026E124 File Offset: 0x0026C324
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 6 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 517f : 90f;
			this.LIEPIPBIBDN.SetVector("settings.hitvariation", new Vector4(this.blurSize * num2, 444f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 2 : 1;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("BitsData", new Vector4(this.blurSize * num2 + (float)i * 969f, 1309f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_ScreenResolution", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x0026E2DA File Offset: 0x0026C4DA
		public virtual bool BPKMCMACDJI()
		{
			base.DHHGCBANGJL(false);
			this.LIEPIPBIBDN = base.AJKPGPKKHHB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x0026E314 File Offset: 0x0026C514
		private void KCNIHHNMFFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 8 : 7;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1073f : 1886f;
			this.LIEPIPBIBDN.SetVector("Init", new Vector4(this.blurSize * num2, 1282f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 1;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("Edited unlock conditions", new Vector4(this.blurSize * num2 + (float)i * 975f, 987f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("GridDataArcs", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x0026E4CC File Offset: 0x0026C6CC
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 0 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 234f : 92f;
			this.LIEPIPBIBDN.SetVector("_SprTex", new Vector4(this.blurSize * num2, 1010f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("SetSunInput", new Vector4(this.blurSize * num2 + (float)i * 1165f, 1679f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("SetSatelliteTrailWidth", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x0026E684 File Offset: 0x0026C884
		private void CACCPBENDAP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 3;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 82f : 637f;
			this.LIEPIPBIBDN.SetVector("#exit", new Vector4(this.blurSize * num2, 830f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector(": ", new Vector4(this.blurSize * num2 + (float)i * 635f, 14f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("Chat", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x0026D072 File Offset: 0x0026B272
		private void EODOHEAKJFO()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0026E83A File Offset: 0x0026CA3A
		public virtual bool LPJNPOJDAOB()
		{
			base.KNGDKKMDKOG(true);
			this.LIEPIPBIBDN = base.ECNEGNMAMDE(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x0026D072 File Offset: 0x0026B272
		private void DHENLPJJOEN()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x0026D072 File Offset: 0x0026B272
		private void FDPOFMCFBMF()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0026E873 File Offset: 0x0026CA73
		public virtual bool OCADOBLPPAA()
		{
			base.JOMCJOEOLHP(true);
			this.LIEPIPBIBDN = base.LKIJNGDHLAK(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x0026E8AC File Offset: 0x0026CAAC
		public virtual bool EGMHIDMIFCI()
		{
			base.MBMLNJJEONO(false);
			this.LIEPIPBIBDN = base.LKIJNGDHLAK(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x0026D072 File Offset: 0x0026B272
		private void EKPLGFAEOBE()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x0026E8E8 File Offset: 0x0026CAE8
		private void HJGNJDAADGP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 8 : 7;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1760f : 634f;
			this.LIEPIPBIBDN.SetVector("menu.playedpage", new Vector4(this.blurSize * num2, 140f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 5 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("CompletedLevel", new Vector4(this.blurSize * num2 + (float)i * 987f, 1579f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Blood", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x0026EA9E File Offset: 0x0026CC9E
		public virtual bool KDFBAJGKACD()
		{
			base.NPOEJIDLJGK(true);
			this.LIEPIPBIBDN = base.AJKPGPKKHHB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x0026D072 File Offset: 0x0026B272
		private void JHJFBCFBKLD()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x0026D072 File Offset: 0x0026B272
		private void EFECEKPFOEM()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x0026EAD8 File Offset: 0x0026CCD8
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 4;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1111f : 462f;
			this.LIEPIPBIBDN.SetVector("Tab1Content", new Vector4(this.blurSize * num2, 921f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 3 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("settings_bindings_controller_type", new Vector4(this.blurSize * num2 + (float)i * 1007f, 875f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("CameraFilterPack/Vision_Tunnel", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x0026EC90 File Offset: 0x0026CE90
		private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1109f : 615f;
			this.LIEPIPBIBDN.SetVector("_TimeX", new Vector4(this.blurSize * num2, 1605f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 8 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("mapselector.filter.favoriteonly", new Vector4(this.blurSize * num2 + (float)i * 1053f, 130f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("[LevelEditorScene] Print Audio Wave: Start", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x0026EE48 File Offset: 0x0026D048
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 7;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 329f : 649f;
			this.LIEPIPBIBDN.SetVector("offsets", new Vector4(this.blurSize * num2, 229f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 5 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("[PlayerController] ", new Vector4(this.blurSize * num2 + (float)i * 1597f, 553f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("The other scroll rect doesnt support scrolling horizontally", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x0026F000 File Offset: 0x0026D200
		private void HCOGCFOBBMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 4;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1682f : 897f;
			this.LIEPIPBIBDN.SetVector("settings_bindings_sec_", new Vector4(this.blurSize * num2, 1882f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("Editor/", new Vector4(this.blurSize * num2 + (float)i * 312f, 1244f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("(\\[ */ *h1 *\\])", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x0026F1B8 File Offset: 0x0026D3B8
		private void BLMICAMBBCD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 0 : 2;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 829f : 1213f;
			this.LIEPIPBIBDN.SetVector("_Source", new Vector4(this.blurSize * num2, 1348f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 1 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Threshhold", new Vector4(this.blurSize * num2 + (float)i * 231f, 1356f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_FgCocMask", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x0026F370 File Offset: 0x0026D570
		private void BMBIGILMLLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 7 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1390f : 1692f;
			this.LIEPIPBIBDN.SetVector("_ScreenResolution", new Vector4(this.blurSize * num2, 1746f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 1 : 1;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("_ScreenResolution", new Vector4(this.blurSize * num2 + (float)i * 232f, 1074f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Value3", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x0026F528 File Offset: 0x0026D728
		private void GOANCMNGDLE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 4 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1857f : 437f;
			this.LIEPIPBIBDN.SetVector("CameraFilterPack/Blend2Camera_ColorBurn", new Vector4(this.blurSize * num2, 1019f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 1 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("Right", new Vector4(this.blurSize * num2 + (float)i * 187f, 1270f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Distortion", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x0026F6E0 File Offset: 0x0026D8E0
		private void IFPOOKJLOJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 8 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 342f : 1363f;
			this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2, 1351f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 2 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("settings.fps", new Vector4(this.blurSize * num2 + (float)i * 1528f, 720f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("ControllerRightX", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x0026F896 File Offset: 0x0026DA96
		public virtual bool GOEOHOLLPKJ()
		{
			base.DHHGCBANGJL(true);
			this.LIEPIPBIBDN = base.NODBMINMALP(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x0026F8D0 File Offset: 0x0026DAD0
		private void GOIMKCCICFK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 8 : 8;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 835f : 1863f;
			this.LIEPIPBIBDN.SetVector("workshop.", new Vector4(this.blurSize * num2, 1067f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 4 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("_Value7", new Vector4(this.blurSize * num2 + (float)i * 801f, 1408f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("\"", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x0026FA88 File Offset: 0x0026DC88
		private void CDCLDBFMKOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 1;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1924f : 593f;
			this.LIEPIPBIBDN.SetVector("CameraFilterPack_WaterDrop", new Vector4(this.blurSize * num2, 104f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("0.00", new Vector4(this.blurSize * num2 + (float)i * 191f, 1806f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Value2", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x0026FC3E File Offset: 0x0026DE3E
		public virtual bool JIJIMMICLAM()
		{
			base.MBMLNJJEONO(true);
			this.LIEPIPBIBDN = base.AJKPGPKKHHB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x0026FC77 File Offset: 0x0026DE77
		public virtual bool CGNGNMFABEP()
		{
			base.LMEBEGFJGEM(true);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x0026FCB0 File Offset: 0x0026DEB0
		public virtual bool GHFILFDHANN()
		{
			base.CKIAMHAKJOK(true);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x0026FD1C File Offset: 0x0026DF1C
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 6 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1192f : 1608f;
			this.LIEPIPBIBDN.SetVector("itemid", new Vector4(this.blurSize * num2, 1402f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 8 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2 + (float)i * 1875f, 878f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("value", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x0026FED2 File Offset: 0x0026E0D2
		public virtual bool PDMNDFFNOPM()
		{
			base.IBFDMKMOBCA(false);
			this.LIEPIPBIBDN = base.GJKHKCOAFDB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x0026D072 File Offset: 0x0026B272
		private void PLIKADJCEPO()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x0026FF0B File Offset: 0x0026E10B
		public virtual bool KIBBICMGDMF()
		{
			base.KNGDKKMDKOG(false);
			this.LIEPIPBIBDN = base.LKIJNGDHLAK(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x0026FF44 File Offset: 0x0026E144
		public virtual bool HBNCKBEPKGF()
		{
			base.LMEBEGFJGEM(true);
			this.LIEPIPBIBDN = base.LKIJNGDHLAK(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x0026D072 File Offset: 0x0026B272
		private void BOLBPPHJBMI()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x0026FF80 File Offset: 0x0026E180
		private void DHLCNIINMDM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 4 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1759f : 1796f;
			this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2, 1531f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 2 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("inventory.selected.", new Vector4(this.blurSize * num2 + (float)i * 315f, 556f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("Set Trail Zoom (player camera move forward effect). Base value - 1.5", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x00270136 File Offset: 0x0026E336
		public virtual bool EBILAMEAKFC()
		{
			base.CKIAMHAKJOK(true);
			this.LIEPIPBIBDN = base.ECNEGNMAMDE(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x0027016F File Offset: 0x0026E36F
		public virtual bool HDDNBPJGGFK()
		{
			base.KHNPMDDIJAJ(true);
			this.LIEPIPBIBDN = base.AJKPGPKKHHB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x002701A8 File Offset: 0x0026E3A8
		public virtual bool PHEIDFBDELF()
		{
			base.IHMNPAHGNFF(true);
			this.LIEPIPBIBDN = base.ECNEGNMAMDE(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x002701E1 File Offset: 0x0026E3E1
		public virtual bool MOLMLGKEBOL()
		{
			base.IHMNPAHGNFF(true);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x0027021C File Offset: 0x0026E41C
		private void JMAJIOHDKCM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 7 : 1;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 504f : 1266f;
			this.LIEPIPBIBDN.SetVector("settings.arcsdestroydelay", new Vector4(this.blurSize * num2, 554f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 1;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector(". Set PhotonNetwork.OnEventCall.", new Vector4(this.blurSize * num2 + (float)i * 326f, 1723f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x002703D4 File Offset: 0x0026E5D4
		private void OPIBJIMIOKE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 8;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 688f : 1074f;
			this.LIEPIPBIBDN.SetVector("Right", new Vector4(this.blurSize * num2, 1215f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 5 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2 + (float)i * 519f, 1744f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("CameraFilterPack/Color_Chromatic_Aberration", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x0026D072 File Offset: 0x0026B272
		private void FJIKDJAMOHA()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x0027058C File Offset: 0x0026E78C
		private void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 6 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1667f : 1720f;
			this.LIEPIPBIBDN.SetVector("_ReflectionTexture4", new Vector4(this.blurSize * num2, 576f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 1;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector(" ", new Vector4(this.blurSize * num2 + (float)i * 926f, 1429f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("SpeedSlider", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x00270742 File Offset: 0x0026E942
		public virtual bool BKCNDIBNLNB()
		{
			base.FNIFJAENDIB(true);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x0026D072 File Offset: 0x0026B272
		private void NAOLAJPDGIC()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x0027077B File Offset: 0x0026E97B
		public virtual bool AMKCNLBKLDJ()
		{
			base.CKIAMHAKJOK(false);
			this.LIEPIPBIBDN = base.NODBMINMALP(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x0026D072 File Offset: 0x0026B272
		private void AAEEHINDPNC()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x0026D072 File Offset: 0x0026B272
		private void ALJEADNKJPO()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x002707B4 File Offset: 0x0026E9B4
		public virtual bool DCCPPPDPIJF()
		{
			base.KHNPMDDIJAJ(false);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x0026D072 File Offset: 0x0026B272
		private void IENKPJEBMFM()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x0026D072 File Offset: 0x0026B272
		private void EJJEDJIOFAB()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x0026D072 File Offset: 0x0026B272
		private void KLOLKEBAPFO()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x002707ED File Offset: 0x0026E9ED
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x00270826 File Offset: 0x0026EA26
		public virtual bool IILEKDNFOFI()
		{
			base.IHMNPAHGNFF(false);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x0026D072 File Offset: 0x0026B272
		private void FGBDGGCBFLP()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x0026D072 File Offset: 0x0026B272
		private void JNALDALAJLG()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x0027085F File Offset: 0x0026EA5F
		public virtual bool NHCNNDEHICD()
		{
			base.DHHGCBANGJL(true);
			this.LIEPIPBIBDN = base.NODBMINMALP(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x0026D072 File Offset: 0x0026B272
		private void ABHEJPAGNMO()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x00270898 File Offset: 0x0026EA98
		private void AGDIBDLHMKF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 4 : 8;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 582f : 624f;
			this.LIEPIPBIBDN.SetVector("CreateRoom failed. In offline mode you still have to leave a room to enter another.", new Vector4(this.blurSize * num2, 972f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2 + (float)i * 43f, 1629f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("float,10", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x0026D072 File Offset: 0x0026B272
		private void LIEGJOHINGC()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x00270A50 File Offset: 0x0026EC50
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 3 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1949f : 1868f;
			this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2, 1234f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("workshop.", new Vector4(this.blurSize * num2 + (float)i * 1978f, 28f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_TimeX", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x00270C06 File Offset: 0x0026EE06
		public virtual bool KLLLLEOIGHG()
		{
			base.CKIAMHAKJOK(true);
			this.LIEPIPBIBDN = base.ECNEGNMAMDE(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x00270C40 File Offset: 0x0026EE40
		private void DLIJFEGIEKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 4;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 730f : 1984f;
			this.LIEPIPBIBDN.SetVector("SettingsCanvas", new Vector4(this.blurSize * num2, 1813f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 1;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("GlassDistortion", new Vector4(this.blurSize * num2 + (float)i * 382f, 1438f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("/icon", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x00270DF8 File Offset: 0x0026EFF8
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 8 : 8;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 944f : 1925f;
			this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2, 1491f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 8 : 1;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("skins", new Vector4(this.blurSize * num2 + (float)i * 1493f, 671f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture(": ", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x00270FAE File Offset: 0x0026F1AE
		public virtual bool IHNGNCCNPCK()
		{
			base.DCHKKHDGBLJ(false);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x00270FE8 File Offset: 0x0026F1E8
		private void IEJCEFENLOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 200f : 348f;
			this.LIEPIPBIBDN.SetVector("SingleplayerButton", new Vector4(this.blurSize * num2, 1012f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 4 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("NEW_ACHIEVEMENT_1_21", new Vector4(this.blurSize * num2 + (float)i * 264f, 818f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("[MapEditor] Openning ", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x0026D072 File Offset: 0x0026B272
		private void IBPAMDEAGJL()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x002711A0 File Offset: 0x0026F3A0
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 7 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 911f : 698f;
			this.LIEPIPBIBDN.SetVector("_Intensity", new Vector4(this.blurSize * num2, 1201f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 3 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("SetSatelliteTrailMinVertexDistance", new Vector4(this.blurSize * num2 + (float)i * 180f, 35f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("Joystick1Button7", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x00271356 File Offset: 0x0026F556
		public virtual bool OBEFMKGPJLI()
		{
			base.LMEBEGFJGEM(false);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x0027138F File Offset: 0x0026F58F
		public virtual bool MPJAPLPIDMG()
		{
			base.JOMCJOEOLHP(false);
			this.LIEPIPBIBDN = base.ECNEGNMAMDE(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x0026D072 File Offset: 0x0026B272
		private void OCCGJMPAJIK()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x002713C8 File Offset: 0x0026F5C8
		private void MNMONMPIPPO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1241f : 965f;
			this.LIEPIPBIBDN.SetVector("_Val", new Vector4(this.blurSize * num2, 1418f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 8 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("_Cible", new Vector4(this.blurSize * num2 + (float)i * 990f, 770f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("Editor", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x0027157E File Offset: 0x0026F77E
		public virtual bool ACEIOFMECMD()
		{
			base.LMEBEGFJGEM(false);
			this.LIEPIPBIBDN = base.ECNEGNMAMDE(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x0026D072 File Offset: 0x0026B272
		private void HGDDCINLDAD()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x0026D072 File Offset: 0x0026B272
		private void EKCKJLFFAID()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x002715B8 File Offset: 0x0026F7B8
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 3 : 1;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 24f : 358f;
			this.LIEPIPBIBDN.SetVector("DPADVER", new Vector4(this.blurSize * num2, 706f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 8 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_FixDistance", new Vector4(this.blurSize * num2 + (float)i * 727f, 1064f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("getint", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x0026D072 File Offset: 0x0026B272
		private void CPAJLKHMOJB()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x0027176E File Offset: 0x0026F96E
		public virtual bool PCBGKEHFKEH()
		{
			base.FNIFJAENDIB(true);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x002717A8 File Offset: 0x0026F9A8
		private void FIKNBPAIFBI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 2 : 8;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 208f : 1151f;
			this.LIEPIPBIBDN.SetVector("_Bullet_9", new Vector4(this.blurSize * num2, 1627f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("CameraFilterPack/Lut_Simple", new Vector4(this.blurSize * num2 + (float)i * 1834f, 1314f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_ScreenResolution", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A78 RID: 31352 RVA: 0x00271960 File Offset: 0x0026FB60
		private void KDOCJGGAOII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 3 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1030f : 1492f;
			this.LIEPIPBIBDN.SetVector("_Offsets", new Vector4(this.blurSize * num2, 1388f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 1 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("RarityImage", new Vector4(this.blurSize * num2 + (float)i * 1865f, 1947f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Vignetting2", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A79 RID: 31353 RVA: 0x0026D072 File Offset: 0x0026B272
		private void LECCHIAFGGE()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x00271B16 File Offset: 0x0026FD16
		public virtual bool ANCBDJKLGAI()
		{
			base.KHNPMDDIJAJ(false);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x00271B50 File Offset: 0x0026FD50
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 6;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 889f : 516f;
			this.LIEPIPBIBDN.SetVector(".lastCheckpoint.penaltyScore", new Vector4(this.blurSize * num2, 1159f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 5 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_SizeX", new Vector4(this.blurSize * num2 + (float)i * 854f, 1266f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_ScreenResolution", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x00271D08 File Offset: 0x0026FF08
		private void HHJBIALGCME(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 0 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 469f : 933f;
			this.LIEPIPBIBDN.SetVector(" (", new Vector4(this.blurSize * num2, 1755f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 5 : 1;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_ColorRGB", new Vector4(this.blurSize * num2 + (float)i * 39f, 950f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("inventory.selected.", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x00271EBE File Offset: 0x002700BE
		public virtual bool IEADOJPLNPO()
		{
			base.JOMCJOEOLHP(true);
			this.LIEPIPBIBDN = base.GJKHKCOAFDB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x00271EF8 File Offset: 0x002700F8
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 3 : 0;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1600f : 1939f;
			this.LIEPIPBIBDN.SetVector("skin.no_hit", new Vector4(this.blurSize * num2, 1888f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 3 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("#failed!", new Vector4(this.blurSize * num2 + (float)i * 734f, 1882f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("Have you fully accept the terms?", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x002720AE File Offset: 0x002702AE
		public virtual bool ENDFLCJNOGA()
		{
			base.IBFDMKMOBCA(false);
			this.LIEPIPBIBDN = base.ECNEGNMAMDE(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x0026D072 File Offset: 0x0026B272
		private void CCPEDDLAMIB()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x002720E8 File Offset: 0x002702E8
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 2 : 4;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1f : 0.5f;
			this.LIEPIPBIBDN.SetVector("_Parameter", new Vector4(this.blurSize * num2, 0f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 2 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Parameter", new Vector4(this.blurSize * num2 + (float)i * 1f, 0f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x0026D072 File Offset: 0x0026B272
		private void JNGMIAFLBDL()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x0026D072 File Offset: 0x0026B272
		private void PHJLHCMCCKE()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x0027229E File Offset: 0x0027049E
		public virtual bool IMPENFDFLPH()
		{
			base.IBFDMKMOBCA(true);
			this.LIEPIPBIBDN = base.AJKPGPKKHHB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x002722D7 File Offset: 0x002704D7
		public virtual bool EAOFDBCPJDI()
		{
			base.JOMCJOEOLHP(true);
			this.LIEPIPBIBDN = base.EDFIBHNHAAB(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00272310 File Offset: 0x00270510
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 5 : 3;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1706f : 1660f;
			this.LIEPIPBIBDN.SetVector("maps.", new Vector4(this.blurSize * num2, 1769f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 1 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("_SpotSize", new Vector4(this.blurSize * num2 + (float)i * 1913f, 146f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture(" while connecting to: ", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x002724C8 File Offset: 0x002706C8
		private void IHAAHFFMJLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 3 : 1;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 94f : 440f;
			this.LIEPIPBIBDN.SetVector("UndoButton", new Vector4(this.blurSize * num2, 981f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Value", new Vector4(this.blurSize * num2 + (float)i * 308f, 839f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Value", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x00272680 File Offset: 0x00270880
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 6 : 4;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1730f : 1728f;
			this.LIEPIPBIBDN.SetVector("menu.selectedplaymode", new Vector4(this.blurSize * num2, 1271f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 4 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.LIEPIPBIBDN.SetVector("RPCs can only be sent in rooms. Call of \"", new Vector4(this.blurSize * num2 + (float)i * 1785f, 1542f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("_Value3", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x0026D072 File Offset: 0x0026B272
		private void CIHGFHNNFEE()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x00272836 File Offset: 0x00270A36
		public virtual bool DIAEBALGKAP()
		{
			base.IBFDMKMOBCA(true);
			this.LIEPIPBIBDN = base.KDHKHOHMKCG(this.fastBloomShader, this.LIEPIPBIBDN);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x00272870 File Offset: 0x00270A70
		private void LNOOFNGHNEL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 777f : 749f;
			this.LIEPIPBIBDN.SetVector("_Value2", new Vector4(this.blurSize * num2, 1343f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 1);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 0 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("Select", new Vector4(this.blurSize * num2 + (float)i * 1675f, 1965f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("#FFFFFF", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x0026D072 File Offset: 0x0026B272
		private void ICDBMJKMIKC()
		{
			if (this.LIEPIPBIBDN)
			{
				UnityEngine.Object.DestroyImmediate(this.LIEPIPBIBDN);
			}
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x00272A28 File Offset: 0x00270C28
		private void ELHDLIHODGE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int num = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 2 : 5;
			float num2 = (this.FEKLGMEFABB != BloomOptimized.Resolution.Low) ? 1670f : 499f;
			this.LIEPIPBIBDN.SetVector("_Value", new Vector4(this.blurSize * num2, 425f, this.threshold, this.intensity));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LIEPIPBIBDN, 0);
			int num3 = (this.blurType != BloomOptimized.BlurType.Standard) ? 6 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.LIEPIPBIBDN.SetVector("_Level", new Vector4(this.blurSize * num2 + (float)i * 890f, 1547f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.LIEPIPBIBDN, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.LIEPIPBIBDN.SetTexture("No connection to item server!", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LIEPIPBIBDN, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x04000D29 RID: 3369
		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		// Token: 0x04000D2A RID: 3370
		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		// Token: 0x04000D2B RID: 3371
		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		// Token: 0x04000D2C RID: 3372
		private BloomOptimized.Resolution FEKLGMEFABB;

		// Token: 0x04000D2D RID: 3373
		[Range(1f, 4f)]
		public int blurIterations = 1;

		// Token: 0x04000D2E RID: 3374
		public BloomOptimized.BlurType blurType;

		// Token: 0x04000D2F RID: 3375
		public Shader fastBloomShader;

		// Token: 0x04000D30 RID: 3376
		private Material LIEPIPBIBDN;

		// Token: 0x020001CC RID: 460
		public enum Resolution
		{
			// Token: 0x04000D32 RID: 3378
			Low,
			// Token: 0x04000D33 RID: 3379
			High
		}

		// Token: 0x020001CD RID: 461
		public enum BlurType
		{
			// Token: 0x04000D35 RID: 3381
			Standard,
			// Token: 0x04000D36 RID: 3382
			Sgx
		}
	}
}
