using System;
using System.Collections.Generic;

// Token: 0x02000451 RID: 1105
internal static class NBKHHKFANLB
{
	// Token: 0x0600FC26 RID: 64550 RVA: 0x00566F12 File Offset: 0x00565112
	public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB)
	{
		return HLBKCLPNHEB.MaxBy(PGBBGIOBPGB, null);
	}

	// Token: 0x0600FC27 RID: 64551 RVA: 0x00566F1C File Offset: 0x0056511C
	public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB, IComparer<TKey> CDNIFCBKPMN)
	{
		if (HLBKCLPNHEB == null)
		{
			throw new ArgumentNullException("source");
		}
		if (PGBBGIOBPGB == null)
		{
			throw new ArgumentNullException("selector");
		}
		CDNIFCBKPMN = (CDNIFCBKPMN ?? Comparer<TKey>.Default);
		TSource result;
		using (IEnumerator<TSource> enumerator = HLBKCLPNHEB.GetEnumerator())
		{
			if (!enumerator.MoveNext())
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			TSource tsource = enumerator.Current;
			TKey y = PGBBGIOBPGB(tsource);
			while (enumerator.MoveNext())
			{
				TSource tsource2 = enumerator.Current;
				TKey tkey = PGBBGIOBPGB(tsource2);
				if (CDNIFCBKPMN.Compare(tkey, y) > 0)
				{
					tsource = tsource2;
					y = tkey;
				}
			}
			result = tsource;
		}
		return result;
	}

	// Token: 0x0600FC28 RID: 64552 RVA: 0x00566FE4 File Offset: 0x005651E4
	public static TSource MinBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB)
	{
		return HLBKCLPNHEB.MinBy(PGBBGIOBPGB, null);
	}

	// Token: 0x0600FC29 RID: 64553 RVA: 0x00566FF0 File Offset: 0x005651F0
	public static TSource MinBy<TSource, TKey>(this IEnumerable<TSource> HLBKCLPNHEB, Func<TSource, TKey> PGBBGIOBPGB, IComparer<TKey> CDNIFCBKPMN)
	{
		if (HLBKCLPNHEB == null)
		{
			throw new ArgumentNullException("source");
		}
		if (PGBBGIOBPGB == null)
		{
			throw new ArgumentNullException("selector");
		}
		CDNIFCBKPMN = (CDNIFCBKPMN ?? Comparer<TKey>.Default);
		TSource result;
		using (IEnumerator<TSource> enumerator = HLBKCLPNHEB.GetEnumerator())
		{
			if (!enumerator.MoveNext())
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			TSource tsource = enumerator.Current;
			TKey y = PGBBGIOBPGB(tsource);
			while (enumerator.MoveNext())
			{
				TSource tsource2 = enumerator.Current;
				TKey tkey = PGBBGIOBPGB(tsource2);
				if (CDNIFCBKPMN.Compare(tkey, y) < 0)
				{
					tsource = tsource2;
					y = tkey;
				}
			}
			result = tsource;
		}
		return result;
	}
}
