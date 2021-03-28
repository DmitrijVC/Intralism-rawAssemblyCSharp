using System;
using UnityEngine;

// Token: 0x02000347 RID: 839
[RequireComponent(typeof(PhotonView))]
public class ManualPhotonViewAllocator : MonoBehaviour
{
	// Token: 0x0600BD59 RID: 48473 RVA: 0x0044D7C4 File Offset: 0x0044B9C4
	public void FELIMAHNPME()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_TimeX");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);";
		PhotonTargets mpnmoonbmii = (PhotonTargets)7;
		object[] array = new object[0];
		array[0] = num;
		photonView2.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD5A RID: 48474 RVA: 0x0044D818 File Offset: 0x0044BA18
	public void KIEKDKCDOOI(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(829f, 1863f, 951f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD5B RID: 48475 RVA: 0x0044D870 File Offset: 0x0044BA70
	public void BALABNBJNAM()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_Value");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "{0:0} second{1}";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
		object[] array = new object[0];
		array[0] = num;
		photonView2.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD5C RID: 48476 RVA: 0x0044D8C4 File Offset: 0x0044BAC4
	public void ENPINIGKJCA()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("DPADHOR");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "{0:x2}";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBuffered;
		object[] array = new object[0];
		array[0] = num;
		photonView2.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD5D RID: 48477 RVA: 0x0044D918 File Offset: 0x0044BB18
	public void AllocateManualPhotonView()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Can't do manual instantiation without PhotonView component.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.RPC("InstantiateRpc", PhotonTargets.AllBuffered, new object[]
		{
			num
		});
	}

	// Token: 0x0600BD5E RID: 48478 RVA: 0x0044D96C File Offset: 0x0044BB6C
	public void OEOBFBIKNNB(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(726f, 190f, 1085f), Quaternion.identity);
		gameObject.GetPhotonView().CHLIDEOBECE(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD5F RID: 48479 RVA: 0x0044D9C4 File Offset: 0x0044BBC4
	public void OJADEOOANDA(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(903f, 496f, 124f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD60 RID: 48480 RVA: 0x0044DA1C File Offset: 0x0044BC1C
	public void ODLLHGPEIEN()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("/theme");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = " not exist";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBuffered;
		object[] array = new object[0];
		array[0] = num;
		photonView2.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD61 RID: 48481 RVA: 0x0044DA70 File Offset: 0x0044BC70
	public void CCFIGBIAOKJ(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(518f, 656f, 762f), Quaternion.identity);
		gameObject.GetPhotonView().CHLIDEOBECE(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD62 RID: 48482 RVA: 0x0044DAC8 File Offset: 0x0044BCC8
	public void LEOMJGLFAIJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "SpawnObj";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
		object[] array = new object[1];
		array[1] = num;
		photonView2.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD63 RID: 48483 RVA: 0x0044DB1C File Offset: 0x0044BD1C
	public void GAOCIFNKIMN()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("LevelEditor/icons");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "music";
		PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
		object[] array = new object[1];
		array[1] = num;
		photonView2.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD64 RID: 48484 RVA: 0x0044DB70 File Offset: 0x0044BD70
	public void MFDEGAAIMOD()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("LoadPlayerSkin");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "_Value3";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[0];
		array[1] = num;
		photonView2.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD65 RID: 48485 RVA: 0x0044DBC4 File Offset: 0x0044BDC4
	public void PPBNIGECGIF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Start");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "_TimeX";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[1] = num;
		photonView2.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD66 RID: 48486 RVA: 0x0044DC18 File Offset: 0x0044BE18
	public void FIKAPCKGFBF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("[Right]");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = " scene view IDs from last level.";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[0];
		array[1] = num;
		photonView2.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD67 RID: 48487 RVA: 0x0044DC6C File Offset: 0x0044BE6C
	public void JOAJGAFKGJB(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(1404f, 610f, 1025f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x0600BD68 RID: 48488 RVA: 0x0044DCC4 File Offset: 0x0044BEC4
	public void EFDEFLCEOBA(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(571f, 1288f, 282f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x0600BD69 RID: 48489 RVA: 0x0044DD1C File Offset: 0x0044BF1C
	public void PANCEPGLHOK()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("ItemNameBGImage");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = ".lastCheckpoint.playerdistance";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[0] = num;
		photonView2.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD6A RID: 48490 RVA: 0x0044DD70 File Offset: 0x0044BF70
	public void HCGEFLJKFEB()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "settings.arcsnohitsoundtimedelay";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[0];
		array[0] = num;
		photonView2.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD6B RID: 48491 RVA: 0x0044DDC4 File Offset: 0x0044BFC4
	public void PBOJOOJBBAG()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("[LocalizationService] Localization: ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "_Value4";
		PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
		object[] array = new object[0];
		array[0] = num;
		photonView2.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD6C RID: 48492 RVA: 0x0044DE18 File Offset: 0x0044C018
	public void OECHDJJKJPJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("NO");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.KEKKFNNMLMG("{", PhotonTargets.MasterClient, new object[]
		{
			num
		});
	}

	// Token: 0x0600BD6D RID: 48493 RVA: 0x0044DE6C File Offset: 0x0044C06C
	public void DNPDKDOCCMN(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(1888f, 1346f, 1499f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x0600BD6E RID: 48494 RVA: 0x0044DEC4 File Offset: 0x0044C0C4
	public void CGIHDPNNDKJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_MainTex2");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "Set particles start speed";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[0] = num;
		photonView2.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD6F RID: 48495 RVA: 0x0044DF18 File Offset: 0x0044C118
	public void GAGFNPBLOID(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(247f, 109f, 1024f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x0600BD70 RID: 48496 RVA: 0x0044DF70 File Offset: 0x0044C170
	public void NENBEPHNIGJ()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("_Distortion");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.KEKKFNNMLMG(".lastCheckpoint.isMapCompleted", (PhotonTargets)8, new object[]
		{
			num
		});
	}

	// Token: 0x0600BD71 RID: 48497 RVA: 0x0044DFC4 File Offset: 0x0044C1C4
	public void DKGIABDLAPF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("\nv.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.RPC("Failed to Instantiate prefab: ", PhotonTargets.Others, new object[]
		{
			num
		});
	}

	// Token: 0x0600BD72 RID: 48498 RVA: 0x0044E018 File Offset: 0x0044C218
	public void AHINONNHLKK(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(448f, 0f, 1911f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD74 RID: 48500 RVA: 0x0044E070 File Offset: 0x0044C270
	public void PIHJPHOGAHM()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("</i>");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = " - GameWebCallback] - ";
		PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
		object[] array = new object[0];
		array[1] = num;
		photonView2.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD75 RID: 48501 RVA: 0x0044E0C4 File Offset: 0x0044C2C4
	public void FKNNOELEIAP(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(1393f, 1079f, 61f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD76 RID: 48502 RVA: 0x0044E11C File Offset: 0x0044C31C
	public void MLCCJFMOJOC()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("HiddenToggle");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "_Value2";
		PhotonTargets mpnmoonbmii = (PhotonTargets)7;
		object[] array = new object[0];
		array[1] = num;
		photonView2.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD77 RID: 48503 RVA: 0x0044E170 File Offset: 0x0044C370
	public void NJEPKEAEPBC(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(1006f, 285f, 1464f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x0600BD78 RID: 48504 RVA: 0x0044E1C8 File Offset: 0x0044C3C8
	public void MIMECNMKDNF()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("SetSunEmission");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.KEKKFNNMLMG(" from: ", PhotonTargets.All, new object[]
		{
			num
		});
	}

	// Token: 0x0600BD79 RID: 48505 RVA: 0x0044E21C File Offset: 0x0044C41C
	public void NNLKLBLKOHC(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(1219f, 989f, 1329f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x0600BD7A RID: 48506 RVA: 0x0044E274 File Offset: 0x0044C474
	public void OEFDPMAOHHP()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("GlassAberration");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		PhotonView photonView2 = photonView;
		string lblkdnnpaco = "CameraFilterPack/TV_WideScreenHorizontal";
		PhotonTargets mpnmoonbmii = (PhotonTargets)8;
		object[] array = new object[0];
		array[0] = num;
		photonView2.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BD7B RID: 48507 RVA: 0x0044E2C8 File Offset: 0x0044C4C8
	public void JBIEHBLKALE(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(1090f, 1687f, 1565f), Quaternion.identity);
		gameObject.GetPhotonView().HANOCKILFNJ(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x0600BD7C RID: 48508 RVA: 0x0044E320 File Offset: 0x0044C520
	public void OEPJDLNAGBK(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(909f, 232f, 1938f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD7D RID: 48509 RVA: 0x0044E378 File Offset: 0x0044C578
	public void CCFKAEGHEJO()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("Error: Can not set the OnSerialize rate higher than the overall SendRate.");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.PBMFBOOALKA("UseScanLine", PhotonTargets.OthersBuffered, new object[]
		{
			num
		});
	}

	// Token: 0x0600BD7E RID: 48510 RVA: 0x0044E3CC File Offset: 0x0044C5CC
	public void OFEEDOGFNLA(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(701f, 1515f, 751f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD7F RID: 48511 RVA: 0x0044E424 File Offset: 0x0044C624
	[PunRPC]
	public void InstantiateRpc(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(0f, 5f, 0f), Quaternion.identity);
		gameObject.GetPhotonView().viewID = NADLIACHBNO;
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = true;
	}

	// Token: 0x0600BD80 RID: 48512 RVA: 0x0044E47C File Offset: 0x0044C67C
	public void KFGEMGKGBDA()
	{
		PhotonView photonView = base.gameObject.GetPhotonView();
		if (photonView == null)
		{
			Debug.LogError("CheckResources () for ");
			return;
		}
		int num = PhotonNetwork.AllocateViewID();
		photonView.IKIJDNPJKPM("LevelConfigButton", PhotonTargets.AllBufferedViaServer, new object[]
		{
			num
		});
	}

	// Token: 0x0600BD81 RID: 48513 RVA: 0x0044E4D0 File Offset: 0x0044C6D0
	public void PLKIEFBPPDJ(int NADLIACHBNO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.Prefab, InputToEvent.inputHitPos + new Vector3(1078f, 513f, 961f), Quaternion.identity);
		gameObject.GetPhotonView().CHLIDEOBECE(NADLIACHBNO);
		OnClickDestroy component = gameObject.GetComponent<OnClickDestroy>();
		component.DestroyByRpc = false;
	}

	// Token: 0x04001641 RID: 5697
	public GameObject Prefab;
}
