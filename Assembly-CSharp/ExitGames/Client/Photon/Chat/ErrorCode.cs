using System;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x02000374 RID: 884
	public class ErrorCode
	{
		// Token: 0x040016FA RID: 5882
		public const int Ok = 0;

		// Token: 0x040016FB RID: 5883
		public const int OperationNotAllowedInCurrentState = -3;

		// Token: 0x040016FC RID: 5884
		public const int InvalidOperationCode = -2;

		// Token: 0x040016FD RID: 5885
		public const int InternalServerError = -1;

		// Token: 0x040016FE RID: 5886
		public const int InvalidAuthentication = 32767;

		// Token: 0x040016FF RID: 5887
		public const int GameIdAlreadyExists = 32766;

		// Token: 0x04001700 RID: 5888
		public const int GameFull = 32765;

		// Token: 0x04001701 RID: 5889
		public const int GameClosed = 32764;

		// Token: 0x04001702 RID: 5890
		public const int ServerFull = 32762;

		// Token: 0x04001703 RID: 5891
		public const int UserBlocked = 32761;

		// Token: 0x04001704 RID: 5892
		public const int NoRandomMatchFound = 32760;

		// Token: 0x04001705 RID: 5893
		public const int GameDoesNotExist = 32758;

		// Token: 0x04001706 RID: 5894
		public const int MaxCcuReached = 32757;

		// Token: 0x04001707 RID: 5895
		public const int InvalidRegion = 32756;

		// Token: 0x04001708 RID: 5896
		public const int CustomAuthenticationFailed = 32755;
	}
}
