using System;

// Token: 0x020002EA RID: 746
public class ErrorCode
{
	// Token: 0x04001387 RID: 4999
	public const int Ok = 0;

	// Token: 0x04001388 RID: 5000
	public const int OperationNotAllowedInCurrentState = -3;

	// Token: 0x04001389 RID: 5001
	[Obsolete("Use InvalidOperation.")]
	public const int InvalidOperationCode = -2;

	// Token: 0x0400138A RID: 5002
	public const int InvalidOperation = -2;

	// Token: 0x0400138B RID: 5003
	public const int InternalServerError = -1;

	// Token: 0x0400138C RID: 5004
	public const int InvalidAuthentication = 32767;

	// Token: 0x0400138D RID: 5005
	public const int GameIdAlreadyExists = 32766;

	// Token: 0x0400138E RID: 5006
	public const int GameFull = 32765;

	// Token: 0x0400138F RID: 5007
	public const int GameClosed = 32764;

	// Token: 0x04001390 RID: 5008
	[Obsolete("No longer used, cause random matchmaking is no longer a process.")]
	public const int AlreadyMatched = 32763;

	// Token: 0x04001391 RID: 5009
	public const int ServerFull = 32762;

	// Token: 0x04001392 RID: 5010
	public const int UserBlocked = 32761;

	// Token: 0x04001393 RID: 5011
	public const int NoRandomMatchFound = 32760;

	// Token: 0x04001394 RID: 5012
	public const int GameDoesNotExist = 32758;

	// Token: 0x04001395 RID: 5013
	public const int MaxCcuReached = 32757;

	// Token: 0x04001396 RID: 5014
	public const int InvalidRegion = 32756;

	// Token: 0x04001397 RID: 5015
	public const int CustomAuthenticationFailed = 32755;

	// Token: 0x04001398 RID: 5016
	public const int AuthenticationTicketExpired = 32753;

	// Token: 0x04001399 RID: 5017
	public const int PluginReportedError = 32752;

	// Token: 0x0400139A RID: 5018
	public const int PluginMismatch = 32751;

	// Token: 0x0400139B RID: 5019
	public const int JoinFailedPeerAlreadyJoined = 32750;

	// Token: 0x0400139C RID: 5020
	public const int JoinFailedFoundInactiveJoiner = 32749;

	// Token: 0x0400139D RID: 5021
	public const int JoinFailedWithRejoinerNotFound = 32748;

	// Token: 0x0400139E RID: 5022
	public const int JoinFailedFoundExcludedUserId = 32747;

	// Token: 0x0400139F RID: 5023
	public const int JoinFailedFoundActiveJoiner = 32746;

	// Token: 0x040013A0 RID: 5024
	public const int HttpLimitReached = 32745;

	// Token: 0x040013A1 RID: 5025
	public const int ExternalHttpCallFailed = 32744;

	// Token: 0x040013A2 RID: 5026
	public const int SlotError = 32742;

	// Token: 0x040013A3 RID: 5027
	public const int InvalidEncryptionParameters = 32741;
}
