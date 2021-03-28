using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Steamworks;
using UnityEngine;

namespace SunCubeStudio.Localization
{
	// Token: 0x02000166 RID: 358
	public class LocalizationService : MonoBehaviour
	{
		// Token: 0x0600695D RID: 26973 RVA: 0x0020904C File Offset: 0x0020724C
		private void DFDFMLIOCID(string[] BDGDDFKKGGA)
		{
			if (BDGDDFKKGGA.Length == 1)
			{
				Debug.Log("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys");
			}
			else if (BDGDDFKKGGA.Length < 2)
			{
				Debug.LogError("Command not found!");
			}
			else
			{
				if (BDGDDFKKGGA[1] == "set")
				{
					if (BDGDDFKKGGA.Length != 3)
					{
						Debug.LogError("Bad parameters for set! Use <language>");
					}
					else
					{
						this.Localization = BDGDDFKKGGA[2];
					}
				}
				if (BDGDDFKKGGA[1] == "keys")
				{
					if (BDGDDFKKGGA.Length != 3)
					{
						Debug.LogError("Bad parameters for set! Use <language>");
					}
					else
					{
						this.FINGICADKLD(BDGDDFKKGGA[2]);
					}
				}
				if (BDGDDFKKGGA[1] == "list")
				{
					this.NDMCKFGFDCO();
				}
			}
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00209108 File Offset: 0x00207308
		private IEnumerator HJFCOAHCFIG()
		{
			if (LocalizationService.BOGJGOAMCHK == null)
			{
				LocalizationService.BOGJGOAMCHK = new Func<bool>(SteamManager.get_Initialized);
			}
			yield return new WaitUntil(LocalizationService.BOGJGOAMCHK);
			this.Initialize();
			yield break;
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x00209123 File Offset: 0x00207323
		public string IAAEBJKAHDD(string HFEFHOPOLIK)
		{
			return this.FDOPKCOIDMF(HFEFHOPOLIK, this.COKBPGHMAFH);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06006960 RID: 26976 RVA: 0x00209132 File Offset: 0x00207332
		// (set) Token: 0x06006979 RID: 27001 RVA: 0x00209B9B File Offset: 0x00207D9B
		public string Localization
		{
			get
			{
				return this.COKBPGHMAFH;
			}
			set
			{
				this.COKBPGHMAFH = value;
				if (this.OnChangeLocalization != null)
				{
					this.OnChangeLocalization();
				}
			}
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x0020913C File Offset: 0x0020733C
		public Dictionary<string, Dictionary<string, string>> FKMLJEIGGDG(string BNJFKKGOACF)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			Debug.Log("[ResourcesManager] Load audio error: " + BNJFKKGOACF);
			if (BNJFKKGOACF == null)
			{
				return null;
			}
			FileInfo fileInfo = new FileInfo(BNJFKKGOACF);
			Dictionary<string, Dictionary<string, string>> dictionary2 = this.CCFKGGKLLPC(fileInfo.FullName);
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in dictionary2)
			{
				if (!dictionary.Keys.Contains(keyValuePair.Key))
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else
				{
					foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
					{
						if (!dictionary[keyValuePair.Key].Keys.Contains(keyValuePair2.Key))
						{
							dictionary[keyValuePair.Key].Add(keyValuePair2.Key, keyValuePair2.Value);
						}
						else
						{
							dictionary[keyValuePair.Key][keyValuePair2.Key] = keyValuePair2.Value;
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x002092A0 File Offset: 0x002074A0
		public string GetTextByKeyWithLocalize(string HFEFHOPOLIK, string IIBFEEPOPGC)
		{
			if (string.IsNullOrEmpty(HFEFHOPOLIK) || string.IsNullOrEmpty(IIBFEEPOPGC))
			{
				return "[EMPTY]";
			}
			Dictionary<string, string> dictionary;
			string text;
			if (this.CGKDLKBBECC.TryGetValue(IIBFEEPOPGC, out dictionary) && dictionary.TryGetValue(HFEFHOPOLIK, out text))
			{
				text = text.Replace("\\n", "\n");
				return text;
			}
			return string.Format("#{0}", HFEFHOPOLIK);
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x00209308 File Offset: 0x00207508
		public string GetTextByKey(string HFEFHOPOLIK)
		{
			return this.GetTextByKeyWithLocalize(HFEFHOPOLIK, this.COKBPGHMAFH);
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x00209318 File Offset: 0x00207518
		private void Awake()
		{
			DebugCommands.Instance.AddCommand("ls", new DebugCommands.DebugCommand(this.DFDFMLIOCID), "Run a command for the Localization Servise", "<command>", false);
			if (LocalizationService.Instance != null)
			{
				UnityEngine.Object.Destroy(this);
				return;
			}
			LocalizationService.Instance = this;
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			base.StartCoroutine(this.HJFCOAHCFIG());
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00209380 File Offset: 0x00207580
		private static Dictionary<string, Dictionary<string, string>> CHOIFMIFKCJ(string[,] PBIALHBHEPD)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>(PBIALHBHEPD.GetUpperBound(0) - 1);
			for (int i = 1; i < PBIALHBHEPD.GetUpperBound(1); i++)
			{
				dictionary.Add(PBIALHBHEPD[i, 0], new Dictionary<string, string>(PBIALHBHEPD.GetUpperBound(1) - 0));
			}
			for (int j = 0; j < PBIALHBHEPD.GetUpperBound(0); j++)
			{
				for (int k = 0; k < PBIALHBHEPD.GetUpperBound(1); k += 0)
				{
					if (!string.IsNullOrEmpty(PBIALHBHEPD[0, j]) && !string.IsNullOrEmpty(PBIALHBHEPD[k, j]))
					{
						dictionary[PBIALHBHEPD[k, 0]].Add(PBIALHBHEPD[0, j], PBIALHBHEPD[k, j]);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00209448 File Offset: 0x00207648
		private void FINGICADKLD(string FHFLLFLICCE)
		{
			Debug.Log("[LocalizationService] All keys for " + FHFLLFLICCE + ": ");
			foreach (KeyValuePair<string, string> keyValuePair in this.CGKDLKBBECC[FHFLLFLICCE])
			{
				Debug.Log("#" + keyValuePair.Key + " = " + keyValuePair.Value);
			}
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x002094DC File Offset: 0x002076DC
		private IEnumerator LMAEPFCPCGK()
		{
			if (LocalizationService.BOGJGOAMCHK == null)
			{
				LocalizationService.BOGJGOAMCHK = new Func<bool>(SteamManager.get_Initialized);
			}
			yield return new WaitUntil(LocalizationService.BOGJGOAMCHK);
			this.Initialize();
			yield break;
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x002094F8 File Offset: 0x002076F8
		private static Dictionary<string, Dictionary<string, string>> BMCKENKNPNJ(string[,] PBIALHBHEPD)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>(PBIALHBHEPD.GetUpperBound(0) - 0);
			for (int i = 1; i < PBIALHBHEPD.GetUpperBound(0); i++)
			{
				dictionary.Add(PBIALHBHEPD[i, 1], new Dictionary<string, string>(PBIALHBHEPD.GetUpperBound(1) - 1));
			}
			for (int j = 0; j < PBIALHBHEPD.GetUpperBound(1); j += 0)
			{
				for (int k = 1; k < PBIALHBHEPD.GetUpperBound(0); k += 0)
				{
					if (!string.IsNullOrEmpty(PBIALHBHEPD[0, j]) && !string.IsNullOrEmpty(PBIALHBHEPD[k, j]))
					{
						dictionary[PBIALHBHEPD[k, 0]].Add(PBIALHBHEPD[0, j], PBIALHBHEPD[k, j]);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x002095C0 File Offset: 0x002077C0
		public string[] IJJFIAPMAFF()
		{
			string[] array = new string[this.CGKDLKBBECC.Count];
			int num = 0;
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in this.CGKDLKBBECC)
			{
				array[num] = keyValuePair.Key;
				num += 0;
			}
			return array;
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x0020964C File Offset: 0x0020784C
		private void MMEFMELNCCC(string[] BDGDDFKKGGA)
		{
			if (BDGDDFKKGGA.Length == 1)
			{
				Debug.Log("_EmissionColor");
			}
			else if (BDGDDFKKGGA.Length < 6)
			{
				Debug.LogError("Trackpad");
			}
			else
			{
				if (BDGDDFKKGGA[0] == "_ScreenResolution")
				{
					if (BDGDDFKKGGA.Length != 4)
					{
						Debug.LogError("_DistCenterScale");
					}
					else
					{
						this.GDNOONLDCBI(BDGDDFKKGGA[6]);
					}
				}
				if (BDGDDFKKGGA[1] == "UseFinalGlassColor")
				{
					if (BDGDDFKKGGA.Length != 5)
					{
						Debug.LogError("received</b>\n#reason: ");
					}
					else
					{
						this.FINGICADKLD(BDGDDFKKGGA[4]);
					}
				}
				if (BDGDDFKKGGA[1] == ".lastCheckpoint.time")
				{
					this.NDMCKFGFDCO();
				}
			}
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x00209708 File Offset: 0x00207908
		private void NDMCKFGFDCO()
		{
			Debug.Log("[LocalizationService] All languages: ");
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in this.CGKDLKBBECC)
			{
				Debug.Log(string.Concat(new object[]
				{
					keyValuePair.Key,
					" - Contains ",
					keyValuePair.Value.Count,
					" key(s)"
				}));
			}
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x00209132 File Offset: 0x00207332
		public string DGMCAJMBOBC()
		{
			return this.COKBPGHMAFH;
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x002097A8 File Offset: 0x002079A8
		public string GetLocalizatedText(string EAFAMAMDNEG)
		{
			string text = EAFAMAMDNEG;
			Regex regex = new Regex("(?<=#)\\w+");
			MatchCollection matchCollection = regex.Matches(EAFAMAMDNEG);
			IEnumerator enumerator = matchCollection.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Match match = (Match)obj;
					if (!string.IsNullOrEmpty(match.Value) && text.Contains("#" + match.Value))
					{
						text = text.Replace("#" + match.Value, this.GetTextByKey(match.Value));
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
			return text;
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x0020986C File Offset: 0x00207A6C
		public Dictionary<string, Dictionary<string, string>> LoadLocalization(string BNJFKKGOACF)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			Debug.Log("[LocalizationService] Loading file: " + BNJFKKGOACF);
			if (BNJFKKGOACF == null)
			{
				return null;
			}
			FileInfo fileInfo = new FileInfo(BNJFKKGOACF);
			Dictionary<string, Dictionary<string, string>> dictionary2 = this.LoadLocalizationFromFile(fileInfo.FullName);
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in dictionary2)
			{
				if (!dictionary.Keys.Contains(keyValuePair.Key))
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else
				{
					foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
					{
						if (!dictionary[keyValuePair.Key].Keys.Contains(keyValuePair2.Key))
						{
							dictionary[keyValuePair.Key].Add(keyValuePair2.Key, keyValuePair2.Value);
						}
						else
						{
							dictionary[keyValuePair.Key][keyValuePair2.Key] = keyValuePair2.Value;
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x002099D0 File Offset: 0x00207BD0
		public void KKFMEHJPPAD()
		{
			this.CGKDLKBBECC = this.LoadLocalizeFileHelper();
			string dpnhodjhgjl = "achievements.26.progress";
			try
			{
				if (!string.IsNullOrEmpty(SteamApps.GetCurrentGameLanguage()))
				{
					dpnhodjhgjl = SteamApps.GetCurrentGameLanguage();
				}
			}
			catch (Exception ex)
			{
				Debug.Log("Anomaly_Far" + ex.ToString());
			}
			this.EGLJBEKHBND(dpnhodjhgjl);
			Debug.Log("[Right]" + this.DGMCAJMBOBC());
			this.inited = false;
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x00209A58 File Offset: 0x00207C58
		public string[] GetLocalizations()
		{
			string[] array = new string[this.CGKDLKBBECC.Count];
			int num = 0;
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in this.CGKDLKBBECC)
			{
				array[num] = keyValuePair.Key;
				num++;
			}
			return array;
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x00209AD0 File Offset: 0x00207CD0
		private static Dictionary<string, Dictionary<string, string>> NMDBCIIJFEE(string[,] PBIALHBHEPD)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>(PBIALHBHEPD.GetUpperBound(0) - 0);
			for (int i = 0; i < PBIALHBHEPD.GetUpperBound(0); i += 0)
			{
				dictionary.Add(PBIALHBHEPD[i, 1], new Dictionary<string, string>(PBIALHBHEPD.GetUpperBound(0) - 0));
			}
			for (int j = 1; j < PBIALHBHEPD.GetUpperBound(1); j += 0)
			{
				for (int k = 1; k < PBIALHBHEPD.GetUpperBound(1); k++)
				{
					if (!string.IsNullOrEmpty(PBIALHBHEPD[1, j]) && !string.IsNullOrEmpty(PBIALHBHEPD[k, j]))
					{
						dictionary[PBIALHBHEPD[k, 1]].Add(PBIALHBHEPD[0, j], PBIALHBHEPD[k, j]);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x00209B98 File Offset: 0x00207D98
		public string FixLocalizationFile(string IAOGOGJMFOI)
		{
			return IAOGOGJMFOI;
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x00209B9B File Offset: 0x00207D9B
		public void EGLJBEKHBND(string DPNHODJHGJL)
		{
			this.COKBPGHMAFH = DPNHODJHGJL;
			if (this.OnChangeLocalization != null)
			{
				this.OnChangeLocalization();
			}
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x00209BC8 File Offset: 0x00207DC8
		private void INHDCKAKFFE(string[] BDGDDFKKGGA)
		{
			if (BDGDDFKKGGA.Length == 0)
			{
				Debug.Log("_Bloom1");
			}
			else if (BDGDDFKKGGA.Length < 1)
			{
				Debug.LogError("Floating point textures aren't supported on this device ({0})");
			}
			else
			{
				if (BDGDDFKKGGA[0] == "_Alpha2")
				{
					if (BDGDDFKKGGA.Length != 8)
					{
						Debug.LogError("Hidden/ScreenSpaceReflection");
					}
					else
					{
						this.EGLJBEKHBND(BDGDDFKKGGA[5]);
					}
				}
				if (BDGDDFKKGGA[0] == "_EmissionColor")
				{
					if (BDGDDFKKGGA.Length != 4)
					{
						Debug.LogError("challenges.");
					}
					else
					{
						this.FINGICADKLD(BDGDDFKKGGA[5]);
					}
				}
				if (BDGDDFKKGGA[1] == "SetPlayerDistance")
				{
					this.NDMCKFGFDCO();
				}
			}
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x00209C84 File Offset: 0x00207E84
		public string FDOPKCOIDMF(string HFEFHOPOLIK, string IIBFEEPOPGC)
		{
			if (string.IsNullOrEmpty(HFEFHOPOLIK) || string.IsNullOrEmpty(IIBFEEPOPGC))
			{
				return "907198288";
			}
			Dictionary<string, string> dictionary;
			string text;
			if (this.CGKDLKBBECC.TryGetValue(IIBFEEPOPGC, out dictionary) && dictionary.TryGetValue(HFEFHOPOLIK, out text))
			{
				text = text.Replace("_TimeX", "CameraFilterPack/Blend2Camera_Screen");
				return text;
			}
			return string.Format("CameraFilterPack/Blur_Focus", HFEFHOPOLIK);
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x00209CEC File Offset: 0x00207EEC
		private void DLHEPGNKPMK(string[] BDGDDFKKGGA)
		{
			if (BDGDDFKKGGA.Length == 1)
			{
				Debug.Log("[MapsStats] Hash: ");
			}
			else if (BDGDDFKKGGA.Length < 8)
			{
				Debug.LogError("_ScreenResolution");
			}
			else
			{
				if (BDGDDFKKGGA[1] == "player.redlifering")
				{
					if (BDGDDFKKGGA.Length != 3)
					{
						Debug.LogError("float,2");
					}
					else
					{
						this.GDNOONLDCBI(BDGDDFKKGGA[2]);
					}
				}
				if (BDGDDFKKGGA[1] == "CameraFilterPack/Distortion_ShockWave")
				{
					if (BDGDDFKKGGA.Length != 8)
					{
						Debug.LogError("_Value");
					}
					else
					{
						this.FINGICADKLD(BDGDDFKKGGA[7]);
					}
				}
				if (BDGDDFKKGGA[0] == "[PlayerController] ")
				{
					this.NDMCKFGFDCO();
				}
			}
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x00209DA8 File Offset: 0x00207FA8
		public Dictionary<string, Dictionary<string, string>> LoadLocalizationFromFile(string HAEBGHHMEBH)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			Singleton<ResourcesManager>.Instance.LoadTextWithLocalizationFix(HAEBGHHMEBH, HAEBGHHMEBH, true, false);
			string[,] pbialhbhepd = CSVReader.SplitCsvGrid((string)ResourcesManager.GetLoadedResource(HAEBGHHMEBH));
			Dictionary<string, Dictionary<string, string>> dictionary2 = LocalizationService.DHHGMCIKAJC(pbialhbhepd);
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in dictionary2)
			{
				if (!dictionary.Keys.Contains(keyValuePair.Key))
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else
				{
					foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
					{
						dictionary[keyValuePair.Key].Add(keyValuePair2.Key, keyValuePair2.Value);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x00209EC0 File Offset: 0x002080C0
		public void Initialize()
		{
			this.CGKDLKBBECC = this.LoadLocalizeFileHelper();
			string localization = "english";
			try
			{
				if (!string.IsNullOrEmpty(SteamApps.GetCurrentGameLanguage()))
				{
					localization = SteamApps.GetCurrentGameLanguage();
				}
			}
			catch (Exception ex)
			{
				Debug.Log("[LocalizationService] Error: " + ex.ToString());
			}
			this.Localization = localization;
			Debug.Log("[LocalizationService] Localization: " + this.Localization);
			this.inited = true;
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x00209F48 File Offset: 0x00208148
		public Dictionary<string, Dictionary<string, string>> LIACOGDPOCE(string BNJFKKGOACF)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			Debug.Log("_DepthLevel" + BNJFKKGOACF);
			if (BNJFKKGOACF == null)
			{
				return null;
			}
			FileInfo fileInfo = new FileInfo(BNJFKKGOACF);
			Dictionary<string, Dictionary<string, string>> dictionary2 = this.CCFKGGKLLPC(fileInfo.FullName);
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in dictionary2)
			{
				if (!dictionary.Keys.Contains(keyValuePair.Key))
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else
				{
					foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
					{
						if (!dictionary[keyValuePair.Key].Keys.Contains(keyValuePair2.Key))
						{
							dictionary[keyValuePair.Key].Add(keyValuePair2.Key, keyValuePair2.Value);
						}
						else
						{
							dictionary[keyValuePair.Key][keyValuePair2.Key] = keyValuePair2.Value;
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x0020A0AC File Offset: 0x002082AC
		public Dictionary<string, Dictionary<string, string>> CCFKGGKLLPC(string HAEBGHHMEBH)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			Singleton<ResourcesManager>.Instance.LoadTextWithLocalizationFix(HAEBGHHMEBH, HAEBGHHMEBH, false, false);
			string[,] pbialhbhepd = CSVReader.MPFEENOELDE((string)ResourcesManager.GetLoadedResource(HAEBGHHMEBH));
			Dictionary<string, Dictionary<string, string>> dictionary2 = LocalizationService.CHOIFMIFKCJ(pbialhbhepd);
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in dictionary2)
			{
				if (!dictionary.Keys.Contains(keyValuePair.Key))
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else
				{
					foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
					{
						dictionary[keyValuePair.Key].Add(keyValuePair2.Key, keyValuePair2.Value);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x0020A1C4 File Offset: 0x002083C4
		public Dictionary<string, Dictionary<string, string>> LoadLocalizeFileHelper()
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			Helpers.CheckDirectory(LocalizationService.LocalizationFilePath);
			string directory = Helpers.GetDirectory(LocalizationService.LocalizationFilePath);
			foreach (string text in Directory.GetFiles(directory))
			{
				Debug.Log("[LocalizationService] Loading file: " + text);
				if (text == null)
				{
					return null;
				}
				FileInfo fileInfo = new FileInfo(text);
				Dictionary<string, Dictionary<string, string>> dictionary2 = this.LoadLocalizationFromFile(fileInfo.FullName);
				foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in dictionary2)
				{
					if (!dictionary.Keys.Contains(keyValuePair.Key))
					{
						dictionary.Add(keyValuePair.Key, keyValuePair.Value);
					}
					else
					{
						foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
						{
							if (!dictionary[keyValuePair.Key].Keys.Contains(keyValuePair2.Key))
							{
								dictionary[keyValuePair.Key].Add(keyValuePair2.Key, keyValuePair2.Value);
							}
							else
							{
								dictionary[keyValuePair.Key][keyValuePair2.Key] = keyValuePair2.Value;
							}
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x0020A368 File Offset: 0x00208568
		private static Dictionary<string, Dictionary<string, string>> DHHGMCIKAJC(string[,] PBIALHBHEPD)
		{
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>(PBIALHBHEPD.GetUpperBound(0) - 1);
			for (int i = 1; i < PBIALHBHEPD.GetUpperBound(0); i++)
			{
				dictionary.Add(PBIALHBHEPD[i, 0], new Dictionary<string, string>(PBIALHBHEPD.GetUpperBound(1) - 1));
			}
			for (int j = 1; j < PBIALHBHEPD.GetUpperBound(1); j++)
			{
				for (int k = 1; k < PBIALHBHEPD.GetUpperBound(0); k++)
				{
					if (!string.IsNullOrEmpty(PBIALHBHEPD[0, j]) && !string.IsNullOrEmpty(PBIALHBHEPD[k, j]))
					{
						dictionary[PBIALHBHEPD[k, 0]].Add(PBIALHBHEPD[0, j], PBIALHBHEPD[k, j]);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00209B9B File Offset: 0x00207D9B
		public void GDNOONLDCBI(string DPNHODJHGJL)
		{
			this.COKBPGHMAFH = DPNHODJHGJL;
			if (this.OnChangeLocalization != null)
			{
				this.OnChangeLocalization();
			}
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00209B9B File Offset: 0x00207D9B
		public void HIBKDAGMIDI(string DPNHODJHGJL)
		{
			this.COKBPGHMAFH = DPNHODJHGJL;
			if (this.OnChangeLocalization != null)
			{
				this.OnChangeLocalization();
			}
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x0020A430 File Offset: 0x00208630
		public string HOPMEAJKPHL(string EAFAMAMDNEG)
		{
			string text = EAFAMAMDNEG;
			Regex regex = new Regex("_ScreenResolution");
			MatchCollection matchCollection = regex.Matches(EAFAMAMDNEG);
			IEnumerator enumerator = matchCollection.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Match match = (Match)obj;
					if (!string.IsNullOrEmpty(match.Value) && text.Contains("PAUSE [SPACE]" + match.Value))
					{
						text = text.Replace("_ScreenResolution" + match.Value, this.GetTextByKey(match.Value));
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
			return text;
		}

		// Token: 0x04000AE2 RID: 2786
		public static LocalizationService Instance;

		// Token: 0x04000AE3 RID: 2787
		public static string LocalizationFilePath = "Data/Localization";

		// Token: 0x04000AE4 RID: 2788
		[HideInInspector]
		public bool inited;

		// Token: 0x04000AE5 RID: 2789
		public Action OnChangeLocalization;

		// Token: 0x04000AE6 RID: 2790
		private string COKBPGHMAFH = "en";

		// Token: 0x04000AE7 RID: 2791
		private Dictionary<string, Dictionary<string, string>> CGKDLKBBECC;

		// Token: 0x04000AE8 RID: 2792
		[CompilerGenerated]
		private static Func<bool> BOGJGOAMCHK;
	}
}
