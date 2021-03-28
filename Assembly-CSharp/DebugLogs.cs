using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000142 RID: 322
public class DebugLogs : ScriptableObject
{
	// Token: 0x060064BF RID: 25791 RVA: 0x001EA098 File Offset: 0x001E8298
	public void DHILJLCAJOH(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064C0 RID: 25792 RVA: 0x001EA0C0 File Offset: 0x001E82C0
	private void BONGPCHPKGM(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		this.IELAGEFHCEH(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064C1 RID: 25793 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> NHOFNFPMPIJ()
	{
		return this.logs;
	}

	// Token: 0x060064C2 RID: 25794 RVA: 0x001EA114 File Offset: 0x001E8314
	private void FIHFNOKPLOE(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		this.NIKKCCMKEBB(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064C3 RID: 25795 RVA: 0x001EA15F File Offset: 0x001E835F
	private void AJBHOEBKGDO()
	{
		Application.logMessageReceived += this.FIHFNOKPLOE;
	}

	// Token: 0x060064C4 RID: 25796 RVA: 0x001EA098 File Offset: 0x001E8298
	public void CFOEEAKEICA(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064C5 RID: 25797 RVA: 0x001EA172 File Offset: 0x001E8372
	public static DebugLogs AAICPABFPMH()
	{
		return DebugLogs.MNNNKLODJPJ();
	}

	// Token: 0x060064C7 RID: 25799 RVA: 0x001EA098 File Offset: 0x001E8298
	public void PEPAOAGLKBE(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064C8 RID: 25800 RVA: 0x001EA18C File Offset: 0x001E838C
	public void EPHCPNILKGI()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x060064C9 RID: 25801 RVA: 0x001EA18C File Offset: 0x001E838C
	public void EGMANOEGILB()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x060064CA RID: 25802 RVA: 0x001EA1B0 File Offset: 0x001E83B0
	private void FDPACFIMNBC(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		this.IELAGEFHCEH(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064CB RID: 25803 RVA: 0x001EA098 File Offset: 0x001E8298
	public void PBAOOLHNKGI(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064CC RID: 25804 RVA: 0x001EA1FB File Offset: 0x001E83FB
	private void DPGHJILBPCE()
	{
		Application.logMessageReceived += this.IMNCPCLALJJ;
	}

	// Token: 0x060064CD RID: 25805 RVA: 0x001EA098 File Offset: 0x001E8298
	public void FMEAEDJNAJE(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064CE RID: 25806 RVA: 0x001EA20E File Offset: 0x001E840E
	private void DEPPMIPBPAL()
	{
		Application.logMessageReceived -= this.JNEHFGLHCBD;
	}

	// Token: 0x060064CF RID: 25807 RVA: 0x001EA098 File Offset: 0x001E8298
	public void NFDOJABJEAJ(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064D0 RID: 25808 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> JAPENNOMMPB()
	{
		return this.logs;
	}

	// Token: 0x060064D1 RID: 25809 RVA: 0x001EA221 File Offset: 0x001E8421
	public static DebugLogs APPNBEHBAAN()
	{
		return DebugLogs.PJGGFINJIEG();
	}

	// Token: 0x060064D2 RID: 25810 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> DAIMPCOMEOC()
	{
		return this.logs;
	}

	// Token: 0x060064D3 RID: 25811 RVA: 0x001EA228 File Offset: 0x001E8428
	public static DebugLogs LIGMMLFHBCO()
	{
		return DebugLogs.BJBGHMFFOML();
	}

	// Token: 0x060064D4 RID: 25812 RVA: 0x001EA098 File Offset: 0x001E8298
	public void KJIKIKAEMEH(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064D5 RID: 25813 RVA: 0x001EA098 File Offset: 0x001E8298
	public void GMBKCMAIGDE(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064D6 RID: 25814 RVA: 0x001EA22F File Offset: 0x001E842F
	private void LOLHKNKBNPF()
	{
		Application.logMessageReceived += this.BNOOOFEECFN;
	}

	// Token: 0x060064D7 RID: 25815 RVA: 0x001EA244 File Offset: 0x001E8444
	private void INMDNNOLNDH(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 1);
		}
		this.AddLog(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064D8 RID: 25816 RVA: 0x001EA098 File Offset: 0x001E8298
	public void BIOMHEFCNGG(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064D9 RID: 25817 RVA: 0x001EA28F File Offset: 0x001E848F
	public static DebugLogs OCJEOJGNDKM()
	{
		return DebugLogs.FLFBBNOFAOL();
	}

	// Token: 0x060064DA RID: 25818 RVA: 0x001EA18C File Offset: 0x001E838C
	public void MGEPCIPHOCL()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x060064DB RID: 25819 RVA: 0x001EA298 File Offset: 0x001E8498
	private void BNOOOFEECFN(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		this.GMNAJNIKMAO(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064DC RID: 25820 RVA: 0x001EA2E3 File Offset: 0x001E84E3
	private void DMANIBGNIMK()
	{
		Application.logMessageReceived -= this.INMDNNOLNDH;
	}

	// Token: 0x060064DD RID: 25821 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs PLNLDAHBDBB()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064DE RID: 25822 RVA: 0x001EA098 File Offset: 0x001E8298
	public void LJKHJBKGCJK(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064DF RID: 25823 RVA: 0x001EA098 File Offset: 0x001E8298
	public void LOGBIMAOOAB(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064E0 RID: 25824 RVA: 0x001EA317 File Offset: 0x001E8517
	public static DebugLogs NEEAJCHBMNL()
	{
		return DebugLogs.NBPGOMDMGHB();
	}

	// Token: 0x060064E1 RID: 25825 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs KDECGCBBEDI()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064E2 RID: 25826 RVA: 0x001EA20E File Offset: 0x001E840E
	private void PELDLDIDGFO()
	{
		Application.logMessageReceived -= this.JNEHFGLHCBD;
	}

	// Token: 0x060064E3 RID: 25827 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs GNOGMOMHIGL()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064E4 RID: 25828 RVA: 0x001EA320 File Offset: 0x001E8520
	private void MNFAKFGGHNK(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		this.PEPAOAGLKBE(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064E5 RID: 25829 RVA: 0x001EA36B File Offset: 0x001E856B
	public static DebugLogs HGIFFBJPMDN()
	{
		return DebugLogs.NIFMFBHNMJH();
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x060064E6 RID: 25830 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs Instance
	{
		get
		{
			if (DebugLogs.instance == null)
			{
				DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
			}
			return DebugLogs.instance;
		}
	}

	// Token: 0x060064E7 RID: 25831 RVA: 0x001EA2E3 File Offset: 0x001E84E3
	private void OnDestroy()
	{
		Application.logMessageReceived -= this.INMDNNOLNDH;
	}

	// Token: 0x060064E8 RID: 25832 RVA: 0x001EA372 File Offset: 0x001E8572
	private void JNJMGIFMNBF()
	{
		Application.logMessageReceived -= this.MJCINHPBLMB;
	}

	// Token: 0x060064E9 RID: 25833 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> DFCCGNACJGL()
	{
		return this.logs;
	}

	// Token: 0x060064EA RID: 25834 RVA: 0x001EA385 File Offset: 0x001E8585
	private void LICOLMAOHKI()
	{
		Application.logMessageReceived += this.MNFAKFGGHNK;
	}

	// Token: 0x060064EB RID: 25835 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs JEGPKFIGPFP()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064EC RID: 25836 RVA: 0x001EA098 File Offset: 0x001E8298
	public void GIODPNEBBID(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064ED RID: 25837 RVA: 0x001EA398 File Offset: 0x001E8598
	private void DONICBHGIMP(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 0);
		}
		this.CFOEEAKEICA(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064EE RID: 25838 RVA: 0x001EA18C File Offset: 0x001E838C
	public void NCGIKMIMIAA()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x060064EF RID: 25839 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs GLEFOHOMBFC()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064F0 RID: 25840 RVA: 0x001EA098 File Offset: 0x001E8298
	public void CGPBBDHGEHL(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064F1 RID: 25841 RVA: 0x001EA3E4 File Offset: 0x001E85E4
	private void FIMPKAEMBDE(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 0);
		}
		this.LOGBIMAOOAB(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064F2 RID: 25842 RVA: 0x001EA098 File Offset: 0x001E8298
	public void IELAGEFHCEH(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064F3 RID: 25843 RVA: 0x001EA42F File Offset: 0x001E862F
	private void OJIHBHNJFBB()
	{
		Application.logMessageReceived -= this.MNFAKFGGHNK;
	}

	// Token: 0x060064F4 RID: 25844 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs MNNNKLODJPJ()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064F5 RID: 25845 RVA: 0x001EA444 File Offset: 0x001E8644
	private void EPECEAPDMKI(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		this.GMBKCMAIGDE(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064F6 RID: 25846 RVA: 0x001EA48F File Offset: 0x001E868F
	private void PAHNKEGFGHB()
	{
		Application.logMessageReceived += this.DONICBHGIMP;
	}

	// Token: 0x060064F7 RID: 25847 RVA: 0x001EA4A2 File Offset: 0x001E86A2
	private void FJGNDJGLBEN()
	{
		Application.logMessageReceived -= this.KJONBKLMPDB;
	}

	// Token: 0x060064F8 RID: 25848 RVA: 0x001EA098 File Offset: 0x001E8298
	public void DGEHKEOGNPN(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x060064F9 RID: 25849 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs FMEBOFOPHDG()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064FA RID: 25850 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> JMBMGJLGOGJ()
	{
		return this.logs;
	}

	// Token: 0x060064FB RID: 25851 RVA: 0x001EA4B8 File Offset: 0x001E86B8
	private void IMNCPCLALJJ(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		this.FMEAEDJNAJE(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x060064FC RID: 25852 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs EGHNDEGBPAP()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064FD RID: 25853 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> MLICHFLLIKF()
	{
		return this.logs;
	}

	// Token: 0x060064FE RID: 25854 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs BEPGMCOJFKL()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x060064FF RID: 25855 RVA: 0x001EA503 File Offset: 0x001E8703
	private void HOLDCFBBHHP()
	{
		Application.logMessageReceived += this.MJCINHPBLMB;
	}

	// Token: 0x06006500 RID: 25856 RVA: 0x001EA18C File Offset: 0x001E838C
	public void JNDMIAKMHCG()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006501 RID: 25857 RVA: 0x001EA221 File Offset: 0x001E8421
	public static DebugLogs GBDGMMKNGFC()
	{
		return DebugLogs.PJGGFINJIEG();
	}

	// Token: 0x06006502 RID: 25858 RVA: 0x001EA18C File Offset: 0x001E838C
	public void ClearLogs()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006503 RID: 25859 RVA: 0x001EA18C File Offset: 0x001E838C
	public void DCIFPNIDJKI()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006504 RID: 25860 RVA: 0x001EA516 File Offset: 0x001E8716
	public static DebugLogs AFDBDFJHMBN()
	{
		return DebugLogs.FAGEJPPIDOL();
	}

	// Token: 0x06006505 RID: 25861 RVA: 0x001EA098 File Offset: 0x001E8298
	public void DCLMNOJMHEJ(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x06006506 RID: 25862 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs PJGGFINJIEG()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006507 RID: 25863 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> FEAOKBPNJKL()
	{
		return this.logs;
	}

	// Token: 0x06006508 RID: 25864 RVA: 0x001EA18C File Offset: 0x001E838C
	public void CHNPAIEBNDA()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006509 RID: 25865 RVA: 0x001EA51D File Offset: 0x001E871D
	private void BKAJKNPDEAP()
	{
		Application.logMessageReceived -= this.FIMPKAEMBDE;
	}

	// Token: 0x0600650A RID: 25866 RVA: 0x001EA098 File Offset: 0x001E8298
	public void JCNCIGNAGFF(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x0600650B RID: 25867 RVA: 0x001EA098 File Offset: 0x001E8298
	public void KIBKHEAHMND(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x0600650C RID: 25868 RVA: 0x001EA530 File Offset: 0x001E8730
	private void NHOFNIIBMDH()
	{
		Application.logMessageReceived -= this.BNOOOFEECFN;
	}

	// Token: 0x0600650D RID: 25869 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> IDLDNGCDICL()
	{
		return this.logs;
	}

	// Token: 0x0600650E RID: 25870 RVA: 0x001EA543 File Offset: 0x001E8743
	private void JOLKPPEBILA()
	{
		Application.logMessageReceived += this.FDPACFIMNBC;
	}

	// Token: 0x0600650F RID: 25871 RVA: 0x001EA18C File Offset: 0x001E838C
	public void JHGPIIIFDNN()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006510 RID: 25872 RVA: 0x001EA098 File Offset: 0x001E8298
	public void AddLog(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x06006511 RID: 25873 RVA: 0x001EA18C File Offset: 0x001E838C
	public void KAHMPKPOEBD()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006512 RID: 25874 RVA: 0x001EA22F File Offset: 0x001E842F
	private void IBFHEDHJDLH()
	{
		Application.logMessageReceived += this.BNOOOFEECFN;
	}

	// Token: 0x06006513 RID: 25875 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs NBPGOMDMGHB()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006514 RID: 25876 RVA: 0x001EA558 File Offset: 0x001E8758
	private void KPFDEHBDLOI(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 1);
		}
		this.DBELJBLKLHE(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x06006515 RID: 25877 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> MLNJPDGONOE()
	{
		return this.logs;
	}

	// Token: 0x06006516 RID: 25878 RVA: 0x001EA098 File Offset: 0x001E8298
	public void NIKKCCMKEBB(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x06006517 RID: 25879 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs NIFMFBHNMJH()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006518 RID: 25880 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs BJBGHMFFOML()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006519 RID: 25881 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs FLFBBNOFAOL()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x0600651A RID: 25882 RVA: 0x001EA098 File Offset: 0x001E8298
	public void GMNAJNIKMAO(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x0600651B RID: 25883 RVA: 0x001EA22F File Offset: 0x001E842F
	private void LHGFCBDACBM()
	{
		Application.logMessageReceived += this.BNOOOFEECFN;
	}

	// Token: 0x0600651C RID: 25884 RVA: 0x001EA5A3 File Offset: 0x001E87A3
	public static DebugLogs JNBJGLMJNPB()
	{
		return DebugLogs.FMEBOFOPHDG();
	}

	// Token: 0x0600651D RID: 25885 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> IEMPPMBDECN()
	{
		return this.logs;
	}

	// Token: 0x0600651E RID: 25886 RVA: 0x001EA385 File Offset: 0x001E8585
	private void AONJNAGNLIH()
	{
		Application.logMessageReceived += this.MNFAKFGGHNK;
	}

	// Token: 0x0600651F RID: 25887 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> KFEKJKLOJKC()
	{
		return this.logs;
	}

	// Token: 0x06006520 RID: 25888 RVA: 0x001EA098 File Offset: 0x001E8298
	public void BFAKEAFBGHN(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x06006521 RID: 25889 RVA: 0x001EA18C File Offset: 0x001E838C
	public void OHFJDPIDCDJ()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006522 RID: 25890 RVA: 0x001EA5AC File Offset: 0x001E87AC
	private void BFHBLOLBLEB(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		this.GMNAJNIKMAO(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x06006523 RID: 25891 RVA: 0x001EA5F7 File Offset: 0x001E87F7
	private void BFKGLMLLIHK()
	{
		Application.logMessageReceived -= this.BFHBLOLBLEB;
	}

	// Token: 0x06006524 RID: 25892 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> BMJBPNFGCHN()
	{
		return this.logs;
	}

	// Token: 0x06006525 RID: 25893 RVA: 0x001EA098 File Offset: 0x001E8298
	public void DBELJBLKLHE(DebugLogs.Log BAODCKEFHMK)
	{
		this.logs.Add(BAODCKEFHMK);
		if (this.OnLogAdded != null)
		{
			this.OnLogAdded(BAODCKEFHMK);
		}
	}

	// Token: 0x06006526 RID: 25894 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs AKNKBPICFGJ()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006527 RID: 25895 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs PFOGFJMFFGA()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006528 RID: 25896 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> BGLJPEENCAI()
	{
		return this.logs;
	}

	// Token: 0x06006529 RID: 25897 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs GFIEMBPCNEC()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x0600652A RID: 25898 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs FNBAADLJGFH()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x0600652B RID: 25899 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> CCIIOIDFOFF()
	{
		return this.logs;
	}

	// Token: 0x0600652C RID: 25900 RVA: 0x001EA60A File Offset: 0x001E880A
	private void OnEnable()
	{
		Application.logMessageReceived += this.INMDNNOLNDH;
	}

	// Token: 0x0600652D RID: 25901 RVA: 0x001EA61D File Offset: 0x001E881D
	private void HEKKABCJLKN()
	{
		Application.logMessageReceived -= this.FHNLBKCJDEE;
	}

	// Token: 0x0600652E RID: 25902 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs FAGEJPPIDOL()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x0600652F RID: 25903 RVA: 0x001EA5F7 File Offset: 0x001E87F7
	private void GHLCFKGNNAI()
	{
		Application.logMessageReceived -= this.BFHBLOLBLEB;
	}

	// Token: 0x06006530 RID: 25904 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs ECIBPJGCNNF()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006531 RID: 25905 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs LDCGDCPIJMK()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x06006532 RID: 25906 RVA: 0x001EA630 File Offset: 0x001E8830
	public static DebugLogs Touch()
	{
		return DebugLogs.Instance;
	}

	// Token: 0x06006533 RID: 25907 RVA: 0x001EA18C File Offset: 0x001E838C
	public void JDIKJHILCJA()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006534 RID: 25908 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> MNAHAGOGMJN()
	{
		return this.logs;
	}

	// Token: 0x06006535 RID: 25909 RVA: 0x001EA637 File Offset: 0x001E8837
	private void KEBNPDKADDF()
	{
		Application.logMessageReceived -= this.FIHFNOKPLOE;
	}

	// Token: 0x06006536 RID: 25910 RVA: 0x001EA503 File Offset: 0x001E8703
	private void ICPOEGIAFBL()
	{
		Application.logMessageReceived += this.MJCINHPBLMB;
	}

	// Token: 0x06006537 RID: 25911 RVA: 0x001EA637 File Offset: 0x001E8837
	private void MECBHGPGCFL()
	{
		Application.logMessageReceived -= this.FIHFNOKPLOE;
	}

	// Token: 0x06006538 RID: 25912 RVA: 0x001EA51D File Offset: 0x001E871D
	private void DLHJMLDBDOK()
	{
		Application.logMessageReceived -= this.FIMPKAEMBDE;
	}

	// Token: 0x06006539 RID: 25913 RVA: 0x001EA18C File Offset: 0x001E838C
	public void CAAMGHOOPJA()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x0600653A RID: 25914 RVA: 0x001EA64A File Offset: 0x001E884A
	public static DebugLogs MEKCLHGCIPJ()
	{
		return DebugLogs.BEPGMCOJFKL();
	}

	// Token: 0x0600653B RID: 25915 RVA: 0x001EA651 File Offset: 0x001E8851
	private void JOPGLJAEBAE()
	{
		Application.logMessageReceived -= this.BONGPCHPKGM;
	}

	// Token: 0x0600653C RID: 25916 RVA: 0x001EA664 File Offset: 0x001E8864
	private void FHNLBKCJDEE(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 0);
		}
		this.KJIKIKAEMEH(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x0600653D RID: 25917 RVA: 0x001EA2F6 File Offset: 0x001E84F6
	public static DebugLogs HPFHKGAKKLL()
	{
		if (DebugLogs.instance == null)
		{
			DebugLogs.instance = ScriptableObject.CreateInstance<DebugLogs>();
		}
		return DebugLogs.instance;
	}

	// Token: 0x0600653E RID: 25918 RVA: 0x001EA18C File Offset: 0x001E838C
	public void INDDCOEIDLB()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x0600653F RID: 25919 RVA: 0x001EA51D File Offset: 0x001E871D
	private void NFADJOKFCDL()
	{
		Application.logMessageReceived -= this.FIMPKAEMBDE;
	}

	// Token: 0x06006540 RID: 25920 RVA: 0x001EA6B0 File Offset: 0x001E88B0
	private void KJONBKLMPDB(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 1, 1);
		}
		this.KIBKHEAHMND(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x06006541 RID: 25921 RVA: 0x001EA22F File Offset: 0x001E842F
	private void MDMDGKHDPKP()
	{
		Application.logMessageReceived += this.BNOOOFEECFN;
	}

	// Token: 0x06006542 RID: 25922 RVA: 0x001EA6FC File Offset: 0x001E88FC
	private void MJCINHPBLMB(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 0);
		}
		this.CFOEEAKEICA(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x06006543 RID: 25923 RVA: 0x001EA18C File Offset: 0x001E838C
	public void BFKIFIEPLJH()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x06006544 RID: 25924 RVA: 0x001EA18C File Offset: 0x001E838C
	public void ONBGLBDBPJG()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06006545 RID: 25925 RVA: 0x001EA10B File Offset: 0x001E830B
	public List<DebugLogs.Log> Logs
	{
		get
		{
			return this.logs;
		}
	}

	// Token: 0x06006546 RID: 25926 RVA: 0x001EA48F File Offset: 0x001E868F
	private void IFBKMAEMKNN()
	{
		Application.logMessageReceived += this.DONICBHGIMP;
	}

	// Token: 0x06006547 RID: 25927 RVA: 0x001EA172 File Offset: 0x001E8372
	public static DebugLogs DMMOGDCBFIB()
	{
		return DebugLogs.MNNNKLODJPJ();
	}

	// Token: 0x06006548 RID: 25928 RVA: 0x001EA747 File Offset: 0x001E8947
	private void OBPIMJPMGFA()
	{
		Application.logMessageReceived -= this.EPECEAPDMKI;
	}

	// Token: 0x06006549 RID: 25929 RVA: 0x001EA516 File Offset: 0x001E8716
	public static DebugLogs HMJBKJDNJIC()
	{
		return DebugLogs.FAGEJPPIDOL();
	}

	// Token: 0x0600654A RID: 25930 RVA: 0x001EA1FB File Offset: 0x001E83FB
	private void LEFFPPCFNKD()
	{
		Application.logMessageReceived += this.IMNCPCLALJJ;
	}

	// Token: 0x0600654B RID: 25931 RVA: 0x001EA75A File Offset: 0x001E895A
	public static DebugLogs NFEDJIAPJGM()
	{
		return DebugLogs.PFOGFJMFFGA();
	}

	// Token: 0x0600654C RID: 25932 RVA: 0x001EA18C File Offset: 0x001E838C
	public void KFOHDCNGILO()
	{
		this.logs.Clear();
		if (this.OnLogsCleared != null)
		{
			this.OnLogsCleared();
		}
	}

	// Token: 0x0600654D RID: 25933 RVA: 0x001EA761 File Offset: 0x001E8961
	private void NKOIECGDEOJ()
	{
		Application.logMessageReceived += this.KPFDEHBDLOI;
	}

	// Token: 0x0600654E RID: 25934 RVA: 0x001EA774 File Offset: 0x001E8974
	private void KMMOLADBHEA()
	{
		Application.logMessageReceived += this.FHNLBKCJDEE;
	}

	// Token: 0x0600654F RID: 25935 RVA: 0x001EA1FB File Offset: 0x001E83FB
	private void GMLJCGAEMKL()
	{
		Application.logMessageReceived += this.IMNCPCLALJJ;
	}

	// Token: 0x06006550 RID: 25936 RVA: 0x001EA788 File Offset: 0x001E8988
	private void JNEHFGLHCBD(string LGFIJEHLGHP, string HAEHALPHBJK, LogType ELCFJBCLFBP)
	{
		if (!string.IsNullOrEmpty(HAEHALPHBJK))
		{
			HAEHALPHBJK = HAEHALPHBJK.Remove(HAEHALPHBJK.Length - 0, 1);
		}
		this.JCNCIGNAGFF(new DebugLogs.Log
		{
			type = ELCFJBCLFBP,
			message = LGFIJEHLGHP,
			stackTrace = HAEHALPHBJK
		});
	}

	// Token: 0x06006551 RID: 25937 RVA: 0x001EA1FB File Offset: 0x001E83FB
	private void BLNLHBNBKOH()
	{
		Application.logMessageReceived += this.IMNCPCLALJJ;
	}

	// Token: 0x04000A2D RID: 2605
	private static DebugLogs instance;

	// Token: 0x04000A2E RID: 2606
	public Action<DebugLogs.Log> OnLogAdded;

	// Token: 0x04000A2F RID: 2607
	public Action OnLogsCleared;

	// Token: 0x04000A30 RID: 2608
	private List<DebugLogs.Log> logs = new List<DebugLogs.Log>();

	// Token: 0x02000143 RID: 323
	[Serializable]
	public class Log
	{
		// Token: 0x04000A31 RID: 2609
		public LogType type;

		// Token: 0x04000A32 RID: 2610
		public string message;

		// Token: 0x04000A33 RID: 2611
		public string stackTrace;
	}
}
