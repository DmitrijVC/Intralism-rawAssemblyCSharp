using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200030D RID: 781
internal class PhotonHandler : MonoBehaviour
{
	// Token: 0x0600B224 RID: 45604 RVA: 0x00415FAC File Offset: 0x004141AC
	protected void DOFKFBFNNNO()
	{
		PhotonHandler.StopFallbackSendAckThread();
	}

	// Token: 0x0600B226 RID: 45606 RVA: 0x00415FB4 File Offset: 0x004141B4
	internal IEnumerator LFDJGLLPNKK(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat(new object[]
			{
				"Waiting for AvailableRegions. State: ",
				PhotonNetwork.connectionStateDetailed,
				" Server: ",
				PhotonNetwork.Server,
				" PhotonNetwork.networkingPeer.AvailableRegions ",
				PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null
			}));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		PhotonPingManager photonPingManager = new PhotonPingManager();
		foreach (Region lpcnahjgafk in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			PhotonHandler.SP.StartCoroutine(photonPingManager.PingSocket(lpcnahjgafk));
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		Region bestRegion = photonPingManager.BestRegion;
		PhotonHandler.IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat(new object[]
		{
			"Found best region: '",
			bestRegion.Code,
			"' ping: ",
			bestRegion.Ping,
			". Calling ConnectToRegionMaster() is: ",
			BHOGFDENPBF
		}));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
		yield break;
	}

	// Token: 0x0600B227 RID: 45607 RVA: 0x00415FCF File Offset: 0x004141CF
	protected internal static void COLNFLDEBEE()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.KJIBDOJLBEP(false));
	}

	// Token: 0x0600B228 RID: 45608 RVA: 0x00415FE8 File Offset: 0x004141E8
	public static bool KJKAKDJCNNJ()
	{
		if (PhotonHandler.JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonHandler.HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 713f && (float)PhotonHandler.HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 39f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				PhotonHandler.HBFJMIGFCNM.Stop();
				PhotonHandler.HBFJMIGFCNM.Reset();
				return PhotonHandler.JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 159)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return PhotonHandler.JJHGLCMPMJC;
	}

	// Token: 0x0600B229 RID: 45609 RVA: 0x004160A9 File Offset: 0x004142A9
	protected internal static void NFPDFKMMJNO()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.BKKCAGBPPMD(false));
	}

	// Token: 0x0600B22A RID: 45610 RVA: 0x004160C4 File Offset: 0x004142C4
	protected void FNMPIAMIKCP()
	{
		if (PhotonHandler.SP != null && PhotonHandler.SP != this && PhotonHandler.SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(PhotonHandler.SP.gameObject);
		}
		PhotonHandler.SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.updateInterval = -110 / PhotonNetwork.sendRate;
		this.updateIntervalOnSerialize = 145 / PhotonNetwork.sendRateOnSerialize;
		PhotonHandler.KLIPAPLOLEL();
	}

	// Token: 0x0600B22B RID: 45611 RVA: 0x00416150 File Offset: 0x00414350
	public static bool MLMCNBABJIC()
	{
		if (PhotonHandler.JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonHandler.HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 495f && (float)PhotonHandler.HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1001f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				PhotonHandler.HBFJMIGFCNM.Stop();
				PhotonHandler.HBFJMIGFCNM.Reset();
				return PhotonHandler.JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 58)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return PhotonHandler.JJHGLCMPMJC;
	}

	// Token: 0x0600B22C RID: 45612 RVA: 0x00416214 File Offset: 0x00414414
	protected void Update()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("NetworkPeer broke!");
			return;
		}
		if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == ClientState.Disconnected || PhotonNetwork.offlineMode)
		{
			return;
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			return;
		}
		bool flag = true;
		while (PhotonNetwork.isMessageQueueRunning && flag)
		{
			flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
		}
		int num = (int)(Time.realtimeSinceStartup * 1000f);
		if (PhotonNetwork.isMessageQueueRunning && num > this.NEHDOENHIBI)
		{
			PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
			this.NEHDOENHIBI = num + this.updateIntervalOnSerialize;
			this.JOMAHKKKGEN = 0;
		}
		num = (int)(Time.realtimeSinceStartup * 1000f);
		if (num > this.JOMAHKKKGEN)
		{
			bool flag2 = true;
			while (PhotonNetwork.isMessageQueueRunning && flag2)
			{
				flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
			}
			this.JOMAHKKKGEN = num + this.updateInterval;
		}
	}

	// Token: 0x0600B22D RID: 45613 RVA: 0x00416310 File Offset: 0x00414510
	protected void OEENOOGEEHD()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("ItemNameBGImage");
			return;
		}
		if (PhotonNetwork.connectionStateDetailed == ClientState.Uninitialized || PhotonNetwork.connectionStateDetailed == (ClientState)(-80) || PhotonNetwork.offlineMode)
		{
			return;
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			return;
		}
		bool flag = false;
		while (PhotonNetwork.isMessageQueueRunning && flag)
		{
			flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
		}
		int num = (int)(Time.realtimeSinceStartup * 144f);
		if (PhotonNetwork.isMessageQueueRunning && num > this.NEHDOENHIBI)
		{
			PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
			this.NEHDOENHIBI = num + this.updateIntervalOnSerialize;
			this.JOMAHKKKGEN = 1;
		}
		num = (int)(Time.realtimeSinceStartup * 178f);
		if (num > this.JOMAHKKKGEN)
		{
			bool flag2 = true;
			while (PhotonNetwork.isMessageQueueRunning && flag2)
			{
				flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
			}
			this.JOMAHKKKGEN = num + this.updateInterval;
		}
	}

	// Token: 0x0600B22E RID: 45614 RVA: 0x0041640C File Offset: 0x0041460C
	protected void DCDNKFPPNEE(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 747f)
		{
			if (PhotonHandler.HBFJMIGFCNM == null)
			{
				PhotonHandler.HBFJMIGFCNM = new Stopwatch();
			}
			PhotonHandler.HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				PhotonHandler.HBFJMIGFCNM.Start();
			}
			else
			{
				PhotonHandler.HBFJMIGFCNM.Stop();
			}
		}
	}

	// Token: 0x0600B22F RID: 45615 RVA: 0x00416465 File Offset: 0x00414665
	protected void IPNKLPNCPNF()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JPBKKEJHKOH());
	}

	// Token: 0x0600B230 RID: 45616 RVA: 0x00416476 File Offset: 0x00414676
	protected void JECJHPCBIJG()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.BJDPEFJHJHE());
	}

	// Token: 0x0600B231 RID: 45617 RVA: 0x00416487 File Offset: 0x00414687
	public static void HIGFHHADAKA()
	{
		PhotonHandler.JJHGLCMPMJC = false;
	}

	// Token: 0x0600B232 RID: 45618 RVA: 0x0041648F File Offset: 0x0041468F
	protected void DBELKDBDEEA()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.APMBINPHLKM());
	}

	// Token: 0x0600B233 RID: 45619 RVA: 0x004164A0 File Offset: 0x004146A0
	protected void NKECEAOOHOO()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	// Token: 0x0600B234 RID: 45620 RVA: 0x004160A9 File Offset: 0x004142A9
	protected internal static void HHFBHNGHJFO()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.BKKCAGBPPMD(false));
	}

	// Token: 0x0600B235 RID: 45621 RVA: 0x004164AC File Offset: 0x004146AC
	protected void AGDKPNKOIHM()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.IDMHHNAOCPN());
	}

	// Token: 0x0600B237 RID: 45623 RVA: 0x004164BD File Offset: 0x004146BD
	protected internal static void OHHODFOKKFN()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.LFDJGLLPNKK(false));
	}

	// Token: 0x0600B238 RID: 45624 RVA: 0x004164A0 File Offset: 0x004146A0
	protected void FELKGPDBFFJ()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	// Token: 0x0600B239 RID: 45625 RVA: 0x004164D5 File Offset: 0x004146D5
	internal static void NFCANDIBPLB(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.asia)
		{
			PlayerPrefs.DeleteKey("player.goldcrystal");
		}
		else
		{
			PlayerPrefs.SetString("_Distortion", DPNHODJHGJL.ToString());
		}
	}

	// Token: 0x0600B23A RID: 45626 RVA: 0x00416504 File Offset: 0x00414704
	public static void OHHNDPPMELE()
	{
		if (PhotonHandler.JJHGLCMPMJC)
		{
			return;
		}
		PhotonHandler.JJHGLCMPMJC = true;
		if (PhotonHandler.BOGJGOAMCHK == null)
		{
			PhotonHandler.BOGJGOAMCHK = new Func<bool>(PhotonHandler.MLMCNBABJIC);
		}
		SupportClass.StartBackgroundCalls(PhotonHandler.BOGJGOAMCHK, 50, string.Empty);
	}

	// Token: 0x0600B23B RID: 45627 RVA: 0x00416541 File Offset: 0x00414741
	protected internal static void POHJEJCJKPN()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.LONCMFKCCJD(true));
	}

	// Token: 0x0600B23C RID: 45628 RVA: 0x00416559 File Offset: 0x00414759
	public static void BPCIBJOACDN()
	{
		if (PhotonHandler.JJHGLCMPMJC)
		{
			return;
		}
		PhotonHandler.JJHGLCMPMJC = false;
		if (PhotonHandler.BOGJGOAMCHK == null)
		{
			PhotonHandler.BOGJGOAMCHK = new Func<bool>(PhotonHandler.KKCHAEIMHME);
		}
		SupportClass.StartBackgroundCalls(PhotonHandler.BOGJGOAMCHK, 70, string.Empty);
	}

	// Token: 0x0600B23D RID: 45629 RVA: 0x00416598 File Offset: 0x00414798
	internal static CloudRegionCode LLEFOLMENEI()
	{
		string @string = PlayerPrefs.GetString("CameraFilterPack/Oculus_NightVision3", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.GBBOFINMPDE(@string);
		}
		return CloudRegionCode.eu;
	}

	// Token: 0x0600B23E RID: 45630 RVA: 0x00416465 File Offset: 0x00414665
	protected void LOCGGCPJLKB()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JPBKKEJHKOH());
	}

	// Token: 0x0600B23F RID: 45631 RVA: 0x004165CC File Offset: 0x004147CC
	protected void EMDBAEDDHNJ(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 1598f)
		{
			if (PhotonHandler.HBFJMIGFCNM == null)
			{
				PhotonHandler.HBFJMIGFCNM = new Stopwatch();
			}
			PhotonHandler.HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				PhotonHandler.HBFJMIGFCNM.Start();
			}
			else
			{
				PhotonHandler.HBFJMIGFCNM.Stop();
			}
		}
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x0600B260 RID: 45664 RVA: 0x00416C40 File Offset: 0x00414E40
	// (set) Token: 0x0600B240 RID: 45632 RVA: 0x00416625 File Offset: 0x00414825
	internal static CloudRegionCode IFAEAEOAJDL
	{
		get
		{
			string @string = PlayerPrefs.GetString("PUNCloudBestRegion", string.Empty);
			if (!string.IsNullOrEmpty(@string))
			{
				return Region.Parse(@string);
			}
			return CloudRegionCode.none;
		}
		set
		{
			if (value == CloudRegionCode.none)
			{
				PlayerPrefs.DeleteKey("PUNCloudBestRegion");
			}
			else
			{
				PlayerPrefs.SetString("PUNCloudBestRegion", value.ToString());
			}
		}
	}

	// Token: 0x0600B241 RID: 45633 RVA: 0x00416654 File Offset: 0x00414854
	public static void OLJENCPABEE()
	{
		if (PhotonHandler.JJHGLCMPMJC)
		{
			return;
		}
		PhotonHandler.JJHGLCMPMJC = true;
		if (PhotonHandler.BOGJGOAMCHK == null)
		{
			PhotonHandler.BOGJGOAMCHK = new Func<bool>(PhotonHandler.IIAJBKHLOPB);
		}
		SupportClass.StartBackgroundCalls(PhotonHandler.BOGJGOAMCHK, 4, string.Empty);
	}

	// Token: 0x0600B242 RID: 45634 RVA: 0x00416691 File Offset: 0x00414891
	protected void OnApplicationQuit()
	{
		PhotonHandler.MBIFDLCKGKN = true;
		PhotonHandler.StopFallbackSendAckThread();
		PhotonNetwork.Disconnect();
	}

	// Token: 0x0600B243 RID: 45635 RVA: 0x004166A3 File Offset: 0x004148A3
	public static void LAMCBJCKFKL()
	{
		if (PhotonHandler.JJHGLCMPMJC)
		{
			return;
		}
		PhotonHandler.JJHGLCMPMJC = false;
		if (PhotonHandler.BOGJGOAMCHK == null)
		{
			PhotonHandler.BOGJGOAMCHK = new Func<bool>(PhotonHandler.KJKAKDJCNNJ);
		}
		SupportClass.StartBackgroundCalls(PhotonHandler.BOGJGOAMCHK, -17, string.Empty);
	}

	// Token: 0x0600B244 RID: 45636 RVA: 0x004166E0 File Offset: 0x004148E0
	protected void KFACDBHDAOD()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("_ScreenResolution");
			return;
		}
		if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == (ClientState)67 || PhotonNetwork.offlineMode)
		{
			return;
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			return;
		}
		bool flag = false;
		while (PhotonNetwork.isMessageQueueRunning && flag)
		{
			flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
		}
		int num = (int)(Time.realtimeSinceStartup * 723f);
		if (PhotonNetwork.isMessageQueueRunning && num > this.NEHDOENHIBI)
		{
			PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
			this.NEHDOENHIBI = num + this.updateIntervalOnSerialize;
			this.JOMAHKKKGEN = 0;
		}
		num = (int)(Time.realtimeSinceStartup * 1138f);
		if (num > this.JOMAHKKKGEN)
		{
			bool flag2 = false;
			while (PhotonNetwork.isMessageQueueRunning && flag2)
			{
				flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
			}
			this.JOMAHKKKGEN = num + this.updateInterval;
		}
	}

	// Token: 0x0600B245 RID: 45637 RVA: 0x004167DC File Offset: 0x004149DC
	internal IEnumerator KJIBDOJLBEP(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat(new object[]
			{
				"Waiting for AvailableRegions. State: ",
				PhotonNetwork.connectionStateDetailed,
				" Server: ",
				PhotonNetwork.Server,
				" PhotonNetwork.networkingPeer.AvailableRegions ",
				PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null
			}));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		photonPingManager = new PhotonPingManager();
		enumerator = PhotonNetwork.JNJJAMNLOHA.AvailableRegions.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Region lpcnahjgafk = enumerator.Current;
				PhotonHandler.SP.StartCoroutine(photonPingManager.PingSocket(lpcnahjgafk));
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		bestRegion = photonPingManager.BestRegion;
		PhotonHandler.IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat(new object[]
		{
			"Found best region: '",
			bestRegion.Code,
			"' ping: ",
			bestRegion.Ping,
			". Calling ConnectToRegionMaster() is: ",
			BHOGFDENPBF
		}));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
		yield break;
	}

	// Token: 0x0600B246 RID: 45638 RVA: 0x004167F7 File Offset: 0x004149F7
	protected void KHDPHGCGNHH()
	{
		PhotonHandler.HIGFHHADAKA();
	}

	// Token: 0x0600B247 RID: 45639 RVA: 0x004167FE File Offset: 0x004149FE
	public static void BPHLJAOPPMH()
	{
		if (PhotonHandler.JJHGLCMPMJC)
		{
			return;
		}
		PhotonHandler.JJHGLCMPMJC = false;
		if (PhotonHandler.BOGJGOAMCHK == null)
		{
			PhotonHandler.BOGJGOAMCHK = new Func<bool>(PhotonHandler.BJDEPNPMBGA);
		}
		SupportClass.StartBackgroundCalls(PhotonHandler.BOGJGOAMCHK, -11, string.Empty);
	}

	// Token: 0x0600B248 RID: 45640 RVA: 0x00416487 File Offset: 0x00414687
	public static void NMCMGIBJMIF()
	{
		PhotonHandler.JJHGLCMPMJC = false;
	}

	// Token: 0x0600B249 RID: 45641 RVA: 0x0041683B File Offset: 0x00414A3B
	protected void FJOBFBDPBOJ(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.DPPJGJCEGPB());
	}

	// Token: 0x0600B24A RID: 45642 RVA: 0x00416856 File Offset: 0x00414A56
	protected void PEJANHIKFAE()
	{
		PhotonHandler.NMCMGIBJMIF();
	}

	// Token: 0x0600B24B RID: 45643 RVA: 0x00416860 File Offset: 0x00414A60
	internal IEnumerator BKKCAGBPPMD(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat(new object[]
			{
				"Waiting for AvailableRegions. State: ",
				PhotonNetwork.connectionStateDetailed,
				" Server: ",
				PhotonNetwork.Server,
				" PhotonNetwork.networkingPeer.AvailableRegions ",
				PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null
			}));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		photonPingManager = new PhotonPingManager();
		enumerator = PhotonNetwork.JNJJAMNLOHA.AvailableRegions.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Region lpcnahjgafk = enumerator.Current;
				PhotonHandler.SP.StartCoroutine(photonPingManager.PingSocket(lpcnahjgafk));
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		bestRegion = photonPingManager.BestRegion;
		PhotonHandler.IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat(new object[]
		{
			"Found best region: '",
			bestRegion.Code,
			"' ping: ",
			bestRegion.Ping,
			". Calling ConnectToRegionMaster() is: ",
			BHOGFDENPBF
		}));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
		yield break;
	}

	// Token: 0x0600B24C RID: 45644 RVA: 0x00416856 File Offset: 0x00414A56
	protected void OJIHBHNJFBB()
	{
		PhotonHandler.NMCMGIBJMIF();
	}

	// Token: 0x0600B24D RID: 45645 RVA: 0x0041687C File Offset: 0x00414A7C
	internal IEnumerator LONCMFKCCJD(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat(new object[]
			{
				"Waiting for AvailableRegions. State: ",
				PhotonNetwork.connectionStateDetailed,
				" Server: ",
				PhotonNetwork.Server,
				" PhotonNetwork.networkingPeer.AvailableRegions ",
				PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null
			}));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		photonPingManager = new PhotonPingManager();
		enumerator = PhotonNetwork.JNJJAMNLOHA.AvailableRegions.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Region lpcnahjgafk = enumerator.Current;
				PhotonHandler.SP.StartCoroutine(photonPingManager.PingSocket(lpcnahjgafk));
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		bestRegion = photonPingManager.BestRegion;
		PhotonHandler.IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat(new object[]
		{
			"Found best region: '",
			bestRegion.Code,
			"' ping: ",
			bestRegion.Ping,
			". Calling ConnectToRegionMaster() is: ",
			BHOGFDENPBF
		}));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
		yield break;
	}

	// Token: 0x0600B24E RID: 45646 RVA: 0x00416898 File Offset: 0x00414A98
	public static bool KKCHAEIMHME()
	{
		if (PhotonHandler.JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonHandler.HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1296f && (float)PhotonHandler.HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1363f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				PhotonHandler.HBFJMIGFCNM.Stop();
				PhotonHandler.HBFJMIGFCNM.Reset();
				return PhotonHandler.JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 184)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return PhotonHandler.JJHGLCMPMJC;
	}

	// Token: 0x0600B24F RID: 45647 RVA: 0x0041695C File Offset: 0x00414B5C
	protected void HICONNMPLEF(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 985f)
		{
			if (PhotonHandler.HBFJMIGFCNM == null)
			{
				PhotonHandler.HBFJMIGFCNM = new Stopwatch();
			}
			PhotonHandler.HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				PhotonHandler.HBFJMIGFCNM.Start();
			}
			else
			{
				PhotonHandler.HBFJMIGFCNM.Stop();
			}
		}
	}

	// Token: 0x0600B250 RID: 45648 RVA: 0x00416691 File Offset: 0x00414891
	protected void PDNMKEKIGJH()
	{
		PhotonHandler.MBIFDLCKGKN = true;
		PhotonHandler.StopFallbackSendAckThread();
		PhotonNetwork.Disconnect();
	}

	// Token: 0x0600B251 RID: 45649 RVA: 0x004169B8 File Offset: 0x00414BB8
	protected void OMCLOFCJMPG()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("_Value6");
			return;
		}
		if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == (ClientState)119 || PhotonNetwork.offlineMode)
		{
			return;
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			return;
		}
		bool flag = false;
		while (PhotonNetwork.isMessageQueueRunning && flag)
		{
			flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
		}
		int num = (int)(Time.realtimeSinceStartup * 784f);
		if (PhotonNetwork.isMessageQueueRunning && num > this.NEHDOENHIBI)
		{
			PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
			this.NEHDOENHIBI = num + this.updateIntervalOnSerialize;
			this.JOMAHKKKGEN = 0;
		}
		num = (int)(Time.realtimeSinceStartup * 1494f);
		if (num > this.JOMAHKKKGEN)
		{
			bool flag2 = true;
			while (PhotonNetwork.isMessageQueueRunning && flag2)
			{
				flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
			}
			this.JOMAHKKKGEN = num + this.updateInterval;
		}
	}

	// Token: 0x0600B252 RID: 45650 RVA: 0x00416856 File Offset: 0x00414A56
	protected void LCKEHMMIFEI()
	{
		PhotonHandler.NMCMGIBJMIF();
	}

	// Token: 0x0600B253 RID: 45651 RVA: 0x004164A0 File Offset: 0x004146A0
	protected void CJJAMKNIOOF()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	// Token: 0x0600B254 RID: 45652 RVA: 0x00416AB4 File Offset: 0x00414CB4
	protected void OnCreatedRoom()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.ActiveSceneName);
	}

	// Token: 0x0600B255 RID: 45653 RVA: 0x00416AC5 File Offset: 0x00414CC5
	protected internal static void LLHBAPCKHAB()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.BKKCAGBPPMD(true));
	}

	// Token: 0x0600B256 RID: 45654 RVA: 0x00416ADD File Offset: 0x00414CDD
	protected void BLPDHKHLLHP()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.NJMKLDDMKPF());
	}

	// Token: 0x0600B257 RID: 45655 RVA: 0x00416AC5 File Offset: 0x00414CC5
	protected internal static void JHNCFDJMKAL()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.BKKCAGBPPMD(true));
	}

	// Token: 0x0600B258 RID: 45656 RVA: 0x00416AEE File Offset: 0x00414CEE
	internal static void LEFACILBIGM(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.asia)
		{
			PlayerPrefs.DeleteKey("EventSystem");
		}
		else
		{
			PlayerPrefs.SetString("IDInputField", DPNHODJHGJL.ToString());
		}
	}

	// Token: 0x0600B259 RID: 45657 RVA: 0x00416B1D File Offset: 0x00414D1D
	protected void MAHCPFOCOHK()
	{
		PhotonHandler.MBIFDLCKGKN = true;
		PhotonHandler.NMCMGIBJMIF();
		PhotonNetwork.Disconnect();
	}

	// Token: 0x0600B25A RID: 45658 RVA: 0x00416B2F File Offset: 0x00414D2F
	public static void StartFallbackSendAckThread()
	{
		if (PhotonHandler.JJHGLCMPMJC)
		{
			return;
		}
		PhotonHandler.JJHGLCMPMJC = true;
		if (PhotonHandler.BOGJGOAMCHK == null)
		{
			PhotonHandler.BOGJGOAMCHK = new Func<bool>(PhotonHandler.FallbackSendAckThread);
		}
		SupportClass.StartBackgroundCalls(PhotonHandler.BOGJGOAMCHK, 100, string.Empty);
	}

	// Token: 0x0600B25B RID: 45659 RVA: 0x00416B6C File Offset: 0x00414D6C
	internal static void GGLNANJIJLG(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.usw)
		{
			PlayerPrefs.DeleteKey("health");
		}
		else
		{
			PlayerPrefs.SetString("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", DPNHODJHGJL.ToString());
		}
	}

	// Token: 0x0600B25C RID: 45660 RVA: 0x00416B9C File Offset: 0x00414D9C
	protected void BMAGFLLGDPJ()
	{
		if (PhotonHandler.SP != null && PhotonHandler.SP != this && PhotonHandler.SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(PhotonHandler.SP.gameObject);
		}
		PhotonHandler.SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.updateInterval = 65 / PhotonNetwork.sendRate;
		this.updateIntervalOnSerialize = -20 / PhotonNetwork.sendRateOnSerialize;
		PhotonHandler.OHHNDPPMELE();
	}

	// Token: 0x0600B25D RID: 45661 RVA: 0x00416487 File Offset: 0x00414687
	public static void StopFallbackSendAckThread()
	{
		PhotonHandler.JJHGLCMPMJC = false;
	}

	// Token: 0x0600B25E RID: 45662 RVA: 0x00416856 File Offset: 0x00414A56
	protected void AAPKEGAJABJ()
	{
		PhotonHandler.NMCMGIBJMIF();
	}

	// Token: 0x0600B25F RID: 45663 RVA: 0x00416C25 File Offset: 0x00414E25
	protected void OnLevelWasLoaded(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.ActiveSceneName);
	}

	// Token: 0x0600B261 RID: 45665 RVA: 0x00416C72 File Offset: 0x00414E72
	protected void EJDALFDJOBD(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.GNBCDNDELNM());
	}

	// Token: 0x0600B262 RID: 45666 RVA: 0x00416C8D File Offset: 0x00414E8D
	public static void FOKEFGDCAGK()
	{
		PhotonHandler.JJHGLCMPMJC = true;
	}

	// Token: 0x0600B263 RID: 45667 RVA: 0x00416C98 File Offset: 0x00414E98
	public static bool BJDEPNPMBGA()
	{
		if (PhotonHandler.JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonHandler.HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1826f && (float)PhotonHandler.HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1910f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				PhotonHandler.HBFJMIGFCNM.Stop();
				PhotonHandler.HBFJMIGFCNM.Reset();
				return PhotonHandler.JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 63)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return PhotonHandler.JJHGLCMPMJC;
	}

	// Token: 0x0600B264 RID: 45668 RVA: 0x00416D5C File Offset: 0x00414F5C
	public static bool NEFBGPHPHFK()
	{
		if (PhotonHandler.JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonHandler.HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1097f && (float)PhotonHandler.HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1954f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				PhotonHandler.HBFJMIGFCNM.Stop();
				PhotonHandler.HBFJMIGFCNM.Reset();
				return PhotonHandler.JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -164)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return PhotonHandler.JJHGLCMPMJC;
	}

	// Token: 0x0600B265 RID: 45669 RVA: 0x004164A0 File Offset: 0x004146A0
	protected void CDDBANKMALP()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	// Token: 0x0600B266 RID: 45670 RVA: 0x004164BD File Offset: 0x004146BD
	protected internal static void ILEFPKJIONO()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.LFDJGLLPNKK(false));
	}

	// Token: 0x0600B267 RID: 45671 RVA: 0x00416E20 File Offset: 0x00415020
	public static bool FallbackSendAckThread()
	{
		if (PhotonHandler.JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonHandler.HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 0.1f && (float)PhotonHandler.HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1000f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				PhotonHandler.HBFJMIGFCNM.Stop();
				PhotonHandler.HBFJMIGFCNM.Reset();
				return PhotonHandler.JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 200)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return PhotonHandler.JJHGLCMPMJC;
	}

	// Token: 0x0600B268 RID: 45672 RVA: 0x00416EE1 File Offset: 0x004150E1
	public static void KLIPAPLOLEL()
	{
		if (PhotonHandler.JJHGLCMPMJC)
		{
			return;
		}
		PhotonHandler.JJHGLCMPMJC = false;
		if (PhotonHandler.BOGJGOAMCHK == null)
		{
			PhotonHandler.BOGJGOAMCHK = new Func<bool>(PhotonHandler.BJDEPNPMBGA);
		}
		SupportClass.StartBackgroundCalls(PhotonHandler.BOGJGOAMCHK, 67, string.Empty);
	}

	// Token: 0x0600B269 RID: 45673 RVA: 0x00416F1E File Offset: 0x0041511E
	protected void CPIGOIKNCHP()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.BKLGNANAKGM());
	}

	// Token: 0x0600B26A RID: 45674 RVA: 0x00415FAC File Offset: 0x004141AC
	protected void PINGNFLJAGB()
	{
		PhotonHandler.StopFallbackSendAckThread();
	}

	// Token: 0x0600B26B RID: 45675 RVA: 0x00416F30 File Offset: 0x00415130
	protected void KIEJKBNBHMD()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("/");
			return;
		}
		if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == (ClientState)(-111) || PhotonNetwork.offlineMode)
		{
			return;
		}
		if (!PhotonNetwork.isMessageQueueRunning)
		{
			return;
		}
		bool flag = true;
		while (PhotonNetwork.isMessageQueueRunning && flag)
		{
			flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
		}
		int num = (int)(Time.realtimeSinceStartup * 1162f);
		if (PhotonNetwork.isMessageQueueRunning && num > this.NEHDOENHIBI)
		{
			PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
			this.NEHDOENHIBI = num + this.updateIntervalOnSerialize;
			this.JOMAHKKKGEN = 0;
		}
		num = (int)(Time.realtimeSinceStartup * 170f);
		if (num > this.JOMAHKKKGEN)
		{
			bool flag2 = false;
			while (PhotonNetwork.isMessageQueueRunning && flag2)
			{
				flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
			}
			this.JOMAHKKKGEN = num + this.updateInterval;
		}
	}

	// Token: 0x0600B26C RID: 45676 RVA: 0x00415FAC File Offset: 0x004141AC
	protected void OnDestroy()
	{
		PhotonHandler.StopFallbackSendAckThread();
	}

	// Token: 0x0600B26D RID: 45677 RVA: 0x0041702C File Offset: 0x0041522C
	protected void MFKCAFGHNNB()
	{
		PhotonHandler.MBIFDLCKGKN = false;
		PhotonHandler.FOKEFGDCAGK();
		PhotonNetwork.Disconnect();
	}

	// Token: 0x0600B26E RID: 45678 RVA: 0x0041703E File Offset: 0x0041523E
	protected void DPLFKFANBCL()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.FPKODNFGBOP());
	}

	// Token: 0x0600B26F RID: 45679 RVA: 0x004164A0 File Offset: 0x004146A0
	protected void OnJoinedRoom()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	// Token: 0x0600B270 RID: 45680 RVA: 0x00417050 File Offset: 0x00415250
	public static bool IIAJBKHLOPB()
	{
		if (PhotonHandler.JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (PhotonHandler.HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 981f && (float)PhotonHandler.HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1206f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				PhotonHandler.HBFJMIGFCNM.Stop();
				PhotonHandler.HBFJMIGFCNM.Reset();
				return PhotonHandler.JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -159)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return PhotonHandler.JJHGLCMPMJC;
	}

	// Token: 0x0600B271 RID: 45681 RVA: 0x00417111 File Offset: 0x00415311
	protected internal static void CEHKCEGFCOI()
	{
		PhotonHandler.SP.StartCoroutine(PhotonHandler.SP.LFDJGLLPNKK(true));
	}

	// Token: 0x0600B272 RID: 45682 RVA: 0x00417129 File Offset: 0x00415329
	protected void EFHACOBMCKB(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.HCBFOHMAICA();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.COFIPBCBADB());
	}

	// Token: 0x0600B273 RID: 45683 RVA: 0x00417144 File Offset: 0x00415344
	protected void Awake()
	{
		if (PhotonHandler.SP != null && PhotonHandler.SP != this && PhotonHandler.SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(PhotonHandler.SP.gameObject);
		}
		PhotonHandler.SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.updateInterval = 1000 / PhotonNetwork.sendRate;
		this.updateIntervalOnSerialize = 1000 / PhotonNetwork.sendRateOnSerialize;
		PhotonHandler.StartFallbackSendAckThread();
	}

	// Token: 0x0600B274 RID: 45684 RVA: 0x004171CD File Offset: 0x004153CD
	internal static void MEBNOLCEOFA(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.asia)
		{
			PlayerPrefs.DeleteKey("OnPressRight");
		}
		else
		{
			PlayerPrefs.SetString("settings.shaders.bloomintencity", DPNHODJHGJL.ToString());
		}
	}

	// Token: 0x0600B275 RID: 45685 RVA: 0x004164A0 File Offset: 0x004146A0
	protected void BDKAKHFLAKD()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	// Token: 0x0600B276 RID: 45686 RVA: 0x004171FC File Offset: 0x004153FC
	protected void OnApplicationPause(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 0.1f)
		{
			if (PhotonHandler.HBFJMIGFCNM == null)
			{
				PhotonHandler.HBFJMIGFCNM = new Stopwatch();
			}
			PhotonHandler.HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				PhotonHandler.HBFJMIGFCNM.Start();
			}
			else
			{
				PhotonHandler.HBFJMIGFCNM.Stop();
			}
		}
	}

	// Token: 0x0600B277 RID: 45687 RVA: 0x00417258 File Offset: 0x00415458
	internal IEnumerator DBPIEBHGIEI(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat(new object[]
			{
				"Waiting for AvailableRegions. State: ",
				PhotonNetwork.connectionStateDetailed,
				" Server: ",
				PhotonNetwork.Server,
				" PhotonNetwork.networkingPeer.AvailableRegions ",
				PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null
			}));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		photonPingManager = new PhotonPingManager();
		enumerator = PhotonNetwork.JNJJAMNLOHA.AvailableRegions.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Region lpcnahjgafk = enumerator.Current;
				PhotonHandler.SP.StartCoroutine(photonPingManager.PingSocket(lpcnahjgafk));
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		bestRegion = photonPingManager.BestRegion;
		PhotonHandler.IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat(new object[]
		{
			"Found best region: '",
			bestRegion.Code,
			"' ping: ",
			bestRegion.Ping,
			". Calling ConnectToRegionMaster() is: ",
			BHOGFDENPBF
		}));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
		yield break;
	}

	// Token: 0x0600B278 RID: 45688 RVA: 0x004164A0 File Offset: 0x004146A0
	protected void LIHPNLAJNHE()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	// Token: 0x040014E7 RID: 5351
	public static PhotonHandler SP;

	// Token: 0x040014E8 RID: 5352
	public int updateInterval;

	// Token: 0x040014E9 RID: 5353
	public int updateIntervalOnSerialize;

	// Token: 0x040014EA RID: 5354
	private int JOMAHKKKGEN;

	// Token: 0x040014EB RID: 5355
	private int NEHDOENHIBI;

	// Token: 0x040014EC RID: 5356
	private static bool JJHGLCMPMJC;

	// Token: 0x040014ED RID: 5357
	private static Stopwatch HBFJMIGFCNM;

	// Token: 0x040014EE RID: 5358
	protected internal static bool MBIFDLCKGKN;

	// Token: 0x040014EF RID: 5359
	protected internal static Type LEILCLLNGGH;

	// Token: 0x040014F0 RID: 5360
	private const string KKKBKNKGIPA = "PUNCloudBestRegion";

	// Token: 0x040014F1 RID: 5361
	[CompilerGenerated]
	private static Func<bool> BOGJGOAMCHK;
}
