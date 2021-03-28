using System;
using System.Collections;
using Photon;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004BE RID: 1214
public class LobbyPlayerElement : PunBehaviour
{
	// Token: 0x060116AC RID: 71340 RVA: 0x005FF165 File Offset: 0x005FD365
	public void HBIGOLEEFNH()
	{
		this.isReady = (base.IBKCMBIGOEJ().owner.GetTeam() != PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	// Token: 0x060116AD RID: 71341 RVA: 0x005FF1A0 File Offset: 0x005FD3A0
	public void BDMCMMCNMLL()
	{
		CSteamID csteamID = new CSteamID(ulong.Parse(base.JAEJDHHCJJO().JJFEGIOPFGN().name));
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("The given 2D texture ") + csteamID.m_SteamID, false);
	}

	// Token: 0x060116AE RID: 71342 RVA: 0x005FF1F4 File Offset: 0x005FD3F4
	public void DAJMBLIMCNM(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_ScreenResolution");
		this.ODNIPBPNKIN();
	}

	// Token: 0x060116AF RID: 71343 RVA: 0x005FF208 File Offset: 0x005FD408
	public void OpenProfile()
	{
		CSteamID csteamID = new CSteamID(ulong.Parse(base.photonView.owner.name));
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?player=") + csteamID.m_SteamID, true);
	}

	// Token: 0x060116B0 RID: 71344 RVA: 0x005FF25C File Offset: 0x005FD45C
	public void NJDAJMNCPIA()
	{
		this.isReady = (base.EOOCGIFFKBG().JFCKAGHNNCA().GetTeam() != PunTeams.Team.none && false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().FDNCEFHNLNJ();
	}

	// Token: 0x060116B1 RID: 71345 RVA: 0x005FF294 File Offset: 0x005FD494
	private void EFJDNLGNACH()
	{
		if (!base.GMAHNPNHMFK().DOLKFPIABDD())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(475f, 1090f, 300f);
			this.Init();
		}
	}

	// Token: 0x060116B2 RID: 71346 RVA: 0x005FF2FC File Offset: 0x005FD4FC
	private void EMKJHNGDAAP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("LeaderboardsButton").gameObject.SetActive(true);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.ALHLMBCOILP("SpawnObj", "[MapEditor] Importing map: ", null, true, false, 126f);
		Singleton<MultiplayerSystem>.Instance.HCIFGHPJKIB();
	}

	// Token: 0x060116B3 RID: 71347 RVA: 0x005FF35C File Offset: 0x005FD55C
	private void Start()
	{
		if (!base.photonView.isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1f, 1f, 1f);
			this.Init();
		}
	}

	// Token: 0x060116B4 RID: 71348 RVA: 0x005FF3C2 File Offset: 0x005FD5C2
	public void EAJPNBCLAEO(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("GlassDistortion");
		this.ONIACAFDJNP();
	}

	// Token: 0x060116B5 RID: 71349 RVA: 0x005FF3D4 File Offset: 0x005FD5D4
	private void JILOMOBDPIA()
	{
		if (!base.EOOCGIFFKBG().KCAOJFPDEIP())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(478f, 1470f, 1060f);
			this.JLMPMMFKJID();
		}
	}

	// Token: 0x060116B6 RID: 71350 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void Update()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x060116B7 RID: 71351 RVA: 0x005FF460 File Offset: 0x005FD660
	public void BKLCHHKOMLD()
	{
		Debug.Log("yesterday" + base.GBHNDHLAJLI().JFCKAGHNNCA().name);
		this.isReady = true;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.OELHGNKAMEG().JFCKAGHNNCA().name));
		base.StartCoroutine(this.BAMOGGMGKEF(jmmilefmacb));
		this.HBIGOLEEFNH();
	}

	// Token: 0x060116B8 RID: 71352 RVA: 0x005FF4C3 File Offset: 0x005FD6C3
	public void ODNIPBPNKIN()
	{
		this.isReady = (base.FFIPLLNKGEN().JFCKAGHNNCA().GetTeam() == PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	// Token: 0x060116B9 RID: 71353 RVA: 0x005FF4FB File Offset: 0x005FD6FB
	public void FIDKCPFLHEB()
	{
		this.isReady = (base.EOOCGIFFKBG().JFCKAGHNNCA().GetTeam() != PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	// Token: 0x060116BA RID: 71354 RVA: 0x005FF534 File Offset: 0x005FD734
	private void JCCIIGINOIE()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("CameraFilterPack_TV_HorrorFX").gameObject.SetActive(false);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("settings.arcsdestroydelay", "#", null, true, false, 1701f);
		Singleton<MultiplayerSystem>.Instance.HKFKGLGIIOH();
	}

	// Token: 0x060116BB RID: 71355 RVA: 0x005FF592 File Offset: 0x005FD792
	public void DNGHDPKGDIC()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.IHPEKIKCFBL(base.IBKCMBIGOEJ().owner);
		}
	}

	// Token: 0x060116BC RID: 71356 RVA: 0x005FF5AF File Offset: 0x005FD7AF
	public void CCPBGHOPKEK(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_Intensity");
		this.FIDKCPFLHEB();
	}

	// Token: 0x060116BD RID: 71357 RVA: 0x005FF5C1 File Offset: 0x005FD7C1
	public void MLFFFAEIOMM(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_Value7");
		this.FIDKCPFLHEB();
	}

	// Token: 0x060116BE RID: 71358 RVA: 0x005FF5D3 File Offset: 0x005FD7D3
	public void CGLAPGFGBFL(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("SetCrosshairEmission");
		this.JOAONIBIKNM();
	}

	// Token: 0x060116BF RID: 71359 RVA: 0x005FF5E8 File Offset: 0x005FD7E8
	private IEnumerator PPEADOFJLAD(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x060116C0 RID: 71360 RVA: 0x005FF60A File Offset: 0x005FD80A
	public void AMFKMGPDBHI(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(116);
		}
		base.JAEJDHHCJJO().DPLELHEFMBE("_MainTex2", JHOEDACNNKK, new object[0]);
	}

	// Token: 0x060116C1 RID: 71361 RVA: 0x005FF638 File Offset: 0x005FD838
	private void NBGIMIDICKE()
	{
		if (!base.EOOCGIFFKBG().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(543f, 447f, 1920f);
			this.Init();
		}
	}

	// Token: 0x060116C2 RID: 71362 RVA: 0x005FF69E File Offset: 0x005FD89E
	public void KickPlayer()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.SendKickPlayer(base.photonView.owner);
		}
	}

	// Token: 0x060116C3 RID: 71363 RVA: 0x005FF6BB File Offset: 0x005FD8BB
	public void CheckIsReady()
	{
		this.isReady = (base.photonView.owner.GetTeam() != PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	// Token: 0x060116C4 RID: 71364 RVA: 0x005FF6F3 File Offset: 0x005FD8F3
	public void EKLHKNMCPNC()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.AIIHFEFLHFE(base.GBHNDHLAJLI().JFCKAGHNNCA());
		}
	}

	// Token: 0x060116C5 RID: 71365 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void GMELGGJOPBB()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x060116C6 RID: 71366 RVA: 0x005FF710 File Offset: 0x005FD910
	private void ILCFPCIPENO()
	{
		if (!base.CIACEFBNDDJ().KCAOJFPDEIP())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1855f, 8f, 1133f);
			this.POGJLIDHDIH();
		}
	}

	// Token: 0x060116C7 RID: 71367 RVA: 0x005FF776 File Offset: 0x005FD976
	public void ACLBOKCIAAD(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-93);
		}
		base.EOOCGIFFKBG().PLMAEOHKJPN("IncorrectHitsScoreText", JHOEDACNNKK, new object[1]);
	}

	// Token: 0x060116C8 RID: 71368 RVA: 0x005FF7A4 File Offset: 0x005FD9A4
	private IEnumerator HJFDEEMKFDJ(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x060116C9 RID: 71369 RVA: 0x005FF7C8 File Offset: 0x005FD9C8
	private IEnumerator BAMOGGMGKEF(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x060116CA RID: 71370 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPMAEFHKEO()
	{
	}

	// Token: 0x060116CB RID: 71371 RVA: 0x005FF7EC File Offset: 0x005FD9EC
	public void NKLCNJEIAFB()
	{
		Debug.Log("curScn" + base.IBKCMBIGOEJ().JFCKAGHNNCA().name);
		this.isReady = false;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.EOOCGIFFKBG().JFCKAGHNNCA().name));
		base.StartCoroutine(this.EHGNFNCJCMM(jmmilefmacb));
		this.CheckIsReady();
	}

	// Token: 0x060116CC RID: 71372 RVA: 0x005FF850 File Offset: 0x005FDA50
	private void DKOPKPBLDHH()
	{
		if (!base.BLMHOKPIMOD().isMine)
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1354f, 1231f, 772f);
			this.MDPJHKECLOF();
		}
	}

	// Token: 0x060116CD RID: 71373 RVA: 0x005FF8B6 File Offset: 0x005FDAB6
	public void IHPEKIKCFBL(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-5);
		}
		base.photonView.KACECEKIPPP("_Value2", JHOEDACNNKK, new object[0]);
	}

	// Token: 0x060116CE RID: 71374 RVA: 0x005FF8E1 File Offset: 0x005FDAE1
	public void EAEPPHAHJBP(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_TimeX");
		this.EPHNJNLKJLP();
	}

	// Token: 0x060116CF RID: 71375 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void IEMEHGCFAPD()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x060116D0 RID: 71376 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBEAPBDAOCC()
	{
	}

	// Token: 0x060116D1 RID: 71377 RVA: 0x005FF8F4 File Offset: 0x005FDAF4
	private IEnumerator DEFNIIHFKFA(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x060116D2 RID: 71378 RVA: 0x005FF918 File Offset: 0x005FDB18
	private void PDHKMDBNGGN()
	{
		if (!base.IBKCMBIGOEJ().BGJKMGJBPFA())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(213f, 514f, 327f);
			this.BKLCHHKOMLD();
		}
	}

	// Token: 0x060116D3 RID: 71379 RVA: 0x005FF980 File Offset: 0x005FDB80
	private void KLJGNMLPBIG()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("_TimeX").gameObject.SetActive(true);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.ILNLMMEOALM("SetParticlesCountPerBeat", "_Value6", null, true, true, 125f);
		Singleton<MultiplayerSystem>.Instance.HKFKGLGIIOH();
	}

	// Token: 0x060116D4 RID: 71380 RVA: 0x005FF9DE File Offset: 0x005FDBDE
	public void BPDDHMICEBP()
	{
		this.isReady = (base.CIACEFBNDDJ().JJFEGIOPFGN().GetTeam() == PunTeams.Team.none || true);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	// Token: 0x060116D5 RID: 71381 RVA: 0x005FFA16 File Offset: 0x005FDC16
	public void ANLGHGCGAGP()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.IHPEKIKCFBL(base.photonView.JFCKAGHNNCA());
		}
	}

	// Token: 0x060116D6 RID: 71382 RVA: 0x005FFA33 File Offset: 0x005FDC33
	public void JPEHBKGOBJN()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.AMFKMGPDBHI(base.CIACEFBNDDJ().owner);
		}
	}

	// Token: 0x060116D7 RID: 71383 RVA: 0x005FFA50 File Offset: 0x005FDC50
	public void LHIEKHPLMFI()
	{
		Debug.Log("CameraFilterPack/Light_Water2" + base.GMAHNPNHMFK().JJFEGIOPFGN().name);
		this.isReady = false;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.OELHGNKAMEG().JFCKAGHNNCA().name));
		base.StartCoroutine(this.EHGNFNCJCMM(jmmilefmacb));
		this.ODNIPBPNKIN();
	}

	// Token: 0x060116D8 RID: 71384 RVA: 0x0002523B File Offset: 0x0002343B
	private void OKHGJFFIIBA()
	{
	}

	// Token: 0x060116D9 RID: 71385 RVA: 0x005FFAB4 File Offset: 0x005FDCB4
	private void PFEKDDLJMHJ()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("maps.").gameObject.SetActive(false);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC("_Value4", "_Value", null, true, true, 1959f);
		Singleton<MultiplayerSystem>.Instance.LCJPNOIOLGJ();
	}

	// Token: 0x060116DA RID: 71386 RVA: 0x005FFB14 File Offset: 0x005FDD14
	public void GGHCMPKGNGE()
	{
		Debug.Log("_BaseTex" + base.GMAHNPNHMFK().JJFEGIOPFGN().name);
		this.isReady = true;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.AAMNKPHHHCI().JFCKAGHNNCA().name));
		base.StartCoroutine(this.BAMOGGMGKEF(jmmilefmacb));
		this.AMCKGGMDLDB();
	}

	// Token: 0x060116DB RID: 71387 RVA: 0x005FFB78 File Offset: 0x005FDD78
	private IEnumerator LAGBNPIFBPL(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x060116DC RID: 71388 RVA: 0x005FFB9C File Offset: 0x005FDD9C
	public void GDJMBJEAPHM()
	{
		Debug.Log("_ColorRGB" + base.IBKCMBIGOEJ().JFCKAGHNNCA().name);
		this.isReady = false;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.GMAHNPNHMFK().JJFEGIOPFGN().name));
		base.StartCoroutine(this.AGEDFEIDJIF(jmmilefmacb));
		this.ODNIPBPNKIN();
	}

	// Token: 0x060116DD RID: 71389 RVA: 0x005FFBFF File Offset: 0x005FDDFF
	public void JMCLAGKENHN()
	{
		this.isReady = (base.GBMJAPGLMGB().owner.GetTeam() == PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().FDNCEFHNLNJ();
	}

	// Token: 0x060116DE RID: 71390 RVA: 0x0002523B File Offset: 0x0002343B
	private void HHODKHPIBLG()
	{
	}

	// Token: 0x060116DF RID: 71391 RVA: 0x005FFC38 File Offset: 0x005FDE38
	public void AOCOABCDFKA()
	{
		CSteamID csteamID = new CSteamID(ulong.Parse(base.IBKCMBIGOEJ().JFCKAGHNNCA().name));
		Singleton<GameManager>.Instance.GIBBJCCHOOJ(Singleton<GameManager>.Instance.CreateServerURL("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.") + csteamID.m_SteamID, true);
	}

	// Token: 0x060116E0 RID: 71392 RVA: 0x005FFC8C File Offset: 0x005FDE8C
	public void MLIBNJPMOHK(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(105);
		}
		base.photonView.OKHNMAMFDFD("_Value", JHOEDACNNKK, new object[0]);
	}

	// Token: 0x060116E1 RID: 71393 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void PBEPCAPAKLG()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x060116E2 RID: 71394 RVA: 0x005FFCB7 File Offset: 0x005FDEB7
	public void AIIHFEFLHFE(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(13);
		}
		base.BLMHOKPIMOD().PLMAEOHKJPN("_History3Weight", JHOEDACNNKK, new object[1]);
	}

	// Token: 0x060116E3 RID: 71395 RVA: 0x005FFCE4 File Offset: 0x005FDEE4
	public void CPFOEFKOJGA()
	{
		Debug.Log("_CameraClipInfo" + base.GMAHNPNHMFK().JJFEGIOPFGN().name);
		this.isReady = false;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.ACPGHFHDCIP().JFCKAGHNNCA().name));
		base.StartCoroutine(this.DEFNIIHFKFA(jmmilefmacb));
		this.AMCKGGMDLDB();
	}

	// Token: 0x060116E5 RID: 71397 RVA: 0x005FFD47 File Offset: 0x005FDF47
	public void ACPGLLCAEJJ(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("GlassDistortion");
		this.EPHNJNLKJLP();
	}

	// Token: 0x060116E6 RID: 71398 RVA: 0x005FFD59 File Offset: 0x005FDF59
	public void KMNLLCOGHPM(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("CameraFilterPack/FX_DarkMatter");
		this.FIDKCPFLHEB();
	}

	// Token: 0x060116E7 RID: 71399 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnEnable()
	{
	}

	// Token: 0x060116E8 RID: 71400 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void NDAJBJFJGCF()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x060116E9 RID: 71401 RVA: 0x005FFD6C File Offset: 0x005FDF6C
	public void POGJLIDHDIH()
	{
		Debug.Log("_ScreenResolution" + base.CIACEFBNDDJ().owner.name);
		this.isReady = false;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.ACPGHFHDCIP().owner.name));
		base.StartCoroutine(this.AGEDFEIDJIF(jmmilefmacb));
		this.JOAONIBIKNM();
	}

	// Token: 0x060116EA RID: 71402 RVA: 0x0002523B File Offset: 0x0002343B
	private void PAHNKEGFGHB()
	{
	}

	// Token: 0x060116EB RID: 71403 RVA: 0x005FFDCF File Offset: 0x005FDFCF
	public void ONIACAFDJNP()
	{
		this.isReady = (base.GBMJAPGLMGB().JFCKAGHNNCA().GetTeam() == PunTeams.Team.none || true);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	// Token: 0x060116EC RID: 71404 RVA: 0x0002523B File Offset: 0x0002343B
	private void OAKONCDEPPI()
	{
	}

	// Token: 0x060116ED RID: 71405 RVA: 0x005FFE08 File Offset: 0x005FE008
	private IEnumerator EHGNFNCJCMM(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x060116EE RID: 71406 RVA: 0x0002523B File Offset: 0x0002343B
	private void BBKMHAFFIMD()
	{
	}

	// Token: 0x060116EF RID: 71407 RVA: 0x005FFE2A File Offset: 0x005FE02A
	public void PDMHGJNBOKA(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(37);
		}
		base.ACPGHFHDCIP().OKHNMAMFDFD("_SphereSize", JHOEDACNNKK, new object[1]);
	}

	// Token: 0x060116F0 RID: 71408 RVA: 0x005FFE58 File Offset: 0x005FE058
	public void Init()
	{
		Debug.Log("[LobbyPlayerElement] Created lpe for " + base.photonView.owner.name);
		this.isReady = false;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.photonView.owner.name));
		base.StartCoroutine(this.HJFDEEMKFDJ(jmmilefmacb));
		this.CheckIsReady();
	}

	// Token: 0x060116F1 RID: 71409 RVA: 0x0002523B File Offset: 0x0002343B
	private void LNIOFCGDDKP()
	{
	}

	// Token: 0x060116F2 RID: 71410 RVA: 0x005FFEBB File Offset: 0x005FE0BB
	public void LPHFBIAFHIM(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(-35);
		}
		base.IBKCMBIGOEJ().PLMAEOHKJPN("Instrumental", JHOEDACNNKK, new object[0]);
	}

	// Token: 0x060116F3 RID: 71411 RVA: 0x005FFEE8 File Offset: 0x005FE0E8
	public void MDPJHKECLOF()
	{
		Debug.Log("_PColor" + base.BLMHOKPIMOD().JFCKAGHNNCA().name);
		this.isReady = false;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.ACPGHFHDCIP().JFCKAGHNNCA().name));
		base.StartCoroutine(this.EHGNFNCJCMM(jmmilefmacb));
		this.NJDAJMNCPIA();
	}

	// Token: 0x060116F4 RID: 71412 RVA: 0x005FFF4C File Offset: 0x005FE14C
	public void GCNKIJDNPMD()
	{
		Debug.Log("/icon" + base.FFIPLLNKGEN().JFCKAGHNNCA().name);
		this.isReady = true;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.GBMJAPGLMGB().JJFEGIOPFGN().name));
		base.StartCoroutine(this.HJFDEEMKFDJ(jmmilefmacb));
		this.HBIGOLEEFNH();
	}

	// Token: 0x060116F5 RID: 71413 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void JDGFCEPDKAJ()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x060116F6 RID: 71414 RVA: 0x005FFFB0 File Offset: 0x005FE1B0
	private IEnumerator AGEDFEIDJIF(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x060116F7 RID: 71415 RVA: 0x005FFFD2 File Offset: 0x005FE1D2
	public void LLJNCICEJCG(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log(".highscore");
		this.HBIGOLEEFNH();
	}

	// Token: 0x060116F8 RID: 71416 RVA: 0x0002523B File Offset: 0x0002343B
	private void PLNLNCDPPGG()
	{
	}

	// Token: 0x060116F9 RID: 71417 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void BMODOIJGIOO()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x060116FA RID: 71418 RVA: 0x005FFFE4 File Offset: 0x005FE1E4
	public void FFEPLLMAACJ(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("pointBuffer");
		this.FIDKCPFLHEB();
	}

	// Token: 0x060116FB RID: 71419 RVA: 0x005FFFF6 File Offset: 0x005FE1F6
	[PunRPC]
	public void OnReadyClick(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("[LobbyPlayerElement] On ready click");
		this.CheckIsReady();
	}

	// Token: 0x060116FC RID: 71420 RVA: 0x00600008 File Offset: 0x005FE208
	public void JLMPMMFKJID()
	{
		Debug.Log("CameraFilterPack/FX_Hexagon" + base.EOOCGIFFKBG().owner.name);
		this.isReady = true;
		CSteamID jmmilefmacb = new CSteamID(ulong.Parse(base.BLMHOKPIMOD().JFCKAGHNNCA().name));
		base.StartCoroutine(this.MJFFOILDAMG(jmmilefmacb));
		this.ODNIPBPNKIN();
	}

	// Token: 0x060116FD RID: 71421 RVA: 0x0060006B File Offset: 0x005FE26B
	public void SendKickPlayer(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(23);
		}
		base.photonView.RPC("KickThePlayer", JHOEDACNNKK, new object[0]);
	}

	// Token: 0x060116FE RID: 71422 RVA: 0x00600098 File Offset: 0x005FE298
	public void IBLBIFMFFOP()
	{
		CSteamID csteamID = new CSteamID(ulong.Parse(base.EOOCGIFFKBG().owner.name));
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("Set Satellite Lerp Speed") + csteamID.m_SteamID, false);
	}

	// Token: 0x060116FF RID: 71423 RVA: 0x006000EC File Offset: 0x005FE2EC
	[PunRPC]
	private void KickThePlayer()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("LobbyCanvas").gameObject.SetActive(false);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(true);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#kicked", "#ok", null, true, false, 0f);
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	// Token: 0x06011700 RID: 71424 RVA: 0x0060014A File Offset: 0x005FE34A
	public void FPLIFINHHIN(PhotonPlayer JHOEDACNNKK)
	{
		if (JHOEDACNNKK == PhotonNetwork.player)
		{
			Helpers.ObtainAchievement(76);
		}
		base.BLMHOKPIMOD().OILIKMGIHFL("Image", JHOEDACNNKK, new object[0]);
	}

	// Token: 0x06011701 RID: 71425 RVA: 0x00600175 File Offset: 0x005FE375
	public void JOAONIBIKNM()
	{
		this.isReady = (base.GMAHNPNHMFK().owner.GetTeam() == PunTeams.Team.none || true);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
	}

	// Token: 0x06011702 RID: 71426 RVA: 0x006001AD File Offset: 0x005FE3AD
	public void DCAIMAJDBHL(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("_Value2");
		this.EPHNJNLKJLP();
	}

	// Token: 0x06011703 RID: 71427 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCHMKJKBAPI()
	{
	}

	// Token: 0x06011704 RID: 71428 RVA: 0x005FF43A File Offset: 0x005FD63A
	private void DDBOODLPCAM()
	{
		this.readyCanvas.SetActive(this.isReady);
		this.removeButton.SetActive(PhotonNetwork.isMasterClient);
	}

	// Token: 0x06011705 RID: 71429 RVA: 0x006001BF File Offset: 0x005FE3BF
	public void EPHNJNLKJLP()
	{
		this.isReady = (base.OELHGNKAMEG().JJFEGIOPFGN().GetTeam() == PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	// Token: 0x06011706 RID: 71430 RVA: 0x006001F7 File Offset: 0x005FE3F7
	public void AMCKGGMDLDB()
	{
		this.isReady = (base.EDIJKHEMPAD().JJFEGIOPFGN().GetTeam() != PunTeams.Team.none);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	// Token: 0x06011707 RID: 71431 RVA: 0x0060022F File Offset: 0x005FE42F
	public void BMOFBBJDOPM()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.SendKickPlayer(base.FFIPLLNKGEN().JJFEGIOPFGN());
		}
	}

	// Token: 0x06011708 RID: 71432 RVA: 0x0060024C File Offset: 0x005FE44C
	public void HIELBNIEKIH(PhotonPlayer DNFGMNFCBGA)
	{
		Debug.Log("EventTimeInputField");
		this.AMCKGGMDLDB();
	}

	// Token: 0x06011709 RID: 71433 RVA: 0x00600260 File Offset: 0x005FE460
	private void PKLOBJHKFEO()
	{
		if (!base.FFIPLLNKGEN().BGJKMGJBPFA())
		{
			base.transform.SetParent(((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().playersScrollRectContent.transform);
			base.transform.localScale = new Vector3(1644f, 1436f, 964f);
			this.LHIEKHPLMFI();
		}
	}

	// Token: 0x0601170A RID: 71434 RVA: 0x006002C8 File Offset: 0x005FE4C8
	private IEnumerator MJFFOILDAMG(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, false);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield break;
	}

	// Token: 0x0601170B RID: 71435 RVA: 0x006002EC File Offset: 0x005FE4EC
	private void EJDACNFJPFK()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("<scene_name> or <id>").gameObject.SetActive(true);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.LKFALPEABHP("id", "CameraFilterPack/RainFX", null, true, false, 1270f);
		Singleton<MultiplayerSystem>.Instance.HKFKGLGIIOH();
	}

	// Token: 0x0601170C RID: 71436 RVA: 0x0060034C File Offset: 0x005FE54C
	private void JBJNGOGGDMP()
	{
		PhotonNetwork.LeaveRoom();
		GameObject.Find("B").gameObject.SetActive(false);
		UnityEngine.Object.FindObjectOfType<NetworkMenu>().networkCanvas.SetActive(false);
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("Share", "_TimeX", null, false, false, 244f);
		Singleton<MultiplayerSystem>.Instance.APEDOOJPKFC();
	}

	// Token: 0x0601170D RID: 71437 RVA: 0x006003AA File Offset: 0x005FE5AA
	public void KOJLLDBMPJB()
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.LPHFBIAFHIM(base.EDIJKHEMPAD().JJFEGIOPFGN());
		}
	}

	// Token: 0x0601170E RID: 71438 RVA: 0x006003C7 File Offset: 0x005FE5C7
	public void GBBBHJHBOFH()
	{
		this.isReady = (base.ACPGHFHDCIP().owner.GetTeam() != PunTeams.Team.none && false);
		((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().NPAELKPFIKP();
	}

	// Token: 0x04001EDE RID: 7902
	public GameObject readyCanvas;

	// Token: 0x04001EDF RID: 7903
	public Text nicknameText;

	// Token: 0x04001EE0 RID: 7904
	public Image bg;

	// Token: 0x04001EE1 RID: 7905
	public Image icon;

	// Token: 0x04001EE2 RID: 7906
	public bool isReady;

	// Token: 0x04001EE3 RID: 7907
	public GameObject removeButton;

	// Token: 0x04001EE4 RID: 7908
	public GameObject contributorGO;
}
