using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200014B RID: 331
public class DiscordController : MonoBehaviour
{
	// Token: 0x060065BE RID: 26046 RVA: 0x001EC077 File Offset: 0x001EA277
	public void NCEMLKAGNII()
	{
		Debug.Log("GlassesColor2");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.Yes);
		this.hasResponded.Invoke();
	}

	// Token: 0x060065BF RID: 26047 RVA: 0x001EC0A0 File Offset: 0x001EA2A0
	public void UpdatePresence(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "icon_border";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.GetLoadedSteamPlayername(steamID, true);
			this.presence.smallImageKey = "white";
			if (loadedRank.place <= 10)
			{
				this.presence.smallImageKey = "gold";
			}
			else if (loadedRank.place <= 25)
			{
				this.presence.smallImageKey = "violet";
			}
			else if (loadedRank.place <= 100)
			{
				this.presence.smallImageKey = "red";
			}
			else if (loadedRank.place <= 500)
			{
				this.presence.smallImageKey = "blue";
			}
		}
		DiscordRpc.UpdatePresence(this.presence);
	}

	// Token: 0x060065C0 RID: 26048 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void LLDHEJIEDHO()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x060065C1 RID: 26049 RVA: 0x001EC1B4 File Offset: 0x001EA3B4
	public void AFPEOLCODFK(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("#exit", MJDPJLOCLIL));
		this.onJoin.Invoke(MJDPJLOCLIL);
		string kginemahhfo = GameManager.PJHEGJPGKPP(MJDPJLOCLIL);
		base.StartCoroutine(this.OJHJHNHGEEI(kginemahhfo));
	}

	// Token: 0x060065C2 RID: 26050 RVA: 0x001EC1F2 File Offset: 0x001EA3F2
	public void KGBCMAKLBGA(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Mar", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x060065C3 RID: 26051 RVA: 0x001EC210 File Offset: 0x001EA410
	public void JoinCallback(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("[DiscordController] Join ({0})", MJDPJLOCLIL));
		this.onJoin.Invoke(MJDPJLOCLIL);
		string kginemahhfo = GameManager.Decrypt(MJDPJLOCLIL);
		base.StartCoroutine(this.KJLFOJHECGL(kginemahhfo));
	}

	// Token: 0x060065C4 RID: 26052 RVA: 0x001EC250 File Offset: 0x001EA450
	public void JAPNGOOCLMF(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = ":\n";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.OHKHAFCNHEI(steamID, true);
			this.presence.smallImageKey = "_Parameter";
			if (loadedRank.place <= 97)
			{
				this.presence.smallImageKey = "_Saturation";
			}
			else if (loadedRank.place <= 53)
			{
				this.presence.smallImageKey = "win";
			}
			else if (loadedRank.INIGKHLOKCD() <= 67)
			{
				this.presence.smallImageKey = "_ScreenResolution";
			}
			else if (loadedRank.place <= -61)
			{
				this.presence.smallImageKey = "ItemsCountText";
			}
		}
		DiscordRpc.NCAIFFNMMMP(this.presence);
	}

	// Token: 0x060065C5 RID: 26053 RVA: 0x001EC35C File Offset: 0x001EA55C
	private void ODGMCJILIHF()
	{
		if (this.inited)
		{
			Debug.Log(". The group number should be at least 1.");
			DiscordRpc.Shutdown();
		}
	}

	// Token: 0x060065C6 RID: 26054 RVA: 0x001EC378 File Offset: 0x001EA578
	private void CJHMHIMKILB()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x060065C7 RID: 26055 RVA: 0x001EC3B3 File Offset: 0x001EA5B3
	public void EEFCBACIHAH()
	{
		Debug.Log("[PowerUp]");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.Yes);
		this.hasResponded.Invoke();
	}

	// Token: 0x060065C8 RID: 26056 RVA: 0x001EC3DB File Offset: 0x001EA5DB
	public void JDACNGIILEE(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format("id", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		this.onConnect.Invoke();
		this.inited = false;
	}

	// Token: 0x060065C9 RID: 26057 RVA: 0x001EC410 File Offset: 0x001EA610
	public void BBMDALMFCHK(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[LevelEditorScene] Error: You're not logged into Steam!", PNCJHNNOAAP, JKPJCEMPAGH));
		this.onDisconnect.Invoke();
	}

	// Token: 0x060065CA RID: 26058 RVA: 0x001EC433 File Offset: 0x001EA633
	public void COKMNBGJONL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("Exit to Windows", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x060065CB RID: 26059 RVA: 0x001EC44B File Offset: 0x001EA64B
	public static DiscordController ELDHCIEPLLH()
	{
		return DiscordController.BFKGHEBNCKL;
	}

	// Token: 0x060065CC RID: 26060 RVA: 0x001EC454 File Offset: 0x001EA654
	public void IFKNIHJCAFB()
	{
		Debug.Log("SetPlayerDistance");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.JDACNGIILEE));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.FOODILEIOMK));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.COKMNBGJONL));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.AFPEOLCODFK));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.PKGIMONADIG));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.ILJJNGMHBHM));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, true, this.optionalSteamId);
	}

	// Token: 0x060065CD RID: 26061 RVA: 0x001EC57C File Offset: 0x001EA77C
	public void LLAJPKFNDIG()
	{
		Debug.Log("GameVolumeSlider");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.JDACNGIILEE));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.BBMDALMFCHK));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.BNKGAALHKMG));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.FFCOJBOLOAO));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.JFKDLOCBONG));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.KDPMCBLDGCI));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, true, this.optionalSteamId);
	}

	// Token: 0x060065CE RID: 26062 RVA: 0x001EC6A4 File Offset: 0x001EA8A4
	private void GNPDGBNDCPL()
	{
		if (this.inited)
		{
			Debug.Log("_Value");
			DiscordRpc.Shutdown();
		}
	}

	// Token: 0x060065CF RID: 26063 RVA: 0x001EC6C0 File Offset: 0x001EA8C0
	public void KLPKKGGCLPH(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.EOBBGILNOEC(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.BGEHIJNADHK(this.presence);
	}

	// Token: 0x060065D0 RID: 26064 RVA: 0x001EC74C File Offset: 0x001EA94C
	public void UpdateJoin(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.Encrypt(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.UpdatePresence(this.presence);
	}

	// Token: 0x060065D1 RID: 26065 RVA: 0x001EC7D8 File Offset: 0x001EA9D8
	public void DGFCPJKBECN(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "FullscreenToggle";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.GetLoadedSteamPlayername(steamID, false);
			this.presence.smallImageKey = "Current xp: ";
			if (loadedRank.CJILPHFNMEB() <= -76)
			{
				this.presence.smallImageKey = "EnableRankedNotificationsToggle";
			}
			else if (loadedRank.INIGKHLOKCD() <= -101)
			{
				this.presence.smallImageKey = "ItemNameBGImage";
			}
			else if (loadedRank.JCDLILAFFAJ() <= 45)
			{
				this.presence.smallImageKey = "Error! no audio sources attached to AudioSampler.css";
			}
			else if (loadedRank.CJILPHFNMEB() <= 67)
			{
				this.presence.smallImageKey = "[MapEditor] Loaded music file: ";
			}
		}
		DiscordRpc.IFHJIJOALEP(this.presence);
	}

	// Token: 0x060065D2 RID: 26066 RVA: 0x001EC8E4 File Offset: 0x001EAAE4
	public void FOBPJLCOKPL(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.HGIFJHHKABG(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.JJLKMAPPECD(this.presence);
	}

	// Token: 0x060065D3 RID: 26067 RVA: 0x001EC970 File Offset: 0x001EAB70
	public void ILJJNGMHBHM(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("_Val", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		this.joinRequest = GILCPIJNOKK;
		this.onJoinRequest.Invoke(GILCPIJNOKK);
		base.StartCoroutine(this.DFJNNAALMIF());
	}

	// Token: 0x060065D4 RID: 26068 RVA: 0x001EC9C8 File Offset: 0x001EABC8
	public void ReadyCallback(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format("[DiscordController] Connected to {0}#{1}: {2}", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		this.onConnect.Invoke();
		this.inited = true;
	}

	// Token: 0x060065D5 RID: 26069 RVA: 0x001ECA00 File Offset: 0x001EAC00
	public void OCHMKJKBAPI()
	{
		Debug.Log("_Size");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.LALGGLEPBLH));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.BBMDALMFCHK));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.CJJLPIHKPIM));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.FFCOJBOLOAO));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.EGENODMDOKN));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.ILJJNGMHBHM));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, false, this.optionalSteamId);
	}

	// Token: 0x060065D7 RID: 26071 RVA: 0x001ECB3B File Offset: 0x001EAD3B
	public void KKGKOAGJEPB(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("id", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x060065D8 RID: 26072 RVA: 0x001ECB5C File Offset: 0x001EAD5C
	public void JHBPINEKDPE()
	{
		Debug.Log("masterVolume");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.JDACNGIILEE));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.NPNJFADIOOP));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ErrorCallback));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.HCOAPDBKODB));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.KKGKOAGJEPB));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.KDPMCBLDGCI));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, true, this.optionalSteamId);
	}

	// Token: 0x060065D9 RID: 26073 RVA: 0x001EC378 File Offset: 0x001EA578
	private void Awake()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x060065DA RID: 26074 RVA: 0x001ECC84 File Offset: 0x001EAE84
	public void KJKAANGEFPK()
	{
		Debug.Log("leave");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x060065DB RID: 26075 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void EHJJFJCKGAJ()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x060065DC RID: 26076 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void FJHFOBHJEHL()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x060065DD RID: 26077 RVA: 0x001ECCAC File Offset: 0x001EAEAC
	private IEnumerator KOMOPGBIHAH(string KGINEMAHHFO)
	{
		if (DiscordController.JLJDGLEDKKD.LNIJKGECNME == null)
		{
			DiscordController.JLJDGLEDKKD.LNIJKGECNME = new Func<bool>(DiscordController.JLJDGLEDKKD.GBKBDKHPLKG);
		}
		yield return new WaitUntil(DiscordController.JLJDGLEDKKD.LNIJKGECNME);
		if (UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
		yield break;
	}

	// Token: 0x060065DE RID: 26078 RVA: 0x001ECCC7 File Offset: 0x001EAEC7
	public void PGCALCPPHBB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("Parameter levelId can't be null!", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x060065DF RID: 26079 RVA: 0x001ECCDF File Offset: 0x001EAEDF
	public void ABDAHOONFNH(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("STOP [R]", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x060065E0 RID: 26080 RVA: 0x001ECCF8 File Offset: 0x001EAEF8
	public void EAFFHHCMLCG()
	{
		Debug.Log("Set camera background color");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.LALGGLEPBLH));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.BBMDALMFCHK));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ELPKAJGLOAN));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.BADJIGMFIKB));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.EGENODMDOKN));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.RequestCallback));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, false, this.optionalSteamId);
	}

	// Token: 0x060065E1 RID: 26081 RVA: 0x001ECE20 File Offset: 0x001EB020
	public void IEFKKHALICN()
	{
		Debug.Log("LostAllLives");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x060065E2 RID: 26082 RVA: 0x001ECE48 File Offset: 0x001EB048
	public void CJJLPIHKPIM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value4", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x060065E3 RID: 26083 RVA: 0x001ECE60 File Offset: 0x001EB060
	private void PNNPDMHLFHE()
	{
		if (this.inited)
		{
			Debug.Log("SetPosition");
			DiscordRpc.Shutdown();
		}
	}

	// Token: 0x060065E4 RID: 26084 RVA: 0x001EC378 File Offset: 0x001EA578
	private void CIAHIJIOFIE()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x060065E5 RID: 26085 RVA: 0x001ECE7C File Offset: 0x001EB07C
	public void FFCOJBOLOAO(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("#no", MJDPJLOCLIL));
		this.onJoin.Invoke(MJDPJLOCLIL);
		string kginemahhfo = GameManager.FHOAAADFONG(MJDPJLOCLIL);
		base.StartCoroutine(this.KOMOPGBIHAH(kginemahhfo));
	}

	// Token: 0x060065E6 RID: 26086 RVA: 0x001ECEBC File Offset: 0x001EB0BC
	public void OAKONCDEPPI()
	{
		Debug.Log("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.LALGGLEPBLH));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.BPNDNPJKEAB));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ErrorCallback));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.FFCOJBOLOAO));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.SpectateCallback));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.RequestCallback));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, true, this.optionalSteamId);
	}

	// Token: 0x060065E7 RID: 26087 RVA: 0x001ECFE4 File Offset: 0x001EB1E4
	public void NPNJFADIOOP(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("CameraFilterPack/Retro_Loading", PNCJHNNOAAP, JKPJCEMPAGH));
		this.onDisconnect.Invoke();
	}

	// Token: 0x060065E8 RID: 26088 RVA: 0x001ED007 File Offset: 0x001EB207
	public void BPNDNPJKEAB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Sensitivity", PNCJHNNOAAP, JKPJCEMPAGH));
		this.onDisconnect.Invoke();
	}

	// Token: 0x060065E9 RID: 26089 RVA: 0x001ED02A File Offset: 0x001EB22A
	private void KACPCCMPAHA()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x060065EA RID: 26090 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void HNDNDPECBPL()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x060065EB RID: 26091 RVA: 0x001ED065 File Offset: 0x001EB265
	public void FDMBOIJJILJ()
	{
		Debug.Log("JoinRandom failed: {0}.");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x060065EC RID: 26092 RVA: 0x001ED08D File Offset: 0x001EB28D
	public void BKGLPPEEOAP(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_Value", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x060065ED RID: 26093 RVA: 0x001ED0AC File Offset: 0x001EB2AC
	public void INGOODALACO()
	{
		Debug.Log("CameraFilterPack/Distortion_Noise");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.ReadyCallback));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.FOODILEIOMK));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ELPKAJGLOAN));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.FFCOJBOLOAO));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.SpectateCallback));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.FOKMCMAOPBI));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, true, this.optionalSteamId);
	}

	// Token: 0x060065EE RID: 26094 RVA: 0x001EC378 File Offset: 0x001EA578
	private void PGGNGAMLGAJ()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x060065EF RID: 26095 RVA: 0x001ED02A File Offset: 0x001EB22A
	private void GGKPLCJNEHF()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x060065F0 RID: 26096 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDPCJGIFJCF()
	{
	}

	// Token: 0x060065F1 RID: 26097 RVA: 0x001ED1D4 File Offset: 0x001EB3D4
	public void FFFLJEOBGCE(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.MLFEBPAINHO(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.IGEODKNADDD(this.presence);
	}

	// Token: 0x060065F2 RID: 26098 RVA: 0x001ED260 File Offset: 0x001EB460
	private IEnumerator OJHJHNHGEEI(string KGINEMAHHFO)
	{
		if (DiscordController.JLJDGLEDKKD.LNIJKGECNME == null)
		{
			DiscordController.JLJDGLEDKKD.LNIJKGECNME = new Func<bool>(DiscordController.JLJDGLEDKKD.GBKBDKHPLKG);
		}
		yield return new WaitUntil(DiscordController.JLJDGLEDKKD.LNIJKGECNME);
		if (UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
		yield break;
	}

	// Token: 0x060065F3 RID: 26099 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANPPPGKOIBP()
	{
	}

	// Token: 0x060065F4 RID: 26100 RVA: 0x001ED27B File Offset: 0x001EB47B
	public void GHPMJEKMDCI(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Save Path: ", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x060065F5 RID: 26101 RVA: 0x001ED29C File Offset: 0x001EB49C
	public void FGGMHJOGKAJ(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "/icon";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.OHAGJGNCAPN(steamID, false);
			this.presence.smallImageKey = "[NetworkManager] roomInfo.name: ";
			if (loadedRank.place <= -85)
			{
				this.presence.smallImageKey = "OpLeaveLobby()";
			}
			else if (loadedRank.place <= -7)
			{
				this.presence.smallImageKey = "New SaveGame";
			}
			else if (loadedRank.CJILPHFNMEB() <= 47)
			{
				this.presence.smallImageKey = "[PhotonMessageInfo: Sender='{1}' Senttime={0}]";
			}
			else if (loadedRank.IGKJJMCLABK() <= 168)
			{
				this.presence.smallImageKey = "_MatrixColor";
			}
		}
		DiscordRpc.AABCMAPBDJN(this.presence);
	}

	// Token: 0x060065F6 RID: 26102 RVA: 0x001ED3A8 File Offset: 0x001EB5A8
	public void HLCMOFCEJLP()
	{
		Debug.Log("y");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.JDACNGIILEE));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.DisconnectedCallback));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.MHIPOFJKNKO));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.BADJIGMFIKB));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.KGBCMAKLBGA));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.RequestCallback));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, true, this.optionalSteamId);
	}

	// Token: 0x060065F7 RID: 26103 RVA: 0x001ED4D0 File Offset: 0x001EB6D0
	public void IFHMKHDNHAC(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "CameraFilterPack_AAA_Blood2";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.DOILNLEFLAP(steamID, false);
			this.presence.smallImageKey = "#close";
			if (loadedRank.place <= -121)
			{
				this.presence.smallImageKey = "_Bullet_3";
			}
			else if (loadedRank.INIGKHLOKCD() <= -34)
			{
				this.presence.smallImageKey = "[ResourcesManager] Load audio error: ";
			}
			else if (loadedRank.INIGKHLOKCD() <= -16)
			{
				this.presence.smallImageKey = ".lastCheckpoint.penaltyScore";
			}
			else if (loadedRank.place <= -42)
			{
				this.presence.smallImageKey = "Mouse X";
			}
		}
		DiscordRpc.HPFIDCEGLIN(this.presence);
	}

	// Token: 0x060065F8 RID: 26104 RVA: 0x001ED5DC File Offset: 0x001EB7DC
	private IEnumerator KJLFOJHECGL(string KGINEMAHHFO)
	{
		if (DiscordController.JLJDGLEDKKD.LNIJKGECNME == null)
		{
			DiscordController.JLJDGLEDKKD.LNIJKGECNME = new Func<bool>(DiscordController.JLJDGLEDKKD.GBKBDKHPLKG);
		}
		yield return new WaitUntil(DiscordController.JLJDGLEDKKD.LNIJKGECNME);
		if (UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
		yield break;
	}

	// Token: 0x060065F9 RID: 26105 RVA: 0x001ED5F8 File Offset: 0x001EB7F8
	public void JBFOLLCGNEH(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.GIMHBMFOBPK(this.presence);
	}

	// Token: 0x060065FA RID: 26106 RVA: 0x001ED02A File Offset: 0x001EB22A
	private void DHNANELONED()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x060065FB RID: 26107 RVA: 0x0002523B File Offset: 0x0002343B
	private void HACCDOCHKGL()
	{
	}

	// Token: 0x060065FC RID: 26108 RVA: 0x001ED682 File Offset: 0x001EB882
	public void EGENODMDOKN(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("NO", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x060065FD RID: 26109 RVA: 0x001ED6A0 File Offset: 0x001EB8A0
	public void LALGGLEPBLH(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format(" id: ", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		this.onConnect.Invoke();
		this.inited = false;
	}

	// Token: 0x060065FE RID: 26110 RVA: 0x001ED6D5 File Offset: 0x001EB8D5
	public void AHMKBKFJCJA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_SizeX", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x060065FF RID: 26111 RVA: 0x001ED6ED File Offset: 0x001EB8ED
	public void RequestRespondYes()
	{
		Debug.Log("[DiscordController] Responding yes to Ask to Join request");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.Yes);
		this.hasResponded.Invoke();
	}

	// Token: 0x06006600 RID: 26112 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnDestroy()
	{
	}

	// Token: 0x06006601 RID: 26113 RVA: 0x001ED715 File Offset: 0x001EB915
	public void PKGIMONADIG(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("[LevelEditorScene] Error: I/O Failure! :(", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x06006602 RID: 26114 RVA: 0x001ED733 File Offset: 0x001EB933
	public void MHJKKJIOPID(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", PNCJHNNOAAP, JKPJCEMPAGH));
		this.onDisconnect.Invoke();
	}

	// Token: 0x06006603 RID: 26115 RVA: 0x001ED758 File Offset: 0x001EB958
	private IEnumerator LNLHGEBABOH()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", this.joinRequest.username), "#yes", new UnityAction(base.GBKBDKHPLKG), "#no", new UnityAction(base.HMMBBDJNGGL)));
		yield break;
	}

	// Token: 0x06006604 RID: 26116 RVA: 0x001ED774 File Offset: 0x001EB974
	public void AAPMAEFHKEO()
	{
		Debug.Log("menu.hardcoreinfo");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.JDACNGIILEE));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.NPNJFADIOOP));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ABDAHOONFNH));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.JoinCallback));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.KKGKOAGJEPB));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.RequestCallback));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, false, this.optionalSteamId);
	}

	// Token: 0x06006605 RID: 26117 RVA: 0x001ED89C File Offset: 0x001EBA9C
	private IEnumerator DFJNNAALMIF()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", this.joinRequest.username), "#yes", new UnityAction(base.GBKBDKHPLKG), "#no", new UnityAction(base.HMMBBDJNGGL)));
		yield break;
	}

	// Token: 0x06006606 RID: 26118 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void LBPCODPOJAH()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x06006607 RID: 26119 RVA: 0x001ED8B8 File Offset: 0x001EBAB8
	public void CBIPOKCJEPJ(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "Not sending leave operation. State is not 'Joined': ";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.OHAGJGNCAPN(steamID, true);
			this.presence.smallImageKey = "_Color";
			if (loadedRank.CJILPHFNMEB() <= 23)
			{
				this.presence.smallImageKey = "settings.arcsdestroydelay";
			}
			else if (loadedRank.IEOGJOLGLFI() <= 106)
			{
				this.presence.smallImageKey = " (inactive)";
			}
			else if (loadedRank.JCDLILAFFAJ() <= 30)
			{
				this.presence.smallImageKey = "ChatInput";
			}
			else if (loadedRank.INIGKHLOKCD() <= -60)
			{
				this.presence.smallImageKey = "player.fire";
			}
		}
		DiscordRpc.PFPMBIEMAIP(this.presence);
	}

	// Token: 0x06006608 RID: 26120 RVA: 0x001ED9C4 File Offset: 0x001EBBC4
	public void CCMIMIMBMOD(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.BGEHIJNADHK(this.presence);
	}

	// Token: 0x06006609 RID: 26121 RVA: 0x001EDA50 File Offset: 0x001EBC50
	public void FOKMCMAOPBI(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("Anime", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		this.joinRequest = GILCPIJNOKK;
		this.onJoinRequest.Invoke(GILCPIJNOKK);
		base.StartCoroutine(this.HJGLCIPNDDI());
	}

	// Token: 0x0600660A RID: 26122 RVA: 0x001EDAA8 File Offset: 0x001EBCA8
	private IEnumerator BLAGLOKLEFP()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", this.joinRequest.username), "#yes", new UnityAction(base.GBKBDKHPLKG), "#no", new UnityAction(base.HMMBBDJNGGL)));
		yield break;
	}

	// Token: 0x0600660B RID: 26123 RVA: 0x001EDAC3 File Offset: 0x001EBCC3
	public void BNKGAALHKMG(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format(" This is not possible to be called for standalone input. Please check your platform and code where this is called", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x0600660C RID: 26124 RVA: 0x001EDADC File Offset: 0x001EBCDC
	public void KDPMCBLDGCI(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("PhotonNetwork error: Could not Instantiate the prefab [", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		this.joinRequest = GILCPIJNOKK;
		this.onJoinRequest.Invoke(GILCPIJNOKK);
		base.StartCoroutine(this.LNLHGEBABOH());
	}

	// Token: 0x0600660D RID: 26125 RVA: 0x001EDB34 File Offset: 0x001EBD34
	public void BADJIGMFIKB(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("\" that takes ", MJDPJLOCLIL));
		this.onJoin.Invoke(MJDPJLOCLIL);
		string kginemahhfo = GameManager.BLNJDEEDEDJ(MJDPJLOCLIL);
		base.StartCoroutine(this.KJLFOJHECGL(kginemahhfo));
	}

	// Token: 0x0600660E RID: 26126 RVA: 0x001EDB72 File Offset: 0x001EBD72
	public void LLBCOONOCFB()
	{
		Debug.Log("_Vignette");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x0600660F RID: 26127 RVA: 0x001EDB9C File Offset: 0x001EBD9C
	public void MIBLNODIDGN(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.GIMHBMFOBPK(this.presence);
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06006610 RID: 26128 RVA: 0x001EC44B File Offset: 0x001EA64B
	public static DiscordController Instance
	{
		get
		{
			return DiscordController.BFKGHEBNCKL;
		}
	}

	// Token: 0x06006611 RID: 26129 RVA: 0x0002523B File Offset: 0x0002343B
	private void KANBABCDCAC()
	{
	}

	// Token: 0x06006612 RID: 26130 RVA: 0x001EDC28 File Offset: 0x001EBE28
	private IEnumerator HJGLCIPNDDI()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", this.joinRequest.username), "#yes", new UnityAction(base.GBKBDKHPLKG), "#no", new UnityAction(base.HMMBBDJNGGL)));
		yield break;
	}

	// Token: 0x06006613 RID: 26131 RVA: 0x001EDC44 File Offset: 0x001EBE44
	private IEnumerator HPIBPBBFBGB()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", this.joinRequest.username), "#yes", new UnityAction(base.GBKBDKHPLKG), "#no", new UnityAction(base.HMMBBDJNGGL)));
		yield break;
	}

	// Token: 0x06006614 RID: 26132 RVA: 0x001EDC5F File Offset: 0x001EBE5F
	private void DHNGNHGDPLM()
	{
		if (this.inited)
		{
			Debug.Log("_ScreenResolution");
			DiscordRpc.Shutdown();
		}
	}

	// Token: 0x06006615 RID: 26133 RVA: 0x001EDC7C File Offset: 0x001EBE7C
	public void HCOAPDBKODB(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("ShowTitle", MJDPJLOCLIL));
		this.onJoin.Invoke(MJDPJLOCLIL);
		string kginemahhfo = GameManager.BLNJDEEDEDJ(MJDPJLOCLIL);
		base.StartCoroutine(this.KOMOPGBIHAH(kginemahhfo));
	}

	// Token: 0x06006616 RID: 26134 RVA: 0x001EDCBC File Offset: 0x001EBEBC
	private IEnumerator HDOKDPAMIIN()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", this.joinRequest.username), "#yes", new UnityAction(base.GBKBDKHPLKG), "#no", new UnityAction(base.HMMBBDJNGGL)));
		yield break;
	}

	// Token: 0x06006617 RID: 26135 RVA: 0x001EDCD7 File Offset: 0x001EBED7
	public void ELPKAJGLOAN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_LutTex", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x06006618 RID: 26136 RVA: 0x001EDCF0 File Offset: 0x001EBEF0
	public void OnEnable()
	{
		Debug.Log("[DiscordController] Init");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.ReadyCallback));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.DisconnectedCallback));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ErrorCallback));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.JoinCallback));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.SpectateCallback));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.RequestCallback));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, true, this.optionalSteamId);
	}

	// Token: 0x06006619 RID: 26137 RVA: 0x001EC44B File Offset: 0x001EA64B
	public static DiscordController KDAJPJPBIBI()
	{
		return DiscordController.BFKGHEBNCKL;
	}

	// Token: 0x0600661A RID: 26138 RVA: 0x001EDE18 File Offset: 0x001EC018
	public void HIDGEDNCFAO(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value5", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x0600661B RID: 26139 RVA: 0x001EDE30 File Offset: 0x001EC030
	public void FBNJEFFDMHJ()
	{
		Debug.Log("#mapnotloaded");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x0600661C RID: 26140 RVA: 0x001EDE58 File Offset: 0x001EC058
	private IEnumerator CNGHGNJOFAE()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", this.joinRequest.username), "#yes", new UnityAction(base.GBKBDKHPLKG), "#no", new UnityAction(base.HMMBBDJNGGL)));
		yield break;
	}

	// Token: 0x0600661D RID: 26141 RVA: 0x001EDE73 File Offset: 0x001EC073
	public void ErrorCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[DiscordController] Error {0}: {1}", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x0600661E RID: 26142 RVA: 0x001EDE8C File Offset: 0x001EC08C
	public void FLEFCDDEDBN(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "_EmissionColor";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.LEKJAGAKEAM(steamID, false);
			this.presence.smallImageKey = "master";
			if (loadedRank.JCDLILAFFAJ() <= -75)
			{
				this.presence.smallImageKey = "CreateRoom failed, client stays on masterserver: {0}.";
			}
			else if (loadedRank.JCDLILAFFAJ() <= 83)
			{
				this.presence.smallImageKey = ".completed";
			}
			else if (loadedRank.IGKJJMCLABK() <= 124)
			{
				this.presence.smallImageKey = "_NoisePerChannel";
			}
			else if (loadedRank.place <= 132)
			{
				this.presence.smallImageKey = "CameraFilterPack/TV_ARCADE_Fast";
			}
		}
		DiscordRpc.UpdatePresence(this.presence);
	}

	// Token: 0x0600661F RID: 26143 RVA: 0x001EDF98 File Offset: 0x001EC198
	public void IGFIHJNBJMB(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "_Value4";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.OHKHAFCNHEI(steamID, false);
			this.presence.smallImageKey = "float,2";
			if (loadedRank.place <= 1)
			{
				this.presence.smallImageKey = " not exist";
			}
			else if (loadedRank.IGKJJMCLABK() <= -69)
			{
				this.presence.smallImageKey = "[PlayerController] ";
			}
			else if (loadedRank.JCDLILAFFAJ() <= -87)
			{
				this.presence.smallImageKey = "_TimeX";
			}
			else if (loadedRank.IGKJJMCLABK() <= -4)
			{
				this.presence.smallImageKey = "[LocalizationService] Loading file: ";
			}
		}
		DiscordRpc.OEFLFJBONMN(this.presence);
	}

	// Token: 0x06006620 RID: 26144 RVA: 0x001EE0A4 File Offset: 0x001EC2A4
	public void KOFFDOHJIAK()
	{
		Debug.Log("float,0");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.Yes);
		this.hasResponded.Invoke();
	}

	// Token: 0x06006621 RID: 26145 RVA: 0x001EE0CC File Offset: 0x001EC2CC
	public void SpectateCallback(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("[DiscordController] Sectate ({0})", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x06006622 RID: 26146 RVA: 0x001EE0EC File Offset: 0x001EC2EC
	public void NLGDPIBFHMK()
	{
		Debug.Log("_Parameter");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.ReadyCallback));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.DisconnectedCallback));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ELPKAJGLOAN));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.FFCOJBOLOAO));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.SpectateCallback));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.RequestCallback));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, false, this.optionalSteamId);
	}

	// Token: 0x06006623 RID: 26147 RVA: 0x001EC44B File Offset: 0x001EA64B
	public static DiscordController OFEINMJONLO()
	{
		return DiscordController.BFKGHEBNCKL;
	}

	// Token: 0x06006624 RID: 26148 RVA: 0x001EE214 File Offset: 0x001EC414
	public void EJDOJKLHJAD()
	{
		Debug.Log("_Value4");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x06006625 RID: 26149 RVA: 0x001EE23C File Offset: 0x001EC43C
	private IEnumerator OBNKBHOFCAO(string KGINEMAHHFO)
	{
		if (DiscordController.JLJDGLEDKKD.LNIJKGECNME == null)
		{
			DiscordController.JLJDGLEDKKD.LNIJKGECNME = new Func<bool>(DiscordController.JLJDGLEDKKD.GBKBDKHPLKG);
		}
		yield return new WaitUntil(DiscordController.JLJDGLEDKKD.LNIJKGECNME);
		if (UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
		yield break;
	}

	// Token: 0x06006626 RID: 26150 RVA: 0x0002523B File Offset: 0x0002343B
	private void KHBLMEGPPLJ()
	{
	}

	// Token: 0x06006627 RID: 26151 RVA: 0x001EE257 File Offset: 0x001EC457
	public void MHIPOFJKNKO(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value2", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	// Token: 0x06006628 RID: 26152 RVA: 0x001EE270 File Offset: 0x001EC470
	public void KGNFAPNFEPC(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = "CameraFilterPack/Vision_Hell_Blood";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.OHKHAFCNHEI(steamID, true);
			this.presence.smallImageKey = "GlassDistortion";
			if (loadedRank.place <= -1)
			{
				this.presence.smallImageKey = ".a";
			}
			else if (loadedRank.IEOGJOLGLFI() <= 33)
			{
				this.presence.smallImageKey = ".lastCheckpoint.lives";
			}
			else if (loadedRank.IGKJJMCLABK() <= -8)
			{
				this.presence.smallImageKey = "settings_bindings_sec_";
			}
			else if (loadedRank.CJILPHFNMEB() <= -117)
			{
				this.presence.smallImageKey = "Please attach component to a Graphical UI component";
			}
		}
		DiscordRpc.NDDOOOKGNKB(this.presence);
	}

	// Token: 0x06006629 RID: 26153 RVA: 0x001EE37C File Offset: 0x001EC57C
	public void CCDJCDOGOFD(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		this.presence.state = ILPCDMBBCOF;
		this.presence.details = IJPCEKICPCP;
		this.presence.largeImageKey = " not exist";
		this.presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			this.presence.smallImageText = ResourcesManager.OHAGJGNCAPN(steamID, true);
			this.presence.smallImageKey = "GroupNameText";
			if (loadedRank.CJILPHFNMEB() <= -11)
			{
				this.presence.smallImageKey = "_Value2";
			}
			else if (loadedRank.IGKJJMCLABK() <= -57)
			{
				this.presence.smallImageKey = "Editor/";
			}
			else if (loadedRank.IGKJJMCLABK() <= -118)
			{
				this.presence.smallImageKey = "OnPlayerGameMessage";
			}
			else if (loadedRank.IEOGJOLGLFI() <= -22)
			{
				this.presence.smallImageKey = "VisionBlur";
			}
		}
		DiscordRpc.BGEHIJNADHK(this.presence);
	}

	// Token: 0x0600662A RID: 26154 RVA: 0x001EE488 File Offset: 0x001EC688
	public void LHINMOCPGHM()
	{
		Debug.Log("Editor");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.Yes);
		this.hasResponded.Invoke();
	}

	// Token: 0x0600662B RID: 26155 RVA: 0x001EE4B0 File Offset: 0x001EC6B0
	public void ANAHGFDJLCJ()
	{
		Debug.Log(").png");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x0600662C RID: 26156 RVA: 0x001EE4D8 File Offset: 0x001EC6D8
	public void DisconnectedCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[DiscordController] Disconnect {0}: {1}", PNCJHNNOAAP, JKPJCEMPAGH));
		this.onDisconnect.Invoke();
	}

	// Token: 0x0600662D RID: 26157 RVA: 0x001EE4FB File Offset: 0x001EC6FB
	private void EJJEDJIOFAB()
	{
		if (this.inited)
		{
			Debug.Log("CompletedLevel");
			DiscordRpc.Shutdown();
		}
	}

	// Token: 0x0600662E RID: 26158 RVA: 0x001EC44B File Offset: 0x001EA64B
	public static DiscordController CJBKCCLGIAG()
	{
		return DiscordController.BFKGHEBNCKL;
	}

	// Token: 0x0600662F RID: 26159 RVA: 0x001EE517 File Offset: 0x001EC717
	private void CBIBDOIBJAI()
	{
		if (this.inited)
		{
			Debug.Log(">");
			DiscordRpc.Shutdown();
		}
	}

	// Token: 0x06006630 RID: 26160 RVA: 0x001EE533 File Offset: 0x001EC733
	public void FOODILEIOMK(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Intensity", PNCJHNNOAAP, JKPJCEMPAGH));
		this.onDisconnect.Invoke();
	}

	// Token: 0x06006631 RID: 26161 RVA: 0x001EE556 File Offset: 0x001EC756
	public void CLHABPEJCJJ()
	{
		Debug.Log("#random #rare #item");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x06006632 RID: 26162 RVA: 0x001ED02A File Offset: 0x001EB22A
	private void OBEJFFEJOBJ()
	{
		if (UnityEngine.Object.FindObjectsOfType(base.GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			DiscordController.BFKGHEBNCKL = this;
			UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
		}
	}

	// Token: 0x06006633 RID: 26163 RVA: 0x001EE57E File Offset: 0x001EC77E
	public void RequestRespondNo()
	{
		Debug.Log("[DiscordController] Responding no to Ask to Join request");
		DiscordRpc.Respond(this.joinRequest.userId, DiscordRpc.Reply.No);
		this.hasResponded.Invoke();
	}

	// Token: 0x06006634 RID: 26164 RVA: 0x001EE5A8 File Offset: 0x001EC7A8
	public void DGEPPDJDBLN()
	{
		Debug.Log("_ScreenResolution");
		this.DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		this.DEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(this.DEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(this.ReadyCallback));
		this.DEBDALGLNCD.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(this.DEBDALGLNCD.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(this.FOODILEIOMK));
		this.DEBDALGLNCD.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(this.DEBDALGLNCD.errorCallback, new DiscordRpc.OnErrorInfo(this.ErrorCallback));
		this.DEBDALGLNCD.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(this.DEBDALGLNCD.joinCallback, new DiscordRpc.OnJoinInfo(this.BADJIGMFIKB));
		this.DEBDALGLNCD.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(this.DEBDALGLNCD.spectateCallback, new DiscordRpc.OnSpectateInfo(this.SpectateCallback));
		this.DEBDALGLNCD.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(this.DEBDALGLNCD.requestCallback, new DiscordRpc.OnRequestInfo(this.RequestCallback));
		DiscordRpc.Initialize(this.applicationId, ref this.DEBDALGLNCD, false, this.optionalSteamId);
	}

	// Token: 0x06006635 RID: 26165 RVA: 0x001EE6D0 File Offset: 0x001EC8D0
	public void JFKDLOCBONG(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_TimeX", MJDPJLOCLIL));
		this.onSpectate.Invoke(MJDPJLOCLIL);
	}

	// Token: 0x06006636 RID: 26166 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void PFNFPINPCMH()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x06006637 RID: 26167 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void Update()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x06006638 RID: 26168 RVA: 0x001EC44B File Offset: 0x001EA64B
	public static DiscordController MFPEEHNEFIM()
	{
		return DiscordController.BFKGHEBNCKL;
	}

	// Token: 0x06006639 RID: 26169 RVA: 0x001EE6F0 File Offset: 0x001EC8F0
	public void CAHGHLOIOKM(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			this.presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			this.presence.partyId = GACMHOJFDEI;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			this.presence.joinSecret = null;
			this.presence.partyId = null;
			this.presence.partySize = NOHGDKNLBFD;
			this.presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.OEFLFJBONMN(this.presence);
	}

	// Token: 0x0600663A RID: 26170 RVA: 0x001EC1AC File Offset: 0x001EA3AC
	private void NEKCPLGFOFD()
	{
		DiscordRpc.RunCallbacks();
	}

	// Token: 0x0600663B RID: 26171 RVA: 0x001EC44B File Offset: 0x001EA64B
	public static DiscordController NLEPFMACKHN()
	{
		return DiscordController.BFKGHEBNCKL;
	}

	// Token: 0x0600663C RID: 26172 RVA: 0x001EE77A File Offset: 0x001EC97A
	private void OnDisable()
	{
		if (this.inited)
		{
			Debug.Log("[DiscordController] Shutdown");
			DiscordRpc.Shutdown();
		}
	}

	// Token: 0x0600663D RID: 26173 RVA: 0x001EE798 File Offset: 0x001EC998
	public void RequestCallback(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("[DiscordController] Join request {0}#{1}: {2}", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		this.joinRequest = GILCPIJNOKK;
		this.onJoinRequest.Invoke(GILCPIJNOKK);
		base.StartCoroutine(this.LNLHGEBABOH());
	}

	// Token: 0x04000A56 RID: 2646
	private static DiscordController BFKGHEBNCKL;

	// Token: 0x04000A57 RID: 2647
	public DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();

	// Token: 0x04000A58 RID: 2648
	public string applicationId;

	// Token: 0x04000A59 RID: 2649
	public string optionalSteamId;

	// Token: 0x04000A5A RID: 2650
	public DiscordRpc.DiscordUser joinRequest;

	// Token: 0x04000A5B RID: 2651
	public UnityEvent onConnect;

	// Token: 0x04000A5C RID: 2652
	public UnityEvent onDisconnect;

	// Token: 0x04000A5D RID: 2653
	public UnityEvent hasResponded;

	// Token: 0x04000A5E RID: 2654
	public DiscordJoinEvent onJoin;

	// Token: 0x04000A5F RID: 2655
	public DiscordJoinEvent onSpectate;

	// Token: 0x04000A60 RID: 2656
	public DiscordJoinRequestEvent onJoinRequest;

	// Token: 0x04000A61 RID: 2657
	private DiscordRpc.EventHandlers DEBDALGLNCD;

	// Token: 0x04000A62 RID: 2658
	[HideInInspector]
	public bool inited;
}
