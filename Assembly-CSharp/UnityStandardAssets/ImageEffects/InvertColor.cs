using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000164 RID: 356
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Inver Color")]
	public class InvertColor : ImageEffectBase
	{
		// Token: 0x0600691F RID: 26911 RVA: 0x00208258 File Offset: 0x00206458
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NFMGLIKNOOC().SetFloat("CameraFilterPack/FX_DigitalMatrix", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKHBBBFLGJH());
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x00208290 File Offset: 0x00206490
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CBCNOEIALHB().SetFloat("[PlayerController] ", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x002082B5 File Offset: 0x002064B5
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CFCPHFMKHII().SetFloat("_Value", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LPPEPKGFOEM());
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x002082DA File Offset: 0x002064DA
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.PGPEMMBJOOG().SetFloat("OnSerialize", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FOOCJIDNGBB());
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x002082FF File Offset: 0x002064FF
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IGIAPKPKGPK().SetFloat("BitsData", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EMDFHOKEGNG());
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00208324 File Offset: 0x00206524
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NBPKMLMCHFN.SetFloat("resource id", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DONENAMLFLF());
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x00208349 File Offset: 0x00206549
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HKGAONMOBMH().SetFloat("': ", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.ABHDNGIHBKE());
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x0020836E File Offset: 0x0020656E
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LMLENGFLEBD().SetFloat("---", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HEINDEMCGIK());
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x00208393 File Offset: 0x00206593
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.ABHDNGIHBKE().SetFloat(",", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OOMFJGPAOKL());
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x002083B8 File Offset: 0x002065B8
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GJHPODJOBHL().SetFloat("_Value1", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CBCNOEIALHB());
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x002083DD File Offset: 0x002065DD
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IIBLJCKLGFG().SetFloat("CameraFilterPack/Vision_Aura", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EPCGJFCCAFH());
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00208402 File Offset: 0x00206602
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.JFDGLLEOPGB().SetFloat("GlassesColor2", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HEHKGPKLAKK());
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x00208427 File Offset: 0x00206627
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.FLGPDBBKAIP().SetFloat("Set Particle Size", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CECICEGFHKL());
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x0020844C File Offset: 0x0020664C
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NBPKMLMCHFN.SetFloat("_Value1", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x00208471 File Offset: 0x00206671
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LDNADDJMIPK().SetFloat("x", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NJDIODJNGGA());
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x00208496 File Offset: 0x00206696
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GCDFNHMJMIP().SetFloat("menu.enableselectormusic", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LMLENGFLEBD());
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x002084BB File Offset: 0x002066BB
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NLFJGMBCICG().SetFloat("Tab1Content", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OIBHFCLJKDB());
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x002084E0 File Offset: 0x002066E0
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EMDFHOKEGNG().SetFloat("In Network lobby", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LEIAFCPJMDP());
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x00208505 File Offset: 0x00206705
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LPPEPKGFOEM().SetFloat("0.00", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MCDGIILBNIF());
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x0020852A File Offset: 0x0020672A
		private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GJHPODJOBHL().SetFloat("_DistortionSize", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FLGPDBBKAIP());
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x0020854F File Offset: 0x0020674F
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IGKFMCPDNOI().SetFloat("_Value", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00208574 File Offset: 0x00206774
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EMDFHOKEGNG().SetFloat("X2", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HEINDEMCGIK());
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00208599 File Offset: 0x00206799
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LDNADDJMIPK().SetFloat("/", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EPCGJFCCAFH());
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x002085BE File Offset: 0x002067BE
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GJHLADDCMFF().SetFloat("duration", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NLFJGMBCICG());
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x002085E3 File Offset: 0x002067E3
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEHKGPKLAKK().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x00208608 File Offset: 0x00206808
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.OKJOKHGJHGF().SetFloat("GlassAberration", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.ABHDNGIHBKE());
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x0020862D File Offset: 0x0020682D
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GCDFNHMJMIP().SetFloat("D-Pad Right", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GJHPODJOBHL());
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x00208652 File Offset: 0x00206852
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CBCNOEIALHB().SetFloat("Set Parent", this.intensity);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.PGPEMMBJOOG());
		}

		// Token: 0x04000AE0 RID: 2784
		[Range(0f, 2f)]
		public float intensity = 1f;
	}
}
