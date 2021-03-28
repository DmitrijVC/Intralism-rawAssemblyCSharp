using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;

// Token: 0x02000303 RID: 771
public interface IPunCallbacks
{
	// Token: 0x0600AFDC RID: 45020
	void OnConnectedToPhoton();

	// Token: 0x0600AFDD RID: 45021
	void OnLeftRoom();

	// Token: 0x0600AFDE RID: 45022
	void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO);

	// Token: 0x0600AFDF RID: 45023
	void OnPhotonCreateRoomFailed(object[] APELDCFFFOH);

	// Token: 0x0600AFE0 RID: 45024
	void OnPhotonJoinRoomFailed(object[] APELDCFFFOH);

	// Token: 0x0600AFE1 RID: 45025
	void OnCreatedRoom();

	// Token: 0x0600AFE2 RID: 45026
	void OnJoinedLobby();

	// Token: 0x0600AFE3 RID: 45027
	void OnLeftLobby();

	// Token: 0x0600AFE4 RID: 45028
	void OnFailedToConnectToPhoton(DisconnectCause BMDDEFBNHAL);

	// Token: 0x0600AFE5 RID: 45029
	void OnConnectionFail(DisconnectCause BMDDEFBNHAL);

	// Token: 0x0600AFE6 RID: 45030
	void OnDisconnectedFromPhoton();

	// Token: 0x0600AFE7 RID: 45031
	void OnPhotonInstantiate(PhotonMessageInfo DAGALCAILLN);

	// Token: 0x0600AFE8 RID: 45032
	void OnReceivedRoomListUpdate();

	// Token: 0x0600AFE9 RID: 45033
	void OnJoinedRoom();

	// Token: 0x0600AFEA RID: 45034
	void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM);

	// Token: 0x0600AFEB RID: 45035
	void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ);

	// Token: 0x0600AFEC RID: 45036
	void OnPhotonRandomJoinFailed(object[] APELDCFFFOH);

	// Token: 0x0600AFED RID: 45037
	void OnConnectedToMaster();

	// Token: 0x0600AFEE RID: 45038
	void OnPhotonMaxCccuReached();

	// Token: 0x0600AFEF RID: 45039
	void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK);

	// Token: 0x0600AFF0 RID: 45040
	void OnPhotonPlayerPropertiesChanged(object[] EMIPGAIEKMK);

	// Token: 0x0600AFF1 RID: 45041
	void OnUpdatedFriendList();

	// Token: 0x0600AFF2 RID: 45042
	void OnCustomAuthenticationFailed(string ONHDMMPKKFH);

	// Token: 0x0600AFF3 RID: 45043
	void OnCustomAuthenticationResponse(Dictionary<string, object> NOJGGCLPPAM);

	// Token: 0x0600AFF4 RID: 45044
	void OnWebRpcResponse(OperationResponse NEKOLHLOPCJ);

	// Token: 0x0600AFF5 RID: 45045
	void OnOwnershipRequest(object[] AHDLHDMNGMP);

	// Token: 0x0600AFF6 RID: 45046
	void OnLobbyStatisticsUpdate();

	// Token: 0x0600AFF7 RID: 45047
	void OnPhotonPlayerActivityChanged(PhotonPlayer MCDOIGNGJBJ);

	// Token: 0x0600AFF8 RID: 45048
	void OnOwnershipTransfered(object[] MMOAKBJOOHM);
}
