using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001EF RID: 495
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ScreenOverlay : PostEffectsBase
	{
		// Token: 0x06008038 RID: 32824 RVA: 0x002B3CF8 File Offset: 0x002B1EF8
		private void CACIIEMMMHG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1111f, 1524f, 197f, 1238f);
			this.NEGMLOMOCGO.SetVector("_TimeX", value);
			this.NEGMLOMOCGO.SetFloat(".highscore", this.intensity);
			this.NEGMLOMOCGO.SetTexture("#", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x002B3D84 File Offset: 0x002B1F84
		private void HJGNJDAADGP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(394f, 1616f, 399f, 1790f);
			this.NEGMLOMOCGO.SetVector("_Value", value);
			this.NEGMLOMOCGO.SetFloat("float", this.intensity);
			this.NEGMLOMOCGO.SetTexture("\r", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x002B3E0F File Offset: 0x002B200F
		public virtual bool BCDIEBGNBEG()
		{
			base.LMEBEGFJGEM(false);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x002B3E48 File Offset: 0x002B2048
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1750f, 841f, 1116f, 961f);
			this.NEGMLOMOCGO.SetVector("_Distortion", value);
			this.NEGMLOMOCGO.SetFloat("_ScreenResolution", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_Noise", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x002B3ED3 File Offset: 0x002B20D3
		public virtual bool GCLELPIDOCM()
		{
			base.DHHGCBANGJL(true);
			this.NEGMLOMOCGO = base.AJKPGPKKHHB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x002B3F0C File Offset: 0x002B210C
		public virtual bool PHJJGBHNECJ()
		{
			base.CKIAMHAKJOK(false);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x002B3F45 File Offset: 0x002B2145
		public virtual bool GMFKDOKAOPO()
		{
			base.JOMCJOEOLHP(false);
			this.NEGMLOMOCGO = base.AJKPGPKKHHB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x002B3F7E File Offset: 0x002B217E
		public virtual bool CIDNHACINGF()
		{
			base.LMEBEGFJGEM(true);
			this.NEGMLOMOCGO = base.ECNEGNMAMDE(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x002B3FB7 File Offset: 0x002B21B7
		public virtual bool MPMLKLHMPJH()
		{
			base.IHMNPAHGNFF(true);
			this.NEGMLOMOCGO = base.KDHKHOHMKCG(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x002B3FF0 File Offset: 0x002B21F0
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(614f, 826f, 1102f, 1206f);
			this.NEGMLOMOCGO.SetVector("_ScreenResolution", value);
			this.NEGMLOMOCGO.SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this.intensity);
			this.NEGMLOMOCGO.SetTexture("return CheckCondition()", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x002B407C File Offset: 0x002B227C
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1836f, 420f, 1110f, 92f);
			this.NEGMLOMOCGO.SetVector("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", value);
			this.NEGMLOMOCGO.SetFloat("]", this.intensity);
			this.NEGMLOMOCGO.SetTexture("skin.no_hit", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x002B4108 File Offset: 0x002B2308
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1687f, 257f, 905f, 1579f);
			this.NEGMLOMOCGO.SetVector("PerfectHitsScoreText", value);
			this.NEGMLOMOCGO.SetFloat("_ScreenResolution", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_TimeX", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x002B4194 File Offset: 0x002B2394
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1325f, 1106f, 652f, 1571f);
			this.NEGMLOMOCGO.SetVector("player.redlifering", value);
			this.NEGMLOMOCGO.SetFloat("#activechallenges", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_ScreenResolution", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x002B4220 File Offset: 0x002B2420
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1053f, 211f, 984f, 1496f);
			this.NEGMLOMOCGO.SetVector("Tab1Content", value);
			this.NEGMLOMOCGO.SetFloat("_Offsets", this.intensity);
			this.NEGMLOMOCGO.SetTexture("\\\"", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x002B42AB File Offset: 0x002B24AB
		public virtual bool HBNCKBEPKGF()
		{
			base.KHNPMDDIJAJ(true);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x002B42E4 File Offset: 0x002B24E4
		private void JKAKHLNPNNP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1937f, 561f, 1917f, 766f);
			this.NEGMLOMOCGO.SetVector("_Value7", value);
			this.NEGMLOMOCGO.SetFloat("_Visualize", this.intensity);
			this.NEGMLOMOCGO.SetTexture("Vignette", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x002B436F File Offset: 0x002B256F
		public virtual bool EAOFDBCPJDI()
		{
			base.LMEBEGFJGEM(true);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x002B43A8 File Offset: 0x002B25A8
		private void GAANDCGCBHF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(959f, 1776f, 1795f, 33f);
			this.NEGMLOMOCGO.SetVector("_Value", value);
			this.NEGMLOMOCGO.SetFloat("Noise shaders are not set up! Disabling noise effect.", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_Amount", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x002B4433 File Offset: 0x002B2633
		public virtual bool HPEEHNKLIJD()
		{
			base.LMEBEGFJGEM(true);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x002B446C File Offset: 0x002B266C
		public virtual bool NHCNNDEHICD()
		{
			base.FNIFJAENDIB(false);
			this.NEGMLOMOCGO = base.ECNEGNMAMDE(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600804C RID: 32844 RVA: 0x002B44A8 File Offset: 0x002B26A8
		private void JKMBDBCDJAL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(795f, 92f, 1190f, 1484f);
			this.NEGMLOMOCGO.SetVector("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", value);
			this.NEGMLOMOCGO.SetFloat(" cannot be used as a 3D LUT.", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_Value", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600804D RID: 32845 RVA: 0x002B4533 File Offset: 0x002B2733
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.NEGMLOMOCGO = base.EDFIBHNHAAB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x002B456C File Offset: 0x002B276C
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1843f, 4f, 167f, 1572f);
			this.NEGMLOMOCGO.SetVector("EnableRankingToggle", value);
			this.NEGMLOMOCGO.SetFloat("Aug", this.intensity);
			this.NEGMLOMOCGO.SetTexture("z", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x002B45F7 File Offset: 0x002B27F7
		public virtual bool BKCNDIBNLNB()
		{
			base.IBFDMKMOBCA(false);
			this.NEGMLOMOCGO = base.GJKHKCOAFDB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008050 RID: 32848 RVA: 0x002B4630 File Offset: 0x002B2830
		public virtual bool BKEJKJKFLGD()
		{
			base.JOMCJOEOLHP(false);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x002B466C File Offset: 0x002B286C
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1f, 0f, 0f, 1f);
			this.NEGMLOMOCGO.SetVector("_UV_Transform", value);
			this.NEGMLOMOCGO.SetFloat("_Intensity", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_Overlay", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x002B46F7 File Offset: 0x002B28F7
		public override bool PFIELBMLHJK()
		{
			base.JOMCJOEOLHP(true);
			this.NEGMLOMOCGO = base.AJKPGPKKHHB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x002B4730 File Offset: 0x002B2930
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(518f, 1250f, 938f, 733f);
			this.NEGMLOMOCGO.SetVector(". Using max value: 255.", value);
			this.NEGMLOMOCGO.SetFloat("stretchWidth", this.intensity);
			this.NEGMLOMOCGO.SetTexture("scn", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x002B47BB File Offset: 0x002B29BB
		public virtual bool HDDNBPJGGFK()
		{
			base.MBMLNJJEONO(true);
			this.NEGMLOMOCGO = base.EDFIBHNHAAB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x002B47F4 File Offset: 0x002B29F4
		private void HCOGCFOBBMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(585f, 1204f, 870f, 81f);
			this.NEGMLOMOCGO.SetVector("x", value);
			this.NEGMLOMOCGO.SetFloat("time", this.intensity);
			this.NEGMLOMOCGO.SetTexture("maps.", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x002B4880 File Offset: 0x002B2A80
		private void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(288f, 606f, 846f, 1399f);
			this.NEGMLOMOCGO.SetVector("type", value);
			this.NEGMLOMOCGO.SetFloat("_Value2", this.intensity);
			this.NEGMLOMOCGO.SetTexture("0,7,true,0", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x002B490C File Offset: 0x002B2B0C
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1587f, 1636f, 1321f, 1803f);
			this.NEGMLOMOCGO.SetVector("LeaderboardsButton", value);
			this.NEGMLOMOCGO.SetFloat(".", this.intensity);
			this.NEGMLOMOCGO.SetTexture("mapselector.filter.favoriteonly", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x002B4997 File Offset: 0x002B2B97
		public override bool LPDGLHPMDLB()
		{
			base.KHNPMDDIJAJ(false);
			this.NEGMLOMOCGO = base.ECNEGNMAMDE(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x002B49D0 File Offset: 0x002B2BD0
		public virtual bool HKJMEHGPPMC()
		{
			base.IHMNPAHGNFF(false);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x002B4A09 File Offset: 0x002B2C09
		public virtual bool AMKCNLBKLDJ()
		{
			base.JOMCJOEOLHP(false);
			this.NEGMLOMOCGO = base.EDFIBHNHAAB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x002B4A44 File Offset: 0x002B2C44
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1708f, 1807f, 1844f, 810f);
			this.NEGMLOMOCGO.SetVector("Sprite", value);
			this.NEGMLOMOCGO.SetFloat("BitsData", this.intensity);
			this.NEGMLOMOCGO.SetTexture("Event Received", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x002B4AD0 File Offset: 0x002B2CD0
		private void JCCIHFMBFJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1597f, 1372f, 300f, 160f);
			this.NEGMLOMOCGO.SetVector("Left", value);
			this.NEGMLOMOCGO.SetFloat("settings.volume.editor", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_Distortion", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x002B4B5B File Offset: 0x002B2D5B
		public virtual bool DPFJOPGMFHN()
		{
			base.IBFDMKMOBCA(false);
			this.NEGMLOMOCGO = base.KDHKHOHMKCG(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x002B4B94 File Offset: 0x002B2D94
		private void IEJCEFENLOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(974f, 269f, 1189f, 1531f);
			this.NEGMLOMOCGO.SetVector("_MainTex2", value);
			this.NEGMLOMOCGO.SetFloat("[PlayerBase] Loading checkpoint data", this.intensity);
			this.NEGMLOMOCGO.SetTexture("[LocalizationService] Localization: ", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x002B4C1F File Offset: 0x002B2E1F
		public virtual bool NOABPEFKKHK()
		{
			base.NPOEJIDLJGK(true);
			this.NEGMLOMOCGO = base.GJKHKCOAFDB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x002B4C58 File Offset: 0x002B2E58
		private void HGJJPACDBEP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(286f, 1361f, 990f, 416f);
			this.NEGMLOMOCGO.SetVector("EventSystem", value);
			this.NEGMLOMOCGO.SetFloat("ViewMenu", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_Value3", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x002B4CE3 File Offset: 0x002B2EE3
		public virtual bool OBEFMKGPJLI()
		{
			base.IHMNPAHGNFF(false);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x002B4D1C File Offset: 0x002B2F1C
		public virtual bool KIELKBGLNKO()
		{
			base.FNIFJAENDIB(false);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x002B4D55 File Offset: 0x002B2F55
		public virtual bool INLAOCGPPLA()
		{
			base.FNIFJAENDIB(true);
			this.NEGMLOMOCGO = base.GJKHKCOAFDB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x002B4D8E File Offset: 0x002B2F8E
		public virtual bool JFFKKNHBANB()
		{
			base.CKIAMHAKJOK(false);
			this.NEGMLOMOCGO = base.ECNEGNMAMDE(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x002B4DC7 File Offset: 0x002B2FC7
		public override bool ILMGHBFANON()
		{
			base.KNGDKKMDKOG(true);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008066 RID: 32870 RVA: 0x002B4E00 File Offset: 0x002B3000
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1726f, 2f, 193f, 1220f);
			this.NEGMLOMOCGO.SetVector("#getrewardfailed: ", value);
			this.NEGMLOMOCGO.SetFloat("Fade", this.intensity);
			this.NEGMLOMOCGO.SetTexture("[GameScene] Events count: ", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x002B4E8C File Offset: 0x002B308C
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1301f, 1148f, 1728f, 186f);
			this.NEGMLOMOCGO.SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", value);
			this.NEGMLOMOCGO.SetFloat("sfxVolume", this.intensity);
			this.NEGMLOMOCGO.SetTexture("grid", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x002B4F18 File Offset: 0x002B3118
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1018f, 1430f, 887f, 1065f);
			this.NEGMLOMOCGO.SetVector("colorB", value);
			this.NEGMLOMOCGO.SetFloat("_NoiseAmount", this.intensity);
			this.NEGMLOMOCGO.SetTexture(".ogg", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x002B4FA4 File Offset: 0x002B31A4
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(28f, 789f, 1464f, 1277f);
			this.NEGMLOMOCGO.SetVector("_Distance", value);
			this.NEGMLOMOCGO.SetFloat("_EmissionColor", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_ScreenResolution", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x002B502F File Offset: 0x002B322F
		public virtual bool LPDMNDMCPCO()
		{
			base.DCHKKHDGBLJ(false);
			this.NEGMLOMOCGO = base.KDHKHOHMKCG(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x002B5068 File Offset: 0x002B3268
		private void HLAIEDEHIBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(425f, 379f, 1995f, 358f);
			this.NEGMLOMOCGO.SetVector("CameraFilterPack/Drawing_Paper2", value);
			this.NEGMLOMOCGO.SetFloat("_ScreenResolution", this.intensity);
			this.NEGMLOMOCGO.SetTexture("Curve texture", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x002B50F4 File Offset: 0x002B32F4
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(944f, 1575f, 977f, 622f);
			this.NEGMLOMOCGO.SetVector("Unknown player asked for PickupItems", value);
			this.NEGMLOMOCGO.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_EdgeSharpness", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x002B5180 File Offset: 0x002B3380
		private void GHILGJJEAOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1354f, 642f, 922f, 609f);
			this.NEGMLOMOCGO.SetVector("achievements.21.completed.workshop.", value);
			this.NEGMLOMOCGO.SetFloat("Received RPC: ", this.intensity);
			this.NEGMLOMOCGO.SetTexture("Save the map before exiting?", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x002B520B File Offset: 0x002B340B
		public override bool OEECIHEGJHE()
		{
			base.DHHGCBANGJL(true);
			this.NEGMLOMOCGO = base.EDFIBHNHAAB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x002B5244 File Offset: 0x002B3444
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1567f, 842f, 16f, 243f);
			this.NEGMLOMOCGO.SetVector("CameraFilterPack/Deep_OilPaintHQ", value);
			this.NEGMLOMOCGO.SetFloat("x", this.intensity);
			this.NEGMLOMOCGO.SetTexture("RenderTextureUtilityTempTexture", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x002B52CF File Offset: 0x002B34CF
		public virtual bool BMCAJHFDDAF()
		{
			base.LMEBEGFJGEM(false);
			this.NEGMLOMOCGO = base.EDFIBHNHAAB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x002B5308 File Offset: 0x002B3508
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(188f, 1802f, 1319f, 1301f);
			this.NEGMLOMOCGO.SetVector("Tab1Content", value);
			this.NEGMLOMOCGO.SetFloat("CameraFilterPack/Glasses_On", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_Value4", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x002B5394 File Offset: 0x002B3594
		private void ABOJKHKBJLN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(414f, 652f, 571f, 1038f);
			this.NEGMLOMOCGO.SetVector("_TimeX", value);
			this.NEGMLOMOCGO.SetFloat(",", this.intensity);
			this.NEGMLOMOCGO.SetTexture("CameraFilterPack/Blend2Camera_LighterColor", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x002B541F File Offset: 0x002B361F
		public virtual bool LGFMJDPKOOM()
		{
			base.LMEBEGFJGEM(false);
			this.NEGMLOMOCGO = base.ECNEGNMAMDE(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x002B5458 File Offset: 0x002B3658
		public virtual bool HBBIDMLLFFD()
		{
			base.MBMLNJJEONO(true);
			this.NEGMLOMOCGO = base.AJKPGPKKHHB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x002B5491 File Offset: 0x002B3691
		public virtual bool JIJIMMICLAM()
		{
			base.KNGDKKMDKOG(true);
			this.NEGMLOMOCGO = base.GJKHKCOAFDB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x002B54CA File Offset: 0x002B36CA
		public virtual bool ACEIOFMECMD()
		{
			base.CKIAMHAKJOK(false);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008077 RID: 32887 RVA: 0x002B5503 File Offset: 0x002B3703
		public virtual bool NKMDBJOGHDI()
		{
			base.IHMNPAHGNFF(false);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x002B553C File Offset: 0x002B373C
		private void ENGFEPKGEDG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1480f, 1125f, 816f, 151f);
			this.NEGMLOMOCGO.SetVector("Connecting to server", value);
			this.NEGMLOMOCGO.SetFloat("_Value2", this.intensity);
			this.NEGMLOMOCGO.SetTexture("Set EnvSprite Color", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008079 RID: 32889 RVA: 0x002B55C7 File Offset: 0x002B37C7
		public virtual bool JDPOEILHKLC()
		{
			base.NPOEJIDLJGK(false);
			this.NEGMLOMOCGO = base.EDFIBHNHAAB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x002B5600 File Offset: 0x002B3800
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1089f, 383f, 1883f, 1949f);
			this.NEGMLOMOCGO.SetVector("\"", value);
			this.NEGMLOMOCGO.SetFloat("#91CCFF", this.intensity);
			this.NEGMLOMOCGO.SetTexture("...", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600807B RID: 32891 RVA: 0x002B568B File Offset: 0x002B388B
		public virtual bool FEIGCNHEINM()
		{
			base.DCHKKHDGBLJ(true);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x002B56C4 File Offset: 0x002B38C4
		private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1784f, 1460f, 59f, 1422f);
			this.NEGMLOMOCGO.SetVector("StartRound", value);
			this.NEGMLOMOCGO.SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_FlipAlphaMask", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x002B574F File Offset: 0x002B394F
		public virtual bool MPOHEEECMIF()
		{
			base.IBFDMKMOBCA(false);
			this.NEGMLOMOCGO = base.NODBMINMALP(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x002B5788 File Offset: 0x002B3988
		public virtual bool HKEMNPKHLEO()
		{
			base.MBMLNJJEONO(true);
			this.NEGMLOMOCGO = base.GJKHKCOAFDB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008080 RID: 32896 RVA: 0x002B57DB File Offset: 0x002B39DB
		public virtual bool PEAKHOPMBFD()
		{
			base.KNGDKKMDKOG(false);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008081 RID: 32897 RVA: 0x002B5814 File Offset: 0x002B3A14
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1662f, 594f, 1560f, 1650f);
			this.NEGMLOMOCGO.SetVector("[SERVER] Selected map: ", value);
			this.NEGMLOMOCGO.SetFloat(".png", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_ScreenResolution", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008082 RID: 32898 RVA: 0x002B589F File Offset: 0x002B3A9F
		public virtual bool DIAEBALGKAP()
		{
			base.KNGDKKMDKOG(true);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x002B58D8 File Offset: 0x002B3AD8
		private void AFCICEAOBHL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(439f, 380f, 1831f, 887f);
			this.NEGMLOMOCGO.SetVector("FullscreenToggle", value);
			this.NEGMLOMOCGO.SetFloat("workshop.", this.intensity);
			this.NEGMLOMOCGO.SetTexture("Texture2", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x002B5964 File Offset: 0x002B3B64
		private void EMKCNMFNDDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1636f, 1127f, 190f, 53f);
			this.NEGMLOMOCGO.SetVector("violet", value);
			this.NEGMLOMOCGO.SetFloat("Called GetNumberOfCurrentPlayers()", this.intensity);
			this.NEGMLOMOCGO.SetTexture("_PositionX", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x002B59EF File Offset: 0x002B3BEF
		public virtual bool PHEIDFBDELF()
		{
			base.MBMLNJJEONO(true);
			this.NEGMLOMOCGO = base.ECNEGNMAMDE(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x002B5A28 File Offset: 0x002B3C28
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(1377f, 1446f, 1489f, 1884f);
			this.NEGMLOMOCGO.SetVector("Selection Box", value);
			this.NEGMLOMOCGO.SetFloat("PhotonView with ID ", this.intensity);
			this.NEGMLOMOCGO.SetTexture("RoomNameText", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x002B5AB3 File Offset: 0x002B3CB3
		public virtual bool DDLPGIECCLI()
		{
			base.NPOEJIDLJGK(true);
			this.NEGMLOMOCGO = base.LKIJNGDHLAK(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x002B5AEC File Offset: 0x002B3CEC
		public virtual bool GACCMCAGAIJ()
		{
			base.KNGDKKMDKOG(false);
			this.NEGMLOMOCGO = base.AJKPGPKKHHB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008089 RID: 32905 RVA: 0x002B5B28 File Offset: 0x002B3D28
		private void KENMBHKMEFK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector4 value = new Vector4(572f, 400f, 1132f, 1018f);
			this.NEGMLOMOCGO.SetVector("FPSToggle", value);
			this.NEGMLOMOCGO.SetFloat("Right Stick Click", this.intensity);
			this.NEGMLOMOCGO.SetTexture(" or ", this.texture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NEGMLOMOCGO, (int)this.blendMode);
		}

		// Token: 0x0600808A RID: 32906 RVA: 0x002B5BB3 File Offset: 0x002B3DB3
		public virtual bool IILEKDNFOFI()
		{
			base.KNGDKKMDKOG(false);
			this.NEGMLOMOCGO = base.GJKHKCOAFDB(this.overlayShader, this.NEGMLOMOCGO);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000E4D RID: 3661
		public ScreenOverlay.OverlayBlendMode blendMode = ScreenOverlay.OverlayBlendMode.Overlay;

		// Token: 0x04000E4E RID: 3662
		public float intensity = 1f;

		// Token: 0x04000E4F RID: 3663
		public Texture2D texture;

		// Token: 0x04000E50 RID: 3664
		public Shader overlayShader;

		// Token: 0x04000E51 RID: 3665
		private Material NEGMLOMOCGO;

		// Token: 0x020001F0 RID: 496
		public enum OverlayBlendMode
		{
			// Token: 0x04000E53 RID: 3667
			Additive,
			// Token: 0x04000E54 RID: 3668
			ScreenBlend,
			// Token: 0x04000E55 RID: 3669
			Multiply,
			// Token: 0x04000E56 RID: 3670
			Overlay,
			// Token: 0x04000E57 RID: 3671
			AlphaBlend
		}
	}
}
