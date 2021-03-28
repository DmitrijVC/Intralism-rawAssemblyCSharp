using System;
using ExitGames.Client.Photon;

// Token: 0x020002E8 RID: 744
internal class OpJoinRandomRoomParams
{
	// Token: 0x04001379 RID: 4985
	public Hashtable ExpectedCustomRoomProperties;

	// Token: 0x0400137A RID: 4986
	public byte ExpectedMaxPlayers;

	// Token: 0x0400137B RID: 4987
	public MatchmakingMode MatchingType;

	// Token: 0x0400137C RID: 4988
	public TypedLobby TypedLobby;

	// Token: 0x0400137D RID: 4989
	public string SqlLobbyFilter;

	// Token: 0x0400137E RID: 4990
	public string[] ExpectedUsers;
}
