using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000349 RID: 841
[RequireComponent(typeof(PhotonView))]
public class NetworkCullingHandler : MonoBehaviour, IPunObservable
{
	// Token: 0x0600BDD4 RID: 48596 RVA: 0x004522C4 File Offset: 0x004504C4
	private void MJEFMIPLFAB()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BDD5 RID: 48597 RVA: 0x0045233C File Offset: 0x0045053C
	private void HBNHHPJNNIP()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "settings.enableranking";
		string text2 = "#failed: ";
		for (int i = 1; i < this.NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "CameraFilterPack/FX_Funk";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "_MatrixSpeed";
		}
		GUI.Label(new Rect(721f, (float)Screen.height - 444f, 1158f, 52f), "SetSatelliteColor" + this.LMGCEPHCNBN.group + "UsernameText", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -50
		});
		GUI.Label(new Rect(252f, (float)Screen.height - 82f, 371f, 1360f), "offsets" + text + "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -21
		});
		GUI.Label(new Rect(1744f, (float)Screen.height - 815f, 816f, 206f), "_TimeX" + text2 + "_Parasite", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 125
		});
	}

	// Token: 0x0600BDD6 RID: 48598 RVA: 0x004524C0 File Offset: 0x004506C0
	private void KKGMKGHFELO()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.DOLKFPIABDD())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(0);
		this.NBMPFGDCLEL = new List<byte>(0);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BDD7 RID: 48599 RVA: 0x0045254C File Offset: 0x0045074C
	private bool BFJNDDIFPJC()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] == this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BDD8 RID: 48600 RVA: 0x00452620 File Offset: 0x00450820
	private void GPFJMKCGHGB()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.PHOGNHBFNHA())
		{
			this.OIMFIKGNNEB();
		}
	}

	// Token: 0x0600BDD9 RID: 48601 RVA: 0x00452684 File Offset: 0x00450884
	private bool JCFIFAAIJOM()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BDDA RID: 48602 RVA: 0x00452758 File Offset: 0x00450958
	private bool GCFFKNOHJGM()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BDDB RID: 48603 RVA: 0x0045282C File Offset: 0x00450A2C
	public void CJKDMGMPMJM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDDC RID: 48604 RVA: 0x00452994 File Offset: 0x00450B94
	private void ICILLMAKLMI()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BDDD RID: 48605 RVA: 0x00452A0C File Offset: 0x00450C0C
	private bool FMILHKLNLPH()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count != this.NHLHOKCKIEF.Count || (this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions] && false);
	}

	// Token: 0x0600BDDE RID: 48606 RVA: 0x00452AE0 File Offset: 0x00450CE0
	public void GLCCIHKIOJI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDDF RID: 48607 RVA: 0x00452C48 File Offset: 0x00450E48
	private void JDKHBGDEONK()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BDE0 RID: 48608 RVA: 0x00452CC0 File Offset: 0x00450EC0
	private void CNHEENCFCMF()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BDE1 RID: 48609 RVA: 0x00452D4C File Offset: 0x00450F4C
	private bool GCECOAALNFP()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && (this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] == this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions] || true);
	}

	// Token: 0x0600BDE2 RID: 48610 RVA: 0x00452E20 File Offset: 0x00451020
	private void GFLAINNLMBO()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BDE3 RID: 48611 RVA: 0x00452EAC File Offset: 0x004510AC
	private void ONKDMMJPEMN()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.FMILHKLNLPH())
		{
			this.MMGEGAHEGIM();
		}
	}

	// Token: 0x0600BDE4 RID: 48612 RVA: 0x00452F10 File Offset: 0x00451110
	private void JODODFGLOLD()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "en";
		string text2 = "AudioClip";
		for (int i = 1; i < this.NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "Can not SetMasterClient(). Not in room or in offlineMode.";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "resetach21";
		}
		GUI.Label(new Rect(576f, (float)Screen.height - 1524f, 8f, 1969f), "float,1" + this.LMGCEPHCNBN.group + "_SoftZDistance", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -42
		});
		GUI.Label(new Rect(421f, (float)Screen.height - 225f, 1740f, 1101f), "ItemNameText" + text + "_EmissionGain", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -12
		});
		GUI.Label(new Rect(1293f, (float)Screen.height - 446f, 1065f, 569f), "/" + text2 + "_ScreenResolution", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 68
		});
	}

	// Token: 0x0600BDE5 RID: 48613 RVA: 0x00453094 File Offset: 0x00451294
	private void PCABPJAANFH()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "{0}{1}:{2}";
		string text2 = "bad";
		for (int i = 0; i < this.NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "SetParticlesColor";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "Subscribed cells:\n";
		}
		GUI.Label(new Rect(955f, (float)Screen.height - 291f, 1432f, 127f), "EditMenu" + this.LMGCEPHCNBN.group + "_RandomTexture", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -28
		});
		GUI.Label(new Rect(1092f, (float)Screen.height - 55f, 1362f, 1814f), "_Intensity" + text + "_Value", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -26
		});
		GUI.Label(new Rect(251f, (float)Screen.height - 1028f, 1155f, 649f), "_Value7" + text2 + "speed", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -50
		});
	}

	// Token: 0x0600BDE6 RID: 48614 RVA: 0x00453218 File Offset: 0x00451418
	private void INODCHEOKGF()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "The number of objects sent via a PhotonStreamQueue has to be the same each frame";
		string text2 = "_Value4";
		for (int i = 0; i < this.NBMPFGDCLEL.Count; i++)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "_ScreenResolution";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "_Value1";
		}
		GUI.Label(new Rect(637f, (float)Screen.height - 768f, 761f, 1495f), "_Value7" + this.LMGCEPHCNBN.group + "Object ID. Case-Sensitive", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -9
		});
		GUI.Label(new Rect(1260f, (float)Screen.height - 1723f, 1983f, 93f), "_VelTex" + text + "_Value", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -17
		});
		GUI.Label(new Rect(215f, (float)Screen.height - 1231f, 288f, 1269f), "LoadMapCanvas" + text2 + "menu.selectedplaymode", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 29
		});
	}

	// Token: 0x0600BDE7 RID: 48615 RVA: 0x0045339C File Offset: 0x0045159C
	private void IEHKJPADFFM()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "settings.enablehitsoundsinnormal";
		string text2 = "PossibleMapPointsText";
		for (int i = 1; i < this.NBMPFGDCLEL.Count; i++)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "_TimeX";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "_MidGrey";
		}
		GUI.Label(new Rect(681f, (float)Screen.height - 188f, 403f, 1878f), "Fade" + this.LMGCEPHCNBN.group + "return ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -102
		});
		GUI.Label(new Rect(1351f, (float)Screen.height - 999f, 1134f, 1861f), "Image" + text + "/?player=", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 38
		});
		GUI.Label(new Rect(1559f, (float)Screen.height - 1342f, 1911f, 1781f), "[SERVER] Selected mode: " + text2 + "_MaxRadiusOrKInPaper", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 26
		});
	}

	// Token: 0x0600BDE8 RID: 48616 RVA: 0x00453520 File Offset: 0x00451720
	private void AENGMPAMCFL()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.DOLKFPIABDD())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(0);
		this.NBMPFGDCLEL = new List<byte>(0);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BDE9 RID: 48617 RVA: 0x004535AC File Offset: 0x004517AC
	private bool EJEDJODNBEN()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BDEA RID: 48618 RVA: 0x00453680 File Offset: 0x00451880
	public void FOHGOGIMPJJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDEB RID: 48619 RVA: 0x004537E8 File Offset: 0x004519E8
	private void FCKIJIKNMCF()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(0);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BDEC RID: 48620 RVA: 0x00453874 File Offset: 0x00451A74
	public void LEPNLHBAHOL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDEE RID: 48622 RVA: 0x004539DC File Offset: 0x00451BDC
	public void LBDNIDJNDJK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 5)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 5)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDEF RID: 48623 RVA: 0x00453B44 File Offset: 0x00451D44
	private void GLEJGFLCLPJ()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BDF0 RID: 48624 RVA: 0x00453BBC File Offset: 0x00451DBC
	private bool MAFAKMHPAKE()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && (this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] == this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions] || true);
	}

	// Token: 0x0600BDF1 RID: 48625 RVA: 0x00453C90 File Offset: 0x00451E90
	private void HNDNDPECBPL()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.MAFAKMHPAKE())
		{
			this.NEKBANHJJJC();
		}
	}

	// Token: 0x0600BDF2 RID: 48626 RVA: 0x00453CF4 File Offset: 0x00451EF4
	private void EPJJDKJEDMM()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.MIBMPMEMPHH())
		{
			this.GEONJNILKEM();
		}
	}

	// Token: 0x0600BDF3 RID: 48627 RVA: 0x00453D58 File Offset: 0x00451F58
	public void JNCHBPPANKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 2)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDF4 RID: 48628 RVA: 0x00453EC0 File Offset: 0x004520C0
	public void EOFAACNPFDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDF5 RID: 48629 RVA: 0x00454028 File Offset: 0x00452228
	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDF6 RID: 48630 RVA: 0x00454190 File Offset: 0x00452390
	public void LMOILMNEOFE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 2)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDF7 RID: 48631 RVA: 0x004542F8 File Offset: 0x004524F8
	public void HIDJLJIEPHK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BDF8 RID: 48632 RVA: 0x00454460 File Offset: 0x00452660
	private void HOLDCFBBHHP()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.DOLKFPIABDD())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(0);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BDF9 RID: 48633 RVA: 0x004544EC File Offset: 0x004526EC
	private void FLHBCHLMOFK()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(0);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BDFA RID: 48634 RVA: 0x00454578 File Offset: 0x00452778
	private void DDOMIEPBBBI()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = " url: ";
		string text2 = "_FixDistance";
		for (int i = 0; i < this.NBMPFGDCLEL.Count; i++)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "_Value2";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "GlassDistortion";
		}
		GUI.Label(new Rect(115f, (float)Screen.height - 549f, 1014f, 1234f), "CameraFilterPack/FX_Mirror" + this.LMGCEPHCNBN.group + "PossibleMapPointsText", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 15
		});
		GUI.Label(new Rect(511f, (float)Screen.height - 114f, 1234f, 1494f), "Tab2Content" + text + "_TimeX", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -53
		});
		GUI.Label(new Rect(1834f, (float)Screen.height - 430f, 1386f, 799f), "_WaveIntensity" + text2 + "settings_bindings_controller_type", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 35
		});
	}

	// Token: 0x0600BDFB RID: 48635 RVA: 0x004546FC File Offset: 0x004528FC
	private void Update()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.PHOGNHBFNHA())
		{
			this.GEONJNILKEM();
		}
	}

	// Token: 0x0600BDFC RID: 48636 RVA: 0x00454760 File Offset: 0x00452960
	private void ANDFECJLDIO()
	{
		List<byte> list = new List<byte>(1);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BDFD RID: 48637 RVA: 0x004547EC File Offset: 0x004529EC
	private void BMIOFJFMCBG()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BDFE RID: 48638 RVA: 0x00454864 File Offset: 0x00452A64
	private void KMKLDAJLCNM()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.MAFAKMHPAKE())
		{
			this.GEONJNILKEM();
		}
	}

	// Token: 0x0600BDFF RID: 48639 RVA: 0x004548C8 File Offset: 0x00452AC8
	private void FABKIGNFECE()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.GCFFKNOHJGM())
		{
			this.GEONJNILKEM();
		}
	}

	// Token: 0x0600BE00 RID: 48640 RVA: 0x0045492C File Offset: 0x00452B2C
	private void HIDOPHINPAL()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(0);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE01 RID: 48641 RVA: 0x004549B8 File Offset: 0x00452BB8
	private void ANCKKLFPGDI()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE02 RID: 48642 RVA: 0x00454A30 File Offset: 0x00452C30
	private void KLILJHJNICK()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE03 RID: 48643 RVA: 0x00454AA8 File Offset: 0x00452CA8
	private bool MIKJANEDHJC()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count != this.NHLHOKCKIEF.Count || this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BE04 RID: 48644 RVA: 0x00454B7C File Offset: 0x00452D7C
	private void HJPCJGOEKMF()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE05 RID: 48645 RVA: 0x00454BF4 File Offset: 0x00452DF4
	private void OnEnable()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(0);
		this.NBMPFGDCLEL = new List<byte>(0);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE06 RID: 48646 RVA: 0x00454C80 File Offset: 0x00452E80
	private void OCHMKJKBAPI()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(0);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE07 RID: 48647 RVA: 0x00454D0C File Offset: 0x00452F0C
	private void CHGDMHFEJOH()
	{
		List<byte> list = new List<byte>(1);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE08 RID: 48648 RVA: 0x00454D98 File Offset: 0x00452F98
	private void KJMHKHDMKIE()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "_Value2";
		string text2 = "SetPosition";
		for (int i = 1; i < this.NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "[LevelEditorScene] Print Audio Wave: Done";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "Gameplay/satellite";
		}
		GUI.Label(new Rect(1847f, (float)Screen.height - 1866f, 470f, 318f), "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy()." + this.LMGCEPHCNBN.group + "misses", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -38
		});
		GUI.Label(new Rect(1746f, (float)Screen.height - 253f, 1442f, 1813f), "_Value2" + text + "Set Background Color", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -27
		});
		GUI.Label(new Rect(1984f, (float)Screen.height - 1501f, 889f, 1189f), "settings.volume.game" + text2 + "_MainTex2", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 11
		});
	}

	// Token: 0x0600BE09 RID: 48649 RVA: 0x00454F1C File Offset: 0x0045311C
	private void GFBOBIBIOMC()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.DOLKFPIABDD())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(0);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE0A RID: 48650 RVA: 0x00454FA8 File Offset: 0x004531A8
	private void CFFCLAHMBAA()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE0B RID: 48651 RVA: 0x00455020 File Offset: 0x00453220
	private void PAHNKEGFGHB()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE0C RID: 48652 RVA: 0x004550AC File Offset: 0x004532AC
	private void CDMHFHPNCDO()
	{
		List<byte> list = new List<byte>(1);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE0D RID: 48653 RVA: 0x00455138 File Offset: 0x00453338
	private void AAPKBNDHBLI()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.CPGDKKIDALK())
		{
			this.GEONJNILKEM();
		}
	}

	// Token: 0x0600BE0E RID: 48654 RVA: 0x0045519C File Offset: 0x0045339C
	private void FJNCHGLIEMA()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE0F RID: 48655 RVA: 0x00455214 File Offset: 0x00453414
	private bool HBFCEAFEMJH()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count != this.NHLHOKCKIEF.Count || this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] == this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BE10 RID: 48656 RVA: 0x004552E8 File Offset: 0x004534E8
	public void PIBOKINJJDJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE11 RID: 48657 RVA: 0x00455450 File Offset: 0x00453650
	private void MLLPGPANCHI()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.isMine)
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE12 RID: 48658 RVA: 0x004554DC File Offset: 0x004536DC
	private void KGNKDPBGJHC()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		string text = "Unsupported type: ";
		string text2 = "workshop.";
		for (int i = 0; i < this.NBMPFGDCLEL.Count; i++)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "CameraFilterPack/Blur_Radial_Fast";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "deleteall";
		}
		GUI.Label(new Rect(1327f, (float)Screen.height - 218f, 1561f, 1592f), "player.licenceaccepted" + this.LMGCEPHCNBN.group + "0,1,false", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 60
		});
		GUI.Label(new Rect(522f, (float)Screen.height - 1225f, 272f, 608f), "null" + text + "setbool", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 77
		});
		GUI.Label(new Rect(303f, (float)Screen.height - 1982f, 638f, 1994f), "_Params" + text2 + ",0", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 90
		});
	}

	// Token: 0x0600BE13 RID: 48659 RVA: 0x00455660 File Offset: 0x00453860
	private bool IFLHNIEIGCO()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] == this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BE14 RID: 48660 RVA: 0x00455734 File Offset: 0x00453934
	public void HDPOECGCALE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 7)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE15 RID: 48661 RVA: 0x0045589C File Offset: 0x00453A9C
	private bool CPGDKKIDALK()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions] && false;
	}

	// Token: 0x0600BE16 RID: 48662 RVA: 0x00455970 File Offset: 0x00453B70
	private void IDJHCPHEKFP()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "_TimeX";
		string text2 = "_Distortion";
		for (int i = 0; i < this.NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "_Value4";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "_NoiseTex";
		}
		GUI.Label(new Rect(348f, (float)Screen.height - 1996f, 793f, 364f), "?" + this.LMGCEPHCNBN.group + ".mp3", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 117
		});
		GUI.Label(new Rect(318f, (float)Screen.height - 1656f, 375f, 249f), "_VelocityTex" + text + "menu.enableselectormusic", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 59
		});
		GUI.Label(new Rect(1990f, (float)Screen.height - 1899f, 1289f, 1806f), "JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?" + text2 + " ", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -32
		});
	}

	// Token: 0x0600BE17 RID: 48663 RVA: 0x00455AF4 File Offset: 0x00453CF4
	private void PDKFMFCMPGE()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		string text = "GLITCH";
		string text2 = "CameraFilterPack/Distortion_Flag";
		for (int i = 0; i < this.NBMPFGDCLEL.Count; i++)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "restrictions\n\n#until: ";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + ". Possible scene loading in progress?";
		}
		GUI.Label(new Rect(408f, (float)Screen.height - 1424f, 952f, 347f), "Circle" + this.LMGCEPHCNBN.group + "VisionBlur", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -34
		});
		GUI.Label(new Rect(1415f, (float)Screen.height - 880f, 1864f, 1119f), "Y" + text + "_CurveParams", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 64
		});
		GUI.Label(new Rect(715f, (float)Screen.height - 771f, 619f, 1230f), "ENABLE_EYE_ADAPTATION" + text2 + "[DiscordController] Error {0}: {1}", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 124
		});
	}

	// Token: 0x0600BE18 RID: 48664 RVA: 0x00455C78 File Offset: 0x00453E78
	private void MBNMADBPDLL()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(0);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE19 RID: 48665 RVA: 0x00455D04 File Offset: 0x00453F04
	private void OHFOLGANOLC()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE1A RID: 48666 RVA: 0x00455D7C File Offset: 0x00453F7C
	private void PHACPKPPBJF()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "_Blood";
		string text2 = "_MainTex2";
		for (int i = 1; i < this.NBMPFGDCLEL.Count; i++)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + " ownership transfered to: ";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "Joystick1Button0";
		}
		GUI.Label(new Rect(450f, (float)Screen.height - 1967f, 412f, 1071f), "Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception" + this.LMGCEPHCNBN.group + "Join failed on GameServer. Changing back to MasterServer. Msg: ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 68
		});
		GUI.Label(new Rect(213f, (float)Screen.height - 1321f, 903f, 1138f), "z" + text + "LevelEditor/icons", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = -62
		});
		GUI.Label(new Rect(509f, (float)Screen.height - 1788f, 350f, 782f), "_TimeX" + text2 + "CameraFilterPack/Color_Contrast", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -47
		});
	}

	// Token: 0x0600BE1B RID: 48667 RVA: 0x00455F00 File Offset: 0x00454100
	public void LIFMLJFPLDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE1C RID: 48668 RVA: 0x00456068 File Offset: 0x00454268
	private void BMOFEBKGLFI()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE1D RID: 48669 RVA: 0x004560E0 File Offset: 0x004542E0
	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 2)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 3)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE1E RID: 48670 RVA: 0x00456248 File Offset: 0x00454448
	private void NEKBANHJJJC()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE1F RID: 48671 RVA: 0x004562D4 File Offset: 0x004544D4
	private void IDIIELPAMCJ()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.GCFFKNOHJGM())
		{
			this.CDMHFHPNCDO();
		}
	}

	// Token: 0x0600BE20 RID: 48672 RVA: 0x00456338 File Offset: 0x00454538
	private bool KJPNKCDLKBO()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count != this.NHLHOKCKIEF.Count || (this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions] && false);
	}

	// Token: 0x0600BE21 RID: 48673 RVA: 0x0045640C File Offset: 0x0045460C
	private void GEONJNILKEM()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE22 RID: 48674 RVA: 0x00456498 File Offset: 0x00454698
	private void AEEGKLABFLN()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.FMILHKLNLPH())
		{
			this.MMGEGAHEGIM();
		}
	}

	// Token: 0x0600BE23 RID: 48675 RVA: 0x004564FC File Offset: 0x004546FC
	private void HDDECCMEJKA()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.HNEKIANDEOI())
		{
			this.GHDBOAPJLFJ();
		}
	}

	// Token: 0x0600BE24 RID: 48676 RVA: 0x00456560 File Offset: 0x00454760
	private void MKIMDFLBFOM()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE25 RID: 48677 RVA: 0x004565D8 File Offset: 0x004547D8
	private void MMOKKAPFGAK()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE26 RID: 48678 RVA: 0x00456650 File Offset: 0x00454850
	private void EOPFFHIGFDA()
	{
		List<byte> list = new List<byte>(1);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE27 RID: 48679 RVA: 0x004566DC File Offset: 0x004548DC
	private void POJFHDFJOPE()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.KJPNKCDLKBO())
		{
			this.EOPFFHIGFDA();
		}
	}

	// Token: 0x0600BE28 RID: 48680 RVA: 0x00456740 File Offset: 0x00454940
	private void JBBCMAJIMCA()
	{
		if (this.LMGCEPHCNBN == null)
		{
			this.LMGCEPHCNBN = base.GetComponent<PhotonView>();
			if (!this.LMGCEPHCNBN.DOLKFPIABDD())
			{
				return;
			}
		}
		if (this.BMLPKAEJLDK == null)
		{
			this.BMLPKAEJLDK = UnityEngine.Object.FindObjectOfType<CullArea>();
		}
		this.NHLHOKCKIEF = new List<byte>(1);
		this.NBMPFGDCLEL = new List<byte>(1);
		this.BLPBCOCAKGG = (this.DBBNMCLENHH = base.transform.position);
	}

	// Token: 0x0600BE29 RID: 48681 RVA: 0x004567CC File Offset: 0x004549CC
	public void IFDFBONAJEG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 8)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE2A RID: 48682 RVA: 0x00456934 File Offset: 0x00454B34
	private void OFNIAEEBJCB()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE2B RID: 48683 RVA: 0x004569C0 File Offset: 0x00454BC0
	private void OJJEKKHIKAO()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "Changed config";
		string text2 = "<b><i>Map's Stats:</i></b>";
		for (int i = 1; i < this.NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "selector";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + " evLeave: ";
		}
		GUI.Label(new Rect(635f, (float)Screen.height - 755f, 1576f, 718f), "UI Extensions/UISoftAdditive" + this.LMGCEPHCNBN.group + "_ScreenResolution", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 32
		});
		GUI.Label(new Rect(1455f, (float)Screen.height - 1360f, 852f, 342f), "float,1.5" + text + "Adreno", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -61
		});
		GUI.Label(new Rect(1456f, (float)Screen.height - 1782f, 1615f, 859f), "_Fade" + text2 + "[PlayerBase] Loaded custom model: ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 99
		});
	}

	// Token: 0x0600BE2C RID: 48684 RVA: 0x00456B44 File Offset: 0x00454D44
	private bool PHOGNHBFNHA()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return false;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.GetActiveCells(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count != this.NHLHOKCKIEF.Count || this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] != this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x0600BE2D RID: 48685 RVA: 0x00456C18 File Offset: 0x00454E18
	private void GHDBOAPJLFJ()
	{
		List<byte> list = new List<byte>(1);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE2E RID: 48686 RVA: 0x00456CA4 File Offset: 0x00454EA4
	private void MMGEGAHEGIM()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE2F RID: 48687 RVA: 0x00456D30 File Offset: 0x00454F30
	private void JHPOIOELNCG()
	{
		if (!this.LMGCEPHCNBN.DOLKFPIABDD())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.PHOGNHBFNHA())
		{
			this.NEKBANHJJJC();
		}
	}

	// Token: 0x0600BE30 RID: 48688 RVA: 0x00456D94 File Offset: 0x00454F94
	public void JNENAPDBOKE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE31 RID: 48689 RVA: 0x00456EFC File Offset: 0x004550FC
	private void JFDIAAOJJEA()
	{
		if (!this.LMGCEPHCNBN.BGJKMGJBPFA())
		{
			return;
		}
		string text = "Cross";
		string text2 = "New SaveGame";
		for (int i = 1; i < this.NBMPFGDCLEL.Count; i += 0)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + "win";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + "player.mysteryitem";
		}
		GUI.Label(new Rect(1193f, (float)Screen.height - 1374f, 263f, 1131f), "[Up]" + this.LMGCEPHCNBN.group + " ", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 2
		});
		GUI.Label(new Rect(22f, (float)Screen.height - 1487f, 218f, 956f), "_Value9" + text + "ticket", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = -59
		});
		GUI.Label(new Rect(53f, (float)Screen.height - 1083f, 161f, 1470f), "BitsData" + text2 + "UseFinalGlassColor", new GUIStyle
		{
			alignment = TextAnchor.UpperCenter,
			fontSize = 100
		});
	}

	// Token: 0x0600BE32 RID: 48690 RVA: 0x00457080 File Offset: 0x00455280
	private void OIMFIKGNNEB()
	{
		List<byte> list = new List<byte>(0);
		foreach (byte item in this.NHLHOKCKIEF)
		{
			if (!this.NBMPFGDCLEL.Contains(item))
			{
				list.Add(item);
			}
		}
		PhotonNetwork.SetInterestGroups(list.ToArray(), this.NBMPFGDCLEL.ToArray());
	}

	// Token: 0x0600BE33 RID: 48691 RVA: 0x0045710C File Offset: 0x0045530C
	private void OnGUI()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		string text = "Inside cells:\n";
		string text2 = "Subscribed cells:\n";
		for (int i = 0; i < this.NBMPFGDCLEL.Count; i++)
		{
			if (i <= this.BMLPKAEJLDK.NumberOfSubdivisions)
			{
				text = text + this.NBMPFGDCLEL[i] + " | ";
			}
			text2 = text2 + this.NBMPFGDCLEL[i] + " | ";
		}
		GUI.Label(new Rect(20f, (float)Screen.height - 120f, 200f, 40f), "<color=white>PhotonView Group: " + this.LMGCEPHCNBN.group + "</color>", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 16
		});
		GUI.Label(new Rect(20f, (float)Screen.height - 100f, 200f, 40f), "<color=white>" + text + "</color>", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 16
		});
		GUI.Label(new Rect(20f, (float)Screen.height - 60f, 200f, 40f), "<color=white>" + text2 + "</color>", new GUIStyle
		{
			alignment = TextAnchor.UpperLeft,
			fontSize = 16
		});
	}

	// Token: 0x0600BE34 RID: 48692 RVA: 0x00457290 File Offset: 0x00455490
	private void Start()
	{
		if (!this.LMGCEPHCNBN.isMine)
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, true);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE35 RID: 48693 RVA: 0x00457308 File Offset: 0x00455508
	public void DEKGPEDBDJE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 7)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE36 RID: 48694 RVA: 0x00457470 File Offset: 0x00455670
	private void EHJJFJCKGAJ()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		this.DBBNMCLENHH = this.BLPBCOCAKGG;
		this.BLPBCOCAKGG = base.transform.position;
		if (this.BLPBCOCAKGG != this.DBBNMCLENHH && this.GCECOAALNFP())
		{
			this.OIMFIKGNNEB();
		}
	}

	// Token: 0x0600BE37 RID: 48695 RVA: 0x004574D4 File Offset: 0x004556D4
	private bool MIBMPMEMPHH()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count == this.NHLHOKCKIEF.Count && (this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] == this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions] || true);
	}

	// Token: 0x0600BE38 RID: 48696 RVA: 0x004575A8 File Offset: 0x004557A8
	public void AAKPEHOAMGP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 1)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_FIRST_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 4)
		{
			this.DPGILFLHKIM = ++this.DPGILFLHKIM % this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_SECOND_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
		else if (this.BMLPKAEJLDK.NumberOfSubdivisions == 6)
		{
			this.DPGILFLHKIM = (this.DPGILFLHKIM += 0) % this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER.Length;
			this.LMGCEPHCNBN.group = this.NBMPFGDCLEL[this.BMLPKAEJLDK.SUBDIVISION_THIRD_LEVEL_ORDER[this.DPGILFLHKIM]];
		}
	}

	// Token: 0x0600BE39 RID: 48697 RVA: 0x00457710 File Offset: 0x00455910
	private void FLKEJJEGCFA()
	{
		if (!this.LMGCEPHCNBN.KCAOJFPDEIP())
		{
			return;
		}
		if (PhotonNetwork.inRoom)
		{
			if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
			{
				this.LMGCEPHCNBN.group = this.BMLPKAEJLDK.FIRST_GROUP_ID;
				PhotonNetwork.SetInterestGroups(this.BMLPKAEJLDK.FIRST_GROUP_ID, false);
			}
			else
			{
				this.LMGCEPHCNBN.ObservedComponents.Add(this);
			}
		}
	}

	// Token: 0x0600BE3A RID: 48698 RVA: 0x00457788 File Offset: 0x00455988
	private bool HNEKIANDEOI()
	{
		if (this.BMLPKAEJLDK.NumberOfSubdivisions == 0)
		{
			return true;
		}
		this.NHLHOKCKIEF = new List<byte>(this.NBMPFGDCLEL);
		this.NBMPFGDCLEL = this.BMLPKAEJLDK.MDICNFNOGEC(base.transform.position);
		while (this.NBMPFGDCLEL.Count <= this.BMLPKAEJLDK.NumberOfSubdivisions)
		{
			this.NBMPFGDCLEL.Add(this.BMLPKAEJLDK.FIRST_GROUP_ID);
		}
		return this.NBMPFGDCLEL.Count != this.NHLHOKCKIEF.Count || this.NBMPFGDCLEL[this.BMLPKAEJLDK.NumberOfSubdivisions] == this.NHLHOKCKIEF[this.BMLPKAEJLDK.NumberOfSubdivisions];
	}

	// Token: 0x04001649 RID: 5705
	private int DPGILFLHKIM;

	// Token: 0x0400164A RID: 5706
	private CullArea BMLPKAEJLDK;

	// Token: 0x0400164B RID: 5707
	private List<byte> NHLHOKCKIEF;

	// Token: 0x0400164C RID: 5708
	private List<byte> NBMPFGDCLEL;

	// Token: 0x0400164D RID: 5709
	private PhotonView LMGCEPHCNBN;

	// Token: 0x0400164E RID: 5710
	private Vector3 DBBNMCLENHH;

	// Token: 0x0400164F RID: 5711
	private Vector3 BLPBCOCAKGG;
}
