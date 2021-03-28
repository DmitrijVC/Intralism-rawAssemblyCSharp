using System;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Math;

namespace PrivateImplementationDetailsLOkWPANW
{
	// Token: 0x02000510 RID: 1296
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	public class Decrypt
	{
		// Token: 0x06012C3E RID: 76862 RVA: 0x00684070 File Offset: 0x00682270
		private static string OADKEIJMJGE(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C3F RID: 76863 RVA: 0x006840D4 File Offset: 0x006822D4
		public static string KOPBGHBFNHJ(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.DLMBIENGFDK(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 2);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.KJNCKGBLOFO(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 5);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C40 RID: 76864 RVA: 0x006841D0 File Offset: 0x006823D0
		private static string IIEANHPICLF(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C41 RID: 76865 RVA: 0x00684234 File Offset: 0x00682434
		private static string DLMBIENGFDK(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C42 RID: 76866 RVA: 0x00684298 File Offset: 0x00682498
		public static string LDDKKMFBLOJ(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.NBHLIFCLHHA(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 7);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.FPOFFFCBDHG(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 4);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C43 RID: 76867 RVA: 0x00684394 File Offset: 0x00682594
		private static string ANBPPNFPDIM(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C44 RID: 76868 RVA: 0x006843F8 File Offset: 0x006825F8
		private static string CFBALJDDMII(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C45 RID: 76869 RVA: 0x0068445C File Offset: 0x0068265C
		private static string MCHKLFDFLKC(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C46 RID: 76870 RVA: 0x006844C0 File Offset: 0x006826C0
		public static string HPMJGLODLJI(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FOPCPFNEMLP(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 7);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.LPIMMHEFBOA(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 3);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C47 RID: 76871 RVA: 0x006845BC File Offset: 0x006827BC
		public static string CAONLFHEMNE(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.JBIKHMBPKBK(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 0);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.CIONLJLIHMM(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 1);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C48 RID: 76872 RVA: 0x006846B8 File Offset: 0x006828B8
		public static string ECIBFKDMAEN(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FPPLFDPBHII(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 1);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.PIBBGKIJGHL(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 2);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C49 RID: 76873 RVA: 0x006847B4 File Offset: 0x006829B4
		public static string LMJELEJNGDI(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FPPLFDPBHII(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 3);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.CIONLJLIHMM(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 7);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C4A RID: 76874 RVA: 0x006848B0 File Offset: 0x00682AB0
		public static string IBOHJJMJCGF(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.HDHLPMHFACE(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 7);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.CFBALJDDMII(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 0);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C4B RID: 76875 RVA: 0x006849AC File Offset: 0x00682BAC
		private static string ONALJBKOKDA(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C4C RID: 76876 RVA: 0x00684A10 File Offset: 0x00682C10
		private static string JKHHEGBLPOM(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C4D RID: 76877 RVA: 0x00684A74 File Offset: 0x00682C74
		private static string OPFNELKKMIG(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C4E RID: 76878 RVA: 0x00684AD8 File Offset: 0x00682CD8
		private static string LNIFMNCECPG(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C4F RID: 76879 RVA: 0x00684B3C File Offset: 0x00682D3C
		private static string KJNCKGBLOFO(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C50 RID: 76880 RVA: 0x00684BA0 File Offset: 0x00682DA0
		public static string PJMOJBLDDHJ(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.KADCFCIPJHK(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 5);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.BLPCCHPOMCM(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 5);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C51 RID: 76881 RVA: 0x00684C9C File Offset: 0x00682E9C
		private static string JCFFBBHPHIK(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C52 RID: 76882 RVA: 0x00684D00 File Offset: 0x00682F00
		private static string FOPCPFNEMLP(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C53 RID: 76883 RVA: 0x00684D64 File Offset: 0x00682F64
		private static string LAIGOGNNJOM(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x00684DC8 File Offset: 0x00682FC8
		private static string FIKPICLBHKD(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C55 RID: 76885 RVA: 0x00684E2C File Offset: 0x0068302C
		private static string HDHLPMHFACE(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C56 RID: 76886 RVA: 0x00684E90 File Offset: 0x00683090
		public static string KJFMAGIONKN(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FPOFFFCBDHG(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 8);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.PIBBGKIJGHL(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 7);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C57 RID: 76887 RVA: 0x00684F8C File Offset: 0x0068318C
		private static string NNEEBJMHIMI(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C58 RID: 76888 RVA: 0x00684FF0 File Offset: 0x006831F0
		private static string JODANFLAINB(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C59 RID: 76889 RVA: 0x00685054 File Offset: 0x00683254
		public static string HIPBFIAJOGJ(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.MCHKLFDFLKC(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 3);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.AKGGKDIBEII(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 0);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C5A RID: 76890 RVA: 0x00685150 File Offset: 0x00683350
		private static string MMHOAOOLANK(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C5B RID: 76891 RVA: 0x006851B4 File Offset: 0x006833B4
		private static string JDJAHIOOJBE(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C5C RID: 76892 RVA: 0x00685218 File Offset: 0x00683418
		private static string PIBBGKIJGHL(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C5D RID: 76893 RVA: 0x0068527C File Offset: 0x0068347C
		private static string ANNMNHDNAKE(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C5E RID: 76894 RVA: 0x006852E0 File Offset: 0x006834E0
		public static string OOLMICODPGH(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.JCFFBBHPHIK(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 1);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.DLMBIENGFDK(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 7);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C5F RID: 76895 RVA: 0x006853DC File Offset: 0x006835DC
		public static string FGBEEIFAIHB(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FPPLFDPBHII(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 6);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.OPFNELKKMIG(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 5);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C60 RID: 76896 RVA: 0x006854D8 File Offset: 0x006836D8
		private static string NBHLIFCLHHA(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C61 RID: 76897 RVA: 0x0068553C File Offset: 0x0068373C
		// Note: this type is marked as 'beforefieldinit'.
		static Decrypt()
		{
			byte[] array = new byte[Decrypt.ODEFCPPBJFC];
			Buffer.BlockCopy(Decrypt.FMCIKFDDCKP, 20, array, 0, Decrypt.ODEFCPPBJFC);
			Array.Reverse(array);
			Decrypt.KJPLMPMANMH = new BigInteger(array);
		}

		// Token: 0x06012C62 RID: 76898 RVA: 0x006855D0 File Offset: 0x006837D0
		private static string CCOFFMHDAOE(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C63 RID: 76899 RVA: 0x00685634 File Offset: 0x00683834
		private static string BLPCCHPOMCM(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C64 RID: 76900 RVA: 0x00685698 File Offset: 0x00683898
		private static string AKGGKDIBEII(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C65 RID: 76901 RVA: 0x006856FC File Offset: 0x006838FC
		public static string ABICIFLFCFK(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.DOMLDKLAIPJ(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 4);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.PIBBGKIJGHL(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 6);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C66 RID: 76902 RVA: 0x006857F8 File Offset: 0x006839F8
		private static string FPOFFFCBDHG(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C67 RID: 76903 RVA: 0x0068585C File Offset: 0x00683A5C
		private static string FHAFEDFOMNC(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C68 RID: 76904 RVA: 0x006858C0 File Offset: 0x00683AC0
		private static string FPPLFDPBHII(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C69 RID: 76905 RVA: 0x00685924 File Offset: 0x00683B24
		private static string LPIMMHEFBOA(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C6A RID: 76906 RVA: 0x00685988 File Offset: 0x00683B88
		public static string EINAAFEDJHF(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.LPIMMHEFBOA(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 1);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.JCFFBBHPHIK(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 3);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C6B RID: 76907 RVA: 0x00685A84 File Offset: 0x00683C84
		private static string HIKDBINGFOC(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C6C RID: 76908 RVA: 0x00685AE8 File Offset: 0x00683CE8
		public static string CODAIOGHBGL(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.JODANFLAINB(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 8);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.HDHLPMHFACE(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 7);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C6D RID: 76909 RVA: 0x00685BE4 File Offset: 0x00683DE4
		public static string PLIEFGHPAHN(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FOPCPFNEMLP(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 0);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.JDJAHIOOJBE(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 4);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C6E RID: 76910 RVA: 0x00685CE0 File Offset: 0x00683EE0
		public static string ABHJGIGIAJL(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.CFBALJDDMII(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 8);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.FPPLFDPBHII(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 6);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C70 RID: 76912 RVA: 0x00685DDC File Offset: 0x00683FDC
		public static string HJHPAECPEJB(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.ANBPPNFPDIM(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 5);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.HIKDBINGFOC(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 1);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C71 RID: 76913 RVA: 0x00685ED8 File Offset: 0x006840D8
		private static string PNAECLHGLIO(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C72 RID: 76914 RVA: 0x00685F3C File Offset: 0x0068413C
		public static string LAFDLDODEFC(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.PEPEBKIBMBJ(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 8);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.KJNCKGBLOFO(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 1);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C73 RID: 76915 RVA: 0x00686038 File Offset: 0x00684238
		public static string AOKEGMKJEOP(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FPPLFDPBHII(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 1);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.JODANFLAINB(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 4);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C74 RID: 76916 RVA: 0x00686134 File Offset: 0x00684334
		public static string JAEFBBDNGHL(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FPOFFFCBDHG(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 2);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.FOPCPFNEMLP(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 8);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C75 RID: 76917 RVA: 0x00686230 File Offset: 0x00684430
		public static string DNMGJFCJEON(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.CFBALJDDMII(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 1);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.CIONLJLIHMM(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 6);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C76 RID: 76918 RVA: 0x0068632C File Offset: 0x0068452C
		private static string EHOENOFJALD(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C77 RID: 76919 RVA: 0x00686390 File Offset: 0x00684590
		private static string POEIMLFOACL(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C78 RID: 76920 RVA: 0x006863F4 File Offset: 0x006845F4
		private static string JBIKHMBPKBK(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C79 RID: 76921 RVA: 0x00686458 File Offset: 0x00684658
		private static string CIONLJLIHMM(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C7A RID: 76922 RVA: 0x006864BC File Offset: 0x006846BC
		public static string DecryptLiteral(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.DLMBIENGFDK(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 2);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.DLMBIENGFDK(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 2);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C7B RID: 76923 RVA: 0x006865B8 File Offset: 0x006847B8
		public static string OMGJMJMFMJP(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.PIBBGKIJGHL(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 4);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.PNAECLHGLIO(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 7);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C7C RID: 76924 RVA: 0x006866B4 File Offset: 0x006848B4
		private static string KADCFCIPJHK(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C7D RID: 76925 RVA: 0x00686718 File Offset: 0x00684918
		private static string IFKFOINPIDN(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C7E RID: 76926 RVA: 0x0068677C File Offset: 0x0068497C
		public static string NCBFHFFOKLD(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.NBHLIFCLHHA(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(0, text.Length - 8);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.ANBPPNFPDIM(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 5);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C7F RID: 76927 RVA: 0x00686878 File Offset: 0x00684A78
		public static string NJFIDGJFFHL(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.KJNCKGBLOFO(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 5);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.MCHKLFDFLKC(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 2);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C80 RID: 76928 RVA: 0x00686974 File Offset: 0x00684B74
		public static string CCIBHLLEODG(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.HIKDBINGFOC(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 3);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.CIONLJLIHMM(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 7);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C81 RID: 76929 RVA: 0x00686A70 File Offset: 0x00684C70
		public static string MOLFKICGCNO(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.OPFNELKKMIG(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 1);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.DOMLDKLAIPJ(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 5);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C82 RID: 76930 RVA: 0x00686B6C File Offset: 0x00684D6C
		private static string PEPEBKIBMBJ(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C83 RID: 76931 RVA: 0x00686BD0 File Offset: 0x00684DD0
		public static string MCHLNPEICAF(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.FIKPICLBHKD(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 0);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.LNIFMNCECPG(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 6);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C84 RID: 76932 RVA: 0x00686CCC File Offset: 0x00684ECC
		private static string DOMLDKLAIPJ(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C85 RID: 76933 RVA: 0x00686D30 File Offset: 0x00684F30
		private static string MEMFBBLIIOF(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i += 0)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 1, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C86 RID: 76934 RVA: 0x00686D94 File Offset: 0x00684F94
		private static string NHKGGMOLIIM(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 0; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x06012C87 RID: 76935 RVA: 0x00686DF8 File Offset: 0x00684FF8
		public static string PGOJMIEPKCB(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.JBIKHMBPKBK(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 3);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 1; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.ONALJBKOKDA(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 3);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C88 RID: 76936 RVA: 0x00686EF4 File Offset: 0x006850F4
		public static string CPDFKOIEONL(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.LAIGOGNNJOM(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 5);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i += 0)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 0, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.FPOFFFCBDHG(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(1, text2.Length - 5);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C89 RID: 76937 RVA: 0x00686FF0 File Offset: 0x006851F0
		public static string LJAFEAADANE(byte[] JMOJMGEEGKD, bool NEJOLIDLENB)
		{
			if (JMOJMGEEGKD.Length == Decrypt.ODEFCPPBJFC)
			{
				BigInteger bigInteger = new BigInteger(JMOJMGEEGKD);
				byte[] bytes = bigInteger.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
				string text = Decrypt.ONALJBKOKDA(bytes);
				if (NEJOLIDLENB)
				{
					return text.Substring(1, text.Length - 1);
				}
				return text;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < JMOJMGEEGKD.Length / Decrypt.ODEFCPPBJFC; i++)
				{
					byte[] array = new byte[Decrypt.ODEFCPPBJFC];
					Buffer.BlockCopy(JMOJMGEEGKD, i * Decrypt.ODEFCPPBJFC, array, 1, Decrypt.ODEFCPPBJFC);
					BigInteger bigInteger2 = new BigInteger(array);
					byte[] bytes2 = bigInteger2.ModPow(Decrypt.EJGFFKADKGB, Decrypt.KJPLMPMANMH).GetBytes();
					stringBuilder.Append(Decrypt.BLPCCHPOMCM(bytes2));
				}
				if (NEJOLIDLENB)
				{
					string text2 = stringBuilder.ToString();
					return text2.Substring(0, text2.Length - 1);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06012C8A RID: 76938 RVA: 0x006870EC File Offset: 0x006852EC
		private static string GNCOKIAFMCD(byte[] EEINGFCFEGF)
		{
			int i;
			for (i = 1; i < EEINGFCFEGF.Length; i++)
			{
				if (EEINGFCFEGF[i] != 0)
				{
					break;
				}
			}
			if (i != EEINGFCFEGF.Length)
			{
				byte[] array = new byte[EEINGFCFEGF.Length - i];
				Buffer.BlockCopy(EEINGFCFEGF, i, array, 0, EEINGFCFEGF.Length - i);
				return Encoding.UTF8.GetString(array);
			}
			return string.Empty;
		}

		// Token: 0x0400213E RID: 8510
		private static byte[] FMCIKFDDCKP = new byte[]
		{
			6,
			2,
			0,
			0,
			0,
			164,
			0,
			0,
			82,
			83,
			65,
			49,
			0,
			4,
			0,
			0,
			17,
			0,
			0,
			0,
			29,
			139,
			237,
			246,
			53,
			196,
			210,
			72,
			210,
			238,
			177,
			37,
			99,
			40,
			154,
			113,
			154,
			151,
			133,
			50,
			188,
			102,
			121,
			20,
			189,
			120,
			193,
			80,
			163,
			158,
			161,
			236,
			98,
			37,
			169,
			246,
			76,
			167,
			246,
			76,
			213,
			151,
			203,
			byte.MaxValue,
			156,
			12,
			134,
			133,
			51,
			109,
			27,
			161,
			152,
			248,
			124,
			87,
			76,
			113,
			211,
			3,
			39,
			100,
			242,
			207,
			55,
			87,
			70,
			160,
			218,
			221,
			172,
			84,
			213,
			75,
			60,
			182,
			28,
			87,
			132,
			26,
			158,
			116,
			47,
			30,
			216,
			81,
			250,
			133,
			66,
			36,
			2,
			202,
			179,
			129,
			171,
			69,
			170,
			57,
			145,
			97,
			249,
			134,
			219,
			207,
			11,
			245,
			203,
			64,
			74,
			141,
			202,
			218,
			209,
			167,
			52,
			82,
			117,
			65,
			93,
			80,
			157,
			24,
			163,
			122,
			105,
			63,
			182,
			231
		};

		// Token: 0x0400213F RID: 8511
		private static int ODEFCPPBJFC = 128;

		// Token: 0x04002140 RID: 8512
		private static int EJGFFKADKGB = (int)Decrypt.FMCIKFDDCKP[16] | (int)Decrypt.FMCIKFDDCKP[17] << 8 | (int)Decrypt.FMCIKFDDCKP[18] << 16;

		// Token: 0x04002141 RID: 8513
		private static BigInteger KJPLMPMANMH;
	}
}
