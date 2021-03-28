using System;

// Token: 0x020002FF RID: 767
public enum DisconnectCause
{
	// Token: 0x0400147E RID: 5246
	DisconnectByServerUserLimit = 1042,
	// Token: 0x0400147F RID: 5247
	ExceptionOnConnect = 1023,
	// Token: 0x04001480 RID: 5248
	DisconnectByServerTimeout = 1041,
	// Token: 0x04001481 RID: 5249
	DisconnectByServerLogic = 1043,
	// Token: 0x04001482 RID: 5250
	Exception = 1026,
	// Token: 0x04001483 RID: 5251
	InvalidAuthentication = 32767,
	// Token: 0x04001484 RID: 5252
	MaxCcuReached = 32757,
	// Token: 0x04001485 RID: 5253
	InvalidRegion = 32756,
	// Token: 0x04001486 RID: 5254
	SecurityExceptionOnConnect = 1022,
	// Token: 0x04001487 RID: 5255
	DisconnectByClientTimeout = 1040,
	// Token: 0x04001488 RID: 5256
	InternalReceiveException = 1039,
	// Token: 0x04001489 RID: 5257
	AuthenticationTicketExpired = 32753
}
