using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020004FC RID: 1276
public class MultiTabUI : MonoBehaviour
{
	// Token: 0x06012A6C RID: 76396 RVA: 0x0067BF04 File Offset: 0x0067A104
	private void EOPBGLHKCAF()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().KGPPEIOBEDJ(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A6D RID: 76397 RVA: 0x0067BF78 File Offset: 0x0067A178
	private void FHGKIOOMMOH()
	{
		this.JKGEHINBJLL(this.currentTab);
	}

	// Token: 0x06012A6E RID: 76398 RVA: 0x0067BF88 File Offset: 0x0067A188
	public void NAEGBHFEGJL(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find(".highscore");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.EOPBGLHKCAF();
		this.KGGCLKEPEJL();
	}

	// Token: 0x06012A6F RID: 76399 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06012A70 RID: 76400 RVA: 0x0067BFC0 File Offset: 0x0067A1C0
	public void EABICKMBGOF(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("#onrankchangeuptext");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.JFNBHGBKLCI();
		this.PJNCCGDMJPH();
	}

	// Token: 0x06012A71 RID: 76401 RVA: 0x0067BFF8 File Offset: 0x0067A1F8
	private void LJGDIIIOEEN()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012A72 RID: 76402 RVA: 0x0067C07C File Offset: 0x0067A27C
	private void AKIMHIDLGLB()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(true);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(true);
		}
	}

	// Token: 0x06012A73 RID: 76403 RVA: 0x0067C100 File Offset: 0x0067A300
	private void KGGCLKEPEJL()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(true);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012A74 RID: 76404 RVA: 0x0067C184 File Offset: 0x0067A384
	private void JKMANIOFCEM()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().DEKCCEKJEKP(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A75 RID: 76405 RVA: 0x0067C1F8 File Offset: 0x0067A3F8
	private void DLOINDFHMGM()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().BHNJGNCINHD(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A76 RID: 76406 RVA: 0x0067C26C File Offset: 0x0067A46C
	public void MKCEKKCEKFP(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find(".icon");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.EOPBGLHKCAF();
		this.PJNCCGDMJPH();
	}

	// Token: 0x06012A77 RID: 76407 RVA: 0x0067C2A3 File Offset: 0x0067A4A3
	private void COIJKMKIEAK()
	{
		this.NAEGBHFEGJL(this.currentTab);
	}

	// Token: 0x06012A78 RID: 76408 RVA: 0x0067C2B4 File Offset: 0x0067A4B4
	public void NMNPLENMAPI(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.INJOFKJFDEM();
		this.HJDDLMCOENE();
	}

	// Token: 0x06012A79 RID: 76409 RVA: 0x0067C2EC File Offset: 0x0067A4EC
	public void OnTabSelect(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.CECPMNODBLA();
		this.PJNCCGDMJPH();
	}

	// Token: 0x06012A7A RID: 76410 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06012A7B RID: 76411 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06012A7C RID: 76412 RVA: 0x0067C324 File Offset: 0x0067A524
	private void HJDDLMCOENE()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(true);
		}
		if (this.panels.Count > 1)
		{
			this.panels[this.currentTab].SetActive(true);
		}
	}

	// Token: 0x06012A7D RID: 76413 RVA: 0x0067C3A8 File Offset: 0x0067A5A8
	private void ILCFPCIPENO()
	{
		this.CEJKHCODENB(this.currentTab);
	}

	// Token: 0x06012A7E RID: 76414 RVA: 0x0067C3B8 File Offset: 0x0067A5B8
	private void CCIDBLACHOD()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 1)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012A7F RID: 76415 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06012A80 RID: 76416 RVA: 0x0067C43C File Offset: 0x0067A63C
	private void ELENFKEEPLP()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 1)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012A81 RID: 76417 RVA: 0x0067C4C0 File Offset: 0x0067A6C0
	private void JFNBHGBKLCI()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().OJAJAOFMBAG(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A82 RID: 76418 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06012A83 RID: 76419 RVA: 0x0067C534 File Offset: 0x0067A734
	private void IMCKJCHKMKB()
	{
		this.MMLGJPALKFG(this.currentTab);
	}

	// Token: 0x06012A84 RID: 76420 RVA: 0x0067C544 File Offset: 0x0067A744
	private void PJNCCGDMJPH()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(true);
		}
	}

	// Token: 0x06012A86 RID: 76422 RVA: 0x0067C5C8 File Offset: 0x0067A7C8
	private void AFKHIPJGKBC()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 1)
		{
			this.panels[this.currentTab].SetActive(true);
		}
	}

	// Token: 0x06012A87 RID: 76423 RVA: 0x0067C534 File Offset: 0x0067A734
	private void NBGIMIDICKE()
	{
		this.MMLGJPALKFG(this.currentTab);
	}

	// Token: 0x06012A88 RID: 76424 RVA: 0x0067C64C File Offset: 0x0067A84C
	private void GIHHKHDEEDE()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().CBNJLHDJDDO(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A89 RID: 76425 RVA: 0x0067C6C0 File Offset: 0x0067A8C0
	private void JECMJNFGBGC()
	{
		this.CEBJCKHBCJP(this.currentTab);
	}

	// Token: 0x06012A8A RID: 76426 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06012A8B RID: 76427 RVA: 0x0067C6CE File Offset: 0x0067A8CE
	private void Start()
	{
		this.OnTabSelect(this.currentTab);
	}

	// Token: 0x06012A8C RID: 76428 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06012A8D RID: 76429 RVA: 0x0067C6DC File Offset: 0x0067A8DC
	private void BFLNPIIAMJA()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().BCBNGINEAJG(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A8E RID: 76430 RVA: 0x0067C750 File Offset: 0x0067A950
	private void HFKMIPNOIIC()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().AKLCEKDMDCC(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A8F RID: 76431 RVA: 0x0067C7C4 File Offset: 0x0067A9C4
	private void JMEOGJHCONJ()
	{
		this.MKCEKKCEKFP(this.currentTab);
	}

	// Token: 0x06012A90 RID: 76432 RVA: 0x0067C7D4 File Offset: 0x0067A9D4
	public void IAPBIAFMIOC(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_MainTex2");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.MGGAMOFLCLN();
		this.INPOALKOLAF();
	}

	// Token: 0x06012A91 RID: 76433 RVA: 0x0067C80C File Offset: 0x0067AA0C
	public void GHOPFIOCGKK(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Atmosphere_Rain");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.CECPMNODBLA();
		this.HJDDLMCOENE();
	}

	// Token: 0x06012A92 RID: 76434 RVA: 0x0067C843 File Offset: 0x0067AA43
	private void KCCIEMBMOBA()
	{
		this.EKMJJMCFEJI(this.currentTab);
	}

	// Token: 0x06012A93 RID: 76435 RVA: 0x0067C854 File Offset: 0x0067AA54
	private void GGKPJBBAHNO()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().EEJOKOAIHPM(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A94 RID: 76436 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06012A95 RID: 76437 RVA: 0x0067C534 File Offset: 0x0067A734
	private void NCNPAKFAFOE()
	{
		this.MMLGJPALKFG(this.currentTab);
	}

	// Token: 0x06012A96 RID: 76438 RVA: 0x0067C8C8 File Offset: 0x0067AAC8
	private void CECPMNODBLA()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().IsSelected = (this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A97 RID: 76439 RVA: 0x0067C93C File Offset: 0x0067AB3C
	public void CEBJCKHBCJP(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("[Left]");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.JFNBHGBKLCI();
		this.JFIGOFMCEHB();
	}

	// Token: 0x06012A98 RID: 76440 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06012A99 RID: 76441 RVA: 0x0067C974 File Offset: 0x0067AB74
	private void MOKLLKMFJPF()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012A9A RID: 76442 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06012A9B RID: 76443 RVA: 0x0067C9F8 File Offset: 0x0067ABF8
	private void LDAOAKEKCKA()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().ADMACILOBFL(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012A9C RID: 76444 RVA: 0x0067CA6C File Offset: 0x0067AC6C
	public void JKGEHINBJLL(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("GameScene");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.CECPMNODBLA();
		this.KCEIJLCPNAP();
	}

	// Token: 0x06012A9D RID: 76445 RVA: 0x0067CAA4 File Offset: 0x0067ACA4
	public void CEJKHCODENB(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_SprTex");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.KDMODFJGGPG();
		this.HJDDLMCOENE();
	}

	// Token: 0x06012A9E RID: 76446 RVA: 0x0067CADC File Offset: 0x0067ACDC
	private void KCEIJLCPNAP()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 1)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012A9F RID: 76447 RVA: 0x0067CB60 File Offset: 0x0067AD60
	private void MGGAMOFLCLN()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().MHDBGGHELEH(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012AA0 RID: 76448 RVA: 0x0067CBD4 File Offset: 0x0067ADD4
	private void EMJLLDAKBHA()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().MHDBGGHELEH(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012AA1 RID: 76449 RVA: 0x0067CC48 File Offset: 0x0067AE48
	private void CCLNNLCOPBL()
	{
		this.IAPBIAFMIOC(this.currentTab);
	}

	// Token: 0x06012AA2 RID: 76450 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06012AA3 RID: 76451 RVA: 0x0067BF78 File Offset: 0x0067A178
	private void KLILJHJNICK()
	{
		this.JKGEHINBJLL(this.currentTab);
	}

	// Token: 0x06012AA4 RID: 76452 RVA: 0x0067CC58 File Offset: 0x0067AE58
	public void LGCHOAOBPLO(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("OperationResponse ignored while disconnecting. Code: ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.BFLNPIIAMJA();
		this.JFIGOFMCEHB();
	}

	// Token: 0x06012AA5 RID: 76453 RVA: 0x0067CC90 File Offset: 0x0067AE90
	private void MKKNHEJMLHI()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 1)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012AA6 RID: 76454 RVA: 0x0067C2A3 File Offset: 0x0067A4A3
	private void NNFMIAFHMJM()
	{
		this.NAEGBHFEGJL(this.currentTab);
	}

	// Token: 0x06012AA7 RID: 76455 RVA: 0x0067CD14 File Offset: 0x0067AF14
	private void MGMAOBPPOBJ()
	{
		this.GHOPFIOCGKK(this.currentTab);
	}

	// Token: 0x06012AA8 RID: 76456 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06012AA9 RID: 76457 RVA: 0x0067CD24 File Offset: 0x0067AF24
	private void CNEOHPBCBMJ()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(true);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012AAA RID: 76458 RVA: 0x0067CDA8 File Offset: 0x0067AFA8
	public void GMNBIEGJHEO(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Gradients_Stripe");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.EMJLLDAKBHA();
		this.AFKHIPJGKBC();
	}

	// Token: 0x06012AAB RID: 76459 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06012AAC RID: 76460 RVA: 0x0067CDE0 File Offset: 0x0067AFE0
	private void IGPCNHOHNCK()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(true);
		}
		if (this.panels.Count > 1)
		{
			this.panels[this.currentTab].SetActive(false);
		}
	}

	// Token: 0x06012AAD RID: 76461 RVA: 0x0067CE64 File Offset: 0x0067B064
	private void INJOFKJFDEM()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().BHNJGNCINHD(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012AAE RID: 76462 RVA: 0x0067CED8 File Offset: 0x0067B0D8
	public void MMLGJPALKFG(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_SpotSize");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.JFNBHGBKLCI();
		this.INPOALKOLAF();
	}

	// Token: 0x06012AAF RID: 76463 RVA: 0x0067CF0F File Offset: 0x0067B10F
	private void KMCPMOGKDEH()
	{
		this.KGBDLPJPAAG(this.currentTab);
	}

	// Token: 0x06012AB0 RID: 76464 RVA: 0x0067C3A8 File Offset: 0x0067A5A8
	private void KNBJBNDGCIJ()
	{
		this.CEJKHCODENB(this.currentTab);
	}

	// Token: 0x06012AB1 RID: 76465 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06012AB2 RID: 76466 RVA: 0x0067CF20 File Offset: 0x0067B120
	private void KDMODFJGGPG()
	{
		foreach (GameObject gameObject in this.tabs)
		{
			gameObject.GetComponent<UITab>().FLNOCLOIMEK(this.tabs.IndexOf(gameObject) == this.currentTab);
		}
	}

	// Token: 0x06012AB3 RID: 76467 RVA: 0x0067CF94 File Offset: 0x0067B194
	public void ILGBFOEMMNN(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_TimeX");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.EMJLLDAKBHA();
		this.ELENFKEEPLP();
	}

	// Token: 0x06012AB4 RID: 76468 RVA: 0x0067CFCC File Offset: 0x0067B1CC
	public void EKMJJMCFEJI(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("_FixDistance");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.MGGAMOFLCLN();
		this.MOKLLKMFJPF();
	}

	// Token: 0x06012AB5 RID: 76469 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06012AB6 RID: 76470 RVA: 0x0067D004 File Offset: 0x0067B204
	private void JFIGOFMCEHB()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(false);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(true);
		}
	}

	// Token: 0x06012AB7 RID: 76471 RVA: 0x0067C843 File Offset: 0x0067AA43
	private void KIMMMCJFMAB()
	{
		this.EKMJJMCFEJI(this.currentTab);
	}

	// Token: 0x06012AB8 RID: 76472 RVA: 0x0067D088 File Offset: 0x0067B288
	public void KGBDLPJPAAG(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("\" error: ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		this.currentTab = JMMILEFMACB;
		this.JKMANIOFCEM();
		this.HJDDLMCOENE();
	}

	// Token: 0x06012AB9 RID: 76473 RVA: 0x0067D0C0 File Offset: 0x0067B2C0
	private void INPOALKOLAF()
	{
		foreach (GameObject gameObject in this.panels)
		{
			gameObject.SetActive(true);
		}
		if (this.panels.Count > 0)
		{
			this.panels[this.currentTab].SetActive(true);
		}
	}

	// Token: 0x040020DE RID: 8414
	public List<GameObject> tabs;

	// Token: 0x040020DF RID: 8415
	public List<GameObject> panels;

	// Token: 0x040020E0 RID: 8416
	public int currentTab;
}
