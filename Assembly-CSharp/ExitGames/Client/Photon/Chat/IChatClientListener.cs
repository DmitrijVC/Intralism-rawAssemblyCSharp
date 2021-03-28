using System;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x02000377 RID: 887
	public interface IChatClientListener
	{
		// Token: 0x0600C34C RID: 49996
		void DebugReturn(DebugLevel level, string message);

		// Token: 0x0600C34D RID: 49997
		void OnDisconnected();

		// Token: 0x0600C34E RID: 49998
		void OnConnected();

		// Token: 0x0600C34F RID: 49999
		void OnChatStateChange(ChatState state);

		// Token: 0x0600C350 RID: 50000
		void OnGetMessages(string channelName, string[] senders, object[] messages);

		// Token: 0x0600C351 RID: 50001
		void OnPrivateMessage(string sender, object message, string channelName);

		// Token: 0x0600C352 RID: 50002
		void OnSubscribed(string[] channels, bool[] results);

		// Token: 0x0600C353 RID: 50003
		void OnUnsubscribed(string[] channels);

		// Token: 0x0600C354 RID: 50004
		void OnStatusUpdate(string user, int status, bool gotMessage, object message);
	}
}
