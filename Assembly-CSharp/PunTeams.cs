using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000359 RID: 857
public class PunTeams : MonoBehaviour
{
	// Token: 0x0600C0E6 RID: 49382 RVA: 0x00464E48 File Offset: 0x00463048
	public void KMODBOJMCGM(object[] EMIPGAIEKMK)
	{
		this.PNDLAAGMDKG();
	}

	// Token: 0x0600C0E7 RID: 49383 RVA: 0x00464E50 File Offset: 0x00463050
	public void BINNHCEOJMK(PhotonPlayer FKKHMGIGLKM)
	{
		this.KJEJABMICLJ();
	}

	// Token: 0x0600C0E8 RID: 49384 RVA: 0x00464E58 File Offset: 0x00463058
	public void IDCKFBKAPLG(object[] EMIPGAIEKMK)
	{
		this.OODPBGLNDBB();
	}

	// Token: 0x0600C0E9 RID: 49385 RVA: 0x00464E60 File Offset: 0x00463060
	public void IBPAPNIDHNG()
	{
		this.FMNPFCHBLJF();
	}

	// Token: 0x0600C0EA RID: 49386 RVA: 0x00464E68 File Offset: 0x00463068
	public void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		this.UpdateTeams();
	}

	// Token: 0x0600C0EB RID: 49387 RVA: 0x00464E70 File Offset: 0x00463070
	public void OANPGFAKCJP(object[] EMIPGAIEKMK)
	{
		this.ELEENIFILJN();
	}

	// Token: 0x0600C0EC RID: 49388 RVA: 0x00464E68 File Offset: 0x00463068
	public void MMBPPLMMAEP(object[] EMIPGAIEKMK)
	{
		this.UpdateTeams();
	}

	// Token: 0x0600C0ED RID: 49389 RVA: 0x00464E78 File Offset: 0x00463078
	public void Start()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C0EE RID: 49390 RVA: 0x00464E50 File Offset: 0x00463050
	public void GPJNGDBFIEF(object[] EMIPGAIEKMK)
	{
		this.KJEJABMICLJ();
	}

	// Token: 0x0600C0EF RID: 49391 RVA: 0x00464EFC File Offset: 0x004630FC
	public void OODPBGLNDBB()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 1; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C0F0 RID: 49392 RVA: 0x00464FB8 File Offset: 0x004631B8
	public void PLLJLMAMJAF(object[] EMIPGAIEKMK)
	{
		this.FLGKDMIDFEM();
	}

	// Token: 0x0600C0F1 RID: 49393 RVA: 0x00464FC0 File Offset: 0x004631C0
	public void PAKPHKPDKGE()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C0F2 RID: 49394 RVA: 0x00465044 File Offset: 0x00463244
	public void IFJDKDFLGBG()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
	}

	// Token: 0x0600C0F3 RID: 49395 RVA: 0x00465050 File Offset: 0x00463250
	public void PBPPONHHCKF(object[] EMIPGAIEKMK)
	{
		this.KIJOCBLAAAH();
	}

	// Token: 0x0600C0F4 RID: 49396 RVA: 0x00465058 File Offset: 0x00463258
	public void JLMBFPCHOMI()
	{
		this.CIPKEPDELJB();
	}

	// Token: 0x0600C0F5 RID: 49397 RVA: 0x00464E50 File Offset: 0x00463050
	public void LBFONLCIOMM(object[] EMIPGAIEKMK)
	{
		this.KJEJABMICLJ();
	}

	// Token: 0x0600C0F6 RID: 49398 RVA: 0x00465060 File Offset: 0x00463260
	public void KOJKBFDNGDK()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C0F7 RID: 49399 RVA: 0x004650E4 File Offset: 0x004632E4
	public void LCJFGHJDCOB()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C0F8 RID: 49400 RVA: 0x004651A0 File Offset: 0x004633A0
	public void EBBHDEHPHKA()
	{
		this.EPEGAEGDJAM();
	}

	// Token: 0x0600C0F9 RID: 49401 RVA: 0x004651A8 File Offset: 0x004633A8
	public void NGKAGGEHJCO()
	{
		this.CPBKHGJJNAJ();
	}

	// Token: 0x0600C0FA RID: 49402 RVA: 0x004651B0 File Offset: 0x004633B0
	public void FNCDAPDOBBI()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C0FB RID: 49403 RVA: 0x00465234 File Offset: 0x00463434
	public void BOEAEAMIIPN(object[] EMIPGAIEKMK)
	{
		this.DMNDKAFNNOD();
	}

	// Token: 0x0600C0FC RID: 49404 RVA: 0x0046523C File Offset: 0x0046343C
	public void CPDMBJCOCAM(object[] EMIPGAIEKMK)
	{
		this.JBJEKKFGLLP();
	}

	// Token: 0x0600C0FD RID: 49405 RVA: 0x00465244 File Offset: 0x00463444
	public void JBJEKKFGLLP()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C0FE RID: 49406 RVA: 0x00465044 File Offset: 0x00463244
	public void OnDisable()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
	}

	// Token: 0x0600C0FF RID: 49407 RVA: 0x00465300 File Offset: 0x00463500
	public void CIEIBNLCIGE(object[] EMIPGAIEKMK)
	{
		this.LMBNFKGBDNK();
	}

	// Token: 0x0600C100 RID: 49408 RVA: 0x00465308 File Offset: 0x00463508
	public void KIJOCBLAAAH()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 1; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C101 RID: 49409 RVA: 0x004653C4 File Offset: 0x004635C4
	public void DMNDKAFNNOD()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 1; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C102 RID: 49410 RVA: 0x00465480 File Offset: 0x00463680
	public void OHFOLGANOLC()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C103 RID: 49411 RVA: 0x00464FB8 File Offset: 0x004631B8
	public void FAFNDLCHPHC()
	{
		this.FLGKDMIDFEM();
	}

	// Token: 0x0600C104 RID: 49412 RVA: 0x00465504 File Offset: 0x00463704
	public void ICLONIMMFLG()
	{
		this.LCJFGHJDCOB();
	}

	// Token: 0x0600C105 RID: 49413 RVA: 0x00464E70 File Offset: 0x00463070
	public void FEIJFPOFEHA()
	{
		this.ELEENIFILJN();
	}

	// Token: 0x0600C106 RID: 49414 RVA: 0x0046550C File Offset: 0x0046370C
	public void KMCPMOGKDEH()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C107 RID: 49415 RVA: 0x00465044 File Offset: 0x00463244
	public void HGDDCINLDAD()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
	}

	// Token: 0x0600C108 RID: 49416 RVA: 0x00465590 File Offset: 0x00463790
	public void CIPKEPDELJB()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C109 RID: 49417 RVA: 0x00465300 File Offset: 0x00463500
	public void CJMGILMCGHG(PhotonPlayer MCDOIGNGJBJ)
	{
		this.LMBNFKGBDNK();
	}

	// Token: 0x0600C10A RID: 49418 RVA: 0x00464FB8 File Offset: 0x004631B8
	public void GJOFHFOCGAB(PhotonPlayer FKKHMGIGLKM)
	{
		this.FLGKDMIDFEM();
	}

	// Token: 0x0600C10B RID: 49419 RVA: 0x004651A8 File Offset: 0x004633A8
	public void CKFDNMMCHEC(PhotonPlayer FKKHMGIGLKM)
	{
		this.CPBKHGJJNAJ();
	}

	// Token: 0x0600C10C RID: 49420 RVA: 0x00465614 File Offset: 0x00463814
	public void FMNPFCHBLJF()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C10D RID: 49421 RVA: 0x0046523C File Offset: 0x0046343C
	public void GDMLOIIILIL(PhotonPlayer FKKHMGIGLKM)
	{
		this.JBJEKKFGLLP();
	}

	// Token: 0x0600C10E RID: 49422 RVA: 0x00465698 File Offset: 0x00463898
	public void PNDLAAGMDKG()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C10F RID: 49423 RVA: 0x00465300 File Offset: 0x00463500
	public void EACGGDMMJCA(object[] EMIPGAIEKMK)
	{
		this.LMBNFKGBDNK();
	}

	// Token: 0x0600C110 RID: 49424 RVA: 0x004651A8 File Offset: 0x004633A8
	public void DMLFOFLEGAH(PhotonPlayer FKKHMGIGLKM)
	{
		this.CPBKHGJJNAJ();
	}

	// Token: 0x0600C111 RID: 49425 RVA: 0x00464FB8 File Offset: 0x004631B8
	public void CCGENFLKPPE(PhotonPlayer MCDOIGNGJBJ)
	{
		this.FLGKDMIDFEM();
	}

	// Token: 0x0600C112 RID: 49426 RVA: 0x00465504 File Offset: 0x00463704
	public void MBBBDIIIOFC()
	{
		this.LCJFGHJDCOB();
	}

	// Token: 0x0600C113 RID: 49427 RVA: 0x00464E68 File Offset: 0x00463068
	public void OnJoinedRoom()
	{
		this.UpdateTeams();
	}

	// Token: 0x0600C114 RID: 49428 RVA: 0x00465044 File Offset: 0x00463244
	public void BKGJOECFMID()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
	}

	// Token: 0x0600C115 RID: 49429 RVA: 0x00464E50 File Offset: 0x00463050
	public void EDAAPBJEEKJ(PhotonPlayer MCDOIGNGJBJ)
	{
		this.KJEJABMICLJ();
	}

	// Token: 0x0600C116 RID: 49430 RVA: 0x00465300 File Offset: 0x00463500
	public void NIEFNFBHNDB(object[] EMIPGAIEKMK)
	{
		this.LMBNFKGBDNK();
	}

	// Token: 0x0600C117 RID: 49431 RVA: 0x00465754 File Offset: 0x00463954
	public void PNAGJMHIGGN()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 1; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C118 RID: 49432 RVA: 0x00464FB8 File Offset: 0x004631B8
	public void NCIAGGDENJE(PhotonPlayer MCDOIGNGJBJ)
	{
		this.FLGKDMIDFEM();
	}

	// Token: 0x0600C119 RID: 49433 RVA: 0x00465810 File Offset: 0x00463A10
	public void OnLeftRoom()
	{
		this.Start();
	}

	// Token: 0x0600C11A RID: 49434 RVA: 0x00465818 File Offset: 0x00463A18
	public void EPEGAEGDJAM()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C11B RID: 49435 RVA: 0x0046589C File Offset: 0x00463A9C
	public void LMBNFKGBDNK()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C11C RID: 49436 RVA: 0x00464E48 File Offset: 0x00463048
	public void OLFOHNNDHMK()
	{
		this.PNDLAAGMDKG();
	}

	// Token: 0x0600C11D RID: 49437 RVA: 0x00465234 File Offset: 0x00463434
	public void MGKJFIOOMHP(object[] EMIPGAIEKMK)
	{
		this.DMNDKAFNNOD();
	}

	// Token: 0x0600C11E RID: 49438 RVA: 0x00465300 File Offset: 0x00463500
	public void KAAIAIBIFOE(PhotonPlayer FKKHMGIGLKM)
	{
		this.LMBNFKGBDNK();
	}

	// Token: 0x0600C11F RID: 49439 RVA: 0x00465504 File Offset: 0x00463704
	public void NMKMMIOCODL(PhotonPlayer MCDOIGNGJBJ)
	{
		this.LCJFGHJDCOB();
	}

	// Token: 0x0600C120 RID: 49440 RVA: 0x00465044 File Offset: 0x00463244
	public void JOJFHFHOCHO()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
	}

	// Token: 0x0600C121 RID: 49441 RVA: 0x00465044 File Offset: 0x00463244
	public void IABLKKAALGI()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
	}

	// Token: 0x0600C122 RID: 49442 RVA: 0x00465958 File Offset: 0x00463B58
	public void ELEENIFILJN()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C123 RID: 49443 RVA: 0x00464E68 File Offset: 0x00463068
	public void OnPhotonPlayerPropertiesChanged(object[] EMIPGAIEKMK)
	{
		this.UpdateTeams();
	}

	// Token: 0x0600C124 RID: 49444 RVA: 0x00465A14 File Offset: 0x00463C14
	public void KJEJABMICLJ()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C126 RID: 49446 RVA: 0x00465AD0 File Offset: 0x00463CD0
	public void PALPIANCGLL()
	{
		this.FNCDAPDOBBI();
	}

	// Token: 0x0600C127 RID: 49447 RVA: 0x00465300 File Offset: 0x00463500
	public void AFJAAJCOLCI(PhotonPlayer FKKHMGIGLKM)
	{
		this.LMBNFKGBDNK();
	}

	// Token: 0x0600C128 RID: 49448 RVA: 0x00465050 File Offset: 0x00463250
	public void BINJHPNHEJB(PhotonPlayer FKKHMGIGLKM)
	{
		this.KIJOCBLAAAH();
	}

	// Token: 0x0600C129 RID: 49449 RVA: 0x00464E50 File Offset: 0x00463050
	public void JNHPFMKIBMO(PhotonPlayer FKKHMGIGLKM)
	{
		this.KJEJABMICLJ();
	}

	// Token: 0x0600C12A RID: 49450 RVA: 0x00465AD8 File Offset: 0x00463CD8
	public void JJCENHLNEEJ()
	{
		this.IHLMNAGPKDA();
	}

	// Token: 0x0600C12B RID: 49451 RVA: 0x00464FB8 File Offset: 0x004631B8
	public void MOCHFOLGBMM()
	{
		this.FLGKDMIDFEM();
	}

	// Token: 0x0600C12C RID: 49452 RVA: 0x00465AE0 File Offset: 0x00463CE0
	public void FLGKDMIDFEM()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C12D RID: 49453 RVA: 0x00465B9C File Offset: 0x00463D9C
	public void DBNPDNJNDBL(PhotonPlayer FKKHMGIGLKM)
	{
		this.OCNEBMKFLLN();
	}

	// Token: 0x0600C12E RID: 49454 RVA: 0x004651A0 File Offset: 0x004633A0
	public void LONKEDEIJKJ()
	{
		this.EPEGAEGDJAM();
	}

	// Token: 0x0600C12F RID: 49455 RVA: 0x00464E68 File Offset: 0x00463068
	public void KGGMHBDCOIO(PhotonPlayer MCDOIGNGJBJ)
	{
		this.UpdateTeams();
	}

	// Token: 0x0600C130 RID: 49456 RVA: 0x00465044 File Offset: 0x00463244
	public void JHJGJJKELJM()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
	}

	// Token: 0x0600C131 RID: 49457 RVA: 0x004651A8 File Offset: 0x004633A8
	public void GGAKOEPCCGB(object[] EMIPGAIEKMK)
	{
		this.CPBKHGJJNAJ();
	}

	// Token: 0x0600C132 RID: 49458 RVA: 0x00464E48 File Offset: 0x00463048
	public void GECDHLCPKNO()
	{
		this.PNDLAAGMDKG();
	}

	// Token: 0x0600C133 RID: 49459 RVA: 0x00464E68 File Offset: 0x00463068
	public void NIEHJGHECJL(PhotonPlayer MCDOIGNGJBJ)
	{
		this.UpdateTeams();
	}

	// Token: 0x0600C134 RID: 49460 RVA: 0x00465BA4 File Offset: 0x00463DA4
	public void OCNEBMKFLLN()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 1; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C135 RID: 49461 RVA: 0x00465C60 File Offset: 0x00463E60
	public void IHLMNAGPKDA()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x0600C136 RID: 49462 RVA: 0x00465CE4 File Offset: 0x00463EE4
	public void CPBKHGJJNAJ()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C137 RID: 49463 RVA: 0x00465DA0 File Offset: 0x00463FA0
	public void UpdateTeams()
	{
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj].Clear();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		for (int i = 0; i < PhotonNetwork.playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = PhotonNetwork.playerList[i];
			PunTeams.Team team = photonPlayer.GetTeam();
			PunTeams.PlayersPerTeam[team].Add(photonPlayer);
		}
	}

	// Token: 0x0600C138 RID: 49464 RVA: 0x004651A8 File Offset: 0x004633A8
	public void GHPHOPNDONN(PhotonPlayer MCDOIGNGJBJ)
	{
		this.CPBKHGJJNAJ();
	}

	// Token: 0x0600C139 RID: 49465 RVA: 0x00464E68 File Offset: 0x00463068
	public void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ)
	{
		this.UpdateTeams();
	}

	// Token: 0x0600C13A RID: 49466 RVA: 0x00465E5C File Offset: 0x0046405C
	public void DBEMDAJDDDA()
	{
		PunTeams.PlayersPerTeam = new Dictionary<PunTeams.Team, List<PhotonPlayer>>();
		Array values = Enum.GetValues(typeof(PunTeams.Team));
		IEnumerator enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				PunTeams.PlayersPerTeam[(PunTeams.Team)obj] = new List<PhotonPlayer>();
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x04001671 RID: 5745
	public static Dictionary<PunTeams.Team, List<PhotonPlayer>> PlayersPerTeam;

	// Token: 0x04001672 RID: 5746
	public const string TeamPlayerProp = "team";

	// Token: 0x0200035A RID: 858
	public enum Team : byte
	{
		// Token: 0x04001674 RID: 5748
		none,
		// Token: 0x04001675 RID: 5749
		red,
		// Token: 0x04001676 RID: 5750
		blue
	}
}
