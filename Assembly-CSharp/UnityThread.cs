using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000477 RID: 1143
public class UnityThread : MonoBehaviour
{
	// Token: 0x060106AB RID: 67243 RVA: 0x00594B28 File Offset: 0x00592D28
	public void POIMNOBDBBN()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = false;
		}
		for (int i = 1; i < this.DIFHBHMJHFJ.Count; i += 0)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x060106AC RID: 67244 RVA: 0x00594BC4 File Offset: 0x00592DC4
	public static void executeInUpdate(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("action");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = false;
		}
	}

	// Token: 0x060106AD RID: 67245 RVA: 0x00594C20 File Offset: 0x00592E20
	public void ODAIMOJLJOF()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106AE RID: 67246 RVA: 0x00594C38 File Offset: 0x00592E38
	public void HEHOKHLEDAL()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = true;
		}
		for (int i = 1; i < this.DLFAHDLMGAI.Count; i += 0)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x060106AF RID: 67247 RVA: 0x00594CD4 File Offset: 0x00592ED4
	public void FixedUpdate()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = true;
		}
		for (int i = 0; i < this.DLFAHDLMGAI.Count; i++)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x060106B0 RID: 67248 RVA: 0x00594D70 File Offset: 0x00592F70
	public static void BIKMBJAKNMC(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.GIGIMBEMFLA(new Action(adjaiffpidj.EGKGJJGAPMN));
		}
	}

	// Token: 0x060106B1 RID: 67249 RVA: 0x00594DAC File Offset: 0x00592FAC
	public static void IMGOAPIKJON(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("PLEASE WAIT");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106B2 RID: 67250 RVA: 0x00594E00 File Offset: 0x00593000
	public static void DEEMJDDNCHP(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("Failed to InstantiateSceneObject prefab: ");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106B3 RID: 67251 RVA: 0x00594E54 File Offset: 0x00593054
	public static void KEBMIJANMJO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_ScreenResolution");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = false;
		}
	}

	// Token: 0x060106B4 RID: 67252 RVA: 0x00594EB0 File Offset: 0x005930B0
	public void FABMDEHEDNO()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = true;
		}
		for (int i = 0; i < this.DIFHBHMJHFJ.Count; i++)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x060106B5 RID: 67253 RVA: 0x00594F4C File Offset: 0x0059314C
	public static void EKONJNOCDLM(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_Speed");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106B6 RID: 67254 RVA: 0x00594FA0 File Offset: 0x005931A0
	public void FGLFIBLBGOM()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = true;
		}
		for (int i = 1; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x060106B7 RID: 67255 RVA: 0x0059503C File Offset: 0x0059323C
	public void Update()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = true;
		}
		for (int i = 0; i < this.DIFHBHMJHFJ.Count; i++)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x060106B8 RID: 67256 RVA: 0x005950D8 File Offset: 0x005932D8
	public static void BMIFHOOCDPL(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.MANOGNAIFFP(new Action(adjaiffpidj.EGKGJJGAPMN));
		}
	}

	// Token: 0x060106B9 RID: 67257 RVA: 0x00595114 File Offset: 0x00593314
	public static void EODPGFNJDJH(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_BorderColor");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)(-118);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106BA RID: 67258 RVA: 0x00595168 File Offset: 0x00593368
	public void APMCMFKPPNE()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = false;
		}
		for (int i = 0; i < this.DLFAHDLMGAI.Count; i += 0)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x060106BB RID: 67259 RVA: 0x00595204 File Offset: 0x00593404
	public static void GGBPLBDLHGK(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_Value3");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~HideFlags.DontSaveInBuild;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106BC RID: 67260 RVA: 0x00595258 File Offset: 0x00593458
	public void DONMAICHHFK()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = false;
		}
		for (int i = 1; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x060106BD RID: 67261 RVA: 0x005952F4 File Offset: 0x005934F4
	public static void BPJOCHBNOFI(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException(" Loaded: ");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = true;
		}
	}

	// Token: 0x060106BE RID: 67262 RVA: 0x00595350 File Offset: 0x00593550
	public static void IEMFGLPHHGG(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("skin.");
		}
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			UnityThread.FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			UnityThread.LOFNLIACCDM = false;
		}
	}

	// Token: 0x060106BF RID: 67263 RVA: 0x005953AC File Offset: 0x005935AC
	public static void EJCFMPEGKGO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("#close");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = false;
		}
	}

	// Token: 0x060106C0 RID: 67264 RVA: 0x00595408 File Offset: 0x00593608
	public static void BMJKLKEMIGJ(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("#,0.00");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106C1 RID: 67265 RVA: 0x00595464 File Offset: 0x00593664
	public void DHNANELONED()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060106C2 RID: 67266 RVA: 0x00595474 File Offset: 0x00593674
	public static void LGHEJJFGGAN(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_LightIntensity");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = false;
		}
	}

	// Token: 0x060106C3 RID: 67267 RVA: 0x005954D0 File Offset: 0x005936D0
	public static void initUnityThread(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("MainThreadExecuter");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = HideFlags.HideAndDontSave;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106C4 RID: 67268 RVA: 0x00595524 File Offset: 0x00593724
	public static void LDMNKCJCFGA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("y");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = false;
		}
	}

	// Token: 0x060106C5 RID: 67269 RVA: 0x00595580 File Offset: 0x00593780
	public void LCDJFJIBADI()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = false;
		}
		for (int i = 0; i < this.DIFHBHMJHFJ.Count; i++)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x060106C6 RID: 67270 RVA: 0x0059561C File Offset: 0x0059381C
	public static void KJGMIENLHCO(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.KEBMIJANMJO(new Action(adjaiffpidj.FHFECFLBHMA));
		}
	}

	// Token: 0x060106C7 RID: 67271 RVA: 0x00595658 File Offset: 0x00593858
	public void KNMHJOPHALM()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = true;
		}
		for (int i = 1; i < this.DLFAHDLMGAI.Count; i++)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x060106C8 RID: 67272 RVA: 0x005956F4 File Offset: 0x005938F4
	public static void PAANFNKJMGP(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("https://vk.com/khb.soft");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = false;
		}
	}

	// Token: 0x060106C9 RID: 67273 RVA: 0x00595750 File Offset: 0x00593950
	public void FOLDLDLFFLM()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = false;
		}
		for (int i = 0; i < this.DIFHBHMJHFJ.Count; i += 0)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x060106CA RID: 67274 RVA: 0x005957EC File Offset: 0x005939EC
	public static void OJGBGHJPNKE(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_NumberOfWaves");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106CB RID: 67275 RVA: 0x00595840 File Offset: 0x00593A40
	public void MBKLLICJBDM()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = false;
		}
		for (int i = 0; i < this.IPAENCDKHNN.Count; i += 0)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x060106CC RID: 67276 RVA: 0x005958DC File Offset: 0x00593ADC
	public static void BJDOBCAOKBO(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.HMGGGFHGEBJ(new Action(adjaiffpidj.MGENGAEDACG));
		}
	}

	// Token: 0x060106CD RID: 67277 RVA: 0x00595918 File Offset: 0x00593B18
	public static void LOONCHEGHLP(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.NKAJGELBEML(new Action(adjaiffpidj.JKEDCEOCPJO));
		}
	}

	// Token: 0x060106CE RID: 67278 RVA: 0x00595954 File Offset: 0x00593B54
	public static void HADIBLEDGEA(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("CameraFilterPack/Glasses_On");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)(-111);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106CF RID: 67279 RVA: 0x005959A8 File Offset: 0x00593BA8
	public static void CEJKFJDKFMO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Joystick1Button4");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = false;
		}
	}

	// Token: 0x060106D0 RID: 67280 RVA: 0x00594C20 File Offset: 0x00592E20
	public void FODKODGPPDA()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106D1 RID: 67281 RVA: 0x00594C20 File Offset: 0x00592E20
	public void PLBOFEPBPKC()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106D2 RID: 67282 RVA: 0x00595A04 File Offset: 0x00593C04
	public void MIGFKFBOBDK()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = true;
		}
		for (int i = 0; i < this.DLFAHDLMGAI.Count; i++)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x060106D3 RID: 67283 RVA: 0x00595AA0 File Offset: 0x00593CA0
	public static void HKONJMJNPFL(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject(".played");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~HideFlags.DontSaveInBuild;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106D4 RID: 67284 RVA: 0x00595AF4 File Offset: 0x00593CF4
	public static void LMNHPENKGHO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException(".lastCheckpoint.incorrectScore");
		}
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			UnityThread.FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			UnityThread.LOFNLIACCDM = true;
		}
	}

	// Token: 0x060106D5 RID: 67285 RVA: 0x00595B50 File Offset: 0x00593D50
	public static void executeInLateUpdate(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("action");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = false;
		}
	}

	// Token: 0x060106D6 RID: 67286 RVA: 0x00595BAC File Offset: 0x00593DAC
	public static void OENILFLFJJI(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_ScreenResolution");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106D7 RID: 67287 RVA: 0x00595C08 File Offset: 0x00593E08
	public static void GIGIMBEMFLA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106D8 RID: 67288 RVA: 0x00595C64 File Offset: 0x00593E64
	public static void PHEHBJECONL(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Player Connected");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106D9 RID: 67289 RVA: 0x00595CC0 File Offset: 0x00593EC0
	public void AJPHCPCLOJD()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = true;
		}
		for (int i = 1; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x060106DA RID: 67290 RVA: 0x00595D5C File Offset: 0x00593F5C
	public static void OGGKKLMEBMN(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.LGHEJJFGGAN(new Action(adjaiffpidj.BKNHHGBPLGH));
		}
	}

	// Token: 0x060106DB RID: 67291 RVA: 0x00595D98 File Offset: 0x00593F98
	public static void BKHHLIBLFHB(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("player.ice");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106DC RID: 67292 RVA: 0x00595DEC File Offset: 0x00593FEC
	public static void OKGFBCCAHBH(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Item ");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = true;
		}
	}

	// Token: 0x060106DD RID: 67293 RVA: 0x00595E48 File Offset: 0x00594048
	public static void EINFPFNFKHA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("maps.");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = false;
		}
	}

	// Token: 0x060106DE RID: 67294 RVA: 0x00595EA4 File Offset: 0x005940A4
	public void IKIDIJLIGOH()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = true;
		}
		for (int i = 0; i < this.DIFHBHMJHFJ.Count; i++)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x060106DF RID: 67295 RVA: 0x00595464 File Offset: 0x00593664
	public void GOBHPAJFFDB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060106E0 RID: 67296 RVA: 0x00595F40 File Offset: 0x00594140
	public static void AJDGCOLEAEM(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("maps.");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = false;
		}
	}

	// Token: 0x060106E1 RID: 67297 RVA: 0x00595F9C File Offset: 0x0059419C
	public void GEHMIFICFCF()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = true;
		}
		for (int i = 0; i < this.IPAENCDKHNN.Count; i += 0)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x060106E2 RID: 67298 RVA: 0x00596038 File Offset: 0x00594238
	public static void CLFIOEEGCBJ(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("PublishMapButton");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)76;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106E3 RID: 67299 RVA: 0x00594C20 File Offset: 0x00592E20
	public void FKDEEJFNNJC()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106E4 RID: 67300 RVA: 0x0059608C File Offset: 0x0059428C
	public static void HNPHJMABGDP(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("StopMusic");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = false;
		}
	}

	// Token: 0x060106E5 RID: 67301 RVA: 0x005960E8 File Offset: 0x005942E8
	public void EGEGNHLODAA()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = false;
		}
		for (int i = 0; i < this.DIFHBHMJHFJ.Count; i++)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x060106E6 RID: 67302 RVA: 0x00596184 File Offset: 0x00594384
	public static void executeInFixedUpdate(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("action");
		}
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			UnityThread.FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			UnityThread.LOFNLIACCDM = false;
		}
	}

	// Token: 0x060106E7 RID: 67303 RVA: 0x005961E0 File Offset: 0x005943E0
	public static void EBNDBKCGKJA(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("TStart");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x060106E8 RID: 67304 RVA: 0x00596234 File Offset: 0x00594434
	public static void NKAJGELBEML(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_Speed");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106E9 RID: 67305 RVA: 0x00596290 File Offset: 0x00594490
	public void MBHKDCGKDFF()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = true;
		}
		for (int i = 1; i < this.DLFAHDLMGAI.Count; i += 0)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x060106EA RID: 67306 RVA: 0x00595464 File Offset: 0x00593664
	public void AJIKPEIGACI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060106EB RID: 67307 RVA: 0x0059632C File Offset: 0x0059452C
	public void FNALDLBGCJA()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = true;
		}
		for (int i = 1; i < this.DLFAHDLMGAI.Count; i++)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x060106EC RID: 67308 RVA: 0x00595464 File Offset: 0x00593664
	public void PEMPABLNJHL()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060106ED RID: 67309 RVA: 0x005963C8 File Offset: 0x005945C8
	public static void FKCFFJOPHFF(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.EJCFMPEGKGO(new Action(adjaiffpidj.LLNDDFGPOPL));
		}
	}

	// Token: 0x060106EE RID: 67310 RVA: 0x00596404 File Offset: 0x00594604
	public void PIOIOLNNFDC()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = false;
		}
		for (int i = 0; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x060106EF RID: 67311 RVA: 0x00594C20 File Offset: 0x00592E20
	public void DLMPALHKMON()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106F0 RID: 67312 RVA: 0x00595464 File Offset: 0x00593664
	public void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060106F2 RID: 67314 RVA: 0x005964E0 File Offset: 0x005946E0
	public static void MANOGNAIFFP(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_Size");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106F3 RID: 67315 RVA: 0x0059653C File Offset: 0x0059473C
	public static void GJKPHIOEGAM(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("[PlayerController] ");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = false;
		}
	}

	// Token: 0x060106F4 RID: 67316 RVA: 0x00594C20 File Offset: 0x00592E20
	public void HNILMGEKDEC()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106F5 RID: 67317 RVA: 0x00596598 File Offset: 0x00594798
	public static void HMGGGFHGEBJ(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_Value7");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106F6 RID: 67318 RVA: 0x005965F4 File Offset: 0x005947F4
	public static void CCPLHGJIJNK(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("CameraFilterPack_Atmosphere_Rain_FX");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = false;
		}
	}

	// Token: 0x060106F7 RID: 67319 RVA: 0x00596650 File Offset: 0x00594850
	public static void NMLBHLGADBI(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.HMPACBMHFKB(new Action(adjaiffpidj.FHIJCPPECHA));
		}
	}

	// Token: 0x060106F8 RID: 67320 RVA: 0x00594C20 File Offset: 0x00592E20
	public void CBIBDOIBJAI()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106F9 RID: 67321 RVA: 0x0059668C File Offset: 0x0059488C
	public static void MPIJDKONKFA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_ScreenResolution");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x060106FA RID: 67322 RVA: 0x00594C20 File Offset: 0x00592E20
	public void OnDisable()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x060106FB RID: 67323 RVA: 0x005966E8 File Offset: 0x005948E8
	public static void KBFFMCLFCPC(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_Value5");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = true;
		}
	}

	// Token: 0x060106FC RID: 67324 RVA: 0x00596744 File Offset: 0x00594944
	public static void EFOPFEFDKJK(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.GIGIMBEMFLA(new Action(adjaiffpidj.JKEDCEOCPJO));
		}
	}

	// Token: 0x060106FD RID: 67325 RVA: 0x00595464 File Offset: 0x00593664
	public void DAHIMKKFNPH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060106FE RID: 67326 RVA: 0x00596780 File Offset: 0x00594980
	public void KMGANMFEEJJ()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = true;
		}
		for (int i = 1; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x060106FF RID: 67327 RVA: 0x0059681C File Offset: 0x00594A1C
	public static void GGCHBHLFAPL(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("Items/");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)79;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x06010700 RID: 67328 RVA: 0x00596870 File Offset: 0x00594A70
	public static void LKMMFLFKCMJ(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.LGHEJJFGGAN(new Action(adjaiffpidj.PBCAHKDLFPE));
		}
	}

	// Token: 0x06010701 RID: 67329 RVA: 0x005968AC File Offset: 0x00594AAC
	public static void NFOBBLIIBFC(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Bad parameters for setbool! Use <key> <value>");
		}
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			UnityThread.ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			UnityThread.BECMAFFONOK = true;
		}
	}

	// Token: 0x06010702 RID: 67330 RVA: 0x00596908 File Offset: 0x00594B08
	public void LLJLDLLNFBH()
	{
		if (UnityThread.OIKBOMKFDGM)
		{
			return;
		}
		this.DIFHBHMJHFJ.Clear();
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			this.DIFHBHMJHFJ.AddRange(UnityThread.LCDDNCEKPPA);
			UnityThread.LCDDNCEKPPA.Clear();
			UnityThread.OIKBOMKFDGM = true;
		}
		for (int i = 1; i < this.DIFHBHMJHFJ.Count; i++)
		{
			this.DIFHBHMJHFJ[i]();
		}
	}

	// Token: 0x06010703 RID: 67331 RVA: 0x005969A4 File Offset: 0x00594BA4
	public static void PJODGCNONEB(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("CONTRAST");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x06010704 RID: 67332 RVA: 0x00596A00 File Offset: 0x00594C00
	public void JJHDNCHBIFB()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = false;
		}
		for (int i = 1; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x06010705 RID: 67333 RVA: 0x00596A9C File Offset: 0x00594C9C
	public static void HMPACBMHFKB(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("[PlayerController] ");
		}
		object lcddncekppa = UnityThread.LCDDNCEKPPA;
		lock (lcddncekppa)
		{
			UnityThread.LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			UnityThread.OIKBOMKFDGM = true;
		}
	}

	// Token: 0x06010706 RID: 67334 RVA: 0x00596AF8 File Offset: 0x00594CF8
	public static void MCGHECJEIPE(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject(".mp3");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x06010707 RID: 67335 RVA: 0x00594C20 File Offset: 0x00592E20
	public void OOGIHDLBBLM()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x06010708 RID: 67336 RVA: 0x00596B4C File Offset: 0x00594D4C
	public void KNBFLJKOPHB()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = false;
		}
		for (int i = 1; i < this.DLFAHDLMGAI.Count; i++)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x06010709 RID: 67337 RVA: 0x00594C20 File Offset: 0x00592E20
	public void ODGMCJILIHF()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x0601070A RID: 67338 RVA: 0x00596BE8 File Offset: 0x00594DE8
	public static void LDNDMKKMKPP(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("maps.");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)78;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x0601070C RID: 67340 RVA: 0x00596C64 File Offset: 0x00594E64
	public void LateUpdate()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = true;
		}
		for (int i = 0; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x0601070D RID: 67341 RVA: 0x00595464 File Offset: 0x00593664
	public void CCDNJPNLGBN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0601070E RID: 67342 RVA: 0x00596D00 File Offset: 0x00594F00
	public static void GFNBKALLMGD(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_TimeX");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x0601070F RID: 67343 RVA: 0x00596D54 File Offset: 0x00594F54
	public static void executeCoroutine(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.executeInUpdate(new Action(adjaiffpidj.GBKBDKHPLKG));
		}
	}

	// Token: 0x06010710 RID: 67344 RVA: 0x00596D90 File Offset: 0x00594F90
	public static void AACCANJOMGN(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_Bloom3");
		}
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			UnityThread.FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			UnityThread.LOFNLIACCDM = false;
		}
	}

	// Token: 0x06010711 RID: 67345 RVA: 0x00596DEC File Offset: 0x00594FEC
	public void EKECFMONIPL()
	{
		if (UnityThread.LOFNLIACCDM)
		{
			return;
		}
		this.DLFAHDLMGAI.Clear();
		object fjjfddkdebb = UnityThread.FJJFDDKDEBB;
		lock (fjjfddkdebb)
		{
			this.DLFAHDLMGAI.AddRange(UnityThread.FJJFDDKDEBB);
			UnityThread.FJJFDDKDEBB.Clear();
			UnityThread.LOFNLIACCDM = true;
		}
		for (int i = 1; i < this.DLFAHDLMGAI.Count; i += 0)
		{
			this.DLFAHDLMGAI[i]();
		}
	}

	// Token: 0x06010712 RID: 67346 RVA: 0x00596E88 File Offset: 0x00595088
	public void JMPPILHKLPO()
	{
		if (UnityThread.BECMAFFONOK)
		{
			return;
		}
		this.IPAENCDKHNN.Clear();
		object icpkfkhejmd = UnityThread.ICPKFKHEJMD;
		lock (icpkfkhejmd)
		{
			this.IPAENCDKHNN.AddRange(UnityThread.ICPKFKHEJMD);
			UnityThread.ICPKFKHEJMD.Clear();
			UnityThread.BECMAFFONOK = false;
		}
		for (int i = 1; i < this.IPAENCDKHNN.Count; i++)
		{
			this.IPAENCDKHNN[i]();
		}
	}

	// Token: 0x06010713 RID: 67347 RVA: 0x00596F24 File Offset: 0x00595124
	public static void AKIENJGEMCK(bool IDNLBGOCOEK = false)
	{
		if (UnityThread.BFPIJFMDBGF != null)
		{
			return;
		}
		if (Application.isPlaying)
		{
			GameObject gameObject = new GameObject("ArcsHitsoundTimeDelaySlider");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			UnityThread.BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	// Token: 0x06010714 RID: 67348 RVA: 0x00595464 File Offset: 0x00593664
	public void HCCMANDFEPL()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06010715 RID: 67349 RVA: 0x00596F78 File Offset: 0x00595178
	public static void FINHJIEEBPL(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.PHEHBJECONL(new Action(adjaiffpidj.BKNHHGBPLGH));
		}
	}

	// Token: 0x06010716 RID: 67350 RVA: 0x00596FB4 File Offset: 0x005951B4
	public static void MBPMNANABIO(IEnumerator LHCIHJOHGEJ)
	{
		UnityThread.ADJAIFFPIDJ adjaiffpidj = new UnityThread.ADJAIFFPIDJ();
		adjaiffpidj.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (UnityThread.BFPIJFMDBGF != null)
		{
			UnityThread.GIGIMBEMFLA(new Action(adjaiffpidj.BKNHHGBPLGH));
		}
	}

	// Token: 0x06010717 RID: 67351 RVA: 0x00594C20 File Offset: 0x00592E20
	public void GJLKJAOBPJD()
	{
		if (UnityThread.BFPIJFMDBGF == this)
		{
			UnityThread.BFPIJFMDBGF = null;
		}
	}

	// Token: 0x04001CC6 RID: 7366
	private static UnityThread BFPIJFMDBGF = null;

	// Token: 0x04001CC7 RID: 7367
	private static List<Action> LCDDNCEKPPA = new List<Action>();

	// Token: 0x04001CC8 RID: 7368
	private List<Action> DIFHBHMJHFJ = new List<Action>();

	// Token: 0x04001CC9 RID: 7369
	private static volatile bool OIKBOMKFDGM = true;

	// Token: 0x04001CCA RID: 7370
	private static List<Action> ICPKFKHEJMD = new List<Action>();

	// Token: 0x04001CCB RID: 7371
	private List<Action> IPAENCDKHNN = new List<Action>();

	// Token: 0x04001CCC RID: 7372
	private static volatile bool BECMAFFONOK = true;

	// Token: 0x04001CCD RID: 7373
	private static List<Action> FJJFDDKDEBB = new List<Action>();

	// Token: 0x04001CCE RID: 7374
	private List<Action> DLFAHDLMGAI = new List<Action>();

	// Token: 0x04001CCF RID: 7375
	private static volatile bool LOFNLIACCDM = true;

	// Token: 0x02000478 RID: 1144
	[CompilerGenerated]
	private sealed class ADJAIFFPIDJ
	{
		// Token: 0x06010718 RID: 67352 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void FFEGPHJKMFK()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010719 RID: 67353 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void LOEAMHGMMPK()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601071A RID: 67354 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void MGENGAEDACG()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601071B RID: 67355 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void FCAGEDLBBHD()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601071C RID: 67356 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void DNIMHEKGJHB()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601071D RID: 67357 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void PIJAOCFAPKC()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601071E RID: 67358 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void LHHFJBIAHCN()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601071F RID: 67359 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void JDELIMPGFDJ()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010720 RID: 67360 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void KGKMOLCPDIH()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010721 RID: 67361 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void FHFECFLBHMA()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010722 RID: 67362 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void BDGDIDPDBHG()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010723 RID: 67363 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void FIPCLHEKKCA()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010724 RID: 67364 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void BMAOCLKPNNC()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010725 RID: 67365 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void MEMPOPNAEDN()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010726 RID: 67366 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void BJMAIJDIKCN()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010727 RID: 67367 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void JKEDCEOCPJO()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010728 RID: 67368 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void OFHCGKJFGDI()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010729 RID: 67369 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void LNDGINDKPFA()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601072A RID: 67370 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void EGKGJJGAPMN()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601072B RID: 67371 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void DBFPGFHEGKA()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601072C RID: 67372 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void GBKBDKHPLKG()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601072D RID: 67373 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void FJDBPPKABJE()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601072E RID: 67374 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void FDAIFOAGDLA()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601072F RID: 67375 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void DKGPCPBNDPK()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010730 RID: 67376 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void HBJFIOJFBHC()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010731 RID: 67377 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void IGFOBPKFCDJ()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010732 RID: 67378 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void AEINPAGJFME()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010733 RID: 67379 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void BKNHHGBPLGH()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010735 RID: 67381 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void AGJKEBOPIOC()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010736 RID: 67382 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void BFEABMIFIEE()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010737 RID: 67383 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void FHIJCPPECHA()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010738 RID: 67384 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void PBCAHKDLFPE()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x06010739 RID: 67385 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void OFLDIMDDLHM()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601073A RID: 67386 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void OLIGLEMPFOP()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601073B RID: 67387 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void LLNDDFGPOPL()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601073C RID: 67388 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void EKHOOPGPPGE()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x0601073D RID: 67389 RVA: 0x00596FEF File Offset: 0x005951EF
		internal void KFNBKFELFLH()
		{
			UnityThread.BFPIJFMDBGF.StartCoroutine(this.LHCIHJOHGEJ);
		}

		// Token: 0x04001CD0 RID: 7376
		internal IEnumerator LHCIHJOHGEJ;
	}
}
