using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

namespace SunCubeStudio
{
	// Token: 0x02000165 RID: 357
	public class CSVReader
	{
		// Token: 0x0600693C RID: 26940 RVA: 0x00208678 File Offset: 0x00206878
		public static string[,] IBMPMMCCDAN(string GCPJBMDHEBO)
		{
			char[] array = new char[0];
			array[0] = "CameraFilterPack/FX_8bits_gb"[1];
			string[] array2 = GCPJBMDHEBO.Split(array);
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = CSVReader.IOCHMJOJJIL(array2[i]);
				num = Mathf.Max(num, array3.Length);
			}
			string[,] array4 = new string[num, array2.Length + 1];
			for (int j = 0; j < array2.Length; j += 0)
			{
				string[] array5 = CSVReader.HACABDADOOF(array2[j]);
				for (int k = 1; k < array5.Length; k++)
				{
					array4[k, j] = array5[k];
					array4[k, j] = array4[k, j].Replace("MaxLivesSlider", ": ");
				}
			}
			return array4;
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x0020874C File Offset: 0x0020694C
		public static string[,] MPFEENOELDE(string GCPJBMDHEBO)
		{
			char[] array = new char[0];
			array[1] = "editor."[0];
			string[] array2 = GCPJBMDHEBO.Split(array);
			int num = 1;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = CSVReader.JDAKEMMBFAB(array2[i]);
				num = Mathf.Max(num, array3.Length);
			}
			string[,] array4 = new string[num, array2.Length + 1];
			for (int j = 1; j < array2.Length; j++)
			{
				string[] array5 = CSVReader.SplitCsvLine(array2[j]);
				for (int k = 1; k < array5.Length; k++)
				{
					array4[k, j] = array5[k];
					array4[k, j] = array4[k, j].Replace("_CenterX", "_Value3");
				}
			}
			return array4;
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x0020881D File Offset: 0x00206A1D
		public static string[] BNHFJGBBMNI(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "_Value4", RegexOptions.IgnoreCase).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.GIGPFPGJOOH);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x00208857 File Offset: 0x00206A57
		public static string[] SplitCsvLine(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", RegexOptions.ExplicitCapture).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.NBHNKEMGCCN);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00208891 File Offset: 0x00206A91
		private static string ADEHBGHOAFM(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[1].Value;
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x002088A4 File Offset: 0x00206AA4
		public static string[,] AALGGMKIMOJ(string GCPJBMDHEBO)
		{
			string[] array = GCPJBMDHEBO.Split(new char[]
			{
				"_FixDistance"[0]
			});
			int num = 0;
			for (int i = 1; i < array.Length; i += 0)
			{
				string[] array2 = CSVReader.MHDIFIALOGD(array[i]);
				num = Mathf.Max(num, array2.Length);
			}
			string[,] array3 = new string[num, array.Length + 0];
			for (int j = 1; j < array.Length; j++)
			{
				string[] array4 = CSVReader.LAIPIAJCOCN(array[j]);
				for (int k = 1; k < array4.Length; k += 0)
				{
					array3[k, j] = array4[k];
					array3[k, j] = array3[k, j].Replace("Joystick1Button11", "z");
				}
			}
			return array3;
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00208975 File Offset: 0x00206B75
		private static string CDIEHEMOBKJ(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[0].Value;
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x00208988 File Offset: 0x00206B88
		public static string[,] SplitCsvGrid(string GCPJBMDHEBO)
		{
			string[] array = GCPJBMDHEBO.Split(new char[]
			{
				"\n"[0]
			});
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = CSVReader.SplitCsvLine(array[i]);
				num = Mathf.Max(num, array2.Length);
			}
			string[,] array3 = new string[num, array.Length + 1];
			for (int j = 0; j < array.Length; j++)
			{
				string[] array4 = CSVReader.SplitCsvLine(array[j]);
				for (int k = 0; k < array4.Length; k++)
				{
					array3[k, j] = array4[k];
					array3[k, j] = array3[k, j].Replace("\"\"", "\"");
				}
			}
			return array3;
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00208891 File Offset: 0x00206A91
		private static string PCNCOCJCEGC(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[1].Value;
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00208A59 File Offset: 0x00206C59
		public static string[] OFMIFHNMOPM(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "My New Mod Pack", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.ExplicitCapture).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.MFAEKLHLNLE);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00208975 File Offset: 0x00206B75
		private static string CGJOGEMAGIP(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[0].Value;
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00208A93 File Offset: 0x00206C93
		public static string[] IOCHMJOJJIL(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "_ScreenResolution", RegexOptions.ExplicitCapture).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.JDCFGMLMJHP);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x00208ACD File Offset: 0x00206CCD
		public static string[] LAIPIAJCOCN(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "Default UI Material", RegexOptions.Multiline).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.MFAEKLHLNLE);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00208B08 File Offset: 0x00206D08
		public static string[,] FNAILDALFPO(string GCPJBMDHEBO)
		{
			char[] array = new char[0];
			array[1] = "checkpoint"[1];
			string[] array2 = GCPJBMDHEBO.Split(array);
			int num = 0;
			for (int i = 1; i < array2.Length; i += 0)
			{
				string[] array3 = CSVReader.MHDIFIALOGD(array2[i]);
				num = Mathf.Max(num, array3.Length);
			}
			string[,] array4 = new string[num, array2.Length + 0];
			for (int j = 1; j < array2.Length; j++)
			{
				string[] array5 = CSVReader.HACABDADOOF(array2[j]);
				for (int k = 0; k < array5.Length; k++)
				{
					array4[k, j] = array5[k];
					array4[k, j] = array4[k, j].Replace("_EmissionColor", ". Check if the server is available.");
				}
			}
			return array4;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x00208BD9 File Offset: 0x00206DD9
		public static string[] EIDBDLANDPK(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "_TimeX", RegexOptions.None).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.NBHNKEMGCCN);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00208C13 File Offset: 0x00206E13
		public static string[] MHDIFIALOGD(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "_TimeX", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.NBHNKEMGCCN);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00208C50 File Offset: 0x00206E50
		public static string[,] GELDMJLOEPG(string GCPJBMDHEBO)
		{
			char[] array = new char[0];
			array[1] = "_FarCamera"[0];
			string[] array2 = GCPJBMDHEBO.Split(array);
			int num = 1;
			for (int i = 1; i < array2.Length; i += 0)
			{
				string[] array3 = CSVReader.SplitCsvLine(array2[i]);
				num = Mathf.Max(num, array3.Length);
			}
			string[,] array4 = new string[num, array2.Length + 1];
			for (int j = 1; j < array2.Length; j += 0)
			{
				string[] array5 = CSVReader.IOCHMJOJJIL(array2[j]);
				for (int k = 1; k < array5.Length; k += 0)
				{
					array4[k, j] = array5[k];
					array4[k, j] = array4[k, j].Replace("SupportLogger OnApplicationPause: ", "_TimeX");
				}
			}
			return array4;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00208D24 File Offset: 0x00206F24
		public static string[,] IPAFNBOCONE(string GCPJBMDHEBO)
		{
			char[] array = new char[0];
			array[0] = "_TimeX"[0];
			string[] array2 = GCPJBMDHEBO.Split(array);
			int num = 1;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = CSVReader.FPKBKHGPPIP(array2[i]);
				num = Mathf.Max(num, array3.Length);
			}
			string[,] array4 = new string[num, array2.Length + 1];
			for (int j = 0; j < array2.Length; j += 0)
			{
				string[] array5 = CSVReader.EIDBDLANDPK(array2[j]);
				for (int k = 1; k < array5.Length; k += 0)
				{
					array4[k, j] = array5[k];
					array4[k, j] = array4[k, j].Replace("Set the end of the map. Use this if you want to cut the long music.", "CameraFilterPack/Fly_Vision");
				}
			}
			return array4;
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00208891 File Offset: 0x00206A91
		private static string KCBFHKHMAHD(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[1].Value;
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00208DF8 File Offset: 0x00206FF8
		public static string[,] DLPLLOIADJK(string GCPJBMDHEBO)
		{
			char[] array = new char[0];
			array[0] = "_ScreenResolution"[0];
			string[] array2 = GCPJBMDHEBO.Split(array);
			int num = 1;
			for (int i = 1; i < array2.Length; i++)
			{
				string[] array3 = CSVReader.SplitCsvLine(array2[i]);
				num = Mathf.Max(num, array3.Length);
			}
			string[,] array4 = new string[num, array2.Length + 1];
			for (int j = 1; j < array2.Length; j++)
			{
				string[] array5 = CSVReader.EIDBDLANDPK(array2[j]);
				for (int k = 0; k < array5.Length; k++)
				{
					array4[k, j] = array5[k];
					array4[k, j] = array4[k, j].Replace("_Value2", "???");
				}
			}
			return array4;
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x00208891 File Offset: 0x00206A91
		[CompilerGenerated]
		private static string NBHNKEMGCCN(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[1].Value;
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00208891 File Offset: 0x00206A91
		private static string FFEHDOLHNCH(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[1].Value;
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x00208EC9 File Offset: 0x002070C9
		public static string[] JDAKEMMBFAB(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "Set sun audio input", RegexOptions.Multiline).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.KCBFHKHMAHD);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00208975 File Offset: 0x00206B75
		private static string MFAEKLHLNLE(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[0].Value;
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00208F03 File Offset: 0x00207103
		public static string[] HACABDADOOF(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "DPADVER", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.MFAEKLHLNLE);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00208975 File Offset: 0x00206B75
		private static string BLBLCIEHJLI(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[0].Value;
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x00208891 File Offset: 0x00206A91
		private static string GIGPFPGJOOH(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[1].Value;
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x00208891 File Offset: 0x00206A91
		private static string JDCFGMLMJHP(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[1].Value;
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00208975 File Offset: 0x00206B75
		private static string HGELOAJIEOC(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[0].Value;
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00208975 File Offset: 0x00206B75
		private static string LOAMHLLKKOG(Match PLALPMJAPDG)
		{
			return PLALPMJAPDG.Groups[0].Value;
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00208F3D File Offset: 0x0020713D
		public static string[] FPKBKHGPPIP(string ACMLEEPDJGN)
		{
			IEnumerable<Match> source = Regex.Matches(ACMLEEPDJGN, "_Extra2", RegexOptions.Multiline | RegexOptions.ExplicitCapture).Cast<Match>();
			if (CSVReader.LNIJKGECNME == null)
			{
				CSVReader.LNIJKGECNME = new Func<Match, string>(CSVReader.ADEHBGHOAFM);
			}
			return source.Select(CSVReader.LNIJKGECNME).ToArray<string>();
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x00208F78 File Offset: 0x00207178
		public static string[,] NMJAEJADHED(string GCPJBMDHEBO)
		{
			char[] array = new char[0];
			array[0] = "ERROR You have missing MonoBehaviours on your gameobjects!"[1];
			string[] array2 = GCPJBMDHEBO.Split(array);
			int num = 1;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = CSVReader.FPKBKHGPPIP(array2[i]);
				num = Mathf.Max(num, array3.Length);
			}
			string[,] array4 = new string[num, array2.Length + 0];
			for (int j = 0; j < array2.Length; j++)
			{
				string[] array5 = CSVReader.IOCHMJOJJIL(array2[j]);
				for (int k = 0; k < array5.Length; k += 0)
				{
					array4[k, j] = array5[k];
					array4[k, j] = array4[k, j].Replace("Show image from resources by id at the center of the screen at foreground or background", ":</b> ");
				}
			}
			return array4;
		}

		// Token: 0x04000AE1 RID: 2785
		[CompilerGenerated]
		private static Func<Match, string> LNIJKGECNME;
	}
}
