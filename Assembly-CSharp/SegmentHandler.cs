using System;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000405 RID: 1029
public class SegmentHandler : MonoBehaviour
{
	// Token: 0x0600EB1E RID: 60190 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void NKLCNJEIAFB(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB1F RID: 60191 RVA: 0x0052DD18 File Offset: 0x0052BF18
	private void EJFJENFKLND()
	{
		if (base.transform.localPosition.z >= 353f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 483f)
		{
			if (this.NBPGDBABKIC.EDIJKHEMPAD().KCAOJFPDEIP() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.FFIPLLNKGEN();
				string lblkdnnpaco = "CameraFilterPack/Color_YUV";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
				object[] array = new object[0];
				array[0] = false;
				photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	// Token: 0x0600EB20 RID: 60192 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void FEJAAGGMBOE(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB21 RID: 60193 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void IFGOHEOEGKH(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB22 RID: 60194 RVA: 0x0052DDF8 File Offset: 0x0052BFF8
	private void FABKIGNFECE()
	{
		if (base.transform.localPosition.z >= 931f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1670f)
		{
			if (this.NBPGDBABKIC.EOOCGIFFKBG().BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GBMJAPGLMGB();
				string lblkdnnpaco = "MapEnd";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = true;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	// Token: 0x0600EB23 RID: 60195 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void CFKJHLOEDFO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB24 RID: 60196 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void PAFMNAIDAFH(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB25 RID: 60197 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void NBHGPDAKJGF(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB26 RID: 60198 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void GAJEPOEIOPP(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB27 RID: 60199 RVA: 0x0052DEBC File Offset: 0x0052C0BC
	private void AAPKBNDHBLI()
	{
		if (base.transform.localPosition.z >= 1525f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1589f)
		{
			if (this.NBPGDBABKIC.EOOCGIFFKBG().BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GMAHNPNHMFK();
				string lblkdnnpaco = "#savemapbeforeuploading";
				PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
				object[] array = new object[1];
				array[1] = true;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	// Token: 0x0600EB28 RID: 60200 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void CPFOEFKOJGA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB29 RID: 60201 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void EMOCEKPLGBK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB2A RID: 60202 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void LCGMHCBNCDM(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB2B RID: 60203 RVA: 0x0052DF80 File Offset: 0x0052C180
	private void ONMGIPAILOH()
	{
		if (base.transform.localPosition.z >= 173f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1748f)
		{
			if (this.NBPGDBABKIC.AAMNKPHHHCI().DOLKFPIABDD() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GBHNDHLAJLI();
				string lblkdnnpaco = "SetBGColor";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[1];
				array[1] = false;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	// Token: 0x0600EB2C RID: 60204 RVA: 0x0052E044 File Offset: 0x0052C244
	private void LCHBFNIPBHB()
	{
		if (base.transform.localPosition.z >= 1027f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 764f)
		{
			if (this.NBPGDBABKIC.FFIPLLNKGEN().DOLKFPIABDD() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.IBKCMBIGOEJ();
				string lblkdnnpaco = "_Offsets";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[1];
				array[1] = false;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	// Token: 0x0600EB2D RID: 60205 RVA: 0x0052E108 File Offset: 0x0052C308
	private void MMBPLGGLPDB()
	{
		if (base.transform.localPosition.z >= 697f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 648f)
		{
			if (this.NBPGDBABKIC.GBHNDHLAJLI().KCAOJFPDEIP() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.EOOCGIFFKBG().PBMFBOOALKA("[Left]", PhotonTargets.All, new object[]
				{
					false
				});
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	// Token: 0x0600EB2E RID: 60206 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void Init(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB2F RID: 60207 RVA: 0x0052E1CC File Offset: 0x0052C3CC
	private void POIMNOBDBBN()
	{
		if (base.transform.localPosition.z >= 174f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 546f)
		{
			if (this.NBPGDBABKIC.JAEJDHHCJJO().DOLKFPIABDD() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.OELHGNKAMEG();
				string lblkdnnpaco = "_Value4";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[1];
				array[1] = true;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	// Token: 0x0600EB30 RID: 60208 RVA: 0x0052E290 File Offset: 0x0052C490
	private void IKIDIJLIGOH()
	{
		if (base.transform.localPosition.z >= 1913f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 961f)
		{
			if (this.NBPGDBABKIC.EDIJKHEMPAD().isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.OELHGNKAMEG();
				string lblkdnnpaco = "useSrcAlphaAsMask";
				PhotonTargets mpnmoonbmii = PhotonTargets.Others;
				object[] array = new object[0];
				array[0] = true;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	// Token: 0x0600EB31 RID: 60209 RVA: 0x0052E354 File Offset: 0x0052C554
	private void JBNPEHMDCMI()
	{
		if (base.transform.localPosition.z >= 1467f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1356f)
		{
			if (this.NBPGDBABKIC.GBMJAPGLMGB().DOLKFPIABDD() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GBHNDHLAJLI();
				string lblkdnnpaco = "_FadeFX";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
				object[] array = new object[0];
				array[0] = false;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	// Token: 0x0600EB32 RID: 60210 RVA: 0x0052E418 File Offset: 0x0052C618
	private void MJNPIDGNJMK()
	{
		if (base.transform.localPosition.z >= 68f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 709f)
		{
			if (this.NBPGDBABKIC.photonView.isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.GBMJAPGLMGB().MIAHMDGOOPJ("CameraFilterPack/Edge_Neon", PhotonTargets.OthersBuffered, new object[]
				{
					true
				});
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	// Token: 0x0600EB33 RID: 60211 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void EFEONCCCKNP(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB34 RID: 60212 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void FIMJABKECNG(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB35 RID: 60213 RVA: 0x0052E4DC File Offset: 0x0052C6DC
	private void MFMIODIAKNI()
	{
		if (base.transform.localPosition.z >= 1663f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 450f)
		{
			if (this.NBPGDBABKIC.IBKCMBIGOEJ().KCAOJFPDEIP() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.FFIPLLNKGEN();
				string lblkdnnpaco = "Object ID. Case-Sensitive";
				PhotonTargets mpnmoonbmii = PhotonTargets.MasterClient;
				object[] array = new object[0];
				array[1] = false;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	// Token: 0x0600EB36 RID: 60214 RVA: 0x0052E5A0 File Offset: 0x0052C7A0
	private void DPIPGGDNGHN()
	{
		if (base.transform.localPosition.z >= 932f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1929f)
		{
			if (this.NBPGDBABKIC.JAEJDHHCJJO().BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.BLMHOKPIMOD().MIAHMDGOOPJ("#discord{0}joinrequest", PhotonTargets.AllBuffered, new object[]
				{
					false
				});
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	// Token: 0x0600EB37 RID: 60215 RVA: 0x0052E664 File Offset: 0x0052C864
	private void FBMDHDBELEK()
	{
		if (base.transform.localPosition.z >= 535f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1729f)
		{
			if (this.NBPGDBABKIC.OELHGNKAMEG().BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.OELHGNKAMEG();
				string lblkdnnpaco = "_NumberOfWaves";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[1] = true;
				photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	// Token: 0x0600EB38 RID: 60216 RVA: 0x0052E728 File Offset: 0x0052C928
	private void Update()
	{
		if (base.transform.localPosition.z >= -0.08f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 10f)
		{
			if (this.NBPGDBABKIC.photonView.isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.photonView.RPC("LostLive", PhotonTargets.AllBufferedViaServer, new object[]
				{
					false
				});
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	// Token: 0x0600EB39 RID: 60217 RVA: 0x0052E7EC File Offset: 0x0052C9EC
	private void AEIJFLJEABG()
	{
		if (base.transform.localPosition.z >= 1021f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 629f)
		{
			if (this.NBPGDBABKIC.photonView.isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.EDIJKHEMPAD();
				string lblkdnnpaco = "Parent ID";
				PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
				object[] array = new object[1];
				array[1] = true;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	// Token: 0x0600EB3A RID: 60218 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void KJBJBNGJDAD(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB3B RID: 60219 RVA: 0x0052E8B0 File Offset: 0x0052CAB0
	private void GPFJMKCGHGB()
	{
		if (base.transform.localPosition.z >= 1766f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1977f)
		{
			if (this.NBPGDBABKIC.JAEJDHHCJJO().isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.EOOCGIFFKBG();
				string lblkdnnpaco = ".lastCheckpoint.time";
				PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
				object[] array = new object[0];
				array[1] = false;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.PBPGEBLGINB(base.gameObject);
		}
	}

	// Token: 0x0600EB3C RID: 60220 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void ALKBNPMCEOM(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB3D RID: 60221 RVA: 0x0052E974 File Offset: 0x0052CB74
	private void FOMNCPKKCFN()
	{
		if (base.transform.localPosition.z >= 594f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 744f)
		{
			if (this.NBPGDBABKIC.EDIJKHEMPAD().isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GBMJAPGLMGB();
				string lblkdnnpaco = "settings.gamemessagesduration";
				PhotonTargets mpnmoonbmii = (PhotonTargets)8;
				object[] array = new object[0];
				array[0] = false;
				photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	// Token: 0x0600EB3E RID: 60222 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void LCKKDMKJJEF(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB3F RID: 60223 RVA: 0x0052EA38 File Offset: 0x0052CC38
	private void IDIIELPAMCJ()
	{
		if (base.transform.localPosition.z >= 1053f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1176f)
		{
			if (this.NBPGDBABKIC.EDIJKHEMPAD().isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.photonView;
				string lblkdnnpaco = "Connecting";
				PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
				object[] array = new object[1];
				array[1] = false;
				photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	// Token: 0x0600EB40 RID: 60224 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void JJFLHFCBENC(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB41 RID: 60225 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void LBICLFNOLAK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB42 RID: 60226 RVA: 0x0052EAFC File Offset: 0x0052CCFC
	private void HMNLHMLILKD()
	{
		if (base.transform.localPosition.z >= 1244f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1270f)
		{
			if (this.NBPGDBABKIC.BLMHOKPIMOD().BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.ACPGHFHDCIP();
				string lblkdnnpaco = ".lastCheckpoint.time";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[1];
				array[1] = true;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	// Token: 0x0600EB43 RID: 60227 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void GCNKIJDNPMD(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB44 RID: 60228 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void GGHCMPKGNGE(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB45 RID: 60229 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void NOBNCNJKOLA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB46 RID: 60230 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void NKLNGGOHLMO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB47 RID: 60231 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void BFMEBNFGCEA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB48 RID: 60232 RVA: 0x0052EBC0 File Offset: 0x0052CDC0
	private void KMKLDAJLCNM()
	{
		if (base.transform.localPosition.z >= 738f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 390f)
		{
			if (this.NBPGDBABKIC.GMAHNPNHMFK().BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.EDIJKHEMPAD().MIAHMDGOOPJ("VHS2", PhotonTargets.AllViaServer, new object[]
				{
					true
				});
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	// Token: 0x0600EB49 RID: 60233 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void LILOGPDPFDA(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB4A RID: 60234 RVA: 0x0052EC84 File Offset: 0x0052CE84
	private void OIBMHPIFAKK()
	{
		if (base.transform.localPosition.z >= 204f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1851f)
		{
			if (this.NBPGDBABKIC.BLMHOKPIMOD().BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GMAHNPNHMFK();
				string lblkdnnpaco = "sfxVolume";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[1];
				array[1] = false;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.despawn(base.gameObject);
		}
	}

	// Token: 0x0600EB4B RID: 60235 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void CAJFKNFJEKC(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB4C RID: 60236 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void FFBDGOBNNCO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB4D RID: 60237 RVA: 0x0052ED48 File Offset: 0x0052CF48
	private void OBAEDJJDCPN()
	{
		if (base.transform.localPosition.z >= 1543f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 675f)
		{
			if (this.NBPGDBABKIC.AAMNKPHHHCI().isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GMAHNPNHMFK();
				string lblkdnnpaco = "SUCCESS! Item submitted! :D :D :D";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[0];
				array[0] = true;
				photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	// Token: 0x0600EB4E RID: 60238 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void CDDHLFNJOGC(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB4F RID: 60239 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void KDJHONILJGK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB50 RID: 60240 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void LLAHPNGMEOO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB51 RID: 60241 RVA: 0x0052EE0C File Offset: 0x0052D00C
	private void LPMINJJPDCH()
	{
		if (base.transform.localPosition.z >= 1583f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 536f)
		{
			if (this.NBPGDBABKIC.JAEJDHHCJJO().DOLKFPIABDD() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.EOOCGIFFKBG().KEKKFNNMLMG("settings.shaders.bloomintencity", (PhotonTargets)7, new object[]
				{
					false
				});
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	// Token: 0x0600EB52 RID: 60242 RVA: 0x0052EED0 File Offset: 0x0052D0D0
	private void DNENFLNCIJP()
	{
		if (base.transform.localPosition.z >= 595f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 1770f)
		{
			if (this.NBPGDBABKIC.photonView.BGJKMGJBPFA() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.GBHNDHLAJLI();
				string lblkdnnpaco = "file://";
				PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
				object[] array = new object[1];
				array[1] = false;
				photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	// Token: 0x0600EB53 RID: 60243 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public void LKEPIEEIMAE(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = true;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB54 RID: 60244 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void EKOAKKNGGGI(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB55 RID: 60245 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void EOPEMLDJAAO(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB56 RID: 60246 RVA: 0x0052EF94 File Offset: 0x0052D194
	private void EGEGNHLODAA()
	{
		if (base.transform.localPosition.z >= 1004f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 794f)
		{
			if (this.NBPGDBABKIC.GBHNDHLAJLI().DOLKFPIABDD() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.ACPGHFHDCIP().IKIJDNPJKPM(": ", PhotonTargets.AllBuffered, new object[]
				{
					true
				});
			}
			TrashMan.AOACLGFGIPE(base.gameObject);
		}
	}

	// Token: 0x0600EB58 RID: 60248 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void AOEEOKNJDCK(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB59 RID: 60249 RVA: 0x0052F06C File Offset: 0x0052D26C
	private void LCJHDLKJEOM()
	{
		if (base.transform.localPosition.z >= 1314f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = true;
		}
		if (base.transform.localPosition.z >= 459f)
		{
			if (this.NBPGDBABKIC.AAMNKPHHHCI().KCAOJFPDEIP() && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Loading && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.IBKCMBIGOEJ().MIAHMDGOOPJ("_Distortion", PhotonTargets.Others, new object[]
				{
					false
				});
			}
			TrashMan.LEJGMANJAHM(base.gameObject);
		}
	}

	// Token: 0x0600EB5A RID: 60250 RVA: 0x0052F130 File Offset: 0x0052D330
	private void JDGFCEPDKAJ()
	{
		if (base.transform.localPosition.z >= 1650f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 1802f)
		{
			if (this.NBPGDBABKIC.EOOCGIFFKBG().isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				PhotonView photonView = this.NBPGDBABKIC.CIACEFBNDDJ();
				string lblkdnnpaco = "settings_bindings_sec_";
				PhotonTargets mpnmoonbmii = PhotonTargets.All;
				object[] array = new object[1];
				array[1] = true;
				photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
			}
			TrashMan.JLCMCGJCNBL(base.gameObject);
		}
	}

	// Token: 0x0600EB5B RID: 60251 RVA: 0x0052DCFC File Offset: 0x0052BEFC
	public void PFMJPIJONIP(PlayerBase NBPGDBABKIC)
	{
		this.NBPGDBABKIC = NBPGDBABKIC;
		this.DIEJJADFJGO = false;
		this.onSpawn.Invoke();
	}

	// Token: 0x0600EB5C RID: 60252 RVA: 0x0052F1F4 File Offset: 0x0052D3F4
	private void BGDONBMDPGM()
	{
		if (base.transform.localPosition.z >= 1864f && !this.DIEJJADFJGO)
		{
			this.DIEJJADFJGO = false;
		}
		if (base.transform.localPosition.z >= 884f)
		{
			if (this.NBPGDBABKIC.EDIJKHEMPAD().isMine && this.NBPGDBABKIC.currentState == PlayerBase.PlayerState.Playing && this.NBPGDBABKIC.GetGameScene().gameMode != GameScene.GameMode.Relax)
			{
				this.NBPGDBABKIC.AAMNKPHHHCI().MIAHMDGOOPJ("_Value", PhotonTargets.AllViaServer, new object[]
				{
					true
				});
			}
			TrashMan.MIKDHOEEODJ(base.gameObject);
		}
	}

	// Token: 0x04001A72 RID: 6770
	public float spawnAnimationDelay = 0.15f;

	// Token: 0x04001A73 RID: 6771
	public UnityEvent onSpawn;

	// Token: 0x04001A74 RID: 6772
	public UnityEvent onDestroy;

	// Token: 0x04001A75 RID: 6773
	private PlayerBase NBPGDBABKIC;

	// Token: 0x04001A76 RID: 6774
	private bool DIEJJADFJGO;
}
