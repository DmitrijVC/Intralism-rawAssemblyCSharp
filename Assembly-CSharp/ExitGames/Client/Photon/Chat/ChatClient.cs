using System;
using System.Collections.Generic;

namespace ExitGames.Client.Photon.Chat
{
	// Token: 0x0200036B RID: 875
	public class ChatClient : IPhotonPeerListener
	{
		// Token: 0x0600C2ED RID: 49901 RVA: 0x0046E3DC File Offset: 0x0046C5DC
		public ChatClient(IChatClientListener listener, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
			this.listener = listener;
			this.State = ChatState.Uninitialized;
			this.chatPeer = new ChatPeer(this, protocol);
			this.PublicChannels = new Dictionary<string, ChatChannel>();
			this.PrivateChannels = new Dictionary<string, ChatChannel>();
			this.PublicChannelsUnsubscribing = new HashSet<string>();
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600C2EE RID: 49902 RVA: 0x0046E43E File Offset: 0x0046C63E
		// (set) Token: 0x0600C2EF RID: 49903 RVA: 0x0046E446 File Offset: 0x0046C646
		public string NameServerAddress { get; private set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600C2F0 RID: 49904 RVA: 0x0046E44F File Offset: 0x0046C64F
		// (set) Token: 0x0600C2F1 RID: 49905 RVA: 0x0046E457 File Offset: 0x0046C657
		public string FrontendAddress { get; private set; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600C2F2 RID: 49906 RVA: 0x0046E460 File Offset: 0x0046C660
		// (set) Token: 0x0600C2F3 RID: 49907 RVA: 0x0046E468 File Offset: 0x0046C668
		public string ChatRegion
		{
			get
			{
				return this.chatRegion;
			}
			set
			{
				this.chatRegion = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600C2F4 RID: 49908 RVA: 0x0046E471 File Offset: 0x0046C671
		// (set) Token: 0x0600C2F5 RID: 49909 RVA: 0x0046E479 File Offset: 0x0046C679
		public ChatState State { get; private set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600C2F6 RID: 49910 RVA: 0x0046E482 File Offset: 0x0046C682
		// (set) Token: 0x0600C2F7 RID: 49911 RVA: 0x0046E48A File Offset: 0x0046C68A
		public ChatDisconnectCause DisconnectedCause { get; private set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600C2F8 RID: 49912 RVA: 0x0046E493 File Offset: 0x0046C693
		public bool CanChat
		{
			get
			{
				return this.State == ChatState.ConnectedToFrontEnd && this.HasPeer;
			}
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x0046E4AA File Offset: 0x0046C6AA
		public bool CanChatInChannel(string channelName)
		{
			return this.CanChat && this.PublicChannels.ContainsKey(channelName) && !this.PublicChannelsUnsubscribing.Contains(channelName);
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600C2FA RID: 49914 RVA: 0x0046E4DA File Offset: 0x0046C6DA
		private bool HasPeer
		{
			get
			{
				return this.chatPeer != null;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600C2FB RID: 49915 RVA: 0x0046E4E8 File Offset: 0x0046C6E8
		// (set) Token: 0x0600C2FC RID: 49916 RVA: 0x0046E4F0 File Offset: 0x0046C6F0
		public string AppVersion { get; private set; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600C2FD RID: 49917 RVA: 0x0046E4F9 File Offset: 0x0046C6F9
		// (set) Token: 0x0600C2FE RID: 49918 RVA: 0x0046E501 File Offset: 0x0046C701
		public string AppId { get; private set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600C2FF RID: 49919 RVA: 0x0046E50A File Offset: 0x0046C70A
		// (set) Token: 0x0600C300 RID: 49920 RVA: 0x0046E512 File Offset: 0x0046C712
		public AuthenticationValues AuthValues { get; set; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600C301 RID: 49921 RVA: 0x0046E51B File Offset: 0x0046C71B
		// (set) Token: 0x0600C302 RID: 49922 RVA: 0x0046E539 File Offset: 0x0046C739
		public string UserId
		{
			get
			{
				return (this.AuthValues == null) ? null : this.AuthValues.UserId;
			}
			private set
			{
				if (this.AuthValues == null)
				{
					this.AuthValues = new AuthenticationValues();
				}
				this.AuthValues.UserId = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600C303 RID: 49923 RVA: 0x0046E55D File Offset: 0x0046C75D
		// (set) Token: 0x0600C304 RID: 49924 RVA: 0x0046E565 File Offset: 0x0046C765
		public bool UseBackgroundWorkerForSending { get; set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600C305 RID: 49925 RVA: 0x0046E56E File Offset: 0x0046C76E
		// (set) Token: 0x0600C306 RID: 49926 RVA: 0x0046E57C File Offset: 0x0046C77C
		public ConnectionProtocol TransportProtocol
		{
			get
			{
				return this.chatPeer.TransportProtocol;
			}
			set
			{
				if (this.chatPeer == null || this.chatPeer.PeerState != PeerStateValue.Disconnected)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "Can't set TransportProtocol. Disconnect first! " + ((this.chatPeer == null) ? "The chatPeer is null." : ("PeerState: " + this.chatPeer.PeerState)));
					return;
				}
				this.chatPeer.TransportProtocol = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600C307 RID: 49927 RVA: 0x0046E5F6 File Offset: 0x0046C7F6
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			get
			{
				return this.chatPeer.SocketImplementationConfig;
			}
		}

		// Token: 0x0600C308 RID: 49928 RVA: 0x0046E604 File Offset: 0x0046C804
		public bool Connect(string appId, string appVersion, AuthenticationValues authValues)
		{
			this.chatPeer.TimePingInterval = 3000;
			this.DisconnectedCause = ChatDisconnectCause.None;
			if (authValues == null)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "Connect failed: no authentication values specified");
				}
				return false;
			}
			this.AuthValues = authValues;
			if (string.IsNullOrEmpty(this.AuthValues.UserId))
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "Connect failed: no UserId specified in authentication values.");
				}
				return false;
			}
			this.AppId = appId;
			this.AppVersion = appVersion;
			this.didAuthenticate = false;
			this.chatPeer.QuickResendAttempts = 2;
			this.chatPeer.SentCountAllowance = 7;
			this.PublicChannels.Clear();
			this.PrivateChannels.Clear();
			this.PublicChannelsUnsubscribing.Clear();
			this.NameServerAddress = this.chatPeer.NameServerAddress;
			bool flag = this.chatPeer.Connect();
			if (flag)
			{
				this.State = ChatState.ConnectingToNameServer;
			}
			if (this.UseBackgroundWorkerForSending)
			{
				SupportClass.StartBackgroundCalls(new Func<bool>(this.SendOutgoingInBackground), this.msDeltaForServiceCalls, "ChatClient Service Thread");
			}
			return flag;
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x0046E730 File Offset: 0x0046C930
		public void Service()
		{
			while (this.HasPeer && this.chatPeer.DispatchIncomingCommands())
			{
			}
			if (!this.UseBackgroundWorkerForSending && (Environment.TickCount - this.msTimestampOfLastServiceCall > this.msDeltaForServiceCalls || this.msTimestampOfLastServiceCall == 0))
			{
				this.msTimestampOfLastServiceCall = Environment.TickCount;
				while (this.HasPeer && this.chatPeer.SendOutgoingCommands())
				{
				}
			}
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x0046E7B5 File Offset: 0x0046C9B5
		private bool SendOutgoingInBackground()
		{
			while (this.HasPeer && this.chatPeer.SendOutgoingCommands())
			{
			}
			return this.State != ChatState.Disconnected;
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x0046E7E4 File Offset: 0x0046C9E4
		[Obsolete("Better use UseBackgroundWorkerForSending and Service().")]
		public void SendAcksOnly()
		{
			if (this.HasPeer)
			{
				this.chatPeer.SendAcksOnly();
			}
		}

		// Token: 0x0600C30C RID: 49932 RVA: 0x0046E7FD File Offset: 0x0046C9FD
		public void Disconnect()
		{
			if (this.HasPeer && this.chatPeer.PeerState != PeerStateValue.Disconnected)
			{
				this.chatPeer.Disconnect();
			}
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x0046E825 File Offset: 0x0046CA25
		public void StopThread()
		{
			if (this.HasPeer)
			{
				this.chatPeer.StopThread();
			}
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x0046E83D File Offset: 0x0046CA3D
		public bool Subscribe(string[] channels)
		{
			return this.Subscribe(channels, 0);
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x0046E848 File Offset: 0x0046CA48
		public bool Subscribe(string[] channels, int messagesFromHistory)
		{
			if (!this.CanChat)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "Subscribe called while not connected to front end server.");
				}
				return false;
			}
			if (channels == null || channels.Length == 0)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "Subscribe can't be called for empty or null channels-list.");
				}
				return false;
			}
			return this.SendChannelOperation(channels, 0, messagesFromHistory);
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x0046E8B8 File Offset: 0x0046CAB8
		public bool Unsubscribe(string[] channels)
		{
			if (!this.CanChat)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "Unsubscribe called while not connected to front end server.");
				}
				return false;
			}
			if (channels == null || channels.Length == 0)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "Unsubscribe can't be called for empty or null channels-list.");
				}
				return false;
			}
			foreach (string item in channels)
			{
				this.PublicChannelsUnsubscribing.Add(item);
			}
			return this.SendChannelOperation(channels, 1, 0);
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x0046E94C File Offset: 0x0046CB4C
		public bool PublishMessage(string channelName, object message, bool forwardAsWebhook = false)
		{
			return this.publishMessage(channelName, message, true, forwardAsWebhook);
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x0046E958 File Offset: 0x0046CB58
		internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook = false)
		{
			return this.publishMessage(channelName, message, false, forwardAsWebhook);
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x0046E964 File Offset: 0x0046CB64
		private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook = false)
		{
			if (!this.CanChat)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "PublishMessage called while not connected to front end server.");
				}
				return false;
			}
			if (string.IsNullOrEmpty(channelName) || message == null)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "PublishMessage parameters must be non-null and not empty.");
				}
				return false;
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>
			{
				{
					1,
					channelName
				},
				{
					3,
					message
				}
			};
			if (forwardAsWebhook)
			{
				dictionary.Add(21, 1);
			}
			return this.chatPeer.OpCustom(2, dictionary, reliable);
		}

		// Token: 0x0600C314 RID: 49940 RVA: 0x0046EA06 File Offset: 0x0046CC06
		public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook = false)
		{
			return this.SendPrivateMessage(target, message, false, forwardAsWebhook);
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x0046EA12 File Offset: 0x0046CC12
		public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook)
		{
			return this.sendPrivateMessage(target, message, encrypt, true, forwardAsWebhook);
		}

		// Token: 0x0600C316 RID: 49942 RVA: 0x0046EA20 File Offset: 0x0046CC20
		internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook = false)
		{
			return this.sendPrivateMessage(target, message, encrypt, false, forwardAsWebhook);
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x0046EA30 File Offset: 0x0046CC30
		private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook = false)
		{
			if (!this.CanChat)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "SendPrivateMessage called while not connected to front end server.");
				}
				return false;
			}
			if (string.IsNullOrEmpty(target) || message == null)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "SendPrivateMessage parameters must be non-null and not empty.");
				}
				return false;
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>
			{
				{
					225,
					target
				},
				{
					3,
					message
				}
			};
			if (forwardAsWebhook)
			{
				dictionary.Add(21, 1);
			}
			return this.chatPeer.OpCustom(3, dictionary, reliable, 0, encrypt);
		}

		// Token: 0x0600C318 RID: 49944 RVA: 0x0046EADC File Offset: 0x0046CCDC
		private bool SetOnlineStatus(int status, object message, bool skipMessage)
		{
			if (!this.CanChat)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "SetOnlineStatus called while not connected to front end server.");
				}
				return false;
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>
			{
				{
					10,
					status
				}
			};
			if (skipMessage)
			{
				dictionary[12] = true;
			}
			else
			{
				dictionary[3] = message;
			}
			return this.chatPeer.OpCustom(5, dictionary, true);
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x0046EB58 File Offset: 0x0046CD58
		public bool SetOnlineStatus(int status)
		{
			return this.SetOnlineStatus(status, null, true);
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x0046EB63 File Offset: 0x0046CD63
		public bool SetOnlineStatus(int status, object message)
		{
			return this.SetOnlineStatus(status, message, false);
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x0046EB70 File Offset: 0x0046CD70
		public bool AddFriends(string[] friends)
		{
			if (!this.CanChat)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "AddFriends called while not connected to front end server.");
				}
				return false;
			}
			if (friends == null || friends.Length == 0)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "AddFriends can't be called for empty or null list.");
				}
				return false;
			}
			if (friends.Length > 1024)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, string.Concat(new object[]
					{
						"AddFriends max list size exceeded: ",
						friends.Length,
						" > ",
						1024
					}));
				}
				return false;
			}
			Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
			{
				{
					11,
					friends
				}
			};
			return this.chatPeer.OpCustom(6, customOpParameters, true);
		}

		// Token: 0x0600C31C RID: 49948 RVA: 0x0046EC50 File Offset: 0x0046CE50
		public bool RemoveFriends(string[] friends)
		{
			if (!this.CanChat)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "RemoveFriends called while not connected to front end server.");
				}
				return false;
			}
			if (friends == null || friends.Length == 0)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "RemoveFriends can't be called for empty or null list.");
				}
				return false;
			}
			if (friends.Length > 1024)
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, string.Concat(new object[]
					{
						"RemoveFriends max list size exceeded: ",
						friends.Length,
						" > ",
						1024
					}));
				}
				return false;
			}
			Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
			{
				{
					11,
					friends
				}
			};
			return this.chatPeer.OpCustom(7, customOpParameters, true);
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x0046ED2D File Offset: 0x0046CF2D
		public string GetPrivateChannelNameByUser(string userName)
		{
			return string.Format("{0}:{1}", this.UserId, userName);
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x0046ED40 File Offset: 0x0046CF40
		public bool TryGetChannel(string channelName, bool isPrivate, out ChatChannel channel)
		{
			if (!isPrivate)
			{
				return this.PublicChannels.TryGetValue(channelName, out channel);
			}
			return this.PrivateChannels.TryGetValue(channelName, out channel);
		}

		// Token: 0x0600C31F RID: 49951 RVA: 0x0046ED64 File Offset: 0x0046CF64
		public bool TryGetChannel(string channelName, out ChatChannel channel)
		{
			bool flag = this.PublicChannels.TryGetValue(channelName, out channel);
			return flag || this.PrivateChannels.TryGetValue(channelName, out channel);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600C321 RID: 49953 RVA: 0x0046EDA6 File Offset: 0x0046CFA6
		// (set) Token: 0x0600C320 RID: 49952 RVA: 0x0046ED98 File Offset: 0x0046CF98
		public DebugLevel DebugOut
		{
			get
			{
				return this.chatPeer.DebugOut;
			}
			set
			{
				this.chatPeer.DebugOut = value;
			}
		}

		// Token: 0x0600C322 RID: 49954 RVA: 0x0046EDB3 File Offset: 0x0046CFB3
		void IPhotonPeerListener.DebugReturn(DebugLevel level, string message)
		{
			this.listener.DebugReturn(level, message);
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x0046EDC4 File Offset: 0x0046CFC4
		void IPhotonPeerListener.OnEvent(EventData eventData)
		{
			switch (eventData.Code)
			{
			case 0:
				this.HandleChatMessagesEvent(eventData);
				break;
			case 2:
				this.HandlePrivateMessageEvent(eventData);
				break;
			case 4:
				this.HandleStatusUpdate(eventData);
				break;
			case 5:
				this.HandleSubscribeEvent(eventData);
				break;
			case 6:
				this.HandleUnsubscribeEvent(eventData);
				break;
			}
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x0046EE3C File Offset: 0x0046D03C
		void IPhotonPeerListener.OnOperationResponse(OperationResponse operationResponse)
		{
			byte operationCode = operationResponse.OperationCode;
			switch (operationCode)
			{
			case 0:
			case 1:
			case 2:
			case 3:
				break;
			default:
				if (operationCode == 230)
				{
					this.HandleAuthResponse(operationResponse);
					return;
				}
				break;
			}
			if (operationResponse.ReturnCode != 0 && this.DebugOut >= DebugLevel.ERROR)
			{
				if (operationResponse.ReturnCode == -2)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, string.Format("Chat Operation {0} unknown on server. Check your AppId and make sure it's for a Chat application.", operationResponse.OperationCode));
				}
				else
				{
					this.listener.DebugReturn(DebugLevel.ERROR, string.Format("Chat Operation {0} failed (Code: {1}). Debug Message: {2}", operationResponse.OperationCode, operationResponse.ReturnCode, operationResponse.DebugMessage));
				}
			}
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x0046EF04 File Offset: 0x0046D104
		void IPhotonPeerListener.OnStatusChanged(StatusCode statusCode)
		{
			if (statusCode != StatusCode.Connect)
			{
				if (statusCode != StatusCode.Disconnect)
				{
					if (statusCode != StatusCode.EncryptionEstablished)
					{
						if (statusCode == StatusCode.EncryptionFailedToEstablish)
						{
							this.State = ChatState.Disconnecting;
							this.chatPeer.Disconnect();
						}
					}
					else if (!this.didAuthenticate)
					{
						this.didAuthenticate = this.chatPeer.AuthenticateOnNameServer(this.AppId, this.AppVersion, this.chatRegion, this.AuthValues);
						if (!this.didAuthenticate && this.DebugOut >= DebugLevel.ERROR)
						{
							((IPhotonPeerListener)this).DebugReturn(DebugLevel.ERROR, "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: " + this.State);
						}
					}
				}
				else if (this.State == ChatState.Authenticated)
				{
					this.ConnectToFrontEnd();
				}
				else
				{
					this.State = ChatState.Disconnected;
					this.listener.OnChatStateChange(ChatState.Disconnected);
					this.listener.OnDisconnected();
				}
			}
			else
			{
				if (!this.chatPeer.IsProtocolSecure)
				{
					this.chatPeer.EstablishEncryption();
				}
				else if (!this.didAuthenticate)
				{
					this.didAuthenticate = this.chatPeer.AuthenticateOnNameServer(this.AppId, this.AppVersion, this.chatRegion, this.AuthValues);
					if (!this.didAuthenticate && this.DebugOut >= DebugLevel.ERROR)
					{
						((IPhotonPeerListener)this).DebugReturn(DebugLevel.ERROR, "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: " + this.State);
					}
				}
				if (this.State == ChatState.ConnectingToNameServer)
				{
					this.State = ChatState.ConnectedToNameServer;
					this.listener.OnChatStateChange(this.State);
				}
				else if (this.State == ChatState.ConnectingToFrontEnd)
				{
					this.AuthenticateOnFrontEnd();
				}
			}
		}

		// Token: 0x0600C326 RID: 49958 RVA: 0x0046F0CC File Offset: 0x0046D2CC
		private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
		{
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>
			{
				{
					0,
					channels
				}
			};
			if (historyLength != 0)
			{
				dictionary.Add(14, historyLength);
			}
			return this.chatPeer.OpCustom(operation, dictionary, true);
		}

		// Token: 0x0600C327 RID: 49959 RVA: 0x0046F10C File Offset: 0x0046D30C
		private void HandlePrivateMessageEvent(EventData eventData)
		{
			object message = eventData.Parameters[3];
			string text = (string)eventData.Parameters[5];
			string privateChannelNameByUser;
			if (this.UserId != null && this.UserId.Equals(text))
			{
				string userName = (string)eventData.Parameters[225];
				privateChannelNameByUser = this.GetPrivateChannelNameByUser(userName);
			}
			else
			{
				privateChannelNameByUser = this.GetPrivateChannelNameByUser(text);
			}
			ChatChannel chatChannel;
			if (!this.PrivateChannels.TryGetValue(privateChannelNameByUser, out chatChannel))
			{
				chatChannel = new ChatChannel(privateChannelNameByUser);
				chatChannel.IsPrivate = true;
				chatChannel.MessageLimit = this.MessageLimit;
				this.PrivateChannels.Add(chatChannel.Name, chatChannel);
			}
			chatChannel.Add(text, message);
			this.listener.OnPrivateMessage(text, message, privateChannelNameByUser);
		}

		// Token: 0x0600C328 RID: 49960 RVA: 0x0046F1DC File Offset: 0x0046D3DC
		private void HandleChatMessagesEvent(EventData eventData)
		{
			object[] messages = (object[])eventData.Parameters[2];
			string[] senders = (string[])eventData.Parameters[4];
			string text = (string)eventData.Parameters[1];
			ChatChannel chatChannel;
			if (!this.PublicChannels.TryGetValue(text, out chatChannel))
			{
				if (this.DebugOut >= DebugLevel.WARNING)
				{
					this.listener.DebugReturn(DebugLevel.WARNING, "Channel " + text + " for incoming message event not found.");
				}
				return;
			}
			chatChannel.Add(senders, messages);
			this.listener.OnGetMessages(text, senders, messages);
		}

		// Token: 0x0600C329 RID: 49961 RVA: 0x0046F274 File Offset: 0x0046D474
		private void HandleSubscribeEvent(EventData eventData)
		{
			string[] array = (string[])eventData.Parameters[0];
			bool[] array2 = (bool[])eventData.Parameters[15];
			for (int i = 0; i < array.Length; i++)
			{
				if (array2[i])
				{
					string text = array[i];
					if (!this.PublicChannels.ContainsKey(text))
					{
						ChatChannel chatChannel = new ChatChannel(text);
						chatChannel.MessageLimit = this.MessageLimit;
						this.PublicChannels.Add(chatChannel.Name, chatChannel);
					}
				}
			}
			this.listener.OnSubscribed(array, array2);
		}

		// Token: 0x0600C32A RID: 49962 RVA: 0x0046F310 File Offset: 0x0046D510
		private void HandleUnsubscribeEvent(EventData eventData)
		{
			foreach (string text in (string[])eventData[0])
			{
				this.PublicChannels.Remove(text);
				this.PublicChannelsUnsubscribing.Remove(text);
			}
			string[] array;
			this.listener.OnUnsubscribed(array);
		}

		// Token: 0x0600C32B RID: 49963 RVA: 0x0046F368 File Offset: 0x0046D568
		private void HandleAuthResponse(OperationResponse operationResponse)
		{
			if (this.DebugOut >= DebugLevel.INFO)
			{
				this.listener.DebugReturn(DebugLevel.INFO, operationResponse.ToStringFull() + " on: " + this.chatPeer.NameServerAddress);
			}
			if (operationResponse.ReturnCode == 0)
			{
				if (this.State == ChatState.ConnectedToNameServer)
				{
					this.State = ChatState.Authenticated;
					this.listener.OnChatStateChange(this.State);
					if (operationResponse.Parameters.ContainsKey(221))
					{
						if (this.AuthValues == null)
						{
							this.AuthValues = new AuthenticationValues();
						}
						this.AuthValues.Token = (operationResponse[221] as string);
						this.FrontendAddress = (string)operationResponse[230];
						this.chatPeer.Disconnect();
					}
					else if (this.DebugOut >= DebugLevel.ERROR)
					{
						this.listener.DebugReturn(DebugLevel.ERROR, "No secret in authentication response.");
					}
				}
				else if (this.State == ChatState.ConnectingToFrontEnd)
				{
					this.State = ChatState.ConnectedToFrontEnd;
					this.listener.OnChatStateChange(this.State);
					this.listener.OnConnected();
				}
			}
			else
			{
				short returnCode = operationResponse.ReturnCode;
				switch (returnCode)
				{
				case 32755:
					this.DisconnectedCause = ChatDisconnectCause.CustomAuthenticationFailed;
					break;
				case 32756:
					this.DisconnectedCause = ChatDisconnectCause.InvalidRegion;
					break;
				case 32757:
					this.DisconnectedCause = ChatDisconnectCause.MaxCcuReached;
					break;
				default:
					if (returnCode != -3)
					{
						if (returnCode == 32767)
						{
							this.DisconnectedCause = ChatDisconnectCause.InvalidAuthentication;
						}
					}
					else
					{
						this.DisconnectedCause = ChatDisconnectCause.OperationNotAllowedInCurrentState;
					}
					break;
				}
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "Authentication request error: " + operationResponse.ReturnCode + ". Disconnecting.");
				}
				this.State = ChatState.Disconnecting;
				this.chatPeer.Disconnect();
			}
		}

		// Token: 0x0600C32C RID: 49964 RVA: 0x0046F554 File Offset: 0x0046D754
		private void HandleStatusUpdate(EventData eventData)
		{
			string user = (string)eventData.Parameters[5];
			int status = (int)eventData.Parameters[10];
			object message = null;
			bool flag = eventData.Parameters.ContainsKey(3);
			if (flag)
			{
				message = eventData.Parameters[3];
			}
			this.listener.OnStatusUpdate(user, status, flag, message);
		}

		// Token: 0x0600C32D RID: 49965 RVA: 0x0046F5B8 File Offset: 0x0046D7B8
		private void ConnectToFrontEnd()
		{
			this.State = ChatState.ConnectingToFrontEnd;
			if (this.DebugOut >= DebugLevel.INFO)
			{
				this.listener.DebugReturn(DebugLevel.INFO, "Connecting to frontend " + this.FrontendAddress);
			}
			this.chatPeer.Connect(this.FrontendAddress, "chat");
		}

		// Token: 0x0600C32E RID: 49966 RVA: 0x0046F60C File Offset: 0x0046D80C
		private bool AuthenticateOnFrontEnd()
		{
			if (this.AuthValues == null)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "Can't authenticate on front end server. Authentication Values are not set");
				}
				return false;
			}
			if (this.AuthValues.Token == null || this.AuthValues.Token == string.Empty)
			{
				if (this.DebugOut >= DebugLevel.ERROR)
				{
					this.listener.DebugReturn(DebugLevel.ERROR, "Can't authenticate on front end server. Secret is not set");
				}
				return false;
			}
			Dictionary<byte, object> customOpParameters = new Dictionary<byte, object>
			{
				{
					221,
					this.AuthValues.Token
				}
			};
			return this.chatPeer.OpCustom(230, customOpParameters, true);
		}

		// Token: 0x040016A0 RID: 5792
		private const int FriendRequestListMax = 1024;

		// Token: 0x040016A3 RID: 5795
		private string chatRegion = "EU";

		// Token: 0x040016A9 RID: 5801
		public int MessageLimit;

		// Token: 0x040016AA RID: 5802
		public readonly Dictionary<string, ChatChannel> PublicChannels;

		// Token: 0x040016AB RID: 5803
		public readonly Dictionary<string, ChatChannel> PrivateChannels;

		// Token: 0x040016AC RID: 5804
		private readonly HashSet<string> PublicChannelsUnsubscribing;

		// Token: 0x040016AD RID: 5805
		private readonly IChatClientListener listener;

		// Token: 0x040016AE RID: 5806
		public ChatPeer chatPeer;

		// Token: 0x040016AF RID: 5807
		private const string ChatAppName = "chat";

		// Token: 0x040016B0 RID: 5808
		private bool didAuthenticate;

		// Token: 0x040016B1 RID: 5809
		private int msDeltaForServiceCalls = 50;

		// Token: 0x040016B2 RID: 5810
		private int msTimestampOfLastServiceCall;
	}
}
