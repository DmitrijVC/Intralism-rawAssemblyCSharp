using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000298 RID: 664
	[AddComponentMenu("UI/Extensions/RescalePanels/RescaleDragPanel")]
	public class RescaleDragPanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x06009FBF RID: 40895 RVA: 0x003BC184 File Offset: 0x003BA384
		public void NDPOELJLHOF(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHPCAECMOFA == null)
			{
				return;
			}
			Vector2 screenPoint = this.AMDHEFCOHJM(NOJGGCLPPAM);
			Vector2 a;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.CJGCOMJMLEN, screenPoint, NOJGGCLPPAM.pressEventCamera, out a))
			{
				this.DHPCAECMOFA.localPosition = a - new Vector2(this.NANAFMLLAKE.x * this.MOBAEJAEGFA.localScale.x, this.NANAFMLLAKE.y * this.MOBAEJAEGFA.localScale.y);
			}
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x003BC220 File Offset: 0x003BA420
		public void BPFLEOPNLJK(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHPCAECMOFA == null)
			{
				return;
			}
			Vector2 screenPoint = this.PHJPOMPEGJK(NOJGGCLPPAM);
			Vector2 a;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.CJGCOMJMLEN, screenPoint, NOJGGCLPPAM.pressEventCamera, out a))
			{
				this.DHPCAECMOFA.localPosition = a - new Vector2(this.NANAFMLLAKE.x * this.MOBAEJAEGFA.localScale.x, this.NANAFMLLAKE.y * this.MOBAEJAEGFA.localScale.y);
			}
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x003BC2BC File Offset: 0x003BA4BC
		private void EIFCCFBJKOO()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			if (componentInParent != null)
			{
				this.CJGCOMJMLEN = (componentInParent.transform as RectTransform);
				this.DHPCAECMOFA = (base.transform.parent as RectTransform);
				this.MOBAEJAEGFA = base.transform.parent;
			}
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x003BC314 File Offset: 0x003BA514
		private Vector2 FDFFEAEBDFN(PointerEventData NOJGGCLPPAM)
		{
			Vector2 position = NOJGGCLPPAM.position;
			Vector3[] array = new Vector3[1];
			this.CJGCOMJMLEN.GetWorldCorners(array);
			float x = Mathf.Clamp(position.x, array[0].x, array[7].x);
			float y = Mathf.Clamp(position.y, array[0].y, array[1].y);
			Vector2 result = new Vector2(x, y);
			return result;
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x003BC390 File Offset: 0x003BA590
		public void OnPointerDown(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x003BC3BC File Offset: 0x003BA5BC
		private void FAAJAMIGJNK()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			if (componentInParent != null)
			{
				this.CJGCOMJMLEN = (componentInParent.transform as RectTransform);
				this.DHPCAECMOFA = (base.transform.parent as RectTransform);
				this.MOBAEJAEGFA = base.transform.parent;
			}
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x003BC390 File Offset: 0x003BA590
		public void NHIHJBBINKP(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FC6 RID: 40902 RVA: 0x003BC390 File Offset: 0x003BA590
		public void LIPHKAAMJJA(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x003BC414 File Offset: 0x003BA614
		private Vector2 PHJPOMPEGJK(PointerEventData NOJGGCLPPAM)
		{
			Vector2 position = NOJGGCLPPAM.position;
			Vector3[] array = new Vector3[4];
			this.CJGCOMJMLEN.GetWorldCorners(array);
			float x = Mathf.Clamp(position.x, array[1].x, array[6].x);
			float y = Mathf.Clamp(position.y, array[0].y, array[3].y);
			Vector2 result = new Vector2(x, y);
			return result;
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x003BC390 File Offset: 0x003BA590
		public void AFJJAOHEEGG(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x003BC490 File Offset: 0x003BA690
		private Vector2 IKMPBFEKBNC(PointerEventData NOJGGCLPPAM)
		{
			Vector2 position = NOJGGCLPPAM.position;
			Vector3[] array = new Vector3[4];
			this.CJGCOMJMLEN.GetWorldCorners(array);
			float x = Mathf.Clamp(position.x, array[0].x, array[2].x);
			float y = Mathf.Clamp(position.y, array[0].y, array[2].y);
			Vector2 result = new Vector2(x, y);
			return result;
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x003BC50C File Offset: 0x003BA70C
		private Vector2 LKGMILFKJFG(PointerEventData NOJGGCLPPAM)
		{
			Vector2 position = NOJGGCLPPAM.position;
			Vector3[] array = new Vector3[1];
			this.CJGCOMJMLEN.GetWorldCorners(array);
			float x = Mathf.Clamp(position.x, array[0].x, array[7].x);
			float y = Mathf.Clamp(position.y, array[0].y, array[8].y);
			Vector2 result = new Vector2(x, y);
			return result;
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x003BC588 File Offset: 0x003BA788
		private void BODPLDJLFCF()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			if (componentInParent != null)
			{
				this.CJGCOMJMLEN = (componentInParent.transform as RectTransform);
				this.DHPCAECMOFA = (base.transform.parent as RectTransform);
				this.MOBAEJAEGFA = base.transform.parent;
			}
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x003BC390 File Offset: 0x003BA590
		public void JLKANOMNOKO(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x003BC390 File Offset: 0x003BA590
		public void BMFCMFPCGKO(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x003BC5E0 File Offset: 0x003BA7E0
		private void MMPOJCFOGJJ()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			if (componentInParent != null)
			{
				this.CJGCOMJMLEN = (componentInParent.transform as RectTransform);
				this.DHPCAECMOFA = (base.transform.parent as RectTransform);
				this.MOBAEJAEGFA = base.transform.parent;
			}
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x003BC638 File Offset: 0x003BA838
		public void OnDrag(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHPCAECMOFA == null)
			{
				return;
			}
			Vector2 screenPoint = this.IKMPBFEKBNC(NOJGGCLPPAM);
			Vector2 a;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.CJGCOMJMLEN, screenPoint, NOJGGCLPPAM.pressEventCamera, out a))
			{
				this.DHPCAECMOFA.localPosition = a - new Vector2(this.NANAFMLLAKE.x * this.MOBAEJAEGFA.localScale.x, this.NANAFMLLAKE.y * this.MOBAEJAEGFA.localScale.y);
			}
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x003BC6D4 File Offset: 0x003BA8D4
		public void AIMHJGCDGFM(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHPCAECMOFA == null)
			{
				return;
			}
			Vector2 screenPoint = this.IKMPBFEKBNC(NOJGGCLPPAM);
			Vector2 a;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.CJGCOMJMLEN, screenPoint, NOJGGCLPPAM.pressEventCamera, out a))
			{
				this.DHPCAECMOFA.localPosition = a - new Vector2(this.NANAFMLLAKE.x * this.MOBAEJAEGFA.localScale.x, this.NANAFMLLAKE.y * this.MOBAEJAEGFA.localScale.y);
			}
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x003BC390 File Offset: 0x003BA590
		public void EODLMNHDCPI(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FD3 RID: 40915 RVA: 0x003BC770 File Offset: 0x003BA970
		private Vector2 AMDHEFCOHJM(PointerEventData NOJGGCLPPAM)
		{
			Vector2 position = NOJGGCLPPAM.position;
			Vector3[] array = new Vector3[7];
			this.CJGCOMJMLEN.GetWorldCorners(array);
			float x = Mathf.Clamp(position.x, array[1].x, array[5].x);
			float y = Mathf.Clamp(position.y, array[1].y, array[4].y);
			Vector2 result = new Vector2(x, y);
			return result;
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x003BC390 File Offset: 0x003BA590
		public void JCKHOLLCLEJ(PointerEventData NOJGGCLPPAM)
		{
			this.DHPCAECMOFA.SetAsLastSibling();
			RectTransformUtility.ScreenPointToLocalPointInRectangle(this.DHPCAECMOFA, NOJGGCLPPAM.position, NOJGGCLPPAM.pressEventCamera, out this.NANAFMLLAKE);
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x003BC7EC File Offset: 0x003BA9EC
		public void AJKNFEEHAFH(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHPCAECMOFA == null)
			{
				return;
			}
			Vector2 screenPoint = this.KADMFADEBJN(NOJGGCLPPAM);
			Vector2 a;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.CJGCOMJMLEN, screenPoint, NOJGGCLPPAM.pressEventCamera, out a))
			{
				this.DHPCAECMOFA.localPosition = a - new Vector2(this.NANAFMLLAKE.x * this.MOBAEJAEGFA.localScale.x, this.NANAFMLLAKE.y * this.MOBAEJAEGFA.localScale.y);
			}
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x003BC888 File Offset: 0x003BAA88
		private void Awake()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			if (componentInParent != null)
			{
				this.CJGCOMJMLEN = (componentInParent.transform as RectTransform);
				this.DHPCAECMOFA = (base.transform.parent as RectTransform);
				this.MOBAEJAEGFA = base.transform.parent;
			}
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x003BC8E0 File Offset: 0x003BAAE0
		private Vector2 KADMFADEBJN(PointerEventData NOJGGCLPPAM)
		{
			Vector2 position = NOJGGCLPPAM.position;
			Vector3[] array = new Vector3[8];
			this.CJGCOMJMLEN.GetWorldCorners(array);
			float x = Mathf.Clamp(position.x, array[0].x, array[0].x);
			float y = Mathf.Clamp(position.y, array[1].y, array[5].y);
			Vector2 result = new Vector2(x, y);
			return result;
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x003BC95C File Offset: 0x003BAB5C
		public void DEEJBOILMCC(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHPCAECMOFA == null)
			{
				return;
			}
			Vector2 screenPoint = this.PHJPOMPEGJK(NOJGGCLPPAM);
			Vector2 a;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(this.CJGCOMJMLEN, screenPoint, NOJGGCLPPAM.pressEventCamera, out a))
			{
				this.DHPCAECMOFA.localPosition = a - new Vector2(this.NANAFMLLAKE.x * this.MOBAEJAEGFA.localScale.x, this.NANAFMLLAKE.y * this.MOBAEJAEGFA.localScale.y);
			}
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x003BC9F8 File Offset: 0x003BABF8
		private void GEGFJJBCHPE()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			if (componentInParent != null)
			{
				this.CJGCOMJMLEN = (componentInParent.transform as RectTransform);
				this.DHPCAECMOFA = (base.transform.parent as RectTransform);
				this.MOBAEJAEGFA = base.transform.parent;
			}
		}

		// Token: 0x04001235 RID: 4661
		private Vector2 NANAFMLLAKE;

		// Token: 0x04001236 RID: 4662
		private RectTransform CJGCOMJMLEN;

		// Token: 0x04001237 RID: 4663
		private RectTransform DHPCAECMOFA;

		// Token: 0x04001238 RID: 4664
		private Transform MOBAEJAEGFA;
	}
}
