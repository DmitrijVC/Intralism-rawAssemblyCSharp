using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000419 RID: 1049
public class GameManager : Singleton<GameManager>
{
	// Token: 0x0600F06E RID: 61550 RVA: 0x0053E3EC File Offset: 0x0053C5EC
	public void JGLFJHNLJHI(bool HHJAEKFIJAI = false)
	{
		GameManager.EPMHNKLAGHK(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.KOKDPAEJECC(Helpers.Md5Sum("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost." + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.BHKEFOMJNDF();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	// Token: 0x0600F06F RID: 61551 RVA: 0x0053E454 File Offset: 0x0053C654
	public void AABEGAMPOLA(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F070 RID: 61552 RVA: 0x0053E48A File Offset: 0x0053C68A
	public static byte[] HLHFMCNMBLK(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.CHCMFHMJGDN());
	}

	// Token: 0x0600F071 RID: 61553 RVA: 0x0002523B File Offset: 0x0002343B
	public void PlayerWarnCheats()
	{
	}

	// Token: 0x0600F072 RID: 61554 RVA: 0x0053E498 File Offset: 0x0053C698
	public string HLECGHBHFAL(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		HMACSHA256 hmacsha = new HMACSHA256(asciiencoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hmacsha.ComputeHash(asciiencoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	// Token: 0x0600F073 RID: 61555 RVA: 0x0002523B File Offset: 0x0002343B
	public void KHMKOJFCFNC()
	{
	}

	// Token: 0x0600F074 RID: 61556 RVA: 0x0053E4CC File Offset: 0x0053C6CC
	private void LLLJPFNEGGK()
	{
		this.PCFCBAHKDGF(false);
	}

	// Token: 0x0600F075 RID: 61557 RVA: 0x0053E4D5 File Offset: 0x0053C6D5
	public static byte[] Decrypt(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.GetSecurityKey());
	}

	// Token: 0x0600F076 RID: 61558 RVA: 0x0053E4E4 File Offset: 0x0053C6E4
	public void EPCFIAHKMCP(bool HHJAEKFIJAI = false)
	{
		GameManager.DGMGJJPAEAN(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.ALGKENJGNLL(Helpers.Md5Sum("SetEnvSpriteColor" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.BEMOILHKFAI();
		Singleton<RanksSystem>.Instance.Init();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	// Token: 0x0600F077 RID: 61559 RVA: 0x0053E54B File Offset: 0x0053C74B
	public static byte[] AMEHCGHMOHG(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.MDGOPLBOIHB());
	}

	// Token: 0x0600F078 RID: 61560 RVA: 0x0053E558 File Offset: 0x0053C758
	public static byte[] ALDIJCJEJDK(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.PFOCCIAHOCL());
	}

	// Token: 0x0600F079 RID: 61561 RVA: 0x0053E565 File Offset: 0x0053C765
	private void LLMPBODBKHM()
	{
		this.JGLFJHNLJHI(false);
	}

	// Token: 0x0600F07A RID: 61562 RVA: 0x0053E56E File Offset: 0x0053C76E
	public static byte[] Encrypt(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GameManager.GetSecurityKey());
	}

	// Token: 0x0600F07B RID: 61563 RVA: 0x0053E57C File Offset: 0x0053C77C
	public void UpdateOnlineStatus(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.Instance.UpdatePresence(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.Instance.UpdateJoin(null, null, 0, 0);
		}
		else
		{
			DiscordController.Instance.UpdateJoin(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("status", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("\n" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("connect", NOEBNLFEPCN);
	}

	// Token: 0x0600F07C RID: 61564 RVA: 0x0053E5FC File Offset: 0x0053C7FC
	public static string GetSecurityKey()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	// Token: 0x0600F07D RID: 61565 RVA: 0x0053E608 File Offset: 0x0053C808
	public void GameEvent(GameEventInfo DAGALCAILLN)
	{
		if (this.OKLHDAEHLKC != null)
		{
			this.OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	// Token: 0x0600F07E RID: 61566 RVA: 0x0053E624 File Offset: 0x0053C824
	public void JPPODEABPEH(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F07F RID: 61567 RVA: 0x0053E48A File Offset: 0x0053C68A
	public static byte[] IBOCADBLICL(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.CHCMFHMJGDN());
	}

	// Token: 0x0600F080 RID: 61568 RVA: 0x0053E65A File Offset: 0x0053C85A
	private static void IPGILIBMHEJ(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	// Token: 0x0600F081 RID: 61569 RVA: 0x0053E668 File Offset: 0x0053C868
	public void OnUserVerified(bool HHJAEKFIJAI = false)
	{
		GameManager.IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.Init(Helpers.Md5Sum("Data" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.Init();
		Singleton<LuaEnvironment>.Instance.RunFirstInit();
	}

	// Token: 0x0600F082 RID: 61570 RVA: 0x0053E6CF File Offset: 0x0053C8CF
	private void BNOPFOOHOJM()
	{
		this.GPDPIBOIKAJ();
	}

	// Token: 0x0600F083 RID: 61571 RVA: 0x0053E6D7 File Offset: 0x0053C8D7
	public static string FHOAAADFONG(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GameManager.JKPMEMICFKA());
	}

	// Token: 0x0600F084 RID: 61572 RVA: 0x0053E6F5 File Offset: 0x0053C8F5
	public static string JJNLMGPCNAA(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GameManager.MDGOPLBOIHB());
	}

	// Token: 0x0600F085 RID: 61573 RVA: 0x0053E713 File Offset: 0x0053C913
	public static string JIEFAOAIANN(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GameManager.GetSecurityKey());
	}

	// Token: 0x0600F086 RID: 61574 RVA: 0x0053E734 File Offset: 0x0053C934
	public void GLBKBPODOBK()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban ban in currentPlayerBans)
			{
				if (this.actveBan == null || this.actveBan.bantype < ban.bantype)
				{
					this.actveBan = ban;
				}
				if (ban.bantype < (RanksSystem.Ban.BanType)7)
				{
					if (ban.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Mouse Wheel Up" + ban.id, null))
					{
						if (!this.NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[5];
							array[1] = "roomDescription";
							array[0] = ban.bantype.ToString().ToLower();
							array[8] = "Received RPC: ";
							array[4] = ban.reason;
							array[4] = "Texture3";
							array[1] = ban.bantype.ToString().ToLower();
							array[0] = " - StoreAuthURLResponse] - ";
							instance.JCHNDBKFGFP(string.Concat(array), "Netw. Sim.", null, false, false, 470f);
							this.NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.CMLFCHINKCH(" respawn in future: " + ban.id, true, null);
						}
					}
					else if (!this.NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[5];
						array2[1] = "/";
						array2[0] = ban.bantype.ToString().ToLower();
						array2[1] = "/icon";
						array2[6] = ban.reason;
						array2[3] = "GraphicsQualitySlider";
						array2[6] = ban.bantype.ToString().ToLower();
						array2[1] = "id";
						array2[2] = ((!(ban.until == "[FileSelector] Starting file dialog")) ? ban.until : "_Value4");
						instance2.ANCIONGLJAC(string.Concat(array2), "Clears the console and prints the logs in the specified range", null, true, false, 1072f);
						this.NJCNMDDBJKI = true;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[5];
					array3[0] = "ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).";
					array3[0] = ban.bantype.ToString().ToLower();
					array3[2] = "player.greenlollipop";
					array3[2] = ban.reason;
					array3[3] = "_Value3";
					array3[0] = ban.bantype.ToString().ToLower();
					array3[5] = "12";
					array3[3] = ((!(ban.until == ": ")) ? ban.until : "AudioSampler");
					instance3.JCHNDBKFGFP(string.Concat(array3), "maps.", new UnityAction(this.OAGAGNAOKGG), false, false, 1384f);
				}
			}
		}
		else if (this.actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.AGMKJJLMOHG(": ", "_ScreenResolution", null, false, true, 1186f);
		}
	}

	// Token: 0x0600F087 RID: 61575 RVA: 0x0053EA58 File Offset: 0x0053CC58
	public new void JEEINPBLBDI()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 1; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "_Value")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = (LogType)8;
		}
	}

	// Token: 0x0600F088 RID: 61576 RVA: 0x0053E713 File Offset: 0x0053C913
	public static string OLLCLOPGHGI(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GameManager.GetSecurityKey());
	}

	// Token: 0x0600F089 RID: 61577 RVA: 0x0053EAAC File Offset: 0x0053CCAC
	public void BAMDHECMAHG(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Remove(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F08A RID: 61578 RVA: 0x0053EAE4 File Offset: 0x0053CCE4
	public void JKGJPFOHAFN(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F08B RID: 61579 RVA: 0x0053EB1A File Offset: 0x0053CD1A
	[CompilerGenerated]
	private void CMKMEMANHFF()
	{
		this.ExitGame();
	}

	// Token: 0x0600F08C RID: 61580 RVA: 0x0002523B File Offset: 0x0002343B
	public void GGGDONNAMNG()
	{
	}

	// Token: 0x0600F08D RID: 61581 RVA: 0x0053EB22 File Offset: 0x0053CD22
	public static bool FCKAHHLOMIC()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	// Token: 0x0600F08E RID: 61582 RVA: 0x0053E5FC File Offset: 0x0053C7FC
	public static string JKPMEMICFKA()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	// Token: 0x0600F08F RID: 61583 RVA: 0x0053E608 File Offset: 0x0053C808
	public void CABBFJAGFDP(GameEventInfo DAGALCAILLN)
	{
		if (this.OKLHDAEHLKC != null)
		{
			this.OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	// Token: 0x0600F090 RID: 61584 RVA: 0x0053EB34 File Offset: 0x0053CD34
	public new void CJHMHIMKILB()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "_MatrixSize")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Assert;
		}
	}

	// Token: 0x0600F091 RID: 61585 RVA: 0x0053E5FC File Offset: 0x0053C7FC
	public static string PBCOHBDCOEI()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x0600F0FF RID: 61695 RVA: 0x005406FC File Offset: 0x0053E8FC
	// (remove) Token: 0x0600F092 RID: 61586 RVA: 0x0053EB88 File Offset: 0x0053CD88
	public event GameManager.FinishedMapEvent OnFinishedMap
	{
		add
		{
			GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
			GameManager.FinishedMapEvent finishedMapEvent2;
			do
			{
				finishedMapEvent2 = finishedMapEvent;
				finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Combine(finishedMapEvent2, value), finishedMapEvent);
			}
			while (finishedMapEvent != finishedMapEvent2);
		}
		remove
		{
			GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
			GameManager.FinishedMapEvent finishedMapEvent2;
			do
			{
				finishedMapEvent2 = finishedMapEvent;
				finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Remove(finishedMapEvent2, value), finishedMapEvent);
			}
			while (finishedMapEvent != finishedMapEvent2);
		}
	}

	// Token: 0x0600F093 RID: 61587 RVA: 0x0053E48A File Offset: 0x0053C68A
	public static byte[] EMBCAJFHAMJ(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.CHCMFHMJGDN());
	}

	// Token: 0x0600F094 RID: 61588 RVA: 0x0053EBBE File Offset: 0x0053CDBE
	public int GetCurrentBanLevel()
	{
		return (int)((this.actveBan != null) ? (this.actveBan.bantype + 1) : RanksSystem.Ban.BanType.Warning);
	}

	// Token: 0x0600F095 RID: 61589 RVA: 0x0053EBE0 File Offset: 0x0053CDE0
	public void DCHDMBFIKPI(string EAFAMAMDNEG)
	{
		base.StopAllCoroutines();
		Singleton<Scene>.Instance.ALAJMFBMENK(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.ALHLMBCOILP(EAFAMAMDNEG.ToUpper(), "BitsData".ToUpper(), new UnityAction(this.HDMJFFHCPKE), false, false, 1837f);
	}

	// Token: 0x0600F096 RID: 61590 RVA: 0x0053EC3C File Offset: 0x0053CE3C
	public void POJOGLNKBFI(bool HHJAEKFIJAI = false)
	{
		GameManager.IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.LCKKDMKJJEF(Helpers.Md5Sum("Closes the app" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.PEGGAJELPBJ();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	// Token: 0x0600F097 RID: 61591 RVA: 0x0053ECA4 File Offset: 0x0053CEA4
	public void ONGHMEOMJCM()
	{
		List<RanksSystem.Ban> list = RanksSystem.GOICCEIEJAI(SteamUser.GetSteamID());
		if (list.Count > 0)
		{
			foreach (RanksSystem.Ban ban in list)
			{
				if (this.actveBan == null || this.actveBan.bantype < ban.bantype)
				{
					this.actveBan = ban;
				}
				if (ban.bantype < RanksSystem.Ban.BanType.Mute)
				{
					if (ban.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_FgOverlap" + ban.id, null))
					{
						if (!this.NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[5];
							array[1] = "DPADHOR";
							array[0] = ban.bantype.ToString().ToLower();
							array[3] = "value";
							array[5] = ban.reason;
							array[5] = "setAF";
							array[0] = ban.bantype.ToString().ToLower();
							array[5] = "FileMenu";
							instance.ANCIONGLJAC(string.Concat(array), "_Value", null, false, false, 1922f);
							this.NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.SetBool("/" + ban.id, false, null);
						}
					}
					else if (!this.NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[1];
						array2[1] = "From {0} at Index {1} \n";
						array2[0] = ban.bantype.ToString().ToLower();
						array2[3] = "[MapEditor] Prepairing map editor...";
						array2[4] = ban.reason;
						array2[5] = "0.00";
						array2[1] = ban.bantype.ToString().ToLower();
						array2[4] = "#,0.00";
						array2[1] = ((!(ban.until == "_TimeX")) ? ban.until : "CameraFilterPack/Blend2Camera_ColorKey");
						instance2.ILNLMMEOALM(string.Concat(array2), "_TimeX", null, true, false, 1687f);
						this.NJCNMDDBJKI = false;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[4];
					array3[1] = "_ScreenResolution";
					array3[0] = ban.bantype.ToString().ToLower();
					array3[1] = "_Value2";
					array3[6] = ban.reason;
					array3[2] = "PointsScoreText";
					array3[4] = ban.bantype.ToString().ToLower();
					array3[5] = "_Distance";
					array3[3] = ((!(ban.until == "_Value3")) ? ban.until : "[PlayerBase] Unknown event: ");
					instance3.JCHNDBKFGFP(string.Concat(array3), "PLEASE WAIT", new UnityAction(this.BNOPFOOHOJM), false, true, 549f);
				}
			}
		}
		else if (this.actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.LKFALPEABHP("[NetworkScene] Exited", "checkpoint", null, true, true, 453f);
		}
	}

	// Token: 0x0600F098 RID: 61592 RVA: 0x0053EFC8 File Offset: 0x0053D1C8
	public string GPILNJFJMHA(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		HMACSHA256 hmacsha = new HMACSHA256(asciiencoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hmacsha.ComputeHash(asciiencoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	// Token: 0x0600F099 RID: 61593 RVA: 0x0053E4D5 File Offset: 0x0053C6D5
	public static byte[] BILHDDDJJNC(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.GetSecurityKey());
	}

	// Token: 0x0600F09A RID: 61594 RVA: 0x0053EFFC File Offset: 0x0053D1FC
	public static byte[] KLNCKGCBKIJ(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.JKPMEMICFKA());
	}

	// Token: 0x0600F09B RID: 61595 RVA: 0x0053F00C File Offset: 0x0053D20C
	public void PCHIFGNAHCH(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F09C RID: 61596 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void ILIPDIKLGFO()
	{
		Application.Quit();
	}

	// Token: 0x0600F09D RID: 61597 RVA: 0x0053F044 File Offset: 0x0053D244
	public void FPEOAAAIFAK(bool HHJAEKFIJAI = false)
	{
		GameManager.IPGILIBMHEJ(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.BEMECPDKOCA(Helpers.Md5Sum("Gameplay/sprite" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.AOBLOMMDBFB();
	}

	// Token: 0x0600F09E RID: 61598 RVA: 0x001F4D99 File Offset: 0x001F2F99
	public bool OLCIGDENLGH()
	{
		return true;
	}

	// Token: 0x0600F09F RID: 61599 RVA: 0x0053F0AC File Offset: 0x0053D2AC
	public void OIFKDCANEOA(string EAFAMAMDNEG)
	{
		base.StopAllCoroutines();
		Singleton<Scene>.Instance.BOECOLNJNOC(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.LKFALPEABHP(EAFAMAMDNEG.ToUpper(), "_Value3".ToUpper(), new UnityAction(this.GPDPIBOIKAJ), true, true, 1647f);
	}

	// Token: 0x0600F0A0 RID: 61600 RVA: 0x0053F108 File Offset: 0x0053D308
	public void EMANBHKAONB()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 1; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "\\")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Exception;
		}
	}

	// Token: 0x0600F0A1 RID: 61601 RVA: 0x0053F15C File Offset: 0x0053D35C
	public void DBFGPPAGNEL()
	{
		Singleton<Scene>.Instance.AJOOLOFFFGF(false);
		base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.IOLBDBFIOAM("maps.", "_NeutralTonemapperParams1".ToUpper(), new UnityAction(this.CMGHDPKCAEI), "_Luminance".ToUpper(), new UnityAction(this.CFNONKKJIOC)));
	}

	// Token: 0x0600F0A2 RID: 61602 RVA: 0x0053F1B6 File Offset: 0x0053D3B6
	public static bool IELIHANIEAC()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	// Token: 0x0600F0A3 RID: 61603 RVA: 0x0053F1C2 File Offset: 0x0053D3C2
	public static byte[] PAIHNEABIOJ(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.LGIIJOJJMPL());
	}

	// Token: 0x0600F0A4 RID: 61604 RVA: 0x0053F1B6 File Offset: 0x0053D3B6
	public static bool IMDOFCBINLC()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	// Token: 0x0600F0A5 RID: 61605 RVA: 0x0053E5FC File Offset: 0x0053C7FC
	public static string PFOCCIAHOCL()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	// Token: 0x0600F0A6 RID: 61606 RVA: 0x0053F1D0 File Offset: 0x0053D3D0
	public void KPCCPKIPFGC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600F0A7 RID: 61607 RVA: 0x0053EFFC File Offset: 0x0053D1FC
	public static byte[] PFJAHBBLGFE(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.JKPMEMICFKA());
	}

	// Token: 0x0600F0A8 RID: 61608 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void GPDPIBOIKAJ()
	{
		Application.Quit();
	}

	// Token: 0x0600F0A9 RID: 61609 RVA: 0x0053F210 File Offset: 0x0053D410
	public void AEIIHIGCCOF(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Remove(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F0AA RID: 61610 RVA: 0x0053F246 File Offset: 0x0053D446
	private void EJCBEEBPCGA()
	{
		this.GJJICHLLBPB(true);
	}

	// Token: 0x0600F0AB RID: 61611 RVA: 0x0053F250 File Offset: 0x0053D450
	public new void POHMFMNEPKK()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 0; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "[Right]")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Log;
		}
	}

	// Token: 0x0600F0AC RID: 61612 RVA: 0x0053F2A4 File Offset: 0x0053D4A4
	public void StartOfflineMessage()
	{
		Singleton<Scene>.Instance.ShowCursor(true);
		base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#startofflinemessage", "#exit".ToUpper(), new UnityAction(this.ExitGame), "#yes".ToUpper(), new UnityAction(this.CFNONKKJIOC)));
	}

	// Token: 0x0600F0AD RID: 61613 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void LOKDOBOJLDM()
	{
		Application.Quit();
	}

	// Token: 0x0600F0AE RID: 61614 RVA: 0x0053F300 File Offset: 0x0053D500
	public void CheckPlayerBans()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban ban in currentPlayerBans)
			{
				if (this.actveBan == null || this.actveBan.bantype < ban.bantype)
				{
					this.actveBan = ban;
				}
				if (ban.bantype < RanksSystem.Ban.BanType.Temporary)
				{
					if (ban.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.HasKey("bans.viewed." + ban.id, null))
					{
						if (!this.NJCNMDDBJKI)
						{
							Singleton<MessageBoxPanel>.Instance.DisplayMessage(string.Concat(new string[]
							{
								"<b>#",
								ban.bantype.ToString().ToLower(),
								"received</b>\n#reason: ",
								ban.reason,
								"\n\n#",
								ban.bantype.ToString().ToLower(),
								"restrictions"
							}), "#ok", null, true, false, 0f);
							this.NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.SetBool("bans.viewed." + ban.id, true, null);
						}
					}
					else if (!this.NJCNMDDBJKI)
					{
						Singleton<MessageBoxPanel>.Instance.DisplayMessage(string.Concat(new string[]
						{
							"<b>#",
							ban.bantype.ToString().ToLower(),
							"received</b>\n#reason: ",
							ban.reason,
							"\n\n#",
							ban.bantype.ToString().ToLower(),
							"restrictions\n\n#until: ",
							(!(ban.until == "-1")) ? ban.until : "#forever"
						}), "#ok", null, true, false, 0f);
						this.NJCNMDDBJKI = true;
					}
				}
				else
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage(string.Concat(new string[]
					{
						"<b>#",
						ban.bantype.ToString().ToLower(),
						"received</b>\n#reason: ",
						ban.reason,
						"\n\n#",
						ban.bantype.ToString().ToLower(),
						"restrictions\n\n#until: ",
						(!(ban.until == "-1")) ? ban.until : "#forever"
					}), "#ok", new UnityAction(this.CMKMEMANHFF), true, false, 0f);
				}
			}
		}
		else if (this.actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("<b>#banended</b>", "#ok", null, true, false, 0f);
		}
	}

	// Token: 0x0600F0AF RID: 61615 RVA: 0x0053F624 File Offset: 0x0053D824
	public static string JNPEKFHDAIG(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GameManager.PFOCCIAHOCL());
	}

	// Token: 0x0600F0B0 RID: 61616 RVA: 0x0053F644 File Offset: 0x0053D844
	public void OpenURL(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600F0B1 RID: 61617 RVA: 0x0002523B File Offset: 0x0002343B
	public void PMLDBMFOPOG()
	{
	}

	// Token: 0x0600F0B2 RID: 61618 RVA: 0x0053E54B File Offset: 0x0053C74B
	public static byte[] NONCHHOHMKM(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GameManager.MDGOPLBOIHB());
	}

	// Token: 0x0600F0B3 RID: 61619 RVA: 0x0053EB22 File Offset: 0x0053CD22
	public static bool BGDFGGHAHHD()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	// Token: 0x0600F0B4 RID: 61620 RVA: 0x001F4D99 File Offset: 0x001F2F99
	public bool IsCheatsAllowed()
	{
		return true;
	}

	// Token: 0x0600F0B5 RID: 61621 RVA: 0x0053F684 File Offset: 0x0053D884
	public static byte[] OGGKBIBHFLH(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GameManager.CHCMFHMJGDN());
	}

	// Token: 0x0600F0B6 RID: 61622 RVA: 0x0053F694 File Offset: 0x0053D894
	public void EJGBOJDDMHH(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.Instance.CBIPOKCJEPJ(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.Instance.KLPKKGGCLPH(null, null, 1, 1);
		}
		else
		{
			DiscordController.ELDHCIEPLLH().JBFOLLCGNEH(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("Gameplay/satellite", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("#mapmustbecompletebeforesubmit" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("_MainTex2", NOEBNLFEPCN);
	}

	// Token: 0x0600F0B7 RID: 61623 RVA: 0x0053E65A File Offset: 0x0053C85A
	private static void BMKIGMJENNK(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	// Token: 0x0600F0B8 RID: 61624 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void HDMJFFHCPKE()
	{
		Application.Quit();
	}

	// Token: 0x0600F0B9 RID: 61625 RVA: 0x0053F714 File Offset: 0x0053D914
	public void NJOEGFFMEIC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600F0BA RID: 61626 RVA: 0x0053F1B6 File Offset: 0x0053D3B6
	public static bool JLAGBKACIIC()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	// Token: 0x0600F0BB RID: 61627 RVA: 0x0053F754 File Offset: 0x0053D954
	public void IKDPMOJKILD(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x0600F0DF RID: 61663 RVA: 0x0053F1B6 File Offset: 0x0053D3B6
	// (set) Token: 0x0600F0BC RID: 61628 RVA: 0x0053E65A File Offset: 0x0053C85A
	public static bool IsOffline
	{
		get
		{
			return Singleton<GameManager>.Instance.CBBMLBIMBIH;
		}
		private set
		{
			Singleton<GameManager>.Instance.CBBMLBIMBIH = value;
		}
	}

	// Token: 0x0600F0BD RID: 61629 RVA: 0x0053F794 File Offset: 0x0053D994
	public void CDJJAFLCOGO(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F0BE RID: 61630 RVA: 0x0053F7CC File Offset: 0x0053D9CC
	public void IAAFHGGFMAB()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "[MenuScene] Inited")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = (LogType)7;
		}
	}

	// Token: 0x0600F0C0 RID: 61632 RVA: 0x0053E65A File Offset: 0x0053C85A
	private static void DGMGJJPAEAN(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	// Token: 0x0600F0C1 RID: 61633 RVA: 0x0053F828 File Offset: 0x0053DA28
	public string HashHMAC(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		HMACSHA256 hmacsha = new HMACSHA256(asciiencoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hmacsha.ComputeHash(asciiencoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	// Token: 0x0600F0C2 RID: 61634 RVA: 0x0053F85C File Offset: 0x0053DA5C
	public static string HGIFJHHKABG(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GameManager.PBCOHBDCOEI());
	}

	// Token: 0x0600F0C3 RID: 61635 RVA: 0x0053F87A File Offset: 0x0053DA7A
	public static byte[] CPICEAAPMIH(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GameManager.PBCOHBDCOEI());
	}

	// Token: 0x0600F0C4 RID: 61636 RVA: 0x0053F887 File Offset: 0x0053DA87
	public static string Decrypt(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GameManager.GetSecurityKey());
	}

	// Token: 0x0600F0C5 RID: 61637 RVA: 0x0053F8A8 File Offset: 0x0053DAA8
	public void MIEFLJDAOCA(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F0C6 RID: 61638 RVA: 0x0053F8E0 File Offset: 0x0053DAE0
	public void GIBBJCCHOOJ(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600F0C7 RID: 61639 RVA: 0x0053F920 File Offset: 0x0053DB20
	public void IDDINACMJAK(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F0C8 RID: 61640 RVA: 0x0053F958 File Offset: 0x0053DB58
	public new void Awake()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "-showlogs")
			{
				flag = true;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Warning;
		}
	}

	// Token: 0x0600F0C9 RID: 61641 RVA: 0x0053F9AC File Offset: 0x0053DBAC
	public void DFLDFEIAOHF()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban ban in currentPlayerBans)
			{
				if (this.actveBan == null || this.actveBan.bantype < ban.bantype)
				{
					this.actveBan = ban;
				}
				if (ban.bantype < RanksSystem.Ban.BanType.Mute)
				{
					if (ban.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + ban.id, null))
					{
						if (!this.NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[3];
							array[0] = "menu.tabid";
							array[0] = ban.bantype.ToString().ToLower();
							array[5] = "PunRespawn";
							array[5] = ban.reason;
							array[0] = "CameraMovementSlider";
							array[1] = ban.bantype.ToString().ToLower();
							array[4] = "[Singleton] Using instance of '";
							instance.AGMKJJLMOHG(string.Concat(array), "CameraFilterPack/FX_Ascii", null, true, false, 92f);
							this.NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.CMLFCHINKCH("menu.selectedlevelid" + ban.id, true, null);
						}
					}
					else if (!this.NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[8];
						array2[1] = "GroupNameText";
						array2[1] = ban.bantype.ToString().ToLower();
						array2[1] = "BadgeImage";
						array2[1] = ban.reason;
						array2[5] = "_TimeX";
						array2[4] = ban.bantype.ToString().ToLower();
						array2[0] = "Forward";
						array2[7] = ((!(ban.until == "[LevelEditorScene] Map submitted!")) ? ban.until : "workshop.");
						instance2.ILNLMMEOALM(string.Concat(array2), "PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", null, false, true, 551f);
						this.NJCNMDDBJKI = false;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[8];
					array3[0] = "Object ID. Case-Sensitive";
					array3[0] = ban.bantype.ToString().ToLower();
					array3[7] = "_Value3";
					array3[4] = ban.reason;
					array3[0] = "PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.";
					array3[4] = ban.bantype.ToString().ToLower();
					array3[3] = "_Offsets";
					array3[1] = ((!(ban.until == "ShowSprite")) ? ban.until : "_Blue_B");
					instance3.ANCIONGLJAC(string.Concat(array3), "Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", new UnityAction(this.CMKMEMANHFF), true, false, 165f);
				}
			}
		}
		else if (this.actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("LivesSlider", "_ScreenResolution", null, true, false, 1599f);
		}
	}

	// Token: 0x0600F0CA RID: 61642 RVA: 0x0053FCD0 File Offset: 0x0053DED0
	public void DBKNEMCABGK(FinishedMapInfo DAGALCAILLN)
	{
		if (this.HOGJGGGDPDD != null)
		{
			this.HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	// Token: 0x0600F0CB RID: 61643 RVA: 0x0053FCEC File Offset: 0x0053DEEC
	public void IPNHHBFPDJK(string EAFAMAMDNEG)
	{
		base.StopAllCoroutines();
		Singleton<Scene>.Instance.AJOOLOFFFGF(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC(EAFAMAMDNEG.ToUpper(), "Drop_Near".ToUpper(), new UnityAction(this.BPJNJNLKOIL), false, false, 980f);
	}

	// Token: 0x0600F0CC RID: 61644 RVA: 0x0053E608 File Offset: 0x0053C808
	public void JPOHIMKANLP(GameEventInfo DAGALCAILLN)
	{
		if (this.OKLHDAEHLKC != null)
		{
			this.OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	// Token: 0x0600F0CD RID: 61645 RVA: 0x0053FD47 File Offset: 0x0053DF47
	public int JICDIFGAADO()
	{
		return (int)((this.actveBan != null) ? (this.actveBan.bantype + 0) : RanksSystem.Ban.BanType.Mute);
	}

	// Token: 0x0600F0CE RID: 61646 RVA: 0x0053E65A File Offset: 0x0053C85A
	private static void EPMHNKLAGHK(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x0600F101 RID: 61697 RVA: 0x00540734 File Offset: 0x0053E934
	// (remove) Token: 0x0600F0CF RID: 61647 RVA: 0x0053FD68 File Offset: 0x0053DF68
	public event GameManager.PlayerGameEvent OnGameEvent
	{
		add
		{
			GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
			GameManager.PlayerGameEvent playerGameEvent2;
			do
			{
				playerGameEvent2 = playerGameEvent;
				playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Combine(playerGameEvent2, value), playerGameEvent);
			}
			while (playerGameEvent != playerGameEvent2);
		}
		remove
		{
			GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
			GameManager.PlayerGameEvent playerGameEvent2;
			do
			{
				playerGameEvent2 = playerGameEvent;
				playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Remove(playerGameEvent2, value), playerGameEvent);
			}
			while (playerGameEvent != playerGameEvent2);
		}
	}

	// Token: 0x0600F0D0 RID: 61648 RVA: 0x0053FCD0 File Offset: 0x0053DED0
	public void FinishedMap(FinishedMapInfo DAGALCAILLN)
	{
		if (this.HOGJGGGDPDD != null)
		{
			this.HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	// Token: 0x0600F0D1 RID: 61649 RVA: 0x0053FDA0 File Offset: 0x0053DFA0
	public string BALOIDPDPAO(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		HMACSHA256 hmacsha = new HMACSHA256(asciiencoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hmacsha.ComputeHash(asciiencoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	// Token: 0x0600F0D2 RID: 61650 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void FJJLJAFCGIE()
	{
		Application.Quit();
	}

	// Token: 0x0600F0D3 RID: 61651 RVA: 0x0053FDD4 File Offset: 0x0053DFD4
	public static string PJHEGJPGKPP(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GameManager.PBCOHBDCOEI());
	}

	// Token: 0x0600F0D4 RID: 61652 RVA: 0x0053FDF4 File Offset: 0x0053DFF4
	public new void JBIFKBNPHJE()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "IntraSig")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = (LogType)8;
		}
	}

	// Token: 0x0600F0D5 RID: 61653 RVA: 0x0053FE48 File Offset: 0x0053E048
	private void OAGAGNAOKGG()
	{
		this.BPJNJNLKOIL();
	}

	// Token: 0x0600F0D6 RID: 61654 RVA: 0x0053E6CF File Offset: 0x0053C8CF
	private void KGPBJODDMLK()
	{
		this.GPDPIBOIKAJ();
	}

	// Token: 0x0600F0D7 RID: 61655 RVA: 0x0053FE50 File Offset: 0x0053E050
	public void BLOKNDEOACI(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F0D8 RID: 61656 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void BPJNJNLKOIL()
	{
		Application.Quit();
	}

	// Token: 0x0600F0D9 RID: 61657 RVA: 0x0053FE86 File Offset: 0x0053E086
	public static byte[] FLFAGFLICNE(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GameManager.JKPMEMICFKA());
	}

	// Token: 0x0600F0DA RID: 61658 RVA: 0x0053FE94 File Offset: 0x0053E094
	public void GJJICHLLBPB(bool HHJAEKFIJAI = false)
	{
		GameManager.PIMOBMKNLPI(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.CAJFKNFJEKC(Helpers.Md5Sum("_Far" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	// Token: 0x0600F0DB RID: 61659 RVA: 0x0053FCD0 File Offset: 0x0053DED0
	public void IFOBNIOIEEL(FinishedMapInfo DAGALCAILLN)
	{
		if (this.HOGJGGGDPDD != null)
		{
			this.HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	// Token: 0x0600F0DC RID: 61660 RVA: 0x0053E713 File Offset: 0x0053C913
	public static string Encrypt(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GameManager.GetSecurityKey());
	}

	// Token: 0x0600F0DD RID: 61661 RVA: 0x0053E6F5 File Offset: 0x0053C8F5
	public static string BLNJDEEDEDJ(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GameManager.MDGOPLBOIHB());
	}

	// Token: 0x0600F0DE RID: 61662 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void ExitGame()
	{
		Application.Quit();
	}

	// Token: 0x0600F0E0 RID: 61664 RVA: 0x0053E65A File Offset: 0x0053C85A
	private static void JIBOMDGPAKF(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	// Token: 0x0600F0E1 RID: 61665 RVA: 0x0053E5FC File Offset: 0x0053C7FC
	public static string LGIIJOJJMPL()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	// Token: 0x0600F0E2 RID: 61666 RVA: 0x0053FEFC File Offset: 0x0053E0FC
	public void GMDIJMFPKOC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600F0E3 RID: 61667 RVA: 0x0053E608 File Offset: 0x0053C808
	public void FODNDEKALAO(GameEventInfo DAGALCAILLN)
	{
		if (this.OKLHDAEHLKC != null)
		{
			this.OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	// Token: 0x0600F0E4 RID: 61668 RVA: 0x0053FF3C File Offset: 0x0053E13C
	public void MBCDCBCLMCI()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "_Value")
			{
				flag = true;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Exception;
		}
	}

	// Token: 0x0600F0E5 RID: 61669 RVA: 0x0053FF90 File Offset: 0x0053E190
	public string JANFHJHPPJP(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		HMACSHA256 hmacsha = new HMACSHA256(asciiencoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hmacsha.ComputeHash(asciiencoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	// Token: 0x0600F0E6 RID: 61670 RVA: 0x0053E5FC File Offset: 0x0053C7FC
	public static string CHCMFHMJGDN()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	// Token: 0x0600F0E7 RID: 61671 RVA: 0x0053FFC4 File Offset: 0x0053E1C4
	public void DieWithError(string EAFAMAMDNEG)
	{
		base.StopAllCoroutines();
		Singleton<Scene>.Instance.ShowCursor(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(EAFAMAMDNEG.ToUpper(), "#ok".ToUpper(), new UnityAction(this.ExitGame), true, false, 0f);
	}

	// Token: 0x0600F0E8 RID: 61672 RVA: 0x00540020 File Offset: 0x0053E220
	public new void BHCCNFJKGPD()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 0; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "colorD")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Error;
		}
	}

	// Token: 0x0600F0E9 RID: 61673 RVA: 0x0053E6D7 File Offset: 0x0053C8D7
	public static string EHJKPAKGJNA(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GameManager.JKPMEMICFKA());
	}

	// Token: 0x0600F0EA RID: 61674 RVA: 0x00540074 File Offset: 0x0053E274
	public void IGIDKGGKODK(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F0EB RID: 61675 RVA: 0x005400AC File Offset: 0x0053E2AC
	public void MKEGIDHHLIC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600F0EC RID: 61676 RVA: 0x005400EC File Offset: 0x0053E2EC
	public void LNGLLNDJDDK(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F0ED RID: 61677 RVA: 0x00540124 File Offset: 0x0053E324
	public void GMEFFKOFBLL()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban ban in currentPlayerBans)
			{
				if (this.actveBan == null || this.actveBan.bantype < ban.bantype)
				{
					this.actveBan = ban;
				}
				if (ban.bantype < RanksSystem.Ban.BanType.Warning)
				{
					if (ban.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_ScreenResolution" + ban.id, null))
					{
						if (!this.NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[3];
							array[0] = "-help";
							array[0] = ban.bantype.ToString().ToLower();
							array[6] = "_ScreenResolution";
							array[0] = ban.reason;
							array[2] = "mapselector.tags.";
							array[7] = ban.bantype.ToString().ToLower();
							array[8] = "_TargetScale";
							instance.ALHLMBCOILP(string.Concat(array), "UndoButton", null, true, true, 280f);
							this.NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.CONNMLDKBOF("_ScreenResolution" + ban.id, true, null);
						}
					}
					else if (!this.NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[0];
						array2[1] = "tagElement";
						array2[0] = ban.bantype.ToString().ToLower();
						array2[8] = "_Value";
						array2[7] = ban.reason;
						array2[3] = "_Value";
						array2[8] = ban.bantype.ToString().ToLower();
						array2[7] = "settings_bindings_controller_type";
						array2[6] = ((!(ban.until == "default")) ? ban.until : "_FarCamera");
						instance2.ILNLMMEOALM(string.Concat(array2), "UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", null, false, false, 362f);
						this.NJCNMDDBJKI = true;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[5];
					array3[0] = "_ScreenResolution";
					array3[0] = ban.bantype.ToString().ToLower();
					array3[0] = "DifficultyBG";
					array3[6] = ban.reason;
					array3[6] = "Print the list of scenes, avalable in game.";
					array3[1] = ban.bantype.ToString().ToLower();
					array3[8] = "TransferOwnership() view ";
					array3[2] = ((!(ban.until == "Image")) ? ban.until : "_ScreenResolution");
					instance3.JCHNDBKFGFP(string.Concat(array3), "ViewMenu", new UnityAction(this.OAGAGNAOKGG), true, true, 1092f);
				}
			}
		}
		else if (this.actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("HightScoreMaxPointsText", "_Value4", null, true, true, 993f);
		}
	}

	// Token: 0x0600F0EE RID: 61678 RVA: 0x00540448 File Offset: 0x0053E648
	public void GEIBPCGKDIP(string EAFAMAMDNEG)
	{
		base.StopAllCoroutines();
		Singleton<Scene>.Instance.GMGMPMIIMLP(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC(EAFAMAMDNEG.ToUpper(), "_TimeX".ToUpper(), new UnityAction(this.CMGHDPKCAEI), true, false, 1597f);
	}

	// Token: 0x0600F0EF RID: 61679 RVA: 0x0053EBBE File Offset: 0x0053CDBE
	public int KMCGCEPLODF()
	{
		return (int)((this.actveBan != null) ? (this.actveBan.bantype + 1) : RanksSystem.Ban.BanType.Warning);
	}

	// Token: 0x0600F0F0 RID: 61680 RVA: 0x005404A3 File Offset: 0x0053E6A3
	public static string CAIPOCBLHFJ(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GameManager.PFOCCIAHOCL());
	}

	// Token: 0x0600F0F1 RID: 61681 RVA: 0x005404C4 File Offset: 0x0053E6C4
	public void IPOGIBLJDPE(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.KDAJPJPBIBI().KGNFAPNFEPC(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.NLEPFMACKHN().JBFOLLCGNEH(null, null, 0, 1);
		}
		else
		{
			DiscordController.MFPEEHNEFIM().FOBPJLCOKPL(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("Joystick1Button10", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("]" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("challenges/", NOEBNLFEPCN);
	}

	// Token: 0x0600F0F2 RID: 61682 RVA: 0x00540544 File Offset: 0x0053E744
	public void PGNNMANJJAC(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F0F3 RID: 61683 RVA: 0x0054057C File Offset: 0x0053E77C
	public void CGKJOLHBNPM(GameManager.PlayerGameEvent DPNHODJHGJL)
	{
		GameManager.PlayerGameEvent playerGameEvent = this.OKLHDAEHLKC;
		GameManager.PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange<GameManager.PlayerGameEvent>(ref this.OKLHDAEHLKC, (GameManager.PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while (playerGameEvent != playerGameEvent2);
	}

	// Token: 0x0600F0F4 RID: 61684 RVA: 0x0053EB22 File Offset: 0x0053CD22
	public static bool IsOwner()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	// Token: 0x0600F0F5 RID: 61685 RVA: 0x0002523B File Offset: 0x0002343B
	public void HJIHIKEKHLC()
	{
	}

	// Token: 0x0600F0F6 RID: 61686 RVA: 0x0053F87A File Offset: 0x0053DA7A
	public static byte[] KBDPIJBHEEH(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GameManager.PBCOHBDCOEI());
	}

	// Token: 0x0600F0F7 RID: 61687 RVA: 0x005405B4 File Offset: 0x0053E7B4
	public void MKGBAKICGOA(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.ELDHCIEPLLH().JAPNGOOCLMF(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.OFEINMJONLO().FOBPJLCOKPL(null, null, 0, 0);
		}
		else
		{
			DiscordController.ELDHCIEPLLH().MIBLNODIDGN(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("player.greenlifering", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("ticket" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("_Vignette", NOEBNLFEPCN);
	}

	// Token: 0x0600F0F8 RID: 61688 RVA: 0x00540634 File Offset: 0x0053E834
	private void LLEEKHKLJLB()
	{
		this.FPEOAAAIFAK(true);
	}

	// Token: 0x0600F0F9 RID: 61689 RVA: 0x00540640 File Offset: 0x0053E840
	public void JFEOOAIGNLK(string EAFAMAMDNEG)
	{
		base.StopAllCoroutines();
		Singleton<Scene>.Instance.GNHEECNBLOC(false);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP(EAFAMAMDNEG.ToUpper(), "Had to lookup view that wasn't in photonViewList: ".ToUpper(), new UnityAction(this.HDMJFFHCPKE), false, true, 310f);
	}

	// Token: 0x0600F0FA RID: 61690 RVA: 0x0054069C File Offset: 0x0053E89C
	public void IEEHOAELCGE(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600F0FB RID: 61691 RVA: 0x0053F1B6 File Offset: 0x0053D3B6
	public static bool PEJIIBNCKEI()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	// Token: 0x0600F0FC RID: 61692 RVA: 0x0053E5FC File Offset: 0x0053C7FC
	public static string MDGOPLBOIHB()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	// Token: 0x0600F0FD RID: 61693 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void FELAFOOEBNG()
	{
		Application.Quit();
	}

	// Token: 0x0600F0FE RID: 61694 RVA: 0x005406DC File Offset: 0x0053E8DC
	public static string EOBBGILNOEC(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GameManager.LGIIJOJJMPL());
	}

	// Token: 0x0600F100 RID: 61696 RVA: 0x0053FD47 File Offset: 0x0053DF47
	public int GAEDGNFPNCL()
	{
		return (int)((this.actveBan != null) ? (this.actveBan.bantype + 0) : RanksSystem.Ban.BanType.Mute);
	}

	// Token: 0x0600F102 RID: 61698 RVA: 0x001F4D9C File Offset: 0x001F2F9C
	public bool FMAOGGPBJFB()
	{
		return false;
	}

	// Token: 0x0600F103 RID: 61699 RVA: 0x0054076C File Offset: 0x0053E96C
	public void DCGKDPPLKBP(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F104 RID: 61700 RVA: 0x005407A2 File Offset: 0x0053E9A2
	public int ONCEJHOAHIC()
	{
		return (int)((this.actveBan != null) ? (this.actveBan.bantype + 0) : RanksSystem.Ban.BanType.Warning);
	}

	// Token: 0x0600F105 RID: 61701 RVA: 0x005407C2 File Offset: 0x0053E9C2
	public int OGHIKBFLOOD()
	{
		return (int)((this.actveBan != null) ? (this.actveBan.bantype + 1) : RanksSystem.Ban.BanType.Mute);
	}

	// Token: 0x0600F106 RID: 61702 RVA: 0x005407E2 File Offset: 0x0053E9E2
	[CompilerGenerated]
	private void CFNONKKJIOC()
	{
		this.OnUserVerified(true);
	}

	// Token: 0x0600F107 RID: 61703 RVA: 0x0053EB22 File Offset: 0x0053CD22
	public static bool ACMHININJEL()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	// Token: 0x0600F108 RID: 61704 RVA: 0x005407EC File Offset: 0x0053E9EC
	public void POFNEAFGOBC()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban ban in currentPlayerBans)
			{
				if (this.actveBan == null || this.actveBan.bantype < ban.bantype)
				{
					this.actveBan = ban;
				}
				if (ban.bantype < (RanksSystem.Ban.BanType)6)
				{
					if (ban.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Set satellite lerp speed" + ban.id, null))
					{
						if (!this.NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[5];
							array[0] = "_SunColor";
							array[0] = ban.bantype.ToString().ToLower();
							array[5] = "[MapsData] Preloading ";
							array[4] = ban.reason;
							array[8] = "player.circle";
							array[6] = ban.bantype.ToString().ToLower();
							array[4] = "1";
							instance.ANCIONGLJAC(string.Concat(array), "skin.", null, false, true, 812f);
							this.NJCNMDDBJKI = false;
							Singleton<SaveSystem>.Instance.NCNNFONPMLD("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + ban.id, true, null);
						}
					}
					else if (!this.NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[7];
						array2[1] = "[NetworkManager] Connecting...";
						array2[0] = ban.bantype.ToString().ToLower();
						array2[6] = "Start Color's hex value #RRGGBBAA";
						array2[4] = ban.reason;
						array2[0] = "Joystick1Button11";
						array2[0] = ban.bantype.ToString().ToLower();
						array2[1] = "CameraFilterPack/Sharpen_Sharpen";
						array2[8] = ((!(ban.until == "_WaveIntensity")) ? ban.until : "_Value3");
						instance2.JCHNDBKFGFP(string.Concat(array2), "EXCEPTION:", null, true, true, 418f);
						this.NJCNMDDBJKI = true;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[3];
					array3[1] = "RestartButton";
					array3[0] = ban.bantype.ToString().ToLower();
					array3[4] = "CameraFilterPack/TV_Rgb";
					array3[1] = ban.reason;
					array3[7] = "MainButton";
					array3[0] = ban.bantype.ToString().ToLower();
					array3[7] = "_CurveParams";
					array3[0] = ((!(ban.until == "_TimeX")) ? ban.until : "Had to lookup view that wasn't in photonViewList: ");
					instance3.ALHLMBCOILP(string.Concat(array3), "ns", new UnityAction(this.KGPBJODDMLK), true, true, 431f);
				}
			}
		}
		else if (this.actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("1248864821", "plainText", null, false, false, 526f);
		}
	}

	// Token: 0x0600F109 RID: 61705 RVA: 0x005407C2 File Offset: 0x0053E9C2
	public int KCBEIOODMGL()
	{
		return (int)((this.actveBan != null) ? (this.actveBan.bantype + 1) : RanksSystem.Ban.BanType.Mute);
	}

	// Token: 0x0600F10A RID: 61706 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void CMGHDPKCAEI()
	{
		Application.Quit();
	}

	// Token: 0x0600F10B RID: 61707 RVA: 0x0053E65A File Offset: 0x0053C85A
	private static void PIMOBMKNLPI(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	// Token: 0x0600F10C RID: 61708 RVA: 0x00540B10 File Offset: 0x0053ED10
	private void ABIMDEFFFJC()
	{
		this.POJOGLNKBFI(false);
	}

	// Token: 0x0600F10D RID: 61709 RVA: 0x0053FCD0 File Offset: 0x0053DED0
	public void OLDEAEGFDAP(FinishedMapInfo DAGALCAILLN)
	{
		if (this.HOGJGGGDPDD != null)
		{
			this.HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	// Token: 0x0600F10E RID: 61710 RVA: 0x00540B1C File Offset: 0x0053ED1C
	public void PDNPNJNFDGL(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.CJBKCCLGIAG().CCDJCDOGOFD(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.CJBKCCLGIAG().UpdateJoin(null, null, 1, 1);
		}
		else
		{
			DiscordController.Instance.KLPKKGGCLPH(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("_Intensity", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("SetParticlesGravity" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("#no", NOEBNLFEPCN);
	}

	// Token: 0x0600F10F RID: 61711 RVA: 0x00540B9C File Offset: 0x0053ED9C
	public string CreateServerURL(string IEENFEMACND)
	{
		return ((!this.isBeta) ? this.dataServerURL : this.betaDataServerURL) + IEENFEMACND;
	}

	// Token: 0x0600F110 RID: 61712 RVA: 0x0053F85C File Offset: 0x0053DA5C
	public static string MLFEBPAINHO(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GameManager.PBCOHBDCOEI());
	}

	// Token: 0x0600F111 RID: 61713 RVA: 0x00540BC0 File Offset: 0x0053EDC0
	public void EAIPOEBPJOP(GameManager.FinishedMapEvent DPNHODJHGJL)
	{
		GameManager.FinishedMapEvent finishedMapEvent = this.HOGJGGGDPDD;
		GameManager.FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange<GameManager.FinishedMapEvent>(ref this.HOGJGGGDPDD, (GameManager.FinishedMapEvent)Delegate.Remove(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while (finishedMapEvent != finishedMapEvent2);
	}

	// Token: 0x0600F112 RID: 61714 RVA: 0x0053EB22 File Offset: 0x0053CD22
	public static bool ONIMHMBKEHG()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	// Token: 0x0600F113 RID: 61715 RVA: 0x00540BF8 File Offset: 0x0053EDF8
	public void PCFCBAHKDGF(bool HHJAEKFIJAI = false)
	{
		GameManager.PIMOBMKNLPI(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.BEMECPDKOCA(Helpers.Md5Sum("_Distortion" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.PEGGAJELPBJ();
		Singleton<RanksSystem>.Instance.NKLCNJEIAFB();
		Singleton<LuaEnvironment>.Instance.RunFirstInit();
	}

	// Token: 0x04001ABF RID: 6847
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GameManager.FinishedMapEvent HOGJGGGDPDD;

	// Token: 0x04001AC0 RID: 6848
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GameManager.PlayerGameEvent OKLHDAEHLKC;

	// Token: 0x04001AC1 RID: 6849
	public bool isBeta;

	// Token: 0x04001AC2 RID: 6850
	public string cachURL;

	// Token: 0x04001AC3 RID: 6851
	public string securityKey;

	// Token: 0x04001AC4 RID: 6852
	public string dataServerURL;

	// Token: 0x04001AC5 RID: 6853
	public string betaDataServerURL;

	// Token: 0x04001AC6 RID: 6854
	public RanksSystem.Ban actveBan;

	// Token: 0x04001AC7 RID: 6855
	private bool NJCNMDDBJKI;

	// Token: 0x04001AC8 RID: 6856
	public GameManager.GameState currentState;

	// Token: 0x04001AC9 RID: 6857
	private bool CBBMLBIMBIH;

	// Token: 0x0200041A RID: 1050
	// (Invoke) Token: 0x0600F115 RID: 61717
	public delegate void FinishedMapEvent(FinishedMapInfo DAGALCAILLN);

	// Token: 0x0200041B RID: 1051
	// (Invoke) Token: 0x0600F119 RID: 61721
	public delegate void PlayerGameEvent(GameEventInfo DAGALCAILLN);

	// Token: 0x0200041C RID: 1052
	public enum GameState
	{
		// Token: 0x04001ACB RID: 6859
		Init,
		// Token: 0x04001ACC RID: 6860
		Loading,
		// Token: 0x04001ACD RID: 6861
		Menu,
		// Token: 0x04001ACE RID: 6862
		Playing,
		// Token: 0x04001ACF RID: 6863
		Finished,
		// Token: 0x04001AD0 RID: 6864
		Editor
	}
}
