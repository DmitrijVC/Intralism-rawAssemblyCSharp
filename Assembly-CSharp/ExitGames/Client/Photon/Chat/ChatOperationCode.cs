using System;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x0200036E RID: 878
	public class ChatOperationCode
	{
		// Token: 0x040016C7 RID: 5831
		public const byte Authenticate = 230;

		// Token: 0x040016C8 RID: 5832
		public const byte Subscribe = 0;

		// Token: 0x040016C9 RID: 5833
		public const byte Unsubscribe = 1;

		// Token: 0x040016CA RID: 5834
		public const byte Publish = 2;

		// Token: 0x040016CB RID: 5835
		public const byte SendPrivate = 3;

		// Token: 0x040016CC RID: 5836
		public const byte ChannelHistory = 4;

		// Token: 0x040016CD RID: 5837
		public const byte UpdateStatus = 5;

		// Token: 0x040016CE RID: 5838
		public const byte AddFriends = 6;

		// Token: 0x040016CF RID: 5839
		public const byte RemoveFriends = 7;
	}
}
