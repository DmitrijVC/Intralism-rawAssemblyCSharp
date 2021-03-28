using System;
using System.Collections;
using System.IO;
using System.Linq;
using AudioVisualizer;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x020003BE RID: 958
public class LevelsListElementButton : MonoBehaviour
{
	// Token: 0x0600D799 RID: 55193 RVA: 0x004CFC2E File Offset: 0x004CDE2E
	public void JMNJAJNMIKP()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.ELNHNLCKKEC(0, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D79A RID: 55194 RVA: 0x004CFC54 File Offset: 0x004CDE54
	private IEnumerator AIJKGAHBBAO(ulong CDAGKANOOHO)
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

	// Token: 0x0600D79B RID: 55195 RVA: 0x004CFC78 File Offset: 0x004CDE78
	private IEnumerator PGPHLFGHGDF(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x0600D79C RID: 55196 RVA: 0x004CFC9C File Offset: 0x004CDE9C
	private IEnumerator JHCBBBJIOKO(ulong CDAGKANOOHO)
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

	// Token: 0x0600D79D RID: 55197 RVA: 0x004CFCBE File Offset: 0x004CDEBE
	public void OLLODDJNDNP()
	{
		if (this.fullLevelData.source == FullMapData.MapSource.Editor)
		{
			base.StartCoroutine(this.FCGGOCIFBGJ());
		}
		if (this.fullLevelData.source == (FullMapData.MapSource)6)
		{
			base.StartCoroutine(this.BNDIBFHNLHL());
		}
	}

	// Token: 0x0600D79E RID: 55198 RVA: 0x004CFCFC File Offset: 0x004CDEFC
	private IEnumerator HPFCCEJODMB(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x0600D79F RID: 55199 RVA: 0x004CFD20 File Offset: 0x004CDF20
	public void GFMKNEGNNJI()
	{
		if (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) == 1)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600D7A0 RID: 55200 RVA: 0x004CFE11 File Offset: 0x004CE011
	public void ToggleRate()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(false);
		this.leaderboardsCanvas.SetActive(false);
		this.PICNOPDLFBE();
		this.InitRateButton();
	}

	// Token: 0x0600D7A1 RID: 55201 RVA: 0x004CFE50 File Offset: 0x004CE050
	public void PFKOBNHHNIJ()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.NKENDKCFCKB(1, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D7A2 RID: 55202 RVA: 0x004CFE76 File Offset: 0x004CE076
	public void FNCDAPDOBBI()
	{
		this.OMMHCNMIIBJ();
		base.StartCoroutine(this.LLDAMHKJPJO());
		base.StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(base.gameObject, false, null, false, 245f, true));
	}

	// Token: 0x0600D7A3 RID: 55203 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnRateClick()
	{
	}

	// Token: 0x0600D7A4 RID: 55204 RVA: 0x004CFEAC File Offset: 0x004CE0AC
	public void FOMDICJKGFK(bool NHLFMIIGBEB)
	{
		Helpers.ObtainAchievement(-61);
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(this.fullLevelData.workshopId)] = ((!NHLFMIIGBEB) ? -1 : 1);
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(this.fullLevelData.workshopId), NHLFMIIGBEB);
		this.GFMKNEGNNJI();
		this.LMGOCLHHDJE();
		this.rateCanvas.SetActive(false);
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(this.fullLevelData.workshopId)))
		{
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(this.fullLevelData.workshopId), (!NHLFMIIGBEB) ? -1 : 1);
		}
	}

	// Token: 0x0600D7A5 RID: 55205 RVA: 0x004CFF8C File Offset: 0x004CE18C
	public void OLIGPHDCCFK()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("StartButton", null))
		{
			this.isSelected = true;
			try
			{
				this.audioSource.Pause();
				if (GameObject.Find("DPADHOR"))
				{
					GameObject.Find("GenerationMenu").GetComponent<AudioSampler>().isMuted = false;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600D7A6 RID: 55206 RVA: 0x004D0004 File Offset: 0x004CE204
	private IEnumerator OMBKMAKDOJF()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D7A7 RID: 55207 RVA: 0x004D001F File Offset: 0x004CE21F
	public void NBGIMIDICKE()
	{
		this.GJILIJALJLE();
		base.StartCoroutine(this.LFMKJHBDJCE());
		base.StartCoroutine(Singleton<UI>.Instance.NCMLIDIEECD(base.gameObject, true, null, true, 859f, false));
	}

	// Token: 0x0600D7A8 RID: 55208 RVA: 0x004D0054 File Offset: 0x004CE254
	private IEnumerator LBBDMDFOCIB(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D7A9 RID: 55209 RVA: 0x004D007D File Offset: 0x004CE27D
	public void LDJHKLEOKHI()
	{
		base.GetComponent<Button>().interactable = true;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600D7AA RID: 55210 RVA: 0x004D0096 File Offset: 0x004CE296
	public void LLFLMHAJEEE()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.NKENDKCFCKB(0, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D7AB RID: 55211 RVA: 0x004D00BC File Offset: 0x004CE2BC
	private IEnumerator JEKGBBCOHLB(ulong CDAGKANOOHO)
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

	// Token: 0x0600D7AC RID: 55212 RVA: 0x004D00E0 File Offset: 0x004CE2E0
	private IEnumerator NOLIEIKFMAM(ulong CDAGKANOOHO)
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

	// Token: 0x0600D7AD RID: 55213 RVA: 0x004D0104 File Offset: 0x004CE304
	private void EJBNPKIIHBO()
	{
		this.rateCanvas.transform.Find("CameraFilterPack_Blizzard1").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(this.fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) != 0 || true);
		this.rateCanvas.transform.Find("_TimeX").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(this.fullLevelData.workshopId)) != -1 || true);
	}

	// Token: 0x0600D7AE RID: 55214 RVA: 0x0002523B File Offset: 0x0002343B
	public void JNEAIMPPCIL()
	{
	}

	// Token: 0x0600D7AF RID: 55215 RVA: 0x004D01FC File Offset: 0x004CE3FC
	private IEnumerator HJCOEFEPNFH()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("unsubscribemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.UnsubscribeLevel(this.fullLevelData.workshopId);
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D7B0 RID: 55216 RVA: 0x004D0218 File Offset: 0x004CE418
	public void NDPAAEIPFPJ()
	{
		if (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) == 1)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) == -1)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600D7B1 RID: 55217 RVA: 0x004D030C File Offset: 0x004CE50C
	private void LMGOCLHHDJE()
	{
		this.rateCanvas.transform.Find("_ForegroundBlurExtrude").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(this.fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) != 1);
		this.rateCanvas.transform.Find("_TimeX").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) != -1);
	}

	// Token: 0x0600D7B2 RID: 55218 RVA: 0x004D0403 File Offset: 0x004CE603
	public void HCOBFENJGAH()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.EACKBBJMBIL(1, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D7B3 RID: 55219 RVA: 0x004D042C File Offset: 0x004CE62C
	private IEnumerator LLDAMHKJPJO()
	{
		string fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D7B4 RID: 55220 RVA: 0x004D0448 File Offset: 0x004CE648
	private IEnumerator KHKCPKKMGHI()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D7B5 RID: 55221 RVA: 0x004D0464 File Offset: 0x004CE664
	private IEnumerator KIGJJAGAJDP(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x0600D7B6 RID: 55222 RVA: 0x004D0488 File Offset: 0x004CE688
	public void OnItemRated(bool NHLFMIIGBEB)
	{
		Helpers.ObtainAchievement(28);
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(this.fullLevelData.workshopId)] = ((!NHLFMIIGBEB) ? -1 : 1);
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(this.fullLevelData.workshopId), NHLFMIIGBEB);
		this.InitRateButton();
		this.PICNOPDLFBE();
		this.rateCanvas.SetActive(false);
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(this.fullLevelData.workshopId)))
		{
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(this.fullLevelData.workshopId), (!NHLFMIIGBEB) ? -1 : 1);
		}
	}

	// Token: 0x0600D7B7 RID: 55223 RVA: 0x004D0568 File Offset: 0x004CE768
	private IEnumerator IJIEEOOPJOF()
	{
		string fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.musicFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, true));
		this.audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		this.audioSource.loop = true;
		this.audioSource.Play();
		yield break;
	}

	// Token: 0x0600D7B8 RID: 55224 RVA: 0x004D0584 File Offset: 0x004CE784
	private IEnumerator EPAAPOAIIDH()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D7B9 RID: 55225 RVA: 0x004D05A0 File Offset: 0x004CE7A0
	private IEnumerator EDMLNOJLPIB(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x0600D7BA RID: 55226 RVA: 0x004D05C2 File Offset: 0x004CE7C2
	public void EMNHHKNHBHP(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA("SupportLogger OnCreatedRoom(", 1, null);
		}
		SceneManager.LoadScene(".sav");
	}

	// Token: 0x0600D7BB RID: 55227 RVA: 0x004D05E6 File Offset: 0x004CE7E6
	public void ODKLCECLCJI()
	{
		base.StartCoroutine(this.JEKGBBCOHLB(this.fullLevelData.mapperSteamID));
	}

	// Token: 0x0600D7BC RID: 55228 RVA: 0x004D0600 File Offset: 0x004CE800
	private IEnumerator NHFBEPDELCN(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x0600D7BD RID: 55229 RVA: 0x004D0622 File Offset: 0x004CE822
	public void Start()
	{
		this.LoadMapperNickname();
		base.StartCoroutine(this.LFMKJHBDJCE());
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(base.gameObject, true, null, true, 0.2f, true));
	}

	// Token: 0x0600D7BE RID: 55230 RVA: 0x004D0658 File Offset: 0x004CE858
	private IEnumerator MFEGJEEIJJP()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D7BF RID: 55231 RVA: 0x004D0674 File Offset: 0x004CE874
	private IEnumerator PLMNMDBEFIL(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D7C0 RID: 55232 RVA: 0x004D069D File Offset: 0x004CE89D
	public void CAPDBMHNNAI()
	{
		base.GetComponent<Button>().interactable = false;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600D7C1 RID: 55233 RVA: 0x004D06B8 File Offset: 0x004CE8B8
	public void Update()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null))
		{
			this.audioSource.volume = Mathf.Lerp(this.audioSource.volume, (float)((!this.isSelected) ? 0 : 1), Time.deltaTime * 10f);
		}
	}

	// Token: 0x0600D7C2 RID: 55234 RVA: 0x004D069D File Offset: 0x004CE89D
	public void KPFNEJOCCGH()
	{
		base.GetComponent<Button>().interactable = false;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600D7C3 RID: 55235 RVA: 0x004D0713 File Offset: 0x004CE913
	public void ToggleLeaderboards()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(1, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D7C4 RID: 55236 RVA: 0x004D073C File Offset: 0x004CE93C
	private void IBDHFBMDMCI()
	{
		this.rateCanvas.transform.Find(" - LOCAL").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) == 1);
		this.rateCanvas.transform.Find("maps.").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(this.fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(this.fullLevelData.workshopId)) != -1 || true);
	}

	// Token: 0x0600D7C5 RID: 55237 RVA: 0x004D0834 File Offset: 0x004CEA34
	private IEnumerator BCLACJOIGHN(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D7C6 RID: 55238 RVA: 0x004D0860 File Offset: 0x004CEA60
	public void OnMouseEnter()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null) && this.fullLevelData.isUnlocked())
		{
			if (this.audioSource.clip == null)
			{
				base.StartCoroutine(this.JINABPAAGGF());
			}
			if (!this.audioSource.isPlaying)
			{
				this.audioSource.UnPause();
			}
			this.isSelected = true;
			if (GameObject.Find("AudioSampler"))
			{
				GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = true;
			}
		}
	}

	// Token: 0x0600D7C7 RID: 55239 RVA: 0x004D0900 File Offset: 0x004CEB00
	public void KAGMODFAFHP()
	{
		if (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(this.fullLevelData.workshopId)) == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600D7C8 RID: 55240 RVA: 0x004D09F4 File Offset: 0x004CEBF4
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

	// Token: 0x0600D7C9 RID: 55241 RVA: 0x004D0A20 File Offset: 0x004CEC20
	public void InitRateButton()
	{
		if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == 1)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600D7CA RID: 55242 RVA: 0x004D0B14 File Offset: 0x004CED14
	private IEnumerator GGCDOOOFLOO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D7CB RID: 55243 RVA: 0x004D0B3D File Offset: 0x004CED3D
	public void MAABEAPENIB()
	{
		this.infoCanvas.SetActive(this.infoCanvas.activeSelf);
		this.leaderboardsCanvas.SetActive(true);
		this.rateCanvas.SetActive(true);
	}

	// Token: 0x0600D7CC RID: 55244 RVA: 0x004D0B70 File Offset: 0x004CED70
	public void MCHENMKMHJP(int JMMILEFMACB = 0)
	{
		string nbebmkfpbep = string.Empty;
		if (JMMILEFMACB == 0)
		{
			nbebmkfpbep = this.fullLevelData.mapData.moreInfoURL;
		}
		if (JMMILEFMACB == 0)
		{
			nbebmkfpbep = "#no" + this.fullLevelData.workshopId;
		}
		Singleton<GameManager>.Instance.KPCCPKIPFGC(nbebmkfpbep, false);
	}

	// Token: 0x0600D7CD RID: 55245 RVA: 0x004D0BC8 File Offset: 0x004CEDC8
	public void LLPJNILPBBI()
	{
		if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
		}
		else if (Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(this.fullLevelData.workshopId)) == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
	}

	// Token: 0x0600D7CE RID: 55246 RVA: 0x004D0CBC File Offset: 0x004CEEBC
	public void GetMoreInfo(int JMMILEFMACB = 0)
	{
		string nbebmkfpbep = string.Empty;
		if (JMMILEFMACB == 0)
		{
			nbebmkfpbep = this.fullLevelData.mapData.moreInfoURL;
		}
		if (JMMILEFMACB == 1)
		{
			nbebmkfpbep = "http://steamcommunity.com/sharedfiles/filedetails/?id=" + this.fullLevelData.workshopId;
		}
		Singleton<GameManager>.Instance.OpenURL(nbebmkfpbep, true);
	}

	// Token: 0x0600D7CF RID: 55247 RVA: 0x004D0D14 File Offset: 0x004CEF14
	public void OnFavoriteClick(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.IsMapFavorite(ulong.Parse(this.fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.AddToFavorite(this.fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.RemoveFromFavorite(this.fullLevelData);
			}
		}
	}

	// Token: 0x0600D7D0 RID: 55248 RVA: 0x004D0D71 File Offset: 0x004CEF71
	public void LoadMapperNickname()
	{
		base.StartCoroutine(this.KFEJNLGMENE(this.fullLevelData.mapperSteamID));
	}

	// Token: 0x0600D7D1 RID: 55249 RVA: 0x004D0D8C File Offset: 0x004CEF8C
	private IEnumerator NGFEBAMIKGB(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D7D2 RID: 55250 RVA: 0x004D0DB5 File Offset: 0x004CEFB5
	public void JPJKCAGJOBJ()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.DisplayViewer(0, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D7D3 RID: 55251 RVA: 0x004D0DDC File Offset: 0x004CEFDC
	private IEnumerator JINABPAAGGF()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.musicFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, true));
		this.audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		this.audioSource.loop = true;
		this.audioSource.Play();
		yield break;
	}

	// Token: 0x0600D7D4 RID: 55252 RVA: 0x004D0DF8 File Offset: 0x004CEFF8
	public void DKHHJKMLHCE(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.NACJDBPDMJI(ulong.Parse(this.fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.BNIFKLGDHAB(this.fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.RemoveFromFavorite(this.fullLevelData);
			}
		}
	}

	// Token: 0x0600D7D5 RID: 55253 RVA: 0x004D0E58 File Offset: 0x004CF058
	private IEnumerator PJGECKOENBF(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x0600D7D6 RID: 55254 RVA: 0x004D0E7C File Offset: 0x004CF07C
	private void MDMIDBOPEHG()
	{
		this.rateCanvas.transform.Find("5;6;7;8;11;12;18;19;20;22x6;44x1").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == 1 && false);
		this.rateCanvas.transform.Find("Done!").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.GBFFPCIAIAB(ulong.Parse(this.fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) != -1 || true);
	}

	// Token: 0x0600D7D7 RID: 55255 RVA: 0x004D0F73 File Offset: 0x004CF173
	public void OMMHCNMIIBJ()
	{
		base.StartCoroutine(this.AIJKGAHBBAO(this.fullLevelData.mapperSteamID));
	}

	// Token: 0x0600D7D8 RID: 55256 RVA: 0x004D0F90 File Offset: 0x004CF190
	private IEnumerator AEPCHPNAOCK()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D7D9 RID: 55257 RVA: 0x004D0FAC File Offset: 0x004CF1AC
	public void KLKGNPNONKE()
	{
		if (Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(this.fullLevelData.workshopId)) == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
		}
		else if (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) == -1)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
	}

	// Token: 0x0600D7DA RID: 55258 RVA: 0x004D10A0 File Offset: 0x004CF2A0
	private IEnumerator FCGGOCIFBGJ()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D7DB RID: 55259 RVA: 0x004D10BC File Offset: 0x004CF2BC
	private IEnumerator HDFCPEOPJPE()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D7DC RID: 55260 RVA: 0x004D10D8 File Offset: 0x004CF2D8
	public void ADMLEIMBMEC(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.ECEOJLNJMHN(ulong.Parse(this.fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.AddToFavorite(this.fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.RemoveFromFavorite(this.fullLevelData);
			}
		}
	}

	// Token: 0x0600D7DD RID: 55261 RVA: 0x004D1135 File Offset: 0x004CF335
	public void OnDeleteButton()
	{
		if (this.fullLevelData.source == FullMapData.MapSource.Editor)
		{
			base.StartCoroutine(this.POMLILLIBOI());
		}
		if (this.fullLevelData.source == FullMapData.MapSource.Workshop)
		{
			base.StartCoroutine(this.HJCOEFEPNFH());
		}
	}

	// Token: 0x0600D7DE RID: 55262 RVA: 0x004D1174 File Offset: 0x004CF374
	private IEnumerator IGJHCGJDLAI(Sprite EOGBJKCLGLP)
	{
		yield return base.StartCoroutine(this.DFMJJLFNBBO(this.bgImage, 0f, 0.1f));
		this.bgImage.sprite = EOGBJKCLGLP;
		if (this.bgImage.sprite != null && this.bgImage.GetComponent<AspectRatioFitter>())
		{
			this.bgImage.GetComponent<AspectRatioFitter>().aspectRatio = this.bgImage.sprite.rect.size.x / this.bgImage.sprite.rect.size.y;
		}
		yield return base.StartCoroutine(this.ENONILPJLCJ(this.bgImage, 1f, 0.1f));
		yield break;
	}

	// Token: 0x0600D7DF RID: 55263 RVA: 0x004D1198 File Offset: 0x004CF398
	public void OnMouseExit()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic", null))
		{
			this.isSelected = false;
			try
			{
				this.audioSource.Pause();
				if (GameObject.Find("AudioSampler"))
				{
					GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = false;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600D7E0 RID: 55264 RVA: 0x004D1210 File Offset: 0x004CF410
	private IEnumerator GJGPECEMPOC()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D7E1 RID: 55265 RVA: 0x004D122B File Offset: 0x004CF42B
	public void LHNMAOKJDMN()
	{
		this.rateCanvas.SetActive(this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(false);
		this.leaderboardsCanvas.SetActive(false);
		this.PICNOPDLFBE();
		this.KLKGNPNONKE();
	}

	// Token: 0x0600D7E2 RID: 55266 RVA: 0x004D007D File Offset: 0x004CE27D
	public void PCJKNJMNOFI()
	{
		base.GetComponent<Button>().interactable = true;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600D7E3 RID: 55267 RVA: 0x004D069D File Offset: 0x004CE89D
	public void NNDFGJPHOED()
	{
		base.GetComponent<Button>().interactable = false;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600D7E4 RID: 55268 RVA: 0x004D126C File Offset: 0x004CF46C
	private void PICNOPDLFBE()
	{
		this.rateCanvas.transform.Find("VoteUpToggle").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == 1);
		this.rateCanvas.transform.Find("VoteDownToggle").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) == -1);
	}

	// Token: 0x0600D7E5 RID: 55269 RVA: 0x004D1363 File Offset: 0x004CF563
	public void OnClick()
	{
		if (this.fullLevelData.isUnlocked())
		{
			Singleton<MapsListSelector>.Instance.Close(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData), false);
		}
	}

	// Token: 0x0600D7E6 RID: 55270 RVA: 0x004D007D File Offset: 0x004CE27D
	public void OnLoaderPanelCansel()
	{
		base.GetComponent<Button>().interactable = true;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600D7E7 RID: 55271 RVA: 0x004D1390 File Offset: 0x004CF590
	public void DGDOCOMJOEA()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(true);
		this.leaderboardsCanvas.SetActive(false);
		this.IBDHFBMDMCI();
		this.NDPAAEIPFPJ();
	}

	// Token: 0x0600D7E8 RID: 55272 RVA: 0x004D13D0 File Offset: 0x004CF5D0
	private IEnumerator DLIAPJONLNP(ulong CDAGKANOOHO)
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

	// Token: 0x0600D7E9 RID: 55273 RVA: 0x004D13F4 File Offset: 0x004CF5F4
	private IEnumerator ADCEBLGIFGO(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D7EA RID: 55274 RVA: 0x004D1420 File Offset: 0x004CF620
	public void PJLLNMAGOKD()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("_TimeX", null))
		{
			this.isSelected = false;
			try
			{
				this.audioSource.Pause();
				if (GameObject.Find("_Value"))
				{
					GameObject.Find("_MainTex2").GetComponent<AudioSampler>().isMuted = false;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600D7EB RID: 55275 RVA: 0x004D1498 File Offset: 0x004CF698
	public void CGOIDOPBBME()
	{
		base.StartCoroutine(this.JHCBBBJIOKO(this.fullLevelData.mapperSteamID));
	}

	// Token: 0x0600D7EC RID: 55276 RVA: 0x0002523B File Offset: 0x0002343B
	public void KCLANECLPEB()
	{
	}

	// Token: 0x0600D7ED RID: 55277 RVA: 0x004D14B2 File Offset: 0x004CF6B2
	public void DJPKDIGGEIM()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.LPJDKNPGGJN(0, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D7EE RID: 55278 RVA: 0x004D14D8 File Offset: 0x004CF6D8
	private IEnumerator LFMKJHBDJCE()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D7EF RID: 55279 RVA: 0x004D14F4 File Offset: 0x004CF6F4
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

	// Token: 0x0600D7F0 RID: 55280 RVA: 0x004D1520 File Offset: 0x004CF720
	private IEnumerator BJMHHLGICPI()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.musicFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, true));
		this.audioSource.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		this.audioSource.loop = true;
		this.audioSource.Play();
		yield break;
	}

	// Token: 0x0600D7F1 RID: 55281 RVA: 0x004D153B File Offset: 0x004CF73B
	public void ToggleInfo()
	{
		this.infoCanvas.SetActive(!this.infoCanvas.activeSelf);
		this.leaderboardsCanvas.SetActive(false);
		this.rateCanvas.SetActive(false);
	}

	// Token: 0x0600D7F2 RID: 55282 RVA: 0x004CFE50 File Offset: 0x004CE050
	public void EGIEPENLHNG()
	{
		base.StartCoroutine(Singleton<RanksViewer>.Instance.NKENDKCFCKB(1, this.fullLevelData.workshopId, null, null));
	}

	// Token: 0x0600D7F3 RID: 55283 RVA: 0x004D156E File Offset: 0x004CF76E
	public void POKAEGMGDIO()
	{
		if (this.fullLevelData.source == FullMapData.MapSource.Editor)
		{
			base.StartCoroutine(this.KHKCPKKMGHI());
		}
		if (this.fullLevelData.source == (FullMapData.MapSource)6)
		{
			base.StartCoroutine(this.EIELMKBMEED());
		}
	}

	// Token: 0x0600D7F4 RID: 55284 RVA: 0x004D15AC File Offset: 0x004CF7AC
	private IEnumerator CPDKINHDKOD()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D7F5 RID: 55285 RVA: 0x004D15C7 File Offset: 0x004CF7C7
	public void HJPCJGOEKMF()
	{
		this.ODKLCECLCJI();
		base.StartCoroutine(this.MFEGJEEIJJP());
		base.StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(base.gameObject, true, null, false, 476f, true));
	}

	// Token: 0x0600D7F6 RID: 55286 RVA: 0x004D15FC File Offset: 0x004CF7FC
	public void FKODENGGPKG()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(false);
		this.leaderboardsCanvas.SetActive(true);
		this.MCFOJLKAACB();
		this.GFMKNEGNNJI();
	}

	// Token: 0x0600D7F7 RID: 55287 RVA: 0x004D163B File Offset: 0x004CF83B
	public void GJILIJALJLE()
	{
		base.StartCoroutine(this.DLIAPJONLNP(this.fullLevelData.mapperSteamID));
	}

	// Token: 0x0600D7F8 RID: 55288 RVA: 0x004D1655 File Offset: 0x004CF855
	public void NEMDLABDKDL(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Value4", 0, null);
		}
		SceneManager.LoadScene("Exit to Windows");
	}

	// Token: 0x0600D7F9 RID: 55289 RVA: 0x004D1679 File Offset: 0x004CF879
	public void FKOMHOMCJBF()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(false);
		this.leaderboardsCanvas.SetActive(true);
		this.PICNOPDLFBE();
		this.NDPAAEIPFPJ();
	}

	// Token: 0x0600D7FA RID: 55290 RVA: 0x0002523B File Offset: 0x0002343B
	public void NPGOHMPPPIE()
	{
	}

	// Token: 0x0600D7FB RID: 55291 RVA: 0x004D16B8 File Offset: 0x004CF8B8
	public void MINEGHNIGCA(bool MJNJNPOHDCF)
	{
		if (Singleton<MapsSystem>.Instance.NACJDBPDMJI(ulong.Parse(this.fullLevelData.workshopId)) != MJNJNPOHDCF)
		{
			if (MJNJNPOHDCF)
			{
				Singleton<MapsSystem>.Instance.BNIFKLGDHAB(this.fullLevelData);
			}
			else
			{
				Singleton<MapsSystem>.Instance.ACIIHJJKNNC(this.fullLevelData);
			}
		}
	}

	// Token: 0x0600D7FC RID: 55292 RVA: 0x004D1715 File Offset: 0x004CF915
	public void LoaderPanelOnButton(int JMMILEFMACB)
	{
		if (JMMILEFMACB == 1)
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.resetlevelcheckpoint", 1, null);
		}
		SceneManager.LoadScene("GameScene");
	}

	// Token: 0x0600D7FD RID: 55293 RVA: 0x004D163B File Offset: 0x004CF83B
	public void DOJDNFEMCFE()
	{
		base.StartCoroutine(this.DLIAPJONLNP(this.fullLevelData.mapperSteamID));
	}

	// Token: 0x0600D7FE RID: 55294 RVA: 0x004D1739 File Offset: 0x004CF939
	public void BEOEODBNOIF()
	{
		if (this.fullLevelData.source == FullMapData.MapSource.Editor)
		{
			base.StartCoroutine(this.KHKCPKKMGHI());
		}
		if (this.fullLevelData.source == (FullMapData.MapSource)5)
		{
			base.StartCoroutine(this.EIELMKBMEED());
		}
	}

	// Token: 0x0600D7FF RID: 55295 RVA: 0x004D1777 File Offset: 0x004CF977
	public void MMCFPCEMPOA()
	{
		this.infoCanvas.SetActive(this.infoCanvas.activeSelf);
		this.leaderboardsCanvas.SetActive(false);
		this.rateCanvas.SetActive(true);
	}

	// Token: 0x0600D800 RID: 55296 RVA: 0x004D17AC File Offset: 0x004CF9AC
	public void NBMHPDNDBLK(bool NHLFMIIGBEB)
	{
		Helpers.ObtainAchievement(-89);
		Singleton<MapsSystem>.Instance.ratedMaps[ulong.Parse(this.fullLevelData.workshopId)] = ((!NHLFMIIGBEB) ? -1 : 0);
		SteamUGC.SetUserItemVote((PublishedFileId_t)ulong.Parse(this.fullLevelData.workshopId), NHLFMIIGBEB);
		this.KAGMODFAFHP();
		this.EJBNPKIIHBO();
		this.rateCanvas.SetActive(false);
		if (!Singleton<MapsSystem>.Instance.ratedMaps.Keys.Contains(ulong.Parse(this.fullLevelData.workshopId)))
		{
			Singleton<MapsSystem>.Instance.ratedMaps.Add(ulong.Parse(this.fullLevelData.workshopId), (!NHLFMIIGBEB) ? -1 : 1);
		}
	}

	// Token: 0x0600D801 RID: 55297 RVA: 0x004D188C File Offset: 0x004CFA8C
	private IEnumerator BNDIBFHNLHL()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("unsubscribemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.UnsubscribeLevel(this.fullLevelData.workshopId);
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D802 RID: 55298 RVA: 0x004D18A7 File Offset: 0x004CFAA7
	public void JILOMOBDPIA()
	{
		this.OMMHCNMIIBJ();
		base.StartCoroutine(this.LFMKJHBDJCE());
		base.StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(base.gameObject, false, null, false, 1331f, true));
	}

	// Token: 0x0600D803 RID: 55299 RVA: 0x004D18DC File Offset: 0x004CFADC
	private IEnumerator BIBPGDOMNEC()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D804 RID: 55300 RVA: 0x004D18F8 File Offset: 0x004CFAF8
	public void CLJLAEIHJDG()
	{
		if (Singleton<SaveSystem>.Instance.HasKey("challenges/", null))
		{
			this.isSelected = false;
			try
			{
				this.audioSource.Pause();
				if (GameObject.Find("_Vignetting2"))
				{
					GameObject.Find("\nCreated by Oxy949").GetComponent<AudioSampler>().isMuted = true;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600D805 RID: 55301 RVA: 0x004D1970 File Offset: 0x004CFB70
	public void IOPHOLIFJEJ(int JMMILEFMACB = 0)
	{
		string nbebmkfpbep = string.Empty;
		if (JMMILEFMACB == 0)
		{
			nbebmkfpbep = this.fullLevelData.mapData.moreInfoURL;
		}
		if (JMMILEFMACB == 1)
		{
			nbebmkfpbep = "Please attach component to a Graphical UI component" + this.fullLevelData.workshopId;
		}
		Singleton<GameManager>.Instance.IEEHOAELCGE(nbebmkfpbep, true);
	}

	// Token: 0x0600D806 RID: 55302 RVA: 0x004D19C8 File Offset: 0x004CFBC8
	private IEnumerator POMLILLIBOI()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(Singleton<MapsSystem>.Instance.GetMapID(this.fullLevelData));
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D807 RID: 55303 RVA: 0x004D19E4 File Offset: 0x004CFBE4
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

	// Token: 0x0600D808 RID: 55304 RVA: 0x0002523B File Offset: 0x0002343B
	public void JMELOADCNNA()
	{
	}

	// Token: 0x0600D809 RID: 55305 RVA: 0x004D1A06 File Offset: 0x004CFC06
	public void JKBMKPDGCHG()
	{
		this.DOJDNFEMCFE();
		base.StartCoroutine(this.LLDAMHKJPJO());
		base.StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(base.gameObject, false, null, true, 1067f, true));
	}

	// Token: 0x0600D80A RID: 55306 RVA: 0x004D1A3C File Offset: 0x004CFC3C
	private IEnumerator KNODHMNPLFA()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D80B RID: 55307 RVA: 0x004D1A58 File Offset: 0x004CFC58
	public void AJCAPKJICFL()
	{
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("CameraFilterPack_Glasses_On2", null) && this.fullLevelData.MLDFFCPMHHF())
		{
			if (this.audioSource.clip == null)
			{
				base.StartCoroutine(this.IJIEEOOPJOF());
			}
			if (!this.audioSource.isPlaying)
			{
				this.audioSource.UnPause();
			}
			this.isSelected = true;
			if (GameObject.Find("maps."))
			{
				GameObject.Find("EventMenu").GetComponent<AudioSampler>().isMuted = false;
			}
		}
	}

	// Token: 0x0600D80C RID: 55308 RVA: 0x004D1AF8 File Offset: 0x004CFCF8
	private IEnumerator CNFDOCLAIFD(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D80D RID: 55309 RVA: 0x004D1B21 File Offset: 0x004CFD21
	public void HDMDKOKOOJC()
	{
		this.DOJDNFEMCFE();
		base.StartCoroutine(this.BIBPGDOMNEC());
		base.StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(base.gameObject, false, null, false, 1688f, true));
	}

	// Token: 0x0600D80E RID: 55310 RVA: 0x004D1B58 File Offset: 0x004CFD58
	private IEnumerator AIEFPPMPFDN(Image EOGBJKCLGLP, float AAEBFBPJJPK, float EHHBHEJBHNG)
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

	// Token: 0x0600D80F RID: 55311 RVA: 0x004D1B81 File Offset: 0x004CFD81
	public void GMBNFAHDCMA()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(false);
		this.leaderboardsCanvas.SetActive(true);
		this.LMGOCLHHDJE();
		this.KAGMODFAFHP();
	}

	// Token: 0x0600D810 RID: 55312 RVA: 0x004D1BC0 File Offset: 0x004CFDC0
	public void KBAEFDAIHON()
	{
		if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("colorC", null) && this.fullLevelData.OKMHKMIOAOL())
		{
			if (this.audioSource.clip == null)
			{
				base.StartCoroutine(this.IJIEEOOPJOF());
			}
			if (!this.audioSource.isPlaying)
			{
				this.audioSource.UnPause();
			}
			this.isSelected = true;
			if (GameObject.Find("_Value2"))
			{
				GameObject.Find("RPC: 'OnAwakeRPC' PhotonView: ").GetComponent<AudioSampler>().isMuted = false;
			}
		}
	}

	// Token: 0x0600D811 RID: 55313 RVA: 0x004D1C60 File Offset: 0x004CFE60
	private IEnumerator OBICOFEAIAJ()
	{
		fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.iconFile).FullName;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSprite(fullName, fullName, true, false));
		base.StartCoroutine(this.KIGJJAGAJDP((Sprite)ResourcesManager.GetLoadedResource(fullName)));
		yield break;
	}

	// Token: 0x0600D812 RID: 55314 RVA: 0x004D1C7C File Offset: 0x004CFE7C
	private IEnumerator EIELMKBMEED()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("unsubscribemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.UnsubscribeLevel(this.fullLevelData.workshopId);
			UnityEngine.Object.Destroy(base.gameObject);
			if (Singleton<global::Scene>.Instance.id == "GameScene")
			{
				((GameScene)Singleton<global::Scene>.Instance).OnExitButton();
				((GameScene)Singleton<global::Scene>.Instance).gameObject.GetComponent<NetworkScene>().OnExitButton(1);
			}
		}
		yield break;
	}

	// Token: 0x0600D814 RID: 55316 RVA: 0x004D1C97 File Offset: 0x004CFE97
	public void IMJKKFLAEFF()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.infoCanvas.SetActive(true);
		this.leaderboardsCanvas.SetActive(false);
		this.MCFOJLKAACB();
		this.InitRateButton();
	}

	// Token: 0x0600D815 RID: 55317 RVA: 0x004D1CD8 File Offset: 0x004CFED8
	private void MCFOJLKAACB()
	{
		this.rateCanvas.transform.Find("_TimeX").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(this.fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(this.fullLevelData.workshopId)) != 0 || true);
		this.rateCanvas.transform.Find("_Value").GetComponent<Toggle>().isOn = (Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) == 0 || Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(this.fullLevelData.workshopId)) != -1 || true);
	}

	// Token: 0x0600D816 RID: 55318 RVA: 0x004D1DCF File Offset: 0x004CFFCF
	public void JMEOGJHCONJ()
	{
		this.LoadMapperNickname();
		base.StartCoroutine(this.MFEGJEEIJJP());
		base.StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(base.gameObject, false, null, false, 1621f, false));
	}

	// Token: 0x0600D817 RID: 55319 RVA: 0x004D1E04 File Offset: 0x004D0004
	public void MDKEGDLADCD()
	{
		if (this.fullLevelData.source == FullMapData.MapSource.Editor)
		{
			base.StartCoroutine(this.GJGPECEMPOC());
		}
		if (this.fullLevelData.source == (FullMapData.MapSource)8)
		{
			base.StartCoroutine(this.EIELMKBMEED());
		}
	}

	// Token: 0x04001873 RID: 6259
	public Image bgImage;

	// Token: 0x04001874 RID: 6260
	public GameObject listMessage;

	// Token: 0x04001875 RID: 6261
	public GameObject highscoresElement;

	// Token: 0x04001876 RID: 6262
	public int launchLevelMode;

	// Token: 0x04001877 RID: 6263
	public FullMapData fullLevelData;

	// Token: 0x04001878 RID: 6264
	public GameObject infoCanvas;

	// Token: 0x04001879 RID: 6265
	public GameObject rateCanvas;

	// Token: 0x0400187A RID: 6266
	public GameObject leaderboardsCanvas;

	// Token: 0x0400187B RID: 6267
	public GameObject lockedCanvas;

	// Token: 0x0400187C RID: 6268
	public GameObject highscoresScrollRectContent;

	// Token: 0x0400187D RID: 6269
	public GameObject loaderPanel;

	// Token: 0x0400187E RID: 6270
	public GameObject rateButton;

	// Token: 0x0400187F RID: 6271
	public GameObject ratedUpButton;

	// Token: 0x04001880 RID: 6272
	public GameObject ratedDownButton;

	// Token: 0x04001881 RID: 6273
	public GameObject favButton;

	// Token: 0x04001882 RID: 6274
	public GameObject delButton;

	// Token: 0x04001883 RID: 6275
	public GameObject moreInfoButton;

	// Token: 0x04001884 RID: 6276
	public GameObject workshopButton;

	// Token: 0x04001885 RID: 6277
	public AudioSource audioSource;

	// Token: 0x04001886 RID: 6278
	public bool isSelected;
}
