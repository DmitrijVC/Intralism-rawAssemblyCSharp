using System;
using System.Collections.Generic;
using Photon;
using UnityEngine;

// Token: 0x02000353 RID: 851
[RequireComponent(typeof(PhotonView))]
public class PickupItem : Photon.MonoBehaviour, IPunObservable
{
	// Token: 0x0600BF97 RID: 49047 RVA: 0x0045B8A8 File Offset: 0x00459AA8
	public void ODEGIMJHPGB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && this.SecondsBeforeRespawn <= 1681f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BF98 RID: 49048 RVA: 0x0045B910 File Offset: 0x00459B10
	[PunRPC]
	public void PunPickup(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			Debug.Log(string.Concat(new object[]
			{
				"Ignored PU RPC, cause item is inactive. ",
				base.gameObject,
				" SecondsBeforeRespawn: ",
				this.SecondsBeforeRespawn,
				" TimeOfRespawn: ",
				this.TimeOfRespawn,
				" respawn in future: ",
				this.TimeOfRespawn > PhotonNetwork.time
			}));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("OnPickedUp", this);
		}
		if (this.SecondsBeforeRespawn <= 0f)
		{
			this.KNABLPOBADA(0f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 0.0)
			{
				this.KNABLPOBADA((float)num2);
			}
		}
	}

	// Token: 0x0600BF99 RID: 49049 RVA: 0x0045BA33 File Offset: 0x00459C33
	public void KFBAOGODIMM()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.GBHNDHLAJLI().MIAHMDGOOPJ(" cannot be used as a 3D LUT.", PhotonTargets.AllBuffered, new object[1]);
	}

	// Token: 0x0600BF9A RID: 49050 RVA: 0x0045BA60 File Offset: 0x00459C60
	internal void PPNPJENOMGA(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 456.0;
		if (DPMFFBEDNNN > 380f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke(" | ", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BF9B RID: 49051 RVA: 0x0045BAB9 File Offset: 0x00459CB9
	public int OKNPEBGCPEA()
	{
		return base.JAEJDHHCJJO().EIMHMIJGMHG();
	}

	// Token: 0x0600BF9C RID: 49052 RVA: 0x0045BAC8 File Offset: 0x00459CC8
	internal void JKLFFEGJCKH()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1660.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BF9D RID: 49053 RVA: 0x0045BB14 File Offset: 0x00459D14
	public void DCMIJEPGKGP()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.AAMNKPHHHCI().KEKKFNNMLMG("speed", PhotonTargets.AllViaServer, new object[1]);
	}

	// Token: 0x0600BF9E RID: 49054 RVA: 0x0045BB40 File Offset: 0x00459D40
	public void OMMNCHIMHBJ(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			base.GBHNDHLAJLI().IKIJDNPJKPM("#", PhotonTargets.Others, new object[]
			{
				ENENGMDFKHK
			});
		}
	}

	// Token: 0x0600BF9F RID: 49055 RVA: 0x0045BB70 File Offset: 0x00459D70
	internal void KNABLPOBADA(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 0.0;
		if (DPMFFBEDNNN > 0f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("PunRespawn", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFA0 RID: 49056 RVA: 0x0045BBC9 File Offset: 0x00459DC9
	public int DMEACFJNMML()
	{
		return base.GBMJAPGLMGB().NPPEFODKHKN();
	}

	// Token: 0x0600BFA1 RID: 49057 RVA: 0x0045BBD6 File Offset: 0x00459DD6
	public void MOJMJPJHGBO()
	{
		if (this.PickupIsMine)
		{
			base.JAEJDHHCJJO().KEKKFNNMLMG("CameraFilterPack/TV_Chromatical2", PhotonTargets.AllBufferedViaServer, new object[0]);
		}
	}

	// Token: 0x0600BFA2 RID: 49058 RVA: 0x0045BBFC File Offset: 0x00459DFC
	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && this.SecondsBeforeRespawn <= 0f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.ReceiveNext();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFA3 RID: 49059 RVA: 0x0045BC61 File Offset: 0x00459E61
	public void NIOAANAHIIO()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.photonView.IKIJDNPJKPM("_ReflectionTexture3", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BFA4 RID: 49060 RVA: 0x0045BC8D File Offset: 0x00459E8D
	internal void AMHOLGKGGBD(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("settings.arcsnohitsoundtimedelay");
		this.FDDMFDFLDOD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFA5 RID: 49061 RVA: 0x0045BCB0 File Offset: 0x00459EB0
	public void MOLJFGIOENO()
	{
		if (this.PickupIsMine)
		{
			base.photonView.KEKKFNNMLMG("ViewMenu", PhotonTargets.All, new object[0]);
		}
	}

	// Token: 0x0600BFA6 RID: 49062 RVA: 0x0045BCD4 File Offset: 0x00459ED4
	internal void HHIKGCOAPDO()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1760.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BFA7 RID: 49063 RVA: 0x0045BD20 File Offset: 0x00459F20
	internal void JIMAKAHKAOB(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_ScreenResolution");
		this.FCEDJDBOOGD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFA8 RID: 49064 RVA: 0x0045BD43 File Offset: 0x00459F43
	public void BOCMAJBBLOM(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.IBKCMBIGOEJ();
			string lblkdnnpaco = "JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.";
			PhotonTargets mpnmoonbmii = PhotonTargets.Others;
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFA9 RID: 49065 RVA: 0x0045BD70 File Offset: 0x00459F70
	public void GGMHFHPCBGA()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.EDIJKHEMPAD().MIAHMDGOOPJ("\t", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BFAA RID: 49066 RVA: 0x0045BD9C File Offset: 0x00459F9C
	public void ENOMMKAFBPN(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.GBMJAPGLMGB();
			string lblkdnnpaco = "MusicFileSelector";
			PhotonTargets mpnmoonbmii = (PhotonTargets)8;
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFAB RID: 49067 RVA: 0x0045BDC9 File Offset: 0x00459FC9
	public void JGACDFLHGKF()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.OELHGNKAMEG().KEKKFNNMLMG("Tab2Content", PhotonTargets.OthersBuffered, new object[0]);
	}

	// Token: 0x0600BFAC RID: 49068 RVA: 0x0045BDF5 File Offset: 0x00459FF5
	public int EIKELGOOEAN()
	{
		return base.GBHNDHLAJLI().EIMHMIJGMHG();
	}

	// Token: 0x0600BFAD RID: 49069 RVA: 0x0045BE02 File Offset: 0x0045A002
	internal void LLIDOADHPJD(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("MapFolderInputField");
		this.DGGFBMKKJFO();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFAE RID: 49070 RVA: 0x0045BE28 File Offset: 0x0045A028
	public void IALOOABLMLF(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.KCAOJFPDEIP())
		{
			this.OCPHFBJHNMM();
		}
	}

	// Token: 0x0600BFAF RID: 49071 RVA: 0x0045BE64 File Offset: 0x0045A064
	public void OAKNHHEJGKJ(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.EDIJKHEMPAD();
			string lblkdnnpaco = "...";
			PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFB0 RID: 49072 RVA: 0x0045BE94 File Offset: 0x0045A094
	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && this.SecondsBeforeRespawn <= 1574f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFB1 RID: 49073 RVA: 0x0045BBC9 File Offset: 0x00459DC9
	public int DHBFALLCHCG()
	{
		return base.GBMJAPGLMGB().NPPEFODKHKN();
	}

	// Token: 0x0600BFB2 RID: 49074 RVA: 0x0045BEF9 File Offset: 0x0045A0F9
	public void IGCDPNAHFFK(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.IBKCMBIGOEJ();
			string lblkdnnpaco = "CameraFilterPack/Blend2Camera_Color";
			PhotonTargets mpnmoonbmii = (PhotonTargets)8;
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFB3 RID: 49075 RVA: 0x0045BF26 File Offset: 0x0045A126
	public void DMNNBOKGIJO(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.BLMHOKPIMOD();
			string lblkdnnpaco = "_OcclusionTexture";
			PhotonTargets mpnmoonbmii = PhotonTargets.All;
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFB4 RID: 49076 RVA: 0x0045BF53 File Offset: 0x0045A153
	public int PKLGNLOHIHG()
	{
		return base.GMAHNPNHMFK().NPPEFODKHKN();
	}

	// Token: 0x0600BFB5 RID: 49077 RVA: 0x0045BF60 File Offset: 0x0045A160
	public void DIBKBFLCPHB()
	{
		if (this.PickupIsMine)
		{
			base.OELHGNKAMEG().MIAHMDGOOPJ("table", PhotonTargets.AllViaServer, new object[1]);
		}
	}

	// Token: 0x0600BFB6 RID: 49078 RVA: 0x0045BF84 File Offset: 0x0045A184
	public void GGEKDHHOOCH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ() && this.SecondsBeforeRespawn <= 150f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFB7 RID: 49079 RVA: 0x0045BFEC File Offset: 0x0045A1EC
	public void ECHLAMLLABB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && this.SecondsBeforeRespawn <= 983f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFB8 RID: 49080 RVA: 0x0045C054 File Offset: 0x0045A254
	public void AHPEFIMKILH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[0] = "open";
			array[1] = base.gameObject;
			array[0] = "_ScreenResolution";
			array[1] = this.SecondsBeforeRespawn;
			array[0] = "settings.volume.menu";
			array[1] = this.TimeOfRespawn;
			array[5] = "_Intervale";
			array[0] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("Drop_With_Obj", this);
		}
		if (this.SecondsBeforeRespawn <= 1248f)
		{
			this.GMMLFEEGIGI(595f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.INALDKDNCCN();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 616.0)
			{
				this.JJEJCCPCNOP((float)num2);
			}
		}
	}

	// Token: 0x0600BFB9 RID: 49081 RVA: 0x0045C177 File Offset: 0x0045A377
	internal void PFEEGCOBHAM(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_ScreenResolution");
		this.DEGJEDLKKJK();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFBA RID: 49082 RVA: 0x0045C19C File Offset: 0x0045A39C
	internal void FABHBEHMJEJ()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 347.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600BFBB RID: 49083 RVA: 0x0045C1E8 File Offset: 0x0045A3E8
	public void AKPCPGPOKKG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && this.SecondsBeforeRespawn <= 1758f)
		{
			HCIJEDFCNOP.PBECMJMDHBI(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFBC RID: 49084 RVA: 0x0045C250 File Offset: 0x0045A450
	public void HNAIGBNLACC(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[3];
			array[0] = "SetSunSensitivity";
			array[0] = base.gameObject;
			array[7] = "EventSystem";
			array[6] = this.SecondsBeforeRespawn;
			array[3] = "BitsData";
			array[8] = this.TimeOfRespawn;
			array[5] = "_EmissionGain";
			array[8] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("_Value2", this);
		}
		if (this.SecondsBeforeRespawn <= 201f)
		{
			this.PIMDACECPMA(214f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.AMGFGPMEMCG();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 1257.0)
			{
				this.PIMDACECPMA((float)num2);
			}
		}
	}

	// Token: 0x0600BFBD RID: 49085 RVA: 0x0045C373 File Offset: 0x0045A573
	public void PPFNLJKLIIM(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.IBKCMBIGOEJ();
			string lblkdnnpaco = "_TimeX";
			PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
			object[] array = new object[1];
			array[1] = ENENGMDFKHK;
			photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFBE RID: 49086 RVA: 0x0045C3A0 File Offset: 0x0045A5A0
	public void KFNACDLDBIP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[3];
			array[0] = "SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ";
			array[1] = base.gameObject;
			array[1] = "menu.selectedplaymode";
			array[5] = this.SecondsBeforeRespawn;
			array[5] = "Joystick";
			array[1] = this.TimeOfRespawn;
			array[5] = "_Value2";
			array[8] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("L2", this);
		}
		if (this.SecondsBeforeRespawn <= 1030f)
		{
			this.IDIJNCBLDBH(1552f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.FKNAEDNOBGP();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 1755.0)
			{
				this.OPHALGOIDOI((float)num2);
			}
		}
	}

	// Token: 0x0600BFBF RID: 49087 RVA: 0x0045C4C4 File Offset: 0x0045A6C4
	internal void GMMLFEEGIGI(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 755.0;
		if (DPMFFBEDNNN > 921f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("[DiscordController] Join ({0})", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFC0 RID: 49088 RVA: 0x0045C51D File Offset: 0x0045A71D
	public void OJFBDENEMMN()
	{
		if (this.PickupIsMine)
		{
			base.JAEJDHHCJJO().MIAHMDGOOPJ("_Value4", PhotonTargets.MasterClient, new object[1]);
		}
	}

	// Token: 0x0600BFC1 RID: 49089 RVA: 0x0045C541 File Offset: 0x0045A741
	public void DOIKKHAJLEB()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.photonView.PBMFBOOALKA("Tab2Content", PhotonTargets.AllBuffered, new object[0]);
	}

	// Token: 0x0600BFC2 RID: 49090 RVA: 0x0045C56D File Offset: 0x0045A76D
	public void BIDJKHEHBHN(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.EOOCGIFFKBG();
			string lblkdnnpaco = "/";
			PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFC3 RID: 49091 RVA: 0x0045C59A File Offset: 0x0045A79A
	public void Pickup()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.photonView.RPC("PunPickup", PhotonTargets.AllViaServer, new object[0]);
	}

	// Token: 0x0600BFC4 RID: 49092 RVA: 0x0045C5C8 File Offset: 0x0045A7C8
	internal void OLCDEGJDIBB(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 723.0;
		if (DPMFFBEDNNN > 177f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("_Distortion", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFC6 RID: 49094 RVA: 0x0045C634 File Offset: 0x0045A834
	internal void OPHALGOIDOI(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 1031.0;
		if (DPMFFBEDNNN > 319f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("CameraFilterPack_Glasses_On6", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFC7 RID: 49095 RVA: 0x0045C68D File Offset: 0x0045A88D
	public void AHIJEHHLCGN()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.photonView.KEKKFNNMLMG("_TimeX", PhotonTargets.OthersBuffered, new object[0]);
	}

	// Token: 0x0600BFC8 RID: 49096 RVA: 0x0045C6B9 File Offset: 0x0045A8B9
	public int BIDKPFPPLDP()
	{
		return base.BLMHOKPIMOD().KINIHBOKFJH();
	}

	// Token: 0x0600BFC9 RID: 49097 RVA: 0x0045C6C6 File Offset: 0x0045A8C6
	public void Drop()
	{
		if (this.PickupIsMine)
		{
			base.photonView.RPC("PunRespawn", PhotonTargets.AllViaServer, new object[0]);
		}
	}

	// Token: 0x0600BFCA RID: 49098 RVA: 0x0045C6EA File Offset: 0x0045A8EA
	public void GHKMNMLNOLM()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.GBMJAPGLMGB().PBMFBOOALKA("Horizontal", PhotonTargets.MasterClient, new object[0]);
	}

	// Token: 0x0600BFCB RID: 49099 RVA: 0x0045C718 File Offset: 0x0045A918
	internal void BGGFOKGOALL()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1834.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600BFCC RID: 49100 RVA: 0x0045C764 File Offset: 0x0045A964
	internal void CKBNBEPJOEE(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 960.0;
		if (DPMFFBEDNNN > 1958f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("/Segment-[Up]", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFCD RID: 49101 RVA: 0x0045C7BD File Offset: 0x0045A9BD
	internal void AMHAGFFHLMI(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("_LightIntensity");
		this.BGGFOKGOALL();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFCE RID: 49102 RVA: 0x0045C7E0 File Offset: 0x0045A9E0
	internal void FCEDJDBOOGD()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 521.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BFCF RID: 49103 RVA: 0x0045C82C File Offset: 0x0045AA2C
	public void JMJOAIDFIIG()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.EDIJKHEMPAD().RPC("z", PhotonTargets.Others, new object[1]);
	}

	// Token: 0x0600BFD0 RID: 49104 RVA: 0x0045C858 File Offset: 0x0045AA58
	internal void APAPAJBEAII(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 1994.0;
		if (DPMFFBEDNNN > 877f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("VisionBlur", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFD1 RID: 49105 RVA: 0x0045C8B1 File Offset: 0x0045AAB1
	internal void DGIAHICNPJG(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("LeaderboardsButton");
		this.OHPFGOOJJKD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFD2 RID: 49106 RVA: 0x0045C8D4 File Offset: 0x0045AAD4
	public void ELHLCLALKJF(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.DOLKFPIABDD())
		{
			this.GGMHFHPCBGA();
		}
	}

	// Token: 0x0600BFD3 RID: 49107 RVA: 0x0045C910 File Offset: 0x0045AB10
	internal void KEMJCJGNPBA(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("ItemsUploader");
		this.JHBEIDMONOI();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFD4 RID: 49108 RVA: 0x0045C934 File Offset: 0x0045AB34
	internal void MFDANMNLGMK()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 181.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600BFD5 RID: 49109 RVA: 0x0045C980 File Offset: 0x0045AB80
	public void PODMNNAFPCC()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.AAMNKPHHHCI().MIAHMDGOOPJ("Spawn ark to be pressed at this time", PhotonTargets.AllBufferedViaServer, new object[0]);
	}

	// Token: 0x0600BFD6 RID: 49110 RVA: 0x0045C9AC File Offset: 0x0045ABAC
	public void EMKIGFCHGPJ()
	{
		if (this.PickupIsMine)
		{
			base.BLMHOKPIMOD().RPC("_TimeX", PhotonTargets.OthersBuffered, new object[0]);
		}
	}

	// Token: 0x0600BFD7 RID: 49111 RVA: 0x0045C9D0 File Offset: 0x0045ABD0
	public void PFGNDEDCOEB(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.AAMNKPHHHCI();
			string lblkdnnpaco = "&page=";
			PhotonTargets mpnmoonbmii = (PhotonTargets)8;
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFD8 RID: 49112 RVA: 0x0045C9FD File Offset: 0x0045ABFD
	public int FKFHMBGPFHF()
	{
		return base.IBKCMBIGOEJ().viewID;
	}

	// Token: 0x0600BFD9 RID: 49113 RVA: 0x0045CA0C File Offset: 0x0045AC0C
	internal void OMIAIKLABKM()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1979.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600BFDA RID: 49114 RVA: 0x0045CA58 File Offset: 0x0045AC58
	internal void DGGFBMKKJFO()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 461.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BFDB RID: 49115 RVA: 0x0045CAA4 File Offset: 0x0045ACA4
	public void OKGCHKJODHF()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.CIACEFBNDDJ().PBMFBOOALKA("Bad parameters for setbool! Use <key> <value>", PhotonTargets.AllBuffered, new object[1]);
	}

	// Token: 0x0600BFDC RID: 49116 RVA: 0x0045CAD0 File Offset: 0x0045ACD0
	public int FEOKOFDBLGL()
	{
		return base.BLMHOKPIMOD().viewID;
	}

	// Token: 0x0600BFDD RID: 49117 RVA: 0x0045CADD File Offset: 0x0045ACDD
	public void EBDKPAOGEGI(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.EOOCGIFFKBG();
			string lblkdnnpaco = "_Value2";
			PhotonTargets mpnmoonbmii = PhotonTargets.All;
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFDE RID: 49118 RVA: 0x0045CB0C File Offset: 0x0045AD0C
	public void OnTriggerEnter(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.isMine)
		{
			this.Pickup();
		}
	}

	// Token: 0x0600BFDF RID: 49119 RVA: 0x0045CB48 File Offset: 0x0045AD48
	public void JCABMIOMNPF(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.CIACEFBNDDJ();
			string lblkdnnpaco = "hand";
			PhotonTargets mpnmoonbmii = PhotonTargets.All;
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFE0 RID: 49120 RVA: 0x0045CB75 File Offset: 0x0045AD75
	public int DNEBJBBNLDD()
	{
		return base.EDIJKHEMPAD().viewID;
	}

	// Token: 0x0600BFE1 RID: 49121 RVA: 0x0045CB84 File Offset: 0x0045AD84
	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && this.SecondsBeforeRespawn <= 698f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFE2 RID: 49122 RVA: 0x0045CBEC File Offset: 0x0045ADEC
	public void FNIOFFCNCEG(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[6];
			array[0] = " on effect ";
			array[1] = base.gameObject;
			array[2] = "inventory.selected.";
			array[8] = this.SecondsBeforeRespawn;
			array[7] = "setbool";
			array[1] = this.TimeOfRespawn;
			array[3] = "_AccumulationTex";
			array[2] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("_Value2", this);
		}
		if (this.SecondsBeforeRespawn <= 975f)
		{
			this.OAOIJGBDKAL(1398f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.HBPFFECIHKL();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 1107.0)
			{
				this.IDIJNCBLDBH((float)num2);
			}
		}
	}

	// Token: 0x0600BFE3 RID: 49123 RVA: 0x0045CD10 File Offset: 0x0045AF10
	public void MBIPCKMIBFG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && this.SecondsBeforeRespawn <= 873f)
		{
			HCIJEDFCNOP.SendNext(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFE4 RID: 49124 RVA: 0x0045CD75 File Offset: 0x0045AF75
	internal void KNAJGGKNLDK(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("The given 2D texture ");
		this.AMCALMOAOMP();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFE5 RID: 49125 RVA: 0x0045CD98 File Offset: 0x0045AF98
	public void ONAMLBMDHJC(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.OELHGNKAMEG();
			string lblkdnnpaco = "failed";
			PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
			object[] array = new object[0];
			array[1] = ENENGMDFKHK;
			photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFE6 RID: 49126 RVA: 0x0045CDC8 File Offset: 0x0045AFC8
	public void LDDKKPNINLC(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[4];
			array[0] = "InventoryButton";
			array[1] = base.gameObject;
			array[4] = "image";
			array[7] = this.SecondsBeforeRespawn;
			array[1] = " not exist";
			array[0] = this.TimeOfRespawn;
			array[0] = "CameraFilterPack/Blur_Regular";
			array[2] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("RoomNameText", this);
		}
		if (this.SecondsBeforeRespawn <= 1196f)
		{
			this.OLCDEGJDIBB(1457f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.GJDFJLLPCEC();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 518.0)
			{
				this.CKBNBEPJOEE((float)num2);
			}
		}
	}

	// Token: 0x0600BFE7 RID: 49127 RVA: 0x0045CEEC File Offset: 0x0045B0EC
	public void PCMFEAOHBNO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && this.SecondsBeforeRespawn <= 844f)
		{
			HCIJEDFCNOP.FADAIFFMBEL(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFE8 RID: 49128 RVA: 0x0045CF54 File Offset: 0x0045B154
	public void GEJCKOBIHFF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && this.SecondsBeforeRespawn <= 668f)
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFE9 RID: 49129 RVA: 0x0045CFBC File Offset: 0x0045B1BC
	internal void PIMDACECPMA(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 906.0;
		if (DPMFFBEDNNN > 1341f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("fetch", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFEA RID: 49130 RVA: 0x0045D015 File Offset: 0x0045B215
	internal void JHLABNLLMOI(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("#");
		this.MFDANMNLGMK();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFEB RID: 49131 RVA: 0x0045D038 File Offset: 0x0045B238
	public void NFCNNHIDOHJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[0];
			array[0] = "settings.arcsdestroydelay";
			array[1] = base.gameObject;
			array[6] = " not exist";
			array[6] = this.SecondsBeforeRespawn;
			array[1] = "Scene";
			array[3] = this.TimeOfRespawn;
			array[4] = "_Value4";
			array[2] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("CameraFilterPack_3D_Computer1", this);
		}
		if (this.SecondsBeforeRespawn <= 1f)
		{
			this.JJEJCCPCNOP(1015f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.MFAFNILAGDF();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 133.0)
			{
				this.OPHALGOIDOI((float)num2);
			}
		}
	}

	// Token: 0x0600BFEC RID: 49132 RVA: 0x0045D15B File Offset: 0x0045B35B
	public void Drop(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			base.photonView.RPC("PunRespawn", PhotonTargets.AllViaServer, new object[]
			{
				ENENGMDFKHK
			});
		}
	}

	// Token: 0x0600BFED RID: 49133 RVA: 0x0045D188 File Offset: 0x0045B388
	public void ENLOGLEEBBP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[1] = "ViewID {0} {1}{2}";
			array[1] = base.gameObject;
			array[4] = "/";
			array[3] = this.SecondsBeforeRespawn;
			array[3] = "/Saved Games/";
			array[0] = this.TimeOfRespawn;
			array[5] = "GlassesColor";
			array[6] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("settings.enablehitsoundsinrelax", this);
		}
		if (this.SecondsBeforeRespawn <= 604f)
		{
			this.OPHALGOIDOI(257f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.LKENLCMIPPL();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 1565.0)
			{
				this.APAPAJBEAII((float)num2);
			}
		}
	}

	// Token: 0x0600BFEE RID: 49134 RVA: 0x0045D2AB File Offset: 0x0045B4AB
	public void BMCDOLNMNDN()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.GBHNDHLAJLI().RPC("No Name", (PhotonTargets)8, new object[0]);
	}

	// Token: 0x0600BFEF RID: 49135 RVA: 0x0045D2D8 File Offset: 0x0045B4D8
	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ() && this.SecondsBeforeRespawn <= 1475f)
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFF0 RID: 49136 RVA: 0x0045D340 File Offset: 0x0045B540
	internal void PPLLHBOPGLA()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 654.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BFF1 RID: 49137 RVA: 0x0045D38C File Offset: 0x0045B58C
	public void ELFDFMKPNDP(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[7];
			array[0] = "SpawnObj";
			array[0] = base.gameObject;
			array[0] = "MessageText";
			array[7] = this.SecondsBeforeRespawn;
			array[6] = " methods \"";
			array[5] = this.TimeOfRespawn;
			array[7] = "isVisible";
			array[3] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("_BorderSize", this);
		}
		if (this.SecondsBeforeRespawn <= 893f)
		{
			this.GANGFBPADGO(285f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 792.0)
			{
				this.PIMDACECPMA((float)num2);
			}
		}
	}

	// Token: 0x0600BFF2 RID: 49138 RVA: 0x0045D4AF File Offset: 0x0045B6AF
	public int KHEHPCAFJBC()
	{
		return base.JAEJDHHCJJO().KINIHBOKFJH();
	}

	// Token: 0x0600BFF3 RID: 49139 RVA: 0x0045D4BC File Offset: 0x0045B6BC
	[PunRPC]
	internal void PunRespawn()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 0.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BFF4 RID: 49140 RVA: 0x0045D508 File Offset: 0x0045B708
	public void IGACCOIJFGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ() && this.SecondsBeforeRespawn <= 1146f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFF5 RID: 49141 RVA: 0x0045D570 File Offset: 0x0045B770
	public void PJBBBAOPOCC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN() && this.SecondsBeforeRespawn <= 326f)
		{
			HCIJEDFCNOP.FADAIFFMBEL(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600BFF6 RID: 49142 RVA: 0x0045D5D5 File Offset: 0x0045B7D5
	public void MGLOIIDCIGF()
	{
		if (this.PickupIsMine)
		{
			base.GMAHNPNHMFK().GNFNHDCJOFC("history", (PhotonTargets)8, new object[0]);
		}
	}

	// Token: 0x0600BFF7 RID: 49143 RVA: 0x0045D5F9 File Offset: 0x0045B7F9
	internal void BOACAPEAOPM(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("Fade");
		this.OMIAIKLABKM();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600BFF8 RID: 49144 RVA: 0x0045D61C File Offset: 0x0045B81C
	internal void LEMHJPBAPEG()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 711.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BFF9 RID: 49145 RVA: 0x0045D668 File Offset: 0x0045B868
	internal void PGJJJJIPOIC()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1607.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600BFFA RID: 49146 RVA: 0x0045D6B4 File Offset: 0x0045B8B4
	public void BKKOLPAFIMG(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.AAMNKPHHHCI();
			string lblkdnnpaco = "_TimeX";
			PhotonTargets mpnmoonbmii = (PhotonTargets)8;
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600BFFB RID: 49147 RVA: 0x0045D6E4 File Offset: 0x0045B8E4
	public void OAGDLBBJIDO(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.BGJKMGJBPFA())
		{
			this.Pickup();
		}
	}

	// Token: 0x0600BFFC RID: 49148 RVA: 0x0045D720 File Offset: 0x0045B920
	internal void ABHKELHLNAN()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 663.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600BFFD RID: 49149 RVA: 0x0045D76C File Offset: 0x0045B96C
	public void OIDHIONJPJJ(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			base.GMAHNPNHMFK().PBMFBOOALKA("_Value6", PhotonTargets.MasterClient, new object[]
			{
				ENENGMDFKHK
			});
		}
	}

	// Token: 0x0600BFFE RID: 49150 RVA: 0x0045D79C File Offset: 0x0045B99C
	internal void OAOIJGBDKAL(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 1242.0;
		if (DPMFFBEDNNN > 401f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke(" AuthMode ", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600BFFF RID: 49151 RVA: 0x0045D7F8 File Offset: 0x0045B9F8
	public void COHGAEMDFEI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN() && this.SecondsBeforeRespawn <= 1833f)
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600C000 RID: 49152 RVA: 0x0045D85D File Offset: 0x0045BA5D
	public void LJLLLFOAJDB()
	{
		if (this.PickupIsMine)
		{
			base.EDIJKHEMPAD().IKIJDNPJKPM("settings.disablestoryboard", PhotonTargets.AllViaServer, new object[0]);
		}
	}

	// Token: 0x0600C001 RID: 49153 RVA: 0x0045D884 File Offset: 0x0045BA84
	public void FBFALABOJHF(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.isMine)
		{
			this.PODMNNAFPCC();
		}
	}

	// Token: 0x0600C002 RID: 49154 RVA: 0x0045D8C0 File Offset: 0x0045BAC0
	public void HBBLLHAOBLE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ() && this.SecondsBeforeRespawn <= 1250f)
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600C003 RID: 49155 RVA: 0x0045D925 File Offset: 0x0045BB25
	public int EENIOALHGGL()
	{
		return base.GMAHNPNHMFK().KINIHBOKFJH();
	}

	// Token: 0x0600C004 RID: 49156 RVA: 0x0045D934 File Offset: 0x0045BB34
	internal void FDDMFDFLDOD()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1325.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C005 RID: 49157 RVA: 0x0045D980 File Offset: 0x0045BB80
	public void NMPLLMFCILA(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[1] = "_Distortion";
			array[0] = base.gameObject;
			array[2] = "CameraFilterPack/Blend2Camera_Hue";
			array[2] = this.SecondsBeforeRespawn;
			array[5] = "_Value";
			array[6] = this.TimeOfRespawn;
			array[0] = "_Value4";
			array[2] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("sounds/hit_wrong", this);
		}
		if (this.SecondsBeforeRespawn <= 1488f)
		{
			this.OAOIJGBDKAL(1413f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.AMGFGPMEMCG();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 384.0)
			{
				this.PIMDACECPMA((float)num2);
			}
		}
	}

	// Token: 0x0600C006 RID: 49158 RVA: 0x0045DAA4 File Offset: 0x0045BCA4
	internal void PHLGBHBGCNC(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 595.0;
		if (DPMFFBEDNNN > 1690f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("offsets", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600C007 RID: 49159 RVA: 0x0045DB00 File Offset: 0x0045BD00
	internal void LLFOEKCLLGA()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 171.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C008 RID: 49160 RVA: 0x0045DB4C File Offset: 0x0045BD4C
	public void LENGHMGDJMK(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.DOLKFPIABDD())
		{
			this.GHKMNMLNOLM();
		}
	}

	// Token: 0x0600C009 RID: 49161 RVA: 0x0045DB88 File Offset: 0x0045BD88
	internal void KPJPJAKNGKK()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 998.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C00A RID: 49162 RVA: 0x0045DBD4 File Offset: 0x0045BDD4
	public void FGDHFOECMDH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[5];
			array[0] = ".status";
			array[0] = base.gameObject;
			array[5] = "settings.enablehitsoundsinrelax";
			array[8] = this.SecondsBeforeRespawn;
			array[2] = "_ToneCurve";
			array[2] = this.TimeOfRespawn;
			array[0] = " not exist";
			array[7] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("_Value", this);
		}
		if (this.SecondsBeforeRespawn <= 1829f)
		{
			this.CKBNBEPJOEE(40f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.IDIKAMCFMKA();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 1486.0)
			{
				this.APAPAJBEAII((float)num2);
			}
		}
	}

	// Token: 0x0600C00B RID: 49163 RVA: 0x0045DCF7 File Offset: 0x0045BEF7
	public void IMAMGDIKKKE(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			base.EOOCGIFFKBG().GNFNHDCJOFC("Turn", (PhotonTargets)7, new object[]
			{
				ENENGMDFKHK
			});
		}
	}

	// Token: 0x0600C00C RID: 49164 RVA: 0x0045DD24 File Offset: 0x0045BF24
	public void ADJPLCCJDLK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[0] = "\" that takes ";
			array[1] = base.gameObject;
			array[1] = "ServerSettings: ";
			array[6] = this.SecondsBeforeRespawn;
			array[2] = "MenuScene";
			array[5] = this.TimeOfRespawn;
			array[6] = "_Size";
			array[8] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("A", this);
		}
		if (this.SecondsBeforeRespawn <= 81f)
		{
			this.IDIJNCBLDBH(478f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.MBLGLJKHMGJ();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 105.0)
			{
				this.GMMLFEEGIGI((float)num2);
			}
		}
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x0600C00D RID: 49165 RVA: 0x0045DE47 File Offset: 0x0045C047
	public int ViewID
	{
		get
		{
			return base.photonView.viewID;
		}
	}

	// Token: 0x0600C00E RID: 49166 RVA: 0x0045DE54 File Offset: 0x0045C054
	public void AKAHFHCMGEJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[8];
			array[1] = "Unable to get a reward! Try again?";
			array[1] = base.gameObject;
			array[8] = "UI Extensions/UIAdditive";
			array[7] = this.SecondsBeforeRespawn;
			array[6] = "#close";
			array[1] = this.TimeOfRespawn;
			array[5] = "CameraFilterPack/Blend2Camera_Divide";
			array[3] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage(". ActorNr: ", this);
		}
		if (this.SecondsBeforeRespawn <= 874f)
		{
			this.EHNKFNNOLIK(766f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.LLINIHLINLF();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 890.0)
			{
				this.GMMLFEEGIGI((float)num2);
			}
		}
	}

	// Token: 0x0600C00F RID: 49167 RVA: 0x0045DF77 File Offset: 0x0045C177
	[PunRPC]
	internal void PunRespawn(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("PunRespawn with Position.");
		this.PunRespawn();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600C010 RID: 49168 RVA: 0x0045DF9C File Offset: 0x0045C19C
	internal void JJEJCCPCNOP(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 1369.0;
		if (DPMFFBEDNNN > 170f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("set id", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600C011 RID: 49169 RVA: 0x0045DFF5 File Offset: 0x0045C1F5
	public void GFDCFGHODJB()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.JAEJDHHCJJO().MIAHMDGOOPJ(":", PhotonTargets.OthersBuffered, new object[1]);
	}

	// Token: 0x0600C012 RID: 49170 RVA: 0x0045E021 File Offset: 0x0045C221
	public int EALIJNCNNKC()
	{
		return base.GMAHNPNHMFK().EIMHMIJGMHG();
	}

	// Token: 0x0600C013 RID: 49171 RVA: 0x0045E030 File Offset: 0x0045C230
	public void BFAMLJLHFJN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.isMine)
		{
			this.OCPHFBJHNMM();
		}
	}

	// Token: 0x0600C014 RID: 49172 RVA: 0x0045E06C File Offset: 0x0045C26C
	public void PIBOKINJJDJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && this.SecondsBeforeRespawn <= 293f)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600C015 RID: 49173 RVA: 0x0045E0D1 File Offset: 0x0045C2D1
	internal void IKHMFPMBEMJ(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("Error0");
		this.GOHOOCEHHHB();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600C016 RID: 49174 RVA: 0x0045E0F4 File Offset: 0x0045C2F4
	public void PIGEEBCJDEG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && this.SecondsBeforeRespawn <= 389f)
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600C017 RID: 49175 RVA: 0x0045E159 File Offset: 0x0045C359
	public void MFOMKJDLDAM(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.ACPGHFHDCIP();
			string lblkdnnpaco = "_MainTex2";
			PhotonTargets mpnmoonbmii = PhotonTargets.All;
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600C018 RID: 49176 RVA: 0x0045E188 File Offset: 0x0045C388
	internal void JHBEIDMONOI()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1102.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C019 RID: 49177 RVA: 0x0045E1D4 File Offset: 0x0045C3D4
	public void OAMFGNKCDJE(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.BGJKMGJBPFA())
		{
			this.PODMNNAFPCC();
		}
	}

	// Token: 0x0600C01A RID: 49178 RVA: 0x0045E210 File Offset: 0x0045C410
	public void DCNNAEFJCNK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[3];
			array[1] = "CameraFilterPack/TV_BrokenGlass2";
			array[1] = base.gameObject;
			array[3] = "player.greenlollipop";
			array[5] = this.SecondsBeforeRespawn;
			array[3] = "true";
			array[5] = this.TimeOfRespawn;
			array[3] = "CameraFilterPack/Vision_Rainbow";
			array[6] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("Other", this);
		}
		if (this.SecondsBeforeRespawn <= 550f)
		{
			this.EHNKFNNOLIK(1611f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.KCECPOJOIPC();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 1872.0)
			{
				this.EHNKFNNOLIK((float)num2);
			}
		}
	}

	// Token: 0x0600C01B RID: 49179 RVA: 0x0045E333 File Offset: 0x0045C533
	public void KLFPBMHEBCL()
	{
		if (this.PickupIsMine)
		{
			base.FFIPLLNKGEN().MIAHMDGOOPJ("maps.", PhotonTargets.AllBufferedViaServer, new object[1]);
		}
	}

	// Token: 0x0600C01C RID: 49180 RVA: 0x0045E357 File Offset: 0x0045C557
	public void OGPBENNLBCC()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.GBMJAPGLMGB().MIAHMDGOOPJ("skin.hit_normal", (PhotonTargets)7, new object[1]);
	}

	// Token: 0x0600C01D RID: 49181 RVA: 0x0045E383 File Offset: 0x0045C583
	internal void DFJENGLLLBE(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("sfxVolume");
		this.MFDANMNLGMK();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600C01E RID: 49182 RVA: 0x0045E3A6 File Offset: 0x0045C5A6
	public void HODPGNGKANI(Vector3 ENENGMDFKHK)
	{
		if (this.PickupIsMine)
		{
			PhotonView photonView = base.BLMHOKPIMOD();
			string lblkdnnpaco = "MascotChallenge2019";
			PhotonTargets mpnmoonbmii = PhotonTargets.All;
			object[] array = new object[0];
			array[0] = ENENGMDFKHK;
			photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
		}
	}

	// Token: 0x0600C01F RID: 49183 RVA: 0x0045E3D4 File Offset: 0x0045C5D4
	public void LJEPIJMPBHH(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.BGJKMGJBPFA())
		{
			this.JGACDFLHGKF();
		}
	}

	// Token: 0x0600C020 RID: 49184 RVA: 0x0045E410 File Offset: 0x0045C610
	public void LKECONBPBGN(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnTrigger && component != null && component.isMine)
		{
			this.BMCDOLNMNDN();
		}
	}

	// Token: 0x0600C021 RID: 49185 RVA: 0x0045E44C File Offset: 0x0045C64C
	public void KFNJJDIAJDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting && this.SecondsBeforeRespawn <= 1616f)
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.gameObject.transform.position);
		}
		else
		{
			Vector3 position = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			base.gameObject.transform.position = position;
		}
	}

	// Token: 0x0600C022 RID: 49186 RVA: 0x0045E4B4 File Offset: 0x0045C6B4
	public void FEFIONGBKIJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = false;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[5];
			array[0] = "Overlay";
			array[0] = base.gameObject;
			array[8] = "settings_bindings_controller_type";
			array[5] = this.SecondsBeforeRespawn;
			array[0] = "_ScreenResolution";
			array[3] = this.TimeOfRespawn;
			array[4] = "settings.shaders.bloomintencity";
			array[1] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("_Value", this);
		}
		if (this.SecondsBeforeRespawn <= 710f)
		{
			this.HBPMLCNJHIL(1470f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 400.0)
			{
				this.CKBNBEPJOEE((float)num2);
			}
		}
	}

	// Token: 0x0600C023 RID: 49187 RVA: 0x0045E5D8 File Offset: 0x0045C7D8
	public void IKDOFOAOFFJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender.IsLocal)
		{
			this.SentPickup = true;
		}
		if (!base.gameObject.GetActive())
		{
			object[] array = new object[7];
			array[1] = "Hidden/DepthOfField/MedianFilter";
			array[0] = base.gameObject;
			array[4] = "#newhighscore";
			array[2] = this.SecondsBeforeRespawn;
			array[5] = "_History4LumaTex";
			array[4] = this.TimeOfRespawn;
			array[6] = "OpenButton";
			array[5] = (this.TimeOfRespawn > PhotonNetwork.time);
			Debug.Log(string.Concat(array));
			return;
		}
		this.PickupIsMine = PDBKGCDNLNG.sender.IsLocal;
		if (this.OnPickedUpCall != null)
		{
			this.OnPickedUpCall.SendMessage("Set Satellite Emission", this);
		}
		if (this.SecondsBeforeRespawn <= 576f)
		{
			this.PIMDACECPMA(1973f);
		}
		else
		{
			double num = PhotonNetwork.time - PDBKGCDNLNG.KBICNLABBMP();
			double num2 = (double)this.SecondsBeforeRespawn - num;
			if (num2 > 306.0)
			{
				this.CKBNBEPJOEE((float)num2);
			}
		}
	}

	// Token: 0x0600C024 RID: 49188 RVA: 0x0045E6FB File Offset: 0x0045C8FB
	public void OHBLOLAFMLL()
	{
		if (this.PickupIsMine)
		{
			base.ACPGHFHDCIP().RPC("_Value4", (PhotonTargets)7, new object[1]);
		}
	}

	// Token: 0x0600C025 RID: 49189 RVA: 0x0045E720 File Offset: 0x0045C920
	internal void GANGFBPADGO(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 327.0;
		if (DPMFFBEDNNN > 48f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("Tab2Content", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600C026 RID: 49190 RVA: 0x0045E77C File Offset: 0x0045C97C
	internal void AMCALMOAOMP()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 471.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C027 RID: 49191 RVA: 0x0045E7C8 File Offset: 0x0045C9C8
	internal void EFADICPMHAN(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("BitsData");
		this.JHBEIDMONOI();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600C028 RID: 49192 RVA: 0x0045E7EC File Offset: 0x0045C9EC
	internal void NEHMOHADDIM()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1109.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600C029 RID: 49193 RVA: 0x0045E838 File Offset: 0x0045CA38
	internal void OHPFGOOJJKD()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 146.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C02A RID: 49194 RVA: 0x0045E884 File Offset: 0x0045CA84
	internal void EHNKFNNOLIK(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(true);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 1596.0;
		if (DPMFFBEDNNN > 210f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("_PosY", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600C02B RID: 49195 RVA: 0x0045E8E0 File Offset: 0x0045CAE0
	internal void IDIJNCBLDBH(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 973.0;
		if (DPMFFBEDNNN > 1941f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("a", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600C02C RID: 49196 RVA: 0x0045E93C File Offset: 0x0045CB3C
	internal void DEGJEDLKKJK()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 111.0;
		this.PickupIsMine = false;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C02E RID: 49198 RVA: 0x0045E994 File Offset: 0x0045CB94
	internal void HBPMLCNJHIL(float DPMFFBEDNNN)
	{
		base.gameObject.SetActive(false);
		PickupItem.DisabledPickupItems.Add(this);
		this.TimeOfRespawn = 1335.0;
		if (DPMFFBEDNNN > 1734f)
		{
			this.TimeOfRespawn = PhotonNetwork.time + (double)DPMFFBEDNNN;
			base.Invoke("/", DPMFFBEDNNN);
		}
	}

	// Token: 0x0600C02F RID: 49199 RVA: 0x0045E9F0 File Offset: 0x0045CBF0
	internal void GOHOOCEHHHB()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 1287.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C030 RID: 49200 RVA: 0x0045EA3C File Offset: 0x0045CC3C
	internal void KMCNCLKFLKF(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("ScoreText");
		this.FDDMFDFLDOD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600C031 RID: 49201 RVA: 0x0045EA5F File Offset: 0x0045CC5F
	internal void FHLBHMIHIDE(Vector3 HMDKPLLDBEA)
	{
		Debug.Log("id");
		this.FDDMFDFLDOD();
		base.gameObject.transform.position = HMDKPLLDBEA;
	}

	// Token: 0x0600C032 RID: 49202 RVA: 0x0045EA82 File Offset: 0x0045CC82
	public void OCPHFBJHNMM()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.EOOCGIFFKBG().IKIJDNPJKPM("settings.arcsdestroydelay", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600C033 RID: 49203 RVA: 0x0045EAB0 File Offset: 0x0045CCB0
	internal void GDANOGMCNEF()
	{
		PickupItem.DisabledPickupItems.Remove(this);
		this.TimeOfRespawn = 786.0;
		this.PickupIsMine = true;
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04001664 RID: 5732
	public float SecondsBeforeRespawn = 2f;

	// Token: 0x04001665 RID: 5733
	public bool PickupOnTrigger;

	// Token: 0x04001666 RID: 5734
	public bool PickupIsMine;

	// Token: 0x04001667 RID: 5735
	public UnityEngine.MonoBehaviour OnPickedUpCall;

	// Token: 0x04001668 RID: 5736
	public bool SentPickup;

	// Token: 0x04001669 RID: 5737
	public double TimeOfRespawn;

	// Token: 0x0400166A RID: 5738
	public static HashSet<PickupItem> DisabledPickupItems = new HashSet<PickupItem>();
}
