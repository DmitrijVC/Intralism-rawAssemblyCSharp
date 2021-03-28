using System;
using System.Collections.Generic;
using System.Text;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x0200036A RID: 874
	public class ChatChannel
	{
		// Token: 0x0600C2E4 RID: 49892 RVA: 0x0046E281 File Offset: 0x0046C481
		public ChatChannel(string name)
		{
			this.Name = name;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600C2E5 RID: 49893 RVA: 0x0046E2A6 File Offset: 0x0046C4A6
		// (set) Token: 0x0600C2E6 RID: 49894 RVA: 0x0046E2AE File Offset: 0x0046C4AE
		public bool IsPrivate { get; protected internal set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600C2E7 RID: 49895 RVA: 0x0046E2B7 File Offset: 0x0046C4B7
		public int MessageCount
		{
			get
			{
				return this.Messages.Count;
			}
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x0046E2C4 File Offset: 0x0046C4C4
		public void Add(string sender, object message)
		{
			this.Senders.Add(sender);
			this.Messages.Add(message);
			this.TruncateMessages();
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x0046E2E4 File Offset: 0x0046C4E4
		public void Add(string[] senders, object[] messages)
		{
			this.Senders.AddRange(senders);
			this.Messages.AddRange(messages);
			this.TruncateMessages();
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x0046E304 File Offset: 0x0046C504
		public void TruncateMessages()
		{
			if (this.MessageLimit <= 0 || this.Messages.Count <= this.MessageLimit)
			{
				return;
			}
			int count = this.Messages.Count - this.MessageLimit;
			this.Senders.RemoveRange(0, count);
			this.Messages.RemoveRange(0, count);
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x0046E361 File Offset: 0x0046C561
		public void ClearMessages()
		{
			this.Senders.Clear();
			this.Messages.Clear();
		}

		// Token: 0x0600C2EC RID: 49900 RVA: 0x0046E37C File Offset: 0x0046C57C
		public string ToStringMessages()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this.Messages.Count; i++)
			{
				stringBuilder.AppendLine(string.Format("{0}: {1}", this.Senders[i], this.Messages[i]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0400169B RID: 5787
		public readonly string Name;

		// Token: 0x0400169C RID: 5788
		public readonly List<string> Senders = new List<string>();

		// Token: 0x0400169D RID: 5789
		public readonly List<object> Messages = new List<object>();

		// Token: 0x0400169E RID: 5790
		public int MessageLimit;
	}
}
