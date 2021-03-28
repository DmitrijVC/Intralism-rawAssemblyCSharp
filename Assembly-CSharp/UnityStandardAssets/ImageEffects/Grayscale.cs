using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001E6 RID: 486
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		// Token: 0x06007D4B RID: 32075 RVA: 0x002999B9 File Offset: 0x00297BB9
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CBCNOEIALHB().SetTexture("GlassAberration", this.textureRamp);
			base.OIBHFCLJKDB().SetFloat("OpAuthenticate()", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKGAONMOBMH());
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x002999F4 File Offset: 0x00297BF4
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEINDEMCGIK().SetTexture("_TimeX", this.textureRamp);
			base.CBCNOEIALHB().SetFloat("CameraFilterPack/Drawing_Manga3", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DONENAMLFLF());
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x00299A2F File Offset: 0x00297C2F
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NBPKMLMCHFN.SetTexture("_RampTex", this.textureRamp);
			base.NBPKMLMCHFN.SetFloat("_RampOffset", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00299A6A File Offset: 0x00297C6A
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HHIFMIPPMPF().SetTexture("Updating...", this.textureRamp);
			base.NJDIODJNGGA().SetFloat("LoadPlayerEnvironment", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.PGPEMMBJOOG());
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x00299AA5 File Offset: 0x00297CA5
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EMDFHOKEGNG().SetTexture("_TimeX", this.textureRamp);
			base.LDNADDJMIPK().SetFloat("_TimeX", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.ABHDNGIHBKE());
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x00299AE0 File Offset: 0x00297CE0
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DNLMFEGJJDD().SetTexture("_Value2", this.textureRamp);
			base.HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_Color", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FLGPDBBKAIP());
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x00299B1B File Offset: 0x00297D1B
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.PGPEMMBJOOG().SetTexture("[LevelEditorScene] Error: I/O Failure! :(", this.textureRamp);
			base.IIBLJCKLGFG().SetFloat(" ", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NLFJGMBCICG());
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x00299B56 File Offset: 0x00297D56
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LEIAFCPJMDP().SetTexture("LivesSlider", this.textureRamp);
			base.JFDGLLEOPGB().SetFloat("Did not read byte array properly", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LEIAFCPJMDP());
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x00299B91 File Offset: 0x00297D91
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LDNADDJMIPK().SetTexture("_BilateralUpsampling", this.textureRamp);
			base.NFMGLIKNOOC().SetFloat("#onfirstranktext", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.BAGICADFBAB());
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x00299BCC File Offset: 0x00297DCC
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IGKFMCPDNOI().SetTexture("_TargetScale", this.textureRamp);
			base.FOOCJIDNGBB().SetFloat("CameraFilterPack/Blend2Camera_Divide", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CIAFLBFJLEJ());
		}

		// Token: 0x06007D55 RID: 32085 RVA: 0x00299C07 File Offset: 0x00297E07
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.JFDGLLEOPGB().SetTexture("CameraFilterPack/Colors_Adjust_ColorRGB", this.textureRamp);
			base.OIBHFCLJKDB().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKHBBBFLGJH());
		}

		// Token: 0x06007D56 RID: 32086 RVA: 0x00299C42 File Offset: 0x00297E42
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EJDPNJAEAKJ().SetTexture("_TexelOffsetScale", this.textureRamp);
			base.HHIFMIPPMPF().SetFloat("Set Satellite Emission", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NLFJGMBCICG());
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x00299C7D File Offset: 0x00297E7D
		private void HLAIEDEHIBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DONENAMLFLF().SetTexture("setbool", this.textureRamp);
			base.MCDGIILBNIF().SetFloat("_CenterY", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NJDIODJNGGA());
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x00299CB8 File Offset: 0x00297EB8
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GCDFNHMJMIP().SetTexture("LoadPlayerSkin", this.textureRamp);
			base.LMLENGFLEBD().SetFloat("_HitPointTexture", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CIAFLBFJLEJ());
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x00299CF3 File Offset: 0x00297EF3
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LMLENGFLEBD().SetTexture("\" gets executed locally only, if at all.", this.textureRamp);
			base.AELJLBOJAIL().SetFloat("_FarCamera", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FGENHBKMPDA());
		}

		// Token: 0x06007D5A RID: 32090 RVA: 0x00299D2E File Offset: 0x00297F2E
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.JFDGLLEOPGB().SetTexture("_Value3", this.textureRamp);
			base.IGKFMCPDNOI().SetFloat("FToA", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MCDGIILBNIF());
		}

		// Token: 0x06007D5B RID: 32091 RVA: 0x00299D69 File Offset: 0x00297F69
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IIBLJCKLGFG().SetTexture("Updating...", this.textureRamp);
			base.DNLMFEGJJDD().SetFloat("_TimeX", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FOOCJIDNGBB());
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x00299DA4 File Offset: 0x00297FA4
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HHIFMIPPMPF().SetTexture("_Blue_B", this.textureRamp);
			base.EPCGJFCCAFH().SetFloat("RECORD [R]", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FLGPDBBKAIP());
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x00299DDF File Offset: 0x00297FDF
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NFMGLIKNOOC().SetTexture("mapselector.lastSearch", this.textureRamp);
			base.LEIAFCPJMDP().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x00299E1A File Offset: 0x0029801A
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CFCPHFMKHII().SetTexture("[ItemsHandler] All in-game items loaded", this.textureRamp);
			base.MCDGIILBNIF().SetFloat("Anomaly_Near", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LEIAFCPJMDP());
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x00299E55 File Offset: 0x00298055
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LEIAFCPJMDP().SetTexture("_Glitch", this.textureRamp);
			base.GJHPODJOBHL().SetFloat("Hidden/DepthOfField/BokehSplatting", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LEIAFCPJMDP());
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x00299E90 File Offset: 0x00298090
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LEIAFCPJMDP().SetTexture("Tab1Content", this.textureRamp);
			base.GCDFNHMJMIP().SetFloat("_Value3", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GJHLADDCMFF());
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x00299ECB File Offset: 0x002980CB
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NJDIODJNGGA().SetTexture("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", this.textureRamp);
			base.NFMGLIKNOOC().SetFloat("Fill Area", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EPCGJFCCAFH());
		}

		// Token: 0x06007D63 RID: 32099 RVA: 0x00299F06 File Offset: 0x00298106
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.PGPEMMBJOOG().SetTexture(". Set PhotonNetwork.OnEventCall.", this.textureRamp);
			base.FOOCJIDNGBB().SetFloat("GridDataArcs", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DNLMFEGJJDD());
		}

		// Token: 0x06007D64 RID: 32100 RVA: 0x00299F41 File Offset: 0x00298141
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IIJMIPBMMBF().SetTexture(",", this.textureRamp);
			base.NFMGLIKNOOC().SetFloat("SetCrosshairEmission", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NJDIODJNGGA());
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x00299F7C File Offset: 0x0029817C
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GJHPODJOBHL().SetTexture("_TimeX", this.textureRamp);
			base.GCDFNHMJMIP().SetFloat("#no", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x00299FB7 File Offset: 0x002981B7
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.PGPEMMBJOOG().SetTexture("/", this.textureRamp);
			base.LDNADDJMIPK().SetFloat("mapselector.filter.favoriteonly", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKHBBBFLGJH());
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x00299FF2 File Offset: 0x002981F2
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEINDEMCGIK().SetTexture("#ok", this.textureRamp);
			base.OKJOKHGJHGF().SetFloat("_Fade", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CBCNOEIALHB());
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x0029A02D File Offset: 0x0029822D
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEHKGPKLAKK().SetTexture("Mouse Wheel Up", this.textureRamp);
			base.EJDPNJAEAKJ().SetFloat("_Value8", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LDNADDJMIPK());
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x0029A068 File Offset: 0x00298268
		private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NFMGLIKNOOC().SetTexture("player.yellowarc", this.textureRamp);
			base.OIBHFCLJKDB().SetFloat(".g", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LEIAFCPJMDP());
		}

		// Token: 0x06007D6A RID: 32106 RVA: 0x0029A0A3 File Offset: 0x002982A3
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CBCNOEIALHB().SetTexture("_Value", this.textureRamp);
			base.OOMFJGPAOKL().SetFloat("_Value", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FLGPDBBKAIP());
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x0029A0DE File Offset: 0x002982DE
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CBCNOEIALHB().SetTexture("Joystick1Button9", this.textureRamp);
			base.OOMFJGPAOKL().SetFloat("[PlayerController] ", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MICHFGAOPKM());
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x0029A119 File Offset: 0x00298319
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CECICEGFHKL().SetTexture("/", this.textureRamp);
			base.JFDGLLEOPGB().SetFloat("_Value", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DONENAMLFLF());
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x0029A154 File Offset: 0x00298354
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.MICHFGAOPKM().SetTexture("_ScreenResolution", this.textureRamp);
			base.IIJMIPBMMBF().SetFloat("CameraFilterPack_WaterDrop", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x06007D6E RID: 32110 RVA: 0x0029A18F File Offset: 0x0029838F
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GJHPODJOBHL().SetTexture("_ReflectionBufferSize", this.textureRamp);
			base.IGIAPKPKGPK().SetFloat(": ", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OLHDPICFBOF());
		}

		// Token: 0x06007D6F RID: 32111 RVA: 0x0029A1CA File Offset: 0x002983CA
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DONENAMLFLF().SetTexture("_Value", this.textureRamp);
			base.DONENAMLFLF().SetFloat("_TimeX", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NLFJGMBCICG());
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x0029A205 File Offset: 0x00298405
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEHKGPKLAKK().SetTexture("CheckpointsScoreText", this.textureRamp);
			base.IIJMIPBMMBF().SetFloat("_BlurCoe", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x0029A240 File Offset: 0x00298440
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.FOOCJIDNGBB().SetTexture("Set sun beat detection sensitivity", this.textureRamp);
			base.HHIFMIPPMPF().SetFloat("id", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OKJOKHGJHGF());
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x0029A27B File Offset: 0x0029847B
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IIJMIPBMMBF().SetTexture("Couldn't call DestroyAll() as only the master client is allowed to call this.", this.textureRamp);
			base.AELJLBOJAIL().SetFloat("Error! no audio sources attached to AudioSampler.css", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OOMFJGPAOKL());
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x0029A2B6 File Offset: 0x002984B6
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DNLMFEGJJDD().SetTexture("<scene_name> or <id>", this.textureRamp);
			base.IGIAPKPKGPK().SetFloat("_Noise", this.rampOffset);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.AELJLBOJAIL());
		}

		// Token: 0x04000E1D RID: 3613
		public Texture textureRamp;

		// Token: 0x04000E1E RID: 3614
		[Range(-1f, 1f)]
		public float rampOffset;
	}
}
