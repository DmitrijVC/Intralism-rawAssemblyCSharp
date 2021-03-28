using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x020004C8 RID: 1224
public class NetworkScene : PunBehaviour
{
	// Token: 0x06011A39 RID: 72249 RVA: 0x00612103 File Offset: 0x00610303
	public void EAAHNMFGIFO(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.GMAHNPNHMFK();
		string lblkdnnpaco = "Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
		object[] array = new object[0];
		array[0] = string.Empty + BHNGOLDNELC;
		array[0] = JKPJCEMPAGH;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A3A RID: 72250 RVA: 0x00612134 File Offset: 0x00610334
	public IEnumerator CPJHOJLHCCA()
	{
		this.players = new List<DynamicPlayerInfo>();
		GameObject gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			ulong num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			Sprite sprite = null;
			CSteamID csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A3B RID: 72251 RVA: 0x00603DDC File Offset: 0x00601FDC
	public void SendChatActionMessage(string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, new object[]
		{
			JKPJCEMPAGH
		});
	}

	// Token: 0x06011A3C RID: 72252 RVA: 0x0061214F File Offset: 0x0061034F
	public void KNEOIOEHFML(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.NJEBMOPIBII(JKPJCEMPAGH);
	}

	// Token: 0x06011A3D RID: 72253 RVA: 0x0061215C File Offset: 0x0061035C
	public void ICCKNDBPHDA(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.MEPEAEDPBKN(JKPJCEMPAGH);
	}

	// Token: 0x06011A3E RID: 72254 RVA: 0x0061216C File Offset: 0x0061036C
	public void FJHFOBHJEHL()
	{
		if (this.BFLIELGAAIM != null && this.BFLIELGAAIM.isGameStarted && !this.BFLIELGAAIM.gameOver)
		{
			if (this.GPLLPIOEJBC > 1569f)
			{
				this.GPLLPIOEJBC -= Time.deltaTime;
			}
			else
			{
				this.GPLLPIOEJBC = 822f;
				this.KNIOEDPEBDG();
			}
		}
	}

	// Token: 0x06011A3F RID: 72255 RVA: 0x006121EC File Offset: 0x006103EC
	private IEnumerator CDKCHEGOCJP(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		base.StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && base.GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources(false);
		if (base.GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
		yield break;
	}

	// Token: 0x06011A40 RID: 72256 RVA: 0x00612215 File Offset: 0x00610415
	public void IPEFPLFPBFG()
	{
		if (!this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().FKAEJEPJIEP();
		}
	}

	// Token: 0x06011A41 RID: 72257 RVA: 0x0061223C File Offset: 0x0061043C
	public virtual void GLBBMGMJJBM(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("nogamesfound");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Editor/", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		}
		base.StartCoroutine(this.GFKAGIONDEN());
	}

	// Token: 0x06011A42 RID: 72258 RVA: 0x00612290 File Offset: 0x00610490
	public void OLBAIFGLAJM()
	{
		for (int i = 0; i < this.players.Count; i++)
		{
			IEnumerable<DynamicPlayerInfo> source = this.players;
			if (NetworkScene.LNIJKGECNME == null)
			{
				NetworkScene.LNIJKGECNME = new Func<DynamicPlayerInfo, int>(NetworkScene.ANHMEMNCMAD);
			}
			DynamicPlayerInfo dynamicPlayerInfo = source.OrderByDescending(NetworkScene.LNIJKGECNME).ToArray<DynamicPlayerInfo>()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				this.firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				this.place = i + 0;
			}
		}
	}

	// Token: 0x06011A43 RID: 72259 RVA: 0x0061231B File Offset: 0x0061051B
	public void EOAMNEABNMK(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.EGNAIPOMDNH((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011A44 RID: 72260 RVA: 0x00612333 File Offset: 0x00610533
	public void FBOCNPJPGFK()
	{
		if (this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
	}

	// Token: 0x06011A45 RID: 72261 RVA: 0x0061235C File Offset: 0x0061055C
	[PunRPC]
	public void UpdateScoreboard()
	{
		for (int i = 0; i < this.players.Count; i++)
		{
			IEnumerable<DynamicPlayerInfo> source = this.players;
			if (NetworkScene.LNIJKGECNME == null)
			{
				NetworkScene.LNIJKGECNME = new Func<DynamicPlayerInfo, int>(NetworkScene.KKAIKIOFDMG);
			}
			DynamicPlayerInfo dynamicPlayerInfo = source.OrderByDescending(NetworkScene.LNIJKGECNME).ToArray<DynamicPlayerInfo>()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				this.firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				this.place = i + 1;
			}
		}
	}

	// Token: 0x06011A46 RID: 72262 RVA: 0x006123E8 File Offset: 0x006105E8
	public IEnumerator NGBMKMKIONO()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A47 RID: 72263 RVA: 0x00612403 File Offset: 0x00610603
	internal void LEGKOCDMDIP(string EAFAMAMDNEG)
	{
		base.GetComponent<GameScene>().asampler.Pause();
		base.GetComponent<GameScene>().KOJKBFDNGDK();
	}

	// Token: 0x06011A48 RID: 72264 RVA: 0x00612420 File Offset: 0x00610620
	public override void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("Player Connected");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("masterSteamID", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		}
		base.StartCoroutine(this.UpdatePlayersList());
	}

	// Token: 0x06011A49 RID: 72265 RVA: 0x00612471 File Offset: 0x00610671
	public void OHDEFNGKCIH(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.IBKCMBIGOEJ();
		string lblkdnnpaco = ".lastCheckpoint.perfectHits";
		PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
		object[] array = new object[4];
		array[0] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A4A RID: 72266 RVA: 0x006124A4 File Offset: 0x006106A4
	public IEnumerator AFFOOFOBMNF()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A4B RID: 72267 RVA: 0x006124C0 File Offset: 0x006106C0
	private IEnumerator JBENCECOCCC(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		base.StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && base.GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources(false);
		if (base.GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
		yield break;
	}

	// Token: 0x06011A4C RID: 72268 RVA: 0x006124EC File Offset: 0x006106EC
	public void PKGJJFIFLII()
	{
		if (this.BFLIELGAAIM != null && this.BFLIELGAAIM.isGameStarted && !this.BFLIELGAAIM.gameOver)
		{
			if (this.GPLLPIOEJBC > 332f)
			{
				this.GPLLPIOEJBC -= Time.deltaTime;
			}
			else
			{
				this.GPLLPIOEJBC = 1563f;
				this.KNIOEDPEBDG();
			}
		}
	}

	// Token: 0x06011A4D RID: 72269 RVA: 0x0061256C File Offset: 0x0061076C
	public void LOGMIOJHHMP(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.GBHNDHLAJLI();
		string lblkdnnpaco = "}";
		PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
		object[] array = new object[1];
		array[1] = JKPJCEMPAGH;
		photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A4E RID: 72270 RVA: 0x00612589 File Offset: 0x00610789
	internal void DMOFPKFBNNG(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		base.GetComponent<GameScene>().PNEHHLMHJAA(ResourcesManager.ALCCOCOFLAK(new CSteamID(ulong.Parse(OBCEIJGMKGB)), false) + "_EdgeThreshold" + NOJGGCLPPAM, 1982f);
	}

	// Token: 0x06011A4F RID: 72271 RVA: 0x006125B7 File Offset: 0x006107B7
	public void ELHNBIJLGFB(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.PNMLHJFPGDI((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011A50 RID: 72272 RVA: 0x006125CF File Offset: 0x006107CF
	public void NAGPMNDBBON(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.LBAGEPFKJPG("s", HMGBJCGOLMI));
	}

	// Token: 0x06011A51 RID: 72273 RVA: 0x006125E4 File Offset: 0x006107E4
	public virtual void INGBALHGDPF(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("VIGNETTE_BLUR");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Threshold", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		base.StartCoroutine(this.GFKAGIONDEN());
	}

	// Token: 0x06011A52 RID: 72274 RVA: 0x00612638 File Offset: 0x00610838
	public override void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("Player Disconnected");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("masterSteamID", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, false);
		}
		base.StartCoroutine(this.UpdatePlayersList());
	}

	// Token: 0x06011A53 RID: 72275 RVA: 0x00612215 File Offset: 0x00610415
	public void DANMKBHOCAO()
	{
		if (!this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().FKAEJEPJIEP();
		}
	}

	// Token: 0x06011A54 RID: 72276 RVA: 0x00612689 File Offset: 0x00610889
	[PunRPC]
	internal void OnPlayerGameMessage(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		base.GetComponent<GameScene>().AddMessage(ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(new CSteamID(ulong.Parse(OBCEIJGMKGB)), true) + " " + NOJGGCLPPAM, 1f);
	}

	// Token: 0x06011A55 RID: 72277 RVA: 0x006126B8 File Offset: 0x006108B8
	public void BMOBABEGEFG()
	{
		for (int i = 1; i < this.players.Count; i += 0)
		{
			IEnumerable<DynamicPlayerInfo> source = this.players;
			if (NetworkScene.LNIJKGECNME == null)
			{
				NetworkScene.LNIJKGECNME = new Func<DynamicPlayerInfo, int>(NetworkScene.KNNDEDLPKHI);
			}
			DynamicPlayerInfo dynamicPlayerInfo = source.OrderByDescending(NetworkScene.LNIJKGECNME).ToArray<DynamicPlayerInfo>()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				this.firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				this.place = i + 1;
			}
		}
	}

	// Token: 0x06011A56 RID: 72278 RVA: 0x00612744 File Offset: 0x00610944
	public IEnumerator HBGGFGDHLBK()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A57 RID: 72279 RVA: 0x00603CB8 File Offset: 0x00601EB8
	[PunRPC]
	public void RecieveChatActionMessage(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}

	// Token: 0x06011A58 RID: 72280 RVA: 0x0061275F File Offset: 0x0061095F
	internal void FOBJPLLALBE(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		base.GetComponent<GameScene>().OHOJFIKCLPI(ResourcesManager.HCPCLINEDDD(new CSteamID(ulong.Parse(OBCEIJGMKGB)), true) + "workshop." + NOJGGCLPPAM, 777f);
	}

	// Token: 0x06011A59 RID: 72281 RVA: 0x00604222 File Offset: 0x00602422
	public void SendChatMessage(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatMessage", PhotonTargets.AllViaServer, new object[]
		{
			string.Empty + BHNGOLDNELC,
			JKPJCEMPAGH
		});
	}

	// Token: 0x06011A5A RID: 72282 RVA: 0x00612790 File Offset: 0x00610990
	public void Update()
	{
		if (this.BFLIELGAAIM != null && this.BFLIELGAAIM.isGameStarted && !this.BFLIELGAAIM.gameOver)
		{
			if (this.GPLLPIOEJBC > 0f)
			{
				this.GPLLPIOEJBC -= Time.deltaTime;
			}
			else
			{
				this.GPLLPIOEJBC = 1f;
				this.UpdateScoreboard();
			}
		}
	}

	// Token: 0x06011A5B RID: 72283 RVA: 0x0060482A File Offset: 0x00602A2A
	[PunRPC]
	public void RecieveChatMessage(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011A5C RID: 72284 RVA: 0x00612810 File Offset: 0x00610A10
	public void NBJEMEINLPD(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.CIACEFBNDDJ();
		string lblkdnnpaco = "Exit to menu?";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBuffered;
		object[] array = new object[4];
		array[1] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A5D RID: 72285 RVA: 0x00612333 File Offset: 0x00610533
	public void AEDJEBAMMDM()
	{
		if (this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
	}

	// Token: 0x06011A5E RID: 72286 RVA: 0x00612840 File Offset: 0x00610A40
	public void FECMEIJGLJI()
	{
		this.place = 1;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.HBGGFGDHLBK());
		}
		else
		{
			this.networkCanvas.SetActive(true);
		}
	}

	// Token: 0x06011A5F RID: 72287 RVA: 0x006128A4 File Offset: 0x00610AA4
	public void OpenChat()
	{
		if (!this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().OpenObjectAnimation();
		}
	}

	// Token: 0x06011A60 RID: 72288 RVA: 0x006128CC File Offset: 0x00610ACC
	public virtual void PLLJCHMHLIO(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("sounds/hit_wrong");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_TimeX", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		base.StartCoroutine(this.GFKAGIONDEN());
	}

	// Token: 0x06011A61 RID: 72289 RVA: 0x00612920 File Offset: 0x00610B20
	private IEnumerator AAMLPNJMODK(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		base.StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && base.GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources(false);
		if (base.GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
		yield break;
	}

	// Token: 0x06011A62 RID: 72290 RVA: 0x00612949 File Offset: 0x00610B49
	public void FMHEBDAIOLI(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.CIACEFBNDDJ();
		string lblkdnnpaco = "_EmissionGain";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
		object[] array = new object[8];
		array[1] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A63 RID: 72291 RVA: 0x00612979 File Offset: 0x00610B79
	public void CGHCFFCNOIJ(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.EOOCGIFFKBG();
		string lblkdnnpaco = ".a";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[1];
		array[1] = JKPJCEMPAGH;
		photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A64 RID: 72292 RVA: 0x00612998 File Offset: 0x00610B98
	public void PIEPPKMBJHI()
	{
		this.place = 0;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(false);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.DIIFECKELPF());
		}
		else
		{
			this.networkCanvas.SetActive(true);
		}
	}

	// Token: 0x06011A65 RID: 72293 RVA: 0x006129FC File Offset: 0x00610BFC
	public void FOLDLDLFFLM()
	{
		if (this.BFLIELGAAIM != null && this.BFLIELGAAIM.isGameStarted && !this.BFLIELGAAIM.gameOver)
		{
			if (this.GPLLPIOEJBC > 416f)
			{
				this.GPLLPIOEJBC -= Time.deltaTime;
			}
			else
			{
				this.GPLLPIOEJBC = 1937f;
				this.KNIOEDPEBDG();
			}
		}
	}

	// Token: 0x06011A66 RID: 72294 RVA: 0x00612A7C File Offset: 0x00610C7C
	public void CloseChat()
	{
		if (this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().CloseObjectAnimation();
		}
	}

	// Token: 0x06011A67 RID: 72295 RVA: 0x00612AA4 File Offset: 0x00610CA4
	public void LLAHPNGMEOO()
	{
		this.place = 1;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(false);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.CPJHOJLHCCA());
		}
		else
		{
			this.networkCanvas.SetActive(true);
		}
	}

	// Token: 0x06011A68 RID: 72296 RVA: 0x00612B08 File Offset: 0x00610D08
	public void OnExitButton(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.CDKCHEGOCJP("MenuScene", HMGBJCGOLMI));
	}

	// Token: 0x06011A69 RID: 72297 RVA: 0x00612B1D File Offset: 0x00610D1D
	public void KPJOEDDBFHB(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.FFIPLLNKGEN();
		string lblkdnnpaco = "PunRespawn";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[]
		{
			string.Empty + BHNGOLDNELC
		};
		array[0] = JKPJCEMPAGH;
		photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A6A RID: 72298 RVA: 0x00612B4D File Offset: 0x00610D4D
	private static int KNNDEDLPKHI(DynamicPlayerInfo HPHENPOHOMK)
	{
		return HPHENPOHOMK.currentScore;
	}

	// Token: 0x06011A6B RID: 72299 RVA: 0x00612215 File Offset: 0x00610415
	public void NHLLJCJMKNC()
	{
		if (!this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().FKAEJEPJIEP();
		}
	}

	// Token: 0x06011A6C RID: 72300 RVA: 0x00612B55 File Offset: 0x00610D55
	public void MIPBKPGLMDN(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AHHMCOEPDPF((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011A6D RID: 72301 RVA: 0x00612B6D File Offset: 0x00610D6D
	internal void MIAKOPFKOFF(string EAFAMAMDNEG)
	{
		base.GetComponent<GameScene>().asampler.CFMNIMFHPMN();
		base.GetComponent<GameScene>().MDNHCLKNCLE();
	}

	// Token: 0x06011A6E RID: 72302 RVA: 0x00612B8C File Offset: 0x00610D8C
	public virtual void LBNKKEPBCCD(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("[NetworkManager] Joined main lobby");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Joystick1Button3", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		base.StartCoroutine(this.AFFOOFOBMNF());
	}

	// Token: 0x06011A6F RID: 72303 RVA: 0x00612BDD File Offset: 0x00610DDD
	public void KNEFADKGEKL(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.FFIPLLNKGEN();
		string lblkdnnpaco = "BadgeText";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
		object[] array = new object[0];
		array[0] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A70 RID: 72304 RVA: 0x00612C0D File Offset: 0x00610E0D
	internal void GHLEBDFCOHN(string EAFAMAMDNEG)
	{
		base.GetComponent<GameScene>().asampler.CNAJEIGEAAP();
		base.GetComponent<GameScene>().Start();
	}

	// Token: 0x06011A71 RID: 72305 RVA: 0x00612C2C File Offset: 0x00610E2C
	private IEnumerator FKPDNLKDLJD(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		base.StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && base.GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources(false);
		if (base.GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
		yield break;
	}

	// Token: 0x06011A72 RID: 72306 RVA: 0x00612C55 File Offset: 0x00610E55
	[PunRPC]
	internal void OnMastedChangeScene(string EAFAMAMDNEG)
	{
		base.GetComponent<GameScene>().asampler.Pause();
		base.GetComponent<GameScene>().Start();
	}

	// Token: 0x06011A73 RID: 72307 RVA: 0x00612C74 File Offset: 0x00610E74
	public virtual void DMLFOFLEGAH(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("DPADVER");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("/", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		base.StartCoroutine(this.BJINGKKGDEG());
	}

	// Token: 0x06011A74 RID: 72308 RVA: 0x00612CC8 File Offset: 0x00610EC8
	private IEnumerator LBAGEPFKJPG(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		base.StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && base.GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources(false);
		if (base.GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
		yield break;
	}

	// Token: 0x06011A75 RID: 72309 RVA: 0x00612CF4 File Offset: 0x00610EF4
	public IEnumerator GFKAGIONDEN()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A76 RID: 72310 RVA: 0x00612D10 File Offset: 0x00610F10
	public IEnumerator EOOPJCDJEBK()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A77 RID: 72311 RVA: 0x00612D2C File Offset: 0x00610F2C
	public IEnumerator BJINGKKGDEG()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A78 RID: 72312 RVA: 0x00612D47 File Offset: 0x00610F47
	public void KHNJLCEGBJM(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.GBHNDHLAJLI();
		string lblkdnnpaco = "#tryagain";
		PhotonTargets mpnmoonbmii = (PhotonTargets)7;
		object[] array = new object[1];
		array[1] = JKPJCEMPAGH;
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A79 RID: 72313 RVA: 0x00612D64 File Offset: 0x00610F64
	private IEnumerator IFNFHBEBDEP(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		base.StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && base.GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources(false);
		if (base.GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
		yield break;
	}

	// Token: 0x06011A7A RID: 72314 RVA: 0x00612D90 File Offset: 0x00610F90
	public IEnumerator LGFGOKCOEMG()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A7B RID: 72315 RVA: 0x00612DAC File Offset: 0x00610FAC
	public void NFKDBPGHHIJ()
	{
		this.place = 1;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.EICHFFCBJDG());
		}
		else
		{
			this.networkCanvas.SetActive(true);
		}
	}

	// Token: 0x06011A7C RID: 72316 RVA: 0x00612E10 File Offset: 0x00611010
	private IEnumerator CCILIOEMOJJ(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		base.StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && base.GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources(false);
		if (base.GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
		yield break;
	}

	// Token: 0x06011A7D RID: 72317 RVA: 0x00612E39 File Offset: 0x00611039
	public void CMGCIAFEECP(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		base.OELHGNKAMEG().MIAHMDGOOPJ("CurrentTimeLabel", PhotonTargets.Others, new object[]
		{
			string.Empty + BHNGOLDNELC,
			JKPJCEMPAGH
		});
	}

	// Token: 0x06011A7E RID: 72318 RVA: 0x00612E6C File Offset: 0x0061106C
	public void CAJFKNFJEKC()
	{
		this.place = 1;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.CPJHOJLHCCA());
		}
		else
		{
			this.networkCanvas.SetActive(true);
		}
	}

	// Token: 0x06011A7F RID: 72319 RVA: 0x00612ED0 File Offset: 0x006110D0
	public void CKJCPBPMBFF()
	{
		this.place = 1;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(false);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.CLIAFLHDPDE());
		}
		else
		{
			this.networkCanvas.SetActive(true);
		}
	}

	// Token: 0x06011A80 RID: 72320 RVA: 0x00612F34 File Offset: 0x00611134
	public void ANHHNJIGHPB(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.MFDGBMNGHAF((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011A81 RID: 72321 RVA: 0x00612F4C File Offset: 0x0061114C
	public void BGLPOGDAGPP(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.AAMNKPHHHCI();
		string lblkdnnpaco = ".sawoutdatedmessage";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[1];
		array[0] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A82 RID: 72322 RVA: 0x00612F7C File Offset: 0x0061117C
	public void KGFHANEECDF(string JKPJCEMPAGH)
	{
		base.JAEJDHHCJJO().GNFNHDCJOFC("GameScene", PhotonTargets.OthersBuffered, new object[]
		{
			JKPJCEMPAGH
		});
	}

	// Token: 0x06011A83 RID: 72323 RVA: 0x00612F99 File Offset: 0x00611199
	public void JELANDGCGPP()
	{
		if (!this.networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().OpenObjectAnimation();
		}
	}

	// Token: 0x06011A84 RID: 72324 RVA: 0x00612FC0 File Offset: 0x006111C0
	public IEnumerator UpdatePlayersList()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A85 RID: 72325 RVA: 0x00612FDC File Offset: 0x006111DC
	public IEnumerator DIIFECKELPF()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A86 RID: 72326 RVA: 0x00612FF8 File Offset: 0x006111F8
	public void MFMIODIAKNI()
	{
		if (this.BFLIELGAAIM != null && this.BFLIELGAAIM.isGameStarted && !this.BFLIELGAAIM.gameOver)
		{
			if (this.GPLLPIOEJBC > 524f)
			{
				this.GPLLPIOEJBC -= Time.deltaTime;
			}
			else
			{
				this.GPLLPIOEJBC = 1148f;
				this.OLBAIFGLAJM();
			}
		}
	}

	// Token: 0x06011A87 RID: 72327 RVA: 0x00613078 File Offset: 0x00611278
	internal void PBLKMJPIPDO(string EAFAMAMDNEG)
	{
		base.GetComponent<GameScene>().asampler.Pause();
		base.GetComponent<GameScene>().LFAFJKJAEEL();
	}

	// Token: 0x06011A88 RID: 72328 RVA: 0x00613098 File Offset: 0x00611298
	public IEnumerator HOOBKJANOLE()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A89 RID: 72329 RVA: 0x006130B4 File Offset: 0x006112B4
	public void Init()
	{
		this.place = 1;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.UpdatePlayersList());
		}
		else
		{
			this.networkCanvas.SetActive(false);
		}
	}

	// Token: 0x06011A8A RID: 72330 RVA: 0x00613118 File Offset: 0x00611318
	internal void FBMHLFBIFIE(string EAFAMAMDNEG)
	{
		base.GetComponent<GameScene>().asampler.CNAJEIGEAAP();
		base.GetComponent<GameScene>().FIKFJDFELIP();
	}

	// Token: 0x06011A8B RID: 72331 RVA: 0x00613135 File Offset: 0x00611335
	internal void BMHHLAHPGEH(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		base.GetComponent<GameScene>().OHOJFIKCLPI(ResourcesManager.IPFFGAILCED(new CSteamID(ulong.Parse(OBCEIJGMKGB)), false) + "Set Sun Input" + NOJGGCLPPAM, 1472f);
	}

	// Token: 0x06011A8C RID: 72332 RVA: 0x00613163 File Offset: 0x00611363
	public void FGJLLCBLKMG(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.JGPMLMPNLLK((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011A8D RID: 72333 RVA: 0x0060482A File Offset: 0x00602A2A
	public void LDKALPHMHAO(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011A8E RID: 72334 RVA: 0x0061317C File Offset: 0x0061137C
	public void MPOCCFKKMOE()
	{
		for (int i = 1; i < this.players.Count; i += 0)
		{
			IEnumerable<DynamicPlayerInfo> source = this.players;
			if (NetworkScene.LNIJKGECNME == null)
			{
				NetworkScene.LNIJKGECNME = new Func<DynamicPlayerInfo, int>(NetworkScene.ANHMEMNCMAD);
			}
			DynamicPlayerInfo dynamicPlayerInfo = source.OrderByDescending(NetworkScene.LNIJKGECNME).ToArray<DynamicPlayerInfo>()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				this.firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				this.place = i + 0;
			}
		}
	}

	// Token: 0x06011A8F RID: 72335 RVA: 0x00612B4D File Offset: 0x00610D4D
	[CompilerGenerated]
	private static int KKAIKIOFDMG(DynamicPlayerInfo HPHENPOHOMK)
	{
		return HPHENPOHOMK.currentScore;
	}

	// Token: 0x06011A90 RID: 72336 RVA: 0x00613207 File Offset: 0x00611407
	public void DKBIBKLDOKO(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.CDKCHEGOCJP("#no", HMGBJCGOLMI));
	}

	// Token: 0x06011A91 RID: 72337 RVA: 0x0061321C File Offset: 0x0061141C
	public IEnumerator CLIAFLHDPDE()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A92 RID: 72338 RVA: 0x00613237 File Offset: 0x00611437
	public void HLPBAPBIMHD(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.CDKCHEGOCJP("OpSetPropertiesOfRoom()", HMGBJCGOLMI));
	}

	// Token: 0x06011A93 RID: 72339 RVA: 0x0060361F File Offset: 0x0060181F
	public void LHCEJOEABNK(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.GHMOPFGCJAP(JKPJCEMPAGH);
	}

	// Token: 0x06011A94 RID: 72340 RVA: 0x0061324C File Offset: 0x0061144C
	public IEnumerator EICHFFCBJDG()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A95 RID: 72341 RVA: 0x00613267 File Offset: 0x00611467
	public void LBLIPPPDFOE(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.IFNFHBEBDEP("Result for ", HMGBJCGOLMI));
	}

	// Token: 0x06011A96 RID: 72342 RVA: 0x0061327C File Offset: 0x0061147C
	public void LNMIPMMFGLG(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.JAEJDHHCJJO();
		string lblkdnnpaco = "\n\n#";
		PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
		object[] array = new object[0];
		array[1] = JKPJCEMPAGH;
		photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A97 RID: 72343 RVA: 0x00612333 File Offset: 0x00610533
	public void ONFEIHPMDCG()
	{
		if (this.networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
	}

	// Token: 0x06011A98 RID: 72344 RVA: 0x00613299 File Offset: 0x00611499
	public void MFEKCNPNPGB()
	{
		if (!this.networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().ADFHHDAGGLD();
		}
	}

	// Token: 0x06011A9A RID: 72346 RVA: 0x006132E5 File Offset: 0x006114E5
	internal void NAMNFPMELMP(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		base.GetComponent<GameScene>().AddMessage(ResourcesManager.MFBHOGHAPHA(new CSteamID(ulong.Parse(OBCEIJGMKGB)), true) + "GlassesColor" + NOJGGCLPPAM, 1651f);
	}

	// Token: 0x06011A9B RID: 72347 RVA: 0x00613314 File Offset: 0x00611514
	public IEnumerator BBCFBHHJIAA()
	{
		this.players = new List<DynamicPlayerInfo>();
		gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		playerList = PhotonNetwork.playerList;
		for (j = 0; j < playerList.Length; j++)
		{
			photonPlayer = playerList[j];
			gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			num = 0UL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			sprite = null;
			csteamID = new CSteamID(num);
			if (num != 0UL)
			{
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID, false));
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID, false));
				if (ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if (gameObject2)
				{
					if (gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID, true);
					}
					if (gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if (gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						this.players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
		yield break;
	}

	// Token: 0x06011A9C RID: 72348 RVA: 0x0061332F File Offset: 0x0061152F
	public void HKJBLNCFICJ(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.FKPDNLKDLJD("Sprite", HMGBJCGOLMI));
	}

	// Token: 0x06011A9D RID: 72349 RVA: 0x00613344 File Offset: 0x00611544
	public void MDOOAKEFCBH(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = base.FFIPLLNKGEN();
		string lblkdnnpaco = "/Segment-[Up]";
		PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
		object[] array = new object[7];
		array[0] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011A9E RID: 72350 RVA: 0x00613374 File Offset: 0x00611574
	public void OEEJIBAHEJO(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.AAMLPNJMODK("_Value", HMGBJCGOLMI));
	}

	// Token: 0x06011A9F RID: 72351 RVA: 0x00613389 File Offset: 0x00611589
	public void HLOCDFDHFFJ(int HMGBJCGOLMI)
	{
		base.StartCoroutine(this.JBENCECOCCC("Tab1Content", HMGBJCGOLMI));
	}

	// Token: 0x06011AA0 RID: 72352 RVA: 0x0061339E File Offset: 0x0061159E
	internal void OECBJLHLFHK(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		base.GetComponent<GameScene>().PNEHHLMHJAA(ResourcesManager.JDFOIINPHIO(new CSteamID(ulong.Parse(OBCEIJGMKGB)), false) + "s" + NOJGGCLPPAM, 1736f);
	}

	// Token: 0x06011AA1 RID: 72353 RVA: 0x00613163 File Offset: 0x00611363
	public void KFHHNCLLKNP(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.JGPMLMPNLLK((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	// Token: 0x06011AA2 RID: 72354 RVA: 0x006133CC File Offset: 0x006115CC
	public void PFNFPINPCMH()
	{
		if (this.BFLIELGAAIM != null && this.BFLIELGAAIM.isGameStarted && !this.BFLIELGAAIM.gameOver)
		{
			if (this.GPLLPIOEJBC > 945f)
			{
				this.GPLLPIOEJBC -= Time.deltaTime;
			}
			else
			{
				this.GPLLPIOEJBC = 1347f;
				this.UpdateScoreboard();
			}
		}
	}

	// Token: 0x06011AA3 RID: 72355 RVA: 0x0061344C File Offset: 0x0061164C
	public void GMGGDHLFAHA(string JKPJCEMPAGH)
	{
		PhotonView photonView = base.EDIJKHEMPAD();
		string lblkdnnpaco = "inventory.selected.";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[0];
		array[1] = JKPJCEMPAGH;
		photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x06011AA4 RID: 72356 RVA: 0x0061346C File Offset: 0x0061166C
	public void EBJMGFNBFEB()
	{
		for (int i = 1; i < this.players.Count; i++)
		{
			IEnumerable<DynamicPlayerInfo> source = this.players;
			if (NetworkScene.LNIJKGECNME == null)
			{
				NetworkScene.LNIJKGECNME = new Func<DynamicPlayerInfo, int>(NetworkScene.KNNDEDLPKHI);
			}
			DynamicPlayerInfo dynamicPlayerInfo = source.OrderByDescending(NetworkScene.LNIJKGECNME).ToArray<DynamicPlayerInfo>()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				this.firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				this.place = i + 1;
			}
		}
	}

	// Token: 0x06011AA5 RID: 72357 RVA: 0x00603CB8 File Offset: 0x00601EB8
	public void HBBDMBICNIB(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}

	// Token: 0x06011AA6 RID: 72358 RVA: 0x00612B4D File Offset: 0x00610D4D
	private static int ANHMEMNCMAD(DynamicPlayerInfo HPHENPOHOMK)
	{
		return HPHENPOHOMK.currentScore;
	}

	// Token: 0x06011AA7 RID: 72359 RVA: 0x006134F8 File Offset: 0x006116F8
	public virtual void NCIAGGDENJE(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("[PlayerBase] Loaded music");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Visualize", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		base.StartCoroutine(this.HOOBKJANOLE());
	}

	// Token: 0x06011AA8 RID: 72360 RVA: 0x0061354C File Offset: 0x0061174C
	public void KNIOEDPEBDG()
	{
		for (int i = 1; i < this.players.Count; i++)
		{
			IEnumerable<DynamicPlayerInfo> source = this.players;
			if (NetworkScene.LNIJKGECNME == null)
			{
				NetworkScene.LNIJKGECNME = new Func<DynamicPlayerInfo, int>(NetworkScene.ANHMEMNCMAD);
			}
			DynamicPlayerInfo dynamicPlayerInfo = source.OrderByDescending(NetworkScene.LNIJKGECNME).ToArray<DynamicPlayerInfo>()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				this.firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				this.place = i + 1;
			}
		}
	}

	// Token: 0x06011AA9 RID: 72361 RVA: 0x006135D7 File Offset: 0x006117D7
	public void NBMHMINELOH()
	{
		if (this.networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
	}

	// Token: 0x06011AAA RID: 72362 RVA: 0x006135FE File Offset: 0x006117FE
	public void LBMHIDHMGIM()
	{
		if (!this.networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			this.networkChatCanvas.GetComponent<EasyTween>().CHOODMAKIKD();
		}
	}

	// Token: 0x06011AAB RID: 72363 RVA: 0x00613628 File Offset: 0x00611828
	public void JOACBIEHHCE()
	{
		if (this.BFLIELGAAIM != null && this.BFLIELGAAIM.isGameStarted && !this.BFLIELGAAIM.gameOver)
		{
			if (this.GPLLPIOEJBC > 489f)
			{
				this.GPLLPIOEJBC -= Time.deltaTime;
			}
			else
			{
				this.GPLLPIOEJBC = 685f;
				this.MPOCCFKKMOE();
			}
		}
	}

	// Token: 0x06011AAC RID: 72364 RVA: 0x006136A8 File Offset: 0x006118A8
	public void OCHADIJNDJK()
	{
		this.place = 0;
		this.BFLIELGAAIM = base.GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			this.networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			base.StartCoroutine(this.BBCFBHHJIAA());
		}
		else
		{
			this.networkCanvas.SetActive(false);
		}
	}

	// Token: 0x04001F29 RID: 7977
	public GameObject networkCanvas;

	// Token: 0x04001F2A RID: 7978
	public GameObject networkChatCanvas;

	// Token: 0x04001F2B RID: 7979
	public InputField chatHistoryInputField;

	// Token: 0x04001F2C RID: 7980
	public GameObject lobbyPlayerElement;

	// Token: 0x04001F2D RID: 7981
	public List<DynamicPlayerInfo> players = new List<DynamicPlayerInfo>();

	// Token: 0x04001F2E RID: 7982
	public DynamicPlayerInfo firstPlayer;

	// Token: 0x04001F2F RID: 7983
	public int place = 1;

	// Token: 0x04001F30 RID: 7984
	private GameScene BFLIELGAAIM;

	// Token: 0x04001F31 RID: 7985
	private float GPLLPIOEJBC = 1f;

	// Token: 0x04001F32 RID: 7986
	[CompilerGenerated]
	private static Func<DynamicPlayerInfo, int> LNIJKGECNME;
}
