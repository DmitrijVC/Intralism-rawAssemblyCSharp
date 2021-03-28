using System;
using AudioVisualizer;
using UnityEngine;

// Token: 0x020003BD RID: 957
public class InventoryListElementButton : MonoBehaviour
{
	// Token: 0x0600D776 RID: 55158 RVA: 0x004CE8A6 File Offset: 0x004CCAA6
	public void ACDBKEOINLH()
	{
		if (this.infoCanvas)
		{
			this.infoCanvas.SetActive(this.infoCanvas.activeSelf);
		}
	}

	// Token: 0x0600D777 RID: 55159 RVA: 0x004CE8D4 File Offset: 0x004CCAD4
	public void GAIOOLFFAFI()
	{
		if (this.itemData.item.type == (InventoryItemType)5)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.JFGOMIIHHMK(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.MenuTheme)
		{
			this.isSelected = false;
			this.DKOMMIKCPKH();
			if (this.itemData.item.type == (InventoryItemType)7)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("_Curve" + this.itemData.item.id + ".lastCheckpoint.perfectHits");
				GameObject.Find("_ExposureAdjustment").GetComponent<AudioSampler>().Init(ojcilkfonmh, 737f, false);
			}
			if (this.itemData.item.type == (InventoryItemType)7)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().LHIEKHPLMFI();
			}
		}
	}

	// Token: 0x0600D778 RID: 55160 RVA: 0x004CE9E0 File Offset: 0x004CCBE0
	public void DBENNOKBPOJ()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D779 RID: 55161 RVA: 0x004CEA40 File Offset: 0x004CCC40
	public void AIJGAJIOJDJ()
	{
		if (this.itemData != null && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.MenuTheme)
		{
			this.isSelected = (Singleton<ItemsHandler>.Instance.KOBNGLOLJHF(this.itemData.item.type) == this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D77A RID: 55162 RVA: 0x004CEAD4 File Offset: 0x004CCCD4
	public void ONNJFFAFGGN()
	{
		if (this.itemData.item.type == (InventoryItemType)7)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.BGBONLPDHKH(1, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)5)
		{
			this.isSelected = false;
			this.EGDEEKCHHDB();
			if (this.itemData.item.type == (InventoryItemType)8)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("SUBMIT" + this.itemData.item.id + "CameraFilterPack/Antialiasing_FXAA");
				GameObject.Find("BlockSize").GetComponent<AudioSampler>().Init(ojcilkfonmh, 502f, false);
			}
			if (this.itemData.item.type == (InventoryItemType)8)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().PIEPPKMBJHI();
			}
		}
	}

	// Token: 0x0600D77B RID: 55163 RVA: 0x004CEBDD File Offset: 0x004CCDDD
	public void MMECHKJKHIP()
	{
		if (this.infoCanvas)
		{
			this.infoCanvas.SetActive(!this.infoCanvas.activeSelf);
		}
	}

	// Token: 0x0600D77C RID: 55164 RVA: 0x004CEC08 File Offset: 0x004CCE08
	public void FHPNIFPJKCK()
	{
		if (this.itemData.item.type == (InventoryItemType)7)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.JIMODLHJFLN(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Player)
		{
			this.isSelected = false;
			this.DKOMMIKCPKH();
			if (this.itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("CameraFilterPack/TV_WideScreenVertical" + this.itemData.item.id + "_Value2");
				GameObject.Find("_ColorBuffer").GetComponent<AudioSampler>().Init(ojcilkfonmh, 1134f, true);
			}
			if (this.itemData.item.type == InventoryItemType.Other)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().FEJAAGGMBOE();
			}
		}
	}

	// Token: 0x0600D77D RID: 55165 RVA: 0x004CED14 File Offset: 0x004CCF14
	public void Update()
	{
		if (this.itemData != null && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Ticket)
		{
			this.isSelected = (Singleton<ItemsHandler>.Instance.EnquippedItem(this.itemData.item.type) == this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D77E RID: 55166 RVA: 0x004CEDA8 File Offset: 0x004CCFA8
	public void EAMCGODKIHI()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.JLEENFEIKHB(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D77F RID: 55167 RVA: 0x004CEE08 File Offset: 0x004CD008
	public void UpdateBadge()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D780 RID: 55168 RVA: 0x004CEE68 File Offset: 0x004CD068
	public void CMOBHGHIBKL()
	{
		if (this.itemData.item.type == InventoryItemType.Player)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)8)
		{
			this.isSelected = true;
			this.AGKAOPFPEOM();
			if (this.itemData.item.type == (InventoryItemType)8)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("_FixDistance" + this.itemData.item.id + "#md5submitionfailed: ");
				GameObject.Find("LevelURLInputField").GetComponent<AudioSampler>().Init(ojcilkfonmh, 1792f, false);
			}
			if (this.itemData.item.type == InventoryItemType.Player)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().PFMJPIJONIP();
			}
		}
	}

	// Token: 0x0600D781 RID: 55169 RVA: 0x004CE8A6 File Offset: 0x004CCAA6
	public void NALIFFCOCMN()
	{
		if (this.infoCanvas)
		{
			this.infoCanvas.SetActive(this.infoCanvas.activeSelf);
		}
	}

	// Token: 0x0600D782 RID: 55170 RVA: 0x004CEF74 File Offset: 0x004CD174
	public void DJAABMENCCB()
	{
		if (this.itemData.item.type == InventoryItemType.MenuTheme)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)8)
		{
			this.isSelected = true;
			this.DKOMMIKCPKH();
			if (this.itemData.item.type == InventoryItemType.Other)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("_SSAO" + this.itemData.item.id + "ConnectToRegion: ");
				GameObject.Find("_ScreenResolution").GetComponent<AudioSampler>().Init(ojcilkfonmh, 614f, true);
			}
			if (this.itemData.item.type == (InventoryItemType)6)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().FEJAAGGMBOE();
			}
		}
	}

	// Token: 0x0600D783 RID: 55171 RVA: 0x004CF080 File Offset: 0x004CD280
	public void JHPOIOELNCG()
	{
		if (this.itemData != null && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Other)
		{
			this.isSelected = (Singleton<ItemsHandler>.Instance.ILHNOCIBMHK(this.itemData.item.type) == this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D784 RID: 55172 RVA: 0x004CF114 File Offset: 0x004CD314
	public void KBOKCPHKCMI()
	{
		if (this.itemData.item.type == InventoryItemType.Other)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.LCJIGDBJEBC(1, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)6)
		{
			this.isSelected = false;
			this.EGDEEKCHHDB();
			if (this.itemData.item.type == (InventoryItemType)7)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("Set crosshair emission (glow)" + this.itemData.item.id + "[PlayerBase] New highscore");
				GameObject.Find("_MainTex").GetComponent<AudioSampler>().Init(ojcilkfonmh, 279f, true);
			}
			if (this.itemData.item.type == (InventoryItemType)5)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().LKEPIEEIMAE();
			}
		}
	}

	// Token: 0x0600D785 RID: 55173 RVA: 0x004CF220 File Offset: 0x004CD420
	public void DKOMMIKCPKH()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D786 RID: 55174 RVA: 0x004CF280 File Offset: 0x004CD480
	public void FABMDEHEDNO()
	{
		if (this.itemData != null && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)6)
		{
			this.isSelected = (Singleton<ItemsHandler>.Instance.EnquippedItem(this.itemData.item.type) == this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D787 RID: 55175 RVA: 0x004CEBDD File Offset: 0x004CCDDD
	public void ToggleInfo()
	{
		if (this.infoCanvas)
		{
			this.infoCanvas.SetActive(!this.infoCanvas.activeSelf);
		}
	}

	// Token: 0x0600D788 RID: 55176 RVA: 0x004CF314 File Offset: 0x004CD514
	public void FHGDNGBIFGF()
	{
		if (this.itemData.item.type == (InventoryItemType)5)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.BGBONLPDHKH(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Other)
		{
			this.isSelected = false;
			this.DBENNOKBPOJ();
			if (this.itemData.item.type == InventoryItemType.Other)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("/" + this.itemData.item.id + "OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
				GameObject.Find("NewMapHandsCountSlider").GetComponent<AudioSampler>().Init(ojcilkfonmh, 252f, false);
			}
			if (this.itemData.item.type == (InventoryItemType)6)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().JHCJHPNAPDI();
			}
		}
	}

	// Token: 0x0600D789 RID: 55177 RVA: 0x004CF420 File Offset: 0x004CD620
	public void HBNGFJBHLBE()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D78A RID: 55178 RVA: 0x004CF480 File Offset: 0x004CD680
	public void AGKAOPFPEOM()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D78B RID: 55179 RVA: 0x004CF4E0 File Offset: 0x004CD6E0
	public void FFBELAHLKDP()
	{
		if (this.itemData.item.type == InventoryItemType.Shader)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.JIMODLHJFLN(1, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)7)
		{
			this.isSelected = false;
			this.NBHKJJPLLHE();
			if (this.itemData.item.type == (InventoryItemType)5)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("_PixelsPerMeterAtOneMeter" + this.itemData.item.id + "_Visualize");
				GameObject.Find("OxOD.lastPath").GetComponent<AudioSampler>().Init(ojcilkfonmh, 1359f, true);
			}
			if (this.itemData.item.type == InventoryItemType.Shader)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().ALKBNPMCEOM();
			}
		}
	}

	// Token: 0x0600D78C RID: 55180 RVA: 0x004CF5EC File Offset: 0x004CD7EC
	public void EGDEEKCHHDB()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D78D RID: 55181 RVA: 0x004CF64C File Offset: 0x004CD84C
	public void OnClick()
	{
		if (this.itemData.item.type == InventoryItemType.Ticket)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.ShowManager(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Ticket)
		{
			this.isSelected = true;
			this.UpdateBadge();
			if (this.itemData.item.type == InventoryItemType.MenuTheme)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("Items/" + this.itemData.item.id + "/theme");
				GameObject.Find("AudioSampler").GetComponent<AudioSampler>().Init(ojcilkfonmh, 0f, true);
			}
			if (this.itemData.item.type == InventoryItemType.Shader)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().Init();
			}
		}
	}

	// Token: 0x0600D78E RID: 55182 RVA: 0x004CF758 File Offset: 0x004CD958
	public void NHKMALPBBAP()
	{
		if (this.itemData.item.type == (InventoryItemType)8)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.JFGOMIIHHMK(1, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)8)
		{
			this.isSelected = false;
			this.DBENNOKBPOJ();
			if (this.itemData.item.type == (InventoryItemType)5)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("_TexelOffsetScale" + this.itemData.item.id + "Joystick1Button4");
				GameObject.Find("new round").GetComponent<AudioSampler>().Init(ojcilkfonmh, 1603f, false);
			}
			if (this.itemData.item.type == InventoryItemType.Other)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().PMAGMPCMGPB();
			}
		}
	}

	// Token: 0x0600D78F RID: 55183 RVA: 0x004CE8A6 File Offset: 0x004CCAA6
	public void FPEJJDJDHHD()
	{
		if (this.infoCanvas)
		{
			this.infoCanvas.SetActive(this.infoCanvas.activeSelf);
		}
	}

	// Token: 0x0600D790 RID: 55184 RVA: 0x004CF864 File Offset: 0x004CDA64
	public void JOLABCPNJGF()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D792 RID: 55186 RVA: 0x004CF8C4 File Offset: 0x004CDAC4
	public void JAAJECBCCFM()
	{
		if (this.itemData != null && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.Ticket)
		{
			this.isSelected = (Singleton<ItemsHandler>.Instance.KOBNGLOLJHF(this.itemData.item.type) == this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D793 RID: 55187 RVA: 0x004CEBDD File Offset: 0x004CCDDD
	public void PHLEPJNOBBN()
	{
		if (this.infoCanvas)
		{
			this.infoCanvas.SetActive(!this.infoCanvas.activeSelf);
		}
	}

	// Token: 0x0600D794 RID: 55188 RVA: 0x004CF958 File Offset: 0x004CDB58
	public void DBDCIAIJOKG()
	{
		if (this.itemData.item.type == InventoryItemType.Player)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.BGBONLPDHKH(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != InventoryItemType.MenuTheme)
		{
			this.isSelected = true;
			this.NBHKJJPLLHE();
			if (this.itemData.item.type == (InventoryItemType)7)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("kick" + this.itemData.item.id + "/");
				GameObject.Find("Tab1Content").GetComponent<AudioSampler>().Init(ojcilkfonmh, 636f, false);
			}
			if (this.itemData.item.type == InventoryItemType.MenuTheme)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().GCNKIJDNPMD();
			}
		}
	}

	// Token: 0x0600D795 RID: 55189 RVA: 0x004CFA64 File Offset: 0x004CDC64
	public void NBHKJJPLLHE()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.EnquipItem(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0600D796 RID: 55190 RVA: 0x004CE8A6 File Offset: 0x004CCAA6
	public void IFCLGEEAHPG()
	{
		if (this.infoCanvas)
		{
			this.infoCanvas.SetActive(this.infoCanvas.activeSelf);
		}
	}

	// Token: 0x0600D797 RID: 55191 RVA: 0x004CFAC4 File Offset: 0x004CDCC4
	public void KHLOKBDJLAO()
	{
		if (this.itemData.item.type == (InventoryItemType)8)
		{
			base.StartCoroutine(Singleton<ContributorSystem>.Instance.JMFDJLNMBMO(0, null, string.Empty + this.itemData.steamid));
		}
		if (!this.isSelected && this.itemData.item.type != InventoryItemType.Other && this.itemData.item.type != (InventoryItemType)5)
		{
			this.isSelected = true;
			this.UpdateBadge();
			if (this.itemData.item.type == InventoryItemType.Ticket)
			{
				AudioClip ojcilkfonmh = Resources.Load<AudioClip>("_TimeX" + this.itemData.item.id + "_CenterX");
				GameObject.Find("id").GetComponent<AudioSampler>().Init(ojcilkfonmh, 1889f, true);
			}
			if (this.itemData.item.type == (InventoryItemType)6)
			{
				UnityEngine.Object.FindObjectOfType<ShaderItemHandler>().BKEFJPOHKDE();
			}
		}
	}

	// Token: 0x0600D798 RID: 55192 RVA: 0x004CFBD0 File Offset: 0x004CDDD0
	public void LMJNNMHMFPL()
	{
		if (this.isSelected)
		{
			Singleton<ItemsHandler>.Instance.JGJCJMPFOAC(this.itemData.item.type, this.itemData.steamid);
		}
		if (this.selectedBadge)
		{
			this.selectedBadge.SetActive(this.isSelected);
		}
	}

	// Token: 0x0400186F RID: 6255
	public SteamInventoryItem itemData;

	// Token: 0x04001870 RID: 6256
	public GameObject infoCanvas;

	// Token: 0x04001871 RID: 6257
	public GameObject selectedBadge;

	// Token: 0x04001872 RID: 6258
	public bool isSelected;
}
