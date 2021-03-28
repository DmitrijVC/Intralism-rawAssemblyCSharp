using System;
using System.Collections;
using System.Collections.Generic;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000390 RID: 912
public class ContributorSystem : Singleton<ContributorSystem>
{
	// Token: 0x0600CB67 RID: 52071 RVA: 0x00495A98 File Offset: 0x00493C98
	public IEnumerator LoadContributor(CSteamID JMMILEFMACB)
	{
		if (!this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			WWWForm wwwform = new WWWForm();
			wwwform.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
			wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
			byte[] data = wwwform.data;
			string url = Singleton<GameManager>.Instance.CreateServerURL(this.checkContributorURL);
			WWW www = new WWW(url, data);
			yield return www;
			if (string.IsNullOrEmpty(www.error))
			{
				try
				{
					bool kjpahofpckd = int.Parse(www.text) == 1;
					this.ELOBOMNKFLH(JMMILEFMACB, kjpahofpckd);
				}
				catch (Exception)
				{
				}
			}
		}
		yield break;
	}

	// Token: 0x0600CB68 RID: 52072 RVA: 0x00495ABC File Offset: 0x00493CBC
	public void CMPNNHPGJHA()
	{
		base.StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(this.promoCanvas, false, null, true, 326f, false));
		base.StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(this.managerCanvas, false, null, true, 1955f, false));
	}

	// Token: 0x0600CB69 RID: 52073 RVA: 0x00495B0C File Offset: 0x00493D0C
	public IEnumerator UseTicket(string EEBCDMFNKLH)
	{
		ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		CSteamID steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		WWW www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB6A RID: 52074 RVA: 0x00495B30 File Offset: 0x00493D30
	public IEnumerator HGFILODOJGH(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB6B RID: 52075 RVA: 0x00495B52 File Offset: 0x00493D52
	public void ShowTicketsStore()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Write me to get one for testing :)", "Ok", null, true, false, 0f);
	}

	// Token: 0x0600CB6C RID: 52076 RVA: 0x00495B70 File Offset: 0x00493D70
	private void OFDKGPBLCIL(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CB6D RID: 52077 RVA: 0x00495B70 File Offset: 0x00493D70
	private void ELOBOMNKFLH(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CB6E RID: 52078 RVA: 0x0002523B File Offset: 0x0002343B
	public void JHMFFEAANLI()
	{
	}

	// Token: 0x0600CB6F RID: 52079 RVA: 0x00495BA4 File Offset: 0x00493DA4
	public void PGKLGJABKEA()
	{
		base.StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(this.promoCanvas, false, null, false, 1349f, false));
		base.StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(this.managerCanvas, true, null, false, 80f, true));
	}

	// Token: 0x0600CB70 RID: 52080 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool OBEILGHDEDH(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB71 RID: 52081 RVA: 0x00495C16 File Offset: 0x00493E16
	public bool LIBHPMCCOCC(CSteamID HFEFHOPOLIK)
	{
		return !this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) || Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB72 RID: 52082 RVA: 0x00495C3C File Offset: 0x00493E3C
	public IEnumerator JFGOMIIHHMK(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		ContributorSystem.BLELFKMMOBG.FHMOFKJOILN fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB73 RID: 52083 RVA: 0x00495C6C File Offset: 0x00493E6C
	public IEnumerator AFAOIMHOLJM(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB74 RID: 52084 RVA: 0x00495C8E File Offset: 0x00493E8E
	public void KLLLPJHDFIA()
	{
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC("_TimeX", "ShowTitle", null, false, true, 921f);
	}

	// Token: 0x0600CB75 RID: 52085 RVA: 0x00495B70 File Offset: 0x00493D70
	private void BNJBMOFBHLA(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CB76 RID: 52086 RVA: 0x00495CAC File Offset: 0x00493EAC
	public IEnumerator ANHEADKMODP(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB77 RID: 52087 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool PNPAPDNCGBD(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB78 RID: 52088 RVA: 0x00495CDC File Offset: 0x00493EDC
	public IEnumerator KKHLDFJCIEK(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB79 RID: 52089 RVA: 0x00495B70 File Offset: 0x00493D70
	private void BOGCGCAFIND(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CB7A RID: 52090 RVA: 0x00495D00 File Offset: 0x00493F00
	public IEnumerator GDDMBKGEGCB(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB7B RID: 52091 RVA: 0x00495D24 File Offset: 0x00493F24
	public IEnumerator IBMAAHEAMDD(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB7C RID: 52092 RVA: 0x00495D54 File Offset: 0x00493F54
	public IEnumerator DFGCDGFDABE(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB7D RID: 52093 RVA: 0x00495D78 File Offset: 0x00493F78
	public IEnumerator BGBONLPDHKH(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB7E RID: 52094 RVA: 0x00495B70 File Offset: 0x00493D70
	private void NPFOMCNHJFG(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CB7F RID: 52095 RVA: 0x0002523B File Offset: 0x0002343B
	public void HideTicketsStore()
	{
	}

	// Token: 0x0600CB80 RID: 52096 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool ACIHIGGAFOJ(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB81 RID: 52097 RVA: 0x00495DA8 File Offset: 0x00493FA8
	public IEnumerator NPBGNMMMPNA(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB82 RID: 52098 RVA: 0x0002523B File Offset: 0x0002343B
	public void ODDNPBGMMGE()
	{
	}

	// Token: 0x0600CB83 RID: 52099 RVA: 0x00495DD8 File Offset: 0x00493FD8
	public IEnumerator CJGDDHMOIAA(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB84 RID: 52100 RVA: 0x00495DFC File Offset: 0x00493FFC
	public IEnumerator ALGKENJGNLL()
	{
		yield return base.StartCoroutine(this.LoadContributor(SteamUser.GetSteamID()));
		yield break;
	}

	// Token: 0x0600CB86 RID: 52102 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool MJNEHMLOFJC(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB87 RID: 52103 RVA: 0x00495E40 File Offset: 0x00494040
	public IEnumerator CGKEFHGMKMM(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB88 RID: 52104 RVA: 0x0002523B File Offset: 0x0002343B
	public void CCODGHNACBO()
	{
	}

	// Token: 0x0600CB89 RID: 52105 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool ADOIJJEICFB(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB8A RID: 52106 RVA: 0x00495B70 File Offset: 0x00493D70
	private void DPKFMIJPJIO(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CB8B RID: 52107 RVA: 0x00495E64 File Offset: 0x00494064
	public void CloseViewer()
	{
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, false, null, true, 0.2f, true));
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, false, null, true, 0.2f, true));
	}

	// Token: 0x0600CB8C RID: 52108 RVA: 0x00495EB1 File Offset: 0x004940B1
	public void CMBCFFHONFL()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("x", "_TimeX", null, true, false, 774f);
	}

	// Token: 0x0600CB8D RID: 52109 RVA: 0x00495ED0 File Offset: 0x004940D0
	public IEnumerator MDPJHKECLOF()
	{
		yield return base.StartCoroutine(this.LoadContributor(SteamUser.GetSteamID()));
		yield break;
	}

	// Token: 0x0600CB8E RID: 52110 RVA: 0x00495EEB File Offset: 0x004940EB
	public void DCDFACDDNHC()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL(".g", "ns", null, true, false, 1739f);
	}

	// Token: 0x0600CB8F RID: 52111 RVA: 0x00495C16 File Offset: 0x00493E16
	public bool CHLFPOBDIFO(CSteamID HFEFHOPOLIK)
	{
		return !this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) || Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB90 RID: 52112 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool IDKJFPIKALJ(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB91 RID: 52113 RVA: 0x00495F0C File Offset: 0x0049410C
	public IEnumerator FBCIBNAGIHM(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB92 RID: 52114 RVA: 0x00495F30 File Offset: 0x00494130
	public IEnumerator DAFAFBGFPLM(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB93 RID: 52115 RVA: 0x00495F60 File Offset: 0x00494160
	public IEnumerator LCKKDMKJJEF()
	{
		yield return base.StartCoroutine(this.LoadContributor(SteamUser.GetSteamID()));
		yield break;
	}

	// Token: 0x0600CB94 RID: 52116 RVA: 0x0002523B File Offset: 0x0002343B
	public void HEGJEDHJEFA()
	{
	}

	// Token: 0x0600CB95 RID: 52117 RVA: 0x00495B70 File Offset: 0x00493D70
	private void GFEEMBOFBPA(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CB96 RID: 52118 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool FAGGPADPEGK(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB97 RID: 52119 RVA: 0x00495F7B File Offset: 0x0049417B
	public void JIDMMCCLHBO()
	{
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("workshop.", "_Value", null, true, true, 925f);
	}

	// Token: 0x0600CB98 RID: 52120 RVA: 0x00495F9C File Offset: 0x0049419C
	public IEnumerator POGCJFEDMJK(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB99 RID: 52121 RVA: 0x00495FC0 File Offset: 0x004941C0
	public IEnumerator ShowManager(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB9A RID: 52122 RVA: 0x00495FF0 File Offset: 0x004941F0
	public IEnumerator MDGAFIGCHNF(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB9B RID: 52123 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool BOOHFGEIJCG(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CB9C RID: 52124 RVA: 0x00496014 File Offset: 0x00494214
	public IEnumerator NNKOMICIOBP(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CB9D RID: 52125 RVA: 0x0002523B File Offset: 0x0002343B
	public void OAGFCKCIDKA()
	{
	}

	// Token: 0x0600CB9E RID: 52126 RVA: 0x00496038 File Offset: 0x00494238
	public IEnumerator JMFDJLNMBMO(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CB9F RID: 52127 RVA: 0x00495B70 File Offset: 0x00493D70
	private void BMPOBADLBJD(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CBA0 RID: 52128 RVA: 0x0002523B File Offset: 0x0002343B
	public void FJOJEHBJACA()
	{
	}

	// Token: 0x0600CBA1 RID: 52129 RVA: 0x00495BF1 File Offset: 0x00493DF1
	public bool IsContributor(CSteamID HFEFHOPOLIK)
	{
		return this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) && Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CBA2 RID: 52130 RVA: 0x0002523B File Offset: 0x0002343B
	public void EJOFHDBBDKN()
	{
	}

	// Token: 0x0600CBA3 RID: 52131 RVA: 0x00496068 File Offset: 0x00494268
	public IEnumerator Init()
	{
		yield return base.StartCoroutine(this.LoadContributor(SteamUser.GetSteamID()));
		yield break;
	}

	// Token: 0x0600CBA4 RID: 52132 RVA: 0x00495B70 File Offset: 0x00493D70
	private void IFKPAMCGIGL(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CBA5 RID: 52133 RVA: 0x0002523B File Offset: 0x0002343B
	public void PKCHDIHNDDN()
	{
	}

	// Token: 0x0600CBA6 RID: 52134 RVA: 0x00496084 File Offset: 0x00494284
	public IEnumerator ELIFGJJCPPF(CSteamID JMMILEFMACB)
	{
		if (!this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			wwwform = new WWWForm();
			wwwform.AddField("steamid", string.Empty + JMMILEFMACB.m_SteamID);
			wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
			data = wwwform.data;
			url = Singleton<GameManager>.Instance.CreateServerURL(this.checkContributorURL);
			www = new WWW(url, data);
			yield return www;
			if (string.IsNullOrEmpty(www.error))
			{
				try
				{
					bool kjpahofpckd = int.Parse(www.text) == 1;
					this.ELOBOMNKFLH(JMMILEFMACB, kjpahofpckd);
				}
				catch (Exception)
				{
				}
			}
		}
		yield break;
	}

	// Token: 0x0600CBA7 RID: 52135 RVA: 0x004960A8 File Offset: 0x004942A8
	public IEnumerator KKIAGAGMLPG(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CBA8 RID: 52136 RVA: 0x004960D8 File Offset: 0x004942D8
	public IEnumerator LCJIGDBJEBC(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CBA9 RID: 52137 RVA: 0x0002523B File Offset: 0x0002343B
	public void JEDEKAMHAKF()
	{
	}

	// Token: 0x0600CBAA RID: 52138 RVA: 0x00496108 File Offset: 0x00494308
	public IEnumerator EKNOOKNNLLI(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CBAB RID: 52139 RVA: 0x00496138 File Offset: 0x00494338
	public void NCNGCIEAIIE()
	{
		base.StartCoroutine(Singleton<UI>.Instance.HJEODGHPPAJ(this.promoCanvas, true, null, false, 671f, false));
		base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.managerCanvas, false, null, false, 929f, true));
	}

	// Token: 0x0600CBAC RID: 52140 RVA: 0x00496188 File Offset: 0x00494388
	public IEnumerator PNNDIMLJKDC(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CBAD RID: 52141 RVA: 0x00495C16 File Offset: 0x00493E16
	public bool KCECAOBCGLN(CSteamID HFEFHOPOLIK)
	{
		return !this.HDCCFLLCGOA.ContainsKey(HFEFHOPOLIK) || Singleton<ContributorSystem>.Instance.HDCCFLLCGOA[HFEFHOPOLIK];
	}

	// Token: 0x0600CBAE RID: 52142 RVA: 0x004961AC File Offset: 0x004943AC
	public IEnumerator GGOJMMMAOOA(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CBAF RID: 52143 RVA: 0x00495B70 File Offset: 0x00493D70
	private void BMNLKFEHCHB(CSteamID JMMILEFMACB, bool KJPAHOFPCKD)
	{
		if (this.HDCCFLLCGOA.ContainsKey(JMMILEFMACB))
		{
			this.HDCCFLLCGOA[JMMILEFMACB] = KJPAHOFPCKD;
		}
		else
		{
			this.HDCCFLLCGOA.Add(JMMILEFMACB, KJPAHOFPCKD);
		}
	}

	// Token: 0x0600CBB0 RID: 52144 RVA: 0x004961D0 File Offset: 0x004943D0
	public IEnumerator JIMODLHJFLN(int DLGIPFOEDCF = 0, UnityAction KPCNMGBCOLP = null, string MJDIIKCLBOF = null)
	{
		fhmofkjoiln = new ContributorSystem.BLELFKMMOBG.FHMOFKJOILN();
		fhmofkjoiln.KAJEFPDIIJA = this;
		fhmofkjoiln.MJDIIKCLBOF = MJDIIKCLBOF;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(fhmofkjoiln.GBKBDKHPLKG));
		if (DLGIPFOEDCF == 1)
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.promoCanvas, true, null, true, 0.2f, true));
		}
		else
		{
			yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.managerCanvas, true, null, true, 0.2f, true));
			if (!string.IsNullOrEmpty(fhmofkjoiln.MJDIIKCLBOF))
			{
				yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#useticket", "#no", new UnityAction(fhmofkjoiln.HMMBBDJNGGL), "#yes", new UnityAction(fhmofkjoiln.NEIDGMKKCBI)));
			}
		}
		yield break;
	}

	// Token: 0x0600CBB1 RID: 52145 RVA: 0x00496200 File Offset: 0x00494400
	public IEnumerator GOEMAOAMNLG(string EEBCDMFNKLH)
	{
		kdpimfpgjhm = new ContributorSystem.JGENBOHDKKM.KDPIMFPGJHM();
		kdpimfpgjhm.ELDNJAFHCFE = this;
		kdpimfpgjhm.EEBCDMFNKLH = EEBCDMFNKLH;
		steamID = SteamUser.GetSteamID();
		Debug.Log("Use ticket: " + kdpimfpgjhm.EEBCDMFNKLH);
		this.CloseViewer();
		Singleton<MessageBoxPanel>.Instance.Close(-1, null);
		yield return true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Updating...", "PLEASE WAIT", null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("steamid", string.Empty + steamID.m_SteamID);
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("itemid", kdpimfpgjhm.EEBCDMFNKLH);
		wwwform.AddField("quantity", 1);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.redeemTicketURL);
		www = new WWW(url, data);
		yield return www;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
				if (ContributorSystem.JGENBOHDKKM.LNIJKGECNME == null)
				{
					ContributorSystem.JGENBOHDKKM.LNIJKGECNME = new Func<bool>(ContributorSystem.JGENBOHDKKM.GBKBDKHPLKG);
				}
				yield return new WaitWhile(ContributorSystem.JGENBOHDKKM.LNIJKGECNME);
				yield return base.StartCoroutine(this.LoadContributor(steamID));
				if (Singleton<Scene>.Instance.id == "MenuScene")
				{
					((MenuScene)Singleton<Scene>.Instance).pInfo.contributorGO.SetActive(this.IsContributor(steamID));
				}
				if (Singleton<InventorySelector>.Instance.IsActive())
				{
					Singleton<InventorySelector>.Instance.SwichCategory(4);
				}
				if (this.IsContributor(SteamUser.GetSteamID()))
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("Done! You are a contributor until: " + www.text, "ok", null, true, false, 0f);
				}
				else
				{
					MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
					string dagalcailln = "#failed: " + www.text;
					string kokbpeccndg = "#tryagain";
					UnityAction jfpbajlmapc = new UnityAction(kdpimfpgjhm.GBKBDKHPLKG);
					string nhcjnaeddjl = "#close";
					if (ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD == null)
					{
						ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD = new UnityAction(ContributorSystem.JGENBOHDKKM.HMMBBDJNGGL);
					}
					base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ContributorSystem.JGENBOHDKKM.CLCBJCKCBDD));
				}
			}
			else
			{
				MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln2 = "#failed: " + www.text;
				string kokbpeccndg2 = "#tryagain";
				UnityAction jfpbajlmapc2 = new UnityAction(kdpimfpgjhm.HMMBBDJNGGL);
				string nhcjnaeddjl2 = "#close";
				if (ContributorSystem.JGENBOHDKKM.HCLEECLNOEA == null)
				{
					ContributorSystem.JGENBOHDKKM.HCLEECLNOEA = new UnityAction(ContributorSystem.JGENBOHDKKM.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ContributorSystem.JGENBOHDKKM.HCLEECLNOEA));
			}
		}
		yield break;
	}

	// Token: 0x0600CBB2 RID: 52146 RVA: 0x0002523B File Offset: 0x0002343B
	public void PINOHCHDHBO()
	{
	}

	// Token: 0x040017AC RID: 6060
	public string checkContributorURL = "?";

	// Token: 0x040017AD RID: 6061
	public string redeemTicketURL = "?";

	// Token: 0x040017AE RID: 6062
	public Button buttonBack;

	// Token: 0x040017AF RID: 6063
	public GameObject managerCanvas;

	// Token: 0x040017B0 RID: 6064
	public GameObject promoCanvas;

	// Token: 0x040017B1 RID: 6065
	private Dictionary<CSteamID, bool> HDCCFLLCGOA = new Dictionary<CSteamID, bool>();
}
