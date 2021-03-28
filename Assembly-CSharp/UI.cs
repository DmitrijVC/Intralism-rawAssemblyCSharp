using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020004FD RID: 1277
public class UI : Singleton<UI>
{
	// Token: 0x06012ABA RID: 76474 RVA: 0x0067D144 File Offset: 0x0067B344
	public void OFIOJOOKAHI(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = (char)-111;
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			(char)-32
		}).Length > 0)
		{
			string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = (char)-67;
			oejijipgmco = hfefhopolik3.Split(array2)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.AEINPAGJFME)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.AGJKEBOPIOC)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.BDGDIDPDBHG)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.FCAGEDLBBHD)))
					{
						base.StartCoroutine(this.CIADGNBMOLN(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, false, 513f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.CIADGNBMOLN(gameObject, false, oejijipgmco, false, 1463f, false));
				}
				else
				{
					base.StartCoroutine(this.JCLKEGPNBJJ(gameObject, false, oejijipgmco, true, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("team" + hkolopjkhif.HFEFHOPOLIK + "#8E8E8EFF");
		}
	}

	// Token: 0x06012ABB RID: 76475 RVA: 0x0067D4DC File Offset: 0x0067B6DC
	public void KFJPOACGOHL(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == " PhotonView: ")
			{
				this.CIIKGGGDGLC();
				return;
			}
		}
		Debug.LogWarning("logc" + JMMILEFMACB);
	}

	// Token: 0x06012ABC RID: 76476 RVA: 0x0067D519 File Offset: 0x0067B719
	public void KLIKIPEPHDC()
	{
		Singleton<UI>.Instance.LJOBBJGJCOC(",", 770f);
	}

	// Token: 0x06012ABD RID: 76477 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void PNGLBLFJOOJ()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012ABE RID: 76478 RVA: 0x0067D53C File Offset: 0x0067B73C
	public void OOHNEOOCLMB(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			')'
		})[1];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			(char)-65
		}).Length > 0)
		{
			oejijipgmco = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
			{
				(char)-86
			})[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.LNDGINDKPFA)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.LLNDDFGPOPL)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.EKHOOPGPPGE)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.JBAJEMGOPDL)))
					{
						base.StartCoroutine(this.IONNACCHGJL(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, true, 1007f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.PKOPFBHMJHM(gameObject, false, oejijipgmco, true, 238f, false));
				}
				else
				{
					base.StartCoroutine(this.HPMMDHAEAJO(gameObject, false, oejijipgmco, true, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("_Saturation" + hkolopjkhif.HFEFHOPOLIK + "There was an error retrieving the NumberOfCurrentPlayers.");
		}
	}

	// Token: 0x06012ABF RID: 76479 RVA: 0x0067D8D4 File Offset: 0x0067BAD4
	public IEnumerator KOKCANEGNJH(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		UI.NIPBMFLIJAP.OFMFMEAFAHP ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AC0 RID: 76480 RVA: 0x0067D918 File Offset: 0x0067BB18
	public void FFNFEIPDLJF(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			','
		})[1];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			(char)-83
		}).Length > 0)
		{
			string hfefhopolik2 = hkolopjkhif.HFEFHOPOLIK;
			char[] array = new char[1];
			array[1] = '>';
			oejijipgmco = hfefhopolik2.Split(array)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FDAIFOAGDLA)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.BDGDIDPDBHG)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.AEIFJLBBKBP)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.FMIHBNPKEEO)))
					{
						base.StartCoroutine(this.CMFJGHFEKIK(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, true, 1616f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.NCMLIDIEECD(gameObject, true, oejijipgmco, false, 288f, false));
				}
				else
				{
					base.StartCoroutine(this.JCLKEGPNBJJ(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("Bad parameters for getint! Use <key> <value>" + hkolopjkhif.HFEFHOPOLIK + "CameraFilterPack/Glitch_Mozaic");
		}
	}

	// Token: 0x06012AC1 RID: 76481 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void ELOBPADDKGE()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012AC2 RID: 76482 RVA: 0x0067DCB0 File Offset: 0x0067BEB0
	public void CKIEONHHKAI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "[ItemsHandler] Found ")
			{
				this.BackToMainMenu();
				return;
			}
		}
		Debug.LogWarning("buttons" + JMMILEFMACB);
	}

	// Token: 0x06012AC3 RID: 76483 RVA: 0x0067DCF0 File Offset: 0x0067BEF0
	public void LOLFAODHMGD(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = (char)-116;
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = (char)-90;
		if (hfefhopolik3.Split(array2).Length > 1)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = (char)-35;
			oejijipgmco = hfefhopolik4.Split(array3)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.KGKMOLCPDIH)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.OFHCGKJFGDI)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.JDELIMPGFDJ)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.LJDLIIIPIIJ)))
					{
						base.StartCoroutine(this.HJEODGHPPAJ(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, false, 806f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.AMOKEEHJLFP(gameObject, false, oejijipgmco, true, 226f, true));
				}
				else
				{
					base.StartCoroutine(this.AMOKEEHJLFP(gameObject, true, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("_Value2" + hkolopjkhif.HFEFHOPOLIK + "_Value4");
		}
	}

	// Token: 0x06012AC4 RID: 76484 RVA: 0x0067E088 File Offset: 0x0067C288
	public IEnumerator HPMMDHAEAJO(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AC5 RID: 76485 RVA: 0x0067E0CC File Offset: 0x0067C2CC
	public void KFMODLOHGKI(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = (char)-35;
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = (char)-68;
		if (hfefhopolik3.Split(array2).Length > 0)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = (char)-18;
			oejijipgmco = hfefhopolik4.Split(array3)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.AEINPAGJFME)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.LOEAMHGMMPK)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.AEIFJLBBKBP)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.BMAOCLKPNNC)))
					{
						base.StartCoroutine(this.FNBLMPBOKNH(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, true, 142f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.PKOPFBHMJHM(gameObject, false, oejijipgmco, false, 1059f, true));
				}
				else
				{
					base.StartCoroutine(this.PHIJAEAEHCF(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + hkolopjkhif.HFEFHOPOLIK + "Set Arcs Speed");
		}
	}

	// Token: 0x06012AC6 RID: 76486 RVA: 0x0067E464 File Offset: 0x0067C664
	public void IJPAELJGBCK(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "_MainTex2")
			{
				this.AEJENOFBCKI();
				return;
			}
		}
		Debug.LogWarning("SetEnvSpriteColor" + JMMILEFMACB);
	}

	// Token: 0x06012AC7 RID: 76487 RVA: 0x0067E4A1 File Offset: 0x0067C6A1
	public void CIIKGGGDGLC()
	{
		Singleton<UI>.Instance.NGJJBLNKIIH("SetParticlesParticleSpeed", 1862f);
	}

	// Token: 0x06012AC8 RID: 76488 RVA: 0x0067E4B7 File Offset: 0x0067C6B7
	public void AJCJDHAJGHI()
	{
		Singleton<UI>.Instance.KFMODLOHGKI("EventTimeInputField", 761f);
	}

	// Token: 0x06012AC9 RID: 76489 RVA: 0x0067E4CD File Offset: 0x0067C6CD
	public void AEJENOFBCKI()
	{
		Singleton<UI>.Instance.FFNFEIPDLJF("Found best region: '", 796f);
	}

	// Token: 0x06012ACA RID: 76490 RVA: 0x0067E4E3 File Offset: 0x0067C6E3
	public void HKECDBBMPIM()
	{
		Singleton<UI>.Instance.NIBDIAOIODC("BloomShaderValueSlider", 1739f);
	}

	// Token: 0x06012ACB RID: 76491 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void GGIFLKMELMP()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012ACC RID: 76492 RVA: 0x0067E4F9 File Offset: 0x0067C6F9
	public void OEFEMGBOILG(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.")
			{
				this.AEJENOFBCKI();
				return;
			}
		}
		Debug.LogWarning("workshop." + JMMILEFMACB);
	}

	// Token: 0x06012ACD RID: 76493 RVA: 0x0067E538 File Offset: 0x0067C738
	public void NIBDIAOIODC(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			(char)-112
		})[1];
		string oejijipgmco = null;
		string hfefhopolik2 = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = (char)-24;
		if (hfefhopolik2.Split(array).Length > 1)
		{
			string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = 'v';
			oejijipgmco = hfefhopolik3.Split(array2)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FHFECFLBHMA)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.OFHCGKJFGDI)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.OFHCGKJFGDI)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.MEMPOPNAEDN)))
					{
						base.StartCoroutine(this.JCLKEGPNBJJ(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, false, 348f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.PDDENNKIMAA(gameObject, false, oejijipgmco, true, 480f, true));
				}
				else
				{
					base.StartCoroutine(this.NIIOJBIEPMG(gameObject, true, oejijipgmco, false, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("float,1.5" + hkolopjkhif.HFEFHOPOLIK + "#failed!");
		}
	}

	// Token: 0x06012ACE RID: 76494 RVA: 0x0067E8D0 File Offset: 0x0067CAD0
	public IEnumerator CIADGNBMOLN(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012ACF RID: 76495 RVA: 0x0067E911 File Offset: 0x0067CB11
	public void GEAKCNKDOPL()
	{
		Singleton<UI>.Instance.OPPKAFLAKPE("3;4;9;10;21x6", 846f);
	}

	// Token: 0x06012AD0 RID: 76496 RVA: 0x0067E928 File Offset: 0x0067CB28
	public void PPDIGLNIJID(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'p'
		})[1];
		string oejijipgmco = null;
		string hfefhopolik2 = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = (char)-90;
		if (hfefhopolik2.Split(array).Length > 1)
		{
			string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = '\u0014';
			oejijipgmco = hfefhopolik3.Split(array2)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FCAGEDLBBHD)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.PIJAOCFAPKC)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.DKGPCPBNDPK)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.FFEGPHJKMFK)))
					{
						base.StartCoroutine(this.FNBLMPBOKNH(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, false, 1280f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.HHBBFHKPOMM(gameObject, true, oejijipgmco, true, 1411f, false));
				}
				else
				{
					base.StartCoroutine(this.IOEPPMJBOLC(gameObject, true, oejijipgmco, true, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("_ProjectToPixelMatrix" + hkolopjkhif.HFEFHOPOLIK + "0.00");
		}
	}

	// Token: 0x06012AD1 RID: 76497 RVA: 0x0067ECC0 File Offset: 0x0067CEC0
	public IEnumerator PDDENNKIMAA(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AD2 RID: 76498 RVA: 0x0067ED01 File Offset: 0x0067CF01
	public void DJAIHGJGOOL()
	{
		Singleton<UI>.Instance.JDAIFPFDJCK("ticket.ticket1", 417f);
	}

	// Token: 0x06012AD3 RID: 76499 RVA: 0x0067ED17 File Offset: 0x0067CF17
	public void DIFIHGGKLLH(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "_Light2")
			{
				this.AJCJDHAJGHI();
				return;
			}
		}
		Debug.LogWarning("_ScreenResolution" + JMMILEFMACB);
	}

	// Token: 0x06012AD4 RID: 76500 RVA: 0x0067ED54 File Offset: 0x0067CF54
	public void CGKGIDKBCMP(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = (char)-51;
		string hfefhopolik2 = hfefhopolik.Split(array)[1];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[1];
		array2[1] = 'Z';
		if (hfefhopolik3.Split(array2).Length > 0)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = 'V';
			oejijipgmco = hfefhopolik4.Split(array3)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.GBKBDKHPLKG)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.BMAOCLKPNNC)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.FHIJCPPECHA)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.PKAPLCFHDOC)))
					{
						base.StartCoroutine(this.KMOMEPOBDBN(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, false, 275f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.HJEODGHPPAJ(gameObject, true, oejijipgmco, true, 526f, true));
				}
				else
				{
					base.StartCoroutine(this.NMNFEEMHJPF(gameObject, true, oejijipgmco, false, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("x" + hkolopjkhif.HFEFHOPOLIK + "_TimeX");
		}
	}

	// Token: 0x06012AD5 RID: 76501 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void OFEBBEDPNJP()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012AD7 RID: 76503 RVA: 0x0067F0F4 File Offset: 0x0067D2F4
	public void FJGJLPFBFMI(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = (char)-76;
		string hfefhopolik2 = hfefhopolik.Split(array)[1];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[1];
		array2[1] = (char)-37;
		if (hfefhopolik3.Split(array2).Length > 0)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = '\u0011';
			oejijipgmco = hfefhopolik4.Split(array3)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.BKNHHGBPLGH)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.OFHCGKJFGDI)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.MEMPOPNAEDN)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.FJDBPPKABJE)))
					{
						base.StartCoroutine(this.FNBLMPBOKNH(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, false, 1952f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.PKOPFBHMJHM(gameObject, false, oejijipgmco, false, 1602f, true));
				}
				else
				{
					base.StartCoroutine(this.PDDENNKIMAA(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("_TimeX" + hkolopjkhif.HFEFHOPOLIK + "Joystick1Button3");
		}
	}

	// Token: 0x06012AD8 RID: 76504 RVA: 0x0067F48C File Offset: 0x0067D68C
	public IEnumerator PKOPFBHMJHM(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AD9 RID: 76505 RVA: 0x0067F4CD File Offset: 0x0067D6CD
	public void DDOOOLMAILF()
	{
		Singleton<UI>.Instance.MLFKPPBECKP("settings.volume.editor", 272f);
	}

	// Token: 0x06012ADA RID: 76506 RVA: 0x0067F4E4 File Offset: 0x0067D6E4
	public void ACJIJCBDDJL(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'\u000e'
		})[1];
		string oejijipgmco = null;
		string hfefhopolik2 = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'e';
		if (hfefhopolik2.Split(array).Length > 0)
		{
			oejijipgmco = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
			{
				'm'
			})[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.DKGPCPBNDPK)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.MEMPOPNAEDN)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.LNDGINDKPFA)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.AGFDCBCBAGI)))
					{
						base.StartCoroutine(this.SwitchViewAnimation(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, true, 546f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.NMNFEEMHJPF(gameObject, false, oejijipgmco, true, 442f, true));
				}
				else
				{
					base.StartCoroutine(this.NCMLIDIEECD(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("Set the end of the map. Use this if you want to cut the long music." + hkolopjkhif.HFEFHOPOLIK + "SubmitUserVote:");
		}
	}

	// Token: 0x06012ADB RID: 76507 RVA: 0x0067F87C File Offset: 0x0067DA7C
	public void HKJNOKADNGB(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = '7';
		string hfefhopolik2 = hfefhopolik.Split(array)[1];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = 'S';
		if (hfefhopolik3.Split(array2).Length > 1)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[0] = (char)-40;
			oejijipgmco = hfefhopolik4.Split(array3)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FDAIFOAGDLA)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.IGFOBPKFCDJ)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.LJDLIIIPIIJ)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.FFEGPHJKMFK)))
					{
						base.StartCoroutine(this.IOEPPMJBOLC(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, false, 742f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.BCOJGDDEDOP(gameObject, true, oejijipgmco, true, 1582f, false));
				}
				else
				{
					base.StartCoroutine(this.PHIJAEAEHCF(gameObject, true, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("ERROR: Make sure your mod contains at leats one file!" + hkolopjkhif.HFEFHOPOLIK + "Texture2");
		}
	}

	// Token: 0x06012ADC RID: 76508 RVA: 0x0067FC14 File Offset: 0x0067DE14
	public void SwitchView(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'#'
		})[0];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'#'
		}).Length > 1)
		{
			oejijipgmco = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
			{
				'#'
			})[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.GBKBDKHPLKG)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.GBKBDKHPLKG)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.GBKBDKHPLKG)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.GBKBDKHPLKG)))
					{
						base.StartCoroutine(this.SwitchViewAnimation(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, true, 0.2f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.SwitchViewAnimation(gameObject, true, oejijipgmco, true, 0.2f, true));
				}
				else
				{
					base.StartCoroutine(this.SwitchViewAnimation(gameObject, true, oejijipgmco, true, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("[UI] " + hkolopjkhif.HFEFHOPOLIK + " canvas not found");
		}
	}

	// Token: 0x06012ADD RID: 76509 RVA: 0x0067FFAC File Offset: 0x0067E1AC
	public void IGNAKIKPGAP(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = (char)-125;
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'K'
		}).Length > 1)
		{
			string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = (char)-106;
			oejijipgmco = hfefhopolik3.Split(array2)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.AEINPAGJFME)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.OFHCGKJFGDI)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.AEIFJLBBKBP)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.BFEABMIFIEE)))
					{
						base.StartCoroutine(this.HPMMDHAEAJO(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, false, 1153f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.GADDOIMMDHH(gameObject, false, oejijipgmco, true, 1281f, true));
				}
				else
				{
					base.StartCoroutine(this.PHIJAEAEHCF(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("CameraFilterPack/Glow_Glow" + hkolopjkhif.HFEFHOPOLIK + "Item invalid. No idea why.");
		}
	}

	// Token: 0x06012ADE RID: 76510 RVA: 0x00680344 File Offset: 0x0067E544
	public IEnumerator KMOMEPOBDBN(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012ADF RID: 76511 RVA: 0x00680385 File Offset: 0x0067E585
	public void LHNPACKBPKO()
	{
		Singleton<UI>.Instance.PPDIGLNIJID("_ScreenResolution", 189f);
	}

	// Token: 0x06012AE0 RID: 76512 RVA: 0x0068039C File Offset: 0x0067E59C
	public IEnumerator CMFJGHFEKIK(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AE1 RID: 76513 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void OCDOOHGMJIA()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012AE2 RID: 76514 RVA: 0x006803DD File Offset: 0x0067E5DD
	public void PDKFHOIBBGG(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "/files/mods_terms.pdf")
			{
				this.NAMMPGNCFJC();
				return;
			}
		}
		Debug.LogWarning("_ScreenResolution" + JMMILEFMACB);
	}

	// Token: 0x06012AE3 RID: 76515 RVA: 0x0068041C File Offset: 0x0067E61C
	public void JDAIFPFDJCK(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			(char)-62
		})[0];
		string oejijipgmco = null;
		string hfefhopolik2 = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = (char)-86;
		if (hfefhopolik2.Split(array).Length > 0)
		{
			string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
			char[] array2 = new char[0];
			array2[0] = 'L';
			oejijipgmco = hfefhopolik3.Split(array2)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FCAGEDLBBHD)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.HBJFIOJFBHC)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.FHFECFLBHMA)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.OFLDIMDDLHM)))
					{
						base.StartCoroutine(this.BCOJGDDEDOP(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, true, 1618f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.PKOPFBHMJHM(gameObject, true, oejijipgmco, true, 888f, true));
				}
				else
				{
					base.StartCoroutine(this.JCLKEGPNBJJ(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("_Value9" + hkolopjkhif.HFEFHOPOLIK + "mapselector.filter.favoriteonly");
		}
	}

	// Token: 0x06012AE4 RID: 76516 RVA: 0x006807B4 File Offset: 0x0067E9B4
	public void ONJNJAEGLJM()
	{
		Singleton<UI>.Instance.ACJIJCBDDJL("HitVariationSlider", 29f);
	}

	// Token: 0x06012AE5 RID: 76517 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void CCHMCLLHGJF()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012AE6 RID: 76518 RVA: 0x006807CA File Offset: 0x0067E9CA
	public void ButtonClick(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "mainmenu")
			{
				this.BackToMainMenu();
				return;
			}
		}
		Debug.LogWarning("[UI] Unknows button action: " + JMMILEFMACB);
	}

	// Token: 0x06012AE7 RID: 76519 RVA: 0x00680807 File Offset: 0x0067EA07
	public void CGNFHPNAMKA(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "FileMenu")
			{
				this.PPFBFANEHEA();
				return;
			}
		}
		Debug.LogWarning("WARNING: rotation axis set to 0 on " + JMMILEFMACB);
	}

	// Token: 0x06012AE8 RID: 76520 RVA: 0x00680844 File Offset: 0x0067EA44
	public IEnumerator HHBBFHKPOMM(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AE9 RID: 76521 RVA: 0x00680885 File Offset: 0x0067EA85
	public void JAAPAHFEDEH()
	{
		Singleton<UI>.Instance.JDAIFPFDJCK("VIGNETTE_CLASSIC", 945f);
	}

	// Token: 0x06012AEA RID: 76522 RVA: 0x0068089C File Offset: 0x0067EA9C
	public void BEMEHOBGEFB(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = (char)-101;
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'E'
		}).Length > 1)
		{
			string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = '\u0004';
			oejijipgmco = hfefhopolik3.Split(array2)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.EKHOOPGPPGE)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.DNIMHEKGJHB)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.LLNDDFGPOPL)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.EFAPFFFGOOA)))
					{
						base.StartCoroutine(this.BCOJGDDEDOP(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, true, 1697f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.CMFJGHFEKIK(gameObject, false, oejijipgmco, false, 1739f, true));
				}
				else
				{
					base.StartCoroutine(this.PDDENNKIMAA(gameObject, true, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("_Blue_R" + hkolopjkhif.HFEFHOPOLIK + "GameScene");
		}
	}

	// Token: 0x06012AEB RID: 76523 RVA: 0x00680C34 File Offset: 0x0067EE34
	public void EFPPCCBIMKM()
	{
		Singleton<UI>.Instance.LOLFAODHMGD("player.arrow", 1260f);
	}

	// Token: 0x06012AEC RID: 76524 RVA: 0x00680C4C File Offset: 0x0067EE4C
	public IEnumerator AMOKEEHJLFP(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AED RID: 76525 RVA: 0x00680C90 File Offset: 0x0067EE90
	public IEnumerator NCMLIDIEECD(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AEE RID: 76526 RVA: 0x00680CD4 File Offset: 0x0067EED4
	public void MLFKPPBECKP(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = 'j';
		string hfefhopolik2 = hfefhopolik.Split(array)[1];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = (char)-45;
		if (hfefhopolik3.Split(array2).Length > 0)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = (char)-89;
			oejijipgmco = hfefhopolik4.Split(array3)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.MGENGAEDACG)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.BDGDIDPDBHG)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.FDAIFOAGDLA)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.BDGDIDPDBHG)))
					{
						base.StartCoroutine(this.HJEODGHPPAJ(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, false, 850f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.NIIOJBIEPMG(gameObject, false, oejijipgmco, true, 70f, true));
				}
				else
				{
					base.StartCoroutine(this.HJEODGHPPAJ(gameObject, true, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])" + hkolopjkhif.HFEFHOPOLIK + "[LevelEditorScene] Error: Timeout :S");
		}
	}

	// Token: 0x06012AEF RID: 76527 RVA: 0x0068106C File Offset: 0x0067F26C
	public void LBKIOIKDFCP(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "DPADVER")
			{
				this.AEJENOFBCKI();
				return;
			}
		}
		Debug.LogWarning("_Value2" + JMMILEFMACB);
	}

	// Token: 0x06012AF0 RID: 76528 RVA: 0x006810A9 File Offset: 0x0067F2A9
	public void EENKPNLIHJB(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "Mouse Wheel Up")
			{
				this.IMGIPHENIFC();
				return;
			}
		}
		Debug.LogWarning("CameraFilterPack/Distortion_Dissipation" + JMMILEFMACB);
	}

	// Token: 0x06012AF1 RID: 76529 RVA: 0x006810E8 File Offset: 0x0067F2E8
	public void JGHKKDOEDCK(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = (char)-90;
		string hfefhopolik2 = hfefhopolik.Split(array)[1];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = (char)-15;
		if (hfefhopolik3.Split(array2).Length > 1)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[0];
			array3[1] = '\u0011';
			oejijipgmco = hfefhopolik4.Split(array3)[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.KFNBKFELFLH)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.FFEGPHJKMFK)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.KGKMOLCPDIH)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.AGJKEBOPIOC)))
					{
						base.StartCoroutine(this.BCOJGDDEDOP(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, true, 1008f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.NMNFEEMHJPF(gameObject, false, oejijipgmco, true, 371f, false));
				}
				else
				{
					base.StartCoroutine(this.FNBLMPBOKNH(gameObject, true, oejijipgmco, true, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("player.blackwhite" + hkolopjkhif.HFEFHOPOLIK + "#,0.00");
		}
	}

	// Token: 0x06012AF2 RID: 76530 RVA: 0x00681480 File Offset: 0x0067F680
	public IEnumerator HJEODGHPPAJ(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AF3 RID: 76531 RVA: 0x006814C1 File Offset: 0x0067F6C1
	public void DGFKMFBCKKJ()
	{
		Singleton<UI>.Instance.OFIOJOOKAHI("_Value3", 1478f);
	}

	// Token: 0x06012AF4 RID: 76532 RVA: 0x006814D7 File Offset: 0x0067F6D7
	public void JHFOMLLGNKD(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "The given 2D texture ")
			{
				this.AJCJDHAJGHI();
				return;
			}
		}
		Debug.LogWarning("[Up-Right-Left]" + JMMILEFMACB);
	}

	// Token: 0x06012AF5 RID: 76533 RVA: 0x00681514 File Offset: 0x0067F714
	public IEnumerator PHIJAEAEHCF(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AF6 RID: 76534 RVA: 0x00681555 File Offset: 0x0067F755
	public void CBFEECDDINO()
	{
		Singleton<UI>.Instance.PPDIGLNIJID("OpSettings()", 418f);
	}

	// Token: 0x06012AF7 RID: 76535 RVA: 0x0068156C File Offset: 0x0067F76C
	public void OPPKAFLAKPE(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = '\u000f';
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = (char)-92;
		if (hfefhopolik3.Split(array2).Length > 0)
		{
			oejijipgmco = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
			{
				(char)-33
			})[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.DBFPGFHEGKA)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.IGFOBPKFCDJ)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.JKEDCEOCPJO)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.FMIHBNPKEEO)))
					{
						base.StartCoroutine(this.FNBLMPBOKNH(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, true, 233f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.IOEPPMJBOLC(gameObject, true, oejijipgmco, false, 1472f, true));
				}
				else
				{
					base.StartCoroutine(this.KMOMEPOBDBN(gameObject, false, oejijipgmco, true, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("_ForegroundBlurExtrude" + hkolopjkhif.HFEFHOPOLIK + "LB");
		}
	}

	// Token: 0x06012AF8 RID: 76536 RVA: 0x00681904 File Offset: 0x0067FB04
	public IEnumerator SwitchViewAnimation(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AF9 RID: 76537 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void MCCBKCDPIMK()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012AFA RID: 76538 RVA: 0x00681948 File Offset: 0x0067FB48
	public IEnumerator IOEPPMJBOLC(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AFB RID: 76539 RVA: 0x0068198C File Offset: 0x0067FB8C
	public IEnumerator IONNACCHGJL(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012AFC RID: 76540 RVA: 0x006819CD File Offset: 0x0067FBCD
	public void FAIMFNFOFCE(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "inventory.selected.")
			{
				this.DJAIHGJGOOL();
				return;
			}
		}
		Debug.LogWarning("Joystick1Button10" + JMMILEFMACB);
	}

	// Token: 0x06012AFD RID: 76541 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void DOGABOPPHBH()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012AFE RID: 76542 RVA: 0x00681A0A File Offset: 0x0067FC0A
	public void EJIPLOBKMPC()
	{
		Singleton<UI>.Instance.MLFKPPBECKP("note.3", 1773f);
	}

	// Token: 0x06012AFF RID: 76543 RVA: 0x00681A20 File Offset: 0x0067FC20
	public void IMGIPHENIFC()
	{
		Singleton<UI>.Instance.FJGJLPFBFMI("_ScreenResolution", 1964f);
	}

	// Token: 0x06012B00 RID: 76544 RVA: 0x00681A36 File Offset: 0x0067FC36
	public void FAGIEGMPAIC()
	{
		Singleton<UI>.Instance.OFIOJOOKAHI("[ResourcesManager] Load image error: ", 408f);
	}

	// Token: 0x06012B01 RID: 76545 RVA: 0x00681A4C File Offset: 0x0067FC4C
	public void MBLLNLBBAAL(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = (char)-33;
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = (char)-83;
		if (hfefhopolik3.Split(array2).Length > 0)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[1];
			array3[1] = (char)-123;
			oejijipgmco = hfefhopolik4.Split(array3)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.BFEABMIFIEE)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.FJDBPPKABJE)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).HDAOEDNALLJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.AEIFJLBBKBP)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.DKGPCPBNDPK)))
					{
						base.StartCoroutine(this.NCMLIDIEECD(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, true, 360f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.HHBBFHKPOMM(gameObject, false, oejijipgmco, true, 712f, true));
				}
				else
				{
					base.StartCoroutine(this.CIADGNBMOLN(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("settings.selectormapsperpage" + hkolopjkhif.HFEFHOPOLIK + " evLeave: ");
		}
	}

	// Token: 0x06012B02 RID: 76546 RVA: 0x00681DE4 File Offset: 0x0067FFE4
	public IEnumerator BFCOGLHKJLN(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B03 RID: 76547 RVA: 0x00681E25 File Offset: 0x00680025
	public void MDGJJGHJGKE()
	{
		Singleton<UI>.Instance.CGKGIDKBCMP("GlassesColor2", 1756f);
	}

	// Token: 0x06012B04 RID: 76548 RVA: 0x00681E3B File Offset: 0x0068003B
	public void EGFJCDLNGIL(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "ConfigVersionSlider")
			{
				this.EFPPCCBIMKM();
				return;
			}
		}
		Debug.LogWarning("_FadeFX" + JMMILEFMACB);
	}

	// Token: 0x06012B05 RID: 76549 RVA: 0x00681E78 File Offset: 0x00680078
	public void BackToMainMenu()
	{
		Singleton<UI>.Instance.SwitchView("mainMenu", 0.2f);
	}

	// Token: 0x06012B06 RID: 76550 RVA: 0x00681E90 File Offset: 0x00680090
	public IEnumerator NMNFEEMHJPF(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B07 RID: 76551 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void DDPPHDJFKOF()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012B08 RID: 76552 RVA: 0x00681ED4 File Offset: 0x006800D4
	public void HPMHPFOBPED(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			(char)-107
		})[1];
		string oejijipgmco = null;
		string hfefhopolik2 = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[1];
		array[1] = 'b';
		if (hfefhopolik2.Split(array).Length > 1)
		{
			oejijipgmco = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
			{
				(char)-2
			})[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FJDBPPKABJE)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.LOEAMHGMMPK)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.OFHCGKJFGDI)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.OFHCGKJFGDI)))
					{
						base.StartCoroutine(this.JCLKEGPNBJJ(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, true, 39f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.NMNFEEMHJPF(gameObject, true, oejijipgmco, true, 1735f, false));
				}
				else
				{
					base.StartCoroutine(this.CBLGHHBMCPD(gameObject, true, oejijipgmco, true, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_Multiply" + hkolopjkhif.HFEFHOPOLIK + "inventory.selected.");
		}
	}

	// Token: 0x06012B09 RID: 76553 RVA: 0x0068226C File Offset: 0x0068046C
	public void LJOBBJGJCOC(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'\u0015'
		})[0];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			'-'
		}).Length > 1)
		{
			string hfefhopolik2 = hkolopjkhif.HFEFHOPOLIK;
			char[] array = new char[1];
			array[1] = (char)-5;
			oejijipgmco = hfefhopolik2.Split(array)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FDAIFOAGDLA)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.OLIGLEMPFOP)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.BJMAIJDIKCN)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.AEIFJLBBKBP)))
					{
						base.StartCoroutine(this.HPMMDHAEAJO(pepaddkcagk.IPIOPNOHDOB, true, oejijipgmco, false, 195f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.IOEPPMJBOLC(gameObject, true, oejijipgmco, false, 1959f, false));
				}
				else
				{
					base.StartCoroutine(this.AMOKEEHJLFP(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("(\\[ *quote *\\])" + hkolopjkhif.HFEFHOPOLIK + "_TimeX");
		}
	}

	// Token: 0x06012B0A RID: 76554 RVA: 0x00682604 File Offset: 0x00680804
	public IEnumerator BCOJGDDEDOP(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B0B RID: 76555 RVA: 0x00682648 File Offset: 0x00680848
	public IEnumerator JCLKEGPNBJJ(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B0C RID: 76556 RVA: 0x0068268C File Offset: 0x0068088C
	public void BMFMLKCDOOE(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = ' ';
		string hfefhopolik2 = hfefhopolik.Split(array)[0];
		string oejijipgmco = null;
		if (hkolopjkhif.HFEFHOPOLIK.Split(new char[]
		{
			(char)-32
		}).Length > 1)
		{
			string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
			char[] array2 = new char[1];
			array2[1] = (char)-67;
			oejijipgmco = hfefhopolik3.Split(array2)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.HBJFIOJFBHC)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.BMAOCLKPNNC)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).AIBBBPLLCFJ(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.AEINPAGJFME)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.JDELIMPGFDJ)))
					{
						base.StartCoroutine(this.KOKCANEGNJH(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, true, 557f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.PHIJAEAEHCF(gameObject, false, oejijipgmco, true, 1689f, false));
				}
				else
				{
					base.StartCoroutine(this.HHBBFHKPOMM(gameObject, true, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("#yes" + hkolopjkhif.HFEFHOPOLIK + "stretchWidth");
		}
	}

	// Token: 0x06012B0D RID: 76557 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void ClearSelection()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012B0E RID: 76558 RVA: 0x00682A24 File Offset: 0x00680C24
	public void PPFBFANEHEA()
	{
		Singleton<UI>.Instance.KFMODLOHGKI("Items", 308f);
	}

	// Token: 0x06012B0F RID: 76559 RVA: 0x00682A3A File Offset: 0x00680C3A
	public void PEJKKBOELBA(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "_AdaptParams")
			{
				this.ONJNJAEGLJM();
				return;
			}
		}
		Debug.LogWarning("Clears the console and prints the logs in the specified range" + JMMILEFMACB);
	}

	// Token: 0x06012B10 RID: 76560 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void HPLGACFDEJJ()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012B11 RID: 76561 RVA: 0x00682A77 File Offset: 0x00680C77
	public void NAMMPGNCFJC()
	{
		Singleton<UI>.Instance.BEMEHOBGEFB("id", 541f);
	}

	// Token: 0x06012B12 RID: 76562 RVA: 0x00682A90 File Offset: 0x00680C90
	public IEnumerator NIIOJBIEPMG(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B13 RID: 76563 RVA: 0x00682AD1 File Offset: 0x00680CD1
	public void BKBBGAFPIKA(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "_ScreenResolution")
			{
				this.CBFEECDDINO();
				return;
			}
		}
		Debug.LogWarning("_Value4" + JMMILEFMACB);
	}

	// Token: 0x06012B14 RID: 76564 RVA: 0x00682B0E File Offset: 0x00680D0E
	public void MDKHCGABDAI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == ":")
			{
				this.KLIKIPEPHDC();
				return;
			}
		}
		Debug.LogWarning("[Right]" + JMMILEFMACB);
	}

	// Token: 0x06012B15 RID: 76565 RVA: 0x00682B4C File Offset: 0x00680D4C
	public IEnumerator FNBLMPBOKNH(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B16 RID: 76566 RVA: 0x00682B8D File Offset: 0x00680D8D
	public void OPJPHPIOBGE(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "_Value")
			{
				this.CIIKGGGDGLC();
				return;
			}
		}
		Debug.LogWarning("menu.enableselectormusic" + JMMILEFMACB);
	}

	// Token: 0x06012B17 RID: 76567 RVA: 0x00682BCA File Offset: 0x00680DCA
	public void BJJAIAGDMGI(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "SetLives")
			{
				this.FAGIEGMPAIC();
				return;
			}
		}
		Debug.LogWarning("settings.enablehitsoundsinrelax" + JMMILEFMACB);
	}

	// Token: 0x06012B18 RID: 76568 RVA: 0x00682C08 File Offset: 0x00680E08
	public IEnumerator CBLGHHBMCPD(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B19 RID: 76569 RVA: 0x00682C4C File Offset: 0x00680E4C
	public void NGJJBLNKIIH(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[1] = (char)-3;
		string hfefhopolik2 = hfefhopolik.Split(array)[1];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[1] = '@';
		if (hfefhopolik3.Split(array2).Length > 0)
		{
			oejijipgmco = hkolopjkhif.HFEFHOPOLIK.Split(new char[]
			{
				(char)-79
			})[0];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.JDELIMPGFDJ)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.FHIJCPPECHA)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.EKHOOPGPPGE)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.BMAOCLKPNNC)))
					{
						base.StartCoroutine(this.PHIJAEAEHCF(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, false, 132f, false));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.CMFJGHFEKIK(gameObject, true, oejijipgmco, true, 1489f, false));
				}
				else
				{
					base.StartCoroutine(this.AMOKEEHJLFP(gameObject, false, oejijipgmco, false, KEDDLFDAIDE, false));
				}
			}
		}
		else
		{
			Debug.LogError("maps." + hkolopjkhif.HFEFHOPOLIK + "CameraFilterPack/Blend2Camera_GreenScreen");
		}
	}

	// Token: 0x06012B1A RID: 76570 RVA: 0x00682FE4 File Offset: 0x006811E4
	public IEnumerator GADDOIMMDHH(GameObject IPIOPNOHDOB, bool BNKMBAECHGB, string OEJIJIPGMCO = null, bool LFNGGHMNBAD = true, float KEDDLFDAIDE = 0.2f, bool OGPEIHMCNGO = true)
	{
		ofmfmeafahp = new UI.NIPBMFLIJAP.OFMFMEAFAHP();
		ofmfmeafahp.MEIIPIOPCIJ = this;
		if (BNKMBAECHGB)
		{
			if (LFNGGHMNBAD)
			{
				IPIOPNOHDOB.SetActive(true);
			}
			if (OGPEIHMCNGO)
			{
				IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}
		else if (OGPEIHMCNGO)
		{
			IPIOPNOHDOB.GetComponent<CanvasGroup>().alpha = 1f;
		}
		if (IPIOPNOHDOB.GetComponent<UIViewLayer>())
		{
			if (BNKMBAECHGB)
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Init(OEJIJIPGMCO);
			}
			else
			{
				IPIOPNOHDOB.GetComponent<UIViewLayer>().Close(OEJIJIPGMCO);
			}
		}
		ofmfmeafahp.LGILGCGIHHM = IPIOPNOHDOB.GetComponent<CanvasGroup>().DOFade((float)((!BNKMBAECHGB) ? 0 : 1), KEDDLFDAIDE);
		yield return new WaitWhile(new Func<bool>(ofmfmeafahp.GBKBDKHPLKG));
		if (!BNKMBAECHGB && LFNGGHMNBAD)
		{
			IPIOPNOHDOB.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06012B1B RID: 76571 RVA: 0x00683025 File Offset: 0x00681225
	public void LBFGNKKJJHB(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "Player")
			{
				this.EFPPCCBIMKM();
				return;
			}
		}
		Debug.LogWarning("MascotChallenge2019" + JMMILEFMACB);
	}

	// Token: 0x06012B1C RID: 76572 RVA: 0x0067D52F File Offset: 0x0067B72F
	public void DLHMKKOKJPE()
	{
		EventSystem.current.SetSelectedGameObject(null);
	}

	// Token: 0x06012B1D RID: 76573 RVA: 0x00683064 File Offset: 0x00681264
	public void KOOJFJDNFCJ(string HFEFHOPOLIK, float KEDDLFDAIDE = 0.2f)
	{
		UI.HKOLOPJKHIF hkolopjkhif = new UI.HKOLOPJKHIF();
		hkolopjkhif.HFEFHOPOLIK = HFEFHOPOLIK;
		string hfefhopolik = hkolopjkhif.HFEFHOPOLIK;
		char[] array = new char[0];
		array[0] = (char)-35;
		string hfefhopolik2 = hfefhopolik.Split(array)[1];
		string oejijipgmco = null;
		string hfefhopolik3 = hkolopjkhif.HFEFHOPOLIK;
		char[] array2 = new char[0];
		array2[0] = (char)-99;
		if (hfefhopolik3.Split(array2).Length > 1)
		{
			string hfefhopolik4 = hkolopjkhif.HFEFHOPOLIK;
			char[] array3 = new char[1];
			array3[1] = (char)-114;
			oejijipgmco = hfefhopolik4.Split(array3)[1];
		}
		hkolopjkhif.HFEFHOPOLIK = hfefhopolik2;
		if (this.viewsDictionary.Exists(new Predicate<UI.UIView>(hkolopjkhif.FFEGPHJKMFK)))
		{
			List<GameObject> list = new List<GameObject>();
			List<GameObject> list2 = new List<GameObject>();
			foreach (UI.UIView uiview in this.viewsDictionary)
			{
				if (uiview.id == hkolopjkhif.HFEFHOPOLIK)
				{
					using (List<GameObject>.Enumerator enumerator2 = uiview.canvases.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UI.MACNHEJAEDM macnhejaedm = new UI.MACNHEJAEDM();
							macnhejaedm.IPIOPNOHDOB = enumerator2.Current;
							if (!list2.Exists(new Predicate<GameObject>(macnhejaedm.JDELIMPGFDJ)))
							{
								list2.Add(macnhejaedm.IPIOPNOHDOB);
							}
						}
					}
					if (UnityEngine.Object.FindObjectOfType<MenuScene>())
					{
						if (uiview.useZoom)
						{
							((MenuScene)Singleton<Scene>.Instance).SetPlayerDistance(uiview.zoom);
						}
						((MenuScene)Singleton<Scene>.Instance).SetPlayerBlur(uiview.blurBG);
					}
				}
				else
				{
					using (List<GameObject>.Enumerator enumerator3 = uiview.canvases.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							UI.IAMIDBEHMEC iamidbehmec = new UI.IAMIDBEHMEC();
							iamidbehmec.IPIOPNOHDOB = enumerator3.Current;
							if (!list.Exists(new Predicate<GameObject>(iamidbehmec.FJDBPPKABJE)))
							{
								list.Add(iamidbehmec.IPIOPNOHDOB);
							}
						}
					}
				}
			}
			using (List<GameObject>.Enumerator enumerator4 = list.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					UI.PEPADDKCAGK pepaddkcagk = new UI.PEPADDKCAGK();
					pepaddkcagk.IPIOPNOHDOB = enumerator4.Current;
					if (!list2.Exists(new Predicate<GameObject>(pepaddkcagk.EDGAPOPEIJF)))
					{
						base.StartCoroutine(this.CIADGNBMOLN(pepaddkcagk.IPIOPNOHDOB, false, oejijipgmco, false, 1730f, true));
					}
				}
			}
			foreach (GameObject gameObject in list2)
			{
				if (!gameObject.activeSelf)
				{
					base.StartCoroutine(this.BCOJGDDEDOP(gameObject, true, oejijipgmco, true, 1552f, false));
				}
				else
				{
					base.StartCoroutine(this.CBLGHHBMCPD(gameObject, true, oejijipgmco, true, KEDDLFDAIDE, true));
				}
			}
		}
		else
		{
			Debug.LogError("ConfigVersionSlider" + hkolopjkhif.HFEFHOPOLIK + "_ColoredChange");
		}
	}

	// Token: 0x06012B1E RID: 76574 RVA: 0x006833FC File Offset: 0x006815FC
	public void ILEIPDFMLJL(string JMMILEFMACB)
	{
		if (JMMILEFMACB != null)
		{
			if (JMMILEFMACB == "]")
			{
				this.MDGJJGHJGKE();
				return;
			}
		}
		Debug.LogWarning(".sawoutdatedmessage" + JMMILEFMACB);
	}

	// Token: 0x040020E1 RID: 8417
	[SerializeField]
	public List<UI.UIView> viewsDictionary;

	// Token: 0x020004FE RID: 1278
	[Serializable]
	public class UIView
	{
		// Token: 0x040020E2 RID: 8418
		public string id;

		// Token: 0x040020E3 RID: 8419
		public bool useZoom;

		// Token: 0x040020E4 RID: 8420
		public float zoom;

		// Token: 0x040020E5 RID: 8421
		public bool blurBG;

		// Token: 0x040020E6 RID: 8422
		public List<GameObject> canvases;
	}

	// Token: 0x020004FF RID: 1279
	[CompilerGenerated]
	private sealed class HKOLOPJKHIF
	{
		// Token: 0x06012B20 RID: 76576 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FHFECFLBHMA(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B21 RID: 76577 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FMIHBNPKEEO(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B22 RID: 76578 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FFEGPHJKMFK(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B23 RID: 76579 RVA: 0x00683439 File Offset: 0x00681639
		internal bool OFLDIMDDLHM(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B24 RID: 76580 RVA: 0x00683439 File Offset: 0x00681639
		internal bool BFEABMIFIEE(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B25 RID: 76581 RVA: 0x00683439 File Offset: 0x00681639
		internal bool AEINPAGJFME(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B26 RID: 76582 RVA: 0x00683439 File Offset: 0x00681639
		internal bool KFNBKFELFLH(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B27 RID: 76583 RVA: 0x00683439 File Offset: 0x00681639
		internal bool EGKGJJGAPMN(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B28 RID: 76584 RVA: 0x00683439 File Offset: 0x00681639
		internal bool LLNDDFGPOPL(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B29 RID: 76585 RVA: 0x00683439 File Offset: 0x00681639
		internal bool GBKBDKHPLKG(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B2A RID: 76586 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FJDBPPKABJE(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B2B RID: 76587 RVA: 0x00683439 File Offset: 0x00681639
		internal bool JDELIMPGFDJ(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B2C RID: 76588 RVA: 0x00683439 File Offset: 0x00681639
		internal bool BEBAENEJFLD(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B2D RID: 76589 RVA: 0x00683439 File Offset: 0x00681639
		internal bool LJDLIIIPIIJ(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B2E RID: 76590 RVA: 0x00683439 File Offset: 0x00681639
		internal bool DBFPGFHEGKA(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B2F RID: 76591 RVA: 0x00683439 File Offset: 0x00681639
		internal bool KGKMOLCPDIH(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B30 RID: 76592 RVA: 0x00683439 File Offset: 0x00681639
		internal bool MGENGAEDACG(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B31 RID: 76593 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FDAIFOAGDLA(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B32 RID: 76594 RVA: 0x00683439 File Offset: 0x00681639
		internal bool PIJAOCFAPKC(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B33 RID: 76595 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FCAGEDLBBHD(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B34 RID: 76596 RVA: 0x00683439 File Offset: 0x00681639
		internal bool LOEAMHGMMPK(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B35 RID: 76597 RVA: 0x00683439 File Offset: 0x00681639
		internal bool LNDGINDKPFA(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B36 RID: 76598 RVA: 0x00683439 File Offset: 0x00681639
		internal bool BJMAIJDIKCN(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B37 RID: 76599 RVA: 0x00683439 File Offset: 0x00681639
		internal bool DNIMHEKGJHB(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B38 RID: 76600 RVA: 0x00683439 File Offset: 0x00681639
		internal bool INHOEMCLAAP(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B3A RID: 76602 RVA: 0x00683439 File Offset: 0x00681639
		internal bool BDGDIDPDBHG(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B3B RID: 76603 RVA: 0x00683439 File Offset: 0x00681639
		internal bool AEIFJLBBKBP(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B3C RID: 76604 RVA: 0x00683439 File Offset: 0x00681639
		internal bool JKEDCEOCPJO(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B3D RID: 76605 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FHIJCPPECHA(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B3E RID: 76606 RVA: 0x00683439 File Offset: 0x00681639
		internal bool OLIGLEMPFOP(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B3F RID: 76607 RVA: 0x00683439 File Offset: 0x00681639
		internal bool PBCAHKDLFPE(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B40 RID: 76608 RVA: 0x00683439 File Offset: 0x00681639
		internal bool HBJFIOJFBHC(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B41 RID: 76609 RVA: 0x00683439 File Offset: 0x00681639
		internal bool MEMPOPNAEDN(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B42 RID: 76610 RVA: 0x00683439 File Offset: 0x00681639
		internal bool JBAJEMGOPDL(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B43 RID: 76611 RVA: 0x00683439 File Offset: 0x00681639
		internal bool LHHFJBIAHCN(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B44 RID: 76612 RVA: 0x00683439 File Offset: 0x00681639
		internal bool EFAPFFFGOOA(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B45 RID: 76613 RVA: 0x00683439 File Offset: 0x00681639
		internal bool BKNHHGBPLGH(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B46 RID: 76614 RVA: 0x00683439 File Offset: 0x00681639
		internal bool OFHCGKJFGDI(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B47 RID: 76615 RVA: 0x00683439 File Offset: 0x00681639
		internal bool DKGPCPBNDPK(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B48 RID: 76616 RVA: 0x00683439 File Offset: 0x00681639
		internal bool FIPCLHEKKCA(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B49 RID: 76617 RVA: 0x00683439 File Offset: 0x00681639
		internal bool BMAOCLKPNNC(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B4A RID: 76618 RVA: 0x00683439 File Offset: 0x00681639
		internal bool EKHOOPGPPGE(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B4B RID: 76619 RVA: 0x00683439 File Offset: 0x00681639
		internal bool AGJKEBOPIOC(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x06012B4C RID: 76620 RVA: 0x00683439 File Offset: 0x00681639
		internal bool IGFOBPKFCDJ(UI.UIView IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.HFEFHOPOLIK;
		}

		// Token: 0x040020E7 RID: 8423
		internal string HFEFHOPOLIK;
	}

	// Token: 0x02000500 RID: 1280
	[CompilerGenerated]
	private sealed class MACNHEJAEDM
	{
		// Token: 0x06012B4D RID: 76621 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B4E RID: 76622 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B4F RID: 76623 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B50 RID: 76624 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B51 RID: 76625 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B52 RID: 76626 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B53 RID: 76627 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B54 RID: 76628 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B55 RID: 76629 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B56 RID: 76630 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B58 RID: 76632 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B59 RID: 76633 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B5A RID: 76634 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B5B RID: 76635 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B5C RID: 76636 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B5D RID: 76637 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B5E RID: 76638 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B5F RID: 76639 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B60 RID: 76640 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B61 RID: 76641 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B62 RID: 76642 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B63 RID: 76643 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B64 RID: 76644 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B65 RID: 76645 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B66 RID: 76646 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B67 RID: 76647 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B68 RID: 76648 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B69 RID: 76649 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B6A RID: 76650 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B6B RID: 76651 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B6C RID: 76652 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B6D RID: 76653 RVA: 0x0068344C File Offset: 0x0068164C
		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x040020E8 RID: 8424
		internal GameObject IPIOPNOHDOB;
	}

	// Token: 0x02000501 RID: 1281
	[CompilerGenerated]
	private sealed class IAMIDBEHMEC
	{
		// Token: 0x06012B6E RID: 76654 RVA: 0x00683464 File Offset: 0x00681664
		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B6F RID: 76655 RVA: 0x00683464 File Offset: 0x00681664
		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B70 RID: 76656 RVA: 0x00683464 File Offset: 0x00681664
		internal bool FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B71 RID: 76657 RVA: 0x00683464 File Offset: 0x00681664
		internal bool OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B72 RID: 76658 RVA: 0x00683464 File Offset: 0x00681664
		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B73 RID: 76659 RVA: 0x00683464 File Offset: 0x00681664
		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B74 RID: 76660 RVA: 0x00683464 File Offset: 0x00681664
		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B75 RID: 76661 RVA: 0x00683464 File Offset: 0x00681664
		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B76 RID: 76662 RVA: 0x00683464 File Offset: 0x00681664
		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B77 RID: 76663 RVA: 0x00683464 File Offset: 0x00681664
		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B78 RID: 76664 RVA: 0x00683464 File Offset: 0x00681664
		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B79 RID: 76665 RVA: 0x00683464 File Offset: 0x00681664
		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B7A RID: 76666 RVA: 0x00683464 File Offset: 0x00681664
		internal bool FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B7B RID: 76667 RVA: 0x00683464 File Offset: 0x00681664
		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B7C RID: 76668 RVA: 0x00683464 File Offset: 0x00681664
		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B7D RID: 76669 RVA: 0x00683464 File Offset: 0x00681664
		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B7E RID: 76670 RVA: 0x00683464 File Offset: 0x00681664
		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B7F RID: 76671 RVA: 0x00683464 File Offset: 0x00681664
		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B80 RID: 76672 RVA: 0x00683464 File Offset: 0x00681664
		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B81 RID: 76673 RVA: 0x00683464 File Offset: 0x00681664
		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B82 RID: 76674 RVA: 0x00683464 File Offset: 0x00681664
		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B83 RID: 76675 RVA: 0x00683464 File Offset: 0x00681664
		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B84 RID: 76676 RVA: 0x00683464 File Offset: 0x00681664
		internal bool MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B85 RID: 76677 RVA: 0x00683464 File Offset: 0x00681664
		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B86 RID: 76678 RVA: 0x00683464 File Offset: 0x00681664
		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B87 RID: 76679 RVA: 0x00683464 File Offset: 0x00681664
		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B88 RID: 76680 RVA: 0x00683464 File Offset: 0x00681664
		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B89 RID: 76681 RVA: 0x00683464 File Offset: 0x00681664
		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B8A RID: 76682 RVA: 0x00683464 File Offset: 0x00681664
		internal bool JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B8B RID: 76683 RVA: 0x00683464 File Offset: 0x00681664
		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B8C RID: 76684 RVA: 0x00683464 File Offset: 0x00681664
		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B8D RID: 76685 RVA: 0x00683464 File Offset: 0x00681664
		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B8E RID: 76686 RVA: 0x00683464 File Offset: 0x00681664
		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B8F RID: 76687 RVA: 0x00683464 File Offset: 0x00681664
		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B90 RID: 76688 RVA: 0x00683464 File Offset: 0x00681664
		internal bool BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B92 RID: 76690 RVA: 0x00683464 File Offset: 0x00681664
		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B93 RID: 76691 RVA: 0x00683464 File Offset: 0x00681664
		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B94 RID: 76692 RVA: 0x00683464 File Offset: 0x00681664
		internal bool AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B95 RID: 76693 RVA: 0x00683464 File Offset: 0x00681664
		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x06012B96 RID: 76694 RVA: 0x00683464 File Offset: 0x00681664
		internal bool LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.transform == this.IPIOPNOHDOB.transform;
		}

		// Token: 0x040020E9 RID: 8425
		internal GameObject IPIOPNOHDOB;
	}

	// Token: 0x02000502 RID: 1282
	[CompilerGenerated]
	private sealed class PEPADDKCAGK
	{
		// Token: 0x06012B97 RID: 76695 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B98 RID: 76696 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B99 RID: 76697 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B9A RID: 76698 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B9B RID: 76699 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B9C RID: 76700 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B9D RID: 76701 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool EDGAPOPEIJF(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B9E RID: 76702 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012B9F RID: 76703 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA0 RID: 76704 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA1 RID: 76705 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FMIHBNPKEEO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA2 RID: 76706 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool EFAPFFFGOOA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA3 RID: 76707 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA4 RID: 76708 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA5 RID: 76709 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA6 RID: 76710 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA7 RID: 76711 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA8 RID: 76712 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BA9 RID: 76713 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool BEBAENEJFLD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BAA RID: 76714 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BAB RID: 76715 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool PCDFLCEIHFF(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BAC RID: 76716 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool OMBHIBNMFNB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BAD RID: 76717 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BAE RID: 76718 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool AKDOOLPMPMG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BAF RID: 76719 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB0 RID: 76720 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB1 RID: 76721 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB2 RID: 76722 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB4 RID: 76724 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB5 RID: 76725 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB6 RID: 76726 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool PKAPLCFHDOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB7 RID: 76727 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB8 RID: 76728 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BB9 RID: 76729 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool JBCHBMKPDAJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BBA RID: 76730 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BBB RID: 76731 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BBC RID: 76732 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BBD RID: 76733 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BBE RID: 76734 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BBF RID: 76735 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC0 RID: 76736 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC1 RID: 76737 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC2 RID: 76738 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC3 RID: 76739 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC4 RID: 76740 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC5 RID: 76741 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC6 RID: 76742 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC7 RID: 76743 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC8 RID: 76744 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool MAGEPMCPGOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BC9 RID: 76745 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool INHOEMCLAAP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BCA RID: 76746 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x06012BCB RID: 76747 RVA: 0x0068347C File Offset: 0x0068167C
		internal bool AGFDCBCBAGI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.IPIOPNOHDOB.name;
		}

		// Token: 0x040020EA RID: 8426
		internal GameObject IPIOPNOHDOB;
	}
}
