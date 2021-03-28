using System;
using UnityEngine;

namespace ExitGames.UtilityScripts
{
	// Token: 0x02000352 RID: 850
	public static class PlayerRoomIndexingExtensions
	{
		// Token: 0x0600BF96 RID: 49046 RVA: 0x0045B87E File Offset: 0x00459A7E
		public static int GetRoomIndex(this PhotonPlayer player)
		{
			if (PlayerRoomIndexing.instance == null)
			{
				Debug.LogError("Missing PlayerRoomIndexing Component in Scene");
				return -1;
			}
			return PlayerRoomIndexing.instance.GetRoomIndex(player);
		}
	}
}
