using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000441 RID: 1089
public class MapsSystem : Singleton<MapsSystem>
{
	// Token: 0x0600F7F8 RID: 63480 RVA: 0x00557324 File Offset: 0x00555524
	private void MILGIHKLCHH(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		this.favoriteMaps.Clear();
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.FFOJIDODGDO, (uint)num, out steamUGCDetails_t);
			this.favoriteMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId);
			num++;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.FFOJIDODGDO);
	}

	// Token: 0x0600F7F9 RID: 63481 RVA: 0x00557388 File Offset: 0x00555588
	public IEnumerator IAFOLGHAEHH(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0UL));
			}
		}
		yield return true;
		yield break;
	}

	// Token: 0x0600F7FA RID: 63482 RVA: 0x005573B8 File Offset: 0x005555B8
	public void MGKDFEEBOEL(string NOJGGCLPPAM)
	{
		if (GameObject.Find("player.licenceaccepted"))
		{
			GameObject.Find("_ScreenResolution").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F7FB RID: 63483 RVA: 0x005573E8 File Offset: 0x005555E8
	private void LMEHDOONBKH(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = this.GetMapData("settings.shaders.bloomintencity" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		if (mapData != null)
		{
			this.levelsData.Remove("LoadingStatusText" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F7FC RID: 63484 RVA: 0x00557458 File Offset: 0x00555658
	public IEnumerator PreloadLevel(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0UL));
			}
		}
		yield return true;
		yield break;
	}

	// Token: 0x0600F7FD RID: 63485 RVA: 0x00557488 File Offset: 0x00555688
	private IEnumerator MNCNOOPPMIH(PublishedFileId_t IAFAANLMOAG)
	{
		ulong num;
		string lcccjelgpjo;
		uint num2;
		if (SteamUGC.GetItemInstallInfo(IAFAANLMOAG, out num, out lcccjelgpjo, 1024U, out num2))
		{
			yield return base.StartCoroutine(this.PreloadLevel(string.Empty + IAFAANLMOAG.m_PublishedFileId, lcccjelgpjo, FullMapData.MapSource.Workshop));
		}
		UnityEngine.Debug.Log("[MapsData] Installed: " + IAFAANLMOAG.m_PublishedFileId);
		Helpers.ObtainAchievement(11);
		if (this.BOPDFMGHFFM != null)
		{
			this.BOPDFMGHFFM(this, new MapsSystem.MapSubscribedAndDownloadedEventArgs(IAFAANLMOAG.m_PublishedFileId));
		}
		yield break;
	}

	// Token: 0x0600F7FE RID: 63486 RVA: 0x005574AA File Offset: 0x005556AA
	public bool ECEOJLNJMHN(ulong AHIIAEFFINI)
	{
		return this.favoriteMaps.Contains(AHIIAEFFINI);
	}

	// Token: 0x0600F7FF RID: 63487 RVA: 0x005574B8 File Offset: 0x005556B8
	public FullMapData GetMapData(string JMMILEFMACB)
	{
		if (!string.IsNullOrEmpty(JMMILEFMACB) && this.levelsData.Keys.Contains(JMMILEFMACB))
		{
			return this.levelsData[JMMILEFMACB];
		}
		return null;
	}

	// Token: 0x0600F800 RID: 63488 RVA: 0x0002523B File Offset: 0x0002343B
	private void LAGFIPMHCFN(ItemInstalled_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F801 RID: 63489 RVA: 0x005574EC File Offset: 0x005556EC
	public void NDBOMBCMJEL(string JMMILEFMACB)
	{
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			this.DeleteLevelSave(JMMILEFMACB);
			Helpers.ClearDirectory(this.GetMapData(JMMILEFMACB).fullLevelPath);
			Directory.Delete(this.GetMapData(JMMILEFMACB).fullLevelPath);
			this.levelsData.Remove(JMMILEFMACB);
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F802 RID: 63490 RVA: 0x00557544 File Offset: 0x00555744
	private void IDOBHGMPFAM(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		int num = 1;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.BOKHPFLMPMO, (uint)num, out steamUGCDetails_t);
			if (!this.ratedMaps.Keys.Contains(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId))
			{
				this.ratedMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId, 0);
			}
			else
			{
				this.ratedMaps[steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId] = 1;
			}
			num += 0;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.BOKHPFLMPMO);
	}

	// Token: 0x0600F803 RID: 63491 RVA: 0x005575DC File Offset: 0x005557DC
	private void BFGFMBIKIEB(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		this.favoriteMaps.Clear();
		int num = 1;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.FFOJIDODGDO, (uint)num, out steamUGCDetails_t);
			this.favoriteMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId);
			num += 0;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.FFOJIDODGDO);
	}

	// Token: 0x0600F804 RID: 63492 RVA: 0x00557640 File Offset: 0x00555840
	public void BNIFKLGDHAB(FullMapData JBJGPIHJBMM)
	{
		if (!this.favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			this.favoriteMaps.Add(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.AddItemToFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		this.JEHIMKCKMEA.Set(hAPICall, null);
	}

	// Token: 0x0600F805 RID: 63493 RVA: 0x005576B8 File Offset: 0x005558B8
	public void NFEFBEBEFMI(string JMMILEFMACB)
	{
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			this.DeleteLevelSave(JMMILEFMACB);
			Helpers.ClearDirectory(this.GetMapData(JMMILEFMACB).fullLevelPath);
			Directory.Delete(this.GetMapData(JMMILEFMACB).fullLevelPath);
			this.levelsData.Remove(JMMILEFMACB);
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F806 RID: 63494 RVA: 0x00557710 File Offset: 0x00555910
	public void ABKCDAHHKCF(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("/" + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		this.GGFPKFKFOPP.Set(hAPICall, null);
	}

	// Token: 0x0600F807 RID: 63495 RVA: 0x0055774C File Offset: 0x0055594C
	public void UnsubscribeLevel(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("[MapsData] Unsubscribe " + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		this.GGFPKFKFOPP.Set(hAPICall, null);
	}

	// Token: 0x0600F808 RID: 63496 RVA: 0x0002523B File Offset: 0x0002343B
	private void ILOKADDCIFO(UserFavoriteItemsListChanged_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
	}

	// Token: 0x0600F809 RID: 63497 RVA: 0x00557788 File Offset: 0x00555988
	public IEnumerator ReloadLevelResources(FullMapData LCHEACMLFLL)
	{
		LCHEACMLFLL.resources = new Dictionary<string, UnityEngine.Object>();
		foreach (MapResource mapResource in LCHEACMLFLL.mapData.levelResources)
		{
			if (mapResource.type == "Sprite")
			{
				string fullName = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + mapResource.path).FullName;
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
				Sprite value = (Sprite)ResourcesManager.GetLoadedResource(fullName);
				LCHEACMLFLL.resources.Add(mapResource.name, value);
			}
			if (mapResource.type == "AudioClip")
			{
				string fullName2 = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + LCHEACMLFLL.mapData.musicFile).FullName;
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName2, fullName2, true, false, true));
				AudioClip value2 = (AudioClip)ResourcesManager.GetLoadedResource(fullName2);
				LCHEACMLFLL.resources.Add(mapResource.name, value2);
			}
		}
		yield return null;
		yield break;
	}

	// Token: 0x0600F80A RID: 63498 RVA: 0x005577AC File Offset: 0x005559AC
	public void OnEnable()
	{
		this.AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.MILGIHKLCHH));
		this.GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.BBLFCINDELL));
		this.LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.LHMIJHBGLAJ));
		this.JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(new CallResult<UserFavoriteItemsListChanged_t>.APIDispatchDelegate(this.BODADHMJGGE));
		this.GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(new CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.APIDispatchDelegate(this.HIIJNGBAOOL));
		this.IIODMDMKEKP = Callback<ItemInstalled_t>.Create(new Callback<ItemInstalled_t>.DispatchDelegate(this.MKJDJPOCDCC));
		this.LICPDJCCACG = Callback<DownloadItemResult_t>.Create(new Callback<DownloadItemResult_t>.DispatchDelegate(this.KOJKLLKMELJ));
	}

	// Token: 0x0600F80B RID: 63499 RVA: 0x0055785C File Offset: 0x00555A5C
	private IEnumerator CENINODLGMJ(PublishedFileId_t IAFAANLMOAG)
	{
		if (SteamUGC.GetItemInstallInfo(IAFAANLMOAG, out num, out lcccjelgpjo, 1024U, out num2))
		{
			yield return base.StartCoroutine(this.PreloadLevel(string.Empty + IAFAANLMOAG.m_PublishedFileId, lcccjelgpjo, FullMapData.MapSource.Workshop));
		}
		UnityEngine.Debug.Log("[MapsData] Installed: " + IAFAANLMOAG.m_PublishedFileId);
		Helpers.ObtainAchievement(11);
		if (this.BOPDFMGHFFM != null)
		{
			this.BOPDFMGHFFM(this, new MapsSystem.MapSubscribedAndDownloadedEventArgs(IAFAANLMOAG.m_PublishedFileId));
		}
		yield break;
	}

	// Token: 0x0600F80C RID: 63500 RVA: 0x00557880 File Offset: 0x00555A80
	private void HIIJNGBAOOL(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = this.GetMapData("workshop." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		if (mapData != null)
		{
			this.levelsData.Remove("workshop." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F80D RID: 63501 RVA: 0x005578F0 File Offset: 0x00555AF0
	public GameObject GPJJCOCANMA(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		MapsSystem.IMKOFKOKGCJ imkofkokgcj = new MapsSystem.IMKOFKOKGCJ();
		imkofkokgcj.DAHGJANLMPI = DAHGJANLMPI;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(317f, 73f, 1624f);
		gameObject.GetComponent<MapsListElement>().EPDCHKECMBL(imkofkokgcj.DAHGJANLMPI, IEENFEMACND, imkofkokgcj.DAHGJANLMPI.m_rgchTitle, imkofkokgcj.DAHGJANLMPI.m_ulSteamIDOwner);
		if (this.ECEOJLNJMHN(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(true);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(this.GBFFPCIAIAB(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 0);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(this.GetUserVote(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if (gameObject.transform.FindDeepChild("_NoiseTex") && RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(imkofkokgcj.GBKBDKHPLKG)))
		{
			gameObject.transform.FindDeepChild("GlassesColor2").gameObject.SetActive(true);
		}
		else
		{
			gameObject.transform.FindDeepChild("GlassDistortion").gameObject.SetActive(false);
		}
		string str = "_ScreenResolution" + imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId;
		string hfefhopolik = "Most likely the game became empty during the switch to GameServer." + str + " Server: ";
		int num = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 0, null);
		int num2 = Singleton<SaveSystem>.Instance.ANECPPFPKAP("[MapsData] Base maps loaded" + str + "CameraFilterPack/Gradients_ElectricGradient", 1, null);
		if (num2 == 1)
		{
			gameObject.transform.FindDeepChild("_Value11").GetComponent<Text>().text = "mapselector.tags.";
		}
		else if (num == 0)
		{
			if (gameObject.transform.FindDeepChild("finished"))
			{
				gameObject.transform.FindDeepChild("_Red_C").GetComponent<Text>().text = "_BlurRadius4";
			}
		}
		else
		{
			if (gameObject.transform.FindDeepChild("SpawnObj"))
			{
				gameObject.transform.FindDeepChild("_Value").gameObject.SetActive(false);
			}
			if (gameObject.transform.FindDeepChild("_TintColor"))
			{
				gameObject.transform.FindDeepChild("Deleted event").gameObject.SetActive(true);
			}
		}
		return gameObject;
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x0600F80E RID: 63502 RVA: 0x00557B9C File Offset: 0x00555D9C
	// (remove) Token: 0x0600F82F RID: 63535 RVA: 0x00559744 File Offset: 0x00557944
	public event MapsSystem.MapSubscribedAndDownloadedEventHandler MapSubscribedAndDownloaded
	{
		add
		{
			MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = this.BOPDFMGHFFM;
			MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
			do
			{
				mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
				mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange<MapsSystem.MapSubscribedAndDownloadedEventHandler>(ref this.BOPDFMGHFFM, (MapsSystem.MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, value), mapSubscribedAndDownloadedEventHandler);
			}
			while (mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
		}
		remove
		{
			MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = this.BOPDFMGHFFM;
			MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
			do
			{
				mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
				mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange<MapsSystem.MapSubscribedAndDownloadedEventHandler>(ref this.BOPDFMGHFFM, (MapsSystem.MapSubscribedAndDownloadedEventHandler)Delegate.Remove(mapSubscribedAndDownloadedEventHandler2, value), mapSubscribedAndDownloadedEventHandler);
			}
			while (mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
		}
	}

	// Token: 0x0600F80F RID: 63503 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600F810 RID: 63504 RVA: 0x00557BD4 File Offset: 0x00555DD4
	public IEnumerator LoadIconForLevel(Image AKEPNOGABIA, FullMapData NOJGGCLPPAM)
	{
		string fullName = new FileInfo(NOJGGCLPPAM.fullLevelPath + "/" + NOJGGCLPPAM.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		NOJGGCLPPAM.icon = (Sprite)ResourcesManager.GetLoadedResource(fullName);
		if (AKEPNOGABIA != null)
		{
			try
			{
				AKEPNOGABIA.sprite = NOJGGCLPPAM.icon;
				if (AKEPNOGABIA.GetComponent<AspectRatioFitter>())
				{
					AKEPNOGABIA.GetComponent<AspectRatioFitter>().aspectRatio = NOJGGCLPPAM.icon.rect.size.x / NOJGGCLPPAM.icon.rect.size.y;
				}
			}
			catch (Exception ex)
			{
			}
		}
		yield break;
	}

	// Token: 0x0600F811 RID: 63505 RVA: 0x00557C00 File Offset: 0x00555E00
	public string GetMapID(FullMapData LCHEACMLFLL)
	{
		MapsSystem.KJJEBOMGBFO kjjebomgbfo = new MapsSystem.KJJEBOMGBFO();
		kjjebomgbfo.LCHEACMLFLL = LCHEACMLFLL;
		if (kjjebomgbfo.LCHEACMLFLL != null && this.levelsData.Values.Contains(kjjebomgbfo.LCHEACMLFLL))
		{
			return this.levelsData.FirstOrDefault(new Func<KeyValuePair<string, FullMapData>, bool>(kjjebomgbfo.GBKBDKHPLKG)).Key;
		}
		UnityEngine.Debug.LogError("Map id for" + kjjebomgbfo.LCHEACMLFLL.fullLevelPath + " not found");
		return null;
	}

	// Token: 0x0600F812 RID: 63506 RVA: 0x00557C80 File Offset: 0x00555E80
	private IEnumerator LBDHAAGDAFE(PublishedFileId_t IAFAANLMOAG)
	{
		if (SteamUGC.GetItemInstallInfo(IAFAANLMOAG, out num, out lcccjelgpjo, 1024U, out num2))
		{
			yield return base.StartCoroutine(this.PreloadLevel(string.Empty + IAFAANLMOAG.m_PublishedFileId, lcccjelgpjo, FullMapData.MapSource.Workshop));
		}
		UnityEngine.Debug.Log("[MapsData] Installed: " + IAFAANLMOAG.m_PublishedFileId);
		Helpers.ObtainAchievement(11);
		if (this.BOPDFMGHFFM != null)
		{
			this.BOPDFMGHFFM(this, new MapsSystem.MapSubscribedAndDownloadedEventArgs(IAFAANLMOAG.m_PublishedFileId));
		}
		yield break;
	}

	// Token: 0x0600F813 RID: 63507 RVA: 0x00557CA2 File Offset: 0x00555EA2
	private void Start()
	{
		if (!this.isLoaded)
		{
			this.Init();
		}
	}

	// Token: 0x0600F814 RID: 63508 RVA: 0x00557CA2 File Offset: 0x00555EA2
	private void COIJKMKIEAK()
	{
		if (!this.isLoaded)
		{
			this.Init();
		}
	}

	// Token: 0x0600F815 RID: 63509 RVA: 0x0002523B File Offset: 0x0002343B
	private void BODADHMJGGE(UserFavoriteItemsListChanged_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
	}

	// Token: 0x0600F816 RID: 63510 RVA: 0x00557CB8 File Offset: 0x00555EB8
	private void KLKPKBLJIGJ(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.FNBCFAANGJA, (uint)num, out steamUGCDetails_t);
			if (!this.ratedMaps.Keys.Contains(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId))
			{
				this.ratedMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId, -1);
			}
			else
			{
				this.ratedMaps[steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId] = -1;
			}
			num++;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.FNBCFAANGJA);
	}

	// Token: 0x0600F817 RID: 63511 RVA: 0x00557D50 File Offset: 0x00555F50
	private void BBLFCINDELL(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.BOKHPFLMPMO, (uint)num, out steamUGCDetails_t);
			if (!this.ratedMaps.Keys.Contains(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId))
			{
				this.ratedMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId, 1);
			}
			else
			{
				this.ratedMaps[steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId] = 1;
			}
			num++;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.BOKHPFLMPMO);
	}

	// Token: 0x0600F818 RID: 63512 RVA: 0x00557DE8 File Offset: 0x00555FE8
	public GameObject CHALLJOJCDJ(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		MapsSystem.NHJPHNHAOJF nhjphnhaojf = new MapsSystem.NHJPHNHAOJF();
		nhjphnhaojf.NOJGGCLPPAM = NOJGGCLPPAM;
		if (nhjphnhaojf.NOJGGCLPPAM != null && nhjphnhaojf.NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1228f, 1079f, 1622f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = nhjphnhaojf.NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = nhjphnhaojf.NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = false;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					gameObject.GetComponent<LevelsListElementButton>().GFMKNEGNNJI();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(false);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DBHJFMLJBJK(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId));
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)8 || nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Original)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(false);
				}
				if (gameObject.transform.FindDeepChild("[LevelEditorScene] Error: I/O Failure! :("))
				{
					gameObject.transform.FindDeepChild(".icon").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("_ScreenResolution"))
				{
					gameObject.transform.FindDeepChild("Mouse").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("/../"))
				{
					gameObject.transform.FindDeepChild("_TimeX").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.info;
				}
				if (gameObject.transform.FindDeepChild("EventMenu"))
				{
					gameObject.transform.FindDeepChild("mapselector.lastSearch").gameObject.SetActive(true);
					if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)8)
					{
						MapsSystem.AKEAHLPGOAN akeahlpgoan = new MapsSystem.AKEAHLPGOAN();
						akeahlpgoan.CAFHKDIIDEE = ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId);
						bool flag = RanksSystem.IsOfficial(akeahlpgoan.CAFHKDIIDEE, true);
						if (flag)
						{
							float num = RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(akeahlpgoan.JKEDCEOCPJO)).IFMFDMKFJBI();
							if (num > 59f)
							{
								gameObject.transform.FindDeepChild("finished").gameObject.SetActive(true);
								gameObject.transform.FindDeepChild("float,40").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				string hfefhopolik = "_Blend" + this.GetMapID(nhjphnhaojf.NOJGGCLPPAM) + "y";
				int @int = Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
				if (nhjphnhaojf.NOJGGCLPPAM.BLDMPJOMGDN())
				{
					if (gameObject.transform.FindDeepChild("Data/Maps/"))
					{
						gameObject.transform.FindDeepChild("/").GetComponent<Text>().text = "CameraFilterPack/Blend2Camera_HardLight";
					}
				}
				else if (@int == 0)
				{
					if (gameObject.transform.FindDeepChild("mapselector.orderby"))
					{
						gameObject.transform.FindDeepChild("DPADHOR").GetComponent<Text>().text = "_FgOverlap";
					}
				}
				else
				{
					if (gameObject.transform.FindDeepChild("_PosX"))
					{
						gameObject.transform.FindDeepChild("OneHand").gameObject.SetActive(false);
					}
					if (gameObject.transform.FindDeepChild("GlassAberration"))
					{
						gameObject.transform.FindDeepChild("InfoCanvas").gameObject.SetActive(true);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(((!nhjphnhaojf.NOJGGCLPPAM.NGILJKKGOCI()) ? 0 : 0) == 1);
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)5 && gameObject.transform.FindDeepChild("\nCreated by Oxy949") && RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(nhjphnhaojf.OLIGLEMPFOP)))
				{
					gameObject.transform.FindDeepChild("StartButton").gameObject.SetActive(false);
				}
				else
				{
					gameObject.transform.FindDeepChild("_Offsets").gameObject.SetActive(true);
				}
				if (!nhjphnhaojf.NOJGGCLPPAM.isUnlocked() && nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)3)
				{
					if (gameObject.transform.FindDeepChild(" while connecting to: ") && this.DHDMCJPPACI(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("_TimeX").gameObject.SetActive(true);
					}
					if (gameObject.transform.FindDeepChild("received</b>\n#reason: ") && !this.ECEOJLNJMHN(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("Error: Someone else(").gameObject.SetActive(true);
					}
				}
				if (string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(true);
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source != (FullMapData.MapSource)7 || (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Original && string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(false);
				}
				return gameObject;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.ToString());
				return null;
			}
		}
		return null;
	}

	// Token: 0x0600F819 RID: 63513 RVA: 0x00558488 File Offset: 0x00556688
	public void DownloadVotedList()
	{
		this.BOKHPFLMPMO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedUp, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1U);
		SteamUGC.SetReturnOnlyIDs(this.FFOJIDODGDO, true);
		SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(this.BOKHPFLMPMO);
		this.GNDGFIKPDCC.Set(hAPICall, null);
		this.FNBCFAANGJA = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1U);
		SteamUGC.SetReturnOnlyIDs(this.FFOJIDODGDO, true);
		SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(this.FNBCFAANGJA);
		this.LIPOMMCLODL.Set(hAPICall2, null);
	}

	// Token: 0x0600F81A RID: 63514 RVA: 0x00558530 File Offset: 0x00556730
	public void LIFBFDKFMMH()
	{
		this.AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.MIBPFKKNOPG));
		this.GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.IDOBHGMPFAM));
		this.LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.LHMIJHBGLAJ));
		this.JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(new CallResult<UserFavoriteItemsListChanged_t>.APIDispatchDelegate(this.BODADHMJGGE));
		this.GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(new CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.APIDispatchDelegate(this.NBMLONPNPBP));
		this.IIODMDMKEKP = Callback<ItemInstalled_t>.Create(new Callback<ItemInstalled_t>.DispatchDelegate(this.BLMEFPDNDMI));
		this.LICPDJCCACG = Callback<DownloadItemResult_t>.Create(new Callback<DownloadItemResult_t>.DispatchDelegate(this.KOJKLLKMELJ));
	}

	// Token: 0x0600F81B RID: 63515 RVA: 0x005585E0 File Offset: 0x005567E0
	public void ENHDGEHDMCD(string JMMILEFMACB)
	{
		UnityEngine.Debug.Log("CloseConnection: No such player connected!" + JMMILEFMACB);
		SteamAPICall_t hAPICall = SteamUGC.UnsubscribeItem((PublishedFileId_t)ulong.Parse(JMMILEFMACB));
		this.GGFPKFKFOPP.Set(hAPICall, null);
	}

	// Token: 0x0600F81C RID: 63516 RVA: 0x0055861C File Offset: 0x0055681C
	public void HIFPDKKBDHJ()
	{
		this.AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.MIBPFKKNOPG));
		this.GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.HOCPEBKLECB));
		this.LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.KLKPKBLJIGJ));
		this.JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(new CallResult<UserFavoriteItemsListChanged_t>.APIDispatchDelegate(this.BODADHMJGGE));
		this.GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(new CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.APIDispatchDelegate(this.MCGBFJONNLO));
		this.IIODMDMKEKP = Callback<ItemInstalled_t>.Create(new Callback<ItemInstalled_t>.DispatchDelegate(this.BLMEFPDNDMI));
		this.LICPDJCCACG = Callback<DownloadItemResult_t>.Create(new Callback<DownloadItemResult_t>.DispatchDelegate(this.KOJKLLKMELJ));
	}

	// Token: 0x0600F81D RID: 63517 RVA: 0x005586CA File Offset: 0x005568CA
	public void BKCKODBAIKP(string NOJGGCLPPAM)
	{
		if (GameObject.Find("OnDeserialize"))
		{
			GameObject.Find("ItemTemplate").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F81E RID: 63518 RVA: 0x005586FA File Offset: 0x005568FA
	public void AOEEOKNJDCK()
	{
		this.isLoaded = false;
		base.StartCoroutine(this.EACGMDPBCOG(false));
	}

	// Token: 0x0600F81F RID: 63519 RVA: 0x00558714 File Offset: 0x00556914
	private void CKINKMJGMHI(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.BOKHPFLMPMO, (uint)num, out steamUGCDetails_t);
			if (!this.ratedMaps.Keys.Contains(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId))
			{
				this.ratedMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId, 1);
			}
			else
			{
				this.ratedMaps[steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId] = 1;
			}
			num += 0;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.BOKHPFLMPMO);
	}

	// Token: 0x0600F820 RID: 63520 RVA: 0x005587AC File Offset: 0x005569AC
	public GameObject MEGHFGEHEHM(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		MapsSystem.NHJPHNHAOJF nhjphnhaojf = new MapsSystem.NHJPHNHAOJF();
		nhjphnhaojf.NOJGGCLPPAM = NOJGGCLPPAM;
		if (nhjphnhaojf.NOJGGCLPPAM != null && nhjphnhaojf.NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1546f, 1487f, 979f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = nhjphnhaojf.NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = nhjphnhaojf.NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = false;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)3)
				{
					gameObject.GetComponent<LevelsListElementButton>().LLPJNILPBBI();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(false);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.NACJDBPDMJI(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId));
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)8 || nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Original)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(true);
				}
				if (gameObject.transform.FindDeepChild("_Gamma"))
				{
					gameObject.transform.FindDeepChild("SupportLogger OnJoinedLobby(").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("settings.showHP"))
				{
					gameObject.transform.FindDeepChild("_Value2").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("You need to have a child LayoutGroup content set for the list: "))
				{
					gameObject.transform.FindDeepChild("isVisible").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.info;
				}
				if (gameObject.transform.FindDeepChild("CameraFilterPack/Blend2Camera_LinearDodge"))
				{
					gameObject.transform.FindDeepChild(" - LOCAL").gameObject.SetActive(false);
					if (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
					{
						MapsSystem.AKEAHLPGOAN akeahlpgoan = new MapsSystem.AKEAHLPGOAN();
						akeahlpgoan.CAFHKDIIDEE = ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId);
						bool flag = RanksSystem.IsOfficial(akeahlpgoan.CAFHKDIIDEE, true);
						if (flag)
						{
							float num = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(akeahlpgoan.LLNDDFGPOPL)).PJBPOLLEJFN();
							if (num > 7f)
							{
								gameObject.transform.FindDeepChild("EnableRankedNotificationsToggle").gameObject.SetActive(false);
								gameObject.transform.FindDeepChild("CameraFilterPack/Blend2Camera_Color").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				string hfefhopolik = "Joystick1Button3" + this.GetMapID(nhjphnhaojf.NOJGGCLPPAM) + "menu.tabid";
				int num2 = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 1, null);
				if (nhjphnhaojf.NOJGGCLPPAM.MDKFJHPDIKB())
				{
					if (gameObject.transform.FindDeepChild("_ScreenResolution"))
					{
						gameObject.transform.FindDeepChild("Testing, the group has toggled [").GetComponent<Text>().text = "Misses:";
					}
				}
				else if (num2 == 0)
				{
					if (gameObject.transform.FindDeepChild("_ScreenResolution"))
					{
						gameObject.transform.FindDeepChild("SetParticlesParticleSize").GetComponent<Text>().text = "PossibleMapMaxScoreText";
					}
				}
				else
				{
					if (gameObject.transform.FindDeepChild("_ScreenResolution"))
					{
						gameObject.transform.FindDeepChild("https://www.youtube.com/watch?v=cDVXukrKo74").gameObject.SetActive(false);
					}
					if (gameObject.transform.FindDeepChild("achievements.21.progress"))
					{
						gameObject.transform.FindDeepChild("player.crystal").gameObject.SetActive(false);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(((!nhjphnhaojf.NOJGGCLPPAM.MLDFFCPMHHF()) ? 1 : 1) == 1);
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)5 && gameObject.transform.FindDeepChild("_Bloom5") && RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(nhjphnhaojf.DNIMHEKGJHB)))
				{
					gameObject.transform.FindDeepChild("settings.enablehitsoundsinnormal").gameObject.SetActive(false);
				}
				else
				{
					gameObject.transform.FindDeepChild("player.gamecompleted").gameObject.SetActive(false);
				}
				if (!nhjphnhaojf.NOJGGCLPPAM.isUnlocked() && nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					if (gameObject.transform.FindDeepChild("_Intensity") && this.DHDMCJPPACI(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("DPADHOR").gameObject.SetActive(true);
					}
					if (gameObject.transform.FindDeepChild("settings_bindings_") && !this.DBHJFMLJBJK(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("menu.selectedlevelid").gameObject.SetActive(false);
					}
				}
				if (string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source != (FullMapData.MapSource)3 || (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Original && string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(true);
				}
				return gameObject;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.ToString());
				return null;
			}
		}
		return null;
	}

	// Token: 0x0600F821 RID: 63521 RVA: 0x00558E4C File Offset: 0x0055704C
	private void LHMIJHBGLAJ(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.FNBCFAANGJA, (uint)num, out steamUGCDetails_t);
			if (!this.ratedMaps.Keys.Contains(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId))
			{
				this.ratedMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId, -1);
			}
			else
			{
				this.ratedMaps[steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId] = -1;
			}
			num++;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.FNBCFAANGJA);
	}

	// Token: 0x0600F822 RID: 63522 RVA: 0x00558EE4 File Offset: 0x005570E4
	public void KCCDEMAGBJL(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log("Texture2" + JMMILEFMACB);
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			if (GKLKDAOMNOL)
			{
				mapData.icon = null;
				mapData.clip = null;
			}
			string haebghhmebh = mapData.fullLevelPath + "_copy" + Helpers.levelConfigFileName;
			string text = Helpers.LoadTextString(haebghhmebh, true);
			if (text != null)
			{
				MapData mapData2 = JsonConvert.DeserializeObject<MapData>(text);
				if (mapData.mapData == null || GKLKDAOMNOL)
				{
					mapData.mapData = mapData2;
					Dictionary<string, UnityEngine.Object> resources = new Dictionary<string, UnityEngine.Object>();
					mapData.resources = resources;
					if (mapData.source == FullMapData.MapSource.Editor)
					{
						string value = string.Empty;
						mapData.mapperSteamID = (ulong)SteamUser.GetSteamID();
						string haebghhmebh2 = mapData.fullLevelPath + "_Value2" + Helpers.workshopConfigFileName;
						string text2 = Helpers.LoadTextString(haebghhmebh2, true);
						value = ((text2 != null) ? text2 : null);
						mapData.workshopId = value;
					}
				}
			}
			else
			{
				UnityEngine.Debug.Log("#failed: " + JMMILEFMACB);
			}
		}
	}

	// Token: 0x0600F823 RID: 63523 RVA: 0x00558FEC File Offset: 0x005571EC
	private void AMDEJOONDOM(DownloadItemResult_t IAFAANLMOAG)
	{
		base.StartCoroutine(this.LBDHAAGDAFE(IAFAANLMOAG.m_nPublishedFileId));
	}

	// Token: 0x0600F824 RID: 63524 RVA: 0x00559004 File Offset: 0x00557204
	public void CLOPEPLNPJD(MapsSystem.MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = this.BOPDFMGHFFM;
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange<MapsSystem.MapSubscribedAndDownloadedEventHandler>(ref this.BOPDFMGHFFM, (MapsSystem.MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while (mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
	}

	// Token: 0x0600F825 RID: 63525 RVA: 0x0055903C File Offset: 0x0055723C
	public IEnumerator AKKLMLODKAG(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0UL));
			}
		}
		yield return true;
		yield break;
	}

	// Token: 0x0600F826 RID: 63526 RVA: 0x0055906C File Offset: 0x0055726C
	private void EPFCHMFIHGJ(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = this.GetMapData("_Value13" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		if (mapData != null)
		{
			this.levelsData.Remove("settings.shaders" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F827 RID: 63527 RVA: 0x005590DA File Offset: 0x005572DA
	public int PCMONCGODLC(ulong AHIIAEFFINI)
	{
		if (this.ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return this.ratedMaps[AHIIAEFFINI];
		}
		return 0;
	}

	// Token: 0x0600F828 RID: 63528 RVA: 0x00559100 File Offset: 0x00557300
	private void MIBPFKKNOPG(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		this.favoriteMaps.Clear();
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.FFOJIDODGDO, (uint)num, out steamUGCDetails_t);
			this.favoriteMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId);
			num++;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.FFOJIDODGDO);
	}

	// Token: 0x0600F829 RID: 63529 RVA: 0x00559164 File Offset: 0x00557364
	public void DeleteLevelSave(string JMMILEFMACB)
	{
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".completed", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".played", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".highscore", null);
		IEnumerator enumerator = Enum.GetValues(typeof(GameScene.GameMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Singleton<SaveSystem>.Instance.DeleteKey(string.Concat(new string[]
				{
					"maps.",
					JMMILEFMACB,
					".",
					obj.ToString().ToLower(),
					".highscore"
				}), null);
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
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.time", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.lives", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.correctScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.incorrectScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.powerupsScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.maxLongestCombo", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.longestComboScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".lastCheckpoint.playerdistance", null);
		Helpers.DeleteColorKey("maps." + JMMILEFMACB + ".lastCheckpoint.bgcolor");
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + JMMILEFMACB + ".sawoutdatedmessage", null);
	}

	// Token: 0x0600F82A RID: 63530 RVA: 0x00559360 File Offset: 0x00557560
	public void ACIIHJJKNNC(FullMapData JBJGPIHJBMM)
	{
		if (this.favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			this.favoriteMaps.Remove(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.RemoveItemFromFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		this.JEHIMKCKMEA.Set(hAPICall, null);
	}

	// Token: 0x0600F82B RID: 63531 RVA: 0x005593D8 File Offset: 0x005575D8
	private IEnumerator CFDPKIGCAKA(bool PJDIHKOBGBA = false)
	{
		if (!this.isLoaded || PJDIHKOBGBA)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Helpers.GetDirectory("Data/Maps/"));
			Helpers.CheckDirectory(directoryInfo.FullName);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			UnityEngine.Debug.Log("[MapsData] Found " + directories.Length + " base map(s)");
			for (int i = 0; i < directories.Length; i++)
			{
				this.PreloadLevelNormal(directories[i].Name, directories[i].FullName, FullMapData.MapSource.Original);
			}
			UnityEngine.Debug.Log("[MapsData] Base maps loaded");
			if (SteamAPI.IsSteamRunning())
			{
				PublishedFileId_t[] array = new PublishedFileId_t[65000];
				uint subscribedItems = SteamUGC.GetSubscribedItems(array, 65000U);
				UnityEngine.Debug.Log("[MapsData] Found " + subscribedItems + " workshop map(s)");
				if (subscribedItems > 0U)
				{
					Helpers.ObtainAchievement(11);
				}
				for (uint num = 0U; num < subscribedItems; num += 1U)
				{
					ulong num2;
					string lcccjelgpjo;
					uint num3;
					if (SteamUGC.GetItemInstallInfo(array[(int)((UIntPtr)num)], out num2, out lcccjelgpjo, 1024U, out num3))
					{
						this.PreloadLevelNormal(string.Empty + array[(int)((UIntPtr)num)], lcccjelgpjo, FullMapData.MapSource.Workshop);
					}
				}
			}
			UnityEngine.Debug.Log("[MapsData] Workshop maps was loaded");
			directoryInfo = new DirectoryInfo(Helpers.GetDirectory("Editor/"));
			Helpers.CheckDirectory(directoryInfo.FullName);
			directories = directoryInfo.GetDirectories();
			UnityEngine.Debug.Log("[MapsData] Found " + directories.Length + " user's map(s)");
			for (int j = 0; j < directories.Length; j++)
			{
				this.PreloadLevelNormal(directories[j].Name, directories[j].FullName, FullMapData.MapSource.Editor);
			}
			UnityEngine.Debug.Log("[MapsData] User's maps was loaded");
			this.DownloadFavoriteList();
			this.DownloadVotedList();
		}
		this.isLoaded = true;
		this.isDownloading = false;
		yield break;
	}

	// Token: 0x0600F82C RID: 63532 RVA: 0x005593FC File Offset: 0x005575FC
	public GameObject EDCJGMBHDJM(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		MapsSystem.IMKOFKOKGCJ imkofkokgcj = new MapsSystem.IMKOFKOKGCJ();
		imkofkokgcj.DAHGJANLMPI = DAHGJANLMPI;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(603f, 198f, 1772f);
		gameObject.GetComponent<MapsListElement>().EPDCHKECMBL(imkofkokgcj.DAHGJANLMPI, IEENFEMACND, imkofkokgcj.DAHGJANLMPI.m_rgchTitle, imkofkokgcj.DAHGJANLMPI.m_ulSteamIDOwner);
		if (this.NACJDBPDMJI(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(false);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(this.GetUserVote(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 0);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(this.DDCMPELCOKM(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if (gameObject.transform.FindDeepChild("settings_bindings_sec_") && RanksSystem.HOCEONHMGHM().Exists(new Predicate<RanksSystem.Map>(imkofkokgcj.FCAGEDLBBHD)))
		{
			gameObject.transform.FindDeepChild("Back").gameObject.SetActive(false);
		}
		else
		{
			gameObject.transform.FindDeepChild("Could not execute RPC ").gameObject.SetActive(true);
		}
		string str = "Joystick1Button8" + imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId;
		string hfefhopolik = "menu.resetlevelcheckpoint" + str + "ArcsNoHitsoundTimeDelaySlider";
		int num = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 0, null);
		int @int = Singleton<SaveSystem>.Instance.GetInt("maps." + str + "CameraFilterPack/Gradients_Tech", 1, null);
		if (@int == 1)
		{
			gameObject.transform.FindDeepChild("_StretchWidth").GetComponent<Text>().text = "settings_bindings_sec_";
		}
		else if (num == 0)
		{
			if (gameObject.transform.FindDeepChild("_ScreenResolution"))
			{
				gameObject.transform.FindDeepChild("PublishButton").GetComponent<Text>().text = "float,1.5";
			}
		}
		else
		{
			if (gameObject.transform.FindDeepChild("tagElement"))
			{
				gameObject.transform.FindDeepChild(".b").gameObject.SetActive(false);
			}
			if (gameObject.transform.FindDeepChild("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id."))
			{
				gameObject.transform.FindDeepChild("_Color_G").gameObject.SetActive(false);
			}
		}
		return gameObject;
	}

	// Token: 0x0600F82D RID: 63533 RVA: 0x005596A8 File Offset: 0x005578A8
	public void AddToFavorite(FullMapData JBJGPIHJBMM)
	{
		if (!this.favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			this.favoriteMaps.Add(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.AddItemToFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		this.JEHIMKCKMEA.Set(hAPICall, null);
	}

	// Token: 0x0600F82E RID: 63534 RVA: 0x00559720 File Offset: 0x00557920
	public IEnumerator ReloadLevel(string JMMILEFMACB, string FJDHGDHKNNG, FullMapData.MapSource HLBKCLPNHEB)
	{
		this.LoadLevel(JMMILEFMACB, true);
		yield break;
	}

	// Token: 0x0600F830 RID: 63536 RVA: 0x0054EC28 File Offset: 0x0054CE28
	public void UpdateLoadingInfo(string NOJGGCLPPAM)
	{
		if (GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F831 RID: 63537 RVA: 0x0055977C File Offset: 0x0055797C
	public IEnumerator IOPKNCBLAPI(FullMapData LCHEACMLFLL)
	{
		LCHEACMLFLL.resources = new Dictionary<string, UnityEngine.Object>();
		enumerator = LCHEACMLFLL.mapData.levelResources.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				mapResource = enumerator.Current;
				if (mapResource.type == "Sprite")
				{
					fullName = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + mapResource.path).FullName;
					yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
					value = (Sprite)ResourcesManager.GetLoadedResource(fullName);
					LCHEACMLFLL.resources.Add(mapResource.name, value);
				}
				if (mapResource.type == "AudioClip")
				{
					fullName2 = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + LCHEACMLFLL.mapData.musicFile).FullName;
					yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName2, fullName2, true, false, true));
					value2 = (AudioClip)ResourcesManager.GetLoadedResource(fullName2);
					LCHEACMLFLL.resources.Add(mapResource.name, value2);
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return null;
		yield break;
	}

	// Token: 0x0600F832 RID: 63538 RVA: 0x0055979E File Offset: 0x0055799E
	public void OPKKBMCDOEM()
	{
		this.isLoaded = true;
		base.StartCoroutine(this.WaitForInit(true));
	}

	// Token: 0x0600F833 RID: 63539 RVA: 0x005597B8 File Offset: 0x005579B8
	private void MCGBFJONNLO(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = this.GetMapData("\"" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		if (mapData != null)
		{
			this.levelsData.Remove("_Bloom5" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F834 RID: 63540 RVA: 0x005574AA File Offset: 0x005556AA
	public bool NACJDBPDMJI(ulong AHIIAEFFINI)
	{
		return this.favoriteMaps.Contains(AHIIAEFFINI);
	}

	// Token: 0x0600F835 RID: 63541 RVA: 0x00559828 File Offset: 0x00557A28
	public IEnumerator GOANIMFPCIJ(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0UL));
			}
		}
		yield return true;
		yield break;
	}

	// Token: 0x0600F836 RID: 63542 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x0600F837 RID: 63543 RVA: 0x00559858 File Offset: 0x00557A58
	public void EKGELAAIOCD()
	{
		UnityEngine.Debug.Log("_SecondTex");
		foreach (KeyValuePair<string, FullMapData> keyValuePair in this.levelsData)
		{
			try
			{
				keyValuePair.Value.clip = null;
				keyValuePair.Value.icon = null;
				keyValuePair.Value.mapData = null;
				if (keyValuePair.Value.resources != null)
				{
					keyValuePair.Value.resources.Clear();
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600F838 RID: 63544 RVA: 0x00559918 File Offset: 0x00557B18
	public void FECMEIJGLJI()
	{
		this.isLoaded = false;
		base.StartCoroutine(this.EACGMDPBCOG(true));
	}

	// Token: 0x0600F839 RID: 63545 RVA: 0x00559930 File Offset: 0x00557B30
	public void HNKBKCBDNBG(string JMMILEFMACB)
	{
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			this.DeleteLevelSave(JMMILEFMACB);
			Helpers.ClearDirectory(this.GetMapData(JMMILEFMACB).fullLevelPath);
			Directory.Delete(this.GetMapData(JMMILEFMACB).fullLevelPath);
			this.levelsData.Remove(JMMILEFMACB);
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F83A RID: 63546 RVA: 0x005574AA File Offset: 0x005556AA
	public bool PCFKDFIDAHE(ulong AHIIAEFFINI)
	{
		return this.favoriteMaps.Contains(AHIIAEFFINI);
	}

	// Token: 0x0600F83B RID: 63547 RVA: 0x00559987 File Offset: 0x00557B87
	private void LBAJLLFMMMP()
	{
		if (!this.isLoaded)
		{
			this.AOEEOKNJDCK();
		}
	}

	// Token: 0x0600F83C RID: 63548 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGFECBFNLOM(ItemInstalled_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F83D RID: 63549 RVA: 0x0055999C File Offset: 0x00557B9C
	public void PreloadLevelNormal(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0UL));
			}
		}
	}

	// Token: 0x0600F83E RID: 63550 RVA: 0x00559A10 File Offset: 0x00557C10
	public void JDJNHFHCBDB(string JMMILEFMACB)
	{
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			this.DeleteLevelSave(JMMILEFMACB);
			Helpers.ClearDirectory(this.GetMapData(JMMILEFMACB).fullLevelPath);
			Directory.Delete(this.GetMapData(JMMILEFMACB).fullLevelPath);
			this.levelsData.Remove(JMMILEFMACB);
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F83F RID: 63551 RVA: 0x00559A68 File Offset: 0x00557C68
	private void AEPDCDLJEBE(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = this.GetMapData(" ." + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		if (mapData != null)
		{
			this.levelsData.Remove("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F840 RID: 63552 RVA: 0x00559AD8 File Offset: 0x00557CD8
	public IEnumerator LNLAPPCBPII(bool GKLKDAOMNOL = false)
	{
		yield return base.StartCoroutine(this.CFDPKIGCAKA(GKLKDAOMNOL));
		if (Singleton<Scene>.Instance.name == "MenuScene")
		{
			if (Singleton<MapsListSelector>.Instance.mapSelector.activeInHierarchy)
			{
				Singleton<MapsListSelector>.Instance.ReloadPage(false);
			}
			if (PhotonNetwork.inRoom)
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
			}
		}
		yield break;
	}

	// Token: 0x0600F841 RID: 63553 RVA: 0x00559AFC File Offset: 0x00557CFC
	public IEnumerator EHEEDMNCKFF(Image AKEPNOGABIA, FullMapData NOJGGCLPPAM)
	{
		fullName = new FileInfo(NOJGGCLPPAM.fullLevelPath + "/" + NOJGGCLPPAM.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		NOJGGCLPPAM.icon = (Sprite)ResourcesManager.GetLoadedResource(fullName);
		if (AKEPNOGABIA != null)
		{
			try
			{
				AKEPNOGABIA.sprite = NOJGGCLPPAM.icon;
				if (AKEPNOGABIA.GetComponent<AspectRatioFitter>())
				{
					AKEPNOGABIA.GetComponent<AspectRatioFitter>().aspectRatio = NOJGGCLPPAM.icon.rect.size.x / NOJGGCLPPAM.icon.rect.size.y;
				}
			}
			catch (Exception ex)
			{
			}
		}
		yield break;
	}

	// Token: 0x0600F842 RID: 63554 RVA: 0x00559B28 File Offset: 0x00557D28
	public void JPPGIKCKFJL()
	{
		this.AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.MILGIHKLCHH));
		this.GNDGFIKPDCC = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.BBLFCINDELL));
		this.LIPOMMCLODL = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.LHMIJHBGLAJ));
		this.JEHIMKCKMEA = CallResult<UserFavoriteItemsListChanged_t>.Create(new CallResult<UserFavoriteItemsListChanged_t>.APIDispatchDelegate(this.ILOKADDCIFO));
		this.GGFPKFKFOPP = CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.Create(new CallResult<RemoteStorageUnsubscribePublishedFileResult_t>.APIDispatchDelegate(this.AEPDCDLJEBE));
		this.IIODMDMKEKP = Callback<ItemInstalled_t>.Create(new Callback<ItemInstalled_t>.DispatchDelegate(this.JKBFPILJHJN));
		this.LICPDJCCACG = Callback<DownloadItemResult_t>.Create(new Callback<DownloadItemResult_t>.DispatchDelegate(this.KOJKLLKMELJ));
	}

	// Token: 0x0600F843 RID: 63555 RVA: 0x00559BD6 File Offset: 0x00557DD6
	public int DDCMPELCOKM(ulong AHIIAEFFINI)
	{
		if (this.ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return this.ratedMaps[AHIIAEFFINI];
		}
		return 1;
	}

	// Token: 0x0600F844 RID: 63556 RVA: 0x00559BFC File Offset: 0x00557DFC
	public string GPILFNKPAFH(FullMapData LCHEACMLFLL)
	{
		MapsSystem.KJJEBOMGBFO kjjebomgbfo = new MapsSystem.KJJEBOMGBFO();
		kjjebomgbfo.LCHEACMLFLL = LCHEACMLFLL;
		if (kjjebomgbfo.LCHEACMLFLL != null && this.levelsData.Values.Contains(kjjebomgbfo.LCHEACMLFLL))
		{
			return this.levelsData.FirstOrDefault(new Func<KeyValuePair<string, FullMapData>, bool>(kjjebomgbfo.FFEGPHJKMFK)).Key;
		}
		UnityEngine.Debug.LogError("_Offsets" + kjjebomgbfo.LCHEACMLFLL.fullLevelPath + "SetPlayerDistance");
		return null;
	}

	// Token: 0x0600F845 RID: 63557 RVA: 0x00559C7C File Offset: 0x00557E7C
	public GameObject LIKKNMIHLBD(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		MapsSystem.IMKOFKOKGCJ imkofkokgcj = new MapsSystem.IMKOFKOKGCJ();
		imkofkokgcj.DAHGJANLMPI = DAHGJANLMPI;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(514f, 109f, 899f);
		gameObject.GetComponent<MapsListElement>().Init(imkofkokgcj.DAHGJANLMPI, IEENFEMACND, imkofkokgcj.DAHGJANLMPI.m_rgchTitle, imkofkokgcj.DAHGJANLMPI.m_ulSteamIDOwner);
		if (this.FOIFNLJJICK(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(true);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(this.PCMONCGODLC(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 1);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(this.GBFFPCIAIAB(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if (gameObject.transform.FindDeepChild("{0}_{1}") && RanksSystem.FIENAHLCHIF().Exists(new Predicate<RanksSystem.Map>(imkofkokgcj.JDELIMPGFDJ)))
		{
			gameObject.transform.FindDeepChild("HandleEventLeave for player ID: ").gameObject.SetActive(false);
		}
		else
		{
			gameObject.transform.FindDeepChild("R:").gameObject.SetActive(true);
		}
		string str = "(\\[ */ *b *\\])" + imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId;
		string hfefhopolik = "_NoiseScale" + str + "_ScreenResolution";
		int num = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(hfefhopolik, 1, null);
		int num2 = Singleton<SaveSystem>.Instance.JPEEFKKPFIL("PlayButton" + str + " canvas not found", 0, null);
		if (num2 == 1)
		{
			gameObject.transform.FindDeepChild("[GameScene] Submiting rank").GetComponent<Text>().text = "_Exponent";
		}
		else if (num == 0)
		{
			if (gameObject.transform.FindDeepChild(" workshop map(s)"))
			{
				gameObject.transform.FindDeepChild("unsubscribemap").GetComponent<Text>().text = "input";
			}
		}
		else
		{
			if (gameObject.transform.FindDeepChild("_Green_G"))
			{
				gameObject.transform.FindDeepChild("float,1.5").gameObject.SetActive(false);
			}
			if (gameObject.transform.FindDeepChild("#"))
			{
				gameObject.transform.FindDeepChild("Set satellite audio input").gameObject.SetActive(true);
			}
		}
		return gameObject;
	}

	// Token: 0x0600F846 RID: 63558 RVA: 0x00559F28 File Offset: 0x00558128
	public void DownloadFavoriteList()
	{
		this.FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Favorited, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1U);
		SteamUGC.SetReturnOnlyIDs(this.FFOJIDODGDO, true);
		SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(this.FFOJIDODGDO);
		this.AICOBBBILIL.Set(hAPICall, null);
	}

	// Token: 0x0600F847 RID: 63559 RVA: 0x005590DA File Offset: 0x005572DA
	public int GetUserVote(ulong AHIIAEFFINI)
	{
		if (this.ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return this.ratedMaps[AHIIAEFFINI];
		}
		return 0;
	}

	// Token: 0x0600F848 RID: 63560 RVA: 0x00559F84 File Offset: 0x00558184
	public void HEGBGPNCAHA(MapsSystem.MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = this.BOPDFMGHFFM;
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange<MapsSystem.MapSubscribedAndDownloadedEventHandler>(ref this.BOPDFMGHFFM, (MapsSystem.MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while (mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
	}

	// Token: 0x0600F849 RID: 63561 RVA: 0x00559FBC File Offset: 0x005581BC
	public void SubscribeAndDownload(PublishedFileId_t LIJPBBCJNHD)
	{
		SteamAPICall_t steamAPICall_t = SteamUGC.SubscribeItem(LIJPBBCJNHD);
		SteamUGC.DownloadItem(LIJPBBCJNHD, false);
	}

	// Token: 0x0600F84A RID: 63562 RVA: 0x00559FD8 File Offset: 0x005581D8
	public void NGGPEGIPDDM(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log(": " + JMMILEFMACB);
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			if (GKLKDAOMNOL)
			{
				mapData.icon = null;
				mapData.clip = null;
			}
			string haebghhmebh = mapData.fullLevelPath + "gold" + Helpers.levelConfigFileName;
			string text = Helpers.LoadTextString(haebghhmebh, true);
			if (text != null)
			{
				MapData mapData2 = JsonConvert.DeserializeObject<MapData>(text);
				if (mapData.mapData == null || GKLKDAOMNOL)
				{
					mapData.mapData = mapData2;
					Dictionary<string, UnityEngine.Object> resources = new Dictionary<string, UnityEngine.Object>();
					mapData.resources = resources;
					if (mapData.source == FullMapData.MapSource.Original)
					{
						string value = string.Empty;
						mapData.mapperSteamID = (ulong)SteamUser.GetSteamID();
						string haebghhmebh2 = mapData.fullLevelPath + "Reset XP" + Helpers.workshopConfigFileName;
						string text2 = Helpers.LoadTextString(haebghhmebh2, false);
						value = ((text2 != null) ? text2 : null);
						mapData.workshopId = value;
					}
				}
			}
			else
			{
				UnityEngine.Debug.Log("GlassesColor2" + JMMILEFMACB);
			}
		}
	}

	// Token: 0x0600F84B RID: 63563 RVA: 0x0055A0E0 File Offset: 0x005582E0
	public void NMOMJBGOLNB(MapsSystem.MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = this.BOPDFMGHFFM;
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange<MapsSystem.MapSubscribedAndDownloadedEventHandler>(ref this.BOPDFMGHFFM, (MapsSystem.MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while (mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
	}

	// Token: 0x0600F84C RID: 63564 RVA: 0x005574AA File Offset: 0x005556AA
	public bool DBHJFMLJBJK(ulong AHIIAEFFINI)
	{
		return this.favoriteMaps.Contains(AHIIAEFFINI);
	}

	// Token: 0x0600F84D RID: 63565 RVA: 0x0055A118 File Offset: 0x00558318
	public IEnumerator OEKMKIJGHAL(FullMapData LCHEACMLFLL)
	{
		LCHEACMLFLL.resources = new Dictionary<string, UnityEngine.Object>();
		enumerator = LCHEACMLFLL.mapData.levelResources.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				mapResource = enumerator.Current;
				if (mapResource.type == "Sprite")
				{
					fullName = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + mapResource.path).FullName;
					yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
					value = (Sprite)ResourcesManager.GetLoadedResource(fullName);
					LCHEACMLFLL.resources.Add(mapResource.name, value);
				}
				if (mapResource.type == "AudioClip")
				{
					fullName2 = new FileInfo(LCHEACMLFLL.fullLevelPath + "/" + LCHEACMLFLL.mapData.musicFile).FullName;
					yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName2, fullName2, true, false, true));
					value2 = (AudioClip)ResourcesManager.GetLoadedResource(fullName2);
					LCHEACMLFLL.resources.Add(mapResource.name, value2);
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return null;
		yield break;
	}

	// Token: 0x0600F84E RID: 63566 RVA: 0x0055A13C File Offset: 0x0055833C
	private void HOCPEBKLECB(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.BOKHPFLMPMO, (uint)num, out steamUGCDetails_t);
			if (!this.ratedMaps.Keys.Contains(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId))
			{
				this.ratedMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId, 1);
			}
			else
			{
				this.ratedMaps[steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId] = 0;
			}
			num += 0;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.BOKHPFLMPMO);
	}

	// Token: 0x0600F84F RID: 63567 RVA: 0x0055A1D4 File Offset: 0x005583D4
	public void FBBJNBILBHE(string NOJGGCLPPAM)
	{
		if (GameObject.Find("StartButton"))
		{
			GameObject.Find(".workshop.json").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F850 RID: 63568 RVA: 0x0055A204 File Offset: 0x00558404
	public void HFOMPALDOHI(string JMMILEFMACB)
	{
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			this.DeleteLevelSave(JMMILEFMACB);
			Helpers.ClearDirectory(this.GetMapData(JMMILEFMACB).fullLevelPath);
			Directory.Delete(this.GetMapData(JMMILEFMACB).fullLevelPath);
			this.levelsData.Remove(JMMILEFMACB);
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F851 RID: 63569 RVA: 0x0055A25B File Offset: 0x0055845B
	private void KOJKLLKMELJ(DownloadItemResult_t IAFAANLMOAG)
	{
		base.StartCoroutine(this.CENINODLGMJ(IAFAANLMOAG.m_nPublishedFileId));
	}

	// Token: 0x0600F852 RID: 63570 RVA: 0x0055A274 File Offset: 0x00558474
	public GameObject IIOCCLPBNNM(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		MapsSystem.NHJPHNHAOJF nhjphnhaojf = new MapsSystem.NHJPHNHAOJF();
		nhjphnhaojf.NOJGGCLPPAM = NOJGGCLPPAM;
		if (nhjphnhaojf.NOJGGCLPPAM != null && nhjphnhaojf.NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1126f, 731f, 917f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = nhjphnhaojf.NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = nhjphnhaojf.NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = true;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)5)
				{
					gameObject.GetComponent<LevelsListElementButton>().KLKGNPNONKE();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(true);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DBHJFMLJBJK(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId));
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)8 || nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(true);
				}
				if (gameObject.transform.FindDeepChild("_TimeX"))
				{
					gameObject.transform.FindDeepChild("0").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("_CurveParams"))
				{
					gameObject.transform.FindDeepChild("Brightness").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("Items/"))
				{
					gameObject.transform.FindDeepChild("pointBuffer").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.info;
				}
				if (gameObject.transform.FindDeepChild("icon"))
				{
					gameObject.transform.FindDeepChild("GameModeText").gameObject.SetActive(true);
					if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)6)
					{
						MapsSystem.AKEAHLPGOAN akeahlpgoan = new MapsSystem.AKEAHLPGOAN();
						akeahlpgoan.CAFHKDIIDEE = ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId);
						bool flag = RanksSystem.IsOfficial(akeahlpgoan.CAFHKDIIDEE, false);
						if (flag)
						{
							float difficulty = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(akeahlpgoan.LLNDDFGPOPL)).difficulty;
							if (difficulty > 1451f)
							{
								gameObject.transform.FindDeepChild("menu.playedpage").gameObject.SetActive(false);
								gameObject.transform.FindDeepChild("L2").GetComponentInChildren<Text>().text = string.Empty + difficulty;
							}
						}
					}
				}
				string hfefhopolik = "intensity" + this.GPILFNKPAFH(nhjphnhaojf.NOJGGCLPPAM) + ",";
				int num = Singleton<SaveSystem>.Instance.CMAFBKOEPLP(hfefhopolik, 1, null);
				if (nhjphnhaojf.NOJGGCLPPAM.PIPAOGHLBEK())
				{
					if (gameObject.transform.FindDeepChild("_MainTex2"))
					{
						gameObject.transform.FindDeepChild("_Radius").GetComponent<Text>().text = "kick";
					}
				}
				else if (num == 0)
				{
					if (gameObject.transform.FindDeepChild("_DiffuseColor"))
					{
						gameObject.transform.FindDeepChild("OnEvent: {0}").GetComponent<Text>().text = "InfoCanvas";
					}
				}
				else
				{
					if (gameObject.transform.FindDeepChild("LeaderboardsButton"))
					{
						gameObject.transform.FindDeepChild("CameraFilterPack/BlurTiltShift").gameObject.SetActive(false);
					}
					if (gameObject.transform.FindDeepChild("_SweaterSize"))
					{
						gameObject.transform.FindDeepChild("_Value2").gameObject.SetActive(true);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(((!nhjphnhaojf.NOJGGCLPPAM.FOAKIJPOHEH()) ? 1 : 0) == 0);
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)6 && gameObject.transform.FindDeepChild("_Intensity") && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(nhjphnhaojf.PIJAOCFAPKC)))
				{
					gameObject.transform.FindDeepChild("_FlipAlphaMask").gameObject.SetActive(false);
				}
				else
				{
					gameObject.transform.FindDeepChild("CameraFilterPack/TV_ARCADE_2").gameObject.SetActive(true);
				}
				if (!nhjphnhaojf.NOJGGCLPPAM.NGILJKKGOCI() && nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)4)
				{
					if (gameObject.transform.FindDeepChild("CameraFilterPack/FX_Glitch2") && this.GetUserVote(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("settings_bindings_controller_type").gameObject.SetActive(true);
					}
					if (gameObject.transform.FindDeepChild("Ownership mode == fixed. Ignoring request.") && !this.NACJDBPDMJI(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("Can't set open when not in that room.").gameObject.SetActive(true);
					}
				}
				if (string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source != (FullMapData.MapSource)7 || (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Original && string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(true);
				}
				return gameObject;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.ToString());
				return null;
			}
		}
		return null;
	}

	// Token: 0x0600F853 RID: 63571 RVA: 0x0055A914 File Offset: 0x00558B14
	public void LoadLevel(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log("[MapsData] Preloading " + JMMILEFMACB);
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			if (GKLKDAOMNOL)
			{
				mapData.icon = null;
				mapData.clip = null;
			}
			string haebghhmebh = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			string text = Helpers.LoadTextString(haebghhmebh, true);
			if (text != null)
			{
				MapData mapData2 = JsonConvert.DeserializeObject<MapData>(text);
				if (mapData.mapData == null || GKLKDAOMNOL)
				{
					mapData.mapData = mapData2;
					Dictionary<string, UnityEngine.Object> resources = new Dictionary<string, UnityEngine.Object>();
					mapData.resources = resources;
					if (mapData.source == FullMapData.MapSource.Editor)
					{
						string value = string.Empty;
						mapData.mapperSteamID = (ulong)SteamUser.GetSteamID();
						string haebghhmebh2 = mapData.fullLevelPath + "/" + Helpers.workshopConfigFileName;
						string text2 = Helpers.LoadTextString(haebghhmebh2, true);
						value = ((text2 != null) ? text2 : null);
						mapData.workshopId = value;
					}
				}
			}
			else
			{
				UnityEngine.Debug.Log("[MapsData] Bad map: " + JMMILEFMACB);
			}
		}
	}

	// Token: 0x0600F854 RID: 63572 RVA: 0x0055AA1C File Offset: 0x00558C1C
	private void HDNPIFAJPHA(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.FNBCFAANGJA, (uint)num, out steamUGCDetails_t);
			if (!this.ratedMaps.Keys.Contains(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId))
			{
				this.ratedMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId, -1);
			}
			else
			{
				this.ratedMaps[steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId] = -1;
			}
			num += 0;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.FNBCFAANGJA);
	}

	// Token: 0x0600F855 RID: 63573 RVA: 0x005574AA File Offset: 0x005556AA
	public bool FOIFNLJJICK(ulong AHIIAEFFINI)
	{
		return this.favoriteMaps.Contains(AHIIAEFFINI);
	}

	// Token: 0x0600F856 RID: 63574 RVA: 0x0055AAB4 File Offset: 0x00558CB4
	private void IPOHBDKAGGC(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		this.favoriteMaps.Clear();
		int num = 0;
		while ((long)num < (long)((ulong)IAFAANLMOAG.m_unNumResultsReturned))
		{
			SteamUGCDetails_t steamUGCDetails_t;
			bool queryUGCResult = SteamUGC.GetQueryUGCResult(this.FFOJIDODGDO, (uint)num, out steamUGCDetails_t);
			this.favoriteMaps.Add(steamUGCDetails_t.m_nPublishedFileId.m_PublishedFileId);
			num++;
		}
		SteamUGC.ReleaseQueryUGCRequest(this.FFOJIDODGDO);
	}

	// Token: 0x0600F857 RID: 63575 RVA: 0x0055AB18 File Offset: 0x00558D18
	private void IMCKJCHKMKB()
	{
		if (!this.isLoaded)
		{
			this.OPKKBMCDOEM();
		}
	}

	// Token: 0x0600F858 RID: 63576 RVA: 0x0055AB2C File Offset: 0x00558D2C
	public GameObject OJHDKEOLHFM(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		MapsSystem.NHJPHNHAOJF nhjphnhaojf = new MapsSystem.NHJPHNHAOJF();
		nhjphnhaojf.NOJGGCLPPAM = NOJGGCLPPAM;
		if (nhjphnhaojf.NOJGGCLPPAM != null && nhjphnhaojf.NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(944f, 1712f, 26f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = nhjphnhaojf.NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = nhjphnhaojf.NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = true;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)8)
				{
					gameObject.GetComponent<LevelsListElementButton>().NDPAAEIPFPJ();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(true);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.DBHJFMLJBJK(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId));
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)6 || nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Original)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(false);
				}
				if (gameObject.transform.FindDeepChild(" on effect "))
				{
					gameObject.transform.FindDeepChild("NEW_ACHIEVEMENT_1_21").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("settings.shaders"))
				{
					gameObject.transform.FindDeepChild("_Far").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("addNewButton"))
				{
					gameObject.transform.FindDeepChild("Tab2Content").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.info;
				}
				if (gameObject.transform.FindDeepChild("#later"))
				{
					gameObject.transform.FindDeepChild("<b>#banended</b>").gameObject.SetActive(false);
					if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)4)
					{
						MapsSystem.AKEAHLPGOAN akeahlpgoan = new MapsSystem.AKEAHLPGOAN();
						akeahlpgoan.CAFHKDIIDEE = ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId);
						bool flag = RanksSystem.IsOfficial(akeahlpgoan.CAFHKDIIDEE, false);
						if (flag)
						{
							float num = RanksSystem.FIENAHLCHIF().Find(new Predicate<RanksSystem.Map>(akeahlpgoan.KFNBKFELFLH)).JEKMHHCPHCN();
							if (num > 261f)
							{
								gameObject.transform.FindDeepChild("help").gameObject.SetActive(true);
								gameObject.transform.FindDeepChild("[PlayerController] ").GetComponentInChildren<Text>().text = string.Empty + num;
							}
						}
					}
				}
				string hfefhopolik = "_Value4" + this.GetMapID(nhjphnhaojf.NOJGGCLPPAM) + "masterSteamID";
				int num2 = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(hfefhopolik, 1, null);
				if (nhjphnhaojf.NOJGGCLPPAM.ADBIEAHEION())
				{
					if (gameObject.transform.FindDeepChild("CameraFilterPack/TV_Old_Movie"))
					{
						gameObject.transform.FindDeepChild("_Parameter").GetComponent<Text>().text = "You need to have a Graphic control (such as an Image) for the list [";
					}
				}
				else if (num2 == 0)
				{
					if (gameObject.transform.FindDeepChild("ItemNameText"))
					{
						gameObject.transform.FindDeepChild("_TimeX").GetComponent<Text>().text = "CameraFilterPack/Blur_Radial";
					}
				}
				else
				{
					if (gameObject.transform.FindDeepChild("_Value7"))
					{
						gameObject.transform.FindDeepChild("#.##").gameObject.SetActive(false);
					}
					if (gameObject.transform.FindDeepChild("/../"))
					{
						gameObject.transform.FindDeepChild("CameraFilterPack/Pixel_Pixelisation").gameObject.SetActive(true);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(((!nhjphnhaojf.NOJGGCLPPAM.HELOOLFBJFP()) ? 0 : 1) == 0);
				if (nhjphnhaojf.NOJGGCLPPAM.source == (FullMapData.MapSource)3 && gameObject.transform.FindDeepChild("z") && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(nhjphnhaojf.LLNDDFGPOPL)))
				{
					gameObject.transform.FindDeepChild("player.xp").gameObject.SetActive(true);
				}
				else
				{
					gameObject.transform.FindDeepChild("curScn").gameObject.SetActive(true);
				}
				if (!nhjphnhaojf.NOJGGCLPPAM.GMMJNEOCBPI() && nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					if (gameObject.transform.FindDeepChild(": ") && this.PCMONCGODLC(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("IntraSig").gameObject.SetActive(true);
					}
					if (gameObject.transform.FindDeepChild("_Distortion") && !this.FOIFNLJJICK(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("_CameraClipInfo").gameObject.SetActive(false);
					}
				}
				if (string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source != (FullMapData.MapSource)7 || (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Editor && string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(false);
				}
				return gameObject;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.ToString());
				return null;
			}
		}
		return null;
	}

	// Token: 0x0600F859 RID: 63577 RVA: 0x0055B1CC File Offset: 0x005593CC
	public void JIKKJDJGEIB(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "SetParticlesColor" + JMMILEFMACB;
			UnityEngine.Debug.Log("_ScreenResolution" + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0UL));
			}
		}
	}

	// Token: 0x0600F85A RID: 63578 RVA: 0x0055B240 File Offset: 0x00559440
	public GameObject AddNotDownloadedLevelItemToList(GameObject DFKAGCGIOHC, SteamUGCDetails_t DAHGJANLMPI, string IEENFEMACND, GameObject MPNMOONBMII)
	{
		MapsSystem.IMKOFKOKGCJ imkofkokgcj = new MapsSystem.IMKOFKOKGCJ();
		imkofkokgcj.DAHGJANLMPI = DAHGJANLMPI;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(DFKAGCGIOHC, Vector3.zero, Quaternion.identity);
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.GetComponent<MapsListElement>().Init(imkofkokgcj.DAHGJANLMPI, IEENFEMACND, imkofkokgcj.DAHGJANLMPI.m_rgchTitle, imkofkokgcj.DAHGJANLMPI.m_ulSteamIDOwner);
		if (this.IsMapFavorite(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId))
		{
			gameObject.GetComponent<MapsListElement>().favButton.SetActive(true);
		}
		gameObject.GetComponent<MapsListElement>().ratedUpButton.SetActive(this.GetUserVote(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == 1);
		gameObject.GetComponent<MapsListElement>().ratedDownButton.SetActive(this.GetUserVote(imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId) == -1);
		if (gameObject.transform.FindDeepChild("LeaderboardsButton") && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(imkofkokgcj.GBKBDKHPLKG)))
		{
			gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(true);
		}
		else
		{
			gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(false);
		}
		string str = "workshop." + imkofkokgcj.DAHGJANLMPI.m_nPublishedFileId;
		string hfefhopolik = "maps." + str + ".played";
		int @int = Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
		int int2 = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".completed", 0, null);
		if (int2 == 1)
		{
			gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "COMPLETED";
		}
		else if (@int == 0)
		{
			if (gameObject.transform.FindDeepChild("BadgeText"))
			{
				gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "NEW";
			}
		}
		else
		{
			if (gameObject.transform.FindDeepChild("BadgeText"))
			{
				gameObject.transform.FindDeepChild("BadgeText").gameObject.SetActive(false);
			}
			if (gameObject.transform.FindDeepChild("BadgeImage"))
			{
				gameObject.transform.FindDeepChild("BadgeImage").gameObject.SetActive(false);
			}
		}
		return gameObject;
	}

	// Token: 0x0600F85C RID: 63580 RVA: 0x0055B514 File Offset: 0x00559714
	public IEnumerator EACGMDPBCOG(bool GKLKDAOMNOL = false)
	{
		yield return base.StartCoroutine(this.CFDPKIGCAKA(GKLKDAOMNOL));
		if (Singleton<Scene>.Instance.name == "MenuScene")
		{
			if (Singleton<MapsListSelector>.Instance.mapSelector.activeInHierarchy)
			{
				Singleton<MapsListSelector>.Instance.ReloadPage(false);
			}
			if (PhotonNetwork.inRoom)
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
			}
		}
		yield break;
	}

	// Token: 0x0600F85D RID: 63581 RVA: 0x0002523B File Offset: 0x0002343B
	private void BLMEFPDNDMI(ItemInstalled_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F85E RID: 63582 RVA: 0x0055B538 File Offset: 0x00559738
	public void DeleteLevel(string JMMILEFMACB)
	{
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			this.DeleteLevelSave(JMMILEFMACB);
			Helpers.ClearDirectory(this.GetMapData(JMMILEFMACB).fullLevelPath);
			Directory.Delete(this.GetMapData(JMMILEFMACB).fullLevelPath);
			this.levelsData.Remove(JMMILEFMACB);
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600F85F RID: 63583 RVA: 0x0055B590 File Offset: 0x00559790
	public IEnumerator LKOFGNHHFBC(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "." + JMMILEFMACB;
			UnityEngine.Debug.Log("[MapsData] Caching " + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 0UL));
			}
		}
		yield return true;
		yield break;
	}

	// Token: 0x0600F860 RID: 63584 RVA: 0x00559BD6 File Offset: 0x00557DD6
	public int DHDMCJPPACI(ulong AHIIAEFFINI)
	{
		if (this.ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return this.ratedMaps[AHIIAEFFINI];
		}
		return 1;
	}

	// Token: 0x0600F861 RID: 63585 RVA: 0x0055B5C0 File Offset: 0x005597C0
	public void CGKOPKMMPFE(MapsSystem.MapSubscribedAndDownloadedEventHandler DPNHODJHGJL)
	{
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler = this.BOPDFMGHFFM;
		MapsSystem.MapSubscribedAndDownloadedEventHandler mapSubscribedAndDownloadedEventHandler2;
		do
		{
			mapSubscribedAndDownloadedEventHandler2 = mapSubscribedAndDownloadedEventHandler;
			mapSubscribedAndDownloadedEventHandler = Interlocked.CompareExchange<MapsSystem.MapSubscribedAndDownloadedEventHandler>(ref this.BOPDFMGHFFM, (MapsSystem.MapSubscribedAndDownloadedEventHandler)Delegate.Combine(mapSubscribedAndDownloadedEventHandler2, DPNHODJHGJL), mapSubscribedAndDownloadedEventHandler);
		}
		while (mapSubscribedAndDownloadedEventHandler != mapSubscribedAndDownloadedEventHandler2);
	}

	// Token: 0x0600F862 RID: 63586 RVA: 0x0055B5F8 File Offset: 0x005597F8
	public IEnumerator PreloadWorkshopLevel(string JMMILEFMACB, bool GKLKDAOMNOL = false)
	{
		UnityEngine.Debug.Log("[MapsData] Preloading workshop" + JMMILEFMACB);
		FullMapData mapData = this.GetMapData(JMMILEFMACB);
		if (mapData != null)
		{
			string text = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			yield return base.StartCoroutine(Helpers.LoadText(text, true));
			if (Helpers.textResult[text] != null)
			{
				MapData mapData2 = JsonConvert.DeserializeObject<MapData>(Helpers.textResult[text]);
				if (mapData.mapData == null || GKLKDAOMNOL)
				{
					mapData.mapData = mapData2;
					Dictionary<string, UnityEngine.Object> resources = new Dictionary<string, UnityEngine.Object>();
					mapData.resources = resources;
					if (mapData.source == FullMapData.MapSource.Editor)
					{
						string value = string.Empty;
						string text2 = mapData.fullLevelPath + "/" + Helpers.workshopConfigFileName;
						yield return base.StartCoroutine(Helpers.LoadText(text2, true));
						value = ((Helpers.textResult[text2] != null) ? Helpers.textResult[text2] : null);
						mapData.workshopId = value;
					}
				}
			}
			else
			{
				UnityEngine.Debug.Log("[MapsData] Bad map: " + JMMILEFMACB);
			}
		}
		yield break;
	}

	// Token: 0x0600F863 RID: 63587 RVA: 0x005574AA File Offset: 0x005556AA
	public bool IsMapFavorite(ulong AHIIAEFFINI)
	{
		return this.favoriteMaps.Contains(AHIIAEFFINI);
	}

	// Token: 0x0600F864 RID: 63588 RVA: 0x0055B624 File Offset: 0x00559824
	public IEnumerator WaitForInit(bool GKLKDAOMNOL = false)
	{
		yield return base.StartCoroutine(this.CFDPKIGCAKA(GKLKDAOMNOL));
		if (Singleton<Scene>.Instance.name == "MenuScene")
		{
			if (Singleton<MapsListSelector>.Instance.mapSelector.activeInHierarchy)
			{
				Singleton<MapsListSelector>.Instance.ReloadPage(false);
			}
			if (PhotonNetwork.inRoom)
			{
				((MenuScene)Singleton<Scene>.Instance).GetComponent<NetworkMenu>().UpdateRoom();
			}
		}
		yield break;
	}

	// Token: 0x0600F865 RID: 63589 RVA: 0x0055B648 File Offset: 0x00559848
	public IEnumerator HLGLJHFLMPI(string JMMILEFMACB, string FJDHGDHKNNG, FullMapData.MapSource HLBKCLPNHEB)
	{
		this.LoadLevel(JMMILEFMACB, true);
		yield break;
	}

	// Token: 0x0600F866 RID: 63590 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKJDJPOCDCC(ItemInstalled_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F867 RID: 63591 RVA: 0x0055B66C File Offset: 0x0055986C
	public void MJPPBPEJGFK(string JMMILEFMACB, string LCCCJELGPJO, FullMapData.MapSource HLBKCLPNHEB)
	{
		if (Directory.Exists(LCCCJELGPJO))
		{
			string text = HLBKCLPNHEB.ToString().ToLower() + "CameraFilterPack_AAA_Blood2" + JMMILEFMACB;
			UnityEngine.Debug.Log("back" + text);
			if (!this.levelsData.ContainsKey(text))
			{
				this.levelsData.Add(text, new FullMapData(null, LCCCJELGPJO, HLBKCLPNHEB, null, null, true, null, JMMILEFMACB, 1UL));
			}
		}
	}

	// Token: 0x0600F868 RID: 63592 RVA: 0x0055B6E0 File Offset: 0x005598E0
	public void RemoveFromFavorite(FullMapData JBJGPIHJBMM)
	{
		if (this.favoriteMaps.Contains(ulong.Parse(JBJGPIHJBMM.workshopId)))
		{
			this.favoriteMaps.Remove(ulong.Parse(JBJGPIHJBMM.workshopId));
		}
		SteamAPICall_t hAPICall = SteamUGC.RemoveItemFromFavorites(SteamUtils.GetAppID(), (PublishedFileId_t)ulong.Parse(JBJGPIHJBMM.workshopId));
		this.JEHIMKCKMEA.Set(hAPICall, null);
	}

	// Token: 0x0600F869 RID: 63593 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600F86A RID: 63594 RVA: 0x0055B758 File Offset: 0x00559958
	public IEnumerator ALLJFGKDOKJ(Image AKEPNOGABIA, FullMapData NOJGGCLPPAM)
	{
		fullName = new FileInfo(NOJGGCLPPAM.fullLevelPath + "/" + NOJGGCLPPAM.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		NOJGGCLPPAM.icon = (Sprite)ResourcesManager.GetLoadedResource(fullName);
		if (AKEPNOGABIA != null)
		{
			try
			{
				AKEPNOGABIA.sprite = NOJGGCLPPAM.icon;
				if (AKEPNOGABIA.GetComponent<AspectRatioFitter>())
				{
					AKEPNOGABIA.GetComponent<AspectRatioFitter>().aspectRatio = NOJGGCLPPAM.icon.rect.size.x / NOJGGCLPPAM.icon.rect.size.y;
				}
			}
			catch (Exception ex)
			{
			}
		}
		yield break;
	}

	// Token: 0x0600F86B RID: 63595 RVA: 0x0055B784 File Offset: 0x00559984
	public void UnloadResources()
	{
		UnityEngine.Debug.Log("[MapsSystem] Unloading maps resources...");
		foreach (KeyValuePair<string, FullMapData> keyValuePair in this.levelsData)
		{
			try
			{
				keyValuePair.Value.clip = null;
				keyValuePair.Value.icon = null;
				keyValuePair.Value.mapData = null;
				if (keyValuePair.Value.resources != null)
				{
					keyValuePair.Value.resources.Clear();
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600F86C RID: 63596 RVA: 0x0055B844 File Offset: 0x00559A44
	public void GEENPLPMPCN()
	{
		this.BOKHPFLMPMO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Subscribed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, AppId_t.Invalid, SteamUtils.GetAppID(), 0U);
		SteamUGC.SetReturnOnlyIDs(this.FFOJIDODGDO, true);
		SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(this.BOKHPFLMPMO);
		this.GNDGFIKPDCC.Set(hAPICall, null);
		this.FNBCFAANGJA = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedOn, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Screenshots, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, AppId_t.Invalid, SteamUtils.GetAppID(), 1U);
		SteamUGC.SetReturnOnlyIDs(this.FFOJIDODGDO, false);
		SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(this.FNBCFAANGJA);
		this.LIPOMMCLODL.Set(hAPICall2, null);
	}

	// Token: 0x0600F86D RID: 63597 RVA: 0x0055B8EC File Offset: 0x00559AEC
	public void ACNJBGOIDDJ()
	{
		UnityEngine.Debug.Log("GlassesColor2");
		foreach (KeyValuePair<string, FullMapData> keyValuePair in this.levelsData)
		{
			try
			{
				keyValuePair.Value.clip = null;
				keyValuePair.Value.icon = null;
				keyValuePair.Value.mapData = null;
				if (keyValuePair.Value.resources != null)
				{
					keyValuePair.Value.resources.Clear();
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600F86E RID: 63598 RVA: 0x0055B9AC File Offset: 0x00559BAC
	public GameObject AddDownloadedLevelItemToList(GameObject NFJLMNHCEOA, FullMapData NOJGGCLPPAM, GameObject MPNMOONBMII)
	{
		MapsSystem.NHJPHNHAOJF nhjphnhaojf = new MapsSystem.NHJPHNHAOJF();
		nhjphnhaojf.NOJGGCLPPAM = NOJGGCLPPAM;
		if (nhjphnhaojf.NOJGGCLPPAM != null && nhjphnhaojf.NOJGGCLPPAM.mapData != null)
		{
			try
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(NFJLMNHCEOA, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.GetComponent<LevelsListElementButton>().fullLevelData = nhjphnhaojf.NOJGGCLPPAM;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.clip = nhjphnhaojf.NOJGGCLPPAM.clip;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.loop = true;
				gameObject.GetComponent<LevelsListElementButton>().audioSource.Pause();
				if (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
				{
					gameObject.GetComponent<LevelsListElementButton>().InitRateButton();
					gameObject.GetComponent<LevelsListElementButton>().favButton.SetActive(true);
					gameObject.GetComponent<LevelsListElementButton>().favButton.GetComponent<Toggle>().isOn = Singleton<MapsSystem>.Instance.IsMapFavorite(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId));
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Workshop || nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Editor)
				{
					gameObject.GetComponent<LevelsListElementButton>().delButton.SetActive(true);
				}
				if (gameObject.transform.FindDeepChild("LevelNameText"))
				{
					gameObject.transform.FindDeepChild("LevelNameText").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("InfoCanvas"))
				{
					gameObject.transform.FindDeepChild("NameInfoText").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.name.Replace(Environment.NewLine, string.Empty);
				}
				if (gameObject.transform.FindDeepChild("InfoCanvas"))
				{
					gameObject.transform.FindDeepChild("InfoText").GetComponent<Text>().text = nhjphnhaojf.NOJGGCLPPAM.mapData.info;
				}
				if (gameObject.transform.FindDeepChild("DifficultyBG"))
				{
					gameObject.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(false);
					if (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
					{
						MapsSystem.AKEAHLPGOAN akeahlpgoan = new MapsSystem.AKEAHLPGOAN();
						akeahlpgoan.CAFHKDIIDEE = ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId);
						bool flag = RanksSystem.IsOfficial(akeahlpgoan.CAFHKDIIDEE, false);
						if (flag)
						{
							float difficulty = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(akeahlpgoan.GBKBDKHPLKG)).difficulty;
							if (difficulty > 0f)
							{
								gameObject.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(true);
								gameObject.transform.FindDeepChild("DifficultyBG").GetComponentInChildren<Text>().text = string.Empty + difficulty;
							}
						}
					}
				}
				string hfefhopolik = "maps." + this.GetMapID(nhjphnhaojf.NOJGGCLPPAM) + ".played";
				int @int = Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
				if (nhjphnhaojf.NOJGGCLPPAM.isLevelCompleted())
				{
					if (gameObject.transform.FindDeepChild("BadgeText"))
					{
						gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "COMPLETED";
					}
				}
				else if (@int == 0)
				{
					if (gameObject.transform.FindDeepChild("BadgeText"))
					{
						gameObject.transform.FindDeepChild("BadgeText").GetComponent<Text>().text = "NEW";
					}
				}
				else
				{
					if (gameObject.transform.FindDeepChild("BadgeText"))
					{
						gameObject.transform.FindDeepChild("BadgeText").gameObject.SetActive(false);
					}
					if (gameObject.transform.FindDeepChild("BadgeImage"))
					{
						gameObject.transform.FindDeepChild("BadgeImage").gameObject.SetActive(false);
					}
				}
				gameObject.GetComponent<LevelsListElementButton>().lockedCanvas.SetActive(((!nhjphnhaojf.NOJGGCLPPAM.isUnlocked()) ? 0 : 1) == 0);
				if (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Workshop && gameObject.transform.FindDeepChild("LeaderboardsButton") && RanksSystem.GetOfficialMapsList().Exists(new Predicate<RanksSystem.Map>(nhjphnhaojf.GBKBDKHPLKG)))
				{
					gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(true);
				}
				else
				{
					gameObject.transform.FindDeepChild("LeaderboardsButton").gameObject.SetActive(false);
				}
				if (!nhjphnhaojf.NOJGGCLPPAM.isUnlocked() && nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Workshop)
				{
					if (gameObject.transform.FindDeepChild("RateButton") && this.GetUserVote(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)) == 0)
					{
						gameObject.transform.FindDeepChild("RateButton").gameObject.SetActive(false);
					}
					if (gameObject.transform.FindDeepChild("FavoriteButton") && !this.IsMapFavorite(ulong.Parse(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
					{
						gameObject.transform.FindDeepChild("FavoriteButton").gameObject.SetActive(false);
					}
				}
				if (string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.mapData.moreInfoURL))
				{
					gameObject.GetComponent<LevelsListElementButton>().moreInfoButton.SetActive(false);
				}
				if (nhjphnhaojf.NOJGGCLPPAM.source != FullMapData.MapSource.Workshop || (nhjphnhaojf.NOJGGCLPPAM.source == FullMapData.MapSource.Editor && string.IsNullOrEmpty(nhjphnhaojf.NOJGGCLPPAM.workshopId)))
				{
					gameObject.GetComponent<LevelsListElementButton>().workshopButton.SetActive(false);
				}
				return gameObject;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.ToString());
				return null;
			}
		}
		return null;
	}

	// Token: 0x0600F86F RID: 63599 RVA: 0x0055C04C File Offset: 0x0055A24C
	public void MMLOJFEBOHN(PublishedFileId_t LIJPBBCJNHD)
	{
		SteamAPICall_t steamAPICall_t = SteamUGC.SubscribeItem(LIJPBBCJNHD);
		SteamUGC.DownloadItem(LIJPBBCJNHD, true);
	}

	// Token: 0x0600F870 RID: 63600 RVA: 0x0055C068 File Offset: 0x0055A268
	public void Init()
	{
		this.isLoaded = false;
		base.StartCoroutine(this.WaitForInit(false));
	}

	// Token: 0x0600F871 RID: 63601 RVA: 0x0002523B File Offset: 0x0002343B
	private void JKBFPILJHJN(ItemInstalled_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F872 RID: 63602 RVA: 0x00559BD6 File Offset: 0x00557DD6
	public int GBFFPCIAIAB(ulong AHIIAEFFINI)
	{
		if (this.ratedMaps.Keys.Contains(AHIIAEFFINI))
		{
			return this.ratedMaps[AHIIAEFFINI];
		}
		return 1;
	}

	// Token: 0x0600F873 RID: 63603 RVA: 0x0055C080 File Offset: 0x0055A280
	private void NBMLONPNPBP(RemoteStorageUnsubscribePublishedFileResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		FullMapData mapData = this.GetMapData("_DepthLevel" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		if (mapData != null)
		{
			this.levelsData.Remove("_ScreenResolution" + IAFAANLMOAG.m_nPublishedFileId.m_PublishedFileId.ToString());
		}
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x04001B97 RID: 7063
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private MapsSystem.MapSubscribedAndDownloadedEventHandler BOPDFMGHFFM;

	// Token: 0x04001B98 RID: 7064
	public Dictionary<string, FullMapData> levelsData = new Dictionary<string, FullMapData>();

	// Token: 0x04001B99 RID: 7065
	[HideInInspector]
	public List<ulong> favoriteMaps = new List<ulong>();

	// Token: 0x04001B9A RID: 7066
	[HideInInspector]
	public Dictionary<ulong, int> ratedMaps = new Dictionary<ulong, int>();

	// Token: 0x04001B9B RID: 7067
	public bool isLoaded;

	// Token: 0x04001B9C RID: 7068
	public bool isDownloading;

	// Token: 0x04001B9D RID: 7069
	private Callback<ItemInstalled_t> IIODMDMKEKP;

	// Token: 0x04001B9E RID: 7070
	private Callback<DownloadItemResult_t> LICPDJCCACG;

	// Token: 0x04001B9F RID: 7071
	private CallResult<SteamUGCQueryCompleted_t> AICOBBBILIL;

	// Token: 0x04001BA0 RID: 7072
	private CallResult<SteamUGCQueryCompleted_t> GNDGFIKPDCC;

	// Token: 0x04001BA1 RID: 7073
	private CallResult<SteamUGCQueryCompleted_t> LIPOMMCLODL;

	// Token: 0x04001BA2 RID: 7074
	private CallResult<UserFavoriteItemsListChanged_t> JEHIMKCKMEA;

	// Token: 0x04001BA3 RID: 7075
	private CallResult<RemoteStorageUnsubscribePublishedFileResult_t> GGFPKFKFOPP;

	// Token: 0x04001BA4 RID: 7076
	private UGCQueryHandle_t FFOJIDODGDO;

	// Token: 0x04001BA5 RID: 7077
	private UGCQueryHandle_t BOKHPFLMPMO;

	// Token: 0x04001BA6 RID: 7078
	private UGCQueryHandle_t FNBCFAANGJA;

	// Token: 0x02000442 RID: 1090
	public class MapSubscribedAndDownloadedEventArgs : EventArgs
	{
		// Token: 0x0600F874 RID: 63604 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong EMOAHNADEHK()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F875 RID: 63605 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong JOGMMDACBIF()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F876 RID: 63606 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong AHOCPHPACKE()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F877 RID: 63607 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void PCOLIEMBMHK(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F878 RID: 63608 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong ENDOGIJIIMN()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F879 RID: 63609 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong PGNOPJPKDEA()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F87A RID: 63610 RVA: 0x0055C0FF File Offset: 0x0055A2FF
		public MapSubscribedAndDownloadedEventArgs(ulong JMMILEFMACB)
		{
			this.id = JMMILEFMACB;
		}

		// Token: 0x0600F87B RID: 63611 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void DGCCOLFGGEE(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F87C RID: 63612 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void BBLNMJCGLDI(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F87D RID: 63613 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong OKFOADGNODA()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F87E RID: 63614 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void LBFFJONGODM(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F87F RID: 63615 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void IJJPNEAGAKF(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F880 RID: 63616 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void IMKEMBOIAEJ(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F881 RID: 63617 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void ENBBNKECEIB(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F882 RID: 63618 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void HCAKPOOEHCA(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F883 RID: 63619 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong KBMEBAACODH()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F884 RID: 63620 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong EKIBIEFGIJC()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F885 RID: 63621 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong FAKJNFJPKJI()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F886 RID: 63622 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong IKPGAGMDCLP()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F887 RID: 63623 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong OLBLEAABNJN()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F888 RID: 63624 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void JMKOCDKFFAE(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F889 RID: 63625 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void KDNAFFGAILB(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F88A RID: 63626 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void KPODABLEDLK(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F88B RID: 63627 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong IAPHLAEFPMN()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F88C RID: 63628 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong NJAFAEMEEPG()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F88D RID: 63629 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void NOPJILICFAH(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F88E RID: 63630 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong BEEMEPJAJCD()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F88F RID: 63631 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong BAOHGANDHBD()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F890 RID: 63632 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void BFPEMBLEKAO(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F891 RID: 63633 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong PLCDNOIDALN()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F892 RID: 63634 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong INGBCJIGOJK()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F893 RID: 63635 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void HNNNEJEHIKP(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600F894 RID: 63636 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		// (set) Token: 0x0600F8A0 RID: 63648 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public ulong id { get; set; }

		// Token: 0x0600F895 RID: 63637 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong CHDCIFPPIFI()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F896 RID: 63638 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong MMDJFDPIHLA()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F897 RID: 63639 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong DGMNLDNBIOD()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F898 RID: 63640 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong AHHAMAIOJEG()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F899 RID: 63641 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong KCGOFGJNCME()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F89A RID: 63642 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong ALIBHGIINJN()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F89B RID: 63643 RVA: 0x0055C0F6 File Offset: 0x0055A2F6
		public void LHNBAEOOPDO(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600F89C RID: 63644 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong JABENKBHJGE()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F89D RID: 63645 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong HJCBNLFCNAM()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F89E RID: 63646 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong DGJBCIEBHHM()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F89F RID: 63647 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong CEEKAHOMGKG()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600F8A1 RID: 63649 RVA: 0x0055C0EE File Offset: 0x0055A2EE
		public ulong HLJAGNFLKFM()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}
	}

	// Token: 0x02000443 RID: 1091
	// (Invoke) Token: 0x0600F8A3 RID: 63651
	public delegate void MapSubscribedAndDownloadedEventHandler(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD);

	// Token: 0x02000444 RID: 1092
	[CompilerGenerated]
	private sealed class KJJEBOMGBFO
	{
		// Token: 0x0600F8A6 RID: 63654 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool OLIGLEMPFOP(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8A7 RID: 63655 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool BFEABMIFIEE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8A8 RID: 63656 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool LLNDDFGPOPL(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8A9 RID: 63657 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool LNDGINDKPFA(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8AA RID: 63658 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool BKNHHGBPLGH(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8AB RID: 63659 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool EKHOOPGPPGE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8AC RID: 63660 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool AEINPAGJFME(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8AD RID: 63661 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool MEMPOPNAEDN(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool BDGDIDPDBHG(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8AF RID: 63663 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool FFEGPHJKMFK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool DKGPCPBNDPK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B1 RID: 63665 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool DBFPGFHEGKA(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B2 RID: 63666 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool LOEAMHGMMPK(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B3 RID: 63667 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool KFNBKFELFLH(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool OFHCGKJFGDI(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B5 RID: 63669 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool JKEDCEOCPJO(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B6 RID: 63670 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool PBCAHKDLFPE(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x0600F8B7 RID: 63671 RVA: 0x0055C10E File Offset: 0x0055A30E
		internal bool GBKBDKHPLKG(KeyValuePair<string, FullMapData> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Value == this.LCHEACMLFLL;
		}

		// Token: 0x04001BA8 RID: 7080
		internal FullMapData LCHEACMLFLL;
	}

	// Token: 0x02000445 RID: 1093
	[CompilerGenerated]
	private sealed class NHJPHNHAOJF
	{
		// Token: 0x0600F8BA RID: 63674 RVA: 0x0055C11F File Offset: 0x0055A31F
		internal bool FHIJCPPECHA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8BB RID: 63675 RVA: 0x0055C13E File Offset: 0x0055A33E
		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8BC RID: 63676 RVA: 0x0055C15D File Offset: 0x0055A35D
		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8BD RID: 63677 RVA: 0x0055C17C File Offset: 0x0055A37C
		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8BE RID: 63678 RVA: 0x0055C17C File Offset: 0x0055A37C
		internal bool IGFOBPKFCDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8BF RID: 63679 RVA: 0x0055C11F File Offset: 0x0055A31F
		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C0 RID: 63680 RVA: 0x0055C19B File Offset: 0x0055A39B
		internal bool FCAGEDLBBHD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C1 RID: 63681 RVA: 0x0055C13E File Offset: 0x0055A33E
		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C2 RID: 63682 RVA: 0x0055C1BA File Offset: 0x0055A3BA
		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C3 RID: 63683 RVA: 0x0055C13E File Offset: 0x0055A33E
		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x0055C11F File Offset: 0x0055A31F
		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C5 RID: 63685 RVA: 0x0055C1D9 File Offset: 0x0055A3D9
		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x0055C13E File Offset: 0x0055A33E
		internal bool HBJFIOJFBHC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x0055C1BA File Offset: 0x0055A3BA
		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C8 RID: 63688 RVA: 0x0055C17C File Offset: 0x0055A37C
		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8C9 RID: 63689 RVA: 0x0055C1D9 File Offset: 0x0055A3D9
		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8CA RID: 63690 RVA: 0x0055C15D File Offset: 0x0055A35D
		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8CB RID: 63691 RVA: 0x0055C15D File Offset: 0x0055A35D
		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8CC RID: 63692 RVA: 0x0055C15D File Offset: 0x0055A35D
		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8CD RID: 63693 RVA: 0x0055C13E File Offset: 0x0055A33E
		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8CE RID: 63694 RVA: 0x0055C1D9 File Offset: 0x0055A3D9
		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8CF RID: 63695 RVA: 0x0055C1BA File Offset: 0x0055A3BA
		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D0 RID: 63696 RVA: 0x0055C11F File Offset: 0x0055A31F
		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D1 RID: 63697 RVA: 0x0055C19B File Offset: 0x0055A39B
		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D2 RID: 63698 RVA: 0x0055C17C File Offset: 0x0055A37C
		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D3 RID: 63699 RVA: 0x0055C11F File Offset: 0x0055A31F
		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D4 RID: 63700 RVA: 0x0055C17C File Offset: 0x0055A37C
		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D5 RID: 63701 RVA: 0x0055C11F File Offset: 0x0055A31F
		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D6 RID: 63702 RVA: 0x0055C1BA File Offset: 0x0055A3BA
		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D7 RID: 63703 RVA: 0x0055C13E File Offset: 0x0055A33E
		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x0055C17C File Offset: 0x0055A37C
		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x0600F8D9 RID: 63705 RVA: 0x0055C13E File Offset: 0x0055A33E
		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(this.NOJGGCLPPAM.workshopId);
		}

		// Token: 0x04001BA9 RID: 7081
		internal FullMapData NOJGGCLPPAM;
	}

	// Token: 0x02000446 RID: 1094
	[CompilerGenerated]
	private sealed class AKEAHLPGOAN
	{
		// Token: 0x0600F8DA RID: 63706 RVA: 0x0055C1F8 File Offset: 0x0055A3F8
		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x0055C208 File Offset: 0x0055A408
		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x0055C208 File Offset: 0x0055A408
		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x0055C218 File Offset: 0x0055A418
		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x0055C218 File Offset: 0x0055A418
		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x0055C208 File Offset: 0x0055A408
		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x0055C218 File Offset: 0x0055A418
		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8E1 RID: 63713 RVA: 0x0055C1F8 File Offset: 0x0055A3F8
		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8E2 RID: 63714 RVA: 0x0055C228 File Offset: 0x0055A428
		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x0055C238 File Offset: 0x0055A438
		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x0055C248 File Offset: 0x0055A448
		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.CAFHKDIIDEE;
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x0055C228 File Offset: 0x0055A428
		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x04001BAA RID: 7082
		internal ulong CAFHKDIIDEE;
	}

	// Token: 0x02000447 RID: 1095
	[CompilerGenerated]
	private sealed class IMKOFKOKGCJ
	{
		// Token: 0x0600F8E7 RID: 63719 RVA: 0x0055C258 File Offset: 0x0055A458
		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8E8 RID: 63720 RVA: 0x0055C272 File Offset: 0x0055A472
		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8E9 RID: 63721 RVA: 0x0055C258 File Offset: 0x0055A458
		internal bool FHIJCPPECHA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8EA RID: 63722 RVA: 0x0055C272 File Offset: 0x0055A472
		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8EB RID: 63723 RVA: 0x0055C28C File Offset: 0x0055A48C
		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8EC RID: 63724 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8ED RID: 63725 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8EE RID: 63726 RVA: 0x0055C28C File Offset: 0x0055A48C
		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8EF RID: 63727 RVA: 0x0055C28C File Offset: 0x0055A48C
		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F0 RID: 63728 RVA: 0x0055C272 File Offset: 0x0055A472
		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F1 RID: 63729 RVA: 0x0055C2C0 File Offset: 0x0055A4C0
		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F2 RID: 63730 RVA: 0x0055C2DA File Offset: 0x0055A4DA
		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F3 RID: 63731 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F4 RID: 63732 RVA: 0x0055C272 File Offset: 0x0055A472
		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F5 RID: 63733 RVA: 0x0055C258 File Offset: 0x0055A458
		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F6 RID: 63734 RVA: 0x0055C258 File Offset: 0x0055A458
		internal bool FCAGEDLBBHD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F7 RID: 63735 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool IGFOBPKFCDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8F8 RID: 63736 RVA: 0x0055C2DA File Offset: 0x0055A4DA
		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8FA RID: 63738 RVA: 0x0055C2C0 File Offset: 0x0055A4C0
		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8FB RID: 63739 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8FC RID: 63740 RVA: 0x0055C272 File Offset: 0x0055A472
		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8FD RID: 63741 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8FE RID: 63742 RVA: 0x0055C2DA File Offset: 0x0055A4DA
		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F8FF RID: 63743 RVA: 0x0055C28C File Offset: 0x0055A48C
		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F900 RID: 63744 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F901 RID: 63745 RVA: 0x0055C2F4 File Offset: 0x0055A4F4
		internal bool HBJFIOJFBHC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F902 RID: 63746 RVA: 0x0055C272 File Offset: 0x0055A472
		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F903 RID: 63747 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F904 RID: 63748 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F905 RID: 63749 RVA: 0x0055C2A6 File Offset: 0x0055A4A6
		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F906 RID: 63750 RVA: 0x0055C272 File Offset: 0x0055A472
		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x0600F907 RID: 63751 RVA: 0x0055C2C0 File Offset: 0x0055A4C0
		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.DAHGJANLMPI.m_nPublishedFileId.m_PublishedFileId;
		}

		// Token: 0x04001BAB RID: 7083
		internal SteamUGCDetails_t DAHGJANLMPI;
	}
}
