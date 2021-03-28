using System;
using ExitGames.Client.Photon;

// Token: 0x0200035E RID: 862
public static class TurnExtensions
{
	// Token: 0x0600C1AD RID: 49581 RVA: 0x00467334 File Offset: 0x00465534
	public static void SetTurn(this Room COLEOPNODBP, int JPFFPMDKAMC, bool LHOKCIBALFF = false)
	{
		if (COLEOPNODBP == null || COLEOPNODBP.CustomProperties == null)
		{
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable[TurnExtensions.TurnPropKey] = JPFFPMDKAMC;
		if (LHOKCIBALFF)
		{
			hashtable[TurnExtensions.TurnStartPropKey] = PhotonNetwork.ServerTimestamp;
		}
		COLEOPNODBP.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0600C1AE RID: 49582 RVA: 0x0046738E File Offset: 0x0046558E
	public static int GetTurn(this RoomInfo COLEOPNODBP)
	{
		if (COLEOPNODBP == null || COLEOPNODBP.CustomProperties == null || !COLEOPNODBP.CustomProperties.ContainsKey(TurnExtensions.TurnPropKey))
		{
			return 0;
		}
		return (int)COLEOPNODBP.CustomProperties[TurnExtensions.TurnPropKey];
	}

	// Token: 0x0600C1AF RID: 49583 RVA: 0x004673CD File Offset: 0x004655CD
	public static int GetTurnStart(this RoomInfo COLEOPNODBP)
	{
		if (COLEOPNODBP == null || COLEOPNODBP.CustomProperties == null || !COLEOPNODBP.CustomProperties.ContainsKey(TurnExtensions.TurnStartPropKey))
		{
			return 0;
		}
		return (int)COLEOPNODBP.CustomProperties[TurnExtensions.TurnStartPropKey];
	}

	// Token: 0x0600C1B0 RID: 49584 RVA: 0x0046740C File Offset: 0x0046560C
	public static int GetFinishedTurn(this PhotonPlayer JHOEDACNNKK)
	{
		Room room = PhotonNetwork.room;
		if (room == null || room.CustomProperties == null || !room.CustomProperties.ContainsKey(TurnExtensions.TurnPropKey))
		{
			return 0;
		}
		string key = TurnExtensions.FinishedTurnPropKey + JHOEDACNNKK.ID;
		return (int)room.CustomProperties[key];
	}

	// Token: 0x0600C1B1 RID: 49585 RVA: 0x00467470 File Offset: 0x00465670
	public static void SetFinishedTurn(this PhotonPlayer JHOEDACNNKK, int JPFFPMDKAMC)
	{
		Room room = PhotonNetwork.room;
		if (room == null || room.CustomProperties == null)
		{
			return;
		}
		string key = TurnExtensions.FinishedTurnPropKey + JHOEDACNNKK.ID;
		Hashtable hashtable = new Hashtable();
		hashtable[key] = JPFFPMDKAMC;
		room.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0400167E RID: 5758
	public static readonly string TurnPropKey = "Turn";

	// Token: 0x0400167F RID: 5759
	public static readonly string TurnStartPropKey = "TStart";

	// Token: 0x04001680 RID: 5760
	public static readonly string FinishedTurnPropKey = "FToA";
}
