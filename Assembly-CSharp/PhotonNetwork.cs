using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000310 RID: 784
public static class PhotonNetwork
{
	// Token: 0x0600B347 RID: 45895 RVA: 0x0041BA18 File Offset: 0x00419C18
	static PhotonNetwork()
	{
		if (PhotonNetwork.PhotonServerSettings != null)
		{
			Application.runInBackground = PhotonNetwork.PhotonServerSettings.RunInBackground;
		}
		GameObject gameObject = new GameObject();
		PhotonNetwork.IBABLIBBKAG = gameObject.AddComponent<PhotonHandler>();
		gameObject.name = "PhotonMono";
		gameObject.hideFlags = HideFlags.HideInHierarchy;
		ConnectionProtocol protocol = PhotonNetwork.PhotonServerSettings.Protocol;
		PhotonNetwork.JNJJAMNLOHA = new BNGIGHBHPEH(string.Empty, protocol);
		PhotonNetwork.JNJJAMNLOHA.QuickResendAttempts = 2;
		PhotonNetwork.JNJJAMNLOHA.SentCountAllowance = 7;
		if (PhotonNetwork.JLDPEKGBJGO)
		{
			UnityEngine.Debug.Log("Using Stopwatch as precision timer for PUN.");
			PhotonNetwork.DKNFDIMGLKG = new Stopwatch();
			PhotonNetwork.DKNFDIMGLKG.Start();
			PhotonNetwork.JNJJAMNLOHA.LocalMsTimestampDelegate = new SupportClass.IntegerMillisecondsDelegate(PhotonNetwork.DLFFNMKNFJA);
		}
		GOLJCGMCKMG.FJPBNMBIOHG();
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x0600B348 RID: 45896 RVA: 0x0041BBA4 File Offset: 0x00419DA4
	// (set) Token: 0x0600B349 RID: 45897 RVA: 0x0041BBAB File Offset: 0x00419DAB
	public static string gameVersion { get; set; }

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x0600B34A RID: 45898 RVA: 0x0041BBB3 File Offset: 0x00419DB3
	public static string ServerAddress
	{
		get
		{
			return (PhotonNetwork.JNJJAMNLOHA == null) ? "<not connected>" : PhotonNetwork.JNJJAMNLOHA.ServerAddress;
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x0600B34B RID: 45899 RVA: 0x0041BBD3 File Offset: 0x00419DD3
	public static CloudRegionCode CloudRegion
	{
		get
		{
			return (PhotonNetwork.JNJJAMNLOHA == null || !PhotonNetwork.connected || PhotonNetwork.Server == ServerConnection.NameServer) ? CloudRegionCode.none : PhotonNetwork.JNJJAMNLOHA.CloudRegion;
		}
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x0600B34C RID: 45900 RVA: 0x0041BC04 File Offset: 0x00419E04
	public static bool connected
	{
		get
		{
			return PhotonNetwork.offlineMode || (PhotonNetwork.JNJJAMNLOHA != null && (!PhotonNetwork.JNJJAMNLOHA.IsInitialConnect && PhotonNetwork.JNJJAMNLOHA.State != ClientState.PeerCreated && PhotonNetwork.JNJJAMNLOHA.State != ClientState.Disconnected && PhotonNetwork.JNJJAMNLOHA.State != ClientState.Disconnecting) && PhotonNetwork.JNJJAMNLOHA.State != ClientState.ConnectingToNameServer);
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x0600B34D RID: 45901 RVA: 0x0041BC7E File Offset: 0x00419E7E
	public static bool connecting
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.IsInitialConnect && !PhotonNetwork.offlineMode;
		}
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x0600B34E RID: 45902 RVA: 0x0041BC9C File Offset: 0x00419E9C
	public static bool connectedAndReady
	{
		get
		{
			if (!PhotonNetwork.connected)
			{
				return false;
			}
			if (PhotonNetwork.offlineMode)
			{
				return true;
			}
			ClientState connectionStateDetailed = PhotonNetwork.connectionStateDetailed;
			switch (connectionStateDetailed)
			{
			case ClientState.ConnectingToMasterserver:
			case ClientState.Disconnecting:
			case ClientState.Disconnected:
			case ClientState.ConnectingToNameServer:
			case ClientState.Authenticating:
				break;
			default:
				switch (connectionStateDetailed)
				{
				case ClientState.ConnectingToGameserver:
				case ClientState.Joining:
					break;
				default:
					if (connectionStateDetailed != ClientState.PeerCreated)
					{
						return true;
					}
					break;
				}
				break;
			}
			return false;
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x0600B34F RID: 45903 RVA: 0x0041BD18 File Offset: 0x00419F18
	public static ConnectionState connectionState
	{
		get
		{
			if (PhotonNetwork.offlineMode)
			{
				return ConnectionState.Connected;
			}
			if (PhotonNetwork.JNJJAMNLOHA == null)
			{
				return ConnectionState.Disconnected;
			}
			PeerStateValue peerState = PhotonNetwork.JNJJAMNLOHA.PeerState;
			switch (peerState)
			{
			case PeerStateValue.Disconnected:
				return ConnectionState.Disconnected;
			case PeerStateValue.Connecting:
				return ConnectionState.Connecting;
			default:
				if (peerState != PeerStateValue.InitializingApplication)
				{
					return ConnectionState.Disconnected;
				}
				return ConnectionState.InitializingApplication;
			case PeerStateValue.Connected:
				return ConnectionState.Connected;
			case PeerStateValue.Disconnecting:
				return ConnectionState.Disconnecting;
			}
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x0600B350 RID: 45904 RVA: 0x0041BD7A File Offset: 0x00419F7A
	public static ClientState connectionStateDetailed
	{
		get
		{
			if (PhotonNetwork.offlineMode)
			{
				return (PhotonNetwork.DNGILIFEKBM == null) ? ClientState.ConnectedToMaster : ClientState.Joined;
			}
			if (PhotonNetwork.JNJJAMNLOHA == null)
			{
				return ClientState.Disconnected;
			}
			return PhotonNetwork.JNJJAMNLOHA.State;
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x0600B351 RID: 45905 RVA: 0x0041BDB1 File Offset: 0x00419FB1
	public static ServerConnection Server
	{
		get
		{
			return (PhotonNetwork.JNJJAMNLOHA == null) ? ServerConnection.NameServer : PhotonNetwork.JNJJAMNLOHA.EHALCLFLGJF;
		}
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x0600B352 RID: 45906 RVA: 0x0041BDCD File Offset: 0x00419FCD
	// (set) Token: 0x0600B353 RID: 45907 RVA: 0x0041BDE9 File Offset: 0x00419FE9
	public static AuthenticationValues AuthValues
	{
		get
		{
			return (PhotonNetwork.JNJJAMNLOHA == null) ? null : PhotonNetwork.JNJJAMNLOHA.AuthValues;
		}
		set
		{
			if (PhotonNetwork.JNJJAMNLOHA != null)
			{
				PhotonNetwork.JNJJAMNLOHA.AuthValues = value;
			}
		}
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x0600B354 RID: 45908 RVA: 0x0041BE00 File Offset: 0x0041A000
	public static Room room
	{
		get
		{
			if (PhotonNetwork.DKPLFGHOICJ)
			{
				return PhotonNetwork.DNGILIFEKBM;
			}
			return PhotonNetwork.JNJJAMNLOHA.CurrentRoom;
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x0600B355 RID: 45909 RVA: 0x0041BE1C File Offset: 0x0041A01C
	public static PhotonPlayer player
	{
		get
		{
			if (PhotonNetwork.JNJJAMNLOHA == null)
			{
				return null;
			}
			return PhotonNetwork.JNJJAMNLOHA.LocalPlayer;
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x0600B356 RID: 45910 RVA: 0x0041BE34 File Offset: 0x0041A034
	public static PhotonPlayer masterClient
	{
		get
		{
			if (PhotonNetwork.offlineMode)
			{
				return PhotonNetwork.player;
			}
			if (PhotonNetwork.JNJJAMNLOHA == null)
			{
				return null;
			}
			return PhotonNetwork.JNJJAMNLOHA.ICMGDHDNIJD(PhotonNetwork.JNJJAMNLOHA.mMasterClientId);
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x0600B357 RID: 45911 RVA: 0x0041BE66 File Offset: 0x0041A066
	// (set) Token: 0x0600B358 RID: 45912 RVA: 0x0041BE72 File Offset: 0x0041A072
	public static string playerName
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.PlayerName;
		}
		set
		{
			PhotonNetwork.JNJJAMNLOHA.PlayerName = value;
		}
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x0600B359 RID: 45913 RVA: 0x0041BE7F File Offset: 0x0041A07F
	public static PhotonPlayer[] playerList
	{
		get
		{
			if (PhotonNetwork.JNJJAMNLOHA == null)
			{
				return new PhotonPlayer[0];
			}
			return PhotonNetwork.JNJJAMNLOHA.mPlayerListCopy;
		}
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x0600B35A RID: 45914 RVA: 0x0041BE9C File Offset: 0x0041A09C
	public static PhotonPlayer[] otherPlayers
	{
		get
		{
			if (PhotonNetwork.JNJJAMNLOHA == null)
			{
				return new PhotonPlayer[0];
			}
			return PhotonNetwork.JNJJAMNLOHA.mOtherPlayerListCopy;
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x0600B35B RID: 45915 RVA: 0x0041BEB9 File Offset: 0x0041A0B9
	// (set) Token: 0x0600B35C RID: 45916 RVA: 0x0041BEC0 File Offset: 0x0041A0C0
	public static List<FriendInfo> Friends { get; internal set; }

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x0600B35D RID: 45917 RVA: 0x0041BEC8 File Offset: 0x0041A0C8
	public static int FriendsListAge
	{
		get
		{
			return (PhotonNetwork.JNJJAMNLOHA == null) ? 0 : PhotonNetwork.JNJJAMNLOHA.LALFOLKNJJD;
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x0600B35E RID: 45918 RVA: 0x0041BEE4 File Offset: 0x0041A0E4
	// (set) Token: 0x0600B35F RID: 45919 RVA: 0x0041BEF0 File Offset: 0x0041A0F0
	public static IPunPrefabPool PrefabPool
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.EGNHNBODKHP;
		}
		set
		{
			PhotonNetwork.JNJJAMNLOHA.EGNHNBODKHP = value;
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x0600B360 RID: 45920 RVA: 0x0041BEFD File Offset: 0x0041A0FD
	// (set) Token: 0x0600B361 RID: 45921 RVA: 0x0041BF04 File Offset: 0x0041A104
	public static bool offlineMode
	{
		get
		{
			return PhotonNetwork.DKPLFGHOICJ;
		}
		set
		{
			if (value == PhotonNetwork.DKPLFGHOICJ)
			{
				return;
			}
			if (value && PhotonNetwork.connected)
			{
				UnityEngine.Debug.LogError("Can't start OFFLINE mode while connected!");
				return;
			}
			if (PhotonNetwork.JNJJAMNLOHA.PeerState != PeerStateValue.Disconnected)
			{
				PhotonNetwork.JNJJAMNLOHA.Disconnect();
			}
			PhotonNetwork.DKPLFGHOICJ = value;
			if (PhotonNetwork.DKPLFGHOICJ)
			{
				PhotonNetwork.JNJJAMNLOHA.ChangeLocalID(-1);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToMaster, new object[0]);
			}
			else
			{
				PhotonNetwork.DNGILIFEKBM = null;
				PhotonNetwork.JNJJAMNLOHA.ChangeLocalID(-1);
			}
		}
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x0600B362 RID: 45922 RVA: 0x0041BF8F File Offset: 0x0041A18F
	// (set) Token: 0x0600B363 RID: 45923 RVA: 0x0041BF96 File Offset: 0x0041A196
	public static bool automaticallySyncScene
	{
		get
		{
			return PhotonNetwork.KLLBMBCNMGO;
		}
		set
		{
			PhotonNetwork.KLLBMBCNMGO = value;
			if (PhotonNetwork.KLLBMBCNMGO && PhotonNetwork.room != null)
			{
				PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
			}
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x0600B364 RID: 45924 RVA: 0x0041BFBC File Offset: 0x0041A1BC
	// (set) Token: 0x0600B365 RID: 45925 RVA: 0x0041BFC3 File Offset: 0x0041A1C3
	public static bool autoCleanUpPlayerObjects
	{
		get
		{
			return PhotonNetwork.EBIOGPLPINH;
		}
		set
		{
			if (PhotonNetwork.room != null)
			{
				UnityEngine.Debug.LogError("Setting autoCleanUpPlayerObjects while in a room is not supported.");
			}
			else
			{
				PhotonNetwork.EBIOGPLPINH = value;
			}
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x0600B366 RID: 45926 RVA: 0x0041BFE4 File Offset: 0x0041A1E4
	// (set) Token: 0x0600B367 RID: 45927 RVA: 0x0041BFF0 File Offset: 0x0041A1F0
	public static bool autoJoinLobby
	{
		get
		{
			return PhotonNetwork.PhotonServerSettings.JoinLobby;
		}
		set
		{
			PhotonNetwork.PhotonServerSettings.JoinLobby = value;
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x0600B368 RID: 45928 RVA: 0x0041BFFD File Offset: 0x0041A1FD
	// (set) Token: 0x0600B369 RID: 45929 RVA: 0x0041C009 File Offset: 0x0041A209
	public static bool EnableLobbyStatistics
	{
		get
		{
			return PhotonNetwork.PhotonServerSettings.EnableLobbyStatistics;
		}
		set
		{
			PhotonNetwork.PhotonServerSettings.EnableLobbyStatistics = value;
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x0600B36A RID: 45930 RVA: 0x0041C016 File Offset: 0x0041A216
	// (set) Token: 0x0600B36B RID: 45931 RVA: 0x0041C022 File Offset: 0x0041A222
	public static List<TypedLobbyInfo> LobbyStatistics
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.HOBLKOKPJOE;
		}
		private set
		{
			PhotonNetwork.JNJJAMNLOHA.HOBLKOKPJOE = value;
		}
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x0600B36C RID: 45932 RVA: 0x0041C02F File Offset: 0x0041A22F
	public static bool insideLobby
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.insideLobby;
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x0600B36D RID: 45933 RVA: 0x0041C03B File Offset: 0x0041A23B
	// (set) Token: 0x0600B36E RID: 45934 RVA: 0x0041C047 File Offset: 0x0041A247
	public static TypedLobby lobby
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.lobby;
		}
		set
		{
			PhotonNetwork.JNJJAMNLOHA.lobby = value;
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x0600B36F RID: 45935 RVA: 0x0041C054 File Offset: 0x0041A254
	// (set) Token: 0x0600B370 RID: 45936 RVA: 0x0041C061 File Offset: 0x0041A261
	public static int sendRate
	{
		get
		{
			return 1000 / PhotonNetwork.BDPJPHDKAOM;
		}
		set
		{
			PhotonNetwork.BDPJPHDKAOM = 1000 / value;
			if (PhotonNetwork.IBABLIBBKAG != null)
			{
				PhotonNetwork.IBABLIBBKAG.updateInterval = PhotonNetwork.BDPJPHDKAOM;
			}
			if (value < PhotonNetwork.sendRateOnSerialize)
			{
				PhotonNetwork.sendRateOnSerialize = value;
			}
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x0600B371 RID: 45937 RVA: 0x0041C09F File Offset: 0x0041A29F
	// (set) Token: 0x0600B372 RID: 45938 RVA: 0x0041C0AC File Offset: 0x0041A2AC
	public static int sendRateOnSerialize
	{
		get
		{
			return 1000 / PhotonNetwork.GMHJFCMGKCB;
		}
		set
		{
			if (value > PhotonNetwork.sendRate)
			{
				UnityEngine.Debug.LogError("Error: Can not set the OnSerialize rate higher than the overall SendRate.");
				value = PhotonNetwork.sendRate;
			}
			PhotonNetwork.GMHJFCMGKCB = 1000 / value;
			if (PhotonNetwork.IBABLIBBKAG != null)
			{
				PhotonNetwork.IBABLIBBKAG.updateIntervalOnSerialize = PhotonNetwork.GMHJFCMGKCB;
			}
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x0600B373 RID: 45939 RVA: 0x0041C100 File Offset: 0x0041A300
	// (set) Token: 0x0600B374 RID: 45940 RVA: 0x0041C107 File Offset: 0x0041A307
	public static bool isMessageQueueRunning
	{
		get
		{
			return PhotonNetwork.LGLLFPCCGBM;
		}
		set
		{
			if (value)
			{
				PhotonHandler.StartFallbackSendAckThread();
			}
			PhotonNetwork.JNJJAMNLOHA.IsSendingOnlyAcks = !value;
			PhotonNetwork.LGLLFPCCGBM = value;
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x0600B375 RID: 45941 RVA: 0x0041C128 File Offset: 0x0041A328
	// (set) Token: 0x0600B376 RID: 45942 RVA: 0x0041C134 File Offset: 0x0041A334
	public static int unreliableCommandsLimit
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.LimitOfUnreliableCommands;
		}
		set
		{
			PhotonNetwork.JNJJAMNLOHA.LimitOfUnreliableCommands = value;
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x0600B377 RID: 45943 RVA: 0x0041C144 File Offset: 0x0041A344
	public static double time
	{
		get
		{
			uint serverTimestamp = (uint)PhotonNetwork.ServerTimestamp;
			double num = serverTimestamp;
			return num / 1000.0;
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x0600B378 RID: 45944 RVA: 0x0041C168 File Offset: 0x0041A368
	public static int ServerTimestamp
	{
		get
		{
			if (!PhotonNetwork.offlineMode)
			{
				return PhotonNetwork.JNJJAMNLOHA.ServerTimeInMilliSeconds;
			}
			if (PhotonNetwork.JLDPEKGBJGO && PhotonNetwork.DKNFDIMGLKG != null && PhotonNetwork.DKNFDIMGLKG.IsRunning)
			{
				return (int)PhotonNetwork.DKNFDIMGLKG.ElapsedMilliseconds;
			}
			return Environment.TickCount;
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x0600B379 RID: 45945 RVA: 0x0041C1BE File Offset: 0x0041A3BE
	public static bool isMasterClient
	{
		get
		{
			return PhotonNetwork.offlineMode || PhotonNetwork.JNJJAMNLOHA.mMasterClientId == PhotonNetwork.player.ID;
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x0600B37A RID: 45946 RVA: 0x0041C1E2 File Offset: 0x0041A3E2
	public static bool inRoom
	{
		get
		{
			return PhotonNetwork.connectionStateDetailed == ClientState.Joined;
		}
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x0600B37B RID: 45947 RVA: 0x0041C1ED File Offset: 0x0041A3ED
	public static bool isNonMasterClientInRoom
	{
		get
		{
			return !PhotonNetwork.isMasterClient && PhotonNetwork.room != null;
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x0600B37C RID: 45948 RVA: 0x0041C207 File Offset: 0x0041A407
	public static int countOfPlayersOnMaster
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.PlayersOnMasterCount;
		}
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x0600B37D RID: 45949 RVA: 0x0041C213 File Offset: 0x0041A413
	public static int countOfPlayersInRooms
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.PlayersInRoomsCount;
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x0600B37E RID: 45950 RVA: 0x0041C21F File Offset: 0x0041A41F
	public static int countOfPlayers
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.PlayersInRoomsCount + PhotonNetwork.JNJJAMNLOHA.PlayersOnMasterCount;
		}
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x0600B37F RID: 45951 RVA: 0x0041C236 File Offset: 0x0041A436
	public static int countOfRooms
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.RoomsCount;
		}
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x0600B380 RID: 45952 RVA: 0x0041C242 File Offset: 0x0041A442
	// (set) Token: 0x0600B381 RID: 45953 RVA: 0x0041C24E File Offset: 0x0041A44E
	public static bool NetworkStatisticsEnabled
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled;
		}
		set
		{
			PhotonNetwork.JNJJAMNLOHA.TrafficStatsEnabled = value;
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x0600B382 RID: 45954 RVA: 0x0041C25B File Offset: 0x0041A45B
	public static int ResentReliableCommands
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.ResentReliableCommands;
		}
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x0600B383 RID: 45955 RVA: 0x0041C267 File Offset: 0x0041A467
	// (set) Token: 0x0600B384 RID: 45956 RVA: 0x0041C274 File Offset: 0x0041A474
	public static bool CrcCheckEnabled
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.CrcEnabled;
		}
		set
		{
			if (!PhotonNetwork.connected && !PhotonNetwork.connecting)
			{
				PhotonNetwork.JNJJAMNLOHA.CrcEnabled = value;
			}
			else
			{
				UnityEngine.Debug.Log("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays " + PhotonNetwork.JNJJAMNLOHA.CrcEnabled);
			}
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x0600B385 RID: 45957 RVA: 0x0041C2C3 File Offset: 0x0041A4C3
	public static int PacketLossByCrcCheck
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.PacketLossByCrc;
		}
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x0600B386 RID: 45958 RVA: 0x0041C2CF File Offset: 0x0041A4CF
	// (set) Token: 0x0600B387 RID: 45959 RVA: 0x0041C2DB File Offset: 0x0041A4DB
	public static int MaxResendsBeforeDisconnect
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.SentCountAllowance;
		}
		set
		{
			if (value < 3)
			{
				value = 3;
			}
			if (value > 10)
			{
				value = 10;
			}
			PhotonNetwork.JNJJAMNLOHA.SentCountAllowance = value;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x0600B388 RID: 45960 RVA: 0x0041C2FE File Offset: 0x0041A4FE
	// (set) Token: 0x0600B389 RID: 45961 RVA: 0x0041C30A File Offset: 0x0041A50A
	public static int QuickResends
	{
		get
		{
			return (int)PhotonNetwork.JNJJAMNLOHA.QuickResendAttempts;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			if (value > 3)
			{
				value = 3;
			}
			PhotonNetwork.JNJJAMNLOHA.QuickResendAttempts = (byte)value;
		}
	}

	// Token: 0x0600B38A RID: 45962 RVA: 0x0041C32C File Offset: 0x0041A52C
	public static void SwitchToProtocol(ConnectionProtocol EMACCDOCOFM)
	{
		PhotonNetwork.JNJJAMNLOHA.TransportProtocol = EMACCDOCOFM;
	}

	// Token: 0x0600B38B RID: 45963 RVA: 0x0041C33C File Offset: 0x0041A53C
	public static bool ConnectUsingSettings(string MHMPNKGMNMJ)
	{
		if (PhotonNetwork.JNJJAMNLOHA.PeerState != PeerStateValue.Disconnected)
		{
			UnityEngine.Debug.LogWarning("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: " + PhotonNetwork.JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonNetwork.PhotonServerSettings == null)
		{
			UnityEngine.Debug.LogError("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
			return false;
		}
		if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.NotSet)
		{
			UnityEngine.Debug.LogError("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().");
			return false;
		}
		if (PhotonNetwork.logLevel == PhotonLogLevel.ErrorsOnly)
		{
			PhotonNetwork.logLevel = PhotonNetwork.PhotonServerSettings.PunLogging;
		}
		if (PhotonNetwork.JNJJAMNLOHA.DebugOut == DebugLevel.ERROR)
		{
			PhotonNetwork.JNJJAMNLOHA.DebugOut = PhotonNetwork.PhotonServerSettings.NetworkLogging;
		}
		PhotonNetwork.SwitchToProtocol(PhotonNetwork.PhotonServerSettings.Protocol);
		PhotonNetwork.JNJJAMNLOHA.SetApp(PhotonNetwork.PhotonServerSettings.AppID, MHMPNKGMNMJ);
		if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode)
		{
			PhotonNetwork.offlineMode = true;
			return true;
		}
		if (PhotonNetwork.offlineMode)
		{
			UnityEngine.Debug.LogWarning("ConnectUsingSettings() disabled the offline mode. No longer offline.");
		}
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.isMessageQueueRunning = true;
		PhotonNetwork.JNJJAMNLOHA.IsInitialConnect = true;
		if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.SelfHosted)
		{
			PhotonNetwork.JNJJAMNLOHA.IsUsingNameServer = false;
			PhotonNetwork.JNJJAMNLOHA.MasterServerAddress = ((PhotonNetwork.PhotonServerSettings.ServerPort != 0) ? (PhotonNetwork.PhotonServerSettings.ServerAddress + ":" + PhotonNetwork.PhotonServerSettings.ServerPort) : PhotonNetwork.PhotonServerSettings.ServerAddress);
			return PhotonNetwork.JNJJAMNLOHA.Connect(PhotonNetwork.JNJJAMNLOHA.MasterServerAddress, ServerConnection.MasterServer);
		}
		if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion)
		{
			return PhotonNetwork.ConnectToBestCloudServer(MHMPNKGMNMJ);
		}
		return PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(PhotonNetwork.PhotonServerSettings.PreferredRegion);
	}

	// Token: 0x0600B38C RID: 45964 RVA: 0x0041C4FC File Offset: 0x0041A6FC
	public static bool ConnectToMaster(string OALFNANFDLI, int EFCMLJHKDEL, string KCJNNPJCECD, string MHMPNKGMNMJ)
	{
		if (PhotonNetwork.JNJJAMNLOHA.PeerState != PeerStateValue.Disconnected)
		{
			UnityEngine.Debug.LogWarning("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: " + PhotonNetwork.JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonNetwork.offlineMode)
		{
			PhotonNetwork.offlineMode = false;
			UnityEngine.Debug.LogWarning("ConnectToMaster() disabled the offline mode. No longer offline.");
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			PhotonNetwork.isMessageQueueRunning = true;
			UnityEngine.Debug.LogWarning("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		}
		PhotonNetwork.JNJJAMNLOHA.SetApp(KCJNNPJCECD, MHMPNKGMNMJ);
		PhotonNetwork.JNJJAMNLOHA.IsUsingNameServer = false;
		PhotonNetwork.JNJJAMNLOHA.IsInitialConnect = true;
		PhotonNetwork.JNJJAMNLOHA.MasterServerAddress = ((EFCMLJHKDEL != 0) ? (OALFNANFDLI + ":" + EFCMLJHKDEL) : OALFNANFDLI);
		return PhotonNetwork.JNJJAMNLOHA.Connect(PhotonNetwork.JNJJAMNLOHA.MasterServerAddress, ServerConnection.MasterServer);
	}

	// Token: 0x0600B38D RID: 45965 RVA: 0x0041C5CC File Offset: 0x0041A7CC
	public static bool Reconnect()
	{
		if (string.IsNullOrEmpty(PhotonNetwork.JNJJAMNLOHA.MasterServerAddress))
		{
			UnityEngine.Debug.LogWarning("Reconnect() failed. It seems the client wasn't connected before?! Current state: " + PhotonNetwork.JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonNetwork.JNJJAMNLOHA.PeerState != PeerStateValue.Disconnected)
		{
			UnityEngine.Debug.LogWarning("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: " + PhotonNetwork.JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonNetwork.offlineMode)
		{
			PhotonNetwork.offlineMode = false;
			UnityEngine.Debug.LogWarning("Reconnect() disabled the offline mode. No longer offline.");
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			PhotonNetwork.isMessageQueueRunning = true;
			UnityEngine.Debug.LogWarning("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		}
		PhotonNetwork.JNJJAMNLOHA.IsUsingNameServer = false;
		PhotonNetwork.JNJJAMNLOHA.IsInitialConnect = false;
		return PhotonNetwork.JNJJAMNLOHA.ReconnectToMaster();
	}

	// Token: 0x0600B38E RID: 45966 RVA: 0x0041C690 File Offset: 0x0041A890
	public static bool ReconnectAndRejoin()
	{
		if (PhotonNetwork.JNJJAMNLOHA.PeerState != PeerStateValue.Disconnected)
		{
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: " + PhotonNetwork.JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonNetwork.offlineMode)
		{
			PhotonNetwork.offlineMode = false;
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() disabled the offline mode. No longer offline.");
		}
		if (string.IsNullOrEmpty(PhotonNetwork.JNJJAMNLOHA.GameServerAddress))
		{
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).");
			return false;
		}
		if (PhotonNetwork.JNJJAMNLOHA.AJFMHFLGCFN == null)
		{
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.");
			return false;
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			PhotonNetwork.isMessageQueueRunning = true;
			UnityEngine.Debug.LogWarning("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		}
		PhotonNetwork.JNJJAMNLOHA.IsUsingNameServer = false;
		PhotonNetwork.JNJJAMNLOHA.IsInitialConnect = false;
		return PhotonNetwork.JNJJAMNLOHA.ReconnectAndRejoin();
	}

	// Token: 0x0600B38F RID: 45967 RVA: 0x0041C75C File Offset: 0x0041A95C
	public static bool ConnectToBestCloudServer(string MHMPNKGMNMJ)
	{
		if (PhotonNetwork.JNJJAMNLOHA.PeerState != PeerStateValue.Disconnected)
		{
			UnityEngine.Debug.LogWarning("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: " + PhotonNetwork.JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonNetwork.PhotonServerSettings == null)
		{
			UnityEngine.Debug.LogError("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
			return false;
		}
		if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode)
		{
			return PhotonNetwork.ConnectUsingSettings(MHMPNKGMNMJ);
		}
		PhotonNetwork.JNJJAMNLOHA.IsInitialConnect = true;
		PhotonNetwork.JNJJAMNLOHA.SetApp(PhotonNetwork.PhotonServerSettings.AppID, MHMPNKGMNMJ);
		CloudRegionCode cloudRegionCode = PhotonHandler.IFAEAEOAJDL;
		if (cloudRegionCode != CloudRegionCode.none)
		{
			UnityEngine.Debug.Log("Best region found in PlayerPrefs. Connecting to: " + cloudRegionCode);
			return PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(cloudRegionCode);
		}
		return PhotonNetwork.JNJJAMNLOHA.ConnectToNameServer();
	}

	// Token: 0x0600B390 RID: 45968 RVA: 0x0041C828 File Offset: 0x0041AA28
	public static bool ConnectToRegion(CloudRegionCode LPCNAHJGAFK, string MHMPNKGMNMJ)
	{
		if (PhotonNetwork.JNJJAMNLOHA.PeerState != PeerStateValue.Disconnected)
		{
			UnityEngine.Debug.LogWarning("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: " + PhotonNetwork.JNJJAMNLOHA.PeerState);
			return false;
		}
		if (PhotonNetwork.PhotonServerSettings == null)
		{
			UnityEngine.Debug.LogError("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
			return false;
		}
		if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode)
		{
			return PhotonNetwork.ConnectUsingSettings(MHMPNKGMNMJ);
		}
		PhotonNetwork.JNJJAMNLOHA.IsInitialConnect = true;
		PhotonNetwork.JNJJAMNLOHA.SetApp(PhotonNetwork.PhotonServerSettings.AppID, MHMPNKGMNMJ);
		if (LPCNAHJGAFK != CloudRegionCode.none)
		{
			UnityEngine.Debug.Log("ConnectToRegion: " + LPCNAHJGAFK);
			return PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(LPCNAHJGAFK);
		}
		return false;
	}

	// Token: 0x0600B391 RID: 45969 RVA: 0x0041C8E0 File Offset: 0x0041AAE0
	public static void OverrideBestCloudServer(CloudRegionCode LPCNAHJGAFK)
	{
		PhotonHandler.IFAEAEOAJDL = LPCNAHJGAFK;
	}

	// Token: 0x0600B392 RID: 45970 RVA: 0x0041C8E8 File Offset: 0x0041AAE8
	public static void RefreshCloudServerRating()
	{
		throw new NotImplementedException("not available at the moment");
	}

	// Token: 0x0600B393 RID: 45971 RVA: 0x0041C8F4 File Offset: 0x0041AAF4
	public static void NetworkStatisticsReset()
	{
		PhotonNetwork.JNJJAMNLOHA.TrafficStatsReset();
	}

	// Token: 0x0600B394 RID: 45972 RVA: 0x0041C900 File Offset: 0x0041AB00
	public static string NetworkStatisticsToString()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.offlineMode)
		{
			return "Offline or in OfflineMode. No VitalStats available.";
		}
		return PhotonNetwork.JNJJAMNLOHA.VitalStatsToString(false);
	}

	// Token: 0x0600B395 RID: 45973 RVA: 0x0002523B File Offset: 0x0002343B
	[Obsolete("Used for compatibility with Unity networking only. Encryption is automatically initialized while connecting.")]
	public static void InitializeSecurity()
	{
	}

	// Token: 0x0600B396 RID: 45974 RVA: 0x0041C927 File Offset: 0x0041AB27
	private static bool OEOOJCDIDEM()
	{
		if (PhotonNetwork.connected)
		{
			return true;
		}
		UnityEngine.Debug.LogError("Cannot send messages when not connected. Either connect to Photon OR use offline mode!");
		return false;
	}

	// Token: 0x0600B397 RID: 45975 RVA: 0x0041C940 File Offset: 0x0041AB40
	public static void Disconnect()
	{
		if (PhotonNetwork.offlineMode)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.DNGILIFEKBM = null;
			PhotonNetwork.JNJJAMNLOHA.State = ClientState.Disconnecting;
			PhotonNetwork.JNJJAMNLOHA.OnStatusChanged(StatusCode.Disconnect);
			return;
		}
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.Disconnect();
	}

	// Token: 0x0600B398 RID: 45976 RVA: 0x0041C994 File Offset: 0x0041AB94
	public static bool FindFriends(string[] MIMEHFLKIIG)
	{
		return PhotonNetwork.JNJJAMNLOHA != null && !PhotonNetwork.DKPLFGHOICJ && PhotonNetwork.JNJJAMNLOHA.OpFindFriends(MIMEHFLKIIG);
	}

	// Token: 0x0600B399 RID: 45977 RVA: 0x0041C9B7 File Offset: 0x0041ABB7
	public static bool CreateRoom(string IOJPMCOBHEJ)
	{
		return PhotonNetwork.CreateRoom(IOJPMCOBHEJ, null, null, null);
	}

	// Token: 0x0600B39A RID: 45978 RVA: 0x0041C9C2 File Offset: 0x0041ABC2
	public static bool CreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB)
	{
		return PhotonNetwork.CreateRoom(IOJPMCOBHEJ, DPODHCMGCPF, LEPNBLFEINB, null);
	}

	// Token: 0x0600B39B RID: 45979 RVA: 0x0041C9D0 File Offset: 0x0041ABD0
	public static bool CreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB, string[] MMIMLMLKCBA)
	{
		if (PhotonNetwork.offlineMode)
		{
			if (PhotonNetwork.DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("CreateRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			PhotonNetwork.KFDFMLDBHFM(IOJPMCOBHEJ, DPODHCMGCPF, true);
			return true;
		}
		else
		{
			if (PhotonNetwork.JNJJAMNLOHA.EHALCLFLGJF != ServerConnection.MasterServer || !PhotonNetwork.connectedAndReady)
			{
				UnityEngine.Debug.LogError("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
				return false;
			}
			LEPNBLFEINB = (LEPNBLFEINB ?? ((!PhotonNetwork.JNJJAMNLOHA.insideLobby) ? null : PhotonNetwork.JNJJAMNLOHA.lobby));
			AKBOPCNHFFJ akbopcnhffj = new AKBOPCNHFFJ();
			akbopcnhffj.RoomName = IOJPMCOBHEJ;
			akbopcnhffj.RoomOptions = DPODHCMGCPF;
			akbopcnhffj.Lobby = LEPNBLFEINB;
			akbopcnhffj.ExpectedUsers = MMIMLMLKCBA;
			return PhotonNetwork.JNJJAMNLOHA.OpCreateGame(akbopcnhffj);
		}
	}

	// Token: 0x0600B39C RID: 45980 RVA: 0x0041CA82 File Offset: 0x0041AC82
	public static bool JoinRoom(string IOJPMCOBHEJ)
	{
		return PhotonNetwork.JoinRoom(IOJPMCOBHEJ, null);
	}

	// Token: 0x0600B39D RID: 45981 RVA: 0x0041CA8C File Offset: 0x0041AC8C
	public static bool JoinRoom(string IOJPMCOBHEJ, string[] MMIMLMLKCBA)
	{
		if (PhotonNetwork.offlineMode)
		{
			if (PhotonNetwork.DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("JoinRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			PhotonNetwork.KFDFMLDBHFM(IOJPMCOBHEJ, null, true);
			return true;
		}
		else
		{
			if (PhotonNetwork.JNJJAMNLOHA.EHALCLFLGJF != ServerConnection.MasterServer || !PhotonNetwork.connectedAndReady)
			{
				UnityEngine.Debug.LogError("JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
				return false;
			}
			if (string.IsNullOrEmpty(IOJPMCOBHEJ))
			{
				UnityEngine.Debug.LogError("JoinRoom failed. A roomname is required. If you don't know one, how will you join?");
				return false;
			}
			AKBOPCNHFFJ akbopcnhffj = new AKBOPCNHFFJ();
			akbopcnhffj.RoomName = IOJPMCOBHEJ;
			akbopcnhffj.ExpectedUsers = MMIMLMLKCBA;
			return PhotonNetwork.JNJJAMNLOHA.OpJoinRoom(akbopcnhffj);
		}
	}

	// Token: 0x0600B39E RID: 45982 RVA: 0x0041CB1E File Offset: 0x0041AD1E
	public static bool JoinOrCreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB)
	{
		return PhotonNetwork.JoinOrCreateRoom(IOJPMCOBHEJ, DPODHCMGCPF, LEPNBLFEINB, null);
	}

	// Token: 0x0600B39F RID: 45983 RVA: 0x0041CB2C File Offset: 0x0041AD2C
	public static bool JoinOrCreateRoom(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, TypedLobby LEPNBLFEINB, string[] MMIMLMLKCBA)
	{
		if (PhotonNetwork.offlineMode)
		{
			if (PhotonNetwork.DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			PhotonNetwork.KFDFMLDBHFM(IOJPMCOBHEJ, DPODHCMGCPF, true);
			return true;
		}
		else
		{
			if (PhotonNetwork.JNJJAMNLOHA.EHALCLFLGJF != ServerConnection.MasterServer || !PhotonNetwork.connectedAndReady)
			{
				UnityEngine.Debug.LogError("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
				return false;
			}
			if (string.IsNullOrEmpty(IOJPMCOBHEJ))
			{
				UnityEngine.Debug.LogError("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?");
				return false;
			}
			LEPNBLFEINB = (LEPNBLFEINB ?? ((!PhotonNetwork.JNJJAMNLOHA.insideLobby) ? null : PhotonNetwork.JNJJAMNLOHA.lobby));
			AKBOPCNHFFJ akbopcnhffj = new AKBOPCNHFFJ();
			akbopcnhffj.RoomName = IOJPMCOBHEJ;
			akbopcnhffj.RoomOptions = DPODHCMGCPF;
			akbopcnhffj.Lobby = LEPNBLFEINB;
			akbopcnhffj.CreateIfNotExists = true;
			akbopcnhffj.PlayerProperties = PhotonNetwork.player.CustomProperties;
			akbopcnhffj.ExpectedUsers = MMIMLMLKCBA;
			return PhotonNetwork.JNJJAMNLOHA.OpJoinRoom(akbopcnhffj);
		}
	}

	// Token: 0x0600B3A0 RID: 45984 RVA: 0x0041CC0C File Offset: 0x0041AE0C
	public static bool JoinRandomRoom()
	{
		return PhotonNetwork.JoinRandomRoom(null, 0, MatchmakingMode.FillRoom, null, null, null);
	}

	// Token: 0x0600B3A1 RID: 45985 RVA: 0x0041CC19 File Offset: 0x0041AE19
	public static bool JoinRandomRoom(Hashtable PDDOKBHKDAL, byte HJHMPEIKPKJ)
	{
		return PhotonNetwork.JoinRandomRoom(PDDOKBHKDAL, HJHMPEIKPKJ, MatchmakingMode.FillRoom, null, null, null);
	}

	// Token: 0x0600B3A2 RID: 45986 RVA: 0x0041CC28 File Offset: 0x0041AE28
	public static bool JoinRandomRoom(Hashtable PDDOKBHKDAL, byte HJHMPEIKPKJ, MatchmakingMode MBFAHJGIFBG, TypedLobby LEPNBLFEINB, string NNJFKLBJCJP, string[] MMIMLMLKCBA = null)
	{
		if (PhotonNetwork.offlineMode)
		{
			if (PhotonNetwork.DNGILIFEKBM != null)
			{
				UnityEngine.Debug.LogError("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.");
				return false;
			}
			PhotonNetwork.KFDFMLDBHFM("offline room", null, true);
			return true;
		}
		else
		{
			if (PhotonNetwork.JNJJAMNLOHA.EHALCLFLGJF != ServerConnection.MasterServer || !PhotonNetwork.connectedAndReady)
			{
				UnityEngine.Debug.LogError("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
				return false;
			}
			LEPNBLFEINB = (LEPNBLFEINB ?? ((!PhotonNetwork.JNJJAMNLOHA.insideLobby) ? null : PhotonNetwork.JNJJAMNLOHA.lobby));
			OpJoinRandomRoomParams opJoinRandomRoomParams = new OpJoinRandomRoomParams();
			opJoinRandomRoomParams.ExpectedCustomRoomProperties = PDDOKBHKDAL;
			opJoinRandomRoomParams.ExpectedMaxPlayers = HJHMPEIKPKJ;
			opJoinRandomRoomParams.MatchingType = MBFAHJGIFBG;
			opJoinRandomRoomParams.TypedLobby = LEPNBLFEINB;
			opJoinRandomRoomParams.SqlLobbyFilter = NNJFKLBJCJP;
			opJoinRandomRoomParams.ExpectedUsers = MMIMLMLKCBA;
			return PhotonNetwork.JNJJAMNLOHA.OpJoinRandomRoom(opJoinRandomRoomParams);
		}
	}

	// Token: 0x0600B3A3 RID: 45987 RVA: 0x0041CCF0 File Offset: 0x0041AEF0
	public static bool ReJoinRoom(string IOJPMCOBHEJ)
	{
		if (PhotonNetwork.offlineMode)
		{
			UnityEngine.Debug.LogError("ReJoinRoom failed due to offline mode.");
			return false;
		}
		if (PhotonNetwork.JNJJAMNLOHA.EHALCLFLGJF != ServerConnection.MasterServer || !PhotonNetwork.connectedAndReady)
		{
			UnityEngine.Debug.LogError("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
			return false;
		}
		if (string.IsNullOrEmpty(IOJPMCOBHEJ))
		{
			UnityEngine.Debug.LogError("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?");
			return false;
		}
		AKBOPCNHFFJ akbopcnhffj = new AKBOPCNHFFJ();
		akbopcnhffj.RoomName = IOJPMCOBHEJ;
		akbopcnhffj.RejoinOnly = true;
		akbopcnhffj.PlayerProperties = PhotonNetwork.player.CustomProperties;
		return PhotonNetwork.JNJJAMNLOHA.OpJoinRoom(akbopcnhffj);
	}

	// Token: 0x0600B3A4 RID: 45988 RVA: 0x0041CD80 File Offset: 0x0041AF80
	private static void KFDFMLDBHFM(string IOJPMCOBHEJ, RoomOptions DPODHCMGCPF, bool IJFFNPDGBGO)
	{
		PhotonNetwork.DNGILIFEKBM = new Room(IOJPMCOBHEJ, DPODHCMGCPF);
		PhotonNetwork.JNJJAMNLOHA.ChangeLocalID(1);
		PhotonNetwork.DNGILIFEKBM.EJLAPIIGIMI = 1;
		if (IJFFNPDGBGO)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom, new object[0]);
		}
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom, new object[0]);
	}

	// Token: 0x0600B3A5 RID: 45989 RVA: 0x0041CDCE File Offset: 0x0041AFCE
	public static bool JoinLobby()
	{
		return PhotonNetwork.JoinLobby(null);
	}

	// Token: 0x0600B3A6 RID: 45990 RVA: 0x0041CDD8 File Offset: 0x0041AFD8
	public static bool JoinLobby(TypedLobby LEPNBLFEINB)
	{
		if (PhotonNetwork.connected && PhotonNetwork.Server == ServerConnection.MasterServer)
		{
			if (LEPNBLFEINB == null)
			{
				LEPNBLFEINB = TypedLobby.Default;
			}
			bool flag = PhotonNetwork.JNJJAMNLOHA.OpJoinLobby(LEPNBLFEINB);
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.lobby = LEPNBLFEINB;
			}
			return flag;
		}
		return false;
	}

	// Token: 0x0600B3A7 RID: 45991 RVA: 0x0041CE26 File Offset: 0x0041B026
	public static bool LeaveLobby()
	{
		return PhotonNetwork.connected && PhotonNetwork.Server == ServerConnection.MasterServer && PhotonNetwork.JNJJAMNLOHA.OpLeaveLobby();
	}

	// Token: 0x0600B3A8 RID: 45992 RVA: 0x0041CE48 File Offset: 0x0041B048
	public static bool LeaveRoom()
	{
		if (PhotonNetwork.offlineMode)
		{
			PhotonNetwork.DNGILIFEKBM = null;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom, new object[0]);
			return true;
		}
		if (PhotonNetwork.room == null)
		{
			UnityEngine.Debug.LogWarning("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: " + PhotonNetwork.connectionStateDetailed);
		}
		return PhotonNetwork.JNJJAMNLOHA.OpLeave();
	}

	// Token: 0x0600B3A9 RID: 45993 RVA: 0x0041CEA5 File Offset: 0x0041B0A5
	public static bool GetCustomRoomList(TypedLobby LEPNBLFEINB, string NNJFKLBJCJP)
	{
		return PhotonNetwork.JNJJAMNLOHA.OpGetGameList(LEPNBLFEINB, NNJFKLBJCJP);
	}

	// Token: 0x0600B3AA RID: 45994 RVA: 0x0041CEB3 File Offset: 0x0041B0B3
	public static RoomInfo[] GetRoomList()
	{
		if (PhotonNetwork.offlineMode || PhotonNetwork.JNJJAMNLOHA == null)
		{
			return new RoomInfo[0];
		}
		return PhotonNetwork.JNJJAMNLOHA.mGameListCopy;
	}

	// Token: 0x0600B3AB RID: 45995 RVA: 0x0041CEDC File Offset: 0x0041B0DC
	public static void SetPlayerCustomProperties(Hashtable MADHFAPNGKO)
	{
		if (MADHFAPNGKO == null)
		{
			MADHFAPNGKO = new Hashtable();
			foreach (object obj in PhotonNetwork.player.CustomProperties.Keys)
			{
				MADHFAPNGKO[(string)obj] = null;
			}
		}
		if (PhotonNetwork.room != null && PhotonNetwork.room.IsLocalClientInside)
		{
			PhotonNetwork.player.SetCustomProperties(MADHFAPNGKO, null, false);
		}
		else
		{
			PhotonNetwork.player.NPOPPIMCDMN(MADHFAPNGKO);
		}
	}

	// Token: 0x0600B3AC RID: 45996 RVA: 0x0041CF8C File Offset: 0x0041B18C
	public static void RemovePlayerCustomProperties(string[] IHEPFEODDEM)
	{
		if (IHEPFEODDEM == null || IHEPFEODDEM.Length == 0 || PhotonNetwork.player.CustomProperties == null)
		{
			PhotonNetwork.player.CustomProperties = new Hashtable();
			return;
		}
		foreach (string key in IHEPFEODDEM)
		{
			if (PhotonNetwork.player.CustomProperties.ContainsKey(key))
			{
				PhotonNetwork.player.CustomProperties.Remove(key);
			}
		}
	}

	// Token: 0x0600B3AD RID: 45997 RVA: 0x0041D004 File Offset: 0x0041B204
	public static bool RaiseEvent(byte IMCBEMICJFC, object PLEDNEPCFIC, bool ANMGHMBBMAO, RaiseEventOptions PCFOAMAODBD)
	{
		if (!PhotonNetwork.inRoom || IMCBEMICJFC >= 200)
		{
			UnityEngine.Debug.LogWarning("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).");
			return false;
		}
		return PhotonNetwork.JNJJAMNLOHA.OpRaiseEvent(IMCBEMICJFC, PLEDNEPCFIC, ANMGHMBBMAO, PCFOAMAODBD);
	}

	// Token: 0x0600B3AE RID: 45998 RVA: 0x0041D038 File Offset: 0x0041B238
	public static int AllocateViewID()
	{
		int num = PhotonNetwork.JDMOJHLFDLL(PhotonNetwork.player.ID);
		PhotonNetwork.JMCPHFPJEJC.Add(num);
		return num;
	}

	// Token: 0x0600B3AF RID: 45999 RVA: 0x0041D064 File Offset: 0x0041B264
	public static int AllocateSceneViewID()
	{
		if (!PhotonNetwork.isMasterClient)
		{
			UnityEngine.Debug.LogError("Only the Master Client can AllocateSceneViewID(). Check PhotonNetwork.isMasterClient!");
			return -1;
		}
		int num = PhotonNetwork.JDMOJHLFDLL(0);
		PhotonNetwork.JMCPHFPJEJC.Add(num);
		return num;
	}

	// Token: 0x0600B3B0 RID: 46000 RVA: 0x0041D09C File Offset: 0x0041B29C
	private static int JDMOJHLFDLL(int GOGMHIJOKBA)
	{
		if (GOGMHIJOKBA == 0)
		{
			int num = PhotonNetwork.JIOIILCHMJL;
			int num2 = GOGMHIJOKBA * PhotonNetwork.MAX_VIEW_IDS;
			for (int i = 1; i < PhotonNetwork.MAX_VIEW_IDS; i++)
			{
				num = (num + 1) % PhotonNetwork.MAX_VIEW_IDS;
				if (num != 0)
				{
					int num3 = num + num2;
					if (!PhotonNetwork.JNJJAMNLOHA.HFCMPEKPBAM.ContainsKey(num3))
					{
						PhotonNetwork.JIOIILCHMJL = num;
						return num3;
					}
				}
			}
			throw new Exception(string.Format("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", GOGMHIJOKBA));
		}
		int num4 = PhotonNetwork.FDMEIPEKMHC;
		int num5 = GOGMHIJOKBA * PhotonNetwork.MAX_VIEW_IDS;
		for (int j = 1; j < PhotonNetwork.MAX_VIEW_IDS; j++)
		{
			num4 = (num4 + 1) % PhotonNetwork.MAX_VIEW_IDS;
			if (num4 != 0)
			{
				int num6 = num4 + num5;
				if (!PhotonNetwork.JNJJAMNLOHA.HFCMPEKPBAM.ContainsKey(num6) && !PhotonNetwork.JMCPHFPJEJC.Contains(num6))
				{
					PhotonNetwork.FDMEIPEKMHC = num4;
					return num6;
				}
			}
		}
		throw new Exception(string.Format("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", GOGMHIJOKBA));
	}

	// Token: 0x0600B3B1 RID: 46001 RVA: 0x0041D1B0 File Offset: 0x0041B3B0
	private static int[] FHEJPNKOIJM(int NLMNICONLMF)
	{
		int[] array = new int[NLMNICONLMF];
		for (int i = 0; i < NLMNICONLMF; i++)
		{
			array[i] = PhotonNetwork.JDMOJHLFDLL(0);
		}
		return array;
	}

	// Token: 0x0600B3B2 RID: 46002 RVA: 0x0041D1E0 File Offset: 0x0041B3E0
	public static void UnAllocateViewID(int NADLIACHBNO)
	{
		PhotonNetwork.JMCPHFPJEJC.Remove(NADLIACHBNO);
		if (PhotonNetwork.JNJJAMNLOHA.HFCMPEKPBAM.ContainsKey(NADLIACHBNO))
		{
			UnityEngine.Debug.LogWarning(string.Format("UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", NADLIACHBNO, PhotonNetwork.JNJJAMNLOHA.HFCMPEKPBAM[NADLIACHBNO]));
		}
	}

	// Token: 0x0600B3B3 RID: 46003 RVA: 0x0041D233 File Offset: 0x0041B433
	public static GameObject Instantiate(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC)
	{
		return PhotonNetwork.Instantiate(PPFBFGBJOHM, JOPCODOJBHD, LOMLCCLOIKN, PNFBEEBFMKC, null);
	}

	// Token: 0x0600B3B4 RID: 46004 RVA: 0x0041D240 File Offset: 0x0041B440
	public static GameObject Instantiate(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, object[] NOJGGCLPPAM)
	{
		if (!PhotonNetwork.connected || (PhotonNetwork.InstantiateInRoomOnly && !PhotonNetwork.inRoom))
		{
			UnityEngine.Debug.LogError(string.Concat(new object[]
			{
				"Failed to Instantiate prefab: ",
				PPFBFGBJOHM,
				". Client should be in a room. Current connectionStateDetailed: ",
				PhotonNetwork.connectionStateDetailed
			}));
			return null;
		}
		GameObject gameObject;
		if (!PhotonNetwork.UsePrefabCache || !PhotonNetwork.PrefabCache.TryGetValue(PPFBFGBJOHM, out gameObject))
		{
			gameObject = (GameObject)Resources.Load(PPFBFGBJOHM, typeof(GameObject));
			if (PhotonNetwork.UsePrefabCache)
			{
				PhotonNetwork.PrefabCache.Add(PPFBFGBJOHM, gameObject);
			}
		}
		if (gameObject == null)
		{
			UnityEngine.Debug.LogError("Failed to Instantiate prefab: " + PPFBFGBJOHM + ". Verify the Prefab is in a Resources folder (and not in a subfolder)");
			return null;
		}
		if (gameObject.GetComponent<PhotonView>() == null)
		{
			UnityEngine.Debug.LogError("Failed to Instantiate prefab:" + PPFBFGBJOHM + ". Prefab must have a PhotonView component.");
			return null;
		}
		Component[] photonViewsInChildren = gameObject.GetPhotonViewsInChildren();
		int[] array = new int[photonViewsInChildren.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = PhotonNetwork.JDMOJHLFDLL(PhotonNetwork.player.ID);
		}
		Hashtable nnnjpmdhphh = PhotonNetwork.JNJJAMNLOHA.JBBJFFKDHNO(PPFBFGBJOHM, JOPCODOJBHD, LOMLCCLOIKN, PNFBEEBFMKC, array, NOJGGCLPPAM, false);
		return PhotonNetwork.JNJJAMNLOHA.JFOLGKKLFJP(nnnjpmdhphh, PhotonNetwork.JNJJAMNLOHA.LocalPlayer, gameObject);
	}

	// Token: 0x0600B3B5 RID: 46005 RVA: 0x0041D394 File Offset: 0x0041B594
	public static GameObject InstantiateSceneObject(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, object[] NOJGGCLPPAM)
	{
		if (!PhotonNetwork.connected || (PhotonNetwork.InstantiateInRoomOnly && !PhotonNetwork.inRoom))
		{
			UnityEngine.Debug.LogError(string.Concat(new object[]
			{
				"Failed to InstantiateSceneObject prefab: ",
				PPFBFGBJOHM,
				". Client should be in a room. Current connectionStateDetailed: ",
				PhotonNetwork.connectionStateDetailed
			}));
			return null;
		}
		if (!PhotonNetwork.isMasterClient)
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab: " + PPFBFGBJOHM + ". Client is not the MasterClient in this room.");
			return null;
		}
		GameObject gameObject;
		if (!PhotonNetwork.UsePrefabCache || !PhotonNetwork.PrefabCache.TryGetValue(PPFBFGBJOHM, out gameObject))
		{
			gameObject = (GameObject)Resources.Load(PPFBFGBJOHM, typeof(GameObject));
			if (PhotonNetwork.UsePrefabCache)
			{
				PhotonNetwork.PrefabCache.Add(PPFBFGBJOHM, gameObject);
			}
		}
		if (gameObject == null)
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab: " + PPFBFGBJOHM + ". Verify the Prefab is in a Resources folder (and not in a subfolder)");
			return null;
		}
		if (gameObject.GetComponent<PhotonView>() == null)
		{
			UnityEngine.Debug.LogError("Failed to InstantiateSceneObject prefab:" + PPFBFGBJOHM + ". Prefab must have a PhotonView component.");
			return null;
		}
		Component[] photonViewsInChildren = gameObject.GetPhotonViewsInChildren();
		int[] array = PhotonNetwork.FHEJPNKOIJM(photonViewsInChildren.Length);
		if (array == null)
		{
			UnityEngine.Debug.LogError(string.Concat(new object[]
			{
				"Failed to InstantiateSceneObject prefab: ",
				PPFBFGBJOHM,
				". No ViewIDs are free to use. Max is: ",
				PhotonNetwork.MAX_VIEW_IDS
			}));
			return null;
		}
		Hashtable nnnjpmdhphh = PhotonNetwork.JNJJAMNLOHA.JBBJFFKDHNO(PPFBFGBJOHM, JOPCODOJBHD, LOMLCCLOIKN, PNFBEEBFMKC, array, NOJGGCLPPAM, true);
		return PhotonNetwork.JNJJAMNLOHA.JFOLGKKLFJP(nnnjpmdhphh, PhotonNetwork.JNJJAMNLOHA.LocalPlayer, gameObject);
	}

	// Token: 0x0600B3B6 RID: 46006 RVA: 0x0041D518 File Offset: 0x0041B718
	public static int GetPing()
	{
		return PhotonNetwork.JNJJAMNLOHA.RoundTripTime;
	}

	// Token: 0x0600B3B7 RID: 46007 RVA: 0x0041D524 File Offset: 0x0041B724
	public static void FetchServerTimestamp()
	{
		if (PhotonNetwork.JNJJAMNLOHA != null)
		{
			PhotonNetwork.JNJJAMNLOHA.FetchServerTimestamp();
		}
	}

	// Token: 0x0600B3B8 RID: 46008 RVA: 0x0041D53A File Offset: 0x0041B73A
	public static void SendOutgoingCommands()
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		while (PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands())
		{
		}
	}

	// Token: 0x0600B3B9 RID: 46009 RVA: 0x0041D55C File Offset: 0x0041B75C
	public static bool CloseConnection(PhotonPlayer HNKDBLECLJD)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return false;
		}
		if (!PhotonNetwork.player.IsMasterClient)
		{
			UnityEngine.Debug.LogError("CloseConnection: Only the masterclient can kick another player.");
			return false;
		}
		if (HNKDBLECLJD == null)
		{
			UnityEngine.Debug.LogError("CloseConnection: No such player connected!");
			return false;
		}
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			TargetActors = new int[]
			{
				HNKDBLECLJD.ID
			}
		};
		return PhotonNetwork.JNJJAMNLOHA.OpRaiseEvent(203, null, true, bplhapbmggc);
	}

	// Token: 0x0600B3BA RID: 46010 RVA: 0x0041D5D4 File Offset: 0x0041B7D4
	public static bool SetMasterClient(PhotonPlayer KOPLIPHDDKI)
	{
		if (!PhotonNetwork.inRoom || !PhotonNetwork.OEOOJCDIDEM() || PhotonNetwork.offlineMode)
		{
			if (PhotonNetwork.logLevel == PhotonLogLevel.Informational)
			{
				UnityEngine.Debug.Log("Can not SetMasterClient(). Not in room or in offlineMode.");
			}
			return false;
		}
		if (PhotonNetwork.room.BDHOOLIDFJO)
		{
			Hashtable mjjmnidhdec = new Hashtable
			{
				{
					248,
					KOPLIPHDDKI.ID
				}
			};
			Hashtable kcjikjdcoal = new Hashtable
			{
				{
					248,
					PhotonNetwork.JNJJAMNLOHA.mMasterClientId
				}
			};
			return PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(mjjmnidhdec, kcjikjdcoal, false);
		}
		return PhotonNetwork.isMasterClient && PhotonNetwork.JNJJAMNLOHA.LGPBHHOJPCA(KOPLIPHDDKI.ID, true);
	}

	// Token: 0x0600B3BB RID: 46011 RVA: 0x0041D69A File Offset: 0x0041B89A
	public static void Destroy(PhotonView NCLLMPGMEGK)
	{
		if (NCLLMPGMEGK != null)
		{
			PhotonNetwork.JNJJAMNLOHA.EFDAOHIDIIF(NCLLMPGMEGK.gameObject, !PhotonNetwork.inRoom);
		}
		else
		{
			UnityEngine.Debug.LogError("Destroy(targetPhotonView) failed, cause targetPhotonView is null.");
		}
	}

	// Token: 0x0600B3BC RID: 46012 RVA: 0x0041D6CF File Offset: 0x0041B8CF
	public static void Destroy(GameObject LLLMPOLKHLI)
	{
		PhotonNetwork.JNJJAMNLOHA.EFDAOHIDIIF(LLLMPOLKHLI, !PhotonNetwork.inRoom);
	}

	// Token: 0x0600B3BD RID: 46013 RVA: 0x0041D6E4 File Offset: 0x0041B8E4
	public static void DestroyPlayerObjects(PhotonPlayer MJCDIJOAEPI)
	{
		if (PhotonNetwork.player == null)
		{
			UnityEngine.Debug.LogError("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.");
		}
		PhotonNetwork.DestroyPlayerObjects(MJCDIJOAEPI.ID);
	}

	// Token: 0x0600B3BE RID: 46014 RVA: 0x0041D708 File Offset: 0x0041B908
	public static void DestroyPlayerObjects(int BJAGFDGPDGB)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		if (PhotonNetwork.player.IsMasterClient || BJAGFDGPDGB == PhotonNetwork.player.ID)
		{
			PhotonNetwork.JNJJAMNLOHA.DestroyPlayerObjects(BJAGFDGPDGB, false);
		}
		else
		{
			UnityEngine.Debug.LogError("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: " + PhotonNetwork.isMasterClient);
		}
	}

	// Token: 0x0600B3BF RID: 46015 RVA: 0x0041D769 File Offset: 0x0041B969
	public static void DestroyAll()
	{
		if (PhotonNetwork.isMasterClient)
		{
			PhotonNetwork.JNJJAMNLOHA.DestroyAll(false);
		}
		else
		{
			UnityEngine.Debug.LogError("Couldn't call DestroyAll() as only the master client is allowed to call this.");
		}
	}

	// Token: 0x0600B3C0 RID: 46016 RVA: 0x0041D78F File Offset: 0x0041B98F
	public static void RemoveRPCs(PhotonPlayer MJCDIJOAEPI)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		if (!MJCDIJOAEPI.IsLocal && !PhotonNetwork.isMasterClient)
		{
			UnityEngine.Debug.LogError("Error; Only the MasterClient can call RemoveRPCs for other players.");
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.OpCleanRpcBuffer(MJCDIJOAEPI.ID);
	}

	// Token: 0x0600B3C1 RID: 46017 RVA: 0x0041D7CC File Offset: 0x0041B9CC
	public static void RemoveRPCs(PhotonView JFOAMHPNFIL)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.CleanRpcBufferIfMine(JFOAMHPNFIL);
	}

	// Token: 0x0600B3C2 RID: 46018 RVA: 0x0041D7E4 File Offset: 0x0041B9E4
	public static void RemoveRPCsInGroup(int FJFIKHHEGKC)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.RemoveRPCsInGroup(FJFIKHHEGKC);
	}

	// Token: 0x0600B3C3 RID: 46019 RVA: 0x0041D7FC File Offset: 0x0041B9FC
	internal static void HFFGNHGFKPE(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		if (PhotonNetwork.room == null)
		{
			UnityEngine.Debug.LogWarning("RPCs can only be sent in rooms. Call of \"" + LBLKDNNPACO + "\" gets executed locally only, if at all.");
			return;
		}
		if (PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonNetwork.room.BDHOOLIDFJO)
			{
				PhotonNetwork.JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, MPNMOONBMII, null, AKFHJNFOCDP, GNNEKCBOBEG);
			}
			else if (PhotonNetwork.JNJJAMNLOHA.hasSwitchedMC && MPNMOONBMII == PhotonTargets.MasterClient)
			{
				PhotonNetwork.JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, PhotonTargets.Others, PhotonNetwork.masterClient, AKFHJNFOCDP, GNNEKCBOBEG);
			}
			else
			{
				PhotonNetwork.JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, MPNMOONBMII, null, AKFHJNFOCDP, GNNEKCBOBEG);
			}
		}
		else
		{
			UnityEngine.Debug.LogWarning("Could not execute RPC " + LBLKDNNPACO + ". Possible scene loading in progress?");
		}
	}

	// Token: 0x0600B3C4 RID: 46020 RVA: 0x0041D8C0 File Offset: 0x0041BAC0
	internal static void HFFGNHGFKPE(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool CHFCLAACMEP, params object[] GNNEKCBOBEG)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		if (PhotonNetwork.room == null)
		{
			UnityEngine.Debug.LogWarning("RPCs can only be sent in rooms. Call of \"" + LBLKDNNPACO + "\" gets executed locally only, if at all.");
			return;
		}
		if (PhotonNetwork.player == null)
		{
			UnityEngine.Debug.LogError("RPC can't be sent to target PhotonPlayer being null! Did not send \"" + LBLKDNNPACO + "\" call.");
		}
		if (PhotonNetwork.JNJJAMNLOHA != null)
		{
			PhotonNetwork.JNJJAMNLOHA.HFFGNHGFKPE(DFIHBOEOJPI, LBLKDNNPACO, PhotonTargets.Others, MJCDIJOAEPI, CHFCLAACMEP, GNNEKCBOBEG);
		}
		else
		{
			UnityEngine.Debug.LogWarning("Could not execute RPC " + LBLKDNNPACO + ". Possible scene loading in progress?");
		}
	}

	// Token: 0x0600B3C5 RID: 46021 RVA: 0x0041D94C File Offset: 0x0041BB4C
	public static void CacheSendMonoMessageTargets(Type HMGBJCGOLMI)
	{
		if (HMGBJCGOLMI == null)
		{
			HMGBJCGOLMI = PhotonNetwork.SendMonoMessageTargetType;
		}
		PhotonNetwork.SendMonoMessageTargets = PhotonNetwork.FindGameObjectsWithComponent(HMGBJCGOLMI);
	}

	// Token: 0x0600B3C6 RID: 46022 RVA: 0x0041D968 File Offset: 0x0041BB68
	public static HashSet<GameObject> FindGameObjectsWithComponent(Type HMGBJCGOLMI)
	{
		HashSet<GameObject> hashSet = new HashSet<GameObject>();
		Component[] array = (Component[])UnityEngine.Object.FindObjectsOfType(HMGBJCGOLMI);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				hashSet.Add(array[i].gameObject);
			}
		}
		return hashSet;
	}

	// Token: 0x0600B3C7 RID: 46023 RVA: 0x0041D9B9 File Offset: 0x0041BBB9
	[Obsolete("Use SetInterestGroups(byte group, bool enabled) instead.")]
	public static void SetReceivingEnabled(int PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		PhotonNetwork.SetInterestGroups((byte)PNFBEEBFMKC, CKALCHJAFBE);
	}

	// Token: 0x0600B3C8 RID: 46024 RVA: 0x0041D9D0 File Offset: 0x0041BBD0
	public static void SetInterestGroups(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		if (CKALCHJAFBE)
		{
			byte[] obkfhnachia = new byte[]
			{
				PNFBEEBFMKC
			};
			PhotonNetwork.JNJJAMNLOHA.SetInterestGroups(null, obkfhnachia);
		}
		else
		{
			byte[] jkoigflnncn = new byte[]
			{
				PNFBEEBFMKC
			};
			PhotonNetwork.JNJJAMNLOHA.SetInterestGroups(jkoigflnncn, null);
		}
	}

	// Token: 0x0600B3C9 RID: 46025 RVA: 0x0041DA24 File Offset: 0x0041BC24
	[Obsolete("Use SetInterestGroups(byte[] disableGroups, byte[] enableGroups) instead. Mind the parameter order!")]
	public static void SetReceivingEnabled(int[] OBKFHNACHIA, int[] JKOIGFLNNCN)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		byte[] array = null;
		byte[] array2 = null;
		if (OBKFHNACHIA != null)
		{
			array2 = new byte[OBKFHNACHIA.Length];
			Array.Copy(OBKFHNACHIA, array2, OBKFHNACHIA.Length);
		}
		if (JKOIGFLNNCN != null)
		{
			array = new byte[JKOIGFLNNCN.Length];
			Array.Copy(JKOIGFLNNCN, array, JKOIGFLNNCN.Length);
		}
		PhotonNetwork.JNJJAMNLOHA.SetInterestGroups(array, array2);
	}

	// Token: 0x0600B3CA RID: 46026 RVA: 0x0041DA7E File Offset: 0x0041BC7E
	public static void SetInterestGroups(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.SetInterestGroups(JKOIGFLNNCN, OBKFHNACHIA);
	}

	// Token: 0x0600B3CB RID: 46027 RVA: 0x0041DA97 File Offset: 0x0041BC97
	[Obsolete("Use SetSendingEnabled(byte group, bool enabled). Interest Groups have a byte-typed ID. Mind the parameter order.")]
	public static void SetSendingEnabled(int PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		PhotonNetwork.SetSendingEnabled((byte)PNFBEEBFMKC, CKALCHJAFBE);
	}

	// Token: 0x0600B3CC RID: 46028 RVA: 0x0041DAA1 File Offset: 0x0041BCA1
	public static void SetSendingEnabled(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.SetSendingEnabled(PNFBEEBFMKC, CKALCHJAFBE);
	}

	// Token: 0x0600B3CD RID: 46029 RVA: 0x0041DABC File Offset: 0x0041BCBC
	[Obsolete("Use SetSendingEnabled(byte group, bool enabled). Interest Groups have a byte-typed ID. Mind the parameter order.")]
	public static void SetSendingEnabled(int[] OBKFHNACHIA, int[] JKOIGFLNNCN)
	{
		byte[] array = null;
		byte[] array2 = null;
		if (OBKFHNACHIA != null)
		{
			array2 = new byte[OBKFHNACHIA.Length];
			Array.Copy(OBKFHNACHIA, array2, OBKFHNACHIA.Length);
		}
		if (JKOIGFLNNCN != null)
		{
			array = new byte[JKOIGFLNNCN.Length];
			Array.Copy(JKOIGFLNNCN, array, JKOIGFLNNCN.Length);
		}
		PhotonNetwork.SetSendingEnabled(array, array2);
	}

	// Token: 0x0600B3CE RID: 46030 RVA: 0x0041DB06 File Offset: 0x0041BD06
	public static void SetSendingEnabled(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.SetSendingEnabled(JKOIGFLNNCN, OBKFHNACHIA);
	}

	// Token: 0x0600B3CF RID: 46031 RVA: 0x0041DB1F File Offset: 0x0041BD1F
	public static void SetLevelPrefix(short MOALALKJCKJ)
	{
		if (!PhotonNetwork.OEOOJCDIDEM())
		{
			return;
		}
		PhotonNetwork.JNJJAMNLOHA.SetLevelPrefix(MOALALKJCKJ);
	}

	// Token: 0x0600B3D0 RID: 46032 RVA: 0x0041DB37 File Offset: 0x0041BD37
	public static void LoadLevel(int JAKFPPDJPAE)
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(JAKFPPDJPAE);
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.JNJJAMNLOHA.HMIEGLIHGEM = true;
		SceneManager.LoadScene(JAKFPPDJPAE);
	}

	// Token: 0x0600B3D1 RID: 46033 RVA: 0x0041DB60 File Offset: 0x0041BD60
	public static void LoadLevel(string CALNJJJGINH)
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(CALNJJJGINH);
		PhotonNetwork.isMessageQueueRunning = false;
		PhotonNetwork.JNJJAMNLOHA.HMIEGLIHGEM = true;
		SceneManager.LoadScene(CALNJJJGINH);
	}

	// Token: 0x0600B3D2 RID: 46034 RVA: 0x0041DB84 File Offset: 0x0041BD84
	public static bool WebRpc(string EBEHBBDKDFJ, object GNNEKCBOBEG)
	{
		return PhotonNetwork.JNJJAMNLOHA.WebRpc(EBEHBBDKDFJ, GNNEKCBOBEG);
	}

	// Token: 0x0600B3D3 RID: 46035 RVA: 0x0041DB92 File Offset: 0x0041BD92
	[CompilerGenerated]
	private static int DLFFNMKNFJA()
	{
		return (int)PhotonNetwork.DKNFDIMGLKG.ElapsedMilliseconds;
	}

	// Token: 0x040014FD RID: 5373
	public const string versionPUN = "1.87";

	// Token: 0x040014FF RID: 5375
	internal static readonly PhotonHandler IBABLIBBKAG;

	// Token: 0x04001500 RID: 5376
	internal static BNGIGHBHPEH JNJJAMNLOHA;

	// Token: 0x04001501 RID: 5377
	public static readonly int MAX_VIEW_IDS = 1000;

	// Token: 0x04001502 RID: 5378
	internal const string MJJENBIFDOH = "PhotonServerSettings";

	// Token: 0x04001503 RID: 5379
	public static ServerSettings PhotonServerSettings = (ServerSettings)Resources.Load("PhotonServerSettings", typeof(ServerSettings));

	// Token: 0x04001504 RID: 5380
	public static bool InstantiateInRoomOnly = true;

	// Token: 0x04001505 RID: 5381
	public static PhotonLogLevel logLevel = PhotonLogLevel.ErrorsOnly;

	// Token: 0x04001507 RID: 5383
	public static float precisionForVectorSynchronization = 9.9E-05f;

	// Token: 0x04001508 RID: 5384
	public static float precisionForQuaternionSynchronization = 1f;

	// Token: 0x04001509 RID: 5385
	public static float precisionForFloatSynchronization = 0.01f;

	// Token: 0x0400150A RID: 5386
	public static bool UseRpcMonoBehaviourCache;

	// Token: 0x0400150B RID: 5387
	public static bool UsePrefabCache = true;

	// Token: 0x0400150C RID: 5388
	public static Dictionary<string, GameObject> PrefabCache = new Dictionary<string, GameObject>();

	// Token: 0x0400150D RID: 5389
	public static HashSet<GameObject> SendMonoMessageTargets;

	// Token: 0x0400150E RID: 5390
	public static Type SendMonoMessageTargetType = typeof(MonoBehaviour);

	// Token: 0x0400150F RID: 5391
	public static bool StartRpcsAsCoroutine = true;

	// Token: 0x04001510 RID: 5392
	private static bool DKPLFGHOICJ = false;

	// Token: 0x04001511 RID: 5393
	private static Room DNGILIFEKBM = null;

	// Token: 0x04001512 RID: 5394
	[Obsolete("Used for compatibility with Unity networking only.")]
	public static int maxConnections;

	// Token: 0x04001513 RID: 5395
	private static bool KLLBMBCNMGO = false;

	// Token: 0x04001514 RID: 5396
	private static bool EBIOGPLPINH = true;

	// Token: 0x04001515 RID: 5397
	private static int BDPJPHDKAOM = 50;

	// Token: 0x04001516 RID: 5398
	private static int GMHJFCMGKCB = 100;

	// Token: 0x04001517 RID: 5399
	private static bool LGLLFPCCGBM = true;

	// Token: 0x04001518 RID: 5400
	private static bool JLDPEKGBJGO = false;

	// Token: 0x04001519 RID: 5401
	private static Stopwatch DKNFDIMGLKG;

	// Token: 0x0400151A RID: 5402
	public static float BackgroundTimeout = 60f;

	// Token: 0x0400151B RID: 5403
	public static PhotonNetwork.EventCallback OnEventCall;

	// Token: 0x0400151C RID: 5404
	internal static int FDMEIPEKMHC = 0;

	// Token: 0x0400151D RID: 5405
	internal static int JIOIILCHMJL = 0;

	// Token: 0x0400151E RID: 5406
	internal static List<int> JMCPHFPJEJC = new List<int>();

	// Token: 0x02000311 RID: 785
	// (Invoke) Token: 0x0600B3D5 RID: 46037
	public delegate void EventCallback(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP);
}
