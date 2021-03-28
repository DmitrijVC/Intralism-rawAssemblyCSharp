using System;
using System.Collections.Generic;
using MoonSharp.Interpreter;

// Token: 0x0200041D RID: 1053
[MoonSharpUserData]
public class GameState
{
	// Token: 0x0600F11C RID: 61724 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void KHJGDOEDODJ(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F11D RID: 61725 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void IJJLEONOJFC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F11E RID: 61726 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int KLEPLFNCJBB(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F11F RID: 61727 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void MIHJACPDMBN(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F120 RID: 61728 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void OMPFFHOCPOA(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F121 RID: 61729 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int GNAMJJFBIIH()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F122 RID: 61730 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void IFNMCNLEJPA(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F123 RID: 61731 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void MGOLCKBNLMN(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F124 RID: 61732 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void NHKBECAGNMF(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F125 RID: 61733 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool IINJNLILBNH(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F126 RID: 61734 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int GJHGEODJOMC(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F127 RID: 61735 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void OAAADLHEAPB(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F128 RID: 61736 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void SetFlag(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F129 RID: 61737 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool ELKKBLKBNCK(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F12A RID: 61738 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void HHDPOFMAJIJ(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F12B RID: 61739 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void OKDLCHPEFAJ(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F12C RID: 61740 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool DANKEDNMADL(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F12D RID: 61741 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int FFJCLMOEGJP()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F12E RID: 61742 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int OCNOMPJFPDH()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F12F RID: 61743 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void PNBKMOKMGCA(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F130 RID: 61744 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void NLJHNBPIOBM(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F131 RID: 61745 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void ILEFCAOODPD(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F132 RID: 61746 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int PIEMAFNAIFJ()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F133 RID: 61747 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void CDJGEAAHDCO(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F134 RID: 61748 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void PLKCIHMOEDF(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F135 RID: 61749 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void MOMKPOKGKGG(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F136 RID: 61750 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void SetInt(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F137 RID: 61751 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int PABBPEFFKIF(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F138 RID: 61752 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int EPIDPKPODKM(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F139 RID: 61753 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int OJNFPHLBFIK(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F13A RID: 61754 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void BJIMJIHHAAO(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F13B RID: 61755 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void GMOCCPMECNA(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F13C RID: 61756 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void FOHCCLDFIPI(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F13D RID: 61757 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int ACFEFOIGPGH()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F13E RID: 61758 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int GetInt(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F13F RID: 61759 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void AIEGEOFOMAK(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F140 RID: 61760 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void ONBLOOKJGJK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F141 RID: 61761 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void GBFBKFACPBI(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F142 RID: 61762 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void EEDFEGBFNEE(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F143 RID: 61763 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool JGJDPHFPDIB(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F144 RID: 61764 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void IHCHOMIEIMA(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F145 RID: 61765 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int JPLMMEMJDFL()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F146 RID: 61766 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int HHEOBAMLBKO(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F147 RID: 61767 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void KAGHFDBFEID(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F148 RID: 61768 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int ADFMPHGIJIB()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F149 RID: 61769 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void NIHEAIFNFGK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F14A RID: 61770 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void HHLLFMCPPHO(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F14B RID: 61771 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void GMNIMJALECK(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F14C RID: 61772 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void JCNPPGPPEHF(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F14D RID: 61773 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int COLMMBOCJLJ()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F14E RID: 61774 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void LAJHLIANCJE(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F14F RID: 61775 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int KPCOPGALPAH(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F150 RID: 61776 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void CJKADOEEHCN(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F151 RID: 61777 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void BBABCIKOEMF(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F152 RID: 61778 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int PMIPMLMPBOI()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F153 RID: 61779 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int JOFPMNKAJOD(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F154 RID: 61780 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool EFDCJIJHPOO(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x0600F155 RID: 61781 RVA: 0x00540CCA File Offset: 0x0053EECA
	// (set) Token: 0x0600F159 RID: 61785 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public int Action
	{
		get
		{
			return this.FFPBGKFKENP;
		}
		[MoonSharpHidden]
		set
		{
			this.FFPBGKFKENP = value;
		}
	}

	// Token: 0x0600F156 RID: 61782 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool HEMKFLEJGCC(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F157 RID: 61783 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void OFBNABDMOFC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F158 RID: 61784 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int LDHFNHNCGMM(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F15A RID: 61786 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void BCMMKLKAGLO(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F15B RID: 61787 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void IJFLFDFLCHP(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F15C RID: 61788 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int PKIEJKHMECB(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F15D RID: 61789 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void OADEMMCFLKA(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F15E RID: 61790 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int EGGJOJMNLBH(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F15F RID: 61791 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int AFCPNFKIKKJ(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F160 RID: 61792 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool LNPDOIGOEIO(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F161 RID: 61793 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void LNOFBDBGDOK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F162 RID: 61794 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int IKPMMJBEAHO()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F163 RID: 61795 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void KKLFJDENBPM(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F164 RID: 61796 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void JPALJEGCCHA(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F165 RID: 61797 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int CDGFIFOHACK()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F166 RID: 61798 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool PHPNPOGFJJJ(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F167 RID: 61799 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void MFMOAHDMPDC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F168 RID: 61800 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int POANCKAKLOH(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F169 RID: 61801 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void OCINFGEAKDI(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F16A RID: 61802 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void ALLJLCGOGJH(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F16B RID: 61803 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void FNGAMGMAHFM(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F16C RID: 61804 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void JMJNKANMANK(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F16D RID: 61805 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool GetFlag(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F16E RID: 61806 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int JBLBOBGALKH(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F16F RID: 61807 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void OFPCEFFGHPI(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F170 RID: 61808 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void LINOCPHKFOG(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F171 RID: 61809 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void DKCBLLOBLAM(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F172 RID: 61810 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int FMHHCMOODOF()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F173 RID: 61811 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void KANLDPOJBHC(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F174 RID: 61812 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void IKFLAMEGGKK(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F175 RID: 61813 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void HOJEBEFDKPD(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F176 RID: 61814 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void LFLJNBFMACE(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F177 RID: 61815 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool KMBKOLIKBDL(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F178 RID: 61816 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void GAMCBGMILFI(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F179 RID: 61817 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void AOCPPOKPMNO(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F17A RID: 61818 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool HEBJGNKAKIL(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F17B RID: 61819 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void IJLFDHOCKIN(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F17C RID: 61820 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int MKKENABFELP()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F17D RID: 61821 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool DBCNCFEBJBN(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F17E RID: 61822 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void GAGPLKADFMJ(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F17F RID: 61823 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void KPDOPNBDBLJ(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F180 RID: 61824 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void IEOCONPDLLF(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F181 RID: 61825 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int ODIGHKEMLLM(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F182 RID: 61826 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int KECMHJIDDEI(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F183 RID: 61827 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void MNJBJNECLCK(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F184 RID: 61828 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int JNLHMOEFMML(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F185 RID: 61829 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int ACHEAADDJOB()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F186 RID: 61830 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void FOJMLGFIPCB(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F187 RID: 61831 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool CDIIDAAHHPA(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F188 RID: 61832 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void NNNBGIJFHFH(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F189 RID: 61833 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void IFLMHHJKJMC(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F18A RID: 61834 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int CDPFJGFPKCB()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F18B RID: 61835 RVA: 0x00540D80 File Offset: 0x0053EF80
	[MoonSharpHidden]
	public GameState()
	{
		this.NOJGGCLPPAM = new Dictionary<string, object>();
	}

	// Token: 0x0600F18C RID: 61836 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void EFHICFFMNGF(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F18D RID: 61837 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int DGPINJKDBGL()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F18E RID: 61838 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void EHOCIKECPKC(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F18F RID: 61839 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int KPGAODLKMOP(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F190 RID: 61840 RVA: 0x00540D0F File Offset: 0x0053EF0F
	public bool IBPJPCDBAPP(string HONJLFPGFON)
	{
		return this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	// Token: 0x0600F191 RID: 61841 RVA: 0x00540D1D File Offset: 0x0053EF1D
	public void OLDPNKLFGKK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F192 RID: 61842 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void GPPDNOGOEHC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F193 RID: 61843 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int IGADJGDBHPO(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F194 RID: 61844 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int EDOOIBLEGEP(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F195 RID: 61845 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int LEOLIDKCBOG(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F196 RID: 61846 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void FFKLBCLMLJM(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F197 RID: 61847 RVA: 0x00540CC1 File Offset: 0x0053EEC1
	public void HEKJPGGNHGI(int DPNHODJHGJL)
	{
		this.FFPBGKFKENP = DPNHODJHGJL;
	}

	// Token: 0x0600F198 RID: 61848 RVA: 0x00540C9B File Offset: 0x0053EE9B
	public int NDGODCIFBOB(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x0600F199 RID: 61849 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void GKPMKFLJEEH(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F19A RID: 61850 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void DCINDMCHGID(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x0600F19B RID: 61851 RVA: 0x00540D5A File Offset: 0x0053EF5A
	public int DFEBLDOCCAC(string HFEFHOPOLIK)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)this.NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x0600F19C RID: 61852 RVA: 0x00540CCA File Offset: 0x0053EECA
	public int PDDKGPCIDJA()
	{
		return this.FFPBGKFKENP;
	}

	// Token: 0x0600F19D RID: 61853 RVA: 0x00540C5F File Offset: 0x0053EE5F
	public void DKPKHLKNOFN(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (this.NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			this.NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			this.NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	// Token: 0x0600F19E RID: 61854 RVA: 0x00540CD2 File Offset: 0x0053EED2
	public void CDPMHHLAPBB(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!this.NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				this.NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			this.NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	// Token: 0x04001AD1 RID: 6865
	private int FFPBGKFKENP;

	// Token: 0x04001AD2 RID: 6866
	private Dictionary<string, object> NOJGGCLPPAM;
}
