using System;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x02000372 RID: 882
	public class AuthenticationValues
	{
		// Token: 0x0600C33A RID: 49978 RVA: 0x0046F98D File Offset: 0x0046DB8D
		public AuthenticationValues()
		{
		}

		// Token: 0x0600C33B RID: 49979 RVA: 0x0046F9A0 File Offset: 0x0046DBA0
		public AuthenticationValues(string userId)
		{
			this.UserId = userId;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600C33C RID: 49980 RVA: 0x0046F9BA File Offset: 0x0046DBBA
		// (set) Token: 0x0600C33D RID: 49981 RVA: 0x0046F9C2 File Offset: 0x0046DBC2
		public CustomAuthenticationType AuthType
		{
			get
			{
				return this.authType;
			}
			set
			{
				this.authType = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600C33E RID: 49982 RVA: 0x0046F9CB File Offset: 0x0046DBCB
		// (set) Token: 0x0600C33F RID: 49983 RVA: 0x0046F9D3 File Offset: 0x0046DBD3
		public string AuthGetParameters { get; set; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600C340 RID: 49984 RVA: 0x0046F9DC File Offset: 0x0046DBDC
		// (set) Token: 0x0600C341 RID: 49985 RVA: 0x0046F9E4 File Offset: 0x0046DBE4
		public object AuthPostData { get; private set; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600C342 RID: 49986 RVA: 0x0046F9ED File Offset: 0x0046DBED
		// (set) Token: 0x0600C343 RID: 49987 RVA: 0x0046F9F5 File Offset: 0x0046DBF5
		public string Token { get; set; }

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600C344 RID: 49988 RVA: 0x0046F9FE File Offset: 0x0046DBFE
		// (set) Token: 0x0600C345 RID: 49989 RVA: 0x0046FA06 File Offset: 0x0046DC06
		public string UserId { get; set; }

		// Token: 0x0600C346 RID: 49990 RVA: 0x0046FA0F File Offset: 0x0046DC0F
		public virtual void SetAuthPostData(string stringData)
		{
			this.AuthPostData = ((!string.IsNullOrEmpty(stringData)) ? stringData : null);
		}

		// Token: 0x0600C347 RID: 49991 RVA: 0x0046FA29 File Offset: 0x0046DC29
		public virtual void SetAuthPostData(byte[] byteData)
		{
			this.AuthPostData = byteData;
		}

		// Token: 0x0600C348 RID: 49992 RVA: 0x0046FA34 File Offset: 0x0046DC34
		public virtual void AddAuthParameter(string key, string value)
		{
			string text = (!string.IsNullOrEmpty(this.AuthGetParameters)) ? "&" : string.Empty;
			this.AuthGetParameters = string.Format("{0}{1}{2}={3}", new object[]
			{
				this.AuthGetParameters,
				text,
				Uri.EscapeDataString(key),
				Uri.EscapeDataString(value)
			});
		}

		// Token: 0x0600C349 RID: 49993 RVA: 0x0046FA96 File Offset: 0x0046DC96
		public override string ToString()
		{
			return string.Format("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", this.UserId, this.AuthGetParameters, this.Token != null);
		}

		// Token: 0x040016EC RID: 5868
		private CustomAuthenticationType authType = CustomAuthenticationType.None;
	}
}
