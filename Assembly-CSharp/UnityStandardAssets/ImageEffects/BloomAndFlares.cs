using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001CA RID: 458
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BloomAndFlares : PostEffectsBase
	{
		// Token: 0x060079A0 RID: 31136 RVA: 0x00262F08 File Offset: 0x00261108
		public virtual bool IEADOJPLNPO()
		{
			base.MBMLNJJEONO(false);
			this.KNABIALPPBB = base.EDFIBHNHAAB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.GJKHKCOAFDB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.KDHKHOHMKCG(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.AJKPGPKKHHB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.ECNEGNMAMDE(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.KDHKHOHMKCG(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.LKIJNGDHLAK(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x00262FDC File Offset: 0x002611DC
		private void IJFBACJAHAG(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_ColorBuffer", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 3);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("vignetteIntensity", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00263040 File Offset: 0x00261240
		private void HELPGHHFPIO(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("MouseX", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x00263060 File Offset: 0x00261260
		private void PKOGJBDPOAB(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("Save", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x00263080 File Offset: 0x00261280
		public virtual bool HKJMEHGPPMC()
		{
			base.NPOEJIDLJGK(true);
			this.KNABIALPPBB = base.NODBMINMALP(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.NODBMINMALP(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.NODBMINMALP(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.NODBMINMALP(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.ECNEGNMAMDE(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.AJKPGPKKHHB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x00263154 File Offset: 0x00261354
		private void BNCBCDHDBKL(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_Val2", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 0);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("LeaderboardsButton", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x002631B8 File Offset: 0x002613B8
		private void DDECHACBKIO(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("Please specify either t or f.", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_ScreenResolution", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value4", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("[LobbyPlayerElement] On ready click", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x00263304 File Offset: 0x00261504
		public virtual bool EJIGOLAIMHP()
		{
			base.LMEBEGFJGEM(false);
			this.KNABIALPPBB = base.ECNEGNMAMDE(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.LKIJNGDHLAK(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.GJKHKCOAFDB(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.AJKPGPKKHHB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.GJKHKCOAFDB(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.NODBMINMALP(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x002633D8 File Offset: 0x002615D8
		private void MNMONMPIPPO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.Shadowmap && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 7, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 8, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 1, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 7, HLBKCLPNHEB.height / 5, 1, format);
			float num = 89f * (float)HLBKCLPNHEB.width / (691f * (float)HLBKCLPNHEB.height);
			float num2 = 1652f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 0);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 5);
			RenderTexture.ReleaseTemporary(temporary);
			this.AKOADBLODOM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1423f + (float)i * 854f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("_Value", new Vector4(1783f, num3 * num2, 728f, 603f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("default", new Vector4(num3 / num * num2, 909f, 6f, 1240f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.DDMFNDHEJLH(this.lensflareThreshold, 735f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.FAKNNAMCNKP(1760f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.PNMPHHGLLBC(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("note.7", new Vector4(this.lensflareThreshold, 528f / (1238f - this.lensflareThreshold), 63f, 325f));
					this.JCPGICFBCNM.SetVector("BadgeText", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 5);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 4);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("LoadingStatusText", new Vector4(this.sepBlurSpread * 98f / num * num2, 624f, 798f, 1153f));
					this.JCPGICFBCNM.SetFloat("CameraFilterPack/TV_Vcr", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_TimeX", this.hollyStretchWidth * 264f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_PColor2", this.hollyStretchWidth * 268f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("PublishButton", new Vector4(this.hollyStretchWidth * 200f / num * num2, 1262f, 688f, 1482f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", new Vector4(this.hollyStretchWidth * 846f / num * num2, 1434f, 732f, 1394f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.EMILNIBFPPE(1465f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("_Value4", new Vector4(this.hollyStretchWidth * 1598f / num * num2, 1878f, 362f, 1776f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_Value", new Vector4(this.hollyStretchWidth * 1149f / num * num2, 585f, 1653f, 984f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.PENFJCNNCOH(687f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.PICCMNNPBJM(temporary4, temporary3);
						temporary4.DiscardContents();
						this.BMFKGMAAHGH(1345f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("#failed!", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("\n", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00263A0F File Offset: 0x00261C0F
		private void CBDLBEGPMHE(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("/", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x00263A2F File Offset: 0x00261C2F
		private void FCANJHDJDMI(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("Set Satellite Input", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x00263A50 File Offset: 0x00261C50
		private void ILLACACMNCB(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("_TimeX", new Vector4(CEBPEMAKFOC, 299f, 364f, 1028f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("\"", new Vector4(CEBPEMAKFOC, 1929f / (810f - CEBPEMAKFOC), 688f, 1011f));
			}
			this.FGAHKAOHPFA.SetFloat("roomDescription", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x00263AE0 File Offset: 0x00261CE0
		private void JNBLBHCKDGD(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("DPADHOR", new Vector4(CEBPEMAKFOC, 978f, 319f, 870f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector(".a", new Vector4(CEBPEMAKFOC, 89f / (42f - CEBPEMAKFOC), 1751f, 858f));
			}
			this.FGAHKAOHPFA.SetFloat("#getrewardfailed: ", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x00263B70 File Offset: 0x00261D70
		private void COBDBLMOCHD(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("RECORD [R]", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value4", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Greenness", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("hidden", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x00263CBC File Offset: 0x00261EBC
		private void JOIEPNDEEIB(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("[MapsData] User's maps was loaded", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 3);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("Use ticket: ", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x00263D20 File Offset: 0x00261F20
		private void PFCKMFEKBNC(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("_ScreenResolution", new Vector4(CEBPEMAKFOC, 1385f, 265f, 221f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("error", new Vector4(CEBPEMAKFOC, 680f / (1863f - CEBPEMAKFOC), 1400f, 1175f));
			}
			this.FGAHKAOHPFA.SetFloat("-1", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x00263DB0 File Offset: 0x00261FB0
		private void PICCMNNPBJM(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("[RanksSystem] Init", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("Edited event", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("LevelEditor/CustomEventEditor-Text", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("ItemsStoreButton", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x00263EFC File Offset: 0x002620FC
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.Default || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Default : RenderTextureFormat.ARGB4444;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 7, HLBKCLPNHEB.height / 4, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 3, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 5, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 1, 1, format);
			float num = 1740f * (float)HLBKCLPNHEB.width / (1676f * (float)HLBKCLPNHEB.height);
			float num2 = 354f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 1);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 1);
			RenderTexture.ReleaseTemporary(temporary);
			this.DDMFNDHEJLH(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (624f + (float)i * 1129f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector(".lastCheckpoint.time", new Vector4(82f, num3 * num2, 198f, 730f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("Create failed on GameServer. Changing back to MasterServer. Msg: ", new Vector4(num3 / num * num2, 1810f, 808f, 1989f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.AKOADBLODOM(this.lensflareThreshold, 991f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.FHNMLFLLIMP(1067f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.IAIDAGFIKEM(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("_Distortion", new Vector4(this.lensflareThreshold, 1678f / (1864f - this.lensflareThreshold), 86f, 303f));
					this.JCPGICFBCNM.SetVector("ItemsCountText", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 5);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 8);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("maps.", new Vector4(this.sepBlurSpread * 551f / num * num2, 1066f, 1587f, 168f));
					this.JCPGICFBCNM.SetFloat("[PlayerBase] Loading checkpoint data", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("id", this.hollyStretchWidth * 561f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_Vignette", this.hollyStretchWidth * 135f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector("{STEAM_CLAN_IMAGE}", new Vector4(this.hollyStretchWidth * 1952f / num * num2, 1778f, 969f, 1037f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(this.hollyStretchWidth * 1684f / num * num2, 630f, 1250f, 603f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.FCANJHDJDMI(673f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector("_Factor", new Vector4(this.hollyStretchWidth * 1059f / num * num2, 1623f, 565f, 1870f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("maps.", new Vector4(this.hollyStretchWidth * 187f / num * num2, 993f, 1875f, 1595f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.IJFBACJAHAG(739f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.CMNJFBHPONJ(temporary4, temporary3);
						temporary4.DiscardContents();
						this.ANJDCIOHBEJ(976f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("GhostSize", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("Preparing content", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x00264533 File Offset: 0x00262733
		private void LIPJLLBHPLH(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("[NetworkManager] Connection failed: ", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079B3 RID: 31155 RVA: 0x00264554 File Offset: 0x00262754
		private void MKIFJMPELJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGB4444 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGB4444;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 0, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 6, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 1, 0, format);
			float num = 487f * (float)HLBKCLPNHEB.width / (258f * (float)HLBKCLPNHEB.height);
			float num2 = 634f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 3);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 3);
			RenderTexture.ReleaseTemporary(temporary);
			this.BJBNKAIBCNJ(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1931f + (float)i * 831f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("_Amount", new Vector4(250f, num3 * num2, 1621f, 1048f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("_Value2", new Vector4(num3 / num * num2, 828f, 1138f, 477f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.HKFHPIMNLFG(this.lensflareThreshold, 101f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.FAKNNAMCNKP(1149f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.GFGCBJBILLF(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("_TimeX", new Vector4(this.lensflareThreshold, 1883f / (207f - this.lensflareThreshold), 495f, 1394f));
					this.JCPGICFBCNM.SetVector("#savemapbeforeuploading", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("Tab2Content", new Vector4(this.sepBlurSpread * 992f / num * num2, 1699f, 313f, 1534f));
					this.JCPGICFBCNM.SetFloat("_MainTex2", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("mapselector.filter.subscribedonly", this.hollyStretchWidth * 1967f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("null", this.hollyStretchWidth * 1661f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("y", new Vector4(this.hollyStretchWidth * 1419f / num * num2, 606f, 1129f, 1830f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector(" not exist", new Vector4(this.hollyStretchWidth * 1292f / num * num2, 281f, 1001f, 700f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.FFHPLDAOKGI(787f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("steamid", new Vector4(this.hollyStretchWidth * 500f / num * num2, 985f, 1848f, 1066f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("CameraFilterPack/Blend2Camera_Hue", new Vector4(this.hollyStretchWidth * 1017f / num * num2, 1170f, 1429f, 113f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.IFNFJHKGGEN(139f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.BNKPLGHINBK(temporary4, temporary3);
						temporary4.DiscardContents();
						this.CBDLBEGPMHE(642f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("_Green_B", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture(" SphereWaveform.cs", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079B4 RID: 31156 RVA: 0x00264B8C File Offset: 0x00262D8C
		public virtual bool KJEILODCDHM()
		{
			base.KNGDKKMDKOG(false);
			this.KNABIALPPBB = base.KDHKHOHMKCG(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.LKIJNGDHLAK(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.KDHKHOHMKCG(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.NODBMINMALP(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.LKIJNGDHLAK(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.NODBMINMALP(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x00264C60 File Offset: 0x00262E60
		private void NFJFHPCMEGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB32 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 1, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 7, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 7, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 4, 1, format);
			float num = 38f * (float)HLBKCLPNHEB.width / (1862f * (float)HLBKCLPNHEB.height);
			float num2 = 829f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 7);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 0);
			RenderTexture.ReleaseTemporary(temporary);
			this.CAPGEDCFJCB(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1630f + (float)i * 961f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("Error: I/O Failure! :(", new Vector4(1677f, num3 * num2, 842f, 298f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("_MainTex2", new Vector4(num3 / num * num2, 1526f, 1139f, 1572f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.CAPGEDCFJCB(this.lensflareThreshold, 266f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.IJFBACJAHAG(1481f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.PNMPHHGLLBC(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("CheckpointsScoreText", new Vector4(this.lensflareThreshold, 1658f / (1970f - this.lensflareThreshold), 571f, 1116f));
					this.JCPGICFBCNM.SetVector("inventory.selected.", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 5);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 5);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("_Y", new Vector4(this.sepBlurSpread * 963f / num * num2, 1532f, 1228f, 140f));
					this.JCPGICFBCNM.SetFloat("_CameraClipInfo", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("maps.", this.hollyStretchWidth * 157f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("ArcsHitsoundTimeDelaySlider", this.hollyStretchWidth * 720f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector("_ScreenSize", new Vector4(this.hollyStretchWidth * 555f / num * num2, 1156f, 1600f, 202f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("maps.", new Vector4(this.hollyStretchWidth * 148f / num * num2, 1137f, 786f, 888f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.GLMOGNMIOCC(506f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("/../", new Vector4(this.hollyStretchWidth * 779f / num * num2, 1315f, 688f, 921f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("#join", new Vector4(this.hollyStretchWidth * 1680f / num * num2, 240f, 939f, 1163f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.BNCBCDHDBKL(1472f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.BNKPLGHINBK(temporary4, temporary3);
						temporary4.DiscardContents();
						this.PFCJCDJBGNH(1589f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("_Radius", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("selector", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079B6 RID: 31158 RVA: 0x00265298 File Offset: 0x00263498
		public virtual bool JDBPDOPGJLA()
		{
			base.LMEBEGFJGEM(false);
			this.KNABIALPPBB = base.NODBMINMALP(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.GJKHKCOAFDB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.LKIJNGDHLAK(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.AJKPGPKKHHB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.EDFIBHNHAAB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.EDFIBHNHAAB(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.NODBMINMALP(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079B7 RID: 31159 RVA: 0x0026536C File Offset: 0x0026356C
		private void GMFDDBJDMCI(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("CameraFilterPack/AAA_BloodOnScreen", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 3);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("MenuScene", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x002653D0 File Offset: 0x002635D0
		private void MMBPPEPNNLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGBHalf || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Depth : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 0, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 8, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 7, HLBKCLPNHEB.height / 5, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 4, 1, format);
			float num = 788f * (float)HLBKCLPNHEB.width / (692f * (float)HLBKCLPNHEB.height);
			float num2 = 190f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 0);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 7);
			RenderTexture.ReleaseTemporary(temporary);
			this.PFCKMFEKBNC(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1911f + (float)i * 575f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("_ScreenResolution", new Vector4(1968f, num3 * num2, 182f, 42f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("Horizontal", new Vector4(num3 / num * num2, 1762f, 1486f, 1275f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.CMOKOCPDFNM(this.lensflareThreshold, 158f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.IJFBACJAHAG(508f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.IKGJMJHCEEB(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("_Offsets", new Vector4(this.lensflareThreshold, 761f / (153f - this.lensflareThreshold), 815f, 1064f));
					this.JCPGICFBCNM.SetVector("LevelURLInputField", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 4);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("_SpherePositionX", new Vector4(this.sepBlurSpread * 218f / num * num2, 1099f, 1034f, 1183f));
					this.JCPGICFBCNM.SetFloat("DPADVER", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_Value4", this.hollyStretchWidth * 1452f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_CameraToWorldMatrix", this.hollyStretchWidth * 1018f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("/", new Vector4(this.hollyStretchWidth * 915f / num * num2, 483f, 1832f, 361f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_Value2", new Vector4(this.hollyStretchWidth * 1404f / num * num2, 1229f, 801f, 716f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.PKOGJBDPOAB(1688f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("CloseConnection: Only the masterclient can kick another player.", new Vector4(this.hollyStretchWidth * 1429f / num * num2, 637f, 116f, 1593f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("The shader ", new Vector4(this.hollyStretchWidth * 1083f / num * num2, 1557f, 1690f, 1665f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.BNCBCDHDBKL(394f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.DDECHACBKIO(temporary4, temporary3);
						temporary4.DiscardContents();
						this.PHLPEAAHKGB(132f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("#scoresubmitionfailed: ", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("/icon", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00265A07 File Offset: 0x00263C07
		private void GLMOGNMIOCC(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("_Distortion", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00265A28 File Offset: 0x00263C28
		private void IKGJMJHCEEB(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("BloomShaderValueSlider", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("workshop.", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector(" SphereWaveform.cs", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_ScreenResolution", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x00265B74 File Offset: 0x00263D74
		private void GAANDCGCBHF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGB32 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGBHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 8, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 5, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 5, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 7, 1, format);
			float num = 782f * (float)HLBKCLPNHEB.width / (1657f * (float)HLBKCLPNHEB.height);
			float num2 = 98f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 6);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 5);
			RenderTexture.ReleaseTemporary(temporary);
			this.JNBLBHCKDGD(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (153f + (float)i * 460f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("_MatrixColor", new Vector4(1864f, num3 * num2, 853f, 500f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("RT", new Vector4(num3 / num * num2, 1402f, 803f, 345f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.DDMFNDHEJLH(this.lensflareThreshold, 1677f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.JOIEPNDEEIB(92f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.DDECHACBKIO(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("_BgColor", new Vector4(this.lensflareThreshold, 375f / (633f - this.lensflareThreshold), 1096f, 1840f));
					this.JCPGICFBCNM.SetVector("_Value8", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 7);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 8);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("[MapsStats] Length: ", new Vector4(this.sepBlurSpread * 15f / num * num2, 146f, 957f, 635f));
					this.JCPGICFBCNM.SetFloat("_ScreenResolution", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat(".lastCheckpoint.incorrectScore", this.hollyStretchWidth * 1295f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_BlurredColor", this.hollyStretchWidth * 1f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("maps.", new Vector4(this.hollyStretchWidth * 285f / num * num2, 597f, 662f, 31f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_Bloom3", new Vector4(this.hollyStretchWidth * 1196f / num * num2, 576f, 1371f, 308f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.MIHOFBDIFGL(635f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector("player.watermelon", new Vector4(this.hollyStretchWidth * 957f / num * num2, 1577f, 1164f, 866f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("Left Stick Click", new Vector4(this.hollyStretchWidth * 1439f / num * num2, 459f, 1838f, 664f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.BNCBCDHDBKL(682f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.DDECHACBKIO(temporary4, temporary3);
						temporary4.DiscardContents();
						this.ANJDCIOHBEJ(365f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("_ChromaticAberration", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_TimeX", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x002661AC File Offset: 0x002643AC
		private void COCLIKPAHFL(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("OK", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("LevelInfoInputField", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector(" - PUBLISHED #", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_LowRez", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x002662F8 File Offset: 0x002644F8
		private void CANJPOCKFCN(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("_Value2", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value4", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x00266442 File Offset: 0x00264642
		private void IINBAHILNOG(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("Ok", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00266464 File Offset: 0x00264664
		private void FHNMLFLLIMP(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("win", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 3);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("menu.playedsolo", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x002664C8 File Offset: 0x002646C8
		private void BJBNKAIBCNJ(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("[SERVER] Kicked ", new Vector4(CEBPEMAKFOC, 1381f, 510f, 1341f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("GraphicsQualitySlider", new Vector4(CEBPEMAKFOC, 535f / (1837f - CEBPEMAKFOC), 1533f, 193f));
			}
			this.FGAHKAOHPFA.SetFloat("_Blood", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x00266558 File Offset: 0x00264758
		private void EIJGAONEEKI(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", new Vector4(CEBPEMAKFOC, 1319f, 1850f, 786f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("RecordButton", new Vector4(CEBPEMAKFOC, 810f / (1403f - CEBPEMAKFOC), 1066f, 88f));
			}
			this.FGAHKAOHPFA.SetFloat("_TimeX", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x002665E8 File Offset: 0x002647E8
		public virtual bool BCDIEBGNBEG()
		{
			base.IHMNPAHGNFF(true);
			this.KNABIALPPBB = base.EDFIBHNHAAB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.EDFIBHNHAAB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.ECNEGNMAMDE(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.GJKHKCOAFDB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.KDHKHOHMKCG(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.LKIJNGDHLAK(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x002666BC File Offset: 0x002648BC
		private void PLIMEJNJNIP(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture(":</b> ", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 0);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat(" does not exist!", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00266720 File Offset: 0x00264920
		private void DJODNAAAOEB(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("Music End", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 2);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x00266784 File Offset: 0x00264984
		private void CAPGEDCFJCB(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("UI Extensions/UIScreen", new Vector4(CEBPEMAKFOC, 1466f, 1448f, 138f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("Circle", new Vector4(CEBPEMAKFOC, 315f / (1951f - CEBPEMAKFOC), 1625f, 919f));
			}
			this.FGAHKAOHPFA.SetFloat("_DiffuseColor", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x00266814 File Offset: 0x00264A14
		private void CMNJFBHPONJ(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("colorA", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("colorB", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("colorC", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("colorD", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x00266960 File Offset: 0x00264B60
		private void GFGCBJBILLF(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("_Noise", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("???", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("SupportLogger OnFailedToConnectToPhoton(", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("note.3", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x00266AAC File Offset: 0x00264CAC
		private void FAKNNAMCNKP(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("SetParticlesParticleSize", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 4);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("Game Version: ", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x00266B10 File Offset: 0x00264D10
		private void EMILNIBFPPE(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("menu.playedpage", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x00266B30 File Offset: 0x00264D30
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB4444 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGB32;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 8, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 3, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 7, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 2, 1, format);
			float num = 1663f * (float)HLBKCLPNHEB.width / (1365f * (float)HLBKCLPNHEB.height);
			float num2 = 1740f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 4);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.CMOKOCPDFNM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1953f + (float)i * 1681f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("CameraFilterPack/Drawing_Manga", new Vector4(1267f, num3 * num2, 1933f, 579f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("https://bitbucket.org/khb-soft/intralismarcsviewer/", new Vector4(num3 / num * num2, 746f, 624f, 1062f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.ILLACACMNCB(this.lensflareThreshold, 1543f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.PJJDEBAAJPI(1681f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.PICCMNNPBJM(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("CameraFilterPack/Color_Convert_Normal", new Vector4(this.lensflareThreshold, 481f / (1358f - this.lensflareThreshold), 1201f, 1078f));
					this.JCPGICFBCNM.SetVector("Found best region: '", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 5);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("_Value", new Vector4(this.sepBlurSpread * 416f / num * num2, 1146f, 411f, 881f));
					this.JCPGICFBCNM.SetFloat("_PositionY", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("{0:0} second{1}", this.hollyStretchWidth * 392f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("{0} seconds ago", this.hollyStretchWidth * 152f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector("_Value", new Vector4(this.hollyStretchWidth * 1f / num * num2, 1994f, 1381f, 642f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", new Vector4(this.hollyStretchWidth * 779f / num * num2, 467f, 1816f, 159f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.HDOHBMOFIGF(517f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("Default UI Material", new Vector4(this.hollyStretchWidth * 974f / num * num2, 183f, 1624f, 1309f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("PointsScoreText", new Vector4(this.hollyStretchWidth * 625f / num * num2, 1528f, 1183f, 574f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.PENFJCNNCOH(423f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.PICCMNNPBJM(temporary4, temporary3);
						temporary4.DiscardContents();
						this.FCANJHDJDMI(1585f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("threshold", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture(" not exist", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00267167 File Offset: 0x00265367
		private void PHLPEAAHKGB(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("_NoiseTex", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00267280 File Offset: 0x00265480
		private void AKOADBLODOM(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("source", new Vector4(CEBPEMAKFOC, 997f, 1914f, 245f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("CameraFilterPack/Blur_Focus", new Vector4(CEBPEMAKFOC, 1583f / (1945f - CEBPEMAKFOC), 1421f, 1898f));
			}
			this.FGAHKAOHPFA.SetFloat("Observed type is not serializable: ", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00267310 File Offset: 0x00265510
		private void GCGPHHLJHFO(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("  |  Events Count: ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("DPADHOR", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Noise", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value2", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x0026745A File Offset: 0x0026565A
		private void MIHOFBDIFGL(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("_Intensity", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x0026747C File Offset: 0x0026567C
		public virtual bool HBNCKBEPKGF()
		{
			base.DCHKKHDGBLJ(false);
			this.KNABIALPPBB = base.AJKPGPKKHHB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.KDHKHOHMKCG(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.GJKHKCOAFDB(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.AJKPGPKKHHB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.KDHKHOHMKCG(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.KDHKHOHMKCG(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x00267550 File Offset: 0x00265750
		private void ANJDCIOHBEJ(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat(".jpg", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x00267570 File Offset: 0x00265770
		private void OMONDKJJFAD(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("a", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x00267590 File Offset: 0x00265790
		private void PENFJCNNCOH(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("Editor", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 8);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("_Value3", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x002675F4 File Offset: 0x002657F4
		private void PFCJCDJBGNH(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("OnPickedUp", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x00267614 File Offset: 0x00265814
		private void MHNMDJFEDLP(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("EnableRankedNotificationsToggle", new Vector4(CEBPEMAKFOC, 1026f, 1826f, 1980f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("LoadingStatusText", new Vector4(CEBPEMAKFOC, 1574f / (103f - CEBPEMAKFOC), 1621f, 983f));
			}
			this.FGAHKAOHPFA.SetFloat("note.6", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x002676A4 File Offset: 0x002658A4
		private void CMOKOCPDFNM(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("_Value", new Vector4(CEBPEMAKFOC, 185f, 957f, 1359f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("_Value4", new Vector4(CEBPEMAKFOC, 623f / (376f - CEBPEMAKFOC), 1110f, 1329f));
			}
			this.FGAHKAOHPFA.SetFloat("_TimeX", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x00267734 File Offset: 0x00265934
		private void MBACCKNLMIA(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("Object ID. Case-Sensitive", new Vector4(CEBPEMAKFOC, 773f, 1693f, 464f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("\\\"", new Vector4(CEBPEMAKFOC, 849f / (1804f - CEBPEMAKFOC), 551f, 141f));
			}
			this.FGAHKAOHPFA.SetFloat("_TimeX", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x002677C2 File Offset: 0x002659C2
		private void BMFKGMAAHGH(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("settings.shaders", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x002677E4 File Offset: 0x002659E4
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB1555 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGB1555;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 6, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 8, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 3, 0, format);
			float num = 1059f * (float)HLBKCLPNHEB.width / (1657f * (float)HLBKCLPNHEB.height);
			float num2 = 281f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 8);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.PFCKMFEKBNC(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1232f + (float)i * 922f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("offsets", new Vector4(1691f, num3 * num2, 221f, 1410f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("Forward", new Vector4(num3 / num * num2, 1356f, 1395f, 10f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.DDMFNDHEJLH(this.lensflareThreshold, 215f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.FJPFODFNFNE(1680f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.COBDBLMOCHD(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("CheckpointsScoreText", new Vector4(this.lensflareThreshold, 956f / (1448f - this.lensflareThreshold), 840f, 230f));
					this.JCPGICFBCNM.SetVector("#ok", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 3);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 7);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("Items", new Vector4(this.sepBlurSpread * 1597f / num * num2, 1977f, 48f, 1960f));
					this.JCPGICFBCNM.SetFloat("#8E8E8EFF", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat(".progress", this.hollyStretchWidth * 976f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_NoiseTex", this.hollyStretchWidth * 1314f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector("Editor", new Vector4(this.hollyStretchWidth * 857f / num * num2, 1752f, 1638f, 1949f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("settings_bindings_controller_type", new Vector4(this.hollyStretchWidth * 529f / num * num2, 972f, 541f, 1991f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.FFHPLDAOKGI(1081f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector("_Value", new Vector4(this.hollyStretchWidth * 356f / num * num2, 199f, 722f, 1006f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("inventory.itemscash", new Vector4(this.hollyStretchWidth * 451f / num * num2, 1607f, 1434f, 633f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.IJFBACJAHAG(1731f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.IKGJMJHCEEB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.FCANJHDJDMI(1745f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("SaveMapButton", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("\t", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00267E1C File Offset: 0x0026601C
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.Shadowmap || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.Shadowmap;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 1, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 4, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 6, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 2, 1, format);
			float num = 5f * (float)HLBKCLPNHEB.width / (576f * (float)HLBKCLPNHEB.height);
			float num2 = 909f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 3);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 8);
			RenderTexture.ReleaseTemporary(temporary);
			this.EEOJDGFAFMP(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1672f + (float)i * 813f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("settings.volume.menu", new Vector4(875f, num3 * num2, 653f, 210f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("LivesSlider", new Vector4(num3 / num * num2, 1492f, 1682f, 1179f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.MBACCKNLMIA(this.lensflareThreshold, 1506f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.FHNMLFLLIMP(83f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.DDECHACBKIO(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("SelectorMusicToggle", new Vector4(this.lensflareThreshold, 1124f / (1339f - this.lensflareThreshold), 1802f, 49f));
					this.JCPGICFBCNM.SetVector("Mouse0", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 3);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("Intensity", new Vector4(this.sepBlurSpread * 1479f / num * num2, 7f, 1079f, 430f));
					this.JCPGICFBCNM.SetFloat("_Value4", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_MainTex2", this.hollyStretchWidth * 1002f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("Internal LUT", this.hollyStretchWidth * 885f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector("_Value2", new Vector4(this.hollyStretchWidth * 236f / num * num2, 1542f, 1767f, 1535f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("ChangeSelectedLevel", new Vector4(this.hollyStretchWidth * 732f / num * num2, 390f, 1477f, 1993f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.HELPGHHFPIO(1998f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(this.hollyStretchWidth * 220f / num * num2, 1804f, 220f, 1940f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_Axis", new Vector4(this.hollyStretchWidth * 842f / num * num2, 1927f, 453f, 1919f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.BNCBCDHDBKL(36f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.IKGJMJHCEEB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.OMONDKJJFAD(1401f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("settings.arcsdestroydelay", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("SaveButton", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x00268454 File Offset: 0x00266654
		private void HKFHPIMNLFG(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("SetCrosshairEmission", new Vector4(CEBPEMAKFOC, 236f, 502f, 9f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("CameraFilterPack/Atmosphere_Fog", new Vector4(CEBPEMAKFOC, 76f / (966f - CEBPEMAKFOC), 1384f, 880f));
			}
			this.FGAHKAOHPFA.SetFloat(" to: ", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x002684E4 File Offset: 0x002666E4
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGBHalf && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 4, 0, format);
			float num = 1f * (float)HLBKCLPNHEB.width / (1f * (float)HLBKCLPNHEB.height);
			float num2 = 0.001953125f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 2);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 2);
			RenderTexture.ReleaseTemporary(temporary);
			this.FCJAOINLBFK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.FCJAOINLBFK(this.lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.IJFBACJAHAG(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.CMNJFBHPONJ(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("_threshold", new Vector4(this.lensflareThreshold, 1f / (1f - this.lensflareThreshold), 0f, 0f));
					this.JCPGICFBCNM.SetVector("tintColor", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 3);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("offsets", new Vector4(this.sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					this.JCPGICFBCNM.SetFloat("stretchWidth", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("stretchWidth", this.hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("stretchWidth", this.hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.MIHOFBDIFGL(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.IJFBACJAHAG(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.CMNJFBHPONJ(temporary4, temporary3);
						temporary4.DiscardContents();
						this.MIHOFBDIFGL(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("_Intensity", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_ColorBuffer", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x00268B1C File Offset: 0x00266D1C
		private void DDMFNDHEJLH(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("Tab2Content", new Vector4(CEBPEMAKFOC, 118f, 344f, 1010f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("offsets", new Vector4(CEBPEMAKFOC, 1266f / (65f - CEBPEMAKFOC), 481f, 800f));
			}
			this.FGAHKAOHPFA.SetFloat("_TimeX", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x00268BAC File Offset: 0x00266DAC
		private void BEGLNNLFFHJ(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("/icon", new Vector4(CEBPEMAKFOC, 1888f, 1533f, 839f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("/", new Vector4(CEBPEMAKFOC, 894f / (1580f - CEBPEMAKFOC), 1181f, 1281f));
			}
			this.FGAHKAOHPFA.SetFloat("th", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x00268C3C File Offset: 0x00266E3C
		private void NHICIDDKCPF(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_Threshold", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 5);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat(" methods \"", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x00268CA0 File Offset: 0x00266EA0
		private void FCJAOINLBFK(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("threshold", new Vector4(CEBPEMAKFOC, 1f, 0f, 0f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("threshold", new Vector4(CEBPEMAKFOC, 1f / (1f - CEBPEMAKFOC), 0f, 0f));
			}
			this.FGAHKAOHPFA.SetFloat("useSrcAlphaAsMask", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00268D30 File Offset: 0x00266F30
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGB32 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 0, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 5, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 0, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 7, HLBKCLPNHEB.height / 5, 0, format);
			float num = 1525f * (float)HLBKCLPNHEB.width / (374f * (float)HLBKCLPNHEB.height);
			float num2 = 521f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 7);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 2);
			RenderTexture.ReleaseTemporary(temporary);
			this.BEGLNNLFFHJ(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (479f + (float)i * 1796f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("Set Player Distance", new Vector4(1959f, num3 * num2, 637f, 1890f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("1.87", new Vector4(num3 / num * num2, 174f, 1029f, 1693f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.FCJAOINLBFK(this.lensflareThreshold, 1481f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.PJJDEBAAJPI(793f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.KDLFIAOIFBF(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("Reload Maps", new Vector4(this.lensflareThreshold, 391f / (1023f - this.lensflareThreshold), 815f, 1925f));
					this.JCPGICFBCNM.SetVector("event", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 6);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 4);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("_EmissionGain", new Vector4(this.sepBlurSpread * 142f / num * num2, 1072f, 532f, 1947f));
					this.JCPGICFBCNM.SetFloat(" not exist", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("Set satellite lerp speed", this.hollyStretchWidth * 1304f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("CameraFilterPack/TV_Posterize", this.hollyStretchWidth * 488f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector(".a", new Vector4(this.hollyStretchWidth * 208f / num * num2, 1730f, 304f, 1411f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("#", new Vector4(this.hollyStretchWidth * 229f / num * num2, 674f, 576f, 27f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.PFCJCDJBGNH(453f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("_Value", new Vector4(this.hollyStretchWidth * 418f / num * num2, 1828f, 1222f, 1364f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("w", new Vector4(this.hollyStretchWidth * 1958f / num * num2, 1307f, 1381f, 418f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.FAKNNAMCNKP(564f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.CMNJFBHPONJ(temporary4, temporary3);
						temporary4.DiscardContents();
						this.CBDLBEGPMHE(865f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("_Value", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_Saturation", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x00269368 File Offset: 0x00267568
		private void MPJCMKFFKHH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB1555 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Default : RenderTextureFormat.ARGB4444;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 2, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 3, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 7, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 4, 0, format);
			float num = 1121f * (float)HLBKCLPNHEB.width / (1939f * (float)HLBKCLPNHEB.height);
			float num2 = 1589f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 7);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 0);
			RenderTexture.ReleaseTemporary(temporary);
			this.BEGLNNLFFHJ(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1828f + (float)i * 1727f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("Editor", new Vector4(1831f, num3 * num2, 1409f, 1003f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("_PositionY", new Vector4(num3 / num * num2, 1931f, 727f, 1625f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.OKEJDLNGFJA(this.lensflareThreshold, 200f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.LACFCGCCABA(1650f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.IAIDAGFIKEM(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("CameraFilterPack/TV_Tiles", new Vector4(this.lensflareThreshold, 1635f / (943f - this.lensflareThreshold), 1862f, 961f));
					this.JCPGICFBCNM.SetVector("MenuScene", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 7);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 6);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("_TimeX", new Vector4(this.sepBlurSpread * 872f / num * num2, 1139f, 60f, 598f));
					this.JCPGICFBCNM.SetFloat("y", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_Value3", this.hollyStretchWidth * 1594f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat(".", this.hollyStretchWidth * 979f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("_MaxBlurRadius", new Vector4(this.hollyStretchWidth * 1125f / num * num2, 932f, 1927f, 390f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_Value2", new Vector4(this.hollyStretchWidth * 479f / num * num2, 844f, 1108f, 813f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.OJCFLHCDCCC(1981f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", new Vector4(this.hollyStretchWidth * 770f / num * num2, 826f, 1081f, 1289f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(this.hollyStretchWidth * 740f / num * num2, 748f, 121f, 1451f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.IJFBACJAHAG(190f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.IKGJMJHCEEB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.LIPJLLBHPLH(1120f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("_ExposureAdjustment", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x002699A0 File Offset: 0x00267BA0
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGB32 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Screen;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB32;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 4, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 3, 1, format);
			float num = 279f * (float)HLBKCLPNHEB.width / (1050f * (float)HLBKCLPNHEB.height);
			float num2 = 853f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 1);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.EIJGAONEEKI(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1060f + (float)i * 807f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("[PlayerBase] Got checkpoint at ", new Vector4(384f, num3 * num2, 659f, 895f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector(";", new Vector4(num3 / num * num2, 1950f, 1873f, 964f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.DDMFNDHEJLH(this.lensflareThreshold, 1503f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.PLIMEJNJNIP(64f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.CMNJFBHPONJ(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("_PixelsPerMeterAtOneMeter", new Vector4(this.lensflareThreshold, 1431f / (553f - this.lensflareThreshold), 639f, 1854f));
					this.JCPGICFBCNM.SetVector(".highscore", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 3);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 8);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("Called GetNumberOfCurrentPlayers()", new Vector4(this.sepBlurSpread * 198f / num * num2, 1080f, 1151f, 708f));
					this.JCPGICFBCNM.SetFloat("Show image from resources by id at the center of the screen at foreground or background", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("ClearEnvironment", this.hollyStretchWidth * 857f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("/", this.hollyStretchWidth * 1082f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("CameraFilterPack/Gradients_Stripe", new Vector4(this.hollyStretchWidth * 1594f / num * num2, 0f, 83f, 1737f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("float,50", new Vector4(this.hollyStretchWidth * 1860f / num * num2, 950f, 840f, 1183f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.GLMOGNMIOCC(1199f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("_ScreenResolution", new Vector4(this.hollyStretchWidth * 994f / num * num2, 1888f, 1652f, 623f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", new Vector4(this.hollyStretchWidth * 1529f / num * num2, 1724f, 103f, 870f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.OFOADJCGDCP(483f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.IKGJMJHCEEB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.FAGMOFLGLOH(1693f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("settings.arcsnohitsoundtimedelay", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("finished", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x00269FD8 File Offset: 0x002681D8
		private void EEOJDGFAFMP(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("[GameScene] Submiting rank", new Vector4(CEBPEMAKFOC, 675f, 943f, 474f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector("win", new Vector4(CEBPEMAKFOC, 263f / (481f - CEBPEMAKFOC), 672f, 91f));
			}
			this.FGAHKAOHPFA.SetFloat("_Alpha", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x0026A068 File Offset: 0x00268268
		public virtual bool PHJJGBHNECJ()
		{
			base.MBMLNJJEONO(true);
			this.KNABIALPPBB = base.ECNEGNMAMDE(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.KDHKHOHMKCG(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.NODBMINMALP(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.EDFIBHNHAAB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.EDFIBHNHAAB(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.GJKHKCOAFDB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x0026A13C File Offset: 0x0026833C
		private void HDOHBMOFIGF(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("_ChangeGreen", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x0026A15C File Offset: 0x0026835C
		public virtual bool MDPPFLOJIEI()
		{
			base.CKIAMHAKJOK(false);
			this.KNABIALPPBB = base.NODBMINMALP(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.AJKPGPKKHHB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.NODBMINMALP(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.KDHKHOHMKCG(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.ECNEGNMAMDE(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.KDHKHOHMKCG(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x0026A230 File Offset: 0x00268430
		private void OKEJDLNGFJA(float CEBPEMAKFOC, float PPLOOGFKDCO, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.AOCBJHAFMCD)
			{
				this.FGAHKAOHPFA.SetVector("0,7,true,0", new Vector4(CEBPEMAKFOC, 747f, 1261f, 369f));
			}
			else
			{
				this.FGAHKAOHPFA.SetVector(" Owner called.", new Vector4(CEBPEMAKFOC, 438f / (1053f - CEBPEMAKFOC), 1234f, 1087f));
			}
			this.FGAHKAOHPFA.SetFloat("_Value3", PPLOOGFKDCO);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.FGAHKAOHPFA);
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x0026A2C0 File Offset: 0x002684C0
		private void KENMBHKMEFK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.ARGB4444 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.Shadowmap;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 0, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 0, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 5, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 5, 1, format);
			float num = 480f * (float)HLBKCLPNHEB.width / (675f * (float)HLBKCLPNHEB.height);
			float num2 = 469f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 8);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 2);
			RenderTexture.ReleaseTemporary(temporary);
			this.FCJAOINLBFK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (265f + (float)i * 1394f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("r", new Vector4(1649f, num3 * num2, 29f, 135f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("CompletedLevel", new Vector4(num3 / num * num2, 1382f, 362f, 976f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.HKFHPIMNLFG(this.lensflareThreshold, 1549f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.PJJDEBAAJPI(206f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.IAIDAGFIKEM(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("[MapEditor] Reset", new Vector4(this.lensflareThreshold, 493f / (905f - this.lensflareThreshold), 0f, 1996f));
					this.JCPGICFBCNM.SetVector("SpawnObj", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 5);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("ws://", new Vector4(this.sepBlurSpread * 1258f / num * num2, 1007f, 16f, 1495f));
					this.JCPGICFBCNM.SetFloat("value", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat(".", this.hollyStretchWidth * 1506f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("offsets", this.hollyStretchWidth * 1195f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector("settings.volume.menu", new Vector4(this.hollyStretchWidth * 1777f / num * num2, 271f, 1266f, 548f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector(".lastCheckpoint.penaltyScore", new Vector4(this.hollyStretchWidth * 1502f / num * num2, 410f, 1709f, 375f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.OGCHCBKGBLD(1473f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector(".", new Vector4(this.hollyStretchWidth * 416f / num * num2, 109f, 1949f, 1962f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("RedoButton", new Vector4(this.hollyStretchWidth * 1497f / num * num2, 199f, 1111f, 1096f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.GMFDDBJDMCI(177f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.PNMPHHGLLBC(temporary4, temporary3);
						temporary4.DiscardContents();
						this.PKOGJBDPOAB(36f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("#failed: ", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("Working commands:\nreset <challengeid>\nresetall", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x0026A8F8 File Offset: 0x00268AF8
		public virtual bool BKNCNFMHIGH()
		{
			base.IBFDMKMOBCA(true);
			this.KNABIALPPBB = base.EDFIBHNHAAB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.GJKHKCOAFDB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.LKIJNGDHLAK(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.ECNEGNMAMDE(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.GJKHKCOAFDB(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.GJKHKCOAFDB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x0026A9CC File Offset: 0x00268BCC
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.KNABIALPPBB = base.EDFIBHNHAAB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.EDFIBHNHAAB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.EDFIBHNHAAB(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.EDFIBHNHAAB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.EDFIBHNHAAB(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.EDFIBHNHAAB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x0026AAA0 File Offset: 0x00268CA0
		private void FFHPLDAOKGI(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("Fill Area", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x0026AAC0 File Offset: 0x00268CC0
		private void CIKBKANMKEH(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_Value", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 4);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("OnReadyClick", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x0026AB24 File Offset: 0x00268D24
		private void BODGDCPNBLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = false;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.Default && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.Auto);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 7, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 2, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 5, 0, format);
			float num = 568f * (float)HLBKCLPNHEB.width / (1864f * (float)HLBKCLPNHEB.height);
			float num2 = 35f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 3);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 0);
			RenderTexture.ReleaseTemporary(temporary);
			this.CAPGEDCFJCB(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (726f + (float)i * 1827f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("[Right-Down]", new Vector4(856f, num3 * num2, 997f, 1065f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("SlidingArea", new Vector4(num3 / num * num2, 688f, 522f, 965f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.EIJGAONEEKI(this.lensflareThreshold, 1715f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.PENFJCNNCOH(785f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.PICCMNNPBJM(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("mapselector.filter.rateduponly", new Vector4(this.lensflareThreshold, 1501f / (667f - this.lensflareThreshold), 1282f, 921f));
					this.JCPGICFBCNM.SetVector("maps.", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 8);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 5);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("/", new Vector4(this.sepBlurSpread * 1201f / num * num2, 200f, 1530f, 1588f));
					this.JCPGICFBCNM.SetFloat("</color>", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("Hidden/DepthOfField/MedianFilter", this.hollyStretchWidth * 1045f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("levelcompleted", this.hollyStretchWidth * 614f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector(" scene: ", new Vector4(this.hollyStretchWidth * 557f / num * num2, 1692f, 1891f, 1858f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector(" timeUntilRespawnBasedOnTimeBase:", new Vector4(this.hollyStretchWidth * 1160f / num * num2, 348f, 666f, 1630f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.IGCHKPIGHNL(367f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.PEADOJLDHBK.SetVector("_Value2", new Vector4(this.hollyStretchWidth * 1837f / num * num2, 1034f, 698f, 1842f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_FixDistance", new Vector4(this.hollyStretchWidth * 906f / num * num2, 1212f, 1941f, 1819f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.FAKNNAMCNKP(93f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.GCGPHHLJHFO(temporary4, temporary3);
						temporary4.DiscardContents();
						this.CBDLBEGPMHE(295f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("Joystick1Button12", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x0026B15C File Offset: 0x0026935C
		private void PJJDEBAAJPI(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture(" Remote called.", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 2);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("GlassesColor2", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x0026B1C0 File Offset: 0x002693C0
		private void JCCIHFMBFJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format == RenderTextureFormat.ARGB1555 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (this.AOCBJHAFMCD && this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Shadowmap : RenderTextureFormat.ARGBHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 0, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 6, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 4, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 3, 1, format);
			float num = 1860f * (float)HLBKCLPNHEB.width / (1868f * (float)HLBKCLPNHEB.height);
			float num2 = 1739f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 2);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 1);
			RenderTexture.ReleaseTemporary(temporary);
			this.BEGLNNLFFHJ(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1569f + (float)i * 1538f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("_Value2", new Vector4(1785f, num3 * num2, 985f, 206f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("_MainTex2", new Vector4(num3 / num * num2, 1140f, 1181f, 1287f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.MHNMDJFEDLP(this.lensflareThreshold, 686f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.BNCBCDHDBKL(1852f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.KDLFIAOIFBF(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("_TimeX", new Vector4(this.lensflareThreshold, 1779f / (1530f - this.lensflareThreshold), 598f, 1970f));
					this.JCPGICFBCNM.SetVector("ns", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 6);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector(":\n", new Vector4(this.sepBlurSpread * 275f / num * num2, 797f, 744f, 1921f));
					this.JCPGICFBCNM.SetFloat("SaveButton", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("_Value2", this.hollyStretchWidth * 1860f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 1);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("#", this.hollyStretchWidth * 1958f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Ghosting)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.PEADOJLDHBK.SetVector("_Speed", new Vector4(this.hollyStretchWidth * 894f / num * num2, 1715f, 1987f, 1577f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("[DiscordController] Error {0}: {1}", new Vector4(this.hollyStretchWidth * 1965f / num * num2, 1921f, 230f, 1390f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.HDOHBMOFIGF(1063f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector("achievements.21.progress", new Vector4(this.hollyStretchWidth * 570f / num * num2, 569f, 467f, 668f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("CameraFilterPack/Blur_Radial_Fast", new Vector4(this.hollyStretchWidth * 248f / num * num2, 1579f, 1210f, 1384f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.PENFJCNNCOH(1956f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.IKGJMJHCEEB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.MIHOFBDIFGL(1271f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("value", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("maps.", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x0026B7F8 File Offset: 0x002699F8
		private void OFOADJCGDCP(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("maps.", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 0);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("CheckpointsScoreText", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x0026B85C File Offset: 0x00269A5C
		private void FAGMOFLGLOH(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("_TimeX", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x0026B87C File Offset: 0x00269A7C
		private void LACFCGCCABA(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("maps.", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 8);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("Texture3", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x0026B8E0 File Offset: 0x00269AE0
		private void BNKPLGHINBK(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("_Near", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value5", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("[PlayerController] ", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_TimeX", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x0026BA2C File Offset: 0x00269C2C
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.AOCBJHAFMCD = true;
			if (this.hdr == HDRBloomMode.Auto)
			{
				this.AOCBJHAFMCD = (HLBKCLPNHEB.format != RenderTextureFormat.Depth || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.AOCBJHAFMCD = (this.hdr == HDRBloomMode.On);
			}
			this.AOCBJHAFMCD = (!this.AOCBJHAFMCD || this.CLHPOIKGFFF);
			BloomScreenBlendMode pass = this.screenBlendMode;
			if (this.AOCBJHAFMCD)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (!this.AOCBJHAFMCD) ? RenderTextureFormat.Default : RenderTextureFormat.ARGB1555;
			RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 8, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 7, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 4, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 8, 0, format);
			float num = 43f * (float)HLBKCLPNHEB.width / (1276f * (float)HLBKCLPNHEB.height);
			float num2 = 1568f;
			Graphics.Blit(HLBKCLPNHEB, temporary, this.KNABIALPPBB, 1);
			Graphics.Blit(temporary, temporary2, this.KNABIALPPBB, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.FCJAOINLBFK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (23f + (float)i * 256f) * this.sepBlurSpread;
				this.PEADOJLDHBK.SetVector("[SoundManager] Loaded skin audio", new Vector4(1651f, num3 * num2, 619f, 985f));
				RenderTexture renderTexture = (i != 0) ? temporary2 : temporary3;
				Graphics.Blit(renderTexture, temporary4, this.PEADOJLDHBK);
				renderTexture.DiscardContents();
				this.PEADOJLDHBK.SetVector("Joystick1Button2", new Vector4(num3 / num * num2, 1114f, 526f, 660f));
				Graphics.Blit(temporary4, temporary2, this.PEADOJLDHBK);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == LensflareStyle34.Ghosting)
				{
					this.BJBNKAIBCNJ(this.lensflareThreshold, 547f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.PJJDEBAAJPI(1978f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.KDLFIAOIFBF(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.JCPGICFBCNM.SetVector("ShowTitle", new Vector4(this.lensflareThreshold, 351f / (1757f - this.lensflareThreshold), 1539f, 669f));
					this.JCPGICFBCNM.SetVector("/", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 6);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetVector("CameraFilterPack/Drawing_Paper2", new Vector4(this.sepBlurSpread * 1735f / num * num2, 1271f, 1218f, 1884f));
					this.JCPGICFBCNM.SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					this.JCPGICFBCNM.SetFloat("/icon", this.hollyStretchWidth * 558f);
					Graphics.Blit(temporary3, temporary4, this.JCPGICFBCNM, 0);
					temporary3.DiscardContents();
					this.JCPGICFBCNM.SetFloat("<start_index> <end_index>", this.hollyStretchWidth * 1360f);
					Graphics.Blit(temporary4, temporary3, this.JCPGICFBCNM, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.PEADOJLDHBK.SetVector("<b>", new Vector4(this.hollyStretchWidth * 739f / num * num2, 928f, 1905f, 1356f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_EmissionColor", new Vector4(this.hollyStretchWidth * 1136f / num * num2, 1507f, 657f, 1589f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.PKOGJBDPOAB(771f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.PEADOJLDHBK.SetVector("EventSystem", new Vector4(this.hollyStretchWidth * 1387f / num * num2, 815f, 1331f, 1871f));
							Graphics.Blit(temporary3, temporary4, this.PEADOJLDHBK);
							temporary3.DiscardContents();
							this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(this.hollyStretchWidth * 1444f / num * num2, 895f, 816f, 1700f));
							Graphics.Blit(temporary4, temporary3, this.PEADOJLDHBK);
							temporary4.DiscardContents();
						}
						this.NHICIDDKCPF(992f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.IKGJMJHCEEB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.IGCHKPIGHNL(1907f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.KNABIALPPBB.SetFloat("_TimeX", this.bloomIntensity);
			this.KNABIALPPBB.SetTexture("Mouse", HLBKCLPNHEB);
			Graphics.Blit(temporary2, BMMLHGHKBNM, this.KNABIALPPBB, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x0026C063 File Offset: 0x0026A263
		private void OJCFLHCDCCC(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("DPADVER", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x0026C084 File Offset: 0x0026A284
		public virtual bool NKMDBJOGHDI()
		{
			base.MBMLNJJEONO(true);
			this.KNABIALPPBB = base.NODBMINMALP(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.NODBMINMALP(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.AJKPGPKKHHB(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.EDFIBHNHAAB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.EDFIBHNHAAB(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.KDHKHOHMKCG(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x0026C158 File Offset: 0x0026A358
		public virtual bool KJAAENHDHHC()
		{
			base.IBFDMKMOBCA(true);
			this.KNABIALPPBB = base.EDFIBHNHAAB(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.GJKHKCOAFDB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.LKIJNGDHLAK(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.LKIJNGDHLAK(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.KDHKHOHMKCG(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.LKIJNGDHLAK(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x0026C22C File Offset: 0x0026A42C
		private void PNMPHHGLLBC(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("\" that takes ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("ready", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_ChromaticAberration", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("id", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x0026C378 File Offset: 0x0026A578
		public virtual bool ANCBDJKLGAI()
		{
			base.NPOEJIDLJGK(false);
			this.KNABIALPPBB = base.NODBMINMALP(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.NODBMINMALP(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.NODBMINMALP(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.EDFIBHNHAAB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.KDHKHOHMKCG(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.EDFIBHNHAAB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x0026C44C File Offset: 0x0026A64C
		public virtual bool ACEIOFMECMD()
		{
			base.IHMNPAHGNFF(true);
			this.KNABIALPPBB = base.ECNEGNMAMDE(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.KDHKHOHMKCG(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.GJKHKCOAFDB(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.LKIJNGDHLAK(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.LKIJNGDHLAK(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.NODBMINMALP(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0026C520 File Offset: 0x0026A720
		public virtual bool CGMIAKDJFDD()
		{
			base.KHNPMDDIJAJ(true);
			this.KNABIALPPBB = base.NODBMINMALP(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.KDHKHOHMKCG(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.LKIJNGDHLAK(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.AJKPGPKKHHB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.GJKHKCOAFDB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.EDFIBHNHAAB(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.ECNEGNMAMDE(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x0026C5F4 File Offset: 0x0026A7F4
		private void IAIDAGFIKEM(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("SettingsCanvas", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("CameraFilterPack/Color_Noise", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("[NetworkManager] Joined room with ", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("CameraFilterPack/Blend2Camera_Multiply", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x0026C740 File Offset: 0x0026A940
		private void IFNFJHKGGEN(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("_Near", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 3);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("#or", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x0026C7A4 File Offset: 0x0026A9A4
		private void FJPFODFNFNE(float BLFCOPNGKIM, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			if (this.lensFlareVignetteMask)
			{
				this.KNABIALPPBB.SetTexture("player.bluearc", this.lensFlareVignetteMask);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.KNABIALPPBB, 6);
			}
			else
			{
				this.PCGPKMODFHI.SetFloat("LetterSpacing: Missing Text component", BLFCOPNGKIM);
				Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.PCGPKMODFHI);
			}
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x0026C808 File Offset: 0x0026AA08
		private void KDLFIAOIFBF(RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LFEBKHIPEIN.SetVector("Joystick1Button1", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("id", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_TimeX", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.LFEBKHIPEIN.SetVector("_Value3", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LFEBKHIPEIN);
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x0026C954 File Offset: 0x0026AB54
		public virtual bool KMKBAOKOJDE()
		{
			base.KNGDKKMDKOG(true);
			this.KNABIALPPBB = base.LKIJNGDHLAK(this.screenBlendShader, this.KNABIALPPBB);
			this.LFEBKHIPEIN = base.EDFIBHNHAAB(this.lensFlareShader, this.LFEBKHIPEIN);
			this.PCGPKMODFHI = base.KDHKHOHMKCG(this.vignetteShader, this.PCGPKMODFHI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			this.LLFPKHFDCGK = base.GJKHKCOAFDB(this.addBrightStuffOneOneShader, this.LLFPKHFDCGK);
			this.JCPGICFBCNM = base.ECNEGNMAMDE(this.hollywoodFlaresShader, this.JCPGICFBCNM);
			this.FGAHKAOHPFA = base.AJKPGPKKHHB(this.brightPassFilterShader, this.FGAHKAOHPFA);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x0026CA28 File Offset: 0x0026AC28
		private void OGCHCBKGBLD(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("#close", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x0026CA48 File Offset: 0x0026AC48
		private void IGCHKPIGHNL(float BHEKCBODHNH, RenderTexture BHNGOLDNELC, RenderTexture HANEOLNMOEF)
		{
			this.LLFPKHFDCGK.SetFloat("turn", BHEKCBODHNH);
			Graphics.Blit(BHNGOLDNELC, HANEOLNMOEF, this.LLFPKHFDCGK);
		}

		// Token: 0x04000D07 RID: 3335
		public TweakMode34 tweakMode;

		// Token: 0x04000D08 RID: 3336
		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		// Token: 0x04000D09 RID: 3337
		public HDRBloomMode hdr;

		// Token: 0x04000D0A RID: 3338
		private bool AOCBJHAFMCD;

		// Token: 0x04000D0B RID: 3339
		public float sepBlurSpread = 1.5f;

		// Token: 0x04000D0C RID: 3340
		public float useSrcAlphaAsMask = 0.5f;

		// Token: 0x04000D0D RID: 3341
		public float bloomIntensity = 1f;

		// Token: 0x04000D0E RID: 3342
		public float bloomThreshold = 0.5f;

		// Token: 0x04000D0F RID: 3343
		public int bloomBlurIterations = 2;

		// Token: 0x04000D10 RID: 3344
		public bool lensflares;

		// Token: 0x04000D11 RID: 3345
		public int hollywoodFlareBlurIterations = 2;

		// Token: 0x04000D12 RID: 3346
		public LensflareStyle34 lensflareMode = LensflareStyle34.Anamorphic;

		// Token: 0x04000D13 RID: 3347
		public float hollyStretchWidth = 3.5f;

		// Token: 0x04000D14 RID: 3348
		public float lensflareIntensity = 1f;

		// Token: 0x04000D15 RID: 3349
		public float lensflareThreshold = 0.3f;

		// Token: 0x04000D16 RID: 3350
		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		// Token: 0x04000D17 RID: 3351
		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		// Token: 0x04000D18 RID: 3352
		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		// Token: 0x04000D19 RID: 3353
		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		// Token: 0x04000D1A RID: 3354
		public Texture2D lensFlareVignetteMask;

		// Token: 0x04000D1B RID: 3355
		public Shader lensFlareShader;

		// Token: 0x04000D1C RID: 3356
		private Material LFEBKHIPEIN;

		// Token: 0x04000D1D RID: 3357
		public Shader vignetteShader;

		// Token: 0x04000D1E RID: 3358
		private Material PCGPKMODFHI;

		// Token: 0x04000D1F RID: 3359
		public Shader separableBlurShader;

		// Token: 0x04000D20 RID: 3360
		private Material PEADOJLDHBK;

		// Token: 0x04000D21 RID: 3361
		public Shader addBrightStuffOneOneShader;

		// Token: 0x04000D22 RID: 3362
		private Material LLFPKHFDCGK;

		// Token: 0x04000D23 RID: 3363
		public Shader screenBlendShader;

		// Token: 0x04000D24 RID: 3364
		private Material KNABIALPPBB;

		// Token: 0x04000D25 RID: 3365
		public Shader hollywoodFlaresShader;

		// Token: 0x04000D26 RID: 3366
		private Material JCPGICFBCNM;

		// Token: 0x04000D27 RID: 3367
		public Shader brightPassFilterShader;

		// Token: 0x04000D28 RID: 3368
		private Material FGAHKAOHPFA;
	}
}
