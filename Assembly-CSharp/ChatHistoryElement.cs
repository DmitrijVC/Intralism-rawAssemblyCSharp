using System;
using System.Collections;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004B8 RID: 1208
public class ChatHistoryElement : MonoBehaviour
{
	// Token: 0x06011540 RID: 70976 RVA: 0x005F8880 File Offset: 0x005F6A80
	private IEnumerator LPLEAFOLDHP(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		int jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011541 RID: 70977 RVA: 0x005F88A4 File Offset: 0x005F6AA4
	private IEnumerator PGHGGKFDCAA(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011543 RID: 70979 RVA: 0x005F88C8 File Offset: 0x005F6AC8
	public void PFMJPIJONIP(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.HJFDEEMKFDJ(GDOHPDHLPBC));
	}

	// Token: 0x06011544 RID: 70980 RVA: 0x005F88F1 File Offset: 0x005F6AF1
	public void EOPEMLDJAAO(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().OABFKACDOFO();
	}

	// Token: 0x06011545 RID: 70981 RVA: 0x005F890C File Offset: 0x005F6B0C
	public void EFEONCCCKNP(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.LNEJMKFDKJH(GDOHPDHLPBC));
	}

	// Token: 0x06011546 RID: 70982 RVA: 0x005F8938 File Offset: 0x005F6B38
	private IEnumerator LNEJMKFDKJH(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011547 RID: 70983 RVA: 0x005F88F1 File Offset: 0x005F6AF1
	public void POGJLIDHDIH(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().OABFKACDOFO();
	}

	// Token: 0x06011548 RID: 70984 RVA: 0x005F895C File Offset: 0x005F6B5C
	public void CFNDDGFGKKG(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.JJHNOHLFNGO(GDOHPDHLPBC));
	}

	// Token: 0x06011549 RID: 70985 RVA: 0x005F8985 File Offset: 0x005F6B85
	public void LNMKDFDKFPF(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().DEIBEBOEPPK();
	}

	// Token: 0x0601154A RID: 70986 RVA: 0x005F899E File Offset: 0x005F6B9E
	public void CMFBCPNHGOF(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().KBGBMIHOPLF();
	}

	// Token: 0x0601154B RID: 70987 RVA: 0x005F89B8 File Offset: 0x005F6BB8
	public void KJBJBNGJDAD(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.MPNDPGDPHPF(GDOHPDHLPBC));
	}

	// Token: 0x0601154C RID: 70988 RVA: 0x005F89E1 File Offset: 0x005F6BE1
	public void FIMJABKECNG(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().NOGJCBJLPPI();
	}

	// Token: 0x0601154D RID: 70989 RVA: 0x005F89FC File Offset: 0x005F6BFC
	public void ALKBNPMCEOM(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.LPLEAFOLDHP(GDOHPDHLPBC));
	}

	// Token: 0x0601154E RID: 70990 RVA: 0x005F8A25 File Offset: 0x005F6C25
	public void EPDCHKECMBL(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().FHNHEBMLGNI();
	}

	// Token: 0x0601154F RID: 70991 RVA: 0x005F8A40 File Offset: 0x005F6C40
	private IEnumerator HJFDEEMKFDJ(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011550 RID: 70992 RVA: 0x005F8A64 File Offset: 0x005F6C64
	private IEnumerator CLHJFMGDODK(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011551 RID: 70993 RVA: 0x005F8A88 File Offset: 0x005F6C88
	private IEnumerator JCFPJFHBAEJ(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011552 RID: 70994 RVA: 0x005F8AAC File Offset: 0x005F6CAC
	public void IFGOHEOEGKH(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.DLODAEFGHIH(GDOHPDHLPBC));
	}

	// Token: 0x06011553 RID: 70995 RVA: 0x005F8AD8 File Offset: 0x005F6CD8
	public void LBICLFNOLAK(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.PGHGGKFDCAA(GDOHPDHLPBC));
	}

	// Token: 0x06011554 RID: 70996 RVA: 0x005F8B01 File Offset: 0x005F6D01
	public void Init(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().DoFix();
	}

	// Token: 0x06011555 RID: 70997 RVA: 0x005F8B1A File Offset: 0x005F6D1A
	public void FECMEIJGLJI(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().KLGENHIIIBK();
	}

	// Token: 0x06011556 RID: 70998 RVA: 0x005F8B34 File Offset: 0x005F6D34
	public void Init(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.HJFDEEMKFDJ(GDOHPDHLPBC));
	}

	// Token: 0x06011557 RID: 70999 RVA: 0x005F8B60 File Offset: 0x005F6D60
	private IEnumerator KFBPICANOJO(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011558 RID: 71000 RVA: 0x005F8B84 File Offset: 0x005F6D84
	private IEnumerator BBEKOKGPJNH(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011559 RID: 71001 RVA: 0x005F8BA8 File Offset: 0x005F6DA8
	private IEnumerator JIHLGDMPDCH(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x0601155A RID: 71002 RVA: 0x005F8BCC File Offset: 0x005F6DCC
	public void MIAIEKCLEAO(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.KFBPICANOJO(GDOHPDHLPBC));
	}

	// Token: 0x0601155B RID: 71003 RVA: 0x005F8BF8 File Offset: 0x005F6DF8
	private IEnumerator MPNDPGDPHPF(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x0601155C RID: 71004 RVA: 0x005F8C1C File Offset: 0x005F6E1C
	private IEnumerator HFMIKDDGCIC(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x0601155D RID: 71005 RVA: 0x005F8C40 File Offset: 0x005F6E40
	private IEnumerator BAKJJFJENBC(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x0601155E RID: 71006 RVA: 0x005F8C64 File Offset: 0x005F6E64
	public void MOKHHEMAJBJ(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.OJNBBBLCDMH(GDOHPDHLPBC));
	}

	// Token: 0x0601155F RID: 71007 RVA: 0x005F8C90 File Offset: 0x005F6E90
	private IEnumerator OJNBBBLCDMH(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011560 RID: 71008 RVA: 0x005F8CB4 File Offset: 0x005F6EB4
	public void HBKEHHCMMBN(CSteamID GDOHPDHLPBC, string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.StartCoroutine(this.JJHNOHLFNGO(GDOHPDHLPBC));
	}

	// Token: 0x06011561 RID: 71009 RVA: 0x005F8CE0 File Offset: 0x005F6EE0
	private IEnumerator DLODAEFGHIH(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011562 RID: 71010 RVA: 0x005F8D02 File Offset: 0x005F6F02
	public void GDJMBJEAPHM(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().LAEIHIHMKNG();
	}

	// Token: 0x06011563 RID: 71011 RVA: 0x005F8D1C File Offset: 0x005F6F1C
	private IEnumerator JJHNOHLFNGO(CSteamID JMMILEFMACB)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(JMMILEFMACB, false));
		this.nicknameText.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(JMMILEFMACB, true);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(JMMILEFMACB, false));
		if (ResourcesManager.GetLoadedAvatar(JMMILEFMACB))
		{
			this.icon.sprite = ResourcesManager.GetLoadedAvatar(JMMILEFMACB);
		}
		loadedRank = RanksSystem.GetLoadedRank(JMMILEFMACB);
		jmiclaeofnp = 0;
		if (loadedRank != null)
		{
			jmiclaeofnp = RanksSystem.GetLoadedRank(JMMILEFMACB).place;
		}
		this.bg.color = RanksSystem.GetRankColor(jmiclaeofnp, false);
		yield return base.StartCoroutine(Singleton<ContributorSystem>.Instance.LoadContributor(JMMILEFMACB));
		this.contributorGO.SetActive(Singleton<ContributorSystem>.Instance.IsContributor(JMMILEFMACB));
		yield return base.StartCoroutine(base.GetComponent<ContentSizeFitterFx>().RunFix());
		yield break;
	}

	// Token: 0x06011564 RID: 71012 RVA: 0x005F8D3E File Offset: 0x005F6F3E
	public void NBHGPDAKJGF(string EAFAMAMDNEG)
	{
		this.message.text = EAFAMAMDNEG;
		base.GetComponent<ContentSizeFitterFx>().IEJKGNLANAE();
	}

	// Token: 0x04001EBD RID: 7869
	public ChatHistoryElement.ChatHistoryType messageType;

	// Token: 0x04001EBE RID: 7870
	public Text nicknameText;

	// Token: 0x04001EBF RID: 7871
	public Image bg;

	// Token: 0x04001EC0 RID: 7872
	public Image icon;

	// Token: 0x04001EC1 RID: 7873
	public GameObject contributorGO;

	// Token: 0x04001EC2 RID: 7874
	public Text message;

	// Token: 0x04001EC3 RID: 7875
	private CSteamID GDOHPDHLPBC;

	// Token: 0x020004B9 RID: 1209
	public enum ChatHistoryType
	{
		// Token: 0x04001EC5 RID: 7877
		FromPlayer,
		// Token: 0x04001EC6 RID: 7878
		Server
	}
}
