using System;
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003C7 RID: 967
public class LevelsSelectorListElement : MonoBehaviour
{
	// Token: 0x0600DAB1 RID: 55985 RVA: 0x0002523B File Offset: 0x0002343B
	private void NNCCPEBIAKH()
	{
	}

	// Token: 0x0600DAB2 RID: 55986 RVA: 0x004DA4FE File Offset: 0x004D86FE
	public void CPECIABOMOL()
	{
		base.StartCoroutine(this.CPPOOLHICFL());
	}

	// Token: 0x0600DAB3 RID: 55987 RVA: 0x004DA50D File Offset: 0x004D870D
	public void BADPFPFPGKP()
	{
		base.StartCoroutine(this.PIAMGOBOLMP());
	}

	// Token: 0x0600DAB4 RID: 55988 RVA: 0x0002523B File Offset: 0x0002343B
	private void DLBODOFAJGM()
	{
	}

	// Token: 0x0600DAB5 RID: 55989 RVA: 0x004DA51C File Offset: 0x004D871C
	public void POAKODFNAIM()
	{
		base.StartCoroutine(this.MMHPCINCIJP());
	}

	// Token: 0x0600DAB6 RID: 55990 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMCPMOGKDEH()
	{
	}

	// Token: 0x0600DAB7 RID: 55991 RVA: 0x004DA52B File Offset: 0x004D872B
	public void HHAECEMFKND()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).BDOIODEMFHC(this.levelid);
	}

	// Token: 0x0600DAB8 RID: 55992 RVA: 0x004DA542 File Offset: 0x004D8742
	public void AKEIPNLIHNL()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).EBAGFEDOKHD(this.levelid);
	}

	// Token: 0x0600DAB9 RID: 55993 RVA: 0x004DA51C File Offset: 0x004D871C
	public void MIHEEHLLAND()
	{
		base.StartCoroutine(this.MMHPCINCIJP());
	}

	// Token: 0x0600DABA RID: 55994 RVA: 0x0002523B File Offset: 0x0002343B
	private void NPLCENPNJBM()
	{
	}

	// Token: 0x0600DABB RID: 55995 RVA: 0x004DA55C File Offset: 0x004D875C
	private IEnumerator BLMFNJPDDIE()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(this.levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
		yield break;
	}

	// Token: 0x0600DABC RID: 55996 RVA: 0x004DA577 File Offset: 0x004D8777
	public void OnClick()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).OpenMap(this.levelid);
	}

	// Token: 0x0600DABD RID: 55997 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x0600DABE RID: 55998 RVA: 0x004DA50D File Offset: 0x004D870D
	public void EEBOIKAPOOO()
	{
		base.StartCoroutine(this.PIAMGOBOLMP());
	}

	// Token: 0x0600DABF RID: 55999 RVA: 0x004DA52B File Offset: 0x004D872B
	public void GGCLKOJPPDD()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).BDOIODEMFHC(this.levelid);
	}

	// Token: 0x0600DAC0 RID: 56000 RVA: 0x0002523B File Offset: 0x0002343B
	private void FIKFJDFELIP()
	{
	}

	// Token: 0x0600DAC1 RID: 56001 RVA: 0x004DA542 File Offset: 0x004D8742
	public void DBDCIAIJOKG()
	{
		((LevelEditorScene)Singleton<Scene>.Instance).EBAGFEDOKHD(this.levelid);
	}

	// Token: 0x0600DAC2 RID: 56002 RVA: 0x0002523B File Offset: 0x0002343B
	private void KLILJHJNICK()
	{
	}

	// Token: 0x0600DAC3 RID: 56003 RVA: 0x004DA590 File Offset: 0x004D8790
	private void BGFJOEPFOPM()
	{
		base.transform.Find("play").gameObject.GetComponent<Button>().interactable = (!((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid) || true);
		base.transform.Find("GameModeText").gameObject.GetComponent<Button>().interactable = (((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid);
	}

	// Token: 0x0600DAC5 RID: 56005 RVA: 0x004DA51C File Offset: 0x004D871C
	public void JCLEGIJAGMG()
	{
		base.StartCoroutine(this.MMHPCINCIJP());
	}

	// Token: 0x0600DAC6 RID: 56006 RVA: 0x0002523B File Offset: 0x0002343B
	private void DKOPKPBLDHH()
	{
	}

	// Token: 0x0600DAC7 RID: 56007 RVA: 0x004DA65C File Offset: 0x004D885C
	private void AEIJFLJEABG()
	{
		base.transform.Find("_MainTex2").gameObject.GetComponent<Button>().interactable = (!((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || (((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid && false));
		base.transform.Find("_Offsets").gameObject.GetComponent<Button>().interactable = (!((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid));
	}

	// Token: 0x0600DAC8 RID: 56008 RVA: 0x004DA728 File Offset: 0x004D8928
	private void Update()
	{
		base.transform.Find("OpenButton").gameObject.GetComponent<Button>().interactable = (!((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid));
		base.transform.Find("DeleteButton").gameObject.GetComponent<Button>().interactable = (!((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || !(((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid));
	}

	// Token: 0x0600DAC9 RID: 56009 RVA: 0x0002523B File Offset: 0x0002343B
	private void BEBNOKFLJPH()
	{
	}

	// Token: 0x0600DACA RID: 56010 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPEGAEGDJAM()
	{
	}

	// Token: 0x0600DACB RID: 56011 RVA: 0x004DA7F4 File Offset: 0x004D89F4
	private IEnumerator POMLILLIBOI()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(this.levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
		yield break;
	}

	// Token: 0x0600DACC RID: 56012 RVA: 0x004DA80F File Offset: 0x004D8A0F
	public void DFFDCFIFCAL()
	{
		base.StartCoroutine(this.POMLILLIBOI());
	}

	// Token: 0x0600DACD RID: 56013 RVA: 0x004DA820 File Offset: 0x004D8A20
	private void JHPOIOELNCG()
	{
		base.transform.Find("_ScreenResolution").gameObject.GetComponent<Button>().interactable = (((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && ((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid && false);
		base.transform.Find("CameraFilterPack/Colors_HUE_Rotate").gameObject.GetComponent<Button>().interactable = (((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded && (!(((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid) || true));
	}

	// Token: 0x0600DACE RID: 56014 RVA: 0x004DA8EC File Offset: 0x004D8AEC
	private IEnumerator CPPOOLHICFL()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(this.levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
		yield break;
	}

	// Token: 0x0600DACF RID: 56015 RVA: 0x004DA908 File Offset: 0x004D8B08
	private IEnumerator PIAMGOBOLMP()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(this.levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
		yield break;
	}

	// Token: 0x0600DAD0 RID: 56016 RVA: 0x0002523B File Offset: 0x0002343B
	private void DAHFFNNIGML()
	{
	}

	// Token: 0x0600DAD1 RID: 56017 RVA: 0x004DA924 File Offset: 0x004D8B24
	private void AGMJDGHLBMN()
	{
		base.transform.Find("caret").gameObject.GetComponent<Button>().interactable = (!((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid);
		base.transform.Find("PLEASE WAIT").gameObject.GetComponent<Button>().interactable = (!((LevelEditorScene)Singleton<Scene>.Instance).isLevelLoaded || ((LevelEditorScene)Singleton<Scene>.Instance).mapID == this.levelid);
	}

	// Token: 0x0600DAD2 RID: 56018 RVA: 0x004DA80F File Offset: 0x004D8A0F
	public void OnDeleteClick()
	{
		base.StartCoroutine(this.POMLILLIBOI());
	}

	// Token: 0x0600DAD3 RID: 56019 RVA: 0x004DA9F0 File Offset: 0x004D8BF0
	private IEnumerator MMHPCINCIJP()
	{
		yield return base.StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog(LocalizationService.Instance.GetTextByKey("deletemap"), LocalizationService.Instance.GetTextByKey("yes").ToUpper(), null, null, null));
		if (Singleton<MessageBoxPanel>.Instance.result == 1)
		{
			Singleton<MapsSystem>.Instance.DeleteLevel(this.levelid);
			((LevelEditorScene)Singleton<Scene>.Instance).OnLoadLevelButton();
		}
		yield break;
	}

	// Token: 0x0600DAD4 RID: 56020 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLIAEEMGBHN()
	{
	}

	// Token: 0x040018B4 RID: 6324
	public string levelid;
}
