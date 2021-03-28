using System;
using System.Collections;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using Steamworks;
using UnityEngine;

// Token: 0x02000229 RID: 553
[DisallowMultipleComponent]
internal class SteamManager : MonoBehaviour
{
	// Token: 0x060085F0 RID: 34288 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void ExitGame()
	{
		Application.Quit();
	}

	// Token: 0x060085F1 RID: 34289 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void NCJHDGAABDE()
	{
		Application.Quit();
	}

	// Token: 0x060085F2 RID: 34290 RVA: 0x002EFCDF File Offset: 0x002EDEDF
	private static void KHJPJOCKGCA(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	// Token: 0x060085F3 RID: 34291 RVA: 0x002EFCE8 File Offset: 0x002EDEE8
	private IEnumerator IMLLNKFFNFE(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		SteamManager.connectingToServer = false;
		if (!SteamManager.isKeyVerified)
		{
			SteamManager.isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
		yield break;
	}

	// Token: 0x060085F4 RID: 34292 RVA: 0x002EFD03 File Offset: 0x002EDF03
	private void JOKPEOJNLJL(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			base.StopCoroutine("CameraFilterPack/Oculus_NightVision2");
			Debug.Log("_Blue_C");
			base.StartCoroutine(this.MNAMCHHEOFB());
		}
	}

	// Token: 0x060085F5 RID: 34293 RVA: 0x002EFD34 File Offset: 0x002EDF34
	private void MLLFDFFJDFA(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive != 0)
		{
		}
	}

	// Token: 0x060085F6 RID: 34294 RVA: 0x002EFCDF File Offset: 0x002EDEDF
	private static void CDFHAHKKCGA(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	// Token: 0x060085F7 RID: 34295 RVA: 0x002EFD48 File Offset: 0x002EDF48
	private IEnumerator LDBKGFDHKFB(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		SteamManager.connectingToServer = false;
		if (!SteamManager.isKeyVerified)
		{
			SteamManager.isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
		yield break;
	}

	// Token: 0x060085F8 RID: 34296 RVA: 0x002EFD64 File Offset: 0x002EDF64
	private void OnEnable()
	{
		if (SteamManager.IEHNBLNFHJI == null)
		{
			SteamManager.IEHNBLNFHJI = this;
		}
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		if (this.PGCMGFLDEFI == null)
		{
			this.PGCMGFLDEFI = new SteamAPIWarningMessageHook_t(SteamManager.KHJPJOCKGCA);
			SteamClient.SetWarningMessageHook(this.PGCMGFLDEFI);
		}
		if (SteamManager.Initialized)
		{
			this.PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.MLLFDFFJDFA));
		}
	}

	// Token: 0x060085F9 RID: 34297 RVA: 0x002EFDDC File Offset: 0x002EDFDC
	private IEnumerator DKNKLPLIENK(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		SteamManager.connectingToServer = false;
		if (!SteamManager.isKeyVerified)
		{
			SteamManager.isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
		yield break;
	}

	// Token: 0x060085FA RID: 34298 RVA: 0x002EFDF7 File Offset: 0x002EDFF7
	private void Update()
	{
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
		if (!this.MEMEGFOKJBG)
		{
			SteamAPI.Shutdown();
			base.enabled = false;
		}
	}

	// Token: 0x060085FB RID: 34299 RVA: 0x002EFE24 File Offset: 0x002EE024
	private IEnumerator JGOOHEBBDBF(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		SteamManager.connectingToServer = false;
		if (!SteamManager.isKeyVerified)
		{
			SteamManager.isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
		yield break;
	}

	// Token: 0x060085FC RID: 34300 RVA: 0x002EFE40 File Offset: 0x002EE040
	private static byte[] NNCJHPHAOOA(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 8];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 0, array.Length);
		return array;
	}

	// Token: 0x060085FD RID: 34301 RVA: 0x002EFE70 File Offset: 0x002EE070
	private static byte[] IJDLJFPBCIE(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 5];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 1, array.Length);
		return array;
	}

	// Token: 0x060085FE RID: 34302 RVA: 0x002EFE9D File Offset: 0x002EE09D
	private void AIKCLFJPGAC(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[1];
		array[1] = " has no method \"";
		array[0] = 145;
		array[1] = "ViewMenu";
		array[6] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x060085FF RID: 34303 RVA: 0x002EFED8 File Offset: 0x002EE0D8
	private IEnumerator IGGDDOEPOGM()
	{
		this.steamTempKey = this.KNFLKCLHDFC(this.GEIOLGGAMKL, (int)this.KMDGBKMCCAM);
		WWWForm wwwform = new WWWForm();
		wwwform.AddField("ticket", this.steamTempKey);
		byte[] data = wwwform.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(this.authenticateUserTicketURL);
		WWW www = new WWW(url, data);
		yield return www;
		SteamManager.connectingToServer = true;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				SteamManager.connectingToServer = false;
				base.StopCoroutine("LDBKGFDHKFB");
				SteamManager.isKeyVerified = true;
				Singleton<GameManager>.Instance.OnUserVerified(false);
			}
		}
		yield break;
	}

	// Token: 0x06008600 RID: 34304 RVA: 0x002EFEF4 File Offset: 0x002EE0F4
	private void JCDPMLPNOOC()
	{
		if (SteamManager.IEHNBLNFHJI == null)
		{
			SteamManager.IEHNBLNFHJI = this;
		}
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		if (this.PGCMGFLDEFI == null)
		{
			this.PGCMGFLDEFI = new SteamAPIWarningMessageHook_t(SteamManager.KHJPJOCKGCA);
			SteamClient.SetWarningMessageHook(this.PGCMGFLDEFI);
		}
		if (SteamManager.CEIGOIJPONC())
		{
			this.PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.MIFCCDEFKNN));
		}
	}

	// Token: 0x06008601 RID: 34305 RVA: 0x002EFF6C File Offset: 0x002EE16C
	private void NDAGPMPBAPN(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		Debug.Log(string.Concat(new object[]
		{
			"[",
			165,
			" - StoreAuthURLResponse] - ",
			IAFAANLMOAG.m_szURL
		}));
	}

	// Token: 0x06008602 RID: 34306 RVA: 0x002EFFA8 File Offset: 0x002EE1A8
	public void IOMCHHBGJEC()
	{
		this.LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(new Callback<GetAuthSessionTicketResponse_t>.DispatchDelegate(this.FBKDGBINBOO));
		if (SteamManager.IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.IEHNBLNFHJI = this;
		if (SteamManager.KGJDHIHOCEI)
		{
			throw new Exception("PS Home");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("settings.disablestoryboard", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("CameraFilterPack/Distortion_Flag", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967216U))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("_FixDistance" + arg, this);
			Application.Quit();
			return;
		}
		SteamManager.connectingToServer = false;
		this.FMLHGNJJDEA = SteamAPI.Init();
		if (!this.FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.IPNHHBFPDJK(": ");
			return;
		}
		this.GEIOLGGAMKL = new byte[193];
		this.CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(this.GEIOLGGAMKL, 130, out this.KMDGBKMCCAM);
		Debug.Log("_ScreenResolution");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			base.StartCoroutine(this.LDBKGFDHKFB(1216f));
		}
		base.StartCoroutine(this.DKNKLPLIENK(this.PJOEHKHICFH));
		SteamManager.KGJDHIHOCEI = false;
	}

	// Token: 0x06008603 RID: 34307 RVA: 0x002F0120 File Offset: 0x002EE320
	public static bool EKLAPOPMFBB()
	{
		return SteamManager.BIPJOHJMDJB().FMLHGNJJDEA;
	}

	// Token: 0x06008604 RID: 34308 RVA: 0x002F012C File Offset: 0x002EE32C
	private void EGNGCHJNLOJ(GameWebCallback_t IAFAANLMOAG)
	{
		Debug.Log(string.Concat(new object[]
		{
			"[",
			164,
			" - GameWebCallback] - ",
			IAFAANLMOAG.m_szURL
		}));
	}

	// Token: 0x06008606 RID: 34310 RVA: 0x002F019C File Offset: 0x002EE39C
	public void Awake()
	{
		this.LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(new Callback<GetAuthSessionTicketResponse_t>.DispatchDelegate(this.BIIBADBPGAP));
		if (SteamManager.IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.IEHNBLNFHJI = this;
		if (SteamManager.KGJDHIHOCEI)
		{
			throw new Exception("Tried to Initialize the SteamAPI twice in one session!");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)513510U))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n" + arg, this);
			Application.Quit();
			return;
		}
		SteamManager.connectingToServer = true;
		this.FMLHGNJJDEA = SteamAPI.Init();
		if (!this.FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.DieWithError("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
			return;
		}
		this.GEIOLGGAMKL = new byte[1024];
		this.CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(this.GEIOLGGAMKL, 1024, out this.KMDGBKMCCAM);
		Debug.Log("[SteamManager] Connecting to server");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			base.StartCoroutine(this.LDBKGFDHKFB(1f));
		}
		base.StartCoroutine(this.LDBKGFDHKFB(this.PJOEHKHICFH));
		SteamManager.KGJDHIHOCEI = true;
	}

	// Token: 0x06008607 RID: 34311 RVA: 0x002F0314 File Offset: 0x002EE514
	private IEnumerator FLAPMANCKPJ()
	{
		this.steamTempKey = this.KNFLKCLHDFC(this.GEIOLGGAMKL, (int)this.KMDGBKMCCAM);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", this.steamTempKey);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.authenticateUserTicketURL);
		www = new WWW(url, data);
		yield return www;
		SteamManager.connectingToServer = true;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				SteamManager.connectingToServer = false;
				base.StopCoroutine("LDBKGFDHKFB");
				SteamManager.isKeyVerified = true;
				Singleton<GameManager>.Instance.OnUserVerified(false);
			}
		}
		yield break;
	}

	// Token: 0x06008608 RID: 34312 RVA: 0x002F0120 File Offset: 0x002EE320
	public static bool FJJLGFEBBGC()
	{
		return SteamManager.BIPJOHJMDJB().FMLHGNJJDEA;
	}

	// Token: 0x06008609 RID: 34313 RVA: 0x002F0330 File Offset: 0x002EE530
	private static byte[] IBMECBIONDH(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 3];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 1, array.Length);
		return array;
	}

	// Token: 0x0600860A RID: 34314 RVA: 0x002EFDF7 File Offset: 0x002EDFF7
	private void OMCLOFCJMPG()
	{
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
		if (!this.MEMEGFOKJBG)
		{
			SteamAPI.Shutdown();
			base.enabled = false;
		}
	}

	// Token: 0x0600860B RID: 34315 RVA: 0x002F035D File Offset: 0x002EE55D
	public static SteamManager BCLHIBPDOPP()
	{
		return SteamManager.IEHNBLNFHJI ?? new GameObject("_ScreenResolution").AddComponent<SteamManager>();
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x0600860C RID: 34316 RVA: 0x002F037A File Offset: 0x002EE57A
	public static SteamManager Instance
	{
		get
		{
			return SteamManager.IEHNBLNFHJI ?? new GameObject("SteamManager").AddComponent<SteamManager>();
		}
	}

	// Token: 0x0600860D RID: 34317 RVA: 0x002F0397 File Offset: 0x002EE597
	private void LFDGLCDDHJE(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[6];
		array[1] = "_Value2";
		array[1] = 112;
		array[8] = "[SERVER] Player ";
		array[1] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600860E RID: 34318 RVA: 0x002F03D0 File Offset: 0x002EE5D0
	private void BLNLHBNBKOH()
	{
		if (SteamManager.IEHNBLNFHJI == null)
		{
			SteamManager.IEHNBLNFHJI = this;
		}
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		if (this.PGCMGFLDEFI == null)
		{
			this.PGCMGFLDEFI = new SteamAPIWarningMessageHook_t(SteamManager.IAADBHJGAIO);
			SteamClient.SetWarningMessageHook(this.PGCMGFLDEFI);
		}
		if (SteamManager.BPKAOOLMLNM())
		{
			this.PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.MLLFDFFJDFA));
		}
	}

	// Token: 0x0600860F RID: 34319 RVA: 0x002F0448 File Offset: 0x002EE648
	private string ELDBHCGADCP(byte[] MJDFGEPAAPO, int NIEADDJOIEG)
	{
		byte[] array = MJDFGEPAAPO;
		Array.Resize<byte>(ref array, NIEADDJOIEG);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			byte b = array2[i];
			stringBuilder.AppendFormat("_TimeX", b);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06008610 RID: 34320 RVA: 0x002EFD34 File Offset: 0x002EDF34
	private void MIFCCDEFKNN(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive != 0)
		{
		}
	}

	// Token: 0x06008611 RID: 34321 RVA: 0x002F04A0 File Offset: 0x002EE6A0
	private void NFADJOKFCDL()
	{
		try
		{
			if (!(SteamManager.IEHNBLNFHJI != this))
			{
				SteamManager.IEHNBLNFHJI = null;
				if (this.FMLHGNJJDEA)
				{
					SteamAPI.Shutdown();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06008612 RID: 34322 RVA: 0x002F04F8 File Offset: 0x002EE6F8
	private void FBKDGBINBOO(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == (EResult)0)
		{
			base.StopCoroutine("_Value2");
			Debug.Log("Added checkpoint");
			base.StartCoroutine(this.IGGDDOEPOGM());
		}
	}

	// Token: 0x06008613 RID: 34323 RVA: 0x002EFCDF File Offset: 0x002EDEDF
	private static void IAADBHJGAIO(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	// Token: 0x06008614 RID: 34324 RVA: 0x002F0529 File Offset: 0x002EE729
	private void DLEGGDCNFJM(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[6];
		array[1] = "_U";
		array[0] = -69;
		array[8] = "_Value3";
		array[0] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x06008615 RID: 34325 RVA: 0x002EFCDF File Offset: 0x002EDEDF
	private static void OFFCILPGLOK(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	// Token: 0x06008616 RID: 34326 RVA: 0x001EA8FB File Offset: 0x001E8AFB
	public void GDAEBPDALMO()
	{
		Application.Quit();
	}

	// Token: 0x06008617 RID: 34327 RVA: 0x002F0564 File Offset: 0x002EE764
	private static string DCDCHPNBGPN(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 2];
		Buffer.BlockCopy(JMOJMGEEGKD, 0, array, 0, JMOJMGEEGKD.Length);
		return new string(array);
	}

	// Token: 0x06008618 RID: 34328 RVA: 0x002F058E File Offset: 0x002EE78E
	private void GPKLHJBMMHJ(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == (EResult)0)
		{
			base.StopCoroutine("_Value");
			Debug.Log("Object ID. Case-Sensitive");
			base.StartCoroutine(this.JAMOCIMBCIB());
		}
	}

	// Token: 0x06008619 RID: 34329 RVA: 0x002F05C0 File Offset: 0x002EE7C0
	private static string EPKBHFDIFHG(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 1];
		Buffer.BlockCopy(JMOJMGEEGKD, 0, array, 0, JMOJMGEEGKD.Length);
		return new string(array);
	}

	// Token: 0x0600861A RID: 34330 RVA: 0x002F05EC File Offset: 0x002EE7EC
	private string KNFLKCLHDFC(byte[] MJDFGEPAAPO, int NIEADDJOIEG)
	{
		byte[] array = MJDFGEPAAPO;
		Array.Resize<byte>(ref array, NIEADDJOIEG);
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in array)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600861B RID: 34331 RVA: 0x002F0644 File Offset: 0x002EE844
	private IEnumerator JAMOCIMBCIB()
	{
		this.steamTempKey = this.KNFLKCLHDFC(this.GEIOLGGAMKL, (int)this.KMDGBKMCCAM);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", this.steamTempKey);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.authenticateUserTicketURL);
		www = new WWW(url, data);
		yield return www;
		SteamManager.connectingToServer = true;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				SteamManager.connectingToServer = false;
				base.StopCoroutine("LDBKGFDHKFB");
				SteamManager.isKeyVerified = true;
				Singleton<GameManager>.Instance.OnUserVerified(false);
			}
		}
		yield break;
	}

	// Token: 0x0600861C RID: 34332 RVA: 0x002F0660 File Offset: 0x002EE860
	private static string OPMKPFKLGGE(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 6];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
	}

	// Token: 0x0600861D RID: 34333 RVA: 0x002F068A File Offset: 0x002EE88A
	private void BIIBADBPGAP(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			base.StopCoroutine("MNAMCHHEOFB");
			Debug.Log("[SteamManager] Connection established, authorization");
			base.StartCoroutine(this.MNAMCHHEOFB());
		}
	}

	// Token: 0x0600861E RID: 34334 RVA: 0x002F06BB File Offset: 0x002EE8BB
	private void KCNAGNEENOG(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			base.StopCoroutine("CameraFilterPack/AAA_Super_Computer");
			Debug.Log("_ScreenResolution");
			base.StartCoroutine(this.OKCMHICMJHP());
		}
	}

	// Token: 0x0600861F RID: 34335 RVA: 0x002F0120 File Offset: 0x002EE320
	public static bool KMNLNPEMCPA()
	{
		return SteamManager.BIPJOHJMDJB().FMLHGNJJDEA;
	}

	// Token: 0x06008620 RID: 34336 RVA: 0x002EFDF7 File Offset: 0x002EDFF7
	private void BGDONBMDPGM()
	{
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
		if (!this.MEMEGFOKJBG)
		{
			SteamAPI.Shutdown();
			base.enabled = false;
		}
	}

	// Token: 0x06008622 RID: 34338 RVA: 0x002F06F4 File Offset: 0x002EE8F4
	private void DMDJCGLEHNM()
	{
		try
		{
			if (!(SteamManager.IEHNBLNFHJI != this))
			{
				SteamManager.IEHNBLNFHJI = null;
				if (this.FMLHGNJJDEA)
				{
					SteamAPI.Shutdown();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06008623 RID: 34339 RVA: 0x002F074C File Offset: 0x002EE94C
	public static bool MHNMLMGOGNO()
	{
		return SteamManager.BCLHIBPDOPP().FMLHGNJJDEA;
	}

	// Token: 0x06008624 RID: 34340 RVA: 0x002F0758 File Offset: 0x002EE958
	private void NKPBJHAECIM(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[7];
		array[0] = "[LevelEditorScene] Item creation successful! Published Item ID: ";
		array[1] = -153;
		array[0] = "x";
		array[2] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x06008625 RID: 34341 RVA: 0x002F0794 File Offset: 0x002EE994
	private IEnumerator HALINOACOBN()
	{
		this.steamTempKey = this.KNFLKCLHDFC(this.GEIOLGGAMKL, (int)this.KMDGBKMCCAM);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", this.steamTempKey);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.authenticateUserTicketURL);
		www = new WWW(url, data);
		yield return www;
		SteamManager.connectingToServer = true;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				SteamManager.connectingToServer = false;
				base.StopCoroutine("LDBKGFDHKFB");
				SteamManager.isKeyVerified = true;
				Singleton<GameManager>.Instance.OnUserVerified(false);
			}
		}
		yield break;
	}

	// Token: 0x06008626 RID: 34342 RVA: 0x002F07B0 File Offset: 0x002EE9B0
	public void HCNECNPPEKA()
	{
		this.LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(new Callback<GetAuthSessionTicketResponse_t>.DispatchDelegate(this.GPKLHJBMMHJ));
		if (SteamManager.IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.IEHNBLNFHJI = this;
		if (SteamManager.KGJDHIHOCEI)
		{
			throw new Exception("_Value3");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("#tryagain", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("[MapEditor] Exported to ", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967248U))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("0 - default, 1 - left, 2 - right" + arg, this);
			Application.Quit();
			return;
		}
		SteamManager.connectingToServer = true;
		this.FMLHGNJJDEA = SteamAPI.Init();
		if (!this.FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.JFEOOAIGNLK("id");
			return;
		}
		this.GEIOLGGAMKL = new byte[-143];
		this.CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(this.GEIOLGGAMKL, -200, out this.KMDGBKMCCAM);
		Debug.Log("_Value4");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			base.StartCoroutine(this.IMLLNKFFNFE(1490f));
		}
		base.StartCoroutine(this.DKNKLPLIENK(this.PJOEHKHICFH));
		SteamManager.KGJDHIHOCEI = true;
	}

	// Token: 0x06008627 RID: 34343 RVA: 0x002F0928 File Offset: 0x002EEB28
	private void FABMDEHEDNO()
	{
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		SteamAPI.RunCallbacks();
		if (!this.MEMEGFOKJBG)
		{
			SteamAPI.Shutdown();
			base.enabled = true;
		}
	}

	// Token: 0x06008628 RID: 34344 RVA: 0x002F0954 File Offset: 0x002EEB54
	private IEnumerator OKCMHICMJHP()
	{
		this.steamTempKey = this.KNFLKCLHDFC(this.GEIOLGGAMKL, (int)this.KMDGBKMCCAM);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", this.steamTempKey);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.authenticateUserTicketURL);
		www = new WWW(url, data);
		yield return www;
		SteamManager.connectingToServer = true;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				SteamManager.connectingToServer = false;
				base.StopCoroutine("LDBKGFDHKFB");
				SteamManager.isKeyVerified = true;
				Singleton<GameManager>.Instance.OnUserVerified(false);
			}
		}
		yield break;
	}

	// Token: 0x06008629 RID: 34345 RVA: 0x002F096F File Offset: 0x002EEB6F
	private void EPFIHLJNAOI(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[8];
		array[0] = "settings.selectormapsperpage";
		array[0] = -121;
		array[3] = "GlassesColor2";
		array[1] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600862A RID: 34346 RVA: 0x002F074C File Offset: 0x002EE94C
	public static bool CEIGOIJPONC()
	{
		return SteamManager.BCLHIBPDOPP().FMLHGNJJDEA;
	}

	// Token: 0x0600862B RID: 34347 RVA: 0x002F09A8 File Offset: 0x002EEBA8
	private static byte[] OFFCGDOJOJK(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 2];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	// Token: 0x0600862C RID: 34348 RVA: 0x002F09D8 File Offset: 0x002EEBD8
	private static string FCPKGKFLEGI(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 8];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 0, JMOJMGEEGKD.Length);
		return new string(array);
	}

	// Token: 0x0600862D RID: 34349 RVA: 0x002F0A04 File Offset: 0x002EEC04
	private static byte[] EPKFHOGILNE(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 4];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 0, array.Length);
		return array;
	}

	// Token: 0x0600862E RID: 34350 RVA: 0x002EFD34 File Offset: 0x002EDF34
	private void ICJIHLEJMDB(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive != 0)
		{
		}
	}

	// Token: 0x0600862F RID: 34351 RVA: 0x002F0A34 File Offset: 0x002EEC34
	private IEnumerator MNAMCHHEOFB()
	{
		this.steamTempKey = this.KNFLKCLHDFC(this.GEIOLGGAMKL, (int)this.KMDGBKMCCAM);
		wwwform = new WWWForm();
		wwwform.AddField("ticket", this.steamTempKey);
		data = wwwform.data;
		url = Singleton<GameManager>.Instance.CreateServerURL(this.authenticateUserTicketURL);
		www = new WWW(url, data);
		yield return www;
		SteamManager.connectingToServer = true;
		if (string.IsNullOrEmpty(www.error))
		{
			if (!www.text.ToLower().Contains("error") && !www.text.ToLower().Contains("bad"))
			{
				SteamManager.connectingToServer = false;
				base.StopCoroutine("LDBKGFDHKFB");
				SteamManager.isKeyVerified = true;
				Singleton<GameManager>.Instance.OnUserVerified(false);
			}
		}
		yield break;
	}

	// Token: 0x06008630 RID: 34352 RVA: 0x002F0A50 File Offset: 0x002EEC50
	private static string OAJDHGHAPMF(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 5];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
	}

	// Token: 0x06008631 RID: 34353 RVA: 0x002F0A7A File Offset: 0x002EEC7A
	public static SteamManager FFDNHKHOPBG()
	{
		return SteamManager.IEHNBLNFHJI ?? new GameObject("/").AddComponent<SteamManager>();
	}

	// Token: 0x06008632 RID: 34354 RVA: 0x002F0A98 File Offset: 0x002EEC98
	private static byte[] GMKGLDIJMFN(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 1];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 1, array.Length);
		return array;
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06008633 RID: 34355 RVA: 0x002F0AC5 File Offset: 0x002EECC5
	public static bool Initialized
	{
		get
		{
			return SteamManager.Instance.FMLHGNJJDEA;
		}
	}

	// Token: 0x06008634 RID: 34356 RVA: 0x002F0AD4 File Offset: 0x002EECD4
	public void BMAGFLLGDPJ()
	{
		this.LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(new Callback<GetAuthSessionTicketResponse_t>.DispatchDelegate(this.GPKLHJBMMHJ));
		if (SteamManager.IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.IEHNBLNFHJI = this;
		if (SteamManager.KGJDHIHOCEI)
		{
			throw new Exception("_Value2");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("MenuScene", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("_BlurTexture", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967222U))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("#rt" + arg, this);
			Application.Quit();
			return;
		}
		SteamManager.connectingToServer = false;
		this.FMLHGNJJDEA = SteamAPI.Init();
		if (!this.FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.IPNHHBFPDJK("_Saturation");
			return;
		}
		this.GEIOLGGAMKL = new byte[-78];
		this.CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(this.GEIOLGGAMKL, -42, out this.KMDGBKMCCAM);
		Debug.Log("PUNCloudBestRegion");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			base.StartCoroutine(this.DKNKLPLIENK(271f));
		}
		base.StartCoroutine(this.JGOOHEBBDBF(this.PJOEHKHICFH));
		SteamManager.KGJDHIHOCEI = true;
	}

	// Token: 0x06008635 RID: 34357 RVA: 0x002F0AC5 File Offset: 0x002EECC5
	public static bool BPKAOOLMLNM()
	{
		return SteamManager.Instance.FMLHGNJJDEA;
	}

	// Token: 0x06008636 RID: 34358 RVA: 0x002F0C4C File Offset: 0x002EEE4C
	private void OnDestroy()
	{
		try
		{
			if (!(SteamManager.IEHNBLNFHJI != this))
			{
				SteamManager.IEHNBLNFHJI = null;
				if (this.FMLHGNJJDEA)
				{
					SteamAPI.Shutdown();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06008637 RID: 34359 RVA: 0x002F0CA4 File Offset: 0x002EEEA4
	private void LLDBPKHDPKI()
	{
		if (SteamManager.IEHNBLNFHJI == null)
		{
			SteamManager.IEHNBLNFHJI = this;
		}
		if (!this.FMLHGNJJDEA)
		{
			return;
		}
		if (this.PGCMGFLDEFI == null)
		{
			this.PGCMGFLDEFI = new SteamAPIWarningMessageHook_t(SteamManager.KHJPJOCKGCA);
			SteamClient.SetWarningMessageHook(this.PGCMGFLDEFI);
		}
		if (SteamManager.Initialized)
		{
			this.PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.EHDLHBEEHFB));
		}
	}

	// Token: 0x06008638 RID: 34360 RVA: 0x002F0D1C File Offset: 0x002EEF1C
	private static string OKLKGCDJDFL(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 4];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
	}

	// Token: 0x06008639 RID: 34361 RVA: 0x002F0D46 File Offset: 0x002EEF46
	public static SteamManager BIPJOHJMDJB()
	{
		return SteamManager.IEHNBLNFHJI ?? new GameObject("[SERVER] Player ").AddComponent<SteamManager>();
	}

	// Token: 0x0600863A RID: 34362 RVA: 0x002F0D64 File Offset: 0x002EEF64
	public void GGHEPDCEHCK()
	{
		this.LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(new Callback<GetAuthSessionTicketResponse_t>.DispatchDelegate(this.KCNAGNEENOG));
		if (SteamManager.IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SteamManager.IEHNBLNFHJI = this;
		if (SteamManager.KGJDHIHOCEI)
		{
			throw new Exception("LoadingStatusText");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("ScrollPanel", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)21U))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException arg)
		{
			Debug.LogError("CameraFilterPack/AAA_Blood_Hit" + arg, this);
			Application.Quit();
			return;
		}
		SteamManager.connectingToServer = true;
		this.FMLHGNJJDEA = SteamAPI.Init();
		if (!this.FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.DieWithError(",");
			return;
		}
		this.GEIOLGGAMKL = new byte[99];
		this.CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(this.GEIOLGGAMKL, -163, out this.KMDGBKMCCAM);
		Debug.Log("SpawnObj");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			base.StartCoroutine(this.DKNKLPLIENK(759f));
		}
		base.StartCoroutine(this.JGOOHEBBDBF(this.PJOEHKHICFH));
		SteamManager.KGJDHIHOCEI = true;
	}

	// Token: 0x0600863B RID: 34363 RVA: 0x002F0EDC File Offset: 0x002EF0DC
	public static SteamManager IKBFAFODKLE()
	{
		return SteamManager.IEHNBLNFHJI ?? new GameObject("LoadingStatusText").AddComponent<SteamManager>();
	}

	// Token: 0x0600863C RID: 34364 RVA: 0x002EFD34 File Offset: 0x002EDF34
	private void EHDLHBEEHFB(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive != 0)
		{
		}
	}

	// Token: 0x04000F8B RID: 3979
	private byte[] GEIOLGGAMKL;

	// Token: 0x04000F8C RID: 3980
	private uint KMDGBKMCCAM;

	// Token: 0x04000F8D RID: 3981
	private HAuthTicket CHMKJCDEAEM;

	// Token: 0x04000F8E RID: 3982
	[HideInInspector]
	public ObscuredString steamTempKey = string.Empty;

	// Token: 0x04000F8F RID: 3983
	private float PJOEHKHICFH = 60f;

	// Token: 0x04000F90 RID: 3984
	protected Callback<GetAuthSessionTicketResponse_t> LIPLGELHGAD;

	// Token: 0x04000F91 RID: 3985
	private bool MEMEGFOKJBG = true;

	// Token: 0x04000F92 RID: 3986
	public static bool connectingToServer = true;

	// Token: 0x04000F93 RID: 3987
	public static bool isKeyVerified;

	// Token: 0x04000F94 RID: 3988
	private static SteamManager IEHNBLNFHJI;

	// Token: 0x04000F95 RID: 3989
	protected Callback<GameOverlayActivated_t> PJDOHKKDBML;

	// Token: 0x04000F96 RID: 3990
	private static bool KGJDHIHOCEI;

	// Token: 0x04000F97 RID: 3991
	private bool FMLHGNJJDEA;

	// Token: 0x04000F98 RID: 3992
	private SteamAPIWarningMessageHook_t PGCMGFLDEFI;

	// Token: 0x04000F99 RID: 3993
	public string authenticateUserTicketURL = "???";
}
