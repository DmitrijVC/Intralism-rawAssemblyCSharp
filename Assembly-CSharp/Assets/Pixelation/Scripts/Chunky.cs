using System;
using Assets.Pixelation.Example.Scripts;
using UnityEngine;

namespace Assets.Pixelation.Scripts
{
	// Token: 0x0200037B RID: 891
	[AddComponentMenu("Image Effects/Color Adjustments/Chunky")]
	[ExecuteInEditMode]
	public class Chunky : ImageEffectBase
	{
		// Token: 0x0600C483 RID: 50307 RVA: 0x00472E18 File Offset: 0x00471018
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1260f / v.x, 204f / v.y);
			base.HKGAONMOBMH().SetVector("[LevelEditorScene] Print Audio Wave: Start", v);
			base.NBPKMLMCHFN.SetVector("Netw. Sim.", v2);
			base.AELJLBOJAIL().SetColor("GraphicsQualitySlider", this.Color);
			base.GCDFNHMJMIP().SetTexture("_ScreenResolution", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x0600C484 RID: 50308 RVA: 0x00472EE8 File Offset: 0x004710E8
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(635f / v.x, 911f / v.y);
			base.HKGAONMOBMH().SetVector("_Heigh", v);
			base.IIBLJCKLGFG().SetVector("FinalScoreText", v2);
			base.MMOODGIODPC().SetColor("file://", this.Color);
			base.AELJLBOJAIL().SetTexture("#no", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKGAONMOBMH());
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x00472FB8 File Offset: 0x004711B8
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1113f / v.x, 1124f / v.y);
			base.EFDEIFCDAFG().SetVector("_Value4", v);
			base.GCDFNHMJMIP().SetVector("_Speed", v2);
			base.DNLMFEGJJDD().SetColor("{STEAM_CLAN_IMAGE}", this.Color);
			base.HHIFMIPPMPF().SetTexture("settings.volume.menu", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IIBLJCKLGFG());
		}

		// Token: 0x0600C486 RID: 50310 RVA: 0x00473088 File Offset: 0x00471288
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1390f / v.x, 1889f / v.y);
			base.DBOLLHHMKKN().SetVector("_ScreenResolution", v);
			base.AELJLBOJAIL().SetVector("settings.arcsnohitsoundtimedelay", v2);
			base.AELJLBOJAIL().SetColor("_PositionX", this.Color);
			base.HHIFMIPPMPF().SetTexture("/GetNews/pinnednewsid", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EFDEIFCDAFG());
		}

		// Token: 0x0600C487 RID: 50311 RVA: 0x00473158 File Offset: 0x00471358
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(837f / v.x, 1560f / v.y);
			base.LONNIJMNKFB().SetVector(".lastCheckpoint.time", v);
			base.GCDFNHMJMIP().SetVector("ticket", v2);
			base.NFMGLIKNOOC().SetColor("SetEnvSpriteColor", this.Color);
			base.LONNIJMNKFB().SetTexture("BitsData", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x0600C488 RID: 50312 RVA: 0x00473228 File Offset: 0x00471428
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(722f / v.x, 0f / v.y);
			base.HHIFMIPPMPF().SetVector("shader.ghost", v);
			base.DEFBJOCJJKF().SetVector("PUNCloudBestRegion", v2);
			base.NFMGLIKNOOC().SetColor("_TimeX", this.Color);
			base.NBMPPNFKFLB().SetTexture(".sawoutdatedmessage", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HFBJAOFLCJI());
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x004732F8 File Offset: 0x004714F8
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1868f / v.x, 159f / v.y);
			base.HHIFMIPPMPF().SetVector("#exit", v);
			base.GKILCDHJFEG().SetVector("\\\\", v2);
			base.NFMGLIKNOOC().SetColor("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", this.Color);
			base.HHIFMIPPMPF().SetTexture("X2", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKGAONMOBMH());
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x004733C8 File Offset: 0x004715C8
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(246f / v.x, 826f / v.y);
			base.AELJLBOJAIL().SetVector("_Value", v);
			base.DEFBJOCJJKF().SetVector(" ", v2);
			base.DBOLLHHMKKN().SetColor("_ScreenResolution", this.Color);
			base.NBPKMLMCHFN.SetTexture("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HFBJAOFLCJI());
		}

		// Token: 0x0600C48B RID: 50315 RVA: 0x00473498 File Offset: 0x00471698
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1108f / v.x, 128f / v.y);
			base.LONNIJMNKFB().SetVector("Set satellite beat detection sensitivity", v);
			base.NFMGLIKNOOC().SetVector("[PowerUp]", v2);
			base.IGKFMCPDNOI().SetColor("_WorldToCameraMatrix", this.Color);
			base.NBPKMLMCHFN.SetTexture("Done!", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C48C RID: 50316 RVA: 0x00473568 File Offset: 0x00471768
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1089f / v.x, 810f / v.y);
			base.PLBEJJIHFPB().SetVector(". Not connectedAndReady.", v);
			base.MMOODGIODPC().SetVector(" Kb", v2);
			base.IGKFMCPDNOI().SetColor("_FgOverlap", this.Color);
			base.NFMGLIKNOOC().SetTexture("_DisplayVelocityScale", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x00473638 File Offset: 0x00471838
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(484f / v.x, 1535f / v.y);
			base.PLBEJJIHFPB().SetVector("_DotSize", v);
			base.MMOODGIODPC().SetVector("materialsquantity[", v2);
			base.IONHGBPGCHK().SetColor("_MinVelocity", this.Color);
			base.IONHGBPGCHK().SetTexture("settings.enablehitsoundsinnormal", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x00473708 File Offset: 0x00471908
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(619f / v.x, 1490f / v.y);
			base.DBOLLHHMKKN().SetVector("_Intensity", v);
			base.NBPKMLMCHFN.SetVector("_ScreenResolution", v2);
			base.DEFBJOCJJKF().SetColor("_Threshhold", this.Color);
			base.NFMGLIKNOOC().SetTexture("LevelEditor/CustomEventEditor-Text", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DEFBJOCJJKF());
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x004737D8 File Offset: 0x004719D8
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(177f / v.x, 802f / v.y);
			base.IGKFMCPDNOI().SetVector("CameraFilterPack/3D_Mirror", v);
			base.AELJLBOJAIL().SetVector("maxScore", v2);
			base.IGKFMCPDNOI().SetColor("Sep", this.Color);
			base.IGKFMCPDNOI().SetTexture("_Blue_C", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IONHGBPGCHK());
		}

		// Token: 0x0600C490 RID: 50320 RVA: 0x004738A8 File Offset: 0x00471AA8
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1539f / v.x, 481f / v.y);
			base.HFBJAOFLCJI().SetVector("_BlendTex", v);
			base.IGKFMCPDNOI().SetVector("_TimeX", v2);
			base.NFMGLIKNOOC().SetColor(" id: ", this.Color);
			base.IIBLJCKLGFG().SetTexture("_Value2", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x00473978 File Offset: 0x00471B78
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(490f / v.x, 744f / v.y);
			base.GKILCDHJFEG().SetVector("https://store.steampowered.com/recommended/recommendgame/", v);
			base.DNLMFEGJJDD().SetVector("_TimeX", v2);
			base.PLBEJJIHFPB().SetColor("Failed to InstantiateSceneObject prefab:", this.Color);
			base.IIBLJCKLGFG().SetTexture("OxOD.lastPath", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IONHGBPGCHK());
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x00473A48 File Offset: 0x00471C48
		private void HLAIEDEHIBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(367f / v.x, 1285f / v.y);
			base.LONNIJMNKFB().SetVector("_Amount", v);
			base.LONNIJMNKFB().SetVector("BadgeText", v2);
			base.LONNIJMNKFB().SetColor("_Alpha2", this.Color);
			base.DBOLLHHMKKN().SetTexture("settings.enableselectormusic", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HCGJCMDJPGD());
		}

		// Token: 0x0600C493 RID: 50323 RVA: 0x00473B18 File Offset: 0x00471D18
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(935f / v.x, 1965f / v.y);
			base.IONHGBPGCHK().SetVector("_TimeX", v);
			base.MMOODGIODPC().SetVector("maps.", v2);
			base.AELJLBOJAIL().SetColor("offsets", this.Color);
			base.LONNIJMNKFB().SetTexture("#tryagain", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x0600C494 RID: 50324 RVA: 0x00473BE8 File Offset: 0x00471DE8
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(648f / v.x, 185f / v.y);
			base.DBOLLHHMKKN().SetVector("Adreno", v);
			base.GCDFNHMJMIP().SetVector("_BokehParams", v2);
			base.MMOODGIODPC().SetColor("[Down]", this.Color);
			base.GCDFNHMJMIP().SetTexture("_Offsets", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C495 RID: 50325 RVA: 0x00473CB8 File Offset: 0x00471EB8
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(986f / v.x, 1783f / v.y);
			base.EFDEIFCDAFG().SetVector("1.87", v);
			base.DBOLLHHMKKN().SetVector("SetParticlesInput", v2);
			base.LONNIJMNKFB().SetColor("_SecondTex", this.Color);
			base.PLBEJJIHFPB().SetTexture("LevelEditor/patterns", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x0600C496 RID: 50326 RVA: 0x00473D88 File Offset: 0x00471F88
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1453f / v.x, 1343f / v.y);
			base.NBPKMLMCHFN.SetVector("_Far", v);
			base.IONHGBPGCHK().SetVector("scene ", v2);
			base.GKILCDHJFEG().SetColor("ClearEnvironment", this.Color);
			base.EFDEIFCDAFG().SetTexture("settings.gamemessagesduration", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HHIFMIPPMPF());
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x00473E58 File Offset: 0x00472058
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1891f / v.x, 1580f / v.y);
			base.IIBLJCKLGFG().SetVector("Joystick1Button9", v);
			base.HCGJCMDJPGD().SetVector("UndoButton", v2);
			base.EFDEIFCDAFG().SetColor(" Loaded: ", this.Color);
			base.AELJLBOJAIL().SetTexture("action", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x0600C498 RID: 50328 RVA: 0x00473F28 File Offset: 0x00472128
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1628f / v.x, 171f / v.y);
			base.MMOODGIODPC().SetVector("#no", v);
			base.AELJLBOJAIL().SetVector("SetSatelliteTrailWidth", v2);
			base.LONNIJMNKFB().SetColor(" By: ", this.Color);
			base.NFMGLIKNOOC().SetTexture("{STEAM_CLAN_IMAGE}", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x0600C499 RID: 50329 RVA: 0x00473FF8 File Offset: 0x004721F8
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(113f / v.x, 1675f / v.y);
			base.HHIFMIPPMPF().SetVector("_Value6", v);
			base.NFMGLIKNOOC().SetVector("_Value2", v2);
			base.HKGAONMOBMH().SetColor("_ScreenResolution", this.Color);
			base.HCGJCMDJPGD().SetTexture("_Near", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C49A RID: 50330 RVA: 0x004740C8 File Offset: 0x004722C8
		private void PEBBCNICBDK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1833f / v.x, 163f / v.y);
			base.IONHGBPGCHK().SetVector("_TileMaxOffs", v);
			base.HFBJAOFLCJI().SetVector("_MatrixSize", v2);
			base.IONHGBPGCHK().SetColor("GlassesColor2", this.Color);
			base.HKGAONMOBMH().SetTexture("Error0", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HCGJCMDJPGD());
		}

		// Token: 0x0600C49B RID: 50331 RVA: 0x00474198 File Offset: 0x00472398
		private void ENGFEPKGEDG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(531f / v.x, 957f / v.y);
			base.NBPKMLMCHFN.SetVector("_Value", v);
			base.AELJLBOJAIL().SetVector("_Offsets", v2);
			base.IIBLJCKLGFG().SetColor("HiddenToggle", this.Color);
			base.HHIFMIPPMPF().SetTexture("_Value2", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x00474268 File Offset: 0x00472468
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(828f / v.x, 1503f / v.y);
			base.LONNIJMNKFB().SetVector("_TimeX", v);
			base.HFBJAOFLCJI().SetVector("Joystick1Button7", v2);
			base.IONHGBPGCHK().SetColor("_MainTex2", this.Color);
			base.GCDFNHMJMIP().SetTexture("_TimeX", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x00474338 File Offset: 0x00472538
		private void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(443f / v.x, 581f / v.y);
			base.DNLMFEGJJDD().SetVector("CameraFilterPack/Distortion_Flag", v);
			base.AELJLBOJAIL().SetVector("Sending vacant view IDs. Length: ", v2);
			base.DEFBJOCJJKF().SetColor("[Down]", this.Color);
			base.DNLMFEGJJDD().SetTexture("_Value", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MMOODGIODPC());
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x00474408 File Offset: 0x00472608
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1663f / v.x, 1477f / v.y);
			base.EFDEIFCDAFG().SetVector("_DisplayVelocityScale", v);
			base.EFDEIFCDAFG().SetVector(": ", v2);
			base.PLBEJJIHFPB().SetColor(".status", this.Color);
			base.IGKFMCPDNOI().SetTexture("Freq: ", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C49F RID: 50335 RVA: 0x004744D8 File Offset: 0x004726D8
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1203f / v.x, 1303f / v.y);
			base.PLBEJJIHFPB().SetVector("_ScreenResolution", v);
			base.DBOLLHHMKKN().SetVector("GlassesColor2", v2);
			base.EFDEIFCDAFG().SetColor("_EmissionColor", this.Color);
			base.GKILCDHJFEG().SetTexture("_ScreenResolution", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GKILCDHJFEG());
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x004745A8 File Offset: 0x004727A8
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(209f / v.x, 496f / v.y);
			base.IONHGBPGCHK().SetVector("CameraFilterPack/Pixelisation_OilPaint", v);
			base.LONNIJMNKFB().SetVector("_Value2", v2);
			base.IIBLJCKLGFG().SetColor("LoadPlayerSkin", this.Color);
			base.DNLMFEGJJDD().SetTexture("[LevelEditorScene] Reloaded config for \"", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EFDEIFCDAFG());
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x00474678 File Offset: 0x00472878
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(18f / v.x, 1197f / v.y);
			base.NBMPPNFKFLB().SetVector("ready", v);
			base.GKILCDHJFEG().SetVector("anonymous", v2);
			base.HKGAONMOBMH().SetColor("player ", this.Color);
			base.NFMGLIKNOOC().SetTexture("_TimeX", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DNLMFEGJJDD());
		}

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x00474748 File Offset: 0x00472948
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(569f / v.x, 1655f / v.y);
			base.EFDEIFCDAFG().SetVector("MusicFileSelector", v);
			base.MMOODGIODPC().SetVector(" not exist", v2);
			base.HFBJAOFLCJI().SetColor("EventSystem", this.Color);
			base.HFBJAOFLCJI().SetTexture("_Offsets", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.AELJLBOJAIL());
		}

		// Token: 0x0600C4A4 RID: 50340 RVA: 0x0047482C File Offset: 0x00472A2C
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(61f / v.x, 1088f / v.y);
			base.LONNIJMNKFB().SetVector("Adding player twice: ", v);
			base.HCGJCMDJPGD().SetVector("SetSpeed", v2);
			base.DBOLLHHMKKN().SetColor("_NoisePerChannel", this.Color);
			base.GCDFNHMJMIP().SetTexture("title", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x004748FC File Offset: 0x00472AFC
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1060f / v.x, 302f / v.y);
			base.IGKFMCPDNOI().SetVector("/", v);
			base.GCDFNHMJMIP().SetVector("grid", v2);
			base.IGKFMCPDNOI().SetColor("ClearEnvironment", this.Color);
			base.PLBEJJIHFPB().SetTexture("_Value1", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x004749CC File Offset: 0x00472BCC
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(117f / v.x, 1548f / v.y);
			base.MMOODGIODPC().SetVector("Joystick1Button4", v);
			base.NBPKMLMCHFN.SetVector("tintColor", v2);
			base.NBMPPNFKFLB().SetColor(":", this.Color);
			base.DBOLLHHMKKN().SetTexture("_Radius", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.PLBEJJIHFPB());
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x00474A9C File Offset: 0x00472C9C
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1707f / v.x, 938f / v.y);
			base.NFMGLIKNOOC().SetVector("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.", v);
			base.NBPKMLMCHFN.SetVector("SetSatelliteRotationSpeed", v2);
			base.IONHGBPGCHK().SetColor("_TimeX", this.Color);
			base.GCDFNHMJMIP().SetTexture("appid", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.PLBEJJIHFPB());
		}

		// Token: 0x0600C4A8 RID: 50344 RVA: 0x00474B6C File Offset: 0x00472D6C
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1339f / v.x, 1564f / v.y);
			base.LONNIJMNKFB().SetVector("_ScreenResolution", v);
			base.NBMPPNFKFLB().SetVector("Ownership mode == fixed. Ignoring request.", v2);
			base.HCGJCMDJPGD().SetColor("_TimeX", this.Color);
			base.PLBEJJIHFPB().SetTexture("_ChangeBlue", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GKILCDHJFEG());
		}

		// Token: 0x0600C4A9 RID: 50345 RVA: 0x00474C3C File Offset: 0x00472E3C
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1568f / v.x, 1969f / v.y);
			base.NFMGLIKNOOC().SetVector("_TimeX", v);
			base.MMOODGIODPC().SetVector("R:", v2);
			base.PLBEJJIHFPB().SetColor("resetall", this.Color);
			base.DNLMFEGJJDD().SetTexture("Playing ", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HCGJCMDJPGD());
		}

		// Token: 0x0600C4AA RID: 50346 RVA: 0x00474D0C File Offset: 0x00472F0C
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1393f / v.x, 171f / v.y);
			base.HCGJCMDJPGD().SetVector("SupportLogger OnFailedToConnectToPhoton(", v);
			base.DEFBJOCJJKF().SetVector("Tab2Content", v2);
			base.IONHGBPGCHK().SetColor("_ScreenResolution", this.Color);
			base.PLBEJJIHFPB().SetTexture("InfoCanvas", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LONNIJMNKFB());
		}

		// Token: 0x0600C4AB RID: 50347 RVA: 0x00474DDC File Offset: 0x00472FDC
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1870f / v.x, 1729f / v.y);
			base.NBMPPNFKFLB().SetVector(". Possible scene loading in progress?", v);
			base.GKILCDHJFEG().SetVector("{0:0} day{1}, ", v2);
			base.AELJLBOJAIL().SetColor("22x1", this.Color);
			base.MMOODGIODPC().SetTexture("Item ", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKGAONMOBMH());
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x00474EAC File Offset: 0x004730AC
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(371f / v.x, 1978f / v.y);
			base.GKILCDHJFEG().SetVector("_TimeX", v);
			base.GKILCDHJFEG().SetVector("MapCreationCanvas", v2);
			base.GCDFNHMJMIP().SetColor("#accuracy", this.Color);
			base.DEFBJOCJJKF().SetTexture("player.rgb", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IIBLJCKLGFG());
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x00474F7C File Offset: 0x0047317C
		private void OHDKDLLBNFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1624f / v.x, 3f / v.y);
			base.DBOLLHHMKKN().SetVector("_Value", v);
			base.DBOLLHHMKKN().SetVector("st", v2);
			base.HKGAONMOBMH().SetColor("CameraFilterPack/FX_DarkMatter", this.Color);
			base.HFBJAOFLCJI().SetTexture("{0}", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBMPPNFKFLB());
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x0047504C File Offset: 0x0047324C
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1141f / v.x, 563f / v.y);
			base.DEFBJOCJJKF().SetVector("(", v);
			base.HFBJAOFLCJI().SetVector("#forever", v2);
			base.EFDEIFCDAFG().SetColor("<b>Speed</b>:", this.Color);
			base.NBPKMLMCHFN.SetTexture("_TimeX", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x0047511C File Offset: 0x0047331C
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(953f / v.x, 863f / v.y);
			base.NBPKMLMCHFN.SetVector("Ev OwnershipTransfer. ViewID ", v);
			base.NBMPPNFKFLB().SetVector("???", v2);
			base.DNLMFEGJJDD().SetColor("_Value2", this.Color);
			base.LONNIJMNKFB().SetTexture("_MainTex2", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x004751EC File Offset: 0x004733EC
		private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(965f / v.x, 1847f / v.y);
			base.NFMGLIKNOOC().SetVector("DPADVER", v);
			base.LONNIJMNKFB().SetVector("_ChangeRed", v2);
			base.DNLMFEGJJDD().SetColor("music", this.Color);
			base.DBOLLHHMKKN().SetTexture("offsets", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EFDEIFCDAFG());
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x004752BC File Offset: 0x004734BC
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(1f / v.x, 1f / v.y);
			base.NBPKMLMCHFN.SetVector("BlockCount", v);
			base.NBPKMLMCHFN.SetVector("BlockSize", v2);
			base.NBPKMLMCHFN.SetColor("_Color", this.Color);
			base.NBPKMLMCHFN.SetTexture("_SprTex", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x0047538C File Offset: 0x0047358C
		private void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			float num = (float)Camera.main.pixelWidth;
			float num2 = (float)Camera.main.pixelHeight;
			Vector2 v = new Vector2(num / (float)this.SprTex.height, num2 / (float)this.SprTex.height);
			Vector2 v2 = new Vector2(177f / v.x, 1854f / v.y);
			base.IIBLJCKLGFG().SetVector("_Offsets", v);
			base.HFBJAOFLCJI().SetVector("_Axis", v2);
			base.DEFBJOCJJKF().SetColor("[Up]", this.Color);
			base.GCDFNHMJMIP().SetTexture("JoystickButton13", this.SprTex);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x04001729 RID: 5929
		public Texture2D SprTex;

		// Token: 0x0400172A RID: 5930
		public Color Color = Color.white;
	}
}
