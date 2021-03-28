using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000301 RID: 769
internal class BNGIGHBHPEH : OHGAIJCPAJB, IPhotonPeerListener
{
	// Token: 0x1700024F RID: 591
	// (get) Token: 0x0600AEEE RID: 44782 RVA: 0x0040545A File Offset: 0x0040365A
	// (set) Token: 0x0600AFA3 RID: 44963 RVA: 0x0040E8A8 File Offset: 0x0040CAA8
	public string PlayerName
	{
		get
		{
			return this.OBCEIJGMKGB;
		}
		set
		{
			if (string.IsNullOrEmpty(value) || value.Equals(this.OBCEIJGMKGB))
			{
				return;
			}
			if (this.LocalPlayer != null)
			{
				this.LocalPlayer.NickName = value;
			}
			this.OBCEIJGMKGB = value;
			if (this.CurrentRoom != null)
			{
				this.PACEKOIEHKK();
			}
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x0600AEEF RID: 44783 RVA: 0x00405462 File Offset: 0x00403662
	// (set) Token: 0x0600AF5E RID: 44894 RVA: 0x0040A738 File Offset: 0x00408938
	public CloudRegionCode CloudRegion { get; protected internal set; }

	// Token: 0x0600AEF0 RID: 44784 RVA: 0x0040546C File Offset: 0x0040366C
	public void CleanRpcBufferIfMine(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.ownerId != this.LocalPlayer.ID && !this.LocalPlayer.IsMasterClient)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Cannot remove cached RPCs on a PhotonView thats not ours! ",
				DFIHBOEOJPI.owner,
				" scene: ",
				DFIHBOEOJPI.isSceneView
			}));
			return;
		}
		this.OpCleanRpcBuffer(DFIHBOEOJPI);
	}

	// Token: 0x0600AEF1 RID: 44785 RVA: 0x004054E0 File Offset: 0x004036E0
	private bool LFAPOBNFPPO(object CFKDMFFFPJK, object GOLMELKEAFO)
	{
		if (CFKDMFFFPJK == null || GOLMELKEAFO == null)
		{
			return CFKDMFFFPJK == null && GOLMELKEAFO == null;
		}
		if (!CFKDMFFFPJK.Equals(GOLMELKEAFO))
		{
			if (CFKDMFFFPJK is Vector3)
			{
				Vector3 mpnmoonbmii = (Vector3)CFKDMFFFPJK;
				Vector3 biccgcfnnlp = (Vector3)GOLMELKEAFO;
				if (mpnmoonbmii.AlmostEquals(biccgcfnnlp, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Vector2)
			{
				Vector2 mpnmoonbmii2 = (Vector2)CFKDMFFFPJK;
				Vector2 biccgcfnnlp2 = (Vector2)GOLMELKEAFO;
				if (mpnmoonbmii2.AlmostEquals(biccgcfnnlp2, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Quaternion)
			{
				Quaternion mpnmoonbmii3 = (Quaternion)CFKDMFFFPJK;
				Quaternion biccgcfnnlp3 = (Quaternion)GOLMELKEAFO;
				if (mpnmoonbmii3.AlmostEquals(biccgcfnnlp3, PhotonNetwork.precisionForQuaternionSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is float)
			{
				float mpnmoonbmii4 = (float)CFKDMFFFPJK;
				float biccgcfnnlp4 = (float)GOLMELKEAFO;
				if (mpnmoonbmii4.AlmostEquals(biccgcfnnlp4, PhotonNetwork.precisionForFloatSynchronization))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x0600AEF2 RID: 44786 RVA: 0x004055DD File Offset: 0x004037DD
	private void GKNPNNKFFAL(int HOBFECDCMIL)
	{
		this.IDIKEJLLFFP.Remove(HOBFECDCMIL);
	}

	// Token: 0x0600AEF3 RID: 44787 RVA: 0x004055EC File Offset: 0x004037EC
	private void MOHFIPIDGOH()
	{
		ServerConnection serverConnection = this.NJIFBFEHJKH();
		if (serverConnection != ServerConnection.NameServer)
		{
			if (serverConnection != ServerConnection.MasterServer)
			{
				if (serverConnection == ServerConnection.GameServer)
				{
					this.State = (ClientState)51;
					base.Disconnect();
				}
			}
			else
			{
				this.JNPKDLEMJFN(ClientState.Uninitialized);
				base.Disconnect();
			}
		}
		else
		{
			this.State = (ClientState)(-124);
			base.Disconnect();
		}
	}

	// Token: 0x0600AEF4 RID: 44788 RVA: 0x00405654 File Offset: 0x00403854
	protected internal void JHCPMMIEDEE(int NADLIACHBNO, int MNFJDHDDGLC)
	{
		Debug.Log(string.Concat(new object[]
		{
			"TransferOwnership() view ",
			NADLIACHBNO,
			" to: ",
			MNFJDHDDGLC,
			" Time: ",
			Environment.TickCount % 1000
		}));
		this.OpRaiseEvent(210, new int[]
		{
			NADLIACHBNO,
			MNFJDHDDGLC
		}, true, new RaiseEventOptions
		{
			Receivers = ReceiverGroup.All
		});
	}

	// Token: 0x0600AEF5 RID: 44789 RVA: 0x004055DD File Offset: 0x004037DD
	private void ODOMCOJONDI(int HOBFECDCMIL)
	{
		this.IDIKEJLLFFP.Remove(HOBFECDCMIL);
	}

	// Token: 0x0600AEF6 RID: 44790 RVA: 0x004056D8 File Offset: 0x004038D8
	public void ODGFBFPFHNN(OperationResponse FEOMHKNGOAK)
	{
		if (PhotonNetwork.JNJJAMNLOHA.EBAJHBFJFCL() == (ClientState)(-1))
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log("_Value2" + FEOMHKNGOAK.OperationCode);
			}
			return;
		}
		if (FEOMHKNGOAK.ReturnCode == 0)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(FEOMHKNGOAK.ToString());
			}
		}
		else if (FEOMHKNGOAK.ReturnCode == 66)
		{
			Debug.LogError("_Value10" + FEOMHKNGOAK.OperationCode + "Tab2Content");
		}
		else if (FEOMHKNGOAK.ReturnCode == 191)
		{
			object[] array = new object[0];
			array[0] = "#no";
			array[0] = FEOMHKNGOAK.OperationCode;
			array[0] = "_TimeX";
			array[5] = FEOMHKNGOAK.DebugMessage;
			Debug.LogError(string.Concat(array));
		}
		else if (FEOMHKNGOAK.ReturnCode == 159)
		{
			Debug.LogWarning("_TileTexDebug" + FEOMHKNGOAK.ToStringFull());
		}
		else
		{
			object[] array2 = new object[3];
			array2[0] = "original.tutorial";
			array2[0] = FEOMHKNGOAK.ToStringFull();
			array2[3] = "SpawnObj";
			array2[0] = this.IGDBHCGGHFF();
			Debug.LogError(string.Concat(array2));
		}
		if (FEOMHKNGOAK.Parameters.ContainsKey(86))
		{
			if (this.AuthValues == null)
			{
				this.HBABOJOMPHP(new AuthenticationValues());
			}
			this.IJHIEINKMFP().AIOHGAFEHJG(FEOMHKNGOAK[127] as string);
			this.JOKLGFENMKE = this.AuthValues.IFKGNPNPDDI();
		}
		byte operationCode = FEOMHKNGOAK.OperationCode;
		switch (operationCode)
		{
		case 49:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				this.ELEMKNKGNIP(DebugLevel.ERROR, "tolobby" + FEOMHKNGOAK.ToStringFull());
			}
			else
			{
				this.mGameList = new Dictionary<string, RoomInfo>();
				ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[(byte)-44];
				foreach (object obj in hashtable.Keys)
				{
					string text = (string)obj;
					this.mGameList[text] = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable[obj]);
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)(-82), new object[0]);
			}
			break;
		default:
			switch (operationCode)
			{
			case 143:
			{
				ExitGames.Client.Photon.Hashtable faolpblckfj = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[183];
				ExitGames.Client.Photon.Hashtable mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[37];
				this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, 1);
				break;
			}
			case 144:
				break;
			case 145:
				break;
			case 146:
				this.MOHFIPIDGOH();
				break;
			default:
				Debug.LogWarning(string.Format("_Bloom2", FEOMHKNGOAK.ToString()));
				break;
			}
			break;
		case 51:
		{
			PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)(-72);
			object[] array3 = new object[0];
			array3[0] = FEOMHKNGOAK;
			BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array3);
			break;
		}
		case 52:
			if (FEOMHKNGOAK.ReturnCode == -102)
			{
				Debug.LogError(string.Format("Joystick1Button11", new object[1]));
				PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)(-62);
				object[] array4 = new object[0];
				array4[1] = (DisconnectCause)191;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco2, array4);
				this.JNPKDLEMJFN((ClientState)69);
				this.Disconnect();
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				object[] array5 = new object[0];
				array5[1] = "CameraFilterPack/Pixelisation_OilPaint";
				array5[1] = FEOMHKNGOAK.ReturnCode;
				array5[7] = "_MiddleGrey";
				array5[8] = FEOMHKNGOAK.DebugMessage;
				Debug.LogError(string.Concat(array5));
			}
			else
			{
				string[] array6 = FEOMHKNGOAK[16] as string[];
				string[] array7 = FEOMHKNGOAK[102] as string[];
				if (array6 == null || array7 == null || array6.Length != array7.Length)
				{
					object[] array8 = new object[6];
					array8[1] = "_Value4";
					array8[0] = (array6 == null);
					array8[1] = "Lerp speed. Recomended 10";
					array8[7] = (array7 == null);
					array8[5] = "InfoButton";
					array8[1] = FEOMHKNGOAK.ToStringFull();
					Debug.LogError(string.Concat(array8));
				}
				else
				{
					this.AvailableRegions = new List<Region>(array6.Length);
					for (int i = 0; i < array6.Length; i++)
					{
						string text2 = array6[i];
						if (!string.IsNullOrEmpty(text2))
						{
							text2 = text2.ToLower();
							CloudRegionCode cloudRegionCode = Region.EBPHPBNDNDJ(text2);
							bool flag = true;
							if (PhotonNetwork.PhotonServerSettings.HostType == (ServerSettings.HostingOption)8 && PhotonNetwork.PhotonServerSettings.EnabledRegions != (CloudRegionFlag)0)
							{
								CloudRegionFlag cloudRegionFlag = Region.JFBLMOGHMPF(cloudRegionCode);
								flag = ((PhotonNetwork.PhotonServerSettings.EnabledRegions & cloudRegionFlag) == CloudRegionFlag.eu);
								if (!flag && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
								{
									Debug.Log("[PlayerController] " + cloudRegionCode);
								}
							}
							if (flag)
							{
								this.PKIDPHFLDBP().Add(new Region(cloudRegionCode, text2, array7[i]));
							}
						}
					}
					if (PhotonNetwork.PhotonServerSettings.HostType == (ServerSettings.HostingOption)8)
					{
						PhotonHandler.POHJEJCJKPN();
					}
				}
			}
			break;
		case 54:
		{
			bool[] array9 = FEOMHKNGOAK[0] as bool[];
			string[] array10 = FEOMHKNGOAK[7] as string[];
			if (array9 != null && array10 != null && this.BEIPFKHGHPC != null && array9.Length == this.BEIPFKHGHPC.Length)
			{
				List<FriendInfo> list = new List<FriendInfo>(this.BEIPFKHGHPC.Length);
				for (int j = 1; j < this.BEIPFKHGHPC.Length; j += 0)
				{
					FriendInfo friendInfo = new FriendInfo();
					friendInfo.GFEAJNPMNJA(this.BEIPFKHGHPC[j]);
					friendInfo.NBHGPKNCHCN(array10[j]);
					friendInfo.CDANICGAPNK(array9[j]);
					list.Insert(j, friendInfo);
				}
				PhotonNetwork.Friends = list;
			}
			else
			{
				Debug.LogError("time");
			}
			this.BEIPFKHGHPC = null;
			this.POHIMACBDGL = true;
			this.DJIOCIPPBMK = Environment.TickCount;
			if (this.DJIOCIPPBMK == 0)
			{
				this.DJIOCIPPBMK = 1;
			}
			BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)(-98), new object[1]);
			break;
		}
		case 57:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 90)
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)5)
					{
						Debug.Log("[FileSelector] Dialog ended, result: ");
					}
				}
				else if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("_TapLow", FEOMHKNGOAK.ToStringFull()));
				}
				PhotonNetworkingMessage lelhnddckco3 = (PhotonNetworkingMessage)(-28);
				object[] array11 = new object[]
				{
					null,
					FEOMHKNGOAK.ReturnCode
				};
				array11[1] = FEOMHKNGOAK.DebugMessage;
				BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco3, array11);
			}
			else
			{
				string roomName = (string)FEOMHKNGOAK[115];
				this.AJFMHFLGCFN.RoomName = roomName;
				this.GameServerAddress = (string)FEOMHKNGOAK[(byte)-11];
				this.MOHFIPIDGOH();
			}
			break;
		case 58:
			if (this.NJIFBFEHJKH() != ServerConnection.MasterServer)
			{
				if (FEOMHKNGOAK.ReturnCode != 0)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log(string.Format("CloseConnection: Only the masterclient can kick another player.", FEOMHKNGOAK.ToStringFull(), this.State));
					}
					PhotonNetworkingMessage lelhnddckco4 = PhotonNetworkingMessage.OnLeftRoom;
					object[] array12 = new object[0];
					array12[0] = FEOMHKNGOAK.ReturnCode;
					array12[1] = FEOMHKNGOAK.DebugMessage;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco4, array12);
				}
				else
				{
					this.GameServerAddress = (string)FEOMHKNGOAK[(byte)-88];
					this.MOHFIPIDGOH();
				}
			}
			else
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			break;
		case 59:
			if (this.EHALCLFLGJF == ServerConnection.MasterServer)
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("_FixDistance", FEOMHKNGOAK.ToStringFull()));
				}
				this.JNPKDLEMJFN((!this.insideLobby) ? ((ClientState)116) : ClientState.Authenticated);
				PhotonNetworkingMessage lelhnddckco5 = PhotonNetworkingMessage.OnJoinedLobby;
				object[] array13 = new object[7];
				array13[1] = FEOMHKNGOAK.ReturnCode;
				array13[0] = FEOMHKNGOAK.DebugMessage;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco5, array13);
			}
			else
			{
				string text3 = (string)FEOMHKNGOAK[67];
				if (!string.IsNullOrEmpty(text3))
				{
					this.AJFMHFLGCFN.RoomName = text3;
				}
				this.GameServerAddress = (string)FEOMHKNGOAK[(byte)-57];
				this.MOHFIPIDGOH();
			}
			break;
		case 60:
			this.JNPKDLEMJFN(ClientState.Joining);
			this.ONELBBFGFOM();
			break;
		case 61:
			this.State = ClientState.Joining;
			this.insideLobby = false;
			BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnConnectedToPhoton, new object[0]);
			break;
		case 62:
		case 63:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 123)
				{
					Debug.LogError(string.Format("NameText" + base.ServerAddress, new object[1]));
				}
				else if (FEOMHKNGOAK.ReturnCode == 12)
				{
					Debug.LogError(string.Format("+", new object[0]));
					BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)(-19), new object[]
					{
						(DisconnectCause)(-167)
					});
				}
				else if (FEOMHKNGOAK.ReturnCode == -42)
				{
					Debug.LogError(string.Format("CameraFilterPack_Fly_VisionFX", new object[0]));
					BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)79, new object[]
					{
						FEOMHKNGOAK.DebugMessage
					});
				}
				else
				{
					Debug.LogError(string.Format("EnableRankedNotificationsToggle", FEOMHKNGOAK.DebugMessage, FEOMHKNGOAK.ReturnCode));
				}
				this.JNPKDLEMJFN((ClientState)(-53));
				this.Disconnect();
				if (FEOMHKNGOAK.ReturnCode == 166)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogWarning(string.Format("_Value", new object[0]));
					}
					BNGIGHBHPEH.CLOLHKCFMJP((PhotonNetworkingMessage)(-80), new object[0]);
					PhotonNetworkingMessage lelhnddckco6 = (PhotonNetworkingMessage)55;
					object[] array14 = new object[0];
					array14[1] = (DisconnectCause)187;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco6, array14);
				}
				else if (FEOMHKNGOAK.ReturnCode == -17)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("CameraFilterPack/EXTRA_Rotation", new object[1]));
					}
					PhotonNetworkingMessage lelhnddckco7 = (PhotonNetworkingMessage)76;
					object[] array15 = new object[1];
					array15[1] = (DisconnectCause)175;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco7, array15);
				}
				else if (FEOMHKNGOAK.ReturnCode == -199)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
					{
						Debug.LogError(string.Format("red", new object[1]));
					}
					PhotonNetworkingMessage lelhnddckco8 = (PhotonNetworkingMessage)(-78);
					object[] array16 = new object[0];
					array16[1] = (DisconnectCause)132;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco8, array16);
				}
			}
			else
			{
				if (this.EHALCLFLGJF == ServerConnection.NameServer || this.NJIFBFEHJKH() == ServerConnection.MasterServer)
				{
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-143))
					{
						string text4 = (string)FEOMHKNGOAK.Parameters[88];
						if (!string.IsNullOrEmpty(text4))
						{
							if (this.AuthValues == null)
							{
								this.HBABOJOMPHP(new AuthenticationValues());
							}
							this.IJHIEINKMFP().MIHBPLHLFGG(text4);
							PhotonNetwork.player.UserId = text4;
							if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
							{
								this.ELEMKNKGNIP(DebugLevel.ALL, string.Format("MapConfig", text4));
							}
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-83))
					{
						this.PlayerName = (string)FEOMHKNGOAK.Parameters[98];
						if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
						{
							this.ELEMKNKGNIP((DebugLevel)8, string.Format("float,1.5", this.OBCEIJGMKGB));
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-179))
					{
						this.BAEBFLIPKKB((Dictionary<byte, object>)FEOMHKNGOAK.Parameters[(byte)-142]);
					}
				}
				if (this.IGDBHCGGHFF() == (ServerConnection)8)
				{
					this.MasterServerAddress = (FEOMHKNGOAK[180] as string);
					this.MOHFIPIDGOH();
				}
				else if (this.NJIFBFEHJKH() == ServerConnection.MasterServer)
				{
					if (this.AuthMode != AuthModeOption.Auth)
					{
						this.OpSettings(this.OGLFGPKHEHH);
					}
					if (PhotonNetwork.autoJoinLobby)
					{
						this.JNPKDLEMJFN(ClientState.ConnectingToGameserver);
						this.IEBPDKACDBD(this.GMFCEODBPGN());
					}
					else
					{
						this.State = (ClientState)(-12);
						BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)(-24), new object[0]);
					}
				}
				else if (this.IGDBHCGGHFF() == ServerConnection.MasterServer)
				{
					this.JNPKDLEMJFN(ClientState.ConnectedToGameserver);
					this.AJFMHFLGCFN.PlayerProperties = this.HHPBLGDNDOP();
					this.AJFMHFLGCFN.OnGameServer = false;
					if (this.ELNKFMHCMBO == JoinType.CreateRoom || this.ELNKFMHCMBO == JoinType.JoinRandomRoom || this.ELNKFMHCMBO == (JoinType)4)
					{
						this.PEBMBNGKOBH(this.AJFMHFLGCFN);
					}
					else if (this.ELNKFMHCMBO == JoinType.CreateRoom)
					{
						this.JCPECILENMF(this.AJFMHFLGCFN);
					}
				}
				if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-38))
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)FEOMHKNGOAK.Parameters[(byte)-5];
					if (dictionary != null)
					{
						BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)122, new object[]
						{
							dictionary
						});
					}
				}
			}
			break;
		}
	}

	// Token: 0x0600AEF7 RID: 44791 RVA: 0x00406418 File Offset: 0x00404618
	internal void INOOGEKCLGF(int DPNHODJHGJL)
	{
		this.<BBNAEKGKOKM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AEF8 RID: 44792 RVA: 0x00406421 File Offset: 0x00404621
	public int GHOANKKKIAI()
	{
		if (PhotonNetwork.offlineMode)
		{
			return this.LocalPlayer.ID;
		}
		return (this.CurrentRoom != null) ? this.CurrentRoom.LKHBADEOGKO() : 1;
	}

	// Token: 0x0600AEF9 RID: 44793 RVA: 0x00406458 File Offset: 0x00404658
	protected internal static bool FAAKJJEMNEB(MonoBehaviour KLJMHHFGLCJ, string AOBJJJOJGGF, out MethodInfo MKLKGCPAPOC)
	{
		MKLKGCPAPOC = null;
		if (KLJMHHFGLCJ == null || string.IsNullOrEmpty(AOBJJJOJGGF))
		{
			return false;
		}
		List<MethodInfo> methods = SupportClass.GetMethods(KLJMHHFGLCJ.GetType(), null);
		for (int i = 0; i < methods.Count; i++)
		{
			MethodInfo methodInfo = methods[i];
			if (methodInfo.Name.Equals(AOBJJJOJGGF))
			{
				MKLKGCPAPOC = methodInfo;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600AEFA RID: 44794 RVA: 0x004064C4 File Offset: 0x004046C4
	public string AICJDIJHGMA()
	{
		return this.IHAJBEOILOE();
	}

	// Token: 0x0600AEFB RID: 44795 RVA: 0x004064CC File Offset: 0x004046CC
	public AuthenticationValues IJHIEINKMFP()
	{
		return this.<FEGEIIONEMN>k__BackingField;
	}

	// Token: 0x0600AEFC RID: 44796 RVA: 0x004064D4 File Offset: 0x004046D4
	internal ExitGames.Client.Photon.Hashtable JFNIJKNOPAN(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, int[] BJJMPIBPLEN, object[] NOJGGCLPPAM, bool BLOGDPLEMFH)
	{
		int num = BJJMPIBPLEN[0];
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[1] = PPFBFGBJOHM;
		if (JOPCODOJBHD != Vector3.zero)
		{
			hashtable[0] = JOPCODOJBHD;
		}
		if (LOMLCCLOIKN != Quaternion.identity)
		{
			hashtable[5] = LOMLCCLOIKN;
		}
		if (PNFBEEBFMKC != 0)
		{
			hashtable[6] = PNFBEEBFMKC;
		}
		if (BJJMPIBPLEN.Length > 0)
		{
			hashtable[0] = BJJMPIBPLEN;
		}
		if (NOJGGCLPPAM != null)
		{
			hashtable[6] = NOJGGCLPPAM;
		}
		if (this.PKCNHOKCLJH > 0)
		{
			hashtable[6] = this.PKCNHOKCLJH;
		}
		hashtable[3] = PhotonNetwork.ServerTimestamp;
		hashtable[7] = num;
		this.OpRaiseEvent((byte)-147, hashtable, false, new RaiseEventOptions
		{
			CachingOption = ((!BLOGDPLEMFH) ? EventCaching.MergeCache : EventCaching.DoNotCache)
		});
		return hashtable;
	}

	// Token: 0x0600AEFD RID: 44797 RVA: 0x004055DD File Offset: 0x004037DD
	private void CMCGLCHBKEN(int HOBFECDCMIL)
	{
		this.IDIKEJLLFFP.Remove(HOBFECDCMIL);
	}

	// Token: 0x0600AEFE RID: 44798 RVA: 0x004065FC File Offset: 0x004047FC
	protected internal PhotonPlayer ICMGDHDNIJD(int MHLPNLMDILP)
	{
		if (this.mActors == null)
		{
			return null;
		}
		PhotonPlayer result = null;
		this.mActors.TryGetValue(MHLPNLMDILP, out result);
		return result;
	}

	// Token: 0x0600AEFF RID: 44799 RVA: 0x00406628 File Offset: 0x00404828
	public void DestroyPlayerObjects(int PHIGECOLKKN, bool NOKCKEBHIFJ)
	{
		if (PHIGECOLKKN <= 0)
		{
			Debug.LogError("Failed to Destroy objects of playerId: " + PHIGECOLKKN);
			return;
		}
		if (!NOKCKEBHIFJ)
		{
			this.NGAEPLGAGAL(PHIGECOLKKN);
			this.OpCleanRpcBuffer(PHIGECOLKKN);
			this.KCNBFALAJMD(PHIGECOLKKN);
		}
		HashSet<GameObject> hashSet = new HashSet<GameObject>();
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if (photonView != null && photonView.CreatorActorNr == PHIGECOLKKN)
			{
				hashSet.Add(photonView.gameObject);
			}
		}
		foreach (GameObject obfjphlbfol in hashSet)
		{
			this.EFDAOHIDIIF(obfjphlbfol, true);
		}
		foreach (PhotonView photonView2 in this.HFCMPEKPBAM.Values)
		{
			if (photonView2.ownerId == PHIGECOLKKN)
			{
				photonView2.ownerId = photonView2.CreatorActorNr;
			}
		}
	}

	// Token: 0x0600AF00 RID: 44800 RVA: 0x00406794 File Offset: 0x00404994
	public void SetApp(string PPNEJGFIAJP, string MHMPNKGMNMJ)
	{
		this.KAIBLIKEDHM = PPNEJGFIAJP.Trim();
		if (!string.IsNullOrEmpty(MHMPNKGMNMJ))
		{
			PhotonNetwork.gameVersion = MHMPNKGMNMJ.Trim();
		}
	}

	// Token: 0x0600AF01 RID: 44801 RVA: 0x004067B8 File Offset: 0x004049B8
	private bool OELIGNFABAJ()
	{
		AuthenticationValues authenticationValues;
		if ((authenticationValues = this.AuthValues) == null)
		{
			authenticationValues = new AuthenticationValues
			{
				UserId = this.PlayerName
			};
		}
		AuthenticationValues gpdfhodmoij = authenticationValues;
		if (this.AuthMode == AuthModeOption.Auth)
		{
			return this.OpAuthenticate(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.OGLFGPKHEHH);
		}
		return this.OpAuthenticateOnce(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.EncryptionMode, PhotonNetwork.PhotonServerSettings.Protocol);
	}

	// Token: 0x0600AF02 RID: 44802 RVA: 0x00406858 File Offset: 0x00404A58
	private void MJLFCEHBMGL()
	{
		Debug.Log("SendVacantViewIds()");
		List<int> list = new List<int>();
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if (!photonView.isOwnerActive)
			{
				list.Add(photonView.viewID);
			}
		}
		Debug.Log("Sending vacant view IDs. Length: " + list.Count);
		this.OpRaiseEvent(211, list.ToArray(), true, null);
	}

	// Token: 0x0600AF03 RID: 44803 RVA: 0x00406908 File Offset: 0x00404B08
	private bool JKOFIOHPEAB(object CFKDMFFFPJK, object GOLMELKEAFO)
	{
		if (CFKDMFFFPJK == null || GOLMELKEAFO == null)
		{
			return CFKDMFFFPJK != null || GOLMELKEAFO == null;
		}
		if (!CFKDMFFFPJK.Equals(GOLMELKEAFO))
		{
			if (CFKDMFFFPJK is Vector3)
			{
				Vector3 mpnmoonbmii = (Vector3)CFKDMFFFPJK;
				Vector3 biccgcfnnlp = (Vector3)GOLMELKEAFO;
				if (mpnmoonbmii.AlmostEquals(biccgcfnnlp, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Vector2)
			{
				Vector2 mpnmoonbmii2 = (Vector2)CFKDMFFFPJK;
				Vector2 biccgcfnnlp2 = (Vector2)GOLMELKEAFO;
				if (mpnmoonbmii2.AlmostEquals(biccgcfnnlp2, PhotonNetwork.precisionForVectorSynchronization))
				{
					return false;
				}
			}
			else if (CFKDMFFFPJK is Quaternion)
			{
				Quaternion mpnmoonbmii3 = (Quaternion)CFKDMFFFPJK;
				Quaternion biccgcfnnlp3 = (Quaternion)GOLMELKEAFO;
				if (mpnmoonbmii3.AlmostEquals(biccgcfnnlp3, PhotonNetwork.precisionForQuaternionSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is float)
			{
				float mpnmoonbmii4 = (float)CFKDMFFFPJK;
				float biccgcfnnlp4 = (float)GOLMELKEAFO;
				if (mpnmoonbmii4.AlmostEquals(biccgcfnnlp4, PhotonNetwork.precisionForFloatSynchronization))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x0600AF04 RID: 44804 RVA: 0x00406A05 File Offset: 0x00404C05
	// (set) Token: 0x0600AF28 RID: 44840 RVA: 0x00408A14 File Offset: 0x00406C14
	public string MasterServerAddress { get; protected internal set; }

	// Token: 0x0600AF05 RID: 44805 RVA: 0x00406A10 File Offset: 0x00404C10
	protected internal bool FKFMPOMNGJE(int PHIGECOLKKN, bool PANGJAJJOLO)
	{
		bool flag = this.GHOANKKKIAI() != PHIGECOLKKN;
		if (!flag || !this.mActors.ContainsKey(PHIGECOLKKN))
		{
			return false;
		}
		if (PANGJAJJOLO && !this.OIOPKLGHDGM(31, new ExitGames.Client.Photon.Hashtable
		{
			{
				1,
				PHIGECOLKKN
			}
		}, true, null))
		{
			return false;
		}
		this.hasSwitchedMC = true;
		this.CurrentRoom.EJLAPIIGIMI = PHIGECOLKKN;
		PhotonNetworkingMessage lelhnddckco = PhotonNetworkingMessage.OnLeftLobby;
		object[] array = new object[0];
		array[0] = this.NLCNFHENKAJ(PHIGECOLKKN);
		BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array);
		return false;
	}

	// Token: 0x0600AF06 RID: 44806 RVA: 0x004055DD File Offset: 0x004037DD
	private void GAJOHMJPDND(int HOBFECDCMIL)
	{
		this.IDIKEJLLFFP.Remove(HOBFECDCMIL);
	}

	// Token: 0x0600AF07 RID: 44807 RVA: 0x00406AA4 File Offset: 0x00404CA4
	public void RunViewUpdate()
	{
		if (!PhotonNetwork.connected || PhotonNetwork.offlineMode || this.mActors == null)
		{
			return;
		}
		if (this.mActors.Count <= 1)
		{
			return;
		}
		int num = 0;
		this.PCFOAMAODBD.Reset();
		List<int> list = null;
		foreach (KeyValuePair<int, PhotonView> keyValuePair in this.HFCMPEKPBAM)
		{
			PhotonView value = keyValuePair.Value;
			if (value == null)
			{
				string format = "PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com";
				Dictionary<int, PhotonView>.Enumerator enumerator;
				KeyValuePair<int, PhotonView> keyValuePair2 = enumerator.Current;
				Debug.LogError(string.Format(format, keyValuePair2.Key));
				if (list == null)
				{
					list = new List<int>(4);
				}
				List<int> list2 = list;
				KeyValuePair<int, PhotonView> keyValuePair3 = enumerator.Current;
				list2.Add(keyValuePair3.Key);
			}
			else if (value.synchronization != ViewSynchronization.Off && value.isMine && value.gameObject.activeInHierarchy)
			{
				if (!this.FFBGBLFBHOK.Contains(value.group))
				{
					object[] array = this.OAMPHAGPLEL(value);
					if (array != null)
					{
						if (value.synchronization == ViewSynchronization.ReliableDeltaCompressed || value.PBIDCPBMFKJ)
						{
							ExitGames.Client.Photon.Hashtable hashtable = null;
							if (!this.ECMNAOLPNBO.TryGetValue((int)value.group, out hashtable))
							{
								hashtable = new ExitGames.Client.Photon.Hashtable(BNGIGHBHPEH.ObjectsInOneUpdate);
								this.ECMNAOLPNBO[(int)value.group] = hashtable;
							}
							hashtable.Add((byte)(hashtable.Count + 10), array);
							num++;
							if (hashtable.Count >= BNGIGHBHPEH.ObjectsInOneUpdate)
							{
								num -= hashtable.Count;
								this.PCFOAMAODBD.InterestGroup = value.group;
								hashtable[0] = PhotonNetwork.ServerTimestamp;
								if (this.PKCNHOKCLJH >= 0)
								{
									hashtable[1] = this.PKCNHOKCLJH;
								}
								this.OpRaiseEvent(206, hashtable, true, this.PCFOAMAODBD);
								hashtable.Clear();
							}
						}
						else
						{
							ExitGames.Client.Photon.Hashtable hashtable2 = null;
							if (!this.ABIMEMLJLPA.TryGetValue((int)value.group, out hashtable2))
							{
								hashtable2 = new ExitGames.Client.Photon.Hashtable(BNGIGHBHPEH.ObjectsInOneUpdate);
								this.ABIMEMLJLPA[(int)value.group] = hashtable2;
							}
							hashtable2.Add((byte)(hashtable2.Count + 10), array);
							num++;
							if (hashtable2.Count >= BNGIGHBHPEH.ObjectsInOneUpdate)
							{
								num -= hashtable2.Count;
								this.PCFOAMAODBD.InterestGroup = value.group;
								hashtable2[0] = PhotonNetwork.ServerTimestamp;
								if (this.PKCNHOKCLJH >= 0)
								{
									hashtable2[1] = this.PKCNHOKCLJH;
								}
								this.OpRaiseEvent(201, hashtable2, false, this.PCFOAMAODBD);
								hashtable2.Clear();
							}
						}
					}
				}
			}
		}
		if (list != null)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				this.HFCMPEKPBAM.Remove(list[i]);
				i++;
			}
		}
		if (num == 0)
		{
			return;
		}
		foreach (int num2 in this.ECMNAOLPNBO.Keys)
		{
			this.PCFOAMAODBD.InterestGroup = (byte)num2;
			ExitGames.Client.Photon.Hashtable hashtable3 = this.ECMNAOLPNBO[num2];
			if (hashtable3.Count != 0)
			{
				hashtable3[0] = PhotonNetwork.ServerTimestamp;
				if (this.PKCNHOKCLJH >= 0)
				{
					hashtable3[1] = this.PKCNHOKCLJH;
				}
				this.OpRaiseEvent(206, hashtable3, true, this.PCFOAMAODBD);
				hashtable3.Clear();
			}
		}
		foreach (int num3 in this.ABIMEMLJLPA.Keys)
		{
			this.PCFOAMAODBD.InterestGroup = (byte)num3;
			ExitGames.Client.Photon.Hashtable hashtable4 = this.ABIMEMLJLPA[num3];
			if (hashtable4.Count != 0)
			{
				hashtable4[0] = PhotonNetwork.ServerTimestamp;
				if (this.PKCNHOKCLJH >= 0)
				{
					hashtable4[1] = this.PKCNHOKCLJH;
				}
				this.OpRaiseEvent(201, hashtable4, false, this.PCFOAMAODBD);
				hashtable4.Clear();
			}
		}
	}

	// Token: 0x0600AF08 RID: 44808 RVA: 0x00406F90 File Offset: 0x00405190
	private void ODLHBPMCMEB()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = -1;
		this.OpRaiseEvent(116, hashtable, true, null);
	}

	// Token: 0x0600AF09 RID: 44809 RVA: 0x00406FC4 File Offset: 0x004051C4
	private void FHILECJLHMM(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		this.IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	// Token: 0x0600AF0A RID: 44810 RVA: 0x00406FD3 File Offset: 0x004051D3
	private void LNKHKBBMMIA(ServerConnection DPNHODJHGJL)
	{
		this.<NFFGNBHFDFM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AF0B RID: 44811 RVA: 0x00406FDC File Offset: 0x004051DC
	public void OpCleanRpcBuffer(int CFLLNEOHNFD)
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				CFLLNEOHNFD
			}
		};
		this.OpRaiseEvent(200, null, true, bplhapbmggc);
	}

	// Token: 0x0600AF0C RID: 44812 RVA: 0x00407017 File Offset: 0x00405217
	protected internal string DCHLIDBMJPK()
	{
		return string.Format("PhotonView with ID ", PhotonNetwork.gameVersion, ".lastCheckpoint.time");
	}

	// Token: 0x0600AF0D RID: 44813 RVA: 0x00407030 File Offset: 0x00405230
	public void BEFPEELGJIE(StatusCode FIIDDDBNCLD)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
		{
			Debug.Log(string.Format("_ProjectionInv", FIIDDDBNCLD.ToString(), this.EBAJHBFJFCL()));
		}
		switch (FIIDDDBNCLD)
		{
		case (StatusCode)(-111):
		case (StatusCode)(-109):
		case (StatusCode)(-108):
		case (StatusCode)(-107):
			if (this.IsInitialConnect)
			{
				object[] array = new object[0];
				array[1] = FIIDDDBNCLD;
				array[1] = "_DistanceParams";
				array[4] = base.ServerAddress;
				array[3] = " ";
				Debug.LogWarning(string.Concat(array));
				this.IsInitialConnect = false;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)(-20);
				object[] array2 = new object[0];
				array2[1] = disconnectCause;
				BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco, array2);
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnPhotonSerializeView, new object[]
				{
					disconnectCause
				});
			}
			if (this.IJHIEINKMFP() != null)
			{
				this.IJHIEINKMFP().NNIDGJOPJOI(null);
			}
			this.Disconnect();
			return;
		case (StatusCode)(-110):
			if (this.IsInitialConnect)
			{
				if (!this.IDOAHFHJJJE)
				{
					object[] array3 = new object[3];
					array3[1] = FIIDDDBNCLD;
					array3[0] = "FileMenu";
					array3[2] = base.ServerAddress;
					array3[2] = "_ScreenResolution";
					Debug.LogWarning(string.Concat(array3));
					this.IsInitialConnect = true;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)(-28);
					object[] array4 = new object[1];
					array4[1] = disconnectCause;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco2, array4);
				}
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco3 = (PhotonNetworkingMessage)(-94);
				object[] array5 = new object[0];
				array5[0] = disconnectCause;
				BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco3, array5);
			}
			if (this.AuthValues != null)
			{
				this.IJHIEINKMFP().AIOHGAFEHJG(null);
			}
			this.Disconnect();
			return;
		default:
			switch (FIIDDDBNCLD)
			{
			case (StatusCode)(-31):
			case (StatusCode)(-30):
			{
				this.IsInitialConnect = true;
				this.State = ClientState.PeerCreated;
				if (this.AuthValues != null)
				{
					this.IJHIEINKMFP().AIOHGAFEHJG(null);
				}
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.CLOLHKCFMJP((PhotonNetworkingMessage)(-29), new object[]
				{
					disconnectCause
				});
				return;
			}
			case (StatusCode)(-29):
				if (this.State == (ClientState)(-98))
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log(".lastCheckpoint.powerupsScore");
					}
					this.LNKHKBBMMIA((ServerConnection)3);
					if (this.IJHIEINKMFP() != null)
					{
						this.IJHIEINKMFP().NJJEJBOAEDG(null);
					}
				}
				if (this.State == ClientState.Queued)
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)6)
					{
						Debug.Log("settings.arcsdestroydelay");
					}
					this.LNKHKBBMMIA(ServerConnection.GameServer);
					this.State = ClientState.ConnectedToGameserver;
				}
				if (this.EBAJHBFJFCL() == (ClientState)(-69))
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
					{
						Debug.Log("_TimeX");
					}
					this.EHALCLFLGJF = ServerConnection.GameServer;
					this.JNPKDLEMJFN(ClientState.QueuedComingFromGameserver);
					if (this.IsInitialConnect)
					{
						this.IsInitialConnect = false;
						BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnLeftRoom, new object[1]);
					}
				}
				if (base.TransportProtocol != (ConnectionProtocol)6)
				{
					if (this.IGDBHCGGHFF() == (ServerConnection)8 || this.AuthMode == AuthModeOption.Auth)
					{
						base.EstablishEncryption();
					}
					return;
				}
				if (this.DebugOut == (DebugLevel)8)
				{
					Debug.Log("[PlayerBase] Starting game from: ");
				}
				goto IL_1AC;
			case (StatusCode)(-28):
				this.DMCPHGDNGDB = false;
				this.POHIMACBDGL = true;
				if (this.NJIFBFEHJKH() == ServerConnection.MasterServer)
				{
					this.BOJKDNJHBNG();
				}
				if (this.IGDBHCGGHFF() == ServerConnection.MasterServer)
				{
					this.ONELBBFGFOM();
				}
				if (this.EBAJHBFJFCL() == ClientState.PeerCreated)
				{
					if (this.Connect(this.GameServerAddress, ServerConnection.MasterServer))
					{
						this.JNPKDLEMJFN(ClientState.Joining);
					}
				}
				else if (this.State == (ClientState)(-69) || this.State == (ClientState)122)
				{
					this.KHKMFIFGPCH(ServerConnection.MasterServer);
					if (this.Connect(this.MasterServerAddress, ServerConnection.GameServer))
					{
						this.State = ClientState.Leaving;
					}
				}
				else
				{
					if (this.IDOAHFHJJJE)
					{
						return;
					}
					if (this.IJHIEINKMFP() != null)
					{
						this.IJHIEINKMFP().NJJEJBOAEDG(null);
					}
					this.IsInitialConnect = false;
					this.State = ClientState.Uninitialized;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom, new object[0]);
				}
				return;
			case (StatusCode)(-27):
				if (this.IsInitialConnect)
				{
					Debug.LogError("AvatarImage" + base.ServerAddress + ",");
					if (base.ServerAddress == null || base.ServerAddress.StartsWith("Moved event"))
					{
						Debug.LogWarning("_Value6");
						if (base.ServerAddress == this.GameServerAddress)
						{
							Debug.LogWarning("bad");
						}
					}
					this.State = ClientState.Uninitialized;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					this.IsInitialConnect = true;
					PhotonNetworkingMessage lelhnddckco4 = (PhotonNetworkingMessage)125;
					object[] array6 = new object[0];
					array6[1] = disconnectCause;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco4, array6);
				}
				else
				{
					this.JNPKDLEMJFN(ClientState.Uninitialized);
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					PhotonNetworkingMessage lelhnddckco5 = (PhotonNetworkingMessage)49;
					object[] array7 = new object[0];
					array7[1] = disconnectCause;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco5, array7);
				}
				this.Disconnect();
				return;
			case (StatusCode)(-23):
				return;
			}
			Debug.LogError("SetScale" + FIIDDDBNCLD);
			return;
		case (StatusCode)(-102):
			break;
		case (StatusCode)(-101):
		{
			Debug.LogError("_Value2" + FIIDDDBNCLD + "Tab2Content");
			AuthenticationValues authenticationValues;
			if ((authenticationValues = this.IJHIEINKMFP()) == null)
			{
				AuthenticationValues authenticationValues2 = new AuthenticationValues();
				authenticationValues2.JCECBNKFODG(this.PlayerName);
				authenticationValues = authenticationValues2;
			}
			AuthenticationValues gpdfhodmoij = authenticationValues;
			this.BCCNNNLOADO(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.OGLFGPKHEHH);
			return;
		}
		}
		IL_1AC:
		this.IDOAHFHJJJE = false;
		if (this.IGDBHCGGHFF() == (ServerConnection)5)
		{
			this.State = (ClientState)122;
			if (!this.DMCPHGDNGDB && this.CloudRegion == CloudRegionCode.cae)
			{
				this.HFBOBEKKBHK(this.KAIBLIKEDHM);
			}
		}
		if (this.NJIFBFEHJKH() != ServerConnection.MasterServer && (this.AuthMode == AuthModeOption.Auth || this.AuthMode == AuthModeOption.Auth))
		{
			object[] array8 = new object[7];
			array8[1] = "Unable to get a reward! Try again?";
			array8[0] = this.DMCPHGDNGDB;
			array8[6] = "EventSystem";
			array8[2] = this.AuthMode;
			Debug.Log(string.Concat(array8));
		}
		else if (!this.DMCPHGDNGDB && (!this.IsUsingNameServer || this.CAFLFPLLMNC() != CloudRegionCode.jp))
		{
			this.DMCPHGDNGDB = this.GHBFBICEHBK();
			if (this.DMCPHGDNGDB)
			{
				this.JNPKDLEMJFN((ClientState)111);
			}
		}
	}

	// Token: 0x0600AF0E RID: 44814 RVA: 0x00407684 File Offset: 0x00405884
	internal GameObject GMINENGCFOE(ExitGames.Client.Photon.Hashtable NNNJPMDHPHH, PhotonPlayer OGKJFFANGMC, GameObject HHLFBCNFLAO)
	{
		string text = (string)NNNJPMDHPHH[0];
		int amciaillaib = (int)NNNJPMDHPHH[8];
		int num = (int)NNNJPMDHPHH[1];
		Vector3 vector;
		if (NNNJPMDHPHH.ContainsKey(1))
		{
			vector = (Vector3)NNNJPMDHPHH[1];
		}
		else
		{
			vector = Vector3.zero;
		}
		Quaternion quaternion = Quaternion.identity;
		if (NNNJPMDHPHH.ContainsKey(7))
		{
			quaternion = (Quaternion)NNNJPMDHPHH[0];
		}
		byte b = 1;
		if (NNNJPMDHPHH.ContainsKey(1))
		{
			b = (byte)NNNJPMDHPHH[3];
		}
		short num2 = 0;
		if (NNNJPMDHPHH.ContainsKey(8))
		{
			num2 = (short)NNNJPMDHPHH[7];
		}
		int[] array;
		if (NNNJPMDHPHH.ContainsKey(0))
		{
			array = (int[])NNNJPMDHPHH[5];
		}
		else
		{
			int[] array2 = new int[1];
			array2[1] = num;
			array = array2;
		}
		object[] array3;
		if (NNNJPMDHPHH.ContainsKey(1))
		{
			array3 = (object[])NNNJPMDHPHH[5];
		}
		else
		{
			array3 = null;
		}
		if (b != 0 && !this.CHIJNBAJIHE.Contains(b))
		{
			return null;
		}
		if (this.EGNHNBODKHP != null)
		{
			GameObject gameObject = this.EGNHNBODKHP.Instantiate(text, vector, quaternion);
			PhotonView[] photonViewsInChildren = gameObject.GetPhotonViewsInChildren();
			if (photonViewsInChildren.Length != array.Length)
			{
				throw new Exception("CameraFilterPack/Blend2Camera_HardLight");
			}
			for (int i = 0; i < photonViewsInChildren.Length; i += 0)
			{
				photonViewsInChildren[i].GEKLBLEBECG = true;
				photonViewsInChildren[i].viewID = 1;
				photonViewsInChildren[i].prefix = (int)num2;
				photonViewsInChildren[i].instantiationId = num;
				photonViewsInChildren[i].isRuntimeInstantiated = false;
				photonViewsInChildren[i].NJDPOGADFJN = array3;
				photonViewsInChildren[i].GEKLBLEBECG = false;
				photonViewsInChildren[i].viewID = array[i];
			}
			gameObject.SendMessage(BNGIGHBHPEH.BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, amciaillaib, null), SendMessageOptions.RequireReceiver);
			return gameObject;
		}
		else
		{
			if (HHLFBCNFLAO == null)
			{
				if (!BNGIGHBHPEH.UsePrefabCache || !BNGIGHBHPEH.PrefabCache.TryGetValue(text, out HHLFBCNFLAO))
				{
					HHLFBCNFLAO = (GameObject)Resources.Load(text, typeof(GameObject));
					if (BNGIGHBHPEH.UsePrefabCache)
					{
						BNGIGHBHPEH.PrefabCache.Add(text, HHLFBCNFLAO);
					}
				}
				if (HHLFBCNFLAO == null)
				{
					Debug.LogError("#tryagain" + text + "_TimeX");
					return null;
				}
			}
			PhotonView[] photonViewsInChildren2 = HHLFBCNFLAO.GetPhotonViewsInChildren();
			if (photonViewsInChildren2.Length != array.Length)
			{
				throw new Exception("Using constructor for new PingNativeDynamic()");
			}
			for (int j = 1; j < array.Length; j++)
			{
				photonViewsInChildren2[j].CHLIDEOBECE(array[j]);
				photonViewsInChildren2[j].BIMKLKFMOCB((int)num2);
				photonViewsInChildren2[j].instantiationId = num;
				photonViewsInChildren2[j].isRuntimeInstantiated = false;
			}
			this.MLHNKIDCCHM(num, array3);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(HHLFBCNFLAO, vector, quaternion);
			for (int k = 1; k < array.Length; k++)
			{
				photonViewsInChildren2[k].viewID = 0;
				photonViewsInChildren2[k].prefix = -1;
				photonViewsInChildren2[k].prefixBackup = -1;
				photonViewsInChildren2[k].instantiationId = -1;
				photonViewsInChildren2[k].isRuntimeInstantiated = true;
			}
			this.GAJOHMJPDND(num);
			gameObject2.SendMessage(BNGIGHBHPEH.BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, amciaillaib, null), SendMessageOptions.DontRequireReceiver);
			return gameObject2;
		}
	}

	// Token: 0x0600AF0F RID: 44815 RVA: 0x00407A24 File Offset: 0x00405C24
	protected internal void DKACLKKBLBO(object EPDDBAPELGI)
	{
		if (!PhotonNetwork.automaticallySyncScene || !PhotonNetwork.isMasterClient || PhotonNetwork.room == null)
		{
			return;
		}
		if (EPDDBAPELGI == null)
		{
			Debug.LogError("Parameter levelId can't be null!");
			return;
		}
		if (PhotonNetwork.room.CustomProperties.ContainsKey("curScn"))
		{
			object obj = PhotonNetwork.room.CustomProperties["curScn"];
			if (obj is int && SceneManagerHelper.ActiveSceneBuildIndex == (int)obj)
			{
				return;
			}
			if (obj is string && SceneManagerHelper.ActiveSceneName != null && SceneManagerHelper.ActiveSceneName.Equals((string)obj))
			{
				return;
			}
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		if (EPDDBAPELGI is int)
		{
			hashtable["curScn"] = (int)EPDDBAPELGI;
		}
		else if (EPDDBAPELGI is string)
		{
			hashtable["curScn"] = (string)EPDDBAPELGI;
		}
		else
		{
			Debug.LogError("Parameter levelId must be int or string!");
		}
		PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		this.SendOutgoingCommands();
	}

	// Token: 0x0600AF10 RID: 44816 RVA: 0x00407B44 File Offset: 0x00405D44
	public void OpRemoveCompleteCache()
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			Receivers = ReceiverGroup.MasterClient
		};
		this.OpRaiseEvent(0, null, true, bplhapbmggc);
	}

	// Token: 0x0600AF11 RID: 44817 RVA: 0x00406FC4 File Offset: 0x004051C4
	private void MIEGGLGIPBJ(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		this.IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	// Token: 0x0600AF12 RID: 44818 RVA: 0x00407B74 File Offset: 0x00405D74
	public BNGIGHBHPEH(string OBCEIJGMKGB, ConnectionProtocol FDGOINDINNH) : base(FDGOINDINNH)
	{
		base.Listener = this;
		base.LimitOfUnreliableCommands = 40;
		this.lobby = TypedLobby.Default;
		this.PlayerName = OBCEIJGMKGB;
		this.LocalPlayer = new PhotonPlayer(true, -1, this.OBCEIJGMKGB);
		this.EGJBHECFAOH(this.LocalPlayer.ID, this.LocalPlayer);
		this.CPLBCMDIGNB = new Dictionary<string, int>(PhotonNetwork.PhotonServerSettings.RpcList.Count);
		for (int i = 0; i < PhotonNetwork.PhotonServerSettings.RpcList.Count; i++)
		{
			string key = PhotonNetwork.PhotonServerSettings.RpcList[i];
			this.CPLBCMDIGNB[key] = i;
		}
		this.State = ClientState.PeerCreated;
	}

	// Token: 0x0600AF13 RID: 44819 RVA: 0x00407CF4 File Offset: 0x00405EF4
	private void NGAEPLGAGAL(int KHACEEGCPEP)
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				KHACEEGCPEP
			}
		};
		this.OpRaiseEvent(202, null, true, bplhapbmggc);
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x0600AF14 RID: 44820 RVA: 0x00407D2F File Offset: 0x00405F2F
	protected internal int LALFOLKNJJD
	{
		get
		{
			return (!this.POHIMACBDGL && this.DJIOCIPPBMK != 0) ? (Environment.TickCount - this.DJIOCIPPBMK) : 0;
		}
	}

	// Token: 0x0600AF15 RID: 44821 RVA: 0x00407D59 File Offset: 0x00405F59
	protected internal void POPMDHDDMGJ()
	{
		BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnJoinedLobby, new object[]
		{
			PhotonNetwork.masterClient
		});
	}

	// Token: 0x0600AF16 RID: 44822 RVA: 0x00407D6F File Offset: 0x00405F6F
	protected internal void ENAIECJFPHM(List<Region> DPNHODJHGJL)
	{
		this.<GMPLFLCBMGI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AF17 RID: 44823 RVA: 0x00407D78 File Offset: 0x00405F78
	public ClientState EBAJHBFJFCL()
	{
		return this.<CKEGJBJJPEC>k__BackingField;
	}

	// Token: 0x0600AF18 RID: 44824 RVA: 0x00407D80 File Offset: 0x00405F80
	public static void CLOLHKCFMJP(PhotonNetworkingMessage LELHNDDCKCO, object[] GNNEKCBOBEG)
	{
		HashSet<GameObject> hashSet;
		if (PhotonNetwork.SendMonoMessageTargets != null)
		{
			hashSet = PhotonNetwork.SendMonoMessageTargets;
		}
		else
		{
			hashSet = PhotonNetwork.FindGameObjectsWithComponent(PhotonNetwork.SendMonoMessageTargetType);
		}
		string methodName = LELHNDDCKCO.ToString();
		object value = (GNNEKCBOBEG == null || GNNEKCBOBEG.Length != 0) ? GNNEKCBOBEG : GNNEKCBOBEG[1];
		foreach (GameObject gameObject in hashSet)
		{
			if (gameObject != null)
			{
				gameObject.SendMessage(methodName, value, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x0040FA3D File Offset: 0x0040DC3D
	// (set) Token: 0x0600AF19 RID: 44825 RVA: 0x00407E30 File Offset: 0x00406030
	public bool IsUsingNameServer { get; protected internal set; }

	// Token: 0x0600AF1A RID: 44826 RVA: 0x00407E3C File Offset: 0x0040603C
	protected internal void MBCHEFNAJFH(ExitGames.Client.Photon.Hashtable LKGFKFMABPG, int BGNEKPOLEEP = 0)
	{
		if (LKGFKFMABPG == null || !LKGFKFMABPG.ContainsKey(0))
		{
			Debug.LogError("Malformed RPC; this should never occur. Content: " + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		int num = (int)LKGFKFMABPG[0];
		int num2 = 0;
		if (LKGFKFMABPG.ContainsKey(1))
		{
			num2 = (int)((short)LKGFKFMABPG[1]);
		}
		string text;
		if (LKGFKFMABPG.ContainsKey(5))
		{
			int num3 = (int)((byte)LKGFKFMABPG[5]);
			if (num3 > PhotonNetwork.PhotonServerSettings.RpcList.Count - 1)
			{
				Debug.LogError("Could not find RPC with index: " + num3 + ". Going to ignore! Check PhotonServerSettings.RpcList");
				return;
			}
			text = PhotonNetwork.PhotonServerSettings.RpcList[num3];
		}
		else
		{
			text = (string)LKGFKFMABPG[3];
		}
		object[] array = null;
		if (LKGFKFMABPG.ContainsKey(4))
		{
			array = (object[])LKGFKFMABPG[4];
		}
		if (array == null)
		{
			array = new object[0];
		}
		PhotonView photonView = this.GetPhotonView(num);
		if (photonView == null)
		{
			int num4 = num / PhotonNetwork.MAX_VIEW_IDS;
			bool flag = num4 == this.LocalPlayer.ID;
			bool flag2 = num4 == BGNEKPOLEEP;
			if (flag)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"Received RPC \"",
					text,
					"\" for viewID ",
					num,
					" but this PhotonView does not exist! View was/is ours.",
					(!flag2) ? " Remote called." : " Owner called.",
					" By: ",
					BGNEKPOLEEP
				}));
			}
			else
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"Received RPC \"",
					text,
					"\" for viewID ",
					num,
					" but this PhotonView does not exist! Was remote PV.",
					(!flag2) ? " Remote called." : " Owner called.",
					" By: ",
					BGNEKPOLEEP,
					" Maybe GO was destroyed but RPC not cleaned up."
				}));
			}
			return;
		}
		if (photonView.prefix != num2)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Received RPC \"",
				text,
				"\" on viewID ",
				num,
				" with a prefix of ",
				num2,
				", our prefix is ",
				photonView.prefix,
				". The RPC has been ignored."
			}));
			return;
		}
		if (string.IsNullOrEmpty(text))
		{
			Debug.LogError("Malformed RPC; this should never occur. Content: " + SupportClass.DictionaryToString(LKGFKFMABPG));
			return;
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Received RPC: " + text);
		}
		if (photonView.group != 0 && !this.CHIJNBAJIHE.Contains(photonView.group))
		{
			return;
		}
		Type[] array2 = new Type[0];
		if (array.Length > 0)
		{
			array2 = new Type[array.Length];
			int num5 = 0;
			foreach (object obj in array)
			{
				if (obj == null)
				{
					array2[num5] = null;
				}
				else
				{
					array2[num5] = obj.GetType();
				}
				num5++;
			}
		}
		int num6 = 0;
		int num7 = 0;
		if (!PhotonNetwork.UseRpcMonoBehaviourCache || photonView.HFCEJMOIGDF == null || photonView.HFCEJMOIGDF.Length == 0)
		{
			photonView.RefreshRpcMonoBehaviourCache();
		}
		for (int j = 0; j < photonView.HFCEJMOIGDF.Length; j++)
		{
			MonoBehaviour monoBehaviour = photonView.HFCEJMOIGDF[j];
			if (monoBehaviour == null)
			{
				Debug.LogError("ERROR You have missing MonoBehaviours on your gameobjects!");
			}
			else
			{
				Type type = monoBehaviour.GetType();
				List<MethodInfo> list = null;
				if (!this.MNKFMEHFNKJ.TryGetValue(type, out list))
				{
					List<MethodInfo> methods = SupportClass.GetMethods(type, typeof(PunRPC));
					this.MNKFMEHFNKJ[type] = methods;
					list = methods;
				}
				if (list != null)
				{
					for (int k = 0; k < list.Count; k++)
					{
						MethodInfo methodInfo = list[k];
						if (methodInfo.Name.Equals(text))
						{
							num7++;
							ParameterInfo[] cachedParemeters = methodInfo.GetCachedParemeters();
							if (cachedParemeters.Length == array2.Length)
							{
								if (this.IHAJPLJACML(cachedParemeters, array2))
								{
									num6++;
									object obj2 = methodInfo.Invoke(monoBehaviour, array);
									if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
									{
										monoBehaviour.StartCoroutine((IEnumerator)obj2);
									}
								}
							}
							else if (cachedParemeters.Length - 1 == array2.Length)
							{
								if (this.IHAJPLJACML(cachedParemeters, array2) && cachedParemeters[cachedParemeters.Length - 1].ParameterType == typeof(PhotonMessageInfo))
								{
									num6++;
									int amciaillaib = (int)LKGFKFMABPG[2];
									object[] array3 = new object[array.Length + 1];
									array.CopyTo(array3, 0);
									array3[array3.Length - 1] = new PhotonMessageInfo(this.ICMGDHDNIJD(BGNEKPOLEEP), amciaillaib, photonView);
									object obj3 = methodInfo.Invoke(monoBehaviour, array3);
									if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
									{
										monoBehaviour.StartCoroutine((IEnumerator)obj3);
									}
								}
							}
							else if (cachedParemeters.Length == 1 && cachedParemeters[0].ParameterType.IsArray)
							{
								num6++;
								object obj4 = methodInfo.Invoke(monoBehaviour, new object[]
								{
									array
								});
								if (PhotonNetwork.StartRpcsAsCoroutine && methodInfo.ReturnType == typeof(IEnumerator))
								{
									monoBehaviour.StartCoroutine((IEnumerator)obj4);
								}
							}
						}
					}
				}
			}
		}
		if (num6 != 1)
		{
			string text2 = string.Empty;
			foreach (Type type2 in array2)
			{
				if (text2 != string.Empty)
				{
					text2 += ", ";
				}
				if (type2 == null)
				{
					text2 += "null";
				}
				else
				{
					text2 += type2.Name;
				}
			}
			if (num6 == 0)
			{
				if (num7 == 0)
				{
					Debug.LogError(string.Concat(new object[]
					{
						"PhotonView with ID ",
						num,
						" has no method \"",
						text,
						"\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ",
						text2
					}));
				}
				else
				{
					Debug.LogError(string.Concat(new object[]
					{
						"PhotonView with ID ",
						num,
						" has no method \"",
						text,
						"\" that takes ",
						array2.Length,
						" argument(s): ",
						text2
					}));
				}
			}
			else
			{
				Debug.LogError(string.Concat(new object[]
				{
					"PhotonView with ID ",
					num,
					" has ",
					num6,
					" methods \"",
					text,
					"\" that takes ",
					array2.Length,
					" argument(s): ",
					text2,
					". Should be just one?"
				}));
			}
		}
	}

	// Token: 0x0600AF1B RID: 44827 RVA: 0x004085C8 File Offset: 0x004067C8
	public void OpCleanRpcBuffer(PhotonView DFIHBOEOJPI)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = DFIHBOEOJPI.viewID;
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache
		};
		this.OpRaiseEvent(200, hashtable, true, bplhapbmggc);
	}

	// Token: 0x0600AF1C RID: 44828 RVA: 0x00408610 File Offset: 0x00406810
	public virtual bool AKKLKCIHNDO(string[] MIMEHFLKIIG)
	{
		if (this.POHIMACBDGL)
		{
			return true;
		}
		this.BEIPFKHGHPC = MIMEHFLKIIG;
		this.POHIMACBDGL = true;
		return base.HGLDGECBKBO(MIMEHFLKIIG);
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x00408634 File Offset: 0x00406834
	// (set) Token: 0x0600AFD8 RID: 45016 RVA: 0x00411BB6 File Offset: 0x0040FDB6
	public int PlayersInRoomsCount { get; internal set; }

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x0600AF1E RID: 44830 RVA: 0x0040863C File Offset: 0x0040683C
	// (set) Token: 0x0600AF79 RID: 44921 RVA: 0x0040B521 File Offset: 0x00409721
	public int mMasterClientId
	{
		get
		{
			if (PhotonNetwork.offlineMode)
			{
				return this.LocalPlayer.ID;
			}
			return (this.CurrentRoom != null) ? this.CurrentRoom.EJLAPIIGIMI : 0;
		}
		private set
		{
			if (this.CurrentRoom != null)
			{
				this.CurrentRoom.EJLAPIIGIMI = value;
			}
		}
	}

	// Token: 0x0600AF1F RID: 44831 RVA: 0x00408670 File Offset: 0x00406870
	public void ChangeLocalID(int LGHIPFAEONM)
	{
		if (this.LocalPlayer == null)
		{
			Debug.LogWarning(string.Format("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", this.LocalPlayer, this.mActors == null, LGHIPFAEONM));
		}
		if (this.mActors.ContainsKey(this.LocalPlayer.ID))
		{
			this.mActors.Remove(this.LocalPlayer.ID);
		}
		this.LocalPlayer.GOCPHBFMIEN(LGHIPFAEONM);
		this.mActors[this.LocalPlayer.ID] = this.LocalPlayer;
		this.LEMBPMNPHCK();
	}

	// Token: 0x0600AF20 RID: 44832 RVA: 0x00408714 File Offset: 0x00406914
	private static int IOCOEKOOLLA(PhotonPlayer[] NEJPNIGJLGP, int AIMBEFMGEFM)
	{
		if (NEJPNIGJLGP == null || NEJPNIGJLGP.Length == 0)
		{
			return -1;
		}
		int num = 15;
		for (int i = 0; i < NEJPNIGJLGP.Length; i += 0)
		{
			PhotonPlayer photonPlayer = NEJPNIGJLGP[i];
			if (photonPlayer.ID != AIMBEFMGEFM)
			{
				if (photonPlayer.ID < num)
				{
					num = photonPlayer.ID;
				}
			}
		}
		return num;
	}

	// Token: 0x0600AF21 RID: 44833 RVA: 0x00408774 File Offset: 0x00406974
	public void SetSendingEnabled(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.FFBGBLFBHOK.Add(PNFBEEBFMKC);
		}
		else
		{
			this.FFBGBLFBHOK.Remove(PNFBEEBFMKC);
		}
	}

	// Token: 0x0600AF22 RID: 44834 RVA: 0x0040879B File Offset: 0x0040699B
	public override bool OpFindFriends(string[] MIMEHFLKIIG)
	{
		if (this.POHIMACBDGL)
		{
			return false;
		}
		this.BEIPFKHGHPC = MIMEHFLKIIG;
		this.POHIMACBDGL = true;
		return base.OpFindFriends(MIMEHFLKIIG);
	}

	// Token: 0x0600AF23 RID: 44835 RVA: 0x004087BF File Offset: 0x004069BF
	public List<Region> ILANOBPPIBF()
	{
		return this.<GMPLFLCBMGI>k__BackingField;
	}

	// Token: 0x0600AF24 RID: 44836 RVA: 0x004087C8 File Offset: 0x004069C8
	protected internal void ANEENOJMDOJ(int[] HOMAECIGJEJ)
	{
		foreach (int num in HOMAECIGJEJ)
		{
			if (this.LocalPlayer.ID != num && !this.mActors.ContainsKey(num))
			{
				this.EGJBHECFAOH(num, new PhotonPlayer(false, num, string.Empty));
			}
		}
	}

	// Token: 0x0600AF25 RID: 44837 RVA: 0x00406FC4 File Offset: 0x004051C4
	private void DGEJLOAMLHI(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		this.IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	// Token: 0x0600AF26 RID: 44838 RVA: 0x00408824 File Offset: 0x00406A24
	protected internal void LBCBHNFEDDF(bool IJJEEIMFOHD)
	{
		if (this.IDIKEJLLFFP.Count > 1)
		{
			Debug.LogWarning("_Value4");
		}
		if (IJJEEIMFOHD)
		{
			HashSet<GameObject> hashSet = new HashSet<GameObject>();
			foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
			{
				if (photonView.isRuntimeInstantiated)
				{
					hashSet.Add(photonView.gameObject);
				}
			}
			foreach (GameObject obfjphlbfol in hashSet)
			{
				this.EFDAOHIDIIF(obfjphlbfol, false);
			}
		}
		this.IDIKEJLLFFP.Clear();
		PhotonNetwork.FDMEIPEKMHC = 0;
		PhotonNetwork.JIOIILCHMJL = 0;
	}

	// Token: 0x0600AF27 RID: 44839 RVA: 0x0040891C File Offset: 0x00406B1C
	protected internal void HMNMFOJCHBJ(bool IJJEEIMFOHD)
	{
		if (this.IDIKEJLLFFP.Count > 1)
		{
			Debug.LogWarning("Tab1Content");
		}
		if (IJJEEIMFOHD)
		{
			HashSet<GameObject> hashSet = new HashSet<GameObject>();
			foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
			{
				if (photonView.isRuntimeInstantiated)
				{
					hashSet.Add(photonView.gameObject);
				}
			}
			foreach (GameObject obfjphlbfol in hashSet)
			{
				this.EFDAOHIDIIF(obfjphlbfol, false);
			}
		}
		this.IDIKEJLLFFP.Clear();
		PhotonNetwork.FDMEIPEKMHC = 1;
		PhotonNetwork.JIOIILCHMJL = 1;
	}

	// Token: 0x0600AF29 RID: 44841 RVA: 0x00408A20 File Offset: 0x00406C20
	private void GIGMNEGOABN(int DIODBOKJKHM, int EJOIHHAHDLD, bool FEINGCNNFGM)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[8] = DIODBOKJKHM;
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
		raiseEventOptions.CachingOption = EventCaching.RemoveFromRoomCacheForActorsLeft;
		RaiseEventOptions raiseEventOptions2 = raiseEventOptions;
		int[] array = new int[1];
		array[1] = EJOIHHAHDLD;
		raiseEventOptions2.TargetActors = array;
		RaiseEventOptions raiseEventOptions3 = raiseEventOptions;
		this.LKLAJKINLFG(40, hashtable, false, raiseEventOptions3);
		ExitGames.Client.Photon.Hashtable hashtable2 = new ExitGames.Client.Photon.Hashtable();
		hashtable2[0] = DIODBOKJKHM;
		raiseEventOptions3 = null;
		if (!FEINGCNNFGM)
		{
			raiseEventOptions3 = new RaiseEventOptions();
			raiseEventOptions3.CachingOption = EventCaching.ReplaceCache;
			Debug.Log("CameraFilterPack/TV_Old" + DIODBOKJKHM);
		}
		this.OpRaiseEvent((byte)-181, hashtable2, false, raiseEventOptions3);
	}

	// Token: 0x0600AF2A RID: 44842 RVA: 0x00408AC4 File Offset: 0x00406CC4
	private bool MNHBLADFKAH()
	{
		AuthenticationValues authenticationValues;
		if ((authenticationValues = this.AuthValues) == null)
		{
			AuthenticationValues authenticationValues2 = new AuthenticationValues();
			authenticationValues2.JCECBNKFODG(this.PlayerName);
			authenticationValues = authenticationValues2;
		}
		AuthenticationValues gpdfhodmoij = authenticationValues;
		if (this.AuthMode == AuthModeOption.Auth)
		{
			return this.MPELLFNHBGN(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CAFLFPLLMNC().ToString(), this.CGPLAHHGMEO());
		}
		return this.OIPJGPKILNF(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.EncryptionMode, PhotonNetwork.PhotonServerSettings.Protocol);
	}

	// Token: 0x0600AF2B RID: 44843 RVA: 0x00408B64 File Offset: 0x00406D64
	private object[] HJOMIJBPHNH(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Off)
		{
			return null;
		}
		PhotonMessageInfo dagalcailln = new PhotonMessageInfo(this.LocalPlayer, PhotonNetwork.ServerTimestamp, DFIHBOEOJPI);
		this.ALPAEKHFHPP.IHFJMFNBJAD();
		this.ALPAEKHFHPP.CPIBABMPJLE(null);
		this.ALPAEKHFHPP.FADAIFFMBEL(null);
		this.ALPAEKHFHPP.SendNext(null);
		DFIHBOEOJPI.OMADJOEHOGE(this.ALPAEKHFHPP, dagalcailln);
		if (this.ALPAEKHFHPP.HCOCCCCDJDD() <= 2)
		{
			return null;
		}
		object[] array = this.ALPAEKHFHPP.NNFAJHPPFBE();
		array[0] = DFIHBOEOJPI.EIMHMIJGMHG();
		array[1] = false;
		array[1] = null;
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.UnreliableOnChange)
		{
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Unreliable)
		{
			if (this.LFAPOBNFPPO(array, DFIHBOEOJPI.EOENPICKCCO))
			{
				if (DFIHBOEOJPI.PBIDCPBMFKJ)
				{
					return null;
				}
				DFIHBOEOJPI.PBIDCPBMFKJ = true;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			else
			{
				DFIHBOEOJPI.PBIDCPBMFKJ = false;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] result = this.ILACHMNMKGF(DFIHBOEOJPI.EOENPICKCCO, array);
			DFIHBOEOJPI.EOENPICKCCO = array;
			return result;
		}
		return null;
	}

	// Token: 0x0600AF2C RID: 44844 RVA: 0x00408774 File Offset: 0x00406974
	public void HOOHJBDOKEO(byte PNFBEEBFMKC, bool CKALCHJAFBE)
	{
		if (!CKALCHJAFBE)
		{
			this.FFBGBLFBHOK.Add(PNFBEEBFMKC);
		}
		else
		{
			this.FFBGBLFBHOK.Remove(PNFBEEBFMKC);
		}
	}

	// Token: 0x0600AF2D RID: 44845 RVA: 0x00408C87 File Offset: 0x00406E87
	public void GBMLENLLNHD(bool NOKCKEBHIFJ)
	{
		if (!NOKCKEBHIFJ)
		{
			this.OpRemoveCompleteCache();
			this.ODLHBPMCMEB();
		}
		this.HMNMFOJCHBJ(false);
	}

	// Token: 0x0600AF2E RID: 44846 RVA: 0x00408CA4 File Offset: 0x00406EA4
	public bool AGAOBGGMCKN(string MDGGHHCAHKF, object GNNEKCBOBEG)
	{
		return this.OpCustom(183, new Dictionary<byte, object>
		{
			{
				74,
				MDGGHHCAHKF
			},
			{
				60,
				GNNEKCBOBEG
			}
		}, true);
	}

	// Token: 0x0600AF2F RID: 44847 RVA: 0x00408CDC File Offset: 0x00406EDC
	public bool OpCreateGame(AKBOPCNHFFJ BDMKOAGEHPM)
	{
		bool flag = this.EHALCLFLGJF == ServerConnection.GameServer;
		BDMKOAGEHPM.OnGameServer = flag;
		BDMKOAGEHPM.PlayerProperties = this.HHPBLGDNDOP();
		if (!flag)
		{
			this.AJFMHFLGCFN = BDMKOAGEHPM;
		}
		this.ELNKFMHCMBO = JoinType.CreateRoom;
		return base.OpCreateRoom(BDMKOAGEHPM);
	}

	// Token: 0x0600AF30 RID: 44848 RVA: 0x00408D21 File Offset: 0x00406F21
	private void ONELBBFGFOM()
	{
		this.mGameList = new Dictionary<string, RoomInfo>();
		this.mGameListCopy = new RoomInfo[0];
		if (this.insideLobby)
		{
			this.insideLobby = true;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateRoomFailed, new object[0]);
		}
	}

	// Token: 0x0600AF31 RID: 44849 RVA: 0x00408D58 File Offset: 0x00406F58
	private bool INCNOLHOHGI(ParameterInfo[] LFONMECHEJD, Type[] HAKMJIHLGNI)
	{
		if (LFONMECHEJD.Length < HAKMJIHLGNI.Length)
		{
			return true;
		}
		for (int i = 1; i < HAKMJIHLGNI.Length; i++)
		{
			Type parameterType = LFONMECHEJD[i].ParameterType;
			if (HAKMJIHLGNI[i] != null && !parameterType.IsAssignableFrom(HAKMJIHLGNI[i]) && (!parameterType.IsEnum || !Enum.GetUnderlyingType(parameterType).IsAssignableFrom(HAKMJIHLGNI[i])))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600AF32 RID: 44850 RVA: 0x00408DC8 File Offset: 0x00406FC8
	public object[] FetchInstantiationData(int HOBFECDCMIL)
	{
		object[] result = null;
		if (HOBFECDCMIL == 0)
		{
			return null;
		}
		this.IDIKEJLLFFP.TryGetValue(HOBFECDCMIL, out result);
		return result;
	}

	// Token: 0x0600AF33 RID: 44851 RVA: 0x00408DF0 File Offset: 0x00406FF0
	internal ExitGames.Client.Photon.Hashtable JBBJFFKDHNO(string PPFBFGBJOHM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, byte PNFBEEBFMKC, int[] BJJMPIBPLEN, object[] NOJGGCLPPAM, bool BLOGDPLEMFH)
	{
		int num = BJJMPIBPLEN[0];
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = PPFBFGBJOHM;
		if (JOPCODOJBHD != Vector3.zero)
		{
			hashtable[1] = JOPCODOJBHD;
		}
		if (LOMLCCLOIKN != Quaternion.identity)
		{
			hashtable[2] = LOMLCCLOIKN;
		}
		if (PNFBEEBFMKC != 0)
		{
			hashtable[3] = PNFBEEBFMKC;
		}
		if (BJJMPIBPLEN.Length > 1)
		{
			hashtable[4] = BJJMPIBPLEN;
		}
		if (NOJGGCLPPAM != null)
		{
			hashtable[5] = NOJGGCLPPAM;
		}
		if (this.PKCNHOKCLJH > 0)
		{
			hashtable[8] = this.PKCNHOKCLJH;
		}
		hashtable[6] = PhotonNetwork.ServerTimestamp;
		hashtable[7] = num;
		this.OpRaiseEvent(202, hashtable, true, new RaiseEventOptions
		{
			CachingOption = ((!BLOGDPLEMFH) ? EventCaching.AddToRoomCache : EventCaching.AddToRoomCacheGlobal)
		});
		return hashtable;
	}

	// Token: 0x0600AF34 RID: 44852 RVA: 0x00408F18 File Offset: 0x00407118
	public bool GetRegions()
	{
		if (this.EHALCLFLGJF != ServerConnection.NameServer)
		{
			return false;
		}
		bool flag = this.OpGetRegions(this.KAIBLIKEDHM);
		if (flag)
		{
			this.AvailableRegions = null;
		}
		return flag;
	}

	// Token: 0x0600AF35 RID: 44853 RVA: 0x00408F50 File Offset: 0x00407150
	public bool Connect(string BPMNPBDOMFO, ServerConnection HMGBJCGOLMI)
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		if (this.State == ClientState.Disconnecting)
		{
			Debug.LogError("Connect() failed. Can't connect while disconnecting (still). Current state: " + PhotonNetwork.connectionStateDetailed);
			return false;
		}
		this.PKNIJKPIKAF = HMGBJCGOLMI;
		this.BLNBCGLIOHP = BPMNPBDOMFO;
		this.KAOMEDGGMEM = string.Empty;
		this.KHKMFIFGPCH(HMGBJCGOLMI);
		bool flag = base.Connect(BPMNPBDOMFO, string.Empty, this.LLJDHHLHFME);
		if (flag)
		{
			if (HMGBJCGOLMI != ServerConnection.NameServer)
			{
				if (HMGBJCGOLMI != ServerConnection.MasterServer)
				{
					if (HMGBJCGOLMI == ServerConnection.GameServer)
					{
						this.State = ClientState.ConnectingToGameserver;
					}
				}
				else
				{
					this.State = ClientState.ConnectingToMasterserver;
				}
			}
			else
			{
				this.State = ClientState.ConnectingToNameServer;
			}
		}
		return flag;
	}

	// Token: 0x0600AF36 RID: 44854 RVA: 0x00409014 File Offset: 0x00407214
	public override bool OpJoinRandomRoom(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		this.AJFMHFLGCFN = new AKBOPCNHFFJ();
		this.AJFMHFLGCFN.Lobby = IFIMMPPLLHI.TypedLobby;
		this.AJFMHFLGCFN.ExpectedUsers = IFIMMPPLLHI.ExpectedUsers;
		this.ELNKFMHCMBO = JoinType.JoinRandomRoom;
		return base.OpJoinRandomRoom(IFIMMPPLLHI);
	}

	// Token: 0x0600AF37 RID: 44855 RVA: 0x00409051 File Offset: 0x00407251
	private void IFPPBJINADG()
	{
		this.mGameList = new Dictionary<string, RoomInfo>();
		this.mGameListCopy = new RoomInfo[0];
		if (this.insideLobby)
		{
			this.insideLobby = false;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftLobby, new object[0]);
		}
	}

	// Token: 0x0600AF38 RID: 44856 RVA: 0x00409088 File Offset: 0x00407288
	public PhotonView GetPhotonView(int NADLIACHBNO)
	{
		PhotonView photonView = null;
		this.HFCMPEKPBAM.TryGetValue(NADLIACHBNO, out photonView);
		if (photonView == null)
		{
			foreach (PhotonView photonView2 in UnityEngine.Object.FindObjectsOfType(typeof(PhotonView)) as PhotonView[])
			{
				if (photonView2.viewID == NADLIACHBNO)
				{
					if (photonView2.GEKLBLEBECG)
					{
						Debug.LogWarning("Had to lookup view that wasn't in photonViewList: " + photonView2);
					}
					return photonView2;
				}
			}
		}
		return photonView;
	}

	// Token: 0x0600AF39 RID: 44857 RVA: 0x00409109 File Offset: 0x00407309
	public virtual bool POGJKHNENIK(string[] MIMEHFLKIIG)
	{
		if (this.POHIMACBDGL)
		{
			return true;
		}
		this.BEIPFKHGHPC = MIMEHFLKIIG;
		this.POHIMACBDGL = false;
		return base.KLGCDNLPLAO(MIMEHFLKIIG);
	}

	// Token: 0x0600AF3A RID: 44858 RVA: 0x00409130 File Offset: 0x00407330
	public void FMAPFMDBMLN(StatusCode FIIDDDBNCLD)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Format("CorrectHitsScoreText", FIIDDDBNCLD.ToString(), this.EBAJHBFJFCL()));
		}
		switch (FIIDDDBNCLD)
		{
		case (StatusCode)(-49):
		case (StatusCode)(-47):
		case (StatusCode)(-46):
		case (StatusCode)(-45):
			if (this.IsInitialConnect)
			{
				object[] array = new object[]
				{
					FIIDDDBNCLD
				};
				array[0] = "skin.";
				array[8] = base.ServerAddress;
				array[1] = ".lastCheckpoint.time";
				Debug.LogWarning(string.Concat(array));
				this.IsInitialConnect = true;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)106;
				object[] array2 = new object[0];
				array2[0] = disconnectCause;
				BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco, array2);
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)40;
				object[] array3 = new object[0];
				array3[1] = disconnectCause;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco2, array3);
			}
			if (this.IJHIEINKMFP() != null)
			{
				this.AuthValues.FNCDLDJFJAM(null);
			}
			this.Disconnect();
			return;
		case (StatusCode)(-48):
			if (this.IsInitialConnect)
			{
				if (!this.IDOAHFHJJJE)
				{
					object[] array4 = new object[0];
					array4[0] = FIIDDDBNCLD;
					array4[0] = "StartButton";
					array4[6] = base.ServerAddress;
					array4[7] = "OneHand";
					Debug.LogWarning(string.Concat(array4));
					this.IsInitialConnect = false;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					PhotonNetworkingMessage lelhnddckco3 = (PhotonNetworkingMessage)(-78);
					object[] array5 = new object[0];
					array5[0] = disconnectCause;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco3, array5);
				}
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco4 = (PhotonNetworkingMessage)39;
				object[] array6 = new object[0];
				array6[0] = disconnectCause;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco4, array6);
			}
			if (this.AuthValues != null)
			{
				this.IJHIEINKMFP().FNCDLDJFJAM(null);
			}
			this.Disconnect();
			return;
		default:
			switch (FIIDDDBNCLD)
			{
			case (StatusCode)67:
			case (StatusCode)68:
			{
				this.IsInitialConnect = false;
				this.State = ClientState.Uninitialized;
				if (this.AuthValues != null)
				{
					this.IJHIEINKMFP().NJJEJBOAEDG(null);
				}
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco5 = (PhotonNetworkingMessage)(-7);
				object[] array7 = new object[0];
				array7[0] = disconnectCause;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco5, array7);
				return;
			}
			case (StatusCode)69:
				if (this.EBAJHBFJFCL() == (ClientState)(-86))
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)4)
					{
						Debug.Log(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.");
					}
					this.LNKHKBBMMIA(ServerConnection.NameServer);
					if (this.IJHIEINKMFP() != null)
					{
						this.AuthValues.AIOHGAFEHJG(null);
					}
				}
				if (this.EBAJHBFJFCL() == ClientState.Authenticated)
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)6)
					{
						Debug.Log("Inside cells:\n");
					}
					this.EHALCLFLGJF = ServerConnection.MasterServer;
					this.JNPKDLEMJFN(ClientState.PeerCreated);
				}
				if (this.EBAJHBFJFCL() == (ClientState)(-85))
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log("NEW_ACHIEVEMENT_1_26");
					}
					this.LNKHKBBMMIA(ServerConnection.MasterServer);
					this.JNPKDLEMJFN((ClientState)(-72));
					if (this.IsInitialConnect)
					{
						this.IsInitialConnect = true;
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToPhoton, new object[1]);
					}
				}
				if (base.TransportProtocol != ConnectionProtocol.Udp)
				{
					if (this.EHALCLFLGJF == (ServerConnection)3 || this.AuthMode == AuthModeOption.Auth)
					{
						base.EstablishEncryption();
					}
					return;
				}
				if (this.DebugOut == DebugLevel.INFO)
				{
					Debug.Log("true");
				}
				goto IL_1AC;
			case (StatusCode)70:
				this.DMCPHGDNGDB = false;
				this.POHIMACBDGL = false;
				if (this.EHALCLFLGJF == ServerConnection.MasterServer)
				{
					this.BJHGKICFMJP();
				}
				if (this.IGDBHCGGHFF() == ServerConnection.MasterServer)
				{
					this.ONELBBFGFOM();
				}
				if (this.EBAJHBFJFCL() == ClientState.Uninitialized)
				{
					if (this.Connect(this.GameServerAddress, ServerConnection.MasterServer))
					{
						this.JNPKDLEMJFN(ClientState.Queued);
					}
				}
				else if (this.EBAJHBFJFCL() == (ClientState)73 || this.EBAJHBFJFCL() == ClientState.ConnectingToGameserver)
				{
					this.KHKMFIFGPCH(ServerConnection.MasterServer);
					if (this.Connect(this.MasterServerAddress, ServerConnection.GameServer))
					{
						this.JNPKDLEMJFN((ClientState)(-49));
					}
				}
				else
				{
					if (this.IDOAHFHJJJE)
					{
						return;
					}
					if (this.IJHIEINKMFP() != null)
					{
						this.AuthValues.NNIDGJOPJOI(null);
					}
					this.IsInitialConnect = true;
					this.JNPKDLEMJFN(ClientState.PeerCreated);
					BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnDisconnectedFromPhoton, new object[0]);
				}
				return;
			case (StatusCode)71:
				if (this.IsInitialConnect)
				{
					Debug.LogError("caret" + base.ServerAddress + " isOwnerActive: ");
					if (base.ServerAddress == null || base.ServerAddress.StartsWith("_MainTex"))
					{
						Debug.LogWarning(" not exist");
						if (base.ServerAddress == this.GameServerAddress)
						{
							Debug.LogWarning("1");
						}
					}
					this.JNPKDLEMJFN(ClientState.PeerCreated);
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					this.IsInitialConnect = true;
					PhotonNetworkingMessage lelhnddckco6 = (PhotonNetworkingMessage)90;
					object[] array8 = new object[0];
					array8[1] = disconnectCause;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco6, array8);
				}
				else
				{
					this.JNPKDLEMJFN(ClientState.Uninitialized);
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					PhotonNetworkingMessage lelhnddckco7 = PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged;
					object[] array9 = new object[0];
					array9[0] = disconnectCause;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco7, array9);
				}
				this.Disconnect();
				return;
			case (StatusCode)75:
				return;
			}
			Debug.LogError(".ogg" + FIIDDDBNCLD);
			return;
		case (StatusCode)(-40):
			break;
		case (StatusCode)(-39):
		{
			Debug.LogError("_Value" + FIIDDDBNCLD + ".a");
			AuthenticationValues authenticationValues;
			if ((authenticationValues = this.AuthValues) == null)
			{
				authenticationValues = new AuthenticationValues
				{
					UserId = this.PlayerName
				};
			}
			AuthenticationValues gpdfhodmoij = authenticationValues;
			this.MPELLFNHBGN(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.OGLFGPKHEHH);
			return;
		}
		}
		IL_1AC:
		this.IDOAHFHJJJE = true;
		if (this.EHALCLFLGJF == ServerConnection.MasterServer)
		{
			this.State = (ClientState)(-94);
			if (!this.DMCPHGDNGDB && this.CAFLFPLLMNC() == CloudRegionCode.us)
			{
				this.CGIPKIOMHCO(this.KAIBLIKEDHM);
			}
		}
		if (this.IGDBHCGGHFF() != (ServerConnection)7 && (this.AuthMode == AuthModeOption.AuthOnce || this.AuthMode == (AuthModeOption)3))
		{
			object[] array10 = new object[8];
			array10[0] = "_InvRenderTargetSize";
			array10[1] = this.DMCPHGDNGDB;
			array10[0] = "_MainTex2";
			array10[8] = this.AuthMode;
			Debug.Log(string.Concat(array10));
		}
		else if (!this.DMCPHGDNGDB && (!this.IsUsingNameServer || this.CloudRegion != CloudRegionCode.au))
		{
			this.DMCPHGDNGDB = this.OELIGNFABAJ();
			if (this.DMCPHGDNGDB)
			{
				this.State = (ClientState)(-73);
			}
		}
	}

	// Token: 0x0600AF3B RID: 44859 RVA: 0x00409784 File Offset: 0x00407984
	private bool IHAJPLJACML(ParameterInfo[] LFONMECHEJD, Type[] HAKMJIHLGNI)
	{
		if (LFONMECHEJD.Length < HAKMJIHLGNI.Length)
		{
			return false;
		}
		for (int i = 0; i < HAKMJIHLGNI.Length; i++)
		{
			Type parameterType = LFONMECHEJD[i].ParameterType;
			if (HAKMJIHLGNI[i] != null && !parameterType.IsAssignableFrom(HAKMJIHLGNI[i]) && (!parameterType.IsEnum || !Enum.GetUnderlyingType(parameterType).IsAssignableFrom(HAKMJIHLGNI[i])))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600AF3C RID: 44860 RVA: 0x004097F4 File Offset: 0x004079F4
	protected internal void KHKMFIFGPCH(ServerConnection NKGHPPHEGCO)
	{
		ConnectionProtocol connectionProtocol = base.TransportProtocol;
		if (this.AuthMode == AuthModeOption.AuthOnceWss)
		{
			if (NKGHPPHEGCO != ServerConnection.NameServer)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): " + PhotonNetwork.PhotonServerSettings.Protocol);
				}
				connectionProtocol = PhotonNetwork.PhotonServerSettings.Protocol;
			}
			else
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).");
				}
				connectionProtocol = ConnectionProtocol.WebSocketSecure;
			}
		}
		Type type = Type.GetType("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", false);
		if (type == null)
		{
			type = Type.GetType("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", false);
		}
		if (type != null)
		{
			this.SocketImplementationConfig[ConnectionProtocol.WebSocket] = type;
			this.SocketImplementationConfig[ConnectionProtocol.WebSocketSecure] = type;
		}
		if (PhotonHandler.LEILCLLNGGH == null)
		{
			PhotonHandler.LEILCLLNGGH = typeof(PingMono);
		}
		if (base.TransportProtocol == connectionProtocol)
		{
			return;
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
		{
			Debug.LogWarning(string.Concat(new object[]
			{
				"Protocol switch from: ",
				base.TransportProtocol,
				" to: ",
				connectionProtocol,
				"."
			}));
		}
		base.TransportProtocol = connectionProtocol;
	}

	// Token: 0x0600AF3D RID: 44861 RVA: 0x00409924 File Offset: 0x00407B24
	private void LLMNFGHNIND(int DIODBOKJKHM, int EJOIHHAHDLD, bool FEINGCNNFGM)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[7] = DIODBOKJKHM;
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				EJOIHHAHDLD
			}
		};
		this.OpRaiseEvent(202, hashtable, true, raiseEventOptions);
		ExitGames.Client.Photon.Hashtable hashtable2 = new ExitGames.Client.Photon.Hashtable();
		hashtable2[0] = DIODBOKJKHM;
		raiseEventOptions = null;
		if (!FEINGCNNFGM)
		{
			raiseEventOptions = new RaiseEventOptions();
			raiseEventOptions.CachingOption = EventCaching.AddToRoomCacheGlobal;
			Debug.Log("Destroying GO as global. ID: " + DIODBOKJKHM);
		}
		this.OpRaiseEvent(204, hashtable2, true, raiseEventOptions);
	}

	// Token: 0x0600AF3E RID: 44862 RVA: 0x004099C8 File Offset: 0x00407BC8
	public virtual bool JPMHBPKKGJD(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		this.AJFMHFLGCFN = new AKBOPCNHFFJ();
		this.AJFMHFLGCFN.Lobby = IFIMMPPLLHI.TypedLobby;
		this.AJFMHFLGCFN.ExpectedUsers = IFIMMPPLLHI.ExpectedUsers;
		this.ELNKFMHCMBO = JoinType.JoinOrCreateRoom;
		return base.DEBJAENPEII(IFIMMPPLLHI);
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x0600AF3F RID: 44863 RVA: 0x00409A05 File Offset: 0x00407C05
	// (set) Token: 0x0600AF70 RID: 44912 RVA: 0x0040B089 File Offset: 0x00409289
	public TypedLobby lobby { get; set; }

	// Token: 0x0600AF40 RID: 44864 RVA: 0x00409A0D File Offset: 0x00407C0D
	private bool CGPLAHHGMEO()
	{
		return PhotonNetwork.EnableLobbyStatistics && this.NJIFBFEHJKH() == ServerConnection.MasterServer;
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x0600AF41 RID: 44865 RVA: 0x00409A25 File Offset: 0x00407C25
	// (set) Token: 0x0600AF49 RID: 44873 RVA: 0x00409DE4 File Offset: 0x00407FE4
	public PhotonPlayer LocalPlayer { get; internal set; }

	// Token: 0x0600AF42 RID: 44866 RVA: 0x00409A30 File Offset: 0x00407C30
	protected internal static bool IIHAIKHPABG(MonoBehaviour KLJMHHFGLCJ, string AOBJJJOJGGF, out MethodInfo MKLKGCPAPOC)
	{
		MKLKGCPAPOC = null;
		if (KLJMHHFGLCJ == null || string.IsNullOrEmpty(AOBJJJOJGGF))
		{
			return true;
		}
		List<MethodInfo> methods = SupportClass.GetMethods(KLJMHHFGLCJ.GetType(), null);
		for (int i = 0; i < methods.Count; i += 0)
		{
			MethodInfo methodInfo = methods[i];
			if (methodInfo.Name.Equals(AOBJJJOJGGF))
			{
				MKLKGCPAPOC = methodInfo;
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600AF43 RID: 44867 RVA: 0x00409A9C File Offset: 0x00407C9C
	private bool DHGPFGBOLGO(ParameterInfo[] LFONMECHEJD, Type[] HAKMJIHLGNI)
	{
		if (LFONMECHEJD.Length < HAKMJIHLGNI.Length)
		{
			return true;
		}
		for (int i = 1; i < HAKMJIHLGNI.Length; i++)
		{
			Type parameterType = LFONMECHEJD[i].ParameterType;
			if (HAKMJIHLGNI[i] != null && !parameterType.IsAssignableFrom(HAKMJIHLGNI[i]) && (!parameterType.IsEnum || !Enum.GetUnderlyingType(parameterType).IsAssignableFrom(HAKMJIHLGNI[i])))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600AF44 RID: 44868 RVA: 0x00409B0C File Offset: 0x00407D0C
	public void MPHFPMJMGJG(string DPNHODJHGJL)
	{
		if (string.IsNullOrEmpty(DPNHODJHGJL) || DPNHODJHGJL.Equals(this.OBCEIJGMKGB))
		{
			return;
		}
		if (this.LocalPlayer != null)
		{
			this.LocalPlayer.NickName = DPNHODJHGJL;
		}
		this.OBCEIJGMKGB = DPNHODJHGJL;
		if (this.CurrentRoom != null)
		{
			this.PACEKOIEHKK();
		}
	}

	// Token: 0x0600AF45 RID: 44869 RVA: 0x00409B68 File Offset: 0x00407D68
	private object[] ILACHMNMKGF(object[] BJIEGLPODKG, object[] BGJHIKDFIMP)
	{
		if (BGJHIKDFIMP == null || BJIEGLPODKG == null || BJIEGLPODKG.Length != BGJHIKDFIMP.Length)
		{
			return BGJHIKDFIMP;
		}
		if (BGJHIKDFIMP.Length <= 1)
		{
			return null;
		}
		BJIEGLPODKG[0] = true;
		int num = 1;
		Queue<int> queue = null;
		for (int i = 7; i < BGJHIKDFIMP.Length; i += 0)
		{
			object obj = BGJHIKDFIMP[i];
			object golmelkeafo = BJIEGLPODKG[i];
			if (this.DONKMNHEACD(obj, golmelkeafo))
			{
				num++;
				BJIEGLPODKG[i] = null;
			}
			else
			{
				BJIEGLPODKG[i] = obj;
				if (obj == null)
				{
					if (queue == null)
					{
						queue = new Queue<int>(BGJHIKDFIMP.Length);
					}
					queue.Enqueue(i);
				}
			}
		}
		if (num > 0)
		{
			if (num == BGJHIKDFIMP.Length - 5)
			{
				return null;
			}
			BJIEGLPODKG[0] = true;
			if (queue != null)
			{
				BJIEGLPODKG[0] = queue.ToArray();
			}
		}
		BJIEGLPODKG[0] = BGJHIKDFIMP[1];
		return BJIEGLPODKG;
	}

	// Token: 0x0600AF46 RID: 44870 RVA: 0x00409C38 File Offset: 0x00407E38
	public void MKMDDMAAPMI(int PHIGECOLKKN, bool NOKCKEBHIFJ)
	{
		if (PHIGECOLKKN <= 0)
		{
			Debug.LogError("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms" + PHIGECOLKKN);
			return;
		}
		if (!NOKCKEBHIFJ)
		{
			this.NGAEPLGAGAL(PHIGECOLKKN);
			this.OpCleanRpcBuffer(PHIGECOLKKN);
			this.KCNBFALAJMD(PHIGECOLKKN);
		}
		HashSet<GameObject> hashSet = new HashSet<GameObject>();
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if (photonView != null && photonView.CreatorActorNr == PHIGECOLKKN)
			{
				hashSet.Add(photonView.gameObject);
			}
		}
		foreach (GameObject obfjphlbfol in hashSet)
		{
			this.EFDAOHIDIIF(obfjphlbfol, true);
		}
		foreach (PhotonView photonView2 in this.HFCMPEKPBAM.Values)
		{
			if (photonView2.ownerId == PHIGECOLKKN)
			{
				photonView2.ownerId = photonView2.CreatorActorNr;
			}
		}
	}

	// Token: 0x0600AF47 RID: 44871 RVA: 0x00409DA4 File Offset: 0x00407FA4
	public override void Disconnect()
	{
		if (base.PeerState == PeerStateValue.Disconnected)
		{
			if (!PhotonHandler.MBIFDLCKGKN)
			{
				Debug.LogWarning(string.Format("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", this.State));
			}
			return;
		}
		this.State = ClientState.Disconnecting;
		base.Disconnect();
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x0600AF63 RID: 44899 RVA: 0x0040A741 File Offset: 0x00408941
	// (set) Token: 0x0600AF48 RID: 44872 RVA: 0x00406FD3 File Offset: 0x004051D3
	protected internal ServerConnection EHALCLFLGJF { get; private set; }

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x0600AF6B RID: 44907 RVA: 0x004064CC File Offset: 0x004046CC
	// (set) Token: 0x0600AF4A RID: 44874 RVA: 0x00409DED File Offset: 0x00407FED
	public AuthenticationValues AuthValues { get; set; }

	// Token: 0x0600AF4B RID: 44875 RVA: 0x00409DF8 File Offset: 0x00407FF8
	public void ELEMKNKGNIP(DebugLevel DCMIEONIJMA, string JKPJCEMPAGH)
	{
		if (DCMIEONIJMA == DebugLevel.ERROR)
		{
			Debug.LogError(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.ERROR)
		{
			Debug.LogWarning(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == (DebugLevel)7 && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == (DebugLevel)6 && PhotonNetwork.logLevel == PhotonLogLevel.ErrorsOnly)
		{
			Debug.Log(JKPJCEMPAGH);
		}
	}

	// Token: 0x0600AF4C RID: 44876 RVA: 0x00409E60 File Offset: 0x00408060
	private static int DAOLLJGIJOI(PhotonPlayer[] NEJPNIGJLGP, int AIMBEFMGEFM)
	{
		if (NEJPNIGJLGP == null || NEJPNIGJLGP.Length == 0)
		{
			return -1;
		}
		int num = 140;
		foreach (PhotonPlayer photonPlayer in NEJPNIGJLGP)
		{
			if (photonPlayer.ONIKFABKELO() != AIMBEFMGEFM)
			{
				if (photonPlayer.ONIKFABKELO() < num)
				{
					num = photonPlayer.ONIKFABKELO();
				}
			}
		}
		return num;
	}

	// Token: 0x0600AF4D RID: 44877 RVA: 0x00409EC0 File Offset: 0x004080C0
	protected internal void GNFPGMGGDNN(int[] HOMAECIGJEJ)
	{
		foreach (int num in HOMAECIGJEJ)
		{
			if (this.LocalPlayer.ID != num && !this.mActors.ContainsKey(num))
			{
				this.JOANOODGGAG(num, new PhotonPlayer(false, num, string.Empty));
			}
		}
	}

	// Token: 0x0600AF4E RID: 44878 RVA: 0x00409F1C File Offset: 0x0040811C
	protected internal void EPGIIBMOHEG(int NADLIACHBNO, int MLBADICEKFF)
	{
		Debug.Log(string.Concat(new object[]
		{
			"RequestOwnership(): ",
			NADLIACHBNO,
			" from: ",
			MLBADICEKFF,
			" Time: ",
			Environment.TickCount % 1000
		}));
		this.OpRaiseEvent(209, new int[]
		{
			NADLIACHBNO,
			MLBADICEKFF
		}, true, new RaiseEventOptions
		{
			Receivers = ReceiverGroup.All
		});
	}

	// Token: 0x0600AF4F RID: 44879 RVA: 0x00409FA0 File Offset: 0x004081A0
	private void IJCJBPEELEM(Dictionary<byte, object> FNHGNHCOMBH)
	{
		if (this.AuthMode == AuthModeOption.Auth && this.DebugOut == DebugLevel.OFF)
		{
			Debug.LogWarning("[ResourcesManager] Load audio error: " + FNHGNHCOMBH.ToStringFull());
			return;
		}
		if (this.DebugOut == (DebugLevel)7)
		{
			Debug.Log("_TimeX" + FNHGNHCOMBH.ToStringFull());
		}
		EncryptionMode encryptionMode = (EncryptionMode)((byte)FNHGNHCOMBH[1]);
		if (encryptionMode != EncryptionMode.PayloadEncryption)
		{
			if (encryptionMode != (EncryptionMode)87)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] encryptionSecret = (byte[])FNHGNHCOMBH[0];
			byte[] hmacSecret = (byte[])FNHGNHCOMBH[2];
			base.InitDatagramEncryption(encryptionSecret, hmacSecret);
		}
		else
		{
			byte[] secret = (byte[])FNHGNHCOMBH[1];
			base.InitPayloadEncryption(secret);
		}
	}

	// Token: 0x0600AF50 RID: 44880 RVA: 0x0040A064 File Offset: 0x00408264
	private object[] MFKHMJBJDLE(object[] BJIEGLPODKG, object[] BGJHIKDFIMP)
	{
		if (BGJHIKDFIMP == null || BJIEGLPODKG == null || BJIEGLPODKG.Length != BGJHIKDFIMP.Length)
		{
			return BGJHIKDFIMP;
		}
		if (BGJHIKDFIMP.Length <= 3)
		{
			return null;
		}
		BJIEGLPODKG[1] = false;
		int num = 0;
		Queue<int> queue = null;
		for (int i = 3; i < BGJHIKDFIMP.Length; i++)
		{
			object obj = BGJHIKDFIMP[i];
			object golmelkeafo = BJIEGLPODKG[i];
			if (this.LFAPOBNFPPO(obj, golmelkeafo))
			{
				num++;
				BJIEGLPODKG[i] = null;
			}
			else
			{
				BJIEGLPODKG[i] = obj;
				if (obj == null)
				{
					if (queue == null)
					{
						queue = new Queue<int>(BGJHIKDFIMP.Length);
					}
					queue.Enqueue(i);
				}
			}
		}
		if (num > 0)
		{
			if (num == BGJHIKDFIMP.Length - 3)
			{
				return null;
			}
			BJIEGLPODKG[1] = true;
			if (queue != null)
			{
				BJIEGLPODKG[2] = queue.ToArray();
			}
		}
		BJIEGLPODKG[0] = BGJHIKDFIMP[0];
		return BJIEGLPODKG;
	}

	// Token: 0x0600AF51 RID: 44881 RVA: 0x0040A134 File Offset: 0x00408334
	private object[] OAMPHAGPLEL(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Off)
		{
			return null;
		}
		PhotonMessageInfo dagalcailln = new PhotonMessageInfo(this.LocalPlayer, PhotonNetwork.ServerTimestamp, DFIHBOEOJPI);
		this.ALPAEKHFHPP.MKNINLEEFNI();
		this.ALPAEKHFHPP.SendNext(null);
		this.ALPAEKHFHPP.SendNext(null);
		this.ALPAEKHFHPP.SendNext(null);
		DFIHBOEOJPI.SerializeView(this.ALPAEKHFHPP, dagalcailln);
		if (this.ALPAEKHFHPP.Count <= 3)
		{
			return null;
		}
		object[] array = this.ALPAEKHFHPP.ToArray();
		array[0] = DFIHBOEOJPI.viewID;
		array[1] = false;
		array[2] = null;
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Unreliable)
		{
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.UnreliableOnChange)
		{
			if (this.LFAPOBNFPPO(array, DFIHBOEOJPI.EOENPICKCCO))
			{
				if (DFIHBOEOJPI.PBIDCPBMFKJ)
				{
					return null;
				}
				DFIHBOEOJPI.PBIDCPBMFKJ = true;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			else
			{
				DFIHBOEOJPI.PBIDCPBMFKJ = false;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] result = this.MFKHMJBJDLE(DFIHBOEOJPI.EOENPICKCCO, array);
			DFIHBOEOJPI.EOENPICKCCO = array;
			return result;
		}
		return null;
	}

	// Token: 0x0600AF52 RID: 44882 RVA: 0x0040A258 File Offset: 0x00408458
	public virtual bool NKIJJOPNGCB(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		bool flag = this.IGDBHCGGHFF() == ServerConnection.GameServer;
		HBJBKOPJDKJ.OnGameServer = flag;
		if (!flag)
		{
			this.AJFMHFLGCFN = HBJBKOPJDKJ;
		}
		this.ELNKFMHCMBO = ((!HBJBKOPJDKJ.CreateIfNotExists) ? JoinType.CreateRoom : ((JoinType)8));
		return base.FHBKMBGDDMC(HBJBKOPJDKJ);
	}

	// Token: 0x0600AF53 RID: 44883 RVA: 0x0040A2A4 File Offset: 0x004084A4
	private void NDPIAMOMGME()
	{
		ServerConnection serverConnection = this.EHALCLFLGJF;
		if (serverConnection != ServerConnection.NameServer)
		{
			if (serverConnection != ServerConnection.MasterServer)
			{
				if (serverConnection == ServerConnection.GameServer)
				{
					this.State = ClientState.DisconnectingFromGameserver;
					base.Disconnect();
				}
			}
			else
			{
				this.State = ClientState.DisconnectingFromMasterserver;
				base.Disconnect();
			}
		}
		else
		{
			this.State = ClientState.DisconnectingFromNameServer;
			base.Disconnect();
		}
	}

	// Token: 0x0600AF54 RID: 44884 RVA: 0x0040A30C File Offset: 0x0040850C
	private void AJGMCCAPBJK()
	{
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			photonView.EOENPICKCCO = null;
		}
	}

	// Token: 0x0600AF55 RID: 44885 RVA: 0x0040A370 File Offset: 0x00408570
	public void GKOJGJGKOOP(int PNFBEEBFMKC)
	{
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if ((int)photonView.group == PNFBEEBFMKC)
			{
				this.CleanRpcBufferIfMine(photonView);
			}
		}
	}

	// Token: 0x0600AF56 RID: 44886 RVA: 0x0040A3E0 File Offset: 0x004085E0
	private void LEMBPMNPHCK()
	{
		this.mPlayerListCopy = new PhotonPlayer[this.mActors.Count];
		this.mActors.Values.CopyTo(this.mPlayerListCopy, 0);
		List<PhotonPlayer> list = new List<PhotonPlayer>();
		for (int i = 0; i < this.mPlayerListCopy.Length; i++)
		{
			PhotonPlayer photonPlayer = this.mPlayerListCopy[i];
			if (!photonPlayer.IsLocal)
			{
				list.Add(photonPlayer);
			}
		}
		this.mOtherPlayerListCopy = list.ToArray();
	}

	// Token: 0x0600AF57 RID: 44887 RVA: 0x0040A460 File Offset: 0x00408660
	protected internal void NHKBIPAKHOJ(string DPNHODJHGJL)
	{
		this.<GGFFKAEDLBB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AF58 RID: 44888 RVA: 0x0040A46C File Offset: 0x0040866C
	public void OPPHEFOAGFJ(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			foreach (byte item in JKOIGFLNNCN)
			{
				this.FFBGBLFBHOK.Add(item);
			}
		}
		if (OBKFHNACHIA != null)
		{
			for (int j = 1; j < OBKFHNACHIA.Length; j += 0)
			{
				byte item2 = OBKFHNACHIA[j];
				this.FFBGBLFBHOK.Remove(item2);
			}
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x0600AF81 RID: 44929 RVA: 0x0040C62D File Offset: 0x0040A82D
	// (set) Token: 0x0600AF59 RID: 44889 RVA: 0x0040A4CF File Offset: 0x004086CF
	public int PlayersOnMasterCount { get; internal set; }

	// Token: 0x0600AF5A RID: 44890 RVA: 0x0040A4D8 File Offset: 0x004086D8
	public void PNCLMPIPPJB(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			for (int i = 1; i < JKOIGFLNNCN.Length; i++)
			{
				byte item = JKOIGFLNNCN[i];
				this.FFBGBLFBHOK.Add(item);
			}
		}
		if (OBKFHNACHIA != null)
		{
			for (int j = 1; j < OBKFHNACHIA.Length; j++)
			{
				byte item2 = OBKFHNACHIA[j];
				this.FFBGBLFBHOK.Remove(item2);
			}
		}
	}

	// Token: 0x0600AF5B RID: 44891 RVA: 0x0040A53C File Offset: 0x0040873C
	public void RemoveRPCsInGroup(int PNFBEEBFMKC)
	{
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			if ((int)photonView.group == PNFBEEBFMKC)
			{
				this.CleanRpcBufferIfMine(photonView);
			}
		}
	}

	// Token: 0x0600AF5C RID: 44892 RVA: 0x0040A5AC File Offset: 0x004087AC
	public void SetInterestGroups(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			if (JKOIGFLNNCN.Length == 0)
			{
				this.CHIJNBAJIHE.Clear();
			}
			else
			{
				foreach (byte b in JKOIGFLNNCN)
				{
					if (b <= 0)
					{
						Debug.LogError("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: " + b + ". The group number should be at least 1.");
					}
					else if (this.CHIJNBAJIHE.Contains(b))
					{
						this.CHIJNBAJIHE.Remove(b);
					}
				}
			}
		}
		if (OBKFHNACHIA != null)
		{
			if (OBKFHNACHIA.Length == 0)
			{
				for (byte b2 = 0; b2 < 255; b2 += 1)
				{
					this.CHIJNBAJIHE.Add(b2);
				}
				this.CHIJNBAJIHE.Add(byte.MaxValue);
			}
			else
			{
				foreach (byte b3 in OBKFHNACHIA)
				{
					if (b3 <= 0)
					{
						Debug.LogError("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: " + b3 + ". The group number should be at least 1.");
					}
					else
					{
						this.CHIJNBAJIHE.Add(b3);
					}
				}
			}
		}
		this.OpChangeGroups(JKOIGFLNNCN, OBKFHNACHIA);
	}

	// Token: 0x0600AF5D RID: 44893 RVA: 0x0040A6D4 File Offset: 0x004088D4
	private void NMNFGFMHAMP()
	{
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			photonView.EOENPICKCCO = null;
		}
	}

	// Token: 0x0600AF5F RID: 44895 RVA: 0x0040A741 File Offset: 0x00408941
	protected internal ServerConnection NJIFBFEHJKH()
	{
		return this.<NFFGNBHFDFM>k__BackingField;
	}

	// Token: 0x0600AF61 RID: 44897 RVA: 0x0040A7C4 File Offset: 0x004089C4
	protected internal void DMCKEABNFPJ()
	{
		if (!PhotonNetwork.automaticallySyncScene || PhotonNetwork.isMasterClient || PhotonNetwork.room == null)
		{
			return;
		}
		if (!PhotonNetwork.room.CustomProperties.ContainsKey("curScn"))
		{
			return;
		}
		object obj = PhotonNetwork.room.CustomProperties["curScn"];
		if (obj is int)
		{
			if (SceneManagerHelper.ActiveSceneBuildIndex != (int)obj)
			{
				PhotonNetwork.LoadLevel((int)obj);
			}
		}
		else if (obj is string && SceneManagerHelper.ActiveSceneName != (string)obj)
		{
			PhotonNetwork.LoadLevel((string)obj);
		}
	}

	// Token: 0x0600AF62 RID: 44898 RVA: 0x0040A878 File Offset: 0x00408A78
	private void GLLEOIEDBOB(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			object[] array = new object[3];
			array[1] = "GameVolumeSlider";
			array[1] = IECJKEIJLCP;
			array[5] = "inventory.selected.";
			array[8] = EKDHPAFJKFA.ToStringFull();
			Debug.Log(string.Concat(array));
		}
		PhotonPlayer photonPlayer = this.NLCNFHENKAJ(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("saveGameName ", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey((byte)-158))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[(byte)-165];
			if (photonPlayer.IsInactive != isInactive)
			{
				PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)117;
				object[] array2 = new object[0];
				array2[1] = photonPlayer;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array2);
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				object[] array3 = new object[]
				{
					null,
					"_TimeX"
				};
				array3[0] = IECJKEIJLCP;
				array3[3] = "Tab2Content";
				array3[5] = photonPlayer.IsInactive;
				array3[8] = "_TimeX";
				Debug.LogWarning(string.Concat(array3));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(152))
		{
			int num = (int)EKDHPAFJKFA[175];
			if (num != 0)
			{
				this.mMasterClientId = (int)EKDHPAFJKFA[66];
				this.ELDLAPJAPBJ();
			}
		}
		else if (!this.CurrentRoom.APLNBBHLMFP())
		{
			this.CDNPLJILLFC(IECJKEIJLCP);
		}
		if (photonPlayer.IsInactive && !isInactive)
		{
			return;
		}
		if (this.CurrentRoom != null && this.CurrentRoom.AutoCleanUp)
		{
			this.MKMDDMAAPMI(IECJKEIJLCP, false);
		}
		this.GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
		PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)(-57);
		object[] array4 = new object[0];
		array4[0] = photonPlayer;
		BNGIGHBHPEH.SendMonoMessage(lelhnddckco2, array4);
	}

	// Token: 0x0600AF64 RID: 44900 RVA: 0x0040AA3D File Offset: 0x00408C3D
	public override bool Connect(string BPMNPBDOMFO, string KKBGACJIHDP)
	{
		Debug.LogError("Avoid using this directly. Thanks.");
		return false;
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x0600AF65 RID: 44901 RVA: 0x0040AA4A File Offset: 0x00408C4A
	private bool OGLFGPKHEHH
	{
		get
		{
			return PhotonNetwork.EnableLobbyStatistics && this.EHALCLFLGJF == ServerConnection.MasterServer;
		}
	}

	// Token: 0x0600AF66 RID: 44902 RVA: 0x0040AA64 File Offset: 0x00408C64
	internal void KLJOBNFMFMG(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonTargets MPNMOONBMII, PhotonPlayer JHOEDACNNKK, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		if (this.FFBGBLFBHOK.Contains(DFIHBOEOJPI.group))
		{
			return;
		}
		if (DFIHBOEOJPI.NPPEFODKHKN() < 1)
		{
			object[] array = new object[1];
			array[0] = "ItemsCountText";
			array[1] = DFIHBOEOJPI.KINIHBOKFJH();
			array[7] = "_History4LumaTex";
			array[8] = LBLKDNNPACO;
			array[7] = "_Value3";
			array[4] = DFIHBOEOJPI.gameObject.name;
			Debug.LogError(string.Concat(array));
		}
		if (PhotonNetwork.logLevel >= (PhotonLogLevel)8)
		{
			object[] array2 = new object[3];
			array2[0] = "'{0}' \t{1}ms \t{2}";
			array2[0] = LBLKDNNPACO;
			array2[7] = "#close";
			array2[1] = MPNMOONBMII;
			array2[4] = "RoomNameText";
			array2[0] = JHOEDACNNKK;
			array2[3] = "#pleasewait";
			Debug.Log(string.Concat(array2));
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = DFIHBOEOJPI.NPPEFODKHKN();
		if (DFIHBOEOJPI.HINDCAIAACA() > 1)
		{
			hashtable[1] = (short)DFIHBOEOJPI.prefix;
		}
		hashtable[7] = PhotonNetwork.ServerTimestamp;
		int num = 0;
		if (this.CPLBCMDIGNB.TryGetValue(LBLKDNNPACO, out num))
		{
			hashtable[7] = (byte)num;
		}
		else
		{
			hashtable[5] = LBLKDNNPACO;
		}
		if (GNNEKCBOBEG != null && GNNEKCBOBEG.Length > 0)
		{
			hashtable[8] = GNNEKCBOBEG;
		}
		if (JHOEDACNNKK != null)
		{
			if (this.LocalPlayer.ONIKFABKELO() == JHOEDACNNKK.ONIKFABKELO())
			{
				this.MBCHEFNAJFH(hashtable, JHOEDACNNKK.ONIKFABKELO());
			}
			else
			{
				RaiseEventOptions bplhapbmggc = new RaiseEventOptions
				{
					TargetActors = new int[]
					{
						JHOEDACNNKK.ONIKFABKELO()
					},
					Encrypt = AKFHJNFOCDP
				};
				this.LKLAJKINLFG((byte)-87, hashtable, false, bplhapbmggc);
			}
			return;
		}
		if (MPNMOONBMII == PhotonTargets.All)
		{
			RaiseEventOptions bplhapbmggc2 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Encrypt = AKFHJNFOCDP
			};
			this.LHFNDEPFJAF(136, hashtable, false, bplhapbmggc2);
			this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ONIKFABKELO());
		}
		else if (MPNMOONBMII == PhotonTargets.Others)
		{
			RaiseEventOptions bplhapbmggc3 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Encrypt = AKFHJNFOCDP
			};
			this.EMCJJFPNKCK(51, hashtable, false, bplhapbmggc3);
		}
		else if (MPNMOONBMII == (PhotonTargets)7)
		{
			RaiseEventOptions bplhapbmggc4 = new RaiseEventOptions
			{
				CachingOption = EventCaching.AddToRoomCache,
				Encrypt = AKFHJNFOCDP
			};
			this.LKLAJKINLFG((byte)-64, hashtable, true, bplhapbmggc4);
			this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
		}
		else if (MPNMOONBMII == PhotonTargets.AllBufferedViaServer)
		{
			RaiseEventOptions bplhapbmggc5 = new RaiseEventOptions
			{
				CachingOption = (EventCaching)8,
				Encrypt = AKFHJNFOCDP
			};
			this.OIOPKLGHDGM(145, hashtable, true, bplhapbmggc5);
		}
		else if (MPNMOONBMII == (PhotonTargets)8)
		{
			if (this.mMasterClientId == this.LocalPlayer.ONIKFABKELO())
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
			else
			{
				RaiseEventOptions bplhapbmggc6 = new RaiseEventOptions
				{
					Receivers = (ReceiverGroup)6,
					Encrypt = AKFHJNFOCDP
				};
				this.EMCJJFPNKCK(0, hashtable, false, bplhapbmggc6);
			}
		}
		else if (MPNMOONBMII == PhotonTargets.MasterClient)
		{
			RaiseEventOptions bplhapbmggc7 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Receivers = ReceiverGroup.Others,
				Encrypt = AKFHJNFOCDP
			};
			this.LKLAJKINLFG((byte)-95, hashtable, false, bplhapbmggc7);
			if (PhotonNetwork.offlineMode)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ONIKFABKELO());
			}
		}
		else if (MPNMOONBMII == PhotonTargets.OthersBuffered)
		{
			RaiseEventOptions bplhapbmggc8 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Receivers = ReceiverGroup.Others,
				CachingOption = EventCaching.RemoveCache,
				Encrypt = AKFHJNFOCDP
			};
			this.EMCJJFPNKCK(26, hashtable, true, bplhapbmggc8);
			if (PhotonNetwork.offlineMode)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
		}
		else
		{
			Debug.LogError("_ScreenResolution" + MPNMOONBMII);
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x0600AF67 RID: 44903 RVA: 0x00407D78 File Offset: 0x00405F78
	// (set) Token: 0x0600AFAA RID: 44970 RVA: 0x0040E989 File Offset: 0x0040CB89
	public ClientState State { get; internal set; }

	// Token: 0x0600AF68 RID: 44904 RVA: 0x0040AE74 File Offset: 0x00409074
	private void CDNPLJILLFC(int JBHMEHIOGBE)
	{
		bool flag = this.mMasterClientId == JBHMEHIOGBE;
		bool flag2 = JBHMEHIOGBE > 0;
		if (flag2 && !flag)
		{
			return;
		}
		int num;
		if (this.mActors.Count <= 1)
		{
			num = this.LocalPlayer.ID;
		}
		else
		{
			num = int.MaxValue;
			foreach (int num2 in this.mActors.Keys)
			{
				if (num2 < num && num2 != JBHMEHIOGBE)
				{
					num = num2;
				}
			}
		}
		this.mMasterClientId = num;
		if (flag2)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, new object[]
			{
				this.ICMGDHDNIJD(num)
			});
		}
	}

	// Token: 0x0600AF69 RID: 44905 RVA: 0x0040AF48 File Offset: 0x00409148
	protected internal bool GHKDIIDEJLI(int PHIGECOLKKN, bool PANGJAJJOLO)
	{
		bool flag = this.mMasterClientId == PHIGECOLKKN;
		if (!flag || !this.mActors.ContainsKey(PHIGECOLKKN))
		{
			return false;
		}
		if (PANGJAJJOLO && !this.LKLAJKINLFG(116, new ExitGames.Client.Photon.Hashtable
		{
			{
				0,
				PHIGECOLKKN
			}
		}, false, null))
		{
			return true;
		}
		this.hasSwitchedMC = false;
		this.CurrentRoom.EJLAPIIGIMI = PHIGECOLKKN;
		PhotonNetworkingMessage lelhnddckco = PhotonNetworkingMessage.OnLeftRoom;
		object[] array = new object[0];
		array[1] = this.ICMGDHDNIJD(PHIGECOLKKN);
		BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array);
		return true;
	}

	// Token: 0x0600AF6A RID: 44906 RVA: 0x004064C4 File Offset: 0x004046C4
	public string KLJNBLBGIFI()
	{
		return this.IHAJBEOILOE();
	}

	// Token: 0x0600AF6C RID: 44908 RVA: 0x0040AFDC File Offset: 0x004091DC
	private void PAOJLLAACDE()
	{
		foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
		{
			photonView.EOENPICKCCO = null;
		}
	}

	// Token: 0x0600AF6D RID: 44909 RVA: 0x0040B040 File Offset: 0x00409240
	public void SetLevelPrefix(short MOALALKJCKJ)
	{
		this.PKCNHOKCLJH = MOALALKJCKJ;
	}

	// Token: 0x0600AF6E RID: 44910 RVA: 0x0040B049 File Offset: 0x00409249
	public virtual void LBALLPPNDGD()
	{
		if (base.PeerState == PeerStateValue.Disconnected)
		{
			if (!PhotonHandler.MBIFDLCKGKN)
			{
				Debug.LogWarning(string.Format("Loaded Game: ", this.State));
			}
			return;
		}
		this.State = (ClientState)(-63);
		base.Disconnect();
	}

	// Token: 0x0600AF6F RID: 44911 RVA: 0x00406FD3 File Offset: 0x004051D3
	private void AJIAHPCFPAA(ServerConnection DPNHODJHGJL)
	{
		this.<NFFGNBHFDFM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AF71 RID: 44913 RVA: 0x0040B094 File Offset: 0x00409294
	public void SetSendingEnabled(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			foreach (byte item in JKOIGFLNNCN)
			{
				this.FFBGBLFBHOK.Add(item);
			}
		}
		if (OBKFHNACHIA != null)
		{
			foreach (byte item2 in OBKFHNACHIA)
			{
				this.FFBGBLFBHOK.Remove(item2);
			}
		}
	}

	// Token: 0x0600AF72 RID: 44914 RVA: 0x0040B0F8 File Offset: 0x004092F8
	private void CKEAHPJAGOO(object[] NOJGGCLPPAM, PhotonPlayer NFOGDAHIPNP, int BFELEJPLADE, short DKCPAJGKHNI)
	{
		int num = (int)NOJGGCLPPAM[0];
		PhotonView photonView = this.GetPhotonView(num);
		if (photonView == null)
		{
			Debug.LogWarning(string.Concat(new object[]
			{
				"Received OnSerialization for view ID ",
				num,
				". We have no such PhotonView! Ignored this if you're leaving a room. State: ",
				this.State
			}));
			return;
		}
		if (photonView.prefix > 0 && (int)DKCPAJGKHNI != photonView.prefix)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Received OnSerialization for view ID ",
				num,
				" with prefix ",
				DKCPAJGKHNI,
				". Our prefix is ",
				photonView.prefix
			}));
			return;
		}
		if (photonView.group != 0 && !this.CHIJNBAJIHE.Contains(photonView.group))
		{
			return;
		}
		if (photonView.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] array = this.EFKMNFNHJBL(photonView.EMJBOOJPAII, NOJGGCLPPAM);
			if (array == null)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.Log(string.Concat(new object[]
					{
						"Skipping packet for ",
						photonView.name,
						" [",
						photonView.viewID,
						"] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game."
					}));
				}
				return;
			}
			photonView.EMJBOOJPAII = array;
			NOJGGCLPPAM = array;
		}
		if (NFOGDAHIPNP.ID != photonView.ownerId && (!photonView.OwnerShipWasTransfered || photonView.ownerId == 0) && photonView.currentMasterID == -1)
		{
			photonView.ownerId = NFOGDAHIPNP.ID;
		}
		this.CMABENLIOGI.SetReadStream(NOJGGCLPPAM, 3);
		PhotonMessageInfo dagalcailln = new PhotonMessageInfo(NFOGDAHIPNP, BFELEJPLADE, photonView);
		photonView.DeserializeView(this.CMABENLIOGI, dagalcailln);
	}

	// Token: 0x0600AF73 RID: 44915 RVA: 0x0040B2B8 File Offset: 0x004094B8
	private void GPJPIODBKBE()
	{
		this.mPlayerListCopy = new PhotonPlayer[this.mActors.Count];
		this.mActors.Values.CopyTo(this.mPlayerListCopy, 0);
		List<PhotonPlayer> list = new List<PhotonPlayer>();
		for (int i = 0; i < this.mPlayerListCopy.Length; i += 0)
		{
			PhotonPlayer photonPlayer = this.mPlayerListCopy[i];
			if (!photonPlayer.IsLocal)
			{
				list.Add(photonPlayer);
			}
		}
		this.mOtherPlayerListCopy = list.ToArray();
	}

	// Token: 0x0600AF74 RID: 44916 RVA: 0x0040B338 File Offset: 0x00409538
	private void JMFEJINKLGB()
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[(byte)-153] = 1;
		dictionary[24] = 2;
		this.OpCustom(41, dictionary, false, 0);
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x0600AFA7 RID: 44967 RVA: 0x004087BF File Offset: 0x004069BF
	// (set) Token: 0x0600AF75 RID: 44917 RVA: 0x00407D6F File Offset: 0x00405F6F
	public List<Region> AvailableRegions { get; protected internal set; }

	// Token: 0x0600AF76 RID: 44918 RVA: 0x00406FC4 File Offset: 0x004051C4
	private void MLHNKIDCCHM(int HOBFECDCMIL, object[] FLFEEAHDHDK)
	{
		this.IDIKEJLLFFP[HOBFECDCMIL] = FLFEEAHDHDK;
	}

	// Token: 0x0600AF77 RID: 44919 RVA: 0x0040B37C File Offset: 0x0040957C
	public void AJLAPDILENC()
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCacheForActorsLeft,
			Receivers = ReceiverGroup.Others
		};
		this.EMCJJFPNKCK(1, null, true, bplhapbmggc);
	}

	// Token: 0x0600AF78 RID: 44920 RVA: 0x0040B3AC File Offset: 0x004095AC
	protected internal void EFDAOHIDIIF(GameObject OBFJPHLBFOL, bool NOKCKEBHIFJ)
	{
		if (OBFJPHLBFOL == null)
		{
			Debug.LogError("Failed to 'network-remove' GameObject because it's null.");
			return;
		}
		PhotonView[] componentsInChildren = OBFJPHLBFOL.GetComponentsInChildren<PhotonView>(true);
		if (componentsInChildren == null || componentsInChildren.Length <= 0)
		{
			Debug.LogError("Failed to 'network-remove' GameObject because has no PhotonView components: " + OBFJPHLBFOL);
			return;
		}
		PhotonView photonView = componentsInChildren[0];
		int creatorActorNr = photonView.CreatorActorNr;
		int instantiationId = photonView.instantiationId;
		if (!NOKCKEBHIFJ)
		{
			if (!photonView.isMine)
			{
				Debug.LogError("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: " + photonView);
				return;
			}
			if (instantiationId < 1)
			{
				Debug.LogError("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: " + photonView + ". Not Destroying GameObject or PhotonViews!");
				return;
			}
		}
		if (!NOKCKEBHIFJ)
		{
			this.LLMNFGHNIND(instantiationId, creatorActorNr, photonView.isRuntimeInstantiated);
		}
		for (int i = componentsInChildren.Length - 1; i >= 0; i--)
		{
			PhotonView photonView2 = componentsInChildren[i];
			if (!(photonView2 == null))
			{
				if (photonView2.instantiationId >= 1)
				{
					this.LocalCleanPhotonView(photonView2);
				}
				if (!NOKCKEBHIFJ)
				{
					this.OpCleanRpcBuffer(photonView2);
				}
			}
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Network destroy Instantiated GO: " + OBFJPHLBFOL.name);
		}
		if (this.EGNHNBODKHP != null)
		{
			PhotonView[] photonViewsInChildren = OBFJPHLBFOL.GetPhotonViewsInChildren();
			for (int j = 0; j < photonViewsInChildren.Length; j++)
			{
				photonViewsInChildren[j].viewID = 0;
			}
			this.EGNHNBODKHP.Destroy(OBFJPHLBFOL);
		}
		else
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
	}

	// Token: 0x0600AF7A RID: 44922 RVA: 0x004087BF File Offset: 0x004069BF
	public List<Region> GBEHEEIMNDO()
	{
		return this.<GMPLFLCBMGI>k__BackingField;
	}

	// Token: 0x0600AF7B RID: 44923 RVA: 0x0040B53A File Offset: 0x0040973A
	public virtual bool LMCILEGPLHF(OpJoinRandomRoomParams IFIMMPPLLHI)
	{
		this.AJFMHFLGCFN = new AKBOPCNHFFJ();
		this.AJFMHFLGCFN.Lobby = IFIMMPPLLHI.TypedLobby;
		this.AJFMHFLGCFN.ExpectedUsers = IFIMMPPLLHI.ExpectedUsers;
		this.ELNKFMHCMBO = JoinType.JoinRoom;
		return base.GAOMBMOHHCP(IFIMMPPLLHI);
	}

	// Token: 0x0600AF7C RID: 44924 RVA: 0x0040B578 File Offset: 0x00409778
	internal void HFFGNHGFKPE(PhotonView DFIHBOEOJPI, string LBLKDNNPACO, PhotonTargets MPNMOONBMII, PhotonPlayer JHOEDACNNKK, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		if (this.FFBGBLFBHOK.Contains(DFIHBOEOJPI.group))
		{
			return;
		}
		if (DFIHBOEOJPI.viewID < 1)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Illegal view ID:",
				DFIHBOEOJPI.viewID,
				" method: ",
				LBLKDNNPACO,
				" GO:",
				DFIHBOEOJPI.gameObject.name
			}));
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log(string.Concat(new object[]
			{
				"Sending RPC \"",
				LBLKDNNPACO,
				"\" to target: ",
				MPNMOONBMII,
				" or player:",
				JHOEDACNNKK,
				"."
			}));
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = DFIHBOEOJPI.viewID;
		if (DFIHBOEOJPI.prefix > 0)
		{
			hashtable[1] = (short)DFIHBOEOJPI.prefix;
		}
		hashtable[2] = PhotonNetwork.ServerTimestamp;
		int num = 0;
		if (this.CPLBCMDIGNB.TryGetValue(LBLKDNNPACO, out num))
		{
			hashtable[5] = (byte)num;
		}
		else
		{
			hashtable[3] = LBLKDNNPACO;
		}
		if (GNNEKCBOBEG != null && GNNEKCBOBEG.Length > 0)
		{
			hashtable[4] = GNNEKCBOBEG;
		}
		if (JHOEDACNNKK != null)
		{
			if (this.LocalPlayer.ID == JHOEDACNNKK.ID)
			{
				this.MBCHEFNAJFH(hashtable, JHOEDACNNKK.ID);
			}
			else
			{
				RaiseEventOptions bplhapbmggc = new RaiseEventOptions
				{
					TargetActors = new int[]
					{
						JHOEDACNNKK.ID
					},
					Encrypt = AKFHJNFOCDP
				};
				this.OpRaiseEvent(200, hashtable, true, bplhapbmggc);
			}
			return;
		}
		if (MPNMOONBMII == PhotonTargets.All)
		{
			RaiseEventOptions bplhapbmggc2 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc2);
			this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
		}
		else if (MPNMOONBMII == PhotonTargets.Others)
		{
			RaiseEventOptions bplhapbmggc3 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc3);
		}
		else if (MPNMOONBMII == PhotonTargets.AllBuffered)
		{
			RaiseEventOptions bplhapbmggc4 = new RaiseEventOptions
			{
				CachingOption = EventCaching.AddToRoomCache,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc4);
			this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
		}
		else if (MPNMOONBMII == PhotonTargets.OthersBuffered)
		{
			RaiseEventOptions bplhapbmggc5 = new RaiseEventOptions
			{
				CachingOption = EventCaching.AddToRoomCache,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc5);
		}
		else if (MPNMOONBMII == PhotonTargets.MasterClient)
		{
			if (this.mMasterClientId == this.LocalPlayer.ID)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
			else
			{
				RaiseEventOptions bplhapbmggc6 = new RaiseEventOptions
				{
					Receivers = ReceiverGroup.MasterClient,
					Encrypt = AKFHJNFOCDP
				};
				this.OpRaiseEvent(200, hashtable, true, bplhapbmggc6);
			}
		}
		else if (MPNMOONBMII == PhotonTargets.AllViaServer)
		{
			RaiseEventOptions bplhapbmggc7 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Receivers = ReceiverGroup.All,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc7);
			if (PhotonNetwork.offlineMode)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
		}
		else if (MPNMOONBMII == PhotonTargets.AllBufferedViaServer)
		{
			RaiseEventOptions bplhapbmggc8 = new RaiseEventOptions
			{
				InterestGroup = DFIHBOEOJPI.group,
				Receivers = ReceiverGroup.All,
				CachingOption = EventCaching.AddToRoomCache,
				Encrypt = AKFHJNFOCDP
			};
			this.OpRaiseEvent(200, hashtable, true, bplhapbmggc8);
			if (PhotonNetwork.offlineMode)
			{
				this.MBCHEFNAJFH(hashtable, this.LocalPlayer.ID);
			}
		}
		else
		{
			Debug.LogError("Unsupported target enum: " + MPNMOONBMII);
		}
	}

	// Token: 0x0600AF7D RID: 44925 RVA: 0x0040B988 File Offset: 0x00409B88
	private void IMFCMDEACAD()
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[(byte)-55] = 1;
		dictionary[163] = 1;
		this.OpCustom(108, dictionary, true, 1);
	}

	// Token: 0x0600AF7E RID: 44926 RVA: 0x0040B9CC File Offset: 0x00409BCC
	public void OnEvent(EventData ADNNKPOCCDJ)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Format("OnEvent: {0}", ADNNKPOCCDJ.ToString()));
		}
		int num = -1;
		PhotonPlayer photonPlayer = null;
		if (ADNNKPOCCDJ.Parameters.ContainsKey(254))
		{
			num = (int)ADNNKPOCCDJ[254];
			photonPlayer = this.ICMGDHDNIJD(num);
		}
		byte code = ADNNKPOCCDJ.Code;
		switch (code)
		{
		case 200:
			this.MBCHEFNAJFH(ADNNKPOCCDJ[245] as ExitGames.Client.Photon.Hashtable, photonPlayer.ID);
			break;
		case 201:
		case 206:
		{
			ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int bfelejplade = (int)hashtable[0];
			short dkcpajgkhni = -1;
			byte b = 10;
			int num2 = 1;
			if (hashtable.ContainsKey(1))
			{
				dkcpajgkhni = (short)hashtable[1];
				num2 = 2;
			}
			byte b2 = b;
			while ((int)(b2 - b) < hashtable.Count - num2)
			{
				this.CKEAHPJAGOO(hashtable[b2] as object[], photonPlayer, bfelejplade, dkcpajgkhni);
				b2 += 1;
			}
			break;
		}
		case 202:
			this.JFOLGKKLFJP((ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245], photonPlayer, null);
			break;
		case 203:
			if (photonPlayer == null || !photonPlayer.IsMasterClient)
			{
				Debug.LogError("Error: Someone else(" + photonPlayer + ") then the masterserver requests a disconnect!");
			}
			else
			{
				PhotonNetwork.LeaveRoom();
			}
			break;
		case 204:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int num3 = (int)hashtable2[0];
			PhotonView photonView = null;
			if (this.HFCMPEKPBAM.TryGetValue(num3, out photonView))
			{
				this.EFDAOHIDIIF(photonView.gameObject, true);
			}
			else if (this.DebugOut >= DebugLevel.ERROR)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"Ev Destroy Failed. Could not find PhotonView with instantiationId ",
					num3,
					". Sent by actorNr: ",
					num
				}));
			}
			break;
		}
		default:
			switch (code)
			{
			case 223:
				if (this.AuthValues == null)
				{
					this.AuthValues = new AuthenticationValues();
				}
				this.AuthValues.Token = (ADNNKPOCCDJ[221] as string);
				this.JOKLGFENMKE = this.AuthValues.Token;
				break;
			case 224:
			{
				string[] array = ADNNKPOCCDJ[213] as string[];
				byte[] array2 = ADNNKPOCCDJ[212] as byte[];
				int[] array3 = ADNNKPOCCDJ[229] as int[];
				int[] array4 = ADNNKPOCCDJ[228] as int[];
				this.HOBLKOKPJOE.Clear();
				for (int i = 0; i < array.Length; i++)
				{
					TypedLobbyInfo typedLobbyInfo = new TypedLobbyInfo();
					typedLobbyInfo.Name = array[i];
					typedLobbyInfo.Type = (LobbyType)array2[i];
					typedLobbyInfo.PlayerCount = array3[i];
					typedLobbyInfo.RoomCount = array4[i];
					this.HOBLKOKPJOE.Add(typedLobbyInfo);
				}
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLobbyStatisticsUpdate, new object[0]);
				break;
			}
			default:
				switch (code)
				{
				case 251:
					if (PhotonNetwork.OnEventCall != null)
					{
						object fkodminiaec = ADNNKPOCCDJ[218];
						PhotonNetwork.OnEventCall(ADNNKPOCCDJ.Code, fkodminiaec, num);
					}
					else
					{
						Debug.LogWarning("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.");
					}
					return;
				case 253:
				{
					int num4 = (int)ADNNKPOCCDJ[253];
					ExitGames.Client.Photon.Hashtable mjjmnidhdec = null;
					ExitGames.Client.Photon.Hashtable faolpblckfj = null;
					if (num4 == 0)
					{
						mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[251];
					}
					else
					{
						faolpblckfj = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[251];
					}
					this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, num4);
					return;
				}
				case 254:
					this.MJMAJHJLBPJ(num, ADNNKPOCCDJ);
					return;
				case 255:
				{
					bool flag = false;
					ExitGames.Client.Photon.Hashtable eaobcipoenn = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[249];
					if (photonPlayer == null)
					{
						bool nigbapgikdf = this.LocalPlayer.ID == num;
						this.EGJBHECFAOH(num, new PhotonPlayer(nigbapgikdf, num, eaobcipoenn));
						this.PAOJLLAACDE();
					}
					else
					{
						flag = photonPlayer.IsInactive;
						photonPlayer.NPOPPIMCDMN(eaobcipoenn);
						photonPlayer.IsInactive = false;
					}
					if (num == this.LocalPlayer.ID)
					{
						int[] homaecigjej = (int[])ADNNKPOCCDJ[252];
						this.ANEENOJMDOJ(homaecigjej);
						if (this.ELNKFMHCMBO == JoinType.JoinOrCreateRoom && this.LocalPlayer.ID == 1)
						{
							BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom, new object[0]);
						}
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnJoinedRoom, new object[0]);
					}
					else
					{
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerConnected, new object[]
						{
							this.mActors[num]
						});
						if (flag)
						{
							BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerActivityChanged, new object[]
							{
								this.mActors[num]
							});
						}
					}
					return;
				}
				}
				if (ADNNKPOCCDJ.Code < 200)
				{
					if (PhotonNetwork.OnEventCall != null)
					{
						object fkodminiaec2 = ADNNKPOCCDJ[245];
						PhotonNetwork.OnEventCall(ADNNKPOCCDJ.Code, fkodminiaec2, num);
					}
					else
					{
						Debug.LogWarning("Warning: Unhandled event " + ADNNKPOCCDJ + ". Set PhotonNetwork.OnEventCall.");
					}
				}
				break;
			case 226:
				this.PlayersInRoomsCount = (int)ADNNKPOCCDJ[229];
				this.PlayersOnMasterCount = (int)ADNNKPOCCDJ[227];
				this.RoomsCount = (int)ADNNKPOCCDJ[228];
				break;
			case 229:
			{
				ExitGames.Client.Photon.Hashtable hashtable3 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[222];
				foreach (object obj in hashtable3.Keys)
				{
					string text = (string)obj;
					RoomInfo roomInfo = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable3[obj]);
					if (roomInfo.removedFromList)
					{
						this.mGameList.Remove(text);
					}
					else
					{
						this.mGameList[text] = roomInfo;
					}
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate, new object[0]);
				break;
			}
			case 230:
			{
				this.mGameList = new Dictionary<string, RoomInfo>();
				ExitGames.Client.Photon.Hashtable hashtable4 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[222];
				foreach (object obj2 in hashtable4.Keys)
				{
					string text2 = (string)obj2;
					this.mGameList[text2] = new RoomInfo(text2, (ExitGames.Client.Photon.Hashtable)hashtable4[obj2]);
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate, new object[0]);
				break;
			}
			}
			break;
		case 207:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int num5 = (int)hashtable2[0];
			if (num5 >= 0)
			{
				this.DestroyPlayerObjects(num5, true);
			}
			else
			{
				if (this.DebugOut >= DebugLevel.INFO)
				{
					Debug.Log("Ev DestroyAll! By PlayerId: " + num);
				}
				this.DestroyAll(true);
			}
			break;
		}
		case 208:
		{
			ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)ADNNKPOCCDJ[245];
			int phigecolkkn = (int)hashtable2[1];
			this.LGPBHHOJPCA(phigecolkkn, false);
			break;
		}
		case 209:
		{
			int[] array5 = (int[])ADNNKPOCCDJ.Parameters[245];
			int num6 = array5[0];
			int num7 = array5[1];
			PhotonView photonView2 = PhotonView.Find(num6);
			if (photonView2 == null)
			{
				Debug.LogWarning("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: " + num6);
			}
			else
			{
				if (PhotonNetwork.logLevel == PhotonLogLevel.Informational)
				{
					Debug.Log(string.Concat(new object[]
					{
						"Ev OwnershipRequest ",
						photonView2.ownershipTransfer,
						". ActorNr: ",
						num,
						" takes from: ",
						num7,
						". local RequestedView.ownerId: ",
						photonView2.ownerId,
						" isOwnerActive: ",
						photonView2.isOwnerActive,
						". MasterClient: ",
						this.mMasterClientId,
						". This client's player: ",
						PhotonNetwork.player.ToStringFull()
					}));
				}
				switch (photonView2.ownershipTransfer)
				{
				case OwnershipOption.Fixed:
					Debug.LogWarning("Ownership mode == fixed. Ignoring request.");
					break;
				case OwnershipOption.Takeover:
					if (num7 == photonView2.ownerId || (num7 == 0 && photonView2.ownerId == this.mMasterClientId) || photonView2.ownerId == 0)
					{
						photonView2.OwnerShipWasTransfered = true;
						int ownerId = photonView2.ownerId;
						PhotonPlayer photonPlayer2 = this.ICMGDHDNIJD(ownerId);
						photonView2.ownerId = num;
						if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
						{
							Debug.LogWarning(photonView2 + " ownership transfered to: " + num);
						}
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnOwnershipTransfered, new object[]
						{
							photonView2,
							photonPlayer,
							photonPlayer2
						});
					}
					break;
				case OwnershipOption.Request:
					if ((num7 == PhotonNetwork.player.ID || PhotonNetwork.player.IsMasterClient) && (photonView2.ownerId == PhotonNetwork.player.ID || (PhotonNetwork.player.IsMasterClient && !photonView2.isOwnerActive)))
					{
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnOwnershipRequest, new object[]
						{
							photonView2,
							photonPlayer
						});
					}
					break;
				}
			}
			break;
		}
		case 210:
		{
			int[] array6 = (int[])ADNNKPOCCDJ.Parameters[245];
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(string.Concat(new object[]
				{
					"Ev OwnershipTransfer. ViewID ",
					array6[0],
					" to: ",
					array6[1],
					" Time: ",
					Environment.TickCount % 1000
				}));
			}
			int nadliachbno = array6[0];
			int num8 = array6[1];
			PhotonView photonView3 = PhotonView.Find(nadliachbno);
			if (photonView3 != null)
			{
				int ownerId2 = photonView3.ownerId;
				photonView3.OwnerShipWasTransfered = true;
				photonView3.ownerId = num8;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnOwnershipTransfered, new object[]
				{
					photonView3,
					PhotonPlayer.Find(num8),
					PhotonPlayer.Find(ownerId2)
				});
			}
			break;
		}
		}
	}

	// Token: 0x0600AF7F RID: 44927 RVA: 0x004087BF File Offset: 0x004069BF
	public List<Region> PKIDPHFLDBP()
	{
		return this.<GMPLFLCBMGI>k__BackingField;
	}

	// Token: 0x0600AF80 RID: 44928 RVA: 0x0040C530 File Offset: 0x0040A730
	private bool DONKMNHEACD(object CFKDMFFFPJK, object GOLMELKEAFO)
	{
		if (CFKDMFFFPJK == null || GOLMELKEAFO == null)
		{
			return CFKDMFFFPJK == null && GOLMELKEAFO == null;
		}
		if (!CFKDMFFFPJK.Equals(GOLMELKEAFO))
		{
			if (CFKDMFFFPJK is Vector3)
			{
				Vector3 mpnmoonbmii = (Vector3)CFKDMFFFPJK;
				Vector3 biccgcfnnlp = (Vector3)GOLMELKEAFO;
				if (mpnmoonbmii.AlmostEquals(biccgcfnnlp, PhotonNetwork.precisionForVectorSynchronization))
				{
					return true;
				}
			}
			else if (CFKDMFFFPJK is Vector2)
			{
				Vector2 mpnmoonbmii2 = (Vector2)CFKDMFFFPJK;
				Vector2 biccgcfnnlp2 = (Vector2)GOLMELKEAFO;
				if (mpnmoonbmii2.AlmostEquals(biccgcfnnlp2, PhotonNetwork.precisionForVectorSynchronization))
				{
					return false;
				}
			}
			else if (CFKDMFFFPJK is Quaternion)
			{
				Quaternion mpnmoonbmii3 = (Quaternion)CFKDMFFFPJK;
				Quaternion biccgcfnnlp3 = (Quaternion)GOLMELKEAFO;
				if (mpnmoonbmii3.AlmostEquals(biccgcfnnlp3, PhotonNetwork.precisionForQuaternionSynchronization))
				{
					return false;
				}
			}
			else if (CFKDMFFFPJK is float)
			{
				float mpnmoonbmii4 = (float)CFKDMFFFPJK;
				float biccgcfnnlp4 = (float)GOLMELKEAFO;
				if (mpnmoonbmii4.AlmostEquals(biccgcfnnlp4, PhotonNetwork.precisionForFloatSynchronization))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x0040C635 File Offset: 0x0040A835
	// (set) Token: 0x0600AFCB RID: 45003 RVA: 0x00410A57 File Offset: 0x0040EC57
	public Room CurrentRoom
	{
		get
		{
			if (this.NBCIDPIDCDP != null && this.NBCIDPIDCDP.IsLocalClientInside)
			{
				return this.NBCIDPIDCDP;
			}
			return null;
		}
		private set
		{
			this.NBCIDPIDCDP = value;
		}
	}

	// Token: 0x0600AF83 RID: 44931 RVA: 0x0040C65C File Offset: 0x0040A85C
	private bool LFAPOBNFPPO(object[] OMGHPPEONFN, object[] BGJHIKDFIMP)
	{
		if (OMGHPPEONFN == null && BGJHIKDFIMP == null)
		{
			return true;
		}
		if (OMGHPPEONFN == null || BGJHIKDFIMP == null || OMGHPPEONFN.Length != BGJHIKDFIMP.Length)
		{
			return false;
		}
		for (int i = 0; i < BGJHIKDFIMP.Length; i++)
		{
			object cfkdmfffpjk = BGJHIKDFIMP[i];
			object golmelkeafo = OMGHPPEONFN[i];
			if (!this.LFAPOBNFPPO(cfkdmfffpjk, golmelkeafo))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600AF84 RID: 44932 RVA: 0x0040C6BC File Offset: 0x0040A8BC
	public void DebugReturn(DebugLevel DCMIEONIJMA, string JKPJCEMPAGH)
	{
		if (DCMIEONIJMA == DebugLevel.ERROR)
		{
			Debug.LogError(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.WARNING)
		{
			Debug.LogWarning(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.INFO && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(JKPJCEMPAGH);
		}
		else if (DCMIEONIJMA == DebugLevel.ALL && PhotonNetwork.logLevel == PhotonLogLevel.Full)
		{
			Debug.Log(JKPJCEMPAGH);
		}
	}

	// Token: 0x0600AF85 RID: 44933 RVA: 0x0040C724 File Offset: 0x0040A924
	private void BJHGKICFMJP()
	{
		bool flag = this.CurrentRoom == null;
		bool flag2 = (this.CurrentRoom == null) ? PhotonNetwork.autoCleanUpPlayerObjects : this.CurrentRoom.IHKCBNNMLNK();
		this.hasSwitchedMC = false;
		this.NLEEJPDKBFH(null);
		this.mActors = new Dictionary<int, PhotonPlayer>();
		this.mPlayerListCopy = new PhotonPlayer[0];
		this.mOtherPlayerListCopy = new PhotonPlayer[1];
		this.CHIJNBAJIHE = new HashSet<byte>();
		this.FFBGBLFBHOK = new HashSet<byte>();
		this.mGameList = new Dictionary<string, RoomInfo>();
		this.mGameListCopy = new RoomInfo[0];
		this.POHIMACBDGL = false;
		this.ChangeLocalID(-1);
		if (flag2)
		{
			this.HMNMFOJCHBJ(false);
			PhotonNetwork.JMCPHFPJEJC = new List<int>();
		}
		if (flag)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom, new object[1]);
		}
	}

	// Token: 0x0600AF86 RID: 44934 RVA: 0x00409A05 File Offset: 0x00407C05
	public TypedLobby GMFCEODBPGN()
	{
		return this.<IGGEJKPFJJD>k__BackingField;
	}

	// Token: 0x0600AF87 RID: 44935 RVA: 0x0040C7F4 File Offset: 0x0040A9F4
	protected internal string APACDJMLLEH()
	{
		return string.Format("?", PhotonNetwork.gameVersion, "mapselector.filter.subscribedonly");
	}

	// Token: 0x0600AF88 RID: 44936 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnMessage(object NBCIEBFNLGN)
	{
	}

	// Token: 0x0600AF89 RID: 44937 RVA: 0x0040C80A File Offset: 0x0040AA0A
	public virtual bool OpLeave()
	{
		if (this.State != ClientState.Joined)
		{
			Debug.LogWarning("Not sending leave operation. State is not 'Joined': " + this.State);
			return false;
		}
		return this.OpCustom(254, null, true, 0);
	}

	// Token: 0x0600AF8A RID: 44938 RVA: 0x0040C843 File Offset: 0x0040AA43
	public virtual bool FNPGHPPDNCJ(string[] MIMEHFLKIIG)
	{
		if (this.POHIMACBDGL)
		{
			return true;
		}
		this.BEIPFKHGHPC = MIMEHFLKIIG;
		this.POHIMACBDGL = false;
		return base.CKBCKDPCODK(MIMEHFLKIIG);
	}

	// Token: 0x0600AF8B RID: 44939 RVA: 0x0040C868 File Offset: 0x0040AA68
	private string IHAJBEOILOE()
	{
		ConnectionProtocol transportProtocol = base.TransportProtocol;
		int num = 0;
		BNGIGHBHPEH.AEGGDHEGGCL.TryGetValue(transportProtocol, out num);
		string arg = string.Empty;
		if (transportProtocol == ConnectionProtocol.WebSocket)
		{
			arg = "ws://";
		}
		else if (transportProtocol == ConnectionProtocol.WebSocketSecure)
		{
			arg = "wss://";
		}
		return string.Format("{0}{1}:{2}", arg, "ns.exitgames.com", num);
	}

	// Token: 0x0600AF8C RID: 44940 RVA: 0x0040C8C9 File Offset: 0x0040AAC9
	protected internal void NJEJHIPKGKD()
	{
		PhotonNetworkingMessage lelhnddckco = PhotonNetworkingMessage.OnConnectedToPhoton;
		object[] array = new object[1];
		array[1] = PhotonNetwork.masterClient;
		BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array);
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x0600AF8D RID: 44941 RVA: 0x0040C8DF File Offset: 0x0040AADF
	public bool IsAuthorizeSecretAvailable
	{
		get
		{
			return this.AuthValues != null && !string.IsNullOrEmpty(this.AuthValues.Token);
		}
	}

	// Token: 0x0600AF8E RID: 44942 RVA: 0x0040C902 File Offset: 0x0040AB02
	protected internal void GBBHGHDFLAB()
	{
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftLobby, new object[]
		{
			PhotonNetwork.masterClient
		});
	}

	// Token: 0x0600AF8F RID: 44943 RVA: 0x0040C918 File Offset: 0x0040AB18
	public void AJJHLPGHNHL(StatusCode FIIDDDBNCLD)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Format("_Value2", FIIDDDBNCLD.ToString(), this.EBAJHBFJFCL()));
		}
		switch (FIIDDDBNCLD)
		{
		case (StatusCode)(-156):
		case (StatusCode)(-154):
		case (StatusCode)(-153):
		case (StatusCode)(-152):
			if (this.IsInitialConnect)
			{
				object[] array = new object[7];
				array[0] = FIIDDDBNCLD;
				array[1] = "MenuScene";
				array[3] = base.ServerAddress;
				array[3] = "_Noise";
				Debug.LogWarning(string.Concat(array));
				this.IsInitialConnect = true;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)71;
				object[] array2 = new object[0];
				array2[0] = disconnectCause;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array2);
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)38;
				object[] array3 = new object[0];
				array3[1] = disconnectCause;
				BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco2, array3);
			}
			if (this.AuthValues != null)
			{
				this.IJHIEINKMFP().AIOHGAFEHJG(null);
			}
			this.Disconnect();
			return;
		case (StatusCode)(-155):
			if (this.IsInitialConnect)
			{
				if (!this.IDOAHFHJJJE)
				{
					object[] array4 = new object[4];
					array4[0] = FIIDDDBNCLD;
					array4[1] = "_MidGrey";
					array4[7] = base.ServerAddress;
					array4[3] = "_Value2";
					Debug.LogWarning(string.Concat(array4));
					this.IsInitialConnect = true;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnCreatedRoom, new object[]
					{
						disconnectCause
					});
				}
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				PhotonNetworkingMessage lelhnddckco3 = (PhotonNetworkingMessage)(-71);
				object[] array5 = new object[0];
				array5[1] = disconnectCause;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco3, array5);
			}
			if (this.IJHIEINKMFP() != null)
			{
				this.AuthValues.FNCDLDJFJAM(null);
			}
			this.Disconnect();
			return;
		default:
			switch (FIIDDDBNCLD)
			{
			case (StatusCode)(-172):
			case (StatusCode)(-171):
			{
				this.IsInitialConnect = false;
				this.State = ClientState.PeerCreated;
				if (this.AuthValues != null)
				{
					this.AuthValues.AIOHGAFEHJG(null);
				}
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)90, new object[]
				{
					disconnectCause
				});
				return;
			}
			case (StatusCode)(-170):
				if (this.State == (ClientState)(-62))
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)5)
					{
						Debug.Log("workshop.");
					}
					this.AJIAHPCFPAA((ServerConnection)6);
					if (this.IJHIEINKMFP() != null)
					{
						this.IJHIEINKMFP().FNCDLDJFJAM(null);
					}
				}
				if (this.EBAJHBFJFCL() == ClientState.Uninitialized)
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)3)
					{
						Debug.Log("player.redarc");
					}
					this.EHALCLFLGJF = ServerConnection.MasterServer;
					this.JNPKDLEMJFN(ClientState.Joining);
				}
				if (this.State == (ClientState)59)
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)3)
					{
						Debug.Log("SetParticlesColor");
					}
					this.LNKHKBBMMIA(ServerConnection.MasterServer);
					this.State = (ClientState)50;
					if (this.IsInitialConnect)
					{
						this.IsInitialConnect = false;
						BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnConnectedToPhoton, new object[1]);
					}
				}
				if (base.TransportProtocol != ConnectionProtocol.Udp)
				{
					if (this.EHALCLFLGJF == (ServerConnection)7 || this.AuthMode == AuthModeOption.Auth)
					{
						base.EstablishEncryption();
					}
					return;
				}
				if (this.DebugOut == DebugLevel.WARNING)
				{
					Debug.Log("Joystick1Button9");
				}
				goto IL_1AC;
			case (StatusCode)(-169):
				this.DMCPHGDNGDB = false;
				this.POHIMACBDGL = false;
				if (this.IGDBHCGGHFF() == ServerConnection.MasterServer)
				{
					this.BOJKDNJHBNG();
				}
				if (this.IGDBHCGGHFF() == ServerConnection.MasterServer)
				{
					this.IFPPBJINADG();
				}
				if (this.EBAJHBFJFCL() == ClientState.JoinedLobby)
				{
					if (this.Connect(this.GameServerAddress, ServerConnection.GameServer))
					{
						this.State = ClientState.Uninitialized;
					}
				}
				else if (this.State == (ClientState)102 || this.EBAJHBFJFCL() == (ClientState)46)
				{
					this.FKNEKIDFEIA(ServerConnection.MasterServer);
					if (this.Connect(this.MasterServerAddress, ServerConnection.GameServer))
					{
						this.State = (ClientState)(-34);
					}
				}
				else
				{
					if (this.IDOAHFHJJJE)
					{
						return;
					}
					if (this.AuthValues != null)
					{
						this.IJHIEINKMFP().NJJEJBOAEDG(null);
					}
					this.IsInitialConnect = false;
					this.JNPKDLEMJFN(ClientState.PeerCreated);
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftLobby, new object[0]);
				}
				return;
			case (StatusCode)(-168):
				if (this.IsInitialConnect)
				{
					Debug.LogError("_Bullet_7" + base.ServerAddress + "settings.enablehitsoundsinrelax");
					if (base.ServerAddress == null || base.ServerAddress.StartsWith(": "))
					{
						Debug.LogWarning("/?page=ranks");
						if (base.ServerAddress == this.GameServerAddress)
						{
							Debug.LogWarning("menu.playedpage");
						}
					}
					this.JNPKDLEMJFN(ClientState.Uninitialized);
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					this.IsInitialConnect = false;
					PhotonNetworkingMessage lelhnddckco4 = (PhotonNetworkingMessage)(-80);
					object[] array6 = new object[0];
					array6[1] = disconnectCause;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco4, array6);
				}
				else
				{
					this.State = ClientState.Uninitialized;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					PhotonNetworkingMessage lelhnddckco5 = PhotonNetworkingMessage.OnMasterClientSwitched;
					object[] array7 = new object[0];
					array7[0] = disconnectCause;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco5, array7);
				}
				this.Disconnect();
				return;
			case (StatusCode)(-164):
				return;
			}
			Debug.LogError(": " + FIIDDDBNCLD);
			return;
		case (StatusCode)(-147):
			break;
		case (StatusCode)(-146):
		{
			Debug.LogError("_ScreenResolution" + FIIDDDBNCLD + "No valid adaptive tonemapper type found!");
			AuthenticationValues authenticationValues;
			if ((authenticationValues = this.AuthValues) == null)
			{
				AuthenticationValues authenticationValues2 = new AuthenticationValues();
				authenticationValues2.JCECBNKFODG(this.PlayerName);
				authenticationValues = authenticationValues2;
			}
			AuthenticationValues gpdfhodmoij = authenticationValues;
			this.HIKIDBBNFBM(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CAFLFPLLMNC().ToString(), this.ADPDMHEPOMG());
			return;
		}
		}
		IL_1AC:
		this.IDOAHFHJJJE = false;
		if (this.NJIFBFEHJKH() == ServerConnection.MasterServer)
		{
			this.State = (ClientState)68;
			if (!this.DMCPHGDNGDB && this.CAFLFPLLMNC() == CloudRegionCode.au)
			{
				this.MPKLAJGIHGP(this.KAIBLIKEDHM);
			}
		}
		if (this.NJIFBFEHJKH() != (ServerConnection)3 && (this.AuthMode == AuthModeOption.AuthOnce || this.AuthMode == AuthModeOption.AuthOnce))
		{
			object[] array8 = new object[3];
			array8[1] = "settings.enablehitsoundsinnormal";
			array8[1] = this.DMCPHGDNGDB;
			array8[6] = "Committing changes...";
			array8[4] = this.AuthMode;
			Debug.Log(string.Concat(array8));
		}
		else if (!this.DMCPHGDNGDB && (!this.IsUsingNameServer || this.CloudRegion != CloudRegionCode.sa))
		{
			this.DMCPHGDNGDB = this.GHBFBICEHBK();
			if (this.DMCPHGDNGDB)
			{
				this.State = (ClientState)53;
			}
		}
	}

	// Token: 0x0600AF90 RID: 44944 RVA: 0x0040CF6C File Offset: 0x0040B16C
	public void NewSceneLoaded()
	{
		if (this.HMIEGLIHGEM)
		{
			this.HMIEGLIHGEM = false;
			PhotonNetwork.isMessageQueueRunning = true;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, PhotonView> keyValuePair in this.HFCMPEKPBAM)
		{
			PhotonView value = keyValuePair.Value;
			if (value == null)
			{
				list.Add(keyValuePair.Key);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			int key = list[i];
			this.HFCMPEKPBAM.Remove(key);
		}
		if (list.Count > 0 && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log("New level loaded. Removed " + list.Count + " scene view IDs from last level.");
		}
	}

	// Token: 0x0600AF91 RID: 44945 RVA: 0x0040D06C File Offset: 0x0040B26C
	private void AMFFFOBFFFM()
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[108] = 1;
		dictionary[(byte)-68] = 2;
		this.OpCustom((byte)-108, dictionary, true, 0);
	}

	// Token: 0x0600AF92 RID: 44946 RVA: 0x0040D0B0 File Offset: 0x0040B2B0
	public void RegisterPhotonView(PhotonView LCJKMJCFDGE)
	{
		if (!Application.isPlaying)
		{
			this.HFCMPEKPBAM = new Dictionary<int, PhotonView>();
			return;
		}
		if (LCJKMJCFDGE.viewID == 0)
		{
			Debug.Log("PhotonView register is ignored, because viewID is 0. No id assigned yet to: " + LCJKMJCFDGE);
			return;
		}
		PhotonView photonView = null;
		bool flag = this.HFCMPEKPBAM.TryGetValue(LCJKMJCFDGE.viewID, out photonView);
		if (flag)
		{
			if (!(LCJKMJCFDGE != photonView))
			{
				return;
			}
			Debug.LogError(string.Format("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", LCJKMJCFDGE.viewID, LCJKMJCFDGE, photonView));
			this.EFDAOHIDIIF(photonView.gameObject, true);
		}
		this.HFCMPEKPBAM.Add(LCJKMJCFDGE.viewID, LCJKMJCFDGE);
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
		{
			Debug.Log("Registered PhotonView: " + LCJKMJCFDGE.viewID);
		}
	}

	// Token: 0x0600AF93 RID: 44947 RVA: 0x0040D17D File Offset: 0x0040B37D
	private void JOANOODGGAG(int IJAEJMNLBLK, PhotonPlayer JHOEDACNNKK)
	{
		if (!this.mActors.ContainsKey(IJAEJMNLBLK))
		{
			this.mActors[IJAEJMNLBLK] = JHOEDACNNKK;
			this.LEMBPMNPHCK();
		}
		else
		{
			Debug.LogError("AddEnvironmentSprite" + IJAEJMNLBLK);
		}
	}

	// Token: 0x0600AF94 RID: 44948 RVA: 0x0040D1C0 File Offset: 0x0040B3C0
	private bool AKIBKCFMMHO()
	{
		this.IDOAHFHJJJE = true;
		PhotonNetwork.SwitchToProtocol(PhotonNetwork.PhotonServerSettings.Protocol);
		this.KHKMFIFGPCH(this.PKNIJKPIKAF);
		bool flag = base.Connect(this.BLNBCGLIOHP, this.KAOMEDGGMEM, this.LLJDHHLHFME);
		if (flag)
		{
			ServerConnection pknijkpikaf = this.PKNIJKPIKAF;
			if (pknijkpikaf != ServerConnection.NameServer)
			{
				if (pknijkpikaf != ServerConnection.MasterServer)
				{
					if (pknijkpikaf == ServerConnection.GameServer)
					{
						this.State = ClientState.ConnectingToGameserver;
					}
				}
				else
				{
					this.State = ClientState.ConnectingToMasterserver;
				}
			}
			else
			{
				this.State = ClientState.ConnectingToNameServer;
			}
		}
		return flag;
	}

	// Token: 0x0600AF95 RID: 44949 RVA: 0x0040D255 File Offset: 0x0040B455
	public void DestroyAll(bool NOKCKEBHIFJ)
	{
		if (!NOKCKEBHIFJ)
		{
			this.OpRemoveCompleteCache();
			this.EBNDKPFKPIJ();
		}
		this.OMEPCMPKIJK(true);
	}

	// Token: 0x0600AF96 RID: 44950 RVA: 0x0040D270 File Offset: 0x0040B470
	private void PCLPOPNEABK(OperationResponse FEOMHKNGOAK)
	{
		if (FEOMHKNGOAK.ReturnCode != 0)
		{
			byte operationCode = FEOMHKNGOAK.OperationCode;
			if (operationCode != 227)
			{
				if (operationCode != 226)
				{
					if (operationCode == 225)
					{
						if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
						{
							Debug.Log("Join failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
							if (FEOMHKNGOAK.ReturnCode == 32758)
							{
								Debug.Log("Most likely the game became empty during the switch to GameServer.");
							}
						}
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonRandomJoinFailed, new object[]
						{
							FEOMHKNGOAK.ReturnCode,
							FEOMHKNGOAK.DebugMessage
						});
					}
				}
				else
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log("Join failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
						if (FEOMHKNGOAK.ReturnCode == 32758)
						{
							Debug.Log("Most likely the game became empty during the switch to GameServer.");
						}
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinRoomFailed, new object[]
					{
						FEOMHKNGOAK.ReturnCode,
						FEOMHKNGOAK.DebugMessage
					});
				}
			}
			else
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.Log("Create failed on GameServer. Changing back to MasterServer. Msg: " + FEOMHKNGOAK.DebugMessage);
				}
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateRoomFailed, new object[]
				{
					FEOMHKNGOAK.ReturnCode,
					FEOMHKNGOAK.DebugMessage
				});
			}
			this.NDPIAMOMGME();
			return;
		}
		this.CurrentRoom = new Room(this.AJFMHFLGCFN.RoomName, null)
		{
			IsLocalClientInside = true
		};
		this.State = ClientState.Joined;
		if (FEOMHKNGOAK.Parameters.ContainsKey(252))
		{
			int[] homaecigjej = (int[])FEOMHKNGOAK.Parameters[252];
			this.ANEENOJMDOJ(homaecigjej);
		}
		int lghipfaeonm = (int)FEOMHKNGOAK[254];
		this.ChangeLocalID(lghipfaeonm);
		ExitGames.Client.Photon.Hashtable faolpblckfj = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[249];
		ExitGames.Client.Photon.Hashtable mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[248];
		this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, 0);
		if (!this.CurrentRoom.BDHOOLIDFJO)
		{
			this.CDNPLJILLFC(-1);
		}
		if (this.BOKEGDFHBAN)
		{
			this.PACEKOIEHKK();
		}
		byte operationCode2 = FEOMHKNGOAK.OperationCode;
		if (operationCode2 != 227)
		{
			if (operationCode2 != 226 && operationCode2 != 225)
			{
			}
		}
		else
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCreatedRoom, new object[0]);
		}
	}

	// Token: 0x0600AF97 RID: 44951 RVA: 0x0040D4DC File Offset: 0x0040B6DC
	private void KIKHKNNMBMN()
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[244] = 0;
		dictionary[247] = 7;
		this.OpCustom(253, dictionary, true, 0);
	}

	// Token: 0x0600AF98 RID: 44952 RVA: 0x0040D520 File Offset: 0x0040B720
	protected internal void FKNEKIDFEIA(ServerConnection NKGHPPHEGCO)
	{
		ConnectionProtocol connectionProtocol = base.TransportProtocol;
		if (this.AuthMode == (AuthModeOption)8)
		{
			if (NKGHPPHEGCO != (ServerConnection)3)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning("maps." + PhotonNetwork.PhotonServerSettings.Protocol);
				}
				connectionProtocol = PhotonNetwork.PhotonServerSettings.Protocol;
			}
			else
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
				}
				connectionProtocol = ConnectionProtocol.Tcp;
			}
		}
		Type type = Type.GetType("GlassDistortion", true);
		if (type == null)
		{
			type = Type.GetType("BadgeText", false);
		}
		if (type != null)
		{
			this.SocketImplementationConfig[ConnectionProtocol.Tcp] = type;
			this.SocketImplementationConfig[(ConnectionProtocol)6] = type;
		}
		if (PhotonHandler.LEILCLLNGGH == null)
		{
			PhotonHandler.LEILCLLNGGH = typeof(PingMono);
		}
		if (base.TransportProtocol == connectionProtocol)
		{
			return;
		}
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			object[] array = new object[3];
			array[1] = "CameraFilterPack/TV_50";
			array[0] = base.TransportProtocol;
			array[6] = "CameraFilterPack/TV_WideScreenHV";
			array[8] = connectionProtocol;
			array[0] = "COMPLETED";
			Debug.LogWarning(string.Concat(array));
		}
		base.TransportProtocol = connectionProtocol;
	}

	// Token: 0x0600AF99 RID: 44953 RVA: 0x0040D650 File Offset: 0x0040B850
	private bool GHBFBICEHBK()
	{
		AuthenticationValues authenticationValues;
		if ((authenticationValues = this.AuthValues) == null)
		{
			AuthenticationValues authenticationValues2 = new AuthenticationValues();
			authenticationValues2.MIHBPLHLFGG(this.PlayerName);
			authenticationValues = authenticationValues2;
		}
		AuthenticationValues gpdfhodmoij = authenticationValues;
		if (this.AuthMode == AuthModeOption.Auth)
		{
			return this.HIKIDBBNFBM(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CAFLFPLLMNC().ToString(), this.OGLFGPKHEHH);
		}
		return this.MDEGPIGGGEE(this.KAIBLIKEDHM, this.DCHLIDBMJPK(), gpdfhodmoij, this.CAFLFPLLMNC().ToString(), this.EncryptionMode, PhotonNetwork.PhotonServerSettings.Protocol);
	}

	// Token: 0x0600AF9A RID: 44954 RVA: 0x00405462 File Offset: 0x00403662
	public CloudRegionCode CAFLFPLLMNC()
	{
		return this.<JINPEAIHFKC>k__BackingField;
	}

	// Token: 0x0600AF9B RID: 44955 RVA: 0x0040D6F0 File Offset: 0x0040B8F0
	private void EBNDKPFKPIJ()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = -1;
		this.OpRaiseEvent(207, hashtable, true, null);
	}

	// Token: 0x0600AF9C RID: 44956 RVA: 0x0040D724 File Offset: 0x0040B924
	public bool WebRpc(string MDGGHHCAHKF, object GNNEKCBOBEG)
	{
		return this.OpCustom(219, new Dictionary<byte, object>
		{
			{
				209,
				MDGGHHCAHKF
			},
			{
				208,
				GNNEKCBOBEG
			}
		}, true);
	}

	// Token: 0x0600AF9D RID: 44957 RVA: 0x0040D75C File Offset: 0x0040B95C
	public void GEJPEGFKLFM(OperationResponse FEOMHKNGOAK)
	{
		if (PhotonNetwork.JNJJAMNLOHA.State == (ClientState)(-8))
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("/../" + FEOMHKNGOAK.OperationCode);
			}
			return;
		}
		if (FEOMHKNGOAK.ReturnCode == 0)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log(FEOMHKNGOAK.ToString());
			}
		}
		else if (FEOMHKNGOAK.ReturnCode == 98)
		{
			Debug.LogError("SpawnObj" + FEOMHKNGOAK.OperationCode + "CameraFilterPack/Distortion_FishEye");
		}
		else if (FEOMHKNGOAK.ReturnCode == 181)
		{
			object[] array = new object[6];
			array[0] = "Show image from resources by id at the center of the screen at foreground or background";
			array[1] = FEOMHKNGOAK.OperationCode;
			array[7] = "/icon";
			array[7] = FEOMHKNGOAK.DebugMessage;
			Debug.LogError(string.Concat(array));
		}
		else if (FEOMHKNGOAK.ReturnCode == 56)
		{
			Debug.LogWarning("player.blackwhite" + FEOMHKNGOAK.ToStringFull());
		}
		else
		{
			object[] array2 = new object[4];
			array2[1] = "0 - sun, 1 - satellite, 2 - particles emitter";
			array2[1] = FEOMHKNGOAK.ToStringFull();
			array2[1] = "ERROR You have missing MonoBehaviours on your gameobjects!";
			array2[2] = this.IGDBHCGGHFF();
			Debug.LogError(string.Concat(array2));
		}
		if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-97))
		{
			if (this.AuthValues == null)
			{
				this.HBABOJOMPHP(new AuthenticationValues());
			}
			this.AuthValues.NJJEJBOAEDG(FEOMHKNGOAK[(byte)-96] as string);
			this.JOKLGFENMKE = this.AuthValues.DGINDFBNNDO();
		}
		byte operationCode = FEOMHKNGOAK.OperationCode;
		switch (operationCode)
		{
		case 63:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				this.ELEMKNKGNIP(DebugLevel.ERROR, "player.greenlifering" + FEOMHKNGOAK.ToStringFull());
			}
			else
			{
				this.mGameList = new Dictionary<string, RoomInfo>();
				ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[58];
				foreach (object obj in hashtable.Keys)
				{
					string text = (string)obj;
					this.mGameList[text] = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable[obj]);
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnDisconnectedFromPhoton, new object[1]);
			}
			break;
		default:
			switch (operationCode)
			{
			case 62:
			{
				ExitGames.Client.Photon.Hashtable faolpblckfj = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[(byte)-187];
				ExitGames.Client.Photon.Hashtable mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[(byte)-133];
				this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, 1);
				break;
			}
			case 63:
				break;
			case 64:
				break;
			case 65:
				this.NDPIAMOMGME();
				break;
			default:
				Debug.LogWarning(string.Format("Item ", FEOMHKNGOAK.ToString()));
				break;
			}
			break;
		case 65:
		{
			PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)120;
			object[] array3 = new object[0];
			array3[1] = FEOMHKNGOAK;
			BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco, array3);
			break;
		}
		case 66:
			if (FEOMHKNGOAK.ReturnCode == -69)
			{
				Debug.LogError(string.Format("_Value4", new object[0]));
				PhotonNetworkingMessage lelhnddckco2 = (PhotonNetworkingMessage)118;
				object[] array4 = new object[0];
				array4[0] = (DisconnectCause)52;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco2, array4);
				this.JNPKDLEMJFN((ClientState)89);
				this.Disconnect();
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				object[] array5 = new object[3];
				array5[0] = "_Value";
				array5[1] = FEOMHKNGOAK.ReturnCode;
				array5[5] = "_VignettingColor";
				array5[5] = FEOMHKNGOAK.DebugMessage;
				Debug.LogError(string.Concat(array5));
			}
			else
			{
				string[] array6 = FEOMHKNGOAK[(byte)-51] as string[];
				string[] array7 = FEOMHKNGOAK[(byte)-37] as string[];
				if (array6 == null || array7 == null || array6.Length != array7.Length)
				{
					object[] array8 = new object[3];
					array8[0] = ".played";
					array8[0] = (array6 == null);
					array8[5] = "_OcclusionTexture";
					array8[5] = (array7 == null);
					array8[6] = "SetBGColor";
					array8[7] = FEOMHKNGOAK.ToStringFull();
					Debug.LogError(string.Concat(array8));
				}
				else
				{
					this.ENAIECJFPHM(new List<Region>(array6.Length));
					for (int i = 0; i < array6.Length; i += 0)
					{
						string text2 = array6[i];
						if (!string.IsNullOrEmpty(text2))
						{
							text2 = text2.ToLower();
							CloudRegionCode cloudRegionCode = Region.IAPELPAACFI(text2);
							bool flag = true;
							if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion && PhotonNetwork.PhotonServerSettings.EnabledRegions != (CloudRegionFlag)0)
							{
								CloudRegionFlag cloudRegionFlag = Region.GDAKNCCMFEI(cloudRegionCode);
								flag = ((PhotonNetwork.PhotonServerSettings.EnabledRegions & cloudRegionFlag) != CloudRegionFlag.eu);
								if (!flag && PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
								{
									Debug.Log("_Amount" + cloudRegionCode);
								}
							}
							if (flag)
							{
								this.PKIDPHFLDBP().Add(new Region(cloudRegionCode, text2, array7[i]));
							}
						}
					}
					if (PhotonNetwork.PhotonServerSettings.HostType == (ServerSettings.HostingOption)8)
					{
						PhotonHandler.HHFBHNGHJFO();
					}
				}
			}
			break;
		case 68:
		{
			bool[] array9 = FEOMHKNGOAK[1] as bool[];
			string[] array10 = FEOMHKNGOAK[5] as string[];
			if (array9 != null && array10 != null && this.BEIPFKHGHPC != null && array9.Length == this.BEIPFKHGHPC.Length)
			{
				List<FriendInfo> list = new List<FriendInfo>(this.BEIPFKHGHPC.Length);
				for (int j = 1; j < this.BEIPFKHGHPC.Length; j++)
				{
					FriendInfo friendInfo = new FriendInfo();
					friendInfo.PCGCFHPAMMB(this.BEIPFKHGHPC[j]);
					friendInfo.LPHFBDMMCFL(array10[j]);
					friendInfo.KEACDHPPPPE(array9[j]);
					list.Insert(j, friendInfo);
				}
				PhotonNetwork.Friends = list;
			}
			else
			{
				Debug.LogError("Scene");
			}
			this.BEIPFKHGHPC = null;
			this.POHIMACBDGL = false;
			this.DJIOCIPPBMK = Environment.TickCount;
			if (this.DJIOCIPPBMK == 0)
			{
				this.DJIOCIPPBMK = 0;
			}
			BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)86, new object[1]);
			break;
		}
		case 71:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 138)
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)7)
					{
						Debug.Log("Joystick1Button8");
					}
				}
				else if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("_Value", FEOMHKNGOAK.ToStringFull()));
				}
				PhotonNetworkingMessage lelhnddckco3 = PhotonNetworkingMessage.OnPhotonPlayerDisconnected;
				object[] array11 = new object[5];
				array11[0] = FEOMHKNGOAK.ReturnCode;
				array11[0] = FEOMHKNGOAK.DebugMessage;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco3, array11);
			}
			else
			{
				string roomName = (string)FEOMHKNGOAK[(byte)-99];
				this.AJFMHFLGCFN.RoomName = roomName;
				this.NHKBIPAKHOJ((string)FEOMHKNGOAK[(byte)-96]);
				this.MOHFIPIDGOH();
			}
			break;
		case 72:
			if (this.NJIFBFEHJKH() != ServerConnection.GameServer)
			{
				if (FEOMHKNGOAK.ReturnCode != 0)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
					{
						Debug.Log(string.Format("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", FEOMHKNGOAK.ToStringFull(), this.EBAJHBFJFCL()));
					}
					PhotonNetworkingMessage lelhnddckco4 = PhotonNetworkingMessage.OnConnectedToPhoton;
					object[] array12 = new object[8];
					array12[0] = FEOMHKNGOAK.ReturnCode;
					array12[0] = FEOMHKNGOAK.DebugMessage;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco4, array12);
				}
				else
				{
					this.GameServerAddress = (string)FEOMHKNGOAK[(byte)-39];
					this.MOHFIPIDGOH();
				}
			}
			else
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			break;
		case 73:
			if (this.NJIFBFEHJKH() == ServerConnection.GameServer)
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
				{
					Debug.LogWarning(string.Format("Error: Cannot change the name of a remote player!", FEOMHKNGOAK.ToStringFull()));
				}
				this.State = ((!this.insideLobby) ? ((ClientState)64) : ClientState.Joining);
				PhotonNetworkingMessage lelhnddckco5 = PhotonNetworkingMessage.OnDisconnectedFromPhoton;
				object[] array13 = new object[3];
				array13[1] = FEOMHKNGOAK.ReturnCode;
				array13[1] = FEOMHKNGOAK.DebugMessage;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco5, array13);
			}
			else
			{
				string text3 = (string)FEOMHKNGOAK[(byte)-66];
				if (!string.IsNullOrEmpty(text3))
				{
					this.AJFMHFLGCFN.RoomName = text3;
				}
				this.NHKBIPAKHOJ((string)FEOMHKNGOAK[135]);
				this.NDPIAMOMGME();
			}
			break;
		case 74:
			this.State = ClientState.Authenticated;
			this.IFPPBJINADG();
			break;
		case 75:
			this.JNPKDLEMJFN(ClientState.Queued);
			this.insideLobby = true;
			BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnLeftLobby, new object[0]);
			break;
		case 76:
		case 77:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 10)
				{
					Debug.LogError(string.Format("CameraFilterPack/Pixelisation_Sweater" + base.ServerAddress, new object[1]));
				}
				else if (FEOMHKNGOAK.ReturnCode == 136)
				{
					Debug.LogError(string.Format("/512px-512px.png", new object[1]));
					PhotonNetworkingMessage lelhnddckco6 = PhotonNetworkingMessage.OnMasterClientSwitched;
					object[] array14 = new object[1];
					array14[1] = (DisconnectCause)42;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco6, array14);
				}
				else if (FEOMHKNGOAK.ReturnCode == -44)
				{
					Debug.LogError(string.Format("CameraFilterPack/Blend2Camera_Screen", new object[0]));
					PhotonNetworkingMessage lelhnddckco7 = (PhotonNetworkingMessage)120;
					object[] array15 = new object[0];
					array15[1] = FEOMHKNGOAK.DebugMessage;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco7, array15);
				}
				else
				{
					Debug.LogError(string.Format("_Distortion", FEOMHKNGOAK.DebugMessage, FEOMHKNGOAK.ReturnCode));
				}
				this.JNPKDLEMJFN((ClientState)21);
				this.Disconnect();
				if (FEOMHKNGOAK.ReturnCode == 115)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogWarning(string.Format("DifficultyBG", new object[0]));
					}
					BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)(-27), new object[1]);
					PhotonNetworkingMessage lelhnddckco8 = (PhotonNetworkingMessage)(-27);
					object[] array16 = new object[1];
					array16[1] = (DisconnectCause)51;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco8, array16);
				}
				else if (FEOMHKNGOAK.ReturnCode == -134)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("shader.crispwinter", new object[0]));
					}
					PhotonNetworkingMessage lelhnddckco9 = (PhotonNetworkingMessage)101;
					object[] array17 = new object[1];
					array17[1] = (DisconnectCause)52;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco9, array17);
				}
				else if (FEOMHKNGOAK.ReturnCode == -51)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("[MapEditor] Reset", new object[0]));
					}
					PhotonNetworkingMessage lelhnddckco10 = (PhotonNetworkingMessage)50;
					object[] array18 = new object[0];
					array18[1] = (DisconnectCause)(-171);
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco10, array18);
				}
			}
			else
			{
				if (this.EHALCLFLGJF == (ServerConnection)6 || this.NJIFBFEHJKH() == ServerConnection.MasterServer)
				{
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-92))
					{
						string text4 = (string)FEOMHKNGOAK.Parameters[(byte)-85];
						if (!string.IsNullOrEmpty(text4))
						{
							if (this.IJHIEINKMFP() == null)
							{
								this.AuthValues = new AuthenticationValues();
							}
							this.AuthValues.UserId = text4;
							PhotonNetwork.player.UserId = text4;
							if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
							{
								this.ELEMKNKGNIP((DebugLevel)6, string.Format("buttons", text4));
							}
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-68))
					{
						this.MPHFPMJMGJG((string)FEOMHKNGOAK.Parameters[52]);
						if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
						{
							this.DebugReturn(DebugLevel.INFO, string.Format("BitsData", this.OBCEIJGMKGB));
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-118))
					{
						this.IJCJBPEELEM((Dictionary<byte, object>)FEOMHKNGOAK.Parameters[(byte)-64]);
					}
				}
				if (this.EHALCLFLGJF == ServerConnection.GameServer)
				{
					this.MasterServerAddress = (FEOMHKNGOAK[(byte)-89] as string);
					this.MOHFIPIDGOH();
				}
				else if (this.NJIFBFEHJKH() == ServerConnection.MasterServer)
				{
					if (this.AuthMode != AuthModeOption.Auth)
					{
						this.KNJOPJNBFCA(this.ADPDMHEPOMG());
					}
					if (PhotonNetwork.autoJoinLobby)
					{
						this.State = ClientState.PeerCreated;
						this.FJCMOCPLACC(this.lobby);
					}
					else
					{
						this.State = (ClientState)(-30);
						BNGIGHBHPEH.CLOLHKCFMJP((PhotonNetworkingMessage)76, new object[1]);
					}
				}
				else if (this.NJIFBFEHJKH() == ServerConnection.GameServer)
				{
					this.JNPKDLEMJFN(ClientState.Joining);
					this.AJFMHFLGCFN.PlayerProperties = this.HHPBLGDNDOP();
					this.AJFMHFLGCFN.OnGameServer = false;
					if (this.ELNKFMHCMBO == JoinType.CreateRoom || this.ELNKFMHCMBO == (JoinType)8 || this.ELNKFMHCMBO == JoinType.JoinRandomRoom)
					{
						this.PNKFPJJPELO(this.AJFMHFLGCFN);
					}
					else if (this.ELNKFMHCMBO == JoinType.CreateRoom)
					{
						this.OpCreateGame(this.AJFMHFLGCFN);
					}
				}
				if (FEOMHKNGOAK.Parameters.ContainsKey(156))
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)FEOMHKNGOAK.Parameters[(byte)-92];
					if (dictionary != null)
					{
						BNGIGHBHPEH.CLOLHKCFMJP((PhotonNetworkingMessage)(-96), new object[]
						{
							dictionary
						});
					}
				}
			}
			break;
		}
	}

	// Token: 0x0600AF9E RID: 44958 RVA: 0x0040E49C File Offset: 0x0040C69C
	protected internal void ELDLAPJAPBJ()
	{
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, new object[]
		{
			PhotonNetwork.masterClient
		});
	}

	// Token: 0x0600AF9F RID: 44959 RVA: 0x0040E4B4 File Offset: 0x0040C6B4
	public static void SendMonoMessage(PhotonNetworkingMessage LELHNDDCKCO, params object[] GNNEKCBOBEG)
	{
		HashSet<GameObject> hashSet;
		if (PhotonNetwork.SendMonoMessageTargets != null)
		{
			hashSet = PhotonNetwork.SendMonoMessageTargets;
		}
		else
		{
			hashSet = PhotonNetwork.FindGameObjectsWithComponent(PhotonNetwork.SendMonoMessageTargetType);
		}
		string methodName = LELHNDDCKCO.ToString();
		object value = (GNNEKCBOBEG == null || GNNEKCBOBEG.Length != 1) ? GNNEKCBOBEG : GNNEKCBOBEG[0];
		foreach (GameObject gameObject in hashSet)
		{
			if (gameObject != null)
			{
				gameObject.SendMessage(methodName, value, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	// Token: 0x0600AFA0 RID: 44960 RVA: 0x0040E564 File Offset: 0x0040C764
	private void MJMAJHJLBPJ(int IECJKEIJLCP, EventData EKDHPAFJKFA)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Concat(new object[]
			{
				"HandleEventLeave for player ID: ",
				IECJKEIJLCP,
				" evLeave: ",
				EKDHPAFJKFA.ToStringFull()
			}));
		}
		PhotonPlayer photonPlayer = this.ICMGDHDNIJD(IECJKEIJLCP);
		if (photonPlayer == null)
		{
			Debug.LogError(string.Format("Received event Leave for unknown player ID: {0}", IECJKEIJLCP));
			return;
		}
		bool isInactive = photonPlayer.IsInactive;
		if (EKDHPAFJKFA.Parameters.ContainsKey(233))
		{
			photonPlayer.IsInactive = (bool)EKDHPAFJKFA.Parameters[233];
			if (photonPlayer.IsInactive != isInactive)
			{
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerActivityChanged, new object[]
				{
					photonPlayer
				});
			}
			if (photonPlayer.IsInactive && isInactive)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					"HandleEventLeave for player ID: ",
					IECJKEIJLCP,
					" isInactive: ",
					photonPlayer.IsInactive,
					". Stopping handling if inactive."
				}));
				return;
			}
		}
		if (EKDHPAFJKFA.Parameters.ContainsKey(203))
		{
			int num = (int)EKDHPAFJKFA[203];
			if (num != 0)
			{
				this.mMasterClientId = (int)EKDHPAFJKFA[203];
				this.ELDLAPJAPBJ();
			}
		}
		else if (!this.CurrentRoom.BDHOOLIDFJO)
		{
			this.CDNPLJILLFC(IECJKEIJLCP);
		}
		if (photonPlayer.IsInactive && !isInactive)
		{
			return;
		}
		if (this.CurrentRoom != null && this.CurrentRoom.AutoCleanUp)
		{
			this.DestroyPlayerObjects(IECJKEIJLCP, true);
		}
		this.GPODJOPLJPD(IECJKEIJLCP, photonPlayer);
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerDisconnected, new object[]
		{
			photonPlayer
		});
	}

	// Token: 0x0600AFA1 RID: 44961 RVA: 0x0040E729 File Offset: 0x0040C929
	private ExitGames.Client.Photon.Hashtable LOCGDJDHCHJ(ExitGames.Client.Photon.Hashtable FPBCPOGCCBD, int KHACEEGCPEP)
	{
		if (FPBCPOGCCBD.ContainsKey(KHACEEGCPEP))
		{
			return (ExitGames.Client.Photon.Hashtable)FPBCPOGCCBD[KHACEEGCPEP];
		}
		return FPBCPOGCCBD;
	}

	// Token: 0x0600AFA2 RID: 44962 RVA: 0x0040E750 File Offset: 0x0040C950
	private void EDMCCPDDDCC(ExitGames.Client.Photon.Hashtable MJJMNIDHDEC, ExitGames.Client.Photon.Hashtable FAOLPBLCKFJ, int AHNMANJKONI)
	{
		if (FAOLPBLCKFJ != null && FAOLPBLCKFJ.Count > 0)
		{
			if (AHNMANJKONI > 0)
			{
				PhotonPlayer photonPlayer = this.ICMGDHDNIJD(AHNMANJKONI);
				if (photonPlayer != null)
				{
					ExitGames.Client.Photon.Hashtable hashtable = this.LOCGDJDHCHJ(FAOLPBLCKFJ, AHNMANJKONI);
					photonPlayer.NPOPPIMCDMN(hashtable);
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, new object[]
					{
						photonPlayer,
						hashtable
					});
				}
			}
			else
			{
				foreach (object obj in FAOLPBLCKFJ.Keys)
				{
					int num = (int)obj;
					ExitGames.Client.Photon.Hashtable hashtable2 = (ExitGames.Client.Photon.Hashtable)FAOLPBLCKFJ[obj];
					string ebehbbdkdfj = (string)hashtable2[byte.MaxValue];
					PhotonPlayer photonPlayer2 = this.ICMGDHDNIJD(num);
					if (photonPlayer2 == null)
					{
						photonPlayer2 = new PhotonPlayer(false, num, ebehbbdkdfj);
						this.EGJBHECFAOH(num, photonPlayer2);
					}
					photonPlayer2.NPOPPIMCDMN(hashtable2);
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, new object[]
					{
						photonPlayer2,
						hashtable2
					});
				}
			}
		}
		if (this.CurrentRoom != null && MJJMNIDHDEC != null)
		{
			this.CurrentRoom.NPOPPIMCDMN(MJJMNIDHDEC);
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCustomRoomPropertiesChanged, new object[]
			{
				MJJMNIDHDEC
			});
			if (PhotonNetwork.automaticallySyncScene)
			{
				this.DMCKEABNFPJ();
			}
		}
	}

	// Token: 0x0600AFA4 RID: 44964 RVA: 0x0040E904 File Offset: 0x0040CB04
	protected internal PhotonPlayer NLCNFHENKAJ(int MHLPNLMDILP)
	{
		if (this.mActors == null)
		{
			return null;
		}
		PhotonPlayer result = null;
		this.mActors.TryGetValue(MHLPNLMDILP, out result);
		return result;
	}

	// Token: 0x0600AFA5 RID: 44965 RVA: 0x0040E930 File Offset: 0x0040CB30
	protected internal void CAEIBLENDBH()
	{
		PhotonNetworkingMessage lelhnddckco = PhotonNetworkingMessage.OnJoinedLobby;
		object[] array = new object[1];
		array[1] = PhotonNetwork.masterClient;
		BNGIGHBHPEH.SendMonoMessage(lelhnddckco, array);
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x0040E946 File Offset: 0x0040CB46
	private string LLJDHHLHFME
	{
		get
		{
			if (this.AuthMode == AuthModeOption.Auth)
			{
				return null;
			}
			return (this.AuthValues == null) ? null : this.AuthValues.Token;
		}
	}

	// Token: 0x0600AFA8 RID: 44968 RVA: 0x0040C62D File Offset: 0x0040A82D
	public int JCPODEMIBMP()
	{
		return this.<EEDBHAJBPLC>k__BackingField;
	}

	// Token: 0x0600AFA9 RID: 44969 RVA: 0x0040E971 File Offset: 0x0040CB71
	private bool ADPDMHEPOMG()
	{
		return PhotonNetwork.EnableLobbyStatistics && this.EHALCLFLGJF == ServerConnection.GameServer;
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x0600AFBC RID: 44988 RVA: 0x0040F8DE File Offset: 0x0040DADE
	// (set) Token: 0x0600AFAB RID: 44971 RVA: 0x00406418 File Offset: 0x00404618
	public int RoomsCount { get; internal set; }

	// Token: 0x0600AFAC RID: 44972 RVA: 0x0040E994 File Offset: 0x0040CB94
	private void GDDBOALPNDO()
	{
		Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
		dictionary[54] = 1;
		dictionary[(byte)-18] = 1;
		this.OpCustom(17, dictionary, false, 0);
	}

	// Token: 0x0600AFAD RID: 44973 RVA: 0x0040E9D8 File Offset: 0x0040CBD8
	private void EGJBHECFAOH(int IJAEJMNLBLK, PhotonPlayer JHOEDACNNKK)
	{
		if (!this.mActors.ContainsKey(IJAEJMNLBLK))
		{
			this.mActors[IJAEJMNLBLK] = JHOEDACNNKK;
			this.LEMBPMNPHCK();
		}
		else
		{
			Debug.LogError("Adding player twice: " + IJAEJMNLBLK);
		}
	}

	// Token: 0x0600AFAE RID: 44974 RVA: 0x0040EA18 File Offset: 0x0040CC18
	private void KCNBFALAJMD(int KHACEEGCPEP)
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[0] = KHACEEGCPEP;
		this.OpRaiseEvent(207, hashtable, true, null);
	}

	// Token: 0x0600AFAF RID: 44975 RVA: 0x0040A4CF File Offset: 0x004086CF
	internal void BNBNGPDLKFF(int DPNHODJHGJL)
	{
		this.<EEDBHAJBPLC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AFB0 RID: 44976 RVA: 0x0040EA4C File Offset: 0x0040CC4C
	protected internal void OMEPCMPKIJK(bool IJJEEIMFOHD)
	{
		if (this.IDIKEJLLFFP.Count > 0)
		{
			Debug.LogWarning("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.");
		}
		if (IJJEEIMFOHD)
		{
			HashSet<GameObject> hashSet = new HashSet<GameObject>();
			foreach (PhotonView photonView in this.HFCMPEKPBAM.Values)
			{
				if (photonView.isRuntimeInstantiated)
				{
					hashSet.Add(photonView.gameObject);
				}
			}
			foreach (GameObject obfjphlbfol in hashSet)
			{
				this.EFDAOHIDIIF(obfjphlbfol, true);
			}
		}
		this.IDIKEJLLFFP.Clear();
		PhotonNetwork.FDMEIPEKMHC = 0;
		PhotonNetwork.JIOIILCHMJL = 0;
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x0600AFB1 RID: 44977 RVA: 0x0040EB44 File Offset: 0x0040CD44
	// (set) Token: 0x0600AFD0 RID: 45008 RVA: 0x0040A460 File Offset: 0x00408660
	public string GameServerAddress { get; protected internal set; }

	// Token: 0x0600AFB2 RID: 44978 RVA: 0x0040EB4C File Offset: 0x0040CD4C
	private object[] HMGGGIGJILH(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Off)
		{
			return null;
		}
		PhotonMessageInfo dagalcailln = new PhotonMessageInfo(this.LocalPlayer, PhotonNetwork.ServerTimestamp, DFIHBOEOJPI);
		this.ALPAEKHFHPP.AKNGAKEGLAD();
		this.ALPAEKHFHPP.BBHGPGBHMML(null);
		this.ALPAEKHFHPP.PNAPNHJHBMN(null);
		this.ALPAEKHFHPP.OLACNHHHOEL(null);
		DFIHBOEOJPI.OMADJOEHOGE(this.ALPAEKHFHPP, dagalcailln);
		if (this.ALPAEKHFHPP.NHKIENHLEID() <= 6)
		{
			return null;
		}
		object[] array = this.ALPAEKHFHPP.CFJBHFNNCFL();
		array[0] = DFIHBOEOJPI.viewID;
		array[1] = true;
		array[8] = null;
		if (DFIHBOEOJPI.synchronization == (ViewSynchronization)8)
		{
			return array;
		}
		if (DFIHBOEOJPI.synchronization == (ViewSynchronization)8)
		{
			if (this.LFAPOBNFPPO(array, DFIHBOEOJPI.EOENPICKCCO))
			{
				if (DFIHBOEOJPI.PBIDCPBMFKJ)
				{
					return null;
				}
				DFIHBOEOJPI.PBIDCPBMFKJ = false;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			else
			{
				DFIHBOEOJPI.PBIDCPBMFKJ = true;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] result = this.ILJGNDNMNOP(DFIHBOEOJPI.EOENPICKCCO, array);
			DFIHBOEOJPI.EOENPICKCCO = array;
			return result;
		}
		return null;
	}

	// Token: 0x0600AFB3 RID: 44979 RVA: 0x0040A741 File Offset: 0x00408941
	protected internal ServerConnection IGDBHCGGHFF()
	{
		return this.<NFFGNBHFDFM>k__BackingField;
	}

	// Token: 0x0600AFB4 RID: 44980 RVA: 0x00409DED File Offset: 0x00407FED
	public void HBABOJOMPHP(AuthenticationValues DPNHODJHGJL)
	{
		this.<FEGEIIONEMN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AFB5 RID: 44981 RVA: 0x0040EC70 File Offset: 0x0040CE70
	internal GameObject JFOLGKKLFJP(ExitGames.Client.Photon.Hashtable NNNJPMDHPHH, PhotonPlayer OGKJFFANGMC, GameObject HHLFBCNFLAO)
	{
		string text = (string)NNNJPMDHPHH[0];
		int amciaillaib = (int)NNNJPMDHPHH[6];
		int num = (int)NNNJPMDHPHH[7];
		Vector3 vector;
		if (NNNJPMDHPHH.ContainsKey(1))
		{
			vector = (Vector3)NNNJPMDHPHH[1];
		}
		else
		{
			vector = Vector3.zero;
		}
		Quaternion quaternion = Quaternion.identity;
		if (NNNJPMDHPHH.ContainsKey(2))
		{
			quaternion = (Quaternion)NNNJPMDHPHH[2];
		}
		byte b = 0;
		if (NNNJPMDHPHH.ContainsKey(3))
		{
			b = (byte)NNNJPMDHPHH[3];
		}
		short prefix = 0;
		if (NNNJPMDHPHH.ContainsKey(8))
		{
			prefix = (short)NNNJPMDHPHH[8];
		}
		int[] array;
		if (NNNJPMDHPHH.ContainsKey(4))
		{
			array = (int[])NNNJPMDHPHH[4];
		}
		else
		{
			array = new int[]
			{
				num
			};
		}
		object[] array2;
		if (NNNJPMDHPHH.ContainsKey(5))
		{
			array2 = (object[])NNNJPMDHPHH[5];
		}
		else
		{
			array2 = null;
		}
		if (b != 0 && !this.CHIJNBAJIHE.Contains(b))
		{
			return null;
		}
		if (this.EGNHNBODKHP != null)
		{
			GameObject gameObject = this.EGNHNBODKHP.Instantiate(text, vector, quaternion);
			PhotonView[] photonViewsInChildren = gameObject.GetPhotonViewsInChildren();
			if (photonViewsInChildren.Length != array.Length)
			{
				throw new Exception("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
			}
			for (int i = 0; i < photonViewsInChildren.Length; i++)
			{
				photonViewsInChildren[i].GEKLBLEBECG = false;
				photonViewsInChildren[i].viewID = 0;
				photonViewsInChildren[i].prefix = (int)prefix;
				photonViewsInChildren[i].instantiationId = num;
				photonViewsInChildren[i].isRuntimeInstantiated = true;
				photonViewsInChildren[i].NJDPOGADFJN = array2;
				photonViewsInChildren[i].GEKLBLEBECG = true;
				photonViewsInChildren[i].viewID = array[i];
			}
			gameObject.SendMessage(BNGIGHBHPEH.BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, amciaillaib, null), SendMessageOptions.DontRequireReceiver);
			return gameObject;
		}
		else
		{
			if (HHLFBCNFLAO == null)
			{
				if (!BNGIGHBHPEH.UsePrefabCache || !BNGIGHBHPEH.PrefabCache.TryGetValue(text, out HHLFBCNFLAO))
				{
					HHLFBCNFLAO = (GameObject)Resources.Load(text, typeof(GameObject));
					if (BNGIGHBHPEH.UsePrefabCache)
					{
						BNGIGHBHPEH.PrefabCache.Add(text, HHLFBCNFLAO);
					}
				}
				if (HHLFBCNFLAO == null)
				{
					Debug.LogError("PhotonNetwork error: Could not Instantiate the prefab [" + text + "]. Please verify you have this gameobject in a Resources folder.");
					return null;
				}
			}
			PhotonView[] photonViewsInChildren2 = HHLFBCNFLAO.GetPhotonViewsInChildren();
			if (photonViewsInChildren2.Length != array.Length)
			{
				throw new Exception("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
			}
			for (int j = 0; j < array.Length; j++)
			{
				photonViewsInChildren2[j].viewID = array[j];
				photonViewsInChildren2[j].prefix = (int)prefix;
				photonViewsInChildren2[j].instantiationId = num;
				photonViewsInChildren2[j].isRuntimeInstantiated = true;
			}
			this.DGEJLOAMLHI(num, array2);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(HHLFBCNFLAO, vector, quaternion);
			for (int k = 0; k < array.Length; k++)
			{
				photonViewsInChildren2[k].viewID = 0;
				photonViewsInChildren2[k].prefix = -1;
				photonViewsInChildren2[k].prefixBackup = -1;
				photonViewsInChildren2[k].instantiationId = -1;
				photonViewsInChildren2[k].isRuntimeInstantiated = false;
			}
			this.GKNPNNKFFAL(num);
			gameObject2.SendMessage(BNGIGHBHPEH.BJJEABNGKBF, new PhotonMessageInfo(OGKJFFANGMC, amciaillaib, null), SendMessageOptions.DontRequireReceiver);
			return gameObject2;
		}
	}

	// Token: 0x0600AFB6 RID: 44982 RVA: 0x0040F010 File Offset: 0x0040D210
	public void OnStatusChanged(StatusCode FIIDDDBNCLD)
	{
		if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log(string.Format("OnStatusChanged: {0} current State: {1}", FIIDDDBNCLD.ToString(), this.State));
		}
		switch (FIIDDDBNCLD)
		{
		case StatusCode.ExceptionOnReceive:
		case StatusCode.DisconnectByServer:
		case StatusCode.DisconnectByServerUserLimit:
		case StatusCode.DisconnectByServerLogic:
			if (this.IsInitialConnect)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					FIIDDDBNCLD,
					" while connecting to: ",
					base.ServerAddress,
					". Check if the server is available."
				}));
				this.IsInitialConnect = false;
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
				{
					disconnectCause
				});
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
				{
					disconnectCause
				});
			}
			if (this.AuthValues != null)
			{
				this.AuthValues.Token = null;
			}
			this.Disconnect();
			return;
		case StatusCode.TimeoutDisconnect:
			if (this.IsInitialConnect)
			{
				if (!this.IDOAHFHJJJE)
				{
					Debug.LogWarning(string.Concat(new object[]
					{
						FIIDDDBNCLD,
						" while connecting to: ",
						base.ServerAddress,
						". Check if the server is available."
					}));
					this.IsInitialConnect = false;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
					{
						disconnectCause
					});
				}
			}
			else
			{
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
				{
					disconnectCause
				});
			}
			if (this.AuthValues != null)
			{
				this.AuthValues.Token = null;
			}
			this.Disconnect();
			return;
		default:
			switch (FIIDDDBNCLD)
			{
			case StatusCode.SecurityExceptionOnConnect:
			case StatusCode.ExceptionOnConnect:
			{
				this.IsInitialConnect = false;
				this.State = ClientState.PeerCreated;
				if (this.AuthValues != null)
				{
					this.AuthValues.Token = null;
				}
				DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
				{
					disconnectCause
				});
				return;
			}
			case StatusCode.Connect:
				if (this.State == ClientState.ConnectingToNameServer)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("Connected to NameServer.");
					}
					this.EHALCLFLGJF = ServerConnection.NameServer;
					if (this.AuthValues != null)
					{
						this.AuthValues.Token = null;
					}
				}
				if (this.State == ClientState.ConnectingToGameserver)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("Connected to gameserver.");
					}
					this.EHALCLFLGJF = ServerConnection.GameServer;
					this.State = ClientState.ConnectedToGameserver;
				}
				if (this.State == ClientState.ConnectingToMasterserver)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("Connected to masterserver.");
					}
					this.EHALCLFLGJF = ServerConnection.MasterServer;
					this.State = ClientState.Authenticating;
					if (this.IsInitialConnect)
					{
						this.IsInitialConnect = false;
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToPhoton, new object[0]);
					}
				}
				if (base.TransportProtocol != ConnectionProtocol.WebSocketSecure)
				{
					if (this.EHALCLFLGJF == ServerConnection.NameServer || this.AuthMode == AuthModeOption.Auth)
					{
						base.EstablishEncryption();
					}
					return;
				}
				if (this.DebugOut == DebugLevel.INFO)
				{
					Debug.Log("Skipping EstablishEncryption. Protocol is secure.");
				}
				goto IL_1AC;
			case StatusCode.Disconnect:
				this.DMCPHGDNGDB = false;
				this.POHIMACBDGL = false;
				if (this.EHALCLFLGJF == ServerConnection.GameServer)
				{
					this.BOJKDNJHBNG();
				}
				if (this.EHALCLFLGJF == ServerConnection.MasterServer)
				{
					this.IFPPBJINADG();
				}
				if (this.State == ClientState.DisconnectingFromMasterserver)
				{
					if (this.Connect(this.GameServerAddress, ServerConnection.GameServer))
					{
						this.State = ClientState.ConnectingToGameserver;
					}
				}
				else if (this.State == ClientState.DisconnectingFromGameserver || this.State == ClientState.DisconnectingFromNameServer)
				{
					this.KHKMFIFGPCH(ServerConnection.MasterServer);
					if (this.Connect(this.MasterServerAddress, ServerConnection.MasterServer))
					{
						this.State = ClientState.ConnectingToMasterserver;
					}
				}
				else
				{
					if (this.IDOAHFHJJJE)
					{
						return;
					}
					if (this.AuthValues != null)
					{
						this.AuthValues.Token = null;
					}
					this.IsInitialConnect = false;
					this.State = ClientState.PeerCreated;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnDisconnectedFromPhoton, new object[0]);
				}
				return;
			case StatusCode.Exception:
				if (this.IsInitialConnect)
				{
					Debug.LogError("Exception while connecting to: " + base.ServerAddress + ". Check if the server is available.");
					if (base.ServerAddress == null || base.ServerAddress.StartsWith("127.0.0.1"))
					{
						Debug.LogWarning("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.");
						if (base.ServerAddress == this.GameServerAddress)
						{
							Debug.LogWarning("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.");
						}
					}
					this.State = ClientState.PeerCreated;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					this.IsInitialConnect = false;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
					{
						disconnectCause
					});
				}
				else
				{
					this.State = ClientState.PeerCreated;
					DisconnectCause disconnectCause = (DisconnectCause)FIIDDDBNCLD;
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						disconnectCause
					});
				}
				this.Disconnect();
				return;
			case StatusCode.SendError:
				return;
			}
			Debug.LogError("Received unknown status code: " + FIIDDDBNCLD);
			return;
		case StatusCode.EncryptionEstablished:
			break;
		case StatusCode.EncryptionFailedToEstablish:
		{
			Debug.LogError("Encryption wasn't established: " + FIIDDDBNCLD + ". Going to authenticate anyways.");
			AuthenticationValues authenticationValues;
			if ((authenticationValues = this.AuthValues) == null)
			{
				authenticationValues = new AuthenticationValues
				{
					UserId = this.PlayerName
				};
			}
			AuthenticationValues gpdfhodmoij = authenticationValues;
			this.OpAuthenticate(this.KAIBLIKEDHM, this.EOCFDCJNAGM, gpdfhodmoij, this.CloudRegion.ToString(), this.OGLFGPKHEHH);
			return;
		}
		}
		IL_1AC:
		this.IDOAHFHJJJE = false;
		if (this.EHALCLFLGJF == ServerConnection.NameServer)
		{
			this.State = ClientState.ConnectedToNameServer;
			if (!this.DMCPHGDNGDB && this.CloudRegion == CloudRegionCode.none)
			{
				this.OpGetRegions(this.KAIBLIKEDHM);
			}
		}
		if (this.EHALCLFLGJF != ServerConnection.NameServer && (this.AuthMode == AuthModeOption.AuthOnce || this.AuthMode == AuthModeOption.AuthOnceWss))
		{
			Debug.Log(string.Concat(new object[]
			{
				"didAuthenticate ",
				this.DMCPHGDNGDB,
				" AuthMode ",
				this.AuthMode
			}));
		}
		else if (!this.DMCPHGDNGDB && (!this.IsUsingNameServer || this.CloudRegion != CloudRegionCode.none))
		{
			this.DMCPHGDNGDB = this.OELIGNFABAJ();
			if (this.DMCPHGDNGDB)
			{
				this.State = ClientState.Authenticating;
			}
		}
	}

	// Token: 0x0600AFB7 RID: 44983 RVA: 0x0040F664 File Offset: 0x0040D864
	public bool ReconnectToMaster()
	{
		if (this.AuthValues == null)
		{
			Debug.LogWarning("ReconnectToMaster() with AuthValues == null is not correct!");
			this.AuthValues = new AuthenticationValues();
		}
		this.AuthValues.Token = this.JOKLGFENMKE;
		return this.Connect(this.MasterServerAddress, ServerConnection.MasterServer);
	}

	// Token: 0x0600AFB8 RID: 44984 RVA: 0x0040F6A4 File Offset: 0x0040D8A4
	public void MMIMMJOEBNG(byte[] JKOIGFLNNCN, byte[] OBKFHNACHIA)
	{
		if (JKOIGFLNNCN != null)
		{
			for (int i = 1; i < JKOIGFLNNCN.Length; i += 0)
			{
				byte item = JKOIGFLNNCN[i];
				this.FFBGBLFBHOK.Add(item);
			}
		}
		if (OBKFHNACHIA != null)
		{
			for (int j = 1; j < OBKFHNACHIA.Length; j += 0)
			{
				byte item2 = OBKFHNACHIA[j];
				this.FFBGBLFBHOK.Remove(item2);
			}
		}
	}

	// Token: 0x0600AFB9 RID: 44985 RVA: 0x0040F708 File Offset: 0x0040D908
	public void HCBFOHMAICA()
	{
		if (this.HMIEGLIHGEM)
		{
			this.HMIEGLIHGEM = false;
			PhotonNetwork.isMessageQueueRunning = false;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, PhotonView> keyValuePair in this.HFCMPEKPBAM)
		{
			PhotonView value = keyValuePair.Value;
			if (value == null)
			{
				list.Add(keyValuePair.Key);
			}
		}
		for (int i = 1; i < list.Count; i++)
		{
			int key = list[i];
			this.HFCMPEKPBAM.Remove(key);
		}
		if (list.Count > 1 && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
		{
			Debug.Log("file://" + list.Count + "HandsCountSlider");
		}
	}

	// Token: 0x0600AFBA RID: 44986 RVA: 0x0040F808 File Offset: 0x0040DA08
	public bool ConnectToNameServer()
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		this.IsUsingNameServer = true;
		this.CloudRegion = CloudRegionCode.none;
		if (this.State == ClientState.ConnectedToNameServer)
		{
			return true;
		}
		this.KHKMFIFGPCH(ServerConnection.NameServer);
		this.PKNIJKPIKAF = ServerConnection.NameServer;
		this.BLNBCGLIOHP = this.NameServerAddress;
		this.KAOMEDGGMEM = "ns";
		if (!base.Connect(this.NameServerAddress, "ns", this.LLJDHHLHFME))
		{
			return false;
		}
		this.State = ClientState.ConnectingToNameServer;
		return true;
	}

	// Token: 0x0600AFBB RID: 44987 RVA: 0x0040F894 File Offset: 0x0040DA94
	public override bool OpJoinRoom(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		bool flag = this.EHALCLFLGJF == ServerConnection.GameServer;
		HBJBKOPJDKJ.OnGameServer = flag;
		if (!flag)
		{
			this.AJFMHFLGCFN = HBJBKOPJDKJ;
		}
		this.ELNKFMHCMBO = ((!HBJBKOPJDKJ.CreateIfNotExists) ? JoinType.JoinRoom : JoinType.JoinOrCreateRoom);
		return base.OpJoinRoom(HBJBKOPJDKJ);
	}

	// Token: 0x0600AFBD RID: 44989 RVA: 0x0040F8E8 File Offset: 0x0040DAE8
	public void PPDHJGDBHCG(int CFLLNEOHNFD)
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				CFLLNEOHNFD
			}
		};
		this.LHOCCIABPNJ(1, null, true, bplhapbmggc);
	}

	// Token: 0x0600AFBE RID: 44990 RVA: 0x0040F920 File Offset: 0x0040DB20
	private object[] EFKMNFNHJBL(object[] EMJBOOJPAII, object[] JGHJOJFOGCO)
	{
		if (!(bool)JGHJOJFOGCO[1])
		{
			return JGHJOJFOGCO;
		}
		if (EMJBOOJPAII == null)
		{
			return null;
		}
		int[] array = JGHJOJFOGCO[2] as int[];
		for (int i = 3; i < JGHJOJFOGCO.Length; i++)
		{
			if (array == null || !array.Contains(i))
			{
				if (JGHJOJFOGCO[i] == null)
				{
					object obj = EMJBOOJPAII[i];
					JGHJOJFOGCO[i] = obj;
				}
			}
		}
		return JGHJOJFOGCO;
	}

	// Token: 0x0600AFBF RID: 44991 RVA: 0x0040F98C File Offset: 0x0040DB8C
	public bool ConnectToRegionMaster(CloudRegionCode LPCNAHJGAFK)
	{
		if (PhotonHandler.MBIFDLCKGKN)
		{
			Debug.LogWarning("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
			return false;
		}
		this.IsUsingNameServer = true;
		this.CloudRegion = LPCNAHJGAFK;
		if (this.State == ClientState.ConnectedToNameServer)
		{
			return this.OELIGNFABAJ();
		}
		this.PKNIJKPIKAF = ServerConnection.NameServer;
		this.BLNBCGLIOHP = this.NameServerAddress;
		this.KAOMEDGGMEM = "ns";
		this.KHKMFIFGPCH(ServerConnection.NameServer);
		if (!base.Connect(this.NameServerAddress, "ns", this.LLJDHHLHFME))
		{
			return false;
		}
		this.State = ClientState.ConnectingToNameServer;
		return true;
	}

	// Token: 0x0600AFC0 RID: 44992 RVA: 0x0040FA1D File Offset: 0x0040DC1D
	private void GPODJOPLJPD(int IJAEJMNLBLK, PhotonPlayer JHOEDACNNKK)
	{
		this.mActors.Remove(IJAEJMNLBLK);
		if (!JHOEDACNNKK.IsLocal)
		{
			this.LEMBPMNPHCK();
		}
	}

	// Token: 0x0600AFC1 RID: 44993 RVA: 0x0040E989 File Offset: 0x0040CB89
	internal void JNPKDLEMJFN(ClientState DPNHODJHGJL)
	{
		this.<CKEGJBJJPEC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AFC3 RID: 44995 RVA: 0x0040FA45 File Offset: 0x0040DC45
	public bool LocalCleanPhotonView(PhotonView DFIHBOEOJPI)
	{
		DFIHBOEOJPI.IHPAIFIHLAE = true;
		return this.HFCMPEKPBAM.Remove(DFIHBOEOJPI.viewID);
	}

	// Token: 0x0600AFC4 RID: 44996 RVA: 0x0040FA60 File Offset: 0x0040DC60
	public bool ReconnectAndRejoin()
	{
		if (this.AuthValues == null)
		{
			Debug.LogWarning("ReconnectAndRejoin() with AuthValues == null is not correct!");
			this.AuthValues = new AuthenticationValues();
		}
		this.AuthValues.Token = this.JOKLGFENMKE;
		if (!string.IsNullOrEmpty(this.GameServerAddress) && this.AJFMHFLGCFN != null)
		{
			this.ELNKFMHCMBO = JoinType.JoinRoom;
			this.AJFMHFLGCFN.RejoinOnly = true;
			return this.Connect(this.GameServerAddress, ServerConnection.GameServer);
		}
		return false;
	}

	// Token: 0x0600AFC5 RID: 44997 RVA: 0x0040FADC File Offset: 0x0040DCDC
	public bool SetMasterClient(int BONHLGFPNHF)
	{
		ExitGames.Client.Photon.Hashtable mjjmnidhdec = new ExitGames.Client.Photon.Hashtable
		{
			{
				248,
				BONHLGFPNHF
			}
		};
		ExitGames.Client.Photon.Hashtable kcjikjdcoal = new ExitGames.Client.Photon.Hashtable
		{
			{
				248,
				this.mMasterClientId
			}
		};
		return base.HFECLDIOHNJ(mjjmnidhdec, kcjikjdcoal, false);
	}

	// Token: 0x0600AFC6 RID: 44998 RVA: 0x0040FB33 File Offset: 0x0040DD33
	public override bool OpRaiseEvent(byte IMCBEMICJFC, object PEIFAPIIKNJ, bool ANMGHMBBMAO, RaiseEventOptions BPLHAPBMGGC)
	{
		return !PhotonNetwork.offlineMode && base.OpRaiseEvent(IMCBEMICJFC, PEIFAPIIKNJ, ANMGHMBBMAO, BPLHAPBMGGC);
	}

	// Token: 0x0600AFC7 RID: 44999 RVA: 0x0040FB4C File Offset: 0x0040DD4C
	public bool JCPECILENMF(AKBOPCNHFFJ BDMKOAGEHPM)
	{
		bool flag = this.IGDBHCGGHFF() == ServerConnection.MasterServer;
		BDMKOAGEHPM.OnGameServer = flag;
		BDMKOAGEHPM.PlayerProperties = this.HHPBLGDNDOP();
		if (!flag)
		{
			this.AJFMHFLGCFN = BDMKOAGEHPM;
		}
		this.ELNKFMHCMBO = JoinType.CreateRoom;
		return base.OpCreateRoom(BDMKOAGEHPM);
	}

	// Token: 0x0600AFC8 RID: 45000 RVA: 0x0040FB94 File Offset: 0x0040DD94
	private static int BBEKGPLBBCA(PhotonPlayer[] NEJPNIGJLGP, int AIMBEFMGEFM)
	{
		if (NEJPNIGJLGP == null || NEJPNIGJLGP.Length == 0)
		{
			return -1;
		}
		int num = int.MaxValue;
		foreach (PhotonPlayer photonPlayer in NEJPNIGJLGP)
		{
			if (photonPlayer.ID != AIMBEFMGEFM)
			{
				if (photonPlayer.ID < num)
				{
					num = photonPlayer.ID;
				}
			}
		}
		return num;
	}

	// Token: 0x0600AFC9 RID: 45001 RVA: 0x0040FBF4 File Offset: 0x0040DDF4
	public void OnOperationResponse(OperationResponse FEOMHKNGOAK)
	{
		if (PhotonNetwork.JNJJAMNLOHA.State == ClientState.Disconnecting)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("OperationResponse ignored while disconnecting. Code: " + FEOMHKNGOAK.OperationCode);
			}
			return;
		}
		if (FEOMHKNGOAK.ReturnCode == 0)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log(FEOMHKNGOAK.ToString());
			}
		}
		else if (FEOMHKNGOAK.ReturnCode == -3)
		{
			Debug.LogError("Operation " + FEOMHKNGOAK.OperationCode + " could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.");
		}
		else if (FEOMHKNGOAK.ReturnCode == 32752)
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Operation ",
				FEOMHKNGOAK.OperationCode,
				" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ",
				FEOMHKNGOAK.DebugMessage
			}));
		}
		else if (FEOMHKNGOAK.ReturnCode == 32760)
		{
			Debug.LogWarning("Operation failed: " + FEOMHKNGOAK.ToStringFull());
		}
		else
		{
			Debug.LogError(string.Concat(new object[]
			{
				"Operation failed: ",
				FEOMHKNGOAK.ToStringFull(),
				" Server: ",
				this.EHALCLFLGJF
			}));
		}
		if (FEOMHKNGOAK.Parameters.ContainsKey(221))
		{
			if (this.AuthValues == null)
			{
				this.AuthValues = new AuthenticationValues();
			}
			this.AuthValues.Token = (FEOMHKNGOAK[221] as string);
			this.JOKLGFENMKE = this.AuthValues.Token;
		}
		byte operationCode = FEOMHKNGOAK.OperationCode;
		switch (operationCode)
		{
		case 217:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				this.DebugReturn(DebugLevel.ERROR, "GetGameList failed: " + FEOMHKNGOAK.ToStringFull());
			}
			else
			{
				this.mGameList = new Dictionary<string, RoomInfo>();
				ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[222];
				foreach (object obj in hashtable.Keys)
				{
					string text = (string)obj;
					this.mGameList[text] = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable[obj]);
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnReceivedRoomListUpdate, new object[0]);
			}
			break;
		default:
			switch (operationCode)
			{
			case 251:
			{
				ExitGames.Client.Photon.Hashtable faolpblckfj = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[249];
				ExitGames.Client.Photon.Hashtable mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[248];
				this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, 0);
				break;
			}
			case 252:
				break;
			case 253:
				break;
			case 254:
				this.NDPIAMOMGME();
				break;
			default:
				Debug.LogWarning(string.Format("OperationResponse unhandled: {0}", FEOMHKNGOAK.ToString()));
				break;
			}
			break;
		case 219:
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnWebRpcResponse, new object[]
			{
				FEOMHKNGOAK
			});
			break;
		case 220:
			if (FEOMHKNGOAK.ReturnCode == 32767)
			{
				Debug.LogError(string.Format("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new object[0]));
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
				{
					DisconnectCause.InvalidAuthentication
				});
				this.State = ClientState.Disconnecting;
				this.Disconnect();
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				Debug.LogError(string.Concat(new object[]
				{
					"GetRegions failed. Can't provide regions list. Error: ",
					FEOMHKNGOAK.ReturnCode,
					": ",
					FEOMHKNGOAK.DebugMessage
				}));
			}
			else
			{
				string[] array = FEOMHKNGOAK[210] as string[];
				string[] array2 = FEOMHKNGOAK[230] as string[];
				if (array == null || array2 == null || array.Length != array2.Length)
				{
					Debug.LogError(string.Concat(new object[]
					{
						"The region arrays from Name Server are not ok. Must be non-null and same length. ",
						array == null,
						" ",
						array2 == null,
						"\n",
						FEOMHKNGOAK.ToStringFull()
					}));
				}
				else
				{
					this.AvailableRegions = new List<Region>(array.Length);
					for (int i = 0; i < array.Length; i++)
					{
						string text2 = array[i];
						if (!string.IsNullOrEmpty(text2))
						{
							text2 = text2.ToLower();
							CloudRegionCode cloudRegionCode = Region.Parse(text2);
							bool flag = true;
							if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion && PhotonNetwork.PhotonServerSettings.EnabledRegions != (CloudRegionFlag)0)
							{
								CloudRegionFlag cloudRegionFlag = Region.JFBLMOGHMPF(cloudRegionCode);
								flag = ((PhotonNetwork.PhotonServerSettings.EnabledRegions & cloudRegionFlag) != (CloudRegionFlag)0);
								if (!flag && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
								{
									Debug.Log("Skipping region because it's not in PhotonServerSettings.EnabledRegions: " + cloudRegionCode);
								}
							}
							if (flag)
							{
								this.AvailableRegions.Add(new Region(cloudRegionCode, text2, array2[i]));
							}
						}
					}
					if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.BestRegion)
					{
						PhotonHandler.LLHBAPCKHAB();
					}
				}
			}
			break;
		case 222:
		{
			bool[] array3 = FEOMHKNGOAK[1] as bool[];
			string[] array4 = FEOMHKNGOAK[2] as string[];
			if (array3 != null && array4 != null && this.BEIPFKHGHPC != null && array3.Length == this.BEIPFKHGHPC.Length)
			{
				List<FriendInfo> list = new List<FriendInfo>(this.BEIPFKHGHPC.Length);
				for (int j = 0; j < this.BEIPFKHGHPC.Length; j++)
				{
					list.Insert(j, new FriendInfo
					{
						Name = this.BEIPFKHGHPC[j],
						Room = array4[j],
						IsOnline = array3[j]
					});
				}
				PhotonNetwork.Friends = list;
			}
			else
			{
				Debug.LogError("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.");
			}
			this.BEIPFKHGHPC = null;
			this.POHIMACBDGL = false;
			this.DJIOCIPPBMK = Environment.TickCount;
			if (this.DJIOCIPPBMK == 0)
			{
				this.DJIOCIPPBMK = 1;
			}
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnUpdatedFriendList, new object[0]);
			break;
		}
		case 225:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 32760)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Full)
					{
						Debug.Log("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.");
					}
				}
				else if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("JoinRandom failed: {0}.", FEOMHKNGOAK.ToStringFull()));
				}
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonRandomJoinFailed, new object[]
				{
					FEOMHKNGOAK.ReturnCode,
					FEOMHKNGOAK.DebugMessage
				});
			}
			else
			{
				string roomName = (string)FEOMHKNGOAK[byte.MaxValue];
				this.AJFMHFLGCFN.RoomName = roomName;
				this.GameServerAddress = (string)FEOMHKNGOAK[230];
				this.NDPIAMOMGME();
			}
			break;
		case 226:
			if (this.EHALCLFLGJF != ServerConnection.GameServer)
			{
				if (FEOMHKNGOAK.ReturnCode != 0)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log(string.Format("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", FEOMHKNGOAK.ToStringFull(), this.State));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonJoinRoomFailed, new object[]
					{
						FEOMHKNGOAK.ReturnCode,
						FEOMHKNGOAK.DebugMessage
					});
				}
				else
				{
					this.GameServerAddress = (string)FEOMHKNGOAK[230];
					this.NDPIAMOMGME();
				}
			}
			else
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			break;
		case 227:
			if (this.EHALCLFLGJF == ServerConnection.GameServer)
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("CreateRoom failed, client stays on masterserver: {0}.", FEOMHKNGOAK.ToStringFull()));
				}
				this.State = ((!this.insideLobby) ? ClientState.ConnectedToMaster : ClientState.JoinedLobby);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCreateRoomFailed, new object[]
				{
					FEOMHKNGOAK.ReturnCode,
					FEOMHKNGOAK.DebugMessage
				});
			}
			else
			{
				string text3 = (string)FEOMHKNGOAK[byte.MaxValue];
				if (!string.IsNullOrEmpty(text3))
				{
					this.AJFMHFLGCFN.RoomName = text3;
				}
				this.GameServerAddress = (string)FEOMHKNGOAK[230];
				this.NDPIAMOMGME();
			}
			break;
		case 228:
			this.State = ClientState.Authenticated;
			this.IFPPBJINADG();
			break;
		case 229:
			this.State = ClientState.JoinedLobby;
			this.insideLobby = true;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnJoinedLobby, new object[0]);
			break;
		case 230:
		case 231:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == -2)
				{
					Debug.LogError(string.Format("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' " + base.ServerAddress, new object[0]));
				}
				else if (FEOMHKNGOAK.ReturnCode == 32767)
				{
					Debug.LogError(string.Format("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", new object[0]));
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnFailedToConnectToPhoton, new object[]
					{
						DisconnectCause.InvalidAuthentication
					});
				}
				else if (FEOMHKNGOAK.ReturnCode == 32755)
				{
					Debug.LogError(string.Format("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", new object[0]));
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCustomAuthenticationFailed, new object[]
					{
						FEOMHKNGOAK.DebugMessage
					});
				}
				else
				{
					Debug.LogError(string.Format("Authentication failed: '{0}' Code: {1}", FEOMHKNGOAK.DebugMessage, FEOMHKNGOAK.ReturnCode));
				}
				this.State = ClientState.Disconnecting;
				this.Disconnect();
				if (FEOMHKNGOAK.ReturnCode == 32757)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogWarning(string.Format("Currently, the limit of users is reached for this title. Try again later. Disconnecting", new object[0]));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonMaxCccuReached, new object[0]);
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						DisconnectCause.MaxCcuReached
					});
				}
				else if (FEOMHKNGOAK.ReturnCode == 32756)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", new object[0]));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						DisconnectCause.InvalidRegion
					});
				}
				else if (FEOMHKNGOAK.ReturnCode == 32753)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", new object[0]));
					}
					BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectionFail, new object[]
					{
						DisconnectCause.AuthenticationTicketExpired
					});
				}
			}
			else
			{
				if (this.EHALCLFLGJF == ServerConnection.NameServer || this.EHALCLFLGJF == ServerConnection.MasterServer)
				{
					if (FEOMHKNGOAK.Parameters.ContainsKey(225))
					{
						string text4 = (string)FEOMHKNGOAK.Parameters[225];
						if (!string.IsNullOrEmpty(text4))
						{
							if (this.AuthValues == null)
							{
								this.AuthValues = new AuthenticationValues();
							}
							this.AuthValues.UserId = text4;
							PhotonNetwork.player.UserId = text4;
							if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
							{
								this.DebugReturn(DebugLevel.INFO, string.Format("Received your UserID from server. Updating local value to: {0}", text4));
							}
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey(202))
					{
						this.PlayerName = (string)FEOMHKNGOAK.Parameters[202];
						if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
						{
							this.DebugReturn(DebugLevel.INFO, string.Format("Received your NickName from server. Updating local value to: {0}", this.OBCEIJGMKGB));
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey(192))
					{
						this.BAEBFLIPKKB((Dictionary<byte, object>)FEOMHKNGOAK.Parameters[192]);
					}
				}
				if (this.EHALCLFLGJF == ServerConnection.NameServer)
				{
					this.MasterServerAddress = (FEOMHKNGOAK[230] as string);
					this.NDPIAMOMGME();
				}
				else if (this.EHALCLFLGJF == ServerConnection.MasterServer)
				{
					if (this.AuthMode != AuthModeOption.Auth)
					{
						this.OpSettings(this.OGLFGPKHEHH);
					}
					if (PhotonNetwork.autoJoinLobby)
					{
						this.State = ClientState.Authenticated;
						this.OpJoinLobby(this.lobby);
					}
					else
					{
						this.State = ClientState.ConnectedToMaster;
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnConnectedToMaster, new object[0]);
					}
				}
				else if (this.EHALCLFLGJF == ServerConnection.GameServer)
				{
					this.State = ClientState.Joining;
					this.AJFMHFLGCFN.PlayerProperties = this.HHPBLGDNDOP();
					this.AJFMHFLGCFN.OnGameServer = true;
					if (this.ELNKFMHCMBO == JoinType.JoinRoom || this.ELNKFMHCMBO == JoinType.JoinRandomRoom || this.ELNKFMHCMBO == JoinType.JoinOrCreateRoom)
					{
						this.OpJoinRoom(this.AJFMHFLGCFN);
					}
					else if (this.ELNKFMHCMBO == JoinType.CreateRoom)
					{
						this.OpCreateGame(this.AJFMHFLGCFN);
					}
				}
				if (FEOMHKNGOAK.Parameters.ContainsKey(245))
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)FEOMHKNGOAK.Parameters[245];
					if (dictionary != null)
					{
						BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnCustomAuthenticationResponse, new object[]
						{
							dictionary
						});
					}
				}
			}
			break;
		}
	}

	// Token: 0x0600AFCA RID: 45002 RVA: 0x00410934 File Offset: 0x0040EB34
	private object[] FOEPFOMJHKL(PhotonView DFIHBOEOJPI)
	{
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.Off)
		{
			return null;
		}
		PhotonMessageInfo dagalcailln = new PhotonMessageInfo(this.LocalPlayer, PhotonNetwork.ServerTimestamp, DFIHBOEOJPI);
		this.ALPAEKHFHPP.IHFJMFNBJAD();
		this.ALPAEKHFHPP.PBECMJMDHBI(null);
		this.ALPAEKHFHPP.SendNext(null);
		this.ALPAEKHFHPP.PBECMJMDHBI(null);
		DFIHBOEOJPI.IBGILLAEDFA(this.ALPAEKHFHPP, dagalcailln);
		if (this.ALPAEKHFHPP.HCOCCCCDJDD() <= 7)
		{
			return null;
		}
		object[] array = this.ALPAEKHFHPP.ICDKEKMNCNC();
		array[0] = DFIHBOEOJPI.NPPEFODKHKN();
		array[0] = true;
		array[4] = null;
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.UnreliableOnChange)
		{
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			if (this.LFAPOBNFPPO(array, DFIHBOEOJPI.EOENPICKCCO))
			{
				if (DFIHBOEOJPI.PBIDCPBMFKJ)
				{
					return null;
				}
				DFIHBOEOJPI.PBIDCPBMFKJ = false;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			else
			{
				DFIHBOEOJPI.PBIDCPBMFKJ = false;
				DFIHBOEOJPI.EOENPICKCCO = array;
			}
			return array;
		}
		if (DFIHBOEOJPI.synchronization == ViewSynchronization.ReliableDeltaCompressed)
		{
			object[] result = this.ILJGNDNMNOP(DFIHBOEOJPI.EOENPICKCCO, array);
			DFIHBOEOJPI.EOENPICKCCO = array;
			return result;
		}
		return null;
	}

	// Token: 0x0600AFCC RID: 45004 RVA: 0x00410A60 File Offset: 0x0040EC60
	private void BAEBFLIPKKB(Dictionary<byte, object> FNHGNHCOMBH)
	{
		if (this.AuthMode == AuthModeOption.Auth && this.DebugOut == DebugLevel.ERROR)
		{
			Debug.LogWarning("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: " + FNHGNHCOMBH.ToStringFull());
			return;
		}
		if (this.DebugOut == DebugLevel.INFO)
		{
			Debug.Log("SetupEncryption() got called. " + FNHGNHCOMBH.ToStringFull());
		}
		EncryptionMode encryptionMode = (EncryptionMode)((byte)FNHGNHCOMBH[0]);
		if (encryptionMode != EncryptionMode.PayloadEncryption)
		{
			if (encryptionMode != EncryptionMode.DatagramEncryption)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] encryptionSecret = (byte[])FNHGNHCOMBH[1];
			byte[] hmacSecret = (byte[])FNHGNHCOMBH[2];
			base.InitDatagramEncryption(encryptionSecret, hmacSecret);
		}
		else
		{
			byte[] secret = (byte[])FNHGNHCOMBH[1];
			base.InitPayloadEncryption(secret);
		}
	}

	// Token: 0x0600AFCD RID: 45005 RVA: 0x0040E729 File Offset: 0x0040C929
	private ExitGames.Client.Photon.Hashtable LNJJOADENLA(ExitGames.Client.Photon.Hashtable FPBCPOGCCBD, int KHACEEGCPEP)
	{
		if (FPBCPOGCCBD.ContainsKey(KHACEEGCPEP))
		{
			return (ExitGames.Client.Photon.Hashtable)FPBCPOGCCBD[KHACEEGCPEP];
		}
		return FPBCPOGCCBD;
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x0600AFCE RID: 45006 RVA: 0x00410B22 File Offset: 0x0040ED22
	protected internal string EOCFDCJNAGM
	{
		get
		{
			return string.Format("{0}_{1}", PhotonNetwork.gameVersion, "1.87");
		}
	}

	// Token: 0x0600AFCF RID: 45007 RVA: 0x00410B38 File Offset: 0x0040ED38
	public void OpRemoveCompleteCacheOfPlayer(int CFLLNEOHNFD)
	{
		RaiseEventOptions bplhapbmggc = new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCache,
			TargetActors = new int[]
			{
				CFLLNEOHNFD
			}
		};
		this.OpRaiseEvent(0, null, true, bplhapbmggc);
	}

	// Token: 0x0600AFD1 RID: 45009 RVA: 0x00410B70 File Offset: 0x0040ED70
	private void BOJKDNJHBNG()
	{
		bool flag = this.CurrentRoom != null;
		bool flag2 = (this.CurrentRoom == null) ? PhotonNetwork.autoCleanUpPlayerObjects : this.CurrentRoom.AutoCleanUp;
		this.hasSwitchedMC = false;
		this.CurrentRoom = null;
		this.mActors = new Dictionary<int, PhotonPlayer>();
		this.mPlayerListCopy = new PhotonPlayer[0];
		this.mOtherPlayerListCopy = new PhotonPlayer[0];
		this.CHIJNBAJIHE = new HashSet<byte>();
		this.FFBGBLFBHOK = new HashSet<byte>();
		this.mGameList = new Dictionary<string, RoomInfo>();
		this.mGameListCopy = new RoomInfo[0];
		this.POHIMACBDGL = false;
		this.ChangeLocalID(-1);
		if (flag2)
		{
			this.OMEPCMPKIJK(true);
			PhotonNetwork.JMCPHFPJEJC = new List<int>();
		}
		if (flag)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom, new object[0]);
		}
	}

	// Token: 0x0600AFD2 RID: 45010 RVA: 0x00410C40 File Offset: 0x0040EE40
	protected internal bool LGPBHHOJPCA(int PHIGECOLKKN, bool PANGJAJJOLO)
	{
		bool flag = this.mMasterClientId != PHIGECOLKKN;
		if (!flag || !this.mActors.ContainsKey(PHIGECOLKKN))
		{
			return false;
		}
		if (PANGJAJJOLO && !this.OpRaiseEvent(208, new ExitGames.Client.Photon.Hashtable
		{
			{
				1,
				PHIGECOLKKN
			}
		}, true, null))
		{
			return false;
		}
		this.hasSwitchedMC = true;
		this.CurrentRoom.EJLAPIIGIMI = PHIGECOLKKN;
		BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnMasterClientSwitched, new object[]
		{
			this.ICMGDHDNIJD(PHIGECOLKKN)
		});
		return true;
	}

	// Token: 0x0600AFD3 RID: 45011 RVA: 0x00410CD4 File Offset: 0x0040EED4
	private void PACEKOIEHKK()
	{
		if (this.State == ClientState.Joining)
		{
			this.BOKEGDFHBAN = true;
			return;
		}
		if (this.LocalPlayer != null)
		{
			this.LocalPlayer.NickName = this.PlayerName;
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable[byte.MaxValue] = this.PlayerName;
			if (this.LocalPlayer.ID > 0)
			{
				base.LJEFICMOPMO(this.LocalPlayer.ID, hashtable, null, false);
				this.BOKEGDFHBAN = false;
			}
		}
	}

	// Token: 0x0600AFD4 RID: 45012 RVA: 0x00410D5C File Offset: 0x0040EF5C
	private object[] ILJGNDNMNOP(object[] BJIEGLPODKG, object[] BGJHIKDFIMP)
	{
		if (BGJHIKDFIMP == null || BJIEGLPODKG == null || BJIEGLPODKG.Length != BGJHIKDFIMP.Length)
		{
			return BGJHIKDFIMP;
		}
		if (BGJHIKDFIMP.Length <= 4)
		{
			return null;
		}
		BJIEGLPODKG[1] = false;
		int num = 1;
		Queue<int> queue = null;
		for (int i = 1; i < BGJHIKDFIMP.Length; i += 0)
		{
			object obj = BGJHIKDFIMP[i];
			object golmelkeafo = BJIEGLPODKG[i];
			if (this.JKOFIOHPEAB(obj, golmelkeafo))
			{
				num++;
				BJIEGLPODKG[i] = null;
			}
			else
			{
				BJIEGLPODKG[i] = obj;
				if (obj == null)
				{
					if (queue == null)
					{
						queue = new Queue<int>(BGJHIKDFIMP.Length);
					}
					queue.Enqueue(i);
				}
			}
		}
		if (num > 1)
		{
			if (num == BGJHIKDFIMP.Length - 1)
			{
				return null;
			}
			BJIEGLPODKG[1] = true;
			if (queue != null)
			{
				BJIEGLPODKG[5] = queue.ToArray();
			}
		}
		BJIEGLPODKG[1] = BGJHIKDFIMP[0];
		return BJIEGLPODKG;
	}

	// Token: 0x0600AFD5 RID: 45013 RVA: 0x00410E2C File Offset: 0x0040F02C
	public void KGNBOOOBLHC(OperationResponse FEOMHKNGOAK)
	{
		if (PhotonNetwork.JNJJAMNLOHA.State == (ClientState)46)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log("GenerationMenu" + FEOMHKNGOAK.OperationCode);
			}
			return;
		}
		if (FEOMHKNGOAK.ReturnCode == 0)
		{
			if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log(FEOMHKNGOAK.ToString());
			}
		}
		else if (FEOMHKNGOAK.ReturnCode == 96)
		{
			Debug.LogError("Testing, the group has toggled [" + FEOMHKNGOAK.OperationCode + "[MenuScene] Error: ");
		}
		else if (FEOMHKNGOAK.ReturnCode == -178)
		{
			object[] array = new object[4];
			array[1] = "ViewID {0} {1}{2}";
			array[1] = FEOMHKNGOAK.OperationCode;
			array[6] = "workshop.";
			array[2] = FEOMHKNGOAK.DebugMessage;
			Debug.LogError(string.Concat(array));
		}
		else if (FEOMHKNGOAK.ReturnCode == -98)
		{
			Debug.LogWarning("1278033234" + FEOMHKNGOAK.ToStringFull());
		}
		else
		{
			object[] array2 = new object[]
			{
				".sawoutdatedmessage"
			};
			array2[0] = FEOMHKNGOAK.ToStringFull();
			array2[2] = "CameraFilterPack/Blend2Camera_Subtract";
			array2[4] = this.NJIFBFEHJKH();
			Debug.LogError(string.Concat(array2));
		}
		if (FEOMHKNGOAK.Parameters.ContainsKey(183))
		{
			if (this.AuthValues == null)
			{
				this.AuthValues = new AuthenticationValues();
			}
			this.IJHIEINKMFP().FNCDLDJFJAM(FEOMHKNGOAK[(byte)-166] as string);
			this.JOKLGFENMKE = this.IJHIEINKMFP().PPFIBJOHICJ();
		}
		byte operationCode = FEOMHKNGOAK.OperationCode;
		switch (operationCode)
		{
		case 21:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				this.ELEMKNKGNIP(DebugLevel.ERROR, "<b>" + FEOMHKNGOAK.ToStringFull());
			}
			else
			{
				this.mGameList = new Dictionary<string, RoomInfo>();
				ExitGames.Client.Photon.Hashtable hashtable = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[(byte)-109];
				foreach (object obj in hashtable.Keys)
				{
					string text = (string)obj;
					this.mGameList[text] = new RoomInfo(text, (ExitGames.Client.Photon.Hashtable)hashtable[obj]);
				}
				this.mGameListCopy = new RoomInfo[this.mGameList.Count];
				this.mGameList.Values.CopyTo(this.mGameListCopy, 0);
				BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, new object[1]);
			}
			break;
		default:
			switch (operationCode)
			{
			case 191:
			{
				ExitGames.Client.Photon.Hashtable faolpblckfj = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[62];
				ExitGames.Client.Photon.Hashtable mjjmnidhdec = (ExitGames.Client.Photon.Hashtable)FEOMHKNGOAK[101];
				this.EDMCCPDDDCC(mjjmnidhdec, faolpblckfj, 1);
				break;
			}
			case 192:
				break;
			case 193:
				break;
			case 194:
				this.MOHFIPIDGOH();
				break;
			default:
				Debug.LogWarning(string.Format("z", FEOMHKNGOAK.ToString()));
				break;
			}
			break;
		case 23:
			BNGIGHBHPEH.CLOLHKCFMJP((PhotonNetworkingMessage)95, new object[]
			{
				FEOMHKNGOAK
			});
			break;
		case 24:
			if (FEOMHKNGOAK.ReturnCode == 150)
			{
				Debug.LogError(string.Format("Text", new object[1]));
				BNGIGHBHPEH.CLOLHKCFMJP(PhotonNetworkingMessage.OnReceivedRoomListUpdate, new object[]
				{
					(DisconnectCause)110
				});
				this.JNPKDLEMJFN((ClientState)90);
				this.Disconnect();
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				object[] array3 = new object[5];
				array3[1] = "MaxLivesSlider";
				array3[1] = FEOMHKNGOAK.ReturnCode;
				array3[8] = "Beat Detected";
				array3[1] = FEOMHKNGOAK.DebugMessage;
				Debug.LogError(string.Concat(array3));
			}
			else
			{
				string[] array4 = FEOMHKNGOAK[(byte)-5] as string[];
				string[] array5 = FEOMHKNGOAK[(byte)-153] as string[];
				if (array4 == null || array5 == null || array4.Length != array5.Length)
				{
					object[] array6 = new object[1];
					array6[0] = "InputField";
					array6[1] = (array4 == null);
					array6[1] = "_LightIntensity";
					array6[0] = (array5 == null);
					array6[0] = "Uploading preview image";
					array6[5] = FEOMHKNGOAK.ToStringFull();
					Debug.LogError(string.Concat(array6));
				}
				else
				{
					this.ENAIECJFPHM(new List<Region>(array4.Length));
					for (int i = 0; i < array4.Length; i++)
					{
						string text2 = array4[i];
						if (!string.IsNullOrEmpty(text2))
						{
							text2 = text2.ToLower();
							CloudRegionCode cloudRegionCode = Region.AGLOFMCGLJI(text2);
							bool flag = true;
							if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode && PhotonNetwork.PhotonServerSettings.EnabledRegions != (CloudRegionFlag)0)
							{
								CloudRegionFlag cloudRegionFlag = Region.PEECIJIGOKD(cloudRegionCode);
								flag = ((PhotonNetwork.PhotonServerSettings.EnabledRegions & cloudRegionFlag) == CloudRegionFlag.eu);
								if (!flag && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
								{
									Debug.Log("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new." + cloudRegionCode);
								}
							}
							if (flag)
							{
								this.GBEHEEIMNDO().Add(new Region(cloudRegionCode, text2, array5[i]));
							}
						}
					}
					if (PhotonNetwork.PhotonServerSettings.HostType == ServerSettings.HostingOption.OfflineMode)
					{
						PhotonHandler.ILEFPKJIONO();
					}
				}
			}
			break;
		case 26:
		{
			bool[] array7 = FEOMHKNGOAK[0] as bool[];
			string[] array8 = FEOMHKNGOAK[3] as string[];
			if (array7 != null && array8 != null && this.BEIPFKHGHPC != null && array7.Length == this.BEIPFKHGHPC.Length)
			{
				List<FriendInfo> list = new List<FriendInfo>(this.BEIPFKHGHPC.Length);
				for (int j = 0; j < this.BEIPFKHGHPC.Length; j++)
				{
					FriendInfo friendInfo = new FriendInfo();
					friendInfo.JCGINDGJKDH(this.BEIPFKHGHPC[j]);
					friendInfo.BHFPBHEJJFE(array8[j]);
					friendInfo.LABJBMDKMDK(array7[j]);
					list.Insert(j, friendInfo);
				}
				PhotonNetwork.Friends = list;
			}
			else
			{
				Debug.LogError("winter2020_official");
			}
			this.BEIPFKHGHPC = null;
			this.POHIMACBDGL = true;
			this.DJIOCIPPBMK = Environment.TickCount;
			if (this.DJIOCIPPBMK == 0)
			{
				this.DJIOCIPPBMK = 1;
			}
			BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)48, new object[1]);
			break;
		}
		case 29:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == -92)
				{
					if (PhotonNetwork.logLevel >= (PhotonLogLevel)4)
					{
						Debug.Log("_TimeX");
					}
				}
				else if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("_ScreenResolution", FEOMHKNGOAK.ToStringFull()));
				}
				PhotonNetworkingMessage lelhnddckco = PhotonNetworkingMessage.OnJoinedLobby;
				object[] array9 = new object[7];
				array9[1] = FEOMHKNGOAK.ReturnCode;
				array9[0] = FEOMHKNGOAK.DebugMessage;
				BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco, array9);
			}
			else
			{
				string roomName = (string)FEOMHKNGOAK[192];
				this.AJFMHFLGCFN.RoomName = roomName;
				this.GameServerAddress = (string)FEOMHKNGOAK[192];
				this.MOHFIPIDGOH();
			}
			break;
		case 30:
			if (this.NJIFBFEHJKH() != ServerConnection.MasterServer)
			{
				if (FEOMHKNGOAK.ReturnCode != 0)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.Log(string.Format("_OcclusionTexture", FEOMHKNGOAK.ToStringFull(), this.State));
					}
					PhotonNetworkingMessage lelhnddckco2 = PhotonNetworkingMessage.OnMasterClientSwitched;
					object[] array10 = new object[5];
					array10[0] = FEOMHKNGOAK.ReturnCode;
					array10[0] = FEOMHKNGOAK.DebugMessage;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco2, array10);
				}
				else
				{
					this.GameServerAddress = (string)FEOMHKNGOAK[(byte)-78];
					this.NDPIAMOMGME();
				}
			}
			else
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			break;
		case 31:
			if (this.IGDBHCGGHFF() == ServerConnection.GameServer)
			{
				this.PCLPOPNEABK(FEOMHKNGOAK);
			}
			else if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
				{
					Debug.LogWarning(string.Format("Tab2Content", FEOMHKNGOAK.ToStringFull()));
				}
				this.JNPKDLEMJFN((!this.insideLobby) ? ((ClientState)87) : ClientState.Authenticated);
				PhotonNetworkingMessage lelhnddckco3 = PhotonNetworkingMessage.OnLeftLobby;
				object[] array11 = new object[8];
				array11[0] = FEOMHKNGOAK.ReturnCode;
				array11[1] = FEOMHKNGOAK.DebugMessage;
				BNGIGHBHPEH.SendMonoMessage(lelhnddckco3, array11);
			}
			else
			{
				string text3 = (string)FEOMHKNGOAK[(byte)-159];
				if (!string.IsNullOrEmpty(text3))
				{
					this.AJFMHFLGCFN.RoomName = text3;
				}
				this.NHKBIPAKHOJ((string)FEOMHKNGOAK[162]);
				this.MOHFIPIDGOH();
			}
			break;
		case 32:
			this.JNPKDLEMJFN(ClientState.Uninitialized);
			this.ONELBBFGFOM();
			break;
		case 33:
			this.JNPKDLEMJFN(ClientState.JoinedLobby);
			this.insideLobby = true;
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnLeftRoom, new object[0]);
			break;
		case 34:
		case 35:
			if (FEOMHKNGOAK.ReturnCode != 0)
			{
				if (FEOMHKNGOAK.ReturnCode == 24)
				{
					Debug.LogError(string.Format(").png" + base.ServerAddress, new object[1]));
				}
				else if (FEOMHKNGOAK.ReturnCode == -102)
				{
					Debug.LogError(string.Format("_Value", new object[0]));
					PhotonNetworkingMessage lelhnddckco4 = (PhotonNetworkingMessage)(-114);
					object[] array12 = new object[0];
					array12[1] = (DisconnectCause)(-2);
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco4, array12);
				}
				else if (FEOMHKNGOAK.ReturnCode == 60)
				{
					Debug.LogError(string.Format("_ScreenResolution", new object[1]));
					PhotonNetworkingMessage lelhnddckco5 = (PhotonNetworkingMessage)(-32);
					object[] array13 = new object[0];
					array13[0] = FEOMHKNGOAK.DebugMessage;
					BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco5, array13);
				}
				else
				{
					Debug.LogError(string.Format("Show Title", FEOMHKNGOAK.DebugMessage, FEOMHKNGOAK.ReturnCode));
				}
				this.JNPKDLEMJFN((ClientState)22);
				this.Disconnect();
				if (FEOMHKNGOAK.ReturnCode == -85)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
					{
						Debug.LogWarning(string.Format("/", new object[0]));
					}
					BNGIGHBHPEH.CLOLHKCFMJP((PhotonNetworkingMessage)(-73), new object[1]);
					PhotonNetworkingMessage lelhnddckco6 = (PhotonNetworkingMessage)(-31);
					object[] array14 = new object[1];
					array14[1] = (DisconnectCause)(-26);
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco6, array14);
				}
				else if (FEOMHKNGOAK.ReturnCode == 111)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
					{
						Debug.LogError(string.Format("_InvScreenSize", new object[1]));
					}
					PhotonNetworkingMessage lelhnddckco7 = PhotonNetworkingMessage.OnConnectedToPhoton;
					object[] array15 = new object[0];
					array15[0] = (DisconnectCause)(-71);
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco7, array15);
				}
				else if (FEOMHKNGOAK.ReturnCode == -192)
				{
					if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
					{
						Debug.LogError(string.Format("threshold", new object[0]));
					}
					PhotonNetworkingMessage lelhnddckco8 = (PhotonNetworkingMessage)(-69);
					object[] array16 = new object[1];
					array16[1] = (DisconnectCause)184;
					BNGIGHBHPEH.SendMonoMessage(lelhnddckco8, array16);
				}
			}
			else
			{
				if (this.IGDBHCGGHFF() == ServerConnection.NameServer || this.NJIFBFEHJKH() == ServerConnection.MasterServer)
				{
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-32))
					{
						string text4 = (string)FEOMHKNGOAK.Parameters[47];
						if (!string.IsNullOrEmpty(text4))
						{
							if (this.IJHIEINKMFP() == null)
							{
								this.AuthValues = new AuthenticationValues();
							}
							this.IJHIEINKMFP().AJBJIDHDDAB(text4);
							PhotonNetwork.player.UserId = text4;
							if (PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
							{
								this.DebugReturn((DebugLevel)7, string.Format("_Offsets", text4));
							}
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey((byte)-18))
					{
						this.MPHFPMJMGJG((string)FEOMHKNGOAK.Parameters[9]);
						if (PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
						{
							this.DebugReturn((DebugLevel)6, string.Format("MenuRecordButton", this.OBCEIJGMKGB));
						}
					}
					if (FEOMHKNGOAK.Parameters.ContainsKey(153))
					{
						this.BAEBFLIPKKB((Dictionary<byte, object>)FEOMHKNGOAK.Parameters[168]);
					}
				}
				if (this.NJIFBFEHJKH() == ServerConnection.GameServer)
				{
					this.MasterServerAddress = (FEOMHKNGOAK[136] as string);
					this.NDPIAMOMGME();
				}
				else if (this.IGDBHCGGHFF() == ServerConnection.MasterServer)
				{
					if (this.AuthMode != AuthModeOption.Auth)
					{
						this.CDDNMNDHELA(this.CGPLAHHGMEO());
					}
					if (PhotonNetwork.autoJoinLobby)
					{
						this.JNPKDLEMJFN(ClientState.Joining);
						this.OpJoinLobby(this.lobby);
					}
					else
					{
						this.State = (ClientState)(-113);
						BNGIGHBHPEH.SendMonoMessage((PhotonNetworkingMessage)103, new object[1]);
					}
				}
				else if (this.IGDBHCGGHFF() == ServerConnection.GameServer)
				{
					this.State = ClientState.Queued;
					this.AJFMHFLGCFN.PlayerProperties = this.HHPBLGDNDOP();
					this.AJFMHFLGCFN.OnGameServer = true;
					if (this.ELNKFMHCMBO == JoinType.CreateRoom || this.ELNKFMHCMBO == (JoinType)7 || this.ELNKFMHCMBO == JoinType.JoinRoom)
					{
						this.FHBKMBGDDMC(this.AJFMHFLGCFN);
					}
					else if (this.ELNKFMHCMBO == JoinType.CreateRoom)
					{
						this.JCPECILENMF(this.AJFMHFLGCFN);
					}
				}
				if (FEOMHKNGOAK.Parameters.ContainsKey(176))
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)FEOMHKNGOAK.Parameters[83];
					if (dictionary != null)
					{
						PhotonNetworkingMessage lelhnddckco9 = (PhotonNetworkingMessage)(-110);
						object[] array17 = new object[1];
						array17[1] = dictionary;
						BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco9, array17);
					}
				}
			}
			break;
		}
	}

	// Token: 0x0600AFD6 RID: 45014 RVA: 0x00411B6C File Offset: 0x0040FD6C
	public virtual bool DJJIHHGPELA(AKBOPCNHFFJ HBJBKOPJDKJ)
	{
		bool flag = this.NJIFBFEHJKH() == ServerConnection.GameServer;
		HBJBKOPJDKJ.OnGameServer = flag;
		if (!flag)
		{
			this.AJFMHFLGCFN = HBJBKOPJDKJ;
		}
		this.ELNKFMHCMBO = ((!HBJBKOPJDKJ.CreateIfNotExists) ? JoinType.CreateRoom : JoinType.CreateRoom);
		return base.IPOIGDNKHJN(HBJBKOPJDKJ);
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x0600AFD7 RID: 45015 RVA: 0x004064C4 File Offset: 0x004046C4
	public string NameServerAddress
	{
		get
		{
			return this.IHAJBEOILOE();
		}
	}

	// Token: 0x0600AFD9 RID: 45017 RVA: 0x00410A57 File Offset: 0x0040EC57
	private void NLEEJPDKBFH(Room DPNHODJHGJL)
	{
		this.NBCIDPIDCDP = DPNHODJHGJL;
	}

	// Token: 0x0600AFDA RID: 45018 RVA: 0x00411BC0 File Offset: 0x0040FDC0
	private ExitGames.Client.Photon.Hashtable HHPBLGDNDOP()
	{
		if (PhotonNetwork.player != null)
		{
			return PhotonNetwork.player.AllProperties;
		}
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable[byte.MaxValue] = this.PlayerName;
		return hashtable;
	}

	// Token: 0x0400148E RID: 5262
	protected internal string KAIBLIKEDHM;

	// Token: 0x04001490 RID: 5264
	private string JOKLGFENMKE;

	// Token: 0x04001491 RID: 5265
	public AuthModeOption AuthMode;

	// Token: 0x04001492 RID: 5266
	public EncryptionMode EncryptionMode;

	// Token: 0x04001494 RID: 5268
	public const string NameServerHost = "ns.exitgames.com";

	// Token: 0x04001495 RID: 5269
	public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

	// Token: 0x04001496 RID: 5270
	private static readonly Dictionary<ConnectionProtocol, int> AEGGDHEGGCL = new Dictionary<ConnectionProtocol, int>
	{
		{
			ConnectionProtocol.Udp,
			5058
		},
		{
			ConnectionProtocol.Tcp,
			4533
		},
		{
			ConnectionProtocol.WebSocket,
			9093
		},
		{
			ConnectionProtocol.WebSocketSecure,
			19093
		}
	};

	// Token: 0x0400149B RID: 5275
	public bool IsInitialConnect;

	// Token: 0x0400149C RID: 5276
	public bool insideLobby;

	// Token: 0x0400149E RID: 5278
	protected internal List<TypedLobbyInfo> HOBLKOKPJOE = new List<TypedLobbyInfo>();

	// Token: 0x0400149F RID: 5279
	public Dictionary<string, RoomInfo> mGameList = new Dictionary<string, RoomInfo>();

	// Token: 0x040014A0 RID: 5280
	public RoomInfo[] mGameListCopy = new RoomInfo[0];

	// Token: 0x040014A1 RID: 5281
	private string OBCEIJGMKGB = string.Empty;

	// Token: 0x040014A2 RID: 5282
	private bool BOKEGDFHBAN;

	// Token: 0x040014A3 RID: 5283
	private Room NBCIDPIDCDP;

	// Token: 0x040014A8 RID: 5288
	private JoinType ELNKFMHCMBO;

	// Token: 0x040014A9 RID: 5289
	protected internal AKBOPCNHFFJ AJFMHFLGCFN;

	// Token: 0x040014AA RID: 5290
	private bool DMCPHGDNGDB;

	// Token: 0x040014AB RID: 5291
	private string[] BEIPFKHGHPC;

	// Token: 0x040014AC RID: 5292
	private int DJIOCIPPBMK;

	// Token: 0x040014AD RID: 5293
	private bool POHIMACBDGL;

	// Token: 0x040014B0 RID: 5296
	public Dictionary<int, PhotonPlayer> mActors = new Dictionary<int, PhotonPlayer>();

	// Token: 0x040014B1 RID: 5297
	public PhotonPlayer[] mOtherPlayerListCopy = new PhotonPlayer[0];

	// Token: 0x040014B2 RID: 5298
	public PhotonPlayer[] mPlayerListCopy = new PhotonPlayer[0];

	// Token: 0x040014B3 RID: 5299
	public bool hasSwitchedMC;

	// Token: 0x040014B4 RID: 5300
	private HashSet<byte> CHIJNBAJIHE = new HashSet<byte>();

	// Token: 0x040014B5 RID: 5301
	private HashSet<byte> FFBGBLFBHOK = new HashSet<byte>();

	// Token: 0x040014B6 RID: 5302
	protected internal Dictionary<int, PhotonView> HFCMPEKPBAM = new Dictionary<int, PhotonView>();

	// Token: 0x040014B7 RID: 5303
	private readonly PhotonStream CMABENLIOGI = new PhotonStream(false, null);

	// Token: 0x040014B8 RID: 5304
	private readonly PhotonStream ALPAEKHFHPP = new PhotonStream(true, null);

	// Token: 0x040014B9 RID: 5305
	private readonly Dictionary<int, ExitGames.Client.Photon.Hashtable> ECMNAOLPNBO = new Dictionary<int, ExitGames.Client.Photon.Hashtable>();

	// Token: 0x040014BA RID: 5306
	private readonly Dictionary<int, ExitGames.Client.Photon.Hashtable> ABIMEMLJLPA = new Dictionary<int, ExitGames.Client.Photon.Hashtable>();

	// Token: 0x040014BB RID: 5307
	protected internal short PKCNHOKCLJH;

	// Token: 0x040014BC RID: 5308
	protected internal bool HMIEGLIHGEM;

	// Token: 0x040014BD RID: 5309
	protected internal const string IDPJICOIFIH = "curScn";

	// Token: 0x040014BE RID: 5310
	public static bool UsePrefabCache = true;

	// Token: 0x040014BF RID: 5311
	internal IPunPrefabPool EGNHNBODKHP;

	// Token: 0x040014C0 RID: 5312
	public static Dictionary<string, GameObject> PrefabCache = new Dictionary<string, GameObject>();

	// Token: 0x040014C1 RID: 5313
	private Dictionary<Type, List<MethodInfo>> MNKFMEHFNKJ = new Dictionary<Type, List<MethodInfo>>();

	// Token: 0x040014C2 RID: 5314
	private readonly Dictionary<string, int> CPLBCMDIGNB;

	// Token: 0x040014C3 RID: 5315
	private static readonly string BJJEABNGKBF = PhotonNetworkingMessage.OnPhotonInstantiate.ToString();

	// Token: 0x040014C4 RID: 5316
	private string BLNBCGLIOHP;

	// Token: 0x040014C5 RID: 5317
	private string KAOMEDGGMEM;

	// Token: 0x040014C6 RID: 5318
	private ServerConnection PKNIJKPIKAF;

	// Token: 0x040014C7 RID: 5319
	private bool IDOAHFHJJJE;

	// Token: 0x040014C8 RID: 5320
	private Dictionary<int, object[]> IDIKEJLLFFP = new Dictionary<int, object[]>();

	// Token: 0x040014C9 RID: 5321
	public static int ObjectsInOneUpdate = 10;

	// Token: 0x040014CA RID: 5322
	private RaiseEventOptions PCFOAMAODBD = new RaiseEventOptions();

	// Token: 0x040014CB RID: 5323
	public const int SyncViewId = 0;

	// Token: 0x040014CC RID: 5324
	public const int SyncCompressed = 1;

	// Token: 0x040014CD RID: 5325
	public const int SyncNullValues = 2;

	// Token: 0x040014CE RID: 5326
	public const int SyncFirstValue = 3;
}
