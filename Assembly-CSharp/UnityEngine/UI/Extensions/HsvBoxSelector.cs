using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000272 RID: 626
	public class HsvBoxSelector : MonoBehaviour, IDragHandler, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x060096B4 RID: 38580 RVA: 0x003641E5 File Offset: 0x003623E5
		public void LIBHPLGPFBL(PointerEventData OLIIPKODDIN)
		{
			this.KKGFKKACPPD(OLIIPKODDIN);
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x003641F0 File Offset: 0x003623F0
		private void POBDFDMPEFB(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 1321f, 808f);
			vector.y = Mathf.Clamp(vector.y, 1884f, 1118f);
			this.picker.MoveCursor(vector.x, vector.y, false);
		}

		// Token: 0x060096B6 RID: 38582 RVA: 0x003641E5 File Offset: 0x003623E5
		public void BJCLJELPAHI(PointerEventData OLIIPKODDIN)
		{
			this.KKGFKKACPPD(OLIIPKODDIN);
		}

		// Token: 0x060096B7 RID: 38583 RVA: 0x00364388 File Offset: 0x00362588
		private void OGCFALCBPOB(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 1527f, 1403f);
			vector.y = Mathf.Clamp(vector.y, 438f, 850f);
			this.picker.MHBKFACADJG(vector.x, vector.y, true);
		}

		// Token: 0x060096B8 RID: 38584 RVA: 0x0036451E File Offset: 0x0036271E
		public void NAFLLKBCDKM(PointerEventData OLIIPKODDIN)
		{
			this.MDAFLJOFLNK(OLIIPKODDIN);
		}

		// Token: 0x060096B9 RID: 38585 RVA: 0x00364527 File Offset: 0x00362727
		public void NEAIICPOHBI(PointerEventData OLIIPKODDIN)
		{
			this.LAAKOILFCFE(OLIIPKODDIN);
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x00364530 File Offset: 0x00362730
		public void EGFNFFPBIMD(PointerEventData OLIIPKODDIN)
		{
			this.OGCFALCBPOB(OLIIPKODDIN);
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x0036453C File Offset: 0x0036273C
		private void ICIHJHOMNDE(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 653f, 772f);
			vector.y = Mathf.Clamp(vector.y, 247f, 1121f);
			this.picker.MCEAEBCFKFK(vector.x, vector.y, false);
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x003646D2 File Offset: 0x003628D2
		public void JLMIGIMEIDA(PointerEventData OLIIPKODDIN)
		{
			this.MILCLILPEOH(OLIIPKODDIN);
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x003646DC File Offset: 0x003628DC
		private void JDFNJAAECAM(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 216f, 1751f);
			vector.y = Mathf.Clamp(vector.y, 466f, 1237f);
			this.picker.MoveCursor(vector.x, vector.y, false);
		}

		// Token: 0x060096BE RID: 38590 RVA: 0x00364872 File Offset: 0x00362A72
		public void DCDNJADEHFA(PointerEventData OLIIPKODDIN)
		{
			this.BKJBEBFGILP(OLIIPKODDIN);
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x0036487C File Offset: 0x00362A7C
		private void BACAMPIBLKO(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 1825f, 493f);
			vector.y = Mathf.Clamp(vector.y, 1418f, 1913f);
			this.picker.ACKLOKNCIBK(vector.x, vector.y, false);
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x00364A14 File Offset: 0x00362C14
		private void KKGFKKACPPD(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 1850f, 1250f);
			vector.y = Mathf.Clamp(vector.y, 221f, 959f);
			this.picker.CONMOICMDPN(vector.x, vector.y, false);
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x00364BAA File Offset: 0x00362DAA
		public void PDLHNIDNPMP(PointerEventData OLIIPKODDIN)
		{
			this.CNJDJLKEJOP(OLIIPKODDIN);
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x00364530 File Offset: 0x00362730
		public void AIMHJGCDGFM(PointerEventData OLIIPKODDIN)
		{
			this.OGCFALCBPOB(OLIIPKODDIN);
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x00364BB4 File Offset: 0x00362DB4
		private void LAAKOILFCFE(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 41f, 1248f);
			vector.y = Mathf.Clamp(vector.y, 1672f, 1603f);
			this.picker.BFHJCALADND(vector.x, vector.y, false);
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x00364D4C File Offset: 0x00362F4C
		private void PLHELAGOGEN(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 1155f, 1202f);
			vector.y = Mathf.Clamp(vector.y, 1651f, 1875f);
			this.picker.JBNPKHEFCFB(vector.x, vector.y, true);
		}

		// Token: 0x060096C5 RID: 38597 RVA: 0x00364EE4 File Offset: 0x003630E4
		private void MILCLILPEOH(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 191f, 1728f);
			vector.y = Mathf.Clamp(vector.y, 1244f, 982f);
			this.picker.JBNPKHEFCFB(vector.x, vector.y, false);
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x0036507C File Offset: 0x0036327C
		private void CNJDJLKEJOP(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 782f, 910f);
			vector.y = Mathf.Clamp(vector.y, 1669f, 933f);
			this.picker.CONMOICMDPN(vector.x, vector.y, false);
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x00365212 File Offset: 0x00363412
		public void KDOLJDKOBML(PointerEventData OLIIPKODDIN)
		{
			this.BACAMPIBLKO(OLIIPKODDIN);
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x0036521B File Offset: 0x0036341B
		public void NDPOELJLHOF(PointerEventData OLIIPKODDIN)
		{
			this.POBDFDMPEFB(OLIIPKODDIN);
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x00364872 File Offset: 0x00362A72
		public void MPAOHHKECIK(PointerEventData OLIIPKODDIN)
		{
			this.BKJBEBFGILP(OLIIPKODDIN);
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x00365224 File Offset: 0x00363424
		public void HNMDAFGIOIK(PointerEventData OLIIPKODDIN)
		{
			this.JDFNJAAECAM(OLIIPKODDIN);
		}

		// Token: 0x060096CB RID: 38603 RVA: 0x003641E5 File Offset: 0x003623E5
		public void PKJMOHDCHNA(PointerEventData OLIIPKODDIN)
		{
			this.KKGFKKACPPD(OLIIPKODDIN);
		}

		// Token: 0x060096CC RID: 38604 RVA: 0x00365230 File Offset: 0x00363430
		private void FMAOKENDKPK(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 1755f, 309f);
			vector.y = Mathf.Clamp(vector.y, 1011f, 1696f);
			this.picker.MCEAEBCFKFK(vector.x, vector.y, true);
		}

		// Token: 0x060096CD RID: 38605 RVA: 0x003653C6 File Offset: 0x003635C6
		public void OnPointerDown(PointerEventData OLIIPKODDIN)
		{
			this.PICCKOHMLFJ(OLIIPKODDIN);
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x003641E5 File Offset: 0x003623E5
		public void PACJHDDENEJ(PointerEventData OLIIPKODDIN)
		{
			this.KKGFKKACPPD(OLIIPKODDIN);
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x003653CF File Offset: 0x003635CF
		public void MNGLBBFLPFE(PointerEventData OLIIPKODDIN)
		{
			this.FMAOKENDKPK(OLIIPKODDIN);
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x003653D8 File Offset: 0x003635D8
		private void BKJBEBFGILP(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 60f, 657f);
			vector.y = Mathf.Clamp(vector.y, 724f, 724f);
			this.picker.CLGFPIANGCA(vector.x, vector.y, true);
		}

		// Token: 0x060096D1 RID: 38609 RVA: 0x00364BAA File Offset: 0x00362DAA
		public void BPFLEOPNLJK(PointerEventData OLIIPKODDIN)
		{
			this.CNJDJLKEJOP(OLIIPKODDIN);
		}

		// Token: 0x060096D2 RID: 38610 RVA: 0x00364872 File Offset: 0x00362A72
		public void JHHDCFMGGGE(PointerEventData OLIIPKODDIN)
		{
			this.BKJBEBFGILP(OLIIPKODDIN);
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x0036556E File Offset: 0x0036376E
		public void NHIHJBBINKP(PointerEventData OLIIPKODDIN)
		{
			this.PLHELAGOGEN(OLIIPKODDIN);
		}

		// Token: 0x060096D4 RID: 38612 RVA: 0x003653C6 File Offset: 0x003635C6
		public void HPHCCCHINOM(PointerEventData OLIIPKODDIN)
		{
			this.PICCKOHMLFJ(OLIIPKODDIN);
		}

		// Token: 0x060096D5 RID: 38613 RVA: 0x00365212 File Offset: 0x00363412
		public void DDDEDHPLFDM(PointerEventData OLIIPKODDIN)
		{
			this.BACAMPIBLKO(OLIIPKODDIN);
		}

		// Token: 0x060096D6 RID: 38614 RVA: 0x00365578 File Offset: 0x00363778
		private void PICCKOHMLFJ(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 0f, 0.9999f);
			vector.y = Mathf.Clamp(vector.y, 0f, 0.9999f);
			this.picker.MoveCursor(vector.x, vector.y, true);
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x0036570E File Offset: 0x0036390E
		public void OKKFLHPDLME(PointerEventData OLIIPKODDIN)
		{
			this.ICIHJHOMNDE(OLIIPKODDIN);
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x0036451E File Offset: 0x0036271E
		public void KOGFFLNAJGB(PointerEventData OLIIPKODDIN)
		{
			this.MDAFLJOFLNK(OLIIPKODDIN);
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x0036570E File Offset: 0x0036390E
		public void NODMNIIGNBI(PointerEventData OLIIPKODDIN)
		{
			this.ICIHJHOMNDE(OLIIPKODDIN);
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x00364530 File Offset: 0x00362730
		public void IOAMFBJCMOD(PointerEventData OLIIPKODDIN)
		{
			this.OGCFALCBPOB(OLIIPKODDIN);
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x00365212 File Offset: 0x00363412
		public void HKLLKLNJPJE(PointerEventData OLIIPKODDIN)
		{
			this.BACAMPIBLKO(OLIIPKODDIN);
		}

		// Token: 0x060096DC RID: 38620 RVA: 0x003653C6 File Offset: 0x003635C6
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			this.PICCKOHMLFJ(OLIIPKODDIN);
		}

		// Token: 0x060096DD RID: 38621 RVA: 0x003641E5 File Offset: 0x003623E5
		public void LIPHKAAMJJA(PointerEventData OLIIPKODDIN)
		{
			this.KKGFKKACPPD(OLIIPKODDIN);
		}

		// Token: 0x060096DE RID: 38622 RVA: 0x0036521B File Offset: 0x0036341B
		public void GNBEFOEOIIK(PointerEventData OLIIPKODDIN)
		{
			this.POBDFDMPEFB(OLIIPKODDIN);
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x00365718 File Offset: 0x00363918
		private void MDAFLJOFLNK(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 764f, 867f);
			vector.y = Mathf.Clamp(vector.y, 635f, 601f);
			this.picker.JBNPKHEFCFB(vector.x, vector.y, true);
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x0036570E File Offset: 0x0036390E
		public void EEOLDBIBAPM(PointerEventData OLIIPKODDIN)
		{
			this.ICIHJHOMNDE(OLIIPKODDIN);
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x00365224 File Offset: 0x00363424
		public void CFIEFBKBAMJ(PointerEventData OLIIPKODDIN)
		{
			this.JDFNJAAECAM(OLIIPKODDIN);
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x0036570E File Offset: 0x0036390E
		public void PIPIDPPIJCF(PointerEventData OLIIPKODDIN)
		{
			this.ICIHJHOMNDE(OLIIPKODDIN);
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x003653CF File Offset: 0x003635CF
		public void HLFDGLFFBPC(PointerEventData OLIIPKODDIN)
		{
			this.FMAOKENDKPK(OLIIPKODDIN);
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x00364872 File Offset: 0x00362A72
		public void LPENBOCGNJK(PointerEventData OLIIPKODDIN)
		{
			this.BKJBEBFGILP(OLIIPKODDIN);
		}

		// Token: 0x060096E5 RID: 38629 RVA: 0x003658B0 File Offset: 0x00363AB0
		private void FPJBCIAPLIF(PointerEventData OLIIPKODDIN)
		{
			Vector2 vector = new Vector2(OLIIPKODDIN.position.x - this.picker.hsvImage.rectTransform.position.x, this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y - (this.picker.hsvImage.rectTransform.position.y - OLIIPKODDIN.position.y));
			vector.x /= this.picker.hsvImage.rectTransform.rect.width * this.picker.hsvImage.transform.lossyScale.x;
			vector.y /= this.picker.hsvImage.rectTransform.rect.height * this.picker.hsvImage.transform.lossyScale.y;
			vector.x = Mathf.Clamp(vector.x, 1130f, 1065f);
			vector.y = Mathf.Clamp(vector.y, 1533f, 1157f);
			this.picker.HOOJNFKDBAK(vector.x, vector.y, true);
		}

		// Token: 0x060096E7 RID: 38631 RVA: 0x00364530 File Offset: 0x00362730
		public void AGEGKOGHBGM(PointerEventData OLIIPKODDIN)
		{
			this.OGCFALCBPOB(OLIIPKODDIN);
		}

		// Token: 0x060096E8 RID: 38632 RVA: 0x0036521B File Offset: 0x0036341B
		public void NCKFHJJDHGC(PointerEventData OLIIPKODDIN)
		{
			this.POBDFDMPEFB(OLIIPKODDIN);
		}

		// Token: 0x060096E9 RID: 38633 RVA: 0x003653CF File Offset: 0x003635CF
		public void BDFBPMMDJKJ(PointerEventData OLIIPKODDIN)
		{
			this.FMAOKENDKPK(OLIIPKODDIN);
		}

		// Token: 0x04001120 RID: 4384
		public HSVPicker picker;
	}
}
