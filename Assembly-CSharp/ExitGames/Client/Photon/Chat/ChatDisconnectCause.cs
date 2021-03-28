using System;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x0200036C RID: 876
	public enum ChatDisconnectCause
	{
		// Token: 0x040016B5 RID: 5813
		None,
		// Token: 0x040016B6 RID: 5814
		DisconnectByServerUserLimit,
		// Token: 0x040016B7 RID: 5815
		ExceptionOnConnect,
		// Token: 0x040016B8 RID: 5816
		DisconnectByServer,
		// Token: 0x040016B9 RID: 5817
		TimeoutDisconnect,
		// Token: 0x040016BA RID: 5818
		Exception,
		// Token: 0x040016BB RID: 5819
		InvalidAuthentication,
		// Token: 0x040016BC RID: 5820
		MaxCcuReached,
		// Token: 0x040016BD RID: 5821
		InvalidRegion,
		// Token: 0x040016BE RID: 5822
		OperationNotAllowedInCurrentState,
		// Token: 0x040016BF RID: 5823
		CustomAuthenticationFailed
	}
}
