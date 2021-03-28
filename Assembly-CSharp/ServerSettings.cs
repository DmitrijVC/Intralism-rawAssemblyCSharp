using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02000321 RID: 801
[Serializable]
public class ServerSettings : ScriptableObject
{
	// Token: 0x0600B813 RID: 47123 RVA: 0x004371CF File Offset: 0x004353CF
	public static void HBJLKBJODGM()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.us);
	}

	// Token: 0x0600B814 RID: 47124 RVA: 0x004371D7 File Offset: 0x004353D7
	public static void OEIECLOHABM()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.cae;
	}

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x0600B815 RID: 47125 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode BestRegionCodeInPreferences
	{
		get
		{
			return PhotonHandler.IFAEAEOAJDL;
		}
	}

	// Token: 0x0600B816 RID: 47126 RVA: 0x004371E6 File Offset: 0x004353E6
	public void COMKDIPEPJO(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B817 RID: 47127 RVA: 0x004371FD File Offset: 0x004353FD
	public void CBHLHLACCNK(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B818 RID: 47128 RVA: 0x0043720D File Offset: 0x0043540D
	public void KAHCJFHDBII(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B819 RID: 47129 RVA: 0x00437220 File Offset: 0x00435420
	public static bool KHIDLNMCHDP(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600B81A RID: 47130 RVA: 0x0043720D File Offset: 0x0043540D
	public void BJDCPMDJFKJ(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B81B RID: 47131 RVA: 0x0043720D File Offset: 0x0043540D
	public void KGAOAJCABJN(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B81C RID: 47132 RVA: 0x00437254 File Offset: 0x00435454
	public virtual string HNCNNGNLKGC()
	{
		object[] array = new object[]
		{
			"GameMessagesDurationSlider"
		};
		array[0] = this.HostType;
		array[3] = ".ogg";
		array[8] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B81D RID: 47133 RVA: 0x00437288 File Offset: 0x00435488
	public void BECOAKOKLAO(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = ((FGLLFDCNMCD == null) ? "_MainTex2" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B81E RID: 47134 RVA: 0x004372B6 File Offset: 0x004354B6
	public void JOMAALGPFJA(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)7;
		this.AppID = ((FGLLFDCNMCD == null) ? "Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): " : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B81F RID: 47135 RVA: 0x004372E4 File Offset: 0x004354E4
	public void KOKFFFMOCJL(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B820 RID: 47136 RVA: 0x004372FB File Offset: 0x004354FB
	public void EIHAHOJHENG(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B821 RID: 47137 RVA: 0x0043730C File Offset: 0x0043550C
	public static bool HDKEBNAGNGB(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600B822 RID: 47138 RVA: 0x0043720D File Offset: 0x0043540D
	public void JLMKLIBOEAE(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B823 RID: 47139 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode IJGCAPPEJFH()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B824 RID: 47140 RVA: 0x00437340 File Offset: 0x00435540
	public static void KEJEOMAAHNC()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.us);
	}

	// Token: 0x0600B825 RID: 47141 RVA: 0x00437348 File Offset: 0x00435548
	public static void MMHBLEDOFOE()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.asia);
	}

	// Token: 0x0600B826 RID: 47142 RVA: 0x00437350 File Offset: 0x00435550
	public static bool AFPEGENCFMC(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600B827 RID: 47143 RVA: 0x00437384 File Offset: 0x00435584
	public void ECLLJOEILLA(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B828 RID: 47144 RVA: 0x004372E4 File Offset: 0x004354E4
	public void FGMBFFHCOEK(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B829 RID: 47145 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode JCDHEAPFFDG()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B82A RID: 47146 RVA: 0x004372E4 File Offset: 0x004354E4
	public void UseCloud(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B82B RID: 47147 RVA: 0x004372FB File Offset: 0x004354FB
	public void AMDCMLCEHHG(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B82C RID: 47148 RVA: 0x004371E6 File Offset: 0x004353E6
	public void KCCPMENBDFA(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B82D RID: 47149 RVA: 0x00437394 File Offset: 0x00435594
	public void PNKCCKMBPBL(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B82E RID: 47150 RVA: 0x004373A4 File Offset: 0x004355A4
	public void IEJKGJFPMLO(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B82F RID: 47151 RVA: 0x004373B4 File Offset: 0x004355B4
	public void FFMAFCKBFLL(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)6;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B830 RID: 47152 RVA: 0x004373C4 File Offset: 0x004355C4
	public static void IHMCIKFBAKC()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.jp);
	}

	// Token: 0x0600B831 RID: 47153 RVA: 0x004373CC File Offset: 0x004355CC
	public static bool DPLIHOEKHPN(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600B832 RID: 47154 RVA: 0x00437400 File Offset: 0x00435600
	public static void BECFEDPCEFP()
	{
		PhotonHandler.NFCANDIBPLB(CloudRegionCode.usw);
	}

	// Token: 0x0600B833 RID: 47155 RVA: 0x00437408 File Offset: 0x00435608
	public static void JLAAGPOIMPI()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.sa);
	}

	// Token: 0x0600B834 RID: 47156 RVA: 0x00437410 File Offset: 0x00435610
	public virtual string LBPOGAEOIDG()
	{
		object[] array = new object[0];
		array[1] = "_Axis";
		array[1] = this.HostType;
		array[2] = "_LutTex";
		array[8] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B835 RID: 47157 RVA: 0x004373C4 File Offset: 0x004355C4
	public static void BIKBBPBKFFA()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.jp);
	}

	// Token: 0x0600B836 RID: 47158 RVA: 0x00437394 File Offset: 0x00435594
	public void ABGICBACEMH(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B837 RID: 47159 RVA: 0x00437444 File Offset: 0x00435644
	public void LOBPAGNIDEI(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)6;
		this.AppID = ((FGLLFDCNMCD == null) ? "_Red_B" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B838 RID: 47160 RVA: 0x00437472 File Offset: 0x00435672
	public static void JICLIMGGGNA()
	{
		PhotonHandler.LEFACILBIGM(CloudRegionCode.au);
	}

	// Token: 0x0600B839 RID: 47161 RVA: 0x0043747A File Offset: 0x0043567A
	public void JLKAHAOGFGM(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = ((FGLLFDCNMCD == null) ? "RPC: 'OnAwakeRPC' PhotonView: " : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B83A RID: 47162 RVA: 0x004374A8 File Offset: 0x004356A8
	public void DOMLBMIOIIL(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = ((FGLLFDCNMCD == null) ? "DPADHOR" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B83B RID: 47163 RVA: 0x004371E6 File Offset: 0x004353E6
	public void JMPLLNIAMDH(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B83C RID: 47164 RVA: 0x004374D6 File Offset: 0x004356D6
	public void MNLHDEBDJGJ(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = ((FGLLFDCNMCD == null) ? "<b>" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B83D RID: 47165 RVA: 0x00437504 File Offset: 0x00435704
	public static bool IsAppId(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600B83E RID: 47166 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode IEJGCJILIHC()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B83F RID: 47167 RVA: 0x0043753F File Offset: 0x0043573F
	public void OEFIMANHABK(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = ((FGLLFDCNMCD == null) ? "#ok" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B840 RID: 47168 RVA: 0x0043756D File Offset: 0x0043576D
	public static void CFDPNHOPIIB()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.us;
	}

	// Token: 0x0600B841 RID: 47169 RVA: 0x00437394 File Offset: 0x00435594
	public void DEFBNJJAECG(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B842 RID: 47170 RVA: 0x004372E4 File Offset: 0x004354E4
	public void IAEKPKAHJHL(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B843 RID: 47171 RVA: 0x00437575 File Offset: 0x00435775
	public void UseMyServer(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = ((FGLLFDCNMCD == null) ? "master" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B844 RID: 47172 RVA: 0x004375A4 File Offset: 0x004357A4
	public static bool DMANFEKAJCA(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600B845 RID: 47173 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode HFMONCHNDEP()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B846 RID: 47174 RVA: 0x004375D8 File Offset: 0x004357D8
	public void NKBMAJKDHGD(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = ((FGLLFDCNMCD == null) ? "_Threshhold" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B847 RID: 47175 RVA: 0x00437606 File Offset: 0x00435806
	public virtual string PDNAHPCOCNJ()
	{
		object[] array = new object[1];
		array[1] = "note.5";
		array[0] = this.HostType;
		array[6] = "_ScreenResolution";
		array[0] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B848 RID: 47176 RVA: 0x004372E4 File Offset: 0x004354E4
	public void MLHIIAKBMNI(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B849 RID: 47177 RVA: 0x0043763A File Offset: 0x0043583A
	public void GKKJBHJFKAH(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)7;
		this.AppID = ((FGLLFDCNMCD == null) ? "workshop." : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B84A RID: 47178 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode FINLEHFGOLD()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B84B RID: 47179 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode JDJCAADPPII()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B84C RID: 47180 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode LOLNPBOPNGP()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B84D RID: 47181 RVA: 0x00437668 File Offset: 0x00435868
	public void PDLOBKPIMAL(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = ((FGLLFDCNMCD == null) ? "[PlayerController] " : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B84E RID: 47182 RVA: 0x00437696 File Offset: 0x00435896
	public static void JGIMGIPNNGK()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.sa;
	}

	// Token: 0x0600B84F RID: 47183 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode CIHKAJHPGIO()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B850 RID: 47184 RVA: 0x0043769E File Offset: 0x0043589E
	public static void DDIIFBJNGMA()
	{
		PhotonHandler.GGLNANJIJLG(CloudRegionCode.eu);
	}

	// Token: 0x0600B851 RID: 47185 RVA: 0x004376A6 File Offset: 0x004358A6
	public static void AGOMEPPNGCD()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.usw);
	}

	// Token: 0x0600B852 RID: 47186 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode GAPMBLINMCO()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B853 RID: 47187 RVA: 0x004376B0 File Offset: 0x004358B0
	public static bool MPCPINLFNID(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600B854 RID: 47188 RVA: 0x004373A4 File Offset: 0x004355A4
	public void KMOBHEFPHKP(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B855 RID: 47189 RVA: 0x004371E6 File Offset: 0x004353E6
	public void DJJOJOHJHBL(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B856 RID: 47190 RVA: 0x004376E4 File Offset: 0x004358E4
	public static bool IEAJGBPAHIJ(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600B857 RID: 47191 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode MMPMHBMKAEF()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B858 RID: 47192 RVA: 0x004371FD File Offset: 0x004353FD
	public void KLMEFOPDLNJ(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B859 RID: 47193 RVA: 0x00437718 File Offset: 0x00435918
	public void DHANOOKPJDE(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = ((FGLLFDCNMCD == null) ? "player.circle" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B85A RID: 47194 RVA: 0x0043720D File Offset: 0x0043540D
	public void FFDELEEONJC(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B85B RID: 47195 RVA: 0x00437748 File Offset: 0x00435948
	public static bool KIMFCPINMOM(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600B85C RID: 47196 RVA: 0x00437394 File Offset: 0x00435594
	public void FEFCPLMPMDP(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B85D RID: 47197 RVA: 0x0043777C File Offset: 0x0043597C
	public static void EADMDMFINLP()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.sa);
	}

	// Token: 0x0600B85E RID: 47198 RVA: 0x004372E4 File Offset: 0x004354E4
	public void MBENBCCHMKM(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B85F RID: 47199 RVA: 0x00437784 File Offset: 0x00435984
	public static void BLIJFBJLHOK()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.none;
	}

	// Token: 0x0600B860 RID: 47200 RVA: 0x0043778C File Offset: 0x0043598C
	public override string ToString()
	{
		return string.Concat(new object[]
		{
			"ServerSettings: ",
			this.HostType,
			" ",
			this.ServerAddress
		});
	}

	// Token: 0x0600B861 RID: 47201 RVA: 0x0043720D File Offset: 0x0043540D
	public void CKDMMGEMAJE(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B862 RID: 47202 RVA: 0x004377C0 File Offset: 0x004359C0
	public virtual string KDBBBMCPKNE()
	{
		object[] array = new object[3];
		array[1] = "Noise shaders are not set up! Disabling noise effect.";
		array[1] = this.HostType;
		array[1] = "0,2,true,0";
		array[4] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B863 RID: 47203 RVA: 0x004372FB File Offset: 0x004354FB
	public void KOMPBFKMLGF(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B864 RID: 47204 RVA: 0x0043720D File Offset: 0x0043540D
	public void OFENIMOBBMB(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B865 RID: 47205 RVA: 0x004377F4 File Offset: 0x004359F4
	public virtual string FLNAABIMMBK()
	{
		object[] array = new object[3];
		array[1] = "Case-Sensitive";
		array[0] = this.HostType;
		array[1] = "settings.volume.menu";
		array[6] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B866 RID: 47206 RVA: 0x004371E6 File Offset: 0x004353E6
	public void JLFOFNOJPMA(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B867 RID: 47207 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode AHAIPGNIOMG()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B868 RID: 47208 RVA: 0x004371E6 File Offset: 0x004353E6
	public void GMGMIJHBAHH(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B869 RID: 47209 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode NPABMCJMMLI()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B86A RID: 47210 RVA: 0x00437828 File Offset: 0x00435A28
	public static void LJMCPKHJPMD()
	{
		PhotonHandler.GGLNANJIJLG(CloudRegionCode.jp);
	}

	// Token: 0x0600B86B RID: 47211 RVA: 0x004372E4 File Offset: 0x004354E4
	public void MEMNOBFGBGO(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B86C RID: 47212 RVA: 0x00437830 File Offset: 0x00435A30
	public static void ALFOIOLIGEA()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.jp;
	}

	// Token: 0x0600B86D RID: 47213 RVA: 0x00437838 File Offset: 0x00435A38
	public virtual string AEMDLMGFGJN()
	{
		object[] array = new object[6];
		array[0] = "[ReplayScene] Loading replay: ";
		array[1] = this.HostType;
		array[7] = "mapselector.filter.officialsortmode";
		array[4] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B86E RID: 47214 RVA: 0x00437394 File Offset: 0x00435594
	public void BKNIODMAMML(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B86F RID: 47215 RVA: 0x0043786C File Offset: 0x00435A6C
	public static bool DECCNGGJPKA(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600B870 RID: 47216 RVA: 0x004378A0 File Offset: 0x00435AA0
	public void BAJJADJIINP(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = ((FGLLFDCNMCD == null) ? "_TimeX" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B871 RID: 47217 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode DHIJIMHCGKF()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B872 RID: 47218 RVA: 0x004378D0 File Offset: 0x00435AD0
	public static bool MOONNCPOJKB(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return true;
	}

	// Token: 0x0600B873 RID: 47219 RVA: 0x00437904 File Offset: 0x00435B04
	public virtual string NKBCECKFAMA()
	{
		object[] array = new object[1];
		array[1] = ". Check if the server is available.";
		array[0] = this.HostType;
		array[3] = "Preparing configuration";
		array[8] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B874 RID: 47220 RVA: 0x00437394 File Offset: 0x00435594
	public void CDEEILCFKIB(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B875 RID: 47221 RVA: 0x00437938 File Offset: 0x00435B38
	public static void PFEMLDJFGIE()
	{
		PhotonHandler.NFCANDIBPLB(CloudRegionCode.us);
	}

	// Token: 0x0600B876 RID: 47222 RVA: 0x00437940 File Offset: 0x00435B40
	public virtual string DBGHNCCINBC()
	{
		object[] array = new object[4];
		array[1] = "SetScale";
		array[0] = this.HostType;
		array[1] = "_LightIntensity";
		array[4] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B877 RID: 47223 RVA: 0x00437696 File Offset: 0x00435896
	public static void KPLCNMKMNEH()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.sa;
	}

	// Token: 0x0600B878 RID: 47224 RVA: 0x00437394 File Offset: 0x00435594
	public void BCMIJHKBDEL(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B879 RID: 47225 RVA: 0x00437974 File Offset: 0x00435B74
	public void FOPLPCFKDDD(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = ((FGLLFDCNMCD == null) ? ".progress" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B87A RID: 47226 RVA: 0x004379A2 File Offset: 0x00435BA2
	public virtual string DIHPHHGLOAO()
	{
		object[] array = new object[5];
		array[1] = "CrosshairOpacitySlider";
		array[1] = this.HostType;
		array[7] = "_TimeX";
		array[8] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B87B RID: 47227 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode PBICDJJBPIG()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B87C RID: 47228 RVA: 0x004379D6 File Offset: 0x00435BD6
	public virtual string HCPGNPLIJHH()
	{
		object[] array = new object[2];
		array[0] = ": ";
		array[0] = this.HostType;
		array[3] = "_MiddleGrey";
		array[3] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B87D RID: 47229 RVA: 0x00437394 File Offset: 0x00435594
	public void LKKJEABCFEN(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B87E RID: 47230 RVA: 0x00437A0A File Offset: 0x00435C0A
	public void MODKLODFHHE(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = ((FGLLFDCNMCD == null) ? "mapselector.filter.officialsortmode" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B87F RID: 47231 RVA: 0x00437A38 File Offset: 0x00435C38
	public virtual string BANNBMDODBJ()
	{
		object[] array = new object[4];
		array[1] = "_Parameter";
		array[0] = this.HostType;
		array[7] = "Value";
		array[2] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B880 RID: 47232 RVA: 0x00437A6C File Offset: 0x00435C6C
	public virtual string DEHDEBNAHOO()
	{
		object[] array = new object[6];
		array[1] = "CameraFilterPack/OldFilm_Cutting1";
		array[1] = this.HostType;
		array[0] = "_Intensity";
		array[4] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B881 RID: 47233 RVA: 0x00437394 File Offset: 0x00435594
	public void APBLCFHGBPK(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B882 RID: 47234 RVA: 0x00437AA0 File Offset: 0x00435CA0
	public void NEKNAMJCIKJ(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = ServerSettings.HostingOption.OfflineMode;
		this.AppID = ((FGLLFDCNMCD == null) ? "_TimeX" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B883 RID: 47235 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode BOLJHHIMFLF()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B884 RID: 47236 RVA: 0x004371E6 File Offset: 0x004353E6
	public void NBDLBCACLND(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B885 RID: 47237 RVA: 0x00437ACE File Offset: 0x00435CCE
	public virtual string GDPGACHMBOI()
	{
		object[] array = new object[7];
		array[0] = "null";
		array[1] = this.HostType;
		array[3] = "_Value2";
		array[2] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B886 RID: 47238 RVA: 0x00437B02 File Offset: 0x00435D02
	public void BAPNFLCIILD(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)7;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B887 RID: 47239 RVA: 0x004371E6 File Offset: 0x004353E6
	public void KNOKCFPAOEB(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B888 RID: 47240 RVA: 0x004373A4 File Offset: 0x004355A4
	public void HGKGGCCOBJI(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B889 RID: 47241 RVA: 0x0043720D File Offset: 0x0043540D
	public void AJILDJPLMBN(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B88A RID: 47242 RVA: 0x00437784 File Offset: 0x00435984
	public static void ResetBestRegionCodeInPreferences()
	{
		PhotonHandler.IFAEAEOAJDL = CloudRegionCode.none;
	}

	// Token: 0x0600B88B RID: 47243 RVA: 0x004371E6 File Offset: 0x004353E6
	public void PMDDANAAPDO(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B88C RID: 47244 RVA: 0x00437B12 File Offset: 0x00435D12
	public virtual string LGJAOGOFKKO()
	{
		object[] array = new object[2];
		array[0] = "_BlurRadius";
		array[0] = this.HostType;
		array[6] = "1332644700";
		array[6] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B88D RID: 47245 RVA: 0x004371E6 File Offset: 0x004353E6
	public void CBDMPEHBHPK(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B88E RID: 47246 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode HMFCKJIGDPH()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B88F RID: 47247 RVA: 0x00437B48 File Offset: 0x00435D48
	public static bool NEDDJPDIKND(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600B890 RID: 47248 RVA: 0x004372E4 File Offset: 0x004354E4
	public void GNEDGHJDJBD(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B891 RID: 47249 RVA: 0x00437384 File Offset: 0x00435584
	public void BFBJIHJNFEK(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.SelfHosted;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B892 RID: 47250 RVA: 0x00437B7C File Offset: 0x00435D7C
	public static void GINOKMBGHDL()
	{
		PhotonHandler.MEBNOLCEOFA(CloudRegionCode.cae);
	}

	// Token: 0x0600B893 RID: 47251 RVA: 0x0043720D File Offset: 0x0043540D
	public void LJDJCEFNKFK(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B894 RID: 47252 RVA: 0x00437B84 File Offset: 0x00435D84
	public virtual string IJGCOHDCCCF()
	{
		object[] array = new object[7];
		array[1] = "_TimeX";
		array[1] = this.HostType;
		array[2] = "CameraFilterPack/Color_Invert";
		array[5] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B895 RID: 47253 RVA: 0x004371E6 File Offset: 0x004353E6
	public void JFPKNPMPGJG(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B896 RID: 47254 RVA: 0x0043720D File Offset: 0x0043540D
	public void FJCLPINPBEN(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B897 RID: 47255 RVA: 0x00437BB8 File Offset: 0x00435DB8
	public static bool BOLDPNNOCGC(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600B898 RID: 47256 RVA: 0x004371DF File Offset: 0x004353DF
	public static CloudRegionCode INDKNFMGIOI()
	{
		return PhotonHandler.IFAEAEOAJDL;
	}

	// Token: 0x0600B899 RID: 47257 RVA: 0x00437394 File Offset: 0x00435594
	public void UseCloud(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B89A RID: 47258 RVA: 0x00437BEC File Offset: 0x00435DEC
	public static void BMLAOEOBNJI()
	{
		PhotonHandler.NFCANDIBPLB(CloudRegionCode.eu);
	}

	// Token: 0x0600B89C RID: 47260 RVA: 0x0043720D File Offset: 0x0043540D
	public void NBHAEGNBFGF(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B89D RID: 47261 RVA: 0x00437C69 File Offset: 0x00435E69
	public virtual string DAFEJDODLIH()
	{
		object[] array = new object[3];
		array[1] = "[UI] ";
		array[1] = this.HostType;
		array[4] = "settings.enablehitsoundsinrelax";
		array[4] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B89E RID: 47262 RVA: 0x0043720D File Offset: 0x0043540D
	public void FFHDPEOCKKF(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B89F RID: 47263 RVA: 0x00437CA0 File Offset: 0x00435EA0
	public static bool IDPGEHBBIIA(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600B8A0 RID: 47264 RVA: 0x00437CD4 File Offset: 0x00435ED4
	public virtual string MNDLOIINHFB()
	{
		object[] array = new object[2];
		array[0] = "Please specify either t or f.";
		array[1] = this.HostType;
		array[2] = "LevelEditor/CustomEventEditor-Text";
		array[6] = this.ServerAddress;
		return string.Concat(array);
	}

	// Token: 0x0600B8A1 RID: 47265 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode BAPDMKDKFIB()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B8A2 RID: 47266 RVA: 0x00437B02 File Offset: 0x00435D02
	public void PEAPMFIGMED(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)7;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8A3 RID: 47267 RVA: 0x004371E6 File Offset: 0x004353E6
	public void OEEAFKKPBGI(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8A4 RID: 47268 RVA: 0x00437D08 File Offset: 0x00435F08
	public void FBJAGBKMOMO(string BPMNPBDOMFO, int FKKAKLDEPKP, string FGLLFDCNMCD)
	{
		this.HostType = (ServerSettings.HostingOption)5;
		this.AppID = ((FGLLFDCNMCD == null) ? "shader.future" : FGLLFDCNMCD);
		this.ServerAddress = BPMNPBDOMFO;
		this.ServerPort = FKKAKLDEPKP;
	}

	// Token: 0x0600B8A5 RID: 47269 RVA: 0x004371E6 File Offset: 0x004353E6
	public void KMLOKACOJFP(string CDDPJNHMGFP, CloudRegionCode JFNKDGKEAEA)
	{
		this.HostType = ServerSettings.HostingOption.NotSet;
		this.AppID = CDDPJNHMGFP;
		this.PreferredRegion = JFNKDGKEAEA;
	}

	// Token: 0x0600B8A6 RID: 47270 RVA: 0x00437394 File Offset: 0x00435594
	public void NEJGNGJEBPL(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8A7 RID: 47271 RVA: 0x0043769E File Offset: 0x0043589E
	public static void MDHBDFOFFHP()
	{
		PhotonHandler.GGLNANJIJLG(CloudRegionCode.eu);
	}

	// Token: 0x0600B8A8 RID: 47272 RVA: 0x00437D36 File Offset: 0x00435F36
	public void JODBOLDAGAG(string CDDPJNHMGFP)
	{
		this.HostType = (ServerSettings.HostingOption)8;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8A9 RID: 47273 RVA: 0x00437D48 File Offset: 0x00435F48
	public static bool CFCCMPADPGH(string ONANKNCCCGO)
	{
		try
		{
			new Guid(ONANKNCCCGO);
		}
		catch
		{
			return false;
		}
		return false;
	}

	// Token: 0x0600B8AA RID: 47274 RVA: 0x004371FD File Offset: 0x004353FD
	public void KPDEKBLKGMD(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8AB RID: 47275 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode IIDHECDDHPI()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x0600B8AC RID: 47276 RVA: 0x004371FD File Offset: 0x004353FD
	public void UseCloudBestRegion(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.BestRegion;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8AD RID: 47277 RVA: 0x00437394 File Offset: 0x00435594
	public void HBAEPGENFJK(string CDDPJNHMGFP)
	{
		this.HostType = ServerSettings.HostingOption.PhotonCloud;
		this.AppID = CDDPJNHMGFP;
	}

	// Token: 0x0600B8AE RID: 47278 RVA: 0x00437538 File Offset: 0x00435738
	public static CloudRegionCode BAKLGMLNGII()
	{
		return PhotonHandler.LLEFOLMENEI();
	}

	// Token: 0x04001586 RID: 5510
	public string AppID = string.Empty;

	// Token: 0x04001587 RID: 5511
	public string VoiceAppID = string.Empty;

	// Token: 0x04001588 RID: 5512
	public string ChatAppID = string.Empty;

	// Token: 0x04001589 RID: 5513
	public ServerSettings.HostingOption HostType;

	// Token: 0x0400158A RID: 5514
	public CloudRegionCode PreferredRegion;

	// Token: 0x0400158B RID: 5515
	public CloudRegionFlag EnabledRegions = (CloudRegionFlag)(-1);

	// Token: 0x0400158C RID: 5516
	public ConnectionProtocol Protocol;

	// Token: 0x0400158D RID: 5517
	public string ServerAddress = string.Empty;

	// Token: 0x0400158E RID: 5518
	public int ServerPort = 5055;

	// Token: 0x0400158F RID: 5519
	public int VoiceServerPort = 5055;

	// Token: 0x04001590 RID: 5520
	public bool JoinLobby;

	// Token: 0x04001591 RID: 5521
	public bool EnableLobbyStatistics;

	// Token: 0x04001592 RID: 5522
	public PhotonLogLevel PunLogging;

	// Token: 0x04001593 RID: 5523
	public DebugLevel NetworkLogging = DebugLevel.ERROR;

	// Token: 0x04001594 RID: 5524
	public bool RunInBackground = true;

	// Token: 0x04001595 RID: 5525
	public List<string> RpcList = new List<string>();

	// Token: 0x04001596 RID: 5526
	[HideInInspector]
	public bool DisableAutoOpenWizard;

	// Token: 0x02000322 RID: 802
	public enum HostingOption
	{
		// Token: 0x04001598 RID: 5528
		NotSet,
		// Token: 0x04001599 RID: 5529
		PhotonCloud,
		// Token: 0x0400159A RID: 5530
		SelfHosted,
		// Token: 0x0400159B RID: 5531
		OfflineMode,
		// Token: 0x0400159C RID: 5532
		BestRegion
	}
}
