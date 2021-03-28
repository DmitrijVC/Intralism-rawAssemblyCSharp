using System;

// Token: 0x020002FD RID: 765
public enum ClientState
{
	// Token: 0x04001463 RID: 5219
	Uninitialized,
	// Token: 0x04001464 RID: 5220
	PeerCreated,
	// Token: 0x04001465 RID: 5221
	Queued,
	// Token: 0x04001466 RID: 5222
	Authenticated,
	// Token: 0x04001467 RID: 5223
	JoinedLobby,
	// Token: 0x04001468 RID: 5224
	DisconnectingFromMasterserver,
	// Token: 0x04001469 RID: 5225
	ConnectingToGameserver,
	// Token: 0x0400146A RID: 5226
	ConnectedToGameserver,
	// Token: 0x0400146B RID: 5227
	Joining,
	// Token: 0x0400146C RID: 5228
	Joined,
	// Token: 0x0400146D RID: 5229
	Leaving,
	// Token: 0x0400146E RID: 5230
	DisconnectingFromGameserver,
	// Token: 0x0400146F RID: 5231
	ConnectingToMasterserver,
	// Token: 0x04001470 RID: 5232
	QueuedComingFromGameserver,
	// Token: 0x04001471 RID: 5233
	Disconnecting,
	// Token: 0x04001472 RID: 5234
	Disconnected,
	// Token: 0x04001473 RID: 5235
	ConnectedToMaster,
	// Token: 0x04001474 RID: 5236
	ConnectingToNameServer,
	// Token: 0x04001475 RID: 5237
	ConnectedToNameServer,
	// Token: 0x04001476 RID: 5238
	DisconnectingFromNameServer,
	// Token: 0x04001477 RID: 5239
	Authenticating
}
