using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001D7 RID: 471
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[RequireComponent(typeof(Camera))]
	public class ContrastEnhance : PostEffectsBase
	{
		// Token: 0x06007BA4 RID: 31652 RVA: 0x0027D2D0 File Offset: 0x0027B4D0
		private void NEIOOEKEOPC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 1, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("updating", new Vector4(1334f, this.blurSpread * 1393f / (float)temporary2.height, 604f, 701f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 2, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", new Vector4(this.blurSpread * 846f / (float)temporary2.width, 1834f, 1089f, 1273f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 6, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_TimeX", temporary2);
			this.HAOKALKHGJI.SetFloat("Set satellite color", this.intensity);
			this.HAOKALKHGJI.SetFloat("#exit", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x0027D430 File Offset: 0x0027B630
		public virtual bool KMKBAOKOJDE()
		{
			base.LMEBEGFJGEM(false);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x0027D48C File Offset: 0x0027B68C
		public virtual bool BDBLODKHNGF()
		{
			base.KHNPMDDIJAJ(true);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x0027D4E8 File Offset: 0x0027B6E8
		public virtual bool HKEMNPKHLEO()
		{
			base.NPOEJIDLJGK(false);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x0027D544 File Offset: 0x0027B744
		public virtual bool IILEKDNFOFI()
		{
			base.IBFDMKMOBCA(true);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x0027D5A0 File Offset: 0x0027B7A0
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 6, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("In Map Editor", new Vector4(515f, this.blurSpread * 1515f / (float)temporary2.height, 1652f, 330f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 7, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("SpawnObj", new Vector4(this.blurSpread * 1545f / (float)temporary2.width, 1014f, 696f, 1359f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 8, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture(" not exist", temporary2);
			this.HAOKALKHGJI.SetFloat("PossibleMapMaxScoreText", this.intensity);
			this.HAOKALKHGJI.SetFloat("TwoHands", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x0027D700 File Offset: 0x0027B900
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 6, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 1, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_BlurVector", new Vector4(659f, this.blurSpread * 556f / (float)temporary2.height, 296f, 815f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 1, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Value3", new Vector4(this.blurSpread * 402f / (float)temporary2.width, 1041f, 1822f, 1966f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 6, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture(" ", temporary2);
			this.HAOKALKHGJI.SetFloat("_Gamma", this.intensity);
			this.HAOKALKHGJI.SetFloat("OnRelease", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x0027D860 File Offset: 0x0027BA60
		public override bool AFNHKGFNOCL()
		{
			base.DHHGCBANGJL(false);
			this.HAOKALKHGJI = base.NODBMINMALP(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x0027D8BC File Offset: 0x0027BABC
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 8, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 3, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("0.00", new Vector4(793f, this.blurSpread * 1246f / (float)temporary2.height, 1614f, 1041f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 7, height / 3, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("Updated!", new Vector4(this.blurSpread * 1752f / (float)temporary2.width, 1982f, 1661f, 494f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 5, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("CameraFilterPack/Blend2Camera_Difference", temporary2);
			this.HAOKALKHGJI.SetFloat("return ", this.intensity);
			this.HAOKALKHGJI.SetFloat("DPADVER", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x0027DA1C File Offset: 0x0027BC1C
		public virtual bool JIJIMMICLAM()
		{
			base.IHMNPAHGNFF(false);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x0027DA78 File Offset: 0x0027BC78
		public virtual bool PDEFIDFBKFE()
		{
			base.IBFDMKMOBCA(true);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x0027DAD4 File Offset: 0x0027BCD4
		public virtual bool KBPPNPKJIJG()
		{
			base.IBFDMKMOBCA(true);
			this.HAOKALKHGJI = base.LKIJNGDHLAK(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x0027DB30 File Offset: 0x0027BD30
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 3, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_ColoredChange", new Vector4(1875f, this.blurSpread * 658f / (float)temporary2.height, 1067f, 1251f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 8, height / 4, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(this.blurSpread * 981f / (float)temporary2.width, 913f, 1154f, 211f));
			temporary2 = RenderTexture.GetTemporary(width / 2, height / 1, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_EmissionColor", temporary2);
			this.HAOKALKHGJI.SetFloat("CameraFilterPack/Distortion_BlackHole", this.intensity);
			this.HAOKALKHGJI.SetFloat(".", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x0027DC90 File Offset: 0x0027BE90
		public virtual bool MKKNILHMBIC()
		{
			base.FNIFJAENDIB(false);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x0027DCEC File Offset: 0x0027BEEC
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 3, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("path", new Vector4(933f, this.blurSpread * 1117f / (float)temporary2.height, 782f, 953f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 8, height / 8, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("menu.tabid", new Vector4(this.blurSpread * 1104f / (float)temporary2.width, 1950f, 1086f, 1600f));
			temporary2 = RenderTexture.GetTemporary(width / 8, height / 5, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("value", temporary2);
			this.HAOKALKHGJI.SetFloat("_Parasite", this.intensity);
			this.HAOKALKHGJI.SetFloat("steamid", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x0027DE4C File Offset: 0x0027C04C
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 0, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("file://", new Vector4(1511f, this.blurSpread * 1757f / (float)temporary2.height, 1667f, 1650f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 7, height / 3, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_ScreenResolution", new Vector4(this.blurSpread * 901f / (float)temporary2.width, 1784f, 264f, 68f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_MainTex2", temporary2);
			this.HAOKALKHGJI.SetFloat("EventMenu", this.intensity);
			this.HAOKALKHGJI.SetFloat("wss://", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x0027DFAC File Offset: 0x0027C1AC
		public virtual bool OBEFMKGPJLI()
		{
			base.LMEBEGFJGEM(true);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x0027E008 File Offset: 0x0027C208
		public virtual bool EICPCBFEDNI()
		{
			base.NPOEJIDLJGK(false);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x0027E064 File Offset: 0x0027C264
		private void KDOCJGGAOII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 2, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 8, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("Jun", new Vector4(280f, this.blurSpread * 368f / (float)temporary2.height, 1886f, 1666f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 7, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_LightIntensity", new Vector4(this.blurSpread * 208f / (float)temporary2.width, 1274f, 1463f, 1141f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 5, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("Unable to get a reward! Try again?", temporary2);
			this.HAOKALKHGJI.SetFloat("BadgeText", this.intensity);
			this.HAOKALKHGJI.SetFloat("settings_bindings_sec_", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x0027E1C4 File Offset: 0x0027C3C4
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 8, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("sfxVolume", new Vector4(1088f, this.blurSpread * 1528f / (float)temporary2.height, 1728f, 673f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 0, height / 1, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("RPC: 'OnAwakeRPC' PhotonView: ", new Vector4(this.blurSpread * 300f / (float)temporary2.width, 1868f, 400f, 174f));
			temporary2 = RenderTexture.GetTemporary(width / 2, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("SetSunMinSize", temporary2);
			this.HAOKALKHGJI.SetFloat("settings.volume.menu", this.intensity);
			this.HAOKALKHGJI.SetFloat("BloodAlternative1", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x0027E324 File Offset: 0x0027C524
		private void HGJJPACDBEP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 6, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 3, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("https://store.steampowered.com/recommended/recommendgame/", new Vector4(1464f, this.blurSpread * 539f / (float)temporary2.height, 1243f, 1456f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 1, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("The shader ", new Vector4(this.blurSpread * 228f / (float)temporary2.width, 1530f, 1326f, 18f));
			temporary2 = RenderTexture.GetTemporary(width / 8, height / 4, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_Intensity", temporary2);
			this.HAOKALKHGJI.SetFloat("_TimeX", this.intensity);
			this.HAOKALKHGJI.SetFloat("settings_bindings_controller_type", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x0027E484 File Offset: 0x0027C684
		public virtual bool JFFKKNHBANB()
		{
			base.IHMNPAHGNFF(false);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x0027E4E0 File Offset: 0x0027C6E0
		public virtual bool GHFILFDHANN()
		{
			base.IBFDMKMOBCA(false);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x0027E53C File Offset: 0x0027C73C
		public virtual bool IHNGNCCNPCK()
		{
			base.FNIFJAENDIB(true);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x0027E598 File Offset: 0x0027C798
		public override bool ILMGHBFANON()
		{
			base.JOMCJOEOLHP(true);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x0027E5F4 File Offset: 0x0027C7F4
		public virtual bool AFMAMEFKALN()
		{
			base.NPOEJIDLJGK(true);
			this.HAOKALKHGJI = base.NODBMINMALP(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x0027E650 File Offset: 0x0027C850
		public virtual bool LPDMNDMCPCO()
		{
			base.KHNPMDDIJAJ(false);
			this.HAOKALKHGJI = base.NODBMINMALP(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x0027E6AC File Offset: 0x0027C8AC
		public virtual bool FEIGCNHEINM()
		{
			base.NPOEJIDLJGK(true);
			this.HAOKALKHGJI = base.NODBMINMALP(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x0027E708 File Offset: 0x0027C908
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 6, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("Set Satellite Input", new Vector4(1151f, this.blurSpread * 1941f / (float)temporary2.height, 1872f, 451f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 7, height / 2, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Value", new Vector4(this.blurSpread * 466f / (float)temporary2.width, 1201f, 291f, 1614f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 5, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("SettingsCanvas", temporary2);
			this.HAOKALKHGJI.SetFloat("CameraFilterPack/FX_DigitalMatrix", this.intensity);
			this.HAOKALKHGJI.SetFloat("x", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x0027E868 File Offset: 0x0027CA68
		public virtual bool IMPPEKJHPIM()
		{
			base.LMEBEGFJGEM(true);
			this.HAOKALKHGJI = base.EDFIBHNHAAB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x0027E8C4 File Offset: 0x0027CAC4
		public virtual bool HBBIDMLLFFD()
		{
			base.FNIFJAENDIB(true);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x0027E920 File Offset: 0x0027CB20
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 5, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 2, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_ScreenResolution", new Vector4(274f, this.blurSpread * 1102f / (float)temporary2.height, 1350f, 1488f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 1, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_TintColor", new Vector4(this.blurSpread * 776f / (float)temporary2.width, 1351f, 1529f, 1663f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 6, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("mapselector.filter.favoriteonly", temporary2);
			this.HAOKALKHGJI.SetFloat("EventSystem", this.intensity);
			this.HAOKALKHGJI.SetFloat("DataText", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x0027EA80 File Offset: 0x0027CC80
		private void CKCPPNHANAA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 2, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 7, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("settings_bindings_sec_", new Vector4(1863f, this.blurSpread * 43f / (float)temporary2.height, 1760f, 1442f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 0, height / 0, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("Call ConnectToNameServer to ping available regions.", new Vector4(this.blurSpread * 227f / (float)temporary2.width, 1785f, 1614f, 1274f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 8, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("settings.fps", temporary2);
			this.HAOKALKHGJI.SetFloat("shader.pixel", this.intensity);
			this.HAOKALKHGJI.SetFloat("Set camera background color", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x0027EBE0 File Offset: 0x0027CDE0
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 1, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 3, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("CameraFilterPack/Blend2Camera_ColorKey", new Vector4(1472f, this.blurSpread * 1900f / (float)temporary2.height, 242f, 475f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 6, height / 8, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector(" ", new Vector4(this.blurSpread * 681f / (float)temporary2.width, 262f, 1807f, 1239f));
			temporary2 = RenderTexture.GetTemporary(width / 1, height / 6, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("settings_bindings_", temporary2);
			this.HAOKALKHGJI.SetFloat("_EmissionColor", this.intensity);
			this.HAOKALKHGJI.SetFloat("[PlayerController] ", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x0027ED40 File Offset: 0x0027CF40
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 5, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_GlowColor", new Vector4(881f, this.blurSpread * 1590f / (float)temporary2.height, 853f, 343f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_PColor", new Vector4(this.blurSpread * 84f / (float)temporary2.width, 1414f, 901f, 423f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 3, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("PhotonView with ID ", temporary2);
			this.HAOKALKHGJI.SetFloat("_UserLutTex", this.intensity);
			this.HAOKALKHGJI.SetFloat("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x0027EEA0 File Offset: 0x0027D0A0
		private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_History3ChromaTex", new Vector4(380f, this.blurSpread * 395f / (float)temporary2.height, 1507f, 1424f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 8, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("Texture2", new Vector4(this.blurSpread * 1291f / (float)temporary2.width, 152f, 1676f, 704f));
			temporary2 = RenderTexture.GetTemporary(width / 0, height / 8, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("offsets", temporary2);
			this.HAOKALKHGJI.SetFloat("cipherText", this.intensity);
			this.HAOKALKHGJI.SetFloat("BitsData", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x0027F000 File Offset: 0x0027D200
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("offsets", new Vector4(0f, this.blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("offsets", new Vector4(this.blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_MainTexBlurred", temporary2);
			this.HAOKALKHGJI.SetFloat("intensity", this.intensity);
			this.HAOKALKHGJI.SetFloat("threshold", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x0027F160 File Offset: 0x0027D360
		private void HCOGCFOBBMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 3, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 5, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("SetPlayerDistance", new Vector4(1122f, this.blurSpread * 89f / (float)temporary2.height, 1031f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 7, height / 6, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("Fade", new Vector4(this.blurSpread * 1572f / (float)temporary2.width, 966f, 465f, 371f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_Value2", temporary2);
			this.HAOKALKHGJI.SetFloat("mapselector.filter.officialsortmode", this.intensity);
			this.HAOKALKHGJI.SetFloat("/icon", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x0027F2C0 File Offset: 0x0027D4C0
		private void MKIFJMPELJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 1, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_Value5", new Vector4(381f, this.blurSpread * 319f / (float)temporary2.height, 765f, 1931f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 6, height / 5, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(this.blurSpread * 977f / (float)temporary2.width, 475f, 1911f, 293f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 7, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("The given 2D texture ", temporary2);
			this.HAOKALKHGJI.SetFloat("DifficultyBG", this.intensity);
			this.HAOKALKHGJI.SetFloat("SpectatingUserInfo", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x0027F420 File Offset: 0x0027D620
		private void LPFHEJNMEOO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 5, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_RGB", new Vector4(1443f, this.blurSpread * 1616f / (float)temporary2.height, 706f, 1316f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 4, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("gold", new Vector4(this.blurSpread * 347f / (float)temporary2.width, 792f, 1638f, 746f));
			temporary2 = RenderTexture.GetTemporary(width / 2, height / 6, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("player.xp", temporary2);
			this.HAOKALKHGJI.SetFloat("_MainTex2", this.intensity);
			this.HAOKALKHGJI.SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x0027F580 File Offset: 0x0027D780
		private void BODGDCPNBLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 3, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 2, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector(").png", new Vector4(22f, this.blurSpread * 945f / (float)temporary2.height, 486f, 1916f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 0, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("maps.", new Vector4(this.blurSpread * 482f / (float)temporary2.width, 1754f, 1807f, 178f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 8, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_TapMedium", temporary2);
			this.HAOKALKHGJI.SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", this.intensity);
			this.HAOKALKHGJI.SetFloat("anonymous", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x0027F6E0 File Offset: 0x0027D8E0
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 3, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 8, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("Keypad", new Vector4(661f, this.blurSpread * 848f / (float)temporary2.height, 923f, 590f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 5, height / 5, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_SunColor", new Vector4(this.blurSpread * 403f / (float)temporary2.width, 901f, 814f, 244f));
			temporary2 = RenderTexture.GetTemporary(width / 3, height / 8, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("mapselector.filter.officialsortmode", temporary2);
			this.HAOKALKHGJI.SetFloat("UseScanLineSize", this.intensity);
			this.HAOKALKHGJI.SetFloat("shader.future", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x0027F840 File Offset: 0x0027DA40
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 0, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 0, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(864f, this.blurSpread * 1626f / (float)temporary2.height, 1954f, 629f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 0, height / 8, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Distortion", new Vector4(this.blurSpread * 1642f / (float)temporary2.width, 143f, 1579f, 511f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 7, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("Room: '{0}' {1},{2} {4}/{3} players.", temporary2);
			this.HAOKALKHGJI.SetFloat("player.circle", this.intensity);
			this.HAOKALKHGJI.SetFloat("ChatHistoryInputField", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x0027F9A0 File Offset: 0x0027DBA0
		public virtual bool BKNCNFMHIGH()
		{
			base.NPOEJIDLJGK(false);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x0027F9FC File Offset: 0x0027DBFC
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.HAOKALKHGJI = base.EDFIBHNHAAB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x0027FA58 File Offset: 0x0027DC58
		public virtual bool GCLELPIDOCM()
		{
			base.DCHKKHDGBLJ(false);
			this.HAOKALKHGJI = base.KDHKHOHMKCG(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x0027FAB4 File Offset: 0x0027DCB4
		public override bool PFIELBMLHJK()
		{
			base.IBFDMKMOBCA(true);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x0027FB10 File Offset: 0x0027DD10
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 3, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector(" not exist", new Vector4(174f, this.blurSpread * 340f / (float)temporary2.height, 1688f, 1185f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 8, height / 7, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector4(this.blurSpread * 1385f / (float)temporary2.width, 623f, 1714f, 1920f));
			temporary2 = RenderTexture.GetTemporary(width / 2, height / 3, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("Tab2Content", temporary2);
			this.HAOKALKHGJI.SetFloat("IEnumerable", this.intensity);
			this.HAOKALKHGJI.SetFloat("_TimeX", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x0027FC70 File Offset: 0x0027DE70
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 5, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 6, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_Value", new Vector4(1230f, this.blurSpread * 1044f / (float)temporary2.height, 1249f, 553f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 0, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Speed", new Vector4(this.blurSpread * 1927f / (float)temporary2.width, 894f, 697f, 1840f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 0, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("PhotonServerSettings", temporary2);
			this.HAOKALKHGJI.SetFloat("settings.selectormapsperpage", this.intensity);
			this.HAOKALKHGJI.SetFloat("CameraFilterPack/Light_Water", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x0027FDD0 File Offset: 0x0027DFD0
		public virtual bool ELHBKCFNCOJ()
		{
			base.KNGDKKMDKOG(false);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x0027FE2C File Offset: 0x0027E02C
		public virtual bool LPOMLFNIDCD()
		{
			base.NPOEJIDLJGK(true);
			this.HAOKALKHGJI = base.EDFIBHNHAAB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x0027FE88 File Offset: 0x0027E088
		public virtual bool ENDFLCJNOGA()
		{
			base.MBMLNJJEONO(true);
			this.HAOKALKHGJI = base.LKIJNGDHLAK(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x0027FEE4 File Offset: 0x0027E0E4
		public virtual bool KLLLLEOIGHG()
		{
			base.MBMLNJJEONO(false);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.AJKPGPKKHHB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x0027FF40 File Offset: 0x0027E140
		private void IEJCEFENLOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 2, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 2, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("UseScanLine", new Vector4(1353f, this.blurSpread * 1976f / (float)temporary2.height, 1720f, 1701f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_ScreenResolution", new Vector4(this.blurSpread * 92f / (float)temporary2.width, 766f, 739f, 215f));
			temporary2 = RenderTexture.GetTemporary(width / 8, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("workshop.", temporary2);
			this.HAOKALKHGJI.SetFloat("CameraFilterPack/Blend2Camera_Difference", this.intensity);
			this.HAOKALKHGJI.SetFloat("0,1,true,0", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x002800A0 File Offset: 0x0027E2A0
		public virtual bool KIBBICMGDMF()
		{
			base.JOMCJOEOLHP(true);
			this.HAOKALKHGJI = base.NODBMINMALP(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x002800FC File Offset: 0x0027E2FC
		public virtual bool PHJJGBHNECJ()
		{
			base.IBFDMKMOBCA(true);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x00280158 File Offset: 0x0027E358
		private void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 5, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 8, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_SprTex", new Vector4(678f, this.blurSpread * 381f / (float)temporary2.height, 124f, 152f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 1, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("#challengecomplete", new Vector4(this.blurSpread * 1195f / (float)temporary2.width, 213f, 395f, 311f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 2, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture(".played", temporary2);
			this.HAOKALKHGJI.SetFloat("The given 2D texture ", this.intensity);
			this.HAOKALKHGJI.SetFloat("maps.", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x002802B8 File Offset: 0x0027E4B8
		private void JKAKHLNPNNP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 5, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_HalfResolution", new Vector4(771f, this.blurSpread * 454f / (float)temporary2.height, 1089f, 1606f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 1, height / 5, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Value1", new Vector4(this.blurSpread * 1480f / (float)temporary2.width, 1007f, 1759f, 399f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 5, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("masterSteamID", temporary2);
			this.HAOKALKHGJI.SetFloat("powerup.0", this.intensity);
			this.HAOKALKHGJI.SetFloat("time", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x00280418 File Offset: 0x0027E618
		private void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 6, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 7, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("Set Background Color", new Vector4(166f, this.blurSpread * 1022f / (float)temporary2.height, 79f, 1106f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 8, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Value4", new Vector4(this.blurSpread * 1527f / (float)temporary2.width, 1991f, 923f, 1041f));
			temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_ColorRGB", temporary2);
			this.HAOKALKHGJI.SetFloat("win", this.intensity);
			this.HAOKALKHGJI.SetFloat("maps.", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x00280578 File Offset: 0x0027E778
		private void MMBPPEPNNLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 0, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 8, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("maps.", new Vector4(1062f, this.blurSpread * 1220f / (float)temporary2.height, 61f, 393f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 6, height / 3, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("Object ID. Case-Sensitive", new Vector4(this.blurSpread * 552f / (float)temporary2.width, 1324f, 893f, 1261f));
			temporary2 = RenderTexture.GetTemporary(width / 1, height / 3, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture(".mp3", temporary2);
			this.HAOKALKHGJI.SetFloat("Right", this.intensity);
			this.HAOKALKHGJI.SetFloat("_ReflectionTexture0", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x002806D8 File Offset: 0x0027E8D8
		public virtual bool PDNFBCMPHEI()
		{
			base.FNIFJAENDIB(true);
			this.HAOKALKHGJI = base.KDHKHOHMKCG(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x00280734 File Offset: 0x0027E934
		public virtual bool DDLPGIECCLI()
		{
			base.IBFDMKMOBCA(false);
			this.HAOKALKHGJI = base.KDHKHOHMKCG(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x00280790 File Offset: 0x0027E990
		public virtual bool PDMNDFFNOPM()
		{
			base.JOMCJOEOLHP(false);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x002807EC File Offset: 0x0027E9EC
		public virtual bool OCADOBLPPAA()
		{
			base.NPOEJIDLJGK(true);
			this.HAOKALKHGJI = base.LKIJNGDHLAK(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x00280848 File Offset: 0x0027EA48
		private void NHNMJJBFLJP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 6, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 1, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_DistortionSize", new Vector4(895f, this.blurSpread * 1407f / (float)temporary2.height, 1845f, 1494f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 7, height / 3, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector(" - PUBLISHED #", new Vector4(this.blurSpread * 853f / (float)temporary2.width, 589f, 1177f, 619f));
			temporary2 = RenderTexture.GetTemporary(width / 3, height / 1, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("GlassAberration", temporary2);
			this.HAOKALKHGJI.SetFloat("SetSpeed", this.intensity);
			this.HAOKALKHGJI.SetFloat("Joystick1Button2", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x002809A8 File Offset: 0x0027EBA8
		public virtual bool KFDALIFKLHE()
		{
			base.IHMNPAHGNFF(false);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x00280A04 File Offset: 0x0027EC04
		public virtual bool BKEJKJKFLGD()
		{
			base.IHMNPAHGNFF(false);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BE7 RID: 31719 RVA: 0x00280A60 File Offset: 0x0027EC60
		private void KFGGHDFLDIP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 7, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 1, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("CameraFilterPack/FX_Hypno", new Vector4(1625f, this.blurSpread * 1862f / (float)temporary2.height, 291f, 361f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 0, height / 7, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Blue_R", new Vector4(this.blurSpread * 517f / (float)temporary2.width, 1856f, 545f, 839f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_DepthLevel", temporary2);
			this.HAOKALKHGJI.SetFloat("EndlessLoopsScoreText", this.intensity);
			this.HAOKALKHGJI.SetFloat(").png", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x00280BC0 File Offset: 0x0027EDC0
		private void PACLEGDKKPI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 2, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 8, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("(\\[ *\\/ *url *])", new Vector4(937f, this.blurSpread * 433f / (float)temporary2.height, 436f, 1435f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 8, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("GlassAberration", new Vector4(this.blurSpread * 1917f / (float)temporary2.width, 1966f, 667f, 1485f));
			temporary2 = RenderTexture.GetTemporary(width / 8, height / 0, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_Value3", temporary2);
			this.HAOKALKHGJI.SetFloat("%]</b> ", this.intensity);
			this.HAOKALKHGJI.SetFloat("NO", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x00280D20 File Offset: 0x0027EF20
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 4, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 6, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_TimeX", new Vector4(1032f, this.blurSpread * 1055f / (float)temporary2.height, 509f, 67f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 8, height / 8, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_SmallTex", new Vector4(this.blurSpread * 1261f / (float)temporary2.width, 536f, 326f, 1076f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 5, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("menu.playedsolo", temporary2);
			this.HAOKALKHGJI.SetFloat(".message", this.intensity);
			this.HAOKALKHGJI.SetFloat("[MapEditor] Updating map assets", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BEA RID: 31722 RVA: 0x00280E80 File Offset: 0x0027F080
		public virtual bool PEAKHOPMBFD()
		{
			base.IBFDMKMOBCA(false);
			this.HAOKALKHGJI = base.EDFIBHNHAAB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x00280EDC File Offset: 0x0027F0DC
		public virtual bool IGHCJDIBGKP()
		{
			base.FNIFJAENDIB(true);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x00280F38 File Offset: 0x0027F138
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 0, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("colorC", new Vector4(1131f, this.blurSpread * 882f / (float)temporary2.height, 1302f, 958f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 0, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("<command>", new Vector4(this.blurSpread * 1055f / (float)temporary2.width, 1810f, 1931f, 235f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 8, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_Offsets", temporary2);
			this.HAOKALKHGJI.SetFloat("Testing, the group has toggled [", this.intensity);
			this.HAOKALKHGJI.SetFloat("DisableStoryboardToggle", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x00281098 File Offset: 0x0027F298
		public virtual bool LGFMJDPKOOM()
		{
			base.IHMNPAHGNFF(false);
			this.HAOKALKHGJI = base.KDHKHOHMKCG(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.AJKPGPKKHHB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x002810F4 File Offset: 0x0027F2F4
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 1, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 5, height / 4, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_FixDistance", new Vector4(56f, this.blurSpread * 1287f / (float)temporary2.height, 1485f, 873f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 8, height / 8, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("Screenshots only supported in PlayMode", new Vector4(this.blurSpread * 734f / (float)temporary2.width, 791f, 1012f, 1744f));
			temporary2 = RenderTexture.GetTemporary(width / 3, height / 5, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("id", temporary2);
			this.HAOKALKHGJI.SetFloat("_ScreenResolution", this.intensity);
			this.HAOKALKHGJI.SetFloat("Joystick1Button10", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x00281254 File Offset: 0x0027F454
		private void BABCJIIKIAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 5, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("CameraFilterPack/Glasses_OnX", new Vector4(1962f, this.blurSpread * 1067f / (float)temporary2.height, 1612f, 1693f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 1, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("BadgeText", new Vector4(this.blurSpread * 388f / (float)temporary2.width, 891f, 1532f, 298f));
			temporary2 = RenderTexture.GetTemporary(width / 1, height / 0, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("[Right-Down]", temporary2);
			this.HAOKALKHGJI.SetFloat("Testing, a toggle has toggled [", this.intensity);
			this.HAOKALKHGJI.SetFloat("#no", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BF0 RID: 31728 RVA: 0x002813B4 File Offset: 0x0027F5B4
		public virtual bool OAGFHJHEBCA()
		{
			base.LMEBEGFJGEM(false);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x00281410 File Offset: 0x0027F610
		private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 8, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 6, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("Jazz", new Vector4(1000f, this.blurSpread * 911f / (float)temporary2.height, 1262f, 1418f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 6, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Blue_R", new Vector4(this.blurSpread * 61f / (float)temporary2.width, 1815f, 442f, 90f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 7, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_TimeX", temporary2);
			this.HAOKALKHGJI.SetFloat("SpawnObj", this.intensity);
			this.HAOKALKHGJI.SetFloat("masterSteamID", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x00281570 File Offset: 0x0027F770
		private void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 7, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 8, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_Value", new Vector4(1275f, this.blurSpread * 1752f / (float)temporary2.height, 1052f, 716f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 6, height / 1, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("</color>", new Vector4(this.blurSpread * 204f / (float)temporary2.width, 1825f, 1351f, 1514f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 5, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("CameraFilterPack/TV_ARCADE_Fast", temporary2);
			this.HAOKALKHGJI.SetFloat("settings.shaders.bloomintencity", this.intensity);
			this.HAOKALKHGJI.SetFloat("MusicFileSelector", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x002816D0 File Offset: 0x0027F8D0
		private void IFPOOKJLOJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 6, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 5, height / 8, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("</color>", new Vector4(1505f, this.blurSpread * 1580f / (float)temporary2.height, 95f, 1594f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 5, height / 8, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("Object ID. Case-Sensitive", new Vector4(this.blurSpread * 1480f / (float)temporary2.width, 161f, 1301f, 1114f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 1, 0);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("Chat", temporary2);
			this.HAOKALKHGJI.SetFloat(".lastCheckpoint.penaltyScore", this.intensity);
			this.HAOKALKHGJI.SetFloat("_Value2", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x00281830 File Offset: 0x0027FA30
		public virtual bool FKHOCKAEMLD()
		{
			base.NPOEJIDLJGK(true);
			this.HAOKALKHGJI = base.NODBMINMALP(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x0028188C File Offset: 0x0027FA8C
		public virtual bool MPJAPLPIDMG()
		{
			base.DHHGCBANGJL(false);
			this.HAOKALKHGJI = base.EDFIBHNHAAB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.GJKHKCOAFDB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x002818E8 File Offset: 0x0027FAE8
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 6, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("#news", new Vector4(1379f, this.blurSpread * 1659f / (float)temporary2.height, 1862f, 1959f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 0, height / 7, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Threshhold", new Vector4(this.blurSpread * 1296f / (float)temporary2.width, 1028f, 243f, 1008f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 8, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture(" ", temporary2);
			this.HAOKALKHGJI.SetFloat("MouseY", this.intensity);
			this.HAOKALKHGJI.SetFloat("CameraFilterPack/Blend2Camera_Luminosity", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x00281A48 File Offset: 0x0027FC48
		public virtual bool BMCAJHFDDAF()
		{
			base.JOMCJOEOLHP(false);
			this.HAOKALKHGJI = base.KDHKHOHMKCG(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.NODBMINMALP(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x00281AA4 File Offset: 0x0027FCA4
		public virtual bool APBDJCHNNEH()
		{
			base.KHNPMDDIJAJ(true);
			this.HAOKALKHGJI = base.AJKPGPKKHHB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x00281B00 File Offset: 0x0027FD00
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 7, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 1, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_Value", new Vector4(453f, this.blurSpread * 521f / (float)temporary2.height, 560f, 791f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 5, height / 0, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Value2", new Vector4(this.blurSpread * 775f / (float)temporary2.width, 1465f, 1281f, 431f));
			temporary2 = RenderTexture.GetTemporary(width / 0, height / 0, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("CameraFilterPack/Distortion_Heat", temporary2);
			this.HAOKALKHGJI.SetFloat("set id", this.intensity);
			this.HAOKALKHGJI.SetFloat("Error: you cannot read this stream that you are writing!", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x00281C60 File Offset: 0x0027FE60
		public virtual bool OANEEBGKMGK()
		{
			base.IBFDMKMOBCA(true);
			this.HAOKALKHGJI = base.ECNEGNMAMDE(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.LKIJNGDHLAK(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x00281CBC File Offset: 0x0027FEBC
		public virtual bool EJIGOLAIMHP()
		{
			base.DHHGCBANGJL(true);
			this.HAOKALKHGJI = base.LKIJNGDHLAK(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00281D18 File Offset: 0x0027FF18
		public virtual bool INLAOCGPPLA()
		{
			base.DCHKKHDGBLJ(true);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.ECNEGNMAMDE(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x00281D74 File Offset: 0x0027FF74
		public virtual bool MPMLKLHMPJH()
		{
			base.IHMNPAHGNFF(true);
			this.HAOKALKHGJI = base.GJKHKCOAFDB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.EDFIBHNHAAB(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x00281DF0 File Offset: 0x0027FFF0
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 2, 0);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 7, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("_ScreenResolution", new Vector4(1731f, this.blurSpread * 1499f / (float)temporary2.height, 1420f, 1654f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 0, 0);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("_Distortion", new Vector4(this.blurSpread * 1863f / (float)temporary2.width, 968f, 1219f, 1750f));
			temporary2 = RenderTexture.GetTemporary(width / 1, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("_EmissionColor", temporary2);
			this.HAOKALKHGJI.SetFloat("[FileSelector] Dialog canceled", this.intensity);
			this.HAOKALKHGJI.SetFloat("_ScreenResolution", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x00281F50 File Offset: 0x00280150
		private void JKMBDBCDJAL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 6, 1);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 5, height / 6, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.PEADOJLDHBK.SetVector("]", new Vector4(147f, this.blurSpread * 220f / (float)temporary2.height, 983f, 1979f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 5, height / 4, 1);
			Graphics.Blit(temporary2, temporary3, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary2);
			this.PEADOJLDHBK.SetVector("[LocalizationService] Error: ", new Vector4(this.blurSpread * 870f / (float)temporary2.width, 402f, 1679f, 696f));
			temporary2 = RenderTexture.GetTemporary(width / 0, height / 2, 1);
			Graphics.Blit(temporary3, temporary2, this.PEADOJLDHBK);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HAOKALKHGJI.SetTexture("/?player=", temporary2);
			this.HAOKALKHGJI.SetFloat("LevelInfoInputField", this.intensity);
			this.HAOKALKHGJI.SetFloat("_Value3", this.threshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HAOKALKHGJI);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x002820B0 File Offset: 0x002802B0
		public virtual bool FCMEACDKKED()
		{
			base.IHMNPAHGNFF(true);
			this.HAOKALKHGJI = base.EDFIBHNHAAB(this.contrastCompositeShader, this.HAOKALKHGJI);
			this.PEADOJLDHBK = base.KDHKHOHMKCG(this.separableBlurShader, this.PEADOJLDHBK);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000D88 RID: 3464
		[Range(0f, 1f)]
		public float intensity = 0.5f;

		// Token: 0x04000D89 RID: 3465
		[Range(0f, 0.999f)]
		public float threshold;

		// Token: 0x04000D8A RID: 3466
		private Material PEADOJLDHBK;

		// Token: 0x04000D8B RID: 3467
		private Material HAOKALKHGJI;

		// Token: 0x04000D8C RID: 3468
		[Range(0f, 1f)]
		public float blurSpread = 1f;

		// Token: 0x04000D8D RID: 3469
		public Shader separableBlurShader;

		// Token: 0x04000D8E RID: 3470
		public Shader contrastCompositeShader;
	}
}
