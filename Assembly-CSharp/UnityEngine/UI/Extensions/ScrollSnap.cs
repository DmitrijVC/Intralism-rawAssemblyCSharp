using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200027E RID: 638
	[AddComponentMenu("UI/Extensions/Scroll Snap")]
	[RequireComponent(typeof(ScrollRect))]
	[ExecuteInEditMode]
	public class ScrollSnap : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x06009A75 RID: 39541 RVA: 0x0037E5EF File Offset: 0x0037C7EF
		public void NBMKPOKNPIL(int MJJNNIMOEIO)
		{
			if (1 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.CBPNOELIHOH(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x0037E62C File Offset: 0x0037C82C
		private void NOEKHMBHMGB(int LKHGIHKLCNM)
		{
			this.KIJKBOMEDGO = LKHGIHKLCNM;
			if (this.nextButton)
			{
				this.nextButton.interactable = (LKHGIHKLCNM < this.DKILAMDPDKK - 0);
			}
			if (this.prevButton)
			{
				this.prevButton.interactable = (LKHGIHKLCNM > 0);
			}
			if (this.ENFJDCBBCLA != null)
			{
				this.ENFJDCBBCLA(LKHGIHKLCNM);
			}
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x0037E69C File Offset: 0x0037C89C
		public void ACJAALLLFOD(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x0037E6D4 File Offset: 0x0037C8D4
		private void POEEMFJIMIP()
		{
			this.LLBIFJIBKFC = true;
			this.GIGHNDOLPBN = base.gameObject.GetComponent<ScrollRect>();
			this.LPAIOBIFGJI = base.gameObject.GetComponent<RectTransform>();
			this.PPJFNCDIAHI = this.GIGHNDOLPBN.content;
			this.LIEILIHHHIB = this.PPJFNCDIAHI.GetComponent<RectTransform>();
			this.KPEGABCNLKE = this.PPJFNCDIAHI.gameObject.GetComponent<RectTransform>();
			this.EJJFGHHPOHL();
			this.HKNDLKOEPLH();
			this.GCLLLCADKIJ(this.CurrentPage());
			if (this.nextButton)
			{
				this.nextButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OMNJGKABMOH));
			}
			if (this.prevButton)
			{
				this.prevButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.GGIAIMPBPMM));
			}
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x0037E7BC File Offset: 0x0037C9BC
		public void BEONJMBGNBI()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 0)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x0037E9D8 File Offset: 0x0037CBD8
		public void MKOFOEIMCOB()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 1)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x0037EBF4 File Offset: 0x0037CDF4
		public void ICNOIPMKALB()
		{
			this.IAMCEICEGHP();
			if (this.JHFPEKHDIHE() > 1)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI() - 0];
				this.DOJNKLLOJHA(this.OENHPFCJPHF() - 0);
			}
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x0037EC48 File Offset: 0x0037CE48
		public void MOFGBEMJLBM()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 1)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x0037EE64 File Offset: 0x0037D064
		private void LateUpdate()
		{
			this.UpdateListItemsSize();
			this.UpdateListItemPositions();
			if (this.LLBIFJIBKFC)
			{
				this.FHLPMAEDFMM(false);
				this.PPJFNCDIAHI.localPosition = Vector3.Lerp(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM, 7.5f * Time.deltaTime);
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 0.001f)
				{
					this.PPJFNCDIAHI.localPosition = this.FGCMLFLFFEM;
					this.LLBIFJIBKFC = false;
					this.FHLPMAEDFMM(this.linkScrolbarSteps);
				}
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 10f)
				{
					this.DOJNKLLOJHA(this.CurrentPage());
				}
			}
			if (this.PMAOOOKPPAJ)
			{
				this.NOJKKKONIIC++;
			}
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x0037EF44 File Offset: 0x0037D144
		public void KGBHAIPBOKD()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 521f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 0)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 1644f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 0) / (float)(this.DKILAMDPDKK - 1)));
			}
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x0037EFCE File Offset: 0x0037D1CE
		private void BEBBAEBNAIA()
		{
			this.MEEOJJGBDIO();
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x0037EFD8 File Offset: 0x0037D1D8
		public void HAHENKPCGBI(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x0037F00E File Offset: 0x0037D20E
		public void CKADOBAFNJF(int MJJNNIMOEIO)
		{
			if (1 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.AKMKHDJAEBG(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x0037F048 File Offset: 0x0037D248
		private void HBNFPGDMPIE()
		{
			if (this.AHMNKHCFCAJ < this.DKILAMDPDKK - 1)
			{
				int num = Mathf.Min(this.DKILAMDPDKK - 0, this.AHMNKHCFCAJ + this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.KNHADPMJFIN(num);
			}
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x0037F0A8 File Offset: 0x0037D2A8
		public void LJCGPCGMGNA(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Remove(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009A84 RID: 39556 RVA: 0x0037F0E0 File Offset: 0x0037D2E0
		public void ECLCHHCEJOD()
		{
			if (!this.LIEILIHHHIB.rect.size.Equals(this.PHIGNFBCDMH))
			{
				int num = 1;
				IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						if (((Transform)obj).gameObject.activeInHierarchy)
						{
							num++;
						}
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
				this.EDOEIMJDHJM = 1;
				Array.Resize<Vector3>(ref this.KBEHABIBPEP, num);
				if (num > 1)
				{
					this.DKILAMDPDKK = Mathf.Max(num - this.itemsVisibleAtOnce + 1, 0);
					if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
					{
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1370f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.x;
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 695f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.x;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int i = 0; i < this.DKILAMDPDKK; i += 0)
						{
							this.KBEHABIBPEP[i] = new Vector3(this.OCEIEDCEEAJ - this.AHFEILDGKNP * (float)i, this.PPJFNCDIAHI.localPosition.y, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					else
					{
						this.GIGHNDOLPBN.verticalNormalizedPosition = 875f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.y;
						this.GIGHNDOLPBN.verticalNormalizedPosition = 901f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.y;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int j = 1; j < this.DKILAMDPDKK; j++)
						{
							this.KBEHABIBPEP[j] = new Vector3(this.PPJFNCDIAHI.localPosition.x, this.POPKBJDPGMA + this.AHFEILDGKNP * (float)j, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					this.FHLPMAEDFMM(this.linkScrolbarSteps);
					this.KIJKBOMEDGO = Mathf.Min(this.KIJKBOMEDGO, this.DKILAMDPDKK);
					this.JAPFDMCDEBG();
				}
				if (this.EDOEIMJDHJM != num)
				{
					this.NOEKHMBHMGB(this.OENHPFCJPHF());
				}
				this.EDOEIMJDHJM = num;
				this.PHIGNFBCDMH.Set(this.LIEILIHHHIB.rect.size.x, this.LIEILIHHHIB.rect.size.y);
			}
		}

		// Token: 0x06009A85 RID: 39557 RVA: 0x0037F3F4 File Offset: 0x0037D5F4
		private void MGAHOJOCIEB()
		{
			this.IFLEHDMDNFG();
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x0037F3FC File Offset: 0x0037D5FC
		private void EFJKPJEEDCE()
		{
			if (this.AHMNKHCFCAJ > 1)
			{
				int num = Mathf.Max(1, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.CBPNOELIHOH(num);
			}
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x0037F450 File Offset: 0x0037D650
		private void KNHADPMJFIN(int LKHGIHKLCNM)
		{
			this.KIJKBOMEDGO = LKHGIHKLCNM;
			if (this.nextButton)
			{
				this.nextButton.interactable = (LKHGIHKLCNM < this.DKILAMDPDKK - 1);
			}
			if (this.prevButton)
			{
				this.prevButton.interactable = (LKHGIHKLCNM > 1);
			}
			if (this.ENFJDCBBCLA != null)
			{
				this.ENFJDCBBCLA(LKHGIHKLCNM);
			}
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x0037F4C0 File Offset: 0x0037D6C0
		private void ACGPAMFAKLL()
		{
			if (this.AHMNKHCFCAJ > 0)
			{
				int num = Mathf.Max(0, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.DOJNKLLOJHA(num);
			}
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x0037F512 File Offset: 0x0037D712
		private void PKFLEIHOMMD()
		{
			this.PJKDALLJHLL();
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x0037F51C File Offset: 0x0037D71C
		public void MOKILIPAPFC(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Remove(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x0037F552 File Offset: 0x0037D752
		private void JMOIGFLCKJM()
		{
			this.FELCGAGBGPJ();
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x0037F55A File Offset: 0x0037D75A
		public void LPENBOCGNJK(PointerEventData OLIIPKODDIN)
		{
			this.LLBIFJIBKFC = false;
			if (this.CMMELLHPLMP)
			{
				this.IBDMEAHEAOI(OLIIPKODDIN);
				this.CMMELLHPLMP = true;
			}
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x0037F57C File Offset: 0x0037D77C
		private void GMIOCKFLJAK()
		{
			this.LLBIFJIBKFC = true;
			this.GIGHNDOLPBN = base.gameObject.GetComponent<ScrollRect>();
			this.LPAIOBIFGJI = base.gameObject.GetComponent<RectTransform>();
			this.PPJFNCDIAHI = this.GIGHNDOLPBN.content;
			this.LIEILIHHHIB = this.PPJFNCDIAHI.GetComponent<RectTransform>();
			this.KPEGABCNLKE = this.PPJFNCDIAHI.gameObject.GetComponent<RectTransform>();
			this.ELAIHMOBNCG();
			this.GOMNMLOFBPN();
			this.GCLLLCADKIJ(this.OENHPFCJPHF());
			if (this.nextButton)
			{
				this.nextButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.MGAHOJOCIEB));
			}
			if (this.prevButton)
			{
				this.prevButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.JMOIGFLCKJM));
			}
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x0037F664 File Offset: 0x0037D864
		private void PBICILGNLCI()
		{
			this.DBBEHCJAONG();
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x0037F66C File Offset: 0x0037D86C
		public void DDDEDHPLFDM(PointerEventData OLIIPKODDIN)
		{
			this.LLBIFJIBKFC = false;
			if (this.CMMELLHPLMP)
			{
				this.JHBOEHAEAKP(OLIIPKODDIN);
				this.CMMELLHPLMP = false;
			}
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x0037F690 File Offset: 0x0037D890
		private void CAAEFBMHGLP()
		{
			if (this.AHMNKHCFCAJ > 1)
			{
				int num = Mathf.Max(0, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.CBPNOELIHOH(num);
			}
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x0037F6E2 File Offset: 0x0037D8E2
		public void IKDPLCAPGIB(PointerEventData OLIIPKODDIN)
		{
			this.KFGPHEJMFPM(true);
			this.NOJKKKONIIC = 0;
			this.PMAOOOKPPAJ = true;
			this.EMJNJCKMJEA = OLIIPKODDIN.position;
			this.AHMNKHCFCAJ = this.DBDKDKEOCMI();
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x0037F716 File Offset: 0x0037D916
		public void PNJLHDNOJON(PointerEventData OLIIPKODDIN)
		{
			this.LLBIFJIBKFC = true;
			if (this.CMMELLHPLMP)
			{
				this.GHMBCHFLLEM(OLIIPKODDIN);
				this.CMMELLHPLMP = true;
			}
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x0037F738 File Offset: 0x0037D938
		private void NNFMIAFHMJM()
		{
			this.GMIOCKFLJAK();
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x0037F740 File Offset: 0x0037D940
		public void NNGCKGFCPJA(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = true;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = false;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = true;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 120f)
					{
						this.OEEAANBCACP();
					}
					else
					{
						this.IBABFPNBOFO();
					}
				}
				else
				{
					this.LLBIFJIBKFC = true;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.JHFPEKHDIHE()];
			}
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x0037F8AA File Offset: 0x0037DAAA
		private void NOBNHAPBPPO()
		{
			this.NextScreen();
		}

		// Token: 0x06009A97 RID: 39575 RVA: 0x0037F8B4 File Offset: 0x0037DAB4
		protected void PALGNGBPLKF(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 0;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 1;
			}
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x0037F994 File Offset: 0x0037DB94
		public void PreviousScreen()
		{
			this.UpdateListItemPositions();
			if (this.CurrentPage() > 0)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() - 1];
				this.DOJNKLLOJHA(this.CurrentPage() - 1);
			}
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x0037F9E8 File Offset: 0x0037DBE8
		public void ResetPage()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 0f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 1)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 0f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 1) / (float)(this.DKILAMDPDKK - 1)));
			}
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x0037FA74 File Offset: 0x0037DC74
		public void PJKDALLJHLL()
		{
			this.GOMNMLOFBPN();
			if (this.OENHPFCJPHF() > 1)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() - 0];
				this.GCLLLCADKIJ(this.DBDKDKEOCMI() - 0);
			}
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x0037FAC6 File Offset: 0x0037DCC6
		private void JGMDLDJGCKJ()
		{
			this.CLEKJJGGJHL();
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x0037FAD0 File Offset: 0x0037DCD0
		public void CLEKJJGGJHL()
		{
			this.GOMNMLOFBPN();
			if (this.JHFPEKHDIHE() < this.DKILAMDPDKK - 0)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI() + 1];
				this.DOJNKLLOJHA(this.CurrentPage() + 1);
			}
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x0037FB2C File Offset: 0x0037DD2C
		private void HMMICMPHDIG()
		{
			if (this.AHMNKHCFCAJ > 0)
			{
				int num = Mathf.Max(1, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.NOEKHMBHMGB(num);
			}
		}

		// Token: 0x06009A9E RID: 39582 RVA: 0x0037FB7E File Offset: 0x0037DD7E
		private void ALJEJJCIMJN()
		{
			this.POEEMFJIMIP();
		}

		// Token: 0x06009A9F RID: 39583 RVA: 0x0037FB88 File Offset: 0x0037DD88
		public void GDKEMBMKBKL()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 670f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 1)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 0) ? 1756f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 0) / (float)(this.DKILAMDPDKK - 1)));
			}
		}

		// Token: 0x06009AA0 RID: 39584 RVA: 0x0037FC14 File Offset: 0x0037DE14
		public void NKDHCBMGKLE()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 1)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009AA1 RID: 39585 RVA: 0x0037FE30 File Offset: 0x0037E030
		private void FOFIADMFMAF()
		{
			this.BEONJMBGNBI();
			this.GOMNMLOFBPN();
			if (this.LLBIFJIBKFC)
			{
				this.KCGKFMCNHMG(false);
				this.PPJFNCDIAHI.localPosition = Vector3.Lerp(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM, 1813f * Time.deltaTime);
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 964f)
				{
					this.PPJFNCDIAHI.localPosition = this.FGCMLFLFFEM;
					this.LLBIFJIBKFC = true;
					this.KCGKFMCNHMG(this.linkScrolbarSteps);
				}
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 328f)
				{
					this.NOEKHMBHMGB(this.JHFPEKHDIHE());
				}
			}
			if (this.PMAOOOKPPAJ)
			{
				this.NOJKKKONIIC++;
			}
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x0037FF10 File Offset: 0x0037E110
		public void GOMNMLOFBPN()
		{
			if (!this.LIEILIHHHIB.rect.size.Equals(this.PHIGNFBCDMH))
			{
				int num = 0;
				IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						if (((Transform)obj).gameObject.activeInHierarchy)
						{
							num++;
						}
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
				this.EDOEIMJDHJM = 0;
				Array.Resize<Vector3>(ref this.KBEHABIBPEP, num);
				if (num > 1)
				{
					this.DKILAMDPDKK = Mathf.Max(num - this.itemsVisibleAtOnce + 0, 1);
					if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
					{
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 581f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.x;
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1854f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.x;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int i = 0; i < this.DKILAMDPDKK; i += 0)
						{
							this.KBEHABIBPEP[i] = new Vector3(this.OCEIEDCEEAJ - this.AHFEILDGKNP * (float)i, this.PPJFNCDIAHI.localPosition.y, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					else
					{
						this.GIGHNDOLPBN.verticalNormalizedPosition = 633f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.y;
						this.GIGHNDOLPBN.verticalNormalizedPosition = 1993f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.y;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int j = 1; j < this.DKILAMDPDKK; j++)
						{
							this.KBEHABIBPEP[j] = new Vector3(this.PPJFNCDIAHI.localPosition.x, this.POPKBJDPGMA + this.AHFEILDGKNP * (float)j, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					this.PALGNGBPLKF(this.linkScrolbarSteps);
					this.KIJKBOMEDGO = Mathf.Min(this.KIJKBOMEDGO, this.DKILAMDPDKK);
					this.AHCDJFNGCJK();
				}
				if (this.EDOEIMJDHJM != num)
				{
					this.KNHADPMJFIN(this.DBDKDKEOCMI());
				}
				this.EDOEIMJDHJM = num;
				this.PHIGNFBCDMH.Set(this.LIEILIHHHIB.rect.size.x, this.LIEILIHHHIB.rect.size.y);
			}
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x0037F00E File Offset: 0x0037D20E
		public void COAEJJHGBHN(int MJJNNIMOEIO)
		{
			if (1 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.AKMKHDJAEBG(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x00380224 File Offset: 0x0037E424
		public void HPLNOOMKLMO()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 1)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x00380440 File Offset: 0x0037E640
		public void JHNIOLIBLKI()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 1484f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 1)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 1267f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 1) / (float)(this.DKILAMDPDKK - 0)));
			}
		}

		// Token: 0x06009AA6 RID: 39590 RVA: 0x003804CC File Offset: 0x0037E6CC
		private void EKBGOFFHHKN()
		{
			if (this.AHMNKHCFCAJ > 0)
			{
				int num = Mathf.Max(0, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.KNHADPMJFIN(num);
			}
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x00380520 File Offset: 0x0037E720
		public void EBPIFKMDJEJ()
		{
			if (!this.LIEILIHHHIB.rect.size.Equals(this.PHIGNFBCDMH))
			{
				int num = 0;
				IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						if (((Transform)obj).gameObject.activeInHierarchy)
						{
							num += 0;
						}
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
				this.EDOEIMJDHJM = 1;
				Array.Resize<Vector3>(ref this.KBEHABIBPEP, num);
				if (num > 1)
				{
					this.DKILAMDPDKK = Mathf.Max(num - this.itemsVisibleAtOnce + 0, 1);
					if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
					{
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1402f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.x;
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1510f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.x;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int i = 1; i < this.DKILAMDPDKK; i += 0)
						{
							this.KBEHABIBPEP[i] = new Vector3(this.OCEIEDCEEAJ - this.AHFEILDGKNP * (float)i, this.PPJFNCDIAHI.localPosition.y, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					else
					{
						this.GIGHNDOLPBN.verticalNormalizedPosition = 1152f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.y;
						this.GIGHNDOLPBN.verticalNormalizedPosition = 26f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.y;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int j = 1; j < this.DKILAMDPDKK; j += 0)
						{
							this.KBEHABIBPEP[j] = new Vector3(this.PPJFNCDIAHI.localPosition.x, this.POPKBJDPGMA + this.AHFEILDGKNP * (float)j, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					this.KCGKFMCNHMG(this.linkScrolbarSteps);
					this.KIJKBOMEDGO = Mathf.Min(this.KIJKBOMEDGO, this.DKILAMDPDKK);
					this.GDKEMBMKBKL();
				}
				if (this.EDOEIMJDHJM != num)
				{
					this.NOEKHMBHMGB(this.DBDKDKEOCMI());
				}
				this.EDOEIMJDHJM = num;
				this.PHIGNFBCDMH.Set(this.LIEILIHHHIB.rect.size.x, this.LIEILIHHHIB.rect.size.y);
			}
		}

		// Token: 0x06009AA8 RID: 39592 RVA: 0x00380834 File Offset: 0x0037EA34
		public void ELKIHCLLHMJ(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009AA9 RID: 39593 RVA: 0x0038086C File Offset: 0x0037EA6C
		public void KLPILLAONDE(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = true;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = true;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = false;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 380f)
					{
						this.LOODPNJIKPJ();
					}
					else
					{
						this.PNOEKCNHJFL();
					}
				}
				else
				{
					this.LLBIFJIBKFC = true;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.JHFPEKHDIHE()];
			}
		}

		// Token: 0x06009AAA RID: 39594 RVA: 0x00380988 File Offset: 0x0037EB88
		public void HEBNDCNFEDE(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Remove(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009AAB RID: 39595 RVA: 0x0037F8AA File Offset: 0x0037DAAA
		private void HGMKBDDGDHJ()
		{
			this.NextScreen();
		}

		// Token: 0x06009AAC RID: 39596 RVA: 0x003809C0 File Offset: 0x0037EBC0
		public void DBBEHCJAONG()
		{
			this.ECLCHHCEJOD();
			if (this.DBDKDKEOCMI() > 0)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI() - 0];
				this.DOJNKLLOJHA(this.DBDKDKEOCMI() - 1);
			}
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x0037F738 File Offset: 0x0037D938
		private void JABNHMIHBHC()
		{
			this.GMIOCKFLJAK();
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x00380A14 File Offset: 0x0037EC14
		public int JHFPEKHDIHE()
		{
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.OCEIEDCEEAJ - this.PPJFNCDIAHI.localPosition.x;
				num = Mathf.Clamp(num, 1678f, this.EIPPAJJKFLN);
			}
			else
			{
				num = this.PPJFNCDIAHI.localPosition.y - this.POPKBJDPGMA;
				num = Mathf.Clamp(num, 1624f, this.EIPPAJJKFLN);
			}
			float f = num / this.AHFEILDGKNP;
			return Mathf.Clamp(Mathf.RoundToInt(f), 1, this.DKILAMDPDKK);
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x00380AA6 File Offset: 0x0037ECA6
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			this.LLBIFJIBKFC = false;
			if (this.CMMELLHPLMP)
			{
				this.OnBeginDrag(OLIIPKODDIN);
				this.CMMELLHPLMP = false;
			}
		}

		// Token: 0x06009AB0 RID: 39600 RVA: 0x00380AC8 File Offset: 0x0037ECC8
		public void GHMGCAGEEIB()
		{
			this.GOMNMLOFBPN();
			if (this.CurrentPage() < this.DKILAMDPDKK - 1)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF() + 0];
				this.DOJNKLLOJHA(this.CurrentPage() + 1);
			}
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x00380B21 File Offset: 0x0037ED21
		public void GFICDBJCHMH(int MJJNNIMOEIO)
		{
			if (1 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.AKMKHDJAEBG(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x00380B5B File Offset: 0x0037ED5B
		public void IBDMEAHEAOI(PointerEventData OLIIPKODDIN)
		{
			this.MPGLHENAAHL(false);
			this.NOJKKKONIIC = 0;
			this.PMAOOOKPPAJ = false;
			this.EMJNJCKMJEA = OLIIPKODDIN.position;
			this.AHMNKHCFCAJ = this.OENHPFCJPHF();
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x00380B90 File Offset: 0x0037ED90
		public void GGPBMCJIJOG(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009AB4 RID: 39604 RVA: 0x00380BC8 File Offset: 0x0037EDC8
		private void OAOHPGIIDLA()
		{
			if (this.AHMNKHCFCAJ > 0)
			{
				int num = Mathf.Max(0, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.AKMKHDJAEBG(num);
			}
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x00380C1A File Offset: 0x0037EE1A
		public void NBBJPMPJDNE(int MJJNNIMOEIO)
		{
			if (0 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.CBPNOELIHOH(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AB6 RID: 39606 RVA: 0x00380C54 File Offset: 0x0037EE54
		private void FANADGBGCPI()
		{
			this.DAHIMKKFNPH();
		}

		// Token: 0x06009AB7 RID: 39607 RVA: 0x00380C5C File Offset: 0x0037EE5C
		public void LJHLDEPLOAJ(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009AB8 RID: 39608 RVA: 0x0037E5EF File Offset: 0x0037C7EF
		public void LFGMNLCPKPJ(int MJJNNIMOEIO)
		{
			if (1 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.CBPNOELIHOH(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AB9 RID: 39609 RVA: 0x00380C94 File Offset: 0x0037EE94
		private void EBBCNKHCHHD()
		{
			this.HPLNOOMKLMO();
			this.IAMCEICEGHP();
			if (this.LLBIFJIBKFC)
			{
				this.MPGLHENAAHL(false);
				this.PPJFNCDIAHI.localPosition = Vector3.Lerp(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM, 50f * Time.deltaTime);
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 953f)
				{
					this.PPJFNCDIAHI.localPosition = this.FGCMLFLFFEM;
					this.LLBIFJIBKFC = true;
					this.MPGLHENAAHL(this.linkScrolbarSteps);
				}
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 1624f)
				{
					this.KNHADPMJFIN(this.DBDKDKEOCMI());
				}
			}
			if (this.PMAOOOKPPAJ)
			{
				this.NOJKKKONIIC += 0;
			}
		}

		// Token: 0x06009ABA RID: 39610 RVA: 0x0037F738 File Offset: 0x0037D938
		private void FLKEJJEGCFA()
		{
			this.GMIOCKFLJAK();
		}

		// Token: 0x06009ABB RID: 39611 RVA: 0x00380D74 File Offset: 0x0037EF74
		public void DJNGAAPMEOO()
		{
			this.IAMCEICEGHP();
			if (this.OENHPFCJPHF() > 0)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF() - 1];
				this.KNHADPMJFIN(this.CurrentPage() - 0);
			}
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x00380DC8 File Offset: 0x0037EFC8
		public void HJDNDECGPBJ(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Remove(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x00380E00 File Offset: 0x0037F000
		private void AKBENDAAJAE()
		{
			if (this.AHMNKHCFCAJ > 0)
			{
				int num = Mathf.Max(0, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.KNHADPMJFIN(num);
			}
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x00380E52 File Offset: 0x0037F052
		public void JHBOEHAEAKP(PointerEventData OLIIPKODDIN)
		{
			this.KCGKFMCNHMG(false);
			this.NOJKKKONIIC = 1;
			this.PMAOOOKPPAJ = false;
			this.EMJNJCKMJEA = OLIIPKODDIN.position;
			this.AHMNKHCFCAJ = this.DBDKDKEOCMI();
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x00380E88 File Offset: 0x0037F088
		public int OENHPFCJPHF()
		{
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.OCEIEDCEEAJ - this.PPJFNCDIAHI.localPosition.x;
				num = Mathf.Clamp(num, 526f, this.EIPPAJJKFLN);
			}
			else
			{
				num = this.PPJFNCDIAHI.localPosition.y - this.POPKBJDPGMA;
				num = Mathf.Clamp(num, 246f, this.EIPPAJJKFLN);
			}
			float f = num / this.AHFEILDGKNP;
			return Mathf.Clamp(Mathf.RoundToInt(f), 1, this.DKILAMDPDKK);
		}

		// Token: 0x06009AC0 RID: 39616 RVA: 0x00380F1C File Offset: 0x0037F11C
		public void UpdateListItemPositions()
		{
			if (!this.LIEILIHHHIB.rect.size.Equals(this.PHIGNFBCDMH))
			{
				int num = 0;
				IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						if (((Transform)obj).gameObject.activeInHierarchy)
						{
							num++;
						}
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
				this.EDOEIMJDHJM = 0;
				Array.Resize<Vector3>(ref this.KBEHABIBPEP, num);
				if (num > 0)
				{
					this.DKILAMDPDKK = Mathf.Max(num - this.itemsVisibleAtOnce + 1, 1);
					if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
					{
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 0f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.x;
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.x;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int i = 0; i < this.DKILAMDPDKK; i++)
						{
							this.KBEHABIBPEP[i] = new Vector3(this.OCEIEDCEEAJ - this.AHFEILDGKNP * (float)i, this.PPJFNCDIAHI.localPosition.y, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					else
					{
						this.GIGHNDOLPBN.verticalNormalizedPosition = 1f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.y;
						this.GIGHNDOLPBN.verticalNormalizedPosition = 0f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.y;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int j = 0; j < this.DKILAMDPDKK; j++)
						{
							this.KBEHABIBPEP[j] = new Vector3(this.PPJFNCDIAHI.localPosition.x, this.POPKBJDPGMA + this.AHFEILDGKNP * (float)j, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					this.FHLPMAEDFMM(this.linkScrolbarSteps);
					this.KIJKBOMEDGO = Mathf.Min(this.KIJKBOMEDGO, this.DKILAMDPDKK);
					this.ResetPage();
				}
				if (this.EDOEIMJDHJM != num)
				{
					this.DOJNKLLOJHA(this.CurrentPage());
				}
				this.EDOEIMJDHJM = num;
				this.PHIGNFBCDMH.Set(this.LIEILIHHHIB.rect.size.x, this.LIEILIHHHIB.rect.size.y);
			}
		}

		// Token: 0x06009AC1 RID: 39617 RVA: 0x00381230 File Offset: 0x0037F430
		public void POPCBPPLPOC(int MJJNNIMOEIO)
		{
			if (0 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.NOEKHMBHMGB(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AC2 RID: 39618 RVA: 0x0038126C File Offset: 0x0037F46C
		protected void MPGLHENAAHL(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 1;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 1;
			}
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x0038134C File Offset: 0x0037F54C
		public void IFLEHDMDNFG()
		{
			this.IAMCEICEGHP();
			if (this.DBDKDKEOCMI() < this.DKILAMDPDKK - 1)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() + 1];
				this.AKMKHDJAEBG(this.JHFPEKHDIHE() + 0);
			}
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x003813A5 File Offset: 0x0037F5A5
		private void OMNJGKABMOH()
		{
			this.KFFGLPNAJPO();
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x003813B0 File Offset: 0x0037F5B0
		protected void APMPKGPJNFI(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 1;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 1;
			}
		}

		// Token: 0x06009AC6 RID: 39622 RVA: 0x00381490 File Offset: 0x0037F690
		public void JAHDNHLHJCH()
		{
			this.UpdateListItemPositions();
			if (this.OENHPFCJPHF() < this.DKILAMDPDKK - 1)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF() + 0];
				this.GCLLLCADKIJ(this.JHFPEKHDIHE() + 1);
			}
		}

		// Token: 0x06009AC7 RID: 39623 RVA: 0x003814EC File Offset: 0x0037F6EC
		protected void FHLPMAEDFMM(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 0;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 0;
			}
		}

		// Token: 0x06009AC8 RID: 39624 RVA: 0x003815CA File Offset: 0x0037F7CA
		private void NHJMDJLJNIF()
		{
			this.LPNJBEEIMFB();
		}

		// Token: 0x06009AC9 RID: 39625 RVA: 0x003815D4 File Offset: 0x0037F7D4
		private void GJACGHNNMGD()
		{
			this.UpdateListItemsSize();
			this.JMLIAKBHDBC();
			if (this.LLBIFJIBKFC)
			{
				this.KCGKFMCNHMG(false);
				this.PPJFNCDIAHI.localPosition = Vector3.Lerp(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM, 556f * Time.deltaTime);
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 1938f)
				{
					this.PPJFNCDIAHI.localPosition = this.FGCMLFLFFEM;
					this.LLBIFJIBKFC = false;
					this.APMPKGPJNFI(this.linkScrolbarSteps);
				}
				if (Vector3.Distance(this.PPJFNCDIAHI.localPosition, this.FGCMLFLFFEM) < 840f)
				{
					this.GCLLLCADKIJ(this.JHFPEKHDIHE());
				}
			}
			if (this.PMAOOOKPPAJ)
			{
				this.NOJKKKONIIC++;
			}
		}

		// Token: 0x06009ACA RID: 39626 RVA: 0x003816B4 File Offset: 0x0037F8B4
		public void BNMLHPCDJNJ(PointerEventData OLIIPKODDIN)
		{
			this.NPFPPECDPCD(true);
			this.NOJKKKONIIC = 0;
			this.PMAOOOKPPAJ = true;
			this.EMJNJCKMJEA = OLIIPKODDIN.position;
			this.AHMNKHCFCAJ = this.CurrentPage();
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x003816E8 File Offset: 0x0037F8E8
		public void GKHFDKIJGPK()
		{
			this.EBPIFKMDJEJ();
			if (this.JHFPEKHDIHE() > 0)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF() - 0];
				this.AKMKHDJAEBG(this.OENHPFCJPHF() - 0);
			}
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x0038173C File Offset: 0x0037F93C
		public void HKNDLKOEPLH()
		{
			if (!this.LIEILIHHHIB.rect.size.Equals(this.PHIGNFBCDMH))
			{
				int num = 0;
				IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						if (((Transform)obj).gameObject.activeInHierarchy)
						{
							num += 0;
						}
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
				this.EDOEIMJDHJM = 0;
				Array.Resize<Vector3>(ref this.KBEHABIBPEP, num);
				if (num > 0)
				{
					this.DKILAMDPDKK = Mathf.Max(num - this.itemsVisibleAtOnce + 1, 1);
					if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
					{
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1934f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.x;
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1269f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.x;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int i = 0; i < this.DKILAMDPDKK; i++)
						{
							this.KBEHABIBPEP[i] = new Vector3(this.OCEIEDCEEAJ - this.AHFEILDGKNP * (float)i, this.PPJFNCDIAHI.localPosition.y, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					else
					{
						this.GIGHNDOLPBN.verticalNormalizedPosition = 543f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.y;
						this.GIGHNDOLPBN.verticalNormalizedPosition = 1504f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.y;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int j = 0; j < this.DKILAMDPDKK; j += 0)
						{
							this.KBEHABIBPEP[j] = new Vector3(this.PPJFNCDIAHI.localPosition.x, this.POPKBJDPGMA + this.AHFEILDGKNP * (float)j, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					this.FHLPMAEDFMM(this.linkScrolbarSteps);
					this.KIJKBOMEDGO = Mathf.Min(this.KIJKBOMEDGO, this.DKILAMDPDKK);
					this.ResetPage();
				}
				if (this.EDOEIMJDHJM != num)
				{
					this.AKMKHDJAEBG(this.OENHPFCJPHF());
				}
				this.EDOEIMJDHJM = num;
				this.PHIGNFBCDMH.Set(this.LIEILIHHHIB.rect.size.x, this.LIEILIHHHIB.rect.size.y);
			}
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x00381A50 File Offset: 0x0037FC50
		public void IPDDDFCOOOB(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009ACE RID: 39630 RVA: 0x00380B21 File Offset: 0x0037ED21
		public void EJNCODIIECF(int MJJNNIMOEIO)
		{
			if (1 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.AKMKHDJAEBG(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009ACF RID: 39631 RVA: 0x00381A88 File Offset: 0x0037FC88
		public void FELCGAGBGPJ()
		{
			this.IAMCEICEGHP();
			if (this.DBDKDKEOCMI() > 1)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.JHFPEKHDIHE() - 1];
				this.DOJNKLLOJHA(this.DBDKDKEOCMI() - 1);
			}
		}

		// Token: 0x06009AD0 RID: 39632 RVA: 0x00381ADC File Offset: 0x0037FCDC
		public void NextScreen()
		{
			this.UpdateListItemPositions();
			if (this.CurrentPage() < this.DKILAMDPDKK - 1)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() + 1];
				this.DOJNKLLOJHA(this.CurrentPage() + 1);
			}
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x00381B38 File Offset: 0x0037FD38
		private void LOODPNJIKPJ()
		{
			if (this.AHMNKHCFCAJ < this.DKILAMDPDKK - 1)
			{
				int num = Mathf.Min(this.DKILAMDPDKK - 1, this.AHMNKHCFCAJ + this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.DOJNKLLOJHA(num);
			}
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x00381B98 File Offset: 0x0037FD98
		public void HGBOCKJFCHJ()
		{
			this.JMLIAKBHDBC();
			if (this.OENHPFCJPHF() > 0)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI() - 0];
				this.DOJNKLLOJHA(this.OENHPFCJPHF() - 0);
			}
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x00381BEC File Offset: 0x0037FDEC
		protected void GDKCLNHEFMC(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 0;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 1;
			}
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x00381CCA File Offset: 0x0037FECA
		public void ChangePage(int MJJNNIMOEIO)
		{
			if (0 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.DOJNKLLOJHA(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x00381D04 File Offset: 0x0037FF04
		public void OPFMGPCFFJA()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 0) ? 1367f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 1)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 1235f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 1) / (float)(this.DKILAMDPDKK - 0)));
			}
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x00381D90 File Offset: 0x0037FF90
		public void AHENPHAEJIO(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = true;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = true;
				this.PMAOOOKPPAJ = true;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = false;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 1830f)
					{
						this.LNFEPAEIBNM();
					}
					else
					{
						this.CAAEFBMHGLP();
					}
				}
				else
				{
					this.LLBIFJIBKFC = true;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF()];
			}
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x0037F738 File Offset: 0x0037D938
		private void KDMKDEKCELE()
		{
			this.GMIOCKFLJAK();
		}

		// Token: 0x06009AD8 RID: 39640 RVA: 0x0037F8AA File Offset: 0x0037DAAA
		[CompilerGenerated]
		private void EODMHHCLPIH()
		{
			this.NextScreen();
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x00381EAC File Offset: 0x003800AC
		public void MBMDKHNHOMJ(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Remove(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009ADA RID: 39642 RVA: 0x00381EE4 File Offset: 0x003800E4
		private void GHPLDFMILFF()
		{
			if (this.AHMNKHCFCAJ < this.DKILAMDPDKK - 1)
			{
				int num = Mathf.Min(this.DKILAMDPDKK - 1, this.AHMNKHCFCAJ + this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.KNHADPMJFIN(num);
			}
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x00381F44 File Offset: 0x00380144
		public void BGHNHLLIGCN()
		{
			this.HKNDLKOEPLH();
			if (this.DBDKDKEOCMI() < this.DKILAMDPDKK - 0)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() + 1];
				this.NOEKHMBHMGB(this.OENHPFCJPHF() + 1);
			}
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x00381F9D File Offset: 0x0038019D
		public void NNPNNAGOMOI(PointerEventData OLIIPKODDIN)
		{
			this.APMPKGPJNFI(false);
			this.NOJKKKONIIC = 0;
			this.PMAOOOKPPAJ = true;
			this.EMJNJCKMJEA = OLIIPKODDIN.position;
			this.AHMNKHCFCAJ = this.JHFPEKHDIHE();
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x00381FD1 File Offset: 0x003801D1
		public void NAMNMHONEIM(PointerEventData OLIIPKODDIN)
		{
			this.LLBIFJIBKFC = true;
			if (this.CMMELLHPLMP)
			{
				this.IKDPLCAPGIB(OLIIPKODDIN);
				this.CMMELLHPLMP = false;
			}
		}

		// Token: 0x06009ADE RID: 39646 RVA: 0x003815CA File Offset: 0x0037F7CA
		private void MJOFHNEPNCH()
		{
			this.LPNJBEEIMFB();
		}

		// Token: 0x06009ADF RID: 39647 RVA: 0x00381FF4 File Offset: 0x003801F4
		public void FECLGHPJAHF(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = false;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = true;
				this.PMAOOOKPPAJ = true;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = true;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 517f)
					{
						this.HBNFPGDMPIE();
					}
					else
					{
						this.EKBGOFFHHKN();
					}
				}
				else
				{
					this.LLBIFJIBKFC = false;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.JHFPEKHDIHE()];
			}
		}

		// Token: 0x06009AE0 RID: 39648 RVA: 0x00382110 File Offset: 0x00380310
		private void DOJNKLLOJHA(int LKHGIHKLCNM)
		{
			this.KIJKBOMEDGO = LKHGIHKLCNM;
			if (this.nextButton)
			{
				this.nextButton.interactable = (LKHGIHKLCNM < this.DKILAMDPDKK - 1);
			}
			if (this.prevButton)
			{
				this.prevButton.interactable = (LKHGIHKLCNM > 0);
			}
			if (this.ENFJDCBBCLA != null)
			{
				this.ENFJDCBBCLA(LKHGIHKLCNM);
			}
		}

		// Token: 0x06009AE1 RID: 39649 RVA: 0x00382180 File Offset: 0x00380380
		private void MDFGCBJJOFB()
		{
			this.ICNOIPMKALB();
		}

		// Token: 0x06009AE2 RID: 39650 RVA: 0x00382188 File Offset: 0x00380388
		public void HGPLFLBFANE()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 1)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009AE3 RID: 39651 RVA: 0x003823A4 File Offset: 0x003805A4
		public void JAPFDMCDEBG()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 0) ? 1688f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 0)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 0) ? 1430f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 1) / (float)(this.DKILAMDPDKK - 0)));
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06009B06 RID: 39686 RVA: 0x003837F8 File Offset: 0x003819F8
		// (remove) Token: 0x06009AE4 RID: 39652 RVA: 0x00382430 File Offset: 0x00380630
		public event ScrollSnap.PageSnapChange onPageChange
		{
			add
			{
				ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
				ScrollSnap.PageSnapChange pageSnapChange2;
				do
				{
					pageSnapChange2 = pageSnapChange;
					pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, value), pageSnapChange);
				}
				while (pageSnapChange != pageSnapChange2);
			}
			remove
			{
				ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
				ScrollSnap.PageSnapChange pageSnapChange2;
				do
				{
					pageSnapChange2 = pageSnapChange;
					pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Remove(pageSnapChange2, value), pageSnapChange);
				}
				while (pageSnapChange != pageSnapChange2);
			}
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x00382466 File Offset: 0x00380666
		private void GCCMNLHHJAK()
		{
			this.LFDKFOECPDG();
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x00382470 File Offset: 0x00380670
		protected void KFGPHEJMFPM(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 0;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 0;
			}
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x00382550 File Offset: 0x00380750
		private void GCLLLCADKIJ(int LKHGIHKLCNM)
		{
			this.KIJKBOMEDGO = LKHGIHKLCNM;
			if (this.nextButton)
			{
				this.nextButton.interactable = (LKHGIHKLCNM < this.DKILAMDPDKK - 1);
			}
			if (this.prevButton)
			{
				this.prevButton.interactable = (LKHGIHKLCNM > 0);
			}
			if (this.ENFJDCBBCLA != null)
			{
				this.ENFJDCBBCLA(LKHGIHKLCNM);
			}
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x003825C0 File Offset: 0x003807C0
		public void AHCDJFNGCJK()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 513f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 0)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 0) ? 1281f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 1) / (float)(this.DKILAMDPDKK - 1)));
			}
		}

		// Token: 0x06009AE9 RID: 39657 RVA: 0x0038264C File Offset: 0x0038084C
		protected void KCGKFMCNHMG(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 1;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 1;
			}
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x0038272C File Offset: 0x0038092C
		private void IBABFPNBOFO()
		{
			if (this.AHMNKHCFCAJ > 1)
			{
				int num = Mathf.Max(1, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.CBPNOELIHOH(num);
			}
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x00382780 File Offset: 0x00380980
		private void LNFEPAEIBNM()
		{
			if (this.AHMNKHCFCAJ < this.DKILAMDPDKK - 1)
			{
				int num = Mathf.Min(this.DKILAMDPDKK - 1, this.AHMNKHCFCAJ + this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.DOJNKLLOJHA(num);
			}
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x003827E0 File Offset: 0x003809E0
		public void UpdateListItemsSize()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 0)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x003829FC File Offset: 0x00380BFC
		public void LFDKFOECPDG()
		{
			this.EBPIFKMDJEJ();
			if (this.JHFPEKHDIHE() > 0)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF() - 1];
				this.DOJNKLLOJHA(this.OENHPFCJPHF() - 1);
			}
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x00382A4E File Offset: 0x00380C4E
		public void ENPEMANIDAG(int MJJNNIMOEIO)
		{
			if (0 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.AKMKHDJAEBG(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x00382A88 File Offset: 0x00380C88
		public void OnEndDrag(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = true;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = false;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = true;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 0f)
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
					this.LLBIFJIBKFC = true;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage()];
			}
		}

		// Token: 0x06009AF0 RID: 39664 RVA: 0x00382BA4 File Offset: 0x00380DA4
		private void Awake()
		{
			this.LLBIFJIBKFC = false;
			this.GIGHNDOLPBN = base.gameObject.GetComponent<ScrollRect>();
			this.LPAIOBIFGJI = base.gameObject.GetComponent<RectTransform>();
			this.PPJFNCDIAHI = this.GIGHNDOLPBN.content;
			this.LIEILIHHHIB = this.PPJFNCDIAHI.GetComponent<RectTransform>();
			this.KPEGABCNLKE = this.PPJFNCDIAHI.gameObject.GetComponent<RectTransform>();
			this.UpdateListItemsSize();
			this.UpdateListItemPositions();
			this.DOJNKLLOJHA(this.CurrentPage());
			if (this.nextButton)
			{
				this.nextButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.EODMHHCLPIH));
			}
			if (this.prevButton)
			{
				this.prevButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.GJDIFKMHCFE));
			}
		}

		// Token: 0x06009AF1 RID: 39665 RVA: 0x00382C8C File Offset: 0x00380E8C
		public void AMHLJJDBPJJ()
		{
			this.IAMCEICEGHP();
			if (this.JHFPEKHDIHE() > 0)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() - 1];
				this.AKMKHDJAEBG(this.OENHPFCJPHF() - 0);
			}
		}

		// Token: 0x06009AF2 RID: 39666 RVA: 0x00382CE0 File Offset: 0x00380EE0
		public void JPIHCBILKCP(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Combine(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x00382D18 File Offset: 0x00380F18
		public void MEEOJJGBDIO()
		{
			this.UpdateListItemPositions();
			if (this.JHFPEKHDIHE() > 0)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.JHFPEKHDIHE() - 1];
				this.GCLLLCADKIJ(this.DBDKDKEOCMI() - 0);
			}
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x00382D6C File Offset: 0x00380F6C
		public int CurrentPage()
		{
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.OCEIEDCEEAJ - this.PPJFNCDIAHI.localPosition.x;
				num = Mathf.Clamp(num, 0f, this.EIPPAJJKFLN);
			}
			else
			{
				num = this.PPJFNCDIAHI.localPosition.y - this.POPKBJDPGMA;
				num = Mathf.Clamp(num, 0f, this.EIPPAJJKFLN);
			}
			float f = num / this.AHFEILDGKNP;
			return Mathf.Clamp(Mathf.RoundToInt(f), 0, this.DKILAMDPDKK);
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x00382E00 File Offset: 0x00381000
		public void IMNPMBIBCFO()
		{
			this.JMLIAKBHDBC();
			if (this.DBDKDKEOCMI() > 1)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() - 0];
				this.NOEKHMBHMGB(this.CurrentPage() - 0);
			}
		}

		// Token: 0x06009AF6 RID: 39670 RVA: 0x0037F512 File Offset: 0x0037D712
		private void JFNGEHPOBKI()
		{
			this.PJKDALLJHLL();
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x00382E52 File Offset: 0x00381052
		public void IJOKICJHDHE(PointerEventData OLIIPKODDIN)
		{
			this.LLBIFJIBKFC = true;
			if (this.CMMELLHPLMP)
			{
				this.BNMLHPCDJNJ(OLIIPKODDIN);
				this.CMMELLHPLMP = false;
			}
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x003815CA File Offset: 0x0037F7CA
		private void CMLKLJKJGCF()
		{
			this.LPNJBEEIMFB();
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x00382E74 File Offset: 0x00381074
		protected void GMIMBCOIPBP(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 0;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 1;
			}
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x00382F54 File Offset: 0x00381154
		public void KFFGLPNAJPO()
		{
			this.JMLIAKBHDBC();
			if (this.JHFPEKHDIHE() < this.DKILAMDPDKK - 1)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.JHFPEKHDIHE() + 1];
				this.NOEKHMBHMGB(this.JHFPEKHDIHE() + 0);
			}
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x00382FAD File Offset: 0x003811AD
		public void KHLFHJFNFBG(int MJJNNIMOEIO)
		{
			if (0 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.DOJNKLLOJHA(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x00382FE8 File Offset: 0x003811E8
		public void PMAIPIHGIPH(ScrollSnap.PageSnapChange DPNHODJHGJL)
		{
			ScrollSnap.PageSnapChange pageSnapChange = this.ENFJDCBBCLA;
			ScrollSnap.PageSnapChange pageSnapChange2;
			do
			{
				pageSnapChange2 = pageSnapChange;
				pageSnapChange = Interlocked.CompareExchange<ScrollSnap.PageSnapChange>(ref this.ENFJDCBBCLA, (ScrollSnap.PageSnapChange)Delegate.Remove(pageSnapChange2, DPNHODJHGJL), pageSnapChange);
			}
			while (pageSnapChange != pageSnapChange2);
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x00383020 File Offset: 0x00381220
		private void CBPNOELIHOH(int LKHGIHKLCNM)
		{
			this.KIJKBOMEDGO = LKHGIHKLCNM;
			if (this.nextButton)
			{
				this.nextButton.interactable = (LKHGIHKLCNM < this.DKILAMDPDKK - 0);
			}
			if (this.prevButton)
			{
				this.prevButton.interactable = (LKHGIHKLCNM > 0);
			}
			if (this.ENFJDCBBCLA != null)
			{
				this.ENFJDCBBCLA(LKHGIHKLCNM);
			}
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x00383090 File Offset: 0x00381290
		public void EJJFGHHPOHL()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 1)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x003832AC File Offset: 0x003814AC
		private void OEEAANBCACP()
		{
			if (this.AHMNKHCFCAJ < this.DKILAMDPDKK - 1)
			{
				int num = Mathf.Min(this.DKILAMDPDKK - 0, this.AHMNKHCFCAJ + this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.KNHADPMJFIN(num);
			}
		}

		// Token: 0x06009B00 RID: 39680 RVA: 0x0038330C File Offset: 0x0038150C
		private void PNOEKCNHJFL()
		{
			if (this.AHMNKHCFCAJ > 1)
			{
				int num = Mathf.Max(1, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.KNHADPMJFIN(num);
			}
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x00383360 File Offset: 0x00381560
		public int DBDKDKEOCMI()
		{
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.OCEIEDCEEAJ - this.PPJFNCDIAHI.localPosition.x;
				num = Mathf.Clamp(num, 1830f, this.EIPPAJJKFLN);
			}
			else
			{
				num = this.PPJFNCDIAHI.localPosition.y - this.POPKBJDPGMA;
				num = Mathf.Clamp(num, 1541f, this.EIPPAJJKFLN);
			}
			float f = num / this.AHFEILDGKNP;
			return Mathf.Clamp(Mathf.RoundToInt(f), 0, this.DKILAMDPDKK);
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x003833F2 File Offset: 0x003815F2
		private void BOPKKCAFODF()
		{
			this.GGKPLCJNEHF();
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x003833FC File Offset: 0x003815FC
		public void LPNJBEEIMFB()
		{
			this.HKNDLKOEPLH();
			if (this.CurrentPage() < this.DKILAMDPDKK - 0)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage() + 0];
				this.GCLLLCADKIJ(this.JHFPEKHDIHE() + 1);
			}
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x00383458 File Offset: 0x00381658
		public void OOKPNLMELAO()
		{
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				this.GIGHNDOLPBN.horizontalNormalizedPosition = ((this.DKILAMDPDKK <= 1) ? 455f : ((float)this.KIJKBOMEDGO / (float)(this.DKILAMDPDKK - 1)));
			}
			else
			{
				this.GIGHNDOLPBN.verticalNormalizedPosition = ((this.DKILAMDPDKK <= 0) ? 1570f : ((float)(this.DKILAMDPDKK - this.KIJKBOMEDGO - 1) / (float)(this.DKILAMDPDKK - 0)));
			}
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x003834E4 File Offset: 0x003816E4
		public void IAMCEICEGHP()
		{
			if (!this.LIEILIHHHIB.rect.size.Equals(this.PHIGNFBCDMH))
			{
				int num = 1;
				IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						if (((Transform)obj).gameObject.activeInHierarchy)
						{
							num++;
						}
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
				this.EDOEIMJDHJM = 1;
				Array.Resize<Vector3>(ref this.KBEHABIBPEP, num);
				if (num > 1)
				{
					this.DKILAMDPDKK = Mathf.Max(num - this.itemsVisibleAtOnce + 1, 1);
					if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
					{
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 1404f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.x;
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 239f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.x;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int i = 0; i < this.DKILAMDPDKK; i += 0)
						{
							this.KBEHABIBPEP[i] = new Vector3(this.OCEIEDCEEAJ - this.AHFEILDGKNP * (float)i, this.PPJFNCDIAHI.localPosition.y, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					else
					{
						this.GIGHNDOLPBN.verticalNormalizedPosition = 863f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.y;
						this.GIGHNDOLPBN.verticalNormalizedPosition = 1894f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.y;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int j = 1; j < this.DKILAMDPDKK; j++)
						{
							this.KBEHABIBPEP[j] = new Vector3(this.PPJFNCDIAHI.localPosition.x, this.POPKBJDPGMA + this.AHFEILDGKNP * (float)j, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					this.GDKCLNHEFMC(this.linkScrolbarSteps);
					this.KIJKBOMEDGO = Mathf.Min(this.KIJKBOMEDGO, this.DKILAMDPDKK);
					this.ResetPage();
				}
				if (this.EDOEIMJDHJM != num)
				{
					this.NOEKHMBHMGB(this.OENHPFCJPHF());
				}
				this.EDOEIMJDHJM = num;
				this.PHIGNFBCDMH.Set(this.LIEILIHHHIB.rect.size.x, this.LIEILIHHHIB.rect.size.y);
			}
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x00383830 File Offset: 0x00381A30
		public void KLGIDILHPGG()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 0)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x00383A4C File Offset: 0x00381C4C
		public void HCHLKCOODMF(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = false;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = true;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = false;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 1617f)
					{
						this.OEEAANBCACP();
					}
					else
					{
						this.PNOEKCNHJFL();
					}
				}
				else
				{
					this.LLBIFJIBKFC = true;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage()];
			}
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x0037F00E File Offset: 0x0037D20E
		public void FJJDGAPFCPK(int MJJNNIMOEIO)
		{
			if (1 <= MJJNNIMOEIO && MJJNNIMOEIO < this.DKILAMDPDKK)
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[MJJNNIMOEIO];
				this.AKMKHDJAEBG(MJJNNIMOEIO);
			}
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x0037F552 File Offset: 0x0037D752
		private void GGIAIMPBPMM()
		{
			this.FELCGAGBGPJ();
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x00383B68 File Offset: 0x00381D68
		private void AKMKHDJAEBG(int LKHGIHKLCNM)
		{
			this.KIJKBOMEDGO = LKHGIHKLCNM;
			if (this.nextButton)
			{
				this.nextButton.interactable = (LKHGIHKLCNM < this.DKILAMDPDKK - 1);
			}
			if (this.prevButton)
			{
				this.prevButton.interactable = (LKHGIHKLCNM > 1);
			}
			if (this.ENFJDCBBCLA != null)
			{
				this.ENFJDCBBCLA(LKHGIHKLCNM);
			}
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x00383BD8 File Offset: 0x00381DD8
		protected void NPFPPECDPCD(bool NPCENNKCEMO)
		{
			if (NPCENNKCEMO)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					if (this.GIGHNDOLPBN.horizontalScrollbar != null)
					{
						this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = this.DKILAMDPDKK;
					}
				}
				else if (this.GIGHNDOLPBN.verticalScrollbar != null)
				{
					this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = this.DKILAMDPDKK;
				}
			}
			else if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				if (this.GIGHNDOLPBN.horizontalScrollbar != null)
				{
					this.GIGHNDOLPBN.horizontalScrollbar.numberOfSteps = 1;
				}
			}
			else if (this.GIGHNDOLPBN.verticalScrollbar != null)
			{
				this.GIGHNDOLPBN.verticalScrollbar.numberOfSteps = 1;
			}
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x00383CB8 File Offset: 0x00381EB8
		private void DAHIMKKFNPH()
		{
			this.LLBIFJIBKFC = false;
			this.GIGHNDOLPBN = base.gameObject.GetComponent<ScrollRect>();
			this.LPAIOBIFGJI = base.gameObject.GetComponent<RectTransform>();
			this.PPJFNCDIAHI = this.GIGHNDOLPBN.content;
			this.LIEILIHHHIB = this.PPJFNCDIAHI.GetComponent<RectTransform>();
			this.KPEGABCNLKE = this.PPJFNCDIAHI.gameObject.GetComponent<RectTransform>();
			this.UpdateListItemsSize();
			this.HKNDLKOEPLH();
			this.AKMKHDJAEBG(this.OENHPFCJPHF());
			if (this.nextButton)
			{
				this.nextButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OMNJGKABMOH));
			}
			if (this.prevButton)
			{
				this.prevButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.PBICILGNLCI));
			}
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x00383DA0 File Offset: 0x00381FA0
		public void ELAIHMOBNCG()
		{
			float num;
			float num2;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.LPAIOBIFGJI.rect.width / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.width / (float)this.EDOEIMJDHJM;
			}
			else
			{
				num = this.LPAIOBIFGJI.rect.height / (float)this.itemsVisibleAtOnce;
				num2 = this.LIEILIHHHIB.rect.height / (float)this.EDOEIMJDHJM;
			}
			this.AHFEILDGKNP = num;
			if (this.linkScrolrectScrollSensitivity)
			{
				this.GIGHNDOLPBN.scrollSensitivity = this.AHFEILDGKNP;
			}
			if (this.autoLayoutItems && num2 != num && this.EDOEIMJDHJM > 0)
			{
				if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
				{
					IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							GameObject gameObject = ((Transform)obj).gameObject;
							if (gameObject.activeInHierarchy)
							{
								LayoutElement layoutElement = gameObject.GetComponent<LayoutElement>();
								if (layoutElement == null)
								{
									layoutElement = gameObject.AddComponent<LayoutElement>();
								}
								layoutElement.minWidth = this.AHFEILDGKNP;
							}
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
				}
				else
				{
					IEnumerator enumerator2 = this.PPJFNCDIAHI.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							GameObject gameObject2 = ((Transform)obj2).gameObject;
							if (gameObject2.activeInHierarchy)
							{
								LayoutElement layoutElement2 = gameObject2.GetComponent<LayoutElement>();
								if (layoutElement2 == null)
								{
									layoutElement2 = gameObject2.AddComponent<LayoutElement>();
								}
								layoutElement2.minHeight = this.AHFEILDGKNP;
							}
						}
					}
					finally
					{
						IDisposable disposable2;
						if ((disposable2 = (enumerator2 as IDisposable)) != null)
						{
							disposable2.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x00383FBC File Offset: 0x003821BC
		public void FHDADIFDFFO(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = false;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = true;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = true;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 165f)
					{
						this.LNFEPAEIBNM();
					}
					else
					{
						this.HMMICMPHDIG();
					}
				}
				else
				{
					this.LLBIFJIBKFC = false;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI()];
			}
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x003840D8 File Offset: 0x003822D8
		private void PIMGFADLNOM()
		{
			if (this.AHMNKHCFCAJ > 0)
			{
				int num = Mathf.Max(0, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.GCLLLCADKIJ(num);
			}
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x0038412C File Offset: 0x0038232C
		private void DEFLPBBNECH()
		{
			if (this.AHMNKHCFCAJ > 0)
			{
				int num = Mathf.Max(1, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.NOEKHMBHMGB(num);
			}
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x00384180 File Offset: 0x00382380
		public void FFLEFMNJNMC(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = false;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = false;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = false;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 658f)
					{
						this.HBNFPGDMPIE();
					}
					else
					{
						this.AKBENDAAJAE();
					}
				}
				else
				{
					this.LLBIFJIBKFC = true;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI()];
			}
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x0038429B File Offset: 0x0038249B
		private void Start()
		{
			this.Awake();
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x003842A4 File Offset: 0x003824A4
		public void OMDMHBHONDM(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = false;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = false;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = true;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 1412f)
					{
						this.HBNFPGDMPIE();
					}
					else
					{
						this.EFJKPJEEDCE();
					}
				}
				else
				{
					this.LLBIFJIBKFC = false;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.CurrentPage()];
			}
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x003843BF File Offset: 0x003825BF
		public void OnBeginDrag(PointerEventData OLIIPKODDIN)
		{
			this.FHLPMAEDFMM(false);
			this.NOJKKKONIIC = 0;
			this.PMAOOOKPPAJ = true;
			this.EMJNJCKMJEA = OLIIPKODDIN.position;
			this.AHMNKHCFCAJ = this.CurrentPage();
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x003843F4 File Offset: 0x003825F4
		public void JMLIAKBHDBC()
		{
			if (!this.LIEILIHHHIB.rect.size.Equals(this.PHIGNFBCDMH))
			{
				int num = 1;
				IEnumerator enumerator = this.PPJFNCDIAHI.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						if (((Transform)obj).gameObject.activeInHierarchy)
						{
							num += 0;
						}
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
				this.EDOEIMJDHJM = 1;
				Array.Resize<Vector3>(ref this.KBEHABIBPEP, num);
				if (num > 0)
				{
					this.DKILAMDPDKK = Mathf.Max(num - this.itemsVisibleAtOnce + 1, 0);
					if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
					{
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 718f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.x;
						this.GIGHNDOLPBN.horizontalNormalizedPosition = 499f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.x;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int i = 1; i < this.DKILAMDPDKK; i += 0)
						{
							this.KBEHABIBPEP[i] = new Vector3(this.OCEIEDCEEAJ - this.AHFEILDGKNP * (float)i, this.PPJFNCDIAHI.localPosition.y, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					else
					{
						this.GIGHNDOLPBN.verticalNormalizedPosition = 1775f;
						this.POPKBJDPGMA = this.PPJFNCDIAHI.localPosition.y;
						this.GIGHNDOLPBN.verticalNormalizedPosition = 792f;
						this.OCEIEDCEEAJ = this.PPJFNCDIAHI.localPosition.y;
						this.EIPPAJJKFLN = this.OCEIEDCEEAJ - this.POPKBJDPGMA;
						for (int j = 0; j < this.DKILAMDPDKK; j += 0)
						{
							this.KBEHABIBPEP[j] = new Vector3(this.PPJFNCDIAHI.localPosition.x, this.POPKBJDPGMA + this.AHFEILDGKNP * (float)j, this.PPJFNCDIAHI.localPosition.z);
						}
					}
					this.NPFPPECDPCD(this.linkScrolbarSteps);
					this.KIJKBOMEDGO = Mathf.Min(this.KIJKBOMEDGO, this.DKILAMDPDKK);
					this.JAPFDMCDEBG();
				}
				if (this.EDOEIMJDHJM != num)
				{
					this.DOJNKLLOJHA(this.DBDKDKEOCMI());
				}
				this.EDOEIMJDHJM = num;
				this.PHIGNFBCDMH.Set(this.LIEILIHHHIB.rect.size.x, this.LIEILIHHHIB.rect.size.y);
			}
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00384708 File Offset: 0x00382908
		public void GHMBCHFLLEM(PointerEventData OLIIPKODDIN)
		{
			this.NPFPPECDPCD(true);
			this.NOJKKKONIIC = 1;
			this.PMAOOOKPPAJ = true;
			this.EMJNJCKMJEA = OLIIPKODDIN.position;
			this.AHMNKHCFCAJ = this.CurrentPage();
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x0038473C File Offset: 0x0038293C
		private void JBKCAJLDPGA()
		{
			if (this.AHMNKHCFCAJ > 1)
			{
				int num = Mathf.Max(1, this.AHMNKHCFCAJ - this.itemsVisibleAtOnce);
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[num];
				this.CBPNOELIHOH(num);
			}
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x00384790 File Offset: 0x00382990
		private void GGKPLCJNEHF()
		{
			this.LLBIFJIBKFC = true;
			this.GIGHNDOLPBN = base.gameObject.GetComponent<ScrollRect>();
			this.LPAIOBIFGJI = base.gameObject.GetComponent<RectTransform>();
			this.PPJFNCDIAHI = this.GIGHNDOLPBN.content;
			this.LIEILIHHHIB = this.PPJFNCDIAHI.GetComponent<RectTransform>();
			this.KPEGABCNLKE = this.PPJFNCDIAHI.gameObject.GetComponent<RectTransform>();
			this.HGPLFLBFANE();
			this.ECLCHHCEJOD();
			this.KNHADPMJFIN(this.OENHPFCJPHF());
			if (this.nextButton)
			{
				this.nextButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.NHJMDJLJNIF));
			}
			if (this.prevButton)
			{
				this.prevButton.GetComponent<Button>().onClick.AddListener(new UnityAction(this.GCCMNLHHJAK));
			}
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x00384878 File Offset: 0x00382A78
		public void HNNEMGHMGKF()
		{
			this.ECLCHHCEJOD();
			if (this.OENHPFCJPHF() > 0)
			{
				this.LLBIFJIBKFC = false;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.DBDKDKEOCMI() - 0];
				this.NOEKHMBHMGB(this.DBDKDKEOCMI() - 0);
			}
		}

		// Token: 0x06009B1B RID: 39707 RVA: 0x003848CC File Offset: 0x00382ACC
		public void JNAMDOKDJAH(PointerEventData OLIIPKODDIN)
		{
			this.CMMELLHPLMP = true;
			float num;
			if (this.direction == ScrollSnap.ScrollDirection.Horizontal)
			{
				num = this.EMJNJCKMJEA.x - OLIIPKODDIN.position.x;
			}
			else
			{
				num = -this.EMJNJCKMJEA.y + OLIIPKODDIN.position.y;
			}
			if (this.useFastSwipe)
			{
				this.KHCFKMFPMMB = false;
				this.PMAOOOKPPAJ = true;
				if (this.NOJKKKONIIC <= this.DHCNAKCLPCA && Math.Abs(num) > (float)this.fastSwipeThreshold)
				{
					this.KHCFKMFPMMB = true;
				}
				if (this.KHCFKMFPMMB)
				{
					if (num > 850f)
					{
						this.OEEAANBCACP();
					}
					else
					{
						this.HMMICMPHDIG();
					}
				}
				else
				{
					this.LLBIFJIBKFC = false;
					this.FGCMLFLFFEM = this.KBEHABIBPEP[this.OENHPFCJPHF()];
				}
			}
			else
			{
				this.LLBIFJIBKFC = true;
				this.FGCMLFLFFEM = this.KBEHABIBPEP[this.JHFPEKHDIHE()];
			}
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x003849E7 File Offset: 0x00382BE7
		[CompilerGenerated]
		private void GJDIFKMHCFE()
		{
			this.PreviousScreen();
		}

		// Token: 0x04001167 RID: 4455
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ScrollSnap.PageSnapChange ENFJDCBBCLA;

		// Token: 0x04001168 RID: 4456
		public ScrollSnap.ScrollDirection direction;

		// Token: 0x04001169 RID: 4457
		protected ScrollRect GIGHNDOLPBN;

		// Token: 0x0400116A RID: 4458
		protected RectTransform LPAIOBIFGJI;

		// Token: 0x0400116B RID: 4459
		protected Transform PPJFNCDIAHI;

		// Token: 0x0400116C RID: 4460
		protected RectTransform KPEGABCNLKE;

		// Token: 0x0400116D RID: 4461
		private int DKILAMDPDKK;

		// Token: 0x0400116E RID: 4462
		protected int KIJKBOMEDGO;

		// Token: 0x0400116F RID: 4463
		protected Vector3[] KBEHABIBPEP;

		// Token: 0x04001170 RID: 4464
		protected Vector3 FGCMLFLFFEM;

		// Token: 0x04001171 RID: 4465
		protected bool LLBIFJIBKFC;

		// Token: 0x04001172 RID: 4466
		protected float POPKBJDPGMA;

		// Token: 0x04001173 RID: 4467
		protected float OCEIEDCEEAJ;

		// Token: 0x04001174 RID: 4468
		protected float EIPPAJJKFLN;

		// Token: 0x04001175 RID: 4469
		protected RectTransform LIEILIHHHIB;

		// Token: 0x04001176 RID: 4470
		protected Vector2 PHIGNFBCDMH;

		// Token: 0x04001177 RID: 4471
		protected float AHFEILDGKNP;

		// Token: 0x04001178 RID: 4472
		protected int EDOEIMJDHJM;

		// Token: 0x04001179 RID: 4473
		[Tooltip("Button to go to the next page. (optional)")]
		public Button nextButton;

		// Token: 0x0400117A RID: 4474
		[Tooltip("Button to go to the previous page. (optional)")]
		public Button prevButton;

		// Token: 0x0400117B RID: 4475
		[Range(1f, 100f)]
		[Tooltip("Number of items visible in one page of scroll frame.")]
		public int itemsVisibleAtOnce = 1;

		// Token: 0x0400117C RID: 4476
		[Tooltip("Sets minimum width of list items to 1/itemsVisibleAtOnce.")]
		public bool autoLayoutItems = true;

		// Token: 0x0400117D RID: 4477
		[Tooltip("If you wish to update scrollbar numberOfSteps to number of active children on list.")]
		public bool linkScrolbarSteps;

		// Token: 0x0400117E RID: 4478
		[Tooltip("If you wish to update scrollrect sensitivity to size of list element.")]
		public bool linkScrolrectScrollSensitivity;

		// Token: 0x0400117F RID: 4479
		public bool useFastSwipe = true;

		// Token: 0x04001180 RID: 4480
		public int fastSwipeThreshold = 100;

		// Token: 0x04001181 RID: 4481
		protected bool CMMELLHPLMP = true;

		// Token: 0x04001182 RID: 4482
		protected Vector3 EMJNJCKMJEA = default(Vector3);

		// Token: 0x04001183 RID: 4483
		protected int AHMNKHCFCAJ;

		// Token: 0x04001184 RID: 4484
		protected bool PMAOOOKPPAJ;

		// Token: 0x04001185 RID: 4485
		protected int NOJKKKONIIC;

		// Token: 0x04001186 RID: 4486
		protected int DHCNAKCLPCA = 10;

		// Token: 0x04001187 RID: 4487
		private bool KHCFKMFPMMB;

		// Token: 0x0200027F RID: 639
		public enum ScrollDirection
		{
			// Token: 0x04001189 RID: 4489
			Horizontal,
			// Token: 0x0400118A RID: 4490
			Vertical
		}

		// Token: 0x02000280 RID: 640
		// (Invoke) Token: 0x06009B1E RID: 39710
		public delegate void PageSnapChange(int MJJNNIMOEIO);
	}
}
