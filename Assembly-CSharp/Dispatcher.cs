using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000413 RID: 1043
public class Dispatcher : Singleton<Dispatcher>
{
	// Token: 0x0600EF62 RID: 61282 RVA: 0x0053B88A File Offset: 0x00539A8A
	public static bool HEFMMMEHCBN()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600EF63 RID: 61283 RVA: 0x0053B898 File Offset: 0x00539A98
	public static void HBPBILKHFFL(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("player.greenlifering");
			return;
		}
		if (Dispatcher.HEFMMMEHCBN())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF64 RID: 61284 RVA: 0x0053B904 File Offset: 0x00539B04
	public static void BPMKNOLLAMJ(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("/");
			return;
		}
		if (Dispatcher.DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF65 RID: 61285 RVA: 0x0053B970 File Offset: 0x00539B70
	public new void EIFCCFBJKOO()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600EF66 RID: 61286 RVA: 0x0053B88A File Offset: 0x00539A8A
	public static bool DIMMLNKANPD()
	{
		return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
	}

	// Token: 0x0600EF67 RID: 61287 RVA: 0x0053B980 File Offset: 0x00539B80
	public static void InvokeAsync(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("No Dispatcher exists in the scene. Actions will not be invoked!");
			return;
		}
		if (Dispatcher.isMainThread)
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF69 RID: 61289 RVA: 0x0053B9F4 File Offset: 0x00539BF4
	public static void DLEEDNEHHIK(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError(" not exist");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.NKLACLFGOJM(new Action(cjalpjdiljh.FCAGEDLBBHD));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(6);
		}
	}

	// Token: 0x0600EF6A RID: 61290 RVA: 0x0053BA54 File Offset: 0x00539C54
	public static void OAOOGDBIHEG(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.POMPIODNGFL(new Action(cjalpjdiljh.FCAGEDLBBHD));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(8);
		}
	}

	// Token: 0x0600EF6B RID: 61291 RVA: 0x0053B970 File Offset: 0x00539B70
	public new void HHJBBHEBJCJ()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600EF6C RID: 61292 RVA: 0x0053B970 File Offset: 0x00539B70
	public new void PPCGJBIIFAO()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600EF6D RID: 61293 RVA: 0x0053BAB4 File Offset: 0x00539CB4
	public static void FCOFEKKCCMH(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("CameraFilterPack/3D_Computer");
			return;
		}
		if (Dispatcher.HEFMMMEHCBN())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF6E RID: 61294 RVA: 0x0053BB20 File Offset: 0x00539D20
	public static void NKLACLFGOJM(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("HitInRelaxMusicToggle");
			return;
		}
		if (Dispatcher.DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x0600EF6F RID: 61295 RVA: 0x0053B88A File Offset: 0x00539A8A
	public static bool isMainThread
	{
		get
		{
			return Thread.CurrentThread == Dispatcher.CEIHDHEOFJE;
		}
	}

	// Token: 0x0600EF70 RID: 61296 RVA: 0x0053BB8C File Offset: 0x00539D8C
	public static void Invoke(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("No Dispatcher exists in the scene. Actions will not be invoked!");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.InvokeAsync(new Action(cjalpjdiljh.GBKBDKHPLKG));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(5);
		}
	}

	// Token: 0x0600EF71 RID: 61297 RVA: 0x0053BBEC File Offset: 0x00539DEC
	public static void JMBEAJDDBAD(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("https://steamcommunity.com/sharedfiles/filedetails/?id=");
			return;
		}
		if (Dispatcher.DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF72 RID: 61298 RVA: 0x0053BC58 File Offset: 0x00539E58
	public static void ONIMJKEFHFA(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("VoteUpToggle");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.NKLACLFGOJM(new Action(cjalpjdiljh.BFEABMIFIEE));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(6);
		}
	}

	// Token: 0x0600EF73 RID: 61299 RVA: 0x0053BCB8 File Offset: 0x00539EB8
	public static void APCBFNEKBKD(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("System.Int32");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.POMPIODNGFL(new Action(cjalpjdiljh.EKHOOPGPPGE));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(1);
		}
	}

	// Token: 0x0600EF74 RID: 61300 RVA: 0x0053BD18 File Offset: 0x00539F18
	public static void HCOCMDGGJOJ(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("ItemsStoreButton");
			return;
		}
		if (Dispatcher.isMainThread)
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF75 RID: 61301 RVA: 0x0053BD84 File Offset: 0x00539F84
	public static void JHODNDBLLFH(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("/theme");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.JPAIOEFLIFM(new Action(cjalpjdiljh.EKHOOPGPPGE));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(8);
		}
	}

	// Token: 0x0600EF76 RID: 61302 RVA: 0x0053BDE4 File Offset: 0x00539FE4
	public static void NKMAIFNJMCE(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("0,7,true,0");
			return;
		}
		if (Dispatcher.isMainThread)
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF77 RID: 61303 RVA: 0x0053BE50 File Offset: 0x0053A050
	private void CFIAKIJAILI()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600EF78 RID: 61304 RVA: 0x0053BEAC File Offset: 0x0053A0AC
	public static void EKMGLJOFIEI(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_ScreenResolution");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.HBPBILKHFFL(new Action(cjalpjdiljh.KFNBKFELFLH));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	// Token: 0x0600EF79 RID: 61305 RVA: 0x0053BF0C File Offset: 0x0053A10C
	public static void ICCEOOEHNLE(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_PositionY");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.POMPIODNGFL(new Action(cjalpjdiljh.BJMAIJDIKCN));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(7);
		}
	}

	// Token: 0x0600EF7A RID: 61306 RVA: 0x0053B970 File Offset: 0x00539B70
	public new void Awake()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = true;
	}

	// Token: 0x0600EF7B RID: 61307 RVA: 0x0053BF6C File Offset: 0x0053A16C
	public static void POMPIODNGFL(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_Value5");
			return;
		}
		if (Dispatcher.DIMMLNKANPD())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF7C RID: 61308 RVA: 0x0053BFD8 File Offset: 0x0053A1D8
	private void BMODOIJGIOO()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600EF7D RID: 61309 RVA: 0x0053C034 File Offset: 0x0053A234
	private void BGFJOEPFOPM()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600EF7E RID: 61310 RVA: 0x0053C090 File Offset: 0x0053A290
	public static void BHJADCPCCGH(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Can not SetMasterClient(). Not in room or in offlineMode.");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.JMBEAJDDBAD(new Action(cjalpjdiljh.HBJFIOJFBHC));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(3);
		}
	}

	// Token: 0x0600EF7F RID: 61311 RVA: 0x0053C0F0 File Offset: 0x0053A2F0
	public static void CKMJFCANPCM(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_ScreenResolution");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.NKLACLFGOJM(new Action(cjalpjdiljh.GBKBDKHPLKG));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(5);
		}
	}

	// Token: 0x0600EF80 RID: 61312 RVA: 0x0053C150 File Offset: 0x0053A350
	public static void AMPAADDDPLF(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_NeutralTonemapperParams2");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.NKLACLFGOJM(new Action(cjalpjdiljh.DKGPCPBNDPK));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(8);
		}
	}

	// Token: 0x0600EF81 RID: 61313 RVA: 0x0053C1B0 File Offset: 0x0053A3B0
	private void FOMNCPKKCFN()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600EF82 RID: 61314 RVA: 0x0053C20C File Offset: 0x0053A40C
	private void JAAJECBCCFM()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600EF83 RID: 61315 RVA: 0x0053C268 File Offset: 0x0053A468
	public static void KONCBGHMBCP(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("0.000");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.FCOFEKKCCMH(new Action(cjalpjdiljh.EKHOOPGPPGE));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(4);
		}
	}

	// Token: 0x0600EF84 RID: 61316 RVA: 0x0053C2C8 File Offset: 0x0053A4C8
	public static void FEBNEGOMFNL(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_Distortion");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = false;
		Dispatcher.BPMKNOLLAMJ(new Action(cjalpjdiljh.MEMPOPNAEDN));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(0);
		}
	}

	// Token: 0x0600EF86 RID: 61318 RVA: 0x0053C33C File Offset: 0x0053A53C
	private void ONMGIPAILOH()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600EF87 RID: 61319 RVA: 0x0053C398 File Offset: 0x0053A598
	public new void AJIKPEIGACI()
	{
		base.Awake();
		Dispatcher.EEHBMEEHKBM = false;
	}

	// Token: 0x0600EF88 RID: 61320 RVA: 0x0053C3A8 File Offset: 0x0053A5A8
	private void Update()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 0)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x0600EF89 RID: 61321 RVA: 0x0053C404 File Offset: 0x0053A604
	public static void JPAIOEFLIFM(Action LHCIHJOHGEJ)
	{
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("Case-Sensitive");
			return;
		}
		if (Dispatcher.HEFMMMEHCBN())
		{
			LHCIHJOHGEJ();
		}
		else
		{
			object bmhffliljhn = Dispatcher.BMHFFLILJHN;
			lock (bmhffliljhn)
			{
				Dispatcher.GACAEIAGHDK.Enqueue(LHCIHJOHGEJ);
			}
		}
	}

	// Token: 0x0600EF8A RID: 61322 RVA: 0x0053C470 File Offset: 0x0053A670
	public static void IDGNACKDHEA(Action LHCIHJOHGEJ)
	{
		Dispatcher.CJALPJDILJH cjalpjdiljh = new Dispatcher.CJALPJDILJH();
		cjalpjdiljh.LHCIHJOHGEJ = LHCIHJOHGEJ;
		if (!Dispatcher.EEHBMEEHKBM)
		{
			Debug.LogError("_TimeX");
			return;
		}
		cjalpjdiljh.GIPNPIABCOM = true;
		Dispatcher.FCOFEKKCCMH(new Action(cjalpjdiljh.FDAIFOAGDLA));
		while (!cjalpjdiljh.GIPNPIABCOM)
		{
			Thread.Sleep(3);
		}
	}

	// Token: 0x0600EF8B RID: 61323 RVA: 0x0053C4D0 File Offset: 0x0053A6D0
	private void HLDFOJMHKNL()
	{
		object bmhffliljhn = Dispatcher.BMHFFLILJHN;
		lock (bmhffliljhn)
		{
			while (Dispatcher.GACAEIAGHDK.Count > 1)
			{
				Dispatcher.GACAEIAGHDK.Dequeue()();
			}
		}
	}

	// Token: 0x04001AAD RID: 6829
	private static bool EEHBMEEHKBM;

	// Token: 0x04001AAE RID: 6830
	private static Thread CEIHDHEOFJE;

	// Token: 0x04001AAF RID: 6831
	private static object BMHFFLILJHN = new object();

	// Token: 0x04001AB0 RID: 6832
	private static readonly Queue<Action> GACAEIAGHDK = new Queue<Action>();

	// Token: 0x02000414 RID: 1044
	[CompilerGenerated]
	private sealed class CJALPJDILJH
	{
		// Token: 0x0600EF8C RID: 61324 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void FJDBPPKABJE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF8D RID: 61325 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void FCAGEDLBBHD()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF8E RID: 61326 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void BKNHHGBPLGH()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF8F RID: 61327 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void JDELIMPGFDJ()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF90 RID: 61328 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void FFEGPHJKMFK()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF91 RID: 61329 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void EKHOOPGPPGE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF92 RID: 61330 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void HBJFIOJFBHC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF93 RID: 61331 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void DKGPCPBNDPK()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF94 RID: 61332 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void OFLDIMDDLHM()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF95 RID: 61333 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void LHHFJBIAHCN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF96 RID: 61334 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void OLIGLEMPFOP()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF97 RID: 61335 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void BMAOCLKPNNC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF98 RID: 61336 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void JKEDCEOCPJO()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF99 RID: 61337 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void KGKMOLCPDIH()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF9A RID: 61338 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void LNDGINDKPFA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF9B RID: 61339 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void DNIMHEKGJHB()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF9C RID: 61340 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void KFNBKFELFLH()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF9D RID: 61341 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void LOEAMHGMMPK()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EF9E RID: 61342 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void BFEABMIFIEE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EF9F RID: 61343 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void PIJAOCFAPKC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void LJDLIIIPIIJ()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFA1 RID: 61345 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void EGKGJJGAPMN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFA2 RID: 61346 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void DBFPGFHEGKA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFA4 RID: 61348 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void GBKBDKHPLKG()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void OFHCGKJFGDI()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void FHFECFLBHMA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFA7 RID: 61351 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void BDGDIDPDBHG()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFA8 RID: 61352 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void MEMPOPNAEDN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFA9 RID: 61353 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void AGJKEBOPIOC()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFAA RID: 61354 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void BJMAIJDIKCN()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFAB RID: 61355 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void FHIJCPPECHA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFAC RID: 61356 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void MGENGAEDACG()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFAD RID: 61357 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void PBCAHKDLFPE()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFAE RID: 61358 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void LLNDDFGPOPL()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFAF RID: 61359 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void FDAIFOAGDLA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x0600EFB0 RID: 61360 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void FIPCLHEKKCA()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFB1 RID: 61361 RVA: 0x0053C52C File Offset: 0x0053A72C
		internal void IGFOBPKFCDJ()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = false;
		}

		// Token: 0x0600EFB2 RID: 61362 RVA: 0x0053C540 File Offset: 0x0053A740
		internal void AEINPAGJFME()
		{
			this.LHCIHJOHGEJ();
			this.GIPNPIABCOM = true;
		}

		// Token: 0x04001AB1 RID: 6833
		internal Action LHCIHJOHGEJ;

		// Token: 0x04001AB2 RID: 6834
		internal bool GIPNPIABCOM;
	}
}
