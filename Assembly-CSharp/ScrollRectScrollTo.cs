using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000462 RID: 1122
public class ScrollRectScrollTo : MonoBehaviour
{
	// Token: 0x06010067 RID: 65639 RVA: 0x0057E060 File Offset: 0x0057C260
	private void Start()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010068 RID: 65640 RVA: 0x0057E060 File Offset: 0x0057C260
	private void CNGAJDBOCLJ()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010069 RID: 65641 RVA: 0x0057E060 File Offset: 0x0057C260
	private void FNCDAPDOBBI()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601006A RID: 65642 RVA: 0x0057E07C File Offset: 0x0057C27C
	public void BPMINJEPFAG(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1383f;
			num = Mathf.Clamp01(533f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601006B RID: 65643 RVA: 0x0057E108 File Offset: 0x0057C308
	public void CenterToItem(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1000f;
			num = Mathf.Clamp01(1f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601006D RID: 65645 RVA: 0x0057E1AC File Offset: 0x0057C3AC
	public void LJCKIIOGAHE(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1675f;
			num = Mathf.Clamp01(805f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601006E RID: 65646 RVA: 0x0057E238 File Offset: 0x0057C438
	public void GILCJJFNAAC(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1789f;
			num = Mathf.Clamp01(1331f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601006F RID: 65647 RVA: 0x0057E060 File Offset: 0x0057C260
	private void KIMMMCJFMAB()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010070 RID: 65648 RVA: 0x0057E2C4 File Offset: 0x0057C4C4
	public void PLBDOPJMILO(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1917f;
			num = Mathf.Clamp01(1089f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010071 RID: 65649 RVA: 0x0057E060 File Offset: 0x0057C260
	private void MMMDPANNAIO()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010072 RID: 65650 RVA: 0x0057E350 File Offset: 0x0057C550
	public void EKIIODMENGB(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1780f;
			num = Mathf.Clamp01(1095f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010073 RID: 65651 RVA: 0x0057E3DC File Offset: 0x0057C5DC
	public void DCEGNNGODJJ(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 783f;
			num = Mathf.Clamp01(1485f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010074 RID: 65652 RVA: 0x0057E468 File Offset: 0x0057C668
	public void LEPMLPHIMGO(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 461f;
			num = Mathf.Clamp01(962f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010075 RID: 65653 RVA: 0x0057E4F4 File Offset: 0x0057C6F4
	public void JJNMFAIPKHB(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 950f;
			num = Mathf.Clamp01(1969f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010076 RID: 65654 RVA: 0x0057E060 File Offset: 0x0057C260
	private void KDMANOEMOCA()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010077 RID: 65655 RVA: 0x0057E060 File Offset: 0x0057C260
	private void JILOMOBDPIA()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010078 RID: 65656 RVA: 0x0057E060 File Offset: 0x0057C260
	private void AGEJKLMJGDO()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010079 RID: 65657 RVA: 0x0057E580 File Offset: 0x0057C780
	public void KDLLEPAJCDJ(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 597f;
			num = Mathf.Clamp01(1304f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601007A RID: 65658 RVA: 0x0057E60C File Offset: 0x0057C80C
	public void HPNKGEEGIIJ(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 498f;
			num = Mathf.Clamp01(743f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601007B RID: 65659 RVA: 0x0057E060 File Offset: 0x0057C260
	private void BMOFEBKGLFI()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601007C RID: 65660 RVA: 0x0057E060 File Offset: 0x0057C260
	private void NBGIMIDICKE()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601007D RID: 65661 RVA: 0x0057E060 File Offset: 0x0057C260
	private void JOPCCCCHNLI()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601007E RID: 65662 RVA: 0x0057E698 File Offset: 0x0057C898
	public void IBGDCPNPJKL(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 840f;
			num = Mathf.Clamp01(564f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601007F RID: 65663 RVA: 0x0057E724 File Offset: 0x0057C924
	public void DANDNIMLNAD(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 964f;
			num = Mathf.Clamp01(98f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010080 RID: 65664 RVA: 0x0057E060 File Offset: 0x0057C260
	private void EGEPLFGKGLI()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010081 RID: 65665 RVA: 0x0057E060 File Offset: 0x0057C260
	private void BEBNOKFLJPH()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010082 RID: 65666 RVA: 0x0057E7B0 File Offset: 0x0057C9B0
	public void IEPIGCMFFPN(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1365f;
			num = Mathf.Clamp01(610f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010083 RID: 65667 RVA: 0x0057E060 File Offset: 0x0057C260
	private void GPNAOAKCMHC()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010084 RID: 65668 RVA: 0x0057E060 File Offset: 0x0057C260
	private void IHLMNAGPKDA()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010085 RID: 65669 RVA: 0x0057E83C File Offset: 0x0057CA3C
	public void NHANEGCEPIA(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 943f;
			num = Mathf.Clamp01(862f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010086 RID: 65670 RVA: 0x0057E8C8 File Offset: 0x0057CAC8
	public void HMMBDGIHLKG(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 818f;
			num = Mathf.Clamp01(1483f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010087 RID: 65671 RVA: 0x0057E954 File Offset: 0x0057CB54
	public void HJPEGPMBCBO(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1373f;
			num = Mathf.Clamp01(293f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010088 RID: 65672 RVA: 0x0057E060 File Offset: 0x0057C260
	private void DLBODOFAJGM()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010089 RID: 65673 RVA: 0x0057E060 File Offset: 0x0057C260
	private void NPLCENPNJBM()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601008A RID: 65674 RVA: 0x0057E060 File Offset: 0x0057C260
	private void FIKFJDFELIP()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601008B RID: 65675 RVA: 0x0057E060 File Offset: 0x0057C260
	private void DAHFFNNIGML()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601008C RID: 65676 RVA: 0x0057E060 File Offset: 0x0057C260
	private void CIPKEPDELJB()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601008D RID: 65677 RVA: 0x0057E060 File Offset: 0x0057C260
	private void DKOPKPBLDHH()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x0601008E RID: 65678 RVA: 0x0057E9E0 File Offset: 0x0057CBE0
	public void DNBIFFDDNBE(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 758f;
			num = Mathf.Clamp01(1621f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x0601008F RID: 65679 RVA: 0x0057E060 File Offset: 0x0057C260
	private void FEHCNJLLJMP()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010090 RID: 65680 RVA: 0x0057EA6C File Offset: 0x0057CC6C
	public void JDODEBDCHJE(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 1849f;
			num = Mathf.Clamp01(736f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010091 RID: 65681 RVA: 0x0057EAF8 File Offset: 0x0057CCF8
	public void AMAAHANIDMC(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 858f;
			num = Mathf.Clamp01(1595f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010092 RID: 65682 RVA: 0x0057EB84 File Offset: 0x0057CD84
	public void DGJAFOELLHC(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 99f;
			num = Mathf.Clamp01(1764f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010093 RID: 65683 RVA: 0x0057EC10 File Offset: 0x0057CE10
	public void PPKFMKGKMDK(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 941f;
			num = Mathf.Clamp01(40f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010094 RID: 65684 RVA: 0x0057E060 File Offset: 0x0057C260
	private void JKFDDNMPOJH()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010095 RID: 65685 RVA: 0x0057EC9C File Offset: 0x0057CE9C
	public void DGLFHKJCGEH(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 593f;
			num = Mathf.Clamp01(706f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010096 RID: 65686 RVA: 0x0057E060 File Offset: 0x0057C260
	private void NNCCPEBIAKH()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010097 RID: 65687 RVA: 0x0057E060 File Offset: 0x0057C260
	private void MKIMDFLBFOM()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x06010098 RID: 65688 RVA: 0x0057ED28 File Offset: 0x0057CF28
	public void ACMDNLHGCOL(RectTransform AGPIGANJKMN)
	{
		if (this.isEnabled)
		{
			float num = this.DLFDBJCKOOD.anchorMin.y - AGPIGANJKMN.anchoredPosition.y - this.offset;
			num += (float)AGPIGANJKMN.transform.GetSiblingIndex() / (float)this.ELPCPHHOALB.content.transform.childCount;
			num /= 285f;
			num = Mathf.Clamp01(832f - num);
			this.ELPCPHHOALB.verticalNormalizedPosition = num;
		}
	}

	// Token: 0x06010099 RID: 65689 RVA: 0x0057E060 File Offset: 0x0057C260
	private void JMEOGJHCONJ()
	{
		this.ELPCPHHOALB = base.GetComponent<ScrollRect>();
		this.DLFDBJCKOOD = base.GetComponent<RectTransform>();
	}

	// Token: 0x04001C63 RID: 7267
	public bool isEnabled = true;

	// Token: 0x04001C64 RID: 7268
	private ScrollRect ELPCPHHOALB;

	// Token: 0x04001C65 RID: 7269
	private RectTransform DLFDBJCKOOD;

	// Token: 0x04001C66 RID: 7270
	public float offset = 200f;
}
