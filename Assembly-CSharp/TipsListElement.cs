using System;
using System.Collections;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000408 RID: 1032
public class TipsListElement : MonoBehaviour
{
	// Token: 0x0600EC5B RID: 60507 RVA: 0x0053134C File Offset: 0x0052F54C
	private void PNOENLGEMON()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		this.rateCanvas.transform.Find("UseFinalGlassColor").GetComponent<Toggle>().isOn = (adgadpaiaic != 0 && adgadpaiaic == 1 && false);
		this.rateCanvas.transform.Find("id").GetComponent<Toggle>().isOn = (adgadpaiaic != 0 && adgadpaiaic == -1);
	}

	// Token: 0x0600EC5C RID: 60508 RVA: 0x005313D4 File Offset: 0x0052F5D4
	private void KBDJCFIIHJF()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		this.rateCanvas.transform.Find("_ColorRGB").GetComponent<Toggle>().isOn = (adgadpaiaic == 0 || adgadpaiaic != 1);
		this.rateCanvas.transform.Find("Down").GetComponent<Toggle>().isOn = (adgadpaiaic == 0 || (adgadpaiaic == -1 && false));
	}

	// Token: 0x0600EC5D RID: 60509 RVA: 0x0053145C File Offset: 0x0052F65C
	public void FNEKLACBDFL(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.KKKFBKJOBDB();
		}
		Text text = this.tipText;
		object[] array = new object[1];
		array[1] = LocalizationService.Instance.IAAEBJKAHDD("CameraFilterPack_AAA_BloodOnScreen1").ToUpper();
		array[0] = ".completed";
		array[2] = this.JANJAEPPJJN.JJKDAFNCDIF();
		array[8] = " ";
		array[7] = this.JANJAEPPJJN.LKGIPBNFPEL();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.LKHKLECGPFD() < 1) ? string.Empty : "#no") + this.JANJAEPPJJN.EPHHAGCNLNF();
		this.ADGADPAIAIC = this.JANJAEPPJJN.CDCIANGOJLC();
		this.InitRateButton();
	}

	// Token: 0x0600EC5E RID: 60510 RVA: 0x0002523B File Offset: 0x0002343B
	public void BGJEPMAENPJ()
	{
	}

	// Token: 0x0600EC5F RID: 60511 RVA: 0x0053153C File Offset: 0x0052F73C
	private IEnumerator DPOCIINMGLM(ulong CDAGKANOOHO)
	{
		string text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC60 RID: 60512 RVA: 0x0002523B File Offset: 0x0002343B
	public void DOCDJFIHIBA()
	{
	}

	// Token: 0x0600EC61 RID: 60513 RVA: 0x00531560 File Offset: 0x0052F760
	public void Init(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.LoadMapperNickname();
		}
		this.tipText.text = string.Concat(new object[]
		{
			LocalizationService.Instance.GetTextByKey("tip").ToUpper(),
			" #",
			this.JANJAEPPJJN.id,
			":\n",
			this.JANJAEPPJJN.tip
		});
		this.ratingText.text = ((this.JANJAEPPJJN.GetRating() < 0) ? string.Empty : "+") + this.JANJAEPPJJN.GetRating();
		this.ADGADPAIAIC = this.JANJAEPPJJN.GetUserVote();
		this.InitRateButton();
	}

	// Token: 0x0600EC62 RID: 60514 RVA: 0x0002523B File Offset: 0x0002343B
	public void DCFPCNCCAMD()
	{
	}

	// Token: 0x0600EC63 RID: 60515 RVA: 0x00531640 File Offset: 0x0052F840
	private IEnumerator ODALOLJABEE(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC64 RID: 60516 RVA: 0x0002523B File Offset: 0x0002343B
	public void IJIBEKLPMLK()
	{
	}

	// Token: 0x0600EC65 RID: 60517 RVA: 0x00531664 File Offset: 0x0052F864
	public void LCGMHCBNCDM(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.LAFBHOEGMDN();
		}
		Text text = this.tipText;
		object[] array = new object[3];
		array[1] = LocalizationService.Instance.GetTextByKey(" ").ToUpper();
		array[0] = "_TimeX";
		array[5] = this.JANJAEPPJJN.OKFOADGNODA();
		array[7] = "_EdgeWeight";
		array[2] = this.JANJAEPPJJN.IHDFNLLIHPN();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.EIBIDABNHLP() < 0) ? string.Empty : "player.gamecompleted") + this.JANJAEPPJJN.FEDBIGMAHEA();
		this.ADGADPAIAIC = this.JANJAEPPJJN.IGJGHMHMOOH();
		this.PDMNHDIEEJD();
	}

	// Token: 0x0600EC66 RID: 60518 RVA: 0x00531744 File Offset: 0x0052F944
	public void AOEEOKNJDCK(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.PAJNCECFJFH();
		}
		Text text = this.tipText;
		object[] array = new object[2];
		array[0] = LocalizationService.Instance.GetTextByKey("CameraFilterPack/AAA_Super_Hexagon").ToUpper();
		array[1] = "yesterday";
		array[7] = this.JANJAEPPJJN.JJKDAFNCDIF();
		array[8] = "_TimeX";
		array[8] = this.JANJAEPPJJN.MOMHHCGBDJK();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.HEDKODDNFEA() < 0) ? string.Empty : "DPADVER") + this.JANJAEPPJJN.JLIKEOFNCPO();
		this.ADGADPAIAIC = this.JANJAEPPJJN.AJMEEPGHOAH();
		this.BKNBCCHACAD();
	}

	// Token: 0x0600EC67 RID: 60519 RVA: 0x0002523B File Offset: 0x0002343B
	public void FPLNFNLJHPP()
	{
	}

	// Token: 0x0600EC68 RID: 60520 RVA: 0x00531824 File Offset: 0x0052FA24
	public void EFEONCCCKNP(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.KKKFBKJOBDB();
		}
		Text text = this.tipText;
		object[] array = new object[5];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("CONTRAST").ToUpper();
		array[0] = "[DiscordController] Error {0}: {1}";
		array[7] = this.JANJAEPPJJN.LPEKOHPMKCE();
		array[3] = "_Value2";
		array[8] = this.JANJAEPPJJN.GNGMJGFIKGD();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.KBIEDPCEHGG() < 0) ? string.Empty : "DISTORT") + this.JANJAEPPJJN.NNLHLJDEMEA();
		this.ADGADPAIAIC = this.JANJAEPPJJN.CDCIANGOJLC();
		this.COAFHJPENIK();
	}

	// Token: 0x0600EC69 RID: 60521 RVA: 0x00531904 File Offset: 0x0052FB04
	public void JEGGEOEIOBG()
	{
		base.StartCoroutine(this.PNDAMNIBPPH(this.JANJAEPPJJN.GOKADDKEMFK()));
	}

	// Token: 0x0600EC6A RID: 60522 RVA: 0x00531920 File Offset: 0x0052FB20
	private IEnumerator PNDAMNIBPPH(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC6B RID: 60523 RVA: 0x00531942 File Offset: 0x0052FB42
	public void FPJEECBBGAI()
	{
		this.rateCanvas.SetActive(this.rateCanvas.activeSelf);
		this.PNOENLGEMON();
		this.KADJDCBHHPN();
	}

	// Token: 0x0600EC6C RID: 60524 RVA: 0x0053196C File Offset: 0x0052FB6C
	public void JKNJMJBKJMF()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
		else if (adgadpaiaic == 1)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
	}

	// Token: 0x0600EC6D RID: 60525 RVA: 0x00531A0A File Offset: 0x0052FC0A
	public void LJIJIFDEGLE()
	{
		this.rateCanvas.SetActive(this.rateCanvas.activeSelf);
		this.PICNOPDLFBE();
		this.PDMNHDIEEJD();
	}

	// Token: 0x0600EC6E RID: 60526 RVA: 0x00531A34 File Offset: 0x0052FC34
	public void EPDCHKECMBL(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.JEGGEOEIOBG();
		}
		Text text = this.tipText;
		object[] array = new object[6];
		array[1] = LocalizationService.Instance.GetTextByKey("CameraFilterPack/Vision_Warp2").ToUpper();
		array[1] = "Joystick1Button2";
		array[6] = this.JANJAEPPJJN.DFKBFAHDLJE();
		array[3] = "_ScreenResolution";
		array[8] = this.JANJAEPPJJN.FFGMCNAEAKH();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.GECKLJLICFP() < 1) ? string.Empty : "SetSatelliteLerpSpeed") + this.JANJAEPPJJN.NNLHLJDEMEA();
		this.ADGADPAIAIC = this.JANJAEPPJJN.CMIDMJKBAGJ();
		this.InitRateButton();
	}

	// Token: 0x0600EC6F RID: 60527 RVA: 0x00531B14 File Offset: 0x0052FD14
	public void OnItemRated(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		this.ADGADPAIAIC = ((!NHLFMIIGBEB) ? -1 : 1);
		this.JANJAEPPJJN.SetUserVote(this.ADGADPAIAIC);
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).GetRandomTip();
		}
		this.InitRateButton();
		this.PICNOPDLFBE();
		this.rateCanvas.SetActive(false);
	}

	// Token: 0x0600EC70 RID: 60528 RVA: 0x00531B90 File Offset: 0x0052FD90
	public void AEGBAGMKIFM()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
		}
		else if (adgadpaiaic == 1)
		{
			this.rateButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600EC71 RID: 60529 RVA: 0x00531C30 File Offset: 0x0052FE30
	public void CPFOEFKOJGA(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.ODKLCECLCJI();
		}
		Text text = this.tipText;
		object[] array = new object[3];
		array[1] = LocalizationService.Instance.IAAEBJKAHDD("BitsData").ToUpper();
		array[0] = "bloomintencity:";
		array[3] = this.JANJAEPPJJN.DFKBFAHDLJE();
		array[6] = "InfoButton";
		array[4] = this.JANJAEPPJJN.IKOLPBDKHIN();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.PKHPADAEJEG() < 1) ? string.Empty : "(master)") + this.JANJAEPPJJN.KBIEDPCEHGG();
		this.ADGADPAIAIC = this.JANJAEPPJJN.GetUserVote();
		this.AEGBAGMKIFM();
	}

	// Token: 0x0600EC72 RID: 60530 RVA: 0x00531D10 File Offset: 0x0052FF10
	private void PICNOPDLFBE()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		this.rateCanvas.transform.Find("VoteUpToggle").GetComponent<Toggle>().isOn = (adgadpaiaic != 0 && adgadpaiaic == 1);
		this.rateCanvas.transform.Find("VoteDownToggle").GetComponent<Toggle>().isOn = (adgadpaiaic != 0 && adgadpaiaic == -1);
	}

	// Token: 0x0600EC73 RID: 60531 RVA: 0x004D069D File Offset: 0x004CE89D
	public void CNAMJCBOMIH()
	{
		base.GetComponent<Button>().interactable = false;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600EC74 RID: 60532 RVA: 0x00531D98 File Offset: 0x0052FF98
	public void NKLNGGOHLMO(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.LoadMapperNickname();
		}
		Text text = this.tipText;
		object[] array = new object[2];
		array[0] = LocalizationService.Instance.GetTextByKey(".lastCheckpoint.perfectHits").ToUpper();
		array[1] = "settings.shaders";
		array[2] = this.JANJAEPPJJN.DFKBFAHDLJE();
		array[8] = "_ScreenResolution";
		array[5] = this.JANJAEPPJJN.ABPAKJHNIPG();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.JLIKEOFNCPO() < 1) ? string.Empty : "Set Particles Input") + this.JANJAEPPJJN.DNLGIMEFFDC();
		this.ADGADPAIAIC = this.JANJAEPPJJN.KJDIFACCLFL();
		this.HKFHIMBMBIP();
	}

	// Token: 0x0600EC75 RID: 60533 RVA: 0x004D069D File Offset: 0x004CE89D
	public void DHONEHCIFOE()
	{
		base.GetComponent<Button>().interactable = false;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600EC76 RID: 60534 RVA: 0x00531E78 File Offset: 0x00530078
	public void INLAGKILJOI()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.MDEMIHCKOOE();
		this.COAFHJPENIK();
	}

	// Token: 0x0600EC77 RID: 60535 RVA: 0x00531E9F File Offset: 0x0053009F
	public void MOPIFHAHGKD()
	{
		this.rateCanvas.SetActive(this.rateCanvas.activeSelf);
		this.GFCJGJHAJIM();
		this.KKOBFAEOIDF();
	}

	// Token: 0x0600EC78 RID: 60536 RVA: 0x00531EC8 File Offset: 0x005300C8
	public void PDMNHDIEEJD()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (adgadpaiaic == 1)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600EC79 RID: 60537 RVA: 0x00531F68 File Offset: 0x00530168
	public void CMFBCPNHGOF(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.JEGGEOEIOBG();
		}
		Text text = this.tipText;
		object[] array = new object[0];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("settings.fps").ToUpper();
		array[0] = "|";
		array[7] = this.JANJAEPPJJN.DFKBFAHDLJE();
		array[1] = "Result for ";
		array[2] = this.JANJAEPPJJN.CKGFBNMMPMC();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.DNLGIMEFFDC() < 1) ? string.Empty : "_MainTex2") + this.JANJAEPPJJN.FEDBIGMAHEA();
		this.ADGADPAIAIC = this.JANJAEPPJJN.AJMEEPGHOAH();
		this.JKNJMJBKJMF();
	}

	// Token: 0x0600EC7A RID: 60538 RVA: 0x00532048 File Offset: 0x00530248
	private IEnumerator JIJDJAOBPJL(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC7B RID: 60539 RVA: 0x004D007D File Offset: 0x004CE27D
	public void OnLoaderPanelCansel()
	{
		base.GetComponent<Button>().interactable = true;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600EC7C RID: 60540 RVA: 0x0053206C File Offset: 0x0053026C
	private void JBHIOKBKOLP()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		this.rateCanvas.transform.Find("_ScreenResolution").GetComponent<Toggle>().isOn = (adgadpaiaic != 0 && adgadpaiaic == 1);
		this.rateCanvas.transform.Find(" not found").GetComponent<Toggle>().isOn = (adgadpaiaic != 0 && adgadpaiaic == -1);
	}

	// Token: 0x0600EC7D RID: 60541 RVA: 0x005320F4 File Offset: 0x005302F4
	public void NFKDBPGHHIJ(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.IIDJCPLEHND();
		}
		Text text = this.tipText;
		object[] array = new object[6];
		array[0] = LocalizationService.Instance.GetTextByKey("SetParticlesParticleSize").ToUpper();
		array[1] = "Server: {0}. Region: {1} ";
		array[3] = this.JANJAEPPJJN.IHGAFOAMKAD();
		array[1] = "ShowSprite";
		array[8] = this.JANJAEPPJJN.MKLBKIJOGBG();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.HKBLIMCKKEH() < 1) ? string.Empty : ".sawoutdatedmessage") + this.JANJAEPPJJN.HKBLIMCKKEH();
		this.ADGADPAIAIC = this.JANJAEPPJJN.CMIDMJKBAGJ();
		this.HKFHIMBMBIP();
	}

	// Token: 0x0600EC7E RID: 60542 RVA: 0x005321D4 File Offset: 0x005303D4
	private IEnumerator BJGEDKLHCCH(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC7F RID: 60543 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnRateClick()
	{
	}

	// Token: 0x0600EC80 RID: 60544 RVA: 0x005321F6 File Offset: 0x005303F6
	public void IIDJCPLEHND()
	{
		base.StartCoroutine(this.IDIGDAGNKGL(this.JANJAEPPJJN.DBMLLBMLDFE()));
	}

	// Token: 0x0600EC81 RID: 60545 RVA: 0x00532210 File Offset: 0x00530410
	public void COAFHJPENIK()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
		else if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600EC82 RID: 60546 RVA: 0x005322B0 File Offset: 0x005304B0
	public void EKOAKKNGGGI(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.HGCPJNBBDMG();
		}
		Text text = this.tipText;
		object[] array = new object[]
		{
			null,
			LocalizationService.Instance.GetTextByKey("#alreadyexist").ToUpper()
		};
		array[1] = "CameraFilterPack/Light_Rainbow2";
		array[6] = this.JANJAEPPJJN.LPEKOHPMKCE();
		array[0] = "SetPlayerDistance";
		array[3] = this.JANJAEPPJJN.EBEANLDNDHL();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.JLIKEOFNCPO() < 0) ? string.Empty : "_FadeFX") + this.JANJAEPPJJN.NNLHLJDEMEA();
		this.ADGADPAIAIC = this.JANJAEPPJJN.AJMEEPGHOAH();
		this.KKOBFAEOIDF();
	}

	// Token: 0x0600EC83 RID: 60547 RVA: 0x00532390 File Offset: 0x00530590
	public void KKOBFAEOIDF()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
	}

	// Token: 0x0600EC84 RID: 60548 RVA: 0x0053242E File Offset: 0x0053062E
	public void KKKFBKJOBDB()
	{
		base.StartCoroutine(this.ODALOLJABEE(this.JANJAEPPJJN.LKKNPEBMCHA()));
	}

	// Token: 0x0600EC85 RID: 60549 RVA: 0x0002523B File Offset: 0x0002343B
	public void OLHKLCNGAGK()
	{
	}

	// Token: 0x0600EC86 RID: 60550 RVA: 0x0002523B File Offset: 0x0002343B
	public void FEGNCCNMFJC()
	{
	}

	// Token: 0x0600EC87 RID: 60551 RVA: 0x00532448 File Offset: 0x00530648
	public void ODKLCECLCJI()
	{
		base.StartCoroutine(this.DPOCIINMGLM(this.JANJAEPPJJN.OEHGOHJGENG()));
	}

	// Token: 0x0600EC88 RID: 60552 RVA: 0x00532464 File Offset: 0x00530664
	private void GFCJGJHAJIM()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		this.rateCanvas.transform.Find("CameraFilterPack/Blend2Camera_Lighten").GetComponent<Toggle>().isOn = (adgadpaiaic == 0 || adgadpaiaic == 1);
		this.rateCanvas.transform.Find("[MapsStats] Map ID: ").GetComponent<Toggle>().isOn = (adgadpaiaic == 0 || adgadpaiaic != -1 || true);
	}

	// Token: 0x0600EC89 RID: 60553 RVA: 0x005324EC File Offset: 0x005306EC
	public void NBMHPDNDBLK(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		this.ADGADPAIAIC = ((!NHLFMIIGBEB) ? -1 : 1);
		this.JANJAEPPJJN.SetUserVote(this.ADGADPAIAIC);
		if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "Moved event")
		{
			((MenuScene)Singleton<Scene>.Instance).MBEPCNGHJHE();
		}
		this.COAFHJPENIK();
		this.PICNOPDLFBE();
		this.rateCanvas.SetActive(true);
	}

	// Token: 0x0600EC8A RID: 60554 RVA: 0x00532568 File Offset: 0x00530768
	private IEnumerator NOLIEIKFMAM(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC8B RID: 60555 RVA: 0x0053258C File Offset: 0x0053078C
	private void MDEMIHCKOOE()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		this.rateCanvas.transform.Find("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?").GetComponent<Toggle>().isOn = (adgadpaiaic == 0 || (adgadpaiaic == 1 && false));
		this.rateCanvas.transform.Find("file://").GetComponent<Toggle>().isOn = (adgadpaiaic != 0 && (adgadpaiaic != -1 || true));
	}

	// Token: 0x0600EC8C RID: 60556 RVA: 0x00532612 File Offset: 0x00530812
	public void LoadMapperNickname()
	{
		base.StartCoroutine(this.KFEJNLGMENE(this.JANJAEPPJJN.steamID));
	}

	// Token: 0x0600EC8D RID: 60557 RVA: 0x0053262C File Offset: 0x0053082C
	private IEnumerator MIOLDDLCNPC(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC8E RID: 60558 RVA: 0x0002523B File Offset: 0x0002343B
	public void PGNOHMENMKL()
	{
	}

	// Token: 0x0600EC8F RID: 60559 RVA: 0x00532650 File Offset: 0x00530850
	public void MAPMJGPBCBO(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		this.ADGADPAIAIC = ((!NHLFMIIGBEB) ? -1 : 0);
		this.JANJAEPPJJN.KMJBGNACIED(this.ADGADPAIAIC);
		if (Singleton<Scene>.Instance.GOMJAEIDHNM() == "_AlphaMask")
		{
			((MenuScene)Singleton<Scene>.Instance).GetRandomTip();
		}
		this.JKNJMJBKJMF();
		this.PNOENLGEMON();
		this.rateCanvas.SetActive(true);
	}

	// Token: 0x0600EC90 RID: 60560 RVA: 0x005326CC File Offset: 0x005308CC
	private IEnumerator FJEMHPGFAOB(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC91 RID: 60561 RVA: 0x005326F0 File Offset: 0x005308F0
	private IEnumerator IDIGDAGNKGL(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC92 RID: 60562 RVA: 0x00532712 File Offset: 0x00530912
	public void KKKLOCDJAFL()
	{
		base.StartCoroutine(this.MIOLDDLCNPC(this.JANJAEPPJJN.DBCMHPJIHGG()));
	}

	// Token: 0x0600EC93 RID: 60563 RVA: 0x0053272C File Offset: 0x0053092C
	private IEnumerator MBBBIOAIMKP(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC94 RID: 60564 RVA: 0x0053274E File Offset: 0x0053094E
	public void PAJNCECFJFH()
	{
		base.StartCoroutine(this.IDIGDAGNKGL(this.JANJAEPPJJN.LHDHLDLEACP()));
	}

	// Token: 0x0600EC95 RID: 60565 RVA: 0x00532768 File Offset: 0x00530968
	public void BDKAGELNCGK()
	{
		this.rateCanvas.SetActive(this.rateCanvas.activeSelf);
		this.PICNOPDLFBE();
		this.JKNJMJBKJMF();
	}

	// Token: 0x0600EC96 RID: 60566 RVA: 0x00532790 File Offset: 0x00530990
	private IEnumerator IPFPOAPIEED(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC97 RID: 60567 RVA: 0x005327B4 File Offset: 0x005309B4
	public void FECMEIJGLJI(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.KKKFBKJOBDB();
		}
		Text text = this.tipText;
		object[] array = new object[1];
		array[1] = LocalizationService.Instance.GetTextByKey("_TimeX").ToUpper();
		array[1] = "inventory.lastitemscount";
		array[2] = this.JANJAEPPJJN.id;
		array[4] = "_EmissionColor";
		array[4] = this.JANJAEPPJJN.tip;
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.JLIKEOFNCPO() < 0) ? string.Empty : " room(s)") + this.JANJAEPPJJN.DNLGIMEFFDC();
		this.ADGADPAIAIC = this.JANJAEPPJJN.IGJGHMHMOOH();
		this.LHCOOHGJEEI();
	}

	// Token: 0x0600EC98 RID: 60568 RVA: 0x00532894 File Offset: 0x00530A94
	public void HKFHIMBMBIP()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
		else if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
	}

	// Token: 0x0600EC99 RID: 60569 RVA: 0x00532932 File Offset: 0x00530B32
	public void LAFBHOEGMDN()
	{
		base.StartCoroutine(this.DPOCIINMGLM(this.JANJAEPPJJN.DBCMHPJIHGG()));
	}

	// Token: 0x0600EC9A RID: 60570 RVA: 0x0053294C File Offset: 0x00530B4C
	private IEnumerator BAEPFHHMHNP(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC9B RID: 60571 RVA: 0x00532970 File Offset: 0x00530B70
	public void KDJHONILJGK(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.KKKFBKJOBDB();
		}
		Text text = this.tipText;
		object[] array = new object[1];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("_Green_C").ToUpper();
		array[1] = "_Far";
		array[8] = this.JANJAEPPJJN.KIHKKAFMDMF();
		array[6] = "SetSatelliteEmission";
		array[7] = this.JANJAEPPJJN.COEFMOFKOJE();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.PFHBHDDKINJ() < 1) ? string.Empty : "[Up]") + this.JANJAEPPJJN.KJDDPBDIEGD();
		this.ADGADPAIAIC = this.JANJAEPPJJN.IPLNCBFBGFJ();
		this.AEGBAGMKIFM();
	}

	// Token: 0x0600EC9C RID: 60572 RVA: 0x00532A50 File Offset: 0x00530C50
	public void EPJEBPMCLAJ()
	{
		this.rateCanvas.SetActive(this.rateCanvas.activeSelf);
		this.MDEMIHCKOOE();
		this.AEGBAGMKIFM();
	}

	// Token: 0x0600EC9D RID: 60573 RVA: 0x00532A78 File Offset: 0x00530C78
	private IEnumerator KFEJNLGMENE(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600EC9E RID: 60574 RVA: 0x00532A9A File Offset: 0x00530C9A
	public void HGCPJNBBDMG()
	{
		base.StartCoroutine(this.FJEMHPGFAOB(this.JANJAEPPJJN.DBCMHPJIHGG()));
	}

	// Token: 0x0600EC9F RID: 60575 RVA: 0x00532AB4 File Offset: 0x00530CB4
	public void BKNBCCHACAD()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
		}
		else if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600ECA0 RID: 60576 RVA: 0x00532B54 File Offset: 0x00530D54
	public void DPOELEBIAOE(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.KKKLOCDJAFL();
		}
		Text text = this.tipText;
		object[] array = new object[3];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("value").ToUpper();
		array[0] = "#ok";
		array[7] = this.JANJAEPPJJN.IHGAFOAMKAD();
		array[0] = "[LocalizationService] All keys for ";
		array[1] = this.JANJAEPPJJN.POJIOBLCHPI();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.GetRating() < 1) ? string.Empty : "_EmissionColor") + this.JANJAEPPJJN.PFHBHDDKINJ();
		this.ADGADPAIAIC = this.JANJAEPPJJN.GetUserVote();
		this.AEGBAGMKIFM();
	}

	// Token: 0x0600ECA1 RID: 60577 RVA: 0x00532C34 File Offset: 0x00530E34
	public void LLAHPNGMEOO(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.JEGGEOEIOBG();
		}
		Text text = this.tipText;
		object[] array = new object[6];
		array[0] = LocalizationService.Instance.GetTextByKey("_TimeX").ToUpper();
		array[0] = "PLEASE WAIT";
		array[1] = this.JANJAEPPJJN.DFKBFAHDLJE();
		array[1] = "_Value2";
		array[7] = this.JANJAEPPJJN.tip;
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.PFHBHDDKINJ() < 1) ? string.Empty : ". No ViewIDs are free to use. Max is: ") + this.JANJAEPPJJN.EPHHAGCNLNF();
		this.ADGADPAIAIC = this.JANJAEPPJJN.PIBNHCNPMNM();
		this.InitRateButton();
	}

	// Token: 0x0600ECA2 RID: 60578 RVA: 0x00532D14 File Offset: 0x00530F14
	public void KADJDCBHHPN()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (adgadpaiaic == 1)
		{
			this.rateButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600ECA3 RID: 60579 RVA: 0x004D007D File Offset: 0x004CE27D
	public void EPNAEDPPELH()
	{
		base.GetComponent<Button>().interactable = true;
		base.GetComponent<Button>().Select();
	}

	// Token: 0x0600ECA4 RID: 60580 RVA: 0x00532DB4 File Offset: 0x00530FB4
	public void NBIEIGBAKND(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.JEGGEOEIOBG();
		}
		Text text = this.tipText;
		object[] array = new object[]
		{
			null,
			LocalizationService.Instance.IAAEBJKAHDD("_ScreenResolution").ToUpper()
		};
		array[0] = "Joystick1Button4";
		array[5] = this.JANJAEPPJJN.id;
		array[3] = "isVisible";
		array[8] = this.JANJAEPPJJN.ABPAKJHNIPG();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.PFHBHDDKINJ() < 0) ? string.Empty : "Vertical") + this.JANJAEPPJJN.FBIJLICDDFD();
		this.ADGADPAIAIC = this.JANJAEPPJJN.CMIDMJKBAGJ();
		this.AEGBAGMKIFM();
	}

	// Token: 0x0600ECA5 RID: 60581 RVA: 0x00532E94 File Offset: 0x00531094
	public void InitRateButton()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
		}
		else if (adgadpaiaic == 1)
		{
			this.rateButton.SetActive(false);
			this.ratedDownButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(false);
			this.ratedDownButton.SetActive(true);
		}
	}

	// Token: 0x0600ECA6 RID: 60582 RVA: 0x00532F34 File Offset: 0x00531134
	private IEnumerator FDLIEMGCHHG(ulong CDAGKANOOHO)
	{
		text = string.Empty;
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO, false));
		text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, this.isBGWhite);
		this.authorText.text = text;
		yield break;
	}

	// Token: 0x0600ECA7 RID: 60583 RVA: 0x00532F56 File Offset: 0x00531156
	public void ToggleRate()
	{
		this.rateCanvas.SetActive(!this.rateCanvas.activeSelf);
		this.PICNOPDLFBE();
		this.InitRateButton();
	}

	// Token: 0x0600ECA8 RID: 60584 RVA: 0x0002523B File Offset: 0x0002343B
	public void AJIFGJPODDA()
	{
	}

	// Token: 0x0600ECA9 RID: 60585 RVA: 0x00532F80 File Offset: 0x00531180
	public void MPHGDIICPBI(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		this.ADGADPAIAIC = ((!NHLFMIIGBEB) ? -1 : 0);
		this.JANJAEPPJJN.SetUserVote(this.ADGADPAIAIC);
		if (Singleton<Scene>.Instance.ALIGPAANMFA() == "_ReflectionTexture3")
		{
			((MenuScene)Singleton<Scene>.Instance).HCNNCEPLHBE();
		}
		this.KADJDCBHHPN();
		this.KBDJCFIIHJF();
		this.rateCanvas.SetActive(false);
	}

	// Token: 0x0600ECAA RID: 60586 RVA: 0x00532FFC File Offset: 0x005311FC
	public void BBICIPNPMLL(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		this.JANJAEPPJJN = BCOEFENFCJB;
		if (this.authorText != null)
		{
			this.KKKFBKJOBDB();
		}
		Text text = this.tipText;
		object[] array = new object[7];
		array[0] = LocalizationService.Instance.GetTextByKey("mapselector.lastSearch").ToUpper();
		array[0] = "_TimeX";
		array[0] = this.JANJAEPPJJN.id;
		array[6] = "00";
		array[5] = this.JANJAEPPJJN.MKLBKIJOGBG();
		text.text = string.Concat(array);
		this.ratingText.text = ((this.JANJAEPPJJN.KBIEDPCEHGG() < 0) ? string.Empty : "Intensity") + this.JANJAEPPJJN.LKHKLECGPFD();
		this.ADGADPAIAIC = this.JANJAEPPJJN.GetUserVote();
		this.PDMNHDIEEJD();
	}

	// Token: 0x0600ECAB RID: 60587 RVA: 0x0002523B File Offset: 0x0002343B
	public void LLDBHHLCEMC()
	{
	}

	// Token: 0x0600ECAC RID: 60588 RVA: 0x005330DC File Offset: 0x005312DC
	public void LHCOOHGJEEI()
	{
		int adgadpaiaic = this.ADGADPAIAIC;
		if (adgadpaiaic == 0)
		{
			this.rateButton.SetActive(true);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
		else if (adgadpaiaic == 1)
		{
			this.rateButton.SetActive(true);
			this.ratedDownButton.SetActive(true);
			this.ratedUpButton.SetActive(false);
		}
		else if (adgadpaiaic == -1)
		{
			this.rateButton.SetActive(false);
			this.ratedUpButton.SetActive(true);
			this.ratedDownButton.SetActive(false);
		}
	}

	// Token: 0x04001A82 RID: 6786
	public bool isBGWhite = true;

	// Token: 0x04001A83 RID: 6787
	public Text tipText;

	// Token: 0x04001A84 RID: 6788
	public Text authorText;

	// Token: 0x04001A85 RID: 6789
	public Text ratingText;

	// Token: 0x04001A86 RID: 6790
	public GameObject rateCanvas;

	// Token: 0x04001A87 RID: 6791
	public GameObject rateButton;

	// Token: 0x04001A88 RID: 6792
	public GameObject ratedUpButton;

	// Token: 0x04001A89 RID: 6793
	public GameObject ratedDownButton;

	// Token: 0x04001A8A RID: 6794
	private RanksSystem.PlayerTip JANJAEPPJJN;

	// Token: 0x04001A8B RID: 6795
	private int ADGADPAIAIC;
}
