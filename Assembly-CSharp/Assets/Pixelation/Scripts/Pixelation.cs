using System;
using Assets.Pixelation.Example.Scripts;
using UnityEngine;

namespace Assets.Pixelation.Scripts
{
	// Token: 0x0200037C RID: 892
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Pixelation")]
	public class Pixelation : ImageEffectBase
	{
		// Token: 0x0600C4B3 RID: 50355 RVA: 0x0047545C File Offset: 0x0047365C
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(418f / v.x, 236f / v.y);
			base.IGKFMCPDNOI().SetVector("_ScreenResolution", v);
			base.NFMGLIKNOOC().SetVector("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IONHGBPGCHK());
		}

		// Token: 0x0600C4B4 RID: 50356 RVA: 0x004754E4 File Offset: 0x004736E4
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(875f / v.x, 1280f / v.y);
			base.GCDFNHMJMIP().SetVector("???", v);
			base.HHIFMIPPMPF().SetVector("[SaveSystem] Outdated savefile found", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IIBLJCKLGFG());
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x0047556C File Offset: 0x0047376C
		private void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1878f / v.x, 107f / v.y);
			base.EFDEIFCDAFG().SetVector("EventSystem", v);
			base.NFMGLIKNOOC().SetVector("Show image from resources by id at the center of the screen at foreground or background", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EFDEIFCDAFG());
		}

		// Token: 0x0600C4B6 RID: 50358 RVA: 0x004755F4 File Offset: 0x004737F4
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(412f / v.x, 622f / v.y);
			base.HCGJCMDJPGD().SetVector("OnStatusChanged: {0} current State: {1}", v);
			base.HCGJCMDJPGD().SetVector("powerup.0", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x0047567C File Offset: 0x0047387C
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1538f / v.x, 1210f / v.y);
			base.GCDFNHMJMIP().SetVector("No Name", v);
			base.EFDEIFCDAFG().SetVector("CameraFilterPack/Pixelisation_OilPaintHQ", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LONNIJMNKFB());
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x00475704 File Offset: 0x00473904
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(912f / v.x, 1339f / v.y);
			base.EFDEIFCDAFG().SetVector("Most likely the game became empty during the switch to GameServer.", v);
			base.PLBEJJIHFPB().SetVector("_BlurredColor", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DNLMFEGJJDD());
		}

		// Token: 0x0600C4BA RID: 50362 RVA: 0x004757A0 File Offset: 0x004739A0
		private void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1855f / v.x, 1187f / v.y);
			base.NBPKMLMCHFN.SetVector("_ScreenResolution", v);
			base.IGKFMCPDNOI().SetVector("/", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MMOODGIODPC());
		}

		// Token: 0x0600C4BB RID: 50363 RVA: 0x00475828 File Offset: 0x00473A28
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(503f / v.x, 1340f / v.y);
			base.HHIFMIPPMPF().SetVector("_TimeX", v);
			base.NFMGLIKNOOC().SetVector("_TimeX", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HFBJAOFLCJI());
		}

		// Token: 0x0600C4BC RID: 50364 RVA: 0x004758B0 File Offset: 0x00473AB0
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1746f / v.x, 738f / v.y);
			base.GKILCDHJFEG().SetVector("[Left]", v);
			base.EFDEIFCDAFG().SetVector("#,0.00", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GKILCDHJFEG());
		}

		// Token: 0x0600C4BD RID: 50365 RVA: 0x00475938 File Offset: 0x00473B38
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(938f / v.x, 319f / v.y);
			base.NFMGLIKNOOC().SetVector("Can't set MaxPlayers when not in that room.", v);
			base.LONNIJMNKFB().SetVector("_ScreenResolution", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HFBJAOFLCJI());
		}

		// Token: 0x0600C4BE RID: 50366 RVA: 0x004759C0 File Offset: 0x00473BC0
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(42f / v.x, 1236f / v.y);
			base.EFDEIFCDAFG().SetVector("[MapsData] Installed: ", v);
			base.PLBEJJIHFPB().SetVector("_ScreenResolution", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x00475A48 File Offset: 0x00473C48
		private void IEJCEFENLOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(254f / v.x, 1312f / v.y);
			base.DNLMFEGJJDD().SetVector("LoadingStatusText", v);
			base.EFDEIFCDAFG().SetVector("PunSupportLogger", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.PLBEJJIHFPB());
		}

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x00475AD0 File Offset: 0x00473CD0
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1390f / v.x, 1998f / v.y);
			base.NBPKMLMCHFN.SetVector("_Value2", v);
			base.DNLMFEGJJDD().SetVector("_BorderSize", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IONHGBPGCHK());
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x00475B58 File Offset: 0x00473D58
		private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1844f / v.x, 1618f / v.y);
			base.HCGJCMDJPGD().SetVector("CameraFilterPack/Drawing_Paper3", v);
			base.HHIFMIPPMPF().SetVector("maps.", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DNLMFEGJJDD());
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x00475BE0 File Offset: 0x00473DE0
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1247f / v.x, 1912f / v.y);
			base.EFDEIFCDAFG().SetVector("[MapsData] Found ", v);
			base.IIBLJCKLGFG().SetVector("_ScreenResolution", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DEFBJOCJJKF());
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x00475C68 File Offset: 0x00473E68
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(547f / v.x, 596f / v.y);
			base.IONHGBPGCHK().SetVector("[SERVER] Kicked ", v);
			base.IIBLJCKLGFG().SetVector("_Threshold", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MMOODGIODPC());
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x00475CF0 File Offset: 0x00473EF0
		private void MMBPPEPNNLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(702f / v.x, 1941f / v.y);
			base.HCGJCMDJPGD().SetVector("&", v);
			base.HHIFMIPPMPF().SetVector("_Distortion", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x00475D78 File Offset: 0x00473F78
		private void IFMHIDNCFFH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(583f / v.x, 479f / v.y);
			base.LONNIJMNKFB().SetVector("_Distance", v);
			base.IGKFMCPDNOI().SetVector("]", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.AELJLBOJAIL());
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x00475E00 File Offset: 0x00474000
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(255f / v.x, 752f / v.y);
			base.DNLMFEGJJDD().SetVector("speed", v);
			base.IONHGBPGCHK().SetVector("[PlayerBase] Loading checkpoint data", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DEFBJOCJJKF());
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x00475E88 File Offset: 0x00474088
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1108f / v.x, 505f / v.y);
			base.HHIFMIPPMPF().SetVector("Message duration multiplier. Recomended 1", v);
			base.NBMPPNFKFLB().SetVector("_MainTex2", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x00475F10 File Offset: 0x00474110
		private void AFCICEAOBHL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1131f / v.x, 233f / v.y);
			base.HHIFMIPPMPF().SetVector("_Blue_G", v);
			base.DEFBJOCJJKF().SetVector("challenges.", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EFDEIFCDAFG());
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x00475F98 File Offset: 0x00474198
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(920f / v.x, 1541f / v.y);
			base.IGKFMCPDNOI().SetVector("offsets", v);
			base.EFDEIFCDAFG().SetVector("_ScreenResolution", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.AELJLBOJAIL());
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x00476020 File Offset: 0x00474220
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1488f / v.x, 1741f / v.y);
			base.IGKFMCPDNOI().SetVector("PLEASE WAIT", v);
			base.PLBEJJIHFPB().SetVector("Left", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x004760A8 File Offset: 0x004742A8
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1636f / v.x, 724f / v.y);
			base.HKGAONMOBMH().SetVector(" is set to dontSave = true, continuing loop.", v);
			base.HCGJCMDJPGD().SetVector("_DiffuseColor", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x00476130 File Offset: 0x00474330
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(679f / v.x, 157f / v.y);
			base.DEFBJOCJJKF().SetVector("HandsCountSlider", v);
			base.GCDFNHMJMIP().SetVector("{0:0} hour{1}, ", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DEFBJOCJJKF());
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x004761B8 File Offset: 0x004743B8
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1232f / v.x, 367f / v.y);
			base.HHIFMIPPMPF().SetVector(": ", v);
			base.HCGJCMDJPGD().SetVector("curScn", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HCGJCMDJPGD());
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x00476240 File Offset: 0x00474440
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(313f / v.x, 1238f / v.y);
			base.HCGJCMDJPGD().SetVector("_Value3", v);
			base.DBOLLHHMKKN().SetVector("_Value2", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HCGJCMDJPGD());
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x004762C8 File Offset: 0x004744C8
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1791f / v.x, 633f / v.y);
			base.NBMPPNFKFLB().SetVector(" while connecting to: ", v);
			base.IGKFMCPDNOI().SetVector("_Visualize", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x00476350 File Offset: 0x00474550
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1361f / v.x, 1241f / v.y);
			base.LONNIJMNKFB().SetVector("_Value", v);
			base.LONNIJMNKFB().SetVector("New SaveGame", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HFBJAOFLCJI());
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x004763D8 File Offset: 0x004745D8
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1597f / v.x, 1804f / v.y);
			base.EFDEIFCDAFG().SetVector("_Exposure", v);
			base.HKGAONMOBMH().SetVector("settings.volume.game", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x0600C4D2 RID: 50386 RVA: 0x00476460 File Offset: 0x00474660
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1f / v.x, 1f / v.y);
			base.NBPKMLMCHFN.SetVector("BlockCount", v);
			base.NBPKMLMCHFN.SetVector("BlockSize", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x004764E8 File Offset: 0x004746E8
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1887f / v.x, 1526f / v.y);
			base.HHIFMIPPMPF().SetVector("_Value4", v);
			base.GCDFNHMJMIP().SetVector("Text", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x00476570 File Offset: 0x00474770
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1371f / v.x, 80f / v.y);
			base.MMOODGIODPC().SetVector("settings.enablehitsoundsinnormal", v);
			base.NFMGLIKNOOC().SetVector("Options", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x004765F8 File Offset: 0x004747F8
		private void HJGNJDAADGP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1869f / v.x, 179f / v.y);
			base.AELJLBOJAIL().SetVector("_Greenness", v);
			base.EFDEIFCDAFG().SetVector("_TileTexDebug", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DEFBJOCJJKF());
		}

		// Token: 0x0600C4D6 RID: 50390 RVA: 0x00476680 File Offset: 0x00474880
		private void JKAKHLNPNNP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1815f / v.x, 1608f / v.y);
			base.HHIFMIPPMPF().SetVector("_Value", v);
			base.HCGJCMDJPGD().SetVector("[DiscordController] Sectate ({0})", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C4D7 RID: 50391 RVA: 0x00476708 File Offset: 0x00474908
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(48f / v.x, 1889f / v.y);
			base.HFBJAOFLCJI().SetVector("menu.selectedplaymode", v);
			base.HHIFMIPPMPF().SetVector("StartButton", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x0600C4D8 RID: 50392 RVA: 0x00476790 File Offset: 0x00474990
		private void HLAIEDEHIBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(23f / v.x, 1622f / v.y);
			base.NFMGLIKNOOC().SetVector("<color=white>", v);
			base.AELJLBOJAIL().SetVector("PUNCloudBestRegion", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x00476818 File Offset: 0x00474A18
		private void ABOJKHKBJLN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1545f / v.x, 1972f / v.y);
			base.PLBEJJIHFPB().SetVector("gold", v);
			base.GKILCDHJFEG().SetVector("_Screen", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C4DA RID: 50394 RVA: 0x004768A0 File Offset: 0x00474AA0
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1564f / v.x, 311f / v.y);
			base.DBOLLHHMKKN().SetVector("_Intensity", v);
			base.GKILCDHJFEG().SetVector("_Value4", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HFBJAOFLCJI());
		}

		// Token: 0x0600C4DB RID: 50395 RVA: 0x00476928 File Offset: 0x00474B28
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(255f / v.x, 1055f / v.y);
			base.EFDEIFCDAFG().SetVector("Cancel", v);
			base.EFDEIFCDAFG().SetVector("_MainTex2", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x0600C4DC RID: 50396 RVA: 0x004769B0 File Offset: 0x00474BB0
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(262f / v.x, 985f / v.y);
			base.GCDFNHMJMIP().SetVector("_Amount", v);
			base.HKGAONMOBMH().SetVector(".progress", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C4DD RID: 50397 RVA: 0x00476A38 File Offset: 0x00474C38
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1523f / v.x, 688f / v.y);
			base.DEFBJOCJJKF().SetVector("open", v);
			base.DEFBJOCJJKF().SetVector("SubmitUserVote:", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C4DE RID: 50398 RVA: 0x00476AC0 File Offset: 0x00474CC0
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1538f / v.x, 85f / v.y);
			base.DBOLLHHMKKN().SetVector("skin.", v);
			base.NBPKMLMCHFN.SetVector("Value", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GKILCDHJFEG());
		}

		// Token: 0x0600C4DF RID: 50399 RVA: 0x00476B48 File Offset: 0x00474D48
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1942f / v.x, 463f / v.y);
			base.PLBEJJIHFPB().SetVector("_ScreenResolution", v);
			base.DNLMFEGJJDD().SetVector("LoadingStatusText", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HCGJCMDJPGD());
		}

		// Token: 0x0600C4E0 RID: 50400 RVA: 0x00476BD0 File Offset: 0x00474DD0
		private void PEBBCNICBDK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1943f / v.x, 1903f / v.y);
			base.NFMGLIKNOOC().SetVector("_Value2", v);
			base.IGKFMCPDNOI().SetVector("_ScreenResolution", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LONNIJMNKFB());
		}

		// Token: 0x0600C4E1 RID: 50401 RVA: 0x00476C58 File Offset: 0x00474E58
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1543f / v.x, 454f / v.y);
			base.DEFBJOCJJKF().SetVector("_Value", v);
			base.NFMGLIKNOOC().SetVector("_Value", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LONNIJMNKFB());
		}

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x00476CE0 File Offset: 0x00474EE0
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(799f / v.x, 906f / v.y);
			base.LONNIJMNKFB().SetVector("ArcsNoHitsoundTimeDelaySlider", v);
			base.DNLMFEGJJDD().SetVector("_TimeX", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DEFBJOCJJKF());
		}

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x00476D68 File Offset: 0x00474F68
		private void ENGFEPKGEDG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(123f / v.x, 1522f / v.y);
			base.DBOLLHHMKKN().SetVector("CameraFilterPack/FX_EarthQuake", v);
			base.AELJLBOJAIL().SetVector("[ResourcesManager] Load image error: ", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DNLMFEGJJDD());
		}

		// Token: 0x0600C4E4 RID: 50404 RVA: 0x00476DF0 File Offset: 0x00474FF0
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1635f / v.x, 1412f / v.y);
			base.IIBLJCKLGFG().SetVector("LevelEditor/icons", v);
			base.GCDFNHMJMIP().SetVector("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DNLMFEGJJDD());
		}

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x00476E78 File Offset: 0x00475078
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(594f / v.x, 84f / v.y);
			base.MMOODGIODPC().SetVector("skin.hit_normal", v);
			base.EFDEIFCDAFG().SetVector("_ScreenResolution", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x0600C4E6 RID: 50406 RVA: 0x00476F00 File Offset: 0x00475100
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1492f / v.x, 1128f / v.y);
			base.IGKFMCPDNOI().SetVector("_Value", v);
			base.PLBEJJIHFPB().SetVector("SetCrosshairEmission", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x0600C4E7 RID: 50407 RVA: 0x00476F88 File Offset: 0x00475188
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1436f / v.x, 1042f / v.y);
			base.PLBEJJIHFPB().SetVector("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", v);
			base.NBMPPNFKFLB().SetVector("_Value2", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x0600C4E8 RID: 50408 RVA: 0x00477010 File Offset: 0x00475210
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(905f / v.x, 264f / v.y);
			base.IONHGBPGCHK().SetVector("[Down-Left]", v);
			base.MMOODGIODPC().SetVector("CameraFilterPack/Vision_Warp", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x00477098 File Offset: 0x00475298
		private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(1607f / v.x, 251f / v.y);
			base.DNLMFEGJJDD().SetVector("_EmissionColor", v);
			base.PLBEJJIHFPB().SetVector("{0} hours ago", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EFDEIFCDAFG());
		}

		// Token: 0x0600C4EA RID: 50410 RVA: 0x00477120 File Offset: 0x00475320
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float aspect = Camera.main.aspect;
			Vector2 v = new Vector2(this.BlockCount, this.BlockCount / aspect);
			Vector2 v2 = new Vector2(324f / v.x, 155f / v.y);
			base.DBOLLHHMKKN().SetVector(" not exist", v);
			base.HFBJAOFLCJI().SetVector("leave", v2);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IONHGBPGCHK());
		}

		// Token: 0x0400172B RID: 5931
		[Range(64f, 512f)]
		public float BlockCount = 128f;
	}
}
