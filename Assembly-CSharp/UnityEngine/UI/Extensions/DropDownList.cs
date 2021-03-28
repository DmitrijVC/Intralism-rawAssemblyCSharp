using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200024F RID: 591
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Extensions/Dropdown List")]
	public class DropDownList : MonoBehaviour
	{
		// Token: 0x06008EC1 RID: 36545 RVA: 0x003140CD File Offset: 0x003122CD
		public void JEOMBLNIIKP(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.GHHKKJJGOAN();
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x003140DC File Offset: 0x003122DC
		public void SelectItem(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.GGENNAENHGP(HDAENIBEMJF);
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x0031410F File Offset: 0x0031230F
		private void JLEDCLHJKDO(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008EC4 RID: 36548 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem NLPNJOCNGHA()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x00314120 File Offset: 0x00312320
		public float LEMADPGKOCI()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem ELMAEGKCFAC()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x00314128 File Offset: 0x00312328
		public void KIMMMCJFMAB()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008EC8 RID: 36552 RVA: 0x00314131 File Offset: 0x00312331
		private void KPFIBDBAKFD(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.EIBKFJMOFHK(true);
			this.GBNICLMGCIG(true);
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x0031416B File Offset: 0x0031236B
		public void HLBNNGFFCBE(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.EBBKKKHMJBM();
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x0031417A File Offset: 0x0031237A
		private void MCGOAGICMHH(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.EIBKFJMOFHK(true);
			this.GGENNAENHGP(true);
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x003141B4 File Offset: 0x003123B4
		private void NEDOMLPGMJF(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.GNOHENELBHB(false);
			this.EALAANPEBFN(false);
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x00314120 File Offset: 0x00312320
		public float FJFHDBDIEEO()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x003141EE File Offset: 0x003123EE
		public void MDNHCLKNCLE()
		{
			this.PBHNFEGCKOG();
		}

		// Token: 0x06008ECE RID: 36558 RVA: 0x003141F8 File Offset: 0x003123F8
		private void EALAANPEBFN(bool EMFOOECGEED = true)
		{
			this.AMNIKLBIHAC((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.SelectedItem == null)
			{
				return;
			}
			bool flag = this.GJHIINGAEJG().NDIHLFODKKE() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.GJHIINGAEJG().GEMFDHOKMOG();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.LNKJOJKJBKL().AOGMILOAJMK();
			}
			for (int i = 1; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(1132f, 1788f, 711f, 675f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem LNKJOJKJBKL()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x00314380 File Offset: 0x00312580
		public void NAMPKIKDIMC(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(748f, 110f, 947f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(686f, 737f, 927f);
			this.BCENJFOJJOL = !this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x00314120 File Offset: 0x00312320
		public float CHNDBBHKEDO()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x0031441C File Offset: 0x0031261C
		private bool DKIAMBIFPKI()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("Add Environment Sprite").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("_Size").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("Joystick1Button8").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("bans.viewed.").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("Received RPC: ").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("LowMid").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1156f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)8;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("_CenterX").gameObject);
				this._itemTemplate.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("#ok");
				result = false;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 0)
			{
				for (int i = 0; i < this.IGECOMGCEDF.childCount; i++)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.KBAJMMDNILB();
			this.RedrawPanel();
			return result;
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x00314640 File Offset: 0x00312840
		public void LALNBFCBCHI(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.RedrawPanel();
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x0031464F File Offset: 0x0031284F
		public void MMOKKAPFGAK()
		{
			this.KPFCINLODFE();
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x00314658 File Offset: 0x00312858
		private bool KPFCINLODFE()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("Done!").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("value").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("[GameScene] Submiting rank").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_TimeX").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("_Value").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_TimeX").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 384f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Clamped;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("_Tint").gameObject);
				this._itemTemplate.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_Visualize");
				result = true;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 0)
			{
				for (int i = 1; i < this.IGECOMGCEDF.childCount; i += 0)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.EHACGFPNNHP();
			this.GHHKKJJGOAN();
			return result;
		}

		// Token: 0x06008ED6 RID: 36566 RVA: 0x0031487C File Offset: 0x00312A7C
		public void PGCCCGLPAGK(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.BOLLLPLMKOK(HDAENIBEMJF);
		}

		// Token: 0x06008ED7 RID: 36567 RVA: 0x003148B0 File Offset: 0x00312AB0
		public void EGIMCJLLKMP(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(901f, 761f, 847f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1504f, 610f, 313f);
			this.BCENJFOJJOL = this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x0031494B File Offset: 0x00312B4B
		public void GFPKIBMGCPC(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.MEMKGENEOGJ();
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0031464F File Offset: 0x0031284F
		public void HPFOFGJPNCI()
		{
			this.KPFCINLODFE();
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x0031495C File Offset: 0x00312B5C
		public void GNOHENELBHB(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(813f, 778f, 196f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1637f, 1565f, 92f);
			this.BCENJFOJJOL = !this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x003149F8 File Offset: 0x00312BF8
		private void LJJEODENDLM(bool EMFOOECGEED = true)
		{
			this.SelectedItem = ((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.EMILPCNCJMP() == null)
			{
				return;
			}
			bool flag = this.ELMAEGKCFAC().GEMFDHOKMOG() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.SelectedItem.GEMFDHOKMOG();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.LNKJOJKJBKL().DGBOGEKKDFM();
			}
			for (int i = 1; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(878f, 1128f, 728f, 134f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x00314B80 File Offset: 0x00312D80
		public void HKJDGOCIGEB(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.EBGHBANFAGJ(HDAENIBEMJF);
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x00314BB4 File Offset: 0x00312DB4
		private bool EFJAMHIHFHO()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("_ScreenResolution").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("[DiscordController] Join ({0})").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("_ScreenResolution").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("maps.").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("\\\"").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_SunColor").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1971f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)8;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change").gameObject);
				this._itemTemplate.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_Red_B");
				result = true;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 1)
			{
				for (int i = 0; i < this.IGECOMGCEDF.childCount; i += 0)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.FKPPDOHCLGA();
			this.RedrawPanel();
			return result;
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x00314DD8 File Offset: 0x00312FD8
		public void LOLOKGNKBBC(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(3f, 685f, 504f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1253f, 1782f, 1865f);
			this.BCENJFOJJOL = !this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008EDF RID: 36575 RVA: 0x00314E73 File Offset: 0x00313073
		private void JKBCPINJEAO(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.ToggleDropdownPanel(true);
			this.GGENNAENHGP(true);
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06008F46 RID: 36678 RVA: 0x00314120 File Offset: 0x00312320
		// (set) Token: 0x06008EE0 RID: 36576 RVA: 0x00314EAD File Offset: 0x003130AD
		public float ScrollBarWidth
		{
			get
			{
				return this._scrollBarWidth;
			}
			set
			{
				this._scrollBarWidth = value;
				this.RedrawPanel();
			}
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x00314120 File Offset: 0x00312320
		public float NDBLJIEFNLI()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x00314EBC File Offset: 0x003130BC
		public void HOMFAAEKCFD(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.KCDJGHLPBMG();
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x00314ECB File Offset: 0x003130CB
		private void BAFFPDEAGMJ(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.FMFMIPPHIBO(false);
			this.EBGHBANFAGJ(false);
		}

		// Token: 0x06008EE4 RID: 36580 RVA: 0x00314F05 File Offset: 0x00313105
		public void KHPFNJCHEBO(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.PFDCFOFLOIC(HDAENIBEMJF);
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x00314120 File Offset: 0x00312320
		public float KGNMCLAGACB()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x00314F38 File Offset: 0x00313138
		public void GDNIDBMAOHD(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.PPKOKKBMHJC();
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x00314F48 File Offset: 0x00313148
		public void EIBKFJMOFHK(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1162f, 1007f, 1233f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1667f, 528f, 933f);
			this.BCENJFOJJOL = this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008EE8 RID: 36584 RVA: 0x00314FE4 File Offset: 0x003131E4
		private void PFDCFOFLOIC(bool EMFOOECGEED = true)
		{
			this.NKMICAIAKLI((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.EMILPCNCJMP() == null)
			{
				return;
			}
			bool flag = this.NCIKHGDFFCC().Image != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.NLPNJOCNGHA().NDIHLFODKKE();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.GJHIINGAEJG().DGBOGEKKDFM();
			}
			for (int i = 1; i < this.IGECOMGCEDF.childCount; i += 0)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(1332f, 435f, 722f, 1865f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x0031516C File Offset: 0x0031336C
		public void ToggleDropdownPanel(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1f, 1f, 1f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1f, 1f, 1f);
			this.BCENJFOJJOL = !this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06008EEA RID: 36586 RVA: 0x00314118 File Offset: 0x00312318
		// (set) Token: 0x06008EF4 RID: 36596 RVA: 0x0031410F File Offset: 0x0031230F
		public DropDownListItem SelectedItem { get; private set; }

		// Token: 0x06008EEB RID: 36587 RVA: 0x00314120 File Offset: 0x00312320
		public float ICHILLOAKLM()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x00314F38 File Offset: 0x00313138
		public void HKDNPIHADND(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.PPKOKKBMHJC();
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x00315207 File Offset: 0x00313407
		public void LDBNMDOOJNM(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.NFOIKLBOHFF(HDAENIBEMJF);
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x0031523A File Offset: 0x0031343A
		public int DILFCJFNBBN()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x00315244 File Offset: 0x00313444
		private bool DDEKPGECKCD()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("MainButton").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Overlay").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("ScrollPanel").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("Scrollbar").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("SlidingArea").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("Items").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 2f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Clamped;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("ItemTemplate").gameObject);
				this._itemTemplate.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
				result = false;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 0)
			{
				for (int i = 0; i < this.IGECOMGCEDF.childCount; i++)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.RebuildPanel();
			this.RedrawPanel();
			return result;
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x00314128 File Offset: 0x00312328
		public void MEBPBNLBECA()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem AHPGIGENBAO()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x00315468 File Offset: 0x00313668
		public void FCGCEPPJNMM()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "Drop_With_Obj" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num += 0;
			}
			for (int i = 1; i < this.NFNGKIJFBCJ.Count; i += 0)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.Caption;
					if (mpeclbghecd.DBIMJHMKHNK.KEEMCPBDFIB())
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.NDIHLFODKKE();
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.NDIHLFODKKE() == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.IsDisabled) ? Color.white : new Color(1835f, 1522f, 1894f, 363f)) : new Color(823f, 775f, 1315f, 668f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.AEIFJLBBKBP));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x003156D4 File Offset: 0x003138D4
		public void GLDCGFIBEPB(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1829f, 1110f, 629f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1957f, 1138f, 1255f);
			this.BCENJFOJJOL = !this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x00315770 File Offset: 0x00313970
		private bool MCPDNFJCAPC()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("AppID: {0}*** GameVersion: {1} PeerId: {2} ").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("{0:x2}").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("BestScoreText").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("DataText").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("_EdgeSize").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("GlassColor").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 49f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Unrestricted;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("float,1.5").gameObject);
				this._itemTemplate.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_Offsets");
				result = false;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 1)
			{
				for (int i = 1; i < this.IGECOMGCEDF.childCount; i += 0)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.EHACGFPNNHP();
			this.MEMKGENEOGJ();
			return result;
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x00315994 File Offset: 0x00313B94
		public void KCDJGHLPBMG()
		{
			float num = (this.Items.Count <= this.ItemsToDisplay) ? 1997f : this._scrollBarWidth;
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.GLHDANCHDDF.rectTransform.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.GLHDANCHDDF.txt.rectTransform.offsetMax = new Vector2(1817f, 1878f);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1280f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.Items.Count < 1)
			{
				return;
			}
			float num2 = this._itemTemplate.GetComponent<LayoutElement>().minHeight * (float)Mathf.Min(this._itemsToDisplay, this.Items.Count) + 1245f;
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			if (this.shadow)
			{
				RectTransform component = this.ICLMGGNADNO.GetComponent<RectTransform>();
				RectTransform component2 = this.shadow.GetComponent<RectTransform>();
				component2.anchorMin = component.anchorMin;
				component2.anchorMax = component.anchorMax;
				component2.anchoredPosition = component.anchoredPosition;
				component2.sizeDelta = component.sizeDelta;
			}
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 1605f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(875f, 1402f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 530f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x00315C84 File Offset: 0x00313E84
		private void BHKMPNAIFCO(bool EMFOOECGEED = true)
		{
			this.NKMICAIAKLI((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.HGGOCKHJLPC() == null)
			{
				return;
			}
			bool flag = this.HGGOCKHJLPC().LHIKDFGOHMH() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.MJIHJHEEOHP().Image;
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.NCIKHGDFFCC().BBLPFDKLPAJ();
			}
			for (int i = 0; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(1908f, 949f, 573f, 993f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x00315E0C File Offset: 0x0031400C
		public void CMPLIHAOKOA()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "init" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num++;
			}
			for (int i = 1; i < this.NFNGKIJFBCJ.Count; i++)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.IAMDNDHGFNP();
					if (mpeclbghecd.DBIMJHMKHNK.JDHICGCBFBF())
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.NDIHLFODKKE();
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.GEMFDHOKMOG() == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.CGCLOKFGLDL()) ? Color.white : new Color(1470f, 1934f, 834f, 987f)) : new Color(1219f, 991f, 22f, 1750f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.GBKBDKHPLKG));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x00316078 File Offset: 0x00314278
		private void NFOIKLBOHFF(bool EMFOOECGEED = true)
		{
			this.AMNIKLBIHAC((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.NLPNJOCNGHA() == null)
			{
				return;
			}
			bool flag = this.SelectedItem.GEMFDHOKMOG() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.NLPNJOCNGHA().LHIKDFGOHMH();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.ELMAEGKCFAC().BBLPFDKLPAJ();
			}
			for (int i = 1; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(936f, 36f, 156f, 854f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008EFA RID: 36602 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem EMILPCNCJMP()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008EFB RID: 36603 RVA: 0x0031410F File Offset: 0x0031230F
		private void GMJAEKJGKLE(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x00314120 File Offset: 0x00312320
		public float DENOOJEBLLP()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x00316200 File Offset: 0x00314400
		public void RebuildPanel()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "Item " + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num++;
			}
			for (int i = 0; i < this.NFNGKIJFBCJ.Count; i++)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.Caption;
					if (mpeclbghecd.DBIMJHMKHNK.IsDisabled)
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.Image;
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.Image == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.IsDisabled) ? Color.white : new Color(1f, 1f, 1f, 0.5f)) : new Color(1f, 1f, 1f, 0f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.GBKBDKHPLKG));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x0031646C File Offset: 0x0031466C
		private bool PBHNFEGCKOG()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find(" beatThreshold: ").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("[ReplayScene] Loading replay: ").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("?").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("CameraFilterPack/FX_Screens").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("DPADHOR").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("sfxVolume").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1035f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)7;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("settings.selectormapsperpage").gameObject);
				this._itemTemplate.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_TimeX");
				result = false;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 1)
			{
				for (int i = 1; i < this.IGECOMGCEDF.childCount; i++)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.RebuildPanel();
			this.EBBKKKHMJBM();
			return result;
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem HGGOCKHJLPC()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x00316690 File Offset: 0x00314890
		public void EOPLNNDKJLM(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.FKGCOBCFHGN(HDAENIBEMJF);
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x00314120 File Offset: 0x00312320
		public float IBDMJAGJNNA()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x00314128 File Offset: 0x00312328
		public void DFFKKLAPHCC()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x00314120 File Offset: 0x00312320
		public float LCLDNJLJFNF()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x003166C4 File Offset: 0x003148C4
		private bool PBJLNMINBOM()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("[LevelEditorScene] Error: Timeout :S").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Joystick1Button5").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("_Value").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_Value3").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("...").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("Already exist!").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 291f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)5;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("CameraFilterPack/Special_Bubble").gameObject);
				this._itemTemplate.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("VisionBlur");
				result = true;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 1)
			{
				for (int i = 0; i < this.IGECOMGCEDF.childCount; i += 0)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.EHACGFPNNHP();
			this.PPKOKKBMHJC();
			return result;
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x003168E8 File Offset: 0x00314AE8
		public void PGMEJLFMLOF(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.MEMKGENEOGJ();
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x003168F8 File Offset: 0x00314AF8
		public void KBAJMMDNILB()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "_AdaptParams" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num++;
			}
			for (int i = 1; i < this.NFNGKIJFBCJ.Count; i++)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.NNMJCJBLDOG();
					if (mpeclbghecd.DBIMJHMKHNK.DFDGJMLCIKA())
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.Image;
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.LHIKDFGOHMH() == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.AAEPJCHHDNP()) ? Color.white : new Color(372f, 1028f, 1233f, 1437f)) : new Color(78f, 1223f, 231f, 667f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.FIPCLHEKKCA));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x06008F07 RID: 36615 RVA: 0x00314F05 File Offset: 0x00313105
		public void HOHNMGKJIMF(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.PFDCFOFLOIC(HDAENIBEMJF);
		}

		// Token: 0x06008F08 RID: 36616 RVA: 0x00316B62 File Offset: 0x00314D62
		private void LOPHEOINMLD(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.ADHPGFNNHNC(true);
			this.FKGCOBCFHGN(false);
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x00314EAD File Offset: 0x003130AD
		public void ADAHDOKBPOF(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.RedrawPanel();
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x00316B9C File Offset: 0x00314D9C
		private void GGENNAENHGP(bool EMFOOECGEED = true)
		{
			this.SelectedItem = ((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.SelectedItem == null)
			{
				return;
			}
			bool flag = this.SelectedItem.Image != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.SelectedItem.Image;
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.SelectedItem.Caption;
			}
			for (int i = 0; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(0f, 0f, 0f, 0f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x00316D24 File Offset: 0x00314F24
		public void MEMKGENEOGJ()
		{
			float num = (this.Items.Count <= this.DHIOGJJJNDG()) ? 935f : this._scrollBarWidth;
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.GLHDANCHDDF.rectTransform.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.GLHDANCHDDF.txt.rectTransform.offsetMax = new Vector2(631f, 836f);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(883f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, true);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.Items.Count < 1)
			{
				return;
			}
			float num2 = this._itemTemplate.GetComponent<LayoutElement>().minHeight * (float)Mathf.Min(this._itemsToDisplay, this.Items.Count) + 1032f;
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			if (this.shadow)
			{
				RectTransform component = this.ICLMGGNADNO.GetComponent<RectTransform>();
				RectTransform component2 = this.shadow.GetComponent<RectTransform>();
				component2.anchorMin = component.anchorMin;
				component2.anchorMax = component.anchorMax;
				component2.anchoredPosition = component.anchoredPosition;
				component2.sizeDelta = component.sizeDelta;
			}
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 1672f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(996f, 1871f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 948f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x00314128 File Offset: 0x00312328
		public void FEHCNJLLJMP()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008F0D RID: 36621 RVA: 0x00317014 File Offset: 0x00315214
		public void CGDMLHLJIDK()
		{
			this.PBJLNMINBOM();
		}

		// Token: 0x06008F0E RID: 36622 RVA: 0x00317020 File Offset: 0x00315220
		public void RedrawPanel()
		{
			float num = (this.Items.Count <= this.ItemsToDisplay) ? 0f : this._scrollBarWidth;
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.GLHDANCHDDF.rectTransform.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.GLHDANCHDDF.txt.rectTransform.offsetMax = new Vector2(4f, 0f);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(0f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.Items.Count < 1)
			{
				return;
			}
			float num2 = this._itemTemplate.GetComponent<LayoutElement>().minHeight * (float)Mathf.Min(this._itemsToDisplay, this.Items.Count) + 5f;
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			if (this.shadow)
			{
				RectTransform component = this.ICLMGGNADNO.GetComponent<RectTransform>();
				RectTransform component2 = this.shadow.GetComponent<RectTransform>();
				component2.anchorMin = component.anchorMin;
				component2.anchorMax = component.anchorMax;
				component2.anchoredPosition = component.anchoredPosition;
				component2.sizeDelta = component.sizeDelta;
			}
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 5f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(5f, 0f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x00317310 File Offset: 0x00315510
		public void AMBGMCDGKBC(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.IGOACJDBECD();
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x00317310 File Offset: 0x00315510
		public void AMECNIGFOGB(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.IGOACJDBECD();
		}

		// Token: 0x06008F11 RID: 36625 RVA: 0x00315207 File Offset: 0x00313407
		public void MMFBPCJPION(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.NFOIKLBOHFF(HDAENIBEMJF);
		}

		// Token: 0x06008F12 RID: 36626 RVA: 0x00317320 File Offset: 0x00315520
		private void FKGCOBCFHGN(bool EMFOOECGEED = true)
		{
			this.HMKHFCLBODK((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.GJHIINGAEJG() == null)
			{
				return;
			}
			bool flag = this.MJIHJHEEOHP().GEMFDHOKMOG() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.GJHIINGAEJG().LHIKDFGOHMH();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.GJHIINGAEJG().IAMDNDHGFNP();
			}
			for (int i = 0; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(943f, 1145f, 737f, 528f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06008F49 RID: 36681 RVA: 0x0031523A File Offset: 0x0031343A
		// (set) Token: 0x06008F13 RID: 36627 RVA: 0x00314640 File Offset: 0x00312840
		public int ItemsToDisplay
		{
			get
			{
				return this._itemsToDisplay;
			}
			set
			{
				this._itemsToDisplay = value;
				this.RedrawPanel();
			}
		}

		// Token: 0x06008F14 RID: 36628 RVA: 0x0031523A File Offset: 0x0031343A
		public int MPJJEGBBDJA()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x00314128 File Offset: 0x00312328
		public void HIPEHGNBJMN()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x0031523A File Offset: 0x0031343A
		public int DHIOGJJJNDG()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x003174A8 File Offset: 0x003156A8
		private bool OBBDNAOBNNF()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("BitsData").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Source directory does not exist or could not be found: ").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("DPADHOR").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find(".a").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("open").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("[Down]").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1912f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)4;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("CameraFilterPack/Colors_Threshold").gameObject);
				this._itemTemplate.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("loadscene");
				result = true;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 1)
			{
				for (int i = 1; i < this.IGECOMGCEDF.childCount; i += 0)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.DLLJFCNIMLI();
			this.RedrawPanel();
			return result;
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x00315207 File Offset: 0x00313407
		public void ABEFJKAGJBG(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.NFOIKLBOHFF(HDAENIBEMJF);
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x003176CC File Offset: 0x003158CC
		private bool LMAGBAGNNAH()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("SAVE FILE").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("settings_bindings_").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("CameraFilterPack/Noise_TV_2").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_Distortion").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("_Value2").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("id").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 401f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)5;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("MapperNameText").gameObject);
				this._itemTemplate.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("[PlayerBase] Got checkpoint at ");
				result = true;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 0)
			{
				for (int i = 0; i < this.IGECOMGCEDF.childCount; i += 0)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.FKPPDOHCLGA();
			this.RedrawPanel();
			return result;
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x003178F0 File Offset: 0x00315AF0
		public void EFHJMDLOOMI(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.GHHKKJJGOAN();
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x00314120 File Offset: 0x00312320
		public float JDJMOEDFIPK()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008F1C RID: 36636 RVA: 0x00314EBC File Offset: 0x003130BC
		public void OFGOFFCFNDG(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.KCDJGHLPBMG();
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x003178FF File Offset: 0x00315AFF
		public void FBOJBIDLIBE(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.EBBKKKHMJBM();
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x00317910 File Offset: 0x00315B10
		public void PPKOKKBMHJC()
		{
			float num = (this.Items.Count <= this.MPJJEGBBDJA()) ? 1642f : this._scrollBarWidth;
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.GLHDANCHDDF.rectTransform.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.GLHDANCHDDF.txt.rectTransform.offsetMax = new Vector2(540f, 1601f);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(488f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, true);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.Items.Count < 1)
			{
				return;
			}
			float num2 = this._itemTemplate.GetComponent<LayoutElement>().minHeight * (float)Mathf.Min(this._itemsToDisplay, this.Items.Count) + 1636f;
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			if (this.shadow)
			{
				RectTransform component = this.ICLMGGNADNO.GetComponent<RectTransform>();
				RectTransform component2 = this.shadow.GetComponent<RectTransform>();
				component2.anchorMin = component.anchorMin;
				component2.anchorMax = component.anchorMax;
				component2.anchoredPosition = component.anchoredPosition;
				component2.sizeDelta = component.sizeDelta;
			}
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 1303f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(1307f, 113f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 517f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x00317C00 File Offset: 0x00315E00
		public void AIBNKIDADPI()
		{
			this.CMGLPNCMLDC();
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x00317C09 File Offset: 0x00315E09
		public void CHOPDIGHJNH()
		{
			this.OBBDNAOBNNF();
		}

		// Token: 0x06008F21 RID: 36641 RVA: 0x00317C14 File Offset: 0x00315E14
		public void EBBKKKHMJBM()
		{
			float num = (this.Items.Count <= this.ItemsToDisplay) ? 183f : this._scrollBarWidth;
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.GLHDANCHDDF.rectTransform.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.GLHDANCHDDF.txt.rectTransform.offsetMax = new Vector2(1406f, 239f);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(482f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, true);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.Items.Count < 1)
			{
				return;
			}
			float num2 = this._itemTemplate.GetComponent<LayoutElement>().minHeight * (float)Mathf.Min(this._itemsToDisplay, this.Items.Count) + 1380f;
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			if (this.shadow)
			{
				RectTransform component = this.ICLMGGNADNO.GetComponent<RectTransform>();
				RectTransform component2 = this.shadow.GetComponent<RectTransform>();
				component2.anchorMin = component.anchorMin;
				component2.anchorMax = component.anchorMax;
				component2.anchoredPosition = component.anchoredPosition;
				component2.sizeDelta = component.sizeDelta;
			}
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 1864f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(1577f, 652f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 27f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x00317F04 File Offset: 0x00316104
		private bool HFDIGALPAHD()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("icon_border").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("inventory.selected.").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("_Saturation").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("steamid").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("Error; Only the MasterClient can call RemoveRPCs for other players.").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("offsets").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1724f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)6;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("_Green_B").gameObject);
				this._itemTemplate.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("CameraFilterPack/3D_Matrix");
				result = false;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 1)
			{
				for (int i = 0; i < this.IGECOMGCEDF.childCount; i += 0)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.PKJKODIIPDI();
			this.MEMKGENEOGJ();
			return result;
		}

		// Token: 0x06008F23 RID: 36643 RVA: 0x00314EBC File Offset: 0x003130BC
		public void GCKEDOHMHCA(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.KCDJGHLPBMG();
		}

		// Token: 0x06008F24 RID: 36644 RVA: 0x00318128 File Offset: 0x00316328
		private void BDALCGKNBPL(bool EMFOOECGEED = true)
		{
			this.AMNIKLBIHAC((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.SelectedItem == null)
			{
				return;
			}
			bool flag = this.SelectedItem.LHIKDFGOHMH() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.NLPNJOCNGHA().GEMFDHOKMOG();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.SelectedItem.DGBOGEKKDFM();
			}
			for (int i = 1; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(918f, 814f, 1432f, 689f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008F25 RID: 36645 RVA: 0x003182B0 File Offset: 0x003164B0
		public void IGOACJDBECD()
		{
			float num = (this.Items.Count <= this.HGDMGANHPHG()) ? 1966f : this._scrollBarWidth;
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.GLHDANCHDDF.rectTransform.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.GLHDANCHDDF.txt.rectTransform.offsetMax = new Vector2(706f, 1288f);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(312f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.Items.Count < 1)
			{
				return;
			}
			float num2 = this._itemTemplate.GetComponent<LayoutElement>().minHeight * (float)Mathf.Min(this._itemsToDisplay, this.Items.Count) + 1037f;
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			if (this.shadow)
			{
				RectTransform component = this.ICLMGGNADNO.GetComponent<RectTransform>();
				RectTransform component2 = this.shadow.GetComponent<RectTransform>();
				component2.anchorMin = component.anchorMin;
				component2.anchorMax = component.anchorMax;
				component2.anchoredPosition = component.anchoredPosition;
				component2.sizeDelta = component.sizeDelta;
			}
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 128f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(448f, 1190f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 1781f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008F26 RID: 36646 RVA: 0x00314128 File Offset: 0x00312328
		public void DNNFHBOOPIN()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x003185A0 File Offset: 0x003167A0
		private void BOLLLPLMKOK(bool EMFOOECGEED = true)
		{
			this.AMNIKLBIHAC((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.NCIKHGDFFCC() == null)
			{
				return;
			}
			bool flag = this.NLPNJOCNGHA().GEMFDHOKMOG() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.SelectedItem.NDIHLFODKKE();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.HGGOCKHJLPC().GNNINBIBPHI();
			}
			for (int i = 1; i < this.IGECOMGCEDF.childCount; i += 0)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(1416f, 387f, 451f, 220f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x00314128 File Offset: 0x00312328
		public void Start()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x00318728 File Offset: 0x00316928
		public void ADHPGFNNHNC(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1497f, 177f, 606f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(740f, 1301f, 1230f);
			this.BCENJFOJJOL = this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x003187C4 File Offset: 0x003169C4
		public void FMFMIPPHIBO(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1548f, 1388f, 802f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1725f, 906f, 1487f);
			this.BCENJFOJJOL = this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x00314640 File Offset: 0x00312840
		public void EEDNFHDJNNN(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.RedrawPanel();
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x00314120 File Offset: 0x00312320
		public float MKCNPOLFKIK()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008F2D RID: 36653 RVA: 0x00318860 File Offset: 0x00316A60
		private void EBGHBANFAGJ(bool EMFOOECGEED = true)
		{
			this.NKMICAIAKLI((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.NCIKHGDFFCC() == null)
			{
				return;
			}
			bool flag = this.EMILPCNCJMP().Image != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.LNKJOJKJBKL().LHIKDFGOHMH();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.HGGOCKHJLPC().DGBOGEKKDFM();
			}
			for (int i = 0; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(799f, 1047f, 641f, 999f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x00314F38 File Offset: 0x00313138
		public void KNPLCICNMJB(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.PPKOKKBMHJC();
		}

		// Token: 0x06008F2F RID: 36655 RVA: 0x003189E8 File Offset: 0x00316BE8
		private bool CMGLPNCMLDC()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.GLHDANCHDDF = new DropDownListButton(this.IHOLCKOEPAP.Find("_Value3").gameObject);
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("SlidingArea").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("0.00").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("CameraFilterPack/Drawing_Manga").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("settings.arcsnohitsoundtimedelay").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_TimeX").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 475f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)3;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this._itemTemplate = ((!this._itemTemplate) ? this._itemTemplate : this.IHOLCKOEPAP.Find("_SpawnHeuristic").gameObject);
				this._itemTemplate.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_ScreenResolution");
				result = false;
			}
			this.NFNGKIJFBCJ = new List<DropDownListButton>();
			if (this.IGECOMGCEDF.childCount > 1)
			{
				for (int i = 1; i < this.IGECOMGCEDF.childCount; i++)
				{
					Object.Destroy(this.IGECOMGCEDF.GetChild(i).gameObject);
				}
			}
			this.Items.Clear();
			this.RebuildPanel();
			this.KCDJGHLPBMG();
			return result;
		}

		// Token: 0x06008F30 RID: 36656 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem GJHIINGAEJG()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem MJIHJHEEOHP()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x00318C0C File Offset: 0x00316E0C
		public void DLLJFCNIMLI()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "[PlayerController] " + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num += 0;
			}
			for (int i = 0; i < this.NFNGKIJFBCJ.Count; i += 0)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.BBLPFDKLPAJ();
					if (mpeclbghecd.DBIMJHMKHNK.AAEPJCHHDNP())
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.GEMFDHOKMOG();
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.LHIKDFGOHMH() == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.ANKNHALAGMP()) ? Color.white : new Color(868f, 953f, 580f, 153f)) : new Color(77f, 998f, 1031f, 1575f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.BFEABMIFIEE));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x00318E78 File Offset: 0x00317078
		private void GBNICLMGCIG(bool EMFOOECGEED = true)
		{
			this.GMJAEKJGKLE((this.AHMBGOCOEAB <= -1 || this.AHMBGOCOEAB >= this.Items.Count) ? null : this.Items[this.AHMBGOCOEAB]);
			if (this.LNKJOJKJBKL() == null)
			{
				return;
			}
			bool flag = this.AHPGIGENBAO().NDIHLFODKKE() != null;
			if (flag)
			{
				this.GLHDANCHDDF.img.sprite = this.NLPNJOCNGHA().GEMFDHOKMOG();
				this.GLHDANCHDDF.img.color = Color.white;
			}
			else if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.img.sprite = null;
			}
			if (this.GLHDANCHDDF != null)
			{
				this.GLHDANCHDDF.txt.text = this.MJIHJHEEOHP().OLILGJPEOIE();
			}
			for (int i = 1; i < this.IGECOMGCEDF.childCount; i++)
			{
				if (this.GLHDANCHDDF != null && i < this.NFNGKIJFBCJ.Count)
				{
					this.NFNGKIJFBCJ[i].btnImg.color = ((this.AHMBGOCOEAB != i) ? new Color(1246f, 1511f, 193f, 1757f) : this.GLHDANCHDDF.btn.colors.highlightedColor);
				}
			}
			if (EMFOOECGEED)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06008F34 RID: 36660 RVA: 0x0031464F File Offset: 0x0031284F
		public void JHANGPCOCIG()
		{
			this.KPFCINLODFE();
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x00319000 File Offset: 0x00317200
		public void FNCDHNCOOBL(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1897f, 186f, 17f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1513f, 1421f, 1258f);
			this.BCENJFOJJOL = !this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x003190BC File Offset: 0x003172BC
		public void GHHKKJJGOAN()
		{
			float num = (this.Items.Count <= this.ItemsToDisplay) ? 279f : this._scrollBarWidth;
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.GLHDANCHDDF.rectTransform.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.GLHDANCHDDF.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.GLHDANCHDDF.txt.rectTransform.offsetMax = new Vector2(715f, 109f);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(56f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, true);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.Items.Count < 1)
			{
				return;
			}
			float num2 = this._itemTemplate.GetComponent<LayoutElement>().minHeight * (float)Mathf.Min(this._itemsToDisplay, this.Items.Count) + 592f;
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			if (this.shadow)
			{
				RectTransform component = this.ICLMGGNADNO.GetComponent<RectTransform>();
				RectTransform component2 = this.shadow.GetComponent<RectTransform>();
				component2.anchorMin = component.anchorMin;
				component2.anchorMax = component.anchorMax;
				component2.anchoredPosition = component.anchoredPosition;
				component2.sizeDelta = component.sizeDelta;
			}
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 925f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(52f, 167f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 791f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x003193AC File Offset: 0x003175AC
		public void FKPPDOHCLGA()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "_Speed" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num++;
			}
			for (int i = 1; i < this.NFNGKIJFBCJ.Count; i += 0)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.IAMDNDHGFNP();
					if (mpeclbghecd.DBIMJHMKHNK.DFDGJMLCIKA())
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.GEMFDHOKMOG();
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.GEMFDHOKMOG() == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.IsDisabled) ? Color.white : new Color(1344f, 1813f, 211f, 1188f)) : new Color(123f, 1007f, 644f, 1228f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.JBAJEMGOPDL));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0031410F File Offset: 0x0031230F
		private void JEJGFAONJPJ(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x00319616 File Offset: 0x00317816
		private void DBPOHINECLN(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.LOLOKGNKBBC(false);
			this.FKGCOBCFHGN(true);
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x00314120 File Offset: 0x00312320
		public float GCINPKIMHLC()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x0031410F File Offset: 0x0031230F
		private void AMNIKLBIHAC(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008F3D RID: 36669 RVA: 0x0031410F File Offset: 0x0031230F
		private void HMKHFCLBODK(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x00314B80 File Offset: 0x00312D80
		public void EINGDNGIEMO(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.EBGHBANFAGJ(HDAENIBEMJF);
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x00319650 File Offset: 0x00317850
		public void MHDILMGABCK(int EDOLBCICJGM, bool HDAENIBEMJF = true)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.GBNICLMGCIG(HDAENIBEMJF);
		}

		// Token: 0x06008F40 RID: 36672 RVA: 0x00319683 File Offset: 0x00317883
		public void CFGKNNAKNCC(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.IGOACJDBECD();
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x00319692 File Offset: 0x00317892
		private void ANLKHFOEOND(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.MBHMHFOBICC(false);
			this.PFDCFOFLOIC(false);
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x00314118 File Offset: 0x00312318
		public DropDownListItem NCIKHGDFFCC()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x00317014 File Offset: 0x00315214
		public void KDMKDEKCELE()
		{
			this.PBJLNMINBOM();
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x003196CC File Offset: 0x003178CC
		public void MBHMHFOBICC(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1649f, 1265f, 1193f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(1061f, 258f, 17f);
			this.BCENJFOJJOL = this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008F45 RID: 36677 RVA: 0x00319768 File Offset: 0x00317968
		public void FHJPDGAGEFF(bool DPLLMKAPDIM)
		{
			this.AAHLPFMBPJP.transform.localScale = new Vector3(1497f, 1143f, 160f);
			this.NKNMCGNABMC.transform.localScale = new Vector3(713f, 1320f, 588f);
			this.BCENJFOJJOL = this.BCENJFOJJOL;
			this.AAHLPFMBPJP.gameObject.SetActive(this.BCENJFOJJOL);
			if (this.BCENJFOJJOL)
			{
				base.transform.SetAsLastSibling();
			}
			else if (DPLLMKAPDIM)
			{
			}
		}

		// Token: 0x06008F47 RID: 36679 RVA: 0x00319803 File Offset: 0x00317A03
		private void FDGKIMCIEAC(int EDOLBCICJGM)
		{
			if (EDOLBCICJGM != this.AHMBGOCOEAB && this.OnSelectionChanged != null)
			{
				this.OnSelectionChanged(EDOLBCICJGM);
			}
			this.AHMBGOCOEAB = EDOLBCICJGM;
			this.GLDCGFIBEPB(false);
			this.EBGHBANFAGJ(true);
		}

		// Token: 0x06008F48 RID: 36680 RVA: 0x0031523A File Offset: 0x0031343A
		public int HGDMGANHPHG()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x0031410F File Offset: 0x0031230F
		private void NKMICAIAKLI(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008F4B RID: 36683 RVA: 0x00319840 File Offset: 0x00317A40
		public void EHACGFPNNHP()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "Destroy(targetPhotonView) failed, cause targetPhotonView is null." + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num += 0;
			}
			for (int i = 0; i < this.NFNGKIJFBCJ.Count; i += 0)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.GNNINBIBPHI();
					if (mpeclbghecd.DBIMJHMKHNK.IFINMJJPCHK())
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.GEMFDHOKMOG();
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.LHIKDFGOHMH() == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.IFINMJJPCHK()) ? Color.white : new Color(177f, 165f, 1907f, 231f)) : new Color(1218f, 1716f, 1857f, 1884f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.PBCAHKDLFPE));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x00319AAC File Offset: 0x00317CAC
		public void PKJKODIIPDI()
		{
			if (this.Items.Count == 0)
			{
				return;
			}
			int num = this.NFNGKIJFBCJ.Count;
			while (this.NFNGKIJFBCJ.Count < this.Items.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this._itemTemplate);
				gameObject.name = "CameraFilterPack/Drawing_CellShading" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				this.NFNGKIJFBCJ.Add(new DropDownListButton(gameObject));
				num += 0;
			}
			for (int i = 1; i < this.NFNGKIJFBCJ.Count; i++)
			{
				if (i < this.Items.Count)
				{
					DropDownList.MPECLBGHECD mpeclbghecd = new DropDownList.MPECLBGHECD();
					mpeclbghecd.ADPIKBBAKHP = this;
					mpeclbghecd.DBIMJHMKHNK = this.Items[i];
					this.NFNGKIJFBCJ[i].txt.text = mpeclbghecd.DBIMJHMKHNK.Caption;
					if (mpeclbghecd.DBIMJHMKHNK.DFDGJMLCIKA())
					{
						this.NFNGKIJFBCJ[i].txt.color = this.disabledTextColor;
					}
					if (this.NFNGKIJFBCJ[i].btnImg != null)
					{
						this.NFNGKIJFBCJ[i].btnImg.sprite = null;
					}
					this.NFNGKIJFBCJ[i].img.sprite = mpeclbghecd.DBIMJHMKHNK.NDIHLFODKKE();
					this.NFNGKIJFBCJ[i].img.color = ((!(mpeclbghecd.DBIMJHMKHNK.GEMFDHOKMOG() == null)) ? ((!mpeclbghecd.DBIMJHMKHNK.ANKNHALAGMP()) ? Color.white : new Color(164f, 538f, 636f, 1235f)) : new Color(118f, 1852f, 575f, 887f));
					mpeclbghecd.KHENJDBAKIF = i;
					this.NFNGKIJFBCJ[i].btn.onClick.RemoveAllListeners();
					this.NFNGKIJFBCJ[i].btn.onClick.AddListener(new UnityAction(mpeclbghecd.JKEDCEOCPJO));
				}
				this.NFNGKIJFBCJ[i].gameobject.SetActive(i < this.Items.Count);
			}
		}

		// Token: 0x0400106D RID: 4205
		public Color disabledTextColor;

		// Token: 0x0400106E RID: 4206
		public Image shadow;

		// Token: 0x04001070 RID: 4208
		public List<DropDownListItem> Items;

		// Token: 0x04001071 RID: 4209
		public Action<int> OnSelectionChanged;

		// Token: 0x04001072 RID: 4210
		public UnityEvent OnSelected;

		// Token: 0x04001073 RID: 4211
		private bool BCENJFOJJOL;

		// Token: 0x04001074 RID: 4212
		private bool MELOHGFLIPB;

		// Token: 0x04001075 RID: 4213
		private DropDownListButton GLHDANCHDDF;

		// Token: 0x04001076 RID: 4214
		private RectTransform IHOLCKOEPAP;

		// Token: 0x04001077 RID: 4215
		private RectTransform AAHLPFMBPJP;

		// Token: 0x04001078 RID: 4216
		private RectTransform ICLMGGNADNO;

		// Token: 0x04001079 RID: 4217
		private RectTransform NKNMCGNABMC;

		// Token: 0x0400107A RID: 4218
		private RectTransform CNEKHMOIMKC;

		// Token: 0x0400107B RID: 4219
		private RectTransform IGECOMGCEDF;

		// Token: 0x0400107C RID: 4220
		private Canvas AHPDJAGJGNL;

		// Token: 0x0400107D RID: 4221
		private RectTransform DGJKIJJBMOB;

		// Token: 0x0400107E RID: 4222
		private ScrollRect CFNFKMGEGHL;

		// Token: 0x0400107F RID: 4223
		private List<DropDownListButton> NFNGKIJFBCJ = new List<DropDownListButton>();

		// Token: 0x04001080 RID: 4224
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x04001081 RID: 4225
		[SerializeField]
		private float _scrollBarWidth = 20f;

		// Token: 0x04001082 RID: 4226
		private int AHMBGOCOEAB;

		// Token: 0x04001083 RID: 4227
		[SerializeField]
		private int _itemsToDisplay;

		// Token: 0x02000250 RID: 592
		[CompilerGenerated]
		private sealed class MPECLBGHECD
		{
			// Token: 0x06008F4D RID: 36685 RVA: 0x00319D16 File Offset: 0x00317F16
			internal void LHHFJBIAHCN()
			{
				this.ADPIKBBAKHP.LOPHEOINMLD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F4E RID: 36686 RVA: 0x00319D49 File Offset: 0x00317F49
			internal void BMAOCLKPNNC()
			{
				this.ADPIKBBAKHP.ANLKHFOEOND(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F4F RID: 36687 RVA: 0x00319D7C File Offset: 0x00317F7C
			internal void LOEAMHGMMPK()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F50 RID: 36688 RVA: 0x00319DAF File Offset: 0x00317FAF
			internal void OLIGLEMPFOP()
			{
				this.ADPIKBBAKHP.NEDOMLPGMJF(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F51 RID: 36689 RVA: 0x00319DE2 File Offset: 0x00317FE2
			internal void AEIFJLBBKBP()
			{
				this.ADPIKBBAKHP.FDGKIMCIEAC(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F52 RID: 36690 RVA: 0x00319E15 File Offset: 0x00318015
			internal void FDAIFOAGDLA()
			{
				this.ADPIKBBAKHP.MCGOAGICMHH(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F53 RID: 36691 RVA: 0x00319E48 File Offset: 0x00318048
			internal void BDGDIDPDBHG()
			{
				this.ADPIKBBAKHP.KPFIBDBAKFD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F54 RID: 36692 RVA: 0x00319E7B File Offset: 0x0031807B
			internal void LLNDDFGPOPL()
			{
				this.ADPIKBBAKHP.DBPOHINECLN(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F55 RID: 36693 RVA: 0x00319D7C File Offset: 0x00317F7C
			internal void DBFPGFHEGKA()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F56 RID: 36694 RVA: 0x00319EAE File Offset: 0x003180AE
			internal void FCAGEDLBBHD()
			{
				this.ADPIKBBAKHP.BAFFPDEAGMJ(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F57 RID: 36695 RVA: 0x00319E15 File Offset: 0x00318015
			internal void FHIJCPPECHA()
			{
				this.ADPIKBBAKHP.MCGOAGICMHH(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F58 RID: 36696 RVA: 0x00319D16 File Offset: 0x00317F16
			internal void PBCAHKDLFPE()
			{
				this.ADPIKBBAKHP.LOPHEOINMLD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F5A RID: 36698 RVA: 0x00319DAF File Offset: 0x00317FAF
			internal void EGKGJJGAPMN()
			{
				this.ADPIKBBAKHP.NEDOMLPGMJF(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F5B RID: 36699 RVA: 0x00319E48 File Offset: 0x00318048
			internal void EKHOOPGPPGE()
			{
				this.ADPIKBBAKHP.KPFIBDBAKFD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F5C RID: 36700 RVA: 0x00319D49 File Offset: 0x00317F49
			internal void DNIMHEKGJHB()
			{
				this.ADPIKBBAKHP.ANLKHFOEOND(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F5D RID: 36701 RVA: 0x00319D49 File Offset: 0x00317F49
			internal void OFHCGKJFGDI()
			{
				this.ADPIKBBAKHP.ANLKHFOEOND(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F5E RID: 36702 RVA: 0x00319E7B File Offset: 0x0031807B
			internal void HBJFIOJFBHC()
			{
				this.ADPIKBBAKHP.DBPOHINECLN(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F5F RID: 36703 RVA: 0x00319EAE File Offset: 0x003180AE
			internal void JKEDCEOCPJO()
			{
				this.ADPIKBBAKHP.BAFFPDEAGMJ(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F60 RID: 36704 RVA: 0x00319E7B File Offset: 0x0031807B
			internal void KGKMOLCPDIH()
			{
				this.ADPIKBBAKHP.DBPOHINECLN(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F61 RID: 36705 RVA: 0x00319DAF File Offset: 0x00317FAF
			internal void BJMAIJDIKCN()
			{
				this.ADPIKBBAKHP.NEDOMLPGMJF(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F62 RID: 36706 RVA: 0x00319D7C File Offset: 0x00317F7C
			internal void GBKBDKHPLKG()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F63 RID: 36707 RVA: 0x00319D7C File Offset: 0x00317F7C
			internal void AEINPAGJFME()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F64 RID: 36708 RVA: 0x00319DE2 File Offset: 0x00317FE2
			internal void FIPCLHEKKCA()
			{
				this.ADPIKBBAKHP.FDGKIMCIEAC(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F65 RID: 36709 RVA: 0x00319EAE File Offset: 0x003180AE
			internal void FFEGPHJKMFK()
			{
				this.ADPIKBBAKHP.BAFFPDEAGMJ(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F66 RID: 36710 RVA: 0x00319DAF File Offset: 0x00317FAF
			internal void OFLDIMDDLHM()
			{
				this.ADPIKBBAKHP.NEDOMLPGMJF(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F67 RID: 36711 RVA: 0x00319E7B File Offset: 0x0031807B
			internal void LNDGINDKPFA()
			{
				this.ADPIKBBAKHP.DBPOHINECLN(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F68 RID: 36712 RVA: 0x00319EAE File Offset: 0x003180AE
			internal void JDELIMPGFDJ()
			{
				this.ADPIKBBAKHP.BAFFPDEAGMJ(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F69 RID: 36713 RVA: 0x00319E15 File Offset: 0x00318015
			internal void DKGPCPBNDPK()
			{
				this.ADPIKBBAKHP.MCGOAGICMHH(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F6A RID: 36714 RVA: 0x00319E15 File Offset: 0x00318015
			internal void BFEABMIFIEE()
			{
				this.ADPIKBBAKHP.MCGOAGICMHH(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F6B RID: 36715 RVA: 0x00319E48 File Offset: 0x00318048
			internal void MGENGAEDACG()
			{
				this.ADPIKBBAKHP.KPFIBDBAKFD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F6C RID: 36716 RVA: 0x00319E7B File Offset: 0x0031807B
			internal void PIJAOCFAPKC()
			{
				this.ADPIKBBAKHP.DBPOHINECLN(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F6D RID: 36717 RVA: 0x00319DE2 File Offset: 0x00317FE2
			internal void FJDBPPKABJE()
			{
				this.ADPIKBBAKHP.FDGKIMCIEAC(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F6E RID: 36718 RVA: 0x00319D16 File Offset: 0x00317F16
			internal void LJDLIIIPIIJ()
			{
				this.ADPIKBBAKHP.LOPHEOINMLD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F6F RID: 36719 RVA: 0x00319D16 File Offset: 0x00317F16
			internal void IGFOBPKFCDJ()
			{
				this.ADPIKBBAKHP.LOPHEOINMLD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F70 RID: 36720 RVA: 0x00319DAF File Offset: 0x00317FAF
			internal void MEMPOPNAEDN()
			{
				this.ADPIKBBAKHP.NEDOMLPGMJF(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F71 RID: 36721 RVA: 0x00319E15 File Offset: 0x00318015
			internal void BKNHHGBPLGH()
			{
				this.ADPIKBBAKHP.MCGOAGICMHH(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F72 RID: 36722 RVA: 0x00319EAE File Offset: 0x003180AE
			internal void EFAPFFFGOOA()
			{
				this.ADPIKBBAKHP.BAFFPDEAGMJ(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F73 RID: 36723 RVA: 0x00319D16 File Offset: 0x00317F16
			internal void JBAJEMGOPDL()
			{
				this.ADPIKBBAKHP.LOPHEOINMLD(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F74 RID: 36724 RVA: 0x00319DAF File Offset: 0x00317FAF
			internal void KFNBKFELFLH()
			{
				this.ADPIKBBAKHP.NEDOMLPGMJF(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F75 RID: 36725 RVA: 0x00319EAE File Offset: 0x003180AE
			internal void FHFECFLBHMA()
			{
				this.ADPIKBBAKHP.BAFFPDEAGMJ(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x06008F76 RID: 36726 RVA: 0x00319D49 File Offset: 0x00317F49
			internal void AGJKEBOPIOC()
			{
				this.ADPIKBBAKHP.ANLKHFOEOND(this.KHENJDBAKIF);
				if (this.DBIMJHMKHNK.OnSelect != null)
				{
					this.DBIMJHMKHNK.OnSelect();
				}
			}

			// Token: 0x04001084 RID: 4228
			internal int KHENJDBAKIF;

			// Token: 0x04001085 RID: 4229
			internal DropDownListItem DBIMJHMKHNK;

			// Token: 0x04001086 RID: 4230
			internal DropDownList ADPIKBBAKHP;
		}
	}
}
