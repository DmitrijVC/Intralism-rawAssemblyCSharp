using System;
using System.Runtime.Serialization;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002C8 RID: 712
	public sealed class ColorSurrogate : ISerializationSurrogate
	{
		// Token: 0x0600A982 RID: 43394 RVA: 0x003EDA78 File Offset: 0x003EBC78
		public object EKECPBCHFCE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("SetSunSensitivity", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("_Bloom1", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Default UI Material", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("---", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x003EDB1C File Offset: 0x003EBD1C
		public object KOKHMHGKCJN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("Case-Sensitive", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("SpeedSlider", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("OnAwakeRPC", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("float,0", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x003EDBC0 File Offset: 0x003EBDC0
		public object GPGOCMEGKKH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("CameraFilterPack_Atmosphere_Rain_FX", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blend2Camera_VividLight", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue(" ", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("Unable to get a reward! Try again?", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x003EDC64 File Offset: 0x003EBE64
		public void AHECBDFNLMP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("settings.cameramovements", color.r);
			DAGALCAILLN.AddValue("SetSunDirectionVector", color.g);
			DAGALCAILLN.AddValue("_Vignette", color.b);
			DAGALCAILLN.AddValue("#TBD", color.a);
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x003EDCC0 File Offset: 0x003EBEC0
		public object OOLCCDLMKBE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("[Right]", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("setAF", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Can't start OFFLINE mode while connected!", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("_Value2", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x003EDD64 File Offset: 0x003EBF64
		public void ONHNIOCJOAG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_MainTex2", color.r);
			DAGALCAILLN.AddValue("workshop.", color.g);
			DAGALCAILLN.AddValue("/?player=", color.b);
			DAGALCAILLN.AddValue("[PlayerController] ", color.a);
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x003EDDC0 File Offset: 0x003EBFC0
		public object ICPNAMPLLDI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("Waiting for AvailableRegions. State: ", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("Editor/", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Set Trail Zoom (player camera move forward effect). Base value - 1.5", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("_Value2", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x003EDE64 File Offset: 0x003EC064
		public object OPCLEKPIKDO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue(".lastCheckpoint.checkpointsUsed", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("settings.shaders", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Start Color's hex value #RRGGBBAA", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("LeaderboardsButton", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x003EDF08 File Offset: 0x003EC108
		public object AKCCLCLONAC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("ChallengesButton", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("player.licenceaccepted", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("[PlayerBase] New highscore", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x003EDFAC File Offset: 0x003EC1AC
		public void FEIAGPABIDM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_TimeX", color.r);
			DAGALCAILLN.AddValue(".completedCount", color.g);
			DAGALCAILLN.AddValue("settings.arcsnohitsoundtimedelay", color.b);
			DAGALCAILLN.AddValue("Received RPC \"", color.a);
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x003EE008 File Offset: 0x003EC208
		public object PGEAPGKAHLP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("[LocalizationService] Error: ", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("Spawn ark to be pressed at this time", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("GhostSize", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("#000000CC", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x003EE0AC File Offset: 0x003EC2AC
		public void JLAIPJBBNJK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Authentication failed: '{0}' Code: {1}", color.r);
			DAGALCAILLN.AddValue(" ", color.g);
			DAGALCAILLN.AddValue("resource id", color.b);
			DAGALCAILLN.AddValue(" / ", color.a);
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x003EE108 File Offset: 0x003EC308
		public object CJBEEELPGBC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("_Speed", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("SetSatelliteInput", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("#getrewardfailed: ", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("IncorrectHitsScoreText", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x003EE1AC File Offset: 0x003EC3AC
		public object OFNDBOIPPMA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("_Blue_C", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("\"", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue(" to: ", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x003EE250 File Offset: 0x003EC450
		public object MMCLEKCNGPM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("ViewMenu", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("_Offsets", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("{0} seconds ago", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("_CurrentMipLevel", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x003EE2F4 File Offset: 0x003EC4F4
		public void CCKGLCDIKKM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue(" ", color.r);
			DAGALCAILLN.AddValue("Add Environment Sprite", color.g);
			DAGALCAILLN.AddValue("_Value3", color.b);
			DAGALCAILLN.AddValue("_Overlay", color.a);
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x003EE350 File Offset: 0x003EC550
		public object NFFDIDCIGJC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("Use \"/help\" for commands list", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("LivesSlider", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("_BlendTex", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x003EE3F4 File Offset: 0x003EC5F4
		public void CBMGLNNPFNO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("CameraFilterPack/Blend2Camera_Overlay", color.r);
			DAGALCAILLN.AddValue("effector", color.g);
			DAGALCAILLN.AddValue("_EmissionGain", color.b);
			DAGALCAILLN.AddValue("_DiffuseColor", color.a);
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x003EE450 File Offset: 0x003EC650
		public void GMJBIOOFPCB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("UseScanLine", color.r);
			DAGALCAILLN.AddValue("Tab1Content", color.g);
			DAGALCAILLN.AddValue("_Color_B", color.b);
			DAGALCAILLN.AddValue("CameraFilterPack_3D_Myst1", color.a);
		}

		// Token: 0x0600A996 RID: 43414 RVA: 0x003EE4AC File Offset: 0x003EC6AC
		public object PNFKODNFDFB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("Value", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Working.\nPlease wait..", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("menu.playedsolo", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A997 RID: 43415 RVA: 0x003EE550 File Offset: 0x003EC750
		public object LPHDEAPHBAP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("_LutTex", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("_Fade", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Joystick1Button7", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("settings_bindings_", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A998 RID: 43416 RVA: 0x003EE5F4 File Offset: 0x003EC7F4
		public void EGCNCGMHAAI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("' ping: ", color.r);
			DAGALCAILLN.AddValue("<b>#", color.g);
			DAGALCAILLN.AddValue("0.00", color.b);
			DAGALCAILLN.AddValue("#ok", color.a);
		}

		// Token: 0x0600A999 RID: 43417 RVA: 0x003EE650 File Offset: 0x003EC850
		public object GNNFGDLNALI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("_Distortion", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("GlassDistortion", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("#alreadystarted", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("Have you fully accept the terms?", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A99A RID: 43418 RVA: 0x003EE6F4 File Offset: 0x003EC8F4
		public object KLIMLHMAHEL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("GenerationMenu", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("_Value2", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("SetPlayerDistance", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("GameVolumeSlider", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A99B RID: 43419 RVA: 0x003EE798 File Offset: 0x003EC998
		public void HEOCKIPDKJJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("event", color.r);
			DAGALCAILLN.AddValue("id", color.g);
			DAGALCAILLN.AddValue("FullscreenToggle", color.b);
			DAGALCAILLN.AddValue("_Value6", color.a);
		}

		// Token: 0x0600A99C RID: 43420 RVA: 0x003EE7F4 File Offset: 0x003EC9F4
		public void PIDHNIGNLIJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("menu.selectedplaymode", color.r);
			DAGALCAILLN.AddValue("_TimeX", color.g);
			DAGALCAILLN.AddValue("skin.", color.b);
			DAGALCAILLN.AddValue("Set Sun Input", color.a);
		}

		// Token: 0x0600A99D RID: 43421 RVA: 0x003EE850 File Offset: 0x003ECA50
		public object MKFLFNJLCEO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("#forever", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("_Value3", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Set satellite trail length in seconds", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("GlassesColor", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A99E RID: 43422 RVA: 0x003EE8F4 File Offset: 0x003ECAF4
		public void APJCODEOBPI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_TileMaxLoop", color.r);
			DAGALCAILLN.AddValue("settings.enablehitsoundsinrelax", color.g);
			DAGALCAILLN.AddValue("event", color.b);
			DAGALCAILLN.AddValue(" (inactive)", color.a);
		}

		// Token: 0x0600A99F RID: 43423 RVA: 0x003EE950 File Offset: 0x003ECB50
		public void DLDGCMEIABB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue(":", color.r);
			DAGALCAILLN.AddValue("Gameplay/satellite", color.g);
			DAGALCAILLN.AddValue("ComboText", color.b);
			DAGALCAILLN.AddValue("_TimeX", color.a);
		}

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x003EE9AC File Offset: 0x003ECBAC
		public object KCLOMJJCNFG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue(": ", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("<color=#{0}>{1}</color>", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("_ExtraLight", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x003EEA50 File Offset: 0x003ECC50
		public object MEHBOCECAEB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("maps.", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("_MainTex2", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("_HrDepthTex", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("FullscreenToggle", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x003EEAF4 File Offset: 0x003ECCF4
		public void PFIEKFHJFAL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("ticket", color.r);
			DAGALCAILLN.AddValue("_Value", color.g);
			DAGALCAILLN.AddValue("settings.volume.sfx", color.b);
			DAGALCAILLN.AddValue(" not exist", color.a);
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x003EEB50 File Offset: 0x003ECD50
		public void MECDEPHNAKC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("caret", color.r);
			DAGALCAILLN.AddValue("https://steamcommunity.com/app/513510/workshop/", color.g);
			DAGALCAILLN.AddValue("_NoisePerChannel", color.b);
			DAGALCAILLN.AddValue("_InvRenderTargetSize", color.a);
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x003EEBAC File Offset: 0x003ECDAC
		public object IIHDDLHDGPC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blend2Camera_LighterColor", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("OnRenderImage in Helper called ...", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("_BlurDirectionPacked", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x003EEC50 File Offset: 0x003ECE50
		public void EIPOIHGFGKA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Error: Timeout :S", color.r);
			DAGALCAILLN.AddValue("SetSatelliteEmission", color.g);
			DAGALCAILLN.AddValue("_Green_C", color.b);
			DAGALCAILLN.AddValue("speed", color.a);
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x003EECAC File Offset: 0x003ECEAC
		public object SetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("r", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("g", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("b", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("a", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x003EED50 File Offset: 0x003ECF50
		public object AABEPDOMFKF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Color color = (Color)AGPIGANJKMN;
			color.r = (float)DAGALCAILLN.GetValue("CameraFilterPack_Atmosphere_Rain_FX", typeof(float));
			color.g = (float)DAGALCAILLN.GetValue("CameraFilterPack_Paper1", typeof(float));
			color.b = (float)DAGALCAILLN.GetValue("Fade", typeof(float));
			color.a = (float)DAGALCAILLN.GetValue("couldn't be found!", typeof(float));
			AGPIGANJKMN = color;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x003EEDF4 File Offset: 0x003ECFF4
		public void DBIIIAGDCBN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue(">", color.r);
			DAGALCAILLN.AddValue("_Far", color.g);
			DAGALCAILLN.AddValue("_Green_G", color.b);
			DAGALCAILLN.AddValue("_Value", color.a);
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x003EEE50 File Offset: 0x003ED050
		public void GetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Color color = (Color)AGPIGANJKMN;
			DAGALCAILLN.AddValue("r", color.r);
			DAGALCAILLN.AddValue("g", color.g);
			DAGALCAILLN.AddValue("b", color.b);
			DAGALCAILLN.AddValue("a", color.a);
		}
	}
}
