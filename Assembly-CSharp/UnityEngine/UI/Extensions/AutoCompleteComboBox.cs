using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200024A RID: 586
	[AddComponentMenu("UI/Extensions/AutoComplete ComboBox")]
	[RequireComponent(typeof(RectTransform))]
	public class AutoCompleteComboBox : MonoBehaviour
	{
		// Token: 0x06008D47 RID: 36167 RVA: 0x0030A355 File Offset: 0x00308555
		public void LFHKGIHNONL()
		{
			this.OONDPKFKGCE();
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x0030A360 File Offset: 0x00308560
		private bool GBDIEJEECOK()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("_Amount").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Set sun min/max size").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("ShowSprite").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_BlurSize").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("_TimeX").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_ScreenResolution").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1267f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Clamped;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find(", ").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("ready");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.FKBPBNPIFBA();
			return result;
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x0030A53C File Offset: 0x0030873C
		private void HICDLIKCOKE(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.BJMAIJDIKCN)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(true);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.LADECCOJPPL)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(false);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x0030A684 File Offset: 0x00308884
		public void HHNNLOEGDEF()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x0030A68D File Offset: 0x0030888D
		public int EBAFLBMJDGN()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x0030A698 File Offset: 0x00308898
		private void EMPLCLJBOBP()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 1;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "UseFinalGlassColor" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[5];
					array[0] = " | ";
					array[1] = i;
					array[4] = "Most likely the game became empty during the switch to GameServer.";
					array[8] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("OK").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.LHHFJBIAHCN));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x0030A68D File Offset: 0x0030888D
		public int CMDMFJHPOFN()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x0030A8CC File Offset: 0x00308ACC
		public void CDCKGIGIDJC(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.HAFNHMNDNOG();
		}

		// Token: 0x06008D4F RID: 36175 RVA: 0x0030A8DC File Offset: 0x00308ADC
		private void KCNOKKMJKJJ(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.DKGPCPBNDPK)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(true);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.HJKJAANIFLL)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(false);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x0030AA24 File Offset: 0x00308C24
		private void KIFBCJELFBD(string DBIMJHMKHNK)
		{
			this.HGEKKLDNHMK(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.DLBKIDOPOED();
			this.ToggleDropdownPanel(false);
		}

		// Token: 0x06008D51 RID: 36177 RVA: 0x0030AA48 File Offset: 0x00308C48
		private void JKEELHHJIGO(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.JBAJEMGOPDL)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(true);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.HMMBBDJNGGL)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(false);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string MNOAHCKDOGF()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008D53 RID: 36179 RVA: 0x0030AB98 File Offset: 0x00308D98
		public void ABOOAANMLIL(string GFHFLBENAHE)
		{
			this.MGLNEPKFHAE(GFHFLBENAHE);
			this.JKEELHHJIGO(GFHFLBENAHE);
			this.MDIIHPHHGEG();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = false;
				this.FNCDHNCOOBL(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.AJDBLDPBCMG(true);
			}
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x0030ABEE File Offset: 0x00308DEE
		public void MFAMHKBMBEI()
		{
			this.KIAEAENCBJD();
		}

		// Token: 0x06008D55 RID: 36181 RVA: 0x0030ABF8 File Offset: 0x00308DF8
		public void EPCMFJDKJLD(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008D56 RID: 36182 RVA: 0x0030AC4C File Offset: 0x00308E4C
		private void MDIIHPHHGEG()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.NDBELDFLAIH()) ? 1922f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.BHGFIDFLPDN());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1759f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.NFNGKIJFBCJ.Count < 1)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 1770f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(839f, 925f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 724f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem GPOIPCBKJBI()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x0030AED0 File Offset: 0x003090D0
		private void MGLNEPKFHAE(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x0030AEDC File Offset: 0x003090DC
		public void AJDBLDPBCMG(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008D5A RID: 36186 RVA: 0x0030AF30 File Offset: 0x00309130
		private void MADMJBPFDBF()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.ItemsToDisplay) ? 872f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.NDBELDFLAIH());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1870f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.NFNGKIJFBCJ.Count < 0)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 1705f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(514f, 496f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1390f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008D5B RID: 36187 RVA: 0x0030B1AC File Offset: 0x003093AC
		private bool IKDINNIGHLL()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("ScrollPanel").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("SpawnObj").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("_Value2").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("isBunned").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("1159514800").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("settings_bindings_sec_").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 511f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Clamped;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("_ScreenResolution").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("in seconds. 0 - forever");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.FKBPBNPIFBA();
			return result;
		}

		// Token: 0x06008D5C RID: 36188 RVA: 0x0030B388 File Offset: 0x00309588
		private void HAFNHMNDNOG()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.NDBELDFLAIH()) ? 1456f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.ItemsToDisplay);
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(631f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, true);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.NFNGKIJFBCJ.Count < 0)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 1854f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(814f, 1973f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 407f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06008D9F RID: 36255 RVA: 0x0030AEC8 File Offset: 0x003090C8
		// (set) Token: 0x06008D5D RID: 36189 RVA: 0x0030B604 File Offset: 0x00309804
		public DropDownListItem SelectedItem { get; private set; }

		// Token: 0x06008D5E RID: 36190 RVA: 0x0030B60D File Offset: 0x0030980D
		public float CHNDBBHKEDO()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem MLHAHDKKJOM()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x0030B615 File Offset: 0x00309815
		public void NFNJANJMFDB(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.MCAJPFOEDNP();
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x0030B615 File Offset: 0x00309815
		public void HKLAMBLHHNG(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.MCAJPFOEDNP();
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x0030B60D File Offset: 0x0030980D
		public float GKGNJKCCJEL()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008D63 RID: 36195 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string JKKJNDPILHL()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x0030A68D File Offset: 0x0030888D
		public int MEDAEPMPLFH()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008D65 RID: 36197 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string NECDJCNLIGG()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x0030B624 File Offset: 0x00309824
		private void GFJEMNMCENC()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 1;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "/" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num++;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[0];
					array[0] = "Left Stick Click";
					array[0] = i;
					array[3] = "[";
					array[4] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("NewMapHandsCountSlider").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.AEINPAGJFME));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x0030B858 File Offset: 0x00309A58
		public void OKJLMBHCINC(string GFHFLBENAHE)
		{
			this.AKPJJFGLKNN(GFHFLBENAHE);
			this.HNLPOHNHEPG(GFHFLBENAHE);
			this.ELNHKEHJDAA();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.ToggleDropdownPanel(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.FNCDHNCOOBL(false);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06008D87 RID: 36231 RVA: 0x0030AB90 File Offset: 0x00308D90
		// (set) Token: 0x06008D68 RID: 36200 RVA: 0x0030AED0 File Offset: 0x003090D0
		public string Text { get; private set; }

		// Token: 0x06008D69 RID: 36201 RVA: 0x0030B8B0 File Offset: 0x00309AB0
		private bool CHGIHAHIENE()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("_Value").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("float,0").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("Event Received").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("Done!").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("Left Stick Click").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("ClearEnvironment").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 26f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)8;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("ConfigVersionSlider").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError(".lastCheckpoint.time");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.MLGDBCKOBJH();
			return result;
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x0030BA8C File Offset: 0x00309C8C
		private void NIJOGDGGCHN()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.ItemsToDisplay) ? 1314f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.CMDMFJHPOFN());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1072f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.NFNGKIJFBCJ.Count < 0)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 913f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(1710f, 754f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 521f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x0030BD08 File Offset: 0x00309F08
		public void AMPAMEHHKML(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.HCLNEHEFOOC();
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x0030A68D File Offset: 0x0030888D
		public int BHGFIDFLPDN()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008D6D RID: 36205 RVA: 0x0030B60D File Offset: 0x0030980D
		public float NLEHJCEPNNM()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x0030BD17 File Offset: 0x00309F17
		public void GOGGEENKDBF(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.NIJOGDGGCHN();
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x0030BD26 File Offset: 0x00309F26
		private void NICHBHIMHHA(string DBIMJHMKHNK)
		{
			this.AKPJJFGLKNN(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.MNOAHCKDOGF();
			this.ToggleDropdownPanel(false);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06008D70 RID: 36208 RVA: 0x0030A68D File Offset: 0x0030888D
		// (set) Token: 0x06008DCF RID: 36303 RVA: 0x0030F968 File Offset: 0x0030DB68
		public int ItemsToDisplay
		{
			get
			{
				return this._itemsToDisplay;
			}
			set
			{
				this._itemsToDisplay = value;
				this.ELNHKEHJDAA();
			}
		}

		// Token: 0x06008D71 RID: 36209 RVA: 0x0030BD47 File Offset: 0x00309F47
		private void JKBCPINJEAO(string DBIMJHMKHNK)
		{
			this.Text = DBIMJHMKHNK;
			this.IBPLEDAHDCF.text = this.Text;
			this.ToggleDropdownPanel(true);
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x0030BD68 File Offset: 0x00309F68
		public void BGMNKNKMCDF(string GFHFLBENAHE)
		{
			this.NCOOLHNBLNB(GFHFLBENAHE);
			this.BNGMFAFEOGF(GFHFLBENAHE);
			this.HCLNEHEFOOC();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = false;
				this.AJDBLDPBCMG(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.EPCMFJDKJLD(false);
			}
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x0030BDC0 File Offset: 0x00309FC0
		private void INPGCNJFFGP()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new." + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num += 0;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[4];
					array[1] = "#md5submitionfailed: ";
					array[0] = i;
					array[3] = "_Value4";
					array[5] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("menutheme.deleted").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.DBFPGFHEGKA));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x0030BFF4 File Offset: 0x0030A1F4
		private bool KIAEAENCBJD()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("visible").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Preparing content...").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("settings.arcsdestroydelay").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("remaining: {0:0.000}").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("x").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("#lives").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 378f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)4;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("CameraFilterPack/FX_Glitch2").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError(".");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.LPHELLEIAHJ();
			return result;
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x0030C1D0 File Offset: 0x0030A3D0
		private void HEGCJKGPNOK(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.BMAOCLKPNNC)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(true);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.JPGFOBNOBKN)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(false);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x0030A68D File Offset: 0x0030888D
		public int NDBELDFLAIH()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x0030C318 File Offset: 0x0030A518
		public void GHMGGIEGEHA(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.LBMNIPAEEFI();
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x0030C327 File Offset: 0x0030A527
		private void JFDIAKNJEDF(string DBIMJHMKHNK)
		{
			this.NCOOLHNBLNB(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.NECDJCNLIGG();
			this.EPCMFJDKJLD(true);
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x0030C348 File Offset: 0x0030A548
		private void LPHELLEIAHJ()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "_Value4" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[6];
					array[1] = "{0}{1}{2}={3}";
					array[0] = i;
					array[1] = "arcs";
					array[7] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find(".GoalProgress").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.IGFOBPKFCDJ));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x0030B604 File Offset: 0x00309804
		private void PMAPLELCHAH(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x0030C57C File Offset: 0x0030A77C
		private void CLFLOKAGNPI(string DBIMJHMKHNK)
		{
			this.HGEKKLDNHMK(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.PBCFGHJKFEP();
			this.NOKOKEEMDCK(false);
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x0030C5A0 File Offset: 0x0030A7A0
		private void ELNHKEHJDAA()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.ItemsToDisplay) ? 0f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.ItemsToDisplay);
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(0f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.NFNGKIJFBCJ.Count < 1)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 5f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(5f, 0f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x0030C81C File Offset: 0x0030AA1C
		private void LBMNIPAEEFI()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.NDBELDFLAIH()) ? 730f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.ItemsToDisplay);
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(693f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.NFNGKIJFBCJ.Count < 0)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 847f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(421f, 1158f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 511f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x0030B604 File Offset: 0x00309804
		private void JLEDCLHJKDO(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008D7F RID: 36223 RVA: 0x0030CA98 File Offset: 0x0030AC98
		private void PHFMNMPPAMF(string DBIMJHMKHNK)
		{
			this.Text = DBIMJHMKHNK;
			this.IBPLEDAHDCF.text = this.Text;
			this.FNCDHNCOOBL(false);
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x0030AED0 File Offset: 0x003090D0
		private void HGEKKLDNHMK(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string DLBKIDOPOED()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x0030CABC File Offset: 0x0030ACBC
		public void NOKOKEEMDCK(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008D83 RID: 36227 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem IACCKBGEMEL()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x0030CB0F File Offset: 0x0030AD0F
		public void PPGKBEJLBFJ()
		{
			this.CHGIHAHIENE();
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x0030CB18 File Offset: 0x0030AD18
		private bool FIMBCPOBFFA()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("0 - default, 1 - left, 2 - right").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("COMPLETED").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("maps.").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_ToneCurveRange").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("Set Arcs Speed").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("LevelNameText").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1024f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)7;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find(". Possible scene loading in progress?").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_TileMaxLoop");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.GFJEMNMCENC();
			return result;
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x0030CCF4 File Offset: 0x0030AEF4
		public void GEPELODHBFN()
		{
			this.MAINKONGBOC();
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x0030CD00 File Offset: 0x0030AF00
		public void FJHENDCENCG(string GFHFLBENAHE)
		{
			this.Text = GFHFLBENAHE;
			this.HEGCJKGPNOK(GFHFLBENAHE);
			this.ELNHKEHJDAA();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.NOKOKEEMDCK(false);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.LPIPGKNFJPA(true);
			}
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x0030BD17 File Offset: 0x00309F17
		public void GONIPMHCDJL(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.NIJOGDGGCHN();
		}

		// Token: 0x06008D8A RID: 36234 RVA: 0x0030CD58 File Offset: 0x0030AF58
		public void EDPKODFJBLF(string GFHFLBENAHE)
		{
			this.AKPJJFGLKNN(GFHFLBENAHE);
			this.BNGMFAFEOGF(GFHFLBENAHE);
			this.MADMJBPFDBF();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.LPIPGKNFJPA(false);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.EPCMFJDKJLD(true);
			}
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x0030AED0 File Offset: 0x003090D0
		private void NCOOLHNBLNB(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008D8C RID: 36236 RVA: 0x0030CDB0 File Offset: 0x0030AFB0
		private void FFIOKMIKHOG(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.GBKBDKHPLKG)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(false);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.HMMBBDJNGGL)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(true);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x0030BD17 File Offset: 0x00309F17
		public void DCPAHKPKIBD(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.NIJOGDGGCHN();
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x0030B604 File Offset: 0x00309804
		private void AHALMIDCLLC(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem FAKEFGJGPEO()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x0030C318 File Offset: 0x0030A518
		public void FGKLIHAMMPH(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.LBMNIPAEEFI();
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x0030CEF8 File Offset: 0x0030B0F8
		private void GIEHEOJGEHC()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 1;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "_Value4" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[]
					{
						"_Near",
						i
					};
					array[1] = "ChatHistoryInputField";
					array[2] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("_ReprojectionMatrix").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.BDGDIDPDBHG));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x0030D12C File Offset: 0x0030B32C
		private void GAMCLAKINEI(string DBIMJHMKHNK)
		{
			this.NCOOLHNBLNB(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.NECDJCNLIGG();
			this.NOKOKEEMDCK(true);
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x0030B604 File Offset: 0x00309804
		private void ANBOBBGJKEI(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x0030D150 File Offset: 0x0030B350
		private void DDJPIILKDMK()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.NDBELDFLAIH()) ? 1872f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.BIPJFGIOFBB());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1092f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.NFNGKIJFBCJ.Count < 1)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 1961f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(65f, 1394f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1169f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string IBIOIEBIMPP()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem GBGCCJPEODG()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x0030D3E0 File Offset: 0x0030B5E0
		private void GPHKDIDKIAG(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.KGKMOLCPDIH)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(false);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.FBGMHPEEIFC)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(true);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x0030D528 File Offset: 0x0030B728
		private void HCLNEHEFOOC()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.BHGFIDFLPDN()) ? 1727f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.NDBELDFLAIH());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(186f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, true);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.NFNGKIJFBCJ.Count < 1)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 1203f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(561f, 371f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 587f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x0030A8CC File Offset: 0x00308ACC
		public void CBHFCPIJMCG(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.HAFNHMNDNOG();
		}

		// Token: 0x06008D9B RID: 36251 RVA: 0x0030D7A4 File Offset: 0x0030B9A4
		private void ANAHPBGCAAD(string DBIMJHMKHNK)
		{
			this.Text = DBIMJHMKHNK;
			this.IBPLEDAHDCF.text = this.JKKJNDPILHL();
			this.EPCMFJDKJLD(false);
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x0030D7C8 File Offset: 0x0030B9C8
		private bool DDEKPGECKCD()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("InputField").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
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
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("ItemTemplate").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.FGPHLABEKEA();
			return result;
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x0030D9A4 File Offset: 0x0030BBA4
		public void OKKFDDEBNOI(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.ELNHKEHJDAA();
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x0030A684 File Offset: 0x00308884
		public void Awake()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem HOJFHHEGICK()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x0030D9B3 File Offset: 0x0030BBB3
		private void PMDABOCHLDJ(string DBIMJHMKHNK)
		{
			this.AKPJJFGLKNN(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.JKKJNDPILHL();
			this.NOKOKEEMDCK(true);
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string BMHKCLAOFAF()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x0030D9D4 File Offset: 0x0030BBD4
		public void GGAKMCPGNAO(string GFHFLBENAHE)
		{
			this.AKPJJFGLKNN(GFHFLBENAHE);
			this.BNGMFAFEOGF(GFHFLBENAHE);
			this.HKDBBKJLNKG();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.NOKOKEEMDCK(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.FNCDHNCOOBL(false);
			}
		}

		// Token: 0x06008DA4 RID: 36260 RVA: 0x0030DA2C File Offset: 0x0030BC2C
		private void GGABEEEANFO()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 1;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "Fill" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num += 0;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[3];
					array[1] = "achievements.26.progress";
					array[0] = i;
					array[4] = "curScn";
					array[2] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("_TimeX").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.KGKMOLCPDIH));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008DA5 RID: 36261 RVA: 0x0030B604 File Offset: 0x00309804
		private void HCNLLCNDLGH(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x0030A355 File Offset: 0x00308555
		public void EMKLCPGKNJL()
		{
			this.OONDPKFKGCE();
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string NBPIJEELAKO()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x0030DC60 File Offset: 0x0030BE60
		private bool MAINKONGBOC()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("CameraFilterPack/Edge_Neon").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("CameraFilterPack_3D_Myst1").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("_ScreenResolution").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("Bad parameters for delete! Use <key>").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("player.neon").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("CameraFilterPack/Gradients_Desert").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 276f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Unrestricted;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("_Value5").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError(" beatThreshold: ");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.GGABEEEANFO();
			return result;
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x0030DE3C File Offset: 0x0030C03C
		private void MLGDBCKOBJH()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "RequestSelectedLevel" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num += 0;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[1];
					array[1] = "maps.";
					array[0] = i;
					array[0] = "HH:mm:ss";
					array[6] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("maps.").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.LLNDDFGPOPL));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x0030B604 File Offset: 0x00309804
		private void DDHOALFLMBO(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x0030E070 File Offset: 0x0030C270
		private void DACPLMPIAFO(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.INHOEMCLAAP)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(true);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.HNMFCOHLALO)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(false);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x0030E1B8 File Offset: 0x0030C3B8
		public void EPFFFDFBFMA()
		{
			this.IKDINNIGHLL();
		}

		// Token: 0x06008DAD RID: 36269 RVA: 0x0030E1C4 File Offset: 0x0030C3C4
		private void BNGMFAFEOGF(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.EFAPFFFGOOA)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(true);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.GDFBBMNOGGD)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(false);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008DAE RID: 36270 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem JGGGPHGNNNH()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x0030E30C File Offset: 0x0030C50C
		private void FKBPBNPIFBA()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 1;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "EditMenu" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num++;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[6];
					array[1] = "Xbox Home";
					array[0] = i;
					array[1] = "/";
					array[5] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("_Blue_R").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.BDGDIDPDBHG));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x0030B604 File Offset: 0x00309804
		private void IFFEJCOEKIF(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008DB1 RID: 36273 RVA: 0x0030E540 File Offset: 0x0030C740
		private void GDAFHNEFGFB(string DBIMJHMKHNK)
		{
			this.AKPJJFGLKNN(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.DLBKIDOPOED();
			this.EPCMFJDKJLD(true);
		}

		// Token: 0x06008DB2 RID: 36274 RVA: 0x0030B604 File Offset: 0x00309804
		private void BFCLBCNHBCP(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008DB3 RID: 36275 RVA: 0x0030B604 File Offset: 0x00309804
		private void HAJCCEONLJN(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008DB4 RID: 36276 RVA: 0x0030A684 File Offset: 0x00308884
		public void AJIKPEIGACI()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008DB5 RID: 36277 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string PBCFGHJKFEP()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008DB6 RID: 36278 RVA: 0x0030E564 File Offset: 0x0030C764
		public void KJKBIOFPJFH(string GFHFLBENAHE)
		{
			this.NCOOLHNBLNB(GFHFLBENAHE);
			this.FFIOKMIKHOG(GFHFLBENAHE);
			this.BHAFIKMGLIB();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = false;
				this.AJDBLDPBCMG(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.FNCDHNCOOBL(false);
			}
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string MLMCNPFHPGH()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x0030E5BC File Offset: 0x0030C7BC
		private void MCAJPFOEDNP()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.EBAFLBMJDGN()) ? 1786f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.EBAFLBMJDGN());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1712f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, false);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.NFNGKIJFBCJ.Count < 0)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 690f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(16f, 1843f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1493f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x0030B60D File Offset: 0x0030980D
		public float GDCPJFBMIDL()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x0030E838 File Offset: 0x0030CA38
		private bool NPDMJNMJJEL()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("_SizeX").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("The given 2D texture ").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("?").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("NO").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("loadscene").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("sfxVolume").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1725f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Clamped;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("_EmissionGain").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("ShineEffect");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.INPGCNJFFGP();
			return result;
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x0030EA14 File Offset: 0x0030CC14
		private bool OONDPKFKGCE()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("Bad parameters for init! Use \"init\" or \"init <savename>\"").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("[RanksSystem] Init").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("settings.fps").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_TimeX").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("Run a command for data system").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("solo").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1360f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)4;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("MenuPlayButton").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("RULES");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.GFJEMNMCENC();
			return result;
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x0030B604 File Offset: 0x00309804
		private void KGBLAPBCHPF(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x0030B60D File Offset: 0x0030980D
		public float LOODEOCKEDD()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x0030EBF0 File Offset: 0x0030CDF0
		public void OCCGEMFOJCN(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.MADMJBPFDBF();
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem JALKKJPKKCJ()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x0030EC00 File Offset: 0x0030CE00
		private void PCFOHGILDDF()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 1;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "_Visualize" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[0];
					array[0] = "Keypad ";
					array[1] = i;
					array[5] = "Health Stats";
					array[7] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.LOEAMHGMMPK));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x0030EE34 File Offset: 0x0030D034
		private void EHEPKOJGNHM()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 1;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "ItemsCountText" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[6];
					array[1] = " not found";
					array[1] = i;
					array[2] = " Owner called.";
					array[7] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("settings.hideui").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.MEMPOPNAEDN));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x0030F068 File Offset: 0x0030D268
		private void FGPHLABEKEA()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string item in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(item);
			}
			this.NFNGKIJFBCJ.Sort();
			this.ADEKGHOJBDP.Clear();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "Item " + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num++;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					AutoCompleteComboBox.ICMCJLOJJEO icmcjlojjeo = new AutoCompleteComboBox.ICMCJLOJJEO();
					icmcjlojjeo.ADPIKBBAKHP = this;
					list[i].name = string.Concat(new object[]
					{
						"Item ",
						i,
						" ",
						this.NFNGKIJFBCJ[i]
					});
					list[i].transform.Find("Text").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					icmcjlojjeo.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(icmcjlojjeo.GBKBDKHPLKG));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x0030F29C File Offset: 0x0030D49C
		public void EDDGAHHJBPJ(string GFHFLBENAHE)
		{
			this.HGEKKLDNHMK(GFHFLBENAHE);
			this.FFIOKMIKHOG(GFHFLBENAHE);
			this.HAFNHMNDNOG();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.LPIPGKNFJPA(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.LPIPGKNFJPA(false);
			}
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x0030F2F2 File Offset: 0x0030D4F2
		public void OOMDBJCBGLL(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.HKDBBKJLNKG();
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x0030F304 File Offset: 0x0030D504
		private bool FEHKOCBOJOK()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("kick").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("_ScreenResolution").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("_SpawnHeuristic").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_DotSize").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("CreateRoom failed. In offline mode you still have to leave a room to enter another.").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("/icon").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1341f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)5;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("#ok").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_Value");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.INPGCNJFFGP();
			return result;
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x0030A355 File Offset: 0x00308555
		public void HBPLJMJAAHK()
		{
			this.OONDPKFKGCE();
		}

		// Token: 0x06008DC7 RID: 36295 RVA: 0x0030F4E0 File Offset: 0x0030D6E0
		private void GKINMOOLNJP(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.KFNBKFELFLH)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(false);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.MMJGKBNKFGM)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(false);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x0030C318 File Offset: 0x0030A518
		public void JOGNGKCDAHH(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.LBMNIPAEEFI();
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x0030F628 File Offset: 0x0030D828
		private void HNLPOHNHEPG(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.LOEAMHGMMPK)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(false);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.GDFBBMNOGGD)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(true);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x0030F770 File Offset: 0x0030D970
		public void OnValueChanged(string GFHFLBENAHE)
		{
			this.Text = GFHFLBENAHE;
			this.FFIOKMIKHOG(GFHFLBENAHE);
			this.ELNHKEHJDAA();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.ToggleDropdownPanel(false);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.ToggleDropdownPanel(false);
			}
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem MDOLINJKFAA()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem DPLIFNMCDOG()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x0030F7C8 File Offset: 0x0030D9C8
		public void CGCEHCDHAGB(string GFHFLBENAHE)
		{
			this.MGLNEPKFHAE(GFHFLBENAHE);
			this.DACPLMPIAFO(GFHFLBENAHE);
			this.HKDBBKJLNKG();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.EPCMFJDKJLD(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.FNCDHNCOOBL(true);
			}
		}

		// Token: 0x06008DCE RID: 36302 RVA: 0x0030F820 File Offset: 0x0030DA20
		private void KNNOCJAPFEB(string GFHFLBENAHE)
		{
			AutoCompleteComboBox.DDMCDJGDIOD ddmcdjgdiod = new AutoCompleteComboBox.DDMCDJGDIOD();
			ddmcdjgdiod.GFHFLBENAHE = GFHFLBENAHE;
			List<string> second = this.NFNGKIJFBCJ.Where(new Func<string, bool>(ddmcdjgdiod.EFAPFFFGOOA)).ToList<string>();
			List<string> list = this.NFNGKIJFBCJ.Except(second).ToList<string>();
			foreach (string text in list)
			{
				this.NFNGAOLFLGA[text].SetActive(false);
				this.NFNGKIJFBCJ.Remove(text);
				this.ADEKGHOJBDP.Add(text);
			}
			List<string> list2 = this.ADEKGHOJBDP.Where(new Func<string, bool>(ddmcdjgdiod.FKCDLJELMNN)).ToList<string>();
			foreach (string text2 in list2)
			{
				this.NFNGAOLFLGA[text2].SetActive(true);
				this.NFNGKIJFBCJ.Add(text2);
				this.ADEKGHOJBDP.Remove(text2);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06008DDF RID: 36319 RVA: 0x0030B60D File Offset: 0x0030980D
		// (set) Token: 0x06008DD0 RID: 36304 RVA: 0x0030D9A4 File Offset: 0x0030BBA4
		public float ScrollBarWidth
		{
			get
			{
				return this._scrollBarWidth;
			}
			set
			{
				this._scrollBarWidth = value;
				this.ELNHKEHJDAA();
			}
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x0030A68D File Offset: 0x0030888D
		public int BIPJFGIOFBB()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x0030F978 File Offset: 0x0030DB78
		public void LFLGNMGIMBI(string GFHFLBENAHE)
		{
			this.Text = GFHFLBENAHE;
			this.GPHKDIDKIAG(GFHFLBENAHE);
			this.MADMJBPFDBF();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = false;
				this.FNCDHNCOOBL(false);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.ToggleDropdownPanel(false);
			}
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x0030AED0 File Offset: 0x003090D0
		private void AKPJJFGLKNN(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x0030BD08 File Offset: 0x00309F08
		public void OPJGKNKEKIM(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.HCLNEHEFOOC();
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x0030A8CC File Offset: 0x00308ACC
		public void IGGLKCAFNJA(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.HAFNHMNDNOG();
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x0030F9D0 File Offset: 0x0030DBD0
		private bool ALIACDAODAH()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("player.blackwhite").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("_PositionY").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("0.00").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("#savemapchanges?").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("_").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_Amount").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 881f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)3;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("PhotonNetwork error: Could not Instantiate the prefab [").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_Value");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.ADEKGHOJBDP = new List<string>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.GFJEMNMCENC();
			return result;
		}

		// Token: 0x06008DD7 RID: 36311 RVA: 0x0030FBAC File Offset: 0x0030DDAC
		public void FNCDHNCOOBL(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008DD8 RID: 36312 RVA: 0x0030AB90 File Offset: 0x00308D90
		public string HJMGJDAHGLB()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x0030FC00 File Offset: 0x0030DE00
		private void BHAFIKMGLIB()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.BHGFIDFLPDN()) ? 661f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.NDBELDFLAIH());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(997f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, true);
			}
			if (this.NFNGKIJFBCJ.Count < 1)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 848f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(1048f, 1273f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 495f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x0030FE7C File Offset: 0x0030E07C
		public void ToggleDropdownPanel(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008DDB RID: 36315 RVA: 0x0030FED0 File Offset: 0x0030E0D0
		public void LPIPGKNFJPA(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008DDC RID: 36316 RVA: 0x0030B60D File Offset: 0x0030980D
		public float KNIGMLEGFNJ()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x0030FF24 File Offset: 0x0030E124
		private void HKDBBKJLNKG()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.MEDAEPMPLFH()) ? 1522f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.CMDMFJHPOFN());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(27f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.NFNGKIJFBCJ.Count < 1)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 440f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(197f, 1609f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 885f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x003101A0 File Offset: 0x0030E3A0
		public void AKDDPDDAAOJ(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.BHAFIKMGLIB();
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x0030AEC8 File Offset: 0x003090C8
		public DropDownListItem KODLKJEHJAG()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008DE1 RID: 36321 RVA: 0x0030F968 File Offset: 0x0030DB68
		public void AMECNIGFOGB(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.ELNHKEHJDAA();
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x0030B60D File Offset: 0x0030980D
		public float BHEPNEEOBIE()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x003101B0 File Offset: 0x0030E3B0
		public void GIENLEFJFJJ(string GFHFLBENAHE)
		{
			this.MGLNEPKFHAE(GFHFLBENAHE);
			this.HNLPOHNHEPG(GFHFLBENAHE);
			this.LBMNIPAEEFI();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.ToggleDropdownPanel(true);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.ToggleDropdownPanel(true);
			}
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x0030B604 File Offset: 0x00309804
		private void AAPFEDOLOFA(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x04001039 RID: 4153
		public Color disabledTextColor;

		// Token: 0x0400103B RID: 4155
		public List<string> AvailableOptions;

		// Token: 0x0400103C RID: 4156
		public Action<int> OnSelectionChanged;

		// Token: 0x0400103D RID: 4157
		private bool BCENJFOJJOL;

		// Token: 0x0400103E RID: 4158
		private bool MELOHGFLIPB;

		// Token: 0x0400103F RID: 4159
		private InputField IBPLEDAHDCF;

		// Token: 0x04001040 RID: 4160
		private RectTransform ILGPPBGOCLD;

		// Token: 0x04001041 RID: 4161
		private RectTransform IHOLCKOEPAP;

		// Token: 0x04001042 RID: 4162
		private RectTransform AAHLPFMBPJP;

		// Token: 0x04001043 RID: 4163
		private RectTransform ICLMGGNADNO;

		// Token: 0x04001044 RID: 4164
		private RectTransform NKNMCGNABMC;

		// Token: 0x04001045 RID: 4165
		private RectTransform CNEKHMOIMKC;

		// Token: 0x04001046 RID: 4166
		private RectTransform IGECOMGCEDF;

		// Token: 0x04001047 RID: 4167
		private Canvas AHPDJAGJGNL;

		// Token: 0x04001048 RID: 4168
		private RectTransform DGJKIJJBMOB;

		// Token: 0x04001049 RID: 4169
		private ScrollRect CFNFKMGEGHL;

		// Token: 0x0400104A RID: 4170
		private List<string> NFNGKIJFBCJ;

		// Token: 0x0400104B RID: 4171
		private List<string> ADEKGHOJBDP;

		// Token: 0x0400104C RID: 4172
		private Dictionary<string, GameObject> NFNGAOLFLGA;

		// Token: 0x0400104D RID: 4173
		private GameObject MPANMCLABFG;

		// Token: 0x0400104F RID: 4175
		[SerializeField]
		private float _scrollBarWidth = 20f;

		// Token: 0x04001050 RID: 4176
		[SerializeField]
		private int _itemsToDisplay;

		// Token: 0x0200024B RID: 587
		[CompilerGenerated]
		private sealed class ICMCJLOJJEO
		{
			// Token: 0x06008DE5 RID: 36325 RVA: 0x00310206 File Offset: 0x0030E406
			internal void BMAOCLKPNNC()
			{
				this.ADPIKBBAKHP.PMDABOCHLDJ(this.DNABNBIBCKK);
			}

			// Token: 0x06008DE6 RID: 36326 RVA: 0x00310219 File Offset: 0x0030E419
			internal void OLIGLEMPFOP()
			{
				this.ADPIKBBAKHP.KIFBCJELFBD(this.DNABNBIBCKK);
			}

			// Token: 0x06008DE7 RID: 36327 RVA: 0x00310219 File Offset: 0x0030E419
			internal void DKGPCPBNDPK()
			{
				this.ADPIKBBAKHP.KIFBCJELFBD(this.DNABNBIBCKK);
			}

			// Token: 0x06008DE8 RID: 36328 RVA: 0x0031022C File Offset: 0x0030E42C
			internal void EKHOOPGPPGE()
			{
				this.ADPIKBBAKHP.CLFLOKAGNPI(this.DNABNBIBCKK);
			}

			// Token: 0x06008DE9 RID: 36329 RVA: 0x0031023F File Offset: 0x0030E43F
			internal void LLNDDFGPOPL()
			{
				this.ADPIKBBAKHP.PHFMNMPPAMF(this.DNABNBIBCKK);
			}

			// Token: 0x06008DEA RID: 36330 RVA: 0x00310252 File Offset: 0x0030E452
			internal void GBKBDKHPLKG()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.DNABNBIBCKK);
			}

			// Token: 0x06008DEB RID: 36331 RVA: 0x0031022C File Offset: 0x0030E42C
			internal void LHHFJBIAHCN()
			{
				this.ADPIKBBAKHP.CLFLOKAGNPI(this.DNABNBIBCKK);
			}

			// Token: 0x06008DEC RID: 36332 RVA: 0x00310206 File Offset: 0x0030E406
			internal void BFEABMIFIEE()
			{
				this.ADPIKBBAKHP.PMDABOCHLDJ(this.DNABNBIBCKK);
			}

			// Token: 0x06008DED RID: 36333 RVA: 0x0031023F File Offset: 0x0030E43F
			internal void KGKMOLCPDIH()
			{
				this.ADPIKBBAKHP.PHFMNMPPAMF(this.DNABNBIBCKK);
			}

			// Token: 0x06008DEF RID: 36335 RVA: 0x00310265 File Offset: 0x0030E465
			internal void MEMPOPNAEDN()
			{
				this.ADPIKBBAKHP.NICHBHIMHHA(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF0 RID: 36336 RVA: 0x00310278 File Offset: 0x0030E478
			internal void BKNHHGBPLGH()
			{
				this.ADPIKBBAKHP.GDAFHNEFGFB(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF1 RID: 36337 RVA: 0x00310278 File Offset: 0x0030E478
			internal void EGKGJJGAPMN()
			{
				this.ADPIKBBAKHP.GDAFHNEFGFB(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF2 RID: 36338 RVA: 0x0031022C File Offset: 0x0030E42C
			internal void FJDBPPKABJE()
			{
				this.ADPIKBBAKHP.CLFLOKAGNPI(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF3 RID: 36339 RVA: 0x00310278 File Offset: 0x0030E478
			internal void BDGDIDPDBHG()
			{
				this.ADPIKBBAKHP.GDAFHNEFGFB(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF4 RID: 36340 RVA: 0x00310252 File Offset: 0x0030E452
			internal void LNDGINDKPFA()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF5 RID: 36341 RVA: 0x0031022C File Offset: 0x0030E42C
			internal void FIPCLHEKKCA()
			{
				this.ADPIKBBAKHP.CLFLOKAGNPI(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF6 RID: 36342 RVA: 0x0031028B File Offset: 0x0030E48B
			internal void LOEAMHGMMPK()
			{
				this.ADPIKBBAKHP.JFDIAKNJEDF(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF7 RID: 36343 RVA: 0x0031029E File Offset: 0x0030E49E
			internal void KFNBKFELFLH()
			{
				this.ADPIKBBAKHP.GAMCLAKINEI(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF8 RID: 36344 RVA: 0x0031028B File Offset: 0x0030E48B
			internal void IGFOBPKFCDJ()
			{
				this.ADPIKBBAKHP.JFDIAKNJEDF(this.DNABNBIBCKK);
			}

			// Token: 0x06008DF9 RID: 36345 RVA: 0x0031022C File Offset: 0x0030E42C
			internal void JDELIMPGFDJ()
			{
				this.ADPIKBBAKHP.CLFLOKAGNPI(this.DNABNBIBCKK);
			}

			// Token: 0x06008DFA RID: 36346 RVA: 0x0031023F File Offset: 0x0030E43F
			internal void FFEGPHJKMFK()
			{
				this.ADPIKBBAKHP.PHFMNMPPAMF(this.DNABNBIBCKK);
			}

			// Token: 0x06008DFB RID: 36347 RVA: 0x00310252 File Offset: 0x0030E452
			internal void JKEDCEOCPJO()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.DNABNBIBCKK);
			}

			// Token: 0x06008DFC RID: 36348 RVA: 0x00310252 File Offset: 0x0030E452
			internal void AEINPAGJFME()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.DNABNBIBCKK);
			}

			// Token: 0x06008DFD RID: 36349 RVA: 0x0031022C File Offset: 0x0030E42C
			internal void OFHCGKJFGDI()
			{
				this.ADPIKBBAKHP.CLFLOKAGNPI(this.DNABNBIBCKK);
			}

			// Token: 0x06008DFE RID: 36350 RVA: 0x003102B1 File Offset: 0x0030E4B1
			internal void PBCAHKDLFPE()
			{
				this.ADPIKBBAKHP.ANAHPBGCAAD(this.DNABNBIBCKK);
			}

			// Token: 0x06008DFF RID: 36351 RVA: 0x00310206 File Offset: 0x0030E406
			internal void AGJKEBOPIOC()
			{
				this.ADPIKBBAKHP.PMDABOCHLDJ(this.DNABNBIBCKK);
			}

			// Token: 0x06008E00 RID: 36352 RVA: 0x00310219 File Offset: 0x0030E419
			internal void DBFPGFHEGKA()
			{
				this.ADPIKBBAKHP.KIFBCJELFBD(this.DNABNBIBCKK);
			}

			// Token: 0x04001051 RID: 4177
			internal string DNABNBIBCKK;

			// Token: 0x04001052 RID: 4178
			internal AutoCompleteComboBox ADPIKBBAKHP;
		}

		// Token: 0x0200024C RID: 588
		[CompilerGenerated]
		private sealed class DDMCDJGDIOD
		{
			// Token: 0x06008E01 RID: 36353 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool HIKCHCCKLJG(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E02 RID: 36354 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool AEIFJLBBKBP(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E03 RID: 36355 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool AHBIANHNBBC(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E04 RID: 36356 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool BMAOCLKPNNC(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E05 RID: 36357 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool OFLDIMDDLHM(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E06 RID: 36358 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool BJMAIJDIKCN(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E07 RID: 36359 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool INHOEMCLAAP(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E08 RID: 36360 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool FBGMHPEEIFC(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E09 RID: 36361 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool EEBODGOFEGB(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E0A RID: 36362 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool HBJFIOJFBHC(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E0B RID: 36363 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool AEINPAGJFME(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E0C RID: 36364 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool DKGPCPBNDPK(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E0D RID: 36365 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool FHFECFLBHMA(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E0E RID: 36366 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool PBCAHKDLFPE(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E0F RID: 36367 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool LJDLIIIPIIJ(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E10 RID: 36368 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool OMJJLDBPEHI(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E11 RID: 36369 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool FHIJCPPECHA(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E12 RID: 36370 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool EKHOOPGPPGE(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E13 RID: 36371 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool DGDCNDCGPCP(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E14 RID: 36372 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool FKCDLJELMNN(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E15 RID: 36373 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool GBKBDKHPLKG(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E16 RID: 36374 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool LLNDDFGPOPL(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E17 RID: 36375 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool EFAPFFFGOOA(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E18 RID: 36376 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool KFNBKFELFLH(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E19 RID: 36377 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool GDFBBMNOGGD(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E1A RID: 36378 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool HJKJAANIFLL(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E1B RID: 36379 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool FCAGEDLBBHD(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E1C RID: 36380 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool LADECCOJPPL(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E1D RID: 36381 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool JBCHBMKPDAJ(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E1F RID: 36383 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool GLLCFMBPDEG(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E20 RID: 36384 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool HNMFCOHLALO(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E21 RID: 36385 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool KGKMOLCPDIH(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E22 RID: 36386 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool AGJKEBOPIOC(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E23 RID: 36387 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool PHFMMNELDEA(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E24 RID: 36388 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool DAICIOGOPNL(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E25 RID: 36389 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool DFHFAFAJGBA(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E26 RID: 36390 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool BEBAENEJFLD(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E27 RID: 36391 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool LOEAMHGMMPK(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E28 RID: 36392 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool NGFGLJGABCM(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E29 RID: 36393 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool JBAJEMGOPDL(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E2A RID: 36394 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool JPGFOBNOBKN(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E2B RID: 36395 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool LKLABDAJAEH(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E2C RID: 36396 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool PHGILLBNBME(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E2D RID: 36397 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool MMJGKBNKFGM(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E2E RID: 36398 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool HMMBBDJNGGL(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E2F RID: 36399 RVA: 0x003102D7 File Offset: 0x0030E4D7
			internal bool DBFPGFHEGKA(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE.ToLower());
			}

			// Token: 0x06008E30 RID: 36400 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool JGEDLMKBGGL(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x06008E31 RID: 36401 RVA: 0x003102C4 File Offset: 0x0030E4C4
			internal bool NLALPCHCOPE(string IACGDFHKCAE)
			{
				return IACGDFHKCAE.ToLower().Contains(this.GFHFLBENAHE);
			}

			// Token: 0x04001053 RID: 4179
			internal string GFHFLBENAHE;
		}
	}
}
