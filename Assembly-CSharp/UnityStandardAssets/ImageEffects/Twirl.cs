using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001FF RID: 511
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	[ExecuteInEditMode]
	public class Twirl : ImageEffectBase
	{
		// Token: 0x060081CD RID: 33229 RVA: 0x002C814E File Offset: 0x002C634E
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.LMBLCDOJBLB(base.AELJLBOJAIL(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x002C816F File Offset: 0x002C636F
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.LMBLCDOJBLB(base.NJDIODJNGGA(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x002C8190 File Offset: 0x002C6390
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.KHOCEDHFNEA(base.JFDGLLEOPGB(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x002C81B1 File Offset: 0x002C63B1
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.RenderDistortion(base.LDNADDJMIPK(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x002C81D2 File Offset: 0x002C63D2
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.KHOCEDHFNEA(base.HKGAONMOBMH(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x002C81F3 File Offset: 0x002C63F3
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.AGPIKDLFPAP(base.IIJMIPBMMBF(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x002C8214 File Offset: 0x002C6414
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.RenderDistortion(base.LMLENGFLEBD(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x002C8235 File Offset: 0x002C6435
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.BNLBLAACADN(base.FLGPDBBKAIP(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x002C8293 File Offset: 0x002C6493
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.LMBLCDOJBLB(base.LEIAFCPJMDP(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x002C82B4 File Offset: 0x002C64B4
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.PDONJBPKJNM(base.LDNADDJMIPK(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x002C82D5 File Offset: 0x002C64D5
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.AGPIKDLFPAP(base.DONENAMLFLF(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x002C82F6 File Offset: 0x002C64F6
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.HFNMMNANFFA(base.NFMGLIKNOOC(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x002C8317 File Offset: 0x002C6517
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.RenderDistortion(base.NBPKMLMCHFN, HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x002C8338 File Offset: 0x002C6538
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.BNLBLAACADN(base.LEIAFCPJMDP(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x002C8359 File Offset: 0x002C6559
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			ImageEffects.GHFCOJLPJJO(base.MICHFGAOPKM(), HLBKCLPNHEB, BMMLHGHKBNM, this.angle, this.center, this.radius);
		}

		// Token: 0x04000EB1 RID: 3761
		public Vector2 radius = new Vector2(0.3f, 0.3f);

		// Token: 0x04000EB2 RID: 3762
		[Range(0f, 360f)]
		public float angle = 50f;

		// Token: 0x04000EB3 RID: 3763
		public Vector2 center = new Vector2(0.5f, 0.5f);
	}
}
