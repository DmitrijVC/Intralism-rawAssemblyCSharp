using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using NAudio.Wave;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;

// Token: 0x0200041F RID: 1055
public static class Helpers
{
	// Token: 0x0600F1FE RID: 61950 RVA: 0x0054379C File Offset: 0x0054199C
	public static string GetGameVersion()
	{
		return Application.version;
	}

	// Token: 0x0600F1FF RID: 61951 RVA: 0x005437A4 File Offset: 0x005419A4
	public static bool IsStoryboardEvent(string JMMILEFMACB)
	{
		Helpers.CEMBABEIJBO cembabeijbo = new Helpers.CEMBABEIJBO();
		cembabeijbo.JMMILEFMACB = JMMILEFMACB;
		return !Helpers.eventsMap.Exists(new Predicate<EditorEventFunctionInfo>(cembabeijbo.GBKBDKHPLKG)) || Helpers.eventsMap.Exists(new Predicate<EditorEventFunctionInfo>(cembabeijbo.HMMBBDJNGGL));
	}

	// Token: 0x0600F200 RID: 61952 RVA: 0x005437F1 File Offset: 0x005419F1
	private static double NPMILGHONMJ(int AFMLIFBPDPG)
	{
		return -((double)(AFMLIFBPDPG * AFMLIFBPDPG) / 4.0) + (double)(1.3f * (float)AFMLIFBPDPG);
	}

	// Token: 0x0600F201 RID: 61953 RVA: 0x0054380C File Offset: 0x00541A0C
	private static double EPIDEKIOIKD(double KEDDLFDAIDE)
	{
		return KEDDLFDAIDE / 14.0;
	}

	// Token: 0x0600F202 RID: 61954 RVA: 0x0054381C File Offset: 0x00541A1C
	private static double AAHJGEGFLEM(double CIHKHOHGNDG)
	{
		if (CIHKHOHGNDG < 14.0)
		{
			return 14.0 / CIHKHOHGNDG;
		}
		return CIHKHOHGNDG * CIHKHOHGNDG / 196.0 - CIHKHOHGNDG / 7.0 + 2.0;
	}

	// Token: 0x0600F203 RID: 61955 RVA: 0x00543868 File Offset: 0x00541A68
	public static float GetMapDifficulty(MapData CLCBMMEKBBC)
	{
		MapData mapData = new MapData(CLCBMMEKBBC);
		if (mapData.configVersion >= 3 && !string.IsNullOrEmpty(mapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(mapData.e, Singleton<SaveSystem>.Instance.folder));
				mapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		double keddlfdaide = (double)CLCBMMEKBBC.speed;
		double cihkhohgndg = 14.0;
		double num = 0.0;
		double num2 = (double)mapData.musicTime;
		bool flag = false;
		foreach (MapEvent mapEvent in mapData.events)
		{
			if (mapEvent.data[0] == "SpawnObj")
			{
				if (!flag)
				{
					num = (double)mapEvent.time;
					flag = true;
				}
				num2 = (double)mapEvent.time;
			}
		}
		if (!flag || num == num2)
		{
			return 0f;
		}
		double num3 = num2 - num;
		double num4 = Helpers.AAHJGEGFLEM(cihkhohgndg);
		double num5 = Helpers.EPIDEKIOIKD(keddlfdaide);
		double num6 = 0.0;
		int num7 = 0;
		double num8 = 0.0;
		int num9 = 0;
		List<double> list = new List<double>();
		for (int i = 0; i < (int)Math.Ceiling(num2); i++)
		{
			int num10 = 0;
			double num11 = 0.0;
			foreach (MapEvent mapEvent2 in mapData.events)
			{
				if (mapEvent2.time >= (float)i && mapEvent2.time < (float)(i + 1))
				{
					if (mapEvent2.data[0] == "SpawnObj")
					{
						IEnumerable<char> source = mapEvent2.data[1];
						if (Helpers.LNIJKGECNME == null)
						{
							Helpers.LNIJKGECNME = new Func<char, bool>(Helpers.LFJDIMOEADJ);
						}
						int num12 = source.Count(Helpers.LNIJKGECNME) + 1;
						num10 += num12;
						double num13 = Helpers.NPMILGHONMJ(num12);
						num11 += num13 * num4 * num5;
					}
					if (mapEvent2.data[0] == "SetPlayerDistance")
					{
						float num14 = float.Parse(mapEvent2.data[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo);
						num4 = Helpers.AAHJGEGFLEM((double)num14);
					}
					if (mapEvent2.data[0] == "SetSpeed")
					{
						float num15 = float.Parse(mapEvent2.data[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo);
						num5 = Helpers.EPIDEKIOIKD((double)num15);
					}
				}
			}
			if (num10 > 0)
			{
				num9++;
			}
			if (num8 < num11)
			{
				num8 = num11;
			}
			if (num11 > 0.0)
			{
				num6 += num11;
				num7++;
				list.Add(num11);
			}
		}
		int num16 = (int)Math.Ceiling((double)num9 * 0.33);
		double num17 = 0.0;
		for (int j = 0; j < num16; j++)
		{
			IEnumerable<double> source2 = list;
			if (Helpers.CLCBJCKCBDD == null)
			{
				Helpers.CLCBJCKCBDD = new Func<double, double>(Helpers.PMBAHAIECAN);
			}
			double num18 = source2.OrderBy(Helpers.CLCBJCKCBDD).ToList<double>()[j];
			num17 += num18;
		}
		double num19 = num17 / (double)num16;
		double num20 = Math.Log((double)num9, 60.0);
		double value = num20 * num19;
		return (float)Math.Round(value, 2);
	}

	// Token: 0x0600F204 RID: 61956 RVA: 0x00543C60 File Offset: 0x00541E60
	public static int GetMapMaxScore(MapData CLCBMMEKBBC)
	{
		MapData mapData = new MapData(CLCBMMEKBBC);
		if (mapData.configVersion >= 3 && !string.IsNullOrEmpty(mapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(mapData.e, Singleton<SaveSystem>.Instance.folder));
				mapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		IEnumerable<MapEvent> events = mapData.events;
		if (Helpers.HCLEECLNOEA == null)
		{
			Helpers.HCLEECLNOEA = new Func<MapEvent, bool>(Helpers.NDFPKEBFAGM);
		}
		List<MapEvent> list = events.Where(Helpers.HCLEECLNOEA).ToList<MapEvent>();
		int num = 0;
		int num2 = 0;
		foreach (MapEvent mapEvent in list)
		{
			int num3 = mapEvent.data[1].Split(new char[]
			{
				'-'
			}).Length;
			for (int i = 0; i < num3; i++)
			{
				num2++;
				num += num2;
			}
		}
		return num;
	}

	// Token: 0x0600F205 RID: 61957 RVA: 0x00543D90 File Offset: 0x00541F90
	public static Color HexToColor(string MLPCOMHPPNH)
	{
		MLPCOMHPPNH = MLPCOMHPPNH.Replace("0x", string.Empty);
		MLPCOMHPPNH = MLPCOMHPPNH.Replace("#", string.Empty);
		byte a = byte.MaxValue;
		byte r = byte.Parse(MLPCOMHPPNH.Substring(0, 2), NumberStyles.HexNumber);
		byte g = byte.Parse(MLPCOMHPPNH.Substring(2, 2), NumberStyles.HexNumber);
		byte b = byte.Parse(MLPCOMHPPNH.Substring(4, 2), NumberStyles.HexNumber);
		if (MLPCOMHPPNH.Length == 8)
		{
			a = byte.Parse(MLPCOMHPPNH.Substring(6, 2), NumberStyles.HexNumber);
		}
		return new Color32(r, g, b, a);
	}

	// Token: 0x0600F206 RID: 61958 RVA: 0x00543E2D File Offset: 0x0054202D
	public static string ColorToHex(Color HABLFKCCKLN)
	{
		return ColorUtility.ToHtmlStringRGBA(HABLFKCCKLN);
	}

	// Token: 0x0600F207 RID: 61959 RVA: 0x00543E38 File Offset: 0x00542038
	public static int GetPlayerLevel(int EEGKDDBECBE)
	{
		int num = 0;
		int num2 = EEGKDDBECBE;
		for (int i = 0; i <= num2; i = num * 500)
		{
			num2 -= i;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num++;
		}
		return num;
	}

	// Token: 0x0600F208 RID: 61960 RVA: 0x00543E74 File Offset: 0x00542074
	public static Transform FindDeepChild(this Transform INBEMGANDKE, string JNOIHECMHJJ)
	{
		Transform transform = INBEMGANDKE.Find(JNOIHECMHJJ);
		if (transform != null)
		{
			return transform;
		}
		IEnumerator enumerator = INBEMGANDKE.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform inbemgandke = (Transform)obj;
				transform = inbemgandke.FindDeepChild(JNOIHECMHJJ);
				if (transform != null)
				{
					return transform;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		return null;
	}

	// Token: 0x0600F209 RID: 61961 RVA: 0x00543F04 File Offset: 0x00542104
	public static float GetPlayerLevelProgress()
	{
		int num = 0;
		int num2 = Helpers.GetStat("player.xp");
		int i;
		for (i = 0; i <= num2; i = num * 500)
		{
			num2 -= i;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num++;
		}
		return (float)num2 / (float)i;
	}

	// Token: 0x0600F20A RID: 61962 RVA: 0x00543F4C File Offset: 0x0054214C
	public static void ObtainAchievement(int JMMILEFMACB)
	{
		if (GameManager.IsOwner())
		{
			string text = "NEW_ACHIEVEMENT_1_" + JMMILEFMACB.ToString();
			bool flag = false;
			if (SteamUserStats.GetAchievement(text, out flag) && !flag)
			{
				SteamUserStats.SetAchievement(text);
				SteamUserStats.StoreStats();
			}
		}
	}

	// Token: 0x0600F20B RID: 61963 RVA: 0x00543FA0 File Offset: 0x005421A0
	public static void ObtainAchievementProgress(int JMMILEFMACB, int IADPPJHIMBG)
	{
		if (GameManager.IsOwner())
		{
			string pchName = "NEW_ACHIEVEMENT_1_" + JMMILEFMACB.ToString();
			bool flag = false;
			if (SteamUserStats.GetAchievement(pchName, out flag) && !flag)
			{
				SteamUserStats.SetStat("achievements.id" + JMMILEFMACB + ".progress", IADPPJHIMBG);
				SteamUserStats.StoreStats();
			}
		}
	}

	// Token: 0x0600F20C RID: 61964 RVA: 0x00544008 File Offset: 0x00542208
	public static int GetStat(string JMMILEFMACB)
	{
		int result = 0;
		if (SteamUserStats.GetStat(JMMILEFMACB, out result))
		{
			return result;
		}
		return result;
	}

	// Token: 0x0600F20D RID: 61965 RVA: 0x00544028 File Offset: 0x00542228
	public static float GetStatFloat(string JMMILEFMACB)
	{
		float result = 0f;
		if (SteamUserStats.GetStat(JMMILEFMACB, out result))
		{
			return result;
		}
		return result;
	}

	// Token: 0x0600F20E RID: 61966 RVA: 0x0054404B File Offset: 0x0054224B
	public static void SetStat(string JMMILEFMACB, int DPNHODJHGJL)
	{
		if (GameManager.IsOwner())
		{
			SteamUserStats.SetStat(JMMILEFMACB, DPNHODJHGJL);
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x0600F20F RID: 61967 RVA: 0x00544068 File Offset: 0x00542268
	public static void AddToStat(string JMMILEFMACB, int DPNHODJHGJL)
	{
		if (GameManager.IsOwner())
		{
			int stat = Helpers.GetStat(JMMILEFMACB);
			SteamUserStats.SetStat(JMMILEFMACB, stat + DPNHODJHGJL);
			SteamUserStats.StoreStats();
		}
	}

	// Token: 0x0600F210 RID: 61968 RVA: 0x00544098 File Offset: 0x00542298
	public static int GetIndex(Dictionary<string, FullMapData> BNBPKEFNIFI, string HFEFHOPOLIK)
	{
		for (int i = 0; i < BNBPKEFNIFI.Count; i++)
		{
			if (BNBPKEFNIFI.Skip(i).First<KeyValuePair<string, FullMapData>>().Key == HFEFHOPOLIK)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0600F211 RID: 61969 RVA: 0x005440E0 File Offset: 0x005422E0
	public static Color StringToColor(string KLOGENNCEPK)
	{
		string[] array = KLOGENNCEPK.Split(new char[]
		{
			','
		});
		Color result = new Color(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]));
		return result;
	}

	// Token: 0x0600F212 RID: 61970 RVA: 0x00544120 File Offset: 0x00542320
	public static string ColorToString(Color HABLFKCCKLN)
	{
		return string.Concat(new object[]
		{
			string.Empty,
			HABLFKCCKLN.r,
			",",
			HABLFKCCKLN.g,
			",",
			HABLFKCCKLN.b
		});
	}

	// Token: 0x0600F213 RID: 61971 RVA: 0x00544180 File Offset: 0x00542380
	public static string CalculateMD5(string DDAOMDPAIEP)
	{
		string result;
		using (MD5 md = MD5.Create())
		{
			using (FileStream fileStream = File.OpenRead(DDAOMDPAIEP))
			{
				byte[] value = md.ComputeHash(fileStream);
				result = BitConverter.ToString(value).Replace("-", string.Empty).ToLowerInvariant();
			}
		}
		return result;
	}

	// Token: 0x0600F214 RID: 61972 RVA: 0x005441FC File Offset: 0x005423FC
	public static string Md5Sum(string FPNPDIKFPEG)
	{
		if (!string.IsNullOrEmpty(FPNPDIKFPEG))
		{
			UTF8Encoding utf8Encoding = new UTF8Encoding();
			byte[] bytes = utf8Encoding.GetBytes(FPNPDIKFPEG);
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = md5CryptoServiceProvider.ComputeHash(bytes);
			string text = string.Empty;
			for (int i = 0; i < array.Length; i++)
			{
				text += Convert.ToString(array[i], 16).PadLeft(2, '0');
			}
			return text.PadLeft(32, '0');
		}
		return null;
	}

	// Token: 0x0600F215 RID: 61973 RVA: 0x00544278 File Offset: 0x00542478
	public static string GetDirectory(string NBEBMKFPBEP)
	{
		NBEBMKFPBEP = Application.dataPath + "/../" + NBEBMKFPBEP;
		return NBEBMKFPBEP;
	}

	// Token: 0x0600F216 RID: 61974 RVA: 0x00544290 File Offset: 0x00542490
	public static void DirectoryCopy(string DLJFEBLOHAE, string JODLOJBNAEH, bool BHOINKKEABD)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(DLJFEBLOHAE);
		if (!directoryInfo.Exists)
		{
			throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + DLJFEBLOHAE);
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		if (!Directory.Exists(JODLOJBNAEH))
		{
			Directory.CreateDirectory(JODLOJBNAEH);
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			string destFileName = Path.Combine(JODLOJBNAEH, fileInfo.Name);
			fileInfo.CopyTo(destFileName, false);
		}
		if (BHOINKKEABD)
		{
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				string jodlojbnaeh = Path.Combine(JODLOJBNAEH, directoryInfo2.Name);
				Helpers.DirectoryCopy(directoryInfo2.FullName, jodlojbnaeh, BHOINKKEABD);
			}
		}
	}

	// Token: 0x0600F217 RID: 61975 RVA: 0x00544364 File Offset: 0x00542564
	public static Color ColorGradient(Color MGHJCGBNEPL, Color NBPMHDANECK, float DPNHODJHGJL)
	{
		Gradient gradient = new Gradient();
		GradientColorKey[] array = new GradientColorKey[2];
		array[0].color = NBPMHDANECK;
		array[0].time = 0f;
		array[1].color = MGHJCGBNEPL;
		array[1].time = 1f;
		GradientAlphaKey[] array2 = new GradientAlphaKey[2];
		array2[0].alpha = 1f;
		array2[0].time = 0f;
		array2[1].alpha = 1f;
		array2[1].time = 1f;
		gradient.SetKeys(array, array2);
		return gradient.Evaluate(DPNHODJHGJL);
	}

	// Token: 0x0600F218 RID: 61976 RVA: 0x00544414 File Offset: 0x00542614
	public static void ClearDirectory(string LFLCJFDDFAG)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(LFLCJFDDFAG);
		foreach (FileInfo fileInfo in directoryInfo.GetFiles())
		{
			fileInfo.Delete();
		}
		foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
		{
			Helpers.ClearDirectory(directoryInfo2.FullName);
			directoryInfo2.Delete();
		}
	}

	// Token: 0x0600F219 RID: 61977 RVA: 0x00544488 File Offset: 0x00542688
	public static void CheckDirectory(string BOGDHCDIMHN)
	{
		if (!Directory.Exists(BOGDHCDIMHN))
		{
			Directory.CreateDirectory(BOGDHCDIMHN);
		}
	}

	// Token: 0x0600F21A RID: 61978 RVA: 0x0054449C File Offset: 0x0054269C
	public static IEnumerator LoadAudio(string NBEBMKFPBEP, bool NFJAJLPOOCA = false)
	{
		Helpers.resultAudio = null;
		if (!NFJAJLPOOCA)
		{
			NBEBMKFPBEP = Helpers.GetDirectory(NBEBMKFPBEP);
		}
		WWW www = new WWW("file://" + NBEBMKFPBEP);
		yield return www;
		Helpers.resultAudio = www.GetAudioClip(false);
		yield return Helpers.resultAudio;
		yield break;
	}

	// Token: 0x0600F21B RID: 61979 RVA: 0x005444C0 File Offset: 0x005426C0
	public static IEnumerator GetAudioLength(string NBEBMKFPBEP, bool NFJAJLPOOCA = false)
	{
		Helpers.resultAudioLength = 0f;
		if (!NFJAJLPOOCA)
		{
			NBEBMKFPBEP = Helpers.GetDirectory(NBEBMKFPBEP);
		}
		if (new FileInfo(NBEBMKFPBEP).Extension.ToLower() != ".mp3")
		{
			WWW www = new WWW("file://" + NBEBMKFPBEP);
			yield return www;
			Helpers.resultAudioLength = www.GetAudioClip(false, true).length;
			yield return Helpers.resultAudioLength;
		}
		else
		{
			AudioFileReader audioFileReader = new AudioFileReader(NBEBMKFPBEP);
			Helpers.resultAudioLength = (float)audioFileReader.TotalTime.TotalSeconds;
		}
		yield break;
	}

	// Token: 0x0600F21C RID: 61980 RVA: 0x005444E4 File Offset: 0x005426E4
	public static IEnumerator LoadText(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string key = HAEBGHHMEBH;
		string value = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(fullName);
		}
		yield return true;
		if (!Helpers.textResult.ContainsKey(key))
		{
			Helpers.textResult.Add(key, value);
		}
		else
		{
			Helpers.textResult[key] = value;
		}
		yield break;
	}

	// Token: 0x0600F21D RID: 61981 RVA: 0x00544508 File Offset: 0x00542708
	public static string LoadTextString(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string result = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			result = File.ReadAllText(fullName);
		}
		return result;
	}

	// Token: 0x0600F21E RID: 61982 RVA: 0x00544548 File Offset: 0x00542748
	public static void LoadMapConfig(string HAEBGHHMEBH, bool NFJAJLPOOCA = false)
	{
		string key = HAEBGHHMEBH;
		string value = null;
		if (!NFJAJLPOOCA)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		string fullName = new FileInfo(HAEBGHHMEBH).FullName;
		if (File.Exists(fullName))
		{
			value = File.ReadAllText(GameManager.Decrypt(fullName));
		}
		if (!Helpers.textResult.ContainsKey(key))
		{
			Helpers.textResult.Add(key, value);
		}
		else
		{
			Helpers.textResult[key] = value;
		}
	}

	// Token: 0x0600F21F RID: 61983 RVA: 0x005445B8 File Offset: 0x005427B8
	public static IEnumerator SaveFile(string HAEBGHHMEBH, string NOJGGCLPPAM, bool HIIOLMMOCPN = false)
	{
		if (!HIIOLMMOCPN)
		{
			HAEBGHHMEBH = Helpers.GetDirectory(HAEBGHHMEBH);
		}
		if (File.Exists(HAEBGHHMEBH))
		{
			File.Delete(HAEBGHHMEBH);
		}
		File.WriteAllText(HAEBGHHMEBH, NOJGGCLPPAM);
		yield return null;
		yield break;
	}

	// Token: 0x0600F220 RID: 61984 RVA: 0x005445E4 File Offset: 0x005427E4
	public static void SetColor(string EBEHBBDKDFJ, Color HABLFKCCKLN)
	{
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".r", HABLFKCCKLN.r, null);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".g", HABLFKCCKLN.g, null);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".b", HABLFKCCKLN.b, null);
		Singleton<SaveSystem>.Instance.SetFloat(EBEHBBDKDFJ + ".a", HABLFKCCKLN.a, null);
	}

	// Token: 0x0600F221 RID: 61985 RVA: 0x00544668 File Offset: 0x00542868
	public static Color GetColor(string EBEHBBDKDFJ, Color HABLFKCCKLN)
	{
		return new Color(0f, 0f, 0f, 0f)
		{
			r = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".r", HABLFKCCKLN.r, null),
			g = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".g", HABLFKCCKLN.g, null),
			b = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".b", HABLFKCCKLN.b, null),
			a = Singleton<SaveSystem>.Instance.GetFloat(EBEHBBDKDFJ + ".a", HABLFKCCKLN.a, null)
		};
	}

	// Token: 0x0600F222 RID: 61986 RVA: 0x00544724 File Offset: 0x00542924
	public static void DeleteColorKey(string EBEHBBDKDFJ)
	{
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".r", null);
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".g", null);
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".b", null);
		Singleton<SaveSystem>.Instance.DeleteKey(EBEHBBDKDFJ + ".a", null);
	}

	// Token: 0x0600F223 RID: 61987 RVA: 0x0054478C File Offset: 0x0054298C
	public static Texture2D FlipTexture(Texture2D LMHCHLAIMJH)
	{
		if (LMHCHLAIMJH != null)
		{
			Texture2D texture2D = new Texture2D(LMHCHLAIMJH.width, LMHCHLAIMJH.height);
			int width = LMHCHLAIMJH.width;
			int height = LMHCHLAIMJH.height;
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					texture2D.SetPixel(i, height - j - 1, LMHCHLAIMJH.GetPixel(i, j));
				}
			}
			texture2D.Apply();
			return texture2D;
		}
		return new Texture2D(2, 2);
	}

	// Token: 0x0600F224 RID: 61988 RVA: 0x00544814 File Offset: 0x00542A14
	public static Texture2D GetSteamImageAsTexture2D(int JLGNPNGBLOA)
	{
		Texture2D texture2D = null;
		uint num;
		uint num2;
		bool flag = SteamUtils.GetImageSize(JLGNPNGBLOA, out num, out num2);
		if (flag)
		{
			byte[] array = new byte[num * num2 * 4U];
			flag = SteamUtils.GetImageRGBA(JLGNPNGBLOA, array, (int)(num * num2 * 4U));
			if (flag)
			{
				texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, false);
				texture2D.LoadRawTextureData(array);
				texture2D.Apply();
			}
		}
		return Helpers.FlipTexture(texture2D);
	}

	// Token: 0x0600F225 RID: 61989 RVA: 0x00544874 File Offset: 0x00542A74
	public static float[] GetWaveform(AudioClip LDJFFDCLEFG, int FEKLGMEFABB)
	{
		FEKLGMEFABB = LDJFFDCLEFG.frequency / FEKLGMEFABB;
		float[] array = new float[LDJFFDCLEFG.samples * LDJFFDCLEFG.channels];
		float[] array2 = new float[array.Length / (FEKLGMEFABB * LDJFFDCLEFG.channels)];
		LDJFFDCLEFG.GetData(array, 0);
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = 0f;
			for (int j = 0; j < FEKLGMEFABB; j++)
			{
				array2[i] += Mathf.Abs(array[i * LDJFFDCLEFG.channels * FEKLGMEFABB + j]);
			}
			array2[i] /= (float)FEKLGMEFABB;
		}
		return array2;
	}

	// Token: 0x0600F226 RID: 61990 RVA: 0x00544914 File Offset: 0x00542B14
	public static Texture2D PaintWaveformSpectrum(float[] IPAAACMOHAB, int PBMAGEKDPLI, Color ONHIBAJJACC, Color NCFLAHLHKPI)
	{
		Texture2D texture2D = new Texture2D(IPAAACMOHAB.Length, PBMAGEKDPLI, TextureFormat.RGBA32, true);
		for (int i = 0; i < IPAAACMOHAB.Length; i++)
		{
			int num = 0;
			while ((float)num <= (float)PBMAGEKDPLI / 2f)
			{
				texture2D.SetPixel(i, num, NCFLAHLHKPI);
				texture2D.SetPixel(i, -num, NCFLAHLHKPI);
				num++;
			}
		}
		for (int j = 0; j < IPAAACMOHAB.Length; j++)
		{
			int num2 = 0;
			while ((float)num2 <= IPAAACMOHAB[j] * (float)PBMAGEKDPLI / 2f)
			{
				texture2D.SetPixel(j, PBMAGEKDPLI / 2 + num2, ONHIBAJJACC);
				texture2D.SetPixel(j, PBMAGEKDPLI / 2 - num2, ONHIBAJJACC);
				num2++;
			}
		}
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x0600F227 RID: 61991 RVA: 0x005449C7 File Offset: 0x00542BC7
	public static float DbToNormal(float HDAMKJKNKJI)
	{
		return Mathf.Pow(10f, HDAMKJKNKJI / 20f);
	}

	// Token: 0x0600F228 RID: 61992 RVA: 0x005449DA File Offset: 0x00542BDA
	public static float NormalToDb(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 0f) ? -80f : (20f * Mathf.Log10(JCLIHOKDOHN));
	}

	// Token: 0x0600F229 RID: 61993 RVA: 0x00544A00 File Offset: 0x00542C00
	public static string GetRelativeDateTime(DateTime MJHMIFPOJEA)
	{
		string result = string.Empty;
		TimeSpan t = DateTime.Now.Subtract(MJHMIFPOJEA);
		if (t <= TimeSpan.FromSeconds(60.0))
		{
			result = string.Format("{0} seconds ago", t.Seconds);
		}
		else if (t <= TimeSpan.FromMinutes(60.0))
		{
			result = ((t.Minutes <= 1) ? "a minute ago" : string.Format("{0} minutes ago", t.Minutes));
		}
		else if (t <= TimeSpan.FromHours(24.0))
		{
			result = ((t.Hours <= 1) ? "an hour ago" : string.Format("{0} hours ago", t.Hours));
		}
		else if (t <= TimeSpan.FromDays(30.0))
		{
			result = ((t.Days <= 1) ? "yesterday" : string.Format("{0} days ago", t.Days));
		}
		else if (t <= TimeSpan.FromDays(365.0))
		{
			result = ((t.Days <= 30) ? "a month ago" : string.Format("{0} months ago", t.Days / 30));
		}
		else
		{
			result = ((t.Days <= 365) ? "a year ago" : string.Format("{0} years ago", t.Days / 365));
		}
		return result;
	}

	// Token: 0x0600F22A RID: 61994 RVA: 0x00544BC4 File Offset: 0x00542DC4
	public static string RemoveSpecialCharacters(string DPNHODJHGJL, char[] MPOJANPJEHH)
	{
		return new string(DPNHODJHGJL.Except(MPOJANPJEHH).ToArray<char>());
	}

	// Token: 0x0600F22B RID: 61995 RVA: 0x00544BD8 File Offset: 0x00542DD8
	public static List<EditorEventFunctionInfo> GetAvailableEditorEvents(int NCCNGCFMNII)
	{
		Helpers.GONBBDCKFPG gonbbdckfpg = new Helpers.GONBBDCKFPG();
		gonbbdckfpg.NCCNGCFMNII = NCCNGCFMNII;
		return Helpers.eventsMap.Where(new Func<EditorEventFunctionInfo, bool>(gonbbdckfpg.GBKBDKHPLKG)).ToList<EditorEventFunctionInfo>();
	}

	// Token: 0x0600F22C RID: 61996 RVA: 0x00544C10 File Offset: 0x00542E10
	public static string FormatTime(float HHGFDGOKNMD, bool BLCMJNECOGL = false)
	{
		int num = (int)Mathf.Abs(HHGFDGOKNMD / 60f);
		int num2 = (int)(HHGFDGOKNMD % 60f);
		string text = string.Empty + (HHGFDGOKNMD % 1f).ToString("0.000").Remove(0, 1);
		return num.ToString("00") + ":" + num2.ToString("00") + (BLCMJNECOGL ? text : string.Empty);
	}

	// Token: 0x0600F22D RID: 61997 RVA: 0x00544C8D File Offset: 0x00542E8D
	public static string ToReadableAgeString(this TimeSpan NMCHKFGKGFJ)
	{
		return string.Format("{0:0}", (double)NMCHKFGKGFJ.Days / 365.25);
	}

	// Token: 0x0600F22E RID: 61998 RVA: 0x00544CB0 File Offset: 0x00542EB0
	public static string ToReadableString(this TimeSpan NMCHKFGKGFJ)
	{
		string text = string.Empty;
		if (NMCHKFGKGFJ.Duration().Days > 1)
		{
			text = string.Format("{0}", (NMCHKFGKGFJ.Duration().Days <= 0) ? string.Empty : string.Format("{0:0} day{1}, ", NMCHKFGKGFJ.Days, (NMCHKFGKGFJ.Days != 1) ? "s" : string.Empty));
		}
		else if (NMCHKFGKGFJ.Duration().Hours > 0)
		{
			text = string.Format("{0}{1}{2}", (NMCHKFGKGFJ.Duration().Days <= 0) ? string.Empty : string.Format("{0:0} day{1}, ", NMCHKFGKGFJ.Days, (NMCHKFGKGFJ.Days != 1) ? "s" : string.Empty), (NMCHKFGKGFJ.Duration().Hours <= 0) ? string.Empty : string.Format("{0:0} hour{1}, ", NMCHKFGKGFJ.Hours, (NMCHKFGKGFJ.Hours != 1) ? "s" : string.Empty), (NMCHKFGKGFJ.Duration().Minutes <= 0) ? string.Empty : string.Format("{0:0} minute{1}, ", NMCHKFGKGFJ.Minutes, (NMCHKFGKGFJ.Minutes != 1) ? "s" : string.Empty));
		}
		else if (NMCHKFGKGFJ.Duration().Minutes > 0)
		{
			text = string.Format("{0}", (NMCHKFGKGFJ.Duration().Minutes <= 0) ? string.Empty : string.Format("{0:0} minute{1}, ", NMCHKFGKGFJ.Minutes, (NMCHKFGKGFJ.Minutes != 1) ? "s" : string.Empty));
		}
		else
		{
			text = string.Format("{0}", (NMCHKFGKGFJ.Duration().Seconds < 0) ? string.Empty : string.Format("{0:0} second{1}", NMCHKFGKGFJ.Seconds, (NMCHKFGKGFJ.Seconds != 1) ? "s" : string.Empty));
		}
		if (text.EndsWith(", "))
		{
			text = text.Substring(0, text.Length - 2);
		}
		if (string.IsNullOrEmpty(text))
		{
			text = "0 seconds";
		}
		return text;
	}

	// Token: 0x0600F22F RID: 61999 RVA: 0x00544F5C File Offset: 0x0054315C
	public static bool isChallengeUnlocked(string EKFAHHJOJHE)
	{
		if (string.IsNullOrEmpty(EKFAHHJOJHE))
		{
			return true;
		}
		bool result = true;
		foreach (string str in EKFAHHJOJHE.Replace(" ", string.Empty).Split(new char[]
		{
			','
		}).ToList<string>())
		{
			if (Singleton<SaveSystem>.Instance.GetInt("challenges." + str + ".status", null) < 2)
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x0600F231 RID: 62001 RVA: 0x005462A7 File Offset: 0x005444A7
	[CompilerGenerated]
	private static bool LFJDIMOEADJ(char HBJIMONFKNL)
	{
		return HBJIMONFKNL == '-';
	}

	// Token: 0x0600F232 RID: 62002 RVA: 0x005462AE File Offset: 0x005444AE
	[CompilerGenerated]
	private static double PMBAHAIECAN(double LPGNCFKLMEH)
	{
		return -LPGNCFKLMEH;
	}

	// Token: 0x0600F233 RID: 62003 RVA: 0x005462B2 File Offset: 0x005444B2
	[CompilerGenerated]
	private static bool NDFPKEBFAGM(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "SpawnObj";
	}

	// Token: 0x04001AD4 RID: 6868
	public static string levelConfigFileName = "config.txt";

	// Token: 0x04001AD5 RID: 6869
	public static string mapEncodedConfigFileName = "map.data";

	// Token: 0x04001AD6 RID: 6870
	public static string workshopConfigFileName = "workshop.txt";

	// Token: 0x04001AD7 RID: 6871
	public static string newsURL = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510";

	// Token: 0x04001AD8 RID: 6872
	public static string newsGIDURL = "/GetNews/pinnednewsid";

	// Token: 0x04001AD9 RID: 6873
	public static List<string> specialTags = new List<string>
	{
		"Winter2020"
	};

	// Token: 0x04001ADA RID: 6874
	public static List<string> tags = new List<string>
	{
		"Alternative",
		"Anime",
		"Blues",
		"Children",
		"Classical",
		"Dance",
		"Electronic",
		"Folk",
		"Hip-hop",
		"Indie",
		"Instrumental",
		"Jazz",
		"Metal",
		"Pop",
		"Rap",
		"Rock",
		"Soundtrack",
		"Other"
	};

	// Token: 0x04001ADB RID: 6875
	public static List<string> patternsMap = new List<string>
	{
		"[Up]",
		"[Right]",
		"[Down]",
		"[Left]",
		"[Up-Right-Left]",
		"[Up-Right-Down]",
		"[Right-Down-Left]",
		"[Up-Down-Left]",
		"[Up-Right-Down-Left]",
		"[PowerUp]",
		"[Up-Right]",
		"[Up-Down]",
		"[Up-Left]",
		"[Right-Down]",
		"[Right-Left]",
		"[Down-Left]"
	};

	// Token: 0x04001ADC RID: 6876
	public static string eventsMapLine = "\n";

	// Token: 0x04001ADD RID: 6877
	public static List<EditorEventFunctionInfo> eventsMap = new List<EditorEventFunctionInfo>
	{
		new EditorEventFunctionInfo("SpawnObj", "Arc", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("arc", EditorEventFunctionInfo.EditorEventParametrType.ArcSelector, string.Empty, null),
			new EditorEventFunctionInfo.EditorEventParametr("hand", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - default, 1 - left, 2 - right", "0,2,true,0")
		}, "Spawn ark to be pressed at this time", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetSpeed", "Set Arcs Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "1,30,true,0")
		}, "Set arcs speed. Base value - 15", 2, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("MapEnd", "Music End", new List<EditorEventFunctionInfo.EditorEventParametr>(), "Set the end of the map. Use this if you want to cut the long music.", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("ShowSprite", "Show Image", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("resource id", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, null),
			new EditorEventFunctionInfo.EditorEventParametr("position", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - background, 1 - foreground", "0,1,true,0"),
			new EditorEventFunctionInfo.EditorEventParametr(string.Empty, EditorEventFunctionInfo.EditorEventParametrType.Toggle, string.Empty, "keep aspect ratio"),
			new EditorEventFunctionInfo.EditorEventParametr("duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "in seconds. 0 - forever", "float,10"),
			new EditorEventFunctionInfo.EditorEventParametr("fade in duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "seconds", "float,0.5"),
			new EditorEventFunctionInfo.EditorEventParametr("fade out duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "seconds", "float,0.5")
		}, "Show image from resources by id at the center of the screen at foreground or background", 1, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("ShowTitle", "Show Title", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("title", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, null),
			new EditorEventFunctionInfo.EditorEventParametr("duration", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Message duration multiplier. Recomended 1", "float,1")
		}, "Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", 1, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetBGColor", "Set Background Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("red", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("green", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("blue", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "0,1,false"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Lerp speed. Recomended 10", "float,10")
		}, "Set camera background color", 1, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetPlayerDistance", "Set Player Distance", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("distance", EditorEventFunctionInfo.EditorEventParametrType.Slider, string.Empty, "4,28,true,0")
		}, "Set camera (or player) distance. Base player distance - 14", 1, -1, EditorEventFunctionInfo.EditorEventType.Arcs),
		new EditorEventFunctionInfo("SetTrailZoomSpeed", "Set Trail Zoom Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Zoom speed. Base 1.5", "float,1.5")
		}, "Set Trail Zoom (player camera move forward effect). Base value - 1.5", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("AddEnvironmentObject", "Add Environment Object", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("type", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0 - sun, 1 - satellite, 2 - particles emitter", "0,2,true,0"),
			new EditorEventFunctionInfo.EditorEventParametr("set id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null)
		}, "Spawn new environment object (sun, satellite etc) and sets its id", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("RemoveEnvironmentObject", "Remove Environment Object", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null)
		}, "Despawn environment object by id", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("ClearEnvironment", "Clear Environment", new List<EditorEventFunctionInfo.EditorEventParametr>(), "Destroy all spawned environment objects", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetPosition", "Set Object Position", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Move environment object to the position", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetRotation", "Set Object Rotation", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Rotate environment object to the rotation", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetScale", "Set Object Scale", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Scale environment object by the values", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParent", "Set Parent", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("Object ID", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("Parent ID", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Parent object ID. Case-Sensitive", null)
		}, "Set object anchor to another object", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunColors", "Set Sun Colors", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("max. lives color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null),
			new EditorEventFunctionInfo.EditorEventParametr("no lives color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null)
		}, "Set sun colors", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunEmission", "Set Sun Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set sun emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunInput", "Set Sun Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set sun audio input", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunLerpSpeed", "Set Sun Lerp Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set sun lerp speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunSensitivity", "Set Sun Sensitivity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,50")
		}, "Set sun beat detection sensitivity", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunMinSize", "Set Sun MinSize", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set sun min/max size", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunMaxSize", "Set Sun MaxSize", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set sun min/max size", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSunDirectionVector", "Set Sun DirectionVector", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("x", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1"),
			new EditorEventFunctionInfo.EditorEventParametr("y", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1"),
			new EditorEventFunctionInfo.EditorEventParametr("z", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set sun directionVector - in which direction sun will grow on beat", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteColor", "Set Satellite Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null)
		}, "Set satellite color", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteEmission", "Set Satellite Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set satellite emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteInput", "Set Satellite Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set satellite audio input", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteLerpSpeed", "Set Satellite Lerp Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set satellite lerp speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteSensitivity", "Set Satellite Sensitivity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,50")
		}, "Set satellite beat detection sensitivity", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteRotationSpeed", "SetSatelliteRotationSpeed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,40")
		}, "Set satellite clockwise rotattion speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteRadius", "Set Satellite Radius", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite radius (offset)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteTrailLength", "Set Satellite Trail Length", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite trail length in seconds", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteTrailWidth", "Set Satellite Trail Width", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite trail width", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetSatelliteTrailMinVertexDistance", "Set Satellite Trail MinVertexDistance", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,2")
		}, "Set satellite MinVertexDistance - how much distance should be between to points of the trail line", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetCrosshairColor", "Set Crosshair Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Lerp speed. Recomended 10", "float,10")
		}, "Set crosshair color", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetCrosshairEmission", "Set Crosshair Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set crosshair emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesColor", "Set Particles Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Hex value #RRGGBB", null)
		}, "Set particles color", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesEmission", "Set Particles Emission", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1.5")
		}, "Set particless emission (glow)", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesParticleSize", "Set Particle Size", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,1")
		}, "Set particles size", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesGravity", "Set Particles Gravity", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles gravity", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesParticleSpeed", "Set Particles Speed", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles start speed", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesCountPerBeat", "Set Particles Count Per Beat", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("value", EditorEventFunctionInfo.EditorEventParametrType.InputField, string.Empty, "float,0")
		}, "Set particles count per one beat", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetParticlesInput", "Set Particles Input", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("input", EditorEventFunctionInfo.EditorEventParametrType.Slider, "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", "0,7,true,0")
		}, "Set particles audio input", 2, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("AddEnvironmentSprite", "Add Environment Sprite", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("resource id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "(from resources)", null),
			new EditorEventFunctionInfo.EditorEventParametr("set environment id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", "float,10"),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Start Color's hex value #RRGGBBAA", "#FFFFFFFF")
		}, "Spawn new environment sprite (image) and sets its id", 3, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetEnvSpriteImage", "Set EnvSprite Image", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("image", EditorEventFunctionInfo.EditorEventParametrType.InputField, "New resource ID. Case-Sensitive", null)
		}, "Switch environment sprite image", 3, -1, EditorEventFunctionInfo.EditorEventType.Storyboard),
		new EditorEventFunctionInfo("SetEnvSpriteColor", "Set EnvSprite Color", new List<EditorEventFunctionInfo.EditorEventParametr>
		{
			new EditorEventFunctionInfo.EditorEventParametr("id", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Object ID. Case-Sensitive", null),
			new EditorEventFunctionInfo.EditorEventParametr("color", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Color's hex value #RRGGBBAA", "#FFFFFFFF"),
			new EditorEventFunctionInfo.EditorEventParametr("speed", EditorEventFunctionInfo.EditorEventParametrType.InputField, "Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", "float,10")
		}, "Set environment sprite color and alpha.", 3, -1, EditorEventFunctionInfo.EditorEventType.Storyboard)
	};

	// Token: 0x04001ADE RID: 6878
	public static Dictionary<string, string> textResult = new Dictionary<string, string>();

	// Token: 0x04001ADF RID: 6879
	public static Sprite resultImage = null;

	// Token: 0x04001AE0 RID: 6880
	public static Dictionary<string, bool> resultLevelNotModified = new Dictionary<string, bool>();

	// Token: 0x04001AE1 RID: 6881
	public static bool resultSubmitNewHash = false;

	// Token: 0x04001AE2 RID: 6882
	public static AudioClip resultAudio = null;

	// Token: 0x04001AE3 RID: 6883
	public static float resultAudioLength = 0f;

	// Token: 0x04001AE4 RID: 6884
	[CompilerGenerated]
	private static Func<char, bool> LNIJKGECNME;

	// Token: 0x04001AE5 RID: 6885
	[CompilerGenerated]
	private static Func<double, double> CLCBJCKCBDD;

	// Token: 0x04001AE6 RID: 6886
	[CompilerGenerated]
	private static Func<MapEvent, bool> HCLEECLNOEA;

	// Token: 0x02000420 RID: 1056
	[CompilerGenerated]
	private sealed class CEMBABEIJBO
	{
		// Token: 0x0600F234 RID: 62004 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool AHBIANHNBBC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F235 RID: 62005 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool NBFOKGGNEOJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F236 RID: 62006 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool LLNDDFGPOPL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F237 RID: 62007 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool LADECCOJPPL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F238 RID: 62008 RVA: 0x00546301 File Offset: 0x00544501
		internal bool DIOBKCECBCH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F239 RID: 62009 RVA: 0x00546301 File Offset: 0x00544501
		internal bool DGDCNDCGPCP(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F23A RID: 62010 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool JKEDCEOCPJO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F23B RID: 62011 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool GBKBDKHPLKG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F23D RID: 62013 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool LDNDNOOCFFA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F23E RID: 62014 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool MBOCPCMMJDI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F23F RID: 62015 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool JBAJEMGOPDL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F240 RID: 62016 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool HNMFCOHLALO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F241 RID: 62017 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool IMOHKBJBLBA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F242 RID: 62018 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool ECGDAHDOPBO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F243 RID: 62019 RVA: 0x00546301 File Offset: 0x00544501
		internal bool BOPKCHEPEEB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F244 RID: 62020 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool NPLKFNFPOKC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F245 RID: 62021 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool PEJNJBGMPKB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F246 RID: 62022 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool GMLFBOMLINM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F247 RID: 62023 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool OFLDIMDDLHM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F248 RID: 62024 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool LNDGINDKPFA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F249 RID: 62025 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool CHBEFOHEEGK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F24A RID: 62026 RVA: 0x00546325 File Offset: 0x00544525
		internal bool FBECAHEMHOO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F24B RID: 62027 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool BOJCHGIGGNK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F24C RID: 62028 RVA: 0x00546349 File Offset: 0x00544549
		internal bool JIMIGOHADJG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F24D RID: 62029 RVA: 0x00546349 File Offset: 0x00544549
		internal bool BFNOHOLLLHB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F24E RID: 62030 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool BFEABMIFIEE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F24F RID: 62031 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool PIJAOCFAPKC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F250 RID: 62032 RVA: 0x00546349 File Offset: 0x00544549
		internal bool HKCAPINMNFF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F251 RID: 62033 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool FHIJCPPECHA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F252 RID: 62034 RVA: 0x00546349 File Offset: 0x00544549
		internal bool FPBODMOMNPG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F253 RID: 62035 RVA: 0x00546349 File Offset: 0x00544549
		internal bool NHPDJEKEOKI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F254 RID: 62036 RVA: 0x00546301 File Offset: 0x00544501
		internal bool KDDPLGEFPEJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x00546325 File Offset: 0x00544525
		internal bool PHDFIAGENEE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F256 RID: 62038 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool INHOEMCLAAP(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F257 RID: 62039 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool FFEGPHJKMFK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F258 RID: 62040 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool AHHNAGGBKOO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F259 RID: 62041 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool IGFOBPKFCDJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool JPICHJKIMDH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x00546325 File Offset: 0x00544525
		internal bool FKCDLJELMNN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F25C RID: 62044 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool HBJOAAJMDDE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F25D RID: 62045 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool PCDFLCEIHFF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F25E RID: 62046 RVA: 0x00546301 File Offset: 0x00544501
		internal bool GCLCICMFCPK(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F25F RID: 62047 RVA: 0x00546325 File Offset: 0x00544525
		internal bool GHBIKOKGLHE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x00546349 File Offset: 0x00544549
		internal bool GEPBCIIDMBC(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F261 RID: 62049 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool FJDBPPKABJE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F262 RID: 62050 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool DBOEBFFAOFJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F263 RID: 62051 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool JBCHBMKPDAJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F264 RID: 62052 RVA: 0x00546325 File Offset: 0x00544525
		internal bool HGOHMNAGGKI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F265 RID: 62053 RVA: 0x00546325 File Offset: 0x00544525
		internal bool OMJJLDBPEHI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F266 RID: 62054 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool MEMPOPNAEDN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F267 RID: 62055 RVA: 0x00546325 File Offset: 0x00544525
		internal bool MKLOGMNMFAF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F268 RID: 62056 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool DNIMHEKGJHB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F269 RID: 62057 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool OFHCGKJFGDI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F26A RID: 62058 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool JDELIMPGFDJ(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F26B RID: 62059 RVA: 0x00546349 File Offset: 0x00544549
		internal bool KFNPHCCAJFD(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F26C RID: 62060 RVA: 0x00546349 File Offset: 0x00544549
		internal bool HMMBBDJNGGL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F26D RID: 62061 RVA: 0x00546301 File Offset: 0x00544501
		internal bool CBHLHPPBCIG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F26E RID: 62062 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool KFNBKFELFLH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F26F RID: 62063 RVA: 0x00546349 File Offset: 0x00544549
		internal bool ONEPCCGOEKI(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F270 RID: 62064 RVA: 0x00546349 File Offset: 0x00544549
		internal bool CJDNDHBDMMO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F271 RID: 62065 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool DFPLMEODJAM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F272 RID: 62066 RVA: 0x00546349 File Offset: 0x00544549
		internal bool PLINPGHDODA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F273 RID: 62067 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool HJNKOEGPEMO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F274 RID: 62068 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool JPGFOBNOBKN(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F275 RID: 62069 RVA: 0x00546349 File Offset: 0x00544549
		internal bool BDNFJBBKBOL(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F276 RID: 62070 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool JBLJIFJHDLO(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F277 RID: 62071 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool KGKMOLCPDIH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F278 RID: 62072 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool EKHOOPGPPGE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F279 RID: 62073 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool HCFLGKJFKFE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F27A RID: 62074 RVA: 0x005462CA File Offset: 0x005444CA
		internal bool DPFLLMAOIHH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F27B RID: 62075 RVA: 0x00546325 File Offset: 0x00544525
		internal bool HIKCHCCKLJG(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F27C RID: 62076 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool ACJAHEOLJNH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F27D RID: 62077 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool MOJKEOEEEDF(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F27E RID: 62078 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool EFAPFFFGOOA(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F27F RID: 62079 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool HKPGGBDEHAM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F280 RID: 62080 RVA: 0x00546349 File Offset: 0x00544549
		internal bool NGFGLJGABCM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB && HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600F281 RID: 62081 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool IKMOFMJNEPH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F282 RID: 62082 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool OMBHIBNMFNB(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F283 RID: 62083 RVA: 0x00546301 File Offset: 0x00544501
		internal bool HKHIFPLBAMM(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600F284 RID: 62084 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool LGKFHOBDANE(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F285 RID: 62085 RVA: 0x005462EE File Offset: 0x005444EE
		internal bool BKNHHGBPLGH(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return HLIOCNLOFMK.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F286 RID: 62086 RVA: 0x00546301 File Offset: 0x00544501
		internal bool PHGILLBNBME(EditorEventFunctionInfo HLIOCNLOFMK)
		{
			return !(HLIOCNLOFMK.id == this.JMMILEFMACB) || HLIOCNLOFMK.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x04001AE7 RID: 6887
		internal string JMMILEFMACB;
	}

	// Token: 0x02000425 RID: 1061
	[CompilerGenerated]
	private sealed class GONBBDCKFPG
	{
		// Token: 0x0600F3AB RID: 62379 RVA: 0x005491C4 File Offset: 0x005473C4
		internal bool FIPCLHEKKCA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600F3AC RID: 62380 RVA: 0x00549214 File Offset: 0x00547414
		internal bool EGKGJJGAPMN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3AD RID: 62381 RVA: 0x00549264 File Offset: 0x00547464
		internal bool MEMPOPNAEDN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3AE RID: 62382 RVA: 0x005492B4 File Offset: 0x005474B4
		internal bool LHHFJBIAHCN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600F3B0 RID: 62384 RVA: 0x00549304 File Offset: 0x00547504
		internal bool PIJAOCFAPKC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600F3B1 RID: 62385 RVA: 0x00549354 File Offset: 0x00547554
		internal bool KGKMOLCPDIH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600F3B2 RID: 62386 RVA: 0x005493A4 File Offset: 0x005475A4
		internal bool KFNBKFELFLH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3B3 RID: 62387 RVA: 0x005493F4 File Offset: 0x005475F4
		internal bool LNDGINDKPFA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII;
		}

		// Token: 0x0600F3B4 RID: 62388 RVA: 0x00549444 File Offset: 0x00547644
		internal bool FFEGPHJKMFK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3B5 RID: 62389 RVA: 0x00549494 File Offset: 0x00547694
		internal bool FCAGEDLBBHD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII;
		}

		// Token: 0x0600F3B6 RID: 62390 RVA: 0x005494E4 File Offset: 0x005476E4
		internal bool BFEABMIFIEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600F3B7 RID: 62391 RVA: 0x00549534 File Offset: 0x00547734
		internal bool OLIGLEMPFOP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600F3B8 RID: 62392 RVA: 0x00549584 File Offset: 0x00547784
		internal bool AEINPAGJFME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600F3B9 RID: 62393 RVA: 0x005495D4 File Offset: 0x005477D4
		internal bool DNIMHEKGJHB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600F3BA RID: 62394 RVA: 0x00549624 File Offset: 0x00547824
		internal bool BDGDIDPDBHG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3BB RID: 62395 RVA: 0x00549674 File Offset: 0x00547874
		internal bool FDAIFOAGDLA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3BC RID: 62396 RVA: 0x005496C4 File Offset: 0x005478C4
		internal bool AGJKEBOPIOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600F3BD RID: 62397 RVA: 0x00549714 File Offset: 0x00547914
		internal bool JDELIMPGFDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600F3BE RID: 62398 RVA: 0x00549764 File Offset: 0x00547964
		internal bool BKNHHGBPLGH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII;
		}

		// Token: 0x0600F3BF RID: 62399 RVA: 0x005497B4 File Offset: 0x005479B4
		internal bool FHIJCPPECHA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600F3C0 RID: 62400 RVA: 0x00549804 File Offset: 0x00547A04
		internal bool LLNDDFGPOPL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600F3C1 RID: 62401 RVA: 0x00549854 File Offset: 0x00547A54
		internal bool PBCAHKDLFPE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3C2 RID: 62402 RVA: 0x005498A4 File Offset: 0x00547AA4
		internal bool GBKBDKHPLKG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 0 || (IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII));
		}

		// Token: 0x0600F3C3 RID: 62403 RVA: 0x005498F4 File Offset: 0x00547AF4
		internal bool IGFOBPKFCDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || (IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII));
		}

		// Token: 0x0600F3C4 RID: 62404 RVA: 0x00549944 File Offset: 0x00547B44
		internal bool LOEAMHGMMPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 0 && (IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600F3C5 RID: 62405 RVA: 0x00549994 File Offset: 0x00547B94
		internal bool FJDBPPKABJE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && (IACGDFHKCAE.maxConfigVersion < 1 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x0600F3C6 RID: 62406 RVA: 0x005499E4 File Offset: 0x00547BE4
		internal bool DBFPGFHEGKA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3C7 RID: 62407 RVA: 0x00549A34 File Offset: 0x00547C34
		internal bool EKHOOPGPPGE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 0 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII;
		}

		// Token: 0x0600F3C8 RID: 62408 RVA: 0x00549A84 File Offset: 0x00547C84
		internal bool OFHCGKJFGDI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII;
		}

		// Token: 0x0600F3C9 RID: 62409 RVA: 0x00549AD4 File Offset: 0x00547CD4
		internal bool BMAOCLKPNNC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 0 || IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII;
		}

		// Token: 0x0600F3CA RID: 62410 RVA: 0x00549B24 File Offset: 0x00547D24
		internal bool HBJFIOJFBHC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || IACGDFHKCAE.maxConfigVersion < 0 || IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII;
		}

		// Token: 0x0600F3CB RID: 62411 RVA: 0x00549B74 File Offset: 0x00547D74
		internal bool JKEDCEOCPJO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion > this.NCCNGCFMNII || (IACGDFHKCAE.maxConfigVersion >= 1 && IACGDFHKCAE.maxConfigVersion > 1 && IACGDFHKCAE.maxConfigVersion < this.NCCNGCFMNII);
		}

		// Token: 0x0600F3CC RID: 62412 RVA: 0x00549BC4 File Offset: 0x00547DC4
		internal bool DKGPCPBNDPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.minConfigVersion <= this.NCCNGCFMNII && IACGDFHKCAE.maxConfigVersion >= 1 && (IACGDFHKCAE.maxConfigVersion <= 1 || IACGDFHKCAE.maxConfigVersion >= this.NCCNGCFMNII);
		}

		// Token: 0x04001B02 RID: 6914
		internal int NCCNGCFMNII;
	}
}
