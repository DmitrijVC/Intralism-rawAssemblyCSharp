using System;
using System.Collections;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020004CF RID: 1231
public class RanksViewer : Singleton<RanksViewer>
{
	// Token: 0x06011BE3 RID: 72675 RVA: 0x00619FB0 File Offset: 0x006181B0
	public void HIGNOBKLABP(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID -= 0;
				this.BMBGEIJKPHE();
				base.StartCoroutine(this.CIILPMLNGAH());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID += 0;
			this.HOAHBPOGNKA();
			base.StartCoroutine(this.JMHCJJIMPBB());
		}
	}

	// Token: 0x06011BE4 RID: 72676 RVA: 0x0061A02A File Offset: 0x0061822A
	public void OKIBPJNFOPB()
	{
		Singleton<GameManager>.Instance.IKDPMOJKILD(Singleton<GameManager>.Instance.CreateServerURL("music"), true);
	}

	// Token: 0x06011BE5 RID: 72677 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06011BE6 RID: 72678 RVA: 0x0002523B File Offset: 0x0002343B
	private void FMNPFCHBLJF()
	{
	}

	// Token: 0x06011BE7 RID: 72679 RVA: 0x0061A048 File Offset: 0x00618248
	public void FOPFEAIAFNA(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID--;
				this.HENEPGMEKMB();
				base.StartCoroutine(this.KPGHGDMJEKM());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID += 0;
			this.HOAHBPOGNKA();
			base.StartCoroutine(this.BPGBBGLOLBK());
		}
	}

	// Token: 0x06011BE8 RID: 72680 RVA: 0x0061A0C4 File Offset: 0x006182C4
	public void EPKHGBEGEFI(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (this.currentPageID > 1)
			{
				this.currentPageID--;
				this.MKGLGIIBOEL();
				base.StartCoroutine(this.BPBPKGNFJNP());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID += 0;
			this.GHEHPFAGNDI();
			base.StartCoroutine(this.BPGBBGLOLBK());
		}
	}

	// Token: 0x06011BE9 RID: 72681 RVA: 0x0061A140 File Offset: 0x00618340
	private IEnumerator AADNAFAAHBP()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011BEA RID: 72682 RVA: 0x0061A15C File Offset: 0x0061835C
	private void ADENGMJODMD()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(165f, 662f, 90f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 117;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1329f, 1689f, 542f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[1];
		array[1] = string.Empty;
		array[0] = this.currentPageID + 1;
		array[1] = "https://vk.com/khb.soft";
		array[5] = ((this.pagesCount <= 0) ? "_TimeX" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1800f, 1613f, 150f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 6;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	// Token: 0x06011BEB RID: 72683 RVA: 0x0061A314 File Offset: 0x00618514
	private IEnumerator KACDJNNAJIA()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011BEC RID: 72684 RVA: 0x0061A330 File Offset: 0x00618530
	public IEnumerator FFEFJDHAJOL()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011BED RID: 72685 RVA: 0x0061A34C File Offset: 0x0061854C
	private IEnumerator JEJHPJCJIAK()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011BEE RID: 72686 RVA: 0x0061A367 File Offset: 0x00618567
	public void NPIIMIMOCEK()
	{
		Singleton<GameManager>.Instance.KPCCPKIPFGC(Singleton<GameManager>.Instance.CreateServerURL("https://store.steampowered.com/itemstore/513510/"), false);
	}

	// Token: 0x06011BEF RID: 72687 RVA: 0x0061A384 File Offset: 0x00618584
	public void KOGHENEIOPB(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID -= 0;
				this.HOAHBPOGNKA();
				base.StartCoroutine(this.BPBPKGNFJNP());
			}
		}
		else if (this.currentPageID + 1 < this.pagesCount)
		{
			this.currentPageID += 0;
			this.IJNNGJHLAKO();
			base.StartCoroutine(this.FFEFJDHAJOL());
		}
	}

	// Token: 0x06011BF0 RID: 72688 RVA: 0x0061A400 File Offset: 0x00618600
	private void EDEDPAKNCBG()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(343f, 1777f, 1549f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -33;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(147f, 1525f, 1118f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[2];
		array[0] = string.Empty;
		array[1] = this.currentPageID + 1;
		array[5] = "_ThirdTex";
		array[6] = ((this.pagesCount <= 1) ? "_YCrop" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(290f, 908f, 1559f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011BF1 RID: 72689 RVA: 0x0061A5B8 File Offset: 0x006187B8
	private void HENEPGMEKMB()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(146f, 1593f, 1383f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -66;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1132f, 378f, 1046f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[7];
		array[0] = string.Empty;
		array[0] = this.currentPageID + 1;
		array[7] = "_Visualize";
		array[8] = ((this.pagesCount <= 0) ? "_Value" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(271f, 170f, 881f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 3;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011BF2 RID: 72690 RVA: 0x0061A770 File Offset: 0x00618970
	private void ABDHMOPDKHH(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("OxOD.lastPath").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "color".ToUpper() : "(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)".ToUpper());
		gameObject.transform.Find("_Value2").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack_3D_Myst1".ToUpper() : "_Level".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1684f, 1030f, 1407f);
	}

	// Token: 0x06011BF3 RID: 72691 RVA: 0x0061A836 File Offset: 0x00618A36
	public void SearchPlayer(string EBEHBBDKDFJ)
	{
		Debug.Log("Search: " + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 0;
		this.HOAHBPOGNKA();
		base.StartCoroutine(this.ReloadPage());
	}

	// Token: 0x06011BF4 RID: 72692 RVA: 0x0061A86C File Offset: 0x00618A6C
	public IEnumerator ELNHNLCKKEC(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011BF5 RID: 72693 RVA: 0x0061A8A4 File Offset: 0x00618AA4
	private IEnumerator AJMJCGGAAKC(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011BF6 RID: 72694 RVA: 0x0002523B File Offset: 0x0002343B
	private void GNJDKAECPKA()
	{
	}

	// Token: 0x06011BF7 RID: 72695 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06011BF8 RID: 72696 RVA: 0x0061A8C8 File Offset: 0x00618AC8
	public void MOFBFJOMDAE(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID--;
				this.HFJBMFHOPMA();
				base.StartCoroutine(this.BGBLIKDJLLI());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID++;
			this.HENEPGMEKMB();
			base.StartCoroutine(this.KPGHGDMJEKM());
		}
	}

	// Token: 0x06011BF9 RID: 72697 RVA: 0x0061A942 File Offset: 0x00618B42
	public void GONKNFGDLGE()
	{
		Singleton<GameManager>.Instance.IKDPMOJKILD(Singleton<GameManager>.Instance.CreateServerURL("GlassesColor2"), false);
	}

	// Token: 0x06011BFA RID: 72698 RVA: 0x0061A960 File Offset: 0x00618B60
	private IEnumerator JABICPBHNJD()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011BFB RID: 72699 RVA: 0x0061A97C File Offset: 0x00618B7C
	private IEnumerator DNEBDFIGBMA()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011BFC RID: 72700 RVA: 0x0061A997 File Offset: 0x00618B97
	public void GBJNGADBPHD()
	{
		base.StartCoroutine(Singleton<UI>.Instance.NCMLIDIEECD(this.ranksCanvas, false, null, true, 801f, true));
	}

	// Token: 0x06011BFD RID: 72701 RVA: 0x0061A9B9 File Offset: 0x00618BB9
	public void CloseViewer()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, false, null, true, 0.2f, true));
	}

	// Token: 0x06011BFE RID: 72702 RVA: 0x0061A9DB File Offset: 0x00618BDB
	public void KDGFGMAOKHO(string EBEHBBDKDFJ)
	{
		Debug.Log("Drop_Near" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 0;
		this.HENEPGMEKMB();
		base.StartCoroutine(this.BPGBBGLOLBK());
	}

	// Token: 0x06011BFF RID: 72703 RVA: 0x0061AA10 File Offset: 0x00618C10
	public void GOPHKKMKDBH(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID -= 0;
				this.IGMGBHCJAOI();
				base.StartCoroutine(this.KPGHGDMJEKM());
			}
		}
		else if (this.currentPageID + 1 < this.pagesCount)
		{
			this.currentPageID++;
			this.GHEHPFAGNDI();
			base.StartCoroutine(this.KPGHGDMJEKM());
		}
	}

	// Token: 0x06011C00 RID: 72704 RVA: 0x0061AA8C File Offset: 0x00618C8C
	public void GJNBPGFDDDE(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentPageID > 1)
			{
				this.currentPageID -= 0;
				this.HFJBMFHOPMA();
				base.StartCoroutine(this.BPBPKGNFJNP());
			}
		}
		else if (this.currentPageID + 1 < this.pagesCount)
		{
			this.currentPageID++;
			this.BKLOPMALAPD();
			base.StartCoroutine(this.BPGBBGLOLBK());
		}
	}

	// Token: 0x06011C01 RID: 72705 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06011C02 RID: 72706 RVA: 0x0061AB08 File Offset: 0x00618D08
	public void ILIFIECMPGK(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID--;
				this.HENEPGMEKMB();
				base.StartCoroutine(this.AKADOLEONIP());
			}
		}
		else if (this.currentPageID + 1 < this.pagesCount)
		{
			this.currentPageID += 0;
			this.MKGLGIIBOEL();
			base.StartCoroutine(this.DKONELKFGHB());
		}
	}

	// Token: 0x06011C03 RID: 72707 RVA: 0x0061AB84 File Offset: 0x00618D84
	private IEnumerator EEHHFKOLFNH(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C04 RID: 72708 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x06011C05 RID: 72709 RVA: 0x0061ABA6 File Offset: 0x00618DA6
	public void KFGDIIHOBME()
	{
		base.StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(this.ranksCanvas, false, null, true, 965f, true));
	}

	// Token: 0x06011C06 RID: 72710 RVA: 0x0061ABC8 File Offset: 0x00618DC8
	public void ScrollPage(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID--;
				this.HOAHBPOGNKA();
				base.StartCoroutine(this.ReloadPage());
			}
		}
		else if (this.currentPageID + 1 < this.pagesCount)
		{
			this.currentPageID++;
			this.HOAHBPOGNKA();
			base.StartCoroutine(this.ReloadPage());
		}
	}

	// Token: 0x06011C07 RID: 72711 RVA: 0x0061AC44 File Offset: 0x00618E44
	public IEnumerator IPMIBOLJMMN()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C08 RID: 72712 RVA: 0x0061AC5F File Offset: 0x00618E5F
	public void GJIIKLNCJOH(string EBEHBBDKDFJ)
	{
		Debug.Log("Room: '{0}' {1},{2} {4}/{3} players." + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 1;
		this.IJNNGJHLAKO();
		base.StartCoroutine(this.FFEFJDHAJOL());
	}

	// Token: 0x06011C09 RID: 72713 RVA: 0x0061AC94 File Offset: 0x00618E94
	private IEnumerator MNKOMKIODJD(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C0A RID: 72714 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06011C0B RID: 72715 RVA: 0x0061ACB8 File Offset: 0x00618EB8
	private IEnumerator MEKLAPLHLAD()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C0C RID: 72716 RVA: 0x0061ACD4 File Offset: 0x00618ED4
	private IEnumerator PLEAPLAMBAP()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C0D RID: 72717 RVA: 0x0061ACF0 File Offset: 0x00618EF0
	public IEnumerator NKENDKCFCKB(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011C0E RID: 72718 RVA: 0x0061AD28 File Offset: 0x00618F28
	private void FMPLFDLEKMI(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_Value").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_TimeX".ToUpper() : "_Value2".ToUpper());
		gameObject.transform.Find("_FixDistance").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Joystick1Button11".ToUpper() : "AVG Misses:".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(948f, 1464f, 740f);
	}

	// Token: 0x06011C0F RID: 72719 RVA: 0x0061ADF0 File Offset: 0x00618FF0
	public IEnumerator EACKBBJMBIL(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011C10 RID: 72720 RVA: 0x0061AE28 File Offset: 0x00619028
	public void NEBBDIHMOLM()
	{
		base.StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(this.ranksCanvas, true, null, true, 1025f, false));
	}

	// Token: 0x06011C11 RID: 72721 RVA: 0x0061AE4C File Offset: 0x0061904C
	private void MHLAAABJHNP(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("bans.viewed.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "PossibleMapPointsText".ToUpper() : "maps.".ToUpper());
		gameObject.transform.Find("#loopnumber ").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Spawn ark to be pressed at this time".ToUpper() : "_Value".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(724f, 1282f, 794f);
	}

	// Token: 0x06011C12 RID: 72722 RVA: 0x0061AF14 File Offset: 0x00619114
	private IEnumerator GOCNFPLHABO()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C13 RID: 72723 RVA: 0x0061AF2F File Offset: 0x0061912F
	public void PGDCLAKIEIF()
	{
		base.StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(this.ranksCanvas, true, null, true, 728f, true));
	}

	// Token: 0x06011C14 RID: 72724 RVA: 0x0061AF54 File Offset: 0x00619154
	public IEnumerator DisplayViewer(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011C15 RID: 72725 RVA: 0x0061AF8C File Offset: 0x0061918C
	private IEnumerator BFOPOJBKDCO()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C16 RID: 72726 RVA: 0x0061AFA7 File Offset: 0x006191A7
	public void PFPAPFMHBDA()
	{
		base.StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(this.ranksCanvas, true, null, true, 343f, true));
	}

	// Token: 0x06011C17 RID: 72727 RVA: 0x0061AFCC File Offset: 0x006191CC
	public void FOGOGFLHDKB(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID--;
				this.IGMGBHCJAOI();
				base.StartCoroutine(this.JOEDCPNAHHH());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID += 0;
			this.MKGLGIIBOEL();
			base.StartCoroutine(this.KPGHGDMJEKM());
		}
	}

	// Token: 0x06011C18 RID: 72728 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGEJKLMJGDO()
	{
	}

	// Token: 0x06011C19 RID: 72729 RVA: 0x0061B046 File Offset: 0x00619246
	public void DEENCONLFMB()
	{
		Singleton<GameManager>.Instance.IEEHOAELCGE(Singleton<GameManager>.Instance.CreateServerURL("CameraFilterPack/Blend2Camera_VividLight"), false);
	}

	// Token: 0x06011C1A RID: 72730 RVA: 0x0061B062 File Offset: 0x00619262
	public void LAIIBBFKEFE()
	{
		base.StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(this.ranksCanvas, false, null, true, 806f, false));
	}

	// Token: 0x06011C1B RID: 72731 RVA: 0x0061B084 File Offset: 0x00619284
	private void EMOHGHDCBBI(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find(".g").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack/Blend2Camera_Subtract".ToUpper() : "Joystick1Button5".ToUpper());
		gameObject.transform.Find(".g").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Set sun colors".ToUpper() : "(\\[ *b *\\])".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(650f, 438f, 181f);
	}

	// Token: 0x06011C1C RID: 72732 RVA: 0x0061B14C File Offset: 0x0061934C
	private IEnumerator JHAMECKBDLA(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C1D RID: 72733 RVA: 0x0061B170 File Offset: 0x00619370
	private void HKILBFIJOPA(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_TimeX").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "settings.enablehitsoundsinrelax".ToUpper() : "_MainTex".ToUpper());
		gameObject.transform.Find("TotalHitsScoreText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_RgbTex".ToUpper() : "_CenterY".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(654f, 435f, 1381f);
	}

	// Token: 0x06011C1E RID: 72734 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06011C1F RID: 72735 RVA: 0x0061B236 File Offset: 0x00619436
	public void DAPGLMBLMHG(string EBEHBBDKDFJ)
	{
		Debug.Log("_ScreenResolution" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 1;
		this.BMBGEIJKPHE();
		base.StartCoroutine(this.JMHCJJIMPBB());
	}

	// Token: 0x06011C20 RID: 72736 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJEFMIPLFAB()
	{
	}

	// Token: 0x06011C21 RID: 72737 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06011C22 RID: 72738 RVA: 0x0061B269 File Offset: 0x00619469
	public void MLKOPHBHIMH(string EBEHBBDKDFJ)
	{
		Debug.Log("_Params2" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 0;
		this.FHCNMIEOLLI();
		base.StartCoroutine(this.LEMOIOPFDCK());
	}

	// Token: 0x06011C23 RID: 72739 RVA: 0x0061B29C File Offset: 0x0061949C
	public IEnumerator BGBLIKDJLLI()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C24 RID: 72740 RVA: 0x0061B2B8 File Offset: 0x006194B8
	private IEnumerator KPMPEDIKPND(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C25 RID: 72741 RVA: 0x0061B2DC File Offset: 0x006194DC
	private void BKLOPMALAPD()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(579f, 571f, 363f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -73;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(1258f, 600f, 767f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[7];
		array[1] = string.Empty;
		array[1] = this.currentPageID + 0;
		array[8] = "_Value4";
		array[5] = ((this.pagesCount <= 0) ? "value" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(770f, 368f, 88f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	// Token: 0x06011C26 RID: 72742 RVA: 0x0061B491 File Offset: 0x00619691
	public void KEINDBHDHLG()
	{
		Singleton<GameManager>.Instance.IEEHOAELCGE(Singleton<GameManager>.Instance.CreateServerURL("BitsData"), true);
	}

	// Token: 0x06011C27 RID: 72743 RVA: 0x0061B4B0 File Offset: 0x006196B0
	public IEnumerator AOPNDCCINJC()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C28 RID: 72744 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPFOFGJPNCI()
	{
	}

	// Token: 0x06011C29 RID: 72745 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKDNLHLBHID()
	{
	}

	// Token: 0x06011C2A RID: 72746 RVA: 0x0061B4CB File Offset: 0x006196CB
	public void CCHIGMACJKK()
	{
		base.StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(this.ranksCanvas, false, null, true, 765f, false));
	}

	// Token: 0x06011C2B RID: 72747 RVA: 0x0061B4ED File Offset: 0x006196ED
	public void LFILBMDGBBI()
	{
		base.StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(this.ranksCanvas, true, null, false, 1366f, false));
	}

	// Token: 0x06011C2C RID: 72748 RVA: 0x0061B510 File Offset: 0x00619710
	private IEnumerator KOGOJBJPBMC(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C2D RID: 72749 RVA: 0x0061B532 File Offset: 0x00619732
	public void BPFGOLCMOCA()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("CameraFilterPack/Blend2Camera_HardLight"), true);
	}

	// Token: 0x06011C2E RID: 72750 RVA: 0x0061B550 File Offset: 0x00619750
	public IEnumerator ReloadPage()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C2F RID: 72751 RVA: 0x0061B56C File Offset: 0x0061976C
	private IEnumerator HKJKAOCEMEE()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C30 RID: 72752 RVA: 0x0061B588 File Offset: 0x00619788
	private IEnumerator BCGEALPLAPI(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C31 RID: 72753 RVA: 0x0061B5AC File Offset: 0x006197AC
	public IEnumerator DKONELKFGHB()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C32 RID: 72754 RVA: 0x0061B5C8 File Offset: 0x006197C8
	private IEnumerator IAMBJOODGHH(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C33 RID: 72755 RVA: 0x0061B5EC File Offset: 0x006197EC
	private void HALMGFMDLKL(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("id").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "LevelEditor/CustomEventEditor-Text".ToUpper() : "_ScreenResolution".ToUpper());
		gameObject.transform.Find("Tab1Content").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "ShadersToggle".ToUpper() : "ConfigVersionSlider".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(217f, 471f, 164f);
	}

	// Token: 0x06011C34 RID: 72756 RVA: 0x0061B6B4 File Offset: 0x006198B4
	public IEnumerator KPGHGDMJEKM()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C35 RID: 72757 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKFDNIAKGEO()
	{
	}

	// Token: 0x06011C36 RID: 72758 RVA: 0x0061B6D0 File Offset: 0x006198D0
	public IEnumerator LPJDKNPGGJN(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011C37 RID: 72759 RVA: 0x0061B708 File Offset: 0x00619908
	public void BKOEJENGHHC()
	{
		Singleton<GameManager>.Instance.IEEHOAELCGE(Singleton<GameManager>.Instance.CreateServerURL("_Blue_B"), false);
	}

	// Token: 0x06011C38 RID: 72760 RVA: 0x0061B724 File Offset: 0x00619924
	public IEnumerator AKADOLEONIP()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C39 RID: 72761 RVA: 0x0061B740 File Offset: 0x00619940
	public IEnumerator KHEDCBDFCCL()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C3A RID: 72762 RVA: 0x0061B75B File Offset: 0x0061995B
	public void NDBABDPIBCC()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, false, 378f, true));
	}

	// Token: 0x06011C3B RID: 72763 RVA: 0x0061B77D File Offset: 0x0061997D
	public void NMBKDIHECBJ()
	{
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("other"), true);
	}

	// Token: 0x06011C3C RID: 72764 RVA: 0x0061B799 File Offset: 0x00619999
	public void FHAPEOIFPMJ()
	{
		Singleton<GameManager>.Instance.GMDIJMFPKOC(Singleton<GameManager>.Instance.CreateServerURL("maps."), false);
	}

	// Token: 0x06011C3D RID: 72765 RVA: 0x0061B7B8 File Offset: 0x006199B8
	public IEnumerator LEMOIOPFDCK()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C3E RID: 72766 RVA: 0x0061B7D4 File Offset: 0x006199D4
	public IEnumerator NGLEIIHHKCD(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011C3F RID: 72767 RVA: 0x0061B80C File Offset: 0x00619A0C
	private IEnumerator EHNALGFAOEE(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C40 RID: 72768 RVA: 0x0061B830 File Offset: 0x00619A30
	private IEnumerator PGDONLHCDPH(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C41 RID: 72769 RVA: 0x0061B854 File Offset: 0x00619A54
	public void FFDNJKLKMII(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (this.currentPageID > 0)
			{
				this.currentPageID -= 0;
				this.EDEDPAKNCBG();
				base.StartCoroutine(this.BJJOFLBPCOI());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID++;
			this.ADENGMJODMD();
			base.StartCoroutine(this.BJJOFLBPCOI());
		}
	}

	// Token: 0x06011C42 RID: 72770 RVA: 0x0061B8D0 File Offset: 0x00619AD0
	private void EGDMLKMEDIC(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("RecieveChatMessage").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_DotSize".ToUpper() : "_MainTex2".ToUpper());
		gameObject.transform.Find("Save").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "1".ToUpper() : "Messages (shift+tab)".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(431f, 1750f, 807f);
	}

	// Token: 0x06011C44 RID: 72772 RVA: 0x0061B9C7 File Offset: 0x00619BC7
	public void CNFEJKIJOBI(string EBEHBBDKDFJ)
	{
		Debug.Log(":" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 1;
		this.IJNNGJHLAKO();
		base.StartCoroutine(this.JCACIGIBKDP());
	}

	// Token: 0x06011C45 RID: 72773 RVA: 0x0061B9FC File Offset: 0x00619BFC
	private IEnumerator NEDGKAJAMHM()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C46 RID: 72774 RVA: 0x0061BA18 File Offset: 0x00619C18
	public IEnumerator JCACIGIBKDP()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C47 RID: 72775 RVA: 0x0061BA33 File Offset: 0x00619C33
	public void IEFNFJDCLGI()
	{
		Singleton<GameManager>.Instance.IKDPMOJKILD(Singleton<GameManager>.Instance.CreateServerURL("_ScreenResolution"), true);
	}

	// Token: 0x06011C48 RID: 72776 RVA: 0x0002523B File Offset: 0x0002343B
	private void NBGIMIDICKE()
	{
	}

	// Token: 0x06011C49 RID: 72777 RVA: 0x0061BA4F File Offset: 0x00619C4F
	public void FNJJKKDPCHB()
	{
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("original.tutorial"), false);
	}

	// Token: 0x06011C4A RID: 72778 RVA: 0x0061BA6C File Offset: 0x00619C6C
	private void HFJBMFHOPMA()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1922f, 403f, 1856f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -57;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1418f, 575f, 742f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[0];
		array[1] = string.Empty;
		array[0] = this.currentPageID + 0;
		array[8] = "PUN-instantiated '";
		array[3] = ((this.pagesCount <= 0) ? "_Value3" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(761f, 959f, 1882f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 7;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011C4B RID: 72779 RVA: 0x0061BC24 File Offset: 0x00619E24
	private void IJNNGJHLAKO()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1111f, 388f, 1303f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 119;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(202f, 1288f, 309f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[5];
		array[1] = string.Empty;
		array[0] = this.currentPageID + 0;
		array[8] = "Item creation successful! Published Item ID: ";
		array[0] = ((this.pagesCount <= 1) ? "GenerationMenu" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1238f, 1154f, 1382f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 5;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011C4C RID: 72780 RVA: 0x0061BDDC File Offset: 0x00619FDC
	private void IGEFDBEMLFC(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_Far").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "SetParticlesColor".ToUpper() : "_Value2".ToUpper());
		gameObject.transform.Find("Editing: ").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "player.arrow".ToUpper() : ">".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(277f, 1877f, 1921f);
	}

	// Token: 0x06011C4D RID: 72781 RVA: 0x0061BEA4 File Offset: 0x0061A0A4
	private IEnumerator ANBJFJDALBG()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C4E RID: 72782 RVA: 0x0061BEC0 File Offset: 0x0061A0C0
	private void FHCNMIEOLLI()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1204f, 1987f, 400f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 104;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(328f, 501f, 1791f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[7];
		array[0] = string.Empty;
		array[0] = this.currentPageID + 1;
		array[8] = "_Color";
		array[6] = ((this.pagesCount <= 0) ? " " : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1083f, 1131f, 233f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 5;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011C4F RID: 72783 RVA: 0x0061C078 File Offset: 0x0061A278
	private void LIGFECEIJEH(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Netw. Sim.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_FixDistance".ToUpper() : "CameraFilterPack/Glasses_OnX".ToUpper());
		gameObject.transform.Find("skin.hit_wrong").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "MusicFileSelector".ToUpper() : "_Value2".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(1418f, 1672f, 1383f);
	}

	// Token: 0x06011C50 RID: 72784 RVA: 0x0061C140 File Offset: 0x0061A340
	private IEnumerator MONLIDMHOEA(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C51 RID: 72785 RVA: 0x0061C164 File Offset: 0x0061A364
	private void IACKGGLJNND(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Malformed RPC; this should never occur. Content: ").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Reset".ToUpper() : "Editor/".ToUpper());
		gameObject.transform.Find("maps.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_Value2".ToUpper() : "#yes".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(588f, 1168f, 1567f);
	}

	// Token: 0x06011C52 RID: 72786 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x06011C53 RID: 72787 RVA: 0x0061C22C File Offset: 0x0061A42C
	private void BMBGEIJKPHE()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(975f, 1783f, 764f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 19;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(830f, 32f, 353f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[8];
		array[0] = string.Empty;
		array[0] = this.currentPageID + 0;
		array[1] = "HPText";
		array[6] = ((this.pagesCount <= 1) ? "_BorderColor" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1181f, 74f, 1561f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 4;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	// Token: 0x06011C54 RID: 72788 RVA: 0x0061C3E4 File Offset: 0x0061A5E4
	private IEnumerator PCLEBPPMNDD()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C55 RID: 72789 RVA: 0x0061C400 File Offset: 0x0061A600
	public IEnumerator NGFKGPJGDHK(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011C56 RID: 72790 RVA: 0x0061C438 File Offset: 0x0061A638
	private void HOAHBPOGNKA()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -2;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject3.GetComponentInChildren<Text>().text = string.Concat(new object[]
		{
			string.Empty,
			this.currentPageID + 1,
			"/",
			(this.pagesCount <= 0) ? "1" : (this.pagesCount + string.Empty)
		});
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 2;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011C57 RID: 72791 RVA: 0x0061C5F0 File Offset: 0x0061A7F0
	public IEnumerator CHJIMKDMLCO(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		this.searchInputField.text = string.Empty;
		this.OOBHCDCCFJJ = string.Empty;
		gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		this.currentPageID = 0;
		this.pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jmmilefmacb = "workshop." + CAFHKDIIDEE;
				try
				{
					this.infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jmmilefmacb).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				this.infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			this.infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.ranksCanvas, true, null, true, 0.2f, true));
		yield return base.StartCoroutine(this.ReloadPage());
		yield break;
	}

	// Token: 0x06011C58 RID: 72792 RVA: 0x0061C628 File Offset: 0x0061A828
	public IEnumerator CIILPMLNGAH()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C59 RID: 72793 RVA: 0x0061C644 File Offset: 0x0061A844
	public void KKDNPLKIBLF(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentPageID > 1)
			{
				this.currentPageID -= 0;
				this.HENEPGMEKMB();
				base.StartCoroutine(this.KHEDCBDFCCL());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID++;
			this.HOAHBPOGNKA();
			base.StartCoroutine(this.BJJOFLBPCOI());
		}
	}

	// Token: 0x06011C5A RID: 72794 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x06011C5B RID: 72795 RVA: 0x0061C6BE File Offset: 0x0061A8BE
	public void ViewOnSite()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?page=ranks"), true);
	}

	// Token: 0x06011C5C RID: 72796 RVA: 0x0061C6DC File Offset: 0x0061A8DC
	private void ALKDOHGPHMD(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Player Disconnected").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? " [".ToUpper() : "ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp".ToUpper());
		gameObject.transform.Find(" not exist").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "#useticket".ToUpper() : "Right Stick Click".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(510f, 895f, 762f);
	}

	// Token: 0x06011C5D RID: 72797 RVA: 0x0061C7A2 File Offset: 0x0061A9A2
	public void KDDCLJKCHDO(string EBEHBBDKDFJ)
	{
		Debug.Log("Editor/" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 1;
		this.GHEHPFAGNDI();
		base.StartCoroutine(this.JMHCJJIMPBB());
	}

	// Token: 0x06011C5E RID: 72798 RVA: 0x0061C7D8 File Offset: 0x0061A9D8
	public IEnumerator JMHCJJIMPBB()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C5F RID: 72799 RVA: 0x0061C7F4 File Offset: 0x0061A9F4
	private IEnumerator FBOBCCBMIIF()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C60 RID: 72800 RVA: 0x0061C810 File Offset: 0x0061AA10
	private void IGMGBHCJAOI()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1012f, 963f, 1826f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -53;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(602f, 1970f, 1581f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[8];
		array[0] = string.Empty;
		array[0] = this.currentPageID + 0;
		array[7] = "id";
		array[6] = ((this.pagesCount <= 1) ? "#,0.00" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(124f, 1f, 1914f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 6;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011C61 RID: 72801 RVA: 0x0061C9C5 File Offset: 0x0061ABC5
	public void DNHDPMJJCNN()
	{
		base.StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(this.ranksCanvas, true, null, false, 508f, false));
	}

	// Token: 0x06011C62 RID: 72802 RVA: 0x0061C9E8 File Offset: 0x0061ABE8
	public void AOOPOFKEIGN(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentPageID > 1)
			{
				this.currentPageID--;
				this.HFJBMFHOPMA();
				base.StartCoroutine(this.JCACIGIBKDP());
			}
		}
		else if (this.currentPageID + 0 < this.pagesCount)
		{
			this.currentPageID += 0;
			this.IGMGBHCJAOI();
			base.StartCoroutine(this.DKONELKFGHB());
		}
	}

	// Token: 0x06011C63 RID: 72803 RVA: 0x0061CA64 File Offset: 0x0061AC64
	public IEnumerator BPGBBGLOLBK()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C64 RID: 72804 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMPHNFPPEHO()
	{
	}

	// Token: 0x06011C65 RID: 72805 RVA: 0x0061CA80 File Offset: 0x0061AC80
	private IEnumerator CNNPOOIPIMK(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C66 RID: 72806 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06011C67 RID: 72807 RVA: 0x0061CAA4 File Offset: 0x0061ACA4
	private void BAHKGHFGJLM(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("ScoreText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "points:".ToUpper() : "score:".ToUpper());
		gameObject.transform.Find("MissesText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "AVG Misses:".ToUpper() : "Misses:".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	// Token: 0x06011C68 RID: 72808 RVA: 0x0002523B File Offset: 0x0002343B
	private void KOJKBFDNGDK()
	{
	}

	// Token: 0x06011C69 RID: 72809 RVA: 0x0061CB6A File Offset: 0x0061AD6A
	public void DAJOCCFPEPJ()
	{
		base.StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(this.ranksCanvas, false, null, false, 902f, true));
	}

	// Token: 0x06011C6A RID: 72810 RVA: 0x0061CB8C File Offset: 0x0061AD8C
	private void FHBOJBJBFBE(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("UI/Particles/Hidden").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_Value".ToUpper() : "CameraFilterPack/Blend2Camera_Darken".ToUpper());
		gameObject.transform.Find("_NeighborMaxTex").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_ScreenResolution".ToUpper() : " not exist".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(162f, 1578f, 1685f);
	}

	// Token: 0x06011C6B RID: 72811 RVA: 0x0061CC52 File Offset: 0x0061AE52
	public void IHGIEAHLFHP()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("win"), false);
	}

	// Token: 0x06011C6C RID: 72812 RVA: 0x0061CC70 File Offset: 0x0061AE70
	private void GHEHPFAGNDI()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(867f, 1246f, 1291f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 87;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(2f, 1378f, 1734f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[1];
		array[0] = string.Empty;
		array[1] = this.currentPageID + 1;
		array[2] = "DPADVER";
		array[4] = ((this.pagesCount <= 0) ? "powerup.1" : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1316f, 1360f, 1973f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 3;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	// Token: 0x06011C6D RID: 72813 RVA: 0x0061CE28 File Offset: 0x0061B028
	public IEnumerator BJJOFLBPCOI()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C6E RID: 72814 RVA: 0x0061CE43 File Offset: 0x0061B043
	public void NLFKGIDAEON(string EBEHBBDKDFJ)
	{
		Debug.Log("Tab2Content" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 1;
		this.ADENGMJODMD();
		base.StartCoroutine(this.ReloadPage());
	}

	// Token: 0x06011C6F RID: 72815 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06011C70 RID: 72816 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06011C71 RID: 72817 RVA: 0x0061CE78 File Offset: 0x0061B078
	private IEnumerator GICHCIBMFPE(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C72 RID: 72818 RVA: 0x0061CE9C File Offset: 0x0061B09C
	private void FCBMLKGDDGP(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("color").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? ".".ToUpper() : "Joystick1Button9".ToUpper());
		gameObject.transform.Find("_Greenness").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack/Blend2Camera_ColorKey".ToUpper() : "ready".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(1446f, 1829f, 872f);
	}

	// Token: 0x06011C73 RID: 72819 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06011C74 RID: 72820 RVA: 0x0061CF64 File Offset: 0x0061B164
	private IEnumerator PENNNPCBEID()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C75 RID: 72821 RVA: 0x0061CF80 File Offset: 0x0061B180
	private void MKGLGIIBOEL()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1030f, 372f, 1746f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -60;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(959f, 338f, 104f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[0];
		array[0] = string.Empty;
		array[1] = this.currentPageID + 1;
		array[8] = "CameraFilterPack/TV_WideScreenHorizontal";
		array[5] = ((this.pagesCount <= 0) ? "JoinRandom failed: {0}." : (this.pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1695f, 1048f, 1131f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 0;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x06011C76 RID: 72822 RVA: 0x0061D135 File Offset: 0x0061B335
	public void MLKHEIGKEIE(string EBEHBBDKDFJ)
	{
		Debug.Log("sfxVolume" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 1;
		this.HFJBMFHOPMA();
		base.StartCoroutine(this.LEMOIOPFDCK());
	}

	// Token: 0x06011C77 RID: 72823 RVA: 0x0061D168 File Offset: 0x0061B368
	public IEnumerator JOEDCPNAHHH()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C78 RID: 72824 RVA: 0x0061D183 File Offset: 0x0061B383
	public void KIINKPEAFGO()
	{
		base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.ranksCanvas, false, null, false, 174f, false));
	}

	// Token: 0x06011C79 RID: 72825 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06011C7A RID: 72826 RVA: 0x0061D1A5 File Offset: 0x0061B3A5
	public void GAFJHLKIIBP()
	{
		base.StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(this.ranksCanvas, true, null, false, 155f, true));
	}

	// Token: 0x06011C7B RID: 72827 RVA: 0x0061D1C7 File Offset: 0x0061B3C7
	public void DHGGMEICMDO()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("Texture2"), false);
	}

	// Token: 0x06011C7C RID: 72828 RVA: 0x0061D1E3 File Offset: 0x0061B3E3
	public void LMCLOJEFNNP(string EBEHBBDKDFJ)
	{
		Debug.Log(":\n" + EBEHBBDKDFJ);
		this.OOBHCDCCFJJ = EBEHBBDKDFJ;
		this.currentPageID = 1;
		this.HFJBMFHOPMA();
		base.StartCoroutine(this.IPMIBOLJMMN());
	}

	// Token: 0x06011C7D RID: 72829 RVA: 0x0061D216 File Offset: 0x0061B416
	public void DNAOMGHDHPB()
	{
		base.StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(this.ranksCanvas, false, null, true, 1160f, false));
	}

	// Token: 0x06011C7E RID: 72830 RVA: 0x0061D238 File Offset: 0x0061B438
	private IEnumerator JGBMMJBKNDA()
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl),
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(www.text);
			this.pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C7F RID: 72831 RVA: 0x0061D254 File Offset: 0x0061B454
	private IEnumerator HLAIECHLCDA(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x06011C80 RID: 72832 RVA: 0x0061D278 File Offset: 0x0061B478
	public IEnumerator BPBPKGNFJNP()
	{
		base.StopAllCoroutines();
		if (this.NOFOMIDHENF == 0)
		{
			base.StartCoroutine(this.HKJKAOCEMEE());
		}
		if (this.NOFOMIDHENF == 1)
		{
			base.StartCoroutine(this.KPMPEDIKPND(this.CAFHKDIIDEE));
		}
		yield return true;
		yield break;
	}

	// Token: 0x06011C81 RID: 72833 RVA: 0x0061D293 File Offset: 0x0061B493
	public void ABFGADPLNKO()
	{
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("Start Color's hex value #RRGGBBAA"), true);
	}

	// Token: 0x06011C82 RID: 72834 RVA: 0x0061D2AF File Offset: 0x0061B4AF
	public void EELFFPJDBFB()
	{
		base.StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(this.ranksCanvas, true, null, true, 1104f, false));
	}

	// Token: 0x06011C83 RID: 72835 RVA: 0x0061D2D4 File Offset: 0x0061B4D4
	private IEnumerator HFAGKHBJGOG(string CAFHKDIIDEE)
	{
		this.loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		gameObject = this.ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		www = new WWW(string.Concat(new object[]
		{
			Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl),
			"&map=",
			CAFHKDIIDEE,
			"&page=",
			this.currentPageID + 1,
			"&search=",
			this.OOBHCDCCFJJ
		}));
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + www.error);
		}
		else
		{
			this.BAHKGHFGJLM(gameObject, true);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(www.text);
			int num = this.currentPageID * this.ranksPerPage;
			int num2 = (((this.currentPageID + 1) * this.ranksPerPage <= mapLeaderboard.scores.Count) ? ((this.currentPageID + 1) * this.ranksPerPage) : mapLeaderboard.scores.Count) - 1;
			this.pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)this.ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID csteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		this.HOAHBPOGNKA();
		yield return true;
		this.loadingCanvas.SetActive(false);
		yield break;
	}

	// Token: 0x04001F57 RID: 8023
	public int ranksPerPage = 100;

	// Token: 0x04001F58 RID: 8024
	public Button buttonBack;

	// Token: 0x04001F59 RID: 8025
	public GameObject ranksCanvas;

	// Token: 0x04001F5A RID: 8026
	public GameObject ranksListContent;

	// Token: 0x04001F5B RID: 8027
	public Text infoText;

	// Token: 0x04001F5C RID: 8028
	public GameObject pageNavScrollRectContent;

	// Token: 0x04001F5D RID: 8029
	public GameObject pageNavPrevPageButton;

	// Token: 0x04001F5E RID: 8030
	public GameObject pageNavCurrentPageButton;

	// Token: 0x04001F5F RID: 8031
	public GameObject pageNavNextPageButton;

	// Token: 0x04001F60 RID: 8032
	public GameObject loadingCanvas;

	// Token: 0x04001F61 RID: 8033
	public GameObject highscoresElement;

	// Token: 0x04001F62 RID: 8034
	public GameObject highscoresTitleElement;

	// Token: 0x04001F63 RID: 8035
	public InputField searchInputField;

	// Token: 0x04001F64 RID: 8036
	[HideInInspector]
	public int currentPageID;

	// Token: 0x04001F65 RID: 8037
	public int pagesCount;

	// Token: 0x04001F66 RID: 8038
	private string OOBHCDCCFJJ = string.Empty;

	// Token: 0x04001F67 RID: 8039
	private int NOFOMIDHENF;

	// Token: 0x04001F68 RID: 8040
	private string CAFHKDIIDEE = string.Empty;

	// Token: 0x04001F69 RID: 8041
	private string IKAGNOFHOGA = string.Empty;
}
