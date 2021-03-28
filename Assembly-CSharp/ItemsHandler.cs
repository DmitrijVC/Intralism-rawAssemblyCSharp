using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200042A RID: 1066
public class ItemsHandler : Singleton<ItemsHandler>
{
	// Token: 0x0600F417 RID: 62487 RVA: 0x00549FE3 File Offset: 0x005481E3
	public void LOCFGHOMHMC(string NOJGGCLPPAM)
	{
		if (GameObject.Find("https://steamcommunity.com/sharedfiles/filedetails/?id="))
		{
			GameObject.Find("Fade").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F418 RID: 62488 RVA: 0x0054A013 File Offset: 0x00548213
	private void OCJICMCAPFN()
	{
		if (this.FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(this.FNMADDPJCLB);
			this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	// Token: 0x0600F419 RID: 62489 RVA: 0x0054A040 File Offset: 0x00548240
	public void JFLLKNGBFHJ()
	{
		base.StartCoroutine(this.BOMFGAMNHIE());
	}

	// Token: 0x0600F41A RID: 62490 RVA: 0x0054A050 File Offset: 0x00548250
	public void NOCDKAPEIHD(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		IEnumerable<SteamInventoryItem> source = Singleton<ItemsHandler>.Instance.JAAIGMFHODM();
		if (ItemsHandler.CLCBJCKCBDD == null)
		{
			ItemsHandler.CLCBJCKCBDD = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.EMOMHOFIPEC);
		}
		foreach (SteamInventoryItem cidiamacink in source.OrderBy(ItemsHandler.CLCBJCKCBDD))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(720f, 111f, 907f);
			this.UpdateInventoryItem(gameObject, cidiamacink, 1);
		}
	}

	// Token: 0x0600F41B RID: 62491 RVA: 0x0054A148 File Offset: 0x00548348
	public void ObtainItem(InventoryItemData LEPFOBGKCPJ)
	{
		this.requestType = 2;
		SteamItemDef_t[] array = new SteamItemDef_t[]
		{
			(SteamItemDef_t)this.itemsData.IndexOf(LEPFOBGKCPJ)
		};
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.GenerateItems(out steamInventoryResult_t, array, null, (uint)array.Length);
	}

	// Token: 0x0600F41C RID: 62492 RVA: 0x0054A18D File Offset: 0x0054838D
	public void BEMOILHKFAI()
	{
		base.StartCoroutine(this.PFMJPIJONIP());
	}

	// Token: 0x0600F41D RID: 62493 RVA: 0x0054A19C File Offset: 0x0054839C
	public void CloseNewItems()
	{
		Singleton<SaveSystem>.Instance.Flush();
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, false, null, true, 0.2f, true));
	}

	// Token: 0x0600F41E RID: 62494 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity JEJKAHEBOLM(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F41F RID: 62495 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x0600F420 RID: 62496 RVA: 0x0054A1D8 File Offset: 0x005483D8
	public void LECNHJFEOCM(InventoryItemData LEPFOBGKCPJ)
	{
		this.requestType = 0;
		SteamItemDef_t[] array = new SteamItemDef_t[1];
		array[1] = (SteamItemDef_t)this.itemsData.IndexOf(LEPFOBGKCPJ);
		SteamItemDef_t[] array2 = array;
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.GenerateItems(out steamInventoryResult_t, array2, null, (uint)array2.Length);
	}

	// Token: 0x0600F421 RID: 62497 RVA: 0x0054A220 File Offset: 0x00548420
	public ulong BHFJMFONBOP(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 1UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.IPEDKOMAKPP("_Gain" + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Other)
		{
			if (HMGBJCGOLMI != (InventoryItemType)8)
			{
				if (HMGBJCGOLMI == InventoryItemType.Shader)
				{
					num = 76UL;
				}
			}
			else
			{
				num = 0UL;
			}
		}
		else
		{
			num = 0UL;
		}
		this.JLEENFEIKHB(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F422 RID: 62498 RVA: 0x0054A2AD File Offset: 0x005484AD
	public void GHBCGDFOLCA()
	{
		this.requestType = 1;
		SteamInventory.TriggerItemDrop(out this.FNMADDPJCLB, (SteamItemDef_t)0);
	}

	// Token: 0x0600F423 RID: 62499 RVA: 0x0054A2C8 File Offset: 0x005484C8
	public void ObtainPromoItems()
	{
		base.StartCoroutine(this.IBGBCINGJHE());
	}

	// Token: 0x0600F424 RID: 62500 RVA: 0x0002523B File Offset: 0x0002343B
	public void JONGDMFEAIE(string JMMILEFMACB)
	{
	}

	// Token: 0x0600F425 RID: 62501 RVA: 0x0054A2D8 File Offset: 0x005484D8
	public List<InventoryItemType> GetAllTypes()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		using (List<InventoryItemData>.Enumerator enumerator = this.itemsData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.FNJCOMEGJBM fnjcomegjbm = new ItemsHandler.FNJCOMEGJBM();
				fnjcomegjbm.DBIMJHMKHNK = enumerator.Current;
				if (!list.Exists(new Predicate<InventoryItemType>(fnjcomegjbm.GBKBDKHPLKG)))
				{
					list.Add(fnjcomegjbm.DBIMJHMKHNK.type);
				}
			}
		}
		return list;
	}

	// Token: 0x0600F426 RID: 62502 RVA: 0x0054A368 File Offset: 0x00548568
	public SteamInventoryItem DNPHLBJMMEM(ulong MOANAJGGPLK)
	{
		ItemsHandler.FPDJBMKIHEE fpdjbmkihee = new ItemsHandler.FPDJBMKIHEE();
		fpdjbmkihee.MOANAJGGPLK = MOANAJGGPLK;
		return this.userItems.Find(new Predicate<SteamInventoryItem>(fpdjbmkihee.LHHFJBIAHCN));
	}

	// Token: 0x0600F427 RID: 62503 RVA: 0x0054A39C File Offset: 0x0054859C
	public List<InventoryItemType> AAEKPNLABHA()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		using (List<InventoryItemData>.Enumerator enumerator = this.itemsData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.FNJCOMEGJBM fnjcomegjbm = new ItemsHandler.FNJCOMEGJBM();
				fnjcomegjbm.DBIMJHMKHNK = enumerator.Current;
				if (!list.Exists(new Predicate<InventoryItemType>(fnjcomegjbm.LOEAMHGMMPK)))
				{
					list.Add(fnjcomegjbm.DBIMJHMKHNK.type);
				}
			}
		}
		return list;
	}

	// Token: 0x0600F429 RID: 62505 RVA: 0x0054A4B0 File Offset: 0x005486B0
	private IEnumerator EBIDDHFCBFA()
	{
		while (this.requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.requestType = 2;
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.GrantPromoItems(out steamInventoryResult_t);
		yield break;
	}

	// Token: 0x0600F42A RID: 62506 RVA: 0x0054A4CC File Offset: 0x005486CC
	public void LJCNOBMKMCL(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CameraFilterPack_VHS2", Singleton<ItemsHandler>.Instance.userItems.Count, null);
		this.CheckInventory();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		using (List<InventoryItemType>.Enumerator enumerator = this.POAMFKKEDIO().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.MOCPGDGNNCN mocpgdgnncn = new ItemsHandler.MOCPGDGNNCN();
				mocpgdgnncn.CJEIKDHCCOI = enumerator.Current;
				if (this.userItems.Find(new Predicate<SteamInventoryItem>(mocpgdgnncn.FFEGPHJKMFK)) != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
					gameObject.transform.SetParent(MPNMOONBMII.transform, true);
					gameObject.transform.localScale = new Vector3(969f, 1071f, 1179f);
					if (gameObject.transform.Find("Data/Skins/").Find("#changenote"))
					{
						switch (mocpgdgnncn.CJEIKDHCCOI)
						{
						case InventoryItemType.Other:
							gameObject.transform.Find("PublishButton").Find("Tab1Content").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("menu.resetlevelcheckpoint").ToUpper();
							break;
						case InventoryItemType.Player:
							gameObject.transform.Find("CHROMATIC_ABERRATION").Find("CameraFilterPack/Blend2Camera_HardLight").GetComponent<Text>().text = LocalizationService.Instance.IAAEBJKAHDD("_ScreenResolution").ToUpper();
							break;
						case InventoryItemType.MenuTheme:
							gameObject.transform.Find("SettingsCanvas").Find("PhotonView with ID ").GetComponent<Text>().text = LocalizationService.Instance.IAAEBJKAHDD("Observed type is not serializable: ").ToUpper();
							break;
						default:
							gameObject.transform.Find("88f00bdf0ad61b16b803971ebe071962").Find("_TimeX").GetComponent<Text>().text = LocalizationService.Instance.IAAEBJKAHDD("Drop_Far").ToUpper();
							break;
						}
					}
					GameObject gameObject2 = gameObject.transform.Find("_Value8").Find("0.000").gameObject;
					for (int j = 0; j < gameObject2.transform.childCount; j += 0)
					{
						UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
							dictionary2.Add(steamInventoryItem.item.id, 0);
						}
					}
					IEnumerable<SteamInventoryItem> values = dictionary.Values;
					if (ItemsHandler.LNIJKGECNME == null)
					{
						ItemsHandler.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.NBEPBOHNGIN);
					}
					foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(ItemsHandler.LNIJKGECNME))
					{
						if (steamInventoryItem2.item.type == mocpgdgnncn.CJEIKDHCCOI)
						{
							GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
							gameObject3.transform.SetParent(gameObject2.transform, true);
							gameObject3.transform.localScale = new Vector3(1417f, 222f, 902f);
							this.UpdateInventoryItem(gameObject3, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600F42B RID: 62507 RVA: 0x0054A93C File Offset: 0x00548B3C
	private void AEHBAEIIIHO()
	{
		this.userItems.Add(new SteamInventoryItem(0UL, this.itemsData[1], false));
		this.userItems.Add(new SteamInventoryItem(0UL, this.itemsData[1], false));
		this.userItems.Add(new SteamInventoryItem(32UL, this.itemsData[-76], true));
	}

	// Token: 0x0600F42C RID: 62508 RVA: 0x0054A9A8 File Offset: 0x00548BA8
	public string GCOMOHOCONL(int EEBCDMFNKLH)
	{
		ItemsHandler.IHAFGMJBHMB ihafgmjbhmb = new ItemsHandler.IHAFGMJBHMB();
		ihafgmjbhmb.EEBCDMFNKLH = EEBCDMFNKLH;
		return this.IHIFDJEOGGK.Where(new Func<KeyValuePair<int, string>, bool>(ihafgmjbhmb.BDGDIDPDBHG)).First<KeyValuePair<int, string>>().Value;
	}

	// Token: 0x0600F42D RID: 62509 RVA: 0x0054A9E8 File Offset: 0x00548BE8
	public void POHIPKCFJKI(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		IEnumerable<SteamInventoryItem> onlySteamItemsList = Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList();
		if (ItemsHandler.CLCBJCKCBDD == null)
		{
			ItemsHandler.CLCBJCKCBDD = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.OEEPHCOLBHL);
		}
		foreach (SteamInventoryItem cidiamacink in onlySteamItemsList.OrderBy(ItemsHandler.CLCBJCKCBDD))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(1578f, 1837f, 1160f);
			this.UpdateInventoryItem(gameObject, cidiamacink, 0);
		}
	}

	// Token: 0x0600F42E RID: 62510 RVA: 0x0054AAE0 File Offset: 0x00548CE0
	public InventoryItemData PNBHBEEFDFE(string JMMILEFMACB)
	{
		ItemsHandler.DNBMFMBLMGG dnbmfmblmgg = new ItemsHandler.DNBMFMBLMGG();
		dnbmfmblmgg.JMMILEFMACB = JMMILEFMACB;
		return this.itemsData.Find(new Predicate<InventoryItemData>(dnbmfmblmgg.BDGDIDPDBHG));
	}

	// Token: 0x0600F42F RID: 62511 RVA: 0x0054AB14 File Offset: 0x00548D14
	public void ShowNewItems()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem poonbaijmmc in this.newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(poonbaijmmc));
		}
		base.StartCoroutine(this.JNHEBDPOOCK(list));
		this.newItemsNotifications.Clear();
	}

	// Token: 0x0600F430 RID: 62512 RVA: 0x0054AB94 File Offset: 0x00548D94
	private IEnumerator JNHEBDPOOCK(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		GameObject gameObject = this.newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem cidiamacink in IOMNJBPDLAK)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.inventoryItemElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, cidiamacink, 1);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600F431 RID: 62513 RVA: 0x0054ABB8 File Offset: 0x00548DB8
	public IEnumerator LCKKDMKJJEF()
	{
		this.itemsData.Clear();
		this.isLoaded = false;
		yield return base.StartCoroutine(this.NGGKHGDAALF());
		this.UpdatePlayerInventory();
		yield break;
	}

	// Token: 0x0600F432 RID: 62514 RVA: 0x0054ABD3 File Offset: 0x00548DD3
	public void DNHDANEDLGG()
	{
		base.StartCoroutine(this.BDKOFJJADOM());
	}

	// Token: 0x0600F433 RID: 62515 RVA: 0x0054A013 File Offset: 0x00548213
	private void NPOJCJFOGMB()
	{
		if (this.FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(this.FNMADDPJCLB);
			this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	// Token: 0x0600F434 RID: 62516 RVA: 0x0054ABE4 File Offset: 0x00548DE4
	public ulong BLOGEMGPJFE(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 1UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.IPEDKOMAKPP("_TimeX" + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Other)
		{
			if (HMGBJCGOLMI != InventoryItemType.Player)
			{
				if (HMGBJCGOLMI == (InventoryItemType)5)
				{
					num = 18446744073709551578UL;
				}
			}
			else
			{
				num = 1UL;
			}
		}
		else
		{
			num = 1UL;
		}
		this.EnquipItem(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F435 RID: 62517 RVA: 0x0054AC71 File Offset: 0x00548E71
	public List<string> GetItemsID()
	{
		return this.IHIFDJEOGGK.Values.ToList<string>();
	}

	// Token: 0x0600F436 RID: 62518 RVA: 0x0054AC84 File Offset: 0x00548E84
	private void PCLKGANMJME(SteamInventoryResultReady_t IAFAANLMOAG)
	{
		this.FNMADDPJCLB = IAFAANLMOAG.m_handle;
		if (this.requestType == 0)
		{
			if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == (EResult)0)
			{
				this.requestType = -1;
				uint num = 0U;
				bool resultItems = SteamInventory.GetResultItems(this.FNMADDPJCLB, null, ref num);
				if (resultItems)
				{
					this.userItems.Clear();
					this.NKPKKPEFGMG = new SteamItemDetails_t[num];
					resultItems = SteamInventory.GetResultItems(this.FNMADDPJCLB, this.NKPKKPEFGMG, ref num);
					this.AJDGHDGDLOH();
					Debug.Log(" [" + num + "_SampleDistance");
					List<string> list = new List<string>();
					ItemsHandler.LEMIJMHKLLM lemijmhkllm = new ItemsHandler.LEMIJMHKLLM();
					lemijmhkllm.ADPIKBBAKHP = this;
					lemijmhkllm.EGMPIBBOEMH = 0;
					while ((long)lemijmhkllm.EGMPIBBOEMH < (long)((ulong)num))
					{
						try
						{
							this.userItems.Add(new SteamInventoryItem(this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, this.itemsData.Find(new Predicate<InventoryItemData>(lemijmhkllm.BFEABMIFIEE)), false));
							list.Add(this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("End index must in an integer." + this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_iDefinition);
						}
						lemijmhkllm.EGMPIBBOEMH += 0;
					}
					string text = string.Join("EditMenu", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.FDPKMMIOGOE("#alreadyexist", string.Empty, null))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("/", null)))
						{
							Singleton<SaveSystem>.Instance.DAGHAOBCIFL("GameScene", text, null);
						}
						else
						{
							Debug.Log("settings.crosshairopacity");
							try
							{
								string text2 = Singleton<SaveSystem>.Instance.IPEDKOMAKPP("player.redabstract", null);
								char[] array = new char[0];
								array[1] = 'p';
								List<string> second = text2.Split(array).ToList<string>();
								List<string> list2 = list.Except(second).ToList<string>();
								using (List<string>.Enumerator enumerator = list2.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										ItemsHandler.MOKFDBBHABE mokfdbbhabe = new ItemsHandler.MOKFDBBHABE();
										mokfdbbhabe.JMMILEFMACB = enumerator.Current;
										this.newItemsNotifications.Add(this.userItems.Find(new Predicate<SteamInventoryItem>(mokfdbbhabe.OLIGLEMPFOP)));
									}
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.SetString("#changenote", text, null);
						}
					}
					else
					{
						Debug.Log("_TimeX");
					}
					this.isLoadeding = true;
				}
			}
			else
			{
				Debug.Log("_ScreenResolution" + SteamInventory.GetResultStatus(this.FNMADDPJCLB).ToString());
				this.LOCFGHOMHMC("[Left]");
				this.AEHBAEIIIHO();
				this.isLoadeding = true;
			}
			this.OCJICMCAPFN();
			this.CheckInventory();
			this.isLoaded = false;
		}
		if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == EResult.k_EResultOK && this.requestType == 1)
		{
			this.requestType = -1;
			uint num2 = 1U;
			bool resultItems2 = SteamInventory.GetResultItems(this.FNMADDPJCLB, null, ref num2);
			if (resultItems2 && num2 > 0U)
			{
				this.NKPKKPEFGMG = new SteamItemDetails_t[num2];
				resultItems2 = SteamInventory.GetResultItems(this.FNMADDPJCLB, this.NKPKKPEFGMG, ref num2);
				this.AJDGHDGDLOH();
				this.DCEFGAJKFIL();
			}
		}
		if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == EResult.k_EResultOK && (this.requestType == 6 || this.requestType == 3))
		{
			this.requestType = -1;
			this.DCEFGAJKFIL();
		}
	}

	// Token: 0x0600F437 RID: 62519 RVA: 0x0054B06C File Offset: 0x0054926C
	public ulong KOBNGLOLJHF(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 1UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.ELHODPGACDI("CameraFilterPack/AAA_Blood_Hit" + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Player)
		{
			if (HMGBJCGOLMI != (InventoryItemType)6)
			{
				if (HMGBJCGOLMI == InventoryItemType.Ticket)
				{
					num = 18446744073709551545UL;
				}
			}
			else
			{
				num = 1UL;
			}
		}
		else
		{
			num = 0UL;
		}
		this.JLEENFEIKHB(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F438 RID: 62520 RVA: 0x0054B0FC File Offset: 0x005492FC
	public IEnumerator LEPEFIIFOJB(int GMDAHHDOPDC)
	{
		ItemsHandler.CNPBOHBMMLN.JFKLMBELJLI jfklmbeljli = new ItemsHandler.CNPBOHBMMLN.JFKLMBELJLI();
		jfklmbeljli.KAJEFPDIIJA = this;
		jfklmbeljli.GMDAHHDOPDC = GMDAHHDOPDC;
		WWWForm wwwform = new WWWForm();
		string text = string.Empty + SteamUser.GetSteamID();
		string value = string.Empty + jfklmbeljli.GMDAHHDOPDC;
		wwwform.AddField("steamid", text);
		Debug.Log(text);
		wwwform.AddField("itemdefid[0]", value);
		byte[] data = wwwform.data;
		string url = this.getRewardURL;
		WWW www = new WWW(url, data);
		yield return www;
		if (!www.text.ToUpper().Contains("ERROR") && www.error == null)
		{
			string text2 = www.text;
			WebAPIResponse.ItemJson itemJson = null;
			try
			{
				WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
				webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
				webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
				itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
			}
			catch (Exception)
			{
			}
			if (itemJson != null && itemJson.items.Count > 0)
			{
				yield return new WaitForSeconds(3f);
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			string text3 = www.text;
		}
		else
		{
			Debug.Log(www.text);
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "Unable to get a reward! Try again?";
			string kokbpeccndg = "Yes";
			UnityAction jfpbajlmapc = new UnityAction(jfklmbeljli.GBKBDKHPLKG);
			string nhcjnaeddjl = "No";
			if (ItemsHandler.CNPBOHBMMLN.LNIJKGECNME == null)
			{
				ItemsHandler.CNPBOHBMMLN.LNIJKGECNME = new UnityAction(ItemsHandler.CNPBOHBMMLN.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ItemsHandler.CNPBOHBMMLN.LNIJKGECNME));
		}
		yield break;
	}

	// Token: 0x0600F439 RID: 62521 RVA: 0x0054B11E File Offset: 0x0054931E
	private void NEICGINNAEB(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		this.FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	// Token: 0x0600F43A RID: 62522 RVA: 0x0054B12D File Offset: 0x0054932D
	public void EnquipItem(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.SetString("inventory.selected." + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString(), null);
		Singleton<SaveSystem>.Instance.Flush();
	}

	// Token: 0x0600F43B RID: 62523 RVA: 0x0054B170 File Offset: 0x00549370
	private IEnumerator MAKEPDKIPCG(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		gameObject = this.newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = IOMNJBPDLAK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem cidiamacink = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.inventoryItemElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, cidiamacink, 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600F43C RID: 62524 RVA: 0x0054B192 File Offset: 0x00549392
	public void BHKEFOMJNDF()
	{
		base.StartCoroutine(this.LCKKDMKJJEF());
	}

	// Token: 0x0600F43D RID: 62525 RVA: 0x0054B1A4 File Offset: 0x005493A4
	public List<InventoryItemType> GONAKLKMJGN()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		using (List<InventoryItemData>.Enumerator enumerator = this.itemsData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.FNJCOMEGJBM fnjcomegjbm = new ItemsHandler.FNJCOMEGJBM();
				fnjcomegjbm.DBIMJHMKHNK = enumerator.Current;
				if (!list.Exists(new Predicate<InventoryItemType>(fnjcomegjbm.AEINPAGJFME)))
				{
					list.Add(fnjcomegjbm.DBIMJHMKHNK.type);
				}
			}
		}
		return list;
	}

	// Token: 0x0600F43E RID: 62526 RVA: 0x0002523B File Offset: 0x0002343B
	public void CheckReward(string JMMILEFMACB)
	{
	}

	// Token: 0x0600F43F RID: 62527 RVA: 0x0054B234 File Offset: 0x00549434
	public void PMIOFIMECAL()
	{
		this.requestType = 0;
		SteamInventory.TriggerItemDrop(out this.FNMADDPJCLB, (SteamItemDef_t)1);
	}

	// Token: 0x0600F440 RID: 62528 RVA: 0x0054B250 File Offset: 0x00549450
	public void OIFFBIKCALF()
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("\\" + InventoryItemType.Player.ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.KOMAMFOPJID("wss://" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 1, null);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("a month ago" + ((InventoryItemType)6).ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.LIFMHPJPNEP("_Near" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 1, null);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Submit" + InventoryItemType.Shader.ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA("/" + ((InventoryItemType)6).ToString().ToLower(), string.Empty + 114, null);
		}
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0, null);
		if (!this.IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA(".lastCheckpoint.bgcolor" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0, null);
		}
		s = Singleton<SaveSystem>.Instance.GetString("CameraFilterPack/Drawing_Manga3" + ((InventoryItemType)8).ToString().ToLower(), string.Empty + 0, null);
		if (!this.IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.KOMAMFOPJID("_EmissionColor" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 1, null);
		}
		s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_Value4" + InventoryItemType.Player.ToString().ToLower(), string.Empty + -122, null);
		if (!this.IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA("RecordButton" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 12, null);
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		foreach (InventoryItemData inventoryItemData in this.itemsData)
		{
			if (inventoryItemData.rarity == InventoryItemRarity.Common)
			{
				num += 0;
			}
			if (inventoryItemData.rarity == InventoryItemRarity.Common)
			{
				num2++;
			}
			if (inventoryItemData.rarity == (InventoryItemRarity)6)
			{
				num3 += 0;
			}
		}
		if (num > 1 && num2 > 0 && num3 > 0)
		{
			Helpers.ObtainAchievement(123);
		}
		if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "skin." && UnityEngine.Object.FindObjectOfType<CraftingPanel>())
		{
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().EPDCHKECMBL();
		}
	}

	// Token: 0x0600F441 RID: 62529 RVA: 0x0054B60C File Offset: 0x0054980C
	public void ODADIAEDJFD()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem poonbaijmmc in this.newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(poonbaijmmc));
		}
		base.StartCoroutine(this.OHPLMOPKKHM(list));
		this.newItemsNotifications.Clear();
	}

	// Token: 0x0600F442 RID: 62530 RVA: 0x0054B68C File Offset: 0x0054988C
	public SteamInventoryItem GJHAJNLENFB(ulong MOANAJGGPLK)
	{
		ItemsHandler.FPDJBMKIHEE fpdjbmkihee = new ItemsHandler.FPDJBMKIHEE();
		fpdjbmkihee.MOANAJGGPLK = MOANAJGGPLK;
		return this.userItems.Find(new Predicate<SteamInventoryItem>(fpdjbmkihee.BMAOCLKPNNC));
	}

	// Token: 0x0600F443 RID: 62531 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity ODPJPMFOKGH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F444 RID: 62532 RVA: 0x0054B6C0 File Offset: 0x005498C0
	public void UpdatePlayerInventory()
	{
		Debug.Log("[ItemsHandler] Loading Steam inventory");
		this.isLoadeding = true;
		try
		{
			this.requestType = 0;
			SteamInventory.GetAllItems(out this.FNMADDPJCLB);
		}
		catch (Exception)
		{
			this.AJDGHDGDLOH();
			this.isLoaded = true;
		}
	}

	// Token: 0x0600F445 RID: 62533 RVA: 0x0054B71C File Offset: 0x0054991C
	public SteamInventoryItem HALDCNOECLE(ulong MOANAJGGPLK)
	{
		ItemsHandler.FPDJBMKIHEE fpdjbmkihee = new ItemsHandler.FPDJBMKIHEE();
		fpdjbmkihee.MOANAJGGPLK = MOANAJGGPLK;
		return this.userItems.Find(new Predicate<SteamInventoryItem>(fpdjbmkihee.FFEGPHJKMFK));
	}

	// Token: 0x0600F446 RID: 62534 RVA: 0x0054B750 File Offset: 0x00549950
	public void HKCNEHGFPEA(ulong MOANAJGGPLK)
	{
		this.requestType = 7;
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.ConsumeItem(out steamInventoryResult_t, (SteamItemInstanceID_t)MOANAJGGPLK, 1U);
	}

	// Token: 0x0600F447 RID: 62535 RVA: 0x0054B774 File Offset: 0x00549974
	public List<SteamInventoryItem> MLABKIDDFAN()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!steamInventoryItem.isLocal)
			{
				list.Add(steamInventoryItem);
			}
		}
		return list;
	}

	// Token: 0x0600F448 RID: 62536 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x0600F449 RID: 62537 RVA: 0x0054B7E8 File Offset: 0x005499E8
	public void CKJOBJOHFHK()
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("DPADHOR" + InventoryItemType.Other.ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.LIFMHPJPNEP("[MapEditor] Item creation successful! Published Item ID: " + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0, null);
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("13" + ((InventoryItemType)5).ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA("_EmissionGain" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 0, null);
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms" + ((InventoryItemType)5).ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.KOMAMFOPJID("menutheme" + ((InventoryItemType)8).ToString().ToLower(), string.Empty + -13, null);
		}
		string s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("#ok" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0, null);
		if (!this.IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.SetString("_Axis" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0, null);
		}
		s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("CameraFilterPack/Blend2Camera_ColorDodge" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0, null);
		if (!this.IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.DAGHAOBCIFL("_ScreenResolution" + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1, null);
		}
		s = Singleton<SaveSystem>.Instance.GetString("_TimeX" + InventoryItemType.Ticket.ToString().ToLower(), string.Empty + -1, null);
		if (!this.IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.LIFMHPJPNEP("CameraFilterPack/Noise_TV" + InventoryItemType.Ticket.ToString().ToLower(), string.Empty + -111, null);
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		foreach (InventoryItemData inventoryItemData in this.itemsData)
		{
			if (inventoryItemData.rarity == InventoryItemRarity.Common)
			{
				num++;
			}
			if (inventoryItemData.rarity == InventoryItemRarity.Rare)
			{
				num2 += 0;
			}
			if (inventoryItemData.rarity == InventoryItemRarity.Rare)
			{
				num3++;
			}
		}
		if (num > 1 && num2 > 0 && num3 > 1)
		{
			Helpers.ObtainAchievement(-95);
		}
		if (Singleton<Scene>.Instance.IKPGAGMDCLP() == "Parent ID" && UnityEngine.Object.FindObjectOfType<CraftingPanel>())
		{
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().Init();
		}
	}

	// Token: 0x0600F44A RID: 62538 RVA: 0x0054BBA4 File Offset: 0x00549DA4
	public void HNNKIOHCDKG()
	{
		this.GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(new Callback<SteamInventoryResultReady_t>.DispatchDelegate(this.PCLKGANMJME));
		this.EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(new Callback<SteamInventoryFullUpdate_t>.DispatchDelegate(this.NEICGINNAEB));
		this.EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(new Callback<SteamInventoryDefinitionUpdate_t>.DispatchDelegate(this.KOPILLBIJKL));
		this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		this.NKPKKPEFGMG = null;
	}

	// Token: 0x0600F44B RID: 62539 RVA: 0x0054AC71 File Offset: 0x00548E71
	public List<string> OFCDOHFMFAA()
	{
		return this.IHIFDJEOGGK.Values.ToList<string>();
	}

	// Token: 0x0600F44C RID: 62540 RVA: 0x0054BC08 File Offset: 0x00549E08
	public IEnumerator TryGetReward(int GMDAHHDOPDC)
	{
		jfklmbeljli = new ItemsHandler.CNPBOHBMMLN.JFKLMBELJLI();
		jfklmbeljli.KAJEFPDIIJA = this;
		jfklmbeljli.GMDAHHDOPDC = GMDAHHDOPDC;
		wwwform = new WWWForm();
		text = string.Empty + SteamUser.GetSteamID();
		value = string.Empty + jfklmbeljli.GMDAHHDOPDC;
		wwwform.AddField("steamid", text);
		Debug.Log(text);
		wwwform.AddField("itemdefid[0]", value);
		data = wwwform.data;
		url = this.getRewardURL;
		www = new WWW(url, data);
		yield return www;
		if (!www.text.ToUpper().Contains("ERROR") && www.error == null)
		{
			text2 = www.text;
			itemJson = null;
			try
			{
				WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(www.text);
				webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
				webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
				itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
			}
			catch (Exception)
			{
			}
			if (itemJson != null && itemJson.items.Count > 0)
			{
				yield return new WaitForSeconds(3f);
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			text3 = www.text;
		}
		else
		{
			Debug.Log(www.text);
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "Unable to get a reward! Try again?";
			string kokbpeccndg = "Yes";
			UnityAction jfpbajlmapc = new UnityAction(jfklmbeljli.GBKBDKHPLKG);
			string nhcjnaeddjl = "No";
			if (ItemsHandler.CNPBOHBMMLN.LNIJKGECNME == null)
			{
				ItemsHandler.CNPBOHBMMLN.LNIJKGECNME = new UnityAction(ItemsHandler.CNPBOHBMMLN.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ItemsHandler.CNPBOHBMMLN.LNIJKGECNME));
		}
		yield break;
	}

	// Token: 0x0600F44D RID: 62541 RVA: 0x0054A013 File Offset: 0x00548213
	private void PALFFMFLILA()
	{
		if (this.FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(this.FNMADDPJCLB);
			this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	// Token: 0x0600F44E RID: 62542 RVA: 0x0054BC2C File Offset: 0x00549E2C
	private IEnumerator HLBNCILJPGC()
	{
		while (this.requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.requestType = 2;
		SteamInventory.GrantPromoItems(out steamInventoryResult_t);
		yield break;
	}

	// Token: 0x0600F44F RID: 62543 RVA: 0x0054BC48 File Offset: 0x00549E48
	public void KFCCKOBOLAH()
	{
		this.GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(new Callback<SteamInventoryResultReady_t>.DispatchDelegate(this.PCLKGANMJME));
		this.EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(new Callback<SteamInventoryFullUpdate_t>.DispatchDelegate(this.PLBAKPAONCD));
		this.EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(new Callback<SteamInventoryDefinitionUpdate_t>.DispatchDelegate(this.KHNLPKIDBDE));
		this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		this.NKPKKPEFGMG = null;
	}

	// Token: 0x0600F450 RID: 62544 RVA: 0x0054BCAC File Offset: 0x00549EAC
	public void JGJCJMPFOAC(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP("_Near" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString(), null);
		Singleton<SaveSystem>.Instance.MMMIEPDLMNM();
	}

	// Token: 0x0600F451 RID: 62545 RVA: 0x0054BCEC File Offset: 0x00549EEC
	private IEnumerator OHGBJBGNDJN(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		gameObject = this.newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = IOMNJBPDLAK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem cidiamacink = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.inventoryItemElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, cidiamacink, 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600F452 RID: 62546 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600F453 RID: 62547 RVA: 0x0054BD10 File Offset: 0x00549F10
	public List<InventoryItemType> FLBOGIPNOGG()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		using (List<InventoryItemData>.Enumerator enumerator = this.itemsData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.FNJCOMEGJBM fnjcomegjbm = new ItemsHandler.FNJCOMEGJBM();
				fnjcomegjbm.DBIMJHMKHNK = enumerator.Current;
				if (!list.Exists(new Predicate<InventoryItemType>(fnjcomegjbm.DBFPGFHEGKA)))
				{
					list.Add(fnjcomegjbm.DBIMJHMKHNK.type);
				}
			}
		}
		return list;
	}

	// Token: 0x0600F454 RID: 62548 RVA: 0x0054BDA0 File Offset: 0x00549FA0
	public void DCEFGAJKFIL()
	{
		Debug.Log("PhotonMono");
		this.isLoadeding = true;
		try
		{
			this.requestType = 0;
			SteamInventory.GetAllItems(out this.FNMADDPJCLB);
		}
		catch (Exception)
		{
			this.AJDGHDGDLOH();
			this.isLoaded = false;
		}
	}

	// Token: 0x0600F455 RID: 62549 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600F456 RID: 62550 RVA: 0x0054BDFC File Offset: 0x00549FFC
	public int GetInventoryChanges()
	{
		return this.userItems.Count - Singleton<SaveSystem>.Instance.GetInt("inventory.lastitemscount", 0, null);
	}

	// Token: 0x0600F457 RID: 62551 RVA: 0x0054BE1C File Offset: 0x0054A01C
	public bool IsItemInInventory(ulong MOANAJGGPLK)
	{
		foreach (SteamInventoryItem steamInventoryItem in this.userItems)
		{
			if (steamInventoryItem.steamid == MOANAJGGPLK)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F458 RID: 62552 RVA: 0x0054BE88 File Offset: 0x0054A088
	public ulong FKJFGDPFDPK(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 0UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.GetString("_EmissionColor" + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Player)
		{
			if (HMGBJCGOLMI != (InventoryItemType)6)
			{
				if (HMGBJCGOLMI == InventoryItemType.MenuTheme)
				{
					num = 42UL;
				}
			}
			else
			{
				num = 1UL;
			}
		}
		else
		{
			num = 1UL;
		}
		this.EnquipItem(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F459 RID: 62553 RVA: 0x0054BF18 File Offset: 0x0054A118
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
		Color white = Color.white;
		Color color = Color.black;
		if (NIMGLEMHIIC.transform.Find("RarityImage"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				white = Color.white;
				color = Color.black;
				break;
			case InventoryItemRarity.Rare:
				white = new Color(0.57f, 0.8f, 1f);
				color = Color.white;
				break;
			case InventoryItemRarity.Epic:
				white = new Color(1f, 0.84f, 0f);
				color = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				white = new Color(0.88f, 0.31f, 1f);
				color = Color.white;
				break;
			}
		}
		if (NIMGLEMHIIC.transform.Find("ItemNameText"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameText").GetComponent<Text>().color = color;
		}
		NIMGLEMHIIC.transform.Find("RarityImage").GetComponent<Image>().color = white;
		if (NIMGLEMHIIC.transform.Find("ItemNameBGImage"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameBGImage").GetComponent<Image>().color = white;
		}
		if (NIMGLEMHIIC.transform.Find("IconImage") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("IconImage").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		if (Singleton<SaveSystem>.Instance.GetString("inventory.selected." + CIDIAMACINK.item.type.ToString().ToLower(), string.Empty, null) == CIDIAMACINK.item.id)
		{
			NIMGLEMHIIC.GetComponent<InventoryListElementButton>().isSelected = true;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	// Token: 0x0600F45A RID: 62554 RVA: 0x0054C2A0 File Offset: 0x0054A4A0
	public void MLEAHDDGEMJ()
	{
		this.GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(new Callback<SteamInventoryResultReady_t>.DispatchDelegate(this.MJBCIEHJBKE));
		this.EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(new Callback<SteamInventoryFullUpdate_t>.DispatchDelegate(this.NEICGINNAEB));
		this.EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(new Callback<SteamInventoryDefinitionUpdate_t>.DispatchDelegate(this.KHNLPKIDBDE));
		this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		this.NKPKKPEFGMG = null;
	}

	// Token: 0x0600F45B RID: 62555 RVA: 0x0054C304 File Offset: 0x0054A504
	public IEnumerator BOMFGAMNHIE()
	{
		this.itemsData.Clear();
		this.isLoaded = false;
		yield return base.StartCoroutine(this.NGGKHGDAALF());
		this.UpdatePlayerInventory();
		yield break;
	}

	// Token: 0x0600F45D RID: 62557 RVA: 0x0054C6DC File Offset: 0x0054A8DC
	public void AddInventoryItemsToList(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.SetInt("inventory.lastitemscount", Singleton<ItemsHandler>.Instance.userItems.Count, null);
		this.CheckInventory();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		using (List<InventoryItemType>.Enumerator enumerator = this.GetAllTypes().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.MOCPGDGNNCN mocpgdgnncn = new ItemsHandler.MOCPGDGNNCN();
				mocpgdgnncn.CJEIKDHCCOI = enumerator.Current;
				if (this.userItems.Find(new Predicate<SteamInventoryItem>(mocpgdgnncn.GBKBDKHPLKG)) != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
					gameObject.transform.SetParent(MPNMOONBMII.transform, true);
					gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
					if (gameObject.transform.Find("Image").Find("GroupNameText"))
					{
						switch (mocpgdgnncn.CJEIKDHCCOI)
						{
						case InventoryItemType.Player:
							gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("skins").ToUpper();
							break;
						case InventoryItemType.MenuTheme:
							gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("menuthemes").ToUpper();
							break;
						case InventoryItemType.Shader:
							gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("shaders").ToUpper();
							break;
						default:
							gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("other").ToUpper();
							break;
						}
					}
					GameObject gameObject2 = gameObject.transform.Find("InventoryGrid").Find("InventoryContent").gameObject;
					for (int j = 0; j < gameObject2.transform.childCount; j++)
					{
						UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
					if (ItemsHandler.LNIJKGECNME == null)
					{
						ItemsHandler.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.NBEPBOHNGIN);
					}
					foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(ItemsHandler.LNIJKGECNME))
					{
						if (steamInventoryItem2.item.type == mocpgdgnncn.CJEIKDHCCOI)
						{
							GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
							gameObject3.transform.SetParent(gameObject2.transform, true);
							gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
							this.UpdateInventoryItem(gameObject3, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600F45E RID: 62558 RVA: 0x0054CB4C File Offset: 0x0054AD4C
	private void MMAGOONHNKM(SteamInventoryResultReady_t IAFAANLMOAG)
	{
		this.FNMADDPJCLB = IAFAANLMOAG.m_handle;
		if (this.requestType == 0)
		{
			if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == EResult.k_EResultOK)
			{
				this.requestType = -1;
				uint num = 0U;
				bool resultItems = SteamInventory.GetResultItems(this.FNMADDPJCLB, null, ref num);
				if (resultItems)
				{
					this.userItems.Clear();
					this.NKPKKPEFGMG = new SteamItemDetails_t[num];
					resultItems = SteamInventory.GetResultItems(this.FNMADDPJCLB, this.NKPKKPEFGMG, ref num);
					this.AJDGHDGDLOH();
					Debug.Log("[ItemsHandler] Found " + num + " item(s) in inventory");
					List<string> list = new List<string>();
					ItemsHandler.LEMIJMHKLLM lemijmhkllm = new ItemsHandler.LEMIJMHKLLM();
					lemijmhkllm.ADPIKBBAKHP = this;
					lemijmhkllm.EGMPIBBOEMH = 0;
					while ((long)lemijmhkllm.EGMPIBBOEMH < (long)((ulong)num))
					{
						try
						{
							this.userItems.Add(new SteamInventoryItem(this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, this.itemsData.Find(new Predicate<InventoryItemData>(lemijmhkllm.GBKBDKHPLKG)), false));
							list.Add(this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("[ItemsHandler] Item not found:" + this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_iDefinition);
						}
						lemijmhkllm.EGMPIBBOEMH++;
					}
					string text = string.Join("|", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.GetString("inventory.itemscash", string.Empty, null))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("inventory.itemscash", null)))
						{
							Singleton<SaveSystem>.Instance.SetString("inventory.itemscash", text, null);
						}
						else
						{
							Debug.Log("[ItemsHandler] Inventory has changed");
							try
							{
								List<string> second = Singleton<SaveSystem>.Instance.GetString("inventory.itemscash", null).Split(new char[]
								{
									'|'
								}).ToList<string>();
								List<string> list2 = list.Except(second).ToList<string>();
								using (List<string>.Enumerator enumerator = list2.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										ItemsHandler.MOKFDBBHABE mokfdbbhabe = new ItemsHandler.MOKFDBBHABE();
										mokfdbbhabe.JMMILEFMACB = enumerator.Current;
										this.newItemsNotifications.Add(this.userItems.Find(new Predicate<SteamInventoryItem>(mokfdbbhabe.GBKBDKHPLKG)));
									}
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.SetString("inventory.itemscash", text, null);
						}
					}
					else
					{
						Debug.Log("[ItemsHandler] Inventory not changed");
					}
					this.isLoadeding = false;
				}
			}
			else
			{
				Debug.Log("[ItemsHandler] No connection to item server: " + SteamInventory.GetResultStatus(this.FNMADDPJCLB).ToString());
				this.UpdateLoadingInfo("No connection to item server!");
				this.AJDGHDGDLOH();
				this.isLoadeding = false;
			}
			this.OCJICMCAPFN();
			this.CheckInventory();
			this.isLoaded = true;
		}
		if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == EResult.k_EResultOK && this.requestType == 1)
		{
			this.requestType = -1;
			uint num2 = 0U;
			bool resultItems2 = SteamInventory.GetResultItems(this.FNMADDPJCLB, null, ref num2);
			if (resultItems2 && num2 > 0U)
			{
				this.NKPKKPEFGMG = new SteamItemDetails_t[num2];
				resultItems2 = SteamInventory.GetResultItems(this.FNMADDPJCLB, this.NKPKKPEFGMG, ref num2);
				this.AJDGHDGDLOH();
				this.UpdatePlayerInventory();
			}
		}
		if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == EResult.k_EResultOK && (this.requestType == 2 || this.requestType == 3))
		{
			this.requestType = -1;
			this.UpdatePlayerInventory();
		}
	}

	// Token: 0x0600F45F RID: 62559 RVA: 0x0054CF34 File Offset: 0x0054B134
	public List<InventoryItemType> DAKBIHKDOJD()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		using (List<InventoryItemData>.Enumerator enumerator = this.itemsData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.FNJCOMEGJBM fnjcomegjbm = new ItemsHandler.FNJCOMEGJBM();
				fnjcomegjbm.DBIMJHMKHNK = enumerator.Current;
				if (!list.Exists(new Predicate<InventoryItemType>(fnjcomegjbm.FIPCLHEKKCA)))
				{
					list.Add(fnjcomegjbm.DBIMJHMKHNK.type);
				}
			}
		}
		return list;
	}

	// Token: 0x0600F460 RID: 62560 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity OOIMMPGCANH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F461 RID: 62561 RVA: 0x0054CFC4 File Offset: 0x0054B1C4
	public void ILDHCNCFOCN(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("[MapsStats] Max score: ", Singleton<ItemsHandler>.Instance.userItems.Count, null);
		this.CheckInventory();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		using (List<InventoryItemType>.Enumerator enumerator = this.DAKBIHKDOJD().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.MOCPGDGNNCN mocpgdgnncn = new ItemsHandler.MOCPGDGNNCN();
				mocpgdgnncn.CJEIKDHCCOI = enumerator.Current;
				if (this.userItems.Find(new Predicate<SteamInventoryItem>(mocpgdgnncn.JKEDCEOCPJO)) != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
					gameObject.transform.SetParent(MPNMOONBMII.transform, true);
					gameObject.transform.localScale = new Vector3(606f, 156f, 1636f);
					if (gameObject.transform.Find("_ScreenResolution").Find("player.xp"))
					{
						switch (mocpgdgnncn.CJEIKDHCCOI)
						{
						case InventoryItemType.Player:
							gameObject.transform.Find("UseFinalGlassColor").Find("[NetworkManager] Exited").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("_FixDistance").ToUpper();
							break;
						case InventoryItemType.MenuTheme:
							gameObject.transform.Find("Reset").Find("_Value2").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("player.playedtutorial").ToUpper();
							break;
						case InventoryItemType.Shader:
							gameObject.transform.Find("[EditorEvent] Exception: ").Find("_MainTex2").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("SetSunInput").ToUpper();
							break;
						default:
							gameObject.transform.Find("input").Find("threshold").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey(").").ToUpper();
							break;
						}
					}
					GameObject gameObject2 = gameObject.transform.Find("CameraFilterPack/BlurTiltShift_V").Find("restrictions\n\n#until: ").gameObject;
					for (int j = 0; j < gameObject2.transform.childCount; j++)
					{
						UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
					if (ItemsHandler.LNIJKGECNME == null)
					{
						ItemsHandler.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.JOFIMKHOPPH);
					}
					foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(ItemsHandler.LNIJKGECNME))
					{
						if (steamInventoryItem2.item.type == mocpgdgnncn.CJEIKDHCCOI)
						{
							GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
							gameObject3.transform.SetParent(gameObject2.transform, true);
							gameObject3.transform.localScale = new Vector3(678f, 1011f, 1761f);
							this.UpdateInventoryItem(gameObject3, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600F462 RID: 62562 RVA: 0x0054A1C8 File Offset: 0x005483C8
	[CompilerGenerated]
	private static InventoryItemRarity NBEPBOHNGIN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F463 RID: 62563 RVA: 0x0002523B File Offset: 0x0002343B
	private void KOPILLBIJKL(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F464 RID: 62564 RVA: 0x0054B234 File Offset: 0x00549434
	public void JNHJLMADBIC()
	{
		this.requestType = 0;
		SteamInventory.TriggerItemDrop(out this.FNMADDPJCLB, (SteamItemDef_t)1);
	}

	// Token: 0x0600F465 RID: 62565 RVA: 0x0054D434 File Offset: 0x0054B634
	public void HJHEIBHBHKC(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		IEnumerable<SteamInventoryItem> source = Singleton<ItemsHandler>.Instance.LHKFIGPJKLK();
		if (ItemsHandler.CLCBJCKCBDD == null)
		{
			ItemsHandler.CLCBJCKCBDD = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.EMOMHOFIPEC);
		}
		foreach (SteamInventoryItem cidiamacink in source.OrderBy(ItemsHandler.CLCBJCKCBDD))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(396f, 511f, 219f);
			this.UpdateInventoryItem(gameObject, cidiamacink, 0);
		}
	}

	// Token: 0x0600F466 RID: 62566 RVA: 0x0054D52C File Offset: 0x0054B72C
	private void OKDMOICNHDL()
	{
		this.userItems.Add(new SteamInventoryItem(1UL, this.itemsData[1], false));
		this.userItems.Add(new SteamInventoryItem(1UL, this.itemsData[0], true));
		this.userItems.Add(new SteamInventoryItem(18446744073709551600UL, this.itemsData[76], false));
	}

	// Token: 0x0600F467 RID: 62567 RVA: 0x0054D598 File Offset: 0x0054B798
	public void PNLKAPJJGLP()
	{
		base.StartCoroutine(this.LHAENMGOBMM());
	}

	// Token: 0x0600F468 RID: 62568 RVA: 0x0054D5A8 File Offset: 0x0054B7A8
	public void EJNKBOLGHJC()
	{
		this.GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(new Callback<SteamInventoryResultReady_t>.DispatchDelegate(this.MMAGOONHNKM));
		this.EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(new Callback<SteamInventoryFullUpdate_t>.DispatchDelegate(this.NEICGINNAEB));
		this.EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(new Callback<SteamInventoryDefinitionUpdate_t>.DispatchDelegate(this.KOPILLBIJKL));
		this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		this.NKPKKPEFGMG = null;
	}

	// Token: 0x0600F469 RID: 62569 RVA: 0x0002523B File Offset: 0x0002343B
	private void KHNLPKIDBDE(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F46A RID: 62570 RVA: 0x0054D60C File Offset: 0x0054B80C
	public int ILKOEKNMAPF()
	{
		return this.userItems.Count - Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("...", 0, null);
	}

	// Token: 0x0600F46B RID: 62571 RVA: 0x0002523B File Offset: 0x0002343B
	public void MIJENMHFKIM(string JMMILEFMACB)
	{
	}

	// Token: 0x0600F46C RID: 62572 RVA: 0x0054D62C File Offset: 0x0054B82C
	private void AJDGHDGDLOH()
	{
		this.userItems.Add(new SteamInventoryItem(0UL, this.itemsData[0], true));
		this.userItems.Add(new SteamInventoryItem(1UL, this.itemsData[1], true));
		this.userItems.Add(new SteamInventoryItem(17UL, this.itemsData[17], true));
	}

	// Token: 0x0600F46D RID: 62573 RVA: 0x0054D698 File Offset: 0x0054B898
	private IEnumerator OHKIFHJHGKA(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		gameObject = this.newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = IOMNJBPDLAK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem cidiamacink = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.inventoryItemElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, cidiamacink, 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600F46E RID: 62574 RVA: 0x0054D6BC File Offset: 0x0054B8BC
	public IEnumerator LHAENMGOBMM()
	{
		this.itemsData.Clear();
		this.isLoaded = false;
		yield return base.StartCoroutine(this.NGGKHGDAALF());
		this.UpdatePlayerInventory();
		yield break;
	}

	// Token: 0x0600F46F RID: 62575 RVA: 0x0054D6D8 File Offset: 0x0054B8D8
	public string EAADCFPMIFB(int EEBCDMFNKLH)
	{
		ItemsHandler.IHAFGMJBHMB ihafgmjbhmb = new ItemsHandler.IHAFGMJBHMB();
		ihafgmjbhmb.EEBCDMFNKLH = EEBCDMFNKLH;
		return this.IHIFDJEOGGK.Where(new Func<KeyValuePair<int, string>, bool>(ihafgmjbhmb.JKEDCEOCPJO)).First<KeyValuePair<int, string>>().Value;
	}

	// Token: 0x0600F470 RID: 62576 RVA: 0x0054D716 File Offset: 0x0054B916
	public void OHKKPHDGKAH(string NOJGGCLPPAM)
	{
		if (GameObject.Find("CameraFilterPack/TV_Video3D"))
		{
			GameObject.Find("CameraFilterPack_RainFX_Anm").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F471 RID: 62577 RVA: 0x0054D748 File Offset: 0x0054B948
	private IEnumerator IBGBCINGJHE()
	{
		while (this.requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.requestType = 2;
		SteamInventory.GrantPromoItems(out steamInventoryResult_t);
		yield break;
	}

	// Token: 0x0600F472 RID: 62578 RVA: 0x0054D764 File Offset: 0x0054B964
	private IEnumerator BMDDMOBFOIC()
	{
		Debug.Log("[ItemsHandler] Found " + this.IHIFDJEOGGK.Count + " in-game items");
		foreach (KeyValuePair<int, string> keyValuePair in this.IHIFDJEOGGK)
		{
			Debug.Log("[ItemsHandler] Loading " + keyValuePair.Value);
			this.itemsData.Add(new InventoryItemData(keyValuePair.Value));
		}
		Debug.Log("[ItemsHandler] All in-game items loaded");
		yield break;
	}

	// Token: 0x0600F473 RID: 62579 RVA: 0x0054D780 File Offset: 0x0054B980
	public IEnumerator PFMJPIJONIP()
	{
		this.itemsData.Clear();
		this.isLoaded = false;
		yield return base.StartCoroutine(this.NGGKHGDAALF());
		this.UpdatePlayerInventory();
		yield break;
	}

	// Token: 0x0600F474 RID: 62580 RVA: 0x0054D79C File Offset: 0x0054B99C
	public void LGGNNFBLJFC()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem poonbaijmmc in this.newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(poonbaijmmc));
		}
		base.StartCoroutine(this.JNHEBDPOOCK(list));
		this.newItemsNotifications.Clear();
	}

	// Token: 0x0600F475 RID: 62581 RVA: 0x0054D81C File Offset: 0x0054BA1C
	public void CheckInventory()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0, null);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1, null);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), null))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), string.Empty + 17, null);
		}
		string @string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0, null);
		if (!this.IsItemInInventory(ulong.Parse(@string)))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0, null);
		}
		@string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1, null);
		if (!this.IsItemInInventory(ulong.Parse(@string)))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1, null);
		}
		@string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), string.Empty + 17, null);
		if (!this.IsItemInInventory(ulong.Parse(@string)))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), string.Empty + 17, null);
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (InventoryItemData inventoryItemData in this.itemsData)
		{
			if (inventoryItemData.rarity == InventoryItemRarity.Common)
			{
				num++;
			}
			if (inventoryItemData.rarity == InventoryItemRarity.Rare)
			{
				num2++;
			}
			if (inventoryItemData.rarity == InventoryItemRarity.Epic)
			{
				num3++;
			}
		}
		if (num > 1 && num2 > 1 && num3 > 1)
		{
			Helpers.ObtainAchievement(14);
		}
		if (Singleton<Scene>.Instance.id == "MenuScene" && UnityEngine.Object.FindObjectOfType<CraftingPanel>())
		{
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().Init();
		}
	}

	// Token: 0x0600F476 RID: 62582 RVA: 0x0054DBD8 File Offset: 0x0054BDD8
	private IEnumerator BDKOFJJADOM()
	{
		while (this.requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.requestType = 2;
		SteamInventory.GrantPromoItems(out steamInventoryResult_t);
		yield break;
	}

	// Token: 0x0600F477 RID: 62583 RVA: 0x0054DBF3 File Offset: 0x0054BDF3
	public void JLEENFEIKHB(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.KOMAMFOPJID("_Value2" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString(), null);
		Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
	}

	// Token: 0x0600F478 RID: 62584 RVA: 0x0054DC34 File Offset: 0x0054BE34
	private void PAEPMFCLNBI()
	{
		this.userItems.Add(new SteamInventoryItem(1UL, this.itemsData[0], true));
		this.userItems.Add(new SteamInventoryItem(1UL, this.itemsData[0], false));
		this.userItems.Add(new SteamInventoryItem(81UL, this.itemsData[20], false));
	}

	// Token: 0x0600F479 RID: 62585 RVA: 0x0054DCA0 File Offset: 0x0054BEA0
	public void DHNCPJMEFLA()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem poonbaijmmc in this.newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(poonbaijmmc));
		}
		base.StartCoroutine(this.OHGBJBGNDJN(list));
		this.newItemsNotifications.Clear();
	}

	// Token: 0x0600F47A RID: 62586 RVA: 0x0054DD20 File Offset: 0x0054BF20
	public void DeleteItem(ulong MOANAJGGPLK)
	{
		this.requestType = 3;
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.ConsumeItem(out steamInventoryResult_t, (SteamItemInstanceID_t)MOANAJGGPLK, 1U);
	}

	// Token: 0x0600F47B RID: 62587 RVA: 0x0054DD43 File Offset: 0x0054BF43
	public void PEGGAJELPBJ()
	{
		base.StartCoroutine(this.Init());
	}

	// Token: 0x0600F47C RID: 62588 RVA: 0x0054DD54 File Offset: 0x0054BF54
	public InventoryItemData GetItemData(string JMMILEFMACB)
	{
		ItemsHandler.DNBMFMBLMGG dnbmfmblmgg = new ItemsHandler.DNBMFMBLMGG();
		dnbmfmblmgg.JMMILEFMACB = JMMILEFMACB;
		return this.itemsData.Find(new Predicate<InventoryItemData>(dnbmfmblmgg.GBKBDKHPLKG));
	}

	// Token: 0x0600F47D RID: 62589 RVA: 0x0054DD88 File Offset: 0x0054BF88
	public List<InventoryItemType> POAMFKKEDIO()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		using (List<InventoryItemData>.Enumerator enumerator = this.itemsData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.FNJCOMEGJBM fnjcomegjbm = new ItemsHandler.FNJCOMEGJBM();
				fnjcomegjbm.DBIMJHMKHNK = enumerator.Current;
				if (!list.Exists(new Predicate<InventoryItemType>(fnjcomegjbm.LLNDDFGPOPL)))
				{
					list.Add(fnjcomegjbm.DBIMJHMKHNK.type);
				}
			}
		}
		return list;
	}

	// Token: 0x0600F47E RID: 62590 RVA: 0x0054DE18 File Offset: 0x0054C018
	public ulong ILHNOCIBMHK(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 1UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.NBMEANCMGEH("Parent ID" + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Other)
		{
			if (HMGBJCGOLMI != InventoryItemType.Player)
			{
				if (HMGBJCGOLMI == InventoryItemType.Player)
				{
					num = 95UL;
				}
			}
			else
			{
				num = 1UL;
			}
		}
		else
		{
			num = 1UL;
		}
		this.EnquipItem(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F47F RID: 62591 RVA: 0x0054DEA8 File Offset: 0x0054C0A8
	public List<SteamInventoryItem> LHKFIGPJKLK()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!steamInventoryItem.isLocal)
			{
				list.Add(steamInventoryItem);
			}
		}
		return list;
	}

	// Token: 0x0600F480 RID: 62592 RVA: 0x0054DF1C File Offset: 0x0054C11C
	public List<SteamInventoryItem> GetOnlySteamItemsList()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!steamInventoryItem.isLocal)
			{
				list.Add(steamInventoryItem);
			}
		}
		return list;
	}

	// Token: 0x0600F481 RID: 62593 RVA: 0x0054DF90 File Offset: 0x0054C190
	private void MJBCIEHJBKE(SteamInventoryResultReady_t IAFAANLMOAG)
	{
		this.FNMADDPJCLB = IAFAANLMOAG.m_handle;
		if (this.requestType == 0)
		{
			if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == EResult.k_EResultOK)
			{
				this.requestType = -1;
				uint num = 1U;
				bool resultItems = SteamInventory.GetResultItems(this.FNMADDPJCLB, null, ref num);
				if (resultItems)
				{
					this.userItems.Clear();
					this.NKPKKPEFGMG = new SteamItemDetails_t[num];
					resultItems = SteamInventory.GetResultItems(this.FNMADDPJCLB, this.NKPKKPEFGMG, ref num);
					this.AEHBAEIIIHO();
					Debug.Log("local CheckCondition = function()" + num + "_Value2");
					List<string> list = new List<string>();
					ItemsHandler.LEMIJMHKLLM lemijmhkllm = new ItemsHandler.LEMIJMHKLLM();
					lemijmhkllm.ADPIKBBAKHP = this;
					lemijmhkllm.EGMPIBBOEMH = 1;
					while ((long)lemijmhkllm.EGMPIBBOEMH < (long)((ulong)num))
					{
						try
						{
							this.userItems.Add(new SteamInventoryItem(this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, this.itemsData.Find(new Predicate<InventoryItemData>(lemijmhkllm.EKHOOPGPPGE)), true));
							list.Add(this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("_Value7" + this.NKPKKPEFGMG[lemijmhkllm.EGMPIBBOEMH].m_iDefinition);
						}
						lemijmhkllm.EGMPIBBOEMH++;
					}
					string text = string.Join("FPSToggle", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_Value2", string.Empty, null))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.NBMEANCMGEH("MAPS NOT FOUND", null)))
						{
							Singleton<SaveSystem>.Instance.KOMAMFOPJID("_Blue_C", text, null);
						}
						else
						{
							Debug.Log("#");
							try
							{
								string text2 = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("Misses:", null);
								char[] array = new char[0];
								array[1] = 'h';
								List<string> second = text2.Split(array).ToList<string>();
								List<string> list2 = list.Except(second).ToList<string>();
								using (List<string>.Enumerator enumerator = list2.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										ItemsHandler.MOKFDBBHABE mokfdbbhabe = new ItemsHandler.MOKFDBBHABE();
										mokfdbbhabe.JMMILEFMACB = enumerator.Current;
										this.newItemsNotifications.Add(this.userItems.Find(new Predicate<SteamInventoryItem>(mokfdbbhabe.DBFPGFHEGKA)));
									}
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.NOEIPDOLJFA("_FinalReflectionTexture", text, null);
						}
					}
					else
					{
						Debug.Log("menu.playedpage");
					}
					this.isLoadeding = true;
				}
			}
			else
			{
				Debug.Log("settings.enablehitsoundsinnormal" + SteamInventory.GetResultStatus(this.FNMADDPJCLB).ToString());
				this.OHKKPHDGKAH("ItemNameBGImage");
				this.PAEPMFCLNBI();
				this.isLoadeding = true;
			}
			this.PALFFMFLILA();
			this.CKJOBJOHFHK();
			this.isLoaded = false;
		}
		if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == (EResult)0 && this.requestType == 0)
		{
			this.requestType = -1;
			uint num2 = 1U;
			bool resultItems2 = SteamInventory.GetResultItems(this.FNMADDPJCLB, null, ref num2);
			if (resultItems2 && num2 > 1U)
			{
				this.NKPKKPEFGMG = new SteamItemDetails_t[num2];
				resultItems2 = SteamInventory.GetResultItems(this.FNMADDPJCLB, this.NKPKKPEFGMG, ref num2);
				this.AJDGHDGDLOH();
				this.DCEFGAJKFIL();
			}
		}
		if (SteamInventory.GetResultStatus(this.FNMADDPJCLB) == EResult.k_EResultOK && (this.requestType == 3 || this.requestType == 4))
		{
			this.requestType = -1;
			this.UpdatePlayerInventory();
		}
	}

	// Token: 0x0600F482 RID: 62594 RVA: 0x0054E378 File Offset: 0x0054C578
	public void ECINNLEOMIH(ulong MOANAJGGPLK)
	{
		this.requestType = 6;
		SteamInventoryResult_t steamInventoryResult_t;
		SteamInventory.ConsumeItem(out steamInventoryResult_t, (SteamItemInstanceID_t)MOANAJGGPLK, 1U);
	}

	// Token: 0x0600F483 RID: 62595 RVA: 0x0054B11E File Offset: 0x0054931E
	private void DHAPJFJFEDI(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		this.FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	// Token: 0x0600F484 RID: 62596 RVA: 0x0054E39C File Offset: 0x0054C59C
	public void HMLPIPGHDBI(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Intensity", Singleton<ItemsHandler>.Instance.userItems.Count, null);
		this.OIFFBIKCALF();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		using (List<InventoryItemType>.Enumerator enumerator = this.GetAllTypes().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				ItemsHandler.MOCPGDGNNCN mocpgdgnncn = new ItemsHandler.MOCPGDGNNCN();
				mocpgdgnncn.CJEIKDHCCOI = enumerator.Current;
				if (this.userItems.Find(new Predicate<SteamInventoryItem>(mocpgdgnncn.BDGDIDPDBHG)) != null)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
					gameObject.transform.SetParent(MPNMOONBMII.transform, true);
					gameObject.transform.localScale = new Vector3(47f, 358f, 14f);
					if (gameObject.transform.Find("_Value").Find("intensity"))
					{
						switch (mocpgdgnncn.CJEIKDHCCOI)
						{
						case InventoryItemType.Player:
							gameObject.transform.Find("_ScreenResolution").Find("_MainTex2").GetComponent<Text>().text = LocalizationService.Instance.IAAEBJKAHDD("GameScene").ToUpper();
							break;
						case InventoryItemType.MenuTheme:
							gameObject.transform.Find("UnityEngine.MonoBehaviour").Find("_BlurParams").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("_Value").ToUpper();
							break;
						case InventoryItemType.Shader:
							gameObject.transform.Find("_ScreenResolution").Find("In Map Editor").GetComponent<Text>().text = LocalizationService.Instance.IAAEBJKAHDD("y").ToUpper();
							break;
						default:
							gameObject.transform.Find("?").Find("tolobby").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey(" - GameWebCallback] - ").ToUpper();
							break;
						}
					}
					GameObject gameObject2 = gameObject.transform.Find("float,0").Find("OxOD.lastPath").gameObject;
					for (int j = 1; j < gameObject2.transform.childCount; j += 0)
					{
						UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
					if (ItemsHandler.LNIJKGECNME == null)
					{
						ItemsHandler.LNIJKGECNME = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.JOFIMKHOPPH);
					}
					foreach (SteamInventoryItem steamInventoryItem2 in values.OrderBy(ItemsHandler.LNIJKGECNME))
					{
						if (steamInventoryItem2.item.type == mocpgdgnncn.CJEIKDHCCOI)
						{
							GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
							gameObject3.transform.SetParent(gameObject2.transform, false);
							gameObject3.transform.localScale = new Vector3(1758f, 1460f, 1670f);
							this.UpdateInventoryItem(gameObject3, steamInventoryItem2, dictionary2[steamInventoryItem2.item.id]);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600F485 RID: 62597 RVA: 0x0054E80C File Offset: 0x0054CA0C
	public List<SteamInventoryItem> JAAIGMFHODM()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!steamInventoryItem.isLocal)
			{
				list.Add(steamInventoryItem);
			}
		}
		return list;
	}

	// Token: 0x0600F486 RID: 62598 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity JOFIMKHOPPH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F487 RID: 62599 RVA: 0x0054A2C8 File Offset: 0x005484C8
	public void HFKDDFOCLAD()
	{
		base.StartCoroutine(this.IBGBCINGJHE());
	}

	// Token: 0x0600F488 RID: 62600 RVA: 0x0054E880 File Offset: 0x0054CA80
	public IEnumerator Init()
	{
		this.itemsData.Clear();
		this.isLoaded = false;
		yield return base.StartCoroutine(this.NGGKHGDAALF());
		this.UpdatePlayerInventory();
		yield break;
	}

	// Token: 0x0600F489 RID: 62601 RVA: 0x0054E89B File Offset: 0x0054CA9B
	public void EFBFKJNGAIJ()
	{
		this.requestType = 0;
		SteamInventory.TriggerItemDrop(out this.FNMADDPJCLB, (SteamItemDef_t)0);
	}

	// Token: 0x0600F48A RID: 62602 RVA: 0x0054E8B8 File Offset: 0x0054CAB8
	public ulong GNLDKKBJNGF(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 1UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.CFLCJCJHNKD("Delete events" + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Player)
		{
			if (HMGBJCGOLMI != (InventoryItemType)6)
			{
				if (HMGBJCGOLMI == InventoryItemType.Shader)
				{
					num = 98UL;
				}
			}
			else
			{
				num = 0UL;
			}
		}
		else
		{
			num = 1UL;
		}
		this.JLEENFEIKHB(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F48B RID: 62603 RVA: 0x0054E945 File Offset: 0x0054CB45
	public void CDFFAHIGGHC(string NOJGGCLPPAM)
	{
		if (GameObject.Find("steamid"))
		{
			GameObject.Find("UI Extensions/SoftMaskShader").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F48C RID: 62604 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity OEEPHCOLBHL(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F48D RID: 62605 RVA: 0x0054E978 File Offset: 0x0054CB78
	public void OnEnable()
	{
		this.GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(new Callback<SteamInventoryResultReady_t>.DispatchDelegate(this.MMAGOONHNKM));
		this.EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(new Callback<SteamInventoryFullUpdate_t>.DispatchDelegate(this.PLBAKPAONCD));
		this.EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(new Callback<SteamInventoryDefinitionUpdate_t>.DispatchDelegate(this.KHNLPKIDBDE));
		this.FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		this.NKPKKPEFGMG = null;
	}

	// Token: 0x0600F48E RID: 62606 RVA: 0x0054A2C8 File Offset: 0x005484C8
	public void NPLAKLFJEOF()
	{
		base.StartCoroutine(this.IBGBCINGJHE());
	}

	// Token: 0x0600F48F RID: 62607 RVA: 0x0054E9DC File Offset: 0x0054CBDC
	public ulong MFPEMIAAILI(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 0UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.NBMEANCMGEH("#close" + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Other)
		{
			if (HMGBJCGOLMI != InventoryItemType.Shader)
			{
				if (HMGBJCGOLMI == InventoryItemType.Other)
				{
					num = 18446744073709551488UL;
				}
			}
			else
			{
				num = 0UL;
			}
		}
		else
		{
			num = 0UL;
		}
		this.JGJCJMPFOAC(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F490 RID: 62608 RVA: 0x0054A2AD File Offset: 0x005484AD
	public void TriggerItemDrop()
	{
		this.requestType = 1;
		SteamInventory.TriggerItemDrop(out this.FNMADDPJCLB, (SteamItemDef_t)0);
	}

	// Token: 0x0600F491 RID: 62609 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCEFBKLKFEJ(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F492 RID: 62610 RVA: 0x0054EA6C File Offset: 0x0054CC6C
	public SteamInventoryItem GetItemBySteamId(ulong MOANAJGGPLK)
	{
		ItemsHandler.FPDJBMKIHEE fpdjbmkihee = new ItemsHandler.FPDJBMKIHEE();
		fpdjbmkihee.MOANAJGGPLK = MOANAJGGPLK;
		return this.userItems.Find(new Predicate<SteamInventoryItem>(fpdjbmkihee.GBKBDKHPLKG));
	}

	// Token: 0x0600F493 RID: 62611 RVA: 0x0054A1C8 File Offset: 0x005483C8
	[CompilerGenerated]
	private static InventoryItemRarity MGDONOIEKEK(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F494 RID: 62612 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600F495 RID: 62613 RVA: 0x0054DD43 File Offset: 0x0054BF43
	public void Initializate()
	{
		base.StartCoroutine(this.Init());
	}

	// Token: 0x0600F496 RID: 62614 RVA: 0x0054B11E File Offset: 0x0054931E
	private void FOPOKOFGDCB(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		this.FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	// Token: 0x0600F497 RID: 62615 RVA: 0x0054EAA0 File Offset: 0x0054CCA0
	public List<SteamInventoryItem> PMIPHDOOIEB()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!steamInventoryItem.isLocal)
			{
				list.Add(steamInventoryItem);
			}
		}
		return list;
	}

	// Token: 0x0600F498 RID: 62616 RVA: 0x0002523B File Offset: 0x0002343B
	public void NBMPNNMLLCF(string JMMILEFMACB)
	{
	}

	// Token: 0x0600F499 RID: 62617 RVA: 0x0054EB14 File Offset: 0x0054CD14
	private IEnumerator GANBALCKOOK()
	{
		while (this.requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		this.requestType = 2;
		SteamInventory.GrantPromoItems(out steamInventoryResult_t);
		yield break;
	}

	// Token: 0x0600F49A RID: 62618 RVA: 0x0054EB30 File Offset: 0x0054CD30
	public void ALEGFDJJKMM(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		IEnumerable<SteamInventoryItem> source = Singleton<ItemsHandler>.Instance.PMIPHDOOIEB();
		if (ItemsHandler.CLCBJCKCBDD == null)
		{
			ItemsHandler.CLCBJCKCBDD = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.JEJKAHEBOLM);
		}
		foreach (SteamInventoryItem cidiamacink in source.OrderBy(ItemsHandler.CLCBJCKCBDD))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(258f, 240f, 1127f);
			this.UpdateInventoryItem(gameObject, cidiamacink, 1);
		}
	}

	// Token: 0x0600F49B RID: 62619 RVA: 0x0054B11E File Offset: 0x0054931E
	private void PLBAKPAONCD(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		this.FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	// Token: 0x0600F49C RID: 62620 RVA: 0x0054EC28 File Offset: 0x0054CE28
	public void UpdateLoadingInfo(string NOJGGCLPPAM)
	{
		if (GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	// Token: 0x0600F49D RID: 62621 RVA: 0x0054AC71 File Offset: 0x00548E71
	public List<string> EJFGHNNFIAF()
	{
		return this.IHIFDJEOGGK.Values.ToList<string>();
	}

	// Token: 0x0600F49E RID: 62622 RVA: 0x0054EC58 File Offset: 0x0054CE58
	public void AddSteamInventoryItemsToList(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		IEnumerable<SteamInventoryItem> onlySteamItemsList = Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList();
		if (ItemsHandler.CLCBJCKCBDD == null)
		{
			ItemsHandler.CLCBJCKCBDD = new Func<SteamInventoryItem, InventoryItemRarity>(ItemsHandler.MGDONOIEKEK);
		}
		foreach (SteamInventoryItem cidiamacink in onlySteamItemsList.OrderBy(ItemsHandler.CLCBJCKCBDD))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			this.UpdateInventoryItem(gameObject, cidiamacink, 1);
		}
	}

	// Token: 0x0600F49F RID: 62623 RVA: 0x0002523B File Offset: 0x0002343B
	private void ACDKNINNMPJ(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	// Token: 0x0600F4A0 RID: 62624 RVA: 0x0054ED50 File Offset: 0x0054CF50
	public int MAHLIKCBOCI()
	{
		return this.userItems.Count - Singleton<SaveSystem>.Instance.ANECPPFPKAP("_TimeX", 0, null);
	}

	// Token: 0x0600F4A1 RID: 62625 RVA: 0x0054ED70 File Offset: 0x0054CF70
	public InventoryItemData BLBIGKOEHGK(string JMMILEFMACB)
	{
		ItemsHandler.DNBMFMBLMGG dnbmfmblmgg = new ItemsHandler.DNBMFMBLMGG();
		dnbmfmblmgg.JMMILEFMACB = JMMILEFMACB;
		return this.itemsData.Find(new Predicate<InventoryItemData>(dnbmfmblmgg.LJDLIIIPIIJ));
	}

	// Token: 0x0600F4A2 RID: 62626 RVA: 0x0054EDA4 File Offset: 0x0054CFA4
	public string GetItemNameByID(int EEBCDMFNKLH)
	{
		ItemsHandler.IHAFGMJBHMB ihafgmjbhmb = new ItemsHandler.IHAFGMJBHMB();
		ihafgmjbhmb.EEBCDMFNKLH = EEBCDMFNKLH;
		return this.IHIFDJEOGGK.Where(new Func<KeyValuePair<int, string>, bool>(ihafgmjbhmb.GBKBDKHPLKG)).First<KeyValuePair<int, string>>().Value;
	}

	// Token: 0x0600F4A3 RID: 62627 RVA: 0x0054EDE4 File Offset: 0x0054CFE4
	private IEnumerator NGGKHGDAALF()
	{
		Debug.Log("[ItemsHandler] Found " + this.IHIFDJEOGGK.Count + " in-game items");
		enumerator = this.IHIFDJEOGGK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				keyValuePair = enumerator.Current;
				Debug.Log("[ItemsHandler] Loading " + keyValuePair.Value);
				this.itemsData.Add(new InventoryItemData(keyValuePair.Value));
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		Debug.Log("[ItemsHandler] All in-game items loaded");
		yield break;
	}

	// Token: 0x0600F4A4 RID: 62628 RVA: 0x0054EE00 File Offset: 0x0054D000
	public ulong EnquippedItem(InventoryItemType HMGBJCGOLMI)
	{
		ulong num = 0UL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.GetString("inventory.selected." + HMGBJCGOLMI.ToString().ToLower(), null), out num) && this.IsItemInInventory(num))
		{
			return num;
		}
		if (HMGBJCGOLMI != InventoryItemType.Player)
		{
			if (HMGBJCGOLMI != InventoryItemType.MenuTheme)
			{
				if (HMGBJCGOLMI == InventoryItemType.Shader)
				{
					num = 17UL;
				}
			}
			else
			{
				num = 1UL;
			}
		}
		else
		{
			num = 0UL;
		}
		this.EnquipItem(HMGBJCGOLMI, num);
		return num;
	}

	// Token: 0x0600F4A5 RID: 62629 RVA: 0x0054A1C8 File Offset: 0x005483C8
	private static InventoryItemRarity EMOMHOFIPEC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	// Token: 0x0600F4A6 RID: 62630 RVA: 0x0054EE8D File Offset: 0x0054D08D
	public void KNGPEINMNMB()
	{
		Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
		base.StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(this.newItemsCanvas, true, null, true, 1215f, false));
	}

	// Token: 0x0600F4A7 RID: 62631 RVA: 0x0054EEBC File Offset: 0x0054D0BC
	public List<SteamInventoryItem> IONIEFDFING()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem steamInventoryItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!steamInventoryItem.isLocal)
			{
				list.Add(steamInventoryItem);
			}
		}
		return list;
	}

	// Token: 0x0600F4A8 RID: 62632 RVA: 0x0054EF30 File Offset: 0x0054D130
	private IEnumerator OHPLMOPKKHM(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		gameObject = this.newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = IOMNJBPDLAK.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem cidiamacink = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.inventoryItemElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, cidiamacink, 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.newItemsCanvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x04001B17 RID: 6935
	[Header("UI")]
	public GameObject newItemsCanvas;

	// Token: 0x04001B18 RID: 6936
	public GameObject newItemsListContent;

	// Token: 0x04001B19 RID: 6937
	[Header("References")]
	public GameObject inventoryItemElement;

	// Token: 0x04001B1A RID: 6938
	private SteamInventoryResult_t FNMADDPJCLB;

	// Token: 0x04001B1B RID: 6939
	private SteamItemDetails_t[] NKPKKPEFGMG;

	// Token: 0x04001B1C RID: 6940
	[HideInInspector]
	public int requestType = -1;

	// Token: 0x04001B1D RID: 6941
	protected Callback<SteamInventoryResultReady_t> GLBMBBFDDOB;

	// Token: 0x04001B1E RID: 6942
	protected Callback<SteamInventoryFullUpdate_t> EHFCDBNJDNA;

	// Token: 0x04001B1F RID: 6943
	protected Callback<SteamInventoryDefinitionUpdate_t> EAMLAGAIMAN;

	// Token: 0x04001B20 RID: 6944
	public List<InventoryItemData> itemsData = new List<InventoryItemData>();

	// Token: 0x04001B21 RID: 6945
	public List<SteamInventoryItem> userItems = new List<SteamInventoryItem>();

	// Token: 0x04001B22 RID: 6946
	public List<SteamInventoryItem> newItemsNotifications = new List<SteamInventoryItem>();

	// Token: 0x04001B23 RID: 6947
	private Dictionary<int, string> IHIFDJEOGGK = new Dictionary<int, string>
	{
		{
			0,
			"player.redarc"
		},
		{
			1,
			"menutheme.fragout"
		},
		{
			2,
			"player.greenarc"
		},
		{
			3,
			"player.bluearc"
		},
		{
			4,
			"player.arrow"
		},
		{
			5,
			"player.goldarc"
		},
		{
			6,
			"player.dragon"
		},
		{
			7,
			"player.linea"
		},
		{
			8,
			"player.deleted"
		},
		{
			9,
			"menutheme.idunno"
		},
		{
			10,
			"menutheme.melancholicose"
		},
		{
			11,
			"menutheme.jamaicanorcdub"
		},
		{
			12,
			"menutheme.deleted"
		},
		{
			13,
			"player.orangearc"
		},
		{
			14,
			"player.yellowarc"
		},
		{
			15,
			"player.violetarc"
		},
		{
			16,
			"menutheme.coldheat"
		},
		{
			17,
			"shader.none"
		},
		{
			18,
			"shader.invert"
		},
		{
			19,
			"shader.future"
		},
		{
			20,
			"shader.pixel"
		},
		{
			21,
			"other.dust0"
		},
		{
			22,
			"other.dust1"
		},
		{
			23,
			"other.dust2"
		},
		{
			24,
			"player.lollipop"
		},
		{
			25,
			"player.greenlollipop"
		},
		{
			26,
			"player.goldlollipop"
		},
		{
			27,
			"menutheme.letitbe"
		},
		{
			28,
			"shader.frost"
		},
		{
			29,
			"player.bat"
		},
		{
			30,
			"player.bluebat"
		},
		{
			31,
			"player.goldbat"
		},
		{
			32,
			"menutheme.hunter"
		},
		{
			33,
			"shader.ghost"
		},
		{
			34,
			"player.slash"
		},
		{
			35,
			"player.redlifering"
		},
		{
			36,
			"player.bluelifering"
		},
		{
			37,
			"player.greenlifering"
		},
		{
			38,
			"player.orangelifering"
		},
		{
			39,
			"menutheme.summerbreeze"
		},
		{
			40,
			"shader.sunny"
		},
		{
			41,
			"player.watermelon"
		},
		{
			42,
			"player.goldwatermelon"
		},
		{
			43,
			"player.russia"
		},
		{
			44,
			"ticket.ticket1"
		},
		{
			100,
			"player.mysteryitem"
		},
		{
			200,
			"player.mysteryitem"
		},
		{
			1827589449,
			"player.neon"
		},
		{
			1868789888,
			"player.quantum"
		},
		{
			1866580677,
			"player.rgb"
		},
		{
			1839047562,
			"player.abstract"
		},
		{
			1892383279,
			"player.goldabstract"
		},
		{
			1892390583,
			"player.redabstract"
		},
		{
			1839728983,
			"player.egglipszerotwo"
		},
		{
			1889690103,
			"player.blackwhite"
		},
		{
			1890098134,
			"menutheme.27thfloor"
		},
		{
			1939835450,
			"player.circle"
		},
		{
			1937478462,
			"player.crystal"
		},
		{
			45,
			"player.goldcrystal"
		},
		{
			46,
			"shader.crispwinter"
		},
		{
			2025747682,
			"player.fire"
		},
		{
			1941333581,
			"player.ice"
		},
		{
			1873045881,
			"player.blackcat"
		}
	};

	// Token: 0x04001B24 RID: 6948
	public static Dictionary<ulong, string> craftRecipes = new Dictionary<ulong, string>
	{
		{
			0UL,
			"22x1"
		},
		{
			1000UL,
			"21x3"
		},
		{
			2000UL,
			"22x3"
		},
		{
			3000UL,
			"23x3"
		},
		{
			21UL,
			"2;13;14;15;16"
		},
		{
			22UL,
			"3;4;9;10;21x6"
		},
		{
			23UL,
			"5;6;7;8;11;12;18;19;20;22x6;44x1"
		}
	};

	// Token: 0x04001B25 RID: 6949
	public bool isLoaded;

	// Token: 0x04001B26 RID: 6950
	public string getRewardURL = "???";

	// Token: 0x04001B27 RID: 6951
	public string exchangeItemURL = "???";

	// Token: 0x04001B28 RID: 6952
	[HideInInspector]
	public bool isLoadeding = true;

	// Token: 0x04001B29 RID: 6953
	[CompilerGenerated]
	private static Func<SteamInventoryItem, InventoryItemRarity> LNIJKGECNME;

	// Token: 0x04001B2A RID: 6954
	[CompilerGenerated]
	private static Func<SteamInventoryItem, InventoryItemRarity> CLCBJCKCBDD;

	// Token: 0x0200042B RID: 1067
	[CompilerGenerated]
	private sealed class IHAFGMJBHMB
	{
		// Token: 0x0600F4A9 RID: 62633 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool PBCAHKDLFPE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4AA RID: 62634 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool OLIGLEMPFOP(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4AB RID: 62635 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool AEINPAGJFME(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4AD RID: 62637 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool JKEDCEOCPJO(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4AE RID: 62638 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool DBFPGFHEGKA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4AF RID: 62639 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool JDELIMPGFDJ(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B0 RID: 62640 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool LHHFJBIAHCN(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B1 RID: 62641 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool FFEGPHJKMFK(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B2 RID: 62642 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool MEMPOPNAEDN(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B3 RID: 62643 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool DKGPCPBNDPK(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool LNDGINDKPFA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B5 RID: 62645 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool LLNDDFGPOPL(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B6 RID: 62646 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool BFEABMIFIEE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B7 RID: 62647 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool EGKGJJGAPMN(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B8 RID: 62648 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool LOEAMHGMMPK(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4B9 RID: 62649 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool KFNBKFELFLH(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4BA RID: 62650 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool FIPCLHEKKCA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4BB RID: 62651 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool EKHOOPGPPGE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4BC RID: 62652 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool GBKBDKHPLKG(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4BD RID: 62653 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool BDGDIDPDBHG(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4BE RID: 62654 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool BKNHHGBPLGH(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x0600F4BF RID: 62655 RVA: 0x0054EF52 File Offset: 0x0054D152
		internal bool OFHCGKJFGDI(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == this.EEBCDMFNKLH;
		}

		// Token: 0x04001B2B RID: 6955
		internal int EEBCDMFNKLH;
	}

	// Token: 0x0200042C RID: 1068
	[CompilerGenerated]
	private sealed class LEMIJMHKLLM
	{
		// Token: 0x0600F4C0 RID: 62656 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool BFEABMIFIEE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C1 RID: 62657 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool AEINPAGJFME(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C2 RID: 62658 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool MEMPOPNAEDN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C3 RID: 62659 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool LOEAMHGMMPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C4 RID: 62660 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool DKGPCPBNDPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C5 RID: 62661 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool EKHOOPGPPGE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C6 RID: 62662 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool BKNHHGBPLGH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C7 RID: 62663 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool PBCAHKDLFPE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C8 RID: 62664 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool JKEDCEOCPJO(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4C9 RID: 62665 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool GBKBDKHPLKG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4CA RID: 62666 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool OLIGLEMPFOP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4CB RID: 62667 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool FFEGPHJKMFK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4CC RID: 62668 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool JDELIMPGFDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4CD RID: 62669 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool LLNDDFGPOPL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4CE RID: 62670 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool LNDGINDKPFA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4CF RID: 62671 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool OFHCGKJFGDI(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4D0 RID: 62672 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool EGKGJJGAPMN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4D1 RID: 62673 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool KFNBKFELFLH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4D2 RID: 62674 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool FIPCLHEKKCA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4D3 RID: 62675 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool LHHFJBIAHCN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4D4 RID: 62676 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool BDGDIDPDBHG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x0600F4D5 RID: 62677 RVA: 0x0054EF63 File Offset: 0x0054D163
		internal bool DBFPGFHEGKA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.IHIFDJEOGGK[this.ADPIKBBAKHP.NKPKKPEFGMG[this.EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		// Token: 0x04001B2C RID: 6956
		internal int EGMPIBBOEMH;

		// Token: 0x04001B2D RID: 6957
		internal ItemsHandler ADPIKBBAKHP;
	}

	// Token: 0x0200042D RID: 1069
	[CompilerGenerated]
	private sealed class MOKFDBBHABE
	{
		// Token: 0x0600F4D7 RID: 62679 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4D8 RID: 62680 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4D9 RID: 62681 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4DA RID: 62682 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4DB RID: 62683 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4DC RID: 62684 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4DD RID: 62685 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4DE RID: 62686 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4DF RID: 62687 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4E0 RID: 62688 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4E1 RID: 62689 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4E3 RID: 62691 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4E4 RID: 62692 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4E5 RID: 62693 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x0600F4E6 RID: 62694 RVA: 0x0054EFA0 File Offset: 0x0054D1A0
		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(this.JMMILEFMACB);
		}

		// Token: 0x04001B2E RID: 6958
		internal string JMMILEFMACB;
	}

	// Token: 0x0200042E RID: 1070
	[CompilerGenerated]
	private sealed class MOCPGDGNNCN
	{
		// Token: 0x0600F4E7 RID: 62695 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool LHHFJBIAHCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4E8 RID: 62696 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4E9 RID: 62697 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4EA RID: 62698 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool EGKGJJGAPMN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4EB RID: 62699 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4EC RID: 62700 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool FFEGPHJKMFK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4ED RID: 62701 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool KGKMOLCPDIH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4EE RID: 62702 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool FIPCLHEKKCA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4EF RID: 62703 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool IGFOBPKFCDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F0 RID: 62704 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool BMAOCLKPNNC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F1 RID: 62705 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool PIJAOCFAPKC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F2 RID: 62706 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F3 RID: 62707 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F4 RID: 62708 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F5 RID: 62709 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F6 RID: 62710 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool JDELIMPGFDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F7 RID: 62711 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F8 RID: 62712 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4F9 RID: 62713 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool FJDBPPKABJE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4FA RID: 62714 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool OFHCGKJFGDI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4FB RID: 62715 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool DKGPCPBNDPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4FC RID: 62716 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4FD RID: 62717 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool HBJFIOJFBHC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4FE RID: 62718 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F4FF RID: 62719 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool AGJKEBOPIOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F500 RID: 62720 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F501 RID: 62721 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F502 RID: 62722 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x0600F503 RID: 62723 RVA: 0x0054EFB5 File Offset: 0x0054D1B5
		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == this.CJEIKDHCCOI;
		}

		// Token: 0x04001B2F RID: 6959
		internal InventoryItemType CJEIKDHCCOI;
	}

	// Token: 0x02000433 RID: 1075
	[CompilerGenerated]
	private sealed class FPDJBMKIHEE
	{
		// Token: 0x0600F61E RID: 63006 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FIPCLHEKKCA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F61F RID: 63007 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool AGJKEBOPIOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F620 RID: 63008 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool BEBAENEJFLD(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F621 RID: 63009 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool KGKMOLCPDIH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F622 RID: 63010 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FHFECFLBHMA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F623 RID: 63011 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool JDELIMPGFDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F625 RID: 63013 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F626 RID: 63014 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool BMAOCLKPNNC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F627 RID: 63015 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F628 RID: 63016 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F629 RID: 63017 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FCAGEDLBBHD(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F62A RID: 63018 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F62B RID: 63019 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F62C RID: 63020 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool HBJFIOJFBHC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F62D RID: 63021 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F62E RID: 63022 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F62F RID: 63023 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool LJDLIIIPIIJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F630 RID: 63024 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F631 RID: 63025 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool EGKGJJGAPMN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F632 RID: 63026 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool JBAJEMGOPDL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F633 RID: 63027 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool BJMAIJDIKCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F634 RID: 63028 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F635 RID: 63029 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool MGENGAEDACG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F636 RID: 63030 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool OFHCGKJFGDI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F637 RID: 63031 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool LHHFJBIAHCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F638 RID: 63032 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FDAIFOAGDLA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F639 RID: 63033 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F63A RID: 63034 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool DKGPCPBNDPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F63B RID: 63035 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FMIHBNPKEEO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F63C RID: 63036 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool OFLDIMDDLHM(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F63D RID: 63037 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool IGFOBPKFCDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F63E RID: 63038 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool INHOEMCLAAP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F63F RID: 63039 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F640 RID: 63040 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FJDBPPKABJE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F641 RID: 63041 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool DNIMHEKGJHB(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F642 RID: 63042 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool AEIFJLBBKBP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F643 RID: 63043 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FHIJCPPECHA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F644 RID: 63044 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F645 RID: 63045 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F646 RID: 63046 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool FFEGPHJKMFK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F647 RID: 63047 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool PIJAOCFAPKC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F648 RID: 63048 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F649 RID: 63049 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool EFAPFFFGOOA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x0600F64A RID: 63050 RVA: 0x005512F2 File Offset: 0x0054F4F2
		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == this.MOANAJGGPLK;
		}

		// Token: 0x04001B4B RID: 6987
		internal ulong MOANAJGGPLK;
	}

	// Token: 0x02000434 RID: 1076
	[CompilerGenerated]
	private sealed class FNJCOMEGJBM
	{
		// Token: 0x0600F64B RID: 63051 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool FCAGEDLBBHD(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F64C RID: 63052 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool FIPCLHEKKCA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F64D RID: 63053 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool PIJAOCFAPKC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F64F RID: 63055 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool MEMPOPNAEDN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F650 RID: 63056 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool EKHOOPGPPGE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F651 RID: 63057 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool OFHCGKJFGDI(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F652 RID: 63058 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool BDGDIDPDBHG(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F653 RID: 63059 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool KGKMOLCPDIH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F654 RID: 63060 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool BKNHHGBPLGH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F655 RID: 63061 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool LHHFJBIAHCN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F656 RID: 63062 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool FHIJCPPECHA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F657 RID: 63063 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool IGFOBPKFCDJ(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F658 RID: 63064 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool PBCAHKDLFPE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F659 RID: 63065 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool HBJFIOJFBHC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F65A RID: 63066 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool JKEDCEOCPJO(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F65B RID: 63067 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool BFEABMIFIEE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F65C RID: 63068 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool EGKGJJGAPMN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F65D RID: 63069 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool KFNBKFELFLH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F65E RID: 63070 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool AEINPAGJFME(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F65F RID: 63071 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool JDELIMPGFDJ(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F660 RID: 63072 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool LOEAMHGMMPK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F661 RID: 63073 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool LNDGINDKPFA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F662 RID: 63074 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool FFEGPHJKMFK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F663 RID: 63075 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool LLNDDFGPOPL(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F664 RID: 63076 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool DBFPGFHEGKA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F665 RID: 63077 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool FJDBPPKABJE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F666 RID: 63078 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool GBKBDKHPLKG(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F667 RID: 63079 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool DNIMHEKGJHB(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F668 RID: 63080 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool BMAOCLKPNNC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F669 RID: 63081 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool AGJKEBOPIOC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F66A RID: 63082 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool OLIGLEMPFOP(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x0600F66B RID: 63083 RVA: 0x00551302 File Offset: 0x0054F502
		internal bool DKGPCPBNDPK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == this.DBIMJHMKHNK.type;
		}

		// Token: 0x04001B4C RID: 6988
		internal InventoryItemData DBIMJHMKHNK;
	}

	// Token: 0x02000436 RID: 1078
	[CompilerGenerated]
	private sealed class DNBMFMBLMGG
	{
		// Token: 0x0600F67C RID: 63100 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool OMBHIBNMFNB(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F67D RID: 63101 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FJDBPPKABJE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F67E RID: 63102 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FDAIFOAGDLA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F67F RID: 63103 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool PIJAOCFAPKC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool JDELIMPGFDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F681 RID: 63105 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool LJDLIIIPIIJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F682 RID: 63106 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool GBKBDKHPLKG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F683 RID: 63107 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool DKGPCPBNDPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F684 RID: 63108 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool MEMPOPNAEDN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F685 RID: 63109 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool DNIMHEKGJHB(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F686 RID: 63110 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool JBCHBMKPDAJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F688 RID: 63112 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool OLIGLEMPFOP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F689 RID: 63113 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool MGENGAEDACG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F68A RID: 63114 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool AEINPAGJFME(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F68B RID: 63115 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool JKEDCEOCPJO(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F68C RID: 63116 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool MPGGBMMPNDH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F68D RID: 63117 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool BJMAIJDIKCN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F68E RID: 63118 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool OFHCGKJFGDI(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F68F RID: 63119 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool AGFDCBCBAGI(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F690 RID: 63120 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool MAGEPMCPGOC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F691 RID: 63121 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool BKNHHGBPLGH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F692 RID: 63122 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FMIHBNPKEEO(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F693 RID: 63123 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool BBIADFAPKDL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F694 RID: 63124 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool PCDFLCEIHFF(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F695 RID: 63125 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool BDGDIDPDBHG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F696 RID: 63126 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool LNDGINDKPFA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F697 RID: 63127 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool BMAOCLKPNNC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F698 RID: 63128 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool DBFPGFHEGKA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F699 RID: 63129 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool EGKGJJGAPMN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F69A RID: 63130 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool IGFOBPKFCDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F69B RID: 63131 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool PKAPLCFHDOC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F69C RID: 63132 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FHFECFLBHMA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F69D RID: 63133 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool LOEAMHGMMPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F69E RID: 63134 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool EDGAPOPEIJF(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F69F RID: 63135 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool BEBAENEJFLD(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A0 RID: 63136 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool AGJKEBOPIOC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A1 RID: 63137 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool KGKMOLCPDIH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A2 RID: 63138 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool JBAJEMGOPDL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A3 RID: 63139 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool EFAPFFFGOOA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A4 RID: 63140 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool AEIFJLBBKBP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A5 RID: 63141 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FCAGEDLBBHD(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A6 RID: 63142 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool KFNBKFELFLH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A7 RID: 63143 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool BFEABMIFIEE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A8 RID: 63144 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool OFLDIMDDLHM(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6A9 RID: 63145 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool INHOEMCLAAP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6AA RID: 63146 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool LLNDDFGPOPL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6AB RID: 63147 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FIPCLHEKKCA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6AC RID: 63148 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool AKDOOLPMPMG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6AD RID: 63149 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FFEGPHJKMFK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6AE RID: 63150 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool LHHFJBIAHCN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6AF RID: 63151 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool HBJFIOJFBHC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6B0 RID: 63152 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool FHIJCPPECHA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6B1 RID: 63153 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool GLHKGBNIHFH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6B2 RID: 63154 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool EKHOOPGPPGE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600F6B3 RID: 63155 RVA: 0x0055140C File Offset: 0x0054F60C
		internal bool PBCAHKDLFPE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x04001B53 RID: 6995
		internal string JMMILEFMACB;
	}
}
