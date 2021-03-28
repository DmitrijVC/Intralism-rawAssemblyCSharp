using System;
using System.Collections;
using System.Globalization;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200037D RID: 893
public class ChallengeListElement : MonoBehaviour
{
	// Token: 0x0600C4EB RID: 50411 RVA: 0x004771A8 File Offset: 0x004753A8
	public void PFMJPIJONIP(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.BBPGJKOIAKM();
		this.EOBIHAGLMIK();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.GetProgress();
		this.PKNEKFHMCOJ();
	}

	// Token: 0x0600C4EC RID: 50412 RVA: 0x0047720C File Offset: 0x0047540C
	private void JAMNLCBMABC()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).OLPHAJDLEDK()))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(true);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C4ED RID: 50413 RVA: 0x00477280 File Offset: 0x00475480
	private void KKMMFEPKFDJ()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("[PlayerController] ").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)4)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Please specify a map name or buildID").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-109];
		array[1] = "maps.";
		array[1] = LocalizationService.Instance.GetLocalizatedText("DPADHOR");
		array[8] = "menu.tabid";
		array[1] = challenge.AMBFPMPCHFE();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[2] = "[GameEvent] Exeption:";
		array[3] = LocalizationService.Instance.HOPMEAJKPHL("Texture3");
		array[1] = "[PlayerBase] Loaded music";
		array[100] = LocalizationService.Instance.HOPMEAJKPHL("Pop" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.KIJCJELFFPO();
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("DifficultyBG").ToUpper() + str;
		this.BLBBEACCFGG();
	}

	// Token: 0x0600C4EE RID: 50414 RVA: 0x00477428 File Offset: 0x00475628
	public void MDCFIHDPLIG()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("PPI: ").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("[NetworkManager] Updating rooms...").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("skin.hit_normal").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("settings.volume.editor").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.InProgress)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("LevelURLInputField").ToUpper();
		}
	}

	// Token: 0x0600C4EF RID: 50415 RVA: 0x004775C0 File Offset: 0x004757C0
	private void BLBBEACCFGG()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C4F0 RID: 50416 RVA: 0x00477634 File Offset: 0x00475834
	public void Init(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.id;
		this.OEFGNIAHHNH();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.GetProgress();
		this.MIBKLDAKMLF();
	}

	// Token: 0x0600C4F1 RID: 50417 RVA: 0x00477698 File Offset: 0x00475898
	private void PKNEKFHMCOJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C4F2 RID: 50418 RVA: 0x0047770C File Offset: 0x0047590C
	public void GOAGFAFGBDL(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.BBPGJKOIAKM();
		this.LOELNKLKDPO();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		this.MIBKLDAKMLF();
	}

	// Token: 0x0600C4F3 RID: 50419 RVA: 0x00477770 File Offset: 0x00475970
	public void OnClick()
	{
		DateTime t = DateTime.UtcNow.AddHours(3.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.AcceptChallenge(Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ), true);
				this.OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.OEFGNIAHHNH();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.TryGetReward(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C4F4 RID: 50420 RVA: 0x00477854 File Offset: 0x00475A54
	private void PNBDOOFABJB()
	{
		if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Params1").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_ReflectionTexture3").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[111];
		array[0] = "JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.";
		array[1] = LocalizationService.Instance.GetLocalizatedText("LevelNameInputField");
		array[6] = "Set Particle Size";
		array[7] = challenge.IGAHKBHFBNE();
		array[0] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[5] = "Bad parameters for setbool! Use <key> <value>";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("Clear Environment");
		array[4] = "Tab2Content";
		array[124] = LocalizationService.Instance.GetLocalizatedText("_DisplayVelocityScale" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("maps.").ToUpper() + reward;
		this.MHIKFCHKCPP();
	}

	// Token: 0x0600C4F5 RID: 50421 RVA: 0x004779FC File Offset: 0x00475BFC
	public IEnumerator BEBNOKFLJPH()
	{
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			string text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C4F6 RID: 50422 RVA: 0x00477A18 File Offset: 0x00475C18
	public IEnumerator KDMANOEMOCA()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C4F7 RID: 50423 RVA: 0x00477A34 File Offset: 0x00475C34
	public void POEMOLBJDLG()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value3").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("ready").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("ArcsNoHitsoundTimeDelaySlider").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)8)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("[PlayerController] ").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_ColorBuffer").ToUpper();
		}
	}

	// Token: 0x0600C4F8 RID: 50424 RVA: 0x00477BCC File Offset: 0x00475DCC
	public void FIMJABKECNG(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.HJCBNLFCNAM();
		this.CIPOJCALGKN();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		this.INLBJELNLAL();
	}

	// Token: 0x0600C4F9 RID: 50425 RVA: 0x00477C30 File Offset: 0x00475E30
	public IEnumerator AKHCOBHHGJP()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C4FA RID: 50426 RVA: 0x00477C4C File Offset: 0x00475E4C
	public void NKLNGGOHLMO(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.HJCBNLFCNAM();
		this.POBAEGNACOL();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PDPNJDOCEOE(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		this.JAMNLCBMABC();
	}

	// Token: 0x0600C4FB RID: 50427 RVA: 0x00477CB0 File Offset: 0x00475EB0
	private void OEFGNIAHHNH()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("[#clicktoacceptchallenge]").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("[#clicktogetreward]").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		this.infoText.text = string.Concat(new string[]
		{
			"<b>",
			LocalizationService.Instance.GetLocalizatedText("#task"),
			":</b> ",
			challengeByID.info,
			Environment.NewLine,
			Environment.NewLine,
			"<b>",
			LocalizationService.Instance.GetLocalizatedText("#status"),
			":</b> ",
			LocalizationService.Instance.GetLocalizatedText("#" + challengeByID.PlayerStatus.ToString().ToLower())
		});
		string reward = challengeByID.reward;
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("#reward: ").ToUpper() + reward;
		this.MIBKLDAKMLF();
	}

	// Token: 0x0600C4FC RID: 50428 RVA: 0x00477E58 File Offset: 0x00476058
	public IEnumerator DKGBFNCOAEO()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C4FD RID: 50429 RVA: 0x00477E74 File Offset: 0x00476074
	private void INLBJELNLAL()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C4FE RID: 50430 RVA: 0x00477EE8 File Offset: 0x004760E8
	private void GDAFKPFKGIM()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("offsets").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)8)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Atmosphere_Fog").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[102];
		array[1] = "LostLive";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL(".lastCheckpoint.checkpointsUsed");
		array[3] = "event";
		array[5] = challenge.IGAHKBHFBNE();
		array[3] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[7] = "pointBuffer";
		array[1] = LocalizationService.Instance.GetLocalizatedText("Noise shaders are not set up! Disabling noise effect.");
		array[6] = "_Extra";
		array[-47] = LocalizationService.Instance.GetLocalizatedText("]" + challenge.PlayerStatus.ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.NJPNFKMPJNE();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("Joystick1Button5").ToUpper() + str;
		this.MHIKFCHKCPP();
	}

	// Token: 0x0600C4FF RID: 50431 RVA: 0x00478090 File Offset: 0x00476290
	public IEnumerator PAKPHKPDKGE()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C500 RID: 50432 RVA: 0x004780AC File Offset: 0x004762AC
	public void OCPFHCPEFCM()
	{
		DateTime t = DateTime.UtcNow.AddHours(1.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.MBJHDNCOGIK(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ), false);
				this.LJHCMDOMAAD();
			}
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.Complete && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.MDDHIDGCIMK();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EEIMLBLFCCA(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C501 RID: 50433 RVA: 0x00478190 File Offset: 0x00476390
	public void ALKBNPMCEOM(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.AKJKDMMKNFO();
		this.LOGGOJBMPCG();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.PPNOAHBNHHN(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.NHMJGGCONBA();
		this.ELFIMAMIENI();
	}

	// Token: 0x0600C502 RID: 50434 RVA: 0x004781F4 File Offset: 0x004763F4
	private void APFLHIECIAE()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).PNHHKLBLPEB()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(true);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C503 RID: 50435 RVA: 0x00478268 File Offset: 0x00476468
	public void LIMLHBICMPL()
	{
		DateTime t = DateTime.UtcNow.AddHours(1138.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.MIDCODCLJLE(Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ), false);
				this.PNBDOOFABJB();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.InProgress && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = true;
				this.PNBDOOFABJB();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.BOBKIIPNBND(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C504 RID: 50436 RVA: 0x0047834C File Offset: 0x0047654C
	private void EOBIHAGLMIK()
	{
		if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("CompletedLevel").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("#ok").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-93];
		array[1] = "Object ID. Case-Sensitive";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("y");
		array[7] = "Set Sun Colors";
		array[4] = challenge.info;
		array[8] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[4] = "Items/";
		array[1] = LocalizationService.Instance.GetLocalizatedText("settings.selectormapsperpage");
		array[0] = " not exist";
		array[37] = LocalizationService.Instance.GetLocalizatedText(")" + challenge.PlayerStatus.ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.BAMLNCCNGFB();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper() + str;
		this.KNICJEFJFAF();
	}

	// Token: 0x0600C505 RID: 50437 RVA: 0x004784F4 File Offset: 0x004766F4
	private void LJHCMDOMAAD()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("_EmissionColor").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("OpGetGameList()").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[98];
		array[0] = "<b>Max Score</b>:";
		array[0] = LocalizationService.Instance.GetLocalizatedText("hand");
		array[1] = "_Bullet_5";
		array[8] = challenge.EBENNNMBEAP();
		array[6] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[5] = "BitsData";
		array[3] = LocalizationService.Instance.HOPMEAJKPHL(" Message: ");
		array[7] = "/";
		array[14] = LocalizationService.Instance.HOPMEAJKPHL("A" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.ONMCIPNMCAF();
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("EventSystem").ToUpper() + str;
		this.PKNEKFHMCOJ();
	}

	// Token: 0x0600C506 RID: 50438 RVA: 0x0047869C File Offset: 0x0047689C
	public void MPELHKFCCFA()
	{
		DateTime t = DateTime.UtcNow.AddHours(1743.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ), true);
				this.LOELNKLKDPO();
			}
			if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.Complete && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = true;
				this.LOGGOJBMPCG();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.PBALPILMOKK(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C507 RID: 50439 RVA: 0x00478780 File Offset: 0x00476980
	public void LDKFAGOEDKF(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.NJNBOPKBLKK();
		this.MDDHIDGCIMK();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PKJLNIKOKCP(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		this.EECOAHLCCHH();
	}

	// Token: 0x0600C508 RID: 50440 RVA: 0x004787E4 File Offset: 0x004769E4
	private void JLIFPFHKDMK()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("_Blue_C").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("MapCreationCanvas").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-78];
		array[0] = ".mp3";
		array[1] = LocalizationService.Instance.GetLocalizatedText("Set sun min/max size");
		array[4] = "_Value";
		array[0] = challenge.DPKPLOJNEOG();
		array[8] = Environment.NewLine;
		array[2] = Environment.NewLine;
		array[4] = "_SSAO";
		array[7] = LocalizationService.Instance.HOPMEAJKPHL("_ChromaticAberration");
		array[0] = "CameraFilterPack/BlurTiltShift_Hole";
		array[-23] = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Gradients_FireGradient" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("OpAuthenticate()").ToUpper() + reward;
		this.PKNEKFHMCOJ();
	}

	// Token: 0x0600C509 RID: 50441 RVA: 0x0047898C File Offset: 0x00476B8C
	public IEnumerator OHFOLGANOLC()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C50A RID: 50442 RVA: 0x004789A8 File Offset: 0x00476BA8
	public IEnumerator MGMAOBPPOBJ()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C50B RID: 50443 RVA: 0x004789C4 File Offset: 0x00476BC4
	public void ABFNJCEBIKA()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).DGAKBIEHAJC() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("/").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("event").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL(" timeUntilRespawn: ").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Have you fully accept the terms?").ToUpper();
		}
	}

	// Token: 0x0600C50C RID: 50444 RVA: 0x00478B5C File Offset: 0x00476D5C
	public void LCJHDLKJEOM()
	{
		if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("menu.relaxinfo").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Error: I/O Failure").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText(".g").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)8)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)5)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Hidden/Subpixel Morphological Anti-aliasing").ToUpper();
		}
	}

	// Token: 0x0600C50D RID: 50445 RVA: 0x00478CF4 File Offset: 0x00476EF4
	public void ONFIKFDPHLL()
	{
		DateTime t = DateTime.UtcNow.AddHours(1088.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.JGLNHCHILNJ(Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ), true);
				this.PNBDOOFABJB();
			}
			if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)4 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.BJLHNNBLHKC();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.CINMGCJPABI(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C50E RID: 50446 RVA: 0x00478DD8 File Offset: 0x00476FD8
	private void CFKMEAENIEJ()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).PNHHKLBLPEB()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(true);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C50F RID: 50447 RVA: 0x00478E4C File Offset: 0x0047704C
	public void NOBNCNJKOLA(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.IKACPLICNNB();
		this.HDKLNBKGFKH();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.GetProgress();
		this.MHIKFCHKCPP();
	}

	// Token: 0x0600C510 RID: 50448 RVA: 0x00478EB0 File Offset: 0x004770B0
	public void BDDNELHPLNI()
	{
		DateTime t = DateTime.UtcNow.AddHours(22.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.ALDHFENHIDP(Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ), false);
				this.HDKLNBKGFKH();
			}
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)6 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.MDDHIDGCIMK();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.FAFMBMPLOCI(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C511 RID: 50449 RVA: 0x00478F94 File Offset: 0x00477194
	public void AOHJJDALDPL()
	{
		DateTime t = DateTime.UtcNow.AddHours(788.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GDLKPBLABII(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ), false);
				this.GDAFKPFKGIM();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.BKKHHJAMNOB();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.BOBKIIPNBND(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C512 RID: 50450 RVA: 0x00479078 File Offset: 0x00477278
	private void MIBKLDAKMLF()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C513 RID: 50451 RVA: 0x004790EC File Offset: 0x004772EC
	private void PNJKMILCMPI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).CKEGGOIGPIO()))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C514 RID: 50452 RVA: 0x00479160 File Offset: 0x00477360
	public void NNFJJJLBPKE(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		this.OEFGNIAHHNH();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.PPNOAHBNHHN(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		this.OBCDJFHEDGG();
	}

	// Token: 0x0600C515 RID: 50453 RVA: 0x004791C4 File Offset: 0x004773C4
	public void EHBMHKDHAEG()
	{
		DateTime t = DateTime.UtcNow.AddHours(639.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.KCKLDEBDNFB(Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ), true);
				this.FLJALKKICLN();
			}
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.ObtainedReward && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = false;
				this.FHNJLKMHJHA();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.CGBGIGPIAHL(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C516 RID: 50454 RVA: 0x004792A8 File Offset: 0x004774A8
	private void BKKHHJAMNOB()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)4)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("[PlayerController] ").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[0];
		array[1] = "Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_InvViewProj");
		array[8] = "Tab2Content";
		array[1] = challenge.FBCMLBBHIEE();
		array[7] = Environment.NewLine;
		array[8] = Environment.NewLine;
		array[0] = "_TimeX";
		array[6] = LocalizationService.Instance.GetLocalizatedText("Drop_With_Obj");
		array[6] = "float,1.5";
		array[14] = LocalizationService.Instance.GetLocalizatedText(".completedMaps" + challenge.JMGIKADHIGM().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("Set Satellite Trail MinVertexDistance").ToUpper() + reward;
		this.EECOAHLCCHH();
	}

	// Token: 0x0600C517 RID: 50455 RVA: 0x00479450 File Offset: 0x00477650
	public void IIFCIDDJHPM()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).DGAKBIEHAJC() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("player.deleted").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("HitVariationSlider").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Could not find RPC with index: ").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_FixDistance").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText(".lastCheckpoint.incorrectScore").ToUpper();
		}
	}

	// Token: 0x0600C518 RID: 50456 RVA: 0x004795E8 File Offset: 0x004777E8
	public void NHJNFAFBIFP()
	{
		DateTime t = DateTime.UtcNow.AddHours(160.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.ALDHFENHIDP(Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ), false);
				this.LOGGOJBMPCG();
			}
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.JLIFPFHKDMK();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.CINMGCJPABI(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C519 RID: 50457 RVA: 0x004796CC File Offset: 0x004778CC
	public IEnumerator HIPEHGNBJMN()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C51A RID: 50458 RVA: 0x004796E8 File Offset: 0x004778E8
	public void ONKDMMJPEMN()
	{
		if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("CompletedLevel").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Blend2Camera_LinearDodge").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.Complete)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_ChannelMixerBlue").ToUpper();
		}
	}

	// Token: 0x0600C51B RID: 50459 RVA: 0x00479880 File Offset: 0x00477A80
	public void AOEEOKNJDCK(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.NJNBOPKBLKK();
		this.EOBIHAGLMIK();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.startDateTime, CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		this.KNICJEFJFAF();
	}

	// Token: 0x0600C51C RID: 50460 RVA: 0x004798E4 File Offset: 0x00477AE4
	public void PAFMNAIDAFH(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		this.JLIFPFHKDMK();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.ONELLAMBEAG(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.DPKBMGBGEPJ();
		this.PNJKMILCMPI();
	}

	// Token: 0x0600C51D RID: 50461 RVA: 0x00479948 File Offset: 0x00477B48
	private void CFCMJBPDLBI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C51E RID: 50462 RVA: 0x004799BC File Offset: 0x00477BBC
	private void AECJNOBOIJB()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("[Down]").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)8)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("Hello").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[45];
		array[0] = "Already exist!";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("GLITCH");
		array[3] = "subscribeall";
		array[2] = challenge.FBCMLBBHIEE();
		array[3] = Environment.NewLine;
		array[2] = Environment.NewLine;
		array[8] = "EnvironmentSlider";
		array[6] = LocalizationService.Instance.GetLocalizatedText("icon");
		array[2] = "_Value";
		array[-100] = LocalizationService.Instance.HOPMEAJKPHL("_TimeX" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.FPMDJMOAEFM();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("DPADHOR").ToUpper() + str;
		this.PNJKMILCMPI();
	}

	// Token: 0x0600C51F RID: 50463 RVA: 0x00479B64 File Offset: 0x00477D64
	private void FHNJLKMHJHA()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("note.4").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.InProgress)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Failed to InstantiateSceneObject prefab: ").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[75];
		array[0] = "mapselector.tags.";
		array[1] = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Blend2Camera_ColorBurn");
		array[4] = "[MapsData] Preloading ";
		array[3] = challenge.DPKPLOJNEOG();
		array[8] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[7] = "z";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[7] = "ItemNameBGImage";
		array[-43] = LocalizationService.Instance.GetLocalizatedText("_InvRenderTargetSize" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)").ToUpper() + reward;
		this.INLBJELNLAL();
	}

	// Token: 0x0600C520 RID: 50464 RVA: 0x00479D0C File Offset: 0x00477F0C
	public void DEIMIKBHIIF()
	{
		DateTime t = DateTime.UtcNow.AddHours(1450.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ), false);
				this.LJHCMDOMAAD();
			}
			if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)4 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.LOELNKLKDPO();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.IJIEFKLHMPF(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C521 RID: 50465 RVA: 0x00479DF0 File Offset: 0x00477FF0
	public IEnumerator OGJJDKENBNC()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C522 RID: 50466 RVA: 0x00479E0C File Offset: 0x0047800C
	public void BHDPKGOKKPF()
	{
		DateTime t = DateTime.UtcNow.AddHours(795.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.IIJFAJMPAEF(Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ), true);
				this.AECJNOBOIJB();
			}
			if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = true;
				this.LJHCMDOMAAD();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.IJIEFKLHMPF(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C523 RID: 50467 RVA: 0x00479EF0 File Offset: 0x004780F0
	public void AKCADICOFDD()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).OCNOEDGAPNL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("menu.selectedlevelid").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("HightScoreMaxPointsText").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.Complete)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("SetRotation").ToUpper();
		}
	}

	// Token: 0x0600C524 RID: 50468 RVA: 0x0047A088 File Offset: 0x00478288
	private void CIPOJCALGKN()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value3").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)8)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Alternative").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-84];
		array[1] = "\n";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[7] = "Can't set visible when not in that room.";
		array[3] = challenge.IOCJJJCAFLK();
		array[6] = Environment.NewLine;
		array[2] = Environment.NewLine;
		array[1] = "_TimeX";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_Distortion");
		array[1] = "/";
		array[26] = LocalizationService.Instance.HOPMEAJKPHL("Tab2Content" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.MEHPEEFFGPH();
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("_Parameter").ToUpper() + str;
		this.ELFIMAMIENI();
	}

	// Token: 0x0600C525 RID: 50469 RVA: 0x0047A230 File Offset: 0x00478430
	public void PEEFILGCABG(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.PHCHLPBPKHL();
		this.JLIFPFHKDMK();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.NHMJGGCONBA();
		this.KNICJEFJFAF();
	}

	// Token: 0x0600C526 RID: 50470 RVA: 0x0047A294 File Offset: 0x00478494
	public IEnumerator MNBPNHNAEBK()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C527 RID: 50471 RVA: 0x0047A2B0 File Offset: 0x004784B0
	public IEnumerator KOFAMEKHHGD()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C528 RID: 50472 RVA: 0x0047A2CC File Offset: 0x004784CC
	public IEnumerator AGEJKLMJGDO()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C529 RID: 50473 RVA: 0x0047A2E8 File Offset: 0x004784E8
	private void CDJAHKOLGDA()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("team").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)6)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-94];
		array[0] = "[Left]";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[3] = "BitsData";
		array[6] = challenge.AMBFPMPCHFE();
		array[4] = Environment.NewLine;
		array[8] = Environment.NewLine;
		array[0] = "player.licenceaccepted";
		array[4] = LocalizationService.Instance.HOPMEAJKPHL("MusicFileSelector");
		array[1] = "_MainTex2";
		array[57] = LocalizationService.Instance.HOPMEAJKPHL("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting." + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.FPMDJMOAEFM();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("bad").ToUpper() + str;
		this.INLBJELNLAL();
	}

	// Token: 0x0600C52B RID: 50475 RVA: 0x0047A490 File Offset: 0x00478690
	public IEnumerator JKBMKPDGCHG()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C52C RID: 50476 RVA: 0x0047A4AC File Offset: 0x004786AC
	public void LCDJFJIBADI()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("float,10").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Distortion_Wave_Horizontal").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("In Maps Editor").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("BitsData").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)4)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("No player left to ask").ToUpper();
		}
	}

	// Token: 0x0600C52D RID: 50477 RVA: 0x0047A644 File Offset: 0x00478844
	private void PGGLDHFKGOC()
	{
		if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("w").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.InProgress)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("ReconnectToMaster() with AuthValues == null is not correct!").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[10];
		array[0] = "player.blackcat";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_Value4");
		array[5] = " ";
		array[5] = challenge.EBENNNMBEAP();
		array[8] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[6] = "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings";
		array[2] = LocalizationService.Instance.HOPMEAJKPHL("_Value3");
		array[3] = "#tryagain";
		array[29] = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Color_Convert_Normal" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution").ToUpper() + reward;
		this.INLBJELNLAL();
	}

	// Token: 0x0600C52E RID: 50478 RVA: 0x0047A7EC File Offset: 0x004789EC
	public void FABMDEHEDNO()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("\\").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL(" timeUntilRespawn: ").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_DiffuseColor").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value1").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.InProgress)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("workshop.").ToUpper();
		}
	}

	// Token: 0x0600C52F RID: 50479 RVA: 0x0047A984 File Offset: 0x00478B84
	public void JEPPDIDLANG()
	{
		DateTime t = DateTime.UtcNow.AddHours(1311.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ), false);
				this.FHNJLKMHJHA();
			}
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)7 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.HDKLNBKGFKH();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.MLIHOLEHFIM(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C530 RID: 50480 RVA: 0x0047AA68 File Offset: 0x00478C68
	private void MHIKFCHKCPP()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(true);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C531 RID: 50481 RVA: 0x0047AADC File Offset: 0x00478CDC
	private void MDDHIDGCIMK()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("_Value").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)4)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("z").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-92];
		array[0] = "CameraFilterPack/3D_Matrix";
		array[1] = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution");
		array[5] = "CameraFilterPack/Drawing_Manga_Color";
		array[5] = challenge.DPKPLOJNEOG();
		array[6] = Environment.NewLine;
		array[1] = Environment.NewLine;
		array[4] = " registered.";
		array[3] = LocalizationService.Instance.HOPMEAJKPHL("maphash");
		array[8] = "_Saturation";
		array[-18] = LocalizationService.Instance.HOPMEAJKPHL("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.NJPNFKMPJNE();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Vision_Warp").ToUpper() + str;
		this.APFLHIECIAE();
	}

	// Token: 0x0600C532 RID: 50482 RVA: 0x0047AC84 File Offset: 0x00478E84
	private void NADOLPJJFNL()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Set satellite audio input").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)8)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[49];
		array[0] = "Particles/Additive";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("x");
		array[3] = "_Value2";
		array[0] = challenge.IOCJJJCAFLK();
		array[7] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[7] = "Clears the console and prints the logs in the specified range";
		array[7] = LocalizationService.Instance.HOPMEAJKPHL("UpdateNewsTileStart");
		array[6] = "_TimeX";
		array[48] = LocalizationService.Instance.HOPMEAJKPHL("[LocalizationService] All keys for " + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.NJPNFKMPJNE();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText(".lastCheckpoint.currentCombo").ToUpper() + str;
		this.CFCMJBPDLBI();
	}

	// Token: 0x0600C533 RID: 50483 RVA: 0x0047AE2C File Offset: 0x0047902C
	public void AEIJFLJEABG()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value4").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Sprite").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value2").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)5)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Show Image").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.Complete)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("SetPlayerDistance").ToUpper();
		}
	}

	// Token: 0x0600C534 RID: 50484 RVA: 0x0047AFC4 File Offset: 0x004791C4
	public void AKMLEJJBBNG(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.AKJKDMMKNFO();
		this.GDAFKPFKGIM();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PKJLNIKOKCP(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		this.BLBBEACCFGG();
	}

	// Token: 0x0600C535 RID: 50485 RVA: 0x0047B028 File Offset: 0x00479228
	public IEnumerator HLIAEEMGBHN()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C536 RID: 50486 RVA: 0x0047B044 File Offset: 0x00479244
	public void HPKNKMOCCHJ()
	{
		DateTime t = DateTime.UtcNow.AddHours(1180.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.LCJFAOGLEEM(Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ), false);
				this.HADPIJCKFMA();
			}
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.JLIFPFHKDMK();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.CGBGIGPIAHL(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C537 RID: 50487 RVA: 0x0047B128 File Offset: 0x00479328
	public void LHIEKHPLMFI(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.PHCHLPBPKHL();
		this.GDAFKPFKGIM();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.endDateTime, CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		this.MIBKLDAKMLF();
	}

	// Token: 0x0600C538 RID: 50488 RVA: 0x0047B18C File Offset: 0x0047938C
	public void AKBAPOMKFPE()
	{
		DateTime t = DateTime.UtcNow.AddHours(1875.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.IIJFAJMPAEF(Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ), true);
				this.PNBDOOFABJB();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)8 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.CIPOJCALGKN();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.BOBKIIPNBND(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C539 RID: 50489 RVA: 0x0047B270 File Offset: 0x00479470
	private void BJLHNNBLHKC()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value2").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("value").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[92];
		array[0] = ".";
		array[0] = LocalizationService.Instance.GetLocalizatedText("_Value4");
		array[5] = "Tab1Content";
		array[6] = challenge.FBCMLBBHIEE();
		array[7] = Environment.NewLine;
		array[8] = Environment.NewLine;
		array[8] = "settings_bindings_controller_type";
		array[2] = LocalizationService.Instance.HOPMEAJKPHL("achievements.26.progress");
		array[1] = "offsets";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL(" does not exist!" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.JDMKFLEFEFA();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("[LevelEditorScene] Print Audio Wave: Start").ToUpper() + str;
		this.AEKABKKFDHI();
	}

	// Token: 0x0600C53A RID: 50490 RVA: 0x0047B418 File Offset: 0x00479618
	public void JLPBFDFLBAF()
	{
		DateTime t = DateTime.UtcNow.AddHours(881.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.JGLNHCHILNJ(Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ), true);
				this.AECJNOBOIJB();
			}
			if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.InProgress && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.JLIFPFHKDMK();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.MLIHOLEHFIM(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C53B RID: 50491 RVA: 0x0047B4FC File Offset: 0x004796FC
	public void LCKKDMKJJEF(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.IHBDBALJGBO();
		this.LJHCMDOMAAD();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.PKJLNIKOKCP(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.PPNOAHBNHHN(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.GetProgress();
		this.AEKABKKFDHI();
	}

	// Token: 0x0600C53C RID: 50492 RVA: 0x0047B560 File Offset: 0x00479760
	private void LOGGOJBMPCG()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)4)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL(" is muted").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[20];
		array[1] = "Select";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("_Value");
		array[6] = "settings.enableranking";
		array[2] = challenge.IGAHKBHFBNE();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[3] = "_TimeX";
		array[5] = LocalizationService.Instance.GetLocalizatedText("powerup.1");
		array[7] = "Result for ";
		array[-60] = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Blur_Radial" + challenge.DGAKBIEHAJC().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.FPMDJMOAEFM();
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("Children").ToUpper() + str;
		this.JAMNLCBMABC();
	}

	// Token: 0x0600C53D RID: 50493 RVA: 0x0047B708 File Offset: 0x00479908
	public void FECMEIJGLJI(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.KHCJFLGCAFL();
		this.POBAEGNACOL();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.HHBIFFOHFJE();
		this.EECOAHLCCHH();
	}

	// Token: 0x0600C53E RID: 50494 RVA: 0x0047B76C File Offset: 0x0047996C
	public IEnumerator CEDFFAOOPOG()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C53F RID: 50495 RVA: 0x0047B788 File Offset: 0x00479988
	public void GFBDFGACCLH()
	{
		DateTime t = DateTime.UtcNow.AddHours(1402.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.NMAJHGEGJCG(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ), true);
				this.OEFGNIAHHNH();
			}
			if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)7 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = false;
				this.FLJALKKICLN();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.CINMGCJPABI(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C540 RID: 50496 RVA: 0x0047B86C File Offset: 0x00479A6C
	public void ONNJFFAFGGN()
	{
		DateTime t = DateTime.UtcNow.AddHours(1223.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.PMBBDPNMGHK(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ), true);
				this.MDDHIDGCIMK();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = true;
				this.PGGLDHFKGOC();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.PAIOCIDCBJL(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C541 RID: 50497 RVA: 0x0047B950 File Offset: 0x00479B50
	private void ENFIPKFPJPC()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("settings.shaders.bloomintencity").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)4)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("_Value2").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-10];
		array[0] = "[PlayerController] ";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution");
		array[0] = "<b>";
		array[4] = challenge.IGAHKBHFBNE();
		array[5] = Environment.NewLine;
		array[6] = Environment.NewLine;
		array[0] = "_Value4";
		array[4] = LocalizationService.Instance.GetLocalizatedText("Updated!");
		array[0] = "_ScreenResolution";
		array[51] = LocalizationService.Instance.HOPMEAJKPHL("Fade" + challenge.IFAJDLKJIDL().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.BBKGHFHMHDA();
		this.rewardText.text = LocalizationService.Instance.HOPMEAJKPHL("LeaderboardsButton").ToUpper() + str;
		this.OBCDJFHEDGG();
	}

	// Token: 0x0600C542 RID: 50498 RVA: 0x0047BAF8 File Offset: 0x00479CF8
	public IEnumerator ALNNIDLFILB()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C543 RID: 50499 RVA: 0x0047BB14 File Offset: 0x00479D14
	public IEnumerator FEKECCBFGMI()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C544 RID: 50500 RVA: 0x0047BB30 File Offset: 0x00479D30
	public void LKEPIEEIMAE(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.KHCJFLGCAFL();
		this.LJHCMDOMAAD();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.DPKBMGBGEPJ();
		this.PKNEKFHMCOJ();
	}

	// Token: 0x0600C545 RID: 50501 RVA: 0x0047BB94 File Offset: 0x00479D94
	public void FOMNCPKKCFN()
	{
		if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Cross").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Horizontal").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/OldFilm_Cutting1").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Object ID. Case-Sensitive").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)7)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper();
		}
	}

	// Token: 0x0600C546 RID: 50502 RVA: 0x0047BD2C File Offset: 0x00479F2C
	private void HADPIJCKFMA()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("/").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-113];
		array[1] = "SetCrosshairEmission";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("_TimeX");
		array[7] = "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.";
		array[1] = challenge.IMDDDMOPBMA();
		array[5] = Environment.NewLine;
		array[1] = Environment.NewLine;
		array[0] = "Left";
		array[4] = LocalizationService.Instance.GetLocalizatedText(".mp3");
		array[6] = "Gameplay/Base";
		array[-110] = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Light_Water" + challenge.OCNOEDGAPNL().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.NJPNFKMPJNE();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("BadgeText").ToUpper() + str;
		this.JAMNLCBMABC();
	}

	// Token: 0x0600C547 RID: 50503 RVA: 0x0047BED4 File Offset: 0x0047A0D4
	private void HDKLNBKGFKH()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText(".g").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("#no").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-20];
		array[1] = "CameraFilterPack/Blend2Camera_DarkerColor";
		array[0] = LocalizationService.Instance.HOPMEAJKPHL("#getrewardfailed: ");
		array[2] = "workshop.";
		array[4] = challenge.info;
		array[7] = Environment.NewLine;
		array[7] = Environment.NewLine;
		array[2] = "_CenterX";
		array[1] = LocalizationService.Instance.GetLocalizatedText("MusicFileSelector");
		array[2] = "VisionBlur";
		array[-122] = LocalizationService.Instance.GetLocalizatedText("#,0.00" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.ONMCIPNMCAF();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("Noise & Grain effect failing as noise texture is not assigned. please assign.").ToUpper() + str;
		this.BLBBEACCFGG();
	}

	// Token: 0x0600C548 RID: 50504 RVA: 0x0047C07C File Offset: 0x0047A27C
	public IEnumerator BOPKKCAFODF()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C549 RID: 50505 RVA: 0x0047C098 File Offset: 0x0047A298
	private void POBAEGNACOL()
	{
		if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("menu.selectedlevelid").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("(scene)").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(true);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-50];
		array[1] = "CameraFilterPack/Atmosphere_Rain_Pro_3D";
		array[0] = LocalizationService.Instance.GetLocalizatedText(" SecondsBeforeRespawn: ");
		array[3] = "_TimeX";
		array[7] = challenge.KJPHHLIPAMA();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[7] = "maps.";
		array[7] = LocalizationService.Instance.HOPMEAJKPHL("Myst_Color");
		array[2] = "FinalScoreText";
		array[-68] = LocalizationService.Instance.GetLocalizatedText("_LumTex" + challenge.IFAJDLKJIDL().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.KIJCJELFFPO();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Blend2Camera_Overlay").ToUpper() + str;
		this.BLBBEACCFGG();
	}

	// Token: 0x0600C54A RID: 50506 RVA: 0x0047C240 File Offset: 0x0047A440
	public void KMEONPMCNJG()
	{
		if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_TempTexture").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Use ticket: ").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("</color>").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_Distortion").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)7)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_FixDistance").ToUpper();
		}
	}

	// Token: 0x0600C54B RID: 50507 RVA: 0x0047C3D8 File Offset: 0x0047A5D8
	public void JNBPKNNBMDI()
	{
		if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText(" registered.").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("offsets").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).CJNNAAGGAJI() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Set Sun DirectionVector").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ICHOIEINCLP(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)5)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_MainTex2").ToUpper();
		}
	}

	// Token: 0x0600C54C RID: 50508 RVA: 0x0047C570 File Offset: 0x0047A770
	private void FLJALKKICLN()
	{
		if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("ItemNameText").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.ObtainedReward)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText(".completedMaps").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[95];
		array[1] = "OneHand";
		array[1] = LocalizationService.Instance.HOPMEAJKPHL("Gameplay/sun");
		array[3] = "[ResourcesManager] Load audio error: ";
		array[0] = challenge.info;
		array[6] = Environment.NewLine;
		array[0] = Environment.NewLine;
		array[8] = "RecieveChatActionMessage";
		array[6] = LocalizationService.Instance.GetLocalizatedText("#exitmapeditor");
		array[0] = "CameraFilterPack/Blur_Focus";
		array[-69] = LocalizationService.Instance.HOPMEAJKPHL("set id" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.MEHPEEFFGPH();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("[Up-Left]").ToUpper() + str;
		this.CFCMJBPDLBI();
	}

	// Token: 0x0600C54D RID: 50509 RVA: 0x0047C718 File Offset: 0x0047A918
	public IEnumerator ODBNMPGBCGO()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C54E RID: 50510 RVA: 0x0047C734 File Offset: 0x0047A934
	private void AEKABKKFDHI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).NFNAMIJACFE()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(true);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C54F RID: 50511 RVA: 0x0047C7A8 File Offset: 0x0047A9A8
	public void JOACBIEHHCE()
	{
		if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("/icon").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Trackpad").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("other.dust1").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.ObtainedReward)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.ObtainedReward)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText(" - ").ToUpper();
		}
	}

	// Token: 0x0600C550 RID: 50512 RVA: 0x0047C940 File Offset: 0x0047AB40
	public void BBICIPNPMLL(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.NJNBOPKBLKK();
		this.JLIFPFHKDMK();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.DPKBMGBGEPJ();
		this.OBCDJFHEDGG();
	}

	// Token: 0x0600C551 RID: 50513 RVA: 0x0047C9A4 File Offset: 0x0047ABA4
	public void OBAEDJJDCPN()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).IFAJDLKJIDL() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("13").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Vision_Blood_Fast").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL(";").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("BitsData").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper();
		}
	}

	// Token: 0x0600C552 RID: 50514 RVA: 0x0047CB3C File Offset: 0x0047AD3C
	public void LPHKBPIIEMA()
	{
		DateTime t = DateTime.UtcNow.AddHours(870.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.GHBFNOEMKJB(Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ), true);
				this.LJHCMDOMAAD();
			}
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = true;
				this.LJHCMDOMAAD();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EONFOJMJJNE(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C553 RID: 50515 RVA: 0x0047CC20 File Offset: 0x0047AE20
	public void AOLABBMIEIM()
	{
		if (Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("[NetworkMenu] Joining ").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("You need to have a Graphic control (such as an Image) for the list [").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Edited unlock conditions").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)5)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.ObtainedReward)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_NoiseAmount").ToUpper();
		}
	}

	// Token: 0x0600C554 RID: 50516 RVA: 0x0047CDB8 File Offset: 0x0047AFB8
	public void MHLHDKJJJEK(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		this.NADOLPJJFNL();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.ONELLAMBEAG(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.BADPAMEGNLK(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.OIODAMENABE();
		this.KNICJEFJFAF();
	}

	// Token: 0x0600C555 RID: 50517 RVA: 0x0047CE1C File Offset: 0x0047B01C
	public void CLPNGMEGNOC()
	{
		DateTime t = DateTime.UtcNow.AddHours(1295.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.LCJFAOGLEEM(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ), true);
				this.GDAFKPFKGIM();
			}
			if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ).OCNOEDGAPNL() == (Challenge.CurrentStatus)8 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = true;
				this.HADPIJCKFMA();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.EEIMLBLFCCA(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C556 RID: 50518 RVA: 0x0047CF00 File Offset: 0x0047B100
	public void KFMDOEEADDM()
	{
		DateTime t = DateTime.UtcNow.AddHours(1934.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).JMGIKADHIGM() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.NMAJHGEGJCG(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ), true);
				this.BKKHHJAMNOB();
			}
			if (Singleton<ChallengesManager>.Instance.PIFHBONLJCA(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = true;
				this.IHEDNJNCIPM = true;
				this.LOGGOJBMPCG();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.IJIEFKLHMPF(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C557 RID: 50519 RVA: 0x0047CFE4 File Offset: 0x0047B1E4
	public IEnumerator DLBODOFAJGM()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C558 RID: 50520 RVA: 0x0047D000 File Offset: 0x0047B200
	public void EMENGNIOCLJ(Challenge BFLLKFPPAAB)
	{
		this.DLNONMLNOJJ = BFLLKFPPAAB.NPIPMDFPLPH();
		this.LOGGOJBMPCG();
		this.DKJCKNPNPAB = DateTime.Parse(BFLLKFPPAAB.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
		this.BLKCBHFNLGB = DateTime.Parse(BFLLKFPPAAB.MGEFANJIDHA(), CultureInfo.InvariantCulture);
		this.progressBar.value = BFLLKFPPAAB.NHMJGGCONBA();
		this.ELFIMAMIENI();
	}

	// Token: 0x0600C559 RID: 50521 RVA: 0x0047D064 File Offset: 0x0047B264
	public IEnumerator CHOPDIGHJNH()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C55A RID: 50522 RVA: 0x0047D080 File Offset: 0x0047B280
	public void AGMJDGHLBMN()
	{
		if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).DGAKBIEHAJC() <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("player.currentrank").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Fade").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("maps.").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)8)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL(" This is not possible to be called for standalone input. Please check your platform and code where this is called").ToUpper();
		}
	}

	// Token: 0x0600C55B RID: 50523 RVA: 0x0047D218 File Offset: 0x0047B418
	public IEnumerator Start()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C55C RID: 50524 RVA: 0x0047D234 File Offset: 0x0047B434
	private void EECOAHLCCHH()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).NFNAMIJACFE()))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C55D RID: 50525 RVA: 0x0047D2A8 File Offset: 0x0047B4A8
	public IEnumerator KCCIEMBMOBA()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C55E RID: 50526 RVA: 0x0047D2C4 File Offset: 0x0047B4C4
	public IEnumerator FMFNILJIEIA()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C55F RID: 50527 RVA: 0x0047D2E0 File Offset: 0x0047B4E0
	public IEnumerator EFJDNLGNACH()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C560 RID: 50528 RVA: 0x0047D2FC File Offset: 0x0047B4FC
	public IEnumerator MMMDPANNAIO()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C561 RID: 50529 RVA: 0x0047D318 File Offset: 0x0047B518
	public IEnumerator DOKAKEMDALN()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C562 RID: 50530 RVA: 0x0047D334 File Offset: 0x0047B534
	public void Update()
	{
		if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus <= Challenge.CurrentStatus.InProgress)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#timeuntilend: ").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#timeuntilchallenge: ").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#finished").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#getrewardnow ").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).PlayerStatus == Challenge.CurrentStatus.ObtainedReward)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#obtained").ToUpper();
		}
	}

	// Token: 0x0600C563 RID: 50531 RVA: 0x0047D4CC File Offset: 0x0047B6CC
	public IEnumerator FJNCHGLIEMA()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C564 RID: 50532 RVA: 0x0047D4E8 File Offset: 0x0047B6E8
	private void LOELNKLKDPO()
	{
		if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("materialsquantity[").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.InProgress)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("Gameplay/sun").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[-4];
		array[0] = "_Value";
		array[0] = LocalizationService.Instance.GetLocalizatedText("_Distortion");
		array[2] = "CameraFilterPack/FX_Grid";
		array[8] = challenge.FBCMLBBHIEE();
		array[8] = Environment.NewLine;
		array[3] = Environment.NewLine;
		array[8] = "_Offsets";
		array[6] = LocalizationService.Instance.GetLocalizatedText("_Value2");
		array[5] = "#forever";
		array[-9] = LocalizationService.Instance.HOPMEAJKPHL("request" + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string str = challenge.NJPNFKMPJNE();
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("_Value2").ToUpper() + str;
		this.MHIKFCHKCPP();
	}

	// Token: 0x0600C565 RID: 50533 RVA: 0x0047D690 File Offset: 0x0047B890
	public void PFNFPINPCMH()
	{
		if (Singleton<ChallengesManager>.Instance.NLPMEFFEPIO(this.DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("CorrectHitsScoreText").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_PixelsPerMeterAtOneMeter").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText(".lastCheckpoint.perfectHits").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).IFAJDLKJIDL() == (Challenge.CurrentStatus)4)
		{
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("float,0").ToUpper();
		}
	}

	// Token: 0x0600C566 RID: 50534 RVA: 0x0047D828 File Offset: 0x0047BA28
	private void OBCDJFHEDGG()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.BOAMLFKCEDJ(this.DLNONMLNOJJ).FOFJIPLGEKL()))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C567 RID: 50535 RVA: 0x0047D89C File Offset: 0x0047BA9C
	public IEnumerator AIBNKIDADPI()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C568 RID: 50536 RVA: 0x0047D8B8 File Offset: 0x0047BAB8
	private void ELFIMAMIENI()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = false;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(false);
		}
		else
		{
			base.GetComponent<Button>().interactable = false;
			this.lockedCanvas.SetActive(false);
		}
	}

	// Token: 0x0600C569 RID: 50537 RVA: 0x0047D92C File Offset: 0x0047BB2C
	public void KMKLDAJLCNM()
	{
		if (Singleton<ChallengesManager>.Instance.LJEGAEKKDPP(this.DLNONMLNOJJ).JMGIKADHIGM() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#random #common #item").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("#md5submitionfailed: ").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("Set Satellite Color").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)6)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_Value").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).PlayerStatus == (Challenge.CurrentStatus)5)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("Triangle").ToUpper();
		}
	}

	// Token: 0x0600C56A RID: 50538 RVA: 0x0047DAC4 File Offset: 0x0047BCC4
	public IEnumerator JONGNKNLLND()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C56B RID: 50539 RVA: 0x0047DAE0 File Offset: 0x0047BCE0
	private void KNICJEFJFAF()
	{
		if (!Helpers.isChallengeUnlocked(Singleton<ChallengesManager>.Instance.NOPECAKEGAN(this.DLNONMLNOJJ).unlockCondition))
		{
			base.GetComponent<Button>().interactable = true;
			this.actionText.gameObject.SetActive(false);
			this.lockedCanvas.SetActive(true);
		}
		else
		{
			base.GetComponent<Button>().interactable = true;
			this.lockedCanvas.SetActive(true);
		}
	}

	// Token: 0x0600C56C RID: 50540 RVA: 0x0047DB54 File Offset: 0x0047BD54
	public IEnumerator MKIMDFLBFOM()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C56D RID: 50541 RVA: 0x0047DB70 File Offset: 0x0047BD70
	public IEnumerator IGPCNCJIEOJ()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C56E RID: 50542 RVA: 0x0047DB8C File Offset: 0x0047BD8C
	public void AKEIPNLIHNL()
	{
		DateTime t = DateTime.UtcNow.AddHours(1675.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.ALDHFENHIDP(Singleton<ChallengesManager>.Instance.CDDFIMMJECM(this.DLNONMLNOJJ), false);
				this.CDJAHKOLGDA();
			}
			if (Singleton<ChallengesManager>.Instance.CIHAIJPFIFP(this.DLNONMLNOJJ).JMGIKADHIGM() == (Challenge.CurrentStatus)8 && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = true;
				this.BKKHHJAMNOB();
				this.actionText.gameObject.SetActive(true);
				Singleton<ChallengesManager>.Instance.FAFMBMPLOCI(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C56F RID: 50543 RVA: 0x0047DC70 File Offset: 0x0047BE70
	public IEnumerator ILCFPCIPENO()
	{
		challengeByID = Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ);
		if (!challengeByID.icon.StartsWith("http"))
		{
			text = "challenges/" + challengeByID.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + challengeByID.id + ".icon", challengeByID.icon, false));
			this.bg.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + challengeByID.id + ".icon");
		}
		yield break;
	}

	// Token: 0x0600C570 RID: 50544 RVA: 0x0047DC8C File Offset: 0x0047BE8C
	public void OEGDGBIKNGG()
	{
		DateTime t = DateTime.UtcNow.AddHours(1557.0);
		if (t >= this.DKJCKNPNPAB && t <= this.BLKCBHFNLGB)
		{
			if (Singleton<ChallengesManager>.Instance.GetChallengeByID(this.DLNONMLNOJJ).OCNOEDGAPNL() == Challenge.CurrentStatus.NotStarted)
			{
				Singleton<ChallengesManager>.Instance.IIJFAJMPAEF(Singleton<ChallengesManager>.Instance.FJKMDIDOJMI(this.DLNONMLNOJJ), false);
				this.FHNJLKMHJHA();
			}
			if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted && !this.IHEDNJNCIPM)
			{
				base.GetComponent<Button>().interactable = false;
				this.IHEDNJNCIPM = false;
				this.PNBDOOFABJB();
				this.actionText.gameObject.SetActive(false);
				Singleton<ChallengesManager>.Instance.IIHGLLIKGKH(this.DLNONMLNOJJ);
			}
		}
	}

	// Token: 0x0600C571 RID: 50545 RVA: 0x0047DD70 File Offset: 0x0047BF70
	private void PPBOIGBIIDL()
	{
		if (Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			this.actionText.gameObject.SetActive(false);
			this.actionText.text = LocalizationService.Instance.GetLocalizatedText("Right").ToUpper();
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).DGAKBIEHAJC() == (Challenge.CurrentStatus)8)
		{
			this.actionText.gameObject.SetActive(true);
			this.actionText.text = LocalizationService.Instance.HOPMEAJKPHL("value").ToUpper();
		}
		else
		{
			this.actionText.gameObject.SetActive(false);
		}
		Challenge challenge = Singleton<ChallengesManager>.Instance.IFPIPMPFHCA(this.DLNONMLNOJJ);
		Text text = this.infoText;
		string[] array = new string[81];
		array[0] = "_MainTex2";
		array[0] = LocalizationService.Instance.GetLocalizatedText("_FilteredReflections");
		array[1] = "88f00bdf0ad61b16b803971ebe071962";
		array[6] = challenge.KJPHHLIPAMA();
		array[6] = Environment.NewLine;
		array[5] = Environment.NewLine;
		array[2] = ".lastCheckpoint.checkpointsUsed";
		array[7] = LocalizationService.Instance.GetLocalizatedText("_Overlay");
		array[5] = "HiddenToggle";
		array[-6] = LocalizationService.Instance.HOPMEAJKPHL("Call ConnectToNameServer to ping available regions." + challenge.CJNNAAGGAJI().ToString().ToLower());
		text.text = string.Concat(array);
		string reward = challenge.reward;
		this.rewardText.text = LocalizationService.Instance.GetLocalizatedText("[PlayerController] ").ToUpper() + reward;
		this.EECOAHLCCHH();
	}

	// Token: 0x0600C572 RID: 50546 RVA: 0x0047DF18 File Offset: 0x0047C118
	public void PNLKFANNOKO()
	{
		if (Singleton<ChallengesManager>.Instance.IDKBNGMCFAL(this.DLNONMLNOJJ).CJNNAAGGAJI() <= Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow = DateTime.UtcNow;
			if (utcNow >= this.DKJCKNPNPAB && utcNow <= this.BLKCBHFNLGB)
			{
				TimeSpan nmchkfgkgfj = this.BLKCBHFNLGB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("DisableStoryboardToggle").ToUpper() + nmchkfgkgfj.ToReadableString();
			}
			else if (utcNow < this.DKJCKNPNPAB)
			{
				TimeSpan nmchkfgkgfj2 = this.DKJCKNPNPAB - utcNow;
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("powerup.1").ToUpper() + nmchkfgkgfj2.ToReadableString();
			}
			else
			{
				this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_Value4").ToUpper();
			}
		}
		else if (Singleton<ChallengesManager>.Instance.ONEPNINILOC(this.DLNONMLNOJJ).IFAJDLKJIDL() == Challenge.CurrentStatus.NotStarted)
		{
			DateTime utcNow2 = DateTime.UtcNow;
			TimeSpan nmchkfgkgfj3 = this.BLKCBHFNLGB - utcNow2;
			this.timeText.text = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper() + nmchkfgkgfj3.ToReadableString();
		}
		else if (Singleton<ChallengesManager>.Instance.JGGLPBFDJKF(this.DLNONMLNOJJ).DGAKBIEHAJC() == Challenge.CurrentStatus.Complete)
		{
			this.timeText.text = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
		}
	}

	// Token: 0x0400172C RID: 5932
	public Text infoText;

	// Token: 0x0400172D RID: 5933
	public Text timeText;

	// Token: 0x0400172E RID: 5934
	public Text rewardText;

	// Token: 0x0400172F RID: 5935
	public Image bg;

	// Token: 0x04001730 RID: 5936
	public Slider progressBar;

	// Token: 0x04001731 RID: 5937
	public GameObject lockedCanvas;

	// Token: 0x04001732 RID: 5938
	public Text actionText;

	// Token: 0x04001733 RID: 5939
	private ulong DLNONMLNOJJ;

	// Token: 0x04001734 RID: 5940
	private DateTime DKJCKNPNPAB;

	// Token: 0x04001735 RID: 5941
	private DateTime BLKCBHFNLGB;

	// Token: 0x04001736 RID: 5942
	private bool IHEDNJNCIPM;
}
