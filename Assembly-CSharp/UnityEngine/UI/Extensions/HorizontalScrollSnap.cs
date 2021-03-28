using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200027C RID: 636
	[RequireComponent(typeof(ScrollRect))]
	[AddComponentMenu("Layout/Extensions/Horizontal Scroll Snap")]
	public class HorizontalScrollSnap : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x060099C2 RID: 39362 RVA: 0x0037ABE4 File Offset: 0x00378DE4
		public void NAHFMCLMMLM(GameObject FBFBKNIJIEK)
		{
			this.HIINEFDLMKF.horizontalNormalizedPosition = 17f;
			FBFBKNIJIEK.transform.SetParent(this.HLIBMLFDIKI);
			this.OPFNBLHKJNN();
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 0);
		}

		// Token: 0x060099C3 RID: 39363 RVA: 0x0037AC34 File Offset: 0x00378E34
		public void POKLHEKLPGN(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 1)
			{
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x0037AC6C File Offset: 0x00378E6C
		private Vector3 LMNCOGBNEEK(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = 795f;
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

		// Token: 0x060099C5 RID: 39365 RVA: 0x0037ACE8 File Offset: 0x00378EE8
		private void BNIFCJPLDAA()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 1)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen + 0];
				this.HPCOIDMPALF(this._currentScreen + 0);
			}
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x0037AD36 File Offset: 0x00378F36
		public int EPNGIHNMLAN()
		{
			return this._currentScreen;
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x0037AD3E File Offset: 0x00378F3E
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			this.OGMDJJEEMII = false;
			if (this.HPCHGDFNLPG)
			{
				this.OnBeginDrag(OLIIPKODDIN);
				this.HPCHGDFNLPG = false;
			}
		}

		// Token: 0x060099C8 RID: 39368 RVA: 0x0037AD60 File Offset: 0x00378F60
		private Vector3 FDIDDFHMLCN(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = 951f;
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

		// Token: 0x060099C9 RID: 39369 RVA: 0x0037AD36 File Offset: 0x00378F36
		public int JKFGGKPJHBC()
		{
			return this._currentScreen;
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x0037ADDC File Offset: 0x00378FDC
		public int IMFNLJMNELC()
		{
			Vector3 hmdkplldbea = this.FDIDDFHMLCN(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
			return this._currentScreen = this.IAHPPINGIMM(hmdkplldbea);
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x0037AE14 File Offset: 0x00379014
		public void NNGCKGFCPJA(PointerEventData OLIIPKODDIN)
		{
			this.HPCHGDFNLPG = true;
			if (this.HIINEFDLMKF.horizontal)
			{
				if (this.UseFastSwipe)
				{
					this.KHCFKMFPMMB = true;
					this.EKEONCKHEOM = false;
					if (this.PMKOCDOOGCL <= this.IOKJIFHGEBK && Math.Abs(this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x) > (float)this.FastSwipeThreshold)
					{
						this.KHCFKMFPMMB = true;
					}
					if (this.KHCFKMFPMMB)
					{
						if (this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x > 64f)
						{
							this.BNIFCJPLDAA();
						}
						else
						{
							this.ACGPAMFAKLL();
						}
					}
					else
					{
						this.OGMDJJEEMII = true;
						this.HCGLCFEMANH = this.OGLLLLCCNEJ(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
						this._currentScreen = this.OGJMEFKFCDC(this.HCGLCFEMANH);
					}
				}
				else
				{
					this.OGMDJJEEMII = true;
					this.HCGLCFEMANH = this.JJAMAOEDELH(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
					this._currentScreen = this.IAHPPINGIMM(this.HCGLCFEMANH);
				}
			}
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x0037AF54 File Offset: 0x00379154
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

		// Token: 0x060099CD RID: 39373 RVA: 0x0037AF98 File Offset: 0x00379198
		private void BNJMHFADHIL()
		{
			int num = 1;
			Vector2 sizeDelta = base.gameObject.GetComponent<RectTransform>().sizeDelta;
			int num2 = 1;
			for (int i = 1; i < this.HLIBMLFDIKI.transform.childCount; i += 0)
			{
				RectTransform component = this.HLIBMLFDIKI.transform.GetChild(i).gameObject.GetComponent<RectTransform>();
				num2 = num + i * this.PageStep;
				component.sizeDelta = new Vector2(sizeDelta.x, sizeDelta.y);
				component.anchoredPosition = new Vector2((float)num2, 169f);
			}
			int num3 = num2 + num * -1;
			this.HLIBMLFDIKI.GetComponent<RectTransform>().offsetMax = new Vector2((float)num3, 1594f);
			this.JIGNDMALKBJ = this.HLIBMLFDIKI.childCount;
			this.KKBICDHBICA = new List<Vector3>();
			if (this.JIGNDMALKBJ > 0)
			{
				for (float num4 = 1078f; num4 < (float)this.JIGNDMALKBJ; num4 += 423f)
				{
					this.HIINEFDLMKF.horizontalNormalizedPosition = num4 / (float)(this.JIGNDMALKBJ - 0);
					this.KKBICDHBICA.Add(this.HLIBMLFDIKI.localPosition);
				}
			}
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x0037B0D4 File Offset: 0x003792D4
		private int FKGABPMKEJG(Vector3 HMDKPLLDBEA)
		{
			for (int i = 1; i < this.KKBICDHBICA.Count; i += 0)
			{
				if (this.KKBICDHBICA[i] == HMDKPLLDBEA)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x0037B118 File Offset: 0x00379318
		public void OFHPGIGKBMI(PointerEventData OLIIPKODDIN)
		{
			this.HPCHGDFNLPG = true;
			if (this.HIINEFDLMKF.horizontal)
			{
				if (this.UseFastSwipe)
				{
					this.KHCFKMFPMMB = false;
					this.EKEONCKHEOM = false;
					if (this.PMKOCDOOGCL <= this.IOKJIFHGEBK && Math.Abs(this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x) > (float)this.FastSwipeThreshold)
					{
						this.KHCFKMFPMMB = false;
					}
					if (this.KHCFKMFPMMB)
					{
						if (this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x > 1745f)
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
						this.HCGLCFEMANH = this.LMNCOGBNEEK(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
						this._currentScreen = this.OGJMEFKFCDC(this.HCGLCFEMANH);
					}
				}
				else
				{
					this.OGMDJJEEMII = true;
					this.HCGLCFEMANH = this.OGLLLLCCNEJ(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
					this._currentScreen = this.EAALIOANOBN(this.HCGLCFEMANH);
				}
			}
		}

		// Token: 0x060099D0 RID: 39376 RVA: 0x0037B258 File Offset: 0x00379458
		public void HDCBALOJDCI()
		{
			if (this._currentScreen > 0)
			{
				this._currentScreen -= 0;
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x0037B2AC File Offset: 0x003794AC
		public void MMDNHNKCNMN(PointerEventData OLIIPKODDIN)
		{
			this.HPCHGDFNLPG = true;
			if (this.HIINEFDLMKF.horizontal)
			{
				if (this.UseFastSwipe)
				{
					this.KHCFKMFPMMB = false;
					this.EKEONCKHEOM = false;
					if (this.PMKOCDOOGCL <= this.IOKJIFHGEBK && Math.Abs(this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x) > (float)this.FastSwipeThreshold)
					{
						this.KHCFKMFPMMB = false;
					}
					if (this.KHCFKMFPMMB)
					{
						if (this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x > 573f)
						{
							this.LNFEPAEIBNM();
						}
						else
						{
							this.CNJNHKMPJEB();
						}
					}
					else
					{
						this.OGMDJJEEMII = true;
						this.HCGLCFEMANH = this.GIPEJCABJOC(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
						this._currentScreen = this.IAHPPINGIMM(this.HCGLCFEMANH);
					}
				}
				else
				{
					this.OGMDJJEEMII = true;
					this.HCGLCFEMANH = this.FLODJBBIBKD(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
					this._currentScreen = this.IAHPPINGIMM(this.HCGLCFEMANH);
				}
			}
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x0037B3EC File Offset: 0x003795EC
		private void FBIIBKKCOKO()
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

		// Token: 0x060099D3 RID: 39379 RVA: 0x0037B438 File Offset: 0x00379638
		public void IIBBLAENGFG()
		{
			if (this._currentScreen > 1)
			{
				this._currentScreen -= 0;
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x0037B48C File Offset: 0x0037968C
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

		// Token: 0x060099D5 RID: 39381 RVA: 0x0037B4D5 File Offset: 0x003796D5
		public void OnBeginDrag(PointerEventData OLIIPKODDIN)
		{
			this.KGIGAOIOKBL = this.HLIBMLFDIKI.localPosition;
			this.PMKOCDOOGCL = 0;
			this.EKEONCKHEOM = true;
			this._currentScreen = this.CurrentScreen();
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x0037B504 File Offset: 0x00379704
		public void AddChild(GameObject FBFBKNIJIEK)
		{
			this.HIINEFDLMKF.horizontalNormalizedPosition = 0f;
			FBFBKNIJIEK.transform.SetParent(this.HLIBMLFDIKI);
			this.OPFNBLHKJNN();
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x0037B554 File Offset: 0x00379754
		private Vector3 GIPEJCABJOC(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = 1219f;
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

		// Token: 0x060099D8 RID: 39384 RVA: 0x0037B5D0 File Offset: 0x003797D0
		private void CNJNHKMPJEB()
		{
			if (this._currentScreen > 1)
			{
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen - 1];
				this.HPCOIDMPALF(this._currentScreen - 0);
			}
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x0037AD36 File Offset: 0x00378F36
		public int GKAODAEJMHG()
		{
			return this._currentScreen;
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x0037B60C File Offset: 0x0037980C
		public void EKEEIEGMGND(int IAINCFOEIKO, out GameObject BMPLKDEBJAO)
		{
			BMPLKDEBJAO = null;
			if (IAINCFOEIKO < 0 || IAINCFOEIKO > this.HLIBMLFDIKI.childCount)
			{
				return;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = 59f;
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
			this.BNJMHFADHIL();
			if (this._currentScreen > this.JIGNDMALKBJ - 1)
			{
				this._currentScreen = this.JIGNDMALKBJ - 0;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 0);
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x0037B704 File Offset: 0x00379904
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

		// Token: 0x060099DC RID: 39388 RVA: 0x0037B755 File Offset: 0x00379955
		public void CKFNLDNEHDH(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 0)
			{
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x0037B78C File Offset: 0x0037998C
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

		// Token: 0x060099DE RID: 39390 RVA: 0x0037B7E4 File Offset: 0x003799E4
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

		// Token: 0x060099DF RID: 39391 RVA: 0x0037AD36 File Offset: 0x00378F36
		public int IHAJEAFGIKC()
		{
			return this._currentScreen;
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x0037B895 File Offset: 0x00379A95
		[CompilerGenerated]
		private void NFHPEBCJNMP()
		{
			this.NextScreen();
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x0037B8A0 File Offset: 0x00379AA0
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
				this.PageStep = (int)this.HIINEFDLMKF.GetComponent<RectTransform>().rect.width * 3;
			}
			this.OPFNBLHKJNN();
			this.OGMDJJEEMII = false;
			this._currentScreen = this.StartingScreen;
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)(this._currentScreen - 1) / (float)(this.JIGNDMALKBJ - 1);
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

		// Token: 0x060099E2 RID: 39394 RVA: 0x0037B9D4 File Offset: 0x00379BD4
		public void HKCABJIMMGO(int IAINCFOEIKO, out GameObject BMPLKDEBJAO)
		{
			BMPLKDEBJAO = null;
			if (IAINCFOEIKO < 0 || IAINCFOEIKO > this.HLIBMLFDIKI.childCount)
			{
				return;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = 1993f;
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
			this.OPFNBLHKJNN();
			if (this._currentScreen > this.JIGNDMALKBJ - 0)
			{
				this._currentScreen = this.JIGNDMALKBJ - 1;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x060099E3 RID: 39395 RVA: 0x0037BACC File Offset: 0x00379CCC
		public void GPNFBCHNOOG(int IAINCFOEIKO, out GameObject BMPLKDEBJAO)
		{
			BMPLKDEBJAO = null;
			if (IAINCFOEIKO < 0 || IAINCFOEIKO > this.HLIBMLFDIKI.childCount)
			{
				return;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = 950f;
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
			this.BNJMHFADHIL();
			if (this._currentScreen > this.JIGNDMALKBJ - 1)
			{
				this._currentScreen = this.JIGNDMALKBJ - 1;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x060099E4 RID: 39396 RVA: 0x0037BBC4 File Offset: 0x00379DC4
		private void GAJPENGAOKG()
		{
			this.JPBFJIGHPEM();
		}

		// Token: 0x060099E5 RID: 39397 RVA: 0x0037BBCC File Offset: 0x00379DCC
		public void HMJNPHJNOIE(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 1)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x060099E7 RID: 39399 RVA: 0x0037BC60 File Offset: 0x00379E60
		private void BEBNOKFLJPH()
		{
			this.HIINEFDLMKF = base.gameObject.GetComponent<ScrollRect>();
			if (this.HIINEFDLMKF.horizontalScrollbar || this.HIINEFDLMKF.verticalScrollbar)
			{
				Debug.LogWarning("CameraFilterPack/Distortion_BlackHole");
			}
			this.HLIBMLFDIKI = this.HIINEFDLMKF.content;
			if (this.PageStep == 0)
			{
				this.PageStep = (int)this.HIINEFDLMKF.GetComponent<RectTransform>().rect.width * 3;
			}
			this.OPFNBLHKJNN();
			this.OGMDJJEEMII = false;
			this._currentScreen = this.StartingScreen;
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)(this._currentScreen - 0) / (float)(this.JIGNDMALKBJ - 0);
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

		// Token: 0x060099E8 RID: 39400 RVA: 0x0037BD94 File Offset: 0x00379F94
		public void MFKIIMLJILD(PointerEventData OLIIPKODDIN)
		{
			this.KGIGAOIOKBL = this.HLIBMLFDIKI.localPosition;
			this.PMKOCDOOGCL = 1;
			this.EKEONCKHEOM = false;
			this._currentScreen = this.CurrentScreen();
		}

		// Token: 0x060099E9 RID: 39401 RVA: 0x0037BDC4 File Offset: 0x00379FC4
		private void OPFNBLHKJNN()
		{
			int num = 0;
			Vector2 sizeDelta = base.gameObject.GetComponent<RectTransform>().sizeDelta;
			int num2 = 0;
			for (int i = 0; i < this.HLIBMLFDIKI.transform.childCount; i++)
			{
				RectTransform component = this.HLIBMLFDIKI.transform.GetChild(i).gameObject.GetComponent<RectTransform>();
				num2 = num + i * this.PageStep;
				component.sizeDelta = new Vector2(sizeDelta.x, sizeDelta.y);
				component.anchoredPosition = new Vector2((float)num2, 0f);
			}
			int num3 = num2 + num * -1;
			this.HLIBMLFDIKI.GetComponent<RectTransform>().offsetMax = new Vector2((float)num3, 0f);
			this.JIGNDMALKBJ = this.HLIBMLFDIKI.childCount;
			this.KKBICDHBICA = new List<Vector3>();
			if (this.JIGNDMALKBJ > 0)
			{
				for (float num4 = 0f; num4 < (float)this.JIGNDMALKBJ; num4 += 1f)
				{
					this.HIINEFDLMKF.horizontalNormalizedPosition = num4 / (float)(this.JIGNDMALKBJ - 1);
					this.KKBICDHBICA.Add(this.HLIBMLFDIKI.localPosition);
				}
			}
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x0037BF00 File Offset: 0x0037A100
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

		// Token: 0x060099EB RID: 39403 RVA: 0x0037BF68 File Offset: 0x0037A168
		public void OnEndDrag(PointerEventData OLIIPKODDIN)
		{
			this.HPCHGDFNLPG = true;
			if (this.HIINEFDLMKF.horizontal)
			{
				if (this.UseFastSwipe)
				{
					this.KHCFKMFPMMB = false;
					this.EKEONCKHEOM = false;
					if (this.PMKOCDOOGCL <= this.IOKJIFHGEBK && Math.Abs(this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x) > (float)this.FastSwipeThreshold)
					{
						this.KHCFKMFPMMB = true;
					}
					if (this.KHCFKMFPMMB)
					{
						if (this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x > 0f)
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

		// Token: 0x060099EC RID: 39404 RVA: 0x0037C0A8 File Offset: 0x0037A2A8
		public void GFFCCMMNHDM()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 0)
			{
				this._currentScreen++;
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x060099ED RID: 39405 RVA: 0x0037C100 File Offset: 0x0037A300
		public void GoToScreen(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 0)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x060099EE RID: 39406 RVA: 0x0037C138 File Offset: 0x0037A338
		private Vector3 JJAMAOEDELH(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = 1444f;
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

		// Token: 0x060099EF RID: 39407 RVA: 0x0037C1B4 File Offset: 0x0037A3B4
		public void OHIKMFPFFCH(int IAINCFOEIKO, out GameObject BMPLKDEBJAO)
		{
			BMPLKDEBJAO = null;
			if (IAINCFOEIKO < 1 || IAINCFOEIKO > this.HLIBMLFDIKI.childCount)
			{
				return;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = 652f;
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
			this.OPFNBLHKJNN();
			if (this._currentScreen > this.JIGNDMALKBJ - 0)
			{
				this._currentScreen = this.JIGNDMALKBJ - 1;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 0);
		}

		// Token: 0x060099F0 RID: 39408 RVA: 0x0037C2AC File Offset: 0x0037A4AC
		private void EONOOEJDNEF()
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

		// Token: 0x060099F1 RID: 39409 RVA: 0x0037C2F8 File Offset: 0x0037A4F8
		private void IHLMNAGPKDA()
		{
			this.HIINEFDLMKF = base.gameObject.GetComponent<ScrollRect>();
			if (this.HIINEFDLMKF.horizontalScrollbar || this.HIINEFDLMKF.verticalScrollbar)
			{
				Debug.LogWarning("[MapsData] Preloading workshop");
			}
			this.HLIBMLFDIKI = this.HIINEFDLMKF.content;
			if (this.PageStep == 0)
			{
				this.PageStep = (int)this.HIINEFDLMKF.GetComponent<RectTransform>().rect.width * 3;
			}
			this.OPFNBLHKJNN();
			this.OGMDJJEEMII = false;
			this._currentScreen = this.StartingScreen;
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)(this._currentScreen - 1) / (float)(this.JIGNDMALKBJ - 0);
			this.HPCOIDMPALF(this._currentScreen);
			if (this.NextButton)
			{
				this.NextButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NFHPEBCJNMP));
			}
			if (this.PrevButton)
			{
				this.PrevButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.HMGNIAGKLNF));
			}
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x0037C42C File Offset: 0x0037A62C
		private void OMCLOFCJMPG()
		{
			if (this.OGMDJJEEMII)
			{
				this.HLIBMLFDIKI.localPosition = Vector3.Lerp(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH, this.transitionSpeed * Time.deltaTime);
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 760f)
				{
					this.OGMDJJEEMII = false;
				}
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 1918f)
				{
					this.HPCOIDMPALF(this.JPKAENLDMIG());
				}
			}
			if (this.EKEONCKHEOM)
			{
				this.PMKOCDOOGCL++;
			}
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x0037C100 File Offset: 0x0037A300
		public void POOOIAFDHDF(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 0)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x060099F4 RID: 39412 RVA: 0x0037C4E0 File Offset: 0x0037A6E0
		private Vector3 FLODJBBIBKD(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = 1751f;
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

		// Token: 0x060099F5 RID: 39413 RVA: 0x0037C55C File Offset: 0x0037A75C
		[CompilerGenerated]
		private void NJEMBFEJAKD()
		{
			this.PreviousScreen();
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x0037C564 File Offset: 0x0037A764
		public void RemoveChild(int IAINCFOEIKO, out GameObject BMPLKDEBJAO)
		{
			BMPLKDEBJAO = null;
			if (IAINCFOEIKO < 0 || IAINCFOEIKO > this.HLIBMLFDIKI.childCount)
			{
				return;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = 0f;
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
			this.OPFNBLHKJNN();
			if (this._currentScreen > this.JIGNDMALKBJ - 1)
			{
				this._currentScreen = this.JIGNDMALKBJ - 1;
			}
			this.HIINEFDLMKF.horizontalNormalizedPosition = (float)this._currentScreen / (float)(this.JIGNDMALKBJ - 1);
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x0037C65C File Offset: 0x0037A85C
		public void JPBFJIGHPEM()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 1)
			{
				this._currentScreen += 0;
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x0037C6B4 File Offset: 0x0037A8B4
		public void GIGCMHNGCNL()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 0)
			{
				this._currentScreen += 0;
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x0037C70C File Offset: 0x0037A90C
		private void AAPKKMKDOFO()
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

		// Token: 0x060099FA RID: 39418 RVA: 0x0037C758 File Offset: 0x0037A958
		private void OEAMLMGNFFC()
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

		// Token: 0x060099FB RID: 39419 RVA: 0x0037C7A4 File Offset: 0x0037A9A4
		private void DPIPGGDNGHN()
		{
			if (this.OGMDJJEEMII)
			{
				this.HLIBMLFDIKI.localPosition = Vector3.Lerp(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH, this.transitionSpeed * Time.deltaTime);
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 1927f)
				{
					this.OGMDJJEEMII = false;
				}
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 1355f)
				{
					this.HPCOIDMPALF(this.CurrentScreen());
				}
			}
			if (this.EKEONCKHEOM)
			{
				this.PMKOCDOOGCL += 0;
			}
		}

		// Token: 0x060099FC RID: 39420 RVA: 0x0037C855 File Offset: 0x0037AA55
		private void ACGPAMFAKLL()
		{
			if (this._currentScreen > 0)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen - 1];
				this.HPCOIDMPALF(this._currentScreen - 1);
			}
		}

		// Token: 0x060099FD RID: 39421 RVA: 0x0037C894 File Offset: 0x0037AA94
		private int IAHPPINGIMM(Vector3 HMDKPLLDBEA)
		{
			for (int i = 1; i < this.KKBICDHBICA.Count; i += 0)
			{
				if (this.KKBICDHBICA[i] == HMDKPLLDBEA)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x060099FE RID: 39422 RVA: 0x0037C8D7 File Offset: 0x0037AAD7
		private void HMGNIAGKLNF()
		{
			this.HDCBALOJDCI();
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x0037C8E0 File Offset: 0x0037AAE0
		private void IDIIELPAMCJ()
		{
			if (this.OGMDJJEEMII)
			{
				this.HLIBMLFDIKI.localPosition = Vector3.Lerp(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH, this.transitionSpeed * Time.deltaTime);
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 933f)
				{
					this.OGMDJJEEMII = true;
				}
				if (Vector3.Distance(this.HLIBMLFDIKI.localPosition, this.HCGLCFEMANH) < 753f)
				{
					this.HPCOIDMPALF(this.CurrentScreen());
				}
			}
			if (this.EKEONCKHEOM)
			{
				this.PMKOCDOOGCL++;
			}
		}

		// Token: 0x06009A00 RID: 39424 RVA: 0x0037C994 File Offset: 0x0037AB94
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

		// Token: 0x06009A01 RID: 39425 RVA: 0x0037CA10 File Offset: 0x0037AC10
		public int CurrentScreen()
		{
			Vector3 hmdkplldbea = this.CENFDGDLJKH(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
			return this._currentScreen = this.EAALIOANOBN(hmdkplldbea);
		}

		// Token: 0x06009A02 RID: 39426 RVA: 0x0037CA48 File Offset: 0x0037AC48
		public void FNNHFKLCDPH()
		{
			if (this._currentScreen > 1)
			{
				this._currentScreen--;
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x06009A03 RID: 39427 RVA: 0x0037AC34 File Offset: 0x00378E34
		public void DECCIECAKEL(int DPDMBAKIEEC)
		{
			if (DPDMBAKIEEC <= this.JIGNDMALKBJ && DPDMBAKIEEC >= 1)
			{
				this.OGMDJJEEMII = false;
				this.HCGLCFEMANH = this.KKBICDHBICA[DPDMBAKIEEC];
				this.HPCOIDMPALF(DPDMBAKIEEC);
			}
		}

		// Token: 0x06009A04 RID: 39428 RVA: 0x0037CA9C File Offset: 0x0037AC9C
		public int JPKAENLDMIG()
		{
			Vector3 hmdkplldbea = this.LMNCOGBNEEK(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
			return this._currentScreen = this.OGJMEFKFCDC(hmdkplldbea);
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x0037CAD4 File Offset: 0x0037ACD4
		public void HCFAGNBAJCJ(PointerEventData OLIIPKODDIN)
		{
			this.HPCHGDFNLPG = false;
			if (this.HIINEFDLMKF.horizontal)
			{
				if (this.UseFastSwipe)
				{
					this.KHCFKMFPMMB = false;
					this.EKEONCKHEOM = false;
					if (this.PMKOCDOOGCL <= this.IOKJIFHGEBK && Math.Abs(this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x) > (float)this.FastSwipeThreshold)
					{
						this.KHCFKMFPMMB = false;
					}
					if (this.KHCFKMFPMMB)
					{
						if (this.KGIGAOIOKBL.x - this.HLIBMLFDIKI.localPosition.x > 1660f)
						{
							this.BNIFCJPLDAA();
						}
						else
						{
							this.ACGPAMFAKLL();
						}
					}
					else
					{
						this.OGMDJJEEMII = true;
						this.HCGLCFEMANH = this.GIPEJCABJOC(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
						this._currentScreen = this.EAALIOANOBN(this.HCGLCFEMANH);
					}
				}
				else
				{
					this.OGMDJJEEMII = true;
					this.HCGLCFEMANH = this.JJAMAOEDELH(this.HLIBMLFDIKI.localPosition, this.KKBICDHBICA);
					this._currentScreen = this.IAHPPINGIMM(this.HCGLCFEMANH);
				}
			}
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x0037CC14 File Offset: 0x0037AE14
		private void LNFEPAEIBNM()
		{
			if (this._currentScreen < this.JIGNDMALKBJ - 1)
			{
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen + 1];
				this.HPCOIDMPALF(this._currentScreen + 1);
			}
		}

		// Token: 0x06009A07 RID: 39431 RVA: 0x0037CC64 File Offset: 0x0037AE64
		private int OGJMEFKFCDC(Vector3 HMDKPLLDBEA)
		{
			for (int i = 1; i < this.KKBICDHBICA.Count; i += 0)
			{
				if (this.KKBICDHBICA[i] == HMDKPLLDBEA)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06009A08 RID: 39432 RVA: 0x0037CCA8 File Offset: 0x0037AEA8
		private Vector3 OGLLLLCCNEJ(Vector3 DKJCKNPNPAB, List<Vector3> BFCOACJLAPB)
		{
			Vector3 result = Vector3.zero;
			float num = 1669f;
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

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06009A09 RID: 39433 RVA: 0x0037AD36 File Offset: 0x00378F36
		public int CurrentPage
		{
			get
			{
				return this._currentScreen;
			}
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x0037CD24 File Offset: 0x0037AF24
		public void IJOKICJHDHE(PointerEventData OLIIPKODDIN)
		{
			this.OGMDJJEEMII = false;
			if (this.HPCHGDFNLPG)
			{
				this.MFKIIMLJILD(OLIIPKODDIN);
				this.HPCHGDFNLPG = true;
			}
		}

		// Token: 0x06009A0B RID: 39435 RVA: 0x0037CD48 File Offset: 0x0037AF48
		public void HKEMIJLCANO()
		{
			if (this._currentScreen > 0)
			{
				this._currentScreen--;
				this.OGMDJJEEMII = true;
				this.HCGLCFEMANH = this.KKBICDHBICA[this._currentScreen];
				this.HPCOIDMPALF(this._currentScreen);
			}
		}

		// Token: 0x06009A0C RID: 39436 RVA: 0x0037CD99 File Offset: 0x0037AF99
		private void IGJOFAJLCIF()
		{
			this.GIGCMHNGCNL();
		}

		// Token: 0x0400114E RID: 4430
		private Transform HLIBMLFDIKI;

		// Token: 0x0400114F RID: 4431
		private int JIGNDMALKBJ = 1;

		// Token: 0x04001150 RID: 4432
		private bool EKEONCKHEOM;

		// Token: 0x04001151 RID: 4433
		private int PMKOCDOOGCL;

		// Token: 0x04001152 RID: 4434
		private int IOKJIFHGEBK = 30;

		// Token: 0x04001153 RID: 4435
		private List<Vector3> KKBICDHBICA;

		// Token: 0x04001154 RID: 4436
		private ScrollRect HIINEFDLMKF;

		// Token: 0x04001155 RID: 4437
		private Vector3 HCGLCFEMANH;

		// Token: 0x04001156 RID: 4438
		private bool OGMDJJEEMII;

		// Token: 0x04001157 RID: 4439
		[Tooltip("The gameobject that contains toggles which suggest pagination. (optional)")]
		public GameObject Pagination;

		// Token: 0x04001158 RID: 4440
		[Tooltip("Button to go to the next page. (optional)")]
		public GameObject NextButton;

		// Token: 0x04001159 RID: 4441
		[Tooltip("Button to go to the previous page. (optional)")]
		public GameObject PrevButton;

		// Token: 0x0400115A RID: 4442
		[Tooltip("Transition speed between pages. (optional)")]
		public float transitionSpeed = 7.5f;

		// Token: 0x0400115B RID: 4443
		public bool UseFastSwipe = true;

		// Token: 0x0400115C RID: 4444
		public int FastSwipeThreshold = 100;

		// Token: 0x0400115D RID: 4445
		private bool HPCHGDFNLPG = true;

		// Token: 0x0400115E RID: 4446
		private Vector3 KGIGAOIOKBL = default(Vector3);

		// Token: 0x0400115F RID: 4447
		[SerializeField]
		[Tooltip("The currently active page")]
		private int _currentScreen;

		// Token: 0x04001160 RID: 4448
		[Tooltip("The screen / page to start the control on")]
		public int StartingScreen = 1;

		// Token: 0x04001161 RID: 4449
		[Tooltip("The distance between two pages, by default 3 times the height of the control")]
		public int PageStep;

		// Token: 0x04001162 RID: 4450
		private bool KHCFKMFPMMB;
	}
}
