using System;
using System.Collections;
using System.Globalization;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003CE RID: 974
public class OpenSteamProfileButton : MonoBehaviour
{
	// Token: 0x0600DC57 RID: 56407 RVA: 0x004DF582 File Offset: 0x004DD782
	public void OpenSteamProfile()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?player=") + this.playerId, true);
	}

	// Token: 0x0600DC58 RID: 56408 RVA: 0x004DF5B0 File Offset: 0x004DD7B0
	private IEnumerator HMACEEHPEHI(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameColored(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC59 RID: 56409 RVA: 0x004DF5D4 File Offset: 0x004DD7D4
	private IEnumerator DDOBIMLAJOM(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameColored(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC5A RID: 56410 RVA: 0x004DF5F8 File Offset: 0x004DD7F8
	private IEnumerator NGHPEKIBEKH(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(this.playerId) == null) ? -1 : RanksSystem.GetLoadedRank(this.playerId).place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC5B RID: 56411 RVA: 0x004DF61C File Offset: 0x004DD81C
	private IEnumerator DKEGICAPCII(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameColored(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC5C RID: 56412 RVA: 0x004DF640 File Offset: 0x004DD840
	private IEnumerator FBBIDIIOLLD(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(this.playerId) == null) ? -1 : RanksSystem.GetLoadedRank(this.playerId).place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC5D RID: 56413 RVA: 0x004DF664 File Offset: 0x004DD864
	private IEnumerator MGCMPLFCAGN(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(this.playerId) == null) ? -1 : RanksSystem.GetLoadedRank(this.playerId).place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC5E RID: 56414 RVA: 0x004DF688 File Offset: 0x004DD888
	private IEnumerator IBMJIJBHGMA(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(this.playerId) == null) ? -1 : RanksSystem.GetLoadedRank(this.playerId).place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC5F RID: 56415 RVA: 0x004DF6AA File Offset: 0x004DD8AA
	public void InitForGlobalRanks(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		this.playerId = JMMILEFMACB;
		base.StartCoroutine(this.DDOBIMLAJOM(NMHGNJMJFGO));
	}

	// Token: 0x0600DC60 RID: 56416 RVA: 0x004DF6C1 File Offset: 0x004DD8C1
	public void BKJGPCGMAPK(RanksSystem.Score NMHGNJMJFGO)
	{
		this.playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.EFEMONFHGDB());
		base.StartCoroutine(this.FBBIDIIOLLD(NMHGNJMJFGO));
	}

	// Token: 0x0600DC61 RID: 56417 RVA: 0x004DF6E7 File Offset: 0x004DD8E7
	public void ABABKDACGDI(RanksSystem.Score NMHGNJMJFGO)
	{
		this.playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.LGJPIKFGCII());
		base.StartCoroutine(this.NGHPEKIBEKH(NMHGNJMJFGO));
	}

	// Token: 0x0600DC62 RID: 56418 RVA: 0x0002523B File Offset: 0x0002343B
	private void KLILJHJNICK()
	{
	}

	// Token: 0x0600DC63 RID: 56419 RVA: 0x004DF70D File Offset: 0x004DD90D
	public void InitForMap(RanksSystem.Score NMHGNJMJFGO)
	{
		this.playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.steamID);
		base.StartCoroutine(this.IBMJIJBHGMA(NMHGNJMJFGO));
	}

	// Token: 0x0600DC64 RID: 56420 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x0600DC65 RID: 56421 RVA: 0x004DF733 File Offset: 0x004DD933
	public void MDNJNCCOGFK(RanksSystem.Score NMHGNJMJFGO)
	{
		this.playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.LGJPIKFGCII());
		base.StartCoroutine(this.FBBIDIIOLLD(NMHGNJMJFGO));
	}

	// Token: 0x0600DC66 RID: 56422 RVA: 0x004DF759 File Offset: 0x004DD959
	public void BDHICPOHEPJ()
	{
		Singleton<GameManager>.Instance.NJOEGFFMEIC(Singleton<GameManager>.Instance.CreateServerURL(" #") + this.playerId, true);
	}

	// Token: 0x0600DC67 RID: 56423 RVA: 0x0002523B File Offset: 0x0002343B
	private void CCLNNLCOPBL()
	{
	}

	// Token: 0x0600DC69 RID: 56425 RVA: 0x004DF788 File Offset: 0x004DD988
	private IEnumerator CHMOJJBJLCJ(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(this.playerId, false));
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(this.playerId, false));
		this.username.text = ResourcesManager.GetLoadedSteamPlayernameColored(this.playerId, true);
		this.avatar.sprite = ResourcesManager.GetLoadedAvatar(this.playerId);
		this.avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		this.position.text = string.Empty + NMHGNJMJFGO.place;
		mjhmifpojea = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		this.date.text = string.Empty + Helpers.GetRelativeDateTime(mjhmifpojea);
		numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		this.score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		this.accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		this.misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
		yield break;
	}

	// Token: 0x0600DC6A RID: 56426 RVA: 0x004DF7AA File Offset: 0x004DD9AA
	public void IOJJDKKHOHH(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		this.playerId = JMMILEFMACB;
		base.StartCoroutine(this.DKEGICAPCII(NMHGNJMJFGO));
	}

	// Token: 0x0600DC6B RID: 56427 RVA: 0x004DF70D File Offset: 0x004DD90D
	public void KNIIGFIJLBN(RanksSystem.Score NMHGNJMJFGO)
	{
		this.playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.steamID);
		base.StartCoroutine(this.IBMJIJBHGMA(NMHGNJMJFGO));
	}

	// Token: 0x040018CA RID: 6346
	[HideInInspector]
	public CSteamID playerId;

	// Token: 0x040018CB RID: 6347
	public Image avatar;

	// Token: 0x040018CC RID: 6348
	public Image avatarBG;

	// Token: 0x040018CD RID: 6349
	public Text position;

	// Token: 0x040018CE RID: 6350
	public Text username;

	// Token: 0x040018CF RID: 6351
	public Text date;

	// Token: 0x040018D0 RID: 6352
	public Text accurancy;

	// Token: 0x040018D1 RID: 6353
	public Text misses;

	// Token: 0x040018D2 RID: 6354
	public Text score;
}
