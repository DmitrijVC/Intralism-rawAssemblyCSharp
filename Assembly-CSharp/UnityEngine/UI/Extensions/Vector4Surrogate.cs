using System;
using System.Runtime.Serialization;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002CC RID: 716
	public sealed class Vector4Surrogate : ISerializationSurrogate
	{
		// Token: 0x0600AA3E RID: 43582 RVA: 0x003F2B14 File Offset: 0x003F0D14
		public object OABBJOGFNGF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blend2Camera_Darken", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value3", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue(" This is not possible to be called for standalone input. Please check your platform and code where this is called", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Please define the RectTransform for the Center viewport of the scrollable area", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA3F RID: 43583 RVA: 0x003F2BB8 File Offset: 0x003F0DB8
		public void PAAAODJKOOM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue(".icon", vector.x);
			DAGALCAILLN.AddValue("CameraFilterPack/VHS_Tracking", vector.y);
			DAGALCAILLN.AddValue("ShineEffect", vector.w);
			DAGALCAILLN.AddValue("x", vector.z);
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x003F2C14 File Offset: 0x003F0E14
		public void OMEBJCJBNLP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_ScreenResolution", vector.x);
			DAGALCAILLN.AddValue("AudioSampler", vector.y);
			DAGALCAILLN.AddValue("_Green_G", vector.w);
			DAGALCAILLN.AddValue("CameraFilterPack/Special_Bubble", vector.z);
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x003F2C70 File Offset: 0x003F0E70
		public object HBLIJKPGFDN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("maps.", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("connecting", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("SetSunInput", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA43 RID: 43587 RVA: 0x003F2D14 File Offset: 0x003F0F14
		public void MNGDKCFNNCH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue(" item(s) in inventory", vector.x);
			DAGALCAILLN.AddValue("_Intervale", vector.y);
			DAGALCAILLN.AddValue("Preparing content...", vector.w);
			DAGALCAILLN.AddValue("_TimeX", vector.z);
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x003F2D70 File Offset: 0x003F0F70
		public object OOLCCDLMKBE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("00", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("TRACKING", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("isVisible", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("???", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x003F2E14 File Offset: 0x003F1014
		public object PFAJCEGDFFK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(", ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value8", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Netw. Sim.", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Distortion", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x003F2EB8 File Offset: 0x003F10B8
		public object NPIFEJFEHLP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("workshop.txt", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("OPEN FILE", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("B", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(":", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x003F2F5C File Offset: 0x003F115C
		public void MENDODKHMMC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("SetParticlesParticleSize", vector.x);
			DAGALCAILLN.AddValue("IEnumerable", vector.y);
			DAGALCAILLN.AddValue("_MainTex2", vector.w);
			DAGALCAILLN.AddValue("Could not execute RPC ", vector.z);
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x003F2FB8 File Offset: 0x003F11B8
		public void PMBFACIGGNC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("BlockSize", vector.x);
			DAGALCAILLN.AddValue("_Axis", vector.y);
			DAGALCAILLN.AddValue("Anomaly_Far", vector.w);
			DAGALCAILLN.AddValue("_Blend", vector.z);
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x003F3014 File Offset: 0x003F1214
		public void NMAAJCKCBIJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Messages (shift+tab)", vector.x);
			DAGALCAILLN.AddValue("_Value", vector.y);
			DAGALCAILLN.AddValue("[ResourcesManager] Load image error: ", vector.w);
			DAGALCAILLN.AddValue("SpectatingUserInfo", vector.z);
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x003F3070 File Offset: 0x003F1270
		public void LNOGBICEBON(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("CameraFilterPack/TV_Vignetting", vector.x);
			DAGALCAILLN.AddValue("_Value6", vector.y);
			DAGALCAILLN.AddValue("+", vector.w);
			DAGALCAILLN.AddValue("OnReadyClick", vector.z);
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x003F30CC File Offset: 0x003F12CC
		public void OOHIPCPJJDN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Editor", vector.x);
			DAGALCAILLN.AddValue("\n", vector.y);
			DAGALCAILLN.AddValue("X", vector.w);
			DAGALCAILLN.AddValue("[DiscordController] Connected to {0}#{1}: {2}", vector.z);
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x003F3128 File Offset: 0x003F1328
		public void FNBGIFHJBKI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("PUN-instantiated '", vector.x);
			DAGALCAILLN.AddValue("System.Boolean", vector.y);
			DAGALCAILLN.AddValue("Texture2", vector.w);
			DAGALCAILLN.AddValue("_Value5", vector.z);
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x003F3184 File Offset: 0x003F1384
		public void JLAIPJBBNJK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("[MapEditor] Loading events...", vector.x);
			DAGALCAILLN.AddValue("_ScreenResolution", vector.y);
			DAGALCAILLN.AddValue("BitsData", vector.w);
			DAGALCAILLN.AddValue("_ScreenResolution", vector.z);
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x003F31E0 File Offset: 0x003F13E0
		public object KLIMLHMAHEL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Done!", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("curScn", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Created", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("achievements.21.progress", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x003F3284 File Offset: 0x003F1484
		public void AHECBDFNLMP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_TimeX", vector.x);
			DAGALCAILLN.AddValue("Turn", vector.y);
			DAGALCAILLN.AddValue("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", vector.w);
			DAGALCAILLN.AddValue("Vertical", vector.z);
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x003F32E0 File Offset: 0x003F14E0
		public void LLACBCKAMOB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Threshhold", vector.x);
			DAGALCAILLN.AddValue("_DiffuseColor", vector.y);
			DAGALCAILLN.AddValue("ERROR You have missing MonoBehaviours on your gameobjects!", vector.w);
			DAGALCAILLN.AddValue("_Value2", vector.z);
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x003F333C File Offset: 0x003F153C
		public void PFIEKFHJFAL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("resource", vector.x);
			DAGALCAILLN.AddValue("_ToPrevViewProjCombined", vector.y);
			DAGALCAILLN.AddValue("replayData", vector.w);
			DAGALCAILLN.AddValue("[PlayerBase] Highscore: ", vector.z);
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x003F3398 File Offset: 0x003F1598
		public object CNFFKIDKHEJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("shader.pixel", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Image", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(" not exist", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x003F343C File Offset: 0x003F163C
		public object GLCKDNLOMLE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(". Check if the server is available.", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x003F34E0 File Offset: 0x003F16E0
		public object NHGPNHFKHLH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("replayData", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("RemoveEnvironmentObject", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("difficulty", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("inventory.selected.", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x003F3584 File Offset: 0x003F1784
		public void IFLPCAPFHOH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("NetworkScene", vector.x);
			DAGALCAILLN.AddValue("Fade", vector.y);
			DAGALCAILLN.AddValue("_AOTex", vector.w);
			DAGALCAILLN.AddValue("_Value", vector.z);
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x003F35E0 File Offset: 0x003F17E0
		public object KOKHMHGKCJN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blend2Camera_Divide", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("status", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("{0}", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Winter2020", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x003F3684 File Offset: 0x003F1884
		public object FNKFPJHGMOM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("EnvironmentSlider", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("note.0", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("OK", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("float,0.5", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x003F3728 File Offset: 0x003F1928
		public void PCBHMEKPKJA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("CameraFilterPack/Color_Switching", vector.x);
			DAGALCAILLN.AddValue("_Value6", vector.y);
			DAGALCAILLN.AddValue("checkpoint", vector.w);
			DAGALCAILLN.AddValue("22x3", vector.z);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x003F3784 File Offset: 0x003F1984
		public void JCJNNEGABPP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("ConfigVersionSlider", vector.x);
			DAGALCAILLN.AddValue("CameraFilterPack_AAA_BloodOnScreen1", vector.y);
			DAGALCAILLN.AddValue("[NetworkManager] Joined room with ", vector.w);
			DAGALCAILLN.AddValue("_Value2", vector.z);
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x003F37E0 File Offset: 0x003F19E0
		public void HGMGEIINBHL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value3", vector.x);
			DAGALCAILLN.AddValue("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", vector.y);
			DAGALCAILLN.AddValue("R:", vector.w);
			DAGALCAILLN.AddValue("score", vector.z);
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x003F383C File Offset: 0x003F1A3C
		public void APJCODEOBPI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value4", vector.x);
			DAGALCAILLN.AddValue("CameraFilterPack/NightVisionFX", vector.y);
			DAGALCAILLN.AddValue("Finished", vector.w);
			DAGALCAILLN.AddValue("_Visualize", vector.z);
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x003F3898 File Offset: 0x003F1A98
		public void BBMDBPFGOEM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("FrostCanvas", vector.x);
			DAGALCAILLN.AddValue("CameraFilterPack/Vision_Drost", vector.y);
			DAGALCAILLN.AddValue("\nCreated by Oxy949", vector.w);
			DAGALCAILLN.AddValue("[EditorEvent] Exception: ", vector.z);
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x003F38F4 File Offset: 0x003F1AF4
		public object PNJABNCGMLF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("0.00", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("MainCamera", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("DPADVER", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("MascotChallenge2019", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x003F3998 File Offset: 0x003F1B98
		public object PEOFCNDCDDG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Tab1Content", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue(": ", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Editor/", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA5F RID: 43615 RVA: 0x003F3A3C File Offset: 0x003F1C3C
		public void JEGDGKFPNEM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("ShadersToggle", vector.x);
			DAGALCAILLN.AddValue("ClearEnvironment", vector.y);
			DAGALCAILLN.AddValue("color", vector.w);
			DAGALCAILLN.AddValue("Noise shaders are not set up! Disabling noise effect.", vector.z);
		}

		// Token: 0x0600AA60 RID: 43616 RVA: 0x003F3A98 File Offset: 0x003F1C98
		public void ONHNIOCJOAG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_TimeX", vector.x);
			DAGALCAILLN.AddValue("_CurveTex", vector.y);
			DAGALCAILLN.AddValue("LevelNameText", vector.w);
			DAGALCAILLN.AddValue("[SteamManager] Connecting to server", vector.z);
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x003F3AF4 File Offset: 0x003F1CF4
		public void EGCNCGMHAAI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("#91CCFF", vector.x);
			DAGALCAILLN.AddValue("Load Game", vector.y);
			DAGALCAILLN.AddValue("_Smooth", vector.w);
			DAGALCAILLN.AddValue("MissesText", vector.z);
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x003F3B50 File Offset: 0x003F1D50
		public object NGENFCMNOCE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(",", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("closed", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Finished", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("SaveGameName is null or empty!", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x003F3BF4 File Offset: 0x003F1DF4
		public void NFJCALEDEFG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_ExposureAdjustment", vector.x);
			DAGALCAILLN.AddValue("https://store.steampowered.com/itemstore/513510/", vector.y);
			DAGALCAILLN.AddValue("PlayMusic", vector.w);
			DAGALCAILLN.AddValue("CameraFilterPack/Distortion_Heat", vector.z);
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x003F3C50 File Offset: 0x003F1E50
		public void ACIFBONGKPB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value", vector.x);
			DAGALCAILLN.AddValue("End index must in an integer.", vector.y);
			DAGALCAILLN.AddValue("#turnoninternet", vector.w);
			DAGALCAILLN.AddValue("_Bullet_12", vector.z);
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x003F3CAC File Offset: 0x003F1EAC
		public object OONPPDPPFCM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_MainTex2", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Classical", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("maps.", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x003F3D50 File Offset: 0x003F1F50
		public void DLDGCMEIABB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("cmd.exe", vector.x);
			DAGALCAILLN.AddValue("_TimeX", vector.y);
			DAGALCAILLN.AddValue("tagElement", vector.w);
			DAGALCAILLN.AddValue("CameraFilterPack/Blend2Camera_Blend", vector.z);
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x003F3DAC File Offset: 0x003F1FAC
		public object JDOCLMOPOCP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("ReconnectAndRejoin() disabled the offline mode. No longer offline.", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value2", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("/", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blend2Camera_LinearBurn", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x003F3E50 File Offset: 0x003F2050
		public object BGIGEEKHOKK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Luminance", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blur_DitherOffset", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("y", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x003F3EF4 File Offset: 0x003F20F4
		public object AFMEHDHKFFJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Instrumental", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("CameraFilterPack/Blur_Noise", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("0", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("JITTER", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x003F3F98 File Offset: 0x003F2198
		public void LAJAKHCMIFA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("BackButton", vector.x);
			DAGALCAILLN.AddValue("_MainTex2", vector.y);
			DAGALCAILLN.AddValue("_DistortionSize", vector.w);
			DAGALCAILLN.AddValue("Failed to 'network-remove' GameObject because has no PhotonView components: ", vector.z);
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x003F3FF4 File Offset: 0x003F21F4
		public object OPCLEKPIKDO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue(" does not exist!", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Tab2Content", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("BitsData", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA6C RID: 43628 RVA: 0x003F4098 File Offset: 0x003F2298
		public void NGFKCGOPLBJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue(" but this PhotonView does not exist! View was/is ours.", vector.x);
			DAGALCAILLN.AddValue("checkpoint", vector.y);
			DAGALCAILLN.AddValue("player.goldarc", vector.w);
			DAGALCAILLN.AddValue("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", vector.z);
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x003F40F4 File Offset: 0x003F22F4
		public object SetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("x", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("y", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("w", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("z", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA6E RID: 43630 RVA: 0x003F4198 File Offset: 0x003F2398
		public object KCJAOCJBOLA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("EnableRankedNotificationsToggle", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("settings.fps", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("GlassesColor", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x003F423C File Offset: 0x003F243C
		public void FHHLIEBKOCD(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("reset", vector.x);
			DAGALCAILLN.AddValue("_ColorBuffer", vector.y);
			DAGALCAILLN.AddValue("</color>", vector.w);
			DAGALCAILLN.AddValue("menu.enableselectormusic", vector.z);
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x003F4298 File Offset: 0x003F2498
		public void ILGDFEIFLEI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("achievements.21.completed.", vector.x);
			DAGALCAILLN.AddValue("_TimeX", vector.y);
			DAGALCAILLN.AddValue("_Value5", vector.w);
			DAGALCAILLN.AddValue("CameraFilterPack/Vision_Warp2", vector.z);
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x003F42F4 File Offset: 0x003F24F4
		public object GPGOCMEGKKH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("table", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("' has been reset to the fault value", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("BitsData", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA72 RID: 43634 RVA: 0x003F4398 File Offset: 0x003F2598
		public object JLBKBHHJBML(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("/icon", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Obtain promo Item", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("R1", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Text", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA73 RID: 43635 RVA: 0x003F443C File Offset: 0x003F263C
		public object OFNDBOIPPMA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Value3", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("HPText", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("BitsData", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("VIGNETTE_FILMIC", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x003F44E0 File Offset: 0x003F26E0
		public object HLBKKJKEBJB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Value3", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("ShowTitle", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("#close", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Distortion2", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x003F4584 File Offset: 0x003F2784
		public void PMMEHGGPIHC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Player", vector.x);
			DAGALCAILLN.AddValue(":", vector.y);
			DAGALCAILLN.AddValue("_MainTex2", vector.w);
			DAGALCAILLN.AddValue("_MainTex2", vector.z);
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x003F45E0 File Offset: 0x003F27E0
		public object CBCOPFLONEJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_AlphaHexa", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_HrDepthTex", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("closed", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x003F4684 File Offset: 0x003F2884
		public object NMNNIILHEKJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("maps.", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_FarCamera", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Deleted event", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x003F4728 File Offset: 0x003F2928
		public object DLDLNBCMHMO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("received</b>\n#reason: ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("settings.arcshitsoundtimedelay", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_Blood", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("LT", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x003F47CC File Offset: 0x003F29CC
		public object GFJALHJGKHF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Speed", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Distortion", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_CenterY", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x003F4870 File Offset: 0x003F2A70
		public void GKHGEMMCIIM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("GlassDistortion", vector.x);
			DAGALCAILLN.AddValue("reset", vector.y);
			DAGALCAILLN.AddValue("id", vector.w);
			DAGALCAILLN.AddValue("UNDISTORT", vector.z);
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x003F48CC File Offset: 0x003F2ACC
		public void DBIIIAGDCBN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Value3", vector.x);
			DAGALCAILLN.AddValue("CameraFilterPack/Blend2Camera_ColorBurn", vector.y);
			DAGALCAILLN.AddValue("[NetworkManager] Exited", vector.w);
			DAGALCAILLN.AddValue("ResetSpeed", vector.z);
		}

		// Token: 0x0600AA7C RID: 43644 RVA: 0x003F4928 File Offset: 0x003F2B28
		public void PIDHNIGNLIJ(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("QuickSave", vector.x);
			DAGALCAILLN.AddValue("_DistortionLevel", vector.y);
			DAGALCAILLN.AddValue("1", vector.w);
			DAGALCAILLN.AddValue("Item ", vector.z);
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x003F4984 File Offset: 0x003F2B84
		public object JCJAMHGEBNO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Blue_B", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Green_G", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_PColor2", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(" ", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x003F4A28 File Offset: 0x003F2C28
		public object EKAHPFHOBIO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("BitsData", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Please specify either t or f.", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Deleted event", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(" with prefix ", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x003F4ACC File Offset: 0x003F2CCC
		public object KBJADKLNBOG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("Scenes List:", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Hidden/ScreenSpaceReflection", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ProjectToPixelMatrix", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x003F4B70 File Offset: 0x003F2D70
		public object FDHDKHGBIOM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("OK", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("ItemNameText", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("CreateRoom failed. In offline mode you still have to leave a room to enter another.", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Tab2Content", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x003F4C14 File Offset: 0x003F2E14
		public void CHFCCBEJFNI(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("Failed to InstantiateSceneObject prefab: ", vector.x);
			DAGALCAILLN.AddValue("menu.enableselectormusic", vector.y);
			DAGALCAILLN.AddValue("Gameplay/Segment-[PowerUp]", vector.w);
			DAGALCAILLN.AddValue("Right", vector.z);
		}

		// Token: 0x0600AA82 RID: 43650 RVA: 0x003F4C70 File Offset: 0x003F2E70
		public object EBFKDEBFMKM(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("PLEASE WAIT", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value4", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("In Maps Editor", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Value12", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x003F4D14 File Offset: 0x003F2F14
		public object KHNOPHCCFFN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("inventory.selected.", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("\r\n", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_SpherePositionY", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x003F4DB8 File Offset: 0x003F2FB8
		public object KFNKNCAKGHK(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("settings.volume.menu", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("white", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue(".icon", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("Turn", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA85 RID: 43653 RVA: 0x003F4E5C File Offset: 0x003F305C
		public object AKCCLCLONAC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("CameraFilterPack_Paper4", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_MaxVelocity", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue(".lastCheckpoint.powerupsScore", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Size", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x003F4F00 File Offset: 0x003F3100
		public object MKFLFNJLCEO(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_Visualize", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("CameraFilterPack/FX_8bits_gb", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("#alreadyexist", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("menuVolume", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA87 RID: 43655 RVA: 0x003F4FA4 File Offset: 0x003F31A4
		public void OJBGEDPFFCA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("?", vector.x);
			DAGALCAILLN.AddValue("SendVacantViewIds()", vector.y);
			DAGALCAILLN.AddValue("#yes", vector.w);
			DAGALCAILLN.AddValue("Environment/SunBase_", vector.z);
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x003F5000 File Offset: 0x003F3200
		public void OPGDEJFEKKA(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_BlurDirectionPacked", vector.x);
			DAGALCAILLN.AddValue("MenuRecordButton", vector.y);
			DAGALCAILLN.AddValue("0", vector.w);
			DAGALCAILLN.AddValue("challenges.", vector.z);
		}

		// Token: 0x0600AA89 RID: 43657 RVA: 0x003F505C File Offset: 0x003F325C
		public void PMHKLBDIAEH(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("#failed!", vector.x);
			DAGALCAILLN.AddValue("STICKRVER", vector.y);
			DAGALCAILLN.AddValue("pointBuffer", vector.w);
			DAGALCAILLN.AddValue("replayData", vector.z);
		}

		// Token: 0x0600AA8A RID: 43658 RVA: 0x003F50B8 File Offset: 0x003F32B8
		public object EJHAMFJIGBC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" url: ", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Tab1Content", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("sfxVolume", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x003F515C File Offset: 0x003F335C
		public void HHILGPIKLIF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("GridDataStoryboard", vector.x);
			DAGALCAILLN.AddValue("Bass", vector.y);
			DAGALCAILLN.AddValue("_Offsets", vector.w);
			DAGALCAILLN.AddValue(". Name: ", vector.z);
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x003F51B8 File Offset: 0x003F33B8
		public object NGMECLGOKMN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("AccuracyScoreText", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("CameraFilterPack/BlurTiltShift", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("AudioSampler", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("MapperNameText", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x003F525C File Offset: 0x003F345C
		public object PNFKODNFDFB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_TimeX", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("#", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Crosshair2", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_Blend", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x003F5300 File Offset: 0x003F3500
		public void OLCFKKFCDEB(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("GenerationMenu", vector.x);
			DAGALCAILLN.AddValue("file://", vector.y);
			DAGALCAILLN.AddValue("x", vector.w);
			DAGALCAILLN.AddValue("_Value4", vector.z);
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x003F535C File Offset: 0x003F355C
		public void GetObjectData(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("x", vector.x);
			DAGALCAILLN.AddValue("y", vector.y);
			DAGALCAILLN.AddValue("w", vector.w);
			DAGALCAILLN.AddValue("z", vector.z);
		}

		// Token: 0x0600AA90 RID: 43664 RVA: 0x003F53B8 File Offset: 0x003F35B8
		public object NJKGPJNICLG(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("CameraFilterPack/Drawing_EnhancedComics", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("settings.gamemessagesduration", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("CameraFilterPack_Fly_VisionFX", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("CameraFilterPack/TV_Vignetting", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x003F545C File Offset: 0x003F365C
		public void PBLAEBBAIAF(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_Curve", vector.x);
			DAGALCAILLN.AddValue("[Up]", vector.y);
			DAGALCAILLN.AddValue("player.licenceaccepted", vector.w);
			DAGALCAILLN.AddValue("_NoisePerChannel", vector.z);
		}

		// Token: 0x0600AA92 RID: 43666 RVA: 0x003F54B8 File Offset: 0x003F36B8
		public object IIHDDLHDGPC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("BitsData", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("plainText", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA93 RID: 43667 RVA: 0x003F555C File Offset: 0x003F375C
		public void CPIMGMMMPLN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_NeighborMaxTex", vector.x);
			DAGALCAILLN.AddValue("[Up]", vector.y);
			DAGALCAILLN.AddValue(",", vector.w);
			DAGALCAILLN.AddValue("#tryagain", vector.z);
		}

		// Token: 0x0600AA94 RID: 43668 RVA: 0x003F55B8 File Offset: 0x003F37B8
		public object GLEAELEODJE(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("settings.fps", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("SelectorMusicToggle", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_Value", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue(".icon", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA95 RID: 43669 RVA: 0x003F565C File Offset: 0x003F385C
		public void FFDNCIJGCME(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("input", vector.x);
			DAGALCAILLN.AddValue("_EmissionGain", vector.y);
			DAGALCAILLN.AddValue("</color>", vector.w);
			DAGALCAILLN.AddValue("default", vector.z);
		}

		// Token: 0x0600AA96 RID: 43670 RVA: 0x003F56B8 File Offset: 0x003F38B8
		public void BDOKGFDJPMD(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("#rt", vector.x);
			DAGALCAILLN.AddValue("CompletedLevel", vector.y);
			DAGALCAILLN.AddValue("an hour ago", vector.w);
			DAGALCAILLN.AddValue("<b>", vector.z);
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x003F5714 File Offset: 0x003F3914
		public void KAIOCDNHHKN(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_ScreenResolution", vector.x);
			DAGALCAILLN.AddValue("/", vector.y);
			DAGALCAILLN.AddValue("_MainTex2", vector.w);
			DAGALCAILLN.AddValue("InfoText", vector.z);
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x003F5770 File Offset: 0x003F3970
		public void JDGDDIJJMAL(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			DAGALCAILLN.AddValue("_ScreenResolution", vector.x);
			DAGALCAILLN.AddValue("_XCrop", vector.y);
			DAGALCAILLN.AddValue("OnSerialize", vector.w);
			DAGALCAILLN.AddValue("_Value3", vector.z);
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x003F57CC File Offset: 0x003F39CC
		public object OEIDAKDFMJC(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue("[Left]", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("[MapsData] Found ", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("Set Sun Input", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("ArcsNoHitsoundTimeDelaySlider", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x003F5870 File Offset: 0x003F3A70
		public object LPHDEAPHBAP(object AGPIGANJKMN, SerializationInfo DAGALCAILLN, StreamingContext CKALHHFJPBN, ISurrogateSelector PGBBGIOBPGB)
		{
			Vector4 vector = (Vector4)AGPIGANJKMN;
			vector.x = (float)DAGALCAILLN.GetValue(" Mb", typeof(float));
			vector.y = (float)DAGALCAILLN.GetValue("maps.", typeof(float));
			vector.w = (float)DAGALCAILLN.GetValue("_Intensity", typeof(float));
			vector.z = (float)DAGALCAILLN.GetValue("_ScreenResolution", typeof(float));
			AGPIGANJKMN = vector;
			return AGPIGANJKMN;
		}
	}
}
