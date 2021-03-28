using System;
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200038C RID: 908
public class ChallengesMessage : Singleton<ChallengesMessage>
{
	// Token: 0x0600CA3E RID: 51774 RVA: 0x004926B4 File Offset: 0x004908B4
	public IEnumerator MHIIDEFFOPG(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			string text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA3F RID: 51775 RVA: 0x004926E4 File Offset: 0x004908E4
	public IEnumerator DAFGMNEEOJN(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA40 RID: 51776 RVA: 0x00492714 File Offset: 0x00490914
	public IEnumerator AGJLCNDGODP(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA41 RID: 51777 RVA: 0x00492744 File Offset: 0x00490944
	public IEnumerator EOAALFEALFB(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA42 RID: 51778 RVA: 0x00492774 File Offset: 0x00490974
	public IEnumerator CHAPAEBAGBG(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA43 RID: 51779 RVA: 0x004927A4 File Offset: 0x004909A4
	public IEnumerator JELKMEDPKCL(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA44 RID: 51780 RVA: 0x004927D4 File Offset: 0x004909D4
	public IEnumerator PGEHEJMPDCD(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA45 RID: 51781 RVA: 0x00492804 File Offset: 0x00490A04
	public IEnumerator DNHHKBDDBGD(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA46 RID: 51782 RVA: 0x00492834 File Offset: 0x00490A34
	public IEnumerator HOCOLBHKCHL(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA47 RID: 51783 RVA: 0x00492864 File Offset: 0x00490A64
	public IEnumerator JOCACBLCCMM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA49 RID: 51785 RVA: 0x004928A8 File Offset: 0x00490AA8
	public IEnumerator AHPMEFOCDIO(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA4A RID: 51786 RVA: 0x004928D8 File Offset: 0x00490AD8
	public IEnumerator FPCHLDCNODE(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA4B RID: 51787 RVA: 0x00492908 File Offset: 0x00490B08
	public IEnumerator CLBHJILJJJB(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA4C RID: 51788 RVA: 0x00492938 File Offset: 0x00490B38
	public IEnumerator GDAILIHICED(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA4D RID: 51789 RVA: 0x00492968 File Offset: 0x00490B68
	public IEnumerator JPGPLFFIGDA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA4E RID: 51790 RVA: 0x00492998 File Offset: 0x00490B98
	public IEnumerator DPPEKLIFMIJ(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA4F RID: 51791 RVA: 0x004929C8 File Offset: 0x00490BC8
	public IEnumerator BKLEAFCFGIF(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA50 RID: 51792 RVA: 0x004929F8 File Offset: 0x00490BF8
	public IEnumerator DPCGEHNCEAA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA51 RID: 51793 RVA: 0x00492A28 File Offset: 0x00490C28
	public IEnumerator DHPELKMAAFM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA52 RID: 51794 RVA: 0x00492A58 File Offset: 0x00490C58
	public IEnumerator FJBFLGEKJEH(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA53 RID: 51795 RVA: 0x00492A88 File Offset: 0x00490C88
	public IEnumerator JNEKADPOGON(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA54 RID: 51796 RVA: 0x00492AB8 File Offset: 0x00490CB8
	public IEnumerator LPMANIOHNCB(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA55 RID: 51797 RVA: 0x00492AE8 File Offset: 0x00490CE8
	public IEnumerator BBGKHAOOLEA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA56 RID: 51798 RVA: 0x00492B18 File Offset: 0x00490D18
	public IEnumerator OEKGNHOHHKM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA57 RID: 51799 RVA: 0x00492B48 File Offset: 0x00490D48
	public IEnumerator MJGCLANHBNE(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA58 RID: 51800 RVA: 0x00492B78 File Offset: 0x00490D78
	public IEnumerator ShowMessage(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA59 RID: 51801 RVA: 0x00492BA8 File Offset: 0x00490DA8
	public IEnumerator IJFDCPFAPBP(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA5A RID: 51802 RVA: 0x00492BD8 File Offset: 0x00490DD8
	public IEnumerator MFOIDBAHKOJ(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA5B RID: 51803 RVA: 0x00492C08 File Offset: 0x00490E08
	public IEnumerator KOJGICNJMHK(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA5C RID: 51804 RVA: 0x00492C38 File Offset: 0x00490E38
	public IEnumerator DEHBMACMNIG(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA5D RID: 51805 RVA: 0x00492C68 File Offset: 0x00490E68
	public IEnumerator FPKCOIJLBLN(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA5E RID: 51806 RVA: 0x00492C98 File Offset: 0x00490E98
	public IEnumerator LMCOPICBHCI(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA5F RID: 51807 RVA: 0x00492CC8 File Offset: 0x00490EC8
	public IEnumerator PJMJPHECLLL(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA60 RID: 51808 RVA: 0x00492CF8 File Offset: 0x00490EF8
	public IEnumerator CGJLEMDDPFK(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA61 RID: 51809 RVA: 0x00492D28 File Offset: 0x00490F28
	public IEnumerator GBEONFANEGF(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA62 RID: 51810 RVA: 0x00492D58 File Offset: 0x00490F58
	public IEnumerator IKIFPMPCMHM(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA63 RID: 51811 RVA: 0x00492D88 File Offset: 0x00490F88
	public IEnumerator HJKACAHALKD(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA64 RID: 51812 RVA: 0x00492DB8 File Offset: 0x00490FB8
	public IEnumerator OFIIHLGMHLA(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600CA65 RID: 51813 RVA: 0x00492DE8 File Offset: 0x00490FE8
	public IEnumerator LLDNOFEBMNO(Challenge BFLLKFPPAAB, string KMPPMPMABKI, string COGJAGOFOKK)
	{
		if (!BFLLKFPPAAB.icon.StartsWith("http"))
		{
			text = "challenges/" + BFLLKFPPAAB.icon;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSprite("skin." + text, text, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + text);
		}
		else
		{
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSpriteFromURL("skin." + BFLLKFPPAAB.id + ".icon", BFLLKFPPAAB.icon, false));
			this.icon.sprite = (Sprite)ResourcesManager.GetLoadedResource("skin." + BFLLKFPPAAB.id + ".icon");
		}
		this.progress.value = BFLLKFPPAAB.GetProgress();
		this.header.text = LocalizationService.Instance.GetLocalizatedText(KMPPMPMABKI);
		this.message.text = COGJAGOFOKK;
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield return new WaitForSeconds(this.duration);
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x04001779 RID: 6009
	public GameObject canvas;

	// Token: 0x0400177A RID: 6010
	public Image icon;

	// Token: 0x0400177B RID: 6011
	public Slider progress;

	// Token: 0x0400177C RID: 6012
	public Text header;

	// Token: 0x0400177D RID: 6013
	public Text message;

	// Token: 0x0400177E RID: 6014
	public float duration = 2f;
}
