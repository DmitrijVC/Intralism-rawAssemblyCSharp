using System;
using UnityEngine;

// Token: 0x020002E2 RID: 738
public static class GameObjectExtensions
{
	// Token: 0x0600AC9A RID: 44186 RVA: 0x003FB731 File Offset: 0x003F9931
	public static bool GetActive(this GameObject MPNMOONBMII)
	{
		return MPNMOONBMII.activeInHierarchy;
	}
}
