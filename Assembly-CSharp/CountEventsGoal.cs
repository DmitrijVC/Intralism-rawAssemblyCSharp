using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x02000382 RID: 898
public class CountEventsGoal : ChallengeGoal
{
	// Token: 0x0600C719 RID: 50969 RVA: 0x00484B88 File Offset: 0x00482D88
	private void LILJBEOPBKP(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.JMMJKHLAIMI(this.OFIFLHGIMAJ());
		}
	}

	// Token: 0x0600C71A RID: 50970 RVA: 0x00484BD4 File Offset: 0x00482DD4
	public override void LoadProgress()
	{
		base.LoadProgress();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(base.PHPLKBPIMIH() + ".completedCount", 0, null);
		base.GoalProgress = this.CAOJDEFHMAG();
	}

	// Token: 0x0600C71B RID: 50971 RVA: 0x00484C0A File Offset: 0x00482E0A
	public virtual void MPDGNIEDBCM()
	{
		Singleton<GameManager>.Instance.AABEGAMPOLA(new GameManager.PlayerGameEvent(this.LILJBEOPBKP));
		base.DDOBENFDOKL();
	}

	// Token: 0x0600C71C RID: 50972 RVA: 0x00484C28 File Offset: 0x00482E28
	public virtual void KMEFHCDNDNF()
	{
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP(base.DIDHNLABPNG() + "_TimeX", null);
		base.Reset();
	}

	// Token: 0x0600C71D RID: 50973 RVA: 0x00484C4B File Offset: 0x00482E4B
	public virtual void KAHKKLGKLLF()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.SetInt(base.CKOFDGAJCFF() + "settings.crosshairopacity", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C71E RID: 50974 RVA: 0x00484C74 File Offset: 0x00482E74
	public virtual void MGLJAMJLIEL()
	{
		base.AFGLHMCLJJN();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.ANECPPFPKAP(base.CKOFDGAJCFF() + "_TimeX", 1, null);
		base.OFPKLCAICJA(this.BCCHCOFCMMM());
	}

	// Token: 0x0600C71F RID: 50975 RVA: 0x00484CAA File Offset: 0x00482EAA
	public override void Reset()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.PHPLKBPIMIH() + ".completedCount", null);
		base.Reset();
	}

	// Token: 0x0600C720 RID: 50976 RVA: 0x00484CCD File Offset: 0x00482ECD
	public virtual void KNNOEGLLDAN()
	{
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(base.DIDHNLABPNG() + "_ScreenResolution", null);
		base.EEBGCGFNELO();
	}

	// Token: 0x0600C721 RID: 50977 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float PMLACFKHAIP()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C722 RID: 50978 RVA: 0x00484D04 File Offset: 0x00482F04
	public virtual void BJKPNPDKIIL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			(char)-119
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_ScreenResolution", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.OnGameEvent -= this.NLPFNLACBHB;
		Singleton<GameManager>.Instance.OnGameEvent += this.NNFFNFNKFOF;
		this.LoadProgress();
	}

	// Token: 0x0600C723 RID: 50979 RVA: 0x00484D98 File Offset: 0x00482F98
	public virtual void BFJJMGFNGMN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-27;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("CameraFilterPack_Paper4", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.AABEGAMPOLA(new GameManager.PlayerGameEvent(this.HJFDNOHJMGN));
		Singleton<GameManager>.Instance.MIEFLJDAOCA(new GameManager.PlayerGameEvent(this.NLPFNLACBHB));
		this.JJPHFPDNDEC();
	}

	// Token: 0x0600C724 RID: 50980 RVA: 0x00484E29 File Offset: 0x00483029
	public virtual void CAPPKCBFILL()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.PHPLKBPIMIH() + ".lastCheckpoint.playerdistance", null);
		base.EEBGCGFNELO();
	}

	// Token: 0x0600C725 RID: 50981 RVA: 0x00484E4C File Offset: 0x0048304C
	private void HJFDNOHJMGN(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.NOCNNNKPEGI());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.EHAMFOBIPEO(this.GLLIALLLLLN());
		}
	}

	// Token: 0x0600C726 RID: 50982 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float OFIFLHGIMAJ()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C727 RID: 50983 RVA: 0x00484E98 File Offset: 0x00483098
	public virtual void HDLJGOMCLEK()
	{
		base.CCGAPNPGAOL();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(base.FDHGPNBJKMP() + "menu.enableselectormusic", 1, null);
		base.GoalProgress = this.DJLHHDEGBKK();
	}

	// Token: 0x0600C728 RID: 50984 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float PDPIKAEEPKI()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C729 RID: 50985 RVA: 0x00484ECE File Offset: 0x004830CE
	public override void AFGLHMCLJJN()
	{
		base.CCGAPNPGAOL();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(base.PHPLKBPIMIH() + "ERROR: Preview file name in modName.workshop.json doesn't match any file", 1, null);
		base.ENHBNIOEKLF(this.DLGFNCGHLPK());
	}

	// Token: 0x0600C72A RID: 50986 RVA: 0x00484F04 File Offset: 0x00483104
	public virtual void OKFNEFJMLJI()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA(base.CKOFDGAJCFF() + "\\n", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C72B RID: 50987 RVA: 0x00484F2D File Offset: 0x0048312D
	public virtual void KHNGJNBKHOK()
	{
		base.DKHLEEPCLEL();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.ANECPPFPKAP(base.PHPLKBPIMIH() + "CameraFilterPack/TV_BrokenGlass", 0, null);
		base.OFPKLCAICJA(this.PEDNHBAJGPP());
	}

	// Token: 0x0600C72C RID: 50988 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float DJLHHDEGBKK()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C72D RID: 50989 RVA: 0x00484F63 File Offset: 0x00483163
	public override void DOPPMCDLPBE()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(base.PHPLKBPIMIH() + "LevelEditor/CustomEventEditor-Text", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C72E RID: 50990 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float GLLIALLLLLN()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C72F RID: 50991 RVA: 0x00484F8C File Offset: 0x0048318C
	public virtual void PMDFDPGNOOD()
	{
		Singleton<GameManager>.Instance.IGIDKGGKODK(new GameManager.PlayerGameEvent(this.AEOMHPDDOGA));
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C730 RID: 50992 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float PAGNCJJOABL()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C731 RID: 50993 RVA: 0x00484FAC File Offset: 0x004831AC
	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			','
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join(",", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.OnGameEvent -= this.OKLHDAEHLKC;
		Singleton<GameManager>.Instance.OnGameEvent += this.OKLHDAEHLKC;
		this.LoadProgress();
	}

	// Token: 0x0600C732 RID: 50994 RVA: 0x0048503D File Offset: 0x0048323D
	public virtual void LOKKIADJAFE()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(base.CKOFDGAJCFF() + "/", null);
		base.LIMBEFBJNPL();
	}

	// Token: 0x0600C733 RID: 50995 RVA: 0x00485060 File Offset: 0x00483260
	public virtual void AFMPCOFDHJI()
	{
		Singleton<GameManager>.Instance.BLOKNDEOACI(new GameManager.PlayerGameEvent(this.OKLHDAEHLKC));
		base.DDOBENFDOKL();
	}

	// Token: 0x0600C734 RID: 50996 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float DLGFNCGHLPK()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C735 RID: 50997 RVA: 0x0048507E File Offset: 0x0048327E
	public virtual void CMHMIMCABKA()
	{
		Singleton<GameManager>.Instance.AABEGAMPOLA(new GameManager.PlayerGameEvent(this.NNFFNFNKFOF));
		base.OnCompleted();
	}

	// Token: 0x0600C736 RID: 50998 RVA: 0x0048509C File Offset: 0x0048329C
	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetInt(base.PHPLKBPIMIH() + ".completedCount", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C737 RID: 50999 RVA: 0x004850C5 File Offset: 0x004832C5
	public virtual void GIHINJKCEHO()
	{
		base.CCGAPNPGAOL();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(base.CKOFDGAJCFF() + "<command>", 0, null);
		base.NHCKOAMBEDE(this.PDPIKAEEPKI());
	}

	// Token: 0x0600C738 RID: 51000 RVA: 0x004850FB File Offset: 0x004832FB
	public virtual void APJPLEFJFJP()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(base.DIDHNLABPNG() + "_PColor2", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C739 RID: 51001 RVA: 0x00485124 File Offset: 0x00483324
	public virtual void JFHDBGECJEI()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA(base.PNLACKIPGLD() + "player.xp", this.HGMKPHILBMM, null);
	}

	// Token: 0x0600C73A RID: 51002 RVA: 0x0048514D File Offset: 0x0048334D
	public virtual void GCMLEEHGBPA()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.PNLACKIPGLD() + "_ScreenResolution", null);
		base.EEBGCGFNELO();
	}

	// Token: 0x0600C73B RID: 51003 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float ILKGIJEBJML()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C73C RID: 51004 RVA: 0x00485170 File Offset: 0x00483370
	private void NLPFNLACBHB(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.NEDLDBBIOGI(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.PNACFCEIEHH(this.DJLHHDEGBKK());
		}
	}

	// Token: 0x0600C73D RID: 51005 RVA: 0x004851BC File Offset: 0x004833BC
	public virtual void EHHOGOOJCHO()
	{
		base.DKHLEEPCLEL();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(base.PHPLKBPIMIH() + "_BlurRadius4", 1, null);
		base.GoalProgress = this.PEDNHBAJGPP();
	}

	// Token: 0x0600C73E RID: 51006 RVA: 0x004851F4 File Offset: 0x004833F4
	private void AEOMHPDDOGA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.OFPKLCAICJA(this.EBPEPGPPLLE());
		}
	}

	// Token: 0x0600C73F RID: 51007 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float GCBBPGINAGC()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C740 RID: 51008 RVA: 0x00485240 File Offset: 0x00483440
	public virtual void IDOFOCOFEIE()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.FDHGPNBJKMP() + "CameraFilterPack/Drawing_Paper", null);
		base.EEBGCGFNELO();
	}

	// Token: 0x0600C741 RID: 51009 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float EBPEPGPPLLE()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C742 RID: 51010 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float PEDNHBAJGPP()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C743 RID: 51011 RVA: 0x00485264 File Offset: 0x00483464
	private void GDAKPKIBLOA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.NOCNNNKPEGI());
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.GoalProgress = this.GCBBPGINAGC();
		}
	}

	// Token: 0x0600C744 RID: 51012 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float CAOJDEFHMAG()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C746 RID: 51014 RVA: 0x004852C3 File Offset: 0x004834C3
	public virtual void KMHCLFLINIO()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.PHPLKBPIMIH() + "color", null);
		base.EEBGCGFNELO();
	}

	// Token: 0x0600C747 RID: 51015 RVA: 0x004852E8 File Offset: 0x004834E8
	private void OKLHDAEHLKC(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.GoalProgress = this.CAOJDEFHMAG();
		}
	}

	// Token: 0x0600C748 RID: 51016 RVA: 0x00485334 File Offset: 0x00483534
	public virtual void KIBIPGFCBKO()
	{
		base.JJPHFPDNDEC();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(base.PHPLKBPIMIH() + "Found best region: '", 0, null);
		base.GoalProgress = this.BCCHCOFCMMM();
	}

	// Token: 0x0600C749 RID: 51017 RVA: 0x0048536C File Offset: 0x0048356C
	public virtual void GIOJOELJFBD(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '$';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_Linecount", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.None);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.IGIDKGGKODK(new GameManager.PlayerGameEvent(this.OKLHDAEHLKC));
		Singleton<GameManager>.Instance.MIEFLJDAOCA(new GameManager.PlayerGameEvent(this.OKLHDAEHLKC));
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C74A RID: 51018 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float CLKJBPKAGFL()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C74B RID: 51019 RVA: 0x00485400 File Offset: 0x00483600
	private void NNFFNFNKFOF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.KNBBEFDHELF());
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM += 0;
			base.JMMJKHLAIMI(this.OFIFLHGIMAJ());
		}
	}

	// Token: 0x0600C74C RID: 51020 RVA: 0x00484CF0 File Offset: 0x00482EF0
	private float BCCHCOFCMMM()
	{
		return (float)this.HGMKPHILBMM / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C74D RID: 51021 RVA: 0x0048544C File Offset: 0x0048364C
	public virtual void MBBHOJMLCBC()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(base.DIDHNLABPNG() + "_Value4", null);
		base.JGMBGCOFCJI();
	}

	// Token: 0x0600C74E RID: 51022 RVA: 0x00485470 File Offset: 0x00483670
	private void LNIAJININIG(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.NEDLDBBIOGI(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(this.CBMKNPLELGP))
		{
			this.HGMKPHILBMM++;
			base.JMMJKHLAIMI(this.CAOJDEFHMAG());
		}
	}

	// Token: 0x0600C74F RID: 51023 RVA: 0x004854BC File Offset: 0x004836BC
	public virtual void HMBLLAECOIL()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.PHPLKBPIMIH() + "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", null);
		base.DGNLHKLGAMC();
	}

	// Token: 0x0600C750 RID: 51024 RVA: 0x004854E0 File Offset: 0x004836E0
	public virtual void FMEGNMDMAAJ(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = '\u0015';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("lobby '{0}'[{1}]", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		Singleton<GameManager>.Instance.OnGameEvent -= this.LILJBEOPBKP;
		Singleton<GameManager>.Instance.OnGameEvent += this.HJFDNOHJMGN;
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C751 RID: 51025 RVA: 0x00485571 File Offset: 0x00483771
	public virtual void MAHMAEOANMD()
	{
		base.IJLBKALOBNO();
		this.HGMKPHILBMM = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(base.PNLACKIPGLD() + "FinalScoreSmallText", 1, null);
		base.ENHBNIOEKLF(this.PAGNCJJOABL());
	}

	// Token: 0x0600C752 RID: 51026 RVA: 0x004855A7 File Offset: 0x004837A7
	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= this.OKLHDAEHLKC;
		base.OnCompleted();
	}

	// Token: 0x04001744 RID: 5956
	private int MHLPNLMDILP;

	// Token: 0x04001745 RID: 5957
	private string CBMKNPLELGP = "true";

	// Token: 0x04001746 RID: 5958
	private int HGMKPHILBMM;
}
