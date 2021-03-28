using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

// Token: 0x020003E5 RID: 997
public class RanksSystem : Singleton<RanksSystem>
{
	// Token: 0x0600E20C RID: 57868 RVA: 0x005153F6 File Offset: 0x005135F6
	public static List<RanksSystem.PlayerTip> HACOOAAIPEN()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	// Token: 0x0600E20D RID: 57869 RVA: 0x00515404 File Offset: 0x00513604
	private IEnumerator HABBEOOPKJI()
	{
		this.GPNKIEPLHNJ = true;
		yield return new WaitForSeconds(0.5f);
		Helpers.ObtainAchievement(24);
		if (RanksSystem.GetLoadedRank(SteamUser.GetSteamID()) != null)
		{
			this.CJDDPDGBLNM = 0;
			int @int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1, null);
			if (@int == -1)
			{
				this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onfirstranktext");
				this.rankText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID(), true);
				base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.rankUpdateCanvas, true, null, true, 0.2f, true));
				this.GPNKIEPLHNJ = false;
				yield return new WaitForSeconds(5f);
				this.CloseRanksChanges();
			}
			else
			{
				this.CJDDPDGBLNM = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place - @int;
				if (this.CJDDPDGBLNM < 0)
				{
					this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangeuptext");
				}
				else
				{
					this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangedowntext");
				}
				string loadedSteamPlayername = ResourcesManager.GetLoadedSteamPlayername(SteamUser.GetSteamID(), false);
				int num = @int;
				int place = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place;
				string text = string.Concat(new object[]
				{
					"<color=#",
					Helpers.ColorToHex(RanksSystem.GetRankColor(num, true)),
					">",
					loadedSteamPlayername,
					"#",
					num,
					"</color>"
				});
				this.rankText.text = text;
				yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.rankUpdateCanvas, true, null, true, 0.2f, true));
				yield return new WaitForSeconds(0.25f);
				int num2 = 1;
				while (num != place)
				{
					num += ((this.CJDDPDGBLNM >= 0) ? num2 : (-num2));
					text = string.Concat(new object[]
					{
						"<color=#",
						Helpers.ColorToHex(RanksSystem.GetRankColor(num, true)),
						">",
						loadedSteamPlayername,
						"#",
						num,
						"</color>"
					});
					this.rankText.text = text;
					float num3 = (float)Mathf.Abs(num - RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place);
					float seconds = 0f;
					num2 = Mathf.RoundToInt(num3 / 10f);
					if (num2 < 1)
					{
						num2 = 1;
					}
					if (num3 <= 1000f)
					{
						seconds = 0.001f;
					}
					if (num3 <= 100f)
					{
						seconds = 0.005f;
					}
					if (num3 <= 50f)
					{
						seconds = 0.01f;
					}
					if (num3 <= 20f)
					{
						seconds = 0.02f;
					}
					if (num3 <= 10f)
					{
						seconds = 0.03f;
					}
					if (num3 <= 5f)
					{
						seconds = 0.05f;
					}
					if (num3 <= 2f)
					{
						num2 = 1;
						seconds = 0.1f;
					}
					if (num3 <= 1f)
					{
						num2 = 1;
						seconds = 0.2f;
					}
					if (this.GPNKIEPLHNJ)
					{
						yield return new WaitForSeconds(seconds);
					}
				}
				this.GPNKIEPLHNJ = false;
				yield return new WaitForSeconds(5f);
				this.CloseRanksChanges();
			}
		}
		yield break;
	}

	// Token: 0x0600E20E RID: 57870 RVA: 0x0051541F File Offset: 0x0051361F
	public void ViewAllRanks()
	{
		this.CloseRanksChanges();
		base.StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(0, null, null, null));
	}

	// Token: 0x0600E20F RID: 57871 RVA: 0x0051543C File Offset: 0x0051363C
	public void DAHGNLKGIJK()
	{
		base.StartCoroutine(this.IBFLEPDMPKJ(false));
	}

	// Token: 0x0600E210 RID: 57872 RVA: 0x0051544C File Offset: 0x0051364C
	public static Color GetRankShadowColor(int JMICLAEOFNP)
	{
		string mlpcomhppnh = "#000000CC";
		if (JMICLAEOFNP > 0)
		{
			if (JMICLAEOFNP <= 500)
			{
			}
			if (JMICLAEOFNP <= 100)
			{
			}
			if (JMICLAEOFNP <= 25)
			{
			}
			if (JMICLAEOFNP <= 10)
			{
				mlpcomhppnh = "#FFDA44CC";
			}
		}
		return Helpers.HexToColor(mlpcomhppnh);
	}

	// Token: 0x0600E211 RID: 57873 RVA: 0x00515495 File Offset: 0x00513695
	public void PMHFJKDEOMG()
	{
		if (GameManager.BGDFGGHAHHD() && Singleton<SaveSystem>.Instance.CMAFBKOEPLP("???", 0, null) == 1)
		{
			base.StartCoroutine(this.BLJMABEIKGD());
		}
		this.isRankChanged = false;
	}

	// Token: 0x0600E212 RID: 57874 RVA: 0x005154CC File Offset: 0x005136CC
	public static void SetLoadedRank(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].place = JMICLAEOFNP;
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new RanksSystem.PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	// Token: 0x0600E213 RID: 57875 RVA: 0x00515528 File Offset: 0x00513728
	private IEnumerator IBFLEPDMPKJ(bool HOCAOEIDOEL = false)
	{
		if (RanksSystem.KADHCHGDFCF.LNIJKGECNME == null)
		{
			RanksSystem.KADHCHGDFCF.LNIJKGECNME = new Func<bool>(RanksSystem.KADHCHGDFCF.GBKBDKHPLKG);
		}
		yield return new WaitUntil(RanksSystem.KADHCHGDFCF.LNIJKGECNME);
		if (GameManager.IsOffline)
		{
			this.isLoaded = true;
			this.FNNKEJFCOPO = new List<RanksSystem.Ban>();
			this.AHJIKFNJJNA = new List<RanksSystem.Map>();
			this.HEECFLEMGOP = new List<RanksSystem.PlayerTip>();
			Singleton<ChallengesManager>.Instance.Init(new List<Challenge>());
			yield break;
		}
		if (HOCAOEIDOEL || this.AHIIEMAHBFE < DateTime.Now)
		{
			string url = Singleton<GameManager>.Instance.CreateServerURL(this.serverStatusUrl);
			WWW www = new WWW(url);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln = "Connection error: " + www.error;
				string kokbpeccndg = "#tryagain";
				UnityAction jfpbajlmapc = new UnityAction(base.HMMBBDJNGGL);
				string nhcjnaeddjl = "#exit";
				if (RanksSystem.KADHCHGDFCF.CLCBJCKCBDD == null)
				{
					RanksSystem.KADHCHGDFCF.CLCBJCKCBDD = new UnityAction(RanksSystem.KADHCHGDFCF.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.KADHCHGDFCF.CLCBJCKCBDD));
			}
			else
			{
				ServerResponse serverResponse = JsonConvert.DeserializeObject<ServerResponse>(www.text);
				if (serverResponse.status == 1)
				{
					Singleton<Scene>.Instance.ShowCursor(true);
					Singleton<MessageBoxPanel>.Instance.DisplayMessage(serverResponse.statusMessage, "#ok", null, true, false, 0f);
				}
				if (serverResponse.status == 2)
				{
					Singleton<Scene>.Instance.ShowCursor(true);
					MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
					string statusMessage = serverResponse.statusMessage;
					string kokbpeccndg2 = "#tryagain";
					UnityAction jfpbajlmapc2 = new UnityAction(base.BJGDNLAOMHE);
					string nhcjnaeddjl2 = "#exit";
					if (RanksSystem.KADHCHGDFCF.HCLEECLNOEA == null)
					{
						RanksSystem.KADHCHGDFCF.HCLEECLNOEA = new UnityAction(RanksSystem.KADHCHGDFCF.PEOLMJGDHJK);
					}
					base.StartCoroutine(instance2.DisplayDialog(statusMessage, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.KADHCHGDFCF.HCLEECLNOEA));
				}
				else
				{
					int num = Helpers.GetGameVersion().CompareTo(serverResponse.lastVersion);
					if (num < 0)
					{
						Singleton<Scene>.Instance.ShowCursor(true);
						MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
						string dagalcailln2 = "Outdated version. Please restart the game to get lastest updates.";
						string kokbpeccndg3 = "#later";
						if (RanksSystem.KADHCHGDFCF.ADLAKIHINOM == null)
						{
							RanksSystem.KADHCHGDFCF.ADLAKIHINOM = new UnityAction(RanksSystem.KADHCHGDFCF.GLDCBMNHEGA);
						}
						UnityAction adlakihinom = RanksSystem.KADHCHGDFCF.ADLAKIHINOM;
						string nhcjnaeddjl3 = "#restart";
						if (RanksSystem.KADHCHGDFCF.KCAPKHIJOHL == null)
						{
							RanksSystem.KADHCHGDFCF.KCAPKHIJOHL = new UnityAction(RanksSystem.KADHCHGDFCF.HBICJNIKCNA);
						}
						base.StartCoroutine(instance3.DisplayDialog(dagalcailln2, kokbpeccndg3, adlakihinom, nhcjnaeddjl3, RanksSystem.KADHCHGDFCF.KCAPKHIJOHL));
					}
					CSteamID steamID = SteamUser.GetSteamID();
					WWW www2 = new WWW(Singleton<GameManager>.Instance.CreateServerURL(this.serverDataUrl) + steamID.m_SteamID.ToString());
					yield return www2;
					if (!string.IsNullOrEmpty(www2.error))
					{
						Singleton<GameManager>.Instance.DieWithError("Connection error: " + www2.error);
					}
					RanksSystem.ServerDataJson serverDataJson = JsonConvert.DeserializeObject<RanksSystem.ServerDataJson>(www2.text);
					foreach (RanksSystem.FastPlayersRank fastPlayersRank in serverDataJson.playerRanksTable.playersRanks)
					{
						try
						{
							RanksSystem.SetLoadedRank((CSteamID)ulong.Parse(fastPlayersRank.s), fastPlayersRank.p);
						}
						catch (Exception)
						{
						}
					}
					RanksSystem.TeamJson teamTable = serverDataJson.teamTable;
					foreach (ulong value in teamTable.devs)
					{
						if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value))
						{
							this.PJCIDKMPHDD[(CSteamID)value].isDev = true;
						}
					}
					foreach (ulong value2 in teamTable.moderators)
					{
						if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value2))
						{
							this.PJCIDKMPHDD[(CSteamID)value2].isModerator = true;
						}
					}
					foreach (ulong value3 in teamTable.team)
					{
						if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value3))
						{
							this.PJCIDKMPHDD[(CSteamID)value3].isTeam = true;
						}
					}
					RanksSystem.BanListJson banList = serverDataJson.banList;
					this.FNNKEJFCOPO.Clear();
					foreach (RanksSystem.Ban item in banList.bans)
					{
						this.FNNKEJFCOPO.Add(item);
					}
					RanksSystem.MapsListJson mapsList = serverDataJson.mapsList;
					this.AHJIKFNJJNA.Clear();
					foreach (RanksSystem.Map item2 in mapsList.maps)
					{
						this.AHJIKFNJJNA.Add(item2);
					}
					RanksSystem.PlayersTipsJson playersTips = serverDataJson.playersTips;
					this.HEECFLEMGOP.Clear();
					foreach (RanksSystem.PlayerTip item3 in playersTips.tips)
					{
						this.HEECFLEMGOP.Add(item3);
					}
					RanksSystem.PlayerServerData playerServerData = serverDataJson.playerServerData;
					this.bgURL = playerServerData.bgURL;
					Singleton<ChallengesManager>.Instance.Init(playerServerData.activeChallenges);
					this.AHIIEMAHBFE = DateTime.Now.AddSeconds((double)this.ranksUpdateTimeoutSeconds);
					Debug.Log("[RanksSystem] Ranks updated. Next update: " + this.AHIIEMAHBFE);
					this.isLoaded = true;
					this.KAOIOJBHFOD();
					yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.Init());
				}
			}
		}
		else
		{
			Debug.Log("[RanksSystem] Ranks: no need to update");
		}
		yield break;
	}

	// Token: 0x0600E214 RID: 57876 RVA: 0x0051554A File Offset: 0x0051374A
	public void Init()
	{
		this.isLoaded = false;
		Debug.Log("[RanksSystem] Init");
		this.ReloadServerInfo();
	}

	// Token: 0x0600E215 RID: 57877 RVA: 0x00515563 File Offset: 0x00513763
	public void KFBKMKHMAPJ()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("[Singleton] An instance of '", 1, null) == 0)
		{
			base.StartCoroutine(this.CJELLDGCDEO());
		}
		this.isRankChanged = false;
	}

	// Token: 0x0600E216 RID: 57878 RVA: 0x0051559A File Offset: 0x0051379A
	public new void Awake()
	{
		base.Awake();
		DebugCommands.Instance.AddCommand("subscribeall", new DebugCommands.DebugCommand(this.MIONODPCAFD), "Run a command for data system", "<command>", false);
	}

	// Token: 0x0600E217 RID: 57879 RVA: 0x005155C8 File Offset: 0x005137C8
	public string GetS()
	{
		return this.s;
	}

	// Token: 0x0600E218 RID: 57880 RVA: 0x005155D0 File Offset: 0x005137D0
	private void KAOIOJBHFOD()
	{
		this.isRankChanged = false;
		if (RanksSystem.GetLoadedRank(SteamUser.GetSteamID()) != null)
		{
			this.CJDDPDGBLNM = 0;
			int @int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1, null);
			if (@int == -1)
			{
				this.isRankChanged = true;
			}
			else
			{
				this.CJDDPDGBLNM = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place - @int;
				if (this.CJDDPDGBLNM != 0)
				{
					this.isRankChanged = true;
				}
			}
		}
	}

	// Token: 0x0600E219 RID: 57881 RVA: 0x00515648 File Offset: 0x00513848
	public static Color KBIACFGMDNG(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mlpcomhppnh = "_ScreenResolution";
		if (DCNGFCBFNKJ)
		{
			mlpcomhppnh = " (inactive)";
		}
		if (JMICLAEOFNP > 0)
		{
			if (JMICLAEOFNP <= -61)
			{
				mlpcomhppnh = "_Value";
			}
			if (JMICLAEOFNP <= -50)
			{
				mlpcomhppnh = "_Extra2";
			}
			if (JMICLAEOFNP <= -14)
			{
				mlpcomhppnh = "_OcclusionTexture";
			}
			if (JMICLAEOFNP <= 3)
			{
				mlpcomhppnh = "_ScreenResolution";
			}
		}
		return Helpers.HexToColor(mlpcomhppnh);
	}

	// Token: 0x0600E21A RID: 57882 RVA: 0x005156B0 File Offset: 0x005138B0
	private IEnumerator BLJMABEIKGD()
	{
		this.GPNKIEPLHNJ = true;
		yield return new WaitForSeconds(0.5f);
		Helpers.ObtainAchievement(24);
		if (RanksSystem.GetLoadedRank(SteamUser.GetSteamID()) != null)
		{
			this.CJDDPDGBLNM = 0;
			@int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1, null);
			if (@int == -1)
			{
				this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onfirstranktext");
				this.rankText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID(), true);
				base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.rankUpdateCanvas, true, null, true, 0.2f, true));
				this.GPNKIEPLHNJ = false;
				yield return new WaitForSeconds(5f);
				this.CloseRanksChanges();
			}
			else
			{
				this.CJDDPDGBLNM = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place - @int;
				if (this.CJDDPDGBLNM < 0)
				{
					this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangeuptext");
				}
				else
				{
					this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangedowntext");
				}
				loadedSteamPlayername = ResourcesManager.GetLoadedSteamPlayername(SteamUser.GetSteamID(), false);
				num = @int;
				place = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place;
				text = string.Concat(new object[]
				{
					"<color=#",
					Helpers.ColorToHex(RanksSystem.GetRankColor(num, true)),
					">",
					loadedSteamPlayername,
					"#",
					num,
					"</color>"
				});
				this.rankText.text = text;
				yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.rankUpdateCanvas, true, null, true, 0.2f, true));
				yield return new WaitForSeconds(0.25f);
				num2 = 1;
				while (num != place)
				{
					num += ((this.CJDDPDGBLNM >= 0) ? num2 : (-num2));
					text = string.Concat(new object[]
					{
						"<color=#",
						Helpers.ColorToHex(RanksSystem.GetRankColor(num, true)),
						">",
						loadedSteamPlayername,
						"#",
						num,
						"</color>"
					});
					this.rankText.text = text;
					num3 = (float)Mathf.Abs(num - RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place);
					seconds = 0f;
					num2 = Mathf.RoundToInt(num3 / 10f);
					if (num2 < 1)
					{
						num2 = 1;
					}
					if (num3 <= 1000f)
					{
						seconds = 0.001f;
					}
					if (num3 <= 100f)
					{
						seconds = 0.005f;
					}
					if (num3 <= 50f)
					{
						seconds = 0.01f;
					}
					if (num3 <= 20f)
					{
						seconds = 0.02f;
					}
					if (num3 <= 10f)
					{
						seconds = 0.03f;
					}
					if (num3 <= 5f)
					{
						seconds = 0.05f;
					}
					if (num3 <= 2f)
					{
						num2 = 1;
						seconds = 0.1f;
					}
					if (num3 <= 1f)
					{
						num2 = 1;
						seconds = 0.2f;
					}
					if (this.GPNKIEPLHNJ)
					{
						yield return new WaitForSeconds(seconds);
					}
				}
				this.GPNKIEPLHNJ = false;
				yield return new WaitForSeconds(5f);
				this.CloseRanksChanges();
			}
		}
		yield break;
	}

	// Token: 0x0600E21B RID: 57883 RVA: 0x005156CB File Offset: 0x005138CB
	public void FIBAFHIJCBM()
	{
		if (GameManager.BGDFGGHAHHD() && Singleton<SaveSystem>.Instance.JPEEFKKPFIL("[EMPTY]", 0, null) == 1)
		{
			base.StartCoroutine(this.BLJMABEIKGD());
		}
		this.isRankChanged = false;
	}

	// Token: 0x0600E21C RID: 57884 RVA: 0x00515704 File Offset: 0x00513904
	private void JHDDEDHIHLO(string[] BDGDDFKKGGA)
	{
		foreach (RanksSystem.Map map in RanksSystem.FIENAHLCHIF())
		{
			Debug.Log("MenuRecordButton" + map.GOMJAEIDHNM());
			Singleton<MapsSystem>.Instance.MMLOJFEBOHN(new PublishedFileId_t(map.id));
		}
	}

	// Token: 0x0600E21D RID: 57885 RVA: 0x00515788 File Offset: 0x00513988
	private void GDCEDAFBJKI(string[] BDGDDFKKGGA)
	{
		foreach (RanksSystem.Map map in RanksSystem.GetOfficialMapsList())
		{
			Debug.Log("Value" + map.GOMJAEIDHNM());
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(map.GOMJAEIDHNM()));
		}
	}

	// Token: 0x0600E21E RID: 57886 RVA: 0x0051580C File Offset: 0x00513A0C
	public static void LLOMEHCONNJ(ulong JMMILEFMACB)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("SearchTex" + JMMILEFMACB);
		if (mapData != null)
		{
			string ddaomdpaiep = mapData.fullLevelPath + "CameraFilterPack_Atmosphere_Rain_FX" + Helpers.levelConfigFileName;
			Debug.Log("_TimeX" + JMMILEFMACB);
			Debug.Log("..." + Helpers.CalculateMD5(ddaomdpaiep).ToUpper());
			Debug.Log("_ScreenResolution" + Math.Round((double)Helpers.GetMapDifficulty(mapData.mapData), 2).ToString().Replace('3', '{'));
			Debug.Log("/" + Helpers.GetMapMaxScore(mapData.mapData));
			Debug.Log("_Near" + Math.Round((double)mapData.mapData.musicTime, 8).ToString().Replace((char)-128, (char)-2));
		}
	}

	// Token: 0x0600E21F RID: 57887 RVA: 0x00515910 File Offset: 0x00513B10
	public IEnumerator HKGMJFOIAMJ(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		RanksSystem.OEODBJNFPHI.OBAFMKOCFDA obafmkocfda = new RanksSystem.OEODBJNFPHI.OBAFMKOCFDA();
		obafmkocfda.ELDNJAFHCFE = this;
		obafmkocfda.CBOLFPGKALK = CBOLFPGKALK;
		obafmkocfda.JKGOFJKFDED = JKGOFJKFDED;
		obafmkocfda.NINLCJIFACI = NINLCJIFACI;
		obafmkocfda.JEHNGECOPJN = JEHNGECOPJN;
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + obafmkocfda.CBOLFPGKALK);
		wwwform.AddField("maphash", obafmkocfda.JKGOFJKFDED);
		wwwform.AddField("difficulty", string.Empty + obafmkocfda.NINLCJIFACI);
		wwwform.AddField("maxScore", string.Empty + obafmkocfda.JEHNGECOPJN);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(this.updateMapMD5Url);
		WWW www = new WWW(url, data);
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#md5submitionfailed: " + www.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(obafmkocfda.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.OEODBJNFPHI.LNIJKGECNME == null)
			{
				RanksSystem.OEODBJNFPHI.LNIJKGECNME = new UnityAction(RanksSystem.OEODBJNFPHI.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.OEODBJNFPHI.LNIJKGECNME));
		}
		else if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#md5submitionfailed: " + www.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(obafmkocfda.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.OEODBJNFPHI.CLCBJCKCBDD == null)
			{
				RanksSystem.OEODBJNFPHI.CLCBJCKCBDD = new UnityAction(RanksSystem.OEODBJNFPHI.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.OEODBJNFPHI.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E220 RID: 57888 RVA: 0x00515948 File Offset: 0x00513B48
	public void OCHADIJNDJK()
	{
		this.isLoaded = true;
		Debug.Log("CameraFilterPack/Drawing_Toon");
		this.DAHGNLKGIJK();
	}

	// Token: 0x0600E221 RID: 57889 RVA: 0x00515964 File Offset: 0x00513B64
	public static Color GetRankColor(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mlpcomhppnh = "#FFFFFF";
		if (DCNGFCBFNKJ)
		{
			mlpcomhppnh = "#000000";
		}
		if (JMICLAEOFNP > 0)
		{
			if (JMICLAEOFNP <= 500)
			{
				mlpcomhppnh = "#91CCFF";
			}
			if (JMICLAEOFNP <= 100)
			{
				mlpcomhppnh = "#EA4137";
			}
			if (JMICLAEOFNP <= 25)
			{
				mlpcomhppnh = "#E14FFF";
			}
			if (JMICLAEOFNP <= 10)
			{
				mlpcomhppnh = "#FFDA44";
			}
		}
		return Helpers.HexToColor(mlpcomhppnh);
	}

	// Token: 0x0600E222 RID: 57890 RVA: 0x005153F6 File Offset: 0x005135F6
	public static List<RanksSystem.PlayerTip> JJEHNLHAAGC()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	// Token: 0x0600E223 RID: 57891 RVA: 0x005159CC File Offset: 0x00513BCC
	private void MIONODPCAFD(string[] BDGDDFKKGGA)
	{
		foreach (RanksSystem.Map map in RanksSystem.GetOfficialMapsList())
		{
			Debug.Log("Subscribe: " + map.id);
			Singleton<MapsSystem>.Instance.SubscribeAndDownload(new PublishedFileId_t(map.id));
		}
	}

	// Token: 0x0600E224 RID: 57892 RVA: 0x00515A50 File Offset: 0x00513C50
	private void NCHNFKLMMCO(string[] BDGDDFKKGGA)
	{
		foreach (RanksSystem.Map map in RanksSystem.HOCEONHMGHM())
		{
			Debug.Log(" " + map.HJPGIGBFCID());
			Singleton<MapsSystem>.Instance.MMLOJFEBOHN(new PublishedFileId_t(map.CHDCIFPPIFI()));
		}
	}

	// Token: 0x0600E225 RID: 57893 RVA: 0x00515AD4 File Offset: 0x00513CD4
	public void CloseRanksChanges()
	{
		if (!this.GPNKIEPLHNJ)
		{
			base.StopCoroutine(this.HABBEOOPKJI());
			base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.rankUpdateCanvas, false, null, true, 0.2f, true));
			Singleton<SaveSystem>.Instance.SetInt("player.currentrank", RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place, null);
		}
		else
		{
			this.GPNKIEPLHNJ = false;
		}
	}

	// Token: 0x0600E226 RID: 57894 RVA: 0x00515B43 File Offset: 0x00513D43
	public static List<RanksSystem.Map> FIENAHLCHIF()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	// Token: 0x0600E227 RID: 57895 RVA: 0x00515B4F File Offset: 0x00513D4F
	public void GEFOBOIAJHI()
	{
		if (GameManager.ACMHININJEL() && Singleton<SaveSystem>.Instance.GetInt("bans.viewed.", 1, null) == 1)
		{
			base.StartCoroutine(this.HABBEOOPKJI());
		}
		this.isRankChanged = true;
	}

	// Token: 0x0600E228 RID: 57896 RVA: 0x00515B86 File Offset: 0x00513D86
	public static RanksSystem.PlayersRank GetLoadedRank(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<RanksSystem>.Instance.PJCIDKMPHDD[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600E229 RID: 57897 RVA: 0x00515BB0 File Offset: 0x00513DB0
	public static List<RanksSystem.Ban> GOICCEIEJAI(CSteamID GDOHPDHLPBC)
	{
		RanksSystem.OFIPPJELEIA ofippjeleia = new RanksSystem.OFIPPJELEIA();
		ofippjeleia.GDOHPDHLPBC = GDOHPDHLPBC;
		return Singleton<RanksSystem>.Instance.FNNKEJFCOPO.FindAll(new Predicate<RanksSystem.Ban>(ofippjeleia.JDELIMPGFDJ));
	}

	// Token: 0x0600E22A RID: 57898 RVA: 0x00515BE5 File Offset: 0x00513DE5
	public static Dictionary<CSteamID, RanksSystem.PlayersRank> GetRanksList()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
	}

	// Token: 0x0600E22B RID: 57899 RVA: 0x00515BF4 File Offset: 0x00513DF4
	public static Color KLOEHDOKBBO(int JMICLAEOFNP, bool DCNGFCBFNKJ = false)
	{
		string mlpcomhppnh = "_TimeX";
		if (DCNGFCBFNKJ)
		{
			mlpcomhppnh = "_Value4";
		}
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 133)
			{
				mlpcomhppnh = "Remove Environment Object";
			}
			if (JMICLAEOFNP <= 57)
			{
				mlpcomhppnh = "CameraFilterPack/3D_Anomaly";
			}
			if (JMICLAEOFNP <= 46)
			{
				mlpcomhppnh = "_TimeX";
			}
			if (JMICLAEOFNP <= -86)
			{
				mlpcomhppnh = "[MapEditor] Loading music...";
			}
		}
		return Helpers.HexToColor(mlpcomhppnh);
	}

	// Token: 0x0600E22C RID: 57900 RVA: 0x00515C5C File Offset: 0x00513E5C
	public static Color DIAJLJLONAC(int JMICLAEOFNP)
	{
		string mlpcomhppnh = "settings.hideui";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= 187)
			{
			}
			if (JMICLAEOFNP <= 3)
			{
			}
			if (JMICLAEOFNP <= -74)
			{
			}
			if (JMICLAEOFNP <= 36)
			{
				mlpcomhppnh = "B";
			}
		}
		return Helpers.HexToColor(mlpcomhppnh);
	}

	// Token: 0x0600E22D RID: 57901 RVA: 0x00515CA8 File Offset: 0x00513EA8
	public static List<RanksSystem.Ban> GetCurrentPlayerBans(CSteamID GDOHPDHLPBC)
	{
		RanksSystem.OFIPPJELEIA ofippjeleia = new RanksSystem.OFIPPJELEIA();
		ofippjeleia.GDOHPDHLPBC = GDOHPDHLPBC;
		return Singleton<RanksSystem>.Instance.FNNKEJFCOPO.FindAll(new Predicate<RanksSystem.Ban>(ofippjeleia.GBKBDKHPLKG));
	}

	// Token: 0x0600E22E RID: 57902 RVA: 0x00515CDD File Offset: 0x00513EDD
	public void NKLCNJEIAFB()
	{
		this.isLoaded = true;
		Debug.Log("_BlurPass");
		this.ReloadServerInfo();
	}

	// Token: 0x0600E22F RID: 57903 RVA: 0x00515CF8 File Offset: 0x00513EF8
	public long LOLDPLJIOPH(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-56, 1, 0, 1, 1, 1)).TotalSeconds;
	}

	// Token: 0x0600E230 RID: 57904 RVA: 0x00515D24 File Offset: 0x00513F24
	public IEnumerator CKGBLPLHJFG(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		obafmkocfda = new RanksSystem.OEODBJNFPHI.OBAFMKOCFDA();
		obafmkocfda.ELDNJAFHCFE = this;
		obafmkocfda.CBOLFPGKALK = CBOLFPGKALK;
		obafmkocfda.JKGOFJKFDED = JKGOFJKFDED;
		obafmkocfda.NINLCJIFACI = NINLCJIFACI;
		obafmkocfda.JEHNGECOPJN = JEHNGECOPJN;
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + obafmkocfda.CBOLFPGKALK);
		wwwform.AddField("maphash", obafmkocfda.JKGOFJKFDED);
		wwwform.AddField("difficulty", string.Empty + obafmkocfda.NINLCJIFACI);
		wwwform.AddField("maxScore", string.Empty + obafmkocfda.JEHNGECOPJN);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.updateMapMD5Url);
		www = new WWW(url, data);
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#md5submitionfailed: " + www.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(obafmkocfda.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.OEODBJNFPHI.LNIJKGECNME == null)
			{
				RanksSystem.OEODBJNFPHI.LNIJKGECNME = new UnityAction(RanksSystem.OEODBJNFPHI.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.OEODBJNFPHI.LNIJKGECNME));
		}
		else if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#md5submitionfailed: " + www.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(obafmkocfda.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.OEODBJNFPHI.CLCBJCKCBDD == null)
			{
				RanksSystem.OEODBJNFPHI.CLCBJCKCBDD = new UnityAction(RanksSystem.OEODBJNFPHI.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.OEODBJNFPHI.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E231 RID: 57905 RVA: 0x00515D5C File Offset: 0x00513F5C
	public static void OOCPADIDCEM(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].OCBEDPHDKMN(JMICLAEOFNP);
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new RanksSystem.PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	// Token: 0x0600E232 RID: 57906 RVA: 0x00515DB8 File Offset: 0x00513FB8
	private IEnumerator KBBCCGACIFJ(bool HOCAOEIDOEL = false)
	{
		if (RanksSystem.KADHCHGDFCF.LNIJKGECNME == null)
		{
			RanksSystem.KADHCHGDFCF.LNIJKGECNME = new Func<bool>(RanksSystem.KADHCHGDFCF.GBKBDKHPLKG);
		}
		yield return new WaitUntil(RanksSystem.KADHCHGDFCF.LNIJKGECNME);
		if (GameManager.IsOffline)
		{
			this.isLoaded = true;
			this.FNNKEJFCOPO = new List<RanksSystem.Ban>();
			this.AHJIKFNJJNA = new List<RanksSystem.Map>();
			this.HEECFLEMGOP = new List<RanksSystem.PlayerTip>();
			Singleton<ChallengesManager>.Instance.Init(new List<Challenge>());
			yield break;
		}
		if (HOCAOEIDOEL || this.AHIIEMAHBFE < DateTime.Now)
		{
			url = Singleton<GameManager>.Instance.CreateServerURL(this.serverStatusUrl);
			www = new WWW(url);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln = "Connection error: " + www.error;
				string kokbpeccndg = "#tryagain";
				UnityAction jfpbajlmapc = new UnityAction(base.HMMBBDJNGGL);
				string nhcjnaeddjl = "#exit";
				if (RanksSystem.KADHCHGDFCF.CLCBJCKCBDD == null)
				{
					RanksSystem.KADHCHGDFCF.CLCBJCKCBDD = new UnityAction(RanksSystem.KADHCHGDFCF.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.KADHCHGDFCF.CLCBJCKCBDD));
			}
			else
			{
				serverResponse = JsonConvert.DeserializeObject<ServerResponse>(www.text);
				if (serverResponse.status == 1)
				{
					Singleton<Scene>.Instance.ShowCursor(true);
					Singleton<MessageBoxPanel>.Instance.DisplayMessage(serverResponse.statusMessage, "#ok", null, true, false, 0f);
				}
				if (serverResponse.status == 2)
				{
					Singleton<Scene>.Instance.ShowCursor(true);
					MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
					string statusMessage = serverResponse.statusMessage;
					string kokbpeccndg2 = "#tryagain";
					UnityAction jfpbajlmapc2 = new UnityAction(base.BJGDNLAOMHE);
					string nhcjnaeddjl2 = "#exit";
					if (RanksSystem.KADHCHGDFCF.HCLEECLNOEA == null)
					{
						RanksSystem.KADHCHGDFCF.HCLEECLNOEA = new UnityAction(RanksSystem.KADHCHGDFCF.PEOLMJGDHJK);
					}
					base.StartCoroutine(instance2.DisplayDialog(statusMessage, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.KADHCHGDFCF.HCLEECLNOEA));
				}
				else
				{
					num = Helpers.GetGameVersion().CompareTo(serverResponse.lastVersion);
					if (num < 0)
					{
						Singleton<Scene>.Instance.ShowCursor(true);
						MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
						string dagalcailln2 = "Outdated version. Please restart the game to get lastest updates.";
						string kokbpeccndg3 = "#later";
						if (RanksSystem.KADHCHGDFCF.ADLAKIHINOM == null)
						{
							RanksSystem.KADHCHGDFCF.ADLAKIHINOM = new UnityAction(RanksSystem.KADHCHGDFCF.GLDCBMNHEGA);
						}
						UnityAction adlakihinom = RanksSystem.KADHCHGDFCF.ADLAKIHINOM;
						string nhcjnaeddjl3 = "#restart";
						if (RanksSystem.KADHCHGDFCF.KCAPKHIJOHL == null)
						{
							RanksSystem.KADHCHGDFCF.KCAPKHIJOHL = new UnityAction(RanksSystem.KADHCHGDFCF.HBICJNIKCNA);
						}
						base.StartCoroutine(instance3.DisplayDialog(dagalcailln2, kokbpeccndg3, adlakihinom, nhcjnaeddjl3, RanksSystem.KADHCHGDFCF.KCAPKHIJOHL));
					}
					steamID = SteamUser.GetSteamID();
					www2 = new WWW(Singleton<GameManager>.Instance.CreateServerURL(this.serverDataUrl) + steamID.m_SteamID.ToString());
					yield return www2;
					if (!string.IsNullOrEmpty(www2.error))
					{
						Singleton<GameManager>.Instance.DieWithError("Connection error: " + www2.error);
					}
					serverDataJson = JsonConvert.DeserializeObject<RanksSystem.ServerDataJson>(www2.text);
					enumerator = serverDataJson.playerRanksTable.playersRanks.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							RanksSystem.FastPlayersRank fastPlayersRank = enumerator.Current;
							try
							{
								RanksSystem.SetLoadedRank((CSteamID)ulong.Parse(fastPlayersRank.s), fastPlayersRank.p);
							}
							catch (Exception)
							{
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					teamTable = serverDataJson.teamTable;
					enumerator2 = teamTable.devs.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ulong value = enumerator2.Current;
							if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value))
							{
								this.PJCIDKMPHDD[(CSteamID)value].isDev = true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					enumerator3 = teamTable.moderators.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							ulong value2 = enumerator3.Current;
							if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value2))
							{
								this.PJCIDKMPHDD[(CSteamID)value2].isModerator = true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
					}
					enumerator4 = teamTable.team.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							ulong value3 = enumerator4.Current;
							if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value3))
							{
								this.PJCIDKMPHDD[(CSteamID)value3].isTeam = true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
					}
					banList = serverDataJson.banList;
					this.FNNKEJFCOPO.Clear();
					enumerator5 = banList.bans.GetEnumerator();
					try
					{
						while (enumerator5.MoveNext())
						{
							RanksSystem.Ban item = enumerator5.Current;
							this.FNNKEJFCOPO.Add(item);
						}
					}
					finally
					{
						((IDisposable)enumerator5).Dispose();
					}
					mapsList = serverDataJson.mapsList;
					this.AHJIKFNJJNA.Clear();
					enumerator6 = mapsList.maps.GetEnumerator();
					try
					{
						while (enumerator6.MoveNext())
						{
							RanksSystem.Map item2 = enumerator6.Current;
							this.AHJIKFNJJNA.Add(item2);
						}
					}
					finally
					{
						((IDisposable)enumerator6).Dispose();
					}
					playersTips = serverDataJson.playersTips;
					this.HEECFLEMGOP.Clear();
					enumerator7 = playersTips.tips.GetEnumerator();
					try
					{
						while (enumerator7.MoveNext())
						{
							RanksSystem.PlayerTip item3 = enumerator7.Current;
							this.HEECFLEMGOP.Add(item3);
						}
					}
					finally
					{
						((IDisposable)enumerator7).Dispose();
					}
					playerServerData = serverDataJson.playerServerData;
					this.bgURL = playerServerData.bgURL;
					Singleton<ChallengesManager>.Instance.Init(playerServerData.activeChallenges);
					this.AHIIEMAHBFE = DateTime.Now.AddSeconds((double)this.ranksUpdateTimeoutSeconds);
					Debug.Log("[RanksSystem] Ranks updated. Next update: " + this.AHIIEMAHBFE);
					this.isLoaded = true;
					this.KAOIOJBHFOD();
					yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.Init());
				}
			}
		}
		else
		{
			Debug.Log("[RanksSystem] Ranks: no need to update");
		}
		yield break;
	}

	// Token: 0x0600E233 RID: 57907 RVA: 0x005155C8 File Offset: 0x005137C8
	public string LHCBFIBKHLA()
	{
		return this.s;
	}

	// Token: 0x0600E234 RID: 57908 RVA: 0x00515DDC File Offset: 0x00513FDC
	public IEnumerator ABLBIOGGGKC(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		obafmkocfda = new RanksSystem.OEODBJNFPHI.OBAFMKOCFDA();
		obafmkocfda.ELDNJAFHCFE = this;
		obafmkocfda.CBOLFPGKALK = CBOLFPGKALK;
		obafmkocfda.JKGOFJKFDED = JKGOFJKFDED;
		obafmkocfda.NINLCJIFACI = NINLCJIFACI;
		obafmkocfda.JEHNGECOPJN = JEHNGECOPJN;
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + obafmkocfda.CBOLFPGKALK);
		wwwform.AddField("maphash", obafmkocfda.JKGOFJKFDED);
		wwwform.AddField("difficulty", string.Empty + obafmkocfda.NINLCJIFACI);
		wwwform.AddField("maxScore", string.Empty + obafmkocfda.JEHNGECOPJN);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.updateMapMD5Url);
		www = new WWW(url, data);
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#md5submitionfailed: " + www.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(obafmkocfda.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.OEODBJNFPHI.LNIJKGECNME == null)
			{
				RanksSystem.OEODBJNFPHI.LNIJKGECNME = new UnityAction(RanksSystem.OEODBJNFPHI.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.OEODBJNFPHI.LNIJKGECNME));
		}
		else if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#md5submitionfailed: " + www.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(obafmkocfda.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.OEODBJNFPHI.CLCBJCKCBDD == null)
			{
				RanksSystem.OEODBJNFPHI.CLCBJCKCBDD = new UnityAction(RanksSystem.OEODBJNFPHI.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.OEODBJNFPHI.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E235 RID: 57909 RVA: 0x00515E14 File Offset: 0x00514014
	public long ToUnixTimeSeconds(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	// Token: 0x0600E236 RID: 57910 RVA: 0x00515E40 File Offset: 0x00514040
	public static bool IsOfficial(ulong JMMILEFMACB, bool LFCLCNMPCNM = false)
	{
		RanksSystem.EGNLMILBMMC egnlmilbmmc = new RanksSystem.EGNLMILBMMC();
		egnlmilbmmc.JMMILEFMACB = JMMILEFMACB;
		if (!Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Exists(new Predicate<RanksSystem.Map>(egnlmilbmmc.GBKBDKHPLKG)))
		{
			return false;
		}
		if (!LFCLCNMPCNM)
		{
			return true;
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("workshop." + egnlmilbmmc.JMMILEFMACB);
		if (mapData != null)
		{
			string ddaomdpaiep = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			return !string.IsNullOrEmpty(Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find(new Predicate<RanksSystem.Map>(egnlmilbmmc.HMMBBDJNGGL)).hash) && Helpers.CalculateMD5(ddaomdpaiep).ToUpper() == Singleton<RanksSystem>.Instance.AHJIKFNJJNA.Find(new Predicate<RanksSystem.Map>(egnlmilbmmc.NEIDGMKKCBI)).hash.ToUpper();
		}
		return false;
	}

	// Token: 0x0600E237 RID: 57911 RVA: 0x00515F23 File Offset: 0x00514123
	public void DisplayRanksChanges()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("settings.enablerankingnotifications", 1, null) == 1)
		{
			base.StartCoroutine(this.HABBEOOPKJI());
		}
		this.isRankChanged = false;
	}

	// Token: 0x0600E238 RID: 57912 RVA: 0x00515F5C File Offset: 0x0051415C
	public IEnumerator SubmitScore(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		RanksSystem.LDHFOHFCJDO.MJLCLAMAKIN mjlclamakin = new RanksSystem.LDHFOHFCJDO.MJLCLAMAKIN();
		mjlclamakin.KAJEFPDIIJA = this;
		mjlclamakin.CBOLFPGKALK = CBOLFPGKALK;
		mjlclamakin.MHGOFBOPNLG = MHGOFBOPNLG;
		mjlclamakin.EPLJLGAIJCM = EPLJLGAIJCM;
		mjlclamakin.LODDNOOJFPA = LODDNOOJFPA;
		mjlclamakin.FNPFEOPCHHJ = FNPFEOPCHHJ;
		mjlclamakin.FBDLGEIDEDA = FBDLGEIDEDA;
		mjlclamakin.JKGOFJKFDED = JKGOFJKFDED;
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + mjlclamakin.CBOLFPGKALK);
		wwwform.AddField("gamemode", string.Empty + (int)mjlclamakin.MHGOFBOPNLG);
		wwwform.AddField("maphash", mjlclamakin.JKGOFJKFDED);
		wwwform.AddField("score", string.Empty + mjlclamakin.EPLJLGAIJCM);
		wwwform.AddField("accuracy", string.Empty + mjlclamakin.LODDNOOJFPA);
		wwwform.AddField("misses", string.Empty + mjlclamakin.FNPFEOPCHHJ);
		wwwform.AddField("replayData", string.Empty + mjlclamakin.FBDLGEIDEDA);
		byte[] data = wwwform.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(this.submitScoreUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		string text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + this.s + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#scoresubmitionfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(mjlclamakin.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.LDHFOHFCJDO.LNIJKGECNME == null)
			{
				RanksSystem.LDHFOHFCJDO.LNIJKGECNME = new UnityAction(RanksSystem.LDHFOHFCJDO.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.LDHFOHFCJDO.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(mjlclamakin.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD == null)
			{
				RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD = new UnityAction(RanksSystem.LDHFOHFCJDO.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E239 RID: 57913 RVA: 0x00515B43 File Offset: 0x00513D43
	public static List<RanksSystem.Map> HOCEONHMGHM()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	// Token: 0x0600E23A RID: 57914 RVA: 0x00515B43 File Offset: 0x00513D43
	public static List<RanksSystem.Map> GetOfficialMapsList()
	{
		return Singleton<RanksSystem>.Instance.AHJIKFNJJNA;
	}

	// Token: 0x0600E23B RID: 57915 RVA: 0x00515FAC File Offset: 0x005141AC
	public IEnumerator DJHAGBKILNI(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		mjlclamakin = new RanksSystem.LDHFOHFCJDO.MJLCLAMAKIN();
		mjlclamakin.KAJEFPDIIJA = this;
		mjlclamakin.CBOLFPGKALK = CBOLFPGKALK;
		mjlclamakin.MHGOFBOPNLG = MHGOFBOPNLG;
		mjlclamakin.EPLJLGAIJCM = EPLJLGAIJCM;
		mjlclamakin.LODDNOOJFPA = LODDNOOJFPA;
		mjlclamakin.FNPFEOPCHHJ = FNPFEOPCHHJ;
		mjlclamakin.FBDLGEIDEDA = FBDLGEIDEDA;
		mjlclamakin.JKGOFJKFDED = JKGOFJKFDED;
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + mjlclamakin.CBOLFPGKALK);
		wwwform.AddField("gamemode", string.Empty + (int)mjlclamakin.MHGOFBOPNLG);
		wwwform.AddField("maphash", mjlclamakin.JKGOFJKFDED);
		wwwform.AddField("score", string.Empty + mjlclamakin.EPLJLGAIJCM);
		wwwform.AddField("accuracy", string.Empty + mjlclamakin.LODDNOOJFPA);
		wwwform.AddField("misses", string.Empty + mjlclamakin.FNPFEOPCHHJ);
		wwwform.AddField("replayData", string.Empty + mjlclamakin.FBDLGEIDEDA);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.submitScoreUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + this.s + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#scoresubmitionfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(mjlclamakin.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.LDHFOHFCJDO.LNIJKGECNME == null)
			{
				RanksSystem.LDHFOHFCJDO.LNIJKGECNME = new UnityAction(RanksSystem.LDHFOHFCJDO.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.LDHFOHFCJDO.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(mjlclamakin.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD == null)
			{
				RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD = new UnityAction(RanksSystem.LDHFOHFCJDO.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E23C RID: 57916 RVA: 0x00515FFC File Offset: 0x005141FC
	public static void PrintStats(ulong JMMILEFMACB)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("workshop." + JMMILEFMACB);
		if (mapData != null)
		{
			string ddaomdpaiep = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			Debug.Log("[MapsStats] Map ID: " + JMMILEFMACB);
			Debug.Log("[MapsStats] Hash: " + Helpers.CalculateMD5(ddaomdpaiep).ToUpper());
			Debug.Log("[MapsStats] Difficulty: " + Math.Round((double)Helpers.GetMapDifficulty(mapData.mapData), 2).ToString().Replace(',', '.'));
			Debug.Log("[MapsStats] Max score: " + Helpers.GetMapMaxScore(mapData.mapData));
			Debug.Log("[MapsStats] Length: " + Math.Round((double)mapData.mapData.musicTime, 2).ToString().Replace(',', '.'));
		}
	}

	// Token: 0x0600E23E RID: 57918 RVA: 0x005161B8 File Offset: 0x005143B8
	public IEnumerator UpdateOfficialMap(string CBOLFPGKALK, string JKGOFJKFDED, float NINLCJIFACI, int JEHNGECOPJN)
	{
		obafmkocfda = new RanksSystem.OEODBJNFPHI.OBAFMKOCFDA();
		obafmkocfda.ELDNJAFHCFE = this;
		obafmkocfda.CBOLFPGKALK = CBOLFPGKALK;
		obafmkocfda.JKGOFJKFDED = JKGOFJKFDED;
		obafmkocfda.NINLCJIFACI = NINLCJIFACI;
		obafmkocfda.JEHNGECOPJN = JEHNGECOPJN;
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + obafmkocfda.CBOLFPGKALK);
		wwwform.AddField("maphash", obafmkocfda.JKGOFJKFDED);
		wwwform.AddField("difficulty", string.Empty + obafmkocfda.NINLCJIFACI);
		wwwform.AddField("maxScore", string.Empty + obafmkocfda.JEHNGECOPJN);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.updateMapMD5Url);
		www = new WWW(url, data);
		yield return www;
		if (!string.IsNullOrEmpty(www.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#md5submitionfailed: " + www.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(obafmkocfda.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.OEODBJNFPHI.LNIJKGECNME == null)
			{
				RanksSystem.OEODBJNFPHI.LNIJKGECNME = new UnityAction(RanksSystem.OEODBJNFPHI.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.OEODBJNFPHI.LNIJKGECNME));
		}
		else if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#md5submitionfailed: " + www.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(obafmkocfda.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.OEODBJNFPHI.CLCBJCKCBDD == null)
			{
				RanksSystem.OEODBJNFPHI.CLCBJCKCBDD = new UnityAction(RanksSystem.OEODBJNFPHI.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.OEODBJNFPHI.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E23F RID: 57919 RVA: 0x005161F0 File Offset: 0x005143F0
	private void DFCILMAJFIC()
	{
		this.isRankChanged = true;
		if (RanksSystem.GetLoadedRank(SteamUser.GetSteamID()) != null)
		{
			this.CJDDPDGBLNM = 1;
			int num = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_Near", -1, null);
			if (num == -1)
			{
				this.isRankChanged = false;
			}
			else
			{
				this.CJDDPDGBLNM = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).IEOGJOLGLFI() - num;
				if (this.CJDDPDGBLNM != 0)
				{
					this.isRankChanged = true;
				}
			}
		}
	}

	// Token: 0x0600E240 RID: 57920 RVA: 0x00516268 File Offset: 0x00514468
	public static void KNMHMBBCNJK(ulong JMMILEFMACB)
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData("visible" + JMMILEFMACB);
		if (mapData != null)
		{
			string ddaomdpaiep = mapData.fullLevelPath + "Hello" + Helpers.levelConfigFileName;
			Debug.Log("inventory.selected." + JMMILEFMACB);
			Debug.Log("OxOD.lastPath" + Helpers.CalculateMD5(ddaomdpaiep).ToUpper());
			Debug.Log("_TimeX" + Math.Round((double)Helpers.GetMapDifficulty(mapData.mapData), 5).ToString().Replace('r', ':'));
			Debug.Log(" " + Helpers.GetMapMaxScore(mapData.mapData));
			Debug.Log("action" + Math.Round((double)mapData.mapData.musicTime, 3).ToString().Replace((char)-18, (char)-120));
		}
	}

	// Token: 0x0600E241 RID: 57921 RVA: 0x0051636C File Offset: 0x0051456C
	public long NHBOHPPIALG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(129, 1, 1, 0, 1, 1)).TotalSeconds;
	}

	// Token: 0x0600E242 RID: 57922 RVA: 0x00516397 File Offset: 0x00514597
	public void ReloadServerInfo(bool HOCAOEIDOEL)
	{
		base.StartCoroutine(this.PEPBPLCDPEH(HOCAOEIDOEL));
	}

	// Token: 0x0600E243 RID: 57923 RVA: 0x005163A7 File Offset: 0x005145A7
	public void ILMJPBGLAGI(ulong KKPILMGBPMD, int BMAEINMDAFF)
	{
		object[] array = new object[6];
		array[0] = "settings.fps";
		array[0] = KKPILMGBPMD;
		array[4] = "SupportLogger OnFailedToConnectToPhoton(";
		array[4] = BMAEINMDAFF;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600E244 RID: 57924 RVA: 0x005163DB File Offset: 0x005145DB
	public void FPPFNPMJECN()
	{
		this.CloseRanksChanges();
		base.StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(1, null, null, null));
	}

	// Token: 0x0600E245 RID: 57925 RVA: 0x005163F8 File Offset: 0x005145F8
	public void SubmitUserVote(ulong KKPILMGBPMD, int BMAEINMDAFF)
	{
		Debug.Log(string.Concat(new object[]
		{
			"SubmitUserVote:",
			KKPILMGBPMD,
			" - ",
			BMAEINMDAFF
		}));
	}

	// Token: 0x0600E246 RID: 57926 RVA: 0x0051642C File Offset: 0x0051462C
	public IEnumerator HPJEBNGAHNA(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		mjlclamakin = new RanksSystem.LDHFOHFCJDO.MJLCLAMAKIN();
		mjlclamakin.KAJEFPDIIJA = this;
		mjlclamakin.CBOLFPGKALK = CBOLFPGKALK;
		mjlclamakin.MHGOFBOPNLG = MHGOFBOPNLG;
		mjlclamakin.EPLJLGAIJCM = EPLJLGAIJCM;
		mjlclamakin.LODDNOOJFPA = LODDNOOJFPA;
		mjlclamakin.FNPFEOPCHHJ = FNPFEOPCHHJ;
		mjlclamakin.FBDLGEIDEDA = FBDLGEIDEDA;
		mjlclamakin.JKGOFJKFDED = JKGOFJKFDED;
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + mjlclamakin.CBOLFPGKALK);
		wwwform.AddField("gamemode", string.Empty + (int)mjlclamakin.MHGOFBOPNLG);
		wwwform.AddField("maphash", mjlclamakin.JKGOFJKFDED);
		wwwform.AddField("score", string.Empty + mjlclamakin.EPLJLGAIJCM);
		wwwform.AddField("accuracy", string.Empty + mjlclamakin.LODDNOOJFPA);
		wwwform.AddField("misses", string.Empty + mjlclamakin.FNPFEOPCHHJ);
		wwwform.AddField("replayData", string.Empty + mjlclamakin.FBDLGEIDEDA);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.submitScoreUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + this.s + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#scoresubmitionfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(mjlclamakin.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.LDHFOHFCJDO.LNIJKGECNME == null)
			{
				RanksSystem.LDHFOHFCJDO.LNIJKGECNME = new UnityAction(RanksSystem.LDHFOHFCJDO.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.LDHFOHFCJDO.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(mjlclamakin.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD == null)
			{
				RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD = new UnityAction(RanksSystem.LDHFOHFCJDO.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E247 RID: 57927 RVA: 0x0051647C File Offset: 0x0051467C
	public IEnumerator JAHLDECAKGK(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		mjlclamakin = new RanksSystem.LDHFOHFCJDO.MJLCLAMAKIN();
		mjlclamakin.KAJEFPDIIJA = this;
		mjlclamakin.CBOLFPGKALK = CBOLFPGKALK;
		mjlclamakin.MHGOFBOPNLG = MHGOFBOPNLG;
		mjlclamakin.EPLJLGAIJCM = EPLJLGAIJCM;
		mjlclamakin.LODDNOOJFPA = LODDNOOJFPA;
		mjlclamakin.FNPFEOPCHHJ = FNPFEOPCHHJ;
		mjlclamakin.FBDLGEIDEDA = FBDLGEIDEDA;
		mjlclamakin.JKGOFJKFDED = JKGOFJKFDED;
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + mjlclamakin.CBOLFPGKALK);
		wwwform.AddField("gamemode", string.Empty + (int)mjlclamakin.MHGOFBOPNLG);
		wwwform.AddField("maphash", mjlclamakin.JKGOFJKFDED);
		wwwform.AddField("score", string.Empty + mjlclamakin.EPLJLGAIJCM);
		wwwform.AddField("accuracy", string.Empty + mjlclamakin.LODDNOOJFPA);
		wwwform.AddField("misses", string.Empty + mjlclamakin.FNPFEOPCHHJ);
		wwwform.AddField("replayData", string.Empty + mjlclamakin.FBDLGEIDEDA);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.submitScoreUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + this.s + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#scoresubmitionfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(mjlclamakin.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.LDHFOHFCJDO.LNIJKGECNME == null)
			{
				RanksSystem.LDHFOHFCJDO.LNIJKGECNME = new UnityAction(RanksSystem.LDHFOHFCJDO.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.LDHFOHFCJDO.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(mjlclamakin.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD == null)
			{
				RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD = new UnityAction(RanksSystem.LDHFOHFCJDO.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E248 RID: 57928 RVA: 0x005153F6 File Offset: 0x005135F6
	public static List<RanksSystem.PlayerTip> EAGFIMBCDCP()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	// Token: 0x0600E249 RID: 57929 RVA: 0x005164CC File Offset: 0x005146CC
	private IEnumerator PEPBPLCDPEH(bool HOCAOEIDOEL = false)
	{
		if (RanksSystem.KADHCHGDFCF.LNIJKGECNME == null)
		{
			RanksSystem.KADHCHGDFCF.LNIJKGECNME = new Func<bool>(RanksSystem.KADHCHGDFCF.GBKBDKHPLKG);
		}
		yield return new WaitUntil(RanksSystem.KADHCHGDFCF.LNIJKGECNME);
		if (GameManager.IsOffline)
		{
			this.isLoaded = true;
			this.FNNKEJFCOPO = new List<RanksSystem.Ban>();
			this.AHJIKFNJJNA = new List<RanksSystem.Map>();
			this.HEECFLEMGOP = new List<RanksSystem.PlayerTip>();
			Singleton<ChallengesManager>.Instance.Init(new List<Challenge>());
			yield break;
		}
		if (HOCAOEIDOEL || this.AHIIEMAHBFE < DateTime.Now)
		{
			url = Singleton<GameManager>.Instance.CreateServerURL(this.serverStatusUrl);
			www = new WWW(url);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Singleton<Scene>.Instance.ShowCursor(true);
				MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
				string dagalcailln = "Connection error: " + www.error;
				string kokbpeccndg = "#tryagain";
				UnityAction jfpbajlmapc = new UnityAction(base.HMMBBDJNGGL);
				string nhcjnaeddjl = "#exit";
				if (RanksSystem.KADHCHGDFCF.CLCBJCKCBDD == null)
				{
					RanksSystem.KADHCHGDFCF.CLCBJCKCBDD = new UnityAction(RanksSystem.KADHCHGDFCF.NEIDGMKKCBI);
				}
				base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.KADHCHGDFCF.CLCBJCKCBDD));
			}
			else
			{
				serverResponse = JsonConvert.DeserializeObject<ServerResponse>(www.text);
				if (serverResponse.status == 1)
				{
					Singleton<Scene>.Instance.ShowCursor(true);
					Singleton<MessageBoxPanel>.Instance.DisplayMessage(serverResponse.statusMessage, "#ok", null, true, false, 0f);
				}
				if (serverResponse.status == 2)
				{
					Singleton<Scene>.Instance.ShowCursor(true);
					MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
					string statusMessage = serverResponse.statusMessage;
					string kokbpeccndg2 = "#tryagain";
					UnityAction jfpbajlmapc2 = new UnityAction(base.BJGDNLAOMHE);
					string nhcjnaeddjl2 = "#exit";
					if (RanksSystem.KADHCHGDFCF.HCLEECLNOEA == null)
					{
						RanksSystem.KADHCHGDFCF.HCLEECLNOEA = new UnityAction(RanksSystem.KADHCHGDFCF.PEOLMJGDHJK);
					}
					base.StartCoroutine(instance2.DisplayDialog(statusMessage, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.KADHCHGDFCF.HCLEECLNOEA));
				}
				else
				{
					num = Helpers.GetGameVersion().CompareTo(serverResponse.lastVersion);
					if (num < 0)
					{
						Singleton<Scene>.Instance.ShowCursor(true);
						MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
						string dagalcailln2 = "Outdated version. Please restart the game to get lastest updates.";
						string kokbpeccndg3 = "#later";
						if (RanksSystem.KADHCHGDFCF.ADLAKIHINOM == null)
						{
							RanksSystem.KADHCHGDFCF.ADLAKIHINOM = new UnityAction(RanksSystem.KADHCHGDFCF.GLDCBMNHEGA);
						}
						UnityAction adlakihinom = RanksSystem.KADHCHGDFCF.ADLAKIHINOM;
						string nhcjnaeddjl3 = "#restart";
						if (RanksSystem.KADHCHGDFCF.KCAPKHIJOHL == null)
						{
							RanksSystem.KADHCHGDFCF.KCAPKHIJOHL = new UnityAction(RanksSystem.KADHCHGDFCF.HBICJNIKCNA);
						}
						base.StartCoroutine(instance3.DisplayDialog(dagalcailln2, kokbpeccndg3, adlakihinom, nhcjnaeddjl3, RanksSystem.KADHCHGDFCF.KCAPKHIJOHL));
					}
					steamID = SteamUser.GetSteamID();
					www2 = new WWW(Singleton<GameManager>.Instance.CreateServerURL(this.serverDataUrl) + steamID.m_SteamID.ToString());
					yield return www2;
					if (!string.IsNullOrEmpty(www2.error))
					{
						Singleton<GameManager>.Instance.DieWithError("Connection error: " + www2.error);
					}
					serverDataJson = JsonConvert.DeserializeObject<RanksSystem.ServerDataJson>(www2.text);
					enumerator = serverDataJson.playerRanksTable.playersRanks.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							RanksSystem.FastPlayersRank fastPlayersRank = enumerator.Current;
							try
							{
								RanksSystem.SetLoadedRank((CSteamID)ulong.Parse(fastPlayersRank.s), fastPlayersRank.p);
							}
							catch (Exception)
							{
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					teamTable = serverDataJson.teamTable;
					enumerator2 = teamTable.devs.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ulong value = enumerator2.Current;
							if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value))
							{
								this.PJCIDKMPHDD[(CSteamID)value].isDev = true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					enumerator3 = teamTable.moderators.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							ulong value2 = enumerator3.Current;
							if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value2))
							{
								this.PJCIDKMPHDD[(CSteamID)value2].isModerator = true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
					}
					enumerator4 = teamTable.team.GetEnumerator();
					try
					{
						while (enumerator4.MoveNext())
						{
							ulong value3 = enumerator4.Current;
							if (this.PJCIDKMPHDD.ContainsKey((CSteamID)value3))
							{
								this.PJCIDKMPHDD[(CSteamID)value3].isTeam = true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
					}
					banList = serverDataJson.banList;
					this.FNNKEJFCOPO.Clear();
					enumerator5 = banList.bans.GetEnumerator();
					try
					{
						while (enumerator5.MoveNext())
						{
							RanksSystem.Ban item = enumerator5.Current;
							this.FNNKEJFCOPO.Add(item);
						}
					}
					finally
					{
						((IDisposable)enumerator5).Dispose();
					}
					mapsList = serverDataJson.mapsList;
					this.AHJIKFNJJNA.Clear();
					enumerator6 = mapsList.maps.GetEnumerator();
					try
					{
						while (enumerator6.MoveNext())
						{
							RanksSystem.Map item2 = enumerator6.Current;
							this.AHJIKFNJJNA.Add(item2);
						}
					}
					finally
					{
						((IDisposable)enumerator6).Dispose();
					}
					playersTips = serverDataJson.playersTips;
					this.HEECFLEMGOP.Clear();
					enumerator7 = playersTips.tips.GetEnumerator();
					try
					{
						while (enumerator7.MoveNext())
						{
							RanksSystem.PlayerTip item3 = enumerator7.Current;
							this.HEECFLEMGOP.Add(item3);
						}
					}
					finally
					{
						((IDisposable)enumerator7).Dispose();
					}
					playerServerData = serverDataJson.playerServerData;
					this.bgURL = playerServerData.bgURL;
					Singleton<ChallengesManager>.Instance.Init(playerServerData.activeChallenges);
					this.AHIIEMAHBFE = DateTime.Now.AddSeconds((double)this.ranksUpdateTimeoutSeconds);
					Debug.Log("[RanksSystem] Ranks updated. Next update: " + this.AHIIEMAHBFE);
					this.isLoaded = true;
					this.KAOIOJBHFOD();
					yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.Init());
				}
			}
		}
		else
		{
			Debug.Log("[RanksSystem] Ranks: no need to update");
		}
		yield break;
	}

	// Token: 0x0600E24A RID: 57930 RVA: 0x005164EE File Offset: 0x005146EE
	public new void JIJPHEDDIHC()
	{
		base.Awake();
		DebugCommands.GLEFOHOMBFC().GIALDAIHBBD("EnableRankedNotificationsToggle", new DebugCommands.DebugCommand(this.MIONODPCAFD), "_MatrixSize", "workshop.", true);
	}

	// Token: 0x0600E24B RID: 57931 RVA: 0x0051651C File Offset: 0x0051471C
	public void ReloadServerInfo()
	{
		base.StartCoroutine(this.PEPBPLCDPEH(false));
	}

	// Token: 0x0600E24C RID: 57932 RVA: 0x005153F6 File Offset: 0x005135F6
	public static List<RanksSystem.PlayerTip> GetTipsList()
	{
		return Singleton<RanksSystem>.Instance.HEECFLEMGOP;
	}

	// Token: 0x0600E24D RID: 57933 RVA: 0x0051652C File Offset: 0x0051472C
	public void BEEPICMONOD()
	{
		if (GameManager.IsOwner() && Singleton<SaveSystem>.Instance.CEKEOJDAEOD("player.licenceaccepted", 0, null) == 0)
		{
			base.StartCoroutine(this.BLJMABEIKGD());
		}
		this.isRankChanged = true;
	}

	// Token: 0x0600E24E RID: 57934 RVA: 0x00516564 File Offset: 0x00514764
	private IEnumerator CJELLDGCDEO()
	{
		this.GPNKIEPLHNJ = true;
		yield return new WaitForSeconds(0.5f);
		Helpers.ObtainAchievement(24);
		if (RanksSystem.GetLoadedRank(SteamUser.GetSteamID()) != null)
		{
			this.CJDDPDGBLNM = 0;
			@int = Singleton<SaveSystem>.Instance.GetInt("player.currentrank", -1, null);
			if (@int == -1)
			{
				this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onfirstranktext");
				this.rankText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID(), true);
				base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.rankUpdateCanvas, true, null, true, 0.2f, true));
				this.GPNKIEPLHNJ = false;
				yield return new WaitForSeconds(5f);
				this.CloseRanksChanges();
			}
			else
			{
				this.CJDDPDGBLNM = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place - @int;
				if (this.CJDDPDGBLNM < 0)
				{
					this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangeuptext");
				}
				else
				{
					this.messageText.text = LocalizationService.Instance.GetLocalizatedText("#onrankchangedowntext");
				}
				loadedSteamPlayername = ResourcesManager.GetLoadedSteamPlayername(SteamUser.GetSteamID(), false);
				num = @int;
				place = RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place;
				text = string.Concat(new object[]
				{
					"<color=#",
					Helpers.ColorToHex(RanksSystem.GetRankColor(num, true)),
					">",
					loadedSteamPlayername,
					"#",
					num,
					"</color>"
				});
				this.rankText.text = text;
				yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.rankUpdateCanvas, true, null, true, 0.2f, true));
				yield return new WaitForSeconds(0.25f);
				num2 = 1;
				while (num != place)
				{
					num += ((this.CJDDPDGBLNM >= 0) ? num2 : (-num2));
					text = string.Concat(new object[]
					{
						"<color=#",
						Helpers.ColorToHex(RanksSystem.GetRankColor(num, true)),
						">",
						loadedSteamPlayername,
						"#",
						num,
						"</color>"
					});
					this.rankText.text = text;
					num3 = (float)Mathf.Abs(num - RanksSystem.GetLoadedRank(SteamUser.GetSteamID()).place);
					seconds = 0f;
					num2 = Mathf.RoundToInt(num3 / 10f);
					if (num2 < 1)
					{
						num2 = 1;
					}
					if (num3 <= 1000f)
					{
						seconds = 0.001f;
					}
					if (num3 <= 100f)
					{
						seconds = 0.005f;
					}
					if (num3 <= 50f)
					{
						seconds = 0.01f;
					}
					if (num3 <= 20f)
					{
						seconds = 0.02f;
					}
					if (num3 <= 10f)
					{
						seconds = 0.03f;
					}
					if (num3 <= 5f)
					{
						seconds = 0.05f;
					}
					if (num3 <= 2f)
					{
						num2 = 1;
						seconds = 0.1f;
					}
					if (num3 <= 1f)
					{
						num2 = 1;
						seconds = 0.2f;
					}
					if (this.GPNKIEPLHNJ)
					{
						yield return new WaitForSeconds(seconds);
					}
				}
				this.GPNKIEPLHNJ = false;
				yield return new WaitForSeconds(5f);
				this.CloseRanksChanges();
			}
		}
		yield break;
	}

	// Token: 0x0600E24F RID: 57935 RVA: 0x00516580 File Offset: 0x00514780
	public static void KLPPDPJFMDE(CSteamID HFEFHOPOLIK, int JMICLAEOFNP)
	{
		CSteamID key = HFEFHOPOLIK;
		if (Singleton<RanksSystem>.Instance.PJCIDKMPHDD.ContainsKey(key))
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD[key].IEGJMMDEDCH(JMICLAEOFNP);
		}
		else
		{
			Singleton<RanksSystem>.Instance.PJCIDKMPHDD.Add(key, new RanksSystem.PlayersRank(HFEFHOPOLIK.m_SteamID, JMICLAEOFNP));
		}
	}

	// Token: 0x0600E250 RID: 57936 RVA: 0x005165DC File Offset: 0x005147DC
	public static Color GCOPNCEDLCP(int JMICLAEOFNP)
	{
		string mlpcomhppnh = "You need to have a child LayoutGroup content set for the list: ";
		if (JMICLAEOFNP > 1)
		{
			if (JMICLAEOFNP <= -111)
			{
			}
			if (JMICLAEOFNP <= -109)
			{
			}
			if (JMICLAEOFNP <= 71)
			{
			}
			if (JMICLAEOFNP <= 117)
			{
				mlpcomhppnh = "_TimeX";
			}
		}
		return Helpers.HexToColor(mlpcomhppnh);
	}

	// Token: 0x0600E251 RID: 57937 RVA: 0x00516628 File Offset: 0x00514828
	public IEnumerator CFGMHNBNPFB(string CBOLFPGKALK, GameScene.GameMode MHGOFBOPNLG, int EPLJLGAIJCM, float LODDNOOJFPA, int FNPFEOPCHHJ, string FBDLGEIDEDA, string JKGOFJKFDED)
	{
		mjlclamakin = new RanksSystem.LDHFOHFCJDO.MJLCLAMAKIN();
		mjlclamakin.KAJEFPDIIJA = this;
		mjlclamakin.CBOLFPGKALK = CBOLFPGKALK;
		mjlclamakin.MHGOFBOPNLG = MHGOFBOPNLG;
		mjlclamakin.EPLJLGAIJCM = EPLJLGAIJCM;
		mjlclamakin.LODDNOOJFPA = LODDNOOJFPA;
		mjlclamakin.FNPFEOPCHHJ = FNPFEOPCHHJ;
		mjlclamakin.FBDLGEIDEDA = FBDLGEIDEDA;
		mjlclamakin.JKGOFJKFDED = JKGOFJKFDED;
		wwwform = new WWWForm();
		wwwform.AddField("ticket", SteamManager.Instance.steamTempKey);
		wwwform.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wwwform.AddField("mapid", string.Empty + mjlclamakin.CBOLFPGKALK);
		wwwform.AddField("gamemode", string.Empty + (int)mjlclamakin.MHGOFBOPNLG);
		wwwform.AddField("maphash", mjlclamakin.JKGOFJKFDED);
		wwwform.AddField("score", string.Empty + mjlclamakin.EPLJLGAIJCM);
		wwwform.AddField("accuracy", string.Empty + mjlclamakin.LODDNOOJFPA);
		wwwform.AddField("misses", string.Empty + mjlclamakin.FNPFEOPCHHJ);
		wwwform.AddField("replayData", string.Empty + mjlclamakin.FBDLGEIDEDA);
		data = wwwform.data;
		uri = Singleton<GameManager>.Instance.CreateServerURL(this.submitScoreUrl);
		unityWebRequest = UnityWebRequest.Post(uri, wwwform);
		text = this.ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + this.s + text, text + Encoding.UTF8.GetString(wwwform.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln = "#scoresubmitionfailed: " + unityWebRequest.error;
			string kokbpeccndg = "#tryagain";
			UnityAction jfpbajlmapc = new UnityAction(mjlclamakin.GBKBDKHPLKG);
			string nhcjnaeddjl = "#close";
			if (RanksSystem.LDHFOHFCJDO.LNIJKGECNME == null)
			{
				RanksSystem.LDHFOHFCJDO.LNIJKGECNME = new UnityAction(RanksSystem.LDHFOHFCJDO.GBKBDKHPLKG);
			}
			base.StartCoroutine(instance.DisplayDialog(dagalcailln, kokbpeccndg, jfpbajlmapc, nhcjnaeddjl, RanksSystem.LDHFOHFCJDO.LNIJKGECNME));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			this.ReloadServerInfo(true);
		}
		else
		{
			MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
			string dagalcailln2 = "#scoresubmitionfailed: " + unityWebRequest.downloadHandler.text;
			string kokbpeccndg2 = "#tryagain";
			UnityAction jfpbajlmapc2 = new UnityAction(mjlclamakin.HMMBBDJNGGL);
			string nhcjnaeddjl2 = "#close";
			if (RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD == null)
			{
				RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD = new UnityAction(RanksSystem.LDHFOHFCJDO.HMMBBDJNGGL);
			}
			base.StartCoroutine(instance2.DisplayDialog(dagalcailln2, kokbpeccndg2, jfpbajlmapc2, nhcjnaeddjl2, RanksSystem.LDHFOHFCJDO.CLCBJCKCBDD));
		}
		yield break;
	}

	// Token: 0x0600E252 RID: 57938 RVA: 0x00515BE5 File Offset: 0x00513DE5
	public static Dictionary<CSteamID, RanksSystem.PlayersRank> LKFLELLCLAN()
	{
		return Singleton<RanksSystem>.Instance.PJCIDKMPHDD;
	}

	// Token: 0x0600E253 RID: 57939 RVA: 0x00516678 File Offset: 0x00514878
	public int GetRanksChange()
	{
		return this.CJDDPDGBLNM;
	}

	// Token: 0x0400199A RID: 6554
	public string serverDataUrl = "?";

	// Token: 0x0400199B RID: 6555
	public string ranksUrl = "?";

	// Token: 0x0400199C RID: 6556
	public string leaderboardUrl = "?";

	// Token: 0x0400199D RID: 6557
	public string submitScoreUrl = "?";

	// Token: 0x0400199E RID: 6558
	public string updateMapMD5Url = "?";

	// Token: 0x0400199F RID: 6559
	public string serverStatusUrl = "?";

	// Token: 0x040019A0 RID: 6560
	[SerializeField]
	private string s = "?";

	// Token: 0x040019A1 RID: 6561
	[SerializeField]
	private string t = "?";

	// Token: 0x040019A2 RID: 6562
	[HideInInspector]
	public string bgURL = string.Empty;

	// Token: 0x040019A3 RID: 6563
	private List<RanksSystem.Ban> FNNKEJFCOPO = new List<RanksSystem.Ban>();

	// Token: 0x040019A4 RID: 6564
	private List<RanksSystem.Map> AHJIKFNJJNA = new List<RanksSystem.Map>();

	// Token: 0x040019A5 RID: 6565
	private List<RanksSystem.PlayerTip> HEECFLEMGOP = new List<RanksSystem.PlayerTip>();

	// Token: 0x040019A6 RID: 6566
	private Dictionary<CSteamID, RanksSystem.PlayersRank> PJCIDKMPHDD = new Dictionary<CSteamID, RanksSystem.PlayersRank>();

	// Token: 0x040019A7 RID: 6567
	[HideInInspector]
	public bool isLoaded;

	// Token: 0x040019A8 RID: 6568
	public float ranksUpdateTimeoutSeconds = 300f;

	// Token: 0x040019A9 RID: 6569
	private DateTime AHIIEMAHBFE = DateTime.Now;

	// Token: 0x040019AA RID: 6570
	private int CJDDPDGBLNM;

	// Token: 0x040019AB RID: 6571
	public bool isRankChanged;

	// Token: 0x040019AC RID: 6572
	public GameObject rankUpdateCanvas;

	// Token: 0x040019AD RID: 6573
	public Text messageText;

	// Token: 0x040019AE RID: 6574
	public Text rankText;

	// Token: 0x040019AF RID: 6575
	private bool GPNKIEPLHNJ;

	// Token: 0x020003E6 RID: 998
	public class MapReplay
	{
		// Token: 0x0600E254 RID: 57940 RVA: 0x00516680 File Offset: 0x00514880
		public void MNNALKPIKMN(int DPNHODJHGJL)
		{
			this.<MMDKNNCMDLL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E255 RID: 57941 RVA: 0x00516689 File Offset: 0x00514889
		public int GKCGCAKMNCN()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E256 RID: 57942 RVA: 0x00516691 File Offset: 0x00514891
		public string INHBFHBPHEC()
		{
			return this.<JLPMPKAGJJM>k__BackingField;
		}

		// Token: 0x0600E257 RID: 57943 RVA: 0x00516699 File Offset: 0x00514899
		public string OHJHPBNPLDB()
		{
			return this.<CFNGABCIAOD>k__BackingField;
		}

		// Token: 0x0600E258 RID: 57944 RVA: 0x005166A1 File Offset: 0x005148A1
		public void BAAIGBGEGNH(float DPNHODJHGJL)
		{
			this.<EPDGGHBOLBD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E259 RID: 57945 RVA: 0x005166AA File Offset: 0x005148AA
		public int AHDCAJGNOBB()
		{
			return this.<MMDKNNCMDLL>k__BackingField;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600E25A RID: 57946 RVA: 0x00516691 File Offset: 0x00514891
		// (set) Token: 0x0600E25F RID: 57951 RVA: 0x005166D3 File Offset: 0x005148D3
		public string playerSteamID { get; set; }

		// Token: 0x0600E25B RID: 57947 RVA: 0x005166B2 File Offset: 0x005148B2
		public string OLNCPGEKJEI()
		{
			return this.<KPCNOKBIIOE>k__BackingField;
		}

		// Token: 0x0600E25C RID: 57948 RVA: 0x005166BA File Offset: 0x005148BA
		public float ADJFAJIOKBI()
		{
			return this.<GBELECOEGLP>k__BackingField;
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600E25D RID: 57949 RVA: 0x005166C2 File Offset: 0x005148C2
		// (set) Token: 0x0600E283 RID: 57987 RVA: 0x00516A9D File Offset: 0x00514C9D
		public string mapHash { get; set; }

		// Token: 0x0600E25E RID: 57950 RVA: 0x005166CA File Offset: 0x005148CA
		public void CBFMHIONBNP(float DPNHODJHGJL)
		{
			this.<GBELECOEGLP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E260 RID: 57952 RVA: 0x005166DC File Offset: 0x005148DC
		public void ALPBACEOLHK(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600E26C RID: 57964 RVA: 0x005167BF File Offset: 0x005149BF
		// (set) Token: 0x0600E261 RID: 57953 RVA: 0x005166A1 File Offset: 0x005148A1
		public float accuracy { get; set; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600E262 RID: 57954 RVA: 0x005166E5 File Offset: 0x005148E5
		// (set) Token: 0x0600E263 RID: 57955 RVA: 0x005166ED File Offset: 0x005148ED
		public string mapID { get; set; }

		// Token: 0x0600E264 RID: 57956 RVA: 0x005166F8 File Offset: 0x005148F8
		public void LABLMLOLOLN(int EPLJLGAIJCM, int EJBAOLHHOEK, float LODDNOOJFPA, int FNPFEOPCHHJ, float NMEHALJBEFC, float HKNBDMAPEHC)
		{
			this.finished = DateTime.Now.ToString("Environment/SunBase_");
			this.score = EPLJLGAIJCM;
			this.checkpointsUsed = EJBAOLHHOEK;
			this.BAAIGBGEGNH(LODDNOOJFPA);
			this.KFLEHIHMIKD(FNPFEOPCHHJ);
			this.comboScore = NMEHALJBEFC;
			this.penalty = HKNBDMAPEHC;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600E265 RID: 57957 RVA: 0x0051674A File Offset: 0x0051494A
		// (set) Token: 0x0600E287 RID: 57991 RVA: 0x005167D0 File Offset: 0x005149D0
		public int misses { get; set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600E27A RID: 57978 RVA: 0x005167F6 File Offset: 0x005149F6
		// (set) Token: 0x0600E266 RID: 57958 RVA: 0x00516752 File Offset: 0x00514952
		public float penalty { get; set; }

		// Token: 0x0600E267 RID: 57959 RVA: 0x0051675B File Offset: 0x0051495B
		public string FBBNJPDPCOM()
		{
			return this.<GFBGFMGKKOL>k__BackingField;
		}

		// Token: 0x0600E268 RID: 57960 RVA: 0x00516764 File Offset: 0x00514964
		public void FinishPlaying(int EPLJLGAIJCM, int EJBAOLHHOEK, float LODDNOOJFPA, int FNPFEOPCHHJ, float NMEHALJBEFC, float HKNBDMAPEHC)
		{
			this.finished = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			this.score = EPLJLGAIJCM;
			this.checkpointsUsed = EJBAOLHHOEK;
			this.accuracy = LODDNOOJFPA;
			this.misses = FNPFEOPCHHJ;
			this.comboScore = NMEHALJBEFC;
			this.penalty = HKNBDMAPEHC;
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600E27F RID: 57983 RVA: 0x005166B2 File Offset: 0x005148B2
		// (set) Token: 0x0600E269 RID: 57961 RVA: 0x005167B6 File Offset: 0x005149B6
		public string devID { get; set; }

		// Token: 0x0600E26A RID: 57962 RVA: 0x005167B6 File Offset: 0x005149B6
		public void OEMPACFCAID(string DPNHODJHGJL)
		{
			this.<KPCNOKBIIOE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E26B RID: 57963 RVA: 0x005166E5 File Offset: 0x005148E5
		public string MHLEJOCDAPI()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600E26D RID: 57965 RVA: 0x00516699 File Offset: 0x00514899
		// (set) Token: 0x0600E282 RID: 57986 RVA: 0x00516A94 File Offset: 0x00514C94
		public string started { get; set; }

		// Token: 0x0600E26E RID: 57966 RVA: 0x005167C7 File Offset: 0x005149C7
		public void JPFCOLONFEO(float DPNHODJHGJL)
		{
			this.<MBMMFCIJMBL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600E26F RID: 57967 RVA: 0x005166BA File Offset: 0x005148BA
		// (set) Token: 0x0600E278 RID: 57976 RVA: 0x005166CA File Offset: 0x005148CA
		public float arcsDelay { get; set; }

		// Token: 0x0600E270 RID: 57968 RVA: 0x005166AA File Offset: 0x005148AA
		public int KKPAGOGNLLN()
		{
			return this.<MMDKNNCMDLL>k__BackingField;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600E280 RID: 57984 RVA: 0x005167FE File Offset: 0x005149FE
		// (set) Token: 0x0600E271 RID: 57969 RVA: 0x005167C7 File Offset: 0x005149C7
		public float comboScore { get; set; }

		// Token: 0x0600E272 RID: 57970 RVA: 0x005167D0 File Offset: 0x005149D0
		public void KFLEHIHMIKD(int DPNHODJHGJL)
		{
			this.<DIOMDJNIGAG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E273 RID: 57971 RVA: 0x005167D9 File Offset: 0x005149D9
		public void GEGLANKEMBP(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			this.playerActions.Add(new RanksSystem.PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600E27C RID: 57980 RVA: 0x00516689 File Offset: 0x00514889
		// (set) Token: 0x0600E274 RID: 57972 RVA: 0x005166DC File Offset: 0x005148DC
		public int score { get; set; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600E288 RID: 57992 RVA: 0x0051675B File Offset: 0x0051495B
		// (set) Token: 0x0600E275 RID: 57973 RVA: 0x005167ED File Offset: 0x005149ED
		public string finished { get; set; }

		// Token: 0x0600E276 RID: 57974 RVA: 0x005166E5 File Offset: 0x005148E5
		public string KPCIHJJFEHL()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600E277 RID: 57975 RVA: 0x005166AA File Offset: 0x005148AA
		// (set) Token: 0x0600E289 RID: 57993 RVA: 0x00516680 File Offset: 0x00514880
		public int checkpointsUsed { get; set; }

		// Token: 0x0600E279 RID: 57977 RVA: 0x005167D9 File Offset: 0x005149D9
		public void RecordAction(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			this.playerActions.Add(new RanksSystem.PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		// Token: 0x0600E27B RID: 57979 RVA: 0x005166A1 File Offset: 0x005148A1
		public void KNNGFGPDGDG(float DPNHODJHGJL)
		{
			this.<EPDGGHBOLBD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E27D RID: 57981 RVA: 0x00516691 File Offset: 0x00514891
		public string HKDPMHFDHLE()
		{
			return this.<JLPMPKAGJJM>k__BackingField;
		}

		// Token: 0x0600E27E RID: 57982 RVA: 0x005167C7 File Offset: 0x005149C7
		public void ALIPKOCBIEH(float DPNHODJHGJL)
		{
			this.<MBMMFCIJMBL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E281 RID: 57985 RVA: 0x00516808 File Offset: 0x00514A08
		public MapReplay(string CAFHKDIIDEE, string CNNLEIEFLOA, string KINNJOLFPCF, float CDDAEGKAHCJ)
		{
			this.mapID = CAFHKDIIDEE;
			this.mapHash = CNNLEIEFLOA;
			this.playerSteamID = KINNJOLFPCF;
			this.arcsDelay = CDDAEGKAHCJ;
			this.score = 0;
			this.checkpointsUsed = 0;
			this.accuracy = 0f;
			this.misses = 0;
			this.comboScore = 0f;
			this.penalty = 0f;
			this.started = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			this.devID = SystemInfo.deviceUniqueIdentifier;
			this.finished = null;
			this.playerSettings = new List<string>();
			List<string> list = new List<string>
			{
				"note.0",
				"note.1",
				"note.2",
				"note.3",
				"note.4",
				"note.5",
				"note.6",
				"note.7",
				"powerup.0",
				"powerup.1"
			};
			this.playerSettings.Add("bloomintencity:" + Singleton<SaveSystem>.Instance.GetFloat("settings.shaders.bloomintencity", 0.05f, null));
			this.playerSettings.Add("cameramovements:" + Singleton<SaveSystem>.Instance.GetFloat("settings.cameramovements", 1f, null));
			bool flag = (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinnormal", 1, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal) || (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			this.playerSettings.Add("hitsounds:" + flag);
			foreach (string text in list)
			{
				this.playerSettings.Add(string.Concat(new object[]
				{
					text,
					":",
					hardInput.GetKeyCode(text, false),
					",",
					hardInput.GetKeyCode(text, true)
				}));
			}
			this.playerActions = new List<RanksSystem.PlayerAction>();
			this.activeProcesses = new List<string>();
		}

		// Token: 0x0600E284 RID: 57988 RVA: 0x00516A94 File Offset: 0x00514C94
		public void DJJAIHCMFLH(string DPNHODJHGJL)
		{
			this.<CFNGABCIAOD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E285 RID: 57989 RVA: 0x005166ED File Offset: 0x005148ED
		public void IDEFLKNEHCA(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E286 RID: 57990 RVA: 0x005167D9 File Offset: 0x005149D9
		public void KECKMCKFJLI(float MBGGNGDHPNF, string NOJGGCLPPAM)
		{
			this.playerActions.Add(new RanksSystem.PlayerAction(MBGGNGDHPNF, NOJGGCLPPAM));
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x00516689 File Offset: 0x00514889
		public int AGGEANMACEL()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x040019BD RID: 6589
		public List<string> playerSettings;

		// Token: 0x040019BE RID: 6590
		public List<string> activeProcesses;

		// Token: 0x040019BF RID: 6591
		public List<RanksSystem.PlayerAction> playerActions;
	}

	// Token: 0x020003E7 RID: 999
	public class PlayerAction
	{
		// Token: 0x0600E28B RID: 57995 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string FHPLICNCMJG()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600E28C RID: 57996 RVA: 0x00516AA6 File Offset: 0x00514CA6
		// (set) Token: 0x0600E2AD RID: 58029 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public string data { get; set; }

		// Token: 0x0600E28D RID: 57997 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void MGGPHEFBLLC(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E28E RID: 57998 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void JFDDODKOBKL(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E28F RID: 57999 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void GLFLPMLJAIP(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E290 RID: 58000 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string OEFMIIHJFNN()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E291 RID: 58001 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string LINMBCLGDJC()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E292 RID: 58002 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float MPJDEFGNDML()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E293 RID: 58003 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float DPMEGFMKKHF()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E294 RID: 58004 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void JMFCCIKLDGF(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E295 RID: 58005 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void KLIBDEPDIBB(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E296 RID: 58006 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string EMJFELHJBPP()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E297 RID: 58007 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float EGKNIKKBMHG()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E298 RID: 58008 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void ALJMCIEAOJJ(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E299 RID: 58009 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float OKNHCNBMKNM()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E29A RID: 58010 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void DINMEAALJLE(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E29B RID: 58011 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void HPKPBONNIIJ(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E29C RID: 58012 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void AAPHEONJOGN(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E29D RID: 58013 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void CKJBHFIFKEE(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E29E RID: 58014 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void JADGHAKGMAG(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E29F RID: 58015 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void FOFFNHCENLG(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2A0 RID: 58016 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float HIPGCCOLOBB()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2A1 RID: 58017 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void DCFGJHIFBPE(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2A2 RID: 58018 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void IKBDCPIBANP(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2A3 RID: 58019 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string NLDPIACJDFO()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2A4 RID: 58020 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float OGAJOMAJJEA()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600E2DA RID: 58074 RVA: 0x00516AC0 File Offset: 0x00514CC0
		// (set) Token: 0x0600E2A5 RID: 58021 RVA: 0x00516AAE File Offset: 0x00514CAE
		public float time { get; set; }

		// Token: 0x0600E2A6 RID: 58022 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float GOBMLHPOMGH()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2A7 RID: 58023 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void DJBNHANOCCM(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2A8 RID: 58024 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void BCINDAHCIHG(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x00516AC8 File Offset: 0x00514CC8
		public PlayerAction(float EHHBHEJBHNG, string NOJGGCLPPAM)
		{
			this.time = EHHBHEJBHNG;
			this.data = NOJGGCLPPAM;
		}

		// Token: 0x0600E2AA RID: 58026 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string BHBIKOHJFLL()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2AB RID: 58027 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void PKKGKBDBLOM(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2AC RID: 58028 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void FMPANGMCDCG(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2AE RID: 58030 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float CAGPFDOGAEE()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2AF RID: 58031 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void FPDHPBKIPPP(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2B0 RID: 58032 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float NFHAEDENGFG()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2B1 RID: 58033 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void FAKBDKJNGLO(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2B2 RID: 58034 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float NKJLAHDNLGE()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2B3 RID: 58035 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string IIFKHLLKHKJ()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2B4 RID: 58036 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float NKBENMLIAOG()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2B5 RID: 58037 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void HKHMFCGAIPD(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2B6 RID: 58038 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string MJGCACEAPMP()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2B7 RID: 58039 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void IPMIGIKBBAI(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2B8 RID: 58040 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void FLJHBGENNLG(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2B9 RID: 58041 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void DAIGFABFNDP(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2BA RID: 58042 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string NPDMBOIJNFP()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2BB RID: 58043 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string HKJHJHOEPOI()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2BC RID: 58044 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void JNNKHPDPKAA(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2BD RID: 58045 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void PEONMPPIDPB(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2BE RID: 58046 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void DPIAKBMCCKB(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2BF RID: 58047 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void BNEEHEMCOOL(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2C0 RID: 58048 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void FEJBEAHFLCO(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2C1 RID: 58049 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string FFAPEEBDLND()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2C2 RID: 58050 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void HHJHNMHDGMP(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2C3 RID: 58051 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void OHOIHAJAECD(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2C4 RID: 58052 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float MLNCDABNMAB()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2C5 RID: 58053 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float ACJADDMBIOJ()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2C6 RID: 58054 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void DIFAHPKFMCB(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2C7 RID: 58055 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string OIBFKLBKDIB()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string MIAHCJNCOEH()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2C9 RID: 58057 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void CENHKGFEJBF(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2CA RID: 58058 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void KFDMLIPCDOF(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2CB RID: 58059 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void MCHDGNHPCBJ(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2CC RID: 58060 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float FMNDMGHADNF()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2CD RID: 58061 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float HAELIPIDHFL()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2CE RID: 58062 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string CHBGKJHAAPO()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2CF RID: 58063 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string KIBFMCMMOOH()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2D0 RID: 58064 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string GIJIGNEODJH()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2D1 RID: 58065 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string CGFLCMMLGNF()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2D2 RID: 58066 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void NJOGBDFCCBG(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2D3 RID: 58067 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void FFADJABEDOG(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2D4 RID: 58068 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void JHKHMIDNJKM(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2D5 RID: 58069 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float BOJHGCFKCAA()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void CLNPNGCGFEK(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2D7 RID: 58071 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void CKDHANKHHBF(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2D8 RID: 58072 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void MMEELLOIOAG(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2D9 RID: 58073 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float NLPPPEBNEJE()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2DB RID: 58075 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float KAGHNDMLIGC()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2DC RID: 58076 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float MFFDNFIEBGB()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2DD RID: 58077 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string MLKANPGNNFN()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2DE RID: 58078 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string JJPHFEFDPFO()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string IHEBHELBJMA()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float CPEEHJGCCLG()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void CAGDCMFEOBG(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2E2 RID: 58082 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float ADGNLKEKEEP()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2E3 RID: 58083 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float LOOKAPGLACH()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2E4 RID: 58084 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void LOKEMPIAHJN(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2E5 RID: 58085 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void LIBDNBFECMC(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void EFPECDECMAH(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float NMDOCAKCGKC()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string LHOLBOGGKEN()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2E9 RID: 58089 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void LJELCCEFFGM(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2EA RID: 58090 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void FIEOAADIFCJ(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2EB RID: 58091 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string ADJKNCJBPJJ()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2EC RID: 58092 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string POKJLHBLOJB()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void CCONNCMKCEK(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2EE RID: 58094 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string HKGBJNACLMD()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2EF RID: 58095 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string PLIHGPHOJNN()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2F0 RID: 58096 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void ILBEMPPPEBJ(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void EEEEOMNNBCC(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string HGBDMGFNDEM()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float JFKCAFGHIOE()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2F4 RID: 58100 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float BEDGGEKMHJF()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2F5 RID: 58101 RVA: 0x00516AC0 File Offset: 0x00514CC0
		public float NHKLKCJEBLN()
		{
			return this.<EBONJCKKKID>k__BackingField;
		}

		// Token: 0x0600E2F6 RID: 58102 RVA: 0x00516AB7 File Offset: 0x00514CB7
		public void HDNCEHKKGMF(string DPNHODJHGJL)
		{
			this.<OEBNPBFJGNK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2F7 RID: 58103 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void KGHJKEIBHKN(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2F8 RID: 58104 RVA: 0x00516AA6 File Offset: 0x00514CA6
		public string BHLPGDMPHIM()
		{
			return this.<OEBNPBFJGNK>k__BackingField;
		}

		// Token: 0x0600E2F9 RID: 58105 RVA: 0x00516AAE File Offset: 0x00514CAE
		public void GKAFABKGPDK(float DPNHODJHGJL)
		{
			this.<EBONJCKKKID>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003E8 RID: 1000
	public class PlayersRank
	{
		// Token: 0x0600E2FA RID: 58106 RVA: 0x00516ADE File Offset: 0x00514CDE
		public void FMJIHEDNCPD(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2FB RID: 58107 RVA: 0x00516ADE File Offset: 0x00514CDE
		public void BLCEFMIHELL(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E2FC RID: 58108 RVA: 0x00516AE7 File Offset: 0x00514CE7
		public float KCFACDJDGLN()
		{
			return this.<BAKCNHNMHPE>k__BackingField;
		}

		// Token: 0x0600E2FD RID: 58109 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void KGDEDHLMOOF(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x00516AF8 File Offset: 0x00514CF8
		// (set) Token: 0x0600E32B RID: 58155 RVA: 0x00516AEF File Offset: 0x00514CEF
		public int place { get; set; }

		// Token: 0x0600E2FF RID: 58111 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void IEGJMMDEDCH(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E300 RID: 58112 RVA: 0x00516B00 File Offset: 0x00514D00
		public void BPLGFNBPGBN(float DPNHODJHGJL)
		{
			this.<HKGAAOFNHED>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E301 RID: 58113 RVA: 0x00516AF8 File Offset: 0x00514CF8
		public int JCDLILAFFAJ()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E302 RID: 58114 RVA: 0x00516B00 File Offset: 0x00514D00
		public void JIGCOIOFDNC(float DPNHODJHGJL)
		{
			this.<HKGAAOFNHED>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E303 RID: 58115 RVA: 0x00516B09 File Offset: 0x00514D09
		public float ANHKILGBOAB()
		{
			return this.<JAJBFAMAHFB>k__BackingField;
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x00516ADE File Offset: 0x00514CDE
		public void PMHHCJJMJMA(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x00516B11 File Offset: 0x00514D11
		public string MNBGIHCKJCE()
		{
			return this.<INOGKDMPHOF>k__BackingField;
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600E33A RID: 58170 RVA: 0x00516B11 File Offset: 0x00514D11
		// (set) Token: 0x0600E306 RID: 58118 RVA: 0x00516B19 File Offset: 0x00514D19
		public string updated { get; set; }

		// Token: 0x0600E307 RID: 58119 RVA: 0x00516AF8 File Offset: 0x00514CF8
		public int IGKJJMCLABK()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600E345 RID: 58181 RVA: 0x00516AE7 File Offset: 0x00514CE7
		// (set) Token: 0x0600E308 RID: 58120 RVA: 0x00516B22 File Offset: 0x00514D22
		public float avgAccuracy { get; set; }

		// Token: 0x0600E309 RID: 58121 RVA: 0x00516B19 File Offset: 0x00514D19
		public void GHDHFEEBKKI(string DPNHODJHGJL)
		{
			this.<INOGKDMPHOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600E330 RID: 58160 RVA: 0x00516B2B File Offset: 0x00514D2B
		// (set) Token: 0x0600E30A RID: 58122 RVA: 0x00516B00 File Offset: 0x00514D00
		public float totalScore { get; set; }

		// Token: 0x0600E30B RID: 58123 RVA: 0x00516B2B File Offset: 0x00514D2B
		public float OPILKKHHCMC()
		{
			return this.<HKGAAOFNHED>k__BackingField;
		}

		// Token: 0x0600E30C RID: 58124 RVA: 0x00516B2B File Offset: 0x00514D2B
		public float BFOOKAMIAIJ()
		{
			return this.<HKGAAOFNHED>k__BackingField;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600E342 RID: 58178 RVA: 0x00516B09 File Offset: 0x00514D09
		// (set) Token: 0x0600E30D RID: 58125 RVA: 0x00516B33 File Offset: 0x00514D33
		public float avgMisses { get; set; }

		// Token: 0x0600E30E RID: 58126 RVA: 0x00516B33 File Offset: 0x00514D33
		public void PMBKDIHAGJD(float DPNHODJHGJL)
		{
			this.<JAJBFAMAHFB>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E30F RID: 58127 RVA: 0x00516B22 File Offset: 0x00514D22
		public void IJOGIMHOGOF(float DPNHODJHGJL)
		{
			this.<BAKCNHNMHPE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E310 RID: 58128 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void BANBLOKFLBD(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E311 RID: 58129 RVA: 0x00516AF8 File Offset: 0x00514CF8
		public int CJILPHFNMEB()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E312 RID: 58130 RVA: 0x00516B09 File Offset: 0x00514D09
		public float DOFKADFJBDI()
		{
			return this.<JAJBFAMAHFB>k__BackingField;
		}

		// Token: 0x0600E313 RID: 58131 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void DBNDBHBGPLE(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x00516AF8 File Offset: 0x00514CF8
		public int INIGKHLOKCD()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x00516B22 File Offset: 0x00514D22
		public void MBONDLKMKGN(float DPNHODJHGJL)
		{
			this.<BAKCNHNMHPE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E316 RID: 58134 RVA: 0x00516B11 File Offset: 0x00514D11
		public string MLLJGLFOOOI()
		{
			return this.<INOGKDMPHOF>k__BackingField;
		}

		// Token: 0x0600E317 RID: 58135 RVA: 0x00516B09 File Offset: 0x00514D09
		public float PFKMDOLEJBF()
		{
			return this.<JAJBFAMAHFB>k__BackingField;
		}

		// Token: 0x0600E318 RID: 58136 RVA: 0x00516B33 File Offset: 0x00514D33
		public void LCMOHCPLGGF(float DPNHODJHGJL)
		{
			this.<JAJBFAMAHFB>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E319 RID: 58137 RVA: 0x00516B00 File Offset: 0x00514D00
		public void PAPMJOFOIDJ(float DPNHODJHGJL)
		{
			this.<HKGAAOFNHED>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E31A RID: 58138 RVA: 0x00516B33 File Offset: 0x00514D33
		public void ILINMDCFIHG(float DPNHODJHGJL)
		{
			this.<JAJBFAMAHFB>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E31B RID: 58139 RVA: 0x00516ADE File Offset: 0x00514CDE
		public void NOEPDOGCBAN(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E31C RID: 58140 RVA: 0x00516B33 File Offset: 0x00514D33
		public void LOGEHEGDCEP(float DPNHODJHGJL)
		{
			this.<JAJBFAMAHFB>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x00516B11 File Offset: 0x00514D11
		public string DPLFGHEHGMI()
		{
			return this.<INOGKDMPHOF>k__BackingField;
		}

		// Token: 0x0600E31E RID: 58142 RVA: 0x00516B3C File Offset: 0x00514D3C
		public ulong CCBBBFKMCOH()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x00516ADE File Offset: 0x00514CDE
		public void LCLLGHAMDKD(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E320 RID: 58144 RVA: 0x00516B11 File Offset: 0x00514D11
		public string LILJDHFLNON()
		{
			return this.<INOGKDMPHOF>k__BackingField;
		}

		// Token: 0x0600E321 RID: 58145 RVA: 0x00516B3C File Offset: 0x00514D3C
		public ulong NOOGEIPEOIL()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E322 RID: 58146 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void OCBEDPHDKMN(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E323 RID: 58147 RVA: 0x00516B22 File Offset: 0x00514D22
		public void JFEKLCFGMCA(float DPNHODJHGJL)
		{
			this.<BAKCNHNMHPE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E324 RID: 58148 RVA: 0x00516B00 File Offset: 0x00514D00
		public void DBENDNHIDGF(float DPNHODJHGJL)
		{
			this.<HKGAAOFNHED>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E325 RID: 58149 RVA: 0x00516B3C File Offset: 0x00514D3C
		public ulong EPELCPMHCJC()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E326 RID: 58150 RVA: 0x00516B3C File Offset: 0x00514D3C
		public ulong BBBKGKJKEGI()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E327 RID: 58151 RVA: 0x00516B2B File Offset: 0x00514D2B
		public float EMFMNNCENOH()
		{
			return this.<HKGAAOFNHED>k__BackingField;
		}

		// Token: 0x0600E328 RID: 58152 RVA: 0x00516B3C File Offset: 0x00514D3C
		public ulong CAFJNOHACPD()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E329 RID: 58153 RVA: 0x00516B2B File Offset: 0x00514D2B
		public float IKPCOIGDIIP()
		{
			return this.<HKGAAOFNHED>k__BackingField;
		}

		// Token: 0x0600E32A RID: 58154 RVA: 0x00516B11 File Offset: 0x00514D11
		public string CHPLBLCNFBJ()
		{
			return this.<INOGKDMPHOF>k__BackingField;
		}

		// Token: 0x0600E32C RID: 58156 RVA: 0x00516AE7 File Offset: 0x00514CE7
		public float BMCKDNPALLJ()
		{
			return this.<BAKCNHNMHPE>k__BackingField;
		}

		// Token: 0x0600E32D RID: 58157 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void JLBBIABGCOD(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E32E RID: 58158 RVA: 0x00516B22 File Offset: 0x00514D22
		public void EELDLHICDFI(float DPNHODJHGJL)
		{
			this.<BAKCNHNMHPE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E32F RID: 58159 RVA: 0x00516B19 File Offset: 0x00514D19
		public void GBIBLLCEBBH(string DPNHODJHGJL)
		{
			this.<INOGKDMPHOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E331 RID: 58161 RVA: 0x00516B3C File Offset: 0x00514D3C
		public ulong DOKGKLEGKDK()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E332 RID: 58162 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void HLDPFDLIHBJ(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E333 RID: 58163 RVA: 0x00516B19 File Offset: 0x00514D19
		public void AHIDNEHNLPN(string DPNHODJHGJL)
		{
			this.<INOGKDMPHOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E334 RID: 58164 RVA: 0x00516B44 File Offset: 0x00514D44
		public PlayersRank(ulong GDOHPDHLPBC, int JMICLAEOFNP)
		{
			this.steamID = GDOHPDHLPBC;
			this.place = JMICLAEOFNP;
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x00516AE7 File Offset: 0x00514CE7
		public float KPBEMENKEKG()
		{
			return this.<BAKCNHNMHPE>k__BackingField;
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600E337 RID: 58167 RVA: 0x00516B3C File Offset: 0x00514D3C
		// (set) Token: 0x0600E336 RID: 58166 RVA: 0x00516ADE File Offset: 0x00514CDE
		public ulong steamID { get; set; }

		// Token: 0x0600E338 RID: 58168 RVA: 0x00516B2B File Offset: 0x00514D2B
		public float KMJIAFJJKBK()
		{
			return this.<HKGAAOFNHED>k__BackingField;
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x00516B33 File Offset: 0x00514D33
		public void HPGOPDANNBO(float DPNHODJHGJL)
		{
			this.<JAJBFAMAHFB>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E33B RID: 58171 RVA: 0x00516AF8 File Offset: 0x00514CF8
		public int IEOGJOLGLFI()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E33C RID: 58172 RVA: 0x00516B09 File Offset: 0x00514D09
		public float JMEMKFEIFJP()
		{
			return this.<JAJBFAMAHFB>k__BackingField;
		}

		// Token: 0x0600E33D RID: 58173 RVA: 0x00516B3C File Offset: 0x00514D3C
		public ulong PPMEPFOPHLF()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E33E RID: 58174 RVA: 0x00516B09 File Offset: 0x00514D09
		public float EGKFMLKFBIN()
		{
			return this.<JAJBFAMAHFB>k__BackingField;
		}

		// Token: 0x0600E33F RID: 58175 RVA: 0x00516B00 File Offset: 0x00514D00
		public void FMMKNCGHMBC(float DPNHODJHGJL)
		{
			this.<HKGAAOFNHED>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E340 RID: 58176 RVA: 0x00516B22 File Offset: 0x00514D22
		public void AJIEPINMKDI(float DPNHODJHGJL)
		{
			this.<BAKCNHNMHPE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E341 RID: 58177 RVA: 0x00516AE7 File Offset: 0x00514CE7
		public float JGNNOLBBLJO()
		{
			return this.<BAKCNHNMHPE>k__BackingField;
		}

		// Token: 0x0600E343 RID: 58179 RVA: 0x00516B2B File Offset: 0x00514D2B
		public float EFACBBBIPHI()
		{
			return this.<HKGAAOFNHED>k__BackingField;
		}

		// Token: 0x0600E344 RID: 58180 RVA: 0x00516B33 File Offset: 0x00514D33
		public void IDPBIHALGDJ(float DPNHODJHGJL)
		{
			this.<JAJBFAMAHFB>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E346 RID: 58182 RVA: 0x00516B11 File Offset: 0x00514D11
		public string KAANIMEJMAL()
		{
			return this.<INOGKDMPHOF>k__BackingField;
		}

		// Token: 0x0600E347 RID: 58183 RVA: 0x00516AEF File Offset: 0x00514CEF
		public void OHEFIECEADL(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x040019C8 RID: 6600
		public bool isDev;

		// Token: 0x040019C9 RID: 6601
		public bool isModerator;

		// Token: 0x040019CA RID: 6602
		public bool isTeam;

		// Token: 0x040019CB RID: 6603
		public bool isContributor;
	}

	// Token: 0x020003E9 RID: 1001
	public class RanksJson
	{
		// Token: 0x0600E349 RID: 58185 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int BNIPNGIBGKM()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E34A RID: 58186 RVA: 0x00516B62 File Offset: 0x00514D62
		public void ABJPJCOOGII(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E34B RID: 58187 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void KGKLBGMBELF(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E34C RID: 58188 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void HDLNDLANIFJ(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E34D RID: 58189 RVA: 0x00516B74 File Offset: 0x00514D74
		public void CEIMMHOPHKM(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E34E RID: 58190 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int MPAADHJGNKF()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> OBPKEDIIPLI()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E350 RID: 58192 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int JBNMBOJJDMF()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E351 RID: 58193 RVA: 0x00516B62 File Offset: 0x00514D62
		public void HGAHJIINGGN(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E352 RID: 58194 RVA: 0x00516B74 File Offset: 0x00514D74
		public void FHHMPKOEDDO(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E353 RID: 58195 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int BKOMPJLOHJN()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> GHDNGAJMEEK()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E355 RID: 58197 RVA: 0x00516B62 File Offset: 0x00514D62
		public void GNKBBPKIDPG(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E356 RID: 58198 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int JDHHENPFHAJ()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E357 RID: 58199 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void IMJNAFCHGMG(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E358 RID: 58200 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int CALKPKGCALB()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E359 RID: 58201 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> MIJDLOEOOKL()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E35A RID: 58202 RVA: 0x00516B62 File Offset: 0x00514D62
		public void HFNBLPHBANH(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E35B RID: 58203 RVA: 0x00516B62 File Offset: 0x00514D62
		public void CHJBEBCIDMK(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E35C RID: 58204 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int NOOJFAMHHBD()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E35D RID: 58205 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int EKPKHNKFABD()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x00516B74 File Offset: 0x00514D74
		public void LMFEJGCEFNN(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E35F RID: 58207 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void HIENMNHBJJK(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E360 RID: 58208 RVA: 0x00516B74 File Offset: 0x00514D74
		public void KMAICIKDDHD(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int JODJNNPECOE()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E362 RID: 58210 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int PKLJGPINFKG()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E363 RID: 58211 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int DLHNPOANIHA()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E364 RID: 58212 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void ECJJNDGLCHL(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void NLJHMABCDMJ(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E366 RID: 58214 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> PHJMIHEFHPH()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600E367 RID: 58215 RVA: 0x00516B7D File Offset: 0x00514D7D
		// (set) Token: 0x0600E381 RID: 58241 RVA: 0x00516B74 File Offset: 0x00514D74
		public int entriesCount { get; set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600E372 RID: 58226 RVA: 0x00516B5A File Offset: 0x00514D5A
		// (set) Token: 0x0600E368 RID: 58216 RVA: 0x00516B62 File Offset: 0x00514D62
		public int page { get; set; }

		// Token: 0x0600E369 RID: 58217 RVA: 0x00516B62 File Offset: 0x00514D62
		public void FAMPAGDDHDM(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E36A RID: 58218 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void DFLFOPNDOMC(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E36B RID: 58219 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> DNNEHNKCECL()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E36C RID: 58220 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int GNFFKIAPIJF()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E36D RID: 58221 RVA: 0x00516B74 File Offset: 0x00514D74
		public void PBMBDMKLAEO(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E36E RID: 58222 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int GABKFAOBDGM()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E36F RID: 58223 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> KKEPKPBCODL()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E370 RID: 58224 RVA: 0x00516B74 File Offset: 0x00514D74
		public void OEBLNBDLOPA(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600E37C RID: 58236 RVA: 0x00516B85 File Offset: 0x00514D85
		// (set) Token: 0x0600E371 RID: 58225 RVA: 0x00516B6B File Offset: 0x00514D6B
		public List<RanksSystem.PlayersRank> playersRanks { get; set; }

		// Token: 0x0600E373 RID: 58227 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int IGANOPJDONE()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E374 RID: 58228 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int HOHIMDBIBMI()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E375 RID: 58229 RVA: 0x00516B74 File Offset: 0x00514D74
		public void NCEPLCMPIFL(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E376 RID: 58230 RVA: 0x00516B62 File Offset: 0x00514D62
		public void HFMIJMMHBKI(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void EJDLDBALNDD(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E378 RID: 58232 RVA: 0x00516B74 File Offset: 0x00514D74
		public void OLMHCNCHOHK(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> BNAMLDFHIGH()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E37A RID: 58234 RVA: 0x00516B6B File Offset: 0x00514D6B
		public void INMJANCPNEP(List<RanksSystem.PlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E37B RID: 58235 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int DNDMKABEJLD()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E37D RID: 58237 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> PGAMKOEGPEM()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E37E RID: 58238 RVA: 0x00516B7D File Offset: 0x00514D7D
		public int MFLGOKACMFP()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E37F RID: 58239 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int NOEBBHNEFEA()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E380 RID: 58240 RVA: 0x00516B5A File Offset: 0x00514D5A
		public int BALJOLFOLHP()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E382 RID: 58242 RVA: 0x00516B74 File Offset: 0x00514D74
		public void GBGKOFEPJMB(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x00516B74 File Offset: 0x00514D74
		public void AEDGOMJDCIH(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> OJCGOBPGGGM()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E385 RID: 58245 RVA: 0x00516B85 File Offset: 0x00514D85
		public List<RanksSystem.PlayersRank> IMPMEFFJPIE()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}
	}

	// Token: 0x020003EA RID: 1002
	public class FastPlayersRank
	{
		// Token: 0x0600E386 RID: 58246 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int MGOMOPDBMHB()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E387 RID: 58247 RVA: 0x00516B95 File Offset: 0x00514D95
		public string NGFMJOJHIKK()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E388 RID: 58248 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int CNPFEGKOFGD()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600E389 RID: 58249 RVA: 0x00516B95 File Offset: 0x00514D95
		// (set) Token: 0x0600E3BF RID: 58303 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public string s { get; set; }

		// Token: 0x0600E38A RID: 58250 RVA: 0x00516B95 File Offset: 0x00514D95
		public string IAPPPJONJFJ()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void BDDLGAHPOPG(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E38C RID: 58252 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int ANKAMMNPKMM()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E38D RID: 58253 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int DABMKCCEIGK()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E38E RID: 58254 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void EPJKFGMIBNN(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600E38F RID: 58255 RVA: 0x00516B8D File Offset: 0x00514D8D
		// (set) Token: 0x0600E3AD RID: 58285 RVA: 0x00516B9D File Offset: 0x00514D9D
		public int p { get; set; }

		// Token: 0x0600E390 RID: 58256 RVA: 0x00516B95 File Offset: 0x00514D95
		public string DBHONACDELD()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E391 RID: 58257 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void PPMMPCNLFCP(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E392 RID: 58258 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void FNPLNODKKDM(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E393 RID: 58259 RVA: 0x00516B95 File Offset: 0x00514D95
		public string JJIALEMJANE()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E394 RID: 58260 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int CODKKENEJCB()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E395 RID: 58261 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void AHKOLHNOBFM(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E396 RID: 58262 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void PKPBEDBJFNI(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x00516B95 File Offset: 0x00514D95
		public string ONIOLBCHKPB()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void KJDEHAGHMCP(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E399 RID: 58265 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void DPOEPMBKKGH(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E39A RID: 58266 RVA: 0x00516B95 File Offset: 0x00514D95
		public string MOMNKJMOJEI()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E39B RID: 58267 RVA: 0x00516B95 File Offset: 0x00514D95
		public string HEIBABNFCAL()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E39C RID: 58268 RVA: 0x00516B95 File Offset: 0x00514D95
		public string FCIMMGEHOPI()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E39D RID: 58269 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int CFOJLCEMKAI()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E39E RID: 58270 RVA: 0x00516B95 File Offset: 0x00514D95
		public string ALMDCOICPEB()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E39F RID: 58271 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void COCMFEKEDEK(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3A0 RID: 58272 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void FOLDOBGNHAG(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3A1 RID: 58273 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int KAIEJOIPHHI()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int NPCGCHMEHJM()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3A3 RID: 58275 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void HNHDAPHKEEP(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3A4 RID: 58276 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int LMIKFNKEBEN()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3A5 RID: 58277 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void EBFMIOPJPKH(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3A6 RID: 58278 RVA: 0x00516B95 File Offset: 0x00514D95
		public string BCMGDNOIMOE()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3A7 RID: 58279 RVA: 0x00516B95 File Offset: 0x00514D95
		public string AOOKKECFMKM()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3A8 RID: 58280 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int EAPHGJIKALP()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3A9 RID: 58281 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void GMBACHEIHGF(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3AA RID: 58282 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void HPGDIPJNKIB(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void GONFKNAIAJH(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3AC RID: 58284 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int HFGMLHADFEB()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3AE RID: 58286 RVA: 0x00516B95 File Offset: 0x00514D95
		public string MNPEAOAJHLM()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3AF RID: 58287 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void FEHIDJHHNIN(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void IEFNJACHGBI(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void CBIOEGAPGCO(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B2 RID: 58290 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void KBIIIIAADAC(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B3 RID: 58291 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void FMLMJDKFPIG(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B4 RID: 58292 RVA: 0x00516B95 File Offset: 0x00514D95
		public string KKAPCKGHHNN()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3B5 RID: 58293 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void LNCKCFMNOFG(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void LOPFHNBAOFP(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B7 RID: 58295 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void INJJNMKJDMN(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B8 RID: 58296 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void OPCNLJKPIBN(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void KFBFLFBGNBD(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void EEFICOMGDMK(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3BB RID: 58299 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void NIBABBHIMNI(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void NAODOIFBPJO(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3BD RID: 58301 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void CECMEKMEBKM(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3BE RID: 58302 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void KLCDMPNLGBL(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3C0 RID: 58304 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void LOEHFKKAKFN(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3C1 RID: 58305 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int OJCKHEFKMOI()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void APCBJJKDFCK(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3C4 RID: 58308 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int HFBFMDMMNNF()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3C5 RID: 58309 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void KEEHHILHMKE(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3C6 RID: 58310 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int AEDDILAJFCC()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3C7 RID: 58311 RVA: 0x00516B95 File Offset: 0x00514D95
		public string IEOKEHMPAIG()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3C8 RID: 58312 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int ADHHMAKDMAI()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3C9 RID: 58313 RVA: 0x00516B95 File Offset: 0x00514D95
		public string FBNHKMECJAM()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3CA RID: 58314 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void BNNOMODCOGO(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3CB RID: 58315 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int POMBJIFGLBJ()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3CC RID: 58316 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void OPIEEAACMNN(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3CD RID: 58317 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void OGGAEFOBFFI(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3CE RID: 58318 RVA: 0x00516B95 File Offset: 0x00514D95
		public string BOKFILKGABA()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3CF RID: 58319 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int EHJKFMJGCDM()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x00516B95 File Offset: 0x00514D95
		public string EDIOGHHEMCI()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}

		// Token: 0x0600E3D1 RID: 58321 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void EBLKFKIHLON(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3D2 RID: 58322 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int MFAHAMJONMI()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3D3 RID: 58323 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void LMKHDHPOBDN(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3D4 RID: 58324 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void BJOEKBPNMMF(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3D5 RID: 58325 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void EHPEACMNGOG(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3D6 RID: 58326 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void COIGEHFNLFL(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3D7 RID: 58327 RVA: 0x00516B8D File Offset: 0x00514D8D
		public int JDODCEDNDFH()
		{
			return this.<HEOCCMLLBHL>k__BackingField;
		}

		// Token: 0x0600E3D8 RID: 58328 RVA: 0x00516B9D File Offset: 0x00514D9D
		public void OBGALFNKMCJ(int DPNHODJHGJL)
		{
			this.<HEOCCMLLBHL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3D9 RID: 58329 RVA: 0x00516BA6 File Offset: 0x00514DA6
		public void PNOHOOAAJPJ(string DPNHODJHGJL)
		{
			this.<CLBGDCMCALI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3DA RID: 58330 RVA: 0x00516B95 File Offset: 0x00514D95
		public string HPKOEJCIAJI()
		{
			return this.<CLBGDCMCALI>k__BackingField;
		}
	}

	// Token: 0x020003EB RID: 1003
	public class FastRanksJson
	{
		// Token: 0x0600E3DB RID: 58331 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> IMPMEFFJPIE()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3DC RID: 58332 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void MCNKKBOAFJN(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3DD RID: 58333 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> NMKJLLNFFFP()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3DE RID: 58334 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void DIGLPMDODML(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3DF RID: 58335 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int EANHIOMELKB()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3E0 RID: 58336 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> PHJMIHEFHPH()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3E1 RID: 58337 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void ODEAINLJBFH(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3E2 RID: 58338 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void JFBIHPDGGOK(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3E3 RID: 58339 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void INMJANCPNEP(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3E4 RID: 58340 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void IGEBIKDNLCP(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3E5 RID: 58341 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> CEDHOLJIKEP()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600E40B RID: 58379 RVA: 0x00516BC0 File Offset: 0x00514DC0
		// (set) Token: 0x0600E3E6 RID: 58342 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public int entriesCount { get; set; }

		// Token: 0x0600E3E8 RID: 58344 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int BJJGGIPAJHA()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3E9 RID: 58345 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int MFLGOKACMFP()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3EA RID: 58346 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int HKGKLAIBGGN()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3EB RID: 58347 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void PJBACNPGHNJ(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3EC RID: 58348 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void DDKKOCHPMLK(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3ED RID: 58349 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void JOCOONDJMGD(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3EE RID: 58350 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> CPMLMOPGNKA()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3EF RID: 58351 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> KAPIGGCPNGO()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3F0 RID: 58352 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> EMFMOOHPPPM()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3F1 RID: 58353 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int CMJMJPHJGBA()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3F2 RID: 58354 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int ADAPEBKMNMM()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3F3 RID: 58355 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> DEFEIGKLBKF()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int KMEJCPCEPLI()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3F5 RID: 58357 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void AEDGOMJDCIH(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3F6 RID: 58358 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void NNAOKKLFNCC(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600E400 RID: 58368 RVA: 0x00516BAF File Offset: 0x00514DAF
		// (set) Token: 0x0600E3F7 RID: 58359 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public List<RanksSystem.FastPlayersRank> playersRanks { get; set; }

		// Token: 0x0600E3F8 RID: 58360 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> HLKPJDLPMFL()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E3F9 RID: 58361 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int NOOJFAMHHBD()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3FA RID: 58362 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void IMPEHAAFAJF(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3FB RID: 58363 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void HCLHEBAKBLL(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3FC RID: 58364 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void IMJNAFCHGMG(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3FD RID: 58365 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void JEDIFHKCDDK(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E3FE RID: 58366 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int GBHICOCNNCK()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E3FF RID: 58367 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> GHDNGAJMEEK()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E401 RID: 58369 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void KPMCNDNCGGN(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E402 RID: 58370 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> LPNJPCGCJOB()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E403 RID: 58371 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void MOHKIBKFOMI(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E404 RID: 58372 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void LMFEJGCEFNN(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E405 RID: 58373 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void HAJPFHOELAP(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E406 RID: 58374 RVA: 0x00516BC0 File Offset: 0x00514DC0
		public int EOEDPGEFGBF()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E407 RID: 58375 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void LFCDIBDICGC(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E408 RID: 58376 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void IMPJCGGONNG(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E409 RID: 58377 RVA: 0x00516BB7 File Offset: 0x00514DB7
		public void JBKFJHEONMO(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E40A RID: 58378 RVA: 0x00516BAF File Offset: 0x00514DAF
		public List<RanksSystem.FastPlayersRank> CPDFCCBOBHC()
		{
			return this.<AHFALFKJCNM>k__BackingField;
		}

		// Token: 0x0600E40C RID: 58380 RVA: 0x00516BC8 File Offset: 0x00514DC8
		public void LKEJFBDMPIE(List<RanksSystem.FastPlayersRank> DPNHODJHGJL)
		{
			this.<AHFALFKJCNM>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003EC RID: 1004
	public class TeamJson
	{
		// Token: 0x0600E40D RID: 58381 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> HNKGJAGCENO()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E40E RID: 58382 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> CIHCMHOKDAM()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E40F RID: 58383 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> GNJMFNBKFOC()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E410 RID: 58384 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> JKLNGPHHGNF()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E411 RID: 58385 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void DLLEAKEECCK(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E412 RID: 58386 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void PDNGDPBCHDB(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E413 RID: 58387 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> BEOFLKLDBAG()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E414 RID: 58388 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void MFOLKPIPMDL(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E415 RID: 58389 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void HOFBFNMJBDG(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600E416 RID: 58390 RVA: 0x00516BD1 File Offset: 0x00514DD1
		// (set) Token: 0x0600E428 RID: 58408 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public List<ulong> moderators { get; set; }

		// Token: 0x0600E417 RID: 58391 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> LMJEDGFGBAC()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E418 RID: 58392 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void IBNONPEHMPG(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E419 RID: 58393 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void BDGLPIPELEP(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E41A RID: 58394 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void BHMFCEAILME(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E41B RID: 58395 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> FFNOMACLKIF()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E41C RID: 58396 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> FNPKHLNJKJK()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> GCIFDCHHNMP()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> HGAHOOLIBKO()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E41F RID: 58399 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void ACEACMDHHLH(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void CIPMEPEMJCG(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> CNPLAHCAMHC()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E422 RID: 58402 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> MHDCENBMFGA()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E423 RID: 58403 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void FGAILFAJCKN(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E424 RID: 58404 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> IEGPBCBEBHM()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E425 RID: 58405 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void GJOFJHIEBFI(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E426 RID: 58406 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void GOENPNNGAGG(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E427 RID: 58407 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> JICAOJIIOPJ()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600E42B RID: 58411 RVA: 0x00516BFC File Offset: 0x00514DFC
		// (set) Token: 0x0600E42A RID: 58410 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public List<ulong> devs { get; set; }

		// Token: 0x0600E42C RID: 58412 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> JKAGOHGELIJ()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E42D RID: 58413 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void KHDOBEDFGDK(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E42E RID: 58414 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> OAGKCIGLNLH()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E42F RID: 58415 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> FAJMKIGABJP()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E430 RID: 58416 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> HPBLHNKPAJE()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> HEFNILELGLE()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> PAJKHEKEHEM()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E433 RID: 58419 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> GLOOBBMBPBP()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E434 RID: 58420 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void HBCEBKGMDLI(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> ENJLPADECIG()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E436 RID: 58422 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> INJNMMBFLMI()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E437 RID: 58423 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void MAGMLNIKPAJ(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600E438 RID: 58424 RVA: 0x00516BD9 File Offset: 0x00514DD9
		// (set) Token: 0x0600E47C RID: 58492 RVA: 0x00516BEA File Offset: 0x00514DEA
		public List<ulong> team { get; set; }

		// Token: 0x0600E439 RID: 58425 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> IDCHOIOHHBD()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E43A RID: 58426 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> MAAAOALGJAJ()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E43B RID: 58427 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void PKLBAMMGGPB(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E43C RID: 58428 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> PKNCMEKLCOH()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E43D RID: 58429 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void KNHFHLEKCGE(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E43E RID: 58430 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void CDDEAKNNABP(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E43F RID: 58431 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void JCLPAECOIJG(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E440 RID: 58432 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void JHPOGBIGEAF(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E441 RID: 58433 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void OPBGODDOAHC(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E442 RID: 58434 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> JNHKJFHFBIG()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E443 RID: 58435 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> CEMCEIHCMIG()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E444 RID: 58436 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void KLOHLCFDKJC(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E445 RID: 58437 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> AEBNCELLMII()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E446 RID: 58438 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> DLPPCHADGIB()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E447 RID: 58439 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> DABFJHPANGH()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E448 RID: 58440 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void CCEDNLBCJOG(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> JEFEEHMMCIN()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E44A RID: 58442 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> HGBHJDBCBFP()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E44B RID: 58443 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> JFOGOMAABDM()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E44C RID: 58444 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void GAOEAIJNBEO(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E44D RID: 58445 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void NEKBPBAGMLO(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> PBIPKOIHKNH()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E44F RID: 58447 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void IMAGGINNINH(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E450 RID: 58448 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void GPGOBNDJOKP(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E451 RID: 58449 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void BAMDJEPCKIB(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> GBPLMGJKPJH()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> DIGAGOGDPOK()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E454 RID: 58452 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> IPEOPAHNCAM()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E455 RID: 58453 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> IOICHPNKCDD()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E456 RID: 58454 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void GOICOPFIICE(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E457 RID: 58455 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void LNBKMMCEIGA(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E458 RID: 58456 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void PPDPBIMGMNG(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E459 RID: 58457 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void FIHNLNKEKEO(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E45A RID: 58458 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> NAEHLCMDEOH()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E45B RID: 58459 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> AHEFKNKBFJB()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E45C RID: 58460 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> DFFMADGLMAK()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E45D RID: 58461 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void GELLNOAMGOF(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E45E RID: 58462 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void MAJHAFBKPBL(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E45F RID: 58463 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> GMKOEKMEDFH()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E460 RID: 58464 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> GMOFCNDFBHO()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E461 RID: 58465 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> MECBOMHPAKG()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> GODJHFCIBAB()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> IGDJMMJEHNL()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> ENPCNGNLPLH()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E465 RID: 58469 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> NIPAIBOHJFI()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E466 RID: 58470 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void AMAHCLGIOAN(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E467 RID: 58471 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> BPCBBDLODAH()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E468 RID: 58472 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void ELODLACPDHC(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E469 RID: 58473 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> OMGFMLALHJA()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E46A RID: 58474 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> MMKDJJLELAK()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E46B RID: 58475 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> KNLJMOGBLDM()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E46C RID: 58476 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> ILPFDHLPJNA()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void KJCGDHBMNGB(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void AJCHOKKCLEA(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E46F RID: 58479 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> CGJKNIBIJMC()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E470 RID: 58480 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> OMPOHMNPHOP()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E471 RID: 58481 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> GGOFACIOFGI()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E472 RID: 58482 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void NCGPJFPOKFM(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E473 RID: 58483 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> GAJGEDPJLCA()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E474 RID: 58484 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void CEDIFNOFJPP(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E475 RID: 58485 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> NDFMKNACOII()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E476 RID: 58486 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> KHJGMNKCAKB()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E477 RID: 58487 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void OPKNNOPGBLJ(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E478 RID: 58488 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> FBGLHEKKPMC()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void NCMNAKFMPPG(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void FCEMLAOPKIH(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> EJJOECMPOGC()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void AOAKLEMCCNK(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> MFCCBJCNOJJ()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E47F RID: 58495 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> FFCEABNMIOF()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E480 RID: 58496 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> EECPPGHFGPL()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E481 RID: 58497 RVA: 0x00516BEA File Offset: 0x00514DEA
		public void NBBNHIKLOKJ(List<ulong> DPNHODJHGJL)
		{
			this.<JPDONDOGCPK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E482 RID: 58498 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void FLAJOLBDFFD(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E483 RID: 58499 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> LBKPLIGICLN()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E484 RID: 58500 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> FMFGNCDJHGB()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E485 RID: 58501 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void MJGPLDNFBLI(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E486 RID: 58502 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> OLHJPKHLJII()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E487 RID: 58503 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void LCBLLLJBMIA(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E488 RID: 58504 RVA: 0x00516BE1 File Offset: 0x00514DE1
		public void PJHMIPKDCBE(List<ulong> DPNHODJHGJL)
		{
			this.<MJLMMHJOHPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E489 RID: 58505 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> NHFELHOOPOA()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E48A RID: 58506 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> DLIMIFBBLGM()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E48B RID: 58507 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> IPBFJPCBCGM()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E48C RID: 58508 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> MLLDDHHLAEF()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E48D RID: 58509 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> GFOIJNHHIAN()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x00516BFC File Offset: 0x00514DFC
		public List<ulong> EELBOHOJKIF()
		{
			return this.<IDHMLBCNFIC>k__BackingField;
		}

		// Token: 0x0600E48F RID: 58511 RVA: 0x00516BF3 File Offset: 0x00514DF3
		public void HFDONCBOMAL(List<ulong> DPNHODJHGJL)
		{
			this.<IDHMLBCNFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E490 RID: 58512 RVA: 0x00516BD1 File Offset: 0x00514DD1
		public List<ulong> ONHKHPCNNID()
		{
			return this.<MJLMMHJOHPJ>k__BackingField;
		}

		// Token: 0x0600E491 RID: 58513 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> MOJHODKLCBC()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}

		// Token: 0x0600E492 RID: 58514 RVA: 0x00516BD9 File Offset: 0x00514DD9
		public List<ulong> CCDIHLLMBIO()
		{
			return this.<JPDONDOGCPK>k__BackingField;
		}
	}

	// Token: 0x020003ED RID: 1005
	public class Ban
	{
		// Token: 0x040019D6 RID: 6614
		public int id;

		// Token: 0x040019D7 RID: 6615
		public ulong steamID;

		// Token: 0x040019D8 RID: 6616
		public string date;

		// Token: 0x040019D9 RID: 6617
		public RanksSystem.Ban.BanType bantype;

		// Token: 0x040019DA RID: 6618
		public string until;

		// Token: 0x040019DB RID: 6619
		public string reason;

		// Token: 0x020003EE RID: 1006
		public enum BanType
		{
			// Token: 0x040019DD RID: 6621
			Warning,
			// Token: 0x040019DE RID: 6622
			Mute,
			// Token: 0x040019DF RID: 6623
			Temporary,
			// Token: 0x040019E0 RID: 6624
			Permanent
		}
	}

	// Token: 0x020003EF RID: 1007
	public class BanListJson
	{
		// Token: 0x0600E494 RID: 58516 RVA: 0x00516C04 File Offset: 0x00514E04
		public void IBBFILGBCHO(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x00516C04 File Offset: 0x00514E04
		public void PLLIMICKMGM(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E496 RID: 58518 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> NOFIMPLHFGF()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x00516C04 File Offset: 0x00514E04
		public void BAHBBADLOEP(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E498 RID: 58520 RVA: 0x00516C04 File Offset: 0x00514E04
		public void LIEEFFBJLFG(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> OIIMIBLNJFF()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x00516C04 File Offset: 0x00514E04
		public void JPPLDAIJGCD(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E49B RID: 58523 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> LNKHIFBJNBP()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E49C RID: 58524 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> FIHFNMHBAIG()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E49D RID: 58525 RVA: 0x00516C04 File Offset: 0x00514E04
		public void LBLHNGMLLAO(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E49E RID: 58526 RVA: 0x00516C04 File Offset: 0x00514E04
		public void BGEBHEDNBDB(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E49F RID: 58527 RVA: 0x00516C04 File Offset: 0x00514E04
		public void PJKOCLDEDFE(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A0 RID: 58528 RVA: 0x00516C04 File Offset: 0x00514E04
		public void JKKOCNNBGII(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A1 RID: 58529 RVA: 0x00516C04 File Offset: 0x00514E04
		public void KCIOIKKOOMM(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A2 RID: 58530 RVA: 0x00516C04 File Offset: 0x00514E04
		public void OIMJACHDEND(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A3 RID: 58531 RVA: 0x00516C04 File Offset: 0x00514E04
		public void AHMDBKJBDPF(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A4 RID: 58532 RVA: 0x00516C04 File Offset: 0x00514E04
		public void MBMEOIMKFGB(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> HLCHCGJBLDG()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4A6 RID: 58534 RVA: 0x00516C04 File Offset: 0x00514E04
		public void CPAFOIHDLOH(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A7 RID: 58535 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> JHBOOBBMBNA()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4A8 RID: 58536 RVA: 0x00516C04 File Offset: 0x00514E04
		public void EGECMIHMOFN(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4A9 RID: 58537 RVA: 0x00516C04 File Offset: 0x00514E04
		public void AIIAOLGFNMB(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4AA RID: 58538 RVA: 0x00516C04 File Offset: 0x00514E04
		public void GCIHNGLDIDL(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4AB RID: 58539 RVA: 0x00516C04 File Offset: 0x00514E04
		public void PDONOBPIKMB(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4AC RID: 58540 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> PLJNEIOJFJK()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4AD RID: 58541 RVA: 0x00516C04 File Offset: 0x00514E04
		public void OEOHNFELNJF(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4AE RID: 58542 RVA: 0x00516C04 File Offset: 0x00514E04
		public void IEDHFANODHL(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x00516C04 File Offset: 0x00514E04
		public void HMJKILGEKAJ(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4B1 RID: 58545 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> JPEBPOAFICH()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4B2 RID: 58546 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> AKMEGMGPKLE()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4B3 RID: 58547 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> NAGCNNDNFOI()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4B4 RID: 58548 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> PNDEGLGJKEG()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4B5 RID: 58549 RVA: 0x00516C04 File Offset: 0x00514E04
		public void NCALIDOPPBJ(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4B6 RID: 58550 RVA: 0x00516C04 File Offset: 0x00514E04
		public void NNAIPMBDLIA(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4B7 RID: 58551 RVA: 0x00516C04 File Offset: 0x00514E04
		public void IIDEBBMMOOB(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4B8 RID: 58552 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> NPHBCLINAEG()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4B9 RID: 58553 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> HGEPBAEMEIO()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4BA RID: 58554 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> NFMDJKFJHHI()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4BB RID: 58555 RVA: 0x00516C04 File Offset: 0x00514E04
		public void PNAKACJFACE(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4BC RID: 58556 RVA: 0x00516C04 File Offset: 0x00514E04
		public void CFDNEAIJGIM(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4BD RID: 58557 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> IJHBHHLFMNG()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4BE RID: 58558 RVA: 0x00516C04 File Offset: 0x00514E04
		public void CMKLIIHPBBK(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4BF RID: 58559 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> NHALPPIMOJJ()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> GCGHGPEEFJL()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4C1 RID: 58561 RVA: 0x00516C04 File Offset: 0x00514E04
		public void DIFPJDJOANM(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4C2 RID: 58562 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> CHCOPNNJNBL()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4C3 RID: 58563 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> PBGPEHPEJCF()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4C4 RID: 58564 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> PAGHLAELOOI()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4C5 RID: 58565 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> CHKPKEFMOBG()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4C6 RID: 58566 RVA: 0x00516C04 File Offset: 0x00514E04
		public void LFFDPAFDIGA(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4C7 RID: 58567 RVA: 0x00516C04 File Offset: 0x00514E04
		public void MAGEEJHGKMB(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4C8 RID: 58568 RVA: 0x00516C04 File Offset: 0x00514E04
		public void DGDEIGHOIAD(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4C9 RID: 58569 RVA: 0x00516C04 File Offset: 0x00514E04
		public void GPFOKENEMGN(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4CA RID: 58570 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> ANAAAHFGFND()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4CB RID: 58571 RVA: 0x00516C04 File Offset: 0x00514E04
		public void NNKFIGPFNOJ(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4CC RID: 58572 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> INEBLADCMEM()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4CD RID: 58573 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> BNCBPEPDLHG()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4CE RID: 58574 RVA: 0x00516C04 File Offset: 0x00514E04
		public void CBFGKLPEGDA(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4CF RID: 58575 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> ODFHABLOGMO()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> NLNILPHFKKP()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D1 RID: 58577 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> PEFHOFHOFLM()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D2 RID: 58578 RVA: 0x00516C04 File Offset: 0x00514E04
		public void BJGAMECOCGA(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4D3 RID: 58579 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> MOJKMKGNKIN()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D4 RID: 58580 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> IEIGIFMEICA()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D5 RID: 58581 RVA: 0x00516C04 File Offset: 0x00514E04
		public void HBKNMGALNLC(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4D6 RID: 58582 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> GEFBPFICMHL()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D7 RID: 58583 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> KFPDFANBKFB()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D8 RID: 58584 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> FHFLGMNPILE()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4D9 RID: 58585 RVA: 0x00516C04 File Offset: 0x00514E04
		public void CGGLJMMOCOP(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4DA RID: 58586 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> MCBCHJCKHCA()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4DB RID: 58587 RVA: 0x00516C04 File Offset: 0x00514E04
		public void EDBMFOOIGIP(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4DC RID: 58588 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> JJLPBGJAMIK()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4DD RID: 58589 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> IBNDABGKNAH()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4DE RID: 58590 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> FODIKILGPFF()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4DF RID: 58591 RVA: 0x00516C04 File Offset: 0x00514E04
		public void PKDEKEJOKNG(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x00516C04 File Offset: 0x00514E04
		public void HCOLGJLMJKB(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x00516C0D File Offset: 0x00514E0D
		// (set) Token: 0x0600E4E3 RID: 58595 RVA: 0x00516C04 File Offset: 0x00514E04
		public List<RanksSystem.Ban> bans { get; set; }

		// Token: 0x0600E4E2 RID: 58594 RVA: 0x00516C04 File Offset: 0x00514E04
		public void EBFEHOKCNPH(List<RanksSystem.Ban> DPNHODJHGJL)
		{
			this.<IODLLMNONOF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4E4 RID: 58596 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> GDEJALDAKIC()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}

		// Token: 0x0600E4E5 RID: 58597 RVA: 0x00516C0D File Offset: 0x00514E0D
		public List<RanksSystem.Ban> CAKIGBHJJFP()
		{
			return this.<IODLLMNONOF>k__BackingField;
		}
	}

	// Token: 0x020003F0 RID: 1008
	public class Map
	{
		// Token: 0x0600E4E6 RID: 58598 RVA: 0x00516C15 File Offset: 0x00514E15
		public void CIHAMBAFIIO(string DPNHODJHGJL)
		{
			this.<PAHJOACFOFP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4E7 RID: 58599 RVA: 0x00516C15 File Offset: 0x00514E15
		public void MMMGPJFLJAN(string DPNHODJHGJL)
		{
			this.<PAHJOACFOFP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4E8 RID: 58600 RVA: 0x00516C15 File Offset: 0x00514E15
		public void NCOJBPAIBDJ(string DPNHODJHGJL)
		{
			this.<PAHJOACFOFP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4E9 RID: 58601 RVA: 0x00516C1E File Offset: 0x00514E1E
		public void ILJAIHNONEG(bool DPNHODJHGJL)
		{
			this.<BGEDPCLDJAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4EA RID: 58602 RVA: 0x00516C27 File Offset: 0x00514E27
		public void NMKGCBJPJHL(bool DPNHODJHGJL)
		{
			this.<APEKGLMDHDK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600E4EB RID: 58603 RVA: 0x00516C30 File Offset: 0x00514E30
		// (set) Token: 0x0600E541 RID: 58689 RVA: 0x00516C27 File Offset: 0x00514E27
		public bool isFunny { get; set; }

		// Token: 0x0600E4EC RID: 58604 RVA: 0x00516C38 File Offset: 0x00514E38
		public bool BJBPMLKECIA()
		{
			return this.<BGEDPCLDJAM>k__BackingField;
		}

		// Token: 0x0600E4ED RID: 58605 RVA: 0x00516C40 File Offset: 0x00514E40
		public string LDDDNPEHCEG()
		{
			return this.<ILPCCDJLHIC>k__BackingField;
		}

		// Token: 0x0600E4EE RID: 58606 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool BOPKDBILIEA()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E4EF RID: 58607 RVA: 0x00516C50 File Offset: 0x00514E50
		public float JEKMHHCPHCN()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E4F0 RID: 58608 RVA: 0x00516C1E File Offset: 0x00514E1E
		public void GJBLMBPFGNP(bool DPNHODJHGJL)
		{
			this.<BGEDPCLDJAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600E4F1 RID: 58609 RVA: 0x00516C38 File Offset: 0x00514E38
		// (set) Token: 0x0600E516 RID: 58646 RVA: 0x00516C1E File Offset: 0x00514E1E
		public bool isOfficial { get; set; }

		// Token: 0x0600E4F2 RID: 58610 RVA: 0x00516C40 File Offset: 0x00514E40
		public string PPHIDEJBJGM()
		{
			return this.<ILPCCDJLHIC>k__BackingField;
		}

		// Token: 0x0600E4F3 RID: 58611 RVA: 0x00516C58 File Offset: 0x00514E58
		public string NPEJINEIOCF()
		{
			return this.<PAHJOACFOFP>k__BackingField;
		}

		// Token: 0x0600E4F4 RID: 58612 RVA: 0x00516C58 File Offset: 0x00514E58
		public string AGPPOOGOKJC()
		{
			return this.<PAHJOACFOFP>k__BackingField;
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00516C1E File Offset: 0x00514E1E
		public void FKOBHMCHPEI(bool DPNHODJHGJL)
		{
			this.<BGEDPCLDJAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4F6 RID: 58614 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool AIGLNDJJPFL()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E4F7 RID: 58615 RVA: 0x00516C60 File Offset: 0x00514E60
		public ulong KCGOFGJNCME()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E4F8 RID: 58616 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool MKLAMAFMEPF()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E4F9 RID: 58617 RVA: 0x00516C68 File Offset: 0x00514E68
		public void NBIFMJNFFJO(bool DPNHODJHGJL)
		{
			this.<AHMCLGDNEOE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4FA RID: 58618 RVA: 0x00516C60 File Offset: 0x00514E60
		public ulong CEEKAHOMGKG()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E4FB RID: 58619 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool FNDFNECFNEL()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E4FC RID: 58620 RVA: 0x00516C30 File Offset: 0x00514E30
		public bool AMJIEEIMBDN()
		{
			return this.<APEKGLMDHDK>k__BackingField;
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x00516C71 File Offset: 0x00514E71
		public void GCEDDGGPGFP(float DPNHODJHGJL)
		{
			this.<FLLFAJGDFNF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x00516C27 File Offset: 0x00514E27
		public void PNDFMMENCMD(bool DPNHODJHGJL)
		{
			this.<APEKGLMDHDK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x00516C58 File Offset: 0x00514E58
		// (set) Token: 0x0600E520 RID: 58656 RVA: 0x00516C15 File Offset: 0x00514E15
		public string added { get; set; }

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600E51B RID: 58651 RVA: 0x00516C48 File Offset: 0x00514E48
		// (set) Token: 0x0600E500 RID: 58624 RVA: 0x00516C68 File Offset: 0x00514E68
		public bool isLoved { get; set; }

		// Token: 0x0600E501 RID: 58625 RVA: 0x00516C40 File Offset: 0x00514E40
		public string BADDMKNNCGI()
		{
			return this.<ILPCCDJLHIC>k__BackingField;
		}

		// Token: 0x0600E502 RID: 58626 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool JMMAPHACFAG()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E503 RID: 58627 RVA: 0x00516C7A File Offset: 0x00514E7A
		public void DDGEEKHCBOF(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600E534 RID: 58676 RVA: 0x00516C40 File Offset: 0x00514E40
		// (set) Token: 0x0600E504 RID: 58628 RVA: 0x00516C83 File Offset: 0x00514E83
		public string hash { get; set; }

		// Token: 0x0600E505 RID: 58629 RVA: 0x00516C40 File Offset: 0x00514E40
		public string KJMICPMGAPD()
		{
			return this.<ILPCCDJLHIC>k__BackingField;
		}

		// Token: 0x0600E506 RID: 58630 RVA: 0x00516C38 File Offset: 0x00514E38
		public bool CDPELGPJPND()
		{
			return this.<BGEDPCLDJAM>k__BackingField;
		}

		// Token: 0x0600E507 RID: 58631 RVA: 0x00516C15 File Offset: 0x00514E15
		public void EDPDFMCOEPC(string DPNHODJHGJL)
		{
			this.<PAHJOACFOFP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E508 RID: 58632 RVA: 0x00516C50 File Offset: 0x00514E50
		public float MBAFCIHCIOM()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E509 RID: 58633 RVA: 0x00516C27 File Offset: 0x00514E27
		public void LEMCHELEEBL(bool DPNHODJHGJL)
		{
			this.<APEKGLMDHDK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600E50A RID: 58634 RVA: 0x00516C60 File Offset: 0x00514E60
		// (set) Token: 0x0600E52A RID: 58666 RVA: 0x00516C7A File Offset: 0x00514E7A
		public ulong id { get; set; }

		// Token: 0x0600E50B RID: 58635 RVA: 0x00516C58 File Offset: 0x00514E58
		public string DFCNJMKCGHO()
		{
			return this.<PAHJOACFOFP>k__BackingField;
		}

		// Token: 0x0600E50C RID: 58636 RVA: 0x00516C27 File Offset: 0x00514E27
		public void IOKCGFNOEBG(bool DPNHODJHGJL)
		{
			this.<APEKGLMDHDK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E50D RID: 58637 RVA: 0x00516C83 File Offset: 0x00514E83
		public void COLBOOOIBCD(string DPNHODJHGJL)
		{
			this.<ILPCCDJLHIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E50E RID: 58638 RVA: 0x00516C50 File Offset: 0x00514E50
		public float BAFALKHFFMK()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E50F RID: 58639 RVA: 0x00516C27 File Offset: 0x00514E27
		public void DIPPGAEKPMK(bool DPNHODJHGJL)
		{
			this.<APEKGLMDHDK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E510 RID: 58640 RVA: 0x00516C71 File Offset: 0x00514E71
		public void LOLIDCAGOJO(float DPNHODJHGJL)
		{
			this.<FLLFAJGDFNF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E511 RID: 58641 RVA: 0x00516C38 File Offset: 0x00514E38
		public bool GPAPLIKKEOH()
		{
			return this.<BGEDPCLDJAM>k__BackingField;
		}

		// Token: 0x0600E512 RID: 58642 RVA: 0x00516C30 File Offset: 0x00514E30
		public bool MEFGLBKEHJE()
		{
			return this.<APEKGLMDHDK>k__BackingField;
		}

		// Token: 0x0600E513 RID: 58643 RVA: 0x00516C60 File Offset: 0x00514E60
		public ulong GOMJAEIDHNM()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E514 RID: 58644 RVA: 0x00516C68 File Offset: 0x00514E68
		public void GMCINLCADOC(bool DPNHODJHGJL)
		{
			this.<AHMCLGDNEOE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E515 RID: 58645 RVA: 0x00516C58 File Offset: 0x00514E58
		public string ANPFFHGKIPB()
		{
			return this.<PAHJOACFOFP>k__BackingField;
		}

		// Token: 0x0600E517 RID: 58647 RVA: 0x00516C1E File Offset: 0x00514E1E
		public void MBFEHFELDMD(bool DPNHODJHGJL)
		{
			this.<BGEDPCLDJAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E518 RID: 58648 RVA: 0x00516C50 File Offset: 0x00514E50
		public float NNDFIJEBENA()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E519 RID: 58649 RVA: 0x00516C1E File Offset: 0x00514E1E
		public void BOAAFPFJLDH(bool DPNHODJHGJL)
		{
			this.<BGEDPCLDJAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x00516C50 File Offset: 0x00514E50
		// (set) Token: 0x0600E522 RID: 58658 RVA: 0x00516C71 File Offset: 0x00514E71
		public float difficulty { get; set; }

		// Token: 0x0600E51C RID: 58652 RVA: 0x00516C83 File Offset: 0x00514E83
		public void NIENNNPBBLN(string DPNHODJHGJL)
		{
			this.<ILPCCDJLHIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E51D RID: 58653 RVA: 0x00516C58 File Offset: 0x00514E58
		public string HAAEJNLHGMK()
		{
			return this.<PAHJOACFOFP>k__BackingField;
		}

		// Token: 0x0600E51E RID: 58654 RVA: 0x00516C40 File Offset: 0x00514E40
		public string JIBONFJGLKN()
		{
			return this.<ILPCCDJLHIC>k__BackingField;
		}

		// Token: 0x0600E51F RID: 58655 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool DKHGLGJAKOF()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E521 RID: 58657 RVA: 0x00516C71 File Offset: 0x00514E71
		public void KHIJPPDJIDD(float DPNHODJHGJL)
		{
			this.<FLLFAJGDFNF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E523 RID: 58659 RVA: 0x00516C15 File Offset: 0x00514E15
		public void FJEONOMKAGF(string DPNHODJHGJL)
		{
			this.<PAHJOACFOFP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E524 RID: 58660 RVA: 0x00516C38 File Offset: 0x00514E38
		public bool BMKGKMJPAMF()
		{
			return this.<BGEDPCLDJAM>k__BackingField;
		}

		// Token: 0x0600E525 RID: 58661 RVA: 0x00516C60 File Offset: 0x00514E60
		public ulong JGEBJGHEJPK()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E526 RID: 58662 RVA: 0x00516C38 File Offset: 0x00514E38
		public bool KFMNMCJFPPI()
		{
			return this.<BGEDPCLDJAM>k__BackingField;
		}

		// Token: 0x0600E527 RID: 58663 RVA: 0x00516C60 File Offset: 0x00514E60
		public ulong HJPGIGBFCID()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E528 RID: 58664 RVA: 0x00516C68 File Offset: 0x00514E68
		public void KKEMCHKBOIM(bool DPNHODJHGJL)
		{
			this.<AHMCLGDNEOE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E529 RID: 58665 RVA: 0x00516C71 File Offset: 0x00514E71
		public void PILDNHHJALI(float DPNHODJHGJL)
		{
			this.<FLLFAJGDFNF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E52B RID: 58667 RVA: 0x00516C58 File Offset: 0x00514E58
		public string FJMBGIKFEME()
		{
			return this.<PAHJOACFOFP>k__BackingField;
		}

		// Token: 0x0600E52C RID: 58668 RVA: 0x00516C7A File Offset: 0x00514E7A
		public void FKHKGBMHBHE(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E52D RID: 58669 RVA: 0x00516C30 File Offset: 0x00514E30
		public bool MOEOCIODBDH()
		{
			return this.<APEKGLMDHDK>k__BackingField;
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x00516C40 File Offset: 0x00514E40
		public string PDHMMOCHDAJ()
		{
			return this.<ILPCCDJLHIC>k__BackingField;
		}

		// Token: 0x0600E52F RID: 58671 RVA: 0x00516C15 File Offset: 0x00514E15
		public void GELHMIMICJD(string DPNHODJHGJL)
		{
			this.<PAHJOACFOFP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E530 RID: 58672 RVA: 0x00516C50 File Offset: 0x00514E50
		public float GDCGLBBAJHN()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E532 RID: 58674 RVA: 0x00516C50 File Offset: 0x00514E50
		public float DEFJMFBIGIM()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E533 RID: 58675 RVA: 0x00516C30 File Offset: 0x00514E30
		public bool GCLPAFADHMD()
		{
			return this.<APEKGLMDHDK>k__BackingField;
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x00516C83 File Offset: 0x00514E83
		public void LHCKCMBBBPH(string DPNHODJHGJL)
		{
			this.<ILPCCDJLHIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x00516C68 File Offset: 0x00514E68
		public void JFMDKOMJBLB(bool DPNHODJHGJL)
		{
			this.<AHMCLGDNEOE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E537 RID: 58679 RVA: 0x00516C38 File Offset: 0x00514E38
		public bool CILAHEMDKNO()
		{
			return this.<BGEDPCLDJAM>k__BackingField;
		}

		// Token: 0x0600E538 RID: 58680 RVA: 0x00516C60 File Offset: 0x00514E60
		public ulong CHDCIFPPIFI()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x00516C50 File Offset: 0x00514E50
		public float IFMFDMKFJBI()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E53A RID: 58682 RVA: 0x00516C71 File Offset: 0x00514E71
		public void GKENDAENHGL(float DPNHODJHGJL)
		{
			this.<FLLFAJGDFNF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E53B RID: 58683 RVA: 0x00516C7A File Offset: 0x00514E7A
		public void HCAKPOOEHCA(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E53C RID: 58684 RVA: 0x00516C27 File Offset: 0x00514E27
		public void ONCAHBANIAN(bool DPNHODJHGJL)
		{
			this.<APEKGLMDHDK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E53D RID: 58685 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool FLPLDEMKOFN()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E53E RID: 58686 RVA: 0x00516C71 File Offset: 0x00514E71
		public void EFNJNOEBKMO(float DPNHODJHGJL)
		{
			this.<FLLFAJGDFNF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E53F RID: 58687 RVA: 0x00516C83 File Offset: 0x00514E83
		public void BLGFMGLIOFN(string DPNHODJHGJL)
		{
			this.<ILPCCDJLHIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E540 RID: 58688 RVA: 0x00516C1E File Offset: 0x00514E1E
		public void FAMOCMOFODI(bool DPNHODJHGJL)
		{
			this.<BGEDPCLDJAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E542 RID: 58690 RVA: 0x00516C30 File Offset: 0x00514E30
		public bool OOFBBOBFPIH()
		{
			return this.<APEKGLMDHDK>k__BackingField;
		}

		// Token: 0x0600E543 RID: 58691 RVA: 0x00516C50 File Offset: 0x00514E50
		public float PJBPOLLEJFN()
		{
			return this.<FLLFAJGDFNF>k__BackingField;
		}

		// Token: 0x0600E544 RID: 58692 RVA: 0x00516C27 File Offset: 0x00514E27
		public void AGGGMKDPKJH(bool DPNHODJHGJL)
		{
			this.<APEKGLMDHDK>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E545 RID: 58693 RVA: 0x00516C48 File Offset: 0x00514E48
		public bool NPFHGDJAMPK()
		{
			return this.<AHMCLGDNEOE>k__BackingField;
		}

		// Token: 0x0600E546 RID: 58694 RVA: 0x00516C83 File Offset: 0x00514E83
		public void OKOPKJMDNGA(string DPNHODJHGJL)
		{
			this.<ILPCCDJLHIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E547 RID: 58695 RVA: 0x00516C68 File Offset: 0x00514E68
		public void BBFNMBEFDHN(bool DPNHODJHGJL)
		{
			this.<AHMCLGDNEOE>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003F1 RID: 1009
	public class MapsListJson
	{
		// Token: 0x0600E548 RID: 58696 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void GAFGJLDJCGD(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600E574 RID: 58740 RVA: 0x00516C95 File Offset: 0x00514E95
		// (set) Token: 0x0600E549 RID: 58697 RVA: 0x00516C8C File Offset: 0x00514E8C
		public List<RanksSystem.Map> maps { get; set; }

		// Token: 0x0600E54A RID: 58698 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void OBDLCCNAJDA(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E54B RID: 58699 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void DIAGAHGDCIP(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E54C RID: 58700 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> MGCLENCJDKC()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E54D RID: 58701 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void DKFKEMGEFHD(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E54E RID: 58702 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void EEMHKBMMNDE(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E54F RID: 58703 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> BIFHHDJDIPF()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E550 RID: 58704 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void FECMGMDBIAF(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E551 RID: 58705 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void JDOGPMLHKLI(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E552 RID: 58706 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void MNEKFJGJPEE(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E554 RID: 58708 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> NHLCIPAEDBK()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> JHHDJMKILHH()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E556 RID: 58710 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void CPPCOPEDNAJ(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E557 RID: 58711 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void EPMMEFGCCMP(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E558 RID: 58712 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> CDINIEMCHCA()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E559 RID: 58713 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void DKCNKLHBFGD(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E55A RID: 58714 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void BFOKNMJGKAC(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E55B RID: 58715 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> MIGBOJDIIOF()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E55C RID: 58716 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void ALHJJHMKIFG(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E55D RID: 58717 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void DBGCPDKKKOH(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E55E RID: 58718 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void MKPMMJCNPEM(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E55F RID: 58719 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void DIGGHMLHFFM(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E560 RID: 58720 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void CDDHDBDILGA(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E561 RID: 58721 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void BJNPDMDDEIF(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E562 RID: 58722 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void BLDLCGJKKEM(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E563 RID: 58723 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void CLGLJCGNJFI(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E564 RID: 58724 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void BHBFDIHCDLI(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E565 RID: 58725 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> CIHFCCGPLPF()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> ENDKCFKIOHD()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E567 RID: 58727 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void AJDMLBHGBAC(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E568 RID: 58728 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> IDFKENODONK()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E569 RID: 58729 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void ODOBIEMGJAN(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E56A RID: 58730 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void GHDACLOAGEL(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E56B RID: 58731 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> CNOKMFEGPOD()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E56C RID: 58732 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> KKBCDFPKOMB()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E56D RID: 58733 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void HFNFJJBAOBP(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E56E RID: 58734 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void EGHHOMOHALD(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E56F RID: 58735 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void HMBFIAGAIDJ(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E570 RID: 58736 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> FHCLMKFHANC()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E571 RID: 58737 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void BGBLFJDIFIB(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E572 RID: 58738 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void PACFCCHFFHE(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E573 RID: 58739 RVA: 0x00516C95 File Offset: 0x00514E95
		public List<RanksSystem.Map> KOHMFBCJDMH()
		{
			return this.<GKIGFPHDENP>k__BackingField;
		}

		// Token: 0x0600E575 RID: 58741 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void CAPLJIHIIID(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E576 RID: 58742 RVA: 0x00516C8C File Offset: 0x00514E8C
		public void NCDJMDFNCHP(List<RanksSystem.Map> DPNHODJHGJL)
		{
			this.<GKIGFPHDENP>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003F2 RID: 1010
	public class Score
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600E5A1 RID: 58785 RVA: 0x00516CF3 File Offset: 0x00514EF3
		// (set) Token: 0x0600E577 RID: 58743 RVA: 0x00516C9D File Offset: 0x00514E9D
		public string steamID { get; set; }

		// Token: 0x0600E578 RID: 58744 RVA: 0x00516CA6 File Offset: 0x00514EA6
		public void HFLMAPBJDAP(float DPNHODJHGJL)
		{
			this.<EPDGGHBOLBD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600E579 RID: 58745 RVA: 0x00516CAF File Offset: 0x00514EAF
		// (set) Token: 0x0600E598 RID: 58776 RVA: 0x00516CA6 File Offset: 0x00514EA6
		public float accuracy { get; set; }

		// Token: 0x0600E57A RID: 58746 RVA: 0x00516CB7 File Offset: 0x00514EB7
		public int JBKEBFBCHAK()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E57B RID: 58747 RVA: 0x00516CBF File Offset: 0x00514EBF
		public void OMBFGMMELHL(int DPNHODJHGJL)
		{
			this.<DIOMDJNIGAG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E57C RID: 58748 RVA: 0x00516C9D File Offset: 0x00514E9D
		public void LMHCKKPBCEJ(string DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E57D RID: 58749 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int HBKDJICGCGJ()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E57E RID: 58750 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public void OHEFIECEADL(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E57F RID: 58751 RVA: 0x00516CA6 File Offset: 0x00514EA6
		public void CJKMEBCLLGG(float DPNHODJHGJL)
		{
			this.<EPDGGHBOLBD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E580 RID: 58752 RVA: 0x00516C9D File Offset: 0x00514E9D
		public void NAKOJLJKOBP(string DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600E581 RID: 58753 RVA: 0x00516CD9 File Offset: 0x00514ED9
		// (set) Token: 0x0600E5A5 RID: 58789 RVA: 0x00516CEA File Offset: 0x00514EEA
		public string date { get; set; }

		// Token: 0x0600E582 RID: 58754 RVA: 0x00516CBF File Offset: 0x00514EBF
		public void JFAFIGCBKNE(int DPNHODJHGJL)
		{
			this.<DIOMDJNIGAG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E583 RID: 58755 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void FNHHKHACPAM(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E584 RID: 58756 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int CPDCGPAHIGA()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E585 RID: 58757 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void BGKKADIEFEF(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E586 RID: 58758 RVA: 0x00516CEA File Offset: 0x00514EEA
		public void DCMHLKONEPE(string DPNHODJHGJL)
		{
			this.<ABAHBKJHEPI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E587 RID: 58759 RVA: 0x00516CEA File Offset: 0x00514EEA
		public void GNKCJEBHCKN(string DPNHODJHGJL)
		{
			this.<ABAHBKJHEPI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E588 RID: 58760 RVA: 0x00516CB7 File Offset: 0x00514EB7
		public int KCGPEDCMDHA()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E589 RID: 58761 RVA: 0x00516CEA File Offset: 0x00514EEA
		public void MDBNEKJMPPJ(string DPNHODJHGJL)
		{
			this.<ABAHBKJHEPI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E58A RID: 58762 RVA: 0x00516C9D File Offset: 0x00514E9D
		public void PINMMDCFJGI(string DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E58B RID: 58763 RVA: 0x00516CD9 File Offset: 0x00514ED9
		public string BLHKAJBLHCD()
		{
			return this.<ABAHBKJHEPI>k__BackingField;
		}

		// Token: 0x0600E58C RID: 58764 RVA: 0x00516CAF File Offset: 0x00514EAF
		public float IMPANHLMOIH()
		{
			return this.<EPDGGHBOLBD>k__BackingField;
		}

		// Token: 0x0600E58D RID: 58765 RVA: 0x00516CBF File Offset: 0x00514EBF
		public void OMGMLKOGLFJ(int DPNHODJHGJL)
		{
			this.<DIOMDJNIGAG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600E59A RID: 58778 RVA: 0x00516CB7 File Offset: 0x00514EB7
		// (set) Token: 0x0600E58E RID: 58766 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public int place { get; set; }

		// Token: 0x0600E58F RID: 58767 RVA: 0x00516CB7 File Offset: 0x00514EB7
		public int LBKPHDHBLEH()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E590 RID: 58768 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void BEPEFAIOMKH(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E591 RID: 58769 RVA: 0x00516CF3 File Offset: 0x00514EF3
		public string EFEMONFHGDB()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E592 RID: 58770 RVA: 0x00516CB7 File Offset: 0x00514EB7
		public int OEIGOCIFIGO()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E593 RID: 58771 RVA: 0x00516C9D File Offset: 0x00514E9D
		public void GMHMMCNPAJL(string DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x00516C9D File Offset: 0x00514E9D
		public void OOLJMMKLIGL(string DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600E59F RID: 58783 RVA: 0x00516CC8 File Offset: 0x00514EC8
		// (set) Token: 0x0600E595 RID: 58773 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public int score { get; set; }

		// Token: 0x0600E596 RID: 58774 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public void ODKHOHEKPEG(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x00516CFB File Offset: 0x00514EFB
		// (set) Token: 0x0600E597 RID: 58775 RVA: 0x00516CBF File Offset: 0x00514EBF
		public int misses { get; set; }

		// Token: 0x0600E599 RID: 58777 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int NNJHIAPEALJ()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E59B RID: 58779 RVA: 0x00516CF3 File Offset: 0x00514EF3
		public string DBMLLBMLDFE()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E59C RID: 58780 RVA: 0x00516CEA File Offset: 0x00514EEA
		public void LMACEOGHOOO(string DPNHODJHGJL)
		{
			this.<ABAHBKJHEPI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E59D RID: 58781 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public void FBKDBPIILAC(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E59E RID: 58782 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void JAIEFLFNNKD(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5A0 RID: 58784 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public void PIJKMCNCAAJ(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5A2 RID: 58786 RVA: 0x00516CAF File Offset: 0x00514EAF
		public float FLMIJFCFNCL()
		{
			return this.<EPDGGHBOLBD>k__BackingField;
		}

		// Token: 0x0600E5A3 RID: 58787 RVA: 0x00516CFB File Offset: 0x00514EFB
		public int GDDOBNABDNE()
		{
			return this.<DIOMDJNIGAG>k__BackingField;
		}

		// Token: 0x0600E5A4 RID: 58788 RVA: 0x00516CFB File Offset: 0x00514EFB
		public int DNCEOPEHEID()
		{
			return this.<DIOMDJNIGAG>k__BackingField;
		}

		// Token: 0x0600E5A6 RID: 58790 RVA: 0x00516CEA File Offset: 0x00514EEA
		public void DGEBOFDFHAM(string DPNHODJHGJL)
		{
			this.<ABAHBKJHEPI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5A7 RID: 58791 RVA: 0x00516CA6 File Offset: 0x00514EA6
		public void JPCLCMDINFD(float DPNHODJHGJL)
		{
			this.<EPDGGHBOLBD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5A8 RID: 58792 RVA: 0x00516CD9 File Offset: 0x00514ED9
		public string BJKHJGIIBHL()
		{
			return this.<ABAHBKJHEPI>k__BackingField;
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x00516CBF File Offset: 0x00514EBF
		public void HIMBMOBJMBH(int DPNHODJHGJL)
		{
			this.<DIOMDJNIGAG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5AB RID: 58795 RVA: 0x00516C9D File Offset: 0x00514E9D
		public void GLMIGICOHAC(string DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5AC RID: 58796 RVA: 0x00516CFB File Offset: 0x00514EFB
		public int CNDMCBLCGFJ()
		{
			return this.<DIOMDJNIGAG>k__BackingField;
		}

		// Token: 0x0600E5AD RID: 58797 RVA: 0x00516CEA File Offset: 0x00514EEA
		public void DNMNKHNPJDB(string DPNHODJHGJL)
		{
			this.<ABAHBKJHEPI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5AE RID: 58798 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int FMBFCMOKBJL()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E5AF RID: 58799 RVA: 0x00516CBF File Offset: 0x00514EBF
		public void OJHHGJKJNAJ(int DPNHODJHGJL)
		{
			this.<DIOMDJNIGAG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5B0 RID: 58800 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int DOBGGOILPPO()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E5B1 RID: 58801 RVA: 0x00516CFB File Offset: 0x00514EFB
		public int BLMDEGCCCFD()
		{
			return this.<DIOMDJNIGAG>k__BackingField;
		}

		// Token: 0x0600E5B2 RID: 58802 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public void PABLALFBLBB(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void CAOIJCDJOOM(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5B4 RID: 58804 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public void CKCJIDMHJDO(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5B5 RID: 58805 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int CGOKNLBMIJB()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E5B6 RID: 58806 RVA: 0x00516CAF File Offset: 0x00514EAF
		public float PCDCMGOBHOD()
		{
			return this.<EPDGGHBOLBD>k__BackingField;
		}

		// Token: 0x0600E5B7 RID: 58807 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int GJPLIDHMEEJ()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E5B8 RID: 58808 RVA: 0x00516CEA File Offset: 0x00514EEA
		public void HJJICJDKILE(string DPNHODJHGJL)
		{
			this.<ABAHBKJHEPI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5B9 RID: 58809 RVA: 0x00516CD9 File Offset: 0x00514ED9
		public string GECMOEAHKPG()
		{
			return this.<ABAHBKJHEPI>k__BackingField;
		}

		// Token: 0x0600E5BA RID: 58810 RVA: 0x00516C9D File Offset: 0x00514E9D
		public void JHKJAAKBFMO(string DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5BB RID: 58811 RVA: 0x00516CB7 File Offset: 0x00514EB7
		public int FDMODBMKMKG()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E5BD RID: 58813 RVA: 0x00516CB7 File Offset: 0x00514EB7
		public int DIFFOAEBLFM()
		{
			return this.<OEHIIAPBGPJ>k__BackingField;
		}

		// Token: 0x0600E5BE RID: 58814 RVA: 0x00516CA6 File Offset: 0x00514EA6
		public void ENDHHBBADHB(float DPNHODJHGJL)
		{
			this.<EPDGGHBOLBD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5BF RID: 58815 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void KLGFCKKNNOF(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5C0 RID: 58816 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int NGIGIFCEFDF()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E5C1 RID: 58817 RVA: 0x00516CD0 File Offset: 0x00514ED0
		public void JKGKFLJDPKA(int DPNHODJHGJL)
		{
			this.<OEHIIAPBGPJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5C2 RID: 58818 RVA: 0x00516CF3 File Offset: 0x00514EF3
		public string LGJPIKFGCII()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E5C3 RID: 58819 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void KHDHCPMNOFP(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5C4 RID: 58820 RVA: 0x00516CC8 File Offset: 0x00514EC8
		public int EBABCEKKEGG()
		{
			return this.<BPNDCADENDJ>k__BackingField;
		}

		// Token: 0x0600E5C5 RID: 58821 RVA: 0x00516CE1 File Offset: 0x00514EE1
		public void LKHNACCELNN(int DPNHODJHGJL)
		{
			this.<BPNDCADENDJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5C6 RID: 58822 RVA: 0x00516CD9 File Offset: 0x00514ED9
		public string DOLCPECPMNH()
		{
			return this.<ABAHBKJHEPI>k__BackingField;
		}

		// Token: 0x0600E5C7 RID: 58823 RVA: 0x00516CA6 File Offset: 0x00514EA6
		public void IFNEOHEOCIL(float DPNHODJHGJL)
		{
			this.<EPDGGHBOLBD>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003F3 RID: 1011
	public class MapLeaderboard
	{
		// Token: 0x0600E5C8 RID: 58824 RVA: 0x00516D03 File Offset: 0x00514F03
		public void DKFFHJOCEDE(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5C9 RID: 58825 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int PMCCOICGALB()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E5CA RID: 58826 RVA: 0x00516D14 File Offset: 0x00514F14
		public int ECOCGNKEIKD()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E5CB RID: 58827 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int DLHNPOANIHA()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E5CC RID: 58828 RVA: 0x00516D14 File Offset: 0x00514F14
		public int KBFPAGNKLGK()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E5CD RID: 58829 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void CDMIAFPINFH(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x00516D14 File Offset: 0x00514F14
		// (set) Token: 0x0600E5CE RID: 58830 RVA: 0x00516D25 File Offset: 0x00514F25
		public int entriesCount { get; set; }

		// Token: 0x0600E5CF RID: 58831 RVA: 0x00516D2E File Offset: 0x00514F2E
		public string KKOGFPCIOBB()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x00516D2E File Offset: 0x00514F2E
		public string FNFEEMHHKIK()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x0600E5D2 RID: 58834 RVA: 0x00516D14 File Offset: 0x00514F14
		public int ELKLHCBICPJ()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E5D3 RID: 58835 RVA: 0x00516D03 File Offset: 0x00514F03
		public void MJEAEAEINLA(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x00516D36 File Offset: 0x00514F36
		// (set) Token: 0x0600E5D9 RID: 58841 RVA: 0x00516D1C File Offset: 0x00514F1C
		public List<RanksSystem.Score> scores { get; set; }

		// Token: 0x0600E5D5 RID: 58837 RVA: 0x00516D3E File Offset: 0x00514F3E
		public void EJNLBMAJBBF(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5D6 RID: 58838 RVA: 0x00516D03 File Offset: 0x00514F03
		public void HFNBLPHBANH(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5D7 RID: 58839 RVA: 0x00516D2E File Offset: 0x00514F2E
		public string IBBECFNAMBJ()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x0600E5D8 RID: 58840 RVA: 0x00516D47 File Offset: 0x00514F47
		public void AIHDJIAKAAF(GameScene.GameMode DPNHODJHGJL)
		{
			this.<HOGLILLDHLN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5DA RID: 58842 RVA: 0x00516D36 File Offset: 0x00514F36
		public List<RanksSystem.Score> JCNHHFKDCCK()
		{
			return this.<CLGNAIHJDFI>k__BackingField;
		}

		// Token: 0x0600E5DB RID: 58843 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void IHEPHLDBIBN(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5DC RID: 58844 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int KKOJAPEGKOM()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int JINCANAFNFA()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x00516D03 File Offset: 0x00514F03
		public void HGJNEFBBOPD(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x00516D2E File Offset: 0x00514F2E
		public string OKGKPEGFEJB()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x0600E5E0 RID: 58848 RVA: 0x00516D14 File Offset: 0x00514F14
		public int BJJGGIPAJHA()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600E604 RID: 58884 RVA: 0x00516D0C File Offset: 0x00514F0C
		// (set) Token: 0x0600E5E2 RID: 58850 RVA: 0x00516D03 File Offset: 0x00514F03
		public int page { get; set; }

		// Token: 0x0600E5E3 RID: 58851 RVA: 0x00516D2E File Offset: 0x00514F2E
		public string LGGBBFNLIME()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x0600E5E4 RID: 58852 RVA: 0x00516D47 File Offset: 0x00514F47
		public void LDMHOMIEAAB(GameScene.GameMode DPNHODJHGJL)
		{
			this.<HOGLILLDHLN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5E5 RID: 58853 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void NLAIICLPPHD(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5E6 RID: 58854 RVA: 0x00516D36 File Offset: 0x00514F36
		public List<RanksSystem.Score> EOFGFGDPKDO()
		{
			return this.<CLGNAIHJDFI>k__BackingField;
		}

		// Token: 0x0600E5E7 RID: 58855 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void EJAIBANAOLA(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5E8 RID: 58856 RVA: 0x00516D2E File Offset: 0x00514F2E
		public string FAOLENHKKLN()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x0600E5E9 RID: 58857 RVA: 0x00516D25 File Offset: 0x00514F25
		public void IGHANDGBMOL(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5EA RID: 58858 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int BNIPNGIBGKM()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E5EB RID: 58859 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int DNJMBGODJCD()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E5EC RID: 58860 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void FOKDDOEEMDO(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5ED RID: 58861 RVA: 0x00516D47 File Offset: 0x00514F47
		public void OMLEILFEGFE(GameScene.GameMode DPNHODJHGJL)
		{
			this.<HOGLILLDHLN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5EE RID: 58862 RVA: 0x00516D3E File Offset: 0x00514F3E
		public void GPFIJFFFBJO(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x00516D36 File Offset: 0x00514F36
		public List<RanksSystem.Score> LCDMFGOPFEN()
		{
			return this.<CLGNAIHJDFI>k__BackingField;
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void KMPPIAMLNKJ(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5F1 RID: 58865 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int BALJOLFOLHP()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E5F2 RID: 58866 RVA: 0x00516D25 File Offset: 0x00514F25
		public void AODLKOONJMM(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x00516D3E File Offset: 0x00514F3E
		public void IGLKLDHKFGO(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x00516D2E File Offset: 0x00514F2E
		public string OFBAIOAEKME()
		{
			return this.<BKDALLFMPCC>k__BackingField;
		}

		// Token: 0x0600E5F5 RID: 58869 RVA: 0x00516D14 File Offset: 0x00514F14
		public int MHBNAEOCMOJ()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E5F6 RID: 58870 RVA: 0x00516D25 File Offset: 0x00514F25
		public void JOCOONDJMGD(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x00516D3E File Offset: 0x00514F3E
		public void GHKIMJJEFMM(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5F8 RID: 58872 RVA: 0x00516D03 File Offset: 0x00514F03
		public void ANDDLPMJFOK(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5F9 RID: 58873 RVA: 0x00516D50 File Offset: 0x00514F50
		public GameScene.GameMode IGHJPDJCJAA()
		{
			return this.<HOGLILLDHLN>k__BackingField;
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600E60C RID: 58892 RVA: 0x00516D50 File Offset: 0x00514F50
		// (set) Token: 0x0600E5FA RID: 58874 RVA: 0x00516D47 File Offset: 0x00514F47
		public GameScene.GameMode gamemode { get; set; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x00516D2E File Offset: 0x00514F2E
		// (set) Token: 0x0600E609 RID: 58889 RVA: 0x00516D3E File Offset: 0x00514F3E
		public string mapID { get; set; }

		// Token: 0x0600E5FC RID: 58876 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void MDCFACNFCME(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5FD RID: 58877 RVA: 0x00516D1C File Offset: 0x00514F1C
		public void JJBBMBEKNHO(List<RanksSystem.Score> DPNHODJHGJL)
		{
			this.<CLGNAIHJDFI>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E5FE RID: 58878 RVA: 0x00516D14 File Offset: 0x00514F14
		public int MMANKFAMNBL()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E5FF RID: 58879 RVA: 0x00516D14 File Offset: 0x00514F14
		public int BEEHKENLHNI()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E600 RID: 58880 RVA: 0x00516D3E File Offset: 0x00514F3E
		public void KLKLNCDCEFD(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E601 RID: 58881 RVA: 0x00516D03 File Offset: 0x00514F03
		public void JKPGMGGCNCJ(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E602 RID: 58882 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int FJDGAMAHJEL()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E603 RID: 58883 RVA: 0x00516D03 File Offset: 0x00514F03
		public void ALIGHCEJKNF(int DPNHODJHGJL)
		{
			this.<LLOKOKDCMJH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E605 RID: 58885 RVA: 0x00516D0C File Offset: 0x00514F0C
		public int EKPKHNKFABD()
		{
			return this.<LLOKOKDCMJH>k__BackingField;
		}

		// Token: 0x0600E606 RID: 58886 RVA: 0x00516D50 File Offset: 0x00514F50
		public GameScene.GameMode IAMGBKGLLBJ()
		{
			return this.<HOGLILLDHLN>k__BackingField;
		}

		// Token: 0x0600E607 RID: 58887 RVA: 0x00516D14 File Offset: 0x00514F14
		public int GKBNMAGHDMP()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E608 RID: 58888 RVA: 0x00516D25 File Offset: 0x00514F25
		public void IMPEHAAFAJF(int DPNHODJHGJL)
		{
			this.<OGELODOODJM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E60A RID: 58890 RVA: 0x00516D14 File Offset: 0x00514F14
		public int KMEJCPCEPLI()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E60B RID: 58891 RVA: 0x00516D3E File Offset: 0x00514F3E
		public void MEHOFHNNKCN(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E60D RID: 58893 RVA: 0x00516D50 File Offset: 0x00514F50
		public GameScene.GameMode GBFKCKOCIGL()
		{
			return this.<HOGLILLDHLN>k__BackingField;
		}

		// Token: 0x0600E60E RID: 58894 RVA: 0x00516D3E File Offset: 0x00514F3E
		public void AEDNDCPEMIF(string DPNHODJHGJL)
		{
			this.<BKDALLFMPCC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E60F RID: 58895 RVA: 0x00516D14 File Offset: 0x00514F14
		public int BLMGAHICCFE()
		{
			return this.<OGELODOODJM>k__BackingField;
		}

		// Token: 0x0600E610 RID: 58896 RVA: 0x00516D36 File Offset: 0x00514F36
		public List<RanksSystem.Score> FJEJKNAMOJD()
		{
			return this.<CLGNAIHJDFI>k__BackingField;
		}
	}

	// Token: 0x020003F4 RID: 1012
	public class PlayersTipsJson
	{
		// Token: 0x0600E611 RID: 58897 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> MJKCFMJEIFG()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E612 RID: 58898 RVA: 0x00516D60 File Offset: 0x00514F60
		public void KIIHGOCALBE(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E613 RID: 58899 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> HDJKGGDBEPA()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E614 RID: 58900 RVA: 0x00516D60 File Offset: 0x00514F60
		public void HDCEEDJLOEO(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E615 RID: 58901 RVA: 0x00516D60 File Offset: 0x00514F60
		public void LDILNAOELGO(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E616 RID: 58902 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> NBLIFLKGMNH()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E617 RID: 58903 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> EJGCBCAIFOL()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E618 RID: 58904 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> GNPAOPOAPAC()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E619 RID: 58905 RVA: 0x00516D60 File Offset: 0x00514F60
		public void ODICHKMHBEG(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E61A RID: 58906 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> FLIOJNMBLNL()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E61B RID: 58907 RVA: 0x00516D60 File Offset: 0x00514F60
		public void ALCIJFHONFN(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E61C RID: 58908 RVA: 0x00516D60 File Offset: 0x00514F60
		public void CPOMOHJAEKM(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E61D RID: 58909 RVA: 0x00516D60 File Offset: 0x00514F60
		public void LDGIBMJBPID(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E61E RID: 58910 RVA: 0x00516D60 File Offset: 0x00514F60
		public void NBFFBPBMBFO(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E61F RID: 58911 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> PAJNMEJPPPC()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E620 RID: 58912 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> NCEHNDDLIEG()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E621 RID: 58913 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> AFPPFBKNBOG()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E622 RID: 58914 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> GFAKCBIPMLC()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E623 RID: 58915 RVA: 0x00516D60 File Offset: 0x00514F60
		public void GBOLBALHHPJ(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E624 RID: 58916 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> JNBKELJKIKG()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E625 RID: 58917 RVA: 0x00516D60 File Offset: 0x00514F60
		public void GBADDOBDGPD(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E626 RID: 58918 RVA: 0x00516D60 File Offset: 0x00514F60
		public void EIDDOJODJAF(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E627 RID: 58919 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> APKFNPGCNLD()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E628 RID: 58920 RVA: 0x00516D60 File Offset: 0x00514F60
		public void BOOHJEDFCCJ(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E629 RID: 58921 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> JJKFMPPOKMJ()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E62A RID: 58922 RVA: 0x00516D60 File Offset: 0x00514F60
		public void DKHFFKGLMLE(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E62B RID: 58923 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> LEOAONFEILL()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E62C RID: 58924 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> MCMCGEAHFIB()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E62D RID: 58925 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> FPPJGPNKNJM()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E62E RID: 58926 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> PAPPKBKALND()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E62F RID: 58927 RVA: 0x00516D60 File Offset: 0x00514F60
		public void HKCAHENEHPD(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E630 RID: 58928 RVA: 0x00516D60 File Offset: 0x00514F60
		public void HJHKPBFPGKI(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E631 RID: 58929 RVA: 0x00516D60 File Offset: 0x00514F60
		public void MINPGCNMEEE(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E632 RID: 58930 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> NNKAFKOPEJG()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E633 RID: 58931 RVA: 0x00516D60 File Offset: 0x00514F60
		public void OHNILHBJPFO(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E634 RID: 58932 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> JMGFFOJLMNA()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E635 RID: 58933 RVA: 0x00516D60 File Offset: 0x00514F60
		public void PPCIDPGOGKG(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600E644 RID: 58948 RVA: 0x00516D58 File Offset: 0x00514F58
		// (set) Token: 0x0600E636 RID: 58934 RVA: 0x00516D60 File Offset: 0x00514F60
		public List<RanksSystem.PlayerTip> tips { get; set; }

		// Token: 0x0600E638 RID: 58936 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> BMFPIJACAJM()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E639 RID: 58937 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> EGNJNEMBFPA()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E63A RID: 58938 RVA: 0x00516D60 File Offset: 0x00514F60
		public void OAFADDMOHIH(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E63B RID: 58939 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> CENEHJAOEOO()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E63C RID: 58940 RVA: 0x00516D60 File Offset: 0x00514F60
		public void HDOIKFDPLLE(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E63D RID: 58941 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> MFKFCIONKCM()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E63E RID: 58942 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> NDIGPPLAIJH()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E63F RID: 58943 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> IFIOFCMOHAM()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E640 RID: 58944 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> OEPILNNNEIH()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E641 RID: 58945 RVA: 0x00516D60 File Offset: 0x00514F60
		public void JEEEGKDNAOP(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E642 RID: 58946 RVA: 0x00516D60 File Offset: 0x00514F60
		public void LKKNGBHNDMM(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> BACGHDICJOM()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E645 RID: 58949 RVA: 0x00516D60 File Offset: 0x00514F60
		public void GLPLNBNBAAN(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E646 RID: 58950 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> DOAKMNDIAPP()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E647 RID: 58951 RVA: 0x00516D60 File Offset: 0x00514F60
		public void MJFEMECKIII(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E648 RID: 58952 RVA: 0x00516D60 File Offset: 0x00514F60
		public void GCBCBDMOKFH(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E649 RID: 58953 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> HBIAKHFJBBF()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E64A RID: 58954 RVA: 0x00516D60 File Offset: 0x00514F60
		public void OAADMIBFHJE(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E64B RID: 58955 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> BEBHFKGOIOL()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E64C RID: 58956 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> FNAMEDDIEJJ()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E64D RID: 58957 RVA: 0x00516D58 File Offset: 0x00514F58
		public List<RanksSystem.PlayerTip> ODIJAMIABJM()
		{
			return this.<MFGKDEDHPMJ>k__BackingField;
		}

		// Token: 0x0600E64E RID: 58958 RVA: 0x00516D60 File Offset: 0x00514F60
		public void EKHGLIIKKMG(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E64F RID: 58959 RVA: 0x00516D60 File Offset: 0x00514F60
		public void DNBIDJDIKLG(List<RanksSystem.PlayerTip> DPNHODJHGJL)
		{
			this.<MFGKDEDHPMJ>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003F5 RID: 1013
	public class PlayerTip
	{
		// Token: 0x0600E650 RID: 58960 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong GOKADDKEMFK()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E651 RID: 58961 RVA: 0x00516D74 File Offset: 0x00514F74
		public int NNLHLJDEMEA()
		{
			int num = 0;
			try
			{
				string text = this.HOHOAOGHFDO();
				char[] array = new char[1];
				array[1] = (char)-46;
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[0] = '\u0004';
					num = num2 + int.Parse(text3.Split(array4)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E652 RID: 58962 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string MKLBKIJOGBG()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E653 RID: 58963 RVA: 0x00516DF8 File Offset: 0x00514FF8
		public int GetUserVote()
		{
			int result = 0;
			try
			{
				string[] array = this.votes.Split(new char[]
				{
					';'
				});
				foreach (string text in array)
				{
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text.Split(new char[]
					{
						'|'
					})[1]))
					{
						result = int.Parse(text.Split(new char[]
						{
							'|'
						})[0]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E654 RID: 58964 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong LKKNPEBMCHA()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E655 RID: 58965 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string IHGKNCLFHEP()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600E656 RID: 58966 RVA: 0x00516DF0 File Offset: 0x00514FF0
		// (set) Token: 0x0600E6D3 RID: 59091 RVA: 0x00517954 File Offset: 0x00515B54
		public string tip { get; set; }

		// Token: 0x0600E657 RID: 58967 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void IHENCDKCJNB(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E658 RID: 58968 RVA: 0x00516EA9 File Offset: 0x005150A9
		public void IFPLIBFLOOM(string DPNHODJHGJL)
		{
			this.<DMAKNKNPHFO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E659 RID: 58969 RVA: 0x00516EB4 File Offset: 0x005150B4
		public int PKHPADAEJEG()
		{
			int num = 0;
			try
			{
				string text = this.FHMMOHLGLOL();
				char[] array = new char[1];
				array[1] = (char)-100;
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[1];
					array4[1] = (char)-56;
					num = num2 + int.Parse(text3.Split(array4)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E65A RID: 58970 RVA: 0x00516F30 File Offset: 0x00515130
		public void BHHEEGGLADG(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E65B RID: 58971 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong IHGAFOAMKAD()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600E68C RID: 59020 RVA: 0x00516FC9 File Offset: 0x005151C9
		// (set) Token: 0x0600E65C RID: 58972 RVA: 0x00516EA9 File Offset: 0x005150A9
		public string votes { get; set; }

		// Token: 0x0600E65D RID: 58973 RVA: 0x00516F44 File Offset: 0x00515144
		public int OGIHMBKNFAC()
		{
			int num = 0;
			try
			{
				string text = this.FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = (char)-127;
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split(new char[]
					{
						(char)-17
					})[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E65E RID: 58974 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void ADEANDNCNLF(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E65F RID: 58975 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string MIDAMGAGFIA()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E660 RID: 58976 RVA: 0x00516F30 File Offset: 0x00515130
		public void KEKDDPICPDK(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E661 RID: 58977 RVA: 0x00516FD4 File Offset: 0x005151D4
		public int BAKGBEGKGFD()
		{
			int num = 1;
			try
			{
				string text = this.HOHOAOGHFDO();
				char[] array = new char[0];
				array[1] = (char)-55;
				string[] array2 = text.Split(array);
				foreach (string text2 in array2)
				{
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[1];
					array4[1] = (char)-8;
					num = num2 + int.Parse(text3.Split(array4)[0]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E662 RID: 58978 RVA: 0x00517050 File Offset: 0x00515250
		public int EIBIDABNHLP()
		{
			int num = 0;
			try
			{
				string text = this.FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = (char)-43;
				string[] array2 = text.Split(array);
				foreach (string text2 in array2)
				{
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[1] = (char)-104;
					num = num2 + int.Parse(text3.Split(array4)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E663 RID: 58979 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong IIPMMNJPGMA()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E664 RID: 58980 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void KMLNCEGPDEL(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E665 RID: 58981 RVA: 0x005170CC File Offset: 0x005152CC
		public string JPKPKHLJDDK()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E666 RID: 58982 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string EBEANLDNDHL()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E667 RID: 58983 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string DNEGFHNDOKP()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600E6DA RID: 59098 RVA: 0x005170CC File Offset: 0x005152CC
		// (set) Token: 0x0600E668 RID: 58984 RVA: 0x00516EA0 File Offset: 0x005150A0
		public string language { get; set; }

		// Token: 0x0600E669 RID: 58985 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string BIMMNOGPBBO()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E66A RID: 58986 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void CKKHEBBKMPD(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E66B RID: 58987 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong OKFOADGNODA()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E66C RID: 58988 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string FHMMOHLGLOL()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E66D RID: 58989 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string DOMCGFLKBIM()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E66E RID: 58990 RVA: 0x005170CC File Offset: 0x005152CC
		public string MHGCKABGGCB()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E66F RID: 58991 RVA: 0x005170D4 File Offset: 0x005152D4
		public int LKHKLECGPFD()
		{
			int num = 1;
			try
			{
				string[] array = this.FHMMOHLGLOL().Split(new char[]
				{
					(char)-50
				});
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string text = array2[i];
					int num2 = num;
					string text2 = text;
					char[] array3 = new char[1];
					array3[1] = (char)-50;
					num = num2 + int.Parse(text2.Split(array3)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E670 RID: 58992 RVA: 0x00517150 File Offset: 0x00515350
		public int GetRating()
		{
			int num = 0;
			try
			{
				string[] array = this.votes.Split(new char[]
				{
					';'
				});
				foreach (string text in array)
				{
					num += int.Parse(text.Split(new char[]
					{
						'|'
					})[0]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E671 RID: 58993 RVA: 0x005170CC File Offset: 0x005152CC
		public string FDLGDAJGABF()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E672 RID: 58994 RVA: 0x005171CC File Offset: 0x005153CC
		public int PIBNHCNPMNM()
		{
			int result = 1;
			try
			{
				string[] array = this.HOHOAOGHFDO().Split(new char[]
				{
					(char)-4
				});
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string text = array2[i];
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text2 = text;
					char[] array3 = new char[0];
					array3[0] = (char)-75;
					if (steamID == ulong.Parse(text2.Split(array3)[0]))
					{
						string text3 = text;
						char[] array4 = new char[0];
						array4[0] = 'r';
						result = int.Parse(text3.Split(array4)[0]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E673 RID: 58995 RVA: 0x005170CC File Offset: 0x005152CC
		public string DFPAENPEGGM()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E674 RID: 58996 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong OEHGOHJGENG()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E675 RID: 58997 RVA: 0x00517274 File Offset: 0x00515474
		public int JLIKEOFNCPO()
		{
			int num = 0;
			try
			{
				string text = this.FJICLFAAFNM();
				char[] array = new char[0];
				array[0] = (char)-43;
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[1];
					array4[1] = (char)-59;
					num = num2 + int.Parse(text3.Split(array4)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E676 RID: 58998 RVA: 0x00516EA9 File Offset: 0x005150A9
		public void NAOEEBAEGDJ(string DPNHODJHGJL)
		{
			this.<DMAKNKNPHFO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E677 RID: 58999 RVA: 0x005172F0 File Offset: 0x005154F0
		public int GECKLJLICFP()
		{
			int num = 0;
			try
			{
				string votes = this.votes;
				char[] array = new char[0];
				array[1] = '\v';
				string[] array2 = votes.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text = array3[i];
					num += int.Parse(text.Split(new char[]
					{
						(char)-64
					})[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E678 RID: 59000 RVA: 0x0051736C File Offset: 0x0051556C
		public int CDCIANGOJLC()
		{
			int result = 1;
			try
			{
				string[] array = this.NJKPMJKDOMK().Split(new char[]
				{
					'\u0019'
				});
				foreach (string text in array)
				{
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text2 = text;
					char[] array3 = new char[0];
					array3[1] = (char)-111;
					if (steamID == ulong.Parse(text2.Split(array3)[1]))
					{
						string text3 = text;
						char[] array4 = new char[1];
						array4[1] = (char)-65;
						result = int.Parse(text3.Split(array4)[1]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E679 RID: 59001 RVA: 0x00516F30 File Offset: 0x00515130
		public void CAAKCCHPHOB(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E67A RID: 59002 RVA: 0x00516EA9 File Offset: 0x005150A9
		public void PELBIOCEALB(string DPNHODJHGJL)
		{
			this.<DMAKNKNPHFO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E67B RID: 59003 RVA: 0x005170CC File Offset: 0x005152CC
		public string MNHHIGAFBEM()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E67C RID: 59004 RVA: 0x00517414 File Offset: 0x00515614
		public int FBIJLICDDFD()
		{
			int num = 1;
			try
			{
				string text = this.CNIIOBIAONN();
				char[] array = new char[0];
				array[0] = '\u0016';
				string[] array2 = text.Split(array);
				foreach (string text2 in array2)
				{
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[1] = (char)-12;
					num = num2 + int.Parse(text3.Split(array4)[0]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E67D RID: 59005 RVA: 0x00516F30 File Offset: 0x00515130
		public void AAOIBICPOIK(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E67E RID: 59006 RVA: 0x00517490 File Offset: 0x00515690
		public int PFHBHDDKINJ()
		{
			int num = 1;
			try
			{
				string text = this.NFHDFIILPEE();
				char[] array = new char[0];
				array[0] = ',';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split(new char[]
					{
						'k'
					})[0]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E67F RID: 59007 RVA: 0x0051750C File Offset: 0x0051570C
		public void EHGCFDCPLCP(int BMAEINMDAFF)
		{
			if (this.AJMEEPGHOAH() != 0)
			{
				string text = string.Empty;
				string text2 = this.DOMCGFLKBIM();
				char[] array = new char[0];
				array[1] = (char)-57;
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					string text4 = text3;
					char[] array4 = new char[0];
					array4[1] = (char)-51;
					string text5 = text4.Split(array4)[0];
					string text6 = text3;
					char[] array5 = new char[0];
					array5[1] = (char)-86;
					string text7 = text6.Split(array5)[1];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text7))
					{
						text5 = string.Empty + BMAEINMDAFF;
					}
					string text8 = text;
					string[] array6 = new string[0];
					array6[0] = text8;
					array6[0] = ((text.Length <= 0) ? string.Empty : "settings.enablehitsoundsinnormal");
					array6[8] = text5;
					array6[1] = "The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.";
					array6[5] = text7;
					text = string.Concat(array6);
				}
				this.BIOBDKHCFIB(text);
			}
			else
			{
				object[] array7 = new object[2];
				array7[0] = this.NJKPMJKDOMK();
				array7[1] = "float,0";
				array7[5] = BMAEINMDAFF;
				array7[1] = "\\n";
				array7[7] = SteamUser.GetSteamID().m_SteamID;
				this.AIAJMCKBLKI(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(this.JJKDAFNCDIF(), BMAEINMDAFF);
		}

		// Token: 0x0600E680 RID: 59008 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string BFIJMABPKOF()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E681 RID: 59009 RVA: 0x005170CC File Offset: 0x005152CC
		public string IAAJFBECEOA()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E682 RID: 59010 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong CIBGICHFIME()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E683 RID: 59011 RVA: 0x00517660 File Offset: 0x00515860
		public int HEDKODDNFEA()
		{
			int num = 1;
			try
			{
				string text = this.FJICLFAAFNM();
				char[] array = new char[0];
				array[0] = '2';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split(new char[]
					{
						'('
					})[0]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E684 RID: 59012 RVA: 0x00516F30 File Offset: 0x00515130
		public void EPPPFMHNCKI(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E685 RID: 59013 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong JJKDAFNCDIF()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E686 RID: 59014 RVA: 0x005176DC File Offset: 0x005158DC
		public void DLBDGKKCEFO(int BMAEINMDAFF)
		{
			if (this.IPLNCBFBGFJ() != 0)
			{
				string text = string.Empty;
				string text2 = this.DOMCGFLKBIM();
				char[] array = new char[1];
				array[1] = '3';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					string text4 = text3;
					char[] array4 = new char[0];
					array4[0] = (char)-50;
					string text5 = text4.Split(array4)[1];
					string text6 = text3.Split(new char[]
					{
						(char)-126
					})[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text6))
					{
						text5 = string.Empty + BMAEINMDAFF;
					}
					string text7 = text;
					string[] array5 = new string[]
					{
						null,
						text7
					};
					array5[0] = ((text.Length <= 0) ? string.Empty : "_Value");
					array5[2] = text5;
					array5[0] = "_Blue_C";
					array5[2] = text6;
					text = string.Concat(array5);
				}
				this.AIAJMCKBLKI(text);
			}
			else
			{
				object[] array6 = new object[8];
				array6[1] = this.FAGKKOIOALB();
				array6[0] = ".lastCheckpoint.currentCombo";
				array6[3] = BMAEINMDAFF;
				array6[6] = "OK";
				array6[7] = SteamUser.GetSteamID().m_SteamID;
				this.PELBIOCEALB(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(this.id, BMAEINMDAFF);
		}

		// Token: 0x0600E687 RID: 59015 RVA: 0x005170CC File Offset: 0x005152CC
		public string JEEGBIGEJMP()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E688 RID: 59016 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void HCEOMMIJOFO(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E689 RID: 59017 RVA: 0x00517830 File Offset: 0x00515A30
		public int GIGDJNPBFNJ()
		{
			int result = 1;
			try
			{
				string text = this.MIDAMGAGFIA();
				char[] array = new char[0];
				array[1] = 'R';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[1] = 'p';
					if (steamID == ulong.Parse(text3.Split(array4)[1]))
					{
						result = int.Parse(text2.Split(new char[]
						{
							(char)-38
						})[0]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E68A RID: 59018 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string ABPAKJHNIPG()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E68B RID: 59019 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string COEFMOFKOJE()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E68D RID: 59021 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void PINMMDCFJGI(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600E6D4 RID: 59092 RVA: 0x00516F39 File Offset: 0x00515139
		// (set) Token: 0x0600E68E RID: 59022 RVA: 0x00516F30 File Offset: 0x00515130
		public ulong id { get; set; }

		// Token: 0x0600E68F RID: 59023 RVA: 0x00516EA9 File Offset: 0x005150A9
		public void MHKPAIMLJHH(string DPNHODJHGJL)
		{
			this.<DMAKNKNPHFO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E690 RID: 59024 RVA: 0x00516EA9 File Offset: 0x005150A9
		public void AIAJMCKBLKI(string DPNHODJHGJL)
		{
			this.<DMAKNKNPHFO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E691 RID: 59025 RVA: 0x005178D8 File Offset: 0x00515AD8
		public int DNLGIMEFFDC()
		{
			int num = 0;
			try
			{
				string[] array = this.BFIJMABPKOF().Split(new char[]
				{
					'['
				});
				foreach (string text in array)
				{
					int num2 = num;
					string text2 = text;
					char[] array3 = new char[0];
					array3[1] = ']';
					num = num2 + int.Parse(text2.Split(array3)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E692 RID: 59026 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string DBNAGAOOGPO()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E693 RID: 59027 RVA: 0x00516F30 File Offset: 0x00515130
		public void HCMBNLCNBGF(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E694 RID: 59028 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string FFGMCNAEAKH()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E695 RID: 59029 RVA: 0x00517954 File Offset: 0x00515B54
		public void LJKJLEAAMJN(string DPNHODJHGJL)
		{
			this.<MMJCIPEEEEG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E696 RID: 59030 RVA: 0x00517960 File Offset: 0x00515B60
		public int IGJGHMHMOOH()
		{
			int result = 0;
			try
			{
				string text = this.MIDAMGAGFIA();
				char[] array = new char[1];
				array[1] = '8';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text2.Split(new char[]
					{
						(char)-100
					})[1]))
					{
						string text3 = text2;
						char[] array4 = new char[1];
						array4[1] = (char)-97;
						result = int.Parse(text3.Split(array4)[0]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E697 RID: 59031 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string IKOLPBDKHIN()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E698 RID: 59032 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong DBMLLBMLDFE()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E699 RID: 59033 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string NJKPMJKDOMK()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E69A RID: 59034 RVA: 0x00517A08 File Offset: 0x00515C08
		public int FEDBIGMAHEA()
		{
			int num = 0;
			try
			{
				string text = this.FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = (char)-72;
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					num += int.Parse(text2.Split(new char[]
					{
						'Q'
					})[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E69B RID: 59035 RVA: 0x00517A84 File Offset: 0x00515C84
		public void KMJBGNACIED(int BMAEINMDAFF)
		{
			if (this.CMIDMJKBAGJ() != 0)
			{
				string text = string.Empty;
				string text2 = this.MIDAMGAGFIA();
				char[] array = new char[0];
				array[0] = 'U';
				string[] array2 = text2.Split(array);
				foreach (string text3 in array2)
				{
					string text4 = text3.Split(new char[]
					{
						'('
					})[1];
					string text5 = text3;
					char[] array4 = new char[1];
					array4[1] = (char)-50;
					string text6 = text5.Split(array4)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text6))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text7 = text;
					string[] array5 = new string[1];
					array5[1] = text7;
					array5[1] = ((text.Length <= 1) ? string.Empty : "2hands");
					array5[1] = text4;
					array5[8] = "Apr";
					array5[6] = text6;
					text = string.Concat(array5);
				}
				this.IFPLIBFLOOM(text);
			}
			else
			{
				object[] array6 = new object[6];
				array6[1] = this.MHCBHFCPKCD();
				array6[0] = "CameraFilterPack/Oculus_NightVision2";
				array6[7] = BMAEINMDAFF;
				array6[7] = "workshop.";
				array6[8] = SteamUser.GetSteamID().m_SteamID;
				this.BIOBDKHCFIB(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(this.id, BMAEINMDAFF);
		}

		// Token: 0x0600E69C RID: 59036 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void JEJMPBHEODM(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E69D RID: 59037 RVA: 0x00517BD8 File Offset: 0x00515DD8
		public int KJDIFACCLFL()
		{
			int result = 1;
			try
			{
				string text = this.FAGKKOIOALB();
				char[] array = new char[0];
				array[0] = '\v';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[1] = (char)-30;
					if (steamID == ulong.Parse(text3.Split(array4)[1]))
					{
						string text4 = text2;
						char[] array5 = new char[1];
						array5[1] = (char)-72;
						result = int.Parse(text4.Split(array5)[1]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E69E RID: 59038 RVA: 0x00517C80 File Offset: 0x00515E80
		public int LENKEOHCLKM()
		{
			int result = 1;
			try
			{
				string text = this.FAGKKOIOALB();
				char[] array = new char[0];
				array[1] = 'h';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text2 = array3[i];
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text3 = text2;
					char[] array4 = new char[1];
					array4[1] = (char)-48;
					if (steamID == ulong.Parse(text3.Split(array4)[1]))
					{
						result = int.Parse(text2.Split(new char[]
						{
							(char)-5
						})[1]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E69F RID: 59039 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string GNGMJGFIKGD()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6A0 RID: 59040 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong NOKJFJDPHDJ()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E6A1 RID: 59041 RVA: 0x00516EA9 File Offset: 0x005150A9
		public void BIOBDKHCFIB(string DPNHODJHGJL)
		{
			this.<DMAKNKNPHFO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6A2 RID: 59042 RVA: 0x00517D28 File Offset: 0x00515F28
		public int KJDDPBDIEGD()
		{
			int num = 1;
			try
			{
				string text = this.MHCBHFCPKCD();
				char[] array = new char[0];
				array[0] = (char)-69;
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[0] = 'R';
					num = num2 + int.Parse(text3.Split(array4)[0]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x00517DA4 File Offset: 0x00515FA4
		public int AJMEEPGHOAH()
		{
			int result = 0;
			try
			{
				string text = this.CNIIOBIAONN();
				char[] array = new char[1];
				array[1] = '\u0012';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[1] = (char)-36;
					if (steamID == ulong.Parse(text3.Split(array4)[1]))
					{
						string text4 = text2;
						char[] array5 = new char[0];
						array5[1] = (char)-22;
						result = int.Parse(text4.Split(array5)[1]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string MHCBHFCPKCD()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E6A5 RID: 59045 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string PIOIINMGAOP()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6A6 RID: 59046 RVA: 0x00517954 File Offset: 0x00515B54
		public void CDDGMCLMPEG(string DPNHODJHGJL)
		{
			this.<MMJCIPEEEEG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600E6BD RID: 59069 RVA: 0x00516D69 File Offset: 0x00514F69
		// (set) Token: 0x0600E6A7 RID: 59047 RVA: 0x00516FC0 File Offset: 0x005151C0
		public ulong steamID { get; set; }

		// Token: 0x0600E6A8 RID: 59048 RVA: 0x00517E4C File Offset: 0x0051604C
		public int HKBLIMCKKEH()
		{
			int num = 1;
			try
			{
				string text = this.NFHDFIILPEE();
				char[] array = new char[0];
				array[1] = (char)-123;
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[1] = (char)-87;
					num = num2 + int.Parse(text3.Split(array4)[0]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E6A9 RID: 59049 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string IHDFNLLIHPN()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6AA RID: 59050 RVA: 0x005170CC File Offset: 0x005152CC
		public string JACPJLIGEOP()
		{
			return this.<KNKMBLBALJN>k__BackingField;
		}

		// Token: 0x0600E6AB RID: 59051 RVA: 0x00516EA9 File Offset: 0x005150A9
		public void PDGNODHEFOF(string DPNHODJHGJL)
		{
			this.<DMAKNKNPHFO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6AC RID: 59052 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string NFHDFIILPEE()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E6AD RID: 59053 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong CNOJOFMOEKP()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E6AE RID: 59054 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string HLJJDODBJMN()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6AF RID: 59055 RVA: 0x00516F30 File Offset: 0x00515130
		public void JIEOJEMCABN(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6B0 RID: 59056 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong LHDHLDLEACP()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E6B1 RID: 59057 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void EHPNOPLMJCC(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6B2 RID: 59058 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string FAGKKOIOALB()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E6B3 RID: 59059 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void PMHHCJJMJMA(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6B4 RID: 59060 RVA: 0x00517954 File Offset: 0x00515B54
		public void BILPCBEPEFH(string DPNHODJHGJL)
		{
			this.<MMJCIPEEEEG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6B5 RID: 59061 RVA: 0x00517EC8 File Offset: 0x005160C8
		public void PKCJEJBPKOE(int BMAEINMDAFF)
		{
			if (this.PIBNHCNPMNM() != 0)
			{
				string text = string.Empty;
				string text2 = this.BFIJMABPKOF();
				char[] array = new char[0];
				array[1] = 'D';
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					string text3 = array3[i];
					string text4 = text3;
					char[] array4 = new char[0];
					array4[0] = (char)-38;
					string text5 = text4.Split(array4)[0];
					string text6 = text3;
					char[] array5 = new char[1];
					array5[1] = (char)-35;
					string text7 = text6.Split(array5)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text7))
					{
						text5 = string.Empty + BMAEINMDAFF;
					}
					string text8 = text;
					string[] array6 = new string[0];
					array6[1] = text8;
					array6[0] = ((text.Length <= 1) ? string.Empty : "0");
					array6[1] = text5;
					array6[7] = "_ScreenResolution";
					array6[2] = text7;
					text = string.Concat(array6);
				}
				this.BIOBDKHCFIB(text);
			}
			else
			{
				object[] array7 = new object[]
				{
					this.NJKPMJKDOMK(),
					"_Value2"
				};
				array7[1] = BMAEINMDAFF;
				array7[5] = "#no";
				array7[0] = SteamUser.GetSteamID().m_SteamID;
				this.BIOBDKHCFIB(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(this.IIPMMNJPGMA(), BMAEINMDAFF);
		}

		// Token: 0x0600E6B6 RID: 59062 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void NFAAADLGEGI(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6B7 RID: 59063 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string FJICLFAAFNM()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E6B9 RID: 59065 RVA: 0x0051801C File Offset: 0x0051621C
		public void ACBCECFHCIO(int BMAEINMDAFF)
		{
			if (this.KHMMMHMDFNF() != 0)
			{
				string text = string.Empty;
				string[] array = this.DOMCGFLKBIM().Split(new char[]
				{
					'X'
				});
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					string text2 = array2[i];
					string text3 = text2;
					char[] array3 = new char[0];
					array3[1] = 'G';
					string text4 = text3.Split(array3)[0];
					string text5 = text2;
					char[] array4 = new char[0];
					array4[0] = (char)-104;
					string text6 = text5.Split(array4)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text6))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text7 = text;
					string[] array5 = new string[5];
					array5[0] = text7;
					array5[1] = ((text.Length <= 0) ? string.Empty : "MenuRecordButton");
					array5[8] = text4;
					array5[5] = "OnAwakeRPC";
					array5[7] = text6;
					text = string.Concat(array5);
				}
				this.NAOEEBAEGDJ(text);
			}
			else
			{
				object[] array6 = new object[]
				{
					this.NFHDFIILPEE(),
					"_Value7"
				};
				array6[0] = BMAEINMDAFF;
				array6[4] = "MapConfig";
				array6[8] = SteamUser.GetSteamID().m_SteamID;
				this.IFPLIBFLOOM(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(this.JJKDAFNCDIF(), BMAEINMDAFF);
		}

		// Token: 0x0600E6BA RID: 59066 RVA: 0x00518170 File Offset: 0x00516370
		public void JFMDLDIGBHE(int BMAEINMDAFF)
		{
			if (this.IPLNCBFBGFJ() != 0)
			{
				string text = string.Empty;
				string[] array = this.FHMMOHLGLOL().Split(new char[]
				{
					','
				});
				string[] array2 = array;
				for (int i = 1; i < array2.Length; i++)
				{
					string text2 = array2[i];
					string text3 = text2;
					char[] array3 = new char[0];
					array3[0] = '}';
					string text4 = text3.Split(array3)[1];
					string text5 = text2;
					char[] array4 = new char[1];
					array4[1] = (char)-114;
					string text6 = text5.Split(array4)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text6))
					{
						text4 = string.Empty + BMAEINMDAFF;
					}
					string text7 = text;
					string[] array5 = new string[]
					{
						null,
						text7
					};
					array5[0] = ((text.Length <= 1) ? string.Empty : "[ItemsHandler] Inventory not changed");
					array5[6] = text4;
					array5[2] = "SetEnvSpriteColor";
					array5[8] = text6;
					text = string.Concat(array5);
				}
				this.votes = text;
			}
			else
			{
				object[] array6 = new object[3];
				array6[0] = this.MIDAMGAGFIA();
				array6[0] = "2hands";
				array6[3] = BMAEINMDAFF;
				array6[2] = "_Value2";
				array6[1] = SteamUser.GetSteamID().m_SteamID;
				this.AIAJMCKBLKI(string.Concat(array6));
			}
			Singleton<RanksSystem>.Instance.ILMJPBGLAGI(this.IHGAFOAMKAD(), BMAEINMDAFF);
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong KIHKKAFMDMF()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E6BC RID: 59068 RVA: 0x00516F30 File Offset: 0x00515130
		public void POPAHCMKOHP(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6BE RID: 59070 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string LKGIPBNFPEL()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6BF RID: 59071 RVA: 0x005182C4 File Offset: 0x005164C4
		public int KHMMMHMDFNF()
		{
			int result = 0;
			try
			{
				string text = this.MIDAMGAGFIA();
				char[] array = new char[1];
				array[1] = '\u0002';
				string[] array2 = text.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text2 = array3[i];
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text3 = text2;
					char[] array4 = new char[1];
					array4[1] = '\u0016';
					if (steamID == ulong.Parse(text3.Split(array4)[1]))
					{
						string text4 = text2;
						char[] array5 = new char[0];
						array5[0] = (char)-86;
						result = int.Parse(text4.Split(array5)[0]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E6C0 RID: 59072 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void OKJFBOFMGMO(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6C1 RID: 59073 RVA: 0x00517954 File Offset: 0x00515B54
		public void CJFBKKPFFMI(string DPNHODJHGJL)
		{
			this.<MMJCIPEEEEG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6C2 RID: 59074 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void KFNAMIGJCLM(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6C3 RID: 59075 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void KFGKIMOAGJD(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6C4 RID: 59076 RVA: 0x0051836C File Offset: 0x0051656C
		public int EPHHAGCNLNF()
		{
			int num = 0;
			try
			{
				string text = this.MIDAMGAGFIA();
				char[] array = new char[1];
				array[1] = 'E';
				string[] array2 = text.Split(array);
				foreach (string text2 in array2)
				{
					int num2 = num;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[0] = (char)-108;
					num = num2 + int.Parse(text3.Split(array4)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E6C5 RID: 59077 RVA: 0x005183E8 File Offset: 0x005165E8
		public int CMIDMJKBAGJ()
		{
			int result = 0;
			try
			{
				string[] array = this.FJICLFAAFNM().Split(new char[]
				{
					'0'
				});
				string[] array2 = array;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string text = array2[i];
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text2 = text;
					char[] array3 = new char[1];
					array3[1] = 'N';
					if (steamID == ulong.Parse(text2.Split(array3)[0]))
					{
						string text3 = text;
						char[] array4 = new char[0];
						array4[1] = (char)-47;
						result = int.Parse(text3.Split(array4)[1]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E6C6 RID: 59078 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string HOHOAOGHFDO()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}

		// Token: 0x0600E6C7 RID: 59079 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void NGAPNJIANCP(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6C8 RID: 59080 RVA: 0x00518490 File Offset: 0x00516690
		public void JGIJADECLGB(int BMAEINMDAFF)
		{
			if (this.IPLNCBFBGFJ() != 0)
			{
				string text = string.Empty;
				string text2 = this.FJICLFAAFNM();
				char[] array = new char[0];
				array[1] = (char)-106;
				string[] array2 = text2.Split(array);
				string[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					string text3 = array3[i];
					string text4 = text3;
					char[] array4 = new char[0];
					array4[1] = (char)-74;
					string text5 = text4.Split(array4)[0];
					string text6 = text3;
					char[] array5 = new char[0];
					array5[1] = '3';
					string text7 = text6.Split(array5)[0];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text7))
					{
						text5 = string.Empty + BMAEINMDAFF;
					}
					string text8 = text;
					string[] array6 = new string[0];
					array6[1] = text8;
					array6[0] = ((text.Length <= 0) ? string.Empty : "ViewID {0} {1}{2}");
					array6[6] = text5;
					array6[5] = "_Value";
					array6[0] = text7;
					text = string.Concat(array6);
				}
				this.MHKPAIMLJHH(text);
			}
			else
			{
				object[] array7 = new object[0];
				array7[1] = this.BFIJMABPKOF();
				array7[0] = "BitsData";
				array7[4] = BMAEINMDAFF;
				array7[7] = "_TimeX";
				array7[8] = SteamUser.GetSteamID().m_SteamID;
				this.PDGNODHEFOF(string.Concat(array7));
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(this.PHCHLPBPKHL(), BMAEINMDAFF);
		}

		// Token: 0x0600E6C9 RID: 59081 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong LPEKOHPMKCE()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E6CA RID: 59082 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong PHCHLPBPKHL()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E6CB RID: 59083 RVA: 0x00516D69 File Offset: 0x00514F69
		public ulong DBCMHPJIHGG()
		{
			return this.<CFJPIFLLIPH>k__BackingField;
		}

		// Token: 0x0600E6CC RID: 59084 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string MOMHHCGBDJK()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6CD RID: 59085 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string CKGFBNMMPMC()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6CE RID: 59086 RVA: 0x00516F30 File Offset: 0x00515130
		public void EJDKCELGOFG(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6CF RID: 59087 RVA: 0x00516F30 File Offset: 0x00515130
		public void LJMEJHIHPGI(ulong DPNHODJHGJL)
		{
			this.<EACCOCFNPIG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6D0 RID: 59088 RVA: 0x00516EA0 File Offset: 0x005150A0
		public void LJELNGLNFHM(string DPNHODJHGJL)
		{
			this.<KNKMBLBALJN>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6D1 RID: 59089 RVA: 0x00516DF0 File Offset: 0x00514FF0
		public string POJIOBLCHPI()
		{
			return this.<MMJCIPEEEEG>k__BackingField;
		}

		// Token: 0x0600E6D2 RID: 59090 RVA: 0x00516FC0 File Offset: 0x005151C0
		public void OGHFEGGAGBK(ulong DPNHODJHGJL)
		{
			this.<CFJPIFLLIPH>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6D5 RID: 59093 RVA: 0x00516F39 File Offset: 0x00515139
		public ulong DFKBFAHDLJE()
		{
			return this.<EACCOCFNPIG>k__BackingField;
		}

		// Token: 0x0600E6D6 RID: 59094 RVA: 0x005185E4 File Offset: 0x005167E4
		public int IPLNCBFBGFJ()
		{
			int result = 0;
			try
			{
				string text = this.FHMMOHLGLOL();
				char[] array = new char[1];
				array[1] = (char)-77;
				string[] array2 = text.Split(array);
				foreach (string text2 in array2)
				{
					ulong steamID = SteamUser.GetSteamID().m_SteamID;
					string text3 = text2;
					char[] array4 = new char[0];
					array4[1] = (char)-90;
					if (steamID == ulong.Parse(text3.Split(array4)[1]))
					{
						result = int.Parse(text2.Split(new char[]
						{
							'\b'
						})[0]);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600E6D7 RID: 59095 RVA: 0x0051868C File Offset: 0x0051688C
		public void SetUserVote(int BMAEINMDAFF)
		{
			if (this.GetUserVote() != 0)
			{
				string text = string.Empty;
				string[] array = this.votes.Split(new char[]
				{
					';'
				});
				foreach (string text2 in array)
				{
					string text3 = text2.Split(new char[]
					{
						'|'
					})[0];
					string text4 = text2.Split(new char[]
					{
						'|'
					})[1];
					if (SteamUser.GetSteamID().m_SteamID == ulong.Parse(text4))
					{
						text3 = string.Empty + BMAEINMDAFF;
					}
					string text5 = text;
					text = string.Concat(new string[]
					{
						text5,
						(text.Length <= 0) ? string.Empty : ";",
						text3,
						"|",
						text4
					});
				}
				this.votes = text;
			}
			else
			{
				this.votes = string.Concat(new object[]
				{
					this.votes,
					";",
					BMAEINMDAFF,
					"|",
					SteamUser.GetSteamID().m_SteamID
				});
			}
			Singleton<RanksSystem>.Instance.SubmitUserVote(this.id, BMAEINMDAFF);
		}

		// Token: 0x0600E6D8 RID: 59096 RVA: 0x005187E0 File Offset: 0x005169E0
		public int KBIEDPCEHGG()
		{
			int num = 1;
			try
			{
				string[] array = this.NJKPMJKDOMK().Split(new char[]
				{
					(char)-117
				});
				string[] array2 = array;
				for (int i = 1; i < array2.Length; i += 0)
				{
					string text = array2[i];
					int num2 = num;
					string text2 = text;
					char[] array3 = new char[1];
					array3[1] = (char)-44;
					num = num2 + int.Parse(text2.Split(array3)[1]);
				}
			}
			catch (Exception)
			{
			}
			return num;
		}

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string CNIIOBIAONN()
		{
			return this.<DMAKNKNPHFO>k__BackingField;
		}
	}

	// Token: 0x020003F6 RID: 1014
	public class PlayerServerData
	{
		// Token: 0x0600E6DB RID: 59099 RVA: 0x0051885C File Offset: 0x00516A5C
		public void EOBMHGEIEBA(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6DC RID: 59100 RVA: 0x00518865 File Offset: 0x00516A65
		public string AIGEAHLELBA()
		{
			return this.<NHDAELAGOIA>k__BackingField;
		}

		// Token: 0x0600E6DD RID: 59101 RVA: 0x0051885C File Offset: 0x00516A5C
		public void IFFBIJPAAHN(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6DE RID: 59102 RVA: 0x0051886D File Offset: 0x00516A6D
		public List<Challenge> BGLCJNOBNKD()
		{
			return this.<NCHDNCHHMDE>k__BackingField;
		}

		// Token: 0x0600E6DF RID: 59103 RVA: 0x0051885C File Offset: 0x00516A5C
		public void MAEIHICNGIN(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6E0 RID: 59104 RVA: 0x00518865 File Offset: 0x00516A65
		public string HANHDJIECKM()
		{
			return this.<NHDAELAGOIA>k__BackingField;
		}

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x0051886D File Offset: 0x00516A6D
		public List<Challenge> ENBDNHKPBNP()
		{
			return this.<NCHDNCHHMDE>k__BackingField;
		}

		// Token: 0x0600E6E2 RID: 59106 RVA: 0x00518865 File Offset: 0x00516A65
		public string POJMJIJJHEO()
		{
			return this.<NHDAELAGOIA>k__BackingField;
		}

		// Token: 0x0600E6E3 RID: 59107 RVA: 0x00518875 File Offset: 0x00516A75
		public void CHIKIOKECNH(List<Challenge> DPNHODJHGJL)
		{
			this.<NCHDNCHHMDE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6E4 RID: 59108 RVA: 0x00518865 File Offset: 0x00516A65
		public string AJKNCCPNEDL()
		{
			return this.<NHDAELAGOIA>k__BackingField;
		}

		// Token: 0x0600E6E5 RID: 59109 RVA: 0x00518875 File Offset: 0x00516A75
		public void KKGHHLLHPPN(List<Challenge> DPNHODJHGJL)
		{
			this.<NCHDNCHHMDE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6E6 RID: 59110 RVA: 0x0051886D File Offset: 0x00516A6D
		public List<Challenge> BILBPKBMBBI()
		{
			return this.<NCHDNCHHMDE>k__BackingField;
		}

		// Token: 0x0600E6E7 RID: 59111 RVA: 0x00518875 File Offset: 0x00516A75
		public void EAJKLIPKJLE(List<Challenge> DPNHODJHGJL)
		{
			this.<NCHDNCHHMDE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x0051886D File Offset: 0x00516A6D
		public List<Challenge> ONBAJFKPBEN()
		{
			return this.<NCHDNCHHMDE>k__BackingField;
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600E6EA RID: 59114 RVA: 0x00518865 File Offset: 0x00516A65
		// (set) Token: 0x0600E6F8 RID: 59128 RVA: 0x0051885C File Offset: 0x00516A5C
		public string bgURL { get; set; }

		// Token: 0x0600E6EB RID: 59115 RVA: 0x0051885C File Offset: 0x00516A5C
		public void PMNOIBHECAE(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6EC RID: 59116 RVA: 0x00518865 File Offset: 0x00516A65
		public string NLOBGCLIMED()
		{
			return this.<NHDAELAGOIA>k__BackingField;
		}

		// Token: 0x0600E6ED RID: 59117 RVA: 0x00518875 File Offset: 0x00516A75
		public void IFHOCAJGECA(List<Challenge> DPNHODJHGJL)
		{
			this.<NCHDNCHHMDE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600E6EE RID: 59118 RVA: 0x0051886D File Offset: 0x00516A6D
		// (set) Token: 0x0600E6F6 RID: 59126 RVA: 0x00518875 File Offset: 0x00516A75
		public List<Challenge> activeChallenges { get; set; }

		// Token: 0x0600E6EF RID: 59119 RVA: 0x0051886D File Offset: 0x00516A6D
		public List<Challenge> CAFNLIMAJMD()
		{
			return this.<NCHDNCHHMDE>k__BackingField;
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x0051885C File Offset: 0x00516A5C
		public void DIDELGKFHGB(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6F1 RID: 59121 RVA: 0x00518865 File Offset: 0x00516A65
		public string PKJCIMBJODL()
		{
			return this.<NHDAELAGOIA>k__BackingField;
		}

		// Token: 0x0600E6F2 RID: 59122 RVA: 0x0051885C File Offset: 0x00516A5C
		public void IFCMOCAIGFH(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6F3 RID: 59123 RVA: 0x00518875 File Offset: 0x00516A75
		public void HIHBNECEAHC(List<Challenge> DPNHODJHGJL)
		{
			this.<NCHDNCHHMDE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6F4 RID: 59124 RVA: 0x0051885C File Offset: 0x00516A5C
		public void JMGAMCAIDDG(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6F5 RID: 59125 RVA: 0x0051885C File Offset: 0x00516A5C
		public void BBBAOAAHICE(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6F7 RID: 59127 RVA: 0x0051885C File Offset: 0x00516A5C
		public void PIJOAIEPJPI(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6F9 RID: 59129 RVA: 0x0051885C File Offset: 0x00516A5C
		public void DHOFLGHAAIH(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6FA RID: 59130 RVA: 0x0051886D File Offset: 0x00516A6D
		public List<Challenge> BKFELAKDMKF()
		{
			return this.<NCHDNCHHMDE>k__BackingField;
		}

		// Token: 0x0600E6FB RID: 59131 RVA: 0x0051885C File Offset: 0x00516A5C
		public void CPNCEPBJLLF(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6FC RID: 59132 RVA: 0x0051885C File Offset: 0x00516A5C
		public void MFALGEOCLED(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E6FD RID: 59133 RVA: 0x0051885C File Offset: 0x00516A5C
		public void IJMHCOHAOFF(string DPNHODJHGJL)
		{
			this.<NHDAELAGOIA>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003F7 RID: 1015
	public class ServerDataJson
	{
		// Token: 0x0600E6FE RID: 59134 RVA: 0x0051887E File Offset: 0x00516A7E
		public RanksSystem.BanListJson MOCAJHGFOEH()
		{
			return this.<FGIOJMFIIBO>k__BackingField;
		}

		// Token: 0x0600E6FF RID: 59135 RVA: 0x00518886 File Offset: 0x00516A86
		public void KPOODIINKII(RanksSystem.BanListJson DPNHODJHGJL)
		{
			this.<FGIOJMFIIBO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600E71F RID: 59167 RVA: 0x005188D4 File Offset: 0x00516AD4
		// (set) Token: 0x0600E700 RID: 59136 RVA: 0x0051888F File Offset: 0x00516A8F
		public RanksSystem.PlayersTipsJson playersTips { get; set; }

		// Token: 0x0600E701 RID: 59137 RVA: 0x00518886 File Offset: 0x00516A86
		public void OIEFGAIDCPD(RanksSystem.BanListJson DPNHODJHGJL)
		{
			this.<FGIOJMFIIBO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E702 RID: 59138 RVA: 0x00518898 File Offset: 0x00516A98
		public RanksSystem.MapsListJson EBKEHMMONMH()
		{
			return this.<AODPKEOADIP>k__BackingField;
		}

		// Token: 0x0600E703 RID: 59139 RVA: 0x00518898 File Offset: 0x00516A98
		public RanksSystem.MapsListJson DGIEFGKLFLD()
		{
			return this.<AODPKEOADIP>k__BackingField;
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x00518898 File Offset: 0x00516A98
		public RanksSystem.MapsListJson LOHMDECDBNF()
		{
			return this.<AODPKEOADIP>k__BackingField;
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x005188A0 File Offset: 0x00516AA0
		public void OKGKMFOGIJO(RanksSystem.FastRanksJson DPNHODJHGJL)
		{
			this.<OBHCFKCBFIE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x005188A9 File Offset: 0x00516AA9
		public void CEIEIHDIFJL(RanksSystem.TeamJson DPNHODJHGJL)
		{
			this.<MHLNPPIHHAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600E71C RID: 59164 RVA: 0x005188CC File Offset: 0x00516ACC
		// (set) Token: 0x0600E707 RID: 59143 RVA: 0x005188B2 File Offset: 0x00516AB2
		public RanksSystem.PlayerServerData playerServerData { get; set; }

		// Token: 0x0600E708 RID: 59144 RVA: 0x00518886 File Offset: 0x00516A86
		public void FCDKNMBOHFP(RanksSystem.BanListJson DPNHODJHGJL)
		{
			this.<FGIOJMFIIBO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600E717 RID: 59159 RVA: 0x0051887E File Offset: 0x00516A7E
		// (set) Token: 0x0600E709 RID: 59145 RVA: 0x00518886 File Offset: 0x00516A86
		public RanksSystem.BanListJson banList { get; set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600E745 RID: 59205 RVA: 0x00518898 File Offset: 0x00516A98
		// (set) Token: 0x0600E70A RID: 59146 RVA: 0x005188BB File Offset: 0x00516ABB
		public RanksSystem.MapsListJson mapsList { get; set; }

		// Token: 0x0600E70B RID: 59147 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson DKHPAENCMFH()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E70C RID: 59148 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson LCIEOKPKPKH()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E70D RID: 59149 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void HCCCCBALHNG(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E70E RID: 59150 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson FLPBOBHLFEN()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E70F RID: 59151 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void CINOJOMNAPN(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E710 RID: 59152 RVA: 0x005188A0 File Offset: 0x00516AA0
		public void LDADCMFPINM(RanksSystem.FastRanksJson DPNHODJHGJL)
		{
			this.<OBHCFKCBFIE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E711 RID: 59153 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData MPMAENGEPOJ()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E712 RID: 59154 RVA: 0x00518898 File Offset: 0x00516A98
		public RanksSystem.MapsListJson FEJJMBCIENK()
		{
			return this.<AODPKEOADIP>k__BackingField;
		}

		// Token: 0x0600E713 RID: 59155 RVA: 0x005188D4 File Offset: 0x00516AD4
		public RanksSystem.PlayersTipsJson ECGLNCJGAID()
		{
			return this.<DIFDJNONGGL>k__BackingField;
		}

		// Token: 0x0600E714 RID: 59156 RVA: 0x0051888F File Offset: 0x00516A8F
		public void INOBAGADIPK(RanksSystem.PlayersTipsJson DPNHODJHGJL)
		{
			this.<DIFDJNONGGL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E715 RID: 59157 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void LKMIECNCHCC(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E716 RID: 59158 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData HECDOOJEOJI()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson BHDJOLPNCNK()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson EAIDOBONKFP()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void IPPKGHJGJKN(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x005188BB File Offset: 0x00516ABB
		public void MLFKAMAFGPP(RanksSystem.MapsListJson DPNHODJHGJL)
		{
			this.<AODPKEOADIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E71D RID: 59165 RVA: 0x005188A0 File Offset: 0x00516AA0
		public void DNELOPFFEMF(RanksSystem.FastRanksJson DPNHODJHGJL)
		{
			this.<OBHCFKCBFIE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E71E RID: 59166 RVA: 0x005188A0 File Offset: 0x00516AA0
		public void DKCPAIOBEDP(RanksSystem.FastRanksJson DPNHODJHGJL)
		{
			this.<OBHCFKCBFIE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E720 RID: 59168 RVA: 0x0051888F File Offset: 0x00516A8F
		public void NHJCKPGKPOM(RanksSystem.PlayersTipsJson DPNHODJHGJL)
		{
			this.<DIFDJNONGGL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E721 RID: 59169 RVA: 0x00518898 File Offset: 0x00516A98
		public RanksSystem.MapsListJson HMDKBJCAINK()
		{
			return this.<AODPKEOADIP>k__BackingField;
		}

		// Token: 0x0600E722 RID: 59170 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData BLAFJKNGHDE()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E723 RID: 59171 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void KMHKIBNDJOH(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x0600E724 RID: 59172 RVA: 0x005188DC File Offset: 0x00516ADC
		// (set) Token: 0x0600E751 RID: 59217 RVA: 0x005188A0 File Offset: 0x00516AA0
		public RanksSystem.FastRanksJson playerRanksTable { get; set; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600E725 RID: 59173 RVA: 0x005188C4 File Offset: 0x00516AC4
		// (set) Token: 0x0600E734 RID: 59188 RVA: 0x005188A9 File Offset: 0x00516AA9
		public RanksSystem.TeamJson teamTable { get; set; }

		// Token: 0x0600E726 RID: 59174 RVA: 0x005188A9 File Offset: 0x00516AA9
		public void FCCKGHCDELE(RanksSystem.TeamJson DPNHODJHGJL)
		{
			this.<MHLNPPIHHAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E727 RID: 59175 RVA: 0x005188D4 File Offset: 0x00516AD4
		public RanksSystem.PlayersTipsJson JMMCIIMNCIN()
		{
			return this.<DIFDJNONGGL>k__BackingField;
		}

		// Token: 0x0600E728 RID: 59176 RVA: 0x00518886 File Offset: 0x00516A86
		public void HHHIKAJLGJF(RanksSystem.BanListJson DPNHODJHGJL)
		{
			this.<FGIOJMFIIBO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E729 RID: 59177 RVA: 0x005188BB File Offset: 0x00516ABB
		public void BFGIJGLPIOA(RanksSystem.MapsListJson DPNHODJHGJL)
		{
			this.<AODPKEOADIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E72A RID: 59178 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson JGPFNEGDBDH()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E72B RID: 59179 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void HPPPFGHGBAO(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E72C RID: 59180 RVA: 0x0051887E File Offset: 0x00516A7E
		public RanksSystem.BanListJson ODCMAFLNADL()
		{
			return this.<FGIOJMFIIBO>k__BackingField;
		}

		// Token: 0x0600E72D RID: 59181 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData HMBMHBFIEBE()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x0051888F File Offset: 0x00516A8F
		public void DFKHDPGCEFD(RanksSystem.PlayersTipsJson DPNHODJHGJL)
		{
			this.<DIFDJNONGGL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E72F RID: 59183 RVA: 0x0051887E File Offset: 0x00516A7E
		public RanksSystem.BanListJson KPBNNABNFHA()
		{
			return this.<FGIOJMFIIBO>k__BackingField;
		}

		// Token: 0x0600E730 RID: 59184 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void NINBMGBLMLF(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x005188BB File Offset: 0x00516ABB
		public void EAEHADJOEMH(RanksSystem.MapsListJson DPNHODJHGJL)
		{
			this.<AODPKEOADIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x005188D4 File Offset: 0x00516AD4
		public RanksSystem.PlayersTipsJson EDOGFAPCLPM()
		{
			return this.<DIFDJNONGGL>k__BackingField;
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson MEJAOJLMNKF()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E735 RID: 59189 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData PDHLBLFODON()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x0051888F File Offset: 0x00516A8F
		public void ONNIFJAMAFG(RanksSystem.PlayersTipsJson DPNHODJHGJL)
		{
			this.<DIFDJNONGGL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E737 RID: 59191 RVA: 0x005188A0 File Offset: 0x00516AA0
		public void DNOPHHLMFDA(RanksSystem.FastRanksJson DPNHODJHGJL)
		{
			this.<OBHCFKCBFIE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E738 RID: 59192 RVA: 0x005188A0 File Offset: 0x00516AA0
		public void PKLIDLIKAOB(RanksSystem.FastRanksJson DPNHODJHGJL)
		{
			this.<OBHCFKCBFIE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E739 RID: 59193 RVA: 0x005188A9 File Offset: 0x00516AA9
		public void DHHFKDAPGAB(RanksSystem.TeamJson DPNHODJHGJL)
		{
			this.<MHLNPPIHHAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E73A RID: 59194 RVA: 0x00518886 File Offset: 0x00516A86
		public void HBDHGMPAOJL(RanksSystem.BanListJson DPNHODJHGJL)
		{
			this.<FGIOJMFIIBO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E73B RID: 59195 RVA: 0x005188A0 File Offset: 0x00516AA0
		public void MMHNKEMBIBK(RanksSystem.FastRanksJson DPNHODJHGJL)
		{
			this.<OBHCFKCBFIE>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E73C RID: 59196 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData OPGANDHGOCM()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E73D RID: 59197 RVA: 0x005188BB File Offset: 0x00516ABB
		public void CEDEKCDGKEB(RanksSystem.MapsListJson DPNHODJHGJL)
		{
			this.<AODPKEOADIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E73E RID: 59198 RVA: 0x005188A9 File Offset: 0x00516AA9
		public void LLALBGGOFNK(RanksSystem.TeamJson DPNHODJHGJL)
		{
			this.<MHLNPPIHHAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E73F RID: 59199 RVA: 0x005188BB File Offset: 0x00516ABB
		public void IEGFFOMJGNA(RanksSystem.MapsListJson DPNHODJHGJL)
		{
			this.<AODPKEOADIP>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E740 RID: 59200 RVA: 0x00518898 File Offset: 0x00516A98
		public RanksSystem.MapsListJson EIBJDBDPOJC()
		{
			return this.<AODPKEOADIP>k__BackingField;
		}

		// Token: 0x0600E741 RID: 59201 RVA: 0x0051888F File Offset: 0x00516A8F
		public void GBIPCEHCLFG(RanksSystem.PlayersTipsJson DPNHODJHGJL)
		{
			this.<DIFDJNONGGL>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E742 RID: 59202 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData KEKBOMFPMBA()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E743 RID: 59203 RVA: 0x00518886 File Offset: 0x00516A86
		public void KEKIEKPPMHJ(RanksSystem.BanListJson DPNHODJHGJL)
		{
			this.<FGIOJMFIIBO>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E744 RID: 59204 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData ADNDGOJPIGC()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void EONKPHPOKFL(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E747 RID: 59207 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson JOBJNLEPHBE()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E748 RID: 59208 RVA: 0x005188B2 File Offset: 0x00516AB2
		public void IHDIGEDPPBP(RanksSystem.PlayerServerData DPNHODJHGJL)
		{
			this.<OPDMJCEPHBM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E749 RID: 59209 RVA: 0x005188CC File Offset: 0x00516ACC
		public RanksSystem.PlayerServerData KIHIEKLEMMI()
		{
			return this.<OPDMJCEPHBM>k__BackingField;
		}

		// Token: 0x0600E74A RID: 59210 RVA: 0x005188D4 File Offset: 0x00516AD4
		public RanksSystem.PlayersTipsJson ELDLJMBHGAN()
		{
			return this.<DIFDJNONGGL>k__BackingField;
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x005188C4 File Offset: 0x00516AC4
		public RanksSystem.TeamJson HNENIDFABLJ()
		{
			return this.<MHLNPPIHHAM>k__BackingField;
		}

		// Token: 0x0600E74C RID: 59212 RVA: 0x0051887E File Offset: 0x00516A7E
		public RanksSystem.BanListJson MBMELLBNGOE()
		{
			return this.<FGIOJMFIIBO>k__BackingField;
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x0051887E File Offset: 0x00516A7E
		public RanksSystem.BanListJson DDCHAKMKDEP()
		{
			return this.<FGIOJMFIIBO>k__BackingField;
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x00518898 File Offset: 0x00516A98
		public RanksSystem.MapsListJson IPKHDLGKPPM()
		{
			return this.<AODPKEOADIP>k__BackingField;
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x005188A9 File Offset: 0x00516AA9
		public void BCIGCHHFJNO(RanksSystem.TeamJson DPNHODJHGJL)
		{
			this.<MHLNPPIHHAM>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600E752 RID: 59218 RVA: 0x005188BB File Offset: 0x00516ABB
		public void FAOHJAAIJKH(RanksSystem.MapsListJson DPNHODJHGJL)
		{
			this.<AODPKEOADIP>k__BackingField = DPNHODJHGJL;
		}
	}

	// Token: 0x020003F8 RID: 1016
	[CompilerGenerated]
	private sealed class EGNLMILBMMC
	{
		// Token: 0x0600E753 RID: 59219 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool CPGJCCBMBBF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool BJMAIJDIKCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E755 RID: 59221 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool IFHICADFDCE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E756 RID: 59222 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool AHBIANHNBBC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E757 RID: 59223 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E758 RID: 59224 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool EAPKJLONHBG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool MACILKHEBEF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E75A RID: 59226 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool HNOIFOOJMCC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E75B RID: 59227 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool MMKHFOFJKNI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E75C RID: 59228 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool JBIMMGGGMPB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E75D RID: 59229 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool EKHOOPGPPGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E75E RID: 59230 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool BCDAGGDDADL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E75F RID: 59231 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool LDNDNOOCFFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E760 RID: 59232 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool KMIAINALJFJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E761 RID: 59233 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool LHONOMOAHJD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E762 RID: 59234 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool HCFLGKJFKFE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E763 RID: 59235 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool AGJKEBOPIOC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E764 RID: 59236 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool PLEFJLBGDOJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E765 RID: 59237 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool JDELIMPGFDJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E766 RID: 59238 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool BHMNMHFDPLN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E767 RID: 59239 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool PKJCCIGEACE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E768 RID: 59240 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool MPGGBMMPNDH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E769 RID: 59241 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool PHDFIAGENEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E76A RID: 59242 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool GBFDHKGDDPO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E76B RID: 59243 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E76C RID: 59244 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool JBAJEMGOPDL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E76D RID: 59245 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool BOPKCHEPEEB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E76E RID: 59246 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool FHAMDNDPKBA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E76F RID: 59247 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool CBKBFHDKJEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E770 RID: 59248 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool HGOHMNAGGKI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E771 RID: 59249 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool GNPPNNLJLMP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E772 RID: 59250 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool AEIFJLBBKBP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E773 RID: 59251 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool IACBEPMAJPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E774 RID: 59252 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool FLKOOOGMBFJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E775 RID: 59253 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool AHHNAGGBKOO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E776 RID: 59254 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool PHJAIEAAMPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E777 RID: 59255 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool HEPDDMCNEKD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E778 RID: 59256 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool DMFFNNFKEAA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E779 RID: 59257 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool ONEPCCGOEKI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E77A RID: 59258 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool LLPCCJGMEIE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E77B RID: 59259 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool INHOEMCLAAP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E77C RID: 59260 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool PHGILLBNBME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E77D RID: 59261 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool LNHHFDKFLAA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E77E RID: 59262 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool HMMBBDJNGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E77F RID: 59263 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool KFNBKFELFLH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E780 RID: 59264 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool MFBMMDCIPGG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E781 RID: 59265 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool PODLCOEIIGA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E782 RID: 59266 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool GBIHGLCGNCM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E783 RID: 59267 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E784 RID: 59268 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool IIFJOGHFCGK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E785 RID: 59269 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool DMKALNCPIAJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E786 RID: 59270 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool LMNCLJKEIFD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E787 RID: 59271 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool OJFHDDECJKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E788 RID: 59272 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool HBJOAAJMDDE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E789 RID: 59273 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool JJPOFCGCKJF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E78A RID: 59274 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool BOJCHGIGGNK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E78B RID: 59275 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool FIPCLHEKKCA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E78C RID: 59276 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool BLGDLGLNCHE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E78D RID: 59277 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool CMBLCKNFNIF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E78E RID: 59278 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool OAKGNJNMBFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E78F RID: 59279 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool EDNIIDHFIJH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E790 RID: 59280 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool DPFLLMAOIHH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E791 RID: 59281 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool PDNFNOLBNIF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E792 RID: 59282 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool CDJJGFHFMBL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool PCDFLCEIHFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E794 RID: 59284 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E795 RID: 59285 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool OPNIKCBNOIF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E796 RID: 59286 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool MBOCPCMMJDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E797 RID: 59287 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool NEIDGMKKCBI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E798 RID: 59288 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool BAKPHDMIHFE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E799 RID: 59289 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool OHMLDGGHGIL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E79A RID: 59290 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool EFAPFFFGOOA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E79B RID: 59291 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool LCAIGLPKJAF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E79C RID: 59292 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool PMEFBOOIAKK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E79D RID: 59293 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool PMPBFHNELAJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E79E RID: 59294 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool INFIHILKMBK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E79F RID: 59295 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool MJBBOHLIILO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A0 RID: 59296 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool FPONLDMBLPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A1 RID: 59297 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool CEFNPJBKLDM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A2 RID: 59298 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool IJINAAGMHKM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A3 RID: 59299 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool EEBODGOFEGB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A4 RID: 59300 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool LBNMAMJDFLG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A5 RID: 59301 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool BLEKGEPJBFN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A6 RID: 59302 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool HDJPOBPGKAK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A7 RID: 59303 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool ILADLNPPGAO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool PLINPGHDODA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool BEFJFFLBLCE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7AA RID: 59306 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool BJCNLIJFEKF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool LKFKDAEBCPN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool MJCLCLJEOIF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7AD RID: 59309 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool DAJMIEHCEMJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7AE RID: 59310 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool BKNHHGBPLGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7AF RID: 59311 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool KFGCBAHGDNK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B0 RID: 59312 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool KGKMOLCPDIH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B1 RID: 59313 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool KKCGGMGGFLC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B2 RID: 59314 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool DOBBJPPAEBB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B3 RID: 59315 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool CANILAHOIGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B4 RID: 59316 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool LKLABDAJAEH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B5 RID: 59317 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool GCLCICMFCPK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B6 RID: 59318 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool CCLAJACDMHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B7 RID: 59319 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool NCGABJOKHGO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B8 RID: 59320 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool INALCBKJMHI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7B9 RID: 59321 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool AAPNNKGJEOG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7BA RID: 59322 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool GEPBCIIDMBC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7BB RID: 59323 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool NHPDJEKEOKI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7BC RID: 59324 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool ILCENHENOKK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7BD RID: 59325 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool EIJKHJOCCAE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E7BE RID: 59326 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool EIKNHEAEHJC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7BF RID: 59327 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool CCJEFHIHEID(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool MPOCBBDLGMP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C1 RID: 59329 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool NDGKBJEKAPJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C2 RID: 59330 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool LADECCOJPPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool KFNPHCCAJFD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool AGFDCBCBAGI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C5 RID: 59333 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool NFMMONDLJCC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C6 RID: 59334 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool PGJLKLKAADB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C7 RID: 59335 RVA: 0x005188F4 File Offset: 0x00516AF4
		internal bool DBHMMIKIBIO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C8 RID: 59336 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool BPJGFELFEDC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7C9 RID: 59337 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool DFPLMEODJAM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7CA RID: 59338 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool JPICHJKIMDH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7CB RID: 59339 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool LJDLIIIPIIJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7CC RID: 59340 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7CD RID: 59341 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool DGFFNMKBANM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7CE RID: 59342 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool HAHHLEACNIL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E7CF RID: 59343 RVA: 0x005188E4 File Offset: 0x00516AE4
		internal bool EBEGBCEJBFI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D0 RID: 59344 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool PMKGJLKNBJB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D1 RID: 59345 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool OLIGLEMPFOP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D2 RID: 59346 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D3 RID: 59347 RVA: 0x00518914 File Offset: 0x00516B14
		internal bool MOJCLHBKMHF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D4 RID: 59348 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool OODLIEKJILO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D5 RID: 59349 RVA: 0x00518934 File Offset: 0x00516B34
		internal bool ACLHMMEEIDA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D6 RID: 59350 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool MJBOKIODLFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D7 RID: 59351 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool BDGDIDPDBHG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7D9 RID: 59353 RVA: 0x00518904 File Offset: 0x00516B04
		internal bool DBOEBFFAOFJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7DA RID: 59354 RVA: 0x00518924 File Offset: 0x00516B24
		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == this.JMMILEFMACB;
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x00518944 File Offset: 0x00516B44
		internal bool JGEDLMKBGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == this.JMMILEFMACB;
		}

		// Token: 0x04001A03 RID: 6659
		internal ulong JMMILEFMACB;
	}

	// Token: 0x020003F9 RID: 1017
	[CompilerGenerated]
	private sealed class OFIPPJELEIA
	{
		// Token: 0x0600E7DC RID: 59356 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool DKGPCPBNDPK(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7DD RID: 59357 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool BFEABMIFIEE(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool LNDGINDKPFA(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7DF RID: 59359 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool BKNHHGBPLGH(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool EGKGJJGAPMN(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool BDGDIDPDBHG(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool PBCAHKDLFPE(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E3 RID: 59363 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool FIPCLHEKKCA(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E4 RID: 59364 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool GBKBDKHPLKG(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E5 RID: 59365 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool JDELIMPGFDJ(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E6 RID: 59366 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool OFHCGKJFGDI(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E7 RID: 59367 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool EKHOOPGPPGE(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E8 RID: 59368 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool LHHFJBIAHCN(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool KFNBKFELFLH(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7EA RID: 59370 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool OLIGLEMPFOP(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7EB RID: 59371 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool DBFPGFHEGKA(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7EC RID: 59372 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool JKEDCEOCPJO(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7ED RID: 59373 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool LLNDDFGPOPL(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7EF RID: 59375 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool MEMPOPNAEDN(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7F0 RID: 59376 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool FFEGPHJKMFK(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7F1 RID: 59377 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool LOEAMHGMMPK(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x0600E7F2 RID: 59378 RVA: 0x00518954 File Offset: 0x00516B54
		internal bool AEINPAGJFME(RanksSystem.Ban IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamID == (ulong)this.GDOHPDHLPBC;
		}

		// Token: 0x04001A04 RID: 6660
		internal CSteamID GDOHPDHLPBC;
	}
}
