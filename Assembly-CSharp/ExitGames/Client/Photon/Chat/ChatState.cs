using System;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x02000375 RID: 885
	public enum ChatState
	{
		// Token: 0x0400170A RID: 5898
		Uninitialized,
		// Token: 0x0400170B RID: 5899
		ConnectingToNameServer,
		// Token: 0x0400170C RID: 5900
		ConnectedToNameServer,
		// Token: 0x0400170D RID: 5901
		Authenticating,
		// Token: 0x0400170E RID: 5902
		Authenticated,
		// Token: 0x0400170F RID: 5903
		DisconnectingFromNameServer,
		// Token: 0x04001710 RID: 5904
		ConnectingToFrontEnd,
		// Token: 0x04001711 RID: 5905
		ConnectedToFrontEnd,
		// Token: 0x04001712 RID: 5906
		DisconnectingFromFrontEnd,
		// Token: 0x04001713 RID: 5907
		QueuedComingFromFrontEnd,
		// Token: 0x04001714 RID: 5908
		Disconnecting,
		// Token: 0x04001715 RID: 5909
		Disconnected
	}
}
