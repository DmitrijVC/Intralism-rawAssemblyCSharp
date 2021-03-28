using System;
using UnityEngine;

// Token: 0x020003DC RID: 988
[Serializable]
public class PlayerControllerKeyHandler
{
	// Token: 0x0600E07A RID: 57466 RVA: 0x005012B4 File Offset: 0x004FF4B4
	public void IJHGPCAHDEH()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.NLIGEMDBEOA().JAEJDHHCJJO().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.JHEFABODNPO().CIACEFBNDDJ();
				string lblkdnnpaco = "_Value2";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[0];
				array[0] = this.player.GBLDJPCFLPC();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.AIFIMLBHNOM(this.player.PDKJFCMEIEE(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E07B RID: 57467 RVA: 0x00501378 File Offset: 0x004FF578
	public void IDOFOCOFEIE()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.DFLDMFKFBPC().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = this.player.NODPGAOEHGL().GBHNDHLAJLI();
				string lblkdnnpaco = "Populate Mesh Data";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[7];
				array[0] = this.player.BODCFCGDMDA();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.NLPAHKLGJMK(this.player.FPFBFHALAJD(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E07C RID: 57468 RVA: 0x0050143C File Offset: 0x004FF63C
	public void MJINNGLCFDC()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E07D RID: 57469 RVA: 0x00501498 File Offset: 0x004FF698
	public void HNNDLFBNBBO()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E07E RID: 57470 RVA: 0x005014F4 File Offset: 0x004FF6F4
	public void HGDELHLBLJI()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E07F RID: 57471 RVA: 0x00501550 File Offset: 0x004FF750
	public void BJKJEJJOPLC()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.KEFGHEIOHON().photonView.KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.DMFKOAIAHDC().EOOCGIFFKBG();
				string lblkdnnpaco = "CameraFilterPack/Color_Chromatic_Aberration";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[2];
				array[0] = this.player.GetCombo();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.NLPAHKLGJMK(this.player.PDKJFCMEIEE(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E080 RID: 57472 RVA: 0x00501614 File Offset: 0x004FF814
	public void LIMBEFBJNPL()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.KEFGHEIOHON().AAMNKPHHHCI().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.KEFGHEIOHON().JAEJDHHCJJO();
				string lblkdnnpaco = "[Left]";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = this.player.JPDMLANDOOI();
				array[0] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.AIFIMLBHNOM(this.player.HFKKBJFPABL(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E081 RID: 57473 RVA: 0x005016D8 File Offset: 0x004FF8D8
	public void OIBMHPIFAKK()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.NGFFMGKPMNP(this.buttonKey))
			{
				this.GOANPHDJCLL();
			}
			if (this.wasPressed && this.currentTimeout > 540f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1230f)
			{
				this.BJIKAHNJNEB();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.NFANBIICAFM().AAMNKPHHHCI().isMine)
			{
				PhotonView photonView = this.player.JHEFABODNPO().IBKCMBIGOEJ();
				string lblkdnnpaco = "CameraFilterPack_Atmosphere_Rain_FX";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[5];
				array[1] = this.player.GetCombo();
				array[0] = this.handId;
				photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.LNAOENCHKGI(this.player.KNBOIOEKJID(), this.handId, 1953f);
			}
		}
	}

	// Token: 0x0600E082 RID: 57474 RVA: 0x00501824 File Offset: 0x004FFA24
	public void OnPressed()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E083 RID: 57475 RVA: 0x00501880 File Offset: 0x004FFA80
	public void FPKJJBAENGF()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.DFLDMFKFBPC().ACPGHFHDCIP().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.JJPEGCHJJED().BLMHOKPIMOD();
				string lblkdnnpaco = "action";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[8];
				array[0] = this.player.ALKGJEEHEBN();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.HPBPJKFHMCD(this.player.GetCombo(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E084 RID: 57476 RVA: 0x00501944 File Offset: 0x004FFB44
	public void EMKKGIEFKML()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.NLIGEMDBEOA().EOOCGIFFKBG().isMine)
			{
				PhotonView photonView = this.player.NODPGAOEHGL().BLMHOKPIMOD();
				string lblkdnnpaco = "Uploading preview image...";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[1];
				array[0] = this.player.FPFBFHALAJD();
				array[1] = this.handId;
				photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.GIGMGMDAJOG(this.player.KNBOIOEKJID(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E085 RID: 57477 RVA: 0x00501A08 File Offset: 0x004FFC08
	public void BPIGKCAHDGG()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E086 RID: 57478 RVA: 0x00501A64 File Offset: 0x004FFC64
	public void OGKGIAAACAD()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.PELOCGBHJFO().GMAHNPNHMFK().isMine)
			{
				PhotonView photonView = this.player.NLIGEMDBEOA().GBMJAPGLMGB();
				string lblkdnnpaco = "Turn";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = this.player.JPDMLANDOOI();
				array[1] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.HPBPJKFHMCD(this.player.ALKGJEEHEBN(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E087 RID: 57479 RVA: 0x00501B28 File Offset: 0x004FFD28
	public void LMBDNPLDGIJ()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.CLMDACAINOA();
			}
			if (this.wasPressed && this.currentTimeout > 1354f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1817f)
			{
				this.PMLPJADKFMG();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.HBDLLAKOFKJ().CIACEFBNDDJ().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.DGNIAONOGKK().IBKCMBIGOEJ();
				string lblkdnnpaco = "_CurTex";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[5];
				array[1] = this.player.JPDMLANDOOI();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.CheckCombo(this.player.KNBOIOEKJID(), this.handId, 1893f);
			}
		}
	}

	// Token: 0x0600E088 RID: 57480 RVA: 0x00501C74 File Offset: 0x004FFE74
	public void NKLIHNJCHOG()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.CHAJOGCCKDA(this.buttonKey))
			{
				this.MAJBGPMBOKB();
			}
			if (this.wasPressed && this.currentTimeout > 1623f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 156f)
			{
				this.IDOFOCOFEIE();
			}
		}
		else if (hardInput.GetKeyDown(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.JJPEGCHJJED().EDIJKHEMPAD().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.PELOCGBHJFO().JAEJDHHCJJO();
				string lblkdnnpaco = "_Value";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = this.player.ALKGJEEHEBN();
				array[1] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.GIGMGMDAJOG(this.player.PDKJFCMEIEE(), this.handId, 1913f);
			}
		}
	}

	// Token: 0x0600E089 RID: 57481 RVA: 0x00501DC0 File Offset: 0x004FFFC0
	public void BBBNLHALLBN()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.JJPEGCHJJED().OELHGNKAMEG().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.NLIGEMDBEOA().IBKCMBIGOEJ();
				string lblkdnnpaco = "_TimeX";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[5];
				array[1] = this.player.GetCombo();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.BHMNLMFCJLE(this.player.ALKGJEEHEBN(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E08A RID: 57482 RVA: 0x00501E84 File Offset: 0x00500084
	public void FJHFOBHJEHL()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.GetKeyDown(this.buttonKey))
			{
				this.CLMDACAINOA();
			}
			if (this.wasPressed && this.currentTimeout > 1870f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 420f)
			{
				this.LIMBEFBJNPL();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.DGNIAONOGKK().JAEJDHHCJJO().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.NLIGEMDBEOA().EOOCGIFFKBG();
				string lblkdnnpaco = "_AccumOrig";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
				object[] array = new object[2];
				array[0] = this.player.MHMBDPMDDAC();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.LNAOENCHKGI(this.player.GBLDJPCFLPC(), this.handId, 1802f);
			}
		}
	}

	// Token: 0x0600E08B RID: 57483 RVA: 0x00501FD0 File Offset: 0x005001D0
	public void CKCPHFLOLAH()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.DMFKOAIAHDC().EOOCGIFFKBG().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.JJPEGCHJJED().CIACEFBNDDJ();
				string lblkdnnpaco = "_Parameter";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[3];
				array[0] = this.player.HFKKBJFPABL();
				array[0] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.DPOCLHCABII(this.player.GBLDJPCFLPC(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E08C RID: 57484 RVA: 0x00502094 File Offset: 0x00500294
	public void LCJHDLKJEOM()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.IPEGECAHFCD();
			}
			if (this.wasPressed && this.currentTimeout > 1750f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 720f)
			{
				this.HFFAJNCOJNB();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.playerBase.GMAHNPNHMFK().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.DGNIAONOGKK().AAMNKPHHHCI();
				string lblkdnnpaco = "CameraFilterPack/Distortion_Wave_Horizontal";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[4];
				array[0] = this.player.GetCombo();
				array[1] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.PPJDDKHHDMP(this.player.JPDMLANDOOI(), this.handId, 1737f);
			}
		}
	}

	// Token: 0x0600E08D RID: 57485 RVA: 0x005021E0 File Offset: 0x005003E0
	public void Update()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.GetKeyDown(this.buttonKey))
			{
				this.OnPressed();
			}
			if (this.wasPressed && this.currentTimeout > 0f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 0f)
			{
				this.Reset();
			}
		}
		else if (hardInput.GetKeyDown(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.playerBase.photonView.isMine)
			{
				this.player.playerBase.photonView.RPC("CheckCombo", PhotonTargets.AllBuffered, new object[]
				{
					this.player.GetCombo(),
					this.handId
				});
			}
			else
			{
				this.player.CheckCombo(this.player.GetCombo(), this.handId, -1f);
			}
		}
	}

	// Token: 0x0600E08E RID: 57486 RVA: 0x0050232C File Offset: 0x0050052C
	public void CPGAFFIOGCH()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.playerBase.ACPGHFHDCIP().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.JJPEGCHJJED().GBMJAPGLMGB();
				string lblkdnnpaco = "_ScreenResolution";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[3];
				array[1] = this.player.GetCombo();
				array[1] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.NLPAHKLGJMK(this.player.HFKKBJFPABL(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E08F RID: 57487 RVA: 0x005023F0 File Offset: 0x005005F0
	public void AEIJFLJEABG()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.CHAJOGCCKDA(this.buttonKey))
			{
				this.EJBLHPIOAJF();
			}
			if (this.wasPressed && this.currentTimeout > 951f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1953f)
			{
				this.IJHGPCAHDEH();
			}
		}
		else if (hardInput.GetKeyDown(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.CCBCAICCJLD().CIACEFBNDDJ().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.HBDLLAKOFKJ().CIACEFBNDDJ();
				string lblkdnnpaco = "PopulateMapsList";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[5];
				array[1] = this.player.ALKGJEEHEBN();
				array[0] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.POFBCEKBIDH(this.player.ALKGJEEHEBN(), this.handId, 682f);
			}
		}
	}

	// Token: 0x0600E090 RID: 57488 RVA: 0x0050253C File Offset: 0x0050073C
	public void MDIDEHPCJBD()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E091 RID: 57489 RVA: 0x00502598 File Offset: 0x00500798
	public void LNLEHBBCGLM()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E092 RID: 57490 RVA: 0x005025F4 File Offset: 0x005007F4
	public void ABDEGHLHHHF()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E093 RID: 57491 RVA: 0x00502650 File Offset: 0x00500850
	public void KFACDBHDAOD()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.KIBLMKAKPOB();
			}
			if (this.wasPressed && this.currentTimeout > 1601f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 364f)
			{
				this.OGKGIAAACAD();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.DMFKOAIAHDC().JAEJDHHCJJO().BGJKMGJBPFA())
			{
				PhotonView photonView = this.player.DFLDMFKFBPC().photonView;
				string lblkdnnpaco = "_CenterX";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBuffered;
				object[] array = new object[3];
				array[1] = this.player.KNBOIOEKJID();
				array[0] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.DPOCLHCABII(this.player.KNBOIOEKJID(), this.handId, 1952f);
			}
		}
	}

	// Token: 0x0600E094 RID: 57492 RVA: 0x0050279C File Offset: 0x0050099C
	public void AJAAPDBCKPP()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E095 RID: 57493 RVA: 0x005027F8 File Offset: 0x005009F8
	public void CFOOCBMIFGA()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E096 RID: 57494 RVA: 0x00502854 File Offset: 0x00500A54
	public PlayerControllerKeyHandler(PlayerController.Direction LPIMAGMABLC, string CIMJCIDACFJ, int PGJECADBIOI, PlayerController JHOEDACNNKK)
	{
		this.attime = 0f;
		this.wasPressed = false;
		this.direction = LPIMAGMABLC;
		this.buttonKey = CIMJCIDACFJ;
		this.player = JHOEDACNNKK;
		this.handId = PGJECADBIOI;
		this.currentTimeout = 0f;
	}

	// Token: 0x0600E097 RID: 57495 RVA: 0x005028B8 File Offset: 0x00500AB8
	public void GANNKLPODAD()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E098 RID: 57496 RVA: 0x00502914 File Offset: 0x00500B14
	public void OFGMLJJEDMM()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E099 RID: 57497 RVA: 0x00502970 File Offset: 0x00500B70
	public void EGFBPCMCNDJ()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.NLIGEMDBEOA().IBKCMBIGOEJ().BGJKMGJBPFA())
			{
				PhotonView photonView = this.player.JJPEGCHJJED().CIACEFBNDDJ();
				string lblkdnnpaco = "settings_bindings_";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[7];
				array[1] = this.player.MHMBDPMDDAC();
				array[0] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.CONKAILPANP(this.player.MHMBDPMDDAC(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E09A RID: 57498 RVA: 0x00502A34 File Offset: 0x00500C34
	public void ENAANLLCMPK()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E09B RID: 57499 RVA: 0x00502A90 File Offset: 0x00500C90
	public void GAOMPMFOJNC()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.EICAMMJELIE().JAEJDHHCJJO().isMine)
			{
				PhotonView photonView = this.player.NLIGEMDBEOA().JAEJDHHCJJO();
				string lblkdnnpaco = "_WaveIntensity";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[2];
				array[0] = this.player.MHMBDPMDDAC();
				array[0] = this.handId;
				photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.AEDJKCPNEOC(this.player.HFKKBJFPABL(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E09C RID: 57500 RVA: 0x00502B54 File Offset: 0x00500D54
	public void HFFAJNCOJNB()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.DGNIAONOGKK().GBMJAPGLMGB().BGJKMGJBPFA())
			{
				PhotonView photonView = this.player.DMFKOAIAHDC().GBMJAPGLMGB();
				string lblkdnnpaco = "_ChangeBlue";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = this.player.HFKKBJFPABL();
				array[1] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.NBMHHGHIHDJ(this.player.ALKGJEEHEBN(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E09D RID: 57501 RVA: 0x00502C18 File Offset: 0x00500E18
	public void KIBLMKAKPOB()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E09E RID: 57502 RVA: 0x00502C74 File Offset: 0x00500E74
	public void GOFMABPMLKF()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.JHEFABODNPO().ACPGHFHDCIP().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.PELOCGBHJFO().FFIPLLNKGEN();
				string lblkdnnpaco = "solo";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[0];
				array[0] = this.player.FPFBFHALAJD();
				array[1] = this.handId;
				photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.OGACJDOPABH(this.player.GBLDJPCFLPC(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E09F RID: 57503 RVA: 0x00502D38 File Offset: 0x00500F38
	public void JHPOIOELNCG()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.GetKeyDown(this.buttonKey))
			{
				this.KIBLMKAKPOB();
			}
			if (this.wasPressed && this.currentTimeout > 1544f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 334f)
			{
				this.Reset();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.CCBCAICCJLD().BLMHOKPIMOD().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.NFANBIICAFM().photonView;
				string lblkdnnpaco = "_ScreenResolution";
				PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
				object[] array = new object[8];
				array[0] = this.player.PDKJFCMEIEE();
				array[1] = this.handId;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.OGACJDOPABH(this.player.HFKKBJFPABL(), this.handId, 428f);
			}
		}
	}

	// Token: 0x0600E0A0 RID: 57504 RVA: 0x00502E84 File Offset: 0x00501084
	public void IPEGECAHFCD()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E0A1 RID: 57505 RVA: 0x00502EE0 File Offset: 0x005010E0
	public void CLMDACAINOA()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E0A2 RID: 57506 RVA: 0x00502F3C File Offset: 0x0050113C
	public void MAOCOEGAFND()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.NGFFMGKPMNP(this.buttonKey))
			{
				this.GHGNCNDBHCG();
			}
			if (this.wasPressed && this.currentTimeout > 1268f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 45f)
			{
				this.JEKEBJCHOHO();
			}
		}
		else if (hardInput.GetKeyDown(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.JJPEGCHJJED().FFIPLLNKGEN().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.HBDLLAKOFKJ().BLMHOKPIMOD();
				string lblkdnnpaco = "_Value2";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = this.player.GBLDJPCFLPC();
				array[0] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.LNAOENCHKGI(this.player.MHMBDPMDDAC(), this.handId, 1284f);
			}
		}
	}

	// Token: 0x0600E0A3 RID: 57507 RVA: 0x00503088 File Offset: 0x00501288
	public void IDIIELPAMCJ()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.GetKeyDown(this.buttonKey))
			{
				this.JDDCECNFJAB();
			}
			if (this.wasPressed && this.currentTimeout > 1685f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 134f)
			{
				this.NNNCKCELBCE();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.NFANBIICAFM().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = this.player.NODPGAOEHGL().photonView;
				string lblkdnnpaco = "_MainTex2";
				PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
				object[] array = new object[1];
				array[1] = this.player.ALKGJEEHEBN();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.LNAOENCHKGI(this.player.DJLACMJODFF(), this.handId, 501f);
			}
		}
	}

	// Token: 0x0600E0A4 RID: 57508 RVA: 0x005031D4 File Offset: 0x005013D4
	public void PMLPJADKFMG()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.KEFGHEIOHON().GMAHNPNHMFK().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.DNOKKLIKLAM().GMAHNPNHMFK();
				string lblkdnnpaco = "' was created: ";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[3];
				array[1] = this.player.MHMBDPMDDAC();
				array[1] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.NBMHHGHIHDJ(this.player.KNBOIOEKJID(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E0A5 RID: 57509 RVA: 0x00503298 File Offset: 0x00501498
	public void EJBLHPIOAJF()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E0A6 RID: 57510 RVA: 0x005032F4 File Offset: 0x005014F4
	public void GLHGOGIMHBP()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E0A7 RID: 57511 RVA: 0x00503350 File Offset: 0x00501550
	public void IAPOBEGCHLG()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.ODHBANOIMPN().EDIJKHEMPAD().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.JHEFABODNPO().AAMNKPHHHCI();
				string lblkdnnpaco = "Editor";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[4];
				array[1] = this.player.GetCombo();
				array[0] = this.handId;
				photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.HPBPJKFHMCD(this.player.JPDMLANDOOI(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E0A8 RID: 57512 RVA: 0x00503414 File Offset: 0x00501614
	public void MFMIODIAKNI()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.ENAANLLCMPK();
			}
			if (this.wasPressed && this.currentTimeout > 715f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1717f)
			{
				this.Reset();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.JHEFABODNPO().OELHGNKAMEG().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.JHEFABODNPO().EOOCGIFFKBG();
				string lblkdnnpaco = "_Value3";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[5];
				array[0] = this.player.PDKJFCMEIEE();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.POFBCEKBIDH(this.player.KNBOIOEKJID(), this.handId, 183f);
			}
		}
	}

	// Token: 0x0600E0A9 RID: 57513 RVA: 0x00503560 File Offset: 0x00501760
	public void BJIKAHNJNEB()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.KEFGHEIOHON().EOOCGIFFKBG().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.DGNIAONOGKK().EDIJKHEMPAD();
				string lblkdnnpaco = "CameraFilterPack_Fly_VisionFX";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[5];
				array[1] = this.player.BODCFCGDMDA();
				array[0] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.LNAOENCHKGI(this.player.GBLDJPCFLPC(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = true;
	}

	// Token: 0x0600E0AA RID: 57514 RVA: 0x00503624 File Offset: 0x00501824
	public void DEJLOIGKEKO()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E0AB RID: 57515 RVA: 0x00503680 File Offset: 0x00501880
	public void KMEONPMCNJG()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.NGFFMGKPMNP(this.buttonKey))
			{
				this.BPIGKCAHDGG();
			}
			if (this.wasPressed && this.currentTimeout > 1262f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 690f)
			{
				this.GOFMABPMLKF();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.DGNIAONOGKK().FFIPLLNKGEN().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.EICAMMJELIE().EOOCGIFFKBG();
				string lblkdnnpaco = "id";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[6];
				array[1] = this.player.DJLACMJODFF();
				array[0] = this.handId;
				photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.CONKAILPANP(this.player.ALKGJEEHEBN(), this.handId, 260f);
			}
		}
	}

	// Token: 0x0600E0AC RID: 57516 RVA: 0x005037CC File Offset: 0x005019CC
	public void NCPAFCKGJEA()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.ENAANLLCMPK();
			}
			if (this.wasPressed && this.currentTimeout > 1860f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1225f)
			{
				this.DABMBPBGPPI();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.JHEFABODNPO().EDIJKHEMPAD().BGJKMGJBPFA())
			{
				PhotonView photonView = this.player.DMFKOAIAHDC().BLMHOKPIMOD();
				string lblkdnnpaco = "Failed to 'GetKeyCode' for key: ";
				PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
				object[] array = new object[4];
				array[1] = this.player.FPFBFHALAJD();
				array[0] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.DBKJHNBJBKK(this.player.KNBOIOEKJID(), this.handId, 1596f);
			}
		}
	}

	// Token: 0x0600E0AD RID: 57517 RVA: 0x00503918 File Offset: 0x00501B18
	public void HLDFOJMHKNL()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.NGFFMGKPMNP(this.buttonKey))
			{
				this.KIBLMKAKPOB();
			}
			if (this.wasPressed && this.currentTimeout > 1292f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1231f)
			{
				this.GAOMPMFOJNC();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.PELOCGBHJFO().EDIJKHEMPAD().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.JHEFABODNPO().photonView;
				string lblkdnnpaco = "No valid adaptive tonemapper type found!";
				PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
				object[] array = new object[8];
				array[0] = this.player.ALKGJEEHEBN();
				array[1] = this.handId;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.OGACJDOPABH(this.player.KNBOIOEKJID(), this.handId, 1389f);
			}
		}
	}

	// Token: 0x0600E0AE RID: 57518 RVA: 0x00503A64 File Offset: 0x00501C64
	public void LLJLDLLNFBH()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.FFEJFNEFNFD();
			}
			if (this.wasPressed && this.currentTimeout > 386f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 212f)
			{
				this.BJKJEJJOPLC();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.JHEFABODNPO().JAEJDHHCJJO().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.PELOCGBHJFO().ACPGHFHDCIP();
				string lblkdnnpaco = "Preparing configuration...";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBuffered;
				object[] array = new object[6];
				array[0] = this.player.GetCombo();
				array[0] = this.handId;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.HPBPJKFHMCD(this.player.BODCFCGDMDA(), this.handId, 1517f);
			}
		}
	}

	// Token: 0x0600E0AF RID: 57519 RVA: 0x00503BB0 File Offset: 0x00501DB0
	public void KCDOMIJBFLL()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.NGFFMGKPMNP(this.buttonKey))
			{
				this.BPIGKCAHDGG();
			}
			if (this.wasPressed && this.currentTimeout > 1147f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 171f)
			{
				this.IJHGPCAHDEH();
			}
		}
		else if (hardInput.GetKeyDown(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.playerBase.EOOCGIFFKBG().BGJKMGJBPFA())
			{
				PhotonView photonView = this.player.playerBase.BLMHOKPIMOD();
				string lblkdnnpaco = "OnDeserialize";
				PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
				object[] array = new object[5];
				array[1] = this.player.FPFBFHALAJD();
				array[1] = this.handId;
				photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.CheckCombo(this.player.KNBOIOEKJID(), this.handId, 1198f);
			}
		}
	}

	// Token: 0x0600E0B0 RID: 57520 RVA: 0x00503CFC File Offset: 0x00501EFC
	public void GPFJMKCGHGB()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.CFOOCBMIFGA();
			}
			if (this.wasPressed && this.currentTimeout > 1287f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 195f)
			{
				this.FPKJJBAENGF();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.DNOKKLIKLAM().EOOCGIFFKBG().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.NFANBIICAFM().CIACEFBNDDJ();
				string lblkdnnpaco = "PAUSE [SPACE]";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[1];
				array[0] = this.player.BODCFCGDMDA();
				array[1] = this.handId;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.OGACJDOPABH(this.player.HFKKBJFPABL(), this.handId, 1948f);
			}
		}
	}

	// Token: 0x0600E0B1 RID: 57521 RVA: 0x00503E48 File Offset: 0x00502048
	public void IEMEHGCFAPD()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.CHAJOGCCKDA(this.buttonKey))
			{
				this.JDDCECNFJAB();
			}
			if (this.wasPressed && this.currentTimeout > 622f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1830f)
			{
				this.EGFBPCMCNDJ();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.DGNIAONOGKK().EOOCGIFFKBG().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.DGNIAONOGKK().AAMNKPHHHCI();
				string lblkdnnpaco = "VeryHigh";
				PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
				object[] array = new object[6];
				array[1] = this.player.GetCombo();
				array[1] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.POFBCEKBIDH(this.player.PDKJFCMEIEE(), this.handId, 1066f);
			}
		}
	}

	// Token: 0x0600E0B2 RID: 57522 RVA: 0x00503F94 File Offset: 0x00502194
	public void NNNCKCELBCE()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.PELOCGBHJFO().IBKCMBIGOEJ().isMine)
			{
				PhotonView photonView = this.player.NLIGEMDBEOA().BLMHOKPIMOD();
				string lblkdnnpaco = "JoinButton";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[8];
				array[1] = this.player.PDKJFCMEIEE();
				array[1] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.BHMNLMFCJLE(this.player.FPFBFHALAJD(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E0B3 RID: 57523 RVA: 0x00504058 File Offset: 0x00502258
	public void MAJBGPMBOKB()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E0B4 RID: 57524 RVA: 0x005040B4 File Offset: 0x005022B4
	public void DEDANNMJNOC()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.DNOKKLIKLAM().CIACEFBNDDJ().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.CCBCAICCJLD().EDIJKHEMPAD();
				string lblkdnnpaco = "inventory.selected.";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[]
				{
					null,
					this.player.DJLACMJODFF()
				};
				array[1] = this.handId;
				photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.GIGMGMDAJOG(this.player.MHMBDPMDDAC(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E0B5 RID: 57525 RVA: 0x00504178 File Offset: 0x00502378
	public void LJIHHJOAJCN()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.AADFFLGEJPP(this.buttonKey))
			{
				this.EJBLHPIOAJF();
			}
			if (this.wasPressed && this.currentTimeout > 73f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 52f)
			{
				this.GOFMABPMLKF();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.DMFKOAIAHDC().OELHGNKAMEG().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.JJPEGCHJJED().OELHGNKAMEG();
				string lblkdnnpaco = "_Value3";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
				object[] array = new object[4];
				array[0] = this.player.JPDMLANDOOI();
				array[1] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.CheckCombo(this.player.DJLACMJODFF(), this.handId, 850f);
			}
		}
	}

	// Token: 0x0600E0B6 RID: 57526 RVA: 0x005042C4 File Offset: 0x005024C4
	public void OFOHOAPHFBD()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E0B7 RID: 57527 RVA: 0x00504320 File Offset: 0x00502520
	public void DABMBPBGPPI()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.DNOKKLIKLAM().JAEJDHHCJJO().BGJKMGJBPFA())
			{
				PhotonView photonView = this.player.DFLDMFKFBPC().GBMJAPGLMGB();
				string lblkdnnpaco = "SingleplayerButton";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[4];
				array[1] = this.player.MHMBDPMDDAC();
				array[0] = this.handId;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.DPOCLHCABII(this.player.JPDMLANDOOI(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E0B8 RID: 57528 RVA: 0x005043E4 File Offset: 0x005025E4
	public void EKPOOJKFJFC()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E0B9 RID: 57529 RVA: 0x00504440 File Offset: 0x00502640
	public void GHGNCNDBHCG()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E0BA RID: 57530 RVA: 0x0050449C File Offset: 0x0050269C
	public void KMKLDAJLCNM()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.NGFFMGKPMNP(this.buttonKey))
			{
				this.MAJBGPMBOKB();
			}
			if (this.wasPressed && this.currentTimeout > 1411f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 9f)
			{
				this.Reset();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.CCBCAICCJLD().GBHNDHLAJLI().DOLKFPIABDD())
			{
				PhotonView photonView = this.player.NFANBIICAFM().ACPGHFHDCIP();
				string lblkdnnpaco = "_ScreenResolution";
				PhotonTargets mpnmoonbmii = (PhotonTargets)7;
				object[] array = new object[3];
				array[1] = this.player.MHMBDPMDDAC();
				array[1] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.DBKJHNBJBKK(this.player.PDKJFCMEIEE(), this.handId, 1934f);
			}
		}
	}

	// Token: 0x0600E0BB RID: 57531 RVA: 0x005045E8 File Offset: 0x005027E8
	public void FFEJFNEFNFD()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E0BC RID: 57532 RVA: 0x00504644 File Offset: 0x00502844
	public void BPJBFPOMCGB()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x0600E0BD RID: 57533 RVA: 0x005046A0 File Offset: 0x005028A0
	public void GOANPHDJCLL()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = false;
	}

	// Token: 0x0600E0BE RID: 57534 RVA: 0x005046FC File Offset: 0x005028FC
	public void JEKEBJCHOHO()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.JHEFABODNPO().BLMHOKPIMOD().isMine)
			{
				PhotonView photonView = this.player.JJPEGCHJJED().EDIJKHEMPAD();
				string lblkdnnpaco = "_TimeX";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[4];
				array[0] = this.player.KNBOIOEKJID();
				array[0] = this.handId;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.BHMNLMFCJLE(this.player.JPDMLANDOOI(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E0BF RID: 57535 RVA: 0x005047C0 File Offset: 0x005029C0
	public void JNBPKNNBMDI()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.CHAJOGCCKDA(this.buttonKey))
			{
				this.OFOHOAPHFBD();
			}
			if (this.wasPressed && this.currentTimeout > 1810f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 105f)
			{
				this.HFFAJNCOJNB();
			}
		}
		else if (hardInput.NGFFMGKPMNP(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.JJPEGCHJJED().JAEJDHHCJJO().isMine)
			{
				PhotonView photonView = this.player.HBDLLAKOFKJ().BLMHOKPIMOD();
				string lblkdnnpaco = "SetTrailZoomSpeed";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[]
				{
					null,
					this.player.DJLACMJODFF()
				};
				array[0] = this.handId;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.NLPAHKLGJMK(this.player.GBLDJPCFLPC(), this.handId, 356f);
			}
		}
	}

	// Token: 0x0600E0C0 RID: 57536 RVA: 0x0050490C File Offset: 0x00502B0C
	public void DPIPGGDNGHN()
	{
		if (this.player.useComboSystem)
		{
			if (!this.wasPressed && hardInput.NGFFMGKPMNP(this.buttonKey))
			{
				this.MAJBGPMBOKB();
			}
			if (this.wasPressed && this.currentTimeout > 1904f)
			{
				this.currentTimeout -= Time.deltaTime;
			}
			if (this.wasPressed && this.currentTimeout <= 1504f)
			{
				this.NNNCKCELBCE();
			}
		}
		else if (hardInput.CHAJOGCCKDA(this.buttonKey))
		{
			this.player.currentCombo.Add(this.direction);
			if (!this.player.isRecording && this.player.NLIGEMDBEOA().AAMNKPHHHCI().KCAOJFPDEIP())
			{
				PhotonView photonView = this.player.PELOCGBHJFO().OELHGNKAMEG();
				string lblkdnnpaco = " : ";
				PhotonTargets mpnmoonbmii = (PhotonTargets)8;
				object[] array = new object[3];
				array[0] = this.player.GetCombo();
				array[0] = this.handId;
				photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
			}
			else
			{
				this.player.LNAOENCHKGI(this.player.FPFBFHALAJD(), this.handId, 562f);
			}
		}
	}

	// Token: 0x0600E0C1 RID: 57537 RVA: 0x00504A58 File Offset: 0x00502C58
	public void Reset()
	{
		if (this.wasPressed)
		{
			if (!this.player.isRecording && this.player.playerBase.photonView.isMine)
			{
				this.player.playerBase.photonView.RPC("CheckCombo", PhotonTargets.All, new object[]
				{
					this.player.GetCombo(),
					this.handId
				});
			}
			else
			{
				this.player.CheckCombo(this.player.GetCombo(), this.handId, this.attime);
			}
		}
		this.player.currentCombo.Clear();
		this.wasPressed = false;
	}

	// Token: 0x0600E0C2 RID: 57538 RVA: 0x00504B1C File Offset: 0x00502D1C
	public void JDDCECNFJAB()
	{
		if (this.player.useComboSystem)
		{
			this.attime = Singleton<MapEditor>.Instance.currentTime;
			this.currentTimeout = this.player.currentComboTimeout;
		}
		this.player.currentCombo.Add(this.direction);
		this.wasPressed = true;
	}

	// Token: 0x04001954 RID: 6484
	public PlayerController player;

	// Token: 0x04001955 RID: 6485
	public PlayerController.Direction direction;

	// Token: 0x04001956 RID: 6486
	public string buttonKey = string.Empty;

	// Token: 0x04001957 RID: 6487
	public bool wasPressed;

	// Token: 0x04001958 RID: 6488
	public float currentTimeout = 0.1f;

	// Token: 0x04001959 RID: 6489
	public int handId;

	// Token: 0x0400195A RID: 6490
	public float attime;
}
