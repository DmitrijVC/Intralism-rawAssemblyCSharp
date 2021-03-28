using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200024D RID: 589
	[AddComponentMenu("UI/Extensions/ComboBox")]
	[RequireComponent(typeof(RectTransform))]
	public class ComboBox : MonoBehaviour
	{
		// Token: 0x06008E32 RID: 36402 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float IBDMJAGJNNA()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x003102F7 File Offset: 0x0030E4F7
		public void HGBALOJOFKC(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.PPDJAFCOCEE();
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x00310306 File Offset: 0x0030E506
		public void BFFHPJMMGHD()
		{
			this.CNCGKHOOCGI();
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x0031030F File Offset: 0x0030E50F
		public string BMGBJHENOPJ()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x00310317 File Offset: 0x0030E517
		public void ADAHDOKBPOF(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.ELNHKEHJDAA();
		}

		// Token: 0x06008E37 RID: 36407 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float JMONNFADKDF()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008E38 RID: 36408 RVA: 0x00310328 File Offset: 0x0030E528
		private void LKKKBBOANKF()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "Right Stick Click" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[]
					{
						null,
						"ComboScoreText"
					};
					array[0] = i;
					array[4] = "\"";
					array[3] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("settings.volume.menu").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.BFEABMIFIEE));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008E39 RID: 36409 RVA: 0x00310554 File Offset: 0x0030E754
		private void DAHFJOCGHCJ(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E3A RID: 36410 RVA: 0x0031055D File Offset: 0x0030E75D
		public DropDownListItem ACDGDIFAFEH()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x00310565 File Offset: 0x0030E765
		private void BMMIGGPOPCO(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x0031056E File Offset: 0x0030E76E
		public void AFGMEBBBJCK(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.IGOACJDBECD();
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x0031057D File Offset: 0x0030E77D
		public void JIJPHEDDIHC()
		{
			this.EHMGKLLKINB();
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x00310588 File Offset: 0x0030E788
		private bool MPDAMDDPPAJ()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("inventory.itemscash").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("finished").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("finished").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("[Down]").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("CameraFilterPack/Blend2Camera_Divide").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("Using Stopwatch as precision timer for PUN.").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 790f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Elastic;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("_MainTex2").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("ConfigVersionSlider");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.FGPHLABEKEA();
			return result;
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x0031075C File Offset: 0x0030E95C
		public void BGPAFBBJEKN(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008E40 RID: 36416 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int MEDBOLENOOB()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x003107B7 File Offset: 0x0030E9B7
		public void HGGDGACFJBP(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.EKENPPADICP();
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float IPIIKCFBNAL()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x0031056E File Offset: 0x0030E76E
		public void GFPKIBMGCPC(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.IGOACJDBECD();
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06008E6D RID: 36461 RVA: 0x0031055D File Offset: 0x0030E75D
		// (set) Token: 0x06008E44 RID: 36420 RVA: 0x00310565 File Offset: 0x0030E765
		public DropDownListItem SelectedItem { get; private set; }

		// Token: 0x06008E46 RID: 36422 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int BLAIPEBIDCH()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E47 RID: 36423 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int CHNHNPPMDHK()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int JOELHOPJLCG()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float MILFNMFHOFI()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x00310565 File Offset: 0x0030E765
		private void BPJNEAINIBP(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06008E4B RID: 36427 RVA: 0x003107AF File Offset: 0x0030E9AF
		// (set) Token: 0x06008E8A RID: 36490 RVA: 0x00312A94 File Offset: 0x00310C94
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

		// Token: 0x06008E4C RID: 36428 RVA: 0x003107DC File Offset: 0x0030E9DC
		public void GIENLEFJFJJ(string GFHFLBENAHE)
		{
			this.EJIFKCNINFP(GFHFLBENAHE);
			this.ELNHKEHJDAA();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = false;
				this.DOLMFPKAAPL(false);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.DOLMFPKAAPL(false);
			}
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x003107B7 File Offset: 0x0030E9B7
		public void LBLLPKHAHLJ(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.EKENPPADICP();
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x00310554 File Offset: 0x0030E754
		private void JMIDCLCLCJM(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x0031082B File Offset: 0x0030EA2B
		public void BMCAMJKMNNF(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.EKENPPADICP();
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x0031083C File Offset: 0x0030EA3C
		private void CCFHJBJIGIB()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "Tab1Content" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[7];
					array[0] = "]";
					array[0] = i;
					array[1] = "offline room";
					array[2] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("Set Crosshair Color").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.DBFPGFHEGKA));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x00310A68 File Offset: 0x0030EC68
		public void GDHMJGBAGHP()
		{
			this.IHEIAKNNJIE();
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00310A74 File Offset: 0x0030EC74
		private void AOPCIDDINMJ()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.GPNDBHLPKCL()) ? 1258f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.MEDBOLENOOB());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1486f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, true);
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
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 32f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(1641f, 1887f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1973f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00310CF0 File Offset: 0x0030EEF0
		private bool IHEIAKNNJIE()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("_MiddleGrey").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("{0}sec average:").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("_Value4").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("offsets").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("EventSystem").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find(",").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1730f;
				this.CFNFKMGEGHL.movementType = ScrollRect.MovementType.Elastic;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("_MainTex").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError(") of this PhotonView does not implement OnPhotonSerializeView()!");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.AJOHEKAMNAK();
			return result;
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x00310554 File Offset: 0x0030E754
		private void JJPDGMODLHB(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float PCEKJPAPPEO()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x00310EC4 File Offset: 0x0030F0C4
		private bool CNCGKHOOCGI()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("Jan").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Internal LUT").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find(": ").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("FinalScoreSmallText").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("no lives color").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 331f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)6;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("inventory.selected.").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("/");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.ACLBFEOCNAC();
			return result;
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x00310565 File Offset: 0x0030E765
		private void ANBOBBGJKEI(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x00311098 File Offset: 0x0030F298
		private bool EHMGKLLKINB()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("CameraFilterPack/Pixelisation_OilPaintHQ").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("_BaseTex").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("Operation failed: ").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_SpotSize").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("EndlessLoopsScoreText").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_BlurVector").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 602f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)6;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("_TimeX").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("Bad parameters for reset! Use \"reset <challengeid>\"");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.FGPHLABEKEA();
			return result;
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x0031126C File Offset: 0x0030F46C
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
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.FGPHLABEKEA();
			return result;
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x0031057D File Offset: 0x0030E77D
		public void OBAIHNFOJGN()
		{
			this.EHMGKLLKINB();
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int GPACFLMMHKH()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x00311440 File Offset: 0x0030F640
		private void AJOHEKAMNAK()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = " (inactive)" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[3];
					array[0] = "ERROR: preview file name is empty in modName.workshop.json";
					array[1] = i;
					array[7] = "?page=addtip";
					array[1] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("_SpotSize").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.BKNHHGBPLGH));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x0031166C File Offset: 0x0030F86C
		private void EKENPPADICP()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.OPEICCMAALH()) ? 1072f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.BIPJFGIOFBB());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1793f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.NFNGKIJFBCJ.Count < 0)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 778f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(889f, 1302f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1177f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x003118E8 File Offset: 0x0030FAE8
		public void PIIMBOLGHOE()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008E5F RID: 36447 RVA: 0x003118F4 File Offset: 0x0030FAF4
		private bool IFJGGEAMFON()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find(",").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Horizontal").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("CameraFilterPack/3D_Anomaly").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("_Value7").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("_Value2").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("Hidden/Image Effects/Cinematic/AmbientOcclusion").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 14f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)5;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("EventData0DropDownList").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("settings.enablerankingnotifications");
				result = true;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.INPGCNJFFGP();
			return result;
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x003118E8 File Offset: 0x0030FAE8
		public void JNBMKLFJCEM()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x00310565 File Offset: 0x0030E765
		private void MHGOGBNBDFE(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x00311AC8 File Offset: 0x0030FCC8
		public void ENJMFNIKBDE(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.AOPCIDDINMJ();
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06008E63 RID: 36451 RVA: 0x003102EF File Offset: 0x0030E4EF
		// (set) Token: 0x06008E6C RID: 36460 RVA: 0x00310317 File Offset: 0x0030E517
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

		// Token: 0x06008E64 RID: 36452 RVA: 0x00311AD7 File Offset: 0x0030FCD7
		private void JKBCPINJEAO(string DBIMJHMKHNK)
		{
			this.Text = DBIMJHMKHNK;
			this.IBPLEDAHDCF.text = this.Text;
			this.ToggleDropdownPanel(true);
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x00311AF8 File Offset: 0x0030FCF8
		private void IGOACJDBECD()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.ItemsToDisplay) ? 473f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.FCCBJGNBBOM());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1899f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
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
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 4f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(912f, 476f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 821f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x00311D74 File Offset: 0x0030FF74
		public void CMBAPNEBMJD(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008E67 RID: 36455 RVA: 0x00311DC8 File Offset: 0x0030FFC8
		public void DOLMFPKAAPL(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008E68 RID: 36456 RVA: 0x00311E1B File Offset: 0x0031001B
		private void GDAFHNEFGFB(string DBIMJHMKHNK)
		{
			this.JMIDCLCLCJM(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.AFMAFNEGLDP();
			this.BGPAFBBJEKN(false);
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int FCCBJGNBBOM()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int GPNDBHLPKCL()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int OPEICCMAALH()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int KHLEODFDFGN()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E6F RID: 36463 RVA: 0x0031055D File Offset: 0x0030E75D
		public DropDownListItem HGPGGKKLLEE()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008E70 RID: 36464 RVA: 0x00311E3C File Offset: 0x0031003C
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

		// Token: 0x06008E71 RID: 36465 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int BIPJFGIOFBB()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E72 RID: 36466 RVA: 0x0031030F File Offset: 0x0030E50F
		public string HEPOCNIIIOB()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06008E89 RID: 36489 RVA: 0x0031030F File Offset: 0x0030E50F
		// (set) Token: 0x06008E73 RID: 36467 RVA: 0x00310554 File Offset: 0x0030E754
		public string Text { get; private set; }

		// Token: 0x06008E74 RID: 36468 RVA: 0x00311E90 File Offset: 0x00310090
		private void INPGCNJFFGP()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "_Value2" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num += 0;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[1];
					array[0] = "settings.volume.game";
					array[1] = i;
					array[1] = "#tryagain";
					array[3] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("player.deleted").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.BKNHHGBPLGH));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x003118E8 File Offset: 0x0030FAE8
		public void Awake()
		{
			this.DDEKPGECKCD();
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x00310554 File Offset: 0x0030E754
		private void EJIFKCNINFP(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x003120BC File Offset: 0x003102BC
		private bool LPEKIBGLFOE()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("Coord").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("BadgeText").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("#yes").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("Run a command for data system").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("ItemsCountText").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_U").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 256f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)6;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("_Blue_G").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("Image_");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.INPGCNJFFGP();
			return result;
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int EAFGKGPDOJG()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x00312290 File Offset: 0x00310490
		public void BIICGJJLPLE(bool DPLLMKAPDIM)
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

		// Token: 0x06008E7A RID: 36474 RVA: 0x003122E3 File Offset: 0x003104E3
		private void CDMOADFJEIC(string DBIMJHMKHNK)
		{
			this.Text = DBIMJHMKHNK;
			this.IBPLEDAHDCF.text = this.BMGBJHENOPJ();
			this.FFHMKNHBICF(false);
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x00312304 File Offset: 0x00310504
		public void AHOBEKAANME(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.IGOACJDBECD();
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x00312314 File Offset: 0x00310514
		public void HJBJMKGJCGL(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008E7D RID: 36477 RVA: 0x00312368 File Offset: 0x00310568
		public void FFHMKNHBICF(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008E7E RID: 36478 RVA: 0x003123BC File Offset: 0x003105BC
		private void ACLBFEOCNAC()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "received</b>\n#reason: " + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num += 0;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[4];
					array[0] = "_Value2";
					array[1] = i;
					array[7] = " not exist";
					array[7] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("[Up]").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.MEMPOPNAEDN));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00310565 File Offset: 0x0030E765
		private void BNLGAPBPGHA(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x003125E8 File Offset: 0x003107E8
		public void NFKFEANHOLD(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.PPDJAFCOCEE();
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x003125F7 File Offset: 0x003107F7
		private void PHFMNMPPAMF(string DBIMJHMKHNK)
		{
			this.EJIFKCNINFP(DBIMJHMKHNK);
			this.IBPLEDAHDCF.text = this.BMGBJHENOPJ();
			this.DOLMFPKAAPL(true);
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x00312618 File Offset: 0x00310818
		public void BANHFNDEPPO()
		{
			this.HFDIGALPAHD();
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x00310565 File Offset: 0x0030E765
		private void BEJLHGJKHGA(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x00312621 File Offset: 0x00310821
		private void JBLILDGMDJF(string DBIMJHMKHNK)
		{
			this.Text = DBIMJHMKHNK;
			this.IBPLEDAHDCF.text = this.Text;
			this.FFHMKNHBICF(true);
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x00312644 File Offset: 0x00310844
		private void ACPCDCEJOJG()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.BIPJFGIOFBB()) ? 1683f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.GPACFLMMHKH());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = false;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, false);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(361f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.x);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(base.transform, true);
				this.ICLMGGNADNO.SetParent(this.AAHLPFMBPJP, false);
			}
			if (this.NFNGKIJFBCJ.Count < 0)
			{
				return;
			}
			float num2 = this.IHOLCKOEPAP.sizeDelta.y * (float)Mathf.Min(this._itemsToDisplay, this.NFNGKIJFBCJ.Count);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.ICLMGGNADNO.sizeDelta.x - num - 1648f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(1544f, 723f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1244f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x003128C0 File Offset: 0x00310AC0
		private bool DJOOKCAPEHA()
		{
			bool result = false;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("_Value").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("maps.").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("restrictions\n\n#until: ").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("connecting").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("Error: Can not set the OnSerialize rate higher than the overall SendRate.").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_Glitch").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 612f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)6;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("CameraFilterPack_Glasses_On3").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("/");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.IMOGILPBBMN();
			return result;
		}

		// Token: 0x06008E87 RID: 36487 RVA: 0x0031055D File Offset: 0x0030E75D
		public DropDownListItem KDFGDJDPAEC()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float ALPMLLDAHEO()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x00310565 File Offset: 0x0030E765
		private void NHNGNGDIFAL(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x00312AA4 File Offset: 0x00310CA4
		private void PPDJAFCOCEE()
		{
			float num = (this.NFNGKIJFBCJ.Count <= this.ItemsToDisplay) ? 1211f : this._scrollBarWidth;
			this.NKNMCGNABMC.gameObject.SetActive(this.NFNGKIJFBCJ.Count > this.FCCBJGNBBOM());
			if (!this.MELOHGFLIPB || this.IHOLCKOEPAP.sizeDelta != this.ILGPPBGOCLD.sizeDelta)
			{
				this.MELOHGFLIPB = true;
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
				this.ILGPPBGOCLD.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.y);
				this.ICLMGGNADNO.SetParent(base.transform, true);
				this.ICLMGGNADNO.anchoredPosition = new Vector2(1093f, -this.IHOLCKOEPAP.sizeDelta.y);
				this.AAHLPFMBPJP.SetParent(this.AHPDJAGJGNL.transform, false);
				this.AAHLPFMBPJP.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.DGJKIJJBMOB.sizeDelta.x);
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
			this.ICLMGGNADNO.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.IHOLCKOEPAP.sizeDelta.x);
			this.IGECOMGCEDF.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.ICLMGGNADNO.sizeDelta.x - num - 455f);
			this.IGECOMGCEDF.anchoredPosition = new Vector2(327f, 944f);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
			this.NKNMCGNABMC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 737f);
			this.CNEKHMOIMKC.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num2 - this.NKNMCGNABMC.sizeDelta.x);
		}

		// Token: 0x06008E8D RID: 36493 RVA: 0x00312D20 File Offset: 0x00310F20
		public void FHCMOOAPCIC(bool DPLLMKAPDIM)
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

		// Token: 0x06008E8E RID: 36494 RVA: 0x00312D74 File Offset: 0x00310F74
		private bool HFDIGALPAHD()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("_Val3").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("_FixDistance").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(false);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find(",").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("CameraFilterPack/FX_superDot").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("_Value").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("_Value3").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 1756f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)3;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("Multiplayer").gameObject;
				this.MPANMCLABFG.SetActive(false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("_TimeX");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.OHFIFOEIJMK();
			return result;
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x00312304 File Offset: 0x00310504
		public void OJCEBHKGPCN(float DPNHODJHGJL)
		{
			this._scrollBarWidth = DPNHODJHGJL;
			this.IGOACJDBECD();
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x0031055D File Offset: 0x0030E75D
		public DropDownListItem PPHOHIKPHBP()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x00312A94 File Offset: 0x00310C94
		public void DLGECJJGHBA(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.ELNHKEHJDAA();
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x0031030F File Offset: 0x0030E50F
		public string AFMAFNEGLDP()
		{
			return this.<PIHKMIHEFPA>k__BackingField;
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x00312F48 File Offset: 0x00311148
		public void GLPOJGCJKDG(bool DPLLMKAPDIM)
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

		// Token: 0x06008E94 RID: 36500 RVA: 0x0031055D File Offset: 0x0030E75D
		public DropDownListItem DPDCKONCDJF()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int ALFBEKAJLEH()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E96 RID: 36502 RVA: 0x00312F9C File Offset: 0x0031119C
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

		// Token: 0x06008E97 RID: 36503 RVA: 0x00311AC8 File Offset: 0x0030FCC8
		public void DBBMLACOHCF(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.AOPCIDDINMJ();
		}

		// Token: 0x06008E98 RID: 36504 RVA: 0x00313218 File Offset: 0x00311418
		public void NOBIKEOMLHD(string GFHFLBENAHE)
		{
			this.JJPDGMODLHB(GFHFLBENAHE);
			this.ACPCDCEJOJG();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = true;
				this.BGPAFBBJEKN(false);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.BIICGJJLPLE(false);
			}
		}

		// Token: 0x06008E99 RID: 36505 RVA: 0x00313268 File Offset: 0x00311468
		private void IFILDAHBHAB()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "Set Sun DirectionVector" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num += 0;
			}
			for (int i = 0; i < list.Count; i += 0)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[1];
					array[0] = "CameraFilterPack/TV_VHS_Rewind";
					array[1] = i;
					array[3] = "SetRoomStartTimestamp";
					array[6] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("Unsupported target enum: ").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.JKEDCEOCPJO));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008E9A RID: 36506 RVA: 0x00313494 File Offset: 0x00311694
		private void OHFIFOEIJMK()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "_Value2" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, false);
				list.Add(gameObject);
				num++;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[5];
					array[0] = "entering";
					array[0] = i;
					array[5] = "CameraFilterPack_TV_Arcade1";
					array[0] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("Editor/").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.LOEAMHGMMPK));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008E9B RID: 36507 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int AALPGHOMDPN()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008E9C RID: 36508 RVA: 0x003136C0 File Offset: 0x003118C0
		public void HMPGAECHICA(bool DPLLMKAPDIM)
		{
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

		// Token: 0x06008E9D RID: 36509 RVA: 0x00310565 File Offset: 0x0030E765
		private void MLELEEIHBKL(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008E9E RID: 36510 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float ICJMCKMACNE()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008E9F RID: 36511 RVA: 0x00313714 File Offset: 0x00311914
		private bool OFONCGKJDJE()
		{
			bool result = true;
			try
			{
				this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
				this.ILGPPBGOCLD = this.IHOLCKOEPAP.Find("_SizeX").GetComponent<RectTransform>();
				this.IBPLEDAHDCF = this.ILGPPBGOCLD.GetComponent<InputField>();
				this.AAHLPFMBPJP = this.IHOLCKOEPAP.Find("Joystick1Button9").GetComponent<RectTransform>();
				this.AAHLPFMBPJP.gameObject.SetActive(true);
				this.ICLMGGNADNO = this.AAHLPFMBPJP.Find("ResetSpeed").GetComponent<RectTransform>();
				this.NKNMCGNABMC = this.ICLMGGNADNO.Find("Can't set visible when not in that room.").GetComponent<RectTransform>();
				this.CNEKHMOIMKC = this.NKNMCGNABMC.Find("settings.customdataskin").GetComponent<RectTransform>();
				this.IGECOMGCEDF = this.ICLMGGNADNO.Find("Received your UserID from server. Updating local value to: {0}").GetComponent<RectTransform>();
				this.AHPDJAGJGNL = base.GetComponentInParent<Canvas>();
				this.DGJKIJJBMOB = this.AHPDJAGJGNL.GetComponent<RectTransform>();
				this.CFNFKMGEGHL = this.ICLMGGNADNO.GetComponent<ScrollRect>();
				this.CFNFKMGEGHL.scrollSensitivity = this.IHOLCKOEPAP.sizeDelta.y / 671f;
				this.CFNFKMGEGHL.movementType = (ScrollRect.MovementType)3;
				this.CFNFKMGEGHL.content = this.IGECOMGCEDF;
				this.MPANMCLABFG = this.IHOLCKOEPAP.Find("menu.enableselectormusic").gameObject;
				this.MPANMCLABFG.SetActive(true);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("float,0");
				result = false;
			}
			this.NFNGAOLFLGA = new Dictionary<string, GameObject>();
			this.NFNGKIJFBCJ = this.AvailableOptions.ToList<string>();
			this.INPGCNJFFGP();
			return result;
		}

		// Token: 0x06008EA0 RID: 36512 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float FKCGPMLBHGN()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x00310A68 File Offset: 0x0030EC68
		public void CCDNJPNLGBN()
		{
			this.IHEIAKNNJIE();
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x00310554 File Offset: 0x0030E754
		private void HCEINBNNLIH(string DPNHODJHGJL)
		{
			this.<PIHKMIHEFPA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x003138E8 File Offset: 0x00311AE8
		private void IMOGILPBBMN()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "_Value2" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num++;
			}
			for (int i = 1; i < list.Count; i += 0)
			{
				list[i].SetActive(i <= this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[3];
					array[1] = "settings.crosshairopacity";
					array[0] = i;
					array[1] = "ItemsCountText";
					array[0] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("CameraFilterPack/3D_Myst").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.GBKBDKHPLKG));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x00313B14 File Offset: 0x00311D14
		public void OLFNCABJBHA()
		{
			this.IFJGGEAMFON();
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x00313B20 File Offset: 0x00311D20
		public void OnValueChanged(string GFHFLBENAHE)
		{
			this.Text = GFHFLBENAHE;
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

		// Token: 0x06008EA6 RID: 36518 RVA: 0x003107AF File Offset: 0x0030E9AF
		public int NPKLLKGFIIF()
		{
			return this._itemsToDisplay;
		}

		// Token: 0x06008EA7 RID: 36519 RVA: 0x003125E8 File Offset: 0x003107E8
		public void GMOKFOIOGML(int DPNHODJHGJL)
		{
			this._itemsToDisplay = DPNHODJHGJL;
			this.PPDJAFCOCEE();
		}

		// Token: 0x06008EA8 RID: 36520 RVA: 0x00313B70 File Offset: 0x00311D70
		public void EKEAMBCIPFK(string GFHFLBENAHE)
		{
			this.DAHFJOCGHCJ(GFHFLBENAHE);
			this.IGOACJDBECD();
			if (this.NFNGKIJFBCJ.Count == 0)
			{
				this.BCENJFOJJOL = false;
				this.FHCMOOAPCIC(false);
			}
			else if (!this.BCENJFOJJOL)
			{
				this.BGPAFBBJEKN(false);
			}
		}

		// Token: 0x06008EA9 RID: 36521 RVA: 0x00313BC0 File Offset: 0x00311DC0
		private void EGBOKOPFIPM()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
			List<GameObject> list = new List<GameObject>(this.NFNGAOLFLGA.Values);
			this.NFNGAOLFLGA.Clear();
			int num = 0;
			while (list.Count < this.AvailableOptions.Count)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.MPANMCLABFG);
				gameObject.name = "attempted to spawn go (" + num;
				gameObject.transform.SetParent(this.IGECOMGCEDF, true);
				list.Add(gameObject);
				num += 0;
			}
			for (int i = 1; i < list.Count; i++)
			{
				list[i].SetActive(i > this.AvailableOptions.Count);
				if (i < this.AvailableOptions.Count)
				{
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
					Object @object = list[i];
					object[] array = new object[3];
					array[1] = "InfoButton";
					array[1] = i;
					array[7] = "mapselector.tags.";
					array[2] = this.NFNGKIJFBCJ[i];
					@object.name = string.Concat(array);
					list[i].transform.Find("_Amount").GetComponent<Text>().text = this.NFNGKIJFBCJ[i];
					Button component = list[i].GetComponent<Button>();
					component.onClick.RemoveAllListeners();
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.BDGDIDPDBHG));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x003102EF File Offset: 0x0030E4EF
		public float NGFDOKEEDKB()
		{
			return this._scrollBarWidth;
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x00313DEC File Offset: 0x00311FEC
		public void GEPELODHBFN()
		{
			this.MPDAMDDPPAJ();
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x00313DF8 File Offset: 0x00311FF8
		public void DOOCMGLFBON(bool DPLLMKAPDIM)
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

		// Token: 0x06008EAD RID: 36525 RVA: 0x00313E4C File Offset: 0x0031204C
		private void FGPHLABEKEA()
		{
			this.NFNGKIJFBCJ.Clear();
			foreach (string text in this.AvailableOptions)
			{
				this.NFNGKIJFBCJ.Add(text.ToLower());
			}
			this.NFNGKIJFBCJ.Sort();
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
					ComboBox.FMMGCMIFAPG fmmgcmifapg = new ComboBox.FMMGCMIFAPG();
					fmmgcmifapg.ADPIKBBAKHP = this;
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
					fmmgcmifapg.DNABNBIBCKK = this.NFNGKIJFBCJ[i];
					component.onClick.AddListener(new UnityAction(fmmgcmifapg.GBKBDKHPLKG));
					this.NFNGAOLFLGA[this.NFNGKIJFBCJ[i]] = list[i];
				}
			}
		}

		// Token: 0x06008EAE RID: 36526 RVA: 0x00310565 File Offset: 0x0030E765
		private void FDOCLNKIDOF(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x06008EAF RID: 36527 RVA: 0x0031055D File Offset: 0x0030E75D
		public DropDownListItem LBBLEFBMNHB()
		{
			return this.<AGDMFMAILOG>k__BackingField;
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x00314078 File Offset: 0x00312278
		public void LOMHIIKFFEP()
		{
			this.OFONCGKJDJE();
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x00310565 File Offset: 0x0030E765
		private void JMDACHOAOIJ(DropDownListItem DPNHODJHGJL)
		{
			this.<AGDMFMAILOG>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x04001054 RID: 4180
		public Color disabledTextColor;

		// Token: 0x04001056 RID: 4182
		public List<string> AvailableOptions;

		// Token: 0x04001057 RID: 4183
		public Action<int> OnSelectionChanged;

		// Token: 0x04001058 RID: 4184
		private bool BCENJFOJJOL;

		// Token: 0x04001059 RID: 4185
		private bool MELOHGFLIPB;

		// Token: 0x0400105A RID: 4186
		private InputField IBPLEDAHDCF;

		// Token: 0x0400105B RID: 4187
		private RectTransform ILGPPBGOCLD;

		// Token: 0x0400105C RID: 4188
		private RectTransform IHOLCKOEPAP;

		// Token: 0x0400105D RID: 4189
		private RectTransform AAHLPFMBPJP;

		// Token: 0x0400105E RID: 4190
		private RectTransform ICLMGGNADNO;

		// Token: 0x0400105F RID: 4191
		private RectTransform NKNMCGNABMC;

		// Token: 0x04001060 RID: 4192
		private RectTransform CNEKHMOIMKC;

		// Token: 0x04001061 RID: 4193
		private RectTransform IGECOMGCEDF;

		// Token: 0x04001062 RID: 4194
		private Canvas AHPDJAGJGNL;

		// Token: 0x04001063 RID: 4195
		private RectTransform DGJKIJJBMOB;

		// Token: 0x04001064 RID: 4196
		private ScrollRect CFNFKMGEGHL;

		// Token: 0x04001065 RID: 4197
		private List<string> NFNGKIJFBCJ;

		// Token: 0x04001066 RID: 4198
		private Dictionary<string, GameObject> NFNGAOLFLGA;

		// Token: 0x04001067 RID: 4199
		private GameObject MPANMCLABFG;

		// Token: 0x04001069 RID: 4201
		[SerializeField]
		private float _scrollBarWidth = 20f;

		// Token: 0x0400106A RID: 4202
		[SerializeField]
		private int _itemsToDisplay;

		// Token: 0x0200024E RID: 590
		[CompilerGenerated]
		private sealed class FMMGCMIFAPG
		{
			// Token: 0x06008EB2 RID: 36530 RVA: 0x00314081 File Offset: 0x00312281
			internal void GBKBDKHPLKG()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.DNABNBIBCKK);
			}

			// Token: 0x06008EB3 RID: 36531 RVA: 0x00314094 File Offset: 0x00312294
			internal void LLNDDFGPOPL()
			{
				this.ADPIKBBAKHP.JBLILDGMDJF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EB4 RID: 36532 RVA: 0x003140A7 File Offset: 0x003122A7
			internal void OLIGLEMPFOP()
			{
				this.ADPIKBBAKHP.GDAFHNEFGFB(this.DNABNBIBCKK);
			}

			// Token: 0x06008EB5 RID: 36533 RVA: 0x003140BA File Offset: 0x003122BA
			internal void JKEDCEOCPJO()
			{
				this.ADPIKBBAKHP.PHFMNMPPAMF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EB6 RID: 36534 RVA: 0x003140BA File Offset: 0x003122BA
			internal void MEMPOPNAEDN()
			{
				this.ADPIKBBAKHP.PHFMNMPPAMF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EB8 RID: 36536 RVA: 0x00314094 File Offset: 0x00312294
			internal void DBFPGFHEGKA()
			{
				this.ADPIKBBAKHP.JBLILDGMDJF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EB9 RID: 36537 RVA: 0x003140A7 File Offset: 0x003122A7
			internal void KFNBKFELFLH()
			{
				this.ADPIKBBAKHP.GDAFHNEFGFB(this.DNABNBIBCKK);
			}

			// Token: 0x06008EBA RID: 36538 RVA: 0x003140BA File Offset: 0x003122BA
			internal void PBCAHKDLFPE()
			{
				this.ADPIKBBAKHP.PHFMNMPPAMF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EBB RID: 36539 RVA: 0x00314094 File Offset: 0x00312294
			internal void BDGDIDPDBHG()
			{
				this.ADPIKBBAKHP.JBLILDGMDJF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EBC RID: 36540 RVA: 0x00314094 File Offset: 0x00312294
			internal void AEINPAGJFME()
			{
				this.ADPIKBBAKHP.JBLILDGMDJF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EBD RID: 36541 RVA: 0x003140A7 File Offset: 0x003122A7
			internal void BKNHHGBPLGH()
			{
				this.ADPIKBBAKHP.GDAFHNEFGFB(this.DNABNBIBCKK);
			}

			// Token: 0x06008EBE RID: 36542 RVA: 0x003140BA File Offset: 0x003122BA
			internal void LOEAMHGMMPK()
			{
				this.ADPIKBBAKHP.PHFMNMPPAMF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EBF RID: 36543 RVA: 0x00314094 File Offset: 0x00312294
			internal void BFEABMIFIEE()
			{
				this.ADPIKBBAKHP.JBLILDGMDJF(this.DNABNBIBCKK);
			}

			// Token: 0x06008EC0 RID: 36544 RVA: 0x00314081 File Offset: 0x00312281
			internal void LNDGINDKPFA()
			{
				this.ADPIKBBAKHP.JKBCPINJEAO(this.DNABNBIBCKK);
			}

			// Token: 0x0400106B RID: 4203
			internal string DNABNBIBCKK;

			// Token: 0x0400106C RID: 4204
			internal ComboBox ADPIKBBAKHP;
		}
	}
}
