using System;
using DG.Tweening;
using UnityEngine;

// Token: 0x0200013E RID: 318
public class Sequences : MonoBehaviour
{
	// Token: 0x0600644C RID: 25676 RVA: 0x001E72EC File Offset: 0x001E54EC
	private void KCCIEMBMOBA()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1211f, 1329f, true));
		sequence.Join(this.target.DORotate(new Vector3(259f, 215f, 182f), 1569f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(498f, 1761f));
		sequence.Insert(476f, this.target.DOMoveX(1417f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(2, LoopType.Restart);
	}

	// Token: 0x0600644D RID: 25677 RVA: 0x001E7398 File Offset: 0x001E5598
	private void JILOMOBDPIA()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(396f, 1882f, false));
		sequence.Join(this.target.DORotate(new Vector3(503f, 172f, 1731f), 1159f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(671f, 1051f));
		sequence.Insert(34f, this.target.DOMoveX(1069f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Yoyo);
	}

	// Token: 0x0600644E RID: 25678 RVA: 0x001E7444 File Offset: 0x001E5644
	private void BGDPIHMAACO()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(799f, 757f, false));
		sequence.Join(this.target.DORotate(new Vector3(1741f, 163f, 1708f), 1705f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(30f, 817f));
		sequence.Insert(639f, this.target.DOMoveX(1359f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(6, LoopType.Restart);
	}

	// Token: 0x0600644F RID: 25679 RVA: 0x001E74F0 File Offset: 0x001E56F0
	private void Start()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(2f, 1f, false));
		sequence.Join(this.target.DORotate(new Vector3(0f, 135f, 0f), 1f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(0.2f, 1f));
		sequence.Insert(0f, this.target.DOMoveX(4f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(4, LoopType.Yoyo);
	}

	// Token: 0x06006450 RID: 25680 RVA: 0x001E759C File Offset: 0x001E579C
	private void CIPKEPDELJB()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1235f, 892f, true));
		sequence.Join(this.target.DORotate(new Vector3(126f, 181f, 1192f), 838f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(513f, 1493f));
		sequence.Insert(1336f, this.target.DOMoveX(1783f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Restart);
	}

	// Token: 0x06006451 RID: 25681 RVA: 0x001E7648 File Offset: 0x001E5848
	private void FHPFJBFCOOF()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(179f, 1844f, true));
		sequence.Join(this.target.DORotate(new Vector3(264f, 1723f, 1380f), 1844f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(912f, 1429f));
		sequence.Insert(1917f, this.target.DOMoveX(906f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Yoyo);
	}

	// Token: 0x06006452 RID: 25682 RVA: 0x001E76F4 File Offset: 0x001E58F4
	private void BMIOFJFMCBG()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(158f, 119f, false));
		sequence.Join(this.target.DORotate(new Vector3(1662f, 1248f, 1234f), 1128f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(146f, 1451f));
		sequence.Insert(1428f, this.target.DOMoveX(1375f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(2, LoopType.Restart);
	}

	// Token: 0x06006453 RID: 25683 RVA: 0x001E77A0 File Offset: 0x001E59A0
	private void KIMMMCJFMAB()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1884f, 1137f, false));
		sequence.Join(this.target.DORotate(new Vector3(1650f, 1674f, 813f), 777f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(169f, 1713f));
		sequence.Insert(1471f, this.target.DOMoveX(1535f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(7, LoopType.Yoyo);
	}

	// Token: 0x06006454 RID: 25684 RVA: 0x001E784C File Offset: 0x001E5A4C
	private void HLIAEEMGBHN()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1375f, 1877f, false));
		sequence.Join(this.target.DORotate(new Vector3(535f, 1698f, 1764f), 506f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(1564f, 925f));
		sequence.Insert(710f, this.target.DOMoveX(739f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(1, LoopType.Yoyo);
	}

	// Token: 0x06006455 RID: 25685 RVA: 0x001E78F8 File Offset: 0x001E5AF8
	private void HMPGIFBJFIK()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1795f, 1170f, true));
		sequence.Join(this.target.DORotate(new Vector3(1070f, 1007f, 1144f), 164f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(975f, 1086f));
		sequence.Insert(1190f, this.target.DOMoveX(1943f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(1, LoopType.Restart);
	}

	// Token: 0x06006456 RID: 25686 RVA: 0x001E79A4 File Offset: 0x001E5BA4
	private void NCNPAKFAFOE()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(116f, 308f, true));
		sequence.Join(this.target.DORotate(new Vector3(1087f, 1927f, 504f), 962f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1442f, 355f));
		sequence.Insert(122f, this.target.DOMoveX(646f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(6, LoopType.Restart);
	}

	// Token: 0x06006457 RID: 25687 RVA: 0x001E7A50 File Offset: 0x001E5C50
	private void KDMKDEKCELE()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1658f, 1911f, false));
		sequence.Join(this.target.DORotate(new Vector3(1978f, 991f, 922f), 1263f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(1690f, 1643f));
		sequence.Insert(794f, this.target.DOMoveX(268f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Yoyo);
	}

	// Token: 0x06006458 RID: 25688 RVA: 0x001E7AFC File Offset: 0x001E5CFC
	private void EPEGAEGDJAM()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(886f, 525f, false));
		sequence.Join(this.target.DORotate(new Vector3(775f, 1428f, 537f), 568f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1885f, 1920f));
		sequence.Insert(1653f, this.target.DOMoveX(1155f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(3, LoopType.Restart);
	}

	// Token: 0x06006459 RID: 25689 RVA: 0x001E7BA8 File Offset: 0x001E5DA8
	private void PAKPHKPDKGE()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1151f, 609f, false));
		sequence.Join(this.target.DORotate(new Vector3(508f, 290f, 1277f), 745f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(1209f, 49f));
		sequence.Insert(827f, this.target.DOMoveX(1942f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(3, LoopType.Restart);
	}

	// Token: 0x0600645A RID: 25690 RVA: 0x001E7C54 File Offset: 0x001E5E54
	private void NBGIMIDICKE()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(246f, 1478f, false));
		sequence.Join(this.target.DORotate(new Vector3(313f, 1627f, 832f), 124f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(376f, 1115f));
		sequence.Insert(1143f, this.target.DOMoveX(618f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Restart);
	}

	// Token: 0x0600645B RID: 25691 RVA: 0x001E7D00 File Offset: 0x001E5F00
	private void CGDMLHLJIDK()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1959f, 169f, true));
		sequence.Join(this.target.DORotate(new Vector3(906f, 1031f, 301f), 1579f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(878f, 491f));
		sequence.Insert(516f, this.target.DOMoveX(83f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(0, LoopType.Yoyo);
	}

	// Token: 0x0600645C RID: 25692 RVA: 0x001E7DAC File Offset: 0x001E5FAC
	private void DAHFFNNIGML()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(588f, 489f, true));
		sequence.Join(this.target.DORotate(new Vector3(1679f, 50f, 225f), 498f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(348f, 1506f));
		sequence.Insert(516f, this.target.DOMoveX(1588f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(1, LoopType.Restart);
	}

	// Token: 0x0600645D RID: 25693 RVA: 0x001E7E58 File Offset: 0x001E6058
	private void KLILJHJNICK()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1406f, 1265f, false));
		sequence.Join(this.target.DORotate(new Vector3(793f, 425f, 370f), 1529f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1911f, 1984f));
		sequence.Insert(1499f, this.target.DOMoveX(1747f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Yoyo);
	}

	// Token: 0x0600645E RID: 25694 RVA: 0x001E7F04 File Offset: 0x001E6104
	private void DIPDEHOOBPG()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1262f, 1159f, false));
		sequence.Join(this.target.DORotate(new Vector3(1843f, 612f, 1778f), 1724f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(510f, 1536f));
		sequence.Insert(608f, this.target.DOMoveX(1548f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(1, LoopType.Yoyo);
	}

	// Token: 0x0600645F RID: 25695 RVA: 0x001E7FB0 File Offset: 0x001E61B0
	private void DLBODOFAJGM()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(926f, 787f, true));
		sequence.Join(this.target.DORotate(new Vector3(389f, 1446f, 1069f), 1213f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1038f, 475f));
		sequence.Insert(574f, this.target.DOMoveX(328f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(4, LoopType.Restart);
	}

	// Token: 0x06006460 RID: 25696 RVA: 0x001E805C File Offset: 0x001E625C
	private void DKOPKPBLDHH()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(461f, 373f, true));
		sequence.Join(this.target.DORotate(new Vector3(1025f, 831f, 51f), 28f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(381f, 793f));
		sequence.Insert(1077f, this.target.DOMoveX(164f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(5, LoopType.Yoyo);
	}

	// Token: 0x06006461 RID: 25697 RVA: 0x001E8108 File Offset: 0x001E6308
	private void AGEJKLMJGDO()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(873f, 1381f, true));
		sequence.Join(this.target.DORotate(new Vector3(1836f, 1168f, 296f), 1467f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(1824f, 513f));
		sequence.Insert(140f, this.target.DOMoveX(61f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(0, LoopType.Restart);
	}

	// Token: 0x06006462 RID: 25698 RVA: 0x001E81B4 File Offset: 0x001E63B4
	private void KMCPMOGKDEH()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(548f, 1823f, false));
		sequence.Join(this.target.DORotate(new Vector3(642f, 639f, 1287f), 1147f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(953f, 1476f));
		sequence.Insert(1493f, this.target.DOMoveX(1212f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(4, LoopType.Restart);
	}

	// Token: 0x06006463 RID: 25699 RVA: 0x001E8260 File Offset: 0x001E6460
	private void BEBNOKFLJPH()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(319f, 1770f, false));
		sequence.Join(this.target.DORotate(new Vector3(537f, 418f, 633f), 765f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1933f, 1263f));
		sequence.Insert(1577f, this.target.DOMoveX(890f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(2, LoopType.Yoyo);
	}

	// Token: 0x06006464 RID: 25700 RVA: 0x001E830C File Offset: 0x001E650C
	private void IHLMNAGPKDA()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1066f, 1952f, false));
		sequence.Join(this.target.DORotate(new Vector3(689f, 1045f, 993f), 1060f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(47f, 673f));
		sequence.Insert(731f, this.target.DOMoveX(1467f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(0, LoopType.Yoyo);
	}

	// Token: 0x06006465 RID: 25701 RVA: 0x001E83B8 File Offset: 0x001E65B8
	private void JKFDDNMPOJH()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(222f, 840f, false));
		sequence.Join(this.target.DORotate(new Vector3(1142f, 1389f, 313f), 379f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(635f, 1065f));
		sequence.Insert(57f, this.target.DOMoveX(802f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(6, LoopType.Yoyo);
	}

	// Token: 0x06006466 RID: 25702 RVA: 0x001E8464 File Offset: 0x001E6664
	private void KDMANOEMOCA()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1443f, 55f, true));
		sequence.Join(this.target.DORotate(new Vector3(1521f, 1778f, 186f), 130f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(672f, 1935f));
		sequence.Insert(733f, this.target.DOMoveX(344f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Restart);
	}

	// Token: 0x06006467 RID: 25703 RVA: 0x001E8510 File Offset: 0x001E6710
	private void FEHCNJLLJMP()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1669f, 965f, true));
		sequence.Join(this.target.DORotate(new Vector3(0f, 1773f, 1199f), 1707f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1138f, 1269f));
		sequence.Insert(1916f, this.target.DOMoveX(1887f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(7, LoopType.Restart);
	}

	// Token: 0x06006468 RID: 25704 RVA: 0x001E85BC File Offset: 0x001E67BC
	private void IMCKJCHKMKB()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(186f, 1477f, false));
		sequence.Join(this.target.DORotate(new Vector3(879f, 369f, 1420f), 423f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1618f, 1256f));
		sequence.Insert(1256f, this.target.DOMoveX(622f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(5, LoopType.Restart);
	}

	// Token: 0x06006469 RID: 25705 RVA: 0x001E8668 File Offset: 0x001E6868
	private void CCLNNLCOPBL()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(344f, 1825f, false));
		sequence.Join(this.target.DORotate(new Vector3(650f, 95f, 783f), 1244f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(703f, 631f));
		sequence.Insert(525f, this.target.DOMoveX(487f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(4, LoopType.Yoyo);
	}

	// Token: 0x0600646B RID: 25707 RVA: 0x001E8714 File Offset: 0x001E6914
	private void CNGAJDBOCLJ()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1264f, 1025f, false));
		sequence.Join(this.target.DORotate(new Vector3(1789f, 1603f, 606f), 1902f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(1147f, 15f));
		sequence.Insert(1342f, this.target.DOMoveX(113f, sequence.Duration(true), false).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Restart);
	}

	// Token: 0x0600646C RID: 25708 RVA: 0x001E87C0 File Offset: 0x001E69C0
	private void DNNFHBOOPIN()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1087f, 1300f, false));
		sequence.Join(this.target.DORotate(new Vector3(1796f, 160f, 1052f), 733f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(304f, 200f));
		sequence.Insert(636f, this.target.DOMoveX(113f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(8, LoopType.Restart);
	}

	// Token: 0x0600646D RID: 25709 RVA: 0x001E886C File Offset: 0x001E6A6C
	private void NNCCPEBIAKH()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1892f, 653f, false));
		sequence.Join(this.target.DORotate(new Vector3(1121f, 1234f, 71f), 1373f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(468f, 18f));
		sequence.Insert(281f, this.target.DOMoveX(1711f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(4, LoopType.Restart);
	}

	// Token: 0x0600646E RID: 25710 RVA: 0x001E8918 File Offset: 0x001E6B18
	private void MMOKKAPFGAK()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1965f, 750f, true));
		sequence.Join(this.target.DORotate(new Vector3(651f, 1156f, 747f), 923f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1162f, 1186f));
		sequence.Insert(1900f, this.target.DOMoveX(1367f, sequence.Duration(true), true).SetRelative<Tweener>());
		sequence.SetLoops(1, LoopType.Yoyo);
	}

	// Token: 0x0600646F RID: 25711 RVA: 0x001E89C4 File Offset: 0x001E6BC4
	private void MMMDPANNAIO()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(16f, 1270f, false));
		sequence.Join(this.target.DORotate(new Vector3(1269f, 1736f, 814f), 119f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(393f, 234f));
		sequence.Insert(1584f, this.target.DOMoveX(531f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(0, LoopType.Restart);
	}

	// Token: 0x06006470 RID: 25712 RVA: 0x001E8A70 File Offset: 0x001E6C70
	private void FIKFJDFELIP()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(469f, 48f, true));
		sequence.Join(this.target.DORotate(new Vector3(386f, 336f, 293f), 1259f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(1476f, 1685f));
		sequence.Insert(296f, this.target.DOMoveX(24f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(5, LoopType.Restart);
	}

	// Token: 0x06006471 RID: 25713 RVA: 0x001E8B1C File Offset: 0x001E6D1C
	private void EGEPLFGKGLI()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1387f, 1433f, false));
		sequence.Join(this.target.DORotate(new Vector3(431f, 1512f, 492f), 1875f, RotateMode.FastBeyond360));
		sequence.Append(this.target.DOScaleY(866f, 348f));
		sequence.Insert(1913f, this.target.DOMoveX(1106f, sequence.Duration(false), false).SetRelative<Tweener>());
		sequence.SetLoops(1, LoopType.Restart);
	}

	// Token: 0x06006472 RID: 25714 RVA: 0x001E8BC8 File Offset: 0x001E6DC8
	private void NPLCENPNJBM()
	{
		Sequence sequence = DOTween.Sequence();
		sequence.Append(this.target.DOMoveY(1459f, 1142f, true));
		sequence.Join(this.target.DORotate(new Vector3(1402f, 1832f, 98f), 1913f, RotateMode.Fast));
		sequence.Append(this.target.DOScaleY(1292f, 1952f));
		sequence.Insert(757f, this.target.DOMoveX(1790f, sequence.Duration(false), true).SetRelative<Tweener>());
		sequence.SetLoops(4, LoopType.Yoyo);
	}

	// Token: 0x04000A24 RID: 2596
	public Transform target;
}
