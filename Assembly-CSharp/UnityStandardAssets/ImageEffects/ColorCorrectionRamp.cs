using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001D6 RID: 470
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	[ExecuteInEditMode]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		// Token: 0x06007B93 RID: 31635 RVA: 0x0027D075 File Offset: 0x0027B275
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NBPKMLMCHFN.SetTexture("_RampTex", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x0027D09A File Offset: 0x0027B29A
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EJDPNJAEAKJ().SetTexture("original.tutorial", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.BAGICADFBAB());
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x0027D0C7 File Offset: 0x0027B2C7
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LEIAFCPJMDP().SetTexture("CameraFilterPack/TV_Chromatical", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x0027D0EC File Offset: 0x0027B2EC
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LEIAFCPJMDP().SetTexture("_PositionX", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MCDGIILBNIF());
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x0027D111 File Offset: 0x0027B311
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.FOOCJIDNGBB().SetTexture("/Assets/MyImage", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MICHFGAOPKM());
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x0027D136 File Offset: 0x0027B336
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NJDIODJNGGA().SetTexture("_Value4", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HEINDEMCGIK());
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x0027D15B File Offset: 0x0027B35B
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CFCPHFMKHII().SetTexture(":\n", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LEIAFCPJMDP());
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x0027D180 File Offset: 0x0027B380
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HKHBBBFLGJH().SetTexture("\\n", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LPPEPKGFOEM());
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x0027D1A5 File Offset: 0x0027B3A5
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GJHPODJOBHL().SetTexture("_PositionX", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKGAONMOBMH());
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x0027D1CA File Offset: 0x0027B3CA
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CIAFLBFJLEJ().SetTexture("{0}", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GJHLADDCMFF());
		}

		// Token: 0x06007B9E RID: 31646 RVA: 0x0027D1EF File Offset: 0x0027B3EF
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CIAFLBFJLEJ().SetTexture("CameraFilterPack/Drawing_Paper", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MCDGIILBNIF());
		}

		// Token: 0x06007B9F RID: 31647 RVA: 0x0027D214 File Offset: 0x0027B414
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEHKGPKLAKK().SetTexture("[SaveSystem] Init from ", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FOOCJIDNGBB());
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x0027D239 File Offset: 0x0027B439
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.MICHFGAOPKM().SetTexture("_Offsets", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MCDGIILBNIF());
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x0027D25E File Offset: 0x0027B45E
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.OLHDPICFBOF().SetTexture(" not exist", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OKJOKHGJHGF());
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x0027D283 File Offset: 0x0027B483
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.FOOCJIDNGBB().SetTexture("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GJHLADDCMFF());
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x0027D2A8 File Offset: 0x0027B4A8
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LPPEPKGFOEM().SetTexture("_Value2", this.textureRamp);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IIJMIPBMMBF());
		}

		// Token: 0x04000D87 RID: 3463
		public Texture textureRamp;
	}
}
