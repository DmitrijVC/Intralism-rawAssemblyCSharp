using System;
using System.Runtime.Serialization;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002CB RID: 715
	public sealed class Vector3Surrogate : ISerializationSurrogate
	{
		// Token: 0x0600A9E8 RID: 43496 RVA: 0x003F0880 File Offset: 0x003EEA80
		public void OPGDEJFEKKA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue(", ", vector.x);
			DAGALCAILLN.AddValue("_Source", vector.y);
			DAGALCAILLN.AddValue("_TimeX", vector.z);
		}

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x003F08CC File Offset: 0x003EEACC
		public object IGNJDHKIICC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("DPADHOR", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_BlurCoe", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x003F094C File Offset: 0x003EEB4C
		public void DLLAAJCCGGL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value", vector.x);
			DAGALCAILLN.AddValue("L2", vector.y);
			DAGALCAILLN.AddValue("_FarCamera", vector.z);
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x003F0998 File Offset: 0x003EEB98
		public object PDGFDKHKADA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("???", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("FinalScoreSmallText", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("ItemNameBGImage", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x003F0A18 File Offset: 0x003EEC18
		public void AHECBDFNLMP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_AlphaMask", vector.x);
			DAGALCAILLN.AddValue("GlassesColor2", vector.y);
			DAGALCAILLN.AddValue("_Axis", vector.z);
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x003F0A64 File Offset: 0x003EEC64
		public object MKFLFNJLCEO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("note.0", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Deleted event", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_LumTex", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x003F0AE4 File Offset: 0x003EECE4
		public void BADAKJFMBDN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value", vector.x);
			DAGALCAILLN.AddValue("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", vector.y);
			DAGALCAILLN.AddValue("CameraFilterPack/Blur_DitherOffset", vector.z);
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x003F0B30 File Offset: 0x003EED30
		public object HLBKKJKEBJB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("speed", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("CompletedLevel", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x003F0BB0 File Offset: 0x003EEDB0
		public object KBJADKLNBOG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("</color>", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("LevelEditor/patterns", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ColorB", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x003F0C30 File Offset: 0x003EEE30
		public object KLIMLHMAHEL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" not exist", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("MaxLivesSlider", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("#yes", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x003F0CB0 File Offset: 0x003EEEB0
		public object NGMECLGOKMN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("value", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_RampTex", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x003F0D30 File Offset: 0x003EEF30
		public object EKAHPFHOBIO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("public", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blend2Camera_ColorBurn", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("/", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x003F0DB0 File Offset: 0x003EEFB0
		public void PPPBIGOHLBH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Player Connected", vector.x);
			DAGALCAILLN.AddValue("GlassDistortion", vector.y);
			DAGALCAILLN.AddValue("Editor/", vector.z);
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x003F0DFC File Offset: 0x003EEFFC
		public void LPDFHEPNALD(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("offsets", vector.x);
			DAGALCAILLN.AddValue("_Value4", vector.y);
			DAGALCAILLN.AddValue("settings_bindings_sec_", vector.z);
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x003F0E48 File Offset: 0x003EF048
		public void CILCOHHNMHL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_TimeX", vector.x);
			DAGALCAILLN.AddValue("_TintColor", vector.y);
			DAGALCAILLN.AddValue("_Blue_C", vector.z);
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x003F0E94 File Offset: 0x003EF094
		public void NMAAJCKCBIJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Edited event", vector.x);
			DAGALCAILLN.AddValue("_ScreenResolution", vector.y);
			DAGALCAILLN.AddValue("restrictions\n\n#until: ", vector.z);
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x003F0EE0 File Offset: 0x003EF0E0
		public object FBAIEMAPHPA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Fade", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Hidden/TonemappingColorGrading", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Creating awesome maps", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x003F0F60 File Offset: 0x003EF160
		public object SetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("x", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("y", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("z", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x003F0FE0 File Offset: 0x003EF1E0
		public object JLBKBHHJBML(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_FixDistance", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_ExposureAdjustment", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Object ID. Case-Sensitive", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x003F1060 File Offset: 0x003EF260
		public object GFICNACCNBB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" player(s)", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_color", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("fade out duration", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9FD RID: 43517 RVA: 0x003F10E0 File Offset: 0x003EF2E0
		public object NHGPNHFKHLH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("menu.tabid", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value1", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("PossibleMapMaxScoreText", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x003F1160 File Offset: 0x003EF360
		public void OLLEIALHFJO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("GameScene", vector.x);
			DAGALCAILLN.AddValue("_MainTex", vector.y);
			DAGALCAILLN.AddValue("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", vector.z);
		}

		// Token: 0x0600A9FF RID: 43519 RVA: 0x003F11AC File Offset: 0x003EF3AC
		public object CJBEEELPGBC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("finished", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("#ok", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(".lastCheckpoint.time", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA00 RID: 43520 RVA: 0x003F122C File Offset: 0x003EF42C
		public object GKPPNDMJDJG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("bpmgrid", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Received event Leave for unknown player ID: {0}", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA01 RID: 43521 RVA: 0x003F12AC File Offset: 0x003EF4AC
		public object LDMKLHFBHIH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(". MasterClient: ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("SelectorMusicToggle", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_SunColor", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA02 RID: 43522 RVA: 0x003F132C File Offset: 0x003EF52C
		public object HKJGHHLNGJE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_ReflectionBufferSize", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Right Stick Click", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("LivesSlider", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x003F13AC File Offset: 0x003EF5AC
		public object OOLCCDLMKBE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" id: ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("music.ogg", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("ScoreText", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x003F142C File Offset: 0x003EF62C
		public void FFDNCIJGCME(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("RequestForPickupItems", vector.x);
			DAGALCAILLN.AddValue("BitsData", vector.y);
			DAGALCAILLN.AddValue("Registered PhotonView: ", vector.z);
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x003F1478 File Offset: 0x003EF678
		public object CBFMJPJONNL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" - StoreAuthURLResponse] - ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("PLEASE WAIT", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x003F14F8 File Offset: 0x003EF6F8
		public object PNFKODNFDFB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Glitch", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("LevelConfigButton", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x003F1578 File Offset: 0x003EF778
		public void GKHGEMMCIIM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Can't set MaxPlayers when not in that room.", vector.x);
			DAGALCAILLN.AddValue("float,1", vector.y);
			DAGALCAILLN.AddValue("tip", vector.z);
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x003F15C4 File Offset: 0x003EF7C4
		public void IFLPCAPFHOH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("In Main Menu", vector.x);
			DAGALCAILLN.AddValue("http://steamcommunity.com/sharedfiles/filedetails/?id=", vector.y);
			DAGALCAILLN.AddValue("_Value", vector.z);
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x003F1610 File Offset: 0x003EF810
		public object GNNFGDLNALI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("tagElement", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("received</b>\n#reason: ", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(": ", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x003F1690 File Offset: 0x003EF890
		public void BBMDBPFGOEM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Case-Sensitive", vector.x);
			DAGALCAILLN.AddValue("mapselector.filter.rateduponly", vector.y);
			DAGALCAILLN.AddValue("MenuScene", vector.z);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x003F16DC File Offset: 0x003EF8DC
		public object FPAHLEMOCHH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Texture2", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x003F175C File Offset: 0x003EF95C
		public object HIHIFGINMAM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("float,0", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("CameraFilterPack/Oculus_NightVision3", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x003F17DC File Offset: 0x003EF9DC
		public object GFJALHJGKHF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_ReflectionTexture1", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Value2", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x003F185C File Offset: 0x003EFA5C
		public object GLEAELEODJE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("roomDescription", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x003F18DC File Offset: 0x003EFADC
		public object AFHOLKCEFNP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("EventSystem", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("HiddenToggle", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("SendVacantViewIds()", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x003F195C File Offset: 0x003EFB5C
		public object MEHBOCECAEB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("RecordButton", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ToPrevViewProjCombined", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x003F19DC File Offset: 0x003EFBDC
		public object GLCKDNLOMLE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(". Client should be in a room. Current connectionStateDetailed: ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("G:", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Exception while connecting to: ", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x003F1A5C File Offset: 0x003EFC5C
		public void IAMMAHIMNEO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("in seconds. 0 - forever", vector.x);
			DAGALCAILLN.AddValue("_BaseTex", vector.y);
			DAGALCAILLN.AddValue("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", vector.z);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x003F1AA8 File Offset: 0x003EFCA8
		public object LPHDEAPHBAP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("settings.shaders.bloomintencity", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value3", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_PrevViewProj", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x003F1B28 File Offset: 0x003EFD28
		public object AKCCLCLONAC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("master", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("TotalHitsScoreText", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x003F1BA8 File Offset: 0x003EFDA8
		public void JEANBLPCENK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("shader.frost", vector.x);
			DAGALCAILLN.AddValue("CameraFilterPack/Oculus_NightVision2", vector.y);
			DAGALCAILLN.AddValue("shader.frost", vector.z);
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x003F1BF4 File Offset: 0x003EFDF4
		public void GetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("x", vector.x);
			DAGALCAILLN.AddValue("y", vector.y);
			DAGALCAILLN.AddValue("z", vector.z);
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x003F1C40 File Offset: 0x003EFE40
		public object OBIHMEGBINE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Illegal view ID:", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Far", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("FinalScoreSmallText", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x003F1CC0 File Offset: 0x003EFEC0
		public void OLNDAMKJHFP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("CameraFilterPack/Blend2Camera_ColorDodge", vector.x);
			DAGALCAILLN.AddValue("_Value5", vector.y);
			DAGALCAILLN.AddValue("ControllerRightX", vector.z);
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x003F1D0C File Offset: 0x003EFF0C
		public void PFIEKFHJFAL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("settings.fps", vector.x);
			DAGALCAILLN.AddValue("score", vector.y);
			DAGALCAILLN.AddValue("nogamesfound", vector.z);
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x003F1D58 File Offset: 0x003EFF58
		public object PNJABNCGMLF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("1177138211", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("No", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("roomDescription", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x003F1DD8 File Offset: 0x003EFFD8
		public object DIKCPCJLIGD(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("CameraFilterPack/BlurTiltShift", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue(": ", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("menu.playedpage", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x003F1E58 File Offset: 0x003F0058
		public void LLACBCKAMOB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", vector.x);
			DAGALCAILLN.AddValue("Cause: ", vector.y);
			DAGALCAILLN.AddValue("_Value", vector.z);
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x003F1EA4 File Offset: 0x003F00A4
		public void JJLBNCAMABC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue(":", vector.x);
			DAGALCAILLN.AddValue("_NoiseAmount", vector.y);
			DAGALCAILLN.AddValue("<b>Max Score</b>:", vector.z);
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x003F1EF0 File Offset: 0x003F00F0
		public object EBMPHBODOAM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Threshhold", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue(".jpg", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("#ok", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x003F1F70 File Offset: 0x003F0170
		public void FHHLIEBKOCD(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("[PlayerBase] SpawnObj error: ", vector.x);
			DAGALCAILLN.AddValue("event", vector.y);
			DAGALCAILLN.AddValue("MenuScene", vector.z);
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x003F1FBC File Offset: 0x003F01BC
		public void PIDHNIGNLIJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Case-Sensitive", vector.x);
			DAGALCAILLN.AddValue("]. Please verify you have this gameobject in a Resources folder.", vector.y);
			DAGALCAILLN.AddValue("cmd.exe", vector.z);
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x003F2008 File Offset: 0x003F0208
		public object KFNKNCAKGHK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(",", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("ShadersToggle", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("EventTimeInputField", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x003F2088 File Offset: 0x003F0288
		public void MENDODKHMMC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("MenuRecordButton", vector.x);
			DAGALCAILLN.AddValue("selector", vector.y);
			DAGALCAILLN.AddValue("_EmissionGain", vector.z);
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x003F20D4 File Offset: 0x003F02D4
		public object NFFDIDCIGJC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("CameraFilterPack/Glasses_On", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("#alreadyexist", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("/files/editor_manual.pdf", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x003F2154 File Offset: 0x003F0354
		public void JDGDDIJJMAL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("SelectorMapsCountSlider", vector.x);
			DAGALCAILLN.AddValue("Items/", vector.y);
			DAGALCAILLN.AddValue("note.3", vector.z);
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x003F21A0 File Offset: 0x003F03A0
		public object JCJAMHGEBNO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("EventMenu", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Vibrance", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ColorB", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x003F2220 File Offset: 0x003F0420
		public void HHILGPIKLIF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value12", vector.x);
			DAGALCAILLN.AddValue("_TimeX", vector.y);
			DAGALCAILLN.AddValue("_ChromaticAberration", vector.z);
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x003F226C File Offset: 0x003F046C
		public void DANIMFFEFCH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("LevelEditor/icons", vector.x);
			DAGALCAILLN.AddValue("Received your UserID from server. Updating local value to: {0}", vector.y);
			DAGALCAILLN.AddValue("QuickSave", vector.z);
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x003F22B8 File Offset: 0x003F04B8
		public void NHDDCBINJBK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("settings.shaders", vector.x);
			DAGALCAILLN.AddValue("BitsData", vector.y);
			DAGALCAILLN.AddValue("_EmissionColor", vector.z);
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x003F2304 File Offset: 0x003F0504
		public void DJMBPMCPMGM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value3", vector.x);
			DAGALCAILLN.AddValue("accuracy", vector.y);
			DAGALCAILLN.AddValue("_TimeX", vector.z);
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x003F2350 File Offset: 0x003F0550
		public void FNBGIFHJBKI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("value", vector.x);
			DAGALCAILLN.AddValue("_Value3", vector.y);
			DAGALCAILLN.AddValue("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", vector.z);
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x003F239C File Offset: 0x003F059C
		public void PAAAODJKOOM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_TimeX", vector.x);
			DAGALCAILLN.AddValue("DPADHOR", vector.y);
			DAGALCAILLN.AddValue("_ScreenResolution", vector.z);
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x003F23E8 File Offset: 0x003F05E8
		public object OHGDHDNANAL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Fade", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Cancel", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("player.currentrank", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x003F2468 File Offset: 0x003F0668
		public void LAJAKHCMIFA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Text", vector.x);
			DAGALCAILLN.AddValue(".", vector.y);
			DAGALCAILLN.AddValue(".highscore", vector.z);
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x003F24B4 File Offset: 0x003F06B4
		public void KFIJAAAPKMA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue(".lastCheckpoint.isMapCompleted", vector.x);
			DAGALCAILLN.AddValue("true", vector.y);
			DAGALCAILLN.AddValue(".", vector.z);
		}

		// Token: 0x0600AA2F RID: 43567 RVA: 0x003F2500 File Offset: 0x003F0700
		public object NGENFCMNOCE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("[MenuScene] Error: ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_TapMedium", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x003F2580 File Offset: 0x003F0780
		public object OFNDBOIPPMA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Value3", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Hidden/TonemappingColorGrading", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Value6", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x003F2600 File Offset: 0x003F0800
		public object NMNNIILHEKJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Overlay", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("player.bluearc", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("offsets", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x003F2680 File Offset: 0x003F0880
		public object KOKHMHGKCJN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Value4", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("LevelEditor/CustomEventEditor-Text", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Fade", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x003F2700 File Offset: 0x003F0900
		public void BHNHIDNDIHF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Y", vector.x);
			DAGALCAILLN.AddValue("newPath", vector.y);
			DAGALCAILLN.AddValue("_PosY", vector.z);
		}

		// Token: 0x0600AA34 RID: 43572 RVA: 0x003F274C File Offset: 0x003F094C
		public object GJJDKIMFDNF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Obtain promo Item", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("X2", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_FixDistance", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x003F27CC File Offset: 0x003F09CC
		public void GODOOKCPNBA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("time", vector.x);
			DAGALCAILLN.AddValue("BitsData", vector.y);
			DAGALCAILLN.AddValue("$ {0}", vector.z);
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x003F2818 File Offset: 0x003F0A18
		public void JEGDGKFPNEM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("tintColor", vector.x);
			DAGALCAILLN.AddValue(" ", vector.y);
			DAGALCAILLN.AddValue("]", vector.z);
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x003F2864 File Offset: 0x003F0A64
		public object IABGFEBAAMB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("unsubscribemap", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x003F28E4 File Offset: 0x003F0AE4
		public void MECDEPHNAKC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value2", vector.x);
			DAGALCAILLN.AddValue("_LutTex", vector.y);
			DAGALCAILLN.AddValue("_MainTex", vector.z);
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x003F2930 File Offset: 0x003F0B30
		public void PBLAEBBAIAF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value2", vector.x);
			DAGALCAILLN.AddValue("No Description", vector.y);
			DAGALCAILLN.AddValue("[Right]", vector.z);
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x003F297C File Offset: 0x003F0B7C
		public void CCKGLCDIKKM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("CameraFilterPack/FX_Drunk", vector.x);
			DAGALCAILLN.AddValue("element", vector.y);
			DAGALCAILLN.AddValue("Object ID. Case-Sensitive", vector.z);
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x003F29C8 File Offset: 0x003F0BC8
		public void IIKCPNIEHON(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Blend", vector.x);
			DAGALCAILLN.AddValue("\" that takes ", vector.y);
			DAGALCAILLN.AddValue(",", vector.z);
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x003F2A14 File Offset: 0x003F0C14
		public object AKNFGBPIFMF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("d264dbba9c2410771b4ad918903b3f4cd9e276a9", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Failed to Destroy objects of playerId: ", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(" key(s)", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x003F2A94 File Offset: 0x003F0C94
		public object PGEAPGKAHLP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector3 vector = (Vector3)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Mouse Wheel Down", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("shader.sunny", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("[Up-Right-Left]", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}
	}
}
