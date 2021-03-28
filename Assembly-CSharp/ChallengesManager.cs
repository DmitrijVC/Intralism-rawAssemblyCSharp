using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

// Token: 0x02000385 RID: 901
public class ChallengesManager : Singleton<ChallengesManager>
{
	// Token: 0x0600C7F4 RID: 51188 RVA: 0x00487010 File Offset: 0x00485210
	public void NOMLFPFGFBI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HMADOEFFOEM().AddCommand("getint", new DebugCommands.DebugCommand(this.KCDICOKEJHJ), "settings.disablestoryboard", "team", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1988.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.BADPAMEGNLK(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_EmissionColor" + challenge.IKACPLICNNB() + "_Distortion", null) && t >= t2 && t <= t3)
			{
				this.NMAJHGEGJCG(challenge, false);
			}
		}
	}

	// Token: 0x0600C7F5 RID: 51189 RVA: 0x00487130 File Offset: 0x00485330
	public IEnumerator PJMMIOMIBFN(ulong DDFGKDFMPNL)
	{
		ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		byte[] data = wwwform.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		string text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C7F6 RID: 51190 RVA: 0x00487152 File Offset: 0x00485352
	public bool PIHGMOLGBJF()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C7F7 RID: 51191 RVA: 0x00487162 File Offset: 0x00485362
	public void BOBKIIPNBND(ulong CENMLCAACBF)
	{
		if (this.NOPECAKEGAN(CENMLCAACBF).DGAKBIEHAJC() == (Challenge.CurrentStatus)7)
		{
			base.StartCoroutine(this.CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	// Token: 0x0600C7F8 RID: 51192 RVA: 0x00487184 File Offset: 0x00485384
	public long AHCHPPGMLEI(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-65, 1, 1, 1, 1, 0)).TotalSeconds;
	}

	// Token: 0x0600C7F9 RID: 51193 RVA: 0x004871AF File Offset: 0x004853AF
	public bool LJOFFJJLPPG()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C7FA RID: 51194 RVA: 0x004871C0 File Offset: 0x004853C0
	public void ODPMHIBGDFM(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Value1" + BFLLKFPPAAB.AKJKDMMKNFO() + "[PlayerController] ", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.GAACBNCIFLG("_History4Weight" + BFLLKFPPAAB.PHCHLPBPKHL() + "Init", false, null);
		}
	}

	// Token: 0x0600C7FB RID: 51195 RVA: 0x00487230 File Offset: 0x00485430
	public void GHGGFGCMGGE()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.MFOIDBAHKOJ(this.GetChallengeByID(jmmilefmacb), "_MainTex2", this.PIFHBONLJCA(jmmilefmacb).info));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C7FC RID: 51196 RVA: 0x004872BC File Offset: 0x004854BC
	public void LMACOJIINNN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("CameraFilterPack/TV_Old_Movie" + BFLLKFPPAAB.NJNBOPKBLKK() + "roomDescription", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.NJNBOPKBLKK());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("CompletedLevel" + BFLLKFPPAAB.IHBDBALJGBO() + "_SweaterSize", true, null);
		}
	}

	// Token: 0x0600C7FD RID: 51197 RVA: 0x0048732A File Offset: 0x0048552A
	public void PMBBDPNMGHK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.OAMNFGLGIPE(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.ALIGPAANMFA() == "Cross")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C7FE RID: 51198 RVA: 0x0048735C File Offset: 0x0048555C
	public IEnumerator BBJLGIFFBKC(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C7FF RID: 51199 RVA: 0x00487380 File Offset: 0x00485580
	public IEnumerator HEDGEAHBBDH(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C800 RID: 51200 RVA: 0x004873A4 File Offset: 0x004855A4
	public void LMOPGJMILEL()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.GBEONFANEGF(this.PIFHBONLJCA(jmmilefmacb), " Also make sure to disable sprite packing for this sprite.", this.LJEGAEKKDPP(jmmilefmacb).EBENNNMBEAP()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C801 RID: 51201 RVA: 0x00487430 File Offset: 0x00485630
	public void PBALPILMOKK(ulong CENMLCAACBF)
	{
		if (this.LJEGAEKKDPP(CENMLCAACBF).IFAJDLKJIDL() == (Challenge.CurrentStatus)5)
		{
			base.StartCoroutine(this.CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	// Token: 0x0600C802 RID: 51202 RVA: 0x00487454 File Offset: 0x00485654
	public Challenge NLPMEFFEPIO(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BKNHHGBPLGH));
	}

	// Token: 0x0600C803 RID: 51203 RVA: 0x004871AF File Offset: 0x004853AF
	public bool HasProgress()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C804 RID: 51204 RVA: 0x0048748C File Offset: 0x0048568C
	public long LBCDIBEALKK(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-80, 0, 1, 0, 0, 0)).TotalSeconds;
	}

	// Token: 0x0600C805 RID: 51205 RVA: 0x004874B8 File Offset: 0x004856B8
	public Challenge GetChallengeByID(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.GBKBDKHPLKG));
	}

	// Token: 0x0600C806 RID: 51206 RVA: 0x004874F0 File Offset: 0x004856F0
	public void ELFNAHPCJJL(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("CameraFilterPack/Distortion_Lens" + BFLLKFPPAAB.NPIPMDFPLPH() + "CameraFilterPack/Edge_Neon", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.SetBool("CameraFilterPack/Distortion_Noise" + BFLLKFPPAAB.ALBJAEBLABB() + "/icon", false, null);
		}
	}

	// Token: 0x0600C807 RID: 51207 RVA: 0x00487560 File Offset: 0x00485760
	public void NFGBFFPGJDE()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.IKIFPMPCMHM(this.NOPECAKEGAN(jmmilefmacb), "_NoiseAmount", this.CDDFIMMJECM(jmmilefmacb).IOCJJJCAFLK()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C808 RID: 51208 RVA: 0x004875EC File Offset: 0x004857EC
	public void MLIHOLEHFIM(ulong CENMLCAACBF)
	{
		if (this.ICHOIEINCLP(CENMLCAACBF).IFAJDLKJIDL() == (Challenge.CurrentStatus)5)
		{
			base.StartCoroutine(this.EBFKFEPCIFJ(CENMLCAACBF));
		}
	}

	// Token: 0x0600C809 RID: 51209 RVA: 0x00487610 File Offset: 0x00485810
	public void RewardsReadyNotification()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.ShowMessage(this.GetChallengeByID(jmmilefmacb), "#challengecomplete", this.GetChallengeByID(jmmilefmacb).info));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C80A RID: 51210 RVA: 0x0048769C File Offset: 0x0048589C
	public void CompleteChallenge(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("challenges." + BFLLKFPPAAB.id + ".message", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.SetBool("challenges." + BFLLKFPPAAB.id + ".message", true, null);
		}
	}

	// Token: 0x0600C80B RID: 51211 RVA: 0x0048770C File Offset: 0x0048590C
	public long NIIAFNLPKAP(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(166, 0, 1, 1, 0, 1)).TotalSeconds;
	}

	// Token: 0x0600C80C RID: 51212 RVA: 0x00487738 File Offset: 0x00485938
	public void KAMJHHEDLKP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("\r\n" + BFLLKFPPAAB.HJCBNLFCNAM() + "#", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.ALBJAEBLABB());
			Singleton<SaveSystem>.Instance.LBFFJLFBOAM("GetGameList failed: " + BFLLKFPPAAB.IKACPLICNNB() + "_History1Weight", false, null);
		}
	}

	// Token: 0x0600C80D RID: 51213 RVA: 0x004871AF File Offset: 0x004853AF
	public bool NAPJNOLANOD()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C80E RID: 51214 RVA: 0x004877A8 File Offset: 0x004859A8
	public void MIAIEKCLEAO(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().JAFPBHCJCGE("achievements.21.progress", new DebugCommands.DebugCommand(this.KDDOGHOJBFJ), "_SizeX", "_TimeX", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(244.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.MGEFANJIDHA(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Value4" + challenge.KHCJFLGCAFL() + "_TimeX", null) && t >= t2 && t <= t3)
			{
				this.PMBBDPNMGHK(challenge, true);
			}
		}
	}

	// Token: 0x0600C80F RID: 51215 RVA: 0x004878C8 File Offset: 0x00485AC8
	public void TryGetReward(ulong CENMLCAACBF)
	{
		if (this.GetChallengeByID(CENMLCAACBF).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			base.StartCoroutine(this.GetReward(CENMLCAACBF));
		}
	}

	// Token: 0x0600C810 RID: 51216 RVA: 0x004878EC File Offset: 0x00485AEC
	private void KJJBDNJLEBD(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 7)
		{
			Debug.LogError("_SecondTex");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 1UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[1], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.AEINPAGJFME));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("USE_PREDICATION");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 2)
		{
			if (lmibfckloaf.BDGDDFKKGGA[1] == "_Value3")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.GONKPNAAIEE();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == "_DiffuseColor")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("int");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.FBGMHPEEIFC)).GONKPNAAIEE();
			}
		}
		if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "_ColorLevel")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C811 RID: 51217 RVA: 0x004871AF File Offset: 0x004853AF
	public bool DJAJOCAAKEC()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C812 RID: 51218 RVA: 0x00487A64 File Offset: 0x00485C64
	public void JHOJDHKEIPL()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.BBGKHAOOLEA(this.JGGLPBFDJKF(jmmilefmacb), "_Blue_G", this.NOPECAKEGAN(jmmilefmacb).EBENNNMBEAP()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C813 RID: 51219 RVA: 0x00487AF0 File Offset: 0x00485CF0
	private void IMGAAAPHGFE(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 4)
		{
			Debug.LogError(".lastCheckpoint.correctScore");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 1UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[1], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.GBKBDKHPLKG));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("#ok");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 0)
		{
			if (lmibfckloaf.BDGDDFKKGGA[0] == "Testing, the group has toggled [")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.HFFAJNCOJNB();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[1] == "Data/Localization")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 8)
			{
				Debug.LogError("<b>(╯°□°）╯︵ ┻━┻</b>");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.JPGFOBNOBKN)).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "value")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C814 RID: 51220 RVA: 0x00487C68 File Offset: 0x00485E68
	public void KPFKCDIFHKG(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("_TimeX" + BFLLKFPPAAB.IKACPLICNNB() + "_Value3", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.KHCJFLGCAFL());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("float,1.5" + BFLLKFPPAAB.IHBDBALJGBO() + "_Value2", false, null);
		}
	}

	// Token: 0x0600C815 RID: 51221 RVA: 0x00487CD8 File Offset: 0x00485ED8
	public long MNGDCJBBFBO(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-183, 1, 0, 1, 0, 1)).TotalSeconds;
	}

	// Token: 0x0600C816 RID: 51222 RVA: 0x00487D04 File Offset: 0x00485F04
	public void GGHCMPKGNGE(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.AddCommand("SetParticlesColor", new DebugCommands.DebugCommand(this.IMGAAAPHGFE), "Fade", "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", false);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1007.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.startDateTime, CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("MessageText" + challenge.id + "float,40", null) && t >= t2 && t <= t3)
			{
				this.IMDLCKCMFMF(challenge, false);
			}
		}
	}

	// Token: 0x0600C817 RID: 51223 RVA: 0x00487E24 File Offset: 0x00486024
	public Challenge BOAMLFKCEDJ(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.MEMPOPNAEDN));
	}

	// Token: 0x0600C818 RID: 51224 RVA: 0x00487E5C File Offset: 0x0048605C
	public Challenge JGGLPBFDJKF(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.GBKBDKHPLKG));
	}

	// Token: 0x0600C819 RID: 51225 RVA: 0x00487E94 File Offset: 0x00486094
	public Challenge CIHAIJPFIFP(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.LNDGINDKPFA));
	}

	// Token: 0x0600C81A RID: 51226 RVA: 0x00487EC9 File Offset: 0x004860C9
	public void NMAJHGEGJCG(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.ICGKNCAAFLN(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.EODGDBPONOL() == "_Red_C")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C81B RID: 51227 RVA: 0x00487152 File Offset: 0x00485352
	public bool ELBBJONPFJM()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C81C RID: 51228 RVA: 0x004871AF File Offset: 0x004853AF
	public bool MCEPCODDFGD()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C81D RID: 51229 RVA: 0x00487EFC File Offset: 0x004860FC
	public void FENIFPLLDAK(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.IGMKHPPPLDD().CEMAFHEDCMF("move", new DebugCommands.DebugCommand(this.IMGAAAPHGFE), "hidden", "_Value", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1087.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.PDPNJDOCEOE(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.endDateTime, CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("The given 2D texture " + challenge.IKACPLICNNB() + "VIGNETTE_FILMIC", null) && t >= t2 && t <= t3)
			{
				this.KCKLDEBDNFB(challenge, false);
			}
		}
	}

	// Token: 0x0600C81E RID: 51230 RVA: 0x0048801C File Offset: 0x0048621C
	public Challenge PIFHBONLJCA(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BFEABMIFIEE));
	}

	// Token: 0x0600C81F RID: 51231 RVA: 0x00488051 File Offset: 0x00486251
	public void MIDCODCLJLE(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.FBPOLBCPJFG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "mapselector.filter.favoriteonly")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C820 RID: 51232 RVA: 0x00488084 File Offset: 0x00486284
	public long FPKNHHINMNM(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(147, 1, 0, 0, 0, 1)).TotalSeconds;
	}

	// Token: 0x0600C821 RID: 51233 RVA: 0x004880B0 File Offset: 0x004862B0
	public void LNMKDFDKFPF(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().CIHBPOBKGNP("_TimeX", new DebugCommands.DebugCommand(this.HEFOBIBCNNP), "_CenterY", "DPADHOR", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(572.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.ONELLAMBEAG(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.BADPAMEGNLK(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey("_FadeFX" + challenge.HJCBNLFCNAM() + "_Value", null) && t >= t2 && t <= t3)
			{
				this.LCJFAOGLEEM(challenge, false);
			}
		}
	}

	// Token: 0x0600C822 RID: 51234 RVA: 0x004881D0 File Offset: 0x004863D0
	public void JGLNHCHILNJ(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.OAMNFGLGIPE(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "]")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C823 RID: 51235 RVA: 0x00488204 File Offset: 0x00486404
	private void KDDOGHOJBFJ(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 0)
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_LinearBurn");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 1UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[0], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.GBKBDKHPLKG));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("settings.volume.menu");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 2)
		{
			if (lmibfckloaf.BDGDDFKKGGA[0] == "EventMenu")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.HFFAJNCOJNB();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == "FullscreenToggle")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("' was created: ");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.HJKJAANIFLL)).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "open")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C824 RID: 51236 RVA: 0x0048837C File Offset: 0x0048657C
	public void NFINEDMNOFP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost." + BFLLKFPPAAB.KHCJFLGCAFL() + "_Value4", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.CONNMLDKBOF(" " + BFLLKFPPAAB.HJCBNLFCNAM() + "LevelNameInputField", false, null);
		}
	}

	// Token: 0x0600C825 RID: 51237 RVA: 0x004883EC File Offset: 0x004865EC
	public long HOLHEOMHCLM(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(50, 1, 0, 1, 1, 1)).TotalSeconds;
	}

	// Token: 0x0600C826 RID: 51238 RVA: 0x00487152 File Offset: 0x00485352
	public bool LHCINEGDJCM()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C827 RID: 51239 RVA: 0x00488418 File Offset: 0x00486618
	public long ToUnixTimeSeconds(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	// Token: 0x0600C828 RID: 51240 RVA: 0x00488443 File Offset: 0x00486643
	public void LIFPBMDKPGI(ulong CENMLCAACBF)
	{
		if (this.IDKBNGMCFAL(CENMLCAACBF).CJNNAAGGAJI() == (Challenge.CurrentStatus)6)
		{
			base.StartCoroutine(this.CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	// Token: 0x0600C829 RID: 51241 RVA: 0x00488468 File Offset: 0x00486668
	public long KDNGOKOLMHE(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(39, 0, 0, 0, 1, 1)).TotalSeconds;
	}

	// Token: 0x0600C82A RID: 51242 RVA: 0x00488494 File Offset: 0x00486694
	public void FIMJABKECNG(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().CEMAFHEDCMF("???", new DebugCommands.DebugCommand(this.KJJBDNJLEBD), "<b>#banended</b>", "_Distortion", false);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1744.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey("_MainTex2" + challenge.NPIPMDFPLPH() + ".lastCheckpoint.incorrectScore", null) && t >= t2 && t <= t3)
			{
				this.IMDLCKCMFMF(challenge, true);
			}
		}
	}

	// Token: 0x0600C82B RID: 51243 RVA: 0x004885B4 File Offset: 0x004867B4
	public Challenge ICHOIEINCLP(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BKNHHGBPLGH));
	}

	// Token: 0x0600C82C RID: 51244 RVA: 0x004885EC File Offset: 0x004867EC
	public long CALKHGLKCBG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-184, 0, 0, 1, 0, 1)).TotalSeconds;
	}

	// Token: 0x0600C82D RID: 51245 RVA: 0x00488618 File Offset: 0x00486818
	public void AJOOJLMPNMO()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.JOCACBLCCMM(this.GetChallengeByID(jmmilefmacb), ".GoalProgress", this.NOPECAKEGAN(jmmilefmacb).EBENNNMBEAP()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C82E RID: 51246 RVA: 0x004886A4 File Offset: 0x004868A4
	public void IIJFAJMPAEF(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.ICGKNCAAFLN(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.PACECPHKLNE() == "settings.showHP")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C82F RID: 51247 RVA: 0x004886D8 File Offset: 0x004868D8
	public void LMHFEBCKPDI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.GLEFOHOMBFC().JAFPBHCJCGE("_MainTex", new DebugCommands.DebugCommand(this.IMGAAAPHGFE), "SpawnObj", "Particles/Additive", false);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1299.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(".lastCheckpoint.bgcolor" + challenge.KHCJFLGCAFL() + "[MapEditor] Loaded music file: ", null) && t >= t2 && t <= t3)
			{
				this.GDLKPBLABII(challenge, false);
			}
		}
	}

	// Token: 0x0600C830 RID: 51248 RVA: 0x004887F8 File Offset: 0x004869F8
	public IEnumerator EBFKFEPCIFJ(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C831 RID: 51249 RVA: 0x0048881C File Offset: 0x00486A1C
	public void OPLCHDMBFJP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("Error: you cannot write/send to this stream that you are reading!" + BFLLKFPPAAB.PHCHLPBPKHL() + "No regions available. Are you sure your appid is valid and setup?", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.IKACPLICNNB());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("CameraFilterPack/3D_Computer" + BFLLKFPPAAB.KHCJFLGCAFL() + "_MainTex2", true, null);
		}
	}

	// Token: 0x0600C832 RID: 51250 RVA: 0x0048888C File Offset: 0x00486A8C
	public IEnumerator CJPKLAMIIJP(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C833 RID: 51251 RVA: 0x004888AE File Offset: 0x00486AAE
	public void PAIOCIDCBJL(ulong CENMLCAACBF)
	{
		if (this.JGGLPBFDJKF(CENMLCAACBF).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			base.StartCoroutine(this.MJGPMLDHKDE(CENMLCAACBF));
		}
	}

	// Token: 0x0600C834 RID: 51252 RVA: 0x004888D0 File Offset: 0x00486AD0
	public void LHOLHHBALDN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("downloading" + BFLLKFPPAAB.PHCHLPBPKHL() + "_ChangeRed", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.BBPGJKOIAKM());
			Singleton<SaveSystem>.Instance.SetBool("Save level before uploading?" + BFLLKFPPAAB.ALBJAEBLABB() + "Operation failed: ", false, null);
		}
	}

	// Token: 0x0600C835 RID: 51253 RVA: 0x004871AF File Offset: 0x004853AF
	public bool BFLOBBEIBEM()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C836 RID: 51254 RVA: 0x004871AF File Offset: 0x004853AF
	public bool JKNMMMCFDAP()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C837 RID: 51255 RVA: 0x00487152 File Offset: 0x00485352
	public bool HKBEDHGKHLG()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C838 RID: 51256 RVA: 0x00488940 File Offset: 0x00486B40
	public long GJCMAKKCCDJ(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-23, 1, 1, 0, 0, 1)).TotalSeconds;
	}

	// Token: 0x0600C839 RID: 51257 RVA: 0x0048896C File Offset: 0x00486B6C
	public long NDIEOCHAOGG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(35, 0, 1, 1, 1, 1)).TotalSeconds;
	}

	// Token: 0x0600C83A RID: 51258 RVA: 0x00488998 File Offset: 0x00486B98
	public void EIPPDLDJJGO(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.KHBHACBOGLJ("_Value4", new DebugCommands.DebugCommand(this.IMGAAAPHGFE), "Tab2Content", "_TimeX", false);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(964.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.ONELLAMBEAG(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(" Remote called." + challenge.PHCHLPBPKHL() + "Classical", null) && t >= t2 && t <= t3)
			{
				this.GHBFNOEMKJB(challenge, true);
			}
		}
	}

	// Token: 0x0600C83B RID: 51259 RVA: 0x00488AB8 File Offset: 0x00486CB8
	public void HCJMCPGGPKH()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.DHPELKMAAFM(this.JGGLPBFDJKF(jmmilefmacb), "Submit", this.IFPIPMPFHCA(jmmilefmacb).info));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C83C RID: 51260 RVA: 0x00488B44 File Offset: 0x00486D44
	public Challenge ONEPNINILOC(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BKNHHGBPLGH));
	}

	// Token: 0x0600C83D RID: 51261 RVA: 0x00488B79 File Offset: 0x00486D79
	public void CINMGCJPABI(ulong CENMLCAACBF)
	{
		if (this.NOPECAKEGAN(CENMLCAACBF).OCNOEDGAPNL() == (Challenge.CurrentStatus)4)
		{
			base.StartCoroutine(this.HEDGEAHBBDH(CENMLCAACBF));
		}
	}

	// Token: 0x0600C83E RID: 51262 RVA: 0x00488B9C File Offset: 0x00486D9C
	public void NEAKMMNMCIH()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.JOCACBLCCMM(this.ICHOIEINCLP(jmmilefmacb), "CameraFilterPack/Colors_Adjust_FullColors", this.IFPIPMPFHCA(jmmilefmacb).IGAHKBHFBNE()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C83F RID: 51263 RVA: 0x00488C28 File Offset: 0x00486E28
	public long HCPCNBCHCHP(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-10, 1, 1, 0, 1, 0)).TotalSeconds;
	}

	// Token: 0x0600C840 RID: 51264 RVA: 0x00488C53 File Offset: 0x00486E53
	public void EONFOJMJJNE(ulong CENMLCAACBF)
	{
		if (this.IDKBNGMCFAL(CENMLCAACBF).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			base.StartCoroutine(this.CDCHOGACPON(CENMLCAACBF));
		}
	}

	// Token: 0x0600C841 RID: 51265 RVA: 0x00488C78 File Offset: 0x00486E78
	public void PEEFILGCABG(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().EHJBOAOCFNP("CameraFilterPack/Glasses_OnX", new DebugCommands.DebugCommand(this.DAPKGMONPDI), "score", "#submit", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(784.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.startDateTime, CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.MGEFANJIDHA(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey(" joined" + challenge.ALBJAEBLABB() + "InventoryButton", null) && t >= t2 && t <= t3)
			{
				this.GDLKPBLABII(challenge, true);
			}
		}
	}

	// Token: 0x0600C842 RID: 51266 RVA: 0x00488D98 File Offset: 0x00486F98
	public void CCCLIKMDEEJ()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.LLDNOFEBMNO(this.GetChallengeByID(jmmilefmacb), "_Params3", this.BOAMLFKCEDJ(jmmilefmacb).IOCJJJCAFLK()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C843 RID: 51267 RVA: 0x00488E24 File Offset: 0x00487024
	public void FAFMBMPLOCI(ulong CENMLCAACBF)
	{
		if (this.LJEGAEKKDPP(CENMLCAACBF).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			base.StartCoroutine(this.CDCHOGACPON(CENMLCAACBF));
		}
	}

	// Token: 0x0600C844 RID: 51268 RVA: 0x00488E48 File Offset: 0x00487048
	public long AGBPNLGADNA(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-136, 1, 0, 0, 1, 1)).TotalSeconds;
	}

	// Token: 0x0600C845 RID: 51269 RVA: 0x00488E74 File Offset: 0x00487074
	public IEnumerator CDCHOGACPON(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C846 RID: 51270 RVA: 0x00488E96 File Offset: 0x00487096
	public void KCKLDEBDNFB(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.HLGJHICPDMO() == "_Fade")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C847 RID: 51271 RVA: 0x00487152 File Offset: 0x00485352
	public bool KKIPAOGPMFI()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C848 RID: 51272 RVA: 0x00488EC8 File Offset: 0x004870C8
	public IEnumerator GetReward(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C849 RID: 51273 RVA: 0x00488EEC File Offset: 0x004870EC
	public void MIGFOIJJJNL(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.IGMKHPPPLDD().PLOIOFEGBIJ("_AOTex", new DebugCommands.DebugCommand(this.DAPKGMONPDI), " method: ", "_Screen", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(149.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.PDPNJDOCEOE(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.endDateTime, CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(".lastCheckpoint.checkpointsUsed" + challenge.HJCBNLFCNAM() + "Found best region: '", null) && t >= t2 && t <= t3)
			{
				this.OLNGIOJOABI(challenge, false);
			}
		}
	}

	// Token: 0x0600C84A RID: 51274 RVA: 0x0048900C File Offset: 0x0048720C
	public void KKMBHEBOGAL()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.PJMJPHECLLL(this.CIHAIJPFIFP(jmmilefmacb), "_SmoothStart", this.ONEPNINILOC(jmmilefmacb).DPKPLOJNEOG()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C84B RID: 51275 RVA: 0x00489098 File Offset: 0x00487298
	public void DHNMKMKCKFD()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.HJKACAHALKD(this.ONEPNINILOC(jmmilefmacb), "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", this.IFPIPMPFHCA(jmmilefmacb).NJKHOALCJBI()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C84C RID: 51276 RVA: 0x00489124 File Offset: 0x00487324
	public void IMDLCKCMFMF(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "Reset XP")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C84D RID: 51277 RVA: 0x00489158 File Offset: 0x00487358
	public IEnumerator MJGPMLDHKDE(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C84E RID: 51278 RVA: 0x0048917A File Offset: 0x0048737A
	public void GDLKPBLABII(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.NMAJHGEGJCG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "Drop_Near")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C84F RID: 51279 RVA: 0x004891AC File Offset: 0x004873AC
	public void LCCIGLLLFBG()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.HOCOLBHKCHL(this.JGGLPBFDJKF(jmmilefmacb), "CameraFilterPack/TV_VHS", this.JGGLPBFDJKF(jmmilefmacb).EBENNNMBEAP()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C850 RID: 51280 RVA: 0x00489238 File Offset: 0x00487438
	public void JEALJMLENKL(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Value3" + BFLLKFPPAAB.ALBJAEBLABB() + "fade out duration", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("EndlessLoopsScoreText" + BFLLKFPPAAB.IKACPLICNNB() + "true", true, null);
		}
	}

	// Token: 0x0600C851 RID: 51281 RVA: 0x004892A6 File Offset: 0x004874A6
	public void GHBFNOEMKJB(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AAIDMDNBMCD(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.PACECPHKLNE() == "_Value")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C852 RID: 51282 RVA: 0x004892D8 File Offset: 0x004874D8
	public long ELAIHKBJPKP(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(137, 1, 1, 1, 1, 0)).TotalSeconds;
	}

	// Token: 0x0600C853 RID: 51283 RVA: 0x00489304 File Offset: 0x00487504
	private void HEFOBIBCNNP(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 1)
		{
			Debug.LogError("[LevelEditorScene] Print Audio Wave: Start");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 0UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[1], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.LLNDDFGPOPL));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("/");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 2)
		{
			if (lmibfckloaf.BDGDDFKKGGA[0] == " base map(s)")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.IHLJALNNBFP();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == "player")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError(",");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.JPGFOBNOBKN)).FEAPMDENLBN();
			}
		}
		if (Singleton<Scene>.Instance.LCBFAFEADIO() == "GlassesColor2")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C854 RID: 51284 RVA: 0x0048947C File Offset: 0x0048767C
	private void KCDICOKEJHJ(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 4)
		{
			Debug.LogError("Fade");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 1UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[0], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.GBKBDKHPLKG));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("IncorrectHitsScoreText");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 5)
		{
			if (lmibfckloaf.BDGDDFKKGGA[1] == "ItemNameBGImage")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.Reset();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == " ")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("OpJoinLobby()");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.NLALPCHCOPE)).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.HPKHOICGMFC() == "OPEN")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C855 RID: 51285 RVA: 0x004895F4 File Offset: 0x004877F4
	public void CHAJHAOEIKF(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("GameScene" + BFLLKFPPAAB.KHCJFLGCAFL() + "Cannot send messages when not connected. Either connect to Photon OR use offline mode!", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.NJNBOPKBLKK());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("(master)" + BFLLKFPPAAB.BBPGJKOIAKM() + "SupportLogger OnApplicationPause: ", false, null);
		}
	}

	// Token: 0x0600C856 RID: 51286 RVA: 0x00487152 File Offset: 0x00485352
	public bool BHFILMECNEI()
	{
		return this.ODNDAPINPLB.Count > 1;
	}

	// Token: 0x0600C857 RID: 51287 RVA: 0x00489662 File Offset: 0x00487862
	public void IIHGLLIKGKH(ulong CENMLCAACBF)
	{
		if (this.CIHAIJPFIFP(CENMLCAACBF).JMGIKADHIGM() == (Challenge.CurrentStatus)4)
		{
			base.StartCoroutine(this.PJMMIOMIBFN(CENMLCAACBF));
		}
	}

	// Token: 0x0600C858 RID: 51288 RVA: 0x00489684 File Offset: 0x00487884
	public void LCJFAOGLEEM(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.PFNIKKMCFDF(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "_HighlightSuppression")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C859 RID: 51289 RVA: 0x004896B5 File Offset: 0x004878B5
	public void IJIEFKLHMPF(ulong CENMLCAACBF)
	{
		if (this.GetChallengeByID(CENMLCAACBF).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			base.StartCoroutine(this.HEDGEAHBBDH(CENMLCAACBF));
		}
	}

	// Token: 0x0600C85A RID: 51290 RVA: 0x004896D8 File Offset: 0x004878D8
	public void Init(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.AddCommand("challenges", new DebugCommands.DebugCommand(this.FINNJIMFAPB), "Commands for challenges", "<command>", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(3.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.startDateTime, CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.endDateTime, CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey("challenges." + challenge.id + ".status", null) && t >= t2 && t <= t3)
			{
				this.AcceptChallenge(challenge, false);
			}
		}
	}

	// Token: 0x0600C85B RID: 51291 RVA: 0x004897F8 File Offset: 0x004879F8
	public Challenge IDKBNGMCFAL(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.JKEDCEOCPJO));
	}

	// Token: 0x0600C85C RID: 51292 RVA: 0x00489830 File Offset: 0x00487A30
	public void NKLCNJEIAFB(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HMADOEFFOEM().CEBBJICIFGO(",0", new DebugCommands.DebugCommand(this.ILCHBIPHPHN), "_VignetteBlur", "_Value4", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(530.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.BADPAMEGNLK(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Radius" + challenge.AKJKDMMKNFO() + "Set Particles Color", null) && t >= t2 && t <= t3)
			{
				this.JGLNHCHILNJ(challenge, false);
			}
		}
	}

	// Token: 0x0600C85D RID: 51293 RVA: 0x00489950 File Offset: 0x00487B50
	public IEnumerator LCMOLPOBCBP(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C85E RID: 51294 RVA: 0x00489974 File Offset: 0x00487B74
	public Challenge NOPECAKEGAN(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BKNHHGBPLGH));
	}

	// Token: 0x0600C85F RID: 51295 RVA: 0x004899AC File Offset: 0x00487BAC
	public IEnumerator PJKOLFHNGGB(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C860 RID: 51296 RVA: 0x004899CE File Offset: 0x00487BCE
	public void MBJHDNCOGIK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.OAMNFGLGIPE(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "_Level")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C861 RID: 51297 RVA: 0x00489A00 File Offset: 0x00487C00
	private void CALDBKBCANF(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 3)
		{
			Debug.LogError("Up");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 0UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[1], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.LLNDDFGPOPL));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("/");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 6)
		{
			if (lmibfckloaf.BDGDDFKKGGA[0] == "_Value")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.FEAPMDENLBN();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == "_CameraWS")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("_Distortion");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.GMLFBOMLINM)).GONKPNAAIEE();
			}
		}
		if (Singleton<Scene>.Instance.id == "x")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C862 RID: 51298 RVA: 0x00489B78 File Offset: 0x00487D78
	public void CKFHEMPKPEM(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("CameraFilterPack/Drawing_NewCellShading" + BFLLKFPPAAB.BBPGJKOIAKM() + "settings_bindings_sec_", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("PublishButton" + BFLLKFPPAAB.AKJKDMMKNFO() + "lobby '{0}'[{1}]", true, null);
		}
	}

	// Token: 0x0600C863 RID: 51299 RVA: 0x00489BE8 File Offset: 0x00487DE8
	public void PBBDHIFJHHC(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.CEMAFHEDCMF("x", new DebugCommands.DebugCommand(this.FINNJIMFAPB), "SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", "\r", false);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(363.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.endDateTime, CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey("_Glitch" + challenge.HJCBNLFCNAM() + "_MainTex2", null) && t >= t2 && t <= t3)
			{
				this.PMBBDPNMGHK(challenge, true);
			}
		}
	}

	// Token: 0x0600C864 RID: 51300 RVA: 0x00489D08 File Offset: 0x00487F08
	public void CMFBCPNHGOF(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.GLEFOHOMBFC().PNEHIPCCEKG("/", new DebugCommands.DebugCommand(this.MBDOHDIHPMI), ". Going to authenticate anyways.", "VHS", false);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(350.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.ONELLAMBEAG(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey("ls" + challenge.BBPGJKOIAKM() + "NetworkScene", null) && t >= t2 && t <= t3)
			{
				this.GDLKPBLABII(challenge, true);
			}
		}
	}

	// Token: 0x0600C865 RID: 51301 RVA: 0x00489E28 File Offset: 0x00488028
	public void EBJDBGBGCJO(ulong CENMLCAACBF)
	{
		if (this.IDKBNGMCFAL(CENMLCAACBF).JMGIKADHIGM() == Challenge.CurrentStatus.Complete)
		{
			base.StartCoroutine(this.CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	// Token: 0x0600C866 RID: 51302 RVA: 0x00489E4C File Offset: 0x0048804C
	public long PNNOHGCMANO(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-60, 0, 0, 1, 0, 0)).TotalSeconds;
	}

	// Token: 0x0600C867 RID: 51303 RVA: 0x00489E78 File Offset: 0x00488078
	public void BADJNHDCDGC()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.LMCOPICBHCI(this.PIFHBONLJCA(jmmilefmacb), "_ReflectionTexture2", this.NLPMEFFEPIO(jmmilefmacb).IGAHKBHFBNE()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C868 RID: 51304 RVA: 0x00489F04 File Offset: 0x00488104
	public Challenge FJKMDIDOJMI(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.JKEDCEOCPJO));
	}

	// Token: 0x0600C869 RID: 51305 RVA: 0x00489F39 File Offset: 0x00488139
	public void ALDHFENHIDP(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.FBPOLBCPJFG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "music")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C86B RID: 51307 RVA: 0x00489F80 File Offset: 0x00488180
	public void PGDHACEMEAE(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP(" " + BFLLKFPPAAB.NPIPMDFPLPH() + "#rt", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.AKJKDMMKNFO());
			Singleton<SaveSystem>.Instance.SetBool("_Value" + BFLLKFPPAAB.NJNBOPKBLKK() + "mapselector.filter.officialsortmode", true, null);
		}
	}

	// Token: 0x0600C86C RID: 51308 RVA: 0x00489FF0 File Offset: 0x004881F0
	public Challenge IFPIPMPFHCA(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.BDGDIDPDBHG));
	}

	// Token: 0x0600C86D RID: 51309 RVA: 0x0048A028 File Offset: 0x00488228
	public long MNDIGJOOFKB(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(53, 0, 0, 0, 1, 0)).TotalSeconds;
	}

	// Token: 0x0600C86E RID: 51310 RVA: 0x0048A054 File Offset: 0x00488254
	private void DAPKGMONPDI(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 0)
		{
			Debug.LogError("EventData0DropDownList");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 1UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[1], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.LOEAMHGMMPK));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("[PlayerBase] SetBGColor error: ");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 6)
		{
			if (lmibfckloaf.BDGDDFKKGGA[0] == "CameraFilterPack/Distortion_BigFace")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.GONKPNAAIEE();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == "_Value")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("CameraFilterPack/RainFX");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.FBGMHPEEIFC)).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.HLGJHICPDMO() == "_Red_R")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C86F RID: 51311 RVA: 0x0048A1CC File Offset: 0x004883CC
	public IEnumerator NGLHHGBFCBF(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C870 RID: 51312 RVA: 0x0048A1F0 File Offset: 0x004883F0
	private void MBDOHDIHPMI(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 2)
		{
			Debug.LogError("#ok");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 1UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[0], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.LOEAMHGMMPK));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("_ScreenResolution");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 3)
		{
			if (lmibfckloaf.BDGDDFKKGGA[0] == "Beat Detected")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.HFFAJNCOJNB();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == "GenerationMenu")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError(" on effect ");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.HMMBBDJNGGL)).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "tagElement")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	// Token: 0x0600C871 RID: 51313 RVA: 0x0048A368 File Offset: 0x00488568
	private void ILCHBIPHPHN(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 5)
		{
			Debug.LogError(".lastCheckpoint.time");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 1UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[0], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.GBKBDKHPLKG));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("setint");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 6)
		{
			if (lmibfckloaf.BDGDDFKKGGA[1] == "Parameter levelId must be int or string!")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.FEAPMDENLBN();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[0] == " connected: ")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.NLALPCHCOPE)).KNNOEGLLDAN();
			}
		}
		if (Singleton<Scene>.Instance.HPKHOICGMFC() == "FileLabel")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C872 RID: 51314 RVA: 0x0048A4E0 File Offset: 0x004886E0
	public void EEIMLBLFCCA(ulong CENMLCAACBF)
	{
		if (this.LJEGAEKKDPP(CENMLCAACBF).IFAJDLKJIDL() == (Challenge.CurrentStatus)8)
		{
			base.StartCoroutine(this.GetReward(CENMLCAACBF));
		}
	}

	// Token: 0x0600C873 RID: 51315 RVA: 0x0048A504 File Offset: 0x00488704
	public void GJHDMBCLDGP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("SetSatelliteTrailWidth" + BFLLKFPPAAB.AKJKDMMKNFO() + "Set Player Distance", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("winter2020_official" + BFLLKFPPAAB.PHCHLPBPKHL() + "CameraFilterPack_Blizzard1", true, null);
		}
	}

	// Token: 0x0600C874 RID: 51316 RVA: 0x0048A572 File Offset: 0x00488772
	public void AcceptChallenge(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C875 RID: 51317 RVA: 0x0048A5A4 File Offset: 0x004887A4
	public void ONAAJPPJILB(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_TimeX" + BFLLKFPPAAB.AKJKDMMKNFO() + "Solo", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.NJNBOPKBLKK());
			Singleton<SaveSystem>.Instance.NCNNFONPMLD("Vertical" + BFLLKFPPAAB.HJCBNLFCNAM() + "value", true, null);
		}
	}

	// Token: 0x0600C876 RID: 51318 RVA: 0x0048A614 File Offset: 0x00488814
	public void EBMNMBNJDMK(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.FAGEJPPIDOL().AddCommand("isVisible", new DebugCommands.DebugCommand(this.KDDOGHOJBFJ), "Save Path: ", "ItemNameBGImage", false);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1708.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("maxScore" + challenge.ALBJAEBLABB() + "_Visualize", null) && t >= t2 && t <= t3)
			{
				this.IMDLCKCMFMF(challenge, true);
			}
		}
	}

	// Token: 0x0600C877 RID: 51319 RVA: 0x0048A734 File Offset: 0x00488934
	public void DHMIFLPJMBA(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_FinalReflectionTexture" + BFLLKFPPAAB.AKJKDMMKNFO() + "================================", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.AKJKDMMKNFO());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("Most likely the game became empty during the switch to GameServer." + BFLLKFPPAAB.NJNBOPKBLKK() + "CameraFilterPack/TV_WideScreenCircle", false, null);
		}
	}

	// Token: 0x0600C878 RID: 51320 RVA: 0x004871AF File Offset: 0x004853AF
	public bool BMAEFPCJKHD()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C879 RID: 51321 RVA: 0x0048A7A4 File Offset: 0x004889A4
	public void AJHDHOGKBBO(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("ShineEffect" + BFLLKFPPAAB.ALBJAEBLABB() + "_Value", null))
		{
			this.ODNDAPINPLB.Add(BFLLKFPPAAB.KHCJFLGCAFL());
			Singleton<SaveSystem>.Instance.SetBool("B" + BFLLKFPPAAB.NPIPMDFPLPH() + "arc", false, null);
		}
	}

	// Token: 0x0600C87A RID: 51322 RVA: 0x0048A814 File Offset: 0x00488A14
	public IEnumerator POAAHNJCIFA(ulong DDFGKDFMPNL)
	{
		nogicjmlgbo = new ChallengesManager.KPNCDNEKOLL.NOGICJMLGBO();
		nogicjmlgbo.MEIIPIOPCIJ = this;
		nogicjmlgbo.DDFGKDFMPNL = DDFGKDFMPNL;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false, false, 0f);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("challengeid", string.Empty + nogicjmlgbo.DDFGKDFMPNL);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.getRewardUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#getrewardfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(nogicjmlgbo.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (ChallengesManager.KPNCDNEKOLL.LNIJKGECNME == null)
			{
				ChallengesManager.KPNCDNEKOLL.LNIJKGECNME = new UnityAction(ChallengesManager.KPNCDNEKOLL.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, ChallengesManager.KPNCDNEKOLL.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.GetChallengeByID(nogicjmlgbo.DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			base.StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			if (ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD == null)
			{
				ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD = new Func<bool>(ChallengesManager.KPNCDNEKOLL.HMMBBDJNGGL);
			}
			yield return new WaitUntil(ChallengesManager.KPNCDNEKOLL.CLCBJCKCBDD);
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close(-1, null);
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#getrewardfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(nogicjmlgbo.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA == null)
			{
				ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA = new UnityAction(ChallengesManager.KPNCDNEKOLL.NEIDGMKKCBI);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, ChallengesManager.KPNCDNEKOLL.HCLEECLNOEA));
		}
		yield break;
	}

	// Token: 0x0600C87B RID: 51323 RVA: 0x004871AF File Offset: 0x004853AF
	public bool JCHPJOHFMKG()
	{
		return this.ODNDAPINPLB.Count > 0;
	}

	// Token: 0x0600C87C RID: 51324 RVA: 0x0048A838 File Offset: 0x00488A38
	public long CGOIJEEKOHO(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(140, 0, 0, 1, 1, 1)).TotalSeconds;
	}

	// Token: 0x0600C87D RID: 51325 RVA: 0x0048A864 File Offset: 0x00488A64
	private void FINNJIMFAPB(string[] BDGDDFKKGGA)
	{
		ChallengesManager.LMIBFCKLOAF lmibfckloaf = new ChallengesManager.LMIBFCKLOAF();
		lmibfckloaf.BDGDDFKKGGA = BDGDDFKKGGA;
		if (lmibfckloaf.BDGDDFKKGGA.Length < 2)
		{
			Debug.LogError("Please specify a map name or buildID");
			return;
		}
		lmibfckloaf.DBBLOPNANJE = 0UL;
		if (ulong.TryParse(lmibfckloaf.BDGDDFKKGGA[1], out lmibfckloaf.DBBLOPNANJE))
		{
			this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.GBKBDKHPLKG));
		}
		if (lmibfckloaf.BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("Working commands:\nreset <challengeid>\nresetall");
		}
		else if (lmibfckloaf.BDGDDFKKGGA.Length == 2)
		{
			if (lmibfckloaf.BDGDDFKKGGA[1] == "resetall")
			{
				foreach (Challenge challenge in this.challengesList)
				{
					challenge.Reset();
				}
			}
		}
		else if (lmibfckloaf.BDGDDFKKGGA[1] == "reset")
		{
			if (lmibfckloaf.BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for reset! Use \"reset <challengeid>\"");
			}
			else
			{
				this.challengesList.Find(new Predicate<Challenge>(lmibfckloaf.HMMBBDJNGGL)).Reset();
			}
		}
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C87E RID: 51326 RVA: 0x0048A9DC File Offset: 0x00488BDC
	public Challenge LJEGAEKKDPP(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.AEINPAGJFME));
	}

	// Token: 0x0600C87F RID: 51327 RVA: 0x0048AA11 File Offset: 0x00488C11
	public void OLNGIOJOABI(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.GDLKPBLABII(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.ALIGPAANMFA() == "_ScreenResolution")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	// Token: 0x0600C880 RID: 51328 RVA: 0x0048AA44 File Offset: 0x00488C44
	public void EKCNGLHGLOK()
	{
		foreach (ulong jmmilefmacb in this.ODNDAPINPLB)
		{
			base.StartCoroutine(Singleton<ChallengesMessage>.Instance.DHPELKMAAFM(this.CIHAIJPFIFP(jmmilefmacb), "note.1", this.BOAMLFKCEDJ(jmmilefmacb).AMBFPMPCHFE()));
		}
		this.ODNDAPINPLB.Clear();
	}

	// Token: 0x0600C881 RID: 51329 RVA: 0x0048AAD0 File Offset: 0x00488CD0
	public void CGBGIGPIAHL(ulong CENMLCAACBF)
	{
		if (this.ICHOIEINCLP(CENMLCAACBF).DGAKBIEHAJC() == Challenge.CurrentStatus.Complete)
		{
			base.StartCoroutine(this.PJKOLFHNGGB(CENMLCAACBF));
		}
	}

	// Token: 0x0600C882 RID: 51330 RVA: 0x0048AAF4 File Offset: 0x00488CF4
	public void NFKKPHKGIEI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.FAGEJPPIDOL().PLOIOFEGBIJ("_BlurRadius", new DebugCommands.DebugCommand(this.MBDOHDIHPMI), "#alreadystarted", "#close", true);
		this.ODNDAPINPLB = new List<ulong>();
		this.challengesList = new List<Challenge>();
		DateTime t = DateTime.UtcNow.AddHours(1567.0);
		foreach (Challenge challenge in KOHKPKPOBPD)
		{
			DateTime t2 = DateTime.Parse(challenge.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
			DateTime t3 = DateTime.Parse(challenge.MGEFANJIDHA(), CultureInfo.InvariantCulture);
			this.challengesList.Add(challenge);
			if (Singleton<SaveSystem>.Instance.HasKey("Objects in List: " + challenge.NPIPMDFPLPH() + "file://", null) && t >= t2 && t <= t3)
			{
				this.MBJHDNCOGIK(challenge, true);
			}
		}
	}

	// Token: 0x0600C883 RID: 51331 RVA: 0x0048AC14 File Offset: 0x00488E14
	public Challenge CDDFIMMJECM(ulong JMMILEFMACB)
	{
		ChallengesManager.EBMHMNGGEJM ebmhmnggejm = new ChallengesManager.EBMHMNGGEJM();
		ebmhmnggejm.JMMILEFMACB = JMMILEFMACB;
		return Singleton<ChallengesManager>.Instance.challengesList.Find(new Predicate<Challenge>(ebmhmnggejm.LOEAMHGMMPK));
	}

	// Token: 0x04001756 RID: 5974
	public string getRewardUrl = "???";

	// Token: 0x04001757 RID: 5975
	public List<Challenge> challengesList;

	// Token: 0x04001758 RID: 5976
	private List<ulong> ODNDAPINPLB;

	// Token: 0x02000386 RID: 902
	[CompilerGenerated]
	private sealed class LMIBFCKLOAF
	{
		// Token: 0x0600C884 RID: 51332 RVA: 0x0048AC49 File Offset: 0x00488E49
		internal bool GMLFBOMLINM(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == ulong.Parse(this.BDGDDFKKGGA[1]);
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x0048AC60 File Offset: 0x00488E60
		internal bool PHFMMNELDEA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == ulong.Parse(this.BDGDDFKKGGA[3]);
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x0048AC77 File Offset: 0x00488E77
		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.DBBLOPNANJE;
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x0048AC87 File Offset: 0x00488E87
		internal bool NLALPCHCOPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.AKJKDMMKNFO() == ulong.Parse(this.BDGDDFKKGGA[3]);
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x0048AC9E File Offset: 0x00488E9E
		internal bool AEINPAGJFME(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.PHCHLPBPKHL() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x0048ACAE File Offset: 0x00488EAE
		internal bool LOEAMHGMMPK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.IKACPLICNNB() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x0048ACBE File Offset: 0x00488EBE
		internal bool LLNDDFGPOPL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == this.DBBLOPNANJE;
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x0048ACCE File Offset: 0x00488ECE
		internal bool JPGFOBNOBKN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.KHCJFLGCAFL() == ulong.Parse(this.BDGDDFKKGGA[0]);
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x0048ACE5 File Offset: 0x00488EE5
		internal bool FBGMHPEEIFC(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.IKACPLICNNB() == ulong.Parse(this.BDGDDFKKGGA[8]);
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x0048ACFC File Offset: 0x00488EFC
		internal bool HMMBBDJNGGL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(this.BDGDDFKKGGA[2]);
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x0048AD13 File Offset: 0x00488F13
		internal bool IIMOMJLLFDB(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == ulong.Parse(this.BDGDDFKKGGA[1]);
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x0048AD2A File Offset: 0x00488F2A
		internal bool HJKJAANIFLL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.NPIPMDFPLPH() == ulong.Parse(this.BDGDDFKKGGA[1]);
		}

		// Token: 0x04001759 RID: 5977
		internal ulong DBBLOPNANJE;

		// Token: 0x0400175A RID: 5978
		internal string[] BDGDDFKKGGA;
	}

	// Token: 0x02000387 RID: 903
	[CompilerGenerated]
	private sealed class EBMHMNGGEJM
	{
		// Token: 0x0600C891 RID: 51345 RVA: 0x0048AD41 File Offset: 0x00488F41
		internal bool PBCAHKDLFPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.AKJKDMMKNFO() == this.JMMILEFMACB;
		}

		// Token: 0x0600C892 RID: 51346 RVA: 0x0048AD51 File Offset: 0x00488F51
		internal bool BFEABMIFIEE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.NJNBOPKBLKK() == this.JMMILEFMACB;
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x0048AD61 File Offset: 0x00488F61
		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600C894 RID: 51348 RVA: 0x0048AD41 File Offset: 0x00488F41
		internal bool KFNBKFELFLH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.AKJKDMMKNFO() == this.JMMILEFMACB;
		}

		// Token: 0x0600C895 RID: 51349 RVA: 0x0048AD71 File Offset: 0x00488F71
		internal bool LNDGINDKPFA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == this.JMMILEFMACB;
		}

		// Token: 0x0600C896 RID: 51350 RVA: 0x0048AD81 File Offset: 0x00488F81
		internal bool FFEGPHJKMFK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.KHCJFLGCAFL() == this.JMMILEFMACB;
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x0048AD71 File Offset: 0x00488F71
		internal bool DBFPGFHEGKA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == this.JMMILEFMACB;
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x0048AD91 File Offset: 0x00488F91
		internal bool LLNDDFGPOPL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.IKACPLICNNB() == this.JMMILEFMACB;
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x0048AD61 File Offset: 0x00488F61
		internal bool AEINPAGJFME(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600C89A RID: 51354 RVA: 0x0048ADA1 File Offset: 0x00488FA1
		internal bool EKHOOPGPPGE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BBPGJKOIAKM() == this.JMMILEFMACB;
		}

		// Token: 0x0600C89B RID: 51355 RVA: 0x0048ADB1 File Offset: 0x00488FB1
		internal bool OLIGLEMPFOP(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == this.JMMILEFMACB;
		}

		// Token: 0x0600C89C RID: 51356 RVA: 0x0048AD61 File Offset: 0x00488F61
		internal bool BKNHHGBPLGH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600C89E RID: 51358 RVA: 0x0048AD51 File Offset: 0x00488F51
		internal bool BDGDIDPDBHG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.NJNBOPKBLKK() == this.JMMILEFMACB;
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x0048ADB1 File Offset: 0x00488FB1
		internal bool JKEDCEOCPJO(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x0048ADC1 File Offset: 0x00488FC1
		internal bool MEMPOPNAEDN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.PHCHLPBPKHL() == this.JMMILEFMACB;
		}

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x0048ADA1 File Offset: 0x00488FA1
		internal bool LOEAMHGMMPK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BBPGJKOIAKM() == this.JMMILEFMACB;
		}

		// Token: 0x0400175B RID: 5979
		internal ulong JMMILEFMACB;
	}
}
