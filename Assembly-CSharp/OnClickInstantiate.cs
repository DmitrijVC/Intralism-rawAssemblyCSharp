using System;
using UnityEngine;

// Token: 0x0200034D RID: 845
public class OnClickInstantiate : MonoBehaviour
{
	// Token: 0x0600BF36 RID: 48950 RVA: 0x004596B4 File Offset: 0x004578B4
	private void DAPLLJDMJCK()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(943f, 116f, 862f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(124f, 545f, 846f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF37 RID: 48951 RVA: 0x0045975C File Offset: 0x0045795C
	private void OLFFIKHJIEO()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -158), 1938f, 705f, 618f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF38 RID: 48952 RVA: 0x004597BC File Offset: 0x004579BC
	private void OBNBENFFJAC()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(28f, 703f, 321f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1671f, 236f, 1944f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF39 RID: 48953 RVA: 0x00459864 File Offset: 0x00457A64
	private void CAEGIHPNLOG()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 148), 580f, 840f, 626f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF3A RID: 48954 RVA: 0x004598C4 File Offset: 0x00457AC4
	private void HHKCCIJMGAB()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -42), 852f, 1060f, 1515f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF3B RID: 48955 RVA: 0x00459924 File Offset: 0x00457B24
	private void LEKGHGJPIJE()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 151), 535f, 1844f, 1937f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF3C RID: 48956 RVA: 0x00459984 File Offset: 0x00457B84
	private void AHNBAOIENOO()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -97), 446f, 864f, 58f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF3D RID: 48957 RVA: 0x004599E4 File Offset: 0x00457BE4
	private void JPNOHODALMI()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1315f, 1936f, 944f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1301f, 156f, 1660f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF3E RID: 48958 RVA: 0x00459A8C File Offset: 0x00457C8C
	private void NHKMALPBBAP()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(93f, 1315f, 954f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(644f, 1590f, 1327f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF3F RID: 48959 RVA: 0x00459B34 File Offset: 0x00457D34
	private void JFMFICMKIAG()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1887f, 1213f, 556f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(961f, 1206f, 716f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF40 RID: 48960 RVA: 0x00459BDC File Offset: 0x00457DDC
	private void AJCFIBPGAME()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -171), 1676f, 1566f, 1463f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF41 RID: 48961 RVA: 0x00459C3C File Offset: 0x00457E3C
	private void PCABPJAANFH()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 9), 1239f, 797f, 387f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF42 RID: 48962 RVA: 0x00459C9C File Offset: 0x00457E9C
	private void JLJHPNKKJPJ()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -69), 1063f, 770f, 738f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF43 RID: 48963 RVA: 0x00459CFC File Offset: 0x00457EFC
	private void NGGLCOLOLHF()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -67), 613f, 1860f, 139f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF44 RID: 48964 RVA: 0x00459D5C File Offset: 0x00457F5C
	private void OJJEKKHIKAO()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 132), 547f, 450f, 1586f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF45 RID: 48965 RVA: 0x00459DBC File Offset: 0x00457FBC
	private void GCLJNMOCIDM()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 148), 1076f, 1967f, 1801f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF46 RID: 48966 RVA: 0x00459E1C File Offset: 0x0045801C
	private void PDKFMFCMPGE()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 39), 1313f, 1298f, 1925f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF47 RID: 48967 RVA: 0x00459E7C File Offset: 0x0045807C
	private void LGHNKDFEOKO()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -160), 740f, 553f, 1497f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF48 RID: 48968 RVA: 0x00459EDC File Offset: 0x004580DC
	private void HFGANPKDCJI()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(709f, 1523f, 454f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1808f, 1625f, 596f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF49 RID: 48969 RVA: 0x00459F84 File Offset: 0x00458184
	private void GDNMIEHNGBL()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(765f, 863f, 972f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1705f, 1059f, 1314f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF4A RID: 48970 RVA: 0x0045A02C File Offset: 0x0045822C
	private void KOCIIOKHKME()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 194), 808f, 1932f, 489f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF4B RID: 48971 RVA: 0x0045A08C File Offset: 0x0045828C
	private void DBDCIAIJOKG()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(416f, 558f, 1874f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1249f, 1060f, 1122f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF4C RID: 48972 RVA: 0x0045A134 File Offset: 0x00458334
	private void OAGAGCMFGOM()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -11), 1293f, 53f, 445f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF4D RID: 48973 RVA: 0x0045A194 File Offset: 0x00458394
	private void MILJCGDAPKA()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(709f, 594f, 1758f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1861f, 1470f, 679f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF4E RID: 48974 RVA: 0x0045A23C File Offset: 0x0045843C
	private void CJFHNNICLEN()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1075f, 1423f, 1336f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(525f, 34f, 1703f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF4F RID: 48975 RVA: 0x0045A2E4 File Offset: 0x004584E4
	private void OnClick()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(0f, 5f, 0f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF51 RID: 48977 RVA: 0x0045A3B0 File Offset: 0x004585B0
	private void OGAIIBPLJBB()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 127), 1433f, 177f, 229f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF52 RID: 48978 RVA: 0x0045A410 File Offset: 0x00458610
	private void OnGUI()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 180), 0f, 180f, 50f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF53 RID: 48979 RVA: 0x0045A470 File Offset: 0x00458670
	private void LAOCNFBGEDE()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(871f, 1324f, 1427f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1273f, 733f, 1506f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF54 RID: 48980 RVA: 0x0045A518 File Offset: 0x00458718
	private void DJAABMENCCB()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1201f, 1906f, 674f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(881f, 1183f, 409f), Quaternion.identity, 0);
		}
	}

	// Token: 0x0600BF55 RID: 48981 RVA: 0x0045A5C0 File Offset: 0x004587C0
	private void CPJBNBJMJFA()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 134), 1333f, 511f, 1633f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF56 RID: 48982 RVA: 0x0045A620 File Offset: 0x00458820
	private void GGJKHODKNOC()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 112), 1999f, 1838f, 1954f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF57 RID: 48983 RVA: 0x0045A680 File Offset: 0x00458880
	private void CMOBHGHIBKL()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(568f, 396f, 820f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(298f, 78f, 1272f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF58 RID: 48984 RVA: 0x0045A728 File Offset: 0x00458928
	private void BCODHAOJLJL()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 125), 1786f, 1920f, 118f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF59 RID: 48985 RVA: 0x0045A788 File Offset: 0x00458988
	private void PCHKMGNOEDF()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 0)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1021f, 1718f, 1700f), Quaternion.identity, 1, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(472f, 1624f, 489f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF5A RID: 48986 RVA: 0x0045A830 File Offset: 0x00458A30
	private void NMHIDAOMOGO()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 117), 18f, 299f, 1470f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF5B RID: 48987 RVA: 0x0045A890 File Offset: 0x00458A90
	private void OGBJNAAAEGI()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -136), 1471f, 301f, 425f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF5C RID: 48988 RVA: 0x0045A8F0 File Offset: 0x00458AF0
	private void APCENGAAHMC()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -40), 896f, 1316f, 170f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF5D RID: 48989 RVA: 0x0045A950 File Offset: 0x00458B50
	private void HBNHHPJNNIP()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -138), 937f, 553f, 738f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF5E RID: 48990 RVA: 0x0045A9B0 File Offset: 0x00458BB0
	private void EOJGCJABGNC()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 117), 1211f, 440f, 850f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF5F RID: 48991 RVA: 0x0045AA10 File Offset: 0x00458C10
	private void GHDFEDMLPCB()
	{
		if (!PhotonNetwork.inRoom)
		{
			return;
		}
		int instantiateType = this.InstantiateType;
		if (instantiateType != 0)
		{
			if (instantiateType == 1)
			{
				PhotonNetwork.InstantiateSceneObject(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(720f, 1015f, 1686f), Quaternion.identity, 0, null);
			}
		}
		else
		{
			PhotonNetwork.Instantiate(this.Prefab.name, InputToEvent.inputHitPos + new Vector3(1160f, 520f, 1947f), Quaternion.identity, 1);
		}
	}

	// Token: 0x0600BF60 RID: 48992 RVA: 0x0045AAB8 File Offset: 0x00458CB8
	private void ADLAFICKCFG()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 61), 1652f, 1371f, 1188f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF61 RID: 48993 RVA: 0x0045AB18 File Offset: 0x00458D18
	private void DDOMIEPBBBI()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - 131), 1849f, 682f, 898f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[1]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x0600BF62 RID: 48994 RVA: 0x0045AB78 File Offset: 0x00458D78
	private void LKFBADCLLML()
	{
		if (this.showGui)
		{
			GUILayout.BeginArea(new Rect((float)(Screen.width - -34), 1818f, 907f, 364f));
			this.InstantiateType = GUILayout.Toolbar(this.InstantiateType, this.PDBHEIPKPIN, new GUILayoutOption[0]);
			GUILayout.EndArea();
		}
	}

	// Token: 0x04001655 RID: 5717
	public GameObject Prefab;

	// Token: 0x04001656 RID: 5718
	public int InstantiateType;

	// Token: 0x04001657 RID: 5719
	private string[] PDBHEIPKPIN = new string[]
	{
		"Mine",
		"Scene"
	};

	// Token: 0x04001658 RID: 5720
	public bool showGui;
}
