using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon;
using UnityEngine;

// Token: 0x0200035C RID: 860
public class PunTurnManager : PunBehaviour
{
	// Token: 0x0600C13D RID: 49469 RVA: 0x00465F70 File Offset: 0x00464170
	private void NCPAFCKGJEA()
	{
		if (this.GJOLNGBIOIN() > 0 && this.PPEHOCMMMAA() && !this.FCAOCIMNLEK)
		{
			this.FCAOCIMNLEK = true;
			this.TurnManagerListener.OnTurnTimeEnds(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x0600C13E RID: 49470 RVA: 0x00465FAC File Offset: 0x004641AC
	public void BeginTurn()
	{
		this.Turn++;
	}

	// Token: 0x0600C13F RID: 49471 RVA: 0x00465FBC File Offset: 0x004641BC
	public float MHDHBLHBMLL()
	{
		return Mathf.Max(665f, this.TurnDuration - this.OELMDPDDDCM());
	}

	// Token: 0x0600C140 RID: 49472 RVA: 0x00465FD5 File Offset: 0x004641D5
	public bool KCMDKCAOPML()
	{
		return PhotonNetwork.room == null || this.GDJLPABBBKN() <= 0 || this.KLPNNDHINIO.Count == PhotonNetwork.room.DHOGHIOACME();
	}

	// Token: 0x0600C141 RID: 49473 RVA: 0x00466007 File Offset: 0x00464207
	public bool GetPlayerFinishedTurn(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK != null && this.KLPNNDHINIO != null && this.KLPNNDHINIO.Contains(JHOEDACNNKK);
	}

	// Token: 0x0600C142 RID: 49474 RVA: 0x0046602E File Offset: 0x0046422E
	public bool DMELHDCJKJB()
	{
		return PhotonNetwork.room != null && this.LMJKMHLMDPM() > 1 && this.KLPNNDHINIO.Count == PhotonNetwork.room.DHOGHIOACME();
	}

	// Token: 0x0600C143 RID: 49475 RVA: 0x00466060 File Offset: 0x00464260
	public float FJENCBAGBNP()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1495f;
	}

	// Token: 0x0600C144 RID: 49476 RVA: 0x0046607C File Offset: 0x0046427C
	public void HFDJCEBDBJG(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (this.IsFinishedByMe)
		{
			Debug.LogWarning("[PlayerController] ");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("_ScreenResolution", this.HHHGEKHMGHN());
		hashtable.Add("mapselector.lastSearch", HNOKMIIDHHH);
		byte imcbemicjfc = (!OEGKPMHIJGF) ? 0 : 6;
		PhotonNetwork.RaiseEvent(imcbemicjfc, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(this.LMJKMHLMDPM());
		}
		this.OnEvent(imcbemicjfc, hashtable, PhotonNetwork.player.ID);
	}

	// Token: 0x0600C145 RID: 49477 RVA: 0x00466114 File Offset: 0x00464314
	public bool EKFHKCOCELJ(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK == null || this.KLPNNDHINIO == null || !this.KLPNNDHINIO.Contains(JHOEDACNNKK) || true;
	}

	// Token: 0x0600C146 RID: 49478 RVA: 0x0046613B File Offset: 0x0046433B
	public int IDFPOLFAFBL()
	{
		return PhotonNetwork.room.GetTurn();
	}

	// Token: 0x0600C147 RID: 49479 RVA: 0x00466148 File Offset: 0x00464348
	public void OJOCFMINBLC(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		if (IMCBEMICJFC != 1)
		{
			if (IMCBEMICJFC == 3)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["In Main Menu"];
				object hnokmiidhhh = hashtable["settings.cameramovements"];
				if (num == this.HHHGEKHMGHN())
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.CPCNILDNMFI())
				{
					this.TurnManagerListener.OnTurnCompleted(this.HHHGEKHMGHN());
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["_ScreenResolution"];
			object hnokmiidhhh2 = hashtable2["_Near"];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C148 RID: 49480 RVA: 0x0046621C File Offset: 0x0046441C
	public void EECLNGDOIIA(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (this.IsFinishedByMe)
		{
			Debug.LogWarning("AddEnvironmentObject");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("UseScanLine", this.PMKDJOOGMLK());
		hashtable.Add("plainText", HNOKMIIDHHH);
		byte imcbemicjfc = (!OEGKPMHIJGF) ? 0 : 0;
		PhotonNetwork.RaiseEvent(imcbemicjfc, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(this.GJOLNGBIOIN());
		}
		this.OnEvent(imcbemicjfc, hashtable, PhotonNetwork.player.ID);
	}

	// Token: 0x0600C149 RID: 49481 RVA: 0x00466007 File Offset: 0x00464207
	public bool HAHPLCCAMKE(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK != null && this.KLPNNDHINIO != null && this.KLPNNDHINIO.Contains(JHOEDACNNKK);
	}

	// Token: 0x0600C14A RID: 49482 RVA: 0x004662B4 File Offset: 0x004644B4
	private void AEEGKLABFLN()
	{
		if (this.PMKDJOOGMLK() > 0 && this.IIMDNFFIDJO() && !this.FCAOCIMNLEK)
		{
			this.FCAOCIMNLEK = true;
			this.TurnManagerListener.OnTurnTimeEnds(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x0600C14B RID: 49483 RVA: 0x004662F0 File Offset: 0x004644F0
	public bool IsOver
	{
		get
		{
			return this.RemainingSecondsInTurn <= 0f;
		}
	}

	// Token: 0x0600C14C RID: 49484 RVA: 0x00466302 File Offset: 0x00464502
	public void MLMGLFPMPKC()
	{
		this.LHFLIDFLPNA(this.IDFPOLFAFBL() + 0);
	}

	// Token: 0x0600C14D RID: 49485 RVA: 0x00466312 File Offset: 0x00464512
	public bool IIMDNFFIDJO()
	{
		return this.DADCNDMNKKE() > 1045f;
	}

	// Token: 0x0600C14E RID: 49486 RVA: 0x00466324 File Offset: 0x00464524
	public bool ILKADLIPFEH()
	{
		return PhotonNetwork.room == null || this.Turn <= 1 || this.KLPNNDHINIO.Count == PhotonNetwork.room.EGPGEMJNPFD();
	}

	// Token: 0x0600C14F RID: 49487 RVA: 0x00466356 File Offset: 0x00464556
	private void LJCOFHNGJNB(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, true);
	}

	// Token: 0x0600C150 RID: 49488 RVA: 0x0046636B File Offset: 0x0046456B
	public virtual void PBFDMLGIPOM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Crosshair"))
		{
			this.FCAOCIMNLEK = false;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x0600C151 RID: 49489 RVA: 0x004663A0 File Offset: 0x004645A0
	public void DCPCOHNMJLL(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (this.GIDIJDPOODD())
		{
			Debug.LogWarning("ControllerRightX");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("mapselector.filter.favoriteonly", this.LMJKMHLMDPM());
		hashtable.Add("The other scroll rect doesnt support scrolling horizontally", HNOKMIIDHHH);
		byte imcbemicjfc = (!OEGKPMHIJGF) ? 1 : 5;
		PhotonNetwork.RaiseEvent(imcbemicjfc, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveFromRoomCacheForActorsLeft
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(this.Turn);
		}
		this.OnEvent(imcbemicjfc, hashtable, PhotonNetwork.player.ONIKFABKELO());
	}

	// Token: 0x0600C152 RID: 49490 RVA: 0x00466438 File Offset: 0x00464638
	public float DADCNDMNKKE()
	{
		return Mathf.Max(1547f, this.TurnDuration - this.CBNGNDADEAG());
	}

	// Token: 0x0600C153 RID: 49491 RVA: 0x00466451 File Offset: 0x00464651
	private void POJFHDFJOPE()
	{
		if (this.Turn > 0 && this.JNKECPKBLOG() && !this.FCAOCIMNLEK)
		{
			this.FCAOCIMNLEK = true;
			this.TurnManagerListener.OnTurnTimeEnds(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x0600C154 RID: 49492 RVA: 0x00466490 File Offset: 0x00464690
	public void IHGGPNLHDGI(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		if (IMCBEMICJFC != 0)
		{
			if (IMCBEMICJFC == 5)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["_Value2"];
				object hnokmiidhhh = hashtable["maps."];
				if (num == this.IDFPOLFAFBL())
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.CPCNILDNMFI())
				{
					this.TurnManagerListener.OnTurnCompleted(this.IDFPOLFAFBL());
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["CameraFilterPack/Drawing_CellShading"];
			object hnokmiidhhh2 = hashtable2["menu.tabid"];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C155 RID: 49493 RVA: 0x00466562 File Offset: 0x00464762
	public bool FONBPACMNAL()
	{
		return this.EBPAGJBFEEE() <= 1388f;
	}

	// Token: 0x0600C156 RID: 49494 RVA: 0x00466574 File Offset: 0x00464774
	public float MCDBAACFMLA()
	{
		return Mathf.Max(1494f, this.TurnDuration - this.FJENCBAGBNP());
	}

	// Token: 0x0600C157 RID: 49495 RVA: 0x00466590 File Offset: 0x00464790
	public void LOCAHNOMIGH(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		if (IMCBEMICJFC != 1)
		{
			if (IMCBEMICJFC == 0)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["MenuScene"];
				object hnokmiidhhh = hashtable["_ScreenResolution"];
				if (num == this.HHHGEKHMGHN())
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.HLLMADAHHIJ())
				{
					this.TurnManagerListener.OnTurnCompleted(this.LMJKMHLMDPM());
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["menu.playedsolo"];
			object hnokmiidhhh2 = hashtable2["Offline or in OfflineMode. No VitalStats available."];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C158 RID: 49496 RVA: 0x00466662 File Offset: 0x00464862
	public float CBNGNDADEAG()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 987f;
	}

	// Token: 0x0600C159 RID: 49497 RVA: 0x0046613B File Offset: 0x0046433B
	public int GJOLNGBIOIN()
	{
		return PhotonNetwork.room.GetTurn();
	}

	// Token: 0x0600C15A RID: 49498 RVA: 0x0046667B File Offset: 0x0046487B
	public float AAFOEEEMIMH()
	{
		return Mathf.Max(1018f, this.TurnDuration - this.CBNGNDADEAG());
	}

	// Token: 0x0600C15B RID: 49499 RVA: 0x00466694 File Offset: 0x00464894
	public bool JNKECPKBLOG()
	{
		return this.NBAKEGJNADK() > 163f;
	}

	// Token: 0x0600C15C RID: 49500 RVA: 0x004666A6 File Offset: 0x004648A6
	private void LHFLIDFLPNA(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, false);
	}

	// Token: 0x0600C15D RID: 49501 RVA: 0x004666BB File Offset: 0x004648BB
	public bool CPCNILDNMFI()
	{
		return PhotonNetwork.room == null || this.HHHGEKHMGHN() <= 0 || this.KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	// Token: 0x0600C15E RID: 49502 RVA: 0x004666ED File Offset: 0x004648ED
	public bool HANCFPKFHDN()
	{
		return PhotonNetwork.room != null && this.PMKDJOOGMLK() > 1 && this.KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	// Token: 0x0600C15F RID: 49503 RVA: 0x0046671F File Offset: 0x0046491F
	public float EBPAGJBFEEE()
	{
		return Mathf.Max(944f, this.TurnDuration - this.CBNGNDADEAG());
	}

	// Token: 0x0600C160 RID: 49504 RVA: 0x00466007 File Offset: 0x00464207
	public bool LFLJFHPDNDP(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK != null && this.KLPNNDHINIO != null && this.KLPNNDHINIO.Contains(JHOEDACNNKK);
	}

	// Token: 0x0600C161 RID: 49505 RVA: 0x00466738 File Offset: 0x00464938
	public void IBKKGJOIENM()
	{
		this.GJLBGOBMPIH(this.PMKDJOOGMLK() + 1);
	}

	// Token: 0x0600C162 RID: 49506 RVA: 0x00466748 File Offset: 0x00464948
	public void OnEvent(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		if (IMCBEMICJFC != 1)
		{
			if (IMCBEMICJFC == 2)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["turn"];
				object hnokmiidhhh = hashtable["move"];
				if (num == this.Turn)
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.IsCompletedByAll)
				{
					this.TurnManagerListener.OnTurnCompleted(this.Turn);
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["turn"];
			object hnokmiidhhh2 = hashtable2["move"];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C163 RID: 49507 RVA: 0x0046681A File Offset: 0x00464A1A
	public bool APDMMAJIHAL()
	{
		return this.KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	// Token: 0x0600C164 RID: 49508 RVA: 0x0046682C File Offset: 0x00464A2C
	public void JIKMAAJPFIC(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		if (IMCBEMICJFC != 1)
		{
			if (IMCBEMICJFC == 6)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["Soundtrack"];
				object hnokmiidhhh = hashtable["value"];
				if (num == this.IDFPOLFAFBL())
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.POOPLIFHPKH())
				{
					this.TurnManagerListener.OnTurnCompleted(this.Turn);
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["Default UI Material"];
			object hnokmiidhhh2 = hashtable2["Preparing content..."];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C165 RID: 49509 RVA: 0x00466356 File Offset: 0x00464556
	private void GJLBGOBMPIH(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, true);
	}

	// Token: 0x0600C166 RID: 49510 RVA: 0x0046613B File Offset: 0x0046433B
	public int GDJLPABBBKN()
	{
		return PhotonNetwork.room.GetTurn();
	}

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x0600C167 RID: 49511 RVA: 0x0046681A File Offset: 0x00464A1A
	public bool IsFinishedByMe
	{
		get
		{
			return this.KLPNNDHINIO.Contains(PhotonNetwork.player);
		}
	}

	// Token: 0x0600C168 RID: 49512 RVA: 0x00466900 File Offset: 0x00464B00
	public void JKHBDPIGFOE(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		if (IMCBEMICJFC != 0)
		{
			if (IMCBEMICJFC == 6)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["_Near"];
				object hnokmiidhhh = hashtable["_BlurTexture"];
				if (num == this.GJOLNGBIOIN())
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.HANCFPKFHDN())
				{
					this.TurnManagerListener.OnTurnCompleted(this.PMKDJOOGMLK());
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["#exit"];
			object hnokmiidhhh2 = hashtable2["_TimeX"];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C169 RID: 49513 RVA: 0x004669D2 File Offset: 0x00464BD2
	private void POBKGKFOFGM(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = true;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, false);
	}

	// Token: 0x0600C16A RID: 49514 RVA: 0x004669E7 File Offset: 0x00464BE7
	public bool HLLMADAHHIJ()
	{
		return PhotonNetwork.room != null && this.HHHGEKHMGHN() > 1 && this.KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	// Token: 0x0600C16B RID: 49515 RVA: 0x004666A6 File Offset: 0x004648A6
	private void LAEPOOENKEC(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, false);
	}

	// Token: 0x0600C16C RID: 49516 RVA: 0x00466A19 File Offset: 0x00464C19
	public void LEOFMGELGDM()
	{
		this.LPMEFHODEJA(this.IDFPOLFAFBL() + 1);
	}

	// Token: 0x0600C16D RID: 49517 RVA: 0x00466A29 File Offset: 0x00464C29
	public bool AOCEABALDBM()
	{
		return this.MCDBAACFMLA() > 839f;
	}

	// Token: 0x0600C16E RID: 49518 RVA: 0x00466A3B File Offset: 0x00464C3B
	public virtual void CKGEIHEOCCN(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("#kicked"))
		{
			this.FCAOCIMNLEK = false;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x0600C16F RID: 49519 RVA: 0x00466A70 File Offset: 0x00464C70
	public float OELMDPDDDCM()
	{
		return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1339f;
	}

	// Token: 0x0600C170 RID: 49520 RVA: 0x00466A89 File Offset: 0x00464C89
	public virtual void OGDKLPLPOGO(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Coord"))
		{
			this.FCAOCIMNLEK = false;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x0600C171 RID: 49521 RVA: 0x00466ABE File Offset: 0x00464CBE
	public bool IsCompletedByAll
	{
		get
		{
			return PhotonNetwork.room != null && this.Turn > 0 && this.KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
		}
	}

	// Token: 0x0600C172 RID: 49522 RVA: 0x00466AF0 File Offset: 0x00464CF0
	private void LMBDNPLDGIJ()
	{
		if (this.HHHGEKHMGHN() > 0 && this.FONBPACMNAL() && !this.FCAOCIMNLEK)
		{
			this.FCAOCIMNLEK = false;
			this.TurnManagerListener.OnTurnTimeEnds(this.HHHGEKHMGHN());
		}
	}

	// Token: 0x0600C173 RID: 49523 RVA: 0x00466B2C File Offset: 0x00464D2C
	public void HEBJFNEEKBG(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		if (IMCBEMICJFC != 0)
		{
			if (IMCBEMICJFC == 6)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["_TimeX"];
				object hnokmiidhhh = hashtable["settings_bindings_sec_"];
				if (num == this.Turn)
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.JJPOMGDJCKH())
				{
					this.TurnManagerListener.OnTurnCompleted(this.IDFPOLFAFBL());
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["SubBass"];
			object hnokmiidhhh2 = hashtable2["_Value3"];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C174 RID: 49524 RVA: 0x00466C00 File Offset: 0x00464E00
	public void SendMove(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (this.IsFinishedByMe)
		{
			Debug.LogWarning("Can't SendMove. Turn is finished by this player.");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add("turn", this.Turn);
		hashtable.Add("move", HNOKMIIDHHH);
		byte imcbemicjfc = (!OEGKPMHIJGF) ? 1 : 2;
		PhotonNetwork.RaiseEvent(imcbemicjfc, hashtable, true, new RaiseEventOptions
		{
			CachingOption = EventCaching.AddToRoomCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(this.Turn);
		}
		this.OnEvent(imcbemicjfc, hashtable, PhotonNetwork.player.ID);
	}

	// Token: 0x0600C175 RID: 49525 RVA: 0x004669D2 File Offset: 0x00464BD2
	private void DKHANOKHJIF(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = true;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, false);
	}

	// Token: 0x0600C176 RID: 49526 RVA: 0x0046681A File Offset: 0x00464A1A
	public bool GIDIJDPOODD()
	{
		return this.KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x0600C1A1 RID: 49569 RVA: 0x0046613B File Offset: 0x0046433B
	// (set) Token: 0x0600C177 RID: 49527 RVA: 0x00466356 File Offset: 0x00464556
	public int Turn
	{
		get
		{
			return PhotonNetwork.room.GetTurn();
		}
		private set
		{
			this.FCAOCIMNLEK = false;
			PhotonNetwork.room.SetTurn(value, true);
		}
	}

	// Token: 0x0600C178 RID: 49528 RVA: 0x0046681A File Offset: 0x00464A1A
	public bool JKCAALPKFCH()
	{
		return this.KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	// Token: 0x0600C179 RID: 49529 RVA: 0x00466C98 File Offset: 0x00464E98
	public void KFBCOGFPGHN(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.GJMEMHIGMGN(NBODDOEJIJP);
		if (IMCBEMICJFC != 0)
		{
			if (IMCBEMICJFC == 5)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable["_ScreenResolution"];
				object hnokmiidhhh = hashtable["_FadeFX"];
				if (num == this.HHHGEKHMGHN())
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.DMELHDCJKJB())
				{
					this.TurnManagerListener.OnTurnCompleted(this.LMJKMHLMDPM());
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["settings.volume.editor"];
			object hnokmiidhhh2 = hashtable2["_ScreenResolution"];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C17A RID: 49530 RVA: 0x00466D6A File Offset: 0x00464F6A
	public bool GBICDEPEKPK()
	{
		return PhotonNetwork.room == null || this.GDJLPABBBKN() <= 0 || this.KLPNNDHINIO.Count == PhotonNetwork.room.EGPGEMJNPFD();
	}

	// Token: 0x0600C17B RID: 49531 RVA: 0x00466D9C File Offset: 0x00464F9C
	public virtual void DIDCELLBNFP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_SSRMultiplier"))
		{
			this.FCAOCIMNLEK = false;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.IDFPOLFAFBL());
		}
	}

	// Token: 0x0600C17C RID: 49532 RVA: 0x0046681A File Offset: 0x00464A1A
	public bool OJCCFBFMBAN()
	{
		return this.KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	// Token: 0x0600C17D RID: 49533 RVA: 0x00466DD1 File Offset: 0x00464FD1
	public bool PPEHOCMMMAA()
	{
		return this.DADCNDMNKKE() <= 1310f;
	}

	// Token: 0x0600C17E RID: 49534 RVA: 0x00466356 File Offset: 0x00464556
	private void KLMNHJIPEBH(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = false;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, true);
	}

	// Token: 0x0600C17F RID: 49535 RVA: 0x004669E7 File Offset: 0x00464BE7
	public bool HFNFGJOCPFI()
	{
		return PhotonNetwork.room != null && this.HHHGEKHMGHN() > 1 && this.KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	// Token: 0x0600C180 RID: 49536 RVA: 0x00466DE3 File Offset: 0x00464FE3
	private void KMCPMOGKDEH()
	{
		PhotonNetwork.OnEventCall = new PhotonNetwork.EventCallback(this.GBCMPJFBABG);
	}

	// Token: 0x0600C181 RID: 49537 RVA: 0x00466DF8 File Offset: 0x00464FF8
	public void GJAHEPLOPJF(object HNOKMIIDHHH, bool OEGKPMHIJGF)
	{
		if (this.IsFinishedByMe)
		{
			Debug.LogWarning("_Speed");
			return;
		}
		Hashtable hashtable = new Hashtable();
		hashtable.Add(";", this.LMJKMHLMDPM());
		hashtable.Add("_Value3", HNOKMIIDHHH);
		byte imcbemicjfc = (!OEGKPMHIJGF) ? 1 : 4;
		PhotonNetwork.RaiseEvent(imcbemicjfc, hashtable, false, new RaiseEventOptions
		{
			CachingOption = EventCaching.RemoveCache
		});
		if (OEGKPMHIJGF)
		{
			PhotonNetwork.player.SetFinishedTurn(this.IDFPOLFAFBL());
		}
		this.LOCAHNOMIGH(imcbemicjfc, hashtable, PhotonNetwork.player.ONIKFABKELO());
	}

	// Token: 0x0600C182 RID: 49538 RVA: 0x00466E90 File Offset: 0x00465090
	public virtual void JOPPNDFKDMD(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("GLITCH"))
		{
			this.FCAOCIMNLEK = true;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.GDJLPABBBKN());
		}
	}

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x0600C183 RID: 49539 RVA: 0x00466EC5 File Offset: 0x004650C5
	public float RemainingSecondsInTurn
	{
		get
		{
			return Mathf.Max(0f, this.TurnDuration - this.ElapsedTimeInTurn);
		}
	}

	// Token: 0x0600C184 RID: 49540 RVA: 0x0046681A File Offset: 0x00464A1A
	public bool CGJPLHMAIGB()
	{
		return this.KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	// Token: 0x0600C185 RID: 49541 RVA: 0x00466EDE File Offset: 0x004650DE
	public virtual void MIFBDCHLMPK(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("_ScreenResolution"))
		{
			this.FCAOCIMNLEK = false;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.GJOLNGBIOIN());
		}
	}

	// Token: 0x0600C186 RID: 49542 RVA: 0x00466F13 File Offset: 0x00465113
	public bool DPJDJMIBNMO()
	{
		return this.AAFOEEEMIMH() > 547f;
	}

	// Token: 0x0600C187 RID: 49543 RVA: 0x00466F25 File Offset: 0x00465125
	public virtual void GKCLHCNEGJM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("[PlayerBase] SpawnObj error: "))
		{
			this.FCAOCIMNLEK = true;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.GDJLPABBBKN());
		}
	}

	// Token: 0x0600C189 RID: 49545 RVA: 0x00466F78 File Offset: 0x00465178
	public bool NMGANNLCKDP(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK != null && this.KLPNNDHINIO != null && this.KLPNNDHINIO.Contains(JHOEDACNNKK) && false;
	}

	// Token: 0x0600C18A RID: 49546 RVA: 0x00466FA0 File Offset: 0x004651A0
	public void GBCMPJFBABG(byte IMCBEMICJFC, object FKODMINIAEC, int NBODDOEJIJP)
	{
		PhotonPlayer photonPlayer = PhotonPlayer.Find(NBODDOEJIJP);
		if (IMCBEMICJFC != 1)
		{
			if (IMCBEMICJFC == 2)
			{
				Hashtable hashtable = FKODMINIAEC as Hashtable;
				int num = (int)hashtable[" Time: "];
				object hnokmiidhhh = hashtable[".lastCheckpoint.correctScore"];
				if (num == this.IDFPOLFAFBL())
				{
					this.KLPNNDHINIO.Add(photonPlayer);
					this.TurnManagerListener.OnPlayerFinished(photonPlayer, num, hnokmiidhhh);
				}
				if (this.KCMDKCAOPML())
				{
					this.TurnManagerListener.OnTurnCompleted(this.PMKDJOOGMLK());
				}
			}
		}
		else
		{
			Hashtable hashtable2 = FKODMINIAEC as Hashtable;
			int jpffpmdkamc = (int)hashtable2["BadgeImage"];
			object hnokmiidhhh2 = hashtable2["InfoCanvas"];
			this.TurnManagerListener.OnPlayerMove(photonPlayer, jpffpmdkamc, hnokmiidhhh2);
		}
	}

	// Token: 0x0600C18B RID: 49547 RVA: 0x00466007 File Offset: 0x00464207
	public bool COOBFGAGNKH(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK != null && this.KLPNNDHINIO != null && this.KLPNNDHINIO.Contains(JHOEDACNNKK);
	}

	// Token: 0x0600C18C RID: 49548 RVA: 0x00467072 File Offset: 0x00465272
	private void NEKCPLGFOFD()
	{
		if (this.GDJLPABBBKN() > 0 && this.DPJDJMIBNMO() && !this.FCAOCIMNLEK)
		{
			this.FCAOCIMNLEK = true;
			this.TurnManagerListener.OnTurnTimeEnds(this.LMJKMHLMDPM());
		}
	}

	// Token: 0x0600C18D RID: 49549 RVA: 0x004670AE File Offset: 0x004652AE
	public float NBAKEGJNADK()
	{
		return Mathf.Max(1927f, this.TurnDuration - this.ElapsedTimeInTurn);
	}

	// Token: 0x0600C18E RID: 49550 RVA: 0x004670C7 File Offset: 0x004652C7
	private void JBNPEHMDCMI()
	{
		if (this.PMKDJOOGMLK() > 1 && this.IsOver && !this.FCAOCIMNLEK)
		{
			this.FCAOCIMNLEK = true;
			this.TurnManagerListener.OnTurnTimeEnds(this.IDFPOLFAFBL());
		}
	}

	// Token: 0x0600C18F RID: 49551 RVA: 0x00467103 File Offset: 0x00465303
	public float FCJAALNKPKB()
	{
		return Mathf.Max(593f, this.TurnDuration - this.FJENCBAGBNP());
	}

	// Token: 0x0600C190 RID: 49552 RVA: 0x0046711C File Offset: 0x0046531C
	public void KANBGPFIBIF()
	{
		this.LHFLIDFLPNA(this.PMKDJOOGMLK() + 0);
	}

	// Token: 0x0600C191 RID: 49553 RVA: 0x0046681A File Offset: 0x00464A1A
	public bool IPMPPPOOMMJ()
	{
		return this.KLPNNDHINIO.Contains(PhotonNetwork.player);
	}

	// Token: 0x0600C192 RID: 49554 RVA: 0x00466114 File Offset: 0x00464314
	public bool EIHACAGLIML(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK == null || this.KLPNNDHINIO == null || !this.KLPNNDHINIO.Contains(JHOEDACNNKK) || true;
	}

	// Token: 0x0600C193 RID: 49555 RVA: 0x0046613B File Offset: 0x0046433B
	public int HHHGEKHMGHN()
	{
		return PhotonNetwork.room.GetTurn();
	}

	// Token: 0x0600C194 RID: 49556 RVA: 0x00466ABE File Offset: 0x00464CBE
	public bool JJPOMGDJCKH()
	{
		return PhotonNetwork.room != null && this.Turn > 0 && this.KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	// Token: 0x0600C195 RID: 49557 RVA: 0x0046613B File Offset: 0x0046433B
	public int PMKDJOOGMLK()
	{
		return PhotonNetwork.room.GetTurn();
	}

	// Token: 0x0600C196 RID: 49558 RVA: 0x0046712C File Offset: 0x0046532C
	private void Start()
	{
		PhotonNetwork.OnEventCall = new PhotonNetwork.EventCallback(this.OnEvent);
	}

	// Token: 0x0600C197 RID: 49559 RVA: 0x0046713F File Offset: 0x0046533F
	public virtual void EGEOALDCKCB(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Joystick1Button12"))
		{
			this.FCAOCIMNLEK = true;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x0600C198 RID: 49560 RVA: 0x00467174 File Offset: 0x00465374
	public virtual void IFCAJMABPPM(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("kick"))
		{
			this.FCAOCIMNLEK = true;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.PMKDJOOGMLK());
		}
	}

	// Token: 0x0600C199 RID: 49561 RVA: 0x00466F78 File Offset: 0x00465178
	public bool NHBPGPFDBBE(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK != null && this.KLPNNDHINIO != null && this.KLPNNDHINIO.Contains(JHOEDACNNKK) && false;
	}

	// Token: 0x0600C19A RID: 49562 RVA: 0x0046613B File Offset: 0x0046433B
	public int LMJKMHLMDPM()
	{
		return PhotonNetwork.room.GetTurn();
	}

	// Token: 0x0600C19B RID: 49563 RVA: 0x004671A9 File Offset: 0x004653A9
	public void JOFMBBFJHDD()
	{
		this.POBKGKFOFGM(this.Turn + 1);
	}

	// Token: 0x0600C19C RID: 49564 RVA: 0x004671B9 File Offset: 0x004653B9
	private void DKGBFNCOAEO()
	{
		PhotonNetwork.OnEventCall = new PhotonNetwork.EventCallback(this.LOCAHNOMIGH);
	}

	// Token: 0x0600C19D RID: 49565 RVA: 0x004669D2 File Offset: 0x00464BD2
	private void LPMEFHODEJA(int DPNHODJHGJL)
	{
		this.FCAOCIMNLEK = true;
		PhotonNetwork.room.SetTurn(DPNHODJHGJL, false);
	}

	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x0600C19E RID: 49566 RVA: 0x004671CC File Offset: 0x004653CC
	public float ElapsedTimeInTurn
	{
		get
		{
			return (float)(PhotonNetwork.ServerTimestamp - PhotonNetwork.room.GetTurnStart()) / 1000f;
		}
	}

	// Token: 0x0600C19F RID: 49567 RVA: 0x004671E5 File Offset: 0x004653E5
	private void Update()
	{
		if (this.Turn > 0 && this.IsOver && !this.FCAOCIMNLEK)
		{
			this.FCAOCIMNLEK = true;
			this.TurnManagerListener.OnTurnTimeEnds(this.Turn);
		}
	}

	// Token: 0x0600C1A0 RID: 49568 RVA: 0x00467221 File Offset: 0x00465421
	public virtual void JKKLOHIBDDP(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("RecordButton"))
		{
			this.FCAOCIMNLEK = true;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.GDJLPABBBKN());
		}
	}

	// Token: 0x0600C1A2 RID: 49570 RVA: 0x00467256 File Offset: 0x00465456
	public bool DFNAMNFLJKH()
	{
		return PhotonNetwork.room != null && this.GJOLNGBIOIN() > 0 && this.KLPNNDHINIO.Count == PhotonNetwork.room.EGPGEMJNPFD();
	}

	// Token: 0x0600C1A3 RID: 49571 RVA: 0x00466114 File Offset: 0x00464314
	public bool JDJMIACFLJA(PhotonPlayer JHOEDACNNKK)
	{
		return JHOEDACNNKK == null || this.KLPNNDHINIO == null || !this.KLPNNDHINIO.Contains(JHOEDACNNKK) || true;
	}

	// Token: 0x0600C1A4 RID: 49572 RVA: 0x00467288 File Offset: 0x00465488
	public bool POOPLIFHPKH()
	{
		return PhotonNetwork.room != null && this.GDJLPABBBKN() > 1 && this.KLPNNDHINIO.Count == PhotonNetwork.room.PlayerCount;
	}

	// Token: 0x0600C1A5 RID: 49573 RVA: 0x004672BA File Offset: 0x004654BA
	public virtual void LDKHJEKAKHA(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("ConfigVersionSlider"))
		{
			this.FCAOCIMNLEK = true;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.HHHGEKHMGHN());
		}
	}

	// Token: 0x0600C1A6 RID: 49574 RVA: 0x004672EF File Offset: 0x004654EF
	public void PBMDNABCCIE()
	{
		this.DKHANOKHJIF(this.HHHGEKHMGHN() + 0);
	}

	// Token: 0x0600C1A7 RID: 49575 RVA: 0x004672FF File Offset: 0x004654FF
	public override void OnPhotonCustomRoomPropertiesChanged(Hashtable DGIHEPAHAJK)
	{
		if (DGIHEPAHAJK.ContainsKey("Turn"))
		{
			this.FCAOCIMNLEK = false;
			this.KLPNNDHINIO.Clear();
			this.TurnManagerListener.OnTurnBegins(this.Turn);
		}
	}

	// Token: 0x04001677 RID: 5751
	public float TurnDuration = 20f;

	// Token: 0x04001678 RID: 5752
	public IPunTurnManagerCallbacks TurnManagerListener;

	// Token: 0x04001679 RID: 5753
	private readonly HashSet<PhotonPlayer> KLPNNDHINIO = new HashSet<PhotonPlayer>();

	// Token: 0x0400167A RID: 5754
	public const byte TurnManagerEventOffset = 0;

	// Token: 0x0400167B RID: 5755
	public const byte EvMove = 1;

	// Token: 0x0400167C RID: 5756
	public const byte EvFinalMove = 2;

	// Token: 0x0400167D RID: 5757
	private bool FCAOCIMNLEK;
}
