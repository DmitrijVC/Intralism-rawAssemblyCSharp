using System;
using System.Text;

// Token: 0x0200046F RID: 1135
internal static class EGOPKJHICLK
{
	// Token: 0x0601043D RID: 66621 RVA: 0x0058FBD6 File Offset: 0x0058DDD6
	public static string CompressString(string EAFAMAMDNEG)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(EAFAMAMDNEG));
	}

	// Token: 0x0601043E RID: 66622 RVA: 0x0058FBE8 File Offset: 0x0058DDE8
	public static string DecompressString(string MBPPMOLCLFO)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(MBPPMOLCLFO));
	}
}
