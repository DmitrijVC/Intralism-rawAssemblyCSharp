using System;
using ExitGames.Client.Photon;

// Token: 0x0200031E RID: 798
public class RoomInfo
{
	// Token: 0x0600B713 RID: 46867 RVA: 0x004344C9 File Offset: 0x004326C9
	internal void MJFHIPPPIFC(bool DPNHODJHGJL)
	{
		this.<DCAKFOHNABM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B714 RID: 46868 RVA: 0x004344D4 File Offset: 0x004326D4
	public virtual string PIHOCGDHMDH()
	{
		string format = "Creating new item...";
		object[] array = new object[6];
		array[1] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? "_TimeX" : "Bad parameters for getstring! Use <key> <value>");
		array[4] = ((!this.PNAALABONJG) ? "Joystick1Button8" : "EditMenu");
		array[0] = this.MDLLBJEFCCJ;
		array[2] = this.IHCFPJIDFOP();
		return string.Format(format, array);
	}

	// Token: 0x0600B715 RID: 46869 RVA: 0x00434550 File Offset: 0x00432750
	public bool PMBLEHFDGCN()
	{
		return this.NJDMEIOHILA();
	}

	// Token: 0x0600B716 RID: 46870 RVA: 0x00434558 File Offset: 0x00432758
	public void HFHFBFPMIHG(bool DPNHODJHGJL)
	{
		this.GMAADPICNOF(DPNHODJHGJL);
	}

	// Token: 0x0600B717 RID: 46871 RVA: 0x00434561 File Offset: 0x00432761
	public bool EEKFKBANKFH()
	{
		return this.FKPGMMEIEJD();
	}

	// Token: 0x0600B718 RID: 46872 RVA: 0x00434569 File Offset: 0x00432769
	public bool NMBLKEMKGFL()
	{
		return this.DBFGBOLNOIO();
	}

	// Token: 0x0600B719 RID: 46873 RVA: 0x00434574 File Offset: 0x00432774
	protected internal void NPOPPIMCDMN(Hashtable KBKCLMDMKCF)
	{
		if (KBKCLMDMKCF == null || KBKCLMDMKCF.Count == 0 || this.ILOIDCICMKC.Equals(KBKCLMDMKCF))
		{
			return;
		}
		if (KBKCLMDMKCF.ContainsKey(251))
		{
			this.removedFromList = (bool)KBKCLMDMKCF[251];
			if (this.removedFromList)
			{
				return;
			}
		}
		if (KBKCLMDMKCF.ContainsKey(255))
		{
			this.MDLLBJEFCCJ = (byte)KBKCLMDMKCF[byte.MaxValue];
		}
		if (KBKCLMDMKCF.ContainsKey(253))
		{
			this.PNAALABONJG = (bool)KBKCLMDMKCF[253];
		}
		if (KBKCLMDMKCF.ContainsKey(254))
		{
			this.FMPBAGHEJDN = (bool)KBKCLMDMKCF[254];
		}
		if (KBKCLMDMKCF.ContainsKey(252))
		{
			this.PlayerCount = (int)((byte)KBKCLMDMKCF[252]);
		}
		if (KBKCLMDMKCF.ContainsKey(249))
		{
			this.FECDEAJPAAJ = (bool)KBKCLMDMKCF[249];
		}
		if (KBKCLMDMKCF.ContainsKey(248))
		{
			this.BDHOOLIDFJO = true;
			bool flag = this.IPBANMNLDPC != 0;
			this.IPBANMNLDPC = (int)KBKCLMDMKCF[248];
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.ELDLAPJAPBJ();
			}
		}
		if (KBKCLMDMKCF.ContainsKey(247))
		{
			this.GFEDJEMJEND = (string[])KBKCLMDMKCF[247];
		}
		this.ILOIDCICMKC.MergeStringKeys(KBKCLMDMKCF);
		this.ILOIDCICMKC.StripKeysWithNullValues();
	}

	// Token: 0x0600B71A RID: 46874 RVA: 0x004344C9 File Offset: 0x004326C9
	internal void HEPDIDMOOBL(bool DPNHODJHGJL)
	{
		this.<DCAKFOHNABM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B71B RID: 46875 RVA: 0x00432F5C File Offset: 0x0043115C
	public string DHFECLEBANC()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x0600B71C RID: 46876 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool IsOpen
	{
		get
		{
			return this.PNAALABONJG;
		}
	}

	// Token: 0x0600B71D RID: 46877 RVA: 0x0043476C File Offset: 0x0043296C
	public virtual bool FAEELIPGIBL(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || this.IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B71E RID: 46878 RVA: 0x004330ED File Offset: 0x004312ED
	public byte HAKOLKCNMME()
	{
		return this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B71F RID: 46879 RVA: 0x0043479C File Offset: 0x0043299C
	public string ToStringFull()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", new object[]
		{
			this.LCKGKDLCFMC,
			(!this.FMPBAGHEJDN) ? "hidden" : "visible",
			(!this.PNAALABONJG) ? "closed" : "open",
			this.MDLLBJEFCCJ,
			this.PlayerCount,
			this.ILOIDCICMKC.ToStringFull()
		});
	}

	// Token: 0x0600B720 RID: 46880 RVA: 0x00432F5C File Offset: 0x0043115C
	public string LLDKMIJOMJE()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B721 RID: 46881 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool KEFEAENEDJO()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x0600B722 RID: 46882 RVA: 0x004330ED File Offset: 0x004312ED
	public byte LGGHIADHKAO()
	{
		return this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B723 RID: 46883 RVA: 0x00434826 File Offset: 0x00432A26
	public void JPMNHFMALJB(bool DPNHODJHGJL)
	{
		this.<GBODHEAGOGK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B724 RID: 46884 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool NJDMEIOHILA()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B725 RID: 46885 RVA: 0x0043482F File Offset: 0x00432A2F
	public Hashtable FLIGPINOOGI()
	{
		return this.ILOIDCICMKC;
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x0600B726 RID: 46886 RVA: 0x00432F5C File Offset: 0x0043115C
	public string Name
	{
		get
		{
			return this.LCKGKDLCFMC;
		}
	}

	// Token: 0x0600B727 RID: 46887 RVA: 0x00434838 File Offset: 0x00432A38
	public virtual bool IAIKFPLMECP(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || this.KPOEKHOONAE().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B728 RID: 46888 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool EPJBEHKANHJ()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x0600B729 RID: 46889 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool IMGLOFGLDJK()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x0600B72A RID: 46890 RVA: 0x00434866 File Offset: 0x00432A66
	// (set) Token: 0x0600B746 RID: 46918 RVA: 0x004344C9 File Offset: 0x004326C9
	public bool removedFromList { get; internal set; }

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x0600B72B RID: 46891 RVA: 0x0043482F File Offset: 0x00432A2F
	public Hashtable CustomProperties
	{
		get
		{
			return this.ILOIDCICMKC;
		}
	}

	// Token: 0x0600B72C RID: 46892 RVA: 0x0043486E File Offset: 0x00432A6E
	public int FEABBJGGNEA()
	{
		return this.<MENHEBDBIFC>k__BackingField;
	}

	// Token: 0x0600B72D RID: 46893 RVA: 0x004330ED File Offset: 0x004312ED
	public byte LEGDCDGCALI()
	{
		return this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B72E RID: 46894 RVA: 0x00434876 File Offset: 0x00432A76
	public void FDPCDHGJFGA(bool DPNHODJHGJL)
	{
		this.BFPOAJNHBLE(DPNHODJHGJL);
	}

	// Token: 0x0600B72F RID: 46895 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool ALKCGCIEJDD()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B730 RID: 46896 RVA: 0x0043487F File Offset: 0x00432A7F
	public void EFJLOAJOGID(int DPNHODJHGJL)
	{
		this.PlayerCount = DPNHODJHGJL;
	}

	// Token: 0x0600B731 RID: 46897 RVA: 0x00432F5C File Offset: 0x0043115C
	public string HOKHGFFAKGG()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B732 RID: 46898 RVA: 0x0043482F File Offset: 0x00432A2F
	public Hashtable BGOPIJPICLJ()
	{
		return this.ILOIDCICMKC;
	}

	// Token: 0x0600B733 RID: 46899 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool DBFGBOLNOIO()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x0600B734 RID: 46900 RVA: 0x00434888 File Offset: 0x00432A88
	// (set) Token: 0x0600B79E RID: 47006 RVA: 0x004350D2 File Offset: 0x004332D2
	[Obsolete("Please use IsLocalClientInside (updated case for naming).")]
	public bool isLocalClientInside
	{
		get
		{
			return this.IsLocalClientInside;
		}
		set
		{
			this.IsLocalClientInside = value;
		}
	}

	// Token: 0x0600B735 RID: 46901 RVA: 0x00434890 File Offset: 0x00432A90
	public bool PKEEBGMKFCD()
	{
		return this.KCLILCMPKIF();
	}

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x0600B748 RID: 46920 RVA: 0x004348E8 File Offset: 0x00432AE8
	// (set) Token: 0x0600B736 RID: 46902 RVA: 0x00434898 File Offset: 0x00432A98
	protected internal bool BDHOOLIDFJO { get; private set; }

	// Token: 0x0600B737 RID: 46903 RVA: 0x004348A1 File Offset: 0x00432AA1
	public bool MCJCLCKFPLG()
	{
		return this.IMGLOFGLDJK();
	}

	// Token: 0x0600B738 RID: 46904 RVA: 0x004348A9 File Offset: 0x00432AA9
	public int HGEDKPOGLFC()
	{
		return this.PlayerCount;
	}

	// Token: 0x0600B739 RID: 46905 RVA: 0x004348B1 File Offset: 0x00432AB1
	public Hashtable EHLPGMBBDLG()
	{
		return this.CustomProperties;
	}

	// Token: 0x0600B73A RID: 46906 RVA: 0x00434888 File Offset: 0x00432A88
	public bool JIOMABAFFGE()
	{
		return this.IsLocalClientInside;
	}

	// Token: 0x0600B73B RID: 46907 RVA: 0x00434826 File Offset: 0x00432A26
	public void GMAADPICNOF(bool DPNHODJHGJL)
	{
		this.<GBODHEAGOGK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x0600B73C RID: 46908 RVA: 0x004348B9 File Offset: 0x00432AB9
	// (set) Token: 0x0600B76B RID: 46955 RVA: 0x00434826 File Offset: 0x00432A26
	public bool IsLocalClientInside { get; set; }

	// Token: 0x0600B73D RID: 46909 RVA: 0x004348C1 File Offset: 0x00432AC1
	public virtual int JNPJFOJAJFG()
	{
		return this.LCKGKDLCFMC.GetHashCode();
	}

	// Token: 0x0600B73E RID: 46910 RVA: 0x004348CE File Offset: 0x00432ACE
	private void PDAPBBGFOHE(int DPNHODJHGJL)
	{
		this.<MENHEBDBIFC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B73F RID: 46911 RVA: 0x004348C1 File Offset: 0x00432AC1
	public override int GetHashCode()
	{
		return this.LCKGKDLCFMC.GetHashCode();
	}

	// Token: 0x0600B740 RID: 46912 RVA: 0x004348D7 File Offset: 0x00432AD7
	public byte HLICJKDDECK()
	{
		return this.LEGDCDGCALI();
	}

	// Token: 0x0600B741 RID: 46913 RVA: 0x004348DF File Offset: 0x00432ADF
	public void JPBAEFPAABM(bool DPNHODJHGJL)
	{
		this.JPMNHFMALJB(DPNHODJHGJL);
	}

	// Token: 0x0600B742 RID: 46914 RVA: 0x004330ED File Offset: 0x004312ED
	public byte FMPNAJBBAMM()
	{
		return this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B743 RID: 46915 RVA: 0x00432F5C File Offset: 0x0043115C
	public string KPOEKHOONAE()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B744 RID: 46916 RVA: 0x00434876 File Offset: 0x00432A76
	public void DHMKNLPFOKE(bool DPNHODJHGJL)
	{
		this.BFPOAJNHBLE(DPNHODJHGJL);
	}

	// Token: 0x0600B745 RID: 46917 RVA: 0x004348CE File Offset: 0x00432ACE
	private void GMHFOPLAHFA(int DPNHODJHGJL)
	{
		this.<MENHEBDBIFC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B747 RID: 46919 RVA: 0x004344C9 File Offset: 0x004326C9
	internal void FFDJINLBACL(bool DPNHODJHGJL)
	{
		this.<DCAKFOHNABM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x0600B749 RID: 46921 RVA: 0x004348F0 File Offset: 0x00432AF0
	[Obsolete("Please use IsOpen (updated case for naming).")]
	public bool open
	{
		get
		{
			return this.IsOpen;
		}
	}

	// Token: 0x0600B74A RID: 46922 RVA: 0x00434898 File Offset: 0x00432A98
	private void DFFOIFOINGL(bool DPNHODJHGJL)
	{
		this.<IGNEFDJICLF>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x0600B74B RID: 46923 RVA: 0x004348F8 File Offset: 0x00432AF8
	[Obsolete("Please use IsVisible (updated case for naming).")]
	public bool visible
	{
		get
		{
			return this.IsVisible;
		}
	}

	// Token: 0x0600B74C RID: 46924 RVA: 0x0043482F File Offset: 0x00432A2F
	public Hashtable MMANMADHAND()
	{
		return this.ILOIDCICMKC;
	}

	// Token: 0x0600B74D RID: 46925 RVA: 0x00434900 File Offset: 0x00432B00
	public override bool Equals(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && this.Name.Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B74E RID: 46926 RVA: 0x00434930 File Offset: 0x00432B30
	public virtual bool JPGKHHINOIL(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || this.CGPHGEJJENL().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B74F RID: 46927 RVA: 0x00432F5C File Offset: 0x0043115C
	public string IAACBCKEOKI()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B750 RID: 46928 RVA: 0x0043495E File Offset: 0x00432B5E
	public void DCKHCGMJDHF(bool DPNHODJHGJL)
	{
		this.CIJJEMMHBGM(DPNHODJHGJL);
	}

	// Token: 0x0600B751 RID: 46929 RVA: 0x00434968 File Offset: 0x00432B68
	public virtual bool OPJOBDOOGPB(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && this.IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B752 RID: 46930 RVA: 0x00434996 File Offset: 0x00432B96
	public Hashtable OJKFLHKNPKO()
	{
		return this.FLIGPINOOGI();
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x0600B753 RID: 46931 RVA: 0x004348A9 File Offset: 0x00432AA9
	// (set) Token: 0x0600B7A6 RID: 47014 RVA: 0x0043487F File Offset: 0x00432A7F
	[Obsolete("Please use PlayerCount (updated case for naming).")]
	public int playerCount
	{
		get
		{
			return this.PlayerCount;
		}
		set
		{
			this.PlayerCount = value;
		}
	}

	// Token: 0x0600B754 RID: 46932 RVA: 0x004349A0 File Offset: 0x00432BA0
	public string HBKDADPEFLP()
	{
		string format = "_TimeX";
		object[] array = new object[4];
		array[1] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "CameraFilterPack_Paper2" : "_BaseTex");
		array[5] = ((!this.PNAALABONJG) ? ".completedMaps" : ".completedMaps");
		array[7] = this.MDLLBJEFCCJ;
		array[2] = this.BFMOMEFLOPF();
		array[1] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B755 RID: 46933 RVA: 0x00434A2A File Offset: 0x00432C2A
	protected internal RoomInfo(string IOJPMCOBHEJ, Hashtable EAOBCIPOENN)
	{
		this.NPOPPIMCDMN(EAOBCIPOENN);
		this.LCKGKDLCFMC = IOJPMCOBHEJ;
	}

	// Token: 0x0600B756 RID: 46934 RVA: 0x004348B1 File Offset: 0x00432AB1
	public Hashtable PFFHNNODEMM()
	{
		return this.CustomProperties;
	}

	// Token: 0x0600B757 RID: 46935 RVA: 0x00434A64 File Offset: 0x00432C64
	public string JCBKKBIANLD()
	{
		string format = "RequestForPickupItems";
		object[] array = new object[6];
		array[0] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? "_SweaterSize" : "EditMenu");
		array[6] = ((!this.PNAALABONJG) ? "Paste events" : "ArcsHitsoundTimeDelaySlider");
		array[1] = this.MDLLBJEFCCJ;
		array[5] = this.PlayerCount;
		array[1] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B758 RID: 46936 RVA: 0x0043486E File Offset: 0x00432A6E
	public int IPOLOPNJIHB()
	{
		return this.<MENHEBDBIFC>k__BackingField;
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x0600B759 RID: 46937 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool IsVisible
	{
		get
		{
			return this.FMPBAGHEJDN;
		}
	}

	// Token: 0x0600B75A RID: 46938 RVA: 0x00434AF0 File Offset: 0x00432CF0
	public virtual bool GIILICBCEEB(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || this.DHFECLEBANC().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B75B RID: 46939 RVA: 0x00434B1E File Offset: 0x00432D1E
	public bool GKCAPAFNILA()
	{
		return this.NNKPAPHLCIN();
	}

	// Token: 0x0600B75C RID: 46940 RVA: 0x00434898 File Offset: 0x00432A98
	private void MKKAMEBKKDK(bool DPNHODJHGJL)
	{
		this.<IGNEFDJICLF>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B75D RID: 46941 RVA: 0x0043487F File Offset: 0x00432A7F
	public void BKDNGAJNOCI(int DPNHODJHGJL)
	{
		this.PlayerCount = DPNHODJHGJL;
	}

	// Token: 0x0600B75E RID: 46942 RVA: 0x00434B28 File Offset: 0x00432D28
	public virtual bool CJHGNEBNMNB(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo == null || this.DHFECLEBANC().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B75F RID: 46943 RVA: 0x004330ED File Offset: 0x004312ED
	public byte NGEMOEEPDMC()
	{
		return this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B760 RID: 46944 RVA: 0x00434569 File Offset: 0x00432769
	public bool DHHCGHCIEDK()
	{
		return this.DBFGBOLNOIO();
	}

	// Token: 0x0600B761 RID: 46945 RVA: 0x00434898 File Offset: 0x00432A98
	private void EGNGCMILMND(bool DPNHODJHGJL)
	{
		this.<IGNEFDJICLF>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B762 RID: 46946 RVA: 0x004348C1 File Offset: 0x00432AC1
	public virtual int CGLEEFLBJIE()
	{
		return this.LCKGKDLCFMC.GetHashCode();
	}

	// Token: 0x0600B763 RID: 46947 RVA: 0x0043482F File Offset: 0x00432A2F
	public Hashtable ODKNHODFPJK()
	{
		return this.ILOIDCICMKC;
	}

	// Token: 0x0600B764 RID: 46948 RVA: 0x00434B56 File Offset: 0x00432D56
	public void NNDCPJBINJE(int DPNHODJHGJL)
	{
		this.GMHFOPLAHFA(DPNHODJHGJL);
	}

	// Token: 0x0600B765 RID: 46949 RVA: 0x00434B56 File Offset: 0x00432D56
	public void IBBLDNKGBNL(int DPNHODJHGJL)
	{
		this.GMHFOPLAHFA(DPNHODJHGJL);
	}

	// Token: 0x0600B766 RID: 46950 RVA: 0x0043495E File Offset: 0x00432B5E
	public void PJHAPBDFMBH(bool DPNHODJHGJL)
	{
		this.CIJJEMMHBGM(DPNHODJHGJL);
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x0600B767 RID: 46951 RVA: 0x004330ED File Offset: 0x004312ED
	public byte MaxPlayers
	{
		get
		{
			return this.MDLLBJEFCCJ;
		}
	}

	// Token: 0x0600B768 RID: 46952 RVA: 0x00432F5C File Offset: 0x0043115C
	public string EGDILAHOLCC()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B769 RID: 46953 RVA: 0x00434B5F File Offset: 0x00432D5F
	public bool EINCKBNFALL()
	{
		return this.KEFEAENEDJO();
	}

	// Token: 0x0600B76A RID: 46954 RVA: 0x00434826 File Offset: 0x00432A26
	public void CIJJEMMHBGM(bool DPNHODJHGJL)
	{
		this.<GBODHEAGOGK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B76C RID: 46956 RVA: 0x00434888 File Offset: 0x00432A88
	public bool GAPAFCEEHIP()
	{
		return this.IsLocalClientInside;
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x0600B799 RID: 47001 RVA: 0x0043486E File Offset: 0x00432A6E
	// (set) Token: 0x0600B76D RID: 46957 RVA: 0x004348CE File Offset: 0x00432ACE
	public int PlayerCount { get; private set; }

	// Token: 0x0600B76E RID: 46958 RVA: 0x00434866 File Offset: 0x00432A66
	public bool DCEBNBGKFHC()
	{
		return this.<DCAKFOHNABM>k__BackingField;
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x0600B76F RID: 46959 RVA: 0x00434B67 File Offset: 0x00432D67
	[Obsolete("Please use Name (updated case for naming).")]
	public string name
	{
		get
		{
			return this.Name;
		}
	}

	// Token: 0x0600B770 RID: 46960 RVA: 0x00434B70 File Offset: 0x00432D70
	public virtual string BEKGOMJHHND()
	{
		string format = "SetSpeed";
		object[] array = new object[8];
		array[1] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "Testing, the group has toggled [" : "_MainTex2");
		array[4] = ((!this.PNAALABONJG) ? "NetworkCanvas" : "_Value2");
		array[8] = this.MDLLBJEFCCJ;
		array[3] = this.BFMOMEFLOPF();
		return string.Format(format, array);
	}

	// Token: 0x0600B771 RID: 46961 RVA: 0x00434BEC File Offset: 0x00432DEC
	public virtual string AAPCGENPDKE()
	{
		string format = "mapselector.filter.subscribedonly";
		object[] array = new object[0];
		array[1] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? "recipes" : "_ScreenResolution");
		array[6] = ((!this.PNAALABONJG) ? "_VignetteBlur" : "menutheme.summerbreeze");
		array[8] = this.MDLLBJEFCCJ;
		array[1] = this.FEABBJGGNEA();
		return string.Format(format, array);
	}

	// Token: 0x0600B772 RID: 46962 RVA: 0x00434C68 File Offset: 0x00432E68
	public bool BHLIJAIEGIM()
	{
		return this.EPJBEHKANHJ();
	}

	// Token: 0x0600B773 RID: 46963 RVA: 0x00434C70 File Offset: 0x00432E70
	public string CNJIIFJGNDM()
	{
		string format = "sfxVolume";
		object[] array = new object[3];
		array[1] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "_Value" : "event");
		array[5] = ((!this.PNAALABONJG) ? "_TimeX" : "Up");
		array[5] = this.MDLLBJEFCCJ;
		array[8] = this.IHCFPJIDFOP();
		array[1] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B774 RID: 46964 RVA: 0x00434550 File Offset: 0x00432750
	public bool JAMCLPIFMED()
	{
		return this.NJDMEIOHILA();
	}

	// Token: 0x0600B775 RID: 46965 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool NKIENLFMMOL()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x0600B776 RID: 46966 RVA: 0x00434CFA File Offset: 0x00432EFA
	public Hashtable KMBLODHBAFO()
	{
		return this.BGOPIJPICLJ();
	}

	// Token: 0x0600B777 RID: 46967 RVA: 0x004348CE File Offset: 0x00432ACE
	private void INGBNFJELAJ(int DPNHODJHGJL)
	{
		this.<MENHEBDBIFC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B778 RID: 46968 RVA: 0x004348A9 File Offset: 0x00432AA9
	public int EOCKFCNGHAD()
	{
		return this.PlayerCount;
	}

	// Token: 0x0600B779 RID: 46969 RVA: 0x00434D04 File Offset: 0x00432F04
	public string GGDFOHIGJLK()
	{
		string format = "[Up-Right]";
		object[] array = new object[4];
		array[1] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "0,2,true,0" : "_Offsets");
		array[7] = ((!this.PNAALABONJG) ? "_ScreenResolution" : "event");
		array[7] = this.MDLLBJEFCCJ;
		array[2] = this.IPOLOPNJIHB();
		array[0] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B77A RID: 46970 RVA: 0x00434D90 File Offset: 0x00432F90
	public string IMCIGKBAJKJ()
	{
		string format = ".jpg";
		object[] array = new object[7];
		array[1] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? " " : "_HardBlend");
		array[7] = ((!this.PNAALABONJG) ? "CameraFilterPack/Drawing_CellShading" : "[MapsSystem] Unloading maps resources...");
		array[5] = this.MDLLBJEFCCJ;
		array[8] = this.BFMOMEFLOPF();
		array[0] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B77B RID: 46971 RVA: 0x004344C9 File Offset: 0x004326C9
	internal void OBBPPCHMOOM(bool DPNHODJHGJL)
	{
		this.<DCAKFOHNABM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B77C RID: 46972 RVA: 0x00434E1C File Offset: 0x0043301C
	public virtual string NHHOIHIOCDI()
	{
		string format = "settings.disablestoryboard";
		object[] array = new object[]
		{
			null,
			this.LCKGKDLCFMC
		};
		array[1] = ((!this.FMPBAGHEJDN) ? "Set sun audio input" : "yyyy-MM-dd HH:mm:ss");
		array[4] = ((!this.PNAALABONJG) ? "CameraFilterPack/Color_YUV" : "Set Object Scale");
		array[8] = this.MDLLBJEFCCJ;
		array[6] = this.BFMOMEFLOPF();
		return string.Format(format, array);
	}

	// Token: 0x0600B77D RID: 46973 RVA: 0x00434E98 File Offset: 0x00433098
	public string OENLPGLAELP()
	{
		string format = "settings.crosshairopacity";
		object[] array = new object[6];
		array[0] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "_Value2" : "players");
		array[7] = ((!this.PNAALABONJG) ? "settings.volume.editor" : "_Value3");
		array[2] = this.MDLLBJEFCCJ;
		array[0] = this.PlayerCount;
		array[0] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B77E RID: 46974 RVA: 0x004344C9 File Offset: 0x004326C9
	internal void GAGJIOPKAGB(bool DPNHODJHGJL)
	{
		this.<DCAKFOHNABM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B77F RID: 46975 RVA: 0x00434866 File Offset: 0x00432A66
	public bool HDBGEHLINHJ()
	{
		return this.<DCAKFOHNABM>k__BackingField;
	}

	// Token: 0x0600B780 RID: 46976 RVA: 0x00434F24 File Offset: 0x00433124
	public virtual bool JHCGGHMMEDK(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && this.IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B781 RID: 46977 RVA: 0x00432F5C File Offset: 0x0043115C
	public string CGPHGEJJENL()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B782 RID: 46978 RVA: 0x00434F52 File Offset: 0x00433152
	public int MLOONFAAGLG()
	{
		return this.BFMOMEFLOPF();
	}

	// Token: 0x0600B783 RID: 46979 RVA: 0x004330ED File Offset: 0x004312ED
	public byte CKKLGDMDFPN()
	{
		return this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B784 RID: 46980 RVA: 0x00434F5A File Offset: 0x0043315A
	public string DPGOJAHONLO()
	{
		return this.CGPHGEJJENL();
	}

	// Token: 0x0600B785 RID: 46981 RVA: 0x00434F64 File Offset: 0x00433164
	public virtual bool BPOBCHFLHPO(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && this.Name.Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B786 RID: 46982 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool NNKPAPHLCIN()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B787 RID: 46983 RVA: 0x00434F92 File Offset: 0x00433192
	public void ADMDCAKOJKI(int DPNHODJHGJL)
	{
		this.INGBNFJELAJ(DPNHODJHGJL);
	}

	// Token: 0x0600B788 RID: 46984 RVA: 0x0043486E File Offset: 0x00432A6E
	public int BFMOMEFLOPF()
	{
		return this.<MENHEBDBIFC>k__BackingField;
	}

	// Token: 0x0600B789 RID: 46985 RVA: 0x0043486E File Offset: 0x00432A6E
	public int IHCFPJIDFOP()
	{
		return this.<MENHEBDBIFC>k__BackingField;
	}

	// Token: 0x0600B78A RID: 46986 RVA: 0x00434F9C File Offset: 0x0043319C
	public virtual string BIKPHEFOKOC()
	{
		string format = "icon";
		object[] array = new object[3];
		array[1] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "\n" : "settings.enablerankingnotifications");
		array[4] = ((!this.PNAALABONJG) ? "_CutOff" : "_Value");
		array[7] = this.MDLLBJEFCCJ;
		array[7] = this.FEABBJGGNEA();
		return string.Format(format, array);
	}

	// Token: 0x0600B78B RID: 46987 RVA: 0x00434C68 File Offset: 0x00432E68
	public bool LPBKMHINIIL()
	{
		return this.EPJBEHKANHJ();
	}

	// Token: 0x0600B78C RID: 46988 RVA: 0x00435018 File Offset: 0x00433218
	public override string ToString()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.", new object[]
		{
			this.LCKGKDLCFMC,
			(!this.FMPBAGHEJDN) ? "hidden" : "visible",
			(!this.PNAALABONJG) ? "closed" : "open",
			this.MDLLBJEFCCJ,
			this.PlayerCount
		});
	}

	// Token: 0x0600B78D RID: 46989 RVA: 0x004348E8 File Offset: 0x00432AE8
	protected internal bool APLNBBHLMFP()
	{
		return this.<IGNEFDJICLF>k__BackingField;
	}

	// Token: 0x0600B78E RID: 46990 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool FKPGMMEIEJD()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600B78F RID: 46991 RVA: 0x00435094 File Offset: 0x00433294
	[Obsolete("Please use MaxPlayers (updated case for naming).")]
	public byte maxPlayers
	{
		get
		{
			return this.MaxPlayers;
		}
	}

	// Token: 0x0600B790 RID: 46992 RVA: 0x004348B9 File Offset: 0x00432AB9
	public bool BMCMFOHDLOP()
	{
		return this.<GBODHEAGOGK>k__BackingField;
	}

	// Token: 0x0600B791 RID: 46993 RVA: 0x0043509C File Offset: 0x0043329C
	public int GPJHLKJLFOM()
	{
		return this.FEABBJGGNEA();
	}

	// Token: 0x0600B792 RID: 46994 RVA: 0x004348DF File Offset: 0x00432ADF
	public void GMHFJIFDIKL(bool DPNHODJHGJL)
	{
		this.JPMNHFMALJB(DPNHODJHGJL);
	}

	// Token: 0x0600B793 RID: 46995 RVA: 0x0043482F File Offset: 0x00432A2F
	public Hashtable MMPBJBAJAAI()
	{
		return this.ILOIDCICMKC;
	}

	// Token: 0x0600B794 RID: 46996 RVA: 0x004348B9 File Offset: 0x00432AB9
	public bool MOAPFJCANFA()
	{
		return this.<GBODHEAGOGK>k__BackingField;
	}

	// Token: 0x0600B795 RID: 46997 RVA: 0x004344C9 File Offset: 0x004326C9
	internal void INOPPFPKPJE(bool DPNHODJHGJL)
	{
		this.<DCAKFOHNABM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B796 RID: 46998 RVA: 0x00432F5C File Offset: 0x0043115C
	public string OHHFGLCLGAD()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B797 RID: 46999 RVA: 0x00434550 File Offset: 0x00432750
	public bool KLFKAPJIKAN()
	{
		return this.NJDMEIOHILA();
	}

	// Token: 0x0600B798 RID: 47000 RVA: 0x004344C9 File Offset: 0x004326C9
	internal void EBCABOJAIKH(bool DPNHODJHGJL)
	{
		this.<DCAKFOHNABM>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B79A RID: 47002 RVA: 0x00434B1E File Offset: 0x00432D1E
	public bool JHMMCKPCNDL()
	{
		return this.NNKPAPHLCIN();
	}

	// Token: 0x0600B79B RID: 47003 RVA: 0x004348C1 File Offset: 0x00432AC1
	public virtual int PLLLJDJJJKN()
	{
		return this.LCKGKDLCFMC.GetHashCode();
	}

	// Token: 0x0600B79C RID: 47004 RVA: 0x004350A4 File Offset: 0x004332A4
	public virtual bool JOGDFHOLLME(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && this.IAACBCKEOKI().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B79D RID: 47005 RVA: 0x00434826 File Offset: 0x00432A26
	public void BFPOAJNHBLE(bool DPNHODJHGJL)
	{
		this.<GBODHEAGOGK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B79F RID: 47007 RVA: 0x004348B9 File Offset: 0x00432AB9
	public bool KCLILCMPKIF()
	{
		return this.<GBODHEAGOGK>k__BackingField;
	}

	// Token: 0x0600B7A0 RID: 47008 RVA: 0x004330ED File Offset: 0x004312ED
	public byte JNMMOPHKDHB()
	{
		return this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B7A1 RID: 47009 RVA: 0x004350DC File Offset: 0x004332DC
	public virtual bool NPBOHIHIMJA(object AGGOHIAAMHN)
	{
		RoomInfo roomInfo = AGGOHIAAMHN as RoomInfo;
		return roomInfo != null && this.DHFECLEBANC().Equals(roomInfo.LCKGKDLCFMC);
	}

	// Token: 0x0600B7A2 RID: 47010 RVA: 0x0043510C File Offset: 0x0043330C
	public string FNKLJHFHFIL()
	{
		string format = "#tryagain";
		object[] array = new object[4];
		array[0] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "note.5" : "_Value5");
		array[5] = ((!this.PNAALABONJG) ? "_TimeX" : "CameraFilterPack_Glasses_On7");
		array[5] = this.MDLLBJEFCCJ;
		array[5] = this.IPOLOPNJIHB();
		array[0] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B7A3 RID: 47011 RVA: 0x00435198 File Offset: 0x00433398
	public virtual string BNGOOJMFMDB()
	{
		string format = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
		object[] array = new object[]
		{
			this.LCKGKDLCFMC
		};
		array[0] = ((!this.FMPBAGHEJDN) ? "Creating new item..." : ".lastCheckpoint.isMapCompleted");
		array[7] = ((!this.PNAALABONJG) ? "_MainTex2" : "PAUSE [SPACE]");
		array[1] = this.MDLLBJEFCCJ;
		array[7] = this.IHCFPJIDFOP();
		return string.Format(format, array);
	}

	// Token: 0x0600B7A4 RID: 47012 RVA: 0x00435214 File Offset: 0x00433414
	public string LACNKJGENJM()
	{
		string format = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
		object[] array = new object[5];
		array[0] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "_FgOverlap" : "_Value7");
		array[7] = ((!this.PNAALABONJG) ? "CameraFilterPack_Paper2" : "_TimeX");
		array[3] = this.MDLLBJEFCCJ;
		array[3] = this.PlayerCount;
		array[7] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B7A5 RID: 47013 RVA: 0x004352A0 File Offset: 0x004334A0
	public string MJDNELPFKDD()
	{
		string format = "BadgeText";
		object[] array = new object[6];
		array[1] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? "_Value" : "_Red_R");
		array[1] = ((!this.PNAALABONJG) ? "_Green_G" : "LoadMapCanvas");
		array[7] = this.MDLLBJEFCCJ;
		array[3] = this.PlayerCount;
		array[5] = this.ILOIDCICMKC.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x0600B7A7 RID: 47015 RVA: 0x004348B1 File Offset: 0x00432AB1
	[Obsolete("Please use CustomProperties (updated case for naming).")]
	public Hashtable customProperties
	{
		get
		{
			return this.CustomProperties;
		}
	}

	// Token: 0x0600B7A8 RID: 47016 RVA: 0x0043487F File Offset: 0x00432A7F
	public void MELFLLIKPPM(int DPNHODJHGJL)
	{
		this.PlayerCount = DPNHODJHGJL;
	}

	// Token: 0x0600B7A9 RID: 47017 RVA: 0x0043532C File Offset: 0x0043352C
	protected internal void ANMNGNKMHLG(Hashtable KBKCLMDMKCF)
	{
		if (KBKCLMDMKCF == null || KBKCLMDMKCF.Count == 0 || this.ILOIDCICMKC.Equals(KBKCLMDMKCF))
		{
			return;
		}
		if (KBKCLMDMKCF.ContainsKey((byte)-137))
		{
			this.removedFromList = (bool)KBKCLMDMKCF[76];
			if (this.HDBGEHLINHJ())
			{
				return;
			}
		}
		if (KBKCLMDMKCF.ContainsKey(188))
		{
			this.MDLLBJEFCCJ = (byte)KBKCLMDMKCF[(byte)-75];
		}
		if (KBKCLMDMKCF.ContainsKey(175))
		{
			this.PNAALABONJG = (bool)KBKCLMDMKCF[(byte)-102];
		}
		if (KBKCLMDMKCF.ContainsKey(52))
		{
			this.FMPBAGHEJDN = (bool)KBKCLMDMKCF[(byte)-107];
		}
		if (KBKCLMDMKCF.ContainsKey(143))
		{
			this.INGBNFJELAJ((int)((byte)KBKCLMDMKCF[(byte)-94]));
		}
		if (KBKCLMDMKCF.ContainsKey(154))
		{
			this.FECDEAJPAAJ = (bool)KBKCLMDMKCF[(byte)-120];
		}
		if (KBKCLMDMKCF.ContainsKey(134))
		{
			this.BDHOOLIDFJO = false;
			bool flag = this.IPBANMNLDPC != 1;
			this.IPBANMNLDPC = (int)KBKCLMDMKCF[(byte)-114];
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.ELDLAPJAPBJ();
			}
		}
		if (KBKCLMDMKCF.ContainsKey(121))
		{
			this.GFEDJEMJEND = (string[])KBKCLMDMKCF[41];
		}
		this.ILOIDCICMKC.MergeStringKeys(KBKCLMDMKCF);
		this.ILOIDCICMKC.StripKeysWithNullValues();
	}

	// Token: 0x04001577 RID: 5495
	private Hashtable ILOIDCICMKC = new Hashtable();

	// Token: 0x04001578 RID: 5496
	protected byte MDLLBJEFCCJ;

	// Token: 0x04001579 RID: 5497
	protected string[] GFEDJEMJEND;

	// Token: 0x0400157A RID: 5498
	protected bool PNAALABONJG = true;

	// Token: 0x0400157B RID: 5499
	protected bool FMPBAGHEJDN = true;

	// Token: 0x0400157C RID: 5500
	protected bool FECDEAJPAAJ = PhotonNetwork.autoCleanUpPlayerObjects;

	// Token: 0x0400157D RID: 5501
	protected string LCKGKDLCFMC;

	// Token: 0x0400157E RID: 5502
	protected internal int IPBANMNLDPC;
}
