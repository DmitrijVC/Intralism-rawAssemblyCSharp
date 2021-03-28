using System;
using System.Collections;
using System.Threading;

// Token: 0x02000470 RID: 1136
public class ThreadedJob
{
	// Token: 0x0601043F RID: 66623 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void CGMJODOBINA()
	{
	}

	// Token: 0x06010440 RID: 66624 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void HEAPJGAGAGL()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010441 RID: 66625 RVA: 0x0058FC07 File Offset: 0x0058DE07
	private void CCCCEEIEBAC()
	{
		this.JAFCCBIPELN();
		this.IsDone = true;
	}

	// Token: 0x06010442 RID: 66626 RVA: 0x0058FC18 File Offset: 0x0058DE18
	public bool HCCJFONPKNG()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x06010443 RID: 66627 RVA: 0x0058FC58 File Offset: 0x0058DE58
	public void MCKEKOENPKO(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010444 RID: 66628 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void LAAOPGMOANL()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010445 RID: 66629 RVA: 0x0058FC98 File Offset: 0x0058DE98
	public void MMIBGKLFGKN(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010446 RID: 66630 RVA: 0x0058FCD8 File Offset: 0x0058DED8
	public virtual bool JBCNIPJDPJB()
	{
		if (this.NJPGLBKALNF())
		{
			this.HHDOHGLHNHI();
			return false;
		}
		return true;
	}

	// Token: 0x06010447 RID: 66631 RVA: 0x0058FCF0 File Offset: 0x0058DEF0
	public IEnumerator PMJNJFLEMMO()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06010448 RID: 66632 RVA: 0x0058FD0B File Offset: 0x0058DF0B
	private void OEFGKIDPCEE()
	{
		this.KACOCMHIAHP();
		this.JGIBKOGBOCL(true);
	}

	// Token: 0x06010449 RID: 66633 RVA: 0x0058FD1C File Offset: 0x0058DF1C
	public IEnumerator CINPOEOOEAK()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x0601044A RID: 66634 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void NHDNCAMNNDP()
	{
	}

	// Token: 0x0601044B RID: 66635 RVA: 0x0058FD38 File Offset: 0x0058DF38
	public void NEMELABJNAD(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x0601044C RID: 66636 RVA: 0x0058FD78 File Offset: 0x0058DF78
	public IEnumerator PIHBFBHOCBN()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x0601044D RID: 66637 RVA: 0x0058FD94 File Offset: 0x0058DF94
	public void NKJHEMBBEKJ(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x0601044E RID: 66638 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void JCFLIHMPFKN()
	{
	}

	// Token: 0x0601044F RID: 66639 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void IIKJGEAGILG()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010450 RID: 66640 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void KACOCMHIAHP()
	{
	}

	// Token: 0x06010451 RID: 66641 RVA: 0x0058FDD4 File Offset: 0x0058DFD4
	public bool HDIOCHHNKAD()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x06010452 RID: 66642 RVA: 0x0058FE14 File Offset: 0x0058E014
	public virtual bool JAAJECBCCFM()
	{
		if (this.IsDone)
		{
			this.HHDOHGLHNHI();
			return false;
		}
		return true;
	}

	// Token: 0x06010453 RID: 66643 RVA: 0x0058FE2A File Offset: 0x0058E02A
	private void PELOINOKMIE()
	{
		this.HNBCBALPKON();
		this.BFHNLICBHGM(false);
	}

	// Token: 0x06010454 RID: 66644 RVA: 0x0058FE3C File Offset: 0x0058E03C
	public void HECLDMBBBFK(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010455 RID: 66645 RVA: 0x0058FE7C File Offset: 0x0058E07C
	public void NMCILFOEIMF(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010456 RID: 66646 RVA: 0x0058FEBC File Offset: 0x0058E0BC
	public IEnumerator FIGGJJPGOJL()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06010457 RID: 66647 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void JAFCCBIPELN()
	{
	}

	// Token: 0x06010458 RID: 66648 RVA: 0x0058FED7 File Offset: 0x0058E0D7
	public virtual bool GHILDCBCDJI()
	{
		if (this.BFANLENFGBJ())
		{
			this.NPDCBGFHHAF();
			return true;
		}
		return true;
	}

	// Token: 0x06010459 RID: 66649 RVA: 0x0058FEED File Offset: 0x0058E0ED
	private void KKOOFPMGNBN()
	{
		this.HNBCBALPKON();
		this.PHFOAMNOLOI(true);
	}

	// Token: 0x0601045A RID: 66650 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void HHDOHGLHNHI()
	{
	}

	// Token: 0x0601045B RID: 66651 RVA: 0x0058FEFC File Offset: 0x0058E0FC
	public IEnumerator LPGHFFEOBJC()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x0601045C RID: 66652 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void DEEGILEDNBM()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x0601045D RID: 66653 RVA: 0x0058FF17 File Offset: 0x0058E117
	private void EOPBPOPPOKG()
	{
		this.INEIAMHKAFF();
		this.PHFOAMNOLOI(true);
	}

	// Token: 0x0601045E RID: 66654 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void BLFNOPKJDGC()
	{
	}

	// Token: 0x0601045F RID: 66655 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void MNOCACNOIPB()
	{
	}

	// Token: 0x06010460 RID: 66656 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void INEIAMHKAFF()
	{
	}

	// Token: 0x06010461 RID: 66657 RVA: 0x0058FF28 File Offset: 0x0058E128
	public void ADPHNKCNFHJ(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010462 RID: 66658 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void MIAKPNFLJDO()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010463 RID: 66659 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void OLBNEHNLGLO()
	{
	}

	// Token: 0x06010464 RID: 66660 RVA: 0x0058FF68 File Offset: 0x0058E168
	public bool CMANEFCBEBB()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x06010465 RID: 66661 RVA: 0x0058FFA8 File Offset: 0x0058E1A8
	public virtual void FNCDAPDOBBI()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.GHJBLLBNBBM));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x06010466 RID: 66662 RVA: 0x0058FFCC File Offset: 0x0058E1CC
	public IEnumerator KJPPHFHBPAK()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06010467 RID: 66663 RVA: 0x0058FFE8 File Offset: 0x0058E1E8
	public void GAOKHINEGAD(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010468 RID: 66664 RVA: 0x00590028 File Offset: 0x0058E228
	public void PHFOAMNOLOI(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010469 RID: 66665 RVA: 0x00590068 File Offset: 0x0058E268
	private void DAJEGGEMJMA()
	{
		this.CGMJODOBINA();
		this.IENPOLLNILL(true);
	}

	// Token: 0x0601046A RID: 66666 RVA: 0x00590077 File Offset: 0x0058E277
	private void AIJAHEOABKJ()
	{
		this.GODPOOJFKEF();
		this.NMCILFOEIMF(false);
	}

	// Token: 0x0601046B RID: 66667 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void BCPDKGMCFPL()
	{
	}

	// Token: 0x0601046C RID: 66668 RVA: 0x0058FFA8 File Offset: 0x0058E1A8
	public virtual void CCLNNLCOPBL()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.GHJBLLBNBBM));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x0601046D RID: 66669 RVA: 0x00590086 File Offset: 0x0058E286
	public virtual void MODENHKMKOC()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.LADLLJDECAM));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x0601046E RID: 66670 RVA: 0x005900AA File Offset: 0x0058E2AA
	public virtual void HDMDKOKOOJC()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.AIJAHEOABKJ));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x0601046F RID: 66671 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void JHJKOHMCKAH()
	{
	}

	// Token: 0x06010470 RID: 66672 RVA: 0x005900D0 File Offset: 0x0058E2D0
	public IEnumerator LLHCIAKLMHG()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06010471 RID: 66673 RVA: 0x005900EB File Offset: 0x0058E2EB
	public virtual void HIPEHGNBJMN()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.GGILEEHGNFP));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x06010472 RID: 66674 RVA: 0x0059010F File Offset: 0x0058E30F
	public virtual void Start()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.CCCCEEIEBAC));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x06010473 RID: 66675 RVA: 0x0058FE2A File Offset: 0x0058E02A
	private void GBGFCGHHKJL()
	{
		this.HNBCBALPKON();
		this.BFHNLICBHGM(false);
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06010474 RID: 66676 RVA: 0x00590134 File Offset: 0x0058E334
	// (set) Token: 0x060104CE RID: 66766 RVA: 0x005907C4 File Offset: 0x0058E9C4
	public bool IsDone
	{
		get
		{
			object bnnaeccmlcb = this.BNNAECCMLCB;
			bool hnhejmglaig;
			lock (bnnaeccmlcb)
			{
				hnhejmglaig = this.HNHEJMGLAIG;
			}
			return hnhejmglaig;
		}
		set
		{
			object bnnaeccmlcb = this.BNNAECCMLCB;
			lock (bnnaeccmlcb)
			{
				this.HNHEJMGLAIG = value;
			}
		}
	}

	// Token: 0x06010475 RID: 66677 RVA: 0x00590174 File Offset: 0x0058E374
	public void JGIBKOGBOCL(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010476 RID: 66678 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void HLIGOANMMIB()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010477 RID: 66679 RVA: 0x005901B4 File Offset: 0x0058E3B4
	public void IENPOLLNILL(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x06010478 RID: 66680 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void DICMBDCKBKH()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010479 RID: 66681 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void JLAPONBAOHB()
	{
	}

	// Token: 0x0601047A RID: 66682 RVA: 0x005901F4 File Offset: 0x0058E3F4
	private void FODBDKLKIGD()
	{
		this.JLAPONBAOHB();
		this.MMIBGKLFGKN(true);
	}

	// Token: 0x0601047B RID: 66683 RVA: 0x00590203 File Offset: 0x0058E403
	public virtual bool FOLDLDLFFLM()
	{
		if (this.BFANLENFGBJ())
		{
			this.MMKBEAKPBIK();
			return false;
		}
		return true;
	}

	// Token: 0x0601047C RID: 66684 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void COOHMDACKGM()
	{
	}

	// Token: 0x0601047D RID: 66685 RVA: 0x00590219 File Offset: 0x0058E419
	private void BCLEBNAOOGN()
	{
		this.JCFLIHMPFKN();
		this.BFHNLICBHGM(true);
	}

	// Token: 0x0601047E RID: 66686 RVA: 0x00590228 File Offset: 0x0058E428
	public virtual void EFJDNLGNACH()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.PELOINOKMIE));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x0601047F RID: 66687 RVA: 0x0059024C File Offset: 0x0058E44C
	public virtual bool EIDKCANPHJE()
	{
		if (this.MNJBDMBMKCN())
		{
			this.DHEBIKHIIAP();
			return false;
		}
		return false;
	}

	// Token: 0x06010480 RID: 66688 RVA: 0x00590264 File Offset: 0x0058E464
	public IEnumerator ADGKLGALNJI()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06010481 RID: 66689 RVA: 0x00590280 File Offset: 0x0058E480
	public bool PFLCOPNEOPE()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x06010482 RID: 66690 RVA: 0x005902C0 File Offset: 0x0058E4C0
	public virtual void JFJLGJEPEAA()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.OEFGKIDPCEE));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x06010484 RID: 66692 RVA: 0x005902C0 File Offset: 0x0058E4C0
	public virtual void JDKHBGDEONK()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.OEFGKIDPCEE));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x06010485 RID: 66693 RVA: 0x0058FFA8 File Offset: 0x0058E1A8
	public virtual void OGJJDKENBNC()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.GHJBLLBNBBM));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x06010486 RID: 66694 RVA: 0x005902F7 File Offset: 0x0058E4F7
	public virtual bool Update()
	{
		if (this.IsDone)
		{
			this.BLFNOPKJDGC();
			return true;
		}
		return false;
	}

	// Token: 0x06010487 RID: 66695 RVA: 0x0059030D File Offset: 0x0058E50D
	private void LADLLJDECAM()
	{
		this.KDCODIEELCE();
		this.NKJHEMBBEKJ(true);
	}

	// Token: 0x06010488 RID: 66696 RVA: 0x0059031C File Offset: 0x0058E51C
	public IEnumerator WaitFor()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06010489 RID: 66697 RVA: 0x005900EB File Offset: 0x0058E2EB
	public virtual void IDJKNBDKHBD()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.GGILEEHGNFP));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x0601048A RID: 66698 RVA: 0x00590338 File Offset: 0x0058E538
	public void BFHNLICBHGM(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x0601048B RID: 66699 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void BOACMLIHMGP()
	{
	}

	// Token: 0x0601048C RID: 66700 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void MOJOIOOMBND()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x0601048D RID: 66701 RVA: 0x00590378 File Offset: 0x0058E578
	private void EGJLMGLPLLG()
	{
		this.OIGJMFDCHKL();
		this.IENPOLLNILL(true);
	}

	// Token: 0x0601048E RID: 66702 RVA: 0x00590388 File Offset: 0x0058E588
	public IEnumerator PONLOCOEIBC()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x0601048F RID: 66703 RVA: 0x005903A3 File Offset: 0x0058E5A3
	private void GHJBLLBNBBM()
	{
		this.OIGJMFDCHKL();
		this.MBMBALOMJOM(false);
	}

	// Token: 0x06010490 RID: 66704 RVA: 0x005903B2 File Offset: 0x0058E5B2
	public virtual bool KCDOMIJBFLL()
	{
		if (this.IsDone)
		{
			this.MNOCACNOIPB();
			return true;
		}
		return true;
	}

	// Token: 0x06010491 RID: 66705 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void KDCODIEELCE()
	{
	}

	// Token: 0x06010492 RID: 66706 RVA: 0x005903C8 File Offset: 0x0058E5C8
	public IEnumerator LPBMGFBKACK()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06010493 RID: 66707 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void DHEBIKHIIAP()
	{
	}

	// Token: 0x06010494 RID: 66708 RVA: 0x005903E3 File Offset: 0x0058E5E3
	public virtual bool IAJKLKJJKEJ()
	{
		if (this.CMANEFCBEBB())
		{
			this.GLCNIPIBCAA();
			return true;
		}
		return false;
	}

	// Token: 0x06010495 RID: 66709 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void LDALEDAOINM()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010496 RID: 66710 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void BCMNBHHMKOP()
	{
	}

	// Token: 0x06010497 RID: 66711 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void DMMBIAOENGI()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x06010498 RID: 66712 RVA: 0x005903FC File Offset: 0x0058E5FC
	public bool NJPGLBKALNF()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x06010499 RID: 66713 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void CNJDBEKDJPO()
	{
	}

	// Token: 0x0601049A RID: 66714 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void CKLFGEEELFC()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x0601049B RID: 66715 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void OMEMPHADKEL()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x0601049C RID: 66716 RVA: 0x0059043C File Offset: 0x0058E63C
	private void MEJIHBBNOPM()
	{
		this.NHDNCAMNNDP();
		this.NMCILFOEIMF(false);
	}

	// Token: 0x0601049D RID: 66717 RVA: 0x0059044C File Offset: 0x0058E64C
	public void MBMBALOMJOM(bool DPNHODJHGJL)
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		lock (bnnaeccmlcb)
		{
			this.HNHEJMGLAIG = DPNHODJHGJL;
		}
	}

	// Token: 0x0601049E RID: 66718 RVA: 0x0059048C File Offset: 0x0058E68C
	public virtual void DKEHGPPOKEA()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.DAJEGGEMJMA));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x0601049F RID: 66719 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void FFGILCAEJMD()
	{
	}

	// Token: 0x060104A0 RID: 66720 RVA: 0x005904B0 File Offset: 0x0058E6B0
	public bool BDHGIHHGLJF()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x060104A1 RID: 66721 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void KHIALHDDPEP()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104A2 RID: 66722 RVA: 0x005904F0 File Offset: 0x0058E6F0
	public virtual void KCCIEMBMOBA()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.MEJIHBBNOPM));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x060104A3 RID: 66723 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void LCMDHDFOGIE()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104A4 RID: 66724 RVA: 0x005904F0 File Offset: 0x0058E6F0
	public virtual void MGMAOBPPOBJ()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.MEJIHBBNOPM));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x060104A5 RID: 66725 RVA: 0x00590514 File Offset: 0x0058E714
	public IEnumerator KPHILEKHJBL()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x060104A6 RID: 66726 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void GODPOOJFKEF()
	{
	}

	// Token: 0x060104A7 RID: 66727 RVA: 0x0059052F File Offset: 0x0058E72F
	public virtual void BMOFEBKGLFI()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.GBGFCGHHKJL));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x060104A8 RID: 66728 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void IHCBHMKFDMK()
	{
	}

	// Token: 0x060104A9 RID: 66729 RVA: 0x00590553 File Offset: 0x0058E753
	private void DOGDFFCDNPA()
	{
		this.BCPDKGMCFPL();
		this.GAOKHINEGAD(true);
	}

	// Token: 0x060104AA RID: 66730 RVA: 0x00590564 File Offset: 0x0058E764
	public bool MNJBDMBMKCN()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x060104AB RID: 66731 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void OMILIDAPCAJ()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104AC RID: 66732 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void NPDCBGFHHAF()
	{
	}

	// Token: 0x060104AD RID: 66733 RVA: 0x005905A4 File Offset: 0x0058E7A4
	private void OKALLNNKFHD()
	{
		this.CGMJODOBINA();
		this.NKJHEMBBEKJ(true);
	}

	// Token: 0x060104AE RID: 66734 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void GNBIIMFLIPK()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104AF RID: 66735 RVA: 0x005905B4 File Offset: 0x0058E7B4
	public bool JBEOCIOKEJA()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x060104B0 RID: 66736 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void Abort()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104B1 RID: 66737 RVA: 0x005905F4 File Offset: 0x0058E7F4
	public virtual bool BGDONBMDPGM()
	{
		if (this.HNKOKBMLIDI())
		{
			this.IHCBHMKFDMK();
			return true;
		}
		return true;
	}

	// Token: 0x060104B2 RID: 66738 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void CCHMIEFEGFJ()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104B3 RID: 66739 RVA: 0x0059052F File Offset: 0x0058E72F
	public virtual void OKLAJINHPAN()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.GBGFCGHHKJL));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x060104B4 RID: 66740 RVA: 0x0059060A File Offset: 0x0058E80A
	public virtual bool BMODOIJGIOO()
	{
		if (this.BCNIJPGCOOE())
		{
			this.COOHMDACKGM();
			return false;
		}
		return true;
	}

	// Token: 0x060104B5 RID: 66741 RVA: 0x00590620 File Offset: 0x0058E820
	public virtual bool LJIHHJOAJCN()
	{
		if (this.IsDone)
		{
			this.MMKBEAKPBIK();
			return false;
		}
		return false;
	}

	// Token: 0x060104B6 RID: 66742 RVA: 0x00590638 File Offset: 0x0058E838
	public IEnumerator LHCLMIIOCIH()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x060104B7 RID: 66743 RVA: 0x00590654 File Offset: 0x0058E854
	public bool LHLIAPPHDJO()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x060104B8 RID: 66744 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void EAEAHCKIDCP()
	{
	}

	// Token: 0x060104B9 RID: 66745 RVA: 0x00590694 File Offset: 0x0058E894
	private void GGILEEHGNFP()
	{
		this.BCPDKGMCFPL();
		this.JGIBKOGBOCL(false);
	}

	// Token: 0x060104BA RID: 66746 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void MMKBEAKPBIK()
	{
	}

	// Token: 0x060104BB RID: 66747 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void OIGJMFDCHKL()
	{
	}

	// Token: 0x060104BC RID: 66748 RVA: 0x005906A3 File Offset: 0x0058E8A3
	public virtual bool HLDFOJMHKNL()
	{
		if (this.BDHGIHHGLJF())
		{
			this.BOACMLIHMGP();
			return false;
		}
		return true;
	}

	// Token: 0x060104BD RID: 66749 RVA: 0x0059048C File Offset: 0x0058E68C
	public virtual void AEMGPJDJGBJ()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.DAJEGGEMJMA));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x060104BE RID: 66750 RVA: 0x005906BC File Offset: 0x0058E8BC
	public IEnumerator KOOMMNGHMLC()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x060104BF RID: 66751 RVA: 0x005906D7 File Offset: 0x0058E8D7
	public virtual void JECMJNFGBGC()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.KKOOFPMGNBN));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x060104C0 RID: 66752 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void MHMFAABEMEK()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104C1 RID: 66753 RVA: 0x005906FC File Offset: 0x0058E8FC
	public IEnumerator LLEFONJNLCL()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x060104C2 RID: 66754 RVA: 0x00590718 File Offset: 0x0058E918
	public bool HNKOKBMLIDI()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x060104C3 RID: 66755 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void CIFGNLJLCMM()
	{
	}

	// Token: 0x060104C4 RID: 66756 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void HNBCBALPKON()
	{
	}

	// Token: 0x060104C5 RID: 66757 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void GKEEMJLCCHK()
	{
	}

	// Token: 0x060104C6 RID: 66758 RVA: 0x00590758 File Offset: 0x0058E958
	private void FGMPLDOJGOC()
	{
		this.CGMJODOBINA();
		this.MCKEKOENPKO(false);
	}

	// Token: 0x060104C7 RID: 66759 RVA: 0x00590768 File Offset: 0x0058E968
	public IEnumerator KAFAJEJLHFP()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x060104C8 RID: 66760 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void MDEAHHIHOFK()
	{
	}

	// Token: 0x060104C9 RID: 66761 RVA: 0x00590784 File Offset: 0x0058E984
	public bool BCNIJPGCOOE()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x060104CA RID: 66762 RVA: 0x00590228 File Offset: 0x0058E428
	public virtual void NCNPAKFAFOE()
	{
		this.JHBKBOFFBIJ = new Thread(new ThreadStart(this.PELOINOKMIE));
		this.JHBKBOFFBIJ.Start();
	}

	// Token: 0x060104CB RID: 66763 RVA: 0x0002523B File Offset: 0x0002343B
	protected virtual void GLCNIPIBCAA()
	{
	}

	// Token: 0x060104CC RID: 66764 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void JEJABONIBAN()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104CD RID: 66765 RVA: 0x0058FBFA File Offset: 0x0058DDFA
	public virtual void BKEICCPCDIO()
	{
		this.JHBKBOFFBIJ.Abort();
	}

	// Token: 0x060104CF RID: 66767 RVA: 0x00590804 File Offset: 0x0058EA04
	public IEnumerator IEBGEEIDKKE()
	{
		while (!this.Update())
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x060104D0 RID: 66768 RVA: 0x00590820 File Offset: 0x0058EA20
	public bool BFANLENFGBJ()
	{
		object bnnaeccmlcb = this.BNNAECCMLCB;
		bool hnhejmglaig;
		lock (bnnaeccmlcb)
		{
			hnhejmglaig = this.HNHEJMGLAIG;
		}
		return hnhejmglaig;
	}

	// Token: 0x060104D1 RID: 66769 RVA: 0x00590860 File Offset: 0x0058EA60
	private void EOEBGHHLPCD()
	{
		this.JCFLIHMPFKN();
		this.IsDone = true;
	}

	// Token: 0x04001CA7 RID: 7335
	private bool HNHEJMGLAIG;

	// Token: 0x04001CA8 RID: 7336
	private object BNNAECCMLCB = new object();

	// Token: 0x04001CA9 RID: 7337
	private Thread JHBKBOFFBIJ;
}
