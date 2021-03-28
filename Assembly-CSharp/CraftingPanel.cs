using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003A6 RID: 934
public class CraftingPanel : MonoBehaviour
{
	// Token: 0x0600D17C RID: 53628 RVA: 0x0002523B File Offset: 0x0002343B
	private void IHLMNAGPKDA()
	{
	}

	// Token: 0x0600D17D RID: 53629 RVA: 0x004AFF40 File Offset: 0x004AE140
	public void ResolveRecipe()
	{
		bool flag = false;
		bool flag2 = false;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			if (this.IsRecipesEquals(itemRecipe.itemsInRecipe, this.GetCurrentCraftRecipe()))
			{
				this.CDBHAGGKAFJ(itemRecipe.itemID, true);
				if (!flag)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.CDBHAGGKAFJ(0UL, false);
		}
	}

	// Token: 0x0600D17E RID: 53630 RVA: 0x004AFFE8 File Offset: 0x004AE1E8
	public List<SteamInventoryItem> HPDJMHGOLPH()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D180 RID: 53632 RVA: 0x004B002C File Offset: 0x004AE22C
	public void ELELIMNECEI()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.BCBKFFJNMCM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(539f, 949f, 1603f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)itemRecipe.itemID) ? this.FHDHFHENJAP(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "_Distortion";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[3];
				array[1] = text2;
				array[1] = " not exist";
				array[1] = text;
				array[7] = "IntraTime";
				array[7] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "maps." + LocalizationService.Instance.HOPMEAJKPHL("turn: {0:0}") + "received</b>\n#reason: ";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("#ok").ToUpper() : LocalizationService.Instance.GetTextByKey(",").ToUpper());
	}

	// Token: 0x0600D181 RID: 53633 RVA: 0x004B0314 File Offset: 0x004AE514
	private void DLHAGIJANEP(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D182 RID: 53634 RVA: 0x004B0329 File Offset: 0x004AE529
	private bool EHNALDIFAII(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D183 RID: 53635 RVA: 0x004B033C File Offset: 0x004AE53C
	public bool EFEBBAEPDNN(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D184 RID: 53636 RVA: 0x004B03D8 File Offset: 0x004AE5D8
	public void GPHOEOKGGAD()
	{
		base.StartCoroutine(this.ADFBIIGOKHE(this.HPDJMHGOLPH()));
	}

	// Token: 0x0600D185 RID: 53637 RVA: 0x004B03F0 File Offset: 0x004AE5F0
	public List<CraftingPanel.ItemRecipe.ItemEntrance> GBDMNFFIEJK()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.HPDJMHGOLPH().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.IKMOFMJNEPH)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.IDNGNCHMCGH()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.BCDAGGDDADL)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D186 RID: 53638 RVA: 0x004B04B0 File Offset: 0x004AE6B0
	private string EMADDABJGBA(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.GetTextByKey("menu.playedpage").ToUpper();
		}
		if (EEBCDMFNKLH == 165UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("finished").ToUpper();
		}
		if (EEBCDMFNKLH == 132UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("HandsCountSlider").ToUpper();
		}
		if (EEBCDMFNKLH != 99UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/AAA_BloodOnScreen").ToUpper();
	}

	// Token: 0x0600D187 RID: 53639 RVA: 0x004B0548 File Offset: 0x004AE748
	public List<CraftingPanel.ItemRecipe.ItemEntrance> CIPIBEPNCMI()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.BBAHPFJLIDD().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.IGFOBPKFCDJ)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.PHLNGGADEON()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.BCDAGGDDADL)).count += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D188 RID: 53640 RVA: 0x004B0608 File Offset: 0x004AE808
	public List<CraftingPanel.ItemRecipe.ItemEntrance> MEKEDHBFAAM()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.BBAHPFJLIDD().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.HKPGGBDEHAM)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.GFJEJMHAMFB()), 0));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.HMMBBDJNGGL)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D189 RID: 53641 RVA: 0x004B06C8 File Offset: 0x004AE8C8
	public void LNELMBKPMJL()
	{
		base.StartCoroutine(this.IDPLIMFICJH(this.HPDJMHGOLPH()));
	}

	// Token: 0x0600D18A RID: 53642 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600D18B RID: 53643 RVA: 0x004B0314 File Offset: 0x004AE514
	private void PMAJKOOEDOJ(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D18C RID: 53644 RVA: 0x004B06E0 File Offset: 0x004AE8E0
	private IEnumerator ADFBIIGOKHE(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem steamInventoryItem in CBGCPECMDFL)
		{
			wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
			wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW www = new WWW(url, data);
		yield return www;
		string text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D18D RID: 53645 RVA: 0x004B0702 File Offset: 0x004AE902
	public void NCGHMODHDDC()
	{
		base.StartCoroutine(this.IAMNPCFCKEJ(this.JGNPONJHPJD()));
	}

	// Token: 0x0600D18E RID: 53646 RVA: 0x004B0329 File Offset: 0x004AE529
	private bool CKEDIKECPON(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D18F RID: 53647 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIMMMCJFMAB()
	{
	}

	// Token: 0x0600D190 RID: 53648 RVA: 0x004B0718 File Offset: 0x004AE918
	private IEnumerator KJBABMAAKBG(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D191 RID: 53649 RVA: 0x004B073C File Offset: 0x004AE93C
	public List<SteamInventoryItem> BBAHPFJLIDD()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D192 RID: 53650 RVA: 0x004B0780 File Offset: 0x004AE980
	public List<SteamInventoryItem> JGNPONJHPJD()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D193 RID: 53651 RVA: 0x004B07C4 File Offset: 0x004AE9C4
	public List<CraftingPanel.ItemRecipe.ItemEntrance> PHOOEHIKAOD()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.HPDJMHGOLPH().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.BKNHHGBPLGH)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.OGPGACCIIJG()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.BFNOHOLLLHB)).count += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D194 RID: 53652 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600D195 RID: 53653 RVA: 0x004B0884 File Offset: 0x004AEA84
	public void OEDJOJNHCJF()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(721f, 1517f, 144f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)itemRecipe.itemID) ? this.JLNHJKBCMOC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "ConnectUsingSettings() disabled the offline mode. No longer offline.";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.OFCDOHFMFAA().Count < (int)itemEntrance.item) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[5];
				array[0] = text2;
				array[0] = ":";
				array[5] = text;
				array[2] = "System.Boolean";
				array[3] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "/icon" + LocalizationService.Instance.GetLocalizatedText("HighScaleShot") + "^";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("CheckResources () for ").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("#roomname").ToUpper());
	}

	// Token: 0x0600D196 RID: 53654 RVA: 0x004B0B6C File Offset: 0x004AED6C
	public void AHGCKEPGILI()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.BCBKFFJNMCM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(628f, 1144f, 1475f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "CameraFilterPack/Blend2Camera_HardMix";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.JLNHJKBCMOC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[3];
				array[1] = text2;
				array[1] = "tagElement";
				array[1] = text;
				array[8] = "_Value2";
				array[0] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "CameraFilterPack_Glasses_On6" + LocalizationService.Instance.GetLocalizatedText("SUBMIT") + "RecordButton";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("_Distortion").ToUpper() : LocalizationService.Instance.GetTextByKey("player.blackcat").ToUpper());
	}

	// Token: 0x0600D197 RID: 53655 RVA: 0x004B0E54 File Offset: 0x004AF054
	private IEnumerator KEDJCDHBMKO(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D198 RID: 53656 RVA: 0x004B0E78 File Offset: 0x004AF078
	public bool HFKLBLKFOHD(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D199 RID: 53657 RVA: 0x004B0329 File Offset: 0x004AE529
	private bool GJFPLFABLHH(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D19A RID: 53658 RVA: 0x004B0F14 File Offset: 0x004AF114
	public bool GLPIPPGPJMG(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D19B RID: 53659 RVA: 0x004B0329 File Offset: 0x004AE529
	private bool PGEGCOAKIDE(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D19C RID: 53660 RVA: 0x004B0FB0 File Offset: 0x004AF1B0
	public void EFEONCCCKNP()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.LGGNNFBLJFC();
		}
		Debug.Log("_FixDistance");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.NOCDKAPEIHD(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(451f, 1746f, 694f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.JAAIGMFHODM().Find(new Predicate<SteamInventoryItem>(this.PDONELCOCOA)), 1);
			gameObject2.GetComponent<Button>().enabled = true;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.IPMMEMNBGNL(-1, null);
	}

	// Token: 0x0600D19D RID: 53661 RVA: 0x004B10E4 File Offset: 0x004AF2E4
	public void NAAINJDKIAC()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.BCBKFFJNMCM())
		{
			if (this.HFKLBLKFOHD(itemRecipe.itemsInRecipe, this.GBDMNFFIEJK()))
			{
				this.PMAJKOOEDOJ(itemRecipe.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = false;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.PMAJKOOEDOJ(1UL, false);
		}
	}

	// Token: 0x0600D19E RID: 53662 RVA: 0x004B118C File Offset: 0x004AF38C
	public void FKGNCKCJDKC()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.BGAOAALHGIG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1475f, 572f, 405f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)itemRecipe.itemID) ? this.FHDHFHENJAP(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "_TimeX";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)itemEntrance.item) ? this.AMAECAPOBGM(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[3];
				array[0] = text2;
				array[0] = "_Value2";
				array[6] = text;
				array[2] = "/";
				array[3] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "<command>" + LocalizationService.Instance.GetLocalizatedText("_RgbDepthTex") + " - Contains ";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("Texture3").ToUpper() : LocalizationService.Instance.GetTextByKey("z").ToUpper());
	}

	// Token: 0x0600D19F RID: 53663 RVA: 0x004B1474 File Offset: 0x004AF674
	public bool FHDNDBNLOGJ(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D1A0 RID: 53664 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600D1A1 RID: 53665 RVA: 0x004B1510 File Offset: 0x004AF710
	private IEnumerator PAFKBBIPEAA(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D1A2 RID: 53666 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x0600D1A3 RID: 53667 RVA: 0x004B0329 File Offset: 0x004AE529
	private bool MOJNDGPFBMJ(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D1A4 RID: 53668 RVA: 0x004B1534 File Offset: 0x004AF734
	public List<CraftingPanel.ItemRecipe.ItemEntrance> IHKCANEHGEM()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.BBAHPFJLIDD().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.BJMAIJDIKCN)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.GetItemInventoryID()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.JPGFOBNOBKN)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D1A5 RID: 53669 RVA: 0x004B15F4 File Offset: 0x004AF7F4
	public void KBNNGBDKPPF()
	{
		base.StartCoroutine(this.PAFKBBIPEAA(this.BBAHPFJLIDD()));
	}

	// Token: 0x0600D1A6 RID: 53670 RVA: 0x004B160C File Offset: 0x004AF80C
	public void MPJGKJGHMPB()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.BGAOAALHGIG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(470f, 37f, 929f);
			string str = (itemRecipe.itemID == 1UL || Singleton<ItemsHandler>.Instance.OFCDOHFMFAA().Count < (int)itemRecipe.itemID) ? this.BELNJNHEHPF(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "_TimeX";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)itemEntrance.item) ? this.JLNHJKBCMOC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[0];
				array[0] = text2;
				array[0] = "CameraFilterPack/TV_MovieNoise";
				array[2] = text;
				array[6] = "CameraFilterPack/Gradients_ElectricGradient";
				array[8] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "GhostFade2" + LocalizationService.Instance.HOPMEAJKPHL("12") + "CameraFilterPack_Paper3";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("_Value3").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD(" cannot be used as a 3D LUT.").ToUpper());
	}

	// Token: 0x0600D1A7 RID: 53671 RVA: 0x004B18F4 File Offset: 0x004AFAF4
	private IEnumerator CMDEGDCLMFO(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D1A8 RID: 53672 RVA: 0x004B1918 File Offset: 0x004AFB18
	public void EPDCHKECMBL()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("Event Received");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1914f, 1964f, 1958f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.IONIEFDFING().Find(new Predicate<SteamInventoryItem>(this.MOJNDGPFBMJ)), 0);
			gameObject2.GetComponent<Button>().enabled = true;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.NNNCEGFJLOB(-1, null);
	}

	// Token: 0x0600D1A9 RID: 53673 RVA: 0x004B1A4C File Offset: 0x004AFC4C
	private IEnumerator IDPLIMFICJH(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D1AA RID: 53674 RVA: 0x004B1A70 File Offset: 0x004AFC70
	public bool IsRecipesEquals(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	// Token: 0x0600D1AB RID: 53675 RVA: 0x004B1B0C File Offset: 0x004AFD0C
	public void HCCJDABGHCJ()
	{
		base.StartCoroutine(this.KJBABMAAKBG(this.JGNPONJHPJD()));
	}

	// Token: 0x0600D1AC RID: 53676 RVA: 0x004B0314 File Offset: 0x004AE514
	private void CDBHAGGKAFJ(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		this.currentItem = EEBCDMFNKLH;
		this.craftButton.interactable = DPGDIPKHEAN;
	}

	// Token: 0x0600D1AD RID: 53677 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x0600D1AE RID: 53678 RVA: 0x004B1B24 File Offset: 0x004AFD24
	public void Init()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("[CraftingPanel] Init");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 0UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().Find(new Predicate<SteamInventoryItem>(this.HLIPOKKEOHB)), 1);
			gameObject2.GetComponent<Button>().enabled = false;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
	}

	// Token: 0x0600D1AF RID: 53679 RVA: 0x004B0329 File Offset: 0x004AE529
	[CompilerGenerated]
	private bool HLIPOKKEOHB(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D1B0 RID: 53680 RVA: 0x004B1C55 File Offset: 0x004AFE55
	public void CraftItem()
	{
		base.StartCoroutine(this.CNLGHPNAACK(this.GetCurrentCraftngItems()));
	}

	// Token: 0x0600D1B1 RID: 53681 RVA: 0x004B1C6C File Offset: 0x004AFE6C
	public List<CraftingPanel.ItemRecipe.ItemEntrance> NIHFFILHCKA()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.JGNPONJHPJD().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.MOJKEOEEEDF)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.ENJDAADCONN()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.HMMBBDJNGGL)).count += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D1B2 RID: 53682 RVA: 0x004B1D2C File Offset: 0x004AFF2C
	public List<SteamInventoryItem> GetCurrentCraftngItems()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (InventoryListElementButton inventoryListElementButton in this.inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>())
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	// Token: 0x0600D1B3 RID: 53683 RVA: 0x004B1D70 File Offset: 0x004AFF70
	public List<CraftingPanel.ItemRecipe> BGAOAALHGIG()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			string value = keyValuePair.Value;
			char[] array = new char[1];
			array[1] = (char)-31;
			string[] array2 = value.Split(array);
			for (int i = 1; i < array2.Length; i++)
			{
				string text = array2[i];
				char[] array3 = new char[0];
				array3[0] = 'w';
				string[] array4 = text.Split(array3);
				int hohoipheopn = 1;
				if (array4.Length > 1)
				{
					hohoipheopn = int.Parse(array4[0]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array4[1]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D1B4 RID: 53684 RVA: 0x004B1E5C File Offset: 0x004B005C
	private IEnumerator IAMNPCFCKEJ(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D1B5 RID: 53685 RVA: 0x004B1E80 File Offset: 0x004B0080
	private string FHDHFHENJAP(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.IAAEBJKAHDD(" isInactive: ").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551570UL)
		{
			return LocalizationService.Instance.HOPMEAJKPHL("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551509UL)
		{
			return LocalizationService.Instance.HOPMEAJKPHL("#").ToUpper();
		}
		if (EEBCDMFNKLH != 18446744073709551498UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
	}

	// Token: 0x0600D1B6 RID: 53686 RVA: 0x004B1F18 File Offset: 0x004B0118
	public void HIFIIGFIMFA()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.BGAOAALHGIG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1037f, 477f, 45f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.JLNHJKBCMOC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "team";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.OFCDOHFMFAA().Count < (int)itemEntrance.item) ? this.JLNHJKBCMOC(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[7];
				array[1] = text2;
				array[1] = "Please specify a map name or buildID";
				array[5] = text;
				array[7] = "Joystick1Button11";
				array[1] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_Value5" + LocalizationService.Instance.HOPMEAJKPHL("CrosshairOpacitySlider") + "OK";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("NEW_ACHIEVEMENT_1_").ToUpper() : LocalizationService.Instance.GetTextByKey("SelectorMusicToggle").ToUpper());
	}

	// Token: 0x0600D1B7 RID: 53687 RVA: 0x004B2200 File Offset: 0x004B0400
	public void JEHJFILKPLL()
	{
		base.StartCoroutine(this.CNLGHPNAACK(this.BBAHPFJLIDD()));
	}

	// Token: 0x0600D1B8 RID: 53688 RVA: 0x004B2218 File Offset: 0x004B0418
	private IEnumerator FAAFFKDGLLB(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D1B9 RID: 53689 RVA: 0x004B223C File Offset: 0x004B043C
	public List<CraftingPanel.ItemRecipe.ItemEntrance> ILJPHLBDAIN()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.JGNPONJHPJD().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.JKEDCEOCPJO)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.FJLPLLHNGOA()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.HNMFCOHLALO)).count += 0;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D1BA RID: 53690 RVA: 0x004B22FC File Offset: 0x004B04FC
	public void ShowRecipes()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + ":\n";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.DDDNMEKCHHD(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				componentInChildren.text = string.Concat(new object[]
				{
					text2,
					"\"",
					text,
					"\"x",
					itemEntrance.count
				});
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 1] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + " " + LocalizationService.Instance.GetLocalizatedText("#or") + " ";
				}
			}
		}
		this.recipesPanel.SetActive(!this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("recipes").ToUpper() : LocalizationService.Instance.GetTextByKey("close").ToUpper());
	}

	// Token: 0x0600D1BB RID: 53691 RVA: 0x004B25E4 File Offset: 0x004B07E4
	private string DDDNMEKCHHD(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.GetTextByKey("randomdrop").ToUpper();
		}
		if (EEBCDMFNKLH == 1000UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("#random #common #item").ToUpper();
		}
		if (EEBCDMFNKLH == 2000UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("#random #rare #item").ToUpper();
		}
		if (EEBCDMFNKLH != 3000UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.GetLocalizatedText("#random #epic #item").ToUpper();
	}

	// Token: 0x0600D1BC RID: 53692 RVA: 0x004B267C File Offset: 0x004B087C
	private IEnumerator AEOJOCFOOIH(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D1BD RID: 53693 RVA: 0x004B26A0 File Offset: 0x004B08A0
	private string JLNHJKBCMOC(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.GetTextByKey("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.").ToUpper();
		}
		if (EEBCDMFNKLH == 127UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551508UL)
		{
			return LocalizationService.Instance.HOPMEAJKPHL("/").ToUpper();
		}
		if (EEBCDMFNKLH != 18446744073709551454UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution").ToUpper();
	}

	// Token: 0x0600D1BE RID: 53694 RVA: 0x004B2738 File Offset: 0x004B0938
	public List<CraftingPanel.ItemRecipe> GetAllRecipes()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			string[] array = keyValuePair.Value.Split(new char[]
			{
				';'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(new char[]
				{
					'x'
				});
				int hohoipheopn = 1;
				if (array2.Length > 1)
				{
					hohoipheopn = int.Parse(array2[1]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array2[0]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D1BF RID: 53695 RVA: 0x0002523B File Offset: 0x0002343B
	private void PMPKMGKAAJH()
	{
	}

	// Token: 0x0600D1C0 RID: 53696 RVA: 0x004B2824 File Offset: 0x004B0A24
	public bool IIGAPCFJKNF(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D1C1 RID: 53697 RVA: 0x004B28C0 File Offset: 0x004B0AC0
	public List<CraftingPanel.ItemRecipe> NFDHLPAMGFN()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			string value = keyValuePair.Value;
			char[] array = new char[0];
			array[0] = (char)-54;
			string[] array2 = value.Split(array);
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(new char[]
				{
					'a'
				});
				int hohoipheopn = 0;
				if (array3.Length > 0)
				{
					hohoipheopn = int.Parse(array3[0]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array3[0]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D1C2 RID: 53698 RVA: 0x004B29AC File Offset: 0x004B0BAC
	public List<CraftingPanel.ItemRecipe.ItemEntrance> GetCurrentCraftRecipe()
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		using (List<SteamInventoryItem>.Enumerator enumerator = this.GetCurrentCraftngItems().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CraftingPanel.LEGBIGPINGP legbigpingp = new CraftingPanel.LEGBIGPINGP();
				legbigpingp.DBIMJHMKHNK = enumerator.Current;
				if (list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.GBKBDKHPLKG)) == null)
				{
					list.Add(new CraftingPanel.ItemRecipe.ItemEntrance((ulong)((long)legbigpingp.DBIMJHMKHNK.item.GetItemInventoryID()), 1));
				}
				else
				{
					list.Find(new Predicate<CraftingPanel.ItemRecipe.ItemEntrance>(legbigpingp.HMMBBDJNGGL)).count++;
				}
			}
		}
		return list;
	}

	// Token: 0x0600D1C3 RID: 53699 RVA: 0x004B2A6C File Offset: 0x004B0C6C
	public bool ELBENDFGPGA(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D1C4 RID: 53700 RVA: 0x004B2B08 File Offset: 0x004B0D08
	private IEnumerator CNLGHPNAACK(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		enumerator = CBGCPECMDFL.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				SteamInventoryItem steamInventoryItem = enumerator.Current;
				wwwform.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + steamInventoryItem.steamid);
				wwwform.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(steamInventoryItem) + "]", string.Empty + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		wwwform.AddField("outputitemdefid", string.Empty + this.currentItem);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		www = new WWW(url, data);
		yield return www;
		text = www.text;
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
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null, true, false, 0f);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			this.lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
		yield break;
	}

	// Token: 0x0600D1C5 RID: 53701 RVA: 0x004B2B2C File Offset: 0x004B0D2C
	public bool CENAFLDOKJG(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D1C6 RID: 53702 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600D1C7 RID: 53703 RVA: 0x004B2BC8 File Offset: 0x004B0DC8
	private string BELNJNHEHPF(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.GetTextByKey("Set satellite trail length in seconds").ToUpper();
		}
		if (EEBCDMFNKLH == 70UL)
		{
			return LocalizationService.Instance.HOPMEAJKPHL("_Value3").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551439UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("_Offsets").ToUpper();
		}
		if (EEBCDMFNKLH != 18446744073709551608UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Color_Switching").ToUpper();
	}

	// Token: 0x0600D1C8 RID: 53704 RVA: 0x004B2C60 File Offset: 0x004B0E60
	public void GCNKIJDNPMD()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.LGGNNFBLJFC();
		}
		Debug.Log("_MainTex2");
		GameObject gameObject = this.inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		this.craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.POHIPKCFJKI(this.craftingItem, this.craftableItemsContent);
		if (this.lastCrafted > 1UL)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(this.historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1885f, 385f, 1979f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.LHKFIGPJKLK().Find(new Predicate<SteamInventoryItem>(this.EHNALDIFAII)), 1);
			gameObject2.GetComponent<Button>().enabled = false;
			this.lastCrafted = 0UL;
		}
		Singleton<MessageBoxPanel>.Instance.KOKMKCJONBG(-1, null);
	}

	// Token: 0x0600D1C9 RID: 53705 RVA: 0x004B2D94 File Offset: 0x004B0F94
	public List<CraftingPanel.ItemRecipe> BCBKFFJNMCM()
	{
		List<CraftingPanel.ItemRecipe> list = new List<CraftingPanel.ItemRecipe>();
		foreach (KeyValuePair<ulong, string> keyValuePair in ItemsHandler.craftRecipes)
		{
			CraftingPanel.ItemRecipe itemRecipe = new CraftingPanel.ItemRecipe(keyValuePair.Key);
			string[] array = keyValuePair.Value.Split(new char[]
			{
				'3'
			});
			for (int i = 1; i < array.Length; i++)
			{
				string text = array[i];
				char[] array2 = new char[0];
				array2[1] = '\f';
				string[] array3 = text.Split(array2);
				int hohoipheopn = 1;
				if (array3.Length > 1)
				{
					hohoipheopn = int.Parse(array3[1]);
				}
				itemRecipe.itemsInRecipe.Add(new CraftingPanel.ItemRecipe.ItemEntrance(ulong.Parse(array3[0]), hohoipheopn));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	// Token: 0x0600D1CA RID: 53706 RVA: 0x0002523B File Offset: 0x0002343B
	private void KNBJBNDGCIJ()
	{
	}

	// Token: 0x0600D1CB RID: 53707 RVA: 0x004B2E80 File Offset: 0x004B1080
	public void AFNIHBKKGGI()
	{
		base.StartCoroutine(this.IAMNPCFCKEJ(this.GetCurrentCraftngItems()));
	}

	// Token: 0x0600D1CC RID: 53708 RVA: 0x004B2E98 File Offset: 0x004B1098
	private string AMAECAPOBGM(ulong EEBCDMFNKLH)
	{
		if (EEBCDMFNKLH == 0UL)
		{
			return LocalizationService.Instance.IAAEBJKAHDD("_Value7").ToUpper();
		}
		if (EEBCDMFNKLH == 18446744073709551436UL)
		{
			return LocalizationService.Instance.GetLocalizatedText("maps.").ToUpper();
		}
		if (EEBCDMFNKLH == 144UL)
		{
			return LocalizationService.Instance.GetLocalizatedText(".status").ToUpper();
		}
		if (EEBCDMFNKLH != 169UL)
		{
			return string.Empty;
		}
		return LocalizationService.Instance.HOPMEAJKPHL("Trackpad").ToUpper();
	}

	// Token: 0x0600D1CD RID: 53709 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x0600D1CE RID: 53710 RVA: 0x004B2F30 File Offset: 0x004B1130
	public bool CMFMIKHOOIP(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x0600D1CF RID: 53711 RVA: 0x004B0329 File Offset: 0x004AE529
	private bool BKOCICOJLBO(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D1D0 RID: 53712 RVA: 0x004B2FCC File Offset: 0x004B11CC
	public void EIBEKECJFKO()
	{
		GameObject gameObject = this.recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1273f, 1820f, 1449f);
			string str = (itemRecipe.itemID == 0UL || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemRecipe.itemID) ? this.AMAECAPOBGM(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemRecipe.itemID].name;
			gameObject2.GetComponentInChildren<Text>().text = str + "icon.png";
			foreach (CraftingPanel.ItemRecipe.ItemEntrance itemEntrance in itemRecipe.itemsInRecipe)
			{
				string text = (Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)itemEntrance.item) ? this.BELNJNHEHPF(itemRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)itemEntrance.item].name;
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text2 = componentInChildren.text;
				object[] array = new object[]
				{
					text2,
					".completedMaps",
					null,
					null,
					text
				};
				array[3] = "play";
				array[5] = itemEntrance.count;
				componentInChildren.text = string.Concat(array);
				if (itemRecipe.itemsInRecipe[itemRecipe.itemsInRecipe.Count - 0] != itemEntrance)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_TimeX" + LocalizationService.Instance.GetLocalizatedText("\n - NetID: ") + "\" call.";
				}
			}
		}
		this.recipesPanel.SetActive(this.recipesPanel.activeSelf);
		this.openRecipesButton.text = ((!this.recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("Prints list of commands").ToUpper() : LocalizationService.Instance.GetTextByKey("hidden").ToUpper());
	}

	// Token: 0x0600D1D1 RID: 53713 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMMDPANNAIO()
	{
	}

	// Token: 0x0600D1D2 RID: 53714 RVA: 0x004B32B4 File Offset: 0x004B14B4
	public void PPOCCAEOONC()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (CraftingPanel.ItemRecipe itemRecipe in this.BCBKFFJNMCM())
		{
			if (this.CMFMIKHOOIP(itemRecipe.itemsInRecipe, this.MEKEDHBFAAM()))
			{
				this.PMAJKOOEDOJ(itemRecipe.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			this.CDBHAGGKAFJ(1UL, true);
		}
	}

	// Token: 0x0600D1D3 RID: 53715 RVA: 0x004B0329 File Offset: 0x004AE529
	private bool PDONELCOCOA(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == this.lastCrafted;
	}

	// Token: 0x0600D1D4 RID: 53716 RVA: 0x004B335C File Offset: 0x004B155C
	public bool KJCHJOONNJO(List<CraftingPanel.ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<CraftingPanel.ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<CraftingPanel.ItemRecipe.ItemEntrance> list = new List<CraftingPanel.ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = true;
		bool flag3 = true;
		foreach (CraftingPanel.ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	// Token: 0x04001804 RID: 6148
	public GameObject craftableItemsContent;

	// Token: 0x04001805 RID: 6149
	public GameObject inCraftingItemsContent;

	// Token: 0x04001806 RID: 6150
	public GameObject craftingItem;

	// Token: 0x04001807 RID: 6151
	public GameObject historyContent;

	// Token: 0x04001808 RID: 6152
	public GameObject recipesPanel;

	// Token: 0x04001809 RID: 6153
	public Text openRecipesButton;

	// Token: 0x0400180A RID: 6154
	public GameObject recipesContent;

	// Token: 0x0400180B RID: 6155
	public GameObject recipeElement;

	// Token: 0x0400180C RID: 6156
	public Button craftButton;

	// Token: 0x0400180D RID: 6157
	public ulong currentItem;

	// Token: 0x0400180E RID: 6158
	public ulong lastCrafted;

	// Token: 0x0400180F RID: 6159
	private SteamInventoryResult_t FNMADDPJCLB;

	// Token: 0x020003A7 RID: 935
	public class ItemRecipe
	{
		// Token: 0x0600D1D5 RID: 53717 RVA: 0x004B33F8 File Offset: 0x004B15F8
		public ItemRecipe(ulong EEBCDMFNKLH)
		{
			this.itemID = EEBCDMFNKLH;
		}

		// Token: 0x04001810 RID: 6160
		public ulong itemID;

		// Token: 0x04001811 RID: 6161
		public List<CraftingPanel.ItemRecipe.ItemEntrance> itemsInRecipe = new List<CraftingPanel.ItemRecipe.ItemEntrance>();

		// Token: 0x020003A8 RID: 936
		public class ItemEntrance
		{
			// Token: 0x0600D1D6 RID: 53718 RVA: 0x004B3414 File Offset: 0x004B1614
			public virtual bool CCMGFFBHIGG(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1D7 RID: 53719 RVA: 0x004B344C File Offset: 0x004B164C
			public virtual bool BLJHKDAHFHL(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1D8 RID: 53720 RVA: 0x004B3484 File Offset: 0x004B1684
			public virtual bool IEFMFMFGMDH(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item != itemEntrance.item || this.count == itemEntrance.count;
			}

			// Token: 0x0600D1D9 RID: 53721 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int DNMJNLAEBKP()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1DA RID: 53722 RVA: 0x004B34C4 File Offset: 0x004B16C4
			public virtual bool INDANPJEICH(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1DB RID: 53723 RVA: 0x004B34FA File Offset: 0x004B16FA
			public ItemEntrance(ulong DBIMJHMKHNK, int HOHOIPHEOPN)
			{
				this.item = DBIMJHMKHNK;
				this.count = HOHOIPHEOPN;
			}

			// Token: 0x0600D1DC RID: 53724 RVA: 0x004B3510 File Offset: 0x004B1710
			public virtual bool ILLAEPFOHCJ(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item != itemEntrance.item || this.count == itemEntrance.count;
			}

			// Token: 0x0600D1DD RID: 53725 RVA: 0x004B3548 File Offset: 0x004B1748
			public virtual bool FAEELIPGIBL(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1DE RID: 53726 RVA: 0x004B3580 File Offset: 0x004B1780
			public virtual bool HELLBLOBANP(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1DF RID: 53727 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int NCBGPMCHGNK()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E0 RID: 53728 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int CHPGJMEKKLM()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E1 RID: 53729 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int HPGDGGOJIGC()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E2 RID: 53730 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int EFLNBBEIGOH()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E3 RID: 53731 RVA: 0x004B35B8 File Offset: 0x004B17B8
			public virtual bool NLEHLDCJEIA(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1E4 RID: 53732 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int LLAFDKINFOM()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E5 RID: 53733 RVA: 0x004B35F0 File Offset: 0x004B17F0
			public virtual bool EEFJNKBILLG(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1E6 RID: 53734 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int COHDDOPMJNE()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E7 RID: 53735 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int OFIPAKGBICP()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E8 RID: 53736 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int EILFHBAOEJF()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1E9 RID: 53737 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int MJFJPBFMLKO()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1EA RID: 53738 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int GBJCILCHOLK()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1EB RID: 53739 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int KJLPMPBLGND()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1EC RID: 53740 RVA: 0x004B3628 File Offset: 0x004B1828
			public virtual bool JHCGGHMMEDK(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item != itemEntrance.item || this.count == itemEntrance.count;
			}

			// Token: 0x0600D1ED RID: 53741 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int APDIKIFPAEB()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1EE RID: 53742 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int MKAMCNNMDIG()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1EF RID: 53743 RVA: 0x004B3660 File Offset: 0x004B1860
			public virtual bool DAPGPBONOFL(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1F0 RID: 53744 RVA: 0x004B3698 File Offset: 0x004B1898
			public override bool Equals(object AGPIGANJKMN)
			{
				CraftingPanel.ItemRecipe.ItemEntrance itemEntrance = (CraftingPanel.ItemRecipe.ItemEntrance)AGPIGANJKMN;
				return this.item == itemEntrance.item && this.count == itemEntrance.count;
			}

			// Token: 0x0600D1F1 RID: 53745 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int BDMNEHBJNLM()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1F2 RID: 53746 RVA: 0x004B34BA File Offset: 0x004B16BA
			public virtual int PPEHIDGIAKH()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600D1F3 RID: 53747 RVA: 0x004B34BA File Offset: 0x004B16BA
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x04001812 RID: 6162
			public ulong item;

			// Token: 0x04001813 RID: 6163
			public int count;
		}
	}

	// Token: 0x020003A9 RID: 937
	[CompilerGenerated]
	private sealed class LEGBIGPINGP
	{
		// Token: 0x0600D1F4 RID: 53748 RVA: 0x004B36CE File Offset: 0x004B18CE
		internal bool FJDBPPKABJE(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		// Token: 0x0600D1F5 RID: 53749 RVA: 0x004B36E9 File Offset: 0x004B18E9
		internal bool KGKMOLCPDIH(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		// Token: 0x0600D1F6 RID: 53750 RVA: 0x004B3704 File Offset: 0x004B1904
		internal bool IGFOBPKFCDJ(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.LDEFHDDBACF();
		}

		// Token: 0x0600D1F7 RID: 53751 RVA: 0x004B371F File Offset: 0x004B191F
		internal bool LNDGINDKPFA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IDNGNCHMCGH();
		}

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x004B373A File Offset: 0x004B193A
		internal bool AKDOOLPMPMG(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x004B36CE File Offset: 0x004B18CE
		internal bool PLINPGHDODA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		// Token: 0x0600D1FA RID: 53754 RVA: 0x004B3755 File Offset: 0x004B1955
		internal bool FKCDLJELMNN(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		// Token: 0x0600D1FB RID: 53755 RVA: 0x004B3770 File Offset: 0x004B1970
		internal bool JDELIMPGFDJ(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IAJKNHICFDA();
		}

		// Token: 0x0600D1FC RID: 53756 RVA: 0x004B378B File Offset: 0x004B198B
		internal bool BKNHHGBPLGH(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.PHLNGGADEON();
		}

		// Token: 0x0600D1FD RID: 53757 RVA: 0x004B37A6 File Offset: 0x004B19A6
		internal bool BOPKCHEPEEB(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.ENJDAADCONN();
		}

		// Token: 0x0600D1FE RID: 53758 RVA: 0x004B37C1 File Offset: 0x004B19C1
		internal bool EEBODGOFEGB(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D1FF RID: 53759 RVA: 0x004B37DC File Offset: 0x004B19DC
		internal bool JKEDCEOCPJO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GEFIGLHEKGA();
		}

		// Token: 0x0600D200 RID: 53760 RVA: 0x004B37F7 File Offset: 0x004B19F7
		internal bool FHFECFLBHMA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		// Token: 0x0600D202 RID: 53762 RVA: 0x004B373A File Offset: 0x004B193A
		internal bool ECGDAHDOPBO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x004B3812 File Offset: 0x004B1A12
		internal bool MFBMMDCIPGG(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IIELGFOOAND();
		}

		// Token: 0x0600D204 RID: 53764 RVA: 0x004B382D File Offset: 0x004B1A2D
		internal bool NGFGLJGABCM(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.CAFEIKLLFFG();
		}

		// Token: 0x0600D205 RID: 53765 RVA: 0x004B3848 File Offset: 0x004B1A48
		internal bool OLIGLEMPFOP(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		// Token: 0x0600D206 RID: 53766 RVA: 0x004B373A File Offset: 0x004B193A
		internal bool OFLDIMDDLHM(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		// Token: 0x0600D207 RID: 53767 RVA: 0x004B36E9 File Offset: 0x004B18E9
		internal bool BCDAGGDDADL(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		// Token: 0x0600D208 RID: 53768 RVA: 0x004B3848 File Offset: 0x004B1A48
		internal bool DFEBIECLKEK(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		// Token: 0x0600D209 RID: 53769 RVA: 0x004B37DC File Offset: 0x004B19DC
		internal bool DBOEBFFAOFJ(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GEFIGLHEKGA();
		}

		// Token: 0x0600D20A RID: 53770 RVA: 0x004B36CE File Offset: 0x004B18CE
		internal bool KFNPHCCAJFD(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		// Token: 0x0600D20B RID: 53771 RVA: 0x004B3755 File Offset: 0x004B1955
		internal bool PKAPLCFHDOC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		// Token: 0x0600D20C RID: 53772 RVA: 0x004B37F7 File Offset: 0x004B19F7
		internal bool HKPGGBDEHAM(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		// Token: 0x0600D20D RID: 53773 RVA: 0x004B371F File Offset: 0x004B191F
		internal bool OFHCGKJFGDI(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IDNGNCHMCGH();
		}

		// Token: 0x0600D20E RID: 53774 RVA: 0x004B3812 File Offset: 0x004B1A12
		internal bool NIFPHAJMPFC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IIELGFOOAND();
		}

		// Token: 0x0600D20F RID: 53775 RVA: 0x004B373A File Offset: 0x004B193A
		internal bool FCAGEDLBBHD(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		// Token: 0x0600D210 RID: 53776 RVA: 0x004B3863 File Offset: 0x004B1A63
		internal bool JPGFOBNOBKN(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GetItemInventoryID();
		}

		// Token: 0x0600D211 RID: 53777 RVA: 0x004B387E File Offset: 0x004B1A7E
		internal bool AHBIANHNBBC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.DMPNOAGIABF();
		}

		// Token: 0x0600D212 RID: 53778 RVA: 0x004B36E9 File Offset: 0x004B18E9
		internal bool BFEABMIFIEE(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x004B3899 File Offset: 0x004B1A99
		internal bool BJMAIJDIKCN(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.PBLNJDFPHJK();
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x004B3704 File Offset: 0x004B1904
		internal bool CHBEFOHEEGK(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.LDEFHDDBACF();
		}

		// Token: 0x0600D215 RID: 53781 RVA: 0x004B3863 File Offset: 0x004B1A63
		internal bool GBKBDKHPLKG(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GetItemInventoryID();
		}

		// Token: 0x0600D216 RID: 53782 RVA: 0x004B3770 File Offset: 0x004B1970
		internal bool LGKMMLGKBEF(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IAJKNHICFDA();
		}

		// Token: 0x0600D217 RID: 53783 RVA: 0x004B3848 File Offset: 0x004B1A48
		internal bool IKMOFMJNEPH(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		// Token: 0x0600D218 RID: 53784 RVA: 0x004B37DC File Offset: 0x004B19DC
		internal bool BFNOHOLLLHB(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GEFIGLHEKGA();
		}

		// Token: 0x0600D219 RID: 53785 RVA: 0x004B37C1 File Offset: 0x004B19C1
		internal bool PHGILLBNBME(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D21A RID: 53786 RVA: 0x004B3770 File Offset: 0x004B1970
		internal bool NJGBIMFOOKP(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IAJKNHICFDA();
		}

		// Token: 0x0600D21B RID: 53787 RVA: 0x004B36CE File Offset: 0x004B18CE
		internal bool EDGAPOPEIJF(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x004B3863 File Offset: 0x004B1A63
		internal bool HMMBBDJNGGL(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GetItemInventoryID();
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x004B3848 File Offset: 0x004B1A48
		internal bool OMJJLDBPEHI(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x004B382D File Offset: 0x004B1A2D
		internal bool BPJGFELFEDC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.CAFEIKLLFFG();
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x004B38B4 File Offset: 0x004B1AB4
		internal bool MOJKEOEEEDF(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.FJLPLLHNGOA();
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x004B37F7 File Offset: 0x004B19F7
		internal bool EKHOOPGPPGE(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		// Token: 0x0600D221 RID: 53793 RVA: 0x004B37F7 File Offset: 0x004B19F7
		internal bool CJDNDHBDMMO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		// Token: 0x0600D222 RID: 53794 RVA: 0x004B38CF File Offset: 0x004B1ACF
		internal bool GEPBCIIDMBC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.OGPGACCIIJG();
		}

		// Token: 0x0600D223 RID: 53795 RVA: 0x004B3863 File Offset: 0x004B1A63
		internal bool DIOBKCECBCH(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.GetItemInventoryID();
		}

		// Token: 0x0600D224 RID: 53796 RVA: 0x004B3755 File Offset: 0x004B1955
		internal bool HNMFCOHLALO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		// Token: 0x0600D225 RID: 53797 RVA: 0x004B37A6 File Offset: 0x004B19A6
		internal bool AGFDCBCBAGI(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.ENJDAADCONN();
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x004B37C1 File Offset: 0x004B19C1
		internal bool EFAPFFFGOOA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x004B37A6 File Offset: 0x004B19A6
		internal bool INHOEMCLAAP(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.ENJDAADCONN();
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x004B387E File Offset: 0x004B1A7E
		internal bool ONEPCCGOEKI(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.DMPNOAGIABF();
		}

		// Token: 0x0600D229 RID: 53801 RVA: 0x004B38EA File Offset: 0x004B1AEA
		internal bool HKCAPINMNFF(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.NGAFDAAEBKC();
		}

		// Token: 0x0600D22A RID: 53802 RVA: 0x004B37C1 File Offset: 0x004B19C1
		internal bool HBJFIOJFBHC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D22B RID: 53803 RVA: 0x004B3905 File Offset: 0x004B1B05
		internal bool BBIADFAPKDL(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IBOFKDGBKIH();
		}

		// Token: 0x0600D22C RID: 53804 RVA: 0x004B36CE File Offset: 0x004B18CE
		internal bool FKHKOGEPNIO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		// Token: 0x0600D22D RID: 53805 RVA: 0x004B3920 File Offset: 0x004B1B20
		internal bool AGJKEBOPIOC(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KPNOHBLJHDJ();
		}

		// Token: 0x0600D22E RID: 53806 RVA: 0x004B3905 File Offset: 0x004B1B05
		internal bool DBFPGFHEGKA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IBOFKDGBKIH();
		}

		// Token: 0x0600D22F RID: 53807 RVA: 0x004B37C1 File Offset: 0x004B19C1
		internal bool PCDFLCEIHFF(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D230 RID: 53808 RVA: 0x004B3848 File Offset: 0x004B1A48
		internal bool HJNKOEGPEMO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		// Token: 0x0600D231 RID: 53809 RVA: 0x004B3755 File Offset: 0x004B1955
		internal bool KFNBKFELFLH(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		// Token: 0x0600D232 RID: 53810 RVA: 0x004B3755 File Offset: 0x004B1955
		internal bool DAICIOGOPNL(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		// Token: 0x0600D233 RID: 53811 RVA: 0x004B373A File Offset: 0x004B193A
		internal bool DFHFAFAJGBA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		// Token: 0x0600D234 RID: 53812 RVA: 0x004B37C1 File Offset: 0x004B19C1
		internal bool CPAOFGMAFAA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		// Token: 0x0600D235 RID: 53813 RVA: 0x004B38EA File Offset: 0x004B1AEA
		internal bool OMBHIBNMFNB(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.NGAFDAAEBKC();
		}

		// Token: 0x0600D236 RID: 53814 RVA: 0x004B373A File Offset: 0x004B193A
		internal bool HCFLGKJFKFE(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		// Token: 0x0600D237 RID: 53815 RVA: 0x004B378B File Offset: 0x004B198B
		internal bool PHFMMNELDEA(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.PHLNGGADEON();
		}

		// Token: 0x0600D238 RID: 53816 RVA: 0x004B3905 File Offset: 0x004B1B05
		internal bool HIHNMOEFONO(CraftingPanel.ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == this.DBIMJHMKHNK.item.IBOFKDGBKIH();
		}

		// Token: 0x04001814 RID: 6164
		internal SteamInventoryItem DBIMJHMKHNK;
	}
}
