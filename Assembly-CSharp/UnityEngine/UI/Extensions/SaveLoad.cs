using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002C5 RID: 709
	public static class SaveLoad
	{
		// Token: 0x0600A8EB RID: 43243 RVA: 0x003EB6C0 File Offset: 0x003E98C0
		public static void Save(SaveGame POLAOFNOLAA)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			SurrogateSelector surrogateSelector = new SurrogateSelector();
			SaveLoad.OEHOEJEGIBL(ref surrogateSelector);
			binaryFormatter.SurrogateSelector = surrogateSelector;
			SaveLoad.FLIDBJHHCNL(SaveLoad.saveGamePath);
			FileStream fileStream = File.Create(SaveLoad.saveGamePath + POLAOFNOLAA.savegameName + ".sav");
			binaryFormatter.Serialize(fileStream, POLAOFNOLAA);
			fileStream.Close();
			Debug.Log("Saved Game: " + POLAOFNOLAA.savegameName);
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x003EB730 File Offset: 0x003E9930
		public static SaveGame Load(string FKLFPELFHON)
		{
			if (File.Exists(SaveLoad.saveGamePath + FKLFPELFHON + ".sav"))
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				SurrogateSelector surrogateSelector = new SurrogateSelector();
				SaveLoad.OEHOEJEGIBL(ref surrogateSelector);
				binaryFormatter.SurrogateSelector = surrogateSelector;
				FileStream fileStream = File.Open(SaveLoad.saveGamePath + FKLFPELFHON + ".sav", FileMode.Open);
				SaveGame saveGame = (SaveGame)binaryFormatter.Deserialize(fileStream);
				fileStream.Close();
				Debug.Log("Loaded Game: " + saveGame.savegameName);
				return saveGame;
			}
			Debug.Log(FKLFPELFHON + " does not exist!");
			return null;
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x003EB7C4 File Offset: 0x003E99C4
		private static void OEHOEJEGIBL(ref SurrogateSelector IGBGEEKMMDN)
		{
			Vector2Surrogate surrogate = new Vector2Surrogate();
			IGBGEEKMMDN.AddSurrogate(typeof(Vector2), new StreamingContext(StreamingContextStates.All), surrogate);
			Vector3Surrogate surrogate2 = new Vector3Surrogate();
			IGBGEEKMMDN.AddSurrogate(typeof(Vector3), new StreamingContext(StreamingContextStates.All), surrogate2);
			Vector4Surrogate surrogate3 = new Vector4Surrogate();
			IGBGEEKMMDN.AddSurrogate(typeof(Vector4), new StreamingContext(StreamingContextStates.All), surrogate3);
			ColorSurrogate surrogate4 = new ColorSurrogate();
			IGBGEEKMMDN.AddSurrogate(typeof(Color), new StreamingContext(StreamingContextStates.All), surrogate4);
			QuaternionSurrogate surrogate5 = new QuaternionSurrogate();
			IGBGEEKMMDN.AddSurrogate(typeof(Quaternion), new StreamingContext(StreamingContextStates.All), surrogate5);
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x003EB880 File Offset: 0x003E9A80
		private static void FLIDBJHHCNL(string BNJFKKGOACF)
		{
			try
			{
				if (!Directory.Exists(BNJFKKGOACF))
				{
					Directory.CreateDirectory(BNJFKKGOACF);
					Debug.Log("The directory was created successfully at " + BNJFKKGOACF);
				}
			}
			catch (Exception ex)
			{
				Debug.Log("The process failed: " + ex.ToString());
			}
			finally
			{
			}
		}

		// Token: 0x040012E2 RID: 4834
		public static string saveGamePath = Application.persistentDataPath + "/Saved Games/";
	}
}
