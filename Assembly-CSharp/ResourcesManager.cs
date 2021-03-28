using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Steamworks;
using UnityEngine;

// Token: 0x02000455 RID: 1109
public class ResourcesManager : Singleton<ResourcesManager>
{
	// Token: 0x0600FD22 RID: 64802 RVA: 0x0056CE51 File Offset: 0x0056B051
	public static void UnloadResources(bool HHPGCLIABFM = false)
	{
		Debug.Log("[ResourcesManager] Unloading data resources");
		Singleton<MapsSystem>.Instance.UnloadResources();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD23 RID: 64803 RVA: 0x0056CE81 File Offset: 0x0056B081
	public new void NLNAJMCBNDC()
	{
		base.Awake();
		UnityThread.BKHHLIBLFHB(true);
	}

	// Token: 0x0600FD24 RID: 64804 RVA: 0x0056CE90 File Offset: 0x0056B090
	public IEnumerator GCBLGJAEFMO(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				WWW www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD25 RID: 64805 RVA: 0x0056CED0 File Offset: 0x0056B0D0
	public static string LEKJAGAKEAM(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (!Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			return null;
		}
		if (!BPFPNAJGGCO)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
		}
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "request" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK();
		}
		return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_OcclusionTexture";
	}

	// Token: 0x0600FD26 RID: 64806 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void PEJANHIKFAE()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD27 RID: 64807 RVA: 0x0056CF74 File Offset: 0x0056B174
	public static string MFBHOGHAPHA(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ(), DPGCGEPHEGF));
			string[] array = new string[4];
			array[1] = "_Amount";
			array[1] = text;
			array[5] = "RecordButton";
			array[4] = ResourcesManager.OHAGJGNCAPN(HFEFHOPOLIK, true);
			array[8] = "#savemapchanges?";
			return string.Concat(array);
		}
		return ResourcesManager.LEKJAGAKEAM(HFEFHOPOLIK, true);
	}

	// Token: 0x0600FD28 RID: 64808 RVA: 0x0056CFE0 File Offset: 0x0056B1E0
	public static string NCPKEIIHELP(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).INIGKHLOKCD(), DPGCGEPHEGF));
			string[] array = new string[6];
			array[1] = "{0}";
			array[1] = text;
			array[8] = "grid";
			array[8] = ResourcesManager.GetLoadedSteamPlayername(HFEFHOPOLIK, false);
			array[8] = "_Level";
			return string.Concat(array);
		}
		return ResourcesManager.OHKHAFCNHEI(HFEFHOPOLIK, false);
	}

	// Token: 0x0600FD29 RID: 64809 RVA: 0x0056D04C File Offset: 0x0056B24C
	public IEnumerator BHKHPBMNHII(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			AudioClip audioClip = null;
			WWW www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD2A RID: 64810 RVA: 0x0056D084 File Offset: 0x0056B284
	public IEnumerator MBPLPLALPPM(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			Texture2D texture2D = null;
			Sprite value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				byte[] data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD2B RID: 64811 RVA: 0x0056D0BC File Offset: 0x0056B2BC
	public IEnumerator MAHLBHNLJFE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD2C RID: 64812 RVA: 0x0056D0F4 File Offset: 0x0056B2F4
	public IEnumerator PFGCBPOFDBK(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".png"))
		{
			yield return base.StartCoroutine(this.LoadSprite(HFEFHOPOLIK, directory + ".png", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".jpg"))
		{
			yield return base.StartCoroutine(this.LoadSprite(HFEFHOPOLIK, directory + ".jpg", true, AAGGLAGLINL));
		}
		yield break;
	}

	// Token: 0x0600FD2D RID: 64813 RVA: 0x0056D124 File Offset: 0x0056B324
	public IEnumerator KIFCGIBEHDD(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			int largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			Texture2D steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			Sprite value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD2E RID: 64814 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void ENCOHKLHOLD()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD2F RID: 64815 RVA: 0x0056D150 File Offset: 0x0056B350
	public IEnumerator KJHIIEDCHDD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD30 RID: 64816 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void EKBAAGELBNJ()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD31 RID: 64817 RVA: 0x0056D188 File Offset: 0x0056B388
	public IEnumerator LLBIBFHAOKB(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			string friendPersonaName = SteamFriends.GetFriendPersonaName(GDOHPDHLPBC);
			if (this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.NJFPKGJNKJE[GDOHPDHLPBC] = friendPersonaName;
				}
			}
			else
			{
				this.NJFPKGJNKJE.Add(GDOHPDHLPBC, friendPersonaName);
			}
		}
		yield break;
	}

	// Token: 0x0600FD32 RID: 64818 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void MOPPDDJHAIK()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD33 RID: 64819 RVA: 0x0056D1B4 File Offset: 0x0056B3B4
	public IEnumerator MDPBPNAFGNE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD34 RID: 64820 RVA: 0x0056D1EC File Offset: 0x0056B3EC
	public IEnumerator ICKJFFAMCCF(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD35 RID: 64821 RVA: 0x0056D215 File Offset: 0x0056B415
	public static void HLOKBICFAOM(bool HHPGCLIABFM = false)
	{
		Debug.Log("No");
		Singleton<MapsSystem>.Instance.EKGELAAIOCD();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD36 RID: 64822 RVA: 0x0056D248 File Offset: 0x0056B448
	public IEnumerator FIPHHGFCINL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD37 RID: 64823 RVA: 0x0056D288 File Offset: 0x0056B488
	public IEnumerator LoadSkinSprite(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".png"))
		{
			yield return base.StartCoroutine(this.LoadSprite(HFEFHOPOLIK, directory + ".png", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".jpg"))
		{
			yield return base.StartCoroutine(this.LoadSprite(HFEFHOPOLIK, directory + ".jpg", true, AAGGLAGLINL));
		}
		yield break;
	}

	// Token: 0x0600FD38 RID: 64824 RVA: 0x0056D2B8 File Offset: 0x0056B4B8
	public IEnumerator MBOGAKPAOHA(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		string directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL, true));
		}
		yield break;
	}

	// Token: 0x0600FD39 RID: 64825 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600FD3A RID: 64826 RVA: 0x0056D2E8 File Offset: 0x0056B4E8
	public static string HKPEOFEEANL(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).place, DPGCGEPHEGF));
			string[] array = new string[4];
			array[0] = "mapselector.filter.favoriteonly";
			array[1] = text;
			array[7] = "_Value10";
			array[2] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[2] = "Set particless emission (glow)";
			return string.Concat(array);
		}
		return null;
	}

	// Token: 0x0600FD3B RID: 64827 RVA: 0x0056D36A File Offset: 0x0056B56A
	public new void Awake()
	{
		base.Awake();
		UnityThread.initUnityThread(false);
	}

	// Token: 0x0600FD3C RID: 64828 RVA: 0x0056D378 File Offset: 0x0056B578
	public IEnumerator GHNEEKFKDJD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD3D RID: 64829 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void BDBODDGIPBM()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD3E RID: 64830 RVA: 0x0056D3B8 File Offset: 0x0056B5B8
	public IEnumerator DOBLPCGMLLI(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL, true));
		}
		yield break;
	}

	// Token: 0x0600FD3F RID: 64831 RVA: 0x0056D3E8 File Offset: 0x0056B5E8
	public IEnumerator GPDFPHOKOBJ(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD40 RID: 64832 RVA: 0x0056D428 File Offset: 0x0056B628
	public void BJIDLJJJCJB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string value = string.Empty;
			if (File.Exists(fullName))
			{
				value = File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("Connection error: ");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
	}

	// Token: 0x0600FD41 RID: 64833 RVA: 0x0056D4C8 File Offset: 0x0056B6C8
	public IEnumerator KFCCIEAKCCG(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD42 RID: 64834 RVA: 0x0056D500 File Offset: 0x0056B700
	public static object AHLMDJKOFJJ(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD43 RID: 64835 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void BPNDDNKKFDD()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD44 RID: 64836 RVA: 0x0056D52C File Offset: 0x0056B72C
	public void PHOHPPPOMPE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string value = string.Empty;
			if (File.Exists(fullName))
			{
				value = File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("_Value2");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
	}

	// Token: 0x0600FD45 RID: 64837 RVA: 0x0056D5CC File Offset: 0x0056B7CC
	public IEnumerator JKMHPMJJFGE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD46 RID: 64838 RVA: 0x0056D60C File Offset: 0x0056B80C
	public IEnumerator JIEBOOFHIPI(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			texture2D = null;
			value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD47 RID: 64839 RVA: 0x0056D644 File Offset: 0x0056B844
	public static string HCPCLINEDDD(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KLOEHDOKBBO(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IEOGJOLGLFI(), DPGCGEPHEGF));
			string[] array = new string[0];
			array[0] = "#close";
			array[1] = text;
			array[0] = "_Blue_C";
			array[7] = ResourcesManager.OHAGJGNCAPN(HFEFHOPOLIK, true);
			array[3] = "Joystick1Button7";
			return string.Concat(array);
		}
		return ResourcesManager.OHAGJGNCAPN(HFEFHOPOLIK, true);
	}

	// Token: 0x0600FD48 RID: 64840 RVA: 0x0056D6B0 File Offset: 0x0056B8B0
	public IEnumerator EGJMDKANHKD(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			texture2D = null;
			value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD49 RID: 64841 RVA: 0x0056D6E8 File Offset: 0x0056B8E8
	public void IPJENEAMGBP()
	{
		base.Awake();
		UnityThread.OJGBGHJPNKE(false);
	}

	// Token: 0x0600FD4A RID: 64842 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void OnDestroy()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD4B RID: 64843 RVA: 0x0056D6F8 File Offset: 0x0056B8F8
	public IEnumerator LoadSkinSound(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL, true));
		}
		yield break;
	}

	// Token: 0x0600FD4C RID: 64844 RVA: 0x0056D728 File Offset: 0x0056B928
	public static Sprite OPBBEMMCIAK(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD4D RID: 64845 RVA: 0x0056D754 File Offset: 0x0056B954
	public static string MDDNCHKAMDI(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK(), DPGCGEPHEGF));
			string[] array = new string[8];
			array[1] = "AudioSampler";
			array[1] = text;
			array[6] = " scene view IDs from last level.";
			array[1] = ResourcesManager.GetLoadedSteamPlayername(HFEFHOPOLIK, true);
			array[0] = "CameraFilterPack/Blur_Movie";
			return string.Concat(array);
		}
		return ResourcesManager.OHKHAFCNHEI(HFEFHOPOLIK, true);
	}

	// Token: 0x0600FD4E RID: 64846 RVA: 0x0056D7C0 File Offset: 0x0056B9C0
	public IEnumerator PGNIHBOAGHB(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD4F RID: 64847 RVA: 0x0056D7EC File Offset: 0x0056B9EC
	public IEnumerator LBOPDMAJOPL(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD50 RID: 64848 RVA: 0x0056D818 File Offset: 0x0056BA18
	public IEnumerator LoadAudio(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD51 RID: 64849 RVA: 0x0056D858 File Offset: 0x0056BA58
	public IEnumerator NBGIBFPLHMB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			texture2D = null;
			value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD52 RID: 64850 RVA: 0x0056D890 File Offset: 0x0056BA90
	public IEnumerator NKHHGDFAJMC(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD53 RID: 64851 RVA: 0x0056D8BC File Offset: 0x0056BABC
	public IEnumerator AECGMKHBLCF(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD54 RID: 64852 RVA: 0x0056D8E8 File Offset: 0x0056BAE8
	public void DMKMCEMNCDN(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string text = string.Empty;
			if (File.Exists(fullName))
			{
				bool flag = true;
				string[] array = File.ReadAllLines(fullName);
				for (int i = 1; i < array.Length; i += 0)
				{
					string str = array[i];
					if (flag)
					{
						text = text + str + "nogamesfound" + Environment.NewLine;
						flag = false;
					}
					else
					{
						text = text + str + "_Value" + Environment.NewLine;
					}
				}
				File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("&");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = text;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, text);
			}
		}
	}

	// Token: 0x0600FD55 RID: 64853 RVA: 0x0056D9E0 File Offset: 0x0056BBE0
	public static string DOILNLEFLAP(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (!Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			return null;
		}
		if (!BPFPNAJGGCO)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
		}
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_Value4" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK();
		}
		return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_Value2";
	}

	// Token: 0x0600FD56 RID: 64854 RVA: 0x0056DA6C File Offset: 0x0056BC6C
	public void LoadTextWithLocalizationFix(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string text = string.Empty;
			if (File.Exists(fullName))
			{
				bool flag = true;
				foreach (string str in File.ReadAllLines(fullName))
				{
					if (flag)
					{
						text = text + str + ",viewkeys" + Environment.NewLine;
						flag = false;
					}
					else
					{
						text = text + str + "," + Environment.NewLine;
					}
				}
				File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load text error: not found");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = text;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, text);
			}
		}
	}

	// Token: 0x0600FD57 RID: 64855 RVA: 0x0056DB64 File Offset: 0x0056BD64
	public static string OHAGJGNCAPN(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (!Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			return null;
		}
		if (!BPFPNAJGGCO)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
		}
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "1" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).CJILPHFNMEB();
		}
		return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_LightIntensity";
	}

	// Token: 0x0600FD58 RID: 64856 RVA: 0x0056D728 File Offset: 0x0056B928
	public static Sprite GetLoadedAvatar(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD59 RID: 64857 RVA: 0x0056D728 File Offset: 0x0056B928
	public static Sprite HGGKKHGCBLB(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD5A RID: 64858 RVA: 0x0056DBF0 File Offset: 0x0056BDF0
	public IEnumerator BCBEFJCHFKG(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD5B RID: 64859 RVA: 0x0056D500 File Offset: 0x0056B700
	public static object HIILLNPNNOB(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD5C RID: 64860 RVA: 0x0056DC28 File Offset: 0x0056BE28
	public static string GetLoadedSteamPlayernameColored(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).place, DPGCGEPHEGF));
			return string.Concat(new string[]
			{
				"<color=#",
				text,
				">",
				Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK],
				"</color>"
			});
		}
		return null;
	}

	// Token: 0x0600FD5D RID: 64861 RVA: 0x0056DCAC File Offset: 0x0056BEAC
	public IEnumerator OEGHEPEDNEJ(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			texture2D = null;
			value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD5E RID: 64862 RVA: 0x0056DCE4 File Offset: 0x0056BEE4
	public void DOOMEMNGMEB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string value = string.Empty;
			if (File.Exists(fullName))
			{
				value = File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("yyyy");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
	}

	// Token: 0x0600FD5F RID: 64863 RVA: 0x0056DD81 File Offset: 0x0056BF81
	public static void NHMEEOHGELO(bool HHPGCLIABFM = false)
	{
		Debug.Log("shader.crispwinter");
		Singleton<MapsSystem>.Instance.ACNJBGOIDDJ();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD60 RID: 64864 RVA: 0x0056DDB4 File Offset: 0x0056BFB4
	public IEnumerator CIPGEHCPCJO(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			friendPersonaName = SteamFriends.GetFriendPersonaName(GDOHPDHLPBC);
			if (this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.NJFPKGJNKJE[GDOHPDHLPBC] = friendPersonaName;
				}
			}
			else
			{
				this.NJFPKGJNKJE.Add(GDOHPDHLPBC, friendPersonaName);
			}
		}
		yield break;
	}

	// Token: 0x0600FD61 RID: 64865 RVA: 0x0056DDE0 File Offset: 0x0056BFE0
	public IEnumerator CHNPOFKMOLG(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".png"))
		{
			yield return base.StartCoroutine(this.LoadSprite(HFEFHOPOLIK, directory + ".png", true, AAGGLAGLINL));
		}
		if (File.Exists(directory + ".jpg"))
		{
			yield return base.StartCoroutine(this.LoadSprite(HFEFHOPOLIK, directory + ".jpg", true, AAGGLAGLINL));
		}
		yield break;
	}

	// Token: 0x0600FD62 RID: 64866 RVA: 0x0056DE10 File Offset: 0x0056C010
	public static string JDFOIINPHIO(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).INIGKHLOKCD(), DPGCGEPHEGF));
			string[] array = new string[2];
			array[0] = "[LevelEditorScene] Error: Timeout :S";
			array[0] = text;
			array[7] = " {0}";
			array[3] = ResourcesManager.OHKHAFCNHEI(HFEFHOPOLIK, true);
			array[5] = "menu.enableselectormusic";
			return string.Concat(array);
		}
		return ResourcesManager.DOILNLEFLAP(HFEFHOPOLIK, true);
	}

	// Token: 0x0600FD63 RID: 64867 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void MLGEBJGBGCO()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD64 RID: 64868 RVA: 0x0056DE7C File Offset: 0x0056C07C
	public static string JOPMKDDJGCD(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KLOEHDOKBBO(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IEOGJOLGLFI(), DPGCGEPHEGF));
			string[] array = new string[4];
			array[1] = "Arc";
			array[1] = text;
			array[3] = "EventSystem";
			array[8] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[3] = "[PlayerController] ";
			return string.Concat(array);
		}
		return null;
	}

	// Token: 0x0600FD65 RID: 64869 RVA: 0x0056DF00 File Offset: 0x0056C100
	public IEnumerator CCGBNECFAEM(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD66 RID: 64870 RVA: 0x0056D500 File Offset: 0x0056B700
	public static object OPIGIBCFLHE(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD67 RID: 64871 RVA: 0x0056DF38 File Offset: 0x0056C138
	public IEnumerator IOJAJLNJGFB(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD68 RID: 64872 RVA: 0x0056DF64 File Offset: 0x0056C164
	public IEnumerator JCJHJEHJNCP(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD69 RID: 64873 RVA: 0x0056D500 File Offset: 0x0056B700
	public static object PJALIBGIPPH(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD6A RID: 64874 RVA: 0x0056DFA4 File Offset: 0x0056C1A4
	public IEnumerator LGIPNJDBEHP(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD6B RID: 64875 RVA: 0x0056DFDC File Offset: 0x0056C1DC
	public static void LPLEGICIAAN(bool HHPGCLIABFM = false)
	{
		Debug.Log("_Value2");
		Singleton<MapsSystem>.Instance.UnloadResources();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD6C RID: 64876 RVA: 0x0056E00C File Offset: 0x0056C20C
	public static string BLGCOKFPGOD(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).CJILPHFNMEB(), DPGCGEPHEGF));
			string[] array = new string[7];
			array[1] = "MapConfig";
			array[1] = text;
			array[2] = "_Size";
			array[7] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[8] = ". No ViewIDs are free to use. Max is: ";
			return string.Concat(array);
		}
		return null;
	}

	// Token: 0x0600FD6D RID: 64877 RVA: 0x0056E090 File Offset: 0x0056C290
	public static string OHKHAFCNHEI(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (!Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			return null;
		}
		if (!BPFPNAJGGCO)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
		}
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "GameVolumeSlider" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ();
		}
		return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "_Value3";
	}

	// Token: 0x0600FD6E RID: 64878 RVA: 0x0056D728 File Offset: 0x0056B928
	public static Sprite DOAJDBODKBF(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD6F RID: 64879 RVA: 0x0056E11C File Offset: 0x0056C31C
	public static string CNAEIKOJBLH(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IGKJJMCLABK(), DPGCGEPHEGF));
			string[] array = new string[4];
			array[0] = "SetPlayerDistance";
			array[1] = text;
			array[8] = "CameraFilterPack/Blend2Camera_Exclusion";
			array[7] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[7] = "_TimeX";
			return string.Concat(array);
		}
		return null;
	}

	// Token: 0x0600FD70 RID: 64880 RVA: 0x0056E1A0 File Offset: 0x0056C3A0
	public IEnumerator LoadSpriteFromURL(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			Sprite sprite = null;
			WWW www = new WWW(NBEBMKFPBEP);
			yield return www;
			if (string.IsNullOrEmpty(www.error))
			{
				Texture2D texture2D = new Texture2D(2, 2);
				www.LoadImageIntoTexture(texture2D);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				sprite = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
				yield return sprite;
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + www.error + " url: " + NBEBMKFPBEP);
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = sprite;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, sprite);
			}
		}
		yield break;
	}

	// Token: 0x0600FD71 RID: 64881 RVA: 0x0056E1D0 File Offset: 0x0056C3D0
	public IEnumerator BJFBHDDLPDG(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD72 RID: 64882 RVA: 0x0056E1FC File Offset: 0x0056C3FC
	public IEnumerator LoadSprite(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			texture2D = null;
			value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD73 RID: 64883 RVA: 0x0056E234 File Offset: 0x0056C434
	public IEnumerator LoadSteamPlayername(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			friendPersonaName = SteamFriends.GetFriendPersonaName(GDOHPDHLPBC);
			if (this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.NJFPKGJNKJE[GDOHPDHLPBC] = friendPersonaName;
				}
			}
			else
			{
				this.NJFPKGJNKJE.Add(GDOHPDHLPBC, friendPersonaName);
			}
		}
		yield break;
	}

	// Token: 0x0600FD74 RID: 64884 RVA: 0x0056E260 File Offset: 0x0056C460
	public IEnumerator PMBNLPKDPJK(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD75 RID: 64885 RVA: 0x0056E2A0 File Offset: 0x0056C4A0
	public static string IPFFGAILCED(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ(), DPGCGEPHEGF));
			string[] array = new string[0];
			array[0] = "/";
			array[1] = text;
			array[1] = "menu.enableselectormusic";
			array[0] = ResourcesManager.DOILNLEFLAP(HFEFHOPOLIK, true);
			array[6] = "[LocalizationService] Error: ";
			return string.Concat(array);
		}
		return ResourcesManager.GetLoadedSteamPlayername(HFEFHOPOLIK, true);
	}

	// Token: 0x0600FD76 RID: 64886 RVA: 0x0056D728 File Offset: 0x0056B928
	public static Sprite JLJNIDMBOIA(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD77 RID: 64887 RVA: 0x0056E30C File Offset: 0x0056C50C
	public IEnumerator BOMAKJAMCJH(string HFEFHOPOLIK, string NBEBMKFPBEP, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			sprite = null;
			www = new WWW(NBEBMKFPBEP);
			yield return www;
			if (string.IsNullOrEmpty(www.error))
			{
				texture2D = new Texture2D(2, 2);
				www.LoadImageIntoTexture(texture2D);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				sprite = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
				yield return sprite;
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + www.error + " url: " + NBEBMKFPBEP);
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = sprite;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, sprite);
			}
		}
		yield break;
	}

	// Token: 0x0600FD78 RID: 64888 RVA: 0x0056D500 File Offset: 0x0056B700
	public static object GetLoadedResource(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD79 RID: 64889 RVA: 0x0056E33C File Offset: 0x0056C53C
	public void LoadText(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string value = string.Empty;
			if (File.Exists(fullName))
			{
				value = File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load text error: not found");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
	}

	// Token: 0x0600FD7A RID: 64890 RVA: 0x0056E3DC File Offset: 0x0056C5DC
	public static string GetLoadedSteamPlayernameWithColoredRank(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).place, DPGCGEPHEGF));
			return string.Concat(new string[]
			{
				"<color=#",
				text,
				">",
				ResourcesManager.GetLoadedSteamPlayername(HFEFHOPOLIK, true),
				"</color>"
			});
		}
		return ResourcesManager.GetLoadedSteamPlayername(HFEFHOPOLIK, true);
	}

	// Token: 0x0600FD7B RID: 64891 RVA: 0x0056D728 File Offset: 0x0056B928
	public static Sprite KPCAOFDFNOD(CSteamID HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.ANAALDPGPOA.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.ANAALDPGPOA[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD7C RID: 64892 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void PGAPACGPCGJ()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD7D RID: 64893 RVA: 0x0056E448 File Offset: 0x0056C648
	public IEnumerator FIHHHOKFBFL(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			texture2D = null;
			value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD7E RID: 64894 RVA: 0x0056E480 File Offset: 0x0056C680
	public IEnumerator PreloadAudio(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD7F RID: 64895 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600FD80 RID: 64896 RVA: 0x0056E4B8 File Offset: 0x0056C6B8
	public IEnumerator AECCOKBCDAN(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false, bool ONHDMKDAANN = true)
	{
		hmljmlimjmp = new ResourcesManager.OANOFHAPHDD.HMLJMLIMJMP();
		hmljmlimjmp.FJLABOBOHMN = this;
		hmljmlimjmp.BNJFKKGOACF = BNJFKKGOACF;
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			glhbcgjfbhl = new ResourcesManager.OANOFHAPHDD.GLHBCGJFBHL();
			glhbcgjfbhl.FJLABOBOHMN = this;
			glhbcgjfbhl.LKGMEEPNEDL = hmljmlimjmp;
			if (!NFJAJLPOOCA)
			{
				hmljmlimjmp.BNJFKKGOACF = Helpers.GetDirectory(hmljmlimjmp.BNJFKKGOACF);
			}
			glhbcgjfbhl.LPEOPOBBFNB = null;
			if (new FileInfo(hmljmlimjmp.BNJFKKGOACF).Extension.ToLower() != ".mp3")
			{
				www = new WWW("file://" + hmljmlimjmp.BNJFKKGOACF);
				yield return www;
				if (!string.IsNullOrEmpty(www.error))
				{
					Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
				}
				else
				{
					glhbcgjfbhl.LPEOPOBBFNB = www.GetAudioClip(false, ONHDMKDAANN);
					yield return glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(glhbcgjfbhl.GBKBDKHPLKG));
				yield return new WaitUntil(new Func<bool>(glhbcgjfbhl.HMMBBDJNGGL));
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = glhbcgjfbhl.LPEOPOBBFNB;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, glhbcgjfbhl.LPEOPOBBFNB);
			}
		}
		yield break;
	}

	// Token: 0x0600FD81 RID: 64897 RVA: 0x0056E4F8 File Offset: 0x0056C6F8
	public static void AELGANHMGBD(bool HHPGCLIABFM = false)
	{
		Debug.Log("maphash");
		Singleton<MapsSystem>.Instance.ACNJBGOIDDJ();
		Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD82 RID: 64898 RVA: 0x0056E528 File Offset: 0x0056C728
	public static string GetLoadedSteamPlayername(CSteamID HFEFHOPOLIK, bool BPFPNAJGGCO = true)
	{
		if (!Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			return null;
		}
		if (!BPFPNAJGGCO)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
		}
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "#" + RanksSystem.GetLoadedRank(HFEFHOPOLIK).place;
		}
		return Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK] + "#TBD";
	}

	// Token: 0x0600FD83 RID: 64899 RVA: 0x0056E5B4 File Offset: 0x0056C7B4
	public static string ALCCOCOFLAK(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null)
		{
			string text = Helpers.ColorToHex(RanksSystem.GetRankColor(RanksSystem.GetLoadedRank(HFEFHOPOLIK).JCDLILAFFAJ(), DPGCGEPHEGF));
			string[] array = new string[3];
			array[0] = "_SearchTex";
			array[1] = text;
			array[0] = "[LevelEditorScene] Reloaded config for \"";
			array[6] = ResourcesManager.LEKJAGAKEAM(HFEFHOPOLIK, false);
			array[8] = "LevelNameText";
			return string.Concat(array);
		}
		return ResourcesManager.GetLoadedSteamPlayername(HFEFHOPOLIK, true);
	}

	// Token: 0x0600FD84 RID: 64900 RVA: 0x0056E620 File Offset: 0x0056C820
	public IEnumerator GLPHAEGKPNB(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			texture2D = null;
			value = null;
			if (File.Exists(BNJFKKGOACF))
			{
				data = File.ReadAllBytes(BNJFKKGOACF);
				texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(data);
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.filterMode = FilterMode.Bilinear;
				value = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			}
			else
			{
				Debug.LogWarning("[ResourcesManager] Load image error: " + BNJFKKGOACF + " not found");
				yield return null;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD85 RID: 64901 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void GKAJONDPPGI()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD86 RID: 64902 RVA: 0x0056E658 File Offset: 0x0056C858
	public void LMEDNIKJMGM(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string text = string.Empty;
			if (File.Exists(fullName))
			{
				bool flag = true;
				string[] array = File.ReadAllLines(fullName);
				for (int i = 1; i < array.Length; i += 0)
				{
					string str = array[i];
					if (flag)
					{
						text = text + str + "Joystick1Button" + Environment.NewLine;
						flag = true;
					}
					else
					{
						text = text + str + "Image" + Environment.NewLine;
					}
				}
				File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("_XCrop");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = text;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, text);
			}
		}
	}

	// Token: 0x0600FD87 RID: 64903 RVA: 0x0056E750 File Offset: 0x0056C950
	public IEnumerator ECAEKKEKBDF(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			audioClip = null;
			www = new WWW("file://" + BNJFKKGOACF);
			yield return www;
			if (!string.IsNullOrEmpty(www.error))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + www.error);
			}
			else
			{
				audioClip = www.GetAudioClip(false, true);
				yield return audioClip;
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = audioClip;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, audioClip);
			}
		}
		yield break;
	}

	// Token: 0x0600FD88 RID: 64904 RVA: 0x0056E788 File Offset: 0x0056C988
	public IEnumerator BPKADDLMNLN(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL, true));
		}
		yield break;
	}

	// Token: 0x0600FD89 RID: 64905 RVA: 0x0056CF5B File Offset: 0x0056B15B
	private void DOFKFBFNNNO()
	{
		this.EPLOIIAGDDM.Clear();
		GC.Collect();
		Resources.UnloadUnusedAssets();
	}

	// Token: 0x0600FD8A RID: 64906 RVA: 0x0056E7B8 File Offset: 0x0056C9B8
	public IEnumerator NGEGINCDLIJ(string HFEFHOPOLIK, string BNJFKKGOACF, bool AAGGLAGLINL = false)
	{
		directory = Helpers.GetDirectory("Data/Skins/" + Singleton<SaveSystem>.Instance.GetString("settings.customdataskin", "default", null) + "/" + BNJFKKGOACF);
		if (File.Exists(directory + ".wav"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".wav", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".ogg"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".ogg", true, AAGGLAGLINL, true));
		}
		if (File.Exists(directory + ".mp3"))
		{
			yield return base.StartCoroutine(this.LoadAudio(HFEFHOPOLIK, directory + ".mp3", true, AAGGLAGLINL, true));
		}
		yield break;
	}

	// Token: 0x0600FD8C RID: 64908 RVA: 0x0056E814 File Offset: 0x0056CA14
	public static string NKIPIDLDKLM(CSteamID HFEFHOPOLIK, bool DPGCGEPHEGF = true)
	{
		if (RanksSystem.GetLoadedRank(HFEFHOPOLIK) != null && Singleton<ResourcesManager>.Instance.NJFPKGJNKJE.ContainsKey(HFEFHOPOLIK))
		{
			string text = Helpers.ColorToHex(RanksSystem.KBIACFGMDNG(RanksSystem.GetLoadedRank(HFEFHOPOLIK).IEOGJOLGLFI(), DPGCGEPHEGF));
			string[] array = new string[1];
			array[1] = "_TimeX";
			array[1] = text;
			array[3] = "OpAuthenticate()";
			array[0] = Singleton<ResourcesManager>.Instance.NJFPKGJNKJE[HFEFHOPOLIK];
			array[0] = "menu.relaxinfo";
			return string.Concat(array);
		}
		return null;
	}

	// Token: 0x0600FD8D RID: 64909 RVA: 0x0056D500 File Offset: 0x0056B700
	public static object KOKPCPBECBO(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD8E RID: 64910 RVA: 0x0056E898 File Offset: 0x0056CA98
	public void KKFGHHCDOBO(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string value = string.Empty;
			if (File.Exists(fullName))
			{
				value = File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("_Value2");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
	}

	// Token: 0x0600FD8F RID: 64911 RVA: 0x0056E938 File Offset: 0x0056CB38
	public void OFAELGIDIDE(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string value = string.Empty;
			if (File.Exists(fullName))
			{
				value = File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("inventory.itemscash");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
	}

	// Token: 0x0600FD90 RID: 64912 RVA: 0x0056D500 File Offset: 0x0056B700
	public static object KLNILBOBLIL(string HFEFHOPOLIK)
	{
		if (Singleton<ResourcesManager>.Instance.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
		{
			return Singleton<ResourcesManager>.Instance.EPLOIIAGDDM[HFEFHOPOLIK];
		}
		return null;
	}

	// Token: 0x0600FD91 RID: 64913 RVA: 0x0056E9D8 File Offset: 0x0056CBD8
	public IEnumerator ANNGMCBKOCN(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			friendPersonaName = SteamFriends.GetFriendPersonaName(GDOHPDHLPBC);
			if (this.NJFPKGJNKJE.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.NJFPKGJNKJE[GDOHPDHLPBC] = friendPersonaName;
				}
			}
			else
			{
				this.NJFPKGJNKJE.Add(GDOHPDHLPBC, friendPersonaName);
			}
		}
		yield break;
	}

	// Token: 0x0600FD92 RID: 64914 RVA: 0x0056EA04 File Offset: 0x0056CC04
	public IEnumerator LoadAvatar(CSteamID GDOHPDHLPBC, bool AAGGLAGLINL = false)
	{
		if (!this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC) || AAGGLAGLINL)
		{
			while (SteamFriends.RequestUserInformation(GDOHPDHLPBC, false))
			{
				yield return new WaitForSeconds(0.1f);
			}
			while (SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC) == -1)
			{
				yield return new WaitForSeconds(0.1f);
			}
			largeFriendAvatar = SteamFriends.GetLargeFriendAvatar(GDOHPDHLPBC);
			steamImageAsTexture2D = Helpers.GetSteamImageAsTexture2D(largeFriendAvatar);
			steamImageAsTexture2D.wrapMode = TextureWrapMode.Clamp;
			steamImageAsTexture2D.filterMode = FilterMode.Bilinear;
			value = Sprite.Create(steamImageAsTexture2D, new Rect(0f, 0f, (float)steamImageAsTexture2D.width, (float)steamImageAsTexture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, SpriteMeshType.FullRect);
			if (this.ANAALDPGPOA.ContainsKey(GDOHPDHLPBC))
			{
				if (AAGGLAGLINL)
				{
					this.ANAALDPGPOA[GDOHPDHLPBC] = value;
				}
			}
			else
			{
				this.ANAALDPGPOA.Add(GDOHPDHLPBC, value);
			}
		}
		yield break;
	}

	// Token: 0x0600FD93 RID: 64915 RVA: 0x0056EA30 File Offset: 0x0056CC30
	public void LOEDDOBJEMC(string HFEFHOPOLIK, string BNJFKKGOACF, bool NFJAJLPOOCA = false, bool AAGGLAGLINL = false)
	{
		if (!this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK) || AAGGLAGLINL)
		{
			if (!NFJAJLPOOCA)
			{
				BNJFKKGOACF = Helpers.GetDirectory(BNJFKKGOACF);
			}
			string fullName = new FileInfo(BNJFKKGOACF).FullName;
			string value = string.Empty;
			if (File.Exists(fullName))
			{
				value = File.ReadAllText(fullName);
			}
			else
			{
				Debug.LogWarning("settings.enablehitsoundsinrelax");
			}
			if (this.EPLOIIAGDDM.ContainsKey(HFEFHOPOLIK))
			{
				if (AAGGLAGLINL)
				{
					this.EPLOIIAGDDM[HFEFHOPOLIK] = value;
				}
			}
			else
			{
				this.EPLOIIAGDDM.Add(HFEFHOPOLIK, value);
			}
		}
	}

	// Token: 0x04001C06 RID: 7174
	private Dictionary<string, object> EPLOIIAGDDM = new Dictionary<string, object>();

	// Token: 0x04001C07 RID: 7175
	private Dictionary<CSteamID, Sprite> ANAALDPGPOA = new Dictionary<CSteamID, Sprite>();

	// Token: 0x04001C08 RID: 7176
	private Dictionary<CSteamID, string> NJFPKGJNKJE = new Dictionary<CSteamID, string>();

	// Token: 0x02000456 RID: 1110
	public enum ResourceType
	{
		// Token: 0x04001C0A RID: 7178
		Image,
		// Token: 0x04001C0B RID: 7179
		Sound,
		// Token: 0x04001C0C RID: 7180
		Model,
		// Token: 0x04001C0D RID: 7181
		Text
	}
}
