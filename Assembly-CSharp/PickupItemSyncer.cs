using System;
using System.Collections.Generic;
using Photon;
using UnityEngine;

// Token: 0x02000355 RID: 853
[RequireComponent(typeof(PhotonView))]
public class PickupItemSyncer : Photon.MonoBehaviour
{
	// Token: 0x0600C05D RID: 49245 RVA: 0x0045F74A File Offset: 0x0045D94A
	public void DJGAIEJMHEE(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.OICIJCNKHCI(PDBKGCDNLNG);
	}

	// Token: 0x0600C05E RID: 49246 RVA: 0x0045F754 File Offset: 0x0045D954
	public void NKOMKHEMAAL()
	{
		object[] array = new object[]
		{
			null,
			"Left"
		};
		array[0] = PhotonNetwork.isMasterClient;
		array[2] = "R1";
		array[7] = PhotonNetwork.player.ONIKFABKELO();
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 4)
		{
			base.Invoke("ConfigVersionSlider", 630f);
		}
	}

	// Token: 0x0600C05F RID: 49247 RVA: 0x0045F7CB File Offset: 0x0045D9CB
	public void ECAAJFBNNCN(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.AOEIIPJAHAJ(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C060 RID: 49248 RVA: 0x0045F7DE File Offset: 0x0045D9DE
	public void CPDLFJPOFJG(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.FECLHODFCAM(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C061 RID: 49249 RVA: 0x0045F7F4 File Offset: 0x0045D9F4
	public void EAABKPJPPHL()
	{
		object[] array = new object[3];
		array[1] = "colorC";
		array[1] = PhotonNetwork.isMasterClient;
		array[6] = "CameraFilterPack/BlurTiltShift_Hole";
		array[8] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 4)
		{
			base.Invoke(".lastCheckpoint.time", 1011f);
		}
	}

	// Token: 0x0600C062 RID: 49250 RVA: 0x0045F86B File Offset: 0x0045DA6B
	public void DCCKANLLCHN(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.PJIMAPMICKB(PDBKGCDNLNG);
	}

	// Token: 0x0600C063 RID: 49251 RVA: 0x0045F874 File Offset: 0x0045DA74
	public void NKOEJIBDFLF(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 2; i += 0)
		{
			int num = i * 0;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.BONCCOJCGAF(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1502f)
			{
				component.HBPMLCNJHIL(1184f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[8];
				array[0] = photonView.viewID;
				array[1] = "UseFinalGlassColor";
				array[4] = num3;
				array[1] = "AudioSampler";
				array[2] = num2;
				array[6] = "Triangle";
				array[1] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 662f)
				{
					num4 = 510.0;
				}
				component.JJEJCCPCNOP((float)num4);
			}
		}
	}

	// Token: 0x0600C064 RID: 49252 RVA: 0x0045F963 File Offset: 0x0045DB63
	public void LHNLOLAJGJL(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.KPOJJLEBCMO(PDBKGCDNLNG);
	}

	// Token: 0x0600C065 RID: 49253 RVA: 0x0045F96C File Offset: 0x0045DB6C
	public void KOABFEFLPDN(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("cameramovements:");
			return;
		}
		this.PGFCEMJCOHL(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C066 RID: 49254 RVA: 0x0045F994 File Offset: 0x0045DB94
	public void DOKKBCMLGEH()
	{
		object[] array = new object[6];
		array[1] = "_ExtraColor";
		array[1] = PhotonNetwork.isMasterClient;
		array[7] = "???";
		array[5] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 7)
		{
			base.Invoke("%", 1007f);
		}
	}

	// Token: 0x0600C067 RID: 49255 RVA: 0x0045FA0C File Offset: 0x0045DC0C
	private void KKOANIFHMKB(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("CONTRAST");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1977.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1335f)
			{
				list.Add((float)pickupItem.EENIOALHGGL());
				list.Add(1507f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[2];
					array2[0] = pickupItem.BIDKPFPPLDP();
					array2[0] = "CameraFilterPack/FX_8bits_gb";
					array2[2] = pickupItem.TimeOfRespawn;
					array2[7] = "Object ID. Case-Sensitive";
					array2[1] = num2;
					array2[4] = "Set Satellite Input";
					array2[2] = PhotonNetwork.time;
					array2[8] = "_MainTex2";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.DNEBJBBNLDD());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[7];
		array3[0] = " - Contains ";
		array3[0] = list.Count;
		array3[6] = "CameraFilterPack/Glasses_On";
		array3[2] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.IBKCMBIGOEJ();
		string lblkdnnpaco = "_Gain";
		object[] array4 = new object[0];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.DPLELHEFMBE(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C068 RID: 49256 RVA: 0x0045FBAC File Offset: 0x0045DDAC
	private void AHEOHDPHICL(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_PositionX");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1659.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int i = 1; i < array.Length; i++)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1893f)
			{
				list.Add((float)pickupItem.EIKELGOOEAN());
				list.Add(501f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[]
					{
						null,
						pickupItem.BIDKPFPPLDP()
					};
					array2[1] = "_Value2";
					array2[2] = pickupItem.TimeOfRespawn;
					array2[3] = "[PlayerController] ";
					array2[8] = num2;
					array2[5] = "The given 2D texture ";
					array2[4] = PhotonNetwork.time;
					array2[7] = "<not connected>";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.BIDKPFPPLDP());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[1];
		array3[1] = "_Visualize";
		array3[0] = list.Count;
		array3[2] = "...";
		array3[7] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.AAMNKPHHHCI();
		string lblkdnnpaco = "n/a";
		object[] array4 = new object[0];
		array4[0] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		photonView.RPC(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C069 RID: 49257 RVA: 0x0045FD4B File Offset: 0x0045DF4B
	public void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.PHOKFNAJMAN(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C06A RID: 49258 RVA: 0x0045FD5E File Offset: 0x0045DF5E
	public void KHEJPFLGFNO(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.NJCPMBLPFCD(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C06B RID: 49259 RVA: 0x0045FD74 File Offset: 0x0045DF74
	public void OnJoinedRoom()
	{
		Debug.Log(string.Concat(new object[]
		{
			"Joined Room. isMasterClient: ",
			PhotonNetwork.isMasterClient,
			" id: ",
			PhotonNetwork.player.ID
		}));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 2)
		{
			base.Invoke("AskForPickupItemSpawnTimes", 2f);
		}
	}

	// Token: 0x0600C06C RID: 49260 RVA: 0x0045FDEB File Offset: 0x0045DFEB
	public void JNJIDKJMPLL(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.PEBNLLBAJFK(PDBKGCDNLNG);
	}

	// Token: 0x0600C06D RID: 49261 RVA: 0x0045FDF4 File Offset: 0x0045DFF4
	public void FLEEJJMGILL()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 2)
			{
				Debug.Log("UseScanLine");
				this.IsWaitingForPickupInit = false;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.DGCJCPLOCNK();
			if (photonPlayer == null || photonPlayer.HJBPPALONKE(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.FCCKKEDLOHA();
			}
			if (photonPlayer != null && !photonPlayer.Equals(PhotonNetwork.player))
			{
				base.GBMJAPGLMGB().KACECEKIPPP("Can't set MaxPlayers when not in that room.", photonPlayer, new object[0]);
			}
			else
			{
				Debug.Log("PLEASE WAIT");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C06E RID: 49262 RVA: 0x0045FE9C File Offset: 0x0045E09C
	public void DKKJFBKKCJD(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 2; i++)
		{
			int num = i * 3;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.JCDPMMJDLOP(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 461f)
			{
				component.KNABLPOBADA(220f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[2];
				array[0] = photonView.KINIHBOKFJH();
				array[0] = "MenuScene";
				array[5] = num3;
				array[3] = "CameraFilterPack/3D_Myst";
				array[3] = num2;
				array[5] = "#ok";
				array[4] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 428f)
				{
					num4 = 1638.0;
				}
				component.IDIJNCBLDBH((float)num4);
			}
		}
	}

	// Token: 0x0600C06F RID: 49263 RVA: 0x0045FF8B File Offset: 0x0045E18B
	public void PLGFJOKBOPA(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("\n");
			return;
		}
		this.DNFJIFDLGMK(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C070 RID: 49264 RVA: 0x0045FFB1 File Offset: 0x0045E1B1
	public void MMNDOMMPMMB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("shader.sunny");
			return;
		}
		this.BKAAGPHGGNL(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C071 RID: 49265 RVA: 0x0045FFD7 File Offset: 0x0045E1D7
	public void KPOJJLEBCMO(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("isVisible");
			return;
		}
		this.CCDJMKJDJGC(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C072 RID: 49266 RVA: 0x0045FFFD File Offset: 0x0045E1FD
	public void DLLKGGFLEBF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("settings.shaders.bloomintencity");
			return;
		}
		this.NJCPMBLPFCD(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C073 RID: 49267 RVA: 0x0045F86B File Offset: 0x0045DA6B
	public void LPPOMKEGHHL(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.PJIMAPMICKB(PDBKGCDNLNG);
	}

	// Token: 0x0600C074 RID: 49268 RVA: 0x00460024 File Offset: 0x0045E224
	private void HILOGFPNNHK(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("settings_bindings_controller_type");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 55.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 6);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1866f)
			{
				list.Add((float)pickupItem.PKLGNLOHIHG());
				list.Add(1752f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[]
					{
						null,
						pickupItem.PKLGNLOHIHG()
					};
					array2[0] = "Curve texture";
					array2[6] = pickupItem.TimeOfRespawn;
					array2[7] = "LoadingStatusText";
					array2[6] = num2;
					array2[8] = "_TimeX";
					array2[3] = PhotonNetwork.time;
					array2[2] = "EndlessLoopsScoreText";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.ViewID);
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[3];
		array3[1] = "init";
		array3[0] = list.Count;
		array3[0] = "settings.enableranking";
		array3[8] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.JAEJDHHCJJO();
		string lblkdnnpaco = "BitsData";
		object[] array4 = new object[]
		{
			PhotonNetwork.time
		};
		array4[0] = list.ToArray();
		photonView.OILIKMGIHFL(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C075 RID: 49269 RVA: 0x004601C4 File Offset: 0x0045E3C4
	public void MNBOLIEAACD(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 5; i += 0)
		{
			int num = i * 7;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.CPHCOHILOAA(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1391f)
			{
				component.PPNPJENOMGA(1361f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[8];
				array[1] = photonView.viewID;
				array[1] = "stretchWidth";
				array[2] = num3;
				array[3] = "MenuScene";
				array[0] = num2;
				array[4] = " beatThreshold: ";
				array[7] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 1970f)
				{
					num4 = 1484.0;
				}
				component.KNABLPOBADA((float)num4);
			}
		}
	}

	// Token: 0x0600C076 RID: 49270 RVA: 0x004602B4 File Offset: 0x0045E4B4
	private void PHOKFNAJMAN(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("Cant send PickupItem spawn times to unknown targetPlayer.");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 0.20000000298023224;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 2);
		foreach (PickupItem pickupItem in array)
		{
			if (pickupItem.SecondsBeforeRespawn <= 0f)
			{
				list.Add((float)pickupItem.ViewID);
				list.Add(0f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					Debug.Log(string.Concat(new object[]
					{
						pickupItem.ViewID,
						" respawn: ",
						pickupItem.TimeOfRespawn,
						" timeUntilRespawn: ",
						num2,
						" (now: ",
						PhotonNetwork.time,
						")"
					}));
					list.Add((float)pickupItem.ViewID);
					list.Add((float)num2);
				}
			}
		}
		Debug.Log(string.Concat(new object[]
		{
			"Sent count: ",
			list.Count,
			" now: ",
			time
		}));
		base.photonView.RPC("PickupItemInit", MJCDIJOAEPI, new object[]
		{
			PhotonNetwork.time,
			list.ToArray()
		});
	}

	// Token: 0x0600C077 RID: 49271 RVA: 0x00460454 File Offset: 0x0045E654
	public void BHELIGNHBCB()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 1)
			{
				Debug.Log("_Size");
				this.IsWaitingForPickupInit = false;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.DGCJCPLOCNK();
			if (photonPlayer == null || photonPlayer.LDGCKCJIMGF(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.HNCFIGNCLPO();
			}
			if (photonPlayer != null && !photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				base.photonView.OKHNMAMFDFD("_FarCamera", photonPlayer, new object[1]);
			}
			else
			{
				Debug.Log("Data");
				this.IsWaitingForPickupInit = true;
			}
		}
	}

	// Token: 0x0600C078 RID: 49272 RVA: 0x004604FA File Offset: 0x0045E6FA
	public void DIGNPJMKODB(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.KKOANIFHMKB(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C079 RID: 49273 RVA: 0x0046050D File Offset: 0x0045E70D
	public void MPAMPGMCNGA(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("float,1.5");
			return;
		}
		this.NJCPMBLPFCD(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C07A RID: 49274 RVA: 0x00460533 File Offset: 0x0045E733
	public void LCNJFMGHPMH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("_FgOverlap");
			return;
		}
		this.DNFJIFDLGMK(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C07B RID: 49275 RVA: 0x0046055C File Offset: 0x0045E75C
	public void IPCNPOIFNDC()
	{
		Debug.Log(string.Concat(new object[]
		{
			"Set satellite MinVertexDistance - how much distance should be between to points of the trail line",
			PhotonNetwork.isMasterClient,
			"_Value3",
			PhotonNetwork.player.ONIKFABKELO()
		}));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 2)
		{
			base.Invoke("BadgeImage", 1013f);
		}
	}

	// Token: 0x0600C07C RID: 49276 RVA: 0x004605D4 File Offset: 0x0045E7D4
	public void FEOKPMGLJEJ()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 6)
			{
				Debug.Log("_BgFade");
				this.IsWaitingForPickupInit = false;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.FCCKKEDLOHA();
			if (photonPlayer == null || photonPlayer.Equals(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.HNCFIGNCLPO();
			}
			if (photonPlayer != null && !photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				base.AAMNKPHHHCI().RPC("_ScreenResolution", photonPlayer, new object[1]);
			}
			else
			{
				Debug.Log("_Value2");
				this.IsWaitingForPickupInit = true;
			}
		}
	}

	// Token: 0x0600C07D RID: 49277 RVA: 0x0045FDEB File Offset: 0x0045DFEB
	public void NPHOABHFFOG(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.PEBNLLBAJFK(PDBKGCDNLNG);
	}

	// Token: 0x0600C07E RID: 49278 RVA: 0x0046067C File Offset: 0x0045E87C
	public void AIPGHEMJLIO()
	{
		object[] array = new object[0];
		array[0] = "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n";
		array[1] = PhotonNetwork.isMasterClient;
		array[7] = "CameraFilterPack/Blend2Camera_Blend";
		array[4] = PhotonNetwork.player.ONIKFABKELO();
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 1)
		{
			base.Invoke("_FixDistance", 575f);
		}
	}

	// Token: 0x0600C07F RID: 49279 RVA: 0x004606F4 File Offset: 0x0045E8F4
	private void JDOOMFNIDID(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("SetParticlesEmission");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1901.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 5);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 77f)
			{
				list.Add((float)pickupItem.ViewID);
				list.Add(1252f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[8];
					array2[0] = pickupItem.EENIOALHGGL();
					array2[1] = "_MainTex2";
					array2[8] = pickupItem.TimeOfRespawn;
					array2[6] = "CameraFilterPack/Colors_Adjust_ColorRGB";
					array2[5] = num2;
					array2[3] = "DPADHOR";
					array2[0] = PhotonNetwork.time;
					array2[6] = "#onfirstranktext";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EALIJNCNNKC());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[]
		{
			null,
			"#ok"
		};
		array3[1] = list.Count;
		array3[5] = "%";
		array3[6] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.GBHNDHLAJLI();
		string lblkdnnpaco = "finished";
		object[] array4 = new object[8];
		array4[1] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		photonView.DPLELHEFMBE(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C080 RID: 49280 RVA: 0x00460894 File Offset: 0x0045EA94
	public void NBEEEMEODBE()
	{
		object[] array = new object[6];
		array[1] = "ViewMenu";
		array[1] = PhotonNetwork.isMasterClient;
		array[0] = "VisionBlur";
		array[7] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 6)
		{
			base.Invoke("[Up]", 425f);
		}
	}

	// Token: 0x0600C081 RID: 49281 RVA: 0x0046090C File Offset: 0x0045EB0C
	public void ECIOFPMELCL()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 4)
			{
				Debug.Log("_Value");
				this.IsWaitingForPickupInit = true;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.HNCFIGNCLPO();
			if (photonPlayer == null || photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.FCCKKEDLOHA();
			}
			if (photonPlayer != null && !photonPlayer.Equals(PhotonNetwork.player))
			{
				base.GMAHNPNHMFK().RPC("selColor", photonPlayer, new object[1]);
			}
			else
			{
				Debug.Log("_Value3");
				this.IsWaitingForPickupInit = true;
			}
		}
	}

	// Token: 0x0600C082 RID: 49282 RVA: 0x004609B2 File Offset: 0x0045EBB2
	public void NGAOAFGLLJI(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("LoadingStatusText");
			return;
		}
		this.MJINJLIKIPN(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C083 RID: 49283 RVA: 0x004609D8 File Offset: 0x0045EBD8
	public void EIFOLKNOCAI()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 4)
			{
				Debug.Log("inventory.selected.");
				this.IsWaitingForPickupInit = true;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.HNCFIGNCLPO();
			if (photonPlayer == null || photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.GetNext();
			}
			if (photonPlayer != null && !photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				base.JAEJDHHCJJO().OKHNMAMFDFD("IncorrectHitsScoreText", photonPlayer, new object[1]);
			}
			else
			{
				Debug.Log("_Value1");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C084 RID: 49284 RVA: 0x00460A7E File Offset: 0x0045EC7E
	public void JHJGKDLGEHI(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.MPAMPGMCNGA(PDBKGCDNLNG);
	}

	// Token: 0x0600C085 RID: 49285 RVA: 0x00460A88 File Offset: 0x0045EC88
	private void DMHMGIBMIDA(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_ScreenResolution");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 57.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 5);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 171f)
			{
				list.Add((float)pickupItem.KHEHPCAFJBC());
				list.Add(1447f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[4];
					array2[0] = pickupItem.ViewID;
					array2[1] = "Fade";
					array2[5] = pickupItem.TimeOfRespawn;
					array2[1] = "_TimeX";
					array2[5] = num2;
					array2[7] = "StartButton";
					array2[8] = PhotonNetwork.time;
					array2[6] = "_Screen";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.FEOKOFDBLGL());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[3];
		array3[1] = "Tab1Content";
		array3[1] = list.Count;
		array3[4] = "1087340967";
		array3[8] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.GMAHNPNHMFK();
		string lblkdnnpaco = "In Network lobby";
		object[] array4 = new object[7];
		array4[0] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.RPC(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C086 RID: 49286 RVA: 0x00460C28 File Offset: 0x0045EE28
	public void LCFDLOHECMM()
	{
		object[] array = new object[8];
		array[0] = ".completed";
		array[1] = PhotonNetwork.isMasterClient;
		array[5] = "Ignored PU RPC, cause item is inactive. ";
		array[1] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 6)
		{
			base.Invoke("/", 935f);
		}
	}

	// Token: 0x0600C087 RID: 49287 RVA: 0x00460CA0 File Offset: 0x0045EEA0
	public void AskForPickupItemSpawnTimes()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 2)
			{
				Debug.Log("Cant ask anyone else for PickupItem spawn times.");
				this.IsWaitingForPickupInit = false;
				return;
			}
			PhotonPlayer next = PhotonNetwork.masterClient.GetNext();
			if (next == null || next.Equals(PhotonNetwork.player))
			{
				next = PhotonNetwork.player.GetNext();
			}
			if (next != null && !next.Equals(PhotonNetwork.player))
			{
				base.photonView.RPC("RequestForPickupItems", next, new object[0]);
			}
			else
			{
				Debug.Log("No player left to ask");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C088 RID: 49288 RVA: 0x00460D48 File Offset: 0x0045EF48
	private void EDCLINPDMDF(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_InternalLutParams");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 443.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 5);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 150f)
			{
				list.Add((float)pickupItem.KHEHPCAFJBC());
				list.Add(1993f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[4];
					array2[1] = pickupItem.EIKELGOOEAN();
					array2[0] = "GlassColor";
					array2[0] = pickupItem.TimeOfRespawn;
					array2[8] = "ns";
					array2[4] = num2;
					array2[0] = ".completed";
					array2[6] = PhotonNetwork.time;
					array2[4] = "_Value13";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EENIOALHGGL());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[2];
		array3[0] = "_ScreenResolution";
		array3[1] = list.Count;
		array3[4] = "error";
		array3[3] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.GBHNDHLAJLI();
		string lblkdnnpaco = "value";
		object[] array4 = new object[4];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.DPLELHEFMBE(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C089 RID: 49289 RVA: 0x00460EE8 File Offset: 0x0045F0E8
	public void AFGMHKGMCCE()
	{
		object[] array = new object[6];
		array[1] = "float,0";
		array[1] = PhotonNetwork.isMasterClient;
		array[1] = "_TimeX";
		array[6] = PhotonNetwork.player.ONIKFABKELO();
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 7)
		{
			base.Invoke("_TimeX", 647f);
		}
	}

	// Token: 0x0600C08A RID: 49290 RVA: 0x00460F5F File Offset: 0x0045F15F
	public void HBJOHJIKOHD(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.MMNDOMMPMMB(PDBKGCDNLNG);
	}

	// Token: 0x0600C08B RID: 49291 RVA: 0x00460F68 File Offset: 0x0045F168
	private void PACMHBNJGID(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("[PlayerController] ");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 178.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 0);
		foreach (PickupItem pickupItem in array)
		{
			if (pickupItem.SecondsBeforeRespawn <= 552f)
			{
				list.Add((float)pickupItem.FEOKOFDBLGL());
				list.Add(123f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[1];
					array2[1] = pickupItem.EENIOALHGGL();
					array2[0] = "Clears all text from the debug console";
					array2[1] = pickupItem.TimeOfRespawn;
					array2[0] = "Received RPC \"";
					array2[1] = num2;
					array2[1] = ").png";
					array2[2] = PhotonNetwork.time;
					array2[6] = "_TimeX";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EENIOALHGGL());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[1];
		array3[0] = "LoadMapCanvas";
		array3[1] = list.Count;
		array3[7] = " ";
		array3[5] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.ACPGHFHDCIP();
		string lblkdnnpaco = "Spawn new environment sprite (image) and sets its id";
		object[] array4 = new object[]
		{
			null,
			PhotonNetwork.time
		};
		array4[0] = list.ToArray();
		photonView.DPLELHEFMBE(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C08C RID: 49292 RVA: 0x00461108 File Offset: 0x0045F308
	private void DNFJIFDLGMK(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("settings.enableranking");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1631.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 0);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1330f)
			{
				list.Add((float)pickupItem.FKFHMBGPFHF());
				list.Add(595f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[1];
					array2[1] = pickupItem.KHEHPCAFJBC();
					array2[0] = "ItemNameText";
					array2[6] = pickupItem.TimeOfRespawn;
					array2[5] = ". Client should be in a room. Current connectionStateDetailed: ";
					array2[4] = num2;
					array2[6] = "GlassAberration";
					array2[7] = PhotonNetwork.time;
					array2[3] = "_MainTex2";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.FEOKOFDBLGL());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[]
		{
			null,
			"Failed to Instantiate prefab: "
		};
		array3[0] = list.Count;
		array3[7] = "Texture2";
		array3[4] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.photonView;
		string lblkdnnpaco = "Data/Editor/leveltemplate";
		object[] array4 = new object[5];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.OKHNMAMFDFD(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C08D RID: 49293 RVA: 0x004612A8 File Offset: 0x0045F4A8
	public void GKHBAIPDPOL()
	{
		object[] array = new object[6];
		array[1] = "[Right]";
		array[0] = PhotonNetwork.isMasterClient;
		array[3] = "_Value";
		array[2] = PhotonNetwork.player.ONIKFABKELO();
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 4)
		{
			base.Invoke("settings.enablehitsoundsinnormal", 80f);
		}
	}

	// Token: 0x0600C08E RID: 49294 RVA: 0x00461320 File Offset: 0x0045F520
	public void GKJPODELLPH(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 1; i < NMMDICHIDNC.Length / 1; i += 0)
		{
			int num = i * 0;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.FNNLDKMFBEB(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1236f)
			{
				component.HBPMLCNJHIL(1806f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[]
				{
					photonView.NPPEFODKHKN(),
					"inventory.selected."
				};
				array[1] = num3;
				array[7] = "CameraFilterPack/Retro_Loading";
				array[7] = num2;
				array[5] = "Square";
				array[0] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 1584f)
				{
					num4 = 1999.0;
				}
				component.PPNPJENOMGA((float)num4);
			}
		}
	}

	// Token: 0x0600C08F RID: 49295 RVA: 0x00461410 File Offset: 0x0045F610
	public void NNGCFPIDMLD()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 2)
			{
				Debug.Log(". Client should be in a room. Current connectionStateDetailed: ");
				this.IsWaitingForPickupInit = false;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.HNCFIGNCLPO();
			if (photonPlayer == null || photonPlayer.HJBPPALONKE(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.FCCKKEDLOHA();
			}
			if (photonPlayer != null && !photonPlayer.Equals(PhotonNetwork.player))
			{
				base.EOOCGIFFKBG().KACECEKIPPP("PossibleMapPointsText", photonPlayer, new object[1]);
			}
			else
			{
				Debug.Log("_TimeX");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C090 RID: 49296 RVA: 0x004614B6 File Offset: 0x0045F6B6
	public void PJIMAPMICKB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("/Assets/MyImage");
			return;
		}
		this.PACMHBNJGID(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C091 RID: 49297 RVA: 0x004614DC File Offset: 0x0045F6DC
	private void NJCPMBLPFCD(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("SetEnvSpriteColor");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 898.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 4);
		for (int i = 1; i < array.Length; i++)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 828f)
			{
				list.Add((float)pickupItem.PKLGNLOHIHG());
				list.Add(1559f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[]
					{
						pickupItem.FEOKOFDBLGL(),
						"Xbox Home"
					};
					array2[1] = pickupItem.TimeOfRespawn;
					array2[5] = "_History1ChromaTex";
					array2[8] = num2;
					array2[3] = "bloomintencity:";
					array2[4] = PhotonNetwork.time;
					array2[3] = "_ColorRGB";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EALIJNCNNKC());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[0];
		array3[1] = "CameraFilterPack/TV_WideScreenCircle";
		array3[1] = list.Count;
		array3[1] = "inventory.selected.";
		array3[2] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.IBKCMBIGOEJ();
		string lblkdnnpaco = "[PlayerController] ";
		object[] array4 = new object[7];
		array4[1] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		photonView.KACECEKIPPP(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C093 RID: 49299 RVA: 0x0045F963 File Offset: 0x0045DB63
	public void GMMFLFIPAHB(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.KPOJJLEBCMO(PDBKGCDNLNG);
	}

	// Token: 0x0600C094 RID: 49300 RVA: 0x0045F7DE File Offset: 0x0045D9DE
	public void PPGAINMKPCN(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.FECLHODFCAM(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C095 RID: 49301 RVA: 0x0046167B File Offset: 0x0045F87B
	public void JNHPFMKIBMO(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.HILOGFPNNHK(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C096 RID: 49302 RVA: 0x00461690 File Offset: 0x0045F890
	[PunRPC]
	public void PickupItemInit(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 2; i++)
		{
			int num = i * 2;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.Find(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 0f)
			{
				component.KNABLPOBADA(0f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				Debug.Log(string.Concat(new object[]
				{
					photonView.viewID,
					" respawn: ",
					num3,
					" timeUntilRespawnBasedOnTimeBase:",
					num2,
					" SecondsBeforeRespawn: ",
					component.SecondsBeforeRespawn
				}));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 0f)
				{
					num4 = 0.0;
				}
				component.KNABLPOBADA((float)num4);
			}
		}
	}

	// Token: 0x0600C097 RID: 49303 RVA: 0x00461780 File Offset: 0x0045F980
	public void BLHKMLGLCHJ(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 4; i += 0)
		{
			int num = i * 8;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.FNNLDKMFBEB(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 503f)
			{
				component.KNABLPOBADA(1193f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[7];
				array[1] = photonView.KINIHBOKFJH();
				array[1] = "1234332714";
				array[6] = num3;
				array[2] = ";";
				array[5] = num2;
				array[4] = "CameraFilterPack/FX_EarthQuake";
				array[7] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 999f)
				{
					num4 = 684.0;
				}
				component.IDIJNCBLDBH((float)num4);
			}
		}
	}

	// Token: 0x0600C098 RID: 49304 RVA: 0x0046186F File Offset: 0x0045FA6F
	[Obsolete("Use RequestForPickupItems(PhotonMessageInfo msgInfo) with corrected typing instead.")]
	[PunRPC]
	public void RequestForPickupTimes(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.RequestForPickupItems(PDBKGCDNLNG);
	}

	// Token: 0x0600C099 RID: 49305 RVA: 0x00461878 File Offset: 0x0045FA78
	public void OBFLLMLKMKB(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = true;
		for (int i = 0; i < NMMDICHIDNC.Length / 0; i++)
		{
			int num = i * 5;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.PMLJACJKPLN(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1158f)
			{
				component.GANGFBPADGO(758f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[3];
				array[1] = photonView.EIMHMIJGMHG();
				array[1] = "GLITCH";
				array[6] = num3;
				array[5] = "_BlurPass";
				array[6] = num2;
				array[1] = "DPADHOR";
				array[8] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 1819f)
				{
					num4 = 1976.0;
				}
				component.GMMLFEEGIGI((float)num4);
			}
		}
	}

	// Token: 0x0600C09A RID: 49306 RVA: 0x00461968 File Offset: 0x0045FB68
	public void MBCCOOKJLGH(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = true;
		for (int i = 1; i < NMMDICHIDNC.Length / 7; i++)
		{
			int num = i * 7;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.PMLJACJKPLN(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1333f)
			{
				component.PIMDACECPMA(186f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[0];
				array[1] = photonView.viewID;
				array[1] = "There are too many cells created by your subdivision options. Maximum allowed number of cells is ";
				array[1] = num3;
				array[4] = "ENABLE_COLOR_GRADING";
				array[8] = num2;
				array[4] = "Set sun min/max size";
				array[0] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 168f)
				{
					num4 = 1744.0;
				}
				component.EHNKFNNOLIK((float)num4);
			}
		}
	}

	// Token: 0x0600C09B RID: 49307 RVA: 0x00461A58 File Offset: 0x0045FC58
	private void PGFCEMJCOHL(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("System.String");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1211.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 4);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1331f)
			{
				list.Add((float)pickupItem.KHEHPCAFJBC());
				list.Add(1362f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[8];
					array2[1] = pickupItem.EALIJNCNNKC();
					array2[1] = "_NoisePerChannel";
					array2[5] = pickupItem.TimeOfRespawn;
					array2[4] = "Data/Skins/";
					array2[5] = num2;
					array2[6] = "SetSatelliteTrailLength";
					array2[2] = PhotonNetwork.time;
					array2[3] = "#lives";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EALIJNCNNKC());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[5];
		array3[1] = "_Value7";
		array3[0] = list.Count;
		array3[6] = "]";
		array3[5] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.ACPGHFHDCIP();
		string lblkdnnpaco = "L2";
		object[] array4 = new object[7];
		array4[0] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.KACECEKIPPP(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C09C RID: 49308 RVA: 0x00461BF7 File Offset: 0x0045FDF7
	public void FLBDPCACCOK(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.EDCLINPDMDF(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C09D RID: 49309 RVA: 0x00461C0A File Offset: 0x0045FE0A
	public void HAFNFEJKGEF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("_TimeX");
			return;
		}
		this.BKAAGPHGGNL(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C09E RID: 49310 RVA: 0x00461C30 File Offset: 0x0045FE30
	public void OICIJCNKHCI(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("Subscribe: ");
			return;
		}
		this.PGEEHKHMMCG(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C09F RID: 49311 RVA: 0x00461C58 File Offset: 0x0045FE58
	public void FMIHGOACEKK()
	{
		object[] array = new object[4];
		array[0] = "SetEnvSpriteImage";
		array[0] = PhotonNetwork.isMasterClient;
		array[8] = "#ok";
		array[4] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 4)
		{
			base.Invoke("ClearEnvironment", 1191f);
		}
	}

	// Token: 0x0600C0A0 RID: 49312 RVA: 0x00461CD0 File Offset: 0x0045FED0
	public void JFNBAEAJKOH()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 4)
			{
				Debug.Log("offsets");
				this.IsWaitingForPickupInit = true;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GetNext();
			if (photonPlayer == null || photonPlayer.Equals(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.HNCFIGNCLPO();
			}
			if (photonPlayer != null && !photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				base.photonView.OILIKMGIHFL("IconFileSelector", photonPlayer, new object[1]);
			}
			else
			{
				Debug.Log("Encryption wasn't established: ");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C0A1 RID: 49313 RVA: 0x00461D78 File Offset: 0x0045FF78
	private void PPGKMKFFGJE(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_ScreenResolution");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1704.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 2);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 633f)
			{
				list.Add((float)pickupItem.FEOKOFDBLGL());
				list.Add(1649f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[3];
					array2[0] = pickupItem.EENIOALHGGL();
					array2[1] = "_Value3";
					array2[0] = pickupItem.TimeOfRespawn;
					array2[1] = "#accuracy";
					array2[5] = num2;
					array2[2] = "[MapEditor] Item creation successful! Published Item ID: ";
					array2[7] = PhotonNetwork.time;
					array2[7] = " - {0}";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.FKFHMBGPFHF());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[1];
		array3[1] = "_TimeX";
		array3[1] = list.Count;
		array3[1] = "event";
		array3[1] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.CIACEFBNDDJ();
		string lblkdnnpaco = "cancel";
		object[] array4 = new object[7];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.RPC(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0A2 RID: 49314 RVA: 0x00461F17 File Offset: 0x00460117
	public void FJCADPOONBF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("y");
			return;
		}
		this.DMHMGIBMIDA(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C0A3 RID: 49315 RVA: 0x00461F40 File Offset: 0x00460140
	public void DBMDJHMBMGH()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 8)
			{
				Debug.Log("Please define the RectTransform for the Center viewport of the scrollable area");
				this.IsWaitingForPickupInit = false;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.DGCJCPLOCNK();
			if (photonPlayer == null || photonPlayer.Equals(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.DGCJCPLOCNK();
			}
			if (photonPlayer != null && !photonPlayer.Equals(PhotonNetwork.player))
			{
				base.OELHGNKAMEG().KACECEKIPPP("tolobby", photonPlayer, new object[1]);
			}
			else
			{
				Debug.Log("FrostCanvas");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C0A4 RID: 49316 RVA: 0x00461FE8 File Offset: 0x004601E8
	public void NKFLPHKKPJH(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = true;
		for (int i = 1; i < NMMDICHIDNC.Length / 3; i++)
		{
			int num = i * 0;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.CPHCOHILOAA(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 489f)
			{
				component.OPHALGOIDOI(1067f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[0];
				array[1] = photonView.EIMHMIJGMHG();
				array[0] = ".lastCheckpoint.incorrectScore";
				array[3] = num3;
				array[0] = " Also make sure to disable sprite packing for this sprite.";
				array[1] = num2;
				array[6] = "_MainTex2";
				array[7] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 855f)
				{
					num4 = 1546.0;
				}
				component.OAOIJGBDKAL((float)num4);
			}
		}
	}

	// Token: 0x0600C0A5 RID: 49317 RVA: 0x004620D7 File Offset: 0x004602D7
	public void GHNBCKLCLCD(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.LCNJFMGHPMH(PDBKGCDNLNG);
	}

	// Token: 0x0600C0A6 RID: 49318 RVA: 0x004620E0 File Offset: 0x004602E0
	public void POALNDIIBGI()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 1)
			{
				Debug.Log("(\\[ *h1 *\\])");
				this.IsWaitingForPickupInit = true;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GetNext();
			if (photonPlayer == null || photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.DGCJCPLOCNK();
			}
			if (photonPlayer != null && !photonPlayer.HJBPPALONKE(PhotonNetwork.player))
			{
				base.photonView.OKHNMAMFDFD("\t", photonPlayer, new object[0]);
			}
			else
			{
				Debug.Log("_Value5");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C0A7 RID: 49319 RVA: 0x00462186 File Offset: 0x00460386
	public void PEBNLLBAJFK(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("_Circle");
			return;
		}
		this.PHOKFNAJMAN(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C0A8 RID: 49320 RVA: 0x004621AC File Offset: 0x004603AC
	public void CAAJFPJAOCJ(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 6; i += 0)
		{
			int num = i * 5;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.FNNLDKMFBEB(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 592f)
			{
				component.PIMDACECPMA(67f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[4];
				array[1] = photonView.NPPEFODKHKN();
				array[0] = "menu.selectedlevelid";
				array[7] = num3;
				array[8] = "[Up-Right-Left]";
				array[1] = num2;
				array[3] = "_Value";
				array[3] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 1144f)
				{
					num4 = 1367.0;
				}
				component.PIMDACECPMA((float)num4);
			}
		}
	}

	// Token: 0x0600C0A9 RID: 49321 RVA: 0x0046229C File Offset: 0x0046049C
	public void IOIMNDEOLGO(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 8; i += 0)
		{
			int num = i * 5;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.IOENOELDJOF(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1184f)
			{
				component.OAOIJGBDKAL(1379f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[4];
				array[0] = photonView.KINIHBOKFJH();
				array[0] = "SetSunLerpSpeed";
				array[2] = num3;
				array[2] = "Reload Maps";
				array[7] = num2;
				array[2] = "_ScreenResolution";
				array[0] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 1406f)
				{
					num4 = 1900.0;
				}
				component.JJEJCCPCNOP((float)num4);
			}
		}
	}

	// Token: 0x0600C0AA RID: 49322 RVA: 0x0046238B File Offset: 0x0046058B
	public void KLMPHNPKILJ(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.PACMHBNJGID(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C0AB RID: 49323 RVA: 0x004623A0 File Offset: 0x004605A0
	public void OGOKEFNPBMC()
	{
		object[] array = new object[0];
		array[1] = "_ScreenResolution";
		array[0] = PhotonNetwork.isMasterClient;
		array[4] = "_Value";
		array[7] = PhotonNetwork.player.ONIKFABKELO();
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 8)
		{
			base.Invoke("GlassDistortion", 1102f);
		}
	}

	// Token: 0x0600C0AC RID: 49324 RVA: 0x00462418 File Offset: 0x00460618
	private void CCDJMKJDJGC(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1249.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 6);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1014f)
			{
				list.Add((float)pickupItem.FKFHMBGPFHF());
				list.Add(107f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[1];
					array2[1] = pickupItem.FKFHMBGPFHF();
					array2[1] = "_PositionY";
					array2[0] = pickupItem.TimeOfRespawn;
					array2[2] = "z";
					array2[3] = num2;
					array2[6] = "Cant ask anyone else for PickupItem spawn times.";
					array2[3] = PhotonNetwork.time;
					array2[1] = "_ScreenResolution";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EALIJNCNNKC());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[6];
		array3[0] = "Set Satellite Sensitivity";
		array3[1] = list.Count;
		array3[3] = "GroupNameText";
		array3[7] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.AAMNKPHHHCI();
		string lblkdnnpaco = "player.orangelifering";
		object[] array4 = new object[7];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.DPLELHEFMBE(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0AD RID: 49325 RVA: 0x004625B7 File Offset: 0x004607B7
	public void EMHBADAIGCA(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.FJCADPOONBF(PDBKGCDNLNG);
	}

	// Token: 0x0600C0AE RID: 49326 RVA: 0x004625C0 File Offset: 0x004607C0
	private void BKAAGPHGGNL(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("bans.viewed.");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1115.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1516f)
			{
				list.Add((float)pickupItem.EALIJNCNNKC());
				list.Add(1243f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[3];
					array2[1] = pickupItem.EALIJNCNNKC();
					array2[1] = "_Sat";
					array2[5] = pickupItem.TimeOfRespawn;
					array2[8] = "/../";
					array2[0] = num2;
					array2[0] = "_Value2";
					array2[6] = PhotonNetwork.time;
					array2[5] = "Destroy all spawned environment objects";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EENIOALHGGL());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[]
		{
			"_Bloom",
			list.Count,
			null,
			null,
			null,
			null,
			null,
			"PunRespawn"
		};
		array3[2] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.IBKCMBIGOEJ();
		string lblkdnnpaco = "_BlurCoe";
		object[] array4 = new object[0];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.DPLELHEFMBE(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0AF RID: 49327 RVA: 0x0046275F File Offset: 0x0046095F
	public void FOKOCCEODFM(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.PGEEHKHMMCG(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C0B0 RID: 49328 RVA: 0x00462774 File Offset: 0x00460974
	public void CCKDNDCIBEP(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 4; i++)
		{
			int num = i * 6;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.BONCCOJCGAF(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1020f)
			{
				component.OAOIJGBDKAL(1073f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[6];
				array[1] = photonView.viewID;
				array[1] = "\"";
				array[2] = num3;
				array[2] = "_ScreenResolution";
				array[1] = num2;
				array[4] = "#random #epic #item";
				array[8] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 687f)
				{
					num4 = 103.0;
				}
				component.GMMLFEEGIGI((float)num4);
			}
		}
	}

	// Token: 0x0600C0B1 RID: 49329 RVA: 0x00462863 File Offset: 0x00460A63
	public void MBHDKCNNMJD(PhotonMessageInfo PDBKGCDNLNG)
	{
		this.NGAOAFGLLJI(PDBKGCDNLNG);
	}

	// Token: 0x0600C0B2 RID: 49330 RVA: 0x0046286C File Offset: 0x00460A6C
	public void PPEKHBDJDKC()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 6)
			{
				Debug.Log("#md5submitionfailed: ");
				this.IsWaitingForPickupInit = true;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.HNCFIGNCLPO();
			if (photonPlayer == null || photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.DGCJCPLOCNK();
			}
			if (photonPlayer != null && !photonPlayer.HJBPPALONKE(PhotonNetwork.player))
			{
				base.GBHNDHLAJLI().DPLELHEFMBE("Set particless emission (glow)", photonPlayer, new object[0]);
			}
			else
			{
				Debug.Log("event");
				this.IsWaitingForPickupInit = false;
			}
		}
	}

	// Token: 0x0600C0B3 RID: 49331 RVA: 0x00462914 File Offset: 0x00460B14
	private void FDOPCLKFMOH(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_Value");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1341.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 5);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1262f)
			{
				list.Add((float)pickupItem.EENIOALHGGL());
				list.Add(206f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[6];
					array2[0] = pickupItem.ViewID;
					array2[1] = "workshop.";
					array2[8] = pickupItem.TimeOfRespawn;
					array2[5] = "_Value3";
					array2[7] = num2;
					array2[5] = "GlassAberration";
					array2[6] = PhotonNetwork.time;
					array2[4] = "&map=";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.DHBFALLCHCG());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[2];
		array3[0] = "<command>";
		array3[0] = list.Count;
		array3[6] = "_TimeX";
		array3[6] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.photonView;
		string lblkdnnpaco = "%]</b> ";
		object[] array4 = new object[]
		{
			null,
			PhotonNetwork.time
		};
		array4[1] = list.ToArray();
		photonView.RPC(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0B4 RID: 49332 RVA: 0x00462AB4 File Offset: 0x00460CB4
	public void ACLKLBGNBBN()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 5)
			{
				Debug.Log("EditMenu");
				this.IsWaitingForPickupInit = true;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.GetNext();
			if (photonPlayer == null || photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.DGCJCPLOCNK();
			}
			if (photonPlayer != null && !photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				base.AAMNKPHHHCI().PLMAEOHKJPN("InfoText", photonPlayer, new object[0]);
			}
			else
			{
				Debug.Log("_Value");
				this.IsWaitingForPickupInit = true;
			}
		}
	}

	// Token: 0x0600C0B5 RID: 49333 RVA: 0x00462B5C File Offset: 0x00460D5C
	public void PBJIMOILOLE()
	{
		object[] array = new object[7];
		array[0] = "GlassColor";
		array[0] = PhotonNetwork.isMasterClient;
		array[1] = "_TimeX";
		array[8] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 5)
		{
			base.Invoke("curScn", 1536f);
		}
	}

	// Token: 0x0600C0B6 RID: 49334 RVA: 0x00462BD3 File Offset: 0x00460DD3
	[PunRPC]
	public void RequestForPickupItems(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("Unknown player asked for PickupItems");
			return;
		}
		this.PHOKFNAJMAN(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C0B7 RID: 49335 RVA: 0x00462BFC File Offset: 0x00460DFC
	public void HHCNFNHEBIF()
	{
		object[] array = new object[3];
		array[1] = "_ExposureAdjustment";
		array[1] = PhotonNetwork.isMasterClient;
		array[3] = "_Distortion";
		array[1] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 0)
		{
			base.Invoke("Joystick1Button4", 206f);
		}
	}

	// Token: 0x0600C0B8 RID: 49336 RVA: 0x00462C74 File Offset: 0x00460E74
	public void GMKMLFAIIAJ()
	{
		object[] array = new object[2];
		array[0] = "win";
		array[1] = PhotonNetwork.isMasterClient;
		array[8] = "_Near";
		array[2] = PhotonNetwork.player.ONIKFABKELO();
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 1)
		{
			base.Invoke("Keypad", 386f);
		}
	}

	// Token: 0x0600C0B9 RID: 49337 RVA: 0x00462CEB File Offset: 0x00460EEB
	public void CMCMLLICMJB(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.MJINJLIKIPN(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C0BA RID: 49338 RVA: 0x00462D00 File Offset: 0x00460F00
	public void FMPICHEDPFF(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = true;
		for (int i = 1; i < NMMDICHIDNC.Length / 0; i += 0)
		{
			int num = i * 6;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.Find(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 884f)
			{
				component.APAPAJBEAII(663f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[]
				{
					photonView.EIMHMIJGMHG()
				};
				array[0] = "_ScreenResolution";
				array[2] = num3;
				array[6] = "itemdefid[0]";
				array[3] = num2;
				array[4] = "Load Game";
				array[0] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 1077f)
				{
					num4 = 783.0;
				}
				component.OAOIJGBDKAL((float)num4);
			}
		}
	}

	// Token: 0x0600C0BB RID: 49339 RVA: 0x00462DF0 File Offset: 0x00460FF0
	public void GKKNIJLJABC()
	{
		object[] array = new object[1];
		array[1] = "_TimeX";
		array[0] = PhotonNetwork.isMasterClient;
		array[7] = "_ScreenResolution";
		array[6] = PhotonNetwork.player.ID;
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 5)
		{
			base.Invoke("RateButton", 1608f);
		}
	}

	// Token: 0x0600C0BC RID: 49340 RVA: 0x00462E67 File Offset: 0x00461067
	public void GJOFHFOCGAB(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.BKAAGPHGGNL(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C0BD RID: 49341 RVA: 0x0046238B File Offset: 0x0046058B
	public void LCNKFALHCOD(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.PACMHBNJGID(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C0BE RID: 49342 RVA: 0x00462E7C File Offset: 0x0046107C
	private void AOEIIPJAHAJ(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("_Value");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1771.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int i = 1; i < array.Length; i++)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 601f)
			{
				list.Add((float)pickupItem.FEOKOFDBLGL());
				list.Add(368f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[6];
					array2[0] = pickupItem.EIKELGOOEAN();
					array2[1] = "Hidden/DepthOfField/BokehSplatting";
					array2[1] = pickupItem.TimeOfRespawn;
					array2[4] = "ReJoinRoom failed due to offline mode.";
					array2[6] = num2;
					array2[6] = "EventMenu";
					array2[5] = PhotonNetwork.time;
					array2[3] = "quantity";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EALIJNCNNKC());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[1];
		array3[1] = "Map: ";
		array3[1] = list.Count;
		array3[3] = "RecordButton";
		array3[1] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.GBMJAPGLMGB();
		string lblkdnnpaco = "LevelConfigButton";
		object[] array4 = new object[6];
		array4[0] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.RPC(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0BF RID: 49343 RVA: 0x0046301B File Offset: 0x0046121B
	public void FIDCAEAJBII(PhotonPlayer FKKHMGIGLKM)
	{
		if (PhotonNetwork.isMasterClient)
		{
			this.PPGKMKFFGJE(FKKHMGIGLKM);
		}
	}

	// Token: 0x0600C0C0 RID: 49344 RVA: 0x00463030 File Offset: 0x00461230
	public void LMNKJGJELAB(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 0; i++)
		{
			int num = i * 3;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.Find(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 266f)
			{
				component.PPNPJENOMGA(483f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[8];
				array[1] = photonView.NPPEFODKHKN();
				array[0] = "MapFolderInputField";
				array[3] = num3;
				array[8] = "_DepthLevel";
				array[8] = num2;
				array[6] = "Joystick1Button3";
				array[2] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 950f)
				{
					num4 = 1797.0;
				}
				component.PHLGBHBGCNC((float)num4);
			}
		}
	}

	// Token: 0x0600C0C1 RID: 49345 RVA: 0x00463120 File Offset: 0x00461320
	public void ICMDKGGMCLB(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 7; i++)
		{
			int num = i * 4;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.Find(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1504f)
			{
				component.EHNKFNNOLIK(1008f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[5];
				array[0] = photonView.NPPEFODKHKN();
				array[0] = "_Value2";
				array[6] = num3;
				array[8] = "Spawn ark to be pressed at this time";
				array[2] = num2;
				array[5] = ") error: ";
				array[5] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 1127f)
				{
					num4 = 1457.0;
				}
				component.OPHALGOIDOI((float)num4);
			}
		}
	}

	// Token: 0x0600C0C2 RID: 49346 RVA: 0x00463210 File Offset: 0x00461410
	public void GNBNAPFGIMD(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = true;
		for (int i = 1; i < NMMDICHIDNC.Length / 4; i++)
		{
			int num = i * 3;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 0];
			PhotonView photonView = PhotonView.BONCCOJCGAF(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 728f)
			{
				component.APAPAJBEAII(255f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[1];
				array[1] = photonView.viewID;
				array[1] = "_Distortion";
				array[8] = num3;
				array[3] = "#.##";
				array[6] = num2;
				array[7] = "_Value3";
				array[5] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 340f)
				{
					num4 = 850.0;
				}
				component.OLCDEGJDIBB((float)num4);
			}
		}
	}

	// Token: 0x0600C0C3 RID: 49347 RVA: 0x00463300 File Offset: 0x00461500
	private void PGEEHKHMMCG(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("maps.");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1726.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1636f)
			{
				list.Add((float)pickupItem.EENIOALHGGL());
				list.Add(1781f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[0];
					array2[1] = pickupItem.FKFHMBGPFHF();
					array2[0] = "Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ";
					array2[0] = pickupItem.TimeOfRespawn;
					array2[2] = "Share";
					array2[2] = num2;
					array2[7] = "ItemsCountText";
					array2[6] = PhotonNetwork.time;
					array2[5] = "#finished";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.FKFHMBGPFHF());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[5];
		array3[0] = "_Value4";
		array3[0] = list.Count;
		array3[3] = "ShadersToggle";
		array3[3] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.OELHGNKAMEG();
		string lblkdnnpaco = "_TimeX";
		object[] array4 = new object[8];
		array4[0] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		photonView.DPLELHEFMBE(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0C4 RID: 49348 RVA: 0x004634A0 File Offset: 0x004616A0
	public void LFBCJFJKDMO()
	{
		if (this.IsWaitingForPickupInit)
		{
			if (PhotonNetwork.playerList.Length < 4)
			{
				Debug.Log("_ScreenResolution");
				this.IsWaitingForPickupInit = false;
				return;
			}
			PhotonPlayer photonPlayer = PhotonNetwork.masterClient.FCCKKEDLOHA();
			if (photonPlayer == null || photonPlayer.Equals(PhotonNetwork.player))
			{
				photonPlayer = PhotonNetwork.player.FCCKKEDLOHA();
			}
			if (photonPlayer != null && !photonPlayer.PEALMFBGGIN(PhotonNetwork.player))
			{
				base.IBKCMBIGOEJ().RPC("#mapmustbecompletebeforesubmit", photonPlayer, new object[0]);
			}
			else
			{
				Debug.Log("/");
				this.IsWaitingForPickupInit = true;
			}
		}
	}

	// Token: 0x0600C0C5 RID: 49349 RVA: 0x00463546 File Offset: 0x00461746
	public void HGHPEPCJHPA(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (PDBKGCDNLNG.sender == null)
		{
			Debug.LogError("back");
			return;
		}
		this.PPGKMKFFGJE(PDBKGCDNLNG.sender);
	}

	// Token: 0x0600C0C6 RID: 49350 RVA: 0x0046356C File Offset: 0x0046176C
	private void MJINJLIKIPN(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("0.00");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 798.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 7);
		for (int i = 0; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 1676f)
			{
				list.Add((float)pickupItem.FKFHMBGPFHF());
				list.Add(1073f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[1];
					array2[0] = pickupItem.KHEHPCAFJBC();
					array2[1] = ".lastCheckpoint.time";
					array2[7] = pickupItem.TimeOfRespawn;
					array2[2] = "LevelInfoInputField";
					array2[2] = num2;
					array2[7] = "Fade";
					array2[6] = PhotonNetwork.time;
					array2[6] = "Hex value #RRGGBB";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.ViewID);
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[7];
		array3[1] = "CameraFilterPack/3D_Myst";
		array3[1] = list.Count;
		array3[5] = "_UserLutTex";
		array3[0] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.EDIJKHEMPAD();
		string lblkdnnpaco = "setbool";
		object[] array4 = new object[8];
		array4[1] = PhotonNetwork.time;
		array4[0] = list.ToArray();
		photonView.RPC(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0C7 RID: 49351 RVA: 0x0046370C File Offset: 0x0046190C
	public void IIMFPEICJPG(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = true;
		for (int i = 1; i < NMMDICHIDNC.Length / 7; i++)
		{
			int num = i * 0;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.JCDPMMJDLOP(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1737f)
			{
				component.PIMDACECPMA(1393f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[7];
				array[0] = photonView.viewID;
				array[0] = "_FixDistance";
				array[1] = num3;
				array[2] = " scene view IDs from last level.";
				array[0] = num2;
				array[0] = "ItemNameText";
				array[7] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 867f)
				{
					num4 = 366.0;
				}
				component.APAPAJBEAII((float)num4);
			}
		}
	}

	// Token: 0x0600C0C8 RID: 49352 RVA: 0x004637FC File Offset: 0x004619FC
	private void PIMMBDEKEGG(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning("EnableRankedNotificationsToggle");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 834.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 0);
		for (int i = 1; i < array.Length; i += 0)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 284f)
			{
				list.Add((float)pickupItem.ViewID);
				list.Add(227f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[8];
					array2[1] = pickupItem.OKNPEBGCPEA();
					array2[1] = "workshop.txt";
					array2[2] = pickupItem.TimeOfRespawn;
					array2[5] = "menutheme.idunno";
					array2[7] = num2;
					array2[6] = "GlassAberration";
					array2[6] = PhotonNetwork.time;
					array2[3] = "Tab1Content";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.EENIOALHGGL());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[6];
		array3[1] = ":</b> ";
		array3[0] = list.Count;
		array3[3] = "menu.selectedplaymode";
		array3[1] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.GBMJAPGLMGB();
		string lblkdnnpaco = "LeaderboardsButton";
		object[] array4 = new object[3];
		array4[1] = PhotonNetwork.time;
		array4[1] = list.ToArray();
		photonView.OILIKMGIHFL(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0C9 RID: 49353 RVA: 0x0046399C File Offset: 0x00461B9C
	private void FECLHODFCAM(PhotonPlayer MJCDIJOAEPI)
	{
		if (MJCDIJOAEPI == null)
		{
			Debug.LogWarning(".status");
			return;
		}
		double time = PhotonNetwork.time;
		double num = time + 1943.0;
		PickupItem[] array = new PickupItem[PickupItem.DisabledPickupItems.Count];
		PickupItem.DisabledPickupItems.CopyTo(array);
		List<float> list = new List<float>(array.Length * 5);
		for (int i = 1; i < array.Length; i++)
		{
			PickupItem pickupItem = array[i];
			if (pickupItem.SecondsBeforeRespawn <= 332f)
			{
				list.Add((float)pickupItem.EALIJNCNNKC());
				list.Add(1306f);
			}
			else
			{
				double num2 = pickupItem.TimeOfRespawn - PhotonNetwork.time;
				if (pickupItem.TimeOfRespawn > num)
				{
					object[] array2 = new object[4];
					array2[0] = pickupItem.DHBFALLCHCG();
					array2[0] = "CameraFilterPack/TV_Distorted";
					array2[0] = pickupItem.TimeOfRespawn;
					array2[8] = "GroupNameText";
					array2[5] = num2;
					array2[0] = "SetSunMaxSize";
					array2[6] = PhotonNetwork.time;
					array2[6] = "elapsed: {0:0.000}";
					Debug.Log(string.Concat(array2));
					list.Add((float)pickupItem.DHBFALLCHCG());
					list.Add((float)num2);
				}
			}
		}
		object[] array3 = new object[1];
		array3[1] = "Waiting to start";
		array3[0] = list.Count;
		array3[7] = "inventory.selected.";
		array3[0] = time;
		Debug.Log(string.Concat(array3));
		PhotonView photonView = base.JAEJDHHCJJO();
		string lblkdnnpaco = "ItemNameText";
		object[] array4 = new object[]
		{
			null,
			PhotonNetwork.time
		};
		array4[0] = list.ToArray();
		photonView.KACECEKIPPP(lblkdnnpaco, MJCDIJOAEPI, array4);
	}

	// Token: 0x0600C0CA RID: 49354 RVA: 0x00463B3C File Offset: 0x00461D3C
	public void KGHGKOIIAGM(double JAFEJOMIMOD, float[] NMMDICHIDNC)
	{
		this.IsWaitingForPickupInit = false;
		for (int i = 0; i < NMMDICHIDNC.Length / 3; i += 0)
		{
			int num = i * 7;
			int nadliachbno = (int)NMMDICHIDNC[num];
			float num2 = NMMDICHIDNC[num + 1];
			PhotonView photonView = PhotonView.IOENOELDJOF(nadliachbno);
			PickupItem component = photonView.GetComponent<PickupItem>();
			if (num2 <= 1848f)
			{
				component.IDIJNCBLDBH(1842f);
			}
			else
			{
				double num3 = (double)num2 + JAFEJOMIMOD;
				object[] array = new object[8];
				array[1] = photonView.EIMHMIJGMHG();
				array[0] = "settings.volume.editor";
				array[2] = num3;
				array[5] = "880078120";
				array[8] = num2;
				array[1] = "EditMenu";
				array[4] = component.SecondsBeforeRespawn;
				Debug.Log(string.Concat(array));
				double num4 = num3 - PhotonNetwork.time;
				if (num2 <= 891f)
				{
					num4 = 8.0;
				}
				component.OPHALGOIDOI((float)num4);
			}
		}
	}

	// Token: 0x0600C0CB RID: 49355 RVA: 0x00463C2C File Offset: 0x00461E2C
	public void GPMKNJDDLJI()
	{
		object[] array = new object[5];
		array[1] = "_Visualize";
		array[1] = PhotonNetwork.isMasterClient;
		array[2] = ": ";
		array[6] = PhotonNetwork.player.ONIKFABKELO();
		Debug.Log(string.Concat(array));
		this.IsWaitingForPickupInit = !PhotonNetwork.isMasterClient;
		if (PhotonNetwork.playerList.Length >= 5)
		{
			base.Invoke("SpawnObj", 1895f);
		}
	}

	// Token: 0x0400166E RID: 5742
	public bool IsWaitingForPickupInit;

	// Token: 0x0400166F RID: 5743
	private const float ENLJMGHAIIO = 0.2f;
}
