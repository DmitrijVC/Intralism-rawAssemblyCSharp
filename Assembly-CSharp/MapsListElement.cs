using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004A7 RID: 1191
public class MapsListElement : MonoBehaviour
{
	// Token: 0x060111B0 RID: 70064 RVA: 0x005E3040 File Offset: 0x005E1240
	public void HBDAPJGAMCM()
	{
		string nbebmkfpbep = "_TimeX" + this.details.m_nPublishedFileId.m_PublishedFileId.ToString();
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, false);
	}

	// Token: 0x060111B1 RID: 70065 RVA: 0x005E3080 File Offset: 0x005E1280
	private IEnumerator FNIGCKPFLOL()
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + this.details.m_nPublishedFileId;
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		}
		if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
		{
			fullMapData.mapperSteamID = this.details.m_ulSteamIDOwner;
			GameObject gameObject = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(Singleton<MapsListSelector>.Instance.levelsListElement, fullMapData, parent.gameObject);
			gameObject.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060111B2 RID: 70066 RVA: 0x005E309B File Offset: 0x005E129B
	private void HDKKLFLOHLD(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.id == this.details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= this.HDKKLFLOHLD;
			base.StartCoroutine(this.JAHKCLKDMKG());
		}
	}

	// Token: 0x060111B3 RID: 70067 RVA: 0x005E30DC File Offset: 0x005E12DC
	public void GNJFFKOKLKM()
	{
		string nbebmkfpbep = "EnableRankingToggle" + this.details.m_nPublishedFileId.m_PublishedFileId.ToString();
		Singleton<GameManager>.Instance.KPCCPKIPFGC(nbebmkfpbep, false);
	}

	// Token: 0x060111B4 RID: 70068 RVA: 0x005E311C File Offset: 0x005E131C
	private IEnumerator KIGJJAGAJDP(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.GetComponent<AspectRatioFitter>() && this.bgImage.sprite != null)
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x060111B5 RID: 70069 RVA: 0x005E3140 File Offset: 0x005E1340
	public void MOKHHEMAJBJ(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		this.details = ILPCDMBBCOF;
		this.nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		base.StartCoroutine(this.CNCHAKNHJLF(BPMFPGOPMFA));
		base.StartCoroutine(this.KFEJNLGMENE(CDAGKANOOHO));
		if (base.transform.FindDeepChild("_ScreenResolution"))
		{
			MapsListElement.BGALOIDHPHG bgaloidhphg = new MapsListElement.BGALOIDHPHG();
			base.transform.FindDeepChild(": ").gameObject.SetActive(false);
			bgaloidhphg.CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
			bool flag = RanksSystem.IsOfficial(bgaloidhphg.CAFHKDIIDEE, false);
			if (flag)
			{
				float num = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(bgaloidhphg.LOEAMHGMMPK)).JEKMHHCPHCN();
				if (num > 632f)
				{
					base.transform.FindDeepChild("offsets").gameObject.SetActive(true);
					base.transform.FindDeepChild("PointsScoreText").GetComponentInChildren<Text>().text = string.Empty + num;
				}
			}
		}
	}

	// Token: 0x060111B6 RID: 70070 RVA: 0x005E3260 File Offset: 0x005E1460
	private IEnumerator GFGNAPDIMKP(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num > AAEBFBPJJPK)
		{
			num -= Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
		yield break;
	}

	// Token: 0x060111B7 RID: 70071 RVA: 0x005E3289 File Offset: 0x005E1489
	private void KCPFMKEOBCG(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.BEEMEPJAJCD() == this.details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= this.KCPFMKEOBCG;
			base.StartCoroutine(this.ADHIBPMIFBK());
		}
	}

	// Token: 0x060111B8 RID: 70072 RVA: 0x005E32CC File Offset: 0x005E14CC
	private IEnumerator JAHKCLKDMKG()
	{
		parent = base.transform.parent;
		text = "workshop." + this.details.m_nPublishedFileId;
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		}
		if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
		{
			fullMapData.mapperSteamID = this.details.m_ulSteamIDOwner;
			GameObject gameObject = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(Singleton<MapsListSelector>.Instance.levelsListElement, fullMapData, parent.gameObject);
			gameObject.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060111B9 RID: 70073 RVA: 0x005E32E8 File Offset: 0x005E14E8
	private IEnumerator LFMKJHBDJCE(string BPMFPGOPMFA)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
		yield break;
	}

	// Token: 0x060111BA RID: 70074 RVA: 0x005E330C File Offset: 0x005E150C
	private IEnumerator ELPJEKKPFPI(ulong CDAGKANOOHO)
	{
		string str = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		str = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if (base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + str;
		}
		yield break;
	}

	// Token: 0x060111BB RID: 70075 RVA: 0x005E3330 File Offset: 0x005E1530
	public void Init(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		this.details = ILPCDMBBCOF;
		this.nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		base.StartCoroutine(this.LFMKJHBDJCE(BPMFPGOPMFA));
		base.StartCoroutine(this.KFEJNLGMENE(CDAGKANOOHO));
		if (base.transform.FindDeepChild("DifficultyBG"))
		{
			MapsListElement.BGALOIDHPHG bgaloidhphg = new MapsListElement.BGALOIDHPHG();
			base.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(false);
			bgaloidhphg.CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
			bool flag = RanksSystem.IsOfficial(bgaloidhphg.CAFHKDIIDEE, false);
			if (flag)
			{
				float difficulty = RanksSystem.GetOfficialMapsList().Find(new Predicate<RanksSystem.Map>(bgaloidhphg.GBKBDKHPLKG)).difficulty;
				if (difficulty > 0f)
				{
					base.transform.FindDeepChild("DifficultyBG").gameObject.SetActive(true);
					base.transform.FindDeepChild("DifficultyBG").GetComponentInChildren<Text>().text = string.Empty + difficulty;
				}
			}
		}
	}

	// Token: 0x060111BC RID: 70076 RVA: 0x005E3450 File Offset: 0x005E1650
	private IEnumerator GLPOJOAKOKH(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.GetComponent<AspectRatioFitter>() && this.bgImage.sprite != null)
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x060111BE RID: 70078 RVA: 0x005E3474 File Offset: 0x005E1674
	private void ENNOEOPMNOK()
	{
		ulong num = 0UL;
		ulong num2 = 0UL;
		if (SteamUGC.GetItemDownloadInfo(this.details.m_nPublishedFileId, out num, out num2))
		{
			this.progressSlider.value = num / num2;
		}
	}

	// Token: 0x060111BF RID: 70079 RVA: 0x005E34B4 File Offset: 0x005E16B4
	private IEnumerator ENKNKLNGNEL(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		num = EOGBJKCLGLP.color.a;
		num2 = 0.3f / EHHBHEJBHNG;
		while (num > AAEBFBPJJPK)
		{
			num -= Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
		yield break;
	}

	// Token: 0x060111C0 RID: 70080 RVA: 0x005E34E0 File Offset: 0x005E16E0
	private IEnumerator KFEJNLGMENE(ulong CDAGKANOOHO)
	{
		str = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		str = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if (base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + str;
		}
		yield break;
	}

	// Token: 0x060111C1 RID: 70081 RVA: 0x005E3504 File Offset: 0x005E1704
	private IEnumerator NHEBPKIPHJM(string BPMFPGOPMFA)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
		yield break;
	}

	// Token: 0x060111C2 RID: 70082 RVA: 0x005E3528 File Offset: 0x005E1728
	private IEnumerator MJLPCILAOJH(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		float num = EOGBJKCLGLP.color.a;
		float num2 = 0.3f / EHHBHEJBHNG;
		while (num < AAEBFBPJJPK)
		{
			num += Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
		yield break;
	}

	// Token: 0x060111C3 RID: 70083 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060111C4 RID: 70084 RVA: 0x005E3554 File Offset: 0x005E1754
	private IEnumerator LPJHJFPABAP(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.GetComponent<AspectRatioFitter>() && this.bgImage.sprite != null)
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x060111C5 RID: 70085 RVA: 0x005E3578 File Offset: 0x005E1778
	private IEnumerator FJBCEKBACPJ(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.GetComponent<AspectRatioFitter>() && this.bgImage.sprite != null)
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x060111C6 RID: 70086 RVA: 0x005E359A File Offset: 0x005E179A
	private void ANPNABDOPCJ(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.INGBCJIGOJK() == this.details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= this.ELGIMHFDCJH;
			base.StartCoroutine(this.JAHKCLKDMKG());
		}
	}

	// Token: 0x060111C7 RID: 70087 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnEnable()
	{
	}

	// Token: 0x060111C8 RID: 70088 RVA: 0x005E35DA File Offset: 0x005E17DA
	private void ELGIMHFDCJH(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if (KJPAHOFPCKD.INGBCJIGOJK() == this.details.m_nPublishedFileId.m_PublishedFileId)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= this.HDKKLFLOHLD;
			base.StartCoroutine(this.JAHKCLKDMKG());
		}
	}

	// Token: 0x060111C9 RID: 70089 RVA: 0x005E361A File Offset: 0x005E181A
	private void DLBODOFAJGM()
	{
		base.StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(base.gameObject, false, null, true, 351f, false));
	}

	// Token: 0x060111CA RID: 70090 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060111CB RID: 70091 RVA: 0x005E363C File Offset: 0x005E183C
	public void ToggleLeaderboards()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(1, this.details.m_nPublishedFileId.m_PublishedFileId.ToString(), this.nameText.text, null));
	}

	// Token: 0x060111CC RID: 70092 RVA: 0x005E3678 File Offset: 0x005E1878
	public void OnClickButton()
	{
		this.downloadingPanel.SetActive(true);
		Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += this.HDKKLFLOHLD;
		Singleton<MapsSystem>.Instance.SubscribeAndDownload(this.details.m_nPublishedFileId);
		base.InvokeRepeating("HAOGHCHDNHH", 0f, 0.1f);
	}

	// Token: 0x060111CD RID: 70093 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060111CE RID: 70094 RVA: 0x005E36D4 File Offset: 0x005E18D4
	private IEnumerator LHADGJJCCMD(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		num = EOGBJKCLGLP.color.a;
		num2 = 0.3f / EHHBHEJBHNG;
		while (num < AAEBFBPJJPK)
		{
			num += Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
		yield break;
	}

	// Token: 0x060111CF RID: 70095 RVA: 0x005E3700 File Offset: 0x005E1900
	public void AAKEAJFAMBN()
	{
		string nbebmkfpbep = "_TimeX" + this.details.m_nPublishedFileId.m_PublishedFileId.ToString();
		Singleton<GameManager>.Instance.GIBBJCCHOOJ(nbebmkfpbep, false);
	}

	// Token: 0x060111D0 RID: 70096 RVA: 0x005E3740 File Offset: 0x005E1940
	public void OnInfoButton()
	{
		string nbebmkfpbep = "http://steamcommunity.com/sharedfiles/filedetails/?id=" + this.details.m_nPublishedFileId.m_PublishedFileId.ToString();
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
	}

	// Token: 0x060111D1 RID: 70097 RVA: 0x005E3780 File Offset: 0x005E1980
	private IEnumerator DFMJJLFNBBO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		num = EOGBJKCLGLP.color.a;
		num2 = 0.3f / EHHBHEJBHNG;
		while (num > AAEBFBPJJPK)
		{
			num -= Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
		yield break;
	}

	// Token: 0x060111D2 RID: 70098 RVA: 0x005E37AC File Offset: 0x005E19AC
	private void HAOGHCHDNHH()
	{
		ulong num = 0UL;
		ulong num2 = 0UL;
		if (SteamUGC.GetItemDownloadInfo(this.details.m_nPublishedFileId, out num, out num2))
		{
			this.progressSlider.value = num / num2;
		}
	}

	// Token: 0x060111D3 RID: 70099 RVA: 0x005E37EC File Offset: 0x005E19EC
	private IEnumerator PACBBHGBAPA(ulong CDAGKANOOHO)
	{
		str = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		str = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, false);
		if (base.transform.FindDeepChild("MapperNameText"))
		{
			base.transform.FindDeepChild("MapperNameText").GetComponent<Text>().text = LocalizationService.Instance.GetLocalizatedText("#mapby") + " " + str;
		}
		yield break;
	}

	// Token: 0x060111D4 RID: 70100 RVA: 0x005E3810 File Offset: 0x005E1A10
	private IEnumerator ADHIBPMIFBK()
	{
		parent = base.transform.parent;
		text = "workshop." + this.details.m_nPublishedFileId;
		Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text, false);
		}
		if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
		{
			fullMapData.mapperSteamID = this.details.m_ulSteamIDOwner;
			GameObject gameObject = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(Singleton<MapsListSelector>.Instance.levelsListElement, fullMapData, parent.gameObject);
			gameObject.transform.SetSiblingIndex(base.transform.GetSiblingIndex());
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060111D5 RID: 70101 RVA: 0x005E382C File Offset: 0x005E1A2C
	public void EPDCHKECMBL(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		this.details = ILPCDMBBCOF;
		this.nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		base.StartCoroutine(this.IMJLDAHDMNN(BPMFPGOPMFA));
		base.StartCoroutine(this.ELPJEKKPFPI(CDAGKANOOHO));
		if (base.transform.FindDeepChild("_Value"))
		{
			MapsListElement.BGALOIDHPHG bgaloidhphg = new MapsListElement.BGALOIDHPHG();
			base.transform.FindDeepChild("#obtained").gameObject.SetActive(false);
			bgaloidhphg.CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
			bool flag = RanksSystem.IsOfficial(bgaloidhphg.CAFHKDIIDEE, true);
			if (flag)
			{
				float num = RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(bgaloidhphg.GBKBDKHPLKG)).MBAFCIHCIOM();
				if (num > 791f)
				{
					base.transform.FindDeepChild(">").gameObject.SetActive(false);
					base.transform.FindDeepChild("_TimeX").GetComponentInChildren<Text>().text = string.Empty + num;
				}
			}
		}
	}

	// Token: 0x060111D6 RID: 70102 RVA: 0x005E394C File Offset: 0x005E1B4C
	private IEnumerator IMJLDAHDMNN(string BPMFPGOPMFA)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
		yield break;
	}

	// Token: 0x060111D7 RID: 70103 RVA: 0x005E396E File Offset: 0x005E1B6E
	private void FEHCNJLLJMP()
	{
		base.StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(base.gameObject, true, null, false, 1319f, true));
	}

	// Token: 0x060111D8 RID: 70104 RVA: 0x005E3990 File Offset: 0x005E1B90
	public void EKOAKKNGGGI(SteamUGCDetails_t ILPCDMBBCOF, string BPMFPGOPMFA, string EBEHBBDKDFJ, ulong CDAGKANOOHO)
	{
		this.details = ILPCDMBBCOF;
		this.nameText.text = EBEHBBDKDFJ.Replace(Environment.NewLine, string.Empty);
		base.StartCoroutine(this.NHEBPKIPHJM(BPMFPGOPMFA));
		base.StartCoroutine(this.PACBBHGBAPA(CDAGKANOOHO));
		if (base.transform.FindDeepChild("player.quantum"))
		{
			MapsListElement.BGALOIDHPHG bgaloidhphg = new MapsListElement.BGALOIDHPHG();
			base.transform.FindDeepChild("_Value2").gameObject.SetActive(true);
			bgaloidhphg.CAFHKDIIDEE = ILPCDMBBCOF.m_nPublishedFileId.m_PublishedFileId;
			bool flag = RanksSystem.IsOfficial(bgaloidhphg.CAFHKDIIDEE, true);
			if (flag)
			{
				float num = RanksSystem.HOCEONHMGHM().Find(new Predicate<RanksSystem.Map>(bgaloidhphg.EKHOOPGPPGE)).GDCGLBBAJHN();
				if (num > 1028f)
				{
					base.transform.FindDeepChild("GlassesColor2").gameObject.SetActive(false);
					base.transform.FindDeepChild(". Using max value: 255.").GetComponentInChildren<Text>().text = string.Empty + num;
				}
			}
		}
	}

	// Token: 0x060111D9 RID: 70105 RVA: 0x005E3AB0 File Offset: 0x005E1CB0
	private IEnumerator CNCHAKNHJLF(string BPMFPGOPMFA)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL(BPMFPGOPMFA, BPMFPGOPMFA, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(BPMFPGOPMFA)));
		yield break;
	}

	// Token: 0x060111DA RID: 70106 RVA: 0x005E3AD2 File Offset: 0x005E1CD2
	private void Start()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(base.gameObject, true, null, true, 0.2f, true));
	}

	// Token: 0x060111DB RID: 70107 RVA: 0x005E3AF4 File Offset: 0x005E1CF4
	private IEnumerator ENONILPJLCJ(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
	{
		num = EOGBJKCLGLP.color.a;
		num2 = 0.3f / EHHBHEJBHNG;
		while (num < AAEBFBPJJPK)
		{
			num += Time.deltaTime * num2;
			EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, num);
			yield return new WaitForFixedUpdate();
		}
		yield break;
	}

	// Token: 0x060111DC RID: 70108 RVA: 0x005E3B20 File Offset: 0x005E1D20
	public void NDFGGJDMKIP()
	{
		string nbebmkfpbep = "Scene" + this.details.m_nPublishedFileId.m_PublishedFileId.ToString();
		Singleton<GameManager>.Instance.KPCCPKIPFGC(nbebmkfpbep, false);
	}

	// Token: 0x04001E1C RID: 7708
	public Image bgImage;

	// Token: 0x04001E1D RID: 7709
	public Text nameText;

	// Token: 0x04001E1E RID: 7710
	public GameObject downloadingPanel;

	// Token: 0x04001E1F RID: 7711
	public GameObject ratedUpButton;

	// Token: 0x04001E20 RID: 7712
	public GameObject ratedDownButton;

	// Token: 0x04001E21 RID: 7713
	public GameObject favButton;

	// Token: 0x04001E22 RID: 7714
	public Slider progressSlider;

	// Token: 0x04001E23 RID: 7715
	public SteamUGCDetails_t details;

	// Token: 0x020004A8 RID: 1192
	[CompilerGenerated]
	private sealed class BGALOIDHPHG
	{
		// Token: 0x060111DD RID: 70109 RVA: 0x005E3B5F File Offset: 0x005E1D5F
		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.CAFHKDIIDEE;
		}

		// Token: 0x060111DE RID: 70110 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111DF RID: 70111 RVA: 0x005E3B7F File Offset: 0x005E1D7F
		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E0 RID: 70112 RVA: 0x005E3B5F File Offset: 0x005E1D5F
		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E2 RID: 70114 RVA: 0x005E3B8F File Offset: 0x005E1D8F
		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E3 RID: 70115 RVA: 0x005E3B7F File Offset: 0x005E1D7F
		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E4 RID: 70116 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E5 RID: 70117 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E6 RID: 70118 RVA: 0x005E3B9F File Offset: 0x005E1D9F
		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E7 RID: 70119 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E8 RID: 70120 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111E9 RID: 70121 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111EA RID: 70122 RVA: 0x005E3B9F File Offset: 0x005E1D9F
		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111EB RID: 70123 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111EC RID: 70124 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111ED RID: 70125 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111EE RID: 70126 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111EF RID: 70127 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F0 RID: 70128 RVA: 0x005E3BAF File Offset: 0x005E1DAF
		internal bool HBJFIOJFBHC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F1 RID: 70129 RVA: 0x005E3B7F File Offset: 0x005E1D7F
		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F2 RID: 70130 RVA: 0x005E3BAF File Offset: 0x005E1DAF
		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F3 RID: 70131 RVA: 0x005E3B8F File Offset: 0x005E1D8F
		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F4 RID: 70132 RVA: 0x005E3B8F File Offset: 0x005E1D8F
		internal bool LLNDDFGPOPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F5 RID: 70133 RVA: 0x005E3BBF File Offset: 0x005E1DBF
		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F6 RID: 70134 RVA: 0x005E3BBF File Offset: 0x005E1DBF
		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F7 RID: 70135 RVA: 0x005E3B9F File Offset: 0x005E1D9F
		internal bool FFEGPHJKMFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F8 RID: 70136 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool IGFOBPKFCDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111F9 RID: 70137 RVA: 0x005E3B8F File Offset: 0x005E1D8F
		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111FA RID: 70138 RVA: 0x005E3BBF File Offset: 0x005E1DBF
		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.CAFHKDIIDEE;
		}

		// Token: 0x060111FB RID: 70139 RVA: 0x005E3B6F File Offset: 0x005E1D6F
		internal bool PBCAHKDLFPE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.CAFHKDIIDEE;
		}

		// Token: 0x04001E24 RID: 7716
		internal ulong CAFHKDIIDEE;
	}
}
