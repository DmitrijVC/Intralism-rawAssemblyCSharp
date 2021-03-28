using System;
using UnityEngine;

// Token: 0x02000356 RID: 854
[RequireComponent(typeof(InputToEvent))]
public class PointedAtGameObjectInfo : MonoBehaviour
{
	// Token: 0x0600C0CC RID: 49356 RVA: 0x00463CA4 File Offset: 0x00461EA4
	private void CAEGIHPNLOG()
	{
		if (InputToEvent.KKKHLHDPFHE() != null)
		{
			PhotonView photonView = InputToEvent.CDAGDJMAHLH().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 26f, (float)Screen.height - Input.mousePosition.y - 813f, 649f, 1470f), string.Format("CameraFilterPack/Light_Rainbow2", photonView.viewID, (!photonView.LIDEPDFOMFC()) ? string.Empty : "checkpoint", (!photonView.isMine) ? ("GenerationMenu" + photonView.ownerId) : "_Offsets"));
			}
		}
	}

	// Token: 0x0600C0CD RID: 49357 RVA: 0x00463D74 File Offset: 0x00461F74
	private void AHNBAOIENOO()
	{
		if (InputToEvent.JHMGPBIPOFP() != null)
		{
			PhotonView photonView = InputToEvent.goPointedAt.GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 523f, (float)Screen.height - Input.mousePosition.y - 388f, 719f, 1490f), string.Format("#rt", photonView.viewID, (!photonView.NADJFHDOFGD()) ? string.Empty : "Tab2Content", (!photonView.KCAOJFPDEIP()) ? ("curScn" + photonView.ownerId) : "_MatrixSpeed"));
			}
		}
	}

	// Token: 0x0600C0CE RID: 49358 RVA: 0x00463E44 File Offset: 0x00462044
	private void KOCIIOKHKME()
	{
		if (InputToEvent.EPNIEGKMAHG() != null)
		{
			PhotonView photonView = InputToEvent.HKPJGDBCCIJ().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 992f, (float)Screen.height - Input.mousePosition.y - 552f, 1418f, 1093f), string.Format("CameraFilterPack/VHS_Tracking", photonView.EIMHMIJGMHG(), (!photonView.LIDEPDFOMFC()) ? string.Empty : "_Value", (!photonView.isMine) ? ("_Val" + photonView.ownerId) : "CameraFilterPack/Blur_Bloom"));
			}
		}
	}

	// Token: 0x0600C0CF RID: 49359 RVA: 0x00463F14 File Offset: 0x00462114
	private void OnGUI()
	{
		if (InputToEvent.goPointedAt != null)
		{
			PhotonView photonView = InputToEvent.goPointedAt.GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 5f, (float)Screen.height - Input.mousePosition.y - 15f, 300f, 30f), string.Format("ViewID {0} {1}{2}", photonView.viewID, (!photonView.isSceneView) ? string.Empty : "scene ", (!photonView.isMine) ? ("owner: " + photonView.ownerId) : "mine"));
			}
		}
	}

	// Token: 0x0600C0D0 RID: 49360 RVA: 0x00463FE4 File Offset: 0x004621E4
	private void OLFFIKHJIEO()
	{
		if (InputToEvent.JHMGPBIPOFP() != null)
		{
			PhotonView photonView = InputToEvent.KKKHLHDPFHE().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 496f, (float)Screen.height - Input.mousePosition.y - 353f, 1221f, 1661f), string.Format("<command>", photonView.KINIHBOKFJH(), (!photonView.isSceneView) ? string.Empty : "_TimeX", (!photonView.KCAOJFPDEIP()) ? ("[Left]" + photonView.ownerId) : "_BokehParams"));
			}
		}
	}

	// Token: 0x0600C0D1 RID: 49361 RVA: 0x004640B4 File Offset: 0x004622B4
	private void GCLJNMOCIDM()
	{
		if (InputToEvent.goPointedAt != null)
		{
			PhotonView photonView = InputToEvent.goPointedAt.GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1381f, (float)Screen.height - Input.mousePosition.y - 166f, 1770f, 1837f), string.Format("warning: Audio Source: ", photonView.EIMHMIJGMHG(), (!photonView.LIDEPDFOMFC()) ? string.Empty : "_Blend", (!photonView.KCAOJFPDEIP()) ? ("HitInRelaxMusicToggle" + photonView.ownerId) : "list"));
			}
		}
	}

	// Token: 0x0600C0D3 RID: 49363 RVA: 0x00464184 File Offset: 0x00462384
	private void HHKCCIJMGAB()
	{
		if (InputToEvent.BHMCMOMJNEB() != null)
		{
			PhotonView photonView = InputToEvent.CDAGDJMAHLH().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1057f, (float)Screen.height - Input.mousePosition.y - 1538f, 1409f, 1145f), string.Format("maps.", photonView.NPPEFODKHKN(), (!photonView.isSceneView) ? string.Empty : ">", (!photonView.isMine) ? ("88f00bdf0ad61b16b803971ebe071962" + photonView.ownerId) : "Anomaly_Intensity"));
			}
		}
	}

	// Token: 0x0600C0D4 RID: 49364 RVA: 0x00464254 File Offset: 0x00462454
	private void MHCDJFCKPEL()
	{
		if (InputToEvent.JHMGPBIPOFP() != null)
		{
			PhotonView photonView = InputToEvent.goPointedAt.GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 579f, (float)Screen.height - Input.mousePosition.y - 1254f, 547f, 1332f), string.Format("icon.png", photonView.EIMHMIJGMHG(), (!photonView.isSceneView) ? string.Empty : "Spawn ark to be pressed at this time", (!photonView.DOLKFPIABDD()) ? (".lastCheckpoint.bgcolor" + photonView.ownerId) : " cannot be used as a 3D LUT."));
			}
		}
	}

	// Token: 0x0600C0D5 RID: 49365 RVA: 0x00464324 File Offset: 0x00462524
	private void OJJEKKHIKAO()
	{
		if (InputToEvent.ALBDFMNBNMM() != null)
		{
			PhotonView photonView = InputToEvent.ALBDFMNBNMM().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1204f, (float)Screen.height - Input.mousePosition.y - 1718f, 1870f, 1302f), string.Format("SetParticlesCountPerBeat", photonView.viewID, (!photonView.FJEMLGIGOCJ()) ? string.Empty : "[PlayerBase] SpawnObj error: ", (!photonView.KCAOJFPDEIP()) ? ("FPSToggle" + photonView.ownerId) : "SpeedSlider"));
			}
		}
	}

	// Token: 0x0600C0D6 RID: 49366 RVA: 0x004643F4 File Offset: 0x004625F4
	private void LKFBADCLLML()
	{
		if (InputToEvent.ALBDFMNBNMM() != null)
		{
			PhotonView photonView = InputToEvent.EPNIEGKMAHG().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 429f, (float)Screen.height - Input.mousePosition.y - 578f, 512f, 1862f), string.Format("_Params1", photonView.KINIHBOKFJH(), (!photonView.LIDEPDFOMFC()) ? string.Empty : "_TimeX", (!photonView.KCAOJFPDEIP()) ? ("Set sun colors" + photonView.ownerId) : "RecieveChatActionMessage"));
			}
		}
	}

	// Token: 0x0600C0D7 RID: 49367 RVA: 0x004644C4 File Offset: 0x004626C4
	private void EOJGCJABGNC()
	{
		if (InputToEvent.NLBLELFIJJC() != null)
		{
			PhotonView photonView = InputToEvent.NLBLELFIJJC().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 846f, (float)Screen.height - Input.mousePosition.y - 1835f, 1569f, 1950f), string.Format("GameScene", photonView.NPPEFODKHKN(), (!photonView.NADJFHDOFGD()) ? string.Empty : "red", (!photonView.BGJKMGJBPFA()) ? ("float,0" + photonView.ownerId) : "ShowTitle"));
			}
		}
	}

	// Token: 0x0600C0D8 RID: 49368 RVA: 0x00464594 File Offset: 0x00462794
	private void OAGAGCMFGOM()
	{
		if (InputToEvent.goPointedAt != null)
		{
			PhotonView photonView = InputToEvent.NLBLELFIJJC().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1733f, (float)Screen.height - Input.mousePosition.y - 244f, 1181f, 110f), string.Format("_Value", photonView.viewID, (!photonView.NADJFHDOFGD()) ? string.Empty : "No Camera attached!", (!photonView.isMine) ? ("music.ogg" + photonView.ownerId) : "Clears the console and prints the logs in the specified range"));
			}
		}
	}

	// Token: 0x0600C0D9 RID: 49369 RVA: 0x00464664 File Offset: 0x00462864
	private void KLEHHODOCLD()
	{
		if (InputToEvent.KKKHLHDPFHE() != null)
		{
			PhotonView photonView = InputToEvent.KKKHLHDPFHE().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 504f, (float)Screen.height - Input.mousePosition.y - 3f, 365f, 256f), string.Format("\t", photonView.KINIHBOKFJH(), (!photonView.LIDEPDFOMFC()) ? string.Empty : "_Value", (!photonView.BGJKMGJBPFA()) ? ("\r" + photonView.ownerId) : "Down "));
			}
		}
	}

	// Token: 0x0600C0DA RID: 49370 RVA: 0x00464734 File Offset: 0x00462934
	private void JODODFGLOLD()
	{
		if (InputToEvent.KKKHLHDPFHE() != null)
		{
			PhotonView photonView = InputToEvent.JHMGPBIPOFP().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1176f, (float)Screen.height - Input.mousePosition.y - 1494f, 49f, 1919f), string.Format("CameraFilterPack/Distortion_Dissipation", photonView.NPPEFODKHKN(), (!photonView.isSceneView) ? string.Empty : "Search: ", (!photonView.KCAOJFPDEIP()) ? ("_Value" + photonView.ownerId) : "_Value2"));
			}
		}
	}

	// Token: 0x0600C0DB RID: 49371 RVA: 0x00464804 File Offset: 0x00462A04
	private void NGGLCOLOLHF()
	{
		if (InputToEvent.EPNIEGKMAHG() != null)
		{
			PhotonView photonView = InputToEvent.KKKHLHDPFHE().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1157f, (float)Screen.height - Input.mousePosition.y - 1800f, 1952f, 1530f), string.Format("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", photonView.EIMHMIJGMHG(), (!photonView.NADJFHDOFGD()) ? string.Empty : "SpawnObj", (!photonView.DOLKFPIABDD()) ? ("0x" + photonView.ownerId) : "_TimeX"));
			}
		}
	}

	// Token: 0x0600C0DC RID: 49372 RVA: 0x004648D4 File Offset: 0x00462AD4
	private void LGHNKDFEOKO()
	{
		if (InputToEvent.ALBDFMNBNMM() != null)
		{
			PhotonView photonView = InputToEvent.GOPJFDFJDEE().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 119f, (float)Screen.height - Input.mousePosition.y - 1315f, 1109f, 420f), string.Format("_Value", photonView.viewID, (!photonView.FJEMLGIGOCJ()) ? string.Empty : ": ", (!photonView.KCAOJFPDEIP()) ? ("updating" + photonView.ownerId) : "_BlurVector"));
			}
		}
	}

	// Token: 0x0600C0DD RID: 49373 RVA: 0x004649A4 File Offset: 0x00462BA4
	private void PDKFMFCMPGE()
	{
		if (InputToEvent.goPointedAt != null)
		{
			PhotonView photonView = InputToEvent.KKKHLHDPFHE().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 146f, (float)Screen.height - Input.mousePosition.y - 839f, 1680f, 1596f), string.Format("PublishMapButton", photonView.KINIHBOKFJH(), (!photonView.FJEMLGIGOCJ()) ? string.Empty : "JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", (!photonView.KCAOJFPDEIP()) ? ("\"\"" + photonView.ownerId) : "float"));
			}
		}
	}

	// Token: 0x0600C0DE RID: 49374 RVA: 0x00464A74 File Offset: 0x00462C74
	private void KCDLPGIDHCK()
	{
		if (InputToEvent.KKKHLHDPFHE() != null)
		{
			PhotonView photonView = InputToEvent.BHMCMOMJNEB().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1553f, (float)Screen.height - Input.mousePosition.y - 3f, 627f, 723f), string.Format("BitsData", photonView.KINIHBOKFJH(), (!photonView.NADJFHDOFGD()) ? string.Empty : "\" error: ", (!photonView.isMine) ? ("itemdefid[0]" + photonView.ownerId) : ",viewkeys"));
			}
		}
	}

	// Token: 0x0600C0DF RID: 49375 RVA: 0x00464B44 File Offset: 0x00462D44
	private void PJCIENAGBGH()
	{
		if (InputToEvent.NLBLELFIJJC() != null)
		{
			PhotonView photonView = InputToEvent.ALBDFMNBNMM().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 108f, (float)Screen.height - Input.mousePosition.y - 1795f, 1873f, 7f), string.Format("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", photonView.EIMHMIJGMHG(), (!photonView.FJEMLGIGOCJ()) ? string.Empty : "Scenes List:", (!photonView.DOLKFPIABDD()) ? ("_Offsets" + photonView.ownerId) : " not exist"));
			}
		}
	}

	// Token: 0x0600C0E0 RID: 49376 RVA: 0x00464C14 File Offset: 0x00462E14
	private void DDOMIEPBBBI()
	{
		if (InputToEvent.BHMCMOMJNEB() != null)
		{
			PhotonView photonView = InputToEvent.GOPJFDFJDEE().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 519f, (float)Screen.height - Input.mousePosition.y - 297f, 142f, 1728f), string.Format("ArcsHitsoundTimeDelaySlider", photonView.NPPEFODKHKN(), (!photonView.FJEMLGIGOCJ()) ? string.Empty : ".highscore", (!photonView.KCAOJFPDEIP()) ? ("GameModeText" + photonView.ownerId) : "_TimeX"));
			}
		}
	}

	// Token: 0x0600C0E1 RID: 49377 RVA: 0x00464CE4 File Offset: 0x00462EE4
	private void OKKKCIAIABC()
	{
		if (InputToEvent.KKKHLHDPFHE() != null)
		{
			PhotonView photonView = InputToEvent.GOPJFDFJDEE().GetPhotonView();
			if (photonView != null)
			{
				GUI.Label(new Rect(Input.mousePosition.x + 1515f, (float)Screen.height - Input.mousePosition.y - 1387f, 1611f, 1914f), string.Format(" cannot be used as a 3D LUT.", photonView.EIMHMIJGMHG(), (!photonView.FJEMLGIGOCJ()) ? string.Empty : "Network destroy Instantiated GO: ", (!photonView.KCAOJFPDEIP()) ? ("GlassesColor2" + photonView.ownerId) : "GlassesColor"));
			}
		}
	}
}
