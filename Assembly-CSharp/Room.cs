using System;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200031D RID: 797
public class Room : RoomInfo
{
	// Token: 0x0600B660 RID: 46688 RVA: 0x00432F5C File Offset: 0x0043115C
	public string GJCOLGAHAIO()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B661 RID: 46689 RVA: 0x00432F64 File Offset: 0x00431164
	public void HLPLFJLNCOJ()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-128] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)-173] = this.KLNEGBJPIBO();
		PhotonNetwork.JNJJAMNLOHA.LPJIFHNJBMO(hashtable, hashtable2, true);
	}

	// Token: 0x0600B662 RID: 46690 RVA: 0x00432FB8 File Offset: 0x004311B8
	public void SetExpectedUsers(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[247] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[247] = this.ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2, false);
	}

	// Token: 0x0600B663 RID: 46691 RVA: 0x00432F5C File Offset: 0x0043115C
	public string OFNKBGMDLPG()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B664 RID: 46692 RVA: 0x00433006 File Offset: 0x00431206
	public void NEHHLFLHCGE(bool DPNHODJHGJL)
	{
		this.KHMHEGIDGKK(DPNHODJHGJL);
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x0600B665 RID: 46693 RVA: 0x0043300F File Offset: 0x0043120F
	public string[] ExpectedUsers
	{
		get
		{
			return this.GFEDJEMJEND;
		}
	}

	// Token: 0x0600B666 RID: 46694 RVA: 0x00433018 File Offset: 0x00431218
	public void DNLBOHAENEB(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[46] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(hashtable, null, false);
		this.PropertiesListedInLobby = GNPOEBDMHMP;
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x0600B667 RID: 46695 RVA: 0x00433051 File Offset: 0x00431251
	// (set) Token: 0x0600B697 RID: 46743 RVA: 0x004330DB File Offset: 0x004312DB
	[Obsolete("Please use Name (updated case for naming).")]
	public new string name
	{
		get
		{
			return this.Name;
		}
		internal set
		{
			this.Name = value;
		}
	}

	// Token: 0x0600B668 RID: 46696 RVA: 0x0043305C File Offset: 0x0043125C
	public void FFGICDHDECA(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("maps.");
		}
		if (DPNHODJHGJL != this.PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.IILDKFGHOHK(new Hashtable
			{
				{
					43,
					DPNHODJHGJL
				}
			}, null, true);
		}
		this.PNAALABONJG = DPNHODJHGJL;
	}

	// Token: 0x0600B669 RID: 46697 RVA: 0x004330CA File Offset: 0x004312CA
	public bool KNLMKIPDHOI()
	{
		return this.IsVisible;
	}

	// Token: 0x0600B66A RID: 46698 RVA: 0x004330D2 File Offset: 0x004312D2
	public void KFAEFFBPMMF(bool DPNHODJHGJL)
	{
		this.CFONNEIKKLP(DPNHODJHGJL);
	}

	// Token: 0x0600B66B RID: 46699 RVA: 0x004330DB File Offset: 0x004312DB
	internal void EECGOBHMHDB(string DPNHODJHGJL)
	{
		this.Name = DPNHODJHGJL;
	}

	// Token: 0x0600B66C RID: 46700 RVA: 0x004330E4 File Offset: 0x004312E4
	internal void LAMBHKJLNGG(string DPNHODJHGJL)
	{
		this.AJKPNAAMHMF(DPNHODJHGJL);
	}

	// Token: 0x0600B66D RID: 46701 RVA: 0x004330ED File Offset: 0x004312ED
	public int BAEAAGJIHNJ()
	{
		return (int)this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B66E RID: 46702 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool EFCFJHBJLOD()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B66F RID: 46703 RVA: 0x004330FD File Offset: 0x004312FD
	internal void FGHHNPKKOPJ(string DPNHODJHGJL)
	{
		this.HLPMDBODKKC(DPNHODJHGJL);
	}

	// Token: 0x0600B670 RID: 46704 RVA: 0x004330CA File Offset: 0x004312CA
	public bool IMPLOHMDHAF()
	{
		return this.IsVisible;
	}

	// Token: 0x0600B671 RID: 46705 RVA: 0x00433106 File Offset: 0x00431306
	public string DMALJMMFNFE()
	{
		return this.GJCOLGAHAIO();
	}

	// Token: 0x0600B672 RID: 46706 RVA: 0x00433110 File Offset: 0x00431310
	public string IAIADIGLPGC()
	{
		string format = "_TimeX";
		object[] array = new object[0];
		array[0] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? "Traffic Stats" : "PunRespawn");
		array[0] = ((!this.PNAALABONJG) ? "maps." : ".lastCheckpoint.penaltyScore");
		array[3] = this.MDLLBJEFCCJ;
		array[0] = this.EGPGEMJNPFD();
		array[0] = base.CustomProperties.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B673 RID: 46707 RVA: 0x0043319A File Offset: 0x0043139A
	public string[] GMMNJDMKBFD()
	{
		return this.PropertiesListedInLobby;
	}

	// Token: 0x0600B674 RID: 46708 RVA: 0x0043300F File Offset: 0x0043120F
	public string[] JHFHDOPLLDF()
	{
		return this.GFEDJEMJEND;
	}

	// Token: 0x0600B675 RID: 46709 RVA: 0x004331A4 File Offset: 0x004313A4
	public void SetCustomProperties(Hashtable ENEEBHGAAJH, Hashtable DBBFANEJNGI = null, bool CDBHGINNCOF = false)
	{
		if (ENEEBHGAAJH == null)
		{
			return;
		}
		Hashtable hashtable = ENEEBHGAAJH.StripToStringKeys();
		Hashtable hashtable2 = DBBFANEJNGI.StripToStringKeys();
		bool flag = hashtable2 == null || hashtable2.Count == 0;
		if (PhotonNetwork.offlineMode || flag)
		{
			base.CustomProperties.Merge(hashtable);
			base.CustomProperties.StripKeysWithNullValues();
		}
		if (!PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2, CDBHGINNCOF);
		}
		if (PhotonNetwork.offlineMode || flag)
		{
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonCustomRoomPropertiesChanged, new object[]
			{
				hashtable
			});
		}
	}

	// Token: 0x0600B676 RID: 46710 RVA: 0x004330D2 File Offset: 0x004312D2
	public void OILCDELFIHI(bool DPNHODJHGJL)
	{
		this.CFONNEIKKLP(DPNHODJHGJL);
	}

	// Token: 0x0600B677 RID: 46711 RVA: 0x00433051 File Offset: 0x00431251
	public string GGAPAOIMIBP()
	{
		return this.Name;
	}

	// Token: 0x0600B678 RID: 46712 RVA: 0x00433239 File Offset: 0x00431439
	protected internal int GHDAFLPOLFA()
	{
		return this.IPBANMNLDPC;
	}

	// Token: 0x0600B679 RID: 46713 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool JPNACDODMEF()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B67A RID: 46714 RVA: 0x00433241 File Offset: 0x00431441
	public bool OADOCGJBGLG()
	{
		return this.IFGKKKFBIHE();
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x0600B67B RID: 46715 RVA: 0x00433249 File Offset: 0x00431449
	public new int PlayerCount
	{
		get
		{
			if (PhotonNetwork.playerList != null)
			{
				return PhotonNetwork.playerList.Length;
			}
			return 0;
		}
	}

	// Token: 0x0600B67C RID: 46716 RVA: 0x0043325E File Offset: 0x0043145E
	protected internal void OPEKABONLBO(int DPNHODJHGJL)
	{
		this.IPBANMNLDPC = DPNHODJHGJL;
	}

	// Token: 0x0600B67D RID: 46717 RVA: 0x00433268 File Offset: 0x00431468
	public void GLKILAMADNE(int DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage");
		}
		if (DPNHODJHGJL > -48)
		{
			Debug.LogWarning("</color>" + DPNHODJHGJL + "SlidingArea");
			DPNHODJHGJL = 44;
		}
		if (DPNHODJHGJL != (int)this.MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(new Hashtable
			{
				{
					(byte)-48,
					(byte)DPNHODJHGJL
				}
			}, null, true);
		}
		this.MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	// Token: 0x0600B67E RID: 46718 RVA: 0x00433304 File Offset: 0x00431504
	public bool GEMHINDJHJL()
	{
		return this.MDBBBNDEANK();
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x0600B6A9 RID: 46761 RVA: 0x0043319A File Offset: 0x0043139A
	// (set) Token: 0x0600B67F RID: 46719 RVA: 0x0043330C File Offset: 0x0043150C
	[Obsolete("Please use PropertiesListedInLobby (updated case for naming).")]
	public string[] propertiesListedInLobby
	{
		get
		{
			return this.PropertiesListedInLobby;
		}
		private set
		{
			this.PropertiesListedInLobby = value;
		}
	}

	// Token: 0x0600B680 RID: 46720 RVA: 0x004330ED File Offset: 0x004312ED
	public int AOHMIPHOEBD()
	{
		return (int)this.MDLLBJEFCCJ;
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x0600B6B0 RID: 46768 RVA: 0x00433548 File Offset: 0x00431748
	// (set) Token: 0x0600B681 RID: 46721 RVA: 0x00433315 File Offset: 0x00431515
	[Obsolete("Please use IsOpen (updated case for naming).")]
	public new bool open
	{
		get
		{
			return this.IsOpen;
		}
		set
		{
			this.IsOpen = value;
		}
	}

	// Token: 0x0600B682 RID: 46722 RVA: 0x004330E4 File Offset: 0x004312E4
	internal void BECALLBICNF(string DPNHODJHGJL)
	{
		this.AJKPNAAMHMF(DPNHODJHGJL);
	}

	// Token: 0x0600B683 RID: 46723 RVA: 0x00433315 File Offset: 0x00431515
	public void JOFLMEGAHEE(bool DPNHODJHGJL)
	{
		this.IsOpen = DPNHODJHGJL;
	}

	// Token: 0x0600B684 RID: 46724 RVA: 0x00433320 File Offset: 0x00431520
	public void HGEPILMBPNP()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-121] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)-15] = this.JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(hashtable, hashtable2, true);
	}

	// Token: 0x0600B685 RID: 46725 RVA: 0x00433239 File Offset: 0x00431439
	protected internal int FNIAGLHIBLL()
	{
		return this.IPBANMNLDPC;
	}

	// Token: 0x0600B686 RID: 46726 RVA: 0x00433373 File Offset: 0x00431573
	public int LCKLEMHPLLC()
	{
		return this.DHOGHIOACME();
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x0600B687 RID: 46727 RVA: 0x0043337B File Offset: 0x0043157B
	public bool AutoCleanUp
	{
		get
		{
			return this.FECDEAJPAAJ;
		}
	}

	// Token: 0x0600B688 RID: 46728 RVA: 0x004330D2 File Offset: 0x004312D2
	public void JJIJDMIHOFM(bool DPNHODJHGJL)
	{
		this.CFONNEIKKLP(DPNHODJHGJL);
	}

	// Token: 0x0600B689 RID: 46729 RVA: 0x00432F5C File Offset: 0x0043115C
	public string POPKEPNKIAO()
	{
		return this.LCKGKDLCFMC;
	}

	// Token: 0x0600B68A RID: 46730 RVA: 0x00433383 File Offset: 0x00431583
	private void CBFLHMDCKHO(string[] DPNHODJHGJL)
	{
		this.EICJKLIICLJ(DPNHODJHGJL);
	}

	// Token: 0x0600B68B RID: 46731 RVA: 0x0043338C File Offset: 0x0043158C
	public void PKLPIFABEIA(bool DPNHODJHGJL)
	{
		this.HJGBGMHJMPJ(DPNHODJHGJL);
	}

	// Token: 0x0600B68C RID: 46732 RVA: 0x0043337B File Offset: 0x0043157B
	public bool ONCMEFOOFJF()
	{
		return this.FECDEAJPAAJ;
	}

	// Token: 0x0600B68D RID: 46733 RVA: 0x00433395 File Offset: 0x00431595
	public bool MMHFBAOFHLP()
	{
		return this.JPNACDODMEF();
	}

	// Token: 0x0600B68E RID: 46734 RVA: 0x0043339D File Offset: 0x0043159D
	public bool CBCIPBLGBPO()
	{
		return this.ANMHADBIJGN();
	}

	// Token: 0x0600B68F RID: 46735 RVA: 0x004333A8 File Offset: 0x004315A8
	public void ILPPFLNOCDD(int DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("mapselector.filter.favoriteonly");
		}
		if (DPNHODJHGJL > 49)
		{
			Debug.LogWarning("[MenuScene] Error: " + DPNHODJHGJL + "green");
			DPNHODJHGJL = -86;
		}
		if (DPNHODJHGJL != (int)this.MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable
			{
				{
					90,
					(byte)DPNHODJHGJL
				}
			}, null, true);
		}
		this.MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	// Token: 0x0600B690 RID: 46736 RVA: 0x00433444 File Offset: 0x00431644
	private void AEOBKBDOEBE(string[] DPNHODJHGJL)
	{
		this.BNNFCKHICOP(DPNHODJHGJL);
	}

	// Token: 0x0600B691 RID: 46737 RVA: 0x00433450 File Offset: 0x00431650
	public void BPBICFHHIHF()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[125] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[41] = this.JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.FMDMPEMOAAB(hashtable, hashtable2, true);
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x00433239 File Offset: 0x00431439
	// (set) Token: 0x0600B692 RID: 46738 RVA: 0x0043325E File Offset: 0x0043145E
	protected internal int EJLAPIIGIMI
	{
		get
		{
			return this.IPBANMNLDPC;
		}
		set
		{
			this.IPBANMNLDPC = value;
		}
	}

	// Token: 0x0600B693 RID: 46739 RVA: 0x004334A4 File Offset: 0x004316A4
	public void SetPropertiesListedInLobby(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[250] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, null, false);
		this.PropertiesListedInLobby = GNPOEBDMHMP;
	}

	// Token: 0x0600B694 RID: 46740 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool OKLCDOKCFLB()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B695 RID: 46741 RVA: 0x004334DD File Offset: 0x004316DD
	public int ADKLFKDIBPG()
	{
		return this.PlayerCount;
	}

	// Token: 0x0600B696 RID: 46742 RVA: 0x0043330C File Offset: 0x0043150C
	private void IDGFIBFOOAG(string[] DPNHODJHGJL)
	{
		this.PropertiesListedInLobby = DPNHODJHGJL;
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x0600B698 RID: 46744 RVA: 0x004330CA File Offset: 0x004312CA
	// (set) Token: 0x0600B700 RID: 46848 RVA: 0x00434358 File Offset: 0x00432558
	[Obsolete("Please use IsVisible (updated case for naming).")]
	public new bool visible
	{
		get
		{
			return this.IsVisible;
		}
		set
		{
			this.IsVisible = value;
		}
	}

	// Token: 0x0600B699 RID: 46745 RVA: 0x004334E8 File Offset: 0x004316E8
	public void FHPFCJDEINO(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[16] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[61] = this.ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.LPJIFHNJBMO(hashtable, hashtable2, false);
	}

	// Token: 0x0600B69A RID: 46746 RVA: 0x00433536 File Offset: 0x00431736
	internal void OOLGFNPPJFJ(string DPNHODJHGJL)
	{
		this.LCKGKDLCFMC = DPNHODJHGJL;
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x0600B6F0 RID: 46832 RVA: 0x004340F2 File Offset: 0x004322F2
	// (set) Token: 0x0600B69B RID: 46747 RVA: 0x0043353F File Offset: 0x0043173F
	[Obsolete("Please use MasterClientId (updated case for naming).")]
	protected internal int LHFOBFKEJNA
	{
		get
		{
			return this.EJLAPIIGIMI;
		}
		set
		{
			this.EJLAPIIGIMI = value;
		}
	}

	// Token: 0x0600B69C RID: 46748 RVA: 0x00433548 File Offset: 0x00431748
	public bool OAJEBJIMNLI()
	{
		return this.IsOpen;
	}

	// Token: 0x0600B69D RID: 46749 RVA: 0x00433550 File Offset: 0x00431750
	public void BNLBLHNHOHG(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-33] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[123] = this.ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.DGNOGCOIPIA(hashtable, hashtable2, true);
	}

	// Token: 0x0600B69E RID: 46750 RVA: 0x0043337B File Offset: 0x0043157B
	public bool DJPCNGHHGFG()
	{
		return this.FECDEAJPAAJ;
	}

	// Token: 0x0600B69F RID: 46751 RVA: 0x0043359E File Offset: 0x0043179E
	protected internal int CKDAKMFOPBA()
	{
		return this.COFIGFDNBLJ();
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x0600B6A0 RID: 46752 RVA: 0x004335A6 File Offset: 0x004317A6
	// (set) Token: 0x0600B6C5 RID: 46789 RVA: 0x004335AE File Offset: 0x004317AE
	public string[] PropertiesListedInLobby { get; private set; }

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x0600B6A1 RID: 46753 RVA: 0x004334DD File Offset: 0x004316DD
	[Obsolete("Please use PlayerCount (updated case for naming).")]
	public new int playerCount
	{
		get
		{
			return this.PlayerCount;
		}
	}

	// Token: 0x0600B6A2 RID: 46754 RVA: 0x0043337B File Offset: 0x0043157B
	public bool HDOGIJOMLNI()
	{
		return this.FECDEAJPAAJ;
	}

	// Token: 0x0600B6A3 RID: 46755 RVA: 0x004335AE File Offset: 0x004317AE
	private void EICJKLIICLJ(string[] DPNHODJHGJL)
	{
		this.<HDDFDGJAIJD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B6A4 RID: 46756 RVA: 0x004334DD File Offset: 0x004316DD
	public int MAKNGHPADGI()
	{
		return this.PlayerCount;
	}

	// Token: 0x0600B6A5 RID: 46757 RVA: 0x004335B7 File Offset: 0x004317B7
	public bool BIEGMBPEJLK()
	{
		return this.HDOGIJOMLNI();
	}

	// Token: 0x0600B6A6 RID: 46758 RVA: 0x00433536 File Offset: 0x00431736
	internal void JKMKLMHIDHH(string DPNHODJHGJL)
	{
		this.LCKGKDLCFMC = DPNHODJHGJL;
	}

	// Token: 0x0600B6A7 RID: 46759 RVA: 0x004335C0 File Offset: 0x004317C0
	public virtual string BOKBCLJLOCL()
	{
		string format = "Solo";
		object[] array = new object[]
		{
			this.LCKGKDLCFMC
		};
		array[1] = ((!this.FMPBAGHEJDN) ? "[SteamManager] Connection established, authorization" : "Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
		array[7] = ((!this.PNAALABONJG) ? "settings.selectormapsperpage" : "local CheckCondition = function()");
		array[8] = this.MDLLBJEFCCJ;
		array[3] = this.EGPGEMJNPFD();
		return string.Format(format, array);
	}

	// Token: 0x0600B6A8 RID: 46760 RVA: 0x0043363C File Offset: 0x0043183C
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

	// Token: 0x0600B6AA RID: 46762 RVA: 0x004335A6 File Offset: 0x004317A6
	public string[] FECOFGHMPPA()
	{
		return this.<HDDFDGJAIJD>k__BackingField;
	}

	// Token: 0x0600B6AB RID: 46763 RVA: 0x004336B8 File Offset: 0x004318B8
	public void GJOJMJBKDEI(int DPNHODJHGJL)
	{
		this.NDEBBNGMFFK(DPNHODJHGJL);
	}

	// Token: 0x0600B6AC RID: 46764 RVA: 0x004336C4 File Offset: 0x004318C4
	public void ClearExpectedUsers()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[247] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[247] = this.ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(hashtable, hashtable2, false);
	}

	// Token: 0x0600B6AD RID: 46765 RVA: 0x00433106 File Offset: 0x00431306
	public string CCPCAPGFFNO()
	{
		return this.GJCOLGAHAIO();
	}

	// Token: 0x0600B6AE RID: 46766 RVA: 0x00433051 File Offset: 0x00431251
	public string OBPBFJGEECJ()
	{
		return this.Name;
	}

	// Token: 0x0600B6AF RID: 46767 RVA: 0x00433239 File Offset: 0x00431439
	protected internal int COFIGFDNBLJ()
	{
		return this.IPBANMNLDPC;
	}

	// Token: 0x0600B6B1 RID: 46769 RVA: 0x0043337B File Offset: 0x0043157B
	public bool IHKCBNNMLNK()
	{
		return this.FECDEAJPAAJ;
	}

	// Token: 0x0600B6B2 RID: 46770 RVA: 0x00433718 File Offset: 0x00431918
	public void DGDMIPBJEPN(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-95] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(hashtable, null, false);
		this.EICJKLIICLJ(GNPOEBDMHMP);
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x0600B6B3 RID: 46771 RVA: 0x004330ED File Offset: 0x004312ED
	// (set) Token: 0x0600B6F3 RID: 46835 RVA: 0x004340FC File Offset: 0x004322FC
	public new int MaxPlayers
	{
		get
		{
			return (int)this.MDLLBJEFCCJ;
		}
		set
		{
			if (!this.Equals(PhotonNetwork.room))
			{
				Debug.LogWarning("Can't set MaxPlayers when not in that room.");
			}
			if (value > 255)
			{
				Debug.LogWarning("Can't set Room.MaxPlayers to: " + value + ". Using max value: 255.");
				value = 255;
			}
			if (value != (int)this.MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable
				{
					{
						byte.MaxValue,
						(byte)value
					}
				}, null, false);
			}
			this.MDLLBJEFCCJ = (byte)value;
		}
	}

	// Token: 0x0600B6B4 RID: 46772 RVA: 0x00433754 File Offset: 0x00431954
	public void BGDKAJLOKLP(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_PositionX");
		}
		if (DPNHODJHGJL != this.PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.CADDOMOCLIJ(new Hashtable
			{
				{
					(byte)-130,
					DPNHODJHGJL
				}
			}, null, true);
		}
		this.PNAALABONJG = DPNHODJHGJL;
	}

	// Token: 0x0600B6B5 RID: 46773 RVA: 0x004337C4 File Offset: 0x004319C4
	public void HJGBGMHJMPJ(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("Validating mod pack...");
		}
		if (DPNHODJHGJL != this.FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.CADDOMOCLIJ(new Hashtable
			{
				{
					(byte)-13,
					DPNHODJHGJL
				}
			}, null, false);
		}
		this.FMPBAGHEJDN = DPNHODJHGJL;
	}

	// Token: 0x0600B6B6 RID: 46774 RVA: 0x004330CA File Offset: 0x004312CA
	public bool CNNCLNGNMJA()
	{
		return this.IsVisible;
	}

	// Token: 0x0600B6B7 RID: 46775 RVA: 0x00433832 File Offset: 0x00431A32
	internal void AABGMMMODEO(string DPNHODJHGJL)
	{
		this.JKMKLMHIDHH(DPNHODJHGJL);
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x0600B6F8 RID: 46840 RVA: 0x00433D73 File Offset: 0x00431F73
	// (set) Token: 0x0600B6B8 RID: 46776 RVA: 0x0043383C File Offset: 0x00431A3C
	public new bool IsVisible
	{
		get
		{
			return this.FMPBAGHEJDN;
		}
		set
		{
			if (!this.Equals(PhotonNetwork.room))
			{
				Debug.LogWarning("Can't set visible when not in that room.");
			}
			if (value != this.FMPBAGHEJDN && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable
				{
					{
						254,
						value
					}
				}, null, false);
			}
			this.FMPBAGHEJDN = value;
		}
	}

	// Token: 0x0600B6B9 RID: 46777 RVA: 0x004338AC File Offset: 0x00431AAC
	public void DCNHBEJAGOJ(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-184] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(hashtable, null, false);
		this.EICJKLIICLJ(GNPOEBDMHMP);
	}

	// Token: 0x0600B6BA RID: 46778 RVA: 0x004338E8 File Offset: 0x00431AE8
	public virtual string LCJLNHLMBLN()
	{
		string format = "CameraFilterPack/FX_Glitch3";
		object[] array = new object[5];
		array[1] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "materialsquantity[" : "_Value3");
		array[3] = ((!this.PNAALABONJG) ? "GlassesColor" : "EventTimeInputField");
		array[6] = this.MDLLBJEFCCJ;
		array[0] = this.DHOGHIOACME();
		return string.Format(format, array);
	}

	// Token: 0x0600B6BB RID: 46779 RVA: 0x00433964 File Offset: 0x00431B64
	public void PLDDJCNGIAG(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-43] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)-76] = this.JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.OABLOBEGOPJ(hashtable, hashtable2, true);
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x0600B6BC RID: 46780 RVA: 0x004339B2 File Offset: 0x00431BB2
	[Obsolete("Please use AutoCleanUp (updated case for naming).")]
	public bool autoCleanUp
	{
		get
		{
			return this.AutoCleanUp;
		}
	}

	// Token: 0x0600B6BD RID: 46781 RVA: 0x004339BC File Offset: 0x00431BBC
	public void NEIEIMFAMEK(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_TimeX");
		}
		if (DPNHODJHGJL != this.FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.OABLOBEGOPJ(new Hashtable
			{
				{
					196,
					DPNHODJHGJL
				}
			}, null, true);
		}
		this.FMPBAGHEJDN = DPNHODJHGJL;
	}

	// Token: 0x0600B6BE RID: 46782 RVA: 0x00433A2C File Offset: 0x00431C2C
	public void PEPKBMBJPAP(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-24] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)-178] = this.ExpectedUsers;
		PhotonNetwork.JNJJAMNLOHA.IILDKFGHOHK(hashtable, hashtable2, false);
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x00433A7A File Offset: 0x00431C7A
	// (set) Token: 0x0600B709 RID: 46857 RVA: 0x00434410 File Offset: 0x00432610
	[Obsolete("Please use MaxPlayers (updated case for naming).")]
	public new int maxPlayers
	{
		get
		{
			return this.MaxPlayers;
		}
		set
		{
			this.MaxPlayers = value;
		}
	}

	// Token: 0x0600B6C0 RID: 46784 RVA: 0x0043337B File Offset: 0x0043157B
	public bool MDBBBNDEANK()
	{
		return this.FECDEAJPAAJ;
	}

	// Token: 0x0600B6C1 RID: 46785 RVA: 0x00433A82 File Offset: 0x00431C82
	public void LBHJHCKLANM(bool DPNHODJHGJL)
	{
		this.AOFIBMMLNAA(DPNHODJHGJL);
	}

	// Token: 0x0600B6C2 RID: 46786 RVA: 0x00433A8B File Offset: 0x00431C8B
	public void DGPIBICDDMG(bool DPNHODJHGJL)
	{
		this.EMAPOENGEIN(DPNHODJHGJL);
	}

	// Token: 0x0600B6C3 RID: 46787 RVA: 0x00433239 File Offset: 0x00431439
	protected internal int LKHBADEOGKO()
	{
		return this.IPBANMNLDPC;
	}

	// Token: 0x0600B6C4 RID: 46788 RVA: 0x00433383 File Offset: 0x00431583
	private void EACCKAOBBEP(string[] DPNHODJHGJL)
	{
		this.EICJKLIICLJ(DPNHODJHGJL);
	}

	// Token: 0x0600B6C6 RID: 46790 RVA: 0x00433A94 File Offset: 0x00431C94
	public bool PGFMHJAMBBN()
	{
		return this.AEIGNIMAAMO();
	}

	// Token: 0x0600B6C7 RID: 46791 RVA: 0x00433536 File Offset: 0x00431736
	internal void HLPMDBODKKC(string DPNHODJHGJL)
	{
		this.LCKGKDLCFMC = DPNHODJHGJL;
	}

	// Token: 0x0600B6C8 RID: 46792 RVA: 0x00433106 File Offset: 0x00431306
	public string LEGHJPDPLLC()
	{
		return this.GJCOLGAHAIO();
	}

	// Token: 0x0600B6C9 RID: 46793 RVA: 0x00433A9C File Offset: 0x00431C9C
	public string CEDLOMLHLDJ()
	{
		string format = "Ok";
		object[] array = new object[8];
		array[0] = this.LCKGKDLCFMC;
		array[0] = ((!this.FMPBAGHEJDN) ? "CameraFilterPack/Blend2Camera_HardLight" : "_VignetteBlur");
		array[1] = ((!this.PNAALABONJG) ? "SetSpeed" : "CameraFilterPack/TV_WideScreenHorizontal");
		array[0] = this.MDLLBJEFCCJ;
		array[4] = this.EGPGEMJNPFD();
		array[2] = base.BGOPIJPICLJ().ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B6CA RID: 46794 RVA: 0x00433B26 File Offset: 0x00431D26
	public void DLKAMKFEDPN(int DPNHODJHGJL)
	{
		this.GLKILAMADNE(DPNHODJHGJL);
	}

	// Token: 0x0600B6CB RID: 46795 RVA: 0x00433B30 File Offset: 0x00431D30
	public void ABLMEGAHILA(string[] GNPOEBDMHMP)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[(byte)-120] = GNPOEBDMHMP;
		PhotonNetwork.JNJJAMNLOHA.DGNOGCOIPIA(hashtable, null, true);
		this.NNKLLBPFBNP(GNPOEBDMHMP);
	}

	// Token: 0x0600B6CC RID: 46796 RVA: 0x00433B6C File Offset: 0x00431D6C
	public void EMAPOENGEIN(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_PrevViewProj");
		}
		if (DPNHODJHGJL != this.FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(new Hashtable
			{
				{
					151,
					DPNHODJHGJL
				}
			}, null, true);
		}
		this.FMPBAGHEJDN = DPNHODJHGJL;
	}

	// Token: 0x0600B6CD RID: 46797 RVA: 0x00433A7A File Offset: 0x00431C7A
	public int NBHPLOFGIEK()
	{
		return this.MaxPlayers;
	}

	// Token: 0x0600B6CE RID: 46798 RVA: 0x00433BDA File Offset: 0x00431DDA
	public string[] PAFNCGNIAGD()
	{
		return this.JHFHDOPLLDF();
	}

	// Token: 0x0600B6CF RID: 46799 RVA: 0x00433373 File Offset: 0x00431573
	public int JNOGEIMFFEG()
	{
		return this.DHOGHIOACME();
	}

	// Token: 0x0600B6D0 RID: 46800 RVA: 0x00433239 File Offset: 0x00431439
	protected internal int ICODKICJIFI()
	{
		return this.IPBANMNLDPC;
	}

	// Token: 0x0600B6D1 RID: 46801 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool CLCCCFDCOBA()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B6D2 RID: 46802 RVA: 0x00433BE4 File Offset: 0x00431DE4
	public string OIDHLIBGOHM()
	{
		string format = "_Amount";
		object[] array = new object[0];
		array[0] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? "JITTER" : "_HrDepthTex");
		array[4] = ((!this.PNAALABONJG) ? "_Value3" : ":\n");
		array[1] = this.MDLLBJEFCCJ;
		array[5] = this.DHOGHIOACME();
		array[6] = base.ODKNHODFPJK().ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B6D3 RID: 46803 RVA: 0x0043337B File Offset: 0x0043157B
	public bool AJKJFECAAKD()
	{
		return this.FECDEAJPAAJ;
	}

	// Token: 0x0600B6D4 RID: 46804 RVA: 0x00433C70 File Offset: 0x00431E70
	public void KHMHEGIDGKK(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_BlurTexture");
		}
		if (DPNHODJHGJL != this.PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable
			{
				{
					165,
					DPNHODJHGJL
				}
			}, null, false);
		}
		this.PNAALABONJG = DPNHODJHGJL;
	}

	// Token: 0x0600B6D5 RID: 46805 RVA: 0x00433536 File Offset: 0x00431736
	internal void PKNPMJFGNIO(string DPNHODJHGJL)
	{
		this.LCKGKDLCFMC = DPNHODJHGJL;
	}

	// Token: 0x0600B6D6 RID: 46806 RVA: 0x00433CE0 File Offset: 0x00431EE0
	public string IMKPICGDCNE()
	{
		string format = "BitsData";
		object[] array = new object[]
		{
			null,
			this.LCKGKDLCFMC
		};
		array[0] = ((!this.FMPBAGHEJDN) ? "_Value2" : "0 - default, 1 - left, 2 - right");
		array[4] = ((!this.PNAALABONJG) ? "#rt" : "sounds/no_hit");
		array[3] = this.MDLLBJEFCCJ;
		array[1] = this.PlayerCount;
		array[8] = base.FLIGPINOOGI().ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B6D7 RID: 46807 RVA: 0x00433D6A File Offset: 0x00431F6A
	internal void CJDFCHEGBGK(string DPNHODJHGJL)
	{
		this.OOLGFNPPJFJ(DPNHODJHGJL);
	}

	// Token: 0x0600B6D8 RID: 46808 RVA: 0x00433249 File Offset: 0x00431449
	public int EGPGEMJNPFD()
	{
		if (PhotonNetwork.playerList != null)
		{
			return PhotonNetwork.playerList.Length;
		}
		return 0;
	}

	// Token: 0x0600B6D9 RID: 46809 RVA: 0x004334DD File Offset: 0x004316DD
	public int PALHDLFINIP()
	{
		return this.PlayerCount;
	}

	// Token: 0x0600B6DA RID: 46810 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool NNDHBLBEKLI()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x00432F5C File Offset: 0x0043115C
	// (set) Token: 0x0600B703 RID: 46851 RVA: 0x00433536 File Offset: 0x00431736
	public new string Name
	{
		get
		{
			return this.LCKGKDLCFMC;
		}
		internal set
		{
			this.LCKGKDLCFMC = value;
		}
	}

	// Token: 0x0600B6DC RID: 46812 RVA: 0x00433D7B File Offset: 0x00431F7B
	public bool MBHJNBADDEC()
	{
		return this.AJKJFECAAKD();
	}

	// Token: 0x0600B6DE RID: 46814 RVA: 0x00433D84 File Offset: 0x00431F84
	public void EMNOOHLFLPH(int DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("file://");
		}
		if (DPNHODJHGJL > 72)
		{
			Debug.LogWarning("_MainTex2" + DPNHODJHGJL + "\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ");
			DPNHODJHGJL = 135;
		}
		if (DPNHODJHGJL != (int)this.MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(new Hashtable
			{
				{
					(byte)-46,
					(byte)DPNHODJHGJL
				}
			}, null, true);
		}
		this.MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	// Token: 0x0600B6DF RID: 46815 RVA: 0x0043319A File Offset: 0x0043139A
	public string[] DDMBOBMOODO()
	{
		return this.PropertiesListedInLobby;
	}

	// Token: 0x0600B6E0 RID: 46816 RVA: 0x004330E4 File Offset: 0x004312E4
	internal void DBEEFIJGPGC(string DPNHODJHGJL)
	{
		this.AJKPNAAMHMF(DPNHODJHGJL);
	}

	// Token: 0x0600B6E1 RID: 46817 RVA: 0x004330ED File Offset: 0x004312ED
	public int DDDIFAMCNDO()
	{
		return (int)this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B6E2 RID: 46818 RVA: 0x00433E20 File Offset: 0x00432020
	internal Room(string IOJPMCOBHEJ, RoomOptions PCFOAMAODBD) : base(IOJPMCOBHEJ, null)
	{
		if (PCFOAMAODBD == null)
		{
			PCFOAMAODBD = new RoomOptions();
		}
		this.FMPBAGHEJDN = PCFOAMAODBD.IsVisible;
		this.PNAALABONJG = PCFOAMAODBD.IsOpen;
		this.MDLLBJEFCCJ = PCFOAMAODBD.MaxPlayers;
		this.FECDEAJPAAJ = false;
		base.NPOPPIMCDMN(PCFOAMAODBD.CustomRoomProperties);
		this.PropertiesListedInLobby = PCFOAMAODBD.CustomRoomPropertiesForLobby;
	}

	// Token: 0x0600B6E3 RID: 46819 RVA: 0x00433E88 File Offset: 0x00432088
	public void NCMLMADCFHJ(string[] MMIMLMLKCBA)
	{
		Hashtable hashtable = new Hashtable();
		hashtable[185] = MMIMLMLKCBA;
		Hashtable hashtable2 = new Hashtable();
		hashtable2[(byte)-189] = this.KLNEGBJPIBO();
		PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(hashtable, hashtable2, true);
	}

	// Token: 0x0600B6E4 RID: 46820 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool IHEBHOMEHIH()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B6E5 RID: 46821 RVA: 0x004335AE File Offset: 0x004317AE
	private void BNNFCKHICOP(string[] DPNHODJHGJL)
	{
		this.<HDDFDGJAIJD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B6E6 RID: 46822 RVA: 0x00433ED8 File Offset: 0x004320D8
	public void JIANOHENIBF(int DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("ready");
		}
		if (DPNHODJHGJL > -40)
		{
			Debug.LogWarning("<b>" + DPNHODJHGJL + "Set Satellite Emission");
			DPNHODJHGJL = -20;
		}
		if (DPNHODJHGJL != (int)this.MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(new Hashtable
			{
				{
					(byte)-17,
					(byte)DPNHODJHGJL
				}
			}, null, false);
		}
		this.MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	// Token: 0x0600B6E7 RID: 46823 RVA: 0x00433373 File Offset: 0x00431573
	public int PEGAPCPKHAB()
	{
		return this.DHOGHIOACME();
	}

	// Token: 0x0600B6E8 RID: 46824 RVA: 0x00433536 File Offset: 0x00431736
	internal void AJKPNAAMHMF(string DPNHODJHGJL)
	{
		this.LCKGKDLCFMC = DPNHODJHGJL;
	}

	// Token: 0x0600B6E9 RID: 46825 RVA: 0x00433F74 File Offset: 0x00432174
	private void EPKKLLKNBNE(string[] DPNHODJHGJL)
	{
		this.NNKLLBPFBNP(DPNHODJHGJL);
	}

	// Token: 0x0600B6EA RID: 46826 RVA: 0x00433A82 File Offset: 0x00431C82
	public void IEAGMKEBIJP(bool DPNHODJHGJL)
	{
		this.AOFIBMMLNAA(DPNHODJHGJL);
	}

	// Token: 0x0600B6EB RID: 46827 RVA: 0x004330E4 File Offset: 0x004312E4
	internal void PAEOJIPPLPF(string DPNHODJHGJL)
	{
		this.AJKPNAAMHMF(DPNHODJHGJL);
	}

	// Token: 0x0600B6EC RID: 46828 RVA: 0x00433F7D File Offset: 0x0043217D
	public string[] MCHPEJLLEFM()
	{
		return this.FECOFGHMPPA();
	}

	// Token: 0x0600B6ED RID: 46829 RVA: 0x00433F88 File Offset: 0x00432188
	public void CFONNEIKKLP(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("SlidingArea");
		}
		if (DPNHODJHGJL != this.FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(new Hashtable
			{
				{
					(byte)-149,
					DPNHODJHGJL
				}
			}, null, true);
		}
		this.FMPBAGHEJDN = DPNHODJHGJL;
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x0600B712 RID: 46866 RVA: 0x004330F5 File Offset: 0x004312F5
	// (set) Token: 0x0600B6EE RID: 46830 RVA: 0x00433FF8 File Offset: 0x004321F8
	public new bool IsOpen
	{
		get
		{
			return this.PNAALABONJG;
		}
		set
		{
			if (!this.Equals(PhotonNetwork.room))
			{
				Debug.LogWarning("Can't set open when not in that room.");
			}
			if (value != this.PNAALABONJG && !PhotonNetwork.offlineMode)
			{
				PhotonNetwork.JNJJAMNLOHA.HFECLDIOHNJ(new Hashtable
				{
					{
						253,
						value
					}
				}, null, false);
			}
			this.PNAALABONJG = value;
		}
	}

	// Token: 0x0600B6EF RID: 46831 RVA: 0x00434068 File Offset: 0x00432268
	public new string ToStringFull()
	{
		return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", new object[]
		{
			this.LCKGKDLCFMC,
			(!this.FMPBAGHEJDN) ? "hidden" : "visible",
			(!this.PNAALABONJG) ? "closed" : "open",
			this.MDLLBJEFCCJ,
			this.PlayerCount,
			base.CustomProperties.ToStringFull()
		});
	}

	// Token: 0x0600B6F1 RID: 46833 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool ANMHADBIJGN()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x0600B6F2 RID: 46834 RVA: 0x004335AE File Offset: 0x004317AE
	private void NNKLLBPFBNP(string[] DPNHODJHGJL)
	{
		this.<HDDFDGJAIJD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600B6F4 RID: 46836 RVA: 0x00434198 File Offset: 0x00432398
	public bool GBOINGMMKJD()
	{
		return this.JLHNLJGHMIJ();
	}

	// Token: 0x0600B6F5 RID: 46837 RVA: 0x004341A0 File Offset: 0x004323A0
	public void AOFIBMMLNAA(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_Value");
		}
		if (DPNHODJHGJL != this.PNAALABONJG && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.BEOJCMLIENM(new Hashtable
			{
				{
					(byte)-3,
					DPNHODJHGJL
				}
			}, null, true);
		}
		this.PNAALABONJG = DPNHODJHGJL;
	}

	// Token: 0x0600B6F6 RID: 46838 RVA: 0x00434210 File Offset: 0x00432410
	public void KJFGMHJLDCK(bool DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_Value4");
		}
		if (DPNHODJHGJL != this.FMPBAGHEJDN && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.DGNOGCOIPIA(new Hashtable
			{
				{
					(byte)-104,
					DPNHODJHGJL
				}
			}, null, true);
		}
		this.FMPBAGHEJDN = DPNHODJHGJL;
	}

	// Token: 0x0600B6F7 RID: 46839 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool JLHNLJGHMIJ()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x0600B6F9 RID: 46841 RVA: 0x00433249 File Offset: 0x00431449
	public int DHOGHIOACME()
	{
		if (PhotonNetwork.playerList != null)
		{
			return PhotonNetwork.playerList.Length;
		}
		return 0;
	}

	// Token: 0x0600B6FA RID: 46842 RVA: 0x00433D73 File Offset: 0x00431F73
	public bool AEIGNIMAAMO()
	{
		return this.FMPBAGHEJDN;
	}

	// Token: 0x0600B6FB RID: 46843 RVA: 0x00434280 File Offset: 0x00432480
	public void DILKACMDELI()
	{
		Hashtable hashtable = new Hashtable();
		hashtable[119] = new string[0];
		Hashtable hashtable2 = new Hashtable();
		hashtable2[18] = this.JHFHDOPLLDF();
		PhotonNetwork.JNJJAMNLOHA.APMINOMEBPE(hashtable, hashtable2, true);
	}

	// Token: 0x0600B6FC RID: 46844 RVA: 0x004330F5 File Offset: 0x004312F5
	public bool IFGKKKFBIHE()
	{
		return this.PNAALABONJG;
	}

	// Token: 0x0600B6FD RID: 46845 RVA: 0x0043319A File Offset: 0x0043139A
	public string[] DGJIEHFNKPO()
	{
		return this.PropertiesListedInLobby;
	}

	// Token: 0x0600B6FE RID: 46846 RVA: 0x004342D3 File Offset: 0x004324D3
	public int MFKFOMBLHPH()
	{
		return this.EGPGEMJNPFD();
	}

	// Token: 0x0600B6FF RID: 46847 RVA: 0x004342DC File Offset: 0x004324DC
	public virtual string FLJBCAOHMMN()
	{
		string format = "_MainTex2";
		object[] array = new object[7];
		array[0] = this.LCKGKDLCFMC;
		array[1] = ((!this.FMPBAGHEJDN) ? "_Value2" : "[PlayerBase] Delete checkpoint data");
		array[8] = ((!this.PNAALABONJG) ? "_Color" : "color");
		array[2] = this.MDLLBJEFCCJ;
		array[7] = this.EGPGEMJNPFD();
		return string.Format(format, array);
	}

	// Token: 0x0600B701 RID: 46849 RVA: 0x0043300F File Offset: 0x0043120F
	public string[] KLNEGBJPIBO()
	{
		return this.GFEDJEMJEND;
	}

	// Token: 0x0600B702 RID: 46850 RVA: 0x00434361 File Offset: 0x00432561
	public bool AOCFNJKILCG()
	{
		return this.CLCCCFDCOBA();
	}

	// Token: 0x0600B704 RID: 46852 RVA: 0x0043436C File Offset: 0x0043256C
	public void NDEBBNGMFFK(int DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("offsets");
		}
		if (DPNHODJHGJL > 148)
		{
			Debug.LogWarning("CameraFilterPack/Drawing_Manga2" + DPNHODJHGJL + "CameraFilterPack/Blend2Camera_LinearBurn");
			DPNHODJHGJL = -93;
		}
		if (DPNHODJHGJL != (int)this.MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.FMDMPEMOAAB(new Hashtable
			{
				{
					(byte)-197,
					(byte)DPNHODJHGJL
				}
			}, null, false);
		}
		this.MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	// Token: 0x0600B705 RID: 46853 RVA: 0x004330E4 File Offset: 0x004312E4
	internal void LFIOCJJFPPH(string DPNHODJHGJL)
	{
		this.AJKPNAAMHMF(DPNHODJHGJL);
	}

	// Token: 0x0600B706 RID: 46854 RVA: 0x00433373 File Offset: 0x00431573
	public int BBPPFMICKMI()
	{
		return this.DHOGHIOACME();
	}

	// Token: 0x0600B707 RID: 46855 RVA: 0x00433239 File Offset: 0x00431439
	protected internal int HLPFAGGIEKM()
	{
		return this.IPBANMNLDPC;
	}

	// Token: 0x0600B708 RID: 46856 RVA: 0x00434408 File Offset: 0x00432608
	public string[] LEABJPBNIKM()
	{
		return this.ExpectedUsers;
	}

	// Token: 0x0600B70A RID: 46858 RVA: 0x00433A8B File Offset: 0x00431C8B
	public void PGADMIKCIDO(bool DPNHODJHGJL)
	{
		this.EMAPOENGEIN(DPNHODJHGJL);
	}

	// Token: 0x0600B70B RID: 46859 RVA: 0x004330ED File Offset: 0x004312ED
	public int DEICKHNCDML()
	{
		return (int)this.MDLLBJEFCCJ;
	}

	// Token: 0x0600B70C RID: 46860 RVA: 0x00433F7D File Offset: 0x0043217D
	public string[] KJIFDNOFGGP()
	{
		return this.FECOFGHMPPA();
	}

	// Token: 0x0600B70D RID: 46861 RVA: 0x00434419 File Offset: 0x00432619
	protected internal int FNPBFGNDHMC()
	{
		return this.LKHBADEOGKO();
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x0600B70E RID: 46862 RVA: 0x00434408 File Offset: 0x00432608
	[Obsolete("Please use ExpectedUsers (updated case for naming).")]
	public string[] expectedUsers
	{
		get
		{
			return this.ExpectedUsers;
		}
	}

	// Token: 0x0600B70F RID: 46863 RVA: 0x004330CA File Offset: 0x004312CA
	public bool JJHDBBKEKBL()
	{
		return this.IsVisible;
	}

	// Token: 0x0600B710 RID: 46864 RVA: 0x00434424 File Offset: 0x00432624
	public void DBFEOJAHPJA(int DPNHODJHGJL)
	{
		if (!this.Equals(PhotonNetwork.room))
		{
			Debug.LogWarning("_TimeX");
		}
		if (DPNHODJHGJL > 105)
		{
			Debug.LogWarning("menu.selectedlevelid" + DPNHODJHGJL + "CameraFilterPack/BlurTiltShift_Hole");
			DPNHODJHGJL = 58;
		}
		if (DPNHODJHGJL != (int)this.MDLLBJEFCCJ && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.JNJJAMNLOHA.FEPNICODBNC(new Hashtable
			{
				{
					(byte)-71,
					(byte)DPNHODJHGJL
				}
			}, null, false);
		}
		this.MDLLBJEFCCJ = (byte)DPNHODJHGJL;
	}

	// Token: 0x0600B711 RID: 46865 RVA: 0x004344C0 File Offset: 0x004326C0
	protected internal void CAAADGPOBMA(int DPNHODJHGJL)
	{
		this.OPEKABONLBO(DPNHODJHGJL);
	}
}
