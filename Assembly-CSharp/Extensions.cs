using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020002E1 RID: 737
public static class Extensions
{
	// Token: 0x0600AC8B RID: 44171 RVA: 0x003FB3BC File Offset: 0x003F95BC
	public static ParameterInfo[] GetCachedParemeters(this MethodInfo HCGPGHJPJAM)
	{
		ParameterInfo[] parameters;
		if (!Extensions.ParametersOfMethods.TryGetValue(HCGPGHJPJAM, out parameters))
		{
			parameters = HCGPGHJPJAM.GetParameters();
			Extensions.ParametersOfMethods[HCGPGHJPJAM] = parameters;
		}
		return parameters;
	}

	// Token: 0x0600AC8C RID: 44172 RVA: 0x003FB3F1 File Offset: 0x003F95F1
	public static PhotonView[] GetPhotonViewsInChildren(this GameObject OBFJPHLBFOL)
	{
		return OBFJPHLBFOL.GetComponentsInChildren<PhotonView>(true);
	}

	// Token: 0x0600AC8D RID: 44173 RVA: 0x003FB3FA File Offset: 0x003F95FA
	public static PhotonView GetPhotonView(this GameObject OBFJPHLBFOL)
	{
		return OBFJPHLBFOL.GetComponent<PhotonView>();
	}

	// Token: 0x0600AC8E RID: 44174 RVA: 0x003FB404 File Offset: 0x003F9604
	public static bool AlmostEquals(this Vector3 MPNMOONBMII, Vector3 BICCGCFNNLP, float ECINLPMCJFK)
	{
		return (MPNMOONBMII - BICCGCFNNLP).sqrMagnitude < ECINLPMCJFK;
	}

	// Token: 0x0600AC8F RID: 44175 RVA: 0x003FB424 File Offset: 0x003F9624
	public static bool AlmostEquals(this Vector2 MPNMOONBMII, Vector2 BICCGCFNNLP, float ECINLPMCJFK)
	{
		return (MPNMOONBMII - BICCGCFNNLP).sqrMagnitude < ECINLPMCJFK;
	}

	// Token: 0x0600AC90 RID: 44176 RVA: 0x003FB443 File Offset: 0x003F9643
	public static bool AlmostEquals(this Quaternion MPNMOONBMII, Quaternion BICCGCFNNLP, float MNAOJGNELDM)
	{
		return Quaternion.Angle(MPNMOONBMII, BICCGCFNNLP) < MNAOJGNELDM;
	}

	// Token: 0x0600AC91 RID: 44177 RVA: 0x003FB44F File Offset: 0x003F964F
	public static bool AlmostEquals(this float MPNMOONBMII, float BICCGCFNNLP, float OGODMIJJENE)
	{
		return Mathf.Abs(MPNMOONBMII - BICCGCFNNLP) < OGODMIJJENE;
	}

	// Token: 0x0600AC92 RID: 44178 RVA: 0x003FB45C File Offset: 0x003F965C
	public static void Merge(this IDictionary MPNMOONBMII, IDictionary PFLIKPMIGLK)
	{
		if (PFLIKPMIGLK == null || MPNMOONBMII.Equals(PFLIKPMIGLK))
		{
			return;
		}
		IEnumerator enumerator = PFLIKPMIGLK.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object key = enumerator.Current;
				MPNMOONBMII[key] = PFLIKPMIGLK[key];
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
	}

	// Token: 0x0600AC93 RID: 44179 RVA: 0x003FB4D8 File Offset: 0x003F96D8
	public static void MergeStringKeys(this IDictionary MPNMOONBMII, IDictionary PFLIKPMIGLK)
	{
		if (PFLIKPMIGLK == null || MPNMOONBMII.Equals(PFLIKPMIGLK))
		{
			return;
		}
		IEnumerator enumerator = PFLIKPMIGLK.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				if (obj is string)
				{
					MPNMOONBMII[obj] = PFLIKPMIGLK[obj];
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
	}

	// Token: 0x0600AC94 RID: 44180 RVA: 0x003FB560 File Offset: 0x003F9760
	public static string ToStringFull(this IDictionary GEMDHBEGEFH)
	{
		return SupportClass.DictionaryToString(GEMDHBEGEFH, false);
	}

	// Token: 0x0600AC95 RID: 44181 RVA: 0x003FB56C File Offset: 0x003F976C
	public static string ToStringFull(this object[] NOJGGCLPPAM)
	{
		if (NOJGGCLPPAM == null)
		{
			return "null";
		}
		string[] array = new string[NOJGGCLPPAM.Length];
		for (int i = 0; i < NOJGGCLPPAM.Length; i++)
		{
			object obj = NOJGGCLPPAM[i];
			array[i] = ((obj == null) ? "null" : obj.ToString());
		}
		return string.Join(", ", array);
	}

	// Token: 0x0600AC96 RID: 44182 RVA: 0x003FB5CC File Offset: 0x003F97CC
	public static ExitGames.Client.Photon.Hashtable StripToStringKeys(this IDictionary LMHCHLAIMJH)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		if (LMHCHLAIMJH != null)
		{
			IEnumerator enumerator = LMHCHLAIMJH.Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					if (obj is string)
					{
						hashtable[obj] = LMHCHLAIMJH[obj];
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
		}
		return hashtable;
	}

	// Token: 0x0600AC97 RID: 44183 RVA: 0x003FB64C File Offset: 0x003F984C
	public static void StripKeysWithNullValues(this IDictionary LMHCHLAIMJH)
	{
		object[] array = new object[LMHCHLAIMJH.Count];
		int num = 0;
		IEnumerator enumerator = LMHCHLAIMJH.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				array[num++] = obj;
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
		foreach (object key in array)
		{
			if (LMHCHLAIMJH[key] == null)
			{
				LMHCHLAIMJH.Remove(key);
			}
		}
	}

	// Token: 0x0600AC98 RID: 44184 RVA: 0x003FB6F0 File Offset: 0x003F98F0
	public static bool Contains(this int[] MPNMOONBMII, int FGBCKIIKMNC)
	{
		if (MPNMOONBMII == null)
		{
			return false;
		}
		for (int i = 0; i < MPNMOONBMII.Length; i++)
		{
			if (MPNMOONBMII[i] == FGBCKIIKMNC)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04001368 RID: 4968
	public static Dictionary<MethodInfo, ParameterInfo[]> ParametersOfMethods = new Dictionary<MethodInfo, ParameterInfo[]>();
}
