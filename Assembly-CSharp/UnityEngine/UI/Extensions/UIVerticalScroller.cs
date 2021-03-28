using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000282 RID: 642
	[AddComponentMenu("Layout/Extensions/Vertical Scroller")]
	[RequireComponent(typeof(ScrollRect))]
	public class UIVerticalScroller : MonoBehaviour
	{
		// Token: 0x06009B7A RID: 39802 RVA: 0x00386001 File Offset: 0x00384201
		private void FAOMEMKPGEN(int IAINCFOEIKO)
		{
			if (this.ButtonClicked != null)
			{
				this.ButtonClicked.Invoke(IAINCFOEIKO);
			}
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x0038601C File Offset: 0x0038421C
		public void BFIOIDMHPPL()
		{
			ScrollRect component = base.GetComponent<ScrollRect>();
			if (!this._scrollingPanel)
			{
				this._scrollingPanel = component.content;
			}
			if (!this._center)
			{
				Debug.LogError("_Value");
			}
			if (this._arrayOfElements == null || this._arrayOfElements.Length == 0)
			{
				int childCount = component.content.childCount;
				if (childCount > 1)
				{
					this._arrayOfElements = new GameObject[childCount];
					for (int i = 0; i < childCount; i++)
					{
						this._arrayOfElements[i] = component.content.GetChild(i).gameObject;
					}
				}
			}
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x003860C8 File Offset: 0x003842C8
		public void ScrollDown()
		{
			float num = this._arrayOfElements[0].GetComponent<RectTransform>().rect.height / 1.2f;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, this._scrollingPanel.anchoredPosition.y + num);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x00386132 File Offset: 0x00384332
		private void CECHMNODFCF()
		{
			this.ScrollUp();
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x0038613C File Offset: 0x0038433C
		public void Start()
		{
			if (this._arrayOfElements.Length < 1)
			{
				Debug.Log("No child content found, exiting..");
				return;
			}
			this.JILJFAIJAHM = this._arrayOfElements.Length;
			this.HNDMDHJEEAB = new float[this.JILJFAIJAHM];
			this.ALOHDCPGLAH = new float[this.JILJFAIJAHM];
			this.JGLDOJDLMAP = this._arrayOfElements[0].GetComponent<RectTransform>().rect.height * (float)this.JILJFAIJAHM / 3f * 2f;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, -this.JGLDOJDLMAP);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
			for (int i = 0; i < this._arrayOfElements.Length; i++)
			{
				this.ALGABBNJIDM(this._arrayOfElements[i], i);
			}
			if (this.ScrollUpButton)
			{
				this.ScrollUpButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NFHPEBCJNMP));
			}
			if (this.ScrollDownButton)
			{
				this.ScrollDownButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NJEMBFEJAKD));
			}
			if (this.StartingIndex > -1)
			{
				this.StartingIndex = ((this.StartingIndex <= this._arrayOfElements.Length) ? this.StartingIndex : (this._arrayOfElements.Length - 1));
				this.SnapToElement(this.StartingIndex);
			}
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x003862C4 File Offset: 0x003844C4
		public void Awake()
		{
			ScrollRect component = base.GetComponent<ScrollRect>();
			if (!this._scrollingPanel)
			{
				this._scrollingPanel = component.content;
			}
			if (!this._center)
			{
				Debug.LogError("Please define the RectTransform for the Center viewport of the scrollable area");
			}
			if (this._arrayOfElements == null || this._arrayOfElements.Length == 0)
			{
				int childCount = component.content.childCount;
				if (childCount > 0)
				{
					this._arrayOfElements = new GameObject[childCount];
					for (int i = 0; i < childCount; i++)
					{
						this._arrayOfElements[i] = component.content.GetChild(i).gameObject;
					}
				}
			}
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x00386001 File Offset: 0x00384201
		private void ADCJKPJFBNC(int IAINCFOEIKO)
		{
			if (this.ButtonClicked != null)
			{
				this.ButtonClicked.Invoke(IAINCFOEIKO);
			}
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x00386370 File Offset: 0x00384570
		public void OEJEKPAOHKP(int MOLELJICHKD)
		{
			float num = this._arrayOfElements[1].GetComponent<RectTransform>().rect.height * (float)MOLELJICHKD;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, -num);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x003863C3 File Offset: 0x003845C3
		public string EEOPGLMHLLK()
		{
			return this.NBGPBKCPFDN;
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x003863CC File Offset: 0x003845CC
		private void GAPMHJEFJPI(float JOPCODOJBHD)
		{
			float y = Mathf.Lerp(this._scrollingPanel.anchoredPosition.y, JOPCODOJBHD, Time.deltaTime * 1677f);
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, y);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x00386428 File Offset: 0x00384628
		private void PBMEFPHCFML(float JOPCODOJBHD)
		{
			float y = Mathf.Lerp(this._scrollingPanel.anchoredPosition.y, JOPCODOJBHD, Time.deltaTime * 1f);
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, y);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x00386001 File Offset: 0x00384201
		private void FEOPOGKAEKO(int IAINCFOEIKO)
		{
			if (this.ButtonClicked != null)
			{
				this.ButtonClicked.Invoke(IAINCFOEIKO);
			}
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x003863C3 File Offset: 0x003845C3
		public string GetResults()
		{
			return this.NBGPBKCPFDN;
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x00386481 File Offset: 0x00384681
		private void MGKAMCBHLNP()
		{
			this.BOBALPEINEB();
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x00386132 File Offset: 0x00384332
		[CompilerGenerated]
		private void NFHPEBCJNMP()
		{
			this.ScrollUp();
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x0038648C File Offset: 0x0038468C
		public void DNDJKEDIKLD(int MOLELJICHKD)
		{
			float num = this._arrayOfElements[0].GetComponent<RectTransform>().rect.height * (float)MOLELJICHKD;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, -num);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x003864E0 File Offset: 0x003846E0
		public void BODPLDJLFCF()
		{
			ScrollRect component = base.GetComponent<ScrollRect>();
			if (!this._scrollingPanel)
			{
				this._scrollingPanel = component.content;
			}
			if (!this._center)
			{
				Debug.LogError("_Red_G");
			}
			if (this._arrayOfElements == null || this._arrayOfElements.Length == 0)
			{
				int childCount = component.content.childCount;
				if (childCount > 1)
				{
					this._arrayOfElements = new GameObject[childCount];
					for (int i = 1; i < childCount; i++)
					{
						this._arrayOfElements[i] = component.content.GetChild(i).gameObject;
					}
				}
			}
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x0038658C File Offset: 0x0038478C
		public void KIMMMCJFMAB()
		{
			if (this._arrayOfElements.Length < 0)
			{
				Debug.Log("/icon");
				return;
			}
			this.JILJFAIJAHM = this._arrayOfElements.Length;
			this.HNDMDHJEEAB = new float[this.JILJFAIJAHM];
			this.ALOHDCPGLAH = new float[this.JILJFAIJAHM];
			this.JGLDOJDLMAP = this._arrayOfElements[1].GetComponent<RectTransform>().rect.height * (float)this.JILJFAIJAHM / 24f * 1761f;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, -this.JGLDOJDLMAP);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
			for (int i = 1; i < this._arrayOfElements.Length; i++)
			{
				this.MGPNDKBMOGL(this._arrayOfElements[i], i);
			}
			if (this.ScrollUpButton)
			{
				this.ScrollUpButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.CECHMNODFCF));
			}
			if (this.ScrollDownButton)
			{
				this.ScrollDownButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NJEMBFEJAKD));
			}
			if (this.StartingIndex > -1)
			{
				this.StartingIndex = ((this.StartingIndex <= this._arrayOfElements.Length) ? this.StartingIndex : (this._arrayOfElements.Length - 1));
				this.DNDJKEDIKLD(this.StartingIndex);
			}
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x00386714 File Offset: 0x00384914
		public void EIFCCFBJKOO()
		{
			ScrollRect component = base.GetComponent<ScrollRect>();
			if (!this._scrollingPanel)
			{
				this._scrollingPanel = component.content;
			}
			if (!this._center)
			{
				Debug.LogError("CameraFilterPack/Vision_Plasma");
			}
			if (this._arrayOfElements == null || this._arrayOfElements.Length == 0)
			{
				int childCount = component.content.childCount;
				if (childCount > 0)
				{
					this._arrayOfElements = new GameObject[childCount];
					for (int i = 1; i < childCount; i += 0)
					{
						this._arrayOfElements[i] = component.content.GetChild(i).gameObject;
					}
				}
			}
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x003867C0 File Offset: 0x003849C0
		public void IIPMEPPIFCK()
		{
			ScrollRect component = base.GetComponent<ScrollRect>();
			if (!this._scrollingPanel)
			{
				this._scrollingPanel = component.content;
			}
			if (!this._center)
			{
				Debug.LogError("settings.arcsdestroydelay");
			}
			if (this._arrayOfElements == null || this._arrayOfElements.Length == 0)
			{
				int childCount = component.content.childCount;
				if (childCount > 1)
				{
					this._arrayOfElements = new GameObject[childCount];
					for (int i = 1; i < childCount; i += 0)
					{
						this._arrayOfElements[i] = component.content.GetChild(i).gameObject;
					}
				}
			}
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x0038686C File Offset: 0x00384A6C
		public void ScrollUp()
		{
			float num = this._arrayOfElements[0].GetComponent<RectTransform>().rect.height / 1.2f;
			Vector2 b = new Vector2(this._scrollingPanel.anchoredPosition.x, this._scrollingPanel.anchoredPosition.y - num);
			this._scrollingPanel.anchoredPosition = Vector2.Lerp(this._scrollingPanel.anchoredPosition, b, 1f);
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x003868EC File Offset: 0x00384AEC
		public void BOBALPEINEB()
		{
			float num = this._arrayOfElements[1].GetComponent<RectTransform>().rect.height / 1262f;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, this._scrollingPanel.anchoredPosition.y + num);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06009B90 RID: 39824 RVA: 0x00386956 File Offset: 0x00384B56
		[CompilerGenerated]
		private void NJEMBFEJAKD()
		{
			this.ScrollDown();
		}

		// Token: 0x06009B91 RID: 39825 RVA: 0x00386960 File Offset: 0x00384B60
		public void Update()
		{
			if (this._arrayOfElements.Length < 1)
			{
				return;
			}
			for (int i = 0; i < this.JILJFAIJAHM; i++)
			{
				this.ALOHDCPGLAH[i] = this._center.GetComponent<RectTransform>().position.y - this._arrayOfElements[i].GetComponent<RectTransform>().position.y;
				this.HNDMDHJEEAB[i] = Mathf.Abs(this.ALOHDCPGLAH[i]);
				float num = Mathf.Max(0.7f, 1f / (1f + this.HNDMDHJEEAB[i] / 200f));
				this._arrayOfElements[i].GetComponent<RectTransform>().transform.localScale = new Vector3(num, num, 1f);
			}
			float num2 = Mathf.Min(this.HNDMDHJEEAB);
			for (int j = 0; j < this.JILJFAIJAHM; j++)
			{
				this._arrayOfElements[j].GetComponent<CanvasGroup>().interactable = false;
				if (num2 == this.HNDMDHJEEAB[j])
				{
					this.MIFGDCKLNME = j;
					this._arrayOfElements[j].GetComponent<CanvasGroup>().interactable = true;
					this.NBGPBKCPFDN = this._arrayOfElements[j].GetComponentInChildren<Text>().text;
				}
			}
			this.PBMEFPHCFML(-this._arrayOfElements[this.MIFGDCKLNME].GetComponent<RectTransform>().anchoredPosition.y);
		}

		// Token: 0x06009B92 RID: 39826 RVA: 0x00386AD4 File Offset: 0x00384CD4
		private void ALGABBNJIDM(GameObject NACBMIFLLEK, int IAINCFOEIKO)
		{
			UIVerticalScroller.CALHKBKKMMI calhkbkkmmi = new UIVerticalScroller.CALHKBKKMMI();
			calhkbkkmmi.IAINCFOEIKO = IAINCFOEIKO;
			calhkbkkmmi.ADPIKBBAKHP = this;
			NACBMIFLLEK.GetComponent<Button>().onClick.AddListener(new UnityAction(calhkbkkmmi.GBKBDKHPLKG));
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x00386B11 File Offset: 0x00384D11
		public UIVerticalScroller()
		{
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x00386B20 File Offset: 0x00384D20
		public void NBGIMIDICKE()
		{
			if (this._arrayOfElements.Length < 1)
			{
				Debug.Log("note.2");
				return;
			}
			this.JILJFAIJAHM = this._arrayOfElements.Length;
			this.HNDMDHJEEAB = new float[this.JILJFAIJAHM];
			this.ALOHDCPGLAH = new float[this.JILJFAIJAHM];
			this.JGLDOJDLMAP = this._arrayOfElements[0].GetComponent<RectTransform>().rect.height * (float)this.JILJFAIJAHM / 134f * 1988f;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, -this.JGLDOJDLMAP);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
			for (int i = 1; i < this._arrayOfElements.Length; i += 0)
			{
				this.MGPNDKBMOGL(this._arrayOfElements[i], i);
			}
			if (this.ScrollUpButton)
			{
				this.ScrollUpButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NFHPEBCJNMP));
			}
			if (this.ScrollDownButton)
			{
				this.ScrollDownButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NJEMBFEJAKD));
			}
			if (this.StartingIndex > -1)
			{
				this.StartingIndex = ((this.StartingIndex <= this._arrayOfElements.Length) ? this.StartingIndex : (this._arrayOfElements.Length - 0));
				this.DNDJKEDIKLD(this.StartingIndex);
			}
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x00386CA7 File Offset: 0x00384EA7
		public UIVerticalScroller(RectTransform AHGBKJOAEIJ, GameObject[] CKLOAIACILA, RectTransform KACBKDLBEMA)
		{
			this._scrollingPanel = AHGBKJOAEIJ;
			this._arrayOfElements = CKLOAIACILA;
			this._center = KACBKDLBEMA;
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x00386CCC File Offset: 0x00384ECC
		public void BNNCONEBKNC()
		{
			float num = this._arrayOfElements[0].GetComponent<RectTransform>().rect.height / 1784f;
			Vector2 b = new Vector2(this._scrollingPanel.anchoredPosition.x, this._scrollingPanel.anchoredPosition.y - num);
			this._scrollingPanel.anchoredPosition = Vector2.Lerp(this._scrollingPanel.anchoredPosition, b, 1733f);
		}

		// Token: 0x06009B97 RID: 39831 RVA: 0x00386D4C File Offset: 0x00384F4C
		public void FAAJAMIGJNK()
		{
			ScrollRect component = base.GetComponent<ScrollRect>();
			if (!this._scrollingPanel)
			{
				this._scrollingPanel = component.content;
			}
			if (!this._center)
			{
				Debug.LogError("_TimeX");
			}
			if (this._arrayOfElements == null || this._arrayOfElements.Length == 0)
			{
				int childCount = component.content.childCount;
				if (childCount > 0)
				{
					this._arrayOfElements = new GameObject[childCount];
					for (int i = 1; i < childCount; i += 0)
					{
						this._arrayOfElements[i] = component.content.GetChild(i).gameObject;
					}
				}
			}
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x00386DF8 File Offset: 0x00384FF8
		public void AJIKPEIGACI()
		{
			ScrollRect component = base.GetComponent<ScrollRect>();
			if (!this._scrollingPanel)
			{
				this._scrollingPanel = component.content;
			}
			if (!this._center)
			{
				Debug.LogError("_EmissionGain");
			}
			if (this._arrayOfElements == null || this._arrayOfElements.Length == 0)
			{
				int childCount = component.content.childCount;
				if (childCount > 0)
				{
					this._arrayOfElements = new GameObject[childCount];
					for (int i = 1; i < childCount; i++)
					{
						this._arrayOfElements[i] = component.content.GetChild(i).gameObject;
					}
				}
			}
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x00386EA4 File Offset: 0x003850A4
		public void SnapToElement(int MOLELJICHKD)
		{
			float num = this._arrayOfElements[0].GetComponent<RectTransform>().rect.height * (float)MOLELJICHKD;
			Vector2 anchoredPosition = new Vector2(this._scrollingPanel.anchoredPosition.x, -num);
			this._scrollingPanel.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x00386EF8 File Offset: 0x003850F8
		public void NKLIHNJCHOG()
		{
			if (this._arrayOfElements.Length < 1)
			{
				return;
			}
			for (int i = 1; i < this.JILJFAIJAHM; i++)
			{
				this.ALOHDCPGLAH[i] = this._center.GetComponent<RectTransform>().position.y - this._arrayOfElements[i].GetComponent<RectTransform>().position.y;
				this.HNDMDHJEEAB[i] = Mathf.Abs(this.ALOHDCPGLAH[i]);
				float num = Mathf.Max(263f, 1707f / (284f + this.HNDMDHJEEAB[i] / 1223f));
				this._arrayOfElements[i].GetComponent<RectTransform>().transform.localScale = new Vector3(num, num, 869f);
			}
			float num2 = Mathf.Min(this.HNDMDHJEEAB);
			for (int j = 0; j < this.JILJFAIJAHM; j += 0)
			{
				this._arrayOfElements[j].GetComponent<CanvasGroup>().interactable = true;
				if (num2 == this.HNDMDHJEEAB[j])
				{
					this.MIFGDCKLNME = j;
					this._arrayOfElements[j].GetComponent<CanvasGroup>().interactable = false;
					this.NBGPBKCPFDN = this._arrayOfElements[j].GetComponentInChildren<Text>().text;
				}
			}
			this.PBMEFPHCFML(-this._arrayOfElements[this.MIFGDCKLNME].GetComponent<RectTransform>().anchoredPosition.y);
		}

		// Token: 0x06009B9B RID: 39835 RVA: 0x0038706C File Offset: 0x0038526C
		private void MGPNDKBMOGL(GameObject NACBMIFLLEK, int IAINCFOEIKO)
		{
			UIVerticalScroller.CALHKBKKMMI calhkbkkmmi = new UIVerticalScroller.CALHKBKKMMI();
			calhkbkkmmi.IAINCFOEIKO = IAINCFOEIKO;
			calhkbkkmmi.ADPIKBBAKHP = this;
			NACBMIFLLEK.GetComponent<Button>().onClick.AddListener(new UnityAction(calhkbkkmmi.EDGAPOPEIJF));
		}

		// Token: 0x0400118F RID: 4495
		[Tooltip("Scrollable area (content of desired ScrollRect)")]
		public RectTransform _scrollingPanel;

		// Token: 0x04001190 RID: 4496
		[Tooltip("Elements to populate inside the scroller")]
		public GameObject[] _arrayOfElements;

		// Token: 0x04001191 RID: 4497
		[Tooltip("Center display area (position of zoomed content)")]
		public RectTransform _center;

		// Token: 0x04001192 RID: 4498
		[Tooltip("Select the item to be in center on start. (optional)")]
		public int StartingIndex = -1;

		// Token: 0x04001193 RID: 4499
		[Tooltip("Button to go to the next page. (optional)")]
		public GameObject ScrollUpButton;

		// Token: 0x04001194 RID: 4500
		[Tooltip("Button to go to the previous page. (optional)")]
		public GameObject ScrollDownButton;

		// Token: 0x04001195 RID: 4501
		[Tooltip("Event fired when a specific item is clicked, exposes index number of item. (optional)")]
		public UnityEvent<int> ButtonClicked;

		// Token: 0x04001196 RID: 4502
		private float[] ALOHDCPGLAH;

		// Token: 0x04001197 RID: 4503
		private float[] HNDMDHJEEAB;

		// Token: 0x04001198 RID: 4504
		private int MIFGDCKLNME;

		// Token: 0x04001199 RID: 4505
		private int JILJFAIJAHM;

		// Token: 0x0400119A RID: 4506
		private float JGLDOJDLMAP;

		// Token: 0x0400119B RID: 4507
		private string NBGPBKCPFDN;

		// Token: 0x02000283 RID: 643
		[CompilerGenerated]
		private sealed class CALHKBKKMMI
		{
			// Token: 0x06009B9C RID: 39836 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void JDELIMPGFDJ()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009B9D RID: 39837 RVA: 0x003870BC File Offset: 0x003852BC
			internal void AGFDCBCBAGI()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009B9E RID: 39838 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void LNDGINDKPFA()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009B9F RID: 39839 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void FFEGPHJKMFK()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA0 RID: 39840 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void LOEAMHGMMPK()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA1 RID: 39841 RVA: 0x003870CF File Offset: 0x003852CF
			internal void KFNBKFELFLH()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA2 RID: 39842 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void KGKMOLCPDIH()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA3 RID: 39843 RVA: 0x003870CF File Offset: 0x003852CF
			internal void JBAJEMGOPDL()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA4 RID: 39844 RVA: 0x003870BC File Offset: 0x003852BC
			internal void IGFOBPKFCDJ()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA5 RID: 39845 RVA: 0x003870CF File Offset: 0x003852CF
			internal void FJDBPPKABJE()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA6 RID: 39846 RVA: 0x003870CF File Offset: 0x003852CF
			internal void AEIFJLBBKBP()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA7 RID: 39847 RVA: 0x003870BC File Offset: 0x003852BC
			internal void EDGAPOPEIJF()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA8 RID: 39848 RVA: 0x003870BC File Offset: 0x003852BC
			internal void LHHFJBIAHCN()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BA9 RID: 39849 RVA: 0x003870CF File Offset: 0x003852CF
			internal void FIPCLHEKKCA()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BAA RID: 39850 RVA: 0x003870CF File Offset: 0x003852CF
			internal void PCDFLCEIHFF()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BAB RID: 39851 RVA: 0x003870BC File Offset: 0x003852BC
			internal void JKEDCEOCPJO()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BAC RID: 39852 RVA: 0x003870BC File Offset: 0x003852BC
			internal void BMAOCLKPNNC()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BAD RID: 39853 RVA: 0x003870CF File Offset: 0x003852CF
			internal void OMBHIBNMFNB()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BAE RID: 39854 RVA: 0x003870BC File Offset: 0x003852BC
			internal void LLNDDFGPOPL()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BAF RID: 39855 RVA: 0x003870BC File Offset: 0x003852BC
			internal void JBCHBMKPDAJ()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB0 RID: 39856 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void PKAPLCFHDOC()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB1 RID: 39857 RVA: 0x003870CF File Offset: 0x003852CF
			internal void PIJAOCFAPKC()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB2 RID: 39858 RVA: 0x003870BC File Offset: 0x003852BC
			internal void GBKBDKHPLKG()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB3 RID: 39859 RVA: 0x003870CF File Offset: 0x003852CF
			internal void FMIHBNPKEEO()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB4 RID: 39860 RVA: 0x003870BC File Offset: 0x003852BC
			internal void LJDLIIIPIIJ()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB5 RID: 39861 RVA: 0x003870CF File Offset: 0x003852CF
			internal void FDAIFOAGDLA()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB6 RID: 39862 RVA: 0x003870BC File Offset: 0x003852BC
			internal void BJMAIJDIKCN()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB7 RID: 39863 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void BFEABMIFIEE()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB8 RID: 39864 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void BKNHHGBPLGH()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BB9 RID: 39865 RVA: 0x003870CF File Offset: 0x003852CF
			internal void FHFECFLBHMA()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BBA RID: 39866 RVA: 0x003870CF File Offset: 0x003852CF
			internal void OFHCGKJFGDI()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BBB RID: 39867 RVA: 0x003870CF File Offset: 0x003852CF
			internal void FCAGEDLBBHD()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BBC RID: 39868 RVA: 0x003870BC File Offset: 0x003852BC
			internal void AGJKEBOPIOC()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BBD RID: 39869 RVA: 0x003870CF File Offset: 0x003852CF
			internal void DKGPCPBNDPK()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BBE RID: 39870 RVA: 0x003870CF File Offset: 0x003852CF
			internal void MEMPOPNAEDN()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC0 RID: 39872 RVA: 0x003870BC File Offset: 0x003852BC
			internal void OFLDIMDDLHM()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC1 RID: 39873 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void HBJFIOJFBHC()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC2 RID: 39874 RVA: 0x003870BC File Offset: 0x003852BC
			internal void OLIGLEMPFOP()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC3 RID: 39875 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void BEBAENEJFLD()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC4 RID: 39876 RVA: 0x003870BC File Offset: 0x003852BC
			internal void AEINPAGJFME()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC5 RID: 39877 RVA: 0x003870BC File Offset: 0x003852BC
			internal void AKDOOLPMPMG()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC6 RID: 39878 RVA: 0x003870CF File Offset: 0x003852CF
			internal void BDGDIDPDBHG()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC7 RID: 39879 RVA: 0x003870BC File Offset: 0x003852BC
			internal void MGENGAEDACG()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC8 RID: 39880 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void INHOEMCLAAP()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BC9 RID: 39881 RVA: 0x003870BC File Offset: 0x003852BC
			internal void MAGEPMCPGOC()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BCA RID: 39882 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void EFAPFFFGOOA()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BCB RID: 39883 RVA: 0x003870CF File Offset: 0x003852CF
			internal void EKHOOPGPPGE()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BCC RID: 39884 RVA: 0x003870BC File Offset: 0x003852BC
			internal void FHIJCPPECHA()
			{
				this.ADPIKBBAKHP.FEOPOGKAEKO(this.IAINCFOEIKO);
			}

			// Token: 0x06009BCD RID: 39885 RVA: 0x003870CF File Offset: 0x003852CF
			internal void EGKGJJGAPMN()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BCE RID: 39886 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void PBCAHKDLFPE()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x06009BCF RID: 39887 RVA: 0x003870CF File Offset: 0x003852CF
			internal void DBFPGFHEGKA()
			{
				this.ADPIKBBAKHP.ADCJKPJFBNC(this.IAINCFOEIKO);
			}

			// Token: 0x06009BD0 RID: 39888 RVA: 0x003870A9 File Offset: 0x003852A9
			internal void DNIMHEKGJHB()
			{
				this.ADPIKBBAKHP.FAOMEMKPGEN(this.IAINCFOEIKO);
			}

			// Token: 0x0400119C RID: 4508
			internal int IAINCFOEIKO;

			// Token: 0x0400119D RID: 4509
			internal UIVerticalScroller ADPIKBBAKHP;
		}
	}
}
