using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x020004B0 RID: 1200
public class MapsListSelector : Singleton<MapsListSelector>
{
	// Token: 0x06011361 RID: 70497 RVA: 0x005E8639 File Offset: 0x005E6839
	public void CCLNNLCOPBL()
	{
		this.relaxModeToggle.isOn = (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("] to be droppable", 0, null) == 0);
	}

	// Token: 0x06011362 RID: 70498 RVA: 0x005E865A File Offset: 0x005E685A
	private void DHODJKNPOLL(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		this.ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (this.KFBIEPMLCBP != null)
		{
			base.StopCoroutine(this.KFBIEPMLCBP);
		}
		this.KFBIEPMLCBP = this.IGIAHHHPMGP(IAFAANLMOAG);
		base.StartCoroutine(this.KFBIEPMLCBP);
	}

	// Token: 0x06011363 RID: 70499 RVA: 0x005E869A File Offset: 0x005E689A
	public void Start()
	{
		this.relaxModeToggle.isOn = (Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0, null) == 0);
	}

	// Token: 0x06011364 RID: 70500 RVA: 0x005E86BC File Offset: 0x005E68BC
	public IEnumerator DisplayMapSelector(int HLBKCLPNHEB = -1, int MJJNNIMOEIO = -1, List<int> BKNCFOOMKHE = null, bool GLHKMKPDAKP = true, UnityAction KPCNMGBCOLP = null, string DLDLDCOHICL = null)
	{
		if (HLBKCLPNHEB > this.tabs.Count - 1)
		{
			HLBKCLPNHEB = -1;
		}
		yield return new WaitUntil(new Func<bool>(base.GBKBDKHPLKG));
		this.lastSearch = Singleton<SaveSystem>.Instance.GetString("mapselector.lastSearch", string.Empty, null);
		this.searchInputField.text = this.lastSearch;
		this.result = null;
		this.finished = false;
		this.KBLADAACANO = GLHKMKPDAKP;
		if (BKNCFOOMKHE == null)
		{
			for (int i = 0; i < this.tabs.Count; i++)
			{
				this.tabs[i].GetComponent<Button>().interactable = true;
			}
		}
		else
		{
			for (int j = 0; j < this.tabs.Count; j++)
			{
				this.tabs[j].GetComponent<Button>().interactable = BKNCFOOMKHE.Contains(j);
			}
		}
		if (string.IsNullOrEmpty(DLDLDCOHICL))
		{
			DLDLDCOHICL = LocalizationService.Instance.GetTextByKey("back").ToUpper();
		}
		this.HLBKCLPNHEB = HLBKCLPNHEB;
		this.MJJNNIMOEIO = MJJNNIMOEIO;
		this.resultMode = (GameScene.GameMode)Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0, null);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.modeSelector, false, null, true, 0.2f, true));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mapSelector, true, null, true, 0.2f, true));
		this.Init(HLBKCLPNHEB, MJJNNIMOEIO);
		this.buttonBack.onClick.RemoveAllListeners();
		this.buttonBack.GetComponentInChildren<Text>().text = DLDLDCOHICL;
		if (KPCNMGBCOLP != null)
		{
			this.HKDGMEHPLDM = KPCNMGBCOLP;
		}
		else
		{
			this.HKDGMEHPLDM = null;
		}
		this.buttonBack.onClick.RemoveAllListeners();
		this.buttonBack.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		EventSystem.current.SetSelectedGameObject(this.buttonBack.transform.gameObject);
		base.StartCoroutine(this.DPHCONACLFO());
		yield return new WaitUntil(new Func<bool>(base.NEIDGMKKCBI));
		yield return new WaitForSeconds(0.25f);
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null) && GameObject.Find("AudioSampler"))
		{
			GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = false;
		}
		yield break;
	}

	// Token: 0x06011365 RID: 70501 RVA: 0x005E8704 File Offset: 0x005E6904
	[CompilerGenerated]
	private static bool DHNHANCJOHB(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isOfficial;
	}

	// Token: 0x06011366 RID: 70502 RVA: 0x005E870C File Offset: 0x005E690C
	public int GetMapsCount()
	{
		return this.AFOAEMCKEEM;
	}

	// Token: 0x06011367 RID: 70503 RVA: 0x005E8714 File Offset: 0x005E6914
	public void CBFMHLKKLIG(int JMMILEFMACB)
	{
		this.resultMode = (GameScene.GameMode)JMMILEFMACB;
		this.JCANNKKJJJJ(this.result, false);
	}

	// Token: 0x06011368 RID: 70504 RVA: 0x005E872C File Offset: 0x005E692C
	public void Close(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			this.result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (this.KBLADAACANO)
				{
					base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.modeSelector, true, null, true, 0.2f, true));
					base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mapSelector, false, null, true, 0.2f, true));
				}
				else
				{
					this.finished = true;
					base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.modeSelector, false, null, true, 0.2f, true));
					base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mapSelector, false, null, true, 0.2f, true));
				}
			}
			else
			{
				this.finished = true;
				base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.modeSelector, false, null, true, 0.2f, true));
				base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mapSelector, false, null, true, 0.2f, true));
				if (this.HKDGMEHPLDM != null)
				{
					this.HKDGMEHPLDM();
				}
			}
		}
		else
		{
			this.finished = true;
			base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.modeSelector, false, null, true, 0.2f, true));
			base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mapSelector, false, null, true, 0.2f, true));
		}
	}

	// Token: 0x06011369 RID: 70505 RVA: 0x005E8898 File Offset: 0x005E6A98
	public void BackToSelector()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.modeSelector, false, null, true, 0.2f, true));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mapSelector, true, null, true, 0.2f, true));
	}

	// Token: 0x0601136A RID: 70506 RVA: 0x005E88E8 File Offset: 0x005E6AE8
	public void ReloadPage(bool IIGAFCONAHP = false)
	{
		if (IIGAFCONAHP)
		{
			this.currentMapsPageID = 0;
		}
		this.BPLAIMGIOKO = (MapsListSelector.OfficialSortMode)Singleton<SaveSystem>.Instance.GetInt("mapselector.filter.officialsortmode", 0, null);
		this.searchInputField.interactable = (!Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false, null));
		if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false, null) || Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false, null) || Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false, null))
		{
			this.lastSearch = string.Empty;
			Singleton<SaveSystem>.Instance.SetString("mapselector.lastSearch", string.Empty, null);
			this.searchInputField.text = string.Empty;
		}
		this.CECPMNODBLA();
		base.StopCoroutine("MAMMIDNFMOM");
		base.StartCoroutine(this.MAMMIDNFMOM());
	}

	// Token: 0x0601136B RID: 70507 RVA: 0x005E89F7 File Offset: 0x005E6BF7
	public void SetMapsCount(int HOHOIPHEOPN)
	{
		this.AFOAEMCKEEM = HOHOIPHEOPN;
	}

	// Token: 0x0601136C RID: 70508 RVA: 0x005E8A00 File Offset: 0x005E6C00
	public void OnEnable()
	{
		this.AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.MILGIHKLCHH));
	}

	// Token: 0x0601136D RID: 70509 RVA: 0x005E8A19 File Offset: 0x005E6C19
	public void Init(int HLBKCLPNHEB, int MJJNNIMOEIO)
	{
		if (HLBKCLPNHEB != -1)
		{
			this.currentMapsTab = HLBKCLPNHEB;
		}
		if (MJJNNIMOEIO != -1)
		{
			this.currentMapsPageID = MJJNNIMOEIO;
		}
		this.ReloadPage(false);
	}

	// Token: 0x0601136E RID: 70510 RVA: 0x005E8A40 File Offset: 0x005E6C40
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
		gameObject2.GetComponent<MapsListNavButton>().actionID = -1;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject3.GetComponentInChildren<Text>().text = string.Concat(new object[]
		{
			string.Empty,
			this.currentMapsPageID + 1,
			"/",
			(this.AOJCGLBEOME <= 0) ? "1" : (this.AOJCGLBEOME + string.Empty)
		});
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x0601136F RID: 70511 RVA: 0x005E8BF4 File Offset: 0x005E6DF4
	private void MILGIHKLCHH(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		this.ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (this.KFBIEPMLCBP != null)
		{
			base.StopCoroutine(this.KFBIEPMLCBP);
		}
		this.KFBIEPMLCBP = this.HBNLOHGCGPG(IAFAANLMOAG);
		base.StartCoroutine(this.KFBIEPMLCBP);
	}

	// Token: 0x06011370 RID: 70512 RVA: 0x005E8C34 File Offset: 0x005E6E34
	private IEnumerator DPHCONACLFO()
	{
		this.sortDropDownList.gameObject.SetActive(true);
		this.sortDropDownList.Start();
		yield return null;
		DropDownList dropDownList = this.sortDropDownList;
		dropDownList.Items.Clear();
		this.sortDropDownListText.text = LocalizationService.Instance.GetLocalizatedText("#orderby:").ToUpper();
		int num = 0;
		IEnumerator enumerator = Enum.GetValues(typeof(MapsListSelector.OfficialSortMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				MapsListSelector.OfficialSortMode officialSortMode = (MapsListSelector.OfficialSortMode)obj;
				dropDownList.Items.Add(new DropDownListItem(LocalizationService.Instance.GetLocalizatedText("#" + officialSortMode.ToString().ToLower()).ToUpper(), string.Empty + officialSortMode.ToString(), null, false, null));
				num++;
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		dropDownList.RebuildPanel();
		dropDownList.RedrawPanel();
		dropDownList.SelectItem((int)this.BPLAIMGIOKO, false);
		dropDownList.gameObject.SetActive(this.currentMapsTab == 0 || this.currentMapsTab == 3 || this.currentMapsTab == 4);
		yield break;
	}

	// Token: 0x06011371 RID: 70513 RVA: 0x005E865A File Offset: 0x005E685A
	private void DAGCCMAKLPG(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		this.ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (this.KFBIEPMLCBP != null)
		{
			base.StopCoroutine(this.KFBIEPMLCBP);
		}
		this.KFBIEPMLCBP = this.IGIAHHHPMGP(IAFAANLMOAG);
		base.StartCoroutine(this.KFBIEPMLCBP);
	}

	// Token: 0x06011372 RID: 70514 RVA: 0x005E8C50 File Offset: 0x005E6E50
	public void ChangeMapsSource(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.lastSearch = string.Empty;
		Singleton<SaveSystem>.Instance.SetString("mapselector.lastSearch", string.Empty, null);
		this.searchInputField.text = string.Empty;
		this.currentMapsTab = JMMILEFMACB;
		this.currentMapsPageID = 0;
		this.CECPMNODBLA();
		base.StopCoroutine("MAMMIDNFMOM");
		base.StartCoroutine(this.MAMMIDNFMOM());
	}

	// Token: 0x06011373 RID: 70515 RVA: 0x005E8CD0 File Offset: 0x005E6ED0
	public void BKAJKMBBNKJ(int JMMILEFMACB)
	{
		this.resultMode = (GameScene.GameMode)JMMILEFMACB;
		this.CGMCNFCBHAJ(this.result, false);
	}

	// Token: 0x06011374 RID: 70516 RVA: 0x005E8CE8 File Offset: 0x005E6EE8
	public void InitSortPanel()
	{
		this.sortPanel.gameObject.SetActive(true);
		GameObject gameObject = this.tagsScrollRectContent.gameObject;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string text in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "tagElement";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + text, true, null);
			gameObject2.GetComponentInChildren<Text>().text = text;
		}
		foreach (string text2 in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "tagElement";
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + text2, true, null);
			gameObject3.GetComponentInChildren<Text>().text = text2;
		}
		this.inTrendToggle.isOn = (Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0, null) == 0);
		this.recentToggle.isOn = (Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0, null) == 1);
		this.topRatedToggle.isOn = (Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0, null) == 2);
		this.subscribedToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false, null);
		this.favoriteToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false, null);
		this.ratedToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false, null);
	}

	// Token: 0x06011375 RID: 70517 RVA: 0x005E8F7C File Offset: 0x005E717C
	private void BHAPMGBDPFI(bool IDNLBGOCOEK)
	{
		this.sortDropDownList.KHPFNJCHEBO((int)this.BPLAIMGIOKO, true);
		this.sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	// Token: 0x06011376 RID: 70518 RVA: 0x005E8FA4 File Offset: 0x005E71A4
	private void PHHPOLMDEIF(bool NNIPFHAFNOK = false)
	{
		this.ANFDMOPJFCK = 50;
		this.HOAHBPOGNKA();
		if (this.currentMapsTab == 2)
		{
			EUGCQuery eugcquery = EUGCQuery.k_EUGCQuery_RankedByTrend;
			if (Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0, null) == 1)
			{
				eugcquery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0, null) == 2)
			{
				eugcquery = EUGCQuery.k_EUGCQuery_RankedByVote;
			}
			if (eugcquery != EUGCQuery.k_EUGCQuery_RankedByTrend)
			{
				Helpers.ObtainAchievement(25);
			}
			if (!Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false, null))
			{
				this.FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eugcquery, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, (AppId_t)513510U, (AppId_t)513510U, (uint)this.HGPMLICPBKA);
				this.ApplySearchFilter();
			}
			else
			{
				if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false, null))
				{
					this.FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Subscribed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_SubscriptionDateDesc, (AppId_t)513510U, (AppId_t)513510U, (uint)this.HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false, null))
				{
					this.FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Favorited, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)513510U, (AppId_t)513510U, (uint)this.HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false, null))
				{
					this.FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedUp, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)513510U, (AppId_t)513510U, (uint)this.HGPMLICPBKA);
				}
			}
			this.ADLHGGOENBP = NNIPFHAFNOK;
			SteamUGC.SetReturnOnlyIDs(this.FFOJIDODGDO, !NNIPFHAFNOK);
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(this.FFOJIDODGDO);
			this.AICOBBBILIL.Set(hAPICall, null);
		}
		if (this.currentMapsTab == 5)
		{
			EUGCQuery eQueryType = EUGCQuery.k_EUGCQuery_RankedByTrend;
			this.FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eQueryType, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, AppId_t.Invalid, SteamUtils.GetAppID(), (uint)this.HGPMLICPBKA);
			SteamUGC.AddRequiredTag(this.FFOJIDODGDO, "winter2020_official");
			SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(this.FFOJIDODGDO);
			this.AICOBBBILIL.Set(hAPICall2, null);
		}
		if (this.currentMapsTab == 0 || this.currentMapsTab == 3 || this.currentMapsTab == 4)
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			List<RanksSystem.Map> list2 = RanksSystem.GetOfficialMapsList();
			if (this.BPLAIMGIOKO == MapsListSelector.OfficialSortMode.Date)
			{
				IEnumerable<RanksSystem.Map> officialMapsList = RanksSystem.GetOfficialMapsList();
				if (MapsListSelector.LNIJKGECNME == null)
				{
					MapsListSelector.LNIJKGECNME = new Func<RanksSystem.Map, DateTime>(MapsListSelector.DHDNNKEMHCM);
				}
				list2 = officialMapsList.OrderByDescending(MapsListSelector.LNIJKGECNME).ToList<RanksSystem.Map>();
			}
			if (this.BPLAIMGIOKO == MapsListSelector.OfficialSortMode.Difficulty)
			{
				IEnumerable<RanksSystem.Map> officialMapsList2 = RanksSystem.GetOfficialMapsList();
				if (MapsListSelector.CLCBJCKCBDD == null)
				{
					MapsListSelector.CLCBJCKCBDD = new Func<RanksSystem.Map, float>(MapsListSelector.HFAMHDJOBIF);
				}
				list2 = officialMapsList2.OrderBy(MapsListSelector.CLCBJCKCBDD).ToList<RanksSystem.Map>();
			}
			if (this.currentMapsTab == 0)
			{
				IEnumerable<RanksSystem.Map> source = list2;
				if (MapsListSelector.HCLEECLNOEA == null)
				{
					MapsListSelector.HCLEECLNOEA = new Func<RanksSystem.Map, bool>(MapsListSelector.DHNHANCJOHB);
				}
				foreach (RanksSystem.Map map in source.Where(MapsListSelector.HCLEECLNOEA).ToList<RanksSystem.Map>())
				{
					list.Add((PublishedFileId_t)map.id);
				}
			}
			if (this.currentMapsTab == 3)
			{
				IEnumerable<RanksSystem.Map> source2 = list2;
				if (MapsListSelector.ADLAKIHINOM == null)
				{
					MapsListSelector.ADLAKIHINOM = new Func<RanksSystem.Map, bool>(MapsListSelector.NDNCFNHKPCF);
				}
				foreach (RanksSystem.Map map2 in source2.Where(MapsListSelector.ADLAKIHINOM).ToList<RanksSystem.Map>())
				{
					list.Add((PublishedFileId_t)map2.id);
				}
			}
			if (this.currentMapsTab == 4)
			{
				IEnumerable<RanksSystem.Map> source3 = list2;
				if (MapsListSelector.KCAPKHIJOHL == null)
				{
					MapsListSelector.KCAPKHIJOHL = new Func<RanksSystem.Map, bool>(MapsListSelector.KLBEEDEECFN);
				}
				foreach (RanksSystem.Map map3 in source3.Where(MapsListSelector.KCAPKHIJOHL).ToList<RanksSystem.Map>())
				{
					list.Add((PublishedFileId_t)map3.id);
				}
			}
			this.FFOJIDODGDO = SteamUGC.CreateQueryUGCDetailsRequest(list.ToArray(), (uint)list.Count);
			SteamAPICall_t hAPICall3 = SteamUGC.SendQueryUGCRequest(this.FFOJIDODGDO);
			this.AICOBBBILIL.Set(hAPICall3, null);
		}
	}

	// Token: 0x06011377 RID: 70519 RVA: 0x005E9460 File Offset: 0x005E7660
	public void CGMCNFCBHAJ(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			this.result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (this.KBLADAACANO)
				{
					base.StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(this.modeSelector, false, null, false, 525f, true));
					base.StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(this.mapSelector, false, null, true, 239f, false));
				}
				else
				{
					this.finished = true;
					base.StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(this.modeSelector, false, null, true, 480f, true));
					base.StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(this.mapSelector, false, null, true, 1031f, false));
				}
			}
			else
			{
				this.finished = false;
				base.StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(this.modeSelector, true, null, false, 1729f, true));
				base.StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(this.mapSelector, true, null, true, 1743f, false));
				if (this.HKDGMEHPLDM != null)
				{
					this.HKDGMEHPLDM();
				}
			}
		}
		else
		{
			this.finished = true;
			base.StartCoroutine(Singleton<UI>.Instance.CIADGNBMOLN(this.modeSelector, false, null, false, 1934f, true));
			base.StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(this.mapSelector, true, null, false, 1636f, false));
		}
	}

	// Token: 0x06011378 RID: 70520 RVA: 0x005E95CA File Offset: 0x005E77CA
	public void SelectPlayMode(int JMMILEFMACB)
	{
		this.resultMode = (GameScene.GameMode)JMMILEFMACB;
		this.Close(this.result, true);
	}

	// Token: 0x06011379 RID: 70521 RVA: 0x005E95E0 File Offset: 0x005E77E0
	public void ALKBNPMCEOM(int HLBKCLPNHEB, int MJJNNIMOEIO)
	{
		if (HLBKCLPNHEB != -1)
		{
			this.currentMapsTab = HLBKCLPNHEB;
		}
		if (MJJNNIMOEIO != -1)
		{
			this.currentMapsPageID = MJJNNIMOEIO;
		}
		this.DLEEFJANJDC(false);
	}

	// Token: 0x0601137A RID: 70522 RVA: 0x005E9608 File Offset: 0x005E7808
	public void AOCEHIHDPIH()
	{
		this.sortPanel.gameObject.SetActive(false);
		GameObject gameObject = this.tagsScrollRectContent.gameObject;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string text in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "https://reddit.com/r/Intralism";
			gameObject2.transform.localScale = new Vector3(261f, 798f, 897f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.AANPGELPGPN(").png" + text, false, null);
			gameObject2.GetComponentInChildren<Text>().text = text;
		}
		foreach (string text2 in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "_Color_G";
			gameObject3.transform.localScale = new Vector3(225f, 1389f, 741f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.AANPGELPGPN("SetSatelliteTrailMinVertexDistance" + text2, true, null);
			gameObject3.GetComponentInChildren<Text>().text = text2;
		}
		this.inTrendToggle.isOn = (Singleton<SaveSystem>.Instance.ANECPPFPKAP("YES", 1, null) == 1);
		this.recentToggle.isOn = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("[EditorEvent] Exception: ", 1, null) == 1);
		this.topRatedToggle.isOn = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD(".b", 0, null) == 1);
		this.subscribedToggle.isOn = Singleton<SaveSystem>.Instance.ONOENJPEFDD("#91CCFF", false, null);
		this.favoriteToggle.isOn = Singleton<SaveSystem>.Instance.ONOENJPEFDD("Value", true, null);
		this.ratedToggle.isOn = Singleton<SaveSystem>.Instance.IOLBIFOIHML("[ItemsHandler] Loading Steam inventory", true, null);
	}

	// Token: 0x0601137B RID: 70523 RVA: 0x005E989C File Offset: 0x005E7A9C
	private IEnumerator JHFJDFHNHHJ()
	{
		this.loadingCanvas.SetActive(true);
		this.levelsScrollRectContentAnimation.SetBool("isVisible", false);
		GameObject gameObject = this.levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (this.currentMapsTab == 1)
		{
			MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD kemnopffemd = new MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD();
			kemnopffemd.KAJEFPDIIJA = this;
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> levelsData = Singleton<MapsSystem>.Instance.levelsData;
			if (MapsListSelector.APGNKGEOGPN.LNIJKGECNME == null)
			{
				MapsListSelector.APGNKGEOGPN.LNIJKGECNME = new Func<KeyValuePair<string, FullMapData>, bool>(MapsListSelector.APGNKGEOGPN.GBKBDKHPLKG);
			}
			IEnumerable<KeyValuePair<string, FullMapData>> enumerable = levelsData.Where(MapsListSelector.APGNKGEOGPN.LNIJKGECNME);
			kemnopffemd.AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD kemnopffemd2 = kemnopffemd;
			IEnumerable<KeyValuePair<string, FullMapData>> source = enumerable;
			if (MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD == null)
			{
				MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.HMMBBDJNGGL);
			}
			Func<KeyValuePair<string, FullMapData>, string> clcbjckcbdd = MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD;
			if (MapsListSelector.APGNKGEOGPN.HCLEECLNOEA == null)
			{
				MapsListSelector.APGNKGEOGPN.HCLEECLNOEA = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.NEIDGMKKCBI);
			}
			kemnopffemd2.AKNKMCNHKGH = source.ToDictionary(clcbjckcbdd, MapsListSelector.APGNKGEOGPN.HCLEECLNOEA);
			IEnumerable<KeyValuePair<string, FullMapData>> enumerable2 = kemnopffemd.AKNKMCNHKGH.Where(new Func<KeyValuePair<string, FullMapData>, bool>(kemnopffemd.GBKBDKHPLKG));
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.ADLAKIHINOM == null)
			{
				MapsListSelector.APGNKGEOGPN.ADLAKIHINOM = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.BJGDNLAOMHE);
			}
			Func<KeyValuePair<string, FullMapData>, string> adlakihinom = MapsListSelector.APGNKGEOGPN.ADLAKIHINOM;
			if (MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL == null)
			{
				MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.PEOLMJGDHJK);
			}
			foreach (string jmmilefmacb in source2.ToDictionary(adlakihinom, MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL).Keys)
			{
				Singleton<MapsSystem>.Instance.LoadLevel(jmmilefmacb, false);
			}
			List<FullMapData> list = new List<FullMapData>();
			IEnumerable<KeyValuePair<string, FullMapData>> source3 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.DIEBHABBNGF == null)
			{
				MapsListSelector.APGNKGEOGPN.DIEBHABBNGF = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.GLDCBMNHEGA);
			}
			Func<KeyValuePair<string, FullMapData>, string> diebhabbngf = MapsListSelector.APGNKGEOGPN.DIEBHABBNGF;
			if (MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH == null)
			{
				MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.HBICJNIKCNA);
			}
			foreach (FullMapData item in source3.ToDictionary(diebhabbngf, MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH).Values)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			using (List<FullMapData>.Enumerator enumerator3 = list.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ femoopfnglj = new MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ();
					femoopfnglj.KAJEFPDIIJA = this;
					femoopfnglj.NOJGGCLPPAM = enumerator3.Current;
					if (femoopfnglj.NOJGGCLPPAM != null)
					{
						if (!femoopfnglj.NOJGGCLPPAM.isLoaded())
						{
							Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault(new Func<KeyValuePair<string, FullMapData>, bool>(femoopfnglj.GBKBDKHPLKG)).Key, false);
						}
						if ((femoopfnglj.NOJGGCLPPAM.mapData != null && femoopfnglj.NOJGGCLPPAM.isUnlocked()) || (!femoopfnglj.NOJGGCLPPAM.isUnlocked() && !femoopfnglj.NOJGGCLPPAM.mapData.hidden))
						{
							GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelsListElement, femoopfnglj.NOJGGCLPPAM, gameObject);
						}
					}
				}
			}
			this.AOJCGLBEOME = (int)Math.Ceiling((double)kemnopffemd.AKNKMCNHKGH.Count / (double)this.ItemsPerPage());
			this.HOAHBPOGNKA();
			if (kemnopffemd.AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject3.transform.SetParent(this.levelsScrollRectContent.transform, true);
				gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			this.loadingCanvas.SetActive(false);
			this.levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			this.HGPMLICPBKA = 1;
			this.PHHPOLMDEIF(false);
		}
		yield break;
	}

	// Token: 0x0601137C RID: 70524 RVA: 0x005E98B8 File Offset: 0x005E7AB8
	public void UpdateSortUI()
	{
		this.filterBGPanel.gameObject.SetActive(this.subscribedToggle.isOn || this.favoriteToggle.isOn || this.ratedToggle.isOn);
		this.searchInputField.interactable = (!Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false, null));
	}

	// Token: 0x0601137D RID: 70525 RVA: 0x005E9954 File Offset: 0x005E7B54
	public void LKFKCOHMNLE()
	{
		GameObject gameObject = this.tagsScrollRectContent.gameObject;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Toggle toggle = componentsInChildren[i];
			Singleton<SaveSystem>.Instance.GAACBNCIFLG("_ForceYSwap" + toggle.GetComponentInChildren<Text>().text, toggle.isOn, null);
		}
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_DistortionLevel", (!this.inTrendToggle.isOn) ? ((!this.recentToggle.isOn) ? 8 : 0) : 0, null);
		Singleton<SaveSystem>.Instance.NCNNFONPMLD("#exit", this.subscribedToggle.isOn, null);
		Singleton<SaveSystem>.Instance.LBFFJLFBOAM("FrostCanvas", this.favoriteToggle.isOn, null);
		Singleton<SaveSystem>.Instance.NCNNFONPMLD("MenuScene", this.ratedToggle.isOn, null);
		this.DBFDIGPGHEJ();
		this.ReloadPage(true);
	}

	// Token: 0x0601137E RID: 70526 RVA: 0x005E9A50 File Offset: 0x005E7C50
	private IEnumerator JLPBJJIFHHB()
	{
		this.sortDropDownList.gameObject.SetActive(true);
		this.sortDropDownList.Start();
		yield return null;
		dropDownList = this.sortDropDownList;
		dropDownList.Items.Clear();
		this.sortDropDownListText.text = LocalizationService.Instance.GetLocalizatedText("#orderby:").ToUpper();
		num = 0;
		enumerator = Enum.GetValues(typeof(MapsListSelector.OfficialSortMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				MapsListSelector.OfficialSortMode officialSortMode = (MapsListSelector.OfficialSortMode)obj;
				dropDownList.Items.Add(new DropDownListItem(LocalizationService.Instance.GetLocalizatedText("#" + officialSortMode.ToString().ToLower()).ToUpper(), string.Empty + officialSortMode.ToString(), null, false, null));
				num++;
			}
		}
		finally
		{
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		dropDownList.RebuildPanel();
		dropDownList.RedrawPanel();
		dropDownList.SelectItem((int)this.BPLAIMGIOKO, false);
		dropDownList.gameObject.SetActive(this.currentMapsTab == 0 || this.currentMapsTab == 3 || this.currentMapsTab == 4);
		yield break;
	}

	// Token: 0x0601137F RID: 70527 RVA: 0x005E9A6C File Offset: 0x005E7C6C
	public void CJJJDAIMDNG(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			this.result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (this.KBLADAACANO)
				{
					base.StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(this.modeSelector, true, null, false, 1125f, true));
					base.StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(this.mapSelector, false, null, true, 620f, false));
				}
				else
				{
					this.finished = false;
					base.StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(this.modeSelector, false, null, false, 1936f, false));
					base.StartCoroutine(Singleton<UI>.Instance.CMFJGHFEKIK(this.mapSelector, true, null, true, 111f, true));
				}
			}
			else
			{
				this.finished = false;
				base.StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(this.modeSelector, false, null, true, 1916f, false));
				base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.mapSelector, false, null, true, 1696f, false));
				if (this.HKDGMEHPLDM != null)
				{
					this.HKDGMEHPLDM();
				}
			}
		}
		else
		{
			this.finished = false;
			base.StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(this.modeSelector, false, null, false, 459f, true));
			base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.mapSelector, true, null, false, 1735f, true));
		}
	}

	// Token: 0x06011380 RID: 70528 RVA: 0x005E9BD6 File Offset: 0x005E7DD6
	public void JDFOIDHPHIO(int JMMILEFMACB)
	{
		this.resultMode = (GameScene.GameMode)JMMILEFMACB;
		this.JCANNKKJJJJ(this.result, true);
	}

	// Token: 0x06011381 RID: 70529 RVA: 0x005E9BEC File Offset: 0x005E7DEC
	public void ALBCHFHEFCK(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentMapsPageID > 1)
			{
				this.currentMapsPageID -= 0;
				this.ReloadPage(true);
			}
		}
		else if (this.currentMapsPageID + 1 < this.AOJCGLBEOME)
		{
			this.currentMapsPageID++;
			this.ReloadPage(true);
		}
	}

	// Token: 0x06011382 RID: 70530 RVA: 0x005E9C50 File Offset: 0x005E7E50
	public void BLKGBHODPFI()
	{
		this.sortPanel.gameObject.SetActive(false);
		GameObject gameObject = this.tagsScrollRectContent.gameObject;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string text in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "#alreadyexist";
			gameObject2.transform.localScale = new Vector3(1635f, 1008f, 1497f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.EBEAKNGJCDC("_Value4" + text, false, null);
			gameObject2.GetComponentInChildren<Text>().text = text;
		}
		foreach (string text2 in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "AudioSampler";
			gameObject3.transform.localScale = new Vector3(1547f, 796f, 455f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.ADKHKNJOJEH(".lastCheckpoint.time" + text2, true, null);
			gameObject3.GetComponentInChildren<Text>().text = text2;
		}
		this.inTrendToggle.isOn = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("settings.crosshairopacity", 0, null) == 0);
		this.recentToggle.isOn = (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("Player Disconnected", 1, null) == 0);
		this.topRatedToggle.isOn = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("0,2,true,0", 0, null) == 8);
		this.subscribedToggle.isOn = Singleton<SaveSystem>.Instance.AANPGELPGPN(":\n", false, null);
		this.favoriteToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("_TimeX", true, null);
		this.ratedToggle.isOn = Singleton<SaveSystem>.Instance.ADKHKNJOJEH("_Value3", false, null);
	}

	// Token: 0x06011383 RID: 70531 RVA: 0x005E9EE4 File Offset: 0x005E80E4
	[CompilerGenerated]
	private static DateTime DHDNNKEMHCM(RanksSystem.Map IACGDFHKCAE)
	{
		return DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture);
	}

	// Token: 0x06011384 RID: 70532 RVA: 0x005E9EF6 File Offset: 0x005E80F6
	private static bool EFBMHLGDJMM(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.MOEOCIODBDH();
	}

	// Token: 0x06011385 RID: 70533 RVA: 0x005E9EFE File Offset: 0x005E80FE
	public void CloseSortPanel()
	{
		this.sortPanel.gameObject.SetActive(false);
	}

	// Token: 0x06011386 RID: 70534 RVA: 0x005E9F14 File Offset: 0x005E8114
	public void SearchMaps(string EAFAMAMDNEG)
	{
		if (this.lastSearch != EAFAMAMDNEG)
		{
			Debug.Log("Search: " + EAFAMAMDNEG);
			this.lastSearch = EAFAMAMDNEG;
			Singleton<SaveSystem>.Instance.SetString("mapselector.lastSearch", this.lastSearch, null);
			this.ReloadPage(true);
		}
	}

	// Token: 0x06011387 RID: 70535 RVA: 0x005E9F66 File Offset: 0x005E8166
	[CompilerGenerated]
	private static bool KLBEEDEECFN(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFunny;
	}

	// Token: 0x06011388 RID: 70536 RVA: 0x005E9F6E File Offset: 0x005E816E
	public void PAFMNAIDAFH(int HLBKCLPNHEB, int MJJNNIMOEIO)
	{
		if (HLBKCLPNHEB != -1)
		{
			this.currentMapsTab = HLBKCLPNHEB;
		}
		if (MJJNNIMOEIO != -1)
		{
			this.currentMapsPageID = MJJNNIMOEIO;
		}
		this.DLEEFJANJDC(true);
	}

	// Token: 0x06011389 RID: 70537 RVA: 0x005E9F93 File Offset: 0x005E8193
	[CompilerGenerated]
	private static float HFAMHDJOBIF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.difficulty;
	}

	// Token: 0x0601138A RID: 70538 RVA: 0x005E9F9B File Offset: 0x005E819B
	private void CPJDEMLFBKD(bool IDNLBGOCOEK)
	{
		this.sortDropDownList.SelectItem((int)this.BPLAIMGIOKO, false);
		this.sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	// Token: 0x0601138B RID: 70539 RVA: 0x005E9FC0 File Offset: 0x005E81C0
	public new void CIAHIJIOFIE()
	{
		base.Awake();
	}

	// Token: 0x0601138C RID: 70540 RVA: 0x005E9FC8 File Offset: 0x005E81C8
	private static bool NHFFFAMFGEG(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GPAPLIKKEOH();
	}

	// Token: 0x0601138D RID: 70541 RVA: 0x005E9FD0 File Offset: 0x005E81D0
	public void JCANNKKJJJJ(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			this.result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (this.KBLADAACANO)
				{
					base.StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(this.modeSelector, false, null, false, 644f, true));
					base.StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(this.mapSelector, false, null, true, 1462f, false));
				}
				else
				{
					this.finished = false;
					base.StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(this.modeSelector, false, null, false, 146f, false));
					base.StartCoroutine(Singleton<UI>.Instance.HJEODGHPPAJ(this.mapSelector, false, null, true, 273f, false));
				}
			}
			else
			{
				this.finished = false;
				base.StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(this.modeSelector, false, null, true, 1449f, true));
				base.StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(this.mapSelector, true, null, false, 1312f, false));
				if (this.HKDGMEHPLDM != null)
				{
					this.HKDGMEHPLDM();
				}
			}
		}
		else
		{
			this.finished = true;
			base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.modeSelector, true, null, true, 106f, false));
			base.StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(this.mapSelector, false, null, true, 1848f, true));
		}
	}

	// Token: 0x0601138E RID: 70542 RVA: 0x005EA13C File Offset: 0x005E833C
	private void CECPMNODBLA()
	{
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", this.currentMapsTab, null);
		if (this.currentMapsTab != 2)
		{
			this.searchInputField.gameObject.SetActive(false);
			this.sortButton.gameObject.SetActive(false);
		}
		else if (!Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false, null) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false, null))
		{
			this.searchInputField.gameObject.SetActive(true);
			this.sortButton.gameObject.SetActive(true);
		}
		else
		{
			this.searchInputField.gameObject.SetActive(false);
			this.sortButton.gameObject.SetActive(true);
		}
		this.CPJDEMLFBKD(this.currentMapsTab == 0 || this.currentMapsTab == 3 || this.currentMapsTab == 4);
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().IsSelected = (this.tabs.IndexOf(gameObject) == this.currentMapsTab);
		}
	}

	// Token: 0x0601138F RID: 70543 RVA: 0x005EA2B0 File Offset: 0x005E84B0
	private static bool KCJHGGECHEK(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GCLPAFADHMD();
	}

	// Token: 0x06011391 RID: 70545 RVA: 0x005EA308 File Offset: 0x005E8508
	public void ChangePage(bool FOJOODCBOIK, int HOHOIPHEOPN, bool AAGGLAGLINL = false)
	{
		int num = this.currentMapsPageID;
		if (!FOJOODCBOIK)
		{
			if (HOHOIPHEOPN > 0)
			{
				num = (this.GetMapsCount() + this.ItemsPerPage() - 1) / this.ItemsPerPage() - 1;
			}
			else
			{
				num = 0;
			}
		}
		else
		{
			num = HOHOIPHEOPN;
		}
		if (num < 0)
		{
			num = 0;
		}
		if (num >= (this.GetMapsCount() + this.ItemsPerPage() - 1) / this.ItemsPerPage() - 1)
		{
			num = (this.GetMapsCount() + this.ItemsPerPage() - 1) / this.ItemsPerPage() - 1;
		}
		if (num != this.currentMapsPageID || AAGGLAGLINL)
		{
			this.currentMapsPageID = num;
			this.CECPMNODBLA();
			base.StopCoroutine("MAMMIDNFMOM");
			base.StartCoroutine(this.MAMMIDNFMOM());
		}
	}

	// Token: 0x06011392 RID: 70546 RVA: 0x005EA3C8 File Offset: 0x005E85C8
	private IEnumerator CBGNMAOAHPF(SteamUGCQueryCompleted_t IAFAANLMOAG)
	{
		GameObject gameObject = this.levelsScrollRectContent;
		if (!this.ADLHGGOENBP)
		{
			this.SetMapsCount((int)IAFAANLMOAG.m_unTotalMatchingResults);
			this.KODEDGNDBLA = this.ItemsPerPage();
			this.AOJCGLBEOME = (int)Math.Ceiling((double)this.GetMapsCount() / (double)this.KODEDGNDBLA);
			this.KNLOJGHDLLJ = this.KODEDGNDBLA * this.currentMapsPageID;
			this.NJEPDDEILLL = ((this.KODEDGNDBLA * this.currentMapsPageID + this.KODEDGNDBLA <= this.GetMapsCount()) ? (this.KODEDGNDBLA * this.currentMapsPageID + this.KODEDGNDBLA - 1) : (this.GetMapsCount() - 1));
			if (this.ANFDMOPJFCK != 0)
			{
				this.BGEEOIKJNJG = this.KNLOJGHDLLJ / this.ANFDMOPJFCK + 1;
				this.ICJGDDNMHKH = this.NJEPDDEILLL / this.ANFDMOPJFCK + 1;
			}
			else
			{
				this.BGEEOIKJNJG = 1;
				this.ICJGDDNMHKH = 1;
			}
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			this.HGPMLICPBKA = ((this.BGEEOIKJNJG <= 1) ? 1 : (this.BGEEOIKJNJG - 1));
			this.ADLHGGOENBP = true;
			this.PHHPOLMDEIF(true);
			yield break;
		}
		this.ONKCIDAHIEJ = ((this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK < 0) ? 0 : (this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK));
		this.OPLHKEHGEAN = ((this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK + this.KODEDGNDBLA <= this.ANFDMOPJFCK) ? (this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK + this.KODEDGNDBLA - 1) : (this.ANFDMOPJFCK - 1));
		for (int j = this.ONKCIDAHIEJ; j < this.OPLHKEHGEAN + 1; j++)
		{
			SteamUGCDetails_t dahgjanlmpi;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(IAFAANLMOAG.m_handle, (uint)j, out dahgjanlmpi);
			if (queryUGCResult && dahgjanlmpi.m_eResult == EResult.k_EResultOK)
			{
				GameObject mpnmoonbmii = this.levelsScrollRectContent;
				string text = "workshop." + dahgjanlmpi.m_nPublishedFileId.m_PublishedFileId;
				if (Singleton<MapsSystem>.Instance.levelsData.Keys.Contains(text))
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
					if (fullMapData.isLoaded())
					{
						Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					}
					if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
					{
						fullMapData.mapperSteamID = dahgjanlmpi.m_ulSteamIDOwner;
						GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelsListElement, fullMapData, mpnmoonbmii);
					}
				}
				else
				{
					string ieenfemacnd;
					bool queryUGCPreviewURL = SteamUGC.GetQueryUGCPreviewURL(IAFAANLMOAG.m_handle, (uint)j, out ieenfemacnd, 1024U);
					GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddNotDownloadedLevelItemToList(this.levelsNotDownloadedListElement, dahgjanlmpi, ieenfemacnd, mpnmoonbmii);
				}
			}
		}
		if (this.GetMapsCount() == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.notFoundListElement, Vector3.zero, Quaternion.identity);
			gameObject3.transform.SetParent(this.levelsScrollRectContent.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		SteamUGC.ReleaseQueryUGCRequest(IAFAANLMOAG.m_handle);
		if (this.ICJGDDNMHKH > this.HGPMLICPBKA)
		{
			this.ADLHGGOENBP = true;
			this.HGPMLICPBKA++;
			this.PHHPOLMDEIF(true);
			yield break;
		}
		this.ADLHGGOENBP = false;
		this.loadingCanvas.SetActive(false);
		this.levelsScrollRectContentAnimation.SetBool("isVisible", true);
		this.HOAHBPOGNKA();
		yield return true;
		yield break;
	}

	// Token: 0x06011393 RID: 70547 RVA: 0x005EA3EA File Offset: 0x005E85EA
	[CompilerGenerated]
	private static bool NDNCFNHKPCF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isLoved;
	}

	// Token: 0x06011394 RID: 70548 RVA: 0x005EA3F2 File Offset: 0x005E85F2
	public void FIKFJDFELIP()
	{
		this.relaxModeToggle.isOn = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_TapLow", 1, null) == 0);
	}

	// Token: 0x06011395 RID: 70549 RVA: 0x005EA414 File Offset: 0x005E8614
	public void OnSortByDDChanged()
	{
		this.BPLAIMGIOKO = (MapsListSelector.OfficialSortMode)Enum.Parse(typeof(MapsListSelector.OfficialSortMode), this.sortDropDownList.SelectedItem.ID);
		Singleton<SaveSystem>.Instance.SetInt("mapselector.filter.officialsortmode", (int)this.BPLAIMGIOKO, null);
		this.ReloadPage(false);
	}

	// Token: 0x06011396 RID: 70550 RVA: 0x005EA468 File Offset: 0x005E8668
	private IEnumerator JPLHJEKLHAN()
	{
		this.sortDropDownList.gameObject.SetActive(true);
		this.sortDropDownList.Start();
		yield return null;
		dropDownList = this.sortDropDownList;
		dropDownList.Items.Clear();
		this.sortDropDownListText.text = LocalizationService.Instance.GetLocalizatedText("#orderby:").ToUpper();
		num = 0;
		enumerator = Enum.GetValues(typeof(MapsListSelector.OfficialSortMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				MapsListSelector.OfficialSortMode officialSortMode = (MapsListSelector.OfficialSortMode)obj;
				dropDownList.Items.Add(new DropDownListItem(LocalizationService.Instance.GetLocalizatedText("#" + officialSortMode.ToString().ToLower()).ToUpper(), string.Empty + officialSortMode.ToString(), null, false, null));
				num++;
			}
		}
		finally
		{
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		dropDownList.RebuildPanel();
		dropDownList.RedrawPanel();
		dropDownList.SelectItem((int)this.BPLAIMGIOKO, false);
		dropDownList.gameObject.SetActive(this.currentMapsTab == 0 || this.currentMapsTab == 3 || this.currentMapsTab == 4);
		yield break;
	}

	// Token: 0x06011397 RID: 70551 RVA: 0x005EA483 File Offset: 0x005E8683
	public void BMIOFJFMCBG()
	{
		this.relaxModeToggle.isOn = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("BitsData", 0, null) == 0);
	}

	// Token: 0x06011398 RID: 70552 RVA: 0x005EA4A4 File Offset: 0x005E86A4
	public void ApplySortParameters()
	{
		GameObject gameObject = this.tagsScrollRectContent.gameObject;
		foreach (Toggle toggle in gameObject.GetComponentsInChildren<Toggle>())
		{
			Singleton<SaveSystem>.Instance.SetBool("mapselector.tags." + toggle.GetComponentInChildren<Text>().text, toggle.isOn, null);
		}
		Singleton<SaveSystem>.Instance.SetInt("mapselector.orderby", (!this.inTrendToggle.isOn) ? ((!this.recentToggle.isOn) ? 2 : 1) : 0, null);
		Singleton<SaveSystem>.Instance.SetBool("mapselector.filter.subscribedonly", this.subscribedToggle.isOn, null);
		Singleton<SaveSystem>.Instance.SetBool("mapselector.filter.favoriteonly", this.favoriteToggle.isOn, null);
		Singleton<SaveSystem>.Instance.SetBool("mapselector.filter.rateduponly", this.ratedToggle.isOn, null);
		this.CloseSortPanel();
		this.ReloadPage(true);
	}

	// Token: 0x06011399 RID: 70553 RVA: 0x005EA5A0 File Offset: 0x005E87A0
	public void CGILKDFIFHE()
	{
		foreach (string text in Helpers.specialTags)
		{
			if (Singleton<SaveSystem>.Instance.ONOENJPEFDD("MusicFileSelector" + text, true, null))
			{
				SteamUGC.AddRequiredTag(this.FFOJIDODGDO, text);
			}
			else
			{
				SteamUGC.AddExcludedTag(this.FFOJIDODGDO, text);
			}
		}
		foreach (string text2 in Helpers.tags)
		{
			if (Singleton<SaveSystem>.Instance.GetBool("/" + text2, true, null))
			{
				SteamUGC.AddRequiredTag(this.FFOJIDODGDO, text2);
			}
			else
			{
				SteamUGC.AddExcludedTag(this.FFOJIDODGDO, text2);
			}
		}
		SteamUGC.SetMatchAnyTag(this.FFOJIDODGDO, false);
		if (!string.IsNullOrEmpty(this.lastSearch))
		{
			SteamUGC.SetSearchText(this.FFOJIDODGDO, this.lastSearch);
		}
	}

	// Token: 0x0601139A RID: 70554 RVA: 0x005E9FC0 File Offset: 0x005E81C0
	public new void Awake()
	{
		base.Awake();
	}

	// Token: 0x0601139B RID: 70555 RVA: 0x005EA6DC File Offset: 0x005E88DC
	private IEnumerator IGIAHHHPMGP(SteamUGCQueryCompleted_t IAFAANLMOAG)
	{
		gameObject = this.levelsScrollRectContent;
		if (!this.ADLHGGOENBP)
		{
			this.SetMapsCount((int)IAFAANLMOAG.m_unTotalMatchingResults);
			this.KODEDGNDBLA = this.ItemsPerPage();
			this.AOJCGLBEOME = (int)Math.Ceiling((double)this.GetMapsCount() / (double)this.KODEDGNDBLA);
			this.KNLOJGHDLLJ = this.KODEDGNDBLA * this.currentMapsPageID;
			this.NJEPDDEILLL = ((this.KODEDGNDBLA * this.currentMapsPageID + this.KODEDGNDBLA <= this.GetMapsCount()) ? (this.KODEDGNDBLA * this.currentMapsPageID + this.KODEDGNDBLA - 1) : (this.GetMapsCount() - 1));
			if (this.ANFDMOPJFCK != 0)
			{
				this.BGEEOIKJNJG = this.KNLOJGHDLLJ / this.ANFDMOPJFCK + 1;
				this.ICJGDDNMHKH = this.NJEPDDEILLL / this.ANFDMOPJFCK + 1;
			}
			else
			{
				this.BGEEOIKJNJG = 1;
				this.ICJGDDNMHKH = 1;
			}
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			this.HGPMLICPBKA = ((this.BGEEOIKJNJG <= 1) ? 1 : (this.BGEEOIKJNJG - 1));
			this.ADLHGGOENBP = true;
			this.PHHPOLMDEIF(true);
			yield break;
		}
		this.ONKCIDAHIEJ = ((this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK < 0) ? 0 : (this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK));
		this.OPLHKEHGEAN = ((this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK + this.KODEDGNDBLA <= this.ANFDMOPJFCK) ? (this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK + this.KODEDGNDBLA - 1) : (this.ANFDMOPJFCK - 1));
		for (int j = this.ONKCIDAHIEJ; j < this.OPLHKEHGEAN + 1; j++)
		{
			SteamUGCDetails_t dahgjanlmpi;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(IAFAANLMOAG.m_handle, (uint)j, out dahgjanlmpi);
			if (queryUGCResult && dahgjanlmpi.m_eResult == EResult.k_EResultOK)
			{
				GameObject mpnmoonbmii = this.levelsScrollRectContent;
				string text = "workshop." + dahgjanlmpi.m_nPublishedFileId.m_PublishedFileId;
				if (Singleton<MapsSystem>.Instance.levelsData.Keys.Contains(text))
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
					if (fullMapData.isLoaded())
					{
						Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					}
					if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
					{
						fullMapData.mapperSteamID = dahgjanlmpi.m_ulSteamIDOwner;
						GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelsListElement, fullMapData, mpnmoonbmii);
					}
				}
				else
				{
					string ieenfemacnd;
					bool queryUGCPreviewURL = SteamUGC.GetQueryUGCPreviewURL(IAFAANLMOAG.m_handle, (uint)j, out ieenfemacnd, 1024U);
					GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddNotDownloadedLevelItemToList(this.levelsNotDownloadedListElement, dahgjanlmpi, ieenfemacnd, mpnmoonbmii);
				}
			}
		}
		if (this.GetMapsCount() == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.notFoundListElement, Vector3.zero, Quaternion.identity);
			gameObject3.transform.SetParent(this.levelsScrollRectContent.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		SteamUGC.ReleaseQueryUGCRequest(IAFAANLMOAG.m_handle);
		if (this.ICJGDDNMHKH > this.HGPMLICPBKA)
		{
			this.ADLHGGOENBP = true;
			this.HGPMLICPBKA++;
			this.PHHPOLMDEIF(true);
			yield break;
		}
		this.ADLHGGOENBP = false;
		this.loadingCanvas.SetActive(false);
		this.levelsScrollRectContentAnimation.SetBool("isVisible", true);
		this.HOAHBPOGNKA();
		yield return true;
		yield break;
	}

	// Token: 0x0601139C RID: 70556 RVA: 0x005EA700 File Offset: 0x005E8900
	private void GOOCDIPJDIG()
	{
		GameObject gameObject = this.pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1612f, 943f, 673f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -1;
		GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(531f, 529f, 637f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[8];
		array[0] = string.Empty;
		array[0] = this.currentMapsPageID + 0;
		array[0] = "' was created: ";
		array[5] = ((this.AOJCGLBEOME <= 0) ? "_TimeX" : (this.AOJCGLBEOME + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(832f, 1323f, 588f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	// Token: 0x0601139D RID: 70557 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x0601139E RID: 70558 RVA: 0x005EA8B4 File Offset: 0x005E8AB4
	private static float OEKAICLKLJJ(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.JEKMHHCPHCN();
	}

	// Token: 0x0601139F RID: 70559 RVA: 0x005EA8BC File Offset: 0x005E8ABC
	private void ILIOEPNONDH()
	{
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(" not exist", this.currentMapsTab, null);
		if (this.currentMapsTab != 4)
		{
			this.searchInputField.gameObject.SetActive(false);
			this.sortButton.gameObject.SetActive(true);
		}
		else if (!Singleton<SaveSystem>.Instance.GetBool("STICKLHOR", false, null) && !Singleton<SaveSystem>.Instance.ONOENJPEFDD("Data/Localization", false, null) && !Singleton<SaveSystem>.Instance.IOLBIFOIHML("Fade", true, null))
		{
			this.searchInputField.gameObject.SetActive(false);
			this.sortButton.gameObject.SetActive(false);
		}
		else
		{
			this.searchInputField.gameObject.SetActive(true);
			this.sortButton.gameObject.SetActive(true);
		}
		this.BHAPMGBDPFI(this.currentMapsTab == 0 || this.currentMapsTab == 0 || this.currentMapsTab == 7);
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().JEJGLCHMBLF(this.tabs.IndexOf(gameObject) == this.currentMapsTab);
		}
	}

	// Token: 0x060113A0 RID: 70560 RVA: 0x005EAA30 File Offset: 0x005E8C30
	private void EOINCLMOFPE(bool NNIPFHAFNOK = false)
	{
		this.ANFDMOPJFCK = -61;
		this.GOOCDIPJDIG();
		if (this.currentMapsTab == 4)
		{
			EUGCQuery eugcquery = EUGCQuery.k_EUGCQuery_RankedByTrend;
			if (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("player.arrow", 0, null) == 0)
			{
				eugcquery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_MainTex2", 1, null) == 4)
			{
				eugcquery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (eugcquery != EUGCQuery.k_EUGCQuery_NotYetRated)
			{
				Helpers.ObtainAchievement(-95);
			}
			if (!Singleton<SaveSystem>.Instance.ADKHKNJOJEH("_TimeX", true, null) && !Singleton<SaveSystem>.Instance.GIHOKCMHMCP("Set Arcs Speed", false, null) && !Singleton<SaveSystem>.Instance.JJKIDIIMABB("_SecondTex", false, null))
			{
				this.FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eugcquery, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Artwork, (AppId_t)11U, (AppId_t)31U, (uint)this.HGPMLICPBKA);
				this.CGILKDFIFHE();
			}
			else
			{
				if (Singleton<SaveSystem>.Instance.AANPGELPGPN("CameraFilterPack/Broken_Screen", true, null))
				{
					this.FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Screenshots, EUserUGCListSortOrder.k_EUserUGCListSortOrder_SubscriptionDateDesc, (AppId_t)5U, (AppId_t)4294967288U, (uint)this.HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.JJKIDIIMABB("\t", true, null))
				{
					this.FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Videos, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, (AppId_t)150U, (AppId_t)4294967171U, (uint)this.HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.OLJGEIBGDHL("player.goldabstract", true, null))
				{
					this.FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Followed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)75U, (AppId_t)uint.MaxValue, (uint)this.HGPMLICPBKA);
				}
			}
			this.ADLHGGOENBP = NNIPFHAFNOK;
			SteamUGC.SetReturnOnlyIDs(this.FFOJIDODGDO, NNIPFHAFNOK);
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(this.FFOJIDODGDO);
			this.AICOBBBILIL.Set(hAPICall, null);
		}
		if (this.currentMapsTab == 5)
		{
			EUGCQuery eQueryType = EUGCQuery.k_EUGCQuery_RankedByTrend;
			this.FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eQueryType, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Artwork, AppId_t.Invalid, SteamUtils.GetAppID(), (uint)this.HGPMLICPBKA);
			SteamUGC.AddRequiredTag(this.FFOJIDODGDO, "_TimeX");
			SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(this.FFOJIDODGDO);
			this.AICOBBBILIL.Set(hAPICall2, null);
		}
		if (this.currentMapsTab == 0 || this.currentMapsTab == 5 || this.currentMapsTab == 0)
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			List<RanksSystem.Map> list2 = RanksSystem.FIENAHLCHIF();
			if (this.BPLAIMGIOKO == MapsListSelector.OfficialSortMode.Date)
			{
				IEnumerable<RanksSystem.Map> source = RanksSystem.HOCEONHMGHM();
				if (MapsListSelector.LNIJKGECNME == null)
				{
					MapsListSelector.LNIJKGECNME = new Func<RanksSystem.Map, DateTime>(MapsListSelector.DHDNNKEMHCM);
				}
				list2 = source.OrderByDescending(MapsListSelector.LNIJKGECNME).ToList<RanksSystem.Map>();
			}
			if (this.BPLAIMGIOKO == MapsListSelector.OfficialSortMode.Difficulty)
			{
				IEnumerable<RanksSystem.Map> source2 = RanksSystem.FIENAHLCHIF();
				if (MapsListSelector.CLCBJCKCBDD == null)
				{
					MapsListSelector.CLCBJCKCBDD = new Func<RanksSystem.Map, float>(MapsListSelector.OEKAICLKLJJ);
				}
				list2 = source2.OrderBy(MapsListSelector.CLCBJCKCBDD).ToList<RanksSystem.Map>();
			}
			if (this.currentMapsTab == 0)
			{
				IEnumerable<RanksSystem.Map> source3 = list2;
				if (MapsListSelector.HCLEECLNOEA == null)
				{
					MapsListSelector.HCLEECLNOEA = new Func<RanksSystem.Map, bool>(MapsListSelector.NHFFFAMFGEG);
				}
				foreach (RanksSystem.Map map in source3.Where(MapsListSelector.HCLEECLNOEA).ToList<RanksSystem.Map>())
				{
					list.Add((PublishedFileId_t)map.id);
				}
			}
			if (this.currentMapsTab == 8)
			{
				IEnumerable<RanksSystem.Map> source4 = list2;
				if (MapsListSelector.ADLAKIHINOM == null)
				{
					MapsListSelector.ADLAKIHINOM = new Func<RanksSystem.Map, bool>(MapsListSelector.NDNCFNHKPCF);
				}
				foreach (RanksSystem.Map map2 in source4.Where(MapsListSelector.ADLAKIHINOM).ToList<RanksSystem.Map>())
				{
					list.Add((PublishedFileId_t)map2.CHDCIFPPIFI());
				}
			}
			if (this.currentMapsTab == 5)
			{
				IEnumerable<RanksSystem.Map> source5 = list2;
				if (MapsListSelector.KCAPKHIJOHL == null)
				{
					MapsListSelector.KCAPKHIJOHL = new Func<RanksSystem.Map, bool>(MapsListSelector.EFBMHLGDJMM);
				}
				foreach (RanksSystem.Map map3 in source5.Where(MapsListSelector.KCAPKHIJOHL).ToList<RanksSystem.Map>())
				{
					list.Add((PublishedFileId_t)map3.CHDCIFPPIFI());
				}
			}
			this.FFOJIDODGDO = SteamUGC.CreateQueryUGCDetailsRequest(list.ToArray(), (uint)list.Count);
			SteamAPICall_t hAPICall3 = SteamUGC.SendQueryUGCRequest(this.FFOJIDODGDO);
			this.AICOBBBILIL.Set(hAPICall3, null);
		}
	}

	// Token: 0x060113A1 RID: 70561 RVA: 0x005E9F9B File Offset: 0x005E819B
	private void NJIMLMKHOAO(bool IDNLBGOCOEK)
	{
		this.sortDropDownList.SelectItem((int)this.BPLAIMGIOKO, false);
		this.sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	// Token: 0x060113A2 RID: 70562 RVA: 0x005EAEEC File Offset: 0x005E90EC
	public int ItemsPerPage()
	{
		return Singleton<SaveSystem>.Instance.GetInt("settings.selectormapsperpage", 21, null);
	}

	// Token: 0x060113A3 RID: 70563 RVA: 0x005EAF00 File Offset: 0x005E9100
	public void DBFDIGPGHEJ()
	{
		this.sortPanel.gameObject.SetActive(true);
	}

	// Token: 0x060113A4 RID: 70564 RVA: 0x005EAF14 File Offset: 0x005E9114
	private IEnumerator DJPFBFOGOIA()
	{
		this.loadingCanvas.SetActive(true);
		this.levelsScrollRectContentAnimation.SetBool("isVisible", false);
		gameObject = this.levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (this.currentMapsTab == 1)
		{
			kemnopffemd = new MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD();
			kemnopffemd.KAJEFPDIIJA = this;
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> levelsData = Singleton<MapsSystem>.Instance.levelsData;
			if (MapsListSelector.APGNKGEOGPN.LNIJKGECNME == null)
			{
				MapsListSelector.APGNKGEOGPN.LNIJKGECNME = new Func<KeyValuePair<string, FullMapData>, bool>(MapsListSelector.APGNKGEOGPN.GBKBDKHPLKG);
			}
			enumerable = levelsData.Where(MapsListSelector.APGNKGEOGPN.LNIJKGECNME);
			kemnopffemd.AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD kemnopffemd2 = kemnopffemd;
			IEnumerable<KeyValuePair<string, FullMapData>> source = enumerable;
			if (MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD == null)
			{
				MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.HMMBBDJNGGL);
			}
			Func<KeyValuePair<string, FullMapData>, string> clcbjckcbdd = MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD;
			if (MapsListSelector.APGNKGEOGPN.HCLEECLNOEA == null)
			{
				MapsListSelector.APGNKGEOGPN.HCLEECLNOEA = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.NEIDGMKKCBI);
			}
			kemnopffemd2.AKNKMCNHKGH = source.ToDictionary(clcbjckcbdd, MapsListSelector.APGNKGEOGPN.HCLEECLNOEA);
			enumerable2 = kemnopffemd.AKNKMCNHKGH.Where(new Func<KeyValuePair<string, FullMapData>, bool>(kemnopffemd.GBKBDKHPLKG));
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.ADLAKIHINOM == null)
			{
				MapsListSelector.APGNKGEOGPN.ADLAKIHINOM = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.BJGDNLAOMHE);
			}
			Func<KeyValuePair<string, FullMapData>, string> adlakihinom = MapsListSelector.APGNKGEOGPN.ADLAKIHINOM;
			if (MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL == null)
			{
				MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.PEOLMJGDHJK);
			}
			enumerator = source2.ToDictionary(adlakihinom, MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL).Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string jmmilefmacb = enumerator.Current;
					Singleton<MapsSystem>.Instance.LoadLevel(jmmilefmacb, false);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			list = new List<FullMapData>();
			IEnumerable<KeyValuePair<string, FullMapData>> source3 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.DIEBHABBNGF == null)
			{
				MapsListSelector.APGNKGEOGPN.DIEBHABBNGF = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.GLDCBMNHEGA);
			}
			Func<KeyValuePair<string, FullMapData>, string> diebhabbngf = MapsListSelector.APGNKGEOGPN.DIEBHABBNGF;
			if (MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH == null)
			{
				MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.HBICJNIKCNA);
			}
			enumerator2 = source3.ToDictionary(diebhabbngf, MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH).Values.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					FullMapData item = enumerator2.Current;
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
			enumerator3 = list.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ femoopfnglj = new MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ();
					femoopfnglj.KAJEFPDIIJA = this;
					femoopfnglj.NOJGGCLPPAM = enumerator3.Current;
					if (femoopfnglj.NOJGGCLPPAM != null)
					{
						if (!femoopfnglj.NOJGGCLPPAM.isLoaded())
						{
							Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault(new Func<KeyValuePair<string, FullMapData>, bool>(femoopfnglj.GBKBDKHPLKG)).Key, false);
						}
						if ((femoopfnglj.NOJGGCLPPAM.mapData != null && femoopfnglj.NOJGGCLPPAM.isUnlocked()) || (!femoopfnglj.NOJGGCLPPAM.isUnlocked() && !femoopfnglj.NOJGGCLPPAM.mapData.hidden))
						{
							GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelsListElement, femoopfnglj.NOJGGCLPPAM, gameObject);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator3).Dispose();
			}
			this.AOJCGLBEOME = (int)Math.Ceiling((double)kemnopffemd.AKNKMCNHKGH.Count / (double)this.ItemsPerPage());
			this.HOAHBPOGNKA();
			if (kemnopffemd.AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject3.transform.SetParent(this.levelsScrollRectContent.transform, true);
				gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			this.loadingCanvas.SetActive(false);
			this.levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			this.HGPMLICPBKA = 1;
			this.PHHPOLMDEIF(false);
		}
		yield break;
	}

	// Token: 0x060113A5 RID: 70565 RVA: 0x005EAF30 File Offset: 0x005E9130
	private IEnumerator MAMMIDNFMOM()
	{
		this.loadingCanvas.SetActive(true);
		this.levelsScrollRectContentAnimation.SetBool("isVisible", false);
		gameObject = this.levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (this.currentMapsTab == 1)
		{
			kemnopffemd = new MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD();
			kemnopffemd.KAJEFPDIIJA = this;
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> levelsData = Singleton<MapsSystem>.Instance.levelsData;
			if (MapsListSelector.APGNKGEOGPN.LNIJKGECNME == null)
			{
				MapsListSelector.APGNKGEOGPN.LNIJKGECNME = new Func<KeyValuePair<string, FullMapData>, bool>(MapsListSelector.APGNKGEOGPN.GBKBDKHPLKG);
			}
			enumerable = levelsData.Where(MapsListSelector.APGNKGEOGPN.LNIJKGECNME);
			kemnopffemd.AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD kemnopffemd2 = kemnopffemd;
			IEnumerable<KeyValuePair<string, FullMapData>> source = enumerable;
			if (MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD == null)
			{
				MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.HMMBBDJNGGL);
			}
			Func<KeyValuePair<string, FullMapData>, string> clcbjckcbdd = MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD;
			if (MapsListSelector.APGNKGEOGPN.HCLEECLNOEA == null)
			{
				MapsListSelector.APGNKGEOGPN.HCLEECLNOEA = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.NEIDGMKKCBI);
			}
			kemnopffemd2.AKNKMCNHKGH = source.ToDictionary(clcbjckcbdd, MapsListSelector.APGNKGEOGPN.HCLEECLNOEA);
			enumerable2 = kemnopffemd.AKNKMCNHKGH.Where(new Func<KeyValuePair<string, FullMapData>, bool>(kemnopffemd.GBKBDKHPLKG));
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.ADLAKIHINOM == null)
			{
				MapsListSelector.APGNKGEOGPN.ADLAKIHINOM = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.BJGDNLAOMHE);
			}
			Func<KeyValuePair<string, FullMapData>, string> adlakihinom = MapsListSelector.APGNKGEOGPN.ADLAKIHINOM;
			if (MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL == null)
			{
				MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.PEOLMJGDHJK);
			}
			enumerator = source2.ToDictionary(adlakihinom, MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL).Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string jmmilefmacb = enumerator.Current;
					Singleton<MapsSystem>.Instance.LoadLevel(jmmilefmacb, false);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			list = new List<FullMapData>();
			IEnumerable<KeyValuePair<string, FullMapData>> source3 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.DIEBHABBNGF == null)
			{
				MapsListSelector.APGNKGEOGPN.DIEBHABBNGF = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.GLDCBMNHEGA);
			}
			Func<KeyValuePair<string, FullMapData>, string> diebhabbngf = MapsListSelector.APGNKGEOGPN.DIEBHABBNGF;
			if (MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH == null)
			{
				MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.HBICJNIKCNA);
			}
			enumerator2 = source3.ToDictionary(diebhabbngf, MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH).Values.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					FullMapData item = enumerator2.Current;
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
			enumerator3 = list.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ femoopfnglj = new MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ();
					femoopfnglj.KAJEFPDIIJA = this;
					femoopfnglj.NOJGGCLPPAM = enumerator3.Current;
					if (femoopfnglj.NOJGGCLPPAM != null)
					{
						if (!femoopfnglj.NOJGGCLPPAM.isLoaded())
						{
							Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault(new Func<KeyValuePair<string, FullMapData>, bool>(femoopfnglj.GBKBDKHPLKG)).Key, false);
						}
						if ((femoopfnglj.NOJGGCLPPAM.mapData != null && femoopfnglj.NOJGGCLPPAM.isUnlocked()) || (!femoopfnglj.NOJGGCLPPAM.isUnlocked() && !femoopfnglj.NOJGGCLPPAM.mapData.hidden))
						{
							GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelsListElement, femoopfnglj.NOJGGCLPPAM, gameObject);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator3).Dispose();
			}
			this.AOJCGLBEOME = (int)Math.Ceiling((double)kemnopffemd.AKNKMCNHKGH.Count / (double)this.ItemsPerPage());
			this.HOAHBPOGNKA();
			if (kemnopffemd.AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject3.transform.SetParent(this.levelsScrollRectContent.transform, true);
				gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			this.loadingCanvas.SetActive(false);
			this.levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			this.HGPMLICPBKA = 1;
			this.PHHPOLMDEIF(false);
		}
		yield break;
	}

	// Token: 0x060113A6 RID: 70566 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060113A7 RID: 70567 RVA: 0x005EAF4C File Offset: 0x005E914C
	public void ApplySearchFilter()
	{
		foreach (string text in Helpers.specialTags)
		{
			if (Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + text, true, null))
			{
				SteamUGC.AddRequiredTag(this.FFOJIDODGDO, text);
			}
			else
			{
				SteamUGC.AddExcludedTag(this.FFOJIDODGDO, text);
			}
		}
		foreach (string text2 in Helpers.tags)
		{
			if (Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + text2, true, null))
			{
				SteamUGC.AddRequiredTag(this.FFOJIDODGDO, text2);
			}
			else
			{
				SteamUGC.AddExcludedTag(this.FFOJIDODGDO, text2);
			}
		}
		SteamUGC.SetMatchAnyTag(this.FFOJIDODGDO, true);
		if (!string.IsNullOrEmpty(this.lastSearch))
		{
			SteamUGC.SetSearchText(this.FFOJIDODGDO, this.lastSearch);
		}
	}

	// Token: 0x060113A8 RID: 70568 RVA: 0x005EB088 File Offset: 0x005E9288
	public IEnumerator ACJDPJNJBLP(int HLBKCLPNHEB = -1, int MJJNNIMOEIO = -1, List<int> BKNCFOOMKHE = null, bool GLHKMKPDAKP = true, UnityAction KPCNMGBCOLP = null, string DLDLDCOHICL = null)
	{
		if (HLBKCLPNHEB > this.tabs.Count - 1)
		{
			HLBKCLPNHEB = -1;
		}
		yield return new WaitUntil(new Func<bool>(base.GBKBDKHPLKG));
		this.lastSearch = Singleton<SaveSystem>.Instance.GetString("mapselector.lastSearch", string.Empty, null);
		this.searchInputField.text = this.lastSearch;
		this.result = null;
		this.finished = false;
		this.KBLADAACANO = GLHKMKPDAKP;
		if (BKNCFOOMKHE == null)
		{
			for (int i = 0; i < this.tabs.Count; i++)
			{
				this.tabs[i].GetComponent<Button>().interactable = true;
			}
		}
		else
		{
			for (int j = 0; j < this.tabs.Count; j++)
			{
				this.tabs[j].GetComponent<Button>().interactable = BKNCFOOMKHE.Contains(j);
			}
		}
		if (string.IsNullOrEmpty(DLDLDCOHICL))
		{
			DLDLDCOHICL = LocalizationService.Instance.GetTextByKey("back").ToUpper();
		}
		this.HLBKCLPNHEB = HLBKCLPNHEB;
		this.MJJNNIMOEIO = MJJNNIMOEIO;
		this.resultMode = (GameScene.GameMode)Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0, null);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.modeSelector, false, null, true, 0.2f, true));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mapSelector, true, null, true, 0.2f, true));
		this.Init(HLBKCLPNHEB, MJJNNIMOEIO);
		this.buttonBack.onClick.RemoveAllListeners();
		this.buttonBack.GetComponentInChildren<Text>().text = DLDLDCOHICL;
		if (KPCNMGBCOLP != null)
		{
			this.HKDGMEHPLDM = KPCNMGBCOLP;
		}
		else
		{
			this.HKDGMEHPLDM = null;
		}
		this.buttonBack.onClick.RemoveAllListeners();
		this.buttonBack.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		EventSystem.current.SetSelectedGameObject(this.buttonBack.transform.gameObject);
		base.StartCoroutine(this.DPHCONACLFO());
		yield return new WaitUntil(new Func<bool>(base.NEIDGMKKCBI));
		yield return new WaitForSeconds(0.25f);
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null) && GameObject.Find("AudioSampler"))
		{
			GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = false;
		}
		yield break;
	}

	// Token: 0x060113A9 RID: 70569 RVA: 0x005EB0D0 File Offset: 0x005E92D0
	public void IDOOBKLMIJH()
	{
		base.StartCoroutine(Singleton<UI>.Instance.NCMLIDIEECD(this.modeSelector, true, null, true, 1215f, true));
		base.StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(this.mapSelector, true, null, true, 1586f, false));
	}

	// Token: 0x060113AA RID: 70570 RVA: 0x005EB11D File Offset: 0x005E931D
	public void GFLAINNLMBO()
	{
		this.AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.DHODJKNPOLL));
	}

	// Token: 0x060113AB RID: 70571 RVA: 0x005E870C File Offset: 0x005E690C
	public int DLLEKBLFEIE()
	{
		return this.AFOAEMCKEEM;
	}

	// Token: 0x060113AC RID: 70572 RVA: 0x005EB138 File Offset: 0x005E9338
	private IEnumerator MJCANADBPGC()
	{
		this.loadingCanvas.SetActive(true);
		this.levelsScrollRectContentAnimation.SetBool("isVisible", false);
		gameObject = this.levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (this.currentMapsTab == 1)
		{
			kemnopffemd = new MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD();
			kemnopffemd.KAJEFPDIIJA = this;
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> levelsData = Singleton<MapsSystem>.Instance.levelsData;
			if (MapsListSelector.APGNKGEOGPN.LNIJKGECNME == null)
			{
				MapsListSelector.APGNKGEOGPN.LNIJKGECNME = new Func<KeyValuePair<string, FullMapData>, bool>(MapsListSelector.APGNKGEOGPN.GBKBDKHPLKG);
			}
			enumerable = levelsData.Where(MapsListSelector.APGNKGEOGPN.LNIJKGECNME);
			kemnopffemd.AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			MapsListSelector.APGNKGEOGPN.KEMNOPFFEMD kemnopffemd2 = kemnopffemd;
			IEnumerable<KeyValuePair<string, FullMapData>> source = enumerable;
			if (MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD == null)
			{
				MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.HMMBBDJNGGL);
			}
			Func<KeyValuePair<string, FullMapData>, string> clcbjckcbdd = MapsListSelector.APGNKGEOGPN.CLCBJCKCBDD;
			if (MapsListSelector.APGNKGEOGPN.HCLEECLNOEA == null)
			{
				MapsListSelector.APGNKGEOGPN.HCLEECLNOEA = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.NEIDGMKKCBI);
			}
			kemnopffemd2.AKNKMCNHKGH = source.ToDictionary(clcbjckcbdd, MapsListSelector.APGNKGEOGPN.HCLEECLNOEA);
			enumerable2 = kemnopffemd.AKNKMCNHKGH.Where(new Func<KeyValuePair<string, FullMapData>, bool>(kemnopffemd.GBKBDKHPLKG));
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.ADLAKIHINOM == null)
			{
				MapsListSelector.APGNKGEOGPN.ADLAKIHINOM = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.BJGDNLAOMHE);
			}
			Func<KeyValuePair<string, FullMapData>, string> adlakihinom = MapsListSelector.APGNKGEOGPN.ADLAKIHINOM;
			if (MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL == null)
			{
				MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.PEOLMJGDHJK);
			}
			enumerator = source2.ToDictionary(adlakihinom, MapsListSelector.APGNKGEOGPN.KCAPKHIJOHL).Keys.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string jmmilefmacb = enumerator.Current;
					Singleton<MapsSystem>.Instance.LoadLevel(jmmilefmacb, false);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			list = new List<FullMapData>();
			IEnumerable<KeyValuePair<string, FullMapData>> source3 = enumerable2;
			if (MapsListSelector.APGNKGEOGPN.DIEBHABBNGF == null)
			{
				MapsListSelector.APGNKGEOGPN.DIEBHABBNGF = new Func<KeyValuePair<string, FullMapData>, string>(MapsListSelector.APGNKGEOGPN.GLDCBMNHEGA);
			}
			Func<KeyValuePair<string, FullMapData>, string> diebhabbngf = MapsListSelector.APGNKGEOGPN.DIEBHABBNGF;
			if (MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH == null)
			{
				MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH = new Func<KeyValuePair<string, FullMapData>, FullMapData>(MapsListSelector.APGNKGEOGPN.HBICJNIKCNA);
			}
			enumerator2 = source3.ToDictionary(diebhabbngf, MapsListSelector.APGNKGEOGPN.FBNFNGBBKHH).Values.GetEnumerator();
			try
			{
				while (enumerator2.MoveNext())
				{
					FullMapData item = enumerator2.Current;
					if (!list.Contains(item))
					{
						list.Add(item);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
			enumerator3 = list.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ femoopfnglj = new MapsListSelector.APGNKGEOGPN.FEMOOPFNGLJ();
					femoopfnglj.KAJEFPDIIJA = this;
					femoopfnglj.NOJGGCLPPAM = enumerator3.Current;
					if (femoopfnglj.NOJGGCLPPAM != null)
					{
						if (!femoopfnglj.NOJGGCLPPAM.isLoaded())
						{
							Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault(new Func<KeyValuePair<string, FullMapData>, bool>(femoopfnglj.GBKBDKHPLKG)).Key, false);
						}
						if ((femoopfnglj.NOJGGCLPPAM.mapData != null && femoopfnglj.NOJGGCLPPAM.isUnlocked()) || (!femoopfnglj.NOJGGCLPPAM.isUnlocked() && !femoopfnglj.NOJGGCLPPAM.mapData.hidden))
						{
							GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelsListElement, femoopfnglj.NOJGGCLPPAM, gameObject);
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator3).Dispose();
			}
			this.AOJCGLBEOME = (int)Math.Ceiling((double)kemnopffemd.AKNKMCNHKGH.Count / (double)this.ItemsPerPage());
			this.HOAHBPOGNKA();
			if (kemnopffemd.AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject3.transform.SetParent(this.levelsScrollRectContent.transform, true);
				gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			this.loadingCanvas.SetActive(false);
			this.levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			this.HGPMLICPBKA = 1;
			this.PHHPOLMDEIF(false);
		}
		yield break;
	}

	// Token: 0x060113AD RID: 70573 RVA: 0x005EB154 File Offset: 0x005E9354
	private IEnumerator HBNLOHGCGPG(SteamUGCQueryCompleted_t IAFAANLMOAG)
	{
		gameObject = this.levelsScrollRectContent;
		if (!this.ADLHGGOENBP)
		{
			this.SetMapsCount((int)IAFAANLMOAG.m_unTotalMatchingResults);
			this.KODEDGNDBLA = this.ItemsPerPage();
			this.AOJCGLBEOME = (int)Math.Ceiling((double)this.GetMapsCount() / (double)this.KODEDGNDBLA);
			this.KNLOJGHDLLJ = this.KODEDGNDBLA * this.currentMapsPageID;
			this.NJEPDDEILLL = ((this.KODEDGNDBLA * this.currentMapsPageID + this.KODEDGNDBLA <= this.GetMapsCount()) ? (this.KODEDGNDBLA * this.currentMapsPageID + this.KODEDGNDBLA - 1) : (this.GetMapsCount() - 1));
			if (this.ANFDMOPJFCK != 0)
			{
				this.BGEEOIKJNJG = this.KNLOJGHDLLJ / this.ANFDMOPJFCK + 1;
				this.ICJGDDNMHKH = this.NJEPDDEILLL / this.ANFDMOPJFCK + 1;
			}
			else
			{
				this.BGEEOIKJNJG = 1;
				this.ICJGDDNMHKH = 1;
			}
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			this.HGPMLICPBKA = ((this.BGEEOIKJNJG <= 1) ? 1 : (this.BGEEOIKJNJG - 1));
			this.ADLHGGOENBP = true;
			this.PHHPOLMDEIF(true);
			yield break;
		}
		this.ONKCIDAHIEJ = ((this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK < 0) ? 0 : (this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK));
		this.OPLHKEHGEAN = ((this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK + this.KODEDGNDBLA <= this.ANFDMOPJFCK) ? (this.KNLOJGHDLLJ - (this.HGPMLICPBKA - 1) * this.ANFDMOPJFCK + this.KODEDGNDBLA - 1) : (this.ANFDMOPJFCK - 1));
		for (int j = this.ONKCIDAHIEJ; j < this.OPLHKEHGEAN + 1; j++)
		{
			SteamUGCDetails_t dahgjanlmpi;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(IAFAANLMOAG.m_handle, (uint)j, out dahgjanlmpi);
			if (queryUGCResult && dahgjanlmpi.m_eResult == EResult.k_EResultOK)
			{
				GameObject mpnmoonbmii = this.levelsScrollRectContent;
				string text = "workshop." + dahgjanlmpi.m_nPublishedFileId.m_PublishedFileId;
				if (Singleton<MapsSystem>.Instance.levelsData.Keys.Contains(text))
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
					if (fullMapData.isLoaded())
					{
						Singleton<MapsSystem>.Instance.LoadLevel(text, false);
					}
					if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
					{
						fullMapData.mapperSteamID = dahgjanlmpi.m_ulSteamIDOwner;
						GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(this.levelsListElement, fullMapData, mpnmoonbmii);
					}
				}
				else
				{
					string ieenfemacnd;
					bool queryUGCPreviewURL = SteamUGC.GetQueryUGCPreviewURL(IAFAANLMOAG.m_handle, (uint)j, out ieenfemacnd, 1024U);
					GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddNotDownloadedLevelItemToList(this.levelsNotDownloadedListElement, dahgjanlmpi, ieenfemacnd, mpnmoonbmii);
				}
			}
		}
		if (this.GetMapsCount() == 0)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.notFoundListElement, Vector3.zero, Quaternion.identity);
			gameObject3.transform.SetParent(this.levelsScrollRectContent.transform, true);
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		SteamUGC.ReleaseQueryUGCRequest(IAFAANLMOAG.m_handle);
		if (this.ICJGDDNMHKH > this.HGPMLICPBKA)
		{
			this.ADLHGGOENBP = true;
			this.HGPMLICPBKA++;
			this.PHHPOLMDEIF(true);
			yield break;
		}
		this.ADLHGGOENBP = false;
		this.loadingCanvas.SetActive(false);
		this.levelsScrollRectContentAnimation.SetBool("isVisible", true);
		this.HOAHBPOGNKA();
		yield return true;
		yield break;
	}

	// Token: 0x060113AE RID: 70574 RVA: 0x005EB178 File Offset: 0x005E9378
	public void ScrollPage(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (this.currentMapsPageID > 0)
			{
				this.currentMapsPageID--;
				this.ReloadPage(false);
			}
		}
		else if (this.currentMapsPageID + 1 < this.AOJCGLBEOME)
		{
			this.currentMapsPageID++;
			this.ReloadPage(false);
		}
	}

	// Token: 0x060113AF RID: 70575 RVA: 0x005EB1DC File Offset: 0x005E93DC
	public void DLEEFJANJDC(bool IIGAFCONAHP = false)
	{
		if (IIGAFCONAHP)
		{
			this.currentMapsPageID = 1;
		}
		this.BPLAIMGIOKO = (MapsListSelector.OfficialSortMode)Singleton<SaveSystem>.Instance.CMAFBKOEPLP("[Singleton] An instance of '", 1, null);
		this.searchInputField.interactable = (Singleton<SaveSystem>.Instance.OLJGEIBGDHL("/../", true, null) || Singleton<SaveSystem>.Instance.GetBool("Creating new item...", true, null) || Singleton<SaveSystem>.Instance.OLJGEIBGDHL("\\", true, null));
		if (Singleton<SaveSystem>.Instance.GetBool("DPADVER", false, null) || Singleton<SaveSystem>.Instance.EBEAKNGJCDC("[PlayerBase] Loaded music", false, null) || Singleton<SaveSystem>.Instance.GetBool("#md5submitionfailed: ", false, null))
		{
			this.lastSearch = string.Empty;
			Singleton<SaveSystem>.Instance.DAGHAOBCIFL("LogStats", string.Empty, null);
			this.searchInputField.text = string.Empty;
		}
		this.CECPMNODBLA();
		base.StopCoroutine("bool");
		base.StartCoroutine(this.MAMMIDNFMOM());
	}

	// Token: 0x060113B0 RID: 70576 RVA: 0x005EB2EC File Offset: 0x005E94EC
	public void AHBJPEKMOPH()
	{
		this.filterBGPanel.gameObject.SetActive(!this.subscribedToggle.isOn && !this.favoriteToggle.isOn && this.ratedToggle.isOn);
		this.searchInputField.interactable = (Singleton<SaveSystem>.Instance.AANPGELPGPN("_TimeX", false, null) || Singleton<SaveSystem>.Instance.AANPGELPGPN("_Visualize", true, null) || !Singleton<SaveSystem>.Instance.ADKHKNJOJEH("CameraFilterPack/Blend2Camera_VividLight", true, null));
	}

	// Token: 0x04001E4E RID: 7758
	public GameObject modeSelector;

	// Token: 0x04001E4F RID: 7759
	public GameObject mapSelector;

	// Token: 0x04001E50 RID: 7760
	public Button buttonBack;

	// Token: 0x04001E51 RID: 7761
	public bool finished = true;

	// Token: 0x04001E52 RID: 7762
	public string result;

	// Token: 0x04001E53 RID: 7763
	public GameScene.GameMode resultMode = GameScene.GameMode.Normal;

	// Token: 0x04001E54 RID: 7764
	public bool isInited;

	// Token: 0x04001E55 RID: 7765
	public List<GameObject> tabs;

	// Token: 0x04001E56 RID: 7766
	public GameObject levelsListElement;

	// Token: 0x04001E57 RID: 7767
	public GameObject levelsNotDownloadedListElement;

	// Token: 0x04001E58 RID: 7768
	public GameObject notFoundListElement;

	// Token: 0x04001E59 RID: 7769
	public Toggle relaxModeToggle;

	// Token: 0x04001E5A RID: 7770
	public GameObject levelsScrollRectContent;

	// Token: 0x04001E5B RID: 7771
	public Animator levelsScrollRectContentAnimation;

	// Token: 0x04001E5C RID: 7772
	public GameObject loadingCanvas;

	// Token: 0x04001E5D RID: 7773
	public GameObject pageNavScrollRectContent;

	// Token: 0x04001E5E RID: 7774
	public GameObject pageNavPrevPageButton;

	// Token: 0x04001E5F RID: 7775
	public GameObject pageNavCurrentPageButton;

	// Token: 0x04001E60 RID: 7776
	public GameObject pageNavNextPageButton;

	// Token: 0x04001E61 RID: 7777
	[HideInInspector]
	public int currentMapsTab;

	// Token: 0x04001E62 RID: 7778
	[HideInInspector]
	public int currentMapsPageID;

	// Token: 0x04001E63 RID: 7779
	private MapsListSelector.OfficialSortMode BPLAIMGIOKO;

	// Token: 0x04001E64 RID: 7780
	public InputField searchInputField;

	// Token: 0x04001E65 RID: 7781
	public DropDownList sortDropDownList;

	// Token: 0x04001E66 RID: 7782
	public Text sortDropDownListText;

	// Token: 0x04001E67 RID: 7783
	public Button sortButton;

	// Token: 0x04001E68 RID: 7784
	[Header("Sort Panel")]
	public Transform sortPanel;

	// Token: 0x04001E69 RID: 7785
	public Transform tagsScrollRectContent;

	// Token: 0x04001E6A RID: 7786
	public GameObject tagsScrollRectElement;

	// Token: 0x04001E6B RID: 7787
	[Header("Order")]
	public Toggle recentToggle;

	// Token: 0x04001E6C RID: 7788
	public Toggle inTrendToggle;

	// Token: 0x04001E6D RID: 7789
	public Toggle topRatedToggle;

	// Token: 0x04001E6E RID: 7790
	[Header("Filter")]
	public Transform filterBGPanel;

	// Token: 0x04001E6F RID: 7791
	public Toggle subscribedToggle;

	// Token: 0x04001E70 RID: 7792
	public Toggle favoriteToggle;

	// Token: 0x04001E71 RID: 7793
	public Toggle ratedToggle;

	// Token: 0x04001E72 RID: 7794
	private bool KBLADAACANO = true;

	// Token: 0x04001E73 RID: 7795
	private UnityAction HKDGMEHPLDM;

	// Token: 0x04001E74 RID: 7796
	private int HLBKCLPNHEB;

	// Token: 0x04001E75 RID: 7797
	private int MJJNNIMOEIO;

	// Token: 0x04001E76 RID: 7798
	public string lastSearch = string.Empty;

	// Token: 0x04001E77 RID: 7799
	private CallResult<SteamUGCQueryCompleted_t> AICOBBBILIL;

	// Token: 0x04001E78 RID: 7800
	private UGCQueryHandle_t FFOJIDODGDO;

	// Token: 0x04001E79 RID: 7801
	private int AFOAEMCKEEM;

	// Token: 0x04001E7A RID: 7802
	private int HGPMLICPBKA = 1;

	// Token: 0x04001E7B RID: 7803
	private int ANFDMOPJFCK = 50;

	// Token: 0x04001E7C RID: 7804
	private IEnumerator KFBIEPMLCBP;

	// Token: 0x04001E7D RID: 7805
	private int AOJCGLBEOME = 1;

	// Token: 0x04001E7E RID: 7806
	private int KODEDGNDBLA;

	// Token: 0x04001E7F RID: 7807
	private int KNLOJGHDLLJ;

	// Token: 0x04001E80 RID: 7808
	private int NJEPDDEILLL;

	// Token: 0x04001E81 RID: 7809
	private int BGEEOIKJNJG = 1;

	// Token: 0x04001E82 RID: 7810
	private int ICJGDDNMHKH;

	// Token: 0x04001E83 RID: 7811
	private int ONKCIDAHIEJ;

	// Token: 0x04001E84 RID: 7812
	private int OPLHKEHGEAN;

	// Token: 0x04001E85 RID: 7813
	private bool ADLHGGOENBP;

	// Token: 0x04001E86 RID: 7814
	[CompilerGenerated]
	private static Func<RanksSystem.Map, DateTime> LNIJKGECNME;

	// Token: 0x04001E87 RID: 7815
	[CompilerGenerated]
	private static Func<RanksSystem.Map, float> CLCBJCKCBDD;

	// Token: 0x04001E88 RID: 7816
	[CompilerGenerated]
	private static Func<RanksSystem.Map, bool> HCLEECLNOEA;

	// Token: 0x04001E89 RID: 7817
	[CompilerGenerated]
	private static Func<RanksSystem.Map, bool> ADLAKIHINOM;

	// Token: 0x04001E8A RID: 7818
	[CompilerGenerated]
	private static Func<RanksSystem.Map, bool> KCAPKHIJOHL;

	// Token: 0x020004B1 RID: 1201
	public enum OfficialSortMode
	{
		// Token: 0x04001E8C RID: 7820
		Date,
		// Token: 0x04001E8D RID: 7821
		Difficulty
	}
}
