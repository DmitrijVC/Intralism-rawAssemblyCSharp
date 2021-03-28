using System;
using System.Collections;
using System.Runtime.CompilerServices;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000452 RID: 1106
public class MessageBoxPanel : Singleton<MessageBoxPanel>
{
	// Token: 0x0600FC2A RID: 64554 RVA: 0x005670B8 File Offset: 0x005652B8
	public IEnumerator KNOPGACCMCN(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC2B RID: 64555 RVA: 0x005670F8 File Offset: 0x005652F8
	public IEnumerator DGHILKGOFHI(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC2C RID: 64556 RVA: 0x00567138 File Offset: 0x00565338
	public IEnumerator DisplayDialog(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC2D RID: 64557 RVA: 0x00567178 File Offset: 0x00565378
	public void MDDBLLLPJBH(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(false);
		this.messageBox.SetActive(true);
	}

	// Token: 0x0600FC2E RID: 64558 RVA: 0x005671A8 File Offset: 0x005653A8
	public IEnumerator PGBDHNNAAMM(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.infoText.text = DAGALCAILLN;
		this.button0.onClick.RemoveAllListeners();
		this.button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		this.button0.gameObject.SetActive(true);
		this.progressSlider.gameObject.SetActive(false);
		this.input.text = EAFAMAMDNEG;
		this.input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		if (this.dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
		}
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC2F RID: 64559 RVA: 0x005671E0 File Offset: 0x005653E0
	public void JDAGGOPDHNM(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC30 RID: 64560 RVA: 0x00567210 File Offset: 0x00565410
	public void KJPEAAAGNGK(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = true;
		this.dialogButtonsCanvas.SetActive(true);
		this.input.gameObject.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.HHKKOEFBIDN));
		this.bg.SetActive(false);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC31 RID: 64561 RVA: 0x00567354 File Offset: 0x00565554
	public IEnumerator IOLBDBFIOAM(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC32 RID: 64562 RVA: 0x00567394 File Offset: 0x00565594
	[CompilerGenerated]
	private void ADAFOPAEAPH()
	{
		this.Close(-1, null);
	}

	// Token: 0x0600FC33 RID: 64563 RVA: 0x0056739E File Offset: 0x0056559E
	private void HHKKOEFBIDN()
	{
		this.CKBPMBBKINC(-1, null);
	}

	// Token: 0x0600FC34 RID: 64564 RVA: 0x005671E0 File Offset: 0x005653E0
	public void EOKFGEFEDBB(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC35 RID: 64565 RVA: 0x005673A8 File Offset: 0x005655A8
	public void JCHNDBKFGFP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = true;
		this.dialogButtonsCanvas.SetActive(true);
		this.input.gameObject.SetActive(false);
		this.infoText.text = LocalizationService.Instance.HOPMEAJKPHL(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.CHIBDIECIEO));
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC36 RID: 64566 RVA: 0x005674EA File Offset: 0x005656EA
	public void CLLBEDAJKBE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = false;
		this.bg.SetActive(false);
		this.messageBox.SetActive(true);
	}

	// Token: 0x0600FC37 RID: 64567 RVA: 0x00567519 File Offset: 0x00565719
	private void IEAONCFDFNC()
	{
		this.JDAGGOPDHNM(-1, null);
	}

	// Token: 0x0600FC38 RID: 64568 RVA: 0x00567524 File Offset: 0x00565724
	public void ALHLMBCOILP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = true;
		this.dialogButtonsCanvas.SetActive(false);
		this.input.gameObject.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.HHKKOEFBIDN));
		this.bg.SetActive(false);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC39 RID: 64569 RVA: 0x00567668 File Offset: 0x00565868
	public IEnumerator DisplayInputDialog(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.infoText.text = DAGALCAILLN;
		this.button0.onClick.RemoveAllListeners();
		this.button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		this.button0.gameObject.SetActive(true);
		this.progressSlider.gameObject.SetActive(false);
		this.input.text = EAFAMAMDNEG;
		this.input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		if (this.dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
		}
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC3A RID: 64570 RVA: 0x005676A0 File Offset: 0x005658A0
	private void LMFLEEPBKDB()
	{
		this.LLJMNFMEIPE(-1, null);
	}

	// Token: 0x0600FC3B RID: 64571 RVA: 0x005676AC File Offset: 0x005658AC
	public IEnumerator MLDHDCNBHGL(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC3C RID: 64572 RVA: 0x005676EC File Offset: 0x005658EC
	public void ANCIONGLJAC(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = true;
		this.dialogButtonsCanvas.SetActive(true);
		this.input.gameObject.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.IEAONCFDFNC));
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC3D RID: 64573 RVA: 0x00567830 File Offset: 0x00565A30
	public void LKFALPEABHP(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = true;
		this.dialogButtonsCanvas.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.GICAFOMBKPL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC3F RID: 64575 RVA: 0x00567988 File Offset: 0x00565B88
	public IEnumerator FOKENJJAIDE(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.infoText.text = DAGALCAILLN;
		this.button0.onClick.RemoveAllListeners();
		this.button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		this.button0.gameObject.SetActive(true);
		this.progressSlider.gameObject.SetActive(false);
		this.input.text = EAFAMAMDNEG;
		this.input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		if (this.dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
		}
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC40 RID: 64576 RVA: 0x005679C0 File Offset: 0x00565BC0
	public void ILNLMMEOALM(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(true);
		this.input.gameObject.SetActive(true);
		this.infoText.text = LocalizationService.Instance.HOPMEAJKPHL(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.IEAONCFDFNC));
		this.bg.SetActive(false);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC41 RID: 64577 RVA: 0x00567B04 File Offset: 0x00565D04
	public IEnumerator BJKANLKLPBL(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.infoText.text = DAGALCAILLN;
		this.button0.onClick.RemoveAllListeners();
		this.button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		this.button0.gameObject.SetActive(true);
		this.progressSlider.gameObject.SetActive(false);
		this.input.text = EAFAMAMDNEG;
		this.input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		if (this.dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
		}
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC42 RID: 64578 RVA: 0x00567B3C File Offset: 0x00565D3C
	public IEnumerator GINFCJIPPHE(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC43 RID: 64579 RVA: 0x00567B7C File Offset: 0x00565D7C
	public void CHBFDGFOLLL(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.input.gameObject.SetActive(true);
		this.infoText.text = LocalizationService.Instance.HOPMEAJKPHL(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.IEAONCFDFNC));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC44 RID: 64580 RVA: 0x005674EA File Offset: 0x005656EA
	public void CEPIBOBEIHE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = false;
		this.bg.SetActive(false);
		this.messageBox.SetActive(true);
	}

	// Token: 0x0600FC45 RID: 64581 RVA: 0x005671E0 File Offset: 0x005653E0
	public void LNBENKOBLCG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC46 RID: 64582 RVA: 0x00567CBE File Offset: 0x00565EBE
	public void CKBPMBBKINC(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(true);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC47 RID: 64583 RVA: 0x00567CF0 File Offset: 0x00565EF0
	public IEnumerator OOFFNLACIMP(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC48 RID: 64584 RVA: 0x00567D30 File Offset: 0x00565F30
	private void CHIBDIECIEO()
	{
		this.EOKFGEFEDBB(-1, null);
	}

	// Token: 0x0600FC49 RID: 64585 RVA: 0x00567D3A File Offset: 0x00565F3A
	public void LLJMNFMEIPE(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = false;
		this.bg.SetActive(true);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC4A RID: 64586 RVA: 0x005671E0 File Offset: 0x005653E0
	public void Close(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC4B RID: 64587 RVA: 0x00567D3A File Offset: 0x00565F3A
	public void IPMMEMNBGNL(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = false;
		this.bg.SetActive(true);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC4C RID: 64588 RVA: 0x00567D69 File Offset: 0x00565F69
	public void NNNCEGFJLOB(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = false;
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC4D RID: 64589 RVA: 0x00567D98 File Offset: 0x00565F98
	public IEnumerator IMGGNCJBANC(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC4E RID: 64590 RVA: 0x00567DD8 File Offset: 0x00565FD8
	public IEnumerator MDBCFODECPM(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC4F RID: 64591 RVA: 0x00567E18 File Offset: 0x00566018
	public IEnumerator KPJFLMDCPMK(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC50 RID: 64592 RVA: 0x00567E58 File Offset: 0x00566058
	public void KOKMKCJONBG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
	}

	// Token: 0x0600FC51 RID: 64593 RVA: 0x00567E88 File Offset: 0x00566088
	public IEnumerator JKIKIMKNNKK(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.infoText.text = DAGALCAILLN;
		this.button0.onClick.RemoveAllListeners();
		this.button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		this.button0.gameObject.SetActive(true);
		this.progressSlider.gameObject.SetActive(false);
		this.input.text = EAFAMAMDNEG;
		this.input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		if (this.dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
		}
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC52 RID: 64594 RVA: 0x00567EC0 File Offset: 0x005660C0
	public void DisplayMessage(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.ADAFOPAEAPH));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC53 RID: 64595 RVA: 0x005671E0 File Offset: 0x005653E0
	public void GIKJIFGFMFP(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC54 RID: 64596 RVA: 0x00567D3A File Offset: 0x00565F3A
	public void PALFHOFEKEG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = false;
		this.bg.SetActive(true);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC55 RID: 64597 RVA: 0x00568004 File Offset: 0x00566204
	public IEnumerator ABDEPPPGGBM(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC56 RID: 64598 RVA: 0x00568044 File Offset: 0x00566244
	public IEnumerator FNLHHMEJCON(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC57 RID: 64599 RVA: 0x00568084 File Offset: 0x00566284
	public void AGMKJJLMOHG(string DAGALCAILLN, string MLDACKJMKMN, UnityAction NBIMAPNDKKA, bool LEOOCHBHIKA = true, bool PAJNNEENEMK = false, float IADPPJHIMBG = 0f)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = true;
		this.dialogButtonsCanvas.SetActive(false);
		this.input.gameObject.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.GetComponentInChildren<Text>().text = LocalizationService.Instance.HOPMEAJKPHL(MLDACKJMKMN).ToUpper();
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(LEOOCHBHIKA);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.progressSlider.gameObject.SetActive(PAJNNEENEMK);
		if (PAJNNEENEMK)
		{
			this.progressSlider.value = IADPPJHIMBG;
		}
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(this.GICAFOMBKPL));
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
		EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
	}

	// Token: 0x0600FC58 RID: 64600 RVA: 0x005674EA File Offset: 0x005656EA
	public void FCNDDFJNFPH(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = false;
		this.bg.SetActive(false);
		this.messageBox.SetActive(true);
	}

	// Token: 0x0600FC59 RID: 64601 RVA: 0x005681C8 File Offset: 0x005663C8
	public IEnumerator MEFKBOBCJKG(string DAGALCAILLN, string KOKBPECCNDG, UnityAction JFPBAJLMAPC = null, string NHCJNAEDDJL = null, UnityAction CBGPGFDGKCH = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		if (string.IsNullOrEmpty(NHCJNAEDDJL))
		{
			NHCJNAEDDJL = LocalizationService.Instance.GetTextByKey("cancel").ToUpper();
		}
		this.dialogButtonsCanvas.SetActive(true);
		this.infoText.text = LocalizationService.Instance.GetLocalizatedText(DAGALCAILLN);
		this.button0.onClick.RemoveAllListeners();
		this.button0.gameObject.SetActive(false);
		this.progressSlider.gameObject.SetActive(false);
		this.input.gameObject.SetActive(false);
		this.button1.onClick.RemoveAllListeners();
		this.button2.onClick.RemoveAllListeners();
		this.button1.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(KOKBPECCNDG).ToUpper();
		this.button2.GetComponentInChildren<Text>().text = LocalizationService.Instance.GetLocalizatedText(NHCJNAEDDJL).ToUpper();
		if (JFPBAJLMAPC != null)
		{
			this.button1.onClick.AddListener(JFPBAJLMAPC);
		}
		if (CBGPGFDGKCH != null)
		{
			this.button2.onClick.AddListener(CBGPGFDGKCH);
		}
		this.button1.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.button2.onClick.AddListener(new UnityAction(base.HMMBBDJNGGL));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		EventSystem.current.SetSelectedGameObject(this.button1.transform.gameObject);
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC5A RID: 64602 RVA: 0x00568208 File Offset: 0x00566408
	public IEnumerator DBDPBPINJLC(string DAGALCAILLN, string MLDACKJMKMN, string EAFAMAMDNEG = "", UnityAction NBIMAPNDKKA = null)
	{
		this.result = -1;
		this.textResult = null;
		this.finished = false;
		this.dialogButtonsCanvas.SetActive(false);
		this.infoText.text = DAGALCAILLN;
		this.button0.onClick.RemoveAllListeners();
		this.button0.GetComponentInChildren<Text>().text = MLDACKJMKMN;
		this.button0.gameObject.SetActive(true);
		this.progressSlider.gameObject.SetActive(false);
		this.input.text = EAFAMAMDNEG;
		this.input.gameObject.SetActive(true);
		if (NBIMAPNDKKA != null)
		{
			this.button0.onClick.AddListener(NBIMAPNDKKA);
		}
		this.button0.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		this.bg.SetActive(true);
		this.messageBox.SetActive(true);
		if (this.dialogButtonsCanvas.activeSelf)
		{
			EventSystem.current.SetSelectedGameObject(this.button0.transform.gameObject);
		}
		while (!this.finished)
		{
			yield return new WaitForSeconds(0.1f);
		}
		yield break;
	}

	// Token: 0x0600FC5B RID: 64603 RVA: 0x005671E0 File Offset: 0x005653E0
	public void CNHKJNCBIAG(int NBGPBKCPFDN = -1, string EAFAMAMDNEG = null)
	{
		this.result = NBGPBKCPFDN;
		this.textResult = EAFAMAMDNEG;
		this.finished = true;
		this.bg.SetActive(false);
		this.messageBox.SetActive(false);
	}

	// Token: 0x0600FC5C RID: 64604 RVA: 0x00567519 File Offset: 0x00565719
	private void GICAFOMBKPL()
	{
		this.JDAGGOPDHNM(-1, null);
	}

	// Token: 0x04001BE9 RID: 7145
	public GameObject bg;

	// Token: 0x04001BEA RID: 7146
	public GameObject messageBox;

	// Token: 0x04001BEB RID: 7147
	public Text infoText;

	// Token: 0x04001BEC RID: 7148
	public Slider progressSlider;

	// Token: 0x04001BED RID: 7149
	public Button button0;

	// Token: 0x04001BEE RID: 7150
	public GameObject dialogButtonsCanvas;

	// Token: 0x04001BEF RID: 7151
	public Button button1;

	// Token: 0x04001BF0 RID: 7152
	public Button button2;

	// Token: 0x04001BF1 RID: 7153
	public InputField input;

	// Token: 0x04001BF2 RID: 7154
	public bool finished = true;

	// Token: 0x04001BF3 RID: 7155
	public int result = -1;

	// Token: 0x04001BF4 RID: 7156
	public string textResult;
}
