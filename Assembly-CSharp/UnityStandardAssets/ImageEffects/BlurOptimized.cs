using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001CF RID: 463
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BlurOptimized : PostEffectsBase
	{
		// Token: 0x06007AD8 RID: 31448 RVA: 0x002742F6 File Offset: 0x002724F6
		public virtual bool KIELKBGLNKO()
		{
			base.FNIFJAENDIB(false);
			this.HKNGEKKGPFK = base.LKIJNGDHLAK(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x00274330 File Offset: 0x00272530
		public void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 747f / (368f * (float)(1 << (this.downsample & -15)));
			this.HKNGEKKGPFK.SetVector("_Value2", new Vector4(this.blurSize * num, -this.blurSize * num, 1049f, 835f));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width >> (this.downsample & 86);
			int height = HLBKCLPNHEB.height >> (this.downsample & -53);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 5 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1588f;
				this.HKNGEKKGPFK.SetVector(">", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 5f, 879f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 4 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x002744C9 File Offset: 0x002726C9
		public virtual bool HDDNBPJGGFK()
		{
			base.FNIFJAENDIB(true);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x00274504 File Offset: 0x00272704
		public void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1472f / (859f * (float)(1 << (this.downsample & -115)));
			this.HKNGEKKGPFK.SetVector("[LevelEditorScene] Error: I/O Failure! :(", new Vector4(this.blurSize * num, -this.blurSize * num, 292f, 1495f));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width >> (this.downsample & 8);
			int height = HLBKCLPNHEB.height >> (this.downsample & -49);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 5 : 1;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 918f;
				this.HKNGEKKGPFK.SetVector(". Should be just one?", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 112f, 146f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x0027469D File Offset: 0x0027289D
		public virtual bool IMPPEKJHPIM()
		{
			base.KNGDKKMDKOG(false);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x002746D6 File Offset: 0x002728D6
		public void GAOOPEEBGJA()
		{
			if (this.HKNGEKKGPFK)
			{
				UnityEngine.Object.DestroyImmediate(this.HKNGEKKGPFK);
			}
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x002746F4 File Offset: 0x002728F4
		public void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1733f / (1941f * (float)(1 << (this.downsample & 7)));
			this.HKNGEKKGPFK.SetVector("_Value4", new Vector4(this.blurSize * num, -this.blurSize * num, 1445f, 914f));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width >> (this.downsample & -14);
			int height = HLBKCLPNHEB.height >> (this.downsample & 117);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 0);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 8 : 1;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 540f;
				this.HKNGEKKGPFK.SetVector("event", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1523f, 984f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 8 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x0027488D File Offset: 0x00272A8D
		public virtual bool GACCMCAGAIJ()
		{
			base.DHHGCBANGJL(false);
			this.HKNGEKKGPFK = base.GJKHKCOAFDB(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x002746D6 File Offset: 0x002728D6
		public void LADCJEIALMH()
		{
			if (this.HKNGEKKGPFK)
			{
				UnityEngine.Object.DestroyImmediate(this.HKNGEKKGPFK);
			}
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x002748C6 File Offset: 0x00272AC6
		public virtual bool MPMLKLHMPJH()
		{
			base.DCHKKHDGBLJ(true);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x002748FF File Offset: 0x00272AFF
		public virtual bool JFFKKNHBANB()
		{
			base.DCHKKHDGBLJ(false);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x00274938 File Offset: 0x00272B38
		public void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 803f / (1883f * (float)(1 << (this.downsample & 108)));
			this.HKNGEKKGPFK.SetVector("#tryagain", new Vector4(this.blurSize * num, -this.blurSize * num, 774f, 1616f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & 112);
			int height = HLBKCLPNHEB.height >> (this.downsample & 79);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 2 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1477f;
				this.HKNGEKKGPFK.SetVector("_Value3", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 882f, 1502f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 3 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x00274AD1 File Offset: 0x00272CD1
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x00274B0C File Offset: 0x00272D0C
		public void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1829f / (351f * (float)(0 << (this.downsample & 26)));
			this.HKNGEKKGPFK.SetVector("{0,-18} {1,18}", new Vector4(this.blurSize * num, -this.blurSize * num, 323f, 1653f));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width >> (this.downsample & 100);
			int height = HLBKCLPNHEB.height >> (this.downsample & 97);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 1 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 206f;
				this.HKNGEKKGPFK.SetVector("SetTrailZoomSpeed", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1945f, 1547f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x00274CC8 File Offset: 0x00272EC8
		public void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1749f / (851f * (float)(1 << (this.downsample & 5)));
			this.HKNGEKKGPFK.SetVector("OK", new Vector4(this.blurSize * num, -this.blurSize * num, 53f, 1979f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & 60);
			int height = HLBKCLPNHEB.height >> (this.downsample & 62);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 0);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 2 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 292f;
				this.HKNGEKKGPFK.SetVector("CameraFilterPack/TV_CompressionFX", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 227f, 1928f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 7 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x00274E61 File Offset: 0x00273061
		public virtual bool NHCNNDEHICD()
		{
			base.IBFDMKMOBCA(true);
			this.HKNGEKKGPFK = base.ECNEGNMAMDE(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x002746D6 File Offset: 0x002728D6
		public void JHJFBCFBKLD()
		{
			if (this.HKNGEKKGPFK)
			{
				UnityEngine.Object.DestroyImmediate(this.HKNGEKKGPFK);
			}
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x00274E9A File Offset: 0x0027309A
		public virtual bool LPDMNDMCPCO()
		{
			base.CKIAMHAKJOK(true);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x00274ED4 File Offset: 0x002730D4
		public void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 30f / (576f * (float)(1 << (this.downsample & -49)));
			this.HKNGEKKGPFK.SetVector("_Value", new Vector4(this.blurSize * num, -this.blurSize * num, 1303f, 1013f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & -1);
			int height = HLBKCLPNHEB.height >> (this.downsample & -62);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 0 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 799f;
				this.HKNGEKKGPFK.SetVector("VIGNETTE_CLASSIC", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 826f, 1232f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 6 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x00275070 File Offset: 0x00273270
		public void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1947f / (281f * (float)(1 << (this.downsample & -19)));
			this.HKNGEKKGPFK.SetVector("Set sun audio input", new Vector4(this.blurSize * num, -this.blurSize * num, 1996f, 1424f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & -123);
			int height = HLBKCLPNHEB.height >> (this.downsample & -73);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 0);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 0 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 861f;
				this.HKNGEKKGPFK.SetVector("_ScreenResolution", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1774f, 1256f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 7 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x0027520C File Offset: 0x0027340C
		public void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1659f / (889f * (float)(1 << (this.downsample & -95)));
			this.HKNGEKKGPFK.SetVector("_CurrentMipLevel", new Vector4(this.blurSize * num, -this.blurSize * num, 1841f, 844f));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width >> (this.downsample & -85);
			int height = HLBKCLPNHEB.height >> (this.downsample & -111);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 0);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 8 : 0;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 163f;
				this.HKNGEKKGPFK.SetVector("Joystick1Button6", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 881f, 592f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 5 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x002753A5 File Offset: 0x002735A5
		public virtual bool KFDALIFKLHE()
		{
			base.FNIFJAENDIB(true);
			this.HKNGEKKGPFK = base.GJKHKCOAFDB(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x002753DE File Offset: 0x002735DE
		public virtual bool PDNFBCMPHEI()
		{
			base.KNGDKKMDKOG(true);
			this.HKNGEKKGPFK = base.GJKHKCOAFDB(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x00275418 File Offset: 0x00273618
		public void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 75f / (1627f * (float)(0 << (this.downsample & 42)));
			this.HKNGEKKGPFK.SetVector("solo", new Vector4(this.blurSize * num, -this.blurSize * num, 1286f, 1956f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & -64);
			int height = HLBKCLPNHEB.height >> (this.downsample & 46);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 0 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1228f;
				this.HKNGEKKGPFK.SetVector("</b>", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 787f, 1414f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x002755B4 File Offset: 0x002737B4
		public void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 16f / (1425f * (float)(1 << (this.downsample & -70)));
			this.HKNGEKKGPFK.SetVector("MapEnd", new Vector4(this.blurSize * num, -this.blurSize * num, 1584f, 1768f));
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			int width = HLBKCLPNHEB.width >> (this.downsample & 47);
			int height = HLBKCLPNHEB.height >> (this.downsample & -73);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 8 : 1;
			for (int i = 1; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 680f;
				this.HKNGEKKGPFK.SetVector("bad", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1207f, 899f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 4 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x002746D6 File Offset: 0x002728D6
		public void ODAIMOJLJOF()
		{
			if (this.HKNGEKKGPFK)
			{
				UnityEngine.Object.DestroyImmediate(this.HKNGEKKGPFK);
			}
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x00275750 File Offset: 0x00273950
		public void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 977f / (1364f * (float)(0 << (this.downsample & 77)));
			this.HKNGEKKGPFK.SetVector("_FixDistance", new Vector4(this.blurSize * num, -this.blurSize * num, 1505f, 208f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & -69);
			int height = HLBKCLPNHEB.height >> (this.downsample & 34);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 0);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 8 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 639f;
				this.HKNGEKKGPFK.SetVector("SubBass", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1781f, 1801f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x002758E9 File Offset: 0x00273AE9
		public virtual bool OOBHPBJOKMD()
		{
			base.LMEBEGFJGEM(true);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x00275922 File Offset: 0x00273B22
		public virtual bool EAOFDBCPJDI()
		{
			base.JOMCJOEOLHP(false);
			this.HKNGEKKGPFK = base.EDFIBHNHAAB(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x0027595C File Offset: 0x00273B5C
		public void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1460f / (1472f * (float)(0 << (this.downsample & -128)));
			this.HKNGEKKGPFK.SetVector("UndoButton", new Vector4(this.blurSize * num, -this.blurSize * num, 676f, 943f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & 99);
			int height = HLBKCLPNHEB.height >> (this.downsample & 77);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 5 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 763f;
				this.HKNGEKKGPFK.SetVector("<b>#", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1459f, 137f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x00275AF8 File Offset: 0x00273CF8
		public void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1296f / (1795f * (float)(1 << (this.downsample & 68)));
			this.HKNGEKKGPFK.SetVector("_Green_G", new Vector4(this.blurSize * num, -this.blurSize * num, 1654f, 1417f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> (this.downsample & 5);
			int height = HLBKCLPNHEB.height >> (this.downsample & -6);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 1);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 2 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 593f;
				this.HKNGEKKGPFK.SetVector("CameraFilterPack/Blend2Camera_Multiply", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1319f, 437f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x002746D6 File Offset: 0x002728D6
		public void OnDisable()
		{
			if (this.HKNGEKKGPFK)
			{
				UnityEngine.Object.DestroyImmediate(this.HKNGEKKGPFK);
			}
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x00275C94 File Offset: 0x00273E94
		public void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			float num = 1f / (1f * (float)(1 << this.downsample));
			this.HKNGEKKGPFK.SetVector("_Parameter", new Vector4(this.blurSize * num, -this.blurSize * num, 0f, 0f));
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			int width = HLBKCLPNHEB.width >> this.downsample;
			int height = HLBKCLPNHEB.height >> this.downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HKNGEKKGPFK, 0);
			int num2 = (this.blurType != BlurOptimized.BlurType.StandardGauss) ? 2 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				this.HKNGEKKGPFK.SetVector("_Parameter", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.HKNGEKKGPFK, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x002746D6 File Offset: 0x002728D6
		public void NAOLAJPDGIC()
		{
			if (this.HKNGEKKGPFK)
			{
				UnityEngine.Object.DestroyImmediate(this.HKNGEKKGPFK);
			}
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x00275E2D File Offset: 0x0027402D
		public virtual bool KLLLLEOIGHG()
		{
			base.CKIAMHAKJOK(false);
			this.HKNGEKKGPFK = base.NODBMINMALP(this.blurShader, this.HKNGEKKGPFK);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000D3B RID: 3387
		[Range(0f, 2f)]
		public int downsample = 1;

		// Token: 0x04000D3C RID: 3388
		[Range(0f, 10f)]
		public float blurSize = 3f;

		// Token: 0x04000D3D RID: 3389
		[Range(1f, 4f)]
		public int blurIterations = 2;

		// Token: 0x04000D3E RID: 3390
		public BlurOptimized.BlurType blurType;

		// Token: 0x04000D3F RID: 3391
		public Shader blurShader;

		// Token: 0x04000D40 RID: 3392
		private Material HKNGEKKGPFK;

		// Token: 0x020001D0 RID: 464
		public enum BlurType
		{
			// Token: 0x04000D42 RID: 3394
			StandardGauss,
			// Token: 0x04000D43 RID: 3395
			SgxGauss
		}
	}
}
