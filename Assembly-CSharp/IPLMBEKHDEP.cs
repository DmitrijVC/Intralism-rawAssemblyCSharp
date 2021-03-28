using System;
using UnityEngine;

// Token: 0x020002CE RID: 718
internal static class IPLMBEKHDEP
{
	// Token: 0x0600AA9F RID: 43679 RVA: 0x003F5A7C File Offset: 0x003F3C7C
	public static bool SetColor(ref Color NGKKLGPFEBB, Color IHIAMPBEFEE)
	{
		if (NGKKLGPFEBB.r == IHIAMPBEFEE.r && NGKKLGPFEBB.g == IHIAMPBEFEE.g && NGKKLGPFEBB.b == IHIAMPBEFEE.b && NGKKLGPFEBB.a == IHIAMPBEFEE.a)
		{
			return false;
		}
		NGKKLGPFEBB = IHIAMPBEFEE;
		return true;
	}

	// Token: 0x0600AAA0 RID: 43680 RVA: 0x003F5ADB File Offset: 0x003F3CDB
	public static bool SetStruct<T>(ref T NGKKLGPFEBB, T IHIAMPBEFEE) where T : struct
	{
		if (NGKKLGPFEBB.Equals(IHIAMPBEFEE))
		{
			return false;
		}
		NGKKLGPFEBB = IHIAMPBEFEE;
		return true;
	}

	// Token: 0x0600AAA1 RID: 43681 RVA: 0x003F5B00 File Offset: 0x003F3D00
	public static bool SetClass<T>(ref T NGKKLGPFEBB, T IHIAMPBEFEE) where T : class
	{
		if ((NGKKLGPFEBB == null && IHIAMPBEFEE == null) || (NGKKLGPFEBB != null && NGKKLGPFEBB.Equals(IHIAMPBEFEE)))
		{
			return false;
		}
		NGKKLGPFEBB = IHIAMPBEFEE;
		return true;
	}
}
