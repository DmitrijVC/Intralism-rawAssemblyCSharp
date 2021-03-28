using System;
using Photon;
using UnityEngine;

// Token: 0x0200034A RID: 842
[RequireComponent(typeof(PhotonView))]
public class OnAwakeUsePhotonView : Photon.MonoBehaviour
{
	// Token: 0x0600BE3B RID: 48699 RVA: 0x0045785B File Offset: 0x00455A5B
	public void BFKJFDJMOPD()
	{
		Debug.Log("Closes the app" + base.IBKCMBIGOEJ());
	}

	// Token: 0x0600BE3C RID: 48700 RVA: 0x00457872 File Offset: 0x00455A72
	public void MKFONKOJHJI(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[1] = "Error0";
		array[0] = JNBMEPMFOOB;
		array[8] = "Checkpoint";
		array[6] = base.GBHNDHLAJLI();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE3D RID: 48701 RVA: 0x004578A6 File Offset: 0x00455AA6
	[PunRPC]
	public void OnAwakeRPC(byte JNBMEPMFOOB)
	{
		Debug.Log(string.Concat(new object[]
		{
			"RPC: 'OnAwakeRPC' Parameter: ",
			JNBMEPMFOOB,
			" PhotonView: ",
			base.photonView
		}));
	}

	// Token: 0x0600BE3E RID: 48702 RVA: 0x004578DA File Offset: 0x00455ADA
	private void IKGFIOIADLN()
	{
		if (!base.AAMNKPHHHCI().KCAOJFPDEIP())
		{
			return;
		}
		base.GMAHNPNHMFK().PBMFBOOALKA("OnPlayerGameMessage", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE3F RID: 48703 RVA: 0x00457904 File Offset: 0x00455B04
	public void NPHJLBOKJBK()
	{
		Debug.Log("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results" + base.JAEJDHHCJJO());
	}

	// Token: 0x0600BE40 RID: 48704 RVA: 0x0045791B File Offset: 0x00455B1B
	private void MFIMFMCMADK()
	{
		if (!base.OELHGNKAMEG().BGJKMGJBPFA())
		{
			return;
		}
		base.GBHNDHLAJLI().RPC("offsets", PhotonTargets.Others, new object[1]);
	}

	// Token: 0x0600BE41 RID: 48705 RVA: 0x00457945 File Offset: 0x00455B45
	private void OBPCMAFGLON()
	{
		if (!base.JAEJDHHCJJO().isMine)
		{
			return;
		}
		base.GBHNDHLAJLI().IKIJDNPJKPM("Image", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BE42 RID: 48706 RVA: 0x0045796F File Offset: 0x00455B6F
	public void HIPICMNNEFC()
	{
		Debug.Log("Error: Cannot change the name of a remote player!" + base.FFIPLLNKGEN());
	}

	// Token: 0x0600BE43 RID: 48707 RVA: 0x00457986 File Offset: 0x00455B86
	[PunRPC]
	public void OnAwakeRPC()
	{
		Debug.Log("RPC: 'OnAwakeRPC' PhotonView: " + base.photonView);
	}

	// Token: 0x0600BE44 RID: 48708 RVA: 0x0045799D File Offset: 0x00455B9D
	public void GPOFBBMIHAM()
	{
		Debug.Log("skin.no_hit" + base.AAMNKPHHHCI());
	}

	// Token: 0x0600BE45 RID: 48709 RVA: 0x004579B4 File Offset: 0x00455BB4
	public void IIOJJBNHMPB(byte JNBMEPMFOOB)
	{
		object[] array = new object[]
		{
			null,
			"float,1"
		};
		array[1] = JNBMEPMFOOB;
		array[5] = "_TimeX";
		array[0] = base.JAEJDHHCJJO();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE46 RID: 48710 RVA: 0x004579E8 File Offset: 0x00455BE8
	private void IIPMEPPIFCK()
	{
		if (!base.CIACEFBNDDJ().BGJKMGJBPFA())
		{
			return;
		}
		base.EDIJKHEMPAD().IKIJDNPJKPM("_History2LumaTex", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE47 RID: 48711 RVA: 0x00457A12 File Offset: 0x00455C12
	public void FJPHKFHHOLH()
	{
		Debug.Log("_Value" + base.GBMJAPGLMGB());
	}

	// Token: 0x0600BE48 RID: 48712 RVA: 0x00457A29 File Offset: 0x00455C29
	private void HBPLJMJAAHK()
	{
		if (!base.FFIPLLNKGEN().BGJKMGJBPFA())
		{
			return;
		}
		base.EOOCGIFFKBG().GNFNHDCJOFC("maps.", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE49 RID: 48713 RVA: 0x00457A53 File Offset: 0x00455C53
	public void EHLNCJPNFPE(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[1] = "value";
		array[0] = JNBMEPMFOOB;
		array[3] = "Horizontal";
		array[7] = base.GBMJAPGLMGB();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE4A RID: 48714 RVA: 0x00457A87 File Offset: 0x00455C87
	public void OBBENHPGDNC(byte JNBMEPMFOOB)
	{
		object[] array = new object[6];
		array[1] = "Scale environment object by the values";
		array[1] = JNBMEPMFOOB;
		array[0] = "GlassesColor";
		array[0] = base.GBMJAPGLMGB();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE4B RID: 48715 RVA: 0x00457ABB File Offset: 0x00455CBB
	private void BFIOIDMHPPL()
	{
		if (!base.GMAHNPNHMFK().BGJKMGJBPFA())
		{
			return;
		}
		base.CIACEFBNDDJ().GNFNHDCJOFC("Hidden/DepthOfField/BokehSplatting", PhotonTargets.Others, new object[1]);
	}

	// Token: 0x0600BE4C RID: 48716 RVA: 0x00457AE5 File Offset: 0x00455CE5
	public void ENHPBOFDJOI(byte JNBMEPMFOOB)
	{
		object[] array = new object[4];
		array[0] = "_ReflectionTexture0";
		array[0] = JNBMEPMFOOB;
		array[4] = "_LightIntensity";
		array[2] = base.photonView;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE4D RID: 48717 RVA: 0x00457B19 File Offset: 0x00455D19
	public void PBOICCCBFGD()
	{
		Debug.Log("JITTER" + base.BLMHOKPIMOD());
	}

	// Token: 0x0600BE4E RID: 48718 RVA: 0x00457B30 File Offset: 0x00455D30
	public void FKJBMKEHDHF(byte JNBMEPMFOOB)
	{
		object[] array = new object[]
		{
			"Send"
		};
		array[0] = JNBMEPMFOOB;
		array[1] = "_Value6";
		array[4] = base.photonView;
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE4F RID: 48719 RVA: 0x00457B64 File Offset: 0x00455D64
	private void PEMPABLNJHL()
	{
		if (!base.FFIPLLNKGEN().isMine)
		{
			return;
		}
		base.ACPGHFHDCIP().KEKKFNNMLMG("R1", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BE50 RID: 48720 RVA: 0x00457B8E File Offset: 0x00455D8E
	private void HCNECNPPEKA()
	{
		if (!base.OELHGNKAMEG().BGJKMGJBPFA())
		{
			return;
		}
		base.GMAHNPNHMFK().RPC("Fade", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE51 RID: 48721 RVA: 0x00457BB8 File Offset: 0x00455DB8
	public void CCAEAOFCNJP(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[1] = "CameraFilterPack/Drawing_Lines";
		array[1] = JNBMEPMFOOB;
		array[8] = " methods \"";
		array[7] = base.BLMHOKPIMOD();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE52 RID: 48722 RVA: 0x00457BEC File Offset: 0x00455DEC
	private void MFAMHKBMBEI()
	{
		if (!base.EDIJKHEMPAD().KCAOJFPDEIP())
		{
			return;
		}
		base.ACPGHFHDCIP().GNFNHDCJOFC("_TimeX", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE53 RID: 48723 RVA: 0x00457C16 File Offset: 0x00455E16
	private void NBGIMIDICKE()
	{
		if (!base.BLMHOKPIMOD().KCAOJFPDEIP())
		{
			return;
		}
		PhotonView photonView = base.photonView;
		string lblkdnnpaco = "UsernameText";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[0] = 0;
		photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE54 RID: 48724 RVA: 0x00457C49 File Offset: 0x00455E49
	public void JBOAOFOEDFA(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[0] = "_FresnelFadePower";
		array[1] = JNBMEPMFOOB;
		array[7] = "  |  ";
		array[0] = base.GMAHNPNHMFK();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE55 RID: 48725 RVA: 0x00457C7D File Offset: 0x00455E7D
	private void MJEFMIPLFAB()
	{
		if (!base.GMAHNPNHMFK().KCAOJFPDEIP())
		{
			return;
		}
		PhotonView photonView = base.AAMNKPHHHCI();
		string lblkdnnpaco = "maphash";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[0] = 0;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE56 RID: 48726 RVA: 0x00457CB0 File Offset: 0x00455EB0
	public void JAMIAHCMKBM()
	{
		Debug.Log("\0\0" + base.photonView);
	}

	// Token: 0x0600BE57 RID: 48727 RVA: 0x00457CC7 File Offset: 0x00455EC7
	public void OIHFGEKFICG(byte JNBMEPMFOOB)
	{
		object[] array = new object[8];
		array[0] = "player.goldarc";
		array[1] = JNBMEPMFOOB;
		array[2] = "_SprTex";
		array[0] = base.FFIPLLNKGEN();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE58 RID: 48728 RVA: 0x00457CFB File Offset: 0x00455EFB
	private void HJPCJGOEKMF()
	{
		if (!base.OELHGNKAMEG().isMine)
		{
			return;
		}
		PhotonView photonView = base.GBMJAPGLMGB();
		string lblkdnnpaco = "_TimeX";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[0] = 1;
		photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE59 RID: 48729 RVA: 0x00457D2E File Offset: 0x00455F2E
	public void IELGEACOPPN(byte JNBMEPMFOOB)
	{
		object[] array = new object[7];
		array[1] = "_Value7";
		array[1] = JNBMEPMFOOB;
		array[0] = "_NoiseTex";
		array[4] = base.GBHNDHLAJLI();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE5A RID: 48730 RVA: 0x00457D62 File Offset: 0x00455F62
	public void OPBLIOMFEGK()
	{
		Debug.Log("#tryagain" + base.ACPGHFHDCIP());
	}

	// Token: 0x0600BE5B RID: 48731 RVA: 0x00457D79 File Offset: 0x00455F79
	private void CHOPDIGHJNH()
	{
		if (!base.ACPGHFHDCIP().DOLKFPIABDD())
		{
			return;
		}
		base.CIACEFBNDDJ().MIAHMDGOOPJ("_Near", PhotonTargets.Others, new object[]
		{
			0
		});
	}

	// Token: 0x0600BE5C RID: 48732 RVA: 0x00457DAC File Offset: 0x00455FAC
	public void IDCJHBIKDAP()
	{
		Debug.Log("offsets" + base.IBKCMBIGOEJ());
	}

	// Token: 0x0600BE5D RID: 48733 RVA: 0x00457DC3 File Offset: 0x00455FC3
	public void JJDKDMAGNFD(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[0] = ": ";
		array[1] = JNBMEPMFOOB;
		array[0] = "_Value7";
		array[8] = base.AAMNKPHHHCI();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE5E RID: 48734 RVA: 0x00457DF7 File Offset: 0x00455FF7
	public void MHNBFGIMPOH(byte JNBMEPMFOOB)
	{
		object[] array = new object[6];
		array[1] = "_Value";
		array[0] = JNBMEPMFOOB;
		array[6] = "513510";
		array[0] = base.GBMJAPGLMGB();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE5F RID: 48735 RVA: 0x00457E2B File Offset: 0x0045602B
	public void CPEGEIEFJHA()
	{
		Debug.Log("Failed to Instantiate prefab:" + base.ACPGHFHDCIP());
	}

	// Token: 0x0600BE60 RID: 48736 RVA: 0x00457E42 File Offset: 0x00456042
	private void Start()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		base.photonView.RPC("OnAwakeRPC", PhotonTargets.All, new object[]
		{
			1
		});
	}

	// Token: 0x0600BE61 RID: 48737 RVA: 0x00457E75 File Offset: 0x00456075
	private void BANHFNDEPPO()
	{
		if (!base.EDIJKHEMPAD().BGJKMGJBPFA())
		{
			return;
		}
		base.GBMJAPGLMGB().KEKKFNNMLMG("1", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE62 RID: 48738 RVA: 0x00457E9F File Offset: 0x0045609F
	public void CGAHECNIBNO()
	{
		Debug.Log("_ScreenResolution" + base.AAMNKPHHHCI());
	}

	// Token: 0x0600BE63 RID: 48739 RVA: 0x00457EB6 File Offset: 0x004560B6
	private void PMPKMGKAAJH()
	{
		if (!base.BLMHOKPIMOD().KCAOJFPDEIP())
		{
			return;
		}
		base.JAEJDHHCJJO().PBMFBOOALKA("GameVolumeSlider", PhotonTargets.Others, new object[]
		{
			0
		});
	}

	// Token: 0x0600BE64 RID: 48740 RVA: 0x00457EE9 File Offset: 0x004560E9
	private void MADENBGHKDD()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		base.GMAHNPNHMFK().MIAHMDGOOPJ("player.bluelifering", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE65 RID: 48741 RVA: 0x00457F13 File Offset: 0x00456113
	private void IOMCHHBGJEC()
	{
		if (!base.GMAHNPNHMFK().isMine)
		{
			return;
		}
		base.GMAHNPNHMFK().GNFNHDCJOFC("CameraFilterPack/Blend2Camera_ColorDodge", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE66 RID: 48742 RVA: 0x00457F3D File Offset: 0x0045613D
	public void APCGLOADLNG()
	{
		Debug.Log("_Value4" + base.GBHNDHLAJLI());
	}

	// Token: 0x0600BE67 RID: 48743 RVA: 0x00457F54 File Offset: 0x00456154
	private void JNBMKLFJCEM()
	{
		if (!base.photonView.BGJKMGJBPFA())
		{
			return;
		}
		base.GBHNDHLAJLI().GNFNHDCJOFC("_TimeX", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE68 RID: 48744 RVA: 0x00457F7E File Offset: 0x0045617E
	public void MEKHEGCLGJO(byte JNBMEPMFOOB)
	{
		object[] array = new object[0];
		array[0] = "Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.";
		array[0] = JNBMEPMFOOB;
		array[5] = "_Value2";
		array[7] = base.IBKCMBIGOEJ();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE69 RID: 48745 RVA: 0x00457FB2 File Offset: 0x004561B2
	public void JEMIPIAKEHF(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[0] = "SetParticlesParticleSize";
		array[1] = JNBMEPMFOOB;
		array[0] = "Message duration multiplier. Recomended 1";
		array[7] = base.FFIPLLNKGEN();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE6A RID: 48746 RVA: 0x00457FE6 File Offset: 0x004561E6
	public void HNIOBNLBJPO()
	{
		Debug.Log("_ScreenResolution" + base.ACPGHFHDCIP());
	}

	// Token: 0x0600BE6B RID: 48747 RVA: 0x00457FFD File Offset: 0x004561FD
	private void LJEFMGOBKGE()
	{
		if (!base.EOOCGIFFKBG().BGJKMGJBPFA())
		{
			return;
		}
		base.ACPGHFHDCIP().KEKKFNNMLMG("{0:0} minute{1}, ", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE6C RID: 48748 RVA: 0x00458027 File Offset: 0x00456227
	private void MMOKKAPFGAK()
	{
		if (!base.GBHNDHLAJLI().DOLKFPIABDD())
		{
			return;
		}
		PhotonView photonView = base.EOOCGIFFKBG();
		string lblkdnnpaco = "File not found: {0}";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[1] = 0;
		photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE6D RID: 48749 RVA: 0x0045805A File Offset: 0x0045625A
	private void NCNPAKFAFOE()
	{
		if (!base.ACPGHFHDCIP().BGJKMGJBPFA())
		{
			return;
		}
		PhotonView photonView = base.EDIJKHEMPAD();
		string lblkdnnpaco = "owner: ";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[0] = 0;
		photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE6E RID: 48750 RVA: 0x0045808D File Offset: 0x0045628D
	private void LBAJLLFMMMP()
	{
		if (!base.GMAHNPNHMFK().isMine)
		{
			return;
		}
		base.GBHNDHLAJLI().IKIJDNPJKPM("_Value3", PhotonTargets.All, new object[]
		{
			0
		});
	}

	// Token: 0x0600BE6F RID: 48751 RVA: 0x004580C0 File Offset: 0x004562C0
	public void GDCFMFILBAM(byte JNBMEPMFOOB)
	{
		object[] array = new object[1];
		array[1] = "Status: ";
		array[1] = JNBMEPMFOOB;
		array[8] = "sfxVolume";
		array[6] = base.GMAHNPNHMFK();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE70 RID: 48752 RVA: 0x004580F4 File Offset: 0x004562F4
	public void DMPLGFKLMLG(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[1] = "materialsitemid[";
		array[1] = JNBMEPMFOOB;
		array[2] = "LevelInfoInputField";
		array[0] = base.AAMNKPHHHCI();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE71 RID: 48753 RVA: 0x00458128 File Offset: 0x00456328
	private void ILCFPCIPENO()
	{
		if (!base.EDIJKHEMPAD().DOLKFPIABDD())
		{
			return;
		}
		base.GBHNDHLAJLI().IKIJDNPJKPM("_FadeDistance", PhotonTargets.Others, new object[]
		{
			0
		});
	}

	// Token: 0x0600BE72 RID: 48754 RVA: 0x0045815B File Offset: 0x0045635B
	private void DMIKIDGJEFC()
	{
		if (!base.GBHNDHLAJLI().KCAOJFPDEIP())
		{
			return;
		}
		base.FFIPLLNKGEN().KEKKFNNMLMG(" but this PhotonView does not exist! View was/is ours.", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE73 RID: 48755 RVA: 0x00458185 File Offset: 0x00456385
	public void ANOGCJCCFFE()
	{
		Debug.Log("Right" + base.photonView);
	}

	// Token: 0x0600BE74 RID: 48756 RVA: 0x0045819C File Offset: 0x0045639C
	private void PHHOMLJECOJ()
	{
		if (!base.OELHGNKAMEG().BGJKMGJBPFA())
		{
			return;
		}
		base.OELHGNKAMEG().KEKKFNNMLMG("_Value2", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BE75 RID: 48757 RVA: 0x004581C6 File Offset: 0x004563C6
	private void JEEINPBLBDI()
	{
		if (!base.IBKCMBIGOEJ().DOLKFPIABDD())
		{
			return;
		}
		base.ACPGHFHDCIP().IKIJDNPJKPM("z", PhotonTargets.Others, new object[1]);
	}

	// Token: 0x0600BE76 RID: 48758 RVA: 0x004581F0 File Offset: 0x004563F0
	private void GBNOIKAPBBO()
	{
		if (!base.EDIJKHEMPAD().isMine)
		{
			return;
		}
		base.photonView.MIAHMDGOOPJ("OpAuthenticate()", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE77 RID: 48759 RVA: 0x0045821A File Offset: 0x0045641A
	public void ABMFEALMMCI()
	{
		Debug.Log("_Value2" + base.BLMHOKPIMOD());
	}

	// Token: 0x0600BE78 RID: 48760 RVA: 0x00458231 File Offset: 0x00456431
	private void LFHKGIHNONL()
	{
		if (!base.FFIPLLNKGEN().DOLKFPIABDD())
		{
			return;
		}
		base.EOOCGIFFKBG().IKIJDNPJKPM("FinalScoreSmallText", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BE79 RID: 48761 RVA: 0x0045825B File Offset: 0x0045645B
	private void OJACCGOHBGH()
	{
		if (!base.GMAHNPNHMFK().DOLKFPIABDD())
		{
			return;
		}
		base.FFIPLLNKGEN().IKIJDNPJKPM("(\\[ *\\/ *url *])", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE7A RID: 48762 RVA: 0x00458285 File Offset: 0x00456485
	public void PEGOOKMNOPH(byte JNBMEPMFOOB)
	{
		object[] array = new object[7];
		array[0] = "list";
		array[1] = JNBMEPMFOOB;
		array[8] = "_MainTex2";
		array[3] = base.GMAHNPNHMFK();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE7B RID: 48763 RVA: 0x004582B9 File Offset: 0x004564B9
	public void LAMEBFJKMBF(byte JNBMEPMFOOB)
	{
		object[] array = new object[3];
		array[1] = "Skipping region because it's not in PhotonServerSettings.EnabledRegions: ";
		array[0] = JNBMEPMFOOB;
		array[3] = "OnStatusChanged: {0} current State: {1}";
		array[0] = base.AAMNKPHHHCI();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE7C RID: 48764 RVA: 0x004582ED File Offset: 0x004564ED
	private void JOBBGDGHJMB()
	{
		if (!base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			return;
		}
		base.GMAHNPNHMFK().KEKKFNNMLMG("/?player=", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE7D RID: 48765 RVA: 0x00458317 File Offset: 0x00456517
	private void FHGKIOOMMOH()
	{
		if (!base.GBMJAPGLMGB().KCAOJFPDEIP())
		{
			return;
		}
		PhotonView photonView = base.ACPGHFHDCIP();
		string lblkdnnpaco = "float,1.5";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[1];
		array[1] = 1;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE7E RID: 48766 RVA: 0x0045834A File Offset: 0x0045654A
	private void JHPKLGGMCBL()
	{
		if (!base.FFIPLLNKGEN().DOLKFPIABDD())
		{
			return;
		}
		base.GBHNDHLAJLI().PBMFBOOALKA("[", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE7F RID: 48767 RVA: 0x00458374 File Offset: 0x00456574
	private void Awake()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		base.photonView.RPC("OnAwakeRPC", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE81 RID: 48769 RVA: 0x0045839E File Offset: 0x0045659E
	private void JILOMOBDPIA()
	{
		if (!base.EOOCGIFFKBG().DOLKFPIABDD())
		{
			return;
		}
		base.EOOCGIFFKBG().PBMFBOOALKA(".lastCheckpoint.time", PhotonTargets.Others, new object[]
		{
			0
		});
	}

	// Token: 0x0600BE82 RID: 48770 RVA: 0x004583D1 File Offset: 0x004565D1
	private void EMANBHKAONB()
	{
		if (!base.EOOCGIFFKBG().DOLKFPIABDD())
		{
			return;
		}
		base.AAMNKPHHHCI().IKIJDNPJKPM("_TimeX", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BE83 RID: 48771 RVA: 0x004583FB File Offset: 0x004565FB
	public void KFICJFBKECE(byte JNBMEPMFOOB)
	{
		object[] array = new object[]
		{
			null,
			"_Value"
		};
		array[0] = JNBMEPMFOOB;
		array[5] = "Parameter levelId must be int or string!";
		array[0] = base.AAMNKPHHHCI();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE84 RID: 48772 RVA: 0x0045842F File Offset: 0x0045662F
	public void INEJPACDDEL()
	{
		Debug.Log("SpawnObj" + base.AAMNKPHHHCI());
	}

	// Token: 0x0600BE85 RID: 48773 RVA: 0x00458446 File Offset: 0x00456646
	private void OBAIHNFOJGN()
	{
		if (!base.EOOCGIFFKBG().DOLKFPIABDD())
		{
			return;
		}
		base.GBMJAPGLMGB().PBMFBOOALKA("skin.", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE86 RID: 48774 RVA: 0x00458470 File Offset: 0x00456670
	private void EIFCCFBJKOO()
	{
		if (!base.AAMNKPHHHCI().isMine)
		{
			return;
		}
		base.EOOCGIFFKBG().PBMFBOOALKA("PLEASE WAIT", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE87 RID: 48775 RVA: 0x0045849A File Offset: 0x0045669A
	private void BMAGFLLGDPJ()
	{
		if (!base.ACPGHFHDCIP().BGJKMGJBPFA())
		{
			return;
		}
		base.AAMNKPHHHCI().RPC("_SunColor", PhotonTargets.All, new object[0]);
	}

	// Token: 0x0600BE88 RID: 48776 RVA: 0x004584C4 File Offset: 0x004566C4
	private void BHCCNFJKGPD()
	{
		if (!base.CIACEFBNDDJ().KCAOJFPDEIP())
		{
			return;
		}
		base.photonView.GNFNHDCJOFC("roomDescription", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE89 RID: 48777 RVA: 0x004584EE File Offset: 0x004566EE
	public void FCJPBNOFCNG()
	{
		Debug.Log("_Offsets" + base.JAEJDHHCJJO());
	}

	// Token: 0x0600BE8A RID: 48778 RVA: 0x00458505 File Offset: 0x00456705
	private void CFFCLAHMBAA()
	{
		if (!base.GBMJAPGLMGB().BGJKMGJBPFA())
		{
			return;
		}
		PhotonView photonView = base.EOOCGIFFKBG();
		string lblkdnnpaco = "sfxVolume";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[1] = 0;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE8B RID: 48779 RVA: 0x00458538 File Offset: 0x00456738
	public void NIEEHCGBDIJ(byte JNBMEPMFOOB)
	{
		object[] array = new object[2];
		array[0] = "[Up]";
		array[1] = JNBMEPMFOOB;
		array[2] = "owner: ";
		array[7] = base.OELHGNKAMEG();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE8C RID: 48780 RVA: 0x0045856C File Offset: 0x0045676C
	public void JDCJIMPEPGB(byte JNBMEPMFOOB)
	{
		object[] array = new object[]
		{
			"[Down]",
			JNBMEPMFOOB
		};
		array[0] = "Can't set visible when not in that room.";
		array[0] = base.FFIPLLNKGEN();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE8D RID: 48781 RVA: 0x004585A0 File Offset: 0x004567A0
	private void PIIMBOLGHOE()
	{
		if (!base.ACPGHFHDCIP().isMine)
		{
			return;
		}
		base.EOOCGIFFKBG().RPC("player.currentrank", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE8E RID: 48782 RVA: 0x004585CA File Offset: 0x004567CA
	public void BICMLHBJAJN(byte JNBMEPMFOOB)
	{
		object[] array = new object[4];
		array[0] = "22x1";
		array[0] = JNBMEPMFOOB;
		array[6] = "< true | false >";
		array[6] = base.OELHGNKAMEG();
		Debug.Log(string.Concat(array));
	}

	// Token: 0x0600BE8F RID: 48783 RVA: 0x004585FE File Offset: 0x004567FE
	private void KLILJHJNICK()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		PhotonView photonView = base.ACPGHFHDCIP();
		string lblkdnnpaco = "scn";
		PhotonTargets mpnmoonbmii = PhotonTargets.Others;
		object[] array = new object[0];
		array[1] = 1;
		photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE90 RID: 48784 RVA: 0x00458631 File Offset: 0x00456831
	private void KPOIJEKDFBE()
	{
		if (!base.GMAHNPNHMFK().BGJKMGJBPFA())
		{
			return;
		}
		base.GMAHNPNHMFK().GNFNHDCJOFC("_FarCamera", PhotonTargets.Others, new object[1]);
	}

	// Token: 0x0600BE91 RID: 48785 RVA: 0x0045865B File Offset: 0x0045685B
	public void LODNFMDBJFE()
	{
		Debug.Log(": " + base.EOOCGIFFKBG());
	}

	// Token: 0x0600BE92 RID: 48786 RVA: 0x00458672 File Offset: 0x00456872
	private void NPLCENPNJBM()
	{
		if (!base.JAEJDHHCJJO().BGJKMGJBPFA())
		{
			return;
		}
		PhotonView photonView = base.JAEJDHHCJJO();
		string lblkdnnpaco = "_Offsets";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[1] = 0;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE93 RID: 48787 RVA: 0x004586A5 File Offset: 0x004568A5
	private void DHNANELONED()
	{
		if (!base.ACPGHFHDCIP().DOLKFPIABDD())
		{
			return;
		}
		base.EDIJKHEMPAD().PBMFBOOALKA("[MapsStats] Length: ", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BE94 RID: 48788 RVA: 0x004586CF File Offset: 0x004568CF
	private void OLFNCABJBHA()
	{
		if (!base.FFIPLLNKGEN().BGJKMGJBPFA())
		{
			return;
		}
		base.EOOCGIFFKBG().MIAHMDGOOPJ(" Also make sure to disable sprite packing for this sprite.", PhotonTargets.Others, new object[1]);
	}

	// Token: 0x0600BE95 RID: 48789 RVA: 0x004586F9 File Offset: 0x004568F9
	private void AJIKPEIGACI()
	{
		if (!base.FFIPLLNKGEN().KCAOJFPDEIP())
		{
			return;
		}
		base.OELHGNKAMEG().GNFNHDCJOFC("player.crystal", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600BE96 RID: 48790 RVA: 0x00458723 File Offset: 0x00456923
	private void JDKHBGDEONK()
	{
		if (!base.OELHGNKAMEG().BGJKMGJBPFA())
		{
			return;
		}
		base.EDIJKHEMPAD().RPC("_Radius", PhotonTargets.All, new object[]
		{
			1
		});
	}

	// Token: 0x0600BE97 RID: 48791 RVA: 0x00458756 File Offset: 0x00456956
	public void EACHPFBJBNP()
	{
		Debug.Log("EnableRankingToggle" + base.GBHNDHLAJLI());
	}

	// Token: 0x0600BE98 RID: 48792 RVA: 0x0045876D File Offset: 0x0045696D
	private void MFCCNPEIOGP()
	{
		if (!base.BLMHOKPIMOD().DOLKFPIABDD())
		{
			return;
		}
		base.IBKCMBIGOEJ().GNFNHDCJOFC("Fade", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600BE99 RID: 48793 RVA: 0x00458797 File Offset: 0x00456997
	public void FCGADANGLFK()
	{
		Debug.Log("color" + base.IBKCMBIGOEJ());
	}

	// Token: 0x0600BE9A RID: 48794 RVA: 0x004587AE File Offset: 0x004569AE
	private void KDMKDEKCELE()
	{
		if (!base.IBKCMBIGOEJ().BGJKMGJBPFA())
		{
			return;
		}
		PhotonView photonView = base.OELHGNKAMEG();
		string lblkdnnpaco = "You must complete your map before submiting it to Workshop";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[0] = 0;
		photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
	}

	// Token: 0x0600BE9B RID: 48795 RVA: 0x004587E1 File Offset: 0x004569E1
	private void MKIMDFLBFOM()
	{
		if (!base.JAEJDHHCJJO().DOLKFPIABDD())
		{
			return;
		}
		PhotonView photonView = base.GBMJAPGLMGB();
		string lblkdnnpaco = "maps.";
		PhotonTargets mpnmoonbmii = PhotonTargets.All;
		object[] array = new object[0];
		array[1] = 1;
		photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
	}
}
