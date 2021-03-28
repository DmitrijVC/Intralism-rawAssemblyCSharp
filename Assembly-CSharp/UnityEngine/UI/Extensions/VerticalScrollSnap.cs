using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000285 RID: 645
	[RequireComponent(typeof(ScrollRect))]
	[AddComponentMenu("Layout/Extensions/Vertical Scroll Snap")]
	public class VerticalScrollSnap : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x06009C1E RID: 39966 RVA: 0x003899BD File Offset: 0x00387BBD
		private void DLHBKLKPPOC()
		{
			this.HNNEMGHMGKF();
		}

		// Token: 0x06009C1F RID: 39967 RVA: 0x003899C8 File Offset: 0x00387BC8
		public void OnEndDrag(PointerEventData OLIIPKODDIN)
		{
			this.HPCHGDFNLPG = true;
			if (this.HIINEFDLMKF.vertical)
			{
				if (this.UseFastSwipe)
				{
					this.KHCFKMFPMMB = false;
					this.EKEONCKHEOM = false;
					if (this.PMKOCDOOGCL <= this.IOKJIFHGEBK && Math.Abs(this.KGIGAOIOKBL.y - this.HLIBMLFDIKI.localPosition.y) > (float)this.FastSwipeThreshold)
					{
						this.KHCFKMFPMMB = true;
					}
					if (this.KHCFKMFPMMB)
					{
						if (this.KGIGAOIOKBL.y - this.HLIBMLFDIKI.localPosition.y > 0f)
						{
							this.LNFEPAEIBNM();
						}
						else
						{
							this.ACGPAMFAKLL();
						}
					}
					else
					{
						this.OGMDJJEEMII = true;
						this.HCGLCFEMANH = this.CENFDGDLJKH(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
						this._currentScreen = this.EAALIOANOBN(this.HCGLCFEMANH);
					}
				}
				else
				{
					this.OGMDJJEEMII = true;
					this.HCGLCFEMANH = this.CENFDGDLJKH(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
					this._currentScreen = this.EAALIOANOBN(this.HCGLCFEMANH);
				}
			}
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x00389B08 File Offset: 0x00387D08
		private void CECHMNODFCF()
		{
			this.NextScreen();
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x00389B10 File Offset: 0x00387D10
		private Vector3 CAFBLHCHHNK(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = 1077f;
			foreach (Vector3 vector in this.KKBICDHBICA)
			{
				if (Vector3.Distance(DKJCKNPNPAB, vector) < num)
				{
					num = Vector3.Distance(DKJCKNPNPAB, vector);
					result = vector;
				}
			}
			return result;
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x00389B8C File Offset: 0x00387D8C
		public void GoToScreen(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 0)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x00389BC4 File Offset: 0x00387DC4
		public void HNNEMGHMGKF()
		{
			if (this._currentScreen > 0)
			{
				this._currentScreen--;
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x00389C18 File Offset: 0x00387E18
		public void DistributePages()
		{
			float num = 0f;
			Vector2 sizeDelta = base.gameObject.GetComponent<RectTransform>().sizeDelta;
			float num2 = 0f;
			for (int i = 0; i < this.HLIBMLFDIKI.transform.childCount; i++)
			{
				RectTransform component = this.HLIBMLFDIKI.transform.GetChild(i).gameObject.GetComponent<RectTransform>();
				num2 = num + (float)(i * this.PageStep);
				component.sizeDelta = new Vector2(sizeDelta.x, sizeDelta.y);
				component.anchoredPosition = new Vector2(0f - sizeDelta.x / 2f, num2 + sizeDelta.y / 2f);
			}
			float y = num2 + num * -1f;
			this.HLIBMLFDIKI.GetComponent<RectTransform>().offsetMax = new Vector2(0f, y);
			this.JIGNDMALKBJ = this.HLIBMLFDIKI.childCount;
			this.KKBICDHBICA = new List<Vector3>();
			if (this.JIGNDMALKBJ > 0)
			{
				for (int j = 0; j < this.JIGNDMALKBJ; j++)
				{
					this.HIINEFDLMKF.verticalNormalizedPosition = (float)j / (float)(this.JIGNDMALKBJ - 1);
					this.KKBICDHBICA.Add(this.HLIBMLFDIKI.localPosition);
				}
			}
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x00389D76 File Offset: 0x00387F76
		public void IOBOKEJCLBF(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 1)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.GAMIBLLFPJK(DPDMBAKIEEC);
			}
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x00389DAC File Offset: 0x00387FAC
		private void KMFGIAALGFC()
		{
			int childCount = base.gameObject.GetComponent<ScrollRect>().content.childCount;
			if (this.StartingScreen > childCount)
			{
				this.StartingScreen = childCount;
			}
			if (this.StartingScreen < 0)
			{
				this.StartingScreen = 0;
			}
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x00389DF8 File Offset: 0x00387FF8
		public int CurrentScreen()
		{
			Vector3 hmdkplldbea = this.CENFDGDLJKH(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
			return this._currentScreen = this.EAALIOANOBN(hmdkplldbea);
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x00389E8C File Offset: 0x0038808C
		private int EAALIOANOBN(Vector3 HMDKPLLDBEA)
		{
			for (int i = 0; i < this.KKBICDHBICA.Count; i++)
			{
				if (this.KKBICDHBICA[i] == HMDKPLLDBEA)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x00389ED0 File Offset: 0x003880D0
		public void PreviousScreen()
		{
			if (this._currentScreen > 0)
			{
				this._currentScreen--;
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x06009C2B RID: 39979 RVA: 0x00389F24 File Offset: 0x00388124
		public int HHKMNBBGDNN()
		{
			Vector3 hmdkplldbea = this.CAFBLHCHHNK(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
			return this._currentScreen = this.KJINCIJEPJG(hmdkplldbea);
		}

		// Token: 0x06009C2C RID: 39980 RVA: 0x00389F5C File Offset: 0x0038815C
		public void HJDADMOPHPE(PointerEventData OLIIPKODDIN)
		{
			this.HPCHGDFNLPG = false;
			if (this.HIINEFDLMKF.vertical)
			{
				if (this.UseFastSwipe)
				{
					this.KHCFKMFPMMB = true;
					this.EKEONCKHEOM = true;
					if (this.PMKOCDOOGCL <= this.IOKJIFHGEBK && Math.Abs(this.KGIGAOIOKBL.y - this.HLIBMLFDIKI.localPosition.y) > (float)this.FastSwipeThreshold)
					{
						this.KHCFKMFPMMB = true;
					}
					if (this.KHCFKMFPMMB)
					{
						if (this.KGIGAOIOKBL.y - this.HLIBMLFDIKI.localPosition.y > 845f)
						{
							this.AFHAGIHJGIG();
						}
						else
						{
							this.ACGPAMFAKLL();
						}
					}
					else
					{
						this.OGMDJJEEMII = true;
						this.HCGLCFEMANH = this.CAFBLHCHHNK(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
						this._currentScreen = this.POBOIMIEPFP(this.HCGLCFEMANH);
					}
				}
				else
				{
					this.OGMDJJEEMII = false;
					this.HCGLCFEMANH = this.CAFBLHCHHNK(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
					this._currentScreen = this.EAALIOANOBN(this.HCGLCFEMANH);
				}
			}
		}

		// Token: 0x06009C2D RID: 39981 RVA: 0x0038A09C File Offset: 0x0038829C
		public void DECCIECAKEL(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 1)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x06009C2E RID: 39982 RVA: 0x0038A0D4 File Offset: 0x003882D4
		private int POBOIMIEPFP(Vector3 HMDKPLLDBEA)
		{
			for (int i = 1; i < this.KKBICDHBICA.Count; i++)
			{
				if (this.KKBICDHBICA[i] == HMDKPLLDBEA)
				{
					return i;
				}
			}
			return 1;
		}

		// Token: 0x06009C2F RID: 39983 RVA: 0x0038A117 File Offset: 0x00388317
		public void OnBeginDrag(PointerEventData OLIIPKODDIN)
		{
			this.KGIGAOIOKBL = this.HLIBMLFDIKI.localPosition;
			this.PMKOCDOOGCL = 0;
			this.EKEONCKHEOM = true;
			this._currentScreen = this.CurrentScreen();
		}

		// Token: 0x06009C30 RID: 39984 RVA: 0x0038A144 File Offset: 0x00388344
		public void BLHOJKFJAKL()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 0)
			{
				this._currentScreen++;
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x06009C31 RID: 39985 RVA: 0x0038A19C File Offset: 0x0038839C
		private int EFNECHBIPHK(Vector3 HMDKPLLDBEA)
		{
			for (int i = 0; i < this.KKBICDHBICA.Count; i++)
			{
				if (this.KKBICDHBICA[i] == HMDKPLLDBEA)
				{
					return i;
				}
			}
			return 1;
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x0038A1E0 File Offset: 0x003883E0
		private void OnValidate()
		{
			int childCount = base.gameObject.GetComponent<ScrollRect>().content.childCount;
			if (this.StartingScreen > childCount)
			{
				this.StartingScreen = childCount;
			}
			if (this.StartingScreen < 1)
			{
				this.StartingScreen = 1;
			}
		}

		// Token: 0x06009C33 RID: 39987 RVA: 0x0038A22C File Offset: 0x0038842C
		private void LEAHIBJDMBI()
		{
			if (this.OGMDJJEEMII)
			{
				this.HLIBMLFDIKI.localPosition = Vector3.Lerp(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH, this.transitionSpeed * Time.deltaTime);
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 1768f)
				{
					this.OGMDJJEEMII = false;
				}
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 689f)
				{
					this.GAMIBLLFPJK(this.HHKMNBBGDNN());
				}
			}
			if (this.EKEONCKHEOM)
			{
				this.PMKOCDOOGCL++;
			}
		}

		// Token: 0x06009C34 RID: 39988 RVA: 0x0038A2E0 File Offset: 0x003884E0
		private void Start()
		{
			this.HIINEFDLMKF = base.gameObject.GetComponent<ScrollRect>();
			if (this.HIINEFDLMKF.horizontalScrollbar || this.HIINEFDLMKF.verticalScrollbar)
			{
				Debug.LogWarning("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results");
			}
			this.HLIBMLFDIKI = this.HIINEFDLMKF.content;
			if (this.PageStep == 0)
			{
				this.PageStep = (int)this.HIINEFDLMKF.GetComponent<RectTransform>().rect.height * 3;
			}
			this.DistributePages();
			this.OGMDJJEEMII = false;
			this._currentScreen = this.StartingScreen;
			this.HIINEFDLMKF.verticalNormalizedPosition = (float)(this._currentScreen - 1) / (float)(this.JIGNDMALKBJ - 1);
			this.HPCOIDMPALF(this._currentScreen);
			if (this.NextButton)
			{
				this.NextButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NFHPEBCJNMP));
			}
			if (this.PrevButton)
			{
				this.PrevButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NJEMBFEJAKD));
			}
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x0038A414 File Offset: 0x00388614
		private void LNFEPAEIBNM()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 1)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen + 1];
				this.HPCOIDMPALF(this._currentScreen + 1);
			}
		}

		// Token: 0x06009C36 RID: 39990 RVA: 0x0038A464 File Offset: 0x00388664
		private void AFHAGIHJGIG()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 0)
			{
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen + 1];
				this.GAMIBLLFPJK(this._currentScreen + 0);
			}
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x0038A4B4 File Offset: 0x003886B4
		private void HPCOIDMPALF(int MMNEFFLEEFC)
		{
			if (this.Pagination)
			{
				for (int i = 0; i < this.Pagination.transform.childCount; i++)
				{
					this.Pagination.transform.GetChild(i).GetComponent<Toggle>().isOn = (MMNEFFLEEFC == i);
				}
			}
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x0038A51B File Offset: 0x0038871B
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			this.OGMDJJEEMII = false;
			if (this.HPCHGDFNLPG)
			{
				this.OnBeginDrag(OLIIPKODDIN);
				this.HPCHGDFNLPG = false;
			}
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0038A53D File Offset: 0x0038873D
		private void HHAIIMFHKOK()
		{
			this.PreviousScreen();
		}

		// Token: 0x06009C3A RID: 39994 RVA: 0x0038A548 File Offset: 0x00388748
		private void BMHFAMJELFH()
		{
			int childCount = base.gameObject.GetComponent<ScrollRect>().content.childCount;
			if (this.StartingScreen > childCount)
			{
				this.StartingScreen = childCount;
			}
			if (this.StartingScreen < 0)
			{
				this.StartingScreen = 1;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06009C3B RID: 39995 RVA: 0x0038A591 File Offset: 0x00388791
		public int CurrentPage
		{
			get
			{
				return this._currentScreen;
			}
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x0038A53D File Offset: 0x0038873D
		[CompilerGenerated]
		private void NJEMBFEJAKD()
		{
			this.PreviousScreen();
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x0038A59C File Offset: 0x0038879C
		public void AddChild(GameObject FBFBKNIJIEK)
		{
			this.HIINEFDLMKF.verticalNormalizedPosition = 0f;
			FBFBKNIJIEK.transform.SetParent(this.HLIBMLFDIKI);
			this.DistributePages();
			this.HIINEFDLMKF.verticalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x0038A5EC File Offset: 0x003887EC
		public void NextScreen()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 1)
			{
				this._currentScreen++;
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x0038A53D File Offset: 0x0038873D
		private void APMNJHEDBDM()
		{
			this.PreviousScreen();
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x0038A644 File Offset: 0x00388844
		public void CGKJMMOHJOK(GameObject FBFBKNIJIEK)
		{
			this.HIINEFDLMKF.verticalNormalizedPosition = 1136f;
			FBFBKNIJIEK.transform.SetParent(this.HLIBMLFDIKI);
			this.DistributePages();
			this.HIINEFDLMKF.verticalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x0038A694 File Offset: 0x00388894
		private void KHDANGFKIGL()
		{
			int childCount = base.gameObject.GetComponent<ScrollRect>().content.childCount;
			if (this.StartingScreen > childCount)
			{
				this.StartingScreen = childCount;
			}
			if (this.StartingScreen < 1)
			{
				this.StartingScreen = 1;
			}
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x0038A6E0 File Offset: 0x003888E0
		private int KJINCIJEPJG(Vector3 HMDKPLLDBEA)
		{
			for (int i = 1; i < this.KKBICDHBICA.Count; i++)
			{
				if (this.KKBICDHBICA[i] == HMDKPLLDBEA)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x0038A724 File Offset: 0x00388924
		private void GAMIBLLFPJK(int MMNEFFLEEFC)
		{
			if (this.Pagination)
			{
				for (int i = 1; i < this.Pagination.transform.childCount; i++)
				{
					this.Pagination.transform.GetChild(i).GetComponent<Toggle>().isOn = (MMNEFFLEEFC == i);
				}
			}
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x00389D76 File Offset: 0x00387F76
		public void BFILDPDOAKI(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 1)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.GAMIBLLFPJK(DPDMBAKIEEC);
			}
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x0038A53D File Offset: 0x0038873D
		private void DHCMKAGPDBP()
		{
			this.PreviousScreen();
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x0038A78C File Offset: 0x0038898C
		public void RemoveChild(int IAINCFOEIKO, out GameObject BMPLKDEBJAO)
		{
			BMPLKDEBJAO = null;
			if (IAINCFOEIKO < 0 || IAINCFOEIKO > this.HLIBMLFDIKI.childCount)
			{
				return;
			}
			this.HIINEFDLMKF.verticalNormalizedPosition = 0f;
			Transform transform = this.HLIBMLFDIKI.transform;
			int num = 0;
			IEnumerator enumerator = transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform2 = (Transform)obj;
					if (num == IAINCFOEIKO)
					{
						transform2.SetParent(null);
						BMPLKDEBJAO = transform2.gameObject;
						break;
					}
					num++;
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			this.DistributePages();
			if (this._currentScreen > this.JIGNDMALKBJ - 1)
			{
				this._currentScreen = this.JIGNDMALKBJ - 1;
			}
			this.HIINEFDLMKF.verticalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x0038A884 File Offset: 0x00388A84
		public void LKLJDFLMKDE(int IAINCFOEIKO, out GameObject BMPLKDEBJAO)
		{
			BMPLKDEBJAO = null;
			if (IAINCFOEIKO < 1 || IAINCFOEIKO > this.HLIBMLFDIKI.childCount)
			{
				return;
			}
			this.HIINEFDLMKF.verticalNormalizedPosition = 631f;
			Transform transform = this.HLIBMLFDIKI.transform;
			int num = 1;
			IEnumerator enumerator = transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform2 = (Transform)obj;
					if (num == IAINCFOEIKO)
					{
						transform2.SetParent(null);
						BMPLKDEBJAO = transform2.gameObject;
						break;
					}
					num += 0;
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
			this.DistributePages();
			if (this._currentScreen > this.JIGNDMALKBJ - 0)
			{
				this._currentScreen = this.JIGNDMALKBJ - 0;
			}
			this.HIINEFDLMKF.verticalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x0038A97C File Offset: 0x00388B7C
		private void Update()
		{
			if (this.OGMDJJEEMII)
			{
				this.HLIBMLFDIKI.localPosition = Vector3.Lerp(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH, this.transitionSpeed * Time.deltaTime);
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 0.005f)
				{
					this.OGMDJJEEMII = false;
				}
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 10f)
				{
					this.HPCOIDMPALF(this.CurrentScreen());
				}
			}
			if (this.EKEONCKHEOM)
			{
				this.PMKOCDOOGCL++;
			}
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x0038AA2D File Offset: 0x00388C2D
		private void ACGPAMFAKLL()
		{
			if (this._currentScreen > 0)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen - 1];
				this.HPCOIDMPALF(this._currentScreen - 1);
			}
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x0038AA6C File Offset: 0x00388C6C
		public void NBMAAPHIMAL()
		{
			if (this._currentScreen > 1)
			{
				this._currentScreen -= 0;
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x0038AAC0 File Offset: 0x00388CC0
		private Vector3 CENFDGDLJKH(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = float.PositiveInfinity;
			foreach (Vector3 vector in this.KKBICDHBICA)
			{
				if (Vector3.Distance(DKJCKNPNPAB, vector) < num)
				{
					num = Vector3.Distance(DKJCKNPNPAB, vector);
					result = vector;
				}
			}
			return result;
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x00389B08 File Offset: 0x00387D08
		[CompilerGenerated]
		private void NFHPEBCJNMP()
		{
			this.NextScreen();
		}

		// Token: 0x040011B4 RID: 4532
		private Transform HLIBMLFDIKI;

		// Token: 0x040011B5 RID: 4533
		private int JIGNDMALKBJ = 1;

		// Token: 0x040011B6 RID: 4534
		private bool EKEONCKHEOM;

		// Token: 0x040011B7 RID: 4535
		private int PMKOCDOOGCL;

		// Token: 0x040011B8 RID: 4536
		private int IOKJIFHGEBK = 30;

		// Token: 0x040011B9 RID: 4537
		private List<Vector3> KKBICDHBICA;

		// Token: 0x040011BA RID: 4538
		private ScrollRect HIINEFDLMKF;

		// Token: 0x040011BB RID: 4539
		private Vector3 HCGLCFEMANH;

		// Token: 0x040011BC RID: 4540
		private bool OGMDJJEEMII;

		// Token: 0x040011BD RID: 4541
		[Tooltip("The gameobject that contains toggles which suggest pagination. (optional)")]
		public GameObject Pagination;

		// Token: 0x040011BE RID: 4542
		[Tooltip("Button to go to the next page. (optional)")]
		public GameObject NextButton;

		// Token: 0x040011BF RID: 4543
		[Tooltip("Button to go to the previous page. (optional)")]
		public GameObject PrevButton;

		// Token: 0x040011C0 RID: 4544
		[Tooltip("Transition speed between pages. (optional)")]
		public float transitionSpeed = 7.5f;

		// Token: 0x040011C1 RID: 4545
		public bool UseFastSwipe = true;

		// Token: 0x040011C2 RID: 4546
		public int FastSwipeThreshold = 100;

		// Token: 0x040011C3 RID: 4547
		private bool HPCHGDFNLPG = true;

		// Token: 0x040011C4 RID: 4548
		private Vector3 KGIGAOIOKBL = default(Vector3);

		// Token: 0x040011C5 RID: 4549
		[SerializeField]
		[Tooltip("The currently active page")]
		private int _currentScreen;

		// Token: 0x040011C6 RID: 4550
		[Tooltip("The screen / page to start the control on")]
		public int StartingScreen = 1;

		// Token: 0x040011C7 RID: 4551
		[Tooltip("The distance between two pages, by default 3 times the width of the control")]
		public int PageStep;

		// Token: 0x040011C8 RID: 4552
		private bool KHCFKMFPMMB;
	}
}
