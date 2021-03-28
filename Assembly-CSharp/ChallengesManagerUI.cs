using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200038A RID: 906
public class ChallengesManagerUI : Singleton<ChallengesManagerUI>
{
	// Token: 0x0600C976 RID: 51574 RVA: 0x0048FB65 File Offset: 0x0048DD65
	public void LLEHKGIHFJL()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(this.canvas, true, null, true, 1349f, true));
	}

	// Token: 0x0600C977 RID: 51575 RVA: 0x0048FB90 File Offset: 0x0048DD90
	public IEnumerator LLLKLEDFGAI(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		GameObject gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (Challenge bfllkfppaab in Singleton<ChallengesManager>.Instance.challengesList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C978 RID: 51576 RVA: 0x0048FBB4 File Offset: 0x0048DDB4
	public IEnumerator BBBNFOHPNOE(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C979 RID: 51577 RVA: 0x0048FBD6 File Offset: 0x0048DDD6
	public void FLEILMCOLPH()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(this.canvas, true, null, true, 316f, false));
	}

	// Token: 0x0600C97A RID: 51578 RVA: 0x0048FC00 File Offset: 0x0048DE00
	public IEnumerator KJHGNLNKAIH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C97B RID: 51579 RVA: 0x0048FC22 File Offset: 0x0048DE22
	public void CMPJLDPEGIF()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.CIADGNBMOLN(this.canvas, false, null, true, 621f, true));
	}

	// Token: 0x0600C97C RID: 51580 RVA: 0x0048FC4C File Offset: 0x0048DE4C
	public IEnumerator KOBBDINKNFM(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C97D RID: 51581 RVA: 0x0048FC6E File Offset: 0x0048DE6E
	public void CloseViewer()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, true, 0.2f, true));
	}

	// Token: 0x0600C97E RID: 51582 RVA: 0x0048FC97 File Offset: 0x0048DE97
	public void ACPPEEDNMJF()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.canvas, false, null, false, 1112f, true));
	}

	// Token: 0x0600C97F RID: 51583 RVA: 0x0048FCC0 File Offset: 0x0048DEC0
	public void FBHBAAKFFIK()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(this.canvas, true, null, false, 644f, true));
	}

	// Token: 0x0600C980 RID: 51584 RVA: 0x0048FCE9 File Offset: 0x0048DEE9
	public void CMMJOOGMPOP()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(this.canvas, true, null, true, 1383f, false));
	}

	// Token: 0x0600C981 RID: 51585 RVA: 0x0048FD14 File Offset: 0x0048DF14
	public IEnumerator DOGKEHLLJML(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C982 RID: 51586 RVA: 0x0048FD36 File Offset: 0x0048DF36
	public void PGKLGJABKEA()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(this.canvas, false, null, true, 510f, true));
	}

	// Token: 0x0600C983 RID: 51587 RVA: 0x0048FD5F File Offset: 0x0048DF5F
	public void IAPKKDFOMNF()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(this.canvas, true, null, false, 418f, true));
	}

	// Token: 0x0600C984 RID: 51588 RVA: 0x0048FD88 File Offset: 0x0048DF88
	public IEnumerator FANLNIPGEII(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C985 RID: 51589 RVA: 0x0048FDAC File Offset: 0x0048DFAC
	public IEnumerator NDIIHPKIOMB(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C986 RID: 51590 RVA: 0x0048FDCE File Offset: 0x0048DFCE
	public void JPDGNCDDBEK()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(this.canvas, false, null, true, 972f, false));
	}

	// Token: 0x0600C988 RID: 51592 RVA: 0x0048FE00 File Offset: 0x0048E000
	public IEnumerator NGAONLGGDIA(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C989 RID: 51593 RVA: 0x0048FE24 File Offset: 0x0048E024
	public IEnumerator FLNHFPHNNME(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C98A RID: 51594 RVA: 0x0048FE46 File Offset: 0x0048E046
	public void IKHNDOCFOLN()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.BCOJGDDEDOP(this.canvas, false, null, false, 1607f, true));
	}

	// Token: 0x0600C98B RID: 51595 RVA: 0x0048FE6F File Offset: 0x0048E06F
	public void FOBIAAOHIIC()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(this.canvas, false, null, false, 778f, false));
	}

	// Token: 0x0600C98C RID: 51596 RVA: 0x0048FE98 File Offset: 0x0048E098
	public void PLLPIDFANLI()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(this.canvas, true, null, false, 454f, true));
	}

	// Token: 0x0600C98D RID: 51597 RVA: 0x0048FEC1 File Offset: 0x0048E0C1
	public void HNDBMNLDILD()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.CMFJGHFEKIK(this.canvas, true, null, true, 1053f, true));
	}

	// Token: 0x0600C98E RID: 51598 RVA: 0x0048FEEA File Offset: 0x0048E0EA
	public void EECCLNMPCEO()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(this.canvas, false, null, true, 419f, false));
	}

	// Token: 0x0600C98F RID: 51599 RVA: 0x0048FF13 File Offset: 0x0048E113
	public void EELFFPJDBFB()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(this.canvas, false, null, false, 1604f, false));
	}

	// Token: 0x0600C990 RID: 51600 RVA: 0x0048FF3C File Offset: 0x0048E13C
	public IEnumerator GKGAEBFMJNH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C991 RID: 51601 RVA: 0x0048FF5E File Offset: 0x0048E15E
	public void MKHPBCJBCPN()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(this.canvas, false, null, false, 1865f, true));
	}

	// Token: 0x0600C992 RID: 51602 RVA: 0x0048FF88 File Offset: 0x0048E188
	public IEnumerator FIGPKFLPKMD(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C993 RID: 51603 RVA: 0x0048FFAC File Offset: 0x0048E1AC
	public IEnumerator IDGAGPEPBGO(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C994 RID: 51604 RVA: 0x0048FFD0 File Offset: 0x0048E1D0
	public IEnumerator JFENHAEGOFE(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C995 RID: 51605 RVA: 0x0048FFF4 File Offset: 0x0048E1F4
	public IEnumerator BEOOPPNPBBH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C996 RID: 51606 RVA: 0x00490018 File Offset: 0x0048E218
	public IEnumerator DOHCPHEEGJJ(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C997 RID: 51607 RVA: 0x0049003C File Offset: 0x0048E23C
	public IEnumerator HOPMPKEKJCJ(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C998 RID: 51608 RVA: 0x00490060 File Offset: 0x0048E260
	public IEnumerator NGLEIIHHKCD(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C999 RID: 51609 RVA: 0x00490082 File Offset: 0x0048E282
	public void PKCADFLECKG()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(this.canvas, true, null, false, 800f, false));
	}

	// Token: 0x0600C99A RID: 51610 RVA: 0x004900AC File Offset: 0x0048E2AC
	public IEnumerator HBEIJLIILBF(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C99B RID: 51611 RVA: 0x004900CE File Offset: 0x0048E2CE
	public void APEIHPBLOAG()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(this.canvas, true, null, true, 245f, true));
	}

	// Token: 0x0600C99C RID: 51612 RVA: 0x004900F8 File Offset: 0x0048E2F8
	public IEnumerator AEJKNCLEFNN(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C99D RID: 51613 RVA: 0x0049011C File Offset: 0x0048E31C
	public IEnumerator DisplayViewer(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C99E RID: 51614 RVA: 0x00490140 File Offset: 0x0048E340
	public IEnumerator CKCOJGFHLEO(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C99F RID: 51615 RVA: 0x00490162 File Offset: 0x0048E362
	public void CCHIGMACJKK()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(this.canvas, false, null, true, 231f, true));
	}

	// Token: 0x0600C9A0 RID: 51616 RVA: 0x0049018B File Offset: 0x0048E38B
	public void NNCAKCMEDOJ()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.canvas, false, null, true, 361f, false));
	}

	// Token: 0x0600C9A1 RID: 51617 RVA: 0x004901B4 File Offset: 0x0048E3B4
	public void LFILBMDGBBI()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(this.canvas, false, null, true, 416f, false));
	}

	// Token: 0x0600C9A2 RID: 51618 RVA: 0x004901E0 File Offset: 0x0048E3E0
	public IEnumerator AOMMGOPABDA(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9A3 RID: 51619 RVA: 0x00490204 File Offset: 0x0048E404
	public IEnumerator PHKIFFJAGCL(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9A4 RID: 51620 RVA: 0x00490226 File Offset: 0x0048E426
	public void KOJJMLMCPKP()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(this.canvas, true, null, false, 9f, true));
	}

	// Token: 0x0600C9A5 RID: 51621 RVA: 0x0049024F File Offset: 0x0048E44F
	public void PFPAPFMHBDA()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(this.canvas, true, null, false, 794f, true));
	}

	// Token: 0x0600C9A6 RID: 51622 RVA: 0x00490278 File Offset: 0x0048E478
	public IEnumerator BNECBFNHCDC(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9A7 RID: 51623 RVA: 0x0049029C File Offset: 0x0048E49C
	public IEnumerator BBPIAEALFJJ(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9A8 RID: 51624 RVA: 0x004902C0 File Offset: 0x0048E4C0
	public IEnumerator BNAGMGHHNBN(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9A9 RID: 51625 RVA: 0x004902E4 File Offset: 0x0048E4E4
	public IEnumerator LFOOHBMHLPK(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9AA RID: 51626 RVA: 0x00490306 File Offset: 0x0048E506
	public void PJCFOHKLHEN()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(this.canvas, false, null, false, 600f, false));
	}

	// Token: 0x0600C9AB RID: 51627 RVA: 0x00490330 File Offset: 0x0048E530
	public IEnumerator CKJGAKFFOFA(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9AC RID: 51628 RVA: 0x00490354 File Offset: 0x0048E554
	public IEnumerator CIGLEJADFDL(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9AD RID: 51629 RVA: 0x00490376 File Offset: 0x0048E576
	public void NFLFAKMAGLA()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(this.canvas, true, null, true, 615f, false));
	}

	// Token: 0x0600C9AE RID: 51630 RVA: 0x0049039F File Offset: 0x0048E59F
	public void FGBBFBOBILD()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(this.canvas, true, null, false, 1017f, false));
	}

	// Token: 0x0600C9AF RID: 51631 RVA: 0x004903C8 File Offset: 0x0048E5C8
	public IEnumerator HBNGMMNFCJB(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9B0 RID: 51632 RVA: 0x004903EA File Offset: 0x0048E5EA
	public void EOEOMBKLLPF()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(this.canvas, false, null, true, 267f, false));
	}

	// Token: 0x0600C9B1 RID: 51633 RVA: 0x00490413 File Offset: 0x0048E613
	public void IMJCECEHKHP()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.CIADGNBMOLN(this.canvas, true, null, true, 1203f, true));
	}

	// Token: 0x0600C9B2 RID: 51634 RVA: 0x0049043C File Offset: 0x0048E63C
	public void LIBDIBDAEAK()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, false, null, false, 437f, true));
	}

	// Token: 0x0600C9B3 RID: 51635 RVA: 0x00490465 File Offset: 0x0048E665
	public void LLMBIBPOOBF()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(this.canvas, true, null, true, 268f, true));
	}

	// Token: 0x0600C9B4 RID: 51636 RVA: 0x0049048E File Offset: 0x0048E68E
	public void PKDMAEGEEIH()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(this.canvas, true, null, true, 1204f, false));
	}

	// Token: 0x0600C9B5 RID: 51637 RVA: 0x004904B7 File Offset: 0x0048E6B7
	public void GDGAAAIELPO()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(this.canvas, false, null, true, 400f, true));
	}

	// Token: 0x0600C9B6 RID: 51638 RVA: 0x004904E0 File Offset: 0x0048E6E0
	public IEnumerator IMGADBAGEMK(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9B7 RID: 51639 RVA: 0x00490502 File Offset: 0x0048E702
	public void MIKDILPAOOI()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.BFCOGLHKJLN(this.canvas, true, null, true, 799f, false));
	}

	// Token: 0x0600C9B8 RID: 51640 RVA: 0x0049052C File Offset: 0x0048E72C
	public IEnumerator GGIOHKKJPCG(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9B9 RID: 51641 RVA: 0x0049054E File Offset: 0x0048E74E
	public void AIOEGPBMFIO()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(this.canvas, true, null, false, 1855f, false));
	}

	// Token: 0x0600C9BA RID: 51642 RVA: 0x00490578 File Offset: 0x0048E778
	public IEnumerator JCCPLKDFGIJ(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9BB RID: 51643 RVA: 0x0049059A File Offset: 0x0048E79A
	public void FGDIBNNJCLK()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(this.canvas, true, null, true, 212f, false));
	}

	// Token: 0x0600C9BC RID: 51644 RVA: 0x004905C4 File Offset: 0x0048E7C4
	public IEnumerator PKBBMKOCLKD(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9BD RID: 51645 RVA: 0x004905E8 File Offset: 0x0048E7E8
	public IEnumerator CGNBONFMPGD(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9BE RID: 51646 RVA: 0x0049060A File Offset: 0x0048E80A
	public void JCLAEAEANOO()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(this.canvas, false, null, false, 1703f, false));
	}

	// Token: 0x0600C9BF RID: 51647 RVA: 0x00490634 File Offset: 0x0048E834
	public IEnumerator MFKDDGKHKJH(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9C0 RID: 51648 RVA: 0x00490656 File Offset: 0x0048E856
	public void CJIPCEEFIGP()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(this.canvas, false, null, false, 1053f, true));
	}

	// Token: 0x0600C9C1 RID: 51649 RVA: 0x0049067F File Offset: 0x0048E87F
	public void HOJKDEGKAEB()
	{
		this.NNMBIFEBFGD = true;
		base.StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(this.canvas, false, null, false, 1519f, false));
	}

	// Token: 0x0600C9C2 RID: 51650 RVA: 0x004906A8 File Offset: 0x0048E8A8
	public void FBPHLGIJMEA()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(this.canvas, true, null, false, 820f, false));
	}

	// Token: 0x0600C9C3 RID: 51651 RVA: 0x004906D4 File Offset: 0x0048E8D4
	public IEnumerator DGPPFIHLEML(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0600C9C4 RID: 51652 RVA: 0x004906F6 File Offset: 0x0048E8F6
	public void HOHJLOMIPNG()
	{
		this.NNMBIFEBFGD = false;
		base.StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(this.canvas, false, null, false, 1565f, true));
	}

	// Token: 0x0600C9C5 RID: 51653 RVA: 0x00490720 File Offset: 0x0048E920
	public IEnumerator FIFDFGDINMO(UnityAction KPCNMGBCOLP = null)
	{
		this.NNMBIFEBFGD = true;
		this.buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			this.buttonBack.onClick.RemoveAllListeners();
			this.buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		this.buttonBack.onClick.AddListener(new UnityAction(base.GBKBDKHPLKG));
		gameObject = this.challengeListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		enumerator = Singleton<ChallengesManager>.Instance.challengesList.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Challenge bfllkfppaab = enumerator.Current;
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.challengeListElementPrefab, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<ChallengeListElement>().Init(bfllkfppaab);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		yield return base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.canvas, true, null, true, 0.2f, true));
		yield break;
	}

	// Token: 0x0400176C RID: 5996
	public GameObject canvas;

	// Token: 0x0400176D RID: 5997
	public Text infoText;

	// Token: 0x0400176E RID: 5998
	public Button buttonBack;

	// Token: 0x0400176F RID: 5999
	public GameObject challengeListContent;

	// Token: 0x04001770 RID: 6000
	public GameObject challengeListElementPrefab;

	// Token: 0x04001771 RID: 6001
	private bool NNMBIFEBFGD;
}
