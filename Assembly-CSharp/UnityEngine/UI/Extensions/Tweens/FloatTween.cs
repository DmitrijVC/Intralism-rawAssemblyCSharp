using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions.Tweens
{
	// Token: 0x02000244 RID: 580
	public struct FloatTween : EDNENBIDEGJ
	{
		// Token: 0x06008BFA RID: 35834 RVA: 0x00308350 File Offset: 0x00306550
		public bool DMLNCLFECLC()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x00308358 File Offset: 0x00306558
		public float DKNKOHKOJKE()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008BFC RID: 35836 RVA: 0x00308358 File Offset: 0x00306558
		public float DOIAKMHHHJC()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x00308360 File Offset: 0x00306560
		public float GDNPMFDICID()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x00308368 File Offset: 0x00306568
		public bool HCGLDAIFPBB()
		{
			return this.ICAHKGKPENF == null;
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x00308350 File Offset: 0x00306550
		public bool GetIgnoreTimescale()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x00308360 File Offset: 0x00306560
		public float NMIAOMPEGPA()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x00308376 File Offset: 0x00306576
		public void PODPKLDMNKN(float NMJBJAOPJBP)
		{
			if (!this.ValidTarget())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x003083A1 File Offset: 0x003065A1
		public void KHDIFMALENP()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x003083B9 File Offset: 0x003065B9
		public void PGCFILIOJAF(bool DPNHODJHGJL)
		{
			this.LCIOMPDACPD = DPNHODJHGJL;
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x003083C2 File Offset: 0x003065C2
		public float EICFILMDOGC()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x00308358 File Offset: 0x00306558
		public float BCNGILCBCIA()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x003083B9 File Offset: 0x003065B9
		public void IGHJOGHHDEK(bool DPNHODJHGJL)
		{
			this.LCIOMPDACPD = DPNHODJHGJL;
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x003083CA File Offset: 0x003065CA
		public void KOOEAMPNCKA(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x003083D3 File Offset: 0x003065D3
		public void ECEDLCKNAHL(float NMJBJAOPJBP)
		{
			if (!this.PONDLLDMNJP())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x003083A1 File Offset: 0x003065A1
		public void BKCLGENOCGM()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C0A RID: 35850 RVA: 0x003083C2 File Offset: 0x003065C2
		public float CFFCNIOOCOG()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x003083CA File Offset: 0x003065CA
		public void MOMGMGLANEK(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x00308350 File Offset: 0x00306550
		public bool HPIKJPDKIMF()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x003083FE File Offset: 0x003065FE
		public void DCIJGBDHMMH(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x00308360 File Offset: 0x00306560
		public float HDPCBPJPNAJ()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C0F RID: 35855 RVA: 0x00308350 File Offset: 0x00306550
		public bool BCPFHEEBBBI()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x003083CA File Offset: 0x003065CA
		public void NELMOPMEFPA(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x003083FE File Offset: 0x003065FE
		public void DJMKLNHLJHJ(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x00308422 File Offset: 0x00306622
		public void CEIGHGPMHID(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C13 RID: 35859 RVA: 0x00308446 File Offset: 0x00306646
		public void GOKNNGFPFDF(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C14 RID: 35860 RVA: 0x003083FE File Offset: 0x003065FE
		public void DKMJMJCEGCI(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x00308358 File Offset: 0x00306558
		public float GCKEHKJOLKJ()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x00308422 File Offset: 0x00306622
		public void MHIPCJOACFL(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C17 RID: 35863 RVA: 0x003083FE File Offset: 0x003065FE
		public void GGFHHDNEPHD(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06008C5F RID: 35935 RVA: 0x00308360 File Offset: 0x00306560
		// (set) Token: 0x06008C18 RID: 35864 RVA: 0x0030844F File Offset: 0x0030664F
		public float startFloat
		{
			get
			{
				return this.KPFNNMMEGGF;
			}
			set
			{
				this.KPFNNMMEGGF = value;
			}
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x003083C2 File Offset: 0x003065C2
		public float MCBKHBPEAED()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C1A RID: 35866 RVA: 0x003083C2 File Offset: 0x003065C2
		public float PJALAAIBFNA()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C1B RID: 35867 RVA: 0x003083B9 File Offset: 0x003065B9
		public void KCBDDBPIOAP(bool DPNHODJHGJL)
		{
			this.LCIOMPDACPD = DPNHODJHGJL;
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x003083A1 File Offset: 0x003065A1
		public void Finished()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C1D RID: 35869 RVA: 0x00308350 File Offset: 0x00306550
		public bool GDJFBMIPNKA()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x00308446 File Offset: 0x00306646
		public void OMMLOPBCJHF(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C1F RID: 35871 RVA: 0x003083B9 File Offset: 0x003065B9
		public void DKAILNKOMMB(bool DPNHODJHGJL)
		{
			this.LCIOMPDACPD = DPNHODJHGJL;
		}

		// Token: 0x06008C20 RID: 35872 RVA: 0x00308358 File Offset: 0x00306558
		public float EBDEDGJKPAI()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x00308422 File Offset: 0x00306622
		public void FEOHNOCBHNO(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x00308358 File Offset: 0x00306558
		public float DBLGMANKIMN()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x003083A1 File Offset: 0x003065A1
		public void KDBOCEEPJMK()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x00308360 File Offset: 0x00306560
		public float LNACKGNGEGK()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x00308446 File Offset: 0x00306646
		public void BEHLFOKHCGD(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x00308422 File Offset: 0x00306622
		public void LNODOBONEFA(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x00308358 File Offset: 0x00306558
		public float PNJFPPHJNDK()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x0030844F File Offset: 0x0030664F
		public void MABJAGKDMND(float DPNHODJHGJL)
		{
			this.KPFNNMMEGGF = DPNHODJHGJL;
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x00308358 File Offset: 0x00306558
		public float CHGLKONLHNG()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x003083FE File Offset: 0x003065FE
		public void IGIDNHEHKPN(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x00308358 File Offset: 0x00306558
		public float FLIANCGKGLK()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x003083C2 File Offset: 0x003065C2
		public float GKIAEJBCLKA()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x00308360 File Offset: 0x00306560
		public float FNJMKEBEPMF()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x00308350 File Offset: 0x00306550
		public bool CMKJOJJHFKN()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C2F RID: 35887 RVA: 0x003083A1 File Offset: 0x003065A1
		public void MOABAICELDJ()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x00308360 File Offset: 0x00306560
		public float HDFCOBFMPJK()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x00308458 File Offset: 0x00306658
		public void GJPOENINLNB(float NMJBJAOPJBP)
		{
			if (!this.IIKJEGDBJFJ())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C32 RID: 35890 RVA: 0x003083A1 File Offset: 0x003065A1
		public void LAMDADGMDJK()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C33 RID: 35891 RVA: 0x00308360 File Offset: 0x00306560
		public float ELPDGKHOEIK()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C34 RID: 35892 RVA: 0x003083FE File Offset: 0x003065FE
		public void AddOnFinishCallback(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C35 RID: 35893 RVA: 0x003083A1 File Offset: 0x003065A1
		public void PCLPELAIEAC()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C36 RID: 35894 RVA: 0x00308360 File Offset: 0x00306560
		public float BFGIMEPBJPK()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C37 RID: 35895 RVA: 0x0030844F File Offset: 0x0030664F
		public void OKANGNECOAN(float DPNHODJHGJL)
		{
			this.KPFNNMMEGGF = DPNHODJHGJL;
		}

		// Token: 0x06008C38 RID: 35896 RVA: 0x003083A1 File Offset: 0x003065A1
		public void KMLAEDKFCJC()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x003083A1 File Offset: 0x003065A1
		public void GKCDHDHBLGH()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x00308446 File Offset: 0x00306646
		public void IIHLFJCBNLE(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x00308422 File Offset: 0x00306622
		public void GEKCGIEAGNG(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x00308446 File Offset: 0x00306646
		public void DGABOEMEHFN(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x00308422 File Offset: 0x00306622
		public void MFHBKOLEPBP(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C3E RID: 35902 RVA: 0x00308350 File Offset: 0x00306550
		public bool LFMEFOHJMMG()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06008C3F RID: 35903 RVA: 0x003083C2 File Offset: 0x003065C2
		// (set) Token: 0x06008C66 RID: 35942 RVA: 0x003083CA File Offset: 0x003065CA
		public float targetFloat
		{
			get
			{
				return this.GDFDPMLMJHK;
			}
			set
			{
				this.GDFDPMLMJHK = value;
			}
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x003083C2 File Offset: 0x003065C2
		public float IBILOFBMNHP()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x003083CA File Offset: 0x003065CA
		public void NGJCEBHDFPH(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00308358 File Offset: 0x00306558
		public float MKODEBHMFIM()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x00308360 File Offset: 0x00306560
		public float JGCLBCNAMIH()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x0030844F File Offset: 0x0030664F
		public void JGKOCCKCJCL(float DPNHODJHGJL)
		{
			this.KPFNNMMEGGF = DPNHODJHGJL;
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x00308350 File Offset: 0x00306550
		public bool MLIBNMFDGNC()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x003083B9 File Offset: 0x003065B9
		public void HPOANOANLJN(bool DPNHODJHGJL)
		{
			this.LCIOMPDACPD = DPNHODJHGJL;
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x00308458 File Offset: 0x00306658
		public void FBDJKCFCDAK(float NMJBJAOPJBP)
		{
			if (!this.IIKJEGDBJFJ())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x00308422 File Offset: 0x00306622
		public void GHKGJNIEEGC(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x00308350 File Offset: 0x00306550
		public bool JLKGFIMOPKE()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C4A RID: 35914 RVA: 0x003083CA File Offset: 0x003065CA
		public void NDCBJCEGCNP(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C4B RID: 35915 RVA: 0x00308458 File Offset: 0x00306658
		public void GBPNJPEFLPF(float NMJBJAOPJBP)
		{
			if (!this.IIKJEGDBJFJ())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x00308350 File Offset: 0x00306550
		public bool GFNFOJBBNOA()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x00308422 File Offset: 0x00306622
		public void AddOnChangedCallback(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x00308350 File Offset: 0x00306550
		public bool CCJNFLNPDGI()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x00308458 File Offset: 0x00306658
		public void KBAEIPFBGBA(float NMJBJAOPJBP)
		{
			if (!this.IIKJEGDBJFJ())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x00308446 File Offset: 0x00306646
		public void PICGIOOADEF(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x00308483 File Offset: 0x00306683
		public void PHCDCOELAOF(float NMJBJAOPJBP)
		{
			if (!this.HCGLDAIFPBB())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x00308350 File Offset: 0x00306550
		public bool HENKEPFPGAE()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x00308350 File Offset: 0x00306550
		public bool GDOHDHKJACH()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x00308358 File Offset: 0x00306558
		public float GetDuration()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x00308446 File Offset: 0x00306646
		public void BEAJGNGKIMP(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x003083FE File Offset: 0x003065FE
		public void IJONDEPKDIL(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x003083FE File Offset: 0x003065FE
		public void PIHMPMFAGLA(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x003084AE File Offset: 0x003066AE
		public bool PONDLLDMNJP()
		{
			return this.ICAHKGKPENF != null;
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x00308422 File Offset: 0x00306622
		public void GKMPCBOIIFL(UnityAction<float> NPIKJHPJIEA)
		{
			if (this.ICAHKGKPENF == null)
			{
				this.ICAHKGKPENF = new FloatTween.FloatTweenCallback();
			}
			this.ICAHKGKPENF.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x00308358 File Offset: 0x00306558
		public float FELNIGFOFMP()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x003083A1 File Offset: 0x003065A1
		public void ENFDFOBEDGA()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06008C62 RID: 35938 RVA: 0x00308358 File Offset: 0x00306558
		// (set) Token: 0x06008C5C RID: 35932 RVA: 0x00308446 File Offset: 0x00306646
		public float duration
		{
			get
			{
				return this.KHIEAPENHOG;
			}
			set
			{
				this.KHIEAPENHOG = value;
			}
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x00308446 File Offset: 0x00306646
		public void IEKPPEPCFHH(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C5E RID: 35934 RVA: 0x00308350 File Offset: 0x00306550
		public bool KMPHPLOGFPA()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x00308350 File Offset: 0x00306550
		public bool AHPMCDOCNFD()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C61 RID: 35937 RVA: 0x00308358 File Offset: 0x00306558
		public float HHECGEPFLIO()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06008C68 RID: 35944 RVA: 0x00308350 File Offset: 0x00306550
		// (set) Token: 0x06008C63 RID: 35939 RVA: 0x003083B9 File Offset: 0x003065B9
		public bool ignoreTimeScale
		{
			get
			{
				return this.LCIOMPDACPD;
			}
			set
			{
				this.LCIOMPDACPD = value;
			}
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x003083FE File Offset: 0x003065FE
		public void EDNPJGKIFCE(UnityAction NPIKJHPJIEA)
		{
			if (this.AENGMBFNDJC == null)
			{
				this.AENGMBFNDJC = new FloatTween.FloatFinishCallback();
			}
			this.AENGMBFNDJC.AddListener(NPIKJHPJIEA);
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x0030844F File Offset: 0x0030664F
		public void IFMFNEFACHC(float DPNHODJHGJL)
		{
			this.KPFNNMMEGGF = DPNHODJHGJL;
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x00308358 File Offset: 0x00306558
		public float ILHKPPBLHNJ()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x00308360 File Offset: 0x00306560
		public float GAAIDAGAOPI()
		{
			return this.KPFNNMMEGGF;
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x00308483 File Offset: 0x00306683
		public void JJBLPNHIDFC(float NMJBJAOPJBP)
		{
			if (!this.HCGLDAIFPBB())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x003083C2 File Offset: 0x003065C2
		public float MKOBJCIGJLC()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x0030844F File Offset: 0x0030664F
		public void PPAIAHCJNEK(float DPNHODJHGJL)
		{
			this.KPFNNMMEGGF = DPNHODJHGJL;
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x00308358 File Offset: 0x00306558
		public float FHLAALFPLIH()
		{
			return this.KHIEAPENHOG;
		}

		// Token: 0x06008C6E RID: 35950 RVA: 0x00308350 File Offset: 0x00306550
		public bool INJGGAHBNGP()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x00308350 File Offset: 0x00306550
		public bool NOILPOOBMKA()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x00308350 File Offset: 0x00306550
		public bool OKKCDEBKIGI()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x003083CA File Offset: 0x003065CA
		public void NDDCCGGPEHL(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x003083CA File Offset: 0x003065CA
		public void MJKMBGONKJE(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x00308350 File Offset: 0x00306550
		public bool HHLCABPPFBD()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x00308350 File Offset: 0x00306550
		public bool NJPALDGNAAC()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x003083C2 File Offset: 0x003065C2
		public float IDLADPICADN()
		{
			return this.GDFDPMLMJHK;
		}

		// Token: 0x06008C76 RID: 35958 RVA: 0x00308350 File Offset: 0x00306550
		public bool EGHFICIJFJN()
		{
			return this.LCIOMPDACPD;
		}

		// Token: 0x06008C77 RID: 35959 RVA: 0x003083B9 File Offset: 0x003065B9
		public void DBNOLLKPLON(bool DPNHODJHGJL)
		{
			this.LCIOMPDACPD = DPNHODJHGJL;
		}

		// Token: 0x06008C78 RID: 35960 RVA: 0x00308446 File Offset: 0x00306646
		public void EHCCNEIJCGH(float DPNHODJHGJL)
		{
			this.KHIEAPENHOG = DPNHODJHGJL;
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x00308376 File Offset: 0x00306576
		public void TweenValue(float NMJBJAOPJBP)
		{
			if (!this.ValidTarget())
			{
				return;
			}
			this.ICAHKGKPENF.Invoke(Mathf.Lerp(this.KPFNNMMEGGF, this.GDFDPMLMJHK, NMJBJAOPJBP));
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x003084AE File Offset: 0x003066AE
		public bool IIKJEGDBJFJ()
		{
			return this.ICAHKGKPENF != null;
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x003083A1 File Offset: 0x003065A1
		public void IIDOGFBBGBH()
		{
			if (this.AENGMBFNDJC != null)
			{
				this.AENGMBFNDJC.Invoke();
			}
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x003083B9 File Offset: 0x003065B9
		public void CIKJLGDCOBK(bool DPNHODJHGJL)
		{
			this.LCIOMPDACPD = DPNHODJHGJL;
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x003084AE File Offset: 0x003066AE
		public bool ValidTarget()
		{
			return this.ICAHKGKPENF != null;
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x003083CA File Offset: 0x003065CA
		public void BGELCMLGPEG(float DPNHODJHGJL)
		{
			this.GDFDPMLMJHK = DPNHODJHGJL;
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x0030844F File Offset: 0x0030664F
		public void KCJOGGECJIA(float DPNHODJHGJL)
		{
			this.KPFNNMMEGGF = DPNHODJHGJL;
		}

		// Token: 0x0400102B RID: 4139
		private float KPFNNMMEGGF;

		// Token: 0x0400102C RID: 4140
		private float GDFDPMLMJHK;

		// Token: 0x0400102D RID: 4141
		private float KHIEAPENHOG;

		// Token: 0x0400102E RID: 4142
		private bool LCIOMPDACPD;

		// Token: 0x0400102F RID: 4143
		private FloatTween.FloatTweenCallback ICAHKGKPENF;

		// Token: 0x04001030 RID: 4144
		private FloatTween.FloatFinishCallback AENGMBFNDJC;

		// Token: 0x02000245 RID: 581
		public class FloatTweenCallback : UnityEvent<float>
		{
		}

		// Token: 0x02000246 RID: 582
		public class FloatFinishCallback : UnityEvent
		{
		}
	}
}
