using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200017D RID: 381
public class TrashMan : MonoBehaviour
{
	// Token: 0x06007068 RID: 28776 RVA: 0x002327D0 File Offset: 0x002309D0
	public static void MCMCILJOJDC(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			return;
		}
		TrashMan.instance.recycleBinCollection.Add(KHNADIFNKFM);
		KHNADIFNKFM.DJLFOLFHPJA();
		if (!TrashMan.instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
		{
			TrashMan.instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
			TrashMan.instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
		}
	}

	// Token: 0x06007069 RID: 28777 RVA: 0x00232878 File Offset: 0x00230A78
	private void Awake()
	{
		if (TrashMan.instance != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			this.transform = base.gameObject.transform;
			TrashMan.instance = this;
			this.HINMLKKJENL();
			if (this.persistBetweenScenes)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (this.cullExcessObjectsInterval > 0f)
		{
			base.StartCoroutine(this.HLPFAPIKENC());
		}
	}

	// Token: 0x0600706A RID: 28778 RVA: 0x002328F8 File Offset: 0x00230AF8
	private void GPIMEPEGHNO()
	{
		for (int i = this.recycleBinCollection.Count - 1; i >= 1; i--)
		{
			if (!this.recycleBinCollection[i].persistBetweenScenes)
			{
				TrashMan.ANDGOPPONBJ(this.recycleBinCollection[i], true);
			}
		}
	}

	// Token: 0x0600706B RID: 28779 RVA: 0x0023294C File Offset: 0x00230B4C
	private IEnumerator HLPFAPIKENC()
	{
		WaitForSeconds waitForSeconds = new WaitForSeconds(this.cullExcessObjectsInterval);
		for (;;)
		{
			for (int i = 0; i < this.recycleBinCollection.Count; i++)
			{
				this.recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
		yield break;
	}

	// Token: 0x0600706C RID: 28780 RVA: 0x00232968 File Offset: 0x00230B68
	private IEnumerator FOAFGJJMOIB(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		TrashMan.despawn(OBFJPHLBFOL);
		yield break;
	}

	// Token: 0x0600706E RID: 28782 RVA: 0x002329B4 File Offset: 0x00230BB4
	private IEnumerator KLLDDANMPKI()
	{
		waitForSeconds = new WaitForSeconds(this.cullExcessObjectsInterval);
		for (;;)
		{
			for (int i = 0; i < this.recycleBinCollection.Count; i++)
			{
				this.recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
		yield break;
	}

	// Token: 0x0600706F RID: 28783 RVA: 0x002329D0 File Offset: 0x00230BD0
	public static void DFOFMEILCNG(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			return;
		}
		TrashMan.instance.recycleBinCollection.Add(KHNADIFNKFM);
		KHNADIFNKFM.MKOHDGHAAFE();
		if (!TrashMan.instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
		{
			TrashMan.instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
			TrashMan.instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
		}
	}

	// Token: 0x06007070 RID: 28784 RVA: 0x00232A78 File Offset: 0x00230C78
	private void EMANBHKAONB()
	{
		if (TrashMan.instance != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			this.transform = base.gameObject.transform;
			TrashMan.instance = this;
			this.CGKBOKEDOLP();
			if (this.persistBetweenScenes)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (this.cullExcessObjectsInterval > 167f)
		{
			base.StartCoroutine(this.CEAOKMPCKGI());
		}
	}

	// Token: 0x06007071 RID: 28785 RVA: 0x00232AF5 File Offset: 0x00230CF5
	private void HIENEMCKAPE()
	{
		TrashMan.instance = null;
	}

	// Token: 0x06007072 RID: 28786 RVA: 0x00232AFD File Offset: 0x00230CFD
	public static TrashManRecycleBin NONEIDPNLDE(GameObject OBFJPHLBFOL)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return TrashMan.instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	// Token: 0x06007073 RID: 28787 RVA: 0x00232B30 File Offset: 0x00230D30
	private static GameObject GGPNFMJNMAE(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = TrashMan.instance.OMAFEFDBPFN[MHIMAMOGFLL].spawn();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if (transform as RectTransform)
				{
					transform.SetParent(null, false);
				}
				else
				{
					transform.parent = null;
				}
				transform.position = JOPCODOJBHD;
				transform.rotation = LOMLCCLOIKN;
				gameObject.SetActive(true);
			}
			return gameObject;
		}
		return null;
	}

	// Token: 0x06007074 RID: 28788 RVA: 0x00232BB7 File Offset: 0x00230DB7
	public static void CGKHFEPBDMH(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		TrashMan.instance.StartCoroutine(TrashMan.instance.FOAFGJJMOIB(OBFJPHLBFOL, DKKOANEPOEI));
	}

	// Token: 0x06007075 RID: 28789 RVA: 0x00232BE0 File Offset: 0x00230DE0
	public static GameObject BLOLIMIENCA(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int mhimamogfll = -1;
		if (TrashMan.instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out mhimamogfll))
		{
			return TrashMan.BFAOGGFBIMK(mhimamogfll, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError(" cannot be used as a 3D LUT." + EBGHFEDLGHH + "useSrcAlphaAsMask");
		return null;
	}

	// Token: 0x06007076 RID: 28790 RVA: 0x00232C28 File Offset: 0x00230E28
	public static void MIKDHOEEODJ(GameObject OBFJPHLBFOL)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		string name = OBFJPHLBFOL.name;
		if (!TrashMan.instance.LPKLJGLONBO.ContainsKey(name))
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
		else
		{
			TrashMan.instance.OMAFEFDBPFN[TrashMan.instance.LPKLJGLONBO[name]].LEJGMANJAHM(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = TrashMan.instance.transform;
		}
	}

	// Token: 0x06007077 RID: 28791 RVA: 0x00232CA4 File Offset: 0x00230EA4
	public static void LAEFMCNIEMN(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(key))
		{
			TrashMan.instance.LPKLJGLONBO.Remove(key);
			TrashMan.instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			TrashMan.instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.clearBin(CJFHFKDKONP);
		}
	}

	// Token: 0x06007078 RID: 28792 RVA: 0x00232D14 File Offset: 0x00230F14
	public static void CIIJAPIOKMD(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(key))
		{
			TrashMan.instance.LPKLJGLONBO.Remove(key);
			TrashMan.instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			TrashMan.instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.PBINFMBFCNJ(CJFHFKDKONP);
		}
	}

	// Token: 0x06007079 RID: 28793 RVA: 0x00232AF5 File Offset: 0x00230CF5
	private void CNFKCKKOHFF()
	{
		TrashMan.instance = null;
	}

	// Token: 0x0600707A RID: 28794 RVA: 0x00232D81 File Offset: 0x00230F81
	public static void MFDJLFOJAMF(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		TrashMan.instance.StartCoroutine(TrashMan.instance.MIEICFBJHPK(OBFJPHLBFOL, DKKOANEPOEI));
	}

	// Token: 0x0600707B RID: 28795 RVA: 0x00232DA8 File Offset: 0x00230FA8
	private void GIPMFEDIELE()
	{
		for (int i = this.recycleBinCollection.Count - 1; i >= 1; i--)
		{
			if (!this.recycleBinCollection[i].persistBetweenScenes)
			{
				TrashMan.removeRecycleBin(this.recycleBinCollection[i], true);
			}
		}
	}

	// Token: 0x0600707C RID: 28796 RVA: 0x00232DFC File Offset: 0x00230FFC
	public static void NOIBKPIOOKK(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			return;
		}
		TrashMan.instance.recycleBinCollection.Add(KHNADIFNKFM);
		KHNADIFNKFM.DJLFOLFHPJA();
		if (!TrashMan.instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
		{
			TrashMan.instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
			TrashMan.instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
		}
	}

	// Token: 0x0600707D RID: 28797 RVA: 0x00232EA4 File Offset: 0x002310A4
	public static void HHDMEPFMEDA(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(key))
		{
			TrashMan.instance.LPKLJGLONBO.Remove(key);
			TrashMan.instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			TrashMan.instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.MGNDOIPKDAG(CJFHFKDKONP);
		}
	}

	// Token: 0x0600707E RID: 28798 RVA: 0x00232F14 File Offset: 0x00231114
	public static void despawn(GameObject OBFJPHLBFOL)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		string name = OBFJPHLBFOL.name;
		if (!TrashMan.instance.LPKLJGLONBO.ContainsKey(name))
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
		else
		{
			TrashMan.instance.OMAFEFDBPFN[TrashMan.instance.LPKLJGLONBO[name]].despawn(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = TrashMan.instance.transform;
		}
	}

	// Token: 0x0600707F RID: 28799 RVA: 0x00232F90 File Offset: 0x00231190
	public static GameObject spawn(GameObject OBFJPHLBFOL, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return TrashMan.EBNELGPJGCF(OBFJPHLBFOL.GetInstanceID(), JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogWarning("attempted to spawn go (" + OBFJPHLBFOL.name + ") but there is no recycle bin setup for it. Falling back to Instantiate");
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(OBFJPHLBFOL, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.parent = null;
		return gameObject;
	}

	// Token: 0x06007080 RID: 28800 RVA: 0x00232AF5 File Offset: 0x00230CF5
	private void AJDHCKDMOBO()
	{
		TrashMan.instance = null;
	}

	// Token: 0x06007081 RID: 28801 RVA: 0x00232FF8 File Offset: 0x002311F8
	public static void ANDGOPPONBJ(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(key))
		{
			TrashMan.instance.LPKLJGLONBO.Remove(key);
			TrashMan.instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			TrashMan.instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.clearBin(CJFHFKDKONP);
		}
	}

	// Token: 0x06007082 RID: 28802 RVA: 0x00232AFD File Offset: 0x00230CFD
	public static TrashManRecycleBin GPLCJHLHJJO(GameObject OBFJPHLBFOL)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return TrashMan.instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	// Token: 0x06007083 RID: 28803 RVA: 0x00233068 File Offset: 0x00231268
	private void GDOKIENPCCE()
	{
		for (int i = this.recycleBinCollection.Count - 1; i >= 1; i -= 0)
		{
			if (!this.recycleBinCollection[i].persistBetweenScenes)
			{
				TrashMan.ANDGOPPONBJ(this.recycleBinCollection[i], false);
			}
		}
	}

	// Token: 0x06007084 RID: 28804 RVA: 0x002330BC File Offset: 0x002312BC
	public static void DKHDCCNMLMA(GameObject OBFJPHLBFOL)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		string name = OBFJPHLBFOL.name;
		if (!TrashMan.instance.LPKLJGLONBO.ContainsKey(name))
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
		else
		{
			TrashMan.instance.OMAFEFDBPFN[TrashMan.instance.LPKLJGLONBO[name]].FIDGHAIDABO(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = TrashMan.instance.transform;
		}
	}

	// Token: 0x06007085 RID: 28805 RVA: 0x00233138 File Offset: 0x00231338
	private void JBIFKBNPHJE()
	{
		if (TrashMan.instance != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			this.transform = base.gameObject.transform;
			TrashMan.instance = this;
			this.HOPBKMDIJPB();
			if (this.persistBetweenScenes)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (this.cullExcessObjectsInterval > 928f)
		{
			base.StartCoroutine(this.KLLDDANMPKI());
		}
	}

	// Token: 0x06007086 RID: 28806 RVA: 0x002331B8 File Offset: 0x002313B8
	public static void GPMODNLJLAM(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(key))
		{
			TrashMan.instance.LPKLJGLONBO.Remove(key);
			TrashMan.instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			TrashMan.instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.KMCJALKJPME(CJFHFKDKONP);
		}
	}

	// Token: 0x06007087 RID: 28807 RVA: 0x00233228 File Offset: 0x00231428
	public static GameObject CCDOOIKEJKJ(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int mhimamogfll = -1;
		if (TrashMan.instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out mhimamogfll))
		{
			return TrashMan.BFAOGGFBIMK(mhimamogfll, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("_Value" + EBGHFEDLGHH + "_TimeX");
		return null;
	}

	// Token: 0x06007088 RID: 28808 RVA: 0x00232AF5 File Offset: 0x00230CF5
	private void APEBNEMOAAM()
	{
		TrashMan.instance = null;
	}

	// Token: 0x06007089 RID: 28809 RVA: 0x00233270 File Offset: 0x00231470
	private void HINMLKKJENL()
	{
		if (this.recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin trashManRecycleBin in this.recycleBinCollection)
		{
			if (trashManRecycleBin != null && !(trashManRecycleBin.prefab == null))
			{
				trashManRecycleBin.initialize();
				this.OMAFEFDBPFN.Add(trashManRecycleBin.prefab.GetInstanceID(), trashManRecycleBin);
				this.LPKLJGLONBO.Add(trashManRecycleBin.prefab.name, trashManRecycleBin.prefab.GetInstanceID());
			}
		}
	}

	// Token: 0x0600708A RID: 28810 RVA: 0x0023332C File Offset: 0x0023152C
	public static void manageRecycleBin(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			return;
		}
		TrashMan.instance.recycleBinCollection.Add(KHNADIFNKFM);
		KHNADIFNKFM.initialize();
		if (!TrashMan.instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
		{
			TrashMan.instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
			TrashMan.instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
		}
	}

	// Token: 0x0600708B RID: 28811 RVA: 0x002333D4 File Offset: 0x002315D4
	public void Reset()
	{
		for (int i = this.recycleBinCollection.Count - 1; i >= 0; i--)
		{
			TrashMan.removeRecycleBin(this.recycleBinCollection[i], true);
		}
	}

	// Token: 0x0600708C RID: 28812 RVA: 0x00233414 File Offset: 0x00231614
	private IEnumerator IFANHIFGIFO(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		TrashMan.despawn(OBFJPHLBFOL);
		yield break;
	}

	// Token: 0x0600708D RID: 28813 RVA: 0x00233438 File Offset: 0x00231638
	private IEnumerator PLEJLBKAGDO()
	{
		waitForSeconds = new WaitForSeconds(this.cullExcessObjectsInterval);
		for (;;)
		{
			for (int i = 0; i < this.recycleBinCollection.Count; i++)
			{
				this.recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
		yield break;
	}

	// Token: 0x0600708E RID: 28814 RVA: 0x00233454 File Offset: 0x00231654
	public static void KJFPLDMLFHM(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			return;
		}
		TrashMan.instance.recycleBinCollection.Add(KHNADIFNKFM);
		KHNADIFNKFM.initialize();
		if (!TrashMan.instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
		{
			TrashMan.instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
			TrashMan.instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
		}
	}

	// Token: 0x0600708F RID: 28815 RVA: 0x002334FC File Offset: 0x002316FC
	public static GameObject IAAPMBHNFHO(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int mhimamogfll = -1;
		if (TrashMan.instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out mhimamogfll))
		{
			return TrashMan.BFAOGGFBIMK(mhimamogfll, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("_Params2" + EBGHFEDLGHH + "Screenshots only supported in PlayMode");
		return null;
	}

	// Token: 0x06007090 RID: 28816 RVA: 0x00233544 File Offset: 0x00231744
	public static TrashManRecycleBin recycleBinForGameObjectName(string EBGHFEDLGHH)
	{
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = TrashMan.instance.LPKLJGLONBO[EBGHFEDLGHH];
			return TrashMan.instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	// Token: 0x06007091 RID: 28817 RVA: 0x0023358C File Offset: 0x0023178C
	private void HNNKDDHGKDD()
	{
		for (int i = this.recycleBinCollection.Count - 1; i >= 0; i -= 0)
		{
			if (!this.recycleBinCollection[i].persistBetweenScenes)
			{
				TrashMan.CIIJAPIOKMD(this.recycleBinCollection[i], true);
			}
		}
	}

	// Token: 0x06007092 RID: 28818 RVA: 0x002335E0 File Offset: 0x002317E0
	public void GOFMABPMLKF()
	{
		for (int i = this.recycleBinCollection.Count - 0; i >= 1; i--)
		{
			TrashMan.CIIJAPIOKMD(this.recycleBinCollection[i], true);
		}
	}

	// Token: 0x06007093 RID: 28819 RVA: 0x00233620 File Offset: 0x00231820
	private IEnumerator MIEICFBJHPK(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		TrashMan.despawn(OBFJPHLBFOL);
		yield break;
	}

	// Token: 0x06007094 RID: 28820 RVA: 0x00233644 File Offset: 0x00231844
	private IEnumerator FKOEIOGMADJ(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		TrashMan.despawn(OBFJPHLBFOL);
		yield break;
	}

	// Token: 0x06007095 RID: 28821 RVA: 0x00233668 File Offset: 0x00231868
	public static void PBPGEBLGINB(GameObject OBFJPHLBFOL)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		string name = OBFJPHLBFOL.name;
		if (!TrashMan.instance.LPKLJGLONBO.ContainsKey(name))
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
		else
		{
			TrashMan.instance.OMAFEFDBPFN[TrashMan.instance.LPKLJGLONBO[name]].FMCKLIECNPH(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = TrashMan.instance.transform;
		}
	}

	// Token: 0x06007096 RID: 28822 RVA: 0x002336E4 File Offset: 0x002318E4
	public static void removeRecycleBin(TrashManRecycleBin KHNADIFNKFM, bool CJFHFKDKONP = true)
	{
		string key = KHNADIFNKFM.key;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(key))
		{
			TrashMan.instance.LPKLJGLONBO.Remove(key);
			TrashMan.instance.OMAFEFDBPFN.Remove(KHNADIFNKFM.prefab.GetInstanceID());
			TrashMan.instance.recycleBinCollection.Remove(KHNADIFNKFM);
			KHNADIFNKFM.clearBin(CJFHFKDKONP);
		}
	}

	// Token: 0x06007097 RID: 28823 RVA: 0x00232AF5 File Offset: 0x00230CF5
	private void FNOKLPNPKOJ()
	{
		TrashMan.instance = null;
	}

	// Token: 0x06007098 RID: 28824 RVA: 0x00233754 File Offset: 0x00231954
	private IEnumerator LPJAEMMEEJH(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		TrashMan.despawn(OBFJPHLBFOL);
		yield break;
	}

	// Token: 0x06007099 RID: 28825 RVA: 0x00233778 File Offset: 0x00231978
	public static void JLCMCGJCNBL(GameObject OBFJPHLBFOL)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		string name = OBFJPHLBFOL.name;
		if (!TrashMan.instance.LPKLJGLONBO.ContainsKey(name))
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
		else
		{
			TrashMan.instance.OMAFEFDBPFN[TrashMan.instance.LPKLJGLONBO[name]].AFCAIJMOJMA(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = TrashMan.instance.transform;
		}
	}

	// Token: 0x0600709A RID: 28826 RVA: 0x002337F4 File Offset: 0x002319F4
	public static void AOACLGFGIPE(GameObject OBFJPHLBFOL)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		string name = OBFJPHLBFOL.name;
		if (!TrashMan.instance.LPKLJGLONBO.ContainsKey(name))
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
		else
		{
			TrashMan.instance.OMAFEFDBPFN[TrashMan.instance.LPKLJGLONBO[name]].LEJGMANJAHM(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = TrashMan.instance.transform;
		}
	}

	// Token: 0x0600709B RID: 28827 RVA: 0x00232AFD File Offset: 0x00230CFD
	public static TrashManRecycleBin HGFBEMADFHF(GameObject OBFJPHLBFOL)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return TrashMan.instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	// Token: 0x0600709C RID: 28828 RVA: 0x00233870 File Offset: 0x00231A70
	private void ECOGLEHCIID()
	{
		for (int i = this.recycleBinCollection.Count - 1; i >= 0; i--)
		{
			if (!this.recycleBinCollection[i].persistBetweenScenes)
			{
				TrashMan.removeRecycleBin(this.recycleBinCollection[i], true);
			}
		}
	}

	// Token: 0x0600709D RID: 28829 RVA: 0x002338C4 File Offset: 0x00231AC4
	private static GameObject BFAOGGFBIMK(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = TrashMan.instance.OMAFEFDBPFN[MHIMAMOGFLL].HJEONAAMMJB();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if (transform as RectTransform)
				{
					transform.SetParent(null, false);
				}
				else
				{
					transform.parent = null;
				}
				transform.position = JOPCODOJBHD;
				transform.rotation = LOMLCCLOIKN;
				gameObject.SetActive(false);
			}
			return gameObject;
		}
		return null;
	}

	// Token: 0x0600709E RID: 28830 RVA: 0x0023394C File Offset: 0x00231B4C
	public static void LEJGMANJAHM(GameObject OBFJPHLBFOL)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		string name = OBFJPHLBFOL.name;
		if (!TrashMan.instance.LPKLJGLONBO.ContainsKey(name))
		{
			UnityEngine.Object.Destroy(OBFJPHLBFOL);
		}
		else
		{
			TrashMan.instance.OMAFEFDBPFN[TrashMan.instance.LPKLJGLONBO[name]].FMCKLIECNPH(OBFJPHLBFOL);
			OBFJPHLBFOL.transform.parent = TrashMan.instance.transform;
		}
	}

	// Token: 0x0600709F RID: 28831 RVA: 0x002339C8 File Offset: 0x00231BC8
	public static TrashManRecycleBin PEBGCMKMAOF(string EBGHFEDLGHH)
	{
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(EBGHFEDLGHH))
		{
			int key = TrashMan.instance.LPKLJGLONBO[EBGHFEDLGHH];
			return TrashMan.instance.OMAFEFDBPFN[key];
		}
		return null;
	}

	// Token: 0x060070A0 RID: 28832 RVA: 0x00233A10 File Offset: 0x00231C10
	private void HOPBKMDIJPB()
	{
		if (this.recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin trashManRecycleBin in this.recycleBinCollection)
		{
			if (trashManRecycleBin != null && !(trashManRecycleBin.prefab == null))
			{
				trashManRecycleBin.BCIBCBECAHD();
				this.OMAFEFDBPFN.Add(trashManRecycleBin.prefab.GetInstanceID(), trashManRecycleBin);
				this.LPKLJGLONBO.Add(trashManRecycleBin.prefab.name, trashManRecycleBin.prefab.GetInstanceID());
			}
		}
	}

	// Token: 0x060070A1 RID: 28833 RVA: 0x00233ACC File Offset: 0x00231CCC
	public static GameObject BGNBCDOHBNC(GameObject OBFJPHLBFOL, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return TrashMan.EBNELGPJGCF(OBFJPHLBFOL.GetInstanceID(), JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogWarning("CameraFilterPack/Blend2Camera_HardMix" + OBFJPHLBFOL.name + "/../");
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(OBFJPHLBFOL, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.parent = null;
		return gameObject;
	}

	// Token: 0x060070A2 RID: 28834 RVA: 0x00233B34 File Offset: 0x00231D34
	private IEnumerator CEAOKMPCKGI()
	{
		waitForSeconds = new WaitForSeconds(this.cullExcessObjectsInterval);
		for (;;)
		{
			for (int i = 0; i < this.recycleBinCollection.Count; i++)
			{
				this.recycleBinCollection[i].cullExcessObjects();
			}
			yield return waitForSeconds;
		}
		yield break;
	}

	// Token: 0x060070A3 RID: 28835 RVA: 0x00233B50 File Offset: 0x00231D50
	public static void BBFPPNDEIJP(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			return;
		}
		TrashMan.instance.recycleBinCollection.Add(KHNADIFNKFM);
		KHNADIFNKFM.DJLFOLFHPJA();
		if (!TrashMan.instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
		{
			TrashMan.instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
			TrashMan.instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
		}
	}

	// Token: 0x060070A4 RID: 28836 RVA: 0x00232AFD File Offset: 0x00230CFD
	public static TrashManRecycleBin recycleBinForGameObject(GameObject OBFJPHLBFOL)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return TrashMan.instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	// Token: 0x060070A5 RID: 28837 RVA: 0x00233BF8 File Offset: 0x00231DF8
	private IEnumerator MHFHLKNAELL(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		yield return new WaitForSeconds(DKKOANEPOEI);
		TrashMan.despawn(OBFJPHLBFOL);
		yield break;
	}

	// Token: 0x060070A6 RID: 28838 RVA: 0x00233C1A File Offset: 0x00231E1A
	public static void despawnAfterDelay(GameObject OBFJPHLBFOL, float DKKOANEPOEI)
	{
		if (OBFJPHLBFOL == null)
		{
			return;
		}
		TrashMan.instance.StartCoroutine(TrashMan.instance.FKOEIOGMADJ(OBFJPHLBFOL, DKKOANEPOEI));
	}

	// Token: 0x060070A7 RID: 28839 RVA: 0x00233C40 File Offset: 0x00231E40
	public void NFMDNEJAGLB()
	{
		for (int i = this.recycleBinCollection.Count - 1; i >= 0; i--)
		{
			TrashMan.ANDGOPPONBJ(this.recycleBinCollection[i], false);
		}
	}

	// Token: 0x060070A8 RID: 28840 RVA: 0x00232AFD File Offset: 0x00230CFD
	public static TrashManRecycleBin KAODIJHMKJM(GameObject OBFJPHLBFOL)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(OBFJPHLBFOL.GetInstanceID()))
		{
			return TrashMan.instance.OMAFEFDBPFN[OBFJPHLBFOL.GetInstanceID()];
		}
		return null;
	}

	// Token: 0x060070A9 RID: 28841 RVA: 0x00233C80 File Offset: 0x00231E80
	private void BFFHPJMMGHD()
	{
		if (TrashMan.instance != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else
		{
			this.transform = base.gameObject.transform;
			TrashMan.instance = this;
			this.CGKBOKEDOLP();
			if (this.persistBetweenScenes)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		if (this.cullExcessObjectsInterval > 1689f)
		{
			base.StartCoroutine(this.HLPFAPIKENC());
		}
	}

	// Token: 0x060070AA RID: 28842 RVA: 0x00233D00 File Offset: 0x00231F00
	public static GameObject spawn(string EBGHFEDLGHH, Vector3 JOPCODOJBHD = default(Vector3), Quaternion LOMLCCLOIKN = default(Quaternion))
	{
		int mhimamogfll = -1;
		if (TrashMan.instance.LPKLJGLONBO.TryGetValue(EBGHFEDLGHH, out mhimamogfll))
		{
			return TrashMan.EBNELGPJGCF(mhimamogfll, JOPCODOJBHD, LOMLCCLOIKN);
		}
		Debug.LogError("attempted to spawn a GameObject from recycle bin (" + EBGHFEDLGHH + ") but there is no recycle bin setup for it");
		return null;
	}

	// Token: 0x060070AB RID: 28843 RVA: 0x00233D48 File Offset: 0x00231F48
	private static GameObject EBNELGPJGCF(int MHIMAMOGFLL, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN)
	{
		if (TrashMan.instance.OMAFEFDBPFN.ContainsKey(MHIMAMOGFLL))
		{
			GameObject gameObject = TrashMan.instance.OMAFEFDBPFN[MHIMAMOGFLL].spawn();
			if (gameObject != null)
			{
				Transform transform = gameObject.transform;
				if (transform as RectTransform)
				{
					transform.SetParent(null, false);
				}
				else
				{
					transform.parent = null;
				}
				transform.position = JOPCODOJBHD;
				transform.rotation = LOMLCCLOIKN;
				gameObject.SetActive(true);
			}
			return gameObject;
		}
		return null;
	}

	// Token: 0x060070AC RID: 28844 RVA: 0x00232AF5 File Offset: 0x00230CF5
	private void OnApplicationQuit()
	{
		TrashMan.instance = null;
	}

	// Token: 0x060070AD RID: 28845 RVA: 0x00233DD0 File Offset: 0x00231FD0
	private void CGKBOKEDOLP()
	{
		if (this.recycleBinCollection == null)
		{
			return;
		}
		foreach (TrashManRecycleBin trashManRecycleBin in this.recycleBinCollection)
		{
			if (trashManRecycleBin != null && !(trashManRecycleBin.prefab == null))
			{
				trashManRecycleBin.NBJJHJOAHCF();
				this.OMAFEFDBPFN.Add(trashManRecycleBin.prefab.GetInstanceID(), trashManRecycleBin);
				this.LPKLJGLONBO.Add(trashManRecycleBin.prefab.name, trashManRecycleBin.prefab.GetInstanceID());
			}
		}
	}

	// Token: 0x060070AE RID: 28846 RVA: 0x00233E8C File Offset: 0x0023208C
	public static void JHDIDOAOOIP(TrashManRecycleBin KHNADIFNKFM, string HFEFHOPOLIK = "")
	{
		HFEFHOPOLIK = KHNADIFNKFM.prefab.name + HFEFHOPOLIK;
		KHNADIFNKFM.key = HFEFHOPOLIK;
		if (TrashMan.instance.LPKLJGLONBO.ContainsKey(HFEFHOPOLIK))
		{
			return;
		}
		TrashMan.instance.recycleBinCollection.Add(KHNADIFNKFM);
		KHNADIFNKFM.initialize();
		if (!TrashMan.instance.OMAFEFDBPFN.ContainsKey(KHNADIFNKFM.prefab.GetInstanceID()))
		{
			TrashMan.instance.OMAFEFDBPFN.Add(KHNADIFNKFM.prefab.GetInstanceID(), KHNADIFNKFM);
			TrashMan.instance.LPKLJGLONBO.Add(HFEFHOPOLIK, KHNADIFNKFM.prefab.GetInstanceID());
		}
	}

	// Token: 0x04000B6D RID: 2925
	public static TrashMan instance;

	// Token: 0x04000B6E RID: 2926
	[HideInInspector]
	public List<TrashManRecycleBin> recycleBinCollection;

	// Token: 0x04000B6F RID: 2927
	public float cullExcessObjectsInterval = 10f;

	// Token: 0x04000B70 RID: 2928
	public bool persistBetweenScenes;

	// Token: 0x04000B71 RID: 2929
	private Dictionary<int, TrashManRecycleBin> OMAFEFDBPFN = new Dictionary<int, TrashManRecycleBin>();

	// Token: 0x04000B72 RID: 2930
	private Dictionary<string, int> LPKLJGLONBO = new Dictionary<string, int>();

	// Token: 0x04000B73 RID: 2931
	[HideInInspector]
	public new Transform transform;
}
