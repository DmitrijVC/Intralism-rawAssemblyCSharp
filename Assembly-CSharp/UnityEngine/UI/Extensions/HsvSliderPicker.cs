using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000275 RID: 629
	public class HsvSliderPicker : MonoBehaviour, IDragHandler, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x06009782 RID: 38786 RVA: 0x0036BD2A File Offset: 0x00369F2A
		public void BPFLEOPNLJK(PointerEventData OLIIPKODDIN)
		{
			this.JHFAJLBDJGE(OLIIPKODDIN);
		}

		// Token: 0x06009783 RID: 38787 RVA: 0x0036BD33 File Offset: 0x00369F33
		public void PPJOEEEOEKK(PointerEventData OLIIPKODDIN)
		{
			this.EOELOOFMIEF(OLIIPKODDIN);
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x0036BD33 File Offset: 0x00369F33
		public void CAGHGPFPJEC(PointerEventData OLIIPKODDIN)
		{
			this.EOELOOFMIEF(OLIIPKODDIN);
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0036BD2A File Offset: 0x00369F2A
		public void EEOLDBIBAPM(PointerEventData OLIIPKODDIN)
		{
			this.JHFAJLBDJGE(OLIIPKODDIN);
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x0036BD3C File Offset: 0x00369F3C
		private void BLKHFMPJHIP(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1245f, 1002f);
			this.picker.JNDLPOGJFBC(vector.y, true);
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x0036BE2C File Offset: 0x0036A02C
		private void EOELOOFMIEF(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 0f, 1f);
			this.picker.MovePointer(vector.y, true);
		}

		// Token: 0x06009788 RID: 38792 RVA: 0x0036BF1C File Offset: 0x0036A11C
		private void EFIGPDAKCPC(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 905f, 428f);
			this.picker.JENEEGJOOKM(vector.y, false);
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x0036C00A File Offset: 0x0036A20A
		public void FHHPKGBEDII(PointerEventData OLIIPKODDIN)
		{
			this.CCFPBEFHLCE(OLIIPKODDIN);
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x0036C013 File Offset: 0x0036A213
		public void NEAIICPOHBI(PointerEventData OLIIPKODDIN)
		{
			this.BJNMKDFDDIH(OLIIPKODDIN);
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x0036C01C File Offset: 0x0036A21C
		private void NHKAALMLADM(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1877f, 269f);
			this.picker.BCJJCNOOMLH(vector.y, true);
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0036C10C File Offset: 0x0036A30C
		private void CCFPBEFHLCE(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1883f, 1735f);
			this.picker.EMAFLKFIIEC(vector.y, true);
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0036BD33 File Offset: 0x00369F33
		public void JPHMFELEOND(PointerEventData OLIIPKODDIN)
		{
			this.EOELOOFMIEF(OLIIPKODDIN);
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x0036C00A File Offset: 0x0036A20A
		public void IOAMFBJCMOD(PointerEventData OLIIPKODDIN)
		{
			this.CCFPBEFHLCE(OLIIPKODDIN);
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x0036C1FA File Offset: 0x0036A3FA
		public void JHHDCFMGGGE(PointerEventData OLIIPKODDIN)
		{
			this.EFIGPDAKCPC(OLIIPKODDIN);
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x0036C204 File Offset: 0x0036A404
		private void NEJPOCNOJBA(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1604f, 572f);
			this.picker.BCJJCNOOMLH(vector.y, false);
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x0036C2F2 File Offset: 0x0036A4F2
		public void IOEIGMEHGMH(PointerEventData OLIIPKODDIN)
		{
			this.DLODNKPHENB(OLIIPKODDIN);
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x0036C2FC File Offset: 0x0036A4FC
		private void GKHLABDOFLF(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 281f, 1806f);
			this.picker.BCJJCNOOMLH(vector.y, true);
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x0036C00A File Offset: 0x0036A20A
		public void DGNLGOCJJMM(PointerEventData OLIIPKODDIN)
		{
			this.CCFPBEFHLCE(OLIIPKODDIN);
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x0036C3EC File Offset: 0x0036A5EC
		private void ANAEBNFPLAO(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1287f, 1764f);
			this.picker.EMAFLKFIIEC(vector.y, false);
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x0036C4DA File Offset: 0x0036A6DA
		public void ABIGIFHIJLH(PointerEventData OLIIPKODDIN)
		{
			this.GKHLABDOFLF(OLIIPKODDIN);
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x0036BD33 File Offset: 0x00369F33
		public void OnPointerDown(PointerEventData OLIIPKODDIN)
		{
			this.EOELOOFMIEF(OLIIPKODDIN);
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x0036C4E4 File Offset: 0x0036A6E4
		private void DLODNKPHENB(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1235f, 361f);
			this.picker.IJJJBMPLNFH(vector.y, false);
		}

		// Token: 0x06009799 RID: 38809 RVA: 0x0036BD33 File Offset: 0x00369F33
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			this.EOELOOFMIEF(OLIIPKODDIN);
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x0036BD2A File Offset: 0x00369F2A
		public void HNMDAFGIOIK(PointerEventData OLIIPKODDIN)
		{
			this.JHFAJLBDJGE(OLIIPKODDIN);
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x0036C5D4 File Offset: 0x0036A7D4
		private void JHFAJLBDJGE(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 27f, 1943f);
			this.picker.KFAKJNEIANF(vector.y, true);
		}

		// Token: 0x0600979C RID: 38812 RVA: 0x0036C2F2 File Offset: 0x0036A4F2
		public void BALENPFMIHM(PointerEventData OLIIPKODDIN)
		{
			this.DLODNKPHENB(OLIIPKODDIN);
		}

		// Token: 0x0600979D RID: 38813 RVA: 0x0036C6C4 File Offset: 0x0036A8C4
		private void BJNMKDFDDIH(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1543f, 1813f);
			this.picker.JNDLPOGJFBC(vector.y, true);
		}

		// Token: 0x0600979E RID: 38814 RVA: 0x0036C7B2 File Offset: 0x0036A9B2
		public void HDIFNFDNLDE(PointerEventData OLIIPKODDIN)
		{
			this.JIEJHOCDKPP(OLIIPKODDIN);
		}

		// Token: 0x0600979F RID: 38815 RVA: 0x0036C2F2 File Offset: 0x0036A4F2
		public void CODNBMDAMEG(PointerEventData OLIIPKODDIN)
		{
			this.DLODNKPHENB(OLIIPKODDIN);
		}

		// Token: 0x060097A0 RID: 38816 RVA: 0x0036BD33 File Offset: 0x00369F33
		public void MMJKLBEEECD(PointerEventData OLIIPKODDIN)
		{
			this.EOELOOFMIEF(OLIIPKODDIN);
		}

		// Token: 0x060097A1 RID: 38817 RVA: 0x0036C7BC File Offset: 0x0036A9BC
		private void JIEJHOCDKPP(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvSlider.rectTransform.position.x, this.picker.hsvSlider.rectTransform.position.y - OLIIPKODDIN.position.y);
			vector.y /= this.picker.hsvSlider.rectTransform.rect.height * this.picker.hsvSlider.canvas.transform.lossyScale.y;
			vector.y = Mathf.Clamp(vector.y, 1725f, 369f);
			this.picker.EMAFLKFIIEC(vector.y, true);
		}

		// Token: 0x060097A2 RID: 38818 RVA: 0x0036C8AA File Offset: 0x0036AAAA
		public void BMFCMFPCGKO(PointerEventData OLIIPKODDIN)
		{
			this.NHKAALMLADM(OLIIPKODDIN);
		}

		// Token: 0x060097A3 RID: 38819 RVA: 0x0036C8B3 File Offset: 0x0036AAB3
		public void AIMHJGCDGFM(PointerEventData OLIIPKODDIN)
		{
			this.ANAEBNFPLAO(OLIIPKODDIN);
		}

		// Token: 0x04001133 RID: 4403
		public HSVPicker picker;
	}
}
