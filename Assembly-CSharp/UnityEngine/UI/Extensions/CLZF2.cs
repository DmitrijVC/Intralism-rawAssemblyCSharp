using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A7 RID: 679
	public static class CLZF2
	{
		// Token: 0x0600A405 RID: 41989 RVA: 0x003D9294 File Offset: 0x003D7494
		public static byte[] Compress(byte[] FJEODNBMILF)
		{
			int num = FJEODNBMILF.Length * 2;
			byte[] src = new byte[num];
			int num2;
			for (num2 = CLZF2.lzf_compress(FJEODNBMILF, ref src); num2 == 0; num2 = CLZF2.lzf_compress(FJEODNBMILF, ref src))
			{
				num *= 2;
				src = new byte[num];
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(src, 0, array, 0, num2);
			return array;
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x003D92E8 File Offset: 0x003D74E8
		public static byte[] Decompress(byte[] FJEODNBMILF)
		{
			int num = FJEODNBMILF.Length * 2;
			byte[] src = new byte[num];
			int num2;
			for (num2 = CLZF2.lzf_decompress(FJEODNBMILF, ref src); num2 == 0; num2 = CLZF2.lzf_decompress(FJEODNBMILF, ref src))
			{
				num *= 2;
				src = new byte[num];
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(src, 0, array, 0, num2);
			return array;
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x003D933C File Offset: 0x003D753C
		public static int lzf_compress(byte[] FMFLEPJIKAI, ref byte[] IPBGIDLHEAG)
		{
			int num = FMFLEPJIKAI.Length;
			int num2 = IPBGIDLHEAG.Length;
			Array.Clear(CLZF2.JBNLFKKOFOH, 0, (int)CLZF2.NJJODDJEENG);
			uint num3 = 0U;
			uint num4 = 0U;
			uint num5 = (uint)((int)FMFLEPJIKAI[(int)((UIntPtr)num3)] << 8 | (int)FMFLEPJIKAI[(int)((UIntPtr)(num3 + 1U))]);
			int num6 = 0;
			for (;;)
			{
				if ((ulong)num3 < (ulong)((long)(num - 2)))
				{
					num5 = (num5 << 8 | (uint)FMFLEPJIKAI[(int)((UIntPtr)(num3 + 2U))]);
					long num7 = (long)((ulong)((num5 ^ num5 << 5) >> (int)(24U - CLZF2.LNAEIBLKGHN - num5 * 5U) & CLZF2.NJJODDJEENG - 1U));
					long num8 = CLZF2.JBNLFKKOFOH[(int)(checked((IntPtr)num7))];
					CLZF2.JBNLFKKOFOH[(int)(checked((IntPtr)num7))] = (long)((ulong)num3);
					long num9;
					if ((num9 = (long)((ulong)num3 - (ulong)num8 - 1UL)) < (long)((ulong)CLZF2.IPBBGLNHAAH) && (ulong)(num3 + 4U) < (ulong)((long)num) && num8 > 0L && FMFLEPJIKAI[(int)(checked((IntPtr)num8))] == FMFLEPJIKAI[(int)((UIntPtr)num3)] && FMFLEPJIKAI[(int)(checked((IntPtr)(unchecked(num8 + 1L))))] == FMFLEPJIKAI[(int)((UIntPtr)(num3 + 1U))] && FMFLEPJIKAI[(int)(checked((IntPtr)(unchecked(num8 + 2L))))] == FMFLEPJIKAI[(int)((UIntPtr)(num3 + 2U))])
					{
						uint num10 = 2U;
						uint num11 = (uint)(num - (int)num3 - (int)num10);
						num11 = ((num11 <= CLZF2.DCFBJNECBMF) ? num11 : CLZF2.DCFBJNECBMF);
						if ((ulong)num4 + (ulong)((long)num6) + 1UL + 3UL >= (ulong)((long)num2))
						{
							break;
						}
						do
						{
							num10 += 1U;
						}
						while (num10 < num11 && FMFLEPJIKAI[(int)(checked((IntPtr)(unchecked(num8 + (long)((ulong)num10)))))] == FMFLEPJIKAI[(int)((UIntPtr)(num3 + num10))]);
						if (num6 != 0)
						{
							IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = (byte)(num6 - 1);
							num6 = -num6;
							do
							{
								IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = FMFLEPJIKAI[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num6)))))];
							}
							while (++num6 != 0);
						}
						num10 -= 2U;
						num3 += 1U;
						if (num10 < 7U)
						{
							IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = (byte)((num9 >> 8) + (long)((ulong)((ulong)num10 << 5)));
						}
						else
						{
							IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = (byte)((num9 >> 8) + 224L);
							IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = (byte)(num10 - 7U);
						}
						IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = (byte)num9;
						num3 += num10 - 1U;
						num5 = (uint)((int)FMFLEPJIKAI[(int)((UIntPtr)num3)] << 8 | (int)FMFLEPJIKAI[(int)((UIntPtr)(num3 + 1U))]);
						num5 = (num5 << 8 | (uint)FMFLEPJIKAI[(int)((UIntPtr)(num3 + 2U))]);
						CLZF2.JBNLFKKOFOH[(int)((UIntPtr)((num5 ^ num5 << 5) >> (int)(24U - CLZF2.LNAEIBLKGHN - num5 * 5U) & CLZF2.NJJODDJEENG - 1U))] = (long)((ulong)num3);
						num3 += 1U;
						num5 = (num5 << 8 | (uint)FMFLEPJIKAI[(int)((UIntPtr)(num3 + 2U))]);
						CLZF2.JBNLFKKOFOH[(int)((UIntPtr)((num5 ^ num5 << 5) >> (int)(24U - CLZF2.LNAEIBLKGHN - num5 * 5U) & CLZF2.NJJODDJEENG - 1U))] = (long)((ulong)num3);
						num3 += 1U;
						continue;
					}
				}
				else if ((ulong)num3 == (ulong)((long)num))
				{
					goto Block_13;
				}
				num6++;
				num3 += 1U;
				if ((long)num6 == (long)((ulong)CLZF2.GDDPMAGJHMC))
				{
					if ((ulong)(num4 + 1U + CLZF2.GDDPMAGJHMC) >= (ulong)((long)num2))
					{
						return 0;
					}
					IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = (byte)(CLZF2.GDDPMAGJHMC - 1U);
					num6 = -num6;
					do
					{
						IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = FMFLEPJIKAI[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num6)))))];
					}
					while (++num6 != 0);
				}
			}
			return 0;
			Block_13:
			if (num6 != 0)
			{
				if ((ulong)num4 + (ulong)((long)num6) + 1UL >= (ulong)((long)num2))
				{
					return 0;
				}
				IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = (byte)(num6 - 1);
				num6 = -num6;
				do
				{
					IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = FMFLEPJIKAI[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num6)))))];
				}
				while (++num6 != 0);
			}
			return (int)num4;
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x003D9684 File Offset: 0x003D7884
		public static int lzf_decompress(byte[] FMFLEPJIKAI, ref byte[] IPBGIDLHEAG)
		{
			int num = FMFLEPJIKAI.Length;
			int num2 = IPBGIDLHEAG.Length;
			uint num3 = 0U;
			uint num4 = 0U;
			for (;;)
			{
				uint num5 = (uint)FMFLEPJIKAI[(int)((UIntPtr)(num3++))];
				if (num5 < 32U)
				{
					num5 += 1U;
					if ((ulong)(num4 + num5) > (ulong)((long)num2))
					{
						break;
					}
					do
					{
						IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = FMFLEPJIKAI[(int)((UIntPtr)(num3++))];
					}
					while ((num5 -= 1U) != 0U);
				}
				else
				{
					uint num6 = num5 >> 5;
					int num7 = (int)(num4 - ((num5 & 31U) << 8) - 1U);
					if (num6 == 7U)
					{
						num6 += (uint)FMFLEPJIKAI[(int)((UIntPtr)(num3++))];
					}
					num7 -= (int)FMFLEPJIKAI[(int)((UIntPtr)(num3++))];
					if ((ulong)(num4 + num6 + 2U) > (ulong)((long)num2))
					{
						return 0;
					}
					if (num7 < 0)
					{
						return 0;
					}
					IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = IPBGIDLHEAG[num7++];
					IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = IPBGIDLHEAG[num7++];
					do
					{
						IPBGIDLHEAG[(int)((UIntPtr)(num4++))] = IPBGIDLHEAG[num7++];
					}
					while ((num6 -= 1U) != 0U);
				}
				if ((ulong)num3 >= (ulong)((long)num))
				{
					return (int)num4;
				}
			}
			return 0;
		}

		// Token: 0x04001289 RID: 4745
		private static readonly uint LNAEIBLKGHN = 14U;

		// Token: 0x0400128A RID: 4746
		private static readonly uint NJJODDJEENG = 16384U;

		// Token: 0x0400128B RID: 4747
		private static readonly uint GDDPMAGJHMC = 32U;

		// Token: 0x0400128C RID: 4748
		private static readonly uint IPBBGLNHAAH = 8192U;

		// Token: 0x0400128D RID: 4749
		private static readonly uint DCFBJNECBMF = 264U;

		// Token: 0x0400128E RID: 4750
		private static readonly long[] JBNLFKKOFOH = new long[CLZF2.NJJODDJEENG];
	}
}
