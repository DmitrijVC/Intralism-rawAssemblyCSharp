using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon;
using UnityEngine;

namespace ExitGames.UtilityScripts
{
	// Token: 0x02000350 RID: 848
	public class PlayerRoomIndexing : PunBehaviour
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600BF85 RID: 49029 RVA: 0x0045B471 File Offset: 0x00459671
		public int[] PlayerIds
		{
			get
			{
				return this._playerIds;
			}
		}

		// Token: 0x0600BF86 RID: 49030 RVA: 0x0045B479 File Offset: 0x00459679
		public void Awake()
		{
			if (PlayerRoomIndexing.instance != null)
			{
				Debug.LogError("Existing instance of PlayerRoomIndexing found. Only One instance is required at the most. Please correct and have only one at any time.");
			}
			PlayerRoomIndexing.instance = this;
			if (PhotonNetwork.room != null)
			{
				this.SanitizeIndexing(true);
			}
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x0045B4AC File Offset: 0x004596AC
		public override void OnJoinedRoom()
		{
			if (PhotonNetwork.isMasterClient)
			{
				this.AssignIndex(PhotonNetwork.player);
			}
			else
			{
				this.RefreshData();
			}
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x0045B4CE File Offset: 0x004596CE
		public override void OnLeftRoom()
		{
			this.RefreshData();
		}

		// Token: 0x0600BF89 RID: 49033 RVA: 0x0045B4D6 File Offset: 0x004596D6
		public override void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
		{
			if (PhotonNetwork.isMasterClient)
			{
				this.AssignIndex(newPlayer);
			}
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x0045B4E9 File Offset: 0x004596E9
		public override void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
		{
			if (PhotonNetwork.isMasterClient)
			{
				this.UnAssignIndex(otherPlayer);
			}
		}

		// Token: 0x0600BF8B RID: 49035 RVA: 0x0045B4FC File Offset: 0x004596FC
		public override void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
		{
			if (propertiesThatChanged.ContainsKey("PlayerIndexes"))
			{
				this.RefreshData();
			}
		}

		// Token: 0x0600BF8C RID: 49036 RVA: 0x0045B514 File Offset: 0x00459714
		public override void OnMasterClientSwitched(PhotonPlayer newMasterClient)
		{
			if (PhotonNetwork.isMasterClient)
			{
				this.SanitizeIndexing(false);
			}
		}

		// Token: 0x0600BF8D RID: 49037 RVA: 0x0045B527 File Offset: 0x00459727
		public int GetRoomIndex(PhotonPlayer player)
		{
			if (this._indexesLUT != null && this._indexesLUT.ContainsKey(player.ID))
			{
				return this._indexesLUT[player.ID];
			}
			return -1;
		}

		// Token: 0x0600BF8E RID: 49038 RVA: 0x0045B560 File Offset: 0x00459760
		private void SanitizeIndexing(bool forceIndexing = false)
		{
			if (!forceIndexing && !PhotonNetwork.isMasterClient)
			{
				return;
			}
			if (PhotonNetwork.room == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (PhotonNetwork.room.CustomProperties.TryGetValue("PlayerIndexes", out this._indexes))
			{
				dictionary = (this._indexes as Dictionary<int, int>);
			}
			if (dictionary.Count != PhotonNetwork.room.PlayerCount)
			{
				foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
				{
					if (!dictionary.ContainsKey(photonPlayer.ID))
					{
						this.AssignIndex(photonPlayer);
					}
				}
			}
		}

		// Token: 0x0600BF8F RID: 49039 RVA: 0x0045B608 File Offset: 0x00459808
		private void RefreshData()
		{
			if (PhotonNetwork.room != null)
			{
				this._playerIds = new int[PhotonNetwork.room.MaxPlayers];
				if (PhotonNetwork.room.CustomProperties.TryGetValue("PlayerIndexes", out this._indexes))
				{
					this._indexesLUT = (this._indexes as Dictionary<int, int>);
					foreach (KeyValuePair<int, int> keyValuePair in this._indexesLUT)
					{
						this._p = PhotonPlayer.Find(keyValuePair.Key);
						this._playerIds[keyValuePair.Value] = this._p.ID;
					}
				}
			}
			else
			{
				this._playerIds = new int[0];
			}
			if (this.OnRoomIndexingChanged != null)
			{
				this.OnRoomIndexingChanged();
			}
		}

		// Token: 0x0600BF90 RID: 49040 RVA: 0x0045B700 File Offset: 0x00459900
		private void AssignIndex(PhotonPlayer player)
		{
			if (PhotonNetwork.room.CustomProperties.TryGetValue("PlayerIndexes", out this._indexes))
			{
				this._indexesLUT = (this._indexes as Dictionary<int, int>);
			}
			else
			{
				this._indexesLUT = new Dictionary<int, int>();
			}
			List<bool> list = new List<bool>(new bool[PhotonNetwork.room.MaxPlayers]);
			foreach (KeyValuePair<int, int> keyValuePair in this._indexesLUT)
			{
				list[keyValuePair.Value] = true;
			}
			this._indexesLUT[player.ID] = Mathf.Max(0, list.IndexOf(false));
			PhotonNetwork.room.SetCustomProperties(new Hashtable
			{
				{
					"PlayerIndexes",
					this._indexesLUT
				}
			}, null, false);
			this.RefreshData();
		}

		// Token: 0x0600BF91 RID: 49041 RVA: 0x0045B800 File Offset: 0x00459A00
		private void UnAssignIndex(PhotonPlayer player)
		{
			if (PhotonNetwork.room.CustomProperties.TryGetValue("PlayerIndexes", out this._indexes))
			{
				this._indexesLUT = (this._indexes as Dictionary<int, int>);
				this._indexesLUT.Remove(player.ID);
				PhotonNetwork.room.SetCustomProperties(new Hashtable
				{
					{
						"PlayerIndexes",
						this._indexesLUT
					}
				}, null, false);
			}
			this.RefreshData();
		}

		// Token: 0x0400165C RID: 5724
		public static PlayerRoomIndexing instance;

		// Token: 0x0400165D RID: 5725
		public PlayerRoomIndexing.RoomIndexingChanged OnRoomIndexingChanged;

		// Token: 0x0400165E RID: 5726
		public const string RoomPlayerIndexedProp = "PlayerIndexes";

		// Token: 0x0400165F RID: 5727
		private int[] _playerIds;

		// Token: 0x04001660 RID: 5728
		private object _indexes;

		// Token: 0x04001661 RID: 5729
		private Dictionary<int, int> _indexesLUT;

		// Token: 0x04001662 RID: 5730
		private List<bool> _indexesPool;

		// Token: 0x04001663 RID: 5731
		private PhotonPlayer _p;

		// Token: 0x02000351 RID: 849
		// (Invoke) Token: 0x0600BF93 RID: 49043
		public delegate void RoomIndexingChanged();
	}
}
