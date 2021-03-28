using System;

// Token: 0x020002EF RID: 751
public class OperationCode
{
	// Token: 0x04001401 RID: 5121
	[Obsolete("Exchanging encrpytion keys is done internally in the lib now. Don't expect this operation-result.")]
	public const byte ExchangeKeysForEncryption = 250;

	// Token: 0x04001402 RID: 5122
	[Obsolete]
	public const byte Join = 255;

	// Token: 0x04001403 RID: 5123
	public const byte AuthenticateOnce = 231;

	// Token: 0x04001404 RID: 5124
	public const byte Authenticate = 230;

	// Token: 0x04001405 RID: 5125
	public const byte JoinLobby = 229;

	// Token: 0x04001406 RID: 5126
	public const byte LeaveLobby = 228;

	// Token: 0x04001407 RID: 5127
	public const byte CreateGame = 227;

	// Token: 0x04001408 RID: 5128
	public const byte JoinGame = 226;

	// Token: 0x04001409 RID: 5129
	public const byte JoinRandomGame = 225;

	// Token: 0x0400140A RID: 5130
	public const byte Leave = 254;

	// Token: 0x0400140B RID: 5131
	public const byte RaiseEvent = 253;

	// Token: 0x0400140C RID: 5132
	public const byte SetProperties = 252;

	// Token: 0x0400140D RID: 5133
	public const byte GetProperties = 251;

	// Token: 0x0400140E RID: 5134
	public const byte ChangeGroups = 248;

	// Token: 0x0400140F RID: 5135
	public const byte FindFriends = 222;

	// Token: 0x04001410 RID: 5136
	public const byte GetLobbyStats = 221;

	// Token: 0x04001411 RID: 5137
	public const byte GetRegions = 220;

	// Token: 0x04001412 RID: 5138
	public const byte WebRpc = 219;

	// Token: 0x04001413 RID: 5139
	public const byte ServerSettings = 218;

	// Token: 0x04001414 RID: 5140
	public const byte GetGameList = 217;
}
