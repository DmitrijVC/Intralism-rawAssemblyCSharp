using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001C0 RID: 448
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Bloom : PostEffectsBase
	{
		// Token: 0x06007943 RID: 31043 RVA: 0x0025B1AB File Offset: 0x002593AB
		private void IKIPBCDOFDE(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("_ScreenResolution", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 74);
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x0025B1D3 File Offset: 0x002593D3
		private void GLMOGNMIOCC(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("_ScreenResolution", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, -64);
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x0025B1FB File Offset: 0x002593FB
		private void IFGAFBCGIDD(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("IconImage", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x0025B224 File Offset: 0x00259424
		public void JCCIHFMBFJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB32 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Default;
			int width = HLBKCLPNHEB.width / 7;
			int height = HLBKCLPNHEB.height / 0;
			int width2 = HLBKCLPNHEB.width / 1;
			int height2 = HLBKCLPNHEB.height / 5;
			float num = 1716f * (float)HLBKCLPNHEB.width / (1341f * (float)HLBKCLPNHEB.height);
			float num2 = 1057f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format);
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 4);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 0);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 7);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 5);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 1, format);
			this.OGOAECPANPO(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			else if (this.bloomBlurIterations > -58)
			{
				this.bloomBlurIterations = 45;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (5f + (float)i * 1563f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", new Vector4(1582f, num3 * num2, 566f, 1390f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("_Parameter", new Vector4(num3 / num * num2, 1330f, 338f, 1649f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, -44);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 6);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 1, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.KDIICFMMHND(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.High)
					{
						this.FNHKJFBHLJN.SetVector("Connected to masterserver.", new Vector4(753f, 1220f / (1352f * (float)temporary.height), 1844f, 286f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
						this.FNHKJFBHLJN.SetVector("_ScreenResolution", new Vector4(1765f / (791f * (float)temporary.width), 365f, 519f, 786f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 2);
					}
					this.HDOHGDKKMJI(938f, temporary5, temporary5);
					this.CANJPOCKFCN(temporary5, renderTexture);
				}
				else
				{
					float num4 = 354f * Mathf.Cos(this.flareRotation);
					float num5 = 1519f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 586f / num * num2;
					this.FNHKJFBHLJN.SetVector("_ScreenResolution", new Vector4(num4, num5, 1692f, 379f));
					this.FNHKJFBHLJN.SetVector("BitsData", new Vector4(this.lensflareThreshold, 1818f, 1201f, 1510f));
					this.FNHKJFBHLJN.SetVector("_TimeX", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("Tab2Content", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 2);
					this.FNHKJFBHLJN.SetVector("_VelocityScale", new Vector4(num4 * num6, num5 * num6, 1816f, 1775f));
					this.FNHKJFBHLJN.SetFloat("BestRegion checks region: ", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("/files/mods_terms.pdf", this.hollyStretchWidth * 1005f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("IconFileSelector", this.hollyStretchWidth * 711f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 1968f / num * num2;
						this.FNHKJFBHLJN.SetVector("No font defined. Found font: ", new Vector4(num6 * num4, num6 * num5, 966f, 1036f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 4);
						this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 1518f, 1934f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 3);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
					{
						this.HONPHAEOIIL(88f, temporary, renderTexture);
					}
					else
					{
						this.NHICIDDKCPF(480f, temporary, temporary5);
						this.CMNJFBHPONJ(temporary5, temporary);
						this.GDJGNPBFLKD(1536f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("_Value10", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("?", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.High)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 1, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x0025B9C8 File Offset: 0x00259BC8
		private void BNCBCDHDBKL(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("Server: {0}. Region: {1} ", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 5 : 7);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x0025BA60 File Offset: 0x00259C60
		private void IKNIHJMIHCH(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("[MenuScene] Error: ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("ItemNameBGImage", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("menutheme.idunno", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("ItemsStoreButton", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x0025BBB0 File Offset: 0x00259DB0
		private void CANJPOCKFCN(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("move", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("ClearEnvironment", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("menuVolume", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x0025BD00 File Offset: 0x00259F00
		public virtual bool PHJJGBHNECJ()
		{
			base.IBFDMKMOBCA(false);
			this.KNABIALPPBB = base.NODBMINMALP(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.ECNEGNMAMDE(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.ECNEGNMAMDE(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.LKIJNGDHLAK(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x0025BD8C File Offset: 0x00259F8C
		private void MGPABGDAEMM(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_Bloom5", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x0025BDB2 File Offset: 0x00259FB2
		private void OKMDBFFGGPG(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("/?player=", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x0025BDDB File Offset: 0x00259FDB
		private void NIMNDOKPCDC(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("JoinRandom failed: {0}.", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x0025BE04 File Offset: 0x0025A004
		public void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB32 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.ARGB1555;
			int width = HLBKCLPNHEB.width / 2;
			int height = HLBKCLPNHEB.height / 7;
			int width2 = HLBKCLPNHEB.width / 6;
			int height2 = HLBKCLPNHEB.height / 1;
			float num = 734f * (float)HLBKCLPNHEB.width / (1843f * (float)HLBKCLPNHEB.height);
			float num2 = 1097f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 1);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 1, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 0);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 8);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 0);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			this.EKOEOEJODMM(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			else if (this.bloomBlurIterations > 84)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1115f + (float)i * 1365f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("_Jitter", new Vector4(366f, num3 * num2, 1771f, 19f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("config.txt", new Vector4(num3 / num * num2, 870f, 1531f, 160f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, false, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, -126);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(true, false, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 5);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 1, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.DMLEDGBNDNI(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.Cheap)
					{
						this.FNHKJFBHLJN.SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4(58f, 1266f / (1968f * (float)temporary.height), 673f, 1906f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 2);
						this.FNHKJFBHLJN.SetVector("checkpoint", new Vector4(35f / (1258f * (float)temporary.width), 297f, 1521f, 1471f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 5);
					}
					this.FEIPEADOAGC(1919f, temporary5, temporary5);
					this.COBDBLMOCHD(temporary5, renderTexture);
				}
				else
				{
					float num4 = 507f * Mathf.Cos(this.flareRotation);
					float num5 = 1491f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 846f / num * num2;
					this.FNHKJFBHLJN.SetVector("_TimeX", new Vector4(num4, num5, 33f, 1389f));
					this.FNHKJFBHLJN.SetVector(" not exist", new Vector4(this.lensflareThreshold, 1855f, 1692f, 330f));
					this.FNHKJFBHLJN.SetVector("SetSatelliteRotationSpeed", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("InfoCanvas", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 7);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 4);
					this.FNHKJFBHLJN.SetVector("ok", new Vector4(num4 * num6, num5 * num6, 331f, 513f));
					this.FNHKJFBHLJN.SetFloat("StartButton", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("_Red_C", this.hollyStretchWidth * 840f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("_TimeX", this.hollyStretchWidth * 241f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					for (int j = 1; j < this.hollywoodFlareBlurIterations; j += 0)
					{
						num6 = this.hollyStretchWidth * 1524f / num * num2;
						this.FNHKJFBHLJN.SetVector("<color=#{0}>{1}</color>", new Vector4(num6 * num4, num6 * num5, 1985f, 951f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 7);
						this.FNHKJFBHLJN.SetVector("SpeedSlider", new Vector4(num6 * num4, num6 * num5, 452f, 917f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Anamorphic)
					{
						this.ACOLGGKAHIL(976f, temporary, renderTexture);
					}
					else
					{
						this.IJFBACJAHAG(156f, temporary, temporary5);
						this.EJEHAFHHLHN(temporary5, temporary);
						this.PFCJCDJBGNH(1637f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("_ScreenResolution", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_ScreenResolution", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.High)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 1, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x0025C5A5 File Offset: 0x0025A7A5
		private void BGOAEMICENB(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("HPToggle", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, -128);
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x0025C5CD File Offset: 0x0025A7CD
		private void OGOAECPANPO(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("SetCrosshairEmission", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x0025C5F3 File Offset: 0x0025A7F3
		private void FCJAOINLBFK(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_Threshhold", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x0025C619 File Offset: 0x0025A819
		private void FAEEDGIIJDI(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_TimeX", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x0025C63F File Offset: 0x0025A83F
		private void FCGICEJGMBF(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("_Blue_C", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, -29);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x0025C668 File Offset: 0x0025A868
		public virtual bool GMFKDOKAOPO()
		{
			base.FNIFJAENDIB(true);
			this.KNABIALPPBB = base.AJKPGPKKHHB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.ECNEGNMAMDE(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.EDFIBHNHAAB(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.AJKPGPKKHHB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x0025C6F4 File Offset: 0x0025A8F4
		public virtual bool BCDIEBGNBEG()
		{
			base.JOMCJOEOLHP(true);
			this.KNABIALPPBB = base.GJKHKCOAFDB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.KDHKHOHMKCG(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.GJKHKCOAFDB(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.AJKPGPKKHHB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x0025C780 File Offset: 0x0025A980
		private void KAFNIFGHIAI(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("achievements.21.progress", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x0025C7A6 File Offset: 0x0025A9A6
		private void HONPHAEOIIL(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("[LocalizationService] Loading file: ", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, -86);
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x0025C7D0 File Offset: 0x0025A9D0
		private void HDOHGDKKMJI(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("mapselector.tags.", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 1 : 5);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(true, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x0025C868 File Offset: 0x0025AA68
		public void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB32 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.RGB565 : RenderTextureFormat.Default;
			int width = HLBKCLPNHEB.width / 3;
			int height = HLBKCLPNHEB.height / 2;
			int width2 = HLBKCLPNHEB.width / 4;
			int height2 = HLBKCLPNHEB.height / 3;
			float num = 1244f * (float)HLBKCLPNHEB.width / (1917f * (float)HLBKCLPNHEB.height);
			float num2 = 403f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 1);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 7);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 4);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 7);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 1, format);
			this.DJLNAAEPDLJ(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			else if (this.bloomBlurIterations > -52)
			{
				this.bloomBlurIterations = -24;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1356f + (float)i * 1943f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("_Value4", new Vector4(1185f, num3 * num2, 1930f, 1796f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("/", new Vector4(num3 / num * num2, 1234f, 395f, 909f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, false, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, -119);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(true, false, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 5);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 1, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.BJBNKAIBCNJ(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.Cheap)
					{
						this.FNHKJFBHLJN.SetVector("<color=#{0}>{1}</color>", new Vector4(1362f, 1625f / (1357f * (float)temporary.height), 1416f, 1692f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 4);
						this.FNHKJFBHLJN.SetVector("player.goldwatermelon", new Vector4(67f / (150f * (float)temporary.width), 1348f, 1741f, 1844f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 7);
					}
					this.HDOHGDKKMJI(125f, temporary5, temporary5);
					this.JOFOMMDPHPA(temporary5, renderTexture);
				}
				else
				{
					float num4 = 599f * Mathf.Cos(this.flareRotation);
					float num5 = 1430f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 458f / num * num2;
					this.FNHKJFBHLJN.SetVector("Object ID. Case-Sensitive", new Vector4(num4, num5, 1392f, 434f));
					this.FNHKJFBHLJN.SetVector("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", new Vector4(this.lensflareThreshold, 1133f, 1242f, 1396f));
					this.FNHKJFBHLJN.SetVector("_Value2", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("CameraMovementSlider", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 7);
					this.FNHKJFBHLJN.SetVector(" GameServer:", new Vector4(num4 * num6, num5 * num6, 1118f, 1779f));
					this.FNHKJFBHLJN.SetFloat("_ScreenResolution", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("CameraFilterPack_Glasses_On7", this.hollyStretchWidth * 1945f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("Image effects aren't supported on this device ({0})", this.hollyStretchWidth * 784f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
					{
						num6 = this.hollyStretchWidth * 1614f / num * num2;
						this.FNHKJFBHLJN.SetVector("team", new Vector4(num6 * num4, num6 * num5, 679f, 1493f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 6);
						this.FNHKJFBHLJN.SetVector("Joystick1Button0", new Vector4(num6 * num4, num6 * num5, 1426f, 1824f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 4);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Anamorphic)
					{
						this.FCGICEJGMBF(1718f, temporary, renderTexture);
					}
					else
					{
						this.NHICIDDKCPF(547f, temporary, temporary5);
						this.JOFOMMDPHPA(temporary5, temporary);
						this.GDJGNPBFLKD(239f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("SpeedSlider", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("[PlayerBase] SpawnObj error: ", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.High)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x0025D00C File Offset: 0x0025B20C
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.KNABIALPPBB = base.EDFIBHNHAAB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.EDFIBHNHAAB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.EDFIBHNHAAB(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.EDFIBHNHAAB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x0025D098 File Offset: 0x0025B298
		public virtual bool FKHOCKAEMLD()
		{
			base.KNGDKKMDKOG(false);
			this.KNABIALPPBB = base.KDHKHOHMKCG(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.NODBMINMALP(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.AJKPGPKKHHB(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.GJKHKCOAFDB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x0025D124 File Offset: 0x0025B324
		private void CMNJFBHPONJ(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("colorA", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("colorB", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("colorC", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("colorD", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x0025D274 File Offset: 0x0025B474
		private void BDGHILJAJNI(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector(" (", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x0025D2A0 File Offset: 0x0025B4A0
		private void COBDBLMOCHD(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("[EMPTY]", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("<b>#", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_MainTex2", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("duration", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x0025D3F0 File Offset: 0x0025B5F0
		private void NHICIDDKCPF(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("OK", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 1 : 6);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x0025D485 File Offset: 0x0025B685
		private void NMAGGBICDOI(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector(".workshop.json", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x0025D4AB File Offset: 0x0025B6AB
		private void BLKDINEBKJC(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("_Value4", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 81);
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x0025D4D3 File Offset: 0x0025B6D3
		private void MIHOFBDIFGL(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("_Intensity", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 9);
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x0025D4FC File Offset: 0x0025B6FC
		public void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGBHalf && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf;
			int width = HLBKCLPNHEB.width / 2;
			int height = HLBKCLPNHEB.height / 2;
			int width2 = HLBKCLPNHEB.width / 4;
			int height2 = HLBKCLPNHEB.height / 4;
			float num = 1f * (float)HLBKCLPNHEB.width / (1f * (float)HLBKCLPNHEB.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 2);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			this.FCJAOINLBFK(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			else if (this.bloomBlurIterations > 10)
			{
				this.bloomBlurIterations = 10;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, 10);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 6);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.FCJAOINLBFK(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.Cheap)
					{
						this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 4);
						this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 4);
					}
					this.IJFBACJAHAG(0.975f, temporary5, temporary5);
					this.CMNJFBHPONJ(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(this.flareRotation);
					float num5 = 1f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 1f / num * num2;
					this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					this.FNHKJFBHLJN.SetVector("_Threshhold", new Vector4(this.lensflareThreshold, 1f, 0f, 0f));
					this.FNHKJFBHLJN.SetVector("_TintColor", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("_Saturation", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 3);
					this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					this.FNHKJFBHLJN.SetFloat("_StretchWidth", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("_StretchWidth", this.hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("_StretchWidth", this.hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 2f / num * num2;
						this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 4);
						this.FNHKJFBHLJN.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 4);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Anamorphic)
					{
						this.MIHOFBDIFGL(1f, temporary, renderTexture);
					}
					else
					{
						this.IJFBACJAHAG(1f, temporary, temporary5);
						this.CMNJFBHPONJ(temporary5, temporary);
						this.MIHOFBDIFGL(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("_Intensity", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_ColorBuffer", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x0025DC9D File Offset: 0x0025BE9D
		private void PFCJCDJBGNH(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("EventTimeInputField", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 102);
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x0025DCC5 File Offset: 0x0025BEC5
		private void PFCKMFEKBNC(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_ScreenResolution", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x0025DCEC File Offset: 0x0025BEEC
		public virtual bool HDDNBPJGGFK()
		{
			base.LMEBEGFJGEM(false);
			this.KNABIALPPBB = base.KDHKHOHMKCG(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.GJKHKCOAFDB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.LKIJNGDHLAK(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.LKIJNGDHLAK(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x0025DD78 File Offset: 0x0025BF78
		public virtual bool KJAAENHDHHC()
		{
			base.CKIAMHAKJOK(false);
			this.KNABIALPPBB = base.AJKPGPKKHHB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.ECNEGNMAMDE(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.LKIJNGDHLAK(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.KDHKHOHMKCG(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x0025DF04 File Offset: 0x0025C104
		private void EJEHAFHHLHN(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("warning: Audio Source: ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Red_G", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("STICKRVER", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x0025E054 File Offset: 0x0025C254
		private void EEOJDGFAFMP(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("CloseConnection: Only the masterclient can kick another player.", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x0025E07C File Offset: 0x0025C27C
		private void HGADBLFHONK(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("ConfigVersionSlider", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 1 : 4);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(true, true, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x0025E114 File Offset: 0x0025C314
		public virtual bool AMKCNLBKLDJ()
		{
			base.KHNPMDDIJAJ(false);
			this.KNABIALPPBB = base.EDFIBHNHAAB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.EDFIBHNHAAB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.KDHKHOHMKCG(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.KDHKHOHMKCG(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x0025E1A0 File Offset: 0x0025C3A0
		public virtual bool LPDMNDMCPCO()
		{
			base.FNIFJAENDIB(true);
			this.KNABIALPPBB = base.LKIJNGDHLAK(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.KDHKHOHMKCG(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.ECNEGNMAMDE(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.KDHKHOHMKCG(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x0025E22C File Offset: 0x0025C42C
		private void OIHPPBBLNIP(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("ShineEffect", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x0025E252 File Offset: 0x0025C452
		private void DANFECMPLAH(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_Visualize", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x0025E27C File Offset: 0x0025C47C
		private void GEBICJFPFFA(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_Value7", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 2 : 6);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x0025E314 File Offset: 0x0025C514
		private void LHPHOONCELG(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("SetSunMinSize", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("id", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("[LevelEditorScene] Item creation successful! Published Item ID: ", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Fade", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x0025E464 File Offset: 0x0025C664
		private void BJDFCKODPOJ(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("set id", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Size", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Joystick1Button4", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x0025E5B4 File Offset: 0x0025C7B4
		private void FHCEIGKEKPP(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("CameraFilterPack/AAA_WaterDropPro", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x0025E5E0 File Offset: 0x0025C7E0
		private void IJFBACJAHAG(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_ColorBuffer", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 3 : 7);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x0025E678 File Offset: 0x0025C878
		private void JOFOMMDPHPA(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("MessageText", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("SetSpeed", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Horizontal", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x0025E7C8 File Offset: 0x0025C9C8
		private void MNGMIEHEJMI(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("Hidden/ScreenSpaceReflection", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, -44);
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x0025E7F0 File Offset: 0x0025C9F0
		private void GDJGNPBFLKD(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("_Value1", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 8);
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x0025E818 File Offset: 0x0025CA18
		public virtual bool MPMLKLHMPJH()
		{
			base.IHMNPAHGNFF(false);
			this.KNABIALPPBB = base.GJKHKCOAFDB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.AJKPGPKKHHB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.ECNEGNMAMDE(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.ECNEGNMAMDE(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x0025E8A4 File Offset: 0x0025CAA4
		public void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.Default && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.RGB565 : RenderTextureFormat.Shadowmap;
			int width = HLBKCLPNHEB.width / 6;
			int height = HLBKCLPNHEB.height / 5;
			int width2 = HLBKCLPNHEB.width / 4;
			int height2 = HLBKCLPNHEB.height / 5;
			float num = 1501f * (float)HLBKCLPNHEB.width / (1001f * (float)HLBKCLPNHEB.height);
			float num2 = 858f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 0);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 8);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 5);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 4);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 1, format);
			this.EKOEOEJODMM(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			else if (this.bloomBlurIterations > 8)
			{
				this.bloomBlurIterations = 31;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1445f + (float)i * 847f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("_Greenness", new Vector4(390f, num3 * num2, 265f, 1084f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("PLEASE WAIT", new Vector4(num3 / num * num2, 48f, 47f, 658f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, 127);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(true, true, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 1);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.ILLACACMNCB(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.High)
					{
						this.FNHKJFBHLJN.SetVector("Editor/", new Vector4(1502f, 1162f / (1982f * (float)temporary.height), 1802f, 1702f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 5);
						this.FNHKJFBHLJN.SetVector("id", new Vector4(1257f / (269f * (float)temporary.width), 1635f, 345f, 1214f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 3);
					}
					this.GEBICJFPFFA(724f, temporary5, temporary5);
					this.OJDHGAGDJAN(temporary5, renderTexture);
				}
				else
				{
					float num4 = 340f * Mathf.Cos(this.flareRotation);
					float num5 = 736f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 1583f / num * num2;
					this.FNHKJFBHLJN.SetVector("_Value5", new Vector4(num4, num5, 1559f, 1629f));
					this.FNHKJFBHLJN.SetVector("CameraFilterPack/FX_Plasma", new Vector4(this.lensflareThreshold, 884f, 1086f, 1441f));
					this.FNHKJFBHLJN.SetVector("_Value", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("visible", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 6);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 3);
					this.FNHKJFBHLJN.SetVector("ChatInput", new Vector4(num4 * num6, num5 * num6, 1132f, 1996f));
					this.FNHKJFBHLJN.SetFloat("No Name", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("_Value4", this.hollyStretchWidth * 829f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("[PlayerBase] SetBGColor error: ", this.hollyStretchWidth * 1933f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
					{
						num6 = this.hollyStretchWidth * 203f / num * num2;
						this.FNHKJFBHLJN.SetVector("<color=#", new Vector4(num6 * num4, num6 * num5, 435f, 296f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 5);
						this.FNHKJFBHLJN.SetVector("{0}_{1}", new Vector4(num6 * num4, num6 * num5, 337f, 849f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 2);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
					{
						this.GDJGNPBFLKD(735f, temporary, renderTexture);
					}
					else
					{
						this.FEIPEADOAGC(123f, temporary, temporary5);
						this.LHPHOONCELG(temporary5, temporary);
						this.GLMOGNMIOCC(850f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("CheckpointsScoreText", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("CameraFilterPack/Distortion_Flush", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.High)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 1, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x0025F048 File Offset: 0x0025D248
		private void JOIEPNDEEIB(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("Set particles gravity", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 7 : 8);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x0025F0DD File Offset: 0x0025D2DD
		private void IBAKDPIILHM(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("pointBuffer", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x0025F106 File Offset: 0x0025D306
		private void ACOLGGKAHIL(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("_Red_R", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 59);
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x0025F130 File Offset: 0x0025D330
		private void JBPGDFNKPPE(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector(" not found", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_MainTex2", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("CameraFilterPack/TV_VHS_Rewind", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_DistAmount", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x0025F280 File Offset: 0x0025D480
		public override bool ILMGHBFANON()
		{
			base.LMEBEGFJGEM(true);
			this.KNABIALPPBB = base.KDHKHOHMKCG(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.LKIJNGDHLAK(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.NODBMINMALP(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.EDFIBHNHAAB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x0025F30C File Offset: 0x0025D50C
		private void MPLAHMHKLNI(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_MainTex2", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 4 : 8);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x0025F3A4 File Offset: 0x0025D5A4
		private void FFJFPIEALED(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("<not connected>", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("seconds", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Zoom speed. Base 1.5", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_LutTex", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x0025F4F4 File Offset: 0x0025D6F4
		private void FEIPEADOAGC(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture(". The RPC has been ignored.", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 7 : 3);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(true, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x0025F589 File Offset: 0x0025D789
		private void CCBHLMIDDBG(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("custom", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 57);
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x0025F5B1 File Offset: 0x0025D7B1
		private void KDIICFMMHND(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("player.xp", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x0025F5DC File Offset: 0x0025D7DC
		private void NBHIDGCGEKK(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("float,0", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_TimeX", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Amount", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Saturation", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x0025F72C File Offset: 0x0025D92C
		private void PCFBANNAGKB(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_PositionX", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x0025F758 File Offset: 0x0025D958
		public virtual bool HPEEHNKLIJD()
		{
			base.NPOEJIDLJGK(true);
			this.KNABIALPPBB = base.AJKPGPKKHHB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.LKIJNGDHLAK(this.lensFlareShader, this.LFEBKHIPEIN);
			this.FNHKJFBHLJN = base.LKIJNGDHLAK(this.blurAndFlaresShader, this.FNHKJFBHLJN);
			this.FGAHKAOHPFA = base.GJKHKCOAFDB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x0025F7E4 File Offset: 0x0025D9E4
		private void PNBNNEPEOMA(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("menu.selectedmode", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x0025F80D File Offset: 0x0025DA0D
		private void FCJAOINLBFK(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_Threshhold", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x0025F838 File Offset: 0x0025DA38
		private void PJJDEBAAJPI(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("LoadPlayerSkin", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 4 : 4);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x0025F8CD File Offset: 0x0025DACD
		private void FKFKBMEBMBH(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_AdaptationSpeed", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x0025F8F4 File Offset: 0x0025DAF4
		public void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGBHalf || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default;
			int width = HLBKCLPNHEB.width / 0;
			int height = HLBKCLPNHEB.height / 7;
			int width2 = HLBKCLPNHEB.width / 1;
			int height2 = HLBKCLPNHEB.height / 0;
			float num = 353f * (float)HLBKCLPNHEB.width / (161f * (float)HLBKCLPNHEB.height);
			float num2 = 1065f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 4);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 4);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 3);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 7);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 1, format);
			this.PFCKMFEKBNC(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			else if (this.bloomBlurIterations > -74)
			{
				this.bloomBlurIterations = -120;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1765f + (float)i * 342f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("_Green_B", new Vector4(477f, num3 * num2, 1222f, 1220f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("_DistortionLevel", new Vector4(num3 / num * num2, 593f, 838f, 1339f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, -69);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(true, true, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 2);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.DANFECMPLAH(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.High)
					{
						this.FNHKJFBHLJN.SetVector("_ScreenResolution", new Vector4(521f, 128f / (524f * (float)temporary.height), 537f, 1949f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 2);
						this.FNHKJFBHLJN.SetVector("return CheckCondition()", new Vector4(923f / (1074f * (float)temporary.width), 549f, 751f, 911f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 6);
					}
					this.PJJDEBAAJPI(945f, temporary5, temporary5);
					this.MBEPCAIPOBN(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1010f * Mathf.Cos(this.flareRotation);
					float num5 = 487f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 409f / num * num2;
					this.FNHKJFBHLJN.SetVector("CameraFilterPack/Glasses_On", new Vector4(num4, num5, 310f, 944f));
					this.FNHKJFBHLJN.SetVector("_DiffuseColor", new Vector4(this.lensflareThreshold, 1909f, 1899f, 1527f));
					this.FNHKJFBHLJN.SetVector("#turnoninternet", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("_Value8", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 6);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 2);
					this.FNHKJFBHLJN.SetVector("ERROR You have missing MonoBehaviours on your gameobjects!", new Vector4(num4 * num6, num5 * num6, 1554f, 148f));
					this.FNHKJFBHLJN.SetFloat("#", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("caret", this.hollyStretchWidth * 1082f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("player.mysteryitem", this.hollyStretchWidth * 394f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 840f / num * num2;
						this.FNHKJFBHLJN.SetVector("MultiplayerButton", new Vector4(num6 * num4, num6 * num5, 157f, 199f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 8);
						this.FNHKJFBHLJN.SetVector("_DistortionSize", new Vector4(num6 * num4, num6 * num5, 1681f, 1042f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
					{
						this.MNGMIEHEJMI(1875f, temporary, renderTexture);
					}
					else
					{
						this.NHICIDDKCPF(1167f, temporary, temporary5);
						this.LKJMMPGGGEG(temporary5, temporary);
						this.CCBHLMIDDBG(969f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("Fade", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("IntraTime", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.High)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x00260095 File Offset: 0x0025E295
		private void DJLNAAEPDLJ(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("null", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x002600BC File Offset: 0x0025E2BC
		private void IBILIPOJDHH(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture(".status", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 6 : 7);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(true, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x00260151 File Offset: 0x0025E351
		private void CAPGEDCFJCB(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("stats on", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x00260177 File Offset: 0x0025E377
		private void LHNAGIHONFC(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.KNABIALPPBB.SetFloat("Prints list of commands", BHEKCBODHNH);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, -67);
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x002601A0 File Offset: 0x0025E3A0
		public void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB2101010 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.Shadowmap;
			int width = HLBKCLPNHEB.width / 7;
			int height = HLBKCLPNHEB.height / 0;
			int width2 = HLBKCLPNHEB.width / 0;
			int height2 = HLBKCLPNHEB.height / 3;
			float num = 1037f * (float)HLBKCLPNHEB.width / (873f * (float)HLBKCLPNHEB.height);
			float num2 = 920f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 6);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 1, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 5);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 5);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 2);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 1, format);
			this.PFCKMFEKBNC(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			else if (this.bloomBlurIterations > -18)
			{
				this.bloomBlurIterations = 39;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1694f + (float)i * 53f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("_Value4", new Vector4(1179f, num3 * num2, 229f, 612f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("_TimeX", new Vector4(num3 / num * num2, 1995f, 394f, 1346f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, false, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, 125);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 4);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.NIMNDOKPCDC(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.High)
					{
						this.FNHKJFBHLJN.SetVector("CameraFilterPack/Distortion_Heat", new Vector4(9f, 1575f / (1729f * (float)temporary.height), 1639f, 30f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 7);
						this.FNHKJFBHLJN.SetVector("menu.playedsolo", new Vector4(1673f / (754f * (float)temporary.width), 1015f, 843f, 1944f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(false, false, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 5);
					}
					this.NHICIDDKCPF(1956f, temporary5, temporary5);
					this.EJEHAFHHLHN(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1074f * Mathf.Cos(this.flareRotation);
					float num5 = 1900f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 180f / num * num2;
					this.FNHKJFBHLJN.SetVector("_Value5", new Vector4(num4, num5, 815f, 1070f));
					this.FNHKJFBHLJN.SetVector("X2", new Vector4(this.lensflareThreshold, 1827f, 1130f, 1665f));
					this.FNHKJFBHLJN.SetVector("_ChangeGreen", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("_MainTex2", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 6);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 7);
					this.FNHKJFBHLJN.SetVector("CameraFilterPack/Retro_Loading", new Vector4(num4 * num6, num5 * num6, 1505f, 1475f));
					this.FNHKJFBHLJN.SetFloat("In Map Editor", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("_Value2", this.hollyStretchWidth * 1461f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat(",", this.hollyStretchWidth * 1390f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 748f / num * num2;
						this.FNHKJFBHLJN.SetVector("[LevelEditorScene] Error: Timeout :S", new Vector4(num6 * num4, num6 * num5, 1166f, 249f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 2);
						this.FNHKJFBHLJN.SetVector("Xbox Home", new Vector4(num6 * num4, num6 * num5, 903f, 1321f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 2);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
					{
						this.MNGMIEHEJMI(231f, temporary, renderTexture);
					}
					else
					{
						this.FEIPEADOAGC(1092f, temporary, temporary5);
						this.AFFNODAHBEI(temporary5, temporary);
						this.BGOAEMICENB(223f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("_Value3", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_Green_B", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x00260944 File Offset: 0x0025EB44
		public void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGBHalf && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB32;
			int width = HLBKCLPNHEB.width / 2;
			int height = HLBKCLPNHEB.height / 4;
			int width2 = HLBKCLPNHEB.width / 2;
			int height2 = HLBKCLPNHEB.height / 0;
			float num = 412f * (float)HLBKCLPNHEB.width / (641f * (float)HLBKCLPNHEB.height);
			float num2 = 1677f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 6);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 1, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 5);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 0);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 2);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 1, format);
			this.FAEEDGIIJDI(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			else if (this.bloomBlurIterations > -97)
			{
				this.bloomBlurIterations = 114;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1329f + (float)i * 814f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("Electronic", new Vector4(60f, num3 * num2, 1243f, 1077f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("SetSunMinSize", new Vector4(num3 / num * num2, 1041f, 129f, 767f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, -115);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 0);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.DMLEDGBNDNI(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.High)
					{
						this.FNHKJFBHLJN.SetVector("[MapEditor] Item creation successful! Published Item ID: ", new Vector4(1842f, 1316f / (361f * (float)temporary.height), 30f, 1949f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 8);
						this.FNHKJFBHLJN.SetVector("return ", new Vector4(884f / (1732f * (float)temporary.width), 841f, 471f, 1419f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(false, false, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 6);
					}
					this.IJFBACJAHAG(1611f, temporary5, temporary5);
					this.BJDFCKODPOJ(temporary5, renderTexture);
				}
				else
				{
					float num4 = 923f * Mathf.Cos(this.flareRotation);
					float num5 = 1977f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 980f / num * num2;
					this.FNHKJFBHLJN.SetVector("SettingsCanvas", new Vector4(num4, num5, 1061f, 1567f));
					this.FNHKJFBHLJN.SetVector("_TimeX", new Vector4(this.lensflareThreshold, 1122f, 1880f, 1862f));
					this.FNHKJFBHLJN.SetVector("_TimeX", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("Blues", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 4);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 4);
					this.FNHKJFBHLJN.SetVector("BitsData", new Vector4(num4 * num6, num5 * num6, 1175f, 1510f));
					this.FNHKJFBHLJN.SetFloat("_TimeX", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("ENABLE_USER_LUT", this.hollyStretchWidth * 314f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("_OcclusionBlurTexture", this.hollyStretchWidth * 1156f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					for (int j = 1; j < this.hollywoodFlareBlurIterations; j += 0)
					{
						num6 = this.hollyStretchWidth * 241f / num * num2;
						this.FNHKJFBHLJN.SetVector("_History3LumaTex", new Vector4(num6 * num4, num6 * num5, 1041f, 1796f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 6);
						this.FNHKJFBHLJN.SetVector("float,0", new Vector4(num6 * num4, num6 * num5, 1383f, 305f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 7);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
					{
						this.ACOLGGKAHIL(812f, temporary, renderTexture);
					}
					else
					{
						this.FEIPEADOAGC(1474f, temporary, temporary5);
						this.OJDHGAGDJAN(temporary5, temporary);
						this.CCBHLMIDDBG(1186f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("_TimeX", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("In Main Menu", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x002610E8 File Offset: 0x0025F2E8
		public void KFGGHDFLDIP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGBHalf || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Depth;
			int width = HLBKCLPNHEB.width / 3;
			int height = HLBKCLPNHEB.height / 6;
			int width2 = HLBKCLPNHEB.width / 5;
			int height2 = HLBKCLPNHEB.height / 7;
			float num = 978f * (float)HLBKCLPNHEB.width / (582f * (float)HLBKCLPNHEB.height);
			float num2 = 1318f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 7);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 1, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 5);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 3);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 7);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			this.EFAIMBBLACK(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			else if (this.bloomBlurIterations > -12)
			{
				this.bloomBlurIterations = -17;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1674f + (float)i * 154f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("#close", new Vector4(1789f, num3 * num2, 636f, 332f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("[NetworkManager] Joined room with ", new Vector4(num3 / num * num2, 471f, 563f, 1179f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, 1);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 1);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 1, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.NIMNDOKPCDC(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.Cheap)
					{
						this.FNHKJFBHLJN.SetVector("_Value2", new Vector4(1608f, 1219f / (73f * (float)temporary.height), 109f, 1185f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, false, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 4);
						this.FNHKJFBHLJN.SetVector("_Value2", new Vector4(975f / (15f * (float)temporary.width), 913f, 1681f, 481f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 0);
					}
					this.KFOKBANNGIL(850f, temporary5, temporary5);
					this.IKNIHJMIHCH(temporary5, renderTexture);
				}
				else
				{
					float num4 = 789f * Mathf.Cos(this.flareRotation);
					float num5 = 259f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 949f / num * num2;
					this.FNHKJFBHLJN.SetVector("SetSatelliteTrailMinVertexDistance", new Vector4(num4, num5, 956f, 785f));
					this.FNHKJFBHLJN.SetVector("_Tint", new Vector4(this.lensflareThreshold, 1645f, 839f, 762f));
					this.FNHKJFBHLJN.SetVector("_Cible", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("_History3Weight", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 6);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 8);
					this.FNHKJFBHLJN.SetVector("#", new Vector4(num4 * num6, num5 * num6, 814f, 620f));
					this.FNHKJFBHLJN.SetFloat("Set Satellite Trail Width", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("PunSupportLogger", this.hollyStretchWidth * 1747f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("GlassesColor2", this.hollyStretchWidth * 329f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 1152f / num * num2;
						this.FNHKJFBHLJN.SetVector("[MenuScene] Error: ", new Vector4(num6 * num4, num6 * num5, 57f, 1390f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 2);
						this.FNHKJFBHLJN.SetVector(".r", new Vector4(num6 * num4, num6 * num5, 475f, 1513f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 3);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
					{
						this.GDJGNPBFLKD(1829f, temporary, renderTexture);
					}
					else
					{
						this.KFOKBANNGIL(136f, temporary, temporary5);
						this.CMNJFBHPONJ(temporary5, temporary);
						this.IKIPBCDOFDE(1259f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("[ItemsHandler] Loading Steam inventory", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("\\", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 1, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00261889 File Offset: 0x0025FA89
		private void EKOEOEJODMM(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("/", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x002618B0 File Offset: 0x0025FAB0
		private void LKJMMPGGGEG(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("Editor/", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("#ok", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("#ok", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Received OnSerialization for view ID ", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x00261A00 File Offset: 0x0025FC00
		private void BJBNKAIBCNJ(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("MouseY", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 1);
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x00261A2C File Offset: 0x0025FC2C
		private void KFOKBANNGIL(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("win", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 5 : 1);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x00261AC4 File Offset: 0x0025FCC4
		private void AFFNODAHBEI(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("OxOD.lastPath", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("ReconnectAndRejoin() disabled the offline mode. No longer offline.", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Distortion", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Checkpoint", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x00261C14 File Offset: 0x0025FE14
		private void OJDHGAGDJAN(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("_Value2", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("</color>", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("addNewButton", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("PlayButton", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x00261D64 File Offset: 0x0025FF64
		private void MBEPCAIPOBN(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("BackButton", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("/", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_ScreenResolution", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("EventMenu", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			HANEOLNMOEF.MarkRestoreExpected();
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x00261EB4 File Offset: 0x002600B4
		private void IHDPANJJBPC(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("SetParticlesCountPerBeat", this.lensFlareVignetteMask);
				HANEOLNMOEF.MarkRestoreExpected();
				Graphics.Blit((!(BHNGOLDNELC == HANEOLNMOEF)) ? BHNGOLDNELC : null, HANEOLNMOEF, this.KNABIALPPBB, (!(BHNGOLDNELC == HANEOLNMOEF)) ? 4 : 2);
			}
			else if (BHNGOLDNELC != HANEOLNMOEF)
			{
				Graphics.SetRenderTarget(HANEOLNMOEF);
				GL.Clear(true, false, Color.black);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF);
			}
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00261F49 File Offset: 0x00260149
		private void EFAIMBBLACK(Color IGEOLBNECBJ, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("_Val", IGEOLBNECBJ);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00261F70 File Offset: 0x00260170
		public void CKCPPNHANAA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.Shadowmap || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGBHalf;
			int width = HLBKCLPNHEB.width / 4;
			int height = HLBKCLPNHEB.height / 4;
			int width2 = HLBKCLPNHEB.width / 4;
			int height2 = HLBKCLPNHEB.height / 5;
			float num = 1360f * (float)HLBKCLPNHEB.width / (1913f * (float)HLBKCLPNHEB.height);
			float num2 = 1255f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 6);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 2);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 1);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 4);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			this.CAPGEDCFJCB(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			else if (this.bloomBlurIterations > -61)
			{
				this.bloomBlurIterations = 78;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (532f + (float)i * 1976f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("_FarCorner", new Vector4(807f, num3 * num2, 1139f, 395f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("_ScreenResolution", new Vector4(num3 / num * num2, 1810f, 1969f, 194f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, 122);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 0);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.IBAKDPIILHM(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.Cheap)
					{
						this.FNHKJFBHLJN.SetVector("The given 2D texture ", new Vector4(639f, 49f / (673f * (float)temporary.height), 1700f, 142f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, false, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 8);
						this.FNHKJFBHLJN.SetVector("maps.", new Vector4(1005f / (765f * (float)temporary.width), 422f, 983f, 873f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 5);
					}
					this.GEBICJFPFFA(576f, temporary5, temporary5);
					this.LHPHOONCELG(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1460f * Mathf.Cos(this.flareRotation);
					float num5 = 1841f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 510f / num * num2;
					this.FNHKJFBHLJN.SetVector(" : ", new Vector4(num4, num5, 7f, 459f));
					this.FNHKJFBHLJN.SetVector("_TimeX", new Vector4(this.lensflareThreshold, 65f, 1850f, 1909f));
					this.FNHKJFBHLJN.SetVector("LoadingStatusText", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("<b>Time</b>:", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 6);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 6);
					this.FNHKJFBHLJN.SetVector("Description goes here", new Vector4(num4 * num6, num5 * num6, 1802f, 373f));
					this.FNHKJFBHLJN.SetFloat("menu.selectedplaymode", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					this.FNHKJFBHLJN.SetFloat("Data", this.hollyStretchWidth * 585f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("_RampOffset", this.hollyStretchWidth * 1617f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 529f / num * num2;
						this.FNHKJFBHLJN.SetVector("/", new Vector4(num6 * num4, num6 * num5, 1947f, 1328f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 8);
						this.FNHKJFBHLJN.SetVector("SfxVolumeSlider", new Vector4(num6 * num4, num6 * num5, 981f, 135f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 4);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
					{
						this.GLMOGNMIOCC(1224f, temporary, renderTexture);
					}
					else
					{
						this.JOIEPNDEEIB(455f, temporary, temporary5);
						this.FFJFPIEALED(temporary5, temporary);
						this.GDJGNPBFLKD(871f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat(".g", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_Value2", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 1, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x00262711 File Offset: 0x00260911
		private void ILLACACMNCB(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("PhotonMono", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x0026273C File Offset: 0x0026093C
		public void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.Shadowmap || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == Bloom.HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.Shadowmap;
			int width = HLBKCLPNHEB.width / 2;
			int height = HLBKCLPNHEB.height / 6;
			int width2 = HLBKCLPNHEB.width / 1;
			int height2 = HLBKCLPNHEB.height / 0;
			float num = 1585f * (float)HLBKCLPNHEB.width / (41f * (float)HLBKCLPNHEB.height);
			float num2 = 1559f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format);
			if (this.quality > Bloom.BloomQuality.High)
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.KNABIALPPBB, 5);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 1, format);
				Graphics.Blit(temporary2, temporary3, this.KNABIALPPBB, 8);
				Graphics.Blit(temporary3, temporary, this.KNABIALPPBB, 5);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary2);
				Graphics.Blit(temporary2, temporary, this.KNABIALPPBB, 7);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 1, format);
			this.EEOJDGFAFMP(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			else if (this.bloomBlurIterations > -88)
			{
				this.bloomBlurIterations = 99;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1710f + (float)i * 1453f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 1, format);
				this.FNHKJFBHLJN.SetVector("_Value2", new Vector4(334f, num3 * num2, 1335f, 496f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.FNHKJFBHLJN.SetVector("GetLive", new Vector4(num3 / num * num2, 835f, 4f, 119f));
				Graphics.Blit(renderTexture, temporary4, this.FNHKJFBHLJN, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.BloomQuality.High)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.KNABIALPPBB, -122);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(temporary, renderTexture, this.KNABIALPPBB, 4);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 1, format);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.NIMNDOKPCDC(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.BloomQuality.High)
					{
						this.FNHKJFBHLJN.SetVector("visible", new Vector4(504f, 359f / (1441f * (float)temporary.height), 412f, 192f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(true, false, Color.black);
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
						this.FNHKJFBHLJN.SetVector("MusicFileSelector", new Vector4(1407f / (192f * (float)temporary.width), 337f, 159f, 185f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(true, true, Color.black);
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 3);
					}
					this.IHDPANJJBPC(471f, temporary5, temporary5);
					this.JBPGDFNKPPE(temporary5, renderTexture);
				}
				else
				{
					float num4 = 870f * Mathf.Cos(this.flareRotation);
					float num5 = 755f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 846f / num * num2;
					this.FNHKJFBHLJN.SetVector("ConfigVersionSlider", new Vector4(num4, num5, 1755f, 567f));
					this.FNHKJFBHLJN.SetVector("_ScreenResolution", new Vector4(this.lensflareThreshold, 445f, 871f, 1367f));
					this.FNHKJFBHLJN.SetVector("[NetworkManager] Connected to ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.FNHKJFBHLJN.SetFloat("_MainTex2", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 5);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 6);
					this.FNHKJFBHLJN.SetVector("_History2LumaTex", new Vector4(num4 * num6, num5 * num6, 926f, 1143f));
					this.FNHKJFBHLJN.SetFloat("CameraFilterPack/Blend2Camera_Screen", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat("_ScreenResolution", this.hollyStretchWidth * 1524f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 1);
					this.FNHKJFBHLJN.SetFloat(" not exist", this.hollyStretchWidth * 1648f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 0);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 1009f / num * num2;
						this.FNHKJFBHLJN.SetVector("CameraFilterPack/Blend2Camera_Luminosity", new Vector4(num6 * num4, num6 * num5, 293f, 65f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.FNHKJFBHLJN, 0);
						this.FNHKJFBHLJN.SetVector("leave", new Vector4(num6 * num4, num6 * num5, 1881f, 1601f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.FNHKJFBHLJN, 7);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Anamorphic)
					{
						this.BGOAEMICENB(949f, temporary, renderTexture);
					}
					else
					{
						this.HDOHGDKKMJI(1544f, temporary, temporary5);
						this.AFFNODAHBEI(temporary5, temporary);
						this.BGOAEMICENB(515f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			this.KNABIALPPBB.SetFloat("#91CCFF", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("Drop_Near", HLBKCLPNHEB);
			if (this.quality > Bloom.BloomQuality.High)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 1, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, BMMLHGHKBNM, this.KNABIALPPBB, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KNABIALPPBB, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x00262EDD File Offset: 0x002610DD
		private void DMLEDGBNDNI(float CEBPEMAKFOC, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.FGAHKAOHPFA.SetVector("resource", new Vector4(CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC, CEBPEMAKFOC));
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA, 0);
		}

		// Token: 0x04000CCA RID: 3274
		public Bloom.TweakMode tweakMode;

		// Token: 0x04000CCB RID: 3275
		public Bloom.BloomScreenBlendMode screenBlendMode = Bloom.BloomScreenBlendMode.Add;

		// Token: 0x04000CCC RID: 3276
		public Bloom.HDRBloomMode hdr;

		// Token: 0x04000CCD RID: 3277
		private bool AOCBJHAFMCD;

		// Token: 0x04000CCE RID: 3278
		public float sepBlurSpread = 2.5f;

		// Token: 0x04000CCF RID: 3279
		public Bloom.BloomQuality quality = Bloom.BloomQuality.High;

		// Token: 0x04000CD0 RID: 3280
		public float bloomIntensity = 0.5f;

		// Token: 0x04000CD1 RID: 3281
		public float bloomThreshold = 0.5f;

		// Token: 0x04000CD2 RID: 3282
		public Color bloomThresholdColor = Color.white;

		// Token: 0x04000CD3 RID: 3283
		public int bloomBlurIterations = 2;

		// Token: 0x04000CD4 RID: 3284
		public int hollywoodFlareBlurIterations = 2;

		// Token: 0x04000CD5 RID: 3285
		public float flareRotation;

		// Token: 0x04000CD6 RID: 3286
		public Bloom.LensFlareStyle lensflareMode = Bloom.LensFlareStyle.Anamorphic;

		// Token: 0x04000CD7 RID: 3287
		public float hollyStretchWidth = 2.5f;

		// Token: 0x04000CD8 RID: 3288
		public float lensflareIntensity;

		// Token: 0x04000CD9 RID: 3289
		public float lensflareThreshold = 0.3f;

		// Token: 0x04000CDA RID: 3290
		public float lensFlareSaturation = 0.75f;

		// Token: 0x04000CDB RID: 3291
		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		// Token: 0x04000CDC RID: 3292
		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		// Token: 0x04000CDD RID: 3293
		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		// Token: 0x04000CDE RID: 3294
		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		// Token: 0x04000CDF RID: 3295
		public Texture2D lensFlareVignetteMask;

		// Token: 0x04000CE0 RID: 3296
		public Shader lensFlareShader;

		// Token: 0x04000CE1 RID: 3297
		private Material LFEBKHIPEIN;

		// Token: 0x04000CE2 RID: 3298
		public Shader screenBlendShader;

		// Token: 0x04000CE3 RID: 3299
		private Material KNABIALPPBB;

		// Token: 0x04000CE4 RID: 3300
		public Shader blurAndFlaresShader;

		// Token: 0x04000CE5 RID: 3301
		private Material FNHKJFBHLJN;

		// Token: 0x04000CE6 RID: 3302
		public Shader brightPassFilterShader;

		// Token: 0x04000CE7 RID: 3303
		private Material FGAHKAOHPFA;

		// Token: 0x020001C1 RID: 449
		public enum LensFlareStyle
		{
			// Token: 0x04000CE9 RID: 3305
			Ghosting,
			// Token: 0x04000CEA RID: 3306
			Anamorphic,
			// Token: 0x04000CEB RID: 3307
			Combined
		}

		// Token: 0x020001C2 RID: 450
		public enum TweakMode
		{
			// Token: 0x04000CED RID: 3309
			Basic,
			// Token: 0x04000CEE RID: 3310
			Complex
		}

		// Token: 0x020001C3 RID: 451
		public enum HDRBloomMode
		{
			// Token: 0x04000CF0 RID: 3312
			Auto,
			// Token: 0x04000CF1 RID: 3313
			On,
			// Token: 0x04000CF2 RID: 3314
			Off
		}

		// Token: 0x020001C4 RID: 452
		public enum BloomScreenBlendMode
		{
			// Token: 0x04000CF4 RID: 3316
			Screen,
			// Token: 0x04000CF5 RID: 3317
			Add
		}

		// Token: 0x020001C5 RID: 453
		public enum BloomQuality
		{
			// Token: 0x04000CF7 RID: 3319
			Cheap,
			// Token: 0x04000CF8 RID: 3320
			High
		}
	}
}
