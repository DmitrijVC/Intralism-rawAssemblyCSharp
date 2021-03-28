using System;

// Token: 0x02000380 RID: 896
public class PlayMapGoal : ChallengeGoal
{
	// Token: 0x0600C654 RID: 50772 RVA: 0x004817FB File Offset: 0x0047F9FB
	public virtual void JBDLFJKOFPG()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.NCEHIAIAMLA;
		base.DDOBENFDOKL();
	}

	// Token: 0x0600C655 RID: 50773 RVA: 0x00481819 File Offset: 0x0047FA19
	private void MLIIFJEFIIK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.BPNMOLIBPNI()))
		{
			base.MMFPGBOEKHL(false);
		}
	}

	// Token: 0x0600C656 RID: 50774 RVA: 0x00481847 File Offset: 0x0047FA47
	public virtual void EBHMFAMPLHD()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.NCEHIAIAMLA));
		base.OnCompleted();
	}

	// Token: 0x0600C657 RID: 50775 RVA: 0x00481865 File Offset: 0x0047FA65
	public virtual void ILNLFGCBIGO()
	{
		base.IJLBKALOBNO();
		base.PNACFCEIEHH(Singleton<SaveSystem>.Instance.DHFOFEJPGPP(base.CKOFDGAJCFF() + "_TimeX", 261f, null));
	}

	// Token: 0x0600C658 RID: 50776 RVA: 0x00481893 File Offset: 0x0047FA93
	private void KJEFEBFKILK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.BPNMOLIBPNI()))
		{
			base.FENBIOJOANF(true);
		}
	}

	// Token: 0x0600C659 RID: 50777 RVA: 0x004818C1 File Offset: 0x0047FAC1
	public virtual void ILOBNHKDGPG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.NCEHIAIAMLA));
		Singleton<GameManager>.Instance.OnFinishedMap += this.MLIIFJEFIIK;
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C65A RID: 50778 RVA: 0x004818FE File Offset: 0x0047FAFE
	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(base.PHPLKBPIMIH() + ".GoalProgress", base.GoalProgress, null);
	}

	// Token: 0x0600C65B RID: 50779 RVA: 0x00481927 File Offset: 0x0047FB27
	private void FPIPAAEFJAD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.HHFDPIMFHBB()))
		{
			base.NJKJDOJBHAB(false);
		}
	}

	// Token: 0x0600C65C RID: 50780 RVA: 0x00481955 File Offset: 0x0047FB55
	public virtual void BLGHPBBJABH(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= this.BCOBPALFKMA;
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.LIIGHENCIFC));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C65D RID: 50781 RVA: 0x00481992 File Offset: 0x0047FB92
	public override void DOPPMCDLPBE()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(base.PFIOEOGECFG() + "{0:0} day{1}, ", base.GoalProgress, null);
	}

	// Token: 0x0600C65E RID: 50782 RVA: 0x004819BB File Offset: 0x0047FBBB
	public virtual void NHDCGONGILN()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.HOGJGGGDPDD));
		base.OnCompleted();
	}

	// Token: 0x0600C65F RID: 50783 RVA: 0x004819D9 File Offset: 0x0047FBD9
	public virtual void GMPAPODODHM()
	{
		base.NAHLBHOLNCG();
		base.JMMJKHLAIMI(Singleton<SaveSystem>.Instance.AKHCHNPPNIB(base.CKOFDGAJCFF() + " | Level: ", 1123f, null));
	}

	// Token: 0x0600C660 RID: 50784 RVA: 0x00481A07 File Offset: 0x0047FC07
	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= this.HOGJGGGDPDD;
		Singleton<GameManager>.Instance.OnFinishedMap += this.HOGJGGGDPDD;
		this.LoadProgress();
	}

	// Token: 0x0600C661 RID: 50785 RVA: 0x00481A44 File Offset: 0x0047FC44
	public virtual void HOPMBFHOAII()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.KJDFGNMKMCP;
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C662 RID: 50786 RVA: 0x00481A62 File Offset: 0x0047FC62
	public virtual void JKPEHIMHKDI()
	{
		base.DKHLEEPCLEL();
		base.EHAMFOBIPEO(Singleton<SaveSystem>.Instance.NPNOOLFEDKN(base.FDHGPNBJKMP() + "achievements.21.progress", 1220f, null));
	}

	// Token: 0x0600C663 RID: 50787 RVA: 0x00481A90 File Offset: 0x0047FC90
	private void OGCLNFHJAHE(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.HKJHJHOEPOI()))
		{
			base.MKFDADCGLNN(true);
		}
	}

	// Token: 0x0600C664 RID: 50788 RVA: 0x00481ABE File Offset: 0x0047FCBE
	public virtual void DMLDCKLBHIB()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.MLIIFJEFIIK;
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C665 RID: 50789 RVA: 0x00481ADC File Offset: 0x0047FCDC
	private void HKIMIGKDJML(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			base.IsComplete = false;
		}
	}

	// Token: 0x0600C666 RID: 50790 RVA: 0x00481B0A File Offset: 0x0047FD0A
	public override void AFFLBJKDKMD()
	{
		base.IIBGJNGDCGB();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(base.DIDHNLABPNG() + "Scene", base.GoalProgress, null);
	}

	// Token: 0x0600C667 RID: 50791 RVA: 0x00481B33 File Offset: 0x0047FD33
	public virtual void CHIOGDOBEDO()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.KJDFGNMKMCP));
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C668 RID: 50792 RVA: 0x00481B51 File Offset: 0x0047FD51
	public override void LoadProgress()
	{
		base.LoadProgress();
		base.GoalProgress = Singleton<SaveSystem>.Instance.GetFloat(base.PHPLKBPIMIH() + ".GoalProgress", 0f, null);
	}

	// Token: 0x0600C669 RID: 50793 RVA: 0x00481B7F File Offset: 0x0047FD7F
	public virtual void KBKFJCIEPLO()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(base.FDHGPNBJKMP() + "inventory.selected.", base.GoalProgress, null);
	}

	// Token: 0x0600C66A RID: 50794 RVA: 0x00481BA8 File Offset: 0x0047FDA8
	public virtual void BKAEKANBIPH()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(base.DIDHNLABPNG() + "Bad parameters for set! Use <language>", base.GoalProgress, null);
	}

	// Token: 0x0600C66B RID: 50795 RVA: 0x00481BD1 File Offset: 0x0047FDD1
	public virtual void HGHHJFLDOEK()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.SetFloat(base.PFIOEOGECFG() + "checkpoint", base.GoalProgress, null);
	}

	// Token: 0x0600C66C RID: 50796 RVA: 0x00481BFA File Offset: 0x0047FDFA
	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.HOGJGGGDPDD;
		base.OnCompleted();
	}

	// Token: 0x0600C66D RID: 50797 RVA: 0x00481C18 File Offset: 0x0047FE18
	public virtual void FJMBAIAJIOC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.NCEHIAIAMLA));
		Singleton<GameManager>.Instance.PGNNMANJJAC(new GameManager.FinishedMapEvent(this.MGPGFAHEDGM));
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C66E RID: 50798 RVA: 0x00481C55 File Offset: 0x0047FE55
	public virtual void FHMNNKODFEP()
	{
		base.DKHLEEPCLEL();
		base.JMMJKHLAIMI(Singleton<SaveSystem>.Instance.GetFloat(base.PHPLKBPIMIH() + "player.licenceaccepted", 663f, null));
	}

	// Token: 0x0600C66F RID: 50799 RVA: 0x00481C83 File Offset: 0x0047FE83
	private void OGIIODFJAHD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.HHFDPIMFHBB()))
		{
			base.MKFDADCGLNN(true);
		}
	}

	// Token: 0x0600C670 RID: 50800 RVA: 0x00481CB1 File Offset: 0x0047FEB1
	public virtual void CHCDBHJILJB()
	{
		base.NAHLBHOLNCG();
		base.JMMJKHLAIMI(Singleton<SaveSystem>.Instance.MFNCMBBPJPA(base.PFIOEOGECFG() + "[PowerUp]", 516f, null));
	}

	// Token: 0x0600C671 RID: 50801 RVA: 0x00481CDF File Offset: 0x0047FEDF
	private void KGGEMDGNLGK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.POMDFLMKAJF()))
		{
			base.EADKFNLBJLO(true);
		}
	}

	// Token: 0x0600C672 RID: 50802 RVA: 0x00481D0D File Offset: 0x0047FF0D
	public virtual void LGKFHOAKNEL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= this.LFMJIMKMBHP;
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.LFMJIMKMBHP));
		this.IJLBKALOBNO();
	}

	// Token: 0x0600C673 RID: 50803 RVA: 0x00481D4A File Offset: 0x0047FF4A
	public virtual void MBLDJHOBIMG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.KJEFEBFKILK));
		Singleton<GameManager>.Instance.PGNNMANJJAC(new GameManager.FinishedMapEvent(this.KJDFGNMKMCP));
		this.CCGAPNPGAOL();
	}

	// Token: 0x0600C674 RID: 50804 RVA: 0x00481D87 File Offset: 0x0047FF87
	private void HOGJGGGDPDD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			base.IsComplete = true;
		}
	}

	// Token: 0x0600C675 RID: 50805 RVA: 0x00481DB5 File Offset: 0x0047FFB5
	public virtual void NGCGIHIKOLA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.KGGEMDGNLGK));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.BCOBPALFKMA));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C676 RID: 50806 RVA: 0x00481DF2 File Offset: 0x0047FFF2
	public virtual void ICAAJACIAPH()
	{
		base.CCGAPNPGAOL();
		base.OFPKLCAICJA(Singleton<SaveSystem>.Instance.NPNOOLFEDKN(base.FDHGPNBJKMP() + "_Colored", 231f, null));
	}

	// Token: 0x0600C678 RID: 50808 RVA: 0x00481E28 File Offset: 0x00480028
	private void OANNPFHDFJE(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			base.NDONNLMLNHH(false);
		}
	}

	// Token: 0x0600C679 RID: 50809 RVA: 0x00481E56 File Offset: 0x00480056
	public virtual void LPLDOKNALPE()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.SetFloat(base.FDHGPNBJKMP() + "_ScreenResolution", base.GoalProgress, null);
	}

	// Token: 0x0600C67A RID: 50810 RVA: 0x00481E7F File Offset: 0x0048007F
	private void MGPGFAHEDGM(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.NOJGGCLPPAM))
		{
			base.MKFDADCGLNN(true);
		}
	}

	// Token: 0x0600C67B RID: 50811 RVA: 0x00481EAD File Offset: 0x004800AD
	public virtual void FJJFCKBBJIL()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(base.FDHGPNBJKMP() + ". Client is not the MasterClient in this room.", base.GoalProgress, null);
	}

	// Token: 0x0600C67C RID: 50812 RVA: 0x00481ED6 File Offset: 0x004800D6
	public virtual void OOBKIGDLJLO(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.BCOBPALFKMA));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.OANNPFHDFJE));
		this.LoadProgress();
	}

	// Token: 0x0600C67D RID: 50813 RVA: 0x00481F13 File Offset: 0x00480113
	public virtual void FHPDJMHPLJA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.LIIGHENCIFC));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.OGCLNFHJAHE));
		this.CCGAPNPGAOL();
	}

	// Token: 0x0600C67E RID: 50814 RVA: 0x00481F50 File Offset: 0x00480150
	public virtual void KEJGDALCJHP()
	{
		base.CCGAPNPGAOL();
		base.PNACFCEIEHH(Singleton<SaveSystem>.Instance.DHFOFEJPGPP(base.PNLACKIPGLD() + "closed", 969f, null));
	}

	// Token: 0x0600C67F RID: 50815 RVA: 0x00481F7E File Offset: 0x0048017E
	public override void IJLBKALOBNO()
	{
		base.DKHLEEPCLEL();
		base.PNACFCEIEHH(Singleton<SaveSystem>.Instance.OLHIEOKMOAK(base.CKOFDGAJCFF() + "_Far", 893f, null));
	}

	// Token: 0x0600C680 RID: 50816 RVA: 0x00481FAC File Offset: 0x004801AC
	public virtual void PLCBPLLCNIC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.LIIGHENCIFC));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.HOGJGGGDPDD));
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C681 RID: 50817 RVA: 0x00481FE9 File Offset: 0x004801E9
	private void NCEHIAIAMLA(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			base.NJKJDOJBHAB(true);
		}
	}

	// Token: 0x0600C682 RID: 50818 RVA: 0x00482017 File Offset: 0x00480217
	private void LFMJIMKMBHP(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.HKJHJHOEPOI()))
		{
			base.MKFDADCGLNN(false);
		}
	}

	// Token: 0x0600C683 RID: 50819 RVA: 0x00482045 File Offset: 0x00480245
	public virtual void GLKDDIIOHDF()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(base.PFIOEOGECFG() + "_SmoothEnd", base.GoalProgress, null);
	}

	// Token: 0x0600C684 RID: 50820 RVA: 0x0048206E File Offset: 0x0048026E
	public virtual void KAHKKLGKLLF()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(base.CKOFDGAJCFF() + "Screenshots only supported in PlayMode", base.GoalProgress, null);
	}

	// Token: 0x0600C685 RID: 50821 RVA: 0x00482097 File Offset: 0x00480297
	private void GDGBPNPJOCK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.MFLLPADMCIN()))
		{
			base.NJKJDOJBHAB(true);
		}
	}

	// Token: 0x0600C686 RID: 50822 RVA: 0x004820C5 File Offset: 0x004802C5
	public virtual void FNJFHBBAJNO(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.LIIGHENCIFC));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.MLIIFJEFIIK));
		this.AFGLHMCLJJN();
	}

	// Token: 0x0600C687 RID: 50823 RVA: 0x00482102 File Offset: 0x00480302
	private void LIIGHENCIFC(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.OIBFKLBKDIB()))
		{
			base.EADKFNLBJLO(false);
		}
	}

	// Token: 0x0600C688 RID: 50824 RVA: 0x00482130 File Offset: 0x00480330
	public virtual void NNMICPOJGPD()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.SetFloat(base.DIDHNLABPNG() + "Value", base.GoalProgress, null);
	}

	// Token: 0x0600C689 RID: 50825 RVA: 0x00482159 File Offset: 0x00480359
	public virtual void MMKBPJFMFFH()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(base.PNLACKIPGLD() + "Up", base.GoalProgress, null);
	}

	// Token: 0x0600C68A RID: 50826 RVA: 0x00482182 File Offset: 0x00480382
	public virtual void OOKHGEKNHHI()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.MGPGFAHEDGM));
		base.DDOBENFDOKL();
	}

	// Token: 0x0600C68B RID: 50827 RVA: 0x004821A0 File Offset: 0x004803A0
	public virtual void GFNFINKABFD()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(base.PFIOEOGECFG() + "/", base.GoalProgress, null);
	}

	// Token: 0x0600C68C RID: 50828 RVA: 0x004821C9 File Offset: 0x004803C9
	public virtual void KHMFEHEPGAM(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.OANNPFHDFJE));
		Singleton<GameManager>.Instance.OnFinishedMap += this.KGGEMDGNLGK;
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C68D RID: 50829 RVA: 0x00482206 File Offset: 0x00480406
	public virtual void NHFICNGICBA()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(base.PHPLKBPIMIH() + "Object ID. Case-Sensitive", base.GoalProgress, null);
	}

	// Token: 0x0600C68E RID: 50830 RVA: 0x0048222F File Offset: 0x0048042F
	private void KJDFGNMKMCP(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.HKJHJHOEPOI()))
		{
			base.MMFPGBOEKHL(true);
		}
	}

	// Token: 0x0600C68F RID: 50831 RVA: 0x0048225D File Offset: 0x0048045D
	public virtual void BCLMEEAMAEB(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.LIIGHENCIFC));
		Singleton<GameManager>.Instance.PGNNMANJJAC(new GameManager.FinishedMapEvent(this.OGCLNFHJAHE));
		this.AFGLHMCLJJN();
	}

	// Token: 0x0600C690 RID: 50832 RVA: 0x0048229A File Offset: 0x0048049A
	public virtual void NEPIKEBNOHI()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(base.PHPLKBPIMIH() + "/", base.GoalProgress, null);
	}

	// Token: 0x0600C691 RID: 50833 RVA: 0x004822C3 File Offset: 0x004804C3
	private void JFJHHCGFBOO(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.OIBFKLBKDIB()))
		{
			base.MMFPGBOEKHL(false);
		}
	}

	// Token: 0x0600C692 RID: 50834 RVA: 0x004822F1 File Offset: 0x004804F1
	public virtual void PGPMPNANPLM()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(base.FDHGPNBJKMP() + ").", base.GoalProgress, null);
	}

	// Token: 0x0600C693 RID: 50835 RVA: 0x0048231A File Offset: 0x0048051A
	public virtual void GHGHILGEOJE()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(base.FDHGPNBJKMP() + "EventSystem", base.GoalProgress, null);
	}

	// Token: 0x0600C694 RID: 50836 RVA: 0x00482343 File Offset: 0x00480543
	private void BCOBPALFKMA(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.POMDFLMKAJF()))
		{
			base.NJKJDOJBHAB(true);
		}
	}

	// Token: 0x0600C695 RID: 50837 RVA: 0x00482371 File Offset: 0x00480571
	public virtual void FCCOFGIGGJK()
	{
		base.CCGAPNPGAOL();
		base.OFPKLCAICJA(Singleton<SaveSystem>.Instance.MFNCMBBPJPA(base.PFIOEOGECFG() + "#rt", 67f, null));
	}

	// Token: 0x0600C696 RID: 50838 RVA: 0x0048239F File Offset: 0x0048059F
	public virtual void OCFEDHEGHAK()
	{
		base.LoadProgress();
		base.PNACFCEIEHH(Singleton<SaveSystem>.Instance.AKHCHNPPNIB(base.PHPLKBPIMIH() + "Reading preview file failed!: \"{0}\"", 776f, null));
	}

	// Token: 0x0600C697 RID: 50839 RVA: 0x004823CD File Offset: 0x004805CD
	public virtual void AKDBKOIHBND()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.GDGBPNPJOCK;
		base.DDOBENFDOKL();
	}
}
