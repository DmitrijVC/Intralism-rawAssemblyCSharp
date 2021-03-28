using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using AudioVisualizer;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;
using UnityStandardAssets.ImageEffects;

// Token: 0x020004EE RID: 1262
public class MenuScene : global::Scene
{
	// Token: 0x060126D9 RID: 75481 RVA: 0x0066B2BB File Offset: 0x006694BB
	private static bool NBIBOHPOCBN(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.IFAJDLKJIDL() > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.InProgress;
	}

	// Token: 0x060126DA RID: 75482 RVA: 0x0066B2D5 File Offset: 0x006694D5
	public void OnDisableStoryboardToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetBool("settings.disablestoryboard", true, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetBool("settings.disablestoryboard", false, null);
		}
	}

	// Token: 0x060126DB RID: 75483 RVA: 0x0066B304 File Offset: 0x00669504
	private static bool PMFJPFHKBPG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "[MenuScene] Error: ";
	}

	// Token: 0x060126DC RID: 75484 RVA: 0x0066B316 File Offset: 0x00669516
	private static bool CFEMMOPIPHE(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Value";
	}

	// Token: 0x060126DD RID: 75485 RVA: 0x0066B328 File Offset: 0x00669528
	private void MFODMAECFGP()
	{
		try
		{
			base.StartCoroutine(this.OCIPHAEEGGO());
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("[MenuScene] Error: " + ex.ToString());
		}
	}

	// Token: 0x060126DE RID: 75486 RVA: 0x0066B374 File Offset: 0x00669574
	public void DAOELGHGILE()
	{
		Transform transform = GameObject.Find("_Value").transform;
		Singleton<SaveSystem>.Instance.LBFFJLFBOAM("]", transform.FindDeepChild("#").GetComponent<Toggle>().isOn, null);
	}

	// Token: 0x060126DF RID: 75487 RVA: 0x0066B3B8 File Offset: 0x006695B8
	public void NENLDJGMNOD()
	{
		Transform transform = GameObject.Find("CameraFilterPack/FX_InverChromiLum").transform;
		Screen.SetResolution((int)this.BNEGFAHKIAA[this.KNOAFBDEBDK].x, (int)this.BNEGFAHKIAA[this.KNOAFBDEBDK].y, transform.FindDeepChild("InfoText").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)transform.FindDeepChild("CameraFilterPack/Blend2Camera_Overlay").GetComponent<Slider>().value);
		base.GetComponent<ShadersSettings>().CIPIONFIKBP(transform.FindDeepChild("There is already a virtual button named ").GetComponent<Toggle>().isOn);
		base.GetComponent<FPSSettings>().SetFPSEnabled(transform.FindDeepChild("_Value").GetComponent<Toggle>().isOn);
	}

	// Token: 0x060126E0 RID: 75488 RVA: 0x0066B47E File Offset: 0x0066967E
	public void WriteReview()
	{
		Singleton<GameManager>.Instance.OpenURL("https://store.steampowered.com/recommended/recommendgame/" + SteamUtils.GetAppID(), true);
	}

	// Token: 0x060126E1 RID: 75489 RVA: 0x0066B49F File Offset: 0x0066969F
	private static bool PCIJHOHOMNH(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction";
	}

	// Token: 0x060126E2 RID: 75490 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnWorkshopButton()
	{
	}

	// Token: 0x060126E3 RID: 75491 RVA: 0x0066B4B1 File Offset: 0x006696B1
	[CompilerGenerated]
	private static bool MLJANIMOCLC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "LastNewsButton";
	}

	// Token: 0x060126E4 RID: 75492 RVA: 0x0066B4C4 File Offset: 0x006696C4
	private IEnumerator PLFEGHCALDM(CSteamID GDOHPDHLPBC)
	{
		yield return true;
		yield break;
	}

	// Token: 0x060126E5 RID: 75493 RVA: 0x0066B4D8 File Offset: 0x006696D8
	private static bool IFADPNCKPDG(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.IFAJDLKJIDL() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.InProgress;
	}

	// Token: 0x060126E6 RID: 75494 RVA: 0x0066B4F4 File Offset: 0x006696F4
	public void OnResolutionChangeButton(int DPNHODJHGJL)
	{
		if (DPNHODJHGJL > 0)
		{
			this.KNOAFBDEBDK++;
		}
		else
		{
			this.KNOAFBDEBDK--;
		}
		if (this.KNOAFBDEBDK < 0)
		{
			this.KNOAFBDEBDK = 0;
		}
		if (this.KNOAFBDEBDK > this.BNEGFAHKIAA.Count - 1)
		{
			this.KNOAFBDEBDK = this.BNEGFAHKIAA.Count - 1;
		}
		Transform transform = GameObject.Find("SettingsCanvas").transform;
		transform.FindDeepChild("ScreenResolutionPanel").Find("Value").GetComponent<Text>().text = (int)this.BNEGFAHKIAA[this.KNOAFBDEBDK].x + " x " + (int)this.BNEGFAHKIAA[this.KNOAFBDEBDK].y;
	}

	// Token: 0x060126E7 RID: 75495 RVA: 0x0066B5DE File Offset: 0x006697DE
	public void SetPlayerDistance(float PNNFAOFBLHK)
	{
		this.playerDistance = PNNFAOFBLHK;
	}

	// Token: 0x060126E8 RID: 75496 RVA: 0x0066B5E7 File Offset: 0x006697E7
	public void OnCameraMovementsSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.cameramovements", DPNHODJHGJL, null);
	}

	// Token: 0x060126E9 RID: 75497 RVA: 0x0066B5FA File Offset: 0x006697FA
	public void OnItemsStoreButton()
	{
		Singleton<GameManager>.Instance.OpenURL("https://store.steampowered.com/itemstore/513510/", true);
	}

	// Token: 0x060126EA RID: 75498 RVA: 0x0066B60C File Offset: 0x0066980C
	[CompilerGenerated]
	private static bool MGLAMCMGJOB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ItemsStoreButton";
	}

	// Token: 0x060126EB RID: 75499 RVA: 0x0066B620 File Offset: 0x00669820
	public void OpenSocial(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.OpenURL("https://discord.gg/intralism", false);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.OpenURL("https://twitch.tv/intralism", false);
		}
		if (DFBMGAGGOHI == 2)
		{
			Singleton<GameManager>.Instance.OpenURL("https://vk.com/khb.soft", false);
		}
		if (DFBMGAGGOHI == 3)
		{
			Singleton<GameManager>.Instance.OpenURL("https://reddit.com/r/Intralism", false);
		}
		if (DFBMGAGGOHI == 4)
		{
			Singleton<GameManager>.Instance.OpenURL("https://bugs.khb-soft.ru/set_project.php?project_id=1", false);
		}
	}

	// Token: 0x060126EC RID: 75500 RVA: 0x0066B6A0 File Offset: 0x006698A0
	private IEnumerator LCJDCFFEMLP()
	{
		Singleton<SaveSystem>.Instance.Flush();
		SteamAPI.Shutdown();
		yield return true;
		Process.GetCurrentProcess().Kill();
		yield break;
	}

	// Token: 0x060126ED RID: 75501 RVA: 0x0066B6B4 File Offset: 0x006698B4
	[CompilerGenerated]
	private static bool BJHHLJBNOBG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ChallengesButton";
	}

	// Token: 0x060126EE RID: 75502 RVA: 0x0066B6C6 File Offset: 0x006698C6
	public void FPMBDJOGPNC(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("TestTicket", DPNHODJHGJL, null);
	}

	// Token: 0x060126EF RID: 75503 RVA: 0x0066B6D9 File Offset: 0x006698D9
	public void OnExitButton()
	{
		base.StartCoroutine(this.LCJDCFFEMLP());
	}

	// Token: 0x060126F0 RID: 75504 RVA: 0x0066B6E8 File Offset: 0x006698E8
	private IEnumerator OCIPHAEEGGO()
	{
		if (GameManager.IsOffline)
		{
			this.newsTile.GetComponent<NewsTile>().Init(LocalizationService.Instance.GetLocalizatedText("#news"), string.Empty, null, string.Empty);
			yield break;
		}
		WWW www = new WWW(Helpers.newsURL);
		yield return www;
		AppNews.NewsRootObject newsRootObject = null;
		if (string.IsNullOrEmpty(www.error))
		{
			string newValue = "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/";
			string value = www.text.Replace("{STEAM_CLAN_IMAGE}", newValue);
			newsRootObject = JsonConvert.DeserializeObject<AppNews.NewsRootObject>(value);
			int nimemphgjco = this.NIMEMPHGJCO;
			Regex regex = new Regex("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", RegexOptions.IgnoreCase);
			MatchCollection matchCollection = regex.Matches(newsRootObject.appnews.newsitems[nimemphgjco].contents);
			string text = string.Empty;
			if (matchCollection.Count > 0)
			{
				int i = 0;
				text = matchCollection[i].ToString();
				yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(text, text.ToString(), false));
			}
			if (this.newsTile.gameObject.activeInHierarchy)
			{
				yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newsTile.GetComponent<NewsTile>().splashImage.gameObject, true, null, true, 0.5f, true));
			}
			this.newsTile.GetComponent<NewsTile>().newsIDSlider.value = (float)this.NIMEMPHGJCO;
			yield return LocalizationService.Instance.inited;
			string text2 = newsRootObject.appnews.newsitems[nimemphgjco].contents;
			text2 = text2.Replace("\r\n", "\n");
			text2 = Regex.Replace(text2, "\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", string.Empty);
			text2 = Regex.Replace(text2, "(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", string.Empty);
			text2 = Regex.Replace(text2, "(\\[ *\\/ *url *])", string.Empty);
			text2 = Regex.Replace(text2, "(\\[ *b *\\])", "<b>");
			text2 = Regex.Replace(text2, "(\\[ */ *b *\\])", "</b>");
			text2 = Regex.Replace(text2, "(\\[ *h1 *\\])", "<size=24>");
			text2 = Regex.Replace(text2, "(\\[ */ *h1 *\\])", "</size>");
			text2 = Regex.Replace(text2, "(\\[ *i *\\])", "<i>");
			text2 = Regex.Replace(text2, "(\\[ */ *i *\\])", "</i>");
			text2 = Regex.Replace(text2, "(\\[ *quote *\\])", string.Empty);
			text2 = Regex.Replace(text2, "(\\[ */ *quote *\\])", string.Empty);
			this.newsTile.GetComponent<NewsTile>().Init(newsRootObject.appnews.newsitems[nimemphgjco].title, text2, (Sprite)ResourcesManager.GetLoadedResource(text), newsRootObject.appnews.newsitems[nimemphgjco].url);
			this.NIMEMPHGJCO++;
			if (this.NIMEMPHGJCO >= this.EKGCLHGOFMG)
			{
				this.NIMEMPHGJCO = 0;
			}
		}
		if (this.newsTile.gameObject.activeInHierarchy)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newsTile.GetComponent<NewsTile>().splashImage.gameObject, false, null, true, 0.5f, true));
		}
		else
		{
			this.newsTile.GetComponent<NewsTile>().splashImage.GetComponent<CanvasGroup>().alpha = 0f;
			this.newsTile.GetComponent<NewsTile>().splashImage.gameObject.SetActive(false);
		}
		yield break;
	}

	// Token: 0x060126F1 RID: 75505 RVA: 0x0066B703 File Offset: 0x00669903
	public void OnSelectorMapsCountSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetInt("settings.selectormapsperpage", (int)DPNHODJHGJL, null);
	}

	// Token: 0x060126F2 RID: 75506 RVA: 0x0066B717 File Offset: 0x00669917
	public void OnEnableRankedNotificationsToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablerankingnotifications", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablerankingnotifications", 0, null);
		}
	}

	// Token: 0x060126F3 RID: 75507 RVA: 0x0066B746 File Offset: 0x00669946
	private static bool OOJLOCNKHOF(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RecieveChatActionMessage";
	}

	// Token: 0x060126F4 RID: 75508 RVA: 0x0066B758 File Offset: 0x00669958
	public IEnumerator RateGameQuestion()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#rategameinfo", "#rate!", new UnityAction(this.WriteReview), "#no", null));
		Helpers.SetStat("player.gamecompleted", 1);
		yield break;
	}

	// Token: 0x060126F5 RID: 75509 RVA: 0x0066B773 File Offset: 0x00669973
	public void LoadBG(CSteamID GDOHPDHLPBC)
	{
		base.StartCoroutine(this.BPFCIABIFMM(GDOHPDHLPBC));
	}

	// Token: 0x060126F6 RID: 75510 RVA: 0x0066B783 File Offset: 0x00669983
	[CompilerGenerated]
	private static bool KJJHGMHJAJP(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InfoButton";
	}

	// Token: 0x060126F7 RID: 75511 RVA: 0x0066B795 File Offset: 0x00669995
	[CompilerGenerated]
	private static bool CKIGFOCPHJN(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RanksButton";
	}

	// Token: 0x060126F8 RID: 75512 RVA: 0x0066B7A7 File Offset: 0x006699A7
	private static bool JOHKPKOKLLH(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Green_R";
	}

	// Token: 0x060126F9 RID: 75513 RVA: 0x0066B7B9 File Offset: 0x006699B9
	public void PLCNEOAGEHA()
	{
		Singleton<GameManager>.Instance.KPCCPKIPFGC("maps.", false);
	}

	// Token: 0x060126FA RID: 75514 RVA: 0x0066B7CC File Offset: 0x006699CC
	private void BPBGOKGNDJB()
	{
		List<GameObject> list = this.menuTiles;
		if (MenuScene.KCAPKHIJOHL == null)
		{
			MenuScene.KCAPKHIJOHL = new Predicate<GameObject>(MenuScene.JOHKPKOKLLH);
		}
		if (list.Find(MenuScene.KCAPKHIJOHL))
		{
			List<GameObject> list2 = this.menuTiles;
			if (MenuScene.DIEBHABBNGF == null)
			{
				MenuScene.DIEBHABBNGF = new Predicate<GameObject>(MenuScene.KMFLLCDHOPB);
			}
			list2.Find(MenuScene.DIEBHABBNGF).GetComponent<Button>().interactable = GameManager.IMDOFCBINLC();
		}
		List<GameObject> list3 = this.menuTiles;
		if (MenuScene.FBNFNGBBKHH == null)
		{
			MenuScene.FBNFNGBBKHH = new Predicate<GameObject>(MenuScene.OBBLIPPPGPI);
		}
		if (list3.Find(MenuScene.FBNFNGBBKHH))
		{
			List<GameObject> list4 = this.menuTiles;
			if (MenuScene.NFNJKONOIJD == null)
			{
				MenuScene.NFNJKONOIJD = new Predicate<GameObject>(MenuScene.CKIGFOCPHJN);
			}
			list4.Find(MenuScene.NFNJKONOIJD).GetComponent<Button>().interactable = GameManager.IMDOFCBINLC();
		}
		List<GameObject> list5 = this.menuTiles;
		if (MenuScene.LBLKOBNMMNL == null)
		{
			MenuScene.LBLKOBNMMNL = new Predicate<GameObject>(MenuScene.BJHHLJBNOBG);
		}
		if (list5.Find(MenuScene.LBLKOBNMMNL))
		{
			List<GameObject> list6 = this.menuTiles;
			if (MenuScene.AKLIPIAOCIA == null)
			{
				MenuScene.AKLIPIAOCIA = new Predicate<GameObject>(MenuScene.BENAPOCGKLD);
			}
			list6.Find(MenuScene.AKLIPIAOCIA).GetComponent<Button>().interactable = !GameManager.IMDOFCBINLC();
		}
		List<GameObject> list7 = this.menuTiles;
		if (MenuScene.EINGHFEALEJ == null)
		{
			MenuScene.EINGHFEALEJ = new Predicate<GameObject>(MenuScene.DCAKGICPDKL);
		}
		if (list7.Find(MenuScene.EINGHFEALEJ))
		{
			List<GameObject> list8 = this.menuTiles;
			if (MenuScene.ONMBGDBHKBH == null)
			{
				MenuScene.ONMBGDBHKBH = new Predicate<GameObject>(MenuScene.CFEMMOPIPHE);
			}
			list8.Find(MenuScene.ONMBGDBHKBH).GetComponent<Button>().interactable = !GameManager.IELIHANIEAC();
		}
		List<GameObject> list9 = this.menuTiles;
		if (MenuScene.NPFIKAFPOOO == null)
		{
			MenuScene.NPFIKAFPOOO = new Predicate<GameObject>(MenuScene.MLJANIMOCLC);
		}
		if (list9.Find(MenuScene.NPFIKAFPOOO))
		{
			List<GameObject> list10 = this.menuTiles;
			if (MenuScene.AANIPNEBEAL == null)
			{
				MenuScene.AANIPNEBEAL = new Predicate<GameObject>(MenuScene.DLKJHBAFDFM);
			}
			list10.Find(MenuScene.AANIPNEBEAL).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list11 = this.menuTiles;
		if (MenuScene.NHFDPIFJIKB == null)
		{
			MenuScene.NHFDPIFJIKB = new Predicate<GameObject>(MenuScene.IAPBHJJONIJ);
		}
		if (list11.Find(MenuScene.NHFDPIFJIKB))
		{
			List<GameObject> list12 = this.menuTiles;
			if (MenuScene.OHJMJNOAGMD == null)
			{
				MenuScene.OHJMJNOAGMD = new Predicate<GameObject>(MenuScene.JILHPDHFHAG);
			}
			list12.Find(MenuScene.OHJMJNOAGMD).GetComponent<Button>().interactable = GameManager.IMDOFCBINLC();
		}
		List<GameObject> list13 = this.menuTiles;
		if (MenuScene.LIDCPIMJKNB == null)
		{
			MenuScene.LIDCPIMJKNB = new Predicate<GameObject>(MenuScene.OOJLOCNKHOF);
		}
		if (list13.Find(MenuScene.LIDCPIMJKNB))
		{
			List<GameObject> list14 = this.menuTiles;
			if (MenuScene.OLKKCLAKBDJ == null)
			{
				MenuScene.OLKKCLAKBDJ = new Predicate<GameObject>(MenuScene.MGLAMCMGJOB);
			}
			list14.Find(MenuScene.OLKKCLAKBDJ).GetComponent<Button>().interactable = GameManager.PEJIIBNCKEI();
		}
	}

	// Token: 0x060126FB RID: 75515 RVA: 0x0066B60C File Offset: 0x0066980C
	[CompilerGenerated]
	private static bool FPCPFNLIBIG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ItemsStoreButton";
	}

	// Token: 0x060126FC RID: 75516 RVA: 0x0066B783 File Offset: 0x00669983
	[CompilerGenerated]
	private static bool HMPHCJBHJGG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InfoButton";
	}

	// Token: 0x060126FD RID: 75517 RVA: 0x0066BACD File Offset: 0x00669CCD
	public void AddTipButton()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("?page=addtip"), true);
	}

	// Token: 0x060126FE RID: 75518 RVA: 0x0066BAE9 File Offset: 0x00669CE9
	private static bool IAPBHJJONIJ(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "Left";
	}

	// Token: 0x060126FF RID: 75519 RVA: 0x0066BAFC File Offset: 0x00669CFC
	[CompilerGenerated]
	private static bool IHHPJEAHLBO(Vector2 IACGDFHKCAE)
	{
		return IACGDFHKCAE.x == (float)Screen.currentResolution.width && IACGDFHKCAE.y == (float)Screen.currentResolution.height;
	}

	// Token: 0x06012700 RID: 75520 RVA: 0x0066BB3D File Offset: 0x00669D3D
	private void CJNIKGCOOAD()
	{
		this.mainMenuCanvas.SetActive(false);
		this.SetPlayerBlur(true);
		this.AIBBBPLLCFJ(1360f);
	}

	// Token: 0x06012701 RID: 75521 RVA: 0x0066BB5D File Offset: 0x00669D5D
	public void InitProfileCanvas()
	{
		this.mainMenuCanvas.SetActive(false);
		this.SetPlayerBlur(true);
		this.SetPlayerDistance(7f);
		base.StartCoroutine(Singleton<InventorySelector>.Instance.DisplayInventory(new UnityAction(this.FLICOEHOIPL)));
	}

	// Token: 0x06012702 RID: 75522 RVA: 0x0066BB9A File Offset: 0x00669D9A
	[CompilerGenerated]
	private static bool FNJAOABNDGP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward;
	}

	// Token: 0x06012703 RID: 75523 RVA: 0x0066BBB4 File Offset: 0x00669DB4
	public void FGINPPFAMIP(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("menu.selectedlevelid", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB(". Prefab must have a PhotonView component.", 1, null);
		}
	}

	// Token: 0x06012704 RID: 75524 RVA: 0x0066BBE3 File Offset: 0x00669DE3
	[CompilerGenerated]
	private static bool EBINHDABFNF(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InventoryButton";
	}

	// Token: 0x06012705 RID: 75525 RVA: 0x0066BBF5 File Offset: 0x00669DF5
	[CompilerGenerated]
	private void GEMMLOGEJON()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(false);
		this.SetPlayerDistance(14f);
	}

	// Token: 0x06012706 RID: 75526 RVA: 0x0066BC18 File Offset: 0x00669E18
	public IEnumerator LoadPlayerInfo()
	{
		CSteamID steamID = SteamUser.GetSteamID();
		if (Helpers.GetStat("player.xp") < 0)
		{
			Helpers.SetStat("player.xp", 0);
		}
		this.pInfo.levelText.text = string.Empty + Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"));
		this.pInfo.xpSlider.value = Helpers.GetPlayerLevelProgress();
		string bgURL = Singleton<RanksSystem>.Instance.bgURL;
		if (!string.IsNullOrEmpty(bgURL))
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(bgURL, bgURL, false));
			this.pInfo.userBG.sprite = (Sprite)ResourcesManager.GetLoadedResource(bgURL);
		}
		else
		{
			this.pInfo.userBG.GetComponent<LoadImageFromSkin>().enabled = true;
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
		int num = 0;
		if (loadedRank != null)
		{
			num = RanksSystem.GetLoadedRank(steamID).place;
			this.pInfo.rank.text = string.Empty + num;
		}
		else
		{
			this.pInfo.rank.text = "TBD";
		}
		this.pInfo.rankBG.color = RanksSystem.GetRankColor(num, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamID, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamID, false));
		this.pInfo.avatar.sprite = ResourcesManager.GetLoadedAvatar(steamID);
		this.LoadBG(steamID);
		this.pInfo.nickname.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamID, false).ToUpper();
		this.pInfo.nickname.GetComponent<BestFitOutline>().effectColor = RanksSystem.GetRankShadowColor(num);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamID));
		this.pInfo.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamID));
		yield break;
	}

	// Token: 0x06012707 RID: 75527 RVA: 0x0066BC33 File Offset: 0x00669E33
	public void IHCFAIPPFPJ()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(true);
		this.SetPlayerDistance(364f);
		base.StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(1, null, null, new UnityAction(this.FPEIMLDCGEG)));
	}

	// Token: 0x06012708 RID: 75528 RVA: 0x0066BC74 File Offset: 0x00669E74
	public void HCNNCEPLHBE()
	{
		if (GameManager.IELIHANIEAC())
		{
			TipsListElement tipsListElement = this.tip;
			RanksSystem.PlayerTip playerTip = new RanksSystem.PlayerTip();
			playerTip.CDDGMCLMPEG(LocalizationService.Instance.HOPMEAJKPHL("_BlurParams"));
			playerTip.id = 0UL;
			playerTip.EHPNOPLMJCC(SteamUser.GetSteamID().m_SteamID);
			tipsListElement.EFEONCCCKNP(playerTip);
			return;
		}
		if (RanksSystem.EAGFIMBCDCP().Count > 0)
		{
			this.tip.EKOAKKNGGGI(RanksSystem.EAGFIMBCDCP()[UnityEngine.Random.Range(0, RanksSystem.JJEHNLHAAGC().Count)]);
		}
	}

	// Token: 0x06012709 RID: 75529 RVA: 0x0066BD03 File Offset: 0x00669F03
	public void OnMultiplayerButton()
	{
		SceneManager.LoadScene("NetworkScene");
	}

	// Token: 0x0601270A RID: 75530 RVA: 0x0066BD0F File Offset: 0x00669F0F
	[CompilerGenerated]
	private static bool KMFLLCDHOPB(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "MultiplayerButton";
	}

	// Token: 0x0601270B RID: 75531 RVA: 0x0066BD24 File Offset: 0x00669F24
	public void OnRelaxToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.HasKey("menu.relaxinfo", null))
			{
				Singleton<SaveSystem>.Instance.SetInt("menu.relaxinfo", 1, null);
			}
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 1, null);
		}
	}

	// Token: 0x0601270C RID: 75532 RVA: 0x0066BD84 File Offset: 0x00669F84
	public void OnGameMessagesDurationSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.gamemessagesduration", DPNHODJHGJL, null);
	}

	// Token: 0x0601270D RID: 75533 RVA: 0x0066BD98 File Offset: 0x00669F98
	public IEnumerator ELBFMNFCCAC()
	{
		steamID = SteamUser.GetSteamID();
		if (Helpers.GetStat("player.xp") < 0)
		{
			Helpers.SetStat("player.xp", 0);
		}
		this.pInfo.levelText.text = string.Empty + Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"));
		this.pInfo.xpSlider.value = Helpers.GetPlayerLevelProgress();
		bgURL = Singleton<RanksSystem>.Instance.bgURL;
		if (!string.IsNullOrEmpty(bgURL))
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(bgURL, bgURL, false));
			this.pInfo.userBG.sprite = (Sprite)ResourcesManager.GetLoadedResource(bgURL);
		}
		else
		{
			this.pInfo.userBG.GetComponent<LoadImageFromSkin>().enabled = true;
		}
		loadedRank = RanksSystem.GetLoadedRank(steamID);
		num = 0;
		if (loadedRank != null)
		{
			num = RanksSystem.GetLoadedRank(steamID).place;
			this.pInfo.rank.text = string.Empty + num;
		}
		else
		{
			this.pInfo.rank.text = "TBD";
		}
		this.pInfo.rankBG.color = RanksSystem.GetRankColor(num, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamID, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamID, false));
		this.pInfo.avatar.sprite = ResourcesManager.GetLoadedAvatar(steamID);
		this.LoadBG(steamID);
		this.pInfo.nickname.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamID, false).ToUpper();
		this.pInfo.nickname.GetComponent<BestFitOutline>().effectColor = RanksSystem.GetRankShadowColor(num);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamID));
		this.pInfo.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamID));
		yield break;
	}

	// Token: 0x0601270E RID: 75534 RVA: 0x0066BDB3 File Offset: 0x00669FB3
	private static bool FLPLKENDBBP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.OCNOEDGAPNL() < Challenge.CurrentStatus.ObtainedReward;
	}

	// Token: 0x0601270F RID: 75535 RVA: 0x0066BDCD File Offset: 0x00669FCD
	private void HPBCCKJKGBL()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(true);
		this.SetPlayerDistance(1838f);
	}

	// Token: 0x06012711 RID: 75537 RVA: 0x0066BE19 File Offset: 0x0066A019
	public void OnEnableRankingToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enableranking", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enableranking", 0, null);
		}
	}

	// Token: 0x06012712 RID: 75538 RVA: 0x0066BE48 File Offset: 0x0066A048
	public void DMGHHDELIIA(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_MatrixSpeed", null))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("UsernameText"), ").png", null, true, true, 195f);
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA("challenges/", 1, null);
			}
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("Map already submited. Update?", 0, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_TimeX", 1, null);
		}
	}

	// Token: 0x06012713 RID: 75539 RVA: 0x0066BECE File Offset: 0x0066A0CE
	public void OnCrosshairOpacitySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.crosshairopacity", DPNHODJHGJL * 0.01f, null);
	}

	// Token: 0x06012714 RID: 75540 RVA: 0x0066BEE7 File Offset: 0x0066A0E7
	private static bool HFMDFOPHGHA(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.OCNOEDGAPNL() != Challenge.CurrentStatus.NotStarted || Helpers.isChallengeUnlocked(IACGDFHKCAE.FOFJIPLGEKL());
	}

	// Token: 0x06012715 RID: 75541 RVA: 0x0066BF04 File Offset: 0x0066A104
	private IEnumerator DCEMOLIGKGC()
	{
		string text = "original.tutorial";
		this.SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0, null);
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		SceneManager.LoadScene("GameScene");
		yield break;
	}

	// Token: 0x06012716 RID: 75542 RVA: 0x0066BF20 File Offset: 0x0066A120
	public void SetPlayerBlur(bool BNKMBAECHGB)
	{
		GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
		gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().enabled = BNKMBAECHGB;
	}

	// Token: 0x06012717 RID: 75543 RVA: 0x0066BF4E File Offset: 0x0066A14E
	private static bool IICLCPOHBEL(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.DGAKBIEHAJC() > Challenge.CurrentStatus.InProgress && IACGDFHKCAE.JMGIKADHIGM() < (Challenge.CurrentStatus)4;
	}

	// Token: 0x06012718 RID: 75544 RVA: 0x0066BF68 File Offset: 0x0066A168
	public void ResetAllSettings()
	{
		Singleton<SaveSystem>.Instance.DeleteKey("settings.shaders", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.shaders.bloomintencity", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.fps", null);
		Singleton<SaveSystem>.Instance.DeleteKey("menu.enableselectormusic", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.showHP", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.menu", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.game", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.editor", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.volume.sfx", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enablehitsoundsinrelax", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.disablestoryboard", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enableselectormusic", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.hitvariation", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.cameramovements", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.crosshairopacity", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.gamemessagesduration", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.arcsdestroydelay", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.arcsnohitsoundtimedelay", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.arcshitsoundtimedelay", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.selectormapsperpage", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enableranking", null);
		Singleton<SaveSystem>.Instance.DeleteKey("settings.enablerankingnotifications", null);
		hardInput.ResetAllBindings();
		VolumeSettings component = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>();
		component.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		component.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		component.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		component.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		Transform transform = GameObject.Find("SettingsCanvas").transform;
		QualitySettings.SetQualityLevel(1);
		this.InitSettingsCanvas();
		base.GetComponent<ShadersSettings>().SetShadersEnabled(transform.FindDeepChild("ShadersToggle").GetComponent<Toggle>().isOn);
		base.GetComponent<FPSSettings>().SetFPSEnabled(transform.FindDeepChild("FPSToggle").GetComponent<Toggle>().isOn);
	}

	// Token: 0x06012719 RID: 75545 RVA: 0x0066B5DE File Offset: 0x006697DE
	public void AIBBBPLLCFJ(float PNNFAOFBLHK)
	{
		this.playerDistance = PNNFAOFBLHK;
	}

	// Token: 0x0601271A RID: 75546 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnStartButton()
	{
	}

	// Token: 0x0601271B RID: 75547 RVA: 0x0066C1B4 File Offset: 0x0066A3B4
	private IEnumerator NKPMFEHMGNP()
	{
		GameObject gameObject = this.tipsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (RanksSystem.PlayerTip playerTip in RanksSystem.GetTipsList())
		{
			CSteamID gdohpdhlpbc = (CSteamID)playerTip.steamID;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(gdohpdhlpbc, false));
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.tipsListElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<TipsListElement>().Init(playerTip);
		}
		yield break;
	}

	// Token: 0x0601271C RID: 75548 RVA: 0x0066B6B4 File Offset: 0x006698B4
	[CompilerGenerated]
	private static bool BENAPOCGKLD(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "ChallengesButton";
	}

	// Token: 0x0601271D RID: 75549 RVA: 0x0066C1CF File Offset: 0x0066A3CF
	public void EADLDFICCDH()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(false);
		this.HDAOEDNALLJ(1949f);
		base.StartCoroutine(Singleton<InventorySelector>.Instance.INLAAKKJLGH(new UnityAction(this.HPBCCKJKGBL)));
	}

	// Token: 0x0601271E RID: 75550 RVA: 0x0066C20C File Offset: 0x0066A40C
	public void ObtainAchievement(int JMMILEFMACB)
	{
		Helpers.ObtainAchievement(JMMILEFMACB);
	}

	// Token: 0x0601271F RID: 75551 RVA: 0x0066C214 File Offset: 0x0066A414
	public void JAAOGDPKJBP(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.GAACBNCIFLG("AvatarImage", false, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("steamid", true, null);
		}
	}

	// Token: 0x06012720 RID: 75552 RVA: 0x0066C243 File Offset: 0x0066A443
	public void OnArcsHitsoundTimeDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcshitsoundtimedelay", DPNHODJHGJL, null);
	}

	// Token: 0x06012721 RID: 75553 RVA: 0x0066C256 File Offset: 0x0066A456
	[CompilerGenerated]
	private static bool AFCPIDKJDGA(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus == Challenge.CurrentStatus.NotStarted && Helpers.isChallengeUnlocked(IACGDFHKCAE.unlockCondition);
	}

	// Token: 0x06012722 RID: 75554 RVA: 0x0066C271 File Offset: 0x0066A471
	private void GOGLEOJCHHG()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(false);
		this.AIBBBPLLCFJ(820f);
	}

	// Token: 0x06012723 RID: 75555 RVA: 0x0066C294 File Offset: 0x0066A494
	private IEnumerator BEHNMAIOPKJ(CSteamID GDOHPDHLPBC)
	{
		yield return true;
		yield break;
	}

	// Token: 0x06012724 RID: 75556 RVA: 0x0066C2A8 File Offset: 0x0066A4A8
	public void ApplyVideoSettings()
	{
		Transform transform = GameObject.Find("SettingsCanvas").transform;
		Screen.SetResolution((int)this.BNEGFAHKIAA[this.KNOAFBDEBDK].x, (int)this.BNEGFAHKIAA[this.KNOAFBDEBDK].y, transform.FindDeepChild("FullscreenToggle").GetComponent<Toggle>().isOn);
		QualitySettings.SetQualityLevel((int)transform.FindDeepChild("GraphicsQualitySlider").GetComponent<Slider>().value);
		base.GetComponent<ShadersSettings>().SetShadersEnabled(transform.FindDeepChild("ShadersToggle").GetComponent<Toggle>().isOn);
		base.GetComponent<FPSSettings>().SetFPSEnabled(transform.FindDeepChild("FPSToggle").GetComponent<Toggle>().isOn);
	}

	// Token: 0x06012725 RID: 75557 RVA: 0x0066BD0F File Offset: 0x00669F0F
	[CompilerGenerated]
	private static bool DMDGONAJGND(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "MultiplayerButton";
	}

	// Token: 0x06012726 RID: 75558 RVA: 0x0066C370 File Offset: 0x0066A570
	private void MNCMLOEAPAH()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerDistance(561f);
		if (base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("View"))
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("SetTrailZoomSpeed").GetComponent<Button>().Select();
		}
		this.SetPlayerBlur(false);
	}

	// Token: 0x06012727 RID: 75559 RVA: 0x0066C3E3 File Offset: 0x0066A5E3
	public void SetGameMode(string DLGIPFOEDCF)
	{
		Singleton<SaveSystem>.Instance.SetString("menu.selectedmode", DLGIPFOEDCF, null);
	}

	// Token: 0x06012728 RID: 75560 RVA: 0x0066C3F6 File Offset: 0x0066A5F6
	public void OnSelectorMusicToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.enableselectormusic", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.DeleteKey("menu.enableselectormusic", null);
		}
	}

	// Token: 0x06012729 RID: 75561 RVA: 0x0066C424 File Offset: 0x0066A624
	public void CKKPICBGKJI(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("_TimeX", 0, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_Radius", 1, null);
		}
	}

	// Token: 0x0601272A RID: 75562 RVA: 0x0066C453 File Offset: 0x0066A653
	private static bool IBGLIBJIJJL(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "CameraFilterPack/Drawing_Paper3";
	}

	// Token: 0x0601272B RID: 75563 RVA: 0x0066C468 File Offset: 0x0066A668
	private void IFPFEIBFKPO()
	{
		List<GameObject> list = this.menuTiles;
		if (MenuScene.KCAPKHIJOHL == null)
		{
			MenuScene.KCAPKHIJOHL = new Predicate<GameObject>(MenuScene.DMDGONAJGND);
		}
		if (list.Find(MenuScene.KCAPKHIJOHL))
		{
			List<GameObject> list2 = this.menuTiles;
			if (MenuScene.DIEBHABBNGF == null)
			{
				MenuScene.DIEBHABBNGF = new Predicate<GameObject>(MenuScene.KMFLLCDHOPB);
			}
			list2.Find(MenuScene.DIEBHABBNGF).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list3 = this.menuTiles;
		if (MenuScene.FBNFNGBBKHH == null)
		{
			MenuScene.FBNFNGBBKHH = new Predicate<GameObject>(MenuScene.OBBLIPPPGPI);
		}
		if (list3.Find(MenuScene.FBNFNGBBKHH))
		{
			List<GameObject> list4 = this.menuTiles;
			if (MenuScene.NFNJKONOIJD == null)
			{
				MenuScene.NFNJKONOIJD = new Predicate<GameObject>(MenuScene.CKIGFOCPHJN);
			}
			list4.Find(MenuScene.NFNJKONOIJD).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list5 = this.menuTiles;
		if (MenuScene.LBLKOBNMMNL == null)
		{
			MenuScene.LBLKOBNMMNL = new Predicate<GameObject>(MenuScene.BJHHLJBNOBG);
		}
		if (list5.Find(MenuScene.LBLKOBNMMNL))
		{
			List<GameObject> list6 = this.menuTiles;
			if (MenuScene.AKLIPIAOCIA == null)
			{
				MenuScene.AKLIPIAOCIA = new Predicate<GameObject>(MenuScene.BENAPOCGKLD);
			}
			list6.Find(MenuScene.AKLIPIAOCIA).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list7 = this.menuTiles;
		if (MenuScene.EINGHFEALEJ == null)
		{
			MenuScene.EINGHFEALEJ = new Predicate<GameObject>(MenuScene.EBINHDABFNF);
		}
		if (list7.Find(MenuScene.EINGHFEALEJ))
		{
			List<GameObject> list8 = this.menuTiles;
			if (MenuScene.ONMBGDBHKBH == null)
			{
				MenuScene.ONMBGDBHKBH = new Predicate<GameObject>(MenuScene.HNBBKDMOGLC);
			}
			list8.Find(MenuScene.ONMBGDBHKBH).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list9 = this.menuTiles;
		if (MenuScene.NPFIKAFPOOO == null)
		{
			MenuScene.NPFIKAFPOOO = new Predicate<GameObject>(MenuScene.MLJANIMOCLC);
		}
		if (list9.Find(MenuScene.NPFIKAFPOOO))
		{
			List<GameObject> list10 = this.menuTiles;
			if (MenuScene.AANIPNEBEAL == null)
			{
				MenuScene.AANIPNEBEAL = new Predicate<GameObject>(MenuScene.DLKJHBAFDFM);
			}
			list10.Find(MenuScene.AANIPNEBEAL).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list11 = this.menuTiles;
		if (MenuScene.NHFDPIFJIKB == null)
		{
			MenuScene.NHFDPIFJIKB = new Predicate<GameObject>(MenuScene.HMPHCJBHJGG);
		}
		if (list11.Find(MenuScene.NHFDPIFJIKB))
		{
			List<GameObject> list12 = this.menuTiles;
			if (MenuScene.OHJMJNOAGMD == null)
			{
				MenuScene.OHJMJNOAGMD = new Predicate<GameObject>(MenuScene.KJJHGMHJAJP);
			}
			list12.Find(MenuScene.OHJMJNOAGMD).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list13 = this.menuTiles;
		if (MenuScene.LIDCPIMJKNB == null)
		{
			MenuScene.LIDCPIMJKNB = new Predicate<GameObject>(MenuScene.FPCPFNLIBIG);
		}
		if (list13.Find(MenuScene.LIDCPIMJKNB))
		{
			List<GameObject> list14 = this.menuTiles;
			if (MenuScene.OLKKCLAKBDJ == null)
			{
				MenuScene.OLKKCLAKBDJ = new Predicate<GameObject>(MenuScene.MGLAMCMGJOB);
			}
			list14.Find(MenuScene.OLKKCLAKBDJ).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
	}

	// Token: 0x0601272C RID: 75564 RVA: 0x0066C76C File Offset: 0x0066A96C
	public IEnumerator CGJLJNMOMLA()
	{
		steamID = SteamUser.GetSteamID();
		if (Helpers.GetStat("player.xp") < 0)
		{
			Helpers.SetStat("player.xp", 0);
		}
		this.pInfo.levelText.text = string.Empty + Helpers.GetPlayerLevel(Helpers.GetStat("player.xp"));
		this.pInfo.xpSlider.value = Helpers.GetPlayerLevelProgress();
		bgURL = Singleton<RanksSystem>.Instance.bgURL;
		if (!string.IsNullOrEmpty(bgURL))
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(bgURL, bgURL, false));
			this.pInfo.userBG.sprite = (Sprite)ResourcesManager.GetLoadedResource(bgURL);
		}
		else
		{
			this.pInfo.userBG.GetComponent<LoadImageFromSkin>().enabled = true;
		}
		loadedRank = RanksSystem.GetLoadedRank(steamID);
		num = 0;
		if (loadedRank != null)
		{
			num = RanksSystem.GetLoadedRank(steamID).place;
			this.pInfo.rank.text = string.Empty + num;
		}
		else
		{
			this.pInfo.rank.text = "TBD";
		}
		this.pInfo.rankBG.color = RanksSystem.GetRankColor(num, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(steamID, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(steamID, false));
		this.pInfo.avatar.sprite = ResourcesManager.GetLoadedAvatar(steamID);
		this.LoadBG(steamID);
		this.pInfo.nickname.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(steamID, false).ToUpper();
		this.pInfo.nickname.GetComponent<BestFitOutline>().effectColor = RanksSystem.GetRankShadowColor(num);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(steamID));
		this.pInfo.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(steamID));
		yield break;
	}

	// Token: 0x0601272D RID: 75565 RVA: 0x0066C787 File Offset: 0x0066A987
	public void OnLevelEditorButton()
	{
		SceneManager.LoadScene("MapEditorScene");
	}

	// Token: 0x0601272E RID: 75566 RVA: 0x0066B795 File Offset: 0x00669995
	[CompilerGenerated]
	private static bool OBBLIPPPGPI(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "RanksButton";
	}

	// Token: 0x0601272F RID: 75567 RVA: 0x0066C793 File Offset: 0x0066A993
	private static bool KNCKDLMHJNE(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "1177138211";
	}

	// Token: 0x06012730 RID: 75568 RVA: 0x0066C7A5 File Offset: 0x0066A9A5
	public void LJBDHLFBNFC()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(true);
		this.SetPlayerDistance(47f);
		base.StartCoroutine(Singleton<InventorySelector>.Instance.PNGLEBHHKJK(new UnityAction(this.FLICOEHOIPL)));
	}

	// Token: 0x06012731 RID: 75569 RVA: 0x0066C7E4 File Offset: 0x0066A9E4
	private IEnumerator BPFCIABIFMM(CSteamID GDOHPDHLPBC)
	{
		yield return true;
		yield break;
	}

	// Token: 0x06012732 RID: 75570 RVA: 0x0066BBE3 File Offset: 0x00669DE3
	[CompilerGenerated]
	private static bool HNBBKDMOGLC(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "InventoryButton";
	}

	// Token: 0x06012733 RID: 75571 RVA: 0x0066C7F8 File Offset: 0x0066A9F8
	public void OnEnableHitSoundsInNormalToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinnormal", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinnormal", 0, null);
		}
	}

	// Token: 0x06012734 RID: 75572 RVA: 0x0066C827 File Offset: 0x0066AA27
	public void NANHJALKKLH()
	{
		Singleton<GameManager>.Instance.OpenURL("#turnoninternet", false);
	}

	// Token: 0x06012735 RID: 75573 RVA: 0x0066C83C File Offset: 0x0066AA3C
	public void DDMILNCEHBH()
	{
		string text = string.Empty;
		if (Singleton<ChallengesManager>.Instance.challengesList.Count > 0)
		{
			IEnumerable<Challenge> challengesList = Singleton<ChallengesManager>.Instance.challengesList;
			if (MenuScene.CLCBJCKCBDD == null)
			{
				MenuScene.CLCBJCKCBDD = new Func<Challenge, bool>(MenuScene.FOBOODEJMAP);
			}
			int num = challengesList.Where(MenuScene.CLCBJCKCBDD).Count<Challenge>();
			if (num > 1)
			{
				string text2 = text;
				object[] array = new object[]
				{
					text2,
					".highscore"
				};
				array[1] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
				array[0] = "_ScreenResolution";
				array[1] = num;
				array[8] = Environment.NewLine;
				array[6] = Environment.NewLine;
				text = string.Concat(array);
				IEnumerable<Challenge> challengesList2 = Singleton<ChallengesManager>.Instance.challengesList;
				if (MenuScene.HCLEECLNOEA == null)
				{
					MenuScene.HCLEECLNOEA = new Func<Challenge, bool>(MenuScene.IICLCPOHBEL);
				}
				foreach (Challenge challenge in challengesList2.Where(MenuScene.HCLEECLNOEA))
				{
					text2 = text;
					object[] array2 = new object[0];
					array2[1] = text2;
					array2[0] = "CameraFilterPack/TV_Posterize";
					array2[7] = challenge.DPKBMGBGEPJ() * 1237f;
					array2[8] = "Trackpad";
					array2[8] = challenge.KJPHHLIPAMA();
					array2[1] = Environment.NewLine;
					array2[5] = Environment.NewLine;
					text = string.Concat(array2);
				}
			}
			IEnumerable<Challenge> challengesList3 = Singleton<ChallengesManager>.Instance.challengesList;
			if (MenuScene.ADLAKIHINOM == null)
			{
				MenuScene.ADLAKIHINOM = new Func<Challenge, bool>(MenuScene.OFPAHEMDOFF);
			}
			int num2 = challengesList3.Where(MenuScene.ADLAKIHINOM).Count<Challenge>();
			if (num2 > 1)
			{
				text += Environment.NewLine;
				string text2 = text;
				object[] array3 = new object[8];
				array3[1] = text2;
				array3[1] = "_TapHigh";
				array3[6] = LocalizationService.Instance.HOPMEAJKPHL(":");
				array3[5] = "maps.";
				array3[1] = num2;
				array3[1] = Environment.NewLine;
				text = string.Concat(array3);
			}
		}
		this.challengetText.text = text;
	}

	// Token: 0x06012736 RID: 75574 RVA: 0x0066B4B1 File Offset: 0x006696B1
	[CompilerGenerated]
	private static bool DLKJHBAFDFM(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "LastNewsButton";
	}

	// Token: 0x06012737 RID: 75575 RVA: 0x0066CA44 File Offset: 0x0066AC44
	private void MHJOOKDMIHD()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerDistance(7f);
		if (base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("SingleplayerButton"))
		{
			base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("SingleplayerButton").GetComponent<Button>().Select();
		}
		this.SetPlayerBlur(false);
	}

	// Token: 0x06012738 RID: 75576 RVA: 0x0066CAB7 File Offset: 0x0066ACB7
	private static bool DCAKGICPDKL(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Offsets";
	}

	// Token: 0x06012739 RID: 75577 RVA: 0x0066CACC File Offset: 0x0066ACCC
	public void UpdateChallengesTile()
	{
		string text = string.Empty;
		if (Singleton<ChallengesManager>.Instance.challengesList.Count > 0)
		{
			IEnumerable<Challenge> challengesList = Singleton<ChallengesManager>.Instance.challengesList;
			if (MenuScene.CLCBJCKCBDD == null)
			{
				MenuScene.CLCBJCKCBDD = new Func<Challenge, bool>(MenuScene.FOBOODEJMAP);
			}
			int num = challengesList.Where(MenuScene.CLCBJCKCBDD).Count<Challenge>();
			if (num > 0)
			{
				string text2 = text;
				text = string.Concat(new object[]
				{
					text2,
					"<b>",
					LocalizationService.Instance.GetLocalizatedText("#activechallenges"),
					":</b> ",
					num,
					Environment.NewLine,
					Environment.NewLine
				});
				IEnumerable<Challenge> challengesList2 = Singleton<ChallengesManager>.Instance.challengesList;
				if (MenuScene.HCLEECLNOEA == null)
				{
					MenuScene.HCLEECLNOEA = new Func<Challenge, bool>(MenuScene.FNJAOABNDGP);
				}
				foreach (Challenge challenge in challengesList2.Where(MenuScene.HCLEECLNOEA))
				{
					text2 = text;
					text = string.Concat(new object[]
					{
						text2,
						"<b>[",
						challenge.GetProgress() * 100f,
						"%]</b> ",
						challenge.info,
						Environment.NewLine,
						Environment.NewLine
					});
				}
			}
			IEnumerable<Challenge> challengesList3 = Singleton<ChallengesManager>.Instance.challengesList;
			if (MenuScene.ADLAKIHINOM == null)
			{
				MenuScene.ADLAKIHINOM = new Func<Challenge, bool>(MenuScene.AFCPIDKJDGA);
			}
			int num2 = challengesList3.Where(MenuScene.ADLAKIHINOM).Count<Challenge>();
			if (num2 > 0)
			{
				text += Environment.NewLine;
				string text2 = text;
				text = string.Concat(new object[]
				{
					text2,
					"<b>",
					LocalizationService.Instance.GetLocalizatedText("#availablechallenges"),
					":</b> ",
					num2,
					Environment.NewLine
				});
			}
		}
		this.challengetText.text = text;
	}

	// Token: 0x0601273A RID: 75578 RVA: 0x0066CCD4 File Offset: 0x0066AED4
	public void MBEPCNGHJHE()
	{
		if (GameManager.IsOffline)
		{
			TipsListElement tipsListElement = this.tip;
			RanksSystem.PlayerTip playerTip = new RanksSystem.PlayerTip();
			playerTip.CDDGMCLMPEG(LocalizationService.Instance.GetLocalizatedText("GhostFade2"));
			playerTip.LJMEJHIHPGI(1UL);
			playerTip.NFAAADLGEGI(SteamUser.GetSteamID().m_SteamID);
			tipsListElement.NFKDBPGHHIJ(playerTip);
			return;
		}
		if (RanksSystem.JJEHNLHAAGC().Count > 0)
		{
			this.tip.EPDCHKECMBL(RanksSystem.JJEHNLHAAGC()[UnityEngine.Random.Range(0, RanksSystem.HACOOAAIPEN().Count)]);
		}
	}

	// Token: 0x0601273B RID: 75579 RVA: 0x0066CD63 File Offset: 0x0066AF63
	private static bool PNOFBIFICND(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "<b>Speed</b>:";
	}

	// Token: 0x0601273C RID: 75580 RVA: 0x0066CD75 File Offset: 0x0066AF75
	public void PlayTutorial()
	{
		Singleton<SaveSystem>.Instance.SetBool("player.playedtutorial", true, null);
		base.StartCoroutine(this.DCEMOLIGKGC());
	}

	// Token: 0x0601273D RID: 75581 RVA: 0x0066CD95 File Offset: 0x0066AF95
	public void MLBFIPDJCII()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(false);
		this.SetPlayerDistance(694f);
		base.StartCoroutine(Singleton<ChallengesManagerUI>.Instance.BBBNFOHPNOE(new UnityAction(this.GEMMLOGEJON)));
	}

	// Token: 0x0601273E RID: 75582 RVA: 0x0066CDD4 File Offset: 0x0066AFD4
	public void OnHardcoreToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			if (!Singleton<SaveSystem>.Instance.HasKey("menu.hardcoreinfo", null))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("hardcoreinfo"), "OK", null, true, false, 0f);
				Singleton<SaveSystem>.Instance.SetInt("menu.hardcoreinfo", 1, null);
			}
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0, null);
		}
	}

	// Token: 0x0601273F RID: 75583 RVA: 0x0066CE5C File Offset: 0x0066B05C
	private IEnumerator DBDHBBGCLNC()
	{
		text = "original.tutorial";
		this.SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0, null);
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		SceneManager.LoadScene("GameScene");
		yield break;
	}

	// Token: 0x06012740 RID: 75584 RVA: 0x0066CE78 File Offset: 0x0066B078
	private IEnumerator MGIJGHNEFKG()
	{
		text = "original.tutorial";
		this.SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0, null);
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		SceneManager.LoadScene("GameScene");
		yield break;
	}

	// Token: 0x06012741 RID: 75585 RVA: 0x0066CE93 File Offset: 0x0066B093
	public void BPBMMGDOKLA()
	{
		SceneManager.LoadScene("achievements.id");
	}

	// Token: 0x06012742 RID: 75586 RVA: 0x0066CE9F File Offset: 0x0066B09F
	public void OnArcsDestroyDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcsdestroydelay", DPNHODJHGJL, null);
	}

	// Token: 0x06012743 RID: 75587 RVA: 0x0066CEB2 File Offset: 0x0066B0B2
	public void InitTipsCanvas()
	{
		base.StartCoroutine(this.NKPMFEHMGNP());
	}

	// Token: 0x06012744 RID: 75588 RVA: 0x0066CEC4 File Offset: 0x0066B0C4
	public override void Update()
	{
		base.Update();
		if (!Singleton<MapsSystem>.Instance.isLoaded && GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = "Loading maps".ToUpper();
		}
		if (!Singleton<ItemsHandler>.Instance.isLoaded && GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = "Loading inventory".ToUpper();
		}
		if ((!Singleton<RanksSystem>.Instance.isLoaded || SteamManager.connectingToServer) && GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = "Connecting to server".ToUpper();
		}
		if (!this.NDIBBILNLHJ && Singleton<MapsSystem>.Instance.isLoaded && Singleton<ItemsHandler>.Instance.isLoaded && !SteamManager.connectingToServer && Singleton<RanksSystem>.Instance.isLoaded)
		{
			Singleton<ItemsHandler>.Instance.CheckInventory();
			AudioClip ojcilkfonmh = Resources.Load<AudioClip>("Items/" + Singleton<ItemsHandler>.Instance.GetItemBySteamId(Singleton<ItemsHandler>.Instance.EnquippedItem(InventoryItemType.MenuTheme)).item.id + "/theme");
			this.asampler.Init(ojcilkfonmh, 0f, true);
			this.NDIBBILNLHJ = true;
			this.IJPCEKICPCP = 0;
			try
			{
				Singleton<ItemsHandler>.Instance.TriggerItemDrop();
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex.ToString());
			}
			try
			{
				base.StartCoroutine(this.LoadPlayerInfo());
			}
			catch (Exception ex2)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex2.ToString());
			}
			try
			{
				base.StartCoroutine(this.OCIPHAEEGGO());
			}
			catch (Exception ex3)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex3.ToString());
			}
			try
			{
				this.UpdateChallengesTile();
			}
			catch (Exception ex4)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex4.ToString());
			}
			try
			{
				this.IFPFEIBFKPO();
			}
			catch (Exception ex5)
			{
				UnityEngine.Debug.LogError("[MenuScene] Error: " + ex5.ToString());
			}
			if (Singleton<GameManager>.Instance.currentState == GameManager.GameState.Loading)
			{
				this.IJPCEKICPCP = 0;
				this.pressAnyKeyCanvas.SetActive(true);
				this.OnLoaded.Invoke();
			}
		}
		if (this.IJPCEKICPCP == 0 && (Input.anyKey || Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Menu))
		{
			if (Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Menu)
			{
				this.OnLoaded.Invoke();
			}
			Singleton<GameManager>.Instance.currentState = GameManager.GameState.Menu;
			this.IJPCEKICPCP = 1;
			Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu", null, null, null, 0, 0);
			this.OnPressAnyKey.Invoke();
			base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.mainMenuCanvas, true, null, true, 0.2f, true));
			base.ShowCursor(true);
			this.ABLMLLLDOPO = false;
			Helpers.ObtainAchievement(0);
			Singleton<ItemsHandler>.Instance.ObtainPromoItems();
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
				PhotonNetwork.room.open = true;
				base.GetComponent<NetworkMenu>().OnJoinedRoom();
			}
			if (Singleton<SaveSystem>.Instance.HasKey("menu.playedsolo", null))
			{
				base.StartCoroutine(this.NMMJBGCEBEB());
			}
			if (!Singleton<SaveSystem>.Instance.HasKey("player.playedtutorial", null))
			{
				this.PlayTutorial();
			}
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<ChallengesManager>.Instance.HasProgress())
			{
				Singleton<ChallengesManager>.Instance.RewardsReadyNotification();
			}
			if (Singleton<RanksSystem>.Instance.isRankChanged)
			{
				Singleton<RanksSystem>.Instance.DisplayRanksChanges();
			}
			if (Helpers.GetPlayerLevel(Helpers.GetStat("player.xp")) >= 10)
			{
				Helpers.ObtainAchievement(13);
			}
			if (Helpers.GetStat("player.gamecompleted") == 0 && Helpers.GetStat("achievements.21.progress") >= 10)
			{
				base.StartCoroutine(this.RateGameQuestion());
			}
			Singleton<GameManager>.Instance.CheckPlayerBans();
			Singleton<RanksSystem>.Instance.ReloadServerInfo();
			base.InvokeRepeating("MFODMAECFGP", 8f, 8f);
		}
		if (this.IJPCEKICPCP == 1)
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
			gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(0f, 0f, -this.playerDistance), Time.smoothDeltaTime * 5f);
			if (gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations < 10)
			{
				gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations++;
			}
		}
	}

	// Token: 0x06012745 RID: 75589 RVA: 0x0066D41C File Offset: 0x0066B61C
	public void JKNLFOBDGGO()
	{
		Singleton<GameManager>.Instance.NJOEGFFMEIC("<b>Time</b>:", true);
	}

	// Token: 0x06012746 RID: 75590 RVA: 0x0066D42E File Offset: 0x0066B62E
	public void OnArcsNoHitsoundTimeDelaySlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.arcsnohitsoundtimedelay", DPNHODJHGJL, null);
	}

	// Token: 0x06012747 RID: 75591 RVA: 0x0066BB9A File Offset: 0x00669D9A
	[CompilerGenerated]
	private static bool FOBOODEJMAP(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus > Challenge.CurrentStatus.NotStarted && IACGDFHKCAE.PlayerStatus < Challenge.CurrentStatus.ObtainedReward;
	}

	// Token: 0x06012748 RID: 75592 RVA: 0x0066D441 File Offset: 0x0066B641
	public void EEOFDNELEAF(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.CBIEBMGENJH("_DotSize", DPNHODJHGJL, null);
	}

	// Token: 0x06012749 RID: 75593 RVA: 0x0066D454 File Offset: 0x0066B654
	private static bool EPJDFDHLAJG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "maps.";
	}

	// Token: 0x0601274A RID: 75594 RVA: 0x0066D466 File Offset: 0x0066B666
	private static bool OPMKIILFJKL(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.PlayerStatus <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.OCNOEDGAPNL() < Challenge.CurrentStatus.NotStarted;
	}

	// Token: 0x0601274B RID: 75595 RVA: 0x0066D480 File Offset: 0x0066B680
	public void OnHitVariationSlider(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.SetFloat("settings.hitvariation", DPNHODJHGJL, null);
	}

	// Token: 0x0601274C RID: 75596 RVA: 0x0066D493 File Offset: 0x0066B693
	public void IGNNALCKOKO()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(true);
		this.AIBBBPLLCFJ(490f);
		base.StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(0, null, null, new UnityAction(this.FPEIMLDCGEG)));
	}

	// Token: 0x0601274D RID: 75597 RVA: 0x0066D4D3 File Offset: 0x0066B6D3
	public void OnGetMoreLevelsButton()
	{
		Singleton<GameManager>.Instance.OpenURL("https://steamcommunity.com/app/513510/workshop/", true);
	}

	// Token: 0x0601274E RID: 75598 RVA: 0x0066D4E5 File Offset: 0x0066B6E5
	private static float AGPPNCJKECJ(Vector2 AIEJPEPBAEJ)
	{
		return AIEJPEPBAEJ.x;
	}

	// Token: 0x0601274F RID: 75599 RVA: 0x0066D4F0 File Offset: 0x0066B6F0
	private IEnumerator HJJPNBBAJPP()
	{
		this.SetGameMode("solo");
		this.mainMenuCanvas.SetActive(false);
		this.SetPlayerDistance(4f);
		this.SetPlayerBlur(true);
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (MenuScene.NHHBOFOLDFN.LNIJKGECNME == null)
		{
			MenuScene.NHHBOFOLDFN.LNIJKGECNME = new Func<bool>(MenuScene.NHHBOFOLDFN.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MenuScene.NHHBOFOLDFN.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, new UnityAction(this.MHJOOKDMIHD), null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", Singleton<MapsListSelector>.Instance.result, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", (int)Singleton<MapsListSelector>.Instance.resultMode, null);
			SceneManager.LoadScene("GameScene");
		}
		yield break;
	}

	// Token: 0x06012750 RID: 75600 RVA: 0x0066D50C File Offset: 0x0066B70C
	public override void Start()
	{
		base.Start();
		this.NDIBBILNLHJ = false;
		UnityEngine.Debug.Log("[MenuScene] Inited");
		Resolution[] resolutions = Screen.resolutions;
		Resolution[] array = resolutions;
		for (int i = 0; i < array.Length; i++)
		{
			MenuScene.MIPBPLJOKPD mipbpljokpd = new MenuScene.MIPBPLJOKPD();
			mipbpljokpd.BBGBGFFPGDN = array[i];
			if (!this.BNEGFAHKIAA.Exists(new Predicate<Vector2>(mipbpljokpd.GBKBDKHPLKG)))
			{
				this.BNEGFAHKIAA.Add(new Vector2((float)mipbpljokpd.BBGBGFFPGDN.width, (float)mipbpljokpd.BBGBGFFPGDN.height));
			}
		}
		IEnumerable<Vector2> bnegfahkiaa = this.BNEGFAHKIAA;
		if (MenuScene.LNIJKGECNME == null)
		{
			MenuScene.LNIJKGECNME = new Func<Vector2, float>(MenuScene.NFHPEBCJNMP);
		}
		this.BNEGFAHKIAA = bnegfahkiaa.OrderBy(MenuScene.LNIJKGECNME).ToList<Vector2>();
		if (Singleton<GameManager>.Instance.currentState < GameManager.GameState.Menu)
		{
			Singleton<GameManager>.Instance.UpdateOnlineStatus("Loading...", null, null, null, 0, 0);
			Singleton<GameManager>.Instance.currentState = GameManager.GameState.Loading;
		}
	}

	// Token: 0x06012751 RID: 75601 RVA: 0x0066D60A File Offset: 0x0066B80A
	public void OnItemsUploaderButton()
	{
		SceneManager.LoadScene("ItemsUploader");
	}

	// Token: 0x06012752 RID: 75602 RVA: 0x0066D618 File Offset: 0x0066B818
	public void KPAKNODELBK(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.IEEHOAELCGE("_TimeX", false);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.OpenURL("#scoresubmitionfailed: ", true);
		}
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.IKDPMOJKILD("Hidden/DepthOfField/MedianFilter", false);
		}
		if (DFBMGAGGOHI == 6)
		{
			Singleton<GameManager>.Instance.OpenURL("<color=#", false);
		}
		if (DFBMGAGGOHI == 4)
		{
			Singleton<GameManager>.Instance.IEEHOAELCGE("_Offsets", true);
		}
	}

	// Token: 0x06012753 RID: 75603 RVA: 0x0066B5DE File Offset: 0x006697DE
	public void HDAOEDNALLJ(float PNNFAOFBLHK)
	{
		this.playerDistance = PNNFAOFBLHK;
	}

	// Token: 0x06012754 RID: 75604 RVA: 0x0066D698 File Offset: 0x0066B898
	public void OnShowHPToggle()
	{
		Transform transform = GameObject.Find("SettingsCanvas").transform;
		Singleton<SaveSystem>.Instance.SetBool("settings.showHP", transform.FindDeepChild("HPToggle").GetComponent<Toggle>().isOn, null);
	}

	// Token: 0x06012755 RID: 75605 RVA: 0x0066BBF5 File Offset: 0x00669DF5
	[CompilerGenerated]
	private void FPEIMLDCGEG()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(false);
		this.SetPlayerDistance(14f);
	}

	// Token: 0x06012756 RID: 75606 RVA: 0x0066D6DA File Offset: 0x0066B8DA
	public void InitRanksCanvas()
	{
		this.mainMenuCanvas.SetActive(false);
		this.SetPlayerBlur(true);
		this.SetPlayerDistance(7f);
		base.StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(0, null, null, new UnityAction(this.FPEIMLDCGEG)));
	}

	// Token: 0x06012757 RID: 75607 RVA: 0x0066D71C File Offset: 0x0066B91C
	public override void AIJGAJIOJDJ()
	{
		base.PHJJHFBLICM();
		if (!Singleton<MapsSystem>.Instance.isLoaded && GameObject.Find("z"))
		{
			GameObject.Find("Editor").GetComponent<Text>().text = "No regions available. Are you sure your appid is valid and setup?".ToUpper();
		}
		if (!Singleton<ItemsHandler>.Instance.isLoaded && GameObject.Find("/"))
		{
			GameObject.Find("_Value1").GetComponent<Text>().text = "_MainTex2".ToUpper();
		}
		if ((!Singleton<RanksSystem>.Instance.isLoaded || SteamManager.connectingToServer) && GameObject.Find("_Value"))
		{
			GameObject.Find("Obtain promo Item").GetComponent<Text>().text = "ns".ToUpper();
		}
		if (!this.NDIBBILNLHJ && Singleton<MapsSystem>.Instance.isLoaded && Singleton<ItemsHandler>.Instance.isLoaded && !SteamManager.connectingToServer && Singleton<RanksSystem>.Instance.isLoaded)
		{
			Singleton<ItemsHandler>.Instance.CheckInventory();
			AudioClip ojcilkfonmh = Resources.Load<AudioClip>("No player left to ask" + Singleton<ItemsHandler>.Instance.GetItemBySteamId(Singleton<ItemsHandler>.Instance.FKJFGDPFDPK(InventoryItemType.MenuTheme)).item.id + "HightScoreMaxPointsText");
			this.asampler.Init(ojcilkfonmh, 1569f, false);
			this.NDIBBILNLHJ = true;
			this.IJPCEKICPCP = 0;
			try
			{
				Singleton<ItemsHandler>.Instance.PMIOFIMECAL();
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError("_Overlay" + ex.ToString());
			}
			try
			{
				base.StartCoroutine(this.CGJLJNMOMLA());
			}
			catch (Exception ex2)
			{
				UnityEngine.Debug.LogError("_Intensity" + ex2.ToString());
			}
			try
			{
				base.StartCoroutine(this.OCIPHAEEGGO());
			}
			catch (Exception ex3)
			{
				UnityEngine.Debug.LogError(": " + ex3.ToString());
			}
			try
			{
				this.UpdateChallengesTile();
			}
			catch (Exception ex4)
			{
				UnityEngine.Debug.LogError("PointsScoreText" + ex4.ToString());
			}
			try
			{
				this.BPBGOKGNDJB();
			}
			catch (Exception ex5)
			{
				UnityEngine.Debug.LogError(": " + ex5.ToString());
			}
			if (Singleton<GameManager>.Instance.currentState == GameManager.GameState.Init)
			{
				this.IJPCEKICPCP = 1;
				this.pressAnyKeyCanvas.SetActive(false);
				this.OnLoaded.Invoke();
			}
		}
		if (this.IJPCEKICPCP == 0 && (Input.anyKey || Singleton<GameManager>.Instance.currentState >= GameManager.GameState.Menu))
		{
			if (Singleton<GameManager>.Instance.currentState >= (GameManager.GameState)6)
			{
				this.OnLoaded.Invoke();
			}
			Singleton<GameManager>.Instance.currentState = GameManager.GameState.Loading;
			this.IJPCEKICPCP = 1;
			Singleton<GameManager>.Instance.IPOGIBLJDPE(".wav", null, null, null, 1, 0);
			this.OnPressAnyKey.Invoke();
			base.StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(this.mainMenuCanvas, true, null, false, 1820f, false));
			base.GMGMPMIIMLP(true);
			this.ABLMLLLDOPO = false;
			Helpers.ObtainAchievement(1);
			Singleton<ItemsHandler>.Instance.NPLAKLFJEOF();
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				base.GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("_ScreenResolution").GetComponent<Button>().onClick.Invoke();
				PhotonNetwork.room.LBHJHCKLANM(false);
				base.GetComponent<NetworkMenu>().KPGIJJHDCJI();
			}
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("Failed to InstantiateSceneObject prefab: ", null))
			{
				base.StartCoroutine(this.HJJPNBBAJPP());
			}
			if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_TimeX", null))
			{
				this.PlayTutorial();
			}
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ODADIAEDJFD();
			}
			if (Singleton<ChallengesManager>.Instance.HKBEDHGKHLG())
			{
				Singleton<ChallengesManager>.Instance.HCJMCPGGPKH();
			}
			if (Singleton<RanksSystem>.Instance.isRankChanged)
			{
				Singleton<RanksSystem>.Instance.KFBKMKHMAPJ();
			}
			if (Helpers.GetPlayerLevel(Helpers.GetStat("Object ID. Case-Sensitive")) >= 95)
			{
				Helpers.ObtainAchievement(-74);
			}
			if (Helpers.GetStat("_Intensity") == 0 && Helpers.GetStat("#close") >= -16)
			{
				base.StartCoroutine(this.RateGameQuestion());
			}
			Singleton<GameManager>.Instance.GMEFFKOFBLL();
			Singleton<RanksSystem>.Instance.DAHGNLKGIJK();
			base.InvokeRepeating("blue", 945f, 1315f);
		}
		if (this.IJPCEKICPCP == 0)
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("(\\[ *i *\\])");
			gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(1526f, 1018f, -this.playerDistance), Time.smoothDeltaTime * 1163f);
			if (gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations < -79)
			{
				gameObject.GetComponentInChildren<Camera>().gameObject.GetComponent<Blur>().iterations += 0;
			}
		}
	}

	// Token: 0x06012758 RID: 75608 RVA: 0x0066DC74 File Offset: 0x0066BE74
	private static bool JILHPDHFHAG(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "_Value3";
	}

	// Token: 0x06012759 RID: 75609 RVA: 0x0002523B File Offset: 0x0002343B
	public void DBHOOLCPPKM()
	{
	}

	// Token: 0x0601275A RID: 75610 RVA: 0x0066DC88 File Offset: 0x0066BE88
	public void NALLEMIPMBE()
	{
		if (GameManager.PEJIIBNCKEI())
		{
			TipsListElement tipsListElement = this.tip;
			RanksSystem.PlayerTip playerTip = new RanksSystem.PlayerTip();
			playerTip.CDDGMCLMPEG(LocalizationService.Instance.HOPMEAJKPHL("BloodAlternative3"));
			playerTip.POPAHCMKOHP(1UL);
			playerTip.HCEOMMIJOFO(SteamUser.GetSteamID().m_SteamID);
			tipsListElement.EPDCHKECMBL(playerTip);
			return;
		}
		if (RanksSystem.HACOOAAIPEN().Count > 0)
		{
			this.tip.LLAHPNGMEOO(RanksSystem.HACOOAAIPEN()[UnityEngine.Random.Range(1, RanksSystem.EAGFIMBCDCP().Count)]);
		}
	}

	// Token: 0x0601275B RID: 75611 RVA: 0x0066DD17 File Offset: 0x0066BF17
	public void NFECGCNOGOJ(float DPNHODJHGJL)
	{
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("Hex value #RRGGBB", DPNHODJHGJL, null);
	}

	// Token: 0x0601275C RID: 75612 RVA: 0x0066D4E5 File Offset: 0x0066B6E5
	[CompilerGenerated]
	private static float NFHPEBCJNMP(Vector2 AIEJPEPBAEJ)
	{
		return AIEJPEPBAEJ.x;
	}

	// Token: 0x0601275D RID: 75613 RVA: 0x0066DD2C File Offset: 0x0066BF2C
	public void BCOPKOLKGDC()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("LevelEditor/patterns", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("L1", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("Object ID. Case-Sensitive", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("isVisible", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("_DistortionSize", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(" GameServer:", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("]", null);
		Singleton<SaveSystem>.Instance.DeleteKey(",", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("SetParticlesParticleSpeed", null);
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("_TimeX", null);
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("/files/editor_manual.pdf", null);
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("ViewMenu", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("CameraFilterPack/FX_ZebraColor", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(". The group number should be at least 1.", null);
		Singleton<SaveSystem>.Instance.DeleteKey(".workshop", null);
		Singleton<SaveSystem>.Instance.DeleteKey("11", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("Set satellite trail width", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("Updating...", null);
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP("settings.enablehitsoundsinrelax", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("_TimeX", null);
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP("x", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(". Verify the Prefab is in a Resources folder (and not in a subfolder)", null);
		hardInput.JONAFAINKKM();
		VolumeSettings component = GameObject.FindGameObjectWithTag("shader.pixel").GetComponent<VolumeSettings>();
		component.PNKIOJIKKEG(Singleton<SaveSystem>.Instance.OLHIEOKMOAK("finished", 1635f, null));
		component.PEMGCAIGPPP(Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_TimeX", 668f, null));
		component.DMLECMADHCP(Singleton<SaveSystem>.Instance.OLHIEOKMOAK("setAF", 216f, null));
		component.IDMPNIJDPEI(Singleton<SaveSystem>.Instance.GetFloat("Search: ", 1790f, null));
		Transform transform = GameObject.Find("CameraFilterPack/FX_superDot").transform;
		QualitySettings.SetQualityLevel(0);
		this.InitSettingsCanvas();
		base.GetComponent<ShadersSettings>().OHJBECDKMGN(transform.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn);
		base.GetComponent<FPSSettings>().SetFPSEnabled(transform.FindDeepChild("Default UI Material").GetComponent<Toggle>().isOn);
	}

	// Token: 0x0601275E RID: 75614 RVA: 0x0066DF76 File Offset: 0x0066C176
	public void SaveData()
	{
		Singleton<SaveSystem>.Instance.Flush();
	}

	// Token: 0x0601275F RID: 75615 RVA: 0x0066DF84 File Offset: 0x0066C184
	public void GGLLIDEFMJC()
	{
		Transform transform = GameObject.Find("_ScreenResolution").transform;
		if (transform.FindDeepChild("Parent object ID. Case-Sensitive"))
		{
			transform.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("_TimeX").GetComponent<ShadersSettings>().IBFEBKLBJOL();
		}
		if (transform.FindDeepChild("SetParticlesParticleSize"))
		{
			transform.FindDeepChild("[Left]").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("LoadingStatusText").GetComponent<FPSSettings>().GGAAOAEKGIP();
		}
		if (transform.FindDeepChild("SetSatelliteTrailMinVertexDistance"))
		{
			transform.FindDeepChild("_Value3").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Myst_Color", null) && false);
		}
		if (transform.FindDeepChild("PlaySound"))
		{
			transform.FindDeepChild("_Value8").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.IOLBIFOIHML("maps.", true, null);
		}
		if (transform.FindDeepChild("_FadeFX"))
		{
			transform.FindDeepChild(" | ").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if (transform.FindDeepChild("In Main Menu"))
		{
			transform.FindDeepChild("_Value").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Value2").GetComponent<VolumeSettings>().HPGOMHIMAEL();
		}
		if (transform.FindDeepChild(".lastCheckpoint.incorrectScore"))
		{
			transform.FindDeepChild("_TimeX").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_MainTex").GetComponent<VolumeSettings>().ECDGHHKPIHL();
		}
		if (transform.FindDeepChild("_Value"))
		{
			transform.FindDeepChild("Mouse Y").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("SpawnObj", 0, null) != 1 || true);
		}
		if (transform.FindDeepChild("CameraFilterPack/TV_ARCADE_2"))
		{
			transform.FindDeepChild("Up").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.LCHPECEJMPE("id", false, null);
		}
		if (transform.FindDeepChild("PerfectHitsScoreText"))
		{
			transform.FindDeepChild("CameraFilterPack/3D_Matrix").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HasKey("0x", null);
		}
		if (transform.FindDeepChild(" b."))
		{
			transform.FindDeepChild("steamid").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("_Value3").GetComponent<VolumeSettings>().KICALMOMCBM();
		}
		if (transform.FindDeepChild("[PlayerController] "))
		{
			transform.FindDeepChild("DisableStoryboardToggle").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("/", 187f, null);
		}
		if (transform.FindDeepChild("_Offsets"))
		{
			transform.FindDeepChild(" PhotonView: ").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_TimeX", 1826f, null);
		}
		if (transform.FindDeepChild("Events Moved"))
		{
			transform.FindDeepChild("{0:0} second{1}").GetComponent<Slider>().value = (float)QualitySettings.GetQualityLevel();
		}
		if (transform.FindDeepChild("CorrectHitsScoreText"))
		{
			transform.FindDeepChild("inventory.selected.").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("/", 763f, null);
		}
		if (transform.FindDeepChild("Received OnSerialization for view ID "))
		{
			transform.FindDeepChild("SpawnObj").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Tab1Content", 1308f, null) * 606f;
		}
		if (transform.FindDeepChild("SetParticlesParticleSize"))
		{
			transform.FindDeepChild("workshop.").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_AdaptionSpeed", 1115f, null);
		}
		if (transform.FindDeepChild("_Heigh"))
		{
			transform.FindDeepChild("_MainTex2").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("_ScreenResolution", 1513f, null);
		}
		if (transform.FindDeepChild("Could not find RPC with index: "))
		{
			transform.FindDeepChild("shader.crispwinter").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("(\\[ */ *quote *\\])", 1366f, null);
		}
		if (transform.FindDeepChild("_Size"))
		{
			transform.FindDeepChild("UNDISTORT").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("_Value", 300f, null);
		}
		if (transform.FindDeepChild("#close"))
		{
			transform.FindDeepChild("_BlendTex").GetComponent<Slider>().value = (float)Singleton<SaveSystem>.Instance.CEKEOJDAEOD("#8E8E8EFF", -105, null);
		}
		if (transform.FindDeepChild(". Possible scene loading in progress?"))
		{
			transform.FindDeepChild("_MainTex2").Find("menu.selectedplaymode").GetComponent<Text>().text = Screen.currentResolution.width + "_FadeFX" + Screen.currentResolution.height;
		}
		if (transform.FindDeepChild("bad"))
		{
			transform.FindDeepChild("_SunPosition").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("<color=#{0}>{1}</color>", 1, null) != 1 || true);
		}
		if (!GameManager.FCKAHHLOMIC())
		{
			if (transform.FindDeepChild("_Value2"))
			{
				transform.FindDeepChild("00").GetComponent<Toggle>().isOn = true;
				transform.FindDeepChild("\"").GetComponent<Toggle>().interactable = false;
			}
			if (transform.FindDeepChild("_Offsets"))
			{
				transform.FindDeepChild("#ok").GetComponent<Toggle>().isOn = true;
				transform.FindDeepChild("HiddenToggle").GetComponent<Toggle>().interactable = true;
			}
		}
		if (transform.FindDeepChild("_Fade"))
		{
			transform.FindDeepChild("_TimeX").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.GetInt("Tab2Content", 0, null) != 1);
		}
		List<Vector2> bnegfahkiaa = this.BNEGFAHKIAA;
		List<Vector2> bnegfahkiaa2 = this.BNEGFAHKIAA;
		if (MenuScene.LCIPKAPHIPI == null)
		{
			MenuScene.LCIPKAPHIPI = new Predicate<Vector2>(MenuScene.IHHPJEAHLBO);
		}
		this.KNOAFBDEBDK = bnegfahkiaa.IndexOf(bnegfahkiaa2.Find(MenuScene.LCIPKAPHIPI));
	}

	// Token: 0x06012760 RID: 75616 RVA: 0x0066BBF5 File Offset: 0x00669DF5
	[CompilerGenerated]
	private void FLICOEHOIPL()
	{
		this.mainMenuCanvas.SetActive(true);
		this.SetPlayerBlur(false);
		this.SetPlayerDistance(14f);
	}

	// Token: 0x06012761 RID: 75617 RVA: 0x0066E672 File Offset: 0x0066C872
	private static bool OFPAHEMDOFF(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.OCNOEDGAPNL() != Challenge.CurrentStatus.NotStarted || Helpers.isChallengeUnlocked(IACGDFHKCAE.PNHHKLBLPEB());
	}

	// Token: 0x06012762 RID: 75618 RVA: 0x0066E690 File Offset: 0x0066C890
	public void GetRandomTip()
	{
		if (GameManager.IsOffline)
		{
			this.tip.Init(new RanksSystem.PlayerTip
			{
				tip = LocalizationService.Instance.GetLocalizatedText("#turnoninternet"),
				id = 0UL,
				steamID = SteamUser.GetSteamID().m_SteamID
			});
			return;
		}
		if (RanksSystem.GetTipsList().Count > 0)
		{
			this.tip.Init(RanksSystem.GetTipsList()[UnityEngine.Random.Range(0, RanksSystem.GetTipsList().Count)]);
		}
	}

	// Token: 0x06012763 RID: 75619 RVA: 0x0066E720 File Offset: 0x0066C920
	private IEnumerator NMMJBGCEBEB()
	{
		this.SetGameMode("solo");
		this.mainMenuCanvas.SetActive(false);
		this.SetPlayerDistance(4f);
		this.SetPlayerBlur(true);
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		if (MenuScene.NHHBOFOLDFN.LNIJKGECNME == null)
		{
			MenuScene.NHHBOFOLDFN.LNIJKGECNME = new Func<bool>(MenuScene.NHHBOFOLDFN.GBKBDKHPLKG);
		}
		yield return new WaitUntil(MenuScene.NHHBOFOLDFN.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1, null), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1, null), null, true, new UnityAction(this.MHJOOKDMIHD), null));
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
			Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", Singleton<MapsListSelector>.Instance.result, null);
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", (int)Singleton<MapsListSelector>.Instance.resultMode, null);
			SceneManager.LoadScene("GameScene");
		}
		yield break;
	}

	// Token: 0x06012764 RID: 75620 RVA: 0x0066E73B File Offset: 0x0066C93B
	private static bool MMPJAOJJFON(GameObject IACGDFHKCAE)
	{
		return IACGDFHKCAE.name == "<b>";
	}

	// Token: 0x06012765 RID: 75621 RVA: 0x0066E74D File Offset: 0x0066C94D
	public void OnEnableHitSoundsInRelaxToggle(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinrelax", 1, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.SetInt("settings.enablehitsoundsinrelax", 0, null);
		}
	}

	// Token: 0x06012766 RID: 75622 RVA: 0x0066E77C File Offset: 0x0066C97C
	public void SelectMapForSingleplayer()
	{
		base.StartCoroutine(this.NMMJBGCEBEB());
	}

	// Token: 0x06012767 RID: 75623 RVA: 0x0066E78B File Offset: 0x0066C98B
	public void LIOECDDFHOG()
	{
		Singleton<GameManager>.Instance.GMDIJMFPKOC(Singleton<GameManager>.Instance.CreateServerURL("DataText"), true);
	}

	// Token: 0x06012768 RID: 75624 RVA: 0x0066E7A8 File Offset: 0x0066C9A8
	public void InitSettingsCanvas()
	{
		Transform transform = GameObject.Find("SettingsCanvas").transform;
		if (transform.FindDeepChild("ShadersToggle"))
		{
			transform.FindDeepChild("ShadersToggle").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("Scene").GetComponent<ShadersSettings>().IsShadersEnabled();
		}
		if (transform.FindDeepChild("FPSToggle"))
		{
			transform.FindDeepChild("FPSToggle").GetComponent<Toggle>().isOn = GameObject.FindGameObjectWithTag("Scene").GetComponent<FPSSettings>().IsFPSEnabled();
		}
		if (transform.FindDeepChild("SelectorMusicToggle"))
		{
			transform.FindDeepChild("SelectorMusicToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null);
		}
		if (transform.FindDeepChild("HPToggle"))
		{
			transform.FindDeepChild("HPToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("settings.showHP", true, null);
		}
		if (transform.FindDeepChild("FullscreenToggle"))
		{
			transform.FindDeepChild("FullscreenToggle").GetComponent<Toggle>().isOn = Screen.fullScreen;
		}
		if (transform.FindDeepChild("MenuVolumeSlider"))
		{
			transform.FindDeepChild("MenuVolumeSlider").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>().GetMenuVolume();
		}
		if (transform.FindDeepChild("GameVolumeSlider"))
		{
			transform.FindDeepChild("GameVolumeSlider").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>().GetGameVolume();
		}
		if (transform.FindDeepChild("HitInRelaxMusicToggle"))
		{
			transform.FindDeepChild("HitInRelaxMusicToggle").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0, null) == 1);
		}
		if (transform.FindDeepChild("DisableStoryboardToggle"))
		{
			transform.FindDeepChild("DisableStoryboardToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false, null);
		}
		if (transform.FindDeepChild("SelectorMusicToggle"))
		{
			transform.FindDeepChild("SelectorMusicToggle").GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null);
		}
		if (transform.FindDeepChild("SfxVolumeSlider"))
		{
			transform.FindDeepChild("SfxVolumeSlider").GetComponent<Slider>().value = GameObject.FindGameObjectWithTag("Scene").GetComponent<VolumeSettings>().GetSfxVolume();
		}
		if (transform.FindDeepChild("HitVariationSlider"))
		{
			transform.FindDeepChild("HitVariationSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.hitvariation", 0.25f, null);
		}
		if (transform.FindDeepChild("BloomShaderValueSlider"))
		{
			transform.FindDeepChild("BloomShaderValueSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.shaders.bloomintencity", 0.05f, null);
		}
		if (transform.FindDeepChild("GraphicsQualitySlider"))
		{
			transform.FindDeepChild("GraphicsQualitySlider").GetComponent<Slider>().value = (float)QualitySettings.GetQualityLevel();
		}
		if (transform.FindDeepChild("CameraMovementSlider"))
		{
			transform.FindDeepChild("CameraMovementSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.cameramovements", 1f, null);
		}
		if (transform.FindDeepChild("CrosshairOpacitySlider"))
		{
			transform.FindDeepChild("CrosshairOpacitySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f, null) * 100f;
		}
		if (transform.FindDeepChild("GameMessagesDurationSlider"))
		{
			transform.FindDeepChild("GameMessagesDurationSlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f, null);
		}
		if (transform.FindDeepChild("ArcsDestroyDelaySlider"))
		{
			transform.FindDeepChild("ArcsDestroyDelaySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsdestroydelay", 0.1f, null);
		}
		if (transform.FindDeepChild("ArcsNoHitsoundTimeDelaySlider"))
		{
			transform.FindDeepChild("ArcsNoHitsoundTimeDelaySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsnohitsoundtimedelay", 0f, null);
		}
		if (transform.FindDeepChild("ArcsHitsoundTimeDelaySlider"))
		{
			transform.FindDeepChild("ArcsHitsoundTimeDelaySlider").GetComponent<Slider>().value = Singleton<SaveSystem>.Instance.GetFloat("settings.arcshitsoundtimedelay", -0.11f, null);
		}
		if (transform.FindDeepChild("SelectorMapsCountSlider"))
		{
			transform.FindDeepChild("SelectorMapsCountSlider").GetComponent<Slider>().value = (float)Singleton<SaveSystem>.Instance.GetInt("settings.selectormapsperpage", 21, null);
		}
		if (transform.FindDeepChild("ScreenResolutionPanel"))
		{
			transform.FindDeepChild("ScreenResolutionPanel").Find("Value").GetComponent<Text>().text = Screen.currentResolution.width + " x " + Screen.currentResolution.height;
		}
		if (transform.FindDeepChild("EnableRankingToggle"))
		{
			transform.FindDeepChild("EnableRankingToggle").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.GetInt("settings.enableranking", 1, null) == 1);
		}
		if (!GameManager.IsOwner())
		{
			if (transform.FindDeepChild("EnableRankingToggle"))
			{
				transform.FindDeepChild("EnableRankingToggle").GetComponent<Toggle>().isOn = false;
				transform.FindDeepChild("EnableRankingToggle").GetComponent<Toggle>().interactable = false;
			}
			if (transform.FindDeepChild("EnableRankedNotificationsToggle"))
			{
				transform.FindDeepChild("EnableRankedNotificationsToggle").GetComponent<Toggle>().isOn = false;
				transform.FindDeepChild("EnableRankedNotificationsToggle").GetComponent<Toggle>().interactable = false;
			}
		}
		if (transform.FindDeepChild("EnableRankedNotificationsToggle"))
		{
			transform.FindDeepChild("EnableRankedNotificationsToggle").GetComponent<Toggle>().isOn = (Singleton<SaveSystem>.Instance.GetInt("settings.enablerankingnotifications", 1, null) == 1);
		}
		List<Vector2> bnegfahkiaa = this.BNEGFAHKIAA;
		List<Vector2> bnegfahkiaa2 = this.BNEGFAHKIAA;
		if (MenuScene.LCIPKAPHIPI == null)
		{
			MenuScene.LCIPKAPHIPI = new Predicate<Vector2>(MenuScene.IHHPJEAHLBO);
		}
		this.KNOAFBDEBDK = bnegfahkiaa.IndexOf(bnegfahkiaa2.Find(MenuScene.LCIPKAPHIPI));
	}

	// Token: 0x06012769 RID: 75625 RVA: 0x0066EE98 File Offset: 0x0066D098
	private void GMJNAPLLOND()
	{
		List<GameObject> list = this.menuTiles;
		if (MenuScene.KCAPKHIJOHL == null)
		{
			MenuScene.KCAPKHIJOHL = new Predicate<GameObject>(MenuScene.DMDGONAJGND);
		}
		if (list.Find(MenuScene.KCAPKHIJOHL))
		{
			List<GameObject> list2 = this.menuTiles;
			if (MenuScene.DIEBHABBNGF == null)
			{
				MenuScene.DIEBHABBNGF = new Predicate<GameObject>(MenuScene.KMFLLCDHOPB);
			}
			list2.Find(MenuScene.DIEBHABBNGF).GetComponent<Button>().interactable = !GameManager.IsOffline;
		}
		List<GameObject> list3 = this.menuTiles;
		if (MenuScene.FBNFNGBBKHH == null)
		{
			MenuScene.FBNFNGBBKHH = new Predicate<GameObject>(MenuScene.OBBLIPPPGPI);
		}
		if (list3.Find(MenuScene.FBNFNGBBKHH))
		{
			List<GameObject> list4 = this.menuTiles;
			if (MenuScene.NFNJKONOIJD == null)
			{
				MenuScene.NFNJKONOIJD = new Predicate<GameObject>(MenuScene.CKIGFOCPHJN);
			}
			list4.Find(MenuScene.NFNJKONOIJD).GetComponent<Button>().interactable = !GameManager.JLAGBKACIIC();
		}
		List<GameObject> list5 = this.menuTiles;
		if (MenuScene.LBLKOBNMMNL == null)
		{
			MenuScene.LBLKOBNMMNL = new Predicate<GameObject>(MenuScene.BJHHLJBNOBG);
		}
		if (list5.Find(MenuScene.LBLKOBNMMNL))
		{
			List<GameObject> list6 = this.menuTiles;
			if (MenuScene.AKLIPIAOCIA == null)
			{
				MenuScene.AKLIPIAOCIA = new Predicate<GameObject>(MenuScene.BENAPOCGKLD);
			}
			list6.Find(MenuScene.AKLIPIAOCIA).GetComponent<Button>().interactable = GameManager.IELIHANIEAC();
		}
		List<GameObject> list7 = this.menuTiles;
		if (MenuScene.EINGHFEALEJ == null)
		{
			MenuScene.EINGHFEALEJ = new Predicate<GameObject>(MenuScene.DCAKGICPDKL);
		}
		if (list7.Find(MenuScene.EINGHFEALEJ))
		{
			List<GameObject> list8 = this.menuTiles;
			if (MenuScene.ONMBGDBHKBH == null)
			{
				MenuScene.ONMBGDBHKBH = new Predicate<GameObject>(MenuScene.HNBBKDMOGLC);
			}
			list8.Find(MenuScene.ONMBGDBHKBH).GetComponent<Button>().interactable = !GameManager.JLAGBKACIIC();
		}
		List<GameObject> list9 = this.menuTiles;
		if (MenuScene.NPFIKAFPOOO == null)
		{
			MenuScene.NPFIKAFPOOO = new Predicate<GameObject>(MenuScene.MLJANIMOCLC);
		}
		if (list9.Find(MenuScene.NPFIKAFPOOO))
		{
			List<GameObject> list10 = this.menuTiles;
			if (MenuScene.AANIPNEBEAL == null)
			{
				MenuScene.AANIPNEBEAL = new Predicate<GameObject>(MenuScene.KNCKDLMHJNE);
			}
			list10.Find(MenuScene.AANIPNEBEAL).GetComponent<Button>().interactable = !GameManager.PEJIIBNCKEI();
		}
		List<GameObject> list11 = this.menuTiles;
		if (MenuScene.NHFDPIFJIKB == null)
		{
			MenuScene.NHFDPIFJIKB = new Predicate<GameObject>(MenuScene.HMPHCJBHJGG);
		}
		if (list11.Find(MenuScene.NHFDPIFJIKB))
		{
			List<GameObject> list12 = this.menuTiles;
			if (MenuScene.OHJMJNOAGMD == null)
			{
				MenuScene.OHJMJNOAGMD = new Predicate<GameObject>(MenuScene.KJJHGMHJAJP);
			}
			list12.Find(MenuScene.OHJMJNOAGMD).GetComponent<Button>().interactable = GameManager.IELIHANIEAC();
		}
		List<GameObject> list13 = this.menuTiles;
		if (MenuScene.LIDCPIMJKNB == null)
		{
			MenuScene.LIDCPIMJKNB = new Predicate<GameObject>(MenuScene.OOJLOCNKHOF);
		}
		if (list13.Find(MenuScene.LIDCPIMJKNB))
		{
			List<GameObject> list14 = this.menuTiles;
			if (MenuScene.OLKKCLAKBDJ == null)
			{
				MenuScene.OLKKCLAKBDJ = new Predicate<GameObject>(MenuScene.MGLAMCMGJOB);
			}
			list14.Find(MenuScene.OLKKCLAKBDJ).GetComponent<Button>().interactable = GameManager.JLAGBKACIIC();
		}
	}

	// Token: 0x0601276A RID: 75626 RVA: 0x0066F199 File Offset: 0x0066D399
	public void FBIFAGDHIPA(bool BAFGNGPNHAP)
	{
		if (BAFGNGPNHAP)
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA(",", 0, null);
		}
		else
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("Set satellite beat detection sensitivity", 0, null);
		}
	}

	// Token: 0x0601276B RID: 75627 RVA: 0x0066F1C8 File Offset: 0x0066D3C8
	public void InitChallengesCanvas()
	{
		this.mainMenuCanvas.SetActive(false);
		this.SetPlayerBlur(true);
		this.SetPlayerDistance(7f);
		base.StartCoroutine(Singleton<ChallengesManagerUI>.Instance.DisplayViewer(new UnityAction(this.GEMMLOGEJON)));
	}

	// Token: 0x0601276C RID: 75628 RVA: 0x0066F205 File Offset: 0x0066D405
	public void EGDELPMABLH()
	{
		this.mainMenuCanvas.SetActive(false);
		this.SetPlayerBlur(false);
		this.AIBBBPLLCFJ(241f);
		base.StartCoroutine(Singleton<ChallengesManagerUI>.Instance.DOHCPHEEGJJ(new UnityAction(this.GOGLEOJCHHG)));
	}

	// Token: 0x0601276D RID: 75629 RVA: 0x0066F244 File Offset: 0x0066D444
	public void PDCMLNAELGH(int DFBMGAGGOHI)
	{
		if (DFBMGAGGOHI == 1)
		{
			Singleton<GameManager>.Instance.GMDIJMFPKOC("[MapEditor] Loaded music file: ", true);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.NJOEGFFMEIC("/Segment-[Left]", false);
		}
		if (DFBMGAGGOHI == 4)
		{
			Singleton<GameManager>.Instance.GMDIJMFPKOC("1", true);
		}
		if (DFBMGAGGOHI == 0)
		{
			Singleton<GameManager>.Instance.MKEGIDHHLIC("CameraFilterPack/Blend2Camera_ColorDodge", true);
		}
		if (DFBMGAGGOHI == 2)
		{
			Singleton<GameManager>.Instance.NJOEGFFMEIC("0.00", true);
		}
	}

	// Token: 0x0601276E RID: 75630 RVA: 0x0066F2C3 File Offset: 0x0066D4C3
	private static bool FOINDIGLLBC(Challenge IACGDFHKCAE)
	{
		return IACGDFHKCAE.CJNNAAGGAJI() <= Challenge.CurrentStatus.NotStarted || IACGDFHKCAE.OCNOEDGAPNL() < Challenge.CurrentStatus.NotStarted;
	}

	// Token: 0x0601276F RID: 75631 RVA: 0x0066F2E0 File Offset: 0x0066D4E0
	private IEnumerator KHHAJELAMPM()
	{
		text = "original.tutorial";
		this.SetGameMode("solo");
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo", null);
		Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab, null);
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text, null);
		Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", 0, null);
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		SceneManager.LoadScene("GameScene");
		yield break;
	}

	// Token: 0x0400206C RID: 8300
	public Text challengetText;

	// Token: 0x0400206D RID: 8301
	public GameObject sun;

	// Token: 0x0400206E RID: 8302
	public GameObject pressAnyKeyCanvas;

	// Token: 0x0400206F RID: 8303
	public GameObject mainMenuCanvas;

	// Token: 0x04002070 RID: 8304
	public GameObject newsTile;

	// Token: 0x04002071 RID: 8305
	public GameObject newItemsCanvas;

	// Token: 0x04002072 RID: 8306
	public GameObject newItemsListContent;

	// Token: 0x04002073 RID: 8307
	public GameObject inventoryGroupsContent;

	// Token: 0x04002074 RID: 8308
	public GameObject inventoryGroupElement;

	// Token: 0x04002075 RID: 8309
	public GameObject tipsListContent;

	// Token: 0x04002076 RID: 8310
	public GameObject tipsListElement;

	// Token: 0x04002077 RID: 8311
	public TipsListElement tip;

	// Token: 0x04002078 RID: 8312
	public float playerDistance = 14f;

	// Token: 0x04002079 RID: 8313
	public AudioSampler asampler;

	// Token: 0x0400207A RID: 8314
	public UnityEvent OnLoaded;

	// Token: 0x0400207B RID: 8315
	public UnityEvent OnPressAnyKey;

	// Token: 0x0400207C RID: 8316
	public UnityEvent OnPressAnyKeyFirstLaunch;

	// Token: 0x0400207D RID: 8317
	public UnityEvent OnGameCompleted;

	// Token: 0x0400207E RID: 8318
	public ProfileInfo pInfo;

	// Token: 0x0400207F RID: 8319
	private bool NDIBBILNLHJ;

	// Token: 0x04002080 RID: 8320
	private bool ABLMLLLDOPO;

	// Token: 0x04002081 RID: 8321
	private int IJPCEKICPCP = -1;

	// Token: 0x04002082 RID: 8322
	private bool FOHPPAKJEHA;

	// Token: 0x04002083 RID: 8323
	private List<Vector2> BNEGFAHKIAA = new List<Vector2>();

	// Token: 0x04002084 RID: 8324
	private int KNOAFBDEBDK;

	// Token: 0x04002085 RID: 8325
	private int EKGCLHGOFMG = 3;

	// Token: 0x04002086 RID: 8326
	private int NIMEMPHGJCO;

	// Token: 0x04002087 RID: 8327
	public List<GameObject> menuTiles;

	// Token: 0x04002088 RID: 8328
	[CompilerGenerated]
	private static Func<Vector2, float> LNIJKGECNME;

	// Token: 0x04002089 RID: 8329
	[CompilerGenerated]
	private static Func<Challenge, bool> CLCBJCKCBDD;

	// Token: 0x0400208A RID: 8330
	[CompilerGenerated]
	private static Func<Challenge, bool> HCLEECLNOEA;

	// Token: 0x0400208B RID: 8331
	[CompilerGenerated]
	private static Func<Challenge, bool> ADLAKIHINOM;

	// Token: 0x0400208C RID: 8332
	[CompilerGenerated]
	private static Predicate<GameObject> KCAPKHIJOHL;

	// Token: 0x0400208D RID: 8333
	[CompilerGenerated]
	private static Predicate<GameObject> DIEBHABBNGF;

	// Token: 0x0400208E RID: 8334
	[CompilerGenerated]
	private static Predicate<GameObject> FBNFNGBBKHH;

	// Token: 0x0400208F RID: 8335
	[CompilerGenerated]
	private static Predicate<GameObject> NFNJKONOIJD;

	// Token: 0x04002090 RID: 8336
	[CompilerGenerated]
	private static Predicate<GameObject> LBLKOBNMMNL;

	// Token: 0x04002091 RID: 8337
	[CompilerGenerated]
	private static Predicate<GameObject> AKLIPIAOCIA;

	// Token: 0x04002092 RID: 8338
	[CompilerGenerated]
	private static Predicate<GameObject> EINGHFEALEJ;

	// Token: 0x04002093 RID: 8339
	[CompilerGenerated]
	private static Predicate<GameObject> ONMBGDBHKBH;

	// Token: 0x04002094 RID: 8340
	[CompilerGenerated]
	private static Predicate<GameObject> NPFIKAFPOOO;

	// Token: 0x04002095 RID: 8341
	[CompilerGenerated]
	private static Predicate<GameObject> AANIPNEBEAL;

	// Token: 0x04002096 RID: 8342
	[CompilerGenerated]
	private static Predicate<GameObject> NHFDPIFJIKB;

	// Token: 0x04002097 RID: 8343
	[CompilerGenerated]
	private static Predicate<GameObject> OHJMJNOAGMD;

	// Token: 0x04002098 RID: 8344
	[CompilerGenerated]
	private static Predicate<GameObject> LIDCPIMJKNB;

	// Token: 0x04002099 RID: 8345
	[CompilerGenerated]
	private static Predicate<GameObject> OLKKCLAKBDJ;

	// Token: 0x0400209A RID: 8346
	[CompilerGenerated]
	private static Predicate<Vector2> LCIPKAPHIPI;

	// Token: 0x020004EF RID: 1263
	[Serializable]
	public enum Socials
	{
		// Token: 0x0400209C RID: 8348
		Twitch,
		// Token: 0x0400209D RID: 8349
		Discord,
		// Token: 0x0400209E RID: 8350
		VK,
		// Token: 0x0400209F RID: 8351
		Reddit,
		// Token: 0x040020A0 RID: 8352
		BugTracker
	}

	// Token: 0x020004F0 RID: 1264
	[CompilerGenerated]
	private sealed class MIPBPLJOKPD
	{
		// Token: 0x06012770 RID: 75632 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool BDGDIDPDBHG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012771 RID: 75633 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool BJMAIJDIKCN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012772 RID: 75634 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool LJDLIIIPIIJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012773 RID: 75635 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool FDAIFOAGDLA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012774 RID: 75636 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool PIJAOCFAPKC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012775 RID: 75637 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool FCAGEDLBBHD(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012776 RID: 75638 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool BKNHHGBPLGH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012777 RID: 75639 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool JBCHBMKPDAJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012778 RID: 75640 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool JKEDCEOCPJO(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012779 RID: 75641 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool LHHFJBIAHCN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601277A RID: 75642 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool KFNBKFELFLH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601277B RID: 75643 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool LOEAMHGMMPK(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601277C RID: 75644 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool FHIJCPPECHA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601277D RID: 75645 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool AEINPAGJFME(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601277E RID: 75646 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool DKGPCPBNDPK(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601277F RID: 75647 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool BFEABMIFIEE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012780 RID: 75648 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool BMAOCLKPNNC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012781 RID: 75649 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool FMIHBNPKEEO(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012782 RID: 75650 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool MGENGAEDACG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012783 RID: 75651 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool BEBAENEJFLD(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012784 RID: 75652 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool HBJFIOJFBHC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012785 RID: 75653 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool JBAJEMGOPDL(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012786 RID: 75654 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool MEMPOPNAEDN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012787 RID: 75655 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool FFEGPHJKMFK(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012788 RID: 75656 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool DNIMHEKGJHB(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012789 RID: 75657 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool AGJKEBOPIOC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601278A RID: 75658 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool KGKMOLCPDIH(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601278B RID: 75659 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool EFAPFFFGOOA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601278C RID: 75660 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool AEIFJLBBKBP(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601278D RID: 75661 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool OFLDIMDDLHM(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601278E RID: 75662 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool GBKBDKHPLKG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601278F RID: 75663 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool DBFPGFHEGKA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012790 RID: 75664 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool EDGAPOPEIJF(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012791 RID: 75665 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool FHFECFLBHMA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012792 RID: 75666 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool FJDBPPKABJE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012793 RID: 75667 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool OLIGLEMPFOP(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012795 RID: 75669 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool PBCAHKDLFPE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012796 RID: 75670 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool IGFOBPKFCDJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012797 RID: 75671 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool LLNDDFGPOPL(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012798 RID: 75672 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool EKHOOPGPPGE(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x06012799 RID: 75673 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool FIPCLHEKKCA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601279A RID: 75674 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool OFHCGKJFGDI(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601279B RID: 75675 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool PKAPLCFHDOC(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601279C RID: 75676 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool OMBHIBNMFNB(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601279D RID: 75677 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool AGFDCBCBAGI(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601279E RID: 75678 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool AKDOOLPMPMG(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x0601279F RID: 75679 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool LNDGINDKPFA(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x060127A0 RID: 75680 RVA: 0x0066F32D File Offset: 0x0066D52D
		internal bool INHOEMCLAAP(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x != (float)this.BBGBGFFPGDN.width || IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x060127A1 RID: 75681 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool JDELIMPGFDJ(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x060127A2 RID: 75682 RVA: 0x0066F2FB File Offset: 0x0066D4FB
		internal bool EGKGJJGAPMN(Vector2 IACGDFHKCAE)
		{
			return IACGDFHKCAE.x == (float)this.BBGBGFFPGDN.width && IACGDFHKCAE.y == (float)this.BBGBGFFPGDN.height;
		}

		// Token: 0x040020A1 RID: 8353
		internal Resolution BBGBGFFPGDN;
	}
}
