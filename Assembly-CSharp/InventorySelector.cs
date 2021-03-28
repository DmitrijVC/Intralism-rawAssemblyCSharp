using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200047F RID: 1151
public class InventorySelector : Singleton<InventorySelector>
{
	// Token: 0x060107F0 RID: 67568 RVA: 0x0059860C File Offset: 0x0059680C
	public void NBMMJEBNIMJ(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.LNLCGEAFOAB(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x060107F1 RID: 67569 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity BMFIBIOLMIG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x060107F2 RID: 67570 RVA: 0x00598658 File Offset: 0x00596858
	public void OHKFJNOADHN(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("id");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.EHFOJAEOEJM(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x060107F3 RID: 67571 RVA: 0x005986A4 File Offset: 0x005968A4
	public void UpdateInventoryItem(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if (NIMGLEMHIIC.transform.Find("ItemNameText"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameText").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if (NIMGLEMHIIC.transform.Find("ItemsCountText"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("ItemsCountText").GetComponent<Text>().text = "x" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("ItemsCountText").GetComponent<Text>().text = string.Empty;
			}
		}
		if (NIMGLEMHIIC.transform.Find("InfoCanvas"))
		{
			NIMGLEMHIIC.transform.Find("InfoCanvas").transform.Find("InfoText").GetComponent<Text>().text = string.Concat(new string[]
			{
				CIDIAMACINK.item.description,
				"\n\n• ",
				LocalizationService.Instance.GetTextByKey("rarity").ToUpper(),
				":\n",
				LocalizationService.Instance.GetTextByKey(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper()
			});
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if (NIMGLEMHIIC.transform.Find("RarityImage"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("#91CCFF");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1f, 0.84f, 0f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(0.88f, 0.31f, 1f);
				color2 = Color.white;
				break;
			}
		}
		if (NIMGLEMHIIC.transform.Find("ItemNameText"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameText").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("RarityImage").GetComponent<Image>().color = color;
		if (NIMGLEMHIIC.transform.Find("ItemNameBGImage"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameBGImage").GetComponent<Image>().color = color;
		}
		if (NIMGLEMHIIC.transform.Find("ItemNameBGImage").Find("IconImage") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("ItemNameBGImage").Find("IconImage").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	// Token: 0x060107F4 RID: 67572 RVA: 0x005989E0 File Offset: 0x00596BE0
	public void PLPBGOJLPOP(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if (NIMGLEMHIIC.transform.Find("DPADHOR"))
		{
			NIMGLEMHIIC.transform.Find("DPADHOR").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if (NIMGLEMHIIC.transform.Find("_Value10"))
		{
			if (MKFKCBBPDPO > 0)
			{
				NIMGLEMHIIC.transform.Find("FPSToggle").GetComponent<Text>().text = "[PlayerController] " + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("22x1").GetComponent<Text>().text = string.Empty;
			}
		}
		if (NIMGLEMHIIC.transform.Find(" registered."))
		{
			Text component = NIMGLEMHIIC.transform.Find(" PhotonView: ").transform.Find("Crosshair1").GetComponent<Text>();
			string[] array = new string[5];
			array[0] = CIDIAMACINK.item.description;
			array[1] = "Drop_Far";
			array[7] = LocalizationService.Instance.IAAEBJKAHDD("achievements.21.completed.workshop.").ToUpper();
			array[8] = ". Our prefix is ";
			array[8] = LocalizationService.Instance.IAAEBJKAHDD(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if (NIMGLEMHIIC.transform.Find(".completed"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("AddEnvironmentSprite");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1593f, 1760f, 1464f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(776f, 151f, 969f);
				color2 = Color.white;
				break;
			}
		}
		if (NIMGLEMHIIC.transform.Find(" ."))
		{
			NIMGLEMHIIC.transform.Find(". Should be just one?").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("mapid").GetComponent<Image>().color = color;
		if (NIMGLEMHIIC.transform.Find("_Value2"))
		{
			NIMGLEMHIIC.transform.Find(".completedCount").GetComponent<Image>().color = color;
		}
		if (NIMGLEMHIIC.transform.Find("_Params2").Find("Vignette") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("note.3").Find(",").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().HBNGFJBHLBE();
	}

	// Token: 0x060107F5 RID: 67573 RVA: 0x00598D1C File Offset: 0x00596F1C
	public void EKGGLEBHEDF(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if (NIMGLEMHIIC.transform.Find(".mp3"))
		{
			NIMGLEMHIIC.transform.Find("reset").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if (NIMGLEMHIIC.transform.Find("float,1"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("Up").GetComponent<Text>().text = "Current xp: " + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("\\\"").GetComponent<Text>().text = string.Empty;
			}
		}
		if (NIMGLEMHIIC.transform.Find("Dance"))
		{
			Text component = NIMGLEMHIIC.transform.Find("_MatrixColor").transform.Find("_History1Weight").GetComponent<Text>();
			string[] array = new string[3];
			array[0] = CIDIAMACINK.item.description;
			array[0] = "_ScreenResolution";
			array[1] = LocalizationService.Instance.GetTextByKey("_PositionX").ToUpper();
			array[7] = "Set satellite clockwise rotattion speed";
			array[2] = LocalizationService.Instance.GetTextByKey(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if (NIMGLEMHIIC.transform.Find("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits."))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("[Down]");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(98f, 76f, 618f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1831f, 606f, 1599f);
				color2 = Color.white;
				break;
			}
		}
		if (NIMGLEMHIIC.transform.Find("roomDescription"))
		{
			NIMGLEMHIIC.transform.Find("maphash").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("<b>").GetComponent<Image>().color = color;
		if (NIMGLEMHIIC.transform.Find(": "))
		{
			NIMGLEMHIIC.transform.Find("Received event Leave for unknown player ID: {0}").GetComponent<Image>().color = color;
		}
		if (NIMGLEMHIIC.transform.Find("[PlayerBase] Saveing checkpoint data").Find("LevelEditor/patterns") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("_Value").Find("[Left]").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().DKOMMIKCPKH();
	}

	// Token: 0x060107F6 RID: 67574 RVA: 0x00599058 File Offset: 0x00597258
	public void EKMFDOAIHBG(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Received OnSerialization for view ID ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.NBPGIJNAGGM(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x060107F7 RID: 67575 RVA: 0x005990A2 File Offset: 0x005972A2
	public void CFIAJPGBGJM()
	{
		base.StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(this.inventoryCanvas, false, null, true, 1064f, false));
	}

	// Token: 0x060107F8 RID: 67576 RVA: 0x005990C4 File Offset: 0x005972C4
	public void EHFOJAEOEJM(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.HADHEGEJDBA();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 1;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 0);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.BMFIBIOLMIG);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1647f, 1941f, 1178f);
				this.PLPBGOJLPOP(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x060107F9 RID: 67577 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity KNOCOLMCBCL(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x060107FA RID: 67578 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity AMKODNBBBOH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x060107FB RID: 67579 RVA: 0x0054A1C8 File Offset: 0x005483C8
	[CompilerGenerated]
	private static InventoryItemRarity NBEPBOHNGIN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x060107FC RID: 67580 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity GPGGJENLKOP(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x060107FE RID: 67582 RVA: 0x005992A8 File Offset: 0x005974A8
	public IEnumerator DMKLEPBKHOL(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		yield return true;
		yield break;
	}

	// Token: 0x060107FF RID: 67583 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity FJEOKJMAKNK(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010800 RID: 67584 RVA: 0x005992CA File Offset: 0x005974CA
	public void JBNDHCOJKAC()
	{
		base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.inventoryCanvas, true, null, false, 675f, true));
	}

	// Token: 0x06010801 RID: 67585 RVA: 0x005992EC File Offset: 0x005974EC
	public void SwichCategory(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.AddInventoryItemsToList(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x06010802 RID: 67586 RVA: 0x00599336 File Offset: 0x00597536
	public bool IBNDDNMACMG()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010803 RID: 67587 RVA: 0x00599336 File Offset: 0x00597536
	public bool HLCDIDFFMAH()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010804 RID: 67588 RVA: 0x00599336 File Offset: 0x00597536
	public bool NNKMLEEKNPG()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010805 RID: 67589 RVA: 0x00599336 File Offset: 0x00597536
	public bool APBOCCAOMFB()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010806 RID: 67590 RVA: 0x00599344 File Offset: 0x00597544
	private void NHOHGIEKNPO()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().NDIEPHMDEFB(this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
		}
	}

	// Token: 0x06010807 RID: 67591 RVA: 0x005993B8 File Offset: 0x005975B8
	public IEnumerator DisplayInventory(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		yield return true;
		yield break;
	}

	// Token: 0x06010808 RID: 67592 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity MNDJKKCILNG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010809 RID: 67593 RVA: 0x005993DC File Offset: 0x005975DC
	private void BKCDPKBPFHI()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().OEHEAPNGEOC(this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
		}
	}

	// Token: 0x0601080A RID: 67594 RVA: 0x00599450 File Offset: 0x00597650
	public void CloseInventory()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, false, null, true, 0.2f, true));
	}

	// Token: 0x0601080B RID: 67595 RVA: 0x00599474 File Offset: 0x00597674
	public void AEIHANNFEEJ(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if (NIMGLEMHIIC.transform.Find("#loopnumber "))
		{
			NIMGLEMHIIC.transform.Find("LostLive").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if (NIMGLEMHIIC.transform.Find("\r"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find(".highscore").GetComponent<Text>().text = "Tab1Content" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("_Value2").GetComponent<Text>().text = string.Empty;
			}
		}
		if (NIMGLEMHIIC.transform.Find("_Value"))
		{
			Text component = NIMGLEMHIIC.transform.Find("ACCEPT").transform.Find("maps.").GetComponent<Text>();
			string[] array = new string[]
			{
				CIDIAMACINK.item.description
			};
			array[0] = "In Network lobby";
			array[7] = LocalizationService.Instance.IAAEBJKAHDD("_TimeX").ToUpper();
			array[8] = "_Exponent";
			array[4] = LocalizationService.Instance.IAAEBJKAHDD(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if (NIMGLEMHIIC.transform.Find("d264dbba9c2410771b4ad918903b3f4cd9e276a9"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("id");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1703f, 959f, 1455f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(532f, 1112f, 732f);
				color2 = Color.white;
				break;
			}
		}
		if (NIMGLEMHIIC.transform.Find("_Value5"))
		{
			NIMGLEMHIIC.transform.Find(" not exist").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("_TimeX").GetComponent<Image>().color = color;
		if (NIMGLEMHIIC.transform.Find("_TraceBehindObjects"))
		{
			NIMGLEMHIIC.transform.Find("_ScreenResolution").GetComponent<Image>().color = color;
		}
		if (NIMGLEMHIIC.transform.Find("_ScreenResolution").Find("_Speed") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("#combo").Find("settings.crosshairopacity").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().HBNGFJBHLBE();
	}

	// Token: 0x0601080C RID: 67596 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity IBJCMEPGIDL(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0601080D RID: 67597 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity MOLFCMFDBKG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0601080E RID: 67598 RVA: 0x005997B0 File Offset: 0x005979B0
	public IEnumerator LDHIGLOBGLI(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		yield return true;
		yield break;
	}

	// Token: 0x0601080F RID: 67599 RVA: 0x005997D4 File Offset: 0x005979D4
	public void AddInventoryItemsToList(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.CECPMNODBLA();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 1;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 1);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.NBEPBOHNGIN);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
				this.UpdateInventoryItem(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x06010810 RID: 67600 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity HLCIGOKINEF(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010811 RID: 67601 RVA: 0x005999B0 File Offset: 0x00597BB0
	public void LNLCGEAFOAB(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.HFKMIPNOIIC();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 0;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 1);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.BMFIBIOLMIG);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(900f, 518f, 1520f);
				this.UpdateInventoryItem(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x06010812 RID: 67602 RVA: 0x00599B8C File Offset: 0x00597D8C
	public void BMFPKDBBHEB(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.CECPMNODBLA();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 1;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 0);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.MNDJKKCILNG);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1023f, 1448f, 611f);
				this.EKGGLEBHEDF(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x06010813 RID: 67603 RVA: 0x00599336 File Offset: 0x00597536
	public bool IsActive()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010814 RID: 67604 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity IGFEBFDBDEC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010815 RID: 67605 RVA: 0x00599D68 File Offset: 0x00597F68
	public void MNFCMFKIJBB(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.BKCDPKBPFHI();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 0;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 1);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.MCEJDCLMBKN);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1634f, 1597f, 359f);
				this.PLPBGOJLPOP(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x06010816 RID: 67606 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity BPNNPAJLNAK(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010817 RID: 67607 RVA: 0x00599336 File Offset: 0x00597536
	public bool BBJIKLGHBEF()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010818 RID: 67608 RVA: 0x00599F44 File Offset: 0x00598144
	public IEnumerator PNGLEBHHKJK(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		yield return true;
		yield break;
	}

	// Token: 0x06010819 RID: 67609 RVA: 0x00599336 File Offset: 0x00597536
	public bool LCNEDBMABJB()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x0601081A RID: 67610 RVA: 0x00599F68 File Offset: 0x00598168
	private void LMKBMKBKNIB()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().ADMACILOBFL(this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
		}
	}

	// Token: 0x0601081B RID: 67611 RVA: 0x00599FDC File Offset: 0x005981DC
	public void LADBHIOPCDD(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if (NIMGLEMHIIC.transform.Find("BadgeImage"))
		{
			NIMGLEMHIIC.transform.Find("[LevelEditorScene] Creating new item...").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if (NIMGLEMHIIC.transform.Find("MenuScene"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("CameraFilterPack_AAA_BloodOnScreen1").GetComponent<Text>().text = "SetSunMinSize" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("AddEnvironmentSprite").GetComponent<Text>().text = string.Empty;
			}
		}
		if (NIMGLEMHIIC.transform.Find("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): "))
		{
			Text component = NIMGLEMHIIC.transform.Find("STICKRHOR").transform.Find("shader.sunny").GetComponent<Text>();
			string[] array = new string[7];
			array[0] = CIDIAMACINK.item.description;
			array[1] = "Loading maps";
			array[7] = LocalizationService.Instance.IAAEBJKAHDD("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.").ToUpper();
			array[8] = "LastHighScoreText";
			array[3] = LocalizationService.Instance.IAAEBJKAHDD(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if (NIMGLEMHIIC.transform.Find("Error; Only the MasterClient can call RemoveRPCs for other players."))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("maps.");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(529f, 1087f, 871f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1256f, 243f, 1433f);
				color2 = Color.white;
				break;
			}
		}
		if (NIMGLEMHIIC.transform.Find("Set sun colors"))
		{
			NIMGLEMHIIC.transform.Find(".sav").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("Tab1Content").GetComponent<Image>().color = color;
		if (NIMGLEMHIIC.transform.Find("_LoopCount"))
		{
			NIMGLEMHIIC.transform.Find("_Value6").GetComponent<Image>().color = color;
		}
		if (NIMGLEMHIIC.transform.Find("Texture2").Find("curScn") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("#yes").Find("ready").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	// Token: 0x0601081C RID: 67612 RVA: 0x0059A316 File Offset: 0x00598516
	public void BFILDPMMKAH()
	{
		base.StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(this.inventoryCanvas, true, null, false, 875f, true));
	}

	// Token: 0x0601081D RID: 67613 RVA: 0x0059A338 File Offset: 0x00598538
	public IEnumerator KDJBPKJFAKI(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		yield return true;
		yield break;
	}

	// Token: 0x0601081E RID: 67614 RVA: 0x00599336 File Offset: 0x00597536
	public bool GPMPJIDJEGA()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x0601081F RID: 67615 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity MCEJDCLMBKN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010820 RID: 67616 RVA: 0x00599336 File Offset: 0x00597536
	public bool KBPBAIPOAHD()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010821 RID: 67617 RVA: 0x0059A35C File Offset: 0x0059855C
	private void CECPMNODBLA()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().IsSelected = (this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
		}
	}

	// Token: 0x06010822 RID: 67618 RVA: 0x0059A3D0 File Offset: 0x005985D0
	private void HFKMIPNOIIC()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().KGPPEIOBEDJ(this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
		}
	}

	// Token: 0x06010823 RID: 67619 RVA: 0x0059A444 File Offset: 0x00598644
	public void OJAIGJBLCHM(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.BKCDPKBPFHI();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 0;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 1);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.JEPOKOKIOMG);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(130f, 1419f, 1816f);
				this.UpdateInventoryItem(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x06010824 RID: 67620 RVA: 0x00599336 File Offset: 0x00597536
	public bool DJPCFGAANGA()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010825 RID: 67621 RVA: 0x00599336 File Offset: 0x00597536
	public bool POAJCKPLGFG()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010826 RID: 67622 RVA: 0x0059A620 File Offset: 0x00598820
	public void GNEMHKALBKL(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("VisionBlur");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.MNFCMFKIJBB(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x06010827 RID: 67623 RVA: 0x0059A66C File Offset: 0x0059886C
	public void BDIJNGHEMOM(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Colors_BleachBypass");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.EHFOJAEOEJM(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x06010828 RID: 67624 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity KLENGGGBLDC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010829 RID: 67625 RVA: 0x0059A6B6 File Offset: 0x005988B6
	public void DNEJMLKNJAJ()
	{
		base.StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(this.inventoryCanvas, true, null, true, 1464f, false));
	}

	// Token: 0x0601082A RID: 67626 RVA: 0x0059A6D8 File Offset: 0x005988D8
	public void HMLNOCICNKE(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.HADHEGEJDBA();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 1;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 1);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.HLCIGOKINEF);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1777f, 685f, 29f);
				this.PLPBGOJLPOP(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x0601082B RID: 67627 RVA: 0x0059A8B4 File Offset: 0x00598AB4
	public void KPBLAKHBFIF(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Tab2Content");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.LNLCGEAFOAB(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x0601082C RID: 67628 RVA: 0x0059A900 File Offset: 0x00598B00
	private void AGMEGMGIILB()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().JPEBCFFMPIP(this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
		}
	}

	// Token: 0x0601082D RID: 67629 RVA: 0x0059A974 File Offset: 0x00598B74
	public IEnumerator OOKKJAPJCDM(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		yield return true;
		yield break;
	}

	// Token: 0x0601082E RID: 67630 RVA: 0x0059A998 File Offset: 0x00598B98
	public void GEFEKBPNNFJ(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("NEW_ACHIEVEMENT_1_21");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.LNLCGEAFOAB(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x0601082F RID: 67631 RVA: 0x0059A9E4 File Offset: 0x00598BE4
	private void HADHEGEJDBA()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().DOHHIMDGKDL(this.tabs.IndexOf(gameObject) == (int)this.currentCategory);
		}
	}

	// Token: 0x06010830 RID: 67632 RVA: 0x0059AA58 File Offset: 0x00598C58
	public void GFMGGMLOBPN(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Can't find key ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			this.currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		this.BMFPKDBBHEB(this.currentCategory, this.inventoryItemElement, this.inventoryContent);
	}

	// Token: 0x06010831 RID: 67633 RVA: 0x00599336 File Offset: 0x00597536
	public bool OHHLMEOIHGL()
	{
		return this.inventoryCanvas.activeSelf;
	}

	// Token: 0x06010832 RID: 67634 RVA: 0x0059AAA2 File Offset: 0x00598CA2
	public void FGIOJMPAOMI()
	{
		base.StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(this.inventoryCanvas, true, null, true, 659f, false));
	}

	// Token: 0x06010833 RID: 67635 RVA: 0x0059AAC4 File Offset: 0x00598CC4
	public void NBPGIJNAGGM(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		this.CECPMNODBLA();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(steamInventoryItem.item.id))
			{
				Dictionary<string, int> dictionary3;
				string id;
				(dictionary3 = dictionary2)[id = steamInventoryItem.item.id] = dictionary3[id] + 1;
			}
			else
			{
				dictionary.Add(steamInventoryItem.item.id, steamInventoryItem);
				dictionary2.Add(steamInventoryItem.item.id, 0);
			}
		}
		IEnumerable<SteamInventoryItem> values = dictionary.Values;
		if (InventorySelector.LNIJKGECNME == null)
		{
			InventorySelector.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(InventorySelector.FJEOKJMAKNK);
		}
		foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(InventorySelector.LNIJKGECNME))
		{
			if (steamInventoryItem2.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1516f, 560f, 1069f);
				this.EKGGLEBHEDF(gameObject, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
			}
		}
	}

	// Token: 0x06010834 RID: 67636 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity JEPOKOKIOMG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x06010835 RID: 67637 RVA: 0x0059ACA0 File Offset: 0x00598EA0
	public IEnumerator INLAAKKJLGH(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.SwichCategory((int)this.currentCategory);
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.inventoryCanvas, true, null, true, 0.2f, true));
		yield return true;
		yield break;
	}

	// Token: 0x04001CE4 RID: 7396
	public Button buttonBack;

	// Token: 0x04001CE5 RID: 7397
	public GameObject inventoryCanvas;

	// Token: 0x04001CE6 RID: 7398
	public List<GameObject> tabs;

	// Token: 0x04001CE7 RID: 7399
	public GameObject inventoryContent;

	// Token: 0x04001CE8 RID: 7400
	public GameObject inventoryItemElement;

	// Token: 0x04001CE9 RID: 7401
	public InventoryItemType currentCategory;

	// Token: 0x04001CEA RID: 7402
	[CompilerGenerated]
	private static Func<SteamInventoryItem, InventoryItemRarity> LNIJKGECNME;
}
