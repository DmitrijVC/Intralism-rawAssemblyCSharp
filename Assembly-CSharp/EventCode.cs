using System;

// Token: 0x020002ED RID: 749
public class EventCode
{
	// Token: 0x040013B0 RID: 5040
	public const byte GameList = 230;

	// Token: 0x040013B1 RID: 5041
	public const byte GameListUpdate = 229;

	// Token: 0x040013B2 RID: 5042
	public const byte QueueState = 228;

	// Token: 0x040013B3 RID: 5043
	public const byte Match = 227;

	// Token: 0x040013B4 RID: 5044
	public const byte AppStats = 226;

	// Token: 0x040013B5 RID: 5045
	public const byte LobbyStats = 224;

	// Token: 0x040013B6 RID: 5046
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const byte AzureNodeInfo = 210;

	// Token: 0x040013B7 RID: 5047
	public const byte Join = 255;

	// Token: 0x040013B8 RID: 5048
	public const byte Leave = 254;

	// Token: 0x040013B9 RID: 5049
	public const byte PropertiesChanged = 253;

	// Token: 0x040013BA RID: 5050
	[Obsolete("Use PropertiesChanged now.")]
	public const byte SetProperties = 253;

	// Token: 0x040013BB RID: 5051
	public const byte ErrorInfo = 251;

	// Token: 0x040013BC RID: 5052
	public const byte CacheSliceChanged = 250;

	// Token: 0x040013BD RID: 5053
	public const byte AuthEvent = 223;
}
