using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000312 RID: 786
public class PhotonPlayer : IComparable<PhotonPlayer>, IComparable<int>, IEquatable<PhotonPlayer>, IEquatable<int>
{
	// Token: 0x0600B3D8 RID: 46040 RVA: 0x0041DB9F File Offset: 0x0041BD9F
	public PhotonPlayer HAGEHGEADJL(PhotonPlayer ILCDNGENBNL)
	{
		if (ILCDNGENBNL == null)
		{
			return null;
		}
		return this.MMDGGOFMDAC(ILCDNGENBNL.ID);
	}

	// Token: 0x0600B3D9 RID: 46041 RVA: 0x0041DBB5 File Offset: 0x0041BDB5
	public virtual int INMMLLMPKEK()
	{
		return this.ONIKFABKELO();
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x0041DBBD File Offset: 0x0041BDBD
	public bool IsMasterClient
	{
		get
		{
			return PhotonNetwork.JNJJAMNLOHA.mMasterClientId == this.ID;
		}
	}

	// Token: 0x0600B3DB RID: 46043 RVA: 0x0041DBD1 File Offset: 0x0041BDD1
	public bool PMPIFCBBMBJ()
	{
		return this.IsInactive;
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x0600B3EC RID: 46060 RVA: 0x0041DBD1 File Offset: 0x0041BDD1
	// (set) Token: 0x0600B3DC RID: 46044 RVA: 0x0041DBD9 File Offset: 0x0041BDD9
	[Obsolete("Please use IsInactive (updated case for naming).")]
	public bool isInactive
	{
		get
		{
			return this.IsInactive;
		}
		set
		{
			this.IsInactive = value;
		}
	}

	// Token: 0x0600B3DD RID: 46045 RVA: 0x0041DBE2 File Offset: 0x0041BDE2
	public bool JPANONLCHEP()
	{
		return PhotonNetwork.JNJJAMNLOHA.GHOANKKKIAI() == this.ONIKFABKELO();
	}

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x0041DBF6 File Offset: 0x0041BDF6
	// (set) Token: 0x0600B419 RID: 46105 RVA: 0x0041E506 File Offset: 0x0041C706
	public bool IsInactive { get; set; }

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x0600B40D RID: 46093 RVA: 0x0041E3B8 File Offset: 0x0041C5B8
	// (set) Token: 0x0600B3DF RID: 46047 RVA: 0x0041DC00 File Offset: 0x0041BE00
	public string NickName
	{
		get
		{
			return this.LCKGKDLCFMC;
		}
		set
		{
			if (!this.IsLocal)
			{
				Debug.LogError("Error: Cannot change the name of a remote player!");
				return;
			}
			if (string.IsNullOrEmpty(value) || value.Equals(this.LCKGKDLCFMC))
			{
				return;
			}
			this.LCKGKDLCFMC = value;
			PhotonNetwork.playerName = value;
		}
	}

	// Token: 0x0600B3E0 RID: 46048 RVA: 0x0041DC50 File Offset: 0x0041BE50
	public override string ToString()
	{
		if (string.IsNullOrEmpty(this.NickName))
		{
			return string.Format("#{0:00}{1}{2}", this.ID, (!this.IsInactive) ? " " : " (inactive)", (!this.IsMasterClient) ? string.Empty : "(master)");
		}
		return string.Format("'{0}'{1}{2}", this.NickName, (!this.IsInactive) ? " " : " (inactive)", (!this.IsMasterClient) ? string.Empty : "(master)");
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x0600B3E1 RID: 46049 RVA: 0x0041DCFB File Offset: 0x0041BEFB
	// (set) Token: 0x0600B401 RID: 46081 RVA: 0x0041E23C File Offset: 0x0041C43C
	public string UserId { get; internal set; }

	// Token: 0x0600B3E2 RID: 46050 RVA: 0x0041DD03 File Offset: 0x0041BF03
	public PhotonPlayer GetNext()
	{
		return this.GetNextFor(this.ID);
	}

	// Token: 0x0600B3E3 RID: 46051 RVA: 0x0041DD14 File Offset: 0x0041BF14
	public bool PEALMFBGGIN(PhotonPlayer AGGOHIAAMHN)
	{
		return AGGOHIAAMHN == null || this.GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	// Token: 0x0600B3E4 RID: 46052 RVA: 0x0041DD3D File Offset: 0x0041BF3D
	public override int GetHashCode()
	{
		return this.ID;
	}

	// Token: 0x0600B3E5 RID: 46053 RVA: 0x0041DD45 File Offset: 0x0041BF45
	public Hashtable IOEPIJNLDDG()
	{
		return this.CustomProperties;
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x0600B3E6 RID: 46054 RVA: 0x0041DD4D File Offset: 0x0041BF4D
	[Obsolete("Please use IsLocal (updated case for naming).")]
	public bool isLocal
	{
		get
		{
			return this.IsLocal;
		}
	}

	// Token: 0x0600B3E7 RID: 46055 RVA: 0x0041DD58 File Offset: 0x0041BF58
	public bool FJIDFAKGIGD(int AGGOHIAAMHN)
	{
		return this.GetHashCode().Equals(AGGOHIAAMHN);
	}

	// Token: 0x0600B3E8 RID: 46056 RVA: 0x0041DD74 File Offset: 0x0041BF74
	public void MGMCOJHGJNO(Hashtable ENEEBHGAAJH, Hashtable DBBFANEJNGI = null, bool CDBHGINNCOF = false)
	{
		if (ENEEBHGAAJH == null)
		{
			return;
		}
		Hashtable hashtable = ENEEBHGAAJH.StripToStringKeys();
		Hashtable hashtable2 = DBBFANEJNGI.StripToStringKeys();
		bool flag = hashtable2 == null || hashtable2.Count == 0;
		bool flag2 = this.IECJKEIJLCP > 0 && PhotonNetwork.offlineMode;
		if (flag)
		{
			this.CustomProperties.Merge(hashtable);
			this.CustomProperties.StripKeysWithNullValues();
		}
		if (flag2)
		{
			PhotonNetwork.JNJJAMNLOHA.CKFJPBAJPHC(this.IECJKEIJLCP, hashtable, hashtable2, CDBHGINNCOF);
		}
		if (!flag2 || flag)
		{
			this.NPOPPIMCDMN(hashtable);
			PhotonNetworkingMessage lelhnddckco = (PhotonNetworkingMessage)92;
			object[] array = new object[]
			{
				null,
				this
			};
			array[1] = hashtable;
			BNGIGHBHPEH.CLOLHKCFMJP(lelhnddckco, array);
		}
	}

	// Token: 0x0600B3E9 RID: 46057 RVA: 0x0041DE20 File Offset: 0x0041C020
	internal void ODKOKBHELDL(string DPNHODJHGJL)
	{
		this.UserId = DPNHODJHGJL;
	}

	// Token: 0x0600B3EA RID: 46058 RVA: 0x0041DE29 File Offset: 0x0041C029
	public int ONIKFABKELO()
	{
		return this.IECJKEIJLCP;
	}

	// Token: 0x0600B3EB RID: 46059 RVA: 0x0041DE31 File Offset: 0x0041C031
	internal void GOCPHBFMIEN(int LGHIPFAEONM)
	{
		if (!this.IsLocal)
		{
			Debug.LogError("ERROR You should never change PhotonPlayer IDs!");
			return;
		}
		this.IECJKEIJLCP = LGHIPFAEONM;
	}

	// Token: 0x0600B3ED RID: 46061 RVA: 0x0041DE50 File Offset: 0x0041C050
	internal void MANKIAGOEHI(Hashtable DPNHODJHGJL)
	{
		this.CustomProperties = DPNHODJHGJL;
	}

	// Token: 0x0600B3EE RID: 46062 RVA: 0x0041DCFB File Offset: 0x0041BEFB
	public string GNFKECKFIBM()
	{
		return this.<DELIHEHNGKB>k__BackingField;
	}

	// Token: 0x0600B3EF RID: 46063 RVA: 0x0041DE59 File Offset: 0x0041C059
	public PhotonPlayer GPONFIOFJMF(PhotonPlayer ILCDNGENBNL)
	{
		if (ILCDNGENBNL == null)
		{
			return null;
		}
		return this.GetNextFor(ILCDNGENBNL.ID);
	}

	// Token: 0x0600B3F0 RID: 46064 RVA: 0x0041DD4D File Offset: 0x0041BF4D
	public bool ANIKDNEBADM()
	{
		return this.IsLocal;
	}

	// Token: 0x0600B3F1 RID: 46065 RVA: 0x0041DE70 File Offset: 0x0041C070
	public int LLAPDNFDFEI(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return 0;
		}
		return this.GetHashCode().CompareTo(AGGOHIAAMHN.GetHashCode());
	}

	// Token: 0x0600B3F2 RID: 46066 RVA: 0x0041DE9C File Offset: 0x0041C09C
	internal void NPOPPIMCDMN(Hashtable EAOBCIPOENN)
	{
		if (EAOBCIPOENN == null || EAOBCIPOENN.Count == 0 || this.CustomProperties.Equals(EAOBCIPOENN))
		{
			return;
		}
		if (EAOBCIPOENN.ContainsKey(255))
		{
			this.LCKGKDLCFMC = (string)EAOBCIPOENN[byte.MaxValue];
		}
		if (EAOBCIPOENN.ContainsKey(253))
		{
			this.UserId = (string)EAOBCIPOENN[253];
		}
		if (EAOBCIPOENN.ContainsKey(254))
		{
			this.IsInactive = (bool)EAOBCIPOENN[254];
		}
		this.CustomProperties.MergeStringKeys(EAOBCIPOENN);
		this.CustomProperties.StripKeysWithNullValues();
	}

	// Token: 0x0600B3F3 RID: 46067 RVA: 0x0041DF73 File Offset: 0x0041C173
	public PhotonPlayer HNCFIGNCLPO()
	{
		return this.GetNextFor(this.ONIKFABKELO());
	}

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x0600B3F4 RID: 46068 RVA: 0x0041DF81 File Offset: 0x0041C181
	// (set) Token: 0x0600B415 RID: 46101 RVA: 0x0041E4FD File Offset: 0x0041C6FD
	public Hashtable CustomProperties { get; internal set; }

	// Token: 0x0600B3F5 RID: 46069 RVA: 0x0041DCFB File Offset: 0x0041BEFB
	public string NOEGMEEAOJD()
	{
		return this.<DELIHEHNGKB>k__BackingField;
	}

	// Token: 0x0600B3F6 RID: 46070 RVA: 0x0041DD45 File Offset: 0x0041BF45
	public Hashtable CIDNLHFHHDL()
	{
		return this.CustomProperties;
	}

	// Token: 0x0600B3F7 RID: 46071 RVA: 0x0041DF89 File Offset: 0x0041C189
	public PhotonPlayer FCCKKEDLOHA()
	{
		return this.HCGBAFENPAA(this.ONIKFABKELO());
	}

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x0600B3F8 RID: 46072 RVA: 0x0041DF97 File Offset: 0x0041C197
	// (set) Token: 0x0600B411 RID: 46097 RVA: 0x0041DE20 File Offset: 0x0041C020
	[Obsolete("Please use UserId (updated case for naming).")]
	public string userId
	{
		get
		{
			return this.UserId;
		}
		internal set
		{
			this.UserId = value;
		}
	}

	// Token: 0x0600B3F9 RID: 46073 RVA: 0x0041DBBD File Offset: 0x0041BDBD
	public bool PLKIIDHHPDG()
	{
		return PhotonNetwork.JNJJAMNLOHA.mMasterClientId == this.ID;
	}

	// Token: 0x0600B3FA RID: 46074 RVA: 0x0041DF9F File Offset: 0x0041C19F
	public bool HKHJMONFBHL()
	{
		return this.IsMasterClient;
	}

	// Token: 0x0600B3FB RID: 46075 RVA: 0x0041DFA8 File Offset: 0x0041C1A8
	public PhotonPlayer HCGBAFENPAA(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 6)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = -97;
		int num2 = PBMHIFICKIG;
		foreach (int num3 in mActors.Keys)
		{
			if (num3 < num2)
			{
				num2 = num3;
			}
			else if (num3 > PBMHIFICKIG && num3 < num)
			{
				num = num3;
			}
		}
		return (num == -59) ? mActors[num2] : mActors[num];
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x0600B428 RID: 46120 RVA: 0x0041E6A8 File Offset: 0x0041C8A8
	// (set) Token: 0x0600B3FC RID: 46076 RVA: 0x0041E080 File Offset: 0x0041C280
	[Obsolete("Please use NickName (updated case for naming).")]
	public string name
	{
		get
		{
			return this.NickName;
		}
		set
		{
			this.NickName = value;
		}
	}

	// Token: 0x0600B3FD RID: 46077 RVA: 0x0041E08C File Offset: 0x0041C28C
	public bool HJBPPALONKE(PhotonPlayer AGGOHIAAMHN)
	{
		return AGGOHIAAMHN == null || this.GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	// Token: 0x0600B3FE RID: 46078 RVA: 0x0041DE50 File Offset: 0x0041C050
	internal void LPJGPHECGCB(Hashtable DPNHODJHGJL)
	{
		this.CustomProperties = DPNHODJHGJL;
	}

	// Token: 0x0600B3FF RID: 46079 RVA: 0x0041E0B8 File Offset: 0x0041C2B8
	public virtual string CLJAJDILKFK()
	{
		if (string.IsNullOrEmpty(this.NickName))
		{
			return string.Format("RateButton", this.ID, (!this.IsInactive) ? "Set Parent" : "inventory.selected.", (!this.IsMasterClient) ? string.Empty : "StartTime already set: ");
		}
		return string.Format("mapselector.filter.favoriteonly", this.NickName, (!this.IsInactive) ? ".sav" : "_Value7", (!this.IsMasterClient) ? string.Empty : "UpdateDownloadingProgress");
	}

	// Token: 0x0600B400 RID: 46080 RVA: 0x0041E164 File Offset: 0x0041C364
	public PhotonPlayer GetNextFor(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 2)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = int.MaxValue;
		int num2 = PBMHIFICKIG;
		foreach (int num3 in mActors.Keys)
		{
			if (num3 < num2)
			{
				num2 = num3;
			}
			else if (num3 > PBMHIFICKIG && num3 < num)
			{
				num = num3;
			}
		}
		return (num == int.MaxValue) ? mActors[num2] : mActors[num];
	}

	// Token: 0x0600B402 RID: 46082 RVA: 0x0041E248 File Offset: 0x0041C448
	public int HIAKBCIOGOD(int AGGOHIAAMHN)
	{
		return this.GetHashCode().CompareTo(AGGOHIAAMHN);
	}

	// Token: 0x0600B403 RID: 46083 RVA: 0x0041E264 File Offset: 0x0041C464
	public static PhotonPlayer Find(int IJAEJMNLBLK)
	{
		if (PhotonNetwork.JNJJAMNLOHA != null)
		{
			return PhotonNetwork.JNJJAMNLOHA.ICMGDHDNIJD(IJAEJMNLBLK);
		}
		return null;
	}

	// Token: 0x0600B404 RID: 46084 RVA: 0x0041DD4D File Offset: 0x0041BF4D
	public bool GMBKOKDAGIE()
	{
		return this.IsLocal;
	}

	// Token: 0x0600B405 RID: 46085 RVA: 0x0041E280 File Offset: 0x0041C480
	public override bool Equals(object HDMLEEGNJHI)
	{
		PhotonPlayer photonPlayer = HDMLEEGNJHI as PhotonPlayer;
		return photonPlayer != null && this.GetHashCode() == photonPlayer.GetHashCode();
	}

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x0600B406 RID: 46086 RVA: 0x0041DF9F File Offset: 0x0041C19F
	[Obsolete("Please use IsMasterClient (updated case for naming).")]
	public bool isMasterClient
	{
		get
		{
			return this.IsMasterClient;
		}
	}

	// Token: 0x0600B407 RID: 46087 RVA: 0x0041E2AB File Offset: 0x0041C4AB
	public PhotonPlayer CFJNNGEPCKM(PhotonPlayer ILCDNGENBNL)
	{
		if (ILCDNGENBNL == null)
		{
			return null;
		}
		return this.HCGBAFENPAA(ILCDNGENBNL.ID);
	}

	// Token: 0x0600B408 RID: 46088 RVA: 0x0041E2C4 File Offset: 0x0041C4C4
	public PhotonPlayer MMDGGOFMDAC(int PBMHIFICKIG)
	{
		if (PhotonNetwork.JNJJAMNLOHA == null || PhotonNetwork.JNJJAMNLOHA.mActors == null || PhotonNetwork.JNJJAMNLOHA.mActors.Count < 0)
		{
			return null;
		}
		Dictionary<int, PhotonPlayer> mActors = PhotonNetwork.JNJJAMNLOHA.mActors;
		int num = 199;
		int num2 = PBMHIFICKIG;
		foreach (int num3 in mActors.Keys)
		{
			if (num3 < num2)
			{
				num2 = num3;
			}
			else if (num3 > PBMHIFICKIG && num3 < num)
			{
				num = num3;
			}
		}
		return (num == 44) ? mActors[num2] : mActors[num];
	}

	// Token: 0x0600B409 RID: 46089 RVA: 0x0041DE20 File Offset: 0x0041C020
	internal void KDDOOLCJLEB(string DPNHODJHGJL)
	{
		this.UserId = DPNHODJHGJL;
	}

	// Token: 0x0600B40A RID: 46090 RVA: 0x0041E39C File Offset: 0x0041C59C
	public bool Equals(int AGGOHIAAMHN)
	{
		return this.GetHashCode().Equals(AGGOHIAAMHN);
	}

	// Token: 0x0600B40B RID: 46091 RVA: 0x0041DBD9 File Offset: 0x0041BDD9
	public void CPLDGGCPFCB(bool DPNHODJHGJL)
	{
		this.IsInactive = DPNHODJHGJL;
	}

	// Token: 0x0600B40C RID: 46092 RVA: 0x0041DD4D File Offset: 0x0041BF4D
	public bool OECIJJJHCDC()
	{
		return this.IsLocal;
	}

	// Token: 0x0600B40E RID: 46094 RVA: 0x0041E3C0 File Offset: 0x0041C5C0
	public void SetCustomProperties(Hashtable ENEEBHGAAJH, Hashtable DBBFANEJNGI = null, bool CDBHGINNCOF = false)
	{
		if (ENEEBHGAAJH == null)
		{
			return;
		}
		Hashtable hashtable = ENEEBHGAAJH.StripToStringKeys();
		Hashtable hashtable2 = DBBFANEJNGI.StripToStringKeys();
		bool flag = hashtable2 == null || hashtable2.Count == 0;
		bool flag2 = this.IECJKEIJLCP > 0 && !PhotonNetwork.offlineMode;
		if (flag)
		{
			this.CustomProperties.Merge(hashtable);
			this.CustomProperties.StripKeysWithNullValues();
		}
		if (flag2)
		{
			PhotonNetwork.JNJJAMNLOHA.LJEFICMOPMO(this.IECJKEIJLCP, hashtable, hashtable2, CDBHGINNCOF);
		}
		if (!flag2 || flag)
		{
			this.NPOPPIMCDMN(hashtable);
			BNGIGHBHPEH.SendMonoMessage(PhotonNetworkingMessage.OnPhotonPlayerPropertiesChanged, new object[]
			{
				this,
				hashtable
			});
		}
	}

	// Token: 0x0600B40F RID: 46095 RVA: 0x0041E46C File Offset: 0x0041C66C
	public PhotonPlayer(bool NIGBAPGIKDF, int IECJKEIJLCP, string EBEHBBDKDFJ)
	{
		this.CustomProperties = new Hashtable();
		this.IsLocal = NIGBAPGIKDF;
		this.IECJKEIJLCP = IECJKEIJLCP;
		this.LCKGKDLCFMC = EBEHBBDKDFJ;
	}

	// Token: 0x0600B410 RID: 46096 RVA: 0x0041E4A8 File Offset: 0x0041C6A8
	public bool LDGCKCJIMGF(PhotonPlayer AGGOHIAAMHN)
	{
		return AGGOHIAAMHN != null && this.GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	// Token: 0x0600B412 RID: 46098 RVA: 0x0041DE59 File Offset: 0x0041C059
	public PhotonPlayer GetNextFor(PhotonPlayer ILCDNGENBNL)
	{
		if (ILCDNGENBNL == null)
		{
			return null;
		}
		return this.GetNextFor(ILCDNGENBNL.ID);
	}

	// Token: 0x0600B413 RID: 46099 RVA: 0x0041E264 File Offset: 0x0041C464
	public static PhotonPlayer GJMEMHIGMGN(int IJAEJMNLBLK)
	{
		if (PhotonNetwork.JNJJAMNLOHA != null)
		{
			return PhotonNetwork.JNJJAMNLOHA.ICMGDHDNIJD(IJAEJMNLBLK);
		}
		return null;
	}

	// Token: 0x0600B414 RID: 46100 RVA: 0x0041E4D4 File Offset: 0x0041C6D4
	public int CompareTo(PhotonPlayer AGGOHIAAMHN)
	{
		if (AGGOHIAAMHN == null)
		{
			return 0;
		}
		return this.GetHashCode().CompareTo(AGGOHIAAMHN.GetHashCode());
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x0600B416 RID: 46102 RVA: 0x0041DD45 File Offset: 0x0041BF45
	// (set) Token: 0x0600B417 RID: 46103 RVA: 0x0041DE50 File Offset: 0x0041C050
	[Obsolete("Please use CustomProperties (updated case for naming).")]
	public Hashtable customProperties
	{
		get
		{
			return this.CustomProperties;
		}
		internal set
		{
			this.CustomProperties = value;
		}
	}

	// Token: 0x0600B418 RID: 46104 RVA: 0x0041DBD9 File Offset: 0x0041BDD9
	public void NDOALCHECKP(bool DPNHODJHGJL)
	{
		this.IsInactive = DPNHODJHGJL;
	}

	// Token: 0x0600B41A RID: 46106 RVA: 0x0041E50F File Offset: 0x0041C70F
	protected internal PhotonPlayer(bool NIGBAPGIKDF, int IECJKEIJLCP, Hashtable EAOBCIPOENN)
	{
		this.CustomProperties = new Hashtable();
		this.IsLocal = NIGBAPGIKDF;
		this.IECJKEIJLCP = IECJKEIJLCP;
		this.NPOPPIMCDMN(EAOBCIPOENN);
	}

	// Token: 0x0600B41B RID: 46107 RVA: 0x0041E549 File Offset: 0x0041C749
	public PhotonPlayer EFFCMNHBPME(int JMMILEFMACB)
	{
		return PhotonPlayer.GJMEMHIGMGN(JMMILEFMACB);
	}

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x0600B41C RID: 46108 RVA: 0x0041E551 File Offset: 0x0041C751
	[Obsolete("Please use AllProperties (updated case for naming).")]
	public Hashtable allProperties
	{
		get
		{
			return this.AllProperties;
		}
	}

	// Token: 0x0600B41D RID: 46109 RVA: 0x0041E55C File Offset: 0x0041C75C
	public int CompareTo(int AGGOHIAAMHN)
	{
		return this.GetHashCode().CompareTo(AGGOHIAAMHN);
	}

	// Token: 0x0600B41E RID: 46110 RVA: 0x0041E578 File Offset: 0x0041C778
	public PhotonPlayer Get(int JMMILEFMACB)
	{
		return PhotonPlayer.Find(JMMILEFMACB);
	}

	// Token: 0x0600B41F RID: 46111 RVA: 0x0041E080 File Offset: 0x0041C280
	public void NCBMHOMGILM(string DPNHODJHGJL)
	{
		this.NickName = DPNHODJHGJL;
	}

	// Token: 0x0600B420 RID: 46112 RVA: 0x0041E580 File Offset: 0x0041C780
	public string HBHNILBBCAH()
	{
		string format = ",";
		object[] array = new object[3];
		array[1] = this.ID;
		array[0] = this.NickName;
		array[0] = ((!this.IsInactive) ? string.Empty : "_DiffuseColor");
		array[2] = this.CustomProperties.ToStringFull();
		return string.Format(format, array);
	}

	// Token: 0x0600B421 RID: 46113 RVA: 0x0041E5E0 File Offset: 0x0041C7E0
	public bool Equals(PhotonPlayer AGGOHIAAMHN)
	{
		return AGGOHIAAMHN != null && this.GetHashCode().Equals(AGGOHIAAMHN.GetHashCode());
	}

	// Token: 0x0600B422 RID: 46114 RVA: 0x0041DD4D File Offset: 0x0041BF4D
	public bool HJNFCJNCBFF()
	{
		return this.IsLocal;
	}

	// Token: 0x0600B423 RID: 46115 RVA: 0x0041E60C File Offset: 0x0041C80C
	public virtual bool LBKEGOEFDKG(object HDMLEEGNJHI)
	{
		PhotonPlayer photonPlayer = HDMLEEGNJHI as PhotonPlayer;
		return photonPlayer != null && this.GetHashCode() == photonPlayer.GetHashCode();
	}

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x0600B424 RID: 46116 RVA: 0x0041E638 File Offset: 0x0041C838
	public Hashtable AllProperties
	{
		get
		{
			Hashtable hashtable = new Hashtable();
			hashtable.Merge(this.CustomProperties);
			hashtable[byte.MaxValue] = this.NickName;
			return hashtable;
		}
	}

	// Token: 0x0600B425 RID: 46117 RVA: 0x0041E670 File Offset: 0x0041C870
	public bool OEPAOAJMACF(int AGGOHIAAMHN)
	{
		return this.GetHashCode().Equals(AGGOHIAAMHN);
	}

	// Token: 0x0600B426 RID: 46118 RVA: 0x0041E68C File Offset: 0x0041C88C
	public int IMGACEGOOON(int AGGOHIAAMHN)
	{
		return this.GetHashCode().CompareTo(AGGOHIAAMHN);
	}

	// Token: 0x0600B427 RID: 46119 RVA: 0x0041DD03 File Offset: 0x0041BF03
	public PhotonPlayer DGCJCPLOCNK()
	{
		return this.GetNextFor(this.ID);
	}

	// Token: 0x0600B429 RID: 46121 RVA: 0x0041DBD9 File Offset: 0x0041BDD9
	public void MMMPACJBBPA(bool DPNHODJHGJL)
	{
		this.IsInactive = DPNHODJHGJL;
	}

	// Token: 0x0600B42A RID: 46122 RVA: 0x0041DCFB File Offset: 0x0041BEFB
	public string JEPBKIEHAPO()
	{
		return this.<DELIHEHNGKB>k__BackingField;
	}

	// Token: 0x0600B42B RID: 46123 RVA: 0x0041E6B0 File Offset: 0x0041C8B0
	public bool MNLOFANHIDN(int AGGOHIAAMHN)
	{
		return this.GetHashCode().Equals(AGGOHIAAMHN);
	}

	// Token: 0x0600B42C RID: 46124 RVA: 0x0041E551 File Offset: 0x0041C751
	public Hashtable CJMAJPAKOIB()
	{
		return this.AllProperties;
	}

	// Token: 0x0600B42D RID: 46125 RVA: 0x0041DD45 File Offset: 0x0041BF45
	public Hashtable JAPFGHDBEPA()
	{
		return this.CustomProperties;
	}

	// Token: 0x0600B42E RID: 46126 RVA: 0x0041E6CC File Offset: 0x0041C8CC
	public string ToStringFull()
	{
		return string.Format("#{0:00} '{1}'{2} {3}", new object[]
		{
			this.ID,
			this.NickName,
			(!this.IsInactive) ? string.Empty : " (inactive)",
			this.CustomProperties.ToStringFull()
		});
	}

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x0600B42F RID: 46127 RVA: 0x0041DE29 File Offset: 0x0041C029
	public int ID
	{
		get
		{
			return this.IECJKEIJLCP;
		}
	}

	// Token: 0x0600B430 RID: 46128 RVA: 0x0041DE20 File Offset: 0x0041C020
	internal void IFBIMEHPBAO(string DPNHODJHGJL)
	{
		this.UserId = DPNHODJHGJL;
	}

	// Token: 0x0400151F RID: 5407
	private int IECJKEIJLCP = -1;

	// Token: 0x04001520 RID: 5408
	private string LCKGKDLCFMC = string.Empty;

	// Token: 0x04001522 RID: 5410
	public readonly bool IsLocal;

	// Token: 0x04001525 RID: 5413
	public object TagObject;
}
