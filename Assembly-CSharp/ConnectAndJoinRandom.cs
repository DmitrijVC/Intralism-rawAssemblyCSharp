using System;
using Photon;
using UnityEngine;

// Token: 0x0200033C RID: 828
public class ConnectAndJoinRandom : Photon.MonoBehaviour
{
	// Token: 0x0600BB41 RID: 47937 RVA: 0x0044252C File Offset: 0x0044072C
	public virtual void OnPhotonRandomJoinFailed()
	{
		Debug.Log("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 4
		}, null);
	}

	// Token: 0x0600BB42 RID: 47938 RVA: 0x00442559 File Offset: 0x00440759
	public void KPGIJJHDCJI()
	{
		Debug.Log("CameraFilterPack/Atmosphere_Snow_8bits");
	}

	// Token: 0x0600BB43 RID: 47939 RVA: 0x00442565 File Offset: 0x00440765
	public virtual void KDMKDEKCELE()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BB44 RID: 47940 RVA: 0x00442570 File Offset: 0x00440770
	public virtual void GABEPDMFBCL()
	{
		Debug.Log("_ScreenResolution");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 7
		}, null);
	}

	// Token: 0x0600BB45 RID: 47941 RVA: 0x004425A0 File Offset: 0x004407A0
	public virtual void FABMDEHEDNO()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("StartButton");
			this.IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(this.Version + "_TimeX" + SceneManagerHelper.HNACANCGPPP());
		}
	}

	// Token: 0x0600BB46 RID: 47942 RVA: 0x00442603 File Offset: 0x00440803
	public virtual void KLNNHMBIBOF(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(":\n" + BMDDEFBNHAL);
	}

	// Token: 0x0600BB47 RID: 47943 RVA: 0x0044261A File Offset: 0x0044081A
	public void IJOJEFDGGHH()
	{
		Debug.Log("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(");
	}

	// Token: 0x0600BB48 RID: 47944 RVA: 0x00442628 File Offset: 0x00440828
	public virtual void OEENOOGEEHD()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("Curve texture");
			this.IDBCIKHLGKL = true;
			PhotonNetwork.ConnectUsingSettings(this.Version + "CameraFilterPack/TV_Old" + SceneManagerHelper.NFKGOFFDNEH());
		}
	}

	// Token: 0x0600BB49 RID: 47945 RVA: 0x0044268B File Offset: 0x0044088B
	public virtual void ENPAMMGKEOP()
	{
		Debug.Log("DPADHOR");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB4A RID: 47946 RVA: 0x0044269D File Offset: 0x0044089D
	public virtual void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("Cause: " + BMDDEFBNHAL);
	}

	// Token: 0x0600BB4B RID: 47947 RVA: 0x004426B4 File Offset: 0x004408B4
	public virtual void KNLFHKBNBOD()
	{
		Debug.Log("Joystick1Button7");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB4C RID: 47948 RVA: 0x004426C6 File Offset: 0x004408C6
	public virtual void BCDDEKNEHII()
	{
		Debug.Log("Ev OwnershipRequest ");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB4D RID: 47949 RVA: 0x004426D8 File Offset: 0x004408D8
	public virtual void PIFDBALMCFG(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError(".save" + BMDDEFBNHAL);
	}

	// Token: 0x0600BB4E RID: 47950 RVA: 0x00442565 File Offset: 0x00440765
	public virtual void FIKFJDFELIP()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BB4F RID: 47951 RVA: 0x004426EF File Offset: 0x004408EF
	public virtual void OnConnectedToMaster()
	{
		Debug.Log("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB50 RID: 47952 RVA: 0x00442701 File Offset: 0x00440901
	public virtual void FMAEMIIFLMM()
	{
		Debug.Log("BitsData");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB51 RID: 47953 RVA: 0x00442713 File Offset: 0x00440913
	public void EJNJHNLJFGE()
	{
		Debug.Log("LeaderboardsButton");
	}

	// Token: 0x0600BB52 RID: 47954 RVA: 0x0044271F File Offset: 0x0044091F
	public virtual void PLKJMLJHAJM()
	{
		Debug.Log("maps.");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB53 RID: 47955 RVA: 0x00442731 File Offset: 0x00440931
	public virtual void IBDJHIKBOKC()
	{
		Debug.Log("Could not execute RPC ");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB54 RID: 47956 RVA: 0x00442743 File Offset: 0x00440943
	public virtual void OnJoinedLobby()
	{
		Debug.Log("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB55 RID: 47957 RVA: 0x00442758 File Offset: 0x00440958
	public virtual void MOMFHGJNBFG()
	{
		Debug.Log(" BETA");
		PhotonNetwork.CreateRoom(null, new RoomOptions
		{
			MaxPlayers = 2
		}, null);
	}

	// Token: 0x0600BB56 RID: 47958 RVA: 0x00442788 File Offset: 0x00440988
	public virtual void Update()
	{
		if (this.IDBCIKHLGKL && this.AutoConnect && !PhotonNetwork.connected)
		{
			Debug.Log("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();");
			this.IDBCIKHLGKL = false;
			PhotonNetwork.ConnectUsingSettings(this.Version + "." + SceneManagerHelper.ActiveSceneBuildIndex);
		}
	}

	// Token: 0x0600BB57 RID: 47959 RVA: 0x004427EB File Offset: 0x004409EB
	public virtual void JPJPKKGBFDI(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("/512px-512px.png" + BMDDEFBNHAL);
	}

	// Token: 0x0600BB58 RID: 47960 RVA: 0x00442802 File Offset: 0x00440A02
	public virtual void Start()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	// Token: 0x0600BB59 RID: 47961 RVA: 0x00442565 File Offset: 0x00440765
	public virtual void MMMDPANNAIO()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BB5A RID: 47962 RVA: 0x0044280A File Offset: 0x00440A0A
	public virtual void BACMLNFLFHN()
	{
		Debug.Log("offsets");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB5B RID: 47963 RVA: 0x0044281C File Offset: 0x00440A1C
	public void JKNOPMDDLML()
	{
		Debug.Log("The process failed: ");
	}

	// Token: 0x0600BB5C RID: 47964 RVA: 0x00442828 File Offset: 0x00440A28
	public void PNHBOKMFFNN()
	{
		Debug.Log("_Value5");
	}

	// Token: 0x0600BB5D RID: 47965 RVA: 0x00442834 File Offset: 0x00440A34
	public void OnJoinedRoom()
	{
		Debug.Log("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");
	}

	// Token: 0x0600BB5E RID: 47966 RVA: 0x00442802 File Offset: 0x00440A02
	public virtual void BEBNOKFLJPH()
	{
		PhotonNetwork.autoJoinLobby = false;
	}

	// Token: 0x0600BB5F RID: 47967 RVA: 0x00442840 File Offset: 0x00440A40
	public virtual void CKALCMLLJOE()
	{
		Debug.Log("_LightIntensity");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB60 RID: 47968 RVA: 0x00442852 File Offset: 0x00440A52
	public void IMPGHNBKJAE()
	{
		Debug.Log("_Value4");
	}

	// Token: 0x0600BB61 RID: 47969 RVA: 0x0044285E File Offset: 0x00440A5E
	public void CHLAEFHCKEO()
	{
		Debug.Log("MusicFileSelector");
	}

	// Token: 0x0600BB62 RID: 47970 RVA: 0x0044286A File Offset: 0x00440A6A
	public virtual void MDMLFBLLIDG(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("{0:0} day{1}, " + BMDDEFBNHAL);
	}

	// Token: 0x0600BB64 RID: 47972 RVA: 0x00442565 File Offset: 0x00440765
	public virtual void NBGIMIDICKE()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	// Token: 0x0600BB65 RID: 47973 RVA: 0x0044289E File Offset: 0x00440A9E
	public virtual void JLEIIMLIIDL()
	{
		Debug.Log("skin.hit_normal");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB66 RID: 47974 RVA: 0x004428B0 File Offset: 0x00440AB0
	public virtual void AKAOCBJBHJH(DisconnectCause BMDDEFBNHAL)
	{
		Debug.LogError("_Value" + BMDDEFBNHAL);
	}

	// Token: 0x0600BB67 RID: 47975 RVA: 0x004428C7 File Offset: 0x00440AC7
	public void IMNLBGHLDGI()
	{
		Debug.Log("[Down]");
	}

	// Token: 0x0600BB68 RID: 47976 RVA: 0x004428D3 File Offset: 0x00440AD3
	public virtual void GJKPODOKJIB()
	{
		Debug.Log("Waiting for AvailableRegions. State: ");
		PhotonNetwork.JoinRandomRoom();
	}

	// Token: 0x0600BB69 RID: 47977 RVA: 0x004428E5 File Offset: 0x00440AE5
	public void AGOLOCOPNOD()
	{
		Debug.Log(" = ");
	}

	// Token: 0x04001602 RID: 5634
	public bool AutoConnect = true;

	// Token: 0x04001603 RID: 5635
	public byte Version = 1;

	// Token: 0x04001604 RID: 5636
	private bool IDBCIKHLGKL = true;
}
