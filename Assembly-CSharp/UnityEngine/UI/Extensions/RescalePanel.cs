using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000299 RID: 665
	[AddComponentMenu("UI/Extensions/RescalePanels/RescalePanel")]
	public class RescalePanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x06009FDA RID: 40922 RVA: 0x003BCA50 File Offset: 0x003BAC50
		public void JLMIGIMEIDA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 343f, -vector2.y * 314f, 256f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1355f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x003BCB78 File Offset: 0x003BAD78
		private void CEKLAECJCKG()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x003BCBCC File Offset: 0x003BADCC
		private void GOBHPAJFFDB()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x003BCC20 File Offset: 0x003BAE20
		private void CIAHIJIOFIE()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x003BCC74 File Offset: 0x003BAE74
		public void HNIIPPPPKIB(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 716f, -vector2.y * 853f, 153f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1389f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x003BCD9C File Offset: 0x003BAF9C
		private void PMBIKIBOHOF()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x003BCDF0 File Offset: 0x003BAFF0
		public void PDDLKDGBEBH(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 779f, -vector2.y * 979f, 1053f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 606f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void MNGLBBFLPFE(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x003BCF44 File Offset: 0x003BB144
		public void BGBNCHOEFOE(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 144f, -vector2.y * 965f, 413f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 512f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x003BD06C File Offset: 0x003BB26C
		public void DCDNJADEHFA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1976f, -vector2.y * 417f, 1742f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1206f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x003BD194 File Offset: 0x003BB394
		private void JOBBGDGHJMB()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x003BD1E8 File Offset: 0x003BB3E8
		private void NCBGPIKDFIA()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void LCBNBDOHBMK(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void PDLHNIDNPMP(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x003BD23C File Offset: 0x003BB43C
		private void JHPKLGGMCBL()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x003BD290 File Offset: 0x003BB490
		private void MADENBGHKDD()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void LIPHKAAMJJA(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void KDPPJGINLKD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x003BD2E4 File Offset: 0x003BB4E4
		public void LCDHHKHMOIC(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 315f, -vector2.y * 935f, 1339f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 589f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x003BD40C File Offset: 0x003BB60C
		private void MMPOJCFOGJJ()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x003BD460 File Offset: 0x003BB660
		public void AIMHJGCDGFM(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 489f, -vector2.y * 413f, 1191f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 134f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x003BD588 File Offset: 0x003BB788
		public void LHGBOMGFMLK(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 863f, -vector2.y * 841f, 1329f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 387f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x003BD6B0 File Offset: 0x003BB8B0
		private void PPGKBEJLBFJ()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x003BD704 File Offset: 0x003BB904
		private void IKKPINNOOLG()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x003BD758 File Offset: 0x003BB958
		public void LOCGKLENAFL(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 360f, -vector2.y * 187f, 1185f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1180f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x003BD880 File Offset: 0x003BBA80
		private void HHJBBHEBJCJ()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x003BD8D4 File Offset: 0x003BBAD4
		public void NBENCHOPPBK(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1572f, -vector2.y * 495f, 1202f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 841f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x003BD9FC File Offset: 0x003BBBFC
		public void OnDrag(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 0.001f, -vector2.y * 0.001f, 0f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x003BDB24 File Offset: 0x003BBD24
		private void AJIKPEIGACI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x003BDB78 File Offset: 0x003BBD78
		private void POHMFMNEPKK()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FF8 RID: 40952 RVA: 0x003BDBCC File Offset: 0x003BBDCC
		public void DABHMIOJMCA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1568f, -vector2.y * 120f, 1951f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 212f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x003BDCF4 File Offset: 0x003BBEF4
		private void JNBMKLFJCEM()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x003BDD48 File Offset: 0x003BBF48
		public void HHPDLMMNJPA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 566f, -vector2.y * 1607f, 1858f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 918f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void IFLKBPGNCOC(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x003BDE70 File Offset: 0x003BC070
		public void NGEEOJPIHAG(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1144f, -vector2.y * 357f, 950f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 548f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x06009FFD RID: 40957 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void JCKHOLLCLEJ(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x003BDF98 File Offset: 0x003BC198
		private void BMAGFLLGDPJ()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x003BDFEC File Offset: 0x003BC1EC
		private void GLGOLEOAFOD()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x003BE040 File Offset: 0x003BC240
		public void DCMLCEFNAEJ(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 834f, -vector2.y * 1918f, 1771f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 156f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x003BE168 File Offset: 0x003BC368
		private void MFIMFMCMADK()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void DPIDABLHJAD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void ANFLHOLGLLD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void PCGMGJFECAE(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void HPNBCLDKEID(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x003BE1BC File Offset: 0x003BC3BC
		private void EPCGHAAONLN()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x003BE210 File Offset: 0x003BC410
		private void CJEDMGCKHBI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x003BE264 File Offset: 0x003BC464
		private void OKADMJFLMGP()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x003BE2B8 File Offset: 0x003BC4B8
		private void GGKPLCJNEHF()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x003BE30C File Offset: 0x003BC50C
		public void GPMBKLGKOPP(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1676f, -vector2.y * 1763f, 1300f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 453f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x003BE434 File Offset: 0x003BC634
		private void FIABIKEIEKH()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x003BE488 File Offset: 0x003BC688
		private void OPFDGBDADMA()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x003BE4DC File Offset: 0x003BC6DC
		public void EEKOPFAOFCC(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1612f, -vector2.y * 1918f, 1487f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1239f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void BNNILFGNGML(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x003BE604 File Offset: 0x003BC804
		public void FIIOMMPPCAA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 308f, -vector2.y * 788f, 735f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1551f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void MHDFMCHNHOJ(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x003BE72C File Offset: 0x003BC92C
		private void GCDNONIKKLI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void CODNBMDAMEG(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void NIAAIHLJIHF(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A014 RID: 40980 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void NFNJLBLGKPF(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x003BE780 File Offset: 0x003BC980
		private void OBAIHNFOJGN()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void PPEFKEGHDJD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void OnPointerDown(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x003BE7D4 File Offset: 0x003BC9D4
		private void HCNECNPPEKA()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x003BE828 File Offset: 0x003BCA28
		public void ABIGIFHIJLH(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1060f, -vector2.y * 1148f, 770f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1843f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A01A RID: 40986 RVA: 0x003BE950 File Offset: 0x003BCB50
		private void HKDMCBDOGDK()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A01B RID: 40987 RVA: 0x003BE9A4 File Offset: 0x003BCBA4
		public void PACJHDDENEJ(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 778f, -vector2.y * 1015f, 554f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1906f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void CONGIDEEKLF(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void MAFGOJMPAAF(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x003BEACC File Offset: 0x003BCCCC
		private void MFAMHKBMBEI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A020 RID: 40992 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void IOAMFBJCMOD(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void AMCDKLDMEIM(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void GNBEFOEOIIK(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x003BEB20 File Offset: 0x003BCD20
		private void JEEINPBLBDI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x003BEB74 File Offset: 0x003BCD74
		private void FOMCIHEDIHI()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void BDFBPMMDJKJ(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x003BEBC8 File Offset: 0x003BCDC8
		private void LHMDCEDONEE()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A027 RID: 40999 RVA: 0x003BEC1C File Offset: 0x003BCE1C
		private void CNDGDDLEFJF()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A028 RID: 41000 RVA: 0x003BEC70 File Offset: 0x003BCE70
		private void OLFNCABJBHA()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A029 RID: 41001 RVA: 0x003BECC4 File Offset: 0x003BCEC4
		private void JIJPHEDDIHC()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A02A RID: 41002 RVA: 0x003BED18 File Offset: 0x003BCF18
		public void ONGEAJFHCHB(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1377f, -vector2.y * 1847f, 406f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1696f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A02B RID: 41003 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void OOBICMGFHEA(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void IOEIGMEHGMH(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x003BEE40 File Offset: 0x003BD040
		public void INCJANDEKNL(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 804f, -vector2.y * 1991f, 1576f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1667f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void ECMPCPPLJFM(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void CKGLAAIDMIG(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x003BEF68 File Offset: 0x003BD168
		public void MAOMMPHGLEF(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 926f, -vector2.y * 965f, 372f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1125f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void ABOPBKJNNKJ(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A032 RID: 41010 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void IAPNKOLECMJ(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void JNJDPLIDCMO(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x003BF090 File Offset: 0x003BD290
		private void Awake()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x003BF0E4 File Offset: 0x003BD2E4
		public void JHHDCFMGGGE(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1556f, -vector2.y * 1801f, 1483f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 45f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x003BF20C File Offset: 0x003BD40C
		private void EMKLCPGKNJL()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void GOLGOEGIFJI(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x003BF260 File Offset: 0x003BD460
		public void MFALIDFFLMO(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1424f, -vector2.y * 732f, 306f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1674f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x003BF388 File Offset: 0x003BD588
		public void ECNCCNNMIMA(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1059f, -vector2.y * 182f, 1125f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 611f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x003BF4B0 File Offset: 0x003BD6B0
		public void IJJAAOOBFEE(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 861f, -vector2.y * 631f, 816f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 519f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void HPHCCCHINOM(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x003BF5D8 File Offset: 0x003BD7D8
		public void GPKEENADAFC(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1069f, -vector2.y * 1206f, 202f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1031f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void DCEJNNDPBIP(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x003BCF16 File Offset: 0x003BB116
		public void OKKFLHPDLME(PointerEventData NOJGGCLPPAM)
		{
			this.KPEGABCNLKE.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.KFGABIOHJCD);
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x003BF700 File Offset: 0x003BD900
		private void HBPLJMJAAHK()
		{
			this.KPEGABCNLKE = base.transform.parent.GetComponent<RectTransform>();
			this.MOBAEJAEGFA = base.transform.parent;
			this.FOGEPIGABFP = base.GetComponent<RectTransform>();
			this.CGOLEAOMNNF = this.FOGEPIGABFP.sizeDelta;
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x003BF754 File Offset: 0x003BD954
		public void IBFHMKJOEGP(PointerEventData NOJGGCLPPAM)
		{
			if (this.KPEGABCNLKE == null)
			{
				return;
			}
			Vector3 vector = this.MOBAEJAEGFA.localScale;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.KPEGABCNLKE, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.BIAFELAGCHD);
			Vector2 vector2 = this.BIAFELAGCHD - this.KFGABIOHJCD;
			vector += new Vector3(-vector2.y * 1081f, -vector2.y * 979f, 401f);
			vector = new Vector3(Mathf.Clamp(vector.x, this.minSize.x, this.maxSize.x), Mathf.Clamp(vector.y, this.minSize.y, this.maxSize.y), 1926f);
			this.MOBAEJAEGFA.localScale = vector;
			this.KFGABIOHJCD = this.BIAFELAGCHD;
			float num = this.CGOLEAOMNNF.x / this.MOBAEJAEGFA.localScale.x;
			Vector2 sizeDelta = new Vector2(num, num);
			this.FOGEPIGABFP.sizeDelta = sizeDelta;
		}

		// Token: 0x04001239 RID: 4665
		public Vector2 minSize;

		// Token: 0x0400123A RID: 4666
		public Vector2 maxSize;

		// Token: 0x0400123B RID: 4667
		private RectTransform KPEGABCNLKE;

		// Token: 0x0400123C RID: 4668
		private Transform MOBAEJAEGFA;

		// Token: 0x0400123D RID: 4669
		private Vector2 BIAFELAGCHD;

		// Token: 0x0400123E RID: 4670
		private Vector2 KFGABIOHJCD;

		// Token: 0x0400123F RID: 4671
		private RectTransform FOGEPIGABFP;

		// Token: 0x04001240 RID: 4672
		private Vector2 CGOLEAOMNNF;
	}
}
