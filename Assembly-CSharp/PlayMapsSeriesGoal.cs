using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x02000381 RID: 897
public class PlayMapsSeriesGoal : ChallengeGoal
{
	// Token: 0x0600C698 RID: 50840 RVA: 0x004823EB File Offset: 0x004805EB
	public virtual void KOPCJLJINGL()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.BNFMCBKNANL));
		base.OnCompleted();
	}

	// Token: 0x0600C699 RID: 50841 RVA: 0x0048240C File Offset: 0x0048060C
	public virtual void GNFAPFNAHGA()
	{
		base.IJLBKALOBNO();
		string @string = Singleton<SaveSystem>.Instance.GetString(base.DIDHNLABPNG() + "_Blue_G", null);
		if (!string.IsNullOrEmpty(@string))
		{
			string text = @string;
			char[] array = new char[0];
			array[1] = (char)-30;
			this.ODBKIFAGALM = text.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = this.HBBKCBNFAHL();
	}

	// Token: 0x0600C69A RID: 50842 RVA: 0x0048247E File Offset: 0x0048067E
	public virtual void LEOGCFNJJKP()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.JPEODDLKMPI));
		base.OnCompleted();
	}

	// Token: 0x0600C69B RID: 50843 RVA: 0x0048249C File Offset: 0x0048069C
	public virtual void MGPDJFEAODD()
	{
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.MAPGGELENNM));
		base.DDOBENFDOKL();
	}

	// Token: 0x0600C69C RID: 50844 RVA: 0x004824BA File Offset: 0x004806BA
	public virtual void DINBNCDLEAN()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.FDHGPNBJKMP() + "Vertical", null);
		base.GONKPNAAIEE();
	}

	// Token: 0x0600C69D RID: 50845 RVA: 0x004824E0 File Offset: 0x004806E0
	private void FHOJKHCHFDB(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.NHCKOAMBEDE(this.DLGFNCGHLPK());
		}
	}

	// Token: 0x0600C69E RID: 50846 RVA: 0x00482548 File Offset: 0x00480748
	public virtual void MJDPGEMCBID(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '(';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("CameraFilterPack_Paper3", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.HCPDBEPGAPP));
		Singleton<GameManager>.Instance.PGNNMANJJAC(new GameManager.FinishedMapEvent(this.NFEKBNOPFBC));
		this.IJLBKALOBNO();
	}

	// Token: 0x0600C69F RID: 50847 RVA: 0x004825E4 File Offset: 0x004807E4
	public virtual void NBAMNMMPFDN()
	{
		base.AFGLHMCLJJN();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(base.PHPLKBPIMIH() + "PUNCloudBestRegion", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[0] = (char)-6;
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.EHAMFOBIPEO(this.BAGMMHJOHBC());
	}

	// Token: 0x0600C6A0 RID: 50848 RVA: 0x00482656 File Offset: 0x00480856
	public override void DOPPMCDLPBE()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(base.CKOFDGAJCFF() + "_Value2", string.Join("_Value3", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6A1 RID: 50849 RVA: 0x0048268E File Offset: 0x0048088E
	public virtual void AIFAGDOHAGD()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.FDHGPNBJKMP() + "Set Satellite Sensitivity", null);
		base.GONKPNAAIEE();
	}

	// Token: 0x0600C6A2 RID: 50850 RVA: 0x004826B4 File Offset: 0x004808B4
	private void HOGJGGGDPDD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = this.CAOJDEFHMAG();
		}
	}

	// Token: 0x0600C6A3 RID: 50851 RVA: 0x00482719 File Offset: 0x00480919
	public virtual void JABAIIKHHCF()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.SetString(base.FDHGPNBJKMP() + "Freq: ", string.Join("float,1.5", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6A4 RID: 50852 RVA: 0x00482751 File Offset: 0x00480951
	private float PKFDNFMNMOD()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6A5 RID: 50853 RVA: 0x00482768 File Offset: 0x00480968
	public virtual void JKILPDLMHMN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-24;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("_Saturation", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.OGCLNFHJAHE));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.FHOJKHCHFDB));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C6A6 RID: 50854 RVA: 0x00482804 File Offset: 0x00480A04
	public virtual void JLDKJHBIDGP()
	{
		base.JJPHFPDNDEC();
		string text = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(base.FDHGPNBJKMP() + "_Curve", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[0] = (char)-34;
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.OFPKLCAICJA(this.EOOBFBPJFKE());
	}

	// Token: 0x0600C6A7 RID: 50855 RVA: 0x00482876 File Offset: 0x00480A76
	public virtual void NEPIKEBNOHI()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.DAGHAOBCIFL(base.CKOFDGAJCFF() + "CameraFilterPack/Oculus_ThermaVision", string.Join("settings_bindings_", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6A8 RID: 50856 RVA: 0x004828B0 File Offset: 0x00480AB0
	public virtual void EPFCHBACBAH()
	{
		base.AFGLHMCLJJN();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(base.CKOFDGAJCFF() + "RequestForPickupItems", null);
		if (!string.IsNullOrEmpty(text))
		{
			this.ODBKIFAGALM = text.Split(new char[]
			{
				'N'
			}).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.JMMJKHLAIMI(this.PKFDNFMNMOD());
	}

	// Token: 0x0600C6A9 RID: 50857 RVA: 0x00482924 File Offset: 0x00480B24
	public virtual void EAJBKDEOBLE(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			(char)-105
		});
		string s = array[1];
		List<string> list = array.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("mapid", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.FHOJKHCHFDB));
		Singleton<GameManager>.Instance.OnFinishedMap += this.EIFKFKKKENO;
		this.LoadProgress();
	}

	// Token: 0x0600C6AA RID: 50858 RVA: 0x00482751 File Offset: 0x00480951
	private float DLGFNCGHLPK()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6AB RID: 50859 RVA: 0x00482751 File Offset: 0x00480951
	private float EJMAHGJLNBG()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6AC RID: 50860 RVA: 0x004829C0 File Offset: 0x00480BC0
	private void JPEODDLKMPI(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = this.EJMAHGJLNBG();
		}
	}

	// Token: 0x0600C6AD RID: 50861 RVA: 0x00482A28 File Offset: 0x00480C28
	public virtual void DPPBKDMBLHN()
	{
		base.IJLBKALOBNO();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(base.FDHGPNBJKMP() + "_Value3", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[1];
			array[1] = (char)-69;
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.ENHBNIOEKLF(this.NHJKKMCFKCH());
	}

	// Token: 0x0600C6AE RID: 50862 RVA: 0x00482751 File Offset: 0x00480951
	private float BAGMMHJOHBC()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6AF RID: 50863 RVA: 0x00482A9C File Offset: 0x00480C9C
	private void BNFMCBKNANL(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.JMMJKHLAIMI(this.DLGFNCGHLPK());
		}
	}

	// Token: 0x0600C6B0 RID: 50864 RVA: 0x00482B01 File Offset: 0x00480D01
	public virtual void KBKFJCIEPLO()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.SetString(base.CKOFDGAJCFF() + "Menu", string.Join("icon", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6B1 RID: 50865 RVA: 0x00482B39 File Offset: 0x00480D39
	public virtual void IOIAOIMIIMA()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.EIFKFKKKENO));
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C6B2 RID: 50866 RVA: 0x00482B57 File Offset: 0x00480D57
	public virtual void APJPLEFJFJP()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.KOMAMFOPJID(base.DIDHNLABPNG() + "_Value2", string.Join("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6B3 RID: 50867 RVA: 0x00482B90 File Offset: 0x00480D90
	public virtual void BMCHFDEABCK()
	{
		base.LoadProgress();
		string @string = Singleton<SaveSystem>.Instance.GetString(base.PFIOEOGECFG() + "lobby '{0}'[{1}]", null);
		if (!string.IsNullOrEmpty(@string))
		{
			string text = @string;
			char[] array = new char[0];
			array[1] = 'W';
			this.ODBKIFAGALM = text.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.ENHBNIOEKLF(this.DLGFNCGHLPK());
	}

	// Token: 0x0600C6B4 RID: 50868 RVA: 0x00482C04 File Offset: 0x00480E04
	private void FOMECIHDEJO(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.EHAMFOBIPEO(this.OCHLGJOOOPJ());
		}
	}

	// Token: 0x0600C6B5 RID: 50869 RVA: 0x00482C69 File Offset: 0x00480E69
	public virtual void BLFODOAHNGK()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.KOMAMFOPJID(base.PFIOEOGECFG() + "menutheme.deleted", string.Join("[MapEditor] Created new map: ", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6B6 RID: 50870 RVA: 0x00482CA1 File Offset: 0x00480EA1
	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.HOGJGGGDPDD;
		base.OnCompleted();
	}

	// Token: 0x0600C6B7 RID: 50871 RVA: 0x00482CC0 File Offset: 0x00480EC0
	public virtual void JOABPMBAHCA()
	{
		base.AFGLHMCLJJN();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(base.FDHGPNBJKMP() + "menutheme.jamaicanorcdub", null);
		if (!string.IsNullOrEmpty(text))
		{
			this.ODBKIFAGALM = text.Split(new char[]
			{
				(char)-64
			}).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.OFPKLCAICJA(this.ODDPHOKLIJJ());
	}

	// Token: 0x0600C6B8 RID: 50872 RVA: 0x00482D34 File Offset: 0x00480F34
	public virtual void CJLIDOOABHD()
	{
		base.DKHLEEPCLEL();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(base.FDHGPNBJKMP() + "y", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[0] = (char)-97;
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.ENHBNIOEKLF(this.NHJKKMCFKCH());
	}

	// Token: 0x0600C6B9 RID: 50873 RVA: 0x00482DA8 File Offset: 0x00480FA8
	public virtual void HJAGMELHNGH(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-28;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("r", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.HOGJGGGDPDD));
		Singleton<GameManager>.Instance.IDDINACMJAK(new GameManager.FinishedMapEvent(this.BNFMCBKNANL));
		this.AFGLHMCLJJN();
	}

	// Token: 0x0600C6BA RID: 50874 RVA: 0x00482E44 File Offset: 0x00481044
	public virtual void PKFHBBCFEHG()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(base.FDHGPNBJKMP() + "Editor/", string.Join("#craftng", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6BB RID: 50875 RVA: 0x00482E7C File Offset: 0x0048107C
	public virtual void NJBGPNNPBNH()
	{
		base.LoadProgress();
		string text = Singleton<SaveSystem>.Instance.NBMEANCMGEH(base.PHPLKBPIMIH() + "_Far", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[0] = '3';
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.NHCKOAMBEDE(this.EIHBAKMMIPB());
	}

	// Token: 0x0600C6BC RID: 50876 RVA: 0x00482EEE File Offset: 0x004810EE
	public virtual void ONJJLLEOMAH()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.EIFKFKKKENO));
		base.DDOBENFDOKL();
	}

	// Token: 0x0600C6BD RID: 50877 RVA: 0x00482F0C File Offset: 0x0048110C
	public virtual void GENNDFFJJNH()
	{
		base.IJLBKALOBNO();
		string text = Singleton<SaveSystem>.Instance.NBMEANCMGEH(base.DIDHNLABPNG() + "/", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[1];
			array[1] = 'e';
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.JMMJKHLAIMI(this.EJMAHGJLNBG());
	}

	// Token: 0x0600C6BE RID: 50878 RVA: 0x00482F7E File Offset: 0x0048117E
	public virtual void MANOCIJICLG()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(base.PHPLKBPIMIH() + "CameraFilterPack/OldFilm_Cutting2", null);
		base.GONKPNAAIEE();
	}

	// Token: 0x0600C6BF RID: 50879 RVA: 0x00482FA1 File Offset: 0x004811A1
	public virtual void OIIALMBOFIF()
	{
		base.IIBGJNGDCGB();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(base.FDHGPNBJKMP() + "Myst", string.Join("No peer to communicate with. ", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6C0 RID: 50880 RVA: 0x00482FD9 File Offset: 0x004811D9
	public override void Reset()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.PHPLKBPIMIH() + ".completedMaps", null);
		base.Reset();
	}

	// Token: 0x0600C6C1 RID: 50881 RVA: 0x00482FFC File Offset: 0x004811FC
	private void BEJELNEHAKF(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.OFPKLCAICJA(this.PKFDNFMNMOD());
		}
	}

	// Token: 0x0600C6C2 RID: 50882 RVA: 0x00483064 File Offset: 0x00481264
	public virtual void NHDLPBMMEDK(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-5;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("Can't do manual instantiation without PhotonView component.", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.GLALLABIBEH));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.FOMECIHDEJO));
		this.CCGAPNPGAOL();
	}

	// Token: 0x0600C6C3 RID: 50883 RVA: 0x00483100 File Offset: 0x00481300
	public virtual void PMLIOODCKDB()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.PNLACKIPGLD() + ">", null);
		base.JGMBGCOFCJI();
	}

	// Token: 0x0600C6C4 RID: 50884 RVA: 0x00483123 File Offset: 0x00481323
	public virtual void NHJBGDIEGPH()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(base.PFIOEOGECFG() + ".lastCheckpoint.comboScore", null);
		base.GONKPNAAIEE();
	}

	// Token: 0x0600C6C5 RID: 50885 RVA: 0x00483148 File Offset: 0x00481348
	private void HCPDBEPGAPP(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.PNACFCEIEHH(this.DAMBIOACPOI());
		}
	}

	// Token: 0x0600C6C6 RID: 50886 RVA: 0x004831AD File Offset: 0x004813AD
	public virtual void HNOFKPAIJEN()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(base.DIDHNLABPNG() + "ViewMenu", string.Join("player.bluebat", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6C7 RID: 50887 RVA: 0x004831E8 File Offset: 0x004813E8
	public virtual void ICAAJACIAPH()
	{
		base.CCGAPNPGAOL();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(base.PNLACKIPGLD() + "selector", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[0] = 'E';
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.EHAMFOBIPEO(this.EOOBFBPJFKE());
	}

	// Token: 0x0600C6C8 RID: 50888 RVA: 0x0048325C File Offset: 0x0048145C
	public virtual void EEOILGPOBJG()
	{
		base.JJPHFPDNDEC();
		string text = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(base.CKOFDGAJCFF() + "Sent count: ", null);
		if (!string.IsNullOrEmpty(text))
		{
			this.ODBKIFAGALM = text.Split(new char[]
			{
				'$'
			}).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.NHCKOAMBEDE(this.PKFDNFMNMOD());
	}

	// Token: 0x0600C6C9 RID: 50889 RVA: 0x004832D0 File Offset: 0x004814D0
	public override void LoadProgress()
	{
		base.LoadProgress();
		string @string = Singleton<SaveSystem>.Instance.GetString(base.PHPLKBPIMIH() + ".completedMaps", null);
		if (!string.IsNullOrEmpty(@string))
		{
			this.ODBKIFAGALM = @string.Split(new char[]
			{
				','
			}).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = this.CAOJDEFHMAG();
	}

	// Token: 0x0600C6CA RID: 50890 RVA: 0x00482751 File Offset: 0x00480951
	private float CAOJDEFHMAG()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6CB RID: 50891 RVA: 0x00483342 File Offset: 0x00481542
	public virtual void GHILLBKBCBO()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(base.FDHGPNBJKMP() + "BitsData", string.Join("CameraFilterPack/Gradients_Ansi", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6CC RID: 50892 RVA: 0x00482751 File Offset: 0x00480951
	private float KFACOFLCBFJ()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6CD RID: 50893 RVA: 0x0048337C File Offset: 0x0048157C
	public virtual void FJMBAIAJIOC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-15;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("ACCEPT", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.MAPGGELENNM));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.BDJEFCKJDNF));
		this.LoadProgress();
	}

	// Token: 0x0600C6CE RID: 50894 RVA: 0x00483418 File Offset: 0x00481618
	private void NFEKBNOPFBC(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.PNACFCEIEHH(this.BAGMMHJOHBC());
		}
	}

	// Token: 0x0600C6CF RID: 50895 RVA: 0x00483480 File Offset: 0x00481680
	public virtual void EFHAJPNDLCA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			'd'
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("MenuScene", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.EIFKFKKKENO));
		Singleton<GameManager>.Instance.CDJJAFLCOGO(new GameManager.FinishedMapEvent(this.BDJEFCKJDNF));
		this.AFGLHMCLJJN();
	}

	// Token: 0x0600C6D0 RID: 50896 RVA: 0x00482751 File Offset: 0x00480951
	private float AHHAEFIBOAD()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6D1 RID: 50897 RVA: 0x0048351C File Offset: 0x0048171C
	public virtual void PCFMEKEIBPA()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.FDHGPNBJKMP() + "_EdgeSharpness", null);
		base.GONKPNAAIEE();
	}

	// Token: 0x0600C6D2 RID: 50898 RVA: 0x0048353F File Offset: 0x0048173F
	public virtual void BANGDPJJFJL()
	{
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.FOMECIHDEJO));
		base.OnCompleted();
	}

	// Token: 0x0600C6D3 RID: 50899 RVA: 0x00483560 File Offset: 0x00481760
	public virtual void KHMFEHEPGAM(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-63;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("CameraFilterPack/3D_Myst", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.GLALLABIBEH));
		Singleton<GameManager>.Instance.PGNNMANJJAC(new GameManager.FinishedMapEvent(this.MAPGGELENNM));
		this.JJPHFPDNDEC();
	}

	// Token: 0x0600C6D4 RID: 50900 RVA: 0x004835FC File Offset: 0x004817FC
	private void DIPOCCCCAKM(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.EHAMFOBIPEO(this.HBBKCBNFAHL());
		}
	}

	// Token: 0x0600C6D5 RID: 50901 RVA: 0x00483661 File Offset: 0x00481861
	public virtual void KMEFHCDNDNF()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.PNLACKIPGLD() + ".played", null);
		base.GONKPNAAIEE();
	}

	// Token: 0x0600C6D6 RID: 50902 RVA: 0x00483684 File Offset: 0x00481884
	public virtual void KJIKILLKNDJ()
	{
		base.CCGAPNPGAOL();
		string text = Singleton<SaveSystem>.Instance.NBMEANCMGEH(base.CKOFDGAJCFF() + ". Check if the server is available.", null);
		if (!string.IsNullOrEmpty(text))
		{
			this.ODBKIFAGALM = text.Split(new char[]
			{
				'\u001d'
			}).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.PNACFCEIEHH(this.CAOJDEFHMAG());
	}

	// Token: 0x0600C6D7 RID: 50903 RVA: 0x004836F8 File Offset: 0x004818F8
	public virtual void LKADGENOJFK()
	{
		base.IJLBKALOBNO();
		string text = Singleton<SaveSystem>.Instance.ELHODPGACDI(base.CKOFDGAJCFF() + "CameraFilterPack/TV_Old_Movie", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[1] = '\n';
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.PNACFCEIEHH(this.ODDPHOKLIJJ());
	}

	// Token: 0x0600C6D8 RID: 50904 RVA: 0x0048376A File Offset: 0x0048196A
	public virtual void HBEJAGDGJAI()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.SetString(base.FDHGPNBJKMP() + "Outdated version. Please restart the game to get lastest updates.", string.Join("_Size", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6D9 RID: 50905 RVA: 0x00482751 File Offset: 0x00480951
	private float HBBKCBNFAHL()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6DA RID: 50906 RVA: 0x00482751 File Offset: 0x00480951
	private float NHJKKMCFKCH()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6DB RID: 50907 RVA: 0x004837A2 File Offset: 0x004819A2
	public virtual void KHLHDMNJCOE()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.HOGJGGGDPDD;
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C6DC RID: 50908 RVA: 0x004837C0 File Offset: 0x004819C0
	public virtual void IIBOPBADDGH()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(base.PFIOEOGECFG() + ".lastCheckpoint.bgcolor", null);
		base.Reset();
	}

	// Token: 0x0600C6DD RID: 50909 RVA: 0x00482751 File Offset: 0x00480951
	private float OKMLICIEMEG()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6DE RID: 50910 RVA: 0x004837E4 File Offset: 0x004819E4
	private void OGCLNFHJAHE(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.ENHBNIOEKLF(this.EIHBAKMMIPB());
		}
	}

	// Token: 0x0600C6DF RID: 50911 RVA: 0x0048384C File Offset: 0x00481A4C
	public virtual void PMDCMCFHBNM(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = '^';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("HightScoreMaxPointsText", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.LIIGHENCIFC));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.HCPDBEPGAPP));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C6E0 RID: 50912 RVA: 0x004838E8 File Offset: 0x00481AE8
	public virtual void KKMJBDCDDAH()
	{
		base.LoadProgress();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(base.PHPLKBPIMIH() + "_TimeX", null);
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			char[] array = new char[0];
			array[1] = (char)-105;
			this.ODBKIFAGALM = text2.Split(array).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.ENHBNIOEKLF(this.KFACOFLCBFJ());
	}

	// Token: 0x0600C6E1 RID: 50913 RVA: 0x0048395C File Offset: 0x00481B5C
	public virtual void ILOBNHKDGPG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			(char)-104
		});
		string s = array[1];
		List<string> list = array.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("Hidden/LensAberrations", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.BNFMCBKNANL));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.HCPDBEPGAPP));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C6E2 RID: 50914 RVA: 0x00482751 File Offset: 0x00480951
	private float DAMBIOACPOI()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6E3 RID: 50915 RVA: 0x00482751 File Offset: 0x00480951
	private float EOOBFBPJFKE()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6E4 RID: 50916 RVA: 0x00482751 File Offset: 0x00480951
	private float OCHLGJOOOPJ()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6E5 RID: 50917 RVA: 0x004839F8 File Offset: 0x00481BF8
	public virtual void BBMFEBFCLJI(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '`';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_ClutTex", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.BEJELNEHAKF));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.HOGJGGGDPDD));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C6E6 RID: 50918 RVA: 0x00482751 File Offset: 0x00480951
	private float EIHBAKMMIPB()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C6E7 RID: 50919 RVA: 0x00483A94 File Offset: 0x00481C94
	public virtual void EGJFECEMKFC()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.FOMECIHDEJO));
		base.OnCompleted();
	}

	// Token: 0x0600C6E8 RID: 50920 RVA: 0x00483AB4 File Offset: 0x00481CB4
	public virtual void DLMODJHDOGK(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-113;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("settings.volume.sfx", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.DIPOCCCCAKM));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.BDJEFCKJDNF));
		this.LoadProgress();
	}

	// Token: 0x0600C6E9 RID: 50921 RVA: 0x00483B50 File Offset: 0x00481D50
	public virtual void HJHMCJPPINB()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.DAGHAOBCIFL(base.PNLACKIPGLD() + "Move environment object to the position", string.Join("[Left]", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6EA RID: 50922 RVA: 0x00483B88 File Offset: 0x00481D88
	private void LIIGHENCIFC(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.OFPKLCAICJA(this.DLGFNCGHLPK());
		}
	}

	// Token: 0x0600C6EB RID: 50923 RVA: 0x00483BF0 File Offset: 0x00481DF0
	public virtual void FHPDJMHPLJA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			(char)-30
		});
		string s = array[0];
		List<string> list = array.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("restrictions\n\n#until: ", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= this.HOGJGGGDPDD;
		Singleton<GameManager>.Instance.CDJJAFLCOGO(new GameManager.FinishedMapEvent(this.BEJELNEHAKF));
		this.LoadProgress();
	}

	// Token: 0x0600C6EC RID: 50924 RVA: 0x00483C8C File Offset: 0x00481E8C
	public virtual void KAEILMBFJHE(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = (char)-19;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_FadeFX", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.NFEKBNOPFBC));
		Singleton<GameManager>.Instance.IDDINACMJAK(new GameManager.FinishedMapEvent(this.BDJEFCKJDNF));
		this.JJPHFPDNDEC();
	}

	// Token: 0x0600C6ED RID: 50925 RVA: 0x00483D28 File Offset: 0x00481F28
	public override void HAPELGDNDFN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = (char)-48;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("shader.sunny", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.BEJELNEHAKF));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.OGCLNFHJAHE));
		this.CCGAPNPGAOL();
	}

	// Token: 0x0600C6EE RID: 50926 RVA: 0x00483DC4 File Offset: 0x00481FC4
	public virtual void FMHBLFELOGC()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.PHPLKBPIMIH() + "settings.hitvariation", null);
		base.JGMBGCOFCJI();
	}

	// Token: 0x0600C6EF RID: 50927 RVA: 0x00483DE8 File Offset: 0x00481FE8
	public virtual void KFHEJFGOHIN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = '\u0005';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("DPADVER", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.FOMECIHDEJO));
		Singleton<GameManager>.Instance.PGNNMANJJAC(new GameManager.FinishedMapEvent(this.EIFKFKKKENO));
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C6F0 RID: 50928 RVA: 0x00483E84 File Offset: 0x00482084
	public virtual void MBLDJHOBIMG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = (char)-90;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("Sent count: ", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.EIFKFKKKENO));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.JPEODDLKMPI));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C6F1 RID: 50929 RVA: 0x00483F20 File Offset: 0x00482120
	public override void CCGAPNPGAOL()
	{
		base.CCGAPNPGAOL();
		string text = Singleton<SaveSystem>.Instance.CFLCJCJHNKD(base.DIDHNLABPNG() + "yyyy-MM-dd HH:mm:ss", null);
		if (!string.IsNullOrEmpty(text))
		{
			this.ODBKIFAGALM = text.Split(new char[]
			{
				(char)-37
			}).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = this.DLGFNCGHLPK();
	}

	// Token: 0x0600C6F2 RID: 50930 RVA: 0x00483F94 File Offset: 0x00482194
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
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= this.HOGJGGGDPDD;
		Singleton<GameManager>.Instance.OnFinishedMap += this.HOGJGGGDPDD;
		this.LoadProgress();
	}

	// Token: 0x0600C6F3 RID: 50931 RVA: 0x00484030 File Offset: 0x00482230
	public virtual void CPGAFFIOGCH()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.DIDHNLABPNG() + "[Left]", null);
		base.EEBGCGFNELO();
	}

	// Token: 0x0600C6F4 RID: 50932 RVA: 0x00484053 File Offset: 0x00482253
	public virtual void DGDGIJFIKDE()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.GLALLABIBEH));
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C6F6 RID: 50934 RVA: 0x00484084 File Offset: 0x00482284
	public virtual void FBHAGNFBIHL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = (char)-14;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= this.BDJEFCKJDNF;
		Singleton<GameManager>.Instance.OnFinishedMap += this.NFEKBNOPFBC;
		this.LoadProgress();
	}

	// Token: 0x0600C6F7 RID: 50935 RVA: 0x00484120 File Offset: 0x00482320
	public virtual void EJDGJIHCNOA()
	{
		base.JJPHFPDNDEC();
		string text = Singleton<SaveSystem>.Instance.IPEDKOMAKPP(base.FDHGPNBJKMP() + "CameraFilterPack/Blur_Radial", null);
		if (!string.IsNullOrEmpty(text))
		{
			this.ODBKIFAGALM = text.Split(new char[]
			{
				'\u001d'
			}).ToList<string>();
		}
		else
		{
			this.ODBKIFAGALM = new List<string>();
		}
		base.GoalProgress = this.HBBKCBNFAHL();
	}

	// Token: 0x0600C6F8 RID: 50936 RVA: 0x00484192 File Offset: 0x00482392
	public override void AFFLBJKDKMD()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(base.DIDHNLABPNG() + " room(s)", string.Join("_Distortion", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6F9 RID: 50937 RVA: 0x004841CA File Offset: 0x004823CA
	public override void EEBGCGFNELO()
	{
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP(base.PHPLKBPIMIH() + "BadgeImage", null);
		base.JGMBGCOFCJI();
	}

	// Token: 0x0600C6FA RID: 50938 RVA: 0x004841ED File Offset: 0x004823ED
	public virtual void FPNFJNEABNP()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.BEJELNEHAKF));
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C6FB RID: 50939 RVA: 0x0048420C File Offset: 0x0048240C
	public virtual void COMOGFCIOMP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-36;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("/", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.FHOJKHCHFDB));
		Singleton<GameManager>.Instance.OnFinishedMap += this.BNFMCBKNANL;
		this.LoadProgress();
	}

	// Token: 0x0600C6FC RID: 50940 RVA: 0x004842A8 File Offset: 0x004824A8
	public virtual void FKCNACFMIOD()
	{
		base.IIBGJNGDCGB();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(base.FDHGPNBJKMP() + "SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", string.Join("_TimeX", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6FD RID: 50941 RVA: 0x004842E0 File Offset: 0x004824E0
	public virtual void OGAMGLEAOAF()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(base.PNLACKIPGLD() + "[EMPTY]", null);
		base.Reset();
	}

	// Token: 0x0600C6FE RID: 50942 RVA: 0x00484303 File Offset: 0x00482503
	public virtual void AFCNHKOOHDF()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP(base.FDHGPNBJKMP() + "settings.enableselectormusic", string.Join("_Value2", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C6FF RID: 50943 RVA: 0x0048433C File Offset: 0x0048253C
	public virtual void IACAMALGJKO(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			'{'
		});
		string s = array[1];
		List<string> list = array.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("Save level before uploading?", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.MAPGGELENNM));
		Singleton<GameManager>.Instance.CDJJAFLCOGO(new GameManager.FinishedMapEvent(this.OGCLNFHJAHE));
		this.IJLBKALOBNO();
	}

	// Token: 0x0600C700 RID: 50944 RVA: 0x004843D8 File Offset: 0x004825D8
	private void BDJEFCKJDNF(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.ENHBNIOEKLF(this.AHHAEFIBOAD());
		}
	}

	// Token: 0x0600C701 RID: 50945 RVA: 0x00482751 File Offset: 0x00480951
	private float ODDPHOKLIJJ()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C702 RID: 50946 RVA: 0x0048443D File Offset: 0x0048263D
	public virtual void KBOHCNNJGCN()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.GLALLABIBEH));
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C703 RID: 50947 RVA: 0x0048445C File Offset: 0x0048265C
	public virtual void LBAEJINADDP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = '\u007f';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("_TimeX", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.OnFinishedMap -= this.NFEKBNOPFBC;
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.FOMECIHDEJO));
		this.NAHLBHOLNCG();
	}

	// Token: 0x0600C704 RID: 50948 RVA: 0x004844F8 File Offset: 0x004826F8
	public virtual void BEJNMIKAFON(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-37;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("Mouse1", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.HOGJGGGDPDD));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.BEJELNEHAKF));
		this.DKHLEEPCLEL();
	}

	// Token: 0x0600C705 RID: 50949 RVA: 0x00484594 File Offset: 0x00482794
	public virtual void OKDKEJEJJAN()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(new GameManager.FinishedMapEvent(this.JPEODDLKMPI));
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C706 RID: 50950 RVA: 0x004845B2 File Offset: 0x004827B2
	public virtual void FEFLLKFKCBG()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.DAGHAOBCIFL(base.PHPLKBPIMIH() + "X2", string.Join("_BokehParams", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C707 RID: 50951 RVA: 0x004837A2 File Offset: 0x004819A2
	public virtual void NHDCGONGILN()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= this.HOGJGGGDPDD;
		base.LMCKEFAMAJG();
	}

	// Token: 0x0600C708 RID: 50952 RVA: 0x004845EC File Offset: 0x004827EC
	private void EIFKFKKKENO(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = this.ODDPHOKLIJJ();
		}
	}

	// Token: 0x0600C709 RID: 50953 RVA: 0x00484654 File Offset: 0x00482854
	public virtual void MOOFNOAOAMF(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-34;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("NOISE", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.HOGJGGGDPDD));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.MAPGGELENNM));
		this.IJLBKALOBNO();
	}

	// Token: 0x0600C70A RID: 50954 RVA: 0x004846F0 File Offset: 0x004828F0
	public virtual void DOKEOBBOHEL()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.FHOJKHCHFDB));
		base.OnCompleted();
	}

	// Token: 0x0600C70B RID: 50955 RVA: 0x00482751 File Offset: 0x00480951
	private float JFLGNNHAHEJ()
	{
		return (float)this.ODBKIFAGALM.Count / (float)this.MHLPNLMDILP;
	}

	// Token: 0x0600C70C RID: 50956 RVA: 0x0048470E File Offset: 0x0048290E
	public virtual void JODHOODGJGP()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.KOMAMFOPJID(base.PNLACKIPGLD() + "/", string.Join("Scene", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C70D RID: 50957 RVA: 0x00484746 File Offset: 0x00482946
	public virtual void ODMIEHCODOK()
	{
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(base.PHPLKBPIMIH() + "Text", null);
		base.LIMBEFBJNPL();
	}

	// Token: 0x0600C70E RID: 50958 RVA: 0x0048476C File Offset: 0x0048296C
	public virtual void OOEIABOMFHP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = '~';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("VIGNETTE_CLASSIC", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.HCPDBEPGAPP));
		Singleton<GameManager>.Instance.PGNNMANJJAC(new GameManager.FinishedMapEvent(this.FHOJKHCHFDB));
		this.AFGLHMCLJJN();
	}

	// Token: 0x0600C70F RID: 50959 RVA: 0x00484808 File Offset: 0x00482A08
	public virtual void GCLJDBADLOA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(new char[]
		{
			'\u0019'
		});
		string s = array[1];
		List<string> list = array.ToList<string>();
		list.RemoveAt(1);
		string cbmknplelgp = string.Join("[PlayerController] ", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.AEIIHIGCCOF(new GameManager.FinishedMapEvent(this.BNFMCBKNANL));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.LIIGHENCIFC));
		this.AFGLHMCLJJN();
	}

	// Token: 0x0600C710 RID: 50960 RVA: 0x004848A4 File Offset: 0x00482AA4
	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetString(base.PHPLKBPIMIH() + ".completedMaps", string.Join(",", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C711 RID: 50961 RVA: 0x004848DC File Offset: 0x00482ADC
	public virtual void PCIOHCMKFBE()
	{
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(base.CKOFDGAJCFF() + "_Axis", null);
		base.JGMBGCOFCJI();
	}

	// Token: 0x0600C712 RID: 50962 RVA: 0x004848FF File Offset: 0x00482AFF
	public virtual void IIMKNABKCAL()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.NOEIPDOLJFA(base.FDHGPNBJKMP() + "The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", string.Join("_Value", this.ODBKIFAGALM.ToArray()), null);
	}

	// Token: 0x0600C713 RID: 50963 RVA: 0x00484938 File Offset: 0x00482B38
	private void MAPGGELENNM(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.OFPKLCAICJA(this.ODDPHOKLIJJ());
		}
	}

	// Token: 0x0600C714 RID: 50964 RVA: 0x004849A0 File Offset: 0x00482BA0
	public virtual void PLCBPLLCNIC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = (char)-78;
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join("Tab2Content", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.None);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.DIPOCCCCAKM));
		Singleton<GameManager>.Instance.DCGKDPPLKBP(new GameManager.FinishedMapEvent(this.BDJEFCKJDNF));
		this.CCGAPNPGAOL();
	}

	// Token: 0x0600C715 RID: 50965 RVA: 0x00484A3C File Offset: 0x00482C3C
	public virtual void LECPHJOIGKN()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(base.DIDHNLABPNG() + "_ScreenResolution", null);
		base.LIMBEFBJNPL();
	}

	// Token: 0x0600C716 RID: 50966 RVA: 0x00484A5F File Offset: 0x00482C5F
	public virtual void DINJDLBLOEC()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(base.PNLACKIPGLD() + "float,0", null);
		base.JGMBGCOFCJI();
	}

	// Token: 0x0600C717 RID: 50967 RVA: 0x00484A84 File Offset: 0x00482C84
	public virtual void JLBNGLIKEPA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '.';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList<string>();
		list.RemoveAt(0);
		string cbmknplelgp = string.Join(",", list.ToArray());
		this.MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		this.CBMKNPLELGP = cbmknplelgp;
		this.ODBKIFAGALM = new List<string>();
		Singleton<GameManager>.Instance.BAMDHECMAHG(new GameManager.FinishedMapEvent(this.BEJELNEHAKF));
		Singleton<GameManager>.Instance.PCHIFGNAHCH(new GameManager.FinishedMapEvent(this.NFEKBNOPFBC));
		this.LoadProgress();
	}

	// Token: 0x0600C718 RID: 50968 RVA: 0x00484B20 File Offset: 0x00482D20
	private void GLALLABIBEH(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(this.CBMKNPLELGP) && !this.ODBKIFAGALM.Contains(DAGALCAILLN.mapid))
		{
			this.ODBKIFAGALM.Add(DAGALCAILLN.mapid);
			base.GoalProgress = this.PKFDNFMNMOD();
		}
	}

	// Token: 0x04001741 RID: 5953
	private int MHLPNLMDILP;

	// Token: 0x04001742 RID: 5954
	private string CBMKNPLELGP = "true";

	// Token: 0x04001743 RID: 5955
	private List<string> ODBKIFAGALM;
}
