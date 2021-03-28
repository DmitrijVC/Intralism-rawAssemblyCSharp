using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

// Token: 0x02000472 RID: 1138
public class ThreadQueuer : Singleton<ThreadQueuer>
{
	// Token: 0x06010553 RID: 66899 RVA: 0x005911F0 File Offset: 0x0058F3F0
	private void JNGMIAFLBDL()
	{
		this.HDOHPLADGBP();
	}

	// Token: 0x06010554 RID: 66900 RVA: 0x005911F8 File Offset: 0x0058F3F8
	public void PKFPDDJLHLK()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.CBCBNNJLBOA));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.DOFJHEPBNHB();
	}

	// Token: 0x06010555 RID: 66901 RVA: 0x00591270 File Offset: 0x0058F470
	public void EAKJCKEKGPJ()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.EFEEHAGKGAC(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x06010556 RID: 66902 RVA: 0x005912E4 File Offset: 0x0058F4E4
	public void TriggerAvailableThreads()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.QueueActionOnMainThread(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x06010557 RID: 66903 RVA: 0x00591358 File Offset: 0x0058F558
	public Action GetNewCoAction()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x06010558 RID: 66904 RVA: 0x00591377 File Offset: 0x0058F577
	private void NJHJHBOJKIC()
	{
		this.CloseThreads();
	}

	// Token: 0x06010559 RID: 66905 RVA: 0x0059137F File Offset: 0x0058F57F
	public new void Awake()
	{
		base.Awake();
		this.InitThreads();
	}

	// Token: 0x0601055A RID: 66906 RVA: 0x00591390 File Offset: 0x0058F590
	private void AEIJFLJEABG()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.MFHMFHNEKDO();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 0)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x0601055B RID: 66907 RVA: 0x00591414 File Offset: 0x0058F614
	public void IAAFHGGFMAB()
	{
		base.Awake();
		this.ABJAPPNMLFP();
	}

	// Token: 0x0601055C RID: 66908 RVA: 0x00591422 File Offset: 0x0058F622
	public void GCDNONIKKLI()
	{
		base.Awake();
		this.FJOGPDFDLJD();
	}

	// Token: 0x0601055D RID: 66909 RVA: 0x00591430 File Offset: 0x0058F630
	public void KELHMGHCDOF(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x0601055E RID: 66910 RVA: 0x00591474 File Offset: 0x0058F674
	public void DPGPCOOKFFM(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x0601055F RID: 66911 RVA: 0x005914B8 File Offset: 0x0058F6B8
	public void EFEEHAGKGAC(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x06010560 RID: 66912 RVA: 0x00591358 File Offset: 0x0058F558
	public Action HJEOEGKJLFN()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x06010561 RID: 66913 RVA: 0x005914FC File Offset: 0x0058F6FC
	private void FGOPJMGNHGO()
	{
		this.NPDKNEOCEOI();
	}

	// Token: 0x06010562 RID: 66914 RVA: 0x00591504 File Offset: 0x0058F704
	public void KLDLKAEMMNB()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 0; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.IFLINFFBOKK));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.TriggerAvailableThreads();
	}

	// Token: 0x06010563 RID: 66915 RVA: 0x0059157C File Offset: 0x0058F77C
	public void DJCDNJHBDNF()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.FGFIHBNKFDK));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.AJCNCJDKKOO();
	}

	// Token: 0x06010564 RID: 66916 RVA: 0x005915F4 File Offset: 0x0058F7F4
	public void HMKEIIHIAEL()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 0; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.LPPDPBECOCI));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.GMEIOLGKFOL();
	}

	// Token: 0x06010565 RID: 66917 RVA: 0x0059166C File Offset: 0x0058F86C
	public void HCPOMEFCOAI()
	{
		for (int i = 0; i < this.EDHJNNOKIAI.Length; i++)
		{
			this.threadsActionData[i].closeThread = true;
		}
		this.AJCNCJDKKOO();
	}

	// Token: 0x06010566 RID: 66918 RVA: 0x005916A8 File Offset: 0x0058F8A8
	public void MGALPNDCFOF(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x06010567 RID: 66919 RVA: 0x005916EC File Offset: 0x0058F8EC
	public void BLEIGOJBMBH(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x06010568 RID: 66920 RVA: 0x00591358 File Offset: 0x0058F558
	public Action HEDBKNFNMFI()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x06010569 RID: 66921 RVA: 0x00591730 File Offset: 0x0058F930
	private void BMAFIJDNOGG(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.GHALNNEOKGO();
					this.threadsActionData[num].isRunningTask = true;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x0601056A RID: 66922 RVA: 0x00591880 File Offset: 0x0058FA80
	private void KGPNMFDGOGN(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.HJEOEGKJLFN();
					this.threadsActionData[num].isRunningTask = true;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x0601056B RID: 66923 RVA: 0x005919D0 File Offset: 0x0058FBD0
	public void DCHBIAGKOFM(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x0601056C RID: 66924 RVA: 0x00591A14 File Offset: 0x0058FC14
	private void BNCLKHOEGDK()
	{
		this.HCPOMEFCOAI();
	}

	// Token: 0x0601056D RID: 66925 RVA: 0x0059137F File Offset: 0x0058F57F
	public void EMKLCPGKNJL()
	{
		base.Awake();
		this.InitThreads();
	}

	// Token: 0x0601056E RID: 66926 RVA: 0x00591A1C File Offset: 0x0058FC1C
	public void MFHMFHNEKDO()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.EFEEHAGKGAC(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x0601056F RID: 66927 RVA: 0x00591A90 File Offset: 0x0058FC90
	private void IFLINFFBOKK(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.IPCFHKLAHEF();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x06010570 RID: 66928 RVA: 0x00591377 File Offset: 0x0058F577
	private void ODGMCJILIHF()
	{
		this.CloseThreads();
	}

	// Token: 0x06010571 RID: 66929 RVA: 0x00591BE0 File Offset: 0x0058FDE0
	public void MAIJGEODMAH()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.IKABLHFIACK));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.POLALEHNGNM();
	}

	// Token: 0x06010572 RID: 66930 RVA: 0x00591C58 File Offset: 0x0058FE58
	public new void EPCGHAAONLN()
	{
		base.Awake();
		this.KLDLKAEMMNB();
	}

	// Token: 0x06010573 RID: 66931 RVA: 0x00591C68 File Offset: 0x0058FE68
	private void Update()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.TriggerAvailableThreads();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 0)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x06010574 RID: 66932 RVA: 0x00591CEC File Offset: 0x0058FEEC
	public void KKHEACCGOPC()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.LAGMNGOAGNB(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x06010575 RID: 66933 RVA: 0x00591D60 File Offset: 0x0058FF60
	public void IFILNFIMJAE()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.MGJGCKEFGCG(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x06010576 RID: 66934 RVA: 0x00591DD4 File Offset: 0x0058FFD4
	private void CBCBNNJLBOA(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.IPCFHKLAHEF();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = false;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x06010577 RID: 66935 RVA: 0x00591F24 File Offset: 0x00590124
	public void NPDKNEOCEOI()
	{
		for (int i = 1; i < this.EDHJNNOKIAI.Length; i++)
		{
			this.threadsActionData[i].closeThread = true;
		}
		this.GMLMDLPLIGJ();
	}

	// Token: 0x06010578 RID: 66936 RVA: 0x00591F60 File Offset: 0x00590160
	public void MHBDPKPDPMF()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.QueueActionOnMainThread(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x06010579 RID: 66937 RVA: 0x00591FD4 File Offset: 0x005901D4
	public void HMDIMOMMAFG()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 0; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.PBEBNPGHLBL));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.NNNIHINHBHE();
	}

	// Token: 0x0601057A RID: 66938 RVA: 0x00591358 File Offset: 0x0058F558
	public Action BLIPNCCMMAG()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x0601057B RID: 66939 RVA: 0x0059204C File Offset: 0x0059024C
	public void ABJAPPNMLFP()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.KMLJHKIMNHL));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.NNNIHINHBHE();
	}

	// Token: 0x0601057C RID: 66940 RVA: 0x00591358 File Offset: 0x0058F558
	public Action GHALNNEOKGO()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x0601057D RID: 66941 RVA: 0x005920C4 File Offset: 0x005902C4
	public void KCLDKCMLCKN()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.KMOMIFGMKKL));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.JCIMJDENCBD();
	}

	// Token: 0x0601057E RID: 66942 RVA: 0x0059213C File Offset: 0x0059033C
	private void AGMJDGHLBMN()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.MHBDPKPDPMF();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 0)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x0601057F RID: 66943 RVA: 0x005921C0 File Offset: 0x005903C0
	public void DHLENLKIEHE()
	{
		for (int i = 0; i < this.EDHJNNOKIAI.Length; i++)
		{
			this.threadsActionData[i].closeThread = true;
		}
		this.POLALEHNGNM();
	}

	// Token: 0x06010580 RID: 66944 RVA: 0x005921FC File Offset: 0x005903FC
	public void InitThreads()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 0; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.CMCANPJNNHB));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.TriggerAvailableThreads();
	}

	// Token: 0x06010581 RID: 66945 RVA: 0x00592274 File Offset: 0x00590474
	public void CDBMPKAEMAD()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.PBEBNPGHLBL));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.OCEDIDGKICL();
	}

	// Token: 0x06010582 RID: 66946 RVA: 0x005922EC File Offset: 0x005904EC
	public void APBFDLNHNHD(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x06010583 RID: 66947 RVA: 0x00592330 File Offset: 0x00590530
	public void CHJFFPOBNLO()
	{
		base.Awake();
		this.CKMKHEJMGKP();
	}

	// Token: 0x06010584 RID: 66948 RVA: 0x005914FC File Offset: 0x0058F6FC
	private void HONBLGFDMLL()
	{
		this.NPDKNEOCEOI();
	}

	// Token: 0x06010585 RID: 66949 RVA: 0x00591358 File Offset: 0x0058F558
	public Action KEDNLOIEDIP()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x06010586 RID: 66950 RVA: 0x00592340 File Offset: 0x00590540
	public void QueueActionOnCoThread(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x06010587 RID: 66951 RVA: 0x00592384 File Offset: 0x00590584
	public void AOJBBCMFJPO()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 0; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.MJCKFOMBOJB));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.JCIMJDENCBD();
	}

	// Token: 0x06010588 RID: 66952 RVA: 0x005923FC File Offset: 0x005905FC
	private void IKABLHFIACK(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.GetNewCoAction();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = false;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x06010589 RID: 66953 RVA: 0x00591377 File Offset: 0x0058F577
	private void MKFLBEGJJDC()
	{
		this.CloseThreads();
	}

	// Token: 0x0601058A RID: 66954 RVA: 0x00591A14 File Offset: 0x0058FC14
	private void DLMPALHKMON()
	{
		this.HCPOMEFCOAI();
	}

	// Token: 0x0601058B RID: 66955 RVA: 0x0059254C File Offset: 0x0059074C
	private void AOKOLPEGHDD()
	{
		this.FBCBLPIIAGB();
	}

	// Token: 0x0601058C RID: 66956 RVA: 0x00592554 File Offset: 0x00590754
	private void KMOMIFGMKKL(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.IPCFHKLAHEF();
					this.threadsActionData[num].isRunningTask = true;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = false;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x0601058D RID: 66957 RVA: 0x005926A4 File Offset: 0x005908A4
	public void JCIMJDENCBD()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.KIEAGEGIICH(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x0601058E RID: 66958 RVA: 0x00592718 File Offset: 0x00590918
	private void BFEILOMHNPC()
	{
		this.LNJABCEOGOB();
	}

	// Token: 0x0601058F RID: 66959 RVA: 0x00592720 File Offset: 0x00590920
	public void CNDGDDLEFJF()
	{
		base.Awake();
		this.AOJBBCMFJPO();
	}

	// Token: 0x06010590 RID: 66960 RVA: 0x00592730 File Offset: 0x00590930
	public void JGFIAPPGEBM(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x06010591 RID: 66961 RVA: 0x00592774 File Offset: 0x00590974
	public void PIGDNBGPOJD(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x06010592 RID: 66962 RVA: 0x005927B8 File Offset: 0x005909B8
	public void AAACNPKFJJK()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.EFEEHAGKGAC(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x06010593 RID: 66963 RVA: 0x00591A14 File Offset: 0x0058FC14
	private void OFIMMFHFHDD()
	{
		this.HCPOMEFCOAI();
	}

	// Token: 0x06010594 RID: 66964 RVA: 0x0059282C File Offset: 0x00590A2C
	public void AJCNCJDKKOO()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.BKNJPOJCBOJ(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x06010595 RID: 66965 RVA: 0x005928A0 File Offset: 0x00590AA0
	private void JFMIDILENDO()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.AAACNPKFJJK();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 1)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x06010596 RID: 66966 RVA: 0x00592924 File Offset: 0x00590B24
	public void PHHOMLJECOJ()
	{
		base.Awake();
		this.HMDIMOMMAFG();
	}

	// Token: 0x06010598 RID: 66968 RVA: 0x00592964 File Offset: 0x00590B64
	public void BLHFCILHPJP()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.CBCBNNJLBOA));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.GMLMDLPLIGJ();
	}

	// Token: 0x06010599 RID: 66969 RVA: 0x005929DC File Offset: 0x00590BDC
	public void CLMMKBJMMOL()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.BLEIGOJBMBH(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x0601059A RID: 66970 RVA: 0x00592A50 File Offset: 0x00590C50
	public void MGJGCKEFGCG(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x0601059B RID: 66971 RVA: 0x00592A94 File Offset: 0x00590C94
	public void JAKKPJKDGHD()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.IFLINFFBOKK));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.AJCNCJDKKOO();
	}

	// Token: 0x0601059C RID: 66972 RVA: 0x00591358 File Offset: 0x0058F558
	public Action CIJDACOPADH()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x0601059D RID: 66973 RVA: 0x00591358 File Offset: 0x0058F558
	public Action PJPFJBCPFPI()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x0601059E RID: 66974 RVA: 0x00592B0C File Offset: 0x00590D0C
	public void KFBINOBLBIO(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x0601059F RID: 66975 RVA: 0x00591A14 File Offset: 0x0058FC14
	private void JHLGHODFJOO()
	{
		this.HCPOMEFCOAI();
	}

	// Token: 0x060105A0 RID: 66976 RVA: 0x00592B50 File Offset: 0x00590D50
	public void KIEAGEGIICH(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105A1 RID: 66977 RVA: 0x00592B94 File Offset: 0x00590D94
	private void FGFIHBNKFDK(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.CFJNNEMICIM();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = false;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105A2 RID: 66978 RVA: 0x00592CE4 File Offset: 0x00590EE4
	private void OBAEDJJDCPN()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.OCEDIDGKICL();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 0)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x060105A3 RID: 66979 RVA: 0x00592D68 File Offset: 0x00590F68
	private void KMLJHKIMNHL(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads++;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.ECAFMHILCJE();
					this.threadsActionData[num].isRunningTask = true;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105A4 RID: 66980 RVA: 0x005914FC File Offset: 0x0058F6FC
	private void NDDNJNCINDA()
	{
		this.NPDKNEOCEOI();
	}

	// Token: 0x060105A5 RID: 66981 RVA: 0x00592EB8 File Offset: 0x005910B8
	public void LPDOPHJPGLC()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.CBCBNNJLBOA));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.MFHMFHNEKDO();
	}

	// Token: 0x060105A6 RID: 66982 RVA: 0x00592F30 File Offset: 0x00591130
	private void LPPDPBECOCI(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads++;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.PJPFJBCPFPI();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105A7 RID: 66983 RVA: 0x00593080 File Offset: 0x00591280
	private void KMKLDAJLCNM()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.GMLMDLPLIGJ();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 0)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x060105A8 RID: 66984 RVA: 0x00593104 File Offset: 0x00591304
	public void MDOBONJMBKF()
	{
		base.Awake();
		this.EKLACGNPPHB();
	}

	// Token: 0x060105A9 RID: 66985 RVA: 0x00591C58 File Offset: 0x0058FE58
	public new void LBOBAIGNOML()
	{
		base.Awake();
		this.KLDLKAEMMNB();
	}

	// Token: 0x060105AA RID: 66986 RVA: 0x00593114 File Offset: 0x00591314
	private void CMCANPJNNHB(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads++;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.GetNewCoAction();
					this.threadsActionData[num].isRunningTask = true;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = false;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105AB RID: 66987 RVA: 0x00593264 File Offset: 0x00591464
	public void BKNJPOJCBOJ(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105AC RID: 66988 RVA: 0x005932A8 File Offset: 0x005914A8
	public void GMEIOLGKFOL()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.BKNJPOJCBOJ(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x060105AD RID: 66989 RVA: 0x0059331C File Offset: 0x0059151C
	private void HLHJBJGEEEA()
	{
		this.DHLENLKIEHE();
	}

	// Token: 0x060105AE RID: 66990 RVA: 0x00593324 File Offset: 0x00591524
	public void GMLMDLPLIGJ()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.EFEEHAGKGAC(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x060105AF RID: 66991 RVA: 0x00591358 File Offset: 0x0058F558
	public Action GKEDPDBJFBJ()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x060105B0 RID: 66992 RVA: 0x00593398 File Offset: 0x00591598
	public void FBCBLPIIAGB()
	{
		for (int i = 0; i < this.EDHJNNOKIAI.Length; i++)
		{
			this.threadsActionData[i].closeThread = false;
		}
		this.IFILNFIMJAE();
	}

	// Token: 0x060105B1 RID: 66993 RVA: 0x005933D2 File Offset: 0x005915D2
	public new void FAAJAMIGJNK()
	{
		base.Awake();
		this.DJCDNJHBDNF();
	}

	// Token: 0x060105B2 RID: 66994 RVA: 0x005933E0 File Offset: 0x005915E0
	public void OCEDIDGKICL()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.FLCDNEPPGIF(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x060105B3 RID: 66995 RVA: 0x005911F0 File Offset: 0x0058F3F0
	private void BDBJEDIOKBN()
	{
		this.HDOHPLADGBP();
	}

	// Token: 0x060105B4 RID: 66996 RVA: 0x0059137F File Offset: 0x0058F57F
	public void EHKAMNFEGMG()
	{
		base.Awake();
		this.InitThreads();
	}

	// Token: 0x060105B5 RID: 66997 RVA: 0x00591377 File Offset: 0x0058F577
	private void OnDisable()
	{
		this.CloseThreads();
	}

	// Token: 0x060105B6 RID: 66998 RVA: 0x00593454 File Offset: 0x00591654
	public void DGHLEBKPFLL(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105B7 RID: 66999 RVA: 0x00593498 File Offset: 0x00591698
	private void PHNPHCBINMO(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads++;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.GHALNNEOKGO();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105B8 RID: 67000 RVA: 0x00591358 File Offset: 0x0058F558
	public Action ECAFMHILCJE()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x060105B9 RID: 67001 RVA: 0x00592720 File Offset: 0x00590920
	public new void CIAHIJIOFIE()
	{
		base.Awake();
		this.AOJBBCMFJPO();
	}

	// Token: 0x060105BA RID: 67002 RVA: 0x005935E8 File Offset: 0x005917E8
	public void HDOHPLADGBP()
	{
		for (int i = 1; i < this.EDHJNNOKIAI.Length; i++)
		{
			this.threadsActionData[i].closeThread = true;
		}
		this.CLMMKBJMMOL();
	}

	// Token: 0x060105BB RID: 67003 RVA: 0x0059254C File Offset: 0x0059074C
	private void GJLKJAOBPJD()
	{
		this.FBCBLPIIAGB();
	}

	// Token: 0x060105BC RID: 67004 RVA: 0x00591358 File Offset: 0x0058F558
	public Action CFJNNEMICIM()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x060105BD RID: 67005 RVA: 0x0059331C File Offset: 0x0059151C
	private void PGMMBADJIKH()
	{
		this.DHLENLKIEHE();
	}

	// Token: 0x060105BE RID: 67006 RVA: 0x00593624 File Offset: 0x00591824
	private void MJCKFOMBOJB(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads++;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.NFGAAPJCPCL();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105BF RID: 67007 RVA: 0x00591C58 File Offset: 0x0058FE58
	public void NEEIFNDHDOG()
	{
		base.Awake();
		this.KLDLKAEMMNB();
	}

	// Token: 0x060105C0 RID: 67008 RVA: 0x00593774 File Offset: 0x00591974
	public void DOFJHEPBNHB()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 0)
			{
				this.DPGPCOOKFFM(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x060105C1 RID: 67009 RVA: 0x005937E8 File Offset: 0x005919E8
	public void EKLACGNPPHB()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i++)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.KMOMIFGMKKL));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.NNNIHINHBHE();
	}

	// Token: 0x060105C2 RID: 67010 RVA: 0x00593860 File Offset: 0x00591A60
	public void ACGOOFLCOCF(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105C3 RID: 67011 RVA: 0x005938A4 File Offset: 0x00591AA4
	public void CloseThreads()
	{
		for (int i = 0; i < this.EDHJNNOKIAI.Length; i++)
		{
			this.threadsActionData[i].closeThread = true;
		}
		this.TriggerAvailableThreads();
	}

	// Token: 0x060105C4 RID: 67012 RVA: 0x00591358 File Offset: 0x0058F558
	public Action NFGAAPJCPCL()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x060105C5 RID: 67013 RVA: 0x00591358 File Offset: 0x0058F558
	public Action KKNAKAMHNJL()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x060105C6 RID: 67014 RVA: 0x005938E0 File Offset: 0x00591AE0
	public void BNKFFGOKGHA(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105C7 RID: 67015 RVA: 0x00593924 File Offset: 0x00591B24
	public void FLINKKAECJC()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.LPPDPBECOCI));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.AJCNCJDKKOO();
	}

	// Token: 0x060105C8 RID: 67016 RVA: 0x0059399C File Offset: 0x00591B9C
	public void GGHEPDCEHCK()
	{
		base.Awake();
		this.HMKEIIHIAEL();
	}

	// Token: 0x060105C9 RID: 67017 RVA: 0x005939AC File Offset: 0x00591BAC
	public void QueueActionOnMainThread(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105CA RID: 67018 RVA: 0x005939F0 File Offset: 0x00591BF0
	public void FLCDNEPPGIF(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105CB RID: 67019 RVA: 0x00593A34 File Offset: 0x00591C34
	public void POLALEHNGNM()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.FLCDNEPPGIF(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x060105CC RID: 67020 RVA: 0x00593AA8 File Offset: 0x00591CA8
	public void GBJALJFDDCK(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105CD RID: 67021 RVA: 0x00593AEC File Offset: 0x00591CEC
	private void NJKCFCMBEAI(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads += 0;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.IPCFHKLAHEF();
					this.threadsActionData[num].isRunningTask = true;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = false;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105CE RID: 67022 RVA: 0x00593C3C File Offset: 0x00591E3C
	public void LAGMNGOAGNB(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105CF RID: 67023 RVA: 0x00593C80 File Offset: 0x00591E80
	public void KDDLJDFOJOP()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.GGOMGFHDNBI(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x060105D0 RID: 67024 RVA: 0x00593CF4 File Offset: 0x00591EF4
	public void KOODOMJECHB(Action JLFMELNFEIP)
	{
		object pdaijpgcakn = this.PDAIJPGCAKN;
		lock (pdaijpgcakn)
		{
			this.PDAIJPGCAKN.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105D1 RID: 67025 RVA: 0x00593D38 File Offset: 0x00591F38
	public void GGOMGFHDNBI(Action JLFMELNFEIP)
	{
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			this.ONGBEPGNDIB.Enqueue(JLFMELNFEIP);
		}
	}

	// Token: 0x060105D2 RID: 67026 RVA: 0x00593D7C File Offset: 0x00591F7C
	private void DPIPGGDNGHN()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.KKHEACCGOPC();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 1)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x060105D3 RID: 67027 RVA: 0x00591358 File Offset: 0x0058F558
	public Action IPCFHKLAHEF()
	{
		if (this.PDAIJPGCAKN.Count != 0)
		{
			return this.PDAIJPGCAKN.Dequeue();
		}
		return null;
	}

	// Token: 0x060105D4 RID: 67028 RVA: 0x00593E00 File Offset: 0x00592000
	private void PBEBNPGHLBL(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads++;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.GetNewCoAction();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = true;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads -= 0;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105D5 RID: 67029 RVA: 0x00593F50 File Offset: 0x00592150
	private void HKMCGGDPCIA(object FHBFLOIHPCF)
	{
		int num = (int)FHBFLOIHPCF;
		this.activeThreads++;
		this.threadsActionData[num] = new ThreadQueuer.ThreadActionData();
		for (;;)
		{
			try
			{
				object fmchbcdbjnb = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb)
				{
					if (this.PDAIJPGCAKN.Count == 0)
					{
						Monitor.Wait(this.FMCHBCDBJNB);
						if (this.threadsActionData[num].closeThread)
						{
							break;
						}
					}
					this.threadsActionData[num].taskToRun = this.CIJDACOPADH();
					this.threadsActionData[num].isRunningTask = false;
				}
				if (this.threadsActionData[num].taskToRun != null)
				{
					this.threadsActionData[num].taskToRun();
				}
				object fmchbcdbjnb2 = this.FMCHBCDBJNB;
				lock (fmchbcdbjnb2)
				{
					this.threadsActionData[num].isRunningTask = false;
					if (this.threadsActionData[num].closeThread)
					{
						this.activeThreads--;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				break;
			}
		}
	}

	// Token: 0x060105D6 RID: 67030 RVA: 0x005940A0 File Offset: 0x005922A0
	public void LNJABCEOGOB()
	{
		for (int i = 0; i < this.EDHJNNOKIAI.Length; i++)
		{
			this.threadsActionData[i].closeThread = true;
		}
		this.POLALEHNGNM();
	}

	// Token: 0x060105D7 RID: 67031 RVA: 0x005940DC File Offset: 0x005922DC
	public void NNNIHINHBHE()
	{
		object fmchbcdbjnb = this.FMCHBCDBJNB;
		lock (fmchbcdbjnb)
		{
			Monitor.PulseAll(this.FMCHBCDBJNB);
		}
		if (this.numThreads == 0)
		{
			while (this.PDAIJPGCAKN.Count > 1)
			{
				this.GGOMGFHDNBI(this.PDAIJPGCAKN.Dequeue());
			}
		}
	}

	// Token: 0x060105D8 RID: 67032 RVA: 0x005933D2 File Offset: 0x005915D2
	public void KAMMKPFNJJF()
	{
		base.Awake();
		this.DJCDNJHBDNF();
	}

	// Token: 0x060105D9 RID: 67033 RVA: 0x00594150 File Offset: 0x00592350
	private void BGFJOEPFOPM()
	{
		this.waitingCoActions = this.PDAIJPGCAKN.Count;
		if (this.PDAIJPGCAKN.Count != 0)
		{
			this.EAKJCKEKGPJ();
		}
		object ongbepgndib = this.ONGBEPGNDIB;
		lock (ongbepgndib)
		{
			while (this.ONGBEPGNDIB.Count > 0)
			{
				this.ONGBEPGNDIB.Dequeue()();
			}
		}
	}

	// Token: 0x060105DA RID: 67034 RVA: 0x005941D4 File Offset: 0x005923D4
	public void CKMKHEJMGKP()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 1; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.PBEBNPGHLBL));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.KDDLJDFOJOP();
	}

	// Token: 0x060105DB RID: 67035 RVA: 0x0059424C File Offset: 0x0059244C
	public void FJOGPDFDLJD()
	{
		this.EDHJNNOKIAI = new Thread[this.numThreads];
		this.threadsActionData = new ThreadQueuer.ThreadActionData[this.numThreads];
		for (int i = 0; i < this.numThreads; i += 0)
		{
			this.EDHJNNOKIAI[i] = new Thread(new ParameterizedThreadStart(this.CMCANPJNNHB));
			this.EDHJNNOKIAI[i].Start(i);
		}
		this.JCIMJDENCBD();
	}

	// Token: 0x04001CAE RID: 7342
	private readonly Queue<Action> ONGBEPGNDIB = new Queue<Action>();

	// Token: 0x04001CAF RID: 7343
	private readonly Queue<Action> PDAIJPGCAKN = new Queue<Action>();

	// Token: 0x04001CB0 RID: 7344
	private Thread[] EDHJNNOKIAI;

	// Token: 0x04001CB1 RID: 7345
	[SerializeField]
	private ThreadQueuer.ThreadActionData[] threadsActionData;

	// Token: 0x04001CB2 RID: 7346
	private readonly object FMCHBCDBJNB = new object();

	// Token: 0x04001CB3 RID: 7347
	public int numThreads = 8;

	// Token: 0x04001CB4 RID: 7348
	[SerializeField]
	private int activeThreads;

	// Token: 0x04001CB5 RID: 7349
	[SerializeField]
	private int waitingCoActions;

	// Token: 0x02000473 RID: 1139
	[Serializable]
	public class ThreadActionData
	{
		// Token: 0x04001CB6 RID: 7350
		public Action taskToRun;

		// Token: 0x04001CB7 RID: 7351
		public bool isRunningTask;

		// Token: 0x04001CB8 RID: 7352
		public bool isWaiting;

		// Token: 0x04001CB9 RID: 7353
		public bool closeThread;
	}
}
