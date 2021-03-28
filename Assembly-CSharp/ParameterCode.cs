using System;

// Token: 0x020002EE RID: 750
public class ParameterCode
{
	// Token: 0x040013BE RID: 5054
	public const byte SuppressRoomEvents = 237;

	// Token: 0x040013BF RID: 5055
	public const byte EmptyRoomTTL = 236;

	// Token: 0x040013C0 RID: 5056
	public const byte PlayerTTL = 235;

	// Token: 0x040013C1 RID: 5057
	public const byte EventForward = 234;

	// Token: 0x040013C2 RID: 5058
	[Obsolete("Use: IsInactive")]
	public const byte IsComingBack = 233;

	// Token: 0x040013C3 RID: 5059
	public const byte IsInactive = 233;

	// Token: 0x040013C4 RID: 5060
	public const byte CheckUserOnJoin = 232;

	// Token: 0x040013C5 RID: 5061
	public const byte ExpectedValues = 231;

	// Token: 0x040013C6 RID: 5062
	public const byte Address = 230;

	// Token: 0x040013C7 RID: 5063
	public const byte PeerCount = 229;

	// Token: 0x040013C8 RID: 5064
	public const byte GameCount = 228;

	// Token: 0x040013C9 RID: 5065
	public const byte MasterPeerCount = 227;

	// Token: 0x040013CA RID: 5066
	public const byte UserId = 225;

	// Token: 0x040013CB RID: 5067
	public const byte ApplicationId = 224;

	// Token: 0x040013CC RID: 5068
	public const byte Position = 223;

	// Token: 0x040013CD RID: 5069
	public const byte MatchMakingType = 223;

	// Token: 0x040013CE RID: 5070
	public const byte GameList = 222;

	// Token: 0x040013CF RID: 5071
	public const byte Secret = 221;

	// Token: 0x040013D0 RID: 5072
	public const byte AppVersion = 220;

	// Token: 0x040013D1 RID: 5073
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const byte AzureNodeInfo = 210;

	// Token: 0x040013D2 RID: 5074
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const byte AzureLocalNodeId = 209;

	// Token: 0x040013D3 RID: 5075
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const byte AzureMasterNodeId = 208;

	// Token: 0x040013D4 RID: 5076
	public const byte RoomName = 255;

	// Token: 0x040013D5 RID: 5077
	public const byte Broadcast = 250;

	// Token: 0x040013D6 RID: 5078
	public const byte ActorList = 252;

	// Token: 0x040013D7 RID: 5079
	public const byte ActorNr = 254;

	// Token: 0x040013D8 RID: 5080
	public const byte PlayerProperties = 249;

	// Token: 0x040013D9 RID: 5081
	public const byte CustomEventContent = 245;

	// Token: 0x040013DA RID: 5082
	public const byte Data = 245;

	// Token: 0x040013DB RID: 5083
	public const byte Code = 244;

	// Token: 0x040013DC RID: 5084
	public const byte GameProperties = 248;

	// Token: 0x040013DD RID: 5085
	public const byte Properties = 251;

	// Token: 0x040013DE RID: 5086
	public const byte TargetActorNr = 253;

	// Token: 0x040013DF RID: 5087
	public const byte ReceiverGroup = 246;

	// Token: 0x040013E0 RID: 5088
	public const byte Cache = 247;

	// Token: 0x040013E1 RID: 5089
	public const byte CleanupCacheOnLeave = 241;

	// Token: 0x040013E2 RID: 5090
	public const byte Group = 240;

	// Token: 0x040013E3 RID: 5091
	public const byte Remove = 239;

	// Token: 0x040013E4 RID: 5092
	public const byte PublishUserId = 239;

	// Token: 0x040013E5 RID: 5093
	public const byte Add = 238;

	// Token: 0x040013E6 RID: 5094
	public const byte Info = 218;

	// Token: 0x040013E7 RID: 5095
	public const byte ClientAuthenticationType = 217;

	// Token: 0x040013E8 RID: 5096
	public const byte ClientAuthenticationParams = 216;

	// Token: 0x040013E9 RID: 5097
	public const byte JoinMode = 215;

	// Token: 0x040013EA RID: 5098
	public const byte ClientAuthenticationData = 214;

	// Token: 0x040013EB RID: 5099
	public const byte MasterClientId = 203;

	// Token: 0x040013EC RID: 5100
	public const byte FindFriendsRequestList = 1;

	// Token: 0x040013ED RID: 5101
	public const byte FindFriendsResponseOnlineList = 1;

	// Token: 0x040013EE RID: 5102
	public const byte FindFriendsResponseRoomIdList = 2;

	// Token: 0x040013EF RID: 5103
	public const byte LobbyName = 213;

	// Token: 0x040013F0 RID: 5104
	public const byte LobbyType = 212;

	// Token: 0x040013F1 RID: 5105
	public const byte LobbyStats = 211;

	// Token: 0x040013F2 RID: 5106
	public const byte Region = 210;

	// Token: 0x040013F3 RID: 5107
	public const byte UriPath = 209;

	// Token: 0x040013F4 RID: 5108
	public const byte WebRpcParameters = 208;

	// Token: 0x040013F5 RID: 5109
	public const byte WebRpcReturnCode = 207;

	// Token: 0x040013F6 RID: 5110
	public const byte WebRpcReturnMessage = 206;

	// Token: 0x040013F7 RID: 5111
	public const byte CacheSliceIndex = 205;

	// Token: 0x040013F8 RID: 5112
	public const byte Plugins = 204;

	// Token: 0x040013F9 RID: 5113
	public const byte NickName = 202;

	// Token: 0x040013FA RID: 5114
	public const byte PluginName = 201;

	// Token: 0x040013FB RID: 5115
	public const byte PluginVersion = 200;

	// Token: 0x040013FC RID: 5116
	public const byte ExpectedProtocol = 195;

	// Token: 0x040013FD RID: 5117
	public const byte CustomInitData = 194;

	// Token: 0x040013FE RID: 5118
	public const byte EncryptionMode = 193;

	// Token: 0x040013FF RID: 5119
	public const byte EncryptionData = 192;

	// Token: 0x04001400 RID: 5120
	public const byte RoomOptionFlags = 191;
}
