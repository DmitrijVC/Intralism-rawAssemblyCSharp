using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200029A RID: 666
	[AddComponentMenu("UI/Extensions/RescalePanels/ResizePanel")]
	public class ResizePanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x0600A041 RID: 41025 RVA: 0x003BF87C File Offset: 0x003BDA7C
		public void EACFCDNNPHP(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x003BF95C File Offset: 0x003BDB5C
		public void PPJOEEEOEKK(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x003BFA3C File Offset: 0x003BDC3C
		public void PPPJCOACFMH(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x003BFB1C File Offset: 0x003BDD1C
		private void FOMCIHEDIHI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1263f * width, 1684f * height);
			this.maxSize = new Vector2(1002f * width, 1105f * height);
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x003BFBA4 File Offset: 0x003BDDA4
		private void LBOBAIGNOML()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(304f * width, 249f * height);
			this.maxSize = new Vector2(262f * width, 881f * height);
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x003BFC2C File Offset: 0x003BDE2C
		private void JOBBGDGHJMB()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(472f * width, 1895f * height);
			this.maxSize = new Vector2(1852f * width, 526f * height);
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x003BFCB4 File Offset: 0x003BDEB4
		public void JMNDCAOMADA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x003BFD94 File Offset: 0x003BDF94
		private void LFHKGIHNONL()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1227f * width, 176f * height);
			this.maxSize = new Vector2(323f * width, 423f * height);
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void CODNBMDAMEG(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void IOAMFBJCMOD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A04B RID: 41035 RVA: 0x003BFE48 File Offset: 0x003BE048
		private void DHNANELONED()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(806f * width, 1759f * height);
			this.maxSize = new Vector2(824f * width, 346f * height);
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x003BFED0 File Offset: 0x003BE0D0
		public void JLMIGIMEIDA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x003BFFB0 File Offset: 0x003BE1B0
		public void PHMLOFLENEF(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x003C0090 File Offset: 0x003BE290
		private void GBNOIKAPBBO()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1770f * width, 1283f * height);
			this.maxSize = new Vector2(1873f * width, 669f * height);
		}

		// Token: 0x0600A04F RID: 41039 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void INKFELLKDFO(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void PIPIDPPIJCF(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x003C0118 File Offset: 0x003BE318
		public void BECFOLOMCLM(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A052 RID: 41042 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void HLFDGLFFBPC(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A053 RID: 41043 RVA: 0x003C01F8 File Offset: 0x003BE3F8
		public void HFKDDAMLINH(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A054 RID: 41044 RVA: 0x003C02D8 File Offset: 0x003BE4D8
		public void CGLDMLFNDNM(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A055 RID: 41045 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void ECMPCPPLJFM(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A056 RID: 41046 RVA: 0x003C03B8 File Offset: 0x003BE5B8
		public void LCDHHKHMOIC(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void JNDEBODOEDE(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void CKLJJLGMHGM(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x003C0498 File Offset: 0x003BE698
		private void PEMPABLNJHL()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(498f * width, 743f * height);
			this.maxSize = new Vector2(980f * width, 1685f * height);
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x003C0520 File Offset: 0x003BE720
		private void CJHMHIMKILB()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(872f * width, 986f * height);
			this.maxSize = new Vector2(1270f * width, 1664f * height);
		}

		// Token: 0x0600A05B RID: 41051 RVA: 0x003C05A8 File Offset: 0x003BE7A8
		private void FIABIKEIEKH()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1260f * width, 141f * height);
			this.maxSize = new Vector2(1562f * width, 402f * height);
		}

		// Token: 0x0600A05C RID: 41052 RVA: 0x003C0630 File Offset: 0x003BE830
		public void DNGHEOANENG(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void HPHCCCHINOM(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x003C0710 File Offset: 0x003BE910
		private void BANHFNDEPPO()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1409f * width, 984f * height);
			this.maxSize = new Vector2(128f * width, 1876f * height);
		}

		// Token: 0x0600A05F RID: 41055 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void DPIDABLHJAD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void BEONMAKCMNB(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x003C0798 File Offset: 0x003BE998
		private void MFIMFMCMADK()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1157f * width, 1440f * height);
			this.maxSize = new Vector2(1949f * width, 1227f * height);
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x003C0820 File Offset: 0x003BEA20
		public void DEIKCIFLMCJ(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A063 RID: 41059 RVA: 0x003C0900 File Offset: 0x003BEB00
		private void PNMCFKNENLJ()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1262f * width, 1511f * height);
			this.maxSize = new Vector2(335f * width, 1123f * height);
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x003C0988 File Offset: 0x003BEB88
		private void MGGNFEPGIJI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(902f * width, 913f * height);
			this.maxSize = new Vector2(1005f * width, 1870f * height);
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x003C0A10 File Offset: 0x003BEC10
		private void JNIPABEGJND()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1773f * width, 1890f * height);
			this.maxSize = new Vector2(1338f * width, 1710f * height);
		}

		// Token: 0x0600A066 RID: 41062 RVA: 0x003C0A98 File Offset: 0x003BEC98
		private void GLALDPKMEDN()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(967f * width, 631f * height);
			this.maxSize = new Vector2(247f * width, 1329f * height);
		}

		// Token: 0x0600A067 RID: 41063 RVA: 0x003C0B20 File Offset: 0x003BED20
		private void DMIKIDGJEFC()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1705f * width, 768f * height);
			this.maxSize = new Vector2(1516f * width, 518f * height);
		}

		// Token: 0x0600A068 RID: 41064 RVA: 0x003C0BA8 File Offset: 0x003BEDA8
		public void GPMBKLGKOPP(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A069 RID: 41065 RVA: 0x003C0C88 File Offset: 0x003BEE88
		private void LFFAKAOAOCN()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1252f * width, 572f * height);
			this.maxSize = new Vector2(1293f * width, 957f * height);
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void OOBICMGFHEA(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void ABOPBKJNNKJ(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void AMCDKLDMEIM(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x003C0D10 File Offset: 0x003BEF10
		private void GOBHPAJFFDB()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1712f * width, 1001f * height);
			this.maxSize = new Vector2(1272f * width, 329f * height);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x003C0D98 File Offset: 0x003BEF98
		private void AJIKPEIGACI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1119f * width, 809f * height);
			this.maxSize = new Vector2(1532f * width, 83f * height);
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x003C0E20 File Offset: 0x003BF020
		public void BDLGDBONFMK(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x003C0F00 File Offset: 0x003BF100
		private void NLNAJMCBNDC()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1309f * width, 59f * height);
			this.maxSize = new Vector2(114f * width, 62f * height);
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x003C0F88 File Offset: 0x003BF188
		private void DEJEBOGKMJO()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(179f * width, 33f * height);
			this.maxSize = new Vector2(279f * width, 358f * height);
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x003C1010 File Offset: 0x003BF210
		public void MFFABDMLCDO(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x003C10F0 File Offset: 0x003BF2F0
		public void AMCCALKONAG(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void BMFCMFPCGKO(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x003C11D0 File Offset: 0x003BF3D0
		public void AGEGKOGHBGM(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void CPDBIAIJAPO(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x003C12B0 File Offset: 0x003BF4B0
		public void KOGFFLNAJGB(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x003C1390 File Offset: 0x003BF590
		private void BHCCNFJKGPD()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1576f * width, 1869f * height);
			this.maxSize = new Vector2(1385f * width, 1800f * height);
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x003C1418 File Offset: 0x003BF618
		public void GGOJJEGCNNH(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x003C14F8 File Offset: 0x003BF6F8
		private void OBPCMAFGLON()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1584f * width, 782f * height);
			this.maxSize = new Vector2(1600f * width, 742f * height);
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x003C1580 File Offset: 0x003BF780
		private void Awake()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(0.1f * width, 0.1f * height);
			this.maxSize = new Vector2(10f * width, 10f * height);
		}

		// Token: 0x0600A07C RID: 41084 RVA: 0x003C1608 File Offset: 0x003BF808
		private void BFFHPJMMGHD()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(762f * width, 1636f * height);
			this.maxSize = new Vector2(1261f * width, 977f * height);
		}

		// Token: 0x0600A07D RID: 41085 RVA: 0x003C1690 File Offset: 0x003BF890
		private void JIJPHEDDIHC()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(578f * width, 1727f * height);
			this.maxSize = new Vector2(40f * width, 709f * height);
		}

		// Token: 0x0600A07E RID: 41086 RVA: 0x003C1718 File Offset: 0x003BF918
		public void OnDrag(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x003C17F8 File Offset: 0x003BF9F8
		public void GAIKALMKMIB(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void LCBNBDOHBMK(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x003C18D8 File Offset: 0x003BFAD8
		private void OJBFBLHIEBB()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1672f * width, 1467f * height);
			this.maxSize = new Vector2(1861f * width, 1196f * height);
		}

		// Token: 0x0600A082 RID: 41090 RVA: 0x003C1960 File Offset: 0x003BFB60
		private void PHHOMLJECOJ()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1387f * width, 156f * height);
			this.maxSize = new Vector2(76f * width, 557f * height);
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x003C19E8 File Offset: 0x003BFBE8
		public void DBLIMHEKNGH(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x003C1AC8 File Offset: 0x003BFCC8
		public void LOCGKLENAFL(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x003C1BA8 File Offset: 0x003BFDA8
		public void HNMDAFGIOIK(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x003C1C88 File Offset: 0x003BFE88
		private void HKKLLDHKBMI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1362f * width, 1277f * height);
			this.maxSize = new Vector2(749f * width, 253f * height);
		}

		// Token: 0x0600A087 RID: 41095 RVA: 0x003C1D10 File Offset: 0x003BFF10
		private void HCNECNPPEKA()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(407f * width, 1543f * height);
			this.maxSize = new Vector2(1624f * width, 1733f * height);
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x003C1D98 File Offset: 0x003BFF98
		public void DCMLCEFNAEJ(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x003C1E78 File Offset: 0x003C0078
		public void EIDOFBMFNLB(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x003C1F58 File Offset: 0x003C0158
		private void OLFNCABJBHA()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(442f * width, 1494f * height);
			this.maxSize = new Vector2(1531f * width, 387f * height);
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void GNBEFOEOIIK(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void OGNPMLLPKMD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x003C1FE0 File Offset: 0x003C01E0
		private void NCBGPIKDFIA()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1282f * width, 1968f * height);
			this.maxSize = new Vector2(646f * width, 51f * height);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x003C2068 File Offset: 0x003C0268
		public void IJOKICJHDHE(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x003C2148 File Offset: 0x003C0348
		private void EBPAOCJEJGE()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1247f * width, 630f * height);
			this.maxSize = new Vector2(853f * width, 1703f * height);
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void DJEHFOLMNPB(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void NEAIICPOHBI(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void OnPointerDown(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x003C21D0 File Offset: 0x003C03D0
		private void HKDMCBDOGDK()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1961f * width, 1149f * height);
			this.maxSize = new Vector2(1455f * width, 1436f * height);
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x003C2258 File Offset: 0x003C0458
		private void LHMDCEDONEE()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1895f * width, 1416f * height);
			this.maxSize = new Vector2(1552f * width, 1429f * height);
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x003C22E0 File Offset: 0x003C04E0
		public void CFIEFBKBAMJ(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void NFNJLBLGKPF(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x003C23C0 File Offset: 0x003C05C0
		public void BGBNCHOEFOE(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void PPEFKEGHDJD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x003C24A0 File Offset: 0x003C06A0
		private void KGMCGGIEPDE()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(653f * width, 183f * height);
			this.maxSize = new Vector2(141f * width, 492f * height);
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x003C2528 File Offset: 0x003C0728
		public void PNAFHIHBKHB(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x003C2608 File Offset: 0x003C0808
		public void LPENBOCGNJK(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A09D RID: 41117 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void MMMDCONOAFK(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A09E RID: 41118 RVA: 0x003C26E8 File Offset: 0x003C08E8
		public void NGEEOJPIHAG(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A09F RID: 41119 RVA: 0x003C27C8 File Offset: 0x003C09C8
		private void OKADMJFLMGP()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1977f * width, 1674f * height);
			this.maxSize = new Vector2(1166f * width, 1244f * height);
		}

		// Token: 0x0600A0A0 RID: 41120 RVA: 0x003C2850 File Offset: 0x003C0A50
		private void PIIMBOLGHOE()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1916f * width, 1878f * height);
			this.maxSize = new Vector2(837f * width, 918f * height);
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x003C28D8 File Offset: 0x003C0AD8
		public void JBOMOJELPFJ(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void LNMLCNDAOPC(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x003C29B8 File Offset: 0x003C0BB8
		private void IKKPINNOOLG()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1070f * width, 1942f * height);
			this.maxSize = new Vector2(359f * width, 640f * height);
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x003C2A40 File Offset: 0x003C0C40
		public void DEEJBOILMCC(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x003C2B20 File Offset: 0x003C0D20
		public void IGEKEPEGJMB(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void GKHGCCKHLLK(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x003C2C00 File Offset: 0x003C0E00
		public void BJJFBGIBKMG(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector2 vector = this.KPEGABCNLKE.sizeDelta;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector2(vector2.x, this.PGAOPOGPBOO * vector2.x);
			vector = new Vector2(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y));
			this.KPEGABCNLKE.sizeDelta = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x003C2CE0 File Offset: 0x003C0EE0
		private void NEEIFNDHDOG()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(803f * width, 1709f * height);
			this.maxSize = new Vector2(1505f * width, 209f * height);
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x003C2D68 File Offset: 0x003C0F68
		private void JHPKLGGMCBL()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(458f * width, 597f * height);
			this.maxSize = new Vector2(517f * width, 933f * height);
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void IFLKBPGNCOC(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x003BFE1A File Offset: 0x003BE01A
		public void BJCLJELPAHI(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x003C2DF0 File Offset: 0x003C0FF0
		private void KEKNHAAEPCJ()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1418f * width, 79f * height);
			this.maxSize = new Vector2(636f * width, 868f * height);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x003C2E78 File Offset: 0x003C1078
		private void DAHIMKKFNPH()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			float width = this.KPEGABCNLKE.rect.width;
			float height = this.KPEGABCNLKE.rect.height;
			this.PGAOPOGPBOO = height / width;
			this.minSize = new Vector2(1210f * width, 1369f * height);
			this.maxSize = new Vector2(776f * width, 1069f * height);
		}

		// Token: 0x04001241 RID: 4673
		public Vector2 minSize;

		// Token: 0x04001242 RID: 4674
		public Vector2 maxSize;

		// Token: 0x04001243 RID: 4675
		private RectTransform KPEGABCNLKE;

		// Token: 0x04001244 RID: 4676
		private Vector2 BIAFELAGCHD;

		// Token: 0x04001245 RID: 4677
		private Vector2 KFGABIOHJCD;

		// Token: 0x04001246 RID: 4678
		private float PGAOPOGPBOO;
	}
}
