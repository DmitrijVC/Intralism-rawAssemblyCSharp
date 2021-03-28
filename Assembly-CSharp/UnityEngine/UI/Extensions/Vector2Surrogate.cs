using System;
using System.Runtime.Serialization;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002CA RID: 714
	public sealed class Vector2Surrogate : ISerializationSurrogate
	{
		// Token: 0x0600A9CE RID: 43470 RVA: 0x003F0128 File Offset: 0x003EE328
		public object KLIMLHMAHEL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(".jpg", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Received RPC \"", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x003F0188 File Offset: 0x003EE388
		public void APJCODEOBPI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Internal LUT", vector.x);
			DAGALCAILLN.AddValue("skin.", vector.y);
		}

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x003F01C0 File Offset: 0x003EE3C0
		public void JJLBNCAMABC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_ScreenResolution", vector.x);
			DAGALCAILLN.AddValue("0 - sun, 1 - satellite, 2 - particles emitter", vector.y);
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x003F01F8 File Offset: 0x003EE3F8
		public void CCKGLCDIKKM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Start", vector.x);
			DAGALCAILLN.AddValue("CameraFilterPack/Pixelisation_OilPaintHQ", vector.y);
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x003F0230 File Offset: 0x003EE430
		public void FOECHAHONFP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("time", vector.x);
			DAGALCAILLN.AddValue("player.licenceaccepted", vector.y);
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x003F0268 File Offset: 0x003EE468
		public void EGOLBBOFMHK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Joystick1Button12", vector.x);
			DAGALCAILLN.AddValue("note.3", vector.y);
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x003F02A0 File Offset: 0x003EE4A0
		public object ICPNAMPLLDI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("CameraFilterPack/Glow_Glow_Color", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue(" cannot be used as a 3D LUT.", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x003F0300 File Offset: 0x003EE500
		public object EKECPBCHFCE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Val2", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x003F0360 File Offset: 0x003EE560
		public object GNNFGDLNALI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("CountEventsGoal", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x003F03C0 File Offset: 0x003EE5C0
		public void FNGCNAOAOPH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("shader.frost", vector.x);
			DAGALCAILLN.AddValue("_TimeX", vector.y);
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x003F03F8 File Offset: 0x003EE5F8
		public void FPBGELHCBNI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("SetSunInput", vector.x);
			DAGALCAILLN.AddValue(",", vector.y);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x003F0430 File Offset: 0x003EE630
		public object AKNFGBPIFMF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("#news", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value2", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x003F0490 File Offset: 0x003EE690
		public void DBIIIAGDCBN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Received RPC: ", vector.x);
			DAGALCAILLN.AddValue(".g", vector.y);
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x003F04C8 File Offset: 0x003EE6C8
		public void GetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("x", vector.x);
			DAGALCAILLN.AddValue("y", vector.y);
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x003F0500 File Offset: 0x003EE700
		public object EBFKDEBFMKM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("sfxVolume", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("#close", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x003F0560 File Offset: 0x003EE760
		public void FNPALFIBKNN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("player.xp", vector.x);
			DAGALCAILLN.AddValue("[PlayerBase] Loaded custom model: ", vector.y);
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x003F0598 File Offset: 0x003EE798
		public object DOIGEKAIOGH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("End Value should be greater than the start value, values not changed", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("isVisible", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x003F05F8 File Offset: 0x003EE7F8
		public void PMMEHGGPIHC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("ItemNameText", vector.x);
			DAGALCAILLN.AddValue("The number of players playing your game: ", vector.y);
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x003F0630 File Offset: 0x003EE830
		public void PMBFACIGGNC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Reset", vector.x);
			DAGALCAILLN.AddValue(": ", vector.y);
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x003F0668 File Offset: 0x003EE868
		public object JCJAMHGEBNO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Rand", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("/", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x003F06C8 File Offset: 0x003EE8C8
		public object AFHOLKCEFNP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Distortion", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Right ", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9E4 RID: 43492 RVA: 0x003F0728 File Offset: 0x003EE928
		public void HHILGPIKLIF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Fade", vector.x);
			DAGALCAILLN.AddValue("_NoisePerChannel", vector.y);
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x003F0760 File Offset: 0x003EE960
		public object IIHDDLHDGPC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("SfxVolumeSlider", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x003F07C0 File Offset: 0x003EE9C0
		public object NFFDIDCIGJC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("/music", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("cancel", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x003F0820 File Offset: 0x003EEA20
		public object SetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector2 vector = (Vector2)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("x", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("y", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}
	}
}
