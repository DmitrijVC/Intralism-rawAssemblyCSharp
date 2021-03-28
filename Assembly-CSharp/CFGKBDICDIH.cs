using System;
using System.Collections.Generic;

// Token: 0x020002CD RID: 717
internal static class CFGKBDICDIH
{
	// Token: 0x0600AA9B RID: 43675 RVA: 0x003F5914 File Offset: 0x003F3B14
	internal static Type LEMHLODODPL(Type ANFOJNABFFJ)
	{
		Type type = CFGKBDICDIH.BNNBDLGMAIE(ANFOJNABFFJ);
		if (type == null)
		{
			return ANFOJNABFFJ;
		}
		return type.GetGenericArguments()[0];
	}

	// Token: 0x0600AA9C RID: 43676 RVA: 0x003F5938 File Offset: 0x003F3B38
	private static Type BNNBDLGMAIE(Type ANFOJNABFFJ)
	{
		if (ANFOJNABFFJ == null || ANFOJNABFFJ == typeof(string))
		{
			return null;
		}
		if (ANFOJNABFFJ.IsArray)
		{
			return typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				ANFOJNABFFJ.GetElementType()
			});
		}
		if (ANFOJNABFFJ.IsGenericType)
		{
			foreach (Type type in ANFOJNABFFJ.GetGenericArguments())
			{
				Type type2 = typeof(IEnumerable<>).MakeGenericType(new Type[]
				{
					type
				});
				if (type2.IsAssignableFrom(ANFOJNABFFJ))
				{
					return type2;
				}
			}
		}
		Type[] interfaces = ANFOJNABFFJ.GetInterfaces();
		if (interfaces != null && interfaces.Length > 0)
		{
			foreach (Type anfojnabffj in interfaces)
			{
				Type type3 = CFGKBDICDIH.BNNBDLGMAIE(anfojnabffj);
				if (type3 != null)
				{
					return type3;
				}
			}
		}
		if (ANFOJNABFFJ.BaseType != null && ANFOJNABFFJ.BaseType != typeof(object))
		{
			return CFGKBDICDIH.BNNBDLGMAIE(ANFOJNABFFJ.BaseType);
		}
		return null;
	}

	// Token: 0x0600AA9D RID: 43677 RVA: 0x003F5A56 File Offset: 0x003F3C56
	public static bool IsEnumerableType(Type HMGBJCGOLMI)
	{
		return HMGBJCGOLMI.GetInterface("IEnumerable") != null;
	}

	// Token: 0x0600AA9E RID: 43678 RVA: 0x003F5A69 File Offset: 0x003F3C69
	public static bool IsCollectionType(Type HMGBJCGOLMI)
	{
		return HMGBJCGOLMI.GetInterface("ICollection") != null;
	}
}
