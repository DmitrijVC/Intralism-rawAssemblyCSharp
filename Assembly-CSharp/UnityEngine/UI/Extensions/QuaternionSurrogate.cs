using System;
using System.Runtime.Serialization;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002C9 RID: 713
	public sealed class QuaternionSurrogate : ISerializationSurrogate
	{
		// Token: 0x0600A9AA RID: 43434 RVA: 0x003EEEAC File Offset: 0x003ED0AC
		public object OBIHMEGBINE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue(".played", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("0.00", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue(" ", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("\t", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x003EEF50 File Offset: 0x003ED150
		public object KCLOMJJCNFG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("ClearEnvironment", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("Best region found in PlayerPrefs. Connecting to: ", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("SetParticlesInput", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("closed", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9AC RID: 43436 RVA: 0x003EEFF4 File Offset: 0x003ED1F4
		public object AKCCLCLONAC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("Set satellite emission (glow)", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("[MapsData] Caching ", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("<b>", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9AD RID: 43437 RVA: 0x003EF098 File Offset: 0x003ED298
		public void CCKGLCDIKKM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Offsets", quaternion.x);
			DAGALCAILLN.AddValue("settings.hitvariation", quaternion.y);
			DAGALCAILLN.AddValue(" Owner called.", quaternion.z);
			DAGALCAILLN.AddValue("achievements.21.progress", quaternion.w);
		}

		// Token: 0x0600A9AE RID: 43438 RVA: 0x003EF0F4 File Offset: 0x003ED2F4
		public object GKPPNDMJDJG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("_Near", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("SpawnObj", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("_Intensity", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("/icon", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9AF RID: 43439 RVA: 0x003EF198 File Offset: 0x003ED398
		public object KLIMLHMAHEL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("SettingsCanvas", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("_Color_G", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("_Visualize", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("kick", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x003EF23C File Offset: 0x003ED43C
		public void AHECBDFNLMP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_TimeX", quaternion.x);
			DAGALCAILLN.AddValue("_OcclusionTexture", quaternion.y);
			DAGALCAILLN.AddValue("PLEASE WAIT", quaternion.z);
			DAGALCAILLN.AddValue("_Green_C", quaternion.w);
		}

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x003EF298 File Offset: 0x003ED498
		public void JLAIPJBBNJK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_ReflectionBlur", quaternion.x);
			DAGALCAILLN.AddValue("settings.volume.menu", quaternion.y);
			DAGALCAILLN.AddValue("_TimeX", quaternion.z);
			DAGALCAILLN.AddValue("id", quaternion.w);
		}

		// Token: 0x0600A9B2 RID: 43442 RVA: 0x003EF2F4 File Offset: 0x003ED4F4
		public object EKECPBCHFCE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue(" ", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue(") error: ", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("Fade", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("#reward: ", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9B3 RID: 43443 RVA: 0x003EF398 File Offset: 0x003ED598
		public object JCJAMHGEBNO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("id", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("ShowTitle", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("_EmissionGain", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("ScrollPanel", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9B4 RID: 43444 RVA: 0x003EF43C File Offset: 0x003ED63C
		public object MEHBOCECAEB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("_GlowColor", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("skin.hit_wrong", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("Connection error: ", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9B5 RID: 43445 RVA: 0x003EF4E0 File Offset: 0x003ED6E0
		public object AKNFGBPIFMF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("restrictions", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("FileMenu", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("FinalScoreSmallText", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9B6 RID: 43446 RVA: 0x003EF584 File Offset: 0x003ED784
		public void GetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("x", quaternion.x);
			DAGALCAILLN.AddValue("y", quaternion.y);
			DAGALCAILLN.AddValue("z", quaternion.z);
			DAGALCAILLN.AddValue("w", quaternion.w);
		}

		// Token: 0x0600A9B7 RID: 43447 RVA: 0x003EF5E0 File Offset: 0x003ED7E0
		public void HHILGPIKLIF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", quaternion.x);
			DAGALCAILLN.AddValue(". Check if the server is available.", quaternion.y);
			DAGALCAILLN.AddValue("_Radius", quaternion.z);
			DAGALCAILLN.AddValue("2", quaternion.w);
		}

		// Token: 0x0600A9B8 RID: 43448 RVA: 0x003EF63C File Offset: 0x003ED83C
		public object AABEPDOMFKF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("ShadersToggle", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("move", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("_Extra", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("mapselector.orderby", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9B9 RID: 43449 RVA: 0x003EF6E0 File Offset: 0x003ED8E0
		public object GFJALHJGKHF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("_InvRenderTargetSize", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("CameraFilterPack/FX_Funk", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue(": ", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9BA RID: 43450 RVA: 0x003EF784 File Offset: 0x003ED984
		public object ICPNAMPLLDI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("Toggle {0} is not part of ToggleGroup {1}", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blend2Camera_SplitScreen3D", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("settings.enablehitsoundsinrelax", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("OnClick", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9BB RID: 43451 RVA: 0x003EF828 File Offset: 0x003EDA28
		public void GMJBIOOFPCB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Right Click", quaternion.x);
			DAGALCAILLN.AddValue("_TempTexture", quaternion.y);
			DAGALCAILLN.AddValue("</i>", quaternion.z);
			DAGALCAILLN.AddValue("_Value2", quaternion.w);
		}

		// Token: 0x0600A9BC RID: 43452 RVA: 0x003EF884 File Offset: 0x003EDA84
		public object CJBEEELPGBC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("Obtain promo Item", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("Sequence contains no elements", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue(".", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("_DistortionLevel", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9BD RID: 43453 RVA: 0x003EF928 File Offset: 0x003EDB28
		public void MECDEPHNAKC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("LoadingStatusText", quaternion.x);
			DAGALCAILLN.AddValue("Unsupported target enum: ", quaternion.y);
			DAGALCAILLN.AddValue("_ScreenResolution", quaternion.z);
			DAGALCAILLN.AddValue("_EmissionColor", quaternion.w);
		}

		// Token: 0x0600A9BE RID: 43454 RVA: 0x003EF984 File Offset: 0x003EDB84
		public object SetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("x", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("y", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("z", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("w", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9BF RID: 43455 RVA: 0x003EFA28 File Offset: 0x003EDC28
		public object OFNDBOIPPMA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("ResetSpeed", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue(":", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("#tryagain", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("_Value4", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9C0 RID: 43456 RVA: 0x003EFACC File Offset: 0x003EDCCC
		public object OOLCCDLMKBE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("_Value2", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("Joystick1Button4", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("Jul", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("[PlayerController] ", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9C1 RID: 43457 RVA: 0x003EFB70 File Offset: 0x003EDD70
		public void EGOLBBOFMHK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("ItemsCountText", quaternion.x);
			DAGALCAILLN.AddValue(" has no method \"", quaternion.y);
			DAGALCAILLN.AddValue("BloomShaderValueSlider", quaternion.z);
			DAGALCAILLN.AddValue("Despawn environment object by id", quaternion.w);
		}

		// Token: 0x0600A9C2 RID: 43458 RVA: 0x003EFBCC File Offset: 0x003EDDCC
		public object MKFLFNJLCEO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("_MainTex2", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("_Value8", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("Messages (shift+tab)", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("CameraFilterPack/Sharpen_Sharpen", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9C3 RID: 43459 RVA: 0x003EFC70 File Offset: 0x003EDE70
		public object KCANKKIDDAH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("_Value3", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue(" - StoreAuthURLResponse] - ", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue(".lastCheckpoint.playerdistance", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue(": ", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9C5 RID: 43461 RVA: 0x003EFD14 File Offset: 0x003EDF14
		public void PFIEKFHJFAL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("ENABLE_USER_LUT", quaternion.x);
			DAGALCAILLN.AddValue("settings_bindings_sec_", quaternion.y);
			DAGALCAILLN.AddValue("GlassAberration", quaternion.z);
			DAGALCAILLN.AddValue("settings.fps", quaternion.w);
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x003EFD70 File Offset: 0x003EDF70
		public object PNFKODNFDFB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("ExitButton", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("https://store.steampowered.com/itemstore/513510/", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("z", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("CameraFilterPack/Glasses_On", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x003EFE14 File Offset: 0x003EE014
		public void GFKFKEBJIIB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value", quaternion.x);
			DAGALCAILLN.AddValue("CameraFilterPack/Atmosphere_Fog", quaternion.y);
			DAGALCAILLN.AddValue(" {0}", quaternion.z);
			DAGALCAILLN.AddValue(". Prefab must have a PhotonView component.", quaternion.w);
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x003EFE70 File Offset: 0x003EE070
		public object IIHDDLHDGPC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("workshop.", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("_Red_C", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("#highscore", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("Object ID. Case-Sensitive", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x003EFF14 File Offset: 0x003EE114
		public void OMEBJCJBNLP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue(".highscore", quaternion.x);
			DAGALCAILLN.AddValue("UsernameText", quaternion.y);
			DAGALCAILLN.AddValue("value", quaternion.z);
			DAGALCAILLN.AddValue("TwoHands", quaternion.w);
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x003EFF70 File Offset: 0x003EE170
		public void PMMEHGGPIHC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value7", quaternion.x);
			DAGALCAILLN.AddValue("Cant ask anyone else for PickupItem spawn times.", quaternion.y);
			DAGALCAILLN.AddValue("MapConfig", quaternion.z);
			DAGALCAILLN.AddValue("CameraFilterPack_3D_Computer1", quaternion.w);
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x003EFFCC File Offset: 0x003EE1CC
		public void JJLBNCAMABC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue(".", quaternion.x);
			DAGALCAILLN.AddValue("CameraFilterPack/FX_Drunk", quaternion.y);
			DAGALCAILLN.AddValue("_Value6", quaternion.z);
			DAGALCAILLN.AddValue("_TimeX", quaternion.w);
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x003F0028 File Offset: 0x003EE228
		public void OJBGEDPFFCA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			DAGALCAILLN.AddValue("System.Boolean", quaternion.x);
			DAGALCAILLN.AddValue("SetCrosshairEmission", quaternion.y);
			DAGALCAILLN.AddValue("). ", quaternion.z);
			DAGALCAILLN.AddValue("UndoButton", quaternion.w);
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x003F0084 File Offset: 0x003EE284
		public object HIHIFGINMAM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Quaternion quaternion = (Quaternion)AGPIGANJKMN;
			quaternion.x = (float)DAGALCAILLN.GetValue("EnableRankedNotificationsToggle", typeof(float));
			quaternion.y = (float)DAGALCAILLN.GetValue("menu.enableselectormusic", typeof(float));
			quaternion.z = (float)DAGALCAILLN.GetValue("player.circle", typeof(float));
			quaternion.w = (float)DAGALCAILLN.GetValue("_Bullet_7", typeof(float));
			AGPIGANJKMN = quaternion;
			return AGPIGANJKMN;
		}
	}
}
